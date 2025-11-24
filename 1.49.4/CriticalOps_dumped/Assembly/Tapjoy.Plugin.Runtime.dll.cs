// Namespace: 
internal class <Module>
{}

// Namespace: 
public static class EntryPointExtensions
{
	// Fields
	public static readonly System.Collections.Generic.Dictionary<TapjoyUnity.TJEntryPoint,System.String> entryPointValues; // 0x0

	// Methods

	// RVA: 0x13517A0
	public static string GetValue(TJEntryPoint entryPoint) { }

	// RVA: 0x135185C
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

	// RVA: 0x1351B14
	private static MonoScriptData Get() { }

	// RVA: 0x1351C18
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction
{
	// Methods

	// RVA: 0x1351C20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1351CC0
	public virtual void Invoke() { }

	// RVA: 0x1351CD4
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1351D2C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1, T2 arg2) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3, T4>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual TResult Invoke() { }

	// RVA: 0x30A1970
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x315B3A8
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual TResult Invoke(T1 arg1) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x315B3A8
	public virtual TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectSuccessHandler
{
	// Methods

	// RVA: 0x1355434
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13554D4
	public virtual void Invoke() { }

	// RVA: 0x13554E8
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1355540
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectFailedHandler
{
	// Methods

	// RVA: 0x135554C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13555F0
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x1355604
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x13556C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectWarningHandler
{
	// Methods

	// RVA: 0x13556D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355774
	public virtual void Invoke(int code, string message) { }

	// RVA: 0x1355788
	public virtual IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x1355848
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDSuccessHandler
{
	// Methods

	// RVA: 0x1355854
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13558F4
	public virtual void Invoke() { }

	// RVA: 0x1355908
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1355960
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailedHandler
{
	// Methods

	// RVA: 0x135596C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355A10
	public virtual void Invoke(int code, string errorMessage) { }

	// RVA: 0x1355A24
	public virtual IAsyncResult BeginInvoke(int code, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1355AE4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailureHandler
{
	// Methods

	// RVA: 0x1355AF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355BA4
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1355BB8
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1355C08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseHandler
{
	// Methods

	// RVA: 0x1355C14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355CD0
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x1355CE4
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x1355DA8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseFailureHandler
{
	// Methods

	// RVA: 0x1355DB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355E68
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1355E7C
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1355ECC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseHandler
{
	// Methods

	// RVA: 0x1355ED8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1355F94
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x1355FA8
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x135606C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x1356078
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135612C
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1356140
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1356190
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseHandler
{
	// Methods

	// RVA: 0x135619C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1356258
	public virtual void Invoke(string currencyName, int balance) { }

	// RVA: 0x135626C
	public virtual IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x1356330
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseFailureHandler
{
	// Methods

	// RVA: 0x135633C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13563F0
	public virtual void Invoke(string errorMessage) { }

	// RVA: 0x1356404
	public virtual IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1356454
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnEarnedCurrencyHandler
{
	// Methods

	// RVA: 0x1356460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135651C
	public virtual void Invoke(string currencyName, int amount) { }

	// RVA: 0x1356530
	public virtual IAsyncResult BeginInvoke(string currencyName, int amount, AsyncCallback callback, object object) { }

	// RVA: 0x13565F4
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

	// RVA: 0x1351D38
	public static string get_Version() { }

	// RVA: 0x1351DD0
	public static bool get_IsConnected() { }

	// RVA: 0x1351E1C
	public static void set_IsConnected(bool value) { }

	// RVA: 0x1351E74
	public static void Connect() { }

	// RVA: 0x135226C
	public static void Connect(string sdkKey) { }

	// RVA: 0x135242C
	public static void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x1352750
	public static void SetDebugEnabled(bool enable) { }

	// RVA: 0x135288C
	public static void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x13528C4
	public static bool GetOptOutAdvertisingID() { }

	// RVA: 0x13528EC
	public static void ActionComplete(string actionID) { }

	// RVA: 0x13528F0
	public static void SetUserID(string userId) { }

	// RVA: 0x1352928
	public static string GetUserID() { }

	// RVA: 0x1352950
	public static void SetCustomParameter(string customParam) { }

	// RVA: 0x1352988
	public static string GetCustomParameter() { }

	// RVA: 0x13529B0
	public static void SetUserLevel(int userLevel) { }

	// RVA: 0x13529E8
	public static int GetUserLevel() { }

	// RVA: 0x1352A10
	public static void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x1352A48
	public static int GetMaxLevel() { }

	// RVA: 0x1352A70
	public static void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1352AA8
	public static TJSegment GetUserSegment() { }

	// RVA: 0x1352AD0
	public static Double GetScreenScale() { }

	// RVA: 0x1352AF8
	public static void ClearUserTags() { }

	// RVA: 0x1352B20
	public static System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1352B48
	public static void AddUserTag(string tag) { }

	// RVA: 0x1352B80
	public static void RemoveUserTag(string tag) { }

	// RVA: 0x1352BB8
	public static void TrackPurchase(string currencyCode, Double productPrice) { }

	// RVA: 0x1352C00
	public static void TrackPurchase(string productId, string currencyCode, Double productPrice, string campaignId) { }

	// RVA: 0x1352C48
	public static void TrackPurchaseInGooglePlayStore(string skuDetails, string purchaseData, string dataSignature, string campaignId) { }

	// RVA: 0x1352C4C
	public static void TrackPurchaseInAppleAppStore(string productId, string currencyCode, Double productPrice, string transactionId, string campaignId) { }

	// RVA: 0x1352C94
	public static void AwardCurrency(int amount) { }

	// RVA: 0x1352CCC
	public static void GetCurrencyBalance() { }

	// RVA: 0x1352CF4
	public static void SpendCurrency(int amount) { }

	// RVA: 0x1352D2C
	public static string GetSupportURL() { }

	// RVA: 0x1352D70
	public static string GetSupportURL(string currencyID) { }

	// RVA: 0x1352DB4
	public static void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x1352DDC
	public static void add_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x1352EB0
	public static void remove_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x1352F84
	internal static void add_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x1353058
	internal static void remove_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x135312C
	public static void add_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x1353200
	public static void remove_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x13532D4
	internal static void add_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x13533A8
	internal static void remove_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x135347C
	public static void add_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x1353550
	public static void remove_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x1353624
	internal static void add_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x13536F8
	internal static void remove_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x13537CC
	internal static void DispatchConnectEvent(string connectCallbackMethod) { }

	// RVA: 0x1353B6C
	public static void add_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x1353C40
	public static void remove_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x1353D14
	public static void add_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x1353DE8
	public static void remove_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x1353EBC
	public static void add_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x1353F90
	public static void remove_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x1354064
	internal static void DispatchSetUserIDEvent(string commaDelimitedMessage) { }

	// RVA: 0x13542C4
	public static void add_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x1354398
	public static void remove_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x135446C
	public static void add_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x1354540
	public static void remove_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x1354614
	public static void add_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x13546E8
	public static void remove_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x13547BC
	public static void add_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x1354890
	public static void remove_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x1354964
	public static void add_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x1354A38
	public static void remove_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x1354B0C
	public static void add_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x1354BE0
	public static void remove_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x1354CB4
	public static void add_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x1354D88
	public static void remove_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x1354E5C
	internal static void DispatchCurrencyEvent(string commaDelimitedMessage) { }

	// RVA: 0x135542C
	public void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJActionRequest
{
	// Fields
	public string requestID; // 0x10
	public string token; // 0x18

	// Methods

	// RVA: 0x1356600
	protected override void Finalize() { }

	// RVA: 0x13567AC
	internal void .ctor(string requestID, string token) { }

	// RVA: 0x13567FC
	public void Completed() { }

	// RVA: 0x1356834
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

	// RVA: 0x13571D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1357278
	public virtual void Invoke() { }

	// RVA: 0x135728C
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x13572E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x13572F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1357394
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x13573A8
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1357468
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x1357474
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1357514
	public virtual void Invoke() { }

	// RVA: 0x1357528
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1357580
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentErrorHandler
{
	// Methods

	// RVA: 0x135758C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1357630
	public virtual void Invoke(int code, string error) { }

	// RVA: 0x1357644
	public virtual IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1357704
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

	// RVA: 0x135686C
	public void .ctor() { }

	// RVA: 0x1356874
	public static void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x13568BC
	public static void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1356924
	public static void ShowOfferwallDiscover() { }

	// RVA: 0x135694C
	public static void DestroyOfferwallDiscover() { }

	// RVA: 0x1356974
	internal static void DispatchOfferwallDiscoverEvent(string commaDelimitedMessage) { }

	// RVA: 0x1356B48
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1356C14
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1356CE0
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1356DB4
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1356E88
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1356F5C
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1357030
	public static void add_OnContentError(OnContentErrorHandler value) { }

	// RVA: 0x1357104
	public static void remove_OnContentError(OnContentErrorHandler value) { }

}

// Namespace: 
public sealed class OnRequestSuccessHandler
{
	// Methods

	// RVA: 0x1359D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1359E50
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x1359E64
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1359EB4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler
{
	// Methods

	// RVA: 0x1359EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1359FE4
	public virtual void Invoke(TJPlacement placement, string error) { }

	// RVA: 0x1359FF8
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, string error, AsyncCallback callback, object object) { }

	// RVA: 0x135A054
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler
{
	// Methods

	// RVA: 0x135A060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A180
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135A194
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135A1E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentShowHandler
{
	// Methods

	// RVA: 0x135A1F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A310
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135A324
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135A374
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentDismissHandler
{
	// Methods

	// RVA: 0x135A380
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A4A0
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135A4B4
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135A504
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnClickHandler
{
	// Methods

	// RVA: 0x135A510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A630
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135A644
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135A694
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnPurchaseRequestHandler
{
	// Methods

	// RVA: 0x135A6A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A7C4
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string productId) { }

	// RVA: 0x135A7D8
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string productId, AsyncCallback callback, object object) { }

	// RVA: 0x135A834
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRewardRequestHandler
{
	// Methods

	// RVA: 0x135A840
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135A964
	public virtual void Invoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity) { }

	// RVA: 0x135A978
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity, AsyncCallback callback, object object) { }

	// RVA: 0x135AA50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceSuccessHandler
{
	// Methods

	// RVA: 0x135AA5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135AB7C
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135AB90
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135ABE0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceFailureHandler
{
	// Methods

	// RVA: 0x135ABEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135AD10
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x135AD24
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x135ADF4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredSuccessHandler
{
	// Methods

	// RVA: 0x135AE00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135AF20
	public virtual void Invoke(TJPlacement placement) { }

	// RVA: 0x135AF34
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x135AF84
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredFailureHandler
{
	// Methods

	// RVA: 0x135AF90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135B0B4
	public virtual void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x135B0C8
	public virtual IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x135B198
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

	// RVA: 0x1357710
	private void .ctor(string placementName) { }

	// RVA: 0x135784C
	protected override void Finalize() { }

	// RVA: 0x13579F0
	public static TJPlacement CreatePlacement(string placementName) { }

	// RVA: 0x1357A54
	public static void DismissContent() { }

	// RVA: 0x1357A7C
	public void RequestContent() { }

	// RVA: 0x1357B70
	public void ShowContent() { }

	// RVA: 0x1357C44
	public bool IsContentAvailable() { }

	// RVA: 0x1357C7C
	public bool IsContentReady() { }

	// RVA: 0x1357CB4
	public string GetName() { }

	// RVA: 0x1357CBC
	public void SetEntryPoint(TJEntryPoint entryPoint) { }

	// RVA: 0x1357CFC
	public void SetCurrencyBalance(string currencyId, int balance) { }

	// RVA: 0x1357D4C
	public int GetCurrencyBalance(string currencyId) { }

	// RVA: 0x1357D8C
	public void SetRequiredAmount(string currencyId, int amount) { }

	// RVA: 0x1357DDC
	public int GetRequiredAmount(string currencyId) { }

	// RVA: 0x1357E1C
	public static void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1357F00
	public static void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1357FE4
	public static void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13580C8
	public static void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x13581AC
	public static void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1358290
	public static void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1358374
	public static void add_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1358458
	public static void remove_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x135853C
	public static void add_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1358620
	public static void remove_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1358704
	public static void add_OnClick(OnClickHandler value) { }

	// RVA: 0x13587E8
	public static void remove_OnClick(OnClickHandler value) { }

	// RVA: 0x13588CC
	public static void add_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x13589B0
	public static void remove_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x1358A94
	public static void add_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x1358B78
	public static void remove_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x1358C5C
	public static void add_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x1358D40
	public static void remove_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x1358E24
	public static void add_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1358F08
	public static void remove_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1358FEC
	public static void add_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x13590D0
	public static void remove_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x13591B4
	public static void add_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x1359298
	public static void remove_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x135937C
	internal static void DispatchPlacementEvent(string commaDelimitedMessage) { }

	// RVA: 0x1359C94
	private static void .cctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJPrivacyPolicy
{
	// Methods

	// RVA: 0x135B1A4
	private void .ctor() { }

	// RVA: 0x135B1D0
	public static TJPrivacyPolicy GetPrivacyPolicy() { }

	// RVA: 0x135B240
	public void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x135B274
	public TJStatus GetSubjectToGDPR() { }

	// RVA: 0x135B298
	public void SetUserConsent(TJStatus consent) { }

	// RVA: 0x135B2CC
	public TJStatus GetUserConsent() { }

	// RVA: 0x135B2F0
	public void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x135B328
	public TJStatus GetBelowConsentAge() { }

	// RVA: 0x135B350
	public void SetUSPrivacy(string privacyPolicy) { }

	// RVA: 0x135B388
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

	// RVA: 0x135B600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135B6A0
	public virtual void Invoke() { }

	// RVA: 0x135B6B4
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x135B70C
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

	// RVA: 0x1352784
	public static ApiBinding get_Instance() { }

	// RVA: 0x135B418
	protected static void SetInstance(ApiBinding value) { }

	// RVA: 0x135B4F4
	internal static void set_OnInstanceSet(OnInstanceSetHandler value) { }

	// RVA: 0x135B5C4
	protected void .ctor(string name) { }

	// RVA: 0x135B5F8
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

	// RVA: 0x135B3B0
	public void .ctor() { }

	// RVA: 0x135B718
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x135B71C
	public override string GetSDKVersion() { }

	// RVA: 0x135B760
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x135B764
	public override void ActivateUnitySupport() { }

	// RVA: 0x135B768
	public override void GetPrivacyPolicy() { }

	// RVA: 0x135B76C
	public override void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x135B770
	public override int GetSubjectToGDPR() { }

	// RVA: 0x135B778
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x135B77C
	public override int GetUserConsent() { }

	// RVA: 0x135B784
	public override void SetBelowConsentAge(TJStatus isBelowConsentAge) { }

	// RVA: 0x135B788
	public override int GetBelowConsentAge() { }

	// RVA: 0x135B790
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x135B794
	public override string GetUSPrivacy() { }

	// RVA: 0x135B7D8
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x135B7DC
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x135B7E4
	public override void GetCurrencyBalance() { }

	// RVA: 0x135B7E8
	public override void SpendCurrency(int amount) { }

	// RVA: 0x135B7EC
	public override void AwardCurrency(int amount) { }

	// RVA: 0x135B7F0
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x135B7F4
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x135B7F8
	public override void DismissPlacementContent() { }

	// RVA: 0x135B7FC
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x135B800
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x135B804
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x135B80C
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x135B814
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x135B818
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x135B820
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x135B824
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x135B82C
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x135B830
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x135B834
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x135B838
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x135B83C
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x135B840
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x135B844
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x135B848
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x135B84C
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x135B850
	public override void SetUserID(string userId) { }

	// RVA: 0x135B854
	public override string GetUserID() { }

	// RVA: 0x135B898
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x135B89C
	public override string GetCustomParameter() { }

	// RVA: 0x135B8E0
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x135B8E4
	public override int GetUserLevel() { }

	// RVA: 0x135B8EC
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x135B8F0
	public override int GetMaxLevel() { }

	// RVA: 0x135B8F8
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x135B8FC
	public override int GetUserSegment() { }

	// RVA: 0x135B904
	public override Double GetScreenScale() { }

	// RVA: 0x135B90C
	public override void ClearUserTags() { }

	// RVA: 0x135B910
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x135B918
	public override void AddUserTag(string tag) { }

	// RVA: 0x135B91C
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x135B920
	public override void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal static class ForegroundRealtimeClock
{
	// Fields
	private static float realtimeSpentWhilePaused; // 0x0
	private static float realtimePaused; // 0x4

	// Methods

	// RVA: 0x135B924
	internal static void OnApplicationPause(bool paused) { }

	// RVA: 0x135B9C8
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

	// RVA: 0x135BA20
	public static void OnActiveSceneChanged(SceneCompat oldScene, SceneCompat newScene) { }

	// RVA: 0x135BAB0
	public static void OnSceneLoaded(SceneCompat scene, int loadMode) { }

	// RVA: 0x135BB3C
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

	// RVA: 0x135BBBC
	public void .ctor() { }

	// RVA: 0x135BC28
	public string get_SdkKey() { }

	// RVA: 0x135BC30
	public void set_SdkKey(string value) { }

	// RVA: 0x135BC84
	public bool get_DisableAdvertisingId() { }

	// RVA: 0x135BC8C
	public void set_DisableAdvertisingId(bool value) { }

	// RVA: 0x135BCA8
	public bool get_Valid() { }

	// RVA: 0x135BD00
	public bool get_Dirty() { }

	// RVA: 0x135BD08
	public void set_Dirty(bool value) { }

}

// Namespace: TapjoyUnity.Internal
[Serializable]
public class IosPlatformSettings
{
	// Methods

	// RVA: 0x135BD10
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal
public sealed class ApiBindingIos
{
	// Methods

	// RVA: 0x135BD7C
	public static void Install() { }

	// RVA: 0x135BEFC
	private void .ctor() { }

	// RVA: 0x135BFB8
	public override void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x135C66C
	private void transferDictionaryToObjectiveCWithName(System.Collections.Generic.Dictionary<System.String,System.Object> dictionary, string dictionaryName) { }

	// RVA: 0x135CD20
	public override string GetSDKVersion() { }

	// RVA: 0x135CD88
	public override void SetDebugEnabled(bool enabled) { }

	// RVA: 0x135CD94
	public override void GetPrivacyPolicy() { }

	// RVA: 0x135CD9C
	public override void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x135CDA8
	public override int GetSubjectToGDPR() { }

	// RVA: 0x135CDB0
	public override void SetUserConsent(TJStatus consent) { }

	// RVA: 0x135CDBC
	public override int GetUserConsent() { }

	// RVA: 0x135CDC4
	public override void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x135CDD0
	public override int GetBelowConsentAge() { }

	// RVA: 0x135CDD8
	public override void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x135CE2C
	public override string GetUSPrivacy() { }

	// RVA: 0x135CE94
	public override void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x135CE98
	public override bool GetOptOutAdvertisingID() { }

	// RVA: 0x135CEA0
	public override void ActivateUnitySupport() { }

	// RVA: 0x135CEA4
	public override void GetCurrencyBalance() { }

	// RVA: 0x135CEAC
	public override void SpendCurrency(int amount) { }

	// RVA: 0x135CEB8
	public override void AwardCurrency(int amount) { }

	// RVA: 0x135CEC4
	public override void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x135CECC
	public override void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x135CF60
	public override void DismissPlacementContent() { }

	// RVA: 0x135CF68
	public override void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x135CFBC
	public override void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x135D010
	public override bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x135D084
	public override bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x135D0F8
	public override void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x135D1B8
	public override int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x135D274
	public override void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x135D334
	public override int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x135D3F0
	public override void ActionRequestCompleted(string requestId) { }

	// RVA: 0x135D444
	public override void ActionRequestCancelled(string requestId) { }

	// RVA: 0x135D498
	public override void RemovePlacement(string placementGuid) { }

	// RVA: 0x135D4EC
	public override void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x135D570
	public override void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x135D634
	public override void ShowOfferwallDiscover() { }

	// RVA: 0x135D654
	public override void DestroyOfferwallDiscover() { }

	// RVA: 0x135D674
	public override void RemoveActionRequest(string requestID) { }

	// RVA: 0x135D6C8
	public override void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x135D84C
	public override void SetUserID(string userID) { }

	// RVA: 0x135D8A0
	public override string GetUserID() { }

	// RVA: 0x135D908
	public override void SetCustomParameter(string customParam) { }

	// RVA: 0x135D95C
	public override string GetCustomParameter() { }

	// RVA: 0x135D9C4
	public override void SetUserLevel(int userLevel) { }

	// RVA: 0x135D9D0
	public override int GetUserLevel() { }

	// RVA: 0x135D9D8
	public override void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x135D9E4
	public override int GetMaxLevel() { }

	// RVA: 0x135D9EC
	public override void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x135D9F8
	public override int GetUserSegment() { }

	// RVA: 0x135DA00
	public override Double GetScreenScale() { }

	// RVA: 0x135DA08
	public override void ClearUserTags() { }

	// RVA: 0x135DA10
	public override System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x135DDF0
	public override void AddUserTag(string tag) { }

	// RVA: 0x135DE44
	public override void RemoveUserTag(string tag) { }

	// RVA: 0x135DE98
	public override void TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x135BF90
	private static extern void Tapjoy_SetUnityVersion(string version) { }

	// RVA: 0x135CCF8
	private static extern void Tapjoy_Connect(string sdkKey) { }

	// RVA: 0x135CC8C
	private static extern void Tapjoy_SetKeyToValueInDictionary(string key, string valueToSet, string dictionaryName) { }

	// RVA: 0x135CC20
	private static extern void Tapjoy_SetKeyToDictionaryRefValueInDictionary(string key, string dictionaryNameToSet, string dictionaryNameToSetTo) { }

	// RVA: 0x135CD54
	private static extern string Tapjoy_GetSDKVersion() { }

	// RVA: 0x135CD90
	private static extern void Tapjoy_SetDebugEnabled(bool enabled) { }

	// RVA: 0x135CD98
	private static extern void Tapjoy_GetPrivacyPolicy() { }

	// RVA: 0x135CDA4
	private static extern void Tapjoy_SetSubjectToGDPRStatus(int gdprApplicable) { }

	// RVA: 0x135CDAC
	private static extern int Tapjoy_GetSubjectToGDPRStatus() { }

	// RVA: 0x135CDB8
	private static extern void Tapjoy_SetUserConsentStatus(int consent) { }

	// RVA: 0x135CDC0
	private static extern int Tapjoy_GetUserConsentStatus() { }

	// RVA: 0x135CDCC
	private static extern void Tapjoy_SetBelowConsentAgeStatus(int belowConsentAge) { }

	// RVA: 0x135CDD4
	private static extern int Tapjoy_GetBelowConsentAgeStatus() { }

	// RVA: 0x135CE04
	private static extern void Tapjoy_SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x135CE60
	private static extern string Tapjoy_GetUSPrivacy() { }

	// RVA: 0x135CEA8
	private static extern void Tapjoy_GetCurrencyBalance() { }

	// RVA: 0x135CEB4
	private static extern void Tapjoy_SpendCurrency(int amount) { }

	// RVA: 0x135CEC0
	private static extern void Tapjoy_AwardCurrency(int amount) { }

	// RVA: 0x135CEC8
	private static extern void Tapjoy_ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x135CF18
	private static extern void Tapjoy_CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x135CF64
	private static extern void Tapjoy_DismissPlacementContent() { }

	// RVA: 0x135CF94
	private static extern void Tapjoy_RequestPlacementContent(string placementGuid) { }

	// RVA: 0x135CFE8
	private static extern void Tapjoy_ShowPlacementContent(string placementGuid) { }

	// RVA: 0x135D0C0
	private static extern bool Tapjoy_IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x135D04C
	private static extern bool Tapjoy_IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x135D154
	private static extern int Tapjoy_SetPlacementBalance(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x135D218
	private static extern int Tapjoy_GetPlacementBalance(string placementGuid, string currencyId) { }

	// RVA: 0x135D2D0
	private static extern int Tapjoy_SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x135D394
	private static extern int Tapjoy_GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x135D528
	private static extern bool Tapjoy_RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x135D5CC
	private static extern bool Tapjoy_RequestOfferwallDiscoverAtPosition(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x135D638
	private static extern bool Tapjoy_ShowOfferwallDiscover() { }

	// RVA: 0x135D658
	private static extern bool Tapjoy_DestroyOfferwallDiscover() { }

	// RVA: 0x135D41C
	private static extern void Tapjoy_ActionRequestCompleted(string requestId) { }

	// RVA: 0x135D470
	private static extern void Tapjoy_ActionRequestCancelled(string requestId) { }

	// RVA: 0x135D4C4
	private static extern void Tapjoy_RemovePlacement(string placementGuid) { }

	// RVA: 0x135D6A0
	private static extern void Tapjoy_RemoveActionRequest(string requestId) { }

	// RVA: 0x135D804
	private static extern void Tapjoy_SetEntryPoint(string placementGuid, string entryPoint) { }

	// RVA: 0x135D878
	private static extern void Tapjoy_SetUserID(string userId) { }

	// RVA: 0x135D8D4
	private static extern string Tapjoy_GetUserID() { }

	// RVA: 0x135D934
	private static extern void Tapjoy_SetCustomParameter(string customParam) { }

	// RVA: 0x135D990
	private static extern string Tapjoy_GetCustomParameter() { }

	// RVA: 0x135D9CC
	private static extern void Tapjoy_SetUserLevel(int userLevel) { }

	// RVA: 0x135D9D4
	private static extern int Tapjoy_GetUserLevel() { }

	// RVA: 0x135D9E0
	private static extern void Tapjoy_SetMaxLevel(int maxLevel) { }

	// RVA: 0x135D9E8
	private static extern int Tapjoy_GetMaxLevel() { }

	// RVA: 0x135D9F4
	private static extern void Tapjoy_SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x135D9FC
	private static extern int Tapjoy_GetUserSegment() { }

	// RVA: 0x135DA04
	private static extern Double Tapjoy_GetScreenScale() { }

	// RVA: 0x135DA0C
	private static extern void Tapjoy_ClearUserTags() { }

	// RVA: 0x135DBFC
	private static extern string Tapjoy_GetUserTags() { }

	// RVA: 0x135DE1C
	private static extern void Tapjoy_AddUserTag(string tag) { }

	// RVA: 0x135DE70
	private static extern void Tapjoy_RemoveUserTag(string tag) { }

	// RVA: 0x135DED4
	private static extern void Tapjoy_TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x135DF0C
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

	// RVA: 0x135F698
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

	// RVA: 0x1352020
	public static TapjoyComponent FindInstance() { }

	// RVA: 0x135E038
	private void Awake() { }

	// RVA: 0x135E5FC
	private void OnApiBindingSet() { }

	// RVA: 0x135E3B4
	private void EnsureSingleton() { }

	// RVA: 0x13520C4
	internal void Reconnect() { }

	// RVA: 0x135E638
	internal bool ConnectManually() { }

	// RVA: 0x1352424
	internal bool ConnectManually(string sdkKey) { }

	// RVA: 0x13525F4
	internal bool ConnectManually(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x135E6CC
	private bool ConnectInternal(System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x135ED44
	private void OnDestroy() { }

	// RVA: 0x135EFC4
	private void HandleOnConnectSuccess() { }

	// RVA: 0x135F040
	private void HandleOnConnectFailed(int code, string message) { }

	// RVA: 0x135F0BC
	private void HandleOnConnectWarning(int code, string message) { }

	// RVA: 0x135F0C0
	private void Start() { }

	// RVA: 0x135F1C0
	private void Update() { }

	// RVA: 0x135F3BC
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x135F544
	private void OnApplicationQuit() { }

	// RVA: 0x135F5F8
	private void OnNativeConnectCallback(string commaDelimitedMessage) { }

	// RVA: 0x135F600
	private void OnNativeSetUserIDCallback(string commaDelimitedMessage) { }

	// RVA: 0x135F608
	private void OnNativeCurrencyCallback(string commaDelimitedMessage) { }

	// RVA: 0x135F610
	private void OnNativePlacementCallback(string commaDelimitedMessage) { }

	// RVA: 0x135F690
	private void OnNativeOfferwallDiscoverCallback(string commaDelimitedMessage) { }

	// RVA: 0x1357924
	public static void RemovePlacement(string placementID) { }

	// RVA: 0x13566D8
	public static void RemoveActionRequest(string requestID) { }

	// RVA: 0x135F6A8
	public void .ctor() { }

	// RVA: 0x135F6B0
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

	// RVA: 0x135F750
	public PlatformSettings get_AndroidSettings() { }

	// RVA: 0x135F758
	public IosPlatformSettings get_IosSettings() { }

	// RVA: 0x135F760
	public bool get_AutoConnectEnabled() { }

	// RVA: 0x135F768
	public void set_AutoConnectEnabled(bool value) { }

	// RVA: 0x135F784
	public bool get_DebugEnabled() { }

	// RVA: 0x135F78C
	public void set_DebugEnabled(bool value) { }

	// RVA: 0x135F7A8
	public bool get_Dirty() { }

	// RVA: 0x135F800
	public void set_Dirty(bool value) { }

	// RVA: 0x135F830
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

	// RVA: 0x1360160
	private static void .cctor() { }

	// RVA: 0x13601CC
	public void .ctor() { }

	// RVA: 0x13601D4
	internal void <Awake>b__1_0(Scene oldScene, Scene newScene) { }

	// RVA: 0x1360280
	internal void <Awake>b__1_1(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x136031C
	internal void <Awake>b__1_2(Scene scene) { }

	// RVA: 0x13603A4
	internal int <Awake>b__1_3() { }

	// RVA: 0x1360414
	internal SceneCompat <Awake>b__1_4() { }

	// RVA: 0x1360494
	internal SceneCompat <Awake>b__1_5(int index) { }

}

// Namespace: TapjoyUnity.Internal
public sealed class TapjoyUnityInit
{
	// Fields
	private static bool initialized; // 0x0

	// Methods

	// RVA: 0x135F96C
	private void Awake() { }

	// RVA: 0x135FF30
	private static SceneCompat Wrap(Scene scene) { }

	// RVA: 0x1360158
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

	// RVA: 0x13606A4
	public void .ctor(int <>1__state) { }

	// RVA: 0x13639E4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13639E8
	private bool MoveNext() { }

	// RVA: 0x1363A08
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1363A10
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1363A50
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1363A58
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1363AF8
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

	// RVA: 0x1360764
	public void .ctor(int <>1__state) { }

	// RVA: 0x1363B98
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1363D88
	private bool MoveNext() { }

	// RVA: 0x1364424
	private void <>m__Finally1() { }

	// RVA: 0x1364360
	private void <>m__Finally2() { }

	// RVA: 0x13644E8
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13644F0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1364530
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1364538
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13645EC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public abstract class JSONNode
{
	// Fields
	internal static StringBuilder m_EscapeBuilder; // 0x0

	// Methods

	// RVA: 0x136051C
	public virtual JSONNode get_Item(int aIndex) { }

	// RVA: 0x1360524
	public virtual void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1360528
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x1360530
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1360534
	public virtual string get_Value() { }

	// RVA: 0x1360578
	public virtual void set_Value(string value) { }

	// RVA: 0x136057C
	public virtual int get_Count() { }

	// RVA: 0x1360584
	public virtual bool get_IsNumber() { }

	// RVA: 0x136058C
	public virtual bool get_IsString() { }

	// RVA: 0x1360594
	public virtual bool get_IsBoolean() { }

	// RVA: 0x136059C
	public virtual bool get_IsNull() { }

	// RVA: 0x13605A4
	public virtual bool get_IsArray() { }

	// RVA: 0x13605AC
	public virtual bool get_IsObject() { }

	// RVA: 0x13605B4
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x13605B8
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x1360620
	public virtual JSONNode Remove(string aKey) { }

	// RVA: 0x1360628
	public virtual JSONNode Remove(int aIndex) { }

	// RVA: 0x1360630
	public virtual JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1360638
	public virtual System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x13606DC
	public System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_DeepChildren() { }

	// RVA: 0x136079C
	public override string ToString() { }

	// RVA: 0x1360834
	public virtual string ToString(int aIndent) { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract JSONNodeType get_Tag() { }

	// RVA: 0x13608D0
	public virtual Double get_AsDouble() { }

	// RVA: 0x1360914
	public virtual void set_AsDouble(Double value) { }

	// RVA: 0x136095C
	public virtual int get_AsInt() { }

	// RVA: 0x1360994
	public virtual void set_AsInt(int value) { }

	// RVA: 0x13609A8
	public virtual float get_AsFloat() { }

	// RVA: 0x13609CC
	public virtual void set_AsFloat(float value) { }

	// RVA: 0x13609E0
	public virtual bool get_AsBool() { }

	// RVA: 0x1360AC0
	public virtual void set_AsBool(bool value) { }

	// RVA: 0x1360B44
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x1360BC8
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x1360C4C
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x135DCB0
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x1360EF4
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x1361018
	public static Double op_Implicit(JSONNode d) { }

	// RVA: 0x136115C
	public static JSONNode op_Implicit(float n) { }

	// RVA: 0x136120C
	public static float op_Implicit(JSONNode d) { }

	// RVA: 0x1361350
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x1361400
	public static int op_Implicit(JSONNode d) { }

	// RVA: 0x1361544
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x1361658
	public static bool op_Implicit(JSONNode d) { }

	// RVA: 0x1360D74
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x136179C
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x136180C
	public override bool Equals(object obj) { }

	// RVA: 0x1361818
	public override int GetHashCode() { }

	// RVA: 0x1361820
	internal static string Escape(string aText) { }

	// RVA: 0x1361C04
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	// RVA: 0x1362108
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x13629DC
	public virtual void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13629E0
	public void SaveToStream(Stream aData) { }

	// RVA: 0x1362A5C
	public void SaveToCompressedStream(Stream aData) { }

	// RVA: 0x1362AB0
	public void SaveToCompressedFile(string aFileName) { }

	// RVA: 0x1362B04
	public string SaveToCompressedBase64() { }

	// RVA: 0x1362B58
	public void SaveToFile(string aFileName) { }

	// RVA: 0x1362D38
	public string SaveToBase64() { }

	// RVA: 0x1362F68
	public static JSONNode Deserialize(BinaryReader aReader) { }

	// RVA: 0x1363478
	public static JSONNode LoadFromCompressedFile(string aFileName) { }

	// RVA: 0x13634CC
	public static JSONNode LoadFromCompressedStream(Stream aData) { }

	// RVA: 0x1363520
	public static JSONNode LoadFromCompressedBase64(string aBase64) { }

	// RVA: 0x1363574
	public static JSONNode LoadFromStream(Stream aData) { }

	// RVA: 0x13636F8
	public static JSONNode LoadFromFile(string aFileName) { }

	// RVA: 0x1363860
	public static JSONNode LoadFromBase64(string aBase64) { }

	// RVA: 0x1363954
	protected void .ctor() { }

	// RVA: 0x136395C
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

	// RVA: 0x13650BC
	public void .ctor(int <>1__state) { }

	// RVA: 0x1365470
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13654EC
	private bool MoveNext() { }

	// RVA: 0x136575C
	private void <>m__Finally1() { }

	// RVA: 0x13657B8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x13657C0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1365800
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

	// RVA: 0x136500C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1365808
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1365884
	private bool MoveNext() { }

	// RVA: 0x1365AF4
	private void <>m__Finally1() { }

	// RVA: 0x1365B50
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1365B58
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1365B98
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1365BA0
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1365C54
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<TapjoyUnity.Internal.SimpleJSON.JSONNode> m_List; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x13645F0
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13645F8
	public override bool get_IsArray() { }

	// RVA: 0x1364600
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13647BC
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x13649C8
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1364A88
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1364C3C
	public override int get_Count() { }

	// RVA: 0x1364C88
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1364E3C
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x1364F18
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1364F84
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x1365044
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13650E8
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13651D8
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1362924
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public JSONNode aNode; // 0x10

	// Methods

	// RVA: 0x1366CD8
	public void .ctor() { }

	// RVA: 0x13675E4
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

	// RVA: 0x1366E18
	public void .ctor(int <>1__state) { }

	// RVA: 0x13676F8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1367774
	private bool MoveNext() { }

	// RVA: 0x1367A1C
	private void <>m__Finally1() { }

	// RVA: 0x1367A78
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1367A80
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1367AC0
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

	// RVA: 0x1366D68
	public void .ctor(int <>1__state) { }

	// RVA: 0x1367AC8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1367B44
	private bool MoveNext() { }

	// RVA: 0x1367E58
	private void <>m__Finally1() { }

	// RVA: 0x1367EB4
	private JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x1367EBC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1367EFC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1367F04
	private System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x1367FB8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> m_Dict; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x1365C58
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1365C60
	public override bool get_IsObject() { }

	// RVA: 0x1365C68
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x1365E34
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1366058
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x13661AC
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1366468
	public override int get_Count() { }

	// RVA: 0x13664BC
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1366758
	public override JSONNode Remove(string aKey) { }

	// RVA: 0x1366844
	public override JSONNode Remove(int aIndex) { }

	// RVA: 0x1366A50
	public override JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1366CE0
	public override System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x1366DA0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1366E44
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1367104
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x136286C
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x1367FBC
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1367FC4
	public override bool get_IsString() { }

	// RVA: 0x1367FCC
	public override string get_Value() { }

	// RVA: 0x1367FD4
	public override void set_Value(string value) { }

	// RVA: 0x1360CFC
	public void .ctor(string aData) { }

	// RVA: 0x1367FDC
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x136802C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13680D4
	public override bool Equals(object obj) { }

	// RVA: 0x1368308
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x136832C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1368334
	public override bool get_IsNumber() { }

	// RVA: 0x136833C
	public override string get_Value() { }

	// RVA: 0x1368348
	public override void set_Value(string value) { }

	// RVA: 0x1368390
	public override Double get_AsDouble() { }

	// RVA: 0x1368398
	public override void set_AsDouble(Double value) { }

	// RVA: 0x1360FA0
	public void .ctor(Double aData) { }

	// RVA: 0x13683A0
	public void .ctor(string aData) { }

	// RVA: 0x136841C
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x136846C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1368490
	private static bool IsNumeric(object value) { }

	// RVA: 0x136863C
	public override bool Equals(object obj) { }

	// RVA: 0x1368884
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x13688A4
	public override JSONNodeType get_Tag() { }

	// RVA: 0x13688AC
	public override bool get_IsBoolean() { }

	// RVA: 0x13688B4
	public override string get_Value() { }

	// RVA: 0x136893C
	public override void set_Value(string value) { }

	// RVA: 0x13689FC
	public override bool get_AsBool() { }

	// RVA: 0x1368A04
	public override void set_AsBool(bool value) { }

	// RVA: 0x13615E8
	public void .ctor(bool aData) { }

	// RVA: 0x1368A0C
	public void .ctor(string aData) { }

	// RVA: 0x1368A88
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1368AD4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1368B58
	public override bool Equals(object obj) { }

	// RVA: 0x1368BE8
	public override int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNull
{
	// Methods

	// RVA: 0x1368C70
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1368C78
	public override bool get_IsNull() { }

	// RVA: 0x1368C80
	public override string get_Value() { }

	// RVA: 0x1368CC4
	public override void set_Value(string value) { }

	// RVA: 0x1368CC8
	public override bool get_AsBool() { }

	// RVA: 0x1368CD0
	public override void set_AsBool(bool value) { }

	// RVA: 0x1368CD4
	public override bool Equals(object obj) { }

	// RVA: 0x1368D84
	public override int GetHashCode() { }

	// RVA: 0x1368D8C
	public override void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1368DB4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13633F0
	public void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x1368E0C
	public override JSONNodeType get_Tag() { }

	// RVA: 0x1364734
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x1365DA0
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x1368E14
	private void Set(JSONNode aVal) { }

	// RVA: 0x1368E94
	public override JSONNode get_Item(int aIndex) { }

	// RVA: 0x1368F54
	public override void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x136901C
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x13690E8
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x13691C0
	public override void Add(JSONNode aItem) { }

	// RVA: 0x1369288
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1369360
	public static bool op_Equality(JSONLazyCreator a, object b) { }

	// RVA: 0x1369370
	public static bool op_Inequality(JSONLazyCreator a, object b) { }

	// RVA: 0x1369380
	public override bool Equals(object obj) { }

	// RVA: 0x1369390
	public override int GetHashCode() { }

	// RVA: 0x1369398
	public override int get_AsInt() { }

	// RVA: 0x13694B0
	public override void set_AsInt(int value) { }

	// RVA: 0x13695DC
	public override float get_AsFloat() { }

	// RVA: 0x13696F4
	public override void set_AsFloat(float value) { }

	// RVA: 0x1369818
	public override Double get_AsDouble() { }

	// RVA: 0x1369930
	public override void set_AsDouble(Double value) { }

	// RVA: 0x1369A4C
	public override bool get_AsBool() { }

	// RVA: 0x1369B64
	public override void set_AsBool(bool value) { }

	// RVA: 0x1369C80
	public override JSONArray get_AsArray() { }

	// RVA: 0x1369D30
	public override JSONObject get_AsObject() { }

	// RVA: 0x1369DE0
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x135DC30
	public static JSONNode Parse(string aJSON) { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
public class JsonUtilityCompat
{
	// Methods

	// RVA: 0x1369E38
	internal static string ToJson(object obj) { }

	// RVA: 0x1369EE4
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

	// RVA: 0x1360080
	public void .ctor(object scene, bool valid, int buildIndex, string name, string path) { }

	// RVA: 0x1369EEC
	public override int GetHashCode() { }

	// RVA: 0x1369EF4
	internal bool IsValid() { }

	// RVA: 0x1369EFC
	internal int get_buildIndex() { }

	// RVA: 0x136A034
	internal string get_name() { }

	// RVA: 0x136A03C
	internal string get_path() { }

	// RVA: 0x136A044
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

	// RVA: 0x136A048
	internal static int get_sceneCount() { }

	// RVA: 0x136A0CC
	internal static SceneCompat GetActiveScene() { }

	// RVA: 0x136A194
	internal static SceneCompat GetSceneAt(int index) { }

	// RVA: 0x136A26C
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

	// RVA: 0x13553A0
	internal static UInt32 ComputeStringHash(string s) { }

}


