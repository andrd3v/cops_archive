// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	// RVA: 0x1A57DFC
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x1A57EEC
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x1A582D4
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x1A586C4
	private static string URLDecode(string encoded) { }

	// RVA: 0x1A5883C
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

	// RVA: 0x1A588DC
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x1A588E4
	public void .ctor() { }

	// RVA: 0x1A58AA8
	public void AddField(string fieldName, string value) { }

	// RVA: 0x1A58AEC
	public void AddField(string fieldName, string value, Encoding e) { }

	// RVA: 0x1A58C20
	public System.Collections.Generic.Dictionary<System.String,System.String> get_headers() { }

	// RVA: 0x1A58D6C
	public Byte[] get_data() { }

	// RVA: 0x1A5A000
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

	// RVA: 0x1A5A288
	private static Byte Hex2Byte(Byte[] b, int offset) { }

	// RVA: 0x1A5A348
	private static void Byte2Hex(Byte b, Byte[] hexChars, Byte byte0, Byte byte1) { }

	// RVA: 0x1A59F8C
	public static Byte[] DataEncode(Byte[] toEncode) { }

	// RVA: 0x1A59E9C
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x1A5A39C
	public static Byte[] Encode(Byte[] input, Byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	// RVA: 0x1A5A7DC
	private static bool ByteArrayContains(Byte[] array, Byte b) { }

	// RVA: 0x1A587CC
	public static Byte[] URLDecode(Byte[] toEncode) { }

	// RVA: 0x1A5AC64
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	// RVA: 0x1A5A854
	public static Byte[] Decode(Byte[] input, Byte escapeChar, Byte[] space) { }

	// RVA: 0x1A59CE4
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x1A5ACF8
	public static bool SevenBitClean(Byte* input, int inputLength) { }

	// RVA: 0x1A5AD54
	private static void .cctor() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5B110
	public static IntPtr ConvertToNative(CertificateHandler handler) { }

}

// Namespace: UnityEngine.Networking
public class CertificateHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1A5AFE4
	private void ReleaseFromScripting() { }

	// RVA: 0x1A5B0A4
	protected virtual bool ValidateCertificate(Byte[] certificateData) { }

	// RVA: 0x1A5B0AC
	internal bool ValidateCertificateNative(Byte[] certificateData) { }

	// RVA: 0x1A5B0B8
	public void Dispose() { }

	// RVA: 0x1A5B054
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5BE74
	public static IntPtr ConvertToNative(DownloadHandler handler) { }

}

// Namespace: UnityEngine.Networking
public class DownloadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1A5B12C
	private void ReleaseFromScripting() { }

	// RVA: 0x1A5B1EC
	internal void .ctor() { }

	// RVA: 0x1A5B1F4
	protected override void Finalize() { }

	// RVA: 0x1A5B28C
	public virtual void Dispose() { }

	// RVA: 0x1A5B2E4
	public bool get_isDone() { }

	// RVA: 0x1A5B354
	private bool IsDone() { }

	// RVA: 0x1A5B414
	public ReadOnly get_nativeData() { }

	// RVA: 0x1A5B488
	public Byte[] get_data() { }

	// RVA: 0x1A5B494
	public string get_text() { }

	// RVA: 0x1A5B4A0
	protected virtual Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x1A5B4AC
	protected virtual Byte[] GetData() { }

	// RVA: 0x1A5B5B4
	protected virtual string GetText() { }

	// RVA: 0x1A5B684
	private Encoding GetTextEncoder() { }

	// RVA: 0x1A5B9DC
	private string GetContentType() { }

	// RVA: 0x1A5BB5C
	protected virtual bool ReceiveData(Byte[] data, int dataLength) { }

	// RVA: 0x1A5BB64
	protected virtual void ReceiveContentLengthHeader(UInt64 contentLength) { }

	// RVA: 0x1A5BB70
	protected virtual void ReceiveContentLength(int contentLength) { }

	// RVA: 0x1A5BB74
	protected virtual void CompleteContent() { }

	// RVA: 0x1A5BB78
	protected virtual float GetProgress() { }

	// RVA: 0x1A5BB80
	internal static Byte* InternalGetByteArray(DownloadHandler dh, int length) { }

	// RVA: 0x1A5B530
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	// RVA: 0x1A5BC64
	internal static Unity.Collections.NativeArray<System.Byte> InternalGetNativeArray(DownloadHandler dh, Unity.Collections.NativeArray<System.Byte>& nativeArray) { }

	// RVA: 0x1A5BDB8
	internal static void DisposeNativeArray(Unity.Collections.NativeArray<System.Byte>& data) { }

	// RVA: 0x1A5BE00
	internal static void CreateNativeArrayForNativeData(Unity.Collections.NativeArray<System.Byte>& data, Byte* bytes, int length) { }

	// RVA: 0x1A5B19C
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5B3C4
	private static bool IsDone_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5BAF4
	private static void GetContentType_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x1A5BBFC
	private static Byte* InternalGetByteArray_Injected(IntPtr dh, int length) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerBuffer
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x1A5BE90
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x1A5BEE0
	private void InternalCreateBuffer() { }

	// RVA: 0x1A5BF40
	public void .ctor() { }

	// RVA: 0x1A5BFA8
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x1A5BFB0
	public override void Dispose() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5C050
	public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }

}

// Namespace: UnityEngine.Networking
public class UnityWebRequestAsyncOperation
{
	// Fields
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1A5C038
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x1A5C040
	public UnityWebRequest get_webRequest() { }

	// RVA: 0x1A5C048
	internal void set_webRequest(UnityWebRequest value) { }

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

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5F39C
	public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }

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

	// RVA: 0x1A5C0B8
	private static string GetWebErrorString(UnityWebRequestError err) { }

	// RVA: 0x1A5C208
	internal static string GetHTTPStatusString(Int64 responseCode) { }

	// RVA: 0x1A5C358
	public bool get_disposeCertificateHandlerOnDispose() { }

	// RVA: 0x1A5C360
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	// RVA: 0x1A5C368
	public bool get_disposeDownloadHandlerOnDispose() { }

	// RVA: 0x1A5C370
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	// RVA: 0x1A5C378
	public bool get_disposeUploadHandlerOnDispose() { }

	// RVA: 0x1A5C380
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x1A5C388
	internal static IntPtr Create() { }

	// RVA: 0x1A5C3C8
	private void Release() { }

	// RVA: 0x1A5C488
	internal void InternalDestroy() { }

	// RVA: 0x1A5C5AC
	private void InternalSetDefaults() { }

	// RVA: 0x1A5C5C0
	public void .ctor(string url) { }

	// RVA: 0x1A5C720
	public void .ctor(string url, string method) { }

	// RVA: 0x1A5C9C0
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x1A5CDDC
	protected override void Finalize() { }

	// RVA: 0x1A5D004
	public void Dispose() { }

	// RVA: 0x1A5CF64
	private void DisposeHandlers() { }

	// RVA: 0x1A5D1A4
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x1A5D2D0
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	// RVA: 0x1A5C53C
	public void Abort() { }

	// RVA: 0x1A5D35C
	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x1A5D44C
	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	// RVA: 0x1A5D62C
	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x1A5D860
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x1A5C804
	public void set_method(string value) { }

	// RVA: 0x1A5D980
	private UnityWebRequestError GetError() { }

	// RVA: 0x1A5DA40
	public string get_error() { }

	// RVA: 0x1A5C68C
	public void set_url(string value) { }

	// RVA: 0x1A5DE3C
	private UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x1A5DD1C
	private void InternalSetUrl(string url) { }

	// RVA: 0x1A5DCAC
	public Int64 get_responseCode() { }

	// RVA: 0x1A5D5BC
	public bool get_isModifiable() { }

	// RVA: 0x1A5E110
	public bool get_isDone() { }

	// RVA: 0x1A5DC3C
	public Result get_result() { }

	// RVA: 0x1A5E1D0
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x1A5E4BC
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x1A5E668
	public string GetResponseHeader(string name) { }

	// RVA: 0x1A5E8EC
	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A5D194
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x1A5CC54
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x1A5E9D8
	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1A5D18C
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x1A5CACC
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x1A5D19C
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x1A5EAC4
	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x1A5EBB4
	public void set_timeout(int value) { }

	// RVA: 0x1A5ED74
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x1A5EE54
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x1A5EEE8
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x1A5C1A0
	private static void GetWebErrorString_Injected(UnityWebRequestError err, ManagedSpanWrapper ret) { }

	// RVA: 0x1A5C2F0
	private static void GetHTTPStatusString_Injected(Int64 responseCode, ManagedSpanWrapper ret) { }

	// RVA: 0x1A5C438
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5D280
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5D30C
	private static void Abort_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5D3E4
	private static UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequestMethod methodType) { }

	// RVA: 0x1A5D7F8
	private static UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ManagedSpanWrapper customMethodName) { }

	// RVA: 0x1A5D9F0
	private static UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5E008
	private static UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ManagedSpanWrapper url) { }

	// RVA: 0x1A5E070
	private static Int64 get_responseCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5E0C0
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5E180
	private static Result get_result_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A5E464
	private static UnityWebRequestError InternalSetRequestHeader_Injected(IntPtr _unity_self, ManagedSpanWrapper name, ManagedSpanWrapper value) { }

	// RVA: 0x1A5E894
	private static void GetResponseHeader_Injected(IntPtr _unity_self, ManagedSpanWrapper name, ManagedSpanWrapper ret) { }

	// RVA: 0x1A5E970
	private static UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh) { }

	// RVA: 0x1A5EA5C
	private static UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }

	// RVA: 0x1A5EB4C
	private static UnityWebRequestError SetTimeoutMsec_Injected(IntPtr _unity_self, int timeout) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5F570
	public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }

}

// Namespace: UnityEngine.Networking
public class UploadHandler
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1A5F3B8
	private void ReleaseFromScripting() { }

	// RVA: 0x1A5F478
	internal void .ctor() { }

	// RVA: 0x1A5F480
	protected override void Finalize() { }

	// RVA: 0x1A5F518
	public virtual void Dispose() { }

	// RVA: 0x1A5F428
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine.Networking
public sealed class UploadHandlerRaw
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_Payload; // 0x18

	// Methods

	// RVA: 0x1A5F58C
	private static IntPtr Create(UploadHandlerRaw self, Byte* data, int dataLength) { }

	// RVA: 0x1A5F304
	public void .ctor(Byte[] data) { }

	// RVA: 0x1A5F5E4
	public void .ctor(Unity.Collections.NativeArray<System.Byte> data, bool transferOwnership) { }

	// RVA: 0x1A5F6E4
	public override void Dispose() { }

}


