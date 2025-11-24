// Namespace: 
internal class <Module>
{}

// Namespace: 
public static class EntryPointExtensions
{
	// Fields
	public static readonly System.Collections.Generic.Dictionary<TapjoyUnity.TJEntryPoint,System.String> entryPointValues; // 0x0

	// Methods

	// RVA: 0x1360AD0
	public static string GetValue(TJEntryPoint entryPoint) { }

	// RVA: 0x1360B8C
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

	// RVA: 0x1360E44
	private static MonoScriptData Get() { }

	// RVA: 0x1360F48
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction
{
	// Methods

	// RVA: 0x1360F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1360FF0
	public virtual void Invoke() { }

	// RVA: 0x1361004
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x136105C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1, T2 arg2) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3, T4>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TResult Invoke() { }

	// RVA: 0x30B1E68
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x316B894
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TResult Invoke(T1 arg1) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x316B894
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectSuccessHandler
{
	// Methods

	// RVA: 0x1364764
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364804
	public virtual void Invoke() { }

	// RVA: 0x1364818
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1364870
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectFailedHandler
{
	// Methods

	// RVA: 0x136487C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364920
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x1364934
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x13649F4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectWarningHandler
{
	// Methods

	// RVA: 0x1364A00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364AA4
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x1364AB8
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x1364B78
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDSuccessHandler
{
	// Methods

	// RVA: 0x1364B84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364C24
	public virtual void Invoke() { }

	// RVA: 0x1364C38
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1364C90
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailedHandler
{
	// Methods

	// RVA: 0x1364C9C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364D40
	public virtual void Invoke(int code, string errorMessage) { }

	// RVA: 0x1364D54
	public virtual IAsyncResult BeginInvoke(int code, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1364E14
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailureHandler
{
	// Methods

	// RVA: 0x1364E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1364ED4
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1364EE8
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1364F38
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseHandler
{
	// Methods

	// RVA: 0x1364F44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1365000
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x1365014
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x13650D8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseFailureHandler
{
	// Methods

	// RVA: 0x13650E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1365198
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x13651AC
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13651FC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseHandler
{
	// Methods

	// RVA: 0x1365208
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13652C4
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x13652D8
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x136539C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x13653A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136545C
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1365470
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x13654C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseHandler
{
	// Methods

	// RVA: 0x13654CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1365588
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x136559C
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x1365660
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x136566C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1365720
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1365734
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1365784
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnEarnedCurrencyHandler
{
	// Methods

	// RVA: 0x1365790
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136584C
	public virtual void Invoke(string currencyName, int amount) { }

	// RVA: 0x1365860
	public virtual IAsyncResult BeginInvoke(string currencyName, int amount, AsyncCallback callback, object object) { }

	// RVA: 0x1365924
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

	// RVA: 0x1361068
	public static string get_Version() { }

	// RVA: 0x1361100
	public static bool get_IsConnected() { }

	// RVA: 0x136114C
	public static void set_IsConnected(bool value) { }

	// RVA: 0x13611A4
	public static void Connect() { }

	// RVA: 0x136159C
	public static void Connect(string sdkKey) { }

	// RVA: 0x136175C
	public static void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x1361A80
	public static void SetDebugEnabled(bool enable) { }

	// RVA: 0x1361BBC
	public static void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x1361BF4
	public static bool GetOptOutAdvertisingID() { }

	// RVA: 0x1361C1C
	public static void ActionComplete(string actionID) { }

	// RVA: 0x1361C20
	public static void SetUserID(string userId) { }

	// RVA: 0x1361C58
	public static string GetUserID() { }

	// RVA: 0x1361C80
	public static void SetCustomParameter(string customParam) { }

	// RVA: 0x1361CB8
	public static string GetCustomParameter() { }

	// RVA: 0x1361CE0
	public static void SetUserLevel(int userLevel) { }

	// RVA: 0x1361D18
	public static int GetUserLevel() { }

	// RVA: 0x1361D40
	public static void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x1361D78
	public static int GetMaxLevel() { }

	// RVA: 0x1361DA0
	public static void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1361DD8
	public static TJSegment GetUserSegment() { }

	// RVA: 0x1361E00
	public static Double GetScreenScale() { }

	// RVA: 0x1361E28
	public static void ClearUserTags() { }

	// RVA: 0x1361E50
	public static System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1361E78
	public static void AddUserTag(string tag) { }

	// RVA: 0x1361EB0
	public static void RemoveUserTag(string tag) { }

	// RVA: 0x1361EE8
	public static void TrackPurchase(string currencyCode, Double productPrice) { }

	// RVA: 0x1361F30
	public static void TrackPurchase(string productId, string currencyCode, Double productPrice, string campaignId) { }

	// RVA: 0x1361F78
	public static void TrackPurchaseInGooglePlayStore(string skuDetails, string purchaseData, string dataSignature, string campaignId) { }

	// RVA: 0x1361F7C
	public static void TrackPurchaseInAppleAppStore(string productId, string currencyCode, Double productPrice, string transactionId, string campaignId) { }

	// RVA: 0x1361FC4
	public static void AwardCurrency(int amount) { }

	// RVA: 0x1361FFC
	public static void GetCurrencyBalance() { }

	// RVA: 0x1362024
	public static void SpendCurrency(int amount) { }

	// RVA: 0x136205C
	public static string GetSupportURL() { }

	// RVA: 0x13620A0
	public static string GetSupportURL(string currencyID) { }

	// RVA: 0x13620E4
	public static void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x136210C
	public static void add_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x13621E0
	public static void remove_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x13622B4
	internal static void add_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x1362388
	internal static void remove_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x136245C
	public static void add_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x1362530
	public static void remove_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x1362604
	internal static void add_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x13626D8
	internal static void remove_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x13627AC
	public static void add_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x1362880
	public static void remove_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x1362954
	internal static void add_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x1362A28
	internal static void remove_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x1362AFC
	internal static void DispatchConnectEvent(string connectCallbackMethod) { }

	// RVA: 0x1362E9C
	public static void add_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x1362F70
	public static void remove_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x1363044
	public static void add_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x1363118
	public static void remove_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x13631EC
	public static void add_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x13632C0
	public static void remove_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x1363394
	internal static void DispatchSetUserIDEvent(string commaDelimitedMessage) { }

	// RVA: 0x13635F4
	public static void add_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x13636C8
	public static void remove_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x136379C
	public static void add_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x1363870
	public static void remove_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x1363944
	public static void add_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x1363A18
	public static void remove_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x1363AEC
	public static void add_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x1363BC0
	public static void remove_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x1363C94
	public static void add_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x1363D68
	public static void remove_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x1363E3C
	public static void add_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x1363F10
	public static void remove_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x1363FE4
	public static void add_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x13640B8
	public static void remove_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x136418C
	internal static void DispatchCurrencyEvent(string commaDelimitedMessage) { }

	// RVA: 0x136475C
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJActionRequest
{
	// Fields
	public string requestID; // 0x10
	public string token; // 0x18

	// Methods

	// RVA: 0x1365930
	protected override void Finalize() { }

	// RVA: 0x1365ADC
	internal void .ctor(string requestID, string token) { }

	// RVA: 0x1365B2C
	public void Completed() { }

	// RVA: 0x1365B64
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

	// RVA: 0x1366508
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13665A8
	public virtual void Invoke() { }

	// RVA: 0x13665BC
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1366614
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x1366620
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13666C4
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x13666D8
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1366798
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x13667A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1366844
	public virtual void Invoke() { }

	// RVA: 0x1366858
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13668B0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentErrorHandler
{
	// Methods

	// RVA: 0x13668BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1366960
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x1366974
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1366A34
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

	// RVA: 0x1365B9C
	public void .ctor() { }

	// RVA: 0x1365BA4
	public static void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x1365BEC
	public static void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1365C54
	public static void ShowOfferwallDiscover() { }

	// RVA: 0x1365C7C
	public static void DestroyOfferwallDiscover() { }

	// RVA: 0x1365CA4
	internal static void DispatchOfferwallDiscoverEvent(string commaDelimitedMessage) { }

	// RVA: 0x1365E78
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1365F44
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1366010
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13660E4
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13661B8
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x136628C
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1366360
	public static void add_OnContentError(OnContentErrorHandler value) { }

	// RVA: 0x1366434
	public static void remove_OnContentError(OnContentErrorHandler value) { }

}

// Namespace: 
public sealed class OnRequestSuccessHandler
{
	// Methods

	// RVA: 0x1369060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369180
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1369194
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13691E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x13691F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369314
	public virtual void Invoke(TJPlacement placement, string error) { }

	// RVA: 0x1369328
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1369384
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x1369390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13694B0
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13694C4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1369514
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentShowHandler
{
	// Methods

	// RVA: 0x1369520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369640
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1369654
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13696A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentDismissHandler
{
	// Methods

	// RVA: 0x13696B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13697D0
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x13697E4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1369834
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnClickHandler
{
	// Methods

	// RVA: 0x1369840
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369960
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1369974
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13699C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnPurchaseRequestHandler
{
	// Methods

	// RVA: 0x13699D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369AF4
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string productId) { }

	// RVA: 0x1369B08
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string productId, AsyncCallback callback, object object) { }

	// RVA: 0x1369B64
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRewardRequestHandler
{
	// Methods

	// RVA: 0x1369B70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369C94
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity) { }

	// RVA: 0x1369CA8
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity, AsyncCallback callback, object object) { }

	// RVA: 0x1369D80
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceSuccessHandler
{
	// Methods

	// RVA: 0x1369D8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1369EAC
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1369EC0
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1369F10
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceFailureHandler
{
	// Methods

	// RVA: 0x1369F1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136A040
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x136A054
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x136A124
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredSuccessHandler
{
	// Methods

	// RVA: 0x136A130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136A250
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x136A264
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x136A2B4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredFailureHandler
{
	// Methods

	// RVA: 0x136A2C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136A3E4
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x136A3F8
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x136A4C8
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

	// RVA: 0x1366A40
	private void .ctor(string placementName) { }

	// RVA: 0x1366B7C
	protected override void Finalize() { }

	// RVA: 0x1366D20
	public static TJPlacement CreatePlacement(string placementName) { }

	// RVA: 0x1366D84
	public static void DismissContent() { }

	// RVA: 0x1366DAC
	public void RequestContent() { }

	// RVA: 0x1366EA0
	public void ShowContent() { }

	// RVA: 0x1366F74
	public bool IsContentAvailable() { }

	// RVA: 0x1366FAC
	public bool IsContentReady() { }

	// RVA: 0x1366FE4
	public string GetName() { }

	// RVA: 0x1366FEC
	public void SetEntryPoint(TJEntryPoint entryPoint) { }

	// RVA: 0x136702C
	public void SetCurrencyBalance(string currencyId, int balance) { }

	// RVA: 0x136707C
	public int GetCurrencyBalance(string currencyId) { }

	// RVA: 0x13670BC
	public void SetRequiredAmount(string currencyId, int amount) { }

	// RVA: 0x136710C
	public int GetRequiredAmount(string currencyId) { }

	// RVA: 0x136714C
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1367230
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1367314
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13673F8
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13674DC
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13675C0
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x13676A4
	public static void add_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1367788
	public static void remove_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x136786C
	public static void add_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1367950
	public static void remove_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1367A34
	public static void add_OnClick(OnClickHandler value) { }

	// RVA: 0x1367B18
	public static void remove_OnClick(OnClickHandler value) { }

	// RVA: 0x1367BFC
	public static void add_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x1367CE0
	public static void remove_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x1367DC4
	public static void add_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x1367EA8
	public static void remove_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x1367F8C
	public static void add_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x1368070
	public static void remove_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x1368154
	public static void add_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1368238
	public static void remove_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x136831C
	public static void add_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x1368400
	public static void remove_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x13684E4
	public static void add_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x13685C8
	public static void remove_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x13686AC
	internal static void DispatchPlacementEvent(string commaDelimitedMessage) { }

	// RVA: 0x1368FC4
	private static void .cctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJPrivacyPolicy
{
	// Methods

	// RVA: 0x136A4D4
	private void .ctor() { }

	// RVA: 0x136A500
	public static TJPrivacyPolicy GetPrivacyPolicy() { }

	// RVA: 0x136A570
	public void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x136A5A4
	public TJStatus GetSubjectToGDPR() { }

	// RVA: 0x136A5C8
	public void SetUserConsent(TJStatus consent) { }

	// RVA: 0x136A5FC
	public TJStatus GetUserConsent() { }

	// RVA: 0x136A620
	public void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x136A658
	public TJStatus GetBelowConsentAge() { }

	// RVA: 0x136A680
	public void SetUSPrivacy(string privacyPolicy) { }

	// RVA: 0x136A6B8
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

	// RVA: 0x136A930
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x136A9D0
	public virtual void Invoke() { }

	// RVA: 0x136A9E4
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x136AA3C
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

	// RVA: 0x1361AB4
	public static ApiBinding get_Instance() { }

	// RVA: 0x136A748
	protected static void SetInstance(ApiBinding value) { }

	// RVA: 0x136A824
	internal static void set_OnInstanceSet(OnInstanceSetHandler value) { }

	// RVA: 0x136A8F4
	protected void .ctor(string name) { }

	// RVA: 0x136A928
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

	// RVA: 0x136A6E0
	public void .ctor() { }

	// RVA: 0x136AA48
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x136AA4C
	public override string GetSDKVersion() { }

	// RVA: 0x136AA90
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x136AA94
	public override void ActivateUnitySupport() { }

	// RVA: 0x136AA98
	public override void GetPrivacyPolicy() { }

	// RVA: 0x136AA9C
	public override void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x136AAA0
	public override int GetSubjectToGDPR() { }

	// RVA: 0x136AAA8
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x136AAAC
	public override int GetUserConsent() { }

	// RVA: 0x136AAB4
	public override void SetBelowConsentAge(TJStatus isBelowConsentAge) { }

	// RVA: 0x136AAB8
	public override int GetBelowConsentAge() { }

	// RVA: 0x136AAC0
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x136AAC4
	public override string GetUSPrivacy() { }

	// RVA: 0x136AB08
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x136AB0C
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x136AB14
	public override void GetCurrencyBalance() { }

	// RVA: 0x136AB18
	public override void SpendCurrency(int amount) { }

	// RVA: 0x136AB1C
	public override void AwardCurrency(int amount) { }

	// RVA: 0x136AB20
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x136AB24
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x136AB28
	public override void DismissPlacementContent() { }

	// RVA: 0x136AB2C
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x136AB30
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x136AB34
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x136AB3C
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x136AB44
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x136AB48
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x136AB50
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x136AB54
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x136AB5C
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x136AB60
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x136AB64
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x136AB68
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x136AB6C
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x136AB70
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x136AB74
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x136AB78
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x136AB7C
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x136AB80
	public override void SetUserID(string userId) { }

	// RVA: 0x136AB84
	public override string GetUserID() { }

	// RVA: 0x136ABC8
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x136ABCC
	public override string GetCustomParameter() { }

	// RVA: 0x136AC10
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x136AC14
	public override int GetUserLevel() { }

	// RVA: 0x136AC1C
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x136AC20
	public override int GetMaxLevel() { }

	// RVA: 0x136AC28
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x136AC2C
	public override int GetUserSegment() { }

	// RVA: 0x136AC34
	public override Double GetScreenScale() { }

	// RVA: 0x136AC3C
	public override void ClearUserTags() { }

	// RVA: 0x136AC40
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x136AC48
	public override void AddUserTag(string tag) { }

	// RVA: 0x136AC4C
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x136AC50
	public override void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal static class ForegroundRealtimeClock
{
	// Fields
	private static float realtimeSpentWhilePaused; // 0x0
	private static float realtimePaused; // 0x4

	// Methods

	// RVA: 0x136AC54
	internal static void OnApplicationPause(bool paused) { }

	// RVA: 0x136ACF8
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

	// RVA: 0x136AD50
	public static void OnActiveSceneChanged(SceneCompat oldScene, SceneCompat newScene) { }

	// RVA: 0x136ADE0
	public static void OnSceneLoaded(SceneCompat scene, int loadMode) { }

	// RVA: 0x136AE6C
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

	// RVA: 0x136AEEC
	public void .ctor() { }

	// RVA: 0x136AF58
	public string get_SdkKey() { }

	// RVA: 0x136AF60
	public void set_SdkKey(string value) { }

	// RVA: 0x136AFB4
	public bool get_DisableAdvertisingId() { }

	// RVA: 0x136AFBC
	public void set_DisableAdvertisingId(bool value) { }

	// RVA: 0x136AFD8
	public bool get_Valid() { }

	// RVA: 0x136B030
	public bool get_Dirty() { }

	// RVA: 0x136B038
	public void set_Dirty(bool value) { }

}

// Namespace: TapjoyUnity.Internal
[Serializable]
public class IosPlatformSettings
{
	// Methods

	// RVA: 0x136B040
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal
public sealed class ApiBindingIos
{
	// Methods

	// RVA: 0x136B0AC
	public static void Install() { }

	// RVA: 0x136B22C
	private void .ctor() { }

	// RVA: 0x136B2E8
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x136B99C
	private void transferDictionaryToObjectiveCWithName(System.Collections.Generic.Dictionary<System.String,System.Object> dictionary, string dictionaryName) { }

	// RVA: 0x136C050
	public override string GetSDKVersion() { }

	// RVA: 0x136C0B8
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x136C0C4
	public override void GetPrivacyPolicy() { }

	// RVA: 0x136C0CC
	public override void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x136C0D8
	public override int GetSubjectToGDPR() { }

	// RVA: 0x136C0E0
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x136C0EC
	public override int GetUserConsent() { }

	// RVA: 0x136C0F4
	public override void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x136C100
	public override int GetBelowConsentAge() { }

	// RVA: 0x136C108
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x136C15C
	public override string GetUSPrivacy() { }

	// RVA: 0x136C1C4
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x136C1C8
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x136C1D0
	public override void ActivateUnitySupport() { }

	// RVA: 0x136C1D4
	public override void GetCurrencyBalance() { }

	// RVA: 0x136C1DC
	public override void SpendCurrency(int amount) { }

	// RVA: 0x136C1E8
	public override void AwardCurrency(int amount) { }

	// RVA: 0x136C1F4
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x136C1FC
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x136C290
	public override void DismissPlacementContent() { }

	// RVA: 0x136C298
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x136C2EC
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x136C340
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x136C3B4
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x136C428
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x136C4E8
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x136C5A4
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x136C664
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x136C720
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x136C774
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x136C7C8
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x136C81C
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x136C8A0
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x136C964
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x136C984
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x136C9A4
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x136C9F8
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x136CB7C
	public override void SetUserID(string userID) { }

	// RVA: 0x136CBD0
	public override string GetUserID() { }

	// RVA: 0x136CC38
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x136CC8C
	public override string GetCustomParameter() { }

	// RVA: 0x136CCF4
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x136CD00
	public override int GetUserLevel() { }

	// RVA: 0x136CD08
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x136CD14
	public override int GetMaxLevel() { }

	// RVA: 0x136CD1C
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x136CD28
	public override int GetUserSegment() { }

	// RVA: 0x136CD30
	public override Double GetScreenScale() { }

	// RVA: 0x136CD38
	public override void ClearUserTags() { }

	// RVA: 0x136CD40
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x136D120
	public override void AddUserTag(string tag) { }

	// RVA: 0x136D174
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x136D1C8
	public override void TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x136B2C0
	private static extern void Tapjoy_SetUnityVersion(string version) { }

	// RVA: 0x136C028
	private static extern void Tapjoy_Connect(string sdkKey) { }

	// RVA: 0x136BFBC
	private static extern void Tapjoy_SetKeyToValueInDictionary(string key, string valueToSet, string dictionaryName) { }

	// RVA: 0x136BF50
	private static extern void Tapjoy_SetKeyToDictionaryRefValueInDictionary(string key, string dictionaryNameToSet, string dictionaryNameToSetTo) { }

	// RVA: 0x136C084
	private static extern string Tapjoy_GetSDKVersion() { }

	// RVA: 0x136C0C0
	private static extern void Tapjoy_SetDebugEnabled(bool enabled) { }

	// RVA: 0x136C0C8
	private static extern void Tapjoy_GetPrivacyPolicy() { }

	// RVA: 0x136C0D4
	private static extern void Tapjoy_SetSubjectToGDPRStatus(int gdprApplicable) { }

	// RVA: 0x136C0DC
	private static extern int Tapjoy_GetSubjectToGDPRStatus() { }

	// RVA: 0x136C0E8
	private static extern void Tapjoy_SetUserConsentStatus(int consent) { }

	// RVA: 0x136C0F0
	private static extern int Tapjoy_GetUserConsentStatus() { }

	// RVA: 0x136C0FC
	private static extern void Tapjoy_SetBelowConsentAgeStatus(int belowConsentAge) { }

	// RVA: 0x136C104
	private static extern int Tapjoy_GetBelowConsentAgeStatus() { }

	// RVA: 0x136C134
	private static extern void Tapjoy_SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x136C190
	private static extern string Tapjoy_GetUSPrivacy() { }

	// RVA: 0x136C1D8
	private static extern void Tapjoy_GetCurrencyBalance() { }

	// RVA: 0x136C1E4
	private static extern void Tapjoy_SpendCurrency(int amount) { }

	// RVA: 0x136C1F0
	private static extern void Tapjoy_AwardCurrency(int amount) { }

	// RVA: 0x136C1F8
	private static extern void Tapjoy_ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x136C248
	private static extern void Tapjoy_CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x136C294
	private static extern void Tapjoy_DismissPlacementContent() { }

	// RVA: 0x136C2C4
	private static extern void Tapjoy_RequestPlacementContent(string placementGuid) { }

	// RVA: 0x136C318
	private static extern void Tapjoy_ShowPlacementContent(string placementGuid) { }

	// RVA: 0x136C3F0
	private static extern bool Tapjoy_IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x136C37C
	private static extern bool Tapjoy_IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x136C484
	private static extern int Tapjoy_SetPlacementBalance(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x136C548
	private static extern int Tapjoy_GetPlacementBalance(string placementGuid, string currencyId) { }

	// RVA: 0x136C600
	private static extern int Tapjoy_SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x136C6C4
	private static extern int Tapjoy_GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x136C858
	private static extern bool Tapjoy_RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x136C8FC
	private static extern bool Tapjoy_RequestOfferwallDiscoverAtPosition(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x136C968
	private static extern bool Tapjoy_ShowOfferwallDiscover() { }

	// RVA: 0x136C988
	private static extern bool Tapjoy_DestroyOfferwallDiscover() { }

	// RVA: 0x136C74C
	private static extern void Tapjoy_ActionRequestCompleted(string requestId) { }

	// RVA: 0x136C7A0
	private static extern void Tapjoy_ActionRequestCancelled(string requestId) { }

	// RVA: 0x136C7F4
	private static extern void Tapjoy_RemovePlacement(string placementGuid) { }

	// RVA: 0x136C9D0
	private static extern void Tapjoy_RemoveActionRequest(string requestId) { }

	// RVA: 0x136CB34
	private static extern void Tapjoy_SetEntryPoint(string placementGuid, string entryPoint) { }

	// RVA: 0x136CBA8
	private static extern void Tapjoy_SetUserID(string userId) { }

	// RVA: 0x136CC04
	private static extern string Tapjoy_GetUserID() { }

	// RVA: 0x136CC64
	private static extern void Tapjoy_SetCustomParameter(string customParam) { }

	// RVA: 0x136CCC0
	private static extern string Tapjoy_GetCustomParameter() { }

	// RVA: 0x136CCFC
	private static extern void Tapjoy_SetUserLevel(int userLevel) { }

	// RVA: 0x136CD04
	private static extern int Tapjoy_GetUserLevel() { }

	// RVA: 0x136CD10
	private static extern void Tapjoy_SetMaxLevel(int maxLevel) { }

	// RVA: 0x136CD18
	private static extern int Tapjoy_GetMaxLevel() { }

	// RVA: 0x136CD24
	private static extern void Tapjoy_SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x136CD2C
	private static extern int Tapjoy_GetUserSegment() { }

	// RVA: 0x136CD34
	private static extern Double Tapjoy_GetScreenScale() { }

	// RVA: 0x136CD3C
	private static extern void Tapjoy_ClearUserTags() { }

	// RVA: 0x136CF2C
	private static extern string Tapjoy_GetUserTags() { }

	// RVA: 0x136D14C
	private static extern void Tapjoy_AddUserTag(string tag) { }

	// RVA: 0x136D1A0
	private static extern void Tapjoy_RemoveUserTag(string tag) { }

	// RVA: 0x136D204
	private static extern void Tapjoy_TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x136D23C
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

	// RVA: 0x136E9C8
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

	// RVA: 0x1361350
	public static TapjoyComponent FindInstance() { }

	// RVA: 0x136D368
	private void Awake() { }

	// RVA: 0x136D92C
	private void OnApiBindingSet() { }

	// RVA: 0x136D6E4
	private void EnsureSingleton() { }

	// RVA: 0x13613F4
	internal void Reconnect() { }

	// RVA: 0x136D968
	internal bool ConnectManually() { }

	// RVA: 0x1361754
	internal bool ConnectManually(string sdkKey) { }

	// RVA: 0x1361924
	internal bool ConnectManually(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x136D9FC
	private bool ConnectInternal(System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x136E074
	private void OnDestroy() { }

	// RVA: 0x136E2F4
	private void HandleOnConnectSuccess() { }

	// RVA: 0x136E370
	private void HandleOnConnectFailed(int code, string message) { }

	// RVA: 0x136E3EC
	private void HandleOnConnectWarning(int code, string message) { }

	// RVA: 0x136E3F0
	private void Start() { }

	// RVA: 0x136E4F0
	private void Update() { }

	// RVA: 0x136E6EC
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x136E874
	private void OnApplicationQuit() { }

	// RVA: 0x136E928
	private void OnNativeConnectCallback(string commaDelimitedMessage) { }

	// RVA: 0x136E930
	private void OnNativeSetUserIDCallback(string commaDelimitedMessage) { }

	// RVA: 0x136E938
	private void OnNativeCurrencyCallback(string commaDelimitedMessage) { }

	// RVA: 0x136E940
	private void OnNativePlacementCallback(string commaDelimitedMessage) { }

	// RVA: 0x136E9C0
	private void OnNativeOfferwallDiscoverCallback(string commaDelimitedMessage) { }

	// RVA: 0x1366C54
	public static void RemovePlacement(string placementID) { }

	// RVA: 0x1365A08
	public static void RemoveActionRequest(string requestID) { }

	// RVA: 0x136E9D8
	public void .ctor() { }

	// RVA: 0x136E9E0
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

	// RVA: 0x136EA80
	public PlatformSettings get_AndroidSettings() { }

	// RVA: 0x136EA88
	public IosPlatformSettings get_IosSettings() { }

	// RVA: 0x136EA90
	public bool get_AutoConnectEnabled() { }

	// RVA: 0x136EA98
	public void set_AutoConnectEnabled(bool value) { }

	// RVA: 0x136EAB4
	public bool get_DebugEnabled() { }

	// RVA: 0x136EABC
	public void set_DebugEnabled(bool value) { }

	// RVA: 0x136EAD8
	public bool get_Dirty() { }

	// RVA: 0x136EB30
	public void set_Dirty(bool value) { }

	// RVA: 0x136EB60
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

	// RVA: 0x136F490
	private static void .cctor() { }

	// RVA: 0x136F4FC
	public void .ctor() { }

	// RVA: 0x136F504
	internal void <Awake>b__1_0(Scene oldScene, Scene newScene) { }

	// RVA: 0x136F5B0
	internal void <Awake>b__1_1(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x136F64C
	internal void <Awake>b__1_2(Scene scene) { }

	// RVA: 0x136F6D4
	internal int <Awake>b__1_3() { }

	// RVA: 0x136F744
	internal SceneCompat <Awake>b__1_4() { }

	// RVA: 0x136F7C4
	internal SceneCompat <Awake>b__1_5(int index) { }

}

// Namespace: TapjoyUnity.Internal
public sealed class TapjoyUnityInit
{
	// Fields
	private static bool initialized; // 0x0

	// Methods

	// RVA: 0x136EC9C
	private void Awake() { }

	// RVA: 0x136F260
	private static SceneCompat Wrap(Scene scene) { }

	// RVA: 0x136F488
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

	// RVA: 0x136F9D4
	public void .ctor(int <>1__state) { }

	// RVA: 0x1372D14
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1372D18
	private bool MoveNext() { }

	// RVA: 0x1372D38
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1372D40
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1372D80
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1372D88
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1372E28
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

	// RVA: 0x136FA94
	public void .ctor(int <>1__state) { }

	// RVA: 0x1372EC8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13730B8
	private bool MoveNext() { }

	// RVA: 0x1373754
	private void <>m__Finally1() { }

	// RVA: 0x1373690
	private void <>m__Finally2() { }

	// RVA: 0x1373818
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1373820
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1373860
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1373868
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x137391C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public abstract class JSONNode
{
	// Fields
	internal static StringBuilder m_EscapeBuilder; // 0x0

	// Methods

	// RVA: 0x136F84C
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x136F854
	public virtual void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x136F858
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x136F860
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x136F864
	public virtual string get_Value() { }

	// RVA: 0x136F8A8
	public virtual void set_Value(string value) { }

	// RVA: 0x136F8AC
	public virtual int get_Count() { }

	// RVA: 0x136F8B4
	public virtual bool get_IsNumber() { }

	// RVA: 0x136F8BC
	public virtual bool get_IsString() { }

	// RVA: 0x136F8C4
	public virtual bool get_IsBoolean() { }

	// RVA: 0x136F8CC
	public virtual bool get_IsNull() { }

	// RVA: 0x136F8D4
	public virtual bool get_IsArray() { }

	// RVA: 0x136F8DC
	public virtual bool get_IsObject() { }

	// RVA: 0x136F8E4
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x136F8E8
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x136F950
	public virtual JSONNode Remove(string aKey) { }

	// RVA: 0x136F958
	public virtual JSONNode Remove(int aIndex) { }

	// RVA: 0x136F960
	public virtual JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x136F968
	public virtual System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x136FA0C
	public System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_DeepChildren() { }

	// RVA: 0x136FACC
	public override string ToString() { }

	// RVA: 0x136FB64
	public virtual string ToString(int aIndent) { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract JSONNodeType get_Tag() { }

	// RVA: 0x136FC00
	public virtual Double get_AsDouble() { }

	// RVA: 0x136FC44
	public virtual void set_AsDouble(Double value) { }

	// RVA: 0x136FC8C
	public virtual int get_AsInt() { }

	// RVA: 0x136FCC4
	public virtual void set_AsInt(int value) { }

	// RVA: 0x136FCD8
	public virtual float get_AsFloat() { }

	// RVA: 0x136FCFC
	public virtual void set_AsFloat(float value) { }

	// RVA: 0x136FD10
	public virtual bool get_AsBool() { }

	// RVA: 0x136FDF0
	public virtual void set_AsBool(bool value) { }

	// RVA: 0x136FE74
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x136FEF8
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x136FF7C
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x136CFE0
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x1370224
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x1370348
	public static Double op_Implicit(JSONNode d) { }

	// RVA: 0x137048C
	public static JSONNode op_Implicit(float n) { }

	// RVA: 0x137053C
	public static float op_Implicit(JSONNode d) { }

	// RVA: 0x1370680
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x1370730
	public static int op_Implicit(JSONNode d) { }

	// RVA: 0x1370874
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x1370988
	public static bool op_Implicit(JSONNode d) { }

	// RVA: 0x13700A4
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x1370ACC
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x1370B3C
	public override bool Equals(object obj) { }

	// RVA: 0x1370B48
	public override int GetHashCode() { }

	// RVA: 0x1370B50
	internal static string Escape(string aText) { }

	// RVA: 0x1370F34
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	// RVA: 0x1371438
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x1371D0C
	public virtual void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1371D10
	public void SaveToStream(Stream aData) { }

	// RVA: 0x1371D8C
	public void SaveToCompressedStream(Stream aData) { }

	// RVA: 0x1371DE0
	public void SaveToCompressedFile(string aFileName) { }

	// RVA: 0x1371E34
	public string SaveToCompressedBase64() { }

	// RVA: 0x1371E88
	public void SaveToFile(string aFileName) { }

	// RVA: 0x1372068
	public string SaveToBase64() { }

	// RVA: 0x1372298
	public static JSONNode Deserialize(BinaryReader aReader) { }

	// RVA: 0x13727A8
	public static JSONNode LoadFromCompressedFile(string aFileName) { }

	// RVA: 0x13727FC
	public static JSONNode LoadFromCompressedStream(Stream aData) { }

	// RVA: 0x1372850
	public static JSONNode LoadFromCompressedBase64(string aBase64) { }

	// RVA: 0x13728A4
	public static JSONNode LoadFromStream(Stream aData) { }

	// RVA: 0x1372A28
	public static JSONNode LoadFromFile(string aFileName) { }

	// RVA: 0x1372B90
	public static JSONNode LoadFromBase64(string aBase64) { }

	// RVA: 0x1372C84
	protected void .ctor() { }

	// RVA: 0x1372C8C
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

	// RVA: 0x13743EC
	public void .ctor(int <>1__state) { }

	// RVA: 0x13747A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x137481C
	private bool MoveNext() { }

	// RVA: 0x1374A8C
	private void <>m__Finally1() { }

	// RVA: 0x1374AE8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1374AF0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1374B30
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

	// RVA: 0x137433C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1374B38
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1374BB4
	private bool MoveNext() { }

	// RVA: 0x1374E24
	private void <>m__Finally1() { }

	// RVA: 0x1374E80
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1374E88
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1374EC8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1374ED0
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1374F84
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<TapjoyUnity.Internal.SimpleJSON.JSONNode> m_List; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x1373920
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1373928
	public override bool get_IsArray() { }

	// RVA: 0x1373930
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x1373AEC
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1373CF8
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1373DB8
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1373F6C
	public override int get_Count() { }

	// RVA: 0x1373FB8
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x137416C
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x1374248
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x13742B4
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x1374374
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1374418
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1374508
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1371C54
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public JSONNode aNode; // 0x10

	// Methods

	// RVA: 0x1376008
	public void .ctor() { }

	// RVA: 0x1376914
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

	// RVA: 0x1376148
	public void .ctor(int <>1__state) { }

	// RVA: 0x1376A28
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1376AA4
	private bool MoveNext() { }

	// RVA: 0x1376D4C
	private void <>m__Finally1() { }

	// RVA: 0x1376DA8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1376DB0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1376DF0
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

	// RVA: 0x1376098
	public void .ctor(int <>1__state) { }

	// RVA: 0x1376DF8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1376E74
	private bool MoveNext() { }

	// RVA: 0x1377188
	private void <>m__Finally1() { }

	// RVA: 0x13771E4
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13771EC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x137722C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1377234
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13772E8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> m_Dict; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x1374F88
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1374F90
	public override bool get_IsObject() { }

	// RVA: 0x1374F98
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1375164
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1375388
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13754DC
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1375798
	public override int get_Count() { }

	// RVA: 0x13757EC
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1375A88
	public override JSONNode Remove(string aKey) { }

	// RVA: 0x1375B74
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x1375D80
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1376010
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x13760D0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1376174
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1376434
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1371B9C
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x13772EC
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13772F4
	public override bool get_IsString() { }

	// RVA: 0x13772FC
	public override string get_Value() { }

	// RVA: 0x1377304
	public override void set_Value(string value) { }

	// RVA: 0x137002C
	public void .ctor(string aData) { }

	// RVA: 0x137730C
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x137735C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1377404
	public override bool Equals(object obj) { }

	// RVA: 0x1377638
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x137765C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1377664
	public override bool get_IsNumber() { }

	// RVA: 0x137766C
	public override string get_Value() { }

	// RVA: 0x1377678
	public override void set_Value(string value) { }

	// RVA: 0x13776C0
	public override Double get_AsDouble() { }

	// RVA: 0x13776C8
	public override void set_AsDouble(Double value) { }

	// RVA: 0x13702D0
	public void .ctor(Double aData) { }

	// RVA: 0x13776D0
	public void .ctor(string aData) { }

	// RVA: 0x137774C
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x137779C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13777C0
	private static bool IsNumeric(object value) { }

	// RVA: 0x137796C
	public override bool Equals(object obj) { }

	// RVA: 0x1377BB4
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x1377BD4
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1377BDC
	public override bool get_IsBoolean() { }

	// RVA: 0x1377BE4
	public override string get_Value() { }

	// RVA: 0x1377C6C
	public override void set_Value(string value) { }

	// RVA: 0x1377D2C
	public override bool get_AsBool() { }

	// RVA: 0x1377D34
	public override void set_AsBool(bool value) { }

	// RVA: 0x1370918
	public void .ctor(bool aData) { }

	// RVA: 0x1377D3C
	public void .ctor(string aData) { }

	// RVA: 0x1377DB8
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1377E04
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1377E88
	public override bool Equals(object obj) { }

	// RVA: 0x1377F18
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNull
{
	// Methods

	// RVA: 0x1377FA0
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1377FA8
	public override bool get_IsNull() { }

	// RVA: 0x1377FB0
	public override string get_Value() { }

	// RVA: 0x1377FF4
	public override void set_Value(string value) { }

	// RVA: 0x1377FF8
	public override bool get_AsBool() { }

	// RVA: 0x1378000
	public override void set_AsBool(bool value) { }

	// RVA: 0x1378004
	public override bool Equals(object obj) { }

	// RVA: 0x13780B4
	public override int GetHashCode() { }

	// RVA: 0x13780BC
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13780E4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1372720
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x137813C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1373A64
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x13750D0
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x1378144
	private void Set(JSONNode aVal) { }

	// RVA: 0x13781C4
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x1378284
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x137834C
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1378418
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13784F0
	public override void Add(JSONNode aItem) { }

	// RVA: 0x13785B8
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1378690
	public static bool op_Equality(JSONLazyCreator a, object b) { }

	// RVA: 0x13786A0
	public static bool op_Inequality(JSONLazyCreator a, object b) { }

	// RVA: 0x13786B0
	public override bool Equals(object obj) { }

	// RVA: 0x13786C0
	public override int GetHashCode() { }

	// RVA: 0x13786C8
	public override int get_AsInt() { }

	// RVA: 0x13787E0
	public override void set_AsInt(int value) { }

	// RVA: 0x137890C
	public override float get_AsFloat() { }

	// RVA: 0x1378A24
	public override void set_AsFloat(float value) { }

	// RVA: 0x1378B48
	public override Double get_AsDouble() { }

	// RVA: 0x1378C60
	public override void set_AsDouble(Double value) { }

	// RVA: 0x1378D7C
	public override bool get_AsBool() { }

	// RVA: 0x1378E94
	public override void set_AsBool(bool value) { }

	// RVA: 0x1378FB0
	public override JSONArray get_AsArray() { }

	// RVA: 0x1379060
	public override JSONObject get_AsObject() { }

	// RVA: 0x1379110
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x136CF60
	public static JSONNode Parse(string aJSON) { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
public class JsonUtilityCompat
{
	// Methods

	// RVA: 0x1379168
	internal static string ToJson(object obj) { }

	// RVA: 0x1379214
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

	// RVA: 0x136F3B0
	public void .ctor(object scene, bool valid, int buildIndex, string name, string path) { }

	// RVA: 0x137921C
	public override int GetHashCode() { }

	// RVA: 0x1379224
	internal bool IsValid() { }

	// RVA: 0x137922C
	internal int get_buildIndex() { }

	// RVA: 0x1379364
	internal string get_name() { }

	// RVA: 0x137936C
	internal string get_path() { }

	// RVA: 0x1379374
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

	// RVA: 0x1379378
	internal static int get_sceneCount() { }

	// RVA: 0x13793FC
	internal static SceneCompat GetActiveScene() { }

	// RVA: 0x13794C4
	internal static SceneCompat GetSceneAt(int index) { }

	// RVA: 0x137959C
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

	// RVA: 0x13646D0
	internal static UInt32 ComputeStringHash(string s) { }

}


