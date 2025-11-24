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

	// RVA: 0xEE7C10
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0xEE7FBC
	private static void EnsureInitialized() { }

	// RVA: 0xEE8144
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xEE81A4
	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags) { }

	// RVA: 0xEE84B8
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xEE84BC
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xEE872C
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xEE8730
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xEE8914
	public void .ctor() { }

	// RVA: 0xEE891C
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

	// RVA: 0xEE899C
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0xEE89FC
	internal static void Initialize() { }

	// RVA: 0xEE8C24
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	// RVA: 0xEE8C2C
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0xEE8C34
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xEE8B64
	private void .ctor() { }

	// RVA: 0xEE8CA0
	private static void .cctor() { }

}

// Namespace: Mono
internal static class X509Pal
{
	// Methods

	// RVA: 0xEE8D20
	public static X509PalImpl get_Instance() { }

}

// Namespace: Mono
internal class X509PalImplMono
{
	// Methods

	// RVA: 0xEE8E44
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0xEE8E48
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xEE8EC8
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xEE7F34
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

	// RVA: 0xEE8ED8
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xEE901C
	protected static Byte[] ConvertData(Byte[] data) { }

	// RVA: 0xEE8304
	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	// RVA: 0xEE86AC
	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xEE913C
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0xEE9144
	public X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0xEE8ED0
	protected void .ctor() { }

	// RVA: 0xEE959C
	private static void .cctor() { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xEE9640
	public void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper
{
	// Methods

	// RVA: 0xEE9648
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xEE9804
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug
{
	// Methods

	// RVA: 0xEE9AB0
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert) { }

	// RVA: 0xEE9B50
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

	// RVA: 0xEE9CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE9D5C
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

	// RVA: 0xEE9D70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE9E2C
	public virtual IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback
{
	// Methods

	// RVA: 0xEE9E40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE9EFC
	public virtual IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback
{
	// Methods

	// RVA: 0xEE9F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE9FCC
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback
{
	// Methods

	// RVA: 0xEE9FE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA09C
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback
{
	// Methods

	// RVA: 0xEEA0BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA178
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

	// RVA: 0xEEA194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA234
	public virtual unitytls_errorstate Invoke() { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t
{
	// Methods

	// RVA: 0xEEA248
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA304
	public virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t
{
	// Methods

	// RVA: 0xEEA318
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA3D4
	public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t
{
	// Methods

	// RVA: 0xEEA3E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA4A4
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t
{
	// Methods

	// RVA: 0xEEA4B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA574
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_free_t
{
	// Methods

	// RVA: 0xEEA588
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA63C
	public virtual void Invoke(unitytls_key* key) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t
{
	// Methods

	// RVA: 0xEEA650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA6F4
	public virtual IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t
{
	// Methods

	// RVA: 0xEEA708
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA7C4
	public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t
{
	// Methods

	// RVA: 0xEEA7D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA87C
	public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t
{
	// Methods

	// RVA: 0xEEA890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEA944
	public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t
{
	// Methods

	// RVA: 0xEEA958
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAA14
	public virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t
{
	// Methods

	// RVA: 0xEEAA28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAAE4
	public virtual void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t
{
	// Methods

	// RVA: 0xEEAAF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEABAC
	public virtual void Invoke(unitytls_x509list* list) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t
{
	// Methods

	// RVA: 0xEEABC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAC64
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t
{
	// Methods

	// RVA: 0xEEAC78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAD1C
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t
{
	// Methods

	// RVA: 0xEEAD34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEADD8
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t
{
	// Methods

	// RVA: 0xEEAE18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAEBC
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t
{
	// Methods

	// RVA: 0xEEAEFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEAFB8
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t
{
	// Methods

	// RVA: 0xEEAFCC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB088
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t
{
	// Methods

	// RVA: 0xEEB09C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB158
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t
{
	// Methods

	// RVA: 0xEEB16C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB228
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t
{
	// Methods

	// RVA: 0xEEB23C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB2F8
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t
{
	// Methods

	// RVA: 0xEEB30C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB3C8
	public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t
{
	// Methods

	// RVA: 0xEEB3DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB498
	public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t
{
	// Methods

	// RVA: 0xEEB4AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB568
	public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t
{
	// Methods

	// RVA: 0xEEB57C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB638
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t
{
	// Methods

	// RVA: 0xEEB64C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB708
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t
{
	// Methods

	// RVA: 0xEEB71C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB7D8
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t
{
	// Methods

	// RVA: 0xEEB7EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB8A0
	public virtual void Invoke(unitytls_tlsctx* ctx) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t
{
	// Methods

	// RVA: 0xEEB8B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEEB970
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

	// RVA: 0xEEA18C
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal static class UnityTls
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Methods

	// RVA: 0xEE9C80
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0xEE9C84
	public static bool get_IsSupported() { }

	// RVA: 0xEE99B8
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

	// RVA: 0xEEBCB4
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEEC7E8
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, unitytls_x509list* nativeCertChain, unitytls_key* nativeKey) { }

	// RVA: 0xEECB60
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEECB68
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xEECB70
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0xEECB78
	public override void Flush() { }

	// RVA: 0xEECB7C
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEECD64
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEECF2C
	public override void Renegotiate() { }

	// RVA: 0xEECF6C
	public override bool PendingRenegotiation() { }

	// RVA: 0xEECF74
	public override void Shutdown() { }

	// RVA: 0xEED098
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEED1A0
	public override void StartHandshake() { }

	// RVA: 0xEED380
	public override bool ProcessHandshake() { }

	// RVA: 0xEED57C
	public override void FinishHandshake() { }

	// RVA: 0xEEB984
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEED6D4
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEEBA58
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEEDB44
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEEBB2C
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xEEDFB4
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xEEBBE8
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xEEE4A0
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions
{
	// Methods

	// RVA: 0xEEC784
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xEEC7B4
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xEED6B4
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xEE9C28
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xEEED40
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

	// RVA: 0xEEED70
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider
{
	// Methods

	// RVA: 0xEEEE10
	public override string get_Name() { }

	// RVA: 0xEEEE54
	public override Guid get_ID() { }

	// RVA: 0xEEEED0
	public override bool get_SupportsSslStream() { }

	// RVA: 0xEEEED8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xEEEEE0
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xEEEEE8
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xEEEEF0
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xEEEEF8
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xEEEDA8
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xEEF060
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEEFCB0
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream
{
	// Methods

	// RVA: 0xEEEFC8
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEEFEC0
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

	// RVA: 0xEEE3FC
	internal void .ctor(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder) { }

	// RVA: 0xEEFBD4
	internal void .ctor(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder) { }

	// RVA: 0xEEFF2C
	public override bool get_IsValid() { }

	// RVA: 0xEEFF60
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0xEEFF68
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0xEF0278
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0xEF037C
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xEF0384
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0xEF038C
	public override void Reset() { }

	// RVA: 0xEF0418
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

	// RVA: 0xEF0450
	public int get_EndOffset() { }

	// RVA: 0xEF045C
	public int get_Remaining() { }

	// RVA: 0xEF0488
	public void .ctor(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF05A4
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0xEF064C
	public void .ctor(int size) { }

	// RVA: 0xEF06C0
	public void Reset() { }

	// RVA: 0xEF0734
	public void MakeRoom(int size) { }

	// RVA: 0xEF080C
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

	// RVA: 0xEF0870
	public int get_UserResult() { }

	// RVA: 0xEF0878
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0xEF0880
	public void .ctor(int result) { }

	// RVA: 0xEF08AC
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

	// RVA: 0xEF0E98
	private void MoveNext() { }

	// RVA: 0xEF12C4
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

	// RVA: 0xEF1344
	private void MoveNext() { }

	// RVA: 0xEF1F64
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

	// RVA: 0xEF1FD0
	private void MoveNext() { }

	// RVA: 0xEF26FC
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

	// RVA: 0xEF08E0
	public MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xEF08E8
	public bool get_RunSynchronously() { }

	// RVA: 0xEF08F0
	public string get_Name() { }

	// RVA: 0xEF0918
	public int get_UserResult() { }

	// RVA: 0xEF0920
	protected void set_UserResult(int value) { }

	// RVA: 0xEF0928
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEF09C8
	internal void RequestRead(int size) { }

	// RVA: 0xEF0AA0
	internal void RequestWrite() { }

	// RVA: 0xEF0AAC
	internal System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEF0BE0
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEF0CF0
	private System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xEF0E28
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest
{
	// Methods

	// RVA: 0xEF277C
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEF281C
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private int <CurrentSize>k__BackingField; // 0x40

	// Methods

	// RVA: 0xEF2C28
	protected BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xEF2C30
	protected int get_CurrentSize() { }

	// RVA: 0xEF2C38
	protected void set_CurrentSize(int value) { }

	// RVA: 0xEF2C40
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF2D4C
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest
{
	// Methods

	// RVA: 0xEF2DC0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF2DC4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest
{
	// Methods

	// RVA: 0xEF2FAC
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF2FB0
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0xEF3A6C
	public void .ctor() { }

	// RVA: 0xEF446C
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

	// RVA: 0xEF31BC
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xEF36AC
	internal static ChainValidationHelper Create(MobileTlsProvider provider, MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xEF32A8
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0xEF3870
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0xEF3A74
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xEF3AC0
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xEF3AC8
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, X509Certificate clientCertificate) { }

	// RVA: 0xEF3B20
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xEF3CF8
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEF3DE4
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEF438C
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

	// RVA: 0xEF5FE4
	private void MoveNext() { }

	// RVA: 0xEF6A94
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

	// RVA: 0xEF6B00
	private void MoveNext() { }

	// RVA: 0xEF73AC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0xEF742C
	public void .ctor() { }

	// RVA: 0xEF7434
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

	// RVA: 0xEF7480
	private void MoveNext() { }

	// RVA: 0xEF797C
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

	// RVA: 0xEF79FC
	private void MoveNext() { }

	// RVA: 0xEF7D38
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

	// RVA: 0xEEFCC0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEF45D0
	public SslStream get_SslStream() { }

	// RVA: 0xEF45D8
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xEF45E0
	public MobileTlsProvider get_Provider() { }

	// RVA: 0xEF45E8
	internal string get_TargetHost() { }

	// RVA: 0xEF45F0
	private void set_TargetHost(string value) { }

	// RVA: 0xEF45F8
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck) { }

	// RVA: 0xEF1C98
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0xEF46C4
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0xEF485C
	internal static Exception GetInternalError() { }

	// RVA: 0xEF48B0
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0xEF1280
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xEF4904
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEF4DD0
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEF4CA0
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	// RVA: 0xEF4F4C
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEF51AC
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEF5284
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEF5324
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEF504C
	private System.Threading.Tasks.Task<System.Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xEEDE98
	internal int InternalRead(Byte[] buffer, int offset, int size, bool outWantMore) { }

	// RVA: 0xEF53C4
	private System.ValueTuple<System.Int32,System.Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEED964
	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF5544
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEF25AC
	internal System.Threading.Tasks.Task<System.Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xEF1E48
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0xEF283C
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0xEF2E40
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xEF304C
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xEF56FC
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEF5800
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEF5ACC
	public override void Flush() { }

	// RVA: 0xEF5AF4
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0xEF5BDC
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xEF5D08
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xEF5D48
	public override bool get_CanRead() { }

	// RVA: 0xEF5D98
	public override bool get_CanTimeout() { }

	// RVA: 0xEF5DBC
	public override bool get_CanWrite() { }

	// RVA: 0xEF5E2C
	public override bool get_CanSeek() { }

	// RVA: 0xEF5E34
	public override Int64 get_Length() { }

	// RVA: 0xEF5E58
	public override Int64 get_Position() { }

	// RVA: 0xEF5E7C
	public override void set_Position(Int64 value) { }

	// RVA: 0xEF5EBC
	public override int get_ReadTimeout() { }

	// RVA: 0xEF5EE4
	public override void set_ReadTimeout(int value) { }

	// RVA: 0xEF5F0C
	public override int get_WriteTimeout() { }

	// RVA: 0xEF5F34
	public override void set_WriteTimeout(int value) { }

	// RVA: 0xEF5F5C
	private static void .cctor() { }

	// RVA: 0xEF5FAC
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

	// RVA: 0xEEC5D8
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEF7DA4
	internal MonoSslAuthenticationOptions get_Options() { }

	// RVA: 0xEF7DAC
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xEED078
	public MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0xEF7DB4
	public bool get_IsServer() { }

	// RVA: 0xEF7DBC
	internal string get_TargetHost() { }

	// RVA: 0xEF7DC4
	protected string get_ServerName() { }

	// RVA: 0xEF7DCC
	protected bool get_AskForClientCertificate() { }

	// RVA: 0xEF7DD4
	protected SslProtocols get_EnabledProtocols() { }

	// RVA: 0xEF7DDC
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEF7DE4
	protected void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }

	// RVA: -1
	public abstract void StartHandshake() { }

	// RVA: -1
	public abstract bool ProcessHandshake() { }

	// RVA: -1
	public abstract void FinishHandshake() { }

	// RVA: 0xEF7F28
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: 0xEF7F30
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

	// RVA: 0xEED524
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0xEF7F38
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0xEEE7D0
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1
	public abstract void Renegotiate() { }

	// RVA: 0xEF5A38
	public void Dispose() { }

	// RVA: 0xEF81D8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xEF81DC
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

	// RVA: 0xEEFCB8
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

	// RVA: 0xEF827C
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0xEF8284
	protected void .ctor() { }

}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions
{
	// Fields
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0xEF828C
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0xEF8294
	public override bool get_ServerMode() { }

	// RVA: 0xEF4C28
	public void .ctor() { }

	// RVA: 0xEF829C
	public override bool get_AllowRenegotiation() { }

	// RVA: 0xEF82BC
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0xEF82DC
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0xEF82FC
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0xEF831C
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0xEF833C
	public override string get_TargetHost() { }

	// RVA: 0xEF835C
	public override void set_TargetHost(string value) { }

	// RVA: 0xEF837C
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0xEF83BC
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEF83DC
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0xEF83FC
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

	// RVA: 0xEF374C
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0xEF843C
	internal static void InitializeInternal() { }

	// RVA: 0xEF8C6C
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0xEF8834
	private static void InitializeProviderRegistration() { }

	// RVA: 0xEF9310
	private static void PopulateUnityProviders() { }

	// RVA: 0xEF9460
	private static void PopulateProviders() { }

	// RVA: 0xEF96B4
	internal static bool IsBtlsSupported() { }

	// RVA: 0xEF8A54
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xEF9790
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0xEF97F8
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

	// RVA: 0xEF9E54
	private void MoveNext() { }

	// RVA: 0xEFA66C
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

	// RVA: 0xEF993C
	internal HttpWebRequest get_Request() { }

	// RVA: 0xEF9944
	internal WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xEF994C
	internal bool get_CertificateValidationFailed() { }

	// RVA: 0xEF9954
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0xEF995C
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xEF9C14
	internal System.Threading.Tasks.Task<System.IO.Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0xEF9D6C
	public void Dispose() { }

	// RVA: 0xEF9D70
	private void CloseSslStream() { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper
{
	// Methods

	// RVA: 0xEFA6EC
	internal static object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xEFA79C
	private static void .cctor() { }

	// RVA: 0xEF4464
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xEFA7F0
	public void .ctor() { }

	// RVA: 0xEFA800
	internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xEFA7F8
	public void .ctor() { }

	// RVA: 0xEFA828
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers
{
	// Methods

	// RVA: 0xEF9B30
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	// RVA: 0xEF3988
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: Mono.Http
internal class NtlmSession
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xEFA850
	public void .ctor() { }

	// RVA: 0xEFA858
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

	// RVA: 0xEFB18C
	private static void .cctor() { }

	// RVA: 0xEFB1F8
	public void .ctor() { }

	// RVA: 0xEFB200
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Mono.Http
internal class NtlmClient
{
	// Fields
	private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache; // 0x0

	// Methods

	// RVA: 0xEFAD14
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEFB09C
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEFB0A4
	public string get_AuthenticationType() { }

	// RVA: 0xEFB0E8
	public void .ctor() { }

	// RVA: 0xEFB0F0
	private static void .cctor() { }

}

// Namespace: 
protected internal class BoringBioHandle
{
	// Methods

	// RVA: 0xEFB400
	public void .ctor(IntPtr handle) { }

	// RVA: 0xEFB414
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBio
{
	// Methods

	// RVA: 0xEFB258
	internal void .ctor(BoringBioHandle handle) { }

	// RVA: 0xEFB2C0
	protected internal BoringBioHandle get_Handle() { }

	// RVA: 0xEFB368
	private static extern void mono_btls_bio_free(IntPtr handle) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory
{
	// Methods

	// RVA: 0xEFB4BC
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0xEFB540
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, IntPtr data) { }

	// RVA: 0xEFB5D0
	public void .ctor() { }

	// RVA: 0xEFB6B0
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

	// RVA: 0xEFC50C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEFCC98
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength, int wantMore) { }

}

// Namespace: 
private sealed class BioWriteFunc
{
	// Methods

	// RVA: 0xEFC5B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEFCCAC
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

}

// Namespace: 
private sealed class BioControlFunc
{
	// Methods

	// RVA: 0xEFC654
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEFCCC0
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

	// RVA: 0xEFBFEC
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0xEFC488
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0xEFC6F8
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0xEFC7A8
	private Int64 Control(ControlCommand command, Int64 arg) { }

	// RVA: 0xEFC8A0
	private int OnRead(IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xEFBB64
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xEFCA3C
	private int OnWrite(IntPtr data, int dataLength) { }

	// RVA: 0xEFBCF8
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	// RVA: 0xEFBE74
	private static Int64 Control(IntPtr instance, ControlCommand command, Int64 arg) { }

	// RVA: 0xEFCB74
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

	// RVA: 0xEFCCD4
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEFCD20
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0xEFCF64
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0xEFD270
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0xEFD794
	private int ServerNameCallback() { }

	// RVA: 0xEFD7FC
	public override void StartHandshake() { }

	// RVA: 0xEFD4A4
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0xEFDDA4
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0xEFE62C
	public override bool ProcessHandshake() { }

	// RVA: 0xEFE838
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0xEFEA6C
	public override void FinishHandshake() { }

	// RVA: 0xEFD938
	private void InitializeConnection() { }

	// RVA: 0xEFD348
	private void GetPeerCertificate() { }

	// RVA: 0xEFEA94
	private void InitializeSession() { }

	// RVA: 0xEFF3A4
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0xEFF40C
	public override void Flush() { }

	// RVA: 0xEFF44C
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEFF748
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEFF9FC
	public override void Renegotiate() { }

	// RVA: 0xEFFA3C
	public override void Shutdown() { }

	// RVA: 0xEFFA90
	public override bool PendingRenegotiation() { }

	// RVA: 0x30D4CD4
	private void Dispose(T disposable) { }

	// RVA: 0xEFFAB0
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEFFC3C
	private int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, bool wantMore) { }

	// RVA: 0xEFFC58
	private bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEFFC74
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0xEFFC78
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xEFFC7C
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEFFC84
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xEFFC8C
	public override X509Certificate2 get_RemoteCertificate() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsError
{
	// Methods

	// RVA: 0xEFFC94
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0xEFFD18
	private static extern int mono_btls_error_get_error_line(IntPtr file, int line) { }

	// RVA: 0xEFFDA8
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0xEFFE40
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0xEFE7B4
	public static void ClearError() { }

	// RVA: 0xEFE3E0
	public static string GetErrorString(int error) { }

	// RVA: 0xEFE188
	public static int GetError(string file, int line) { }

	// RVA: 0xEFE348
	public static int GetErrorReason(int error) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsException
{
	// Methods

	// RVA: 0xEFFED8
	public void .ctor() { }

	// RVA: 0xEFE294
	public void .ctor(MonoBtlsSslError error) { }

	// RVA: 0xEFE5C0
	public void .ctor(string message) { }

	// RVA: 0xEFFF60
	public void .ctor(string format, object[] args) { }

}

// Namespace: 
internal class BoringKeyHandle
{
	// Methods

	// RVA: 0xF0094C
	internal void .ctor(IntPtr handle) { }

	// RVA: 0xF00B8C
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsKey
{
	// Methods

	// RVA: 0xEFFFEC
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0xF00070
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0xF00108
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0xF001A0
	private static extern int mono_btls_key_get_bytes(IntPtr handle, IntPtr data, int size, int include_private_bits) { }

	// RVA: 0xF00248
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	// RVA: 0xF002E8
	internal BoringKeyHandle get_Handle() { }

	// RVA: 0xF0036C
	internal void .ctor(BoringKeyHandle handle) { }

	// RVA: 0xF003A0
	public Byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0xF006F4
	public MonoBtlsKey Copy() { }

	// RVA: 0xF00958
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

}

// Namespace: 
protected internal abstract class MonoBtlsHandle
{
	// Methods

	// RVA: 0xEFB40C
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0xF00FAC
	public override bool get_IsInvalid() { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject
{
	// Fields
	private MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Methods

	// RVA: 0xEFB28C
	internal void .ctor(MonoBtlsHandle handle) { }

	// RVA: 0xEFB344
	internal MonoBtlsHandle get_Handle() { }

	// RVA: 0xF00C10
	public bool get_IsValid() { }

	// RVA: 0xF008CC
	protected void CheckThrow() { }

	// RVA: 0xEFC9F8
	protected Exception SetException(Exception ex) { }

	// RVA: 0xEFB9E4
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0xF00650
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0xEFE88C
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0xF00C38
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0xF0065C
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0xF00CD0
	protected virtual void Close() { }

	// RVA: 0xF00CD4
	protected void Dispose(bool disposing) { }

	// RVA: 0xF00E60
	public void Dispose() { }

	// RVA: 0xF00F00
	protected override void Finalize() { }

}

// Namespace: 
internal class BoringPkcs12Handle
{
	// Methods

	// RVA: 0xF01584
	public void .ctor(IntPtr handle) { }

	// RVA: 0xF01CBC
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Methods

	// RVA: 0xF00FBC
	internal BoringPkcs12Handle get_Handle() { }

	// RVA: 0xF01040
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0xF010D8
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0xF0115C
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0xF011F4
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0xF01284
	private static extern int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	// RVA: 0xF01374
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0xF0140C
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0xF014A4
	internal void .ctor() { }

	// RVA: 0xF01590
	public int get_Count() { }

	// RVA: 0xF01698
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0xF01890
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0xF019A8
	public bool get_HasPrivateKey() { }

	// RVA: 0xF01AA0
	public MonoBtlsKey GetPrivateKey() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsProvider
{
	// Methods

	// RVA: 0xF01D40
	public override Guid get_ID() { }

	// RVA: 0xF01DBC
	public override string get_Name() { }

	// RVA: 0xEF96B8
	internal void .ctor() { }

	// RVA: 0xF01E00
	public override bool get_SupportsSslStream() { }

	// RVA: 0xF01E08
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xF01E10
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xF01E18
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xF01E20
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xF01E28
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xF01EC0
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0xF020E8
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0xF02068
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0xEFEF94
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0xF02200
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xF02DE4
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0xF02874
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, SslPolicyErrors errors, int status11) { }

	// RVA: 0xF030CC
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0xEFEC40
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xF03344
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0xF033D4
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0xF03430
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0xF03308
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEFF228
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0xF02D50
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0xF0348C
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0xF02960
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsVerifyCallback
{
	// Methods

	// RVA: 0x12864A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12865C4
	public virtual int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsSelectCallback
{
	// Methods

	// RVA: 0x12865D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x128668C
	public virtual int Invoke(string[] acceptableIssuers) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsServerNameCallback
{
	// Methods

	// RVA: 0x12866A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1286740
	public virtual int Invoke() { }

}

// Namespace: 
internal class BoringSslHandle
{
	// Methods

	// RVA: 0x1287844
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1289B6C
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class PrintErrorsCallbackFunc
{
	// Methods

	// RVA: 0x12879B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1289C00
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

	// RVA: 0x12868E4
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x128697C
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x1286A14
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1286AA4
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x1286B34
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1286BC4
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x1286C5C
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x1286CF4
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x1286D8C
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x1286E20
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x1286EB8
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x1286F48
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x1286FD8
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x1287070
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x1287104
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x1287194
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x128722C
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x12872C4
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x128735C
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x12873EC
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x128747C
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x1287514
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x12875A4
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x128763C
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1287850
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1287A5C
	internal BoringSslHandle get_Handle() { }

	// RVA: 0x1287AE0
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x1287C10
	private Exception ThrowError(string callerName) { }

	// RVA: 0x1287F98
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x12880E0
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12882F8
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x1288438
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x12885CC
	public MonoBtlsSslError Accept() { }

	// RVA: 0x12886D8
	public MonoBtlsSslError Connect() { }

	// RVA: 0x12887E4
	public MonoBtlsSslError Handshake() { }

	// RVA: 0x1286754
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x1287DF8
	public string GetErrors() { }

	// RVA: 0x12888F0
	public void PrintErrors() { }

	// RVA: 0x1288A70
	public MonoBtlsSslError Read(IntPtr data, int dataSize) { }

	// RVA: 0x1288BD4
	public MonoBtlsSslError Write(IntPtr data, int dataSize) { }

	// RVA: 0x1288DE0
	public int GetVersion() { }

	// RVA: 0x1288EF0
	public int GetCipher() { }

	// RVA: 0x1289064
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x1289230
	public void SetServerName(string name) { }

	// RVA: 0x1289478
	public string GetServerName() { }

	// RVA: 0x12895FC
	public void Shutdown() { }

	// RVA: 0x1289718
	public void SetQuietShutdown() { }

	// RVA: 0x1289814
	protected override void Close() { }

	// RVA: 0x128996C
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x1289A74
	public bool RenegotiatePending() { }

}

// Namespace: 
internal class BoringSslCtxHandle
{
	// Methods

	// RVA: 0x128AA8C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x128C864
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class NativeVerifyFunc
{
	// Methods

	// RVA: 0x128AEDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x128C8E8
	public virtual int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

}

// Namespace: 
private sealed class NativeSelectFunc
{
	// Methods

	// RVA: 0x128AF80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x128C8FC
	public virtual int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

}

// Namespace: 
private sealed class NativeServerNameFunc
{
	// Methods

	// RVA: 0x128B024
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x128C910
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

	// RVA: 0x12877C0
	internal BoringSslCtxHandle get_Handle() { }

	// RVA: 0x128A358
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x128A3DC
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x128A474
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x128A504
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x128A59C
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x128A62C
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x128A6BC
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x128A74C
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x128A7F4
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x128A884
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x128A92C
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x128A9BC
	public void .ctor() { }

	// RVA: 0x128AA98
	internal void .ctor(BoringSslCtxHandle handle) { }

	// RVA: 0x128B0F8
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x128B100
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	// RVA: 0x1289C14
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x128A020
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x128B1C4
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x128B8B0
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x128BA48
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x128BB64
	public void SetMinVersion(int version) { }

	// RVA: 0x128BC6C
	public void SetMaxVersion(int version) { }

	// RVA: 0x128BD74
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	// RVA: 0x128BFF0
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x128C25C
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x128C6E0
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	// RVA: 0x128A1E4
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x128C7FC
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

	// RVA: 0x128C924
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x128C9C0
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils
{
	// Fields
	private static Byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x128CA30
	public static bool Compare(Byte[] a, Byte[] b) { }

	// RVA: 0x128CAA4
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x128B768
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x128D7D0
	private static void .cctor() { }

}

// Namespace: 
internal class BoringX509Handle
{
	// Methods

	// RVA: 0x128921C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x128EB08
	protected override bool ReleaseHandle() { }

	// RVA: 0x128EBA0
	public IntPtr StealHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509
{
	// Methods

	// RVA: 0x1288274
	internal BoringX509Handle get_Handle() { }

	// RVA: 0x1289228
	internal void .ctor(BoringX509Handle handle) { }

	// RVA: 0x128D874
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x128D90C
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x128D9A4
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x128DA3C
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x128DAD4
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x128DB64
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x128DBF8
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x128DC88
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x128DE48
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x128E110
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x128E318
	public Int64 GetSubjectNameHash() { }

	// RVA: 0x128E570
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x128E82C
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x128E990
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

}

// Namespace: 
internal class BoringX509ChainHandle
{
	// Methods

	// RVA: 0x128F074
	public void .ctor(IntPtr handle) { }

	// RVA: 0x128F6BC
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain
{
	// Methods

	// RVA: 0x128EBB0
	internal BoringX509ChainHandle get_Handle() { }

	// RVA: 0x128EC34
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x128ECB8
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x128ED50
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x128EDE0
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x128EE70
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x128EF08
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x128EFA0
	public void .ctor() { }

	// RVA: 0x128F080
	internal void .ctor(BoringX509ChainHandle handle) { }

	// RVA: 0x128F088
	public int get_Count() { }

	// RVA: 0x128F190
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x128F390
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x128F4FC
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

	// RVA: 0x128FCC4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1290868
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

	// RVA: 0x128F740
	internal BoringX509LookupHandle get_Handle() { }

	// RVA: 0x128F7C4
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x128F854
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x128F8EC
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x128F97C
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x128FA14
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x128FAAC
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x128FCD0
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x128FD2C
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x128FE34
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x129007C
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x1290410
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x12905FC
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509LookupMonoHandle
{
	// Methods

	// RVA: 0x12910E0
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1291280
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class BySubjectFunc
{
	// Methods

	// RVA: 0x12910EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1291304
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

	// RVA: 0x1290334
	internal BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x1290C54
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x1290CD8
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x1290D70
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x1290E08
	internal void .ctor() { }

	// RVA: 0x12903B8
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x1291190
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12908EC
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, IntPtr x509_ptr) { }

	// RVA: 0x12911B4
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

	// RVA: 0x1291318
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x129135C
	private void Initialize() { }

	// RVA: 0x1291544
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12915FC
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

	// RVA: 0x128E2E0
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1291CA8
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name
{
	// Methods

	// RVA: 0x129174C
	private static extern Int64 mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x12917E4
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x129187C
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x129190C
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x12919B4
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, IntPtr data) { }

	// RVA: 0x1291A4C
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, int tag, IntPtr str) { }

	// RVA: 0x1291AF4
	private static extern IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	// RVA: 0x1291B8C
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x1291C24
	internal BoringX509NameHandle get_Handle() { }

	// RVA: 0x128E310
	internal void .ctor(BoringX509NameHandle handle) { }

	// RVA: 0x128E468
	public Int64 GetHash() { }

	// RVA: 0x128D6C8
	public int GetEntryCount() { }

	// RVA: 0x128CE68
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x128D42C
	public string GetEntryOid(int index) { }

	// RVA: 0x128CFA8
	public Byte[] GetEntryOidData(int index) { }

	// RVA: 0x128D18C
	public string GetEntryValue(int index, int tag) { }

	// RVA: 0x128B584
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

	// RVA: 0x12920B0
	public void .ctor(IntPtr handle) { }

	// RVA: 0x129275C
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store
{
	// Fields
	private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

	// Methods

	// RVA: 0x128FC40
	internal BoringX509StoreHandle get_Handle() { }

	// RVA: 0x1291D48
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x1291DCC
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x1291E64
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1291EF4
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x1291F8C
	private static BoringX509StoreHandle Create_internal() { }

	// RVA: 0x12920BC
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	// RVA: 0x12921D8
	internal void .ctor() { }

	// RVA: 0x128B0C8
	internal void .ctor(BoringSslCtxHandle ctx) { }

	// RVA: 0x129042C
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1292204
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x12923B0
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12923E8
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x12924C4
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509StoreCtxHandle
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x1292F08
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1293D54
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx
{
	// Fields
	private System.Nullable<System.Int32> verifyResult; // 0x20

	// Methods

	// RVA: 0x12927E0
	internal BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x1292864
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x12928E8
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x1292980
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, IntPtr error_string) { }

	// RVA: 0x1292A10
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x1292AA8
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x1292B40
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x1292BD0
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x1292C68
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x1292D00
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x1292D98
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x1292E30
	internal void .ctor() { }

	// RVA: 0x1292F38
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x128B128
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x129304C
	internal void .ctor(BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }

	// RVA: 0x1293078
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x1293170
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x1293338
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x1293500
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x1293744
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1293914
	public int get_VerifyResult() { }

	// RVA: 0x12939FC
	public int Verify() { }

	// RVA: 0x1293B88
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

	// RVA: 0x1293DF4
	private static void Initialize() { }

	// RVA: 0x1293FD4
	private static void DoInitialize() { }

	// RVA: 0x129416C
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

	// RVA: 0x1294808
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12951C8
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam
{
	// Methods

	// RVA: 0x128C1D8
	internal BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x12942B8
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x1294350
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x12943E8
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x1294480
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x1294518
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, Int64 time) { }

	// RVA: 0x12945A8
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x1294640
	internal void .ctor(BoringX509VerifyParamHandle handle) { }

	// RVA: 0x1294648
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x1294814
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x1294B34
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x129485C
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail) { }

	// RVA: 0x1294B7C
	public bool get_CanModify() { }

	// RVA: 0x1294C74
	private void WantToModify() { }

	// RVA: 0x1294CDC
	public void SetHost(string name) { }

	// RVA: 0x1294F84
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

	// RVA: 0x129524C
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x1295290
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x1295348
	internal void .ctor(Byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x1295394
	internal void .ctor(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1295EB0
	public override bool get_IsValid() { }

	// RVA: 0x1295EC4
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x1295EEC
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x1295F14
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1295F84
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x1295FC4
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1295FCC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1296010
	public override bool get_HasPrivateKey() { }

	// RVA: 0x1296020
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1296050
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1296194
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x12961C4
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x129576C
	private void Import(Byte[] data) { }

	// RVA: 0x12957D8
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	// RVA: 0x1295DDC
	private void ImportAuthenticode(Byte[] data) { }

	// RVA: 0x1296204
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

	// RVA: 0x1296488
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x1296524
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x1296838
	public override bool get_IsValid() { }

	// RVA: 0x129684C
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x1296874
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1296B98
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1296BA0
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x1296CA4
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1296CAC
	public override void Reset() { }

	// RVA: 0x1296D5C
	protected override void Dispose(bool disposing) { }

}

// Namespace: Mono.Btls
internal class X509PalImplBtls
{
	// Fields
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1296EBC
	public void .ctor(MonoTlsProvider provider) { }

	// RVA: 0x1296FD8
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x1296FE0
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0x1297008
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1297028
	public override X509Certificate2Impl Import(X509Certificate cert) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Internal.Cryptography.OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1299778
	private static void .cctor() { }

	// RVA: 0x12997E4
	public void .ctor() { }

	// RVA: 0x12997EC
	internal string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

	// RVA: 0x12998B8
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

	// RVA: 0x1297048
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1297558
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1297230
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x1297238
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1297744
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1297A6C
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

	// RVA: 0x129B284
	public void .ctor(int <>1__state) { }

	// RVA: 0x129B2BC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x129B2C0
	private bool MoveNext() { }

	// RVA: 0x129B594
	private System.Collections.Generic.KeyValuePair<System.String,System.String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	// RVA: 0x129B5A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x129B5E0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x129B648
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x129B6F0
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

	// RVA: 0x1299980
	internal void .ctor(Byte[] rawData) { }

	// RVA: 0x129A1B8
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x129AA50
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x129AFD0
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	// RVA: 0x129B1FC
	private static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(X500DistinguishedName name) { }

}

// Namespace: System
internal static class IPv4AddressHelper
{
	// Methods

	// RVA: 0x129B6F4
	internal static int ParseHostNumber(System.ReadOnlySpan<System.Char> str, int start, int end) { }

	// RVA: 0x129B8FC
	internal static bool IsValid(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x129B728
	private static bool ParseCanonical(System.ReadOnlySpan<System.Char> name, Byte* numbers, int start, int end) { }

	// RVA: 0x129B928
	internal static bool IsValidCanonical(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x129BC50
	internal static Int64 ParseNonCanonical(Char* name, int start, int end, bool notImplicitFile) { }

	// RVA: 0x129C018
	internal static string ParseCanonicalName(string str, int start, int end, bool isLoopback) { }

	// RVA: 0x129C4D8
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

}

// Namespace: System
internal static class IPv6AddressHelper
{
	// Methods

	// RVA: 0x129C548
	internal static System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x129C63C
	internal static bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x129C720
	internal static bool IsValidStrict(Char* name, int start, int end) { }

	// RVA: 0x129CB9C
	internal static void Parse(System.ReadOnlySpan<System.Char> address, UInt16* numbers, int start, string scopeId) { }

	// RVA: 0x129D138
	internal static string ParseCanonicalName(string str, int start, bool isLoopback, string scopeId) { }

	// RVA: 0x129DA4C
	private static bool IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x129DB38
	private static bool InternalIsValid(Char* name, int start, int end, bool validateStrictAddress) { }

	// RVA: 0x129DF18
	internal static bool IsValid(Char* name, int start, int end) { }

}

// Namespace: System
internal static class NotImplemented
{
	// Methods

	// RVA: 0x129DF20
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

	// RVA: 0x129DF88
	public void .ctor(Uri uri) { }

	// RVA: 0x129E160
	private void Init(Uri uri) { }

	// RVA: 0x129E530
	public void set_Path(string value) { }

	// RVA: 0x129E5F8
	public Uri get_Uri() { }

	// RVA: 0x129E6A0
	public override bool Equals(object rparam) { }

	// RVA: 0x129E78C
	public override int GetHashCode() { }

	// RVA: 0x129E340
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x129E844
	public override string ToString() { }

}

// Namespace: System
internal static class SecurityUtils
{
	// Methods

	// RVA: 0x129EEA8
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x129EEAC
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x129EEB0
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x129EEB8
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x129EEC4
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x129EFE4
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x129EFEC
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x129EFF4
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x129F1A8
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x129F250
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

	// RVA: 0x129F444
	internal void .ctor() { }

	// RVA: 0x129F4F8
	public int Compare(object a, object b) { }

	// RVA: 0x129F5F4
	private static void .cctor() { }

}

// Namespace: System
internal static class IriHelper
{
	// Methods

	// RVA: 0x129F65C
	internal static bool CheckIriUnicodeRange(Char unicode, bool isQuery) { }

	// RVA: 0x129F6B4
	internal static bool CheckIriUnicodeRange(Char highSurr, Char lowSurr, bool surrogatePair, bool isQuery) { }

	// RVA: 0x129FD30
	internal static bool CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0x129FEA0
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

	// RVA: 0x12A1320
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

	// RVA: 0x12A1328
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

	// RVA: 0x1229AB8
	private bool get_IsImplicitFile() { }

	// RVA: 0x1229AC4
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x1229AD4
	private bool get_IsDosPath() { }

	// RVA: 0x1229AE0
	private bool get_IsUncPath() { }

	// RVA: 0x1229AEC
	private Flags get_HostType() { }

	// RVA: 0x1229AF8
	private UriParser get_Syntax() { }

	// RVA: 0x1229B00
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x1229B10
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x1229BD8
	private bool get_AllowIdn() { }

	// RVA: 0x1229CF4
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0x1229E30
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1229E38
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1229E44
	private void SetUserDrivenParsing() { }

	// RVA: 0x1229E58
	private UInt16 get_SecuredPathIndex() { }

	// RVA: 0x1229CE4
	private bool NotAny(Flags flags) { }

	// RVA: 0x1229EB8
	private bool InFact(Flags flags) { }

	// RVA: 0x1229E24
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x1229EC8
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x1229ED4
	private UriInfo EnsureUriInfo() { }

	// RVA: 0x122A514
	private void EnsureParseRemaining() { }

	// RVA: 0x122B3C4
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x122B84C
	public void .ctor(string uriString) { }

	// RVA: 0x122BAA4
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x122BB34
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x122BC24
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x122C538
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x122C784
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, string result) { }

	// RVA: 0x122D740
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x122D8DC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122D9FC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122DA00
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122DB5C
	public string get_AbsolutePath() { }

	// RVA: 0x122DC1C
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x122DD18
	public string get_AbsoluteUri() { }

	// RVA: 0x122DE54
	public string get_LocalPath() { }

	// RVA: 0x122E664
	public string get_Authority() { }

	// RVA: 0x122E6DC
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x122E82C
	public bool get_IsDefaultPort() { }

	// RVA: 0x122E908
	public bool get_IsFile() { }

	// RVA: 0x122E9CC
	public bool get_IsLoopback() { }

	// RVA: 0x122EA88
	public string get_PathAndQuery() { }

	// RVA: 0x122EB50
	public string[] get_Segments() { }

	// RVA: 0x122EDA4
	public bool get_IsUnc() { }

	// RVA: 0x122EE1C
	public string get_Host() { }

	// RVA: 0x122EE94
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x122EEB0
	private static object get_InitializeLock() { }

	// RVA: 0x122EFB4
	private static void InitializeUriConfig() { }

	// RVA: 0x122DEC4
	private string GetLocalPath() { }

	// RVA: 0x122F770
	public int get_Port() { }

	// RVA: 0x122F868
	public string get_Query() { }

	// RVA: 0x122F9A8
	public string get_Fragment() { }

	// RVA: 0x122FAE8
	public string get_Scheme() { }

	// RVA: 0x122FB5C
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x122CB50
	public string get_OriginalString() { }

	// RVA: 0x122FBB8
	public string get_DnsSafeHost() { }

	// RVA: 0x122BC14
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x122FE30
	public bool get_UserEscaped() { }

	// RVA: 0x122FE3C
	public string get_UserInfo() { }

	// RVA: 0x122FEB4
	internal static bool IsGenDelim(Char ch) { }

	// RVA: 0x122FED8
	public static bool IsHexDigit(Char character) { }

	// RVA: 0x122FF04
	public static int FromHex(Char digit) { }

	// RVA: 0x122FF98
	public override int GetHashCode() { }

	// RVA: 0x1230244
	public override string ToString() { }

	// RVA: 0x12305C0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x122C37C
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x12305F4
	public override bool Equals(object comparand) { }

	// RVA: 0x1230D5C
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x1230E20
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x1230F10
	private static ParsingError ParseScheme(string uriString, Flags flags, UriParser syntax) { }

	// RVA: 0x1231618
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x12316AC
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1232D20
	private void PrivateParseMinimalIri(string newHost, UInt16 idx) { }

	// RVA: 0x1229F04
	private void CreateUriInfo(Flags cF) { }

	// RVA: 0x122B424
	private void CreateHostString() { }

	// RVA: 0x1233264
	private static string CreateHostStringHelper(string str, UInt16 idx, UInt16 end, Flags flags, string scopeId) { }

	// RVA: 0x1232E18
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x122DB58
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1233A30
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x122F684
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x12341D8
	private string ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1233B20
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x122A524
	private void ParseRemaining() { }

	// RVA: 0x1231020
	private static UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ParsingError err, Flags flags, UriParser syntax) { }

	// RVA: 0x1235784
	private static bool CheckKnownSchemes(Int64* lptr, UInt16 nChars, UriParser syntax) { }

	// RVA: 0x122C9F4
	private static ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, UriParser syntax) { }

	// RVA: 0x1231DA0
	private UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ParsingError err, Flags flags, UriParser syntax, string newHost) { }

	// RVA: 0x1235CD8
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, Flags flags, bool justNormalized, string newHost, ParsingError err) { }

	// RVA: 0x123614C
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, Flags flags, string newHost, ParsingError err) { }

	// RVA: 0x123561C
	private void FindEndOfComponent(string input, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1236654
	private void FindEndOfComponent(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1233448
	private Check CheckCanonical(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1234E84
	private Char[] GetCanonicalPath(Char[] dest, int pos, UriFormat formatAs) { }

	// RVA: 0x1236700
	private static void UnescapeOnly(Char* pch, int start, int end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0x122F188
	private static Char[] Compress(Char[] dest, UInt16 start, int destLength, UriParser syntax) { }

	// RVA: 0x1230168
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x122CBB4
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x1236908
	internal bool get_HasAuthority() { }

	// RVA: 0x1231D70
	private static bool IsLWS(Char ch) { }

	// RVA: 0x1231D8C
	private static bool IsAsciiLetter(Char character) { }

	// RVA: 0x1236914
	internal static bool IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0x1236988
	internal static bool IsBidiControlCharacter(Char ch) { }

	// RVA: 0x1236464
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	// RVA: 0x122B8D0
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x12369AC
	private void InitializeUri(ParsingError err, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x123709C
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x123718C
	private bool CheckForUnicode(string data) { }

	// RVA: 0x12372C8
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x1230C60
	public static bool TryCreate(string uriString, UriKind uriKind, Uri result) { }

	// RVA: 0x1237798
	public static bool TryCreate(Uri baseUri, string relativeUri, Uri result) { }

	// RVA: 0x12378D4
	public static bool TryCreate(Uri baseUri, Uri relativeUri, Uri result) { }

	// RVA: 0x1233854
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1237D24
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x123822C
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x1237D78
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x1238330
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x12384F4
	public static string EscapeDataString(string stringToEscape) { }

	// RVA: 0x123572C
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1238630
	private void .ctor(Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x12374D8
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x122BDDC
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, string newUriString, bool userEscaped, UriFormatException e) { }

	// RVA: 0x1237AB8
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x1230344
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x1238688
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x1238740
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x122C3C4
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x1238944
	private static void .cctor() { }

}

// Namespace: System
[Serializable]
public class UriFormatException
{
	// Methods

	// RVA: 0x12A1330
	public void .ctor() { }

	// RVA: 0x129ECB8
	public void .ctor(string textString) { }

	// RVA: 0x12A1338
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12A1340
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

	// RVA: 0x12A1348
	internal static bool TestForSubPath(Char* pMe, UInt16 meLength, Char* pShe, UInt16 sheLength, bool ignoreCase) { }

	// RVA: 0x12A15C4
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, int destPos, bool isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0x12A1CD8
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, int destPos, int prevInputPos) { }

	// RVA: 0x12A21A4
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x12A227C
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x12A09E0
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x12A1210
	internal static void EscapeAsciiChar(Char ch, Char[] to, int pos) { }

	// RVA: 0x12A0904
	internal static Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0x12A096C
	internal static bool IsNotSafeForUnescape(Char ch) { }

	// RVA: 0x12A2008
	private static bool IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0x12A1E90
	internal static bool IsUnreserved(Char c) { }

	// RVA: 0x12A2DD0
	internal static bool Is3986Unreserved(Char c) { }

	// RVA: 0x12A2EA0
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

	// RVA: 0x12A3D18
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

	// RVA: 0x12A2F44
	internal string get_SchemeName() { }

	// RVA: 0x12A2F4C
	internal int get_DefaultPort() { }

	// RVA: 0x12A2F54
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x12A2F58
	protected virtual void InitializeAndValidate(Uri uri, UriFormatException parsingError) { }

	// RVA: 0x12A2F94
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, UriFormatException parsingError) { }

	// RVA: 0x12A31B8
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x12A31D8
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x12A33FC
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x12A2D6C
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x12A3418
	private static void .cctor() { }

	// RVA: 0x12A3E14
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x129EE3C
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x129EDD0
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x12A3E7C
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x12A3E1C
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x12A3EE8
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x12A3F5C
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x129ECC0
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x12A426C
	internal bool get_IsSimple() { }

	// RVA: 0x12A4278
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x12A42E4
	internal void InternalValidate(Uri thisUri, UriFormatException parsingError) { }

	// RVA: 0x12A42F0
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, UriFormatException parsingError) { }

	// RVA: 0x12A42FC
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x12A4308
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x12A4314
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: System
internal class DomainNameHelper
{
	// Methods

	// RVA: 0x12A4320
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x12A44C0
	internal static bool IsValid(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x12A46E8
	internal static bool IsValidByIri(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x12A48E0
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x12A4C58
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, string bidiStrippedHost) { }

	// RVA: 0x12A4EC0
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x12A4E74
	private static bool IsIdnAce(Char* input, int index) { }

	// RVA: 0x12A4F54
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	// RVA: 0x12A5090
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x12A4660
	private static bool IsASCIILetterOrDigit(Char character, bool notCanonical) { }

	// RVA: 0x12A469C
	private static bool IsValidDomainLabelCharacter(Char character, bool notCanonical) { }

}

// Namespace: System
internal class UncNameHelper
{
	// Methods

	// RVA: 0x12A561C
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x12A5624
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

	// RVA: 0x12A5A64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12A5B84
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

	// RVA: 0x12A5B98
	protected void .ctor() { }

	// RVA: 0x12A5BA0
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x12A5BF4
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x12A5C44
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x12A5C4C
	public object get_AsyncState() { }

	// RVA: 0x12A5C54
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x12A5DA4
	public bool get_CompletedSynchronously() { }

	// RVA: 0x12A5DAC
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x12A5DB4
	public bool get_IsCompleted() { }

	// RVA: 0x12A5DBC
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

	// RVA: 0x12A5E98
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x12A5EF0
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x12A5F1C
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x12A5F20
	public void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector
{
	// Methods

	// RVA: 0x12A5F44
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal class SRDescriptionAttribute
{
	// Fields
	private bool isReplaced; // 0x18

	// Methods

	// RVA: 0x12A5F48
	public void .ctor(string description) { }

	// RVA: 0x12A5FB4
	public override string get_Description() { }

}

// Namespace: System
public class UriTypeConverter
{
	// Methods

	// RVA: 0x12A6014
	public void .ctor() { }

	// RVA: 0x12A601C
	private bool CanConvert(Type type) { }

	// RVA: 0x12A6104
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12A61E0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12A6288
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12A6440
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Web
public sealed class HttpUtility
{
	// Methods

	// RVA: 0x12A663C
	public static string UrlEncode(string str) { }

	// RVA: 0x12A6668
	public static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x12A68C8
	public static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Web.Util.HttpEncoder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x12A7284
	private static void .cctor() { }

	// RVA: 0x12A72F0
	public void .ctor() { }

	// RVA: 0x12A72F8
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

	// RVA: 0x12A6964
	public static HttpEncoder get_Current() { }

	// RVA: 0x12A6A74
	private static void .cctor() { }

	// RVA: 0x12A6C6C
	public void .ctor() { }

	// RVA: 0x12A6C74
	protected internal virtual Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	// RVA: 0x12A6EFC
	private static HttpEncoder GetCustomEncoderFromConfig() { }

	// RVA: 0x12A6CEC
	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	// RVA: 0x12A68A8
	internal static bool NotEncoded(Char c) { }

	// RVA: 0x12A6FA4
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

	// RVA: 0x12A7350
	internal void .ctor(string text, int index, int length) { }

	// RVA: 0x12A739C
	public int get_Index() { }

	// RVA: 0x12A73A4
	internal void set_Index(int value) { }

	// RVA: 0x12A73AC
	public int get_Length() { }

	// RVA: 0x12A73B4
	internal void set_Length(int value) { }

	// RVA: 0x12A73BC
	internal string get_Text() { }

	// RVA: 0x12A73C4
	internal void set_Text(string value) { }

	// RVA: 0x12A73CC
	public string get_Value() { }

	// RVA: 0x12A73F4
	public override string ToString() { }

	// RVA: 0x12A741C
	internal System.ReadOnlySpan<System.Char> GetLeftSubstring() { }

	// RVA: 0x12A74C0
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

	// RVA: 0x12A7564
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x12A7630
	public bool get_Success() { }

	// RVA: 0x12A7640
	private static void .cctor() { }

	// RVA: 0x12A77C0
	internal void .ctor() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12A7C50
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x12A8B14
	public bool MoveNext() { }

	// RVA: 0x12A8B6C
	public Group get_Current() { }

	// RVA: 0x12A8BFC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A8C00
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12A8C0C
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

	// RVA: 0x12A77FC
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x12A784C
	public bool get_IsReadOnly() { }

	// RVA: 0x12A7854
	public int get_Count() { }

	// RVA: 0x12A787C
	public Group get_Item(int groupnum) { }

	// RVA: 0x12A79B0
	public Group get_Item(string groupname) { }

	// RVA: 0x12A7BD4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12A7C90
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x12A7880
	private Group GetGroup(int groupnum) { }

	// RVA: 0x12A7D0C
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x12A8088
	public bool get_IsSynchronized() { }

	// RVA: 0x12A8090
	public object get_SyncRoot() { }

	// RVA: 0x12A8098
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12A816C
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x12A8334
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x12A8418
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x12A846C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x12A84C0
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x12A84C4
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x12A8518
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x12A856C
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x12A85C0
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x12A8678
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x12A86CC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12A8720
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12A8774
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12A8878
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12A897C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12A89D0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12A89D8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12A8A2C
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12A8A80
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12A8A84
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12A8AD8
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

	// RVA: 0x12A8C10
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x12A8DC4
	public static Match get_Empty() { }

	// RVA: 0x12A8E40
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x12A8EC8
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x12A8F84
	public Match NextMatch() { }

	// RVA: 0x12A92B8
	internal virtual System.ReadOnlySpan<System.Char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x12A9470
	internal System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }

	// RVA: 0x12A949C
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x12A969C
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x12A977C
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x12A97B8
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x12A9850
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x12A98E8
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x12A9980
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x12A9AFC
	private static void .cctor() { }

	// RVA: 0x12A9BA4
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Methods

	// RVA: 0x12A9BE0
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x12A9C9C
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

	// RVA: 0x12AA17C
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x12AAB20
	public bool MoveNext() { }

	// RVA: 0x12AAB8C
	public Match get_Current() { }

	// RVA: 0x12AAC00
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12AAC04
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12AAC10
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

	// RVA: 0x12A9D5C
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x12A9EB4
	public bool get_IsReadOnly() { }

	// RVA: 0x12A9EBC
	public int get_Count() { }

	// RVA: 0x12A9F40
	public virtual Match get_Item(int i) { }

	// RVA: 0x12AA100
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12AA1BC
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x12A9FAC
	private Match GetMatch(int i) { }

	// RVA: 0x12A9F2C
	private void EnsureInitialized() { }

	// RVA: 0x12AA238
	public bool get_IsSynchronized() { }

	// RVA: 0x12AA240
	public object get_SyncRoot() { }

	// RVA: 0x12AA244
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12AA324
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x12AA3B4
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x12AA43C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x12AA490
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x12AA4E4
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x12AA4F4
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x12AA548
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x12AA59C
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x12AA5F0
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x12AA678
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x12AA6CC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12AA720
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12AA774
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12AA878
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12AA97C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12AA9D0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12AA9D8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12AAA2C
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12AAA80
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12AAA90
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12AAAE4
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

	// RVA: 0x12AAC14
	public RegexRunner Get() { }

	// RVA: 0x12AACA4
	public void Release(RegexRunner obj) { }

	// RVA: 0x12AADB4
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

	// RVA: 0x12AD900
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x12ADCD4
	public override bool Equals(object obj) { }

	// RVA: 0x12ADD94
	public bool Equals(CachedCodeEntryKey other) { }

	// RVA: 0x12AAF10
	public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	// RVA: 0x12ADE00
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

	// RVA: 0x12AB764
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

	// RVA: 0x12AADBC
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x12AAF84
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x12AB844
	private void FillCacheDictionary() { }

	// RVA: 0x12AB95C
	private static bool TryGetCacheValue(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x12ABA94
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x12AB4EC
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	// RVA: 0x12ABCF4
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x12ABDD8
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12AC1D0
	public bool IsMatch(string input) { }

	// RVA: 0x12AC25C
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x12AC2E4
	public static Match Match(string input, string pattern) { }

	// RVA: 0x12AC3C8
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12AC458
	public Match Match(string input) { }

	// RVA: 0x12AC4D8
	public Match Match(string input, int startat) { }

	// RVA: 0x12AC554
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x12AC638
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12AC6C8
	public MatchCollection Matches(string input) { }

	// RVA: 0x12AC748
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x12AC81C
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x12AC914
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12AC9B4
	public string Replace(string input, string replacement) { }

	// RVA: 0x12ACA3C
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x12ACB18
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x12ACC04
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x12ACCA4
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x12ACD2C
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x12ACE00
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x12AD250
	private static void .cctor() { }

	// RVA: 0x12AD600
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x12AD3A0
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x12AD7BC
	public void .ctor(string pattern) { }

	// RVA: 0x12AD838
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x12AD8C0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x12ABE68
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x12ADBAC
	public static string Escape(string str) { }

	// RVA: 0x12ADC68
	public RegexOptions get_Options() { }

	// RVA: 0x12AD244
	public bool get_RightToLeft() { }

	// RVA: 0x12ADC70
	public override string ToString() { }

	// RVA: 0x12A7F24
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x12A7A68
	public int GroupNumberFromName(string name) { }

	// RVA: 0x12ADA98
	protected void InitializeReferences() { }

	// RVA: 0x12A8FB4
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x12AC250
	protected internal bool UseOptionR() { }

	// RVA: 0x12ADC78
	internal bool UseOptionInvariant() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator
{
	// Methods

	// RVA: 0x12ADE60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12ADF80
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

	// RVA: 0x12ADF94
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x12AE5A0
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x12AE718
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x12AE788
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

	// RVA: 0x12B6838
	internal void .ctor(Char chMin, Char chMax, int lcOp, int data) { }

}

// Namespace: 
private sealed class SingleRangeComparer
{
	// Fields
	public static readonly SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x12B6848
	private void .ctor() { }

	// RVA: 0x12B6850
	public int Compare(SingleRange x, SingleRange y) { }

	// RVA: 0x12B68C8
	private static void .cctor() { }

}

// Namespace: 
private struct SingleRange
{
	// Fields
	public readonly Char First; // 0x10
	public readonly Char Last; // 0x12

	// Methods

	// RVA: 0x12AF1EC
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

	// RVA: 0x12AEA84
	public void .ctor() { }

	// RVA: 0x12AEB5C
	private void .ctor(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x12AEBD8
	public bool get_CanMerge() { }

	// RVA: 0x12AEBF8
	public void set_Negate(bool value) { }

	// RVA: 0x12AEC00
	public void AddChar(Char c) { }

	// RVA: 0x12AECDC
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x12AEFE0
	private void AddSet(string set) { }

	// RVA: 0x12AF1F8
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x12AEC08
	public void AddRange(Char first, Char last) { }

	// RVA: 0x12AF200
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x12AF768
	private void AddCategory(string category) { }

	// RVA: 0x12AF788
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x12AF918
	private void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0x12AFBC8
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x12AFCEC
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x12AFE10
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x12AFED4
	public static Char SingletonChar(string set) { }

	// RVA: 0x12AFEF0
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x12B005C
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x12B0164
	public static bool IsSingleton(string set) { }

	// RVA: 0x12B02A4
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x12AFFFC
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x12AFFD4
	private static bool IsNegated(string set) { }

	// RVA: 0x12B03E8
	public static bool IsECMAWordChar(Char ch) { }

	// RVA: 0x12B0538
	public static bool IsWordChar(Char ch) { }

	// RVA: 0x12B04CC
	public static bool CharInClass(Char ch, string set) { }

	// RVA: 0x12B0614
	private static bool CharInClassRecursive(Char ch, string set, int start) { }

	// RVA: 0x12B0748
	private static bool CharInClassInternal(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x12B0870
	private static bool CharInCategory(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x12B0AA0
	private static bool CharInCategoryGroup(Char ch, UnicodeCategory chcategory, string category, int i) { }

	// RVA: 0x12AF444
	private static string NegateCategory(string category) { }

	// RVA: 0x12B0B6C
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x12B0BF4
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x12AEF1C
	private int RangeCount() { }

	// RVA: 0x12B0E68
	public string ToStringClass() { }

	// RVA: 0x12AEF68
	private SingleRange GetRangeAt(int i) { }

	// RVA: 0x12B103C
	private void Canonicalize() { }

	// RVA: 0x12AF4F0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x12B12B8
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

	// RVA: 0x12B6934
	public void .ctor(int[] codes, System.Collections.Generic.List<System.String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x12B6A48
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

	// RVA: 0x12B6A6C
	private void .ctor(System.Span<System.Int32> intStack) { }

	// RVA: 0x12B6B4C
	public static System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x12B7128
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x12B739C
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x12B7568
	private static int AnchorFromType(int type) { }

	// RVA: 0x12B75D0
	private void PushInt(int i) { }

	// RVA: 0x12B763C
	private bool IntIsEmpty() { }

	// RVA: 0x12B7684
	private int PopInt() { }

	// RVA: 0x12B77AC
	private void PushFC(RegexFC fc) { }

	// RVA: 0x12B7810
	private bool FCIsEmpty() { }

	// RVA: 0x12B7864
	private RegexFC PopFC() { }

	// RVA: 0x12B7948
	private RegexFC TopFC() { }

	// RVA: 0x12B7098
	public void Dispose() { }

	// RVA: 0x12B6E9C
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x12B7F9C
	private void SkipChild() { }

	// RVA: 0x12B79C4
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

	// RVA: 0x12B7FA8
	public void .ctor(bool nullable) { }

	// RVA: 0x12B80EC
	public void .ctor(Char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x12B81EC
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x12B8028
	public bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x12B82F0
	public bool get_CaseInsensitive() { }

	// RVA: 0x12B82F8
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x12B70EC
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

	// RVA: 0x12ADC84
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x12B8300
	protected override void InitTrackCount() { }

	// RVA: 0x12B8324
	private void Advance(int i) { }

	// RVA: 0x12B83AC
	private void Goto(int newpos) { }

	// RVA: 0x12B842C
	private void Textto(int newpos) { }

	// RVA: 0x12B8434
	private void Trackto(int newpos) { }

	// RVA: 0x12B845C
	private int Textstart() { }

	// RVA: 0x12B8464
	private int Textpos() { }

	// RVA: 0x12B846C
	private int Trackpos() { }

	// RVA: 0x12B8494
	private void TrackPush() { }

	// RVA: 0x12B84D8
	private void TrackPush(int I1) { }

	// RVA: 0x12B8538
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x12B85B4
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x12B864C
	private void TrackPush2(int I1) { }

	// RVA: 0x12B86B0
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x12B8730
	private void Backtrack() { }

	// RVA: 0x12B838C
	private void SetOperator(int op) { }

	// RVA: 0x12B8838
	private void TrackPop() { }

	// RVA: 0x12B8848
	private void TrackPop(int framesize) { }

	// RVA: 0x12B8858
	private int TrackPeek() { }

	// RVA: 0x12B8894
	private int TrackPeek(int i) { }

	// RVA: 0x12B88D4
	private void StackPush(int I1) { }

	// RVA: 0x12B8914
	private void StackPush(int I1, int I2) { }

	// RVA: 0x12B8970
	private void StackPop() { }

	// RVA: 0x12B8980
	private void StackPop(int framesize) { }

	// RVA: 0x12B8990
	private int StackPeek() { }

	// RVA: 0x12B89CC
	private int StackPeek(int i) { }

	// RVA: 0x12B8A0C
	private int Operator() { }

	// RVA: 0x12B8A14
	private int Operand(int i) { }

	// RVA: 0x12B8A5C
	private int Leftchars() { }

	// RVA: 0x12B8A6C
	private int Rightchars() { }

	// RVA: 0x12B8A7C
	private int Bump() { }

	// RVA: 0x12B8A90
	private int Forwardchars() { }

	// RVA: 0x12B8ABC
	private Char Forwardcharnext() { }

	// RVA: 0x12B8B50
	private bool Stringmatch(string str) { }

	// RVA: 0x12B8CC4
	private bool Refmatch(int index, int len) { }

	// RVA: 0x12B8E6C
	private void Backwardnext() { }

	// RVA: 0x12B8E9C
	private Char CharAt(int j) { }

	// RVA: 0x12B8EBC
	protected override bool FindFirstChar() { }

	// RVA: 0x12B9460
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

	// RVA: 0x12BB868
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x12BB984
	public void .ctor() { }

	// RVA: 0x12BBA3C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12BBBC0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12BBCC8
	public string get_Input() { }

	// RVA: 0x12BBCD0
	public string get_Pattern() { }

	// RVA: 0x12BBCD8
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

	// RVA: 0x12BBCE0
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x12BBD1C
	public void .ctor(int type, RegexOptions options, Char ch) { }

	// RVA: 0x12BBD60
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x12BBDAC
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x12BBDF0
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x12BBE40
	public bool UseOptionR() { }

	// RVA: 0x12BBE4C
	public RegexNode ReverseLeft() { }

	// RVA: 0x12BBECC
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x12BBEE4
	private RegexNode Reduce() { }

	// RVA: 0x12BCC24
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x12BC9EC
	private RegexNode ReduceGroup() { }

	// RVA: 0x12BC820
	private RegexNode ReduceRep() { }

	// RVA: 0x12BCA74
	private RegexNode ReduceSet() { }

	// RVA: 0x12BBFE0
	private RegexNode ReduceAlternation() { }

	// RVA: 0x12BC424
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x12BCE20
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x12BCF7C
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x12BCDA8
	public RegexNode Child(int i) { }

	// RVA: 0x12BCD50
	public int ChildCount() { }

	// RVA: 0x12BD074
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

	// RVA: 0x12BD07C
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x12BE734
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x12BEEA0
	public static string Escape(string input) { }

	// RVA: 0x12BD2DC
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x12BD3BC
	private void SetPattern(string Re) { }

	// RVA: 0x12BD838
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x12BD8D8
	private RegexNode ScanRegex() { }

	// RVA: 0x12BE8FC
	private RegexNode ScanReplacement() { }

	// RVA: 0x12BFD80
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x12C04AC
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x12BF2C8
	private void ScanBlank() { }

	// RVA: 0x12C14F4
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x12C2D44
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x12C1E14
	private RegexNode ScanDollar() { }

	// RVA: 0x12C281C
	private string ScanCapname() { }

	// RVA: 0x12C3474
	private Char ScanOctal() { }

	// RVA: 0x12C1CF4
	private int ScanDecimal() { }

	// RVA: 0x12C3584
	private Char ScanHex(int c) { }

	// RVA: 0x12C36DC
	private static int HexDigit(Char ch) { }

	// RVA: 0x12C370C
	private Char ScanControl() { }

	// RVA: 0x12C37C0
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x12C2AA8
	private void ScanOptions() { }

	// RVA: 0x12C24D4
	private Char ScanCharEscape() { }

	// RVA: 0x12C2344
	private string ParseProperty() { }

	// RVA: 0x12C2CB4
	private int TypeFromCode(Char ch) { }

	// RVA: 0x12C37E0
	private static RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0x12BD430
	private void CountCaptures() { }

	// RVA: 0x12C3840
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x12C399C
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x12BE8B8
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x12C3B10
	private void AssignNameSlots() { }

	// RVA: 0x12C2A10
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x12C2930
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x12C29F4
	private bool IsCaptureName(string capname) { }

	// RVA: 0x12C2924
	private bool UseOptionN() { }

	// RVA: 0x12BFD74
	private bool UseOptionI() { }

	// RVA: 0x12C1B28
	private bool UseOptionM() { }

	// RVA: 0x12C1BB0
	private bool UseOptionS() { }

	// RVA: 0x12BF634
	private bool UseOptionX() { }

	// RVA: 0x12C2338
	private bool UseOptionE() { }

	// RVA: 0x12BF910
	private static bool IsSpecial(Char ch) { }

	// RVA: 0x12BF6A0
	private static bool IsStopperX(Char ch) { }

	// RVA: 0x12BF9B0
	private static bool IsQuantifier(Char ch) { }

	// RVA: 0x12BF740
	private bool IsTrueQuantifier() { }

	// RVA: 0x12C2C14
	private static bool IsSpace(Char ch) { }

	// RVA: 0x12BF164
	private static bool IsMetachar(Char ch) { }

	// RVA: 0x12BFA50
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x12C0E68
	private void PushGroup() { }

	// RVA: 0x12C130C
	private void PopGroup() { }

	// RVA: 0x12C105C
	private bool EmptyStack() { }

	// RVA: 0x12BF204
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x12C0ED4
	private void AddAlternate() { }

	// RVA: 0x12C1C88
	private void AddConcatenate() { }

	// RVA: 0x12C1DC8
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x12C41FC
	private RegexNode Unit() { }

	// RVA: 0x12BFCB8
	private void AddUnitOne(Char ch) { }

	// RVA: 0x12C1BBC
	private void AddUnitNotone(Char ch) { }

	// RVA: 0x12C03B0
	private void AddUnitSet(string cc) { }

	// RVA: 0x12C4204
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x12C1B34
	private void AddUnitType(int type) { }

	// RVA: 0x12C110C
	private void AddGroup() { }

	// RVA: 0x12C0440
	private void PushOptions() { }

	// RVA: 0x12C1448
	private void PopOptions() { }

	// RVA: 0x12C3948
	private bool EmptyOptionsStack() { }

	// RVA: 0x12C0E00
	private void PopKeepOptions() { }

	// RVA: 0x12C106C
	private ArgumentException MakeException(string message) { }

	// RVA: 0x12C420C
	private int Textpos() { }

	// RVA: 0x12C4214
	private void Textto(int pos) { }

	// RVA: 0x12C1CC4
	private Char RightCharMoveRight() { }

	// RVA: 0x12BF640
	private void MoveRight() { }

	// RVA: 0x12C2914
	private void MoveRight(int i) { }

	// RVA: 0x12C1C78
	private void MoveLeft() { }

	// RVA: 0x12BFC98
	private Char CharAt(int i) { }

	// RVA: 0x12BF678
	internal Char RightChar() { }

	// RVA: 0x12C28E8
	private Char RightChar(int i) { }

	// RVA: 0x12BF650
	private int CharsRight() { }

	// RVA: 0x12C421C
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

	// RVA: 0x12C42C0
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x12C42EC
	internal bool get_CaseInsensitive() { }

	// RVA: 0x12C42F4
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x12C4370
	internal string get_Prefix() { }

	// RVA: 0x12C4378
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

	// RVA: 0x12BEA8C
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x12C4420
	public static RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	// RVA: 0x12C4540
	public string get_Pattern() { }

	// RVA: 0x12C4548
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x12C4704
	private void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, Match match) { }

	// RVA: 0x12C491C
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

	// RVA: 0x12C4CDC
	protected internal void .ctor() { }

	// RVA: 0x12C4CE4
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x12C50DC
	private void StartTimeoutWatch() { }

	// RVA: 0x12C5128
	protected void CheckTimeout() { }

	// RVA: 0x12C53E0
	private void DoCheckTimeout() { }

	// RVA: -1
	protected abstract void Go() { }

	// RVA: -1
	protected abstract bool FindFirstChar() { }

	// RVA: -1
	protected abstract void InitTrackCount() { }

	// RVA: 0x12C5138
	private void InitMatch() { }

	// RVA: 0x12C5378
	private Match TidyMatch(bool quick) { }

	// RVA: 0x12C54BC
	protected void EnsureStorage() { }

	// RVA: 0x12C5680
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12C5784
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12C55CC
	protected void DoubleTrack() { }

	// RVA: 0x12C5518
	protected void DoubleStack() { }

	// RVA: 0x12C5888
	protected void DoubleCrawl() { }

	// RVA: 0x12C593C
	protected void Crawl(int i) { }

	// RVA: 0x12C599C
	protected int Popcrawl() { }

	// RVA: 0x12C59DC
	protected int Crawlpos() { }

	// RVA: 0x12C5A04
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x12C5A98
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x12C5C48
	protected void Uncapture() { }

	// RVA: 0x12C5C98
	protected bool IsMatched(int cap) { }

	// RVA: 0x12C5C00
	protected int MatchIndex(int cap) { }

	// RVA: 0x12C5C24
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

	// RVA: 0x12BE684
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

	// RVA: 0x12C5CBC
	private void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }

	// RVA: 0x12C5E04
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x12C66C4
	public void Dispose() { }

	// RVA: 0x12C60B8
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x12C72C4
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x12C7334
	private void Emit(int op) { }

	// RVA: 0x12C6724
	private void Emit(int op, int opd1) { }

	// RVA: 0x12C73BC
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x12C747C
	private int StringCode(string str) { }

	// RVA: 0x12C75A8
	private int MapCapnum(int capnum) { }

	// RVA: 0x12C67C4
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute
{
	// Fields
	private readonly string tool; // 0x10
	private readonly string version; // 0x18

	// Methods

	// RVA: 0x12C7668
	public void .ctor(string tool, string version) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch
{
	// Methods

	// RVA: 0x12C76B8
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

	// RVA: 0x12C7780
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x12C77EC
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x12C7A24
	private static void _pruneCachedSwitches() { }

	// RVA: 0x12C7F10
	private static void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x12C7FAC
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x12C7FDC
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

	// RVA: 0x12C80C4
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

	// RVA: 0x12C818C
	public static Int64 GetTimestamp() { }

	// RVA: 0x12C8190
	public static Stopwatch StartNew() { }

	// RVA: 0x12C825C
	public void .ctor() { }

	// RVA: 0x12C82E4
	public TimeSpan get_Elapsed() { }

	// RVA: 0x12C8510
	public Int64 get_ElapsedMilliseconds() { }

	// RVA: 0x12C8494
	public Int64 get_ElapsedTicks() { }

	// RVA: 0x12C86CC
	public bool get_IsRunning() { }

	// RVA: 0x12C86D4
	public void Reset() { }

	// RVA: 0x12C8264
	public void Start() { }

	// RVA: 0x12C86E0
	public void Stop() { }

	// RVA: 0x12C875C
	public void Restart() { }

	// RVA: 0x12C87C8
	private static void .cctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute
{
	// Methods

	// RVA: 0x12C8824
	public void .ctor() { }

}

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException
{
	// Methods

	// RVA: 0x12C882C
	public void .ctor() { }

	// RVA: 0x12C8890
	public void .ctor(string message) { }

	// RVA: 0x12C8898
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12C88A0
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

	// RVA: 0x12CA3B0
	private static void .cctor() { }

	// RVA: 0x12CA41C
	public void .ctor() { }

	// RVA: 0x12CA424
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x12CA484
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x12CA4CC
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

	// RVA: 0x12C88A8
	private void set_ContentLength(int value) { }

	// RVA: 0x12C88B0
	internal void .ctor(Byte[] data) { }

	// RVA: 0x12C88D8
	internal void .ctor(Byte[] data, int offset, int length) { }

	// RVA: 0x12C88EC
	private void .ctor(DerTag tagToEat, Byte[] data, int offset, int length) { }

	// RVA: 0x12C8ACC
	internal bool get_HasData() { }

	// RVA: 0x12C8ADC
	internal Byte PeekTag() { }

	// RVA: 0x12C8B7C
	internal void SkipValue() { }

	// RVA: 0x12C8BD8
	internal Byte[] ReadNextEncodedValue() { }

	// RVA: 0x12C8DC8
	internal bool ReadBoolean() { }

	// RVA: 0x12C8E9C
	internal int ReadInteger() { }

	// RVA: 0x12C8F48
	internal Byte[] ReadIntegerBytes() { }

	// RVA: 0x12C90C0
	internal Byte[] ReadBitString() { }

	// RVA: 0x12C9208
	internal Byte[] ReadOctetString() { }

	// RVA: 0x12C92C8
	internal string ReadOidAsString() { }

	// RVA: 0x12C95BC
	internal string ReadUtf8String() { }

	// RVA: 0x12C9748
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	// RVA: 0x12C98B4
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x12C98BC
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x12C98C4
	internal string ReadPrintableString() { }

	// RVA: 0x12C99CC
	internal string ReadIA5String() { }

	// RVA: 0x12C9AD4
	internal string ReadT61String() { }

	// RVA: 0x12C9ED4
	internal DateTime ReadX509Date() { }

	// RVA: 0x12C9FB4
	internal DateTime ReadUtcTime() { }

	// RVA: 0x12CA00C
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x12CA2A8
	internal string ReadBMPString() { }

	// RVA: 0x12C96C4
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x12CA064
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	// RVA: 0x12C9008
	private Byte[] ReadContentAsBytes() { }

	// RVA: 0x12C89F8
	private void EatTag(DerTag expected) { }

	// RVA: 0x12C9814
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	// RVA: 0x12C8A84
	private int EatLength() { }

	// RVA: 0x12C8C94
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

	// RVA: 0x12CA5B8
	public void .ctor() { }

	// RVA: 0x12CA5C0
	public void .ctor(string oid) { }

	// RVA: 0x12CA658
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x12CA6A8
	public void .ctor(Oid oid) { }

	// RVA: 0x12CA744
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x12CA900
	public string get_Value() { }

	// RVA: 0x12CA908
	public void set_Value(string value) { }

	// RVA: 0x12CA910
	public string get_FriendlyName() { }

	// RVA: 0x12CA8A4
	private void .ctor(string value, string friendlyName, OidGroup group) { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection
{
	// Fields
	private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list; // 0x10

	// Methods

	// RVA: 0x12CA9DC
	public void .ctor() { }

	// RVA: 0x12CAA68
	public int Add(Oid oid) { }

	// RVA: 0x12CAAE4
	public Oid get_Item(int index) { }

	// RVA: 0x12CAB5C
	public int get_Count() { }

	// RVA: 0x12CABA8
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x12CAC64
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12CACE0
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12CAF40
	public bool get_IsSynchronized() { }

	// RVA: 0x12CAF48
	public object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Methods

	// RVA: 0x12CAC24
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x12CAF4C
	public Oid get_Current() { }

	// RVA: 0x12CAFC8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12CB044
	public bool MoveNext() { }

	// RVA: 0x12CB0C4
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

	// RVA: 0x12CB0D0
	protected void .ctor() { }

	// RVA: 0x12CB0D8
	public void .ctor(string oid, Byte[] rawData) { }

	// RVA: 0x12CB2DC
	public void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0x12CB430
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12CB584
	public Oid get_Oid() { }

	// RVA: 0x12CB3A0
	public void set_Oid(Oid value) { }

	// RVA: 0x12CB58C
	public Byte[] get_RawData() { }

	// RVA: 0x12CB1D4
	public void set_RawData(Byte[] value) { }

	// RVA: 0x12CB594
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12CB6FC
	public virtual string Format(bool multiLine) { }

	// RVA: 0x12CB8DC
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x12CB7A0
	internal string Default(bool multiLine) { }

	// RVA: 0x12CBAB0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x12CBBD4
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x12CBCFC
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x12CBE24
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x12CBF4C
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x12CC338
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

	// RVA: 0x12CC83C
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x12CC9B8
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x12CC9C0
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x12CC9C8
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x12CD6A4
	public Oid get_Oid() { }

	// RVA: 0x12CD6AC
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x12CCFC4
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0x12CCB94
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0x12CD760
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName
{
	// Fields
	private string name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x12CD7E0
	public void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0x12CDA98
	public void .ctor(string distinguishedName) { }

	// RVA: 0x12CDAA0
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x12CDF98
	public string get_Name() { }

	// RVA: 0x12CDDE8
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12CE028
	public override string Format(bool multiLine) { }

	// RVA: 0x12CDFA0
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12CD98C
	private void DecodeRawData() { }

	// RVA: 0x12CE098
	private static string Canonize(string s) { }

	// RVA: 0x12CE2F4
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

	// RVA: 0x12CE4EC
	public void .ctor() { }

	// RVA: 0x12CC728
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x12CE7EC
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x12CEA9C
	public bool get_CertificateAuthority() { }

	// RVA: 0x12CEB10
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x12CEB84
	public int get_PathLengthConstraint() { }

	// RVA: 0x12CEBF8
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12CE5BC
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12CE940
	internal Byte[] Encode() { }

	// RVA: 0x12CEDF4
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

	// RVA: 0x12CF08C
	public override void Reset() { }

	// RVA: 0x12CF144
	public void .ctor() { }

	// RVA: 0x12CF14C
	public void .ctor(Byte[] rawData) { }

	// RVA: 0x12CF2DC
	public void .ctor(Byte[] rawData, string password) { }

	// RVA: 0x12CF2E4
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x12CF2EC
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x12CF2F4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12CF33C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x12CFA0C
	public bool get_HasPrivateKey() { }

	// RVA: 0x12CFAB8
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12CFCF0
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12CFDE8
	public DateTime get_NotAfter() { }

	// RVA: 0x12CFDF0
	public DateTime get_NotBefore() { }

	// RVA: 0x12CFDF8
	public PublicKey get_PublicKey() { }

	// RVA: 0x12CFFC0
	public Byte[] get_RawData() { }

	// RVA: 0x12D00BC
	public string get_SerialNumber() { }

	// RVA: 0x12D00CC
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x12D01CC
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12D02C4
	public string get_Thumbprint() { }

	// RVA: 0x12D02E4
	public int get_Version() { }

	// RVA: 0x12D03C0
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0x12D045C
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12D0518
	public override string ToString() { }

	// RVA: 0x12D0524
	public override string ToString(bool verbose) { }

	// RVA: 0x12D1C68
	public bool Verify() { }

	// RVA: 0x12CF808
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x12CF778
	internal X509Certificate2Impl get_Impl() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x12D1D10
	public void .ctor() { }

	// RVA: 0x12D1D20
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x12D1DCC
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x12D1EFC
	public int Add(X509Certificate2 certificate) { }

	// RVA: 0x12D1D50
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x12D1F78
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x12D22B0
	private string GetKeyIdentifier(X509Certificate2 x) { }

	// RVA: 0x12D2BD0
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x12D3D58
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x12D3E84
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12D3DBC
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x12D3F2C
	public X509Certificate2 get_Current() { }

	// RVA: 0x12D4030
	public bool MoveNext() { }

	// RVA: 0x12D40E4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12D419C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12D4250
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

	// RVA: 0x12D4308
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

	// RVA: 0x12D4310
	public override bool get_IsValid() { }

	// RVA: 0x12D4320
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x12D435C
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x12D4468
	public void .ctor(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x12D4698
	public override X509CertificateImpl Clone() { }

	// RVA: 0x12D4708
	private X509Certificate get_Cert() { }

	// RVA: 0x12D4730
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x12D4774
	public override bool get_HasPrivateKey() { }

	// RVA: 0x12D479C
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12D4BEC
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x12D4D94
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x12D4E2C
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x12D4620
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x12D4EC4
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	// RVA: 0x12D57EC
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x12D59E4
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x12D59EC
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x12D59F4
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Methods

	// RVA: 0x12D5AD4
	private void EnsureCertData() { }

	// RVA: -1
	protected abstract Byte[] GetRawCertData() { }

	// RVA: 0x12D5BAC
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x12D5C90
	public sealed override Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x12D5D74
	public sealed override Byte[] get_PublicKeyValue() { }

	// RVA: 0x12D5E58
	public sealed override Byte[] get_SerialNumber() { }

	// RVA: 0x12D5F3C
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x12D6020
	public sealed override int get_Version() { }

	// RVA: 0x12D610C
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12D61F0
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12D62D4
	public sealed override string get_Subject() { }

	// RVA: 0x12D6300
	public sealed override string get_Issuer() { }

	// RVA: 0x12D632C
	public sealed override Byte[] get_RawData() { }

	// RVA: 0x12D6410
	public sealed override Byte[] get_Thumbprint() { }

	// RVA: 0x12D6628
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12D6718
	public sealed override System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x12D67FC
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x12D692C
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x12D6A5C
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x12D6B00
	public sealed override Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x12D6C60
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x12D6CC0
	private Byte[] ExportPkcs12(string password) { }

	// RVA: 0x12D4354
	protected void .ctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12D74F8
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x12D75E4
	public X509Certificate get_Current() { }

	// RVA: 0x12D76E8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12D77A0
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12D7854
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12D790C
	public bool MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0x12D1D18
	public void .ctor() { }

	// RVA: 0x12D71F0
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x12D7374
	public X509Certificate get_Item(int index) { }

	// RVA: 0x12D7418
	public int Add(X509Certificate value) { }

	// RVA: 0x12D7220
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x12D7494
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x12D75C0
	public override int GetHashCode() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection
{
	// Fields
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

	// Methods

	// RVA: 0x12D56DC
	public void .ctor() { }

	// RVA: 0x12D79C0
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x12D71A4
	public int get_Count() { }

	// RVA: 0x12D712C
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x12D5768
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x12D4404
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x12D7C2C
	public void Dispose() { }

	// RVA: 0x12D7CBC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12D7FC4
	protected override void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Methods

	// RVA: 0x12D8060
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x12D8104
	public void .ctor() { }

	// RVA: 0x12D8178
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12D8254
	internal void .ctor(X509ChainImpl impl) { }

	// RVA: 0x12D82C0
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x12D8308
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12D8370
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12D5974
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12D83D8
	public void Reset() { }

	// RVA: 0x12D58C8
	public static X509Chain Create() { }

	// RVA: 0x12D8440
	public void Dispose() { }

	// RVA: 0x12D84D0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12D8600
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

	// RVA: 0x12D869C
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x12D871C
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x12D8724
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x12D872C
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x12D8734
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x12D873C
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x12D87F4
	private void Set(X509ChainStatus[] status, int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x12D8A20
	internal void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection
{
	// Fields
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12D99F0
	internal void .ctor() { }

	// RVA: 0x12D9A68
	public int get_Count() { }

	// RVA: 0x12D9A90
	public bool get_IsSynchronized() { }

	// RVA: 0x12D9AB8
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x12D9B5C
	public object get_SyncRoot() { }

	// RVA: 0x12D9B84
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12D9BAC
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x12D9CDC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12D9D44
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x12D9E24
	internal void Clear() { }

	// RVA: 0x12D9E4C
	internal bool Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12D9C14
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x12D9FB8
	public X509ChainElement get_Current() { }

	// RVA: 0x12DA0BC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12DA174
	public bool MoveNext() { }

	// RVA: 0x12DA228
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl
{
	// Methods

	// RVA: -1
	public abstract bool get_IsValid() { }

	// RVA: 0x12DA2E0
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

	// RVA: 0x12D8570
	public void Dispose() { }

	// RVA: 0x12DA3B0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12DA3B4
	protected override void Finalize() { }

	// RVA: 0x12DA450
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

	// RVA: 0x12DA458
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12DA5A8
	public override bool get_IsValid() { }

	// RVA: 0x12DA5B0
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12DA5B8
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12DA5C0
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x12DA5C4
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12DB0E0
	public override void Reset() { }

	// RVA: 0x12DB2EC
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x12DB880
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x12DB4A8
	private X509Store get_LMRootStore() { }

	// RVA: 0x12DB640
	private X509Store get_UserRootStore() { }

	// RVA: 0x12DBA3C
	private X509Store get_LMCAStore() { }

	// RVA: 0x12DBBA8
	private X509Store get_UserCAStore() { }

	// RVA: 0x12DC2B4
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x12DACF0
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x12DC8D4
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x12DC6AC
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x12DC7D0
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x12DCCBC
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x12DAE90
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12DCD08
	private void Process(int n) { }

	// RVA: 0x12DD128
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x12DD6EC
	private void WrapUp() { }

	// RVA: 0x12DD9B8
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x12DD970
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x12DCC04
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12DCB60
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12DDF8C
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x12DDDF8
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x12DD45C
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12DE028
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x12DE200
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x12DEC70
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x12DE480
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x12DE948
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x12DE650
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0x12DEFD4
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

	// RVA: 0x12DA580
	public void .ctor() { }

	// RVA: 0x12DC3A8
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x12DF178
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x12DF180
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x12DF188
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x12DF190
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x12DF1FC
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x12DF204
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x12DF270
	public DateTime get_VerificationTime() { }

	// RVA: 0x12DF054
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private string info; // 0x18

	// Methods

	// RVA: 0x12DB0AC
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x12DF278
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x12DF280
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x12DF288
	public void set_StatusInformation(string value) { }

	// RVA: 0x12D8880
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x12DF290
	public void .ctor() { }

	// RVA: 0x12DF348
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x12DF6D8
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x12DF98C
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12DF43C
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12DF890
	internal Byte[] Encode() { }

	// RVA: 0x12DFB68
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension
{
	// Fields
	private bool _critical; // 0x20

	// Methods

	// RVA: 0x12DF340
	protected void .ctor() { }

	// RVA: 0x12DFF88
	public void .ctor(string oid, Byte[] rawData, bool critical) { }

	// RVA: 0x12DFFB4
	public bool get_Critical() { }

	// RVA: 0x12DFFBC
	public void set_Critical(bool value) { }

	// RVA: 0x12DFFC4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12DFE58
	internal string FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12E00F4
	public void .ctor() { }

	// RVA: 0x12D3CBC
	public int get_Count() { }

	// RVA: 0x12E016C
	public bool get_IsSynchronized() { }

	// RVA: 0x12E0194
	public object get_SyncRoot() { }

	// RVA: 0x12D237C
	public X509Extension get_Item(string oid) { }

	// RVA: 0x12E0198
	public int Add(X509Extension extension) { }

	// RVA: 0x12E0214
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12DDBAC
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x12E037C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12E0410
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12E032C
	internal void .ctor(ArrayList list) { }

	// RVA: 0x12DDC40
	public X509Extension get_Current() { }

	// RVA: 0x12E0490
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12DDD44
	public bool MoveNext() { }

	// RVA: 0x12E0548
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2
{
	// Methods

	// RVA: 0x12DD888
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x12D81F0
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x12E0600
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x12D80B8
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x12DA328
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

	// RVA: 0x12E0614
	public void .ctor() { }

	// RVA: 0x12E06C4
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x12E09E0
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x12D3CE4
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x12E0C74
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12E0ACC
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x12E07B8
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12E0ADC
	internal Byte[] Encode() { }

	// RVA: 0x12E0E50
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

	// RVA: 0x12DBD14
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x12DB7D8
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x12E13F4
	private X509Stores get_Factory() { }

	// RVA: 0x12E1410
	internal X509Store get_Store() { }

	// RVA: 0x12DB2A8
	public void Close() { }

	// RVA: 0x12E1418
	public void Dispose() { }

	// RVA: 0x12DBE50
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

	// RVA: 0x12E145C
	public void .ctor() { }

	// RVA: 0x12E150C
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x12E17C0
	public void .ctor(Byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12E1A94
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12E1E24
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x12D26FC
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x12D2B38
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x12E1E30
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12E200C
	internal static Byte FromHexChar(Char c) { }

	// RVA: 0x12E204C
	internal static Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0x12E1C7C
	internal static Byte[] FromHex(string hex) { }

	// RVA: 0x12E1600
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12E1A14
	internal Byte[] Encode() { }

	// RVA: 0x12E20E8
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Methods

	// RVA: 0x12E2368
	public void .ctor(Type type, string value) { }

	// RVA: 0x12E28AC
	public void .ctor(Char value) { }

	// RVA: 0x12E2930
	public void .ctor(Byte value) { }

	// RVA: 0x12E29B4
	public void .ctor(Int16 value) { }

	// RVA: 0x12E2A38
	public void .ctor(int value) { }

	// RVA: 0x12E2ABC
	public void .ctor(Int64 value) { }

	// RVA: 0x12E2B40
	public void .ctor(float value) { }

	// RVA: 0x12E2BCC
	public void .ctor(Double value) { }

	// RVA: 0x12E2C58
	public void .ctor(bool value) { }

	// RVA: 0x12E2CDC
	public void .ctor(string value) { }

	// RVA: 0x12E2D10
	public void .ctor(object value) { }

	// RVA: 0x12E2D44
	public void .ctor(SByte value) { }

	// RVA: 0x12E2DC8
	public void .ctor(UInt16 value) { }

	// RVA: 0x12E2E4C
	public void .ctor(UInt32 value) { }

	// RVA: 0x12E2ED0
	public void .ctor(UInt64 value) { }

	// RVA: 0x12E2F54
	public virtual object get_Value() { }

	// RVA: 0x12E2F5C
	public override bool Equals(object obj) { }

	// RVA: 0x12E3084
	public override int GetHashCode() { }

	// RVA: 0x12E308C
	protected void SetValue(object value) { }

	// RVA: 0x12E2684
	internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, object conversionResult) { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x12E3094
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x12E30C0
	public void .ctor() { }

	// RVA: 0x12E30E8
	public EditorBrowsableState get_State() { }

	// RVA: 0x12E30F0
	public override bool Equals(object obj) { }

	// RVA: 0x12E3194
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

	// RVA: 0x12E319C
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12E3208
	protected override void Finalize() { }

	// RVA: 0x12E32B0
	public object get_UserSuppliedState() { }

	// RVA: 0x12E32B8
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12E32C0
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x12E33B0
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x12E34B8
	public void OperationCompleted() { }

	// RVA: 0x12E32C8
	private void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x12E33D8
	private void OperationCompletedCore() { }

	// RVA: 0x12E3528
	private void VerifyNotCompleted() { }

	// RVA: 0x12E3590
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x12E3600
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12E36A8
	internal void .ctor() { }

}

// Namespace: System.ComponentModel
public static class AsyncOperationManager
{
	// Methods

	// RVA: 0x12E36E4
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x12E3764
	public static SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12E37F0
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

	// RVA: 0x12E37F8
	public void .ctor() { }

	// RVA: 0x12E38F8
	private void AsyncOperationCompleted(object arg) { }

	// RVA: 0x12E3998
	public bool get_CancellationPending() { }

	// RVA: 0x12E39A0
	public void CancelAsync() { }

	// RVA: 0x12E3A10
	public void add_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12E3AB4
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12E3B58
	public bool get_IsBusy() { }

	// RVA: 0x12E3B60
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x12E3B84
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x12E3BA8
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	// RVA: 0x12E3BCC
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12E3C70
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12E3D14
	private void ProgressReporter(object arg) { }

	// RVA: 0x12E3DB0
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x12E3DB8
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x12E3EB4
	public void RunWorkerAsync() { }

	// RVA: 0x12E3EBC
	public void RunWorkerAsync(object argument) { }

	// RVA: 0x12E4110
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12E41B4
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12E4258
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x12E4260
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x12E4268
	public bool get_WorkerSupportsCancellation() { }

	// RVA: 0x12E4270
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x12E4278
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x12E4410
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12E4414
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

	// RVA: 0x12E4418
	public void .ctor(bool browsable) { }

	// RVA: 0x12E4444
	public bool get_Browsable() { }

	// RVA: 0x12E444C
	public override bool Equals(object obj) { }

	// RVA: 0x12E4618
	public override int GetHashCode() { }

	// RVA: 0x12E4690
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E4704
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection
{
	// Methods

	// RVA: 0x12E47B8
	public void .ctor(IComponent[] components) { }

	// RVA: 0x12E4804
	public virtual IComponent get_Item(string name) { }

	// RVA: 0x12E4D6C
	public virtual IComponent get_Item(int index) { }

	// RVA: 0x12E4E08
	public void CopyTo(IComponent[] array, int index) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string <DescriptionValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E4E4C
	public void .ctor() { }

	// RVA: 0x12E4EBC
	public void .ctor(string description) { }

	// RVA: 0x12E4EF0
	public virtual string get_Description() { }

	// RVA: 0x12E4EF8
	protected string get_DescriptionValue() { }

	// RVA: 0x12E4F00
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x12E4F08
	public override bool Equals(object obj) { }

	// RVA: 0x12E4FE4
	public override int GetHashCode() { }

	// RVA: 0x12E5010
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E5084
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

	// RVA: 0x12E5140
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x12E516C
	public bool get_IsDesignOnly() { }

	// RVA: 0x12E5174
	public override bool Equals(object obj) { }

	// RVA: 0x12E5340
	public override int GetHashCode() { }

	// RVA: 0x12E53B8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E5460
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

	// RVA: 0x12E5514
	public void .ctor() { }

	// RVA: 0x12E5580
	public void .ctor(string category) { }

	// RVA: 0x12E55B4
	public string get_Category() { }

	// RVA: 0x12E55BC
	public override bool Equals(object obj) { }

	// RVA: 0x12E565C
	public override int GetHashCode() { }

	// RVA: 0x12E5680
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E5724
	public override object get_TypeId() { }

	// RVA: 0x12E5768
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

	// RVA: 0x12E5918
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x12E5944
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x12E594C
	public override bool Equals(object obj) { }

	// RVA: 0x12E5B08
	public override int GetHashCode() { }

	// RVA: 0x12E5B10
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E5B84
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E5C68
	public void .ctor() { }

	// RVA: 0x12E5CD8
	public void .ctor(string displayName) { }

	// RVA: 0x12E5D0C
	public virtual string get_DisplayName() { }

	// RVA: 0x12E5D14
	protected string get_DisplayNameValue() { }

	// RVA: 0x12E5D1C
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x12E5D24
	public override bool Equals(object obj) { }

	// RVA: 0x12E5E00
	public override int GetHashCode() { }

	// RVA: 0x12E5E2C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E5EA0
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

	// RVA: 0x12E6114
	public void .ctor(object key, Delegate handler, ListEntry next) { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList
{
	// Fields
	private ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Methods

	// RVA: 0x12E5F5C
	internal void .ctor(Component parent) { }

	// RVA: 0x12E5F90
	public void .ctor() { }

	// RVA: 0x12E5F98
	public Delegate get_Item(object key) { }

	// RVA: 0x12E602C
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x12E6178
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0x12E6274
	public void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x12E62B4
	public void Dispose() { }

	// RVA: 0x12E6014
	private ListEntry Find(object key) { }

	// RVA: 0x12E62C0
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

	// RVA: 0x12E631C
	public void .ctor(bool immutable) { }

	// RVA: 0x12E6348
	public bool get_Immutable() { }

	// RVA: 0x12E6350
	public override bool Equals(object obj) { }

	// RVA: 0x12E651C
	public override int GetHashCode() { }

	// RVA: 0x12E6524
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E6598
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class InitializationEventAttribute
{
	// Fields
	private readonly string <EventName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E664C
	public void .ctor(string eventName) { }

	// RVA: 0x12E6680
	public string get_EventName() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException
{
	// Methods

	// RVA: 0x12E6688
	public void .ctor() { }

	// RVA: 0x12E6694
	public void .ctor(string message) { }

	// RVA: 0x12E669C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12E66A4
	public void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x12E6790
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

	// RVA: 0x12E6798
	public void .ctor(bool isLocalizable) { }

	// RVA: 0x12E67C4
	public bool get_IsLocalizable() { }

	// RVA: 0x12E67CC
	public override bool Equals(object obj) { }

	// RVA: 0x12E6998
	public override int GetHashCode() { }

	// RVA: 0x12E69A0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E6A48
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

	// RVA: 0x12E6AFC
	public void .ctor(bool allowMerge) { }

	// RVA: 0x12E6B28
	public bool get_AllowMerge() { }

	// RVA: 0x12E6B30
	public override bool Equals(object obj) { }

	// RVA: 0x12E6CFC
	public override int GetHashCode() { }

	// RVA: 0x12E6D04
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E6D78
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

	// RVA: 0x12E6E2C
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x12E6E58
	public bool get_IsReadOnly() { }

	// RVA: 0x12E6E60
	public override bool Equals(object value) { }

	// RVA: 0x12E702C
	public override int GetHashCode() { }

	// RVA: 0x12E7034
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E70DC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AddingNewEventArgs
{
	// Fields
	private object <NewObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E7190
	public void .ctor() { }

	// RVA: 0x12E7218
	public void .ctor(object newObject) { }

	// RVA: 0x12E7290
	public object get_NewObject() { }

	// RVA: 0x12E7298
	public void set_NewObject(object value) { }

}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler
{
	// Methods

	// RVA: 0x12E72A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E73C4
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x12E73D8
	public virtual IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E7434
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute
{
	// Fields
	private readonly object <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E7440
	public void .ctor(Type type, string value) { }

	// RVA: 0x12E7578
	public void .ctor(Char value) { }

	// RVA: 0x12E75FC
	public void .ctor(Byte value) { }

	// RVA: 0x12E7680
	public void .ctor(Int16 value) { }

	// RVA: 0x12E7704
	public void .ctor(int value) { }

	// RVA: 0x12E7788
	public void .ctor(Int64 value) { }

	// RVA: 0x12E780C
	public void .ctor(float value) { }

	// RVA: 0x12E7898
	public void .ctor(Double value) { }

	// RVA: 0x12E7924
	public void .ctor(bool value) { }

	// RVA: 0x12E79A8
	public void .ctor(string value) { }

	// RVA: 0x12E79DC
	public void .ctor(object value) { }

	// RVA: 0x12E7A10
	public object get_Value() { }

	// RVA: 0x12E7A18
	public override bool Equals(object obj) { }

	// RVA: 0x12E7AD8
	public override int GetHashCode() { }

}

// Namespace: 
private class ArrayPropertyDescriptor
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x12E7FD0
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x12E80A0
	public override object GetValue(object instance) { }

	// RVA: 0x12E8158
	public override void SetValue(object instance, object value) { }

}

// Namespace: System.ComponentModel
public class ArrayConverter
{
	// Methods

	// RVA: 0x12E7AE0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12E7CD4
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12E8090
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12E8098
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

	// RVA: 0x12E825C
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x12E83E8
	protected void .ctor() { }

	// RVA: 0x12E83F0
	public static AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x12E88A8
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x12E8814
	public int get_Count() { }

	// RVA: 0x12E88B0
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x12E88F8
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x12E96A4
	public bool Contains(Attribute attribute) { }

	// RVA: 0x12E9708
	public bool Contains(Attribute[] attributes) { }

	// RVA: 0x12E9098
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x12E97A8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12E97D0
	public bool Matches(Attribute attribute) { }

	// RVA: 0x12E9880
	public bool Matches(Attribute[] attributes) { }

	// RVA: 0x12E98F8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12E9900
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12E9908
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12E9930
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12E883C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12E9958
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12E9A08
	public void .ctor(string typeName) { }

	// RVA: 0x12E9A88
	public void .ctor(string typeName, string propertyName) { }

	// RVA: 0x12E9B48
	public void .ctor(Type type) { }

	// RVA: 0x12E9C64
	public string get_TypeName() { }

	// RVA: 0x12E9C6C
	public string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public abstract class ComponentEditor
{
	// Methods

	// RVA: 0x12E9C74
	public bool EditComponent(object component) { }

	// RVA: -1
	public abstract bool EditComponent(ITypeDescriptorContext context, object component) { }

	// RVA: 0x12E9C88
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter
{
	// Methods

	// RVA: 0x12E9C90
	internal void .ctor() { }

	// RVA: 0x12E9C98
	internal virtual bool get_AllowHex() { }

	// RVA: -1
	internal abstract Type get_TargetType() { }

	// RVA: -1
	internal abstract object FromString(string value, int radix) { }

	// RVA: -1
	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: -1
	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E9CA0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E9D6C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12EA188
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EA488
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

	// RVA: 0x12EA4D0
	public void .ctor(bool bindable) { }

	// RVA: 0x12EA500
	public void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x12EA53C
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12EA580
	public void .ctor(BindableSupport flags, BindingDirection direction) { }

	// RVA: 0x12EA5D0
	public bool get_Bindable() { }

	// RVA: 0x12EA5D8
	public BindingDirection get_Direction() { }

	// RVA: 0x12EA5E0
	public override bool Equals(object obj) { }

	// RVA: 0x12EA690
	public override int GetHashCode() { }

	// RVA: 0x12EA708
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12EA7A4
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IList<T> list) { }

	// RVA: 0x30D488C
	private void Initialize() { }

	// RVA: 0x30D3738
	private bool get_ItemTypeHasDefaultConstructor() { }

	// RVA: 0x30D4CD4
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30D4CD4
	public void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30D4CD4
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x30D3CF0
	private object FireAddingNew() { }

	// RVA: 0x30D4CD4
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30D4CD4
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30D4CD4
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x30D3738
	public bool get_RaiseListChangedEvents() { }

	// RVA: 0x30D4918
	public void set_RaiseListChangedEvents(bool value) { }

	// RVA: 0x30D488C
	public void ResetBindings() { }

	// RVA: 0x30D4A04
	public void ResetItem(int position) { }

	// RVA: 0x30D4A74
	private void FireListChanged(ListChangedType type, int index) { }

	// RVA: 0x30D488C
	protected override void ClearItems() { }

	// RVA: 0x318DB98
	protected override void InsertItem(int index, T item) { }

	// RVA: 0x30D4A04
	protected override void RemoveItem(int index) { }

	// RVA: 0x318DB98
	protected override void SetItem(int index, T item) { }

	// RVA: 0x30D4A04
	public virtual void CancelNew(int itemIndex) { }

	// RVA: 0x30D4A04
	public virtual void EndNew(int itemIndex) { }

	// RVA: 0x318DB98
	public T AddNew() { }

	// RVA: 0x30D3CF0
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x30D3738
	private bool get_AddingNewHandled() { }

	// RVA: 0x30D3CF0
	protected virtual object AddNewCore() { }

	// RVA: 0x30D3738
	public bool get_AllowNew() { }

	// RVA: 0x30D4918
	public void set_AllowNew(bool value) { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x30D3738
	public bool get_AllowEdit() { }

	// RVA: 0x30D4918
	public void set_AllowEdit(bool value) { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x30D3738
	public bool get_AllowRemove() { }

	// RVA: 0x30D4918
	public void set_AllowRemove(bool value) { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x30D3738
	protected virtual bool get_SupportsChangeNotificationCore() { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x30D3738
	protected virtual bool get_SupportsSearchingCore() { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x30D3738
	protected virtual bool get_SupportsSortingCore() { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x30D3738
	protected virtual bool get_IsSortedCore() { }

	// RVA: 0x30D3CF0
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x30D3CF0
	protected virtual PropertyDescriptor get_SortPropertyCore() { }

	// RVA: 0x30D39B8
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x30D39B8
	protected virtual ListSortDirection get_SortDirectionCore() { }

	// RVA: 0x30D4D3C
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30D4D3C
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30D488C
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x30D488C
	protected virtual void RemoveSortCore() { }

	// RVA: -1
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }

	// RVA: -1
	protected virtual int FindCore(PropertyDescriptor prop, object key) { }

	// RVA: 0x30D4CD4
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }

	// RVA: 0x30D4CD4
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }

	// RVA: 0x318DB98
	private void HookPropertyChanged(T item) { }

	// RVA: 0x318DB98
	private void UnhookPropertyChanged(T item) { }

	// RVA: 0x30D4F34
	private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x30D3738
	private bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter
{
	// Fields
	private static StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x12EA860
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12EA92C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12EAB2C
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12EACD8
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12EACE0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12EACE8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter
{
	// Methods

	// RVA: 0x12EACF0
	internal override Type get_TargetType() { }

	// RVA: 0x12EAD90
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12EAE2C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12EAEA8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12EAF60
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler
{
	// Methods

	// RVA: 0x12EAF68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12EB08C
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x12EB0A0
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12EB0FC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CharConverter
{
	// Methods

	// RVA: 0x12EB108
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12EB1D4
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EB308
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12EB49C
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

	// RVA: 0x12EB4A4
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x12EB52C
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x12EB534
	public virtual object get_Element() { }

}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler
{
	// Methods

	// RVA: 0x12EB53C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12EB660
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x12EB674
	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12EB6D0
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

	// RVA: 0x12EB6DC
	public void .ctor() { }

	// RVA: 0x12EB6E4
	public void .ctor(string dataSource) { }

	// RVA: 0x12EB718
	public void .ctor(string dataSource, string dataMember) { }

	// RVA: 0x12EB768
	public string get_DataSource() { }

	// RVA: 0x12EB770
	public string get_DataMember() { }

	// RVA: 0x12EB778
	public override bool Equals(object obj) { }

	// RVA: 0x12EB810
	public override int GetHashCode() { }

	// RVA: 0x12EB818
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentResourceManager
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Methods

	// RVA: 0x12EB884
	public void .ctor() { }

	// RVA: 0x12EB90C
	public void .ctor(Type t) { }

	// RVA: 0x12EB978
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x12EBA20
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x12EBA30
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x12EC8F0
	private System.Collections.Generic.SortedList<System.String,System.Object> FillResources(CultureInfo culture, ResourceSet resourceSet) { }

}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService
{
	// Methods

	// RVA: 0x12ECE98
	protected void .ctor() { }

	// RVA: 0x12ECEA0
	public virtual ComponentCollection FilterComponents(ComponentCollection components) { }

}

// Namespace: 
private class CultureComparer
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x12EE240
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x12EE28C
	public int Compare(object item1, object item2) { }

}

// Namespace: 
private static class CultureInfoMapper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x12EE400
	private static System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }

	// RVA: 0x12EDA68
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x12F24E4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class CultureInfoConverter
{
	// Fields
	private StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Methods

	// RVA: 0x12ECEA8
	private string get_DefaultCultureString() { }

	// RVA: 0x12ECEEC
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x12ECF14
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12ECFE0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12ED0AC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12EDB30
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EDFF0
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12EE274
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12EE27C
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12EE284
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x12F2540
	protected void .ctor() { }

	// RVA: 0x12F2548
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x12F257C
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x12F267C
	public virtual string GetClassName() { }

	// RVA: 0x12F2740
	public virtual string GetComponentName() { }

	// RVA: 0x12F2804
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x12F28F0
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x12F29B4
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x12F2A78
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x12F2B40
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x12F2C44
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x12F2D50
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x12F2E54
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x12F2F60
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

	// RVA: 0x12F3028
	public void .ctor() { }

	// RVA: 0x12F3054
	public void .ctor(bool isDataObject) { }

	// RVA: 0x12F3080
	public bool get_IsDataObject() { }

	// RVA: 0x12F3088
	public override bool Equals(object obj) { }

	// RVA: 0x12F3138
	public override int GetHashCode() { }

	// RVA: 0x12F31B0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F3224
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

	// RVA: 0x12F32D8
	public void .ctor(bool primaryKey) { }

	// RVA: 0x12F3364
	public void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x12F33AC
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x12F3310
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	// RVA: 0x12F33F8
	public bool get_IsIdentity() { }

	// RVA: 0x12F3400
	public bool get_IsNullable() { }

	// RVA: 0x12F3408
	public int get_Length() { }

	// RVA: 0x12F3410
	public bool get_PrimaryKey() { }

	// RVA: 0x12F3418
	public override bool Equals(object obj) { }

	// RVA: 0x12F3518
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectMethodAttribute
{
	// Fields
	private readonly bool <IsDefault>k__BackingField; // 0x10
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Methods

	// RVA: 0x12F3520
	public void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x12F3550
	public void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	// RVA: 0x12F358C
	public bool get_IsDefault() { }

	// RVA: 0x12F3594
	public DataObjectMethodType get_MethodType() { }

	// RVA: 0x12F359C
	public override bool Equals(object obj) { }

	// RVA: 0x12F365C
	public override int GetHashCode() { }

	// RVA: 0x12F36F0
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

	// RVA: 0x12F3794
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F3860
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F392C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F3C78
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F40BC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DecimalConverter
{
	// Methods

	// RVA: 0x12F40C4
	internal override bool get_AllowHex() { }

	// RVA: 0x12F40CC
	internal override Type get_TargetType() { }

	// RVA: 0x12F416C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F4238
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F459C
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F4690
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F4748
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F483C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultBindingPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12F4844
	public void .ctor() { }

	// RVA: 0x12F484C
	public void .ctor(string name) { }

	// RVA: 0x12F4880
	public string get_Name() { }

	// RVA: 0x12F4888
	public override bool Equals(object obj) { }

	// RVA: 0x12F490C
	public override int GetHashCode() { }

	// RVA: 0x12F4914
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Methods

	// RVA: 0x12F4980
	public void .ctor(string name) { }

	// RVA: 0x12F49B4
	public string get_Name() { }

	// RVA: 0x12F49BC
	public override bool Equals(object obj) { }

	// RVA: 0x12F4A40
	public override int GetHashCode() { }

	// RVA: 0x12F4A48
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12F4AC4
	public void .ctor(string name) { }

	// RVA: 0x12F4AF8
	public string get_Name() { }

	// RVA: 0x12F4B00
	public override bool Equals(object obj) { }

	// RVA: 0x12F4B84
	public override int GetHashCode() { }

	// RVA: 0x12F4B8C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider
{
	// Fields
	private readonly Type _type; // 0x20

	// Methods

	// RVA: 0x12F4C08
	internal void .ctor(Type type) { }

	// RVA: 0x12F4C44
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x12F4CD4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12F4DA0
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x12F4E44
	public override string GetFullComponentName(object component) { }

	// RVA: 0x12F4EE8
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12F4F8C
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12F5030
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12F50E4
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x12F5188
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12F523C
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

	// RVA: 0x12F52E0
	public void .ctor() { }

	// RVA: 0x12F5388
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	// RVA: 0x12F53B4
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x12F53BC
	public override bool Equals(object value) { }

	// RVA: 0x12F5460
	public override int GetHashCode() { }

	// RVA: 0x12F5468
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F54DC
	public override string ToString() { }

	// RVA: 0x12F55DC
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

	// RVA: 0x12F56C4
	public void .ctor() { }

	// RVA: 0x12F5858
	public void .ctor(Type tabClass) { }

	// RVA: 0x12F59F0
	public void .ctor(string tabClassName) { }

	// RVA: 0x12F5860
	public void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x12F59F8
	public void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x12F5B64
	public Type[] get_TabClasses() { }

	// RVA: 0x12F5EC4
	protected string[] get_TabClassNames() { }

	// RVA: 0x12F5F3C
	public PropertyTabScope[] get_TabScopes() { }

	// RVA: 0x12F5F44
	private void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x12F5F4C
	public override bool Equals(object other) { }

	// RVA: 0x12F5FE8
	public bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x12F61A0
	public override int GetHashCode() { }

	// RVA: 0x12F61A8
	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12F64F0
	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12F61B4
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

	// RVA: 0x12F6500
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F6574
	public void .ctor(bool defaultType) { }

	// RVA: 0x12F65F0
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x12F66AC
	public void .ctor(Type toolboxItemType) { }

	// RVA: 0x12F670C
	public Type get_ToolboxItemType() { }

	// RVA: 0x12F68EC
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x12F6958
	public override bool Equals(object obj) { }

	// RVA: 0x12F6A88
	public override int GetHashCode() { }

	// RVA: 0x12F6AAC
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

	// RVA: 0x12F6B80
	public void .ctor(bool visible) { }

	// RVA: 0x12F6BAC
	public void .ctor() { }

	// RVA: 0x12F6BB4
	public bool get_Visible() { }

	// RVA: 0x12F6BBC
	public override bool Equals(object obj) { }

	// RVA: 0x12F6C6C
	public override int GetHashCode() { }

	// RVA: 0x12F6D2C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F6DD4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter
{
	// Methods

	// RVA: 0x12F6E88
	internal override bool get_AllowHex() { }

	// RVA: 0x12F6E90
	internal override Type get_TargetType() { }

	// RVA: 0x12F6F30
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F6FF8
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F7074
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F712C
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

	// RVA: 0x12F7134
	public void .ctor() { }

	// RVA: 0x12F71B8
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x12F7290
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x12F7384
	public void .ctor(Type type, Type baseType) { }

	// RVA: 0x12F7408
	public string get_EditorBaseTypeName() { }

	// RVA: 0x12F7410
	public string get_EditorTypeName() { }

	// RVA: 0x12F7418
	public override object get_TypeId() { }

	// RVA: 0x12F74D4
	public override bool Equals(object obj) { }

	// RVA: 0x12F759C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor
{
	// Methods

	// RVA: 0x12F75A4
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12F75AC
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12F75B4
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

	// RVA: 0x12F8488
	public void .ctor(Array array, int count) { }

	// RVA: 0x12F8D68
	public bool MoveNext() { }

	// RVA: 0x12F8D8C
	public void Reset() { }

	// RVA: 0x12F8D98
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

	// RVA: 0x12F75BC
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x12F76EC
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x12F7714
	private void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12F7834
	public int get_Count() { }

	// RVA: 0x12F783C
	private void set_Count(int value) { }

	// RVA: 0x12F7844
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x12F7994
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x12F79A8
	public int Add(EventDescriptor value) { }

	// RVA: 0x12F7B9C
	public void Clear() { }

	// RVA: 0x12F7BF4
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x12F7CC8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12F78CC
	private void EnsureEventsOwned() { }

	// RVA: 0x12F7A7C
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12F8030
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12F7C64
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x12F8158
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x12F824C
	public void Remove(EventDescriptor value) { }

	// RVA: 0x12F8310
	public void RemoveAt(int index) { }

	// RVA: 0x12F83D8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12F84D4
	public virtual EventDescriptorCollection Sort() { }

	// RVA: 0x12F8558
	public virtual EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12F85E0
	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12F8668
	public virtual EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12F7D10
	protected void InternalSort(string[] names) { }

	// RVA: 0x12F86EC
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x12F878C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12F8794
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12F879C
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12F87A4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12F87A8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12F87B8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12F893C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12F89CC
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12F8A9C
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12F8AF4
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12F8BB8
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12F8C50
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12F8CE0
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12F8CE4
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12F8CEC
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12F8CF4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter
{
	// Methods

	// RVA: 0x12F8E00
	public void .ctor() { }

	// RVA: 0x12F8E08
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12F8E74
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Methods

	// RVA: 0x12F8E7C
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x12F910C
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x12F9254
	public override bool CanResetValue(object comp) { }

	// RVA: 0x12F9280
	public override Type get_ComponentType() { }

	// RVA: 0x12F92A8
	public override bool get_IsReadOnly() { }

	// RVA: 0x12F939C
	public override Type get_PropertyType() { }

	// RVA: 0x12F93C4
	public override string get_DisplayName() { }

	// RVA: 0x12F95BC
	public override object GetValue(object comp) { }

	// RVA: 0x12F95E8
	public override void ResetValue(object comp) { }

	// RVA: 0x12F9614
	public override void SetValue(object component, object value) { }

	// RVA: 0x12F9644
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

	// RVA: 0x12F9060
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x12F9670
	public void .ctor() { }

	// RVA: 0x12F9678
	public PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0x12F9680
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	// RVA: 0x12F9688
	public IExtenderProvider get_Provider() { }

	// RVA: 0x12F9690
	private void set_Provider(IExtenderProvider value) { }

	// RVA: 0x12F9698
	public Type get_ReceiverType() { }

	// RVA: 0x12F96A0
	private void set_ReceiverType(Type value) { }

	// RVA: 0x12F96A8
	public override bool Equals(object obj) { }

	// RVA: 0x12F97A4
	public override int GetHashCode() { }

	// RVA: 0x12F97AC
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter
{
	// Methods

	// RVA: 0x12F9818
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F98E4
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F99B0
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F9AA0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F9E04
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class HandledEventArgs
{
	// Fields
	private bool <Handled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12F9E0C
	public void .ctor() { }

	// RVA: 0x12F9E78
	public void .ctor(bool defaultHandledValue) { }

	// RVA: 0x12F9EE8
	public bool get_Handled() { }

	// RVA: 0x12F9EF0
	public void set_Handled(bool value) { }

}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler
{
	// Methods

	// RVA: 0x12F9EF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12FA01C
	public virtual void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x12FA030
	public virtual IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12FA08C
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

	// RVA: 0x12FA098
	public void .ctor(Type installerType) { }

	// RVA: 0x12FA0E8
	public void .ctor(string typeName) { }

	// RVA: 0x12FA11C
	public virtual Type get_InstallerType() { }

	// RVA: 0x12FA1B0
	public override bool Equals(object obj) { }

	// RVA: 0x12FA26C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor
{
	// Methods

	// RVA: 0x12FA274
	public virtual string get_Text() { }

	// RVA: -1
	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType) { }

	// RVA: 0x12FA2B8
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int16Converter
{
	// Methods

	// RVA: 0x12FA2C0
	internal override Type get_TargetType() { }

	// RVA: 0x12FA360
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12FA3FC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FA478
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FA530
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter
{
	// Methods

	// RVA: 0x12FA538
	internal override Type get_TargetType() { }

	// RVA: 0x12FA5D8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12FA674
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FA6F0
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FA7A8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter
{
	// Methods

	// RVA: 0x12FA7B0
	internal override Type get_TargetType() { }

	// RVA: 0x12FA850
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12FA8EC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FA968
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12FAA20
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidAsynchronousStateException
{
	// Methods

	// RVA: 0x12FAA28
	public void .ctor() { }

	// RVA: 0x12FAA34
	public void .ctor(string message) { }

	// RVA: 0x12FAA3C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12FAA44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private class LicFileLicense
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12FAFB4
	public void .ctor(LicFileLicenseProvider owner, string key) { }

	// RVA: 0x12FB01C
	public override string get_LicenseKey() { }

	// RVA: 0x12FB024
	public override void Dispose() { }

}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider
{
	// Methods

	// RVA: 0x12FAA4C
	protected virtual bool IsKeyValid(string key, Type type) { }

	// RVA: 0x12FAA94
	protected virtual string GetKey(Type type) { }

	// RVA: 0x12FAB54
	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12FB004
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

	// RVA: 0x12FB014
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class LicenseContext
{
	// Methods

	// RVA: 0x12FB0AC
	public virtual LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12FB0B4
	public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x12FB0BC
	public virtual object GetService(Type type) { }

	// RVA: 0x12FB0C4
	public virtual void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x12FB0C8
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

	// RVA: 0x12FB0D0
	private void .ctor() { }

	// RVA: 0x12FB0D8
	public static LicenseContext get_CurrentContext() { }

	// RVA: 0x12FB2C8
	public static void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x12FB468
	public static LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12FB52C
	private static void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x12FB754
	public static object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x12FB854
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x12FBCC0
	private static bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x12FBD9C
	private static LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x12FBE9C
	private static LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x12FBF9C
	public static bool IsLicensed(Type type) { }

	// RVA: 0x12FC138
	public static bool IsValid(Type type) { }

	// RVA: 0x12FC23C
	public static bool IsValid(Type type, object instance, License license) { }

	// RVA: 0x12FBB30
	public static void LockContext(object contextUser) { }

	// RVA: 0x12FC32C
	public static void UnlockContext(object contextUser) { }

	// RVA: 0x12FC0A0
	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, License license) { }

	// RVA: 0x12FC4C0
	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, License license, string licenseKey) { }

	// RVA: 0x12FC9AC
	public static void Validate(Type type) { }

	// RVA: 0x12FCAE4
	public static License Validate(Type type, object instance) { }

	// RVA: 0x12FCC14
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class LicenseProvider
{
	// Methods

	// RVA: -1
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12FB00C
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

	// RVA: 0x12FCCC4
	public void .ctor() { }

	// RVA: 0x12FCCF4
	public void .ctor(string typeName) { }

	// RVA: 0x12FCD28
	public void .ctor(Type type) { }

	// RVA: 0x12FC894
	public Type get_LicenseProvider() { }

	// RVA: 0x12FCD5C
	public override object get_TypeId() { }

	// RVA: 0x12FCE38
	public override bool Equals(object value) { }

	// RVA: 0x12FCF7C
	public override int GetHashCode() { }

	// RVA: 0x12FCF84
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

	// RVA: 0x12FD000
	public void .ctor(bool listBindable) { }

	// RVA: 0x12FD02C
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12FD06C
	public bool get_ListBindable() { }

	// RVA: 0x12FD074
	public override bool Equals(object obj) { }

	// RVA: 0x12FD124
	public override int GetHashCode() { }

	// RVA: 0x12FD12C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12FD1C8
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

	// RVA: 0x12FD27C
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x12FD384
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x12FD420
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x12FD300
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x12FD4A8
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x12FD4B0
	public int get_NewIndex() { }

	// RVA: 0x12FD4B8
	public int get_OldIndex() { }

	// RVA: 0x12FD4C0
	public PropertyDescriptor get_PropertyDescriptor() { }

}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler
{
	// Methods

	// RVA: 0x12FD4C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12FD5EC
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x12FD600
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12FD65C
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

	// RVA: 0x12FD668
	public void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x12FD6B0
	public PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x12FD6B8
	public void set_PropertyDescriptor(PropertyDescriptor value) { }

	// RVA: 0x12FD6C0
	public ListSortDirection get_SortDirection() { }

	// RVA: 0x12FD6C8
	public void set_SortDirection(ListSortDirection value) { }

}

// Namespace: System.ComponentModel
public class ListSortDescriptionCollection
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Methods

	// RVA: 0x12FD6D0
	public void .ctor() { }

	// RVA: 0x12FD748
	public void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x12FD814
	public ListSortDescription get_Item(int index) { }

	// RVA: 0x12FD8B8
	public void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x12FD90C
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12FD914
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12FD91C
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12FD9C0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12FDA14
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12FDA68
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12FDABC
	public bool Contains(object value) { }

	// RVA: 0x12FDB74
	public int IndexOf(object value) { }

	// RVA: 0x12FDC2C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12FDC80
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12FDCD4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12FDD28
	public int get_Count() { }

	// RVA: 0x12FDD50
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12FDD58
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12FDD5C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12FDD84
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

	// RVA: 0x12FDDAC
	public void .ctor() { }

	// RVA: 0x12FDE0C
	public void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	// RVA: 0x12FDE8C
	public string get_DataSource() { }

	// RVA: 0x12FDE94
	public string get_DisplayMember() { }

	// RVA: 0x12FDE9C
	public string get_ValueMember() { }

	// RVA: 0x12FDEA4
	public string get_LookupMember() { }

	// RVA: 0x12FDEAC
	public override bool Equals(object obj) { }

	// RVA: 0x12FDF6C
	public override int GetHashCode() { }

	// RVA: 0x12FDF74
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

	// RVA: 0x12FE020
	public void .ctor() { }

	// RVA: 0x12FE028
	protected override void Finalize() { }

	// RVA: 0x12FE0C4
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x12FE250
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x12FE1C4
	protected EventHandlerList get_Events() { }

	// RVA: 0x12FE350
	public virtual ISite get_Site() { }

	// RVA: 0x12FE358
	public virtual void set_Site(ISite value) { }

	// RVA: 0x12FE360
	public void Dispose() { }

	// RVA: 0x12FE3F0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12FE69C
	public virtual IContainer get_Container() { }

	// RVA: 0x12FE760
	public virtual object GetService(Type service) { }

	// RVA: 0x12FE824
	public virtual bool get_DesignMode() { }

	// RVA: 0x12FE8E8
	public override string ToString() { }

	// RVA: 0x12FEA28
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

	// RVA: 0x12FF4CC
	public void .ctor(int maskPos, CharType charType) { }

	// RVA: 0x1305368
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

	// RVA: 0x12FEAB0
	public void .ctor(string mask) { }

	// RVA: 0x12FEF08
	public void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x12FEF20
	public void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x12FEF34
	public void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x12FEF48
	public void .ctor(string mask, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12FEF5C
	public void .ctor(string mask, CultureInfo culture, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12FEAC8
	public void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, Char promptChar, Char passwordChar, bool restrictToAscii) { }

	// RVA: 0x12FF074
	private void Initialize() { }

	// RVA: 0x12FF530
	public bool get_AllowPromptAsInput() { }

	// RVA: 0x12FF5A4
	public int get_AssignedEditPositionCount() { }

	// RVA: 0x12FF5AC
	private void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x12FF5B4
	public int get_AvailableEditPositionCount() { }

	// RVA: 0x12FF5D4
	public object Clone() { }

	// RVA: 0x130046C
	public CultureInfo get_Culture() { }

	// RVA: 0x1300474
	public static Char get_DefaultPasswordChar() { }

	// RVA: 0x12FF5C8
	public int get_EditPositionCount() { }

	// RVA: 0x130047C
	public IEnumerator get_EditPositions() { }

	// RVA: 0x130028C
	public bool get_IncludeLiterals() { }

	// RVA: 0x1300300
	public void set_IncludeLiterals(bool value) { }

	// RVA: 0x130037C
	public bool get_IncludePrompt() { }

	// RVA: 0x13003F0
	public void set_IncludePrompt(bool value) { }

	// RVA: 0x12FFF1C
	public bool get_AsciiOnly() { }

	// RVA: 0x1300780
	public bool get_IsPassword() { }

	// RVA: 0x1300790
	public void set_IsPassword(bool value) { }

	// RVA: 0x130084C
	public static int get_InvalidIndex() { }

	// RVA: 0x1300854
	public int get_LastAssignedPosition() { }

	// RVA: 0x13009AC
	public int get_Length() { }

	// RVA: 0x13009CC
	public string get_Mask() { }

	// RVA: 0x13009D4
	public bool get_MaskCompleted() { }

	// RVA: 0x13009E4
	public bool get_MaskFull() { }

	// RVA: 0x13009FC
	public Char get_PasswordChar() { }

	// RVA: 0x1300A04
	public void set_PasswordChar(Char value) { }

	// RVA: 0x1300BE4
	public Char get_PromptChar() { }

	// RVA: 0x1300BEC
	public void set_PromptChar(Char value) { }

	// RVA: 0x1300130
	public bool get_ResetOnPrompt() { }

	// RVA: 0x12FFF90
	public void set_ResetOnPrompt(bool value) { }

	// RVA: 0x13001A4
	public bool get_ResetOnSpace() { }

	// RVA: 0x130000C
	public void set_ResetOnSpace(bool value) { }

	// RVA: 0x1300218
	public bool get_SkipLiterals() { }

	// RVA: 0x1300088
	public void set_SkipLiterals(bool value) { }

	// RVA: 0x1300E88
	public Char get_Item(int index) { }

	// RVA: 0x1300F48
	public bool Add(Char input) { }

	// RVA: 0x1300F70
	public bool Add(Char input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x130122C
	public bool Add(string input) { }

	// RVA: 0x1301258
	public bool Add(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1301378
	public void Clear() { }

	// RVA: 0x13013D4
	public void Clear(MaskedTextResultHint resultHint) { }

	// RVA: 0x1300924
	public int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1301514
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x1301110
	public int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x13016CC
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x130152C
	private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, Byte assignedStatus) { }

	// RVA: 0x1301824
	public int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x1301888
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x13016D4
	private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags) { }

	// RVA: 0x1301890
	public int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x13018F4
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x1301A80
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x1301A8C
	public bool InsertAt(Char input, int position) { }

	// RVA: 0x1301B84
	public bool InsertAt(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1301B58
	public bool InsertAt(string input, int position) { }

	// RVA: 0x1301C24
	public bool InsertAt(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1301D08
	private bool InsertAtInt(string input, int position, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x1302AA8
	private static bool IsAscii(Char c) { }

	// RVA: 0x1302AB8
	private static bool IsAciiAlphanumeric(Char c) { }

	// RVA: 0x1302AE4
	private static bool IsAlphanumeric(Char c) { }

	// RVA: 0x1302BB0
	private static bool IsAsciiLetter(Char c) { }

	// RVA: 0x1302BC4
	public bool IsAvailablePosition(int position) { }

	// RVA: 0x1300DA4
	public bool IsEditPosition(int position) { }

	// RVA: 0x12FF508
	private static bool IsEditPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x1302CB4
	private static bool IsLiteralPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12FEF70
	private static bool IsPrintableChar(Char c) { }

	// RVA: 0x1302CDC
	public static bool IsValidInputChar(Char c) { }

	// RVA: 0x1302D5C
	public static bool IsValidMaskChar(Char c) { }

	// RVA: 0x1300B78
	public static bool IsValidPasswordChar(Char c) { }

	// RVA: 0x1302DDC
	public bool Remove() { }

	// RVA: 0x1302E14
	public bool Remove(int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1302E78
	public bool RemoveAt(int position) { }

	// RVA: 0x1302EE8
	public bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x1302F80
	public bool RemoveAt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1303028
	private bool RemoveAtInt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x1300104
	public bool Replace(Char input, int position) { }

	// RVA: 0x1303650
	public bool Replace(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x130388C
	public bool Replace(Char input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1303DC0
	public bool Replace(string input, int position) { }

	// RVA: 0x1303DEC
	public bool Replace(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1303A1C
	public bool Replace(string input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1301440
	private void ResetChar(int testPosition) { }

	// RVA: 0x1303420
	private void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x1303F34
	public bool Set(string input) { }

	// RVA: 0x1303F60
	public bool Set(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x13028CC
	private void SetChar(Char input, int position) { }

	// RVA: 0x1304158
	private void SetChar(Char input, int position, CharDescriptor charDescriptor) { }

	// RVA: 0x1302958
	private void SetString(string input, int testPosition) { }

	// RVA: 0x1302308
	private bool TestChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x1303800
	private bool TestEscapeChar(Char input, int position) { }

	// RVA: 0x1304350
	private bool TestEscapeChar(Char input, int position, CharDescriptor charDex) { }

	// RVA: 0x1301174
	private bool TestSetChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x130132C
	private bool TestSetString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x130212C
	private bool TestString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x1304530
	public string ToDisplayString() { }

	// RVA: 0x1304768
	public override string ToString() { }

	// RVA: 0x1304D20
	public string ToString(bool ignorePasswordChar) { }

	// RVA: 0x1304E20
	public string ToString(int startPosition, int length) { }

	// RVA: 0x1304F14
	public string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x130500C
	public string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x1305064
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x1304864
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x130507C
	public bool VerifyChar(Char input, int position, MaskedTextResultHint hint) { }

	// RVA: 0x1305100
	public bool VerifyEscapeChar(Char input, int position) { }

	// RVA: 0x13051C0
	public bool VerifyString(string input) { }

	// RVA: 0x130520C
	public bool VerifyString(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x130523C
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

	// RVA: 0x13055C0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1305770
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1305778
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1305780
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

	// RVA: 0x1305C7C
	internal void .ctor(IComponent component, NestedContainer container, string name) { }

	// RVA: 0x1305EBC
	public IComponent get_Component() { }

	// RVA: 0x1305EC4
	public IContainer get_Container() { }

	// RVA: 0x1305ECC
	public object GetService(Type service) { }

	// RVA: 0x1305FE0
	public bool get_DesignMode() { }

	// RVA: 0x13061DC
	public string get_FullName() { }

	// RVA: 0x13062E0
	public string get_Name() { }

	// RVA: 0x13062E8
	public void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class NestedContainer
{
	// Fields
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Methods

	// RVA: 0x1305788
	public void .ctor(IComponent owner) { }

	// RVA: 0x13058F8
	public IComponent get_Owner() { }

	// RVA: 0x1305900
	protected virtual string get_OwnerName() { }

	// RVA: 0x1305B94
	protected override ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x1305CE0
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1305DF0
	protected override object GetService(Type service) { }

	// RVA: 0x1305EB4
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

	// RVA: 0x13063C0
	public void .ctor(Type type) { }

	// RVA: 0x1306510
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x130660C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1306780
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x130687C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1306AB8
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x1306ADC
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1306B00
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1306B24
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1306B48
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1306F00
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1306F28
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1306F50
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1306F84
	public Type get_NullableType() { }

	// RVA: 0x1306F8C
	public Type get_UnderlyingType() { }

	// RVA: 0x1306F94
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

	// RVA: 0x1306F9C
	public void .ctor() { }

	// RVA: 0x1306FC4
	public void .ctor(bool password) { }

	// RVA: 0x1306FF0
	public bool get_Password() { }

	// RVA: 0x1306FF8
	public override bool Equals(object o) { }

	// RVA: 0x130708C
	public override int GetHashCode() { }

	// RVA: 0x1307094
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1307108
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

	// RVA: 0x13071BC
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x13071C4
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12F9058
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: 0x13071CC
	public virtual TypeConverter get_Converter() { }

	// RVA: 0x13078D8
	public virtual bool get_IsLocalizable() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x13079CC
	public DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: -1
	public abstract Type get_PropertyType() { }

	// RVA: 0x1307AAC
	public virtual void AddValueChanged(object component, EventHandler handler) { }

	// RVA: -1
	public abstract bool CanResetValue(object component) { }

	// RVA: 0x1307C14
	public override bool Equals(object obj) { }

	// RVA: 0x1307690
	protected object CreateInstance(Type type) { }

	// RVA: 0x1307E28
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x1307E84
	public PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x1307E9C
	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x1307EB4
	public PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x1307EC8
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x1307F80
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x1308398
	public override int GetHashCode() { }

	// RVA: 0x13083F0
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x130746C
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1
	public abstract object GetValue(object component) { }

	// RVA: 0x13084E8
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x130859C
	public virtual void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x1308714
	protected internal EventHandler GetValueChangedHandler(object component) { }

	// RVA: -1
	public abstract void ResetValue(object component) { }

	// RVA: -1
	public abstract void SetValue(object component, object value) { }

	// RVA: -1
	public abstract bool ShouldSerializeValue(object component) { }

	// RVA: 0x13087B0
	public virtual bool get_SupportsChangeEvents() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x130A108
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x130AEC8
	public object get_Current() { }

	// RVA: 0x130AF74
	public DictionaryEntry get_Entry() { }

	// RVA: 0x130AFE8
	public object get_Key() { }

	// RVA: 0x130B028
	public object get_Value() { }

	// RVA: 0x130B068
	public bool MoveNext() { }

	// RVA: 0x130B0A8
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

	// RVA: 0x13087B8
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x130890C
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x1308934
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x1308A8C
	public int get_Count() { }

	// RVA: 0x1308A94
	private void set_Count(int value) { }

	// RVA: 0x1308A9C
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x1308BEC
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x1308C00
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x1308DF4
	public void Clear() { }

	// RVA: 0x1308E54
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x1308F28
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1308B24
	private void EnsurePropsOwned() { }

	// RVA: 0x1308CD4
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x1309290
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x1308EC4
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x1309864
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x1309958
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x1309A1C
	public void RemoveAt(int index) { }

	// RVA: 0x1309AE4
	public virtual PropertyDescriptorCollection Sort() { }

	// RVA: 0x1309B68
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x1309BF0
	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x1309C78
	public virtual PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x1308F70
	protected void InternalSort(string[] names) { }

	// RVA: 0x1309CFC
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x1309D9C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1309E38
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1309E40
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1309E48
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1309E50
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1309EB0
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x1309F10
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1309F20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1309F24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x1309FF4
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x130A08C
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x130A144
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x130A14C
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x130A154
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x130A1E0
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x130A5D4
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x130A6E4
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x130A7E8
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x130A8EC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x130A97C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x130AA4C
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x130AB10
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x130ABA8
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x130ABB0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x130ABB8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x130AC48
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x130AC58
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x130AE54
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute
{
	// Fields
	private readonly string <PropertyName>k__BackingField; // 0x10
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x130B0B4
	public void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x130B120
	public void .ctor(string propertyName, string receiverTypeName) { }

	// RVA: 0x130B170
	public string get_PropertyName() { }

	// RVA: 0x130B178
	public string get_ReceiverTypeName() { }

	// RVA: 0x130B180
	public override bool Equals(object obj) { }

	// RVA: 0x130B248
	public override int GetHashCode() { }

	// RVA: 0x130B298
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

	// RVA: 0x130B2DC
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x130B308
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x130B310
	public override bool Equals(object obj) { }

	// RVA: 0x130B3DC
	public override int GetHashCode() { }

	// RVA: 0x130B3E4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x130B3F4
	private static void .cctor() { }

}

// Namespace: 
private class ReferenceComparer
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x130C57C
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x130C640
	public int Compare(object item1, object item2) { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x130B4A8
	public void .ctor(Type type) { }

	// RVA: 0x130B4DC
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x130B5AC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x130B940
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x130BE30
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x130C5B0
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x130C5B8
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x130C5C0
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x130C5C8
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

	// RVA: 0x130C6F4
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x130C8A8
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x130CA60
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x130CB5C
	public override Type get_ComponentType() { }

	// RVA: 0x130CB64
	public override Type get_EventType() { }

	// RVA: 0x130D0E0
	public override bool get_IsMulticast() { }

	// RVA: 0x130D194
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x130D940
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x130D9C0
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x130CB88
	private void FillMethods() { }

	// RVA: 0x130DD38
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x130E0F0
	public override void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs
{
	// Fields
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Methods

	// RVA: 0x130E7EC
	public void .ctor(object componentChanged) { }

	// RVA: 0x130E888
	public void .ctor(Type typeChanged) { }

	// RVA: 0x130E900
	public object get_ComponentChanged() { }

	// RVA: 0x130E908
	public Type get_TypeChanged() { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler
{
	// Methods

	// RVA: 0x130E910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x130EA30
	public virtual void Invoke(RefreshEventArgs e) { }

	// RVA: 0x130EA44
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x130EA94
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

	// RVA: 0x130EAA0
	public void .ctor(bool runInstaller) { }

	// RVA: 0x130EACC
	public bool get_RunInstaller() { }

	// RVA: 0x130EAD4
	public override bool Equals(object obj) { }

	// RVA: 0x130EBA0
	public override int GetHashCode() { }

	// RVA: 0x130EBA8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x130EC1C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SByteConverter
{
	// Methods

	// RVA: 0x130ECD0
	internal override Type get_TargetType() { }

	// RVA: 0x130ED70
	internal override object FromString(string value, int radix) { }

	// RVA: 0x130EE0C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x130EE88
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x130EF40
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

	// RVA: 0x130EF48
	public void .ctor(bool bindable) { }

	// RVA: 0x130EF74
	public bool get_Bindable() { }

	// RVA: 0x130EF7C
	public override bool Equals(object obj) { }

	// RVA: 0x130F02C
	public override int GetHashCode() { }

	// RVA: 0x130F0A4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter
{
	// Methods

	// RVA: 0x130F144
	internal override bool get_AllowHex() { }

	// RVA: 0x130F14C
	internal override Type get_TargetType() { }

	// RVA: 0x130F1EC
	internal override object FromString(string value, int radix) { }

	// RVA: 0x130F2B4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x130F330
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x130F3E8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter
{
	// Methods

	// RVA: 0x130F3F0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x130F4BC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x130F564
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public static class SyntaxCheck
{
	// Methods

	// RVA: 0x130F56C
	public static bool CheckMachineName(string value) { }

	// RVA: 0x130F60C
	public static bool CheckPath(string value) { }

	// RVA: 0x130F6B4
	public static bool CheckRootedPath(string value) { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter
{
	// Methods

	// RVA: 0x130F77C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x130F848
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x130F914
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x130FB18
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x130FE58
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

	// RVA: 0x130FE60
	public void .ctor(string filterString) { }

	// RVA: 0x130FEFC
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	// RVA: 0x130FF9C
	public string get_FilterString() { }

	// RVA: 0x130FFA4
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x130FFAC
	public override object get_TypeId() { }

	// RVA: 0x1310034
	public override bool Equals(object obj) { }

	// RVA: 0x1310158
	public override int GetHashCode() { }

	// RVA: 0x131017C
	public override bool Match(object obj) { }

	// RVA: 0x1310208
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

	// RVA: 0x1310328
	public void .ctor() { }

	// RVA: 0x1310394
	public void .ctor(Type type) { }

	// RVA: 0x13103E4
	public void .ctor(string typeName) { }

	// RVA: 0x1310418
	public string get_ConverterTypeName() { }

	// RVA: 0x1310420
	public override bool Equals(object obj) { }

	// RVA: 0x13104A4
	public override int GetHashCode() { }

	// RVA: 0x13104C8
	private static void .cctor() { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor
{
	// Methods

	// RVA: 0x1310794
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x12F4C3C
	protected void .ctor() { }

	// RVA: 0x1310580
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x13105B4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x13106C4
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x13106DC
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x131079C
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x13108F8
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x1310A7C
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x1310A8C
	public Type GetReflectionType(object instance) { }

	// RVA: 0x1310B18
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1310B34
	public virtual Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x1310CC0
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x13109F0
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x1310CD0
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1310D90
	public virtual bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1310E94
	public void .ctor(string typeName) { }

	// RVA: 0x1310F14
	public void .ctor(Type type) { }

	// RVA: 0x1311030
	public string get_TypeName() { }

}

// Namespace: System.ComponentModel
public abstract class TypeListConverter
{
	// Fields
	private readonly Type[] _types; // 0x10
	private StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x1311038
	protected void .ctor(Type[] types) { }

	// RVA: 0x131106C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1311138
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1311204
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1311318
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x13114FC
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x13115E0
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x13115E8
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
public class UInt16Converter
{
	// Methods

	// RVA: 0x13115F0
	internal override Type get_TargetType() { }

	// RVA: 0x1311690
	internal override object FromString(string value, int radix) { }

	// RVA: 0x131172C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x13117A8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1311860
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter
{
	// Methods

	// RVA: 0x1311868
	internal override Type get_TargetType() { }

	// RVA: 0x1311908
	internal override object FromString(string value, int radix) { }

	// RVA: 0x13119A4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1311A20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1311AD8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter
{
	// Methods

	// RVA: 0x1311AE0
	internal override Type get_TargetType() { }

	// RVA: 0x1311B80
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1311C1C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1311C98
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1311D50
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

	// RVA: 0x1311D58
	public void .ctor() { }

	// RVA: 0x1311DEC
	public void .ctor(string message) { }

	// RVA: 0x1311E2C
	public void .ctor(string message, string helpUrl) { }

	// RVA: 0x1311E70
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1311D9C
	public void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x1311E78
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1312020
	public string get_HelpUrl() { }

	// RVA: 0x1312028
	public string get_HelpTopic() { }

	// RVA: 0x1312030
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public class CancelEventArgs
{
	// Fields
	private bool <Cancel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13120E8
	public bool get_Cancel() { }

	// RVA: 0x13120F0
	public void set_Cancel(bool value) { }

	// RVA: 0x13120F8
	public void .ctor() { }

	// RVA: 0x1312180
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

	// RVA: 0x13121F0
	public void .ctor(string propertyName) { }

	// RVA: 0x1312268
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

	// RVA: 0x1312270
	public void .ctor(string propertyName) { }

	// RVA: 0x13122E8
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler
{
	// Methods

	// RVA: 0x13122F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1312414
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x1312428
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1312484
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1312490
	public void .ctor(string propertyName) { }

	// RVA: 0x1312508
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler
{
	// Methods

	// RVA: 0x1312510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1312634
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x1312648
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x13126A4
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

	// RVA: 0x13126B0
	public void .ctor(Array array, int count) { }

	// RVA: 0x13126FC
	public bool MoveNext() { }

	// RVA: 0x1312720
	public void Reset() { }

	// RVA: 0x131272C
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

	// RVA: 0x1312794
	public void .ctor() { }

	// RVA: 0x131281C
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x13128B8
	public bool get_Cancelled() { }

	// RVA: 0x13128C0
	public Exception get_Error() { }

	// RVA: 0x13128C8
	public object get_UserState() { }

	// RVA: 0x13128D0
	protected void RaiseExceptionIfNecessary() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler
{
	// Methods

	// RVA: 0x13129B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1312AD4
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x1312AE8
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1312B44
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

	// RVA: 0x1312B50
	public static CategoryAttribute get_Action() { }

	// RVA: 0x1312C54
	public static CategoryAttribute get_Appearance() { }

	// RVA: 0x1312D24
	public static CategoryAttribute get_Asynchronous() { }

	// RVA: 0x1312DEC
	public static CategoryAttribute get_Behavior() { }

	// RVA: 0x1312EB4
	public static CategoryAttribute get_Data() { }

	// RVA: 0x1312F7C
	public static CategoryAttribute get_Default() { }

	// RVA: 0x13130CC
	public static CategoryAttribute get_Design() { }

	// RVA: 0x1313194
	public static CategoryAttribute get_DragDrop() { }

	// RVA: 0x131325C
	public static CategoryAttribute get_Focus() { }

	// RVA: 0x1313324
	public static CategoryAttribute get_Format() { }

	// RVA: 0x13133EC
	public static CategoryAttribute get_Key() { }

	// RVA: 0x13134B4
	public static CategoryAttribute get_Layout() { }

	// RVA: 0x131357C
	public static CategoryAttribute get_Mouse() { }

	// RVA: 0x1313644
	public static CategoryAttribute get_WindowStyle() { }

	// RVA: 0x131305C
	public void .ctor() { }

	// RVA: 0x1312C18
	public void .ctor(string category) { }

	// RVA: 0x131370C
	public string get_Category() { }

	// RVA: 0x1313778
	public override bool Equals(object obj) { }

	// RVA: 0x13138E8
	public override int GetHashCode() { }

	// RVA: 0x1313954
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x1313CA8
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CollectionConverter
{
	// Methods

	// RVA: 0x1313D68
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x131416C
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1314174
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x131417C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
internal static class CompModSwitches
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Methods

	// RVA: 0x131418C
	public static BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x131426C
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

	// RVA: 0x1314344
	protected override void Finalize() { }

	// RVA: 0x13143E4
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x13143EC
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x13143F8
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x13145B0
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x1314510
	protected EventHandlerList get_Events() { }

	// RVA: 0x13146C8
	public virtual ISite get_Site() { }

	// RVA: 0x13146D0
	public virtual void set_Site(ISite value) { }

	// RVA: 0x13146D8
	public void Dispose() { }

	// RVA: 0x131476C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1314A98
	public IContainer get_Container() { }

	// RVA: 0x1314B5C
	protected virtual object GetService(Type service) { }

	// RVA: 0x1314C20
	protected bool get_DesignMode() { }

	// RVA: 0x1314CE4
	public override string ToString() { }

	// RVA: 0x1314E24
	public void .ctor() { }

	// RVA: 0x1314E2C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentConverter
{
	// Methods

	// RVA: 0x1314EB4
	public void .ctor(Type type) { }

	// RVA: 0x1314F20
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x13150F8
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

	// RVA: 0x1315708
	internal void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x1316944
	public IComponent get_Component() { }

	// RVA: 0x131694C
	public IContainer get_Container() { }

	// RVA: 0x1316954
	public object GetService(Type service) { }

	// RVA: 0x1316A28
	public bool get_DesignMode() { }

	// RVA: 0x1316A30
	public string get_Name() { }

	// RVA: 0x1316A38
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

	// RVA: 0x1315100
	protected override void Finalize() { }

	// RVA: 0x131519C
	public virtual void Add(IComponent component) { }

	// RVA: 0x13151AC
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x1315664
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x131576C
	public void Dispose() { }

	// RVA: 0x13157FC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1315B4C
	protected virtual object GetService(Type service) { }

	// RVA: 0x1315BF0
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x131608C
	public virtual void Remove(IComponent component) { }

	// RVA: 0x1316094
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x13163AC
	protected void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x13163B4
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x13168CC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter
{
	// Methods

	// RVA: 0x1316AB0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1316C44
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1316DD8
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1317234
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1317EC0
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

	// RVA: 0x1317EC8
	public void .ctor(string designerTypeName) { }

	// RVA: 0x1317FF4
	public void .ctor(Type designerType) { }

	// RVA: 0x13180D0
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x13181A8
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x131829C
	public void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x1318320
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x1318328
	public string get_DesignerTypeName() { }

	// RVA: 0x1318330
	public override object get_TypeId() { }

	// RVA: 0x13183EC
	public override bool Equals(object obj) { }

	// RVA: 0x13184B4
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public class DoWorkEventArgs
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Methods

	// RVA: 0x1318504
	public void .ctor(object argument) { }

	// RVA: 0x1318538
	public object get_Argument() { }

	// RVA: 0x1318540
	public object get_Result() { }

	// RVA: 0x1318548
	public void set_Result(object value) { }

}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler
{
	// Methods

	// RVA: 0x1318550
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1318674
	public virtual void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x1318688
	public virtual IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x13186E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class EnumConverter
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x13186F0
	public void .ctor(Type type) { }

	// RVA: 0x1318724
	protected Type get_EnumType() { }

	// RVA: 0x131872C
	protected StandardValuesCollection get_Values() { }

	// RVA: 0x1318734
	protected void set_Values(StandardValuesCollection value) { }

	// RVA: 0x131873C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x131888C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x13189DC
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x1318A58
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1318FD0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1319EB4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x131A4F4
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x131A5C0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x131A5C8
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

	// RVA: 0x131A638
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

	// RVA: 0x131A6C0
	public void .ctor(Type type) { }

	// RVA: 0x131A850
	public void .ctor(Type type, object instance) { }

	// RVA: 0x131A7EC
	public void .ctor(Type type, object instance, string message) { }

	// RVA: 0x131A9DC
	public void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x131AA44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131ABF0
	public Type get_LicensedType() { }

	// RVA: 0x131ABF8
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

	// RVA: 0x131ACF4
	protected void .ctor(string name) { }

	// RVA: 0x131ACFC
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x131AEE8
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x131B040
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x131B49C
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x131BD20
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x131BE20
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x131BF34
	public virtual string get_Category() { }

	// RVA: 0x131C09C
	public virtual string get_Description() { }

	// RVA: 0x131C1CC
	public virtual bool get_IsBrowsable() { }

	// RVA: 0x131C2AC
	public virtual string get_Name() { }

	// RVA: 0x131C308
	protected virtual int get_NameHashCode() { }

	// RVA: 0x131C310
	public virtual bool get_DesignTimeOnly() { }

	// RVA: 0x131C404
	public virtual string get_DisplayName() { }

	// RVA: 0x131B4C8
	private void CheckAttributesValid() { }

	// RVA: 0x131C52C
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x131C5A8
	public override bool Equals(object obj) { }

	// RVA: 0x131C830
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x131B5BC
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x131C928
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x131C9A4
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x131CA6C
	public override int GetHashCode() { }

	// RVA: 0x131CA74
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x131D208
	protected static ISite GetSite(object component) { }

	// RVA: 0x131D328
	protected static object GetInvokee(Type componentClass, object component) { }

}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Methods

	// RVA: 0x131D46C
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x131D4F4
	public int get_ProgressPercentage() { }

	// RVA: 0x131D4FC
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler
{
	// Methods

	// RVA: 0x131D504
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x131D628
	public virtual void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x131D63C
	public virtual IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x131D698
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

	// RVA: 0x131D6A4
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x131D994
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x131DAF0
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x131DBE8
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x131E0A8
	private object get_AmbientValue() { }

	// RVA: 0x131E264
	private EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x131E5D0
	private EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x131E7D4
	private void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x131E860
	public override Type get_ComponentType() { }

	// RVA: 0x131E868
	private object get_DefaultValue() { }

	// RVA: 0x131EB58
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x131F060
	private bool get_IsExtender() { }

	// RVA: 0x131F0CC
	public override bool get_IsReadOnly() { }

	// RVA: 0x131F7FC
	public override Type get_PropertyType() { }

	// RVA: 0x131F804
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x131F1E0
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x131FACC
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x131FD94
	public override void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x131FF4C
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x13203A4
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x13203AC
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x1320258
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x13203BC
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x13208DC
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1320D90
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x132126C
	public override bool CanResetValue(object component) { }

	// RVA: 0x132158C
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x1322710
	public override object GetValue(object component) { }

	// RVA: 0x1322A4C
	internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x1322B54
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x1322C38
	public override void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x1322DF4
	public override void ResetValue(object component) { }

	// RVA: 0x1323268
	public override void SetValue(object component, object value) { }

	// RVA: 0x1323878
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1323C00
	public override bool get_SupportsChangeEvents() { }

	// RVA: 0x1323C44
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

	// RVA: 0x132AEF8
	internal void .ctor(Type type) { }

	// RVA: 0x132AAD0
	internal bool get_IsPopulated() { }

	// RVA: 0x13252F0
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x1325C3C
	internal string GetClassName(object instance) { }

	// RVA: 0x1325C94
	internal string GetComponentName(object instance) { }

	// RVA: 0x1325EB0
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x1326424
	internal EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x13266D0
	internal PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x13269D4
	internal object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x132D5F0
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x1327578
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0x132AB0C
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x132D114
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x132C364
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

	// RVA: 0x1323EA8
	internal static Guid get_ExtenderProviderKey() { }

	// RVA: 0x1323F24
	internal void .ctor() { }

	// RVA: 0x1323F2C
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x13249E4
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x1324CB8
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1324EF0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x1325028
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x132583C
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1325C08
	internal string GetClassName(Type type) { }

	// RVA: 0x1325C64
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x1325E80
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x13263F4
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x13266A0
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x132699C
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x13270C4
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x1327558
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x132795C
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x13279D8
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x1327A30
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x1327A7C
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x1327AC8
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x1327AD0
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x1327AD8
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x1327B34
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x1327BB0
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x13291E4
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x13296A4
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x132A248
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x132A374
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x132A37C
	public override string GetFullComponentName(object component) { }

	// RVA: 0x132A5F8
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x132AAEC
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x132A2E8
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x132AEF0
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1325048
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x132AF2C
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x132AF34
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x132B050
	internal bool IsPopulated(Type type) { }

	// RVA: 0x132B084
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x1322270
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x132B524
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x1328218
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x132BC54
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x132C2DC
	internal void Refresh(Type type) { }

	// RVA: 0x132C3E0
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x132CDD8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs
{
	// Fields
	private object result; // 0x28

	// Methods

	// RVA: 0x132D990
	public void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x132DA3C
	public object get_Result() { }

	// RVA: 0x132DA60
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler
{
	// Methods

	// RVA: 0x132DA68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x132DB8C
	public virtual void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x132DBA0
	public virtual IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x132DBFC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Methods

	// RVA: 0x132E8DC
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x132E978
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x132E9D0
	public override Type get_ComponentType() { }

	// RVA: 0x132E9D8
	public override bool get_IsReadOnly() { }

	// RVA: 0x132EA64
	public override Type get_PropertyType() { }

	// RVA: 0x132EA6C
	public override bool CanResetValue(object component) { }

	// RVA: 0x132EBBC
	public override void ResetValue(object component) { }

	// RVA: 0x132ECF4
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public class StandardValuesCollection
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Methods

	// RVA: 0x131A424
	public void .ctor(ICollection values) { }

	// RVA: 0x132ECFC
	public int get_Count() { }

	// RVA: 0x132EDCC
	public object get_Item(int index) { }

	// RVA: 0x132EFD8
	public void CopyTo(Array array, int index) { }

	// RVA: 0x132F094
	public IEnumerator GetEnumerator() { }

	// RVA: 0x132F148
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x132F14C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x132F154
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x132F15C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x132F218
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public class TypeConverter
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x132DC08
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x132DC5C
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1316BB8
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x132DC70
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1316D4C
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x132DC84
	public object ConvertFrom(object value) { }

	// RVA: 0x13171BC
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x132DE38
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x132DEC4
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x132DF50
	public object ConvertFromString(string text) { }

	// RVA: 0x132DF68
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x132DEB8
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x132DFF4
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1313F00
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x132E18C
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1319E30
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x132E2EC
	public string ConvertToString(object value) { }

	// RVA: 0x132E3F4
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x132E204
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x132E500
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x132E514
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x132DD04
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x132E010
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x132E51C
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x132E52C
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x132E534
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x132E540
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x132E63C
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x132E644
	public bool GetPropertiesSupported() { }

	// RVA: 0x132E654
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x132E65C
	public ICollection GetStandardValues() { }

	// RVA: 0x132E66C
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x132E674
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x132E688
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x132E690
	public bool GetStandardValuesSupported() { }

	// RVA: 0x132E6A4
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x132E6AC
	public bool IsValid(object value) { }

	// RVA: 0x132E6C4
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x132E898
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x1314184
	public void .ctor() { }

}

// Namespace: 
private class AttributeTypeDescriptor
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x133CA20
	internal void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x133CA58
	public override AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class AttributeProvider
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x133C948
	internal void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x133C97C
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x133CF24
	internal void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x133CF74
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x133D034
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x133D0F8
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x133D100
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x133D1C4
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x133D288
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x133D34C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x133D40C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x133D4D0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x133D590
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x133D644
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x133D704
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Methods

	// RVA: 0x133CD1C
	internal void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x133CD50
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x133CD58
	internal void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x133CD60
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x133D70C
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x133D75C
	internal bool IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x133D7D4
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x133D824
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

	// RVA: 0x133D834
	public int Compare(object left, object right) { }

	// RVA: 0x133D958
	public void .ctor() { }

	// RVA: 0x133D960
	private static void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x133D9CC
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x133DA1C
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x133DB5C
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x133DCA4
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x133DDEC
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x133DF34
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x133E07C
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x133E1C4
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x133E3A8
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x133E4F0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x133E634
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x133E77C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x133E8C0
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x133ED34
	internal void .ctor(TypeDescriptionNode node, object instance) { }

	// RVA: 0x133F360
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x133F674
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x133F8BC
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x133FAD8
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x133FD88
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x133FFA4
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x13401C0
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1340480
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1340798
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1340ACC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1340D7C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1341044
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

	// RVA: 0x133F21C
	internal void .ctor(TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x1341290
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1341540
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1341780
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x134199C
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1341C4C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1341E68
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1342084
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1342344
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x13425F8
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x13428C4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1342B78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1342E44
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class TypeDescriptionNode
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x133EA04
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x133EA38
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x133EBDC
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x133EC54
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x133ED68
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x133EDE0
	public override string GetFullComponentName(object component) { }

	// RVA: 0x133EE58
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x133EF5C
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x133F050
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x133F26C
	public override bool IsSupportedType(Type type) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject
{
	// Methods

	// RVA: 0x1343090
	public void .ctor() { }

}

// Namespace: 
private sealed class TypeDescriptorInterface
{
	// Methods

	// RVA: 0x1343098
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

	// RVA: 0x132F2CC
	private void .ctor() { }

	// RVA: 0x132F2D4
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x132F558
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x132F430
	public static Type get_ComObjectType() { }

	// RVA: 0x132FA2C
	public static Type get_InterfaceType() { }

	// RVA: 0x132FACC
	internal static int get_MetadataVersion() { }

	// RVA: 0x132FB48
	public static void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x132FC38
	public static void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x132FD28
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0x132FFB4
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	// RVA: 0x1330440
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x132F780
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x133018C
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1331B54
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1331C78
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1331D68
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x13323C8
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x1332B70
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x1333088
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1333110
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x1333190
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x13334EC
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1333570
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x133374C
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x1333750
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x1333754
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0x1333758
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x133375C
	private static void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0x1333760
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x1333764
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0x1333768
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x133376C
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0x1333770
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1333774
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0x131CBB8
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x13220D4
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x1316844
	public static AttributeCollection GetAttributes(object component) { }

	// RVA: 0x1333DBC
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1328138
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x13378DC
	public static string GetClassName(object component) { }

	// RVA: 0x1337964
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1337A78
	public static string GetClassName(Type componentType) { }

	// RVA: 0x132A570
	public static string GetComponentName(object component) { }

	// RVA: 0x1337BA4
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1337CB8
	public static TypeConverter GetConverter(object component) { }

	// RVA: 0x1337D40
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1337E54
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1337F80
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x1338064
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x13381D8
	public static EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x1338260
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1338370
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x13384E4
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x133856C
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1333C58
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x13341D4
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1334448
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x133867C
	public static object GetEditor(object component, Type editorBaseType) { }

	// RVA: 0x13386E8
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x133887C
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x131E42C
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x1338A18
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x132D320
	public static EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x1339178
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x13391E4
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x1338CAC
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x13398FC
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x1339C54
	public static string GetFullComponentName(object component) { }

	// RVA: 0x1339D10
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x132D44C
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x1339F18
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x132D388
	public static PropertyDescriptorCollection GetProperties(object component) { }

	// RVA: 0x133A1AC
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1315030
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x133A8D0
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x133A21C
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x132FE98
	public static TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0x13300D0
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x133A94C
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0x131A2B4
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x133A9D4
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x132F4D0
	private static TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x13304CC
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x1337854
	private static TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1331044
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x133AAF0
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x1339250
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x13357D0
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x1337048
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x1334568
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x133AED8
	private static void RaiseRefresh(object component) { }

	// RVA: 0x133AFB0
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x133B088
	public static void Refresh(object component) { }

	// RVA: 0x1331294
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x13309F8
	public static void Refresh(Type type) { }

	// RVA: 0x133B110
	public static void Refresh(Module module) { }

	// RVA: 0x133BB84
	public static void Refresh(Assembly assembly) { }

	// RVA: 0x133BC50
	public static void RemoveAssociation(object primary, object secondary) { }

	// RVA: 0x133C010
	public static void RemoveAssociations(object primary) { }

	// RVA: 0x133C0F4
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x133C208
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x133C2E8
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x133C40C
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1333BC4
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x133C4FC
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x133C5D0
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x133C5D4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Methods

	// RVA: 0x13430A0
	public void .ctor() { }

	// RVA: 0x1343120
	public void .ctor(int error) { }

	// RVA: 0x1343F50
	public void .ctor(int error, string message) { }

	// RVA: 0x1343F80
	public void .ctor(string message) { }

	// RVA: 0x1344000
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x134408C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1344120
	public int get_NativeErrorCode() { }

	// RVA: 0x1344128
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x134315C
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

	// RVA: 0x13441FC
	public void .ctor(bool notifyParent) { }

	// RVA: 0x1344228
	public bool get_NotifyParent() { }

	// RVA: 0x1344230
	public override bool Equals(object obj) { }

	// RVA: 0x13442D4
	public override int GetHashCode() { }

	// RVA: 0x13442DC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1344350
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ParenthesizePropertyNameAttribute
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Methods

	// RVA: 0x1344404
	public void .ctor() { }

	// RVA: 0x134442C
	public void .ctor(bool needParenthesis) { }

	// RVA: 0x1344458
	public bool get_NeedParenthesis() { }

	// RVA: 0x1344460
	public override bool Equals(object o) { }

	// RVA: 0x13444E8
	public override int GetHashCode() { }

	// RVA: 0x13444F0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1344564
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

	// RVA: 0x13445D4
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x1344600
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x1344608
	public override bool Equals(object value) { }

	// RVA: 0x1344690
	public override int GetHashCode() { }

	// RVA: 0x1344698
	public override bool IsDefaultAttribute() { }

	// RVA: 0x134470C
	private static void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer
{
	// Methods

	// RVA: 0x1345050
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x13451C8
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x1345048
	public void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x1344F7C
	internal void .ctor(object o) { }

	// RVA: 0x13451F0
	public override bool Equals(object o) { }

	// RVA: 0x1345280
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

	// RVA: 0x13447DC
	internal void .ctor() { }

	// RVA: 0x134484C
	public override void Clear() { }

	// RVA: 0x1344854
	public override void Remove(object key) { }

	// RVA: 0x134485C
	public void SetWeak(object key, object value) { }

	// RVA: 0x134490C
	private void ScavengeKeys() { }

	// RVA: 0x1344FC0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute
{
	// Methods

	// RVA: 0x1345288
	public void .ctor(string category) { }

}

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x1345290
	public void .ctor() { }

	// RVA: 0x1345298
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x13452A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13452A8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x134533C
	private string GetLocalPath(string fileName) { }

	// RVA: 0x13453D0
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x1345938
	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x1345D54
	public void .ctor() { }

	// RVA: 0x1345D5C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer
{
	// Methods

	// RVA: 0x1345B1C
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

	// RVA: 0x1346660
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x1346768
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x134678C
	public override Type get_ComponentType() { }

	// RVA: 0x13467B4
	public override bool get_IsReadOnly() { }

	// RVA: 0x13467DC
	public override Type get_PropertyType() { }

	// RVA: 0x1346804
	public override bool CanResetValue(object component) { }

	// RVA: 0x1346834
	public override object GetValue(object component) { }

	// RVA: 0x1346864
	public override void ResetValue(object component) { }

	// RVA: 0x1346894
	public override void SetValue(object component, object value) { }

	// RVA: 0x13468C4
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

	// RVA: 0x1345E20
	public int get_Count() { }

	// RVA: 0x1345EFC
	public string get_Name() { }

	// RVA: 0x1345F04
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x13466D4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1345E58
	private void EnsurePopulated() { }

	// RVA: 0x1346724
	public IEnumerator GetEnumerator() { }

	// RVA: 0x134675C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1346764
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
private class OptionPropertyDescriptor
{
	// Fields
	private DesignerOptionCollection _option; // 0x88

	// Methods

	// RVA: 0x1346EC8
	internal void .ctor(DesignerOptionCollection option) { }

	// RVA: 0x1347014
	public override Type get_ComponentType() { }

	// RVA: 0x1347034
	public override bool get_IsReadOnly() { }

	// RVA: 0x134703C
	public override Type get_PropertyType() { }

	// RVA: 0x134705C
	public override bool CanResetValue(object component) { }

	// RVA: 0x1347064
	public override object GetValue(object component) { }

	// RVA: 0x134706C
	public override void ResetValue(object component) { }

	// RVA: 0x1347070
	public override void SetValue(object component, object value) { }

	// RVA: 0x1347074
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
internal sealed class DesignerOptionConverter
{
	// Methods

	// RVA: 0x13468F4
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x13468FC
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x1346F0C
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x134700C
	public void .ctor() { }

}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService
{
	// Methods

	// RVA: 0x1345E1C
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

	// RVA: 0x134707C
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x1347084
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	// RVA: 0x1347610
	public ICollection get_Arguments() { }

	// RVA: 0x1347618
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x1347620
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

	// RVA: 0x13479A0
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x13479FC
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x1347A04
	public override object get_TypeId() { }

}

// Namespace: System.Collections
internal static class HashtableExtensions
{
	// Methods

	// RVA: 0x30D6280
	public static bool TryGetValue(Hashtable table, object key, T value) { }

}

// Namespace: System.Collections.Specialized
public struct BitVector32
{
	// Fields
	private UInt32 _data; // 0x10

	// Methods

	// RVA: 0x1347AC0
	public void .ctor(int data) { }

	// RVA: 0x1347AC8
	public bool get_Item(int bit) { }

	// RVA: 0x1347AD8
	public void set_Item(int bit, bool value) { }

	// RVA: 0x1347AF4
	public int get_Data() { }

	// RVA: 0x1347AFC
	public static int CreateMask() { }

	// RVA: 0x1347B04
	public static int CreateMask(int previous) { }

	// RVA: 0x1347B78
	public override bool Equals(object o) { }

	// RVA: 0x1347C08
	public override int GetHashCode() { }

	// RVA: 0x1347C78
	public static string ToString(BitVector32 value) { }

	// RVA: 0x1347FA8
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

	// RVA: 0x1347FB0
	public void .ctor() { }

	// RVA: 0x13480E0
	public void .ctor(int capacity) { }

	// RVA: 0x134825C
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x134830C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13483B8
	protected void InvalidateCachedArrays() { }

	// RVA: 0x13483EC
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x13485B8
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x1348674
	public virtual void Add(string name, string value) { }

	// RVA: 0x13489A0
	public virtual string Get(string name) { }

	// RVA: 0x1348A38
	public virtual string[] GetValues(string name) { }

	// RVA: 0x1348B9C
	public virtual void Set(string name, string value) { }

	// RVA: 0x1348D64
	public virtual void Remove(string name) { }

	// RVA: 0x13490D0
	public string get_Item(string name) { }

	// RVA: 0x13490E0
	public void set_Item(string name, string value) { }

	// RVA: 0x13490F0
	public virtual string Get(int index) { }

	// RVA: 0x13492B0
	public virtual string GetKey(int index) { }

	// RVA: 0x1349400
	internal void .ctor(DBNull dummy) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Methods

	// RVA: 0x134A814
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x134B108
	public object get_Current() { }

	// RVA: 0x134B304
	public DictionaryEntry get_Entry() { }

	// RVA: 0x134B4B8
	public object get_Key() { }

	// RVA: 0x134B5AC
	public object get_Value() { }

	// RVA: 0x134B6A0
	public bool MoveNext() { }

	// RVA: 0x134B754
	public void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Methods

	// RVA: 0x13497D8
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x134B80C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x134BBE8
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x134BC10
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x134BC18
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x134BC40
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

	// RVA: 0x1349490
	public void .ctor() { }

	// RVA: 0x13494C4
	public void .ctor(int capacity) { }

	// RVA: 0x13494FC
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x1349540
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1349574
	public int get_Count() { }

	// RVA: 0x13496B4
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x13496BC
	public bool get_IsReadOnly() { }

	// RVA: 0x13496C4
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13496CC
	public ICollection get_Keys() { }

	// RVA: 0x1349610
	private ArrayList get_objectsArray() { }

	// RVA: 0x1349820
	private Hashtable get_objectsTable() { }

	// RVA: 0x13498D8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1349964
	public object get_Item(object key) { }

	// RVA: 0x1349A18
	public void set_Item(object key, object value) { }

	// RVA: 0x134A0E8
	public ICollection get_Values() { }

	// RVA: 0x1349EF4
	public void Add(object key, object value) { }

	// RVA: 0x134A1F0
	public void Clear() { }

	// RVA: 0x134A364
	public bool Contains(object key) { }

	// RVA: 0x134A418
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1349CC8
	private int IndexOfKey(object key) { }

	// RVA: 0x134A4DC
	public void Remove(object key) { }

	// RVA: 0x134A6D8
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x134A878
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x134A9B4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x134ABF4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x134AC04
	protected virtual void OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringCollection
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Methods

	// RVA: 0x134BCE8
	public string get_Item(int index) { }

	// RVA: 0x134BD70
	public void set_Item(int index, string value) { }

	// RVA: 0x134BD98
	public int get_Count() { }

	// RVA: 0x134BDC0
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x134BDC8
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x134BDD0
	public int Add(string value) { }

	// RVA: 0x134BDF8
	public void Clear() { }

	// RVA: 0x134BE20
	public bool Contains(string value) { }

	// RVA: 0x134BE48
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x134BE70
	public int IndexOf(string value) { }

	// RVA: 0x134BE98
	public void Insert(int index, string value) { }

	// RVA: 0x134BEC0
	public bool get_IsSynchronized() { }

	// RVA: 0x134BEC8
	public void Remove(string value) { }

	// RVA: 0x134BEF0
	public void RemoveAt(int index) { }

	// RVA: 0x134BF18
	public object get_SyncRoot() { }

	// RVA: 0x134BF40
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x134BFC8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x134C058
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x134C0E0
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x134C168
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x134C1F0
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x134C280
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x134C308
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x134C330
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x134C358
	public void .ctor() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringDictionary
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x134C3D0
	public void .ctor() { }

	// RVA: 0x134C448
	public virtual string get_Item(string key) { }

	// RVA: 0x134C52C
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

	// RVA: 0x134C554
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x134C770
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x134CAD0
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x134CE0C
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x134C9A4
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x134C6C8
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x134CFE4
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x134CCE8
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler
{
	// Methods

	// RVA: 0x134D0C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x134D1E4
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

// Namespace: System.Collections.Specialized
internal sealed class ReadOnlyList
{
	// Fields
	private readonly IList _list; // 0x10

	// Methods

	// RVA: 0x134D08C
	internal void .ctor(IList list) { }

	// RVA: 0x134D1F8
	public int get_Count() { }

	// RVA: 0x134D2B0
	public bool get_IsReadOnly() { }

	// RVA: 0x134D2B8
	public bool get_IsFixedSize() { }

	// RVA: 0x134D2C0
	public bool get_IsSynchronized() { }

	// RVA: 0x134D378
	public object get_Item(int index) { }

	// RVA: 0x134D42C
	public void set_Item(int index, object value) { }

	// RVA: 0x134D480
	public object get_SyncRoot() { }

	// RVA: 0x134D538
	public int Add(object value) { }

	// RVA: 0x134D58C
	public void Clear() { }

	// RVA: 0x134D5E0
	public bool Contains(object value) { }

	// RVA: 0x134D698
	public void CopyTo(Array array, int index) { }

	// RVA: 0x134D754
	public IEnumerator GetEnumerator() { }

	// RVA: 0x134D808
	public int IndexOf(object value) { }

	// RVA: 0x134D8C0
	public void Insert(int index, object value) { }

	// RVA: 0x134D914
	public void Remove(object value) { }

	// RVA: 0x134D968
	public void RemoveAt(int index) { }

}

// Namespace: 
internal class NameObjectEntry
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x134ED3C
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

	// RVA: 0x134EE20
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x134F358
	public bool MoveNext() { }

	// RVA: 0x134F43C
	public void Reset() { }

	// RVA: 0x134F4C8
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

	// RVA: 0x1348074
	protected void .ctor() { }

	// RVA: 0x134D9BC
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x13482DC
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x134816C
	protected void .ctor(int capacity) { }

	// RVA: 0x1349488
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x1348384
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x134DC34
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x134E480
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x134DA78
	private void Reset() { }

	// RVA: 0x134DB4C
	private void Reset(int capacity) { }

	// RVA: 0x134EC5C
	private NameObjectEntry FindEntry(string key) { }

	// RVA: 0x134ED34
	protected bool get_IsReadOnly() { }

	// RVA: 0x1348818
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1348DA8
	protected void BaseRemove(string name) { }

	// RVA: 0x13487FC
	protected object BaseGet(string name) { }

	// RVA: 0x1348CA4
	protected void BaseSet(string name, object value) { }

	// RVA: 0x1349208
	protected object BaseGet(int index) { }

	// RVA: 0x1349358
	protected string BaseGetKey(int index) { }

	// RVA: 0x134ED8C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x134EE80
	public virtual int get_Count() { }

	// RVA: 0x134EEA8
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x134F1E0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x134F26C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x134F274
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

	// RVA: 0x134EC0C
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x134F5F0
	public bool Equals(object a, object b) { }

	// RVA: 0x134F810
	public int GetHashCode(object obj) { }

	// RVA: 0x134F928
	public IComparer get_Comparer() { }

	// RVA: 0x134F930
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x134E394
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x134E2B0
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

	// RVA: 0x30D4CD4
	internal void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: 0x318DB98
	internal void LocalPush(T item, Int64 emptyToNonEmptyListTransitionCount) { }

	// RVA: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30D39B8
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

	// RVA: 0x30D4CD4
	public void .ctor(T[] array) { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public T get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	public void Add(T item) { }

	// RVA: -1
	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	// RVA: 0x30D3CF0
	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: 0x30D3CF0
	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: 0x30D4D3C
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D3CF0
	public T[] ToArray() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D39B8
	private int get_DangerousCount() { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D3CF0
	private object get_GlobalQueuesLock() { }

	// RVA: 0x30D4CD4
	private void FreezeBag(bool lockTaken) { }

	// RVA: 0x30D4918
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

	// RVA: 0x318DB98
	public void .ctor(System.Span<T> initialSpan) { }

	// RVA: 0x30D39B8
	public int get_Length() { }

	// RVA: -1
	public T get_Item(int index) { }

	// RVA: 0x318DB98
	public void Append(T item) { }

	// RVA: 0x318DB98
	public System.ReadOnlySpan<T> AsSpan() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D488C
	private void Grow() { }

	// RVA: 0x318DB98
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

	// RVA: 0x134F938
	internal void .ctor(Int32* bitArrayPtr, int length) { }

	// RVA: 0x134F97C
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x134F9C4
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x134FA44
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x134FACC
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.LinkedList<T> list) { }

	// RVA: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x318DB98
	public T get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.LinkedListNode<T> get_First() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x318DB98
	public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }

	// RVA: 0x318DB98
	public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }

	// RVA: 0x30D4CD4
	public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(T value) { }

	// RVA: 0x30D4D3C
	public void CopyTo(T[] array, int index) { }

	// RVA: 0x318DB98
	public System.Collections.Generic.LinkedListNode<T> Find(T value) { }

	// RVA: 0x318DB98
	public Enumerator GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x318DB98
	public bool Remove(T value) { }

	// RVA: 0x30D4CD4
	public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30D488C
	public void RemoveFirst() { }

	// RVA: -1
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D4CD4
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x30D4F34
	private void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30D4CD4
	private void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30D4CD4
	internal void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30D4CD4
	internal void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30D4CD4
	internal void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x318DB98
	internal void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.LinkedListNode<T> get_Next() { }

	// RVA: 0x318DB98
	public T get_Value() { }

	// RVA: 0x30D488C
	internal void Invalidate() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x30D4D3C
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, int getEnumeratorRetType) { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x318DB98
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30D3738
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30D488C
	internal void Reset() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public TKey get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D4D3C
	public void CopyTo(TKey[] array, int index) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: 0x30D488C
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public TValue get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D4D3C
	public void CopyTo(TValue[] array, int index) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: 0x30D488C
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
[Serializable]
internal sealed class KeyValuePairComparer
{
	// Fields
	internal System.Collections.Generic.IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }

	// RVA: 0x318DB98
	public override int Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1
{
	// Fields
	public System.Collections.Generic.EqualityComparer<TValue> valueComparer; // 0x0
	public System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey,TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x318DB98
	public TValue get_Item(TKey key) { }

	// RVA: 0x318DB98
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3CF0
	public KeyCollection get_Keys() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30D3CF0
	public ValueCollection get_Values() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x318DB98
	public void Add(TKey key, TValue value) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool ContainsKey(TKey key) { }

	// RVA: 0x318DB98
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30D4D3C
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int index) { }

	// RVA: 0x318DB98
	public Enumerator GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x318DB98
	public bool Remove(TKey key) { }

	// RVA: 0x318DB98
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D3738
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30D3738
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30D3DA0
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30D3858
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30D5E84
	private static bool IsCompatibleKey(object key) { }

	// RVA: 0x30D3CF0
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30D4CD4
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
[Serializable]
internal sealed class TreeSet<T0>
{
	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	public void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D4D3C
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, int getEnumeratorRetType) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x318DB98
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public TKey get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public TValue get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class KeyList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	public bool get_IsReadOnly() { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x318DB98
	public void Add(TKey key) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(TKey key) { }

	// RVA: 0x30D4D3C
	public void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x318DB98
	public void Insert(int index, TKey value) { }

	// RVA: 0x318DB98
	public TKey get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, TKey value) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public int IndexOf(TKey key) { }

	// RVA: 0x318DB98
	public bool Remove(TKey key) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int index) { }

}

// Namespace: 
[Serializable]
private sealed class ValueList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	public bool get_IsReadOnly() { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x318DB98
	public void Add(TValue key) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(TValue value) { }

	// RVA: 0x30D4D3C
	public void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x318DB98
	public void Insert(int index, TValue value) { }

	// RVA: 0x318DB98
	public TValue get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public int IndexOf(TValue value) { }

	// RVA: 0x318DB98
	public bool Remove(TValue value) { }

	// RVA: 0x30D4A04
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x318DB98
	public void Add(TKey key, TValue value) { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30D4A04
	public void set_Capacity(int value) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IComparer<TKey> get_Comparer() { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30D3CF0
	private KeyList GetKeyListHelper() { }

	// RVA: 0x30D3CF0
	private ValueList GetValueListHelper() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30D3738
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30D3738
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x30D3858
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x318DB98
	public bool ContainsKey(TKey key) { }

	// RVA: 0x318DB98
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30D4D3C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D4A04
	private void EnsureCapacity(int min) { }

	// RVA: 0x318DB98
	private TValue GetByIndex(int index) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	private TKey GetKey(int index) { }

	// RVA: 0x318DB98
	public TValue get_Item(TKey key) { }

	// RVA: 0x318DB98
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30D3DA0
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x318DB98
	public int IndexOfKey(TKey key) { }

	// RVA: 0x318DB98
	public int IndexOfValue(TValue value) { }

	// RVA: 0x318DB98
	private void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x318DB98
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int index) { }

	// RVA: 0x318DB98
	public bool Remove(TKey key) { }

	// RVA: 0x30D4CD4
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30D5E84
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

	// RVA: 0x318DB98
	public void .ctor(T item, NodeColor color) { }

	// RVA: 0x30D5E84
	public static bool IsNonNullRed(Node node) { }

	// RVA: 0x30D5E84
	public static bool IsNullOrBlack(Node node) { }

	// RVA: 0x318DB98
	public T get_Item() { }

	// RVA: 0x318DB98
	public void set_Item(T value) { }

	// RVA: 0x30D3CF0
	public Node get_Left() { }

	// RVA: 0x30D4CD4
	public void set_Left(Node value) { }

	// RVA: 0x30D3CF0
	public Node get_Right() { }

	// RVA: 0x30D4CD4
	public void set_Right(Node value) { }

	// RVA: 0x30D3738
	public NodeColor get_Color() { }

	// RVA: 0x30D4918
	public void set_Color(NodeColor value) { }

	// RVA: 0x30D3738
	public bool get_IsBlack() { }

	// RVA: 0x30D3738
	public bool get_IsRed() { }

	// RVA: 0x30D3738
	public bool get_Is2Node() { }

	// RVA: 0x30D3738
	public bool get_Is4Node() { }

	// RVA: 0x30D488C
	public void ColorBlack() { }

	// RVA: 0x30D488C
	public void ColorRed() { }

	// RVA: -1
	public Node DeepClone(int count) { }

	// RVA: -1
	public TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: 0x30D3DA0
	public Node GetSibling(Node node) { }

	// RVA: 0x30D3CF0
	public Node ShallowClone() { }

	// RVA: 0x30D488C
	public void Split4Node() { }

	// RVA: -1
	public Node Rotate(TreeRotation rotation) { }

	// RVA: 0x30D3CF0
	public Node RotateLeft() { }

	// RVA: 0x30D3CF0
	public Node RotateLeftRight() { }

	// RVA: 0x30D3CF0
	public Node RotateRight() { }

	// RVA: 0x30D3CF0
	public Node RotateRightLeft() { }

	// RVA: 0x30D488C
	public void Merge2Nodes() { }

	// RVA: 0x30D4F34
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Collections.Generic.SortedSet<T> set) { }

	// RVA: -1
	internal void .ctor(System.Collections.Generic.SortedSet<T> set, bool reverse) { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D4CD4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30D488C
	private void Initialize() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x318DB98
	public T get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3738
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30D488C
	internal void Reset() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: 0x30D4F34
	public void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D4CD4
	private void AddAllElements(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x30D3858
	internal virtual bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IComparer<T> get_Comparer() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D488C
	internal virtual void VersionCheck() { }

	// RVA: 0x318DB98
	internal virtual bool IsWithinRange(T item) { }

	// RVA: 0x318DB98
	public bool Add(T item) { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x318DB98
	internal virtual bool AddIfNotPresent(T item) { }

	// RVA: 0x318DB98
	public bool Remove(T item) { }

	// RVA: 0x318DB98
	internal virtual bool DoRemove(T item) { }

	// RVA: 0x30D488C
	public virtual void Clear() { }

	// RVA: 0x318DB98
	public virtual bool Contains(T item) { }

	// RVA: 0x30D4D3C
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	public void CopyTo(T[] array, int index, int count) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x318DB98
	public Enumerator GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D5174
	private void InsertionBalance(Node current, Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: 0x30D5108
	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: 0x30D5174
	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: 0x318DB98
	internal virtual Node FindNode(T item) { }

	// RVA: 0x318DB98
	internal virtual int InternalIndexOf(T item) { }

	// RVA: 0x30D488C
	internal void UpdateVersion() { }

	// RVA: 0x30D3858
	private bool HasEqualComparer(System.Collections.Generic.SortedSet<T> other) { }

	// RVA: 0x30D4CD4
	public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x318DB98
	private static Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode) { }

	// RVA: 0x30D4CD4
	public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30D4CD4
	internal virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30D3858
	public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x318DB98
	private ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, bool returnIfUnfound) { }

	// RVA: 0x318DB98
	public T get_Min() { }

	// RVA: 0x318DB98
	internal virtual T get_MinInternal() { }

	// RVA: 0x318DB98
	public T get_Max() { }

	// RVA: 0x318DB98
	internal virtual T get_MaxInternal() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30D4CD4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x30D3858
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

	// RVA: 0x134FAE0
	public void .ctor() { }

	// RVA: 0x134FB38
	public void .ctor(string message) { }

	// RVA: 0x134FB40
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

	// RVA: 0x134FB48
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x134FB50
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x134FC14
	public override bool get_CanRead() { }

	// RVA: 0x134FC2C
	public override bool get_CanWrite() { }

	// RVA: 0x134FC44
	public override bool get_CanSeek() { }

	// RVA: 0x134FC5C
	public override Int64 get_Length() { }

	// RVA: 0x134FCB0
	public override Int64 get_Position() { }

	// RVA: 0x134FD04
	public override void set_Position(Int64 value) { }

	// RVA: 0x134FD58
	public override void Flush() { }

	// RVA: 0x134FD9C
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x134FDF0
	public override int ReadByte() { }

	// RVA: 0x134FE18
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x134FED0
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x134FF38
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x134FF60
	public override int Read(System.Span<System.Byte> buffer) { }

	// RVA: 0x1350174
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x135022C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1350238
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1350260
	public override void Write(System.ReadOnlySpan<System.Byte> buffer) { }

	// RVA: 0x1350444
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x135046C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1350530
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1350558
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1350644
	public override Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x135066C
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1350758
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x134FD80
	private void CheckDeflateStream() { }

	// RVA: 0x1350780
	private static void ThrowStreamClosedException() { }

}

// Namespace: 
private sealed class ReadMethod
{
	// Methods

	// RVA: 0x1351A8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13525CC
	public virtual int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1351B48
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x13522B0
	public virtual int EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod
{
	// Methods

	// RVA: 0x1351FB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13525E0
	public virtual void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1352070
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1352434
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

	// RVA: 0x13507D8
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x134FC0C
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x13507E4
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x1350C20
	protected override void Finalize() { }

	// RVA: 0x1350CC0
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1350EE8
	private int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x135063C
	internal System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x135004C
	internal int ReadCore(System.Span<System.Byte> destination) { }

	// RVA: 0x135100C
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1351230
	private void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1350750
	internal ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x13503B4
	internal void WriteCore(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x135134C
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x135158C
	public override void Flush() { }

	// RVA: 0x13516F4
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1351C1C
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1352144
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x13522DC
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1352440
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1352480
	public override bool get_CanRead() { }

	// RVA: 0x13524C0
	public override bool get_CanSeek() { }

	// RVA: 0x13524C8
	public override bool get_CanWrite() { }

	// RVA: 0x135250C
	public override Int64 get_Length() { }

	// RVA: 0x135254C
	public override Int64 get_Position() { }

	// RVA: 0x135258C
	public override void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite
{
	// Methods

	// RVA: 0x1352794
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1352FC8
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle
{
	// Methods

	// RVA: 0x1352FDC
	public override bool get_IsInvalid() { }

	// RVA: 0x1352FB4
	private void .ctor() { }

	// RVA: 0x1352FEC
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

	// RVA: 0x135278C
	private void .ctor() { }

	// RVA: 0x13509B0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x13528DC
	protected override void Finalize() { }

	// RVA: 0x1350DBC
	public void Dispose(bool disposing) { }

	// RVA: 0x1351640
	public void Flush() { }

	// RVA: 0x1350F3C
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1351280
	public void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x13525F4
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1352BD0
	private int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x13526C0
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1352DB4
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x13529E0
	private void CheckResult(int result, string where) { }

	// RVA: 0x1352838
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1352FC4
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1352970
	private static extern int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x1352AC0
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1352B48
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

	// RVA: 0x13544E0
	private static void .cctor() { }

	// RVA: 0x135454C
	public void .ctor() { }

	// RVA: 0x1354554
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

	// RVA: 0x1353090
	private void SafeCaptureIdentity() { }

	// RVA: 0x1353094
	private void CleanupInternal() { }

	// RVA: 0x1353098
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x13530A0
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1353110
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1353198
	internal object StartPostingAsyncOp() { }

	// RVA: 0x13531A0
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x135344C
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x1353AF0
	protected override void Cleanup() { }

	// RVA: 0x135349C
	private bool CaptureOrComplete(ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x1354004
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x13543B0
	private void CompleteCallback() { }

}

// Namespace: System.Net
internal static class HttpStatusDescription
{
	// Methods

	// RVA: 0x13545D8
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x13545DC
	internal static string Get(int code) { }

}

// Namespace: System.Net
internal static class HttpValidationHelpers
{
	// Fields
	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x1354ECC
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x1354FF0
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

	// RVA: 0x1355094
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1355794
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x1355D30
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x135570C
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x1355F0C
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1356160
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x13560D8
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x1353CA4
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1353E70
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x13562F4
	private void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x135637C
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x1356510
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x13532B8
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x1356598
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1356620
	public static void Associate(object first, object second, string memberName) { }

	// RVA: 0x13567BC
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x1353C24
	public static bool get_IsEnabled() { }

	// RVA: 0x1355260
	public static string IdOf(object value) { }

	// RVA: 0x1356A60
	public static int GetHashCode(object value) { }

	// RVA: 0x135593C
	public static object Format(object value) { }

	// RVA: 0x1355360
	private static string Format(FormattableString s) { }

	// RVA: 0x1356848
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1356A74
	public void .ctor() { }

	// RVA: 0x1356A7C
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class TcpValidationHelpers
{
	// Methods

	// RVA: 0x1356AE8
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

	// RVA: 0x1356AF4
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x1356BEC
	public void AuthenticateAsClient() { }

	// RVA: 0x1356D3C
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x1356EA4
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1356ECC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1356EF4
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x1356F1C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1356F44
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1356F6C
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1356F94
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1356FBC
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

	// RVA: 0x1357000
	private static void .cctor() { }

}

// Namespace: 
private sealed class ReadOnlyIPAddress
{
	// Methods

	// RVA: 0x1358E68
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

	// RVA: 0x1357120
	private bool get_IsIPv4() { }

	// RVA: 0x1357130
	private bool get_IsIPv6() { }

	// RVA: 0x1357140
	private UInt32 get_PrivateAddress() { }

	// RVA: 0x1357148
	private void set_PrivateAddress(UInt32 value) { }

	// RVA: 0x1357180
	private UInt32 get_PrivateScopeId() { }

	// RVA: 0x1357188
	private void set_PrivateScopeId(UInt32 value) { }

	// RVA: 0x13571C0
	public void .ctor(Int64 newAddress) { }

	// RVA: 0x1357250
	public void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0x1357370
	public void .ctor(System.ReadOnlySpan<System.Byte> address, Int64 scopeid) { }

	// RVA: 0x13575A4
	internal void .ctor(UInt16* numbers, int numbersLength, UInt32 scopeid) { }

	// RVA: 0x135766C
	private void .ctor(UInt16[] numbers, UInt32 scopeid) { }

	// RVA: 0x13576C8
	public static bool TryParse(string ipString, IPAddress address) { }

	// RVA: 0x1357A64
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1357B00
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten) { }

	// RVA: 0x1357E30
	private void WriteIPv6Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x1358088
	private void WriteIPv4Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x13580D8
	public Byte[] GetAddressBytes() { }

	// RVA: 0x13581E0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x13581F8
	public Int64 get_ScopeId() { }

	// RVA: 0x1358254
	public override string ToString() { }

	// RVA: 0x135839C
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x13584B4
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x13586B0
	public override bool Equals(object comparand) { }

	// RVA: 0x13586B8
	public override int GetHashCode() { }

	// RVA: 0x1358AA0
	public IPAddress MapToIPv6() { }

	// RVA: 0x135731C
	private static Byte[] ThrowAddressNullException() { }

	// RVA: 0x1358BAC
	private static void .cctor() { }

}

// Namespace: System.Net
internal class IPAddressParser
{
	// Methods

	// RVA: 0x135776C
	internal static IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, bool tryParse) { }

	// RVA: 0x135832C
	internal static string IPv4AddressToString(UInt32 address) { }

	// RVA: 0x13593C0
	internal static void IPv4AddressToString(UInt32 address, StringBuilder destination) { }

	// RVA: 0x135911C
	private static int IPv4AddressToStringHelper(UInt32 address, Char* addressString) { }

	// RVA: 0x1358314
	internal static string IPv6AddressToString(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x135950C
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x1359440
	private static void FormatIPv4AddressNumber(int number, Char* addressString, int offset) { }

	// RVA: 0x1359060
	public static bool Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, Int64 address) { }

	// RVA: 0x1358EF4
	public static bool Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, UInt16* numbers, int numbersLength, UInt32 scope) { }

	// RVA: 0x135969C
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x1359A34
	private static void AppendHex(UInt16 value, StringBuilder buffer) { }

	// RVA: 0x13599FC
	private static UInt32 ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x1359AD0
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

	// RVA: 0x1359AD8
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1359B08
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x1359BE8
	public IPAddress get_Address() { }

	// RVA: 0x1359BF0
	public int get_Port() { }

	// RVA: 0x1359BF8
	public override string ToString() { }

	// RVA: 0x1359CC0
	public override SocketAddress Serialize() { }

	// RVA: 0x1359D34
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1359F44
	public override bool Equals(object comparand) { }

	// RVA: 0x135A01C
	public override int GetHashCode() { }

	// RVA: 0x135A058
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

	// RVA: 0x135C60C
	internal void .ctor(string command) { }

	// RVA: 0x135C640
	internal void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x135C688
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

	// RVA: 0x135A138
	internal void .ctor(TcpClient client) { }

	// RVA: 0x135A1F4
	internal virtual void Abort(Exception e) { }

	// RVA: 0x135A45C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x135A5DC
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x135A660
	internal bool get_RecoverableFailure() { }

	// RVA: 0x135A668
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x135A680
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x135ADAC
	protected virtual void ClearState() { }

	// RVA: 0x135AE54
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x135AE5C
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x135AEE0
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x135A788
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x135AF9C
	internal void CheckContinuePipeline() { }

	// RVA: 0x135A844
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x135B058
	private bool PostSendCommandProcessing(Stream stream) { }

	// RVA: 0x135B51C
	private bool PostReadCommandProcessing(Stream stream) { }

	// RVA: 0x135B7C8
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x135B7D0
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x135C0D4
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x135C3C4
	protected Encoding get_Encoding() { }

	// RVA: 0x135C3CC
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x135C420
	protected virtual bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x135B1A0
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x135BAD8
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x135C428
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

	// RVA: 0x135C698
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x135C6AC
	internal bool get_PositiveCompletion() { }

	// RVA: 0x135C6C0
	internal bool get_TransientFailure() { }

	// RVA: 0x135C6D4
	internal bool get_PermanentFailure() { }

	// RVA: 0x135C6E8
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x135C6FC
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

	// RVA: 0x135C77C
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

	// RVA: 0x135E55C
	public void .ctor() { }

	// RVA: 0x1361D60
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

	// RVA: 0x135C8A0
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x135C958
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x135C9F0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x135CA9C
	internal void AbortConnect() { }

	// RVA: 0x135CB3C
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x135D064
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x135D23C
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x135D414
	private PipelineInstruction QueueOrCreateFtpDataStream(Stream stream) { }

	// RVA: 0x135DBA8
	protected override void ClearState() { }

	// RVA: 0x135DC7C
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x135F700
	protected override PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x135E564
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream, bool isSocketReady) { }

	// RVA: 0x1360A34
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, string path, string directory, string filename) { }

	// RVA: 0x1361588
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x13616A8
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x13617C4
	internal Int64 get_ContentLength() { }

	// RVA: 0x13617CC
	internal DateTime get_LastModified() { }

	// RVA: 0x13617D4
	internal Uri get_ResponseUri() { }

	// RVA: 0x13617DC
	internal string get_BannerMessage() { }

	// RVA: 0x13617F4
	internal string get_WelcomeMessage() { }

	// RVA: 0x136180C
	internal string get_ExitMessage() { }

	// RVA: 0x135F188
	private Int64 GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x135F2BC
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x135EDF4
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x135ECF4
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x135F64C
	private string GetLoginDirectory(string str) { }

	// RVA: 0x1361074
	private int GetPortV4(string responseString) { }

	// RVA: 0x1361254
	private int GetPortV6(string responseString) { }

	// RVA: 0x1360C4C
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1360E48
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x1360904
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1361400
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x1361824
	protected override bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x135D7F8
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x1361C2C
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

	// RVA: 0x135D890
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x1361E74
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1362000
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1362468
	private void CheckError() { }

	// RVA: 0x13624B4
	public override bool get_CanRead() { }

	// RVA: 0x13624BC
	public override bool get_CanSeek() { }

	// RVA: 0x13624E0
	public override bool get_CanWrite() { }

	// RVA: 0x13624E8
	public override Int64 get_Length() { }

	// RVA: 0x136250C
	public override Int64 get_Position() { }

	// RVA: 0x1362530
	public override void set_Position(Int64 value) { }

	// RVA: 0x1362558
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1362650
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1362780
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1362874
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x1362BE8
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1362EF8
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x13630EC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x13631E4
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x13632C8
	public override void Flush() { }

	// RVA: 0x13632F0
	public override bool get_CanTimeout() { }

	// RVA: 0x1363314
	public override int get_ReadTimeout() { }

	// RVA: 0x136333C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1363364
	public override int get_WriteTimeout() { }

	// RVA: 0x136338C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x13633B4
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

	// RVA: 0x1363408
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x1360A24
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x1360C3C
	internal bool get_IsCommandOnly() { }

	// RVA: 0x1361C14
	internal bool get_IsUpload() { }

	// RVA: 0x1361C20
	internal bool get_IsDownload() { }

	// RVA: 0x135EDE8
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x136346C
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x13635E4
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

	// RVA: 0x136A630
	private void MoveNext() { }

	// RVA: 0x136AA50
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

	// RVA: 0x136AA5C
	private static void .cctor() { }

	// RVA: 0x136AAC8
	public void .ctor() { }

	// RVA: 0x136AAD0
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

	// RVA: 0x1363D8C
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x1363D94
	public override string get_Method() { }

	// RVA: 0x1363DB4
	public override void set_Method(string value) { }

	// RVA: 0x1363FA4
	public string get_RenameTo() { }

	// RVA: 0x1363FAC
	public override ICredentials get_Credentials() { }

	// RVA: 0x1363FB4
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1364158
	public override Uri get_RequestUri() { }

	// RVA: 0x1364160
	public override int get_Timeout() { }

	// RVA: 0x1364168
	internal int get_RemainingTimeout() { }

	// RVA: 0x1364170
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1364178
	public Int64 get_ContentOffset() { }

	// RVA: 0x1364180
	public override Int64 get_ContentLength() { }

	// RVA: 0x1364188
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1364190
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1364200
	internal bool get_Aborted() { }

	// RVA: 0x1364208
	internal void .ctor(Uri uri) { }

	// RVA: 0x136482C
	public override WebResponse GetResponse() { }

	// RVA: 0x1366554
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1366D0C
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x13655A0
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x1367B2C
	private Exception TranslateConnectException(Exception e) { }

	// RVA: 0x1367174
	private void CreateConnectionAsync() { }

	// RVA: 0x136722C
	private FtpControlStream CreateConnection() { }

	// RVA: 0x1367470
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x1367DB4
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x1367D1C
	private Queue get_TimerQueue() { }

	// RVA: 0x13678B8
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x1366104
	private void SetException(Exception exception) { }

	// RVA: 0x1365084
	private void CheckError() { }

	// RVA: 0x1368928
	internal void RequestCallback(object obj) { }

	// RVA: 0x13694FC
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x1368938
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x136511C
	private RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x136997C
	public override void Abort() { }

	// RVA: 0x1369E58
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1369EC8
	public bool get_UseBinary() { }

	// RVA: 0x1369ED0
	public bool get_UsePassive() { }

	// RVA: 0x135DA7C
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1369ED8
	public bool get_EnableSsl() { }

	// RVA: 0x1369EE0
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x136A02C
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1363F84
	private bool get_InUse() { }

	// RVA: 0x1365B48
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x136A35C
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x136A3F4
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FtpWebRequestCreator
{
	// Methods

	// RVA: 0x136AB28
	internal void .ctor() { }

	// RVA: 0x136AB30
	public WebRequest Create(Uri uri) { }

}

// Namespace: 
internal sealed class EmptyStream
{
	// Methods

	// RVA: 0x136AC24
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

	// RVA: 0x136A1AC
	internal void .ctor(Stream responseStream, Int64 contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x13688EC
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x136AB9C
	public override Stream GetResponseStream() { }

	// RVA: 0x136A0E0
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x136AD10
	public override void Close() { }

	// RVA: 0x136AE4C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x136AFD8
	public override Uri get_ResponseUri() { }

	// RVA: 0x136AFE0
	public FtpStatusCode get_StatusCode() { }

}

// Namespace: System.Net
internal class NetworkStreamWrapper
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Methods

	// RVA: 0x136AFE8
	internal void .ctor(TcpClient client) { }

	// RVA: 0x135D9F4
	protected bool get_UsingSecureStream() { }

	// RVA: 0x135CED8
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x135F168
	internal Socket get_Socket() { }

	// RVA: 0x136B084
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x136B08C
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x136B094
	public override bool get_CanRead() { }

	// RVA: 0x136B0B8
	public override bool get_CanSeek() { }

	// RVA: 0x136B0DC
	public override bool get_CanWrite() { }

	// RVA: 0x136B100
	public override bool get_CanTimeout() { }

	// RVA: 0x136B124
	public override int get_ReadTimeout() { }

	// RVA: 0x136B14C
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x136B174
	public override int get_WriteTimeout() { }

	// RVA: 0x136B19C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x136B1C4
	public override Int64 get_Length() { }

	// RVA: 0x136B1E8
	public override Int64 get_Position() { }

	// RVA: 0x136B20C
	public override void set_Position(Int64 value) { }

	// RVA: 0x136B234
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x136B25C
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x136B284
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x136B2AC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x135D020
	internal void CloseSocket() { }

	// RVA: 0x136B3B0
	public void Close(int timeout) { }

	// RVA: 0x136B3EC
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x136B414
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x136B43C
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x136B464
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x136B48C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x136B4B4
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x136B4DC
	public override void Flush() { }

	// RVA: 0x136B504
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x136741C
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

	// RVA: 0x136B52C
	public void .ctor(string token) { }

	// RVA: 0x136B5F4
	public void .ctor(string token, bool finished) { }

	// RVA: 0x136B6B0
	public string get_Message() { }

	// RVA: 0x136B6B8
	public bool get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache
{
	// Methods

	// RVA: 0x136B6C0
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x136B73C
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x136B7B8
	private void .ctor() { }

	// RVA: 0x136B81C
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint
{
	// Methods

	// RVA: 0x136B8CC
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x136B980
	public virtual SocketAddress Serialize() { }

	// RVA: 0x136BA34
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x136BA60
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

	// RVA: 0x136BA68
	public string get_HostName() { }

	// RVA: 0x136BA70
	public void set_HostName(string value) { }

	// RVA: 0x136BA78
	public void set_Aliases(string[] value) { }

	// RVA: 0x136BA80
	public IPAddress[] get_AddressList() { }

	// RVA: 0x136BA88
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x136BA90
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

	// RVA: 0x135D7F0
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

	// RVA: 0x136BAA0
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x136BB94
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x136C254
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x136BC24
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x136C270
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

	// RVA: 0x136B5E0
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x136C32C
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x136C348
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x136C354
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper
{
	// Methods

	// RVA: 0x136B9AC
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x136B8F8
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x1365098
	internal static WebException get_TimeoutException() { }

	// RVA: 0x136A058
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1361480
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

	// RVA: 0x136C534
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x136C764
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x136C76C
	public void .ctor(string P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate
{
	// Methods

	// RVA: 0x136C7BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136C860
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

	// RVA: 0x13647B8
	public void .ctor(string userName, string password) { }

	// RVA: 0x136A520
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1360A08
	public string get_UserName() { }

	// RVA: 0x136C874
	public void set_UserName(string value) { }

	// RVA: 0x1360A18
	public string get_Password() { }

	// RVA: 0x136C8F8
	public void set_Password(string value) { }

	// RVA: 0x1360A10
	public string get_Domain() { }

	// RVA: 0x136C92C
	public void set_Domain(string value) { }

	// RVA: 0x136C9BC
	internal string InternalGetUserName() { }

	// RVA: 0x136C9B0
	internal string InternalGetPassword() { }

	// RVA: 0x136C9C4
	internal string InternalGetDomain() { }

	// RVA: 0x136C9CC
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException
{
	// Methods

	// RVA: 0x136C9D0
	public void .ctor() { }

	// RVA: 0x136C9D8
	public void .ctor(string message) { }

	// RVA: 0x136C9E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136C9E8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136C9F0
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

	// RVA: 0x136C9F8
	public AddressFamily get_Family() { }

	// RVA: 0x136CA2C
	public int get_Size() { }

	// RVA: 0x136CA34
	public Byte get_Item(int offset) { }

	// RVA: 0x136CAB4
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x136CBEC
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x136CE50
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x136CEB0
	internal IPAddress GetIPAddress() { }

	// RVA: 0x136D094
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x136D138
	public override bool Equals(object comparand) { }

	// RVA: 0x136D244
	public override int GetHashCode() { }

	// RVA: 0x136D57C
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

	// RVA: 0x136D858
	public void .ctor() { }

	// RVA: 0x1360C28
	public void .ctor(string message) { }

	// RVA: 0x13688DC
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x135CF70
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x136D868
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x136881C
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x136D9FC
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x136D930
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x136DAF0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x136DBF0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136DC00
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136DC0C
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136DC14
	public WebExceptionStatus get_Status() { }

	// RVA: 0x136DC1C
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

	// RVA: 0x136DC24
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x136DDF0
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

	// RVA: 0x136DE70
	private void NormalizeCommonHeaders() { }

	// RVA: 0x136DF88
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x136E054
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x136E250
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x136E298
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x136E3AC
	internal void AddInternal(string name, string value) { }

	// RVA: 0x136E40C
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x136E46C
	internal void RemoveInternal(string name) { }

	// RVA: 0x136E4CC
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x136E8A0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x136E928
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x136EAA0
	public override void Add(string name, string value) { }

	// RVA: 0x136EC5C
	public void Add(string header) { }

	// RVA: 0x136EF48
	public override void Set(string name, string value) { }

	// RVA: 0x136F190
	internal void SetInternal(string name, string value) { }

	// RVA: 0x136F3CC
	public override void Remove(string name) { }

	// RVA: 0x136F51C
	public override string[] GetValues(string header) { }

	// RVA: 0x136F754
	public override string ToString() { }

	// RVA: 0x136F7BC
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1369FBC
	public void .ctor() { }

	// RVA: 0x136FAFC
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x136FBF8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136FDF8
	public override void OnDeserialization(object sender) { }

	// RVA: 0x136FDFC
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136FF88
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x136FF94
	public override string Get(string name) { }

	// RVA: 0x13702CC
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1370348
	public override int get_Count() { }

	// RVA: 0x1370384
	public override string Get(int index) { }

	// RVA: 0x13703C8
	public override string GetKey(int index) { }

	// RVA: 0x137040C
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CaseInsensitiveAscii
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x13709CC
	public int GetHashCode(object myObject) { }

	// RVA: 0x1370AF0
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1370C80
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1370D80
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x1370F40
	public void .ctor() { }

	// RVA: 0x1370F48
	private static void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate
{
	// Methods

	// RVA: 0x1372794
	public WebRequest Create(Uri uri) { }

	// RVA: 0x1372698
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass79_0
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x13720A8
	public void .ctor() { }

	// RVA: 0x1372814
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

	// RVA: 0x1371014
	private static object get_InternalSyncObject() { }

	// RVA: 0x1371118
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1371588
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x137167C
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x13713B4
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1371798
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1364664
	protected void .ctor() { }

	// RVA: 0x1371A34
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1371A3C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1371A48
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1371A4C
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1371A50
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1371B20
	public virtual string get_Method() { }

	// RVA: 0x1371B4C
	public virtual void set_Method(string value) { }

	// RVA: 0x1371B78
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1371BA4
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1371BD0
	public virtual Int64 get_ContentLength() { }

	// RVA: 0x1371BFC
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1371C28
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x1371C54
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1371C80
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1371CAC
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1371CD8
	public virtual int get_Timeout() { }

	// RVA: 0x1371D04
	public virtual WebResponse GetResponse() { }

	// RVA: 0x1371D30
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1371D5C
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1371D88
	public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }

	// RVA: 0x13720B0
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1372120
	public virtual void Abort() { }

	// RVA: 0x137214C
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x1372154
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x137215C
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1372378
	private static void .cctor() { }

	// RVA: 0x13726A0
	private System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Methods

	// RVA: 0x136AB94
	protected void .ctor() { }

	// RVA: 0x1372B1C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1372B24
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1372B30
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1372B34
	public virtual void Close() { }

	// RVA: 0x1372B38
	public void Dispose() { }

	// RVA: 0x1372BC8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1372C68
	public virtual bool get_IsFromCache() { }

	// RVA: 0x1372C70
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1372C9C
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1372CC8
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

	// RVA: 0x1372CF4
	internal void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x1372DB0
	internal void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser
{
	// Methods

	// RVA: 0x1372E6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1372F20
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

	// RVA: 0x1372F34
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

	// RVA: 0x1372FA8
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x137302C
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x13733C4
	private static void .cctor() { }

	// RVA: 0x136E128
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x13709C4
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

	// RVA: 0x13755D0
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

	// RVA: 0x1375518
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1362E38
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x13755D8
	internal object get_AsyncObject() { }

	// RVA: 0x13755E0
	public object get_AsyncState() { }

	// RVA: 0x13755E8
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x13755F0
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x13756B0
	private bool LazilyCreateEvent(ManualResetEvent waitHandle) { }

	// RVA: 0x1375894
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1362BA4
	public bool get_IsCompleted() { }

	// RVA: 0x1366CF0
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x13758D8
	internal bool get_EndCalled() { }

	// RVA: 0x13758E0
	internal void set_EndCalled(bool value) { }

	// RVA: 0x13758E8
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1362B9C
	internal void InvokeCallback(object result) { }

	// RVA: 0x1366D00
	internal void InvokeCallback() { }

	// RVA: 0x1375B18
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1375CB8
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x1375D7C
	protected virtual void Cleanup() { }

	// RVA: 0x13630E4
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1375D80
	private object WaitForCompletion(bool snap) { }

}

// Namespace: System.Net
internal class NetRes
{
	// Methods

	// RVA: 0x136C478
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1376088
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x13760F0
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Namespace: 
internal abstract class Queue
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x13773B8
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x13773E4
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

	// RVA: 0x13773EC
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x1377424
	internal int get_StartTime() { }

	// RVA: 0x137742C
	internal int get_Expiration() { }

	// RVA: -1
	internal abstract bool Cancel() { }

	// RVA: -1
	internal abstract bool get_HasExpired() { }

	// RVA: 0x1377438
	public void Dispose() { }

}

// Namespace: 
internal sealed class Callback
{
	// Methods

	// RVA: 0x1364694
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1377444
	public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Namespace: 
private class TimerQueue
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x13765C4
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x1377494
	internal override Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x1377010
	internal bool Fire(int nextExpiration) { }

}

// Namespace: 
private class InfiniteTimerQueue
{
	// Methods

	// RVA: 0x1376598
	internal void .ctor() { }

	// RVA: 0x1377A98
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

	// RVA: 0x1377710
	internal void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x1377458
	internal void .ctor() { }

	// RVA: 0x1377B3C
	internal override bool get_HasExpired() { }

	// RVA: 0x1377B4C
	internal TimerNode get_Next() { }

	// RVA: 0x1377B54
	internal void set_Next(TimerNode value) { }

	// RVA: 0x1377B5C
	internal TimerNode get_Prev() { }

	// RVA: 0x1377B64
	internal void set_Prev(TimerNode value) { }

	// RVA: 0x1377B6C
	internal override bool Cancel() { }

	// RVA: 0x1377798
	internal bool Fire() { }

}

// Namespace: 
private class InfiniteTimer
{
	// Fields
	private int cancelled; // 0x18

	// Methods

	// RVA: 0x1377B04
	internal void .ctor() { }

	// RVA: 0x1377D14
	internal override bool get_HasExpired() { }

	// RVA: 0x1377D1C
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

	// RVA: 0x13762CC
	private static void .cctor() { }

	// RVA: 0x137243C
	internal static Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1367F0C
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x1376688
	private static void Prod() { }

	// RVA: 0x13767B8
	private static void ThreadProc() { }

	// RVA: 0x1377208
	private static void StopTimerThread() { }

	// RVA: 0x13771E4
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x1377288
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

	// RVA: 0x1377D44
	public void .ctor() { }

	// RVA: 0x1377EA0
	public string get_Comment() { }

	// RVA: 0x1377EA8
	public void set_Comment(string value) { }

	// RVA: 0x1377F14
	public void set_CommentUri(Uri value) { }

	// RVA: 0x1377F1C
	public void set_HttpOnly(bool value) { }

	// RVA: 0x1377F24
	public void set_Discard(bool value) { }

	// RVA: 0x1377F2C
	public string get_Domain() { }

	// RVA: 0x1377F34
	public void set_Domain(string value) { }

	// RVA: 0x1377FD4
	private string get__Domain() { }

	// RVA: 0x13780C8
	public bool get_Expired() { }

	// RVA: 0x13781B0
	public void set_Expires(DateTime value) { }

	// RVA: 0x13781B8
	public string get_Name() { }

	// RVA: 0x13781C0
	internal bool InternalSetName(string value) { }

	// RVA: 0x13782F0
	public string get_Path() { }

	// RVA: 0x13782F8
	public void set_Path(string value) { }

	// RVA: 0x137837C
	private string get__Path() { }

	// RVA: 0x13780B8
	internal bool get_Plain() { }

	// RVA: 0x137841C
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1378480
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1378F1C
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1378FB4
	public void set_Port(string value) { }

	// RVA: 0x1379340
	internal int[] get_PortList() { }

	// RVA: 0x1379348
	private string get__Port() { }

	// RVA: 0x1379424
	public bool get_Secure() { }

	// RVA: 0x137942C
	public void set_Secure(bool value) { }

	// RVA: 0x1379434
	public string get_Value() { }

	// RVA: 0x137943C
	public void set_Value(string value) { }

	// RVA: 0x13794B8
	internal CookieVariant get_Variant() { }

	// RVA: 0x13794C0
	internal string get_DomainKey() { }

	// RVA: 0x13794DC
	public int get_Version() { }

	// RVA: 0x13794E4
	public void set_Version(int value) { }

	// RVA: 0x1379564
	private string get__Version() { }

	// RVA: 0x1379674
	internal static IComparer GetComparer() { }

	// RVA: 0x13796F0
	public override bool Equals(object comparand) { }

	// RVA: 0x13797D8
	public override int GetHashCode() { }

	// RVA: 0x13799CC
	public override string ToString() { }

	// RVA: 0x1379D24
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

	// RVA: 0x1239D4C
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x1239D78
	internal CookieToken get_Token() { }

	// RVA: 0x1239768
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

	// RVA: 0x1238D58
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1238D9C
	internal bool get_EndOfCookie() { }

	// RVA: 0x1238DA4
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1238DAC
	internal bool get_Eof() { }

	// RVA: 0x1238DBC
	internal string get_Name() { }

	// RVA: 0x1238DC4
	internal void set_Name(string value) { }

	// RVA: 0x1238DCC
	internal bool get_Quoted() { }

	// RVA: 0x1238DD4
	internal void set_Quoted(bool value) { }

	// RVA: 0x1238DDC
	internal CookieToken get_Token() { }

	// RVA: 0x1238DE4
	internal void set_Token(CookieToken value) { }

	// RVA: 0x1238DEC
	internal string get_Value() { }

	// RVA: 0x1238DF4
	internal void set_Value(string value) { }

	// RVA: 0x1238DFC
	internal string Extract() { }

	// RVA: 0x1238E94
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x12391DC
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x12394F0
	internal void Reset() { }

	// RVA: 0x123957C
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1239790
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CookieParser
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x1239D80
	internal void .ctor(string cookieString) { }

	// RVA: 0x1239E1C
	internal Cookie Get() { }

	// RVA: 0x123A3CC
	internal static string CheckQuoted(string value) { }

}

// Namespace: System.Net
internal class Comparer
{
	// Methods

	// RVA: 0x123A48C
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x123A574
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

	// RVA: 0x123B5B0
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x123B61C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x123B6C4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x123B764
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

	// RVA: 0x123A57C
	public void .ctor() { }

	// RVA: 0x123A634
	public Cookie get_Item(int index) { }

	// RVA: 0x123A728
	public void Add(Cookie cookie) { }

	// RVA: 0x123ABB4
	public void Add(CookieCollection cookies) { }

	// RVA: 0x123AF4C
	public int get_Count() { }

	// RVA: 0x123AF74
	public bool get_IsSynchronized() { }

	// RVA: 0x123AF7C
	public object get_SyncRoot() { }

	// RVA: 0x123AF80
	public void CopyTo(Array array, int index) { }

	// RVA: 0x123AFA8
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0x123B0B0
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x123B0B8
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x123A7EC
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x123B588
	internal void RemoveAt(int idx) { }

	// RVA: 0x123AEA4
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields
	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Methods

	// RVA: 0x123B770
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x123B79C
	internal string get_Name() { }

	// RVA: 0x123B7A4
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

	// RVA: 0x123B7AC
	public void .ctor() { }

	// RVA: 0x123B8D8
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x123BA18
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x123C8C4
	private bool AgeCookies(string domain) { }

	// RVA: 0x123DDB8
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x123DF8C
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x123E41C
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x123EAF0
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x123EE38
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x123F754
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x123F984
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x123FA80
	internal string GetCookieHeader(Uri uri, string optCookie2) { }

	// RVA: 0x123FE1C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private class PathListComparer
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x123FF50
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x12400F0
	public void .ctor() { }

	// RVA: 0x12400F8
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
internal class PathList
{
	// Fields
	private SortedList m_list; // 0x10

	// Methods

	// RVA: 0x123C27C
	public void .ctor() { }

	// RVA: 0x123DF64
	public int get_Count() { }

	// RVA: 0x123C334
	public int GetCookiesCount() { }

	// RVA: 0x123DD90
	public ICollection get_Values() { }

	// RVA: 0x123C788
	public object get_Item(string s) { }

	// RVA: 0x123C7B0
	public void set_Item(string s, object value) { }

	// RVA: 0x123F72C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x123C760
	public object get_SyncRoot() { }

}

// Namespace: System.Net
[Serializable]
public class CookieException
{
	// Methods

	// RVA: 0x1240164
	public void .ctor() { }

	// RVA: 0x123C274
	internal void .ctor(string message) { }

	// RVA: 0x123DD88
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x124016C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1240174
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124017C
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

	// RVA: 0x1240184
	internal void .ctor(Uri uri) { }

	// RVA: 0x1240314
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1240748
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1240754
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1240A24
	internal bool get_Aborted() { }

	// RVA: 0x1240A34
	public override Int64 get_ContentLength() { }

	// RVA: 0x1240A3C
	public override ICredentials get_Credentials() { }

	// RVA: 0x1240A44
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1240A4C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1240A54
	public override string get_Method() { }

	// RVA: 0x1240A5C
	public override void set_Method(string value) { }

	// RVA: 0x1240B58
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1240B60
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1240B68
	public override int get_Timeout() { }

	// RVA: 0x1240B70
	public override Uri get_RequestUri() { }

	// RVA: 0x1240B78
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1240EA8
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x124118C
	public override WebResponse GetResponse() { }

	// RVA: 0x12414FC
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1241828
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1241ED8
	internal void UnblockReader() { }

	// RVA: 0x1241FC8
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1241FF8
	public override void Abort() { }

	// RVA: 0x1242374
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator
{
	// Methods

	// RVA: 0x1242464
	internal void .ctor() { }

	// RVA: 0x124246C
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1241780
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x12424D0
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1242590
	protected override void Dispose(bool disposing) { }

	// RVA: 0x124266C
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x12426AC
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1242844
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1242958
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1242A6C
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1242B14
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1242C28
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x12427C0
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

	// RVA: 0x1241B64
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x1242CD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1242F58
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1242F64
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124314C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x12431F0
	public override Uri get_ResponseUri() { }

	// RVA: 0x1243170
	private void CheckDisposed() { }

	// RVA: 0x1243214
	public override void Close() { }

	// RVA: 0x12432B8
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x124343C
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

	// RVA: 0x1243498
	public void .ctor() { }

	// RVA: 0x124350C
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x12438DC
	public ICredentials get_Credentials() { }

	// RVA: 0x12438E4
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x124396C
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1243A00
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x12435E4
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x1243D74
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x1243F28
	private bool IsLocal(Uri host) { }

	// RVA: 0x12440C4
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x12441CC
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1243C84
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1244368
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124477C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1244788
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124491C
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x1244924
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x1244988
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1244770
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x1243BFC
	private bool GetProxyAuto(Uri destination, Uri proxyUri) { }

	// RVA: 0x12442F4
	private bool IsBypassedAuto(Uri destination, bool isBypassed) { }

	// RVA: 0x12449E0
	private static bool AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, bool checkFirstOnly) { }

	// RVA: 0x1244CBC
	private static Uri ProxyUri(string proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine
{
	// Methods

	// RVA: 0x12449BC
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList) { }

	// RVA: 0x1244D64
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList, int syncStatus) { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x124541C
	internal static string ToString(int position) { }

	// RVA: 0x12454BC
	private static void .cctor() { }

}

// Namespace: 
internal static class HttpApi
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x1244D88
	private static void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper
{
	// Methods

	// RVA: 0x1245D60
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x1245EE4
	internal static SecureString CreateSecureString(string plainString) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods
{}

// Namespace: System.Net
internal static class Logging
{
	// Methods

	// RVA: 0x1240EA0
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

	// RVA: 0x1246274
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
internal class ServerCertValidationCallback
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x1245F94
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x1246024
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x124602C
	internal void Callback(object state) { }

	// RVA: 0x12460E0
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

	// RVA: 0x12462EC
	private static void EnsureModules() { }

	// RVA: 0x12465A8
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x12466AC
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1246B7C
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x1247098
	private static void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient
{
	// Methods

	// RVA: 0x124712C
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1247550
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x12471DC
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1247610
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x124761C
	public string get_AuthenticationType() { }

	// RVA: 0x12465A0
	public void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint
{
	// Methods

	// RVA: 0x1247660
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1247784
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

	// RVA: 0x12479E0
	private void MoveNext() { }

	// RVA: 0x1247D50
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class BufferedReadStream
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x1247798
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x12477CC
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1247938
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

	// RVA: 0x1247DD0
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x1247EF0
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x1247EBC
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x1247EF8
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1247F20
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

	// RVA: 0x1248050
	public void .ctor(string header) { }

	// RVA: 0x1248138
	public string get_Realm() { }

	// RVA: 0x1248164
	public string get_Opaque() { }

	// RVA: 0x1248194
	public string get_Nonce() { }

	// RVA: 0x12481C4
	public string get_Algorithm() { }

	// RVA: 0x12481F4
	public string get_QOP() { }

	// RVA: 0x1248224
	public bool Parse() { }

	// RVA: 0x12486D0
	private void SkipWhitespace() { }

	// RVA: 0x124875C
	private string GetKey() { }

	// RVA: 0x1248460
	private bool GetKeywordAndValue(string key, string value) { }

	// RVA: 0x1248850
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

	// RVA: 0x12489D4
	private static void .cctor() { }

	// RVA: 0x1248A34
	public void .ctor() { }

	// RVA: 0x1248AB0
	public string get_Algorithm() { }

	// RVA: 0x1248AE8
	public string get_Realm() { }

	// RVA: 0x1248B1C
	public string get_Nonce() { }

	// RVA: 0x1248B54
	public string get_Opaque() { }

	// RVA: 0x1248B8C
	public string get_QOP() { }

	// RVA: 0x1248BC4
	public string get_CNonce() { }

	// RVA: 0x1248CDC
	public bool Parse(string challenge) { }

	// RVA: 0x1248DE0
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x1248F4C
	private string HA1(string username, string password) { }

	// RVA: 0x1249088
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x1249174
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x12492F4
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1249950
	public DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Methods

	// RVA: 0x1249958
	private static Hashtable get_Cache() { }

	// RVA: 0x1249AFC
	private static void CheckExpired(int count) { }

	// RVA: 0x124A328
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x124A638
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x124A7E8
	public string get_AuthenticationType() { }

	// RVA: 0x1246598
	public void .ctor() { }

	// RVA: 0x124A82C
	private static void .cctor() { }

}

// Namespace: 
private sealed class GetHostAddressesCallback
{
	// Methods

	// RVA: 0x124AB10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x124B9F0
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x124ABC4
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x124AD20
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public static class Dns
{
	// Methods

	// RVA: 0x124A8C0
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x124AC14
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x124AD2C
	private static bool GetHostByName_icall(string host, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x124AD30
	private static bool GetHostByAddr_icall(string addr, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x124AD34
	private static bool GetHostName_icall(string h_name) { }

	// RVA: 0x124AD38
	private static void Error_11001(string hostName) { }

	// RVA: 0x124ADA0
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x124B134
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x124B2B4
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x124B460
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x124B610
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x124B4D4
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x124B834
	public static string GetHostName() { }

	// RVA: 0x124B8CC
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

	// RVA: 0x124BBA4
	private void MoveNext() { }

	// RVA: 0x124BF18
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class FixedSizeReadStream
{
	// Fields
	private readonly Int64 <ContentLength>k__BackingField; // 0x40
	private Int64 position; // 0x48

	// Methods

	// RVA: 0x124BA04
	public Int64 get_ContentLength() { }

	// RVA: 0x124BA0C
	public void .ctor(WebOperation operation, Stream innerStream, Int64 contentLength) { }

	// RVA: 0x124BA38
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class HttpRequestCreator
{
	// Methods

	// RVA: 0x124BF98
	internal void .ctor() { }

	// RVA: 0x124BFA0
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

	// RVA: 0x12500FC
	public bool get_IsCompleted() { }

	// RVA: 0x1250104
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x125010C
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x124C4F4
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x124F434
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x124FF20
	public void Reset() { }

	// RVA: 0x125012C
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D488C
	private void MoveNext() { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x1250238
	private void MoveNext() { }

	// RVA: 0x12515E0
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

	// RVA: 0x1251660
	private void MoveNext() { }

	// RVA: 0x12522A8
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

	// RVA: 0x1252328
	private void MoveNext() { }

	// RVA: 0x12527D0
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

	// RVA: 0x124C274
	private static void .cctor() { }

	// RVA: 0x124C004
	public void .ctor(Uri uri) { }

	// RVA: 0x124C388
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124C308
	private void ResetAuthorization() { }

	// RVA: 0x124C528
	public Uri get_Address() { }

	// RVA: 0x124C530
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x124C538
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x124C540
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x124C554
	private bool get_MethodWithBuffer() { }

	// RVA: 0x124C660
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x124C668
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x124C670
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x124C6F8
	public override Int64 get_ContentLength() { }

	// RVA: 0x124C700
	internal void set_InternalContentLength(Int64 value) { }

	// RVA: 0x124C708
	internal bool get_ThrowOnError() { }

	// RVA: 0x124C710
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x124C718
	public override ICredentials get_Credentials() { }

	// RVA: 0x124C720
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x124C728
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x124C7A4
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x124C7AC
	public string get_Host() { }

	// RVA: 0x124C904
	public bool get_KeepAlive() { }

	// RVA: 0x124C90C
	public int get_ReadWriteTimeout() { }

	// RVA: 0x124C914
	public override string get_Method() { }

	// RVA: 0x124C91C
	public override void set_Method(string value) { }

	// RVA: 0x124CB78
	public Version get_ProtocolVersion() { }

	// RVA: 0x124CB80
	public override IWebProxy get_Proxy() { }

	// RVA: 0x124CB88
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x124CDD4
	public override Uri get_RequestUri() { }

	// RVA: 0x124CDDC
	public bool get_SendChunked() { }

	// RVA: 0x124CDE4
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x124CDE8
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x124CDF0
	public override int get_Timeout() { }

	// RVA: 0x124CDF8
	public string get_TransferEncoding() { }

	// RVA: 0x124CE50
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x124CEE4
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x124CEEC
	internal bool get_ExpectContinue() { }

	// RVA: 0x124CEF4
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x124CEFC
	internal Uri get_AuthUri() { }

	// RVA: 0x124CF04
	internal bool get_ProxyQuery() { }

	// RVA: 0x124CF40
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x124CF48
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x124CC78
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x124CF60
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x318DB98
	internal static System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationToken cancellationToken) { }

	// RVA: -1
	private static System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationTokenSource cts) { }

	// RVA: 0x30D3DA0
	private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }

	// RVA: 0x124D1B4
	private System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x124D300
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x124D45C
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x124D52C
	private WebException GetWebException(Exception e) { }

	// RVA: 0x124D5DC
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x124D7B4
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x124D874
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x124DA3C
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x124DB90
	public override WebResponse GetResponse() { }

	// RVA: 0x124DCAC
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x124D5B0
	internal bool get_Aborted() { }

	// RVA: 0x124DCB4
	public override void Abort() { }

	// RVA: 0x124DDD8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124DE18
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x124CC10
	private void CheckRequestStarted() { }

	// RVA: 0x124DE58
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x124DE74
	private void RewriteRedirectToGet() { }

	// RVA: 0x124DF04
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x124E4C0
	private string GetHeaders() { }

	// RVA: 0x124EBB8
	private void DoPreAuthenticate() { }

	// RVA: 0x124EDFC
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0x124F158
	private System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x124F41C
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x124F784
	private System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x124F990
	private System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x30D3738
	private bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x124FFA8
	private System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	// RVA: 0x12500C0
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

	// RVA: 0x1252850
	public void .ctor() { }

	// RVA: 0x1252858
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x1251F40
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x1252BA4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1252FAC
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1252FB4
	public override Uri get_ResponseUri() { }

	// RVA: 0x1253058
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1253060
	public virtual string get_StatusDescription() { }

	// RVA: 0x1253084
	public override Stream GetResponseStream() { }

	// RVA: 0x125312C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1253138
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1253304
	public override void Close() { }

	// RVA: 0x1253338
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1253348
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1252FD8
	private void CheckDisposed() { }

	// RVA: 0x1252950
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

	// RVA: 0x12545FC
	public void .ctor(Byte[] chunk) { }

	// RVA: 0x1254630
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

	// RVA: 0x125335C
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1253438
	public int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x125343C
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1253834
	public void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1253860
	private void InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0x125440C
	public bool get_WantMore() { }

	// RVA: 0x1254430
	public bool get_DataAvailable() { }

	// RVA: 0x1254544
	public int get_ChunkLeft() { }

	// RVA: 0x1253D94
	private State ReadBody(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12539A0
	private State GetChunkSize(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12545A4
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1253EDC
	private State ReadCRLF(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1254040
	private State ReadTrailer(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1254550
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

	// RVA: 0x1254C74
	private void MoveNext() { }

	// RVA: 0x1255128
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

	// RVA: 0x12551A8
	private void MoveNext() { }

	// RVA: 0x1255784
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class MonoChunkStream
{
	// Fields
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Methods

	// RVA: 0x1254694
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x125469C
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x1254854
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12549C0
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1254ACC
	private static void ThrowExpectingChunkTrailer() { }

	// RVA: 0x1254B2C
	private Task <>n__0(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class NtlmClient
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Methods

	// RVA: 0x12557F0
	public void .ctor() { }

	// RVA: 0x1255868
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1255948
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1255950
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

	// RVA: 0x1255994
	internal void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1255D20
	internal SPKey get_Key() { }

	// RVA: 0x1255D28
	private ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1255D30
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x1255D38
	public Uri get_Address() { }

	// RVA: 0x1255D40
	public int get_ConnectionLimit() { }

	// RVA: 0x1255D48
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x1255D50
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x1255D58
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x1255D60
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x1255D68
	internal bool get_SendContinue() { }

	// RVA: 0x1255E10
	internal void set_SendContinue(bool value) { }

	// RVA: 0x1255E18
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x1255EC8
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x125603C
	private static void PutBytes(Byte[] bytes, UInt32 v, int offset) { }

	// RVA: 0x12560C0
	internal bool get_UsesProxy() { }

	// RVA: 0x12560C8
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x12560D0
	internal bool get_UseConnect() { }

	// RVA: 0x12560D8
	internal void set_UseConnect(bool value) { }

	// RVA: 0x12560E0
	private bool get_HasTimedOut() { }

	// RVA: 0x125624C
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x1256648
	internal void SetVersion(Version version) { }

	// RVA: 0x1256650
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x125691C
	internal void FreeServicePoint() { }

	// RVA: 0x1256930
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x1256988
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x12569E0
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

	// RVA: 0x1257714
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x125782C
	public bool get_UsesProxy() { }

	// RVA: 0x1257898
	public override int GetHashCode() { }

	// RVA: 0x1257978
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

	// RVA: 0x1256C2C
	private static void .cctor() { }

	// RVA: 0x1256CF0
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x1256D6C
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x1256DE8
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x1256E64
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x1256EE0
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1256F5C
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1257008
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x1257770
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

	// RVA: 0x1259B58
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1257C80
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x12584B0
	public bool IsEmpty() { }

	// RVA: 0x1258F08
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x12590D8
	public void Cleanup() { }

	// RVA: 0x1259990
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x125941C
	public WebOperation GetNextOperation() { }

	// RVA: 0x1259C3C
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x1259218
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

	// RVA: 0x125A8BC
	private static void .cctor() { }

	// RVA: 0x125A928
	public void .ctor() { }

	// RVA: 0x125A930
	internal bool <Set>b__4_0(object s) { }

}

// Namespace: 
private class AsyncManualResetEvent
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs; // 0x10

	// Methods

	// RVA: 0x125A85C
	public System.Threading.Tasks.Task<System.Boolean> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x1257EC4
	public void Set() { }

	// RVA: 0x12588AC
	public void Reset() { }

	// RVA: 0x1257BC4
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

	// RVA: 0x125A9E4
	private void MoveNext() { }

	// RVA: 0x125B75C
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

	// RVA: 0x125B7C8
	private void MoveNext() { }

	// RVA: 0x125BD50
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

	// RVA: 0x1257BAC
	private ServicePoint get_ServicePoint() { }

	// RVA: 0x1257BB4
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1257BBC
	public int get_MaxIdleTime() { }

	// RVA: 0x1255AA0
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1257DC4
	public void Run() { }

	// RVA: 0x125819C
	private Task RunScheduler() { }

	// RVA: 0x1258288
	private void Cleanup() { }

	// RVA: 0x1258530
	private void RunSchedulerIteration() { }

	// RVA: 0x1258A6C
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x12593E0
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x1258978
	private bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x1259578
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x1258FB4
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x125969C
	private void FinalCleanup() { }

	// RVA: 0x12567E4
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1259770
	private ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x12599F4
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x1259A00
	private void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x1259A28
	public static System.Threading.Tasks.Task<System.Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x1259B54
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

	// RVA: 0x318DB98
	public Status get_Status() { }

	// RVA: 0x30D3738
	public bool get_Success() { }

	// RVA: 0x30D3CF0
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x318DB98
	public T get_Argument() { }

	// RVA: 0x318DB98
	public void .ctor(T argument) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D488C
	private void MoveNext() { }

	// RVA: 0x30D4CD4
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebCompletionSource<T0>
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion; // 0x0
	private Result currentResult; // 0x0

	// Methods

	// RVA: 0x30D4918
	public void .ctor(bool runAsync) { }

	// RVA: 0x30D3CF0
	internal Result get_CurrentResult() { }

	// RVA: 0x30D3CF0
	internal Task get_Task() { }

	// RVA: 0x318DB98
	public bool TrySetCompleted(T argument) { }

	// RVA: 0x30D3738
	public bool TrySetCompleted() { }

	// RVA: 0x30D3738
	public bool TrySetCanceled() { }

	// RVA: 0x30D3858
	public bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x30D3858
	public bool TrySetException(Exception error) { }

	// RVA: 0x30D488C
	public void ThrowOnError() { }

	// RVA: 0x30D3CF0
	public System.Threading.Tasks.Task<T> WaitForCompletion() { }

}

// Namespace: System.Net
internal class WebCompletionSource
{
	// Methods

	// RVA: 0x125BDD0
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

	// RVA: 0x125D2CC
	private static void .cctor() { }

	// RVA: 0x125D338
	public void .ctor() { }

	// RVA: 0x125D340
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x125D3E4
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

	// RVA: 0x125D4E8
	private void MoveNext() { }

	// RVA: 0x125E32C
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

	// RVA: 0x125E398
	private void MoveNext() { }

	// RVA: 0x125EDF8
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

	// RVA: 0x125EE78
	private void MoveNext() { }

	// RVA: 0x125F7B4
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

	// RVA: 0x125BE28
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x125A828
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x125BE30
	private bool CanReuse() { }

	// RVA: 0x125BE60
	private bool CheckReusable() { }

	// RVA: 0x125BF30
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x125C058
	private System.Threading.Tasks.Task<System.Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x125C1B8
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x125C310
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x125C488
	internal static bool ReadLine(Byte[] buffer, int start, int max, string output) { }

	// RVA: 0x125A128
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x125C6B4
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x125CA1C
	private void Reset() { }

	// RVA: 0x125CB34
	private void Close(bool reset) { }

	// RVA: 0x125CC0C
	private void CloseSocket() { }

	// RVA: 0x1259BA8
	public bool get_Closed() { }

	// RVA: 0x125CF00
	public DateTime get_IdleSince() { }

	// RVA: 0x125A574
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1258CE8
	public bool Continue(WebOperation next) { }

	// RVA: 0x125D254
	private void Dispose(bool disposing) { }

	// RVA: 0x1259B60
	public void Dispose() { }

	// RVA: 0x125CB00
	private void ResetNtlm() { }

	// RVA: 0x125D29C
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x125D2A4
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x125D2AC
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x125D2B4
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x125D2BC
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x125D2C4
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

	// RVA: 0x125F834
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x125F930
	internal HttpWebRequest get_Request() { }

	// RVA: 0x125F938
	internal WebConnection get_Connection() { }

	// RVA: 0x125F940
	internal WebOperation get_Operation() { }

	// RVA: 0x125F948
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x125F968
	public override bool get_CanTimeout() { }

	// RVA: 0x125F970
	public override int get_ReadTimeout() { }

	// RVA: 0x125F978
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x125F9E4
	public override int get_WriteTimeout() { }

	// RVA: 0x125F9EC
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x125FA58
	protected Exception GetException(Exception e) { }

	// RVA: -1
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x125FC24
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x125FFD0
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1260230
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1260384
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x12605C0
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x12606D0
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1260958
	public override void Flush() { }

	// RVA: 0x126095C
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1260AAC
	internal void InternalClose() { }

	// RVA: -1
	protected abstract void Close_internal(bool disposed) { }

	// RVA: 0x1260AB8
	public override void Close() { }

	// RVA: 0x1260ACC
	public override Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0x1260B20
	public override bool get_CanSeek() { }

	// RVA: 0x1260B28
	public override Int64 get_Length() { }

	// RVA: 0x1260B7C
	public override Int64 get_Position() { }

	// RVA: 0x1260BD0
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

	// RVA: 0x1260EB8
	private void MoveNext() { }

	// RVA: 0x1261C88
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

	// RVA: 0x1261CF4
	private void MoveNext() { }

	// RVA: 0x12627A4
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

	// RVA: 0x1260C24
	public HttpWebRequest get_Request() { }

	// RVA: 0x1260C2C
	public Uri get_ConnectUri() { }

	// RVA: 0x125EC80
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x1260C34
	public bool get_Success() { }

	// RVA: 0x1260C3C
	private void set_Success(bool value) { }

	// RVA: 0x1260C44
	public bool get_CloseConnection() { }

	// RVA: 0x1260C4C
	private void set_CloseConnection(bool value) { }

	// RVA: 0x1260C54
	public int get_StatusCode() { }

	// RVA: 0x1260C5C
	private void set_StatusCode(int value) { }

	// RVA: 0x1260C64
	private void set_StatusDescription(string value) { }

	// RVA: 0x1260C6C
	public string[] get_Challenge() { }

	// RVA: 0x1260C74
	private void set_Challenge(string[] value) { }

	// RVA: 0x1260C7C
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x1260C84
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1260C8C
	public Version get_ProxyVersion() { }

	// RVA: 0x1260C94
	private void set_ProxyVersion(Version value) { }

	// RVA: 0x1260C9C
	public Byte[] get_Data() { }

	// RVA: 0x1260CA4
	private void set_Data(Byte[] value) { }

	// RVA: 0x125ECD0
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1260CAC
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1260E08
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

	// RVA: 0x126370C
	private void MoveNext() { }

	// RVA: 0x1264114
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

	// RVA: 0x1262824
	public HttpWebRequest get_Request() { }

	// RVA: 0x126282C
	public WebConnection get_Connection() { }

	// RVA: 0x1262834
	private void set_Connection(WebConnection value) { }

	// RVA: 0x126283C
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1262844
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x126284C
	public BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x1262854
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x126285C
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1259BB8
	public bool get_Aborted() { }

	// RVA: 0x1262A44
	public bool get_Closed() { }

	// RVA: 0x1262AD0
	public void Abort() { }

	// RVA: 0x1262CEC
	public void Close() { }

	// RVA: 0x1262C18
	private void SetCanceled() { }

	// RVA: 0x1263150
	private void SetError(Exception error) { }

	// RVA: 0x1262B20
	private System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(ExceptionDispatchInfo field) { }

	// RVA: 0x1263200
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x126333C
	internal void ThrowIfDisposed() { }

	// RVA: 0x125E234
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x125FF64
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x125F53C
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x12632D8
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ExceptionDispatchInfo field) { }

	// RVA: 0x125CF08
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x12633A8
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x126353C
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x1263590
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x1263604
	public System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }

	// RVA: 0x1263658
	internal System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }

	// RVA: 0x125D19C
	internal void Run() { }

	// RVA: 0x1263660
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x1262E94
	internal void Finish(bool ok, Exception error) { }

	// RVA: 0x12636E4
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

	// RVA: 0x1264D38
	private void MoveNext() { }

	// RVA: 0x126534C
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

	// RVA: 0x1264120
	public WebOperation get_Operation() { }

	// RVA: 0x1264128
	protected Stream get_InnerStream() { }

	// RVA: 0x12547C0
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x1264130
	public override Int64 get_Length() { }

	// RVA: 0x1264170
	public override Int64 get_Position() { }

	// RVA: 0x12641B0
	public override void set_Position(Int64 value) { }

	// RVA: 0x12641F0
	public override bool get_CanSeek() { }

	// RVA: 0x12641F8
	public override bool get_CanRead() { }

	// RVA: 0x1264200
	public override bool get_CanWrite() { }

	// RVA: 0x1264208
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1264248
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1264288
	public override void Flush() { }

	// RVA: 0x12642C8
	protected Exception GetException(Exception e) { }

	// RVA: 0x1264494
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12647B8
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1264A18
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1264B6C
	public sealed override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1254B30
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1264CD0
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

	// RVA: 0x1266400
	private void MoveNext() { }

	// RVA: 0x12667E4
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

	// RVA: 0x1266850
	private void MoveNext() { }

	// RVA: 0x1266E24
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

	// RVA: 0x1266E90
	private void MoveNext() { }

	// RVA: 0x12674B8
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

	// RVA: 0x1267524
	private void MoveNext() { }

	// RVA: 0x12678F4
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

	// RVA: 0x1267960
	private void MoveNext() { }

	// RVA: 0x1268120
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

	// RVA: 0x126818C
	private void MoveNext() { }

	// RVA: 0x1268778
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

	// RVA: 0x12687E4
	private void MoveNext() { }

	// RVA: 0x1268AB8
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

	// RVA: 0x1268B24
	private void MoveNext() { }

	// RVA: 0x12694D4
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

	// RVA: 0x125F618
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x12653CC
	internal Stream get_InnerStream() { }

	// RVA: 0x12653D4
	public bool get_KeepAlive() { }

	// RVA: 0x12653DC
	public override bool get_CanRead() { }

	// RVA: 0x12653E4
	public override bool get_CanWrite() { }

	// RVA: 0x12653EC
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x1265428
	internal int get_WriteBufferLength() { }

	// RVA: 0x1265478
	internal BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x1265578
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x126567C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1265958
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x1265AA8
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1265BE0
	private void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0x1263E70
	internal Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x1265C88
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x1265D98
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1265EA0
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x1265FA4
	private Task WriteChunkTrailer() { }

	// RVA: 0x1265C7C
	internal void KillBuffer() { }

	// RVA: 0x1266094
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1266160
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x12661A0
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x126635C
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

	// RVA: 0x126B0AC
	private void MoveNext() { }

	// RVA: 0x126BB80
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

	// RVA: 0x12699E8
	public void .ctor() { }

	// RVA: 0x126BC00
	internal System.Threading.Tasks.Task<System.Int32> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x126BC40
	internal void <ProcessRead>b__1() { }

	// RVA: 0x126BCB0
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

	// RVA: 0x126BD40
	private void MoveNext() { }

	// RVA: 0x126C394
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

	// RVA: 0x126C414
	private void MoveNext() { }

	// RVA: 0x126D010
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

	// RVA: 0x126D07C
	private void MoveNext() { }

	// RVA: 0x126D9E4
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

	// RVA: 0x1269540
	public WebRequestStream get_RequestStream() { }

	// RVA: 0x1269548
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x1269550
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1269558
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1269560
	private void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1269568
	public string get_StatusDescription() { }

	// RVA: 0x1269570
	private void set_StatusDescription(string value) { }

	// RVA: 0x1269578
	public Version get_Version() { }

	// RVA: 0x1269580
	private void set_Version(Version value) { }

	// RVA: 0x1269588
	public bool get_KeepAlive() { }

	// RVA: 0x1269590
	private void set_KeepAlive(bool value) { }

	// RVA: 0x1263F78
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x1269598
	public override bool get_CanRead() { }

	// RVA: 0x12695A0
	public override bool get_CanWrite() { }

	// RVA: 0x12695A8
	private bool get_ChunkedRead() { }

	// RVA: 0x12695B0
	private void set_ChunkedRead(bool value) { }

	// RVA: 0x12695B8
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1269724
	private System.Threading.Tasks.Task<System.Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12699F0
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x1269AC0
	private bool get_ExpectContent() { }

	// RVA: 0x1269B58
	private void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x126A200
	private System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x126A340
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x126A454
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x126A50C
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x126A5BC
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x126400C
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x126A868
	private bool GetResponse(BufferOffsetSize buffer, int pos, ReadState state) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties
{
	// Methods

	// RVA: 0x126DA50
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x126DB00
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1
	public abstract string get_DomainName() { }

	// RVA: 0x126DB58
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException
{
	// Methods

	// RVA: 0x126DB60
	public void .ctor() { }

	// RVA: 0x126DBD0
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

	// RVA: 0x126DAA8
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties
{
	// Methods

	// RVA: 0x126DBD8
	private static extern int getdomainname(Byte[] name, int len) { }

	// RVA: 0x126DC70
	public override string get_DomainName() { }

	// RVA: 0x126DE7C
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties
{
	// Methods

	// RVA: 0x126DE84
	public void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties
{
	// Methods

	// RVA: 0x126DE8C
	public override string get_DomainName() { }

	// RVA: 0x126DED8
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

	// RVA: 0x126DEE0
	public void .ctor(string procDir) { }

	// RVA: 0x126E098
	private static void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal
{
	// Fields
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Methods

	// RVA: 0x126E13C
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x126E188
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Methods

	// RVA: 0x126E2C4
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x126E2CC
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x126E2D4
	internal static object get_ClassSyncObject() { }

	// RVA: 0x126E38C
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x126E560
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x126E558
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

	// RVA: 0x126E568
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x126E5E4
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x126E5EC
	public void .ctor() { }

	// RVA: 0x126E604
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x126E680
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator
{
	// Methods

	// RVA: 0x126E724
	public object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Methods

	// RVA: 0x126E764
	internal RequestCache get_Cache() { }

	// RVA: 0x126E76C
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

	// RVA: 0x126E774
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x126E7F0
	public RequestCacheLevel get_Level() { }

	// RVA: 0x126E7F8
	public override string ToString() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol
{
	// Methods

	// RVA: 0x126E890
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

	// RVA: 0x126E8D8
	public void .ctor(Socket socket) { }

	// RVA: 0x126EAC8
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x126E8E4
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x126EAD4
	public override bool get_CanRead() { }

	// RVA: 0x126EADC
	public override bool get_CanSeek() { }

	// RVA: 0x126EAE4
	public override bool get_CanWrite() { }

	// RVA: 0x126EAEC
	public override bool get_CanTimeout() { }

	// RVA: 0x126EAF4
	public override int get_ReadTimeout() { }

	// RVA: 0x126ED50
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x126EFC0
	public override int get_WriteTimeout() { }

	// RVA: 0x126F04C
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x126F0D4
	public override Int64 get_Length() { }

	// RVA: 0x126F128
	public override Int64 get_Position() { }

	// RVA: 0x126F17C
	public override void set_Position(Int64 value) { }

	// RVA: 0x126F1D0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x126F224
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x126F60C
	public override int Read(System.Span<System.Byte> destination) { }

	// RVA: 0x126F98C
	public override int ReadByte() { }

	// RVA: 0x126FAD4
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x126FEBC
	public override void Write(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1270204
	public override void WriteByte(Byte value) { }

	// RVA: 0x127033C
	public void Close(int timeout) { }

	// RVA: 0x12703AC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1270620
	protected override void Finalize() { }

	// RVA: 0x12706C0
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1270AD8
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1270DC0
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x12711D8
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x12714C0
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1271C6C
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1271EC8
	public override Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12726E8
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1272940
	public override void Flush() { }

	// RVA: 0x1272944
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x126EDD8
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x1272B64
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

	// RVA: 0x127CE6C
	public void .ctor() { }

}

// Namespace: 
private class TaskSocketAsyncEventArgs<T0>
{
	// Fields
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: 0x30D488C
	internal void .ctor() { }

	// RVA: 0x318DB98
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(bool responsibleForReturningToPool) { }

}

// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0x99

	// Methods

	// RVA: 0x127CE18
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

	// RVA: 0x127DFA4
	private static void .cctor() { }

	// RVA: 0x127E010
	public void .ctor() { }

	// RVA: 0x127E018
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x127E1A0
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x127E2D8
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x127E32C
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

	// RVA: 0x127CE74
	public void .ctor() { }

	// RVA: 0x127CFA4
	public bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x127CFAC
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x1272C08
	public bool Reserve() { }

	// RVA: 0x127CFB4
	private void Release() { }

	// RVA: 0x127D038
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x1272D98
	public System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(Socket socket) { }

	// RVA: 0x127333C
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x127D694
	public ValueTaskSourceStatus GetStatus(Int16 token) { }

	// RVA: 0x127D7E8
	public void OnCompleted(System.Action<System.Object> continuation, object state, Int16 token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x127D278
	private void InvokeContinuation(System.Action<System.Object> continuation, object state, bool forceAsync) { }

	// RVA: 0x127DB64
	public int GetResult(Int16 token) { }

	// RVA: 0x127DCAC
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16 token) { }

	// RVA: 0x127D794
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x127DB10
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x127DC80
	private void ThrowException(SocketError error) { }

	// RVA: 0x127D5AC
	private Exception CreateException(SocketError error) { }

	// RVA: 0x127DDB8
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

	// RVA: 0x127E380
	private static void .cctor() { }

	// RVA: 0x127E3EC
	public void .ctor() { }

	// RVA: 0x127E3F4
	internal CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x127E44C
	internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x127E520
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x127E7E8
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x127EDD0
	internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x127EE28
	internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x127EEFC
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x127F1C4
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x127F600
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x127F6A8
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x127F750
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x127F854
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x127F940
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x127FA2C
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x127FCF8
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x127FE7C
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x1280144
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x1280404
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x12808F4
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x1280BB4
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x1280CD8
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x1280FF4
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x12812C4
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x1281458
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x1281748
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x1281904
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x1281C20
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x1281DB4
	internal void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass240_0
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x127920C
	public void .ctor() { }

	// RVA: 0x1282084
	internal void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x127BA40
	public void .ctor() { }

	// RVA: 0x12821F0
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

	// RVA: 0x127C268
	public void .ctor() { }

	// RVA: 0x12822A4
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

	// RVA: 0x12718A4
	internal System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x1272E50
	private System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x12722C8
	internal ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x12733C4
	private System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1273900
	private static void CompleteAccept(Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x1273C50
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1273B6C
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x1273E04
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1273B04
	private void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x1273E60
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x1274700
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x1274768
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x12747D0
	public IntPtr get_Handle() { }

	// RVA: 0x12747F0
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x12747F8
	public SocketType get_SocketType() { }

	// RVA: 0x1274800
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x1274808
	public void set_DontFragment(bool value) { }

	// RVA: 0x12749AC
	public bool get_DualMode() { }

	// RVA: 0x1274A90
	public void set_DualMode(bool value) { }

	// RVA: 0x1274B10
	private bool get_IsDualMode() { }

	// RVA: 0x1274B28
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x1274B60
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x126FE54
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1275344
	public int SendTo(Byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x126F5A4
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x12756D8
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1275CCC
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x1274510
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1271160
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1271458
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1270A60
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1270D58
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1276610
	private static object get_InternalSyncObject() { }

	// RVA: 0x1276714
	internal bool get_CleanedUp() { }

	// RVA: 0x12740F4
	internal static void InitializeSockets() { }

	// RVA: 0x12767A4
	public void Dispose() { }

	// RVA: 0x1276834
	protected override void Finalize() { }

	// RVA: 0x12704F8
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1272A08
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x1276B90
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1274618
	private void SocketDefaults() { }

	// RVA: 0x12743E8
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, int error) { }

	// RVA: 0x1276D24
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1276EAC
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x1277004
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x1277008
	public bool get_Blocking() { }

	// RVA: 0x1277010
	public void set_Blocking(bool value) { }

	// RVA: 0x12770DC
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, int error) { }

	// RVA: 0x1277224
	internal static void Blocking_icall(IntPtr socket, bool block, int error) { }

	// RVA: 0x1277228
	public bool get_Connected() { }

	// RVA: 0x1276CB0
	public void set_NoDelay(bool value) { }

	// RVA: 0x1277288
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1277390
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x12774E8
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x12774EC
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x127769C
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, int error) { }

	// RVA: 0x1277804
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, int error) { }

	// RVA: 0x1277808
	public Socket Accept() { }

	// RVA: 0x1277AA8
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1277BE0
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x1277F40
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x1277F6C
	public Socket EndAccept(Byte[] buffer, int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1277948
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, int error, bool blocking) { }

	// RVA: 0x12783C0
	private static IntPtr Accept_icall(IntPtr sock, int error, bool blocking) { }

	// RVA: 0x12783C4
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1278620
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error) { }

	// RVA: 0x1278768
	private static void Bind_icall(IntPtr sock, SocketAddress sa, int error) { }

	// RVA: 0x127876C
	public void Listen(int backlog) { }

	// RVA: 0x127885C
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, int error) { }

	// RVA: 0x12789A4
	private static void Listen_icall(IntPtr sock, int backlog, int error) { }

	// RVA: 0x12789A8
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x1278A28
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1278ED0
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x1279214
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1279868
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1279378
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1279AD4
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1278DA0
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1279BA0
	private static void Connect_icall(IntPtr sock, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1279BA4
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1279DF0
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1279CA8
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, int error) { }

	// RVA: 0x1279EBC
	private static void Disconnect_icall(IntPtr sock, bool reuse, int error) { }

	// RVA: 0x127557C
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x127A19C
	private int Receive(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1275740
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x126F878
	public int Receive(System.Span<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x127016C
	public int Send(System.ReadOnlySpan<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x127A504
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1276288
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1276488
	public int EndReceive(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x127A3AC
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127A860
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127A044
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127A864
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127A868
	private int ReceiveFrom(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, SocketError errorCode) { }

	// RVA: 0x127AC74
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x127AED0
	public int EndReceiveFrom(IAsyncResult asyncResult, EndPoint endPoint) { }

	// RVA: 0x127AFE8
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x127AB14
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x127B0BC
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x12751BC
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1274BC8
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x127B370
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1275E60
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x127B694
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1276100
	public int EndSend(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x127B218
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127BA78
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127B0C0
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x127BA7C
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1275378
	public int SendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x127BBE0
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x127BA80
	private static int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x127BC9C
	private static int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x126EB80
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x127BCA0
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x127BE00
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x1274888
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1276A18
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x127BE04
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x1275CD0
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x127BE08
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x127BF78
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x127BF7C
	public void Close() { }

	// RVA: 0x127058C
	public void Close(int timeout) { }

	// RVA: 0x127C010
	internal static void Close_icall(IntPtr socket, int error) { }

	// RVA: 0x12768D0
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, int error) { }

	// RVA: 0x127C014
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, int error) { }

	// RVA: 0x127C018
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x127C088
	private void Linger(IntPtr handle) { }

	// RVA: 0x1276E24
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1279EC0
	private void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x1279F1C
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1277230
	private void ThrowIfUdp() { }

	// RVA: 0x1278070
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x1277DE0
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x127A748
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x127C3AC
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x1278560
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x127C544
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x127C548
	internal static int get_FamilyHint() { }

	// RVA: 0x127C690
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1276724
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x127C694
	private static void .cctor() { }

}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Methods

	// RVA: 0x12822EC
	private static int WSAGetLastError_icall() { }

	// RVA: 0x12744E4
	public void .ctor() { }

	// RVA: 0x12822F0
	internal void .ctor(int error, string message) { }

	// RVA: 0x126F984
	public void .ctor(int errorCode) { }

	// RVA: 0x12751B4
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x12822F8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1282300
	public override string get_Message() { }

	// RVA: 0x127FCF0
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

	// RVA: 0x127C22C
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x12823A0
	public void set_Enabled(bool value) { }

	// RVA: 0x12823A8
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

	// RVA: 0x12823B0
	public void .ctor() { }

	// RVA: 0x12823D4
	public void .ctor(AddressFamily family) { }

	// RVA: 0x12825C0
	public Socket get_Client() { }

	// RVA: 0x12825C8
	public void set_Client(Socket value) { }

	// RVA: 0x12825D0
	public void Connect(string hostname, int port) { }

	// RVA: 0x1282E50
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x1282F50
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1282FC4
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x128300C
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x12831A8
	public NetworkStream GetStream() { }

	// RVA: 0x128330C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12835A8
	public void Dispose() { }

	// RVA: 0x12835B8
	protected override void Finalize() { }

	// RVA: 0x1282540
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

	// RVA: 0x12743EC
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x1283654
	protected override bool ReleaseHandle() { }

	// RVA: 0x1278278
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x1283D64
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x1283F80
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

	// RVA: 0x1284014
	public Socket get_AcceptSocket() { }

	// RVA: 0x128401C
	public void set_AcceptSocket(Socket value) { }

	// RVA: 0x1284024
	public int get_BytesTransferred() { }

	// RVA: 0x128402C
	private void set_BytesTransferred(int value) { }

	// RVA: 0x1284034
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x128403C
	public void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x1284044
	public SocketError get_SocketError() { }

	// RVA: 0x128404C
	public void set_SocketError(SocketError value) { }

	// RVA: 0x1284054
	public void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x128405C
	public object get_UserToken() { }

	// RVA: 0x1284064
	public void set_UserToken(object value) { }

	// RVA: 0x127CEF0
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x1284074
	protected override void Finalize() { }

	// RVA: 0x1284084
	private void Dispose(bool disposing) { }

	// RVA: 0x1284098
	public void Dispose() { }

	// RVA: 0x127C53C
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x1284138
	internal Socket get_CurrentSocket() { }

	// RVA: 0x1284140
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x127C45C
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x1284148
	internal void Complete_internal() { }

	// RVA: 0x128417C
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x12841A4
	public System.Memory<System.Byte> get_MemoryBuffer() { }

	// RVA: 0x12841B0
	public int get_Offset() { }

	// RVA: 0x12841B8
	public int get_Count() { }

	// RVA: 0x12841C0
	public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }

	// RVA: 0x1272C94
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

	// RVA: 0x12841CC
	private static void .cctor() { }

	// RVA: 0x1284238
	public void .ctor() { }

	// RVA: 0x1284240
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

	// RVA: 0x1277DAC
	public IntPtr get_Handle() { }

	// RVA: 0x128406C
	public void .ctor() { }

	// RVA: 0x127C270
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1277D5C
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x127A7D0
	public SocketError get_ErrorCode() { }

	// RVA: 0x12781D4
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x12841C8
	internal override void CompleteDisposed() { }

	// RVA: 0x12806F0
	public void Complete() { }

	// RVA: 0x1279ACC
	public void Complete(bool synch) { }

	// RVA: 0x127BA70
	public void Complete(int total) { }

	// RVA: 0x1279A9C
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x127BA48
	public void Complete(Exception e) { }

	// RVA: 0x127FE54
	public void Complete(Socket s) { }

	// RVA: 0x1280114
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

	// RVA: 0x12842BC
	public bool get_AllowRenegotiation() { }

	// RVA: 0x12842C4
	public string get_TargetHost() { }

	// RVA: 0x12842CC
	public void set_TargetHost(string value) { }

	// RVA: 0x12842D4
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x12842DC
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x12842E4
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x1284384
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x1284424
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x128442C
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1284434
	public void .ctor() { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Methods

	// RVA: 0x1284444
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1284608
	protected Stream get_InnerStream() { }

	// RVA: 0x1284610
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

	// RVA: 0x128472C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1284850
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0x1284864
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1284988
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

	// RVA: 0x128499C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1284A58
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback
{
	// Methods

	// RVA: 0x1284A6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1284B20
	public virtual X509Certificate Invoke(string hostName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x1285238
	public void .ctor() { }

	// RVA: 0x1285CD0
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

	// RVA: 0x1284B34
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x1284C04
	internal string get_InternalTargetHost() { }

	// RVA: 0x1284C70
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x1284CEC
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x1284CF4
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x12850E4
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1284E18
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x1284F18
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x1285240
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x12852AC
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1285330
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x128533C
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x12853A8
	public override bool get_IsAuthenticated() { }

	// RVA: 0x128541C
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x1285488
	public override bool get_CanSeek() { }

	// RVA: 0x1285490
	public override bool get_CanRead() { }

	// RVA: 0x12854A8
	public override bool get_CanTimeout() { }

	// RVA: 0x12854CC
	public override bool get_CanWrite() { }

	// RVA: 0x12854E4
	public override int get_ReadTimeout() { }

	// RVA: 0x1285558
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x12855CC
	public override int get_WriteTimeout() { }

	// RVA: 0x1285640
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x12856B4
	public override Int64 get_Length() { }

	// RVA: 0x1285724
	public override Int64 get_Position() { }

	// RVA: 0x1285794
	public override void set_Position(Int64 value) { }

	// RVA: 0x12857F0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x128584C
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1285874
	public override void Flush() { }

	// RVA: 0x1284B9C
	private void CheckDisposed() { }

	// RVA: 0x128589C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1285984
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12859F8
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1285A6C
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1285AE0
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1285B54
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1285BD8
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1285C40
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1285CC4
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

	// RVA: 0x1285D0C
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

	// RVA: 0x1285D98
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection
{
	// Methods

	// RVA: 0x1285DD4
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection
{
	// Methods

	// RVA: 0x1285E10
	public void .ctor() { }

	// RVA: 0x1285E4C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection
{
	// Methods

	// RVA: 0x1285E88
	public void .ctor() { }

	// RVA: 0x1285EC4
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1285F00
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement
{
	// Methods

	// RVA: 0x1285F3C
	public void .ctor() { }

	// RVA: 0x1285F78
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement
{
	// Methods

	// RVA: 0x1285FB4
	public void .ctor() { }

	// RVA: 0x1285FF0
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element
{
	// Methods

	// RVA: 0x128602C
	public void .ctor() { }

	// RVA: 0x1286068
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup
{
	// Methods

	// RVA: 0x12860A4
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection
{
	// Methods

	// RVA: 0x12860E0
	public void .ctor() { }

	// RVA: 0x128611C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement
{
	// Methods

	// RVA: 0x1286158
	public void .ctor() { }

	// RVA: 0x1286194
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement
{
	// Methods

	// RVA: 0x12861D0
	public void .ctor() { }

	// RVA: 0x128620C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement
{
	// Methods

	// RVA: 0x1286248
	public void .ctor() { }

	// RVA: 0x1286284
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement
{
	// Methods

	// RVA: 0x12862C0
	public void .ctor() { }

	// RVA: 0x12862FC
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection
{
	// Methods

	// RVA: 0x1286338
	public void .ctor() { }

	// RVA: 0x1286374
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection
{
	// Methods

	// RVA: 0x12863B0
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler
{
	// Methods

	// RVA: 0x12863EC
	public void .ctor() { }

	// RVA: 0x1286428
	public virtual object Create(object parent, object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x1286464
	public static void ThrowNotSupportedException() { }

}


