// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0x18F93A8
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x18F9498
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x18F9880
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x18F9C68
	private static string URLDecode(string encoded) { }

	// RVA: 0x18F9DE0
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

	// RVA: 0x18F9E80
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x18F9E88
	public void .ctor() { }

	// RVA: 0x18FA04C
	public void AddField(string fieldName, string value) { }

	// RVA: 0x18FA090
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x18FA1C4
	public System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }

	// RVA: 0x18FA310
	public Byte[] get_data() { }

	// RVA: 0x18FB5A4
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

	// RVA: 0x18FB82C
	private static Byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x18FB8EC
	private static void Byte2Hex(Byte b, Byte[] hexChars, Byte byte0, Byte byte1) { }

	// RVA: 0x18FB530
	public static Byte[] DataEncode(Byte[] toEncode) { }

	// RVA: 0x18FB440
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x18FB940
	public static Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	// RVA: 0x18FBD80
	private static bool ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0x18F9D70
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x18FC208
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x18FBDF8
	public static Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0x18FB288
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x18FC29C
	public static bool SevenBitClean(Byte* input, int inputLength) { }

	// RVA: 0x18FC2F8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Networking
public class CertificateHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18FC588
	private void Release() { }

	// RVA: 0x18FC5D8
	protected virtual bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x18FC5E0
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x18FC5EC
	public void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18FC648
	private void Release() { }

	// RVA: 0x18FC698
	internal void .ctor() { }

	// RVA: 0x18FC6A0
	protected override void Finalize() { }

	// RVA: 0x18FC738
	public virtual void Dispose() { }

	// RVA: 0x18FC794
	public bool get_isDone() { }

	// RVA: 0x18FC7E4
	private bool IsDone() { }

	// RVA: 0x18FC834
	public ReadOnly get_nativeData() { }

	// RVA: 0x18FC8A8
	public Byte[] get_data() { }

	// RVA: 0x18FC8B4
	public string get_text() { }

	// RVA: 0x18FC8C0
	protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18FC8CC
	protected virtual Byte[] GetData() { }

	// RVA: 0x18FC9D4
	protected virtual string GetText() { }

	// RVA: 0x18FCAA4
	private Encoding GetTextEncoder() { }

	// RVA: 0x18FCD4C
	private string GetContentType() { }

	// RVA: 0x18FCD9C
	protected virtual bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x18FCDA4
	protected virtual void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0x18FCDB0
	protected virtual void ReceiveContentLength(int contentLength) { }

	// RVA: 0x18FCDB4
	protected virtual void CompleteContent() { }

	// RVA: 0x18FCDB8
	protected virtual float GetProgress() { }

	// RVA: 0x18FCDC0
	internal static Byte* InternalGetByteArray(DownloadHandler dh, int length) { }

	// RVA: 0x18FC950
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x18FCE28
	internal static Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }

	// RVA: 0x18FCF84
	internal static void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }

	// RVA: 0x18FCFCC
	internal static void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, Byte* bytes, int length) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x18FD040
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x18FD090
	private void InternalCreateBuffer() { }

	// RVA: 0x18FD0F0
	public void .ctor() { }

	// RVA: 0x18FD158
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18FD160
	public override void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x18FD1F4
	public UnityWebRequest get_webRequest() { }

	// RVA: 0x18FD1FC
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x18FD204
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

	// RVA: 0x18FD20C
	private static string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x18FD25C
	internal static string GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0x18FD2AC
	public bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x18FD2B4
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x18FD2BC
	public bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x18FD2C4
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x18FD2CC
	public bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x18FD2D4
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x18FD2DC
	internal static IntPtr Create() { }

	// RVA: 0x18FD31C
	private void Release() { }

	// RVA: 0x18FD36C
	internal void InternalDestroy() { }

	// RVA: 0x18FD458
	private void InternalSetDefaults() { }

	// RVA: 0x18FD46C
	public void .ctor(string url) { }

	// RVA: 0x18FD5CC
	public void .ctor(string url, string method) { }

	// RVA: 0x18FD86C
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x18FDBA8
	protected override void Finalize() { }

	// RVA: 0x18FDDD0
	public void Dispose() { }

	// RVA: 0x18FDD2C
	private void DisposeHandlers() { }

	// RVA: 0x18FDF78
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x18FDFC8
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x18FD408
	public void Abort() { }

	// RVA: 0x18FE03C
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18FE0A4
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18FE200
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x18FE268
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x18FD6B0
	public void set_method(string value) { }

	// RVA: 0x18FE374
	private UnityWebRequestError GetError() { }

	// RVA: 0x18FE3C4
	public string get_error() { }

	// RVA: 0x18FD538
	public void set_url(string value) { }

	// RVA: 0x18FE794
	private UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x18FE688
	private void InternalSetUrl(string url) { }

	// RVA: 0x18FE638
	public Int64 get_responseCode() { }

	// RVA: 0x18FE1B0
	public bool get_isModifiable() { }

	// RVA: 0x18FE7FC
	public bool get_isDone() { }

	// RVA: 0x18FE5E8
	public Result get_result() { }

	// RVA: 0x18FE848
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x18FE8A0
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x18FEA30
	public string GetResponseHeader(string name) { }

	// RVA: 0x18FEA98
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x18FDF68
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x18FDA90
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x18FEB00
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x18FDF60
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x18FD978
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x18FDF70
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x18FEB68
	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x18FEBD0
	public void set_timeout(int value) { }

	// RVA: 0x18FED44
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x18FEE24
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x18FEEB8
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18FF36C
	private void Release() { }

	// RVA: 0x18FF3BC
	internal void .ctor() { }

	// RVA: 0x18FF3C4
	protected override void Finalize() { }

	// RVA: 0x18FF45C
	public virtual void Dispose() { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x18FF4B8
	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	// RVA: 0x18FF2D4
	public void .ctor(Byte[] data) { }

	// RVA: 0x18FF510
	public void .ctor(Unity.Collections.NativeArray<System.Byte> data, bool transferOwnership) { }

	// RVA: 0x18FF610
	public override void Dispose() { }

}


