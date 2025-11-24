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

	// RVA: 0xEBF3BC
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0xEBF768
	private static void EnsureInitialized() { }

	// RVA: 0xEBF8F0
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xEBF950
	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags) { }

	// RVA: 0xEBFC64
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xEBFC68
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xEBFED8
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xEBFEDC
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xEC00C0
	public void .ctor() { }

	// RVA: 0xEC00C8
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

	// RVA: 0xEC0148
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0xEC01A8
	internal static void Initialize() { }

	// RVA: 0xEC03D0
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	// RVA: 0xEC03D8
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0xEC03E0
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xEC0310
	private void .ctor() { }

	// RVA: 0xEC044C
	private static void .cctor() { }

}

// Namespace: Mono
internal static class X509Pal
{
	// Methods

	// RVA: 0xEC04CC
	public static X509PalImpl get_Instance() { }

}

// Namespace: Mono
internal class X509PalImplMono
{
	// Methods

	// RVA: 0xEC05F0
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0xEC05F4
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xEC0674
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xEBF6E0
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

	// RVA: 0xEC0684
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xEC07C8
	protected static Byte[] ConvertData(Byte[] data) { }

	// RVA: 0xEBFAB0
	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	// RVA: 0xEBFE58
	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xEC08E8
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0xEC08F0
	public X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0xEC067C
	protected void .ctor() { }

	// RVA: 0xEC0D48
	private static void .cctor() { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xEC0DEC
	public void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper
{
	// Methods

	// RVA: 0xEC0DF4
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xEC0FB0
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug
{
	// Methods

	// RVA: 0xEC125C
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert) { }

	// RVA: 0xEC12FC
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

	// RVA: 0xEC144C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1508
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

	// RVA: 0xEC151C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC15D8
	public virtual IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback
{
	// Methods

	// RVA: 0xEC15EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC16A8
	public virtual IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback
{
	// Methods

	// RVA: 0xEC16BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1778
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback
{
	// Methods

	// RVA: 0xEC178C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1848
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback
{
	// Methods

	// RVA: 0xEC1868
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1924
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

	// RVA: 0xEC1940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC19E0
	public virtual unitytls_errorstate Invoke() { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t
{
	// Methods

	// RVA: 0xEC19F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1AB0
	public virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t
{
	// Methods

	// RVA: 0xEC1AC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1B80
	public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t
{
	// Methods

	// RVA: 0xEC1B94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1C50
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t
{
	// Methods

	// RVA: 0xEC1C64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1D20
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_free_t
{
	// Methods

	// RVA: 0xEC1D34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1DE8
	public virtual void Invoke(unitytls_key* key) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t
{
	// Methods

	// RVA: 0xEC1DFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1EA0
	public virtual IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t
{
	// Methods

	// RVA: 0xEC1EB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC1F70
	public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t
{
	// Methods

	// RVA: 0xEC1F84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2028
	public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t
{
	// Methods

	// RVA: 0xEC203C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC20F0
	public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t
{
	// Methods

	// RVA: 0xEC2104
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC21C0
	public virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t
{
	// Methods

	// RVA: 0xEC21D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2290
	public virtual void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t
{
	// Methods

	// RVA: 0xEC22A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2358
	public virtual void Invoke(unitytls_x509list* list) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t
{
	// Methods

	// RVA: 0xEC236C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2410
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t
{
	// Methods

	// RVA: 0xEC2424
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC24C8
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t
{
	// Methods

	// RVA: 0xEC24E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2584
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t
{
	// Methods

	// RVA: 0xEC25C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2668
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t
{
	// Methods

	// RVA: 0xEC26A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2764
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t
{
	// Methods

	// RVA: 0xEC2778
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2834
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t
{
	// Methods

	// RVA: 0xEC2848
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2904
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t
{
	// Methods

	// RVA: 0xEC2918
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC29D4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t
{
	// Methods

	// RVA: 0xEC29E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2AA4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t
{
	// Methods

	// RVA: 0xEC2AB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2B74
	public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t
{
	// Methods

	// RVA: 0xEC2B88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2C44
	public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t
{
	// Methods

	// RVA: 0xEC2C58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2D14
	public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t
{
	// Methods

	// RVA: 0xEC2D28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2DE4
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t
{
	// Methods

	// RVA: 0xEC2DF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2EB4
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t
{
	// Methods

	// RVA: 0xEC2EC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC2F84
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t
{
	// Methods

	// RVA: 0xEC2F98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC304C
	public virtual void Invoke(unitytls_tlsctx* ctx) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t
{
	// Methods

	// RVA: 0xEC3060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEC311C
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

	// RVA: 0xEC1938
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal static class UnityTls
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Methods

	// RVA: 0xEC142C
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0xEC1430
	public static bool get_IsSupported() { }

	// RVA: 0xEC1164
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

	// RVA: 0xEC3460
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEC3F94
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, unitytls_x509list* nativeCertChain, unitytls_key* nativeKey) { }

	// RVA: 0xEC430C
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEC4314
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xEC431C
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0xEC4324
	public override void Flush() { }

	// RVA: 0xEC4328
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEC4510
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEC46D8
	public override void Renegotiate() { }

	// RVA: 0xEC4718
	public override bool PendingRenegotiation() { }

	// RVA: 0xEC4720
	public override void Shutdown() { }

	// RVA: 0xEC4844
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEC494C
	public override void StartHandshake() { }

	// RVA: 0xEC4B2C
	public override bool ProcessHandshake() { }

	// RVA: 0xEC4D28
	public override void FinishHandshake() { }

	// RVA: 0xEC3130
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEC4E80
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEC3204
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEC52F0
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xEC32D8
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xEC5760
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xEC3394
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xEC5C4C
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions
{
	// Methods

	// RVA: 0xEC3F30
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xEC3F60
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xEC4E60
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xEC13D4
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xEC64EC
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

	// RVA: 0xEC651C
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider
{
	// Methods

	// RVA: 0xEC65BC
	public override string get_Name() { }

	// RVA: 0xEC6600
	public override Guid get_ID() { }

	// RVA: 0xEC667C
	public override bool get_SupportsSslStream() { }

	// RVA: 0xEC6684
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xEC668C
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xEC6694
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xEC669C
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xEC66A4
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xEC6554
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xEC680C
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEC745C
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream
{
	// Methods

	// RVA: 0xEC6774
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEC766C
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

	// RVA: 0xEC5BA8
	internal void .ctor(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder) { }

	// RVA: 0xEC7380
	internal void .ctor(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder) { }

	// RVA: 0xEC76D8
	public override bool get_IsValid() { }

	// RVA: 0xEC770C
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0xEC7714
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0xEC7A24
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0xEC7B28
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xEC7B30
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0xEC7B38
	public override void Reset() { }

	// RVA: 0xEC7BC4
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

	// RVA: 0xEC7BFC
	public int get_EndOffset() { }

	// RVA: 0xEC7C08
	public int get_Remaining() { }

	// RVA: 0xEC7C34
	public void .ctor(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEC7D50
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0xEC7DF8
	public void .ctor(int size) { }

	// RVA: 0xEC7E6C
	public void Reset() { }

	// RVA: 0xEC7EE0
	public void MakeRoom(int size) { }

	// RVA: 0xEC7FB8
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

	// RVA: 0xEC801C
	public int get_UserResult() { }

	// RVA: 0xEC8024
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0xEC802C
	public void .ctor(int result) { }

	// RVA: 0xEC8058
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

	// RVA: 0xEC8644
	private void MoveNext() { }

	// RVA: 0xEC8A70
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

	// RVA: 0xEC8AF0
	private void MoveNext() { }

	// RVA: 0xEC9710
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

	// RVA: 0xEC977C
	private void MoveNext() { }

	// RVA: 0xEC9EA8
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

	// RVA: 0xEC808C
	public MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xEC8094
	public bool get_RunSynchronously() { }

	// RVA: 0xEC809C
	public string get_Name() { }

	// RVA: 0xEC80C4
	public int get_UserResult() { }

	// RVA: 0xEC80CC
	protected void set_UserResult(int value) { }

	// RVA: 0xEC80D4
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEC8174
	internal void RequestRead(int size) { }

	// RVA: 0xEC824C
	internal void RequestWrite() { }

	// RVA: 0xEC8258
	internal System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEC838C
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEC849C
	private System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xEC85D4
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest
{
	// Methods

	// RVA: 0xEC9F28
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEC9FC8
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private int <CurrentSize>k__BackingField; // 0x40

	// Methods

	// RVA: 0xECA3D4
	protected BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xECA3DC
	protected int get_CurrentSize() { }

	// RVA: 0xECA3E4
	protected void set_CurrentSize(int value) { }

	// RVA: 0xECA3EC
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xECA4F8
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest
{
	// Methods

	// RVA: 0xECA56C
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xECA570
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest
{
	// Methods

	// RVA: 0xECA758
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xECA75C
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0xECB218
	public void .ctor() { }

	// RVA: 0xECBC18
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

	// RVA: 0xECA968
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xECAE58
	internal static ChainValidationHelper Create(MobileTlsProvider provider, MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xECAA54
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0xECB01C
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0xECB220
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xECB26C
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xECB274
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, X509Certificate clientCertificate) { }

	// RVA: 0xECB2CC
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xECB4A4
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xECB590
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xECBB38
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

	// RVA: 0xECD790
	private void MoveNext() { }

	// RVA: 0xECE240
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

	// RVA: 0xECE2AC
	private void MoveNext() { }

	// RVA: 0xECEB58
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0xECEBD8
	public void .ctor() { }

	// RVA: 0xECEBE0
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

	// RVA: 0xECEC2C
	private void MoveNext() { }

	// RVA: 0xECF128
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

	// RVA: 0xECF1A8
	private void MoveNext() { }

	// RVA: 0xECF4E4
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

	// RVA: 0xEC746C
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xECBD7C
	public SslStream get_SslStream() { }

	// RVA: 0xECBD84
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xECBD8C
	public MobileTlsProvider get_Provider() { }

	// RVA: 0xECBD94
	internal string get_TargetHost() { }

	// RVA: 0xECBD9C
	private void set_TargetHost(string value) { }

	// RVA: 0xECBDA4
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck) { }

	// RVA: 0xEC9444
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0xECBE70
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0xECC008
	internal static Exception GetInternalError() { }

	// RVA: 0xECC05C
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0xEC8A2C
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xECC0B0
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xECC57C
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xECC44C
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	// RVA: 0xECC6F8
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xECC958
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xECCA30
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xECCAD0
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xECC7F8
	private System.Threading.Tasks.Task<System.Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xEC5644
	internal int InternalRead(Byte[] buffer, int offset, int size, bool outWantMore) { }

	// RVA: 0xECCB70
	private System.ValueTuple<System.Int32,System.Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEC5110
	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0xECCCF0
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEC9D58
	internal System.Threading.Tasks.Task<System.Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xEC95F4
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0xEC9FE8
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0xECA5EC
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xECA7F8
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xECCEA8
	public override bool get_IsAuthenticated() { }

	// RVA: 0xECCFAC
	protected override void Dispose(bool disposing) { }

	// RVA: 0xECD278
	public override void Flush() { }

	// RVA: 0xECD2A0
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0xECD388
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xECD4B4
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xECD4F4
	public override bool get_CanRead() { }

	// RVA: 0xECD544
	public override bool get_CanTimeout() { }

	// RVA: 0xECD568
	public override bool get_CanWrite() { }

	// RVA: 0xECD5D8
	public override bool get_CanSeek() { }

	// RVA: 0xECD5E0
	public override Int64 get_Length() { }

	// RVA: 0xECD604
	public override Int64 get_Position() { }

	// RVA: 0xECD628
	public override void set_Position(Int64 value) { }

	// RVA: 0xECD668
	public override int get_ReadTimeout() { }

	// RVA: 0xECD690
	public override void set_ReadTimeout(int value) { }

	// RVA: 0xECD6B8
	public override int get_WriteTimeout() { }

	// RVA: 0xECD6E0
	public override void set_WriteTimeout(int value) { }

	// RVA: 0xECD708
	private static void .cctor() { }

	// RVA: 0xECD758
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

	// RVA: 0xEC3D84
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xECF550
	internal MonoSslAuthenticationOptions get_Options() { }

	// RVA: 0xECF558
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xEC4824
	public MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0xECF560
	public bool get_IsServer() { }

	// RVA: 0xECF568
	internal string get_TargetHost() { }

	// RVA: 0xECF570
	protected string get_ServerName() { }

	// RVA: 0xECF578
	protected bool get_AskForClientCertificate() { }

	// RVA: 0xECF580
	protected SslProtocols get_EnabledProtocols() { }

	// RVA: 0xECF588
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xECF590
	protected void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }

	// RVA: -1
	public abstract void StartHandshake() { }

	// RVA: -1
	public abstract bool ProcessHandshake() { }

	// RVA: -1
	public abstract void FinishHandshake() { }

	// RVA: 0xECF6D4
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: 0xECF6DC
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

	// RVA: 0xEC4CD0
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0xECF6E4
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0xEC5F7C
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1
	public abstract void Renegotiate() { }

	// RVA: 0xECD1E4
	public void Dispose() { }

	// RVA: 0xECF984
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xECF988
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

	// RVA: 0xEC7464
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

	// RVA: 0xECFA28
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0xECFA30
	protected void .ctor() { }

}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions
{
	// Fields
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0xECFA38
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0xECFA40
	public override bool get_ServerMode() { }

	// RVA: 0xECC3D4
	public void .ctor() { }

	// RVA: 0xECFA48
	public override bool get_AllowRenegotiation() { }

	// RVA: 0xECFA68
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0xECFA88
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0xECFAA8
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0xECFAC8
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0xECFAE8
	public override string get_TargetHost() { }

	// RVA: 0xECFB08
	public override void set_TargetHost(string value) { }

	// RVA: 0xECFB28
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0xECFB68
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xECFB88
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0xECFBA8
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

	// RVA: 0xECAEF8
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0xECFBE8
	internal static void InitializeInternal() { }

	// RVA: 0xED0418
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0xECFFE0
	private static void InitializeProviderRegistration() { }

	// RVA: 0xED0ABC
	private static void PopulateUnityProviders() { }

	// RVA: 0xED0C0C
	private static void PopulateProviders() { }

	// RVA: 0xED0E60
	internal static bool IsBtlsSupported() { }

	// RVA: 0xED0200
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xED0F3C
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0xED0FA4
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

	// RVA: 0xED1600
	private void MoveNext() { }

	// RVA: 0xED1E18
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

	// RVA: 0xED10E8
	internal HttpWebRequest get_Request() { }

	// RVA: 0xED10F0
	internal WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xED10F8
	internal bool get_CertificateValidationFailed() { }

	// RVA: 0xED1100
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0xED1108
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xED13C0
	internal System.Threading.Tasks.Task<System.IO.Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0xED1518
	public void Dispose() { }

	// RVA: 0xED151C
	private void CloseSslStream() { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper
{
	// Methods

	// RVA: 0xED1E98
	internal static object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xED1F48
	private static void .cctor() { }

	// RVA: 0xECBC10
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xED1F9C
	public void .ctor() { }

	// RVA: 0xED1FAC
	internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xED1FA4
	public void .ctor() { }

	// RVA: 0xED1FD4
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers
{
	// Methods

	// RVA: 0xED12DC
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	// RVA: 0xECB134
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: Mono.Http
internal class NtlmSession
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xED1FFC
	public void .ctor() { }

	// RVA: 0xED2004
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

	// RVA: 0xED2938
	private static void .cctor() { }

	// RVA: 0xED29A4
	public void .ctor() { }

	// RVA: 0xED29AC
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Mono.Http
internal class NtlmClient
{
	// Fields
	private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache; // 0x0

	// Methods

	// RVA: 0xED24C0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xED2848
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xED2850
	public string get_AuthenticationType() { }

	// RVA: 0xED2894
	public void .ctor() { }

	// RVA: 0xED289C
	private static void .cctor() { }

}

// Namespace: 
protected internal class BoringBioHandle
{
	// Methods

	// RVA: 0xED2BAC
	public void .ctor(IntPtr handle) { }

	// RVA: 0xED2BC0
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBio
{
	// Methods

	// RVA: 0xED2A04
	internal void .ctor(BoringBioHandle handle) { }

	// RVA: 0xED2A6C
	protected internal BoringBioHandle get_Handle() { }

	// RVA: 0xED2B14
	private static extern void mono_btls_bio_free(IntPtr handle) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory
{
	// Methods

	// RVA: 0xED2C68
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0xED2CEC
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, IntPtr data) { }

	// RVA: 0xED2D7C
	public void .ctor() { }

	// RVA: 0xED2E5C
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

	// RVA: 0xED3CB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED4444
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength, int wantMore) { }

}

// Namespace: 
private sealed class BioWriteFunc
{
	// Methods

	// RVA: 0xED3D5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED4458
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

}

// Namespace: 
private sealed class BioControlFunc
{
	// Methods

	// RVA: 0xED3E00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED446C
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

	// RVA: 0xED3798
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0xED3C34
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0xED3EA4
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0xED3F54
	private Int64 Control(ControlCommand command, Int64 arg) { }

	// RVA: 0xED404C
	private int OnRead(IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xED3310
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xED41E8
	private int OnWrite(IntPtr data, int dataLength) { }

	// RVA: 0xED34A4
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	// RVA: 0xED3620
	private static Int64 Control(IntPtr instance, ControlCommand command, Int64 arg) { }

	// RVA: 0xED4320
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

	// RVA: 0xED4480
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xED44CC
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0xED4710
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0xED4A1C
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0xED4F40
	private int ServerNameCallback() { }

	// RVA: 0xED4FA8
	public override void StartHandshake() { }

	// RVA: 0xED4C50
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0xED5550
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0xED5DD8
	public override bool ProcessHandshake() { }

	// RVA: 0xED5FE4
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0xED6218
	public override void FinishHandshake() { }

	// RVA: 0xED50E4
	private void InitializeConnection() { }

	// RVA: 0xED4AF4
	private void GetPeerCertificate() { }

	// RVA: 0xED6240
	private void InitializeSession() { }

	// RVA: 0xED6B50
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0xED6BB8
	public override void Flush() { }

	// RVA: 0xED6BF8
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0xED6EF4
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xED71A8
	public override void Renegotiate() { }

	// RVA: 0xED71E8
	public override void Shutdown() { }

	// RVA: 0xED723C
	public override bool PendingRenegotiation() { }

	// RVA: 0x30A27C0
	private void Dispose(T disposable) { }

	// RVA: 0xED725C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xED73E8
	private int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, bool wantMore) { }

	// RVA: 0xED7404
	private bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xED7420
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0xED7424
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xED7428
	public override bool get_IsAuthenticated() { }

	// RVA: 0xED7430
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xED7438
	public override X509Certificate2 get_RemoteCertificate() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsError
{
	// Methods

	// RVA: 0xED7440
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0xED74C4
	private static extern int mono_btls_error_get_error_line(IntPtr file, int line) { }

	// RVA: 0xED7554
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0xED75EC
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0xED5F60
	public static void ClearError() { }

	// RVA: 0xED5B8C
	public static string GetErrorString(int error) { }

	// RVA: 0xED5934
	public static int GetError(string file, int line) { }

	// RVA: 0xED5AF4
	public static int GetErrorReason(int error) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsException
{
	// Methods

	// RVA: 0xED7684
	public void .ctor() { }

	// RVA: 0xED5A40
	public void .ctor(MonoBtlsSslError error) { }

	// RVA: 0xED5D6C
	public void .ctor(string message) { }

	// RVA: 0xED770C
	public void .ctor(string format, object[] args) { }

}

// Namespace: 
internal class BoringKeyHandle
{
	// Methods

	// RVA: 0xED80F8
	internal void .ctor(IntPtr handle) { }

	// RVA: 0xED8338
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsKey
{
	// Methods

	// RVA: 0xED7798
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0xED781C
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0xED78B4
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0xED794C
	private static extern int mono_btls_key_get_bytes(IntPtr handle, IntPtr data, int size, int include_private_bits) { }

	// RVA: 0xED79F4
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	// RVA: 0xED7A94
	internal BoringKeyHandle get_Handle() { }

	// RVA: 0xED7B18
	internal void .ctor(BoringKeyHandle handle) { }

	// RVA: 0xED7B4C
	public Byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0xED7EA0
	public MonoBtlsKey Copy() { }

	// RVA: 0xED8104
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

}

// Namespace: 
protected internal abstract class MonoBtlsHandle
{
	// Methods

	// RVA: 0xED2BB8
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0xED8758
	public override bool get_IsInvalid() { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject
{
	// Fields
	private MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Methods

	// RVA: 0xED2A38
	internal void .ctor(MonoBtlsHandle handle) { }

	// RVA: 0xED2AF0
	internal MonoBtlsHandle get_Handle() { }

	// RVA: 0xED83BC
	public bool get_IsValid() { }

	// RVA: 0xED8078
	protected void CheckThrow() { }

	// RVA: 0xED41A4
	protected Exception SetException(Exception ex) { }

	// RVA: 0xED3190
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0xED7DFC
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0xED6038
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0xED83E4
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0xED7E08
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0xED847C
	protected virtual void Close() { }

	// RVA: 0xED8480
	protected void Dispose(bool disposing) { }

	// RVA: 0xED860C
	public void Dispose() { }

	// RVA: 0xED86AC
	protected override void Finalize() { }

}

// Namespace: 
internal class BoringPkcs12Handle
{
	// Methods

	// RVA: 0xED8D30
	public void .ctor(IntPtr handle) { }

	// RVA: 0xED9468
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Methods

	// RVA: 0xED8768
	internal BoringPkcs12Handle get_Handle() { }

	// RVA: 0xED87EC
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0xED8884
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0xED8908
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0xED89A0
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0xED8A30
	private static extern int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	// RVA: 0xED8B20
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0xED8BB8
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0xED8C50
	internal void .ctor() { }

	// RVA: 0xED8D3C
	public int get_Count() { }

	// RVA: 0xED8E44
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0xED903C
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0xED9154
	public bool get_HasPrivateKey() { }

	// RVA: 0xED924C
	public MonoBtlsKey GetPrivateKey() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsProvider
{
	// Methods

	// RVA: 0xED94EC
	public override Guid get_ID() { }

	// RVA: 0xED9568
	public override string get_Name() { }

	// RVA: 0xED0E64
	internal void .ctor() { }

	// RVA: 0xED95AC
	public override bool get_SupportsSslStream() { }

	// RVA: 0xED95B4
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xED95BC
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xED95C4
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xED95CC
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xED95D4
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xED966C
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0xED9894
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0xED9814
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0xED6740
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0xED99AC
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEDA590
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0xEDA020
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEDA878
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0xED63EC
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEDAAF0
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0xEDAB80
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0xEDABDC
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0xEDAAB4
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xED69D4
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0xEDA4FC
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0xEDAC38
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0xEDA10C
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsVerifyCallback
{
	// Methods

	// RVA: 0x125DC2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125DD4C
	public virtual int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsSelectCallback
{
	// Methods

	// RVA: 0x125DD60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125DE14
	public virtual int Invoke(string[] acceptableIssuers) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsServerNameCallback
{
	// Methods

	// RVA: 0x125DE28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125DEC8
	public virtual int Invoke() { }

}

// Namespace: 
internal class BoringSslHandle
{
	// Methods

	// RVA: 0x125EFCC
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12612F4
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class PrintErrorsCallbackFunc
{
	// Methods

	// RVA: 0x125F140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1261388
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

	// RVA: 0x125E06C
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x125E104
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x125E19C
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x125E22C
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x125E2BC
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x125E34C
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x125E3E4
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x125E47C
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x125E514
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x125E5A8
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x125E640
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x125E6D0
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x125E760
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x125E7F8
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x125E88C
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x125E91C
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x125E9B4
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x125EA4C
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x125EAE4
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x125EB74
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x125EC04
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x125EC9C
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x125ED2C
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x125EDC4
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x125EFD8
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x125F1E4
	internal BoringSslHandle get_Handle() { }

	// RVA: 0x125F268
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x125F398
	private Exception ThrowError(string callerName) { }

	// RVA: 0x125F720
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x125F868
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x125FA80
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x125FBC0
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x125FD54
	public MonoBtlsSslError Accept() { }

	// RVA: 0x125FE60
	public MonoBtlsSslError Connect() { }

	// RVA: 0x125FF6C
	public MonoBtlsSslError Handshake() { }

	// RVA: 0x125DEDC
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x125F580
	public string GetErrors() { }

	// RVA: 0x1260078
	public void PrintErrors() { }

	// RVA: 0x12601F8
	public MonoBtlsSslError Read(IntPtr data, int dataSize) { }

	// RVA: 0x126035C
	public MonoBtlsSslError Write(IntPtr data, int dataSize) { }

	// RVA: 0x1260568
	public int GetVersion() { }

	// RVA: 0x1260678
	public int GetCipher() { }

	// RVA: 0x12607EC
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x12609B8
	public void SetServerName(string name) { }

	// RVA: 0x1260C00
	public string GetServerName() { }

	// RVA: 0x1260D84
	public void Shutdown() { }

	// RVA: 0x1260EA0
	public void SetQuietShutdown() { }

	// RVA: 0x1260F9C
	protected override void Close() { }

	// RVA: 0x12610F4
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x12611FC
	public bool RenegotiatePending() { }

}

// Namespace: 
internal class BoringSslCtxHandle
{
	// Methods

	// RVA: 0x1262214
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1263FEC
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class NativeVerifyFunc
{
	// Methods

	// RVA: 0x1262664
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1264070
	public virtual int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

}

// Namespace: 
private sealed class NativeSelectFunc
{
	// Methods

	// RVA: 0x1262708
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1264084
	public virtual int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

}

// Namespace: 
private sealed class NativeServerNameFunc
{
	// Methods

	// RVA: 0x12627AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1264098
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

	// RVA: 0x125EF48
	internal BoringSslCtxHandle get_Handle() { }

	// RVA: 0x1261AE0
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x1261B64
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x1261BFC
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x1261C8C
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x1261D24
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x1261DB4
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x1261E44
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x1261ED4
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x1261F7C
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x126200C
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x12620B4
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x1262144
	public void .ctor() { }

	// RVA: 0x1262220
	internal void .ctor(BoringSslCtxHandle handle) { }

	// RVA: 0x1262880
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x1262888
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	// RVA: 0x126139C
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x12617A8
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x126294C
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x1263038
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x12631D0
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x12632EC
	public void SetMinVersion(int version) { }

	// RVA: 0x12633F4
	public void SetMaxVersion(int version) { }

	// RVA: 0x12634FC
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	// RVA: 0x1263778
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x12639E4
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x1263E68
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	// RVA: 0x126196C
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x1263F84
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

	// RVA: 0x12640AC
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x1264148
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils
{
	// Fields
	private static Byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x12641B8
	public static bool Compare(Byte[] a, Byte[] b) { }

	// RVA: 0x126422C
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x1262EF0
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1264F58
	private static void .cctor() { }

}

// Namespace: 
internal class BoringX509Handle
{
	// Methods

	// RVA: 0x12609A4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1266290
	protected override bool ReleaseHandle() { }

	// RVA: 0x1266328
	public IntPtr StealHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509
{
	// Methods

	// RVA: 0x125F9FC
	internal BoringX509Handle get_Handle() { }

	// RVA: 0x12609B0
	internal void .ctor(BoringX509Handle handle) { }

	// RVA: 0x1264FFC
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x1265094
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x126512C
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x12651C4
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x126525C
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x12652EC
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x1265380
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x1265410
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x12655D0
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x1265898
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x1265AA0
	public Int64 GetSubjectNameHash() { }

	// RVA: 0x1265CF8
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x1265FB4
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x1266118
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

}

// Namespace: 
internal class BoringX509ChainHandle
{
	// Methods

	// RVA: 0x12667FC
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1266E44
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain
{
	// Methods

	// RVA: 0x1266338
	internal BoringX509ChainHandle get_Handle() { }

	// RVA: 0x12663BC
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x1266440
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x12664D8
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x1266568
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x12665F8
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x1266690
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x1266728
	public void .ctor() { }

	// RVA: 0x1266808
	internal void .ctor(BoringX509ChainHandle handle) { }

	// RVA: 0x1266810
	public int get_Count() { }

	// RVA: 0x1266918
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x1266B18
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1266C84
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

	// RVA: 0x126744C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1267FF0
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

	// RVA: 0x1266EC8
	internal BoringX509LookupHandle get_Handle() { }

	// RVA: 0x1266F4C
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1266FDC
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1267074
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x1267104
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x126719C
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x1267234
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1267458
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x12674B4
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x12675BC
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1267804
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x1267B98
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x1267D84
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509LookupMonoHandle
{
	// Methods

	// RVA: 0x1268868
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1268A08
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class BySubjectFunc
{
	// Methods

	// RVA: 0x1268874
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1268A8C
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

	// RVA: 0x1267ABC
	internal BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x12683DC
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x1268460
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x12684F8
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x1268590
	internal void .ctor() { }

	// RVA: 0x1267B40
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x1268918
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x1268074
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, IntPtr x509_ptr) { }

	// RVA: 0x126893C
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

	// RVA: 0x1268AA0
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1268AE4
	private void Initialize() { }

	// RVA: 0x1268CCC
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x1268D84
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

	// RVA: 0x1265A68
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1269430
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name
{
	// Methods

	// RVA: 0x1268ED4
	private static extern Int64 mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x1268F6C
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x1269004
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x1269094
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x126913C
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, IntPtr data) { }

	// RVA: 0x12691D4
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, int tag, IntPtr str) { }

	// RVA: 0x126927C
	private static extern IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	// RVA: 0x1269314
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x12693AC
	internal BoringX509NameHandle get_Handle() { }

	// RVA: 0x1265A98
	internal void .ctor(BoringX509NameHandle handle) { }

	// RVA: 0x1265BF0
	public Int64 GetHash() { }

	// RVA: 0x1264E50
	public int GetEntryCount() { }

	// RVA: 0x12645F0
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x1264BB4
	public string GetEntryOid(int index) { }

	// RVA: 0x1264730
	public Byte[] GetEntryOidData(int index) { }

	// RVA: 0x1264914
	public string GetEntryValue(int index, int tag) { }

	// RVA: 0x1262D0C
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

	// RVA: 0x1269838
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1269EE4
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store
{
	// Fields
	private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

	// Methods

	// RVA: 0x12673C8
	internal BoringX509StoreHandle get_Handle() { }

	// RVA: 0x12694D0
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x1269554
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x12695EC
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x126967C
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x1269714
	private static BoringX509StoreHandle Create_internal() { }

	// RVA: 0x1269844
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	// RVA: 0x1269960
	internal void .ctor() { }

	// RVA: 0x1262850
	internal void .ctor(BoringSslCtxHandle ctx) { }

	// RVA: 0x1267BB4
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x126998C
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x1269B38
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1269B70
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1269C4C
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509StoreCtxHandle
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x126A690
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x126B4DC
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx
{
	// Fields
	private System.Nullable<System.Int32> verifyResult; // 0x20

	// Methods

	// RVA: 0x1269F68
	internal BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x1269FEC
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x126A070
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x126A108
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, IntPtr error_string) { }

	// RVA: 0x126A198
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x126A230
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x126A2C8
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x126A358
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x126A3F0
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x126A488
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x126A520
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x126A5B8
	internal void .ctor() { }

	// RVA: 0x126A6C0
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x12628B0
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x126A7D4
	internal void .ctor(BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }

	// RVA: 0x126A800
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x126A8F8
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x126AAC0
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x126AC88
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x126AECC
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x126B09C
	public int get_VerifyResult() { }

	// RVA: 0x126B184
	public int Verify() { }

	// RVA: 0x126B310
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

	// RVA: 0x126B57C
	private static void Initialize() { }

	// RVA: 0x126B75C
	private static void DoInitialize() { }

	// RVA: 0x126B8F4
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

	// RVA: 0x126BF90
	public void .ctor(IntPtr handle) { }

	// RVA: 0x126C950
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam
{
	// Methods

	// RVA: 0x1263960
	internal BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x126BA40
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x126BAD8
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x126BB70
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x126BC08
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x126BCA0
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, Int64 time) { }

	// RVA: 0x126BD30
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x126BDC8
	internal void .ctor(BoringX509VerifyParamHandle handle) { }

	// RVA: 0x126BDD0
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x126BF9C
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x126C2BC
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x126BFE4
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail) { }

	// RVA: 0x126C304
	public bool get_CanModify() { }

	// RVA: 0x126C3FC
	private void WantToModify() { }

	// RVA: 0x126C464
	public void SetHost(string name) { }

	// RVA: 0x126C70C
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

	// RVA: 0x126C9D4
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x126CA18
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x126CAD0
	internal void .ctor(Byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x126CB1C
	internal void .ctor(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x126D638
	public override bool get_IsValid() { }

	// RVA: 0x126D64C
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x126D674
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x126D69C
	public override X509CertificateImpl Clone() { }

	// RVA: 0x126D70C
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x126D74C
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x126D754
	protected override void Dispose(bool disposing) { }

	// RVA: 0x126D798
	public override bool get_HasPrivateKey() { }

	// RVA: 0x126D7A8
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x126D7D8
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x126D91C
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x126D94C
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x126CEF4
	private void Import(Byte[] data) { }

	// RVA: 0x126CF60
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	// RVA: 0x126D564
	private void ImportAuthenticode(Byte[] data) { }

	// RVA: 0x126D98C
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

	// RVA: 0x126DC10
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x126DCAC
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x126DFC0
	public override bool get_IsValid() { }

	// RVA: 0x126DFD4
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x126DFFC
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x126E320
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x126E328
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x126E42C
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x126E434
	public override void Reset() { }

	// RVA: 0x126E4E4
	protected override void Dispose(bool disposing) { }

}

// Namespace: Mono.Btls
internal class X509PalImplBtls
{
	// Fields
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Methods

	// RVA: 0x126E644
	public void .ctor(MonoTlsProvider provider) { }

	// RVA: 0x126E760
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x126E768
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0x126E790
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x126E7B0
	public override X509Certificate2Impl Import(X509Certificate cert) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Internal.Cryptography.OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1270F00
	private static void .cctor() { }

	// RVA: 0x1270F6C
	public void .ctor() { }

	// RVA: 0x1270F74
	internal string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

	// RVA: 0x1271040
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

	// RVA: 0x126E7D0
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x126ECE0
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x126E9B8
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x126E9C0
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x126EECC
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x126F1F4
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

	// RVA: 0x1272A0C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1272A44
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1272A48
	private bool MoveNext() { }

	// RVA: 0x1272D1C
	private System.Collections.Generic.KeyValuePair<System.String,System.String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	// RVA: 0x1272D28
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1272D68
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1272DD0
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x1272E78
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

	// RVA: 0x1271108
	internal void .ctor(Byte[] rawData) { }

	// RVA: 0x1271940
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12721D8
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x1272758
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	// RVA: 0x1272984
	private static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(X500DistinguishedName name) { }

}

// Namespace: System
internal static class IPv4AddressHelper
{
	// Methods

	// RVA: 0x1272E7C
	internal static int ParseHostNumber(System.ReadOnlySpan<System.Char> str, int start, int end) { }

	// RVA: 0x1273084
	internal static bool IsValid(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x1272EB0
	private static bool ParseCanonical(System.ReadOnlySpan<System.Char> name, Byte* numbers, int start, int end) { }

	// RVA: 0x12730B0
	internal static bool IsValidCanonical(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x12733D8
	internal static Int64 ParseNonCanonical(Char* name, int start, int end, bool notImplicitFile) { }

	// RVA: 0x12737A0
	internal static string ParseCanonicalName(string str, int start, int end, bool isLoopback) { }

	// RVA: 0x1273C60
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

}

// Namespace: System
internal static class IPv6AddressHelper
{
	// Methods

	// RVA: 0x1273CD0
	internal static System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x1273DC4
	internal static bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x1273EA8
	internal static bool IsValidStrict(Char* name, int start, int end) { }

	// RVA: 0x1274324
	internal static void Parse(System.ReadOnlySpan<System.Char> address, UInt16* numbers, int start, string scopeId) { }

	// RVA: 0x12748C0
	internal static string ParseCanonicalName(string str, int start, bool isLoopback, string scopeId) { }

	// RVA: 0x12751D4
	private static bool IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12752C0
	private static bool InternalIsValid(Char* name, int start, int end, bool validateStrictAddress) { }

	// RVA: 0x12756A0
	internal static bool IsValid(Char* name, int start, int end) { }

}

// Namespace: System
internal static class NotImplemented
{
	// Methods

	// RVA: 0x12756A8
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

	// RVA: 0x1275710
	public void .ctor(Uri uri) { }

	// RVA: 0x12758E8
	private void Init(Uri uri) { }

	// RVA: 0x1275CB8
	public void set_Path(string value) { }

	// RVA: 0x1275D80
	public Uri get_Uri() { }

	// RVA: 0x1275E28
	public override bool Equals(object rparam) { }

	// RVA: 0x1275F14
	public override int GetHashCode() { }

	// RVA: 0x1275AC8
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x1275FCC
	public override string ToString() { }

}

// Namespace: System
internal static class SecurityUtils
{
	// Methods

	// RVA: 0x1276630
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x1276634
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x1276638
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x1276640
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x127664C
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x127676C
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x1276774
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x127677C
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x1276930
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x12769D8
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

	// RVA: 0x1276BCC
	internal void .ctor() { }

	// RVA: 0x1276C80
	public int Compare(object a, object b) { }

	// RVA: 0x1276D7C
	private static void .cctor() { }

}

// Namespace: System
internal static class IriHelper
{
	// Methods

	// RVA: 0x1276DE4
	internal static bool CheckIriUnicodeRange(Char unicode, bool isQuery) { }

	// RVA: 0x1276E3C
	internal static bool CheckIriUnicodeRange(Char highSurr, Char lowSurr, bool surrogatePair, bool isQuery) { }

	// RVA: 0x12774B8
	internal static bool CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0x1277628
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

	// RVA: 0x1278AA8
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

	// RVA: 0x1278AB0
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

	// RVA: 0x1201240
	private bool get_IsImplicitFile() { }

	// RVA: 0x120124C
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x120125C
	private bool get_IsDosPath() { }

	// RVA: 0x1201268
	private bool get_IsUncPath() { }

	// RVA: 0x1201274
	private Flags get_HostType() { }

	// RVA: 0x1201280
	private UriParser get_Syntax() { }

	// RVA: 0x1201288
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x1201298
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x1201360
	private bool get_AllowIdn() { }

	// RVA: 0x120147C
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0x12015B8
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x12015C0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x12015CC
	private void SetUserDrivenParsing() { }

	// RVA: 0x12015E0
	private UInt16 get_SecuredPathIndex() { }

	// RVA: 0x120146C
	private bool NotAny(Flags flags) { }

	// RVA: 0x1201640
	private bool InFact(Flags flags) { }

	// RVA: 0x12015AC
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x1201650
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x120165C
	private UriInfo EnsureUriInfo() { }

	// RVA: 0x1201C9C
	private void EnsureParseRemaining() { }

	// RVA: 0x1202B4C
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1202FD4
	public void .ctor(string uriString) { }

	// RVA: 0x120322C
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x12032BC
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x12033AC
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x1203CC0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x1203F0C
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, string result) { }

	// RVA: 0x1204EC8
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x1205064
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1205184
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1205188
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12052E4
	public string get_AbsolutePath() { }

	// RVA: 0x12053A4
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x12054A0
	public string get_AbsoluteUri() { }

	// RVA: 0x12055DC
	public string get_LocalPath() { }

	// RVA: 0x1205DEC
	public string get_Authority() { }

	// RVA: 0x1205E64
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x1205FB4
	public bool get_IsDefaultPort() { }

	// RVA: 0x1206090
	public bool get_IsFile() { }

	// RVA: 0x1206154
	public bool get_IsLoopback() { }

	// RVA: 0x1206210
	public string get_PathAndQuery() { }

	// RVA: 0x12062D8
	public string[] get_Segments() { }

	// RVA: 0x120652C
	public bool get_IsUnc() { }

	// RVA: 0x12065A4
	public string get_Host() { }

	// RVA: 0x120661C
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x1206638
	private static object get_InitializeLock() { }

	// RVA: 0x120673C
	private static void InitializeUriConfig() { }

	// RVA: 0x120564C
	private string GetLocalPath() { }

	// RVA: 0x1206EF8
	public int get_Port() { }

	// RVA: 0x1206FF0
	public string get_Query() { }

	// RVA: 0x1207130
	public string get_Fragment() { }

	// RVA: 0x1207270
	public string get_Scheme() { }

	// RVA: 0x12072E4
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x12042D8
	public string get_OriginalString() { }

	// RVA: 0x1207340
	public string get_DnsSafeHost() { }

	// RVA: 0x120339C
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x12075B8
	public bool get_UserEscaped() { }

	// RVA: 0x12075C4
	public string get_UserInfo() { }

	// RVA: 0x120763C
	internal static bool IsGenDelim(Char ch) { }

	// RVA: 0x1207660
	public static bool IsHexDigit(Char character) { }

	// RVA: 0x120768C
	public static int FromHex(Char digit) { }

	// RVA: 0x1207720
	public override int GetHashCode() { }

	// RVA: 0x12079CC
	public override string ToString() { }

	// RVA: 0x1207D48
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x1203B04
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x1207D7C
	public override bool Equals(object comparand) { }

	// RVA: 0x12084E4
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x12085A8
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x1208698
	private static ParsingError ParseScheme(string uriString, Flags flags, UriParser syntax) { }

	// RVA: 0x1208DA0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1208E34
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x120A4A8
	private void PrivateParseMinimalIri(string newHost, UInt16 idx) { }

	// RVA: 0x120168C
	private void CreateUriInfo(Flags cF) { }

	// RVA: 0x1202BAC
	private void CreateHostString() { }

	// RVA: 0x120A9EC
	private static string CreateHostStringHelper(string str, UInt16 idx, UInt16 end, Flags flags, string scopeId) { }

	// RVA: 0x120A5A0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x12052E0
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x120B1B8
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x1206E0C
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x120B960
	private string ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0x120B2A8
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1201CAC
	private void ParseRemaining() { }

	// RVA: 0x12087A8
	private static UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ParsingError err, Flags flags, UriParser syntax) { }

	// RVA: 0x120CF0C
	private static bool CheckKnownSchemes(Int64* lptr, UInt16 nChars, UriParser syntax) { }

	// RVA: 0x120417C
	private static ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, UriParser syntax) { }

	// RVA: 0x1209528
	private UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ParsingError err, Flags flags, UriParser syntax, string newHost) { }

	// RVA: 0x120D460
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, Flags flags, bool justNormalized, string newHost, ParsingError err) { }

	// RVA: 0x120D8D4
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, Flags flags, string newHost, ParsingError err) { }

	// RVA: 0x120CDA4
	private void FindEndOfComponent(string input, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x120DDDC
	private void FindEndOfComponent(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x120ABD0
	private Check CheckCanonical(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x120C60C
	private Char[] GetCanonicalPath(Char[] dest, int pos, UriFormat formatAs) { }

	// RVA: 0x120DE88
	private static void UnescapeOnly(Char* pch, int start, int end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0x1206910
	private static Char[] Compress(Char[] dest, UInt16 start, int destLength, UriParser syntax) { }

	// RVA: 0x12078F0
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x120433C
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x120E090
	internal bool get_HasAuthority() { }

	// RVA: 0x12094F8
	private static bool IsLWS(Char ch) { }

	// RVA: 0x1209514
	private static bool IsAsciiLetter(Char character) { }

	// RVA: 0x120E09C
	internal static bool IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0x120E110
	internal static bool IsBidiControlCharacter(Char ch) { }

	// RVA: 0x120DBEC
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	// RVA: 0x1203058
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x120E134
	private void InitializeUri(ParsingError err, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x120E824
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x120E914
	private bool CheckForUnicode(string data) { }

	// RVA: 0x120EA50
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x12083E8
	public static bool TryCreate(string uriString, UriKind uriKind, Uri result) { }

	// RVA: 0x120EF20
	public static bool TryCreate(Uri baseUri, string relativeUri, Uri result) { }

	// RVA: 0x120F05C
	public static bool TryCreate(Uri baseUri, Uri relativeUri, Uri result) { }

	// RVA: 0x120AFDC
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x120F4AC
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x120F9B4
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x120F500
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x120FAB8
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x120FC7C
	public static string EscapeDataString(string stringToEscape) { }

	// RVA: 0x120CEB4
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x120FDB8
	private void .ctor(Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x120EC60
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x1203564
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, string newUriString, bool userEscaped, UriFormatException e) { }

	// RVA: 0x120F240
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x1207ACC
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x120FE10
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x120FEC8
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x1203B4C
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x12100CC
	private static void .cctor() { }

}

// Namespace: System
[Serializable]
public class UriFormatException
{
	// Methods

	// RVA: 0x1278AB8
	public void .ctor() { }

	// RVA: 0x1276440
	public void .ctor(string textString) { }

	// RVA: 0x1278AC0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1278AC8
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

	// RVA: 0x1278AD0
	internal static bool TestForSubPath(Char* pMe, UInt16 meLength, Char* pShe, UInt16 sheLength, bool ignoreCase) { }

	// RVA: 0x1278D4C
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, int destPos, bool isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0x1279460
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, int destPos, int prevInputPos) { }

	// RVA: 0x127992C
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1279A04
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1278168
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x1278998
	internal static void EscapeAsciiChar(Char ch, Char[] to, int pos) { }

	// RVA: 0x127808C
	internal static Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0x12780F4
	internal static bool IsNotSafeForUnescape(Char ch) { }

	// RVA: 0x1279790
	private static bool IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0x1279618
	internal static bool IsUnreserved(Char c) { }

	// RVA: 0x127A558
	internal static bool Is3986Unreserved(Char c) { }

	// RVA: 0x127A628
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

	// RVA: 0x127B4A0
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

	// RVA: 0x127A6CC
	internal string get_SchemeName() { }

	// RVA: 0x127A6D4
	internal int get_DefaultPort() { }

	// RVA: 0x127A6DC
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x127A6E0
	protected virtual void InitializeAndValidate(Uri uri, UriFormatException parsingError) { }

	// RVA: 0x127A71C
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, UriFormatException parsingError) { }

	// RVA: 0x127A940
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x127A960
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x127AB84
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x127A4F4
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x127ABA0
	private static void .cctor() { }

	// RVA: 0x127B59C
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x12765C4
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x1276558
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x127B604
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x127B5A4
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x127B670
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x127B6E4
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x1276448
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x127B9F4
	internal bool get_IsSimple() { }

	// RVA: 0x127BA00
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x127BA6C
	internal void InternalValidate(Uri thisUri, UriFormatException parsingError) { }

	// RVA: 0x127BA78
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, UriFormatException parsingError) { }

	// RVA: 0x127BA84
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x127BA90
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x127BA9C
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: System
internal class DomainNameHelper
{
	// Methods

	// RVA: 0x127BAA8
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x127BC48
	internal static bool IsValid(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x127BE70
	internal static bool IsValidByIri(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x127C068
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x127C3E0
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, string bidiStrippedHost) { }

	// RVA: 0x127C648
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x127C5FC
	private static bool IsIdnAce(Char* input, int index) { }

	// RVA: 0x127C6DC
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	// RVA: 0x127C818
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x127BDE8
	private static bool IsASCIILetterOrDigit(Char character, bool notCanonical) { }

	// RVA: 0x127BE24
	private static bool IsValidDomainLabelCharacter(Char character, bool notCanonical) { }

}

// Namespace: System
internal class UncNameHelper
{
	// Methods

	// RVA: 0x127CDA4
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x127CDAC
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

	// RVA: 0x127D1EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x127D30C
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

	// RVA: 0x127D320
	protected void .ctor() { }

	// RVA: 0x127D328
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x127D37C
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x127D3CC
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x127D3D4
	public object get_AsyncState() { }

	// RVA: 0x127D3DC
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x127D52C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x127D534
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x127D53C
	public bool get_IsCompleted() { }

	// RVA: 0x127D544
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

	// RVA: 0x127D620
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x127D678
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x127D6A4
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x127D6A8
	public void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector
{
	// Methods

	// RVA: 0x127D6CC
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal class SRDescriptionAttribute
{
	// Fields
	private bool isReplaced; // 0x18

	// Methods

	// RVA: 0x127D6D0
	public void .ctor(string description) { }

	// RVA: 0x127D73C
	public override string get_Description() { }

}

// Namespace: System
public class UriTypeConverter
{
	// Methods

	// RVA: 0x127D79C
	public void .ctor() { }

	// RVA: 0x127D7A4
	private bool CanConvert(Type type) { }

	// RVA: 0x127D88C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x127D968
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x127DA10
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x127DBC8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Web
public sealed class HttpUtility
{
	// Methods

	// RVA: 0x127DDC4
	public static string UrlEncode(string str) { }

	// RVA: 0x127DDF0
	public static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x127E050
	public static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Web.Util.HttpEncoder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x127EA0C
	private static void .cctor() { }

	// RVA: 0x127EA78
	public void .ctor() { }

	// RVA: 0x127EA80
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

	// RVA: 0x127E0EC
	public static HttpEncoder get_Current() { }

	// RVA: 0x127E1FC
	private static void .cctor() { }

	// RVA: 0x127E3F4
	public void .ctor() { }

	// RVA: 0x127E3FC
	protected internal virtual Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	// RVA: 0x127E684
	private static HttpEncoder GetCustomEncoderFromConfig() { }

	// RVA: 0x127E474
	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	// RVA: 0x127E030
	internal static bool NotEncoded(Char c) { }

	// RVA: 0x127E72C
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

	// RVA: 0x127EAD8
	internal void .ctor(string text, int index, int length) { }

	// RVA: 0x127EB24
	public int get_Index() { }

	// RVA: 0x127EB2C
	internal void set_Index(int value) { }

	// RVA: 0x127EB34
	public int get_Length() { }

	// RVA: 0x127EB3C
	internal void set_Length(int value) { }

	// RVA: 0x127EB44
	internal string get_Text() { }

	// RVA: 0x127EB4C
	internal void set_Text(string value) { }

	// RVA: 0x127EB54
	public string get_Value() { }

	// RVA: 0x127EB7C
	public override string ToString() { }

	// RVA: 0x127EBA4
	internal System.ReadOnlySpan<System.Char> GetLeftSubstring() { }

	// RVA: 0x127EC48
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

	// RVA: 0x127ECEC
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x127EDB8
	public bool get_Success() { }

	// RVA: 0x127EDC8
	private static void .cctor() { }

	// RVA: 0x127EF48
	internal void .ctor() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x127F3D8
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x128029C
	public bool MoveNext() { }

	// RVA: 0x12802F4
	public Group get_Current() { }

	// RVA: 0x1280384
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1280388
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1280394
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

	// RVA: 0x127EF84
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x127EFD4
	public bool get_IsReadOnly() { }

	// RVA: 0x127EFDC
	public int get_Count() { }

	// RVA: 0x127F004
	public Group get_Item(int groupnum) { }

	// RVA: 0x127F138
	public Group get_Item(string groupname) { }

	// RVA: 0x127F35C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x127F418
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x127F008
	private Group GetGroup(int groupnum) { }

	// RVA: 0x127F494
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x127F810
	public bool get_IsSynchronized() { }

	// RVA: 0x127F818
	public object get_SyncRoot() { }

	// RVA: 0x127F820
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x127F8F4
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x127FABC
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x127FBA0
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x127FBF4
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x127FC48
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x127FC4C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x127FCA0
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x127FCF4
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x127FD48
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x127FE00
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x127FE54
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x127FEA8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x127FEFC
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1280000
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1280104
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1280158
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1280160
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12801B4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1280208
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x128020C
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1280260
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

	// RVA: 0x1280398
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x128054C
	public static Match get_Empty() { }

	// RVA: 0x12805C8
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x1280650
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x128070C
	public Match NextMatch() { }

	// RVA: 0x1280A40
	internal virtual System.ReadOnlySpan<System.Char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x1280BF8
	internal System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }

	// RVA: 0x1280C24
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x1280E24
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x1280F04
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x1280F40
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x1280FD8
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x1281070
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x1281108
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x1281284
	private static void .cctor() { }

	// RVA: 0x128132C
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Methods

	// RVA: 0x1281368
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1281424
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

	// RVA: 0x1281904
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x12822A8
	public bool MoveNext() { }

	// RVA: 0x1282314
	public Match get_Current() { }

	// RVA: 0x1282388
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x128238C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1282398
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

	// RVA: 0x12814E4
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x128163C
	public bool get_IsReadOnly() { }

	// RVA: 0x1281644
	public int get_Count() { }

	// RVA: 0x12816C8
	public virtual Match get_Item(int i) { }

	// RVA: 0x1281888
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1281944
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x1281734
	private Match GetMatch(int i) { }

	// RVA: 0x12816B4
	private void EnsureInitialized() { }

	// RVA: 0x12819C0
	public bool get_IsSynchronized() { }

	// RVA: 0x12819C8
	public object get_SyncRoot() { }

	// RVA: 0x12819CC
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1281AAC
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x1281B3C
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x1281BC4
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x1281C18
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x1281C6C
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x1281C7C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x1281CD0
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x1281D24
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x1281D78
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x1281E00
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x1281E54
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1281EA8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1281EFC
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1282000
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1282104
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1282158
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1282160
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12821B4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1282208
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1282218
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x128226C
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

	// RVA: 0x128239C
	public RegexRunner Get() { }

	// RVA: 0x128242C
	public void Release(RegexRunner obj) { }

	// RVA: 0x128253C
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

	// RVA: 0x1285088
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x128545C
	public override bool Equals(object obj) { }

	// RVA: 0x128551C
	public bool Equals(CachedCodeEntryKey other) { }

	// RVA: 0x1282698
	public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	// RVA: 0x1285588
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

	// RVA: 0x1282EEC
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

	// RVA: 0x1282544
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x128270C
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1282FCC
	private void FillCacheDictionary() { }

	// RVA: 0x12830E4
	private static bool TryGetCacheValue(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x128321C
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x1282C74
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	// RVA: 0x128347C
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x1283560
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1283958
	public bool IsMatch(string input) { }

	// RVA: 0x12839E4
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x1283A6C
	public static Match Match(string input, string pattern) { }

	// RVA: 0x1283B50
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1283BE0
	public Match Match(string input) { }

	// RVA: 0x1283C60
	public Match Match(string input, int startat) { }

	// RVA: 0x1283CDC
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x1283DC0
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1283E50
	public MatchCollection Matches(string input) { }

	// RVA: 0x1283ED0
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x1283FA4
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x128409C
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x128413C
	public string Replace(string input, string replacement) { }

	// RVA: 0x12841C4
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x12842A0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x128438C
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x128442C
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x12844B4
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x1284588
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x12849D8
	private static void .cctor() { }

	// RVA: 0x1284D88
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x1284B28
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x1284F44
	public void .ctor(string pattern) { }

	// RVA: 0x1284FC0
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x1285048
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x12835F0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x1285334
	public static string Escape(string str) { }

	// RVA: 0x12853F0
	public RegexOptions get_Options() { }

	// RVA: 0x12849CC
	public bool get_RightToLeft() { }

	// RVA: 0x12853F8
	public override string ToString() { }

	// RVA: 0x127F6AC
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x127F1F0
	public int GroupNumberFromName(string name) { }

	// RVA: 0x1285220
	protected void InitializeReferences() { }

	// RVA: 0x128073C
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x12839D8
	protected internal bool UseOptionR() { }

	// RVA: 0x1285400
	internal bool UseOptionInvariant() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator
{
	// Methods

	// RVA: 0x12855E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1285708
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

	// RVA: 0x128571C
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x1285D28
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x1285EA0
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x1285F10
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

	// RVA: 0x128DFC0
	internal void .ctor(Char chMin, Char chMax, int lcOp, int data) { }

}

// Namespace: 
private sealed class SingleRangeComparer
{
	// Fields
	public static readonly SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x128DFD0
	private void .ctor() { }

	// RVA: 0x128DFD8
	public int Compare(SingleRange x, SingleRange y) { }

	// RVA: 0x128E050
	private static void .cctor() { }

}

// Namespace: 
private struct SingleRange
{
	// Fields
	public readonly Char First; // 0x10
	public readonly Char Last; // 0x12

	// Methods

	// RVA: 0x1286974
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

	// RVA: 0x128620C
	public void .ctor() { }

	// RVA: 0x12862E4
	private void .ctor(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x1286360
	public bool get_CanMerge() { }

	// RVA: 0x1286380
	public void set_Negate(bool value) { }

	// RVA: 0x1286388
	public void AddChar(Char c) { }

	// RVA: 0x1286464
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x1286768
	private void AddSet(string set) { }

	// RVA: 0x1286980
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x1286390
	public void AddRange(Char first, Char last) { }

	// RVA: 0x1286988
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x1286EF0
	private void AddCategory(string category) { }

	// RVA: 0x1286F10
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x12870A0
	private void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0x1287350
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x1287474
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x1287598
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x128765C
	public static Char SingletonChar(string set) { }

	// RVA: 0x1287678
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x12877E4
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x12878EC
	public static bool IsSingleton(string set) { }

	// RVA: 0x1287A2C
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x1287784
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x128775C
	private static bool IsNegated(string set) { }

	// RVA: 0x1287B70
	public static bool IsECMAWordChar(Char ch) { }

	// RVA: 0x1287CC0
	public static bool IsWordChar(Char ch) { }

	// RVA: 0x1287C54
	public static bool CharInClass(Char ch, string set) { }

	// RVA: 0x1287D9C
	private static bool CharInClassRecursive(Char ch, string set, int start) { }

	// RVA: 0x1287ED0
	private static bool CharInClassInternal(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1287FF8
	private static bool CharInCategory(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1288228
	private static bool CharInCategoryGroup(Char ch, UnicodeCategory chcategory, string category, int i) { }

	// RVA: 0x1286BCC
	private static string NegateCategory(string category) { }

	// RVA: 0x12882F4
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x128837C
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x12866A4
	private int RangeCount() { }

	// RVA: 0x12885F0
	public string ToStringClass() { }

	// RVA: 0x12866F0
	private SingleRange GetRangeAt(int i) { }

	// RVA: 0x12887C4
	private void Canonicalize() { }

	// RVA: 0x1286C78
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x1288A40
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

	// RVA: 0x128E0BC
	public void .ctor(int[] codes, System.Collections.Generic.List<System.String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x128E1D0
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

	// RVA: 0x128E1F4
	private void .ctor(System.Span<System.Int32> intStack) { }

	// RVA: 0x128E2D4
	public static System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x128E8B0
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x128EB24
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x128ECF0
	private static int AnchorFromType(int type) { }

	// RVA: 0x128ED58
	private void PushInt(int i) { }

	// RVA: 0x128EDC4
	private bool IntIsEmpty() { }

	// RVA: 0x128EE0C
	private int PopInt() { }

	// RVA: 0x128EF34
	private void PushFC(RegexFC fc) { }

	// RVA: 0x128EF98
	private bool FCIsEmpty() { }

	// RVA: 0x128EFEC
	private RegexFC PopFC() { }

	// RVA: 0x128F0D0
	private RegexFC TopFC() { }

	// RVA: 0x128E820
	public void Dispose() { }

	// RVA: 0x128E624
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x128F724
	private void SkipChild() { }

	// RVA: 0x128F14C
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

	// RVA: 0x128F730
	public void .ctor(bool nullable) { }

	// RVA: 0x128F874
	public void .ctor(Char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x128F974
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x128F7B0
	public bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x128FA78
	public bool get_CaseInsensitive() { }

	// RVA: 0x128FA80
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x128E874
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

	// RVA: 0x128540C
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x128FA88
	protected override void InitTrackCount() { }

	// RVA: 0x128FAAC
	private void Advance(int i) { }

	// RVA: 0x128FB34
	private void Goto(int newpos) { }

	// RVA: 0x128FBB4
	private void Textto(int newpos) { }

	// RVA: 0x128FBBC
	private void Trackto(int newpos) { }

	// RVA: 0x128FBE4
	private int Textstart() { }

	// RVA: 0x128FBEC
	private int Textpos() { }

	// RVA: 0x128FBF4
	private int Trackpos() { }

	// RVA: 0x128FC1C
	private void TrackPush() { }

	// RVA: 0x128FC60
	private void TrackPush(int I1) { }

	// RVA: 0x128FCC0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x128FD3C
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x128FDD4
	private void TrackPush2(int I1) { }

	// RVA: 0x128FE38
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x128FEB8
	private void Backtrack() { }

	// RVA: 0x128FB14
	private void SetOperator(int op) { }

	// RVA: 0x128FFC0
	private void TrackPop() { }

	// RVA: 0x128FFD0
	private void TrackPop(int framesize) { }

	// RVA: 0x128FFE0
	private int TrackPeek() { }

	// RVA: 0x129001C
	private int TrackPeek(int i) { }

	// RVA: 0x129005C
	private void StackPush(int I1) { }

	// RVA: 0x129009C
	private void StackPush(int I1, int I2) { }

	// RVA: 0x12900F8
	private void StackPop() { }

	// RVA: 0x1290108
	private void StackPop(int framesize) { }

	// RVA: 0x1290118
	private int StackPeek() { }

	// RVA: 0x1290154
	private int StackPeek(int i) { }

	// RVA: 0x1290194
	private int Operator() { }

	// RVA: 0x129019C
	private int Operand(int i) { }

	// RVA: 0x12901E4
	private int Leftchars() { }

	// RVA: 0x12901F4
	private int Rightchars() { }

	// RVA: 0x1290204
	private int Bump() { }

	// RVA: 0x1290218
	private int Forwardchars() { }

	// RVA: 0x1290244
	private Char Forwardcharnext() { }

	// RVA: 0x12902D8
	private bool Stringmatch(string str) { }

	// RVA: 0x129044C
	private bool Refmatch(int index, int len) { }

	// RVA: 0x12905F4
	private void Backwardnext() { }

	// RVA: 0x1290624
	private Char CharAt(int j) { }

	// RVA: 0x1290644
	protected override bool FindFirstChar() { }

	// RVA: 0x1290BE8
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

	// RVA: 0x1292FF0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x129310C
	public void .ctor() { }

	// RVA: 0x12931C4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1293348
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1293450
	public string get_Input() { }

	// RVA: 0x1293458
	public string get_Pattern() { }

	// RVA: 0x1293460
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

	// RVA: 0x1293468
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x12934A4
	public void .ctor(int type, RegexOptions options, Char ch) { }

	// RVA: 0x12934E8
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x1293534
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x1293578
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x12935C8
	public bool UseOptionR() { }

	// RVA: 0x12935D4
	public RegexNode ReverseLeft() { }

	// RVA: 0x1293654
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x129366C
	private RegexNode Reduce() { }

	// RVA: 0x12943AC
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x1294174
	private RegexNode ReduceGroup() { }

	// RVA: 0x1293FA8
	private RegexNode ReduceRep() { }

	// RVA: 0x12941FC
	private RegexNode ReduceSet() { }

	// RVA: 0x1293768
	private RegexNode ReduceAlternation() { }

	// RVA: 0x1293BAC
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x12945A8
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x1294704
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x1294530
	public RegexNode Child(int i) { }

	// RVA: 0x12944D8
	public int ChildCount() { }

	// RVA: 0x12947FC
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

	// RVA: 0x1294804
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x1295EBC
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x1296628
	public static string Escape(string input) { }

	// RVA: 0x1294A64
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x1294B44
	private void SetPattern(string Re) { }

	// RVA: 0x1294FC0
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x1295060
	private RegexNode ScanRegex() { }

	// RVA: 0x1296084
	private RegexNode ScanReplacement() { }

	// RVA: 0x1297508
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x1297C34
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x1296A50
	private void ScanBlank() { }

	// RVA: 0x1298C7C
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x129A4CC
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x129959C
	private RegexNode ScanDollar() { }

	// RVA: 0x1299FA4
	private string ScanCapname() { }

	// RVA: 0x129ABFC
	private Char ScanOctal() { }

	// RVA: 0x129947C
	private int ScanDecimal() { }

	// RVA: 0x129AD0C
	private Char ScanHex(int c) { }

	// RVA: 0x129AE64
	private static int HexDigit(Char ch) { }

	// RVA: 0x129AE94
	private Char ScanControl() { }

	// RVA: 0x129AF48
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x129A230
	private void ScanOptions() { }

	// RVA: 0x1299C5C
	private Char ScanCharEscape() { }

	// RVA: 0x1299ACC
	private string ParseProperty() { }

	// RVA: 0x129A43C
	private int TypeFromCode(Char ch) { }

	// RVA: 0x129AF68
	private static RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0x1294BB8
	private void CountCaptures() { }

	// RVA: 0x129AFC8
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x129B124
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x1296040
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x129B298
	private void AssignNameSlots() { }

	// RVA: 0x129A198
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x129A0B8
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x129A17C
	private bool IsCaptureName(string capname) { }

	// RVA: 0x129A0AC
	private bool UseOptionN() { }

	// RVA: 0x12974FC
	private bool UseOptionI() { }

	// RVA: 0x12992B0
	private bool UseOptionM() { }

	// RVA: 0x1299338
	private bool UseOptionS() { }

	// RVA: 0x1296DBC
	private bool UseOptionX() { }

	// RVA: 0x1299AC0
	private bool UseOptionE() { }

	// RVA: 0x1297098
	private static bool IsSpecial(Char ch) { }

	// RVA: 0x1296E28
	private static bool IsStopperX(Char ch) { }

	// RVA: 0x1297138
	private static bool IsQuantifier(Char ch) { }

	// RVA: 0x1296EC8
	private bool IsTrueQuantifier() { }

	// RVA: 0x129A39C
	private static bool IsSpace(Char ch) { }

	// RVA: 0x12968EC
	private static bool IsMetachar(Char ch) { }

	// RVA: 0x12971D8
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x12985F0
	private void PushGroup() { }

	// RVA: 0x1298A94
	private void PopGroup() { }

	// RVA: 0x12987E4
	private bool EmptyStack() { }

	// RVA: 0x129698C
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x129865C
	private void AddAlternate() { }

	// RVA: 0x1299410
	private void AddConcatenate() { }

	// RVA: 0x1299550
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x129B984
	private RegexNode Unit() { }

	// RVA: 0x1297440
	private void AddUnitOne(Char ch) { }

	// RVA: 0x1299344
	private void AddUnitNotone(Char ch) { }

	// RVA: 0x1297B38
	private void AddUnitSet(string cc) { }

	// RVA: 0x129B98C
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x12992BC
	private void AddUnitType(int type) { }

	// RVA: 0x1298894
	private void AddGroup() { }

	// RVA: 0x1297BC8
	private void PushOptions() { }

	// RVA: 0x1298BD0
	private void PopOptions() { }

	// RVA: 0x129B0D0
	private bool EmptyOptionsStack() { }

	// RVA: 0x1298588
	private void PopKeepOptions() { }

	// RVA: 0x12987F4
	private ArgumentException MakeException(string message) { }

	// RVA: 0x129B994
	private int Textpos() { }

	// RVA: 0x129B99C
	private void Textto(int pos) { }

	// RVA: 0x129944C
	private Char RightCharMoveRight() { }

	// RVA: 0x1296DC8
	private void MoveRight() { }

	// RVA: 0x129A09C
	private void MoveRight(int i) { }

	// RVA: 0x1299400
	private void MoveLeft() { }

	// RVA: 0x1297420
	private Char CharAt(int i) { }

	// RVA: 0x1296E00
	internal Char RightChar() { }

	// RVA: 0x129A070
	private Char RightChar(int i) { }

	// RVA: 0x1296DD8
	private int CharsRight() { }

	// RVA: 0x129B9A4
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

	// RVA: 0x129BA48
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x129BA74
	internal bool get_CaseInsensitive() { }

	// RVA: 0x129BA7C
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x129BAF8
	internal string get_Prefix() { }

	// RVA: 0x129BB00
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

	// RVA: 0x1296214
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x129BBA8
	public static RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	// RVA: 0x129BCC8
	public string get_Pattern() { }

	// RVA: 0x129BCD0
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x129BE8C
	private void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, Match match) { }

	// RVA: 0x129C0A4
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

	// RVA: 0x129C464
	protected internal void .ctor() { }

	// RVA: 0x129C46C
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x129C864
	private void StartTimeoutWatch() { }

	// RVA: 0x129C8B0
	protected void CheckTimeout() { }

	// RVA: 0x129CB68
	private void DoCheckTimeout() { }

	// RVA: -1
	protected abstract void Go() { }

	// RVA: -1
	protected abstract bool FindFirstChar() { }

	// RVA: -1
	protected abstract void InitTrackCount() { }

	// RVA: 0x129C8C0
	private void InitMatch() { }

	// RVA: 0x129CB00
	private Match TidyMatch(bool quick) { }

	// RVA: 0x129CC44
	protected void EnsureStorage() { }

	// RVA: 0x129CE08
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x129CF0C
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x129CD54
	protected void DoubleTrack() { }

	// RVA: 0x129CCA0
	protected void DoubleStack() { }

	// RVA: 0x129D010
	protected void DoubleCrawl() { }

	// RVA: 0x129D0C4
	protected void Crawl(int i) { }

	// RVA: 0x129D124
	protected int Popcrawl() { }

	// RVA: 0x129D164
	protected int Crawlpos() { }

	// RVA: 0x129D18C
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x129D220
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x129D3D0
	protected void Uncapture() { }

	// RVA: 0x129D420
	protected bool IsMatched(int cap) { }

	// RVA: 0x129D388
	protected int MatchIndex(int cap) { }

	// RVA: 0x129D3AC
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

	// RVA: 0x1295E0C
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

	// RVA: 0x129D444
	private void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }

	// RVA: 0x129D58C
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x129DE4C
	public void Dispose() { }

	// RVA: 0x129D840
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x129EA4C
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x129EABC
	private void Emit(int op) { }

	// RVA: 0x129DEAC
	private void Emit(int op, int opd1) { }

	// RVA: 0x129EB44
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x129EC04
	private int StringCode(string str) { }

	// RVA: 0x129ED30
	private int MapCapnum(int capnum) { }

	// RVA: 0x129DF4C
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute
{
	// Fields
	private readonly string tool; // 0x10
	private readonly string version; // 0x18

	// Methods

	// RVA: 0x129EDF0
	public void .ctor(string tool, string version) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch
{
	// Methods

	// RVA: 0x129EE40
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

	// RVA: 0x129EF08
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x129EF74
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x129F1AC
	private static void _pruneCachedSwitches() { }

	// RVA: 0x129F698
	private static void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x129F734
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x129F764
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

	// RVA: 0x129F84C
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

	// RVA: 0x129F914
	public static Int64 GetTimestamp() { }

	// RVA: 0x129F918
	public static Stopwatch StartNew() { }

	// RVA: 0x129F9E4
	public void .ctor() { }

	// RVA: 0x129FA6C
	public TimeSpan get_Elapsed() { }

	// RVA: 0x129FC98
	public Int64 get_ElapsedMilliseconds() { }

	// RVA: 0x129FC1C
	public Int64 get_ElapsedTicks() { }

	// RVA: 0x129FE54
	public bool get_IsRunning() { }

	// RVA: 0x129FE5C
	public void Reset() { }

	// RVA: 0x129F9EC
	public void Start() { }

	// RVA: 0x129FE68
	public void Stop() { }

	// RVA: 0x129FEE4
	public void Restart() { }

	// RVA: 0x129FF50
	private static void .cctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute
{
	// Methods

	// RVA: 0x129FFAC
	public void .ctor() { }

}

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException
{
	// Methods

	// RVA: 0x129FFB4
	public void .ctor() { }

	// RVA: 0x12A0018
	public void .ctor(string message) { }

	// RVA: 0x12A0020
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12A0028
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

	// RVA: 0x12A1B38
	private static void .cctor() { }

	// RVA: 0x12A1BA4
	public void .ctor() { }

	// RVA: 0x12A1BAC
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x12A1C0C
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x12A1C54
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

	// RVA: 0x12A0030
	private void set_ContentLength(int value) { }

	// RVA: 0x12A0038
	internal void .ctor(Byte[] data) { }

	// RVA: 0x12A0060
	internal void .ctor(Byte[] data, int offset, int length) { }

	// RVA: 0x12A0074
	private void .ctor(DerTag tagToEat, Byte[] data, int offset, int length) { }

	// RVA: 0x12A0254
	internal bool get_HasData() { }

	// RVA: 0x12A0264
	internal Byte PeekTag() { }

	// RVA: 0x12A0304
	internal void SkipValue() { }

	// RVA: 0x12A0360
	internal Byte[] ReadNextEncodedValue() { }

	// RVA: 0x12A0550
	internal bool ReadBoolean() { }

	// RVA: 0x12A0624
	internal int ReadInteger() { }

	// RVA: 0x12A06D0
	internal Byte[] ReadIntegerBytes() { }

	// RVA: 0x12A0848
	internal Byte[] ReadBitString() { }

	// RVA: 0x12A0990
	internal Byte[] ReadOctetString() { }

	// RVA: 0x12A0A50
	internal string ReadOidAsString() { }

	// RVA: 0x12A0D44
	internal string ReadUtf8String() { }

	// RVA: 0x12A0ED0
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	// RVA: 0x12A103C
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x12A1044
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x12A104C
	internal string ReadPrintableString() { }

	// RVA: 0x12A1154
	internal string ReadIA5String() { }

	// RVA: 0x12A125C
	internal string ReadT61String() { }

	// RVA: 0x12A165C
	internal DateTime ReadX509Date() { }

	// RVA: 0x12A173C
	internal DateTime ReadUtcTime() { }

	// RVA: 0x12A1794
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x12A1A30
	internal string ReadBMPString() { }

	// RVA: 0x12A0E4C
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x12A17EC
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	// RVA: 0x12A0790
	private Byte[] ReadContentAsBytes() { }

	// RVA: 0x12A0180
	private void EatTag(DerTag expected) { }

	// RVA: 0x12A0F9C
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	// RVA: 0x12A020C
	private int EatLength() { }

	// RVA: 0x12A041C
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

	// RVA: 0x12A1D40
	public void .ctor() { }

	// RVA: 0x12A1D48
	public void .ctor(string oid) { }

	// RVA: 0x12A1DE0
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x12A1E30
	public void .ctor(Oid oid) { }

	// RVA: 0x12A1ECC
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x12A2088
	public string get_Value() { }

	// RVA: 0x12A2090
	public void set_Value(string value) { }

	// RVA: 0x12A2098
	public string get_FriendlyName() { }

	// RVA: 0x12A202C
	private void .ctor(string value, string friendlyName, OidGroup group) { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection
{
	// Fields
	private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list; // 0x10

	// Methods

	// RVA: 0x12A2164
	public void .ctor() { }

	// RVA: 0x12A21F0
	public int Add(Oid oid) { }

	// RVA: 0x12A226C
	public Oid get_Item(int index) { }

	// RVA: 0x12A22E4
	public int get_Count() { }

	// RVA: 0x12A2330
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x12A23EC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12A2468
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12A26C8
	public bool get_IsSynchronized() { }

	// RVA: 0x12A26D0
	public object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Methods

	// RVA: 0x12A23AC
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x12A26D4
	public Oid get_Current() { }

	// RVA: 0x12A2750
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12A27CC
	public bool MoveNext() { }

	// RVA: 0x12A284C
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

	// RVA: 0x12A2858
	protected void .ctor() { }

	// RVA: 0x12A2860
	public void .ctor(string oid, Byte[] rawData) { }

	// RVA: 0x12A2A64
	public void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0x12A2BB8
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12A2D0C
	public Oid get_Oid() { }

	// RVA: 0x12A2B28
	public void set_Oid(Oid value) { }

	// RVA: 0x12A2D14
	public Byte[] get_RawData() { }

	// RVA: 0x12A295C
	public void set_RawData(Byte[] value) { }

	// RVA: 0x12A2D1C
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12A2E84
	public virtual string Format(bool multiLine) { }

	// RVA: 0x12A3064
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x12A2F28
	internal string Default(bool multiLine) { }

	// RVA: 0x12A3238
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x12A335C
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x12A3484
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x12A35AC
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x12A36D4
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x12A3AC0
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

	// RVA: 0x12A3FC4
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x12A4140
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x12A4148
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x12A4150
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x12A4E2C
	public Oid get_Oid() { }

	// RVA: 0x12A4E34
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x12A474C
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0x12A431C
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0x12A4EE8
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName
{
	// Fields
	private string name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x12A4F68
	public void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0x12A5220
	public void .ctor(string distinguishedName) { }

	// RVA: 0x12A5228
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x12A5720
	public string get_Name() { }

	// RVA: 0x12A5570
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12A57B0
	public override string Format(bool multiLine) { }

	// RVA: 0x12A5728
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12A5114
	private void DecodeRawData() { }

	// RVA: 0x12A5820
	private static string Canonize(string s) { }

	// RVA: 0x12A5A7C
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

	// RVA: 0x12A5C74
	public void .ctor() { }

	// RVA: 0x12A3EB0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x12A5F74
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x12A6224
	public bool get_CertificateAuthority() { }

	// RVA: 0x12A6298
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x12A630C
	public int get_PathLengthConstraint() { }

	// RVA: 0x12A6380
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12A5D44
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12A60C8
	internal Byte[] Encode() { }

	// RVA: 0x12A657C
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

	// RVA: 0x12A6814
	public override void Reset() { }

	// RVA: 0x12A68CC
	public void .ctor() { }

	// RVA: 0x12A68D4
	public void .ctor(Byte[] rawData) { }

	// RVA: 0x12A6A64
	public void .ctor(Byte[] rawData, string password) { }

	// RVA: 0x12A6A6C
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x12A6A74
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x12A6A7C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A6AC4
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x12A7194
	public bool get_HasPrivateKey() { }

	// RVA: 0x12A7240
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12A7478
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12A7570
	public DateTime get_NotAfter() { }

	// RVA: 0x12A7578
	public DateTime get_NotBefore() { }

	// RVA: 0x12A7580
	public PublicKey get_PublicKey() { }

	// RVA: 0x12A7748
	public Byte[] get_RawData() { }

	// RVA: 0x12A7844
	public string get_SerialNumber() { }

	// RVA: 0x12A7854
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x12A7954
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12A7A4C
	public string get_Thumbprint() { }

	// RVA: 0x12A7A6C
	public int get_Version() { }

	// RVA: 0x12A7B48
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0x12A7BE4
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12A7CA0
	public override string ToString() { }

	// RVA: 0x12A7CAC
	public override string ToString(bool verbose) { }

	// RVA: 0x12A93F0
	public bool Verify() { }

	// RVA: 0x12A6F90
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x12A6F00
	internal X509Certificate2Impl get_Impl() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x12A9498
	public void .ctor() { }

	// RVA: 0x12A94A8
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x12A9554
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x12A9684
	public int Add(X509Certificate2 certificate) { }

	// RVA: 0x12A94D8
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x12A9700
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x12A9A38
	private string GetKeyIdentifier(X509Certificate2 x) { }

	// RVA: 0x12AA358
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x12AB4E0
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x12AB60C
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12AB544
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x12AB6B4
	public X509Certificate2 get_Current() { }

	// RVA: 0x12AB7B8
	public bool MoveNext() { }

	// RVA: 0x12AB86C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12AB924
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12AB9D8
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

	// RVA: 0x12ABA90
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

	// RVA: 0x12ABA98
	public override bool get_IsValid() { }

	// RVA: 0x12ABAA8
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x12ABAE4
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x12ABBF0
	public void .ctor(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x12ABE20
	public override X509CertificateImpl Clone() { }

	// RVA: 0x12ABE90
	private X509Certificate get_Cert() { }

	// RVA: 0x12ABEB8
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x12ABEFC
	public override bool get_HasPrivateKey() { }

	// RVA: 0x12ABF24
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12AC374
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x12AC51C
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x12AC5B4
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x12ABDA8
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x12AC64C
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	// RVA: 0x12ACF74
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x12AD16C
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x12AD174
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x12AD17C
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Methods

	// RVA: 0x12AD25C
	private void EnsureCertData() { }

	// RVA: -1
	protected abstract Byte[] GetRawCertData() { }

	// RVA: 0x12AD334
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x12AD418
	public sealed override Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x12AD4FC
	public sealed override Byte[] get_PublicKeyValue() { }

	// RVA: 0x12AD5E0
	public sealed override Byte[] get_SerialNumber() { }

	// RVA: 0x12AD6C4
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x12AD7A8
	public sealed override int get_Version() { }

	// RVA: 0x12AD894
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12AD978
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12ADA5C
	public sealed override string get_Subject() { }

	// RVA: 0x12ADA88
	public sealed override string get_Issuer() { }

	// RVA: 0x12ADAB4
	public sealed override Byte[] get_RawData() { }

	// RVA: 0x12ADB98
	public sealed override Byte[] get_Thumbprint() { }

	// RVA: 0x12ADDB0
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12ADEA0
	public sealed override System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x12ADF84
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x12AE0B4
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x12AE1E4
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x12AE288
	public sealed override Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x12AE3E8
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x12AE448
	private Byte[] ExportPkcs12(string password) { }

	// RVA: 0x12ABADC
	protected void .ctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12AEC80
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x12AED6C
	public X509Certificate get_Current() { }

	// RVA: 0x12AEE70
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12AEF28
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12AEFDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12AF094
	public bool MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0x12A94A0
	public void .ctor() { }

	// RVA: 0x12AE978
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x12AEAFC
	public X509Certificate get_Item(int index) { }

	// RVA: 0x12AEBA0
	public int Add(X509Certificate value) { }

	// RVA: 0x12AE9A8
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x12AEC1C
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x12AED48
	public override int GetHashCode() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection
{
	// Fields
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

	// Methods

	// RVA: 0x12ACE64
	public void .ctor() { }

	// RVA: 0x12AF148
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x12AE92C
	public int get_Count() { }

	// RVA: 0x12AE8B4
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x12ACEF0
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x12ABB8C
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x12AF3B4
	public void Dispose() { }

	// RVA: 0x12AF444
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12AF74C
	protected override void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Methods

	// RVA: 0x12AF7E8
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x12AF88C
	public void .ctor() { }

	// RVA: 0x12AF900
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12AF9DC
	internal void .ctor(X509ChainImpl impl) { }

	// RVA: 0x12AFA48
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x12AFA90
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12AFAF8
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12AD0FC
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12AFB60
	public void Reset() { }

	// RVA: 0x12AD050
	public static X509Chain Create() { }

	// RVA: 0x12AFBC8
	public void Dispose() { }

	// RVA: 0x12AFC58
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12AFD88
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

	// RVA: 0x12AFE24
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x12AFEA4
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x12AFEAC
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x12AFEB4
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x12AFEBC
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x12AFEC4
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x12AFF7C
	private void Set(X509ChainStatus[] status, int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x12B01A8
	internal void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection
{
	// Fields
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12B1178
	internal void .ctor() { }

	// RVA: 0x12B11F0
	public int get_Count() { }

	// RVA: 0x12B1218
	public bool get_IsSynchronized() { }

	// RVA: 0x12B1240
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x12B12E4
	public object get_SyncRoot() { }

	// RVA: 0x12B130C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12B1334
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x12B1464
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12B14CC
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x12B15AC
	internal void Clear() { }

	// RVA: 0x12B15D4
	internal bool Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12B139C
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x12B1740
	public X509ChainElement get_Current() { }

	// RVA: 0x12B1844
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12B18FC
	public bool MoveNext() { }

	// RVA: 0x12B19B0
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl
{
	// Methods

	// RVA: -1
	public abstract bool get_IsValid() { }

	// RVA: 0x12B1A68
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

	// RVA: 0x12AFCF8
	public void Dispose() { }

	// RVA: 0x12B1B38
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12B1B3C
	protected override void Finalize() { }

	// RVA: 0x12B1BD8
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

	// RVA: 0x12B1BE0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12B1D30
	public override bool get_IsValid() { }

	// RVA: 0x12B1D38
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12B1D40
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12B1D48
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x12B1D4C
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12B2868
	public override void Reset() { }

	// RVA: 0x12B2A74
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x12B3008
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x12B2C30
	private X509Store get_LMRootStore() { }

	// RVA: 0x12B2DC8
	private X509Store get_UserRootStore() { }

	// RVA: 0x12B31C4
	private X509Store get_LMCAStore() { }

	// RVA: 0x12B3330
	private X509Store get_UserCAStore() { }

	// RVA: 0x12B3A3C
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x12B2478
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x12B405C
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x12B3E34
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x12B3F58
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x12B4444
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x12B2618
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12B4490
	private void Process(int n) { }

	// RVA: 0x12B48B0
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x12B4E74
	private void WrapUp() { }

	// RVA: 0x12B5140
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x12B50F8
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x12B438C
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12B42E8
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12B5714
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x12B5580
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x12B4BE4
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12B57B0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x12B5988
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x12B63F8
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x12B5C08
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x12B60D0
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x12B5DD8
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0x12B675C
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

	// RVA: 0x12B1D08
	public void .ctor() { }

	// RVA: 0x12B3B30
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x12B6900
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x12B6908
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x12B6910
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x12B6918
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x12B6984
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x12B698C
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x12B69F8
	public DateTime get_VerificationTime() { }

	// RVA: 0x12B67DC
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private string info; // 0x18

	// Methods

	// RVA: 0x12B2834
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x12B6A00
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x12B6A08
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x12B6A10
	public void set_StatusInformation(string value) { }

	// RVA: 0x12B0008
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x12B6A18
	public void .ctor() { }

	// RVA: 0x12B6AD0
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x12B6E60
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x12B7114
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B6BC4
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12B7018
	internal Byte[] Encode() { }

	// RVA: 0x12B72F0
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension
{
	// Fields
	private bool _critical; // 0x20

	// Methods

	// RVA: 0x12B6AC8
	protected void .ctor() { }

	// RVA: 0x12B7710
	public void .ctor(string oid, Byte[] rawData, bool critical) { }

	// RVA: 0x12B773C
	public bool get_Critical() { }

	// RVA: 0x12B7744
	public void set_Critical(bool value) { }

	// RVA: 0x12B774C
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B75E0
	internal string FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12B787C
	public void .ctor() { }

	// RVA: 0x12AB444
	public int get_Count() { }

	// RVA: 0x12B78F4
	public bool get_IsSynchronized() { }

	// RVA: 0x12B791C
	public object get_SyncRoot() { }

	// RVA: 0x12A9B04
	public X509Extension get_Item(string oid) { }

	// RVA: 0x12B7920
	public int Add(X509Extension extension) { }

	// RVA: 0x12B799C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12B5334
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x12B7B04
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12B7B98
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12B7AB4
	internal void .ctor(ArrayList list) { }

	// RVA: 0x12B53C8
	public X509Extension get_Current() { }

	// RVA: 0x12B7C18
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12B54CC
	public bool MoveNext() { }

	// RVA: 0x12B7CD0
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2
{
	// Methods

	// RVA: 0x12B5010
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x12AF978
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x12B7D88
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x12AF840
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x12B1AB0
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

	// RVA: 0x12B7D9C
	public void .ctor() { }

	// RVA: 0x12B7E4C
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x12B8168
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x12AB46C
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x12B83FC
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B8254
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x12B7F40
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12B8264
	internal Byte[] Encode() { }

	// RVA: 0x12B85D8
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

	// RVA: 0x12B349C
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x12B2F60
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x12B8B7C
	private X509Stores get_Factory() { }

	// RVA: 0x12B8B98
	internal X509Store get_Store() { }

	// RVA: 0x12B2A30
	public void Close() { }

	// RVA: 0x12B8BA0
	public void Dispose() { }

	// RVA: 0x12B35D8
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

	// RVA: 0x12B8BE4
	public void .ctor() { }

	// RVA: 0x12B8C94
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x12B8F48
	public void .ctor(Byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12B921C
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12B95AC
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x12A9E84
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x12AA2C0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x12B95B8
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B9794
	internal static Byte FromHexChar(Char c) { }

	// RVA: 0x12B97D4
	internal static Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0x12B9404
	internal static Byte[] FromHex(string hex) { }

	// RVA: 0x12B8D88
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12B919C
	internal Byte[] Encode() { }

	// RVA: 0x12B9870
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Methods

	// RVA: 0x12B9AF0
	public void .ctor(Type type, string value) { }

	// RVA: 0x12BA034
	public void .ctor(Char value) { }

	// RVA: 0x12BA0B8
	public void .ctor(Byte value) { }

	// RVA: 0x12BA13C
	public void .ctor(Int16 value) { }

	// RVA: 0x12BA1C0
	public void .ctor(int value) { }

	// RVA: 0x12BA244
	public void .ctor(Int64 value) { }

	// RVA: 0x12BA2C8
	public void .ctor(float value) { }

	// RVA: 0x12BA354
	public void .ctor(Double value) { }

	// RVA: 0x12BA3E0
	public void .ctor(bool value) { }

	// RVA: 0x12BA464
	public void .ctor(string value) { }

	// RVA: 0x12BA498
	public void .ctor(object value) { }

	// RVA: 0x12BA4CC
	public void .ctor(SByte value) { }

	// RVA: 0x12BA550
	public void .ctor(UInt16 value) { }

	// RVA: 0x12BA5D4
	public void .ctor(UInt32 value) { }

	// RVA: 0x12BA658
	public void .ctor(UInt64 value) { }

	// RVA: 0x12BA6DC
	public virtual object get_Value() { }

	// RVA: 0x12BA6E4
	public override bool Equals(object obj) { }

	// RVA: 0x12BA80C
	public override int GetHashCode() { }

	// RVA: 0x12BA814
	protected void SetValue(object value) { }

	// RVA: 0x12B9E0C
	internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, object conversionResult) { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x12BA81C
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x12BA848
	public void .ctor() { }

	// RVA: 0x12BA870
	public EditorBrowsableState get_State() { }

	// RVA: 0x12BA878
	public override bool Equals(object obj) { }

	// RVA: 0x12BA91C
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

	// RVA: 0x12BA924
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12BA990
	protected override void Finalize() { }

	// RVA: 0x12BAA38
	public object get_UserSuppliedState() { }

	// RVA: 0x12BAA40
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12BAA48
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x12BAB38
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x12BAC40
	public void OperationCompleted() { }

	// RVA: 0x12BAA50
	private void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x12BAB60
	private void OperationCompletedCore() { }

	// RVA: 0x12BACB0
	private void VerifyNotCompleted() { }

	// RVA: 0x12BAD18
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x12BAD88
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12BAE30
	internal void .ctor() { }

}

// Namespace: System.ComponentModel
public static class AsyncOperationManager
{
	// Methods

	// RVA: 0x12BAE6C
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x12BAEEC
	public static SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12BAF78
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

	// RVA: 0x12BAF80
	public void .ctor() { }

	// RVA: 0x12BB080
	private void AsyncOperationCompleted(object arg) { }

	// RVA: 0x12BB120
	public bool get_CancellationPending() { }

	// RVA: 0x12BB128
	public void CancelAsync() { }

	// RVA: 0x12BB198
	public void add_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12BB23C
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12BB2E0
	public bool get_IsBusy() { }

	// RVA: 0x12BB2E8
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x12BB30C
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x12BB330
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	// RVA: 0x12BB354
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12BB3F8
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12BB49C
	private void ProgressReporter(object arg) { }

	// RVA: 0x12BB538
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x12BB540
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x12BB63C
	public void RunWorkerAsync() { }

	// RVA: 0x12BB644
	public void RunWorkerAsync(object argument) { }

	// RVA: 0x12BB898
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12BB93C
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12BB9E0
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x12BB9E8
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x12BB9F0
	public bool get_WorkerSupportsCancellation() { }

	// RVA: 0x12BB9F8
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x12BBA00
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x12BBB98
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12BBB9C
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

	// RVA: 0x12BBBA0
	public void .ctor(bool browsable) { }

	// RVA: 0x12BBBCC
	public bool get_Browsable() { }

	// RVA: 0x12BBBD4
	public override bool Equals(object obj) { }

	// RVA: 0x12BBDA0
	public override int GetHashCode() { }

	// RVA: 0x12BBE18
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BBE8C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection
{
	// Methods

	// RVA: 0x12BBF40
	public void .ctor(IComponent[] components) { }

	// RVA: 0x12BBF8C
	public virtual IComponent get_Item(string name) { }

	// RVA: 0x12BC4F4
	public virtual IComponent get_Item(int index) { }

	// RVA: 0x12BC590
	public void CopyTo(IComponent[] array, int index) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string <DescriptionValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BC5D4
	public void .ctor() { }

	// RVA: 0x12BC644
	public void .ctor(string description) { }

	// RVA: 0x12BC678
	public virtual string get_Description() { }

	// RVA: 0x12BC680
	protected string get_DescriptionValue() { }

	// RVA: 0x12BC688
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x12BC690
	public override bool Equals(object obj) { }

	// RVA: 0x12BC76C
	public override int GetHashCode() { }

	// RVA: 0x12BC798
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BC80C
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

	// RVA: 0x12BC8C8
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x12BC8F4
	public bool get_IsDesignOnly() { }

	// RVA: 0x12BC8FC
	public override bool Equals(object obj) { }

	// RVA: 0x12BCAC8
	public override int GetHashCode() { }

	// RVA: 0x12BCB40
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BCBE8
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

	// RVA: 0x12BCC9C
	public void .ctor() { }

	// RVA: 0x12BCD08
	public void .ctor(string category) { }

	// RVA: 0x12BCD3C
	public string get_Category() { }

	// RVA: 0x12BCD44
	public override bool Equals(object obj) { }

	// RVA: 0x12BCDE4
	public override int GetHashCode() { }

	// RVA: 0x12BCE08
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BCEAC
	public override object get_TypeId() { }

	// RVA: 0x12BCEF0
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

	// RVA: 0x12BD0A0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x12BD0CC
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x12BD0D4
	public override bool Equals(object obj) { }

	// RVA: 0x12BD290
	public override int GetHashCode() { }

	// RVA: 0x12BD298
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BD30C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BD3F0
	public void .ctor() { }

	// RVA: 0x12BD460
	public void .ctor(string displayName) { }

	// RVA: 0x12BD494
	public virtual string get_DisplayName() { }

	// RVA: 0x12BD49C
	protected string get_DisplayNameValue() { }

	// RVA: 0x12BD4A4
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x12BD4AC
	public override bool Equals(object obj) { }

	// RVA: 0x12BD588
	public override int GetHashCode() { }

	// RVA: 0x12BD5B4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BD628
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

	// RVA: 0x12BD89C
	public void .ctor(object key, Delegate handler, ListEntry next) { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList
{
	// Fields
	private ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Methods

	// RVA: 0x12BD6E4
	internal void .ctor(Component parent) { }

	// RVA: 0x12BD718
	public void .ctor() { }

	// RVA: 0x12BD720
	public Delegate get_Item(object key) { }

	// RVA: 0x12BD7B4
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x12BD900
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0x12BD9FC
	public void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x12BDA3C
	public void Dispose() { }

	// RVA: 0x12BD79C
	private ListEntry Find(object key) { }

	// RVA: 0x12BDA48
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

	// RVA: 0x12BDAA4
	public void .ctor(bool immutable) { }

	// RVA: 0x12BDAD0
	public bool get_Immutable() { }

	// RVA: 0x12BDAD8
	public override bool Equals(object obj) { }

	// RVA: 0x12BDCA4
	public override int GetHashCode() { }

	// RVA: 0x12BDCAC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BDD20
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class InitializationEventAttribute
{
	// Fields
	private readonly string <EventName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BDDD4
	public void .ctor(string eventName) { }

	// RVA: 0x12BDE08
	public string get_EventName() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException
{
	// Methods

	// RVA: 0x12BDE10
	public void .ctor() { }

	// RVA: 0x12BDE1C
	public void .ctor(string message) { }

	// RVA: 0x12BDE24
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12BDE2C
	public void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x12BDF18
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

	// RVA: 0x12BDF20
	public void .ctor(bool isLocalizable) { }

	// RVA: 0x12BDF4C
	public bool get_IsLocalizable() { }

	// RVA: 0x12BDF54
	public override bool Equals(object obj) { }

	// RVA: 0x12BE120
	public override int GetHashCode() { }

	// RVA: 0x12BE128
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BE1D0
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

	// RVA: 0x12BE284
	public void .ctor(bool allowMerge) { }

	// RVA: 0x12BE2B0
	public bool get_AllowMerge() { }

	// RVA: 0x12BE2B8
	public override bool Equals(object obj) { }

	// RVA: 0x12BE484
	public override int GetHashCode() { }

	// RVA: 0x12BE48C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BE500
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

	// RVA: 0x12BE5B4
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x12BE5E0
	public bool get_IsReadOnly() { }

	// RVA: 0x12BE5E8
	public override bool Equals(object value) { }

	// RVA: 0x12BE7B4
	public override int GetHashCode() { }

	// RVA: 0x12BE7BC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12BE864
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AddingNewEventArgs
{
	// Fields
	private object <NewObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BE918
	public void .ctor() { }

	// RVA: 0x12BE9A0
	public void .ctor(object newObject) { }

	// RVA: 0x12BEA18
	public object get_NewObject() { }

	// RVA: 0x12BEA20
	public void set_NewObject(object value) { }

}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler
{
	// Methods

	// RVA: 0x12BEA28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BEB4C
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x12BEB60
	public virtual IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12BEBBC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute
{
	// Fields
	private readonly object <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BEBC8
	public void .ctor(Type type, string value) { }

	// RVA: 0x12BED00
	public void .ctor(Char value) { }

	// RVA: 0x12BED84
	public void .ctor(Byte value) { }

	// RVA: 0x12BEE08
	public void .ctor(Int16 value) { }

	// RVA: 0x12BEE8C
	public void .ctor(int value) { }

	// RVA: 0x12BEF10
	public void .ctor(Int64 value) { }

	// RVA: 0x12BEF94
	public void .ctor(float value) { }

	// RVA: 0x12BF020
	public void .ctor(Double value) { }

	// RVA: 0x12BF0AC
	public void .ctor(bool value) { }

	// RVA: 0x12BF130
	public void .ctor(string value) { }

	// RVA: 0x12BF164
	public void .ctor(object value) { }

	// RVA: 0x12BF198
	public object get_Value() { }

	// RVA: 0x12BF1A0
	public override bool Equals(object obj) { }

	// RVA: 0x12BF260
	public override int GetHashCode() { }

}

// Namespace: 
private class ArrayPropertyDescriptor
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x12BF758
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x12BF828
	public override object GetValue(object instance) { }

	// RVA: 0x12BF8E0
	public override void SetValue(object instance, object value) { }

}

// Namespace: System.ComponentModel
public class ArrayConverter
{
	// Methods

	// RVA: 0x12BF268
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12BF45C
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12BF818
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12BF820
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

	// RVA: 0x12BF9E4
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x12BFB70
	protected void .ctor() { }

	// RVA: 0x12BFB78
	public static AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x12C0030
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x12BFF9C
	public int get_Count() { }

	// RVA: 0x12C0038
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x12C0080
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x12C0E2C
	public bool Contains(Attribute attribute) { }

	// RVA: 0x12C0E90
	public bool Contains(Attribute[] attributes) { }

	// RVA: 0x12C0820
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x12C0F30
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12C0F58
	public bool Matches(Attribute attribute) { }

	// RVA: 0x12C1008
	public bool Matches(Attribute[] attributes) { }

	// RVA: 0x12C1080
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12C1088
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12C1090
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12C10B8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12BFFC4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12C10E0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12C1190
	public void .ctor(string typeName) { }

	// RVA: 0x12C1210
	public void .ctor(string typeName, string propertyName) { }

	// RVA: 0x12C12D0
	public void .ctor(Type type) { }

	// RVA: 0x12C13EC
	public string get_TypeName() { }

	// RVA: 0x12C13F4
	public string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public abstract class ComponentEditor
{
	// Methods

	// RVA: 0x12C13FC
	public bool EditComponent(object component) { }

	// RVA: -1
	public abstract bool EditComponent(ITypeDescriptorContext context, object component) { }

	// RVA: 0x12C1410
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter
{
	// Methods

	// RVA: 0x12C1418
	internal void .ctor() { }

	// RVA: 0x12C1420
	internal virtual bool get_AllowHex() { }

	// RVA: -1
	internal abstract Type get_TargetType() { }

	// RVA: -1
	internal abstract object FromString(string value, int radix) { }

	// RVA: -1
	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: -1
	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1428
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C14F4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C1910
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C1C10
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

	// RVA: 0x12C1C58
	public void .ctor(bool bindable) { }

	// RVA: 0x12C1C88
	public void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x12C1CC4
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12C1D08
	public void .ctor(BindableSupport flags, BindingDirection direction) { }

	// RVA: 0x12C1D58
	public bool get_Bindable() { }

	// RVA: 0x12C1D60
	public BindingDirection get_Direction() { }

	// RVA: 0x12C1D68
	public override bool Equals(object obj) { }

	// RVA: 0x12C1E18
	public override int GetHashCode() { }

	// RVA: 0x12C1E90
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12C1F2C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IList<T> list) { }

	// RVA: 0x30A2378
	private void Initialize() { }

	// RVA: 0x30A1224
	private bool get_ItemTypeHasDefaultConstructor() { }

	// RVA: 0x30A27C0
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30A27C0
	public void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30A27C0
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x30A17DC
	private object FireAddingNew() { }

	// RVA: 0x30A27C0
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30A27C0
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30A27C0
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x30A1224
	public bool get_RaiseListChangedEvents() { }

	// RVA: 0x30A2404
	public void set_RaiseListChangedEvents(bool value) { }

	// RVA: 0x30A2378
	public void ResetBindings() { }

	// RVA: 0x30A24F0
	public void ResetItem(int position) { }

	// RVA: 0x30A2560
	private void FireListChanged(ListChangedType type, int index) { }

	// RVA: 0x30A2378
	protected override void ClearItems() { }

	// RVA: 0x315B3A8
	protected override void InsertItem(int index, T item) { }

	// RVA: 0x30A24F0
	protected override void RemoveItem(int index) { }

	// RVA: 0x315B3A8
	protected override void SetItem(int index, T item) { }

	// RVA: 0x30A24F0
	public virtual void CancelNew(int itemIndex) { }

	// RVA: 0x30A24F0
	public virtual void EndNew(int itemIndex) { }

	// RVA: 0x315B3A8
	public T AddNew() { }

	// RVA: 0x30A17DC
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x30A1224
	private bool get_AddingNewHandled() { }

	// RVA: 0x30A17DC
	protected virtual object AddNewCore() { }

	// RVA: 0x30A1224
	public bool get_AllowNew() { }

	// RVA: 0x30A2404
	public void set_AllowNew(bool value) { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x30A1224
	public bool get_AllowEdit() { }

	// RVA: 0x30A2404
	public void set_AllowEdit(bool value) { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x30A1224
	public bool get_AllowRemove() { }

	// RVA: 0x30A2404
	public void set_AllowRemove(bool value) { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x30A1224
	protected virtual bool get_SupportsChangeNotificationCore() { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x30A1224
	protected virtual bool get_SupportsSearchingCore() { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x30A1224
	protected virtual bool get_SupportsSortingCore() { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x30A1224
	protected virtual bool get_IsSortedCore() { }

	// RVA: 0x30A17DC
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x30A17DC
	protected virtual PropertyDescriptor get_SortPropertyCore() { }

	// RVA: 0x30A14A4
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x30A14A4
	protected virtual ListSortDirection get_SortDirectionCore() { }

	// RVA: 0x30A2828
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30A2828
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30A2378
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x30A2378
	protected virtual void RemoveSortCore() { }

	// RVA: -1
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }

	// RVA: -1
	protected virtual int FindCore(PropertyDescriptor prop, object key) { }

	// RVA: 0x30A27C0
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }

	// RVA: 0x30A27C0
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }

	// RVA: 0x315B3A8
	private void HookPropertyChanged(T item) { }

	// RVA: 0x315B3A8
	private void UnhookPropertyChanged(T item) { }

	// RVA: 0x30A2A20
	private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x30A1224
	private bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter
{
	// Fields
	private static StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x12C1FE8
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C20B4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C22B4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12C2460
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12C2468
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12C2470
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter
{
	// Methods

	// RVA: 0x12C2478
	internal override Type get_TargetType() { }

	// RVA: 0x12C2518
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12C25B4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C2630
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C26E8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler
{
	// Methods

	// RVA: 0x12C26F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C2814
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x12C2828
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C2884
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CharConverter
{
	// Methods

	// RVA: 0x12C2890
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C295C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C2A90
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C2C24
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

	// RVA: 0x12C2C2C
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x12C2CB4
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x12C2CBC
	public virtual object get_Element() { }

}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler
{
	// Methods

	// RVA: 0x12C2CC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C2DE8
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x12C2DFC
	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C2E58
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

	// RVA: 0x12C2E64
	public void .ctor() { }

	// RVA: 0x12C2E6C
	public void .ctor(string dataSource) { }

	// RVA: 0x12C2EA0
	public void .ctor(string dataSource, string dataMember) { }

	// RVA: 0x12C2EF0
	public string get_DataSource() { }

	// RVA: 0x12C2EF8
	public string get_DataMember() { }

	// RVA: 0x12C2F00
	public override bool Equals(object obj) { }

	// RVA: 0x12C2F98
	public override int GetHashCode() { }

	// RVA: 0x12C2FA0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentResourceManager
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Methods

	// RVA: 0x12C300C
	public void .ctor() { }

	// RVA: 0x12C3094
	public void .ctor(Type t) { }

	// RVA: 0x12C3100
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x12C31A8
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x12C31B8
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x12C4078
	private System.Collections.Generic.SortedList<System.String,System.Object> FillResources(CultureInfo culture, ResourceSet resourceSet) { }

}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService
{
	// Methods

	// RVA: 0x12C4620
	protected void .ctor() { }

	// RVA: 0x12C4628
	public virtual ComponentCollection FilterComponents(ComponentCollection components) { }

}

// Namespace: 
private class CultureComparer
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x12C59C8
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x12C5A14
	public int Compare(object item1, object item2) { }

}

// Namespace: 
private static class CultureInfoMapper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x12C5B88
	private static System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }

	// RVA: 0x12C51F0
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x12C9C6C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class CultureInfoConverter
{
	// Fields
	private StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Methods

	// RVA: 0x12C4630
	private string get_DefaultCultureString() { }

	// RVA: 0x12C4674
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x12C469C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C4768
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12C4834
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C52B8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C5778
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12C59FC
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12C5A04
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12C5A0C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x12C9CC8
	protected void .ctor() { }

	// RVA: 0x12C9CD0
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x12C9D04
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x12C9E04
	public virtual string GetClassName() { }

	// RVA: 0x12C9EC8
	public virtual string GetComponentName() { }

	// RVA: 0x12C9F8C
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x12CA078
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x12CA13C
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x12CA200
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x12CA2C8
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x12CA3CC
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x12CA4D8
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x12CA5DC
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x12CA6E8
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

	// RVA: 0x12CA7B0
	public void .ctor() { }

	// RVA: 0x12CA7DC
	public void .ctor(bool isDataObject) { }

	// RVA: 0x12CA808
	public bool get_IsDataObject() { }

	// RVA: 0x12CA810
	public override bool Equals(object obj) { }

	// RVA: 0x12CA8C0
	public override int GetHashCode() { }

	// RVA: 0x12CA938
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CA9AC
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

	// RVA: 0x12CAA60
	public void .ctor(bool primaryKey) { }

	// RVA: 0x12CAAEC
	public void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x12CAB34
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x12CAA98
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	// RVA: 0x12CAB80
	public bool get_IsIdentity() { }

	// RVA: 0x12CAB88
	public bool get_IsNullable() { }

	// RVA: 0x12CAB90
	public int get_Length() { }

	// RVA: 0x12CAB98
	public bool get_PrimaryKey() { }

	// RVA: 0x12CABA0
	public override bool Equals(object obj) { }

	// RVA: 0x12CACA0
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectMethodAttribute
{
	// Fields
	private readonly bool <IsDefault>k__BackingField; // 0x10
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Methods

	// RVA: 0x12CACA8
	public void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x12CACD8
	public void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	// RVA: 0x12CAD14
	public bool get_IsDefault() { }

	// RVA: 0x12CAD1C
	public DataObjectMethodType get_MethodType() { }

	// RVA: 0x12CAD24
	public override bool Equals(object obj) { }

	// RVA: 0x12CADE4
	public override int GetHashCode() { }

	// RVA: 0x12CAE78
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

	// RVA: 0x12CAF1C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12CAFE8
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12CB0B4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12CB400
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12CB844
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DecimalConverter
{
	// Methods

	// RVA: 0x12CB84C
	internal override bool get_AllowHex() { }

	// RVA: 0x12CB854
	internal override Type get_TargetType() { }

	// RVA: 0x12CB8F4
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12CB9C0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12CBD24
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12CBE18
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12CBED0
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12CBFC4
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultBindingPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12CBFCC
	public void .ctor() { }

	// RVA: 0x12CBFD4
	public void .ctor(string name) { }

	// RVA: 0x12CC008
	public string get_Name() { }

	// RVA: 0x12CC010
	public override bool Equals(object obj) { }

	// RVA: 0x12CC094
	public override int GetHashCode() { }

	// RVA: 0x12CC09C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Methods

	// RVA: 0x12CC108
	public void .ctor(string name) { }

	// RVA: 0x12CC13C
	public string get_Name() { }

	// RVA: 0x12CC144
	public override bool Equals(object obj) { }

	// RVA: 0x12CC1C8
	public override int GetHashCode() { }

	// RVA: 0x12CC1D0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12CC24C
	public void .ctor(string name) { }

	// RVA: 0x12CC280
	public string get_Name() { }

	// RVA: 0x12CC288
	public override bool Equals(object obj) { }

	// RVA: 0x12CC30C
	public override int GetHashCode() { }

	// RVA: 0x12CC314
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider
{
	// Fields
	private readonly Type _type; // 0x20

	// Methods

	// RVA: 0x12CC390
	internal void .ctor(Type type) { }

	// RVA: 0x12CC3CC
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x12CC45C
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12CC528
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x12CC5CC
	public override string GetFullComponentName(object component) { }

	// RVA: 0x12CC670
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12CC714
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12CC7B8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12CC86C
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x12CC910
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12CC9C4
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

	// RVA: 0x12CCA68
	public void .ctor() { }

	// RVA: 0x12CCB10
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	// RVA: 0x12CCB3C
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x12CCB44
	public override bool Equals(object value) { }

	// RVA: 0x12CCBE8
	public override int GetHashCode() { }

	// RVA: 0x12CCBF0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CCC64
	public override string ToString() { }

	// RVA: 0x12CCD64
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

	// RVA: 0x12CCE4C
	public void .ctor() { }

	// RVA: 0x12CCFE0
	public void .ctor(Type tabClass) { }

	// RVA: 0x12CD178
	public void .ctor(string tabClassName) { }

	// RVA: 0x12CCFE8
	public void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x12CD180
	public void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x12CD2EC
	public Type[] get_TabClasses() { }

	// RVA: 0x12CD64C
	protected string[] get_TabClassNames() { }

	// RVA: 0x12CD6C4
	public PropertyTabScope[] get_TabScopes() { }

	// RVA: 0x12CD6CC
	private void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x12CD6D4
	public override bool Equals(object other) { }

	// RVA: 0x12CD770
	public bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x12CD928
	public override int GetHashCode() { }

	// RVA: 0x12CD930
	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12CDC78
	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12CD93C
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

	// RVA: 0x12CDC88
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CDCFC
	public void .ctor(bool defaultType) { }

	// RVA: 0x12CDD78
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x12CDE34
	public void .ctor(Type toolboxItemType) { }

	// RVA: 0x12CDE94
	public Type get_ToolboxItemType() { }

	// RVA: 0x12CE074
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x12CE0E0
	public override bool Equals(object obj) { }

	// RVA: 0x12CE210
	public override int GetHashCode() { }

	// RVA: 0x12CE234
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

	// RVA: 0x12CE308
	public void .ctor(bool visible) { }

	// RVA: 0x12CE334
	public void .ctor() { }

	// RVA: 0x12CE33C
	public bool get_Visible() { }

	// RVA: 0x12CE344
	public override bool Equals(object obj) { }

	// RVA: 0x12CE3F4
	public override int GetHashCode() { }

	// RVA: 0x12CE4B4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CE55C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter
{
	// Methods

	// RVA: 0x12CE610
	internal override bool get_AllowHex() { }

	// RVA: 0x12CE618
	internal override Type get_TargetType() { }

	// RVA: 0x12CE6B8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12CE780
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12CE7FC
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12CE8B4
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

	// RVA: 0x12CE8BC
	public void .ctor() { }

	// RVA: 0x12CE940
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x12CEA18
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x12CEB0C
	public void .ctor(Type type, Type baseType) { }

	// RVA: 0x12CEB90
	public string get_EditorBaseTypeName() { }

	// RVA: 0x12CEB98
	public string get_EditorTypeName() { }

	// RVA: 0x12CEBA0
	public override object get_TypeId() { }

	// RVA: 0x12CEC5C
	public override bool Equals(object obj) { }

	// RVA: 0x12CED24
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor
{
	// Methods

	// RVA: 0x12CED2C
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12CED34
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12CED3C
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

	// RVA: 0x12CFC10
	public void .ctor(Array array, int count) { }

	// RVA: 0x12D04F0
	public bool MoveNext() { }

	// RVA: 0x12D0514
	public void Reset() { }

	// RVA: 0x12D0520
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

	// RVA: 0x12CED44
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x12CEE74
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x12CEE9C
	private void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12CEFBC
	public int get_Count() { }

	// RVA: 0x12CEFC4
	private void set_Count(int value) { }

	// RVA: 0x12CEFCC
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x12CF11C
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x12CF130
	public int Add(EventDescriptor value) { }

	// RVA: 0x12CF324
	public void Clear() { }

	// RVA: 0x12CF37C
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x12CF450
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12CF054
	private void EnsureEventsOwned() { }

	// RVA: 0x12CF204
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12CF7B8
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12CF3EC
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x12CF8E0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x12CF9D4
	public void Remove(EventDescriptor value) { }

	// RVA: 0x12CFA98
	public void RemoveAt(int index) { }

	// RVA: 0x12CFB60
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12CFC5C
	public virtual EventDescriptorCollection Sort() { }

	// RVA: 0x12CFCE0
	public virtual EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12CFD68
	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12CFDF0
	public virtual EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12CF498
	protected void InternalSort(string[] names) { }

	// RVA: 0x12CFE74
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x12CFF14
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12CFF1C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12CFF24
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12CFF2C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12CFF30
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12CFF40
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12D00C4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12D0154
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12D0224
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12D027C
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12D0340
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12D03D8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12D0468
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12D046C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12D0474
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12D047C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter
{
	// Methods

	// RVA: 0x12D0588
	public void .ctor() { }

	// RVA: 0x12D0590
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12D05FC
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Methods

	// RVA: 0x12D0604
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x12D0894
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x12D09DC
	public override bool CanResetValue(object comp) { }

	// RVA: 0x12D0A08
	public override Type get_ComponentType() { }

	// RVA: 0x12D0A30
	public override bool get_IsReadOnly() { }

	// RVA: 0x12D0B24
	public override Type get_PropertyType() { }

	// RVA: 0x12D0B4C
	public override string get_DisplayName() { }

	// RVA: 0x12D0D44
	public override object GetValue(object comp) { }

	// RVA: 0x12D0D70
	public override void ResetValue(object comp) { }

	// RVA: 0x12D0D9C
	public override void SetValue(object component, object value) { }

	// RVA: 0x12D0DCC
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

	// RVA: 0x12D07E8
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x12D0DF8
	public void .ctor() { }

	// RVA: 0x12D0E00
	public PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0x12D0E08
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	// RVA: 0x12D0E10
	public IExtenderProvider get_Provider() { }

	// RVA: 0x12D0E18
	private void set_Provider(IExtenderProvider value) { }

	// RVA: 0x12D0E20
	public Type get_ReceiverType() { }

	// RVA: 0x12D0E28
	private void set_ReceiverType(Type value) { }

	// RVA: 0x12D0E30
	public override bool Equals(object obj) { }

	// RVA: 0x12D0F2C
	public override int GetHashCode() { }

	// RVA: 0x12D0F34
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter
{
	// Methods

	// RVA: 0x12D0FA0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D106C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12D1138
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D1228
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12D158C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class HandledEventArgs
{
	// Fields
	private bool <Handled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12D1594
	public void .ctor() { }

	// RVA: 0x12D1600
	public void .ctor(bool defaultHandledValue) { }

	// RVA: 0x12D1670
	public bool get_Handled() { }

	// RVA: 0x12D1678
	public void set_Handled(bool value) { }

}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler
{
	// Methods

	// RVA: 0x12D1680
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12D17A4
	public virtual void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x12D17B8
	public virtual IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12D1814
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

	// RVA: 0x12D1820
	public void .ctor(Type installerType) { }

	// RVA: 0x12D1870
	public void .ctor(string typeName) { }

	// RVA: 0x12D18A4
	public virtual Type get_InstallerType() { }

	// RVA: 0x12D1938
	public override bool Equals(object obj) { }

	// RVA: 0x12D19F4
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor
{
	// Methods

	// RVA: 0x12D19FC
	public virtual string get_Text() { }

	// RVA: -1
	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType) { }

	// RVA: 0x12D1A40
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int16Converter
{
	// Methods

	// RVA: 0x12D1A48
	internal override Type get_TargetType() { }

	// RVA: 0x12D1AE8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12D1B84
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1C00
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1CB8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter
{
	// Methods

	// RVA: 0x12D1CC0
	internal override Type get_TargetType() { }

	// RVA: 0x12D1D60
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12D1DFC
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1E78
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1F30
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter
{
	// Methods

	// RVA: 0x12D1F38
	internal override Type get_TargetType() { }

	// RVA: 0x12D1FD8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12D2074
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D20F0
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D21A8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidAsynchronousStateException
{
	// Methods

	// RVA: 0x12D21B0
	public void .ctor() { }

	// RVA: 0x12D21BC
	public void .ctor(string message) { }

	// RVA: 0x12D21C4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12D21CC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private class LicFileLicense
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12D273C
	public void .ctor(LicFileLicenseProvider owner, string key) { }

	// RVA: 0x12D27A4
	public override string get_LicenseKey() { }

	// RVA: 0x12D27AC
	public override void Dispose() { }

}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider
{
	// Methods

	// RVA: 0x12D21D4
	protected virtual bool IsKeyValid(string key, Type type) { }

	// RVA: 0x12D221C
	protected virtual string GetKey(Type type) { }

	// RVA: 0x12D22DC
	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12D278C
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

	// RVA: 0x12D279C
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class LicenseContext
{
	// Methods

	// RVA: 0x12D2834
	public virtual LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12D283C
	public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x12D2844
	public virtual object GetService(Type type) { }

	// RVA: 0x12D284C
	public virtual void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x12D2850
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

	// RVA: 0x12D2858
	private void .ctor() { }

	// RVA: 0x12D2860
	public static LicenseContext get_CurrentContext() { }

	// RVA: 0x12D2A50
	public static void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x12D2BF0
	public static LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12D2CB4
	private static void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x12D2EDC
	public static object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x12D2FDC
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x12D3448
	private static bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x12D3524
	private static LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x12D3624
	private static LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x12D3724
	public static bool IsLicensed(Type type) { }

	// RVA: 0x12D38C0
	public static bool IsValid(Type type) { }

	// RVA: 0x12D39C4
	public static bool IsValid(Type type, object instance, License license) { }

	// RVA: 0x12D32B8
	public static void LockContext(object contextUser) { }

	// RVA: 0x12D3AB4
	public static void UnlockContext(object contextUser) { }

	// RVA: 0x12D3828
	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, License license) { }

	// RVA: 0x12D3C48
	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, License license, string licenseKey) { }

	// RVA: 0x12D4134
	public static void Validate(Type type) { }

	// RVA: 0x12D426C
	public static License Validate(Type type, object instance) { }

	// RVA: 0x12D439C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class LicenseProvider
{
	// Methods

	// RVA: -1
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12D2794
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

	// RVA: 0x12D444C
	public void .ctor() { }

	// RVA: 0x12D447C
	public void .ctor(string typeName) { }

	// RVA: 0x12D44B0
	public void .ctor(Type type) { }

	// RVA: 0x12D401C
	public Type get_LicenseProvider() { }

	// RVA: 0x12D44E4
	public override object get_TypeId() { }

	// RVA: 0x12D45C0
	public override bool Equals(object value) { }

	// RVA: 0x12D4704
	public override int GetHashCode() { }

	// RVA: 0x12D470C
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

	// RVA: 0x12D4788
	public void .ctor(bool listBindable) { }

	// RVA: 0x12D47B4
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12D47F4
	public bool get_ListBindable() { }

	// RVA: 0x12D47FC
	public override bool Equals(object obj) { }

	// RVA: 0x12D48AC
	public override int GetHashCode() { }

	// RVA: 0x12D48B4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12D4950
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

	// RVA: 0x12D4A04
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x12D4B0C
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x12D4BA8
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x12D4A88
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x12D4C30
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x12D4C38
	public int get_NewIndex() { }

	// RVA: 0x12D4C40
	public int get_OldIndex() { }

	// RVA: 0x12D4C48
	public PropertyDescriptor get_PropertyDescriptor() { }

}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler
{
	// Methods

	// RVA: 0x12D4C50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12D4D74
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x12D4D88
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12D4DE4
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

	// RVA: 0x12D4DF0
	public void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x12D4E38
	public PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x12D4E40
	public void set_PropertyDescriptor(PropertyDescriptor value) { }

	// RVA: 0x12D4E48
	public ListSortDirection get_SortDirection() { }

	// RVA: 0x12D4E50
	public void set_SortDirection(ListSortDirection value) { }

}

// Namespace: System.ComponentModel
public class ListSortDescriptionCollection
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Methods

	// RVA: 0x12D4E58
	public void .ctor() { }

	// RVA: 0x12D4ED0
	public void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x12D4F9C
	public ListSortDescription get_Item(int index) { }

	// RVA: 0x12D5040
	public void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x12D5094
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12D509C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12D50A4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12D5148
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12D519C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12D51F0
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12D5244
	public bool Contains(object value) { }

	// RVA: 0x12D52FC
	public int IndexOf(object value) { }

	// RVA: 0x12D53B4
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12D5408
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12D545C
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12D54B0
	public int get_Count() { }

	// RVA: 0x12D54D8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12D54E0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12D54E4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12D550C
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

	// RVA: 0x12D5534
	public void .ctor() { }

	// RVA: 0x12D5594
	public void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	// RVA: 0x12D5614
	public string get_DataSource() { }

	// RVA: 0x12D561C
	public string get_DisplayMember() { }

	// RVA: 0x12D5624
	public string get_ValueMember() { }

	// RVA: 0x12D562C
	public string get_LookupMember() { }

	// RVA: 0x12D5634
	public override bool Equals(object obj) { }

	// RVA: 0x12D56F4
	public override int GetHashCode() { }

	// RVA: 0x12D56FC
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

	// RVA: 0x12D57A8
	public void .ctor() { }

	// RVA: 0x12D57B0
	protected override void Finalize() { }

	// RVA: 0x12D584C
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x12D59D8
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x12D594C
	protected EventHandlerList get_Events() { }

	// RVA: 0x12D5AD8
	public virtual ISite get_Site() { }

	// RVA: 0x12D5AE0
	public virtual void set_Site(ISite value) { }

	// RVA: 0x12D5AE8
	public void Dispose() { }

	// RVA: 0x12D5B78
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12D5E24
	public virtual IContainer get_Container() { }

	// RVA: 0x12D5EE8
	public virtual object GetService(Type service) { }

	// RVA: 0x12D5FAC
	public virtual bool get_DesignMode() { }

	// RVA: 0x12D6070
	public override string ToString() { }

	// RVA: 0x12D61B0
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

	// RVA: 0x12D6C54
	public void .ctor(int maskPos, CharType charType) { }

	// RVA: 0x12DCAF0
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

	// RVA: 0x12D6238
	public void .ctor(string mask) { }

	// RVA: 0x12D6690
	public void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x12D66A8
	public void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x12D66BC
	public void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x12D66D0
	public void .ctor(string mask, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12D66E4
	public void .ctor(string mask, CultureInfo culture, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12D6250
	public void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, Char promptChar, Char passwordChar, bool restrictToAscii) { }

	// RVA: 0x12D67FC
	private void Initialize() { }

	// RVA: 0x12D6CB8
	public bool get_AllowPromptAsInput() { }

	// RVA: 0x12D6D2C
	public int get_AssignedEditPositionCount() { }

	// RVA: 0x12D6D34
	private void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x12D6D3C
	public int get_AvailableEditPositionCount() { }

	// RVA: 0x12D6D5C
	public object Clone() { }

	// RVA: 0x12D7BF4
	public CultureInfo get_Culture() { }

	// RVA: 0x12D7BFC
	public static Char get_DefaultPasswordChar() { }

	// RVA: 0x12D6D50
	public int get_EditPositionCount() { }

	// RVA: 0x12D7C04
	public IEnumerator get_EditPositions() { }

	// RVA: 0x12D7A14
	public bool get_IncludeLiterals() { }

	// RVA: 0x12D7A88
	public void set_IncludeLiterals(bool value) { }

	// RVA: 0x12D7B04
	public bool get_IncludePrompt() { }

	// RVA: 0x12D7B78
	public void set_IncludePrompt(bool value) { }

	// RVA: 0x12D76A4
	public bool get_AsciiOnly() { }

	// RVA: 0x12D7F08
	public bool get_IsPassword() { }

	// RVA: 0x12D7F18
	public void set_IsPassword(bool value) { }

	// RVA: 0x12D7FD4
	public static int get_InvalidIndex() { }

	// RVA: 0x12D7FDC
	public int get_LastAssignedPosition() { }

	// RVA: 0x12D8134
	public int get_Length() { }

	// RVA: 0x12D8154
	public string get_Mask() { }

	// RVA: 0x12D815C
	public bool get_MaskCompleted() { }

	// RVA: 0x12D816C
	public bool get_MaskFull() { }

	// RVA: 0x12D8184
	public Char get_PasswordChar() { }

	// RVA: 0x12D818C
	public void set_PasswordChar(Char value) { }

	// RVA: 0x12D836C
	public Char get_PromptChar() { }

	// RVA: 0x12D8374
	public void set_PromptChar(Char value) { }

	// RVA: 0x12D78B8
	public bool get_ResetOnPrompt() { }

	// RVA: 0x12D7718
	public void set_ResetOnPrompt(bool value) { }

	// RVA: 0x12D792C
	public bool get_ResetOnSpace() { }

	// RVA: 0x12D7794
	public void set_ResetOnSpace(bool value) { }

	// RVA: 0x12D79A0
	public bool get_SkipLiterals() { }

	// RVA: 0x12D7810
	public void set_SkipLiterals(bool value) { }

	// RVA: 0x12D8610
	public Char get_Item(int index) { }

	// RVA: 0x12D86D0
	public bool Add(Char input) { }

	// RVA: 0x12D86F8
	public bool Add(Char input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D89B4
	public bool Add(string input) { }

	// RVA: 0x12D89E0
	public bool Add(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D8B00
	public void Clear() { }

	// RVA: 0x12D8B5C
	public void Clear(MaskedTextResultHint resultHint) { }

	// RVA: 0x12D80AC
	public int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12D8C9C
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12D8898
	public int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12D8E54
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12D8CB4
	private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, Byte assignedStatus) { }

	// RVA: 0x12D8FAC
	public int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12D9010
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12D8E5C
	private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags) { }

	// RVA: 0x12D9018
	public int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12D907C
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12D9208
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x12D9214
	public bool InsertAt(Char input, int position) { }

	// RVA: 0x12D930C
	public bool InsertAt(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D92E0
	public bool InsertAt(string input, int position) { }

	// RVA: 0x12D93AC
	public bool InsertAt(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D9490
	private bool InsertAtInt(string input, int position, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12DA230
	private static bool IsAscii(Char c) { }

	// RVA: 0x12DA240
	private static bool IsAciiAlphanumeric(Char c) { }

	// RVA: 0x12DA26C
	private static bool IsAlphanumeric(Char c) { }

	// RVA: 0x12DA338
	private static bool IsAsciiLetter(Char c) { }

	// RVA: 0x12DA34C
	public bool IsAvailablePosition(int position) { }

	// RVA: 0x12D852C
	public bool IsEditPosition(int position) { }

	// RVA: 0x12D6C90
	private static bool IsEditPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12DA43C
	private static bool IsLiteralPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12D66F8
	private static bool IsPrintableChar(Char c) { }

	// RVA: 0x12DA464
	public static bool IsValidInputChar(Char c) { }

	// RVA: 0x12DA4E4
	public static bool IsValidMaskChar(Char c) { }

	// RVA: 0x12D8300
	public static bool IsValidPasswordChar(Char c) { }

	// RVA: 0x12DA564
	public bool Remove() { }

	// RVA: 0x12DA59C
	public bool Remove(int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DA600
	public bool RemoveAt(int position) { }

	// RVA: 0x12DA670
	public bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x12DA708
	public bool RemoveAt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DA7B0
	private bool RemoveAtInt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12D788C
	public bool Replace(Char input, int position) { }

	// RVA: 0x12DADD8
	public bool Replace(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DB014
	public bool Replace(Char input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DB548
	public bool Replace(string input, int position) { }

	// RVA: 0x12DB574
	public bool Replace(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DB1A4
	public bool Replace(string input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D8BC8
	private void ResetChar(int testPosition) { }

	// RVA: 0x12DABA8
	private void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x12DB6BC
	public bool Set(string input) { }

	// RVA: 0x12DB6E8
	public bool Set(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DA054
	private void SetChar(Char input, int position) { }

	// RVA: 0x12DB8E0
	private void SetChar(Char input, int position, CharDescriptor charDescriptor) { }

	// RVA: 0x12DA0E0
	private void SetString(string input, int testPosition) { }

	// RVA: 0x12D9A90
	private bool TestChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DAF88
	private bool TestEscapeChar(Char input, int position) { }

	// RVA: 0x12DBAD8
	private bool TestEscapeChar(Char input, int position, CharDescriptor charDex) { }

	// RVA: 0x12D88FC
	private bool TestSetChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D8AB4
	private bool TestSetString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12D98B4
	private bool TestString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DBCB8
	public string ToDisplayString() { }

	// RVA: 0x12DBEF0
	public override string ToString() { }

	// RVA: 0x12DC4A8
	public string ToString(bool ignorePasswordChar) { }

	// RVA: 0x12DC5A8
	public string ToString(int startPosition, int length) { }

	// RVA: 0x12DC69C
	public string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x12DC794
	public string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x12DC7EC
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12DBFEC
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12DC804
	public bool VerifyChar(Char input, int position, MaskedTextResultHint hint) { }

	// RVA: 0x12DC888
	public bool VerifyEscapeChar(Char input, int position) { }

	// RVA: 0x12DC948
	public bool VerifyString(string input) { }

	// RVA: 0x12DC994
	public bool VerifyString(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12DC9C4
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

	// RVA: 0x12DCD48
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12DCEF8
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12DCF00
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DCF08
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

	// RVA: 0x12DD404
	internal void .ctor(IComponent component, NestedContainer container, string name) { }

	// RVA: 0x12DD644
	public IComponent get_Component() { }

	// RVA: 0x12DD64C
	public IContainer get_Container() { }

	// RVA: 0x12DD654
	public object GetService(Type service) { }

	// RVA: 0x12DD768
	public bool get_DesignMode() { }

	// RVA: 0x12DD964
	public string get_FullName() { }

	// RVA: 0x12DDA68
	public string get_Name() { }

	// RVA: 0x12DDA70
	public void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class NestedContainer
{
	// Fields
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Methods

	// RVA: 0x12DCF10
	public void .ctor(IComponent owner) { }

	// RVA: 0x12DD080
	public IComponent get_Owner() { }

	// RVA: 0x12DD088
	protected virtual string get_OwnerName() { }

	// RVA: 0x12DD31C
	protected override ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12DD468
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12DD578
	protected override object GetService(Type service) { }

	// RVA: 0x12DD63C
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

	// RVA: 0x12DDB48
	public void .ctor(Type type) { }

	// RVA: 0x12DDC98
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12DDD94
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12DDF08
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12DE004
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12DE240
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x12DE264
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE288
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12DE2AC
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE2D0
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12DE688
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12DE6B0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE6D8
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12DE70C
	public Type get_NullableType() { }

	// RVA: 0x12DE714
	public Type get_UnderlyingType() { }

	// RVA: 0x12DE71C
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

	// RVA: 0x12DE724
	public void .ctor() { }

	// RVA: 0x12DE74C
	public void .ctor(bool password) { }

	// RVA: 0x12DE778
	public bool get_Password() { }

	// RVA: 0x12DE780
	public override bool Equals(object o) { }

	// RVA: 0x12DE814
	public override int GetHashCode() { }

	// RVA: 0x12DE81C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12DE890
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

	// RVA: 0x12DE944
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12DE94C
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12D07E0
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: 0x12DE954
	public virtual TypeConverter get_Converter() { }

	// RVA: 0x12DF060
	public virtual bool get_IsLocalizable() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x12DF154
	public DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: -1
	public abstract Type get_PropertyType() { }

	// RVA: 0x12DF234
	public virtual void AddValueChanged(object component, EventHandler handler) { }

	// RVA: -1
	public abstract bool CanResetValue(object component) { }

	// RVA: 0x12DF39C
	public override bool Equals(object obj) { }

	// RVA: 0x12DEE18
	protected object CreateInstance(Type type) { }

	// RVA: 0x12DF5B0
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x12DF60C
	public PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x12DF624
	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x12DF63C
	public PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x12DF650
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x12DF708
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x12DFB20
	public override int GetHashCode() { }

	// RVA: 0x12DFB78
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x12DEBF4
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1
	public abstract object GetValue(object component) { }

	// RVA: 0x12DFC70
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x12DFD24
	public virtual void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12DFE9C
	protected internal EventHandler GetValueChangedHandler(object component) { }

	// RVA: -1
	public abstract void ResetValue(object component) { }

	// RVA: -1
	public abstract void SetValue(object component, object value) { }

	// RVA: -1
	public abstract bool ShouldSerializeValue(object component) { }

	// RVA: 0x12DFF38
	public virtual bool get_SupportsChangeEvents() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12E1890
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x12E2650
	public object get_Current() { }

	// RVA: 0x12E26FC
	public DictionaryEntry get_Entry() { }

	// RVA: 0x12E2770
	public object get_Key() { }

	// RVA: 0x12E27B0
	public object get_Value() { }

	// RVA: 0x12E27F0
	public bool MoveNext() { }

	// RVA: 0x12E2830
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

	// RVA: 0x12DFF40
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x12E0094
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x12E00BC
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12E0214
	public int get_Count() { }

	// RVA: 0x12E021C
	private void set_Count(int value) { }

	// RVA: 0x12E0224
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x12E0374
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x12E0388
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x12E057C
	public void Clear() { }

	// RVA: 0x12E05DC
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x12E06B0
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12E02AC
	private void EnsurePropsOwned() { }

	// RVA: 0x12E045C
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12E0A18
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12E064C
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x12E0FEC
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x12E10E0
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x12E11A4
	public void RemoveAt(int index) { }

	// RVA: 0x12E126C
	public virtual PropertyDescriptorCollection Sort() { }

	// RVA: 0x12E12F0
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12E1378
	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12E1400
	public virtual PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12E06F8
	protected void InternalSort(string[] names) { }

	// RVA: 0x12E1484
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x12E1524
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x12E15C0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12E15C8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12E15D0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12E15D8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12E1638
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x12E1698
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12E16A8
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12E16AC
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x12E177C
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x12E1814
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x12E18CC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x12E18D4
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x12E18DC
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x12E1968
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x12E1D5C
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x12E1E6C
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x12E1F70
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x12E2074
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12E2104
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12E21D4
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12E2298
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12E2330
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12E2338
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12E2340
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12E23D0
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12E23E0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12E25DC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute
{
	// Fields
	private readonly string <PropertyName>k__BackingField; // 0x10
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12E283C
	public void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x12E28A8
	public void .ctor(string propertyName, string receiverTypeName) { }

	// RVA: 0x12E28F8
	public string get_PropertyName() { }

	// RVA: 0x12E2900
	public string get_ReceiverTypeName() { }

	// RVA: 0x12E2908
	public override bool Equals(object obj) { }

	// RVA: 0x12E29D0
	public override int GetHashCode() { }

	// RVA: 0x12E2A20
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

	// RVA: 0x12E2A64
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x12E2A90
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x12E2A98
	public override bool Equals(object obj) { }

	// RVA: 0x12E2B64
	public override int GetHashCode() { }

	// RVA: 0x12E2B6C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E2B7C
	private static void .cctor() { }

}

// Namespace: 
private class ReferenceComparer
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x12E3D04
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x12E3DC8
	public int Compare(object item1, object item2) { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x12E2C30
	public void .ctor(Type type) { }

	// RVA: 0x12E2C64
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E2D34
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12E30C8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12E35B8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12E3D38
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12E3D40
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12E3D48
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12E3D50
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

	// RVA: 0x12E3E7C
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12E4030
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x12E41E8
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x12E42E4
	public override Type get_ComponentType() { }

	// RVA: 0x12E42EC
	public override Type get_EventType() { }

	// RVA: 0x12E4868
	public override bool get_IsMulticast() { }

	// RVA: 0x12E491C
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x12E50C8
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x12E5148
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x12E4310
	private void FillMethods() { }

	// RVA: 0x12E54C0
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x12E5878
	public override void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs
{
	// Fields
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12E5F74
	public void .ctor(object componentChanged) { }

	// RVA: 0x12E6010
	public void .ctor(Type typeChanged) { }

	// RVA: 0x12E6088
	public object get_ComponentChanged() { }

	// RVA: 0x12E6090
	public Type get_TypeChanged() { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler
{
	// Methods

	// RVA: 0x12E6098
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E61B8
	public virtual void Invoke(RefreshEventArgs e) { }

	// RVA: 0x12E61CC
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E621C
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

	// RVA: 0x12E6228
	public void .ctor(bool runInstaller) { }

	// RVA: 0x12E6254
	public bool get_RunInstaller() { }

	// RVA: 0x12E625C
	public override bool Equals(object obj) { }

	// RVA: 0x12E6328
	public override int GetHashCode() { }

	// RVA: 0x12E6330
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E63A4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SByteConverter
{
	// Methods

	// RVA: 0x12E6458
	internal override Type get_TargetType() { }

	// RVA: 0x12E64F8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E6594
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E6610
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E66C8
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

	// RVA: 0x12E66D0
	public void .ctor(bool bindable) { }

	// RVA: 0x12E66FC
	public bool get_Bindable() { }

	// RVA: 0x12E6704
	public override bool Equals(object obj) { }

	// RVA: 0x12E67B4
	public override int GetHashCode() { }

	// RVA: 0x12E682C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter
{
	// Methods

	// RVA: 0x12E68CC
	internal override bool get_AllowHex() { }

	// RVA: 0x12E68D4
	internal override Type get_TargetType() { }

	// RVA: 0x12E6974
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E6A3C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E6AB8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E6B70
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter
{
	// Methods

	// RVA: 0x12E6B78
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E6C44
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12E6CEC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public static class SyntaxCheck
{
	// Methods

	// RVA: 0x12E6CF4
	public static bool CheckMachineName(string value) { }

	// RVA: 0x12E6D94
	public static bool CheckPath(string value) { }

	// RVA: 0x12E6E3C
	public static bool CheckRootedPath(string value) { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter
{
	// Methods

	// RVA: 0x12E6F04
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E6FD0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12E709C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12E72A0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12E75E0
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

	// RVA: 0x12E75E8
	public void .ctor(string filterString) { }

	// RVA: 0x12E7684
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	// RVA: 0x12E7724
	public string get_FilterString() { }

	// RVA: 0x12E772C
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x12E7734
	public override object get_TypeId() { }

	// RVA: 0x12E77BC
	public override bool Equals(object obj) { }

	// RVA: 0x12E78E0
	public override int GetHashCode() { }

	// RVA: 0x12E7904
	public override bool Match(object obj) { }

	// RVA: 0x12E7990
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

	// RVA: 0x12E7AB0
	public void .ctor() { }

	// RVA: 0x12E7B1C
	public void .ctor(Type type) { }

	// RVA: 0x12E7B6C
	public void .ctor(string typeName) { }

	// RVA: 0x12E7BA0
	public string get_ConverterTypeName() { }

	// RVA: 0x12E7BA8
	public override bool Equals(object obj) { }

	// RVA: 0x12E7C2C
	public override int GetHashCode() { }

	// RVA: 0x12E7C50
	private static void .cctor() { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor
{
	// Methods

	// RVA: 0x12E7F1C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x12CC3C4
	protected void .ctor() { }

	// RVA: 0x12E7D08
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x12E7D3C
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12E7E4C
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x12E7E64
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12E7F24
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12E8080
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x12E8204
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x12E8214
	public Type GetReflectionType(object instance) { }

	// RVA: 0x12E82A0
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12E82BC
	public virtual Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x12E8448
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x12E8178
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x12E8458
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12E8518
	public virtual bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E861C
	public void .ctor(string typeName) { }

	// RVA: 0x12E869C
	public void .ctor(Type type) { }

	// RVA: 0x12E87B8
	public string get_TypeName() { }

}

// Namespace: System.ComponentModel
public abstract class TypeListConverter
{
	// Fields
	private readonly Type[] _types; // 0x10
	private StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x12E87C0
	protected void .ctor(Type[] types) { }

	// RVA: 0x12E87F4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E88C0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12E898C
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12E8AA0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12E8C84
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12E8D68
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12E8D70
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
public class UInt16Converter
{
	// Methods

	// RVA: 0x12E8D78
	internal override Type get_TargetType() { }

	// RVA: 0x12E8E18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E8EB4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E8F30
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E8FE8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter
{
	// Methods

	// RVA: 0x12E8FF0
	internal override Type get_TargetType() { }

	// RVA: 0x12E9090
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E912C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E91A8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E9260
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter
{
	// Methods

	// RVA: 0x12E9268
	internal override Type get_TargetType() { }

	// RVA: 0x12E9308
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E93A4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E9420
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E94D8
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

	// RVA: 0x12E94E0
	public void .ctor() { }

	// RVA: 0x12E9574
	public void .ctor(string message) { }

	// RVA: 0x12E95B4
	public void .ctor(string message, string helpUrl) { }

	// RVA: 0x12E95F8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12E9524
	public void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x12E9600
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12E97A8
	public string get_HelpUrl() { }

	// RVA: 0x12E97B0
	public string get_HelpTopic() { }

	// RVA: 0x12E97B8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public class CancelEventArgs
{
	// Fields
	private bool <Cancel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E9870
	public bool get_Cancel() { }

	// RVA: 0x12E9878
	public void set_Cancel(bool value) { }

	// RVA: 0x12E9880
	public void .ctor() { }

	// RVA: 0x12E9908
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

	// RVA: 0x12E9978
	public void .ctor(string propertyName) { }

	// RVA: 0x12E99F0
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

	// RVA: 0x12E99F8
	public void .ctor(string propertyName) { }

	// RVA: 0x12E9A70
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler
{
	// Methods

	// RVA: 0x12E9A78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9B9C
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x12E9BB0
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E9C0C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12E9C18
	public void .ctor(string propertyName) { }

	// RVA: 0x12E9C90
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler
{
	// Methods

	// RVA: 0x12E9C98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9DBC
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x12E9DD0
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E9E2C
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

	// RVA: 0x12E9E38
	public void .ctor(Array array, int count) { }

	// RVA: 0x12E9E84
	public bool MoveNext() { }

	// RVA: 0x12E9EA8
	public void Reset() { }

	// RVA: 0x12E9EB4
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

	// RVA: 0x12E9F1C
	public void .ctor() { }

	// RVA: 0x12E9FA4
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x12EA040
	public bool get_Cancelled() { }

	// RVA: 0x12EA048
	public Exception get_Error() { }

	// RVA: 0x12EA050
	public object get_UserState() { }

	// RVA: 0x12EA058
	protected void RaiseExceptionIfNecessary() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler
{
	// Methods

	// RVA: 0x12EA138
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12EA25C
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x12EA270
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12EA2CC
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

	// RVA: 0x12EA2D8
	public static CategoryAttribute get_Action() { }

	// RVA: 0x12EA3DC
	public static CategoryAttribute get_Appearance() { }

	// RVA: 0x12EA4AC
	public static CategoryAttribute get_Asynchronous() { }

	// RVA: 0x12EA574
	public static CategoryAttribute get_Behavior() { }

	// RVA: 0x12EA63C
	public static CategoryAttribute get_Data() { }

	// RVA: 0x12EA704
	public static CategoryAttribute get_Default() { }

	// RVA: 0x12EA854
	public static CategoryAttribute get_Design() { }

	// RVA: 0x12EA91C
	public static CategoryAttribute get_DragDrop() { }

	// RVA: 0x12EA9E4
	public static CategoryAttribute get_Focus() { }

	// RVA: 0x12EAAAC
	public static CategoryAttribute get_Format() { }

	// RVA: 0x12EAB74
	public static CategoryAttribute get_Key() { }

	// RVA: 0x12EAC3C
	public static CategoryAttribute get_Layout() { }

	// RVA: 0x12EAD04
	public static CategoryAttribute get_Mouse() { }

	// RVA: 0x12EADCC
	public static CategoryAttribute get_WindowStyle() { }

	// RVA: 0x12EA7E4
	public void .ctor() { }

	// RVA: 0x12EA3A0
	public void .ctor(string category) { }

	// RVA: 0x12EAE94
	public string get_Category() { }

	// RVA: 0x12EAF00
	public override bool Equals(object obj) { }

	// RVA: 0x12EB070
	public override int GetHashCode() { }

	// RVA: 0x12EB0DC
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x12EB430
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CollectionConverter
{
	// Methods

	// RVA: 0x12EB4F0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EB8F4
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12EB8FC
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12EB904
	public void .ctor() { }

}

// Namespace: System.ComponentModel
internal static class CompModSwitches
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Methods

	// RVA: 0x12EB914
	public static BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x12EB9F4
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

	// RVA: 0x12EBACC
	protected override void Finalize() { }

	// RVA: 0x12EBB6C
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x12EBB74
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x12EBB80
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x12EBD38
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x12EBC98
	protected EventHandlerList get_Events() { }

	// RVA: 0x12EBE50
	public virtual ISite get_Site() { }

	// RVA: 0x12EBE58
	public virtual void set_Site(ISite value) { }

	// RVA: 0x12EBE60
	public void Dispose() { }

	// RVA: 0x12EBEF4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12EC220
	public IContainer get_Container() { }

	// RVA: 0x12EC2E4
	protected virtual object GetService(Type service) { }

	// RVA: 0x12EC3A8
	protected bool get_DesignMode() { }

	// RVA: 0x12EC46C
	public override string ToString() { }

	// RVA: 0x12EC5AC
	public void .ctor() { }

	// RVA: 0x12EC5B4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentConverter
{
	// Methods

	// RVA: 0x12EC63C
	public void .ctor(Type type) { }

	// RVA: 0x12EC6A8
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12EC880
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

	// RVA: 0x12ECE90
	internal void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x12EE0CC
	public IComponent get_Component() { }

	// RVA: 0x12EE0D4
	public IContainer get_Container() { }

	// RVA: 0x12EE0DC
	public object GetService(Type service) { }

	// RVA: 0x12EE1B0
	public bool get_DesignMode() { }

	// RVA: 0x12EE1B8
	public string get_Name() { }

	// RVA: 0x12EE1C0
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

	// RVA: 0x12EC888
	protected override void Finalize() { }

	// RVA: 0x12EC924
	public virtual void Add(IComponent component) { }

	// RVA: 0x12EC934
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x12ECDEC
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12ECEF4
	public void Dispose() { }

	// RVA: 0x12ECF84
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12ED2D4
	protected virtual object GetService(Type service) { }

	// RVA: 0x12ED378
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x12ED814
	public virtual void Remove(IComponent component) { }

	// RVA: 0x12ED81C
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x12EDB34
	protected void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x12EDB3C
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x12EE054
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter
{
	// Methods

	// RVA: 0x12EE238
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12EE3CC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12EE560
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12EE9BC
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EF648
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

	// RVA: 0x12EF650
	public void .ctor(string designerTypeName) { }

	// RVA: 0x12EF77C
	public void .ctor(Type designerType) { }

	// RVA: 0x12EF858
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x12EF930
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x12EFA24
	public void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x12EFAA8
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x12EFAB0
	public string get_DesignerTypeName() { }

	// RVA: 0x12EFAB8
	public override object get_TypeId() { }

	// RVA: 0x12EFB74
	public override bool Equals(object obj) { }

	// RVA: 0x12EFC3C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public class DoWorkEventArgs
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Methods

	// RVA: 0x12EFC8C
	public void .ctor(object argument) { }

	// RVA: 0x12EFCC0
	public object get_Argument() { }

	// RVA: 0x12EFCC8
	public object get_Result() { }

	// RVA: 0x12EFCD0
	public void set_Result(object value) { }

}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler
{
	// Methods

	// RVA: 0x12EFCD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12EFDFC
	public virtual void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x12EFE10
	public virtual IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12EFE6C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class EnumConverter
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x12EFE78
	public void .ctor(Type type) { }

	// RVA: 0x12EFEAC
	protected Type get_EnumType() { }

	// RVA: 0x12EFEB4
	protected StandardValuesCollection get_Values() { }

	// RVA: 0x12EFEBC
	protected void set_Values(StandardValuesCollection value) { }

	// RVA: 0x12EFEC4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F0014
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F0164
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x12F01E0
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F0758
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F163C
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12F1C7C
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12F1D48
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12F1D50
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

	// RVA: 0x12F1DC0
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

	// RVA: 0x12F1E48
	public void .ctor(Type type) { }

	// RVA: 0x12F1FD8
	public void .ctor(Type type, object instance) { }

	// RVA: 0x12F1F74
	public void .ctor(Type type, object instance, string message) { }

	// RVA: 0x12F2164
	public void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x12F21CC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F2378
	public Type get_LicensedType() { }

	// RVA: 0x12F2380
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

	// RVA: 0x12F247C
	protected void .ctor(string name) { }

	// RVA: 0x12F2484
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x12F2670
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12F27C8
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x12F2C24
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x12F34A8
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x12F35A8
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x12F36BC
	public virtual string get_Category() { }

	// RVA: 0x12F3824
	public virtual string get_Description() { }

	// RVA: 0x12F3954
	public virtual bool get_IsBrowsable() { }

	// RVA: 0x12F3A34
	public virtual string get_Name() { }

	// RVA: 0x12F3A90
	protected virtual int get_NameHashCode() { }

	// RVA: 0x12F3A98
	public virtual bool get_DesignTimeOnly() { }

	// RVA: 0x12F3B8C
	public virtual string get_DisplayName() { }

	// RVA: 0x12F2C50
	private void CheckAttributesValid() { }

	// RVA: 0x12F3CB4
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x12F3D30
	public override bool Equals(object obj) { }

	// RVA: 0x12F3FB8
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x12F2D44
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x12F40B0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x12F412C
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x12F41F4
	public override int GetHashCode() { }

	// RVA: 0x12F41FC
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x12F4990
	protected static ISite GetSite(object component) { }

	// RVA: 0x12F4AB0
	protected static object GetInvokee(Type componentClass, object component) { }

}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Methods

	// RVA: 0x12F4BF4
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x12F4C7C
	public int get_ProgressPercentage() { }

	// RVA: 0x12F4C84
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler
{
	// Methods

	// RVA: 0x12F4C8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12F4DB0
	public virtual void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x12F4DC4
	public virtual IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12F4E20
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

	// RVA: 0x12F4E2C
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12F511C
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x12F5278
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x12F5370
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x12F5830
	private object get_AmbientValue() { }

	// RVA: 0x12F59EC
	private EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x12F5D58
	private EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x12F5F5C
	private void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x12F5FE8
	public override Type get_ComponentType() { }

	// RVA: 0x12F5FF0
	private object get_DefaultValue() { }

	// RVA: 0x12F62E0
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x12F67E8
	private bool get_IsExtender() { }

	// RVA: 0x12F6854
	public override bool get_IsReadOnly() { }

	// RVA: 0x12F6F84
	public override Type get_PropertyType() { }

	// RVA: 0x12F6F8C
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x12F6968
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x12F7254
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x12F751C
	public override void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12F76D4
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12F7B2C
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x12F7B34
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x12F79E0
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12F7B44
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x12F8064
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x12F8518
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12F89F4
	public override bool CanResetValue(object component) { }

	// RVA: 0x12F8D14
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x12F9E98
	public override object GetValue(object component) { }

	// RVA: 0x12FA1D4
	internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x12FA2DC
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x12FA3C0
	public override void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12FA57C
	public override void ResetValue(object component) { }

	// RVA: 0x12FA9F0
	public override void SetValue(object component, object value) { }

	// RVA: 0x12FB000
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x12FB388
	public override bool get_SupportsChangeEvents() { }

	// RVA: 0x12FB3CC
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

	// RVA: 0x1302680
	internal void .ctor(Type type) { }

	// RVA: 0x1302258
	internal bool get_IsPopulated() { }

	// RVA: 0x12FCA78
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x12FD3C4
	internal string GetClassName(object instance) { }

	// RVA: 0x12FD41C
	internal string GetComponentName(object instance) { }

	// RVA: 0x12FD638
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x12FDBAC
	internal EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x12FDE58
	internal PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x12FE15C
	internal object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x1304D78
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x12FED00
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0x1302294
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x130489C
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x1303AEC
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

	// RVA: 0x12FB630
	internal static Guid get_ExtenderProviderKey() { }

	// RVA: 0x12FB6AC
	internal void .ctor() { }

	// RVA: 0x12FB6B4
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x12FC16C
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x12FC440
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12FC678
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x12FC7B0
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x12FCFC4
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x12FD390
	internal string GetClassName(Type type) { }

	// RVA: 0x12FD3EC
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x12FD608
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x12FDB7C
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x12FDE28
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x12FE124
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x12FE84C
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x12FECE0
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x12FF0E4
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x12FF160
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x12FF1B8
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x12FF204
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x12FF250
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x12FF258
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x12FF260
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x12FF2BC
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x12FF338
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x130096C
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1300E2C
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x13019D0
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x1301AFC
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1301B04
	public override string GetFullComponentName(object component) { }

	// RVA: 0x1301D80
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x1302274
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x1301A70
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x1302678
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12FC7D0
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x13026B4
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x13026BC
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x13027D8
	internal bool IsPopulated(Type type) { }

	// RVA: 0x130280C
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x12F99F8
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x1302CAC
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x12FF9A0
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x13033DC
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x1303A64
	internal void Refresh(Type type) { }

	// RVA: 0x1303B68
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1304560
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs
{
	// Fields
	private object result; // 0x28

	// Methods

	// RVA: 0x1305118
	public void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x13051C4
	public object get_Result() { }

	// RVA: 0x13051E8
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler
{
	// Methods

	// RVA: 0x13051F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1305314
	public virtual void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x1305328
	public virtual IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1305384
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Methods

	// RVA: 0x1306064
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x1306100
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x1306158
	public override Type get_ComponentType() { }

	// RVA: 0x1306160
	public override bool get_IsReadOnly() { }

	// RVA: 0x13061EC
	public override Type get_PropertyType() { }

	// RVA: 0x13061F4
	public override bool CanResetValue(object component) { }

	// RVA: 0x1306344
	public override void ResetValue(object component) { }

	// RVA: 0x130647C
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public class StandardValuesCollection
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Methods

	// RVA: 0x12F1BAC
	public void .ctor(ICollection values) { }

	// RVA: 0x1306484
	public int get_Count() { }

	// RVA: 0x1306554
	public object get_Item(int index) { }

	// RVA: 0x1306760
	public void CopyTo(Array array, int index) { }

	// RVA: 0x130681C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13068D0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x13068D4
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13068DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13068E4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x13069A0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public class TypeConverter
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x1305390
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x13053E4
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x12EE340
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x13053F8
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x12EE4D4
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x130540C
	public object ConvertFrom(object value) { }

	// RVA: 0x12EE944
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x13055C0
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x130564C
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x13056D8
	public object ConvertFromString(string text) { }

	// RVA: 0x13056F0
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1305640
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x130577C
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x12EB688
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1305914
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x12F15B8
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1305A74
	public string ConvertToString(object value) { }

	// RVA: 0x1305B7C
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x130598C
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1305C88
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x1305C9C
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x130548C
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1305798
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x1305CA4
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x1305CB4
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1305CBC
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x1305CC8
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1305DC4
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1305DCC
	public bool GetPropertiesSupported() { }

	// RVA: 0x1305DDC
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1305DE4
	public ICollection GetStandardValues() { }

	// RVA: 0x1305DF4
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1305DFC
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x1305E10
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1305E18
	public bool GetStandardValuesSupported() { }

	// RVA: 0x1305E2C
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1305E34
	public bool IsValid(object value) { }

	// RVA: 0x1305E4C
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1306020
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x12EB90C
	public void .ctor() { }

}

// Namespace: 
private class AttributeTypeDescriptor
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x13141A8
	internal void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x13141E0
	public override AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class AttributeProvider
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x13140D0
	internal void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x1314104
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x13146AC
	internal void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x13146FC
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x13147BC
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1314880
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1314888
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x131494C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1314A10
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1314AD4
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1314B94
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1314C58
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1314D18
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1314DCC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1314E8C
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Methods

	// RVA: 0x13144A4
	internal void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x13144D8
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x13144E0
	internal void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x13144E8
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x1314E94
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x1314EE4
	internal bool IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x1314F5C
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x1314FAC
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

	// RVA: 0x1314FBC
	public int Compare(object left, object right) { }

	// RVA: 0x13150E0
	public void .ctor() { }

	// RVA: 0x13150E8
	private static void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x1315154
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x13151A4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x13152E4
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x131542C
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1315574
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x13156BC
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1315804
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x131594C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1315B30
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1315C78
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1315DBC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1315F04
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1316048
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x13164BC
	internal void .ctor(TypeDescriptionNode node, object instance) { }

	// RVA: 0x1316AE8
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1316DFC
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1317044
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1317260
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1317510
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x131772C
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1317948
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1317C08
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1317F20
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1318254
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1318504
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x13187CC
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

	// RVA: 0x13169A4
	internal void .ctor(TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x1318A18
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1318CC8
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1318F08
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1319124
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x13193D4
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x13195F0
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x131980C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1319ACC
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1319D80
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x131A04C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x131A300
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x131A5CC
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class TypeDescriptionNode
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x131618C
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x13161C0
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1316364
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x13163DC
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x13164F0
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1316568
	public override string GetFullComponentName(object component) { }

	// RVA: 0x13165E0
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x13166E4
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x13167D8
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x13169F4
	public override bool IsSupportedType(Type type) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject
{
	// Methods

	// RVA: 0x131A818
	public void .ctor() { }

}

// Namespace: 
private sealed class TypeDescriptorInterface
{
	// Methods

	// RVA: 0x131A820
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

	// RVA: 0x1306A54
	private void .ctor() { }

	// RVA: 0x1306A5C
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x1306CE0
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x1306BB8
	public static Type get_ComObjectType() { }

	// RVA: 0x13071B4
	public static Type get_InterfaceType() { }

	// RVA: 0x1307254
	internal static int get_MetadataVersion() { }

	// RVA: 0x13072D0
	public static void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x13073C0
	public static void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x13074B0
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0x130773C
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	// RVA: 0x1307BC8
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x1306F08
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1307914
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x13092DC
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1309400
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x13094F0
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1309B50
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x130A2F8
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x130A810
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x130A898
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x130A918
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x130AC74
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x130ACF8
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x130AED4
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x130AED8
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x130AEDC
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0x130AEE0
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x130AEE4
	private static void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0x130AEE8
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x130AEEC
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0x130AEF0
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x130AEF4
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0x130AEF8
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x130AEFC
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0x12F4340
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x12F985C
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x12EDFCC
	public static AttributeCollection GetAttributes(object component) { }

	// RVA: 0x130B544
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12FF8C0
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x130F064
	public static string GetClassName(object component) { }

	// RVA: 0x130F0EC
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130F200
	public static string GetClassName(Type componentType) { }

	// RVA: 0x1301CF8
	public static string GetComponentName(object component) { }

	// RVA: 0x130F32C
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130F440
	public static TypeConverter GetConverter(object component) { }

	// RVA: 0x130F4C8
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130F5DC
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x130F708
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x130F7EC
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x130F960
	public static EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x130F9E8
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130FAF8
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x130FC6C
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x130FCF4
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130B3E0
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x130B95C
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130BBD0
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x130FE04
	public static object GetEditor(object component, Type editorBaseType) { }

	// RVA: 0x130FE70
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x1310004
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x12F5BB4
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x13101A0
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x1304AA8
	public static EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x1310900
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131096C
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x1310434
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1311084
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x13113DC
	public static string GetFullComponentName(object component) { }

	// RVA: 0x1311498
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x1304BD4
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x13116A0
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x1304B10
	public static PropertyDescriptorCollection GetProperties(object component) { }

	// RVA: 0x1311934
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12EC7B8
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x1312058
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x13119A4
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x1307620
	public static TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0x1307858
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x13120D4
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0x12F1A3C
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x131215C
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x1306C58
	private static TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x1307C54
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x130EFDC
	private static TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x13087CC
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x1312278
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x13109D8
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x130CF58
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x130E7D0
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x130BCF0
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x1312660
	private static void RaiseRefresh(object component) { }

	// RVA: 0x1312738
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x1312810
	public static void Refresh(object component) { }

	// RVA: 0x1308A1C
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x1308180
	public static void Refresh(Type type) { }

	// RVA: 0x1312898
	public static void Refresh(Module module) { }

	// RVA: 0x131330C
	public static void Refresh(Assembly assembly) { }

	// RVA: 0x13133D8
	public static void RemoveAssociation(object primary, object secondary) { }

	// RVA: 0x1313798
	public static void RemoveAssociations(object primary) { }

	// RVA: 0x131387C
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1313990
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1313A70
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1313B94
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x130B34C
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1313C84
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1313D58
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x1313D5C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Methods

	// RVA: 0x131A828
	public void .ctor() { }

	// RVA: 0x131A8A8
	public void .ctor(int error) { }

	// RVA: 0x131B6D8
	public void .ctor(int error, string message) { }

	// RVA: 0x131B708
	public void .ctor(string message) { }

	// RVA: 0x131B788
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x131B814
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131B8A8
	public int get_NativeErrorCode() { }

	// RVA: 0x131B8B0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131A8E4
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

	// RVA: 0x131B984
	public void .ctor(bool notifyParent) { }

	// RVA: 0x131B9B0
	public bool get_NotifyParent() { }

	// RVA: 0x131B9B8
	public override bool Equals(object obj) { }

	// RVA: 0x131BA5C
	public override int GetHashCode() { }

	// RVA: 0x131BA64
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131BAD8
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ParenthesizePropertyNameAttribute
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Methods

	// RVA: 0x131BB8C
	public void .ctor() { }

	// RVA: 0x131BBB4
	public void .ctor(bool needParenthesis) { }

	// RVA: 0x131BBE0
	public bool get_NeedParenthesis() { }

	// RVA: 0x131BBE8
	public override bool Equals(object o) { }

	// RVA: 0x131BC70
	public override int GetHashCode() { }

	// RVA: 0x131BC78
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131BCEC
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

	// RVA: 0x131BD5C
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x131BD88
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x131BD90
	public override bool Equals(object value) { }

	// RVA: 0x131BE18
	public override int GetHashCode() { }

	// RVA: 0x131BE20
	public override bool IsDefaultAttribute() { }

	// RVA: 0x131BE94
	private static void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer
{
	// Methods

	// RVA: 0x131C7D8
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x131C950
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x131C7D0
	public void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x131C704
	internal void .ctor(object o) { }

	// RVA: 0x131C978
	public override bool Equals(object o) { }

	// RVA: 0x131CA08
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

	// RVA: 0x131BF64
	internal void .ctor() { }

	// RVA: 0x131BFD4
	public override void Clear() { }

	// RVA: 0x131BFDC
	public override void Remove(object key) { }

	// RVA: 0x131BFE4
	public void SetWeak(object key, object value) { }

	// RVA: 0x131C094
	private void ScavengeKeys() { }

	// RVA: 0x131C748
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute
{
	// Methods

	// RVA: 0x131CA10
	public void .ctor(string category) { }

}

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x131CA18
	public void .ctor() { }

	// RVA: 0x131CA20
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x131CA28
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131CA30
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x131CAC4
	private string GetLocalPath(string fileName) { }

	// RVA: 0x131CB58
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x131D0C0
	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x131D4DC
	public void .ctor() { }

	// RVA: 0x131D4E4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer
{
	// Methods

	// RVA: 0x131D2A4
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

	// RVA: 0x131DDE8
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x131DEF0
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x131DF14
	public override Type get_ComponentType() { }

	// RVA: 0x131DF3C
	public override bool get_IsReadOnly() { }

	// RVA: 0x131DF64
	public override Type get_PropertyType() { }

	// RVA: 0x131DF8C
	public override bool CanResetValue(object component) { }

	// RVA: 0x131DFBC
	public override object GetValue(object component) { }

	// RVA: 0x131DFEC
	public override void ResetValue(object component) { }

	// RVA: 0x131E01C
	public override void SetValue(object component, object value) { }

	// RVA: 0x131E04C
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

	// RVA: 0x131D5A8
	public int get_Count() { }

	// RVA: 0x131D684
	public string get_Name() { }

	// RVA: 0x131D68C
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x131DE5C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x131D5E0
	private void EnsurePopulated() { }

	// RVA: 0x131DEAC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x131DEE4
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x131DEEC
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
private class OptionPropertyDescriptor
{
	// Fields
	private DesignerOptionCollection _option; // 0x88

	// Methods

	// RVA: 0x131E650
	internal void .ctor(DesignerOptionCollection option) { }

	// RVA: 0x131E79C
	public override Type get_ComponentType() { }

	// RVA: 0x131E7BC
	public override bool get_IsReadOnly() { }

	// RVA: 0x131E7C4
	public override Type get_PropertyType() { }

	// RVA: 0x131E7E4
	public override bool CanResetValue(object component) { }

	// RVA: 0x131E7EC
	public override object GetValue(object component) { }

	// RVA: 0x131E7F4
	public override void ResetValue(object component) { }

	// RVA: 0x131E7F8
	public override void SetValue(object component, object value) { }

	// RVA: 0x131E7FC
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
internal sealed class DesignerOptionConverter
{
	// Methods

	// RVA: 0x131E07C
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x131E084
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x131E694
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x131E794
	public void .ctor() { }

}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService
{
	// Methods

	// RVA: 0x131D5A4
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

	// RVA: 0x131E804
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x131E80C
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	// RVA: 0x131ED98
	public ICollection get_Arguments() { }

	// RVA: 0x131EDA0
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x131EDA8
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

	// RVA: 0x131F128
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x131F184
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x131F18C
	public override object get_TypeId() { }

}

// Namespace: System.Collections
internal static class HashtableExtensions
{
	// Methods

	// RVA: 0x30A3D6C
	public static bool TryGetValue(Hashtable table, object key, T value) { }

}

// Namespace: System.Collections.Specialized
public struct BitVector32
{
	// Fields
	private UInt32 _data; // 0x10

	// Methods

	// RVA: 0x131F248
	public void .ctor(int data) { }

	// RVA: 0x131F250
	public bool get_Item(int bit) { }

	// RVA: 0x131F260
	public void set_Item(int bit, bool value) { }

	// RVA: 0x131F27C
	public int get_Data() { }

	// RVA: 0x131F284
	public static int CreateMask() { }

	// RVA: 0x131F28C
	public static int CreateMask(int previous) { }

	// RVA: 0x131F300
	public override bool Equals(object o) { }

	// RVA: 0x131F390
	public override int GetHashCode() { }

	// RVA: 0x131F400
	public static string ToString(BitVector32 value) { }

	// RVA: 0x131F730
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

	// RVA: 0x131F738
	public void .ctor() { }

	// RVA: 0x131F868
	public void .ctor(int capacity) { }

	// RVA: 0x131F9E4
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x131FA94
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x131FB40
	protected void InvalidateCachedArrays() { }

	// RVA: 0x131FB74
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x131FD40
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x131FDFC
	public virtual void Add(string name, string value) { }

	// RVA: 0x1320128
	public virtual string Get(string name) { }

	// RVA: 0x13201C0
	public virtual string[] GetValues(string name) { }

	// RVA: 0x1320324
	public virtual void Set(string name, string value) { }

	// RVA: 0x13204EC
	public virtual void Remove(string name) { }

	// RVA: 0x1320858
	public string get_Item(string name) { }

	// RVA: 0x1320868
	public void set_Item(string name, string value) { }

	// RVA: 0x1320878
	public virtual string Get(int index) { }

	// RVA: 0x1320A38
	public virtual string GetKey(int index) { }

	// RVA: 0x1320B88
	internal void .ctor(DBNull dummy) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Methods

	// RVA: 0x1321F9C
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x1322890
	public object get_Current() { }

	// RVA: 0x1322A8C
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1322C40
	public object get_Key() { }

	// RVA: 0x1322D34
	public object get_Value() { }

	// RVA: 0x1322E28
	public bool MoveNext() { }

	// RVA: 0x1322EDC
	public void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Methods

	// RVA: 0x1320F60
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x1322F94
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1323370
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1323398
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13233A0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13233C8
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

	// RVA: 0x1320C18
	public void .ctor() { }

	// RVA: 0x1320C4C
	public void .ctor(int capacity) { }

	// RVA: 0x1320C84
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x1320CC8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1320CFC
	public int get_Count() { }

	// RVA: 0x1320E3C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1320E44
	public bool get_IsReadOnly() { }

	// RVA: 0x1320E4C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1320E54
	public ICollection get_Keys() { }

	// RVA: 0x1320D98
	private ArrayList get_objectsArray() { }

	// RVA: 0x1320FA8
	private Hashtable get_objectsTable() { }

	// RVA: 0x1321060
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13210EC
	public object get_Item(object key) { }

	// RVA: 0x13211A0
	public void set_Item(object key, object value) { }

	// RVA: 0x1321870
	public ICollection get_Values() { }

	// RVA: 0x132167C
	public void Add(object key, object value) { }

	// RVA: 0x1321978
	public void Clear() { }

	// RVA: 0x1321AEC
	public bool Contains(object key) { }

	// RVA: 0x1321BA0
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1321450
	private int IndexOfKey(object key) { }

	// RVA: 0x1321C64
	public void Remove(object key) { }

	// RVA: 0x1321E60
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1322000
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x132213C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x132237C
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x132238C
	protected virtual void OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringCollection
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Methods

	// RVA: 0x1323470
	public string get_Item(int index) { }

	// RVA: 0x13234F8
	public void set_Item(int index, string value) { }

	// RVA: 0x1323520
	public int get_Count() { }

	// RVA: 0x1323548
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1323550
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1323558
	public int Add(string value) { }

	// RVA: 0x1323580
	public void Clear() { }

	// RVA: 0x13235A8
	public bool Contains(string value) { }

	// RVA: 0x13235D0
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x13235F8
	public int IndexOf(string value) { }

	// RVA: 0x1323620
	public void Insert(int index, string value) { }

	// RVA: 0x1323648
	public bool get_IsSynchronized() { }

	// RVA: 0x1323650
	public void Remove(string value) { }

	// RVA: 0x1323678
	public void RemoveAt(int index) { }

	// RVA: 0x13236A0
	public object get_SyncRoot() { }

	// RVA: 0x13236C8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1323750
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x13237E0
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1323868
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x13238F0
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1323978
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1323A08
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1323A90
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1323AB8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1323AE0
	public void .ctor() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringDictionary
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x1323B58
	public void .ctor() { }

	// RVA: 0x1323BD0
	public virtual string get_Item(string key) { }

	// RVA: 0x1323CB4
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

	// RVA: 0x1323CDC
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x1323EF8
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x1324258
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x1324594
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x132412C
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x1323E50
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x132476C
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x1324470
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler
{
	// Methods

	// RVA: 0x1324848
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x132496C
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

// Namespace: System.Collections.Specialized
internal sealed class ReadOnlyList
{
	// Fields
	private readonly IList _list; // 0x10

	// Methods

	// RVA: 0x1324814
	internal void .ctor(IList list) { }

	// RVA: 0x1324980
	public int get_Count() { }

	// RVA: 0x1324A38
	public bool get_IsReadOnly() { }

	// RVA: 0x1324A40
	public bool get_IsFixedSize() { }

	// RVA: 0x1324A48
	public bool get_IsSynchronized() { }

	// RVA: 0x1324B00
	public object get_Item(int index) { }

	// RVA: 0x1324BB4
	public void set_Item(int index, object value) { }

	// RVA: 0x1324C08
	public object get_SyncRoot() { }

	// RVA: 0x1324CC0
	public int Add(object value) { }

	// RVA: 0x1324D14
	public void Clear() { }

	// RVA: 0x1324D68
	public bool Contains(object value) { }

	// RVA: 0x1324E20
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1324EDC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1324F90
	public int IndexOf(object value) { }

	// RVA: 0x1325048
	public void Insert(int index, object value) { }

	// RVA: 0x132509C
	public void Remove(object value) { }

	// RVA: 0x13250F0
	public void RemoveAt(int index) { }

}

// Namespace: 
internal class NameObjectEntry
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x13264C4
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

	// RVA: 0x13265A8
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x1326AE0
	public bool MoveNext() { }

	// RVA: 0x1326BC4
	public void Reset() { }

	// RVA: 0x1326C50
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

	// RVA: 0x131F7FC
	protected void .ctor() { }

	// RVA: 0x1325144
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x131FA64
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x131F8F4
	protected void .ctor(int capacity) { }

	// RVA: 0x1320C10
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x131FB0C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13253BC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1325C08
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x1325200
	private void Reset() { }

	// RVA: 0x13252D4
	private void Reset(int capacity) { }

	// RVA: 0x13263E4
	private NameObjectEntry FindEntry(string key) { }

	// RVA: 0x13264BC
	protected bool get_IsReadOnly() { }

	// RVA: 0x131FFA0
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1320530
	protected void BaseRemove(string name) { }

	// RVA: 0x131FF84
	protected object BaseGet(string name) { }

	// RVA: 0x132042C
	protected void BaseSet(string name, object value) { }

	// RVA: 0x1320990
	protected object BaseGet(int index) { }

	// RVA: 0x1320AE0
	protected string BaseGetKey(int index) { }

	// RVA: 0x1326514
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1326608
	public virtual int get_Count() { }

	// RVA: 0x1326630
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1326968
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13269F4
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13269FC
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

	// RVA: 0x1326394
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1326D78
	public bool Equals(object a, object b) { }

	// RVA: 0x1326F98
	public int GetHashCode(object obj) { }

	// RVA: 0x13270B0
	public IComparer get_Comparer() { }

	// RVA: 0x13270B8
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1325B1C
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1325A38
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

	// RVA: 0x30A27C0
	internal void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: 0x315B3A8
	internal void LocalPush(T item, Int64 emptyToNonEmptyListTransitionCount) { }

	// RVA: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30A14A4
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

	// RVA: 0x30A27C0
	public void .ctor(T[] array) { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	public void Add(T item) { }

	// RVA: -1
	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	// RVA: 0x30A17DC
	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: 0x30A17DC
	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: 0x30A2828
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A17DC
	public T[] ToArray() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A14A4
	private int get_DangerousCount() { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A17DC
	private object get_GlobalQueuesLock() { }

	// RVA: 0x30A27C0
	private void FreezeBag(bool lockTaken) { }

	// RVA: 0x30A2404
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

	// RVA: 0x315B3A8
	public void .ctor(System.Span<T> initialSpan) { }

	// RVA: 0x30A14A4
	public int get_Length() { }

	// RVA: -1
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public void Append(T item) { }

	// RVA: 0x315B3A8
	public System.ReadOnlySpan<T> AsSpan() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2378
	private void Grow() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x13270C0
	internal void .ctor(Int32* bitArrayPtr, int length) { }

	// RVA: 0x1327104
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x132714C
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x13271CC
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x1327254
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.LinkedList<T> list) { }

	// RVA: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.LinkedListNode<T> get_First() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x315B3A8
	public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }

	// RVA: 0x315B3A8
	public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }

	// RVA: 0x30A27C0
	public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(T value) { }

	// RVA: 0x30A2828
	public void CopyTo(T[] array, int index) { }

	// RVA: 0x315B3A8
	public System.Collections.Generic.LinkedListNode<T> Find(T value) { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Remove(T value) { }

	// RVA: 0x30A27C0
	public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30A2378
	public void RemoveFirst() { }

	// RVA: -1
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A27C0
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x30A2A20
	private void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30A27C0
	private void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30A27C0
	internal void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30A27C0
	internal void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30A27C0
	internal void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A17DC
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

	// RVA: 0x315B3A8
	internal void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.LinkedListNode<T> get_Next() { }

	// RVA: 0x315B3A8
	public T get_Value() { }

	// RVA: 0x30A2378
	internal void Invalidate() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x30A2828
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, int getEnumeratorRetType) { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x315B3A8
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30A1224
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30A2378
	internal void Reset() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30A17DC
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public TKey get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A2828
	public void CopyTo(TKey[] array, int index) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: 0x30A2378
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public TValue get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A2828
	public void CopyTo(TValue[] array, int index) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: 0x30A2378
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
[Serializable]
internal sealed class KeyValuePairComparer
{
	// Fields
	internal System.Collections.Generic.IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }

	// RVA: 0x315B3A8
	public override int Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1
{
	// Fields
	public System.Collections.Generic.EqualityComparer<TValue> valueComparer; // 0x0
	public System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey,TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x315B3A8
	public TValue get_Item(TKey key) { }

	// RVA: 0x315B3A8
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A17DC
	public KeyCollection get_Keys() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30A17DC
	public ValueCollection get_Values() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x315B3A8
	public void Add(TKey key, TValue value) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool ContainsKey(TKey key) { }

	// RVA: 0x315B3A8
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30A2828
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int index) { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Remove(TKey key) { }

	// RVA: 0x315B3A8
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A1224
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30A1224
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30A188C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30A1344
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30A3970
	private static bool IsCompatibleKey(object key) { }

	// RVA: 0x30A17DC
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30A27C0
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
[Serializable]
internal sealed class TreeSet<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	public void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2828
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, int getEnumeratorRetType) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A17DC
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x315B3A8
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public TKey get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public TValue get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class KeyList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	public bool get_IsReadOnly() { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x315B3A8
	public void Add(TKey key) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(TKey key) { }

	// RVA: 0x30A2828
	public void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x315B3A8
	public void Insert(int index, TKey value) { }

	// RVA: 0x315B3A8
	public TKey get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, TKey value) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public int IndexOf(TKey key) { }

	// RVA: 0x315B3A8
	public bool Remove(TKey key) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int index) { }

}

// Namespace: 
[Serializable]
private sealed class ValueList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	public bool get_IsReadOnly() { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x315B3A8
	public void Add(TValue key) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(TValue value) { }

	// RVA: 0x30A2828
	public void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x315B3A8
	public void Insert(int index, TValue value) { }

	// RVA: 0x315B3A8
	public TValue get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public int IndexOf(TValue value) { }

	// RVA: 0x315B3A8
	public bool Remove(TValue value) { }

	// RVA: 0x30A24F0
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x315B3A8
	public void Add(TKey key, TValue value) { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30A24F0
	public void set_Capacity(int value) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IComparer<TKey> get_Comparer() { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30A17DC
	private KeyList GetKeyListHelper() { }

	// RVA: 0x30A17DC
	private ValueList GetValueListHelper() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30A1224
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30A1224
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A1344
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x315B3A8
	public bool ContainsKey(TKey key) { }

	// RVA: 0x315B3A8
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30A2828
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A24F0
	private void EnsureCapacity(int min) { }

	// RVA: 0x315B3A8
	private TValue GetByIndex(int index) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	private TKey GetKey(int index) { }

	// RVA: 0x315B3A8
	public TValue get_Item(TKey key) { }

	// RVA: 0x315B3A8
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30A188C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x315B3A8
	public int IndexOfKey(TKey key) { }

	// RVA: 0x315B3A8
	public int IndexOfValue(TValue value) { }

	// RVA: 0x315B3A8
	private void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x315B3A8
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int index) { }

	// RVA: 0x315B3A8
	public bool Remove(TKey key) { }

	// RVA: 0x30A27C0
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30A3970
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

	// RVA: 0x315B3A8
	public void .ctor(T item, NodeColor color) { }

	// RVA: 0x30A3970
	public static bool IsNonNullRed(Node node) { }

	// RVA: 0x30A3970
	public static bool IsNullOrBlack(Node node) { }

	// RVA: 0x315B3A8
	public T get_Item() { }

	// RVA: 0x315B3A8
	public void set_Item(T value) { }

	// RVA: 0x30A17DC
	public Node get_Left() { }

	// RVA: 0x30A27C0
	public void set_Left(Node value) { }

	// RVA: 0x30A17DC
	public Node get_Right() { }

	// RVA: 0x30A27C0
	public void set_Right(Node value) { }

	// RVA: 0x30A1224
	public NodeColor get_Color() { }

	// RVA: 0x30A2404
	public void set_Color(NodeColor value) { }

	// RVA: 0x30A1224
	public bool get_IsBlack() { }

	// RVA: 0x30A1224
	public bool get_IsRed() { }

	// RVA: 0x30A1224
	public bool get_Is2Node() { }

	// RVA: 0x30A1224
	public bool get_Is4Node() { }

	// RVA: 0x30A2378
	public void ColorBlack() { }

	// RVA: 0x30A2378
	public void ColorRed() { }

	// RVA: -1
	public Node DeepClone(int count) { }

	// RVA: -1
	public TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: 0x30A188C
	public Node GetSibling(Node node) { }

	// RVA: 0x30A17DC
	public Node ShallowClone() { }

	// RVA: 0x30A2378
	public void Split4Node() { }

	// RVA: -1
	public Node Rotate(TreeRotation rotation) { }

	// RVA: 0x30A17DC
	public Node RotateLeft() { }

	// RVA: 0x30A17DC
	public Node RotateLeftRight() { }

	// RVA: 0x30A17DC
	public Node RotateRight() { }

	// RVA: 0x30A17DC
	public Node RotateRightLeft() { }

	// RVA: 0x30A2378
	public void Merge2Nodes() { }

	// RVA: 0x30A2A20
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Collections.Generic.SortedSet<T> set) { }

	// RVA: -1
	internal void .ctor(System.Collections.Generic.SortedSet<T> set, bool reverse) { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A27C0
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30A2378
	private void Initialize() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A1224
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30A2378
	internal void Reset() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A6D04
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: 0x30A2A20
	public void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A27C0
	private void AddAllElements(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x30A1344
	internal virtual bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IComparer<T> get_Comparer() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A2378
	internal virtual void VersionCheck() { }

	// RVA: 0x315B3A8
	internal virtual bool IsWithinRange(T item) { }

	// RVA: 0x315B3A8
	public bool Add(T item) { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x315B3A8
	internal virtual bool AddIfNotPresent(T item) { }

	// RVA: 0x315B3A8
	public bool Remove(T item) { }

	// RVA: 0x315B3A8
	internal virtual bool DoRemove(T item) { }

	// RVA: 0x30A2378
	public virtual void Clear() { }

	// RVA: 0x315B3A8
	public virtual bool Contains(T item) { }

	// RVA: 0x30A2828
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	public void CopyTo(T[] array, int index, int count) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A2C60
	private void InsertionBalance(Node current, Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: 0x30A2BF4
	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: 0x30A2C60
	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: 0x315B3A8
	internal virtual Node FindNode(T item) { }

	// RVA: 0x315B3A8
	internal virtual int InternalIndexOf(T item) { }

	// RVA: 0x30A2378
	internal void UpdateVersion() { }

	// RVA: 0x30A1344
	private bool HasEqualComparer(System.Collections.Generic.SortedSet<T> other) { }

	// RVA: 0x30A27C0
	public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x315B3A8
	private static Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode) { }

	// RVA: 0x30A27C0
	public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30A27C0
	internal virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30A1344
	public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x315B3A8
	private ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, bool returnIfUnfound) { }

	// RVA: 0x315B3A8
	public T get_Min() { }

	// RVA: 0x315B3A8
	internal virtual T get_MinInternal() { }

	// RVA: 0x315B3A8
	public T get_Max() { }

	// RVA: 0x315B3A8
	internal virtual T get_MaxInternal() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30A27C0
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x30A1344
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

	// RVA: 0x1327268
	public void .ctor() { }

	// RVA: 0x13272C0
	public void .ctor(string message) { }

	// RVA: 0x13272C8
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

	// RVA: 0x13272D0
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x13272D8
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x132739C
	public override bool get_CanRead() { }

	// RVA: 0x13273B4
	public override bool get_CanWrite() { }

	// RVA: 0x13273CC
	public override bool get_CanSeek() { }

	// RVA: 0x13273E4
	public override Int64 get_Length() { }

	// RVA: 0x1327438
	public override Int64 get_Position() { }

	// RVA: 0x132748C
	public override void set_Position(Int64 value) { }

	// RVA: 0x13274E0
	public override void Flush() { }

	// RVA: 0x1327524
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1327578
	public override int ReadByte() { }

	// RVA: 0x13275A0
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1327658
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x13276C0
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x13276E8
	public override int Read(System.Span<System.Byte> buffer) { }

	// RVA: 0x13278FC
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x13279B4
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x13279C0
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x13279E8
	public override void Write(System.ReadOnlySpan<System.Byte> buffer) { }

	// RVA: 0x1327BCC
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1327BF4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1327CB8
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1327CE0
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1327DCC
	public override Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1327DF4
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1327EE0
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1327508
	private void CheckDeflateStream() { }

	// RVA: 0x1327F08
	private static void ThrowStreamClosedException() { }

}

// Namespace: 
private sealed class ReadMethod
{
	// Methods

	// RVA: 0x1329214
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1329D54
	public virtual int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x13292D0
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1329A38
	public virtual int EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod
{
	// Methods

	// RVA: 0x132973C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1329D68
	public virtual void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x13297F8
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1329BBC
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

	// RVA: 0x1327F60
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1327394
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1327F6C
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x13283A8
	protected override void Finalize() { }

	// RVA: 0x1328448
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1328670
	private int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1327DC4
	internal System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x13277D4
	internal int ReadCore(System.Span<System.Byte> destination) { }

	// RVA: 0x1328794
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x13289B8
	private void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1327ED8
	internal ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x1327B3C
	internal void WriteCore(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1328AD4
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1328D14
	public override void Flush() { }

	// RVA: 0x1328E7C
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x13293A4
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x13298CC
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1329A64
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1329BC8
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1329C08
	public override bool get_CanRead() { }

	// RVA: 0x1329C48
	public override bool get_CanSeek() { }

	// RVA: 0x1329C50
	public override bool get_CanWrite() { }

	// RVA: 0x1329C94
	public override Int64 get_Length() { }

	// RVA: 0x1329CD4
	public override Int64 get_Position() { }

	// RVA: 0x1329D14
	public override void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite
{
	// Methods

	// RVA: 0x1329F1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x132A750
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle
{
	// Methods

	// RVA: 0x132A764
	public override bool get_IsInvalid() { }

	// RVA: 0x132A73C
	private void .ctor() { }

	// RVA: 0x132A774
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

	// RVA: 0x1329F14
	private void .ctor() { }

	// RVA: 0x1328138
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x132A064
	protected override void Finalize() { }

	// RVA: 0x1328544
	public void Dispose(bool disposing) { }

	// RVA: 0x1328DC8
	public void Flush() { }

	// RVA: 0x13286C4
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1328A08
	public void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x1329D7C
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x132A358
	private int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x1329E48
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x132A53C
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x132A168
	private void CheckResult(int result, string where) { }

	// RVA: 0x1329FC0
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x132A74C
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x132A0F8
	private static extern int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x132A248
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x132A2D0
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

	// RVA: 0x132BC68
	private static void .cctor() { }

	// RVA: 0x132BCD4
	public void .ctor() { }

	// RVA: 0x132BCDC
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

	// RVA: 0x132A818
	private void SafeCaptureIdentity() { }

	// RVA: 0x132A81C
	private void CleanupInternal() { }

	// RVA: 0x132A820
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x132A828
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x132A898
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x132A920
	internal object StartPostingAsyncOp() { }

	// RVA: 0x132A928
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x132ABD4
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x132B278
	protected override void Cleanup() { }

	// RVA: 0x132AC24
	private bool CaptureOrComplete(ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x132B78C
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x132BB38
	private void CompleteCallback() { }

}

// Namespace: System.Net
internal static class HttpStatusDescription
{
	// Methods

	// RVA: 0x132BD60
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x132BD64
	internal static string Get(int code) { }

}

// Namespace: System.Net
internal static class HttpValidationHelpers
{
	// Fields
	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x132C654
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x132C778
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

	// RVA: 0x132C81C
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x132CF1C
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x132D4B8
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x132CE94
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x132D694
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x132D8E8
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x132D860
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x132B42C
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x132B5F8
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x132DA7C
	private void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x132DB04
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x132DC98
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x132AA40
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x132DD20
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x132DDA8
	public static void Associate(object first, object second, string memberName) { }

	// RVA: 0x132DF44
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x132B3AC
	public static bool get_IsEnabled() { }

	// RVA: 0x132C9E8
	public static string IdOf(object value) { }

	// RVA: 0x132E1E8
	public static int GetHashCode(object value) { }

	// RVA: 0x132D0C4
	public static object Format(object value) { }

	// RVA: 0x132CAE8
	private static string Format(FormattableString s) { }

	// RVA: 0x132DFD0
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x132E1FC
	public void .ctor() { }

	// RVA: 0x132E204
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class TcpValidationHelpers
{
	// Methods

	// RVA: 0x132E270
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

	// RVA: 0x132E27C
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x132E374
	public void AuthenticateAsClient() { }

	// RVA: 0x132E4C4
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x132E62C
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x132E654
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x132E67C
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x132E6A4
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x132E6CC
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x132E6F4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x132E71C
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x132E744
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

	// RVA: 0x132E788
	private static void .cctor() { }

}

// Namespace: 
private sealed class ReadOnlyIPAddress
{
	// Methods

	// RVA: 0x13305F0
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

	// RVA: 0x132E8A8
	private bool get_IsIPv4() { }

	// RVA: 0x132E8B8
	private bool get_IsIPv6() { }

	// RVA: 0x132E8C8
	private UInt32 get_PrivateAddress() { }

	// RVA: 0x132E8D0
	private void set_PrivateAddress(UInt32 value) { }

	// RVA: 0x132E908
	private UInt32 get_PrivateScopeId() { }

	// RVA: 0x132E910
	private void set_PrivateScopeId(UInt32 value) { }

	// RVA: 0x132E948
	public void .ctor(Int64 newAddress) { }

	// RVA: 0x132E9D8
	public void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0x132EAF8
	public void .ctor(System.ReadOnlySpan<System.Byte> address, Int64 scopeid) { }

	// RVA: 0x132ED2C
	internal void .ctor(UInt16* numbers, int numbersLength, UInt32 scopeid) { }

	// RVA: 0x132EDF4
	private void .ctor(UInt16[] numbers, UInt32 scopeid) { }

	// RVA: 0x132EE50
	public static bool TryParse(string ipString, IPAddress address) { }

	// RVA: 0x132F1EC
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x132F288
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten) { }

	// RVA: 0x132F5B8
	private void WriteIPv6Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x132F810
	private void WriteIPv4Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x132F860
	public Byte[] GetAddressBytes() { }

	// RVA: 0x132F968
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x132F980
	public Int64 get_ScopeId() { }

	// RVA: 0x132F9DC
	public override string ToString() { }

	// RVA: 0x132FB24
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x132FC3C
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x132FE38
	public override bool Equals(object comparand) { }

	// RVA: 0x132FE40
	public override int GetHashCode() { }

	// RVA: 0x1330228
	public IPAddress MapToIPv6() { }

	// RVA: 0x132EAA4
	private static Byte[] ThrowAddressNullException() { }

	// RVA: 0x1330334
	private static void .cctor() { }

}

// Namespace: System.Net
internal class IPAddressParser
{
	// Methods

	// RVA: 0x132EEF4
	internal static IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, bool tryParse) { }

	// RVA: 0x132FAB4
	internal static string IPv4AddressToString(UInt32 address) { }

	// RVA: 0x1330B48
	internal static void IPv4AddressToString(UInt32 address, StringBuilder destination) { }

	// RVA: 0x13308A4
	private static int IPv4AddressToStringHelper(UInt32 address, Char* addressString) { }

	// RVA: 0x132FA9C
	internal static string IPv6AddressToString(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x1330C94
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x1330BC8
	private static void FormatIPv4AddressNumber(int number, Char* addressString, int offset) { }

	// RVA: 0x13307E8
	public static bool Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, Int64 address) { }

	// RVA: 0x133067C
	public static bool Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, UInt16* numbers, int numbersLength, UInt32 scope) { }

	// RVA: 0x1330E24
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x13311BC
	private static void AppendHex(UInt16 value, StringBuilder buffer) { }

	// RVA: 0x1331184
	private static UInt32 ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x1331258
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

	// RVA: 0x1331260
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1331290
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x1331370
	public IPAddress get_Address() { }

	// RVA: 0x1331378
	public int get_Port() { }

	// RVA: 0x1331380
	public override string ToString() { }

	// RVA: 0x1331448
	public override SocketAddress Serialize() { }

	// RVA: 0x13314BC
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x13316CC
	public override bool Equals(object comparand) { }

	// RVA: 0x13317A4
	public override int GetHashCode() { }

	// RVA: 0x13317E0
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

	// RVA: 0x1333D94
	internal void .ctor(string command) { }

	// RVA: 0x1333DC8
	internal void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x1333E10
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

	// RVA: 0x13318C0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x133197C
	internal virtual void Abort(Exception e) { }

	// RVA: 0x1331BE4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1331D64
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x1331DE8
	internal bool get_RecoverableFailure() { }

	// RVA: 0x1331DF0
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x1331E08
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x1332534
	protected virtual void ClearState() { }

	// RVA: 0x13325DC
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x13325E4
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x1332668
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x1331F10
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x1332724
	internal void CheckContinuePipeline() { }

	// RVA: 0x1331FCC
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x13327E0
	private bool PostSendCommandProcessing(Stream stream) { }

	// RVA: 0x1332CA4
	private bool PostReadCommandProcessing(Stream stream) { }

	// RVA: 0x1332F50
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x1332F58
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x133385C
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1333B4C
	protected Encoding get_Encoding() { }

	// RVA: 0x1333B54
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x1333BA8
	protected virtual bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x1332928
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x1333260
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x1333BB0
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

	// RVA: 0x1333E20
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x1333E34
	internal bool get_PositiveCompletion() { }

	// RVA: 0x1333E48
	internal bool get_TransientFailure() { }

	// RVA: 0x1333E5C
	internal bool get_PermanentFailure() { }

	// RVA: 0x1333E70
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x1333E84
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

	// RVA: 0x1333F04
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

	// RVA: 0x1335CE4
	public void .ctor() { }

	// RVA: 0x13394E8
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

	// RVA: 0x1334028
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x13340E0
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x1334178
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1334224
	internal void AbortConnect() { }

	// RVA: 0x13342C4
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x13347EC
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x13349C4
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1334B9C
	private PipelineInstruction QueueOrCreateFtpDataStream(Stream stream) { }

	// RVA: 0x1335330
	protected override void ClearState() { }

	// RVA: 0x1335404
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x1336E88
	protected override PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x1335CEC
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream, bool isSocketReady) { }

	// RVA: 0x13381BC
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, string path, string directory, string filename) { }

	// RVA: 0x1338D10
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1338E30
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1338F4C
	internal Int64 get_ContentLength() { }

	// RVA: 0x1338F54
	internal DateTime get_LastModified() { }

	// RVA: 0x1338F5C
	internal Uri get_ResponseUri() { }

	// RVA: 0x1338F64
	internal string get_BannerMessage() { }

	// RVA: 0x1338F7C
	internal string get_WelcomeMessage() { }

	// RVA: 0x1338F94
	internal string get_ExitMessage() { }

	// RVA: 0x1336910
	private Int64 GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x1336A44
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x133657C
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x133647C
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x1336DD4
	private string GetLoginDirectory(string str) { }

	// RVA: 0x13387FC
	private int GetPortV4(string responseString) { }

	// RVA: 0x13389DC
	private int GetPortV6(string responseString) { }

	// RVA: 0x13383D4
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x13385D0
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x133808C
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1338B88
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x1338FAC
	protected override bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x1334F80
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x13393B4
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

	// RVA: 0x1335018
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x13395FC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1339788
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1339BF0
	private void CheckError() { }

	// RVA: 0x1339C3C
	public override bool get_CanRead() { }

	// RVA: 0x1339C44
	public override bool get_CanSeek() { }

	// RVA: 0x1339C68
	public override bool get_CanWrite() { }

	// RVA: 0x1339C70
	public override Int64 get_Length() { }

	// RVA: 0x1339C94
	public override Int64 get_Position() { }

	// RVA: 0x1339CB8
	public override void set_Position(Int64 value) { }

	// RVA: 0x1339CE0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1339DD8
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1339F08
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1339FFC
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x133A370
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x133A680
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x133A874
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x133A96C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x133AA50
	public override void Flush() { }

	// RVA: 0x133AA78
	public override bool get_CanTimeout() { }

	// RVA: 0x133AA9C
	public override int get_ReadTimeout() { }

	// RVA: 0x133AAC4
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x133AAEC
	public override int get_WriteTimeout() { }

	// RVA: 0x133AB14
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x133AB3C
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

	// RVA: 0x133AB90
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x13381AC
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x13383C4
	internal bool get_IsCommandOnly() { }

	// RVA: 0x133939C
	internal bool get_IsUpload() { }

	// RVA: 0x13393A8
	internal bool get_IsDownload() { }

	// RVA: 0x1336570
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x133ABF4
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x133AD6C
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

	// RVA: 0x1341DB8
	private void MoveNext() { }

	// RVA: 0x13421D8
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

	// RVA: 0x13421E4
	private static void .cctor() { }

	// RVA: 0x1342250
	public void .ctor() { }

	// RVA: 0x1342258
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

	// RVA: 0x133B514
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x133B51C
	public override string get_Method() { }

	// RVA: 0x133B53C
	public override void set_Method(string value) { }

	// RVA: 0x133B72C
	public string get_RenameTo() { }

	// RVA: 0x133B734
	public override ICredentials get_Credentials() { }

	// RVA: 0x133B73C
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x133B8E0
	public override Uri get_RequestUri() { }

	// RVA: 0x133B8E8
	public override int get_Timeout() { }

	// RVA: 0x133B8F0
	internal int get_RemainingTimeout() { }

	// RVA: 0x133B8F8
	public int get_ReadWriteTimeout() { }

	// RVA: 0x133B900
	public Int64 get_ContentOffset() { }

	// RVA: 0x133B908
	public override Int64 get_ContentLength() { }

	// RVA: 0x133B910
	public override IWebProxy get_Proxy() { }

	// RVA: 0x133B918
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x133B988
	internal bool get_Aborted() { }

	// RVA: 0x133B990
	internal void .ctor(Uri uri) { }

	// RVA: 0x133BFB4
	public override WebResponse GetResponse() { }

	// RVA: 0x133DCDC
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x133E494
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x133CD28
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x133F2B4
	private Exception TranslateConnectException(Exception e) { }

	// RVA: 0x133E8FC
	private void CreateConnectionAsync() { }

	// RVA: 0x133E9B4
	private FtpControlStream CreateConnection() { }

	// RVA: 0x133EBF8
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x133F53C
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x133F4A4
	private Queue get_TimerQueue() { }

	// RVA: 0x133F040
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x133D88C
	private void SetException(Exception exception) { }

	// RVA: 0x133C80C
	private void CheckError() { }

	// RVA: 0x13400B0
	internal void RequestCallback(object obj) { }

	// RVA: 0x1340C84
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x13400C0
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x133C8A4
	private RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x1341104
	public override void Abort() { }

	// RVA: 0x13415E0
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1341650
	public bool get_UseBinary() { }

	// RVA: 0x1341658
	public bool get_UsePassive() { }

	// RVA: 0x1335204
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1341660
	public bool get_EnableSsl() { }

	// RVA: 0x1341668
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x13417B4
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x133B70C
	private bool get_InUse() { }

	// RVA: 0x133D2D0
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x1341AE4
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x1341B7C
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FtpWebRequestCreator
{
	// Methods

	// RVA: 0x13422B0
	internal void .ctor() { }

	// RVA: 0x13422B8
	public WebRequest Create(Uri uri) { }

}

// Namespace: 
internal sealed class EmptyStream
{
	// Methods

	// RVA: 0x13423AC
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

	// RVA: 0x1341934
	internal void .ctor(Stream responseStream, Int64 contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x1340074
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x1342324
	public override Stream GetResponseStream() { }

	// RVA: 0x1341868
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x1342498
	public override void Close() { }

	// RVA: 0x13425D4
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1342760
	public override Uri get_ResponseUri() { }

	// RVA: 0x1342768
	public FtpStatusCode get_StatusCode() { }

}

// Namespace: System.Net
internal class NetworkStreamWrapper
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Methods

	// RVA: 0x1342770
	internal void .ctor(TcpClient client) { }

	// RVA: 0x133517C
	protected bool get_UsingSecureStream() { }

	// RVA: 0x1334660
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x13368F0
	internal Socket get_Socket() { }

	// RVA: 0x134280C
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x1342814
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x134281C
	public override bool get_CanRead() { }

	// RVA: 0x1342840
	public override bool get_CanSeek() { }

	// RVA: 0x1342864
	public override bool get_CanWrite() { }

	// RVA: 0x1342888
	public override bool get_CanTimeout() { }

	// RVA: 0x13428AC
	public override int get_ReadTimeout() { }

	// RVA: 0x13428D4
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x13428FC
	public override int get_WriteTimeout() { }

	// RVA: 0x1342924
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x134294C
	public override Int64 get_Length() { }

	// RVA: 0x1342970
	public override Int64 get_Position() { }

	// RVA: 0x1342994
	public override void set_Position(Int64 value) { }

	// RVA: 0x13429BC
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x13429E4
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1342A0C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1342A34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13347A8
	internal void CloseSocket() { }

	// RVA: 0x1342B38
	public void Close(int timeout) { }

	// RVA: 0x1342B74
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1342B9C
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1342BC4
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1342BEC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1342C14
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1342C3C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1342C64
	public override void Flush() { }

	// RVA: 0x1342C8C
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x133EBA4
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

	// RVA: 0x1342CB4
	public void .ctor(string token) { }

	// RVA: 0x1342D7C
	public void .ctor(string token, bool finished) { }

	// RVA: 0x1342E38
	public string get_Message() { }

	// RVA: 0x1342E40
	public bool get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache
{
	// Methods

	// RVA: 0x1342E48
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x1342EC4
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x1342F40
	private void .ctor() { }

	// RVA: 0x1342FA4
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint
{
	// Methods

	// RVA: 0x1343054
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x1343108
	public virtual SocketAddress Serialize() { }

	// RVA: 0x13431BC
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x13431E8
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

	// RVA: 0x13431F0
	public string get_HostName() { }

	// RVA: 0x13431F8
	public void set_HostName(string value) { }

	// RVA: 0x1343200
	public void set_Aliases(string[] value) { }

	// RVA: 0x1343208
	public IPAddress[] get_AddressList() { }

	// RVA: 0x1343210
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x1343218
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

	// RVA: 0x1334F78
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

	// RVA: 0x1343228
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x134331C
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x13439DC
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x13433AC
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x13439F8
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

	// RVA: 0x1342D68
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x1343AB4
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x1343AD0
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x1343ADC
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper
{
	// Methods

	// RVA: 0x1343134
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x1343080
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x133C820
	internal static WebException get_TimeoutException() { }

	// RVA: 0x13417E0
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1338C08
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

	// RVA: 0x1343CBC
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x1343EEC
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x1343EF4
	public void .ctor(string P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate
{
	// Methods

	// RVA: 0x1343F44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1343FE8
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

	// RVA: 0x133BF40
	public void .ctor(string userName, string password) { }

	// RVA: 0x1341CA8
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1338190
	public string get_UserName() { }

	// RVA: 0x1343FFC
	public void set_UserName(string value) { }

	// RVA: 0x13381A0
	public string get_Password() { }

	// RVA: 0x1344080
	public void set_Password(string value) { }

	// RVA: 0x1338198
	public string get_Domain() { }

	// RVA: 0x13440B4
	public void set_Domain(string value) { }

	// RVA: 0x1344144
	internal string InternalGetUserName() { }

	// RVA: 0x1344138
	internal string InternalGetPassword() { }

	// RVA: 0x134414C
	internal string InternalGetDomain() { }

	// RVA: 0x1344154
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException
{
	// Methods

	// RVA: 0x1344158
	public void .ctor() { }

	// RVA: 0x1344160
	public void .ctor(string message) { }

	// RVA: 0x1344168
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1344170
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1344178
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

	// RVA: 0x1344180
	public AddressFamily get_Family() { }

	// RVA: 0x13441B4
	public int get_Size() { }

	// RVA: 0x13441BC
	public Byte get_Item(int offset) { }

	// RVA: 0x134423C
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1344374
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x13445D8
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1344638
	internal IPAddress GetIPAddress() { }

	// RVA: 0x134481C
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x13448C0
	public override bool Equals(object comparand) { }

	// RVA: 0x13449CC
	public override int GetHashCode() { }

	// RVA: 0x1344D04
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

	// RVA: 0x1344FE0
	public void .ctor() { }

	// RVA: 0x13383B0
	public void .ctor(string message) { }

	// RVA: 0x1340064
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x13346F8
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1344FF0
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x133FFA4
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1345184
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x13450B8
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1345278
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1345378
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1345388
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1345394
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x134539C
	public WebExceptionStatus get_Status() { }

	// RVA: 0x13453A4
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

	// RVA: 0x13453AC
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x1345578
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

	// RVA: 0x13455F8
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1345710
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x13457DC
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x13459D8
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x1345A20
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1345B34
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1345B94
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1345BF4
	internal void RemoveInternal(string name) { }

	// RVA: 0x1345C54
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1346028
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x13460B0
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1346228
	public override void Add(string name, string value) { }

	// RVA: 0x13463E4
	public void Add(string header) { }

	// RVA: 0x13466D0
	public override void Set(string name, string value) { }

	// RVA: 0x1346918
	internal void SetInternal(string name, string value) { }

	// RVA: 0x1346B54
	public override void Remove(string name) { }

	// RVA: 0x1346CA4
	public override string[] GetValues(string header) { }

	// RVA: 0x1346EDC
	public override string ToString() { }

	// RVA: 0x1346F44
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1341744
	public void .ctor() { }

	// RVA: 0x1347284
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x1347380
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1347580
	public override void OnDeserialization(object sender) { }

	// RVA: 0x1347584
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1347710
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x134771C
	public override string Get(string name) { }

	// RVA: 0x1347A54
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1347AD0
	public override int get_Count() { }

	// RVA: 0x1347B0C
	public override string Get(int index) { }

	// RVA: 0x1347B50
	public override string GetKey(int index) { }

	// RVA: 0x1347B94
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CaseInsensitiveAscii
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1348154
	public int GetHashCode(object myObject) { }

	// RVA: 0x1348278
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1348408
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1348508
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x13486C8
	public void .ctor() { }

	// RVA: 0x13486D0
	private static void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate
{
	// Methods

	// RVA: 0x1349F1C
	public WebRequest Create(Uri uri) { }

	// RVA: 0x1349E20
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass79_0
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x1349830
	public void .ctor() { }

	// RVA: 0x1349F9C
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

	// RVA: 0x134879C
	private static object get_InternalSyncObject() { }

	// RVA: 0x13488A0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1348D10
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x1348E04
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x1348B3C
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1348F20
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x133BDEC
	protected void .ctor() { }

	// RVA: 0x13491BC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13491C4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13491D0
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13491D4
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x13491D8
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x13492A8
	public virtual string get_Method() { }

	// RVA: 0x13492D4
	public virtual void set_Method(string value) { }

	// RVA: 0x1349300
	public virtual Uri get_RequestUri() { }

	// RVA: 0x134932C
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1349358
	public virtual Int64 get_ContentLength() { }

	// RVA: 0x1349384
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x13493B0
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x13493DC
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1349408
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1349434
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1349460
	public virtual int get_Timeout() { }

	// RVA: 0x134948C
	public virtual WebResponse GetResponse() { }

	// RVA: 0x13494B8
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x13494E4
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1349510
	public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }

	// RVA: 0x1349838
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x13498A8
	public virtual void Abort() { }

	// RVA: 0x13498D4
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x13498DC
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x13498E4
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1349B00
	private static void .cctor() { }

	// RVA: 0x1349E28
	private System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Methods

	// RVA: 0x134231C
	protected void .ctor() { }

	// RVA: 0x134A2A4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x134A2AC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x134A2B8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x134A2BC
	public virtual void Close() { }

	// RVA: 0x134A2C0
	public void Dispose() { }

	// RVA: 0x134A350
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x134A3F0
	public virtual bool get_IsFromCache() { }

	// RVA: 0x134A3F8
	public virtual Stream GetResponseStream() { }

	// RVA: 0x134A424
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x134A450
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

	// RVA: 0x134A47C
	internal void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x134A538
	internal void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser
{
	// Methods

	// RVA: 0x134A5F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x134A6A8
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

	// RVA: 0x134A6BC
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

	// RVA: 0x134A730
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x134A7B4
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x134AB4C
	private static void .cctor() { }

	// RVA: 0x13458B0
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x134814C
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

	// RVA: 0x134CD58
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

	// RVA: 0x134CCA0
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x133A5C0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x134CD60
	internal object get_AsyncObject() { }

	// RVA: 0x134CD68
	public object get_AsyncState() { }

	// RVA: 0x134CD70
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x134CD78
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x134CE38
	private bool LazilyCreateEvent(ManualResetEvent waitHandle) { }

	// RVA: 0x134D01C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x133A32C
	public bool get_IsCompleted() { }

	// RVA: 0x133E478
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x134D060
	internal bool get_EndCalled() { }

	// RVA: 0x134D068
	internal void set_EndCalled(bool value) { }

	// RVA: 0x134D070
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x133A324
	internal void InvokeCallback(object result) { }

	// RVA: 0x133E488
	internal void InvokeCallback() { }

	// RVA: 0x134D2A0
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x134D440
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x134D504
	protected virtual void Cleanup() { }

	// RVA: 0x133A86C
	internal object InternalWaitForCompletion() { }

	// RVA: 0x134D508
	private object WaitForCompletion(bool snap) { }

}

// Namespace: System.Net
internal class NetRes
{
	// Methods

	// RVA: 0x1343C00
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x134D810
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x134D878
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Namespace: 
internal abstract class Queue
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x134EB40
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x134EB6C
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

	// RVA: 0x134EB74
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x134EBAC
	internal int get_StartTime() { }

	// RVA: 0x134EBB4
	internal int get_Expiration() { }

	// RVA: -1
	internal abstract bool Cancel() { }

	// RVA: -1
	internal abstract bool get_HasExpired() { }

	// RVA: 0x134EBC0
	public void Dispose() { }

}

// Namespace: 
internal sealed class Callback
{
	// Methods

	// RVA: 0x133BE1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x134EBCC
	public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Namespace: 
private class TimerQueue
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x134DD4C
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x134EC1C
	internal override Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x134E798
	internal bool Fire(int nextExpiration) { }

}

// Namespace: 
private class InfiniteTimerQueue
{
	// Methods

	// RVA: 0x134DD20
	internal void .ctor() { }

	// RVA: 0x134F220
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

	// RVA: 0x134EE98
	internal void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x134EBE0
	internal void .ctor() { }

	// RVA: 0x134F2C4
	internal override bool get_HasExpired() { }

	// RVA: 0x134F2D4
	internal TimerNode get_Next() { }

	// RVA: 0x134F2DC
	internal void set_Next(TimerNode value) { }

	// RVA: 0x134F2E4
	internal TimerNode get_Prev() { }

	// RVA: 0x134F2EC
	internal void set_Prev(TimerNode value) { }

	// RVA: 0x134F2F4
	internal override bool Cancel() { }

	// RVA: 0x134EF20
	internal bool Fire() { }

}

// Namespace: 
private class InfiniteTimer
{
	// Fields
	private int cancelled; // 0x18

	// Methods

	// RVA: 0x134F28C
	internal void .ctor() { }

	// RVA: 0x134F49C
	internal override bool get_HasExpired() { }

	// RVA: 0x134F4A4
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

	// RVA: 0x134DA54
	private static void .cctor() { }

	// RVA: 0x1349BC4
	internal static Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x133F694
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x134DE10
	private static void Prod() { }

	// RVA: 0x134DF40
	private static void ThreadProc() { }

	// RVA: 0x134E990
	private static void StopTimerThread() { }

	// RVA: 0x134E96C
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x134EA10
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

	// RVA: 0x134F4CC
	public void .ctor() { }

	// RVA: 0x134F628
	public string get_Comment() { }

	// RVA: 0x134F630
	public void set_Comment(string value) { }

	// RVA: 0x134F69C
	public void set_CommentUri(Uri value) { }

	// RVA: 0x134F6A4
	public void set_HttpOnly(bool value) { }

	// RVA: 0x134F6AC
	public void set_Discard(bool value) { }

	// RVA: 0x134F6B4
	public string get_Domain() { }

	// RVA: 0x134F6BC
	public void set_Domain(string value) { }

	// RVA: 0x134F75C
	private string get__Domain() { }

	// RVA: 0x134F850
	public bool get_Expired() { }

	// RVA: 0x134F938
	public void set_Expires(DateTime value) { }

	// RVA: 0x134F940
	public string get_Name() { }

	// RVA: 0x134F948
	internal bool InternalSetName(string value) { }

	// RVA: 0x134FA78
	public string get_Path() { }

	// RVA: 0x134FA80
	public void set_Path(string value) { }

	// RVA: 0x134FB04
	private string get__Path() { }

	// RVA: 0x134F840
	internal bool get_Plain() { }

	// RVA: 0x134FBA4
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x134FC08
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x13506A4
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x135073C
	public void set_Port(string value) { }

	// RVA: 0x1350AC8
	internal int[] get_PortList() { }

	// RVA: 0x1350AD0
	private string get__Port() { }

	// RVA: 0x1350BAC
	public bool get_Secure() { }

	// RVA: 0x1350BB4
	public void set_Secure(bool value) { }

	// RVA: 0x1350BBC
	public string get_Value() { }

	// RVA: 0x1350BC4
	public void set_Value(string value) { }

	// RVA: 0x1350C40
	internal CookieVariant get_Variant() { }

	// RVA: 0x1350C48
	internal string get_DomainKey() { }

	// RVA: 0x1350C64
	public int get_Version() { }

	// RVA: 0x1350C6C
	public void set_Version(int value) { }

	// RVA: 0x1350CEC
	private string get__Version() { }

	// RVA: 0x1350DFC
	internal static IComparer GetComparer() { }

	// RVA: 0x1350E78
	public override bool Equals(object comparand) { }

	// RVA: 0x1350F60
	public override int GetHashCode() { }

	// RVA: 0x1351154
	public override string ToString() { }

	// RVA: 0x13514AC
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

	// RVA: 0x12114D4
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x1211500
	internal CookieToken get_Token() { }

	// RVA: 0x1210EF0
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

	// RVA: 0x12104E0
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1210524
	internal bool get_EndOfCookie() { }

	// RVA: 0x121052C
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1210534
	internal bool get_Eof() { }

	// RVA: 0x1210544
	internal string get_Name() { }

	// RVA: 0x121054C
	internal void set_Name(string value) { }

	// RVA: 0x1210554
	internal bool get_Quoted() { }

	// RVA: 0x121055C
	internal void set_Quoted(bool value) { }

	// RVA: 0x1210564
	internal CookieToken get_Token() { }

	// RVA: 0x121056C
	internal void set_Token(CookieToken value) { }

	// RVA: 0x1210574
	internal string get_Value() { }

	// RVA: 0x121057C
	internal void set_Value(string value) { }

	// RVA: 0x1210584
	internal string Extract() { }

	// RVA: 0x121061C
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1210964
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1210C78
	internal void Reset() { }

	// RVA: 0x1210D04
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1210F18
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CookieParser
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x1211508
	internal void .ctor(string cookieString) { }

	// RVA: 0x12115A4
	internal Cookie Get() { }

	// RVA: 0x1211B54
	internal static string CheckQuoted(string value) { }

}

// Namespace: System.Net
internal class Comparer
{
	// Methods

	// RVA: 0x1211C14
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1211CFC
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

	// RVA: 0x1212D38
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x1212DA4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1212E4C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1212EEC
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

	// RVA: 0x1211D04
	public void .ctor() { }

	// RVA: 0x1211DBC
	public Cookie get_Item(int index) { }

	// RVA: 0x1211EB0
	public void Add(Cookie cookie) { }

	// RVA: 0x121233C
	public void Add(CookieCollection cookies) { }

	// RVA: 0x12126D4
	public int get_Count() { }

	// RVA: 0x12126FC
	public bool get_IsSynchronized() { }

	// RVA: 0x1212704
	public object get_SyncRoot() { }

	// RVA: 0x1212708
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1212730
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0x1212838
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1212840
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1211F74
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1212D10
	internal void RemoveAt(int idx) { }

	// RVA: 0x121262C
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields
	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Methods

	// RVA: 0x1212EF8
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x1212F24
	internal string get_Name() { }

	// RVA: 0x1212F2C
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

	// RVA: 0x1212F34
	public void .ctor() { }

	// RVA: 0x1213060
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x12131A0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x121404C
	private bool AgeCookies(string domain) { }

	// RVA: 0x1215540
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1215714
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1215BA4
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1216278
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x12165C0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1216EDC
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x121710C
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1217208
	internal string GetCookieHeader(Uri uri, string optCookie2) { }

	// RVA: 0x12175A4
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private class PathListComparer
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x12176D8
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1217878
	public void .ctor() { }

	// RVA: 0x1217880
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
internal class PathList
{
	// Fields
	private SortedList m_list; // 0x10

	// Methods

	// RVA: 0x1213A04
	public void .ctor() { }

	// RVA: 0x12156EC
	public int get_Count() { }

	// RVA: 0x1213ABC
	public int GetCookiesCount() { }

	// RVA: 0x1215518
	public ICollection get_Values() { }

	// RVA: 0x1213F10
	public object get_Item(string s) { }

	// RVA: 0x1213F38
	public void set_Item(string s, object value) { }

	// RVA: 0x1216EB4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1213EE8
	public object get_SyncRoot() { }

}

// Namespace: System.Net
[Serializable]
public class CookieException
{
	// Methods

	// RVA: 0x12178EC
	public void .ctor() { }

	// RVA: 0x12139FC
	internal void .ctor(string message) { }

	// RVA: 0x1215510
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x12178F4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12178FC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1217904
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

	// RVA: 0x121790C
	internal void .ctor(Uri uri) { }

	// RVA: 0x1217A9C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1217ED0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1217EDC
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12181AC
	internal bool get_Aborted() { }

	// RVA: 0x12181BC
	public override Int64 get_ContentLength() { }

	// RVA: 0x12181C4
	public override ICredentials get_Credentials() { }

	// RVA: 0x12181CC
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x12181D4
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x12181DC
	public override string get_Method() { }

	// RVA: 0x12181E4
	public override void set_Method(string value) { }

	// RVA: 0x12182E0
	public override IWebProxy get_Proxy() { }

	// RVA: 0x12182E8
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x12182F0
	public override int get_Timeout() { }

	// RVA: 0x12182F8
	public override Uri get_RequestUri() { }

	// RVA: 0x1218300
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1218630
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1218914
	public override WebResponse GetResponse() { }

	// RVA: 0x1218C84
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1218FB0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1219660
	internal void UnblockReader() { }

	// RVA: 0x1219750
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1219780
	public override void Abort() { }

	// RVA: 0x1219AFC
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator
{
	// Methods

	// RVA: 0x1219BEC
	internal void .ctor() { }

	// RVA: 0x1219BF4
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1218F08
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1219C58
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1219D18
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1219DF4
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1219E34
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1219FCC
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x121A0E0
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x121A1F4
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x121A29C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x121A3B0
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1219F48
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

	// RVA: 0x12192EC
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x121A458
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121A6E0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121A6EC
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121A8D4
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x121A978
	public override Uri get_ResponseUri() { }

	// RVA: 0x121A8F8
	private void CheckDisposed() { }

	// RVA: 0x121A99C
	public override void Close() { }

	// RVA: 0x121AA40
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x121ABC4
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

	// RVA: 0x121AC20
	public void .ctor() { }

	// RVA: 0x121AC94
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x121B064
	public ICredentials get_Credentials() { }

	// RVA: 0x121B06C
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x121B0F4
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x121B188
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x121AD6C
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x121B4FC
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x121B6B0
	private bool IsLocal(Uri host) { }

	// RVA: 0x121B84C
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x121B954
	public bool IsBypassed(Uri host) { }

	// RVA: 0x121B40C
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x121BAF0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121BF04
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121BF10
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x121C0A4
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x121C0AC
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x121C110
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x121BEF8
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x121B384
	private bool GetProxyAuto(Uri destination, Uri proxyUri) { }

	// RVA: 0x121BA7C
	private bool IsBypassedAuto(Uri destination, bool isBypassed) { }

	// RVA: 0x121C168
	private static bool AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, bool checkFirstOnly) { }

	// RVA: 0x121C444
	private static Uri ProxyUri(string proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine
{
	// Methods

	// RVA: 0x121C144
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList) { }

	// RVA: 0x121C4EC
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList, int syncStatus) { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x121CBA4
	internal static string ToString(int position) { }

	// RVA: 0x121CC44
	private static void .cctor() { }

}

// Namespace: 
internal static class HttpApi
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x121C510
	private static void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper
{
	// Methods

	// RVA: 0x121D4E8
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x121D66C
	internal static SecureString CreateSecureString(string plainString) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods
{}

// Namespace: System.Net
internal static class Logging
{
	// Methods

	// RVA: 0x1218628
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

	// RVA: 0x121D9FC
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
internal class ServerCertValidationCallback
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x121D71C
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x121D7AC
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x121D7B4
	internal void Callback(object state) { }

	// RVA: 0x121D868
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

	// RVA: 0x121DA74
	private static void EnsureModules() { }

	// RVA: 0x121DD30
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x121DE34
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x121E304
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x121E820
	private static void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient
{
	// Methods

	// RVA: 0x121E8B4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121ECD8
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x121E964
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121ED98
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x121EDA4
	public string get_AuthenticationType() { }

	// RVA: 0x121DD28
	public void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint
{
	// Methods

	// RVA: 0x121EDE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x121EF0C
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

	// RVA: 0x121F168
	private void MoveNext() { }

	// RVA: 0x121F4D8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class BufferedReadStream
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x121EF20
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x121EF54
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x121F0C0
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

	// RVA: 0x121F558
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x121F678
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x121F644
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x121F680
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x121F6A8
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

	// RVA: 0x121F7D8
	public void .ctor(string header) { }

	// RVA: 0x121F8C0
	public string get_Realm() { }

	// RVA: 0x121F8EC
	public string get_Opaque() { }

	// RVA: 0x121F91C
	public string get_Nonce() { }

	// RVA: 0x121F94C
	public string get_Algorithm() { }

	// RVA: 0x121F97C
	public string get_QOP() { }

	// RVA: 0x121F9AC
	public bool Parse() { }

	// RVA: 0x121FE58
	private void SkipWhitespace() { }

	// RVA: 0x121FEE4
	private string GetKey() { }

	// RVA: 0x121FBE8
	private bool GetKeywordAndValue(string key, string value) { }

	// RVA: 0x121FFD8
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

	// RVA: 0x122015C
	private static void .cctor() { }

	// RVA: 0x12201BC
	public void .ctor() { }

	// RVA: 0x1220238
	public string get_Algorithm() { }

	// RVA: 0x1220270
	public string get_Realm() { }

	// RVA: 0x12202A4
	public string get_Nonce() { }

	// RVA: 0x12202DC
	public string get_Opaque() { }

	// RVA: 0x1220314
	public string get_QOP() { }

	// RVA: 0x122034C
	public string get_CNonce() { }

	// RVA: 0x1220464
	public bool Parse(string challenge) { }

	// RVA: 0x1220568
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x12206D4
	private string HA1(string username, string password) { }

	// RVA: 0x1220810
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x12208FC
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x1220A7C
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x12210D8
	public DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Methods

	// RVA: 0x12210E0
	private static Hashtable get_Cache() { }

	// RVA: 0x1221284
	private static void CheckExpired(int count) { }

	// RVA: 0x1221AB0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1221DC0
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1221F70
	public string get_AuthenticationType() { }

	// RVA: 0x121DD20
	public void .ctor() { }

	// RVA: 0x1221FB4
	private static void .cctor() { }

}

// Namespace: 
private sealed class GetHostAddressesCallback
{
	// Methods

	// RVA: 0x1222298
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1223178
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x122234C
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x12224A8
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public static class Dns
{
	// Methods

	// RVA: 0x1222048
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x122239C
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x12224B4
	private static bool GetHostByName_icall(string host, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x12224B8
	private static bool GetHostByAddr_icall(string addr, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x12224BC
	private static bool GetHostName_icall(string h_name) { }

	// RVA: 0x12224C0
	private static void Error_11001(string hostName) { }

	// RVA: 0x1222528
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x12228BC
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x1222A3C
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x1222BE8
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x1222D98
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x1222C5C
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x1222FBC
	public static string GetHostName() { }

	// RVA: 0x1223054
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

	// RVA: 0x122332C
	private void MoveNext() { }

	// RVA: 0x12236A0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class FixedSizeReadStream
{
	// Fields
	private readonly Int64 <ContentLength>k__BackingField; // 0x40
	private Int64 position; // 0x48

	// Methods

	// RVA: 0x122318C
	public Int64 get_ContentLength() { }

	// RVA: 0x1223194
	public void .ctor(WebOperation operation, Stream innerStream, Int64 contentLength) { }

	// RVA: 0x12231C0
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class HttpRequestCreator
{
	// Methods

	// RVA: 0x1223720
	internal void .ctor() { }

	// RVA: 0x1223728
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

	// RVA: 0x1227884
	public bool get_IsCompleted() { }

	// RVA: 0x122788C
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1227894
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1223C7C
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1226BBC
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x12276A8
	public void Reset() { }

	// RVA: 0x12278B4
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2378
	private void MoveNext() { }

	// RVA: 0x30A27C0
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

	// RVA: 0x12279C0
	private void MoveNext() { }

	// RVA: 0x1228D68
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

	// RVA: 0x1228DE8
	private void MoveNext() { }

	// RVA: 0x1229A30
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

	// RVA: 0x1229AB0
	private void MoveNext() { }

	// RVA: 0x1229F58
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

	// RVA: 0x12239FC
	private static void .cctor() { }

	// RVA: 0x122378C
	public void .ctor(Uri uri) { }

	// RVA: 0x1223B10
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1223A90
	private void ResetAuthorization() { }

	// RVA: 0x1223CB0
	public Uri get_Address() { }

	// RVA: 0x1223CB8
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1223CC0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x1223CC8
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1223CDC
	private bool get_MethodWithBuffer() { }

	// RVA: 0x1223DE8
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x1223DF0
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1223DF8
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1223E80
	public override Int64 get_ContentLength() { }

	// RVA: 0x1223E88
	internal void set_InternalContentLength(Int64 value) { }

	// RVA: 0x1223E90
	internal bool get_ThrowOnError() { }

	// RVA: 0x1223E98
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x1223EA0
	public override ICredentials get_Credentials() { }

	// RVA: 0x1223EA8
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1223EB0
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x1223F2C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1223F34
	public string get_Host() { }

	// RVA: 0x122408C
	public bool get_KeepAlive() { }

	// RVA: 0x1224094
	public int get_ReadWriteTimeout() { }

	// RVA: 0x122409C
	public override string get_Method() { }

	// RVA: 0x12240A4
	public override void set_Method(string value) { }

	// RVA: 0x1224300
	public Version get_ProtocolVersion() { }

	// RVA: 0x1224308
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1224310
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x122455C
	public override Uri get_RequestUri() { }

	// RVA: 0x1224564
	public bool get_SendChunked() { }

	// RVA: 0x122456C
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1224570
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1224578
	public override int get_Timeout() { }

	// RVA: 0x1224580
	public string get_TransferEncoding() { }

	// RVA: 0x12245D8
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x122466C
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1224674
	internal bool get_ExpectContinue() { }

	// RVA: 0x122467C
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x1224684
	internal Uri get_AuthUri() { }

	// RVA: 0x122468C
	internal bool get_ProxyQuery() { }

	// RVA: 0x12246C8
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x12246D0
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1224400
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x12246E8
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x315B3A8
	internal static System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationToken cancellationToken) { }

	// RVA: -1
	private static System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationTokenSource cts) { }

	// RVA: 0x30A188C
	private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }

	// RVA: 0x122493C
	private System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1224A88
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1224BE4
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x1224CB4
	private WebException GetWebException(Exception e) { }

	// RVA: 0x1224D64
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x1224F3C
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x1224FFC
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x12251C4
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1225318
	public override WebResponse GetResponse() { }

	// RVA: 0x1225434
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1224D38
	internal bool get_Aborted() { }

	// RVA: 0x122543C
	public override void Abort() { }

	// RVA: 0x1225560
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12255A0
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1224398
	private void CheckRequestStarted() { }

	// RVA: 0x12255E0
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x12255FC
	private void RewriteRedirectToGet() { }

	// RVA: 0x122568C
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1225C48
	private string GetHeaders() { }

	// RVA: 0x1226340
	private void DoPreAuthenticate() { }

	// RVA: 0x1226584
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0x12268E0
	private System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1226BA4
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1226F0C
	private System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1227118
	private System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x30A1224
	private bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x1227730
	private System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	// RVA: 0x1227848
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

	// RVA: 0x1229FD8
	public void .ctor() { }

	// RVA: 0x1229FE0
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x12296C8
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x122A32C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122A734
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x122A73C
	public override Uri get_ResponseUri() { }

	// RVA: 0x122A7E0
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x122A7E8
	public virtual string get_StatusDescription() { }

	// RVA: 0x122A80C
	public override Stream GetResponseStream() { }

	// RVA: 0x122A8B4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122A8C0
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122AA8C
	public override void Close() { }

	// RVA: 0x122AAC0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x122AAD0
	protected override void Dispose(bool disposing) { }

	// RVA: 0x122A760
	private void CheckDisposed() { }

	// RVA: 0x122A0D8
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

	// RVA: 0x122BD84
	public void .ctor(Byte[] chunk) { }

	// RVA: 0x122BDB8
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

	// RVA: 0x122AAE4
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x122ABC0
	public int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122ABC4
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122AFBC
	public void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122AFE8
	private void InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122BB94
	public bool get_WantMore() { }

	// RVA: 0x122BBB8
	public bool get_DataAvailable() { }

	// RVA: 0x122BCCC
	public int get_ChunkLeft() { }

	// RVA: 0x122B51C
	private State ReadBody(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122B128
	private State GetChunkSize(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122BD2C
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x122B664
	private State ReadCRLF(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122B7C8
	private State ReadTrailer(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122BCD8
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

	// RVA: 0x122C3FC
	private void MoveNext() { }

	// RVA: 0x122C8B0
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

	// RVA: 0x122C930
	private void MoveNext() { }

	// RVA: 0x122CF0C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class MonoChunkStream
{
	// Fields
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Methods

	// RVA: 0x122BE1C
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x122BE24
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x122BFDC
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x122C148
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x122C254
	private static void ThrowExpectingChunkTrailer() { }

	// RVA: 0x122C2B4
	private Task <>n__0(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class NtlmClient
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Methods

	// RVA: 0x122CF78
	public void .ctor() { }

	// RVA: 0x122CFF0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x122D0D0
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x122D0D8
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

	// RVA: 0x122D11C
	internal void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x122D4A8
	internal SPKey get_Key() { }

	// RVA: 0x122D4B0
	private ServicePointScheduler get_Scheduler() { }

	// RVA: 0x122D4B8
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x122D4C0
	public Uri get_Address() { }

	// RVA: 0x122D4C8
	public int get_ConnectionLimit() { }

	// RVA: 0x122D4D0
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x122D4D8
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x122D4E0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x122D4E8
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x122D4F0
	internal bool get_SendContinue() { }

	// RVA: 0x122D598
	internal void set_SendContinue(bool value) { }

	// RVA: 0x122D5A0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x122D650
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x122D7C4
	private static void PutBytes(Byte[] bytes, UInt32 v, int offset) { }

	// RVA: 0x122D848
	internal bool get_UsesProxy() { }

	// RVA: 0x122D850
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x122D858
	internal bool get_UseConnect() { }

	// RVA: 0x122D860
	internal void set_UseConnect(bool value) { }

	// RVA: 0x122D868
	private bool get_HasTimedOut() { }

	// RVA: 0x122D9D4
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x122DDD0
	internal void SetVersion(Version version) { }

	// RVA: 0x122DDD8
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x122E0A4
	internal void FreeServicePoint() { }

	// RVA: 0x122E0B8
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x122E110
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x122E168
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

	// RVA: 0x122EE9C
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x122EFB4
	public bool get_UsesProxy() { }

	// RVA: 0x122F020
	public override int GetHashCode() { }

	// RVA: 0x122F100
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

	// RVA: 0x122E3B4
	private static void .cctor() { }

	// RVA: 0x122E478
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x122E4F4
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x122E570
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x122E5EC
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x122E668
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x122E6E4
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x122E790
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x122EEF8
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

	// RVA: 0x12312E0
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x122F408
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x122FC38
	public bool IsEmpty() { }

	// RVA: 0x1230690
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x1230860
	public void Cleanup() { }

	// RVA: 0x1231118
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x1230BA4
	public WebOperation GetNextOperation() { }

	// RVA: 0x12313C4
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x12309A0
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

	// RVA: 0x1232044
	private static void .cctor() { }

	// RVA: 0x12320B0
	public void .ctor() { }

	// RVA: 0x12320B8
	internal bool <Set>b__4_0(object s) { }

}

// Namespace: 
private class AsyncManualResetEvent
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs; // 0x10

	// Methods

	// RVA: 0x1231FE4
	public System.Threading.Tasks.Task<System.Boolean> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x122F64C
	public void Set() { }

	// RVA: 0x1230034
	public void Reset() { }

	// RVA: 0x122F34C
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

	// RVA: 0x123216C
	private void MoveNext() { }

	// RVA: 0x1232EE4
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

	// RVA: 0x1232F50
	private void MoveNext() { }

	// RVA: 0x12334D8
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

	// RVA: 0x122F334
	private ServicePoint get_ServicePoint() { }

	// RVA: 0x122F33C
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x122F344
	public int get_MaxIdleTime() { }

	// RVA: 0x122D228
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x122F54C
	public void Run() { }

	// RVA: 0x122F924
	private Task RunScheduler() { }

	// RVA: 0x122FA10
	private void Cleanup() { }

	// RVA: 0x122FCB8
	private void RunSchedulerIteration() { }

	// RVA: 0x12301F4
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x1230B68
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x1230100
	private bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x1230D00
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x123073C
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x1230E24
	private void FinalCleanup() { }

	// RVA: 0x122DF6C
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1230EF8
	private ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x123117C
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x1231188
	private void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x12311B0
	public static System.Threading.Tasks.Task<System.Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x12312DC
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

	// RVA: 0x315B3A8
	public Status get_Status() { }

	// RVA: 0x30A1224
	public bool get_Success() { }

	// RVA: 0x30A17DC
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x315B3A8
	public T get_Argument() { }

	// RVA: 0x315B3A8
	public void .ctor(T argument) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2378
	private void MoveNext() { }

	// RVA: 0x30A27C0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebCompletionSource<T0>
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion; // 0x0
	private Result currentResult; // 0x0

	// Methods

	// RVA: 0x30A2404
	public void .ctor(bool runAsync) { }

	// RVA: 0x30A17DC
	internal Result get_CurrentResult() { }

	// RVA: 0x30A17DC
	internal Task get_Task() { }

	// RVA: 0x315B3A8
	public bool TrySetCompleted(T argument) { }

	// RVA: 0x30A1224
	public bool TrySetCompleted() { }

	// RVA: 0x30A1224
	public bool TrySetCanceled() { }

	// RVA: 0x30A1344
	public bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x30A1344
	public bool TrySetException(Exception error) { }

	// RVA: 0x30A2378
	public void ThrowOnError() { }

	// RVA: 0x30A17DC
	public System.Threading.Tasks.Task<T> WaitForCompletion() { }

}

// Namespace: System.Net
internal class WebCompletionSource
{
	// Methods

	// RVA: 0x1233558
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

	// RVA: 0x1234A54
	private static void .cctor() { }

	// RVA: 0x1234AC0
	public void .ctor() { }

	// RVA: 0x1234AC8
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x1234B6C
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

	// RVA: 0x1234C70
	private void MoveNext() { }

	// RVA: 0x1235AB4
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

	// RVA: 0x1235B20
	private void MoveNext() { }

	// RVA: 0x1236580
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

	// RVA: 0x1236600
	private void MoveNext() { }

	// RVA: 0x1236F3C
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

	// RVA: 0x12335B0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1231FB0
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x12335B8
	private bool CanReuse() { }

	// RVA: 0x12335E8
	private bool CheckReusable() { }

	// RVA: 0x12336B8
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x12337E0
	private System.Threading.Tasks.Task<System.Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x1233940
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1233A98
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x1233C10
	internal static bool ReadLine(Byte[] buffer, int start, int max, string output) { }

	// RVA: 0x12318B0
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x1233E3C
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x12341A4
	private void Reset() { }

	// RVA: 0x12342BC
	private void Close(bool reset) { }

	// RVA: 0x1234394
	private void CloseSocket() { }

	// RVA: 0x1231330
	public bool get_Closed() { }

	// RVA: 0x1234688
	public DateTime get_IdleSince() { }

	// RVA: 0x1231CFC
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1230470
	public bool Continue(WebOperation next) { }

	// RVA: 0x12349DC
	private void Dispose(bool disposing) { }

	// RVA: 0x12312E8
	public void Dispose() { }

	// RVA: 0x1234288
	private void ResetNtlm() { }

	// RVA: 0x1234A24
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1234A2C
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x1234A34
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x1234A3C
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x1234A44
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1234A4C
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

	// RVA: 0x1236FBC
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x12370B8
	internal HttpWebRequest get_Request() { }

	// RVA: 0x12370C0
	internal WebConnection get_Connection() { }

	// RVA: 0x12370C8
	internal WebOperation get_Operation() { }

	// RVA: 0x12370D0
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x12370F0
	public override bool get_CanTimeout() { }

	// RVA: 0x12370F8
	public override int get_ReadTimeout() { }

	// RVA: 0x1237100
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x123716C
	public override int get_WriteTimeout() { }

	// RVA: 0x1237174
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x12371E0
	protected Exception GetException(Exception e) { }

	// RVA: -1
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x12373AC
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1237758
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x12379B8
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1237B0C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1237D48
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1237E58
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12380E0
	public override void Flush() { }

	// RVA: 0x12380E4
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1238234
	internal void InternalClose() { }

	// RVA: -1
	protected abstract void Close_internal(bool disposed) { }

	// RVA: 0x1238240
	public override void Close() { }

	// RVA: 0x1238254
	public override Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0x12382A8
	public override bool get_CanSeek() { }

	// RVA: 0x12382B0
	public override Int64 get_Length() { }

	// RVA: 0x1238304
	public override Int64 get_Position() { }

	// RVA: 0x1238358
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

	// RVA: 0x1238640
	private void MoveNext() { }

	// RVA: 0x1239410
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

	// RVA: 0x123947C
	private void MoveNext() { }

	// RVA: 0x1239F2C
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

	// RVA: 0x12383AC
	public HttpWebRequest get_Request() { }

	// RVA: 0x12383B4
	public Uri get_ConnectUri() { }

	// RVA: 0x1236408
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x12383BC
	public bool get_Success() { }

	// RVA: 0x12383C4
	private void set_Success(bool value) { }

	// RVA: 0x12383CC
	public bool get_CloseConnection() { }

	// RVA: 0x12383D4
	private void set_CloseConnection(bool value) { }

	// RVA: 0x12383DC
	public int get_StatusCode() { }

	// RVA: 0x12383E4
	private void set_StatusCode(int value) { }

	// RVA: 0x12383EC
	private void set_StatusDescription(string value) { }

	// RVA: 0x12383F4
	public string[] get_Challenge() { }

	// RVA: 0x12383FC
	private void set_Challenge(string[] value) { }

	// RVA: 0x1238404
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x123840C
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1238414
	public Version get_ProxyVersion() { }

	// RVA: 0x123841C
	private void set_ProxyVersion(Version value) { }

	// RVA: 0x1238424
	public Byte[] get_Data() { }

	// RVA: 0x123842C
	private void set_Data(Byte[] value) { }

	// RVA: 0x1236458
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1238434
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1238590
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

	// RVA: 0x123AE94
	private void MoveNext() { }

	// RVA: 0x123B89C
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

	// RVA: 0x1239FAC
	public HttpWebRequest get_Request() { }

	// RVA: 0x1239FB4
	public WebConnection get_Connection() { }

	// RVA: 0x1239FBC
	private void set_Connection(WebConnection value) { }

	// RVA: 0x1239FC4
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1239FCC
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1239FD4
	public BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x1239FDC
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x1239FE4
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1231340
	public bool get_Aborted() { }

	// RVA: 0x123A1CC
	public bool get_Closed() { }

	// RVA: 0x123A258
	public void Abort() { }

	// RVA: 0x123A474
	public void Close() { }

	// RVA: 0x123A3A0
	private void SetCanceled() { }

	// RVA: 0x123A8D8
	private void SetError(Exception error) { }

	// RVA: 0x123A2A8
	private System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(ExceptionDispatchInfo field) { }

	// RVA: 0x123A988
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x123AAC4
	internal void ThrowIfDisposed() { }

	// RVA: 0x12359BC
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x12376EC
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x1236CC4
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x123AA60
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ExceptionDispatchInfo field) { }

	// RVA: 0x1234690
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x123AB30
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x123ACC4
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x123AD18
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x123AD8C
	public System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }

	// RVA: 0x123ADE0
	internal System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }

	// RVA: 0x1234924
	internal void Run() { }

	// RVA: 0x123ADE8
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x123A61C
	internal void Finish(bool ok, Exception error) { }

	// RVA: 0x123AE6C
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

	// RVA: 0x123C4C0
	private void MoveNext() { }

	// RVA: 0x123CAD4
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

	// RVA: 0x123B8A8
	public WebOperation get_Operation() { }

	// RVA: 0x123B8B0
	protected Stream get_InnerStream() { }

	// RVA: 0x122BF48
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x123B8B8
	public override Int64 get_Length() { }

	// RVA: 0x123B8F8
	public override Int64 get_Position() { }

	// RVA: 0x123B938
	public override void set_Position(Int64 value) { }

	// RVA: 0x123B978
	public override bool get_CanSeek() { }

	// RVA: 0x123B980
	public override bool get_CanRead() { }

	// RVA: 0x123B988
	public override bool get_CanWrite() { }

	// RVA: 0x123B990
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x123B9D0
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x123BA10
	public override void Flush() { }

	// RVA: 0x123BA50
	protected Exception GetException(Exception e) { }

	// RVA: 0x123BC1C
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123BF40
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x123C1A0
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x123C2F4
	public sealed override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x122C2B8
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x123C458
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

	// RVA: 0x123DB88
	private void MoveNext() { }

	// RVA: 0x123DF6C
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

	// RVA: 0x123DFD8
	private void MoveNext() { }

	// RVA: 0x123E5AC
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

	// RVA: 0x123E618
	private void MoveNext() { }

	// RVA: 0x123EC40
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

	// RVA: 0x123ECAC
	private void MoveNext() { }

	// RVA: 0x123F07C
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

	// RVA: 0x123F0E8
	private void MoveNext() { }

	// RVA: 0x123F8A8
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

	// RVA: 0x123F914
	private void MoveNext() { }

	// RVA: 0x123FF00
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

	// RVA: 0x123FF6C
	private void MoveNext() { }

	// RVA: 0x1240240
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

	// RVA: 0x12402AC
	private void MoveNext() { }

	// RVA: 0x1240C5C
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

	// RVA: 0x1236DA0
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x123CB54
	internal Stream get_InnerStream() { }

	// RVA: 0x123CB5C
	public bool get_KeepAlive() { }

	// RVA: 0x123CB64
	public override bool get_CanRead() { }

	// RVA: 0x123CB6C
	public override bool get_CanWrite() { }

	// RVA: 0x123CB74
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x123CBB0
	internal int get_WriteBufferLength() { }

	// RVA: 0x123CC00
	internal BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x123CD00
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x123CE04
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x123D0E0
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x123D230
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x123D368
	private void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0x123B5F8
	internal Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x123D410
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x123D520
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x123D628
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x123D72C
	private Task WriteChunkTrailer() { }

	// RVA: 0x123D404
	internal void KillBuffer() { }

	// RVA: 0x123D81C
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x123D8E8
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x123D928
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x123DAE4
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

	// RVA: 0x1242834
	private void MoveNext() { }

	// RVA: 0x1243308
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

	// RVA: 0x1241170
	public void .ctor() { }

	// RVA: 0x1243388
	internal System.Threading.Tasks.Task<System.Int32> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x12433C8
	internal void <ProcessRead>b__1() { }

	// RVA: 0x1243438
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

	// RVA: 0x12434C8
	private void MoveNext() { }

	// RVA: 0x1243B1C
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

	// RVA: 0x1243B9C
	private void MoveNext() { }

	// RVA: 0x1244798
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

	// RVA: 0x1244804
	private void MoveNext() { }

	// RVA: 0x124516C
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

	// RVA: 0x1240CC8
	public WebRequestStream get_RequestStream() { }

	// RVA: 0x1240CD0
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x1240CD8
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1240CE0
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1240CE8
	private void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1240CF0
	public string get_StatusDescription() { }

	// RVA: 0x1240CF8
	private void set_StatusDescription(string value) { }

	// RVA: 0x1240D00
	public Version get_Version() { }

	// RVA: 0x1240D08
	private void set_Version(Version value) { }

	// RVA: 0x1240D10
	public bool get_KeepAlive() { }

	// RVA: 0x1240D18
	private void set_KeepAlive(bool value) { }

	// RVA: 0x123B700
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x1240D20
	public override bool get_CanRead() { }

	// RVA: 0x1240D28
	public override bool get_CanWrite() { }

	// RVA: 0x1240D30
	private bool get_ChunkedRead() { }

	// RVA: 0x1240D38
	private void set_ChunkedRead(bool value) { }

	// RVA: 0x1240D40
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1240EAC
	private System.Threading.Tasks.Task<System.Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1241178
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x1241248
	private bool get_ExpectContent() { }

	// RVA: 0x12412E0
	private void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x1241988
	private System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x1241AC8
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x1241BDC
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1241C94
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x1241D44
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x123B794
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1241FF0
	private bool GetResponse(BufferOffsetSize buffer, int pos, ReadState state) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties
{
	// Methods

	// RVA: 0x12451D8
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x1245288
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1
	public abstract string get_DomainName() { }

	// RVA: 0x12452E0
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException
{
	// Methods

	// RVA: 0x12452E8
	public void .ctor() { }

	// RVA: 0x1245358
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

	// RVA: 0x1245230
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties
{
	// Methods

	// RVA: 0x1245360
	private static extern int getdomainname(Byte[] name, int len) { }

	// RVA: 0x12453F8
	public override string get_DomainName() { }

	// RVA: 0x1245604
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties
{
	// Methods

	// RVA: 0x124560C
	public void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties
{
	// Methods

	// RVA: 0x1245614
	public override string get_DomainName() { }

	// RVA: 0x1245660
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

	// RVA: 0x1245668
	public void .ctor(string procDir) { }

	// RVA: 0x1245820
	private static void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal
{
	// Fields
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Methods

	// RVA: 0x12458C4
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x1245910
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Methods

	// RVA: 0x1245A4C
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x1245A54
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x1245A5C
	internal static object get_ClassSyncObject() { }

	// RVA: 0x1245B14
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x1245CE8
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x1245CE0
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

	// RVA: 0x1245CF0
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x1245D6C
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x1245D74
	public void .ctor() { }

	// RVA: 0x1245D8C
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x1245E08
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator
{
	// Methods

	// RVA: 0x1245EAC
	public object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Methods

	// RVA: 0x1245EEC
	internal RequestCache get_Cache() { }

	// RVA: 0x1245EF4
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

	// RVA: 0x1245EFC
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x1245F78
	public RequestCacheLevel get_Level() { }

	// RVA: 0x1245F80
	public override string ToString() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol
{
	// Methods

	// RVA: 0x1246018
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

	// RVA: 0x1246060
	public void .ctor(Socket socket) { }

	// RVA: 0x1246250
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x124606C
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x124625C
	public override bool get_CanRead() { }

	// RVA: 0x1246264
	public override bool get_CanSeek() { }

	// RVA: 0x124626C
	public override bool get_CanWrite() { }

	// RVA: 0x1246274
	public override bool get_CanTimeout() { }

	// RVA: 0x124627C
	public override int get_ReadTimeout() { }

	// RVA: 0x12464D8
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1246748
	public override int get_WriteTimeout() { }

	// RVA: 0x12467D4
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x124685C
	public override Int64 get_Length() { }

	// RVA: 0x12468B0
	public override Int64 get_Position() { }

	// RVA: 0x1246904
	public override void set_Position(Int64 value) { }

	// RVA: 0x1246958
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x12469AC
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1246D94
	public override int Read(System.Span<System.Byte> destination) { }

	// RVA: 0x1247114
	public override int ReadByte() { }

	// RVA: 0x124725C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1247644
	public override void Write(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x124798C
	public override void WriteByte(Byte value) { }

	// RVA: 0x1247AC4
	public void Close(int timeout) { }

	// RVA: 0x1247B34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1247DA8
	protected override void Finalize() { }

	// RVA: 0x1247E48
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1248260
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1248548
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1248960
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1248C48
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12493F4
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1249650
	public override Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1249E70
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x124A0C8
	public override void Flush() { }

	// RVA: 0x124A0CC
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1246560
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x124A2EC
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

	// RVA: 0x12545F4
	public void .ctor() { }

}

// Namespace: 
private class TaskSocketAsyncEventArgs<T0>
{
	// Fields
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: 0x30A2378
	internal void .ctor() { }

	// RVA: 0x315B3A8
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(bool responsibleForReturningToPool) { }

}

// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0x99

	// Methods

	// RVA: 0x12545A0
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

	// RVA: 0x125572C
	private static void .cctor() { }

	// RVA: 0x1255798
	public void .ctor() { }

	// RVA: 0x12557A0
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x1255928
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x1255A60
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x1255AB4
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

	// RVA: 0x12545FC
	public void .ctor() { }

	// RVA: 0x125472C
	public bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x1254734
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x124A390
	public bool Reserve() { }

	// RVA: 0x125473C
	private void Release() { }

	// RVA: 0x12547C0
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x124A520
	public System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(Socket socket) { }

	// RVA: 0x124AAC4
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x1254E1C
	public ValueTaskSourceStatus GetStatus(Int16 token) { }

	// RVA: 0x1254F70
	public void OnCompleted(System.Action<System.Object> continuation, object state, Int16 token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x1254A00
	private void InvokeContinuation(System.Action<System.Object> continuation, object state, bool forceAsync) { }

	// RVA: 0x12552EC
	public int GetResult(Int16 token) { }

	// RVA: 0x1255434
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16 token) { }

	// RVA: 0x1254F1C
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x1255298
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x1255408
	private void ThrowException(SocketError error) { }

	// RVA: 0x1254D34
	private Exception CreateException(SocketError error) { }

	// RVA: 0x1255540
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

	// RVA: 0x1255B08
	private static void .cctor() { }

	// RVA: 0x1255B74
	public void .ctor() { }

	// RVA: 0x1255B7C
	internal CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x1255BD4
	internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x1255CA8
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x1255F70
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x1256558
	internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x12565B0
	internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x1256684
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x125694C
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x1256D88
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x1256E30
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x1256ED8
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x1256FDC
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12570C8
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12571B4
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x1257480
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x1257604
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x12578CC
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x1257B8C
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x125807C
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x125833C
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x1258460
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x125877C
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x1258A4C
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x1258BE0
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x1258ED0
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x125908C
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x12593A8
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x125953C
	internal void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass240_0
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x1250994
	public void .ctor() { }

	// RVA: 0x125980C
	internal void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x12531C8
	public void .ctor() { }

	// RVA: 0x1259978
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

	// RVA: 0x12539F0
	public void .ctor() { }

	// RVA: 0x1259A2C
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

	// RVA: 0x124902C
	internal System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x124A5D8
	private System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1249A50
	internal ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x124AB4C
	private System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x124B088
	private static void CompleteAccept(Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x124B3D8
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x124B2F4
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x124B58C
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x124B28C
	private void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x124B5E8
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x124BE88
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x124BEF0
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x124BF58
	public IntPtr get_Handle() { }

	// RVA: 0x124BF78
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x124BF80
	public SocketType get_SocketType() { }

	// RVA: 0x124BF88
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x124BF90
	public void set_DontFragment(bool value) { }

	// RVA: 0x124C134
	public bool get_DualMode() { }

	// RVA: 0x124C218
	public void set_DualMode(bool value) { }

	// RVA: 0x124C298
	private bool get_IsDualMode() { }

	// RVA: 0x124C2B0
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x124C2E8
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x12475DC
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x124CACC
	public int SendTo(Byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x1246D2C
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x124CE60
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x124D454
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x124BC98
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x12488E8
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1248BE0
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x12481E8
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x12484E0
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x124DD98
	private static object get_InternalSyncObject() { }

	// RVA: 0x124DE9C
	internal bool get_CleanedUp() { }

	// RVA: 0x124B87C
	internal static void InitializeSockets() { }

	// RVA: 0x124DF2C
	public void Dispose() { }

	// RVA: 0x124DFBC
	protected override void Finalize() { }

	// RVA: 0x1247C80
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x124A190
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x124E318
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x124BDA0
	private void SocketDefaults() { }

	// RVA: 0x124BB70
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, int error) { }

	// RVA: 0x124E4AC
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x124E634
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x124E78C
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x124E790
	public bool get_Blocking() { }

	// RVA: 0x124E798
	public void set_Blocking(bool value) { }

	// RVA: 0x124E864
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, int error) { }

	// RVA: 0x124E9AC
	internal static void Blocking_icall(IntPtr socket, bool block, int error) { }

	// RVA: 0x124E9B0
	public bool get_Connected() { }

	// RVA: 0x124E438
	public void set_NoDelay(bool value) { }

	// RVA: 0x124EA10
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x124EB18
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x124EC70
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x124EC74
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x124EE24
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, int error) { }

	// RVA: 0x124EF8C
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, int error) { }

	// RVA: 0x124EF90
	public Socket Accept() { }

	// RVA: 0x124F230
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x124F368
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x124F6C8
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x124F6F4
	public Socket EndAccept(Byte[] buffer, int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x124F0D0
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, int error, bool blocking) { }

	// RVA: 0x124FB48
	private static IntPtr Accept_icall(IntPtr sock, int error, bool blocking) { }

	// RVA: 0x124FB4C
	public void Bind(EndPoint localEP) { }

	// RVA: 0x124FDA8
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error) { }

	// RVA: 0x124FEF0
	private static void Bind_icall(IntPtr sock, SocketAddress sa, int error) { }

	// RVA: 0x124FEF4
	public void Listen(int backlog) { }

	// RVA: 0x124FFE4
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, int error) { }

	// RVA: 0x125012C
	private static void Listen_icall(IntPtr sock, int backlog, int error) { }

	// RVA: 0x1250130
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x12501B0
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1250658
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x125099C
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1250FF0
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1250B00
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x125125C
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1250528
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1251328
	private static void Connect_icall(IntPtr sock, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x125132C
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1251578
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1251430
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, int error) { }

	// RVA: 0x1251644
	private static void Disconnect_icall(IntPtr sock, bool reuse, int error) { }

	// RVA: 0x124CD04
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1251924
	private int Receive(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x124CEC8
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1247000
	public int Receive(System.Span<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x12478F4
	public int Send(System.ReadOnlySpan<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1251C8C
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x124DA10
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x124DC10
	public int EndReceive(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x1251B34
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1251FE8
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x12517CC
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1251FEC
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1251FF0
	private int ReceiveFrom(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, SocketError errorCode) { }

	// RVA: 0x12523FC
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1252658
	public int EndReceiveFrom(IAsyncResult asyncResult, EndPoint endPoint) { }

	// RVA: 0x1252770
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x125229C
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x1252844
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x124C944
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x124C350
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1252AF8
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x124D5E8
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1252E1C
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x124D888
	public int EndSend(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x12529A0
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1253200
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1252848
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1253204
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x124CB00
	public int SendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1253368
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1253208
	private static int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1253424
	private static int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1246308
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1253428
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x1253588
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x124C010
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x124E1A0
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x125358C
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x124D458
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x1253590
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x1253700
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x1253704
	public void Close() { }

	// RVA: 0x1247D14
	public void Close(int timeout) { }

	// RVA: 0x1253798
	internal static void Close_icall(IntPtr socket, int error) { }

	// RVA: 0x124E058
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, int error) { }

	// RVA: 0x125379C
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, int error) { }

	// RVA: 0x12537A0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1253810
	private void Linger(IntPtr handle) { }

	// RVA: 0x124E5AC
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1251648
	private void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x12516A4
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x124E9B8
	private void ThrowIfUdp() { }

	// RVA: 0x124F7F8
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x124F568
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1251ED0
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1253B34
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x124FCE8
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1253CCC
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1253CD0
	internal static int get_FamilyHint() { }

	// RVA: 0x1253E18
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x124DEAC
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1253E1C
	private static void .cctor() { }

}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Methods

	// RVA: 0x1259A74
	private static int WSAGetLastError_icall() { }

	// RVA: 0x124BC6C
	public void .ctor() { }

	// RVA: 0x1259A78
	internal void .ctor(int error, string message) { }

	// RVA: 0x124710C
	public void .ctor(int errorCode) { }

	// RVA: 0x124C93C
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1259A80
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1259A88
	public override string get_Message() { }

	// RVA: 0x1257478
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

	// RVA: 0x12539B4
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x1259B28
	public void set_Enabled(bool value) { }

	// RVA: 0x1259B30
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

	// RVA: 0x1259B38
	public void .ctor() { }

	// RVA: 0x1259B5C
	public void .ctor(AddressFamily family) { }

	// RVA: 0x1259D48
	public Socket get_Client() { }

	// RVA: 0x1259D50
	public void set_Client(Socket value) { }

	// RVA: 0x1259D58
	public void Connect(string hostname, int port) { }

	// RVA: 0x125A5D8
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x125A6D8
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x125A74C
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x125A794
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x125A930
	public NetworkStream GetStream() { }

	// RVA: 0x125AA94
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x125AD30
	public void Dispose() { }

	// RVA: 0x125AD40
	protected override void Finalize() { }

	// RVA: 0x1259CC8
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

	// RVA: 0x124BB74
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x125ADDC
	protected override bool ReleaseHandle() { }

	// RVA: 0x124FA00
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x125B4EC
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x125B708
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

	// RVA: 0x125B79C
	public Socket get_AcceptSocket() { }

	// RVA: 0x125B7A4
	public void set_AcceptSocket(Socket value) { }

	// RVA: 0x125B7AC
	public int get_BytesTransferred() { }

	// RVA: 0x125B7B4
	private void set_BytesTransferred(int value) { }

	// RVA: 0x125B7BC
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x125B7C4
	public void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x125B7CC
	public SocketError get_SocketError() { }

	// RVA: 0x125B7D4
	public void set_SocketError(SocketError value) { }

	// RVA: 0x125B7DC
	public void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x125B7E4
	public object get_UserToken() { }

	// RVA: 0x125B7EC
	public void set_UserToken(object value) { }

	// RVA: 0x1254678
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x125B7FC
	protected override void Finalize() { }

	// RVA: 0x125B80C
	private void Dispose(bool disposing) { }

	// RVA: 0x125B820
	public void Dispose() { }

	// RVA: 0x1253CC4
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x125B8C0
	internal Socket get_CurrentSocket() { }

	// RVA: 0x125B8C8
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x1253BE4
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x125B8D0
	internal void Complete_internal() { }

	// RVA: 0x125B904
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x125B92C
	public System.Memory<System.Byte> get_MemoryBuffer() { }

	// RVA: 0x125B938
	public int get_Offset() { }

	// RVA: 0x125B940
	public int get_Count() { }

	// RVA: 0x125B948
	public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }

	// RVA: 0x124A41C
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

	// RVA: 0x125B954
	private static void .cctor() { }

	// RVA: 0x125B9C0
	public void .ctor() { }

	// RVA: 0x125B9C8
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

	// RVA: 0x124F534
	public IntPtr get_Handle() { }

	// RVA: 0x125B7F4
	public void .ctor() { }

	// RVA: 0x12539F8
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x124F4E4
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1251F58
	public SocketError get_ErrorCode() { }

	// RVA: 0x124F95C
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x125B950
	internal override void CompleteDisposed() { }

	// RVA: 0x1257E78
	public void Complete() { }

	// RVA: 0x1251254
	public void Complete(bool synch) { }

	// RVA: 0x12531F8
	public void Complete(int total) { }

	// RVA: 0x1251224
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x12531D0
	public void Complete(Exception e) { }

	// RVA: 0x12575DC
	public void Complete(Socket s) { }

	// RVA: 0x125789C
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

	// RVA: 0x125BA44
	public bool get_AllowRenegotiation() { }

	// RVA: 0x125BA4C
	public string get_TargetHost() { }

	// RVA: 0x125BA54
	public void set_TargetHost(string value) { }

	// RVA: 0x125BA5C
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x125BA64
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x125BA6C
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x125BB0C
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x125BBAC
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x125BBB4
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x125BBBC
	public void .ctor() { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Methods

	// RVA: 0x125BBCC
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x125BD90
	protected Stream get_InnerStream() { }

	// RVA: 0x125BD98
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

	// RVA: 0x125BEB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125BFD8
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0x125BFEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125C110
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

	// RVA: 0x125C124
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125C1E0
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback
{
	// Methods

	// RVA: 0x125C1F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x125C2A8
	public virtual X509Certificate Invoke(string hostName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x125C9C0
	public void .ctor() { }

	// RVA: 0x125D458
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

	// RVA: 0x125C2BC
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x125C38C
	internal string get_InternalTargetHost() { }

	// RVA: 0x125C3F8
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x125C474
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x125C47C
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x125C86C
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x125C5A0
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x125C6A0
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x125C9C8
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x125CA34
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x125CAB8
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x125CAC4
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x125CB30
	public override bool get_IsAuthenticated() { }

	// RVA: 0x125CBA4
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x125CC10
	public override bool get_CanSeek() { }

	// RVA: 0x125CC18
	public override bool get_CanRead() { }

	// RVA: 0x125CC30
	public override bool get_CanTimeout() { }

	// RVA: 0x125CC54
	public override bool get_CanWrite() { }

	// RVA: 0x125CC6C
	public override int get_ReadTimeout() { }

	// RVA: 0x125CCE0
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x125CD54
	public override int get_WriteTimeout() { }

	// RVA: 0x125CDC8
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x125CE3C
	public override Int64 get_Length() { }

	// RVA: 0x125CEAC
	public override Int64 get_Position() { }

	// RVA: 0x125CF1C
	public override void set_Position(Int64 value) { }

	// RVA: 0x125CF78
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x125CFD4
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x125CFFC
	public override void Flush() { }

	// RVA: 0x125C324
	private void CheckDisposed() { }

	// RVA: 0x125D024
	protected override void Dispose(bool disposing) { }

	// RVA: 0x125D10C
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x125D180
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x125D1F4
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x125D268
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x125D2DC
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x125D360
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x125D3C8
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x125D44C
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

	// RVA: 0x125D494
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

	// RVA: 0x125D520
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection
{
	// Methods

	// RVA: 0x125D55C
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection
{
	// Methods

	// RVA: 0x125D598
	public void .ctor() { }

	// RVA: 0x125D5D4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection
{
	// Methods

	// RVA: 0x125D610
	public void .ctor() { }

	// RVA: 0x125D64C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x125D688
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement
{
	// Methods

	// RVA: 0x125D6C4
	public void .ctor() { }

	// RVA: 0x125D700
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement
{
	// Methods

	// RVA: 0x125D73C
	public void .ctor() { }

	// RVA: 0x125D778
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element
{
	// Methods

	// RVA: 0x125D7B4
	public void .ctor() { }

	// RVA: 0x125D7F0
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup
{
	// Methods

	// RVA: 0x125D82C
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection
{
	// Methods

	// RVA: 0x125D868
	public void .ctor() { }

	// RVA: 0x125D8A4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement
{
	// Methods

	// RVA: 0x125D8E0
	public void .ctor() { }

	// RVA: 0x125D91C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement
{
	// Methods

	// RVA: 0x125D958
	public void .ctor() { }

	// RVA: 0x125D994
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement
{
	// Methods

	// RVA: 0x125D9D0
	public void .ctor() { }

	// RVA: 0x125DA0C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement
{
	// Methods

	// RVA: 0x125DA48
	public void .ctor() { }

	// RVA: 0x125DA84
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection
{
	// Methods

	// RVA: 0x125DAC0
	public void .ctor() { }

	// RVA: 0x125DAFC
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection
{
	// Methods

	// RVA: 0x125DB38
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler
{
	// Methods

	// RVA: 0x125DB74
	public void .ctor() { }

	// RVA: 0x125DBB0
	public virtual object Create(object parent, object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x125DBEC
	public static void ThrowNotSupportedException() { }

}


