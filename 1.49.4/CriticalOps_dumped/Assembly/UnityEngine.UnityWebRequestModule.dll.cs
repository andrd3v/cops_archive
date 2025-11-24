// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0x18C6F64
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x18C7054
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x18C743C
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x18C7824
	private static string URLDecode(string encoded) { }

	// RVA: 0x18C799C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class WWWForm
{
	// Fields
	private System.Collections.Generic.List<System.Byte[]> formData; // 0x10
	private System.Collections.Generic.List<System.String> fieldNames; // 0x18
	private System.Collections.Generic.List<System.String> fileNames; // 0x20
	private System.Collections.Generic.List<System.String> types; // 0x28
	private Byte[] boundary; // 0x30
	private bool containsFiles; // 0x38
	private static Byte[] dDash; // 0x0
	private static Byte[] crlf; // 0x8
	private static Byte[] contentTypeHeader; // 0x10
	private static Byte[] dispositionHeader; // 0x18
	private static Byte[] endQuote; // 0x20
	private static Byte[] fileNameField; // 0x28
	private static Byte[] ampersand; // 0x30
	private static Byte[] equal; // 0x38

	// Methods

	// RVA: 0x18C7A3C
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x18C7A44
	public void .ctor() { }

	// RVA: 0x18C7C08
	public void AddField(string fieldName, string value) { }

	// RVA: 0x18C7C4C
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x18C7D80
	public System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }

	// RVA: 0x18C7ECC
	public Byte[] get_data() { }

	// RVA: 0x18C9160
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal class WWWTranscoder
{
	// Fields
	private static Byte[] ucHexChars; // 0x0
	private static Byte[] lcHexChars; // 0x8
	private static Byte urlEscapeChar; // 0x10
	private static Byte[] urlSpace; // 0x18
	private static Byte[] dataSpace; // 0x20
	private static Byte[] urlForbidden; // 0x28
	private static Byte qpEscapeChar; // 0x30
	private static Byte[] qpSpace; // 0x38
	private static Byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x18C93E8
	private static Byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x18C94A8
	private static void Byte2Hex(Byte b, Byte[] hexChars, Byte byte0, Byte byte1) { }

	// RVA: 0x18C90EC
	public static Byte[] DataEncode(Byte[] toEncode) { }

	// RVA: 0x18C8FFC
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x18C94FC
	public static Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	// RVA: 0x18C993C
	private static bool ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0x18C792C
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x18C9DC4
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x18C99B4
	public static Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0x18C8E44
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x18C9E58
	public static bool SevenBitClean(Byte* input, int inputLength) { }

	// RVA: 0x18C9EB4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Networking
public class CertificateHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18CA144
	private void Release() { }

	// RVA: 0x18CA194
	protected virtual bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x18CA19C
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x18CA1A8
	public void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18CA204
	private void Release() { }

	// RVA: 0x18CA254
	internal void .ctor() { }

	// RVA: 0x18CA25C
	protected override void Finalize() { }

	// RVA: 0x18CA2F4
	public virtual void Dispose() { }

	// RVA: 0x18CA350
	public bool get_isDone() { }

	// RVA: 0x18CA3A0
	private bool IsDone() { }

	// RVA: 0x18CA3F0
	public ReadOnly get_nativeData() { }

	// RVA: 0x18CA464
	public Byte[] get_data() { }

	// RVA: 0x18CA470
	public string get_text() { }

	// RVA: 0x18CA47C
	protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18CA488
	protected virtual Byte[] GetData() { }

	// RVA: 0x18CA590
	protected virtual string GetText() { }

	// RVA: 0x18CA660
	private Encoding GetTextEncoder() { }

	// RVA: 0x18CA908
	private string GetContentType() { }

	// RVA: 0x18CA958
	protected virtual bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x18CA960
	protected virtual void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0x18CA96C
	protected virtual void ReceiveContentLength(int contentLength) { }

	// RVA: 0x18CA970
	protected virtual void CompleteContent() { }

	// RVA: 0x18CA974
	protected virtual float GetProgress() { }

	// RVA: 0x18CA97C
	internal static Byte* InternalGetByteArray(DownloadHandler dh, int length) { }

	// RVA: 0x18CA50C
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x18CA9E4
	internal static Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }

	// RVA: 0x18CAB40
	internal static void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }

	// RVA: 0x18CAB88
	internal static void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, Byte* bytes, int length) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x18CABFC
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x18CAC4C
	private void InternalCreateBuffer() { }

	// RVA: 0x18CACAC
	public void .ctor() { }

	// RVA: 0x18CAD14
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18CAD1C
	public override void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x18CADB0
	public UnityWebRequest get_webRequest() { }

	// RVA: 0x18CADB8
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x18CADC0
	public void .ctor() { }

}

// Namespace: 
internal enum UnityWebRequestMethod
{
	// Fields
	public int value__; // 0x10
	public const UnityWebRequestMethod Get = 0;
	public const UnityWebRequestMethod Post = 1;
	public const UnityWebRequestMethod Put = 2;
	public const UnityWebRequestMethod Head = 3;
	public const UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequestError
{
	// Fields
	public int value__; // 0x10
	public const UnityWebRequestError OK = 0;
	public const UnityWebRequestError OKCached = 1;
	public const UnityWebRequestError Unknown = 2;
	public const UnityWebRequestError SDKError = 3;
	public const UnityWebRequestError UnsupportedProtocol = 4;
	public const UnityWebRequestError MalformattedUrl = 5;
	public const UnityWebRequestError CannotResolveProxy = 6;
	public const UnityWebRequestError CannotResolveHost = 7;
	public const UnityWebRequestError CannotConnectToHost = 8;
	public const UnityWebRequestError AccessDenied = 9;
	public const UnityWebRequestError GenericHttpError = 10;
	public const UnityWebRequestError WriteError = 11;
	public const UnityWebRequestError ReadError = 12;
	public const UnityWebRequestError OutOfMemory = 13;
	public const UnityWebRequestError Timeout = 14;
	public const UnityWebRequestError HTTPPostError = 15;
	public const UnityWebRequestError SSLCannotConnect = 16;
	public const UnityWebRequestError Aborted = 17;
	public const UnityWebRequestError TooManyRedirects = 18;
	public const UnityWebRequestError ReceivedNoData = 19;
	public const UnityWebRequestError SSLNotSupported = 20;
	public const UnityWebRequestError FailedToSendData = 21;
	public const UnityWebRequestError FailedToReceiveData = 22;
	public const UnityWebRequestError SSLCertificateError = 23;
	public const UnityWebRequestError SSLCipherNotAvailable = 24;
	public const UnityWebRequestError SSLCACertError = 25;
	public const UnityWebRequestError UnrecognizedContentEncoding = 26;
	public const UnityWebRequestError LoginFailed = 27;
	public const UnityWebRequestError SSLShutdownFailed = 28;
	public const UnityWebRequestError RedirectLimitInvalid = 29;
	public const UnityWebRequestError InvalidRedirect = 30;
	public const UnityWebRequestError CannotModifyRequest = 31;
	public const UnityWebRequestError HeaderNameContainsInvalidCharacters = 32;
	public const UnityWebRequestError HeaderValueContainsInvalidCharacters = 33;
	public const UnityWebRequestError CannotOverrideSystemHeaders = 34;
	public const UnityWebRequestError AlreadySent = 35;
	public const UnityWebRequestError InvalidMethod = 36;
	public const UnityWebRequestError NotImplemented = 37;
	public const UnityWebRequestError NoInternetConnection = 38;
	public const UnityWebRequestError DataProcessingError = 39;
	public const UnityWebRequestError InsecureConnectionNotAllowed = 40;
}

// Namespace: 
public enum Result
{
	// Fields
	public int value__; // 0x10
	public const Result InProgress = 0;
	public const Result Success = 1;
	public const Result ConnectionError = 2;
	public const Result ProtocolError = 3;
	public const Result DataProcessingError = 4;
}

// Namespace: UnityEngine.Networking
public class UnityWebRequest
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Methods

	// RVA: 0x18CADC8
	private static string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x18CAE18
	internal static string GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0x18CAE68
	public bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x18CAE70
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x18CAE78
	public bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x18CAE80
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x18CAE88
	public bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x18CAE90
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x18CAE98
	internal static IntPtr Create() { }

	// RVA: 0x18CAED8
	private void Release() { }

	// RVA: 0x18CAF28
	internal void InternalDestroy() { }

	// RVA: 0x18CB014
	private void InternalSetDefaults() { }

	// RVA: 0x18CB028
	public void .ctor(string url) { }

	// RVA: 0x18CB188
	public void .ctor(string url, string method) { }

	// RVA: 0x18CB428
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x18CB764
	protected override void Finalize() { }

	// RVA: 0x18CB98C
	public void Dispose() { }

	// RVA: 0x18CB8E8
	private void DisposeHandlers() { }

	// RVA: 0x18CBB34
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x18CBB84
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x18CAFC4
	public void Abort() { }

	// RVA: 0x18CBBF8
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18CBC60
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18CBDBC
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x18CBE24
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x18CB26C
	public void set_method(string value) { }

	// RVA: 0x18CBF30
	private UnityWebRequestError GetError() { }

	// RVA: 0x18CBF80
	public string get_error() { }

	// RVA: 0x18CB0F4
	public void set_url(string value) { }

	// RVA: 0x18CC350
	private UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x18CC244
	private void InternalSetUrl(string url) { }

	// RVA: 0x18CC1F4
	public Int64 get_responseCode() { }

	// RVA: 0x18CBD6C
	public bool get_isModifiable() { }

	// RVA: 0x18CC3B8
	public bool get_isDone() { }

	// RVA: 0x18CC1A4
	public Result get_result() { }

	// RVA: 0x18CC404
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x18CC45C
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x18CC5EC
	public string GetResponseHeader(string name) { }

	// RVA: 0x18CC654
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x18CBB24
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x18CB64C
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x18CC6BC
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x18CBB1C
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x18CB534
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x18CBB2C
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x18CC724
	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x18CC78C
	public void set_timeout(int value) { }

	// RVA: 0x18CC900
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x18CC9E0
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x18CCA74
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18CCF28
	private void Release() { }

	// RVA: 0x18CCF78
	internal void .ctor() { }

	// RVA: 0x18CCF80
	protected override void Finalize() { }

	// RVA: 0x18CD018
	public virtual void Dispose() { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x18CD074
	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	// RVA: 0x18CCE90
	public void .ctor(Byte[] data) { }

	// RVA: 0x18CD0CC
	public void .ctor(Unity.Collections.NativeArray<System.Byte> data, bool transferOwnership) { }

	// RVA: 0x18CD1CC
	public override void Dispose() { }

}


