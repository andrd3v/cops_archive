// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0x18D61D4
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x18D62C4
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x18D66AC
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x18D6A94
	private static string URLDecode(string encoded) { }

	// RVA: 0x18D6C0C
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

	// RVA: 0x18D6CAC
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x18D6CB4
	public void .ctor() { }

	// RVA: 0x18D6E78
	public void AddField(string fieldName, string value) { }

	// RVA: 0x18D6EBC
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x18D6FF0
	public System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }

	// RVA: 0x18D713C
	public Byte[] get_data() { }

	// RVA: 0x18D83D0
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

	// RVA: 0x18D8658
	private static Byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x18D8718
	private static void Byte2Hex(Byte b, Byte[] hexChars, Byte byte0, Byte byte1) { }

	// RVA: 0x18D835C
	public static Byte[] DataEncode(Byte[] toEncode) { }

	// RVA: 0x18D826C
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x18D876C
	public static Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	// RVA: 0x18D8BAC
	private static bool ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0x18D6B9C
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x18D9034
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x18D8C24
	public static Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0x18D80B4
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x18D90C8
	public static bool SevenBitClean(Byte* input, int inputLength) { }

	// RVA: 0x18D9124
	private static void .cctor() { }

}

// Namespace: UnityEngine.Networking
public class CertificateHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18D93B4
	private void Release() { }

	// RVA: 0x18D9404
	protected virtual bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x18D940C
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x18D9418
	public void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18D9474
	private void Release() { }

	// RVA: 0x18D94C4
	internal void .ctor() { }

	// RVA: 0x18D94CC
	protected override void Finalize() { }

	// RVA: 0x18D9564
	public virtual void Dispose() { }

	// RVA: 0x18D95C0
	public bool get_isDone() { }

	// RVA: 0x18D9610
	private bool IsDone() { }

	// RVA: 0x18D9660
	public ReadOnly get_nativeData() { }

	// RVA: 0x18D96D4
	public Byte[] get_data() { }

	// RVA: 0x18D96E0
	public string get_text() { }

	// RVA: 0x18D96EC
	protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18D96F8
	protected virtual Byte[] GetData() { }

	// RVA: 0x18D9800
	protected virtual string GetText() { }

	// RVA: 0x18D98D0
	private Encoding GetTextEncoder() { }

	// RVA: 0x18D9B78
	private string GetContentType() { }

	// RVA: 0x18D9BC8
	protected virtual bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x18D9BD0
	protected virtual void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0x18D9BDC
	protected virtual void ReceiveContentLength(int contentLength) { }

	// RVA: 0x18D9BE0
	protected virtual void CompleteContent() { }

	// RVA: 0x18D9BE4
	protected virtual float GetProgress() { }

	// RVA: 0x18D9BEC
	internal static Byte* InternalGetByteArray(DownloadHandler dh, int length) { }

	// RVA: 0x18D977C
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x18D9C54
	internal static Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }

	// RVA: 0x18D9DB0
	internal static void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }

	// RVA: 0x18D9DF8
	internal static void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, Byte* bytes, int length) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x18D9E6C
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x18D9EBC
	private void InternalCreateBuffer() { }

	// RVA: 0x18D9F1C
	public void .ctor() { }

	// RVA: 0x18D9F84
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18D9F8C
	public override void Dispose() { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x18DA020
	public UnityWebRequest get_webRequest() { }

	// RVA: 0x18DA028
	internal void set_webRequest(UnityWebRequest value) { }

	// RVA: 0x18DA030
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

	// RVA: 0x18DA038
	private static string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x18DA088
	internal static string GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0x18DA0D8
	public bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x18DA0E0
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x18DA0E8
	public bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x18DA0F0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x18DA0F8
	public bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x18DA100
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x18DA108
	internal static IntPtr Create() { }

	// RVA: 0x18DA148
	private void Release() { }

	// RVA: 0x18DA198
	internal void InternalDestroy() { }

	// RVA: 0x18DA284
	private void InternalSetDefaults() { }

	// RVA: 0x18DA298
	public void .ctor(string url) { }

	// RVA: 0x18DA3F8
	public void .ctor(string url, string method) { }

	// RVA: 0x18DA698
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x18DA9D4
	protected override void Finalize() { }

	// RVA: 0x18DABFC
	public void Dispose() { }

	// RVA: 0x18DAB58
	private void DisposeHandlers() { }

	// RVA: 0x18DADA4
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x18DADF4
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x18DA234
	public void Abort() { }

	// RVA: 0x18DAE68
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18DAED0
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x18DB02C
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x18DB094
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x18DA4DC
	public void set_method(string value) { }

	// RVA: 0x18DB1A0
	private UnityWebRequestError GetError() { }

	// RVA: 0x18DB1F0
	public string get_error() { }

	// RVA: 0x18DA364
	public void set_url(string value) { }

	// RVA: 0x18DB5C0
	private UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x18DB4B4
	private void InternalSetUrl(string url) { }

	// RVA: 0x18DB464
	public Int64 get_responseCode() { }

	// RVA: 0x18DAFDC
	public bool get_isModifiable() { }

	// RVA: 0x18DB628
	public bool get_isDone() { }

	// RVA: 0x18DB414
	public Result get_result() { }

	// RVA: 0x18DB674
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x18DB6CC
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x18DB85C
	public string GetResponseHeader(string name) { }

	// RVA: 0x18DB8C4
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x18DAD94
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x18DA8BC
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x18DB92C
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x18DAD8C
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x18DA7A4
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x18DAD9C
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x18DB994
	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x18DB9FC
	public void set_timeout(int value) { }

	// RVA: 0x18DBB70
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x18DBC50
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x18DBCE4
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18DC198
	private void Release() { }

	// RVA: 0x18DC1E8
	internal void .ctor() { }

	// RVA: 0x18DC1F0
	protected override void Finalize() { }

	// RVA: 0x18DC288
	public virtual void Dispose() { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x18DC2E4
	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	// RVA: 0x18DC100
	public void .ctor(Byte[] data) { }

	// RVA: 0x18DC33C
	public void .ctor(Unity.Collections.NativeArray<System.Byte> data, bool transferOwnership) { }

	// RVA: 0x18DC43C
	public override void Dispose() { }

}


