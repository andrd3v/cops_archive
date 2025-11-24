// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils 
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0x17E1F80
	string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x17E2070
	string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x17E2458
	string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x17E2840
	string URLDecode(string encoded) { }

	// RVA: 0x17E29B8
	void .cctor() { }

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

	// RVA: 0x17E2A58
	Encoding get_DefaultEncoding() { }

	// RVA: 0x17E2A60
	void .ctor() { }

	// RVA: 0x17E2C24
	void AddField(string fieldName, string value) { }

	// RVA: 0x17E2C68
	void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x17E2D9C
	System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }

	// RVA: 0x17E2EE8
	Byte[] get_data() { }

	// RVA: 0x17E417C
	void .cctor() { }

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

	// RVA: 0x17E4404
	Byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x17E44C4
	void Byte2Hex(Byte b, Byte[] hexChars, out Byte byte0, out Byte byte1) { }

	// RVA: 0x17E4108
	Byte[] DataEncode(Byte[] toEncode) { }

	// RVA: 0x17E4018
	string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x17E4518
	Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	// RVA: 0x17E4958
	bool ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0x17E2948
	Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x17E4DE0
	bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x17E49D0
	Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0x17E3E60
	bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x17E4E74
	bool SevenBitClean(Byte* input, int inputLength) { }

	// RVA: 0x17E4ED0
	void .cctor() { }

}

// Namespace: UnityEngine.Networking
public class CertificateHandler 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x17E5160
	void Release() { }

	// RVA: 0x17E51B0
	bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x17E51B8
	bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x17E51C4
	void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x17E5220
	void Release() { }

	// RVA: 0x17E5270
	void .ctor() { }

	// RVA: 0x17E5278
	void Finalize() { }

	// RVA: 0x17E5310
	void Dispose() { }

	// RVA: 0x17E536C
	bool get_isDone() { }

	// RVA: 0x17E53BC
	bool IsDone() { }

	// RVA: 0x17E540C
	Byte[] get_data() { }

	// RVA: 0x17E5418
	string get_text() { }

	// RVA: 0x17E5424
	Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x17E5430
	Byte[] GetData() { }

	// RVA: 0x17E5538
	string GetText() { }

	// RVA: 0x17E5608
	Encoding GetTextEncoder() { }

	// RVA: 0x17E58B0
	string GetContentType() { }

	// RVA: 0x17E5900
	bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x17E5908
	void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0x17E5914
	void ReceiveContentLength(int contentLength) { }

	// RVA: 0x17E5918
	void CompleteContent() { }

	// RVA: 0x17E591C
	float GetProgress() { }

	// RVA: 0x17E5924
	Byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	// RVA: 0x17E54B4
	Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x17E598C
	Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(DownloadHandler dh, ref Unity.Collections.NativeArray<System.Byte>& nativeArray) { }

	// RVA: 0x17E5AE8
	void DisposeNativeArray(ref Unity.Collections.NativeArray<System.Byte>& data) { }

	// RVA: 0x17E5B30
	void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<System.Byte>& data, Byte* bytes, int length) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer 
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x17E5BA4
	IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x17E5BF4
	void InternalCreateBuffer() { }

	// RVA: 0x17E5C54
	void .ctor() { }

	// RVA: 0x17E5CBC
	Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x17E5CC4
	void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation 
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x17E5D58
	UnityWebRequest get_webRequest() { }

	// RVA: 0x17E5D60
	void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x17E5D68
	void .ctor() { }

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

	// RVA: 0x17E5D70
	string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x17E5DC0
	string GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0x17E5E10
	bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x17E5E18
	void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x17E5E20
	bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x17E5E28
	void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x17E5E30
	bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x17E5E38
	void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x17E5E40
	IntPtr Create() { }

	// RVA: 0x17E5E80
	void Release() { }

	// RVA: 0x17E5ED0
	void InternalDestroy() { }

	// RVA: 0x17E5FBC
	void InternalSetDefaults() { }

	// RVA: 0x17E5FD0
	void .ctor(string url) { }

	// RVA: 0x17E6130
	void .ctor(string url, string method) { }

	// RVA: 0x17E63D0
	void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x17E670C
	void Finalize() { }

	// RVA: 0x17E6934
	void Dispose() { }

	// RVA: 0x17E6890
	void DisposeHandlers() { }

	// RVA: 0x17E6ADC
	UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x17E6B2C
	UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x17E5F6C
	void Abort() { }

	// RVA: 0x17E6BA0
	UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x17E6C08
	void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x17E6D64
	UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x17E6DCC
	void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x17E6214
	void set_method(string value) { }

	// RVA: 0x17E6ED8
	UnityWebRequestError GetError() { }

	// RVA: 0x17E6F28
	string get_error() { }

	// RVA: 0x17E609C
	void set_url(string value) { }

	// RVA: 0x17E72F8
	UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x17E71EC
	void InternalSetUrl(string url) { }

	// RVA: 0x17E719C
	Int64 get_responseCode() { }

	// RVA: 0x17E6D14
	bool get_isModifiable() { }

	// RVA: 0x17E7360
	bool get_isDone() { }

	// RVA: 0x17E714C
	Result get_result() { }

	// RVA: 0x17E73AC
	UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x17E7404
	void SetRequestHeader(string name, string value) { }

	// RVA: 0x17E7594
	UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x17E6ACC
	UploadHandler get_uploadHandler() { }

	// RVA: 0x17E65F4
	void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x17E75FC
	UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x17E6AC4
	DownloadHandler get_downloadHandler() { }

	// RVA: 0x17E64DC
	void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x17E6AD4
	CertificateHandler get_certificateHandler() { }

	// RVA: 0x17E7664
	UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x17E76CC
	void set_timeout(int value) { }

	// RVA: 0x17E7840
	UnityWebRequest Get(string uri) { }

	// RVA: 0x17E7920
	UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x17E79B4
	void SetupPost(UnityWebRequest request, WWWForm formData) { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x17E7E68
	void Release() { }

	// RVA: 0x17E7EB8
	void .ctor() { }

	// RVA: 0x17E7EC0
	void Finalize() { }

	// RVA: 0x17E7F58
	void Dispose() { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw 
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x17E7FB4
	IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	// RVA: 0x17E7DD0
	void .ctor(Byte[] data) { }

	// RVA: 0x17E800C
	void .ctor(Unity.Collections.NativeArray<System.Byte> data, bool transferOwnership) { }

	// RVA: 0x17E810C
	void Dispose() { }

}


