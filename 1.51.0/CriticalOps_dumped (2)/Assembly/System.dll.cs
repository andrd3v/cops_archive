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

	// RVA: 0xF23FA0
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0xF2434C
	private static void EnsureInitialized() { }

	// RVA: 0xF244D4
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xF24534
	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags) { }

	// RVA: 0xF24848
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xF2484C
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xF24ABC
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xF24AC0
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xF24CA4
	public void .ctor() { }

	// RVA: 0xF24CAC
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

	// RVA: 0xF24D2C
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0xF24D8C
	internal static void Initialize() { }

	// RVA: 0xF24FB4
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	// RVA: 0xF24FBC
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0xF24FC4
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xF24EF4
	private void .ctor() { }

	// RVA: 0xF25030
	private static void .cctor() { }

}

// Namespace: Mono
internal static class X509Pal
{
	// Methods

	// RVA: 0xF250B0
	public static X509PalImpl get_Instance() { }

}

// Namespace: Mono
internal class X509PalImplMono
{
	// Methods

	// RVA: 0xF251D4
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0xF251D8
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xF25258
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xF242C4
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

	// RVA: 0xF25268
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xF253AC
	protected static Byte[] ConvertData(Byte[] data) { }

	// RVA: 0xF24694
	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	// RVA: 0xF24A3C
	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xF254CC
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0xF254D4
	public X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0xF25260
	protected void .ctor() { }

	// RVA: 0xF2592C
	private static void .cctor() { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xF259D0
	public void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper
{
	// Methods

	// RVA: 0xF259D8
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xF25B94
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug
{
	// Methods

	// RVA: 0xF25E2C
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert) { }

	// RVA: 0xF25ECC
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
	public const unitytls_error_code UNITYTLS_DER_PARSE_ERROR = 11;
	public const unitytls_error_code UNITYTLS_KEY_PARSE_ERROR = 12;
	public const unitytls_error_code UNITYTLS_SSL_ERROR = 13;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const unitytls_error_code UNITYTLS_USER_WOULD_BLOCK_READ = 1048578;
	public const unitytls_error_code UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579;
	public const unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048580;
	public const unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048581;
	public const unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048582;
	public const unitytls_error_code UNITYTLS_SSL_NEEDS_VERIFY = 1048583;
	public const unitytls_error_code UNITYTLS_HANDSHAKE_STEP = 1048584;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;
}

// Namespace: 
public enum unitytls_log_level
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_log_level UNITYTLS_LOGLEVEL_MIN = 0;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_FATAL = 0;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_ERROR = 1;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_WARN = 2;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_INFO = 3;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_DEBUG = 4;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_TRACE = 5;
	public const unitytls_log_level UNITYTLS_LOGLEVEL_MAX = 5;
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
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_NOT_TRUSTED = 16;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_EXPIRED = 32;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_MISSING = 64;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_SKIP_VERIFY = 128;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_OTHER = 256;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_FUTURE = 512;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_FUTURE = 1024;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_KEY_USAGE = 2048;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_EXT_KEY_USAGE = 4096;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_NS_CERT_TYPE = 8192;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_MD = 16384;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_PK = 32768;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_KEY = 65536;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_MD = 131072;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_PK = 262144;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_KEY = 524288;
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

	// RVA: 0xF2601C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF260D8
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

	// RVA: 0xF260EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF261A8
	public virtual IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback
{
	// Methods

	// RVA: 0xF261BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26278
	public virtual IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback
{
	// Methods

	// RVA: 0xF2628C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26348
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback
{
	// Methods

	// RVA: 0xF2635C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26418
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback
{
	// Methods

	// RVA: 0xF26438
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF264F4
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

	// RVA: 0xF26510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF265B0
	public virtual unitytls_errorstate Invoke() { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t
{
	// Methods

	// RVA: 0xF265C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26680
	public virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t
{
	// Methods

	// RVA: 0xF26694
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26750
	public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t
{
	// Methods

	// RVA: 0xF26764
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26820
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t
{
	// Methods

	// RVA: 0xF26834
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF268F0
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_free_t
{
	// Methods

	// RVA: 0xF26904
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF269B8
	public virtual void Invoke(unitytls_key* key) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t
{
	// Methods

	// RVA: 0xF269CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26A70
	public virtual IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t
{
	// Methods

	// RVA: 0xF26A84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26B40
	public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t
{
	// Methods

	// RVA: 0xF26B54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26BF8
	public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t
{
	// Methods

	// RVA: 0xF26C0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26CC0
	public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t
{
	// Methods

	// RVA: 0xF26CD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26D90
	public virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t
{
	// Methods

	// RVA: 0xF26DA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26E60
	public virtual void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t
{
	// Methods

	// RVA: 0xF26E74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26F28
	public virtual void Invoke(unitytls_x509list* list) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t
{
	// Methods

	// RVA: 0xF26F3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF26FE0
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t
{
	// Methods

	// RVA: 0xF26FF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27098
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t
{
	// Methods

	// RVA: 0xF270B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27154
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t
{
	// Methods

	// RVA: 0xF27194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27238
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t
{
	// Methods

	// RVA: 0xF27278
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27334
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t
{
	// Methods

	// RVA: 0xF27348
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27404
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t
{
	// Methods

	// RVA: 0xF27418
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF274D4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t
{
	// Methods

	// RVA: 0xF274E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF275A4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t
{
	// Methods

	// RVA: 0xF275B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27674
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t
{
	// Methods

	// RVA: 0xF27688
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27744
	public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t
{
	// Methods

	// RVA: 0xF27758
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27814
	public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t
{
	// Methods

	// RVA: 0xF27828
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF278E4
	public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t
{
	// Methods

	// RVA: 0xF278F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF279B4
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t
{
	// Methods

	// RVA: 0xF279C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27A84
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t
{
	// Methods

	// RVA: 0xF27A98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27B54
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t
{
	// Methods

	// RVA: 0xF27B68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27C1C
	public virtual void Invoke(unitytls_tlsctx* ctx) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t
{
	// Methods

	// RVA: 0xF27C30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27CEC
	public virtual void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_result_to_string_t
{
	// Methods

	// RVA: 0xF27D00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27DA4
	public virtual Char* Invoke(unitytls_x509verify_result v) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_level_t
{
	// Methods

	// RVA: 0xF27DB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF27E74
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_log_level level) { }

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
	public unitytls_x509verify_result_to_string_t unitytls_x509verify_result_to_string; // 0x118
	public unitytls_tlsctx_set_trace_level_t unitytls_tlsctx_set_trace_level; // 0x120

	// Methods

	// RVA: 0xF26508
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal static class UnityTls
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Methods

	// RVA: 0xF25FFC
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0xF26000
	public static bool get_IsSupported() { }

	// RVA: 0xF25D48
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

	// RVA: 0xF282E0
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xF28E14
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, unitytls_x509list* nativeCertChain, unitytls_key* nativeKey) { }

	// RVA: 0xF2918C
	public override bool get_IsAuthenticated() { }

	// RVA: 0xF29194
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xF2919C
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0xF291A4
	public override void Flush() { }

	// RVA: 0xF291A8
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF29390
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF29558
	public override void Renegotiate() { }

	// RVA: 0xF29598
	public override bool PendingRenegotiation() { }

	// RVA: 0xF295A0
	public override void Shutdown() { }

	// RVA: 0xF296C4
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF297CC
	public override void StartHandshake() { }

	// RVA: 0xF299AC
	public override bool ProcessHandshake() { }

	// RVA: 0xF29BA8
	public override void FinishHandshake() { }

	// RVA: 0xF27E88
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xF29D00
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xF27FA4
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xF2A170
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xF280C0
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xF2A5E0
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xF281C4
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xF2AACC
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions
{
	// Methods

	// RVA: 0xF28DB0
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xF28DE0
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xF29CE0
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xF25FA4
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xF2B36C
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

	// RVA: 0xF2B39C
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider
{
	// Methods

	// RVA: 0xF2B43C
	public override string get_Name() { }

	// RVA: 0xF2B480
	public override Guid get_ID() { }

	// RVA: 0xF2B4FC
	public override bool get_SupportsSslStream() { }

	// RVA: 0xF2B504
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xF2B50C
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xF2B514
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xF2B51C
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xF2B524
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xF2B3D4
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xF2B68C
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xF2C2D0
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream
{
	// Methods

	// RVA: 0xF2B5F4
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xF2C4E0
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

	// RVA: 0xF2AA28
	internal void .ctor(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder) { }

	// RVA: 0xF2C1F4
	internal void .ctor(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder) { }

	// RVA: 0xF2C54C
	public override bool get_IsValid() { }

	// RVA: 0xF2C580
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0xF2C588
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0xF2C898
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0xF2C99C
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xF2C9A4
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0xF2C9AC
	public override void Reset() { }

	// RVA: 0xF2CA38
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

	// RVA: 0xF2CA70
	public int get_EndOffset() { }

	// RVA: 0xF2CA7C
	public int get_Remaining() { }

	// RVA: 0xF2CAA8
	public void .ctor(Byte[] buffer, int offset, int size) { }

	// RVA: 0xF2CBC4
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0xF2CC60
	public void .ctor(int size) { }

	// RVA: 0xF2CCD4
	public void Reset() { }

	// RVA: 0xF2CD48
	public void MakeRoom(int size) { }

	// RVA: 0xF2CE20
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

	// RVA: 0xF2CE84
	public int get_UserResult() { }

	// RVA: 0xF2CE8C
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0xF2CE94
	public void .ctor(int result) { }

	// RVA: 0xF2CEC0
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

	// RVA: 0xF2D4AC
	private void MoveNext() { }

	// RVA: 0xF2D8D8
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

	// RVA: 0xF2D958
	private void MoveNext() { }

	// RVA: 0xF2E578
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

	// RVA: 0xF2E5E4
	private void MoveNext() { }

	// RVA: 0xF2ED10
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

	// RVA: 0xF2CEF4
	public MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xF2CEFC
	public bool get_RunSynchronously() { }

	// RVA: 0xF2CF04
	public string get_Name() { }

	// RVA: 0xF2CF2C
	public int get_UserResult() { }

	// RVA: 0xF2CF34
	protected void set_UserResult(int value) { }

	// RVA: 0xF2CF3C
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xF2CFDC
	internal void RequestRead(int size) { }

	// RVA: 0xF2D0B4
	internal void RequestWrite() { }

	// RVA: 0xF2D0C0
	internal System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xF2D1F4
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xF2D304
	private System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xF2D43C
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest
{
	// Methods

	// RVA: 0xF2ED90
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xF2EE30
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private int <CurrentSize>k__BackingField; // 0x40

	// Methods

	// RVA: 0xF2F23C
	protected BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xF2F244
	protected int get_CurrentSize() { }

	// RVA: 0xF2F24C
	protected void set_CurrentSize(int value) { }

	// RVA: 0xF2F254
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xF2F360
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest
{
	// Methods

	// RVA: 0xF2F3D4
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xF2F3D8
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest
{
	// Methods

	// RVA: 0xF2F5C0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xF2F5C4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0xF30080
	public void .ctor() { }

	// RVA: 0xF30A80
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

	// RVA: 0xF2F7D0
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xF2FCC0
	internal static ChainValidationHelper Create(MobileTlsProvider provider, MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xF2F8BC
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0xF2FE84
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0xF30088
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xF300D4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xF300DC
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, X509Certificate clientCertificate) { }

	// RVA: 0xF30134
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xF3030C
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xF303F8
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xF309A0
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

	// RVA: 0xF325F8
	private void MoveNext() { }

	// RVA: 0xF330A8
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

	// RVA: 0xF33114
	private void MoveNext() { }

	// RVA: 0xF339C0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0xF33A40
	public void .ctor() { }

	// RVA: 0xF33A48
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

	// RVA: 0xF33A94
	private void MoveNext() { }

	// RVA: 0xF33F90
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

	// RVA: 0xF34010
	private void MoveNext() { }

	// RVA: 0xF3434C
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

	// RVA: 0xF2C2E0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xF30BE4
	public SslStream get_SslStream() { }

	// RVA: 0xF30BEC
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xF30BF4
	public MobileTlsProvider get_Provider() { }

	// RVA: 0xF30BFC
	internal string get_TargetHost() { }

	// RVA: 0xF30C04
	private void set_TargetHost(string value) { }

	// RVA: 0xF30C0C
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck) { }

	// RVA: 0xF2E2AC
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0xF30CD8
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0xF30E70
	internal static Exception GetInternalError() { }

	// RVA: 0xF30EC4
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0xF2D894
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xF30F18
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xF313E4
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xF312B4
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	// RVA: 0xF31560
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF317C0
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF31898
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xF31938
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xF31660
	private System.Threading.Tasks.Task<System.Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xF2A4C4
	internal int InternalRead(Byte[] buffer, int offset, int size, bool outWantMore) { }

	// RVA: 0xF319D8
	private System.ValueTuple<System.Int32,System.Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xF29F90
	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0xF31B58
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xF2EBC0
	internal System.Threading.Tasks.Task<System.Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xF2E45C
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0xF2EE50
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0xF2F454
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xF2F660
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xF31D10
	public override bool get_IsAuthenticated() { }

	// RVA: 0xF31E14
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF320E0
	public override void Flush() { }

	// RVA: 0xF32108
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0xF321F0
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xF3231C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xF3235C
	public override bool get_CanRead() { }

	// RVA: 0xF323AC
	public override bool get_CanTimeout() { }

	// RVA: 0xF323D0
	public override bool get_CanWrite() { }

	// RVA: 0xF32440
	public override bool get_CanSeek() { }

	// RVA: 0xF32448
	public override Int64 get_Length() { }

	// RVA: 0xF3246C
	public override Int64 get_Position() { }

	// RVA: 0xF32490
	public override void set_Position(Int64 value) { }

	// RVA: 0xF324D0
	public override int get_ReadTimeout() { }

	// RVA: 0xF324F8
	public override void set_ReadTimeout(int value) { }

	// RVA: 0xF32520
	public override int get_WriteTimeout() { }

	// RVA: 0xF32548
	public override void set_WriteTimeout(int value) { }

	// RVA: 0xF32570
	private static void .cctor() { }

	// RVA: 0xF325C0
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

	// RVA: 0xF28C04
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xF343B8
	internal MonoSslAuthenticationOptions get_Options() { }

	// RVA: 0xF343C0
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xF296A4
	public MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0xF343C8
	public bool get_IsServer() { }

	// RVA: 0xF343D0
	internal string get_TargetHost() { }

	// RVA: 0xF343D8
	protected string get_ServerName() { }

	// RVA: 0xF343E0
	protected bool get_AskForClientCertificate() { }

	// RVA: 0xF343E8
	protected SslProtocols get_EnabledProtocols() { }

	// RVA: 0xF343F0
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xF343F8
	protected void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }

	// RVA: -1
	public abstract void StartHandshake() { }

	// RVA: -1
	public abstract bool ProcessHandshake() { }

	// RVA: -1
	public abstract void FinishHandshake() { }

	// RVA: 0xF3453C
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: 0xF34544
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

	// RVA: 0xF29B50
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0xF3454C
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0xF2ADFC
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1
	public abstract void Renegotiate() { }

	// RVA: 0xF3204C
	public void Dispose() { }

	// RVA: 0xF347E0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xF347E4
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

	// RVA: 0xF2C2D8
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

	// RVA: 0xF34884
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0xF3488C
	protected void .ctor() { }

}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions
{
	// Fields
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0xF34894
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0xF3489C
	public override bool get_ServerMode() { }

	// RVA: 0xF3123C
	public void .ctor() { }

	// RVA: 0xF348A4
	public override bool get_AllowRenegotiation() { }

	// RVA: 0xF348C4
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0xF348E4
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0xF34904
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0xF34924
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0xF34944
	public override string get_TargetHost() { }

	// RVA: 0xF34964
	public override void set_TargetHost(string value) { }

	// RVA: 0xF34984
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0xF349C4
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xF349E4
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0xF34A04
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

	// RVA: 0xF2FD60
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0xF34A44
	internal static void InitializeInternal() { }

	// RVA: 0xF35274
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0xF34E3C
	private static void InitializeProviderRegistration() { }

	// RVA: 0xF3590C
	private static void PopulateUnityProviders() { }

	// RVA: 0xF35A5C
	private static void PopulateProviders() { }

	// RVA: 0xF35C78
	internal static bool IsBtlsSupported() { }

	// RVA: 0xF3505C
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xF35D54
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0xF35DBC
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

	// RVA: 0xF36418
	private void MoveNext() { }

	// RVA: 0xF36C30
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

	// RVA: 0xF35F00
	internal HttpWebRequest get_Request() { }

	// RVA: 0xF35F08
	internal WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xF35F10
	internal bool get_CertificateValidationFailed() { }

	// RVA: 0xF35F18
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0xF35F20
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xF361D8
	internal System.Threading.Tasks.Task<System.IO.Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0xF36330
	public void Dispose() { }

	// RVA: 0xF36334
	private void CloseSslStream() { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper
{
	// Methods

	// RVA: 0xF36CB0
	internal static object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xF36D60
	private static void .cctor() { }

	// RVA: 0xF30A78
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xF36DB4
	public void .ctor() { }

	// RVA: 0xF36DC4
	internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xF36DBC
	public void .ctor() { }

	// RVA: 0xF36DEC
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers
{
	// Methods

	// RVA: 0xF360F4
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	// RVA: 0xF2FF9C
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: Mono.Http
internal class NtlmSession
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xF36E14
	public void .ctor() { }

	// RVA: 0xF36E1C
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

	// RVA: 0xF37744
	private static void .cctor() { }

	// RVA: 0xF377B0
	public void .ctor() { }

	// RVA: 0xF377B8
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Mono.Http
internal class NtlmClient
{
	// Fields
	private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache; // 0x0

	// Methods

	// RVA: 0xF372CC
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xF37654
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xF3765C
	public string get_AuthenticationType() { }

	// RVA: 0xF376A0
	public void .ctor() { }

	// RVA: 0xF376A8
	private static void .cctor() { }

}

// Namespace: 
protected internal class BoringBioHandle
{
	// Methods

	// RVA: 0xF379B8
	public void .ctor(IntPtr handle) { }

	// RVA: 0xF379CC
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBio
{
	// Methods

	// RVA: 0xF37810
	internal void .ctor(BoringBioHandle handle) { }

	// RVA: 0xF37878
	protected internal BoringBioHandle get_Handle() { }

	// RVA: 0xF37920
	private static extern void mono_btls_bio_free(IntPtr handle) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory
{
	// Methods

	// RVA: 0xF37A64
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0xF37AE8
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, IntPtr data) { }

	// RVA: 0xF37B78
	public void .ctor() { }

	// RVA: 0xF37C58
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

	// RVA: 0xF38B8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF39308
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength, int wantMore) { }

}

// Namespace: 
private sealed class BioWriteFunc
{
	// Methods

	// RVA: 0xF38C30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF3931C
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

}

// Namespace: 
private sealed class BioControlFunc
{
	// Methods

	// RVA: 0xF38CD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF39330
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

	// RVA: 0xF3866C
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0xF38B08
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0xF38D78
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0xF38E28
	private Int64 Control(ControlCommand command, Int64 arg) { }

	// RVA: 0xF38F20
	private int OnRead(IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xF3810C
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xF390BC
	private int OnWrite(IntPtr data, int dataLength) { }

	// RVA: 0xF382E8
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	// RVA: 0xF384AC
	private static Int64 Control(IntPtr instance, ControlCommand command, Int64 arg) { }

	// RVA: 0xF391F4
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

	// RVA: 0xF39344
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xF39390
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0xF395D4
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0xF398E0
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0xF39E04
	private int ServerNameCallback() { }

	// RVA: 0xF39E6C
	public override void StartHandshake() { }

	// RVA: 0xF39B14
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0xF3A414
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0xF3ACC0
	public override bool ProcessHandshake() { }

	// RVA: 0xF3AECC
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0xF3B100
	public override void FinishHandshake() { }

	// RVA: 0xF39FA8
	private void InitializeConnection() { }

	// RVA: 0xF399B8
	private void GetPeerCertificate() { }

	// RVA: 0xF3B128
	private void InitializeSession() { }

	// RVA: 0xF3BA38
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0xF3BAA0
	public override void Flush() { }

	// RVA: 0xF3BAE0
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0xF3BDF0
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xF3C0B8
	public override void Renegotiate() { }

	// RVA: 0xF3C0F8
	public override void Shutdown() { }

	// RVA: 0xF3C14C
	public override bool PendingRenegotiation() { }

	// RVA: 0x35267E8
	private void Dispose(T disposable) { }

	// RVA: 0xF3C16C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF3C2F8
	private int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, bool wantMore) { }

	// RVA: 0xF3C314
	private bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xF3C330
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0xF3C334
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xF3C338
	public override bool get_IsAuthenticated() { }

	// RVA: 0xF3C340
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xF3C348
	public override X509Certificate2 get_RemoteCertificate() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsError
{
	// Methods

	// RVA: 0xF3C350
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0xF3C3D4
	private static extern int mono_btls_error_get_error_line(IntPtr file, int line) { }

	// RVA: 0xF3C464
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0xF3C4FC
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0xF3AE48
	public static void ClearError() { }

	// RVA: 0xF3AA60
	public static string GetErrorString(int error) { }

	// RVA: 0xF3A7EC
	public static int GetError(string file, int line) { }

	// RVA: 0xF3A9C8
	public static int GetErrorReason(int error) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsException
{
	// Methods

	// RVA: 0xF3C594
	public void .ctor() { }

	// RVA: 0xF3A914
	public void .ctor(MonoBtlsSslError error) { }

	// RVA: 0xF3AC54
	public void .ctor(string message) { }

	// RVA: 0xF3C61C
	public void .ctor(string format, object[] args) { }

}

// Namespace: 
internal class BoringKeyHandle
{
	// Methods

	// RVA: 0xF3D000
	internal void .ctor(IntPtr handle) { }

	// RVA: 0xF3D240
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsKey
{
	// Methods

	// RVA: 0xF3C6A8
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0xF3C72C
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0xF3C7C4
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0xF3C85C
	private static extern int mono_btls_key_get_bytes(IntPtr handle, IntPtr data, int size, int include_private_bits) { }

	// RVA: 0xF3C904
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	// RVA: 0xF3C9A4
	internal BoringKeyHandle get_Handle() { }

	// RVA: 0xF3CA28
	internal void .ctor(BoringKeyHandle handle) { }

	// RVA: 0xF3CA5C
	public Byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0xF3CDB0
	public MonoBtlsKey Copy() { }

	// RVA: 0xF3D00C
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

}

// Namespace: 
protected internal abstract class MonoBtlsHandle
{
	// Methods

	// RVA: 0xF379C4
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0xF3D660
	public override bool get_IsInvalid() { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject
{
	// Fields
	private MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Methods

	// RVA: 0xF37844
	internal void .ctor(MonoBtlsHandle handle) { }

	// RVA: 0xF378FC
	internal MonoBtlsHandle get_Handle() { }

	// RVA: 0xF3D2C4
	public bool get_IsValid() { }

	// RVA: 0xF3CF80
	protected void CheckThrow() { }

	// RVA: 0xF39078
	protected Exception SetException(Exception ex) { }

	// RVA: 0xF37F8C
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0xF3CD0C
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0xF3AF20
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0xF3D2EC
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0xF3CD18
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0xF3D384
	protected virtual void Close() { }

	// RVA: 0xF3D388
	protected void Dispose(bool disposing) { }

	// RVA: 0xF3D514
	public void Dispose() { }

	// RVA: 0xF3D5B4
	protected override void Finalize() { }

}

// Namespace: 
internal class BoringPkcs12Handle
{
	// Methods

	// RVA: 0xF3DC38
	public void .ctor(IntPtr handle) { }

	// RVA: 0xF3E360
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Methods

	// RVA: 0xF3D670
	internal BoringPkcs12Handle get_Handle() { }

	// RVA: 0xF3D6F4
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0xF3D78C
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0xF3D810
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0xF3D8A8
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0xF3D938
	private static extern int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	// RVA: 0xF3DA28
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0xF3DAC0
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0xF3DB58
	internal void .ctor() { }

	// RVA: 0xF3DC44
	public int get_Count() { }

	// RVA: 0xF3DD4C
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0xF3DF3C
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0xF3E054
	public bool get_HasPrivateKey() { }

	// RVA: 0xF3E14C
	public MonoBtlsKey GetPrivateKey() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsProvider
{
	// Methods

	// RVA: 0xF3E3E4
	public override Guid get_ID() { }

	// RVA: 0xF3E460
	public override string get_Name() { }

	// RVA: 0xF35C7C
	internal void .ctor() { }

	// RVA: 0xF3E4A4
	public override bool get_SupportsSslStream() { }

	// RVA: 0xF3E4AC
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xF3E4B4
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xF3E4BC
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xF3E4C4
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xF3E4CC
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xF3E564
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0xF3E78C
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0xF3E70C
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0xF3B628
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0xF3E8A4
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xF3F43C
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0xF3EECC
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, SslPolicyErrors errors, int status11) { }

	// RVA: 0xF3F724
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0xF3B2D4
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xF3F99C
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0xF3FA2C
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0xF3FA88
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0xF3F960
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xF3B8BC
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0xF3F3A8
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0xF3FAE4
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0xF3EFB8
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsVerifyCallback
{
	// Methods

	// RVA: 0x12B8C40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B8D60
	public virtual int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsSelectCallback
{
	// Methods

	// RVA: 0x12B8D74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B8E28
	public virtual int Invoke(string[] acceptableIssuers) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsServerNameCallback
{
	// Methods

	// RVA: 0x12B8E3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B8EDC
	public virtual int Invoke() { }

}

// Namespace: 
internal class BoringSslHandle
{
	// Methods

	// RVA: 0x12BA020
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12BC2F4
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class PrintErrorsCallbackFunc
{
	// Methods

	// RVA: 0x12BA194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BC388
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

	// RVA: 0x12B90CC
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x12B9164
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x12B91FC
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x12B928C
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x12B931C
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x12B93AC
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x12B9444
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x12B94DC
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x12B9574
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x12B9608
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x12B96A0
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x12B9730
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x12B97C0
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x12B9858
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x12B98EC
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x12B997C
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x12B9A14
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x12B9AAC
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x12B9B44
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x12B9BD4
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x12B9C64
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x12B9CFC
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x12B9D8C
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x12B9E24
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x12BA02C
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x12BA238
	internal BoringSslHandle get_Handle() { }

	// RVA: 0x12BA2BC
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x12BA3EC
	private Exception ThrowError(string callerName) { }

	// RVA: 0x12BA760
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x12BA8A8
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12BAAC0
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x12BAC00
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12BAD94
	public MonoBtlsSslError Accept() { }

	// RVA: 0x12BAEA0
	public MonoBtlsSslError Connect() { }

	// RVA: 0x12BAFAC
	public MonoBtlsSslError Handshake() { }

	// RVA: 0x12B8EF0
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x12BA5D4
	public string GetErrors() { }

	// RVA: 0x12BB0B8
	public void PrintErrors() { }

	// RVA: 0x12BB238
	public MonoBtlsSslError Read(IntPtr data, int dataSize) { }

	// RVA: 0x12BB39C
	public MonoBtlsSslError Write(IntPtr data, int dataSize) { }

	// RVA: 0x12BB5A8
	public int GetVersion() { }

	// RVA: 0x12BB6B8
	public int GetCipher() { }

	// RVA: 0x12BB82C
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x12BB9E8
	public void SetServerName(string name) { }

	// RVA: 0x12BBC14
	public string GetServerName() { }

	// RVA: 0x12BBD84
	public void Shutdown() { }

	// RVA: 0x12BBEA0
	public void SetQuietShutdown() { }

	// RVA: 0x12BBF9C
	protected override void Close() { }

	// RVA: 0x12BC0F4
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x12BC1FC
	public bool RenegotiatePending() { }

}

// Namespace: 
internal class BoringSslCtxHandle
{
	// Methods

	// RVA: 0x12BD2F8
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12BF090
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class NativeVerifyFunc
{
	// Methods

	// RVA: 0x12BD748
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BF114
	public virtual int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

}

// Namespace: 
private sealed class NativeSelectFunc
{
	// Methods

	// RVA: 0x12BD7EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BF128
	public virtual int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

}

// Namespace: 
private sealed class NativeServerNameFunc
{
	// Methods

	// RVA: 0x12BD890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BF13C
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

	// RVA: 0x12B9F9C
	internal BoringSslCtxHandle get_Handle() { }

	// RVA: 0x12BCBC4
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x12BCC48
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x12BCCE0
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x12BCD70
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x12BCE08
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x12BCE98
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x12BCF28
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x12BCFB8
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x12BD060
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x12BD0F0
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x12BD198
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x12BD228
	public void .ctor() { }

	// RVA: 0x12BD304
	internal void .ctor(BoringSslCtxHandle handle) { }

	// RVA: 0x12BD964
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x12BD96C
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	// RVA: 0x12BC39C
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x12BC7FC
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x12BDA30
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x12BE0E8
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x12BE280
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x12BE39C
	public void SetMinVersion(int version) { }

	// RVA: 0x12BE4A4
	public void SetMaxVersion(int version) { }

	// RVA: 0x12BE5AC
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	// RVA: 0x12BE828
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x12BEA94
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x12BEF18
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	// RVA: 0x12BCA08
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x12BF034
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

	// RVA: 0x12BF150
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x12BF1EC
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils
{
	// Fields
	private static Byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x12BF25C
	public static bool Compare(Byte[] a, Byte[] b) { }

	// RVA: 0x12BF2D0
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x12BDFA0
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x12BFFE0
	private static void .cctor() { }

}

// Namespace: 
internal class BoringX509Handle
{
	// Methods

	// RVA: 0x12BB9D4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C12EC
	protected override bool ReleaseHandle() { }

	// RVA: 0x12C1370
	public IntPtr StealHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509
{
	// Methods

	// RVA: 0x12BAA3C
	internal BoringX509Handle get_Handle() { }

	// RVA: 0x12BB9E0
	internal void .ctor(BoringX509Handle handle) { }

	// RVA: 0x12C0084
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x12C011C
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x12C01B4
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x12C024C
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x12C02E4
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x12C0374
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x12C0408
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x12C0498
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x12C0650
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x12C08FC
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x12C0AFC
	public Int64 GetSubjectNameHash() { }

	// RVA: 0x12C0D54
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x12C1010
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x12C1174
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

}

// Namespace: 
internal class BoringX509ChainHandle
{
	// Methods

	// RVA: 0x12C1844
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C1E7C
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain
{
	// Methods

	// RVA: 0x12C1380
	internal BoringX509ChainHandle get_Handle() { }

	// RVA: 0x12C1404
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x12C1488
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x12C1520
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x12C15B0
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x12C1640
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x12C16D8
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x12C1770
	public void .ctor() { }

	// RVA: 0x12C1850
	internal void .ctor(BoringX509ChainHandle handle) { }

	// RVA: 0x12C1858
	public int get_Count() { }

	// RVA: 0x12C1960
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x12C1B58
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12C1CC4
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

	// RVA: 0x12C2478
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C3000
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

	// RVA: 0x12C1F00
	internal BoringX509LookupHandle get_Handle() { }

	// RVA: 0x12C1F84
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x12C2014
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12C20AC
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x12C213C
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x12C21D4
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x12C226C
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x12C2484
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x12C24E0
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x12C25E8
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12C2814
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x12C2BA8
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x12C2D94
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509LookupMonoHandle
{
	// Methods

	// RVA: 0x12C38D4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C3A68
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class BySubjectFunc
{
	// Methods

	// RVA: 0x12C38E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C3AEC
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

	// RVA: 0x12C2ACC
	internal BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x12C3448
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x12C34CC
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x12C3564
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x12C35FC
	internal void .ctor() { }

	// RVA: 0x12C2B50
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x12C3984
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12C3084
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, IntPtr x509_ptr) { }

	// RVA: 0x12C39A8
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

	// RVA: 0x12C3B00
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x12C3B44
	private void Initialize() { }

	// RVA: 0x12C3D2C
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12C3DE4
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

	// RVA: 0x12C0AC4
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x12C4490
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name
{
	// Methods

	// RVA: 0x12C3F34
	private static extern Int64 mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x12C3FCC
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x12C4064
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x12C40F4
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x12C419C
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, IntPtr data) { }

	// RVA: 0x12C4234
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, int tag, IntPtr str) { }

	// RVA: 0x12C42DC
	private static extern IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	// RVA: 0x12C4374
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x12C440C
	internal BoringX509NameHandle get_Handle() { }

	// RVA: 0x12C0AF4
	internal void .ctor(BoringX509NameHandle handle) { }

	// RVA: 0x12C0C4C
	public Int64 GetHash() { }

	// RVA: 0x12BFED8
	public int GetEntryCount() { }

	// RVA: 0x12BF694
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x12BFC3C
	public string GetEntryOid(int index) { }

	// RVA: 0x12BF7D4
	public Byte[] GetEntryOidData(int index) { }

	// RVA: 0x12BF9B8
	public string GetEntryValue(int index, int tag) { }

	// RVA: 0x12BDDC8
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

	// RVA: 0x12C487C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C4F1C
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store
{
	// Fields
	private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

	// Methods

	// RVA: 0x12C23F4
	internal BoringX509StoreHandle get_Handle() { }

	// RVA: 0x12C4530
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x12C45B4
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x12C464C
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x12C46DC
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x12C4774
	private static BoringX509StoreHandle Create_internal() { }

	// RVA: 0x12C4888
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	// RVA: 0x12C4998
	internal void .ctor() { }

	// RVA: 0x12BD934
	internal void .ctor(BoringSslCtxHandle ctx) { }

	// RVA: 0x12C2BC4
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12C49C4
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x12C4B70
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12C4BA8
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x12C4C84
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509StoreCtxHandle
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x12C56C8
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x12C6508
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx
{
	// Fields
	private System.Nullable<System.Int32> verifyResult; // 0x20

	// Methods

	// RVA: 0x12C4FA0
	internal BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x12C5024
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x12C50A8
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x12C5140
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, IntPtr error_string) { }

	// RVA: 0x12C51D0
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x12C5268
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x12C5300
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x12C5390
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x12C5428
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x12C54C0
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x12C5558
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x12C55F0
	internal void .ctor() { }

	// RVA: 0x12C56F8
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x12BD994
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x12C5818
	internal void .ctor(BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }

	// RVA: 0x12C5844
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x12C593C
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x12C5AFC
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x12C5CBC
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x12C5F00
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x12C60D0
	public int get_VerifyResult() { }

	// RVA: 0x12C61B8
	public int Verify() { }

	// RVA: 0x12C6344
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

	// RVA: 0x12C65A8
	private static void Initialize() { }

	// RVA: 0x12C6788
	private static void DoInitialize() { }

	// RVA: 0x12C6920
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

	// RVA: 0x12C6FB4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12C7920
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam
{
	// Methods

	// RVA: 0x12BEA10
	internal BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x12C6A6C
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x12C6B04
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x12C6B9C
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x12C6C34
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x12C6CCC
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, Int64 time) { }

	// RVA: 0x12C6D5C
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x12C6DF4
	internal void .ctor(BoringX509VerifyParamHandle handle) { }

	// RVA: 0x12C6DFC
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x12C6FC0
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x12C72A8
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x12C7008
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail) { }

	// RVA: 0x12C72F0
	public bool get_CanModify() { }

	// RVA: 0x12C73E8
	private void WantToModify() { }

	// RVA: 0x12C7450
	public void SetHost(string name) { }

	// RVA: 0x12C76DC
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

	// RVA: 0x12C79A4
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x12C79E8
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x12C7AA0
	internal void .ctor(Byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x12C7AEC
	internal void .ctor(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x12C85EC
	public override bool get_IsValid() { }

	// RVA: 0x12C8600
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x12C8628
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x12C8650
	public override X509CertificateImpl Clone() { }

	// RVA: 0x12C86C0
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x12C8700
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x12C8708
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12C874C
	public override bool get_HasPrivateKey() { }

	// RVA: 0x12C875C
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12C878C
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x12C88D0
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x12C8900
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x12C7EB4
	private void Import(Byte[] data) { }

	// RVA: 0x12C7F20
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	// RVA: 0x12C8518
	private void ImportAuthenticode(Byte[] data) { }

	// RVA: 0x12C8940
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

	// RVA: 0x12C8BC4
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x12C8C60
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x12C8F74
	public override bool get_IsValid() { }

	// RVA: 0x12C8F88
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x12C8FB0
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12C92D4
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12C92DC
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x12C93E0
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12C93E8
	public override void Reset() { }

	// RVA: 0x12C9498
	protected override void Dispose(bool disposing) { }

}

// Namespace: Mono.Btls
internal class X509PalImplBtls
{
	// Fields
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12C95F8
	public void .ctor(MonoTlsProvider provider) { }

	// RVA: 0x12C9714
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x12C971C
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0x12C9744
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x12C9764
	public override X509Certificate2Impl Import(X509Certificate cert) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Internal.Cryptography.OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x12CBEB4
	private static void .cctor() { }

	// RVA: 0x12CBF20
	public void .ctor() { }

	// RVA: 0x12CBF28
	internal string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

	// RVA: 0x12CBFF4
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

	// RVA: 0x12C9784
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12C9C94
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12C996C
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x12C9974
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12C9E80
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12CA1A8
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

	// RVA: 0x12CD9C0
	public void .ctor(int <>1__state) { }

	// RVA: 0x12CD9F8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x12CD9FC
	private bool MoveNext() { }

	// RVA: 0x12CDCD0
	private System.Collections.Generic.KeyValuePair<System.String,System.String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	// RVA: 0x12CDCDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12CDD1C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12CDD84
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x12CDE2C
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

	// RVA: 0x12CC0BC
	internal void .ctor(Byte[] rawData) { }

	// RVA: 0x12CC8F4
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12CD18C
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x12CD70C
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	// RVA: 0x12CD938
	private static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(X500DistinguishedName name) { }

}

// Namespace: System
internal static class IPv4AddressHelper
{
	// Methods

	// RVA: 0x12CDE30
	internal static int ParseHostNumber(System.ReadOnlySpan<System.Char> str, int start, int end) { }

	// RVA: 0x12CE038
	internal static bool IsValid(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x12CDE64
	private static bool ParseCanonical(System.ReadOnlySpan<System.Char> name, Byte* numbers, int start, int end) { }

	// RVA: 0x12CE064
	internal static bool IsValidCanonical(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x12CE38C
	internal static Int64 ParseNonCanonical(Char* name, int start, int end, bool notImplicitFile) { }

	// RVA: 0x12CE754
	internal static string ParseCanonicalName(string str, int start, int end, bool isLoopback) { }

	// RVA: 0x12CEBE0
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

}

// Namespace: System
internal static class IPv6AddressHelper
{
	// Methods

	// RVA: 0x12CEC50
	internal static System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12CED44
	internal static bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12CEE28
	internal static bool IsValidStrict(Char* name, int start, int end) { }

	// RVA: 0x12CF2A4
	internal static void Parse(System.ReadOnlySpan<System.Char> address, UInt16* numbers, int start, string scopeId) { }

	// RVA: 0x12CF848
	internal static string ParseCanonicalName(string str, int start, bool isLoopback, string scopeId) { }

	// RVA: 0x12D00F8
	private static bool IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12D01E4
	private static bool InternalIsValid(Char* name, int start, int end, bool validateStrictAddress) { }

	// RVA: 0x12D05C4
	internal static bool IsValid(Char* name, int start, int end) { }

}

// Namespace: System
internal static class NotImplemented
{
	// Methods

	// RVA: 0x12D05CC
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

	// RVA: 0x12D0634
	public void .ctor(Uri uri) { }

	// RVA: 0x12D0800
	private void Init(Uri uri) { }

	// RVA: 0x12D0BD0
	public void set_Path(string value) { }

	// RVA: 0x12D0C98
	public Uri get_Uri() { }

	// RVA: 0x12D0D40
	public override bool Equals(object rparam) { }

	// RVA: 0x12D0E2C
	public override int GetHashCode() { }

	// RVA: 0x12D09E0
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x12D0EE4
	public override string ToString() { }

}

// Namespace: System
internal static class SecurityUtils
{
	// Methods

	// RVA: 0x12D153C
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x12D1540
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x12D1544
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x12D154C
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x12D1558
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x12D1630
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x12D1638
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x12D1640
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x12D17E4
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x12D188C
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

	// RVA: 0x12D1A5C
	internal void .ctor() { }

	// RVA: 0x12D1B10
	public int Compare(object a, object b) { }

	// RVA: 0x12D1BF4
	private static void .cctor() { }

}

// Namespace: System
internal static class IriHelper
{
	// Methods

	// RVA: 0x12D1C5C
	internal static bool CheckIriUnicodeRange(Char unicode, bool isQuery) { }

	// RVA: 0x12D1CB4
	internal static bool CheckIriUnicodeRange(Char highSurr, Char lowSurr, bool surrogatePair, bool isQuery) { }

	// RVA: 0x12D232C
	internal static bool CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0x12D249C
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

	// RVA: 0x12D38EC
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

	// RVA: 0x12D38F4
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

	// RVA: 0x125C170
	private bool get_IsImplicitFile() { }

	// RVA: 0x125C17C
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x125C18C
	private bool get_IsDosPath() { }

	// RVA: 0x125C198
	private bool get_IsUncPath() { }

	// RVA: 0x125C1A4
	private Flags get_HostType() { }

	// RVA: 0x125C1B0
	private UriParser get_Syntax() { }

	// RVA: 0x125C1B8
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x125C1C8
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x125C290
	private bool get_AllowIdn() { }

	// RVA: 0x125C3AC
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0x125C4E8
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x125C4F0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x125C4FC
	private void SetUserDrivenParsing() { }

	// RVA: 0x125C510
	private UInt16 get_SecuredPathIndex() { }

	// RVA: 0x125C39C
	private bool NotAny(Flags flags) { }

	// RVA: 0x125C570
	private bool InFact(Flags flags) { }

	// RVA: 0x125C4DC
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x125C580
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x125C58C
	private UriInfo EnsureUriInfo() { }

	// RVA: 0x125CBCC
	private void EnsureParseRemaining() { }

	// RVA: 0x125DA70
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x125DEF8
	public void .ctor(string uriString) { }

	// RVA: 0x125E144
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x125E1D4
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x125E2C4
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x125EBCC
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x125EE18
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, string result) { }

	// RVA: 0x125FDBC
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x125FF58
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1260078
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x126007C
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12601CC
	public string get_AbsolutePath() { }

	// RVA: 0x126028C
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x1260388
	public string get_AbsoluteUri() { }

	// RVA: 0x12604C4
	public string get_LocalPath() { }

	// RVA: 0x1260CD4
	public string get_Authority() { }

	// RVA: 0x1260D4C
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x1260E9C
	public bool get_IsDefaultPort() { }

	// RVA: 0x1260F78
	public bool get_IsFile() { }

	// RVA: 0x126103C
	public bool get_IsLoopback() { }

	// RVA: 0x12610F8
	public string get_PathAndQuery() { }

	// RVA: 0x12611C0
	public string[] get_Segments() { }

	// RVA: 0x12613F8
	public bool get_IsUnc() { }

	// RVA: 0x1261470
	public string get_Host() { }

	// RVA: 0x12614E8
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x1261504
	private static object get_InitializeLock() { }

	// RVA: 0x1261608
	private static void InitializeUriConfig() { }

	// RVA: 0x1260534
	private string GetLocalPath() { }

	// RVA: 0x1261DC4
	public int get_Port() { }

	// RVA: 0x1261EBC
	public string get_Query() { }

	// RVA: 0x1261FFC
	public string get_Fragment() { }

	// RVA: 0x126213C
	public string get_Scheme() { }

	// RVA: 0x12621B0
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x125F1D8
	public string get_OriginalString() { }

	// RVA: 0x126220C
	public string get_DnsSafeHost() { }

	// RVA: 0x125E2B4
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x1262478
	public bool get_UserEscaped() { }

	// RVA: 0x1262484
	public string get_UserInfo() { }

	// RVA: 0x12624FC
	internal static bool IsGenDelim(Char ch) { }

	// RVA: 0x1262520
	public static bool IsHexDigit(Char character) { }

	// RVA: 0x126254C
	public static int FromHex(Char digit) { }

	// RVA: 0x12625E0
	public override int GetHashCode() { }

	// RVA: 0x126288C
	public override string ToString() { }

	// RVA: 0x1262BFC
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x125EA10
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x1262C30
	public override bool Equals(object comparand) { }

	// RVA: 0x126338C
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x1263450
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x1263534
	private static ParsingError ParseScheme(string uriString, Flags flags, UriParser syntax) { }

	// RVA: 0x1263C3C
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1263CD0
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1265344
	private void PrivateParseMinimalIri(string newHost, UInt16 idx) { }

	// RVA: 0x125C5BC
	private void CreateUriInfo(Flags cF) { }

	// RVA: 0x125DAD0
	private void CreateHostString() { }

	// RVA: 0x1265888
	private static string CreateHostStringHelper(string str, UInt16 idx, UInt16 end, Flags flags, string scopeId) { }

	// RVA: 0x126543C
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x12601C8
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x126603C
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x1261CD8
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x12667D8
	private string ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0x126612C
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x125CBDC
	private void ParseRemaining() { }

	// RVA: 0x1263644
	private static UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ParsingError err, Flags flags, UriParser syntax) { }

	// RVA: 0x1267D78
	private static bool CheckKnownSchemes(Int64* lptr, UInt16 nChars, UriParser syntax) { }

	// RVA: 0x125F07C
	private static ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, UriParser syntax) { }

	// RVA: 0x12643C4
	private UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ParsingError err, Flags flags, UriParser syntax, string newHost) { }

	// RVA: 0x12682CC
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, Flags flags, bool justNormalized, string newHost, ParsingError err) { }

	// RVA: 0x1268740
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, Flags flags, string newHost, ParsingError err) { }

	// RVA: 0x1267C10
	private void FindEndOfComponent(string input, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1268C48
	private void FindEndOfComponent(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1265A60
	private Check CheckCanonical(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1267478
	private Char[] GetCanonicalPath(Char[] dest, int pos, UriFormat formatAs) { }

	// RVA: 0x1268CF4
	private static void UnescapeOnly(Char* pch, int start, int end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0x12617DC
	private static Char[] Compress(Char[] dest, UInt16 start, int destLength, UriParser syntax) { }

	// RVA: 0x12627B0
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x125F23C
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x1268EFC
	internal bool get_HasAuthority() { }

	// RVA: 0x1264394
	private static bool IsLWS(Char ch) { }

	// RVA: 0x12643B0
	private static bool IsAsciiLetter(Char character) { }

	// RVA: 0x1268F08
	internal static bool IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0x1268F7C
	internal static bool IsBidiControlCharacter(Char ch) { }

	// RVA: 0x1268A58
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	// RVA: 0x125DF7C
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1268FA0
	private void InitializeUri(ParsingError err, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x1269690
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1269780
	private bool CheckForUnicode(string data) { }

	// RVA: 0x12698BC
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x1263290
	public static bool TryCreate(string uriString, UriKind uriKind, Uri result) { }

	// RVA: 0x1269D8C
	public static bool TryCreate(Uri baseUri, string relativeUri, Uri result) { }

	// RVA: 0x1269EC8
	public static bool TryCreate(Uri baseUri, Uri relativeUri, Uri result) { }

	// RVA: 0x1265E60
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x126A30C
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x126A814
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x126A360
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x126A918
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x126AAD0
	public static string EscapeDataString(string stringToEscape) { }

	// RVA: 0x1267D20
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x126AC00
	private void .ctor(Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x1269ACC
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x125E47C
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, string newUriString, bool userEscaped, UriFormatException e) { }

	// RVA: 0x126A0AC
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x126298C
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x126AC58
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x126AD10
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x125EA58
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x126AF14
	private static void .cctor() { }

}

// Namespace: System
[Serializable]
public class UriFormatException
{
	// Methods

	// RVA: 0x12D38FC
	public void .ctor() { }

	// RVA: 0x12D134C
	public void .ctor(string textString) { }

	// RVA: 0x12D3904
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12D390C
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

	// RVA: 0x12D3914
	internal static bool TestForSubPath(Char* pMe, UInt16 meLength, Char* pShe, UInt16 sheLength, bool ignoreCase) { }

	// RVA: 0x12D3B84
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, int destPos, bool isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0x12D4298
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, int destPos, int prevInputPos) { }

	// RVA: 0x12D4764
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x12D483C
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x12D2FB8
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x12D37DC
	internal static void EscapeAsciiChar(Char ch, Char[] to, int pos) { }

	// RVA: 0x12D2EDC
	internal static Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0x12D2F44
	internal static bool IsNotSafeForUnescape(Char ch) { }

	// RVA: 0x12D45C8
	private static bool IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0x12D4450
	internal static bool IsUnreserved(Char c) { }

	// RVA: 0x12D5390
	internal static bool Is3986Unreserved(Char c) { }

	// RVA: 0x12D5460
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

	// RVA: 0x12D69EC
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

	// RVA: 0x12D5504
	internal string get_SchemeName() { }

	// RVA: 0x12D550C
	internal int get_DefaultPort() { }

	// RVA: 0x12D5514
	protected void .ctor() { }

	// RVA: 0x12D55A4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x12D55A8
	protected virtual void InitializeAndValidate(Uri uri, UriFormatException parsingError) { }

	// RVA: 0x12D55E4
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, UriFormatException parsingError) { }

	// RVA: 0x12D5808
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x12D5828
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x12D5A4C
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x12D532C
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x12D5A68
	private static void .cctor() { }

	// RVA: 0x12D6AA4
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x12D14D0
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x12D1464
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x12D6B0C
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x12D6AAC
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x12D555C
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x12D6B78
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x12D1354
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x12D6EF8
	internal bool get_IsSimple() { }

	// RVA: 0x12D6F04
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x12D6F70
	internal void InternalValidate(Uri thisUri, UriFormatException parsingError) { }

	// RVA: 0x12D6F7C
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, UriFormatException parsingError) { }

	// RVA: 0x12D6F88
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x12D6F94
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x12D6FA0
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: System
internal class DomainNameHelper
{
	// Methods

	// RVA: 0x12D6FAC
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x12D714C
	internal static bool IsValid(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x12D7374
	internal static bool IsValidByIri(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x12D756C
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x12D78E4
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, string bidiStrippedHost) { }

	// RVA: 0x12D7B4C
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x12D7B00
	private static bool IsIdnAce(Char* input, int index) { }

	// RVA: 0x12D7BE0
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	// RVA: 0x12D7D1C
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x12D72EC
	private static bool IsASCIILetterOrDigit(Char character, bool notCanonical) { }

	// RVA: 0x12D7328
	private static bool IsValidDomainLabelCharacter(Char character, bool notCanonical) { }

}

// Namespace: System
internal class UncNameHelper
{
	// Methods

	// RVA: 0x12D82A8
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x12D82B0
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

	// RVA: 0x12D86CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12D87EC
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

	// RVA: 0x12D8800
	protected void .ctor() { }

	// RVA: 0x12D8808
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x12D885C
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x12D88AC
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x12D88B4
	public object get_AsyncState() { }

	// RVA: 0x12D88BC
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x12D8A0C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x12D8A14
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x12D8A1C
	public bool get_IsCompleted() { }

	// RVA: 0x12D8A24
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

	// RVA: 0x12D8B00
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x12D8B58
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x12D8B84
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x12D8B88
	public void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector
{
	// Methods

	// RVA: 0x12D8BAC
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal class SRDescriptionAttribute
{
	// Fields
	private bool isReplaced; // 0x18

	// Methods

	// RVA: 0x12D8BB0
	public void .ctor(string description) { }

	// RVA: 0x12D8C1C
	public override string get_Description() { }

}

// Namespace: System
public class UriTypeConverter
{
	// Methods

	// RVA: 0x12D8C7C
	public void .ctor() { }

	// RVA: 0x12D8C84
	private bool CanConvert(Type type) { }

	// RVA: 0x12D8D50
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D8DE4
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12D8E54
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D9000
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Web
public sealed class HttpUtility
{
	// Methods

	// RVA: 0x12D91E0
	public static string UrlEncode(string str) { }

	// RVA: 0x12D920C
	public static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x12D9460
	public static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Web.Util.HttpEncoder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x12D9E1C
	private static void .cctor() { }

	// RVA: 0x12D9E88
	public void .ctor() { }

	// RVA: 0x12D9E90
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

	// RVA: 0x12D94FC
	public static HttpEncoder get_Current() { }

	// RVA: 0x12D960C
	private static void .cctor() { }

	// RVA: 0x12D9804
	public void .ctor() { }

	// RVA: 0x12D980C
	protected internal virtual Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	// RVA: 0x12D9A94
	private static HttpEncoder GetCustomEncoderFromConfig() { }

	// RVA: 0x12D9884
	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	// RVA: 0x12D9440
	internal static bool NotEncoded(Char c) { }

	// RVA: 0x12D9B3C
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

	// RVA: 0x12D9EE8
	internal void .ctor(string text, int index, int length) { }

	// RVA: 0x12D9F34
	public int get_Index() { }

	// RVA: 0x12D9F3C
	internal void set_Index(int value) { }

	// RVA: 0x12D9F44
	public int get_Length() { }

	// RVA: 0x12D9F4C
	internal void set_Length(int value) { }

	// RVA: 0x12D9F54
	internal string get_Text() { }

	// RVA: 0x12D9F5C
	internal void set_Text(string value) { }

	// RVA: 0x12D9F64
	public string get_Value() { }

	// RVA: 0x12D9F8C
	public override string ToString() { }

	// RVA: 0x12D9FB4
	internal System.ReadOnlySpan<System.Char> GetLeftSubstring() { }

	// RVA: 0x12DA058
	internal System.ReadOnlySpan<System.Char> GetRightSubstring() { }

	// RVA: 0x12DA0FC
	internal void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class Enumerator
{
	// Fields
	private readonly CaptureCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12DA298
	internal void .ctor(CaptureCollection collection) { }

	// RVA: 0x12DAF18
	public bool MoveNext() { }

	// RVA: 0x12DAF60
	public Capture get_Current() { }

	// RVA: 0x12DAFE0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12DAFE4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12DAFF0
	private void System.IDisposable.Dispose() { }

}

// Namespace: System.Text.RegularExpressions
public class CaptureCollection
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20

	// Methods

	// RVA: 0x12DA138
	public bool get_IsReadOnly() { }

	// RVA: 0x12DA140
	public int get_Count() { }

	// RVA: 0x12DA148
	public Capture get_Item(int i) { }

	// RVA: 0x12DA21C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12DA2D8
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	// RVA: 0x12DA14C
	private Capture GetCapture(int i) { }

	// RVA: 0x12DA354
	internal void ForceInitialized() { }

	// RVA: 0x12DA4E0
	public bool get_IsSynchronized() { }

	// RVA: 0x12DA4E8
	public object get_SyncRoot() { }

	// RVA: 0x12DA4F0
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12DA5B4
	public void CopyTo(Capture[] array, int arrayIndex) { }

	// RVA: 0x12DA760
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	// RVA: 0x12DA81C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	// RVA: 0x12DA870
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	// RVA: 0x12DA8C4
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	// RVA: 0x12DA8C8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	// RVA: 0x12DA91C
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	// RVA: 0x12DA970
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	// RVA: 0x12DA9C4
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	// RVA: 0x12DAA7C
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	// RVA: 0x12DAAD0
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12DAB24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12DAB78
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12DAC7C
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12DAD80
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12DADD4
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12DADDC
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12DAE30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12DAE84
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12DAE88
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12DAEDC
	internal void .ctor() { }

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

	// RVA: 0x12DAFF4
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x12DB0C0
	public bool get_Success() { }

	// RVA: 0x12DB0D0
	private static void .cctor() { }

	// RVA: 0x12DB22C
	internal void .ctor() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12DB6B0
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x12DC560
	public bool MoveNext() { }

	// RVA: 0x12DC5B8
	public Group get_Current() { }

	// RVA: 0x12DC648
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12DC64C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12DC658
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

	// RVA: 0x12DB268
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x12DB2B8
	public bool get_IsReadOnly() { }

	// RVA: 0x12DB2C0
	public int get_Count() { }

	// RVA: 0x12DB2E8
	public Group get_Item(int groupnum) { }

	// RVA: 0x12DB410
	public Group get_Item(string groupname) { }

	// RVA: 0x12DB634
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12DB6F0
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x12DB2EC
	private Group GetGroup(int groupnum) { }

	// RVA: 0x12DB76C
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x12DBAD4
	public bool get_IsSynchronized() { }

	// RVA: 0x12DBADC
	public object get_SyncRoot() { }

	// RVA: 0x12DBAE4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12DBBB8
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x12DBD80
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x12DBE64
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x12DBEB8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x12DBF0C
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x12DBF10
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x12DBF64
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x12DBFB8
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x12DC00C
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x12DC0C4
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x12DC118
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12DC16C
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12DC1C0
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12DC2C4
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12DC3C8
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12DC41C
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12DC424
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12DC478
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12DC4CC
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12DC4D0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12DC524
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

	// RVA: 0x12DC65C
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x12DC810
	public static Match get_Empty() { }

	// RVA: 0x12DC88C
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x12DC914
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x12DC9D0
	public Match NextMatch() { }

	// RVA: 0x12DCD04
	internal virtual System.ReadOnlySpan<System.Char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x12DCE94
	internal System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }

	// RVA: 0x12DCEC0
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x12DD0C0
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x12DD1A0
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x12DD1DC
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x12DD274
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x12DD30C
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x12DD3A4
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x12DD520
	private static void .cctor() { }

	// RVA: 0x12DD5BC
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Methods

	// RVA: 0x12DD5F8
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x12DD6B4
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

	// RVA: 0x12DDB94
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x12DE538
	public bool MoveNext() { }

	// RVA: 0x12DE5A4
	public Match get_Current() { }

	// RVA: 0x12DE618
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12DE61C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12DE628
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

	// RVA: 0x12DD774
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x12DD8CC
	public bool get_IsReadOnly() { }

	// RVA: 0x12DD8D4
	public int get_Count() { }

	// RVA: 0x12DD958
	public virtual Match get_Item(int i) { }

	// RVA: 0x12DDB18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12DDBD4
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x12DD9C4
	private Match GetMatch(int i) { }

	// RVA: 0x12DD944
	private void EnsureInitialized() { }

	// RVA: 0x12DDC50
	public bool get_IsSynchronized() { }

	// RVA: 0x12DDC58
	public object get_SyncRoot() { }

	// RVA: 0x12DDC5C
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12DDD3C
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x12DDDCC
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x12DDE54
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x12DDEA8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x12DDEFC
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x12DDF0C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x12DDF60
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x12DDFB4
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x12DE008
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x12DE090
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x12DE0E4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12DE138
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12DE18C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12DE290
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12DE394
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12DE3E8
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12DE3F0
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12DE444
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12DE498
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12DE4A8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12DE4FC
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

	// RVA: 0x12DE62C
	public RegexRunner Get() { }

	// RVA: 0x12DE6BC
	public void Release(RegexRunner obj) { }

	// RVA: 0x12DE7CC
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

	// RVA: 0x12E147C
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x12E1850
	public override bool Equals(object obj) { }

	// RVA: 0x12E1910
	public bool Equals(CachedCodeEntryKey other) { }

	// RVA: 0x12DE928
	public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	// RVA: 0x12E197C
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

	// RVA: 0x12DF17C
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

	// RVA: 0x12DE7D4
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x12DE99C
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x12DF25C
	private void FillCacheDictionary() { }

	// RVA: 0x12DF374
	private static bool TryGetCacheValue(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x12DF4AC
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x12DEF04
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	// RVA: 0x12DF70C
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x12DF7F0
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12DFBE8
	public bool IsMatch(string input) { }

	// RVA: 0x12DFC74
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x12DFCFC
	public static Match Match(string input, string pattern) { }

	// RVA: 0x12DFDE0
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12DFE70
	public Match Match(string input) { }

	// RVA: 0x12DFEF0
	public Match Match(string input, int startat) { }

	// RVA: 0x12DFF6C
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x12E0050
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12E00E0
	public MatchCollection Matches(string input) { }

	// RVA: 0x12E0160
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x12E0234
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x12E03C0
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x12E0320
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12E04B8
	public string Replace(string input, string replacement) { }

	// RVA: 0x12E0540
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x12E061C
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x12E0708
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12E07A8
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x12E0830
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x12E0904
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x12E0D54
	private static void .cctor() { }

	// RVA: 0x12E1104
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x12E0EA4
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x12E12C0
	protected void .ctor() { }

	// RVA: 0x12E1338
	public void .ctor(string pattern) { }

	// RVA: 0x12E13B4
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x12E143C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x12DF880
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x12E1728
	public static string Escape(string str) { }

	// RVA: 0x12E17E4
	public RegexOptions get_Options() { }

	// RVA: 0x12E0D48
	public bool get_RightToLeft() { }

	// RVA: 0x12E17EC
	public override string ToString() { }

	// RVA: 0x12DB980
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x12DB4C8
	public int GroupNumberFromName(string name) { }

	// RVA: 0x12E1614
	protected void InitializeReferences() { }

	// RVA: 0x12DCA00
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x12DFC68
	protected internal bool UseOptionR() { }

	// RVA: 0x12E17F4
	internal bool UseOptionInvariant() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator
{
	// Methods

	// RVA: 0x12E19DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E1AFC
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

	// RVA: 0x12E1B10
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x12E2130
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x12E22A8
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x12E2318
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

	// RVA: 0x12EA3BC
	internal void .ctor(Char chMin, Char chMax, int lcOp, int data) { }

}

// Namespace: 
private sealed class SingleRangeComparer
{
	// Fields
	public static readonly SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x12EA3CC
	private void .ctor() { }

	// RVA: 0x12EA3D4
	public int Compare(SingleRange x, SingleRange y) { }

	// RVA: 0x12EA424
	private static void .cctor() { }

}

// Namespace: 
private struct SingleRange
{
	// Fields
	public readonly Char First; // 0x10
	public readonly Char Last; // 0x12

	// Methods

	// RVA: 0x12E2D7C
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

	// RVA: 0x12E2614
	public void .ctor() { }

	// RVA: 0x12E26EC
	private void .ctor(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x12E2768
	public bool get_CanMerge() { }

	// RVA: 0x12E2788
	public void set_Negate(bool value) { }

	// RVA: 0x12E2790
	public void AddChar(Char c) { }

	// RVA: 0x12E286C
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x12E2B70
	private void AddSet(string set) { }

	// RVA: 0x12E2D88
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x12E2798
	public void AddRange(Char first, Char last) { }

	// RVA: 0x12E2D90
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x12E32F8
	private void AddCategory(string category) { }

	// RVA: 0x12E3318
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x12E34A8
	private void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0x12E3758
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x12E387C
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x12E39A0
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x12E3A64
	public static Char SingletonChar(string set) { }

	// RVA: 0x12E3A80
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x12E3BEC
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x12E3CF4
	public static bool IsSingleton(string set) { }

	// RVA: 0x12E3E34
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x12E3B8C
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x12E3B64
	private static bool IsNegated(string set) { }

	// RVA: 0x12E3F78
	public static bool IsECMAWordChar(Char ch) { }

	// RVA: 0x12E40C8
	public static bool IsWordChar(Char ch) { }

	// RVA: 0x12E405C
	public static bool CharInClass(Char ch, string set) { }

	// RVA: 0x12E41A4
	private static bool CharInClassRecursive(Char ch, string set, int start) { }

	// RVA: 0x12E42D8
	private static bool CharInClassInternal(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x12E4400
	private static bool CharInCategory(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x12E4624
	private static bool CharInCategoryGroup(Char ch, UnicodeCategory chcategory, string category, int i) { }

	// RVA: 0x12E2FD4
	private static string NegateCategory(string category) { }

	// RVA: 0x12E46F0
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x12E4778
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x12E2AAC
	private int RangeCount() { }

	// RVA: 0x12E49EC
	public string ToStringClass() { }

	// RVA: 0x12E2AF8
	private SingleRange GetRangeAt(int i) { }

	// RVA: 0x12E4BC0
	private void Canonicalize() { }

	// RVA: 0x12E3080
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x12E4E3C
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

	// RVA: 0x12EA490
	public void .ctor(int[] codes, System.Collections.Generic.List<System.String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x12EA5A4
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

	// RVA: 0x12EA5C8
	private void .ctor(System.Span<System.Int32> intStack) { }

	// RVA: 0x12EA6A8
	public static System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x12EAC38
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x12EAE94
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x12EB060
	private static int AnchorFromType(int type) { }

	// RVA: 0x12EB0C8
	private void PushInt(int i) { }

	// RVA: 0x12EB134
	private bool IntIsEmpty() { }

	// RVA: 0x12EB17C
	private int PopInt() { }

	// RVA: 0x12EB2A4
	private void PushFC(RegexFC fc) { }

	// RVA: 0x12EB308
	private bool FCIsEmpty() { }

	// RVA: 0x12EB35C
	private RegexFC PopFC() { }

	// RVA: 0x12EB440
	private RegexFC TopFC() { }

	// RVA: 0x12EABA8
	public void Dispose() { }

	// RVA: 0x12EA9AC
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x12EBA94
	private void SkipChild() { }

	// RVA: 0x12EB4BC
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

	// RVA: 0x12EBAA0
	public void .ctor(bool nullable) { }

	// RVA: 0x12EBBE4
	public void .ctor(Char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x12EBCE4
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x12EBB20
	public bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x12EBDE8
	public bool get_CaseInsensitive() { }

	// RVA: 0x12EBDF0
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x12EABFC
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

	// RVA: 0x12E1800
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x12EBDF8
	protected override void InitTrackCount() { }

	// RVA: 0x12EBE1C
	private void Advance(int i) { }

	// RVA: 0x12EBEA4
	private void Goto(int newpos) { }

	// RVA: 0x12EBF24
	private void Textto(int newpos) { }

	// RVA: 0x12EBF2C
	private void Trackto(int newpos) { }

	// RVA: 0x12EBF54
	private int Textstart() { }

	// RVA: 0x12EBF5C
	private int Textpos() { }

	// RVA: 0x12EBF64
	private int Trackpos() { }

	// RVA: 0x12EBF8C
	private void TrackPush() { }

	// RVA: 0x12EBFD0
	private void TrackPush(int I1) { }

	// RVA: 0x12EC030
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x12EC0AC
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x12EC144
	private void TrackPush2(int I1) { }

	// RVA: 0x12EC1A8
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x12EC228
	private void Backtrack() { }

	// RVA: 0x12EBE84
	private void SetOperator(int op) { }

	// RVA: 0x12EC330
	private void TrackPop() { }

	// RVA: 0x12EC340
	private void TrackPop(int framesize) { }

	// RVA: 0x12EC350
	private int TrackPeek() { }

	// RVA: 0x12EC38C
	private int TrackPeek(int i) { }

	// RVA: 0x12EC3CC
	private void StackPush(int I1) { }

	// RVA: 0x12EC40C
	private void StackPush(int I1, int I2) { }

	// RVA: 0x12EC468
	private void StackPop() { }

	// RVA: 0x12EC478
	private void StackPop(int framesize) { }

	// RVA: 0x12EC488
	private int StackPeek() { }

	// RVA: 0x12EC4C4
	private int StackPeek(int i) { }

	// RVA: 0x12EC504
	private int Operator() { }

	// RVA: 0x12EC50C
	private int Operand(int i) { }

	// RVA: 0x12EC554
	private int Leftchars() { }

	// RVA: 0x12EC564
	private int Rightchars() { }

	// RVA: 0x12EC574
	private int Bump() { }

	// RVA: 0x12EC588
	private int Forwardchars() { }

	// RVA: 0x12EC5B4
	private Char Forwardcharnext() { }

	// RVA: 0x12EC648
	private bool Stringmatch(string str) { }

	// RVA: 0x12EC7BC
	private bool Refmatch(int index, int len) { }

	// RVA: 0x12EC964
	private void Backwardnext() { }

	// RVA: 0x12EC994
	private Char CharAt(int j) { }

	// RVA: 0x12EC9B4
	protected override bool FindFirstChar() { }

	// RVA: 0x12ECF58
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

	// RVA: 0x12EF360
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x12EF470
	public void .ctor() { }

	// RVA: 0x12EF51C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12EF694
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12EF79C
	public string get_Input() { }

	// RVA: 0x12EF7A4
	public string get_Pattern() { }

	// RVA: 0x12EF7AC
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

	// RVA: 0x12EF7B4
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x12EF7F0
	public void .ctor(int type, RegexOptions options, Char ch) { }

	// RVA: 0x12EF834
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x12EF880
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x12EF8C4
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x12EF914
	public bool UseOptionR() { }

	// RVA: 0x12EF920
	public RegexNode ReverseLeft() { }

	// RVA: 0x12EF9A0
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x12EF9B8
	private RegexNode Reduce() { }

	// RVA: 0x12F06EC
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x12F04B4
	private RegexNode ReduceGroup() { }

	// RVA: 0x12F02E8
	private RegexNode ReduceRep() { }

	// RVA: 0x12F053C
	private RegexNode ReduceSet() { }

	// RVA: 0x12EFAB4
	private RegexNode ReduceAlternation() { }

	// RVA: 0x12EFEF8
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x12F08E8
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x12F0A44
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x12F0870
	public RegexNode Child(int i) { }

	// RVA: 0x12F0818
	public int ChildCount() { }

	// RVA: 0x12F0B3C
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

	// RVA: 0x12F0B44
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x12F21AC
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x12F28EC
	public static string Escape(string input) { }

	// RVA: 0x12F0D84
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x12F0E64
	private void SetPattern(string Re) { }

	// RVA: 0x12F12B0
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x12F1350
	private RegexNode ScanRegex() { }

	// RVA: 0x12F2354
	private RegexNode ScanReplacement() { }

	// RVA: 0x12F37CC
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x12F3EF8
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x12F2D14
	private void ScanBlank() { }

	// RVA: 0x12F4F20
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x12F66A0
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x12F5840
	private RegexNode ScanDollar() { }

	// RVA: 0x12F61EC
	private string ScanCapname() { }

	// RVA: 0x12F6D10
	private Char ScanOctal() { }

	// RVA: 0x12F5720
	private int ScanDecimal() { }

	// RVA: 0x12F6E20
	private Char ScanHex(int c) { }

	// RVA: 0x12F6F78
	private static int HexDigit(Char ch) { }

	// RVA: 0x12F6FA8
	private Char ScanControl() { }

	// RVA: 0x12F705C
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x12F6404
	private void ScanOptions() { }

	// RVA: 0x12F5EA4
	private Char ScanCharEscape() { }

	// RVA: 0x12F5D14
	private string ParseProperty() { }

	// RVA: 0x12F6610
	private int TypeFromCode(Char ch) { }

	// RVA: 0x12F707C
	private static RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0x12F0EA8
	private void CountCaptures() { }

	// RVA: 0x12F70DC
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x12F7218
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x12F2310
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x12F7380
	private void AssignNameSlots() { }

	// RVA: 0x12F63A8
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x12F6300
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x12F638C
	private bool IsCaptureName(string capname) { }

	// RVA: 0x12F62F4
	private bool UseOptionN() { }

	// RVA: 0x12F37C0
	private bool UseOptionI() { }

	// RVA: 0x12F5554
	private bool UseOptionM() { }

	// RVA: 0x12F55DC
	private bool UseOptionS() { }

	// RVA: 0x12F3080
	private bool UseOptionX() { }

	// RVA: 0x12F5D08
	private bool UseOptionE() { }

	// RVA: 0x12F335C
	private static bool IsSpecial(Char ch) { }

	// RVA: 0x12F30EC
	private static bool IsStopperX(Char ch) { }

	// RVA: 0x12F33FC
	private static bool IsQuantifier(Char ch) { }

	// RVA: 0x12F318C
	private bool IsTrueQuantifier() { }

	// RVA: 0x12F6570
	private static bool IsSpace(Char ch) { }

	// RVA: 0x12F2BB0
	private static bool IsMetachar(Char ch) { }

	// RVA: 0x12F349C
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x12F4894
	private void PushGroup() { }

	// RVA: 0x12F4D38
	private void PopGroup() { }

	// RVA: 0x12F4A88
	private bool EmptyStack() { }

	// RVA: 0x12F2C50
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x12F4900
	private void AddAlternate() { }

	// RVA: 0x12F56B4
	private void AddConcatenate() { }

	// RVA: 0x12F57F4
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x12F7A5C
	private RegexNode Unit() { }

	// RVA: 0x12F3704
	private void AddUnitOne(Char ch) { }

	// RVA: 0x12F55E8
	private void AddUnitNotone(Char ch) { }

	// RVA: 0x12F3DFC
	private void AddUnitSet(string cc) { }

	// RVA: 0x12F7A64
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x12F5560
	private void AddUnitType(int type) { }

	// RVA: 0x12F4B38
	private void AddGroup() { }

	// RVA: 0x12F3E8C
	private void PushOptions() { }

	// RVA: 0x12F4E74
	private void PopOptions() { }

	// RVA: 0x12F71C4
	private bool EmptyOptionsStack() { }

	// RVA: 0x12F482C
	private void PopKeepOptions() { }

	// RVA: 0x12F4A98
	private ArgumentException MakeException(string message) { }

	// RVA: 0x12F7A6C
	private int Textpos() { }

	// RVA: 0x12F7A74
	private void Textto(int pos) { }

	// RVA: 0x12F56F0
	private Char RightCharMoveRight() { }

	// RVA: 0x12F308C
	private void MoveRight() { }

	// RVA: 0x12F62E4
	private void MoveRight(int i) { }

	// RVA: 0x12F56A4
	private void MoveLeft() { }

	// RVA: 0x12F36E4
	private Char CharAt(int i) { }

	// RVA: 0x12F30C4
	internal Char RightChar() { }

	// RVA: 0x12F62B8
	private Char RightChar(int i) { }

	// RVA: 0x12F309C
	private int CharsRight() { }

	// RVA: 0x12F7A7C
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

	// RVA: 0x12F7B20
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x12F7B4C
	internal bool get_CaseInsensitive() { }

	// RVA: 0x12F7B54
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x12F7BD0
	internal string get_Prefix() { }

	// RVA: 0x12F7BD8
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

	// RVA: 0x12F24E4
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x12F7C6C
	public static RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	// RVA: 0x12F7D8C
	public string get_Pattern() { }

	// RVA: 0x12F7D94
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x12F7F50
	private void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, Match match) { }

	// RVA: 0x12F8168
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

	// RVA: 0x12F8528
	protected internal void .ctor() { }

	// RVA: 0x12F8530
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x12F8928
	private void StartTimeoutWatch() { }

	// RVA: 0x12F8974
	protected void CheckTimeout() { }

	// RVA: 0x12F8C2C
	private void DoCheckTimeout() { }

	// RVA: -1
	protected abstract void Go() { }

	// RVA: -1
	protected abstract bool FindFirstChar() { }

	// RVA: -1
	protected abstract void InitTrackCount() { }

	// RVA: 0x12F8984
	private void InitMatch() { }

	// RVA: 0x12F8BC4
	private Match TidyMatch(bool quick) { }

	// RVA: 0x12F8D08
	protected void EnsureStorage() { }

	// RVA: 0x12F8ECC
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12F8FD0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12F8E18
	protected void DoubleTrack() { }

	// RVA: 0x12F8D64
	protected void DoubleStack() { }

	// RVA: 0x12F90D4
	protected void DoubleCrawl() { }

	// RVA: 0x12F9188
	protected void Crawl(int i) { }

	// RVA: 0x12F91E8
	protected int Popcrawl() { }

	// RVA: 0x12F9228
	protected int Crawlpos() { }

	// RVA: 0x12F9250
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x12F92E4
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x12F9494
	protected void Uncapture() { }

	// RVA: 0x12F94E4
	protected bool IsMatched(int cap) { }

	// RVA: 0x12F944C
	protected int MatchIndex(int cap) { }

	// RVA: 0x12F9470
	protected int MatchLength(int cap) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory
{
	// Methods

	// RVA: 0x12F9508
	protected void .ctor() { }

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

	// RVA: 0x12F20FC
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

	// RVA: 0x12F9510
	private void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }

	// RVA: 0x12F9658
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x12F9E78
	public void Dispose() { }

	// RVA: 0x12F9878
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x12FAB28
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x12FAB98
	private void Emit(int op) { }

	// RVA: 0x12F9ED8
	private void Emit(int op, int opd1) { }

	// RVA: 0x12FAC20
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x12FACE0
	private int StringCode(string str) { }

	// RVA: 0x12FAE00
	private int MapCapnum(int capnum) { }

	// RVA: 0x12F9F78
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute
{
	// Fields
	private readonly string tool; // 0x10
	private readonly string version; // 0x18

	// Methods

	// RVA: 0x12FAE90
	public void .ctor(string tool, string version) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch
{
	// Methods

	// RVA: 0x12FAEE0
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

	// RVA: 0x12FAFA8
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x12FB014
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x12FB240
	private static void _pruneCachedSwitches() { }

	// RVA: 0x12FB72C
	private static void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x12FB7C8
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x12FB7F8
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

	// RVA: 0x12FB898
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

	// RVA: 0x12FB960
	public static Int64 GetTimestamp() { }

	// RVA: 0x12FB964
	public static Stopwatch StartNew() { }

	// RVA: 0x12FBA30
	public void .ctor() { }

	// RVA: 0x12FBAB8
	public TimeSpan get_Elapsed() { }

	// RVA: 0x12FBCE4
	public Int64 get_ElapsedMilliseconds() { }

	// RVA: 0x12FBC68
	public Int64 get_ElapsedTicks() { }

	// RVA: 0x12FBEA0
	public bool get_IsRunning() { }

	// RVA: 0x12FBEA8
	public void Reset() { }

	// RVA: 0x12FBA38
	public void Start() { }

	// RVA: 0x12FBEB4
	public void Stop() { }

	// RVA: 0x12FBF30
	public void Restart() { }

	// RVA: 0x12FBF9C
	private static void .cctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute
{
	// Methods

	// RVA: 0x12FBFF8
	public void .ctor() { }

}

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException
{
	// Methods

	// RVA: 0x12FC000
	public void .ctor() { }

	// RVA: 0x12FC064
	public void .ctor(string message) { }

	// RVA: 0x12FC06C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12FC074
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

	// RVA: 0x12FDB84
	private static void .cctor() { }

	// RVA: 0x12FDBF0
	public void .ctor() { }

	// RVA: 0x12FDBF8
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x12FDC58
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x12FDCA0
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

	// RVA: 0x12FC07C
	private void set_ContentLength(int value) { }

	// RVA: 0x12FC084
	internal void .ctor(Byte[] data) { }

	// RVA: 0x12FC0AC
	internal void .ctor(Byte[] data, int offset, int length) { }

	// RVA: 0x12FC0C0
	private void .ctor(DerTag tagToEat, Byte[] data, int offset, int length) { }

	// RVA: 0x12FC2A0
	internal bool get_HasData() { }

	// RVA: 0x12FC2B0
	internal Byte PeekTag() { }

	// RVA: 0x12FC350
	internal void SkipValue() { }

	// RVA: 0x12FC3AC
	internal Byte[] ReadNextEncodedValue() { }

	// RVA: 0x12FC59C
	internal bool ReadBoolean() { }

	// RVA: 0x12FC670
	internal int ReadInteger() { }

	// RVA: 0x12FC71C
	internal Byte[] ReadIntegerBytes() { }

	// RVA: 0x12FC894
	internal Byte[] ReadBitString() { }

	// RVA: 0x12FC9DC
	internal Byte[] ReadOctetString() { }

	// RVA: 0x12FCA9C
	internal string ReadOidAsString() { }

	// RVA: 0x12FCD90
	internal string ReadUtf8String() { }

	// RVA: 0x12FCF1C
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	// RVA: 0x12FD088
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x12FD090
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x12FD098
	internal string ReadPrintableString() { }

	// RVA: 0x12FD1A0
	internal string ReadIA5String() { }

	// RVA: 0x12FD2A8
	internal string ReadT61String() { }

	// RVA: 0x12FD6A8
	internal DateTime ReadX509Date() { }

	// RVA: 0x12FD788
	internal DateTime ReadUtcTime() { }

	// RVA: 0x12FD7E0
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x12FDA7C
	internal string ReadBMPString() { }

	// RVA: 0x12FCE98
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x12FD838
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	// RVA: 0x12FC7DC
	private Byte[] ReadContentAsBytes() { }

	// RVA: 0x12FC1CC
	private void EatTag(DerTag expected) { }

	// RVA: 0x12FCFE8
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	// RVA: 0x12FC258
	private int EatLength() { }

	// RVA: 0x12FC468
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

	// RVA: 0x12FDD8C
	public void .ctor() { }

	// RVA: 0x12FDD94
	public void .ctor(string oid) { }

	// RVA: 0x12FDE2C
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x12FDE7C
	public void .ctor(Oid oid) { }

	// RVA: 0x12FDF18
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x12FE0D4
	public string get_Value() { }

	// RVA: 0x12FE0DC
	public void set_Value(string value) { }

	// RVA: 0x12FE0E4
	public string get_FriendlyName() { }

	// RVA: 0x12FE078
	private void .ctor(string value, string friendlyName, OidGroup group) { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection
{
	// Fields
	private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list; // 0x10

	// Methods

	// RVA: 0x12FE1B0
	public void .ctor() { }

	// RVA: 0x12FE23C
	public int Add(Oid oid) { }

	// RVA: 0x12FE2B8
	public Oid get_Item(int index) { }

	// RVA: 0x12FE330
	public int get_Count() { }

	// RVA: 0x12FE37C
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x12FE438
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12FE4B4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12FE714
	public bool get_IsSynchronized() { }

	// RVA: 0x12FE71C
	public object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Methods

	// RVA: 0x12FE3F8
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x12FE720
	public Oid get_Current() { }

	// RVA: 0x12FE79C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12FE818
	public bool MoveNext() { }

	// RVA: 0x12FE898
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

	// RVA: 0x12FE8A4
	protected void .ctor() { }

	// RVA: 0x12FE8AC
	public void .ctor(string oid, Byte[] rawData) { }

	// RVA: 0x12FEAB0
	public void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0x12FEC04
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12FED58
	public Oid get_Oid() { }

	// RVA: 0x12FEB74
	public void set_Oid(Oid value) { }

	// RVA: 0x12FED60
	public Byte[] get_RawData() { }

	// RVA: 0x12FE9A8
	public void set_RawData(Byte[] value) { }

	// RVA: 0x12FED68
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12FEED0
	public virtual string Format(bool multiLine) { }

	// RVA: 0x12FF048
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x12FEF0C
	internal string Default(bool multiLine) { }

	// RVA: 0x12FF21C
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x12FF338
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x12FF458
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x12FF578
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x12FF698
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x12FFA70
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

	// RVA: 0x12FFF74
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x13000F0
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x13000F8
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1300100
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x1300DDC
	public Oid get_Oid() { }

	// RVA: 0x1300DE4
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x13006FC
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0x13002CC
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0x1300E98
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName
{
	// Fields
	private string name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x1300F18
	public void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0x13011B8
	public void .ctor(string distinguishedName) { }

	// RVA: 0x13011C0
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x13016AC
	public string get_Name() { }

	// RVA: 0x1301508
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x130173C
	public override string Format(bool multiLine) { }

	// RVA: 0x13016B4
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x13010B8
	private void DecodeRawData() { }

	// RVA: 0x13017AC
	private static string Canonize(string s) { }

	// RVA: 0x13019FC
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

	// RVA: 0x1301BF4
	public void .ctor() { }

	// RVA: 0x12FFE60
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1301EF4
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x13021A4
	public bool get_CertificateAuthority() { }

	// RVA: 0x1302218
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x130228C
	public int get_PathLengthConstraint() { }

	// RVA: 0x1302300
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1301CC4
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1302048
	internal Byte[] Encode() { }

	// RVA: 0x13024FC
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

	// RVA: 0x1302788
	public override void Reset() { }

	// RVA: 0x1302840
	public void .ctor() { }

	// RVA: 0x1302848
	public void .ctor(Byte[] rawData) { }

	// RVA: 0x13029D8
	public void .ctor(Byte[] rawData, string password) { }

	// RVA: 0x13029E0
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x13029E8
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x13029F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1302A38
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1303108
	public bool get_HasPrivateKey() { }

	// RVA: 0x13031B4
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x13033EC
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x13034E4
	public DateTime get_NotAfter() { }

	// RVA: 0x13034EC
	public DateTime get_NotBefore() { }

	// RVA: 0x13034F4
	public PublicKey get_PublicKey() { }

	// RVA: 0x13036BC
	public Byte[] get_RawData() { }

	// RVA: 0x13037B8
	public string get_SerialNumber() { }

	// RVA: 0x13037C8
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x13038C8
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x13039C0
	public string get_Thumbprint() { }

	// RVA: 0x13039E0
	public int get_Version() { }

	// RVA: 0x1303ABC
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0x1303B58
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1303C14
	public override string ToString() { }

	// RVA: 0x1303C20
	public override string ToString(bool verbose) { }

	// RVA: 0x1305364
	public bool Verify() { }

	// RVA: 0x1302F04
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x1302E74
	internal X509Certificate2Impl get_Impl() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x130540C
	public void .ctor() { }

	// RVA: 0x130541C
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x13054C8
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x13055F8
	public int Add(X509Certificate2 certificate) { }

	// RVA: 0x130544C
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1305674
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x13059AC
	private string GetKeyIdentifier(X509Certificate2 x) { }

	// RVA: 0x13062CC
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x1307448
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1307574
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x13074AC
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x130761C
	public X509Certificate2 get_Current() { }

	// RVA: 0x1307720
	public bool MoveNext() { }

	// RVA: 0x13077D4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x130788C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1307940
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

	// RVA: 0x13079F8
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

	// RVA: 0x1307A00
	public override bool get_IsValid() { }

	// RVA: 0x1307A10
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x1307A4C
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x1307B58
	public void .ctor(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1307D88
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1307DF8
	private X509Certificate get_Cert() { }

	// RVA: 0x1307E20
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x1307E64
	public override bool get_HasPrivateKey() { }

	// RVA: 0x1307E8C
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x13082DC
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1308484
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x130851C
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x1307D10
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x13085B4
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	// RVA: 0x1308ED4
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x13090CC
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x13090D4
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x13090DC
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Methods

	// RVA: 0x13091BC
	private void EnsureCertData() { }

	// RVA: -1
	protected abstract Byte[] GetRawCertData() { }

	// RVA: 0x1309294
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x1309378
	public sealed override Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x130945C
	public sealed override Byte[] get_PublicKeyValue() { }

	// RVA: 0x1309540
	public sealed override Byte[] get_SerialNumber() { }

	// RVA: 0x1309624
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x1309708
	public sealed override int get_Version() { }

	// RVA: 0x13097F4
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x13098D8
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x13099BC
	public sealed override string get_Subject() { }

	// RVA: 0x13099E8
	public sealed override string get_Issuer() { }

	// RVA: 0x1309A14
	public sealed override Byte[] get_RawData() { }

	// RVA: 0x1309AF8
	public sealed override Byte[] get_Thumbprint() { }

	// RVA: 0x1309D10
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1309E00
	public sealed override System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x1309EE4
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x130A014
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x130A144
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x130A1E8
	public sealed override Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x130A348
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x130A3A8
	private Byte[] ExportPkcs12(string password) { }

	// RVA: 0x1307A44
	protected void .ctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x130ABE0
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x130ACCC
	public X509Certificate get_Current() { }

	// RVA: 0x130ADD0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x130AE88
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x130AF3C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x130AFF4
	public bool MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0x1305414
	public void .ctor() { }

	// RVA: 0x130A8D8
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x130AA5C
	public X509Certificate get_Item(int index) { }

	// RVA: 0x130AB00
	public int Add(X509Certificate value) { }

	// RVA: 0x130A908
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x130AB7C
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x130ACA8
	public override int GetHashCode() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection
{
	// Fields
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

	// Methods

	// RVA: 0x1308DC4
	public void .ctor() { }

	// RVA: 0x130B0A8
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x130A88C
	public int get_Count() { }

	// RVA: 0x130A814
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x1308E50
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x1307AF4
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x130B314
	public void Dispose() { }

	// RVA: 0x130B3A4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x130B6A8
	protected override void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Methods

	// RVA: 0x130B744
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x130B7E8
	public void .ctor() { }

	// RVA: 0x130B85C
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x130B938
	internal void .ctor(X509ChainImpl impl) { }

	// RVA: 0x130B9A4
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x130B9EC
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x130BA54
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x130905C
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x130BABC
	public void Reset() { }

	// RVA: 0x1308FB0
	public static X509Chain Create() { }

	// RVA: 0x130BB24
	public void Dispose() { }

	// RVA: 0x130BBB4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x130BCE4
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

	// RVA: 0x130BD80
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x130BDD4
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x130BDDC
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x130BDE4
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x130BDEC
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x130BDF4
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x130BEAC
	private void Set(X509ChainStatus[] status, int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x130C0CC
	internal void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection
{
	// Fields
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x130CF94
	internal void .ctor() { }

	// RVA: 0x130D00C
	public int get_Count() { }

	// RVA: 0x130D034
	public bool get_IsSynchronized() { }

	// RVA: 0x130D05C
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x130D100
	public object get_SyncRoot() { }

	// RVA: 0x130D128
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x130D150
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x130D280
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x130D2E8
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x130D39C
	internal void Clear() { }

	// RVA: 0x130D3C4
	internal bool Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x130D1B8
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x130D530
	public X509ChainElement get_Current() { }

	// RVA: 0x130D634
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x130D6EC
	public bool MoveNext() { }

	// RVA: 0x130D7A0
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl
{
	// Methods

	// RVA: -1
	public abstract bool get_IsValid() { }

	// RVA: 0x130D858
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

	// RVA: 0x130BC54
	public void Dispose() { }

	// RVA: 0x130D928
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x130D92C
	protected override void Finalize() { }

	// RVA: 0x130D9C8
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

	// RVA: 0x130D9D0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x130DB20
	public override bool get_IsValid() { }

	// RVA: 0x130DB28
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x130DB30
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x130DB38
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x130DB3C
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x130E64C
	public override void Reset() { }

	// RVA: 0x130E858
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x130EDEC
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x130EA14
	private X509Store get_LMRootStore() { }

	// RVA: 0x130EBAC
	private X509Store get_UserRootStore() { }

	// RVA: 0x130EFA8
	private X509Store get_LMCAStore() { }

	// RVA: 0x130F114
	private X509Store get_UserCAStore() { }

	// RVA: 0x130F820
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x130E25C
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x130FE40
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x130FC18
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x130FD3C
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x131021C
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x130E3FC
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x1310268
	private void Process(int n) { }

	// RVA: 0x1310688
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x1310C4C
	private void WrapUp() { }

	// RVA: 0x1310F18
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x1310ED0
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x1310170
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x13100CC
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x13114E0
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x1311358
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x13109BC
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x131157C
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x1311754
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x13121C4
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x13119D4
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x1311E9C
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x1311BA4
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0x1312528
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

	// RVA: 0x130DAF8
	public void .ctor() { }

	// RVA: 0x130F914
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x13126CC
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x13126D4
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x13126DC
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x13126E4
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x1312750
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x1312758
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x13127C4
	public DateTime get_VerificationTime() { }

	// RVA: 0x13125A8
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private string info; // 0x18

	// Methods

	// RVA: 0x130E618
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x13127CC
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x13127D4
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x13127DC
	public void set_StatusInformation(string value) { }

	// RVA: 0x130BF38
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x13127E4
	public void .ctor() { }

	// RVA: 0x131289C
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x1312C2C
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x1312EE0
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1312990
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1312DE4
	internal Byte[] Encode() { }

	// RVA: 0x13130BC
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension
{
	// Fields
	private bool _critical; // 0x20

	// Methods

	// RVA: 0x1312894
	protected void .ctor() { }

	// RVA: 0x13134C4
	public void .ctor(string oid, Byte[] rawData, bool critical) { }

	// RVA: 0x13134F0
	public bool get_Critical() { }

	// RVA: 0x13134F8
	public void set_Critical(bool value) { }

	// RVA: 0x1313500
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x13133A0
	internal string FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x1313630
	public void .ctor() { }

	// RVA: 0x13073AC
	public int get_Count() { }

	// RVA: 0x13136A8
	public bool get_IsSynchronized() { }

	// RVA: 0x13136D0
	public object get_SyncRoot() { }

	// RVA: 0x1305A78
	public X509Extension get_Item(string oid) { }

	// RVA: 0x13136D4
	public int Add(X509Extension extension) { }

	// RVA: 0x1313750
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x131110C
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x13138B8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x131394C
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1313868
	internal void .ctor(ArrayList list) { }

	// RVA: 0x13111A0
	public X509Extension get_Current() { }

	// RVA: 0x13139CC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13112A4
	public bool MoveNext() { }

	// RVA: 0x1313A84
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2
{
	// Methods

	// RVA: 0x1310DE8
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x130B8D4
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x1313B3C
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x130B79C
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x130D8A0
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

	// RVA: 0x1313B50
	public void .ctor() { }

	// RVA: 0x1313C00
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x1313F1C
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x13073D4
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x13141B0
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1314008
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x1313CF4
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1314018
	internal Byte[] Encode() { }

	// RVA: 0x131438C
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

	// RVA: 0x130F280
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x130ED44
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x1314924
	private X509Stores get_Factory() { }

	// RVA: 0x1314940
	internal X509Store get_Store() { }

	// RVA: 0x130E814
	public void Close() { }

	// RVA: 0x1314948
	public void Dispose() { }

	// RVA: 0x130F3BC
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

	// RVA: 0x131498C
	public void .ctor() { }

	// RVA: 0x1314A3C
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x1314CDC
	public void .ctor(Byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1314FB0
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1315340
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x1305DF8
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x1306234
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x131534C
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1315528
	internal static Byte FromHexChar(Char c) { }

	// RVA: 0x1315568
	internal static Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0x1315198
	internal static Byte[] FromHex(string hex) { }

	// RVA: 0x1314B30
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1314F30
	internal Byte[] Encode() { }

	// RVA: 0x1315604
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Methods

	// RVA: 0x1315878
	public void .ctor(Type type, string value) { }

	// RVA: 0x1315D7C
	public void .ctor(Char value) { }

	// RVA: 0x1315DD4
	public void .ctor(Byte value) { }

	// RVA: 0x1315E2C
	public void .ctor(Int16 value) { }

	// RVA: 0x1315E84
	public void .ctor(int value) { }

	// RVA: 0x1315EDC
	public void .ctor(Int64 value) { }

	// RVA: 0x1315F34
	public void .ctor(float value) { }

	// RVA: 0x1315F94
	public void .ctor(Double value) { }

	// RVA: 0x1315FF4
	public void .ctor(bool value) { }

	// RVA: 0x131604C
	public void .ctor(string value) { }

	// RVA: 0x1316080
	public void .ctor(object value) { }

	// RVA: 0x13160B4
	public void .ctor(SByte value) { }

	// RVA: 0x131610C
	public void .ctor(UInt16 value) { }

	// RVA: 0x1316164
	public void .ctor(UInt32 value) { }

	// RVA: 0x13161BC
	public void .ctor(UInt64 value) { }

	// RVA: 0x1316214
	public virtual object get_Value() { }

	// RVA: 0x131621C
	public override bool Equals(object obj) { }

	// RVA: 0x1316344
	public override int GetHashCode() { }

	// RVA: 0x131634C
	protected void SetValue(object value) { }

	// RVA: 0x1315B60
	internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, object conversionResult) { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x1316354
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x1316380
	public void .ctor() { }

	// RVA: 0x13163A8
	public EditorBrowsableState get_State() { }

	// RVA: 0x13163B0
	public override bool Equals(object obj) { }

	// RVA: 0x1316454
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

	// RVA: 0x131645C
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x13164C8
	protected override void Finalize() { }

	// RVA: 0x1316570
	public object get_UserSuppliedState() { }

	// RVA: 0x1316578
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1316580
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x1316670
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x1316778
	public void OperationCompleted() { }

	// RVA: 0x1316588
	private void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x1316698
	private void OperationCompletedCore() { }

	// RVA: 0x13167E8
	private void VerifyNotCompleted() { }

	// RVA: 0x1316850
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x13168C0
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x1316968
	internal void .ctor() { }

}

// Namespace: System.ComponentModel
public static class AsyncOperationManager
{
	// Methods

	// RVA: 0x13169A4
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x1316A24
	public static SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1316AB0
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

	// RVA: 0x1316AB8
	public void .ctor() { }

	// RVA: 0x1316BB8
	private void AsyncOperationCompleted(object arg) { }

	// RVA: 0x1316C58
	public bool get_CancellationPending() { }

	// RVA: 0x1316C60
	public void CancelAsync() { }

	// RVA: 0x1316CD0
	public void add_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x1316D74
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x1316E18
	public bool get_IsBusy() { }

	// RVA: 0x1316E20
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x1316E44
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x1316E68
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	// RVA: 0x1316E8C
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x1316F30
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x1316FD4
	private void ProgressReporter(object arg) { }

	// RVA: 0x1317070
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x1317078
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x1317174
	public void RunWorkerAsync() { }

	// RVA: 0x131717C
	public void RunWorkerAsync(object argument) { }

	// RVA: 0x13173D0
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x1317474
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x1317518
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x1317520
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x1317528
	public bool get_WorkerSupportsCancellation() { }

	// RVA: 0x1317530
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x1317538
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x13176D0
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13176D4
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

	// RVA: 0x13176D8
	public void .ctor(bool browsable) { }

	// RVA: 0x1317704
	public bool get_Browsable() { }

	// RVA: 0x131770C
	public override bool Equals(object obj) { }

	// RVA: 0x13178D8
	public override int GetHashCode() { }

	// RVA: 0x1317934
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13179A8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection
{
	// Methods

	// RVA: 0x1317A5C
	public void .ctor(IComponent[] components) { }

	// RVA: 0x1317AA8
	public virtual IComponent get_Item(string name) { }

	// RVA: 0x1318010
	public virtual IComponent get_Item(int index) { }

	// RVA: 0x13180AC
	public void CopyTo(IComponent[] array, int index) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string <DescriptionValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13180F0
	public void .ctor() { }

	// RVA: 0x1318134
	public void .ctor(string description) { }

	// RVA: 0x1318168
	public virtual string get_Description() { }

	// RVA: 0x1318170
	protected string get_DescriptionValue() { }

	// RVA: 0x1318178
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x1318180
	public override bool Equals(object obj) { }

	// RVA: 0x131825C
	public override int GetHashCode() { }

	// RVA: 0x1318288
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13182FC
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

	// RVA: 0x1318394
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x13183C0
	public bool get_IsDesignOnly() { }

	// RVA: 0x13183C8
	public override bool Equals(object obj) { }

	// RVA: 0x1318594
	public override int GetHashCode() { }

	// RVA: 0x13185F0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1318698
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

	// RVA: 0x131874C
	public void .ctor() { }

	// RVA: 0x131878C
	public void .ctor(string category) { }

	// RVA: 0x13187C0
	public string get_Category() { }

	// RVA: 0x13187C8
	public override bool Equals(object obj) { }

	// RVA: 0x1318868
	public override int GetHashCode() { }

	// RVA: 0x131888C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1318930
	public override object get_TypeId() { }

	// RVA: 0x1318974
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

	// RVA: 0x1318B00
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x1318B2C
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x1318B34
	public override bool Equals(object obj) { }

	// RVA: 0x1318CF0
	public override int GetHashCode() { }

	// RVA: 0x1318CF8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1318D6C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1318E50
	public void .ctor() { }

	// RVA: 0x1318E94
	public void .ctor(string displayName) { }

	// RVA: 0x1318EC8
	public virtual string get_DisplayName() { }

	// RVA: 0x1318ED0
	protected string get_DisplayNameValue() { }

	// RVA: 0x1318ED8
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x1318EE0
	public override bool Equals(object obj) { }

	// RVA: 0x1318FBC
	public override int GetHashCode() { }

	// RVA: 0x1318FE8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131905C
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

	// RVA: 0x13192AC
	public void .ctor(object key, Delegate handler, ListEntry next) { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList
{
	// Fields
	private ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Methods

	// RVA: 0x13190F4
	internal void .ctor(Component parent) { }

	// RVA: 0x1319128
	public void .ctor() { }

	// RVA: 0x1319130
	public Delegate get_Item(object key) { }

	// RVA: 0x13191C4
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x1319310
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0x131940C
	public void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x131944C
	public void Dispose() { }

	// RVA: 0x13191AC
	private ListEntry Find(object key) { }

	// RVA: 0x1319458
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

	// RVA: 0x13194B4
	public void .ctor(bool immutable) { }

	// RVA: 0x13194E0
	public bool get_Immutable() { }

	// RVA: 0x13194E8
	public override bool Equals(object obj) { }

	// RVA: 0x13196B4
	public override int GetHashCode() { }

	// RVA: 0x13196BC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1319730
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class InitializationEventAttribute
{
	// Fields
	private readonly string <EventName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13197E4
	public void .ctor(string eventName) { }

	// RVA: 0x1319818
	public string get_EventName() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException
{
	// Methods

	// RVA: 0x1319820
	public void .ctor() { }

	// RVA: 0x131982C
	public void .ctor(string message) { }

	// RVA: 0x1319834
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x131983C
	public void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x1319928
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

	// RVA: 0x1319930
	public void .ctor(bool isLocalizable) { }

	// RVA: 0x131995C
	public bool get_IsLocalizable() { }

	// RVA: 0x1319964
	public override bool Equals(object obj) { }

	// RVA: 0x1319B30
	public override int GetHashCode() { }

	// RVA: 0x1319B38
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1319BE0
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

	// RVA: 0x1319C94
	public void .ctor(bool allowMerge) { }

	// RVA: 0x1319CC0
	public bool get_AllowMerge() { }

	// RVA: 0x1319CC8
	public override bool Equals(object obj) { }

	// RVA: 0x1319E94
	public override int GetHashCode() { }

	// RVA: 0x1319E9C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1319F10
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

	// RVA: 0x1319FC4
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x1319FF0
	public bool get_IsReadOnly() { }

	// RVA: 0x1319FF8
	public override bool Equals(object value) { }

	// RVA: 0x131A1C4
	public override int GetHashCode() { }

	// RVA: 0x131A1CC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131A274
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AddingNewEventArgs
{
	// Fields
	private object <NewObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x131A328
	public void .ctor() { }

	// RVA: 0x131A3B0
	public void .ctor(object newObject) { }

	// RVA: 0x131A428
	public object get_NewObject() { }

	// RVA: 0x131A430
	public void set_NewObject(object value) { }

}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler
{
	// Methods

	// RVA: 0x131A438
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x131A55C
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x131A570
	public virtual IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x131A5CC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute
{
	// Fields
	private readonly object <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x131A5D8
	public void .ctor(Type type, string value) { }

	// RVA: 0x131A710
	public void .ctor(Char value) { }

	// RVA: 0x131A768
	public void .ctor(Byte value) { }

	// RVA: 0x131A7C0
	public void .ctor(Int16 value) { }

	// RVA: 0x131A818
	public void .ctor(int value) { }

	// RVA: 0x131A870
	public void .ctor(Int64 value) { }

	// RVA: 0x131A8C8
	public void .ctor(float value) { }

	// RVA: 0x131A928
	public void .ctor(Double value) { }

	// RVA: 0x131A988
	public void .ctor(bool value) { }

	// RVA: 0x131A9E0
	public void .ctor(string value) { }

	// RVA: 0x131AA14
	public void .ctor(object value) { }

	// RVA: 0x131AA48
	public object get_Value() { }

	// RVA: 0x131AA50
	public override bool Equals(object obj) { }

	// RVA: 0x131AB10
	public override int GetHashCode() { }

}

// Namespace: 
private class ArrayPropertyDescriptor
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x131AFD4
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x131B0A4
	public override object GetValue(object instance) { }

	// RVA: 0x131B130
	public override void SetValue(object instance, object value) { }

}

// Namespace: System.ComponentModel
public class ArrayConverter
{
	// Methods

	// RVA: 0x131AB18
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x131ACE4
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x131B094
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x131B09C
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

	// RVA: 0x131B228
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x131B3B4
	protected void .ctor() { }

	// RVA: 0x131B3BC
	public static AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x131B874
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x131B7E0
	public int get_Count() { }

	// RVA: 0x131B87C
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x131B8C4
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x131C664
	public bool Contains(Attribute attribute) { }

	// RVA: 0x131C6C8
	public bool Contains(Attribute[] attributes) { }

	// RVA: 0x131C058
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x131C768
	public IEnumerator GetEnumerator() { }

	// RVA: 0x131C790
	public bool Matches(Attribute attribute) { }

	// RVA: 0x131C840
	public bool Matches(Attribute[] attributes) { }

	// RVA: 0x131C8B8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x131C8C0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x131C8C8
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x131C8F0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x131B808
	public void CopyTo(Array array, int index) { }

	// RVA: 0x131C918
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x131C9C8
	public void .ctor(string typeName) { }

	// RVA: 0x131CA48
	public void .ctor(string typeName, string propertyName) { }

	// RVA: 0x131CB08
	public void .ctor(Type type) { }

	// RVA: 0x131CBCC
	public string get_TypeName() { }

	// RVA: 0x131CBD4
	public string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public abstract class ComponentEditor
{
	// Methods

	// RVA: 0x131CBDC
	public bool EditComponent(object component) { }

	// RVA: -1
	public abstract bool EditComponent(ITypeDescriptorContext context, object component) { }

	// RVA: 0x131CBF0
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter
{
	// Methods

	// RVA: 0x131CBF8
	internal void .ctor() { }

	// RVA: 0x131CC00
	internal virtual bool get_AllowHex() { }

	// RVA: -1
	internal abstract Type get_TargetType() { }

	// RVA: -1
	internal abstract object FromString(string value, int radix) { }

	// RVA: -1
	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: -1
	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x131CC08
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x131CC98
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x131D094
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x131D380
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

	// RVA: 0x131D3C8
	public void .ctor(bool bindable) { }

	// RVA: 0x131D3F8
	public void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x131D434
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x131D478
	public void .ctor(BindableSupport flags, BindingDirection direction) { }

	// RVA: 0x131D4C8
	public bool get_Bindable() { }

	// RVA: 0x131D4D0
	public BindingDirection get_Direction() { }

	// RVA: 0x131D4D8
	public override bool Equals(object obj) { }

	// RVA: 0x131D588
	public override int GetHashCode() { }

	// RVA: 0x131D5E4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131D680
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IList<T> list) { }

	// RVA: 0x35263A0
	private void Initialize() { }

	// RVA: 0x35251DC
	private bool get_ItemTypeHasDefaultConstructor() { }

	// RVA: 0x35267E8
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x35267E8
	public void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x35267E8
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x3525804
	private object FireAddingNew() { }

	// RVA: 0x35267E8
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x35267E8
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x35267E8
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x35251DC
	public bool get_RaiseListChangedEvents() { }

	// RVA: 0x352642C
	public void set_RaiseListChangedEvents(bool value) { }

	// RVA: 0x35263A0
	public void ResetBindings() { }

	// RVA: 0x3526518
	public void ResetItem(int position) { }

	// RVA: 0x3526588
	private void FireListChanged(ListChangedType type, int index) { }

	// RVA: 0x35263A0
	protected override void ClearItems() { }

	// RVA: 0x26AD93C
	protected override void InsertItem(int index, T item) { }

	// RVA: 0x3526518
	protected override void RemoveItem(int index) { }

	// RVA: 0x26AD93C
	protected override void SetItem(int index, T item) { }

	// RVA: 0x3526518
	public virtual void CancelNew(int itemIndex) { }

	// RVA: 0x3526518
	public virtual void EndNew(int itemIndex) { }

	// RVA: 0x26AD93C
	public T AddNew() { }

	// RVA: 0x3525804
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x35251DC
	private bool get_AddingNewHandled() { }

	// RVA: 0x3525804
	protected virtual object AddNewCore() { }

	// RVA: 0x35251DC
	public bool get_AllowNew() { }

	// RVA: 0x352642C
	public void set_AllowNew(bool value) { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x35251DC
	public bool get_AllowEdit() { }

	// RVA: 0x352642C
	public void set_AllowEdit(bool value) { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x35251DC
	public bool get_AllowRemove() { }

	// RVA: 0x352642C
	public void set_AllowRemove(bool value) { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x35251DC
	protected virtual bool get_SupportsChangeNotificationCore() { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x35251DC
	protected virtual bool get_SupportsSearchingCore() { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x35251DC
	protected virtual bool get_SupportsSortingCore() { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x35251DC
	protected virtual bool get_IsSortedCore() { }

	// RVA: 0x3525804
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x3525804
	protected virtual PropertyDescriptor get_SortPropertyCore() { }

	// RVA: 0x35254D0
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x35254D0
	protected virtual ListSortDirection get_SortDirectionCore() { }

	// RVA: 0x3526850
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x3526850
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x35263A0
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x35263A0
	protected virtual void RemoveSortCore() { }

	// RVA: -1
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }

	// RVA: -1
	protected virtual int FindCore(PropertyDescriptor prop, object key) { }

	// RVA: 0x35267E8
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }

	// RVA: 0x35267E8
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }

	// RVA: 0x26AD93C
	private void HookPropertyChanged(T item) { }

	// RVA: 0x26AD93C
	private void UnhookPropertyChanged(T item) { }

	// RVA: 0x35269D4
	private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x35251DC
	private bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter
{
	// Fields
	private static StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x131D73C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x131D7CC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x131D968
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x131DB08
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x131DB10
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x131DB18
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter
{
	// Methods

	// RVA: 0x131DB20
	internal override Type get_TargetType() { }

	// RVA: 0x131DB70
	internal override object FromString(string value, int radix) { }

	// RVA: 0x131DC00
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x131DC40
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x131DCEC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler
{
	// Methods

	// RVA: 0x131DCF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x131DE18
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x131DE2C
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x131DE88
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CharConverter
{
	// Methods

	// RVA: 0x131DE94
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x131DF24
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x131E028
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x131E15C
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

	// RVA: 0x131E164
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x131E1EC
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x131E1F4
	public virtual object get_Element() { }

}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler
{
	// Methods

	// RVA: 0x131E1FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x131E320
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x131E334
	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x131E390
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

	// RVA: 0x131E39C
	public void .ctor() { }

	// RVA: 0x131E3A4
	public void .ctor(string dataSource) { }

	// RVA: 0x131E3D8
	public void .ctor(string dataSource, string dataMember) { }

	// RVA: 0x131E428
	public string get_DataSource() { }

	// RVA: 0x131E430
	public string get_DataMember() { }

	// RVA: 0x131E438
	public override bool Equals(object obj) { }

	// RVA: 0x131E4D0
	public override int GetHashCode() { }

	// RVA: 0x131E4D8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentResourceManager
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Methods

	// RVA: 0x131E544
	public void .ctor() { }

	// RVA: 0x131E5CC
	public void .ctor(Type t) { }

	// RVA: 0x131E638
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x131E6E0
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x131E6F0
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x131F618
	private System.Collections.Generic.SortedList<System.String,System.Object> FillResources(CultureInfo culture, ResourceSet resourceSet) { }

}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService
{
	// Methods

	// RVA: 0x131FBB4
	protected void .ctor() { }

	// RVA: 0x131FBBC
	public virtual ComponentCollection FilterComponents(ComponentCollection components) { }

}

// Namespace: 
private class CultureComparer
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x1320EF4
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x1320F40
	public int Compare(object item1, object item2) { }

}

// Namespace: 
private static class CultureInfoMapper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x13210B4
	private static System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }

	// RVA: 0x132072C
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x1325198
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class CultureInfoConverter
{
	// Fields
	private StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Methods

	// RVA: 0x131FBC4
	private string get_DefaultCultureString() { }

	// RVA: 0x131FC08
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x131FC30
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x131FCC0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x131FD80
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x13207F4
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1320CA4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1320F28
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1320F30
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1320F38
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x13251F4
	protected void .ctor() { }

	// RVA: 0x13251FC
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x1325230
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x1325330
	public virtual string GetClassName() { }

	// RVA: 0x13253F4
	public virtual string GetComponentName() { }

	// RVA: 0x13254B8
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x13255A4
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x1325668
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x132572C
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x13257F4
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x13258F8
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x1325A04
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1325B08
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x1325C14
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

	// RVA: 0x1325CDC
	public void .ctor() { }

	// RVA: 0x1325D08
	public void .ctor(bool isDataObject) { }

	// RVA: 0x1325D34
	public bool get_IsDataObject() { }

	// RVA: 0x1325D3C
	public override bool Equals(object obj) { }

	// RVA: 0x1325DEC
	public override int GetHashCode() { }

	// RVA: 0x1325E48
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1325EBC
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

	// RVA: 0x1325F70
	public void .ctor(bool primaryKey) { }

	// RVA: 0x1325FFC
	public void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x1326044
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x1325FA8
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	// RVA: 0x1326090
	public bool get_IsIdentity() { }

	// RVA: 0x1326098
	public bool get_IsNullable() { }

	// RVA: 0x13260A0
	public int get_Length() { }

	// RVA: 0x13260A8
	public bool get_PrimaryKey() { }

	// RVA: 0x13260B0
	public override bool Equals(object obj) { }

	// RVA: 0x13261B0
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectMethodAttribute
{
	// Fields
	private readonly bool <IsDefault>k__BackingField; // 0x10
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Methods

	// RVA: 0x13261B8
	public void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x13261E8
	public void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	// RVA: 0x1326224
	public bool get_IsDefault() { }

	// RVA: 0x132622C
	public DataObjectMethodType get_MethodType() { }

	// RVA: 0x1326234
	public override bool Equals(object obj) { }

	// RVA: 0x13262F4
	public override int GetHashCode() { }

	// RVA: 0x1326360
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

	// RVA: 0x1326404
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1326494
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1326554
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1326874
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1326C88
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DecimalConverter
{
	// Methods

	// RVA: 0x1326C90
	internal override bool get_AllowHex() { }

	// RVA: 0x1326C98
	internal override Type get_TargetType() { }

	// RVA: 0x1326D28
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1326DE8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1327148
	internal override object FromString(string value, int radix) { }

	// RVA: 0x132723C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13272F4
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13273E8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultBindingPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x13273F0
	public void .ctor() { }

	// RVA: 0x13273F8
	public void .ctor(string name) { }

	// RVA: 0x132742C
	public string get_Name() { }

	// RVA: 0x1327434
	public override bool Equals(object obj) { }

	// RVA: 0x13274B8
	public override int GetHashCode() { }

	// RVA: 0x13274C0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Methods

	// RVA: 0x132752C
	public void .ctor(string name) { }

	// RVA: 0x1327560
	public string get_Name() { }

	// RVA: 0x1327568
	public override bool Equals(object obj) { }

	// RVA: 0x13275EC
	public override int GetHashCode() { }

	// RVA: 0x13275F4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x1327670
	public void .ctor(string name) { }

	// RVA: 0x13276A4
	public string get_Name() { }

	// RVA: 0x13276AC
	public override bool Equals(object obj) { }

	// RVA: 0x1327730
	public override int GetHashCode() { }

	// RVA: 0x1327738
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider
{
	// Fields
	private readonly Type _type; // 0x20

	// Methods

	// RVA: 0x13277B4
	internal void .ctor(Type type) { }

	// RVA: 0x13277F0
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x1327880
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x132794C
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x13279F0
	public override string GetFullComponentName(object component) { }

	// RVA: 0x1327A94
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1327B38
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1327BDC
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1327C90
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x1327D34
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1327DE8
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

	// RVA: 0x1327E8C
	public void .ctor() { }

	// RVA: 0x1327F34
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	// RVA: 0x1327F60
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x1327F68
	public override bool Equals(object value) { }

	// RVA: 0x132800C
	public override int GetHashCode() { }

	// RVA: 0x1328014
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1328088
	public override string ToString() { }

	// RVA: 0x132817C
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

	// RVA: 0x1328264
	public void .ctor() { }

	// RVA: 0x13283F8
	public void .ctor(Type tabClass) { }

	// RVA: 0x1328590
	public void .ctor(string tabClassName) { }

	// RVA: 0x1328400
	public void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x1328598
	public void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x1328704
	public Type[] get_TabClasses() { }

	// RVA: 0x1328A58
	protected string[] get_TabClassNames() { }

	// RVA: 0x1328AD0
	public PropertyTabScope[] get_TabScopes() { }

	// RVA: 0x1328AD8
	private void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x1328AE0
	public override bool Equals(object other) { }

	// RVA: 0x1328B7C
	public bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x1328D14
	public override int GetHashCode() { }

	// RVA: 0x1328D1C
	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x1329064
	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x1328D28
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

	// RVA: 0x1329074
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13290E8
	public void .ctor(bool defaultType) { }

	// RVA: 0x1329164
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1329220
	public void .ctor(Type toolboxItemType) { }

	// RVA: 0x1329280
	public Type get_ToolboxItemType() { }

	// RVA: 0x1329440
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x1329464
	public override bool Equals(object obj) { }

	// RVA: 0x132956C
	public override int GetHashCode() { }

	// RVA: 0x1329590
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

	// RVA: 0x1329664
	public void .ctor(bool visible) { }

	// RVA: 0x1329690
	public void .ctor() { }

	// RVA: 0x1329698
	public bool get_Visible() { }

	// RVA: 0x13296A0
	public override bool Equals(object obj) { }

	// RVA: 0x1329750
	public override int GetHashCode() { }

	// RVA: 0x132980C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13298B4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter
{
	// Methods

	// RVA: 0x1329968
	internal override bool get_AllowHex() { }

	// RVA: 0x1329970
	internal override Type get_TargetType() { }

	// RVA: 0x13299C0
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1329AAC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1329AEC
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1329B98
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

	// RVA: 0x1329BA0
	public void .ctor() { }

	// RVA: 0x1329BF8
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x1329CD0
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x1329DC4
	public void .ctor(Type type, Type baseType) { }

	// RVA: 0x1329E48
	public string get_EditorBaseTypeName() { }

	// RVA: 0x1329E50
	public string get_EditorTypeName() { }

	// RVA: 0x1329E58
	public override object get_TypeId() { }

	// RVA: 0x1329F14
	public override bool Equals(object obj) { }

	// RVA: 0x1329FDC
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor
{
	// Methods

	// RVA: 0x1329FE4
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x1329FEC
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x1329FF4
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

	// RVA: 0x132AEC8
	public void .ctor(Array array, int count) { }

	// RVA: 0x132B7A8
	public bool MoveNext() { }

	// RVA: 0x132B7CC
	public void Reset() { }

	// RVA: 0x132B7D8
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

	// RVA: 0x1329FFC
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x132A12C
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x132A154
	private void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x132A274
	public int get_Count() { }

	// RVA: 0x132A27C
	private void set_Count(int value) { }

	// RVA: 0x132A284
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x132A3D4
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x132A3E8
	public int Add(EventDescriptor value) { }

	// RVA: 0x132A5DC
	public void Clear() { }

	// RVA: 0x132A634
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x132A708
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x132A30C
	private void EnsureEventsOwned() { }

	// RVA: 0x132A4BC
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x132AA70
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x132A6A4
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x132AB98
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x132AC8C
	public void Remove(EventDescriptor value) { }

	// RVA: 0x132AD50
	public void RemoveAt(int index) { }

	// RVA: 0x132AE18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x132AF14
	public virtual EventDescriptorCollection Sort() { }

	// RVA: 0x132AF98
	public virtual EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x132B020
	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x132B0A8
	public virtual EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x132A750
	protected void InternalSort(string[] names) { }

	// RVA: 0x132B12C
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x132B1CC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x132B1D4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x132B1DC
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x132B1E4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x132B1E8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x132B1F8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x132B37C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x132B40C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x132B4DC
	private void System.Collections.IList.Clear() { }

	// RVA: 0x132B534
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x132B5F8
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x132B690
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x132B720
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x132B724
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x132B72C
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x132B734
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter
{
	// Methods

	// RVA: 0x132B840
	public void .ctor() { }

	// RVA: 0x132B848
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x132B8B4
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Methods

	// RVA: 0x132B8BC
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x132BB4C
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x132BC88
	public override bool CanResetValue(object comp) { }

	// RVA: 0x132BCB4
	public override Type get_ComponentType() { }

	// RVA: 0x132BCDC
	public override bool get_IsReadOnly() { }

	// RVA: 0x132BDC4
	public override Type get_PropertyType() { }

	// RVA: 0x132BDEC
	public override string get_DisplayName() { }

	// RVA: 0x132BFCC
	public override object GetValue(object comp) { }

	// RVA: 0x132BFF8
	public override void ResetValue(object comp) { }

	// RVA: 0x132C024
	public override void SetValue(object component, object value) { }

	// RVA: 0x132C054
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

	// RVA: 0x132BAA0
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x132C080
	public void .ctor() { }

	// RVA: 0x132C088
	public PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0x132C090
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	// RVA: 0x132C098
	public IExtenderProvider get_Provider() { }

	// RVA: 0x132C0A0
	private void set_Provider(IExtenderProvider value) { }

	// RVA: 0x132C0A8
	public Type get_ReceiverType() { }

	// RVA: 0x132C0B0
	private void set_ReceiverType(Type value) { }

	// RVA: 0x132C0B8
	public override bool Equals(object obj) { }

	// RVA: 0x132C1B4
	public override int GetHashCode() { }

	// RVA: 0x132C1BC
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter
{
	// Methods

	// RVA: 0x132C214
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x132C2A4
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x132C364
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x132C448
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x132C798
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class HandledEventArgs
{
	// Fields
	private bool <Handled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x132C7A0
	public void .ctor() { }

	// RVA: 0x132C80C
	public void .ctor(bool defaultHandledValue) { }

	// RVA: 0x132C87C
	public bool get_Handled() { }

	// RVA: 0x132C884
	public void set_Handled(bool value) { }

}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler
{
	// Methods

	// RVA: 0x132C88C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x132C9B0
	public virtual void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x132C9C4
	public virtual IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x132CA20
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

	// RVA: 0x132CA2C
	public void .ctor(Type installerType) { }

	// RVA: 0x132CA7C
	public void .ctor(string typeName) { }

	// RVA: 0x132CAB0
	public virtual Type get_InstallerType() { }

	// RVA: 0x132CB38
	public override bool Equals(object obj) { }

	// RVA: 0x132CBF4
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor
{
	// Methods

	// RVA: 0x132CBFC
	public virtual string get_Text() { }

	// RVA: -1
	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType) { }

	// RVA: 0x132CC40
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int16Converter
{
	// Methods

	// RVA: 0x132CC48
	internal override Type get_TargetType() { }

	// RVA: 0x132CC98
	internal override object FromString(string value, int radix) { }

	// RVA: 0x132CD28
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132CD68
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132CE14
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter
{
	// Methods

	// RVA: 0x132CE1C
	internal override Type get_TargetType() { }

	// RVA: 0x132CE6C
	internal override object FromString(string value, int radix) { }

	// RVA: 0x132CEFC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132CF3C
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132CFE8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter
{
	// Methods

	// RVA: 0x132CFF0
	internal override Type get_TargetType() { }

	// RVA: 0x132D040
	internal override object FromString(string value, int radix) { }

	// RVA: 0x132D0D0
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132D110
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x132D1BC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidAsynchronousStateException
{
	// Methods

	// RVA: 0x132D1C4
	public void .ctor() { }

	// RVA: 0x132D1D0
	public void .ctor(string message) { }

	// RVA: 0x132D1D8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x132D1E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private class LicFileLicense
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x132D744
	public void .ctor(LicFileLicenseProvider owner, string key) { }

	// RVA: 0x132D7AC
	public override string get_LicenseKey() { }

	// RVA: 0x132D7B4
	public override void Dispose() { }

}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider
{
	// Methods

	// RVA: 0x132D1E8
	protected virtual bool IsKeyValid(string key, Type type) { }

	// RVA: 0x132D230
	protected virtual string GetKey(Type type) { }

	// RVA: 0x132D2F0
	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x132D794
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

	// RVA: 0x132D7A4
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class LicenseContext
{
	// Methods

	// RVA: 0x132D83C
	public virtual LicenseUsageMode get_UsageMode() { }

	// RVA: 0x132D844
	public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x132D84C
	public virtual object GetService(Type type) { }

	// RVA: 0x132D854
	public virtual void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x132D858
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

	// RVA: 0x132D860
	private void .ctor() { }

	// RVA: 0x132D868
	public static LicenseContext get_CurrentContext() { }

	// RVA: 0x132DA58
	public static void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x132DBF8
	public static LicenseUsageMode get_UsageMode() { }

	// RVA: 0x132DCBC
	private static void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x132DEE4
	public static object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x132DFE4
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x132E450
	private static bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x132E52C
	private static LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x132E62C
	private static LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x132E72C
	public static bool IsLicensed(Type type) { }

	// RVA: 0x132E8C8
	public static bool IsValid(Type type) { }

	// RVA: 0x132E9CC
	public static bool IsValid(Type type, object instance, License license) { }

	// RVA: 0x132E2C0
	public static void LockContext(object contextUser) { }

	// RVA: 0x132EABC
	public static void UnlockContext(object contextUser) { }

	// RVA: 0x132E830
	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, License license) { }

	// RVA: 0x132EC50
	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, License license, string licenseKey) { }

	// RVA: 0x132F100
	public static void Validate(Type type) { }

	// RVA: 0x132F238
	public static License Validate(Type type, object instance) { }

	// RVA: 0x132F368
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class LicenseProvider
{
	// Methods

	// RVA: -1
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x132D79C
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

	// RVA: 0x132F418
	public void .ctor() { }

	// RVA: 0x132F448
	public void .ctor(string typeName) { }

	// RVA: 0x132F47C
	public void .ctor(Type type) { }

	// RVA: 0x132F008
	public Type get_LicenseProvider() { }

	// RVA: 0x132F4B0
	public override object get_TypeId() { }

	// RVA: 0x132F56C
	public override bool Equals(object value) { }

	// RVA: 0x132F6A4
	public override int GetHashCode() { }

	// RVA: 0x132F6AC
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

	// RVA: 0x132F728
	public void .ctor(bool listBindable) { }

	// RVA: 0x132F754
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x132F794
	public bool get_ListBindable() { }

	// RVA: 0x132F79C
	public override bool Equals(object obj) { }

	// RVA: 0x132F84C
	public override int GetHashCode() { }

	// RVA: 0x132F854
	public override bool IsDefaultAttribute() { }

	// RVA: 0x132F8F0
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

	// RVA: 0x132F9A4
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x132FAAC
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x132FB48
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x132FA28
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x132FBD0
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x132FBD8
	public int get_NewIndex() { }

	// RVA: 0x132FBE0
	public int get_OldIndex() { }

	// RVA: 0x132FBE8
	public PropertyDescriptor get_PropertyDescriptor() { }

}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler
{
	// Methods

	// RVA: 0x132FBF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x132FD14
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x132FD28
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x132FD84
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

	// RVA: 0x132FD90
	public void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x132FDD8
	public PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x132FDE0
	public void set_PropertyDescriptor(PropertyDescriptor value) { }

	// RVA: 0x132FDE8
	public ListSortDirection get_SortDirection() { }

	// RVA: 0x132FDF0
	public void set_SortDirection(ListSortDirection value) { }

}

// Namespace: System.ComponentModel
public class ListSortDescriptionCollection
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Methods

	// RVA: 0x132FDF8
	public void .ctor() { }

	// RVA: 0x132FE70
	public void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x132FF3C
	public ListSortDescription get_Item(int index) { }

	// RVA: 0x132FFE0
	public void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x1330034
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x133003C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1330044
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x13300E8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x133013C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1330190
	private void System.Collections.IList.Clear() { }

	// RVA: 0x13301E4
	public bool Contains(object value) { }

	// RVA: 0x133029C
	public int IndexOf(object value) { }

	// RVA: 0x1330354
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13303A8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x13303FC
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1330450
	public int get_Count() { }

	// RVA: 0x1330478
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1330480
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1330484
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13304AC
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

	// RVA: 0x13304D4
	public void .ctor() { }

	// RVA: 0x1330534
	public void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	// RVA: 0x13305B4
	public string get_DataSource() { }

	// RVA: 0x13305BC
	public string get_DisplayMember() { }

	// RVA: 0x13305C4
	public string get_ValueMember() { }

	// RVA: 0x13305CC
	public string get_LookupMember() { }

	// RVA: 0x13305D4
	public override bool Equals(object obj) { }

	// RVA: 0x1330694
	public override int GetHashCode() { }

	// RVA: 0x133069C
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

	// RVA: 0x1330748
	public void .ctor() { }

	// RVA: 0x1330750
	protected override void Finalize() { }

	// RVA: 0x13307EC
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x1330978
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x13308EC
	protected EventHandlerList get_Events() { }

	// RVA: 0x1330A78
	public virtual ISite get_Site() { }

	// RVA: 0x1330A80
	public virtual void set_Site(ISite value) { }

	// RVA: 0x1330A88
	public void Dispose() { }

	// RVA: 0x1330B18
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1330DC4
	public virtual IContainer get_Container() { }

	// RVA: 0x1330E88
	public virtual object GetService(Type service) { }

	// RVA: 0x1330F4C
	public virtual bool get_DesignMode() { }

	// RVA: 0x1331010
	public override string ToString() { }

	// RVA: 0x1331150
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

	// RVA: 0x1331BA0
	public void .ctor(int maskPos, CharType charType) { }

	// RVA: 0x1337948
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

	// RVA: 0x13311D8
	public void .ctor(string mask) { }

	// RVA: 0x1331630
	public void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x1331648
	public void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x133165C
	public void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x1331670
	public void .ctor(string mask, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x1331684
	public void .ctor(string mask, CultureInfo culture, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x13311F0
	public void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, Char promptChar, Char passwordChar, bool restrictToAscii) { }

	// RVA: 0x1331760
	private void Initialize() { }

	// RVA: 0x1331C04
	public bool get_AllowPromptAsInput() { }

	// RVA: 0x1331C78
	public int get_AssignedEditPositionCount() { }

	// RVA: 0x1331C80
	private void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x1331C88
	public int get_AvailableEditPositionCount() { }

	// RVA: 0x1331CA8
	public object Clone() { }

	// RVA: 0x1332AF8
	public CultureInfo get_Culture() { }

	// RVA: 0x1332B00
	public static Char get_DefaultPasswordChar() { }

	// RVA: 0x1331C9C
	public int get_EditPositionCount() { }

	// RVA: 0x1332B08
	public IEnumerator get_EditPositions() { }

	// RVA: 0x1332918
	public bool get_IncludeLiterals() { }

	// RVA: 0x133298C
	public void set_IncludeLiterals(bool value) { }

	// RVA: 0x1332A08
	public bool get_IncludePrompt() { }

	// RVA: 0x1332A7C
	public void set_IncludePrompt(bool value) { }

	// RVA: 0x13325A8
	public bool get_AsciiOnly() { }

	// RVA: 0x1332E0C
	public bool get_IsPassword() { }

	// RVA: 0x1332E1C
	public void set_IsPassword(bool value) { }

	// RVA: 0x1332ED8
	public static int get_InvalidIndex() { }

	// RVA: 0x1332EE0
	public int get_LastAssignedPosition() { }

	// RVA: 0x1333038
	public int get_Length() { }

	// RVA: 0x1333058
	public string get_Mask() { }

	// RVA: 0x1333060
	public bool get_MaskCompleted() { }

	// RVA: 0x1333070
	public bool get_MaskFull() { }

	// RVA: 0x1333088
	public Char get_PasswordChar() { }

	// RVA: 0x1333090
	public void set_PasswordChar(Char value) { }

	// RVA: 0x1333270
	public Char get_PromptChar() { }

	// RVA: 0x1333278
	public void set_PromptChar(Char value) { }

	// RVA: 0x13327BC
	public bool get_ResetOnPrompt() { }

	// RVA: 0x133261C
	public void set_ResetOnPrompt(bool value) { }

	// RVA: 0x1332830
	public bool get_ResetOnSpace() { }

	// RVA: 0x1332698
	public void set_ResetOnSpace(bool value) { }

	// RVA: 0x13328A4
	public bool get_SkipLiterals() { }

	// RVA: 0x1332714
	public void set_SkipLiterals(bool value) { }

	// RVA: 0x1333514
	public Char get_Item(int index) { }

	// RVA: 0x13335D4
	public bool Add(Char input) { }

	// RVA: 0x13335FC
	public bool Add(Char input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x13338B8
	public bool Add(string input) { }

	// RVA: 0x13338E4
	public bool Add(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1333A04
	public void Clear() { }

	// RVA: 0x1333A60
	public void Clear(MaskedTextResultHint resultHint) { }

	// RVA: 0x1332FB0
	public int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1333BA0
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x133379C
	public int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1333D58
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x1333BB8
	private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, Byte assignedStatus) { }

	// RVA: 0x1333EB0
	public int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1333F14
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x1333D60
	private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags) { }

	// RVA: 0x1333F1C
	public int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1333F80
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x133410C
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x1334118
	public bool InsertAt(Char input, int position) { }

	// RVA: 0x13341E4
	public bool InsertAt(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x13341B8
	public bool InsertAt(string input, int position) { }

	// RVA: 0x133425C
	public bool InsertAt(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1334340
	private bool InsertAtInt(string input, int position, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x13350D4
	private static bool IsAscii(Char c) { }

	// RVA: 0x13350E4
	private static bool IsAciiAlphanumeric(Char c) { }

	// RVA: 0x1335110
	private static bool IsAlphanumeric(Char c) { }

	// RVA: 0x13351A0
	private static bool IsAsciiLetter(Char c) { }

	// RVA: 0x13351B4
	public bool IsAvailablePosition(int position) { }

	// RVA: 0x1333430
	public bool IsEditPosition(int position) { }

	// RVA: 0x1331BDC
	private static bool IsEditPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x13352A4
	private static bool IsLiteralPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x1331698
	private static bool IsPrintableChar(Char c) { }

	// RVA: 0x13352CC
	public static bool IsValidInputChar(Char c) { }

	// RVA: 0x133534C
	public static bool IsValidMaskChar(Char c) { }

	// RVA: 0x1333204
	public static bool IsValidPasswordChar(Char c) { }

	// RVA: 0x13353CC
	public bool Remove() { }

	// RVA: 0x1335404
	public bool Remove(int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1335468
	public bool RemoveAt(int position) { }

	// RVA: 0x13354D8
	public bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x1335570
	public bool RemoveAt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1335618
	private bool RemoveAtInt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x1332790
	public bool Replace(Char input, int position) { }

	// RVA: 0x1335C40
	public bool Replace(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1335E7C
	public bool Replace(Char input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x13363C4
	public bool Replace(string input, int position) { }

	// RVA: 0x13363F0
	public bool Replace(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1336020
	public bool Replace(string input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1333ACC
	private void ResetChar(int testPosition) { }

	// RVA: 0x1335A10
	private void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x1336538
	public bool Set(string input) { }

	// RVA: 0x1336564
	public bool Set(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1334EF8
	private void SetChar(Char input, int position) { }

	// RVA: 0x133675C
	private void SetChar(Char input, int position, CharDescriptor charDescriptor) { }

	// RVA: 0x1334F84
	private void SetString(string input, int testPosition) { }

	// RVA: 0x1334940
	private bool TestChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x1335DF0
	private bool TestEscapeChar(Char input, int position) { }

	// RVA: 0x1336948
	private bool TestEscapeChar(Char input, int position, CharDescriptor charDex) { }

	// RVA: 0x1333800
	private bool TestSetChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x13339B8
	private bool TestSetString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1334764
	private bool TestString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1336B28
	public string ToDisplayString() { }

	// RVA: 0x1336D60
	public override string ToString() { }

	// RVA: 0x133730C
	public string ToString(bool ignorePasswordChar) { }

	// RVA: 0x133740C
	public string ToString(int startPosition, int length) { }

	// RVA: 0x1337500
	public string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x13375F8
	public string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x1337650
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x1336E5C
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x1337668
	public bool VerifyChar(Char input, int position, MaskedTextResultHint hint) { }

	// RVA: 0x13376EC
	public bool VerifyEscapeChar(Char input, int position) { }

	// RVA: 0x13377AC
	public bool VerifyString(string input) { }

	// RVA: 0x13377F8
	public bool VerifyString(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1337828
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

	// RVA: 0x1337B80
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1337D08
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1337D10
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1337D18
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

	// RVA: 0x1338214
	internal void .ctor(IComponent component, NestedContainer container, string name) { }

	// RVA: 0x133843C
	public IComponent get_Component() { }

	// RVA: 0x1338444
	public IContainer get_Container() { }

	// RVA: 0x133844C
	public object GetService(Type service) { }

	// RVA: 0x1338548
	public bool get_DesignMode() { }

	// RVA: 0x1338744
	public string get_FullName() { }

	// RVA: 0x1338848
	public string get_Name() { }

	// RVA: 0x1338850
	public void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class NestedContainer
{
	// Fields
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Methods

	// RVA: 0x1337D20
	public void .ctor(IComponent owner) { }

	// RVA: 0x1337E90
	public IComponent get_Owner() { }

	// RVA: 0x1337E98
	protected virtual string get_OwnerName() { }

	// RVA: 0x133812C
	protected override ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x1338278
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1338388
	protected override object GetService(Type service) { }

	// RVA: 0x1338434
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

	// RVA: 0x1338928
	public void .ctor(Type type) { }

	// RVA: 0x1338A6C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1338B28
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1338C68
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1338D24
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1338EFC
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x1338F20
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1338F44
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1338F68
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1338F8C
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1339344
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x133936C
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1339394
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x13393C8
	public Type get_NullableType() { }

	// RVA: 0x13393D0
	public Type get_UnderlyingType() { }

	// RVA: 0x13393D8
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

	// RVA: 0x13393E0
	public void .ctor() { }

	// RVA: 0x1339408
	public void .ctor(bool password) { }

	// RVA: 0x1339434
	public bool get_Password() { }

	// RVA: 0x133943C
	public override bool Equals(object o) { }

	// RVA: 0x13394D0
	public override int GetHashCode() { }

	// RVA: 0x13394D8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x133954C
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

	// RVA: 0x1339600
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x1339608
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x132BA98
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: 0x1339610
	public virtual TypeConverter get_Converter() { }

	// RVA: 0x1339CE4
	public virtual bool get_IsLocalizable() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x1339DCC
	public DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: -1
	public abstract Type get_PropertyType() { }

	// RVA: 0x1339EA0
	public virtual void AddValueChanged(object component, EventHandler handler) { }

	// RVA: -1
	public abstract bool CanResetValue(object component) { }

	// RVA: 0x133A008
	public override bool Equals(object obj) { }

	// RVA: 0x1339ABC
	protected object CreateInstance(Type type) { }

	// RVA: 0x133A210
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x133A26C
	public PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x133A284
	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x133A29C
	public PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x133A2B0
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x133A368
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x133A780
	public override int GetHashCode() { }

	// RVA: 0x133A7D8
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x13398A4
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1
	public abstract object GetValue(object component) { }

	// RVA: 0x133A8D0
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x133A984
	public virtual void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x133AAFC
	protected internal EventHandler GetValueChangedHandler(object component) { }

	// RVA: -1
	public abstract void ResetValue(object component) { }

	// RVA: -1
	public abstract void SetValue(object component, object value) { }

	// RVA: -1
	public abstract bool ShouldSerializeValue(object component) { }

	// RVA: 0x133AB98
	public virtual bool get_SupportsChangeEvents() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x133C4B0
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x133D1DC
	public object get_Current() { }

	// RVA: 0x133D288
	public DictionaryEntry get_Entry() { }

	// RVA: 0x133D2FC
	public object get_Key() { }

	// RVA: 0x133D33C
	public object get_Value() { }

	// RVA: 0x133D37C
	public bool MoveNext() { }

	// RVA: 0x133D3BC
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

	// RVA: 0x133ABA0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x133ACF4
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x133AD1C
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x133AE74
	public int get_Count() { }

	// RVA: 0x133AE7C
	private void set_Count(int value) { }

	// RVA: 0x133AE84
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x133AFD4
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x133AFE8
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x133B1DC
	public void Clear() { }

	// RVA: 0x133B23C
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x133B310
	public void CopyTo(Array array, int index) { }

	// RVA: 0x133AF0C
	private void EnsurePropsOwned() { }

	// RVA: 0x133B0BC
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x133B678
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x133B2AC
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x133BC4C
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x133BD40
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x133BE04
	public void RemoveAt(int index) { }

	// RVA: 0x133BECC
	public virtual PropertyDescriptorCollection Sort() { }

	// RVA: 0x133BF50
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x133BFD8
	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x133C060
	public virtual PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x133B358
	protected void InternalSort(string[] names) { }

	// RVA: 0x133C0E4
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x133C184
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x133C220
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x133C228
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x133C230
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x133C238
	private void System.Collections.IList.Clear() { }

	// RVA: 0x133C298
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x133C2F8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x133C308
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x133C30C
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x133C3DC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x133C434
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x133C4EC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x133C4F4
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x133C4FC
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x133C530
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x133C904
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x133CA04
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x133CB08
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x133CC00
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x133CC90
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x133CD60
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x133CE24
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x133CEBC
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x133CEC4
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x133CECC
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x133CF5C
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x133CF6C
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x133D168
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute
{
	// Fields
	private readonly string <PropertyName>k__BackingField; // 0x10
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x133D3C8
	public void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x133D434
	public void .ctor(string propertyName, string receiverTypeName) { }

	// RVA: 0x133D484
	public string get_PropertyName() { }

	// RVA: 0x133D48C
	public string get_ReceiverTypeName() { }

	// RVA: 0x133D494
	public override bool Equals(object obj) { }

	// RVA: 0x133D55C
	public override int GetHashCode() { }

	// RVA: 0x133D5AC
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

	// RVA: 0x133D5F0
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x133D61C
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x133D624
	public override bool Equals(object obj) { }

	// RVA: 0x133D6F0
	public override int GetHashCode() { }

	// RVA: 0x133D6F8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x133D708
	private static void .cctor() { }

}

// Namespace: 
private class ReferenceComparer
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x133E800
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x133E8C4
	public int Compare(object item1, object item2) { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x133D7BC
	public void .ctor(Type type) { }

	// RVA: 0x133D7F0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x133D884
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x133DBF8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x133E0C0
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x133E834
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x133E83C
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x133E844
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x133E84C
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

	// RVA: 0x133E978
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x133EB18
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x133ECD8
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x133EDD4
	public override Type get_ComponentType() { }

	// RVA: 0x133EDDC
	public override Type get_EventType() { }

	// RVA: 0x133F338
	public override bool get_IsMulticast() { }

	// RVA: 0x133F3E0
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x133FB80
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x133FC00
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x133EE00
	private void FillMethods() { }

	// RVA: 0x133FF58
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x13402F0
	public override void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs
{
	// Fields
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13409E0
	public void .ctor(object componentChanged) { }

	// RVA: 0x1340A7C
	public void .ctor(Type typeChanged) { }

	// RVA: 0x1340AF4
	public object get_ComponentChanged() { }

	// RVA: 0x1340AFC
	public Type get_TypeChanged() { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler
{
	// Methods

	// RVA: 0x1340B04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1340C24
	public virtual void Invoke(RefreshEventArgs e) { }

	// RVA: 0x1340C38
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1340C88
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

	// RVA: 0x1340C94
	public void .ctor(bool runInstaller) { }

	// RVA: 0x1340CC0
	public bool get_RunInstaller() { }

	// RVA: 0x1340CC8
	public override bool Equals(object obj) { }

	// RVA: 0x1340D94
	public override int GetHashCode() { }

	// RVA: 0x1340D9C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1340E10
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SByteConverter
{
	// Methods

	// RVA: 0x1340EC4
	internal override Type get_TargetType() { }

	// RVA: 0x1340F14
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1340FA4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1340FE4
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1341090
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

	// RVA: 0x1341098
	public void .ctor(bool bindable) { }

	// RVA: 0x13410C4
	public bool get_Bindable() { }

	// RVA: 0x13410CC
	public override bool Equals(object obj) { }

	// RVA: 0x134117C
	public override int GetHashCode() { }

	// RVA: 0x13411D8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter
{
	// Methods

	// RVA: 0x1341278
	internal override bool get_AllowHex() { }

	// RVA: 0x1341280
	internal override Type get_TargetType() { }

	// RVA: 0x13412D0
	internal override object FromString(string value, int radix) { }

	// RVA: 0x13413BC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13413FC
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13414A8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter
{
	// Methods

	// RVA: 0x13414B0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1341540
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1341574
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public static class SyntaxCheck
{
	// Methods

	// RVA: 0x134157C
	public static bool CheckMachineName(string value) { }

	// RVA: 0x13415F4
	public static bool CheckPath(string value) { }

	// RVA: 0x1341690
	public static bool CheckRootedPath(string value) { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter
{
	// Methods

	// RVA: 0x134174C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x13417DC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x134189C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1341A88
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1341DB4
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

	// RVA: 0x1341DBC
	public void .ctor(string filterString) { }

	// RVA: 0x1341E18
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	// RVA: 0x1341E80
	public string get_FilterString() { }

	// RVA: 0x1341E88
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x1341E90
	public override object get_TypeId() { }

	// RVA: 0x1341F18
	public override bool Equals(object obj) { }

	// RVA: 0x134203C
	public override int GetHashCode() { }

	// RVA: 0x1342060
	public override bool Match(object obj) { }

	// RVA: 0x13420EC
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

	// RVA: 0x13421EC
	public void .ctor() { }

	// RVA: 0x134222C
	public void .ctor(Type type) { }

	// RVA: 0x134227C
	public void .ctor(string typeName) { }

	// RVA: 0x13422B0
	public string get_ConverterTypeName() { }

	// RVA: 0x13422B8
	public override bool Equals(object obj) { }

	// RVA: 0x134233C
	public override int GetHashCode() { }

	// RVA: 0x1342360
	private static void .cctor() { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor
{
	// Methods

	// RVA: 0x13425B4
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x13277E8
	protected void .ctor() { }

	// RVA: 0x13423EC
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x1342420
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x13424E4
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x13424FC
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x13425BC
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1342718
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x134289C
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x13428AC
	public Type GetReflectionType(object instance) { }

	// RVA: 0x1342938
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1342954
	public virtual Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x1342AAC
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x1342810
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x1342ABC
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1342B7C
	public virtual bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1342C34
	public void .ctor(string typeName) { }

	// RVA: 0x1342CB4
	public void .ctor(Type type) { }

	// RVA: 0x1342D78
	public string get_TypeName() { }

}

// Namespace: System.ComponentModel
public abstract class TypeListConverter
{
	// Fields
	private readonly Type[] _types; // 0x10
	private StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x1342D80
	protected void .ctor(Type[] types) { }

	// RVA: 0x1342DB4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1342E44
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1342F04
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1342FF8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x13431C8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x13432AC
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x13432B4
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
public class UInt16Converter
{
	// Methods

	// RVA: 0x13432BC
	internal override Type get_TargetType() { }

	// RVA: 0x134330C
	internal override object FromString(string value, int radix) { }

	// RVA: 0x134339C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13433DC
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1343488
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter
{
	// Methods

	// RVA: 0x1343490
	internal override Type get_TargetType() { }

	// RVA: 0x13434E0
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1343570
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13435B0
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x134365C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter
{
	// Methods

	// RVA: 0x1343664
	internal override Type get_TargetType() { }

	// RVA: 0x13436B4
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1343744
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1343784
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1343830
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

	// RVA: 0x1343838
	public void .ctor() { }

	// RVA: 0x13438CC
	public void .ctor(string message) { }

	// RVA: 0x134390C
	public void .ctor(string message, string helpUrl) { }

	// RVA: 0x1343950
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x134387C
	public void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x1343958
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1343ACC
	public string get_HelpUrl() { }

	// RVA: 0x1343AD4
	public string get_HelpTopic() { }

	// RVA: 0x1343ADC
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public class CancelEventArgs
{
	// Fields
	private bool <Cancel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1343B94
	public bool get_Cancel() { }

	// RVA: 0x1343B9C
	public void set_Cancel(bool value) { }

	// RVA: 0x1343BA4
	public void .ctor() { }

	// RVA: 0x1343C2C
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

	// RVA: 0x1343C9C
	public void .ctor(string propertyName) { }

	// RVA: 0x1343D14
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

	// RVA: 0x1343D1C
	public void .ctor(string propertyName) { }

	// RVA: 0x1343D94
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler
{
	// Methods

	// RVA: 0x1343D9C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1343EC0
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x1343ED4
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1343F30
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1343F3C
	public void .ctor(string propertyName) { }

	// RVA: 0x1343FB4
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler
{
	// Methods

	// RVA: 0x1343FBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13440E0
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x13440F4
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1344150
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

	// RVA: 0x134415C
	public void .ctor(Array array, int count) { }

	// RVA: 0x13441A8
	public bool MoveNext() { }

	// RVA: 0x13441CC
	public void Reset() { }

	// RVA: 0x13441D8
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

	// RVA: 0x1344240
	public void .ctor() { }

	// RVA: 0x13442C8
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x1344364
	public bool get_Cancelled() { }

	// RVA: 0x134436C
	public Exception get_Error() { }

	// RVA: 0x1344374
	public object get_UserState() { }

	// RVA: 0x134437C
	protected void RaiseExceptionIfNecessary() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler
{
	// Methods

	// RVA: 0x134445C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1344580
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x1344594
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x13445F0
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

	// RVA: 0x13445FC
	public static CategoryAttribute get_Action() { }

	// RVA: 0x1344700
	public static CategoryAttribute get_Appearance() { }

	// RVA: 0x13447D0
	public static CategoryAttribute get_Asynchronous() { }

	// RVA: 0x1344898
	public static CategoryAttribute get_Behavior() { }

	// RVA: 0x1344960
	public static CategoryAttribute get_Data() { }

	// RVA: 0x1344A28
	public static CategoryAttribute get_Default() { }

	// RVA: 0x1344B78
	public static CategoryAttribute get_Design() { }

	// RVA: 0x1344C40
	public static CategoryAttribute get_DragDrop() { }

	// RVA: 0x1344D08
	public static CategoryAttribute get_Focus() { }

	// RVA: 0x1344DD0
	public static CategoryAttribute get_Format() { }

	// RVA: 0x1344E98
	public static CategoryAttribute get_Key() { }

	// RVA: 0x1344F60
	public static CategoryAttribute get_Layout() { }

	// RVA: 0x1345028
	public static CategoryAttribute get_Mouse() { }

	// RVA: 0x13450F0
	public static CategoryAttribute get_WindowStyle() { }

	// RVA: 0x1344B08
	public void .ctor() { }

	// RVA: 0x13446C4
	public void .ctor(string category) { }

	// RVA: 0x13451B8
	public string get_Category() { }

	// RVA: 0x1345224
	public override bool Equals(object obj) { }

	// RVA: 0x1345394
	public override int GetHashCode() { }

	// RVA: 0x1345400
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x1345754
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CollectionConverter
{
	// Methods

	// RVA: 0x1345814
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1345BDC
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1345BE4
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1345BEC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
internal static class CompModSwitches
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Methods

	// RVA: 0x1345BFC
	public static BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x1345CDC
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

	// RVA: 0x1345DB4
	protected override void Finalize() { }

	// RVA: 0x1345E54
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x1345E5C
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x1345E68
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x1346020
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x1345F80
	protected EventHandlerList get_Events() { }

	// RVA: 0x1346138
	public virtual ISite get_Site() { }

	// RVA: 0x1346140
	public virtual void set_Site(ISite value) { }

	// RVA: 0x1346148
	public void Dispose() { }

	// RVA: 0x13461DC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1346508
	public IContainer get_Container() { }

	// RVA: 0x13465CC
	protected virtual object GetService(Type service) { }

	// RVA: 0x1346690
	protected bool get_DesignMode() { }

	// RVA: 0x1346754
	public override string ToString() { }

	// RVA: 0x1346894
	public void .ctor() { }

	// RVA: 0x134689C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentConverter
{
	// Methods

	// RVA: 0x1346924
	public void .ctor(Type type) { }

	// RVA: 0x1346990
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1346B68
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

	// RVA: 0x1347178
	internal void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x1348388
	public IComponent get_Component() { }

	// RVA: 0x1348390
	public IContainer get_Container() { }

	// RVA: 0x1348398
	public object GetService(Type service) { }

	// RVA: 0x1348454
	public bool get_DesignMode() { }

	// RVA: 0x134845C
	public string get_Name() { }

	// RVA: 0x1348464
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

	// RVA: 0x1346B70
	protected override void Finalize() { }

	// RVA: 0x1346C0C
	public virtual void Add(IComponent component) { }

	// RVA: 0x1346C1C
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x13470D4
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x13471DC
	public void Dispose() { }

	// RVA: 0x134726C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13475BC
	protected virtual object GetService(Type service) { }

	// RVA: 0x134764C
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x1347ADC
	public virtual void Remove(IComponent component) { }

	// RVA: 0x1347AE4
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x1347DFC
	protected void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x1347E04
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x1348310
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter
{
	// Methods

	// RVA: 0x13484DC
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1348628
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1348740
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1348B74
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x13497A0
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

	// RVA: 0x13497A8
	public void .ctor(string designerTypeName) { }

	// RVA: 0x13498C8
	public void .ctor(Type designerType) { }

	// RVA: 0x1349998
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x1349A70
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x1349B64
	public void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x1349BE8
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x1349BF0
	public string get_DesignerTypeName() { }

	// RVA: 0x1349BF8
	public override object get_TypeId() { }

	// RVA: 0x1349CB4
	public override bool Equals(object obj) { }

	// RVA: 0x1349D7C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public class DoWorkEventArgs
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Methods

	// RVA: 0x1349DCC
	public void .ctor(object argument) { }

	// RVA: 0x1349E00
	public object get_Argument() { }

	// RVA: 0x1349E08
	public object get_Result() { }

	// RVA: 0x1349E10
	public void set_Result(object value) { }

}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler
{
	// Methods

	// RVA: 0x1349E18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1349F3C
	public virtual void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x1349F50
	public virtual IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1349FAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class EnumConverter
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x1349FB8
	public void .ctor(Type type) { }

	// RVA: 0x1349FEC
	protected Type get_EnumType() { }

	// RVA: 0x1349FF4
	protected StandardValuesCollection get_Values() { }

	// RVA: 0x1349FFC
	protected void set_Values(StandardValuesCollection value) { }

	// RVA: 0x134A004
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x134A12C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x134A23C
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x134A2B8
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x134A810
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x134B6A8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x134BCB8
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x134BD54
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x134BD5C
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

	// RVA: 0x134BDB8
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

	// RVA: 0x134BE40
	public void .ctor(Type type) { }

	// RVA: 0x134BFD0
	public void .ctor(Type type, object instance) { }

	// RVA: 0x134BF6C
	public void .ctor(Type type, object instance, string message) { }

	// RVA: 0x134C15C
	public void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x134C1C4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x134C338
	public Type get_LicensedType() { }

	// RVA: 0x134C340
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

	// RVA: 0x134C43C
	protected void .ctor(string name) { }

	// RVA: 0x134C444
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x134C630
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x134C788
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x134CBE4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x134D468
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x134D568
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x134D67C
	public virtual string get_Category() { }

	// RVA: 0x134D7D8
	public virtual string get_Description() { }

	// RVA: 0x134D8FC
	public virtual bool get_IsBrowsable() { }

	// RVA: 0x134D9D0
	public virtual string get_Name() { }

	// RVA: 0x134DA2C
	protected virtual int get_NameHashCode() { }

	// RVA: 0x134DA34
	public virtual bool get_DesignTimeOnly() { }

	// RVA: 0x134DB1C
	public virtual string get_DisplayName() { }

	// RVA: 0x134CC10
	private void CheckAttributesValid() { }

	// RVA: 0x134DC38
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x134DCB4
	public override bool Equals(object obj) { }

	// RVA: 0x134DF30
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x134CD04
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x134E028
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x134E0A4
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x134E16C
	public override int GetHashCode() { }

	// RVA: 0x134E174
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x134E8D0
	protected static ISite GetSite(object component) { }

	// RVA: 0x134E9F0
	protected static object GetInvokee(Type componentClass, object component) { }

}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Methods

	// RVA: 0x134EB30
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x134EBB8
	public int get_ProgressPercentage() { }

	// RVA: 0x134EBC0
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler
{
	// Methods

	// RVA: 0x134EBC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x134ECEC
	public virtual void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x134ED00
	public virtual IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x134ED5C
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

	// RVA: 0x134ED68
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x134F028
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x134F184
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x134F27C
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x134F720
	private object get_AmbientValue() { }

	// RVA: 0x134F8D0
	private EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x134FC28
	private EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x134FE14
	private void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x134FEA0
	public override Type get_ComponentType() { }

	// RVA: 0x134FEA8
	private object get_DefaultValue() { }

	// RVA: 0x1350178
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x1350674
	private bool get_IsExtender() { }

	// RVA: 0x13506CC
	public override bool get_IsReadOnly() { }

	// RVA: 0x1350DB4
	public override Type get_PropertyType() { }

	// RVA: 0x1350DBC
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x13507C8
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x1351068
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x1351314
	public override void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x13514CC
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1351918
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x1351920
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x13517CC
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1351930
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1351E44
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x13522EC
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x13527BC
	public override bool CanResetValue(object component) { }

	// RVA: 0x1352AB0
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x1353BF0
	public override object GetValue(object component) { }

	// RVA: 0x1353F0C
	internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x1354014
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x13540F8
	public override void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x13542B4
	public override void ResetValue(object component) { }

	// RVA: 0x135471C
	public override void SetValue(object component, object value) { }

	// RVA: 0x1354D20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x135509C
	public override bool get_SupportsChangeEvents() { }

	// RVA: 0x13550E0
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

	// RVA: 0x135C180
	internal void .ctor(Type type) { }

	// RVA: 0x135BD74
	internal bool get_IsPopulated() { }

	// RVA: 0x135664C
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x1356F6C
	internal string GetClassName(object instance) { }

	// RVA: 0x1356FC4
	internal string GetComponentName(object instance) { }

	// RVA: 0x13571E0
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x1357758
	internal EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x13579E4
	internal PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x1357CC8
	internal object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x135E7C4
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x1358874
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0x135BDB0
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x135E308
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x135D5C8
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

	// RVA: 0x1355344
	internal static Guid get_ExtenderProviderKey() { }

	// RVA: 0x13553C0
	internal void .ctor() { }

	// RVA: 0x13553C8
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x1355D6C
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x135603C
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x135624C
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x1356384
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x1356B78
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1356F38
	internal string GetClassName(Type type) { }

	// RVA: 0x1356F94
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x13571B0
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x1357728
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x13579B4
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x1357C90
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x13583C0
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x1358854
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x1358C3C
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x1358CB8
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x1358D10
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x1358D5C
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x1358DA8
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x1358DB0
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x1358DB8
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x1358E14
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x1358E90
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x135A4AC
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x135A960
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x135B504
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x135B630
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x135B638
	public override string GetFullComponentName(object component) { }

	// RVA: 0x135B8B4
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x135BD90
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x135B5A4
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x135C178
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x13563A4
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x135C1B4
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x135C1BC
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x135C2CC
	internal bool IsPopulated(Type type) { }

	// RVA: 0x135C300
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x135375C
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x135C794
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x13594EC
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x135CEB8
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x135D540
	internal void Refresh(Type type) { }

	// RVA: 0x135D644
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x135DFEC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs
{
	// Fields
	private object result; // 0x28

	// Methods

	// RVA: 0x135EB58
	public void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x135EC04
	public object get_Result() { }

	// RVA: 0x135EC28
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler
{
	// Methods

	// RVA: 0x135EC30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135ED54
	public virtual void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x135ED68
	public virtual IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x135EDC4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Methods

	// RVA: 0x135FA58
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x135FAF4
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x135FB4C
	public override Type get_ComponentType() { }

	// RVA: 0x135FB54
	public override bool get_IsReadOnly() { }

	// RVA: 0x135FBE0
	public override Type get_PropertyType() { }

	// RVA: 0x135FBE8
	public override bool CanResetValue(object component) { }

	// RVA: 0x135FD20
	public override void ResetValue(object component) { }

	// RVA: 0x135FE40
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public class StandardValuesCollection
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Methods

	// RVA: 0x134BBF4
	public void .ctor(ICollection values) { }

	// RVA: 0x135FE48
	public int get_Count() { }

	// RVA: 0x135FF18
	public object get_Item(int index) { }

	// RVA: 0x1360124
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13601E0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1360294
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1360298
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13602A0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13602A8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1360364
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public class TypeConverter
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x135EDD0
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x135EE24
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x13485A8
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x135EE38
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x13486F0
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x135EE4C
	public object ConvertFrom(object value) { }

	// RVA: 0x1348AFC
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x135F000
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x135F08C
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x135F118
	public object ConvertFromString(string text) { }

	// RVA: 0x135F130
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x135F080
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x135F1BC
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1345998
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x135F354
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x134B5CC
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x135F4C8
	public string ConvertToString(object value) { }

	// RVA: 0x135F5A0
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x135F42C
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x135F67C
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x135F690
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x135EECC
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x135F1D8
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x135F698
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x135F6A8
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x135F6B0
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x135F6BC
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x135F7B8
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x135F7C0
	public bool GetPropertiesSupported() { }

	// RVA: 0x135F7D0
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x135F7D8
	public ICollection GetStandardValues() { }

	// RVA: 0x135F7E8
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x135F7F0
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x135F804
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x135F80C
	public bool GetStandardValuesSupported() { }

	// RVA: 0x135F820
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x135F828
	public bool IsValid(object value) { }

	// RVA: 0x135F840
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x135FA14
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x1345BF4
	public void .ctor() { }

}

// Namespace: 
private class AttributeTypeDescriptor
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x136DA04
	internal void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x136DA3C
	public override AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class AttributeProvider
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x136D92C
	internal void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x136D960
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x136DEF8
	internal void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x136DF48
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x136E008
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x136E0CC
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x136E0D4
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x136E198
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x136E25C
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x136E320
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x136E3E0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x136E4A4
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x136E564
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x136E618
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x136E6D8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Methods

	// RVA: 0x136DD00
	internal void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x136DD34
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x136DD3C
	internal void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x136DD44
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x136E6E0
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x136E730
	internal bool IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x136E7A8
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x136E7F8
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

	// RVA: 0x136E808
	public int Compare(object left, object right) { }

	// RVA: 0x136E92C
	public void .ctor() { }

	// RVA: 0x136E934
	private static void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x136E9A0
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x136E9F0
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x136EB30
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x136EC78
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x136EDC0
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x136EF08
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x136F050
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x136F198
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x136F378
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x136F4C0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x136F604
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x136F74C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x136F890
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x136FCBC
	internal void .ctor(TypeDescriptionNode node, object instance) { }

	// RVA: 0x137020C
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1370520
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1370768
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1370984
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1370C34
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1370E50
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x137106C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1371328
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1371640
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1371974
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1371C24
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1371EEC
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

	// RVA: 0x1370110
	internal void .ctor(TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x1372138
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x13723E8
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1372628
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1372844
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1372AF4
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1372D10
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1372F2C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x13731E8
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x137349C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1373768
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1373A1C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1373CE8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class TypeDescriptionNode
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x136F9D4
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x136FA08
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x136FB64
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x136FBDC
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x136FCF0
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x136FD68
	public override string GetFullComponentName(object component) { }

	// RVA: 0x136FDE0
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x136FE9C
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x136FF48
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1370160
	public override bool IsSupportedType(Type type) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject
{
	// Methods

	// RVA: 0x1373F34
	public void .ctor() { }

}

// Namespace: 
private sealed class TypeDescriptorInterface
{
	// Methods

	// RVA: 0x1373F3C
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

	// RVA: 0x1360418
	private void .ctor() { }

	// RVA: 0x1360420
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x13606C4
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x13605AC
	public static Type get_ComObjectType() { }

	// RVA: 0x1360BB0
	public static Type get_InterfaceType() { }

	// RVA: 0x1360C40
	internal static int get_MetadataVersion() { }

	// RVA: 0x1360CBC
	public static void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x1360DAC
	public static void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x1360E9C
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0x1361114
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	// RVA: 0x13615A0
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x1360910
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x13612EC
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1362C4C
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1362D64
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1362E54
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x13634A8
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x1363C50
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x136415C
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x13641E4
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x1364264
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x13645BC
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1364640
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x1364810
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x1364814
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x1364818
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0x136481C
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x1364820
	private static void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0x1364824
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x1364828
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0x136482C
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1364830
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0x1364834
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1364838
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0x134E2B4
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x13535D4
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x1348288
	public static AttributeCollection GetAttributes(object component) { }

	// RVA: 0x1364E7C
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x135940C
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x1368990
	public static string GetClassName(object component) { }

	// RVA: 0x1368A18
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1368B2C
	public static string GetClassName(Type componentType) { }

	// RVA: 0x135B82C
	public static string GetComponentName(object component) { }

	// RVA: 0x1368C58
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1368D6C
	public static TypeConverter GetConverter(object component) { }

	// RVA: 0x1368DF4
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1368F08
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1369034
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x1369118
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x1369278
	public static EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x1369300
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1369410
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x1369570
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x13695F8
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1364D1C
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x1365294
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1365508
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x1369708
	public static object GetEditor(object component, Type editorBaseType) { }

	// RVA: 0x1369774
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x13698FC
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x134FA98
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x1369A94
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x135E508
	public static EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x136A1F0
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x136A25C
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x1369D24
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x136A974
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x136ACB4
	public static string GetFullComponentName(object component) { }

	// RVA: 0x136AD70
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x135E634
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x136AF54
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x135E570
	public static PropertyDescriptorCollection GetProperties(object component) { }

	// RVA: 0x136B1E4
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1346AA0
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x136B908
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x136B254
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x1361008
	public static TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0x1361230
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x136B984
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0x134BA88
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x136BA0C
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x136063C
	private static TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x136162C
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x1368908
	private static TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1362150
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x136BB28
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x136A2C8
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x1366890
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x13680FC
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x1365628
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x136BF04
	private static void RaiseRefresh(object component) { }

	// RVA: 0x136BFDC
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x136C0B4
	public static void Refresh(object component) { }

	// RVA: 0x13623C4
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x1361B38
	public static void Refresh(Type type) { }

	// RVA: 0x136C13C
	public static void Refresh(Module module) { }

	// RVA: 0x136CB80
	public static void Refresh(Assembly assembly) { }

	// RVA: 0x136CC4C
	public static void RemoveAssociation(object primary, object secondary) { }

	// RVA: 0x136D00C
	public static void RemoveAssociations(object primary) { }

	// RVA: 0x136D0F0
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x136D1F8
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x136D2D8
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x136D3F0
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1364C88
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x136D4E0
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x136D5B4
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x136D5B8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Methods

	// RVA: 0x1373F44
	public void .ctor() { }

	// RVA: 0x1373FC4
	public void .ctor(int error) { }

	// RVA: 0x1374DE8
	public void .ctor(int error, string message) { }

	// RVA: 0x1374E18
	public void .ctor(string message) { }

	// RVA: 0x1374E98
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1374F24
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1374FB8
	public int get_NativeErrorCode() { }

	// RVA: 0x1374FC0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1374000
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

	// RVA: 0x1375094
	public void .ctor(bool notifyParent) { }

	// RVA: 0x13750C0
	public bool get_NotifyParent() { }

	// RVA: 0x13750C8
	public override bool Equals(object obj) { }

	// RVA: 0x137516C
	public override int GetHashCode() { }

	// RVA: 0x1375174
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13751E8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ParenthesizePropertyNameAttribute
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Methods

	// RVA: 0x137529C
	public void .ctor() { }

	// RVA: 0x13752C4
	public void .ctor(bool needParenthesis) { }

	// RVA: 0x13752F0
	public bool get_NeedParenthesis() { }

	// RVA: 0x13752F8
	public override bool Equals(object o) { }

	// RVA: 0x1375380
	public override int GetHashCode() { }

	// RVA: 0x1375388
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13753FC
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

	// RVA: 0x137546C
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x1375498
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x13754A0
	public override bool Equals(object value) { }

	// RVA: 0x1375528
	public override int GetHashCode() { }

	// RVA: 0x1375530
	public override bool IsDefaultAttribute() { }

	// RVA: 0x13755A4
	private static void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer
{
	// Methods

	// RVA: 0x1375EE8
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x1376060
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x1375EE0
	public void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x1375E14
	internal void .ctor(object o) { }

	// RVA: 0x1376088
	public override bool Equals(object o) { }

	// RVA: 0x1376118
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

	// RVA: 0x1375674
	internal void .ctor() { }

	// RVA: 0x13756E4
	public override void Clear() { }

	// RVA: 0x13756EC
	public override void Remove(object key) { }

	// RVA: 0x13756F4
	public void SetWeak(object key, object value) { }

	// RVA: 0x13757A4
	private void ScavengeKeys() { }

	// RVA: 0x1375E58
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute
{
	// Methods

	// RVA: 0x1376120
	public void .ctor(string category) { }

}

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x1376128
	public void .ctor() { }

	// RVA: 0x1376130
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x1376138
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1376140
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x13761D4
	private string GetLocalPath(string fileName) { }

	// RVA: 0x1376268
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x13767C4
	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x1376BD4
	public void .ctor() { }

	// RVA: 0x1376BDC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer
{
	// Methods

	// RVA: 0x13769A8
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

	// RVA: 0x13774D4
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x13775DC
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x1377600
	public override Type get_ComponentType() { }

	// RVA: 0x1377628
	public override bool get_IsReadOnly() { }

	// RVA: 0x1377650
	public override Type get_PropertyType() { }

	// RVA: 0x1377678
	public override bool CanResetValue(object component) { }

	// RVA: 0x13776A8
	public override object GetValue(object component) { }

	// RVA: 0x13776D8
	public override void ResetValue(object component) { }

	// RVA: 0x1377708
	public override void SetValue(object component, object value) { }

	// RVA: 0x1377738
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

	// RVA: 0x1376CA0
	public int get_Count() { }

	// RVA: 0x1376D7C
	public string get_Name() { }

	// RVA: 0x1376D84
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x1377548
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1376CD8
	private void EnsurePopulated() { }

	// RVA: 0x1377598
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13775D0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13775D8
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
private class OptionPropertyDescriptor
{
	// Fields
	private DesignerOptionCollection _option; // 0x88

	// Methods

	// RVA: 0x1377D3C
	internal void .ctor(DesignerOptionCollection option) { }

	// RVA: 0x1377E60
	public override Type get_ComponentType() { }

	// RVA: 0x1377E80
	public override bool get_IsReadOnly() { }

	// RVA: 0x1377E88
	public override Type get_PropertyType() { }

	// RVA: 0x1377EA8
	public override bool CanResetValue(object component) { }

	// RVA: 0x1377EB0
	public override object GetValue(object component) { }

	// RVA: 0x1377EB8
	public override void ResetValue(object component) { }

	// RVA: 0x1377EBC
	public override void SetValue(object component, object value) { }

	// RVA: 0x1377EC0
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
internal sealed class DesignerOptionConverter
{
	// Methods

	// RVA: 0x1377768
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x1377770
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x1377D80
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1377E58
	public void .ctor() { }

}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService
{
	// Methods

	// RVA: 0x1376C9C
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

	// RVA: 0x1377EC8
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x1377ED0
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	// RVA: 0x137845C
	public ICollection get_Arguments() { }

	// RVA: 0x1378464
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x137846C
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

	// RVA: 0x1378808
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x1378864
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x137886C
	public override object get_TypeId() { }

}

// Namespace: System.Collections
internal static class HashtableExtensions
{
	// Methods

	// RVA: 0x3527DAC
	public static bool TryGetValue(Hashtable table, object key, T value) { }

}

// Namespace: System.Collections.Specialized
public struct BitVector32
{
	// Fields
	private UInt32 _data; // 0x10

	// Methods

	// RVA: 0x1378928
	public void .ctor(int data) { }

	// RVA: 0x1378930
	public bool get_Item(int bit) { }

	// RVA: 0x1378940
	public void set_Item(int bit, bool value) { }

	// RVA: 0x137895C
	public int get_Data() { }

	// RVA: 0x1378964
	public static int CreateMask() { }

	// RVA: 0x137896C
	public static int CreateMask(int previous) { }

	// RVA: 0x13789E0
	public override bool Equals(object o) { }

	// RVA: 0x1378A70
	public override int GetHashCode() { }

	// RVA: 0x1378AE0
	public static string ToString(BitVector32 value) { }

	// RVA: 0x1378E10
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

	// RVA: 0x1378E18
	public void .ctor() { }

	// RVA: 0x1378F48
	public void .ctor(int capacity) { }

	// RVA: 0x13790C4
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1379174
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1379220
	protected void InvalidateCachedArrays() { }

	// RVA: 0x1379254
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x1379414
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x13794D0
	public virtual void Add(string name, string value) { }

	// RVA: 0x13797FC
	public virtual string Get(string name) { }

	// RVA: 0x1379894
	public virtual string[] GetValues(string name) { }

	// RVA: 0x13799F8
	public virtual void Set(string name, string value) { }

	// RVA: 0x1379BC0
	public virtual void Remove(string name) { }

	// RVA: 0x1379F2C
	public string get_Item(string name) { }

	// RVA: 0x1379F3C
	public void set_Item(string name, string value) { }

	// RVA: 0x1379F4C
	public virtual string Get(int index) { }

	// RVA: 0x137A10C
	public virtual string GetKey(int index) { }

	// RVA: 0x137A25C
	internal void .ctor(DBNull dummy) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Methods

	// RVA: 0x137B670
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x137BF4C
	public object get_Current() { }

	// RVA: 0x137C148
	public DictionaryEntry get_Entry() { }

	// RVA: 0x137C2FC
	public object get_Key() { }

	// RVA: 0x137C3F0
	public object get_Value() { }

	// RVA: 0x137C4E4
	public bool MoveNext() { }

	// RVA: 0x137C598
	public void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Methods

	// RVA: 0x137A634
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x137C650
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x137CA2C
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x137CA54
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x137CA5C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x137CA84
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

	// RVA: 0x137A2EC
	public void .ctor() { }

	// RVA: 0x137A320
	public void .ctor(int capacity) { }

	// RVA: 0x137A358
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x137A39C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x137A3D0
	public int get_Count() { }

	// RVA: 0x137A510
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x137A518
	public bool get_IsReadOnly() { }

	// RVA: 0x137A520
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x137A528
	public ICollection get_Keys() { }

	// RVA: 0x137A46C
	private ArrayList get_objectsArray() { }

	// RVA: 0x137A67C
	private Hashtable get_objectsTable() { }

	// RVA: 0x137A734
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x137A7C0
	public object get_Item(object key) { }

	// RVA: 0x137A874
	public void set_Item(object key, object value) { }

	// RVA: 0x137AF44
	public ICollection get_Values() { }

	// RVA: 0x137AD50
	public void Add(object key, object value) { }

	// RVA: 0x137B04C
	public void Clear() { }

	// RVA: 0x137B1C0
	public bool Contains(object key) { }

	// RVA: 0x137B274
	public void CopyTo(Array array, int index) { }

	// RVA: 0x137AB24
	private int IndexOfKey(object key) { }

	// RVA: 0x137B338
	public void Remove(object key) { }

	// RVA: 0x137B534
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x137B6D4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x137B810
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x137BA44
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x137BA54
	protected virtual void OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringCollection
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Methods

	// RVA: 0x137CB2C
	public string get_Item(int index) { }

	// RVA: 0x137CB78
	public void set_Item(int index, string value) { }

	// RVA: 0x137CBA0
	public int get_Count() { }

	// RVA: 0x137CBC8
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x137CBD0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x137CBD8
	public int Add(string value) { }

	// RVA: 0x137CC00
	public void Clear() { }

	// RVA: 0x137CC28
	public bool Contains(string value) { }

	// RVA: 0x137CC50
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x137CC78
	public int IndexOf(string value) { }

	// RVA: 0x137CCA0
	public void Insert(int index, string value) { }

	// RVA: 0x137CCC8
	public bool get_IsSynchronized() { }

	// RVA: 0x137CCD0
	public void Remove(string value) { }

	// RVA: 0x137CCF8
	public void RemoveAt(int index) { }

	// RVA: 0x137CD20
	public object get_SyncRoot() { }

	// RVA: 0x137CD48
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x137CD94
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x137CDE4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x137CE34
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x137CE84
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x137CED4
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x137CF24
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x137CF74
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x137CF9C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x137CFC4
	public void .ctor() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringDictionary
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x137D03C
	public void .ctor() { }

	// RVA: 0x137D0B4
	public virtual string get_Item(string key) { }

	// RVA: 0x137D168
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

	// RVA: 0x137D190
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x137D3AC
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x137D70C
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x137DA48
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x137D5E0
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x137D304
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x137DC20
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x137D924
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler
{
	// Methods

	// RVA: 0x137DCFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137DE20
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

// Namespace: System.Collections.Specialized
internal sealed class ReadOnlyList
{
	// Fields
	private readonly IList _list; // 0x10

	// Methods

	// RVA: 0x137DCC8
	internal void .ctor(IList list) { }

	// RVA: 0x137DE34
	public int get_Count() { }

	// RVA: 0x137DEEC
	public bool get_IsReadOnly() { }

	// RVA: 0x137DEF4
	public bool get_IsFixedSize() { }

	// RVA: 0x137DEFC
	public bool get_IsSynchronized() { }

	// RVA: 0x137DFB4
	public object get_Item(int index) { }

	// RVA: 0x137E068
	public void set_Item(int index, object value) { }

	// RVA: 0x137E0BC
	public object get_SyncRoot() { }

	// RVA: 0x137E174
	public int Add(object value) { }

	// RVA: 0x137E1C8
	public void Clear() { }

	// RVA: 0x137E21C
	public bool Contains(object value) { }

	// RVA: 0x137E2D4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x137E390
	public IEnumerator GetEnumerator() { }

	// RVA: 0x137E444
	public int IndexOf(object value) { }

	// RVA: 0x137E4FC
	public void Insert(int index, object value) { }

	// RVA: 0x137E550
	public void Remove(object value) { }

	// RVA: 0x137E5A4
	public void RemoveAt(int index) { }

}

// Namespace: 
internal class NameObjectEntry
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x137F960
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

	// RVA: 0x137FA44
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x137FF7C
	public bool MoveNext() { }

	// RVA: 0x1380060
	public void Reset() { }

	// RVA: 0x13800EC
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

	// RVA: 0x1378EDC
	protected void .ctor() { }

	// RVA: 0x137E5F8
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1379144
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1378FD4
	protected void .ctor(int capacity) { }

	// RVA: 0x137A2E4
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x13791EC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x137E870
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x137F0B0
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x137E6B4
	private void Reset() { }

	// RVA: 0x137E788
	private void Reset(int capacity) { }

	// RVA: 0x137F880
	private NameObjectEntry FindEntry(string key) { }

	// RVA: 0x137F958
	protected bool get_IsReadOnly() { }

	// RVA: 0x1379674
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1379C04
	protected void BaseRemove(string name) { }

	// RVA: 0x1379658
	protected object BaseGet(string name) { }

	// RVA: 0x1379B00
	protected void BaseSet(string name, object value) { }

	// RVA: 0x137A064
	protected object BaseGet(int index) { }

	// RVA: 0x137A1B4
	protected string BaseGetKey(int index) { }

	// RVA: 0x137F9B0
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x137FAA4
	public virtual int get_Count() { }

	// RVA: 0x137FACC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x137FE04
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x137FE90
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x137FE98
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

	// RVA: 0x137F830
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1380214
	public bool Equals(object a, object b) { }

	// RVA: 0x1380434
	public int GetHashCode(object obj) { }

	// RVA: 0x138054C
	public IComparer get_Comparer() { }

	// RVA: 0x1380554
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x137EFC4
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x137EEE0
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

	// RVA: 0x35267E8
	internal void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: 0x26AD93C
	internal void LocalPush(T item, Int64 emptyToNonEmptyListTransitionCount) { }

	// RVA: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x35254D0
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

	// RVA: 0x35267E8
	public void .ctor(T[] array) { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x35263A0
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	public void Add(T item) { }

	// RVA: -1
	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	// RVA: 0x3525804
	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: 0x3525804
	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: 0x3526850
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3525804
	public T[] ToArray() { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35254D0
	private int get_DangerousCount() { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3525804
	private object get_GlobalQueuesLock() { }

	// RVA: 0x35267E8
	private void FreezeBag(bool lockTaken) { }

	// RVA: 0x352642C
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

	// RVA: 0x26AD93C
	public void .ctor(System.Span<T> initialSpan) { }

	// RVA: 0x35254D0
	public int get_Length() { }

	// RVA: -1
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public void Append(T item) { }

	// RVA: 0x26AD93C
	public System.ReadOnlySpan<T> AsSpan() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35263A0
	private void Grow() { }

	// RVA: 0x26AD93C
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

	// RVA: 0x138055C
	internal void .ctor(Int32* bitArrayPtr, int length) { }

	// RVA: 0x13805A0
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x13805E8
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x1380668
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x13806F0
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

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.LinkedList<T> list) { }

	// RVA: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35267E8
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
	private const string VersionName = "Version";
	private const string CountName = "Count";
	private const string ValuesName = "Data";

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3525804
	public System.Collections.Generic.LinkedListNode<T> get_First() { }

	// RVA: 0x3525804
	public System.Collections.Generic.LinkedListNode<T> get_Last() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x26AD93C
	public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }

	// RVA: 0x35267E8
	public void AddFirst(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x26AD93C
	public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }

	// RVA: 0x35267E8
	public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool Contains(T value) { }

	// RVA: 0x3526850
	public void CopyTo(T[] array, int index) { }

	// RVA: 0x26AD93C
	public System.Collections.Generic.LinkedListNode<T> Find(T value) { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x26AD93C
	public bool Remove(T value) { }

	// RVA: 0x35267E8
	public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x35263A0
	public void RemoveFirst() { }

	// RVA: 0x35263A0
	public void RemoveLast() { }

	// RVA: -1
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35267E8
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x35269D4
	private void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x35267E8
	private void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x35267E8
	internal void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x35267E8
	internal void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x35267E8
	internal void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3525804
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

	// RVA: 0x26AD93C
	public void .ctor(T value) { }

	// RVA: 0x26AD93C
	internal void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }

	// RVA: 0x3525804
	public System.Collections.Generic.LinkedListNode<T> get_Next() { }

	// RVA: 0x26AD93C
	public T get_Value() { }

	// RVA: 0x35263A0
	internal void Invalidate() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x3526850
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, int getEnumeratorRetType) { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x26AD93C
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x35251DC
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x35263A0
	internal void Reset() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x3525804
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

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public TKey get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3526850
	public void CopyTo(TKey[] array, int index) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: 0x35263A0
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public TValue get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3526850
	public void CopyTo(TValue[] array, int index) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: 0x35263A0
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
[Serializable]
internal sealed class KeyValuePairComparer
{
	// Fields
	internal System.Collections.Generic.IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }

	// RVA: 0x26AD93C
	public override int Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1
{
	// Fields
	public System.Collections.Generic.EqualityComparer<TValue> valueComparer; // 0x0
	public System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey,TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public TValue get_Item(TKey key) { }

	// RVA: 0x26AD93C
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3525804
	public KeyCollection get_Keys() { }

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x3525804
	public ValueCollection get_Values() { }

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x26AD93C
	public void Add(TKey key, TValue value) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool ContainsKey(TKey key) { }

	// RVA: 0x26AD93C
	public bool ContainsValue(TValue value) { }

	// RVA: 0x3526850
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int index) { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x26AD93C
	public bool Remove(TKey key) { }

	// RVA: 0x26AD93C
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x35251DC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x35251DC
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x35258B4
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x35252FC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x35279B0
	private static bool IsCompatibleKey(object key) { }

	// RVA: 0x3525804
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x35267E8
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
[Serializable]
internal sealed class TreeSet<T0>
{
	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	public void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x3526850
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, int getEnumeratorRetType) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x3525804
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x26AD93C
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x35263A0
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

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public TKey get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
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

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public TValue get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class KeyList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	public bool get_IsReadOnly() { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x26AD93C
	public void Add(TKey key) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool Contains(TKey key) { }

	// RVA: 0x3526850
	public void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x26AD93C
	public void Insert(int index, TKey value) { }

	// RVA: 0x26AD93C
	public TKey get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, TKey value) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	public int IndexOf(TKey key) { }

	// RVA: 0x26AD93C
	public bool Remove(TKey key) { }

	// RVA: 0x3526518
	public void RemoveAt(int index) { }

}

// Namespace: 
[Serializable]
private sealed class ValueList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	public bool get_IsReadOnly() { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x26AD93C
	public void Add(TValue key) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool Contains(TValue value) { }

	// RVA: 0x3526850
	public void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x26AD93C
	public void Insert(int index, TValue value) { }

	// RVA: 0x26AD93C
	public TValue get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, TValue value) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	public int IndexOf(TValue value) { }

	// RVA: 0x26AD93C
	public bool Remove(TValue value) { }

	// RVA: 0x3526518
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x26AD93C
	public void Add(TKey key, TValue value) { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x3526518
	public void set_Capacity(int value) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IComparer<TKey> get_Comparer() { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x3525804
	private KeyList GetKeyListHelper() { }

	// RVA: 0x3525804
	private ValueList GetValueListHelper() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x35251DC
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x35251DC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x35252FC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x26AD93C
	public bool ContainsKey(TKey key) { }

	// RVA: 0x26AD93C
	public bool ContainsValue(TValue value) { }

	// RVA: 0x3526850
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3526518
	private void EnsureCapacity(int min) { }

	// RVA: 0x26AD93C
	private TValue GetByIndex(int index) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x3525804
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	private TKey GetKey(int index) { }

	// RVA: 0x26AD93C
	public TValue get_Item(TKey key) { }

	// RVA: 0x26AD93C
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x35258B4
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x26AD93C
	public int IndexOfKey(TKey key) { }

	// RVA: 0x26AD93C
	public int IndexOfValue(TValue value) { }

	// RVA: 0x26AD93C
	private void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x26AD93C
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x3526518
	public void RemoveAt(int index) { }

	// RVA: 0x26AD93C
	public bool Remove(TKey key) { }

	// RVA: 0x35267E8
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x35279B0
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

	// RVA: 0x26AD93C
	public void .ctor(T item, NodeColor color) { }

	// RVA: 0x35279B0
	public static bool IsNonNullRed(Node node) { }

	// RVA: 0x35279B0
	public static bool IsNullOrBlack(Node node) { }

	// RVA: 0x26AD93C
	public T get_Item() { }

	// RVA: 0x26AD93C
	public void set_Item(T value) { }

	// RVA: 0x3525804
	public Node get_Left() { }

	// RVA: 0x35267E8
	public void set_Left(Node value) { }

	// RVA: 0x3525804
	public Node get_Right() { }

	// RVA: 0x35267E8
	public void set_Right(Node value) { }

	// RVA: 0x35251DC
	public NodeColor get_Color() { }

	// RVA: 0x352642C
	public void set_Color(NodeColor value) { }

	// RVA: 0x35251DC
	public bool get_IsBlack() { }

	// RVA: 0x35251DC
	public bool get_IsRed() { }

	// RVA: 0x35251DC
	public bool get_Is2Node() { }

	// RVA: 0x35251DC
	public bool get_Is4Node() { }

	// RVA: 0x35263A0
	public void ColorBlack() { }

	// RVA: 0x35263A0
	public void ColorRed() { }

	// RVA: -1
	public Node DeepClone(int count) { }

	// RVA: -1
	public TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: 0x35258B4
	public Node GetSibling(Node node) { }

	// RVA: 0x3525804
	public Node ShallowClone() { }

	// RVA: 0x35263A0
	public void Split4Node() { }

	// RVA: -1
	public Node Rotate(TreeRotation rotation) { }

	// RVA: 0x3525804
	public Node RotateLeft() { }

	// RVA: 0x3525804
	public Node RotateLeftRight() { }

	// RVA: 0x3525804
	public Node RotateRight() { }

	// RVA: 0x3525804
	public Node RotateRightLeft() { }

	// RVA: 0x35263A0
	public void Merge2Nodes() { }

	// RVA: 0x35269D4
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

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.SortedSet<T> set) { }

	// RVA: -1
	internal void .ctor(System.Collections.Generic.SortedSet<T> set, bool reverse) { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35267E8
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x35263A0
	private void Initialize() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35251DC
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x35263A0
	internal void Reset() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x352AE04
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: 0x35269D4
	public void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35267E8
	private void AddAllElements(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x35252FC
	internal virtual bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3525804
	public System.Collections.Generic.IComparer<T> get_Comparer() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x35263A0
	internal virtual void VersionCheck() { }

	// RVA: 0x26AD93C
	internal virtual bool IsWithinRange(T item) { }

	// RVA: 0x26AD93C
	public bool Add(T item) { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x26AD93C
	internal virtual bool AddIfNotPresent(T item) { }

	// RVA: 0x26AD93C
	public bool Remove(T item) { }

	// RVA: 0x26AD93C
	internal virtual bool DoRemove(T item) { }

	// RVA: 0x35263A0
	public virtual void Clear() { }

	// RVA: 0x26AD93C
	public virtual bool Contains(T item) { }

	// RVA: 0x3526850
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	public void CopyTo(T[] array, int index, int count) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3526C14
	private void InsertionBalance(Node current, Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: 0x3526BA8
	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: 0x3526C14
	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: 0x26AD93C
	internal virtual Node FindNode(T item) { }

	// RVA: 0x26AD93C
	internal virtual int InternalIndexOf(T item) { }

	// RVA: 0x35263A0
	internal void UpdateVersion() { }

	// RVA: 0x35252FC
	private bool HasEqualComparer(System.Collections.Generic.SortedSet<T> other) { }

	// RVA: 0x35267E8
	public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x26AD93C
	private static Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode) { }

	// RVA: 0x35267E8
	public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x35267E8
	internal virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x35252FC
	public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x26AD93C
	private ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, bool returnIfUnfound) { }

	// RVA: 0x26AD93C
	public T get_Min() { }

	// RVA: 0x26AD93C
	internal virtual T get_MinInternal() { }

	// RVA: 0x26AD93C
	public T get_Max() { }

	// RVA: 0x26AD93C
	internal virtual T get_MaxInternal() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35267E8
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x35267E8
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

	// RVA: 0x35252FC
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

	// RVA: 0x1380704
	public void .ctor() { }

	// RVA: 0x138075C
	public void .ctor(string message) { }

	// RVA: 0x1380764
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.IO
[Serializable]
public sealed class InvalidDataException
{
	// Methods

	// RVA: 0x138076C
	public void .ctor() { }

	// RVA: 0x13807E0
	public void .ctor(string message) { }

	// RVA: 0x1380810
	private void .ctor(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0x1380818
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1380820
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x13808E4
	public override bool get_CanRead() { }

	// RVA: 0x13808FC
	public override bool get_CanWrite() { }

	// RVA: 0x1380914
	public override bool get_CanSeek() { }

	// RVA: 0x138092C
	public override Int64 get_Length() { }

	// RVA: 0x1380980
	public override Int64 get_Position() { }

	// RVA: 0x13809D4
	public override void set_Position(Int64 value) { }

	// RVA: 0x1380A28
	public override void Flush() { }

	// RVA: 0x1380A6C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1380AC0
	public override int ReadByte() { }

	// RVA: 0x1380AE8
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1380BA0
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1380C08
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1380C30
	public override int Read(System.Span<System.Byte> buffer) { }

	// RVA: 0x1380E38
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1380EF0
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1380EFC
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1380F24
	public override void Write(System.ReadOnlySpan<System.Byte> buffer) { }

	// RVA: 0x13810FC
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1381124
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13811E8
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1381210
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x13812E8
	public override Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1381310
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x13813E8
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1380A50
	private void CheckDeflateStream() { }

	// RVA: 0x1381410
	private static void ThrowStreamClosedException() { }

}

// Namespace: 
private sealed class ReadMethod
{
	// Methods

	// RVA: 0x13826F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13831B8
	public virtual int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x13827AC
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1382E9C
	public virtual int EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod
{
	// Methods

	// RVA: 0x1382BCC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13831CC
	public virtual void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1382C88
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1383020
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

	// RVA: 0x1381468
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x13808DC
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1381474
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x13818B0
	protected override void Finalize() { }

	// RVA: 0x1381950
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1381B6C
	private int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x13812E0
	internal System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x1380D10
	internal int ReadCore(System.Span<System.Byte> destination) { }

	// RVA: 0x1381C90
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1381EB4
	private void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x13813E0
	internal ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x138106C
	internal void WriteCore(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1381FD0
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1382210
	public override void Flush() { }

	// RVA: 0x1382378
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1382854
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1382D30
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1382EC8
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x138302C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x138306C
	public override bool get_CanRead() { }

	// RVA: 0x13830AC
	public override bool get_CanSeek() { }

	// RVA: 0x13830B4
	public override bool get_CanWrite() { }

	// RVA: 0x13830F8
	public override Int64 get_Length() { }

	// RVA: 0x1383138
	public override Int64 get_Position() { }

	// RVA: 0x1383178
	public override void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite
{
	// Methods

	// RVA: 0x1383410
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1383C44
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle
{
	// Methods

	// RVA: 0x1383C58
	public override bool get_IsInvalid() { }

	// RVA: 0x1383C30
	private void .ctor() { }

	// RVA: 0x1383C68
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

	// RVA: 0x1383408
	private void .ctor() { }

	// RVA: 0x1381640
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1383558
	protected override void Finalize() { }

	// RVA: 0x1381A4C
	public void Dispose(bool disposing) { }

	// RVA: 0x13822C4
	public void Flush() { }

	// RVA: 0x1381BC0
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1381F04
	public void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x13831E0
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x138384C
	private int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x13832F4
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1383A30
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x138365C
	private void CheckResult(int result, string where) { }

	// RVA: 0x13834B4
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1383C40
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x13835EC
	private static extern int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x138373C
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x13837C4
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

	// RVA: 0x138512C
	private static void .cctor() { }

	// RVA: 0x1385198
	public void .ctor() { }

	// RVA: 0x13851A0
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

	// RVA: 0x1383D0C
	private void SafeCaptureIdentity() { }

	// RVA: 0x1383D10
	private void CleanupInternal() { }

	// RVA: 0x1383D14
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1383D1C
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1383D8C
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1383E14
	internal object StartPostingAsyncOp() { }

	// RVA: 0x1383E1C
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x13840C8
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x138476C
	protected override void Cleanup() { }

	// RVA: 0x1384118
	private bool CaptureOrComplete(ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x1384C80
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x1384FFC
	private void CompleteCallback() { }

}

// Namespace: System.Net
internal static class HttpStatusDescription
{
	// Methods

	// RVA: 0x1385224
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x1385228
	internal static string Get(int code) { }

}

// Namespace: System.Net
internal static class HttpValidationHelpers
{
	// Fields
	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x1385B18
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x1385C3C
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

	// RVA: 0x1385CE0
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x13863C0
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x1386910
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x1386338
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x1386AEC
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1386D40
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x1386CB8
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x1384920
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1384AEC
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x1386ED4
	private void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1386F5C
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x13870F0
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1383F34
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x1387178
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1387200
	public static void Associate(object first, object second, string memberName) { }

	// RVA: 0x138739C
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x13848A0
	public static bool get_IsEnabled() { }

	// RVA: 0x1385EAC
	public static string IdOf(object value) { }

	// RVA: 0x1387640
	public static int GetHashCode(object value) { }

	// RVA: 0x1386568
	public static object Format(object value) { }

	// RVA: 0x1385FAC
	private static string Format(FormattableString s) { }

	// RVA: 0x1387428
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1387654
	public void .ctor() { }

	// RVA: 0x138765C
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class TcpValidationHelpers
{
	// Methods

	// RVA: 0x13876C8
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

	// RVA: 0x13876D4
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x13877CC
	public void AuthenticateAsClient() { }

	// RVA: 0x138791C
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x1387A84
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1387AAC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1387AD4
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x1387AFC
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1387B24
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1387B4C
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1387B74
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1387B9C
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

	// RVA: 0x1387BE0
	private static void .cctor() { }

}

// Namespace: 
private sealed class ReadOnlyIPAddress
{
	// Methods

	// RVA: 0x13899F8
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

	// RVA: 0x1387D00
	private bool get_IsIPv4() { }

	// RVA: 0x1387D10
	private bool get_IsIPv6() { }

	// RVA: 0x1387D20
	private UInt32 get_PrivateAddress() { }

	// RVA: 0x1387D28
	private void set_PrivateAddress(UInt32 value) { }

	// RVA: 0x1387D60
	private UInt32 get_PrivateScopeId() { }

	// RVA: 0x1387D68
	private void set_PrivateScopeId(UInt32 value) { }

	// RVA: 0x1387DA0
	public void .ctor(Int64 newAddress) { }

	// RVA: 0x1387E30
	public void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0x1387F50
	public void .ctor(System.ReadOnlySpan<System.Byte> address, Int64 scopeid) { }

	// RVA: 0x1388184
	internal void .ctor(UInt16* numbers, int numbersLength, UInt32 scopeid) { }

	// RVA: 0x138824C
	private void .ctor(UInt16[] numbers, UInt32 scopeid) { }

	// RVA: 0x13882A8
	public static bool TryParse(string ipString, IPAddress address) { }

	// RVA: 0x1388628
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x13886C4
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten) { }

	// RVA: 0x13889F4
	private void WriteIPv6Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x1388C4C
	private void WriteIPv4Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x1388C9C
	public Byte[] GetAddressBytes() { }

	// RVA: 0x1388DA4
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1388DBC
	public Int64 get_ScopeId() { }

	// RVA: 0x1388E18
	public override string ToString() { }

	// RVA: 0x1388F60
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1389078
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1389274
	public override bool Equals(object comparand) { }

	// RVA: 0x138927C
	public override int GetHashCode() { }

	// RVA: 0x1389630
	public IPAddress MapToIPv6() { }

	// RVA: 0x1387EFC
	private static Byte[] ThrowAddressNullException() { }

	// RVA: 0x138973C
	private static void .cctor() { }

}

// Namespace: System.Net
internal class IPAddressParser
{
	// Methods

	// RVA: 0x138834C
	internal static IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, bool tryParse) { }

	// RVA: 0x1388EF0
	internal static string IPv4AddressToString(UInt32 address) { }

	// RVA: 0x1389F50
	internal static void IPv4AddressToString(UInt32 address, StringBuilder destination) { }

	// RVA: 0x1389CAC
	private static int IPv4AddressToStringHelper(UInt32 address, Char* addressString) { }

	// RVA: 0x1388ED8
	internal static string IPv6AddressToString(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x138A09C
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x1389FD0
	private static void FormatIPv4AddressNumber(int number, Char* addressString, int offset) { }

	// RVA: 0x1389BF0
	public static bool Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, Int64 address) { }

	// RVA: 0x1389A84
	public static bool Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, UInt16* numbers, int numbersLength, UInt32 scope) { }

	// RVA: 0x138A22C
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x138A5C4
	private static void AppendHex(UInt16 value, StringBuilder buffer) { }

	// RVA: 0x138A58C
	private static UInt32 ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x138A660
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

	// RVA: 0x138A668
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x138A698
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x138A778
	public IPAddress get_Address() { }

	// RVA: 0x138A780
	public int get_Port() { }

	// RVA: 0x138A788
	public override string ToString() { }

	// RVA: 0x138A850
	public override SocketAddress Serialize() { }

	// RVA: 0x138A8C4
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x138AAD4
	public override bool Equals(object comparand) { }

	// RVA: 0x138ABAC
	public override int GetHashCode() { }

	// RVA: 0x138ABE8
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

	// RVA: 0x138D0C4
	internal void .ctor(string command) { }

	// RVA: 0x138D0F8
	internal void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x138D140
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

	// RVA: 0x138ACC8
	internal void .ctor(TcpClient client) { }

	// RVA: 0x138AD60
	internal virtual void Abort(Exception e) { }

	// RVA: 0x138AFC8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x138B148
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x138B1CC
	internal bool get_RecoverableFailure() { }

	// RVA: 0x138B1D4
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x138B1EC
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x138B8B4
	protected virtual void ClearState() { }

	// RVA: 0x138B930
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x138B938
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x138B9BC
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x138B2C0
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x138BA78
	internal void CheckContinuePipeline() { }

	// RVA: 0x138B34C
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x138BB34
	private bool PostSendCommandProcessing(Stream stream) { }

	// RVA: 0x138BFF8
	private bool PostReadCommandProcessing(Stream stream) { }

	// RVA: 0x138C2A0
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x138C2A8
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x138CB98
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x138CE88
	protected Encoding get_Encoding() { }

	// RVA: 0x138CE90
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x138CEE4
	protected virtual bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x138BC7C
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x138C5B0
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x138CEEC
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

	// RVA: 0x138D150
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x138D164
	internal bool get_PositiveCompletion() { }

	// RVA: 0x138D178
	internal bool get_TransientFailure() { }

	// RVA: 0x138D18C
	internal bool get_PermanentFailure() { }

	// RVA: 0x138D1A0
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x138D1B4
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

	// RVA: 0x138D234
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

	// RVA: 0x138F000
	public void .ctor() { }

	// RVA: 0x1392770
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

	// RVA: 0x138D358
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x138D410
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x138D4A8
	internal void .ctor(TcpClient client) { }

	// RVA: 0x138D540
	internal void AbortConnect() { }

	// RVA: 0x138D5E0
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x138DB08
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x138DCE0
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x138DEB8
	private PipelineInstruction QueueOrCreateFtpDataStream(Stream stream) { }

	// RVA: 0x138E64C
	protected override void ClearState() { }

	// RVA: 0x138E720
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x1390178
	protected override PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x138F008
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream, bool isSocketReady) { }

	// RVA: 0x139148C
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, string path, string directory, string filename) { }

	// RVA: 0x1391FA4
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x13920C4
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x13921E0
	internal Int64 get_ContentLength() { }

	// RVA: 0x13921E8
	internal DateTime get_LastModified() { }

	// RVA: 0x13921F0
	internal Uri get_ResponseUri() { }

	// RVA: 0x13921F8
	internal string get_BannerMessage() { }

	// RVA: 0x1392210
	internal string get_WelcomeMessage() { }

	// RVA: 0x1392228
	internal string get_ExitMessage() { }

	// RVA: 0x138FC20
	private Int64 GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x138FD54
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x138F88C
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x138F78C
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x13900E4
	private string GetLoginDirectory(string str) { }

	// RVA: 0x1391A9C
	private int GetPortV4(string responseString) { }

	// RVA: 0x1391C70
	private int GetPortV6(string responseString) { }

	// RVA: 0x1391674
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1391870
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x139135C
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1391E1C
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x1392240
	protected override bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x138E29C
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x139263C
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

	// RVA: 0x138E334
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x1392884
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1392A10
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1392E78
	private void CheckError() { }

	// RVA: 0x1392EC4
	public override bool get_CanRead() { }

	// RVA: 0x1392ECC
	public override bool get_CanSeek() { }

	// RVA: 0x1392EF0
	public override bool get_CanWrite() { }

	// RVA: 0x1392EF8
	public override Int64 get_Length() { }

	// RVA: 0x1392F1C
	public override Int64 get_Position() { }

	// RVA: 0x1392F40
	public override void set_Position(Int64 value) { }

	// RVA: 0x1392F68
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1393060
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1393190
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1393284
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x13935E4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x13938F4
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1393ADC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1393BD4
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1393CB8
	public override void Flush() { }

	// RVA: 0x1393CE0
	public override bool get_CanTimeout() { }

	// RVA: 0x1393D04
	public override int get_ReadTimeout() { }

	// RVA: 0x1393D2C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1393D54
	public override int get_WriteTimeout() { }

	// RVA: 0x1393D7C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1393DA4
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

	// RVA: 0x1393DF8
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x139147C
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x1391664
	internal bool get_IsCommandOnly() { }

	// RVA: 0x1392624
	internal bool get_IsUpload() { }

	// RVA: 0x1392630
	internal bool get_IsDownload() { }

	// RVA: 0x138F880
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x1393E5C
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x1393FD4
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

	// RVA: 0x139AEFC
	private void MoveNext() { }

	// RVA: 0x139B310
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

	// RVA: 0x139B31C
	private static void .cctor() { }

	// RVA: 0x139B388
	public void .ctor() { }

	// RVA: 0x139B390
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

	// RVA: 0x139477C
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x1394784
	public override string get_Method() { }

	// RVA: 0x13947A4
	public override void set_Method(string value) { }

	// RVA: 0x1394994
	public string get_RenameTo() { }

	// RVA: 0x139499C
	public override ICredentials get_Credentials() { }

	// RVA: 0x13949A4
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1394B48
	public override Uri get_RequestUri() { }

	// RVA: 0x1394B50
	public override int get_Timeout() { }

	// RVA: 0x1394B58
	internal int get_RemainingTimeout() { }

	// RVA: 0x1394B60
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1394B68
	public Int64 get_ContentOffset() { }

	// RVA: 0x1394B70
	public override Int64 get_ContentLength() { }

	// RVA: 0x1394B78
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1394B80
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1394BF0
	internal bool get_Aborted() { }

	// RVA: 0x1394BF8
	internal void .ctor(Uri uri) { }

	// RVA: 0x139519C
	public override WebResponse GetResponse() { }

	// RVA: 0x1396EC4
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x139767C
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1395F10
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x1398488
	private Exception TranslateConnectException(Exception e) { }

	// RVA: 0x1397AE4
	private void CreateConnectionAsync() { }

	// RVA: 0x1397B9C
	private FtpControlStream CreateConnection() { }

	// RVA: 0x1397DCC
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x1398710
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x1398678
	private Queue get_TimerQueue() { }

	// RVA: 0x1398214
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x1396A74
	private void SetException(Exception exception) { }

	// RVA: 0x13959F4
	private void CheckError() { }

	// RVA: 0x1399278
	internal void RequestCallback(object obj) { }

	// RVA: 0x1399E40
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x1399288
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x1395A8C
	private RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x139A2B4
	public override void Abort() { }

	// RVA: 0x139A790
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x139A800
	public bool get_UseBinary() { }

	// RVA: 0x139A808
	public bool get_UsePassive() { }

	// RVA: 0x138E520
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x139A810
	public bool get_EnableSsl() { }

	// RVA: 0x139A818
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x139A964
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1394974
	private bool get_InUse() { }

	// RVA: 0x13964B8
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x139AC88
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x139AD20
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FtpWebRequestCreator
{
	// Methods

	// RVA: 0x139B3E8
	internal void .ctor() { }

	// RVA: 0x139B3F0
	public WebRequest Create(Uri uri) { }

}

// Namespace: 
internal sealed class EmptyStream
{
	// Methods

	// RVA: 0x139B4E4
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

	// RVA: 0x139AAE4
	internal void .ctor(Stream responseStream, Int64 contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x139923C
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x139B45C
	public override Stream GetResponseStream() { }

	// RVA: 0x139AA18
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x139B5D0
	public override void Close() { }

	// RVA: 0x139B70C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x139B898
	public override Uri get_ResponseUri() { }

	// RVA: 0x139B8A0
	public FtpStatusCode get_StatusCode() { }

}

// Namespace: System.Net
internal class NetworkStreamWrapper
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Methods

	// RVA: 0x139B8A8
	internal void .ctor(TcpClient client) { }

	// RVA: 0x138E498
	protected bool get_UsingSecureStream() { }

	// RVA: 0x138D97C
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x138FC00
	internal Socket get_Socket() { }

	// RVA: 0x139B944
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x139B94C
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x139B954
	public override bool get_CanRead() { }

	// RVA: 0x139B978
	public override bool get_CanSeek() { }

	// RVA: 0x139B99C
	public override bool get_CanWrite() { }

	// RVA: 0x139B9C0
	public override bool get_CanTimeout() { }

	// RVA: 0x139B9E4
	public override int get_ReadTimeout() { }

	// RVA: 0x139BA0C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x139BA34
	public override int get_WriteTimeout() { }

	// RVA: 0x139BA5C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x139BA84
	public override Int64 get_Length() { }

	// RVA: 0x139BAA8
	public override Int64 get_Position() { }

	// RVA: 0x139BACC
	public override void set_Position(Int64 value) { }

	// RVA: 0x139BAF4
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x139BB1C
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x139BB44
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x139BB6C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x138DAC4
	internal void CloseSocket() { }

	// RVA: 0x139BC70
	public void Close(int timeout) { }

	// RVA: 0x139BCAC
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x139BCD4
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x139BCFC
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x139BD24
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x139BD4C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x139BD74
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x139BD9C
	public override void Flush() { }

	// RVA: 0x139BDC4
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1397D78
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

	// RVA: 0x139BDEC
	public void .ctor(string token) { }

	// RVA: 0x139BEB4
	public void .ctor(string token, bool finished) { }

	// RVA: 0x139BF70
	public string get_Message() { }

	// RVA: 0x139BF78
	public bool get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache
{
	// Methods

	// RVA: 0x139BF80
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x139BFFC
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x139C078
	private void .ctor() { }

	// RVA: 0x139C098
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint
{
	// Methods

	// RVA: 0x139C11C
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x139C1D0
	public virtual SocketAddress Serialize() { }

	// RVA: 0x139C284
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x139C2B0
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

	// RVA: 0x139C2B8
	public string get_HostName() { }

	// RVA: 0x139C2C0
	public void set_HostName(string value) { }

	// RVA: 0x139C2C8
	public void set_Aliases(string[] value) { }

	// RVA: 0x139C2D0
	public IPAddress[] get_AddressList() { }

	// RVA: 0x139C2D8
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x139C2E0
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

	// RVA: 0x138E294
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

	// RVA: 0x139C2F0
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x139C3E4
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x139CAA4
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x139C474
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x139CAC0
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

	// RVA: 0x139BEA0
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x139CB7C
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x139CB98
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x139CBA4
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper
{
	// Methods

	// RVA: 0x139C1FC
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x139C148
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x1395A08
	internal static WebException get_TimeoutException() { }

	// RVA: 0x139A990
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1391E9C
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

	// RVA: 0x139CD84
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x139CFA8
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x139CFB0
	public void .ctor(string P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate
{
	// Methods

	// RVA: 0x139D000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x139D0A4
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

	// RVA: 0x1395184
	public void .ctor(string userName, string password) { }

	// RVA: 0x139AE38
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1391460
	public string get_UserName() { }

	// RVA: 0x139D0B8
	public void set_UserName(string value) { }

	// RVA: 0x1391470
	public string get_Password() { }

	// RVA: 0x139D0E0
	public void set_Password(string value) { }

	// RVA: 0x1391468
	public string get_Domain() { }

	// RVA: 0x139D114
	public void set_Domain(string value) { }

	// RVA: 0x139D148
	internal string InternalGetUserName() { }

	// RVA: 0x139D13C
	internal string InternalGetPassword() { }

	// RVA: 0x139D150
	internal string InternalGetDomain() { }

	// RVA: 0x139D158
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException
{
	// Methods

	// RVA: 0x139D15C
	public void .ctor() { }

	// RVA: 0x139D164
	public void .ctor(string message) { }

	// RVA: 0x139D16C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x139D174
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x139D17C
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

	// RVA: 0x139D184
	public AddressFamily get_Family() { }

	// RVA: 0x139D1B8
	public int get_Size() { }

	// RVA: 0x139D1C0
	public Byte get_Item(int offset) { }

	// RVA: 0x139D240
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x139D378
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x139D5DC
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x139D63C
	internal IPAddress GetIPAddress() { }

	// RVA: 0x139D820
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x139D8C4
	public override bool Equals(object comparand) { }

	// RVA: 0x139D9D0
	public override int GetHashCode() { }

	// RVA: 0x139DD08
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

	// RVA: 0x139DFE4
	public void .ctor() { }

	// RVA: 0x1391650
	public void .ctor(string message) { }

	// RVA: 0x139922C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x138DA14
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x139DFF4
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x139916C
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x139E188
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x139E0BC
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x139E27C
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x139E37C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x139E38C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x139E398
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x139E3A0
	public WebExceptionStatus get_Status() { }

	// RVA: 0x139E3A8
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

	// RVA: 0x139E3B0
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x139E57C
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

	// RVA: 0x139E5FC
	private void NormalizeCommonHeaders() { }

	// RVA: 0x139E714
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x139E7E0
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x139E9DC
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x139EA24
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x139EB38
	internal void AddInternal(string name, string value) { }

	// RVA: 0x139EB98
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x139EBF8
	internal void RemoveInternal(string name) { }

	// RVA: 0x139EC58
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x139F020
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x139F0A8
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x139F220
	public override void Add(string name, string value) { }

	// RVA: 0x139F3DC
	public void Add(string header) { }

	// RVA: 0x139F6C8
	public override void Set(string name, string value) { }

	// RVA: 0x139F910
	internal void SetInternal(string name, string value) { }

	// RVA: 0x139FB4C
	public override void Remove(string name) { }

	// RVA: 0x139FC9C
	public override string[] GetValues(string header) { }

	// RVA: 0x139FED4
	public override string ToString() { }

	// RVA: 0x139FF3C
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x139A8F4
	public void .ctor() { }

	// RVA: 0x13A0270
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x13A036C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A056C
	public override void OnDeserialization(object sender) { }

	// RVA: 0x13A0570
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A06FC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A0708
	public override string Get(string name) { }

	// RVA: 0x13A0A40
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x13A0ABC
	public override int get_Count() { }

	// RVA: 0x13A0AF8
	public override string Get(int index) { }

	// RVA: 0x13A0B3C
	public override string GetKey(int index) { }

	// RVA: 0x13A0B80
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CaseInsensitiveAscii
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x13A1140
	public int GetHashCode(object myObject) { }

	// RVA: 0x13A1258
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x13A13DC
	private int FastGetHashCode(string myString) { }

	// RVA: 0x13A14DC
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x13A1690
	public void .ctor() { }

	// RVA: 0x13A1698
	private static void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate
{
	// Methods

	// RVA: 0x13A2EE4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x13A2DE8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass79_0
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x13A27F8
	public void .ctor() { }

	// RVA: 0x13A2F64
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

	// RVA: 0x13A1764
	private static object get_InternalSyncObject() { }

	// RVA: 0x13A1868
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x13A1CD8
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x13A1DCC
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x13A1B04
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x13A1EE8
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1395030
	protected void .ctor() { }

	// RVA: 0x13A2184
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A218C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A2198
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A219C
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x13A21A0
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x13A2270
	public virtual string get_Method() { }

	// RVA: 0x13A229C
	public virtual void set_Method(string value) { }

	// RVA: 0x13A22C8
	public virtual Uri get_RequestUri() { }

	// RVA: 0x13A22F4
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x13A2320
	public virtual Int64 get_ContentLength() { }

	// RVA: 0x13A234C
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x13A2378
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x13A23A4
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x13A23D0
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x13A23FC
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x13A2428
	public virtual int get_Timeout() { }

	// RVA: 0x13A2454
	public virtual WebResponse GetResponse() { }

	// RVA: 0x13A2480
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x13A24AC
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x13A24D8
	public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }

	// RVA: 0x13A2800
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x13A2870
	public virtual void Abort() { }

	// RVA: 0x13A289C
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x13A28A4
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x13A28AC
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x13A2AC8
	private static void .cctor() { }

	// RVA: 0x13A2DF0
	private System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Methods

	// RVA: 0x139B454
	protected void .ctor() { }

	// RVA: 0x13A326C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A3274
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A3280
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13A3284
	public virtual void Close() { }

	// RVA: 0x13A3288
	public void Dispose() { }

	// RVA: 0x13A3318
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x13A33B8
	public virtual bool get_IsFromCache() { }

	// RVA: 0x13A33C0
	public virtual Stream GetResponseStream() { }

	// RVA: 0x13A33EC
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x13A3418
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

	// RVA: 0x13A3444
	internal void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x13A3500
	internal void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser
{
	// Methods

	// RVA: 0x13A35BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13A3670
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

	// RVA: 0x13A3684
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

	// RVA: 0x13A36F8
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x13A377C
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x13A3B14
	private static void .cctor() { }

	// RVA: 0x139E8B4
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x13A1138
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

	// RVA: 0x13A5D14
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

	// RVA: 0x13A5C5C
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1393834
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x13A5D1C
	internal object get_AsyncObject() { }

	// RVA: 0x13A5D24
	public object get_AsyncState() { }

	// RVA: 0x13A5D2C
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x13A5D34
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x13A5DF4
	private bool LazilyCreateEvent(ManualResetEvent waitHandle) { }

	// RVA: 0x13A5FD8
	public bool get_CompletedSynchronously() { }

	// RVA: 0x13935A0
	public bool get_IsCompleted() { }

	// RVA: 0x1397660
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x13A601C
	internal bool get_EndCalled() { }

	// RVA: 0x13A6024
	internal void set_EndCalled(bool value) { }

	// RVA: 0x13A602C
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1393598
	internal void InvokeCallback(object result) { }

	// RVA: 0x1397670
	internal void InvokeCallback() { }

	// RVA: 0x13A625C
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x13A63FC
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x13A64C0
	protected virtual void Cleanup() { }

	// RVA: 0x1393AD4
	internal object InternalWaitForCompletion() { }

	// RVA: 0x13A64C4
	private object WaitForCompletion(bool snap) { }

}

// Namespace: System.Net
internal class NetRes
{
	// Methods

	// RVA: 0x139CCC8
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x13A67CC
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x13A6834
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Namespace: 
internal abstract class Queue
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x13A7AE8
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x13A7B14
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

	// RVA: 0x13A7B1C
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x13A7B54
	internal int get_StartTime() { }

	// RVA: 0x13A7B5C
	internal int get_Expiration() { }

	// RVA: -1
	internal abstract bool Cancel() { }

	// RVA: -1
	internal abstract bool get_HasExpired() { }

	// RVA: 0x13A7B68
	public void Dispose() { }

}

// Namespace: 
internal sealed class Callback
{
	// Methods

	// RVA: 0x1395060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13A7B74
	public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Namespace: 
private class TimerQueue
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x13A6D08
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x13A7BC4
	internal override Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x13A7754
	internal bool Fire(int nextExpiration) { }

}

// Namespace: 
private class InfiniteTimerQueue
{
	// Methods

	// RVA: 0x13A6CDC
	internal void .ctor() { }

	// RVA: 0x13A81B8
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

	// RVA: 0x13A7E30
	internal void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x13A7B88
	internal void .ctor() { }

	// RVA: 0x13A825C
	internal override bool get_HasExpired() { }

	// RVA: 0x13A826C
	internal TimerNode get_Next() { }

	// RVA: 0x13A8274
	internal void set_Next(TimerNode value) { }

	// RVA: 0x13A827C
	internal TimerNode get_Prev() { }

	// RVA: 0x13A8284
	internal void set_Prev(TimerNode value) { }

	// RVA: 0x13A828C
	internal override bool Cancel() { }

	// RVA: 0x13A7EB8
	internal bool Fire() { }

}

// Namespace: 
private class InfiniteTimer
{
	// Fields
	private int cancelled; // 0x18

	// Methods

	// RVA: 0x13A8224
	internal void .ctor() { }

	// RVA: 0x13A8434
	internal override bool get_HasExpired() { }

	// RVA: 0x13A843C
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

	// RVA: 0x13A6A10
	private static void .cctor() { }

	// RVA: 0x13A2B8C
	internal static Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1398868
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x13A6DCC
	private static void Prod() { }

	// RVA: 0x13A6EFC
	private static void ThreadProc() { }

	// RVA: 0x13A7938
	private static void StopTimerThread() { }

	// RVA: 0x13A7914
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x13A79B8
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

	// RVA: 0x13A8464
	public void .ctor() { }

	// RVA: 0x13A85B4
	public string get_Comment() { }

	// RVA: 0x13A85BC
	public void set_Comment(string value) { }

	// RVA: 0x13A85E4
	public void set_CommentUri(Uri value) { }

	// RVA: 0x13A85EC
	public void set_HttpOnly(bool value) { }

	// RVA: 0x13A85F4
	public void set_Discard(bool value) { }

	// RVA: 0x13A85FC
	public string get_Domain() { }

	// RVA: 0x13A8604
	public void set_Domain(string value) { }

	// RVA: 0x13A8664
	private string get__Domain() { }

	// RVA: 0x13A8754
	public bool get_Expired() { }

	// RVA: 0x13A883C
	public void set_Expires(DateTime value) { }

	// RVA: 0x13A8844
	public string get_Name() { }

	// RVA: 0x13A884C
	internal bool InternalSetName(string value) { }

	// RVA: 0x13A8970
	public string get_Path() { }

	// RVA: 0x13A8978
	public void set_Path(string value) { }

	// RVA: 0x13A89C4
	private string get__Path() { }

	// RVA: 0x13A8744
	internal bool get_Plain() { }

	// RVA: 0x13A8A58
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x13A8ABC
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x13A9558
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x13A95F0
	public void set_Port(string value) { }

	// RVA: 0x13A9980
	internal int[] get_PortList() { }

	// RVA: 0x13A9988
	private string get__Port() { }

	// RVA: 0x13A9A60
	public bool get_Secure() { }

	// RVA: 0x13A9A68
	public void set_Secure(bool value) { }

	// RVA: 0x13A9A70
	public string get_Value() { }

	// RVA: 0x13A9A78
	public void set_Value(string value) { }

	// RVA: 0x13A9AAC
	internal CookieVariant get_Variant() { }

	// RVA: 0x13A9AB4
	internal string get_DomainKey() { }

	// RVA: 0x13A9AD0
	public int get_Version() { }

	// RVA: 0x13A9AD8
	public void set_Version(int value) { }

	// RVA: 0x13A9B58
	private string get__Version() { }

	// RVA: 0x13A9C5C
	internal static IComparer GetComparer() { }

	// RVA: 0x13A9CD8
	public override bool Equals(object comparand) { }

	// RVA: 0x13A9DC0
	public override int GetHashCode() { }

	// RVA: 0x13A9FB4
	public override string ToString() { }

	// RVA: 0x13AA3AC
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

	// RVA: 0x126C22C
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x126C258
	internal CookieToken get_Token() { }

	// RVA: 0x126BC48
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

	// RVA: 0x126B328
	internal void .ctor(string tokenStream) { }

	// RVA: 0x126B36C
	internal bool get_EndOfCookie() { }

	// RVA: 0x126B374
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x126B37C
	internal bool get_Eof() { }

	// RVA: 0x126B38C
	internal string get_Name() { }

	// RVA: 0x126B394
	internal void set_Name(string value) { }

	// RVA: 0x126B39C
	internal bool get_Quoted() { }

	// RVA: 0x126B3A4
	internal void set_Quoted(bool value) { }

	// RVA: 0x126B3AC
	internal CookieToken get_Token() { }

	// RVA: 0x126B3B4
	internal void set_Token(CookieToken value) { }

	// RVA: 0x126B3BC
	internal string get_Value() { }

	// RVA: 0x126B3C4
	internal void set_Value(string value) { }

	// RVA: 0x126B3CC
	internal string Extract() { }

	// RVA: 0x126B444
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x126B76C
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x126B9FC
	internal void Reset() { }

	// RVA: 0x126BA5C
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x126BC70
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CookieParser
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x126C260
	internal void .ctor(string cookieString) { }

	// RVA: 0x126C2FC
	internal Cookie Get() { }

	// RVA: 0x126CAE8
	internal static string CheckQuoted(string value) { }

}

// Namespace: System.Net
internal class Comparer
{
	// Methods

	// RVA: 0x126CB88
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x126CC70
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

	// RVA: 0x126DCAC
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x126DD18
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x126DDC0
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x126DE60
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

	// RVA: 0x126CC78
	public void .ctor() { }

	// RVA: 0x126CD30
	public Cookie get_Item(int index) { }

	// RVA: 0x126CE24
	public void Add(Cookie cookie) { }

	// RVA: 0x126D2B0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x126D648
	public int get_Count() { }

	// RVA: 0x126D670
	public bool get_IsSynchronized() { }

	// RVA: 0x126D678
	public object get_SyncRoot() { }

	// RVA: 0x126D67C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x126D6A4
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0x126D7AC
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x126D7B4
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x126CEE8
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x126DC84
	internal void RemoveAt(int idx) { }

	// RVA: 0x126D5A0
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields
	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Methods

	// RVA: 0x126DE6C
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x126DE98
	internal string get_Name() { }

	// RVA: 0x126DEA0
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

	// RVA: 0x126DEA8
	public void .ctor() { }

	// RVA: 0x126DFC8
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x126E108
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x126EFB4
	private bool AgeCookies(string domain) { }

	// RVA: 0x1270490
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1270664
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1270AF4
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x12711C8
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1271510
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1271DF8
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1272028
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1272124
	internal string GetCookieHeader(Uri uri, string optCookie2) { }

	// RVA: 0x12724B4
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private class PathListComparer
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x12725E8
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1272844
	public void .ctor() { }

	// RVA: 0x127284C
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
internal class PathList
{
	// Fields
	private SortedList m_list; // 0x10

	// Methods

	// RVA: 0x126E96C
	public void .ctor() { }

	// RVA: 0x127063C
	public int get_Count() { }

	// RVA: 0x126EA24
	public int GetCookiesCount() { }

	// RVA: 0x1270468
	public ICollection get_Values() { }

	// RVA: 0x126EE78
	public object get_Item(string s) { }

	// RVA: 0x126EEA0
	public void set_Item(string s, object value) { }

	// RVA: 0x1271DD0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x126EE50
	public object get_SyncRoot() { }

}

// Namespace: System.Net
[Serializable]
public class CookieException
{
	// Methods

	// RVA: 0x12728B8
	public void .ctor() { }

	// RVA: 0x126E964
	internal void .ctor(string message) { }

	// RVA: 0x1270460
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x12728C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12728C8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12728D0
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

	// RVA: 0x12728D8
	internal void .ctor(Uri uri) { }

	// RVA: 0x1272A68
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1272E90
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1272E9C
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x127313C
	internal bool get_Aborted() { }

	// RVA: 0x127314C
	public override Int64 get_ContentLength() { }

	// RVA: 0x1273154
	public override ICredentials get_Credentials() { }

	// RVA: 0x127315C
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1273164
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x127316C
	public override string get_Method() { }

	// RVA: 0x1273174
	public override void set_Method(string value) { }

	// RVA: 0x1273270
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1273278
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1273280
	public override int get_Timeout() { }

	// RVA: 0x1273288
	public override Uri get_RequestUri() { }

	// RVA: 0x1273290
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x12735C0
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x12738A4
	public override WebResponse GetResponse() { }

	// RVA: 0x1273C14
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1273F40
	private static void GetResponseCallback(object state) { }

	// RVA: 0x12745F0
	internal void UnblockReader() { }

	// RVA: 0x12746E0
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1274710
	public override void Abort() { }

	// RVA: 0x1274A8C
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator
{
	// Methods

	// RVA: 0x1274B7C
	internal void .ctor() { }

	// RVA: 0x1274B84
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1273E98
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1274BE8
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1274CA8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1274D84
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1274DC4
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1274F5C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1275070
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1275184
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x127522C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1275340
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1274ED8
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

	// RVA: 0x127427C
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x12753E8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x127565C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1275668
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1275820
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x12758C4
	public override Uri get_ResponseUri() { }

	// RVA: 0x1275844
	private void CheckDisposed() { }

	// RVA: 0x12758E8
	public override void Close() { }

	// RVA: 0x127598C
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1275B10
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

	// RVA: 0x1275B6C
	public void .ctor() { }

	// RVA: 0x1275BE0
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x1275FA4
	public ICredentials get_Credentials() { }

	// RVA: 0x1275FAC
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x1276034
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x12760C8
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1275CB8
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x127643C
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x12765F0
	private bool IsLocal(Uri host) { }

	// RVA: 0x127678C
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x1276894
	public bool IsBypassed(Uri host) { }

	// RVA: 0x127634C
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1276A30
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1276E30
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1276E3C
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1276FD0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x1276FD8
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x127703C
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1276E24
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x12762C4
	private bool GetProxyAuto(Uri destination, Uri proxyUri) { }

	// RVA: 0x12769BC
	private bool IsBypassedAuto(Uri destination, bool isBypassed) { }

	// RVA: 0x1277094
	private static bool AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, bool checkFirstOnly) { }

	// RVA: 0x1277370
	private static Uri ProxyUri(string proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine
{
	// Methods

	// RVA: 0x1277070
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList) { }

	// RVA: 0x1277418
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList, int syncStatus) { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x1277AD0
	internal static string ToString(int position) { }

	// RVA: 0x1277B70
	private static void .cctor() { }

}

// Namespace: 
internal static class HttpApi
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x127743C
	private static void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper
{
	// Methods

	// RVA: 0x1278414
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x1278570
	internal static SecureString CreateSecureString(string plainString) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods
{}

// Namespace: System.Net
internal static class Logging
{
	// Methods

	// RVA: 0x12735B8
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

	// RVA: 0x1278900
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
internal class ServerCertValidationCallback
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x1278620
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x12786B0
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x12786B8
	internal void Callback(object state) { }

	// RVA: 0x127876C
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

	// RVA: 0x1278978
	private static void EnsureModules() { }

	// RVA: 0x1278C34
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1278D38
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1279208
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x1279724
	private static void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient
{
	// Methods

	// RVA: 0x12797B8
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1279BDC
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x1279868
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1279C9C
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1279CA8
	public string get_AuthenticationType() { }

	// RVA: 0x1278C2C
	public void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint
{
	// Methods

	// RVA: 0x1279CEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1279E10
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

	// RVA: 0x127A06C
	private void MoveNext() { }

	// RVA: 0x127A3DC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class BufferedReadStream
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x1279E24
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x1279E58
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1279FC4
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

	// RVA: 0x127A45C
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x127A57C
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x127A548
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x127A584
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x127A5AC
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

	// RVA: 0x127A6DC
	public void .ctor(string header) { }

	// RVA: 0x127A7C4
	public string get_Realm() { }

	// RVA: 0x127A7F0
	public string get_Opaque() { }

	// RVA: 0x127A820
	public string get_Nonce() { }

	// RVA: 0x127A850
	public string get_Algorithm() { }

	// RVA: 0x127A880
	public string get_QOP() { }

	// RVA: 0x127A8B0
	public bool Parse() { }

	// RVA: 0x127AD5C
	private void SkipWhitespace() { }

	// RVA: 0x127ADE8
	private string GetKey() { }

	// RVA: 0x127AAEC
	private bool GetKeywordAndValue(string key, string value) { }

	// RVA: 0x127AEDC
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

	// RVA: 0x127B060
	private static void .cctor() { }

	// RVA: 0x127B0C0
	public void .ctor() { }

	// RVA: 0x127B13C
	public string get_Algorithm() { }

	// RVA: 0x127B174
	public string get_Realm() { }

	// RVA: 0x127B1A8
	public string get_Nonce() { }

	// RVA: 0x127B1E0
	public string get_Opaque() { }

	// RVA: 0x127B218
	public string get_QOP() { }

	// RVA: 0x127B250
	public string get_CNonce() { }

	// RVA: 0x127B368
	public bool Parse(string challenge) { }

	// RVA: 0x127B46C
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x127B5D8
	private string HA1(string username, string password) { }

	// RVA: 0x127B714
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x127B800
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x127B980
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x127BFD0
	public DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Methods

	// RVA: 0x127BFD8
	private static Hashtable get_Cache() { }

	// RVA: 0x127C17C
	private static void CheckExpired(int count) { }

	// RVA: 0x127C99C
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x127CCA0
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x127CE44
	public string get_AuthenticationType() { }

	// RVA: 0x1278C24
	public void .ctor() { }

	// RVA: 0x127CE88
	private static void .cctor() { }

}

// Namespace: 
private sealed class GetHostAddressesCallback
{
	// Methods

	// RVA: 0x127D16C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x127E040
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x127D220
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x127D37C
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public static class Dns
{
	// Methods

	// RVA: 0x127CF1C
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x127D270
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x127D388
	private static bool GetHostByName_icall(string host, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x127D38C
	private static bool GetHostByAddr_icall(string addr, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x127D390
	private static bool GetHostName_icall(string h_name) { }

	// RVA: 0x127D394
	private static void Error_11001(string hostName) { }

	// RVA: 0x127D3FC
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x127D784
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x127D904
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x127DAB0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x127DC60
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x127DB24
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x127DE84
	public static string GetHostName() { }

	// RVA: 0x127DF1C
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

	// RVA: 0x127E1F4
	private void MoveNext() { }

	// RVA: 0x127E568
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class FixedSizeReadStream
{
	// Fields
	private readonly Int64 <ContentLength>k__BackingField; // 0x40
	private Int64 position; // 0x48

	// Methods

	// RVA: 0x127E054
	public Int64 get_ContentLength() { }

	// RVA: 0x127E05C
	public void .ctor(WebOperation operation, Stream innerStream, Int64 contentLength) { }

	// RVA: 0x127E088
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class HttpRequestCreator
{
	// Methods

	// RVA: 0x127E5E8
	internal void .ctor() { }

	// RVA: 0x127E5F0
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

	// RVA: 0x128272C
	public bool get_IsCompleted() { }

	// RVA: 0x1282734
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x128273C
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x127EB34
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1281A68
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1282550
	public void Reset() { }

	// RVA: 0x128275C
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
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

	// RVA: 0x35263A0
	private void MoveNext() { }

	// RVA: 0x35267E8
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

	// RVA: 0x1282854
	private void MoveNext() { }

	// RVA: 0x1283BFC
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

	// RVA: 0x1283C7C
	private void MoveNext() { }

	// RVA: 0x12848C4
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

	// RVA: 0x1284944
	private void MoveNext() { }

	// RVA: 0x1284DEC
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

	// RVA: 0x127E8B8
	private static void .cctor() { }

	// RVA: 0x127E654
	public void .ctor(Uri uri) { }

	// RVA: 0x127E9CC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x127E94C
	private void ResetAuthorization() { }

	// RVA: 0x127EB68
	public Uri get_Address() { }

	// RVA: 0x127EB70
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x127EB78
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x127EB80
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x127EB94
	private bool get_MethodWithBuffer() { }

	// RVA: 0x127ECA0
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x127ECA8
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x127ECB0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x127ED38
	public override Int64 get_ContentLength() { }

	// RVA: 0x127ED40
	internal void set_InternalContentLength(Int64 value) { }

	// RVA: 0x127ED48
	internal bool get_ThrowOnError() { }

	// RVA: 0x127ED50
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x127ED58
	public override ICredentials get_Credentials() { }

	// RVA: 0x127ED60
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x127ED68
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x127EDE4
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x127EDEC
	public string get_Host() { }

	// RVA: 0x127EF44
	public bool get_KeepAlive() { }

	// RVA: 0x127EF4C
	public int get_ReadWriteTimeout() { }

	// RVA: 0x127EF54
	public override string get_Method() { }

	// RVA: 0x127EF5C
	public override void set_Method(string value) { }

	// RVA: 0x127F1B8
	public Version get_ProtocolVersion() { }

	// RVA: 0x127F1C0
	public override IWebProxy get_Proxy() { }

	// RVA: 0x127F1C8
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x127F414
	public override Uri get_RequestUri() { }

	// RVA: 0x127F41C
	public bool get_SendChunked() { }

	// RVA: 0x127F424
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x127F428
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x127F430
	public override int get_Timeout() { }

	// RVA: 0x127F438
	public string get_TransferEncoding() { }

	// RVA: 0x127F490
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x127F524
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x127F52C
	internal bool get_ExpectContinue() { }

	// RVA: 0x127F534
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x127F53C
	internal Uri get_AuthUri() { }

	// RVA: 0x127F544
	internal bool get_ProxyQuery() { }

	// RVA: 0x127F580
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x127F588
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x127F2B8
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x127F5A0
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x26AD93C
	internal static System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationToken cancellationToken) { }

	// RVA: -1
	private static System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationTokenSource cts) { }

	// RVA: 0x35258B4
	private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }

	// RVA: 0x127F7F4
	private System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x127F940
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x127FA9C
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x127FB6C
	private WebException GetWebException(Exception e) { }

	// RVA: 0x127FC1C
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x127FDF4
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x127FEB4
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x128007C
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x12801D0
	public override WebResponse GetResponse() { }

	// RVA: 0x12802EC
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x127FBF0
	internal bool get_Aborted() { }

	// RVA: 0x12802F4
	public override void Abort() { }

	// RVA: 0x1280418
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1280458
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x127F250
	private void CheckRequestStarted() { }

	// RVA: 0x1280498
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x12804B4
	private void RewriteRedirectToGet() { }

	// RVA: 0x1280544
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1280B00
	private string GetHeaders() { }

	// RVA: 0x12811F8
	private void DoPreAuthenticate() { }

	// RVA: 0x128143C
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0x128178C
	private System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1281A50
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1281DB8
	private System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1281FC4
	private System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x35251DC
	private bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x12825D8
	private System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	// RVA: 0x12826F0
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

	// RVA: 0x1284E6C
	public void .ctor() { }

	// RVA: 0x1284E74
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x128455C
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x12851C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12855BC
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x12855C4
	public override Uri get_ResponseUri() { }

	// RVA: 0x1285668
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1285670
	public virtual string get_StatusDescription() { }

	// RVA: 0x1285694
	public override Stream GetResponseStream() { }

	// RVA: 0x128573C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1285748
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1285914
	public override void Close() { }

	// RVA: 0x1285948
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1285958
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12855E8
	private void CheckDisposed() { }

	// RVA: 0x1284F6C
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

	// RVA: 0x1286C0C
	public void .ctor(Byte[] chunk) { }

	// RVA: 0x1286C40
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

	// RVA: 0x128596C
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1285A48
	public int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1285A4C
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1285E44
	public void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1285E70
	private void InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1286A1C
	public bool get_WantMore() { }

	// RVA: 0x1286A40
	public bool get_DataAvailable() { }

	// RVA: 0x1286B54
	public int get_ChunkLeft() { }

	// RVA: 0x12863A4
	private State ReadBody(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1285FB0
	private State GetChunkSize(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1286BB4
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x12864EC
	private State ReadCRLF(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1286650
	private State ReadTrailer(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1286B60
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

	// RVA: 0x1287284
	private void MoveNext() { }

	// RVA: 0x1287738
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

	// RVA: 0x12877B8
	private void MoveNext() { }

	// RVA: 0x1287D94
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class MonoChunkStream
{
	// Fields
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Methods

	// RVA: 0x1286CA4
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x1286CAC
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x1286E64
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1286FD0
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x12870DC
	private static void ThrowExpectingChunkTrailer() { }

	// RVA: 0x128713C
	private Task <>n__0(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class NtlmClient
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Methods

	// RVA: 0x1287E00
	public void .ctor() { }

	// RVA: 0x1287E78
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1287F58
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1287F60
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

	// RVA: 0x1287FA4
	internal void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1288324
	internal SPKey get_Key() { }

	// RVA: 0x128832C
	private ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1288334
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x128833C
	public Uri get_Address() { }

	// RVA: 0x1288344
	public int get_ConnectionLimit() { }

	// RVA: 0x128834C
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x1288354
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x128835C
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x1288364
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x128836C
	internal bool get_SendContinue() { }

	// RVA: 0x1288414
	internal void set_SendContinue(bool value) { }

	// RVA: 0x128841C
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x12884CC
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x1288640
	private static void PutBytes(Byte[] bytes, UInt32 v, int offset) { }

	// RVA: 0x12886C4
	internal bool get_UsesProxy() { }

	// RVA: 0x12886CC
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x12886D4
	internal bool get_UseConnect() { }

	// RVA: 0x12886DC
	internal void set_UseConnect(bool value) { }

	// RVA: 0x12886E4
	private bool get_HasTimedOut() { }

	// RVA: 0x1288850
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x1288C4C
	internal void SetVersion(Version version) { }

	// RVA: 0x1288C54
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1288F20
	internal void FreeServicePoint() { }

	// RVA: 0x1288F34
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x1288F8C
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x1288FE4
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

	// RVA: 0x1289D18
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x1289E30
	public bool get_UsesProxy() { }

	// RVA: 0x1289E9C
	public override int GetHashCode() { }

	// RVA: 0x1289F7C
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

	// RVA: 0x1289230
	private static void .cctor() { }

	// RVA: 0x12892F4
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x1289370
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x12893EC
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x1289468
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x12894E4
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1289560
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x128960C
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x1289D74
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

	// RVA: 0x128C15C
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x128A284
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x128AAB4
	public bool IsEmpty() { }

	// RVA: 0x128B50C
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x128B6DC
	public void Cleanup() { }

	// RVA: 0x128BF94
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x128BA20
	public WebOperation GetNextOperation() { }

	// RVA: 0x128C240
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x128B81C
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

	// RVA: 0x128CEC0
	private static void .cctor() { }

	// RVA: 0x128CF2C
	public void .ctor() { }

	// RVA: 0x128CF34
	internal bool <Set>b__4_0(object s) { }

}

// Namespace: 
private class AsyncManualResetEvent
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs; // 0x10

	// Methods

	// RVA: 0x128CE60
	public System.Threading.Tasks.Task<System.Boolean> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x128A4C8
	public void Set() { }

	// RVA: 0x128AEB0
	public void Reset() { }

	// RVA: 0x128A1C8
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

	// RVA: 0x128CFE8
	private void MoveNext() { }

	// RVA: 0x128DD60
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

	// RVA: 0x128DDCC
	private void MoveNext() { }

	// RVA: 0x128E354
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

	// RVA: 0x128A1B0
	private ServicePoint get_ServicePoint() { }

	// RVA: 0x128A1B8
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x128A1C0
	public int get_MaxIdleTime() { }

	// RVA: 0x12880B0
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x128A3C8
	public void Run() { }

	// RVA: 0x128A7A0
	private Task RunScheduler() { }

	// RVA: 0x128A88C
	private void Cleanup() { }

	// RVA: 0x128AB34
	private void RunSchedulerIteration() { }

	// RVA: 0x128B070
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x128B9E4
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x128AF7C
	private bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x128BB7C
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x128B5B8
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x128BCA0
	private void FinalCleanup() { }

	// RVA: 0x1288DE8
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x128BD74
	private ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x128BFF8
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x128C004
	private void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x128C02C
	public static System.Threading.Tasks.Task<System.Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x128C158
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

	// RVA: 0x26AD93C
	public Status get_Status() { }

	// RVA: 0x35251DC
	public bool get_Success() { }

	// RVA: 0x3525804
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x26AD93C
	public T get_Argument() { }

	// RVA: 0x26AD93C
	public void .ctor(T argument) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x35263A0
	private void MoveNext() { }

	// RVA: 0x35267E8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebCompletionSource<T0>
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion; // 0x0
	private Result currentResult; // 0x0

	// Methods

	// RVA: 0x352642C
	public void .ctor(bool runAsync) { }

	// RVA: 0x3525804
	internal Result get_CurrentResult() { }

	// RVA: 0x3525804
	internal Task get_Task() { }

	// RVA: 0x26AD93C
	public bool TrySetCompleted(T argument) { }

	// RVA: 0x35251DC
	public bool TrySetCompleted() { }

	// RVA: 0x35251DC
	public bool TrySetCanceled() { }

	// RVA: 0x35252FC
	public bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x35252FC
	public bool TrySetException(Exception error) { }

	// RVA: 0x35263A0
	public void ThrowOnError() { }

	// RVA: 0x3525804
	public System.Threading.Tasks.Task<T> WaitForCompletion() { }

}

// Namespace: System.Net
internal class WebCompletionSource
{
	// Methods

	// RVA: 0x128E3D4
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

	// RVA: 0x128F8D0
	private static void .cctor() { }

	// RVA: 0x128F93C
	public void .ctor() { }

	// RVA: 0x128F944
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x128F9E8
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

	// RVA: 0x128FAEC
	private void MoveNext() { }

	// RVA: 0x1290930
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

	// RVA: 0x129099C
	private void MoveNext() { }

	// RVA: 0x12913FC
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

	// RVA: 0x129147C
	private void MoveNext() { }

	// RVA: 0x1291DB8
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

	// RVA: 0x128E42C
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x128CE2C
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x128E434
	private bool CanReuse() { }

	// RVA: 0x128E464
	private bool CheckReusable() { }

	// RVA: 0x128E534
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x128E65C
	private System.Threading.Tasks.Task<System.Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x128E7BC
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x128E914
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x128EA8C
	internal static bool ReadLine(Byte[] buffer, int start, int max, string output) { }

	// RVA: 0x128C72C
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x128ECB8
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x128F020
	private void Reset() { }

	// RVA: 0x128F138
	private void Close(bool reset) { }

	// RVA: 0x128F210
	private void CloseSocket() { }

	// RVA: 0x128C1AC
	public bool get_Closed() { }

	// RVA: 0x128F504
	public DateTime get_IdleSince() { }

	// RVA: 0x128CB78
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x128B2EC
	public bool Continue(WebOperation next) { }

	// RVA: 0x128F858
	private void Dispose(bool disposing) { }

	// RVA: 0x128C164
	public void Dispose() { }

	// RVA: 0x128F104
	private void ResetNtlm() { }

	// RVA: 0x128F8A0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x128F8A8
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x128F8B0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x128F8B8
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x128F8C0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x128F8C8
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

	// RVA: 0x1291E38
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x1291F34
	internal HttpWebRequest get_Request() { }

	// RVA: 0x1291F3C
	internal WebConnection get_Connection() { }

	// RVA: 0x1291F44
	internal WebOperation get_Operation() { }

	// RVA: 0x1291F4C
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x1291F6C
	public override bool get_CanTimeout() { }

	// RVA: 0x1291F74
	public override int get_ReadTimeout() { }

	// RVA: 0x1291F7C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1291FE8
	public override int get_WriteTimeout() { }

	// RVA: 0x1291FF0
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x129205C
	protected Exception GetException(Exception e) { }

	// RVA: -1
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x1292228
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12925D4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1292834
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1292988
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1292BC4
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1292CD4
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1292F5C
	public override void Flush() { }

	// RVA: 0x1292F60
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12930B0
	internal void InternalClose() { }

	// RVA: -1
	protected abstract void Close_internal(bool disposed) { }

	// RVA: 0x12930BC
	public override void Close() { }

	// RVA: 0x12930D0
	public override Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0x1293124
	public override bool get_CanSeek() { }

	// RVA: 0x129312C
	public override Int64 get_Length() { }

	// RVA: 0x1293180
	public override Int64 get_Position() { }

	// RVA: 0x12931D4
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

	// RVA: 0x12934BC
	private void MoveNext() { }

	// RVA: 0x129428C
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

	// RVA: 0x12942F8
	private void MoveNext() { }

	// RVA: 0x1294DA8
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

	// RVA: 0x1293228
	public HttpWebRequest get_Request() { }

	// RVA: 0x1293230
	public Uri get_ConnectUri() { }

	// RVA: 0x1291284
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x1293238
	public bool get_Success() { }

	// RVA: 0x1293240
	private void set_Success(bool value) { }

	// RVA: 0x1293248
	public bool get_CloseConnection() { }

	// RVA: 0x1293250
	private void set_CloseConnection(bool value) { }

	// RVA: 0x1293258
	public int get_StatusCode() { }

	// RVA: 0x1293260
	private void set_StatusCode(int value) { }

	// RVA: 0x1293268
	private void set_StatusDescription(string value) { }

	// RVA: 0x1293270
	public string[] get_Challenge() { }

	// RVA: 0x1293278
	private void set_Challenge(string[] value) { }

	// RVA: 0x1293280
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x1293288
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1293290
	public Version get_ProxyVersion() { }

	// RVA: 0x1293298
	private void set_ProxyVersion(Version value) { }

	// RVA: 0x12932A0
	public Byte[] get_Data() { }

	// RVA: 0x12932A8
	private void set_Data(Byte[] value) { }

	// RVA: 0x12912D4
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x12932B0
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x129340C
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

	// RVA: 0x1295D10
	private void MoveNext() { }

	// RVA: 0x1296718
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

	// RVA: 0x1294E28
	public HttpWebRequest get_Request() { }

	// RVA: 0x1294E30
	public WebConnection get_Connection() { }

	// RVA: 0x1294E38
	private void set_Connection(WebConnection value) { }

	// RVA: 0x1294E40
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1294E48
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1294E50
	public BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x1294E58
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x1294E60
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x128C1BC
	public bool get_Aborted() { }

	// RVA: 0x1295048
	public bool get_Closed() { }

	// RVA: 0x12950D4
	public void Abort() { }

	// RVA: 0x12952F0
	public void Close() { }

	// RVA: 0x129521C
	private void SetCanceled() { }

	// RVA: 0x1295754
	private void SetError(Exception error) { }

	// RVA: 0x1295124
	private System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(ExceptionDispatchInfo field) { }

	// RVA: 0x1295804
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1295940
	internal void ThrowIfDisposed() { }

	// RVA: 0x1290838
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1292568
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x1291B40
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x12958DC
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ExceptionDispatchInfo field) { }

	// RVA: 0x128F50C
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x12959AC
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x1295B40
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x1295B94
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x1295C08
	public System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }

	// RVA: 0x1295C5C
	internal System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }

	// RVA: 0x128F7A0
	internal void Run() { }

	// RVA: 0x1295C64
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x1295498
	internal void Finish(bool ok, Exception error) { }

	// RVA: 0x1295CE8
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

	// RVA: 0x129733C
	private void MoveNext() { }

	// RVA: 0x1297950
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

	// RVA: 0x1296724
	public WebOperation get_Operation() { }

	// RVA: 0x129672C
	protected Stream get_InnerStream() { }

	// RVA: 0x1286DD0
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x1296734
	public override Int64 get_Length() { }

	// RVA: 0x1296774
	public override Int64 get_Position() { }

	// RVA: 0x12967B4
	public override void set_Position(Int64 value) { }

	// RVA: 0x12967F4
	public override bool get_CanSeek() { }

	// RVA: 0x12967FC
	public override bool get_CanRead() { }

	// RVA: 0x1296804
	public override bool get_CanWrite() { }

	// RVA: 0x129680C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x129684C
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x129688C
	public override void Flush() { }

	// RVA: 0x12968CC
	protected Exception GetException(Exception e) { }

	// RVA: 0x1296A98
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1296DBC
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x129701C
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1297170
	public sealed override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1287140
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x12972D4
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

	// RVA: 0x1298A04
	private void MoveNext() { }

	// RVA: 0x1298DE8
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

	// RVA: 0x1298E54
	private void MoveNext() { }

	// RVA: 0x1299428
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

	// RVA: 0x1299494
	private void MoveNext() { }

	// RVA: 0x1299AB0
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

	// RVA: 0x1299B1C
	private void MoveNext() { }

	// RVA: 0x1299EEC
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

	// RVA: 0x1299F58
	private void MoveNext() { }

	// RVA: 0x129A718
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

	// RVA: 0x129A784
	private void MoveNext() { }

	// RVA: 0x129AD70
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

	// RVA: 0x129ADDC
	private void MoveNext() { }

	// RVA: 0x129B0B0
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

	// RVA: 0x129B11C
	private void MoveNext() { }

	// RVA: 0x129BACC
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

	// RVA: 0x1291C1C
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x12979D0
	internal Stream get_InnerStream() { }

	// RVA: 0x12979D8
	public bool get_KeepAlive() { }

	// RVA: 0x12979E0
	public override bool get_CanRead() { }

	// RVA: 0x12979E8
	public override bool get_CanWrite() { }

	// RVA: 0x12979F0
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x1297A2C
	internal int get_WriteBufferLength() { }

	// RVA: 0x1297A7C
	internal BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x1297B7C
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x1297C80
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1297F5C
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x12980AC
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12981E4
	private void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0x1296474
	internal Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x129828C
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x129839C
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12984A4
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x12985A8
	private Task WriteChunkTrailer() { }

	// RVA: 0x1298280
	internal void KillBuffer() { }

	// RVA: 0x1298698
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1298764
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x12987A4
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x1298960
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

	// RVA: 0x129D698
	private void MoveNext() { }

	// RVA: 0x129E16C
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

	// RVA: 0x129BFE0
	public void .ctor() { }

	// RVA: 0x129E1EC
	internal System.Threading.Tasks.Task<System.Int32> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x129E22C
	internal void <ProcessRead>b__1() { }

	// RVA: 0x129E29C
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

	// RVA: 0x129E32C
	private void MoveNext() { }

	// RVA: 0x129E980
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

	// RVA: 0x129EA00
	private void MoveNext() { }

	// RVA: 0x129F5FC
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

	// RVA: 0x129F668
	private void MoveNext() { }

	// RVA: 0x129FFD0
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

	// RVA: 0x129BB38
	public WebRequestStream get_RequestStream() { }

	// RVA: 0x129BB40
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x129BB48
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x129BB50
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x129BB58
	private void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x129BB60
	public string get_StatusDescription() { }

	// RVA: 0x129BB68
	private void set_StatusDescription(string value) { }

	// RVA: 0x129BB70
	public Version get_Version() { }

	// RVA: 0x129BB78
	private void set_Version(Version value) { }

	// RVA: 0x129BB80
	public bool get_KeepAlive() { }

	// RVA: 0x129BB88
	private void set_KeepAlive(bool value) { }

	// RVA: 0x129657C
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x129BB90
	public override bool get_CanRead() { }

	// RVA: 0x129BB98
	public override bool get_CanWrite() { }

	// RVA: 0x129BBA0
	private bool get_ChunkedRead() { }

	// RVA: 0x129BBA8
	private void set_ChunkedRead(bool value) { }

	// RVA: 0x129BBB0
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x129BD1C
	private System.Threading.Tasks.Task<System.Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x129BFE8
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x129C0B8
	private bool get_ExpectContent() { }

	// RVA: 0x129C150
	private void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x129C7F8
	private System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x129C938
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x129CA4C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x129CB04
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x129CBB4
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x1296610
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x129CE60
	private bool GetResponse(BufferOffsetSize buffer, int pos, ReadState state) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties
{
	// Methods

	// RVA: 0x12A003C
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x12A00EC
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1
	public abstract string get_DomainName() { }

	// RVA: 0x12A0144
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException
{
	// Methods

	// RVA: 0x12A014C
	public void .ctor() { }

	// RVA: 0x12A01BC
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

	// RVA: 0x12A0094
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties
{
	// Methods

	// RVA: 0x12A01C4
	private static extern int getdomainname(Byte[] name, int len) { }

	// RVA: 0x12A025C
	public override string get_DomainName() { }

	// RVA: 0x12A0468
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties
{
	// Methods

	// RVA: 0x12A0470
	public void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties
{
	// Methods

	// RVA: 0x12A0478
	public override string get_DomainName() { }

	// RVA: 0x12A0490
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

	// RVA: 0x12A0498
	public void .ctor(string procDir) { }

	// RVA: 0x12A0650
	private static void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal
{
	// Fields
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Methods

	// RVA: 0x12A06F4
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x12A0740
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Methods

	// RVA: 0x12A087C
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x12A0884
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x12A088C
	internal static object get_ClassSyncObject() { }

	// RVA: 0x12A0944
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x12A0B18
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x12A0B10
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

	// RVA: 0x12A0B20
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x12A0B9C
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x12A0BA4
	public void .ctor() { }

	// RVA: 0x12A0BBC
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x12A0C38
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator
{
	// Methods

	// RVA: 0x12A0CDC
	public object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Methods

	// RVA: 0x12A0D1C
	internal RequestCache get_Cache() { }

	// RVA: 0x12A0D24
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

	// RVA: 0x12A0D2C
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x12A0DA8
	public RequestCacheLevel get_Level() { }

	// RVA: 0x12A0DB0
	public override string ToString() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol
{
	// Methods

	// RVA: 0x12A0E48
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

	// RVA: 0x12A0E90
	public void .ctor(Socket socket) { }

	// RVA: 0x12A1080
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x12A0E9C
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x12A108C
	public override bool get_CanRead() { }

	// RVA: 0x12A1094
	public override bool get_CanSeek() { }

	// RVA: 0x12A109C
	public override bool get_CanWrite() { }

	// RVA: 0x12A10A4
	public override bool get_CanTimeout() { }

	// RVA: 0x12A10AC
	public override int get_ReadTimeout() { }

	// RVA: 0x12A12D0
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x12A1520
	public override int get_WriteTimeout() { }

	// RVA: 0x12A1580
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x12A1608
	public override Int64 get_Length() { }

	// RVA: 0x12A165C
	public override Int64 get_Position() { }

	// RVA: 0x12A16B0
	public override void set_Position(Int64 value) { }

	// RVA: 0x12A1704
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x12A1758
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12A1B7C
	public override int Read(System.Span<System.Byte> destination) { }

	// RVA: 0x12A1EF0
	public override int ReadByte() { }

	// RVA: 0x12A200C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12A2430
	public override void Write(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x12A276C
	public override void WriteByte(Byte value) { }

	// RVA: 0x12A2878
	public void Close(int timeout) { }

	// RVA: 0x12A28E8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12A2B5C
	protected override void Finalize() { }

	// RVA: 0x12A2BFC
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x12A3050
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x12A3374
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x12A37C8
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x12A3AEC
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12A42AC
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x12A4544
	public override Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12A4D78
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x12A500C
	public override void Flush() { }

	// RVA: 0x12A5010
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12A1358
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x12A5230
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

	// RVA: 0x12AF620
	public void .ctor() { }

}

// Namespace: 
private class TaskSocketAsyncEventArgs<T0>
{
	// Fields
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: 0x35263A0
	internal void .ctor() { }

	// RVA: 0x26AD93C
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(bool responsibleForReturningToPool) { }

}

// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0x99

	// Methods

	// RVA: 0x12AF5CC
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

	// RVA: 0x12B074C
	private static void .cctor() { }

	// RVA: 0x12B07B8
	public void .ctor() { }

	// RVA: 0x12B07C0
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x12B0948
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x12B0A80
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x12B0AD4
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

	// RVA: 0x12AF628
	public void .ctor() { }

	// RVA: 0x12AF758
	public bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x12AF760
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x12A52D4
	public bool Reserve() { }

	// RVA: 0x12AF768
	private void Release() { }

	// RVA: 0x12AF7EC
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x12A5464
	public System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(Socket socket) { }

	// RVA: 0x12A5A08
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x12AFE48
	public ValueTaskSourceStatus GetStatus(Int16 token) { }

	// RVA: 0x12AFF9C
	public void OnCompleted(System.Action<System.Object> continuation, object state, Int16 token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x12AFA2C
	private void InvokeContinuation(System.Action<System.Object> continuation, object state, bool forceAsync) { }

	// RVA: 0x12B030C
	public int GetResult(Int16 token) { }

	// RVA: 0x12B0454
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16 token) { }

	// RVA: 0x12AFF48
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x12B02B8
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x12B0428
	private void ThrowException(SocketError error) { }

	// RVA: 0x12AFD60
	private Exception CreateException(SocketError error) { }

	// RVA: 0x12B0560
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

	// RVA: 0x12B0B28
	private static void .cctor() { }

	// RVA: 0x12B0B94
	public void .ctor() { }

	// RVA: 0x12B0B9C
	internal CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x12B0BF4
	internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x12B0CC8
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x12B0F90
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x12B1578
	internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x12B15D0
	internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x12B16A4
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x12B196C
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x12B1DA8
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x12B1E50
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x12B1EF8
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12B1FFC
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12B20E8
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12B21D4
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x12B24A0
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x12B2624
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x12B28EC
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x12B2BAC
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x12B3090
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x12B3350
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x12B3474
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x12B3790
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x12B3A60
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x12B3BF4
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x12B3EE4
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x12B40A0
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x12B43BC
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x12B4550
	internal void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass240_0
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x12AB9C0
	public void .ctor() { }

	// RVA: 0x12B4820
	internal void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x12AE1F4
	public void .ctor() { }

	// RVA: 0x12B498C
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

	// RVA: 0x12AEA1C
	public void .ctor() { }

	// RVA: 0x12B4A40
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

	// RVA: 0x12A3EE4
	internal System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x12A551C
	private System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x12A4958
	internal ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x12A5A90
	private System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x12A5FCC
	private static void CompleteAccept(Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x12A631C
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x12A6238
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x12A64D0
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x12A61D0
	private void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x12A652C
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x12A6DCC
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x12A6E34
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x12A6E9C
	public IntPtr get_Handle() { }

	// RVA: 0x12A6EBC
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x12A6EC4
	public SocketType get_SocketType() { }

	// RVA: 0x12A6ECC
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x12A6ED4
	public void set_DontFragment(bool value) { }

	// RVA: 0x12A7078
	public bool get_DualMode() { }

	// RVA: 0x12A7134
	public void set_DualMode(bool value) { }

	// RVA: 0x12A71B4
	private bool get_IsDualMode() { }

	// RVA: 0x12A71CC
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x12A7204
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x12A23C8
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x12A7A78
	public int SendTo(Byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x12A1B14
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x12A7E0C
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x12A848C
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x12A6BDC
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x12A3750
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x12A3A84
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x12A2FD8
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x12A330C
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x12A8DD0
	private static object get_InternalSyncObject() { }

	// RVA: 0x12A8ED4
	internal bool get_CleanedUp() { }

	// RVA: 0x12A67C0
	internal static void InitializeSockets() { }

	// RVA: 0x12A8F64
	public void Dispose() { }

	// RVA: 0x12A8FF4
	protected override void Finalize() { }

	// RVA: 0x12A2A34
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x12A50D4
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x12A9350
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x12A6CE4
	private void SocketDefaults() { }

	// RVA: 0x12A6AB4
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, int error) { }

	// RVA: 0x12A94E4
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x12A966C
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x12A97C4
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x12A97C8
	public bool get_Blocking() { }

	// RVA: 0x12A97D0
	public void set_Blocking(bool value) { }

	// RVA: 0x12A989C
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, int error) { }

	// RVA: 0x12A99E4
	internal static void Blocking_icall(IntPtr socket, bool block, int error) { }

	// RVA: 0x12A99E8
	public bool get_Connected() { }

	// RVA: 0x12A9470
	public void set_NoDelay(bool value) { }

	// RVA: 0x12A9A48
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x12A9B50
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x12A9CA8
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x12A9CAC
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x12A9E50
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, int error) { }

	// RVA: 0x12A9FB8
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, int error) { }

	// RVA: 0x12A9FBC
	public Socket Accept() { }

	// RVA: 0x12AA25C
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x12AA394
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x12AA6F4
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x12AA720
	public Socket EndAccept(Byte[] buffer, int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x12AA0FC
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, int error, bool blocking) { }

	// RVA: 0x12AAB74
	private static IntPtr Accept_icall(IntPtr sock, int error, bool blocking) { }

	// RVA: 0x12AAB78
	public void Bind(EndPoint localEP) { }

	// RVA: 0x12AADD4
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error) { }

	// RVA: 0x12AAF1C
	private static void Bind_icall(IntPtr sock, SocketAddress sa, int error) { }

	// RVA: 0x12AAF20
	public void Listen(int backlog) { }

	// RVA: 0x12AB010
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, int error) { }

	// RVA: 0x12AB158
	private static void Listen_icall(IntPtr sock, int backlog, int error) { }

	// RVA: 0x12AB15C
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x12AB1DC
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x12AB684
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x12AB9C8
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x12AC01C
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x12ABB2C
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x12AC288
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x12AB554
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x12AC354
	private static void Connect_icall(IntPtr sock, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x12AC358
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x12AC5A4
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x12AC45C
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, int error) { }

	// RVA: 0x12AC670
	private static void Disconnect_icall(IntPtr sock, bool reuse, int error) { }

	// RVA: 0x12A7CB0
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12AC950
	private int Receive(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12A7E74
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12A1DDC
	public int Receive(System.Span<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12A26D4
	public int Send(System.ReadOnlySpan<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12ACCB8
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x12A8A48
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x12A8C48
	public int EndReceive(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x12ACB60
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AD014
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AC7F8
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AD018
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AD01C
	private int ReceiveFrom(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, SocketError errorCode) { }

	// RVA: 0x12AD428
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x12AD684
	public int EndReceiveFrom(IAsyncResult asyncResult, EndPoint endPoint) { }

	// RVA: 0x12AD79C
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x12AD2C8
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x12AD870
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x12A78F0
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12A726C
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12ADB24
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x12A8620
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x12ADE48
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x12A88C0
	public int EndSend(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x12AD9CC
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AE22C
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AD874
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12AE230
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12A7AAC
	public int SendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x12AE394
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x12AE234
	private static int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x12AE450
	private static int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x12A110C
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x12AE454
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x12AE5B4
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x12A6F54
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x12A91D8
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x12AE5B8
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x12A8490
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x12AE5BC
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x12AE72C
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x12AE730
	public void Close() { }

	// RVA: 0x12A2AC8
	public void Close(int timeout) { }

	// RVA: 0x12AE7C4
	internal static void Close_icall(IntPtr socket, int error) { }

	// RVA: 0x12A9090
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, int error) { }

	// RVA: 0x12AE7C8
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, int error) { }

	// RVA: 0x12AE7CC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12AE83C
	private void Linger(IntPtr handle) { }

	// RVA: 0x12A95E4
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x12AC674
	private void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x12AC6D0
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12A99F0
	private void ThrowIfUdp() { }

	// RVA: 0x12AA824
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x12AA594
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x12ACEFC
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x12AEB60
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x12AAD14
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x12AECF8
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x12AECFC
	internal static int get_FamilyHint() { }

	// RVA: 0x12AEE44
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x12A8EE4
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x12AEE48
	private static void .cctor() { }

}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Methods

	// RVA: 0x12B4A88
	private static int WSAGetLastError_icall() { }

	// RVA: 0x12A6BB0
	public void .ctor() { }

	// RVA: 0x12B4A8C
	internal void .ctor(int error, string message) { }

	// RVA: 0x12A1EE8
	public void .ctor(int errorCode) { }

	// RVA: 0x12A78E8
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x12B4A94
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12B4A9C
	public override string get_Message() { }

	// RVA: 0x12B2498
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

	// RVA: 0x12AE9E0
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x12B4B3C
	public void set_Enabled(bool value) { }

	// RVA: 0x12B4B44
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

	// RVA: 0x12B4B4C
	public void .ctor() { }

	// RVA: 0x12B4B70
	public void .ctor(AddressFamily family) { }

	// RVA: 0x12B4D5C
	public Socket get_Client() { }

	// RVA: 0x12B4D64
	public void set_Client(Socket value) { }

	// RVA: 0x12B4D6C
	public void Connect(string hostname, int port) { }

	// RVA: 0x12B55EC
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x12B56EC
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x12B5760
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x12B57A8
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x12B5944
	public NetworkStream GetStream() { }

	// RVA: 0x12B5AA8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12B5D44
	public void Dispose() { }

	// RVA: 0x12B5D54
	protected override void Finalize() { }

	// RVA: 0x12B4CDC
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

	// RVA: 0x12A6AB8
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x12B5DF0
	protected override bool ReleaseHandle() { }

	// RVA: 0x12AAA2C
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x12B6500
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x12B671C
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

	// RVA: 0x12B67B0
	public Socket get_AcceptSocket() { }

	// RVA: 0x12B67B8
	public void set_AcceptSocket(Socket value) { }

	// RVA: 0x12B67C0
	public int get_BytesTransferred() { }

	// RVA: 0x12B67C8
	private void set_BytesTransferred(int value) { }

	// RVA: 0x12B67D0
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x12B67D8
	public void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x12B67E0
	public SocketError get_SocketError() { }

	// RVA: 0x12B67E8
	public void set_SocketError(SocketError value) { }

	// RVA: 0x12B67F0
	public void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x12B67F8
	public object get_UserToken() { }

	// RVA: 0x12B6800
	public void set_UserToken(object value) { }

	// RVA: 0x12AF6A4
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x12B6810
	protected override void Finalize() { }

	// RVA: 0x12B6820
	private void Dispose(bool disposing) { }

	// RVA: 0x12B6834
	public void Dispose() { }

	// RVA: 0x12AECF0
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x12B68D4
	internal Socket get_CurrentSocket() { }

	// RVA: 0x12B68DC
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x12AEC10
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x12B68E4
	internal void Complete_internal() { }

	// RVA: 0x12B6918
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x12B6940
	public System.Memory<System.Byte> get_MemoryBuffer() { }

	// RVA: 0x12B694C
	public int get_Offset() { }

	// RVA: 0x12B6954
	public int get_Count() { }

	// RVA: 0x12B695C
	public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }

	// RVA: 0x12A5360
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

	// RVA: 0x12B6968
	private static void .cctor() { }

	// RVA: 0x12B69D4
	public void .ctor() { }

	// RVA: 0x12B69DC
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

	// RVA: 0x12AA560
	public IntPtr get_Handle() { }

	// RVA: 0x12B6808
	public void .ctor() { }

	// RVA: 0x12AEA24
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x12AA510
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x12ACF84
	public SocketError get_ErrorCode() { }

	// RVA: 0x12AA988
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x12B6964
	internal override void CompleteDisposed() { }

	// RVA: 0x12B2E8C
	public void Complete() { }

	// RVA: 0x12AC280
	public void Complete(bool synch) { }

	// RVA: 0x12AE224
	public void Complete(int total) { }

	// RVA: 0x12AC250
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x12AE1FC
	public void Complete(Exception e) { }

	// RVA: 0x12B25FC
	public void Complete(Socket s) { }

	// RVA: 0x12B28BC
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

	// RVA: 0x12B6A58
	public bool get_AllowRenegotiation() { }

	// RVA: 0x12B6A60
	public string get_TargetHost() { }

	// RVA: 0x12B6A68
	public void set_TargetHost(string value) { }

	// RVA: 0x12B6A70
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x12B6A78
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x12B6A80
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x12B6B20
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x12B6BC0
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x12B6BC8
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x12B6BD0
	public void .ctor() { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Methods

	// RVA: 0x12B6BE0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x12B6DA4
	protected Stream get_InnerStream() { }

	// RVA: 0x12B6DAC
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

	// RVA: 0x12B6EC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B6FEC
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0x12B7000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B7124
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

	// RVA: 0x12B7138
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B71F4
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback
{
	// Methods

	// RVA: 0x12B7208
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12B72BC
	public virtual X509Certificate Invoke(string hostName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x12B79D4
	public void .ctor() { }

	// RVA: 0x12B846C
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

	// RVA: 0x12B72D0
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x12B73A0
	internal string get_InternalTargetHost() { }

	// RVA: 0x12B740C
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x12B7488
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x12B7490
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x12B7880
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x12B75B4
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x12B76B4
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x12B79DC
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x12B7A48
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x12B7ACC
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x12B7AD8
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x12B7B44
	public override bool get_IsAuthenticated() { }

	// RVA: 0x12B7BB8
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x12B7C24
	public override bool get_CanSeek() { }

	// RVA: 0x12B7C2C
	public override bool get_CanRead() { }

	// RVA: 0x12B7C44
	public override bool get_CanTimeout() { }

	// RVA: 0x12B7C68
	public override bool get_CanWrite() { }

	// RVA: 0x12B7C80
	public override int get_ReadTimeout() { }

	// RVA: 0x12B7CF4
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x12B7D68
	public override int get_WriteTimeout() { }

	// RVA: 0x12B7DDC
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x12B7E50
	public override Int64 get_Length() { }

	// RVA: 0x12B7EC0
	public override Int64 get_Position() { }

	// RVA: 0x12B7F30
	public override void set_Position(Int64 value) { }

	// RVA: 0x12B7F8C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x12B7FE8
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12B8010
	public override void Flush() { }

	// RVA: 0x12B7338
	private void CheckDisposed() { }

	// RVA: 0x12B8038
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12B8120
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12B8194
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12B8208
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x12B827C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x12B82F0
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x12B8374
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x12B83DC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x12B8460
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

	// RVA: 0x12B84A8
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

	// RVA: 0x12B8534
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection
{
	// Methods

	// RVA: 0x12B8570
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection
{
	// Methods

	// RVA: 0x12B85AC
	public void .ctor() { }

	// RVA: 0x12B85E8
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection
{
	// Methods

	// RVA: 0x12B8624
	public void .ctor() { }

	// RVA: 0x12B8660
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x12B869C
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement
{
	// Methods

	// RVA: 0x12B86D8
	public void .ctor() { }

	// RVA: 0x12B8714
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement
{
	// Methods

	// RVA: 0x12B8750
	public void .ctor() { }

	// RVA: 0x12B878C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element
{
	// Methods

	// RVA: 0x12B87C8
	public void .ctor() { }

	// RVA: 0x12B8804
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup
{
	// Methods

	// RVA: 0x12B8840
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection
{
	// Methods

	// RVA: 0x12B887C
	public void .ctor() { }

	// RVA: 0x12B88B8
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement
{
	// Methods

	// RVA: 0x12B88F4
	public void .ctor() { }

	// RVA: 0x12B8930
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement
{
	// Methods

	// RVA: 0x12B896C
	public void .ctor() { }

	// RVA: 0x12B89A8
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement
{
	// Methods

	// RVA: 0x12B89E4
	public void .ctor() { }

	// RVA: 0x12B8A20
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement
{
	// Methods

	// RVA: 0x12B8A5C
	public void .ctor() { }

	// RVA: 0x12B8A98
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection
{
	// Methods

	// RVA: 0x12B8AD4
	public void .ctor() { }

	// RVA: 0x12B8B10
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection
{
	// Methods

	// RVA: 0x12B8B4C
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler
{
	// Methods

	// RVA: 0x12B8B88
	public void .ctor() { }

	// RVA: 0x12B8BC4
	public virtual object Create(object parent, object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x12B8C00
	public static void ThrowNotSupportedException() { }

}


