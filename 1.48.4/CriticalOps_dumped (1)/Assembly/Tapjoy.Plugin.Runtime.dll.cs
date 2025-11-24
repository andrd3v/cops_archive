// Namespace: 
internal class <Module> 
{}

// Namespace: 
public static class EntryPointExtensions 
{
	// Fields
	public static readonly System.Collections.Generic.Dictionary<TapjoyUnity.TJEntryPoint,System.String> entryPointValues; // 0x0

	// Methods

	// RVA: 0x132A100
	string GetValue(TJEntryPoint entryPoint) { }

	// RVA: 0x132A1BC
	void .cctor() { }

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

	// RVA: 0x132A474
	MonoScriptData Get() { }

	// RVA: 0x132A578
	void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction 
{
	// Methods

	// RVA: 0x132A580
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132A620
	internal void Invoke() { }

	// RVA: 0x132A634
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x132A68C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1, T2 arg2) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyAction<T0, T1, T2, T3, T4> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TResult Invoke() { }

	// RVA: 0x2FE37A0
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x309AF8C
	internal TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public sealed class TapjoyFunc<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TResult Invoke(T1 arg1) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 arg1, AsyncCallback callback, object object) { }

	// RVA: 0x309AF8C
	internal TResult EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectSuccessHandler 
{
	// Methods

	// RVA: 0x132DD6C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132DE0C
	internal void Invoke() { }

	// RVA: 0x132DE20
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x132DE78
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectFailedHandler 
{
	// Methods

	// RVA: 0x132DE84
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132DF28
	internal void Invoke(int code, string message) { }

	// RVA: 0x132DF3C
	internal IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x132DFFC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnConnectWarningHandler 
{
	// Methods

	// RVA: 0x132E008
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E0AC
	internal void Invoke(int code, string message) { }

	// RVA: 0x132E0C0
	internal IAsyncResult BeginInvoke(int code, string message, AsyncCallback callback, object object) { }

	// RVA: 0x132E180
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDSuccessHandler 
{
	// Methods

	// RVA: 0x132E18C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E22C
	internal void Invoke() { }

	// RVA: 0x132E240
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x132E298
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailedHandler 
{
	// Methods

	// RVA: 0x132E2A4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E348
	internal void Invoke(int code, string errorMessage) { }

	// RVA: 0x132E35C
	internal IAsyncResult BeginInvoke(int code, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x132E41C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetUserIDFailureHandler 
{
	// Methods

	// RVA: 0x132E428
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E4DC
	internal void Invoke(string errorMessage) { }

	// RVA: 0x132E4F0
	internal IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x132E540
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseHandler 
{
	// Methods

	// RVA: 0x132E54C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E608
	internal void Invoke(string currencyName, int balance) { }

	// RVA: 0x132E61C
	internal IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x132E6E0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnGetCurrencyBalanceResponseFailureHandler 
{
	// Methods

	// RVA: 0x132E6EC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E7A0
	internal void Invoke(string errorMessage) { }

	// RVA: 0x132E7B4
	internal IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x132E804
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseHandler 
{
	// Methods

	// RVA: 0x132E810
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132E8CC
	internal void Invoke(string currencyName, int balance) { }

	// RVA: 0x132E8E0
	internal IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x132E9A4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSpendCurrencyResponseFailureHandler 
{
	// Methods

	// RVA: 0x132E9B0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132EA64
	internal void Invoke(string errorMessage) { }

	// RVA: 0x132EA78
	internal IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x132EAC8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseHandler 
{
	// Methods

	// RVA: 0x132EAD4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132EB90
	internal void Invoke(string currencyName, int balance) { }

	// RVA: 0x132EBA4
	internal IAsyncResult BeginInvoke(string currencyName, int balance, AsyncCallback callback, object object) { }

	// RVA: 0x132EC68
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnAwardCurrencyResponseFailureHandler 
{
	// Methods

	// RVA: 0x132EC74
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132ED28
	internal void Invoke(string errorMessage) { }

	// RVA: 0x132ED3C
	internal IAsyncResult BeginInvoke(string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x132ED8C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnEarnedCurrencyHandler 
{
	// Methods

	// RVA: 0x132ED98
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132EE54
	internal void Invoke(string currencyName, int amount) { }

	// RVA: 0x132EE68
	internal IAsyncResult BeginInvoke(string currencyName, int amount, AsyncCallback callback, object object) { }

	// RVA: 0x132EF2C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity
public class Tapjoy 
{
	// Fields
	internal const string VERSION_NAME = 5736732160;
	internal const string VERSION_SUFFIX = 5081882432;
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

	// RVA: 0x132A698
	string get_Version() { }

	// RVA: 0x132A730
	bool get_IsConnected() { }

	// RVA: 0x132A77C
	void set_IsConnected(bool value) { }

	// RVA: 0x132A7D4
	void Connect() { }

	// RVA: 0x132ABCC
	void Connect(string sdkKey) { }

	// RVA: 0x132AD8C
	void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x132B0B0
	void SetDebugEnabled(bool enable) { }

	// RVA: 0x132B1EC
	void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x132B224
	void ActionComplete(string actionID) { }

	// RVA: 0x132B228
	void SetUserID(string userId) { }

	// RVA: 0x132B260
	string GetUserID() { }

	// RVA: 0x132B288
	void SetCustomParameter(string customParam) { }

	// RVA: 0x132B2C0
	string GetCustomParameter() { }

	// RVA: 0x132B2E8
	void SetUserLevel(int userLevel) { }

	// RVA: 0x132B320
	int GetUserLevel() { }

	// RVA: 0x132B348
	void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x132B380
	int GetMaxLevel() { }

	// RVA: 0x132B3A8
	void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x132B3E0
	TJSegment GetUserSegment() { }

	// RVA: 0x132B408
	Double GetScreenScale() { }

	// RVA: 0x132B430
	void ClearUserTags() { }

	// RVA: 0x132B458
	System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x132B480
	void AddUserTag(string tag) { }

	// RVA: 0x132B4B8
	void RemoveUserTag(string tag) { }

	// RVA: 0x132B4F0
	void TrackPurchase(string currencyCode, Double productPrice) { }

	// RVA: 0x132B538
	void TrackPurchase(string productId, string currencyCode, Double productPrice, string campaignId) { }

	// RVA: 0x132B580
	void TrackPurchaseInGooglePlayStore(string skuDetails, string purchaseData, string dataSignature, string campaignId) { }

	// RVA: 0x132B584
	void TrackPurchaseInAppleAppStore(string productId, string currencyCode, Double productPrice, string transactionId, string campaignId) { }

	// RVA: 0x132B5CC
	void AwardCurrency(int amount) { }

	// RVA: 0x132B604
	void GetCurrencyBalance() { }

	// RVA: 0x132B62C
	void SpendCurrency(int amount) { }

	// RVA: 0x132B664
	string GetSupportURL() { }

	// RVA: 0x132B6A8
	string GetSupportURL(string currencyID) { }

	// RVA: 0x132B6EC
	void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x132B714
	void add_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x132B7E8
	void remove_OnConnectSuccess(OnConnectSuccessHandler value) { }

	// RVA: 0x132B8BC
	void add_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x132B990
	void remove_OnConnectSuccessInternal(OnConnectSuccessHandler value) { }

	// RVA: 0x132BA64
	void add_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x132BB38
	void remove_OnConnectFailed(OnConnectFailedHandler value) { }

	// RVA: 0x132BC0C
	void add_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x132BCE0
	void remove_OnConnectFailedInternal(OnConnectFailedHandler value) { }

	// RVA: 0x132BDB4
	void add_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x132BE88
	void remove_OnConnectWarning(OnConnectWarningHandler value) { }

	// RVA: 0x132BF5C
	void add_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x132C030
	void remove_OnConnectWarningInternal(OnConnectWarningHandler value) { }

	// RVA: 0x132C104
	void DispatchConnectEvent(string connectCallbackMethod) { }

	// RVA: 0x132C4A4
	void add_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x132C578
	void remove_OnSetUserIDSuccess(OnSetUserIDSuccessHandler value) { }

	// RVA: 0x132C64C
	void add_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x132C720
	void remove_OnSetUserIDFailed(OnSetUserIDFailedHandler value) { }

	// RVA: 0x132C7F4
	void add_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x132C8C8
	void remove_OnSetUserIDFailure(OnSetUserIDFailureHandler value) { }

	// RVA: 0x132C99C
	void DispatchSetUserIDEvent(string commaDelimitedMessage) { }

	// RVA: 0x132CBFC
	void add_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x132CCD0
	void remove_OnGetCurrencyBalanceResponse(OnGetCurrencyBalanceResponseHandler value) { }

	// RVA: 0x132CDA4
	void add_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x132CE78
	void remove_OnGetCurrencyBalanceResponseFailure(OnGetCurrencyBalanceResponseFailureHandler value) { }

	// RVA: 0x132CF4C
	void add_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x132D020
	void remove_OnSpendCurrencyResponse(OnSpendCurrencyResponseHandler value) { }

	// RVA: 0x132D0F4
	void add_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x132D1C8
	void remove_OnSpendCurrencyResponseFailure(OnSpendCurrencyResponseFailureHandler value) { }

	// RVA: 0x132D29C
	void add_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x132D370
	void remove_OnAwardCurrencyResponse(OnAwardCurrencyResponseHandler value) { }

	// RVA: 0x132D444
	void add_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x132D518
	void remove_OnAwardCurrencyResponseFailure(OnAwardCurrencyResponseFailureHandler value) { }

	// RVA: 0x132D5EC
	void add_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x132D6C0
	void remove_OnEarnedCurrency(OnEarnedCurrencyHandler value) { }

	// RVA: 0x132D794
	void DispatchCurrencyEvent(string commaDelimitedMessage) { }

	// RVA: 0x132DD64
	void .ctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJActionRequest 
{
	// Fields
	public string requestID; // 0x10
	public string token; // 0x18

	// Methods

	// RVA: 0x132EF38
	void Finalize() { }

	// RVA: 0x132F0E4
	void .ctor(string requestID, string token) { }

	// RVA: 0x132F134
	void Completed() { }

	// RVA: 0x132F16C
	void Cancelled() { }

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

	// RVA: 0x132FB10
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132FBB0
	internal void Invoke() { }

	// RVA: 0x132FBC4
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x132FC1C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler 
{
	// Methods

	// RVA: 0x132FC28
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132FCCC
	internal void Invoke(int code, string error) { }

	// RVA: 0x132FCE0
	internal IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x132FDA0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler 
{
	// Methods

	// RVA: 0x132FDAC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132FE4C
	internal void Invoke() { }

	// RVA: 0x132FE60
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x132FEB8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentErrorHandler 
{
	// Methods

	// RVA: 0x132FEC4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x132FF68
	internal void Invoke(int code, string error) { }

	// RVA: 0x132FF7C
	internal IAsyncResult BeginInvoke(int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x133003C
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x132F1A4
	void .ctor() { }

	// RVA: 0x132F1AC
	void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x132F1F4
	void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x132F25C
	void ShowOfferwallDiscover() { }

	// RVA: 0x132F284
	void DestroyOfferwallDiscover() { }

	// RVA: 0x132F2AC
	void DispatchOfferwallDiscoverEvent(string commaDelimitedMessage) { }

	// RVA: 0x132F480
	void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x132F54C
	void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x132F618
	void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x132F6EC
	void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x132F7C0
	void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x132F894
	void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x132F968
	void add_OnContentError(OnContentErrorHandler value) { }

	// RVA: 0x132FA3C
	void remove_OnContentError(OnContentErrorHandler value) { }

}

// Namespace: 
public sealed class OnRequestSuccessHandler 
{
	// Methods

	// RVA: 0x1332668
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1332788
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x133279C
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13327EC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRequestFailureHandler 
{
	// Methods

	// RVA: 0x13327F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x133291C
	internal void Invoke(TJPlacement placement, string error) { }

	// RVA: 0x1332930
	internal IAsyncResult BeginInvoke(TJPlacement placement, string error, AsyncCallback callback, object object) { }

	// RVA: 0x133298C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentReadyHandler 
{
	// Methods

	// RVA: 0x1332998
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1332AB8
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x1332ACC
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1332B1C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentShowHandler 
{
	// Methods

	// RVA: 0x1332B28
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1332C48
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x1332C5C
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1332CAC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnContentDismissHandler 
{
	// Methods

	// RVA: 0x1332CB8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1332DD8
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x1332DEC
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1332E3C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnClickHandler 
{
	// Methods

	// RVA: 0x1332E48
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1332F68
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x1332F7C
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1332FCC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnPurchaseRequestHandler 
{
	// Methods

	// RVA: 0x1332FD8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13330FC
	internal void Invoke(TJPlacement placement, TJActionRequest request, string productId) { }

	// RVA: 0x1333110
	internal IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string productId, AsyncCallback callback, object object) { }

	// RVA: 0x133316C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnRewardRequestHandler 
{
	// Methods

	// RVA: 0x1333178
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x133329C
	internal void Invoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity) { }

	// RVA: 0x13332B0
	internal IAsyncResult BeginInvoke(TJPlacement placement, TJActionRequest request, string itemId, int quantity, AsyncCallback callback, object object) { }

	// RVA: 0x1333388
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceSuccessHandler 
{
	// Methods

	// RVA: 0x1333394
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13334B4
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x13334C8
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x1333518
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyBalanceFailureHandler 
{
	// Methods

	// RVA: 0x1333524
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1333648
	internal void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x133365C
	internal IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x133372C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredSuccessHandler 
{
	// Methods

	// RVA: 0x1333738
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1333858
	internal void Invoke(TJPlacement placement) { }

	// RVA: 0x133386C
	internal IAsyncResult BeginInvoke(TJPlacement placement, AsyncCallback callback, object object) { }

	// RVA: 0x13338BC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class OnSetCurrencyAmountRequiredFailureHandler 
{
	// Methods

	// RVA: 0x13338C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x13339EC
	internal void Invoke(TJPlacement placement, int code, string error) { }

	// RVA: 0x1333A00
	internal IAsyncResult BeginInvoke(TJPlacement placement, int code, string error, AsyncCallback callback, object object) { }

	// RVA: 0x1333AD0
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x1330048
	void .ctor(string placementName) { }

	// RVA: 0x1330184
	void Finalize() { }

	// RVA: 0x1330328
	TJPlacement CreatePlacement(string placementName) { }

	// RVA: 0x133038C
	void DismissContent() { }

	// RVA: 0x13303B4
	void RequestContent() { }

	// RVA: 0x13304A8
	void ShowContent() { }

	// RVA: 0x133057C
	bool IsContentAvailable() { }

	// RVA: 0x13305B4
	bool IsContentReady() { }

	// RVA: 0x13305EC
	string GetName() { }

	// RVA: 0x13305F4
	void SetEntryPoint(TJEntryPoint entryPoint) { }

	// RVA: 0x1330634
	void SetCurrencyBalance(string currencyId, int balance) { }

	// RVA: 0x1330684
	int GetCurrencyBalance(string currencyId) { }

	// RVA: 0x13306C4
	void SetRequiredAmount(string currencyId, int amount) { }

	// RVA: 0x1330714
	int GetRequiredAmount(string currencyId) { }

	// RVA: 0x1330754
	void add_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x1330838
	void remove_OnRequestSuccess(OnRequestSuccessHandler value) { }

	// RVA: 0x133091C
	void add_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1330A00
	void remove_OnRequestFailure(OnRequestFailureHandler value) { }

	// RVA: 0x1330AE4
	void add_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1330BC8
	void remove_OnContentReady(OnContentReadyHandler value) { }

	// RVA: 0x1330CAC
	void add_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1330D90
	void remove_OnContentShow(OnContentShowHandler value) { }

	// RVA: 0x1330E74
	void add_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x1330F58
	void remove_OnContentDismiss(OnContentDismissHandler value) { }

	// RVA: 0x133103C
	void add_OnClick(OnClickHandler value) { }

	// RVA: 0x1331120
	void remove_OnClick(OnClickHandler value) { }

	// RVA: 0x1331204
	void add_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x13312E8
	void remove_OnPurchaseRequest(OnPurchaseRequestHandler value) { }

	// RVA: 0x13313CC
	void add_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x13314B0
	void remove_OnRewardRequest(OnRewardRequestHandler value) { }

	// RVA: 0x1331594
	void add_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x1331678
	void remove_OnSetCurrencyBalanceSuccess(OnSetCurrencyBalanceSuccessHandler value) { }

	// RVA: 0x133175C
	void add_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1331840
	void remove_OnSetCurrencyBalanceFailure(OnSetCurrencyBalanceFailureHandler value) { }

	// RVA: 0x1331924
	void add_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x1331A08
	void remove_OnSetCurrencyAmountRequiredSuccess(OnSetCurrencyAmountRequiredSuccessHandler value) { }

	// RVA: 0x1331AEC
	void add_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x1331BD0
	void remove_OnSetCurrencyAmountRequiredFailure(OnSetCurrencyAmountRequiredFailureHandler value) { }

	// RVA: 0x1331CB4
	void DispatchPlacementEvent(string commaDelimitedMessage) { }

	// RVA: 0x13325CC
	void .cctor() { }

}

// Namespace: TapjoyUnity
public sealed class TJPrivacyPolicy 
{
	// Methods

	// RVA: 0x1333ADC
	void .ctor() { }

	// RVA: 0x1333B08
	TJPrivacyPolicy GetPrivacyPolicy() { }

	// RVA: 0x1333B78
	void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x1333BAC
	TJStatus GetSubjectToGDPR() { }

	// RVA: 0x1333BD0
	void SetUserConsent(TJStatus consent) { }

	// RVA: 0x1333C04
	TJStatus GetUserConsent() { }

	// RVA: 0x1333C28
	void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x1333C60
	TJStatus GetBelowConsentAge() { }

	// RVA: 0x1333C88
	void SetUSPrivacy(string privacyPolicy) { }

	// RVA: 0x1333CC0
	string GetUSPrivacy() { }

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

	// RVA: 0x1333F38
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1333FD8
	internal void Invoke() { }

	// RVA: 0x1333FEC
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1334044
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: TapjoyUnity.Internal
public abstract class ApiBinding 
{
	// Fields
	protected const string DEFAULT_EVENT_VALUE_NAME = 5736732016;
	protected const string VERSION_NAME = 5736731968;
	protected const string CONNECT_FLAG_DICTIONARY_NAME = 5730682176;
	private static ApiBinding instance; // 0x0
	private static OnInstanceSetHandler onInstanceSetHandler; // 0x8
	private string name; // 0x10

	// Methods

	// RVA: 0x132B0E4
	ApiBinding get_Instance() { }

	// RVA: 0x1333D50
	void SetInstance(ApiBinding value) { }

	// RVA: 0x1333E2C
	void set_OnInstanceSet(OnInstanceSetHandler value) { }

	// RVA: 0x1333EFC
	void .ctor(string name) { }

	// RVA: 0x1333F30
	string get_Name() { }

	// RVA: 0x2FE47D4
	void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x2FE360C
	string GetSDKVersion() { }

	// RVA: 0x2FE4234
	void SetDebugEnabled(bool enabled) { }

	// RVA: 0x2FE41A8
	void ActivateUnitySupport() { }

	// RVA: 0x2FE41A8
	void GetPrivacyPolicy() { }

	// RVA: 0x2FE42A4
	void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x2FE32D4
	int GetSubjectToGDPR() { }

	// RVA: 0x2FE42A4
	void SetUserConsent(TJStatus consent) { }

	// RVA: 0x2FE32D4
	int GetUserConsent() { }

	// RVA: 0x2FE42A4
	void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x2FE32D4
	int GetBelowConsentAge() { }

	// RVA: 0x2FE4574
	void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x2FE360C
	string GetUSPrivacy() { }

	// RVA: 0x2FE4234
	void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x2FE41A8
	void GetCurrencyBalance() { }

	// RVA: 0x2FE42A4
	void SpendCurrency(int points) { }

	// RVA: 0x2FE42A4
	void AwardCurrency(int points) { }

	// RVA: 0x2FE41A8
	void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x2FE47D4
	void CreatePlacement(string placementGuid, string placementName) { }

	// RVA: 0x2FE41A8
	void DismissPlacementContent() { }

	// RVA: 0x2FE4574
	void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x2FE4574
	void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x2FE4574
	void ActionRequestCompleted(string requestId) { }

	// RVA: 0x2FE4574
	void ActionRequestCancelled(string requestId) { }

	// RVA: 0x2FE3174
	bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x2FE3174
	bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x2FE4574
	void RemovePlacement(string placementGuid) { }

	// RVA: 0x2FE45DC
	void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x2FE4840
	void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: -1
	int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x2FE4840
	void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: -1
	int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: -1
	void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: -1
	void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x2FE41A8
	void ShowOfferwallDiscover() { }

	// RVA: 0x2FE41A8
	void DestroyOfferwallDiscover() { }

	// RVA: 0x2FE4574
	void RemoveActionRequest(string requestId) { }

	// RVA: 0x2FE4574
	void SetUserID(string userId) { }

	// RVA: 0x2FE360C
	string GetUserID() { }

	// RVA: 0x2FE4574
	void SetCustomParameter(string customParam) { }

	// RVA: 0x2FE360C
	string GetCustomParameter() { }

	// RVA: 0x2FE42A4
	void SetUserLevel(int userLevel) { }

	// RVA: 0x2FE32D4
	int GetUserLevel() { }

	// RVA: 0x2FE42A4
	void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x2FE32D4
	int GetMaxLevel() { }

	// RVA: 0x2FE42A4
	void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x2FE32D4
	int GetUserSegment() { }

	// RVA: -1
	Double GetScreenScale() { }

	// RVA: 0x2FE41A8
	void ClearUserTags() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x2FE4574
	void AddUserTag(string tag) { }

	// RVA: 0x2FE4574
	void RemoveUserTag(string tag) { }

	// RVA: -1
	void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal class ApiBindingNone 
{
	// Methods

	// RVA: 0x1333CE8
	void .ctor() { }

	// RVA: 0x1334050
	void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flag) { }

	// RVA: 0x1334054
	string GetSDKVersion() { }

	// RVA: 0x1334098
	void SetDebugEnabled(bool enabled) { }

	// RVA: 0x133409C
	void ActivateUnitySupport() { }

	// RVA: 0x13340A0
	void GetPrivacyPolicy() { }

	// RVA: 0x13340A4
	void SetSubjectToGDPR(TJStatus subject) { }

	// RVA: 0x13340A8
	int GetSubjectToGDPR() { }

	// RVA: 0x13340B0
	void SetUserConsent(TJStatus consent) { }

	// RVA: 0x13340B4
	int GetUserConsent() { }

	// RVA: 0x13340BC
	void SetBelowConsentAge(TJStatus isBelowConsentAge) { }

	// RVA: 0x13340C0
	int GetBelowConsentAge() { }

	// RVA: 0x13340C8
	void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x13340CC
	string GetUSPrivacy() { }

	// RVA: 0x1334110
	void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x1334114
	void GetCurrencyBalance() { }

	// RVA: 0x1334118
	void SpendCurrency(int amount) { }

	// RVA: 0x133411C
	void AwardCurrency(int amount) { }

	// RVA: 0x1334120
	void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x1334124
	void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x1334128
	void DismissPlacementContent() { }

	// RVA: 0x133412C
	void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x1334130
	void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x1334134
	bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x133413C
	bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x1334144
	void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x1334148
	int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1334150
	void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1334154
	int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x133415C
	void ActionRequestCompleted(string requestId) { }

	// RVA: 0x1334160
	void ActionRequestCancelled(string requestId) { }

	// RVA: 0x1334164
	void RemovePlacement(string placementGuid) { }

	// RVA: 0x1334168
	void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x133416C
	void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1334170
	void ShowOfferwallDiscover() { }

	// RVA: 0x1334174
	void DestroyOfferwallDiscover() { }

	// RVA: 0x1334178
	void RemoveActionRequest(string requestID) { }

	// RVA: 0x133417C
	void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x1334180
	void SetUserID(string userId) { }

	// RVA: 0x1334184
	string GetUserID() { }

	// RVA: 0x13341C8
	void SetCustomParameter(string customParam) { }

	// RVA: 0x13341CC
	string GetCustomParameter() { }

	// RVA: 0x1334210
	void SetUserLevel(int userLevel) { }

	// RVA: 0x1334214
	int GetUserLevel() { }

	// RVA: 0x133421C
	void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x1334220
	int GetMaxLevel() { }

	// RVA: 0x1334228
	void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x133422C
	int GetUserSegment() { }

	// RVA: 0x1334234
	Double GetScreenScale() { }

	// RVA: 0x133423C
	void ClearUserTags() { }

	// RVA: 0x1334240
	System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1334248
	void AddUserTag(string tag) { }

	// RVA: 0x133424C
	void RemoveUserTag(string tag) { }

	// RVA: 0x1334250
	void TrackPurchase(string currencyCode, Double price) { }

}

// Namespace: TapjoyUnity.Internal
internal static class ForegroundRealtimeClock 
{
	// Fields
	private static float realtimeSpentWhilePaused; // 0x0
	private static float realtimePaused; // 0x4

	// Methods

	// RVA: 0x1334254
	void OnApplicationPause(bool paused) { }

	// RVA: 0x13342F8
	float get_Realtime() { }

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

	// RVA: 0x1334350
	void OnActiveSceneChanged(SceneCompat oldScene, SceneCompat newScene) { }

	// RVA: 0x13343E0
	void OnSceneLoaded(SceneCompat scene, int loadMode) { }

	// RVA: 0x133446C
	void OnSceneUnloaded(SceneCompat scene) { }

}

// Namespace: TapjoyUnity.Internal
public class PlatformSettings 
{
	// Fields
	private string sdkKey; // 0x10
	private bool disableAdvertisingId; // 0x18
	protected bool dirty; // 0x19

	// Methods

	// RVA: 0x13344EC
	void .ctor() { }

	// RVA: 0x1334558
	string get_SdkKey() { }

	// RVA: 0x1334560
	void set_SdkKey(string value) { }

	// RVA: 0x13345B4
	bool get_DisableAdvertisingId() { }

	// RVA: 0x13345BC
	void set_DisableAdvertisingId(bool value) { }

	// RVA: 0x13345D8
	bool get_Valid() { }

	// RVA: 0x1334630
	bool get_Dirty() { }

	// RVA: 0x1334638
	void set_Dirty(bool value) { }

}

// Namespace: TapjoyUnity.Internal
public class IosPlatformSettings 
{
	// Methods

	// RVA: 0x1334640
	void .ctor() { }

}

// Namespace: TapjoyUnity.Internal
public sealed class ApiBindingIos 
{
	// Methods

	// RVA: 0x13346AC
	void Install() { }

	// RVA: 0x133482C
	void .ctor() { }

	// RVA: 0x13348E8
	void Connect(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x1334F9C
	void transferDictionaryToObjectiveCWithName(System.Collections.Generic.Dictionary<System.String,System.Object> dictionary, string dictionaryName) { }

	// RVA: 0x1335650
	string GetSDKVersion() { }

	// RVA: 0x13356B8
	void SetDebugEnabled(bool enabled) { }

	// RVA: 0x13356C4
	void GetPrivacyPolicy() { }

	// RVA: 0x13356CC
	void SetSubjectToGDPR(TJStatus gdprApplicable) { }

	// RVA: 0x13356D8
	int GetSubjectToGDPR() { }

	// RVA: 0x13356E0
	void SetUserConsent(TJStatus consent) { }

	// RVA: 0x13356EC
	int GetUserConsent() { }

	// RVA: 0x13356F4
	void SetBelowConsentAge(TJStatus belowConsentAge) { }

	// RVA: 0x1335700
	int GetBelowConsentAge() { }

	// RVA: 0x1335708
	void SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x133575C
	string GetUSPrivacy() { }

	// RVA: 0x13357C4
	void OptOutAdvertisingID(bool optOut) { }

	// RVA: 0x13357C8
	void ActivateUnitySupport() { }

	// RVA: 0x13357CC
	void GetCurrencyBalance() { }

	// RVA: 0x13357D4
	void SpendCurrency(int amount) { }

	// RVA: 0x13357E0
	void AwardCurrency(int amount) { }

	// RVA: 0x13357EC
	void ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x13357F4
	void CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x1335888
	void DismissPlacementContent() { }

	// RVA: 0x1335890
	void RequestPlacementContent(string placementGuid) { }

	// RVA: 0x13358E4
	void ShowPlacementContent(string placementGuid) { }

	// RVA: 0x1335938
	bool IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x13359AC
	bool IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x1335A20
	void SetCurrencyBalance(string placementGuid, string currencyId, int balance) { }

	// RVA: 0x1335AE0
	int GetCurrencyBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1335B9C
	void SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1335C5C
	int GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x1335D18
	void ActionRequestCompleted(string requestId) { }

	// RVA: 0x1335D6C
	void ActionRequestCancelled(string requestId) { }

	// RVA: 0x1335DC0
	void RemovePlacement(string placementGuid) { }

	// RVA: 0x1335E14
	void RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x1335E98
	void RequestOfferwallDiscover(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1335F5C
	void ShowOfferwallDiscover() { }

	// RVA: 0x1335F7C
	void DestroyOfferwallDiscover() { }

	// RVA: 0x1335F9C
	void RemoveActionRequest(string requestID) { }

	// RVA: 0x1335FF0
	void SetEntryPoint(string placementGuid, TJEntryPoint entryPoint) { }

	// RVA: 0x1336174
	void SetUserID(string userID) { }

	// RVA: 0x13361C8
	string GetUserID() { }

	// RVA: 0x1336230
	void SetCustomParameter(string customParam) { }

	// RVA: 0x1336284
	string GetCustomParameter() { }

	// RVA: 0x13362EC
	void SetUserLevel(int userLevel) { }

	// RVA: 0x13362F8
	int GetUserLevel() { }

	// RVA: 0x1336300
	void SetMaxLevel(int maxUserLevel) { }

	// RVA: 0x133630C
	int GetMaxLevel() { }

	// RVA: 0x1336314
	void SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1336320
	int GetUserSegment() { }

	// RVA: 0x1336328
	Double GetScreenScale() { }

	// RVA: 0x1336330
	void ClearUserTags() { }

	// RVA: 0x1336338
	System.Collections.Generic.List<System.String> GetUserTags() { }

	// RVA: 0x1336718
	void AddUserTag(string tag) { }

	// RVA: 0x133676C
	void RemoveUserTag(string tag) { }

	// RVA: 0x13367C0
	void TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x13348C0
	void Tapjoy_SetUnityVersion(string version) { }

	// RVA: 0x1335628
	void Tapjoy_Connect(string sdkKey) { }

	// RVA: 0x13355BC
	void Tapjoy_SetKeyToValueInDictionary(string key, string valueToSet, string dictionaryName) { }

	// RVA: 0x1335550
	void Tapjoy_SetKeyToDictionaryRefValueInDictionary(string key, string dictionaryNameToSet, string dictionaryNameToSetTo) { }

	// RVA: 0x1335684
	string Tapjoy_GetSDKVersion() { }

	// RVA: 0x13356C0
	void Tapjoy_SetDebugEnabled(bool enabled) { }

	// RVA: 0x13356C8
	void Tapjoy_GetPrivacyPolicy() { }

	// RVA: 0x13356D4
	void Tapjoy_SetSubjectToGDPRStatus(int gdprApplicable) { }

	// RVA: 0x13356DC
	int Tapjoy_GetSubjectToGDPRStatus() { }

	// RVA: 0x13356E8
	void Tapjoy_SetUserConsentStatus(int consent) { }

	// RVA: 0x13356F0
	int Tapjoy_GetUserConsentStatus() { }

	// RVA: 0x13356FC
	void Tapjoy_SetBelowConsentAgeStatus(int belowConsentAge) { }

	// RVA: 0x1335704
	int Tapjoy_GetBelowConsentAgeStatus() { }

	// RVA: 0x1335734
	void Tapjoy_SetUSPrivacy(string privacyConsent) { }

	// RVA: 0x1335790
	string Tapjoy_GetUSPrivacy() { }

	// RVA: 0x13357D0
	void Tapjoy_GetCurrencyBalance() { }

	// RVA: 0x13357DC
	void Tapjoy_SpendCurrency(int amount) { }

	// RVA: 0x13357E8
	void Tapjoy_AwardCurrency(int amount) { }

	// RVA: 0x13357F0
	void Tapjoy_ShowDefaultEarnedCurrencyAlert() { }

	// RVA: 0x1335840
	void Tapjoy_CreatePlacement(string placementGuid, string eventName) { }

	// RVA: 0x133588C
	void Tapjoy_DismissPlacementContent() { }

	// RVA: 0x13358BC
	void Tapjoy_RequestPlacementContent(string placementGuid) { }

	// RVA: 0x1335910
	void Tapjoy_ShowPlacementContent(string placementGuid) { }

	// RVA: 0x13359E8
	bool Tapjoy_IsPlacementContentAvailable(string placementGuid) { }

	// RVA: 0x1335974
	bool Tapjoy_IsPlacementContentReady(string placementGuid) { }

	// RVA: 0x1335A7C
	int Tapjoy_SetPlacementBalance(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1335B40
	int Tapjoy_GetPlacementBalance(string placementGuid, string currencyId) { }

	// RVA: 0x1335BF8
	int Tapjoy_SetRequiredAmount(string placementGuid, string currencyId, int amount) { }

	// RVA: 0x1335CBC
	int Tapjoy_GetRequiredAmount(string placementGuid, string currencyId) { }

	// RVA: 0x1335E50
	bool Tapjoy_RequestOfferwallDiscover(string placementName, float height) { }

	// RVA: 0x1335EF4
	bool Tapjoy_RequestOfferwallDiscoverAtPosition(string placementName, float left, float top, float width, float height) { }

	// RVA: 0x1335F60
	bool Tapjoy_ShowOfferwallDiscover() { }

	// RVA: 0x1335F80
	bool Tapjoy_DestroyOfferwallDiscover() { }

	// RVA: 0x1335D44
	void Tapjoy_ActionRequestCompleted(string requestId) { }

	// RVA: 0x1335D98
	void Tapjoy_ActionRequestCancelled(string requestId) { }

	// RVA: 0x1335DEC
	void Tapjoy_RemovePlacement(string placementGuid) { }

	// RVA: 0x1335FC8
	void Tapjoy_RemoveActionRequest(string requestId) { }

	// RVA: 0x133612C
	void Tapjoy_SetEntryPoint(string placementGuid, string entryPoint) { }

	// RVA: 0x13361A0
	void Tapjoy_SetUserID(string userId) { }

	// RVA: 0x13361FC
	string Tapjoy_GetUserID() { }

	// RVA: 0x133625C
	void Tapjoy_SetCustomParameter(string customParam) { }

	// RVA: 0x13362B8
	string Tapjoy_GetCustomParameter() { }

	// RVA: 0x13362F4
	void Tapjoy_SetUserLevel(int userLevel) { }

	// RVA: 0x13362FC
	int Tapjoy_GetUserLevel() { }

	// RVA: 0x1336308
	void Tapjoy_SetMaxLevel(int maxLevel) { }

	// RVA: 0x1336310
	int Tapjoy_GetMaxLevel() { }

	// RVA: 0x133631C
	void Tapjoy_SetUserSegment(TJSegment userSegment) { }

	// RVA: 0x1336324
	int Tapjoy_GetUserSegment() { }

	// RVA: 0x133632C
	Double Tapjoy_GetScreenScale() { }

	// RVA: 0x1336334
	void Tapjoy_ClearUserTags() { }

	// RVA: 0x1336524
	string Tapjoy_GetUserTags() { }

	// RVA: 0x1336744
	void Tapjoy_AddUserTag(string tag) { }

	// RVA: 0x1336798
	void Tapjoy_RemoveUserTag(string tag) { }

	// RVA: 0x13367FC
	void Tapjoy_TrackPurchase(string currencyCode, Double price) { }

	// RVA: 0x1336834
	string GetStringFromNativeUtf8(IntPtr nativeUtf8) { }

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

	// RVA: 0x1337FC0
	void .ctor(InternalEventType _type, string _data) { }

}

// Namespace: TapjoyUnity.Internal
public class TapjoyComponent 
{
	// Fields
	private const string GAME_OBJECT_NAME = 5730682048;
	private const string DISABLE_ADVERTISING_ID_CHECK = 5735916192;
	private static bool applicationPaused; // 0x0
	private static bool isConnecting; // 0x1
	private static bool triedConnecting; // 0x2
	private static PlatformSettings app; // 0x8
	private static GameObject singletonGameObject; // 0x10
	private System.Collections.Generic.Dictionary<System.String,System.Object> lastConnectFlags; // 0x20
	private static Queue events; // 0x18
	public TapjoySettings settings; // 0x28

	// Methods

	// RVA: 0x132A980
	TapjoyComponent FindInstance() { }

	// RVA: 0x1336960
	void Awake() { }

	// RVA: 0x1336F24
	void OnApiBindingSet() { }

	// RVA: 0x1336CDC
	void EnsureSingleton() { }

	// RVA: 0x132AA24
	void Reconnect() { }

	// RVA: 0x1336F60
	bool ConnectManually() { }

	// RVA: 0x132AD84
	bool ConnectManually(string sdkKey) { }

	// RVA: 0x132AF54
	bool ConnectManually(string sdkKey, System.Collections.Generic.Dictionary<System.String,System.Object> flags) { }

	// RVA: 0x1336FF4
	bool ConnectInternal(System.Collections.Generic.Dictionary<System.String,System.Object> connectFlags) { }

	// RVA: 0x133766C
	void OnDestroy() { }

	// RVA: 0x13378EC
	void HandleOnConnectSuccess() { }

	// RVA: 0x1337968
	void HandleOnConnectFailed(int code, string message) { }

	// RVA: 0x13379E4
	void HandleOnConnectWarning(int code, string message) { }

	// RVA: 0x13379E8
	void Start() { }

	// RVA: 0x1337AE8
	void Update() { }

	// RVA: 0x1337CE4
	void OnApplicationPause(bool paused) { }

	// RVA: 0x1337E6C
	void OnApplicationQuit() { }

	// RVA: 0x1337F20
	void OnNativeConnectCallback(string commaDelimitedMessage) { }

	// RVA: 0x1337F28
	void OnNativeSetUserIDCallback(string commaDelimitedMessage) { }

	// RVA: 0x1337F30
	void OnNativeCurrencyCallback(string commaDelimitedMessage) { }

	// RVA: 0x1337F38
	void OnNativePlacementCallback(string commaDelimitedMessage) { }

	// RVA: 0x1337FB8
	void OnNativeOfferwallDiscoverCallback(string commaDelimitedMessage) { }

	// RVA: 0x133025C
	void RemovePlacement(string placementID) { }

	// RVA: 0x132F010
	void RemoveActionRequest(string requestID) { }

	// RVA: 0x1337FD0
	void .ctor() { }

	// RVA: 0x1337FD8
	void .cctor() { }

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

	// RVA: 0x1338078
	PlatformSettings get_AndroidSettings() { }

	// RVA: 0x1338080
	IosPlatformSettings get_IosSettings() { }

	// RVA: 0x1338088
	bool get_AutoConnectEnabled() { }

	// RVA: 0x1338090
	void set_AutoConnectEnabled(bool value) { }

	// RVA: 0x13380AC
	bool get_DebugEnabled() { }

	// RVA: 0x13380B4
	void set_DebugEnabled(bool value) { }

	// RVA: 0x13380D0
	bool get_Dirty() { }

	// RVA: 0x1338128
	void set_Dirty(bool value) { }

	// RVA: 0x1338158
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x1338A88
	void .cctor() { }

	// RVA: 0x1338AF4
	void .ctor() { }

	// RVA: 0x1338AFC
	void <Awake>b__1_0(Scene oldScene, Scene newScene) { }

	// RVA: 0x1338BA8
	void <Awake>b__1_1(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1338C44
	void <Awake>b__1_2(Scene scene) { }

	// RVA: 0x1338CCC
	int <Awake>b__1_3() { }

	// RVA: 0x1338D3C
	SceneCompat <Awake>b__1_4() { }

	// RVA: 0x1338DBC
	SceneCompat <Awake>b__1_5(int index) { }

}

// Namespace: TapjoyUnity.Internal
public sealed class TapjoyUnityInit 
{
	// Fields
	private static bool initialized; // 0x0

	// Methods

	// RVA: 0x1338294
	void Awake() { }

	// RVA: 0x1338858
	SceneCompat Wrap(Scene scene) { }

	// RVA: 0x1338A80
	void .ctor() { }

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

	// RVA: 0x1338FCC
	void .ctor(int <>1__state) { }

	// RVA: 0x133C30C
	void System.IDisposable.Dispose() { }

	// RVA: 0x133C310
	bool MoveNext() { }

	// RVA: 0x133C330
	JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x133C338
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x133C378
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x133C380
	System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x133C420
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x133908C
	void .ctor(int <>1__state) { }

	// RVA: 0x133C4C0
	void System.IDisposable.Dispose() { }

	// RVA: 0x133C6B0
	bool MoveNext() { }

	// RVA: 0x133CD4C
	void <>m__Finally1() { }

	// RVA: 0x133CC88
	void <>m__Finally2() { }

	// RVA: 0x133CE10
	JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x133CE18
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x133CE58
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x133CE60
	System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x133CF14
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public abstract class JSONNode 
{
	// Fields
	internal static StringBuilder m_EscapeBuilder; // 0x0

	// Methods

	// RVA: 0x1338E44
	JSONNode get_Item(int aIndex) { }

	// RVA: 0x1338E4C
	void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1338E50
	JSONNode get_Item(string aKey) { }

	// RVA: 0x1338E58
	void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1338E5C
	string get_Value() { }

	// RVA: 0x1338EA0
	void set_Value(string value) { }

	// RVA: 0x1338EA4
	int get_Count() { }

	// RVA: 0x1338EAC
	bool get_IsNumber() { }

	// RVA: 0x1338EB4
	bool get_IsString() { }

	// RVA: 0x1338EBC
	bool get_IsBoolean() { }

	// RVA: 0x1338EC4
	bool get_IsNull() { }

	// RVA: 0x1338ECC
	bool get_IsArray() { }

	// RVA: 0x1338ED4
	bool get_IsObject() { }

	// RVA: 0x1338EDC
	void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1338EE0
	void Add(JSONNode aItem) { }

	// RVA: 0x1338F48
	JSONNode Remove(string aKey) { }

	// RVA: 0x1338F50
	JSONNode Remove(int aIndex) { }

	// RVA: 0x1338F58
	JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x1338F60
	System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x1339004
	System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_DeepChildren() { }

	// RVA: 0x13390C4
	string ToString() { }

	// RVA: 0x133915C
	string ToString(int aIndent) { }

	// RVA: -1
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x2FE32D4
	JSONNodeType get_Tag() { }

	// RVA: 0x13391F8
	Double get_AsDouble() { }

	// RVA: 0x133923C
	void set_AsDouble(Double value) { }

	// RVA: 0x1339284
	int get_AsInt() { }

	// RVA: 0x13392BC
	void set_AsInt(int value) { }

	// RVA: 0x13392D0
	float get_AsFloat() { }

	// RVA: 0x13392F4
	void set_AsFloat(float value) { }

	// RVA: 0x1339308
	bool get_AsBool() { }

	// RVA: 0x13393E8
	void set_AsBool(bool value) { }

	// RVA: 0x133946C
	JSONArray get_AsArray() { }

	// RVA: 0x13394F0
	JSONObject get_AsObject() { }

	// RVA: 0x1339574
	JSONNode op_Implicit(string s) { }

	// RVA: 0x13365D8
	string op_Implicit(JSONNode d) { }

	// RVA: 0x133981C
	JSONNode op_Implicit(Double n) { }

	// RVA: 0x1339940
	Double op_Implicit(JSONNode d) { }

	// RVA: 0x1339A84
	JSONNode op_Implicit(float n) { }

	// RVA: 0x1339B34
	float op_Implicit(JSONNode d) { }

	// RVA: 0x1339C78
	JSONNode op_Implicit(int n) { }

	// RVA: 0x1339D28
	int op_Implicit(JSONNode d) { }

	// RVA: 0x1339E6C
	JSONNode op_Implicit(bool b) { }

	// RVA: 0x1339F80
	bool op_Implicit(JSONNode d) { }

	// RVA: 0x133969C
	bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x133A0C4
	bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x133A134
	bool Equals(object obj) { }

	// RVA: 0x133A140
	int GetHashCode() { }

	// RVA: 0x133A148
	string Escape(string aText) { }

	// RVA: 0x133A52C
	void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	// RVA: 0x133AA30
	JSONNode Parse(string aJSON) { }

	// RVA: 0x133B304
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x133B308
	void SaveToStream(Stream aData) { }

	// RVA: 0x133B384
	void SaveToCompressedStream(Stream aData) { }

	// RVA: 0x133B3D8
	void SaveToCompressedFile(string aFileName) { }

	// RVA: 0x133B42C
	string SaveToCompressedBase64() { }

	// RVA: 0x133B480
	void SaveToFile(string aFileName) { }

	// RVA: 0x133B660
	string SaveToBase64() { }

	// RVA: 0x133B890
	JSONNode Deserialize(BinaryReader aReader) { }

	// RVA: 0x133BDA0
	JSONNode LoadFromCompressedFile(string aFileName) { }

	// RVA: 0x133BDF4
	JSONNode LoadFromCompressedStream(Stream aData) { }

	// RVA: 0x133BE48
	JSONNode LoadFromCompressedBase64(string aBase64) { }

	// RVA: 0x133BE9C
	JSONNode LoadFromStream(Stream aData) { }

	// RVA: 0x133C020
	JSONNode LoadFromFile(string aFileName) { }

	// RVA: 0x133C188
	JSONNode LoadFromBase64(string aBase64) { }

	// RVA: 0x133C27C
	void .ctor() { }

	// RVA: 0x133C284
	void .cctor() { }

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

	// RVA: 0x133D9E4
	void .ctor(int <>1__state) { }

	// RVA: 0x133DD98
	void System.IDisposable.Dispose() { }

	// RVA: 0x133DE14
	bool MoveNext() { }

	// RVA: 0x133E084
	void <>m__Finally1() { }

	// RVA: 0x133E0E0
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x133E0E8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x133E128
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x133D934
	void .ctor(int <>1__state) { }

	// RVA: 0x133E130
	void System.IDisposable.Dispose() { }

	// RVA: 0x133E1AC
	bool MoveNext() { }

	// RVA: 0x133E41C
	void <>m__Finally1() { }

	// RVA: 0x133E478
	JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x133E480
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x133E4C0
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x133E4C8
	System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x133E57C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONArray 
{
	// Fields
	private System.Collections.Generic.List<TapjoyUnity.Internal.SimpleJSON.JSONNode> m_List; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x133CF18
	JSONNodeType get_Tag() { }

	// RVA: 0x133CF20
	bool get_IsArray() { }

	// RVA: 0x133CF28
	JSONNode get_Item(int aIndex) { }

	// RVA: 0x133D0E4
	void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x133D2F0
	JSONNode get_Item(string aKey) { }

	// RVA: 0x133D3B0
	void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x133D564
	int get_Count() { }

	// RVA: 0x133D5B0
	void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x133D764
	JSONNode Remove(int aIndex) { }

	// RVA: 0x133D840
	JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x133D8AC
	System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x133D96C
	IEnumerator GetEnumerator() { }

	// RVA: 0x133DA10
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x133DB00
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x133B24C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0 
{
	// Fields
	public JSONNode aNode; // 0x10

	// Methods

	// RVA: 0x133F600
	void .ctor() { }

	// RVA: 0x133FF0C
	bool <Remove>b__0(System.Collections.Generic.KeyValuePair<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> k) { }

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

	// RVA: 0x133F740
	void .ctor(int <>1__state) { }

	// RVA: 0x1340020
	void System.IDisposable.Dispose() { }

	// RVA: 0x134009C
	bool MoveNext() { }

	// RVA: 0x1340344
	void <>m__Finally1() { }

	// RVA: 0x13403A0
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x13403A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x13403E8
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x133F690
	void .ctor(int <>1__state) { }

	// RVA: 0x13403F0
	void System.IDisposable.Dispose() { }

	// RVA: 0x134046C
	bool MoveNext() { }

	// RVA: 0x1340780
	void <>m__Finally1() { }

	// RVA: 0x13407DC
	JSONNode System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode>.get_Current() { }

	// RVA: 0x13407E4
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1340824
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x134082C
	System.Collections.Generic.IEnumerator<TapjoyUnity.Internal.SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode>.GetEnumerator() { }

	// RVA: 0x13408E0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONObject 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,TapjoyUnity.Internal.SimpleJSON.JSONNode> m_Dict; // 0x10
	public bool inline; // 0x18

	// Methods

	// RVA: 0x133E580
	JSONNodeType get_Tag() { }

	// RVA: 0x133E588
	bool get_IsObject() { }

	// RVA: 0x133E590
	JSONNode get_Item(string aKey) { }

	// RVA: 0x133E75C
	void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x133E980
	JSONNode get_Item(int aIndex) { }

	// RVA: 0x133EAD4
	void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x133ED90
	int get_Count() { }

	// RVA: 0x133EDE4
	void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x133F080
	JSONNode Remove(string aKey) { }

	// RVA: 0x133F16C
	JSONNode Remove(int aIndex) { }

	// RVA: 0x133F378
	JSONNode Remove(JSONNode aNode) { }

	// RVA: 0x133F608
	System.Collections.Generic.IEnumerable<TapjoyUnity.Internal.SimpleJSON.JSONNode> get_Children() { }

	// RVA: 0x133F6C8
	IEnumerator GetEnumerator() { }

	// RVA: 0x133F76C
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x133FA2C
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x133B194
	void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONString 
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x13408E4
	JSONNodeType get_Tag() { }

	// RVA: 0x13408EC
	bool get_IsString() { }

	// RVA: 0x13408F4
	string get_Value() { }

	// RVA: 0x13408FC
	void set_Value(string value) { }

	// RVA: 0x1339624
	void .ctor(string aData) { }

	// RVA: 0x1340904
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1340954
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x13409FC
	bool Equals(object obj) { }

	// RVA: 0x1340C30
	int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNumber 
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x1340C54
	JSONNodeType get_Tag() { }

	// RVA: 0x1340C5C
	bool get_IsNumber() { }

	// RVA: 0x1340C64
	string get_Value() { }

	// RVA: 0x1340C70
	void set_Value(string value) { }

	// RVA: 0x1340CB8
	Double get_AsDouble() { }

	// RVA: 0x1340CC0
	void set_AsDouble(Double value) { }

	// RVA: 0x13398C8
	void .ctor(Double aData) { }

	// RVA: 0x1340CC8
	void .ctor(string aData) { }

	// RVA: 0x1340D44
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x1340D94
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1340DB8
	bool IsNumeric(object value) { }

	// RVA: 0x1340F64
	bool Equals(object obj) { }

	// RVA: 0x13411AC
	int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONBool 
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x13411CC
	JSONNodeType get_Tag() { }

	// RVA: 0x13411D4
	bool get_IsBoolean() { }

	// RVA: 0x13411DC
	string get_Value() { }

	// RVA: 0x1341264
	void set_Value(string value) { }

	// RVA: 0x1341324
	bool get_AsBool() { }

	// RVA: 0x134132C
	void set_AsBool(bool value) { }

	// RVA: 0x1339F10
	void .ctor(bool aData) { }

	// RVA: 0x1341334
	void .ctor(string aData) { }

	// RVA: 0x13413B0
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13413FC
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x1341480
	bool Equals(object obj) { }

	// RVA: 0x1341510
	int GetHashCode() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public class JSONNull 
{
	// Methods

	// RVA: 0x1341598
	JSONNodeType get_Tag() { }

	// RVA: 0x13415A0
	bool get_IsNull() { }

	// RVA: 0x13415A8
	string get_Value() { }

	// RVA: 0x13415EC
	void set_Value(string value) { }

	// RVA: 0x13415F0
	bool get_AsBool() { }

	// RVA: 0x13415F8
	void set_AsBool(bool value) { }

	// RVA: 0x13415FC
	bool Equals(object obj) { }

	// RVA: 0x13416AC
	int GetHashCode() { }

	// RVA: 0x13416B4
	void Serialize(BinaryWriter aWriter) { }

	// RVA: 0x13416DC
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x133BD18
	void .ctor() { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
internal class JSONLazyCreator 
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x1341734
	JSONNodeType get_Tag() { }

	// RVA: 0x133D05C
	void .ctor(JSONNode aNode) { }

	// RVA: 0x133E6C8
	void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x134173C
	void Set(JSONNode aVal) { }

	// RVA: 0x13417BC
	JSONNode get_Item(int aIndex) { }

	// RVA: 0x134187C
	void set_Item(int aIndex, JSONNode value) { }

	// RVA: 0x1341944
	JSONNode get_Item(string aKey) { }

	// RVA: 0x1341A10
	void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x1341AE8
	void Add(JSONNode aItem) { }

	// RVA: 0x1341BB0
	void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x1341C88
	bool op_Equality(JSONLazyCreator a, object b) { }

	// RVA: 0x1341C98
	bool op_Inequality(JSONLazyCreator a, object b) { }

	// RVA: 0x1341CA8
	bool Equals(object obj) { }

	// RVA: 0x1341CB8
	int GetHashCode() { }

	// RVA: 0x1341CC0
	int get_AsInt() { }

	// RVA: 0x1341DD8
	void set_AsInt(int value) { }

	// RVA: 0x1341F04
	float get_AsFloat() { }

	// RVA: 0x134201C
	void set_AsFloat(float value) { }

	// RVA: 0x1342140
	Double get_AsDouble() { }

	// RVA: 0x1342258
	void set_AsDouble(Double value) { }

	// RVA: 0x1342374
	bool get_AsBool() { }

	// RVA: 0x134248C
	void set_AsBool(bool value) { }

	// RVA: 0x13425A8
	JSONArray get_AsArray() { }

	// RVA: 0x1342658
	JSONObject get_AsObject() { }

	// RVA: 0x1342708
	void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: TapjoyUnity.Internal.SimpleJSON
public static class JSON 
{
	// Methods

	// RVA: 0x1336558
	JSONNode Parse(string aJSON) { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
public class JsonUtilityCompat 
{
	// Methods

	// RVA: 0x1342760
	string ToJson(object obj) { }

	// RVA: 0x134280C
	void .ctor() { }

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

	// RVA: 0x13389A8
	void .ctor(object scene, bool valid, int buildIndex, string name, string path) { }

	// RVA: 0x1342814
	int GetHashCode() { }

	// RVA: 0x134281C
	bool IsValid() { }

	// RVA: 0x1342824
	int get_buildIndex() { }

	// RVA: 0x134295C
	string get_name() { }

	// RVA: 0x1342964
	string get_path() { }

	// RVA: 0x134296C
	void .cctor() { }

}

// Namespace: TapjoyUnity.Internal.UnityCompat
internal class SceneManagerCompat 
{
	// Fields
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat,TapjoyUnity.Internal.UnityCompat.SceneCompat> activeSceneChanged; // 0x0
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat,System.Int32> sceneLoaded; // 0x8
	internal static TapjoyUnity.TapjoyAction<TapjoyUnity.Internal.UnityCompat.SceneCompat> sceneUnloaded; // 0x10

	// Methods

	// RVA: 0x1342970
	int get_sceneCount() { }

	// RVA: 0x13429F4
	SceneCompat GetActiveScene() { }

	// RVA: 0x1342ABC
	SceneCompat GetSceneAt(int index) { }

	// RVA: 0x1342B94
	void .ctor() { }

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

	// RVA: 0x132DCD8
	UInt32 ComputeStringHash(string s) { }

}


