// Namespace: 
internal class <Module>
{}

// Namespace: 
public static class EntryPointExtensions
{
	// Fields
	public static readonly System.Collections.Generic.Dictionary<TapjoyUnity.TJEntryPoint,System.String> entryPointValues; // 0x0

	// Methods

	// RVA: 0x13AA68C
	public static string GetValue(TJEntryPoint entryPoint) { }

	// RVA: 0x13AA748
	private static void .cctor() { }

}

// Namespace: 
private struct MonoScriptData
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Methods

	// RVA: 0x13AAA00
	private static MonoScriptData Get() { }

	// RVA: 0x13AAB04
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction
{
	// Methods

	// RVA: 0x13AAB0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AABAC
	public virtual void Invoke() { }

	// RVA: 0x13AABC0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13AAC18
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1, T2 arg2) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3, T4>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TResult Invoke() { }

	// RVA: 0x3525998
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x26AD93C
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TResult Invoke(T1 arg1) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x26AD93C
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public enum LoggingLevel
{
	// Fields
	public int value__; // 0x10
	public const LoggingLevel Error = 0;
	public const LoggingLevel Warning = 1;
	public const LoggingLevel Info = 2;
	public const LoggingLevel Debug = 3;
}

// Namespace: 
public sealed class OnConnectSuccessHandler
{
	// Methods

	// RVA: 0x13AE398
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AE438
	public virtual void Invoke() { }

	// RVA: 0x13AE44C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13AE4A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectFailedHandler
{
	// Methods

	// RVA: 0x13AE4B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AE554
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x13AE568
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x13AE600
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectWarningHandler
{
	// Methods

	// RVA: 0x13AE60C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AE6B0
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x13AE6C4
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x13AE75C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDSuccessHandler
{
	// Methods

	// RVA: 0x13AE768
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AE808
	public virtual void Invoke() { }

	// RVA: 0x13AE81C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13AE874
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailedHandler
{
	// Methods

	// RVA: 0x13AE880
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AE924
	public virtual void Invoke(int code, string errorMessage) { }

	// RVA: 0x13AE938
	public virtual IAsyncResult BeginInvoke(int code, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13AE9D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailureHandler
{
	// Methods

	// RVA: 0x13AE9DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AEA90
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x13AEAA4
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13AEAF4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseHandler
{
	// Methods

	// RVA: 0x13AEB00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AEBBC
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x13AEBD0
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x13AEC68
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseFailureHandler
{
	// Methods

	// RVA: 0x13AEC74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AED28
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x13AED3C
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13AED8C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseHandler
{
	// Methods

	// RVA: 0x13AED98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AEE54
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x13AEE68
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x13AEF00
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x13AEF0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AEFC0
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x13AEFD4
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13AF024
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseHandler
{
	// Methods

	// RVA: 0x13AF030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AF0EC
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x13AF100
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x13AF198
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x13AF1A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AF258
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x13AF26C
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13AF2BC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnEarnedCurrencyHandler
{
	// Methods

	// RVA: 0x13AF2C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13AF384
	public virtual void Invoke(string currencyName, int amount) { }

	// RVA: 0x13AF398
	public virtual IAsyncResult BeginInvoke(string currencyName, int amount, AsyncCallback callback, object object) { }

	// RVA: 0x13AF430
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public class Tapjoy
{
	// Fields
	internal const string VERSION_NAME = "14.4.0";
	internal const string VERSION_SUFFIX = "";
	private static bool _isConnected; // 0x0
	private static OnConnectSuccessHandler OnConnectSuccessInvoker; // 0x8
	private static OnConnectSuccessHandler OnConnectSuccessInternalInvoker; // 0x10
	private static OnConnectFailedHandler OnConnectFailedInvoker; // 0x18
	private static OnConnectFailedHandler OnConnectFailedInternalInvoker; // 0x20
	private static OnConnectWarningHandler OnConnectWarningInvoker; // 0x28
	private static OnConnectWarningHandler OnConnectWarningInternalInvoker; // 0x30
	private static OnSetUserIDSuccessHandler OnSetUserIDSuccessInvoker; // 0x38
	private static OnSetUserIDFailedHandler OnSetUserIDFailedInvoker; // 0x40
	private static OnSetUserIDFailureHandler OnSetUserIDFailureInvoker; // 0x48
	private static OnGetCurrencyBalanceResponseHandler OnGetCurrencyBalanceResponseInvoker; // 0x50
	private static OnGetCurrencyBalanceResponseFailureHandler OnGetCurrencyBalanceResponseFailureInvoker; // 0x58
	private static OnSpendCurrencyResponseHandler OnSpendCurrencyResponseInvoker; // 0x60
	private static OnSpendCurrencyResponseFailureHandler OnSpendCurrencyResponseFailureInvoker; // 0x68
	private static OnAwardCurrencyResponseHandler OnAwardCurrencyResponseInvoker; // 0x70
	private static OnAwardCurrencyResponseFailureHandler OnAwardCurrencyResponseFailureInvoker; // 0x78
	private static OnEarnedCurrencyHandler OnEarnedCurrencyInvoker; // 0x80

	// Methods

	// RVA: 0x13AAC24
	public static string get_Version() { }

	// RVA: 0x13AACBC
	public static bool get_IsConnected() { }

	// RVA: 0x13AAD08
	public static void set_IsConnected(bool value) { }

	// RVA: 0x13AAD60
	public static void Connect() { }

	// RVA: 0x13AB158
	public static void Connect(string sdkKey) { }

	// RVA: 0x13AB318
	public static void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x13AB63C
	public static void SetLoggingLevel(LoggingLevel loggingLevel) { }

	// RVA: 0x13AB778
	public static LoggingLevel GetLoggingLevel() { }

	// RVA: 0x13AB79C
	public static void SetDebugEnabled(bool enable) { }

	// RVA: 0x13AB7F0
	public static void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x13AB828
	public static bool GetOptOutAdvertisingID() { }

	// RVA: 0x13AB850
	public static void ActionComplete(string actionID) { }

	// RVA: 0x13AB854
	public static void SetUserID(string userId) { }

	// RVA: 0x13AB88C
	public static string GetUserID() { }

	// RVA: 0x13AB8B4
	public static void SetCustomParameter(string customParam) { }

	// RVA: 0x13AB8EC
	public static string GetCustomParameter() { }

	// RVA: 0x13AB914
	public static void SetUserLevel(int userLevel) { }

	// RVA: 0x13AB94C
	public static int GetUserLevel() { }

	// RVA: 0x13AB974
	public static void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x13AB9AC
	public static int GetMaxLevel() { }

	// RVA: 0x13AB9D4
	public static void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x13ABA0C
	public static TJSegment GetUserSegment() { }

	// RVA: 0x13ABA34
	public static Double GetScreenScale() { }

	// RVA: 0x13ABA5C
	public static void ClearUserTags() { }

	// RVA: 0x13ABA84
	public static System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x13ABAAC
	public static void AddUserTag(string tag) { }

	// RVA: 0x13ABAE4
	public static void RemoveUserTag(string tag) { }

	// RVA: 0x13ABB1C
	public static void TrackPurchase(string currencyCode, Double productPrice) { }

	// RVA: 0x13ABB64
	public static void TrackPurchase(string productId, string currencyCode, Double productPrice, string campaignId) { }

	// RVA: 0x13ABBAC
	public static void TrackPurchaseInGooglePlayStore(string skuDetails, string purchaseData, string dataSignature, string campaignId) { }

	// RVA: 0x13ABBB0
	public static void TrackPurchaseInAppleAppStore(string productId, string currencyCode, Double productPrice, string transactionId, string campaignId) { }

	// RVA: 0x13ABBF8
	public static void AwardCurrency(int amount) { }

	// RVA: 0x13ABC30
	public static void GetCurrencyBalance() { }

	// RVA: 0x13ABC58
	public static void SpendCurrency(int amount) { }

	// RVA: 0x13ABC90
	public static string GetSupportURL() { }

	// RVA: 0x13ABCD4
	public static string GetSupportURL(string currencyID) { }

	// RVA: 0x13ABD18
	public static void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x13ABD40
	public static void add_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x13ABE14
	public static void remove_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x13ABEE8
	internal static void add_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x13ABFBC
	internal static void remove_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x13AC090
	public static void add_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x13AC164
	public static void remove_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x13AC238
	internal static void add_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x13AC30C
	internal static void remove_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x13AC3E0
	public static void add_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x13AC4B4
	public static void remove_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x13AC588
	internal static void add_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x13AC65C
	internal static void remove_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x13AC730
	internal static void DispatchConnectEvent(string connectCallbackMethod) { }

	// RVA: 0x13ACAD0
	public static void add_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x13ACBA4
	public static void remove_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x13ACC78
	public static void add_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x13ACD4C
	public static void remove_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x13ACE20
	public static void add_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x13ACEF4
	public static void remove_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x13ACFC8
	internal static void DispatchSetUserIDEvent(string commaDelimitedMessage) { }

	// RVA: 0x13AD228
	public static void add_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x13AD2FC
	public static void remove_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x13AD3D0
	public static void add_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x13AD4A4
	public static void remove_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x13AD578
	public static void add_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x13AD64C
	public static void remove_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x13AD720
	public static void add_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x13AD7F4
	public static void remove_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x13AD8C8
	public static void add_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x13AD99C
	public static void remove_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x13ADA70
	public static void add_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x13ADB44
	public static void remove_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x13ADC18
	public static void add_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x13ADCEC
	public static void remove_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x13ADDC0
	internal static void DispatchCurrencyEvent(string commaDelimitedMessage) { }

	// RVA: 0x13AE390
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJActionRequest
{
	// Fields
	public string requestID; // 0x10
	public string token; // 0x18

	// Methods

	// RVA: 0x13AF43C
	protected override void Finalize() { }

	// RVA: 0x13AF5E8
	internal void .ctor(string requestID, string token) { }

	// RVA: 0x13AF638
	public void Completed() { }

	// RVA: 0x13AF670
	public void Cancelled() { }

}

// Namespace: TapjoyUnity
public enum TJEntryPoint
{
	// Fields
	public int value__; // 0x10
	public const TJEntryPoint UNKNOWN = 0;
	public const TJEntryPoint OTHER = 1;
	public const TJEntryPoint MAIN_MENU = 2;
	public const TJEntryPoint HUD = 3;
	public const TJEntryPoint EXIT = 4;
	public const TJEntryPoint FAIL = 5;
	public const TJEntryPoint COMPLETE = 6;
	public const TJEntryPoint INBOX = 7;
	public const TJEntryPoint INIT = 8;
	public const TJEntryPoint STORE = 9;
}

// Namespace: 
public sealed class OnRequestSuccessHandler
{
	// Methods

	// RVA: 0x13B0014
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B00B4
	public virtual void Invoke() { }

	// RVA: 0x13B00C8
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13B0120
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x13B012C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B01D0
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x13B01E4
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13B027C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x13B0288
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B0328
	public virtual void Invoke() { }

	// RVA: 0x13B033C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13B0394
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentErrorHandler
{
	// Methods

	// RVA: 0x13B03A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B0444
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x13B0458
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13B04F0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public class TJOfferwallDiscover
{
	// Fields
	private static OnRequestSuccessHandler OnRequestSuccessInvoker; // 0x0
	private static OnRequestFailureHandler OnRequestFailureInvoker; // 0x8
	private static OnContentReadyHandler OnContentReadyInvoker; // 0x10
	private static OnContentErrorHandler OnContentErrorInvoker; // 0x18

	// Methods

	// RVA: 0x13AF6A8
	public void .ctor() { }

	// RVA: 0x13AF6B0
	public static void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13AF6F8
	public static void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x13AF760
	public static void ShowOfferwallDiscover() { }

	// RVA: 0x13AF788
	public static void DestroyOfferwallDiscover() { }

	// RVA: 0x13AF7B0
	internal static void DispatchOfferwallDiscoverEvent(string commaDelimitedMessage) { }

	// RVA: 0x13AF984
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x13AFA50
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x13AFB1C
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13AFBF0
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13AFCC4
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13AFD98
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13AFE6C
	public static void add_OnContentError(OnContentErrorHandler value) { }

	// RVA: 0x13AFF40
	public static void remove_OnContentError(OnContentErrorHandler value) { }

}

// Namespace: 
public sealed class OnRequestSuccessHandler
{
	// Methods

	// RVA: 0x13B2B1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B2C3C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B2C50
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B2CA0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x13B2CAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B2DD0
	public virtual void Invoke(TJPlacement placement, string error) { }

	// RVA: 0x13B2DE4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13B2E40
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x13B2E4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B2F6C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B2F80
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B2FD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentShowHandler
{
	// Methods

	// RVA: 0x13B2FDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B30FC
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B3110
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B3160
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentDismissHandler
{
	// Methods

	// RVA: 0x13B316C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B328C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B32A0
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B32F0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnClickHandler
{
	// Methods

	// RVA: 0x13B32FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B341C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B3430
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B3480
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnPurchaseRequestHandler
{
	// Methods

	// RVA: 0x13B348C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B35B0
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string productId) { }

	// RVA: 0x13B35C4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string productId, AsyncCallback callback, object object) { }

	// RVA: 0x13B3620
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRewardRequestHandler
{
	// Methods

	// RVA: 0x13B362C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B3750
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity) { }

	// RVA: 0x13B3764
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity, AsyncCallback callback, object object) { }

	// RVA: 0x13B3800
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceSuccessHandler
{
	// Methods

	// RVA: 0x13B380C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B392C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B3940
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B3990
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceFailureHandler
{
	// Methods

	// RVA: 0x13B399C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B3AC0
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x13B3AD4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13B3B70
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredSuccessHandler
{
	// Methods

	// RVA: 0x13B3B7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B3C9C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13B3CB0
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13B3D00
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredFailureHandler
{
	// Methods

	// RVA: 0x13B3D0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B3E30
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x13B3E44
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13B3EE0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public class TJPlacement
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.WeakReference> placementDictionary; // 0x0
	private string _placementName; // 0x10
	private string _guid; // 0x18
	internal static TapjoyUnity.TapjoyAction<System.String> OnShowContentCalled; // 0x8
	private static OnRequestSuccessHandler OnRequestSuccessInvoker; // 0x10
	private static OnRequestFailureHandler OnRequestFailureInvoker; // 0x18
	private static OnContentReadyHandler OnContentReadyInvoker; // 0x20
	private static OnContentShowHandler OnContentShowInvoker; // 0x28
	private static OnContentDismissHandler OnContentDismissInvoker; // 0x30
	private static OnClickHandler OnClickInvoker; // 0x38
	private static OnPurchaseRequestHandler OnPurchaseRequestInvoker; // 0x40
	private static OnRewardRequestHandler OnRewardRequestInvoker; // 0x48
	private static OnSetCurrencyBalanceSuccessHandler OnSetCurrencyBalanceSuccessInvoker; // 0x50
	private static OnSetCurrencyBalanceFailureHandler OnSetCurrencyBalanceFailureInvoker; // 0x58
	private static OnSetCurrencyAmountRequiredSuccessHandler OnSetCurrencyAmountRequiredSuccessInvoker; // 0x60
	private static OnSetCurrencyAmountRequiredFailureHandler OnSetCurrencyAmountRequiredFailureInvoker; // 0x68

	// Methods

	// RVA: 0x13B04FC
	private void .ctor(string placementName) { }

	// RVA: 0x13B0638
	protected override void Finalize() { }

	// RVA: 0x13B07DC
	public static TJPlacement CreatePlacement(string placementName) { }

	// RVA: 0x13B0840
	public static void DismissContent() { }

	// RVA: 0x13B0868
	public void RequestContent() { }

	// RVA: 0x13B095C
	public void ShowContent() { }

	// RVA: 0x13B0A30
	public bool IsContentAvailable() { }

	// RVA: 0x13B0A68
	public bool IsContentReady() { }

	// RVA: 0x13B0AA0
	public string GetName() { }

	// RVA: 0x13B0AA8
	public void SetEntryPoint(TJEntryPoint entryPoint) { }

	// RVA: 0x13B0AE8
	public void SetCurrencyBalance(string currencyId, int balance) { }

	// RVA: 0x13B0B38
	public int GetCurrencyBalance(string currencyId) { }

	// RVA: 0x13B0B78
	public void SetRequiredAmount(string currencyId, int amount) { }

	// RVA: 0x13B0BC8
	public int GetRequiredAmount(string currencyId) { }

	// RVA: 0x13B0C08
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x13B0CEC
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x13B0DD0
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13B0EB4
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13B0F98
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13B107C
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13B1160
	public static void add_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x13B1244
	public static void remove_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x13B1328
	public static void add_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x13B140C
	public static void remove_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x13B14F0
	public static void add_OnClick(OnClickHandler value) { }

	// RVA: 0x13B15D4
	public static void remove_OnClick(OnClickHandler value) { }

	// RVA: 0x13B16B8
	public static void add_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x13B179C
	public static void remove_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x13B1880
	public static void add_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x13B1964
	public static void remove_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x13B1A48
	public static void add_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x13B1B2C
	public static void remove_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x13B1C10
	public static void add_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x13B1CF4
	public static void remove_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x13B1DD8
	public static void add_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x13B1EBC
	public static void remove_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x13B1FA0
	public static void add_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x13B2084
	public static void remove_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x13B2168
	internal static void DispatchPlacementEvent(string commaDelimitedMessage) { }

	// RVA: 0x13B2A80
	private static void .cctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJPrivacyPolicy
{
	// Methods

	// RVA: 0x13B3EEC
	private void .ctor() { }

	// RVA: 0x13B3F18
	public static TJPrivacyPolicy GetPrivacyPolicy() { }

	// RVA: 0x13B3F88
	public void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x13B3FBC
	public TJStatus GetSubjectToGDPR() { }

	// RVA: 0x13B3FE0
	public void SetUserConsent(TJStatus consent) { }

	// RVA: 0x13B4014
	public TJStatus GetUserConsent() { }

	// RVA: 0x13B403C
	public void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x13B4074
	public TJStatus GetBelowConsentAge() { }

	// RVA: 0x13B409C
	public void SetUSPrivacy(string privacyPolicy) { }

	// RVA: 0x13B40D4
	public string GetUSPrivacy() { }

}

// Namespace: TapjoyUnity
public enum TJSegment
{
	// Fields
	public int value__; // 0x10
	public const TJSegment NonPayer = 0;
	public const TJSegment Payer = 1;
	public const TJSegment VIP = 2;
	public const TJSegment Unknown = 4294967295;
}

// Namespace: TapjoyUnity
public enum TJStatus
{
	// Fields
	public int value__; // 0x10
	public const TJStatus FALSE = 0;
	public const TJStatus TRUE = 1;
	public const TJStatus UNKNOWN = 2;
}

// Namespace: 
internal sealed class OnInstanceSetHandler
{
	// Methods

	// RVA: 0x13B434C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13B43EC
	public virtual void Invoke() { }

	// RVA: 0x13B4400
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13B4458
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity.Internal
public abstract class ApiBinding
{
	// Fields
	protected const string DEFAULT_EVENT_VALUE_NAME = "value";
	protected const string VERSION_NAME = "14.4.0";
	protected const string CONNECT_FLAG_DICTIONARY_NAME = "connectFlags";
	private static ApiBinding instance; // 0x0
	private static OnInstanceSetHandler onInstanceSetHandler; // 0x8
	private string name; // 0x10

	// Methods

	// RVA: 0x13AB670
	public static ApiBinding get_Instance() { }

	// RVA: 0x13B4164
	protected static void SetInstance(ApiBinding value) { }

	// RVA: 0x13B4240
	internal static void set_OnInstanceSet(OnInstanceSetHandler value) { }

	// RVA: 0x13B4310
	protected void .ctor(string name) { }

	// RVA: 0x13B4344
	internal string get_Name() { }

	// RVA: -1
	public abstract void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: -1
	public abstract string GetSDKVersion() { }

	// RVA: -1
	public abstract void SetLoggingLevel(LoggingLevel loggingLevel) { }

	// RVA: -1
	public abstract LoggingLevel GetLoggingLevel() { }

	// RVA: -1
	public abstract void ActivateUnitySupport() { }

	// RVA: -1
	public abstract void GetPrivacyPolicy() { }

	// RVA: -1
	public abstract void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: -1
	public abstract int GetSubjectToGDPR() { }

	// RVA: -1
	public abstract void SetUserConsent(TJStatus consent) { }

	// RVA: -1
	public abstract int GetUserConsent() { }

	// RVA: -1
	public abstract void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: -1
	public abstract int GetBelowConsentAge() { }

	// RVA: -1
	public abstract void SetUSPrivacy(string privacyConsent) { }

	// RVA: -1
	public abstract string GetUSPrivacy() { }

	// RVA: -1
	public abstract void OptOutAdvertisingID(bool optOut) { }

	// RVA: -1
	public abstract bool GetOptOutAdvertisingID() { }

	// RVA: -1
	public abstract void GetCurrencyBalance() { }

	// RVA: -1
	public abstract void SpendCurrency(int points) { }

	// RVA: -1
	public abstract void AwardCurrency(int points) { }

	// RVA: -1
	public abstract void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: -1
	public abstract void CreatePlacement(string placementGuid, string placementName) { }

	// RVA: -1
	public abstract void DismissPlacementContent() { }

	// RVA: -1
	public abstract void RequestPlacementContent(string placementGuid) { }

	// RVA: -1
	public abstract void ShowPlacementContent(string placementGuid) { }

	// RVA: -1
	public abstract void ActionRequestCompleted(string requestId) { }

	// RVA: -1
	public abstract void ActionRequestCancelled(string requestId) { }

	// RVA: -1
	public abstract bool IsPlacementContentReady(string placementGuid) { }

	// RVA: -1
	public abstract bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: -1
	public abstract void RemovePlacement(string placementGuid) { }

	// RVA: -1
	public abstract void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: -1
	public abstract void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: -1
	public abstract int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: -1
	public abstract void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: -1
	public abstract int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: -1
	public abstract void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: -1
	public abstract void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: -1
	public abstract void ShowOfferwallDiscover() { }

	// RVA: -1
	public abstract void DestroyOfferwallDiscover() { }

	// RVA: -1
	public abstract void RemoveActionRequest(string requestId) { }

	// RVA: -1
	public abstract void SetUserID(string userId) { }

	// RVA: -1
	public abstract string GetUserID() { }

	// RVA: -1
	public abstract void SetCustomParameter(string customParam) { }

	// RVA: -1
	public abstract string GetCustomParameter() { }

	// RVA: -1
	public abstract void SetUserLevel(int userLevel) { }

	// RVA: -1
	public abstract int GetUserLevel() { }

	// RVA: -1
	public abstract void SetMaxLevel(int maxUserLevel) { }

	// RVA: -1
	public abstract int GetMaxLevel() { }

	// RVA: -1
	public abstract void SetUserSegment(TJSegment userSegment) { }

	// RVA: -1
	public abstract int GetUserSegment() { }

	// RVA: -1
	public abstract Double GetScreenScale() { }

	// RVA: -1
	public abstract void ClearUserTags() { }

	// RVA: -1
	public abstract System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: -1
	public abstract void AddUserTag(string tag) { }

	// RVA: -1
	public abstract void RemoveUserTag(string tag) { }

	// RVA: -1
	public abstract void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal class ApiBindingNone
{
	// Methods

	// RVA: 0x13B40FC
	public void .ctor() { }

	// RVA: 0x13B4464
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x13B4468
	public override string GetSDKVersion() { }

	// RVA: 0x13B44AC
	public override void SetLoggingLevel(LoggingLevel loggingLevel) { }

	// RVA: 0x13B44B0
	public override LoggingLevel GetLoggingLevel() { }

	// RVA: 0x13B44B8
	public override void ActivateUnitySupport() { }

	// RVA: 0x13B44BC
	public override void GetPrivacyPolicy() { }

	// RVA: 0x13B44C0
	public override void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x13B44C4
	public override int GetSubjectToGDPR() { }

	// RVA: 0x13B44CC
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x13B44D0
	public override int GetUserConsent() { }

	// RVA: 0x13B44D8
	public override void SetBelowConsentAge(TJStatus isBelowConsentAge) { }

	// RVA: 0x13B44DC
	public override int GetBelowConsentAge() { }

	// RVA: 0x13B44E4
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13B44E8
	public override string GetUSPrivacy() { }

	// RVA: 0x13B452C
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x13B4530
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x13B4538
	public override void GetCurrencyBalance() { }

	// RVA: 0x13B453C
	public override void SpendCurrency(int amount) { }

	// RVA: 0x13B4540
	public override void AwardCurrency(int amount) { }

	// RVA: 0x13B4544
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x13B4548
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x13B454C
	public override void DismissPlacementContent() { }

	// RVA: 0x13B4550
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x13B4554
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x13B4558
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13B4560
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x13B4568
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x13B456C
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x13B4574
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x13B4578
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x13B4580
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x13B4584
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x13B4588
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x13B458C
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13B4590
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x13B4594
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x13B4598
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x13B459C
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x13B45A0
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x13B45A4
	public override void SetUserID(string userId) { }

	// RVA: 0x13B45A8
	public override string GetUserID() { }

	// RVA: 0x13B45EC
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x13B45F0
	public override string GetCustomParameter() { }

	// RVA: 0x13B4634
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x13B4638
	public override int GetUserLevel() { }

	// RVA: 0x13B4640
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x13B4644
	public override int GetMaxLevel() { }

	// RVA: 0x13B464C
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x13B4650
	public override int GetUserSegment() { }

	// RVA: 0x13B4658
	public override Double GetScreenScale() { }

	// RVA: 0x13B4660
	public override void ClearUserTags() { }

	// RVA: 0x13B4664
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x13B466C
	public override void AddUserTag(string tag) { }

	// RVA: 0x13B4670
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x13B4674
	public override void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal static class ForegroundRealtimeClock
{
	// Fields
	private static float realtimeSpentWhilePaused; // 0x0
	private static float realtimePaused; // 0x4

	// Methods

	// RVA: 0x13B4678
	internal static void OnApplicationPause(bool paused) { }

	// RVA: 0x13B471C
	internal static float get_Realtime() { }

}

// Namespace: TapjoyUnity.Internal
public static class UnityDependency
{
	// Fields
	public static TapjoyUnity.TapjoyFunc<System.Int32> sceneCount; // 0x0
	public static TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> GetActiveScene; // 0x8
	public static TapjoyUnity.TapjoyFunc<System.Int32,TapjoyUnity.Internal.UnityCompat.SceneCompat> GetSceneAt; // 0x10
	public static TapjoyUnity.TapjoyFunc<System.Object,System.String> ToJson; // 0x18

	// Methods

	// RVA: 0x13B4774
	public static void OnActiveSceneChanged(SceneCompat oldScene, SceneCompat newScene) { }

	// RVA: 0x13B4804
	public static void OnSceneLoaded(SceneCompat scene, int loadMode) { }

	// RVA: 0x13B4890
	public static void OnSceneUnloaded(SceneCompat scene) { }

}

// Namespace: TapjoyUnity.Internal
[Serializable]
public class PlatformSettings
{
	// Fields
	private string sdkKey; // 0x10
	private bool disableAdvertisingId; // 0x18
	protected bool dirty; // 0x19

	// Methods

	// RVA: 0x13B4910
	public void .ctor() { }

	// RVA: 0x13B4950
	public string get_SdkKey() { }

	// RVA: 0x13B4958
	public void set_SdkKey(string value) { }

	// RVA: 0x13B49AC
	public bool get_DisableAdvertisingId() { }

	// RVA: 0x13B49B4
	public void set_DisableAdvertisingId(bool value) { }

	// RVA: 0x13B49D0
	public bool get_Valid() { }

	// RVA: 0x13B4A28
	public bool get_Dirty() { }

	// RVA: 0x13B4A30
	public void set_Dirty(bool value) { }

}

// Namespace: TapjoyUnity.Internal
[Serializable]
public class IosPlatformSettings
{
	// Methods

	// RVA: 0x13B4A38
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal
public sealed class ApiBindingIos
{
	// Methods

	// RVA: 0x13B4A78
	public static void Install() { }

	// RVA: 0x13B4BF8
	private void .ctor() { }

	// RVA: 0x13B4CB4
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x13B5368
	private void transferDictionaryToObjectiveCWithName(System.Collections.Generic.Dictionary<System.String,System.Object> dictionary, string dictionaryName) { }

	// RVA: 0x13B59FC
	public override string GetSDKVersion() { }

	// RVA: 0x13B5A64
	public override void SetLoggingLevel(LoggingLevel loggingLevel) { }

	// RVA: 0x13B5A70
	public override LoggingLevel GetLoggingLevel() { }

	// RVA: 0x13B5A78
	public override void GetPrivacyPolicy() { }

	// RVA: 0x13B5A80
	public override void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x13B5A8C
	public override int GetSubjectToGDPR() { }

	// RVA: 0x13B5A94
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x13B5AA0
	public override int GetUserConsent() { }

	// RVA: 0x13B5AA8
	public override void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x13B5AB4
	public override int GetBelowConsentAge() { }

	// RVA: 0x13B5ABC
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13B5B10
	public override string GetUSPrivacy() { }

	// RVA: 0x13B5B78
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x13B5B7C
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x13B5B84
	public override void ActivateUnitySupport() { }

	// RVA: 0x13B5B88
	public override void GetCurrencyBalance() { }

	// RVA: 0x13B5B90
	public override void SpendCurrency(int amount) { }

	// RVA: 0x13B5B9C
	public override void AwardCurrency(int amount) { }

	// RVA: 0x13B5BA8
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x13B5BB0
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x13B5C44
	public override void DismissPlacementContent() { }

	// RVA: 0x13B5C4C
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x13B5CA0
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x13B5CF4
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13B5D68
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x13B5DDC
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x13B5E9C
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x13B5F58
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x13B6018
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x13B60D4
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x13B6128
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x13B617C
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x13B61D0
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13B6254
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x13B6318
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x13B6338
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x13B6358
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x13B63AC
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x13B6530
	public override void SetUserID(string userID) { }

	// RVA: 0x13B6584
	public override string GetUserID() { }

	// RVA: 0x13B65EC
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x13B6640
	public override string GetCustomParameter() { }

	// RVA: 0x13B66A8
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x13B66B4
	public override int GetUserLevel() { }

	// RVA: 0x13B66BC
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x13B66C8
	public override int GetMaxLevel() { }

	// RVA: 0x13B66D0
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x13B66DC
	public override int GetUserSegment() { }

	// RVA: 0x13B66E4
	public override Double GetScreenScale() { }

	// RVA: 0x13B66EC
	public override void ClearUserTags() { }

	// RVA: 0x13B66F4
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x13B6AD4
	public override void AddUserTag(string tag) { }

	// RVA: 0x13B6B28
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x13B6B7C
	public override void TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x13B4C8C
	private static extern void Tapjoy_SetUnityVersion(string version) { }

	// RVA: 0x13B59D4
	private static extern void Tapjoy_Connect(string sdkKey) { }

	// RVA: 0x13B5968
	private static extern void Tapjoy_SetKeyToValueInDictionary(string key, string valueToSet, string dictionaryName) { }

	// RVA: 0x13B58FC
	private static extern void Tapjoy_SetKeyToDictionaryRefValueInDictionary(string key, string dictionaryNameToSet, string dictionaryNameToSetTo) { }

	// RVA: 0x13B5A30
	private static extern string Tapjoy_GetSDKVersion() { }

	// RVA: 0x13B5A6C
	private static extern void Tapjoy_SetLoggingLevel(int loggingLevel) { }

	// RVA: 0x13B5A74
	private static extern int Tapjoy_GetLoggingLevel() { }

	// RVA: 0x13B5A7C
	private static extern void Tapjoy_GetPrivacyPolicy() { }

	// RVA: 0x13B5A88
	private static extern void Tapjoy_SetSubjectToGDPRStatus(int gdprApplicable) { }

	// RVA: 0x13B5A90
	private static extern int Tapjoy_GetSubjectToGDPRStatus() { }

	// RVA: 0x13B5A9C
	private static extern void Tapjoy_SetUserConsentStatus(int consent) { }

	// RVA: 0x13B5AA4
	private static extern int Tapjoy_GetUserConsentStatus() { }

	// RVA: 0x13B5AB0
	private static extern void Tapjoy_SetBelowConsentAgeStatus(int belowConsentAge) { }

	// RVA: 0x13B5AB8
	private static extern int Tapjoy_GetBelowConsentAgeStatus() { }

	// RVA: 0x13B5AE8
	private static extern void Tapjoy_SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13B5B44
	private static extern string Tapjoy_GetUSPrivacy() { }

	// RVA: 0x13B5B8C
	private static extern void Tapjoy_GetCurrencyBalance() { }

	// RVA: 0x13B5B98
	private static extern void Tapjoy_SpendCurrency(int amount) { }

	// RVA: 0x13B5BA4
	private static extern void Tapjoy_AwardCurrency(int amount) { }

	// RVA: 0x13B5BAC
	private static extern void Tapjoy_ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x13B5BFC
	private static extern void Tapjoy_CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x13B5C48
	private static extern void Tapjoy_DismissPlacementContent() { }

	// RVA: 0x13B5C78
	private static extern void Tapjoy_RequestPlacementContent(string placementGuid) { }

	// RVA: 0x13B5CCC
	private static extern void Tapjoy_ShowPlacementContent(string placementGuid) { }

	// RVA: 0x13B5DA4
	private static extern bool Tapjoy_IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x13B5D30
	private static extern bool Tapjoy_IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13B5E38
	private static extern int Tapjoy_SetPlacementBalance(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x13B5EFC
	private static extern int Tapjoy_GetPlacementBalance(string placementGuid, string currencyId) { }

	// RVA: 0x13B5FB4
	private static extern int Tapjoy_SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x13B6078
	private static extern int Tapjoy_GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x13B620C
	private static extern bool Tapjoy_RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13B62B0
	private static extern bool Tapjoy_RequestOfferwallDiscoverAtPosition(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x13B631C
	private static extern bool Tapjoy_ShowOfferwallDiscover() { }

	// RVA: 0x13B633C
	private static extern bool Tapjoy_DestroyOfferwallDiscover() { }

	// RVA: 0x13B6100
	private static extern void Tapjoy_ActionRequestCompleted(string requestId) { }

	// RVA: 0x13B6154
	private static extern void Tapjoy_ActionRequestCancelled(string requestId) { }

	// RVA: 0x13B61A8
	private static extern void Tapjoy_RemovePlacement(string placementGuid) { }

	// RVA: 0x13B6384
	private static extern void Tapjoy_RemoveActionRequest(string requestId) { }

	// RVA: 0x13B64E8
	private static extern void Tapjoy_SetEntryPoint(string placementGuid, string entryPoint) { }

	// RVA: 0x13B655C
	private static extern void Tapjoy_SetUserID(string userId) { }

	// RVA: 0x13B65B8
	private static extern string Tapjoy_GetUserID() { }

	// RVA: 0x13B6618
	private static extern void Tapjoy_SetCustomParameter(string customParam) { }

	// RVA: 0x13B6674
	private static extern string Tapjoy_GetCustomParameter() { }

	// RVA: 0x13B66B0
	private static extern void Tapjoy_SetUserLevel(int userLevel) { }

	// RVA: 0x13B66B8
	private static extern int Tapjoy_GetUserLevel() { }

	// RVA: 0x13B66C4
	private static extern void Tapjoy_SetMaxLevel(int maxLevel) { }

	// RVA: 0x13B66CC
	private static extern int Tapjoy_GetMaxLevel() { }

	// RVA: 0x13B66D8
	private static extern void Tapjoy_SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x13B66E0
	private static extern int Tapjoy_GetUserSegment() { }

	// RVA: 0x13B66E8
	private static extern Double Tapjoy_GetScreenScale() { }

	// RVA: 0x13B66F0
	private static extern void Tapjoy_ClearUserTags() { }

	// RVA: 0x13B68E0
	private static extern string Tapjoy_GetUserTags() { }

	// RVA: 0x13B6B00
	private static extern void Tapjoy_AddUserTag(string tag) { }

	// RVA: 0x13B6B54
	private static extern void Tapjoy_RemoveUserTag(string tag) { }

	// RVA: 0x13B6BB8
	private static extern void Tapjoy_TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x13B6BF0
	private static string GetStringFromNativeUtf8(IntPtr nativeUtf8) { }

}

// Namespace: 
private enum InternalEventType
{
	// Fields
	public int value__; // 0x10
	public const InternalEventType RemovePlacement = 0;
	public const InternalEventType RemoveActionRequest = 1;
}

// Namespace: 
private struct InternalEvent
{
	// Fields
	public InternalEventType type; // 0x10
	public string data; // 0x18

	// Methods

	// RVA: 0x13B8340
	public void .ctor(InternalEventType _type, string _data) { }

}

// Namespace: TapjoyUnity.Internal
public class TapjoyComponent
{
	// Fields
	private const string GAME_OBJECT_NAME = "TapjoyUnity";
	private const string DISABLE_ADVERTISING_ID_CHECK = "TJC_OPTION_DISABLE_ADVERTISING_ID_CHECK";
	private static bool applicationPaused; // 0x0
	private static bool isConnecting; // 0x1
	private static bool triedConnecting; // 0x2
	private static PlatformSettings app; // 0x8
	private static GameObject singletonGameObject; // 0x10
	private System.Collections.Generic.Dictionary<System.String,System.Object> lastConnectFlags; // 0x20
	private static Queue events; // 0x18
	public TapjoySettings settings; // 0x28

	// Methods

	// RVA: 0x13AAF0C
	public static TapjoyComponent FindInstance() { }

	// RVA: 0x13B6D10
	private void Awake() { }

	// RVA: 0x13B72B0
	private void OnApiBindingSet() { }

	// RVA: 0x13B7068
	private void EnsureSingleton() { }

	// RVA: 0x13AAFB0
	internal void Reconnect() { }

	// RVA: 0x13B72EC
	internal bool ConnectManually() { }

	// RVA: 0x13AB310
	internal bool ConnectManually(string sdkKey) { }

	// RVA: 0x13AB4E0
	internal bool ConnectManually(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x13B7380
	private bool ConnectInternal(System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x13B79EC
	private void OnDestroy() { }

	// RVA: 0x13B7C6C
	private void HandleOnConnectSuccess() { }

	// RVA: 0x13B7CE8
	private void HandleOnConnectFailed(int code, string message) { }

	// RVA: 0x13B7D64
	private void HandleOnConnectWarning(int code, string message) { }

	// RVA: 0x13B7D68
	private void Start() { }

	// RVA: 0x13B7E68
	private void Update() { }

	// RVA: 0x13B8064
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x13B81EC
	private void OnApplicationQuit() { }

	// RVA: 0x13B82A0
	private void OnNativeConnectCallback(string commaDelimitedMessage) { }

	// RVA: 0x13B82A8
	private void OnNativeSetUserIDCallback(string commaDelimitedMessage) { }

	// RVA: 0x13B82B0
	private void OnNativeCurrencyCallback(string commaDelimitedMessage) { }

	// RVA: 0x13B82B8
	private void OnNativePlacementCallback(string commaDelimitedMessage) { }

	// RVA: 0x13B8338
	private void OnNativeOfferwallDiscoverCallback(string commaDelimitedMessage) { }

	// RVA: 0x13B0710
	public static void RemovePlacement(string placementID) { }

	// RVA: 0x13AF514
	public static void RemoveActionRequest(string requestID) { }

	// RVA: 0x13B8350
	public void .ctor() { }

	// RVA: 0x13B8358
	private static void .cctor() { }

}

// Namespace: TapjoyUnity.Internal
public class TapjoySettings
{
	// Fields
	private PlatformSettings androidSettings; // 0x18
	private IosPlatformSettings iosSettings; // 0x20
	private bool autoConnectEnabled; // 0x28
	private LoggingLevel loggingLevel; // 0x2C
	private bool dirty; // 0x30

	// Methods

	// RVA: 0x13B83F8
	public PlatformSettings get_AndroidSettings() { }

	// RVA: 0x13B8400
	public IosPlatformSettings get_IosSettings() { }

	// RVA: 0x13B8408
	public bool get_AutoConnectEnabled() { }

	// RVA: 0x13B8410
	public void set_AutoConnectEnabled(bool value) { }

	// RVA: 0x13B842C
	public LoggingLevel get_LoggingLevel() { }

	// RVA: 0x13B8434
	public void set_LoggingLevel(LoggingLevel value) { }

	// RVA: 0x13B8450
	public bool get_Dirty() { }

	// RVA: 0x13B84A8
	public void set_Dirty(bool value) { }

	// RVA: 0x13B84D8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly TapjoyUnity.Internal.TapjoyUnityInit.<>c <>9; // 0x0
	public static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> <>9__1_0; // 0x8
	public static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> <>9__1_1; // 0x10
	public static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> <>9__1_2; // 0x18
	public static TapjoyUnity.TapjoyFunc<System.Int32> <>9__1_3; // 0x20
	public static TapjoyUnity.TapjoyFunc<TapjoyUnity.Internal.UnityCompat.SceneCompat> <>9__1_4; // 0x28
	public static TapjoyUnity.TapjoyFunc<System.Int32,TapjoyUnity.Internal.UnityCompat.SceneCompat> <>9__1_5; // 0x30

	// Methods

	// RVA: 0x13B8DBC
	private static void .cctor() { }

	// RVA: 0x13B8E28
	public void .ctor() { }

	// RVA: 0x13B8E30
	internal void <Awake>b__1_0(Scene oldScene, Scene newScene) { }

	// RVA: 0x13B8EDC
	internal void <Awake>b__1_1(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x13B8F78
	internal void <Awake>b__1_2(Scene scene) { }

	// RVA: 0x13B9000
	internal int <Awake>b__1_3() { }

	// RVA: 0x13B9070
	internal SceneCompat <Awake>b__1_4() { }

	// RVA: 0x13B90F0
	internal SceneCompat <Awake>b__1_5(int index) { }

}

// Namespace: TapjoyUnity.Internal
public sealed class TapjoyUnityInit
{
	// Fields
	private static bool initialized; // 0x0

	// Methods

	// RVA: 0x13B85C8
	private void Awake() { }

	// RVA: 0x13B8B8C
	private static SceneCompat Wrap(Scene scene) { }

	// RVA: 0x13B8DB4
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public enum JSONNodeType
{
	// Fields
	public int value__; // 0x10
	public const JSONNodeType Array = 1;
	public const JSONNodeType Object = 2;
	public const JSONNodeType String = 3;
	public const JSONNodeType Number = 4;
	public const JSONNodeType NullValue = 5;
	public const JSONNodeType Boolean = 6;
	public const JSONNodeType None = 7;
}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public enum JSONTextMode
{
	// Fields
	public int value__; // 0x10
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;
}

// Namespace: 
private sealed class <get_Children>d__29
{
	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20

	// Methods

	// RVA: 0x13B9300
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BC610
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BC614
	private bool MoveNext() { }

	// RVA: 0x13BC634
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13BC63C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BC67C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13BC684
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13BC724
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <get_DeepChildren>d__31
{
	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONNode <>4__this; // 0x28
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> <>7__wrap1; // 0x30
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> <>7__wrap2; // 0x38

	// Methods

	// RVA: 0x13B93C0
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BC7C4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BC9B4
	private bool MoveNext() { }

	// RVA: 0x13BD050
	private void <>m__Finally1() { }

	// RVA: 0x13BCF8C
	private void <>m__Finally2() { }

	// RVA: 0x13BD114
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13BD11C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BD15C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13BD164
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13BD218
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public abstract class JSONNode
{
	// Fields
	internal static StringBuilder m_EscapeBuilder; // 0x0

	// Methods

	// RVA: 0x13B9178
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x13B9180
	public virtual void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x13B9184
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x13B918C
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13B9190
	public virtual string get_Value() { }

	// RVA: 0x13B91D4
	public virtual void set_Value(string value) { }

	// RVA: 0x13B91D8
	public virtual int get_Count() { }

	// RVA: 0x13B91E0
	public virtual bool get_IsNumber() { }

	// RVA: 0x13B91E8
	public virtual bool get_IsString() { }

	// RVA: 0x13B91F0
	public virtual bool get_IsBoolean() { }

	// RVA: 0x13B91F8
	public virtual bool get_IsNull() { }

	// RVA: 0x13B9200
	public virtual bool get_IsArray() { }

	// RVA: 0x13B9208
	public virtual bool get_IsObject() { }

	// RVA: 0x13B9210
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13B9214
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x13B927C
	public virtual JSONNode Remove(string aKey) { }

	// RVA: 0x13B9284
	public virtual JSONNode Remove(int aIndex) { }

	// RVA: 0x13B928C
	public virtual JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x13B9294
	public virtual System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x13B9338
	public System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_DeepChildren() { }

	// RVA: 0x13B93F8
	public override string ToString() { }

	// RVA: 0x13B9490
	public virtual string ToString(int aIndent) { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract JSONNodeType get_Tag() { }

	// RVA: 0x13B952C
	public virtual Double get_AsDouble() { }

	// RVA: 0x13B9570
	public virtual void set_AsDouble(Double value) { }

	// RVA: 0x13B95B8
	public virtual int get_AsInt() { }

	// RVA: 0x13B95F0
	public virtual void set_AsInt(int value) { }

	// RVA: 0x13B9604
	public virtual float get_AsFloat() { }

	// RVA: 0x13B9628
	public virtual void set_AsFloat(float value) { }

	// RVA: 0x13B963C
	public virtual bool get_AsBool() { }

	// RVA: 0x13B96EC
	public virtual void set_AsBool(bool value) { }

	// RVA: 0x13B9770
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x13B97F4
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13B9878
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x13B6994
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x13B9B20
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x13B9C44
	public static Double op_Implicit(JSONNode d) { }

	// RVA: 0x13B9D88
	public static JSONNode op_Implicit(float n) { }

	// RVA: 0x13B9E38
	public static float op_Implicit(JSONNode d) { }

	// RVA: 0x13B9F7C
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x13BA02C
	public static int op_Implicit(JSONNode d) { }

	// RVA: 0x13BA170
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x13BA284
	public static bool op_Implicit(JSONNode d) { }

	// RVA: 0x13B99A0
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x13BA3C8
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x13BA438
	public override bool Equals(object obj) { }

	// RVA: 0x13BA444
	public override int GetHashCode() { }

	// RVA: 0x13BA44C
	internal static string Escape(string aText) { }

	// RVA: 0x13BA830
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	// RVA: 0x13BAD34
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x13BB608
	public virtual void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13BB60C
	public void SaveToStream(Stream aData) { }

	// RVA: 0x13BB688
	public void SaveToCompressedStream(Stream aData) { }

	// RVA: 0x13BB6DC
	public void SaveToCompressedFile(string aFileName) { }

	// RVA: 0x13BB730
	public string SaveToCompressedBase64() { }

	// RVA: 0x13BB784
	public void SaveToFile(string aFileName) { }

	// RVA: 0x13BB964
	public string SaveToBase64() { }

	// RVA: 0x13BBB94
	public static JSONNode Deserialize(BinaryReader aReader) { }

	// RVA: 0x13BC0A4
	public static JSONNode LoadFromCompressedFile(string aFileName) { }

	// RVA: 0x13BC0F8
	public static JSONNode LoadFromCompressedStream(Stream aData) { }

	// RVA: 0x13BC14C
	public static JSONNode LoadFromCompressedBase64(string aBase64) { }

	// RVA: 0x13BC1A0
	public static JSONNode LoadFromStream(Stream aData) { }

	// RVA: 0x13BC324
	public static JSONNode LoadFromFile(string aFileName) { }

	// RVA: 0x13BC48C
	public static JSONNode LoadFromBase64(string aBase64) { }

	// RVA: 0x13BC580
	protected void .ctor() { }

	// RVA: 0x13BC588
	private static void .cctor() { }

}

// Namespace: 
private sealed class <GetEnumerator>d__19
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public JSONArray <>4__this; // 0x20
	private Enumerator <>7__wrap1; // 0x28

	// Methods

	// RVA: 0x13BDCE8
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BE09C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BE118
	private bool MoveNext() { }

	// RVA: 0x13BE388
	private void <>m__Finally1() { }

	// RVA: 0x13BE3E4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x13BE3EC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BE42C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private sealed class <get_Children>d__18
{
	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONArray <>4__this; // 0x28
	private Enumerator <>7__wrap1; // 0x30

	// Methods

	// RVA: 0x13BDC38
	public void .ctor(int <>1__state) { }

	// RVA: 0x13BE434
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13BE4B0
	private bool MoveNext() { }

	// RVA: 0x13BE720
	private void <>m__Finally1() { }

	// RVA: 0x13BE77C
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13BE784
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13BE7C4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13BE7CC
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13BE880
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<TapjoyUnity.Internal.SimpleJSON.JSONNode> m_List; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x13BD21C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13BD224
	public override bool get_IsArray() { }

	// RVA: 0x13BD22C
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13BD3E8
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x13BD5F4
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13BD6B4
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13BD868
	public override int get_Count() { }

	// RVA: 0x13BD8B4
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13BDA68
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x13BDB44
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x13BDBB0
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x13BDC70
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13BDD14
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13BDE04
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13BB550
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public JSONNode aNode; // 0x10

	// Methods

	// RVA: 0x13BF904
	public void .ctor() { }

	// RVA: 0x13C0210
	internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> k) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__20
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public JSONObject <>4__this; // 0x20
	private Enumerator <>7__wrap1; // 0x28

	// Methods

	// RVA: 0x13BFA44
	public void .ctor(int <>1__state) { }

	// RVA: 0x13C0324
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C03A0
	private bool MoveNext() { }

	// RVA: 0x13C0648
	private void <>m__Finally1() { }

	// RVA: 0x13C06A4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x13C06AC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13C06EC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private sealed class <get_Children>d__19
{
	// Fields
	private int <>1__state; // 0x10
	private JSONNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public JSONObject <>4__this; // 0x28
	private Enumerator <>7__wrap1; // 0x30

	// Methods

	// RVA: 0x13BF994
	public void .ctor(int <>1__state) { }

	// RVA: 0x13C06F4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13C0770
	private bool MoveNext() { }

	// RVA: 0x13C0A84
	private void <>m__Finally1() { }

	// RVA: 0x13C0AE0
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13C0AE8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13C0B28
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x13C0B30
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13C0BE4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> m_Dict; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x13BE884
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13BE88C
	public override bool get_IsObject() { }

	// RVA: 0x13BE894
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13BEA60
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13BEC84
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13BEDD8
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x13BF094
	public override int get_Count() { }

	// RVA: 0x13BF0E8
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13BF384
	public override JSONNode Remove(string aKey) { }

	// RVA: 0x13BF470
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x13BF67C
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x13BF90C
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x13BF9CC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13BFA70
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13BFD30
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13BB498
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x13C0BE8
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13C0BF0
	public override bool get_IsString() { }

	// RVA: 0x13C0BF8
	public override string get_Value() { }

	// RVA: 0x13C0C00
	public override void set_Value(string value) { }

	// RVA: 0x13B9928
	public void .ctor(string aData) { }

	// RVA: 0x13C0C08
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13C0C58
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C0D00
	public override bool Equals(object obj) { }

	// RVA: 0x13C0F28
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x13C0F4C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13C0F54
	public override bool get_IsNumber() { }

	// RVA: 0x13C0F5C
	public override string get_Value() { }

	// RVA: 0x13C0F68
	public override void set_Value(string value) { }

	// RVA: 0x13C0FB0
	public override Double get_AsDouble() { }

	// RVA: 0x13C0FB8
	public override void set_AsDouble(Double value) { }

	// RVA: 0x13B9BCC
	public void .ctor(Double aData) { }

	// RVA: 0x13C0FC0
	public void .ctor(string aData) { }

	// RVA: 0x13C103C
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13C108C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C10B0
	private static bool IsNumeric(object value) { }

	// RVA: 0x13C119C
	public override bool Equals(object obj) { }

	// RVA: 0x13C14A0
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x13C14C0
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13C14C8
	public override bool get_IsBoolean() { }

	// RVA: 0x13C14D0
	public override string get_Value() { }

	// RVA: 0x13C1520
	public override void set_Value(string value) { }

	// RVA: 0x13C15A4
	public override bool get_AsBool() { }

	// RVA: 0x13C15AC
	public override void set_AsBool(bool value) { }

	// RVA: 0x13BA214
	public void .ctor(bool aData) { }

	// RVA: 0x13C15B4
	public void .ctor(string aData) { }

	// RVA: 0x13C1630
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13C167C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13C1700
	public override bool Equals(object obj) { }

	// RVA: 0x13C1764
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNull
{
	// Methods

	// RVA: 0x13C17B4
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13C17BC
	public override bool get_IsNull() { }

	// RVA: 0x13C17C4
	public override string get_Value() { }

	// RVA: 0x13C1808
	public override void set_Value(string value) { }

	// RVA: 0x13C180C
	public override bool get_AsBool() { }

	// RVA: 0x13C1814
	public override void set_AsBool(bool value) { }

	// RVA: 0x13C1818
	public override bool Equals(object obj) { }

	// RVA: 0x13C18C8
	public override int GetHashCode() { }

	// RVA: 0x13C18D0
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13C18F8
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13BC01C
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x13C1950
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13BD360
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x13BE9CC
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x13C1958
	private void Set(JSONNode aVal) { }

	// RVA: 0x13C19D8
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13C1A98
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x13C1B60
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13C1C2C
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13C1D04
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13C1DCC
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13C1EA4
	public static bool op_Equality(JSONLazyCreator a, object b) { }

	// RVA: 0x13C1EB4
	public static bool op_Inequality(JSONLazyCreator a, object b) { }

	// RVA: 0x13C1EC4
	public override bool Equals(object obj) { }

	// RVA: 0x13C1ED4
	public override int GetHashCode() { }

	// RVA: 0x13C1EDC
	public override int get_AsInt() { }

	// RVA: 0x13C1FF4
	public override void set_AsInt(int value) { }

	// RVA: 0x13C2120
	public override float get_AsFloat() { }

	// RVA: 0x13C2238
	public override void set_AsFloat(float value) { }

	// RVA: 0x13C235C
	public override Double get_AsDouble() { }

	// RVA: 0x13C2474
	public override void set_AsDouble(Double value) { }

	// RVA: 0x13C2590
	public override bool get_AsBool() { }

	// RVA: 0x13C26A8
	public override void set_AsBool(bool value) { }

	// RVA: 0x13C27C4
	public override JSONArray get_AsArray() { }

	// RVA: 0x13C2874
	public override JSONObject get_AsObject() { }

	// RVA: 0x13C2924
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x13B6914
	public static JSONNode Parse(string aJSON) { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
public class JsonUtilityCompat
{
	// Methods

	// RVA: 0x13C297C
	internal static string ToJson(object obj) { }

	// RVA: 0x13C2A28
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
internal enum LoadSceneModeCompat
{
	// Fields
	public int value__; // 0x10
	public const LoadSceneModeCompat Init = 4294967295;
	public const LoadSceneModeCompat Single = 0;
	public const LoadSceneModeCompat Additive = 1;
}

// Namespace: TapjoyUnity.Internal.UnityCompat
public struct SceneCompat
{
	// Fields
	internal static readonly SceneCompat NONE; // 0x0
	private readonly int _hashCode; // 0x10
	private readonly bool _valid; // 0x14
	private readonly System.Nullable<System.Int32> _buildIndex; // 0x18
	private readonly string _name; // 0x20
	private readonly string _path; // 0x28

	// Methods

	// RVA: 0x13B8CDC
	public void .ctor(object scene, bool valid, int buildIndex, string name, string path) { }

	// RVA: 0x13C2A30
	public override int GetHashCode() { }

	// RVA: 0x13C2A38
	internal bool IsValid() { }

	// RVA: 0x13C2A40
	internal int get_buildIndex() { }

	// RVA: 0x13C2B78
	internal string get_name() { }

	// RVA: 0x13C2B80
	internal string get_path() { }

	// RVA: 0x13C2B88
	private static void .cctor() { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
internal class SceneManagerCompat
{
	// Fields
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat,TapjoyUnity.Internal.UnityCompat.SceneCompat> activeSceneChanged; // 0x0
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat,System.Int32> sceneLoaded; // 0x8
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat> sceneUnloaded; // 0x10

	// Methods

	// RVA: 0x13C2B8C
	internal static int get_sceneCount() { }

	// RVA: 0x13C2C10
	internal static SceneCompat GetActiveScene() { }

	// RVA: 0x13C2CD8
	internal static SceneCompat GetSceneAt(int index) { }

	// RVA: 0x13C2DB0
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=1075
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1221
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=1221 66F789A128FC54CF4A39E951EDEAF61B7811C02E9CB781E6F4A6F171967CEAEF; // 0x0
	internal static readonly __StaticArrayInitTypeSize=1075 B74232A3E1CAFFF740537ECBE9173A7D721034642DE10F8C586A4FFCBC6B1BB5; // 0x4C5

	// Methods

	// RVA: 0x13AE304
	internal static UInt32 ComputeStringHash(string s) { }

}


