// Namespace: 
internal class <Module>
{}

// Namespace: 
public static class EntryPointExtensions
{
	// Fields
	public static readonly System.Collections.Generic.Dictionary<TapjoyUnity.TJEntryPoint,System.String> entryPointValues; // 0x0

	// Methods

	// RVA: 0x137A018
	public static string GetValue(TJEntryPoint entryPoint) { }

	// RVA: 0x137A0D4
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

	// RVA: 0x137A38C
	private static MonoScriptData Get() { }

	// RVA: 0x137A490
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction
{
	// Methods

	// RVA: 0x137A498
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137A538
	public virtual void Invoke() { }

	// RVA: 0x137A54C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x137A5A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1, T2 arg2) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3, T4>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual TResult Invoke() { }

	// RVA: 0x30D3E84
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x318DB98
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual TResult Invoke(T1 arg1) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x318DB98
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectSuccessHandler
{
	// Methods

	// RVA: 0x137DCAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137DD4C
	public virtual void Invoke() { }

	// RVA: 0x137DD60
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x137DDB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectFailedHandler
{
	// Methods

	// RVA: 0x137DDC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137DE68
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x137DE7C
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x137DF3C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectWarningHandler
{
	// Methods

	// RVA: 0x137DF48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137DFEC
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x137E000
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x137E0C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDSuccessHandler
{
	// Methods

	// RVA: 0x137E0CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E16C
	public virtual void Invoke() { }

	// RVA: 0x137E180
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x137E1D8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailedHandler
{
	// Methods

	// RVA: 0x137E1E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E288
	public virtual void Invoke(int code, string errorMessage) { }

	// RVA: 0x137E29C
	public virtual IAsyncResult BeginInvoke(int code, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x137E35C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailureHandler
{
	// Methods

	// RVA: 0x137E368
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E41C
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x137E430
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x137E480
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseHandler
{
	// Methods

	// RVA: 0x137E48C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E548
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x137E55C
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x137E620
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseFailureHandler
{
	// Methods

	// RVA: 0x137E62C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E6E0
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x137E6F4
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x137E744
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseHandler
{
	// Methods

	// RVA: 0x137E750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E80C
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x137E820
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x137E8E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x137E8F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137E9A4
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x137E9B8
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x137EA08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseHandler
{
	// Methods

	// RVA: 0x137EA14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137EAD0
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x137EAE4
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x137EBA8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x137EBB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137EC68
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x137EC7C
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x137ECCC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnEarnedCurrencyHandler
{
	// Methods

	// RVA: 0x137ECD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137ED94
	public virtual void Invoke(string currencyName, int amount) { }

	// RVA: 0x137EDA8
	public virtual IAsyncResult BeginInvoke(string currencyName, int amount, AsyncCallback callback, object object) { }

	// RVA: 0x137EE6C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public class Tapjoy
{
	// Fields
	internal const string VERSION_NAME = "14.3.1";
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

	// RVA: 0x137A5B0
	public static string get_Version() { }

	// RVA: 0x137A648
	public static bool get_IsConnected() { }

	// RVA: 0x137A694
	public static void set_IsConnected(bool value) { }

	// RVA: 0x137A6EC
	public static void Connect() { }

	// RVA: 0x137AAE4
	public static void Connect(string sdkKey) { }

	// RVA: 0x137ACA4
	public static void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x137AFC8
	public static void SetDebugEnabled(bool enable) { }

	// RVA: 0x137B104
	public static void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x137B13C
	public static bool GetOptOutAdvertisingID() { }

	// RVA: 0x137B164
	public static void ActionComplete(string actionID) { }

	// RVA: 0x137B168
	public static void SetUserID(string userId) { }

	// RVA: 0x137B1A0
	public static string GetUserID() { }

	// RVA: 0x137B1C8
	public static void SetCustomParameter(string customParam) { }

	// RVA: 0x137B200
	public static string GetCustomParameter() { }

	// RVA: 0x137B228
	public static void SetUserLevel(int userLevel) { }

	// RVA: 0x137B260
	public static int GetUserLevel() { }

	// RVA: 0x137B288
	public static void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x137B2C0
	public static int GetMaxLevel() { }

	// RVA: 0x137B2E8
	public static void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x137B320
	public static TJSegment GetUserSegment() { }

	// RVA: 0x137B348
	public static Double GetScreenScale() { }

	// RVA: 0x137B370
	public static void ClearUserTags() { }

	// RVA: 0x137B398
	public static System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x137B3C0
	public static void AddUserTag(string tag) { }

	// RVA: 0x137B3F8
	public static void RemoveUserTag(string tag) { }

	// RVA: 0x137B430
	public static void TrackPurchase(string currencyCode, Double productPrice) { }

	// RVA: 0x137B478
	public static void TrackPurchase(string productId, string currencyCode, Double productPrice, string campaignId) { }

	// RVA: 0x137B4C0
	public static void TrackPurchaseInGooglePlayStore(string skuDetails, string purchaseData, string dataSignature, string campaignId) { }

	// RVA: 0x137B4C4
	public static void TrackPurchaseInAppleAppStore(string productId, string currencyCode, Double productPrice, string transactionId, string campaignId) { }

	// RVA: 0x137B50C
	public static void AwardCurrency(int amount) { }

	// RVA: 0x137B544
	public static void GetCurrencyBalance() { }

	// RVA: 0x137B56C
	public static void SpendCurrency(int amount) { }

	// RVA: 0x137B5A4
	public static string GetSupportURL() { }

	// RVA: 0x137B5E8
	public static string GetSupportURL(string currencyID) { }

	// RVA: 0x137B62C
	public static void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x137B654
	public static void add_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x137B728
	public static void remove_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x137B7FC
	internal static void add_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x137B8D0
	internal static void remove_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x137B9A4
	public static void add_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x137BA78
	public static void remove_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x137BB4C
	internal static void add_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x137BC20
	internal static void remove_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x137BCF4
	public static void add_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x137BDC8
	public static void remove_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x137BE9C
	internal static void add_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x137BF70
	internal static void remove_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x137C044
	internal static void DispatchConnectEvent(string connectCallbackMethod) { }

	// RVA: 0x137C3E4
	public static void add_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x137C4B8
	public static void remove_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x137C58C
	public static void add_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x137C660
	public static void remove_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x137C734
	public static void add_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x137C808
	public static void remove_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x137C8DC
	internal static void DispatchSetUserIDEvent(string commaDelimitedMessage) { }

	// RVA: 0x137CB3C
	public static void add_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x137CC10
	public static void remove_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x137CCE4
	public static void add_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x137CDB8
	public static void remove_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x137CE8C
	public static void add_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x137CF60
	public static void remove_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x137D034
	public static void add_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x137D108
	public static void remove_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x137D1DC
	public static void add_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x137D2B0
	public static void remove_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x137D384
	public static void add_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x137D458
	public static void remove_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x137D52C
	public static void add_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x137D600
	public static void remove_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x137D6D4
	internal static void DispatchCurrencyEvent(string commaDelimitedMessage) { }

	// RVA: 0x137DCA4
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJActionRequest
{
	// Fields
	public string requestID; // 0x10
	public string token; // 0x18

	// Methods

	// RVA: 0x137EE78
	protected override void Finalize() { }

	// RVA: 0x137F024
	internal void .ctor(string requestID, string token) { }

	// RVA: 0x137F074
	public void Completed() { }

	// RVA: 0x137F0AC
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

	// RVA: 0x137FA50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137FAF0
	public virtual void Invoke() { }

	// RVA: 0x137FB04
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x137FB5C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x137FB68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137FC0C
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x137FC20
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x137FCE0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x137FCEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137FD8C
	public virtual void Invoke() { }

	// RVA: 0x137FDA0
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x137FDF8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentErrorHandler
{
	// Methods

	// RVA: 0x137FE04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x137FEA8
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x137FEBC
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x137FF7C
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

	// RVA: 0x137F0E4
	public void .ctor() { }

	// RVA: 0x137F0EC
	public static void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x137F134
	public static void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x137F19C
	public static void ShowOfferwallDiscover() { }

	// RVA: 0x137F1C4
	public static void DestroyOfferwallDiscover() { }

	// RVA: 0x137F1EC
	internal static void DispatchOfferwallDiscoverEvent(string commaDelimitedMessage) { }

	// RVA: 0x137F3C0
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x137F48C
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x137F558
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x137F62C
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x137F700
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x137F7D4
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x137F8A8
	public static void add_OnContentError(OnContentErrorHandler value) { }

	// RVA: 0x137F97C
	public static void remove_OnContentError(OnContentErrorHandler value) { }

}

// Namespace: 
public sealed class OnRequestSuccessHandler
{
	// Methods

	// RVA: 0x13825A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13826C8
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13826DC
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x138272C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x1382738
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x138285C
	public virtual void Invoke(TJPlacement placement, string error) { }

	// RVA: 0x1382870
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, string error, AsyncCallback callback, object object) { }

	// RVA: 0x13828CC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x13828D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13829F8
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1382A0C
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1382A5C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentShowHandler
{
	// Methods

	// RVA: 0x1382A68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1382B88
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1382B9C
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1382BEC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentDismissHandler
{
	// Methods

	// RVA: 0x1382BF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1382D18
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1382D2C
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1382D7C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnClickHandler
{
	// Methods

	// RVA: 0x1382D88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1382EA8
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1382EBC
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1382F0C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnPurchaseRequestHandler
{
	// Methods

	// RVA: 0x1382F18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x138303C
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string productId) { }

	// RVA: 0x1383050
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string productId, AsyncCallback callback, object object) { }

	// RVA: 0x13830AC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRewardRequestHandler
{
	// Methods

	// RVA: 0x13830B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13831DC
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity) { }

	// RVA: 0x13831F0
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity, AsyncCallback callback, object object) { }

	// RVA: 0x13832C8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceSuccessHandler
{
	// Methods

	// RVA: 0x13832D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13833F4
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1383408
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1383458
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceFailureHandler
{
	// Methods

	// RVA: 0x1383464
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1383588
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x138359C
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x138366C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredSuccessHandler
{
	// Methods

	// RVA: 0x1383678
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1383798
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13837AC
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13837FC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredFailureHandler
{
	// Methods

	// RVA: 0x1383808
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x138392C
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x1383940
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1383A10
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

	// RVA: 0x137FF88
	private void .ctor(string placementName) { }

	// RVA: 0x13800C4
	protected override void Finalize() { }

	// RVA: 0x1380268
	public static TJPlacement CreatePlacement(string placementName) { }

	// RVA: 0x13802CC
	public static void DismissContent() { }

	// RVA: 0x13802F4
	public void RequestContent() { }

	// RVA: 0x13803E8
	public void ShowContent() { }

	// RVA: 0x13804BC
	public bool IsContentAvailable() { }

	// RVA: 0x13804F4
	public bool IsContentReady() { }

	// RVA: 0x138052C
	public string GetName() { }

	// RVA: 0x1380534
	public void SetEntryPoint(TJEntryPoint entryPoint) { }

	// RVA: 0x1380574
	public void SetCurrencyBalance(string currencyId, int balance) { }

	// RVA: 0x13805C4
	public int GetCurrencyBalance(string currencyId) { }

	// RVA: 0x1380604
	public void SetRequiredAmount(string currencyId, int amount) { }

	// RVA: 0x1380654
	public int GetRequiredAmount(string currencyId) { }

	// RVA: 0x1380694
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1380778
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x138085C
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1380940
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1380A24
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1380B08
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1380BEC
	public static void add_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1380CD0
	public static void remove_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1380DB4
	public static void add_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1380E98
	public static void remove_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1380F7C
	public static void add_OnClick(OnClickHandler value) { }

	// RVA: 0x1381060
	public static void remove_OnClick(OnClickHandler value) { }

	// RVA: 0x1381144
	public static void add_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x1381228
	public static void remove_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x138130C
	public static void add_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x13813F0
	public static void remove_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x13814D4
	public static void add_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x13815B8
	public static void remove_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x138169C
	public static void add_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1381780
	public static void remove_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1381864
	public static void add_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x1381948
	public static void remove_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x1381A2C
	public static void add_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x1381B10
	public static void remove_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x1381BF4
	internal static void DispatchPlacementEvent(string commaDelimitedMessage) { }

	// RVA: 0x138250C
	private static void .cctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJPrivacyPolicy
{
	// Methods

	// RVA: 0x1383A1C
	private void .ctor() { }

	// RVA: 0x1383A48
	public static TJPrivacyPolicy GetPrivacyPolicy() { }

	// RVA: 0x1383AB8
	public void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x1383AEC
	public TJStatus GetSubjectToGDPR() { }

	// RVA: 0x1383B10
	public void SetUserConsent(TJStatus consent) { }

	// RVA: 0x1383B44
	public TJStatus GetUserConsent() { }

	// RVA: 0x1383B68
	public void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x1383BA0
	public TJStatus GetBelowConsentAge() { }

	// RVA: 0x1383BC8
	public void SetUSPrivacy(string privacyPolicy) { }

	// RVA: 0x1383C00
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

	// RVA: 0x1383E78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1383F18
	public virtual void Invoke() { }

	// RVA: 0x1383F2C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1383F84
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity.Internal
public abstract class ApiBinding
{
	// Fields
	protected const string DEFAULT_EVENT_VALUE_NAME = "value";
	protected const string VERSION_NAME = "14.3.1";
	protected const string CONNECT_FLAG_DICTIONARY_NAME = "connectFlags";
	private static ApiBinding instance; // 0x0
	private static OnInstanceSetHandler onInstanceSetHandler; // 0x8
	private string name; // 0x10

	// Methods

	// RVA: 0x137AFFC
	public static ApiBinding get_Instance() { }

	// RVA: 0x1383C90
	protected static void SetInstance(ApiBinding value) { }

	// RVA: 0x1383D6C
	internal static void set_OnInstanceSet(OnInstanceSetHandler value) { }

	// RVA: 0x1383E3C
	protected void .ctor(string name) { }

	// RVA: 0x1383E70
	internal string get_Name() { }

	// RVA: -1
	public abstract void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: -1
	public abstract string GetSDKVersion() { }

	// RVA: -1
	public abstract void SetDebugEnabled(bool enabled) { }

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

	// RVA: 0x1383C28
	public void .ctor() { }

	// RVA: 0x1383F90
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x1383F94
	public override string GetSDKVersion() { }

	// RVA: 0x1383FD8
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x1383FDC
	public override void ActivateUnitySupport() { }

	// RVA: 0x1383FE0
	public override void GetPrivacyPolicy() { }

	// RVA: 0x1383FE4
	public override void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x1383FE8
	public override int GetSubjectToGDPR() { }

	// RVA: 0x1383FF0
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x1383FF4
	public override int GetUserConsent() { }

	// RVA: 0x1383FFC
	public override void SetBelowConsentAge(TJStatus isBelowConsentAge) { }

	// RVA: 0x1384000
	public override int GetBelowConsentAge() { }

	// RVA: 0x1384008
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x138400C
	public override string GetUSPrivacy() { }

	// RVA: 0x1384050
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x1384054
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x138405C
	public override void GetCurrencyBalance() { }

	// RVA: 0x1384060
	public override void SpendCurrency(int amount) { }

	// RVA: 0x1384064
	public override void AwardCurrency(int amount) { }

	// RVA: 0x1384068
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x138406C
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x1384070
	public override void DismissPlacementContent() { }

	// RVA: 0x1384074
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x1384078
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x138407C
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x1384084
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x138408C
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x1384090
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1384098
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x138409C
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x13840A4
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x13840A8
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x13840AC
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x13840B0
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13840B4
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x13840B8
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x13840BC
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x13840C0
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x13840C4
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x13840C8
	public override void SetUserID(string userId) { }

	// RVA: 0x13840CC
	public override string GetUserID() { }

	// RVA: 0x1384110
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x1384114
	public override string GetCustomParameter() { }

	// RVA: 0x1384158
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x138415C
	public override int GetUserLevel() { }

	// RVA: 0x1384164
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x1384168
	public override int GetMaxLevel() { }

	// RVA: 0x1384170
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1384174
	public override int GetUserSegment() { }

	// RVA: 0x138417C
	public override Double GetScreenScale() { }

	// RVA: 0x1384184
	public override void ClearUserTags() { }

	// RVA: 0x1384188
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1384190
	public override void AddUserTag(string tag) { }

	// RVA: 0x1384194
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x1384198
	public override void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal static class ForegroundRealtimeClock
{
	// Fields
	private static float realtimeSpentWhilePaused; // 0x0
	private static float realtimePaused; // 0x4

	// Methods

	// RVA: 0x138419C
	internal static void OnApplicationPause(bool paused) { }

	// RVA: 0x1384240
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

	// RVA: 0x1384298
	public static void OnActiveSceneChanged(SceneCompat oldScene, SceneCompat newScene) { }

	// RVA: 0x1384328
	public static void OnSceneLoaded(SceneCompat scene, int loadMode) { }

	// RVA: 0x13843B4
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

	// RVA: 0x1384434
	public void .ctor() { }

	// RVA: 0x13844A0
	public string get_SdkKey() { }

	// RVA: 0x13844A8
	public void set_SdkKey(string value) { }

	// RVA: 0x13844FC
	public bool get_DisableAdvertisingId() { }

	// RVA: 0x1384504
	public void set_DisableAdvertisingId(bool value) { }

	// RVA: 0x1384520
	public bool get_Valid() { }

	// RVA: 0x1384578
	public bool get_Dirty() { }

	// RVA: 0x1384580
	public void set_Dirty(bool value) { }

}

// Namespace: TapjoyUnity.Internal
[Serializable]
public class IosPlatformSettings
{
	// Methods

	// RVA: 0x1384588
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal
public sealed class ApiBindingIos
{
	// Methods

	// RVA: 0x13845F4
	public static void Install() { }

	// RVA: 0x1384774
	private void .ctor() { }

	// RVA: 0x1384830
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x1384EE4
	private void transferDictionaryToObjectiveCWithName(System.Collections.Generic.Dictionary<System.String,System.Object> dictionary, string dictionaryName) { }

	// RVA: 0x1385598
	public override string GetSDKVersion() { }

	// RVA: 0x1385600
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x138560C
	public override void GetPrivacyPolicy() { }

	// RVA: 0x1385614
	public override void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x1385620
	public override int GetSubjectToGDPR() { }

	// RVA: 0x1385628
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x1385634
	public override int GetUserConsent() { }

	// RVA: 0x138563C
	public override void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x1385648
	public override int GetBelowConsentAge() { }

	// RVA: 0x1385650
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13856A4
	public override string GetUSPrivacy() { }

	// RVA: 0x138570C
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x1385710
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x1385718
	public override void ActivateUnitySupport() { }

	// RVA: 0x138571C
	public override void GetCurrencyBalance() { }

	// RVA: 0x1385724
	public override void SpendCurrency(int amount) { }

	// RVA: 0x1385730
	public override void AwardCurrency(int amount) { }

	// RVA: 0x138573C
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x1385744
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x13857D8
	public override void DismissPlacementContent() { }

	// RVA: 0x13857E0
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x1385834
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x1385888
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13858FC
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x1385970
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x1385A30
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1385AEC
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1385BAC
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x1385C68
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x1385CBC
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x1385D10
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x1385D64
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x1385DE8
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1385EAC
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x1385ECC
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x1385EEC
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x1385F40
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x13860C4
	public override void SetUserID(string userID) { }

	// RVA: 0x1386118
	public override string GetUserID() { }

	// RVA: 0x1386180
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x13861D4
	public override string GetCustomParameter() { }

	// RVA: 0x138623C
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x1386248
	public override int GetUserLevel() { }

	// RVA: 0x1386250
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x138625C
	public override int GetMaxLevel() { }

	// RVA: 0x1386264
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1386270
	public override int GetUserSegment() { }

	// RVA: 0x1386278
	public override Double GetScreenScale() { }

	// RVA: 0x1386280
	public override void ClearUserTags() { }

	// RVA: 0x1386288
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1386668
	public override void AddUserTag(string tag) { }

	// RVA: 0x13866BC
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x1386710
	public override void TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x1384808
	private static extern void Tapjoy_SetUnityVersion(string version) { }

	// RVA: 0x1385570
	private static extern void Tapjoy_Connect(string sdkKey) { }

	// RVA: 0x1385504
	private static extern void Tapjoy_SetKeyToValueInDictionary(string key, string valueToSet, string dictionaryName) { }

	// RVA: 0x1385498
	private static extern void Tapjoy_SetKeyToDictionaryRefValueInDictionary(string key, string dictionaryNameToSet, string dictionaryNameToSetTo) { }

	// RVA: 0x13855CC
	private static extern string Tapjoy_GetSDKVersion() { }

	// RVA: 0x1385608
	private static extern void Tapjoy_SetDebugEnabled(bool enabled) { }

	// RVA: 0x1385610
	private static extern void Tapjoy_GetPrivacyPolicy() { }

	// RVA: 0x138561C
	private static extern void Tapjoy_SetSubjectToGDPRStatus(int gdprApplicable) { }

	// RVA: 0x1385624
	private static extern int Tapjoy_GetSubjectToGDPRStatus() { }

	// RVA: 0x1385630
	private static extern void Tapjoy_SetUserConsentStatus(int consent) { }

	// RVA: 0x1385638
	private static extern int Tapjoy_GetUserConsentStatus() { }

	// RVA: 0x1385644
	private static extern void Tapjoy_SetBelowConsentAgeStatus(int belowConsentAge) { }

	// RVA: 0x138564C
	private static extern int Tapjoy_GetBelowConsentAgeStatus() { }

	// RVA: 0x138567C
	private static extern void Tapjoy_SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13856D8
	private static extern string Tapjoy_GetUSPrivacy() { }

	// RVA: 0x1385720
	private static extern void Tapjoy_GetCurrencyBalance() { }

	// RVA: 0x138572C
	private static extern void Tapjoy_SpendCurrency(int amount) { }

	// RVA: 0x1385738
	private static extern void Tapjoy_AwardCurrency(int amount) { }

	// RVA: 0x1385740
	private static extern void Tapjoy_ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x1385790
	private static extern void Tapjoy_CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x13857DC
	private static extern void Tapjoy_DismissPlacementContent() { }

	// RVA: 0x138580C
	private static extern void Tapjoy_RequestPlacementContent(string placementGuid) { }

	// RVA: 0x1385860
	private static extern void Tapjoy_ShowPlacementContent(string placementGuid) { }

	// RVA: 0x1385938
	private static extern bool Tapjoy_IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x13858C4
	private static extern bool Tapjoy_IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13859CC
	private static extern int Tapjoy_SetPlacementBalance(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1385A90
	private static extern int Tapjoy_GetPlacementBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1385B48
	private static extern int Tapjoy_SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1385C0C
	private static extern int Tapjoy_GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x1385DA0
	private static extern bool Tapjoy_RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x1385E44
	private static extern bool Tapjoy_RequestOfferwallDiscoverAtPosition(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1385EB0
	private static extern bool Tapjoy_ShowOfferwallDiscover() { }

	// RVA: 0x1385ED0
	private static extern bool Tapjoy_DestroyOfferwallDiscover() { }

	// RVA: 0x1385C94
	private static extern void Tapjoy_ActionRequestCompleted(string requestId) { }

	// RVA: 0x1385CE8
	private static extern void Tapjoy_ActionRequestCancelled(string requestId) { }

	// RVA: 0x1385D3C
	private static extern void Tapjoy_RemovePlacement(string placementGuid) { }

	// RVA: 0x1385F18
	private static extern void Tapjoy_RemoveActionRequest(string requestId) { }

	// RVA: 0x138607C
	private static extern void Tapjoy_SetEntryPoint(string placementGuid, string entryPoint) { }

	// RVA: 0x13860F0
	private static extern void Tapjoy_SetUserID(string userId) { }

	// RVA: 0x138614C
	private static extern string Tapjoy_GetUserID() { }

	// RVA: 0x13861AC
	private static extern void Tapjoy_SetCustomParameter(string customParam) { }

	// RVA: 0x1386208
	private static extern string Tapjoy_GetCustomParameter() { }

	// RVA: 0x1386244
	private static extern void Tapjoy_SetUserLevel(int userLevel) { }

	// RVA: 0x138624C
	private static extern int Tapjoy_GetUserLevel() { }

	// RVA: 0x1386258
	private static extern void Tapjoy_SetMaxLevel(int maxLevel) { }

	// RVA: 0x1386260
	private static extern int Tapjoy_GetMaxLevel() { }

	// RVA: 0x138626C
	private static extern void Tapjoy_SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1386274
	private static extern int Tapjoy_GetUserSegment() { }

	// RVA: 0x138627C
	private static extern Double Tapjoy_GetScreenScale() { }

	// RVA: 0x1386284
	private static extern void Tapjoy_ClearUserTags() { }

	// RVA: 0x1386474
	private static extern string Tapjoy_GetUserTags() { }

	// RVA: 0x1386694
	private static extern void Tapjoy_AddUserTag(string tag) { }

	// RVA: 0x13866E8
	private static extern void Tapjoy_RemoveUserTag(string tag) { }

	// RVA: 0x138674C
	private static extern void Tapjoy_TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x1386784
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

	// RVA: 0x1387F10
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

	// RVA: 0x137A898
	public static TapjoyComponent FindInstance() { }

	// RVA: 0x13868B0
	private void Awake() { }

	// RVA: 0x1386E74
	private void OnApiBindingSet() { }

	// RVA: 0x1386C2C
	private void EnsureSingleton() { }

	// RVA: 0x137A93C
	internal void Reconnect() { }

	// RVA: 0x1386EB0
	internal bool ConnectManually() { }

	// RVA: 0x137AC9C
	internal bool ConnectManually(string sdkKey) { }

	// RVA: 0x137AE6C
	internal bool ConnectManually(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x1386F44
	private bool ConnectInternal(System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x13875BC
	private void OnDestroy() { }

	// RVA: 0x138783C
	private void HandleOnConnectSuccess() { }

	// RVA: 0x13878B8
	private void HandleOnConnectFailed(int code, string message) { }

	// RVA: 0x1387934
	private void HandleOnConnectWarning(int code, string message) { }

	// RVA: 0x1387938
	private void Start() { }

	// RVA: 0x1387A38
	private void Update() { }

	// RVA: 0x1387C34
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x1387DBC
	private void OnApplicationQuit() { }

	// RVA: 0x1387E70
	private void OnNativeConnectCallback(string commaDelimitedMessage) { }

	// RVA: 0x1387E78
	private void OnNativeSetUserIDCallback(string commaDelimitedMessage) { }

	// RVA: 0x1387E80
	private void OnNativeCurrencyCallback(string commaDelimitedMessage) { }

	// RVA: 0x1387E88
	private void OnNativePlacementCallback(string commaDelimitedMessage) { }

	// RVA: 0x1387F08
	private void OnNativeOfferwallDiscoverCallback(string commaDelimitedMessage) { }

	// RVA: 0x138019C
	public static void RemovePlacement(string placementID) { }

	// RVA: 0x137EF50
	public static void RemoveActionRequest(string requestID) { }

	// RVA: 0x1387F20
	public void .ctor() { }

	// RVA: 0x1387F28
	private static void .cctor() { }

}

// Namespace: TapjoyUnity.Internal
public class TapjoySettings
{
	// Fields
	private PlatformSettings androidSettings; // 0x18
	private IosPlatformSettings iosSettings; // 0x20
	private bool autoConnectEnabled; // 0x28
	private bool debugEnabled; // 0x29
	private bool dirty; // 0x2A

	// Methods

	// RVA: 0x1387FC8
	public PlatformSettings get_AndroidSettings() { }

	// RVA: 0x1387FD0
	public IosPlatformSettings get_IosSettings() { }

	// RVA: 0x1387FD8
	public bool get_AutoConnectEnabled() { }

	// RVA: 0x1387FE0
	public void set_AutoConnectEnabled(bool value) { }

	// RVA: 0x1387FFC
	public bool get_DebugEnabled() { }

	// RVA: 0x1388004
	public void set_DebugEnabled(bool value) { }

	// RVA: 0x1388020
	public bool get_Dirty() { }

	// RVA: 0x1388078
	public void set_Dirty(bool value) { }

	// RVA: 0x13880A8
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

	// RVA: 0x13889D8
	private static void .cctor() { }

	// RVA: 0x1388A44
	public void .ctor() { }

	// RVA: 0x1388A4C
	internal void <Awake>b__1_0(Scene oldScene, Scene newScene) { }

	// RVA: 0x1388AF8
	internal void <Awake>b__1_1(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1388B94
	internal void <Awake>b__1_2(Scene scene) { }

	// RVA: 0x1388C1C
	internal int <Awake>b__1_3() { }

	// RVA: 0x1388C8C
	internal SceneCompat <Awake>b__1_4() { }

	// RVA: 0x1388D0C
	internal SceneCompat <Awake>b__1_5(int index) { }

}

// Namespace: TapjoyUnity.Internal
public sealed class TapjoyUnityInit
{
	// Fields
	private static bool initialized; // 0x0

	// Methods

	// RVA: 0x13881E4
	private void Awake() { }

	// RVA: 0x13887A8
	private static SceneCompat Wrap(Scene scene) { }

	// RVA: 0x13889D0
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

	// RVA: 0x1388F1C
	public void .ctor(int <>1__state) { }

	// RVA: 0x138C25C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138C260
	private bool MoveNext() { }

	// RVA: 0x138C280
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x138C288
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x138C2C8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138C2D0
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x138C370
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

	// RVA: 0x1388FDC
	public void .ctor(int <>1__state) { }

	// RVA: 0x138C410
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138C600
	private bool MoveNext() { }

	// RVA: 0x138CC9C
	private void <>m__Finally1() { }

	// RVA: 0x138CBD8
	private void <>m__Finally2() { }

	// RVA: 0x138CD60
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x138CD68
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x138CDA8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138CDB0
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x138CE64
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public abstract class JSONNode
{
	// Fields
	internal static StringBuilder m_EscapeBuilder; // 0x0

	// Methods

	// RVA: 0x1388D94
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x1388D9C
	public virtual void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1388DA0
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x1388DA8
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1388DAC
	public virtual string get_Value() { }

	// RVA: 0x1388DF0
	public virtual void set_Value(string value) { }

	// RVA: 0x1388DF4
	public virtual int get_Count() { }

	// RVA: 0x1388DFC
	public virtual bool get_IsNumber() { }

	// RVA: 0x1388E04
	public virtual bool get_IsString() { }

	// RVA: 0x1388E0C
	public virtual bool get_IsBoolean() { }

	// RVA: 0x1388E14
	public virtual bool get_IsNull() { }

	// RVA: 0x1388E1C
	public virtual bool get_IsArray() { }

	// RVA: 0x1388E24
	public virtual bool get_IsObject() { }

	// RVA: 0x1388E2C
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1388E30
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x1388E98
	public virtual JSONNode Remove(string aKey) { }

	// RVA: 0x1388EA0
	public virtual JSONNode Remove(int aIndex) { }

	// RVA: 0x1388EA8
	public virtual JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1388EB0
	public virtual System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x1388F54
	public System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_DeepChildren() { }

	// RVA: 0x1389014
	public override string ToString() { }

	// RVA: 0x13890AC
	public virtual string ToString(int aIndent) { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract JSONNodeType get_Tag() { }

	// RVA: 0x1389148
	public virtual Double get_AsDouble() { }

	// RVA: 0x138918C
	public virtual void set_AsDouble(Double value) { }

	// RVA: 0x13891D4
	public virtual int get_AsInt() { }

	// RVA: 0x138920C
	public virtual void set_AsInt(int value) { }

	// RVA: 0x1389220
	public virtual float get_AsFloat() { }

	// RVA: 0x1389244
	public virtual void set_AsFloat(float value) { }

	// RVA: 0x1389258
	public virtual bool get_AsBool() { }

	// RVA: 0x1389338
	public virtual void set_AsBool(bool value) { }

	// RVA: 0x13893BC
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x1389440
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x13894C4
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x1386528
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x138976C
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x1389890
	public static Double op_Implicit(JSONNode d) { }

	// RVA: 0x13899D4
	public static JSONNode op_Implicit(float n) { }

	// RVA: 0x1389A84
	public static float op_Implicit(JSONNode d) { }

	// RVA: 0x1389BC8
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x1389C78
	public static int op_Implicit(JSONNode d) { }

	// RVA: 0x1389DBC
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x1389ED0
	public static bool op_Implicit(JSONNode d) { }

	// RVA: 0x13895EC
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x138A014
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x138A084
	public override bool Equals(object obj) { }

	// RVA: 0x138A090
	public override int GetHashCode() { }

	// RVA: 0x138A098
	internal static string Escape(string aText) { }

	// RVA: 0x138A47C
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	// RVA: 0x138A980
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x138B254
	public virtual void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x138B258
	public void SaveToStream(Stream aData) { }

	// RVA: 0x138B2D4
	public void SaveToCompressedStream(Stream aData) { }

	// RVA: 0x138B328
	public void SaveToCompressedFile(string aFileName) { }

	// RVA: 0x138B37C
	public string SaveToCompressedBase64() { }

	// RVA: 0x138B3D0
	public void SaveToFile(string aFileName) { }

	// RVA: 0x138B5B0
	public string SaveToBase64() { }

	// RVA: 0x138B7E0
	public static JSONNode Deserialize(BinaryReader aReader) { }

	// RVA: 0x138BCF0
	public static JSONNode LoadFromCompressedFile(string aFileName) { }

	// RVA: 0x138BD44
	public static JSONNode LoadFromCompressedStream(Stream aData) { }

	// RVA: 0x138BD98
	public static JSONNode LoadFromCompressedBase64(string aBase64) { }

	// RVA: 0x138BDEC
	public static JSONNode LoadFromStream(Stream aData) { }

	// RVA: 0x138BF70
	public static JSONNode LoadFromFile(string aFileName) { }

	// RVA: 0x138C0D8
	public static JSONNode LoadFromBase64(string aBase64) { }

	// RVA: 0x138C1CC
	protected void .ctor() { }

	// RVA: 0x138C1D4
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

	// RVA: 0x138D934
	public void .ctor(int <>1__state) { }

	// RVA: 0x138DCE8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138DD64
	private bool MoveNext() { }

	// RVA: 0x138DFD4
	private void <>m__Finally1() { }

	// RVA: 0x138E030
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x138E038
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x138E078
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

	// RVA: 0x138D884
	public void .ctor(int <>1__state) { }

	// RVA: 0x138E080
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138E0FC
	private bool MoveNext() { }

	// RVA: 0x138E36C
	private void <>m__Finally1() { }

	// RVA: 0x138E3C8
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x138E3D0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x138E410
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x138E418
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x138E4CC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<TapjoyUnity.Internal.SimpleJSON.JSONNode> m_List; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x138CE68
	public override JSONNodeType get_Tag() { }

	// RVA: 0x138CE70
	public override bool get_IsArray() { }

	// RVA: 0x138CE78
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x138D034
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x138D240
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x138D300
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x138D4B4
	public override int get_Count() { }

	// RVA: 0x138D500
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x138D6B4
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x138D790
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x138D7FC
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x138D8BC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x138D960
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x138DA50
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x138B19C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public JSONNode aNode; // 0x10

	// Methods

	// RVA: 0x138F550
	public void .ctor() { }

	// RVA: 0x138FE5C
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

	// RVA: 0x138F690
	public void .ctor(int <>1__state) { }

	// RVA: 0x138FF70
	private void System.IDisposable.Dispose() { }

	// RVA: 0x138FFEC
	private bool MoveNext() { }

	// RVA: 0x1390294
	private void <>m__Finally1() { }

	// RVA: 0x13902F0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x13902F8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1390338
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

	// RVA: 0x138F5E0
	public void .ctor(int <>1__state) { }

	// RVA: 0x1390340
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13903BC
	private bool MoveNext() { }

	// RVA: 0x13906D0
	private void <>m__Finally1() { }

	// RVA: 0x139072C
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1390734
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1390774
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x139077C
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1390830
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> m_Dict; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x138E4D0
	public override JSONNodeType get_Tag() { }

	// RVA: 0x138E4D8
	public override bool get_IsObject() { }

	// RVA: 0x138E4E0
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x138E6AC
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x138E8D0
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x138EA24
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x138ECE0
	public override int get_Count() { }

	// RVA: 0x138ED34
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x138EFD0
	public override JSONNode Remove(string aKey) { }

	// RVA: 0x138F0BC
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x138F2C8
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x138F558
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x138F618
	public IEnumerator GetEnumerator() { }

	// RVA: 0x138F6BC
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x138F97C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x138B0E4
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x1390834
	public override JSONNodeType get_Tag() { }

	// RVA: 0x139083C
	public override bool get_IsString() { }

	// RVA: 0x1390844
	public override string get_Value() { }

	// RVA: 0x139084C
	public override void set_Value(string value) { }

	// RVA: 0x1389574
	public void .ctor(string aData) { }

	// RVA: 0x1390854
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13908A4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x139094C
	public override bool Equals(object obj) { }

	// RVA: 0x1390B80
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x1390BA4
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1390BAC
	public override bool get_IsNumber() { }

	// RVA: 0x1390BB4
	public override string get_Value() { }

	// RVA: 0x1390BC0
	public override void set_Value(string value) { }

	// RVA: 0x1390C08
	public override Double get_AsDouble() { }

	// RVA: 0x1390C10
	public override void set_AsDouble(Double value) { }

	// RVA: 0x1389818
	public void .ctor(Double aData) { }

	// RVA: 0x1390C18
	public void .ctor(string aData) { }

	// RVA: 0x1390C94
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1390CE4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1390D08
	private static bool IsNumeric(object value) { }

	// RVA: 0x1390EB4
	public override bool Equals(object obj) { }

	// RVA: 0x13910FC
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x139111C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1391124
	public override bool get_IsBoolean() { }

	// RVA: 0x139112C
	public override string get_Value() { }

	// RVA: 0x13911B4
	public override void set_Value(string value) { }

	// RVA: 0x1391274
	public override bool get_AsBool() { }

	// RVA: 0x139127C
	public override void set_AsBool(bool value) { }

	// RVA: 0x1389E60
	public void .ctor(bool aData) { }

	// RVA: 0x1391284
	public void .ctor(string aData) { }

	// RVA: 0x1391300
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x139134C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13913D0
	public override bool Equals(object obj) { }

	// RVA: 0x1391460
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNull
{
	// Methods

	// RVA: 0x13914E8
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13914F0
	public override bool get_IsNull() { }

	// RVA: 0x13914F8
	public override string get_Value() { }

	// RVA: 0x139153C
	public override void set_Value(string value) { }

	// RVA: 0x1391540
	public override bool get_AsBool() { }

	// RVA: 0x1391548
	public override void set_AsBool(bool value) { }

	// RVA: 0x139154C
	public override bool Equals(object obj) { }

	// RVA: 0x13915FC
	public override int GetHashCode() { }

	// RVA: 0x1391604
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x139162C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x138BC68
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x1391684
	public override JSONNodeType get_Tag() { }

	// RVA: 0x138CFAC
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x138E618
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x139168C
	private void Set(JSONNode aVal) { }

	// RVA: 0x139170C
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13917CC
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1391894
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1391960
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1391A38
	public override void Add(JSONNode aItem) { }

	// RVA: 0x1391B00
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1391BD8
	public static bool op_Equality(JSONLazyCreator a, object b) { }

	// RVA: 0x1391BE8
	public static bool op_Inequality(JSONLazyCreator a, object b) { }

	// RVA: 0x1391BF8
	public override bool Equals(object obj) { }

	// RVA: 0x1391C08
	public override int GetHashCode() { }

	// RVA: 0x1391C10
	public override int get_AsInt() { }

	// RVA: 0x1391D28
	public override void set_AsInt(int value) { }

	// RVA: 0x1391E54
	public override float get_AsFloat() { }

	// RVA: 0x1391F6C
	public override void set_AsFloat(float value) { }

	// RVA: 0x1392090
	public override Double get_AsDouble() { }

	// RVA: 0x13921A8
	public override void set_AsDouble(Double value) { }

	// RVA: 0x13922C4
	public override bool get_AsBool() { }

	// RVA: 0x13923DC
	public override void set_AsBool(bool value) { }

	// RVA: 0x13924F8
	public override JSONArray get_AsArray() { }

	// RVA: 0x13925A8
	public override JSONObject get_AsObject() { }

	// RVA: 0x1392658
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x13864A8
	public static JSONNode Parse(string aJSON) { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
public class JsonUtilityCompat
{
	// Methods

	// RVA: 0x13926B0
	internal static string ToJson(object obj) { }

	// RVA: 0x139275C
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

	// RVA: 0x13888F8
	public void .ctor(object scene, bool valid, int buildIndex, string name, string path) { }

	// RVA: 0x1392764
	public override int GetHashCode() { }

	// RVA: 0x139276C
	internal bool IsValid() { }

	// RVA: 0x1392774
	internal int get_buildIndex() { }

	// RVA: 0x13928AC
	internal string get_name() { }

	// RVA: 0x13928B4
	internal string get_path() { }

	// RVA: 0x13928BC
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

	// RVA: 0x13928C0
	internal static int get_sceneCount() { }

	// RVA: 0x1392944
	internal static SceneCompat GetActiveScene() { }

	// RVA: 0x1392A0C
	internal static SceneCompat GetSceneAt(int index) { }

	// RVA: 0x1392AE4
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

	// RVA: 0x137DC18
	internal static UInt32 ComputeStringHash(string s) { }

}


