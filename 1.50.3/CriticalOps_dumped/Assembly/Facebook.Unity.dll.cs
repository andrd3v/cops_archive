// Namespace: 
internal class <Module>
{}

// Namespace: 
public enum TournamentSortOrder
{
	// Fields
	public int value__; // 0x10
	public const TournamentSortOrder HigherIsBetter = 0;
	public const TournamentSortOrder LowerIsBetter = 1;
}

// Namespace: 
public enum TournamentScoreFormat
{
	// Fields
	public int value__; // 0x10
	public const TournamentScoreFormat Numeric = 0;
	public const TournamentScoreFormat Time = 1;
}

// Namespace: 
private enum TOKEN
{
	// Fields
	public int value__; // 0x10
	public const TOKEN NONE = 0;
	public const TOKEN CURLY_OPEN = 1;
	public const TOKEN CURLY_CLOSE = 2;
	public const TOKEN SQUARED_OPEN = 3;
	public const TOKEN SQUARED_CLOSE = 4;
	public const TOKEN COLON = 5;
	public const TOKEN COMMA = 6;
	public const TOKEN STRING = 7;
	public const TOKEN NUMBER = 8;
	public const TOKEN TRUE = 9;
	public const TOKEN FALSE = 10;
	public const TOKEN NULL = 11;
}

// Namespace: 
private sealed class Parser
{
	// Fields
	private StringReader json; // 0x10

	// Methods

	// RVA: 0x769258
	private void .ctor(string jsonString) { }

	// RVA: 0x7692D8
	private Char get_PeekChar() { }

	// RVA: 0x769364
	private Char get_NextChar() { }

	// RVA: 0x7693F0
	private string get_NextWord() { }

	// RVA: 0x76957C
	private TOKEN get_NextToken() { }

	// RVA: 0x768F0C
	public static object Parse(string jsonString) { }

	// RVA: 0x769940
	public void Dispose() { }

	// RVA: 0x76997C
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x769FA4
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x769918
	private object ParseValue() { }

	// RVA: 0x76A0B4
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x769B08
	private string ParseString() { }

	// RVA: 0x76A1C0
	private object ParseNumber() { }

	// RVA: 0x769820
	private void EatWhitespace() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x76A2CC
	private void .ctor() { }

	// RVA: 0x7690C8
	public static string Serialize(object obj) { }

	// RVA: 0x76A344
	private void SerializeValue(object value) { }

	// RVA: 0x76AB20
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x76A7D8
	private void SerializeArray(IList array) { }

	// RVA: 0x76A51C
	private void SerializeString(string str) { }

	// RVA: 0x76AFA4
	private void SerializeOther(object value) { }

}

// Namespace: Facebook.MiniJSON
public static class Json
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x768F00
	public static object Deserialize(string json) { }

	// RVA: 0x7690C4
	public static string Serialize(object obj) { }

	// RVA: 0x76919C
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public class AccessToken
{
	// Fields
	private static AccessToken <CurrentAccessToken>k__BackingField; // 0x0
	private string <TokenString>k__BackingField; // 0x10
	private DateTime <ExpirationTime>k__BackingField; // 0x18
	private System.Collections.Generic.IEnumerable<System.String> <Permissions>k__BackingField; // 0x20
	private string <UserId>k__BackingField; // 0x28
	private System.Nullable<System.DateTime> <LastRefresh>k__BackingField; // 0x30
	private string <GraphDomain>k__BackingField; // 0x40

	// Methods

	// RVA: 0x76B190
	internal void .ctor(string tokenString, string userId, DateTime expirationTime, System.Collections.Generic.IEnumerable<System.String> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain) { }

	// RVA: 0x76B380
	public static AccessToken get_CurrentAccessToken() { }

	// RVA: 0x76B3CC
	internal static void set_CurrentAccessToken(AccessToken value) { }

	// RVA: 0x76B430
	public string get_TokenString() { }

	// RVA: 0x76B438
	private void set_TokenString(string value) { }

	// RVA: 0x76B440
	public DateTime get_ExpirationTime() { }

	// RVA: 0x76B448
	private void set_ExpirationTime(DateTime value) { }

	// RVA: 0x76B450
	public System.Collections.Generic.IEnumerable<System.String> get_Permissions() { }

	// RVA: 0x76B458
	private void set_Permissions(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x76B460
	public string get_UserId() { }

	// RVA: 0x76B468
	private void set_UserId(string value) { }

	// RVA: 0x76B470
	public System.Nullable<System.DateTime> get_LastRefresh() { }

	// RVA: 0x76B47C
	private void set_LastRefresh(System.Nullable<System.DateTime> value) { }

	// RVA: 0x76B484
	public string get_GraphDomain() { }

	// RVA: 0x76B48C
	private void set_GraphDomain(string value) { }

	// RVA: 0x76B494
	public override string ToString() { }

	// RVA: 0x76BEDC
	internal string ToJson() { }

}

// Namespace: Facebook.Unity
internal class CallbackManager
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: 0x30D3DA0
	public string AddFacebookDelegate(Facebook.Unity.FacebookDelegate<T> callback) { }

	// RVA: 0x76C184
	public void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x76C454
	private static void CallCallback(object callback, IResult result) { }

	// RVA: 0x30D6128
	private static bool TryCallCallback(object callback, IResult result) { }

	// RVA: 0x76CBD8
	public void .ctor() { }

}

// Namespace: 
internal enum IfNotExist
{
	// Fields
	public int value__; // 0x10
	public const IfNotExist AddNew = 0;
	public const IfNotExist ReturnNull = 1;
}

// Namespace: Facebook.Unity
internal class ComponentFactory
{
	// Fields
	private static GameObject facebookGameObject; // 0x0

	// Methods

	// RVA: 0x76CC64
	private static GameObject get_FacebookGameObject() { }

	// RVA: 0x318DB98
	public static T GetComponent(IfNotExist ifNotExist) { }

	// RVA: 0x318DB98
	public static T AddComponent() { }

}

// Namespace: Facebook.Unity
internal static class Constants
{
	// Fields
	private static System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform; // 0x0

	// Methods

	// RVA: 0x76CD88
	public static Uri get_GraphUrl() { }

	// RVA: 0x76D0B8
	public static string get_GraphApiUserAgent() { }

	// RVA: 0x76D45C
	public static bool get_IsEditor() { }

	// RVA: 0x76D4CC
	public static bool get_IsWeb() { }

	// RVA: 0x76D668
	public static string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x76D3E4
	public static string get_UnitySDKUserAgent() { }

	// RVA: 0x76D8FC
	public static bool get_DebugMode() { }

	// RVA: 0x76D4E8
	public static FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x76D96C
	private static FacebookUnityPlatform GetCurrentPlatform() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateContent
{
	// Fields
	private string _contextTokenId; // 0x10
	private CustomUpdateLocalizedText _text; // 0x18
	private CustomUpdateLocalizedText _cta; // 0x20
	private string _image; // 0x28
	private CustomUpdateMedia _media; // 0x30
	private string _data; // 0x38

	// Methods

	// RVA: 0x76D9FC
	public System.Collections.Generic.IDictionary<System.String,System.String> toGraphAPIData() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText
{
	// Fields
	private string _default; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> _localizations; // 0x18

	// Methods

	// RVA: 0x76DBAC
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x76DCCC
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo
{
	// Fields
	private string _url; // 0x10

	// Methods

	// RVA: 0x76DEB0
	public string get_Url() { }

}

// Namespace: 
private sealed class OnDLLLoaded
{
	// Methods

	// RVA: 0x76F3F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x77276C
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class Mobile
{
	// Methods

	// RVA: 0x772780
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x772860
	public static void LoginWithTrackingPreference(LoginTracking loginTracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7729A0
	public static AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x772A58
	public static Profile CurrentProfile() { }

	// RVA: 0x772B10
	public static void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x772BD4
	public static bool IsImplicitPurchaseLoggingEnabled() { }

}

// Namespace: 
internal abstract class CompiledFacebookLoader
{
	// Methods

	// RVA: -1
	protected abstract FacebookGameObject get_FBGameObject() { }

	// RVA: 0x772C8C
	public void Start() { }

	// RVA: 0x772DD0
	protected void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public string appId; // 0x10
	public HideUnityDelegate onHideUnity; // 0x18
	public InitDelegate onInitComplete; // 0x20
	public bool cookie; // 0x28
	public bool logging; // 0x29
	public bool status; // 0x2A
	public bool xfbml; // 0x2B
	public string authResponse; // 0x30
	public bool frictionlessRequests; // 0x38
	public string javascriptSDKLocale; // 0x40
	public string clientToken; // 0x48

	// Methods

	// RVA: 0x76F3F0
	public void .ctor() { }

	// RVA: 0x772DD8
	internal void <Init>b__0() { }

	// RVA: 0x772FE8
	internal void <Init>b__1() { }

	// RVA: 0x7730C0
	internal void <Init>b__2() { }

	// RVA: 0x773288
	internal void <Init>b__3() { }

	// RVA: 0x773398
	internal void <Init>b__4() { }

	// RVA: 0x773458
	internal void <Init>b__5() { }

}

// Namespace: Facebook.Unity
public sealed class FB
{
	// Fields
	private const string DefaultJSSDKLocale = "en_US";
	private static IFacebook facebook; // 0x0
	private static bool isInitCalled; // 0x8
	private static string facebookDomain; // 0x10
	private static string gamingDomain; // 0x18
	private static string graphApiVersion; // 0x20
	private static string <AppId>k__BackingField; // 0x28
	private static string <ClientToken>k__BackingField; // 0x30
	private static OnDLLLoaded <OnDLLLoadedDelegate>k__BackingField; // 0x38

	// Methods

	// RVA: 0x76DEB8
	public static string get_AppId() { }

	// RVA: 0x76DF34
	private static void set_AppId(string value) { }

	// RVA: 0x76DFA0
	public static string get_ClientToken() { }

	// RVA: 0x76E01C
	private static void set_ClientToken(string value) { }

	// RVA: 0x76E088
	public static string get_GraphApiVersion() { }

	// RVA: 0x76E104
	public static void set_GraphApiVersion(string value) { }

	// RVA: 0x76E170
	public static bool get_IsLoggedIn() { }

	// RVA: 0x76E28C
	public static bool get_IsInitialized() { }

	// RVA: 0x76E3B0
	public static bool get_LimitAppEventUsage() { }

	// RVA: 0x76E4D4
	public static void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x76D2F8
	internal static IFacebook get_FacebookImpl() { }

	// RVA: 0x76E5F8
	internal static void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x76CF74
	internal static string get_FacebookDomain() { }

	// RVA: 0x76E66C
	internal static void set_FacebookDomain(string value) { }

	// RVA: 0x76E6D8
	private static OnDLLLoaded get_OnDLLLoadedDelegate() { }

	// RVA: 0x76E754
	private static void set_OnDLLLoadedDelegate(OnDLLLoaded value) { }

	// RVA: 0x76E7C0
	public static void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x76E900
	public static void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x76F5D8
	public static void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x76F6D0
	public static void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x76F7C8
	public static void LogOut() { }

	// RVA: 0x76F8B8
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76FA20
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76FB90
	public static void AppRequest(string message, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76FCE0
	public static void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76FE00
	public static void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76FF4C
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x7700B4
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x77021C
	public static void ActivateApp() { }

	// RVA: 0x770360
	public static void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x770458
	public static void ClearAppLink() { }

	// RVA: 0x77045C
	public static void LogAppEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x770564
	public static void LogPurchase(Decimal logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x770650
	public static void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x770778
	private static void LogVersion() { }

	// RVA: 0x770AB0
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x770BA0
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x770C90
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x770D98
	public static void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x770E90
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x770F80
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x771070
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x771168
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x771260
	public static Profile CurrentProfile() { }

	// RVA: 0x771350
	public static void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x771440
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x771538
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x771630
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x771728
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x771820
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x771910
	public static void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x771A00
	public static void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x771AF8
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x771C20
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x771D18
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x771E10
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x771F00
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x772008
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x772150
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x772260
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x772370
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77248C
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7725AC
	public static void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x77269C
	public void .ctor() { }

	// RVA: 0x7726A4
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public sealed class FBGamingServices
{
	// Methods

	// RVA: 0x773514
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7736B8
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x773790
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x773868
	public static void PerformCustomUpdate(CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x773900
	public static void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7739C4
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x773A88
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x773B4C
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x773C14
	public static void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x773CD4
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x773D98
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x773E5C
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x773F1C
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x773FDC
	public static void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7740A0
	public static void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x774164
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x774254
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x774314
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7743D4
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x774494
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x774554
	public static void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x774618
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7746D8
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77479C
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x774864
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77496C
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x774A2C
	public static void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x774AF0
	public static void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x774BB0
	public static void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x774C70
	public static void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x774D48
	public static void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7735D8
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x774E0C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Facebook.Unity.FacebookBase.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__41_0; // 0x8

	// Methods

	// RVA: 0x7763C0
	private static void .cctor() { }

	// RVA: 0x77642C
	public void .ctor() { }

	// RVA: 0x776434
	internal bool <ValidateAppRequestArgs>b__41_0(string toWhom) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookBase
{
	// Fields
	private InitDelegate onInitCompleteDelegate; // 0x10
	private bool <Initialized>k__BackingField; // 0x18
	private CallbackManager <CallbackManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x774E14
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract bool get_LimitEventUsage() { }

	// RVA: -1
	public abstract void set_LimitEventUsage(bool value) { }

	// RVA: -1
	public abstract string get_SDKName() { }

	// RVA: -1
	public abstract string get_SDKVersion() { }

	// RVA: 0x774E48
	public virtual string get_SDKUserAgent() { }

	// RVA: 0x774E94
	public virtual bool get_LoggedIn() { }

	// RVA: 0x774F68
	public bool get_Initialized() { }

	// RVA: 0x774F70
	public void set_Initialized(bool value) { }

	// RVA: 0x774F78
	protected CallbackManager get_CallbackManager() { }

	// RVA: 0x774F80
	private void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x774F88
	public virtual void Init(InitDelegate onInitComplete) { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x774F90
	public virtual void LogOut() { }

	// RVA: -1
	public abstract void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: -1
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x774FE8
	public void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x775AB8
	public void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void ActivateApp(string appId) { }

	// RVA: -1
	public abstract void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	public abstract void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x775D04
	public virtual void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x775E74
	public void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x775ECC
	protected void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x776314
	protected virtual void OnAuthResponse(LoginResult result) { }

	// RVA: 0x775398
	private System.Collections.Generic.IDictionary<System.String,System.String> CopyByValue(System.Collections.Generic.IDictionary<System.String,System.String> data) { }

	// RVA: 0x7759F0
	private Uri GetGraphUrl(string query) { }

	// RVA: -1
	public abstract void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: -1
	public abstract void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: -1
	public abstract void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: -1
	public abstract void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: -1
	public abstract void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: -1
	public abstract void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: -1
	public abstract void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: -1
	public abstract void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: -1
	public abstract Profile CurrentProfile() { }

	// RVA: -1
	public abstract void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: -1
	public abstract void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: -1
	public abstract void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: -1
	public abstract void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: -1
	public abstract void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: -1
	public abstract void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	public abstract void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: -1
	public abstract void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: -1
	public abstract void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	public abstract void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	public abstract void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77639C
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7763A0
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7763A4
	private void <OnInitComplete>b__35_0(ILoginResult result) { }

}

// Namespace: Facebook.Unity
public sealed class InitDelegate
{
	// Methods

	// RVA: 0x776440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7764E0
	public virtual void Invoke() { }

}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T result) { }

}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate
{
	// Methods

	// RVA: 0x7764F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x776598
	public virtual void Invoke(bool isUnityShown) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject
{
	// Fields
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Methods

	// RVA: 0x7765AC
	public IFacebookImplementation get_Facebook() { }

	// RVA: 0x7765B4
	public void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x7765BC
	public void Awake() { }

	// RVA: 0x77669C
	public void OnInitComplete(string message) { }

	// RVA: 0x776908
	public void OnLoginComplete(string message) { }

	// RVA: 0x7769E8
	public void OnLogoutComplete(string message) { }

	// RVA: 0x776AC8
	public void OnGetAppLinkComplete(string message) { }

	// RVA: 0x776BA8
	public void OnAppRequestsComplete(string message) { }

	// RVA: 0x776C88
	public void OnShareLinkComplete(string message) { }

	// RVA: 0x776D68
	protected virtual void OnAwake() { }

	// RVA: 0x776D6C
	protected void .ctor() { }

}

// Namespace: Facebook.Unity
public class FacebookSdkVersion
{
	// Methods

	// RVA: 0x76D788
	public static string get_Build() { }

}

// Namespace: Facebook.Unity
internal enum FacebookUnityPlatform
{
	// Fields
	public int value__; // 0x10
	public const FacebookUnityPlatform Unknown = 0;
	public const FacebookUnityPlatform Android = 1;
	public const FacebookUnityPlatform IOS = 2;
	public const FacebookUnityPlatform WebGL = 3;
	public const FacebookUnityPlatform Windows = 4;
}

// Namespace: Facebook.Unity
internal interface IFacebook
{
	// Methods

	// RVA: -1
	public abstract bool get_LoggedIn() { }

	// RVA: -1
	public abstract bool get_LimitEventUsage() { }

	// RVA: -1
	public abstract void set_LimitEventUsage(bool value) { }

	// RVA: -1
	public abstract string get_SDKUserAgent() { }

	// RVA: -1
	public abstract bool get_Initialized() { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogOut() { }

	// RVA: -1
	public abstract void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: -1
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void ActivateApp(string appId) { }

	// RVA: -1
	public abstract void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	public abstract void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: -1
	public abstract void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: -1
	public abstract void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: -1
	public abstract void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: -1
	public abstract void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: -1
	public abstract void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: -1
	public abstract void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: -1
	public abstract void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: -1
	public abstract Profile CurrentProfile() { }

	// RVA: -1
	public abstract void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: -1
	public abstract void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: -1
	public abstract void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: -1
	public abstract void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: -1
	public abstract void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: -1
	public abstract void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	public abstract void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: -1
	public abstract void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: -1
	public abstract void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	public abstract void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	public abstract void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookWindows
{
	// Methods

	// RVA: -1
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookCallbackHandler
{
	// Methods

	// RVA: -1
	public abstract void OnInitComplete(string message) { }

	// RVA: -1
	public abstract void OnLoginComplete(string message) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(string message) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(string message) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookImplementation
{}

// Namespace: Facebook.Unity
internal interface IFacebookResultHandler
{
	// Methods

	// RVA: -1
	public abstract void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class MethodArguments
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> arguments; // 0x10

	// Methods

	// RVA: 0x776D74
	public void .ctor() { }

	// RVA: 0x776E9C
	public void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x776DF0
	private void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> arguments) { }

	// RVA: 0x318DB98
	public void AddPrimative(string argumentName, T value) { }

	// RVA: 0x318DB98
	public void AddNullablePrimitive(string argumentName, System.Nullable<T> nullable) { }

	// RVA: 0x776EB8
	public void AddString(string argumentName, string value) { }

	// RVA: 0x776F98
	public void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7770E0
	public void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

	// RVA: 0x30D4F34
	public void AddList(string argumentName, System.Collections.Generic.IEnumerable<T> list) { }

	// RVA: 0x777640
	public void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x7777A8
	public string ToJsonString() { }

	// RVA: 0x7771C0
	private static System.Collections.Generic.Dictionary<System.String,System.String> ToStringDict(System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

}

// Namespace: Facebook.Unity
internal abstract class MethodCall<T0>
{
	// Fields
	private string <MethodName>k__BackingField; // 0x0
	private Facebook.Unity.FacebookDelegate<T> <Callback>k__BackingField; // 0x0
	private FacebookBase <FacebookImpl>k__BackingField; // 0x0
	private MethodArguments <Parameters>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(FacebookBase facebookImpl, string methodName) { }

	// RVA: 0x30D3CF0
	public string get_MethodName() { }

	// RVA: 0x30D4CD4
	private void set_MethodName(string value) { }

	// RVA: 0x30D3CF0
	protected Facebook.Unity.FacebookDelegate<T> get_Callback() { }

	// RVA: 0x30D4CD4
	public void set_Callback(Facebook.Unity.FacebookDelegate<T> value) { }

	// RVA: 0x30D4CD4
	protected void set_FacebookImpl(FacebookBase value) { }

	// RVA: 0x30D4CD4
	protected void set_Parameters(MethodArguments value) { }

	// RVA: -1
	public abstract void Call(MethodArguments args) { }

}

// Namespace: Facebook.Unity
public enum OGActionType
{
	// Fields
	public int value__; // 0x10
	public const OGActionType SEND = 0;
	public const OGActionType ASKFOR = 1;
	public const OGActionType TURN = 2;
}

// Namespace: Facebook.Unity
public class CurrencyAmount
{
	// Fields
	private string <Amount>k__BackingField; // 0x10
	private string <Currency>k__BackingField; // 0x18

	// Methods

	// RVA: 0x777830
	internal void .ctor(string amount, string currency) { }

	// RVA: 0x777880
	public string get_Amount() { }

	// RVA: 0x777888
	private void set_Amount(string value) { }

	// RVA: 0x777890
	public string get_Currency() { }

	// RVA: 0x777898
	private void set_Currency(string value) { }

	// RVA: 0x7778A0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class Product
{
	// Fields
	private string <Title>k__BackingField; // 0x10
	private string <ProductID>k__BackingField; // 0x18
	private string <Description>k__BackingField; // 0x20
	private string <ImageURI>k__BackingField; // 0x28
	private string <Price>k__BackingField; // 0x30
	private System.Nullable<System.Double> <PriceAmount>k__BackingField; // 0x38
	private string <PriceCurrencyCode>k__BackingField; // 0x48

	// Methods

	// RVA: 0x7779B4
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode) { }

	// RVA: 0x777B88
	public string get_Title() { }

	// RVA: 0x777B90
	private void set_Title(string value) { }

	// RVA: 0x777B98
	public string get_ProductID() { }

	// RVA: 0x777BA0
	private void set_ProductID(string value) { }

	// RVA: 0x777BA8
	public string get_Description() { }

	// RVA: 0x777BB0
	private void set_Description(string value) { }

	// RVA: 0x777BB8
	public string get_ImageURI() { }

	// RVA: 0x777BC0
	private void set_ImageURI(string value) { }

	// RVA: 0x777BC8
	public string get_Price() { }

	// RVA: 0x777BD0
	private void set_Price(string value) { }

	// RVA: 0x777BD8
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x777BE4
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x777BEC
	public string get_PriceCurrencyCode() { }

	// RVA: 0x777BF4
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x777BFC
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class Purchase
{
	// Fields
	private string <DeveloperPayload>k__BackingField; // 0x10
	private bool <IsConsumed>k__BackingField; // 0x18
	private string <PaymentActionType>k__BackingField; // 0x20
	private string <PaymentID>k__BackingField; // 0x28
	private string <ProductID>k__BackingField; // 0x30
	private string <PurchasePlatform>k__BackingField; // 0x38
	private CurrencyAmount <PurchasePrice>k__BackingField; // 0x40
	private DateTime <PurchaseTime>k__BackingField; // 0x48
	private string <PurchaseToken>k__BackingField; // 0x50
	private string <SignedRequest>k__BackingField; // 0x58

	// Methods

	// RVA: 0x777EEC
	internal void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest) { }

	// RVA: 0x778514
	public string get_DeveloperPayload() { }

	// RVA: 0x77851C
	private void set_DeveloperPayload(string value) { }

	// RVA: 0x778524
	public bool get_IsConsumed() { }

	// RVA: 0x77852C
	public string get_PaymentActionType() { }

	// RVA: 0x778534
	private void set_PaymentActionType(string value) { }

	// RVA: 0x77853C
	public string get_PaymentID() { }

	// RVA: 0x778544
	private void set_PaymentID(string value) { }

	// RVA: 0x77854C
	public string get_ProductID() { }

	// RVA: 0x778554
	private void set_ProductID(string value) { }

	// RVA: 0x77855C
	public string get_PurchasePlatform() { }

	// RVA: 0x778564
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x77856C
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x778574
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x77857C
	public DateTime get_PurchaseTime() { }

	// RVA: 0x778584
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x77858C
	public string get_PurchaseToken() { }

	// RVA: 0x778594
	private void set_PurchaseToken(string value) { }

	// RVA: 0x77859C
	public string get_SignedRequest() { }

	// RVA: 0x7785A4
	private void set_SignedRequest(string value) { }

	// RVA: 0x7785AC
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class SubscribableProduct
{
	// Fields
	private string <Title>k__BackingField; // 0x10
	private string <ProductID>k__BackingField; // 0x18
	private string <Description>k__BackingField; // 0x20
	private string <ImageURI>k__BackingField; // 0x28
	private string <Price>k__BackingField; // 0x30
	private System.Nullable<System.Double> <PriceAmount>k__BackingField; // 0x38
	private string <PriceCurrencyCode>k__BackingField; // 0x48
	private string <SubscriptionTerm>k__BackingField; // 0x50

	// Methods

	// RVA: 0x778904
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	// RVA: 0x778AF8
	public string get_Title() { }

	// RVA: 0x778B00
	private void set_Title(string value) { }

	// RVA: 0x778B08
	public string get_ProductID() { }

	// RVA: 0x778B10
	private void set_ProductID(string value) { }

	// RVA: 0x778B18
	public string get_Description() { }

	// RVA: 0x778B20
	private void set_Description(string value) { }

	// RVA: 0x778B28
	public string get_ImageURI() { }

	// RVA: 0x778B30
	private void set_ImageURI(string value) { }

	// RVA: 0x778B38
	public string get_Price() { }

	// RVA: 0x778B40
	private void set_Price(string value) { }

	// RVA: 0x778B48
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x778B54
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x778B5C
	public string get_PriceCurrencyCode() { }

	// RVA: 0x778B64
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x778B6C
	public string get_SubscriptionTerm() { }

	// RVA: 0x778B74
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x778B7C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class Subscription
{
	// Fields
	private DateTime <DeactivationTime>k__BackingField; // 0x10
	private bool <IsEntitlementActive>k__BackingField; // 0x18
	private DateTime <PeriodStartTime>k__BackingField; // 0x20
	private DateTime <PeriodEndTime>k__BackingField; // 0x28
	private string <ProductID>k__BackingField; // 0x30
	private string <PurchasePlatform>k__BackingField; // 0x38
	private CurrencyAmount <PurchasePrice>k__BackingField; // 0x40
	private DateTime <PurchaseTime>k__BackingField; // 0x48
	private string <PurchaseToken>k__BackingField; // 0x50
	private string <SignedRequest>k__BackingField; // 0x58
	private string <Status>k__BackingField; // 0x60
	private string <SubscriptionTerm>k__BackingField; // 0x68

	// Methods

	// RVA: 0x778E94
	internal void .ctor(Int64 deactivationTime, bool isEntitlementActive, Int64 periodStartTime, Int64 periodEndTime, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	// RVA: 0x7797AC
	public DateTime get_DeactivationTime() { }

	// RVA: 0x7797B4
	private void set_DeactivationTime(DateTime value) { }

	// RVA: 0x7797BC
	public bool get_IsEntitlementActive() { }

	// RVA: 0x7797C4
	private void set_IsEntitlementActive(bool value) { }

	// RVA: 0x7797CC
	public DateTime get_PeriodStartTime() { }

	// RVA: 0x7797D4
	private void set_PeriodStartTime(DateTime value) { }

	// RVA: 0x7797DC
	public DateTime get_PeriodEndTime() { }

	// RVA: 0x7797E4
	private void set_PeriodEndTime(DateTime value) { }

	// RVA: 0x7797EC
	public string get_ProductID() { }

	// RVA: 0x7797F4
	private void set_ProductID(string value) { }

	// RVA: 0x7797FC
	public string get_PurchasePlatform() { }

	// RVA: 0x779804
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x77980C
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x779814
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x77981C
	public DateTime get_PurchaseTime() { }

	// RVA: 0x779824
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x77982C
	public string get_PurchaseToken() { }

	// RVA: 0x779834
	private void set_PurchaseToken(string value) { }

	// RVA: 0x77983C
	public string get_SignedRequest() { }

	// RVA: 0x779844
	private void set_SignedRequest(string value) { }

	// RVA: 0x77984C
	public string get_Status() { }

	// RVA: 0x779854
	private void set_Status(string value) { }

	// RVA: 0x77985C
	public string get_SubscriptionTerm() { }

	// RVA: 0x779864
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x77986C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult
{
	// Fields
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Methods

	// RVA: 0x779C10
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77A018
	public AccessToken get_AccessToken() { }

	// RVA: 0x77A020
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x77A028
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppLinkResult
{
	// Fields
	private string <Url>k__BackingField; // 0x50
	private string <TargetUrl>k__BackingField; // 0x58
	private string <Ref>k__BackingField; // 0x60
	private System.Collections.Generic.IDictionary<System.String,System.Object> <Extras>k__BackingField; // 0x68

	// Methods

	// RVA: 0x77A334
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77A4F0
	public string get_Url() { }

	// RVA: 0x77A4F8
	private void set_Url(string value) { }

	// RVA: 0x77A500
	public string get_TargetUrl() { }

	// RVA: 0x77A508
	private void set_TargetUrl(string value) { }

	// RVA: 0x77A510
	public string get_Ref() { }

	// RVA: 0x77A518
	private void set_Ref(string value) { }

	// RVA: 0x77A520
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_Extras() { }

	// RVA: 0x77A528
	private void set_Extras(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x77A530
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppRequestResult
{
	// Fields
	private string <RequestID>k__BackingField; // 0x50
	private System.Collections.Generic.IEnumerable<System.String> <To>k__BackingField; // 0x58

	// Methods

	// RVA: 0x77A76C
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77AC40
	public string get_RequestID() { }

	// RVA: 0x77AC48
	private void set_RequestID(string value) { }

	// RVA: 0x77AC50
	public System.Collections.Generic.IEnumerable<System.String> get_To() { }

	// RVA: 0x77AC58
	private void set_To(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x77AC60
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77AE08
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77B634
	public System.Collections.Generic.IList<Facebook.Unity.Product> get_Products() { }

	// RVA: 0x77B63C
	private void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value) { }

	// RVA: 0x77B644
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface IFriendFinderInvitationResult
{}

// Namespace: Facebook.Unity
public interface ILocaleResult
{}

// Namespace: Facebook.Unity
public interface IProfileResult
{}

// Namespace: Facebook.Unity
internal class CancelSubscriptionResult
{
	// Methods

	// RVA: 0x77BA2C
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult
{
	// Methods

	// RVA: 0x77BA30
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult
{
	// Methods

	// RVA: 0x77BA34
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GraphResult
{
	// Fields
	private System.Collections.Generic.IList<System.Object> <ResultList>k__BackingField; // 0x50
	private Texture2D <Texture>k__BackingField; // 0x58

	// Methods

	// RVA: 0x77BA38
	internal void .ctor(UnityWebRequestAsyncOperation result) { }

	// RVA: 0x77BD20
	private void set_ResultList(System.Collections.Generic.IList<System.Object> value) { }

	// RVA: 0x77BD28
	public Texture2D get_Texture() { }

	// RVA: 0x77BD30
	private void set_Texture(Texture2D value) { }

	// RVA: 0x77BC00
	private void Init(string rawResult) { }

}

// Namespace: Facebook.Unity
public interface IAccessTokenRefreshResult
{}

// Namespace: Facebook.Unity
public interface IAppLinkResult
{}

// Namespace: Facebook.Unity
internal class IAPReadyResult
{
	// Methods

	// RVA: 0x77BD38
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public interface IAppRequestResult
{}

// Namespace: Facebook.Unity
public interface ICancelSubscriptionResult
{}

// Namespace: Facebook.Unity
public interface ICatalogResult
{}

// Namespace: Facebook.Unity
public interface IConsumePurchaseResult
{}

// Namespace: Facebook.Unity
public interface IGamingServicesFriendFinderResult
{}

// Namespace: Facebook.Unity
public interface IGraphResult
{}

// Namespace: Facebook.Unity
public interface IGroupCreateResult
{}

// Namespace: Facebook.Unity
public interface IGroupJoinResult
{}

// Namespace: Facebook.Unity
internal class InitCloudGameResult
{
	// Methods

	// RVA: 0x77BD3C
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult
{
	// Methods

	// RVA: 0x77BD40
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class InterstitialAdResult
{
	// Methods

	// RVA: 0x77BD44
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public interface IIAPReadyResult
{}

// Namespace: Facebook.Unity
public interface IInitCloudGameResult
{}

// Namespace: Facebook.Unity
public interface IGameLoadCompleteResult
{}

// Namespace: Facebook.Unity
internal interface IInternalResult
{
	// Methods

	// RVA: -1
	public abstract string get_CallbackId() { }

}

// Namespace: Facebook.Unity
public interface IInterstitialAdResult
{}

// Namespace: Facebook.Unity
public interface ILoginResult
{}

// Namespace: Facebook.Unity
public interface ILoginStatusResult
{}

// Namespace: Facebook.Unity
public interface IOpenAppStoreResult
{}

// Namespace: Facebook.Unity
public interface IPayloadResult
{}

// Namespace: Facebook.Unity
public interface IPayResult
{}

// Namespace: Facebook.Unity
public interface IPurchaseResult
{}

// Namespace: Facebook.Unity
public interface IPurchasesResult
{}

// Namespace: Facebook.Unity
public interface IResult
{
	// Methods

	// RVA: -1
	public abstract string get_Error() { }

	// RVA: -1
	public abstract System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: -1
	public abstract bool get_Cancelled() { }

}

// Namespace: Facebook.Unity
public interface IReferralsCreateResult
{}

// Namespace: Facebook.Unity
public interface IReferralsGetDataResult
{}

// Namespace: Facebook.Unity
public interface IRewardedVideoResult
{}

// Namespace: Facebook.Unity
public interface IScheduleAppToUserNotificationResult
{}

// Namespace: Facebook.Unity
public interface IShareResult
{}

// Namespace: Facebook.Unity
public interface ISoftKeyboardOpenResult
{}

// Namespace: Facebook.Unity
public interface ISubscribableCatalogResult
{}

// Namespace: Facebook.Unity
public interface ISubscriptionResult
{}

// Namespace: Facebook.Unity
public interface ISubscriptionsResult
{}

// Namespace: Facebook.Unity
public interface IVirtualGamepadLayoutResult
{}

// Namespace: Facebook.Unity
internal class LoginResult
{
	// Fields
	public static readonly string UserIdKey; // 0x0
	public static readonly string ExpirationTimestampKey; // 0x8
	public static readonly string PermissionsKey; // 0x10
	public static readonly string AccessTokenKey; // 0x18
	public static readonly string GraphDomain; // 0x20
	public static readonly string AuthTokenString; // 0x28
	public static readonly string AuthNonce; // 0x30
	private AccessToken <AccessToken>k__BackingField; // 0x50
	private AuthenticationToken <AuthenticationToken>k__BackingField; // 0x58

	// Methods

	// RVA: 0x77BE8C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77C430
	public AccessToken get_AccessToken() { }

	// RVA: 0x77C438
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x77C440
	public AuthenticationToken get_AuthenticationToken() { }

	// RVA: 0x77C448
	private void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x77C450
	public override string ToString() { }

	// RVA: 0x77C5FC
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class LoginStatusResult
{
	// Fields
	public static readonly string FailedKey; // 0x0
	private bool <Failed>k__BackingField; // 0x60

	// Methods

	// RVA: 0x77C7F8
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77C9C8
	public bool get_Failed() { }

	// RVA: 0x77C9D0
	private void set_Failed(bool value) { }

	// RVA: 0x77C9D8
	public override string ToString() { }

	// RVA: 0x77CB14
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult
{
	// Methods

	// RVA: 0x77CB8C
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class PayloadResult
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77CB90
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77CE20
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x77CE28
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x77CE30
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PayResult
{
	// Methods

	// RVA: 0x77CE74
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77CF64
	public Int64 get_ErrorCode() { }

	// RVA: 0x77D040
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchaseResult
{
	// Fields
	private Purchase <Purchase>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77D208
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77D7A0
	public Purchase get_Purchase() { }

	// RVA: 0x77D7A8
	private void set_Purchase(Purchase value) { }

	// RVA: 0x77D7B0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchasesResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77D8A8
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77E044
	public System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases() { }

	// RVA: 0x77E04C
	private void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value) { }

	// RVA: 0x77E054
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal abstract class ResultBase
{
	// Fields
	private string <Error>k__BackingField; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> <ErrorDictionary>k__BackingField; // 0x18
	private System.Collections.Generic.IDictionary<System.String,System.Object> <ResultDictionary>k__BackingField; // 0x20
	private string <RawResult>k__BackingField; // 0x28
	private bool <Cancelled>k__BackingField; // 0x30
	private string <CallbackId>k__BackingField; // 0x38
	private System.Nullable<System.Int64> <CanvasErrorCode>k__BackingField; // 0x40

	// Methods

	// RVA: 0x779D70
	internal void .ctor(ResultContainer result) { }

	// RVA: 0x77BBB4
	internal void .ctor(ResultContainer result, string error, bool cancelled) { }

	// RVA: 0x77EB0C
	public virtual string get_Error() { }

	// RVA: 0x77EB14
	protected virtual void set_Error(string value) { }

	// RVA: 0x77EB1C
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> get_ErrorDictionary() { }

	// RVA: 0x77EB24
	protected virtual void set_ErrorDictionary(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x77EB2C
	public virtual System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x77EB34
	protected virtual void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x77EB3C
	public virtual string get_RawResult() { }

	// RVA: 0x77EB44
	protected virtual void set_RawResult(string value) { }

	// RVA: 0x77EB4C
	public virtual bool get_Cancelled() { }

	// RVA: 0x77EB54
	protected virtual void set_Cancelled(bool value) { }

	// RVA: 0x77EB5C
	public virtual string get_CallbackId() { }

	// RVA: 0x77EB64
	protected virtual void set_CallbackId(string value) { }

	// RVA: 0x77EB6C
	protected System.Nullable<System.Int64> get_CanvasErrorCode() { }

	// RVA: 0x77EB78
	private void set_CanvasErrorCode(System.Nullable<System.Int64> value) { }

	// RVA: 0x77A168
	public override string ToString() { }

	// RVA: 0x77E8F8
	protected void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x77E43C
	private static string GetErrorValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x77E4D8
	private static bool GetCancelledValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x77E85C
	private static string GetCallbackId(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

}

// Namespace: Facebook.Unity
internal class ResultContainer
{
	// Fields
	private const string CanvasResponseKey = "response";
	private string <RawResult>k__BackingField; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.Object> <ResultDictionary>k__BackingField; // 0x18

	// Methods

	// RVA: 0x77F0D4
	public void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x776778
	public void .ctor(string result) { }

	// RVA: 0x77F348
	public string get_RawResult() { }

	// RVA: 0x77F350
	private void set_RawResult(string value) { }

	// RVA: 0x77F358
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x77F360
	public void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x77F194
	private System.Collections.Generic.IDictionary<System.String,System.Object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

}

// Namespace: Facebook.Unity
internal class RewardedVideoResult
{
	// Methods

	// RVA: 0x77F368
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult
{
	// Methods

	// RVA: 0x77F4B0
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ShareResult
{
	// Fields
	private string <PostId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77F4B4
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77F660
	public string get_PostId() { }

	// RVA: 0x77F668
	private void set_PostId(string value) { }

	// RVA: 0x77F5F4
	internal static string get_PostIDKey() { }

	// RVA: 0x77F670
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Methods

	// RVA: 0x77F768
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77FF94
	public System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> get_SubscribableProducts() { }

	// RVA: 0x77FF9C
	private void set_SubscribableProducts(System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> value) { }

	// RVA: 0x77FFA4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionResult
{
	// Fields
	private Subscription <Subscription>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78038C
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x780924
	public Subscription get_Subscription() { }

	// RVA: 0x78092C
	private void set_Subscription(Subscription value) { }

	// RVA: 0x780934
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionsResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Subscription> <Subscriptions>k__BackingField; // 0x50

	// Methods

	// RVA: 0x780A2C
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7811C0
	public System.Collections.Generic.IList<Facebook.Unity.Subscription> get_Subscriptions() { }

	// RVA: 0x7811C8
	private void set_Subscriptions(System.Collections.Generic.IList<Facebook.Unity.Subscription> value) { }

	// RVA: 0x7811D0
	public override string ToString() { }

}

// Namespace: 
private sealed class <Start>d__9
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AsyncRequestString <>4__this; // 0x20
	private UnityWebRequestAsyncOperation <webRequestOperation>5__2; // 0x28

	// Methods

	// RVA: 0x781954
	public void .ctor(int <>1__state) { }

	// RVA: 0x781988
	private void System.IDisposable.Dispose() { }

	// RVA: 0x78198C
	private bool MoveNext() { }

	// RVA: 0x782478
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x782480
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7824C0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestString
{
	// Fields
	private Uri url; // 0x20
	private HttpMethod method; // 0x28
	private System.Collections.Generic.IDictionary<System.String,System.String> formData; // 0x30
	private WWWForm query; // 0x38
	private Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback; // 0x40

	// Methods

	// RVA: 0x7815B8
	internal static void Post(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7816F8
	internal static void Get(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x781794
	internal static void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x781658
	internal static void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7818DC
	internal IEnumerator Start() { }

	// RVA: 0x781834
	internal AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x78185C
	internal AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x7818B4
	internal AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x781864
	internal AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x78188C
	internal AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x781980
	public void .ctor() { }

}

// Namespace: 
private class DebugLogger
{
	// Methods

	// RVA: 0x782584
	public void .ctor() { }

	// RVA: 0x782844
	public void Log(string msg) { }

	// RVA: 0x782904
	public void Info(string msg) { }

	// RVA: 0x78298C
	public void Warn(string msg) { }

}

// Namespace: Facebook.Unity
internal static class FacebookLogger
{
	// Fields
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x7824C8
	private static void .cctor() { }

	// RVA: 0x78258C
	private static IFacebookLogger get_Instance() { }

	// RVA: 0x782608
	internal static void set_Instance(IFacebookLogger value) { }

	// RVA: 0x78267C
	public static void Log(string msg) { }

	// RVA: 0x770970
	public static void Info(string msg) { }

	// RVA: 0x76F498
	public static void Warn(string msg) { }

	// RVA: 0x7827B8
	public static void Warn(string format, string[] args) { }

}

// Namespace: Facebook.Unity
public enum HttpMethod
{
	// Fields
	public int value__; // 0x10
	public const HttpMethod GET = 0;
	public const HttpMethod POST = 1;
	public const HttpMethod DELETE = 2;
}

// Namespace: Facebook.Unity
internal interface IFacebookLogger
{
	// Methods

	// RVA: -1
	public abstract void Log(string msg) { }

	// RVA: -1
	public abstract void Info(string msg) { }

	// RVA: -1
	public abstract void Warn(string msg) { }

}

// Namespace: 
public sealed class Callback<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T obj) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Facebook.Unity.Utilities.<>c <>9; // 0x0
	public static System.Func<System.Object,System.String> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x785880
	private static void .cctor() { }

	// RVA: 0x7858EC
	public void .ctor() { }

	// RVA: 0x7858F4
	internal string <ParsePermissionFromResult>b__19_0(object permission) { }

}

// Namespace: Facebook.Unity
internal static class Utilities
{
	// Methods

	// RVA: 0x30D6280
	public static bool TryGetValue(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, T value) { }

	// RVA: 0x76B784
	public static Int64 TotalSeconds(DateTime dateTime) { }

	// RVA: 0x318DB98
	public static T GetValueOrDefault(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, bool logWarning) { }

	// RVA: 0x76B870
	public static string ToCommaSeparateList(System.Collections.Generic.IEnumerable<System.String> list) { }

	// RVA: 0x782A14
	public static string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x76D7CC
	public static string GetUserAgent(string productName, string productVersion) { }

	// RVA: 0x77A6EC
	public static string ToJson(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x30DB358
	public static void AddAllKVPFrom(System.Collections.Generic.IDictionary<T1,T2> dest, System.Collections.Generic.IDictionary<T1,T2> source) { }

	// RVA: 0x779EB0
	public static AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x77C338
	public static AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76B910
	public static string ToStringNullOk(object obj) { }

	// RVA: 0x76B974
	public static string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<System.String,System.String> propertiesAndValues) { }

	// RVA: 0x782AE4
	private static DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x782FF8
	private static System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x782CDC
	private static System.Collections.Generic.ICollection<System.String> ParsePermissionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x77B10C
	public static System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x78323C
	public static Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x77FA6C
	public static System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> ParseSubscribableCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x783A64
	public static SubscribableProduct ParseSubscribableProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x77DBAC
	public static System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x77D604
	public static Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x780D28
	public static System.Collections.Generic.IList<Facebook.Unity.Subscription> ParseSubscriptionsFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x780788
	public static Subscription ParseSubscriptionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7843B0
	public static Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> purchase, bool isWindows) { }

	// RVA: 0x785010
	public static Subscription ParseSubscriptionFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> subscription, bool isWindows) { }

	// RVA: 0x77EB80
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x77CCDC
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary, string key) { }

	// RVA: 0x77846C
	public static DateTime FromTimestamp(int timestamp) { }

}

// Namespace: Facebook.Unity
internal static class FBUnityUtility
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Methods

	// RVA: 0x775934
	public static IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper
{
	// Methods

	// RVA: 0x785924
	public void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7859C4
	public void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x78591C
	public void .ctor() { }

}

// Namespace: Facebook.Unity
internal interface IAsyncRequestStringWrapper
{
	// Methods

	// RVA: -1
	public abstract void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

}

// Namespace: 
private sealed class <DelayEvent>d__1
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Int64 delay; // 0x20
	public Action action; // 0x28

	// Methods

	// RVA: 0x785B78
	public void .ctor(int <>1__state) { }

	// RVA: 0x785BAC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x785BB0
	private bool MoveNext() { }

	// RVA: 0x785C8C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x785C94
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x785CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class FacebookScheduler
{
	// Methods

	// RVA: 0x785A64
	public void Schedule(Action action, Int64 delay) { }

	// RVA: 0x785AF8
	public IEnumerator DelayEvent(Action action, Int64 delay) { }

	// RVA: 0x785BA4
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public interface IHasLicenseResult
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog
{
	// Methods

	// RVA: 0x785CDC
	internal static void handlePurchaseCompleted(object data) { }

	// RVA: 0x78645C
	internal static void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x786634
	internal static void addListenerToGameObject(object gameObject, object listenerObject) { }

	// RVA: 0x786A24
	private static Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x786590
	private static object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x786B80
	private static object GetField(object inObj, string fieldName) { }

	// RVA: 0x7863F8
	private static object GetProperty(object inObj, string propertyName) { }

}

// Namespace: 
private sealed class <GenSnapshot>d__4
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Methods

	// RVA: 0x786F6C
	public void .ctor(int <>1__state) { }

	// RVA: 0x788580
	private void System.IDisposable.Dispose() { }

	// RVA: 0x788584
	private bool MoveNext() { }

	// RVA: 0x7887EC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7887F4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x788834
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
public class CodelessCrawler
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x786BE0
	public void Awake() { }

	// RVA: 0x786C90
	public void CaptureViewHierarchy(string message) { }

	// RVA: 0x786F10
	private IEnumerator GenSnapshot() { }

	// RVA: 0x786F98
	private static void SendAndroid(string json) { }

	// RVA: 0x7871A4
	private static void SendIos(string json) { }

	// RVA: 0x7871A8
	private static string GenBase64Screenshot() { }

	// RVA: 0x7872E8
	private static string GenViewJson() { }

	// RVA: 0x787718
	private static void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x788490
	private void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x786E74
	private static void updateMainCamera() { }

	// RVA: 0x788254
	private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x788388
	private static string getClasstypeBitmaskButton() { }

	// RVA: 0x788410
	private static string getVisibility(GameObject gameObj) { }

	// RVA: 0x788574
	public void .ctor() { }

	// RVA: 0x78857C
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent
{
	// Fields
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x78883C
	private FBSDKEventBindingManager get_eventBindingManager() { }

	// RVA: 0x788844
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x78884C
	private void Awake() { }

	// RVA: 0x788870
	private static void SetLoggerInitAndroid() { }

	// RVA: 0x7889B8
	private static void SetLoggerInitIos() { }

	// RVA: 0x7889BC
	public void OnReceiveMapping(string message) { }

	// RVA: 0x788DA4
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public class FBSDKCodelessPathComponent
{
	// Fields
	private string <className>k__BackingField; // 0x10
	private string <text>k__BackingField; // 0x18
	private string <hint>k__BackingField; // 0x20
	private string <desc>k__BackingField; // 0x28
	private string <tag>k__BackingField; // 0x30
	private Int64 <index>k__BackingField; // 0x38
	private Int64 <section>k__BackingField; // 0x40
	private Int64 <row>k__BackingField; // 0x48
	private Int64 <matchBitmask>k__BackingField; // 0x50

	// Methods

	// RVA: 0x788DAC
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x789208
	public string get_className() { }

	// RVA: 0x789210
	public void set_className(string value) { }

	// RVA: 0x789218
	public void set_text(string value) { }

	// RVA: 0x789220
	public void set_hint(string value) { }

	// RVA: 0x789228
	public void set_desc(string value) { }

	// RVA: 0x789230
	public void set_tag(string value) { }

	// RVA: 0x789238
	public void set_index(Int64 value) { }

	// RVA: 0x789240
	public void set_section(Int64 value) { }

	// RVA: 0x789248
	public void set_row(Int64 value) { }

	// RVA: 0x789250
	public void set_matchBitmask(Int64 value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBinding
{
	// Fields
	private string <eventName>k__BackingField; // 0x10
	private string <eventType>k__BackingField; // 0x18
	private string <appVersion>k__BackingField; // 0x20
	private string <pathType>k__BackingField; // 0x28
	private System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> <path>k__BackingField; // 0x30
	private System.Collections.Generic.List<System.String> <parameters>k__BackingField; // 0x38

	// Methods

	// RVA: 0x789258
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x789758
	public string get_eventName() { }

	// RVA: 0x789760
	public void set_eventName(string value) { }

	// RVA: 0x789768
	public string get_eventType() { }

	// RVA: 0x789770
	public void set_eventType(string value) { }

	// RVA: 0x789778
	public string get_appVersion() { }

	// RVA: 0x789780
	public void set_appVersion(string value) { }

	// RVA: 0x789788
	public System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path() { }

	// RVA: 0x789790
	public void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager
{
	// Fields
	private System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Methods

	// RVA: 0x789798
	public System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings() { }

	// RVA: 0x7897A0
	public void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value) { }

	// RVA: 0x788AC4
	public void .ctor(System.Collections.Generic.List<System.Object> listDict) { }

}

// Namespace: Facebook.Unity
public interface IMediaUploadResult
{}

// Namespace: Facebook.Unity
internal class MediaUploadResult
{
	// Fields
	private string <MediaId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7897A8
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7898A4
	public string get_MediaId() { }

	// RVA: 0x7898AC
	private void set_MediaId(string value) { }

	// RVA: 0x7898B4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface ISessionScoreResult
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult
{
	// Methods

	// RVA: 0x7899AC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public class AuthenticationToken
{
	// Fields
	private string <TokenString>k__BackingField; // 0x10
	private string <Nonce>k__BackingField; // 0x18

	// Methods

	// RVA: 0x783164
	internal void .ctor(string tokenString, string nonce) { }

	// RVA: 0x7899B0
	public string get_TokenString() { }

	// RVA: 0x7899B8
	private void set_TokenString(string value) { }

	// RVA: 0x7899C0
	public string get_Nonce() { }

	// RVA: 0x7899C8
	private void set_Nonce(string value) { }

	// RVA: 0x7899D0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public enum LoginTracking
{
	// Fields
	public int value__; // 0x10
	public const LoginTracking ENABLED = 0;
	public const LoginTracking LIMITED = 1;
}

// Namespace: Facebook.Unity
public class Profile
{
	// Fields
	private string <UserID>k__BackingField; // 0x10
	private string <FirstName>k__BackingField; // 0x18
	private string <MiddleName>k__BackingField; // 0x20
	private string <LastName>k__BackingField; // 0x28
	private string <Name>k__BackingField; // 0x30
	private string <Email>k__BackingField; // 0x38
	private string <ImageURL>k__BackingField; // 0x40
	private string <LinkURL>k__BackingField; // 0x48
	private string[] <FriendIDs>k__BackingField; // 0x50
	private System.Nullable<System.DateTime> <Birthday>k__BackingField; // 0x58
	private UserAgeRange <AgeRange>k__BackingField; // 0x68
	private FBLocation <Hometown>k__BackingField; // 0x70
	private FBLocation <Location>k__BackingField; // 0x78
	private string <Gender>k__BackingField; // 0x80

	// Methods

	// RVA: 0x789AE4
	internal void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	// RVA: 0x789D48
	public string get_UserID() { }

	// RVA: 0x789D50
	private void set_UserID(string value) { }

	// RVA: 0x789D58
	public string get_FirstName() { }

	// RVA: 0x789D60
	private void set_FirstName(string value) { }

	// RVA: 0x789D68
	public string get_MiddleName() { }

	// RVA: 0x789D70
	private void set_MiddleName(string value) { }

	// RVA: 0x789D78
	public string get_LastName() { }

	// RVA: 0x789D80
	private void set_LastName(string value) { }

	// RVA: 0x789D88
	public string get_Name() { }

	// RVA: 0x789D90
	private void set_Name(string value) { }

	// RVA: 0x789D98
	public string get_Email() { }

	// RVA: 0x789DA0
	private void set_Email(string value) { }

	// RVA: 0x789DA8
	public string get_ImageURL() { }

	// RVA: 0x789DB0
	private void set_ImageURL(string value) { }

	// RVA: 0x789DB8
	public string get_LinkURL() { }

	// RVA: 0x789DC0
	private void set_LinkURL(string value) { }

	// RVA: 0x789DC8
	public string[] get_FriendIDs() { }

	// RVA: 0x789DD0
	private void set_FriendIDs(string[] value) { }

	// RVA: 0x789DD8
	public System.Nullable<System.DateTime> get_Birthday() { }

	// RVA: 0x789DE4
	private void set_Birthday(System.Nullable<System.DateTime> value) { }

	// RVA: 0x789DEC
	public UserAgeRange get_AgeRange() { }

	// RVA: 0x789DF4
	private void set_AgeRange(UserAgeRange value) { }

	// RVA: 0x789DFC
	public FBLocation get_Hometown() { }

	// RVA: 0x789E04
	private void set_Hometown(FBLocation value) { }

	// RVA: 0x789E0C
	public FBLocation get_Location() { }

	// RVA: 0x789E14
	private void set_Location(FBLocation value) { }

	// RVA: 0x789E1C
	public string get_Gender() { }

	// RVA: 0x789E24
	private void set_Gender(string value) { }

	// RVA: 0x789E2C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class UserAgeRange
{
	// Fields
	private Int64 <Min>k__BackingField; // 0x10
	private Int64 <Max>k__BackingField; // 0x18

	// Methods

	// RVA: 0x78A2F0
	internal void .ctor(Int64 min, Int64 max) { }

	// RVA: 0x78A328
	public Int64 get_Min() { }

	// RVA: 0x78A330
	private void set_Min(Int64 value) { }

	// RVA: 0x78A338
	public Int64 get_Max() { }

	// RVA: 0x78A340
	private void set_Max(Int64 value) { }

	// RVA: 0x78A348
	internal static UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x78A538
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class FBLocation
{
	// Fields
	private string <ID>k__BackingField; // 0x10
	private string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x78A680
	internal void .ctor(string id, string name) { }

	// RVA: 0x78A6D0
	public string get_ID() { }

	// RVA: 0x78A6D8
	private void set_ID(string value) { }

	// RVA: 0x78A6E0
	public string get_Name() { }

	// RVA: 0x78A6E8
	private void set_Name(string value) { }

	// RVA: 0x78A6F0
	internal static FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x78A8D8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface ITournamentResult
{}

// Namespace: Facebook.Unity
internal class TournamentResult
{
	// Fields
	private string <TournamentId>k__BackingField; // 0x50
	private string <ContextId>k__BackingField; // 0x58
	private int <EndTime>k__BackingField; // 0x60
	private string <TournamentTitle>k__BackingField; // 0x68
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x70

	// Methods

	// RVA: 0x78A9EC
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78AC00
	public string get_TournamentId() { }

	// RVA: 0x78AC08
	private void set_TournamentId(string value) { }

	// RVA: 0x78AC10
	public string get_ContextId() { }

	// RVA: 0x78AC18
	private void set_ContextId(string value) { }

	// RVA: 0x78AC20
	public int get_EndTime() { }

	// RVA: 0x78AC28
	private void set_EndTime(int value) { }

	// RVA: 0x78AC30
	public string get_TournamentTitle() { }

	// RVA: 0x78AC38
	private void set_TournamentTitle(string value) { }

	// RVA: 0x78AC40
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x78AC48
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x78AC50
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface IGetTournamentsResult
{}

// Namespace: Facebook.Unity
internal class GetTournamentsResult
{
	// Fields
	private TournamentResult[] <Tournaments>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78B228
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78B700
	private void set_Tournaments(TournamentResult[] value) { }

}

// Namespace: Facebook.Unity
public interface IDialogResult
{}

// Namespace: Facebook.Unity
internal class AbortDialogResult
{
	// Fields
	private bool <Success>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78B708
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78B72C
	private void set_Success(bool value) { }

}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult
{
	// Methods

	// RVA: 0x78B734
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public interface ICreateGamingContextResult
{}

// Namespace: Facebook.Unity
public interface ISwitchGamingContextResult
{}

// Namespace: Facebook.Unity
public interface IChooseGamingContextResult
{}

// Namespace: Facebook.Unity
internal class ChooseGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78B738
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78B7FC
	public string get_ContextId() { }

	// RVA: 0x78B804
	private void set_ContextId(string value) { }

	// RVA: 0x78B80C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78B904
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78B9C8
	public string get_ContextId() { }

	// RVA: 0x78B9D0
	private void set_ContextId(string value) { }

	// RVA: 0x78B9D8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78BAD0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78BB94
	public string get_ContextId() { }

	// RVA: 0x78BB9C
	private void set_ContextId(string value) { }

	// RVA: 0x78BBA4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface IGetCurrentGamingContextResult
{}

// Namespace: Facebook.Unity
internal class GetCurrentGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x78BC9C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x78BD60
	public string get_ContextId() { }

	// RVA: 0x78BD68
	private void set_ContextId(string value) { }

	// RVA: 0x78BD70
	public override string ToString() { }

}

// Namespace: Facebook.Unity.Windows
internal sealed class WindowsFacebook
{
	// Fields
	private string appId; // 0x28
	private IWindowsWrapper windowsWrapper; // 0x30
	private bool <LimitEventUsage>k__BackingField; // 0x38

	// Methods

	// RVA: 0x78BE68
	public void .ctor() { }

	// RVA: 0x78C020
	public void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	// RVA: 0x78C070
	public override bool get_LimitEventUsage() { }

	// RVA: 0x78C078
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x78C080
	public override string get_SDKName() { }

	// RVA: 0x78C0C4
	public override string get_SDKVersion() { }

	// RVA: 0x772EF4
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x78C108
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78C1FC
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78C2F0
	public override void LogOut() { }

	// RVA: 0x78C3A8
	public override bool get_LoggedIn() { }

	// RVA: 0x78C460
	public override void ActivateApp(string appId) { }

	// RVA: 0x78C50C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78C87C
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78C9BC
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x78CAA8
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x78CB94
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x78CC98
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x78CD8C
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x78CDCC
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x78CE0C
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x78CE4C
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x78CE8C
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x78CF78
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78D06C
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78D160
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x78D254
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x78D348
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x78D434
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x78D520
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x78D614
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x78D748
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x78D83C
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x78D930
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x78DA1C
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x78DB20
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x78DC60
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78DD7C
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78DE98
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78DFC8
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78E0F8
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x78BF64
	private static IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x78E1E4
	public void Tick() { }

	// RVA: 0x78E29C
	public void Deinit() { }

	// RVA: 0x78E354
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78E394
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x78E3D4
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x78E414
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78E454
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78E494
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x78E4D4
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x78E514
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x78E554
	public override Profile CurrentProfile() { }

}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsFacebookImplementation
{
	// Methods

	// RVA: -1
	public abstract void Tick() { }

	// RVA: -1
	public abstract void Deinit() { }

}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsWrapper
{
	// Methods

	// RVA: -1
	public abstract bool Init(string appId, string clientToken) { }

	// RVA: -1
	public abstract void LogInWithScopes(System.Collections.Generic.IEnumerable<System.String> scope, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract bool IsLoggedIn() { }

	// RVA: -1
	public abstract void LogOut() { }

	// RVA: -1
	public abstract void Tick() { }

	// RVA: -1
	public abstract void Deinit() { }

	// RVA: -1
	public abstract void GetCatalog(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void GetPurchases(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void Purchase(string productID, string developerPayload, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void ConsumePurchase(string productToken, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void CurrentProfile(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void LoadInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void ShowInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void LoadRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void ShowRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void OpenFriendFinderDialog(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void GetFriendFinderInvitations(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void DeleteFriendFinderInvitation(string invitationId, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void PostSessionScore(int score, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void PostTournamentScore(int score, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void GetTournament(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager) { }

	// RVA: -1
	public abstract void GetUserLocale(string callbackId, CallbackManager callbackManager) { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookLoader
{
	// Methods

	// RVA: 0x78E594
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x78E64C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject
{
	// Methods

	// RVA: 0x78E654
	protected IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x78E6D0
	protected override void OnAwake() { }

	// RVA: 0x78E6D4
	public void Update() { }

	// RVA: 0x78E7EC
	public void OnDestroy() { }

	// RVA: 0x78E908
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	private bool <LimitEventUsage>k__BackingField; // 0x30

	// Methods

	// RVA: 0x78E910
	public void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x78E960
	public void .ctor() { }

	// RVA: 0x78EB00
	public override bool get_LimitEventUsage() { }

	// RVA: 0x78EB08
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x78EB10
	public override string get_SDKName() { }

	// RVA: 0x78EB54
	public override string get_SDKVersion() { }

	// RVA: 0x78EAB8
	private static IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x78EB98
	public override void Init(InitDelegate onInitComplete) { }

	// RVA: 0x78ECAC
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78ECBC
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78EE6C
	public void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78F01C
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78F138
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78F270
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78F3A8
	public override void ActivateApp(string appId) { }

	// RVA: 0x78F434
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x78F598
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78F624
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78F6B0
	public bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x78F6B8
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x78F6C0
	public override Profile CurrentProfile() { }

	// RVA: 0x78F6C8
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x78F708
	public void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x78FA28
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FA9C
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FB10
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FB88
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FBFC
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FC70
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x78F9B4
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FCE4
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FD58
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FDCC
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FE40
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FEB4
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FF28
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x78FF9C
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x790010
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x790084
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7900F8
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x79016C
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7901E0
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x790254
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x7902C8
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x79033C
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x7903B0
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x790424
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x790498
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x79050C
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x790580
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x7905F4
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x790668
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7906DC
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x790750
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7907C4
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x790838
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7908AC
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x790920
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x790994
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x790A0C
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x790A84
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x790AF8
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x790B6C
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x790BE0
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x790C54
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x790CC8
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x790E00
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x790E40
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x790E80
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x791018
	public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7911B0
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7911F0
	public void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x791314
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x791438
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x79155C
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x791680
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7917A4
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7918C8
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7919EC
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x791B10
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x791C34
	public void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x791D58
	public void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x791E7C
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x791FA0
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7920C4
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7921E8
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x79230C
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x792430
	public void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x792554
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x792678
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x79279C
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x792998
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x792ABC
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x792CB8
	public void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x792DDC
	public void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x792F00
	public void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x793024
	public void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x793148
	public void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x79326C
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x7932AC
	public void OnUrlResponse(string message) { }

	// RVA: 0x7932EC
	public void OnHideUnity(bool hidden) { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject
{
	// Methods

	// RVA: 0x79749C
	protected override void OnAwake() { }

	// RVA: 0x7974A4
	private void OnEnable() { }

	// RVA: 0x797554
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x79755C
	private void OnDisable() { }

	// RVA: 0x79760C
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x797618
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader
{
	// Methods

	// RVA: 0x797620
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7976BC
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal abstract class EditorFacebookMockDialog
{
	// Fields
	private Rect modalRect; // 0x20
	private GUIStyle modalStyle; // 0x30
	private Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <Callback>k__BackingField; // 0x38
	private string <CallbackID>k__BackingField; // 0x40

	// Methods

	// RVA: 0x7976C4
	protected Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback() { }

	// RVA: 0x7976CC
	public void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value) { }

	// RVA: 0x7976D4
	protected string get_CallbackID() { }

	// RVA: 0x7976DC
	public void set_CallbackID(string value) { }

	// RVA: -1
	protected abstract string get_DialogTitle() { }

	// RVA: 0x7976E4
	public void Start() { }

	// RVA: 0x797810
	public void OnGUI() { }

	// RVA: -1
	protected abstract void DoGui() { }

	// RVA: -1
	protected abstract void SendSuccessResult() { }

	// RVA: 0x797920
	protected virtual void SendCancelResult() { }

	// RVA: 0x797AA0
	protected virtual void SendErrorResult(string errorMessage) { }

	// RVA: 0x797BF0
	private void OnGUIDialog(int windowId) { }

	// RVA: 0x798010
	protected void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x798018
	public void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x79804C
	public void Init() { }

	// RVA: 0x798128
	public void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x7981A8
	public void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x798330
	public void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x7983CC
	public void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x798294
	private void ShowEmptyMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string title) { }

}

// Namespace: Facebook.Unity.Editor
internal interface IEditorWrapper
{
	// Methods

	// RVA: -1
	public abstract void Init() { }

	// RVA: -1
	public abstract void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permissions) { }

	// RVA: -1
	public abstract void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: -1
	public abstract void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: -1
	public abstract void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class EmptyMockDialog
{
	// Fields
	private string <EmptyDialogTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x798468
	public string get_EmptyDialogTitle() { }

	// RVA: 0x798470
	public void set_EmptyDialogTitle(string value) { }

	// RVA: 0x798478
	protected override string get_DialogTitle() { }

	// RVA: 0x798480
	protected override void DoGui() { }

	// RVA: 0x798484
	protected override void SendSuccessResult() { }

	// RVA: 0x7985F4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x798C0C
	public void .ctor() { }

	// RVA: 0x798C80
	internal void <SendSuccessResult>b__0(IGraphResult graphResult) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1
{
	// Fields
	public string facebookID; // 0x10
	public Facebook.Unity.Editor.Dialogs.MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x799020
	public void .ctor() { }

	// RVA: 0x799028
	internal void <SendSuccessResult>b__1(IGraphResult permResult) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog
{
	// Fields
	private string accessToken; // 0x48

	// Methods

	// RVA: 0x7985FC
	protected override string get_DialogTitle() { }

	// RVA: 0x798640
	protected override void DoGui() { }

	// RVA: 0x7988A0
	protected override void SendSuccessResult() { }

	// RVA: 0x798C14
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog
{
	// Fields
	private string <SubTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x799A28
	private string get_SubTitle() { }

	// RVA: 0x799A30
	public void set_SubTitle(string value) { }

	// RVA: 0x799A38
	protected override string get_DialogTitle() { }

	// RVA: 0x799AA8
	protected override void DoGui() { }

	// RVA: 0x799AAC
	protected override void SendSuccessResult() { }

	// RVA: 0x799F64
	protected override void SendCancelResult() { }

	// RVA: 0x799C84
	private string GenerateFakePostID() { }

	// RVA: 0x79A0AC
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebook
{
	// Methods

	// RVA: -1
	public abstract void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: -1
	public abstract bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: -1
	public abstract void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: -1
	public abstract void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: -1
	public abstract void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: -1
	public abstract void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: -1
	public abstract void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: -1
	public abstract void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: -1
	public abstract void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: -1
	public abstract void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: -1
	public abstract void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookImplementation
{}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookResultHandler
{
	// Methods

	// RVA: -1
	public abstract void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebook
{
	// Methods

	// RVA: 0x79A0B4
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x79A0BC
	public override Profile CurrentProfile() { }

	// RVA: 0x79A0FC
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: -1
	public abstract bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x79A13C
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A1B8
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A234
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A2B0
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A32C
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A3A8
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A474
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x79A4B4
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x79A4F4
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x79A534
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A5B0
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A62C
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A6A8
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A724
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A7A0
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A81C
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A898
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A914
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x79A990
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AA0C
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AA88
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AB04
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AB80
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x79ABFC
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AC78
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x79ACF4
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AD70
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x79ADEC
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AE68
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AEE4
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AF60
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x79AFDC
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B058
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B0D4
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B150
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B1CC
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B248
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x79B2C4
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x79B340
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x79B3BC
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B438
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B4B4
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B530
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B5AC
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x79B628
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x79B668
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x79B6A8
	public virtual void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x79B6E8
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x79B728
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x79B768
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x79B7A8
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x79B7E8
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x79B828
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x79B868
	public override void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x79B8A8
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x79B8E8
	public virtual void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x79B928
	public virtual void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x79B968
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x79B9A8
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x79B9E8
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x79BA28
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x79BA68
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x79BAA8
	public virtual void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x79BAE8
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x79BB28
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x79BB68
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x79BBA8
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x79BBE8
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x79BC28
	public virtual void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x79BC68
	public virtual void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x79BCA8
	public virtual void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x79BCE8
	public virtual void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x79BD28
	public virtual void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject
{
	// Methods

	// RVA: 0x79BD68
	private IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x79BDE4
	public void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x79BF2C
	public void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x79C078
	public void OnFriendFinderComplete(string message) { }

	// RVA: 0x79C1C4
	public void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x79C310
	public void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x79C45C
	public void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x79C5A8
	public void OnGetCatalogComplete(string message) { }

	// RVA: 0x79C6F4
	public void OnGetPurchasesComplete(string message) { }

	// RVA: 0x79C840
	public void OnPurchaseComplete(string message) { }

	// RVA: 0x79C98C
	public void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x79CAD8
	public void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x79CC24
	public void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x79CD70
	public void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x79CEBC
	public void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x79D008
	public void OnInitCloudGameComplete(string message) { }

	// RVA: 0x79D154
	public void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x79D2A0
	public void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x79D3EC
	public void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x79D538
	public void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x79D684
	public void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x79D7D0
	public void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x79D91C
	public void OnGetPayloadComplete(string message) { }

	// RVA: 0x79DA68
	public virtual void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x79DBB4
	public virtual void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x79DD00
	public virtual void OnGetTournamentComplete(string message) { }

	// RVA: 0x79DE4C
	public virtual void OnShareTournamentComplete(string message) { }

	// RVA: 0x79DF98
	public virtual void OnCreateTournamentComplete(string message) { }

	// RVA: 0x79E0E4
	public virtual void OnGetTournamentsComplete(string message) { }

	// RVA: 0x79E230
	public virtual void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x79E37C
	public virtual void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x79E4C8
	public virtual void OnTournamentDialogCancel(string message) { }

	// RVA: 0x79E614
	public virtual void OnTournamentDialogError(string message) { }

	// RVA: 0x79E760
	public void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x79E8AC
	public void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x79E9F8
	public void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x79EB44
	public void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x79EC90
	public void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x79EDDC
	protected void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal interface IIOSWrapper
{
	// Methods

	// RVA: -1
	public abstract void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: -1
	public abstract void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: -1
	public abstract void LogOut() { }

	// RVA: -1
	public abstract void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: -1
	public abstract void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: -1
	public abstract void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: -1
	public abstract void FBAppEventsActivateApp() { }

	// RVA: -1
	public abstract void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: -1
	public abstract void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: -1
	public abstract void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: -1
	public abstract void GetAppLink(int requestId) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(int requestId) { }

	// RVA: -1
	public abstract string FBSdkVersion() { }

	// RVA: -1
	public abstract string FBGetUserID() { }

	// RVA: -1
	public abstract void OpenFriendFinderDialog(int requestId) { }

	// RVA: -1
	public abstract void CreateGamingContext(int requestId, string playerID) { }

	// RVA: -1
	public abstract void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: -1
	public abstract void GetCurrentGamingContext(int requestId) { }

	// RVA: -1
	public abstract void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: -1
	public abstract void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog) { }

	// RVA: -1
	public abstract void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: -1
	public abstract Profile CurrentProfile() { }

}

// Namespace: 
private class NativeDict
{
	// Fields
	private int <NumEntries>k__BackingField; // 0x10
	private string[] <Keys>k__BackingField; // 0x18
	private string[] <Values>k__BackingField; // 0x20

	// Methods

	// RVA: 0x7A1410
	public void .ctor() { }

	// RVA: 0x7A1454
	public int get_NumEntries() { }

	// RVA: 0x7A145C
	public void set_NumEntries(int value) { }

	// RVA: 0x7A1464
	public string[] get_Keys() { }

	// RVA: 0x7A146C
	public void set_Keys(string[] value) { }

	// RVA: 0x7A1474
	public string[] get_Values() { }

	// RVA: 0x7A147C
	public void set_Values(string[] value) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebook
{
	// Fields
	private bool limitEventUsage; // 0x28
	private IIOSWrapper iosWrapper; // 0x30
	private string userID; // 0x38

	// Methods

	// RVA: 0x79EDE4
	public void .ctor() { }

	// RVA: 0x79EF24
	public void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x79EF5C
	public override bool get_LimitEventUsage() { }

	// RVA: 0x79EF64
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x79F020
	public override string get_SDKName() { }

	// RVA: 0x79F064
	public override string get_SDKVersion() { }

	// RVA: 0x79F11C
	public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x79F28C
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x79F3A4
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x79F4A4
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x79F5A4
	public override void LogOut() { }

	// RVA: 0x79F668
	public override bool get_LoggedIn() { }

	// RVA: 0x79F744
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x79F7FC
	public override Profile CurrentProfile() { }

	// RVA: 0x79F8B4
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x79FCE8
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x79FE18
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7A0030
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A06A0
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A0794
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7A079C
	public override void ActivateApp(string appId) { }

	// RVA: 0x7A0854
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7A096C
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7A0A84
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A0AC4
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A0B04
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7A0C24
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7A0D44
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7A0EF0
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7A1008
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7A1120
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A127C
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A13D0
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x79EE68
	private static IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x7A021C
	private static NativeDict MarshallDict(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x30D3AE8
	private int AddCallback(Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject
{
	// Methods

	// RVA: 0x7A1484
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader
{
	// Methods

	// RVA: 0x7A148C
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7A15B0
	public void .ctor() { }

}

// Namespace: 
private class JavaMethodCall<T0>
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(AndroidFacebook androidImpl, string methodName) { }

	// RVA: 0x30D4CD4
	public override void Call(MethodArguments args) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Facebook.Unity.Mobile.Android.AndroidFacebook.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__73_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Object> <>9__73_1; // 0x10
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__74_0; // 0x18
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Object> <>9__74_1; // 0x20

	// Methods

	// RVA: 0x7A630C
	private static void .cctor() { }

	// RVA: 0x7A6378
	public void .ctor() { }

	// RVA: 0x7A6380
	internal string <CreateTournament>b__73_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7A6448
	internal object <CreateTournament>b__73_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7A6514
	internal string <ShareTournament>b__74_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7A65DC
	internal object <ShareTournament>b__74_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal sealed class AndroidFacebook
{
	// Fields
	private bool limitEventUsage; // 0x28
	private IAndroidWrapper androidWrapper; // 0x30
	private string userID; // 0x38
	private string <KeyHash>k__BackingField; // 0x40

	// Methods

	// RVA: 0x7A15B8
	public void .ctor() { }

	// RVA: 0x7A1740
	public void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7A17D0
	private void set_KeyHash(string value) { }

	// RVA: 0x7A17D8
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7A17E0
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7A19B0
	public override string get_SDKName() { }

	// RVA: 0x7A19F4
	public override string get_SDKVersion() { }

	// RVA: 0x7A1AD4
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7A1D3C
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7A1DFC
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7A1F2C
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7A205C
	public override void LogOut() { }

	// RVA: 0x7A2118
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7A242C
	public override Profile CurrentProfile() { }

	// RVA: 0x7A2CEC
	public void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x7A2D68
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7A30C0
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7A3284
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7A34C4
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7A3594
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A3844
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A39FC
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7A3ADC
	public override void ActivateApp(string appId) { }

	// RVA: 0x7A3B34
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7A3C04
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7A3CD4
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A3D14
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A3D54
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A3F20
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A4084
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7A40C4
	public override void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7A4194
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7A4264
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7A4334
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7A4498
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7A45C8
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7A4698
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7A4768
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7A4898
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7A49C8
	public override void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7A4A98
	public override void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7A4B68
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7A4D74
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7A4EA4
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7A4FD4
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7A5104
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7A5234
	public override void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x7A5304
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7A5444
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7A5584
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7A5654
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7A5A04
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7A5D10
	public override void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x7A5DE0
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7A5F10
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7A6040
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7A620C
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7A1684
	private static IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x7A1880
	private void CallFB(string method, string args) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject
{
	// Methods

	// RVA: 0x7A66A8
	protected override void OnAwake() { }

	// RVA: 0x7A66B0
	private void OnEnable() { }

	// RVA: 0x7A6760
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x7A6768
	private void OnDisable() { }

	// RVA: 0x7A6818
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x7A6824
	public void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x7A6918
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader
{
	// Methods

	// RVA: 0x7A6920
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7A69D8
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal interface IAndroidWrapper
{
	// Methods

	// RVA: -1
	public abstract T CallStatic(string methodName) { }

	// RVA: -1
	public abstract void CallStatic(string methodName, object[] args) { }

}

// Namespace: 
private class CanvasUIMethodCall<T0>
{
	// Fields
	private CanvasFacebook canvasImpl; // 0x0
	private string callbackMethod; // 0x0

	// Methods

	// RVA: 0x30D5108
	public void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }

	// RVA: 0x30D4CD4
	public override void Call(MethodArguments args) { }

	// RVA: 0x30D5108
	private void UI(string method, MethodArguments args, Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Facebook.Unity.Canvas.CanvasFacebook.<>c <>9; // 0x0
	public static Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <>9__40_0; // 0x8

	// Methods

	// RVA: 0x7A973C
	private static void .cctor() { }

	// RVA: 0x7A97A8
	public void .ctor() { }

	// RVA: 0x7A97B0
	internal void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass47_0
{
	// Fields
	public ResultContainer result; // 0x10
	public Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x7A9038
	public void .ctor() { }

	// RVA: 0x7A9860
	internal void <FormatAuthResponse>b__0(IGraphResult r) { }

}

// Namespace: Facebook.Unity.Canvas
internal sealed class CanvasFacebook
{
	// Fields
	private string appId; // 0x28
	private string appLinkUrl; // 0x30
	private ICanvasJSWrapper canvasJSWrapper; // 0x38
	private HideUnityDelegate onHideUnityDelegate; // 0x40
	private bool <LimitEventUsage>k__BackingField; // 0x48

	// Methods

	// RVA: 0x7A69E0
	public void .ctor() { }

	// RVA: 0x7A6B20
	public void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7A6A64
	private static ICanvasJSWrapper GetCanvasJSWrapper() { }

	// RVA: 0x7A6B58
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7A6B60
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7A6B68
	public override string get_SDKName() { }

	// RVA: 0x7A6BAC
	public override string get_SDKVersion() { }

	// RVA: 0x7A6C60
	public override string get_SDKUserAgent() { }

	// RVA: 0x7A6F10
	public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7A7340
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7A74AC
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7A7618
	public override void LogOut() { }

	// RVA: 0x7A76DC
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7A7A8C
	public override void ActivateApp(string appId) { }

	// RVA: 0x7A7B44
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7A7D20
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7A7F78
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7A80D4
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A81F8
	public override void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7A8324
	public override void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x7A8D4C
	public override void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x7A8D8C
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x7A8EA0
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7A8F1C
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7A8F98
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7A9014
	public void OnUrlResponse(string url) { }

	// RVA: 0x7A901C
	public void OnHideUnity(bool isGameShown) { }

	// RVA: 0x7A83B4
	private static void FormatAuthResponse(ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback) { }

	// RVA: 0x7A9040
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7A9080
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7A90C0
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7A9100
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7A9140
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7A9180
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7A91C0
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7A9200
	public override void CancelSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7A9240
	public override Profile CurrentProfile() { }

	// RVA: 0x7A9280
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x7A92C0
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7A9300
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7A9340
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7A9380
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7A93C0
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7A9400
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A9440
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7A9480
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7A94C0
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7A9500
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7A9540
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7A9580
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7A95C0
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7A9600
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A9640
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7A9680
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7A96C0
	private void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject
{
	// Methods

	// RVA: 0x7AA054
	protected ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x7AA0D0
	public void OnPayComplete(string result) { }

	// RVA: 0x7AA218
	public void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x7AA364
	public void OnUrlResponse(string message) { }

	// RVA: 0x7AA47C
	public void OnHideUnity(bool hide) { }

	// RVA: 0x7AA594
	protected override void OnAwake() { }

	// RVA: 0x7AA66C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader
{
	// Methods

	// RVA: 0x7AA674
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7AA798
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookCallbackHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPayComplete(string message) { }

	// RVA: -1
	public abstract void OnFacebookAuthResponseChange(string message) { }

	// RVA: -1
	public abstract void OnUrlResponse(string message) { }

	// RVA: -1
	public abstract void OnHideUnity(bool hide) { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookImplementation
{}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookResultHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnUrlResponse(string message) { }

	// RVA: -1
	public abstract void OnHideUnity(bool hide) { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasJSWrapper
{
	// Methods

	// RVA: -1
	public abstract string GetSDKVersion() { }

	// RVA: -1
	public abstract void DisableFullScreen() { }

	// RVA: -1
	public abstract void Init(string connectFacebookUrl, string locale, int debug, string initParams, int status) { }

	// RVA: -1
	public abstract void Login(System.Collections.Generic.IEnumerable<System.String> scope, string callback_id) { }

	// RVA: -1
	public abstract void Logout() { }

	// RVA: -1
	public abstract void ActivateApp() { }

	// RVA: -1
	public abstract void LogAppEvent(string eventName, System.Nullable<System.Single> valueToSum, string parameters) { }

	// RVA: -1
	public abstract void LogPurchase(float purchaseAmount, string currency, string parameters) { }

	// RVA: -1
	public abstract void Ui(string x, string uid, string callbackMethodName) { }

	// RVA: -1
	public abstract void InitScreenPosition() { }

}

// Namespace: Facebook.Unity.Canvas
internal class JsBridge
{
	// Fields
	private ICanvasFacebookCallbackHandler facebook; // 0x20

	// Methods

	// RVA: 0x7AA7A0
	public void Start() { }

	// RVA: 0x7AA804
	public void OnLoginComplete(string responseJsonData) { }

	// RVA: 0x7AA8BC
	public void OnFacebookAuthResponseChange(string responseJsonData) { }

	// RVA: 0x7AA974
	public void OnPayComplete(string responseJsonData) { }

	// RVA: 0x7AAA28
	public void OnAppRequestsComplete(string responseJsonData) { }

	// RVA: 0x7AAAE0
	public void OnShareLinkComplete(string responseJsonData) { }

	// RVA: 0x7AAB98
	public void OnFacebookFocus(string state) { }

	// RVA: 0x7AAC78
	public void OnInitComplete(string responseJsonData) { }

	// RVA: 0x7AAD2C
	public void OnUrlResponse(string url) { }

	// RVA: 0x7AADE4
	public void .ctor() { }

}


