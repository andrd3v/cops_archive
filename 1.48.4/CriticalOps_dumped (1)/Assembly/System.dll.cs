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

	// RVA: 0xE97E90
	X509PalImpl GetX509Pal() { }

	// RVA: 0xE9823C
	void EnsureInitialized() { }

	// RVA: 0xE983C4
	X509PalImpl get_X509Pal() { }

	// RVA: 0xE98424
	X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags) { }

	// RVA: 0xE98738
	X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xE9873C
	X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xE989AC
	X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xE989B0
	X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xE98B94
	void .ctor() { }

	// RVA: 0xE98B9C
	void .cctor() { }

}

// Namespace: Mono
internal class SystemDependencyProvider 
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE98C1C
	SystemDependencyProvider get_Instance() { }

	// RVA: 0xE98C7C
	void Initialize() { }

	// RVA: 0xE98EA4
	ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	// RVA: 0xE98EAC
	SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0xE98EB4
	X509PalImpl get_X509Pal() { }

	// RVA: 0xE98DE4
	void .ctor() { }

	// RVA: 0xE98F20
	void .cctor() { }

}

// Namespace: Mono
internal static class X509Pal 
{
	// Methods

	// RVA: 0xE98FA0
	X509PalImpl get_Instance() { }

}

// Namespace: Mono
internal class X509PalImplMono 
{
	// Methods

	// RVA: 0xE990C4
	X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0xE990C8
	X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xE99148
	X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xE981B4
	void .ctor() { }

}

// Namespace: Mono
internal abstract class X509PalImpl 
{
	// Fields
	private static Byte[] signedData; // 0x0

	// Methods

	// RVA: 0x2FE36BC
	X509CertificateImpl Import(Byte[] data) { }

	// RVA: -1
	X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x2FE36BC
	X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xE99158
	Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xE9929C
	Byte[] ConvertData(Byte[] data) { }

	// RVA: 0xE98584
	X509Certificate2Impl ImportFallback(Byte[] data) { }

	// RVA: 0xE9892C
	X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xE993BC
	bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0xE993C4
	X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0xE99150
	void .ctor() { }

	// RVA: 0xE9981C
	void .cctor() { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute 
{
	// Methods

	// RVA: 0xE998C0
	void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper 
{
	// Methods

	// RVA: 0xE998C8
	void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xE99A84
	void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug 
{
	// Methods

	// RVA: 0xE99D30
	void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert) { }

	// RVA: 0xE99DD0
	void CheckAndThrow(unitytls_errorstate errorState, unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert) { }

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

	// RVA: 0xE99F20
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE99FDC
	internal unitytls_x509verify_result Invoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

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

	// RVA: 0xE99FF0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A0AC
	internal IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback 
{
	// Methods

	// RVA: 0xE9A0C0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A17C
	internal IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback 
{
	// Methods

	// RVA: 0xE9A190
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A24C
	internal void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback 
{
	// Methods

	// RVA: 0xE9A260
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A31C
	internal void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback 
{
	// Methods

	// RVA: 0xE9A33C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A3F8
	internal unitytls_x509verify_result Invoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

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

	// RVA: 0xE9A414
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A4B4
	internal unitytls_errorstate Invoke() { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t 
{
	// Methods

	// RVA: 0xE9A4C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A584
	internal void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t 
{
	// Methods

	// RVA: 0xE9A598
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A654
	internal unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t 
{
	// Methods

	// RVA: 0xE9A668
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A724
	internal unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t 
{
	// Methods

	// RVA: 0xE9A738
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A7F4
	internal unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_free_t 
{
	// Methods

	// RVA: 0xE9A808
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A8BC
	internal void Invoke(unitytls_key* key) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t 
{
	// Methods

	// RVA: 0xE9A8D0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9A974
	internal IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t 
{
	// Methods

	// RVA: 0xE9A988
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AA44
	internal unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t 
{
	// Methods

	// RVA: 0xE9AA58
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AAFC
	internal unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t 
{
	// Methods

	// RVA: 0xE9AB10
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9ABC4
	internal unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t 
{
	// Methods

	// RVA: 0xE9ABD8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AC94
	internal void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t 
{
	// Methods

	// RVA: 0xE9ACA8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AD64
	internal void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t 
{
	// Methods

	// RVA: 0xE9AD78
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AE2C
	internal void Invoke(unitytls_x509list* list) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t 
{
	// Methods

	// RVA: 0xE9AE40
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AEE4
	internal unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t 
{
	// Methods

	// RVA: 0xE9AEF8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9AF9C
	internal unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t 
{
	// Methods

	// RVA: 0xE9AFB4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B058
	internal unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t 
{
	// Methods

	// RVA: 0xE9B098
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B13C
	internal unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t 
{
	// Methods

	// RVA: 0xE9B17C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B238
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t 
{
	// Methods

	// RVA: 0xE9B24C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B308
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t 
{
	// Methods

	// RVA: 0xE9B31C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B3D8
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t 
{
	// Methods

	// RVA: 0xE9B3EC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B4A8
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t 
{
	// Methods

	// RVA: 0xE9B4BC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B578
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t 
{
	// Methods

	// RVA: 0xE9B58C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B648
	internal unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t 
{
	// Methods

	// RVA: 0xE9B65C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B718
	internal unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t 
{
	// Methods

	// RVA: 0xE9B72C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B7E8
	internal unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t 
{
	// Methods

	// RVA: 0xE9B7FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B8B8
	internal IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t 
{
	// Methods

	// RVA: 0xE9B8CC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9B988
	internal IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t 
{
	// Methods

	// RVA: 0xE9B99C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9BA58
	internal void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t 
{
	// Methods

	// RVA: 0xE9BA6C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9BB20
	internal void Invoke(unitytls_tlsctx* ctx) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t 
{
	// Methods

	// RVA: 0xE9BB34
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xE9BBF0
	internal void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

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

	// RVA: 0xE9A40C
	void .ctor() { }

}

// Namespace: Mono.Unity
internal static class UnityTls 
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Methods

	// RVA: 0xE99F00
	IntPtr GetUnityTlsInterface() { }

	// RVA: 0xE99F04
	bool get_IsSupported() { }

	// RVA: 0xE99C38
	unitytls_interface_struct get_NativeInterface() { }

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

	// RVA: 0xE9BF34
	void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xE9CA68
	void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	// RVA: 0xE9CDE0
	bool get_IsAuthenticated() { }

	// RVA: 0xE9CDE8
	X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xE9CDF0
	X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0xE9CDF8
	void Flush() { }

	// RVA: 0xE9CDFC
	System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xE9CFE4
	System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xE9D1AC
	void Renegotiate() { }

	// RVA: 0xE9D1EC
	bool PendingRenegotiation() { }

	// RVA: 0xE9D1F4
	void Shutdown() { }

	// RVA: 0xE9D318
	void Dispose(bool disposing) { }

	// RVA: 0xE9D420
	void StartHandshake() { }

	// RVA: 0xE9D600
	bool ProcessHandshake() { }

	// RVA: 0xE9D7FC
	void FinishHandshake() { }

	// RVA: 0xE9BC04
	IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xE9D954
	IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xE9BCD8
	IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xE9DDC4
	IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xE9BDAC
	unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xE9E234
	unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xE9BE68
	void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xE9E720
	void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions 
{
	// Methods

	// RVA: 0xE9CA04
	unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xE9CA34
	unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xE9D934
	TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xE99EA8
	AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xE9EFC0
	SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

	// RVA: 0xE9EFF0
	X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider 
{
	// Methods

	// RVA: 0xE9F090
	string get_Name() { }

	// RVA: 0xE9F0D4
	Guid get_ID() { }

	// RVA: 0xE9F150
	bool get_SupportsSslStream() { }

	// RVA: 0xE9F158
	bool get_SupportsMonoExtensions() { }

	// RVA: 0xE9F160
	bool get_SupportsConnectionInfo() { }

	// RVA: 0xE9F168
	bool get_SupportsCleanShutdown() { }

	// RVA: 0xE9F170
	SslProtocols get_SupportedProtocols() { }

	// RVA: 0xE9F178
	MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xE9F028
	unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xE9F2E0
	bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0xE9FF30
	void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream 
{
	// Methods

	// RVA: 0xE9F248
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEA0140
	MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

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

	// RVA: 0xE9E67C
	void .ctor(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder) { }

	// RVA: 0xE9FE54
	void .ctor(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder) { }

	// RVA: 0xEA01AC
	bool get_IsValid() { }

	// RVA: 0xEA01E0
	unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0xEA01E8
	X509ChainElementCollection get_ChainElements() { }

	// RVA: 0xEA04F8
	void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0xEA05FC
	X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xEA0604
	bool Build(X509Certificate2 certificate) { }

	// RVA: 0xEA060C
	void Reset() { }

	// RVA: 0xEA0698
	void Dispose(bool disposing) { }

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

	// RVA: 0xEA06D0
	int get_EndOffset() { }

	// RVA: 0xEA06DC
	int get_Remaining() { }

	// RVA: 0xEA0708
	void .ctor(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA0824
	string ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2 
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0xEA08CC
	void .ctor(int size) { }

	// RVA: 0xEA0940
	void Reset() { }

	// RVA: 0xEA09B4
	void MakeRoom(int size) { }

	// RVA: 0xEA0A8C
	void AppendData(Byte[] buffer, int offset, int size) { }

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

	// RVA: 0xEA0AF0
	int get_UserResult() { }

	// RVA: 0xEA0AF8
	ExceptionDispatchInfo get_Error() { }

	// RVA: 0xEA0B00
	void .ctor(int result) { }

	// RVA: 0xEA0B2C
	void .ctor(ExceptionDispatchInfo error) { }

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

	// RVA: 0xEA1118
	void MoveNext() { }

	// RVA: 0xEA1544
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA15C4
	void MoveNext() { }

	// RVA: 0xEA21E4
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA2250
	void MoveNext() { }

	// RVA: 0xEA297C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA0B60
	MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xEA0B68
	bool get_RunSynchronously() { }

	// RVA: 0xEA0B70
	string get_Name() { }

	// RVA: 0xEA0B98
	int get_UserResult() { }

	// RVA: 0xEA0BA0
	void set_UserResult(int value) { }

	// RVA: 0xEA0BA8
	void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEA0C48
	void RequestRead(int size) { }

	// RVA: 0xEA0D20
	void RequestWrite() { }

	// RVA: 0xEA0D2C
	System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEA0E60
	Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xEA0F70
	System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xEA10A8
	string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest 
{
	// Methods

	// RVA: 0xEA29FC
	void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xEA2A9C
	AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest 
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private int <CurrentSize>k__BackingField; // 0x40

	// Methods

	// RVA: 0xEA2EA8
	BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xEA2EB0
	int get_CurrentSize() { }

	// RVA: 0xEA2EB8
	void set_CurrentSize(int value) { }

	// RVA: 0xEA2EC0
	void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA2FCC
	string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest 
{
	// Methods

	// RVA: 0xEA3040
	void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA3044
	AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest 
{
	// Methods

	// RVA: 0xEA322C
	void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA3230
	AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0 
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0xEA3CEC
	void .ctor() { }

	// RVA: 0xEA46EC
	bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

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

	// RVA: 0xEA343C
	ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xEA392C
	ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xEA3528
	void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0xEA3AF0
	ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0xEA3CF4
	X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xEA3D40
	MonoTlsSettings get_Settings() { }

	// RVA: 0xEA3D48
	bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0xEA3DA0
	ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xEA3F78
	ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEA4064
	ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEA460C
	bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }

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

	// RVA: 0xEA6264
	void MoveNext() { }

	// RVA: 0xEA6D14
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA6D80
	void MoveNext() { }

	// RVA: 0xEA762C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0 
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0xEA76AC
	void .ctor() { }

	// RVA: 0xEA76B4
	int <InnerRead>b__0() { }

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

	// RVA: 0xEA7700
	void MoveNext() { }

	// RVA: 0xEA7BFC
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA7C7C
	void MoveNext() { }

	// RVA: 0xEA7FB8
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xE9FF40
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEA4850
	SslStream get_SslStream() { }

	// RVA: 0xEA4858
	MonoTlsSettings get_Settings() { }

	// RVA: 0xEA4860
	MobileTlsProvider get_Provider() { }

	// RVA: 0xEA4868
	string get_TargetHost() { }

	// RVA: 0xEA4870
	void set_TargetHost(string value) { }

	// RVA: 0xEA4878
	void CheckThrow(bool authSuccessCheck, bool shutdownCheck) { }

	// RVA: 0xEA1F18
	Exception GetSSPIException(Exception e) { }

	// RVA: 0xEA4944
	Exception GetIOException(Exception e, string message) { }

	// RVA: 0xEA4ADC
	Exception GetInternalError() { }

	// RVA: 0xEA4B30
	Exception GetInvalidNestedCallException() { }

	// RVA: 0xEA1500
	ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xEA4B84
	void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEA5050
	Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEA4F20
	Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: 0x2FE36BC
	MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	// RVA: 0xEA51CC
	int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEA542C
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEA5504
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEA55A4
	Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEA52CC
	System.Threading.Tasks.Task<System.Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xE9E118
	int InternalRead(Byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0xEA5644
	System.ValueTuple<System.Int32,System.Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xE9DBE4
	bool InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA57C4
	bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xEA282C
	System.Threading.Tasks.Task<System.Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xEA20C8
	Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0xEA2ABC
	AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0xEA30C0
	System.ValueTuple<System.Int32,System.Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xEA32CC
	System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xEA597C
	bool get_IsAuthenticated() { }

	// RVA: 0xEA5A80
	void Dispose(bool disposing) { }

	// RVA: 0xEA5D4C
	void Flush() { }

	// RVA: 0xEA5D74
	X509Certificate get_LocalCertificate() { }

	// RVA: 0xEA5E5C
	X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xEA5F88
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xEA5FC8
	bool get_CanRead() { }

	// RVA: 0xEA6018
	bool get_CanTimeout() { }

	// RVA: 0xEA603C
	bool get_CanWrite() { }

	// RVA: 0xEA60AC
	bool get_CanSeek() { }

	// RVA: 0xEA60B4
	Int64 get_Length() { }

	// RVA: 0xEA60D8
	Int64 get_Position() { }

	// RVA: 0xEA60FC
	void set_Position(Int64 value) { }

	// RVA: 0xEA613C
	int get_ReadTimeout() { }

	// RVA: 0xEA6164
	void set_ReadTimeout(int value) { }

	// RVA: 0xEA618C
	int get_WriteTimeout() { }

	// RVA: 0xEA61B4
	void set_WriteTimeout(int value) { }

	// RVA: 0xEA61DC
	void .cctor() { }

	// RVA: 0xEA622C
	void <InnerWrite>b__67_0() { }

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

	// RVA: 0xE9C858
	void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEA8024
	MonoSslAuthenticationOptions get_Options() { }

	// RVA: 0xEA802C
	MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xE9D2F8
	MonoTlsSettings get_Settings() { }

	// RVA: 0x2FE3054
	bool get_IsAuthenticated() { }

	// RVA: 0xEA8034
	bool get_IsServer() { }

	// RVA: 0xEA803C
	string get_TargetHost() { }

	// RVA: 0xEA8044
	string get_ServerName() { }

	// RVA: 0xEA804C
	bool get_AskForClientCertificate() { }

	// RVA: 0xEA8054
	SslProtocols get_EnabledProtocols() { }

	// RVA: 0xEA805C
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEA8064
	void GetProtocolVersions(out System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, out System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }

	// RVA: 0x2FE41A8
	void StartHandshake() { }

	// RVA: 0x2FE3054
	bool ProcessHandshake() { }

	// RVA: 0x2FE41A8
	void FinishHandshake() { }

	// RVA: 0xEA81A8
	X509Certificate get_LocalServerCertificate() { }

	// RVA: 0xEA81B0
	void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: 0x2FE360C
	X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x2FE360C
	X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0x2FE41A8
	void Flush() { }

	// RVA: -1
	System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: -1
	System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x2FE41A8
	void Shutdown() { }

	// RVA: 0x2FE3054
	bool PendingRenegotiation() { }

	// RVA: 0xE9D7A4
	bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0xEA81B8
	X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0xE9EA50
	X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: 0x2FE41A8
	void Renegotiate() { }

	// RVA: 0xEA5CB8
	void Dispose() { }

	// RVA: 0xEA8458
	void Dispose(bool disposing) { }

	// RVA: 0xEA845C
	void Finalize() { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsProvider 
{
	// Methods

	// RVA: -1
	MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1
	bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0xE9FF38
	void .ctor() { }

}

// Namespace: Mono.Net.Security
internal abstract class MonoSslAuthenticationOptions 
{
	// Fields
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x10

	// Methods

	// RVA: 0x2FE3054
	bool get_ServerMode() { }

	// RVA: 0x2FE3054
	bool get_AllowRenegotiation() { }

	// RVA: 0x2FE32D4
	SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x2FE42A4
	void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x2FE42A4
	void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x2FE42A4
	void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x2FE360C
	string get_TargetHost() { }

	// RVA: 0x2FE4574
	void set_TargetHost(string value) { }

	// RVA: 0x2FE360C
	X509Certificate get_ServerCertificate() { }

	// RVA: 0x2FE360C
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x2FE4574
	void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x2FE3054
	bool get_ClientCertificateRequired() { }

	// RVA: 0xEA84FC
	ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0xEA8504
	void .ctor() { }

}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions 
{
	// Fields
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0xEA850C
	SslClientAuthenticationOptions get_Options() { }

	// RVA: 0xEA8514
	bool get_ServerMode() { }

	// RVA: 0xEA4EA8
	void .ctor() { }

	// RVA: 0xEA851C
	bool get_AllowRenegotiation() { }

	// RVA: 0xEA853C
	void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0xEA855C
	void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0xEA857C
	SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0xEA859C
	void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0xEA85BC
	string get_TargetHost() { }

	// RVA: 0xEA85DC
	void set_TargetHost(string value) { }

	// RVA: 0xEA85FC
	bool get_ClientCertificateRequired() { }

	// RVA: 0xEA863C
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEA865C
	void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0xEA867C
	X509Certificate get_ServerCertificate() { }

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

	// RVA: 0xEA39CC
	MobileTlsProvider GetProviderInternal() { }

	// RVA: 0xEA86BC
	void InitializeInternal() { }

	// RVA: 0xEA8EEC
	MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0xEA8AB4
	void InitializeProviderRegistration() { }

	// RVA: 0xEA9590
	void PopulateUnityProviders() { }

	// RVA: 0xEA96E0
	void PopulateProviders() { }

	// RVA: 0xEA9934
	bool IsBtlsSupported() { }

	// RVA: 0xEA8CD4
	MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xEA9A10
	MobileTlsProvider GetProvider() { }

	// RVA: 0xEA9A78
	void .cctor() { }

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

	// RVA: 0xEAA0D4
	void MoveNext() { }

	// RVA: 0xEAA8EC
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0xEA9BBC
	HttpWebRequest get_Request() { }

	// RVA: 0xEA9BC4
	WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xEA9BCC
	bool get_CertificateValidationFailed() { }

	// RVA: 0xEA9BD4
	void set_CertificateValidationFailed(bool value) { }

	// RVA: 0xEA9BDC
	void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xEA9E94
	System.Threading.Tasks.Task<System.IO.Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0xEA9FEC
	void Dispose() { }

	// RVA: 0xEA9FF0
	void CloseSslStream() { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper 
{
	// Methods

	// RVA: 0xEAA96C
	object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator 
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xEAAA1C
	void .cctor() { }

	// RVA: 0xEA46E4
	bool NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0 
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xEAAA70
	void .ctor() { }

	// RVA: 0xEAAA80
	bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xEAAA78
	void .ctor() { }

	// RVA: 0xEAAAA8
	X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers 
{
	// Methods

	// RVA: 0xEA9DB0
	MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	// RVA: 0xEA3C08
	LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: Mono.Http
internal class NtlmSession 
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xEAAAD0
	void .ctor() { }

	// RVA: 0xEAAAD8
	Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Mono.Http.NtlmClient.<>c <>9; // 0x0
	public static CreateValueCallback <>9__1_0; // 0x8

	// Methods

	// RVA: 0xEAB40C
	void .cctor() { }

	// RVA: 0xEAB478
	void .ctor() { }

	// RVA: 0xEAB480
	NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Mono.Http
internal class NtlmClient 
{
	// Fields
	private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache; // 0x0

	// Methods

	// RVA: 0xEAAF94
	Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEAB31C
	Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEAB324
	string get_AuthenticationType() { }

	// RVA: 0xEAB368
	void .ctor() { }

	// RVA: 0xEAB370
	void .cctor() { }

}

// Namespace: 
protected internal class BoringBioHandle 
{
	// Methods

	// RVA: 0xEAB680
	void .ctor(IntPtr handle) { }

	// RVA: 0xEAB694
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBio 
{
	// Methods

	// RVA: 0xEAB4D8
	void .ctor(BoringBioHandle handle) { }

	// RVA: 0xEAB540
	BoringBioHandle get_Handle() { }

	// RVA: 0xEAB5E8
	void mono_btls_bio_free(IntPtr handle) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory 
{
	// Methods

	// RVA: 0xEAB73C
	IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0xEAB7C0
	int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data) { }

	// RVA: 0xEAB850
	void .ctor() { }

	// RVA: 0xEAB930
	Byte[] GetData() { }

}

// Namespace: Mono.Btls
internal interface IMonoBtlsBioMono 
{
	// Methods

	// RVA: -1
	int Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	// RVA: -1
	bool Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x2FE41A8
	void Flush() { }

	// RVA: 0x2FE41A8
	void Close() { }

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

	// RVA: 0xEAC78C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xEACF18
	internal int Invoke(IntPtr bio, IntPtr data, int dataLength, out int wantMore) { }

}

// Namespace: 
private sealed class BioWriteFunc 
{
	// Methods

	// RVA: 0xEAC830
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xEACF2C
	internal int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

}

// Namespace: 
private sealed class BioControlFunc 
{
	// Methods

	// RVA: 0xEAC8D4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xEACF40
	internal Int64 Invoke(IntPtr bio, ControlCommand command, Int64 arg) { }

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

	// RVA: 0xEAC26C
	void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0xEAC708
	IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0xEAC978
	void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0xEACA28
	Int64 Control(ControlCommand command, Int64 arg) { }

	// RVA: 0xEACB20
	int OnRead(IntPtr data, int dataLength, out int wantMore) { }

	// RVA: 0xEABDE4
	int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) { }

	// RVA: 0xEACCBC
	int OnWrite(IntPtr data, int dataLength) { }

	// RVA: 0xEABF78
	int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	// RVA: 0xEAC0F4
	Int64 Control(IntPtr instance, ControlCommand command, Int64 arg) { }

	// RVA: 0xEACDF4
	void Close() { }

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

	// RVA: 0xEACF54
	void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEACFA0
	X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0xEAD1E4
	int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0xEAD4F0
	int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0xEADA14
	int ServerNameCallback() { }

	// RVA: 0xEADA7C
	void StartHandshake() { }

	// RVA: 0xEAD724
	void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0xEAE024
	Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0xEAE8AC
	bool ProcessHandshake() { }

	// RVA: 0xEAEAB8
	MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0xEAECEC
	void FinishHandshake() { }

	// RVA: 0xEADBB8
	void InitializeConnection() { }

	// RVA: 0xEAD5C8
	void GetPeerCertificate() { }

	// RVA: 0xEAED14
	void InitializeSession() { }

	// RVA: 0xEAF624
	TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0xEAF68C
	void Flush() { }

	// RVA: 0xEAF6CC
	System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEAF9C8
	System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEAFC7C
	void Renegotiate() { }

	// RVA: 0xEAFCBC
	void Shutdown() { }

	// RVA: 0xEAFD10
	bool PendingRenegotiation() { }

	// RVA: 0x2FE4574
	void Dispose(ref T disposable) { }

	// RVA: 0xEAFD30
	void Dispose(bool disposing) { }

	// RVA: 0xEAFEBC
	int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	// RVA: 0xEAFED8
	bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEAFEF4
	void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0xEAFEF8
	void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xEAFEFC
	bool get_IsAuthenticated() { }

	// RVA: 0xEAFF04
	X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xEAFF0C
	X509Certificate2 get_RemoteCertificate() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsError 
{
	// Methods

	// RVA: 0xEAFF14
	void mono_btls_error_clear_error() { }

	// RVA: 0xEAFF98
	int mono_btls_error_get_error_line(out IntPtr file, out int line) { }

	// RVA: 0xEB0028
	void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0xEB00C0
	int mono_btls_error_get_reason(int error) { }

	// RVA: 0xEAEA34
	void ClearError() { }

	// RVA: 0xEAE660
	string GetErrorString(int error) { }

	// RVA: 0xEAE408
	int GetError(out string file, out int line) { }

	// RVA: 0xEAE5C8
	int GetErrorReason(int error) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsException 
{
	// Methods

	// RVA: 0xEB0158
	void .ctor() { }

	// RVA: 0xEAE514
	void .ctor(MonoBtlsSslError error) { }

	// RVA: 0xEAE840
	void .ctor(string message) { }

	// RVA: 0xEB01E0
	void .ctor(string format, object[] args) { }

}

// Namespace: 
internal class BoringKeyHandle 
{
	// Methods

	// RVA: 0xEB0BCC
	void .ctor(IntPtr handle) { }

	// RVA: 0xEB0E0C
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsKey 
{
	// Methods

	// RVA: 0xEB026C
	IntPtr mono_btls_key_new() { }

	// RVA: 0xEB02F0
	void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0xEB0388
	IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0xEB0420
	int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	// RVA: 0xEB04C8
	int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	// RVA: 0xEB0568
	BoringKeyHandle get_Handle() { }

	// RVA: 0xEB05EC
	void .ctor(BoringKeyHandle handle) { }

	// RVA: 0xEB0620
	Byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0xEB0974
	MonoBtlsKey Copy() { }

	// RVA: 0xEB0BD8
	MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

}

// Namespace: 
protected internal abstract class MonoBtlsHandle 
{
	// Methods

	// RVA: 0xEAB68C
	void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0xEB122C
	bool get_IsInvalid() { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject 
{
	// Fields
	private MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Methods

	// RVA: 0xEAB50C
	void .ctor(MonoBtlsHandle handle) { }

	// RVA: 0xEAB5C4
	MonoBtlsHandle get_Handle() { }

	// RVA: 0xEB0E90
	bool get_IsValid() { }

	// RVA: 0xEB0B4C
	void CheckThrow() { }

	// RVA: 0xEACC78
	Exception SetException(Exception ex) { }

	// RVA: 0xEABC64
	void CheckError(bool ok, string callerName) { }

	// RVA: 0xEB08D0
	void CheckError(int ret, string callerName) { }

	// RVA: 0xEAEB0C
	void CheckLastError(string callerName) { }

	// RVA: 0xEB0EB8
	void mono_btls_free(IntPtr data) { }

	// RVA: 0xEB08DC
	void FreeDataPtr(IntPtr data) { }

	// RVA: 0xEB0F50
	void Close() { }

	// RVA: 0xEB0F54
	void Dispose(bool disposing) { }

	// RVA: 0xEB10E0
	void Dispose() { }

	// RVA: 0xEB1180
	void Finalize() { }

}

// Namespace: 
internal class BoringPkcs12Handle 
{
	// Methods

	// RVA: 0xEB1804
	void .ctor(IntPtr handle) { }

	// RVA: 0xEB1F3C
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12 
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Methods

	// RVA: 0xEB123C
	BoringPkcs12Handle get_Handle() { }

	// RVA: 0xEB12C0
	void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0xEB1358
	IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0xEB13DC
	int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0xEB1474
	IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0xEB1504
	int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	// RVA: 0xEB15F4
	int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0xEB168C
	IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0xEB1724
	void .ctor() { }

	// RVA: 0xEB1810
	int get_Count() { }

	// RVA: 0xEB1918
	MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0xEB1B10
	void Import(Byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0xEB1C28
	bool get_HasPrivateKey() { }

	// RVA: 0xEB1D20
	MonoBtlsKey GetPrivateKey() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsProvider 
{
	// Methods

	// RVA: 0xEB1FC0
	Guid get_ID() { }

	// RVA: 0xEB203C
	string get_Name() { }

	// RVA: 0xEA9938
	void .ctor() { }

	// RVA: 0xEB2080
	bool get_SupportsSslStream() { }

	// RVA: 0xEB2088
	bool get_SupportsMonoExtensions() { }

	// RVA: 0xEB2090
	bool get_SupportsConnectionInfo() { }

	// RVA: 0xEB2098
	bool get_SupportsCleanShutdown() { }

	// RVA: 0xEB20A0
	SslProtocols get_SupportedProtocols() { }

	// RVA: 0xEB20A8
	MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xEB2140
	X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0xEB2368
	X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0xEB22E8
	X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0xEAF214
	MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0xEB2480
	bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0xEB3064
	bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0xEB2AF4
	void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0xEB334C
	X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0xEAEEC0
	void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEB35C4
	void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0xEB3654
	void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0xEB36B0
	void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0xEB3588
	void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEAF4A8
	X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0xEB2FD0
	X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0xEB370C
	MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0xEB2BE0
	MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsVerifyCallback 
{
	// Methods

	// RVA: 0x1236700
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1236820
	internal int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsSelectCallback 
{
	// Methods

	// RVA: 0x1236834
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12368E8
	internal int Invoke(string[] acceptableIssuers) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsServerNameCallback 
{
	// Methods

	// RVA: 0x12368FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x123699C
	internal int Invoke() { }

}

// Namespace: 
internal class BoringSslHandle 
{
	// Methods

	// RVA: 0x1237AA0
	void .ctor(IntPtr handle) { }

	// RVA: 0x1239DC8
	bool ReleaseHandle() { }

}

// Namespace: 
private sealed class PrintErrorsCallbackFunc 
{
	// Methods

	// RVA: 0x1237C14
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1239E5C
	internal int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsSsl 
{
	// Fields
	private MonoBtlsBio bio; // 0x20
	private PrintErrorsCallbackFunc printErrorsFunc; // 0x28
	private IntPtr printErrorsFuncPtr; // 0x30

	// Methods

	// RVA: 0x1236B40
	void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x1236BD8
	IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x1236C70
	int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1236D00
	int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x1236D90
	int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1236E20
	int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x1236EB8
	int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x1236F50
	int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x1236FE8
	void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x123707C
	int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x1237114
	void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x12371A4
	void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x1237234
	int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x12372CC
	int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x1237360
	int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x12373F0
	int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x1237488
	int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x1237520
	IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x12375B8
	void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x1237648
	int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x12376D8
	IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x1237770
	void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x1237800
	int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x1237898
	BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1237AAC
	void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x1237CB8
	BoringSslHandle get_Handle() { }

	// RVA: 0x1237D3C
	void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x1237E6C
	Exception ThrowError(string callerName) { }

	// RVA: 0x12381F4
	MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x123833C
	void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1238554
	void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x1238694
	void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1238828
	MonoBtlsSslError Accept() { }

	// RVA: 0x1238934
	MonoBtlsSslError Connect() { }

	// RVA: 0x1238A40
	MonoBtlsSslError Handshake() { }

	// RVA: 0x12369B0
	int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x1238054
	string GetErrors() { }

	// RVA: 0x1238B4C
	void PrintErrors() { }

	// RVA: 0x1238CCC
	MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	// RVA: 0x1238E30
	MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

	// RVA: 0x123903C
	int GetVersion() { }

	// RVA: 0x123914C
	int GetCipher() { }

	// RVA: 0x12392C0
	MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x123948C
	void SetServerName(string name) { }

	// RVA: 0x12396D4
	string GetServerName() { }

	// RVA: 0x1239858
	void Shutdown() { }

	// RVA: 0x1239974
	void SetQuietShutdown() { }

	// RVA: 0x1239A70
	void Close() { }

	// RVA: 0x1239BC8
	void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x1239CD0
	bool RenegotiatePending() { }

}

// Namespace: 
internal class BoringSslCtxHandle 
{
	// Methods

	// RVA: 0x123ACE8
	void .ctor(IntPtr handle) { }

	// RVA: 0x123CAC0
	bool ReleaseHandle() { }

}

// Namespace: 
private sealed class NativeVerifyFunc 
{
	// Methods

	// RVA: 0x123B138
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x123CB44
	internal int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

}

// Namespace: 
private sealed class NativeSelectFunc 
{
	// Methods

	// RVA: 0x123B1DC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x123CB58
	internal int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

}

// Namespace: 
private sealed class NativeServerNameFunc 
{
	// Methods

	// RVA: 0x123B280
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x123CB6C
	internal int Invoke(IntPtr instance) { }

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

	// RVA: 0x1237A1C
	BoringSslCtxHandle get_Handle() { }

	// RVA: 0x123A5B4
	IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x123A638
	int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x123A6D0
	void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x123A760
	void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x123A7F8
	void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x123A888
	void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x123A918
	void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x123A9A8
	int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x123AA50
	int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x123AAE0
	int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x123AB88
	void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x123AC18
	void .ctor() { }

	// RVA: 0x123ACF4
	void .ctor(BoringSslCtxHandle handle) { }

	// RVA: 0x123B354
	MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x123B35C
	int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	// RVA: 0x1239E70
	int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x123A27C
	int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x123B420
	string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x123BB0C
	void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x123BCA4
	void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x123BDC0
	void SetMinVersion(int version) { }

	// RVA: 0x123BEC8
	void SetMaxVersion(int version) { }

	// RVA: 0x123BFD0
	void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	// RVA: 0x123C24C
	void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x123C4B8
	void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x123C93C
	void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	// RVA: 0x123A440
	int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x123CA58
	void Close() { }

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

	// RVA: 0x123CB80
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x123CC1C
	MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils 
{
	// Fields
	private static Byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x123CC8C
	bool Compare(Byte[] a, Byte[] b) { }

	// RVA: 0x123CD00
	bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x123B9C4
	string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x123DA2C
	void .cctor() { }

}

// Namespace: 
internal class BoringX509Handle 
{
	// Methods

	// RVA: 0x1239478
	void .ctor(IntPtr handle) { }

	// RVA: 0x123ED64
	bool ReleaseHandle() { }

	// RVA: 0x123EDFC
	IntPtr StealHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509 
{
	// Methods

	// RVA: 0x12384D0
	BoringX509Handle get_Handle() { }

	// RVA: 0x1239484
	void .ctor(BoringX509Handle handle) { }

	// RVA: 0x123DAD0
	IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x123DB68
	IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x123DC00
	IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x123DC98
	int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x123DD30
	int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x123DDC0
	void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x123DE54
	int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x123DEE4
	MonoBtlsX509 Copy() { }

	// RVA: 0x123E0A4
	MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x123E36C
	MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x123E574
	Int64 GetSubjectNameHash() { }

	// RVA: 0x123E7CC
	Byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x123EA88
	int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x123EBEC
	void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

}

// Namespace: 
internal class BoringX509ChainHandle 
{
	// Methods

	// RVA: 0x123F2D0
	void .ctor(IntPtr handle) { }

	// RVA: 0x123F918
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain 
{
	// Methods

	// RVA: 0x123EE0C
	BoringX509ChainHandle get_Handle() { }

	// RVA: 0x123EE90
	IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x123EF14
	int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x123EFAC
	IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x123F03C
	int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x123F0CC
	IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x123F164
	void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x123F1FC
	void .ctor() { }

	// RVA: 0x123F2DC
	void .ctor(BoringX509ChainHandle handle) { }

	// RVA: 0x123F2E4
	int get_Count() { }

	// RVA: 0x123F3EC
	MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x123F5EC
	void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x123F758
	MonoBtlsX509Chain Copy() { }

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

	// RVA: 0x123FF20
	void .ctor(IntPtr handle) { }

	// RVA: 0x1240AC4
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Lookup 
{
	// Fields
	private MonoBtlsX509Store store; // 0x20
	private MonoBtlsX509LookupType type; // 0x28
	private System.Collections.Generic.List<Mono.Btls.MonoBtlsX509LookupMono> monoLookups; // 0x30

	// Methods

	// RVA: 0x123F99C
	BoringX509LookupHandle get_Handle() { }

	// RVA: 0x123FA20
	IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x123FAB0
	int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x123FB48
	int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x123FBD8
	void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x123FC70
	IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x123FD08
	BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x123FF2C
	void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x123FF88
	IntPtr GetNativeLookup() { }

	// RVA: 0x1240090
	void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12402D8
	void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x124066C
	void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x1240858
	void Close() { }

}

// Namespace: 
internal class BoringX509LookupMonoHandle 
{
	// Methods

	// RVA: 0x124133C
	void .ctor(IntPtr handle) { }

	// RVA: 0x12414DC
	bool ReleaseHandle() { }

}

// Namespace: 
private sealed class BySubjectFunc 
{
	// Methods

	// RVA: 0x1241348
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1241560
	internal int Invoke(IntPtr instance, IntPtr name, out IntPtr x509_ptr) { }

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

	// RVA: 0x1240590
	BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x1240EB0
	IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x1240F34
	void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x1240FCC
	int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x1241064
	void .ctor() { }

	// RVA: 0x1240614
	void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x12413EC
	void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x2FE36BC
	MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x1240B48
	int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

	// RVA: 0x1241410
	void Close() { }

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

	// RVA: 0x1241574
	void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x12415B8
	void Initialize() { }

	// RVA: 0x12417A0
	MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x1241858
	void Close() { }

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

	// RVA: 0x123E53C
	void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1241F04
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name 
{
	// Methods

	// RVA: 0x12419A8
	Int64 mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x1241A40
	int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x1241AD8
	MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x1241B68
	int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x1241C10
	int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	// RVA: 0x1241CA8
	int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	// RVA: 0x1241D50
	IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	// RVA: 0x1241DE8
	void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x1241E80
	BoringX509NameHandle get_Handle() { }

	// RVA: 0x123E56C
	void .ctor(BoringX509NameHandle handle) { }

	// RVA: 0x123E6C4
	Int64 GetHash() { }

	// RVA: 0x123D924
	int GetEntryCount() { }

	// RVA: 0x123D0C4
	MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x123D688
	string GetEntryOid(int index) { }

	// RVA: 0x123D204
	Byte[] GetEntryOidData(int index) { }

	// RVA: 0x123D3E8
	string GetEntryValue(int index, out int tag) { }

	// RVA: 0x123B7E0
	MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

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

	// RVA: 0x124230C
	void .ctor(IntPtr handle) { }

	// RVA: 0x12429B8
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

	// Methods

	// RVA: 0x123FE9C
	BoringX509StoreHandle get_Handle() { }

	// RVA: 0x1241FA4
	IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x1242028
	IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x12420C0
	int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x1242150
	void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x12421E8
	BoringX509StoreHandle Create_internal() { }

	// RVA: 0x1242318
	BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	// RVA: 0x1242434
	void .ctor() { }

	// RVA: 0x123B324
	void .ctor(BoringSslCtxHandle ctx) { }

	// RVA: 0x1240688
	void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1242460
	MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x124260C
	void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1242644
	void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1242720
	void Close() { }

}

// Namespace: 
internal class BoringX509StoreCtxHandle 
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x1243164
	void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1243FB0
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx 
{
	// Fields
	private System.Nullable<System.Int32> verifyResult; // 0x20

	// Methods

	// RVA: 0x1242A3C
	BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x1242AC0
	IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x1242B44
	IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x1242BDC
	MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	// RVA: 0x1242C6C
	IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x1242D04
	int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x1242D9C
	int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x1242E2C
	int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x1242EC4
	IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x1242F5C
	IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x1242FF4
	void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x124308C
	void .ctor() { }

	// RVA: 0x1243194
	BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x123B384
	void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x12432A8
	void .ctor(BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }

	// RVA: 0x12432D4
	MonoBtlsX509Error GetError() { }

	// RVA: 0x12433CC
	MonoBtlsX509Chain GetChain() { }

	// RVA: 0x1243594
	MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x124375C
	void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x12439A0
	void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1243B70
	int get_VerifyResult() { }

	// RVA: 0x1243C58
	int Verify() { }

	// RVA: 0x1243DE4
	MonoBtlsX509StoreCtx Copy() { }

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

	// RVA: 0x1244050
	void Initialize() { }

	// RVA: 0x1244230
	void DoInitialize() { }

	// RVA: 0x12443C8
	string GetStorePath(MonoBtlsX509StoreType type) { }

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

	// RVA: 0x1244A64
	void .ctor(IntPtr handle) { }

	// RVA: 0x1245424
	bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam 
{
	// Methods

	// RVA: 0x123C434
	BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x1244514
	IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x12445AC
	IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x1244644
	int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x12446DC
	int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x1244774
	int mono_btls_x509_verify_param_set_time(IntPtr handle, Int64 time) { }

	// RVA: 0x1244804
	void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x124489C
	void .ctor(BoringX509VerifyParamHandle handle) { }

	// RVA: 0x12448A4
	MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x1244A70
	MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x1244D90
	MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x1244AB8
	MonoBtlsX509VerifyParam Lookup(string name, bool fail) { }

	// RVA: 0x1244DD8
	bool get_CanModify() { }

	// RVA: 0x1244ED0
	void WantToModify() { }

	// RVA: 0x1244F38
	void SetHost(string name) { }

	// RVA: 0x12451E0
	void SetTime(DateTime time) { }

}

// Namespace: Mono.Btls
internal class X509CertificateImplBtls 
{
	// Fields
	private MonoBtlsX509 x509; // 0xB0
	private MonoBtlsKey nativePrivateKey; // 0xB8
	private X509CertificateImplCollection intermediateCerts; // 0xC0

	// Methods

	// RVA: 0x12454A8
	void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x12454EC
	void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x12455A4
	void .ctor(Byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x12455F0
	void .ctor(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x124610C
	bool get_IsValid() { }

	// RVA: 0x1246120
	MonoBtlsX509 get_X509() { }

	// RVA: 0x1246148
	MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x1246170
	X509CertificateImpl Clone() { }

	// RVA: 0x12461E0
	Byte[] GetRawCertData() { }

	// RVA: 0x1246220
	X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1246228
	void Dispose(bool disposing) { }

	// RVA: 0x124626C
	bool get_HasPrivateKey() { }

	// RVA: 0x124627C
	AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12462AC
	void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x12463F0
	RSA GetRSAPrivateKey() { }

	// RVA: 0x1246420
	DSA GetDSAPrivateKey() { }

	// RVA: 0x12459C8
	void Import(Byte[] data) { }

	// RVA: 0x1245A34
	void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	// RVA: 0x1246038
	void ImportAuthenticode(Byte[] data) { }

	// RVA: 0x1246460
	bool Verify(X509Certificate2 thisCertificate) { }

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

	// RVA: 0x12466E4
	void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x1246780
	void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x1246A94
	bool get_IsValid() { }

	// RVA: 0x1246AA8
	MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x1246AD0
	X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1246DF4
	X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1246DFC
	void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x1246F00
	bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1246F08
	void Reset() { }

	// RVA: 0x1246FB8
	void Dispose(bool disposing) { }

}

// Namespace: Mono.Btls
internal class X509PalImplBtls 
{
	// Fields
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1247118
	void .ctor(MonoTlsProvider provider) { }

	// RVA: 0x1247234
	MonoBtlsProvider get_Provider() { }

	// RVA: 0x124723C
	X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0x1247264
	X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1247284
	X509Certificate2Impl Import(X509Certificate cert) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Internal.Cryptography.OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x12499D4
	void .cctor() { }

	// RVA: 0x1249A40
	void .ctor() { }

	// RVA: 0x1249A48
	string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

	// RVA: 0x1249B14
	string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

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

	// RVA: 0x12472A4
	string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12477B4
	string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x124748C
	bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x1247494
	string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x12479A0
	string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1247CC8
	void .cctor() { }

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

	// RVA: 0x124B4E0
	void .ctor(int <>1__state) { }

	// RVA: 0x124B518
	void System.IDisposable.Dispose() { }

	// RVA: 0x124B51C
	bool MoveNext() { }

	// RVA: 0x124B7F0
	System.Collections.Generic.KeyValuePair<System.String,System.String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	// RVA: 0x124B7FC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x124B83C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x124B8A4
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x124B94C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x1249BDC
	void .ctor(Byte[] rawData) { }

	// RVA: 0x124A414
	string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x124ACAC
	string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x124B22C
	string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	// RVA: 0x124B458
	System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(X500DistinguishedName name) { }

}

// Namespace: System
internal static class IPv4AddressHelper 
{
	// Methods

	// RVA: 0x124B950
	int ParseHostNumber(System.ReadOnlySpan<System.Char> str, int start, int end) { }

	// RVA: 0x124BB58
	bool IsValid(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x124B984
	bool ParseCanonical(System.ReadOnlySpan<System.Char> name, Byte* numbers, int start, int end) { }

	// RVA: 0x124BB84
	bool IsValidCanonical(Char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x124BEAC
	Int64 ParseNonCanonical(Char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x124C274
	string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x124C734
	bool Parse(string name, Byte* numbers, int start, int end) { }

}

// Namespace: System
internal static class IPv6AddressHelper 
{
	// Methods

	// RVA: 0x124C7A4
	System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x124C898
	bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x124C97C
	bool IsValidStrict(Char* name, int start, ref int end) { }

	// RVA: 0x124CDF8
	void Parse(System.ReadOnlySpan<System.Char> address, UInt16* numbers, int start, ref string scopeId) { }

	// RVA: 0x124D394
	string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x124DCA8
	bool IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x124DD94
	bool InternalIsValid(Char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x124E174
	bool IsValid(Char* name, int start, ref int end) { }

}

// Namespace: System
internal static class NotImplemented 
{
	// Methods

	// RVA: 0x124E17C
	Exception ByDesignWithMessage(string message) { }

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

	// RVA: 0x124E1E4
	void .ctor(Uri uri) { }

	// RVA: 0x124E3BC
	void Init(Uri uri) { }

	// RVA: 0x124E78C
	void set_Path(string value) { }

	// RVA: 0x124E854
	Uri get_Uri() { }

	// RVA: 0x124E8FC
	bool Equals(object rparam) { }

	// RVA: 0x124E9E8
	int GetHashCode() { }

	// RVA: 0x124E59C
	void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x124EAA0
	string ToString() { }

}

// Namespace: System
internal static class SecurityUtils 
{
	// Methods

	// RVA: 0x124F104
	void DemandReflectionAccess(Type type) { }

	// RVA: 0x124F108
	void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x124F10C
	bool HasReflectionPermission(Type type) { }

	// RVA: 0x124F114
	object SecureCreateInstance(Type type) { }

	// RVA: 0x124F120
	object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x124F240
	object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x124F248
	object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x124F250
	object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x124F404
	bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x124F4AC
	object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

// Namespace: System
internal class InvariantComparer 
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10
	internal static readonly InvariantComparer Default; // 0x0

	// Methods

	// RVA: 0x124F6A0
	void .ctor() { }

	// RVA: 0x124F754
	int Compare(object a, object b) { }

	// RVA: 0x124F850
	void .cctor() { }

}

// Namespace: System
internal static class IriHelper 
{
	// Methods

	// RVA: 0x124F8B8
	bool CheckIriUnicodeRange(Char unicode, bool isQuery) { }

	// RVA: 0x124F910
	bool CheckIriUnicodeRange(Char highSurr, Char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x124FF8C
	bool CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0x12500FC
	string EscapeUnescapeIri(Char* pInput, int start, int end, UriComponents component) { }

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

	// RVA: 0x125157C
	void .ctor() { }

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

	// RVA: 0x1251584
	void .ctor() { }

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

	// RVA: 0x11D9D14
	bool get_IsImplicitFile() { }

	// RVA: 0x11D9D20
	bool get_IsUncOrDosPath() { }

	// RVA: 0x11D9D30
	bool get_IsDosPath() { }

	// RVA: 0x11D9D3C
	bool get_IsUncPath() { }

	// RVA: 0x11D9D48
	Flags get_HostType() { }

	// RVA: 0x11D9D54
	UriParser get_Syntax() { }

	// RVA: 0x11D9D5C
	bool get_IsNotAbsoluteUri() { }

	// RVA: 0x11D9D6C
	bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x11D9E34
	bool get_AllowIdn() { }

	// RVA: 0x11D9F50
	bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0x11DA08C
	bool IsIntranet(string schemeHost) { }

	// RVA: 0x11DA094
	bool get_UserDrivenParsing() { }

	// RVA: 0x11DA0A0
	void SetUserDrivenParsing() { }

	// RVA: 0x11DA0B4
	UInt16 get_SecuredPathIndex() { }

	// RVA: 0x11D9F40
	bool NotAny(Flags flags) { }

	// RVA: 0x11DA114
	bool InFact(Flags flags) { }

	// RVA: 0x11DA080
	bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x11DA124
	bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x11DA130
	UriInfo EnsureUriInfo() { }

	// RVA: 0x11DA770
	void EnsureParseRemaining() { }

	// RVA: 0x11DB620
	void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x11DBAA8
	void .ctor(string uriString) { }

	// RVA: 0x11DBD00
	void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x11DBD90
	void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x11DBE80
	void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x11DC794
	void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x11DC9E0
	ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x11DD99C
	UriFormatException GetException(ParsingError err) { }

	// RVA: 0x11DDB38
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11DDC58
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11DDC5C
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11DDDB8
	string get_AbsolutePath() { }

	// RVA: 0x11DDE78
	string get_PrivateAbsolutePath() { }

	// RVA: 0x11DDF74
	string get_AbsoluteUri() { }

	// RVA: 0x11DE0B0
	string get_LocalPath() { }

	// RVA: 0x11DE8C0
	string get_Authority() { }

	// RVA: 0x11DE938
	UriHostNameType get_HostNameType() { }

	// RVA: 0x11DEA88
	bool get_IsDefaultPort() { }

	// RVA: 0x11DEB64
	bool get_IsFile() { }

	// RVA: 0x11DEC28
	bool get_IsLoopback() { }

	// RVA: 0x11DECE4
	string get_PathAndQuery() { }

	// RVA: 0x11DEDAC
	string[] get_Segments() { }

	// RVA: 0x11DF000
	bool get_IsUnc() { }

	// RVA: 0x11DF078
	string get_Host() { }

	// RVA: 0x11DF0F0
	bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x11DF10C
	object get_InitializeLock() { }

	// RVA: 0x11DF210
	void InitializeUriConfig() { }

	// RVA: 0x11DE120
	string GetLocalPath() { }

	// RVA: 0x11DF9CC
	int get_Port() { }

	// RVA: 0x11DFAC4
	string get_Query() { }

	// RVA: 0x11DFC04
	string get_Fragment() { }

	// RVA: 0x11DFD44
	string get_Scheme() { }

	// RVA: 0x11DFDB8
	bool get_OriginalStringSwitched() { }

	// RVA: 0x11DCDAC
	string get_OriginalString() { }

	// RVA: 0x11DFE14
	string get_DnsSafeHost() { }

	// RVA: 0x11DBE70
	bool get_IsAbsoluteUri() { }

	// RVA: 0x11E008C
	bool get_UserEscaped() { }

	// RVA: 0x11E0098
	string get_UserInfo() { }

	// RVA: 0x11E0110
	bool IsGenDelim(Char ch) { }

	// RVA: 0x11E0134
	bool IsHexDigit(Char character) { }

	// RVA: 0x11E0160
	int FromHex(Char digit) { }

	// RVA: 0x11E01F4
	int GetHashCode() { }

	// RVA: 0x11E04A0
	string ToString() { }

	// RVA: 0x11E081C
	bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x11DC5D8
	bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x11E0850
	bool Equals(object comparand) { }

	// RVA: 0x11E0FB8
	bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x11E107C
	string InternalEscapeString(string rawString) { }

	// RVA: 0x11E116C
	ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) { }

	// RVA: 0x11E1874
	UriFormatException ParseMinimal() { }

	// RVA: 0x11E1908
	ParsingError PrivateParseMinimal() { }

	// RVA: 0x11E2F7C
	void PrivateParseMinimalIri(string newHost, UInt16 idx) { }

	// RVA: 0x11DA160
	void CreateUriInfo(Flags cF) { }

	// RVA: 0x11DB680
	void CreateHostString() { }

	// RVA: 0x11E34C0
	string CreateHostStringHelper(string str, UInt16 idx, UInt16 end, ref Flags flags, ref string scopeId) { }

	// RVA: 0x11E3074
	void GetHostViaCustomSyntax() { }

	// RVA: 0x11DDDB4
	string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x11E3C8C
	string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x11DF8E0
	string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x11E4434
	string ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0x11E3D7C
	string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x11DA780
	void ParseRemaining() { }

	// RVA: 0x11E127C
	UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	// RVA: 0x11E59E0
	bool CheckKnownSchemes(Int64* lptr, UInt16 nChars, ref UriParser syntax) { }

	// RVA: 0x11DCC50
	ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, ref UriParser syntax) { }

	// RVA: 0x11E1FFC
	UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x11E5F34
	void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x11E63A8
	void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x11E5878
	void FindEndOfComponent(string input, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x11E68B0
	void FindEndOfComponent(Char* str, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x11E36A4
	Check CheckCanonical(Char* str, ref UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x11E50E0
	Char[] GetCanonicalPath(Char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x11E695C
	void UnescapeOnly(Char* pch, int start, ref int end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0x11DF3E4
	Char[] Compress(Char[] dest, UInt16 start, ref int destLength, UriParser syntax) { }

	// RVA: 0x11E03C4
	int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x11DCE10
	string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x11E6B64
	bool get_HasAuthority() { }

	// RVA: 0x11E1FCC
	bool IsLWS(Char ch) { }

	// RVA: 0x11E1FE8
	bool IsAsciiLetter(Char character) { }

	// RVA: 0x11E6B70
	bool IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0x11E6BE4
	bool IsBidiControlCharacter(Char ch) { }

	// RVA: 0x11E66C0
	string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	// RVA: 0x11DBB2C
	void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x11E6C08
	void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x11E72F8
	bool CheckForConfigLoad(string data) { }

	// RVA: 0x11E73E8
	bool CheckForUnicode(string data) { }

	// RVA: 0x11E7524
	bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x11E0EBC
	bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x11E79F4
	bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x11E7B30
	bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x11E3AB0
	string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x11E7F80
	bool IsWellFormedOriginalString() { }

	// RVA: 0x11E8488
	bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x11E7FD4
	bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x11E858C
	string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x11E8750
	string EscapeDataString(string stringToEscape) { }

	// RVA: 0x11E5988
	string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x11E888C
	void .ctor(Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x11E7734
	Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x11DC038
	Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x11E7D14
	string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x11E05A0
	string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x11E88E4
	bool IsBaseOf(Uri uri) { }

	// RVA: 0x11E899C
	bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x11DC620
	void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x11E8BA0
	void .cctor() { }

}

// Namespace: System
public class UriFormatException 
{
	// Methods

	// RVA: 0x125158C
	void .ctor() { }

	// RVA: 0x124EF14
	void .ctor(string textString) { }

	// RVA: 0x1251594
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x125159C
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

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

	// RVA: 0x12515A4
	bool TestForSubPath(Char* pMe, UInt16 meLength, Char* pShe, UInt16 sheLength, bool ignoreCase) { }

	// RVA: 0x1251820
	Char[] EscapeString(string input, int start, int end, Char[] dest, ref int destPos, bool isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0x1251F34
	Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x1252400
	Char[] UnescapeString(string input, int start, int end, Char[] dest, ref int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x12524D8
	Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, ref int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1250C3C
	void MatchUTF8Sequence(Char* pDest, Char[] dest, ref int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x125146C
	void EscapeAsciiChar(Char ch, Char[] to, ref int pos) { }

	// RVA: 0x1250B60
	Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0x1250BC8
	bool IsNotSafeForUnescape(Char ch) { }

	// RVA: 0x1252264
	bool IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0x12520EC
	bool IsUnreserved(Char c) { }

	// RVA: 0x125302C
	bool Is3986Unreserved(Char c) { }

	// RVA: 0x12530FC
	void .cctor() { }

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

	// RVA: 0x1253F74
	void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

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

	// RVA: 0x12531A0
	string get_SchemeName() { }

	// RVA: 0x12531A8
	int get_DefaultPort() { }

	// RVA: 0x12531B0
	UriParser OnNewUri() { }

	// RVA: 0x12531B4
	void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x12531F0
	string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x1253414
	bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x1253434
	string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x1253658
	bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x1252FC8
	bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x1253674
	void .cctor() { }

	// RVA: 0x1254070
	UriSyntaxFlags get_Flags() { }

	// RVA: 0x124F098
	bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x124F02C
	bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x12540D8
	bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x1254078
	bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x1254144
	void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x12541B8
	UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x124EF1C
	UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x12544C8
	bool get_IsSimple() { }

	// RVA: 0x12544D4
	UriParser InternalOnNewUri() { }

	// RVA: 0x1254540
	void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x125454C
	string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x1254558
	bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x1254564
	string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x1254570
	bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: System
internal class DomainNameHelper 
{
	// Methods

	// RVA: 0x125457C
	string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x125471C
	bool IsValid(Char* name, UInt16 pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1254944
	bool IsValidByIri(Char* name, UInt16 pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1254B3C
	string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x1254EB4
	string IdnEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x125511C
	bool IsIdnAce(string input, int index) { }

	// RVA: 0x12550D0
	bool IsIdnAce(Char* input, int index) { }

	// RVA: 0x12551B0
	string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	// RVA: 0x12552EC
	string UnicodeEquivalent(Char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x12548BC
	bool IsASCIILetterOrDigit(Char character, ref bool notCanonical) { }

	// RVA: 0x12548F8
	bool IsValidDomainLabelCharacter(Char character, ref bool notCanonical) { }

}

// Namespace: System
internal class UncNameHelper 
{
	// Methods

	// RVA: 0x1255878
	string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x1255880
	bool IsValid(Char* name, UInt16 start, ref int returnedEnd, bool notImplicitFile) { }

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

	// RVA: 0x1255CC0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1255DE0
	internal void Invoke(IOAsyncResult ioares) { }

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

	// RVA: 0x1255DF4
	void .ctor() { }

	// RVA: 0x1255DFC
	void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x1255E50
	void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x1255EA0
	AsyncCallback get_AsyncCallback() { }

	// RVA: 0x1255EA8
	object get_AsyncState() { }

	// RVA: 0x1255EB0
	WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1256000
	bool get_CompletedSynchronously() { }

	// RVA: 0x1256008
	void set_CompletedSynchronously(bool value) { }

	// RVA: 0x1256010
	bool get_IsCompleted() { }

	// RVA: 0x1256018
	void set_IsCompleted(bool value) { }

	// RVA: 0x2FE41A8
	void CompleteDisposed() { }

}

// Namespace: System
internal class IOSelectorJob 
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x12560F4
	void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x125614C
	void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1256178
	void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x125617C
	void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector 
{
	// Methods

	// RVA: 0x12561A0
	void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal class SRDescriptionAttribute 
{
	// Fields
	private bool isReplaced; // 0x18

	// Methods

	// RVA: 0x12561A4
	void .ctor(string description) { }

	// RVA: 0x1256210
	string get_Description() { }

}

// Namespace: System
public class UriTypeConverter 
{
	// Methods

	// RVA: 0x1256270
	void .ctor() { }

	// RVA: 0x1256278
	bool CanConvert(Type type) { }

	// RVA: 0x1256360
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x125643C
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12564E4
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x125669C
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Web
public sealed class HttpUtility 
{
	// Methods

	// RVA: 0x1256898
	string UrlEncode(string str) { }

	// RVA: 0x12568C4
	string UrlEncode(string str, Encoding e) { }

	// RVA: 0x1256B24
	Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Web.Util.HttpEncoder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x12574E0
	void .cctor() { }

	// RVA: 0x125754C
	void .ctor() { }

	// RVA: 0x1257554
	HttpEncoder <.cctor>b__13_0() { }

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

	// RVA: 0x1256BC0
	HttpEncoder get_Current() { }

	// RVA: 0x1256CD0
	void .cctor() { }

	// RVA: 0x1256EC8
	void .ctor() { }

	// RVA: 0x1256ED0
	Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	// RVA: 0x1257158
	HttpEncoder GetCustomEncoderFromConfig() { }

	// RVA: 0x1256F48
	Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	// RVA: 0x1256B04
	bool NotEncoded(Char c) { }

	// RVA: 0x1257200
	void UrlEncodeChar(Char c, Stream result, bool isUnicode) { }

}

// Namespace: System.Text.RegularExpressions
public class Capture 
{
	// Fields
	private int <Index>k__BackingField; // 0x10
	private int <Length>k__BackingField; // 0x14
	private string <Text>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12575AC
	void .ctor(string text, int index, int length) { }

	// RVA: 0x12575F8
	int get_Index() { }

	// RVA: 0x1257600
	void set_Index(int value) { }

	// RVA: 0x1257608
	int get_Length() { }

	// RVA: 0x1257610
	void set_Length(int value) { }

	// RVA: 0x1257618
	string get_Text() { }

	// RVA: 0x1257620
	void set_Text(string value) { }

	// RVA: 0x1257628
	string get_Value() { }

	// RVA: 0x1257650
	string ToString() { }

	// RVA: 0x1257678
	System.ReadOnlySpan<System.Char> GetLeftSubstring() { }

	// RVA: 0x125771C
	System.ReadOnlySpan<System.Char> GetRightSubstring() { }

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
public class Group 
{
	// Fields
	internal static readonly Group s_emptyGroup; // 0x0
	internal readonly int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	private readonly string <Name>k__BackingField; // 0x38

	// Methods

	// RVA: 0x12577C0
	void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x125788C
	bool get_Success() { }

	// RVA: 0x125789C
	void .cctor() { }

	// RVA: 0x1257A1C
	void .ctor() { }

}

// Namespace: 
private sealed class Enumerator 
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x1257EAC
	void .ctor(GroupCollection collection) { }

	// RVA: 0x1258D70
	bool MoveNext() { }

	// RVA: 0x1258DC8
	Group get_Current() { }

	// RVA: 0x1258E58
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1258E5C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1258E68
	void System.IDisposable.Dispose() { }

}

// Namespace: System.Text.RegularExpressions
public class GroupCollection 
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Methods

	// RVA: 0x1257A58
	void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x1257AA8
	bool get_IsReadOnly() { }

	// RVA: 0x1257AB0
	int get_Count() { }

	// RVA: 0x1257AD8
	Group get_Item(int groupnum) { }

	// RVA: 0x1257C0C
	Group get_Item(string groupname) { }

	// RVA: 0x1257E30
	IEnumerator GetEnumerator() { }

	// RVA: 0x1257EEC
	System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x1257ADC
	Group GetGroup(int groupnum) { }

	// RVA: 0x1257F68
	Group GetGroupImpl(int groupnum) { }

	// RVA: 0x12582E4
	bool get_IsSynchronized() { }

	// RVA: 0x12582EC
	object get_SyncRoot() { }

	// RVA: 0x12582F4
	void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x12583C8
	void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x1258590
	int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x1258674
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x12586C8
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x125871C
	Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x1258720
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x1258774
	void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x12587C8
	void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x125881C
	bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x12588D4
	bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x1258928
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x125897C
	void System.Collections.IList.Clear() { }

	// RVA: 0x12589D0
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1258AD4
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1258BD8
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1258C2C
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1258C34
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1258C88
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1258CDC
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1258CE0
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1258D34
	void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
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

	// RVA: 0x1258E6C
	void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1259020
	Match get_Empty() { }

	// RVA: 0x125909C
	void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x1259124
	GroupCollection get_Groups() { }

	// RVA: 0x12591E0
	Match NextMatch() { }

	// RVA: 0x1259514
	System.ReadOnlySpan<System.Char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x12596CC
	System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }

	// RVA: 0x12596F8
	void AddMatch(int cap, int start, int len) { }

	// RVA: 0x12598F8
	void BalanceMatch(int cap) { }

	// RVA: 0x12599D8
	void RemoveMatch(int cap) { }

	// RVA: 0x1259A14
	bool IsMatched(int cap) { }

	// RVA: 0x1259AAC
	int MatchIndex(int cap) { }

	// RVA: 0x1259B44
	int MatchLength(int cap) { }

	// RVA: 0x1259BDC
	void Tidy(int textpos) { }

	// RVA: 0x1259D58
	void .cctor() { }

	// RVA: 0x1259E00
	void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse 
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Methods

	// RVA: 0x1259E3C
	void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1259EF8
	GroupCollection get_Groups() { }

}

// Namespace: 
private sealed class Enumerator 
{
	// Fields
	private readonly MatchCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x125A3D8
	void .ctor(MatchCollection collection) { }

	// RVA: 0x125AD7C
	bool MoveNext() { }

	// RVA: 0x125ADE8
	Match get_Current() { }

	// RVA: 0x125AE5C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x125AE60
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x125AE6C
	void System.IDisposable.Dispose() { }

}

// Namespace: System.Text.RegularExpressions
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

	// RVA: 0x1259FB8
	void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x125A110
	bool get_IsReadOnly() { }

	// RVA: 0x125A118
	int get_Count() { }

	// RVA: 0x125A19C
	Match get_Item(int i) { }

	// RVA: 0x125A35C
	IEnumerator GetEnumerator() { }

	// RVA: 0x125A418
	System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x125A208
	Match GetMatch(int i) { }

	// RVA: 0x125A188
	void EnsureInitialized() { }

	// RVA: 0x125A494
	bool get_IsSynchronized() { }

	// RVA: 0x125A49C
	object get_SyncRoot() { }

	// RVA: 0x125A4A0
	void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x125A580
	void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x125A610
	int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x125A698
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x125A6EC
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x125A740
	Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x125A750
	void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x125A7A4
	void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x125A7F8
	void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x125A84C
	bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x125A8D4
	bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x125A928
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x125A97C
	void System.Collections.IList.Clear() { }

	// RVA: 0x125A9D0
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x125AAD4
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x125ABD8
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x125AC2C
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x125AC34
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x125AC88
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x125ACDC
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x125ACEC
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x125AD40
	void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class ExclusiveReference 
{
	// Fields
	private RegexRunner _ref; // 0x10
	private RegexRunner _obj; // 0x18
	private int _locked; // 0x20

	// Methods

	// RVA: 0x125AE70
	RegexRunner Get() { }

	// RVA: 0x125AF00
	void Release(RegexRunner obj) { }

	// RVA: 0x125B010
	void .ctor() { }

}

// Namespace: 
internal struct CachedCodeEntryKey 
{
	// Fields
	private readonly RegexOptions _options; // 0x10
	private readonly string _cultureKey; // 0x18
	private readonly string _pattern; // 0x20

	// Methods

	// RVA: 0x125D9E8
	void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x125DDBC
	bool Equals(object obj) { }

	// RVA: 0x125DE7C
	bool Equals(CachedCodeEntryKey other) { }

	// RVA: 0x125B16C
	bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	// RVA: 0x125DEE8
	int GetHashCode() { }

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

	// RVA: 0x125B9C0
	void .ctor(CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref) { }

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
	private const string DefaultMatchTimeout_ConfigKeyName = 5708594080;
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

	// RVA: 0x125B018
	CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x125B1E0
	CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x125BAA0
	void FillCacheDictionary() { }

	// RVA: 0x125BBB8
	bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	// RVA: 0x125BCF0
	bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	// RVA: 0x125B748
	CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	// RVA: 0x125BF50
	bool IsMatch(string input, string pattern) { }

	// RVA: 0x125C034
	bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x125C42C
	bool IsMatch(string input) { }

	// RVA: 0x125C4B8
	bool IsMatch(string input, int startat) { }

	// RVA: 0x125C540
	Match Match(string input) { }

	// RVA: 0x125C5C0
	Match Match(string input, int startat) { }

	// RVA: 0x125C63C
	MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x125C720
	MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x125C7B0
	MatchCollection Matches(string input) { }

	// RVA: 0x125C830
	MatchCollection Matches(string input, int startat) { }

	// RVA: 0x125C904
	string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x125C9FC
	string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x125CA9C
	string Replace(string input, string replacement) { }

	// RVA: 0x125CB24
	string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x125CC00
	string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x125CCEC
	string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x125CD8C
	string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x125CE14
	string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x125CEE8
	string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x125D338
	void .cctor() { }

	// RVA: 0x125D6E8
	void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x125D488
	TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x125D8A4
	void .ctor(string pattern) { }

	// RVA: 0x125D920
	void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x125D9A8
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x125C0C4
	void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x125DC94
	string Escape(string str) { }

	// RVA: 0x125DD50
	RegexOptions get_Options() { }

	// RVA: 0x125D32C
	bool get_RightToLeft() { }

	// RVA: 0x125DD58
	string ToString() { }

	// RVA: 0x1258180
	string GroupNameFromNumber(int i) { }

	// RVA: 0x1257CC4
	int GroupNumberFromName(string name) { }

	// RVA: 0x125DB80
	void InitializeReferences() { }

	// RVA: 0x1259210
	Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x125C4AC
	bool UseOptionR() { }

	// RVA: 0x125DD60
	bool UseOptionInvariant() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator 
{
	// Methods

	// RVA: 0x125DF48
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x125E068
	internal string Invoke(Match match) { }

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

	// RVA: 0x125E07C
	void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x125E688
	bool MatchPattern(string text, int index) { }

	// RVA: 0x125E800
	bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x125E870
	int Scan(string text, int index, int beglimit, int endlimit) { }

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

	// RVA: 0x1266920
	void .ctor(Char chMin, Char chMax, int lcOp, int data) { }

}

// Namespace: 
private sealed class SingleRangeComparer 
{
	// Fields
	public static readonly SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x1266930
	void .ctor() { }

	// RVA: 0x1266938
	int Compare(SingleRange x, SingleRange y) { }

	// RVA: 0x12669B0
	void .cctor() { }

}

// Namespace: 
private struct SingleRange 
{
	// Fields
	public readonly Char First; // 0x10
	public readonly Char Last; // 0x12

	// Methods

	// RVA: 0x125F2D4
	void .ctor(Char first, Char last) { }

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

	// RVA: 0x125EB6C
	void .ctor() { }

	// RVA: 0x125EC44
	void .ctor(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x125ECC0
	bool get_CanMerge() { }

	// RVA: 0x125ECE0
	void set_Negate(bool value) { }

	// RVA: 0x125ECE8
	void AddChar(Char c) { }

	// RVA: 0x125EDC4
	void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x125F0C8
	void AddSet(string set) { }

	// RVA: 0x125F2E0
	void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x125ECF0
	void AddRange(Char first, Char last) { }

	// RVA: 0x125F2E8
	void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x125F850
	void AddCategory(string category) { }

	// RVA: 0x125F870
	void AddLowercase(CultureInfo culture) { }

	// RVA: 0x125FA00
	void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0x125FCB0
	void AddWord(bool ecma, bool negate) { }

	// RVA: 0x125FDD4
	void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x125FEF8
	void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x125FFBC
	Char SingletonChar(string set) { }

	// RVA: 0x125FFD8
	bool IsMergeable(string charClass) { }

	// RVA: 0x1260144
	bool IsEmpty(string charClass) { }

	// RVA: 0x126024C
	bool IsSingleton(string set) { }

	// RVA: 0x126038C
	bool IsSingletonInverse(string set) { }

	// RVA: 0x12600E4
	bool IsSubtraction(string charClass) { }

	// RVA: 0x12600BC
	bool IsNegated(string set) { }

	// RVA: 0x12604D0
	bool IsECMAWordChar(Char ch) { }

	// RVA: 0x1260620
	bool IsWordChar(Char ch) { }

	// RVA: 0x12605B4
	bool CharInClass(Char ch, string set) { }

	// RVA: 0x12606FC
	bool CharInClassRecursive(Char ch, string set, int start) { }

	// RVA: 0x1260830
	bool CharInClassInternal(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1260958
	bool CharInCategory(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1260B88
	bool CharInCategoryGroup(Char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x125F52C
	string NegateCategory(string category) { }

	// RVA: 0x1260C54
	RegexCharClass Parse(string charClass) { }

	// RVA: 0x1260CDC
	RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x125F004
	int RangeCount() { }

	// RVA: 0x1260F50
	string ToStringClass() { }

	// RVA: 0x125F050
	SingleRange GetRangeAt(int i) { }

	// RVA: 0x1261124
	void Canonicalize() { }

	// RVA: 0x125F5D8
	string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x12613A0
	void .cctor() { }

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

	// RVA: 0x1266A1C
	void .ctor(int[] codes, System.Collections.Generic.List<System.String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x1266B30
	bool OpcodeBacktracks(int Op) { }

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

	// RVA: 0x1266B54
	void .ctor(System.Span<System.Int32> intStack) { }

	// RVA: 0x1266C34
	System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x1267210
	RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x1267484
	int Anchors(RegexTree tree) { }

	// RVA: 0x1267650
	int AnchorFromType(int type) { }

	// RVA: 0x12676B8
	void PushInt(int i) { }

	// RVA: 0x1267724
	bool IntIsEmpty() { }

	// RVA: 0x126776C
	int PopInt() { }

	// RVA: 0x1267894
	void PushFC(RegexFC fc) { }

	// RVA: 0x12678F8
	bool FCIsEmpty() { }

	// RVA: 0x126794C
	RegexFC PopFC() { }

	// RVA: 0x1267A30
	RegexFC TopFC() { }

	// RVA: 0x1267180
	void Dispose() { }

	// RVA: 0x1266F84
	RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x1268084
	void SkipChild() { }

	// RVA: 0x1267AAC
	void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC 
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Methods

	// RVA: 0x1268090
	void .ctor(bool nullable) { }

	// RVA: 0x12681D4
	void .ctor(Char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x12682D4
	void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x1268110
	bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x12683D8
	bool get_CaseInsensitive() { }

	// RVA: 0x12683E0
	void set_CaseInsensitive(bool value) { }

	// RVA: 0x12671D4
	string GetFirstChars(CultureInfo culture) { }

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

	// RVA: 0x125DD6C
	void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x12683E8
	void InitTrackCount() { }

	// RVA: 0x126840C
	void Advance(int i) { }

	// RVA: 0x1268494
	void Goto(int newpos) { }

	// RVA: 0x1268514
	void Textto(int newpos) { }

	// RVA: 0x126851C
	void Trackto(int newpos) { }

	// RVA: 0x1268544
	int Textstart() { }

	// RVA: 0x126854C
	int Textpos() { }

	// RVA: 0x1268554
	int Trackpos() { }

	// RVA: 0x126857C
	void TrackPush() { }

	// RVA: 0x12685C0
	void TrackPush(int I1) { }

	// RVA: 0x1268620
	void TrackPush(int I1, int I2) { }

	// RVA: 0x126869C
	void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x1268734
	void TrackPush2(int I1) { }

	// RVA: 0x1268798
	void TrackPush2(int I1, int I2) { }

	// RVA: 0x1268818
	void Backtrack() { }

	// RVA: 0x1268474
	void SetOperator(int op) { }

	// RVA: 0x1268920
	void TrackPop() { }

	// RVA: 0x1268930
	void TrackPop(int framesize) { }

	// RVA: 0x1268940
	int TrackPeek() { }

	// RVA: 0x126897C
	int TrackPeek(int i) { }

	// RVA: 0x12689BC
	void StackPush(int I1) { }

	// RVA: 0x12689FC
	void StackPush(int I1, int I2) { }

	// RVA: 0x1268A58
	void StackPop() { }

	// RVA: 0x1268A68
	void StackPop(int framesize) { }

	// RVA: 0x1268A78
	int StackPeek() { }

	// RVA: 0x1268AB4
	int StackPeek(int i) { }

	// RVA: 0x1268AF4
	int Operator() { }

	// RVA: 0x1268AFC
	int Operand(int i) { }

	// RVA: 0x1268B44
	int Leftchars() { }

	// RVA: 0x1268B54
	int Rightchars() { }

	// RVA: 0x1268B64
	int Bump() { }

	// RVA: 0x1268B78
	int Forwardchars() { }

	// RVA: 0x1268BA4
	Char Forwardcharnext() { }

	// RVA: 0x1268C38
	bool Stringmatch(string str) { }

	// RVA: 0x1268DAC
	bool Refmatch(int index, int len) { }

	// RVA: 0x1268F54
	void Backwardnext() { }

	// RVA: 0x1268F84
	Char CharAt(int j) { }

	// RVA: 0x1268FA4
	bool FindFirstChar() { }

	// RVA: 0x1269548
	void Go() { }

}

// Namespace: System.Text.RegularExpressions
public class RegexMatchTimeoutException 
{
	// Fields
	private readonly string <Input>k__BackingField; // 0x90
	private readonly string <Pattern>k__BackingField; // 0x98
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Methods

	// RVA: 0x126B950
	void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x126BA6C
	void .ctor() { }

	// RVA: 0x126BB24
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x126BCA8
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x126BDB0
	string get_Input() { }

	// RVA: 0x126BDB8
	string get_Pattern() { }

	// RVA: 0x126BDC0
	TimeSpan get_MatchTimeout() { }

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

	// RVA: 0x126BDC8
	void .ctor(int type, RegexOptions options) { }

	// RVA: 0x126BE04
	void .ctor(int type, RegexOptions options, Char ch) { }

	// RVA: 0x126BE48
	void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x126BE94
	void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x126BED8
	void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x126BF28
	bool UseOptionR() { }

	// RVA: 0x126BF34
	RegexNode ReverseLeft() { }

	// RVA: 0x126BFB4
	void MakeRep(int type, int min, int max) { }

	// RVA: 0x126BFCC
	RegexNode Reduce() { }

	// RVA: 0x126CD0C
	RegexNode StripEnation(int emptyType) { }

	// RVA: 0x126CAD4
	RegexNode ReduceGroup() { }

	// RVA: 0x126C908
	RegexNode ReduceRep() { }

	// RVA: 0x126CB5C
	RegexNode ReduceSet() { }

	// RVA: 0x126C0C8
	RegexNode ReduceAlternation() { }

	// RVA: 0x126C50C
	RegexNode ReduceConcatenation() { }

	// RVA: 0x126CF08
	RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x126D064
	void AddChild(RegexNode newChild) { }

	// RVA: 0x126CE90
	RegexNode Child(int i) { }

	// RVA: 0x126CE38
	int ChildCount() { }

	// RVA: 0x126D15C
	int Type() { }

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

	// RVA: 0x126D164
	RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x126E81C
	RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x126EF88
	string Escape(string input) { }

	// RVA: 0x126D3C4
	void .ctor(CultureInfo culture) { }

	// RVA: 0x126D4A4
	void SetPattern(string Re) { }

	// RVA: 0x126D920
	void Reset(RegexOptions topopts) { }

	// RVA: 0x126D9C0
	RegexNode ScanRegex() { }

	// RVA: 0x126E9E4
	RegexNode ScanReplacement() { }

	// RVA: 0x126FE68
	RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x1270594
	RegexNode ScanGroupOpen() { }

	// RVA: 0x126F3B0
	void ScanBlank() { }

	// RVA: 0x12715DC
	RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x1272E2C
	RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x1271EFC
	RegexNode ScanDollar() { }

	// RVA: 0x1272904
	string ScanCapname() { }

	// RVA: 0x127355C
	Char ScanOctal() { }

	// RVA: 0x1271DDC
	int ScanDecimal() { }

	// RVA: 0x127366C
	Char ScanHex(int c) { }

	// RVA: 0x12737C4
	int HexDigit(Char ch) { }

	// RVA: 0x12737F4
	Char ScanControl() { }

	// RVA: 0x12738A8
	bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x1272B90
	void ScanOptions() { }

	// RVA: 0x12725BC
	Char ScanCharEscape() { }

	// RVA: 0x127242C
	string ParseProperty() { }

	// RVA: 0x1272D9C
	int TypeFromCode(Char ch) { }

	// RVA: 0x12738C8
	RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0x126D518
	void CountCaptures() { }

	// RVA: 0x1273928
	void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x1273A84
	void NoteCaptureName(string name, int pos) { }

	// RVA: 0x126E9A0
	void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x1273BF8
	void AssignNameSlots() { }

	// RVA: 0x1272AF8
	int CaptureSlotFromName(string capname) { }

	// RVA: 0x1272A18
	bool IsCaptureSlot(int i) { }

	// RVA: 0x1272ADC
	bool IsCaptureName(string capname) { }

	// RVA: 0x1272A0C
	bool UseOptionN() { }

	// RVA: 0x126FE5C
	bool UseOptionI() { }

	// RVA: 0x1271C10
	bool UseOptionM() { }

	// RVA: 0x1271C98
	bool UseOptionS() { }

	// RVA: 0x126F71C
	bool UseOptionX() { }

	// RVA: 0x1272420
	bool UseOptionE() { }

	// RVA: 0x126F9F8
	bool IsSpecial(Char ch) { }

	// RVA: 0x126F788
	bool IsStopperX(Char ch) { }

	// RVA: 0x126FA98
	bool IsQuantifier(Char ch) { }

	// RVA: 0x126F828
	bool IsTrueQuantifier() { }

	// RVA: 0x1272CFC
	bool IsSpace(Char ch) { }

	// RVA: 0x126F24C
	bool IsMetachar(Char ch) { }

	// RVA: 0x126FB38
	void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x1270F50
	void PushGroup() { }

	// RVA: 0x12713F4
	void PopGroup() { }

	// RVA: 0x1271144
	bool EmptyStack() { }

	// RVA: 0x126F2EC
	void StartGroup(RegexNode openGroup) { }

	// RVA: 0x1270FBC
	void AddAlternate() { }

	// RVA: 0x1271D70
	void AddConcatenate() { }

	// RVA: 0x1271EB0
	void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x12742E4
	RegexNode Unit() { }

	// RVA: 0x126FDA0
	void AddUnitOne(Char ch) { }

	// RVA: 0x1271CA4
	void AddUnitNotone(Char ch) { }

	// RVA: 0x1270498
	void AddUnitSet(string cc) { }

	// RVA: 0x12742EC
	void AddUnitNode(RegexNode node) { }

	// RVA: 0x1271C1C
	void AddUnitType(int type) { }

	// RVA: 0x12711F4
	void AddGroup() { }

	// RVA: 0x1270528
	void PushOptions() { }

	// RVA: 0x1271530
	void PopOptions() { }

	// RVA: 0x1273A30
	bool EmptyOptionsStack() { }

	// RVA: 0x1270EE8
	void PopKeepOptions() { }

	// RVA: 0x1271154
	ArgumentException MakeException(string message) { }

	// RVA: 0x12742F4
	int Textpos() { }

	// RVA: 0x12742FC
	void Textto(int pos) { }

	// RVA: 0x1271DAC
	Char RightCharMoveRight() { }

	// RVA: 0x126F728
	void MoveRight() { }

	// RVA: 0x12729FC
	void MoveRight(int i) { }

	// RVA: 0x1271D60
	void MoveLeft() { }

	// RVA: 0x126FD80
	Char CharAt(int i) { }

	// RVA: 0x126F760
	Char RightChar() { }

	// RVA: 0x12729D0
	Char RightChar(int i) { }

	// RVA: 0x126F738
	int CharsRight() { }

	// RVA: 0x1274304
	void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
internal struct RegexPrefix 
{
	// Fields
	private readonly bool <CaseInsensitive>k__BackingField; // 0x10
	private static readonly RegexPrefix <Empty>k__BackingField; // 0x0
	private readonly string <Prefix>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12743A8
	void .ctor(string prefix, bool ci) { }

	// RVA: 0x12743D4
	bool get_CaseInsensitive() { }

	// RVA: 0x12743DC
	RegexPrefix get_Empty() { }

	// RVA: 0x1274458
	string get_Prefix() { }

	// RVA: 0x1274460
	void .cctor() { }

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

	// RVA: 0x126EB74
	void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x1274508
	RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	// RVA: 0x1274628
	string get_Pattern() { }

	// RVA: 0x1274630
	void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x12747EC
	void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, Match match) { }

	// RVA: 0x1274A04
	string Replace(Regex regex, string input, int count, int startat) { }

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

	// RVA: 0x1274DC4
	void .ctor() { }

	// RVA: 0x1274DCC
	Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x12751C4
	void StartTimeoutWatch() { }

	// RVA: 0x1275210
	void CheckTimeout() { }

	// RVA: 0x12754C8
	void DoCheckTimeout() { }

	// RVA: 0x2FE41A8
	void Go() { }

	// RVA: 0x2FE3054
	bool FindFirstChar() { }

	// RVA: 0x2FE41A8
	void InitTrackCount() { }

	// RVA: 0x1275220
	void InitMatch() { }

	// RVA: 0x1275460
	Match TidyMatch(bool quick) { }

	// RVA: 0x12755A4
	void EnsureStorage() { }

	// RVA: 0x1275768
	bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x127586C
	bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12756B4
	void DoubleTrack() { }

	// RVA: 0x1275600
	void DoubleStack() { }

	// RVA: 0x1275970
	void DoubleCrawl() { }

	// RVA: 0x1275A24
	void Crawl(int i) { }

	// RVA: 0x1275A84
	int Popcrawl() { }

	// RVA: 0x1275AC4
	int Crawlpos() { }

	// RVA: 0x1275AEC
	void Capture(int capnum, int start, int end) { }

	// RVA: 0x1275B80
	void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x1275D30
	void Uncapture() { }

	// RVA: 0x1275D80
	bool IsMatched(int cap) { }

	// RVA: 0x1275CE8
	int MatchIndex(int cap) { }

	// RVA: 0x1275D0C
	int MatchLength(int cap) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory 
{
	// Methods

	// RVA: 0x2FE360C
	RegexRunner CreateInstance() { }

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

	// RVA: 0x126E76C
	void .ctor(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }

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

	// RVA: 0x1275DA4
	void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }

	// RVA: 0x1275EEC
	RegexCode Write(RegexTree tree) { }

	// RVA: 0x12767AC
	void Dispose() { }

	// RVA: 0x12761A0
	RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x12773AC
	void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x127741C
	void Emit(int op) { }

	// RVA: 0x127680C
	void Emit(int op, int opd1) { }

	// RVA: 0x12774A4
	void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x1277564
	int StringCode(string str) { }

	// RVA: 0x1277690
	int MapCapnum(int capnum) { }

	// RVA: 0x12768AC
	void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute 
{
	// Fields
	private readonly string tool; // 0x10
	private readonly string version; // 0x18

	// Methods

	// RVA: 0x1277750
	void .ctor(string tool, string version) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch 
{
	// Methods

	// RVA: 0x12777A0
	void .ctor(string displayName, string description) { }

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

	// RVA: 0x1277868
	void .ctor(string displayName, string description) { }

	// RVA: 0x12778D4
	void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1277B0C
	void _pruneCachedSwitches() { }

	// RVA: 0x1277FF8
	void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute 
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x1278094
	void .ctor(Type switchLevelType) { }

	// RVA: 0x12780C4
	void set_SwitchLevelType(Type value) { }

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

	// RVA: 0x12781AC
	void .ctor(string displayName, string description) { }

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

	// RVA: 0x1278274
	Int64 GetTimestamp() { }

	// RVA: 0x1278278
	Stopwatch StartNew() { }

	// RVA: 0x1278344
	void .ctor() { }

	// RVA: 0x12783CC
	TimeSpan get_Elapsed() { }

	// RVA: 0x12785F8
	Int64 get_ElapsedMilliseconds() { }

	// RVA: 0x127857C
	Int64 get_ElapsedTicks() { }

	// RVA: 0x12787B4
	bool get_IsRunning() { }

	// RVA: 0x12787BC
	void Reset() { }

	// RVA: 0x127834C
	void Start() { }

	// RVA: 0x12787C8
	void Stop() { }

	// RVA: 0x1278844
	void Restart() { }

	// RVA: 0x12788B0
	void .cctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute 
{
	// Methods

	// RVA: 0x127890C
	void .ctor() { }

}

// Namespace: System.Security.Authentication
public class AuthenticationException 
{
	// Methods

	// RVA: 0x1278914
	void .ctor() { }

	// RVA: 0x1278978
	void .ctor(string message) { }

	// RVA: 0x1278980
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x1278988
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly System.Security.Cryptography.DerSequenceReader.<>c <>9; // 0x0
	public static System.Func<System.Text.Encoding> <>9__45_0; // 0x8
	public static System.Func<System.Text.Encoding> <>9__45_1; // 0x10
	public static System.Func<System.Globalization.DateTimeFormatInfo> <>9__51_0; // 0x18

	// Methods

	// RVA: 0x127A498
	void .cctor() { }

	// RVA: 0x127A504
	void .ctor() { }

	// RVA: 0x127A50C
	Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x127A56C
	Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x127A5B4
	DateTimeFormatInfo <ReadTime>b__51_0() { }

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

	// RVA: 0x1278990
	void set_ContentLength(int value) { }

	// RVA: 0x1278998
	void .ctor(Byte[] data) { }

	// RVA: 0x12789C0
	void .ctor(Byte[] data, int offset, int length) { }

	// RVA: 0x12789D4
	void .ctor(DerTag tagToEat, Byte[] data, int offset, int length) { }

	// RVA: 0x1278BB4
	bool get_HasData() { }

	// RVA: 0x1278BC4
	Byte PeekTag() { }

	// RVA: 0x1278C64
	void SkipValue() { }

	// RVA: 0x1278CC0
	Byte[] ReadNextEncodedValue() { }

	// RVA: 0x1278EB0
	bool ReadBoolean() { }

	// RVA: 0x1278F84
	int ReadInteger() { }

	// RVA: 0x1279030
	Byte[] ReadIntegerBytes() { }

	// RVA: 0x12791A8
	Byte[] ReadBitString() { }

	// RVA: 0x12792F0
	Byte[] ReadOctetString() { }

	// RVA: 0x12793B0
	string ReadOidAsString() { }

	// RVA: 0x12796A4
	string ReadUtf8String() { }

	// RVA: 0x1279830
	DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	// RVA: 0x127999C
	DerSequenceReader ReadSequence() { }

	// RVA: 0x12799A4
	DerSequenceReader ReadSet() { }

	// RVA: 0x12799AC
	string ReadPrintableString() { }

	// RVA: 0x1279AB4
	string ReadIA5String() { }

	// RVA: 0x1279BBC
	string ReadT61String() { }

	// RVA: 0x1279FBC
	DateTime ReadX509Date() { }

	// RVA: 0x127A09C
	DateTime ReadUtcTime() { }

	// RVA: 0x127A0F4
	DateTime ReadGeneralizedTime() { }

	// RVA: 0x127A390
	string ReadBMPString() { }

	// RVA: 0x12797AC
	string TrimTrailingNulls(string value) { }

	// RVA: 0x127A14C
	DateTime ReadTime(DerTag timeTag, string formatString) { }

	// RVA: 0x12790F0
	Byte[] ReadContentAsBytes() { }

	// RVA: 0x1278AE0
	void EatTag(DerTag expected) { }

	// RVA: 0x12798FC
	void CheckTag(DerTag expected, Byte[] data, int position) { }

	// RVA: 0x1278B6C
	int EatLength() { }

	// RVA: 0x1278D7C
	int ScanContentLength(Byte[] data, int offset, int end, out int bytesConsumed) { }

}

// Namespace: System.Security.Cryptography
public sealed class Oid 
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Methods

	// RVA: 0x127A6A0
	void .ctor() { }

	// RVA: 0x127A6A8
	void .ctor(string oid) { }

	// RVA: 0x127A740
	void .ctor(string value, string friendlyName) { }

	// RVA: 0x127A790
	void .ctor(Oid oid) { }

	// RVA: 0x127A82C
	Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x127A9E8
	string get_Value() { }

	// RVA: 0x127A9F0
	void set_Value(string value) { }

	// RVA: 0x127A9F8
	string get_FriendlyName() { }

	// RVA: 0x127A98C
	void .ctor(string value, string friendlyName, OidGroup group) { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection 
{
	// Fields
	private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list; // 0x10

	// Methods

	// RVA: 0x127AAC4
	void .ctor() { }

	// RVA: 0x127AB50
	int Add(Oid oid) { }

	// RVA: 0x127ABCC
	Oid get_Item(int index) { }

	// RVA: 0x127AC44
	int get_Count() { }

	// RVA: 0x127AC90
	OidEnumerator GetEnumerator() { }

	// RVA: 0x127AD4C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x127ADC8
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x127B028
	bool get_IsSynchronized() { }

	// RVA: 0x127B030
	object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator 
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Methods

	// RVA: 0x127AD0C
	void .ctor(OidCollection oids) { }

	// RVA: 0x127B034
	Oid get_Current() { }

	// RVA: 0x127B0B0
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x127B12C
	bool MoveNext() { }

	// RVA: 0x127B1AC
	void Reset() { }

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

	// RVA: 0x127B1B8
	void .ctor() { }

	// RVA: 0x127B1C0
	void .ctor(string oid, Byte[] rawData) { }

	// RVA: 0x127B3C4
	void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0x127B518
	void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x127B66C
	Oid get_Oid() { }

	// RVA: 0x127B488
	void set_Oid(Oid value) { }

	// RVA: 0x127B674
	Byte[] get_RawData() { }

	// RVA: 0x127B2BC
	void set_RawData(Byte[] value) { }

	// RVA: 0x127B67C
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x127B7E4
	string Format(bool multiLine) { }

	// RVA: 0x127B9C4
	string ToString(bool multiLine) { }

	// RVA: 0x127B888
	string Default(bool multiLine) { }

	// RVA: 0x127BB98
	string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x127BCBC
	string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x127BDE4
	string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x127BF0C
	string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x127C034
	string SubjectAltName(bool multiLine) { }

	// RVA: 0x127C420
	string NetscapeCertType(bool multiLine) { }

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

	// RVA: 0x127C924
	void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x127CAA0
	AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x127CAA8
	AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x127CAB0
	AsymmetricAlgorithm get_Key() { }

	// RVA: 0x127D78C
	Oid get_Oid() { }

	// RVA: 0x127D794
	Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x127D0AC
	DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0x127CC7C
	RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0x127D848
	void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName 
{
	// Fields
	private string name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x127D8C8
	void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0x127DB80
	void .ctor(string distinguishedName) { }

	// RVA: 0x127DB88
	void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x127E080
	string get_Name() { }

	// RVA: 0x127DED0
	string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x127E110
	string Format(bool multiLine) { }

	// RVA: 0x127E088
	string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x127DA74
	void DecodeRawData() { }

	// RVA: 0x127E180
	string Canonize(string s) { }

	// RVA: 0x127E3DC
	bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension 
{
	// Fields
	internal const string oid = 5736722816;
	internal const string friendlyName = 5730682816;
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Methods

	// RVA: 0x127E5D4
	void .ctor() { }

	// RVA: 0x127C810
	void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x127E8D4
	void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x127EB84
	bool get_CertificateAuthority() { }

	// RVA: 0x127EBF8
	bool get_HasPathLengthConstraint() { }

	// RVA: 0x127EC6C
	int get_PathLengthConstraint() { }

	// RVA: 0x127ECE0
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x127E6A4
	AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x127EA28
	Byte[] Encode() { }

	// RVA: 0x127EEDC
	string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
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

	// RVA: 0x127F174
	void Reset() { }

	// RVA: 0x127F22C
	void .ctor() { }

	// RVA: 0x127F234
	void .ctor(Byte[] rawData) { }

	// RVA: 0x127F3C4
	void .ctor(Byte[] rawData, string password) { }

	// RVA: 0x127F3CC
	void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x127F3D4
	void .ctor(X509Certificate certificate) { }

	// RVA: 0x127F3DC
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x127F424
	X509ExtensionCollection get_Extensions() { }

	// RVA: 0x127FAF4
	bool get_HasPrivateKey() { }

	// RVA: 0x127FBA0
	AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x127FDD8
	X500DistinguishedName get_IssuerName() { }

	// RVA: 0x127FED0
	DateTime get_NotAfter() { }

	// RVA: 0x127FED8
	DateTime get_NotBefore() { }

	// RVA: 0x127FEE0
	PublicKey get_PublicKey() { }

	// RVA: 0x12800A8
	Byte[] get_RawData() { }

	// RVA: 0x12801A4
	string get_SerialNumber() { }

	// RVA: 0x12801B4
	Oid get_SignatureAlgorithm() { }

	// RVA: 0x12802B4
	X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12803AC
	string get_Thumbprint() { }

	// RVA: 0x12803CC
	int get_Version() { }

	// RVA: 0x12804A8
	X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0x1280544
	string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1280600
	string ToString() { }

	// RVA: 0x128060C
	string ToString(bool verbose) { }

	// RVA: 0x1281D50
	bool Verify() { }

	// RVA: 0x127F8F0
	X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x127F860
	X509Certificate2Impl get_Impl() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection 
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x1281DF8
	void .ctor() { }

	// RVA: 0x1281E08
	void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x1281EB4
	X509Certificate2 get_Item(int index) { }

	// RVA: 0x1281FE4
	int Add(X509Certificate2 certificate) { }

	// RVA: 0x1281E38
	void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1282060
	bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x1282398
	string GetKeyIdentifier(X509Certificate2 x) { }

	// RVA: 0x1282CB8
	X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x1283E40
	X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1283F6C
	void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1283EA4
	void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x1284014
	X509Certificate2 get_Current() { }

	// RVA: 0x1284118
	bool MoveNext() { }

	// RVA: 0x12841CC
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1284284
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1284338
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl 
{
	// Methods

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x2FE360C
	X500DistinguishedName get_IssuerName() { }

	// RVA: 0x2FE360C
	AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x2FE4574
	void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x2FE360C
	string get_SignatureAlgorithm() { }

	// RVA: 0x2FE360C
	X500DistinguishedName get_SubjectName() { }

	// RVA: 0x2FE32D4
	int get_Version() { }

	// RVA: 0x2FE360C
	X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: -1
	string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x2FE3174
	bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x2FE4574
	void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x12843F0
	void .ctor() { }

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

	// RVA: 0x12843F8
	bool get_IsValid() { }

	// RVA: 0x1284408
	void .ctor(X509Certificate cert) { }

	// RVA: 0x1284444
	void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x1284550
	void .ctor(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1284780
	X509CertificateImpl Clone() { }

	// RVA: 0x12847F0
	X509Certificate get_Cert() { }

	// RVA: 0x1284818
	Byte[] GetRawCertData() { }

	// RVA: 0x128485C
	bool get_HasPrivateKey() { }

	// RVA: 0x1284884
	AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1284CD4
	void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1284E7C
	RSA GetRSAPrivateKey() { }

	// RVA: 0x1284F14
	DSA GetDSAPrivateKey() { }

	// RVA: 0x1284708
	X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x1284FAC
	X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	// RVA: 0x12858D4
	bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x1285ACC
	X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1285AD4
	X509Certificate get_MonoCertificate() { }

	// RVA: 0x1285ADC
	void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix 
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Methods

	// RVA: 0x1285BBC
	void EnsureCertData() { }

	// RVA: 0x2FE360C
	Byte[] GetRawCertData() { }

	// RVA: 0x1285C94
	string get_KeyAlgorithm() { }

	// RVA: 0x1285D78
	Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1285E5C
	Byte[] get_PublicKeyValue() { }

	// RVA: 0x1285F40
	Byte[] get_SerialNumber() { }

	// RVA: 0x1286024
	string get_SignatureAlgorithm() { }

	// RVA: 0x1286108
	int get_Version() { }

	// RVA: 0x12861F4
	X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12862D8
	X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12863BC
	string get_Subject() { }

	// RVA: 0x12863E8
	string get_Issuer() { }

	// RVA: 0x1286414
	Byte[] get_RawData() { }

	// RVA: 0x12864F8
	Byte[] get_Thumbprint() { }

	// RVA: 0x1286710
	string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1286800
	System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x12868E4
	DateTime get_NotAfter() { }

	// RVA: 0x1286A14
	DateTime get_NotBefore() { }

	// RVA: 0x1286B44
	void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x1286BE8
	Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x1286D48
	Byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x1286DA8
	Byte[] ExportPkcs12(string password) { }

	// RVA: 0x128443C
	void .ctor() { }

}

// Namespace: 
public class X509CertificateEnumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12875E0
	void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x12876CC
	X509Certificate get_Current() { }

	// RVA: 0x12877D0
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1287888
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x128793C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12879F4
	bool MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509CertificateCollection 
{
	// Methods

	// RVA: 0x1281E00
	void .ctor() { }

	// RVA: 0x12872D8
	void .ctor(X509CertificateCollection value) { }

	// RVA: 0x128745C
	X509Certificate get_Item(int index) { }

	// RVA: 0x1287500
	int Add(X509Certificate value) { }

	// RVA: 0x1287308
	void AddRange(X509CertificateCollection value) { }

	// RVA: 0x128757C
	X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x12876A8
	int GetHashCode() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection 
{
	// Fields
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

	// Methods

	// RVA: 0x12857C4
	void .ctor() { }

	// RVA: 0x1287AA8
	void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x128728C
	int get_Count() { }

	// RVA: 0x1287214
	X509CertificateImpl get_Item(int index) { }

	// RVA: 0x1285850
	void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x12844EC
	X509CertificateImplCollection Clone() { }

	// RVA: 0x1287D14
	void Dispose() { }

	// RVA: 0x1287DA4
	void Dispose(bool disposing) { }

	// RVA: 0x12880AC
	void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain 
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Methods

	// RVA: 0x1288148
	X509ChainImpl get_Impl() { }

	// RVA: 0x12881EC
	void .ctor() { }

	// RVA: 0x1288260
	void .ctor(bool useMachineContext) { }

	// RVA: 0x128833C
	void .ctor(X509ChainImpl impl) { }

	// RVA: 0x12883A8
	void .ctor(IntPtr chainContext) { }

	// RVA: 0x12883F0
	X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1288458
	X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1285A5C
	bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12884C0
	void Reset() { }

	// RVA: 0x12859B0
	X509Chain Create() { }

	// RVA: 0x1288528
	void Dispose() { }

	// RVA: 0x12885B8
	void Dispose(bool disposing) { }

	// RVA: 0x12886E8
	void Finalize() { }

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

	// RVA: 0x1288784
	void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x1288804
	X509Certificate2 get_Certificate() { }

	// RVA: 0x128880C
	X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x1288814
	X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x128881C
	void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x1288824
	int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x12888DC
	void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x1288B08
	void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection 
{
	// Fields
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x1289AD8
	void .ctor() { }

	// RVA: 0x1289B50
	int get_Count() { }

	// RVA: 0x1289B78
	bool get_IsSynchronized() { }

	// RVA: 0x1289BA0
	X509ChainElement get_Item(int index) { }

	// RVA: 0x1289C44
	object get_SyncRoot() { }

	// RVA: 0x1289C6C
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1289C94
	X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x1289DC4
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1289E2C
	void Add(X509Certificate2 certificate) { }

	// RVA: 0x1289F0C
	void Clear() { }

	// RVA: 0x1289F34
	bool Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1289CFC
	void .ctor(IEnumerable enumerable) { }

	// RVA: 0x128A0A0
	X509ChainElement get_Current() { }

	// RVA: 0x128A1A4
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x128A25C
	bool MoveNext() { }

	// RVA: 0x128A310
	void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_IsValid() { }

	// RVA: 0x128A3C8
	void ThrowIfContextInvalid() { }

	// RVA: 0x2FE360C
	X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x2FE360C
	X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x2FE3174
	bool Build(X509Certificate2 certificate) { }

	// RVA: 0x2FE42A4
	void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x1288658
	void Dispose() { }

	// RVA: 0x128A498
	void Dispose(bool disposing) { }

	// RVA: 0x128A49C
	void Finalize() { }

	// RVA: 0x128A538
	void .ctor() { }

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

	// RVA: 0x128A540
	void .ctor(bool useMachineContext) { }

	// RVA: 0x128A690
	bool get_IsValid() { }

	// RVA: 0x128A698
	X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x128A6A0
	X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x128A6A8
	void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x128A6AC
	bool Build(X509Certificate2 certificate) { }

	// RVA: 0x128B1C8
	void Reset() { }

	// RVA: 0x128B3D4
	X509Certificate2Collection get_Roots() { }

	// RVA: 0x128B968
	X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x128B590
	X509Store get_LMRootStore() { }

	// RVA: 0x128B728
	X509Store get_UserRootStore() { }

	// RVA: 0x128BB24
	X509Store get_LMCAStore() { }

	// RVA: 0x128BC90
	X509Store get_UserCAStore() { }

	// RVA: 0x128C39C
	X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x128ADD8
	X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x128C9BC
	X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x128C794
	X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x128C8B8
	bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x128CDA4
	bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x128AF78
	void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x128CDF0
	void Process(int n) { }

	// RVA: 0x128D210
	void PrepareForNextCertificate(int n) { }

	// RVA: 0x128D7D4
	void WrapUp() { }

	// RVA: 0x128DAA0
	void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x128DA58
	bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x128CCEC
	string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x128CC48
	string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x128E074
	string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x128DEE0
	string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x128D544
	void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x128E110
	X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x128E2E8
	X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x128ED58
	X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x128E568
	X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x128EA30
	bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x128E738
	bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0x128F0BC
	void .cctor() { }

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

	// RVA: 0x128A668
	void .ctor() { }

	// RVA: 0x128C490
	X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x128F260
	void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x128F268
	X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x128F270
	X509RevocationMode get_RevocationMode() { }

	// RVA: 0x128F278
	void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x128F2E4
	X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x128F2EC
	void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x128F358
	DateTime get_VerificationTime() { }

	// RVA: 0x128F13C
	void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus 
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private string info; // 0x18

	// Methods

	// RVA: 0x128B194
	void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x128F360
	X509ChainStatusFlags get_Status() { }

	// RVA: 0x128F368
	void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x128F370
	void set_StatusInformation(string value) { }

	// RVA: 0x1288968
	string GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension 
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x128F378
	void .ctor() { }

	// RVA: 0x128F430
	void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x128F7C0
	void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x128FA74
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x128F524
	AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x128F978
	Byte[] Encode() { }

	// RVA: 0x128FC50
	string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension 
{
	// Fields
	private bool _critical; // 0x20

	// Methods

	// RVA: 0x128F428
	void .ctor() { }

	// RVA: 0x1290070
	void .ctor(string oid, Byte[] rawData, bool critical) { }

	// RVA: 0x129009C
	bool get_Critical() { }

	// RVA: 0x12900A4
	void set_Critical(bool value) { }

	// RVA: 0x12900AC
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x128FF40
	string FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection 
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12901DC
	void .ctor() { }

	// RVA: 0x1283DA4
	int get_Count() { }

	// RVA: 0x1290254
	bool get_IsSynchronized() { }

	// RVA: 0x129027C
	object get_SyncRoot() { }

	// RVA: 0x1282464
	X509Extension get_Item(string oid) { }

	// RVA: 0x1290280
	int Add(X509Extension extension) { }

	// RVA: 0x12902FC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x128DC94
	X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x1290464
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12904F8
	void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1290414
	void .ctor(ArrayList list) { }

	// RVA: 0x128DD28
	X509Extension get_Current() { }

	// RVA: 0x1290578
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x128DE2C
	bool MoveNext() { }

	// RVA: 0x1290630
	void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 
{
	// Methods

	// RVA: 0x128D970
	X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x12882D8
	X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x12906E8
	bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x12881A0
	void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x128A410
	Exception GetInvalidChainContextException() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension 
{
	// Fields
	internal const string oid = 5736722576;
	internal const string friendlyName = 5736722528;
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Methods

	// RVA: 0x12906FC
	void .ctor() { }

	// RVA: 0x12907AC
	void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x1290AC8
	void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x1283DCC
	X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x1290D5C
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1290BB4
	X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x12908A0
	AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1290BC4
	Byte[] Encode() { }

	// RVA: 0x1290F38
	string ToString(bool multiLine) { }

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

	// RVA: 0x128BDFC
	void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x128B8C0
	X509Certificate2Collection get_Certificates() { }

	// RVA: 0x12914DC
	X509Stores get_Factory() { }

	// RVA: 0x12914F8
	X509Store get_Store() { }

	// RVA: 0x128B390
	void Close() { }

	// RVA: 0x1291500
	void Dispose() { }

	// RVA: 0x128BF38
	void Open(OpenFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension 
{
	// Fields
	internal const string oid = 5736722432;
	internal const string friendlyName = 5714674144;
	private Byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Methods

	// RVA: 0x1291544
	void .ctor() { }

	// RVA: 0x12915F4
	void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x12918A8
	void .ctor(Byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1291B7C
	void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1291F0C
	void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x12827E4
	void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x1282C20
	string get_SubjectKeyIdentifier() { }

	// RVA: 0x1291F18
	void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12920F4
	Byte FromHexChar(Char c) { }

	// RVA: 0x1292134
	Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0x1291D64
	Byte[] FromHex(string hex) { }

	// RVA: 0x12916E8
	AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x1291AFC
	Byte[] Encode() { }

	// RVA: 0x12921D0
	string ToString(bool multiLine) { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute 
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Methods

	// RVA: 0x1292450
	void .ctor(Type type, string value) { }

	// RVA: 0x1292994
	void .ctor(Char value) { }

	// RVA: 0x1292A18
	void .ctor(Byte value) { }

	// RVA: 0x1292A9C
	void .ctor(Int16 value) { }

	// RVA: 0x1292B20
	void .ctor(int value) { }

	// RVA: 0x1292BA4
	void .ctor(Int64 value) { }

	// RVA: 0x1292C28
	void .ctor(float value) { }

	// RVA: 0x1292CB4
	void .ctor(Double value) { }

	// RVA: 0x1292D40
	void .ctor(bool value) { }

	// RVA: 0x1292DC4
	void .ctor(string value) { }

	// RVA: 0x1292DF8
	void .ctor(object value) { }

	// RVA: 0x1292E2C
	void .ctor(SByte value) { }

	// RVA: 0x1292EB0
	void .ctor(UInt16 value) { }

	// RVA: 0x1292F34
	void .ctor(UInt32 value) { }

	// RVA: 0x1292FB8
	void .ctor(UInt64 value) { }

	// RVA: 0x129303C
	object get_Value() { }

	// RVA: 0x1293044
	bool Equals(object obj) { }

	// RVA: 0x129316C
	int GetHashCode() { }

	// RVA: 0x1293174
	void SetValue(object value) { }

	// RVA: 0x129276C
	bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, out object conversionResult) { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute 
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x129317C
	void .ctor(EditorBrowsableState state) { }

	// RVA: 0x12931A8
	void .ctor() { }

	// RVA: 0x12931D0
	EditorBrowsableState get_State() { }

	// RVA: 0x12931D8
	bool Equals(object obj) { }

	// RVA: 0x129327C
	int GetHashCode() { }

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

	// RVA: 0x1293284
	void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12932F0
	void Finalize() { }

	// RVA: 0x1293398
	object get_UserSuppliedState() { }

	// RVA: 0x12933A0
	SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12933A8
	void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x1293498
	void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x12935A0
	void OperationCompleted() { }

	// RVA: 0x12933B0
	void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x12934C0
	void OperationCompletedCore() { }

	// RVA: 0x1293610
	void VerifyNotCompleted() { }

	// RVA: 0x1293678
	void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x12936E8
	AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x1293790
	void .ctor() { }

}

// Namespace: System.ComponentModel
public static class AsyncOperationManager 
{
	// Methods

	// RVA: 0x12937CC
	AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x129384C
	SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12938D8
	void set_SynchronizationContext(SynchronizationContext value) { }

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

	// RVA: 0x12938E0
	void .ctor() { }

	// RVA: 0x12939E0
	void AsyncOperationCompleted(object arg) { }

	// RVA: 0x1293A80
	bool get_CancellationPending() { }

	// RVA: 0x1293A88
	void CancelAsync() { }

	// RVA: 0x1293AF8
	void add_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x1293B9C
	void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x1293C40
	bool get_IsBusy() { }

	// RVA: 0x1293C48
	void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x1293C6C
	void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x1293C90
	void OnProgressChanged(ProgressChangedEventArgs e) { }

	// RVA: 0x1293CB4
	void add_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x1293D58
	void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x1293DFC
	void ProgressReporter(object arg) { }

	// RVA: 0x1293E98
	void ReportProgress(int percentProgress) { }

	// RVA: 0x1293EA0
	void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x1293F9C
	void RunWorkerAsync() { }

	// RVA: 0x1293FA4
	void RunWorkerAsync(object argument) { }

	// RVA: 0x12941F8
	void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x129429C
	void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x1294340
	bool get_WorkerReportsProgress() { }

	// RVA: 0x1294348
	void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x1294350
	bool get_WorkerSupportsCancellation() { }

	// RVA: 0x1294358
	void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x1294360
	void WorkerThreadStart(object argument) { }

	// RVA: 0x12944F8
	void Dispose(bool disposing) { }

	// RVA: 0x12944FC
	void <RunWorkerAsync>b__27_0(object arg) { }

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

	// RVA: 0x1294500
	void .ctor(bool browsable) { }

	// RVA: 0x129452C
	bool get_Browsable() { }

	// RVA: 0x1294534
	bool Equals(object obj) { }

	// RVA: 0x1294700
	int GetHashCode() { }

	// RVA: 0x1294778
	bool IsDefaultAttribute() { }

	// RVA: 0x12947EC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection 
{
	// Methods

	// RVA: 0x12948A0
	void .ctor(IComponent[] components) { }

	// RVA: 0x12948EC
	IComponent get_Item(string name) { }

	// RVA: 0x1294E54
	IComponent get_Item(int index) { }

	// RVA: 0x1294EF0
	void CopyTo(IComponent[] array, int index) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute 
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string <DescriptionValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1294F34
	void .ctor() { }

	// RVA: 0x1294FA4
	void .ctor(string description) { }

	// RVA: 0x1294FD8
	string get_Description() { }

	// RVA: 0x1294FE0
	string get_DescriptionValue() { }

	// RVA: 0x1294FE8
	void set_DescriptionValue(string value) { }

	// RVA: 0x1294FF0
	bool Equals(object obj) { }

	// RVA: 0x12950CC
	int GetHashCode() { }

	// RVA: 0x12950F8
	bool IsDefaultAttribute() { }

	// RVA: 0x129516C
	void .cctor() { }

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

	// RVA: 0x1295228
	void .ctor(bool isDesignOnly) { }

	// RVA: 0x1295254
	bool get_IsDesignOnly() { }

	// RVA: 0x129525C
	bool Equals(object obj) { }

	// RVA: 0x1295428
	int GetHashCode() { }

	// RVA: 0x12954A0
	bool IsDefaultAttribute() { }

	// RVA: 0x1295548
	void .cctor() { }

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

	// RVA: 0x12955FC
	void .ctor() { }

	// RVA: 0x1295668
	void .ctor(string category) { }

	// RVA: 0x129569C
	string get_Category() { }

	// RVA: 0x12956A4
	bool Equals(object obj) { }

	// RVA: 0x1295744
	int GetHashCode() { }

	// RVA: 0x1295768
	bool IsDefaultAttribute() { }

	// RVA: 0x129580C
	object get_TypeId() { }

	// RVA: 0x1295850
	void .cctor() { }

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

	// RVA: 0x1295A00
	void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x1295A2C
	DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x1295A34
	bool Equals(object obj) { }

	// RVA: 0x1295BF0
	int GetHashCode() { }

	// RVA: 0x1295BF8
	bool IsDefaultAttribute() { }

	// RVA: 0x1295C6C
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute 
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1295D50
	void .ctor() { }

	// RVA: 0x1295DC0
	void .ctor(string displayName) { }

	// RVA: 0x1295DF4
	string get_DisplayName() { }

	// RVA: 0x1295DFC
	string get_DisplayNameValue() { }

	// RVA: 0x1295E04
	void set_DisplayNameValue(string value) { }

	// RVA: 0x1295E0C
	bool Equals(object obj) { }

	// RVA: 0x1295EE8
	int GetHashCode() { }

	// RVA: 0x1295F14
	bool IsDefaultAttribute() { }

	// RVA: 0x1295F88
	void .cctor() { }

}

// Namespace: 
private sealed class ListEntry 
{
	// Fields
	internal ListEntry _next; // 0x10
	internal object _key; // 0x18
	internal Delegate _handler; // 0x20

	// Methods

	// RVA: 0x12961FC
	void .ctor(object key, Delegate handler, ListEntry next) { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList 
{
	// Fields
	private ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Methods

	// RVA: 0x1296044
	void .ctor(Component parent) { }

	// RVA: 0x1296078
	void .ctor() { }

	// RVA: 0x1296080
	Delegate get_Item(object key) { }

	// RVA: 0x1296114
	void set_Item(object key, Delegate value) { }

	// RVA: 0x1296260
	void AddHandler(object key, Delegate value) { }

	// RVA: 0x129635C
	void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x129639C
	void Dispose() { }

	// RVA: 0x12960FC
	ListEntry Find(object key) { }

	// RVA: 0x12963A8
	void RemoveHandler(object key, Delegate value) { }

}

// Namespace: System.ComponentModel
public interface IContainer 
{
	// Methods

	// RVA: 0x2FE4574
	void Add(IComponent component) { }

	// RVA: 0x2FE47D4
	void Add(IComponent component, string name) { }

	// RVA: 0x2FE360C
	ComponentCollection get_Components() { }

	// RVA: 0x2FE4574
	void Remove(IComponent component) { }

}

// Namespace: System.ComponentModel
public interface ISite 
{
	// Methods

	// RVA: 0x2FE360C
	IComponent get_Component() { }

	// RVA: 0x2FE360C
	IContainer get_Container() { }

	// RVA: 0x2FE3054
	bool get_DesignMode() { }

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE4574
	void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public interface ISupportInitialize 
{
	// Methods

	// RVA: 0x2FE41A8
	void BeginInit() { }

	// RVA: 0x2FE41A8
	void EndInit() { }

}

// Namespace: System.ComponentModel
public interface ISynchronizeInvoke 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_InvokeRequired() { }

	// RVA: 0x2FE37A0
	IAsyncResult BeginInvoke(Delegate method, object[] args) { }

	// RVA: 0x2FE36BC
	object EndInvoke(IAsyncResult result) { }

	// RVA: 0x2FE37A0
	object Invoke(Delegate method, object[] args) { }

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

	// RVA: 0x1296404
	void .ctor(bool immutable) { }

	// RVA: 0x1296430
	bool get_Immutable() { }

	// RVA: 0x1296438
	bool Equals(object obj) { }

	// RVA: 0x1296604
	int GetHashCode() { }

	// RVA: 0x129660C
	bool IsDefaultAttribute() { }

	// RVA: 0x1296680
	void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class InitializationEventAttribute 
{
	// Fields
	private readonly string <EventName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1296734
	void .ctor(string eventName) { }

	// RVA: 0x1296768
	string get_EventName() { }

}

// Namespace: System.ComponentModel
public class InvalidEnumArgumentException 
{
	// Methods

	// RVA: 0x1296770
	void .ctor() { }

	// RVA: 0x129677C
	void .ctor(string message) { }

	// RVA: 0x1296784
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x129678C
	void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x1296878
	void .ctor(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0x1296880
	void .ctor(bool isLocalizable) { }

	// RVA: 0x12968AC
	bool get_IsLocalizable() { }

	// RVA: 0x12968B4
	bool Equals(object obj) { }

	// RVA: 0x1296A80
	int GetHashCode() { }

	// RVA: 0x1296A88
	bool IsDefaultAttribute() { }

	// RVA: 0x1296B30
	void .cctor() { }

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

	// RVA: 0x1296BE4
	void .ctor(bool allowMerge) { }

	// RVA: 0x1296C10
	bool get_AllowMerge() { }

	// RVA: 0x1296C18
	bool Equals(object obj) { }

	// RVA: 0x1296DE4
	int GetHashCode() { }

	// RVA: 0x1296DEC
	bool IsDefaultAttribute() { }

	// RVA: 0x1296E60
	void .cctor() { }

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

	// RVA: 0x1296F14
	void .ctor(bool isReadOnly) { }

	// RVA: 0x1296F40
	bool get_IsReadOnly() { }

	// RVA: 0x1296F48
	bool Equals(object value) { }

	// RVA: 0x1297114
	int GetHashCode() { }

	// RVA: 0x129711C
	bool IsDefaultAttribute() { }

	// RVA: 0x12971C4
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class AddingNewEventArgs 
{
	// Fields
	private object <NewObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1297278
	void .ctor() { }

	// RVA: 0x1297300
	void .ctor(object newObject) { }

	// RVA: 0x1297378
	object get_NewObject() { }

	// RVA: 0x1297380
	void set_NewObject(object value) { }

}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler 
{
	// Methods

	// RVA: 0x1297388
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12974AC
	internal void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x12974C0
	internal IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x129751C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute 
{
	// Fields
	private readonly object <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1297528
	void .ctor(Type type, string value) { }

	// RVA: 0x1297660
	void .ctor(Char value) { }

	// RVA: 0x12976E4
	void .ctor(Byte value) { }

	// RVA: 0x1297768
	void .ctor(Int16 value) { }

	// RVA: 0x12977EC
	void .ctor(int value) { }

	// RVA: 0x1297870
	void .ctor(Int64 value) { }

	// RVA: 0x12978F4
	void .ctor(float value) { }

	// RVA: 0x1297980
	void .ctor(Double value) { }

	// RVA: 0x1297A0C
	void .ctor(bool value) { }

	// RVA: 0x1297A90
	void .ctor(string value) { }

	// RVA: 0x1297AC4
	void .ctor(object value) { }

	// RVA: 0x1297AF8
	object get_Value() { }

	// RVA: 0x1297B00
	bool Equals(object obj) { }

	// RVA: 0x1297BC0
	int GetHashCode() { }

}

// Namespace: 
private class ArrayPropertyDescriptor 
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x12980B8
	void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x1298188
	object GetValue(object instance) { }

	// RVA: 0x1298240
	void SetValue(object instance, object value) { }

}

// Namespace: System.ComponentModel
public class ArrayConverter 
{
	// Methods

	// RVA: 0x1297BC8
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1297DBC
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1298178
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1298180
	void .ctor() { }

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

	// RVA: 0x1298344
	void .ctor(Attribute[] attributes) { }

	// RVA: 0x12984D0
	void .ctor() { }

	// RVA: 0x12984D8
	AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x1298990
	Attribute[] get_Attributes() { }

	// RVA: 0x12988FC
	int get_Count() { }

	// RVA: 0x1298998
	Attribute get_Item(int index) { }

	// RVA: 0x12989E0
	Attribute get_Item(Type attributeType) { }

	// RVA: 0x129978C
	bool Contains(Attribute attribute) { }

	// RVA: 0x12997F0
	bool Contains(Attribute[] attributes) { }

	// RVA: 0x1299180
	Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x1299890
	IEnumerator GetEnumerator() { }

	// RVA: 0x12998B8
	bool Matches(Attribute attribute) { }

	// RVA: 0x1299968
	bool Matches(Attribute[] attributes) { }

	// RVA: 0x12999E0
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12999E8
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12999F0
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1299A18
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1298924
	void CopyTo(Array array, int index) { }

	// RVA: 0x1299A40
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute 
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1299AF0
	void .ctor(string typeName) { }

	// RVA: 0x1299B70
	void .ctor(string typeName, string propertyName) { }

	// RVA: 0x1299C30
	void .ctor(Type type) { }

	// RVA: 0x1299D4C
	string get_TypeName() { }

	// RVA: 0x1299D54
	string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public abstract class ComponentEditor 
{
	// Methods

	// RVA: 0x1299D5C
	bool EditComponent(object component) { }

	// RVA: -1
	bool EditComponent(ITypeDescriptorContext context, object component) { }

	// RVA: 0x1299D70
	void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter 
{
	// Methods

	// RVA: 0x1299D78
	void .ctor() { }

	// RVA: 0x1299D80
	bool get_AllowHex() { }

	// RVA: 0x2FE360C
	Type get_TargetType() { }

	// RVA: 0x2FE3728
	object FromString(string value, int radix) { }

	// RVA: 0x2FE37A0
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x2FE37A0
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1299D88
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1299E54
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x129A270
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x129A570
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

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

	// RVA: 0x129A5B8
	void .ctor(bool bindable) { }

	// RVA: 0x129A5E8
	void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x129A624
	void .ctor(BindableSupport flags) { }

	// RVA: 0x129A668
	void .ctor(BindableSupport flags, BindingDirection direction) { }

	// RVA: 0x129A6B8
	bool get_Bindable() { }

	// RVA: 0x129A6C0
	BindingDirection get_Direction() { }

	// RVA: 0x129A6C8
	bool Equals(object obj) { }

	// RVA: 0x129A778
	int GetHashCode() { }

	// RVA: 0x129A7F0
	bool IsDefaultAttribute() { }

	// RVA: 0x129A88C
	void .cctor() { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IList<T> list) { }

	// RVA: 0x2FE41A8
	void Initialize() { }

	// RVA: 0x2FE3054
	bool get_ItemTypeHasDefaultConstructor() { }

	// RVA: 0x2FE4574
	void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x2FE4574
	void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x2FE4574
	void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x2FE360C
	object FireAddingNew() { }

	// RVA: 0x2FE4574
	void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2FE4574
	void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2FE4574
	void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x2FE3054
	bool get_RaiseListChangedEvents() { }

	// RVA: 0x2FE4234
	void set_RaiseListChangedEvents(bool value) { }

	// RVA: 0x2FE41A8
	void ResetBindings() { }

	// RVA: 0x2FE42A4
	void ResetItem(int position) { }

	// RVA: 0x2FE4314
	void FireListChanged(ListChangedType type, int index) { }

	// RVA: 0x2FE41A8
	void ClearItems() { }

	// RVA: 0x309AF8C
	void InsertItem(int index, T item) { }

	// RVA: 0x2FE42A4
	void RemoveItem(int index) { }

	// RVA: 0x309AF8C
	void SetItem(int index, T item) { }

	// RVA: 0x2FE42A4
	void CancelNew(int itemIndex) { }

	// RVA: 0x2FE42A4
	void EndNew(int itemIndex) { }

	// RVA: 0x309AF8C
	T AddNew() { }

	// RVA: 0x2FE360C
	object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x2FE3054
	bool get_AddingNewHandled() { }

	// RVA: 0x2FE360C
	object AddNewCore() { }

	// RVA: 0x2FE3054
	bool get_AllowNew() { }

	// RVA: 0x2FE4234
	void set_AllowNew(bool value) { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x2FE3054
	bool get_AllowEdit() { }

	// RVA: 0x2FE4234
	void set_AllowEdit(bool value) { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x2FE3054
	bool get_AllowRemove() { }

	// RVA: 0x2FE4234
	void set_AllowRemove(bool value) { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x2FE3054
	bool get_SupportsChangeNotificationCore() { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x2FE3054
	bool get_SupportsSearchingCore() { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x2FE3054
	bool get_SupportsSortingCore() { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x2FE3054
	bool get_IsSortedCore() { }

	// RVA: 0x2FE360C
	PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x2FE360C
	PropertyDescriptor get_SortPropertyCore() { }

	// RVA: 0x2FE32D4
	ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x2FE32D4
	ListSortDirection get_SortDirectionCore() { }

	// RVA: 0x2FE45DC
	void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x2FE45DC
	void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x2FE41A8
	void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x2FE41A8
	void RemoveSortCore() { }

	// RVA: -1
	int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }

	// RVA: -1
	int FindCore(PropertyDescriptor prop, object key) { }

	// RVA: 0x2FE4574
	void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }

	// RVA: 0x2FE4574
	void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }

	// RVA: 0x309AF8C
	void HookPropertyChanged(T item) { }

	// RVA: 0x309AF8C
	void UnhookPropertyChanged(T item) { }

	// RVA: 0x2FE47D4
	void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x2FE3054
	bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter 
{
	// Fields
	private static StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x129A948
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x129AA14
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x129AC14
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x129ADC0
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x129ADC8
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x129ADD0
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter 
{
	// Methods

	// RVA: 0x129ADD8
	Type get_TargetType() { }

	// RVA: 0x129AE78
	object FromString(string value, int radix) { }

	// RVA: 0x129AF14
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x129AF90
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x129B048
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler 
{
	// Methods

	// RVA: 0x129B050
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x129B174
	internal void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x129B188
	internal IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x129B1E4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CharConverter 
{
	// Methods

	// RVA: 0x129B1F0
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x129B2BC
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x129B3F0
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x129B584
	void .ctor() { }

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

	// RVA: 0x129B58C
	void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x129B614
	CollectionChangeAction get_Action() { }

	// RVA: 0x129B61C
	object get_Element() { }

}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler 
{
	// Methods

	// RVA: 0x129B624
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x129B748
	internal void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x129B75C
	internal IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x129B7B8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class ComplexBindingPropertiesAttribute 
{
	// Fields
	private readonly string <DataSource>k__BackingField; // 0x10
	private readonly string <DataMember>k__BackingField; // 0x18
	public static readonly ComplexBindingPropertiesAttribute Default; // 0x0

	// Methods

	// RVA: 0x129B7C4
	void .ctor() { }

	// RVA: 0x129B7CC
	void .ctor(string dataSource) { }

	// RVA: 0x129B800
	void .ctor(string dataSource, string dataMember) { }

	// RVA: 0x129B850
	string get_DataSource() { }

	// RVA: 0x129B858
	string get_DataMember() { }

	// RVA: 0x129B860
	bool Equals(object obj) { }

	// RVA: 0x129B8F8
	int GetHashCode() { }

	// RVA: 0x129B900
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentResourceManager 
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Methods

	// RVA: 0x129B96C
	void .ctor() { }

	// RVA: 0x129B9F4
	void .ctor(Type t) { }

	// RVA: 0x129BA60
	CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x129BB08
	void ApplyResources(object value, string objectName) { }

	// RVA: 0x129BB18
	void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x129C9D8
	System.Collections.Generic.SortedList<System.String,System.Object> FillResources(CultureInfo culture, out ResourceSet resourceSet) { }

}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService 
{
	// Methods

	// RVA: 0x129CF80
	void .ctor() { }

	// RVA: 0x129CF88
	ComponentCollection FilterComponents(ComponentCollection components) { }

}

// Namespace: 
private class CultureComparer 
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x129E328
	void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x129E374
	int Compare(object item1, object item2) { }

}

// Namespace: 
private static class CultureInfoMapper 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x129E4E8
	System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }

	// RVA: 0x129DB50
	string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x12A25CC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class CultureInfoConverter 
{
	// Fields
	private StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = 5736734512;

	// Methods

	// RVA: 0x129CF90
	string get_DefaultCultureString() { }

	// RVA: 0x129CFD4
	string GetCultureName(CultureInfo culture) { }

	// RVA: 0x129CFFC
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x129D0C8
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x129D194
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x129DC18
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x129E0D8
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x129E35C
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x129E364
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x129E36C
	void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor 
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x12A2628
	void .ctor() { }

	// RVA: 0x12A2630
	void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x12A2664
	AttributeCollection GetAttributes() { }

	// RVA: 0x12A2764
	string GetClassName() { }

	// RVA: 0x12A2828
	string GetComponentName() { }

	// RVA: 0x12A28EC
	TypeConverter GetConverter() { }

	// RVA: 0x12A29D8
	EventDescriptor GetDefaultEvent() { }

	// RVA: 0x12A2A9C
	PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x12A2B60
	object GetEditor(Type editorBaseType) { }

	// RVA: 0x12A2C28
	EventDescriptorCollection GetEvents() { }

	// RVA: 0x12A2D2C
	EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x12A2E38
	PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x12A2F3C
	PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x12A3048
	object GetPropertyOwner(PropertyDescriptor pd) { }

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

	// RVA: 0x12A3110
	void .ctor() { }

	// RVA: 0x12A313C
	void .ctor(bool isDataObject) { }

	// RVA: 0x12A3168
	bool get_IsDataObject() { }

	// RVA: 0x12A3170
	bool Equals(object obj) { }

	// RVA: 0x12A3220
	int GetHashCode() { }

	// RVA: 0x12A3298
	bool IsDefaultAttribute() { }

	// RVA: 0x12A330C
	void .cctor() { }

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

	// RVA: 0x12A33C0
	void .ctor(bool primaryKey) { }

	// RVA: 0x12A344C
	void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x12A3494
	void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x12A33F8
	void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	// RVA: 0x12A34E0
	bool get_IsIdentity() { }

	// RVA: 0x12A34E8
	bool get_IsNullable() { }

	// RVA: 0x12A34F0
	int get_Length() { }

	// RVA: 0x12A34F8
	bool get_PrimaryKey() { }

	// RVA: 0x12A3500
	bool Equals(object obj) { }

	// RVA: 0x12A3600
	int GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectMethodAttribute 
{
	// Fields
	private readonly bool <IsDefault>k__BackingField; // 0x10
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Methods

	// RVA: 0x12A3608
	void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x12A3638
	void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	// RVA: 0x12A3674
	bool get_IsDefault() { }

	// RVA: 0x12A367C
	DataObjectMethodType get_MethodType() { }

	// RVA: 0x12A3684
	bool Equals(object obj) { }

	// RVA: 0x12A3744
	int GetHashCode() { }

	// RVA: 0x12A37D8
	bool Match(object obj) { }

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

	// RVA: 0x12A387C
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12A3948
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12A3A14
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12A3D60
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12A41A4
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class DecimalConverter 
{
	// Methods

	// RVA: 0x12A41AC
	bool get_AllowHex() { }

	// RVA: 0x12A41B4
	Type get_TargetType() { }

	// RVA: 0x12A4254
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12A4320
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12A4684
	object FromString(string value, int radix) { }

	// RVA: 0x12A4778
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12A4830
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12A4924
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultBindingPropertyAttribute 
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12A492C
	void .ctor() { }

	// RVA: 0x12A4934
	void .ctor(string name) { }

	// RVA: 0x12A4968
	string get_Name() { }

	// RVA: 0x12A4970
	bool Equals(object obj) { }

	// RVA: 0x12A49F4
	int GetHashCode() { }

	// RVA: 0x12A49FC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute 
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Methods

	// RVA: 0x12A4A68
	void .ctor(string name) { }

	// RVA: 0x12A4A9C
	string get_Name() { }

	// RVA: 0x12A4AA4
	bool Equals(object obj) { }

	// RVA: 0x12A4B28
	int GetHashCode() { }

	// RVA: 0x12A4B30
	void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute 
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12A4BAC
	void .ctor(string name) { }

	// RVA: 0x12A4BE0
	string get_Name() { }

	// RVA: 0x12A4BE8
	bool Equals(object obj) { }

	// RVA: 0x12A4C6C
	int GetHashCode() { }

	// RVA: 0x12A4C74
	void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider 
{
	// Fields
	private readonly Type _type; // 0x20

	// Methods

	// RVA: 0x12A4CF0
	void .ctor(Type type) { }

	// RVA: 0x12A4D2C
	TypeDescriptionProvider get_Provider() { }

	// RVA: 0x12A4DBC
	object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12A4E88
	IDictionary GetCache(object instance) { }

	// RVA: 0x12A4F2C
	string GetFullComponentName(object component) { }

	// RVA: 0x12A4FD0
	ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12A5074
	IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12A5118
	Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12A51CC
	Type GetRuntimeType(Type objectType) { }

	// RVA: 0x12A5270
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12A5324
	bool IsSupportedType(Type type) { }

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

	// RVA: 0x12A53C8
	void .ctor() { }

	// RVA: 0x12A5470
	void .ctor(InheritanceLevel inheritanceLevel) { }

	// RVA: 0x12A549C
	InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x12A54A4
	bool Equals(object value) { }

	// RVA: 0x12A5548
	int GetHashCode() { }

	// RVA: 0x12A5550
	bool IsDefaultAttribute() { }

	// RVA: 0x12A55C4
	string ToString() { }

	// RVA: 0x12A56C4
	void .cctor() { }

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

	// RVA: 0x12A57AC
	void .ctor() { }

	// RVA: 0x12A5940
	void .ctor(Type tabClass) { }

	// RVA: 0x12A5AD8
	void .ctor(string tabClassName) { }

	// RVA: 0x12A5948
	void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x12A5AE0
	void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x12A5C4C
	Type[] get_TabClasses() { }

	// RVA: 0x12A5FAC
	string[] get_TabClassNames() { }

	// RVA: 0x12A6024
	PropertyTabScope[] get_TabScopes() { }

	// RVA: 0x12A602C
	void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x12A6034
	bool Equals(object other) { }

	// RVA: 0x12A60D0
	bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x12A6288
	int GetHashCode() { }

	// RVA: 0x12A6290
	void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12A65D8
	void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12A629C
	void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes) { }

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

	// RVA: 0x12A65E8
	bool IsDefaultAttribute() { }

	// RVA: 0x12A665C
	void .ctor(bool defaultType) { }

	// RVA: 0x12A66D8
	void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x12A6794
	void .ctor(Type toolboxItemType) { }

	// RVA: 0x12A67F4
	Type get_ToolboxItemType() { }

	// RVA: 0x12A69D4
	string get_ToolboxItemTypeName() { }

	// RVA: 0x12A6A40
	bool Equals(object obj) { }

	// RVA: 0x12A6B70
	int GetHashCode() { }

	// RVA: 0x12A6B94
	void .cctor() { }

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

	// RVA: 0x12A6C68
	void .ctor(bool visible) { }

	// RVA: 0x12A6C94
	void .ctor() { }

	// RVA: 0x12A6C9C
	bool get_Visible() { }

	// RVA: 0x12A6CA4
	bool Equals(object obj) { }

	// RVA: 0x12A6D54
	int GetHashCode() { }

	// RVA: 0x12A6E14
	bool IsDefaultAttribute() { }

	// RVA: 0x12A6EBC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter 
{
	// Methods

	// RVA: 0x12A6F70
	bool get_AllowHex() { }

	// RVA: 0x12A6F78
	Type get_TargetType() { }

	// RVA: 0x12A7018
	object FromString(string value, int radix) { }

	// RVA: 0x12A70E0
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12A715C
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12A7214
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class EditorAttribute 
{
	// Fields
	private string _typeId; // 0x10
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12A721C
	void .ctor() { }

	// RVA: 0x12A72A0
	void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x12A7378
	void .ctor(string typeName, Type baseType) { }

	// RVA: 0x12A746C
	void .ctor(Type type, Type baseType) { }

	// RVA: 0x12A74F0
	string get_EditorBaseTypeName() { }

	// RVA: 0x12A74F8
	string get_EditorTypeName() { }

	// RVA: 0x12A7500
	object get_TypeId() { }

	// RVA: 0x12A75BC
	bool Equals(object obj) { }

	// RVA: 0x12A7684
	int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor 
{
	// Methods

	// RVA: 0x12A768C
	void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12A7694
	void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12A769C
	void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: 0x2FE360C
	Type get_ComponentType() { }

	// RVA: 0x2FE360C
	Type get_EventType() { }

	// RVA: 0x2FE3054
	bool get_IsMulticast() { }

	// RVA: 0x2FE47D4
	void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x2FE47D4
	void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: 
private class ArraySubsetEnumerator 
{
	// Fields
	private readonly Array _array; // 0x10
	private readonly int _total; // 0x18
	private int _current; // 0x1C

	// Methods

	// RVA: 0x12A8570
	void .ctor(Array array, int count) { }

	// RVA: 0x12A8E50
	bool MoveNext() { }

	// RVA: 0x12A8E74
	void Reset() { }

	// RVA: 0x12A8E80
	object get_Current() { }

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

	// RVA: 0x12A76A4
	void .ctor(EventDescriptor[] events) { }

	// RVA: 0x12A77D4
	void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x12A77FC
	void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12A791C
	int get_Count() { }

	// RVA: 0x12A7924
	void set_Count(int value) { }

	// RVA: 0x12A792C
	EventDescriptor get_Item(int index) { }

	// RVA: 0x12A7A7C
	EventDescriptor get_Item(string name) { }

	// RVA: 0x12A7A90
	int Add(EventDescriptor value) { }

	// RVA: 0x12A7C84
	void Clear() { }

	// RVA: 0x12A7CDC
	bool Contains(EventDescriptor value) { }

	// RVA: 0x12A7DB0
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12A79B4
	void EnsureEventsOwned() { }

	// RVA: 0x12A7B64
	void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12A8118
	EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12A7D4C
	int IndexOf(EventDescriptor value) { }

	// RVA: 0x12A8240
	void Insert(int index, EventDescriptor value) { }

	// RVA: 0x12A8334
	void Remove(EventDescriptor value) { }

	// RVA: 0x12A83F8
	void RemoveAt(int index) { }

	// RVA: 0x12A84C0
	IEnumerator GetEnumerator() { }

	// RVA: 0x12A85BC
	EventDescriptorCollection Sort() { }

	// RVA: 0x12A8640
	EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12A86C8
	EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12A8750
	EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12A7DF8
	void InternalSort(string[] names) { }

	// RVA: 0x12A87D4
	void InternalSort(IComparer sorter) { }

	// RVA: 0x12A8874
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12A887C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12A8884
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12A888C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12A8890
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12A88A0
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12A8A24
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x12A8AB4
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12A8B84
	void System.Collections.IList.Clear() { }

	// RVA: 0x12A8BDC
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12A8CA0
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12A8D38
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12A8DC8
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12A8DCC
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12A8DD4
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12A8DDC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter 
{
	// Methods

	// RVA: 0x12A8EE8
	void .ctor() { }

	// RVA: 0x12A8EF0
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12A8F5C
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor 
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Methods

	// RVA: 0x12A8F64
	void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x12A91F4
	void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x12A933C
	bool CanResetValue(object comp) { }

	// RVA: 0x12A9368
	Type get_ComponentType() { }

	// RVA: 0x12A9390
	bool get_IsReadOnly() { }

	// RVA: 0x12A9484
	Type get_PropertyType() { }

	// RVA: 0x12A94AC
	string get_DisplayName() { }

	// RVA: 0x12A96A4
	object GetValue(object comp) { }

	// RVA: 0x12A96D0
	void ResetValue(object comp) { }

	// RVA: 0x12A96FC
	void SetValue(object component, object value) { }

	// RVA: 0x12A972C
	bool ShouldSerializeValue(object comp) { }

}

// Namespace: System.ComponentModel
public sealed class ExtenderProvidedPropertyAttribute 
{
	// Fields
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	private Type <ReceiverType>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12A9148
	ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x12A9758
	void .ctor() { }

	// RVA: 0x12A9760
	PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0x12A9768
	void set_ExtenderProperty(PropertyDescriptor value) { }

	// RVA: 0x12A9770
	IExtenderProvider get_Provider() { }

	// RVA: 0x12A9778
	void set_Provider(IExtenderProvider value) { }

	// RVA: 0x12A9780
	Type get_ReceiverType() { }

	// RVA: 0x12A9788
	void set_ReceiverType(Type value) { }

	// RVA: 0x12A9790
	bool Equals(object obj) { }

	// RVA: 0x12A988C
	int GetHashCode() { }

	// RVA: 0x12A9894
	bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter 
{
	// Methods

	// RVA: 0x12A9900
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12A99CC
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12A9A98
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12A9B88
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12A9EEC
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class HandledEventArgs 
{
	// Fields
	private bool <Handled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12A9EF4
	void .ctor() { }

	// RVA: 0x12A9F60
	void .ctor(bool defaultHandledValue) { }

	// RVA: 0x12A9FD0
	bool get_Handled() { }

	// RVA: 0x12A9FD8
	void set_Handled(bool value) { }

}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler 
{
	// Methods

	// RVA: 0x12A9FE0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12AA104
	internal void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x12AA118
	internal IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12AA174
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public interface IBindingList 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_AllowNew() { }

	// RVA: 0x2FE360C
	object AddNew() { }

	// RVA: 0x2FE3054
	bool get_AllowEdit() { }

	// RVA: 0x2FE3054
	bool get_AllowRemove() { }

	// RVA: 0x2FE3054
	bool get_SupportsChangeNotification() { }

	// RVA: 0x2FE3054
	bool get_SupportsSearching() { }

	// RVA: 0x2FE3054
	bool get_SupportsSorting() { }

	// RVA: 0x2FE3054
	bool get_IsSorted() { }

	// RVA: 0x2FE360C
	PropertyDescriptor get_SortProperty() { }

	// RVA: 0x2FE32D4
	ListSortDirection get_SortDirection() { }

	// RVA: 0x2FE4574
	void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2FE4574
	void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2FE4574
	void AddIndex(PropertyDescriptor property) { }

	// RVA: 0x2FE45DC
	void ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: -1
	int Find(PropertyDescriptor property, object key) { }

	// RVA: 0x2FE4574
	void RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x2FE41A8
	void RemoveSort() { }

}

// Namespace: System.ComponentModel
public interface IBindingListView 
{
	// Methods

	// RVA: 0x2FE4574
	void ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0x2FE360C
	string get_Filter() { }

	// RVA: 0x2FE4574
	void set_Filter(string value) { }

	// RVA: 0x2FE360C
	ListSortDescriptionCollection get_SortDescriptions() { }

	// RVA: 0x2FE41A8
	void RemoveFilter() { }

	// RVA: 0x2FE3054
	bool get_SupportsAdvancedSorting() { }

	// RVA: 0x2FE3054
	bool get_SupportsFiltering() { }

}

// Namespace: System.ComponentModel
public interface ICancelAddNew 
{
	// Methods

	// RVA: 0x2FE42A4
	void CancelNew(int itemIndex) { }

	// RVA: 0x2FE42A4
	void EndNew(int itemIndex) { }

}

// Namespace: System.ComponentModel
public interface IComNativeDescriptorHandler 
{
	// Methods

	// RVA: 0x2FE36BC
	AttributeCollection GetAttributes(object component) { }

	// RVA: 0x2FE36BC
	string GetClassName(object component) { }

	// RVA: 0x2FE36BC
	TypeConverter GetConverter(object component) { }

	// RVA: 0x2FE36BC
	EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x2FE36BC
	PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x2FE37A0
	object GetEditor(object component, Type baseEditorType) { }

	// RVA: 0x2FE36BC
	string GetName(object component) { }

	// RVA: 0x2FE36BC
	EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x2FE37A0
	EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x2FE37A0
	PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x2FE3810
	object GetPropertyValue(object component, string propertyName, ref bool success) { }

	// RVA: -1
	object GetPropertyValue(object component, int dispid, ref bool success) { }

}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor 
{
	// Methods

	// RVA: 0x2FE360C
	AttributeCollection GetAttributes() { }

	// RVA: 0x2FE360C
	string GetClassName() { }

	// RVA: 0x2FE360C
	string GetComponentName() { }

	// RVA: 0x2FE360C
	TypeConverter GetConverter() { }

	// RVA: 0x2FE360C
	EventDescriptor GetDefaultEvent() { }

	// RVA: 0x2FE360C
	PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x2FE36BC
	object GetEditor(Type editorBaseType) { }

	// RVA: 0x2FE360C
	EventDescriptorCollection GetEvents() { }

	// RVA: 0x2FE36BC
	EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x2FE360C
	PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x2FE36BC
	PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x2FE36BC
	object GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: System.ComponentModel
public interface IDataErrorInfo 
{
	// Methods

	// RVA: 0x2FE36BC
	string get_Item(string columnName) { }

	// RVA: 0x2FE360C
	string get_Error() { }

}

// Namespace: System.ComponentModel
public interface IExtenderProvider 
{
	// Methods

	// RVA: 0x2FE3174
	bool CanExtend(object extendee) { }

}

// Namespace: System.ComponentModel
public interface IIntellisenseBuilder 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: -1
	bool Show(string language, string value, ref string newValue) { }

}

// Namespace: System.ComponentModel
public interface IListSource 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_ContainsListCollection() { }

	// RVA: 0x2FE360C
	IList GetList() { }

}

// Namespace: System.ComponentModel
public interface INestedContainer 
{
	// Methods

	// RVA: 0x2FE360C
	IComponent get_Owner() { }

}

// Namespace: System.ComponentModel
public interface INestedSite 
{
	// Methods

	// RVA: 0x2FE360C
	string get_FullName() { }

}

// Namespace: System.ComponentModel
public interface IRaiseItemChangedEvents 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public interface ISupportInitializeNotification 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_IsInitialized() { }

	// RVA: 0x2FE4574
	void add_Initialized(EventHandler value) { }

	// RVA: 0x2FE4574
	void remove_Initialized(EventHandler value) { }

}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext 
{
	// Methods

	// RVA: 0x2FE360C
	IContainer get_Container() { }

	// RVA: 0x2FE360C
	object get_Instance() { }

	// RVA: 0x2FE360C
	PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x2FE3054
	bool OnComponentChanging() { }

	// RVA: 0x2FE41A8
	void OnComponentChanged() { }

}

// Namespace: System.ComponentModel
public interface ITypedList 
{
	// Methods

	// RVA: 0x2FE36BC
	string GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x2FE36BC
	PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) { }

}

// Namespace: System.ComponentModel
public class InstallerTypeAttribute 
{
	// Fields
	private string _typeName; // 0x10

	// Methods

	// RVA: 0x12AA180
	void .ctor(Type installerType) { }

	// RVA: 0x12AA1D0
	void .ctor(string typeName) { }

	// RVA: 0x12AA204
	Type get_InstallerType() { }

	// RVA: 0x12AA298
	bool Equals(object obj) { }

	// RVA: 0x12AA354
	int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor 
{
	// Methods

	// RVA: 0x12AA35C
	string get_Text() { }

	// RVA: 0x2FE37A0
	object CreateInstance(ITypeDescriptorContext context, Type instanceType) { }

	// RVA: 0x12AA3A0
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int16Converter 
{
	// Methods

	// RVA: 0x12AA3A8
	Type get_TargetType() { }

	// RVA: 0x12AA448
	object FromString(string value, int radix) { }

	// RVA: 0x12AA4E4
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AA560
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AA618
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter 
{
	// Methods

	// RVA: 0x12AA620
	Type get_TargetType() { }

	// RVA: 0x12AA6C0
	object FromString(string value, int radix) { }

	// RVA: 0x12AA75C
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AA7D8
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AA890
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter 
{
	// Methods

	// RVA: 0x12AA898
	Type get_TargetType() { }

	// RVA: 0x12AA938
	object FromString(string value, int radix) { }

	// RVA: 0x12AA9D4
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AAA50
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12AAB08
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class InvalidAsynchronousStateException 
{
	// Methods

	// RVA: 0x12AAB10
	void .ctor() { }

	// RVA: 0x12AAB1C
	void .ctor(string message) { }

	// RVA: 0x12AAB24
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x12AAB2C
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private class LicFileLicense 
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12AB09C
	void .ctor(LicFileLicenseProvider owner, string key) { }

	// RVA: 0x12AB104
	string get_LicenseKey() { }

	// RVA: 0x12AB10C
	void Dispose() { }

}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider 
{
	// Methods

	// RVA: 0x12AAB34
	bool IsKeyValid(string key, Type type) { }

	// RVA: 0x12AAB7C
	string GetKey(Type type) { }

	// RVA: 0x12AAC3C
	License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12AB0EC
	void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class License 
{
	// Methods

	// RVA: 0x2FE360C
	string get_LicenseKey() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x12AB0FC
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class LicenseContext 
{
	// Methods

	// RVA: 0x12AB194
	LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12AB19C
	string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x12AB1A4
	object GetService(Type type) { }

	// RVA: 0x12AB1AC
	void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x12AB1B0
	void .ctor() { }

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

	// RVA: 0x12AB1B8
	void .ctor() { }

	// RVA: 0x12AB1C0
	LicenseContext get_CurrentContext() { }

	// RVA: 0x12AB3B0
	void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x12AB550
	LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12AB614
	void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x12AB83C
	object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x12AB93C
	object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x12ABDA8
	bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x12ABE84
	LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x12ABF84
	LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x12AC084
	bool IsLicensed(Type type) { }

	// RVA: 0x12AC220
	bool IsValid(Type type) { }

	// RVA: 0x12AC324
	bool IsValid(Type type, object instance, out License license) { }

	// RVA: 0x12ABC18
	void LockContext(object contextUser) { }

	// RVA: 0x12AC414
	void UnlockContext(object contextUser) { }

	// RVA: 0x12AC188
	bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license) { }

	// RVA: 0x12AC5A8
	bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey) { }

	// RVA: 0x12ACA94
	void Validate(Type type) { }

	// RVA: 0x12ACBCC
	License Validate(Type type, object instance) { }

	// RVA: 0x12ACCFC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class LicenseProvider 
{
	// Methods

	// RVA: -1
	License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12AB0F4
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class LicenseProviderAttribute 
{
	// Fields
	public static readonly LicenseProviderAttribute Default; // 0x0
	private Type _licenseProviderType; // 0x10
	private string _licenseProviderName; // 0x18

	// Methods

	// RVA: 0x12ACDAC
	void .ctor() { }

	// RVA: 0x12ACDDC
	void .ctor(string typeName) { }

	// RVA: 0x12ACE10
	void .ctor(Type type) { }

	// RVA: 0x12AC97C
	Type get_LicenseProvider() { }

	// RVA: 0x12ACE44
	object get_TypeId() { }

	// RVA: 0x12ACF20
	bool Equals(object value) { }

	// RVA: 0x12AD064
	int GetHashCode() { }

	// RVA: 0x12AD06C
	void .cctor() { }

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

	// RVA: 0x12AD0E8
	void .ctor(bool listBindable) { }

	// RVA: 0x12AD114
	void .ctor(BindableSupport flags) { }

	// RVA: 0x12AD154
	bool get_ListBindable() { }

	// RVA: 0x12AD15C
	bool Equals(object obj) { }

	// RVA: 0x12AD20C
	int GetHashCode() { }

	// RVA: 0x12AD214
	bool IsDefaultAttribute() { }

	// RVA: 0x12AD2B0
	void .cctor() { }

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

	// RVA: 0x12AD364
	void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x12AD46C
	void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x12AD508
	void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x12AD3E8
	void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x12AD590
	ListChangedType get_ListChangedType() { }

	// RVA: 0x12AD598
	int get_NewIndex() { }

	// RVA: 0x12AD5A0
	int get_OldIndex() { }

	// RVA: 0x12AD5A8
	PropertyDescriptor get_PropertyDescriptor() { }

}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler 
{
	// Methods

	// RVA: 0x12AD5B0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12AD6D4
	internal void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x12AD6E8
	internal IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12AD744
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x12AD750
	void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x12AD798
	PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x12AD7A0
	void set_PropertyDescriptor(PropertyDescriptor value) { }

	// RVA: 0x12AD7A8
	ListSortDirection get_SortDirection() { }

	// RVA: 0x12AD7B0
	void set_SortDirection(ListSortDirection value) { }

}

// Namespace: System.ComponentModel
public class ListSortDescriptionCollection 
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Methods

	// RVA: 0x12AD7B8
	void .ctor() { }

	// RVA: 0x12AD830
	void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x12AD8FC
	ListSortDescription get_Item(int index) { }

	// RVA: 0x12AD9A0
	void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x12AD9F4
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12AD9FC
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12ADA04
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12ADAA8
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12ADAFC
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x12ADB50
	void System.Collections.IList.Clear() { }

	// RVA: 0x12ADBA4
	bool Contains(object value) { }

	// RVA: 0x12ADC5C
	int IndexOf(object value) { }

	// RVA: 0x12ADD14
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12ADD68
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12ADDBC
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12ADE10
	int get_Count() { }

	// RVA: 0x12ADE38
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12ADE40
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12ADE44
	void CopyTo(Array array, int index) { }

	// RVA: 0x12ADE6C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x12ADE94
	void .ctor() { }

	// RVA: 0x12ADEF4
	void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	// RVA: 0x12ADF74
	string get_DataSource() { }

	// RVA: 0x12ADF7C
	string get_DisplayMember() { }

	// RVA: 0x12ADF84
	string get_ValueMember() { }

	// RVA: 0x12ADF8C
	string get_LookupMember() { }

	// RVA: 0x12ADF94
	bool Equals(object obj) { }

	// RVA: 0x12AE054
	int GetHashCode() { }

	// RVA: 0x12AE05C
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class MarshalByValueComponent 
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Methods

	// RVA: 0x12AE108
	void .ctor() { }

	// RVA: 0x12AE110
	void Finalize() { }

	// RVA: 0x12AE1AC
	void add_Disposed(EventHandler value) { }

	// RVA: 0x12AE338
	void remove_Disposed(EventHandler value) { }

	// RVA: 0x12AE2AC
	EventHandlerList get_Events() { }

	// RVA: 0x12AE438
	ISite get_Site() { }

	// RVA: 0x12AE440
	void set_Site(ISite value) { }

	// RVA: 0x12AE448
	void Dispose() { }

	// RVA: 0x12AE4D8
	void Dispose(bool disposing) { }

	// RVA: 0x12AE784
	IContainer get_Container() { }

	// RVA: 0x12AE848
	object GetService(Type service) { }

	// RVA: 0x12AE90C
	bool get_DesignMode() { }

	// RVA: 0x12AE9D0
	string ToString() { }

	// RVA: 0x12AEB10
	void .cctor() { }

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

	// RVA: 0x12AF5B4
	void .ctor(int maskPos, CharType charType) { }

	// RVA: 0x12B5450
	string ToString() { }

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

	// RVA: 0x12AEB98
	void .ctor(string mask) { }

	// RVA: 0x12AEFF0
	void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x12AF008
	void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x12AF01C
	void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x12AF030
	void .ctor(string mask, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12AF044
	void .ctor(string mask, CultureInfo culture, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12AEBB0
	void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, Char promptChar, Char passwordChar, bool restrictToAscii) { }

	// RVA: 0x12AF15C
	void Initialize() { }

	// RVA: 0x12AF618
	bool get_AllowPromptAsInput() { }

	// RVA: 0x12AF68C
	int get_AssignedEditPositionCount() { }

	// RVA: 0x12AF694
	void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x12AF69C
	int get_AvailableEditPositionCount() { }

	// RVA: 0x12AF6BC
	object Clone() { }

	// RVA: 0x12B0554
	CultureInfo get_Culture() { }

	// RVA: 0x12B055C
	Char get_DefaultPasswordChar() { }

	// RVA: 0x12AF6B0
	int get_EditPositionCount() { }

	// RVA: 0x12B0564
	IEnumerator get_EditPositions() { }

	// RVA: 0x12B0374
	bool get_IncludeLiterals() { }

	// RVA: 0x12B03E8
	void set_IncludeLiterals(bool value) { }

	// RVA: 0x12B0464
	bool get_IncludePrompt() { }

	// RVA: 0x12B04D8
	void set_IncludePrompt(bool value) { }

	// RVA: 0x12B0004
	bool get_AsciiOnly() { }

	// RVA: 0x12B0868
	bool get_IsPassword() { }

	// RVA: 0x12B0878
	void set_IsPassword(bool value) { }

	// RVA: 0x12B0934
	int get_InvalidIndex() { }

	// RVA: 0x12B093C
	int get_LastAssignedPosition() { }

	// RVA: 0x12B0A94
	int get_Length() { }

	// RVA: 0x12B0AB4
	string get_Mask() { }

	// RVA: 0x12B0ABC
	bool get_MaskCompleted() { }

	// RVA: 0x12B0ACC
	bool get_MaskFull() { }

	// RVA: 0x12B0AE4
	Char get_PasswordChar() { }

	// RVA: 0x12B0AEC
	void set_PasswordChar(Char value) { }

	// RVA: 0x12B0CCC
	Char get_PromptChar() { }

	// RVA: 0x12B0CD4
	void set_PromptChar(Char value) { }

	// RVA: 0x12B0218
	bool get_ResetOnPrompt() { }

	// RVA: 0x12B0078
	void set_ResetOnPrompt(bool value) { }

	// RVA: 0x12B028C
	bool get_ResetOnSpace() { }

	// RVA: 0x12B00F4
	void set_ResetOnSpace(bool value) { }

	// RVA: 0x12B0300
	bool get_SkipLiterals() { }

	// RVA: 0x12B0170
	void set_SkipLiterals(bool value) { }

	// RVA: 0x12B0F70
	Char get_Item(int index) { }

	// RVA: 0x12B1030
	bool Add(Char input) { }

	// RVA: 0x12B1058
	bool Add(Char input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1314
	bool Add(string input) { }

	// RVA: 0x12B1340
	bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1460
	void Clear() { }

	// RVA: 0x12B14BC
	void Clear(out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B0A0C
	int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12B15FC
	int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12B11F8
	int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12B17B4
	int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12B1614
	int FindEditPositionInRange(int startPosition, int endPosition, bool direction, Byte assignedStatus) { }

	// RVA: 0x12B190C
	int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12B1970
	int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12B17BC
	int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags) { }

	// RVA: 0x12B1978
	int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12B19DC
	int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12B1B68
	bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x12B1B74
	bool InsertAt(Char input, int position) { }

	// RVA: 0x12B1C6C
	bool InsertAt(Char input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1C40
	bool InsertAt(string input, int position) { }

	// RVA: 0x12B1D0C
	bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1DF0
	bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12B2B90
	bool IsAscii(Char c) { }

	// RVA: 0x12B2BA0
	bool IsAciiAlphanumeric(Char c) { }

	// RVA: 0x12B2BCC
	bool IsAlphanumeric(Char c) { }

	// RVA: 0x12B2C98
	bool IsAsciiLetter(Char c) { }

	// RVA: 0x12B2CAC
	bool IsAvailablePosition(int position) { }

	// RVA: 0x12B0E8C
	bool IsEditPosition(int position) { }

	// RVA: 0x12AF5F0
	bool IsEditPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12B2D9C
	bool IsLiteralPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12AF058
	bool IsPrintableChar(Char c) { }

	// RVA: 0x12B2DC4
	bool IsValidInputChar(Char c) { }

	// RVA: 0x12B2E44
	bool IsValidMaskChar(Char c) { }

	// RVA: 0x12B0C60
	bool IsValidPasswordChar(Char c) { }

	// RVA: 0x12B2EC4
	bool Remove() { }

	// RVA: 0x12B2EFC
	bool Remove(out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B2F60
	bool RemoveAt(int position) { }

	// RVA: 0x12B2FD0
	bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x12B3068
	bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B3110
	bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12B01EC
	bool Replace(Char input, int position) { }

	// RVA: 0x12B3738
	bool Replace(Char input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B3974
	bool Replace(Char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B3EA8
	bool Replace(string input, int position) { }

	// RVA: 0x12B3ED4
	bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B3B04
	bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1528
	void ResetChar(int testPosition) { }

	// RVA: 0x12B3508
	void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x12B401C
	bool Set(string input) { }

	// RVA: 0x12B4048
	bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B29B4
	void SetChar(Char input, int position) { }

	// RVA: 0x12B4240
	void SetChar(Char input, int position, CharDescriptor charDescriptor) { }

	// RVA: 0x12B2A40
	void SetString(string input, int testPosition) { }

	// RVA: 0x12B23F0
	bool TestChar(Char input, int position, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B38E8
	bool TestEscapeChar(Char input, int position) { }

	// RVA: 0x12B4438
	bool TestEscapeChar(Char input, int position, CharDescriptor charDex) { }

	// RVA: 0x12B125C
	bool TestSetChar(Char input, int position, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B1414
	bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B2214
	bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B4618
	string ToDisplayString() { }

	// RVA: 0x12B4850
	string ToString() { }

	// RVA: 0x12B4E08
	string ToString(bool ignorePasswordChar) { }

	// RVA: 0x12B4F08
	string ToString(int startPosition, int length) { }

	// RVA: 0x12B4FFC
	string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x12B50F4
	string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x12B514C
	string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12B494C
	string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12B5164
	bool VerifyChar(Char input, int position, out MaskedTextResultHint hint) { }

	// RVA: 0x12B51E8
	bool VerifyEscapeChar(Char input, int position) { }

	// RVA: 0x12B52A8
	bool VerifyString(string input) { }

	// RVA: 0x12B52F4
	bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x12B5324
	void .cctor() { }

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

	// RVA: 0x12B56A8
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12B5858
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12B5860
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12B5868
	void .ctor() { }

}

// Namespace: 
private class Site 
{
	// Fields
	private string _name; // 0x10
	private readonly IComponent <Component>k__BackingField; // 0x18
	private readonly IContainer <Container>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12B5D64
	void .ctor(IComponent component, NestedContainer container, string name) { }

	// RVA: 0x12B5FA4
	IComponent get_Component() { }

	// RVA: 0x12B5FAC
	IContainer get_Container() { }

	// RVA: 0x12B5FB4
	object GetService(Type service) { }

	// RVA: 0x12B60C8
	bool get_DesignMode() { }

	// RVA: 0x12B62C4
	string get_FullName() { }

	// RVA: 0x12B63C8
	string get_Name() { }

	// RVA: 0x12B63D0
	void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class NestedContainer 
{
	// Fields
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Methods

	// RVA: 0x12B5870
	void .ctor(IComponent owner) { }

	// RVA: 0x12B59E0
	IComponent get_Owner() { }

	// RVA: 0x12B59E8
	string get_OwnerName() { }

	// RVA: 0x12B5C7C
	ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12B5DC8
	void Dispose(bool disposing) { }

	// RVA: 0x12B5ED8
	object GetService(Type service) { }

	// RVA: 0x12B5F9C
	void OnOwnerDisposed(object sender, EventArgs e) { }

}

// Namespace: System.ComponentModel
public class NullableConverter 
{
	// Fields
	private readonly Type <NullableType>k__BackingField; // 0x10
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12B64A8
	void .ctor(Type type) { }

	// RVA: 0x12B65F8
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12B66F4
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12B6868
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12B6964
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12B6BA0
	object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x12B6BC4
	bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12B6BE8
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12B6C0C
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12B6C30
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12B6FE8
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12B7010
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12B7038
	bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12B706C
	Type get_NullableType() { }

	// RVA: 0x12B7074
	Type get_UnderlyingType() { }

	// RVA: 0x12B707C
	TypeConverter get_UnderlyingTypeConverter() { }

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

	// RVA: 0x12B7084
	void .ctor() { }

	// RVA: 0x12B70AC
	void .ctor(bool password) { }

	// RVA: 0x12B70D8
	bool get_Password() { }

	// RVA: 0x12B70E0
	bool Equals(object o) { }

	// RVA: 0x12B7174
	int GetHashCode() { }

	// RVA: 0x12B717C
	bool IsDefaultAttribute() { }

	// RVA: 0x12B71F0
	void .cctor() { }

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

	// RVA: 0x12B72A4
	void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12B72AC
	void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12A9140
	void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: 0x2FE360C
	Type get_ComponentType() { }

	// RVA: 0x12B72B4
	TypeConverter get_Converter() { }

	// RVA: 0x12B79C0
	bool get_IsLocalizable() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x12B7AB4
	DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: 0x2FE360C
	Type get_PropertyType() { }

	// RVA: 0x12B7B94
	void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x2FE3174
	bool CanResetValue(object component) { }

	// RVA: 0x12B7CFC
	bool Equals(object obj) { }

	// RVA: 0x12B7778
	object CreateInstance(Type type) { }

	// RVA: 0x12B7F10
	void FillAttributes(IList attributeList) { }

	// RVA: 0x12B7F6C
	PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x12B7F84
	PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x12B7F9C
	PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x12B7FB0
	PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x12B8068
	object GetEditor(Type editorBaseType) { }

	// RVA: 0x12B8480
	int GetHashCode() { }

	// RVA: 0x12B84D8
	object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x12B7554
	Type GetTypeFromName(string typeName) { }

	// RVA: 0x2FE36BC
	object GetValue(object component) { }

	// RVA: 0x12B85D0
	void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x12B8684
	void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12B87FC
	EventHandler GetValueChangedHandler(object component) { }

	// RVA: 0x2FE4574
	void ResetValue(object component) { }

	// RVA: 0x2FE47D4
	void SetValue(object component, object value) { }

	// RVA: 0x2FE3174
	bool ShouldSerializeValue(object component) { }

	// RVA: 0x12B8898
	bool get_SupportsChangeEvents() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator 
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12BA1F0
	void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x12BAFB0
	object get_Current() { }

	// RVA: 0x12BB05C
	DictionaryEntry get_Entry() { }

	// RVA: 0x12BB0D0
	object get_Key() { }

	// RVA: 0x12BB110
	object get_Value() { }

	// RVA: 0x12BB150
	bool MoveNext() { }

	// RVA: 0x12BB190
	void Reset() { }

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

	// RVA: 0x12B88A0
	void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x12B89F4
	void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x12B8A1C
	void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12B8B74
	int get_Count() { }

	// RVA: 0x12B8B7C
	void set_Count(int value) { }

	// RVA: 0x12B8B84
	PropertyDescriptor get_Item(int index) { }

	// RVA: 0x12B8CD4
	PropertyDescriptor get_Item(string name) { }

	// RVA: 0x12B8CE8
	int Add(PropertyDescriptor value) { }

	// RVA: 0x12B8EDC
	void Clear() { }

	// RVA: 0x12B8F3C
	bool Contains(PropertyDescriptor value) { }

	// RVA: 0x12B9010
	void CopyTo(Array array, int index) { }

	// RVA: 0x12B8C0C
	void EnsurePropsOwned() { }

	// RVA: 0x12B8DBC
	void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12B9378
	PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12B8FAC
	int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x12B994C
	void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x12B9A40
	void Remove(PropertyDescriptor value) { }

	// RVA: 0x12B9B04
	void RemoveAt(int index) { }

	// RVA: 0x12B9BCC
	PropertyDescriptorCollection Sort() { }

	// RVA: 0x12B9C50
	PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12B9CD8
	PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12B9D60
	PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12B9058
	void InternalSort(string[] names) { }

	// RVA: 0x12B9DE4
	void InternalSort(IComparer sorter) { }

	// RVA: 0x12B9E84
	IEnumerator GetEnumerator() { }

	// RVA: 0x12B9F20
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12B9F28
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12B9F30
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12B9F38
	void System.Collections.IList.Clear() { }

	// RVA: 0x12B9F98
	void System.Collections.IDictionary.Clear() { }

	// RVA: 0x12B9FF8
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12BA008
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12BA00C
	void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x12BA0DC
	bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x12BA174
	IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x12BA22C
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x12BA234
	bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x12BA23C
	object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x12BA2C8
	void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x12BA6BC
	ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x12BA7CC
	ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x12BA8D0
	void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x12BA9D4
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x12BAA64
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12BAB34
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12BABF8
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12BAC90
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12BAC98
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12BACA0
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12BAD30
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12BAD40
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12BAF3C
	void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute 
{
	// Fields
	private readonly string <PropertyName>k__BackingField; // 0x10
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12BB19C
	void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x12BB208
	void .ctor(string propertyName, string receiverTypeName) { }

	// RVA: 0x12BB258
	string get_PropertyName() { }

	// RVA: 0x12BB260
	string get_ReceiverTypeName() { }

	// RVA: 0x12BB268
	bool Equals(object obj) { }

	// RVA: 0x12BB330
	int GetHashCode() { }

	// RVA: 0x12BB380
	object get_TypeId() { }

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

	// RVA: 0x12BB3C4
	void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x12BB3F0
	bool get_RecommendedAsConfigurable() { }

	// RVA: 0x12BB3F8
	bool Equals(object obj) { }

	// RVA: 0x12BB4C4
	int GetHashCode() { }

	// RVA: 0x12BB4CC
	bool IsDefaultAttribute() { }

	// RVA: 0x12BB4DC
	void .cctor() { }

}

// Namespace: 
private class ReferenceComparer 
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x12BC664
	void .ctor(ReferenceConverter converter) { }

	// RVA: 0x12BC728
	int Compare(object item1, object item2) { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter 
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x12BB590
	void .ctor(Type type) { }

	// RVA: 0x12BB5C4
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12BB694
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12BBA28
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12BBF18
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12BC698
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12BC6A0
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12BC6A8
	bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12BC6B0
	void .cctor() { }

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

	// RVA: 0x12BC7DC
	void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12BC990
	void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x12BCB48
	void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x12BCC44
	Type get_ComponentType() { }

	// RVA: 0x12BCC4C
	Type get_EventType() { }

	// RVA: 0x12BD1C8
	bool get_IsMulticast() { }

	// RVA: 0x12BD27C
	void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x12BDA28
	void FillAttributes(IList attributes) { }

	// RVA: 0x12BDAA8
	void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x12BCC70
	void FillMethods() { }

	// RVA: 0x12BDE20
	void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x12BE1D8
	void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs 
{
	// Fields
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12BE8D4
	void .ctor(object componentChanged) { }

	// RVA: 0x12BE970
	void .ctor(Type typeChanged) { }

	// RVA: 0x12BE9E8
	object get_ComponentChanged() { }

	// RVA: 0x12BE9F0
	Type get_TypeChanged() { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler 
{
	// Methods

	// RVA: 0x12BE9F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12BEB18
	internal void Invoke(RefreshEventArgs e) { }

	// RVA: 0x12BEB2C
	internal IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12BEB7C
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x12BEB88
	void .ctor(bool runInstaller) { }

	// RVA: 0x12BEBB4
	bool get_RunInstaller() { }

	// RVA: 0x12BEBBC
	bool Equals(object obj) { }

	// RVA: 0x12BEC88
	int GetHashCode() { }

	// RVA: 0x12BEC90
	bool IsDefaultAttribute() { }

	// RVA: 0x12BED04
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class SByteConverter 
{
	// Methods

	// RVA: 0x12BEDB8
	Type get_TargetType() { }

	// RVA: 0x12BEE58
	object FromString(string value, int radix) { }

	// RVA: 0x12BEEF4
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12BEF70
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12BF028
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class SettingsBindableAttribute 
{
	// Fields
	public static readonly SettingsBindableAttribute Yes; // 0x0
	public static readonly SettingsBindableAttribute No; // 0x8
	private readonly bool <Bindable>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12BF030
	void .ctor(bool bindable) { }

	// RVA: 0x12BF05C
	bool get_Bindable() { }

	// RVA: 0x12BF064
	bool Equals(object obj) { }

	// RVA: 0x12BF114
	int GetHashCode() { }

	// RVA: 0x12BF18C
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter 
{
	// Methods

	// RVA: 0x12BF22C
	bool get_AllowHex() { }

	// RVA: 0x12BF234
	Type get_TargetType() { }

	// RVA: 0x12BF2D4
	object FromString(string value, int radix) { }

	// RVA: 0x12BF39C
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12BF418
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12BF4D0
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter 
{
	// Methods

	// RVA: 0x12BF4D8
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12BF5A4
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12BF64C
	void .ctor() { }

}

// Namespace: System.ComponentModel
public static class SyntaxCheck 
{
	// Methods

	// RVA: 0x12BF654
	bool CheckMachineName(string value) { }

	// RVA: 0x12BF6F4
	bool CheckPath(string value) { }

	// RVA: 0x12BF79C
	bool CheckRootedPath(string value) { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter 
{
	// Methods

	// RVA: 0x12BF864
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12BF930
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12BF9FC
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12BFC00
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12BFF40
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class ToolboxItemFilterAttribute 
{
	// Fields
	private string _typeId; // 0x10
	private readonly string <FilterString>k__BackingField; // 0x18
	private readonly ToolboxItemFilterType <FilterType>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12BFF48
	void .ctor(string filterString) { }

	// RVA: 0x12BFFE4
	void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	// RVA: 0x12C0084
	string get_FilterString() { }

	// RVA: 0x12C008C
	ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x12C0094
	object get_TypeId() { }

	// RVA: 0x12C011C
	bool Equals(object obj) { }

	// RVA: 0x12C0240
	int GetHashCode() { }

	// RVA: 0x12C0264
	bool Match(object obj) { }

	// RVA: 0x12C02F0
	string ToString() { }

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

	// RVA: 0x12C0410
	void .ctor() { }

	// RVA: 0x12C047C
	void .ctor(Type type) { }

	// RVA: 0x12C04CC
	void .ctor(string typeName) { }

	// RVA: 0x12C0500
	string get_ConverterTypeName() { }

	// RVA: 0x12C0508
	bool Equals(object obj) { }

	// RVA: 0x12C058C
	int GetHashCode() { }

	// RVA: 0x12C05B0
	void .cctor() { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor 
{
	// Methods

	// RVA: 0x12C087C
	void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider 
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x12A4D24
	void .ctor() { }

	// RVA: 0x12C0668
	void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x12C069C
	object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12C07AC
	IDictionary GetCache(object instance) { }

	// RVA: 0x12C07C4
	ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12C0884
	IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12C09E0
	string GetFullComponentName(object component) { }

	// RVA: 0x12C0B64
	Type GetReflectionType(Type objectType) { }

	// RVA: 0x12C0B74
	Type GetReflectionType(object instance) { }

	// RVA: 0x12C0C00
	Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12C0C1C
	Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x12C0DA8
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x12C0AD8
	ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x12C0DB8
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12C0E78
	bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute 
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12C0F7C
	void .ctor(string typeName) { }

	// RVA: 0x12C0FFC
	void .ctor(Type type) { }

	// RVA: 0x12C1118
	string get_TypeName() { }

}

// Namespace: System.ComponentModel
public abstract class TypeListConverter 
{
	// Fields
	private readonly Type[] _types; // 0x10
	private StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x12C1120
	void .ctor(Type[] types) { }

	// RVA: 0x12C1154
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C1220
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12C12EC
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C1400
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C15E4
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12C16C8
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12C16D0
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
public class UInt16Converter 
{
	// Methods

	// RVA: 0x12C16D8
	Type get_TargetType() { }

	// RVA: 0x12C1778
	object FromString(string value, int radix) { }

	// RVA: 0x12C1814
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1890
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1948
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter 
{
	// Methods

	// RVA: 0x12C1950
	Type get_TargetType() { }

	// RVA: 0x12C19F0
	object FromString(string value, int radix) { }

	// RVA: 0x12C1A8C
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1B08
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1BC0
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter 
{
	// Methods

	// RVA: 0x12C1BC8
	Type get_TargetType() { }

	// RVA: 0x12C1C68
	object FromString(string value, int radix) { }

	// RVA: 0x12C1D04
	object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1D80
	string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12C1E38
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class WarningException 
{
	// Fields
	private readonly string <HelpUrl>k__BackingField; // 0x90
	private readonly string <HelpTopic>k__BackingField; // 0x98

	// Methods

	// RVA: 0x12C1E40
	void .ctor() { }

	// RVA: 0x12C1ED4
	void .ctor(string message) { }

	// RVA: 0x12C1F14
	void .ctor(string message, string helpUrl) { }

	// RVA: 0x12C1F58
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x12C1E84
	void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x12C1F60
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12C2108
	string get_HelpUrl() { }

	// RVA: 0x12C2110
	string get_HelpTopic() { }

	// RVA: 0x12C2118
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public class CancelEventArgs 
{
	// Fields
	private bool <Cancel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12C21D0
	bool get_Cancel() { }

	// RVA: 0x12C21D8
	void set_Cancel(bool value) { }

	// RVA: 0x12C21E0
	void .ctor() { }

	// RVA: 0x12C2268
	void .ctor(bool cancel) { }

}

// Namespace: System.ComponentModel
public interface IChangeTracking 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_IsChanged() { }

	// RVA: 0x2FE41A8
	void AcceptChanges() { }

}

// Namespace: System.ComponentModel
public interface IEditableObject 
{
	// Methods

	// RVA: 0x2FE41A8
	void BeginEdit() { }

	// RVA: 0x2FE41A8
	void EndEdit() { }

	// RVA: 0x2FE41A8
	void CancelEdit() { }

}

// Namespace: System.ComponentModel
public interface IRevertibleChangeTracking 
{
	// Methods

	// RVA: 0x2FE41A8
	void RejectChanges() { }

}

// Namespace: System.ComponentModel
public class DataErrorsChangedEventArgs 
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12C22D8
	void .ctor(string propertyName) { }

	// RVA: 0x12C2350
	string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public interface INotifyDataErrorInfo 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_HasErrors() { }

	// RVA: 0x2FE36BC
	IEnumerable GetErrors(string propertyName) { }

	// RVA: 0x2FE4574
	void add_ErrorsChanged(System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> value) { }

	// RVA: 0x2FE4574
	void remove_ErrorsChanged(System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> value) { }

}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanged 
{
	// Methods

	// RVA: 0x2FE4574
	void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0x2FE4574
	void remove_PropertyChanged(PropertyChangedEventHandler value) { }

}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanging 
{
	// Methods

	// RVA: 0x2FE4574
	void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0x2FE4574
	void remove_PropertyChanging(PropertyChangingEventHandler value) { }

}

// Namespace: System.ComponentModel
public class PropertyChangedEventArgs 
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12C2358
	void .ctor(string propertyName) { }

	// RVA: 0x12C23D0
	string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler 
{
	// Methods

	// RVA: 0x12C23D8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C24FC
	internal void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x12C2510
	internal IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C256C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs 
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12C2578
	void .ctor(string propertyName) { }

	// RVA: 0x12C25F0
	string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler 
{
	// Methods

	// RVA: 0x12C25F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C271C
	internal void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x12C2730
	internal IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C278C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
internal class ArraySubsetEnumerator 
{
	// Fields
	private Array array; // 0x10
	private int total; // 0x18
	private int current; // 0x1C

	// Methods

	// RVA: 0x12C2798
	void .ctor(Array array, int count) { }

	// RVA: 0x12C27E4
	bool MoveNext() { }

	// RVA: 0x12C2808
	void Reset() { }

	// RVA: 0x12C2814
	object get_Current() { }

}

// Namespace: System.ComponentModel
public class AsyncCompletedEventArgs 
{
	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Methods

	// RVA: 0x12C287C
	void .ctor() { }

	// RVA: 0x12C2904
	void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x12C29A0
	bool get_Cancelled() { }

	// RVA: 0x12C29A8
	Exception get_Error() { }

	// RVA: 0x12C29B0
	object get_UserState() { }

	// RVA: 0x12C29B8
	void RaiseExceptionIfNecessary() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler 
{
	// Methods

	// RVA: 0x12C2A98
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C2BBC
	internal void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x12C2BD0
	internal IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C2C2C
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x12C2C38
	CategoryAttribute get_Action() { }

	// RVA: 0x12C2D3C
	CategoryAttribute get_Appearance() { }

	// RVA: 0x12C2E0C
	CategoryAttribute get_Asynchronous() { }

	// RVA: 0x12C2ED4
	CategoryAttribute get_Behavior() { }

	// RVA: 0x12C2F9C
	CategoryAttribute get_Data() { }

	// RVA: 0x12C3064
	CategoryAttribute get_Default() { }

	// RVA: 0x12C31B4
	CategoryAttribute get_Design() { }

	// RVA: 0x12C327C
	CategoryAttribute get_DragDrop() { }

	// RVA: 0x12C3344
	CategoryAttribute get_Focus() { }

	// RVA: 0x12C340C
	CategoryAttribute get_Format() { }

	// RVA: 0x12C34D4
	CategoryAttribute get_Key() { }

	// RVA: 0x12C359C
	CategoryAttribute get_Layout() { }

	// RVA: 0x12C3664
	CategoryAttribute get_Mouse() { }

	// RVA: 0x12C372C
	CategoryAttribute get_WindowStyle() { }

	// RVA: 0x12C3144
	void .ctor() { }

	// RVA: 0x12C2D00
	void .ctor(string category) { }

	// RVA: 0x12C37F4
	string get_Category() { }

	// RVA: 0x12C3860
	bool Equals(object obj) { }

	// RVA: 0x12C39D0
	int GetHashCode() { }

	// RVA: 0x12C3A3C
	string GetLocalizedString(string value) { }

	// RVA: 0x12C3D90
	bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CollectionConverter 
{
	// Methods

	// RVA: 0x12C3E50
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C4254
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12C425C
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12C4264
	void .ctor() { }

}

// Namespace: System.ComponentModel
internal static class CompModSwitches 
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Methods

	// RVA: 0x12C4274
	BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x12C4354
	TraceSwitch get_EventLog() { }

}

// Namespace: System.ComponentModel
public class Component 
{
	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Methods

	// RVA: 0x12C442C
	void Finalize() { }

	// RVA: 0x12C44CC
	bool get_CanRaiseEvents() { }

	// RVA: 0x12C44D4
	bool get_CanRaiseEventsInternal() { }

	// RVA: 0x12C44E0
	void add_Disposed(EventHandler value) { }

	// RVA: 0x12C4698
	void remove_Disposed(EventHandler value) { }

	// RVA: 0x12C45F8
	EventHandlerList get_Events() { }

	// RVA: 0x12C47B0
	ISite get_Site() { }

	// RVA: 0x12C47B8
	void set_Site(ISite value) { }

	// RVA: 0x12C47C0
	void Dispose() { }

	// RVA: 0x12C4854
	void Dispose(bool disposing) { }

	// RVA: 0x12C4B80
	IContainer get_Container() { }

	// RVA: 0x12C4C44
	object GetService(Type service) { }

	// RVA: 0x12C4D08
	bool get_DesignMode() { }

	// RVA: 0x12C4DCC
	string ToString() { }

	// RVA: 0x12C4F0C
	void .ctor() { }

	// RVA: 0x12C4F14
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentConverter 
{
	// Methods

	// RVA: 0x12C4F9C
	void .ctor(Type type) { }

	// RVA: 0x12C5008
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12C51E0
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private class Site 
{
	// Fields
	private IComponent component; // 0x10
	private Container container; // 0x18
	private string name; // 0x20

	// Methods

	// RVA: 0x12C57F0
	void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x12C6A2C
	IComponent get_Component() { }

	// RVA: 0x12C6A34
	IContainer get_Container() { }

	// RVA: 0x12C6A3C
	object GetService(Type service) { }

	// RVA: 0x12C6B10
	bool get_DesignMode() { }

	// RVA: 0x12C6B18
	string get_Name() { }

	// RVA: 0x12C6B20
	void set_Name(string value) { }

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

	// RVA: 0x12C51E8
	void Finalize() { }

	// RVA: 0x12C5284
	void Add(IComponent component) { }

	// RVA: 0x12C5294
	void Add(IComponent component, string name) { }

	// RVA: 0x12C574C
	ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12C5854
	void Dispose() { }

	// RVA: 0x12C58E4
	void Dispose(bool disposing) { }

	// RVA: 0x12C5C34
	object GetService(Type service) { }

	// RVA: 0x12C5CD8
	ComponentCollection get_Components() { }

	// RVA: 0x12C6174
	void Remove(IComponent component) { }

	// RVA: 0x12C617C
	void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x12C6494
	void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x12C649C
	void ValidateName(IComponent component, string name) { }

	// RVA: 0x12C69B4
	void .ctor() { }

}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter 
{
	// Methods

	// RVA: 0x12C6B98
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C6D2C
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12C6EC0
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C731C
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C7FA8
	void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignerAttribute 
{
	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Methods

	// RVA: 0x12C7FB0
	void .ctor(string designerTypeName) { }

	// RVA: 0x12C80DC
	void .ctor(Type designerType) { }

	// RVA: 0x12C81B8
	void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x12C8290
	void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x12C8384
	void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x12C8408
	string get_DesignerBaseTypeName() { }

	// RVA: 0x12C8410
	string get_DesignerTypeName() { }

	// RVA: 0x12C8418
	object get_TypeId() { }

	// RVA: 0x12C84D4
	bool Equals(object obj) { }

	// RVA: 0x12C859C
	int GetHashCode() { }

}

// Namespace: System.ComponentModel
public class DoWorkEventArgs 
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Methods

	// RVA: 0x12C85EC
	void .ctor(object argument) { }

	// RVA: 0x12C8620
	object get_Argument() { }

	// RVA: 0x12C8628
	object get_Result() { }

	// RVA: 0x12C8630
	void set_Result(object value) { }

}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler 
{
	// Methods

	// RVA: 0x12C8638
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12C875C
	internal void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x12C8770
	internal IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12C87CC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class EnumConverter 
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x12C87D8
	void .ctor(Type type) { }

	// RVA: 0x12C880C
	Type get_EnumType() { }

	// RVA: 0x12C8814
	StandardValuesCollection get_Values() { }

	// RVA: 0x12C881C
	void set_Values(StandardValuesCollection value) { }

	// RVA: 0x12C8824
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12C8974
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12C8AC4
	IComparer get_Comparer() { }

	// RVA: 0x12C8B40
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12C90B8
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12C9F9C
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12CA5DC
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12CA6A8
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12CA6B0
	bool IsValid(ITypeDescriptorContext context, object value) { }

}

// Namespace: System.ComponentModel
public interface IComponent 
{
	// Methods

	// RVA: 0x2FE360C
	ISite get_Site() { }

	// RVA: 0x2FE4574
	void set_Site(ISite value) { }

	// RVA: 0x2FE4574
	void add_Disposed(EventHandler value) { }

	// RVA: 0x2FE4574
	void remove_Disposed(EventHandler value) { }

}

// Namespace: System.ComponentModel
internal static class IntSecurity 
{
	// Methods

	// RVA: 0x12CA720
	string UnsafeGetFullPath(string fileName) { }

}

// Namespace: System.ComponentModel
public class LicenseException 
{
	// Fields
	private Type type; // 0x90
	private object instance; // 0x98

	// Methods

	// RVA: 0x12CA7A8
	void .ctor(Type type) { }

	// RVA: 0x12CA938
	void .ctor(Type type, object instance) { }

	// RVA: 0x12CA8D4
	void .ctor(Type type, object instance, string message) { }

	// RVA: 0x12CAAC4
	void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x12CAB2C
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12CACD8
	Type get_LicensedType() { }

	// RVA: 0x12CACE0
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0x12CADDC
	void .ctor(string name) { }

	// RVA: 0x12CADE4
	void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x12CAFD0
	void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12CB128
	void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x12CB584
	Attribute[] get_AttributeArray() { }

	// RVA: 0x12CBE08
	void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x12CBF08
	AttributeCollection get_Attributes() { }

	// RVA: 0x12CC01C
	string get_Category() { }

	// RVA: 0x12CC184
	string get_Description() { }

	// RVA: 0x12CC2B4
	bool get_IsBrowsable() { }

	// RVA: 0x12CC394
	string get_Name() { }

	// RVA: 0x12CC3F0
	int get_NameHashCode() { }

	// RVA: 0x12CC3F8
	bool get_DesignTimeOnly() { }

	// RVA: 0x12CC4EC
	string get_DisplayName() { }

	// RVA: 0x12CB5B0
	void CheckAttributesValid() { }

	// RVA: 0x12CC614
	AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x12CC690
	bool Equals(object obj) { }

	// RVA: 0x12CC918
	void FillAttributes(IList attributeList) { }

	// RVA: 0x12CB6A4
	void FilterAttributesIfNeeded() { }

	// RVA: 0x12CCA10
	MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x12CCA8C
	MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x12CCB54
	int GetHashCode() { }

	// RVA: 0x12CCB5C
	object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x12CD2F0
	ISite GetSite(object component) { }

	// RVA: 0x12CD410
	object GetInvokee(Type componentClass, object component) { }

}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs 
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Methods

	// RVA: 0x12CD554
	void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x12CD5DC
	int get_ProgressPercentage() { }

	// RVA: 0x12CD5E4
	object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler 
{
	// Methods

	// RVA: 0x12CD5EC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12CD710
	internal void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x12CD724
	internal IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12CD780
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x12CD78C
	void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12CDA7C
	void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x12CDBD8
	void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x12CDCD0
	void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x12CE190
	object get_AmbientValue() { }

	// RVA: 0x12CE34C
	EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x12CE6B8
	EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x12CE8BC
	void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x12CE948
	Type get_ComponentType() { }

	// RVA: 0x12CE950
	object get_DefaultValue() { }

	// RVA: 0x12CEC40
	MethodInfo get_GetMethodValue() { }

	// RVA: 0x12CF148
	bool get_IsExtender() { }

	// RVA: 0x12CF1B4
	bool get_IsReadOnly() { }

	// RVA: 0x12CF8E4
	Type get_PropertyType() { }

	// RVA: 0x12CF8EC
	MethodInfo get_ResetMethodValue() { }

	// RVA: 0x12CF2C8
	MethodInfo get_SetMethodValue() { }

	// RVA: 0x12CFBB4
	MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x12CFE7C
	void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12D0034
	bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12D048C
	Type ExtenderGetReceiverType() { }

	// RVA: 0x12D0494
	Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x12D0340
	object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12D04A4
	void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x12D09C4
	void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x12D0E78
	bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x12D1354
	bool CanResetValue(object component) { }

	// RVA: 0x12D1674
	void FillAttributes(IList attributes) { }

	// RVA: 0x12D27F8
	object GetValue(object component) { }

	// RVA: 0x12D2B34
	void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x12D2C3C
	void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x12D2D20
	void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12D2EDC
	void ResetValue(object component) { }

	// RVA: 0x12D3350
	void SetValue(object component, object value) { }

	// RVA: 0x12D3960
	bool ShouldSerializeValue(object component) { }

	// RVA: 0x12D3CE8
	bool get_SupportsChangeEvents() { }

	// RVA: 0x12D3D2C
	void .cctor() { }

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

	// RVA: 0x12DAFE0
	void .ctor(Type type) { }

	// RVA: 0x12DABB8
	bool get_IsPopulated() { }

	// RVA: 0x12D53D8
	AttributeCollection GetAttributes() { }

	// RVA: 0x12D5D24
	string GetClassName(object instance) { }

	// RVA: 0x12D5D7C
	string GetComponentName(object instance) { }

	// RVA: 0x12D5F98
	TypeConverter GetConverter(object instance) { }

	// RVA: 0x12D650C
	EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x12D67B8
	PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x12D6ABC
	object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x12DD6D8
	EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x12D7660
	EventDescriptorCollection GetEvents() { }

	// RVA: 0x12DABF4
	PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x12DD1FC
	Type GetTypeFromName(string typeName) { }

	// RVA: 0x12DC44C
	void Refresh() { }

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

	// RVA: 0x12D3F90
	Guid get_ExtenderProviderKey() { }

	// RVA: 0x12D400C
	void .ctor() { }

	// RVA: 0x12D4014
	Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x12D4ACC
	void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x12D4DA0
	object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12D4FD8
	object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x12D5110
	AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x12D5924
	IDictionary GetCache(object instance) { }

	// RVA: 0x12D5CF0
	string GetClassName(Type type) { }

	// RVA: 0x12D5D4C
	string GetComponentName(Type type, object instance) { }

	// RVA: 0x12D5F68
	TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x12D64DC
	EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x12D6788
	PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x12D6A84
	object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x12D71AC
	Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x12D7640
	EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x12D7A44
	AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x12D7AC0
	string GetExtendedClassName(object instance) { }

	// RVA: 0x12D7B18
	string GetExtendedComponentName(object instance) { }

	// RVA: 0x12D7B64
	TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x12D7BB0
	EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x12D7BB8
	PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x12D7BC0
	object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x12D7C1C
	EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x12D7C98
	PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x12D92CC
	IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12D978C
	IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x12DA330
	object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x12DA45C
	ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12DA464
	string GetFullComponentName(object component) { }

	// RVA: 0x12DA6E0
	Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x12DABD4
	PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x12DA3D0
	object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x12DAFD8
	Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12D5130
	ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x12DB014
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12DB01C
	Type GetTypeFromName(string typeName) { }

	// RVA: 0x12DB138
	bool IsPopulated(Type type) { }

	// RVA: 0x12DB16C
	Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x12D2358
	Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x12DB60C
	EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x12D8300
	PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x12DBD3C
	PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x12DC3C4
	void Refresh(Type type) { }

	// RVA: 0x12DC4C8
	object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x12DCEC0
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs 
{
	// Fields
	private object result; // 0x28

	// Methods

	// RVA: 0x12DDA78
	void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x12DDB24
	object get_Result() { }

	// RVA: 0x12DDB48
	object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler 
{
	// Methods

	// RVA: 0x12DDB50
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DDC74
	internal void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x12DDC88
	internal IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12DDCE4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor 
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Methods

	// RVA: 0x12DE9C4
	void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x12DEA60
	void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x12DEAB8
	Type get_ComponentType() { }

	// RVA: 0x12DEAC0
	bool get_IsReadOnly() { }

	// RVA: 0x12DEB4C
	Type get_PropertyType() { }

	// RVA: 0x12DEB54
	bool CanResetValue(object component) { }

	// RVA: 0x12DECA4
	void ResetValue(object component) { }

	// RVA: 0x12DEDDC
	bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public class StandardValuesCollection 
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Methods

	// RVA: 0x12CA50C
	void .ctor(ICollection values) { }

	// RVA: 0x12DEDE4
	int get_Count() { }

	// RVA: 0x12DEEB4
	object get_Item(int index) { }

	// RVA: 0x12DF0C0
	void CopyTo(Array array, int index) { }

	// RVA: 0x12DF17C
	IEnumerator GetEnumerator() { }

	// RVA: 0x12DF230
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12DF234
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12DF23C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12DF244
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12DF300
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public class TypeConverter 
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = 5708593888;
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x12DDCF0
	bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x12DDD44
	bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x12C6CA0
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12DDD58
	bool CanConvertTo(Type destinationType) { }

	// RVA: 0x12C6E34
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12DDD6C
	object ConvertFrom(object value) { }

	// RVA: 0x12C72A4
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12DDF20
	object ConvertFromInvariantString(string text) { }

	// RVA: 0x12DDFAC
	object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x12DE038
	object ConvertFromString(string text) { }

	// RVA: 0x12DE050
	object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x12DDFA0
	object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x12DE0DC
	object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x12C3FE8
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12DE274
	string ConvertToInvariantString(object value) { }

	// RVA: 0x12C9F18
	string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12DE3D4
	string ConvertToString(object value) { }

	// RVA: 0x12DE4DC
	string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12DE2EC
	string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12DE5E8
	object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x12DE5FC
	object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x12DDDEC
	Exception GetConvertFromException(object value) { }

	// RVA: 0x12DE0F8
	Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x12DE604
	bool GetCreateInstanceSupported() { }

	// RVA: 0x12DE614
	bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE61C
	PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x12DE628
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12DE724
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12DE72C
	bool GetPropertiesSupported() { }

	// RVA: 0x12DE73C
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE744
	ICollection GetStandardValues() { }

	// RVA: 0x12DE754
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12DE75C
	bool GetStandardValuesExclusive() { }

	// RVA: 0x12DE770
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12DE778
	bool GetStandardValuesSupported() { }

	// RVA: 0x12DE78C
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12DE794
	bool IsValid(object value) { }

	// RVA: 0x12DE7AC
	bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12DE980
	PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x12C426C
	void .ctor() { }

}

// Namespace: 
private class AttributeTypeDescriptor 
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x12ECB08
	void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x12ECB40
	AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class AttributeProvider 
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x12ECA30
	void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x12ECA64
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor 
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x12ED00C
	void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x12ED05C
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x12ED11C
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x12ED1E0
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x12ED1E8
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12ED2AC
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x12ED370
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x12ED434
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x12ED4F4
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x12ED5B8
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x12ED678
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x12ED72C
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x12ED7EC
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider 
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Methods

	// RVA: 0x12ECE04
	void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x12ECE38
	IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x12ECE40
	void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x12ECE48
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem 
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x12ED7F4
	void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x12ED844
	bool IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem 
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x12ED8BC
	void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x12ED90C
	bool IsValid(ITypeDescriptorFilterService filterService) { }

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

	// RVA: 0x12ED91C
	int Compare(object left, object right) { }

	// RVA: 0x12EDA40
	void .ctor() { }

	// RVA: 0x12EDA48
	void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor 
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x12EDAB4
	void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x12EDB04
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x12EDC44
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x12EDD8C
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x12EDED4
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12EE01C
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x12EE164
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x12EE2AC
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x12EE490
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x12EE5D8
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x12EE71C
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x12EE864
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x12EE9A8
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor 
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x12EEE1C
	void .ctor(TypeDescriptionNode node, object instance) { }

	// RVA: 0x12EF448
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x12EF75C
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x12EF9A4
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x12EFBC0
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12EFE70
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x12F008C
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x12F02A8
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x12F0568
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x12F0880
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x12F0BB4
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x12F0E64
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x12F112C
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultTypeDescriptor 
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private Type _objectType; // 0x18
	private object _instance; // 0x20

	// Methods

	// RVA: 0x12EF304
	void .ctor(TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x12F1378
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x12F1628
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x12F1868
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x12F1A84
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12F1D34
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x12F1F50
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x12F216C
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x12F242C
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x12F26E0
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x12F29AC
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x12F2C60
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x12F2F2C
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class TypeDescriptionNode 
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x12EEAEC
	void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x12EEB20
	object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12EECC4
	IDictionary GetCache(object instance) { }

	// RVA: 0x12EED3C
	ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12EEE50
	IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12EEEC8
	string GetFullComponentName(object component) { }

	// RVA: 0x12EEF40
	Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12EF044
	Type GetRuntimeType(Type objectType) { }

	// RVA: 0x12EF138
	ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12EF354
	bool IsSupportedType(Type type) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject 
{
	// Methods

	// RVA: 0x12F3178
	void .ctor() { }

}

// Namespace: 
private sealed class TypeDescriptorInterface 
{
	// Methods

	// RVA: 0x12F3180
	void .ctor() { }

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

	// RVA: 0x12DF3B4
	void .ctor() { }

	// RVA: 0x12DF3BC
	IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x12DF640
	void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x12DF518
	Type get_ComObjectType() { }

	// RVA: 0x12DFB14
	Type get_InterfaceType() { }

	// RVA: 0x12DFBB4
	int get_MetadataVersion() { }

	// RVA: 0x12DFC30
	void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x12DFD20
	void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x12DFE10
	TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0x12E009C
	TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	// RVA: 0x12E0528
	void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x12DF868
	void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x12E0274
	void AddProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x12E1C3C
	void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x12E1D60
	void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x12E1E50
	void CheckDefaultProvider(Type type) { }

	// RVA: 0x12E24B0
	void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x12E2C58
	IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x12E3170
	EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12E31F8
	EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x12E3278
	object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12E35D4
	PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12E3658
	PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x12E3834
	void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x12E3838
	void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x12E383C
	void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0x12E3840
	void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x12E3844
	void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0x12E3848
	void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x12E384C
	void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0x12E3850
	void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x12E3854
	void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0x12E3858
	void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x12E385C
	ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0x12CCCA0
	object GetAssociation(Type type, object primary) { }

	// RVA: 0x12D21BC
	AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x12C692C
	AttributeCollection GetAttributes(object component) { }

	// RVA: 0x12E3EA4
	AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12D8220
	IDictionary GetCache(object instance) { }

	// RVA: 0x12E79C4
	string GetClassName(object component) { }

	// RVA: 0x12E7A4C
	string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E7B60
	string GetClassName(Type componentType) { }

	// RVA: 0x12DA658
	string GetComponentName(object component) { }

	// RVA: 0x12E7C8C
	string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E7DA0
	TypeConverter GetConverter(object component) { }

	// RVA: 0x12E7E28
	TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E7F3C
	TypeConverter GetConverter(Type type) { }

	// RVA: 0x12E8068
	object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x12E814C
	EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x12E82C0
	EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x12E8348
	EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E8458
	PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x12E85CC
	PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x12E8654
	PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E3D40
	ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x12E42BC
	ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E4530
	ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x12E8764
	object GetEditor(object component, Type editorBaseType) { }

	// RVA: 0x12E87D0
	object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x12E8964
	object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x12CE514
	EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x12E8B00
	EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x12DD408
	EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x12E9260
	EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12E92CC
	EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x12E8D94
	EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x12E99E4
	string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x12E9D3C
	string GetFullComponentName(object component) { }

	// RVA: 0x12E9DF8
	Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x12DD534
	PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x12EA000
	PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x12DD470
	PropertyDescriptorCollection GetProperties(object component) { }

	// RVA: 0x12EA294
	PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12C5118
	PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x12EA9B8
	PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x12EA304
	PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x12DFF80
	TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0x12E01B8
	TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x12EAA34
	TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0x12CA39C
	Type GetReflectionType(Type type) { }

	// RVA: 0x12EAABC
	Type GetReflectionType(object instance) { }

	// RVA: 0x12DF5B8
	TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x12E05B4
	TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x12E793C
	TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x12E112C
	TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x12EABD8
	void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x12E9338
	ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x12E58B8
	ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x12E7130
	ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x12E4650
	ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x12EAFC0
	void RaiseRefresh(object component) { }

	// RVA: 0x12EB098
	void RaiseRefresh(Type type) { }

	// RVA: 0x12EB170
	void Refresh(object component) { }

	// RVA: 0x12E137C
	void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x12E0AE0
	void Refresh(Type type) { }

	// RVA: 0x12EB1F8
	void Refresh(Module module) { }

	// RVA: 0x12EBC6C
	void Refresh(Assembly assembly) { }

	// RVA: 0x12EBD38
	void RemoveAssociation(object primary, object secondary) { }

	// RVA: 0x12EC0F8
	void RemoveAssociations(object primary) { }

	// RVA: 0x12EC1DC
	void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x12EC2F0
	void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x12EC3D0
	void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x12EC4F4
	void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x12E3CAC
	bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x12EC5E4
	void SortDescriptorArray(IList infos) { }

	// RVA: 0x12EC6B8
	void Trace(string message, object[] args) { }

	// RVA: 0x12EC6BC
	void .cctor() { }

}

// Namespace: System.ComponentModel
public class Win32Exception 
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Methods

	// RVA: 0x12F3188
	void .ctor() { }

	// RVA: 0x12F3208
	void .ctor(int error) { }

	// RVA: 0x12F4038
	void .ctor(int error, string message) { }

	// RVA: 0x12F4068
	void .ctor(string message) { }

	// RVA: 0x12F40E8
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x12F4174
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F4208
	int get_NativeErrorCode() { }

	// RVA: 0x12F4210
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F3244
	string GetErrorMessage(int error) { }

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

	// RVA: 0x12F42E4
	void .ctor(bool notifyParent) { }

	// RVA: 0x12F4310
	bool get_NotifyParent() { }

	// RVA: 0x12F4318
	bool Equals(object obj) { }

	// RVA: 0x12F43BC
	int GetHashCode() { }

	// RVA: 0x12F43C4
	bool IsDefaultAttribute() { }

	// RVA: 0x12F4438
	void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ParenthesizePropertyNameAttribute 
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Methods

	// RVA: 0x12F44EC
	void .ctor() { }

	// RVA: 0x12F4514
	void .ctor(bool needParenthesis) { }

	// RVA: 0x12F4540
	bool get_NeedParenthesis() { }

	// RVA: 0x12F4548
	bool Equals(object o) { }

	// RVA: 0x12F45D0
	int GetHashCode() { }

	// RVA: 0x12F45D8
	bool IsDefaultAttribute() { }

	// RVA: 0x12F464C
	void .cctor() { }

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

	// RVA: 0x12F46BC
	void .ctor(RefreshProperties refresh) { }

	// RVA: 0x12F46E8
	RefreshProperties get_RefreshProperties() { }

	// RVA: 0x12F46F0
	bool Equals(object value) { }

	// RVA: 0x12F4778
	int GetHashCode() { }

	// RVA: 0x12F4780
	bool IsDefaultAttribute() { }

	// RVA: 0x12F47F4
	void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer 
{
	// Methods

	// RVA: 0x12F5138
	bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x12F52B0
	int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x12F5130
	void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference 
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x12F5064
	void .ctor(object o) { }

	// RVA: 0x12F52D8
	bool Equals(object o) { }

	// RVA: 0x12F5368
	int GetHashCode() { }

}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable 
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0
	private Int64 _lastGlobalMem; // 0x50
	private int _lastHashCount; // 0x58

	// Methods

	// RVA: 0x12F48C4
	void .ctor() { }

	// RVA: 0x12F4934
	void Clear() { }

	// RVA: 0x12F493C
	void Remove(object key) { }

	// RVA: 0x12F4944
	void SetWeak(object key, object value) { }

	// RVA: 0x12F49F4
	void ScavengeKeys() { }

	// RVA: 0x12F50A8
	void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute 
{
	// Methods

	// RVA: 0x12F5370
	void .ctor(string category) { }

}

// Namespace: System.ComponentModel.Design
public class CheckoutException 
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x12F5378
	void .ctor() { }

	// RVA: 0x12F5380
	void .ctor(string message, int errorCode) { }

	// RVA: 0x12F5388
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F5390
	void .cctor() { }

}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext 
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x12F5424
	string GetLocalPath(string fileName) { }

	// RVA: 0x12F54B8
	string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x12F5A20
	Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x12F5E3C
	void .ctor() { }

	// RVA: 0x12F5E44
	void .cctor() { }

}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer 
{
	// Methods

	// RVA: 0x12F5C04
	void Deserialize(Stream o, string cryptoKey, RuntimeLicenseContext context) { }

}

// Namespace: System.ComponentModel.Design
public interface IComponentChangeService 
{
	// Methods

	// RVA: 0x2FE4A14
	void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue) { }

	// RVA: 0x2FE47D4
	void OnComponentChanging(object component, MemberDescriptor member) { }

}

// Namespace: System.ComponentModel.Design
public interface IDesigner 
{}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost 
{
	// Methods

	// RVA: 0x2FE36BC
	IDesigner GetDesigner(IComponent component) { }

}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService 
{
	// Methods

	// RVA: 0x2FE36BC
	object GetValue(object key) { }

	// RVA: 0x2FE47D4
	void SetValue(object key, object value) { }

}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService 
{
	// Methods

	// RVA: 0x2FE360C
	IExtenderProvider[] GetExtenderProviders() { }

}

// Namespace: System.ComponentModel.Design
public interface IReferenceService 
{
	// Methods

	// RVA: 0x2FE36BC
	object GetReference(string name) { }

	// RVA: 0x2FE36BC
	string GetName(object reference) { }

	// RVA: 0x2FE36BC
	object[] GetReferences(Type baseType) { }

}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService 
{
	// Methods

	// RVA: -1
	bool FilterAttributes(IComponent component, IDictionary attributes) { }

	// RVA: -1
	bool FilterEvents(IComponent component, IDictionary events) { }

	// RVA: -1
	bool FilterProperties(IComponent component, IDictionary properties) { }

}

// Namespace: System.ComponentModel.Design
public interface ITypeResolutionService 
{
	// Methods

	// RVA: 0x2FE36BC
	Type GetType(string name) { }

	// RVA: 0x2FE36BC
	string GetPathOfAssembly(AssemblyName name) { }

}

// Namespace: 
private sealed class WrappedPropertyDescriptor 
{
	// Fields
	private object target; // 0x88
	private PropertyDescriptor property; // 0x90

	// Methods

	// RVA: 0x12F6748
	void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x12F6850
	AttributeCollection get_Attributes() { }

	// RVA: 0x12F6874
	Type get_ComponentType() { }

	// RVA: 0x12F689C
	bool get_IsReadOnly() { }

	// RVA: 0x12F68C4
	Type get_PropertyType() { }

	// RVA: 0x12F68EC
	bool CanResetValue(object component) { }

	// RVA: 0x12F691C
	object GetValue(object component) { }

	// RVA: 0x12F694C
	void ResetValue(object component) { }

	// RVA: 0x12F697C
	void SetValue(object component, object value) { }

	// RVA: 0x12F69AC
	bool ShouldSerializeValue(object component) { }

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

	// RVA: 0x12F5F08
	int get_Count() { }

	// RVA: 0x12F5FE4
	string get_Name() { }

	// RVA: 0x12F5FEC
	PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x12F67BC
	void CopyTo(Array array, int index) { }

	// RVA: 0x12F5F40
	void EnsurePopulated() { }

	// RVA: 0x12F680C
	IEnumerator GetEnumerator() { }

	// RVA: 0x12F6844
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12F684C
	object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
private class OptionPropertyDescriptor 
{
	// Fields
	private DesignerOptionCollection _option; // 0x88

	// Methods

	// RVA: 0x12F6FB0
	void .ctor(DesignerOptionCollection option) { }

	// RVA: 0x12F70FC
	Type get_ComponentType() { }

	// RVA: 0x12F711C
	bool get_IsReadOnly() { }

	// RVA: 0x12F7124
	Type get_PropertyType() { }

	// RVA: 0x12F7144
	bool CanResetValue(object component) { }

	// RVA: 0x12F714C
	object GetValue(object component) { }

	// RVA: 0x12F7154
	void ResetValue(object component) { }

	// RVA: 0x12F7158
	void SetValue(object component, object value) { }

	// RVA: 0x12F715C
	bool ShouldSerializeValue(object component) { }

}

// Namespace: 
internal sealed class DesignerOptionConverter 
{
	// Methods

	// RVA: 0x12F69DC
	bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x12F69E4
	PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x12F6FF4
	object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F70F4
	void .ctor() { }

}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService 
{
	// Methods

	// RVA: 0x12F5F04
	void PopulateOptionCollection(DesignerOptionCollection options) { }

}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor 
{
	// Fields
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	private readonly bool <IsComplete>k__BackingField; // 0x18
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12F7164
	void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x12F716C
	void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	// RVA: 0x12F76F8
	ICollection get_Arguments() { }

	// RVA: 0x12F7700
	MemberInfo get_MemberInfo() { }

	// RVA: 0x12F7708
	object Invoke() { }

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

	// RVA: 0x12F7A88
	void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x12F7AE4
	string get_SerializerBaseTypeName() { }

	// RVA: 0x12F7AEC
	object get_TypeId() { }

}

// Namespace: System.Collections
internal static class HashtableExtensions 
{
	// Methods

	// RVA: 0x2FE5B20
	bool TryGetValue(Hashtable table, object key, out T value) { }

}

// Namespace: System.Collections.Specialized
public struct BitVector32 
{
	// Fields
	private UInt32 _data; // 0x10

	// Methods

	// RVA: 0x12F7BA8
	void .ctor(int data) { }

	// RVA: 0x12F7BB0
	bool get_Item(int bit) { }

	// RVA: 0x12F7BC0
	void set_Item(int bit, bool value) { }

	// RVA: 0x12F7BDC
	int get_Data() { }

	// RVA: 0x12F7BE4
	int CreateMask() { }

	// RVA: 0x12F7BEC
	int CreateMask(int previous) { }

	// RVA: 0x12F7C60
	bool Equals(object o) { }

	// RVA: 0x12F7CF0
	int GetHashCode() { }

	// RVA: 0x12F7D60
	string ToString(BitVector32 value) { }

	// RVA: 0x12F8090
	string ToString() { }

}

// Namespace: System.Collections.Specialized
public class NameValueCollection 
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Methods

	// RVA: 0x12F8098
	void .ctor() { }

	// RVA: 0x12F81C8
	void .ctor(int capacity) { }

	// RVA: 0x12F8344
	void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x12F83F4
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F84A0
	void InvalidateCachedArrays() { }

	// RVA: 0x12F84D4
	string GetAsOneString(ArrayList list) { }

	// RVA: 0x12F86A0
	string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x12F875C
	void Add(string name, string value) { }

	// RVA: 0x12F8A88
	string Get(string name) { }

	// RVA: 0x12F8B20
	string[] GetValues(string name) { }

	// RVA: 0x12F8C84
	void Set(string name, string value) { }

	// RVA: 0x12F8E4C
	void Remove(string name) { }

	// RVA: 0x12F91B8
	string get_Item(string name) { }

	// RVA: 0x12F91C8
	void set_Item(string name, string value) { }

	// RVA: 0x12F91D8
	string Get(int index) { }

	// RVA: 0x12F9398
	string GetKey(int index) { }

	// RVA: 0x12F94E8
	void .ctor(DBNull dummy) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator 
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Methods

	// RVA: 0x12FA8FC
	void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x12FB1F0
	object get_Current() { }

	// RVA: 0x12FB3EC
	DictionaryEntry get_Entry() { }

	// RVA: 0x12FB5A0
	object get_Key() { }

	// RVA: 0x12FB694
	object get_Value() { }

	// RVA: 0x12FB788
	bool MoveNext() { }

	// RVA: 0x12FB83C
	void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection 
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Methods

	// RVA: 0x12F98C0
	void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x12FB8F4
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12FBCD0
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12FBCF8
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12FBD00
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12FBD28
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Specialized
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

	// RVA: 0x12F9578
	void .ctor() { }

	// RVA: 0x12F95AC
	void .ctor(int capacity) { }

	// RVA: 0x12F95E4
	void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x12F9628
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F965C
	int get_Count() { }

	// RVA: 0x12F979C
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x12F97A4
	bool get_IsReadOnly() { }

	// RVA: 0x12F97AC
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12F97B4
	ICollection get_Keys() { }

	// RVA: 0x12F96F8
	ArrayList get_objectsArray() { }

	// RVA: 0x12F9908
	Hashtable get_objectsTable() { }

	// RVA: 0x12F99C0
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12F9A4C
	object get_Item(object key) { }

	// RVA: 0x12F9B00
	void set_Item(object key, object value) { }

	// RVA: 0x12FA1D0
	ICollection get_Values() { }

	// RVA: 0x12F9FDC
	void Add(object key, object value) { }

	// RVA: 0x12FA2D8
	void Clear() { }

	// RVA: 0x12FA44C
	bool Contains(object key) { }

	// RVA: 0x12FA500
	void CopyTo(Array array, int index) { }

	// RVA: 0x12F9DB0
	int IndexOfKey(object key) { }

	// RVA: 0x12FA5C4
	void Remove(object key) { }

	// RVA: 0x12FA7C0
	IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x12FA960
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12FAA9C
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12FACDC
	void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x12FACEC
	void OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Specialized
public class StringCollection 
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Methods

	// RVA: 0x12FBDD0
	string get_Item(int index) { }

	// RVA: 0x12FBE58
	void set_Item(int index, string value) { }

	// RVA: 0x12FBE80
	int get_Count() { }

	// RVA: 0x12FBEA8
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12FBEB0
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12FBEB8
	int Add(string value) { }

	// RVA: 0x12FBEE0
	void Clear() { }

	// RVA: 0x12FBF08
	bool Contains(string value) { }

	// RVA: 0x12FBF30
	void CopyTo(string[] array, int index) { }

	// RVA: 0x12FBF58
	int IndexOf(string value) { }

	// RVA: 0x12FBF80
	void Insert(int index, string value) { }

	// RVA: 0x12FBFA8
	bool get_IsSynchronized() { }

	// RVA: 0x12FBFB0
	void Remove(string value) { }

	// RVA: 0x12FBFD8
	void RemoveAt(int index) { }

	// RVA: 0x12FC000
	object get_SyncRoot() { }

	// RVA: 0x12FC028
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12FC0B0
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12FC140
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x12FC1C8
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12FC250
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12FC2D8
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12FC368
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12FC3F0
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12FC418
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12FC440
	void .ctor() { }

}

// Namespace: System.Collections.Specialized
public class StringDictionary 
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x12FC4B8
	void .ctor() { }

	// RVA: 0x12FC530
	string get_Item(string key) { }

	// RVA: 0x12FC614
	IEnumerator GetEnumerator() { }

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

	// RVA: 0x12FC63C
	void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x12FC858
	void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x12FCBB8
	void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x12FCEF4
	void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x12FCA8C
	void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x12FC7B0
	void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x12FD0CC
	void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x12FCDD0
	void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler 
{
	// Methods

	// RVA: 0x12FD1A8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x12FD2CC
	internal void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

// Namespace: System.Collections.Specialized
internal sealed class ReadOnlyList 
{
	// Fields
	private readonly IList _list; // 0x10

	// Methods

	// RVA: 0x12FD174
	void .ctor(IList list) { }

	// RVA: 0x12FD2E0
	int get_Count() { }

	// RVA: 0x12FD398
	bool get_IsReadOnly() { }

	// RVA: 0x12FD3A0
	bool get_IsFixedSize() { }

	// RVA: 0x12FD3A8
	bool get_IsSynchronized() { }

	// RVA: 0x12FD460
	object get_Item(int index) { }

	// RVA: 0x12FD514
	void set_Item(int index, object value) { }

	// RVA: 0x12FD568
	object get_SyncRoot() { }

	// RVA: 0x12FD620
	int Add(object value) { }

	// RVA: 0x12FD674
	void Clear() { }

	// RVA: 0x12FD6C8
	bool Contains(object value) { }

	// RVA: 0x12FD780
	void CopyTo(Array array, int index) { }

	// RVA: 0x12FD83C
	IEnumerator GetEnumerator() { }

	// RVA: 0x12FD8F0
	int IndexOf(object value) { }

	// RVA: 0x12FD9A8
	void Insert(int index, object value) { }

	// RVA: 0x12FD9FC
	void Remove(object value) { }

	// RVA: 0x12FDA50
	void RemoveAt(int index) { }

}

// Namespace: 
internal class NameObjectEntry 
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x12FEE24
	void .ctor(string name, object value) { }

}

// Namespace: 
internal class NameObjectKeysEnumerator 
{
	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Methods

	// RVA: 0x12FEF08
	void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x12FF440
	bool MoveNext() { }

	// RVA: 0x12FF524
	void Reset() { }

	// RVA: 0x12FF5B0
	object get_Current() { }

}

// Namespace: System.Collections.Specialized
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

	// RVA: 0x12F815C
	void .ctor() { }

	// RVA: 0x12FDAA4
	void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x12F83C4
	void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x12F8254
	void .ctor(int capacity) { }

	// RVA: 0x12F9570
	void .ctor(DBNull dummy) { }

	// RVA: 0x12F846C
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12FDD1C
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12FE568
	void OnDeserialization(object sender) { }

	// RVA: 0x12FDB60
	void Reset() { }

	// RVA: 0x12FDC34
	void Reset(int capacity) { }

	// RVA: 0x12FED44
	NameObjectEntry FindEntry(string key) { }

	// RVA: 0x12FEE1C
	bool get_IsReadOnly() { }

	// RVA: 0x12F8900
	void BaseAdd(string name, object value) { }

	// RVA: 0x12F8E90
	void BaseRemove(string name) { }

	// RVA: 0x12F88E4
	object BaseGet(string name) { }

	// RVA: 0x12F8D8C
	void BaseSet(string name, object value) { }

	// RVA: 0x12F92F0
	object BaseGet(int index) { }

	// RVA: 0x12F9440
	string BaseGetKey(int index) { }

	// RVA: 0x12FEE74
	IEnumerator GetEnumerator() { }

	// RVA: 0x12FEF68
	int get_Count() { }

	// RVA: 0x12FEF90
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12FF2C8
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12FF354
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12FF35C
	void .cctor() { }

}

// Namespace: System.Collections.Specialized
internal class CompatibleComparer 
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Methods

	// RVA: 0x12FECF4
	void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x12FF6D8
	bool Equals(object a, object b) { }

	// RVA: 0x12FF8F8
	int GetHashCode(object obj) { }

	// RVA: 0x12FFA10
	IComparer get_Comparer() { }

	// RVA: 0x12FFA18
	IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x12FE47C
	IComparer get_DefaultComparer() { }

	// RVA: 0x12FE398
	IHashCodeProvider get_DefaultHashCodeProvider() { }

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

	// RVA: 0x2FE4574
	void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: 0x309AF8C
	void LocalPush(T item, ref Int64 emptyToNonEmptyListTransitionCount) { }

	// RVA: -1
	int DangerousCopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x2FE32D4
	int get_DangerousCount() { }

}

// Namespace: 
private sealed class Enumerator 
{
	// Fields
	private readonly T[] _array; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(T[] array) { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

}

// Namespace: System.Collections.Concurrent
public class ConcurrentBag<T0> 
{
	// Fields
	private readonly System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals; // 0x0
	private WorkStealingQueue _workStealingQueues; // 0x0
	private Int64 _emptyToNonEmptyListTransitionCount; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	void Add(T item) { }

	// RVA: -1
	WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	// RVA: 0x2FE360C
	WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: 0x2FE360C
	WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: 0x2FE45DC
	void CopyTo(T[] array, int index) { }

	// RVA: -1
	int CopyFromEachQueueToArray(T[] array, int index) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE360C
	T[] ToArray() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE32D4
	int get_DangerousCount() { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE360C
	object get_GlobalQueuesLock() { }

	// RVA: 0x2FE4574
	void FreezeBag(ref bool lockTaken) { }

	// RVA: 0x2FE4234
	void UnfreezeBag(bool lockTaken) { }

}

// Namespace: System.Collections.Generic
internal struct ValueListBuilder<T0> 
{
	// Fields
	private System.Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(System.Span<T> initialSpan) { }

	// RVA: 0x2FE32D4
	int get_Length() { }

	// RVA: -1
	ref T get_Item(int index) { }

	// RVA: 0x309AF8C
	void Append(T item) { }

	// RVA: 0x309AF8C
	System.ReadOnlySpan<T> AsSpan() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE41A8
	void Grow() { }

	// RVA: 0x309AF8C
	T Pop() { }

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

	// RVA: 0x12FFA20
	void .ctor(Int32* bitArrayPtr, int length) { }

	// RVA: 0x12FFA64
	void .ctor(int[] bitArray, int length) { }

	// RVA: 0x12FFAAC
	void MarkBit(int bitPosition) { }

	// RVA: 0x12FFB2C
	bool IsMarked(int bitPosition) { }

	// RVA: 0x12FFBB4
	int ToIntArrayLength(int n) { }

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
public struct Enumerator 
{
	// Fields
	private System.Collections.Generic.LinkedList<T> _list; // 0x0
	private System.Collections.Generic.LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.LinkedList<T> list) { }

	// RVA: -1
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: -1
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE4574
	void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Generic
public class LinkedList<T0> 
{
	// Fields
	internal System.Collections.Generic.LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: -1
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.LinkedListNode<T> get_First() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x309AF8C
	System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }

	// RVA: 0x309AF8C
	System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }

	// RVA: 0x2FE4574
	void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(T value) { }

	// RVA: 0x2FE45DC
	void CopyTo(T[] array, int index) { }

	// RVA: 0x309AF8C
	System.Collections.Generic.LinkedListNode<T> Find(T value) { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Remove(T value) { }

	// RVA: 0x2FE4574
	void Remove(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x2FE41A8
	void RemoveFirst() { }

	// RVA: -1
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE4574
	void OnDeserialization(object sender) { }

	// RVA: 0x2FE47D4
	void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x2FE4574
	void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x2FE4574
	void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x2FE4574
	void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x2FE4574
	void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x309AF8C
	void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.LinkedListNode<T> get_Next() { }

	// RVA: 0x309AF8C
	T get_Value() { }

	// RVA: 0x2FE41A8
	void Invalidate() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x2FE45DC
	void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, int getEnumeratorRetType) { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x309AF8C
	System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x2FE3054
	bool get_NotStartedOrEnded() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x2FE360C
	object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: -1
	DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	TKey get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
public sealed class KeyCollection 
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE45DC
	void CopyTo(TKey[] array, int index) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: 0x2FE41A8
	void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	TValue get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
public sealed class ValueCollection 
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE45DC
	void CopyTo(TValue[] array, int index) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: 0x2FE41A8
	void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
internal sealed class KeyValuePairComparer 
{
	// Fields
	internal System.Collections.Generic.IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }

	// RVA: 0x309AF8C
	int Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0 
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1 
{
	// Fields
	public System.Collections.Generic.EqualityComparer<TValue> valueComparer; // 0x0
	public System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey,TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <ContainsValue>b__1(Node node) { }

}

// Namespace: System.Collections.Generic
public class SortedDictionary<T0, T1> 
{
	// Fields
	private KeyCollection _keys; // 0x0
	private ValueCollection _values; // 0x0
	private System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey,TValue>> _set; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x309AF8C
	TValue get_Item(TKey key) { }

	// RVA: 0x309AF8C
	void set_Item(TKey key, TValue value) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	KeyCollection get_Keys() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x2FE360C
	ValueCollection get_Values() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x309AF8C
	void Add(TKey key, TValue value) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool ContainsKey(TKey key) { }

	// RVA: 0x309AF8C
	bool ContainsValue(TValue value) { }

	// RVA: 0x2FE45DC
	void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int index) { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Remove(TKey key) { }

	// RVA: 0x309AF8C
	bool TryGetValue(TKey key, out TValue value) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE3054
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x2FE3054
	bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x2FE36BC
	object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x2FE3174
	bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x2FE5724
	bool IsCompatibleKey(object key) { }

	// RVA: 0x2FE360C
	IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x2FE4574
	void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
internal sealed class TreeSet<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: 0x309AF8C
	bool AddIfNotPresent(T item) { }

}

// Namespace: 
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

	// RVA: 0x2FE45DC
	void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, int getEnumeratorRetType) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE360C
	object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: -1
	DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x309AF8C
	System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class SortedListKeyEnumerator 
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	TKey get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class SortedListValueEnumerator 
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	TValue get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class KeyList 
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x309AF8C
	void Add(TKey key) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(TKey key) { }

	// RVA: 0x2FE45DC
	void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x309AF8C
	void Insert(int index, TKey value) { }

	// RVA: 0x309AF8C
	TKey get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, TKey value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	int IndexOf(TKey key) { }

	// RVA: 0x309AF8C
	bool Remove(TKey key) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

}

// Namespace: 
private sealed class ValueList 
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x309AF8C
	void Add(TValue key) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(TValue value) { }

	// RVA: 0x2FE45DC
	void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x309AF8C
	void Insert(int index, TValue value) { }

	// RVA: 0x309AF8C
	TValue get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, TValue value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	int IndexOf(TValue value) { }

	// RVA: 0x309AF8C
	bool Remove(TValue value) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

}

// Namespace: System.Collections.Generic
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

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x309AF8C
	void Add(TKey key, TValue value) { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x2FE42A4
	void set_Capacity(int value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IComparer<TKey> get_Comparer() { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x2FE360C
	KeyList GetKeyListHelper() { }

	// RVA: 0x2FE360C
	ValueList GetValueListHelper() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x2FE3054
	bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x2FE3054
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x2FE3174
	bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x309AF8C
	bool ContainsKey(TKey key) { }

	// RVA: 0x309AF8C
	bool ContainsValue(TValue value) { }

	// RVA: 0x2FE45DC
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE42A4
	void EnsureCapacity(int min) { }

	// RVA: 0x309AF8C
	TValue GetByIndex(int index) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	TKey GetKey(int index) { }

	// RVA: 0x309AF8C
	TValue get_Item(TKey key) { }

	// RVA: 0x309AF8C
	void set_Item(TKey key, TValue value) { }

	// RVA: 0x2FE36BC
	object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x309AF8C
	int IndexOfKey(TKey key) { }

	// RVA: 0x309AF8C
	int IndexOfValue(TValue value) { }

	// RVA: 0x309AF8C
	void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x309AF8C
	bool TryGetValue(TKey key, out TValue value) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

	// RVA: 0x309AF8C
	bool Remove(TKey key) { }

	// RVA: 0x2FE4574
	void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x2FE5724
	bool IsCompatibleKey(object key) { }

}

// Namespace: 
internal sealed class TreeSubSet 
{}

// Namespace: 
internal sealed class Node 
{
	// Fields
	private T <Item>k__BackingField; // 0x0
	private Node <Left>k__BackingField; // 0x0
	private Node <Right>k__BackingField; // 0x0
	private NodeColor <Color>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(T item, NodeColor color) { }

	// RVA: 0x2FE5724
	bool IsNonNullRed(Node node) { }

	// RVA: 0x2FE5724
	bool IsNullOrBlack(Node node) { }

	// RVA: 0x309AF8C
	T get_Item() { }

	// RVA: 0x309AF8C
	void set_Item(T value) { }

	// RVA: 0x2FE360C
	Node get_Left() { }

	// RVA: 0x2FE4574
	void set_Left(Node value) { }

	// RVA: 0x2FE360C
	Node get_Right() { }

	// RVA: 0x2FE4574
	void set_Right(Node value) { }

	// RVA: 0x2FE3054
	NodeColor get_Color() { }

	// RVA: 0x2FE4234
	void set_Color(NodeColor value) { }

	// RVA: 0x2FE3054
	bool get_IsBlack() { }

	// RVA: 0x2FE3054
	bool get_IsRed() { }

	// RVA: 0x2FE3054
	bool get_Is2Node() { }

	// RVA: 0x2FE3054
	bool get_Is4Node() { }

	// RVA: 0x2FE41A8
	void ColorBlack() { }

	// RVA: 0x2FE41A8
	void ColorRed() { }

	// RVA: -1
	Node DeepClone(int count) { }

	// RVA: -1
	TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: 0x2FE36BC
	Node GetSibling(Node node) { }

	// RVA: 0x2FE360C
	Node ShallowClone() { }

	// RVA: 0x2FE41A8
	void Split4Node() { }

	// RVA: -1
	Node Rotate(TreeRotation rotation) { }

	// RVA: 0x2FE360C
	Node RotateLeft() { }

	// RVA: 0x2FE360C
	Node RotateLeftRight() { }

	// RVA: 0x2FE360C
	Node RotateRight() { }

	// RVA: 0x2FE360C
	Node RotateRightLeft() { }

	// RVA: 0x2FE41A8
	void Merge2Nodes() { }

	// RVA: 0x2FE47D4
	void ReplaceChild(Node child, Node newChild) { }

}

// Namespace: 
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

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.SortedSet<T> set) { }

	// RVA: -1
	void .ctor(System.Collections.Generic.SortedSet<T> set, bool reverse) { }

	// RVA: -1
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE4574
	void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2FE41A8
	void Initialize() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE3054
	bool get_NotStartedOrEnded() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0 
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: System.Collections.Generic
public class SortedSet<T0> 
{
	// Fields
	private Node root; // 0x0
	private System.Collections.Generic.IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0
	private const string ComparerName = 5736733696;
	private const string CountName = 5736733648;
	private const string ItemsName = 5736733504;
	private const string VersionName = 5736733456;
	private const string TreeName = 5736733408;
	private const string NodeValueName = 5736733360;
	private const string EnumStartName = 5730682496;
	private const string ReverseName = 5736733312;
	private const string EnumVersionName = 5730682432;
	private const string MinName = 5736733168;
	private const string MaxName = 5736733120;
	private const string LowerBoundActiveName = 5730682368;
	private const string UpperBoundActiveName = 5730682304;
	internal const int StackAllocThreshold = 100;

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: 0x2FE47D4
	void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE4574
	void AddAllElements(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x2FE3174
	bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IComparer<T> get_Comparer() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE41A8
	void VersionCheck() { }

	// RVA: 0x309AF8C
	bool IsWithinRange(T item) { }

	// RVA: 0x309AF8C
	bool Add(T item) { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x309AF8C
	bool AddIfNotPresent(T item) { }

	// RVA: 0x309AF8C
	bool Remove(T item) { }

	// RVA: 0x309AF8C
	bool DoRemove(T item) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(T item) { }

	// RVA: 0x2FE45DC
	void CopyTo(T[] array, int index) { }

	// RVA: -1
	void CopyTo(T[] array, int index, int count) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE4A14
	void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: 0x2FE49A8
	void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: 0x2FE4A14
	void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: 0x309AF8C
	Node FindNode(T item) { }

	// RVA: 0x309AF8C
	int InternalIndexOf(T item) { }

	// RVA: 0x2FE41A8
	void UpdateVersion() { }

	// RVA: 0x2FE3174
	bool HasEqualComparer(System.Collections.Generic.SortedSet<T> other) { }

	// RVA: 0x2FE4574
	void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x309AF8C
	Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode) { }

	// RVA: 0x2FE4574
	void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x2FE4574
	void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x2FE3174
	bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x309AF8C
	ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, bool returnIfUnfound) { }

	// RVA: 0x309AF8C
	T get_Min() { }

	// RVA: 0x309AF8C
	T get_MinInternal() { }

	// RVA: 0x309AF8C
	T get_Max() { }

	// RVA: 0x309AF8C
	T get_MaxInternal() { }

	// RVA: -1
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FE4574
	void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2FE4574
	void OnDeserialization(object sender) { }

	// RVA: -1
	int Log2(int value) { }

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
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FE3174
	internal bool Invoke(Node node) { }

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

	// RVA: 0x309AF8C
	bool Add(T item) { }

	// RVA: 0x2FE4574
	void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x2FE4574
	void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x2FE3174
	bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

}

// Namespace: System.IO
public class InternalBufferOverflowException 
{
	// Methods

	// RVA: 0x12FFBC8
	void .ctor() { }

	// RVA: 0x12FFC20
	void .ctor(string message) { }

	// RVA: 0x12FFC28
	void .ctor(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0x12FFC30
	void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x12FFC38
	void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x12FFCFC
	bool get_CanRead() { }

	// RVA: 0x12FFD14
	bool get_CanWrite() { }

	// RVA: 0x12FFD2C
	bool get_CanSeek() { }

	// RVA: 0x12FFD44
	Int64 get_Length() { }

	// RVA: 0x12FFD98
	Int64 get_Position() { }

	// RVA: 0x12FFDEC
	void set_Position(Int64 value) { }

	// RVA: 0x12FFE40
	void Flush() { }

	// RVA: 0x12FFE84
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x12FFED8
	int ReadByte() { }

	// RVA: 0x12FFF00
	IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x12FFFB8
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1300020
	int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1300048
	int Read(System.Span<System.Byte> buffer) { }

	// RVA: 0x130025C
	IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1300314
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1300320
	void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1300348
	void Write(System.ReadOnlySpan<System.Byte> buffer) { }

	// RVA: 0x130052C
	void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1300554
	void Dispose(bool disposing) { }

	// RVA: 0x1300618
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1300640
	System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x130072C
	Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1300754
	ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1300840
	Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12FFE68
	void CheckDeflateStream() { }

	// RVA: 0x1300868
	void ThrowStreamClosedException() { }

}

// Namespace: 
private sealed class ReadMethod 
{
	// Methods

	// RVA: 0x1301B74
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13026B4
	internal int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1301C30
	internal IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1302398
	internal int EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod 
{
	// Methods

	// RVA: 0x130209C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13026C8
	internal void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1302158
	internal IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x130251C
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x13008C0
	void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x12FFCF4
	void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x13008CC
	void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x1300D08
	void Finalize() { }

	// RVA: 0x1300DA8
	void Dispose(bool disposing) { }

	// RVA: 0x1300FD0
	int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1300724
	System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x1300134
	int ReadCore(System.Span<System.Byte> destination) { }

	// RVA: 0x13010F4
	int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1301318
	void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1300838
	ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x130049C
	void WriteCore(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1301434
	void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1301674
	void Flush() { }

	// RVA: 0x13017DC
	IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1301D04
	IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x130222C
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x13023C4
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1302528
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1302568
	bool get_CanRead() { }

	// RVA: 0x13025A8
	bool get_CanSeek() { }

	// RVA: 0x13025B0
	bool get_CanWrite() { }

	// RVA: 0x13025F4
	Int64 get_Length() { }

	// RVA: 0x1302634
	Int64 get_Position() { }

	// RVA: 0x1302674
	void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite 
{
	// Methods

	// RVA: 0x130287C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13030B0
	internal int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle 
{
	// Methods

	// RVA: 0x13030C4
	bool get_IsInvalid() { }

	// RVA: 0x130309C
	void .ctor() { }

	// RVA: 0x13030D4
	bool ReleaseHandle() { }

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

	// RVA: 0x1302874
	void .ctor() { }

	// RVA: 0x1300A98
	DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x13029C4
	void Finalize() { }

	// RVA: 0x1300EA4
	void Dispose(bool disposing) { }

	// RVA: 0x1301728
	void Flush() { }

	// RVA: 0x1301024
	int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1301368
	void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x13026DC
	int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1302CB8
	int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x13027A8
	int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1302E9C
	int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1302AC8
	void CheckResult(int result, string where) { }

	// RVA: 0x1302920
	SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x13030AC
	int CloseZStream(IntPtr stream) { }

	// RVA: 0x1302A58
	int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x1302BA8
	int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1302C30
	int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.ContextAwareResult.<>c <>9; // 0x0
	public static ContextCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x13045C8
	void .cctor() { }

	// RVA: 0x1304634
	void .ctor() { }

	// RVA: 0x130463C
	void <Complete>b__17_0(object s) { }

}

// Namespace: System.Net
internal class ContextAwareResult 
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x1303178
	void SafeCaptureIdentity() { }

	// RVA: 0x130317C
	void CleanupInternal() { }

	// RVA: 0x1303180
	void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1303188
	void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x13031F8
	void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1303280
	object StartPostingAsyncOp() { }

	// RVA: 0x1303288
	object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x1303534
	bool FinishPostingAsyncOp() { }

	// RVA: 0x1303BD8
	void Cleanup() { }

	// RVA: 0x1303584
	bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x13040EC
	void Complete(IntPtr userToken) { }

	// RVA: 0x1304498
	void CompleteCallback() { }

}

// Namespace: System.Net
internal static class HttpStatusDescription 
{
	// Methods

	// RVA: 0x13046C0
	string Get(HttpStatusCode code) { }

	// RVA: 0x13046C4
	string Get(int code) { }

}

// Namespace: System.Net
internal static class HttpValidationHelpers 
{
	// Fields
	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x1304FB4
	bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x13050D8
	void .cctor() { }

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

	// RVA: 0x130517C
	void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x130587C
	void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x1305E18
	void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x13057F4
	void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x1305FF4
	void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1306248
	void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x13061C0
	void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x1303D8C
	void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x1303F58
	void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x13063DC
	void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1306464
	void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x13065F8
	void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x13033A0
	void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x1306680
	void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1306708
	void Associate(object first, object second, string memberName) { }

	// RVA: 0x13068A4
	void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x1303D0C
	bool get_IsEnabled() { }

	// RVA: 0x1305348
	string IdOf(object value) { }

	// RVA: 0x1306B48
	int GetHashCode(object value) { }

	// RVA: 0x1305A24
	object Format(object value) { }

	// RVA: 0x1305448
	string Format(FormattableString s) { }

	// RVA: 0x1306930
	void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1306B5C
	void .ctor() { }

	// RVA: 0x1306B64
	void .cctor() { }

}

// Namespace: System.Net
internal static class TcpValidationHelpers 
{
	// Methods

	// RVA: 0x1306BD0
	bool ValidatePortNumber(int port) { }

}

// Namespace: System.Net
internal class TlsStream 
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x1306BDC
	void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x1306CD4
	void AuthenticateAsClient() { }

	// RVA: 0x1306E24
	IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x1306F8C
	void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1306FB4
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1306FDC
	void EndWrite(IAsyncResult result) { }

	// RVA: 0x1307004
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x130702C
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1307054
	IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x130707C
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x13070A4
	void Close() { }

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

	// RVA: 0x13070E8
	void .cctor() { }

}

// Namespace: 
private sealed class ReadOnlyIPAddress 
{
	// Methods

	// RVA: 0x1308F50
	void .ctor(Int64 newAddress) { }

}

// Namespace: System.Net
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

	// RVA: 0x1307208
	bool get_IsIPv4() { }

	// RVA: 0x1307218
	bool get_IsIPv6() { }

	// RVA: 0x1307228
	UInt32 get_PrivateAddress() { }

	// RVA: 0x1307230
	void set_PrivateAddress(UInt32 value) { }

	// RVA: 0x1307268
	UInt32 get_PrivateScopeId() { }

	// RVA: 0x1307270
	void set_PrivateScopeId(UInt32 value) { }

	// RVA: 0x13072A8
	void .ctor(Int64 newAddress) { }

	// RVA: 0x1307338
	void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0x1307458
	void .ctor(System.ReadOnlySpan<System.Byte> address, Int64 scopeid) { }

	// RVA: 0x130768C
	void .ctor(UInt16* numbers, int numbersLength, UInt32 scopeid) { }

	// RVA: 0x1307754
	void .ctor(UInt16[] numbers, UInt32 scopeid) { }

	// RVA: 0x13077B0
	bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1307B4C
	IPAddress Parse(string ipString) { }

	// RVA: 0x1307BE8
	bool TryWriteBytes(System.Span<System.Byte> destination, out int bytesWritten) { }

	// RVA: 0x1307F18
	void WriteIPv6Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x1308170
	void WriteIPv4Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x13081C0
	Byte[] GetAddressBytes() { }

	// RVA: 0x13082C8
	AddressFamily get_AddressFamily() { }

	// RVA: 0x13082E0
	Int64 get_ScopeId() { }

	// RVA: 0x130833C
	string ToString() { }

	// RVA: 0x1308484
	bool IsLoopback(IPAddress address) { }

	// RVA: 0x130859C
	bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1308798
	bool Equals(object comparand) { }

	// RVA: 0x13087A0
	int GetHashCode() { }

	// RVA: 0x1308B88
	IPAddress MapToIPv6() { }

	// RVA: 0x1307404
	Byte[] ThrowAddressNullException() { }

	// RVA: 0x1308C94
	void .cctor() { }

}

// Namespace: System.Net
internal class IPAddressParser 
{
	// Methods

	// RVA: 0x1307854
	IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, bool tryParse) { }

	// RVA: 0x1308414
	string IPv4AddressToString(UInt32 address) { }

	// RVA: 0x13094A8
	void IPv4AddressToString(UInt32 address, StringBuilder destination) { }

	// RVA: 0x1309204
	int IPv4AddressToStringHelper(UInt32 address, Char* addressString) { }

	// RVA: 0x13083FC
	string IPv6AddressToString(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x13095F4
	StringBuilder IPv6AddressToStringHelper(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x1309528
	void FormatIPv4AddressNumber(int number, Char* addressString, ref int offset) { }

	// RVA: 0x1309148
	bool Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, out Int64 address) { }

	// RVA: 0x1308FDC
	bool Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, UInt16* numbers, int numbersLength, out UInt32 scope) { }

	// RVA: 0x1309784
	void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x1309B1C
	void AppendHex(UInt16 value, StringBuilder buffer) { }

	// RVA: 0x1309AE4
	UInt32 ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x1309BB8
	UInt16 Reverse(UInt16 number) { }

}

// Namespace: System.Net
public class IPEndPoint 
{
	// Fields
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Methods

	// RVA: 0x1309BC0
	AddressFamily get_AddressFamily() { }

	// RVA: 0x1309BF0
	void .ctor(IPAddress address, int port) { }

	// RVA: 0x1309CD0
	IPAddress get_Address() { }

	// RVA: 0x1309CD8
	int get_Port() { }

	// RVA: 0x1309CE0
	string ToString() { }

	// RVA: 0x1309DA8
	SocketAddress Serialize() { }

	// RVA: 0x1309E1C
	EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x130A02C
	bool Equals(object comparand) { }

	// RVA: 0x130A104
	int GetHashCode() { }

	// RVA: 0x130A140
	void .cctor() { }

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

	// RVA: 0x130C6F4
	void .ctor(string command) { }

	// RVA: 0x130C728
	void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x130C770
	bool HasFlag(PipelineEntryFlags flags) { }

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

	// RVA: 0x130A220
	void .ctor(TcpClient client) { }

	// RVA: 0x130A2DC
	void Abort(Exception e) { }

	// RVA: 0x130A544
	void Dispose(bool disposing) { }

	// RVA: 0x130A6C4
	void InvokeRequestCallback(object obj) { }

	// RVA: 0x130A748
	bool get_RecoverableFailure() { }

	// RVA: 0x130A750
	void MarkAsRecoverableFailure() { }

	// RVA: 0x130A768
	Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x130AE94
	void ClearState() { }

	// RVA: 0x130AF3C
	PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x130AF44
	Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x130AFC8
	Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x130A870
	void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x130B084
	void CheckContinuePipeline() { }

	// RVA: 0x130A92C
	Stream ContinueCommandPipeline() { }

	// RVA: 0x130B140
	bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x130B604
	bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x130B8B0
	PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x130B8B8
	void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x130C1BC
	void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x130C4AC
	Encoding get_Encoding() { }

	// RVA: 0x130C4B4
	void set_Encoding(Encoding value) { }

	// RVA: 0x130C508
	bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x130B288
	ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x130BBC0
	void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x130C510
	void .cctor() { }

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

	// RVA: 0x130C780
	bool get_PositiveIntermediate() { }

	// RVA: 0x130C794
	bool get_PositiveCompletion() { }

	// RVA: 0x130C7A8
	bool get_TransientFailure() { }

	// RVA: 0x130C7BC
	bool get_PermanentFailure() { }

	// RVA: 0x130C7D0
	bool get_InvalidStatusCode() { }

	// RVA: 0x130C7E4
	void .ctor() { }

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

	// RVA: 0x130C864
	void .ctor(CommandStream connection) { }

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

	// RVA: 0x130E644
	void .ctor() { }

	// RVA: 0x1311E48
	void <PipelineCallback>b__0(IAsyncResult ar) { }

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

	// RVA: 0x130C988
	NetworkCredential get_Credentials() { }

	// RVA: 0x130CA40
	void set_Credentials(NetworkCredential value) { }

	// RVA: 0x130CAD8
	void .ctor(TcpClient client) { }

	// RVA: 0x130CB84
	void AbortConnect() { }

	// RVA: 0x130CC24
	void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x130D14C
	void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x130D324
	void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x130D4FC
	PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x130DC90
	void ClearState() { }

	// RVA: 0x130DD64
	PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x130F7E8
	PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x130E64C
	PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x1310B1C
	void GetPathInfo(GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x1311670
	string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1311790
	string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x13118AC
	Int64 get_ContentLength() { }

	// RVA: 0x13118B4
	DateTime get_LastModified() { }

	// RVA: 0x13118BC
	Uri get_ResponseUri() { }

	// RVA: 0x13118C4
	string get_BannerMessage() { }

	// RVA: 0x13118DC
	string get_WelcomeMessage() { }

	// RVA: 0x13118F4
	string get_ExitMessage() { }

	// RVA: 0x130F270
	Int64 GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x130F3A4
	DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x130EEDC
	void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x130EDDC
	void TryUpdateContentLength(string str) { }

	// RVA: 0x130F734
	string GetLoginDirectory(string str) { }

	// RVA: 0x131115C
	int GetPortV4(string responseString) { }

	// RVA: 0x131133C
	int GetPortV6(string responseString) { }

	// RVA: 0x1310D34
	void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1310F30
	string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x13109EC
	string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x13114E8
	Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x131190C
	bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x130D8E0
	TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x1311D14
	void .cctor() { }

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

	// RVA: 0x130D978
	void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x1311F5C
	void Dispose(bool disposing) { }

	// RVA: 0x13120E8
	void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1312550
	void CheckError() { }

	// RVA: 0x131259C
	bool get_CanRead() { }

	// RVA: 0x13125A4
	bool get_CanSeek() { }

	// RVA: 0x13125C8
	bool get_CanWrite() { }

	// RVA: 0x13125D0
	Int64 get_Length() { }

	// RVA: 0x13125F4
	Int64 get_Position() { }

	// RVA: 0x1312618
	void set_Position(Int64 value) { }

	// RVA: 0x1312640
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1312738
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1312868
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x131295C
	void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x1312CD0
	IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1312FE0
	int EndRead(IAsyncResult ar) { }

	// RVA: 0x13131D4
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x13132CC
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x13133B0
	void Flush() { }

	// RVA: 0x13133D8
	bool get_CanTimeout() { }

	// RVA: 0x13133FC
	int get_ReadTimeout() { }

	// RVA: 0x1313424
	void set_ReadTimeout(int value) { }

	// RVA: 0x131344C
	int get_WriteTimeout() { }

	// RVA: 0x1313474
	void set_WriteTimeout(int value) { }

	// RVA: 0x131349C
	void SetSocketTimeoutOption(int timeout) { }

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

	// RVA: 0x13134F0
	void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x1310B0C
	bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x1310D24
	bool get_IsCommandOnly() { }

	// RVA: 0x1311CFC
	bool get_IsUpload() { }

	// RVA: 0x1311D08
	bool get_IsDownload() { }

	// RVA: 0x130EED0
	bool get_ShouldParseForResponseUri() { }

	// RVA: 0x1313554
	FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x13136CC
	void .cctor() { }

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

	// RVA: 0x131A718
	void MoveNext() { }

	// RVA: 0x131AB38
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.FtpWebRequest.<>c <>9; // 0x0
	public static System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0; // 0x8

	// Methods

	// RVA: 0x131AB44
	void .cctor() { }

	// RVA: 0x131ABB0
	void .ctor() { }

	// RVA: 0x131ABB8
	X509CertificateCollection <get_ClientCertificates>b__114_0() { }

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

	// RVA: 0x1313E74
	FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x1313E7C
	string get_Method() { }

	// RVA: 0x1313E9C
	void set_Method(string value) { }

	// RVA: 0x131408C
	string get_RenameTo() { }

	// RVA: 0x1314094
	ICredentials get_Credentials() { }

	// RVA: 0x131409C
	void set_Credentials(ICredentials value) { }

	// RVA: 0x1314240
	Uri get_RequestUri() { }

	// RVA: 0x1314248
	int get_Timeout() { }

	// RVA: 0x1314250
	int get_RemainingTimeout() { }

	// RVA: 0x1314258
	int get_ReadWriteTimeout() { }

	// RVA: 0x1314260
	Int64 get_ContentOffset() { }

	// RVA: 0x1314268
	Int64 get_ContentLength() { }

	// RVA: 0x1314270
	IWebProxy get_Proxy() { }

	// RVA: 0x1314278
	void set_Proxy(IWebProxy value) { }

	// RVA: 0x13142E8
	bool get_Aborted() { }

	// RVA: 0x13142F0
	void .ctor(Uri uri) { }

	// RVA: 0x1314914
	WebResponse GetResponse() { }

	// RVA: 0x131663C
	IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1316DF4
	WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1315688
	void SubmitRequest(bool isAsync) { }

	// RVA: 0x1317C14
	Exception TranslateConnectException(Exception e) { }

	// RVA: 0x131725C
	void CreateConnectionAsync() { }

	// RVA: 0x1317314
	FtpControlStream CreateConnection() { }

	// RVA: 0x1317558
	Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x1317E9C
	void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x1317E04
	Queue get_TimerQueue() { }

	// RVA: 0x13179A0
	bool AttemptedRecovery(Exception e) { }

	// RVA: 0x13161EC
	void SetException(Exception exception) { }

	// RVA: 0x131516C
	void CheckError() { }

	// RVA: 0x1318A10
	void RequestCallback(object obj) { }

	// RVA: 0x13195E4
	void SyncRequestCallback(object obj) { }

	// RVA: 0x1318A20
	void AsyncRequestCallback(object obj) { }

	// RVA: 0x1315204
	RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x1319A64
	void Abort() { }

	// RVA: 0x1319F40
	void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1319FB0
	bool get_UseBinary() { }

	// RVA: 0x1319FB8
	bool get_UsePassive() { }

	// RVA: 0x130DB64
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1319FC0
	bool get_EnableSsl() { }

	// RVA: 0x1319FC8
	WebHeaderCollection get_Headers() { }

	// RVA: 0x131A114
	bool get_UseDefaultCredentials() { }

	// RVA: 0x131406C
	bool get_InUse() { }

	// RVA: 0x1315C30
	void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x131A444
	void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x131A4DC
	void .cctor() { }

}

// Namespace: System.Net
internal class FtpWebRequestCreator 
{
	// Methods

	// RVA: 0x131AC10
	void .ctor() { }

	// RVA: 0x131AC18
	WebRequest Create(Uri uri) { }

}

// Namespace: 
internal sealed class EmptyStream 
{
	// Methods

	// RVA: 0x131AD0C
	void .ctor() { }

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

	// RVA: 0x131A294
	void .ctor(Stream responseStream, Int64 contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x13189D4
	void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x131AC84
	Stream GetResponseStream() { }

	// RVA: 0x131A1C8
	void SetResponseStream(Stream stream) { }

	// RVA: 0x131ADF8
	void Close() { }

	// RVA: 0x131AF34
	WebHeaderCollection get_Headers() { }

	// RVA: 0x131B0C0
	Uri get_ResponseUri() { }

	// RVA: 0x131B0C8
	FtpStatusCode get_StatusCode() { }

}

// Namespace: System.Net
internal class NetworkStreamWrapper 
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Methods

	// RVA: 0x131B0D0
	void .ctor(TcpClient client) { }

	// RVA: 0x130DADC
	bool get_UsingSecureStream() { }

	// RVA: 0x130CFC0
	IPAddress get_ServerAddress() { }

	// RVA: 0x130F250
	Socket get_Socket() { }

	// RVA: 0x131B16C
	NetworkStream get_NetworkStream() { }

	// RVA: 0x131B174
	void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x131B17C
	bool get_CanRead() { }

	// RVA: 0x131B1A0
	bool get_CanSeek() { }

	// RVA: 0x131B1C4
	bool get_CanWrite() { }

	// RVA: 0x131B1E8
	bool get_CanTimeout() { }

	// RVA: 0x131B20C
	int get_ReadTimeout() { }

	// RVA: 0x131B234
	void set_ReadTimeout(int value) { }

	// RVA: 0x131B25C
	int get_WriteTimeout() { }

	// RVA: 0x131B284
	void set_WriteTimeout(int value) { }

	// RVA: 0x131B2AC
	Int64 get_Length() { }

	// RVA: 0x131B2D0
	Int64 get_Position() { }

	// RVA: 0x131B2F4
	void set_Position(Int64 value) { }

	// RVA: 0x131B31C
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x131B344
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x131B36C
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x131B394
	void Dispose(bool disposing) { }

	// RVA: 0x130D108
	void CloseSocket() { }

	// RVA: 0x131B498
	void Close(int timeout) { }

	// RVA: 0x131B4D4
	IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x131B4FC
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x131B524
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x131B54C
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x131B574
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x131B59C
	Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x131B5C4
	void Flush() { }

	// RVA: 0x131B5EC
	Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1317504
	void SetSocketTimeoutOption(int timeout) { }

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

	// RVA: 0x131B614
	void .ctor(string token) { }

	// RVA: 0x131B6DC
	void .ctor(string token, bool finished) { }

	// RVA: 0x131B798
	string get_Message() { }

	// RVA: 0x131B7A0
	bool get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache 
{
	// Methods

	// RVA: 0x131B7A8
	ICredentials get_DefaultCredentials() { }

	// RVA: 0x131B824
	NetworkCredential get_DefaultNetworkCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential 
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x131B8A0
	void .ctor() { }

	// RVA: 0x131B904
	void .cctor() { }

}

// Namespace: System.Net
public abstract class EndPoint 
{
	// Methods

	// RVA: 0x131B9B4
	AddressFamily get_AddressFamily() { }

	// RVA: 0x131BA68
	SocketAddress Serialize() { }

	// RVA: 0x131BB1C
	EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x131BB48
	void .ctor() { }

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

	// RVA: 0x2FE3810
	Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x2FE37A0
	Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x2FE360C
	string get_AuthenticationType() { }

}

// Namespace: System.Net
public interface ICertificatePolicy 
{
	// Methods

	// RVA: -1
	bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

// Namespace: System.Net
public interface ICredentials 
{
	// Methods

	// RVA: 0x2FE37A0
	NetworkCredential GetCredential(Uri uri, string authType) { }

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

	// RVA: 0x131BB50
	string get_HostName() { }

	// RVA: 0x131BB58
	void set_HostName(string value) { }

	// RVA: 0x131BB60
	void set_Aliases(string[] value) { }

	// RVA: 0x131BB68
	IPAddress[] get_AddressList() { }

	// RVA: 0x131BB70
	void set_AddressList(IPAddress[] value) { }

	// RVA: 0x131BB78
	void .ctor() { }

}

// Namespace: System.Net
public interface IWebRequestCreate 
{
	// Methods

	// RVA: 0x2FE36BC
	WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal class InternalException 
{
	// Methods

	// RVA: 0x130D8D8
	void .ctor() { }

}

// Namespace: System.Net
internal static class NclUtilities 
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Methods

	// RVA: 0x131BB88
	bool IsFatal(Exception exception) { }

	// RVA: 0x131BC7C
	bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x131C33C
	IPHostEntry GetLocalHost() { }

	// RVA: 0x131BD0C
	IPAddress[] get_LocalAddresses() { }

	// RVA: 0x131C358
	object get_LocalAddressesLock() { }

}

// Namespace: System.Net
internal static class ValidationHelper 
{
	// Fields
	public static string[] EmptyArray; // 0x0
	internal static readonly Char[] InvalidMethodChars; // 0x8
	internal static readonly Char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0x131B6C8
	string MakeStringNull(string stringValue) { }

	// RVA: 0x131C414
	bool IsBlankString(string stringValue) { }

	// RVA: 0x131C430
	bool ValidateTcpPort(int port) { }

	// RVA: 0x131C43C
	void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper 
{
	// Methods

	// RVA: 0x131BA94
	NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x131B9E0
	NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x1315180
	WebException get_TimeoutException() { }

	// RVA: 0x131A140
	NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1311568
	WebException get_RequestAbortedException() { }

}

// Namespace: System.Net
internal class WebRequestPrefixElement 
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Methods

	// RVA: 0x131C61C
	IWebRequestCreate get_Creator() { }

	// RVA: 0x131C84C
	void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x131C854
	void .ctor(string P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate 
{
	// Methods

	// RVA: 0x131C8A4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x131C948
	internal void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

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

	// RVA: 0x13148A0
	void .ctor(string userName, string password) { }

	// RVA: 0x131A608
	void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1310AF0
	string get_UserName() { }

	// RVA: 0x131C95C
	void set_UserName(string value) { }

	// RVA: 0x1310B00
	string get_Password() { }

	// RVA: 0x131C9E0
	void set_Password(string value) { }

	// RVA: 0x1310AF8
	string get_Domain() { }

	// RVA: 0x131CA14
	void set_Domain(string value) { }

	// RVA: 0x131CAA4
	string InternalGetUserName() { }

	// RVA: 0x131CA98
	string InternalGetPassword() { }

	// RVA: 0x131CAAC
	string InternalGetDomain() { }

	// RVA: 0x131CAB4
	NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
public class ProtocolViolationException 
{
	// Methods

	// RVA: 0x131CAB8
	void .ctor() { }

	// RVA: 0x131CAC0
	void .ctor(string message) { }

	// RVA: 0x131CAC8
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131CAD0
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131CAD8
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

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

	// RVA: 0x131CAE0
	AddressFamily get_Family() { }

	// RVA: 0x131CB14
	int get_Size() { }

	// RVA: 0x131CB1C
	Byte get_Item(int offset) { }

	// RVA: 0x131CB9C
	void .ctor(AddressFamily family, int size) { }

	// RVA: 0x131CCD4
	void .ctor(IPAddress ipAddress) { }

	// RVA: 0x131CF38
	void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x131CF98
	IPAddress GetIPAddress() { }

	// RVA: 0x131D17C
	IPEndPoint GetIPEndPoint() { }

	// RVA: 0x131D220
	bool Equals(object comparand) { }

	// RVA: 0x131D32C
	int GetHashCode() { }

	// RVA: 0x131D664
	string ToString() { }

}

// Namespace: System.Net
public class WebException 
{
	// Fields
	private WebExceptionStatus m_Status; // 0x8C
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Methods

	// RVA: 0x131D940
	void .ctor() { }

	// RVA: 0x1310D10
	void .ctor(string message) { }

	// RVA: 0x13189C4
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x130D058
	void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x131D950
	void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1318904
	void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x131DAE4
	void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x131DA18
	void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x131DBD8
	void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x131DCD8
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131DCE8
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131DCF4
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131DCFC
	WebExceptionStatus get_Status() { }

	// RVA: 0x131DD04
	WebResponse get_Response() { }

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

	// RVA: 0x131DD0C
	string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x131DED8
	void .cctor() { }

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

	// RVA: 0x131DF58
	void NormalizeCommonHeaders() { }

	// RVA: 0x131E070
	NameValueCollection get_InnerCollection() { }

	// RVA: 0x131E13C
	bool AllowMultiValues(string name) { }

	// RVA: 0x131E338
	bool get_AllowHttpRequestHeader() { }

	// RVA: 0x131E380
	void Remove(HttpRequestHeader header) { }

	// RVA: 0x131E494
	void AddInternal(string name, string value) { }

	// RVA: 0x131E4F4
	void ChangeInternal(string name, string value) { }

	// RVA: 0x131E554
	void RemoveInternal(string name) { }

	// RVA: 0x131E5B4
	string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x131E988
	bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x131EA10
	void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x131EB88
	void Add(string name, string value) { }

	// RVA: 0x131ED44
	void Add(string header) { }

	// RVA: 0x131F030
	void Set(string name, string value) { }

	// RVA: 0x131F278
	void SetInternal(string name, string value) { }

	// RVA: 0x131F4B4
	void Remove(string name) { }

	// RVA: 0x131F604
	string[] GetValues(string header) { }

	// RVA: 0x131F83C
	string ToString() { }

	// RVA: 0x131F8A4
	string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x131A0A4
	void .ctor() { }

	// RVA: 0x131FBE4
	void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x131FCE0
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x131FEE0
	void OnDeserialization(object sender) { }

	// RVA: 0x131FEE4
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1320070
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x132007C
	string Get(string name) { }

	// RVA: 0x13203B4
	IEnumerator GetEnumerator() { }

	// RVA: 0x1320430
	int get_Count() { }

	// RVA: 0x132046C
	string Get(int index) { }

	// RVA: 0x13204B0
	string GetKey(int index) { }

	// RVA: 0x13204F4
	void .cctor() { }

}

// Namespace: System.Net
internal class CaseInsensitiveAscii 
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1320AB4
	int GetHashCode(object myObject) { }

	// RVA: 0x1320BD8
	int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1320D68
	int FastGetHashCode(string myString) { }

	// RVA: 0x1320E68
	bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x1321028
	void .ctor() { }

	// RVA: 0x1321030
	void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate 
{
	// Methods

	// RVA: 0x132287C
	WebRequest Create(Uri uri) { }

	// RVA: 0x1322780
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass79_0 
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x1322190
	void .ctor() { }

	// RVA: 0x13228FC
	System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1() { }

}

// Namespace: System.Net
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

	// RVA: 0x13210FC
	object get_InternalSyncObject() { }

	// RVA: 0x1321200
	WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1321670
	WebRequest Create(string requestUriString) { }

	// RVA: 0x1321764
	WebRequest Create(Uri requestUri) { }

	// RVA: 0x132149C
	ArrayList get_PrefixList() { }

	// RVA: 0x1321880
	ArrayList PopulatePrefixList() { }

	// RVA: 0x131474C
	void .ctor() { }

	// RVA: 0x1321B1C
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1321B24
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1321B30
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1321B34
	void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1321B38
	void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1321C08
	string get_Method() { }

	// RVA: 0x1321C34
	void set_Method(string value) { }

	// RVA: 0x1321C60
	Uri get_RequestUri() { }

	// RVA: 0x1321C8C
	WebHeaderCollection get_Headers() { }

	// RVA: 0x1321CB8
	Int64 get_ContentLength() { }

	// RVA: 0x1321CE4
	ICredentials get_Credentials() { }

	// RVA: 0x1321D10
	void set_Credentials(ICredentials value) { }

	// RVA: 0x1321D3C
	bool get_UseDefaultCredentials() { }

	// RVA: 0x1321D68
	IWebProxy get_Proxy() { }

	// RVA: 0x1321D94
	void set_Proxy(IWebProxy value) { }

	// RVA: 0x1321DC0
	int get_Timeout() { }

	// RVA: 0x1321DEC
	WebResponse GetResponse() { }

	// RVA: 0x1321E18
	IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1321E44
	WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1321E70
	System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }

	// RVA: 0x1322198
	WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1322208
	void Abort() { }

	// RVA: 0x1322234
	RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x132223C
	void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1322244
	IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1322460
	void .cctor() { }

	// RVA: 0x1322788
	System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

}

// Namespace: System.Net
public abstract class WebResponse 
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Methods

	// RVA: 0x131AC7C
	void .ctor() { }

	// RVA: 0x1322C04
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1322C0C
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1322C18
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1322C1C
	void Close() { }

	// RVA: 0x1322C20
	void Dispose() { }

	// RVA: 0x1322CB0
	void Dispose(bool disposing) { }

	// RVA: 0x1322D50
	bool get_IsFromCache() { }

	// RVA: 0x1322D58
	Stream GetResponseStream() { }

	// RVA: 0x1322D84
	Uri get_ResponseUri() { }

	// RVA: 0x1322DB0
	WebHeaderCollection get_Headers() { }

}

// Namespace: System.Net
internal class BufferOffsetSize 
{
	// Fields
	internal Byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x1322DDC
	void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x1322E98
	void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser 
{
	// Methods

	// RVA: 0x1322F54
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1323008
	internal string[] Invoke(string value) { }

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

	// RVA: 0x132301C
	void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

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

	// RVA: 0x1323090
	string[] ParseSingleValue(string value) { }

	// RVA: 0x1323114
	string[] ParseMultiValue(string value) { }

	// RVA: 0x13234AC
	void .cctor() { }

	// RVA: 0x131E210
	HeaderInfo get_Item(string name) { }

	// RVA: 0x1320AAC
	void .ctor() { }

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

	// RVA: 0x2FE42A4
	void CloseEx(CloseExState closeState) { }

}

// Namespace: 
private class ThreadContext 
{
	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x13256B8
	void .ctor() { }

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

	// RVA: 0x1325600
	ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1312F20
	void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x13256C0
	object get_AsyncObject() { }

	// RVA: 0x13256C8
	object get_AsyncState() { }

	// RVA: 0x13256D0
	AsyncCallback get_AsyncCallback() { }

	// RVA: 0x13256D8
	WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1325798
	bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x132597C
	bool get_CompletedSynchronously() { }

	// RVA: 0x1312C8C
	bool get_IsCompleted() { }

	// RVA: 0x1316DD8
	bool get_InternalPeekCompleted() { }

	// RVA: 0x13259C0
	bool get_EndCalled() { }

	// RVA: 0x13259C8
	void set_EndCalled(bool value) { }

	// RVA: 0x13259D0
	void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1312C84
	void InvokeCallback(object result) { }

	// RVA: 0x1316DE8
	void InvokeCallback() { }

	// RVA: 0x1325C00
	void Complete(IntPtr userToken) { }

	// RVA: 0x1325DA0
	void WorkerThreadComplete(object state) { }

	// RVA: 0x1325E64
	void Cleanup() { }

	// RVA: 0x13131CC
	object InternalWaitForCompletion() { }

	// RVA: 0x1325E68
	object WaitForCompletion(bool snap) { }

}

// Namespace: System.Net
internal class NetRes 
{
	// Methods

	// RVA: 0x131C560
	string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1326170
	string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x13261D8
	string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Namespace: 
internal abstract class Queue 
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x13274A0
	void .ctor(int durationMilliseconds) { }

	// RVA: 0x13274CC
	int get_Duration() { }

	// RVA: 0x2FE37A0
	Timer CreateTimer(Callback callback, object context) { }

}

// Namespace: 
internal abstract class Timer 
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x13274D4
	void .ctor(int durationMilliseconds) { }

	// RVA: 0x132750C
	int get_StartTime() { }

	// RVA: 0x1327514
	int get_Expiration() { }

	// RVA: 0x2FE3054
	bool Cancel() { }

	// RVA: 0x2FE3054
	bool get_HasExpired() { }

	// RVA: 0x1327520
	void Dispose() { }

}

// Namespace: 
internal sealed class Callback 
{
	// Methods

	// RVA: 0x131477C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132752C
	internal void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Namespace: 
private class TimerQueue 
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x13266AC
	void .ctor(int durationMilliseconds) { }

	// RVA: 0x132757C
	Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x13270F8
	bool Fire(out int nextExpiration) { }

}

// Namespace: 
private class InfiniteTimerQueue 
{
	// Methods

	// RVA: 0x1326680
	void .ctor() { }

	// RVA: 0x1327B80
	Timer CreateTimer(Callback callback, object context) { }

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

	// RVA: 0x13277F8
	void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x1327540
	void .ctor() { }

	// RVA: 0x1327C24
	bool get_HasExpired() { }

	// RVA: 0x1327C34
	TimerNode get_Next() { }

	// RVA: 0x1327C3C
	void set_Next(TimerNode value) { }

	// RVA: 0x1327C44
	TimerNode get_Prev() { }

	// RVA: 0x1327C4C
	void set_Prev(TimerNode value) { }

	// RVA: 0x1327C54
	bool Cancel() { }

	// RVA: 0x1327880
	bool Fire() { }

}

// Namespace: 
private class InfiniteTimer 
{
	// Fields
	private int cancelled; // 0x18

	// Methods

	// RVA: 0x1327BEC
	void .ctor() { }

	// RVA: 0x1327DFC
	bool get_HasExpired() { }

	// RVA: 0x1327E04
	bool Cancel() { }

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

	// RVA: 0x13263B4
	void .cctor() { }

	// RVA: 0x1322524
	Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1317FF4
	Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x1326770
	void Prod() { }

	// RVA: 0x13268A0
	void ThreadProc() { }

	// RVA: 0x13272F0
	void StopTimerThread() { }

	// RVA: 0x13272CC
	bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x1327370
	void OnDomainUnload(object sender, EventArgs e) { }

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

	// RVA: 0x1327E2C
	void .ctor() { }

	// RVA: 0x1327F88
	string get_Comment() { }

	// RVA: 0x1327F90
	void set_Comment(string value) { }

	// RVA: 0x1327FFC
	void set_CommentUri(Uri value) { }

	// RVA: 0x1328004
	void set_HttpOnly(bool value) { }

	// RVA: 0x132800C
	void set_Discard(bool value) { }

	// RVA: 0x1328014
	string get_Domain() { }

	// RVA: 0x132801C
	void set_Domain(string value) { }

	// RVA: 0x13280BC
	string get__Domain() { }

	// RVA: 0x13281B0
	bool get_Expired() { }

	// RVA: 0x1328298
	void set_Expires(DateTime value) { }

	// RVA: 0x13282A0
	string get_Name() { }

	// RVA: 0x13282A8
	bool InternalSetName(string value) { }

	// RVA: 0x13283D8
	string get_Path() { }

	// RVA: 0x13283E0
	void set_Path(string value) { }

	// RVA: 0x1328464
	string get__Path() { }

	// RVA: 0x13281A0
	bool get_Plain() { }

	// RVA: 0x1328504
	bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1328568
	bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1329004
	bool DomainCharsTest(string name) { }

	// RVA: 0x132909C
	void set_Port(string value) { }

	// RVA: 0x1329428
	int[] get_PortList() { }

	// RVA: 0x1329430
	string get__Port() { }

	// RVA: 0x132950C
	bool get_Secure() { }

	// RVA: 0x1329514
	void set_Secure(bool value) { }

	// RVA: 0x132951C
	string get_Value() { }

	// RVA: 0x1329524
	void set_Value(string value) { }

	// RVA: 0x13295A0
	CookieVariant get_Variant() { }

	// RVA: 0x13295A8
	string get_DomainKey() { }

	// RVA: 0x13295C4
	int get_Version() { }

	// RVA: 0x13295CC
	void set_Version(int value) { }

	// RVA: 0x132964C
	string get__Version() { }

	// RVA: 0x132975C
	IComparer GetComparer() { }

	// RVA: 0x13297D8
	bool Equals(object comparand) { }

	// RVA: 0x13298C0
	int GetHashCode() { }

	// RVA: 0x1329AB4
	string ToString() { }

	// RVA: 0x1329E0C
	void .cctor() { }

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

	// RVA: 0x11E9FA8
	void .ctor(string name, CookieToken token) { }

	// RVA: 0x11E9FD4
	CookieToken get_Token() { }

	// RVA: 0x11E99C4
	bool IsEqualTo(string value) { }

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

	// RVA: 0x11E8FB4
	void .ctor(string tokenStream) { }

	// RVA: 0x11E8FF8
	bool get_EndOfCookie() { }

	// RVA: 0x11E9000
	void set_EndOfCookie(bool value) { }

	// RVA: 0x11E9008
	bool get_Eof() { }

	// RVA: 0x11E9018
	string get_Name() { }

	// RVA: 0x11E9020
	void set_Name(string value) { }

	// RVA: 0x11E9028
	bool get_Quoted() { }

	// RVA: 0x11E9030
	void set_Quoted(bool value) { }

	// RVA: 0x11E9038
	CookieToken get_Token() { }

	// RVA: 0x11E9040
	void set_Token(CookieToken value) { }

	// RVA: 0x11E9048
	string get_Value() { }

	// RVA: 0x11E9050
	void set_Value(string value) { }

	// RVA: 0x11E9058
	string Extract() { }

	// RVA: 0x11E90F0
	CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x11E9438
	CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x11E974C
	void Reset() { }

	// RVA: 0x11E97D8
	CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x11E99EC
	void .cctor() { }

}

// Namespace: System.Net
internal class CookieParser 
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x11E9FDC
	void .ctor(string cookieString) { }

	// RVA: 0x11EA078
	Cookie Get() { }

	// RVA: 0x11EA628
	string CheckQuoted(string value) { }

}

// Namespace: System.Net
internal class Comparer 
{
	// Methods

	// RVA: 0x11EA6E8
	int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x11EA7D0
	void .ctor() { }

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

	// RVA: 0x11EB80C
	void .ctor(CookieCollection cookies) { }

	// RVA: 0x11EB878
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x11EB920
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x11EB9C0
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Net
public class CookieCollection 
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	private bool m_IsReadOnly; // 0x29

	// Methods

	// RVA: 0x11EA7D8
	void .ctor() { }

	// RVA: 0x11EA890
	Cookie get_Item(int index) { }

	// RVA: 0x11EA984
	void Add(Cookie cookie) { }

	// RVA: 0x11EAE10
	void Add(CookieCollection cookies) { }

	// RVA: 0x11EB1A8
	int get_Count() { }

	// RVA: 0x11EB1D0
	bool get_IsSynchronized() { }

	// RVA: 0x11EB1D8
	object get_SyncRoot() { }

	// RVA: 0x11EB1DC
	void CopyTo(Array array, int index) { }

	// RVA: 0x11EB204
	DateTime TimeStamp(Stamp how) { }

	// RVA: 0x11EB30C
	bool get_IsOtherVersionSeen() { }

	// RVA: 0x11EB314
	int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x11EAA48
	int IndexOf(Cookie cookie) { }

	// RVA: 0x11EB7E4
	void RemoveAt(int idx) { }

	// RVA: 0x11EB100
	IEnumerator GetEnumerator() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo 
{
	// Fields
	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Methods

	// RVA: 0x11EB9CC
	void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x11EB9F8
	string get_Name() { }

	// RVA: 0x11EBA00
	CookieVariant get_Variant() { }

}

// Namespace: System.Net
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

	// RVA: 0x11EBA08
	void .ctor() { }

	// RVA: 0x11EBB34
	void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x11EBC74
	void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x11ECB20
	bool AgeCookies(string domain) { }

	// RVA: 0x11EE014
	int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x11EE1E8
	bool IsLocalDomain(string host) { }

	// RVA: 0x11EE678
	CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x11EED4C
	CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x11EF094
	void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x11EF9B0
	void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x11EFBE0
	string GetCookieHeader(Uri uri) { }

	// RVA: 0x11EFCDC
	string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x11F0078
	void .cctor() { }

}

// Namespace: 
private class PathListComparer 
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x11F01AC
	int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x11F034C
	void .ctor() { }

	// RVA: 0x11F0354
	void .cctor() { }

}

// Namespace: System.Net
internal class PathList 
{
	// Fields
	private SortedList m_list; // 0x10

	// Methods

	// RVA: 0x11EC4D8
	void .ctor() { }

	// RVA: 0x11EE1C0
	int get_Count() { }

	// RVA: 0x11EC590
	int GetCookiesCount() { }

	// RVA: 0x11EDFEC
	ICollection get_Values() { }

	// RVA: 0x11EC9E4
	object get_Item(string s) { }

	// RVA: 0x11ECA0C
	void set_Item(string s, object value) { }

	// RVA: 0x11EF988
	IEnumerator GetEnumerator() { }

	// RVA: 0x11EC9BC
	object get_SyncRoot() { }

}

// Namespace: System.Net
public class CookieException 
{
	// Methods

	// RVA: 0x11F03C0
	void .ctor() { }

	// RVA: 0x11EC4D0
	void .ctor(string message) { }

	// RVA: 0x11EDFE4
	void .ctor(string message, Exception inner) { }

	// RVA: 0x11F03C8
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F03D0
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F03D8
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net
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

	// RVA: 0x11F03E0
	void .ctor(Uri uri) { }

	// RVA: 0x11F0570
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F09A4
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F09B0
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F0C80
	bool get_Aborted() { }

	// RVA: 0x11F0C90
	Int64 get_ContentLength() { }

	// RVA: 0x11F0C98
	ICredentials get_Credentials() { }

	// RVA: 0x11F0CA0
	void set_Credentials(ICredentials value) { }

	// RVA: 0x11F0CA8
	WebHeaderCollection get_Headers() { }

	// RVA: 0x11F0CB0
	string get_Method() { }

	// RVA: 0x11F0CB8
	void set_Method(string value) { }

	// RVA: 0x11F0DB4
	IWebProxy get_Proxy() { }

	// RVA: 0x11F0DBC
	void set_Proxy(IWebProxy value) { }

	// RVA: 0x11F0DC4
	int get_Timeout() { }

	// RVA: 0x11F0DCC
	Uri get_RequestUri() { }

	// RVA: 0x11F0DD4
	IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x11F1104
	WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x11F13E8
	WebResponse GetResponse() { }

	// RVA: 0x11F1758
	void GetRequestStreamCallback(object state) { }

	// RVA: 0x11F1A84
	void GetResponseCallback(object state) { }

	// RVA: 0x11F2134
	void UnblockReader() { }

	// RVA: 0x11F2224
	bool get_UseDefaultCredentials() { }

	// RVA: 0x11F2254
	void Abort() { }

	// RVA: 0x11F25D0
	void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator 
{
	// Methods

	// RVA: 0x11F26C0
	void .ctor() { }

	// RVA: 0x11F26C8
	WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream 
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x11F19DC
	void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x11F272C
	void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x11F27EC
	void Dispose(bool disposing) { }

	// RVA: 0x11F28C8
	void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x11F2908
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x11F2AA0
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x11F2BB4
	IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x11F2CC8
	int EndRead(IAsyncResult ar) { }

	// RVA: 0x11F2D70
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x11F2E84
	void EndWrite(IAsyncResult ar) { }

	// RVA: 0x11F2A1C
	void CheckError() { }

}

// Namespace: System.Net
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

	// RVA: 0x11F1DC0
	void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x11F2F2C
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F31B4
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F31C0
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F33A8
	WebHeaderCollection get_Headers() { }

	// RVA: 0x11F344C
	Uri get_ResponseUri() { }

	// RVA: 0x11F33CC
	void CheckDisposed() { }

	// RVA: 0x11F3470
	void Close() { }

	// RVA: 0x11F3514
	void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x11F3698
	Stream GetResponseStream() { }

}

// Namespace: System.Net
public interface IWebProxy 
{
	// Methods

	// RVA: 0x2FE36BC
	Uri GetProxy(Uri destination) { }

	// RVA: 0x2FE3174
	bool IsBypassed(Uri host) { }

	// RVA: 0x2FE360C
	ICredentials get_Credentials() { }

}

// Namespace: System.Net
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

	// RVA: 0x11F36F4
	void .ctor() { }

	// RVA: 0x11F3768
	void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x11F3B38
	ICredentials get_Credentials() { }

	// RVA: 0x11F3B40
	bool get_UseDefaultCredentials() { }

	// RVA: 0x11F3BC8
	void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x11F3C5C
	Uri GetProxy(Uri destination) { }

	// RVA: 0x11F3840
	void UpdateRegExList(bool canThrow) { }

	// RVA: 0x11F3FD0
	bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x11F4184
	bool IsLocal(Uri host) { }

	// RVA: 0x11F4320
	bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x11F4428
	bool IsBypassed(Uri host) { }

	// RVA: 0x11F3EE0
	bool IsBypassedManual(Uri host) { }

	// RVA: 0x11F45C4
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F49D8
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F49E4
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11F4B78
	AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x11F4B80
	IWebProxy CreateDefaultProxy() { }

	// RVA: 0x11F4BE4
	void .ctor(bool enableAutoproxy) { }

	// RVA: 0x11F49CC
	void UnsafeUpdateFromRegistry() { }

	// RVA: 0x11F3E58
	bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x11F4550
	bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x11F4C3C
	bool AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, bool checkFirstOnly) { }

	// RVA: 0x11F4F18
	Uri ProxyUri(string proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine 
{
	// Methods

	// RVA: 0x11F4C18
	bool GetProxies(Uri destination, out System.Collections.Generic.IList<System.String>& proxyList) { }

	// RVA: 0x11F4FC0
	bool GetProxies(Uri destination, out System.Collections.Generic.IList<System.String>& proxyList, ref int syncStatus) { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID 
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x11F5678
	string ToString(int position) { }

	// RVA: 0x11F5718
	void .cctor() { }

}

// Namespace: 
internal static class HttpApi 
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x11F4FE4
	void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper 
{
	// Methods

	// RVA: 0x11F5FBC
	string CreateString(SecureString secureString) { }

	// RVA: 0x11F6140
	SecureString CreateSecureString(string plainString) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods 
{}

// Namespace: System.Net
internal static class Logging 
{
	// Methods

	// RVA: 0x11F10FC
	bool get_On() { }

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

	// RVA: 0x11F64D0
	void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
internal class ServerCertValidationCallback 
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x11F61F0
	void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x11F6280
	RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x11F6288
	void Callback(object state) { }

	// RVA: 0x11F633C
	bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
public class AuthenticationManager 
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x11F6548
	void EnsureModules() { }

	// RVA: 0x11F6804
	Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x11F6908
	Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x11F6DD8
	Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x11F72F4
	void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient 
{
	// Methods

	// RVA: 0x11F7388
	Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11F77AC
	Byte[] GetBytes(string str) { }

	// RVA: 0x11F7438
	Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11F786C
	Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11F7878
	string get_AuthenticationType() { }

	// RVA: 0x11F67FC
	void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint 
{
	// Methods

	// RVA: 0x11F78BC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x11F79E0
	internal IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

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

	// RVA: 0x11F7C3C
	void MoveNext() { }

	// RVA: 0x11F7FAC
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class BufferedReadStream 
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x11F79F4
	void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x11F7A28
	System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x11F7B94
	bool TryReadFromBuffer(Byte[] buffer, int offset, int size, out int result) { }

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

	// RVA: 0x11F802C
	ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x11F814C
	Stream get_OriginalInnerStream() { }

	// RVA: 0x11F8118
	void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x11F8154
	System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x11F817C
	Task FinishReading(CancellationToken cancellationToken) { }

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

	// RVA: 0x11F82AC
	void .ctor(string header) { }

	// RVA: 0x11F8394
	string get_Realm() { }

	// RVA: 0x11F83C0
	string get_Opaque() { }

	// RVA: 0x11F83F0
	string get_Nonce() { }

	// RVA: 0x11F8420
	string get_Algorithm() { }

	// RVA: 0x11F8450
	string get_QOP() { }

	// RVA: 0x11F8480
	bool Parse() { }

	// RVA: 0x11F892C
	void SkipWhitespace() { }

	// RVA: 0x11F89B8
	string GetKey() { }

	// RVA: 0x11F86BC
	bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x11F8AAC
	void .cctor() { }

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

	// RVA: 0x11F8C30
	void .cctor() { }

	// RVA: 0x11F8C90
	void .ctor() { }

	// RVA: 0x11F8D0C
	string get_Algorithm() { }

	// RVA: 0x11F8D44
	string get_Realm() { }

	// RVA: 0x11F8D78
	string get_Nonce() { }

	// RVA: 0x11F8DB0
	string get_Opaque() { }

	// RVA: 0x11F8DE8
	string get_QOP() { }

	// RVA: 0x11F8E20
	string get_CNonce() { }

	// RVA: 0x11F8F38
	bool Parse(string challenge) { }

	// RVA: 0x11F903C
	string HashToHexString(string toBeHashed) { }

	// RVA: 0x11F91A8
	string HA1(string username, string password) { }

	// RVA: 0x11F92E4
	string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x11F93D0
	string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x11F9550
	Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11F9BAC
	DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient 
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Methods

	// RVA: 0x11F9BB4
	Hashtable get_Cache() { }

	// RVA: 0x11F9D58
	void CheckExpired(int count) { }

	// RVA: 0x11FA584
	Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11FA894
	Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x11FAA44
	string get_AuthenticationType() { }

	// RVA: 0x11F67F4
	void .ctor() { }

	// RVA: 0x11FAA88
	void .cctor() { }

}

// Namespace: 
private sealed class GetHostAddressesCallback 
{
	// Methods

	// RVA: 0x11FAD6C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x11FBC4C
	internal IPAddress[] Invoke(string hostName) { }

	// RVA: 0x11FAE20
	internal IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x11FAF7C
	internal IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public static class Dns 
{
	// Methods

	// RVA: 0x11FAB1C
	IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x11FAE70
	IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x11FAF88
	bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x11FAF8C
	bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x11FAF90
	bool GetHostName_icall(out string h_name) { }

	// RVA: 0x11FAF94
	void Error_11001(string hostName) { }

	// RVA: 0x11FAFFC
	IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x11FB390
	IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x11FB510
	IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x11FB6BC
	IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x11FB86C
	IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x11FB730
	IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x11FBA90
	string GetHostName() { }

	// RVA: 0x11FBB28
	System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

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

	// RVA: 0x11FBE00
	void MoveNext() { }

	// RVA: 0x11FC174
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class FixedSizeReadStream 
{
	// Fields
	private readonly Int64 <ContentLength>k__BackingField; // 0x40
	private Int64 position; // 0x48

	// Methods

	// RVA: 0x11FBC60
	Int64 get_ContentLength() { }

	// RVA: 0x11FBC68
	void .ctor(WebOperation operation, Stream innerStream, Int64 contentLength) { }

	// RVA: 0x11FBC94
	System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class HttpRequestCreator 
{
	// Methods

	// RVA: 0x11FC1F4
	void .ctor() { }

	// RVA: 0x11FC1FC
	WebRequest Create(Uri uri) { }

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

	// RVA: 0x1200358
	bool get_IsCompleted() { }

	// RVA: 0x1200360
	NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1200368
	bool get_IsNtlmAuthenticated() { }

	// RVA: 0x11FC750
	void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x11FF690
	bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x120017C
	void Reset() { }

	// RVA: 0x1200388
	string ToString() { }

}

// Namespace: 
private sealed class <>c__241<T0> 
{
	// Fields
	public static readonly System.Net.HttpWebRequest.<>c__241<T> <>9; // 0x0
	public static System.Func<System.Threading.Tasks.Task<T>,System.Nullable<System.Int32>> <>9__241_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	System.Nullable<System.Int32> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t) { }

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

	// RVA: 0x2FE41A8
	void MoveNext() { }

	// RVA: 0x2FE4574
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1200494
	void MoveNext() { }

	// RVA: 0x120183C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x12018BC
	void MoveNext() { }

	// RVA: 0x1202504
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1202584
	void MoveNext() { }

	// RVA: 0x1202A2C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
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

	// RVA: 0x11FC4D0
	void .cctor() { }

	// RVA: 0x11FC260
	void .ctor(Uri uri) { }

	// RVA: 0x11FC5E4
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11FC564
	void ResetAuthorization() { }

	// RVA: 0x11FC784
	Uri get_Address() { }

	// RVA: 0x11FC78C
	bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x11FC794
	DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x11FC79C
	bool get_InternalAllowBuffering() { }

	// RVA: 0x11FC7B0
	bool get_MethodWithBuffer() { }

	// RVA: 0x11FC8BC
	MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x11FC8C4
	MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x11FC8CC
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x11FC954
	Int64 get_ContentLength() { }

	// RVA: 0x11FC95C
	void set_InternalContentLength(Int64 value) { }

	// RVA: 0x11FC964
	bool get_ThrowOnError() { }

	// RVA: 0x11FC96C
	void set_ThrowOnError(bool value) { }

	// RVA: 0x11FC974
	ICredentials get_Credentials() { }

	// RVA: 0x11FC97C
	void set_Credentials(ICredentials value) { }

	// RVA: 0x11FC984
	int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x11FCA00
	WebHeaderCollection get_Headers() { }

	// RVA: 0x11FCA08
	string get_Host() { }

	// RVA: 0x11FCB60
	bool get_KeepAlive() { }

	// RVA: 0x11FCB68
	int get_ReadWriteTimeout() { }

	// RVA: 0x11FCB70
	string get_Method() { }

	// RVA: 0x11FCB78
	void set_Method(string value) { }

	// RVA: 0x11FCDD4
	Version get_ProtocolVersion() { }

	// RVA: 0x11FCDDC
	IWebProxy get_Proxy() { }

	// RVA: 0x11FCDE4
	void set_Proxy(IWebProxy value) { }

	// RVA: 0x11FD030
	Uri get_RequestUri() { }

	// RVA: 0x11FD038
	bool get_SendChunked() { }

	// RVA: 0x11FD040
	ServicePoint get_ServicePoint() { }

	// RVA: 0x11FD044
	ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x11FD04C
	int get_Timeout() { }

	// RVA: 0x11FD054
	string get_TransferEncoding() { }

	// RVA: 0x11FD0AC
	bool get_UseDefaultCredentials() { }

	// RVA: 0x11FD140
	bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x11FD148
	bool get_ExpectContinue() { }

	// RVA: 0x11FD150
	void set_ExpectContinue(bool value) { }

	// RVA: 0x11FD158
	Uri get_AuthUri() { }

	// RVA: 0x11FD160
	bool get_ProxyQuery() { }

	// RVA: 0x11FD19C
	ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x11FD1A4
	RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x11FCED4
	ServicePoint GetServicePoint() { }

	// RVA: 0x11FD1BC
	WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x309AF8C
	System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationToken cancellationToken) { }

	// RVA: -1
	System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationTokenSource cts) { }

	// RVA: 0x2FE36BC
	System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }

	// RVA: 0x11FD410
	System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x11FD55C
	System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x11FD6B8
	Exception FlattenException(Exception e) { }

	// RVA: 0x11FD788
	WebException GetWebException(Exception e) { }

	// RVA: 0x11FD838
	WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x11FDA10
	WebException CreateRequestAbortedException() { }

	// RVA: 0x11FDAD0
	IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x11FDC98
	WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x11FDDEC
	WebResponse GetResponse() { }

	// RVA: 0x11FDF08
	void set_FinishedReading(bool value) { }

	// RVA: 0x11FD80C
	bool get_Aborted() { }

	// RVA: 0x11FDF10
	void Abort() { }

	// RVA: 0x11FE034
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11FE074
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11FCE6C
	void CheckRequestStarted() { }

	// RVA: 0x11FE0B4
	void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x11FE0D0
	void RewriteRedirectToGet() { }

	// RVA: 0x11FE160
	bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x11FE71C
	string GetHeaders() { }

	// RVA: 0x11FEE14
	void DoPreAuthenticate() { }

	// RVA: 0x11FF058
	Byte[] GetRequestHeaders() { }

	// RVA: 0x11FF3B4
	System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x11FF678
	bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x11FF9E0
	System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x11FFBEC
	System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x2FE3054
	bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x1200204
	System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	// RVA: 0x120031C
	void .ctor() { }

}

// Namespace: System.Net
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

	// RVA: 0x1202AAC
	void .ctor() { }

	// RVA: 0x1202AB4
	void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x120219C
	void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x1202E00
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1203208
	WebHeaderCollection get_Headers() { }

	// RVA: 0x1203210
	Uri get_ResponseUri() { }

	// RVA: 0x12032B4
	HttpStatusCode get_StatusCode() { }

	// RVA: 0x12032BC
	string get_StatusDescription() { }

	// RVA: 0x12032E0
	Stream GetResponseStream() { }

	// RVA: 0x1203388
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1203394
	void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1203560
	void Close() { }

	// RVA: 0x1203594
	void System.IDisposable.Dispose() { }

	// RVA: 0x12035A4
	void Dispose(bool disposing) { }

	// RVA: 0x1203234
	void CheckDisposed() { }

	// RVA: 0x1202BAC
	void FillCookies() { }

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

	// RVA: 0x1204858
	void .ctor(Byte[] chunk) { }

	// RVA: 0x120488C
	int Read(Byte[] buffer, int offset, int size) { }

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

	// RVA: 0x12035B8
	void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1203694
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1203698
	int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1203A90
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1203ABC
	void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1204668
	bool get_WantMore() { }

	// RVA: 0x120468C
	bool get_DataAvailable() { }

	// RVA: 0x12047A0
	int get_ChunkLeft() { }

	// RVA: 0x1203FF0
	State ReadBody(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1203BFC
	State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1204800
	string RemoveChunkExtension(string input) { }

	// RVA: 0x1204138
	State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x120429C
	State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	// RVA: 0x12047AC
	void ThrowProtocolViolation(string message) { }

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

	// RVA: 0x1204ED0
	void MoveNext() { }

	// RVA: 0x1205384
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1205404
	void MoveNext() { }

	// RVA: 0x12059E0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class MonoChunkStream 
{
	// Fields
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Methods

	// RVA: 0x12048F0
	MonoChunkParser get_Decoder() { }

	// RVA: 0x12048F8
	void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x1204AB0
	System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1204C1C
	Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1204D28
	void ThrowExpectingChunkTrailer() { }

	// RVA: 0x1204D88
	Task <>n__0(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class NtlmClient 
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Methods

	// RVA: 0x1205A4C
	void .ctor() { }

	// RVA: 0x1205AC4
	Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1205BA4
	Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1205BAC
	string get_AuthenticationType() { }

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

	// RVA: 0x1205BF0
	void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1205F7C
	SPKey get_Key() { }

	// RVA: 0x1205F84
	ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1205F8C
	void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x1205F94
	Uri get_Address() { }

	// RVA: 0x1205F9C
	int get_ConnectionLimit() { }

	// RVA: 0x1205FA4
	Version get_ProtocolVersion() { }

	// RVA: 0x1205FAC
	void set_Expect100Continue(bool value) { }

	// RVA: 0x1205FB4
	bool get_UseNagleAlgorithm() { }

	// RVA: 0x1205FBC
	void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x1205FC4
	bool get_SendContinue() { }

	// RVA: 0x120606C
	void set_SendContinue(bool value) { }

	// RVA: 0x1206074
	void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x1206124
	void KeepAliveSetup(Socket socket) { }

	// RVA: 0x1206298
	void PutBytes(Byte[] bytes, UInt32 v, int offset) { }

	// RVA: 0x120631C
	bool get_UsesProxy() { }

	// RVA: 0x1206324
	void set_UsesProxy(bool value) { }

	// RVA: 0x120632C
	bool get_UseConnect() { }

	// RVA: 0x1206334
	void set_UseConnect(bool value) { }

	// RVA: 0x120633C
	bool get_HasTimedOut() { }

	// RVA: 0x12064A8
	IPHostEntry get_HostEntry() { }

	// RVA: 0x12068A4
	void SetVersion(Version version) { }

	// RVA: 0x12068AC
	void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1206B78
	void FreeServicePoint() { }

	// RVA: 0x1206B8C
	void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x1206BE4
	void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x1206C3C
	bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

}

// Namespace: 
internal class SPKey 
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Methods

	// RVA: 0x1207970
	void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x1207A88
	bool get_UsesProxy() { }

	// RVA: 0x1207AF4
	int GetHashCode() { }

	// RVA: 0x1207BD4
	bool Equals(object obj) { }

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

	// RVA: 0x1206E88
	void .cctor() { }

	// RVA: 0x1206F4C
	ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x1206FC8
	bool get_CheckCertificateRevocationList() { }

	// RVA: 0x1207044
	int get_DnsRefreshTimeout() { }

	// RVA: 0x12070C0
	SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x120713C
	ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x12071B8
	RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1207264
	ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x12079CC
	void RemoveServicePoint(ServicePoint sp) { }

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

	// RVA: 0x1209DB4
	ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1207EDC
	void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x120870C
	bool IsEmpty() { }

	// RVA: 0x1209164
	void RemoveConnection(WebConnection connection) { }

	// RVA: 0x1209334
	void Cleanup() { }

	// RVA: 0x1209BEC
	void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x1209678
	WebOperation GetNextOperation() { }

	// RVA: 0x1209E98
	WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x1209474
	System.ValueTuple<System.Net.WebConnection,System.Boolean> CreateOrReuseConnection(WebOperation operation, bool force) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.ServicePointScheduler.AsyncManualResetEvent.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Boolean> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x120AB18
	void .cctor() { }

	// RVA: 0x120AB84
	void .ctor() { }

	// RVA: 0x120AB8C
	bool <Set>b__4_0(object s) { }

}

// Namespace: 
private class AsyncManualResetEvent 
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs; // 0x10

	// Methods

	// RVA: 0x120AAB8
	System.Threading.Tasks.Task<System.Boolean> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x1208120
	void Set() { }

	// RVA: 0x1208B08
	void Reset() { }

	// RVA: 0x1207E20
	void .ctor(bool state) { }

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

	// RVA: 0x120AC40
	void MoveNext() { }

	// RVA: 0x120B9B8
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x120BA24
	void MoveNext() { }

	// RVA: 0x120BFAC
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1207E08
	ServicePoint get_ServicePoint() { }

	// RVA: 0x1207E10
	void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1207E18
	int get_MaxIdleTime() { }

	// RVA: 0x1205CFC
	void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1208020
	void Run() { }

	// RVA: 0x12083F8
	Task RunScheduler() { }

	// RVA: 0x12084E4
	void Cleanup() { }

	// RVA: 0x120878C
	void RunSchedulerIteration() { }

	// RVA: 0x1208CC8
	bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x120963C
	void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x1208BD4
	bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x12097D4
	void RemoveOperation(WebOperation operation) { }

	// RVA: 0x1209210
	void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x12098F8
	void FinalCleanup() { }

	// RVA: 0x1206A40
	void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x12099CC
	ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x1209C50
	void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x1209C5C
	void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x1209C84
	System.Threading.Tasks.Task<System.Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x1209DB0
	Task <Run>b__31_0() { }

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

	// RVA: 0x309AF8C
	Status get_Status() { }

	// RVA: 0x2FE3054
	bool get_Success() { }

	// RVA: 0x2FE360C
	ExceptionDispatchInfo get_Error() { }

	// RVA: 0x309AF8C
	T get_Argument() { }

	// RVA: 0x309AF8C
	void .ctor(T argument) { }

	// RVA: 0x309AF8C
	void .ctor(Status state, ExceptionDispatchInfo error) { }

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

	// RVA: 0x2FE41A8
	void MoveNext() { }

	// RVA: 0x2FE4574
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebCompletionSource<T0> 
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion; // 0x0
	private Result currentResult; // 0x0

	// Methods

	// RVA: 0x2FE4234
	void .ctor(bool runAsync) { }

	// RVA: 0x2FE360C
	Result get_CurrentResult() { }

	// RVA: 0x2FE360C
	Task get_Task() { }

	// RVA: 0x309AF8C
	bool TrySetCompleted(T argument) { }

	// RVA: 0x2FE3054
	bool TrySetCompleted() { }

	// RVA: 0x2FE3054
	bool TrySetCanceled() { }

	// RVA: 0x2FE3174
	bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x2FE3174
	bool TrySetException(Exception error) { }

	// RVA: 0x2FE41A8
	void ThrowOnError() { }

	// RVA: 0x2FE360C
	System.Threading.Tasks.Task<T> WaitForCompletion() { }

}

// Namespace: System.Net
internal class WebCompletionSource 
{
	// Methods

	// RVA: 0x120C02C
	void .ctor() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.WebConnection.<>c <>9; // 0x0
	public static System.Func<System.Net.IPEndPoint,System.AsyncCallback,System.Object,System.IAsyncResult> <>9__16_0; // 0x8
	public static System.Action<System.IAsyncResult> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x120D528
	void .cctor() { }

	// RVA: 0x120D594
	void .ctor() { }

	// RVA: 0x120D59C
	IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x120D640
	void <Connect>b__16_1(IAsyncResult asyncResult) { }

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

	// RVA: 0x120D744
	void MoveNext() { }

	// RVA: 0x120E588
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x120E5F4
	void MoveNext() { }

	// RVA: 0x120F054
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x120F0D4
	void MoveNext() { }

	// RVA: 0x120FA10
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x120C084
	ServicePoint get_ServicePoint() { }

	// RVA: 0x120AA84
	void .ctor(ServicePoint sPoint) { }

	// RVA: 0x120C08C
	bool CanReuse() { }

	// RVA: 0x120C0BC
	bool CheckReusable() { }

	// RVA: 0x120C18C
	Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x120C2B4
	System.Threading.Tasks.Task<System.Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x120C414
	System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x120C56C
	WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x120C6E4
	bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x120A384
	bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x120C910
	bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x120CC78
	void Reset() { }

	// RVA: 0x120CD90
	void Close(bool reset) { }

	// RVA: 0x120CE68
	void CloseSocket() { }

	// RVA: 0x1209E04
	bool get_Closed() { }

	// RVA: 0x120D15C
	DateTime get_IdleSince() { }

	// RVA: 0x120A7D0
	bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1208F44
	bool Continue(WebOperation next) { }

	// RVA: 0x120D4B0
	void Dispose(bool disposing) { }

	// RVA: 0x1209DBC
	void Dispose() { }

	// RVA: 0x120CD5C
	void ResetNtlm() { }

	// RVA: 0x120D4F8
	bool get_NtlmAuthenticated() { }

	// RVA: 0x120D500
	void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x120D508
	NetworkCredential get_NtlmCredential() { }

	// RVA: 0x120D510
	void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x120D518
	bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x120D520
	void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

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

	// RVA: 0x120FA90
	void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x120FB8C
	HttpWebRequest get_Request() { }

	// RVA: 0x120FB94
	WebConnection get_Connection() { }

	// RVA: 0x120FB9C
	WebOperation get_Operation() { }

	// RVA: 0x120FBA4
	ServicePoint get_ServicePoint() { }

	// RVA: 0x120FBC4
	bool get_CanTimeout() { }

	// RVA: 0x120FBCC
	int get_ReadTimeout() { }

	// RVA: 0x120FBD4
	void set_ReadTimeout(int value) { }

	// RVA: 0x120FC40
	int get_WriteTimeout() { }

	// RVA: 0x120FC48
	void set_WriteTimeout(int value) { }

	// RVA: 0x120FCB4
	Exception GetException(Exception e) { }

	// RVA: -1
	bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x120FE80
	int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x121022C
	IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x121048C
	int EndRead(IAsyncResult r) { }

	// RVA: 0x12105E0
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x121081C
	void EndWrite(IAsyncResult r) { }

	// RVA: 0x121092C
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1210BB4
	void Flush() { }

	// RVA: 0x1210BB8
	Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1210D08
	void InternalClose() { }

	// RVA: 0x2FE4574
	void Close_internal(ref bool disposed) { }

	// RVA: 0x1210D14
	void Close() { }

	// RVA: 0x1210D28
	Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0x1210D7C
	bool get_CanSeek() { }

	// RVA: 0x1210D84
	Int64 get_Length() { }

	// RVA: 0x1210DD8
	Int64 get_Position() { }

	// RVA: 0x1210E2C
	void set_Position(Int64 value) { }

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

	// RVA: 0x1211114
	void MoveNext() { }

	// RVA: 0x1211EE4
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1211F50
	void MoveNext() { }

	// RVA: 0x1212A00
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1210E80
	HttpWebRequest get_Request() { }

	// RVA: 0x1210E88
	Uri get_ConnectUri() { }

	// RVA: 0x120EEDC
	void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x1210E90
	bool get_Success() { }

	// RVA: 0x1210E98
	void set_Success(bool value) { }

	// RVA: 0x1210EA0
	bool get_CloseConnection() { }

	// RVA: 0x1210EA8
	void set_CloseConnection(bool value) { }

	// RVA: 0x1210EB0
	int get_StatusCode() { }

	// RVA: 0x1210EB8
	void set_StatusCode(int value) { }

	// RVA: 0x1210EC0
	void set_StatusDescription(string value) { }

	// RVA: 0x1210EC8
	string[] get_Challenge() { }

	// RVA: 0x1210ED0
	void set_Challenge(string[] value) { }

	// RVA: 0x1210ED8
	WebHeaderCollection get_Headers() { }

	// RVA: 0x1210EE0
	void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1210EE8
	Version get_ProxyVersion() { }

	// RVA: 0x1210EF0
	void set_ProxyVersion(Version value) { }

	// RVA: 0x1210EF8
	Byte[] get_Data() { }

	// RVA: 0x1210F00
	void set_Data(Byte[] value) { }

	// RVA: 0x120EF2C
	Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1210F08
	System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1211064
	void FlushContents(Stream stream, int contentLength) { }

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

	// RVA: 0x1213968
	void MoveNext() { }

	// RVA: 0x1214370
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1212A80
	HttpWebRequest get_Request() { }

	// RVA: 0x1212A88
	WebConnection get_Connection() { }

	// RVA: 0x1212A90
	void set_Connection(WebConnection value) { }

	// RVA: 0x1212A98
	ServicePoint get_ServicePoint() { }

	// RVA: 0x1212AA0
	void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1212AA8
	BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x1212AB0
	bool get_IsNtlmChallenge() { }

	// RVA: 0x1212AB8
	void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1209E14
	bool get_Aborted() { }

	// RVA: 0x1212CA0
	bool get_Closed() { }

	// RVA: 0x1212D2C
	void Abort() { }

	// RVA: 0x1212F48
	void Close() { }

	// RVA: 0x1212E74
	void SetCanceled() { }

	// RVA: 0x12133AC
	void SetError(Exception error) { }

	// RVA: 0x1212D7C
	System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x121345C
	ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1213598
	void ThrowIfDisposed() { }

	// RVA: 0x120E490
	void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x12101C0
	void ThrowIfClosedOrDisposed() { }

	// RVA: 0x120F798
	void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1213534
	ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x120D164
	void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x1213604
	void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x1213798
	System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x12137EC
	WebRequestStream get_WriteStream() { }

	// RVA: 0x1213860
	System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }

	// RVA: 0x12138B4
	System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }

	// RVA: 0x120D3F8
	void Run() { }

	// RVA: 0x12138BC
	void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x12130F0
	void Finish(bool ok, Exception error) { }

	// RVA: 0x1213940
	void <RegisterRequest>b__48_0() { }

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

	// RVA: 0x1214F94
	void MoveNext() { }

	// RVA: 0x12155A8
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal abstract class WebReadStream 
{
	// Fields
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Methods

	// RVA: 0x121437C
	WebOperation get_Operation() { }

	// RVA: 0x1214384
	Stream get_InnerStream() { }

	// RVA: 0x1204A1C
	void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x121438C
	Int64 get_Length() { }

	// RVA: 0x12143CC
	Int64 get_Position() { }

	// RVA: 0x121440C
	void set_Position(Int64 value) { }

	// RVA: 0x121444C
	bool get_CanSeek() { }

	// RVA: 0x1214454
	bool get_CanRead() { }

	// RVA: 0x121445C
	bool get_CanWrite() { }

	// RVA: 0x1214464
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x12144A4
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x12144E4
	void Flush() { }

	// RVA: 0x1214524
	Exception GetException(Exception e) { }

	// RVA: 0x12146F0
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1214A14
	IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1214C74
	int EndRead(IAsyncResult r) { }

	// RVA: 0x1214DC8
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1
	System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1204D8C
	Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1214F2C
	void Dispose(bool disposing) { }

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

	// RVA: 0x121665C
	void MoveNext() { }

	// RVA: 0x1216A40
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1216AAC
	void MoveNext() { }

	// RVA: 0x1217080
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x12170EC
	void MoveNext() { }

	// RVA: 0x1217714
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1217780
	void MoveNext() { }

	// RVA: 0x1217B50
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1217BBC
	void MoveNext() { }

	// RVA: 0x121837C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x12183E8
	void MoveNext() { }

	// RVA: 0x12189D4
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1218A40
	void MoveNext() { }

	// RVA: 0x1218D14
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1218D80
	void MoveNext() { }

	// RVA: 0x1219730
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x120F874
	void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x1215628
	Stream get_InnerStream() { }

	// RVA: 0x1215630
	bool get_KeepAlive() { }

	// RVA: 0x1215638
	bool get_CanRead() { }

	// RVA: 0x1215640
	bool get_CanWrite() { }

	// RVA: 0x1215648
	bool get_HasWriteBuffer() { }

	// RVA: 0x1215684
	int get_WriteBufferLength() { }

	// RVA: 0x12156D4
	BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x12157D4
	Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x12158D8
	Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1215BB4
	Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x1215D04
	Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1215E3C
	void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0x12140CC
	Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x1215EE4
	Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x1215FF4
	Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x12160FC
	Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x1216200
	Task WriteChunkTrailer() { }

	// RVA: 0x1215ED8
	void KillBuffer() { }

	// RVA: 0x12162F0
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12163BC
	bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x12163FC
	void Close_internal(ref bool disposed) { }

	// RVA: 0x12165B8
	void .cctor() { }

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

	// RVA: 0x121B308
	void MoveNext() { }

	// RVA: 0x121BDDC
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1219C44
	void .ctor() { }

	// RVA: 0x121BE5C
	System.Threading.Tasks.Task<System.Int32> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x121BE9C
	void <ProcessRead>b__1() { }

	// RVA: 0x121BF0C
	bool <ProcessRead>b__2() { }

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

	// RVA: 0x121BF9C
	void MoveNext() { }

	// RVA: 0x121C5F0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x121C670
	void MoveNext() { }

	// RVA: 0x121D26C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x121D2D8
	void MoveNext() { }

	// RVA: 0x121DC40
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x121979C
	WebRequestStream get_RequestStream() { }

	// RVA: 0x12197A4
	WebHeaderCollection get_Headers() { }

	// RVA: 0x12197AC
	void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x12197B4
	HttpStatusCode get_StatusCode() { }

	// RVA: 0x12197BC
	void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x12197C4
	string get_StatusDescription() { }

	// RVA: 0x12197CC
	void set_StatusDescription(string value) { }

	// RVA: 0x12197D4
	Version get_Version() { }

	// RVA: 0x12197DC
	void set_Version(Version value) { }

	// RVA: 0x12197E4
	bool get_KeepAlive() { }

	// RVA: 0x12197EC
	void set_KeepAlive(bool value) { }

	// RVA: 0x12141D4
	void .ctor(WebRequestStream request) { }

	// RVA: 0x12197F4
	bool get_CanRead() { }

	// RVA: 0x12197FC
	bool get_CanWrite() { }

	// RVA: 0x1219804
	bool get_ChunkedRead() { }

	// RVA: 0x121980C
	void set_ChunkedRead(bool value) { }

	// RVA: 0x1219814
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1219980
	System.Threading.Tasks.Task<System.Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1219C4C
	bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x1219D1C
	bool get_ExpectContent() { }

	// RVA: 0x1219DB4
	void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x121A45C
	System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x121A59C
	Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x121A6B0
	Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x121A768
	void Close_internal(ref bool disposed) { }

	// RVA: 0x121A818
	WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x1214268
	Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x121AAC4
	bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties 
{
	// Methods

	// RVA: 0x121DCAC
	IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x121DD5C
	IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: 0x2FE360C
	string get_DomainName() { }

	// RVA: 0x121DDB4
	void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
public class NetworkInformationException 
{
	// Methods

	// RVA: 0x121DDBC
	void .ctor() { }

	// RVA: 0x121DE2C
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

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

	// RVA: 0x121DD04
	IPGlobalProperties Create() { }

}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties 
{
	// Methods

	// RVA: 0x121DE34
	int getdomainname(Byte[] name, int len) { }

	// RVA: 0x121DECC
	string get_DomainName() { }

	// RVA: 0x121E0D8
	void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties 
{
	// Methods

	// RVA: 0x121E0E0
	void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties 
{
	// Methods

	// RVA: 0x121E0E8
	string get_DomainName() { }

	// RVA: 0x121E134
	void .ctor() { }

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

	// RVA: 0x121E13C
	void .ctor(string procDir) { }

	// RVA: 0x121E2F4
	void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal 
{
	// Fields
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Methods

	// RVA: 0x121E398
	bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x121E3E4
	IPGlobalProperties Create() { }

}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal 
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Methods

	// RVA: 0x121E520
	IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x121E528
	IWebProxy GetSystemWebProxy() { }

	// RVA: 0x121E530
	object get_ClassSyncObject() { }

	// RVA: 0x121E5E8
	DefaultProxySectionInternal GetSection() { }

	// RVA: 0x121E7BC
	IWebProxy get_WebProxy() { }

	// RVA: 0x121E7B4
	void .ctor() { }

}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal 
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Methods

	// RVA: 0x121E7C4
	SettingsSectionInternal get_Section() { }

	// RVA: 0x121E840
	bool get_Ipv6Enabled() { }

	// RVA: 0x121E848
	void .ctor() { }

	// RVA: 0x121E860
	void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache 
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x121E8DC
	void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator 
{
	// Methods

	// RVA: 0x121E980
	object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding 
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Methods

	// RVA: 0x121E9C0
	RequestCache get_Cache() { }

	// RVA: 0x121E9C8
	RequestCacheValidator get_Validator() { }

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

	// RVA: 0x121E9D0
	void .ctor(RequestCacheLevel level) { }

	// RVA: 0x121EA4C
	RequestCacheLevel get_Level() { }

	// RVA: 0x121EA54
	string ToString() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol 
{
	// Methods

	// RVA: 0x121EAEC
	void .ctor(object arg1, object arg2) { }

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

	// RVA: 0x121EB34
	void .ctor(Socket socket) { }

	// RVA: 0x121ED24
	void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x121EB40
	void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x121ED30
	bool get_CanRead() { }

	// RVA: 0x121ED38
	bool get_CanSeek() { }

	// RVA: 0x121ED40
	bool get_CanWrite() { }

	// RVA: 0x121ED48
	bool get_CanTimeout() { }

	// RVA: 0x121ED50
	int get_ReadTimeout() { }

	// RVA: 0x121EFAC
	void set_ReadTimeout(int value) { }

	// RVA: 0x121F21C
	int get_WriteTimeout() { }

	// RVA: 0x121F2A8
	void set_WriteTimeout(int value) { }

	// RVA: 0x121F330
	Int64 get_Length() { }

	// RVA: 0x121F384
	Int64 get_Position() { }

	// RVA: 0x121F3D8
	void set_Position(Int64 value) { }

	// RVA: 0x121F42C
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x121F480
	int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x121F868
	int Read(System.Span<System.Byte> destination) { }

	// RVA: 0x121FBE8
	int ReadByte() { }

	// RVA: 0x121FD30
	void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1220118
	void Write(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1220460
	void WriteByte(Byte value) { }

	// RVA: 0x1220598
	void Close(int timeout) { }

	// RVA: 0x1220608
	void Dispose(bool disposing) { }

	// RVA: 0x122087C
	void Finalize() { }

	// RVA: 0x122091C
	IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1220D34
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x122101C
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1221434
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x122171C
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1221EC8
	System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1222124
	Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1222944
	ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1222B9C
	void Flush() { }

	// RVA: 0x1222BA0
	Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x121F034
	void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x1222DC0
	Socket get_InternalSocket() { }

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

	// RVA: 0x122D0C8
	void .ctor() { }

}

// Namespace: 
private class TaskSocketAsyncEventArgs<T0> 
{
	// Fields
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool) { }

}

// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs 
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0x99

	// Methods

	// RVA: 0x122D074
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<>c <>9; // 0x0
	public static ContextCallback <>9__14_0; // 0x8
	public static SendOrPostCallback <>9__20_0; // 0x10

	// Methods

	// RVA: 0x122E200
	void .cctor() { }

	// RVA: 0x122E26C
	void .ctor() { }

	// RVA: 0x122E274
	void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x122E3FC
	void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x122E534
	void <.cctor>b__27_0(object state) { }

	// RVA: 0x122E588
	void <.cctor>b__27_1(object state) { }

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

	// RVA: 0x122D0D0
	void .ctor() { }

	// RVA: 0x122D200
	bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x122D208
	void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x1222E64
	bool Reserve() { }

	// RVA: 0x122D210
	void Release() { }

	// RVA: 0x122D294
	void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x1222FF4
	System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(Socket socket) { }

	// RVA: 0x1223598
	ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x122D8F0
	ValueTaskSourceStatus GetStatus(Int16 token) { }

	// RVA: 0x122DA44
	void OnCompleted(System.Action<System.Object> continuation, object state, Int16 token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x122D4D4
	void InvokeContinuation(System.Action<System.Object> continuation, object state, bool forceAsync) { }

	// RVA: 0x122DDC0
	int GetResult(Int16 token) { }

	// RVA: 0x122DF08
	void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16 token) { }

	// RVA: 0x122D9F0
	void ThrowIncorrectTokenException() { }

	// RVA: 0x122DD6C
	void ThrowMultipleContinuationsException() { }

	// RVA: 0x122DEDC
	void ThrowException(SocketError error) { }

	// RVA: 0x122D808
	Exception CreateException(SocketError error) { }

	// RVA: 0x122E014
	void .cctor() { }

}

// Namespace: 
private struct WSABUF 
{
	// Fields
	public int len; // 0x10
	public IntPtr buf; // 0x18
}

// Namespace: 
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

	// RVA: 0x122E5DC
	void .cctor() { }

	// RVA: 0x122E648
	void .ctor() { }

	// RVA: 0x122E650
	CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x122E6A8
	AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x122E77C
	void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x122EA44
	void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x122F02C
	CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x122F084
	AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x122F158
	void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x122F420
	void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x122F85C
	void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x122F904
	void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x122F9AC
	void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x122FAB0
	void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x122FB9C
	void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x122FC88
	void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x122FF54
	void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x12300D8
	void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x12303A0
	void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x1230660
	void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x1230B50
	void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x1230E10
	void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x1230F34
	void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x1231250
	void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x1231520
	void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x12316B4
	void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x12319A4
	void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x1231B60
	void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x1231E7C
	void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x1232010
	void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass240_0 
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x1229468
	void .ctor() { }

	// RVA: 0x12322E0
	void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0 
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x122BC9C
	void .ctor() { }

	// RVA: 0x123244C
	void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass355_0 
{
	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x122C4C4
	void .ctor() { }

	// RVA: 0x1232500
	void <QueueIOSelectorJob>b__0(Task t) { }

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

	// RVA: 0x1221B00
	System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x12230AC
	System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1222524
	ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x1223620
	System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1223B5C
	void CompleteAccept(Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x1223EAC
	void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1223DC8
	Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x1224060
	void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1223D60
	void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x12240BC
	void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x122495C
	bool get_OSSupportsIPv4() { }

	// RVA: 0x12249C4
	bool get_OSSupportsIPv6() { }

	// RVA: 0x1224A2C
	IntPtr get_Handle() { }

	// RVA: 0x1224A4C
	AddressFamily get_AddressFamily() { }

	// RVA: 0x1224A54
	SocketType get_SocketType() { }

	// RVA: 0x1224A5C
	ProtocolType get_ProtocolType() { }

	// RVA: 0x1224A64
	void set_DontFragment(bool value) { }

	// RVA: 0x1224C08
	bool get_DualMode() { }

	// RVA: 0x1224CEC
	void set_DualMode(bool value) { }

	// RVA: 0x1224D6C
	bool get_IsDualMode() { }

	// RVA: 0x1224D84
	bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x1224DBC
	int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x12200B0
	int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x12255A0
	int SendTo(Byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x121F800
	int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1225934
	int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1225F28
	int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x122476C
	void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x12213BC
	IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x12216B4
	int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1220CBC
	IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1220FB4
	int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x122686C
	object get_InternalSyncObject() { }

	// RVA: 0x1226970
	bool get_CleanedUp() { }

	// RVA: 0x1224350
	void InitializeSockets() { }

	// RVA: 0x1226A00
	void Dispose() { }

	// RVA: 0x1226A90
	void Finalize() { }

	// RVA: 0x1220754
	void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1222C64
	void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x1226DEC
	void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1224874
	void SocketDefaults() { }

	// RVA: 0x1224644
	IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x1226F80
	EndPoint get_LocalEndPoint() { }

	// RVA: 0x1227108
	SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1227260
	SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x1227264
	bool get_Blocking() { }

	// RVA: 0x122726C
	void set_Blocking(bool value) { }

	// RVA: 0x1227338
	void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1227480
	void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x1227484
	bool get_Connected() { }

	// RVA: 0x1226F0C
	void set_NoDelay(bool value) { }

	// RVA: 0x12274E4
	EndPoint get_RemoteEndPoint() { }

	// RVA: 0x12275EC
	SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1227744
	SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x1227748
	bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x12278F8
	bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1227A60
	bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1227A64
	Socket Accept() { }

	// RVA: 0x1227D04
	void Accept(Socket acceptSocket) { }

	// RVA: 0x1227E3C
	IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x122819C
	Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x12281C8
	Socket EndAccept(out Byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1227BA4
	SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x122861C
	IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x1228620
	void Bind(EndPoint localEP) { }

	// RVA: 0x122887C
	void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x12289C4
	void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x12289C8
	void Listen(int backlog) { }

	// RVA: 0x1228AB8
	void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1228C00
	void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x1228C04
	void Connect(IPAddress address, int port) { }

	// RVA: 0x1228C84
	void Connect(EndPoint remoteEP) { }

	// RVA: 0x122912C
	IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x1229470
	IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1229AC4
	bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x12295D4
	bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1229D30
	void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1228FFC
	void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1229DFC
	void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1229E00
	void Disconnect(bool reuseSocket) { }

	// RVA: 0x122A04C
	void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1229F04
	void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x122A118
	void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x12257D8
	int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x122A3F8
	int Receive(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x122599C
	int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x121FAD4
	int Receive(System.Span<System.Byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x12203C8
	int Send(System.ReadOnlySpan<System.Byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x122A760
	bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x12264E4
	IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x12266E4
	int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x122A608
	int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122AABC
	int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122A2A0
	int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122AAC0
	int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122AAC4
	int ReceiveFrom(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x122AED0
	IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x122B12C
	int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x122B244
	int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x122AD70
	int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x122B318
	int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1225418
	int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1224E24
	int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x122B5CC
	bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x12260BC
	IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x122B8F0
	void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x122635C
	int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x122B474
	int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122BCD4
	int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122B31C
	int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x122BCD8
	int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x12255D4
	int SendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x122BE3C
	int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x122BCDC
	int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x122BEF8
	int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x121EDDC
	object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x122BEFC
	void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x122C05C
	void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1224AE4
	void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1226C74
	void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x122C060
	void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1225F2C
	int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x122C064
	int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	// RVA: 0x122C1D4
	int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	// RVA: 0x122C1D8
	void Close() { }

	// RVA: 0x12207E8
	void Close(int timeout) { }

	// RVA: 0x122C26C
	void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x1226B2C
	void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x122C270
	void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x122C274
	void Dispose(bool disposing) { }

	// RVA: 0x122C2E4
	void Linger(IntPtr handle) { }

	// RVA: 0x1227080
	void ThrowIfDisposedAndClosed() { }

	// RVA: 0x122A11C
	void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x122A178
	void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x122748C
	void ThrowIfUdp() { }

	// RVA: 0x12282CC
	SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x122803C
	void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x122A9A4
	void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x122C608
	SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x12287BC
	IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x122C7A0
	void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x122C7A4
	int get_FamilyHint() { }

	// RVA: 0x122C8EC
	bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1226980
	bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x122C8F0
	void .cctor() { }

}

// Namespace: System.Net.Sockets
public class SocketException 
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Methods

	// RVA: 0x1232548
	int WSAGetLastError_icall() { }

	// RVA: 0x1224740
	void .ctor() { }

	// RVA: 0x123254C
	void .ctor(int error, string message) { }

	// RVA: 0x121FBE0
	void .ctor(int errorCode) { }

	// RVA: 0x1225410
	void .ctor(SocketError socketError) { }

	// RVA: 0x1232554
	void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x123255C
	string get_Message() { }

	// RVA: 0x122FF4C
	SocketError get_SocketErrorCode() { }

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

	// RVA: 0x122C488
	void .ctor(bool enable, int seconds) { }

	// RVA: 0x12325FC
	void set_Enabled(bool value) { }

	// RVA: 0x1232604
	void set_LingerTime(int value) { }

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

	// RVA: 0x123260C
	void .ctor() { }

	// RVA: 0x1232630
	void .ctor(AddressFamily family) { }

	// RVA: 0x123281C
	Socket get_Client() { }

	// RVA: 0x1232824
	void set_Client(Socket value) { }

	// RVA: 0x123282C
	void Connect(string hostname, int port) { }

	// RVA: 0x12330AC
	void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x12331AC
	IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1233220
	void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1233268
	Task ConnectAsync(string host, int port) { }

	// RVA: 0x1233404
	NetworkStream GetStream() { }

	// RVA: 0x1233568
	void Dispose(bool disposing) { }

	// RVA: 0x1233804
	void Dispose() { }

	// RVA: 0x1233814
	void Finalize() { }

	// RVA: 0x123279C
	void initialize() { }

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

	// RVA: 0x1224648
	void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x12338B0
	bool ReleaseHandle() { }

	// RVA: 0x12284D4
	void RegisterForBlockingSyscall() { }

	// RVA: 0x1233FC0
	void UnRegisterForBlockingSyscall() { }

	// RVA: 0x12341DC
	void .cctor() { }

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

	// RVA: 0x1234270
	Socket get_AcceptSocket() { }

	// RVA: 0x1234278
	void set_AcceptSocket(Socket value) { }

	// RVA: 0x1234280
	int get_BytesTransferred() { }

	// RVA: 0x1234288
	void set_BytesTransferred(int value) { }

	// RVA: 0x1234290
	void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x1234298
	void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x12342A0
	SocketError get_SocketError() { }

	// RVA: 0x12342A8
	void set_SocketError(SocketError value) { }

	// RVA: 0x12342B0
	void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x12342B8
	object get_UserToken() { }

	// RVA: 0x12342C0
	void set_UserToken(object value) { }

	// RVA: 0x122D14C
	void .ctor(bool flowExecutionContext) { }

	// RVA: 0x12342D0
	void Finalize() { }

	// RVA: 0x12342E0
	void Dispose(bool disposing) { }

	// RVA: 0x12342F4
	void Dispose() { }

	// RVA: 0x122C798
	void SetBytesTransferred(int value) { }

	// RVA: 0x1234394
	Socket get_CurrentSocket() { }

	// RVA: 0x123439C
	void SetCurrentSocket(Socket socket) { }

	// RVA: 0x122C6B8
	void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x12343A4
	void Complete_internal() { }

	// RVA: 0x12343D8
	void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x1234400
	System.Memory<System.Byte> get_MemoryBuffer() { }

	// RVA: 0x123440C
	int get_Offset() { }

	// RVA: 0x1234414
	int get_Count() { }

	// RVA: 0x123441C
	System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }

	// RVA: 0x1222EF0
	void SetBuffer(System.Memory<System.Byte> buffer) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Net.Sockets.SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x1234428
	void .cctor() { }

	// RVA: 0x1234494
	void .ctor() { }

	// RVA: 0x123449C
	void <Complete>b__27_0(object state) { }

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

	// RVA: 0x1228008
	IntPtr get_Handle() { }

	// RVA: 0x12342C8
	void .ctor() { }

	// RVA: 0x122C4CC
	void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1227FB8
	void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x122AA2C
	SocketError get_ErrorCode() { }

	// RVA: 0x1228430
	void CheckIfThrowDelayedException() { }

	// RVA: 0x1234424
	void CompleteDisposed() { }

	// RVA: 0x123094C
	void Complete() { }

	// RVA: 0x1229D28
	void Complete(bool synch) { }

	// RVA: 0x122BCCC
	void Complete(int total) { }

	// RVA: 0x1229CF8
	void Complete(Exception e, bool synch) { }

	// RVA: 0x122BCA4
	void Complete(Exception e) { }

	// RVA: 0x12300B0
	void Complete(Socket s) { }

	// RVA: 0x1230370
	void Complete(Socket s, int total) { }

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

	// RVA: 0x1234518
	bool get_AllowRenegotiation() { }

	// RVA: 0x1234520
	string get_TargetHost() { }

	// RVA: 0x1234528
	void set_TargetHost(string value) { }

	// RVA: 0x1234530
	X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1234538
	void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x1234540
	void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x12345E0
	void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x1234680
	SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x1234688
	void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1234690
	void .ctor() { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream 
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Methods

	// RVA: 0x12346A0
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1234864
	Stream get_InnerStream() { }

	// RVA: 0x123486C
	void Dispose(bool disposing) { }

	// RVA: 0x2FE3054
	bool get_IsAuthenticated() { }

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

	// RVA: 0x1234988
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1234AAC
	internal X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback 
{
	// Methods

	// RVA: 0x1234AC0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1234BE4
	internal bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

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

	// RVA: 0x1234BF8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1234CB4
	internal X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback 
{
	// Methods

	// RVA: 0x1234CC8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1234D7C
	internal X509Certificate Invoke(string hostName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0 
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x1235494
	void .ctor() { }

	// RVA: 0x1235F2C
	X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

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

	// RVA: 0x1234D90
	MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x1234E60
	string get_InternalTargetHost() { }

	// RVA: 0x1234ECC
	MobileTlsProvider GetProvider() { }

	// RVA: 0x1234F48
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x1234F50
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x1235340
	void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1235074
	void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x1235174
	void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x123549C
	void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1235508
	IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x123558C
	void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1235598
	Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1235604
	bool get_IsAuthenticated() { }

	// RVA: 0x1235678
	X509Certificate get_LocalCertificate() { }

	// RVA: 0x12356E4
	bool get_CanSeek() { }

	// RVA: 0x12356EC
	bool get_CanRead() { }

	// RVA: 0x1235704
	bool get_CanTimeout() { }

	// RVA: 0x1235728
	bool get_CanWrite() { }

	// RVA: 0x1235740
	int get_ReadTimeout() { }

	// RVA: 0x12357B4
	void set_ReadTimeout(int value) { }

	// RVA: 0x1235828
	int get_WriteTimeout() { }

	// RVA: 0x123589C
	void set_WriteTimeout(int value) { }

	// RVA: 0x1235910
	Int64 get_Length() { }

	// RVA: 0x1235980
	Int64 get_Position() { }

	// RVA: 0x12359F0
	void set_Position(Int64 value) { }

	// RVA: 0x1235A4C
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1235AA8
	Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1235AD0
	void Flush() { }

	// RVA: 0x1234DF8
	void CheckDisposed() { }

	// RVA: 0x1235AF8
	void Dispose(bool disposing) { }

	// RVA: 0x1235BE0
	int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1235C54
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1235CC8
	System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1235D3C
	Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1235DB0
	IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1235E34
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1235E9C
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1235F20
	void EndWrite(IAsyncResult asyncResult) { }

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

	// RVA: 0x1235F68
	UInt32 ComputeStringHash(string s) { }

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

	// RVA: 0x1235FF4
	void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement 
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection 
{
	// Methods

	// RVA: 0x1236030
	void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection 
{
	// Methods

	// RVA: 0x123606C
	void .ctor() { }

	// RVA: 0x12360A8
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection 
{
	// Methods

	// RVA: 0x12360E4
	void .ctor() { }

	// RVA: 0x1236120
	ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x123615C
	void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement 
{
	// Methods

	// RVA: 0x1236198
	void .ctor() { }

	// RVA: 0x12361D4
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement 
{
	// Methods

	// RVA: 0x1236210
	void .ctor() { }

	// RVA: 0x123624C
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element 
{
	// Methods

	// RVA: 0x1236288
	void .ctor() { }

	// RVA: 0x12362C4
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup 
{
	// Methods

	// RVA: 0x1236300
	void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection 
{
	// Methods

	// RVA: 0x123633C
	void .ctor() { }

	// RVA: 0x1236378
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement 
{
	// Methods

	// RVA: 0x12363B4
	void .ctor() { }

	// RVA: 0x12363F0
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement 
{
	// Methods

	// RVA: 0x123642C
	void .ctor() { }

	// RVA: 0x1236468
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement 
{
	// Methods

	// RVA: 0x12364A4
	void .ctor() { }

	// RVA: 0x12364E0
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement 
{
	// Methods

	// RVA: 0x123651C
	void .ctor() { }

	// RVA: 0x1236558
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection 
{
	// Methods

	// RVA: 0x1236594
	void .ctor() { }

	// RVA: 0x12365D0
	ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection 
{
	// Methods

	// RVA: 0x123660C
	void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement 
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler 
{
	// Methods

	// RVA: 0x1236648
	void .ctor() { }

	// RVA: 0x1236684
	object Create(object parent, object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub 
{
	// Methods

	// RVA: 0x12366C0
	void ThrowNotSupportedException() { }

}


