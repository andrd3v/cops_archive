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

	// RVA: 0x7526E0
	private void .ctor(string jsonString) { }

	// RVA: 0x752760
	private Char get_PeekChar() { }

	// RVA: 0x7527EC
	private Char get_NextChar() { }

	// RVA: 0x752878
	private string get_NextWord() { }

	// RVA: 0x752A04
	private TOKEN get_NextToken() { }

	// RVA: 0x752394
	public static object Parse(string jsonString) { }

	// RVA: 0x752DC8
	public void Dispose() { }

	// RVA: 0x752E04
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x75342C
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x752DA0
	private object ParseValue() { }

	// RVA: 0x75353C
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x752F90
	private string ParseString() { }

	// RVA: 0x753648
	private object ParseNumber() { }

	// RVA: 0x752CA8
	private void EatWhitespace() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x753754
	private void .ctor() { }

	// RVA: 0x752550
	public static string Serialize(object obj) { }

	// RVA: 0x7537CC
	private void SerializeValue(object value) { }

	// RVA: 0x753FA8
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x753C60
	private void SerializeArray(IList array) { }

	// RVA: 0x7539A4
	private void SerializeString(string str) { }

	// RVA: 0x75442C
	private void SerializeOther(object value) { }

}

// Namespace: Facebook.MiniJSON
public static class Json
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x752388
	public static object Deserialize(string json) { }

	// RVA: 0x75254C
	public static string Serialize(object obj) { }

	// RVA: 0x752624
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

	// RVA: 0x754618
	internal void .ctor(string tokenString, string userId, DateTime expirationTime, System.Collections.Generic.IEnumerable<System.String> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain) { }

	// RVA: 0x754808
	public static AccessToken get_CurrentAccessToken() { }

	// RVA: 0x754854
	internal static void set_CurrentAccessToken(AccessToken value) { }

	// RVA: 0x7548B8
	public string get_TokenString() { }

	// RVA: 0x7548C0
	private void set_TokenString(string value) { }

	// RVA: 0x7548C8
	public DateTime get_ExpirationTime() { }

	// RVA: 0x7548D0
	private void set_ExpirationTime(DateTime value) { }

	// RVA: 0x7548D8
	public System.Collections.Generic.IEnumerable<System.String> get_Permissions() { }

	// RVA: 0x7548E0
	private void set_Permissions(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7548E8
	public string get_UserId() { }

	// RVA: 0x7548F0
	private void set_UserId(string value) { }

	// RVA: 0x7548F8
	public System.Nullable<System.DateTime> get_LastRefresh() { }

	// RVA: 0x754904
	private void set_LastRefresh(System.Nullable<System.DateTime> value) { }

	// RVA: 0x75490C
	public string get_GraphDomain() { }

	// RVA: 0x754914
	private void set_GraphDomain(string value) { }

	// RVA: 0x75491C
	public override string ToString() { }

	// RVA: 0x755364
	internal string ToJson() { }

}

// Namespace: Facebook.Unity
internal class CallbackManager
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: 0x30B1D84
	public string AddFacebookDelegate(Facebook.Unity.FacebookDelegate<T> callback) { }

	// RVA: 0x75560C
	public void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x7558DC
	private static void CallCallback(object callback, IResult result) { }

	// RVA: 0x30B410C
	private static bool TryCallCallback(object callback, IResult result) { }

	// RVA: 0x756060
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

	// RVA: 0x7560EC
	private static GameObject get_FacebookGameObject() { }

	// RVA: 0x316B894
	public static T GetComponent(IfNotExist ifNotExist) { }

	// RVA: 0x316B894
	public static T AddComponent() { }

}

// Namespace: Facebook.Unity
internal static class Constants
{
	// Fields
	private static System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform; // 0x0

	// Methods

	// RVA: 0x756210
	public static Uri get_GraphUrl() { }

	// RVA: 0x756540
	public static string get_GraphApiUserAgent() { }

	// RVA: 0x7568E4
	public static bool get_IsEditor() { }

	// RVA: 0x756954
	public static bool get_IsWeb() { }

	// RVA: 0x756AF0
	public static string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x75686C
	public static string get_UnitySDKUserAgent() { }

	// RVA: 0x756D84
	public static bool get_DebugMode() { }

	// RVA: 0x756970
	public static FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x756DF4
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

	// RVA: 0x756E84
	public System.Collections.Generic.IDictionary<System.String,System.String> toGraphAPIData() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText
{
	// Fields
	private string _default; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> _localizations; // 0x18

	// Methods

	// RVA: 0x757034
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x757154
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo
{
	// Fields
	private string _url; // 0x10

	// Methods

	// RVA: 0x757338
	public string get_Url() { }

}

// Namespace: 
private sealed class OnDLLLoaded
{
	// Methods

	// RVA: 0x758880
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x75BBF4
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class Mobile
{
	// Methods

	// RVA: 0x75BC08
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x75BCE8
	public static void LoginWithTrackingPreference(LoginTracking loginTracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x75BE28
	public static AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x75BEE0
	public static Profile CurrentProfile() { }

	// RVA: 0x75BF98
	public static void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x75C05C
	public static bool IsImplicitPurchaseLoggingEnabled() { }

}

// Namespace: 
internal abstract class CompiledFacebookLoader
{
	// Methods

	// RVA: -1
	protected abstract FacebookGameObject get_FBGameObject() { }

	// RVA: 0x75C114
	public void Start() { }

	// RVA: 0x75C258
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

	// RVA: 0x758878
	public void .ctor() { }

	// RVA: 0x75C260
	internal void <Init>b__0() { }

	// RVA: 0x75C470
	internal void <Init>b__1() { }

	// RVA: 0x75C548
	internal void <Init>b__2() { }

	// RVA: 0x75C710
	internal void <Init>b__3() { }

	// RVA: 0x75C820
	internal void <Init>b__4() { }

	// RVA: 0x75C8E0
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

	// RVA: 0x757340
	public static string get_AppId() { }

	// RVA: 0x7573BC
	private static void set_AppId(string value) { }

	// RVA: 0x757428
	public static string get_ClientToken() { }

	// RVA: 0x7574A4
	private static void set_ClientToken(string value) { }

	// RVA: 0x757510
	public static string get_GraphApiVersion() { }

	// RVA: 0x75758C
	public static void set_GraphApiVersion(string value) { }

	// RVA: 0x7575F8
	public static bool get_IsLoggedIn() { }

	// RVA: 0x757714
	public static bool get_IsInitialized() { }

	// RVA: 0x757838
	public static bool get_LimitAppEventUsage() { }

	// RVA: 0x75795C
	public static void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x756780
	internal static IFacebook get_FacebookImpl() { }

	// RVA: 0x757A80
	internal static void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x7563FC
	internal static string get_FacebookDomain() { }

	// RVA: 0x757AF4
	internal static void set_FacebookDomain(string value) { }

	// RVA: 0x757B60
	private static OnDLLLoaded get_OnDLLLoadedDelegate() { }

	// RVA: 0x757BDC
	private static void set_OnDLLLoadedDelegate(OnDLLLoaded value) { }

	// RVA: 0x757C48
	public static void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x757D88
	public static void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x758A60
	public static void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x758B58
	public static void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x758C50
	public static void LogOut() { }

	// RVA: 0x758D40
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x758EA8
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x759018
	public static void AppRequest(string message, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x759168
	public static void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x759288
	public static void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7593D4
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x75953C
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x7596A4
	public static void ActivateApp() { }

	// RVA: 0x7597E8
	public static void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7598E0
	public static void ClearAppLink() { }

	// RVA: 0x7598E4
	public static void LogAppEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7599EC
	public static void LogPurchase(Decimal logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x759AD8
	public static void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x759C00
	private static void LogVersion() { }

	// RVA: 0x759F38
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x75A028
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x75A118
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x75A220
	public static void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x75A318
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x75A408
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x75A4F8
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x75A5F0
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x75A6E8
	public static Profile CurrentProfile() { }

	// RVA: 0x75A7D8
	public static void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x75A8C8
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75A9C0
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75AAB8
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75ABB0
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75ACA8
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x75AD98
	public static void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x75AE88
	public static void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x75AF80
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x75B0A8
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x75B1A0
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75B298
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75B388
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75B490
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75B5D8
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75B6E8
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75B7F8
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75B914
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75BA34
	public static void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x75BB24
	public void .ctor() { }

	// RVA: 0x75BB2C
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public sealed class FBGamingServices
{
	// Methods

	// RVA: 0x75C99C
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x75CB40
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75CC18
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75CCF0
	public static void PerformCustomUpdate(CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75CD88
	public static void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x75CE4C
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x75CF10
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x75CFD4
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x75D09C
	public static void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x75D15C
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x75D220
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x75D2E4
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x75D3A4
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x75D464
	public static void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x75D528
	public static void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x75D5EC
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x75D6DC
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75D79C
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75D85C
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75D91C
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75D9DC
	public static void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x75DAA0
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x75DB60
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75DC24
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75DCEC
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75DDF4
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75DEB4
	public static void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x75DF78
	public static void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x75E038
	public static void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x75E0F8
	public static void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x75E1D0
	public static void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x75CA60
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x75E294
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

	// RVA: 0x75F848
	private static void .cctor() { }

	// RVA: 0x75F8B4
	public void .ctor() { }

	// RVA: 0x75F8BC
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

	// RVA: 0x75E29C
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract bool get_LimitEventUsage() { }

	// RVA: -1
	public abstract void set_LimitEventUsage(bool value) { }

	// RVA: -1
	public abstract string get_SDKName() { }

	// RVA: -1
	public abstract string get_SDKVersion() { }

	// RVA: 0x75E2D0
	public virtual string get_SDKUserAgent() { }

	// RVA: 0x75E31C
	public virtual bool get_LoggedIn() { }

	// RVA: 0x75E3F0
	public bool get_Initialized() { }

	// RVA: 0x75E3F8
	public void set_Initialized(bool value) { }

	// RVA: 0x75E400
	protected CallbackManager get_CallbackManager() { }

	// RVA: 0x75E408
	private void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x75E410
	public virtual void Init(InitDelegate onInitComplete) { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x75E418
	public virtual void LogOut() { }

	// RVA: -1
	public abstract void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: -1
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x75E470
	public void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75EF40
	public void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void ActivateApp(string appId) { }

	// RVA: -1
	public abstract void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	public abstract void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x75F18C
	public virtual void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x75F2FC
	public void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x75F354
	protected void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x75F79C
	protected virtual void OnAuthResponse(LoginResult result) { }

	// RVA: 0x75E820
	private System.Collections.Generic.IDictionary<System.String,System.String> CopyByValue(System.Collections.Generic.IDictionary<System.String,System.String> data) { }

	// RVA: 0x75EE78
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

	// RVA: 0x75F824
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75F828
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x75F82C
	private void <OnInitComplete>b__35_0(ILoginResult result) { }

}

// Namespace: Facebook.Unity
public sealed class InitDelegate
{
	// Methods

	// RVA: 0x75F8C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x75F968
	public virtual void Invoke() { }

}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T result) { }

}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate
{
	// Methods

	// RVA: 0x75F97C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x75FA20
	public virtual void Invoke(bool isUnityShown) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject
{
	// Fields
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Methods

	// RVA: 0x75FA34
	public IFacebookImplementation get_Facebook() { }

	// RVA: 0x75FA3C
	public void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x75FA44
	public void Awake() { }

	// RVA: 0x75FB24
	public void OnInitComplete(string message) { }

	// RVA: 0x75FD90
	public void OnLoginComplete(string message) { }

	// RVA: 0x75FE70
	public void OnLogoutComplete(string message) { }

	// RVA: 0x75FF50
	public void OnGetAppLinkComplete(string message) { }

	// RVA: 0x760030
	public void OnAppRequestsComplete(string message) { }

	// RVA: 0x760110
	public void OnShareLinkComplete(string message) { }

	// RVA: 0x7601F0
	protected virtual void OnAwake() { }

	// RVA: 0x7601F4
	protected void .ctor() { }

}

// Namespace: Facebook.Unity
public class FacebookSdkVersion
{
	// Methods

	// RVA: 0x756C10
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

	// RVA: 0x7601FC
	public void .ctor() { }

	// RVA: 0x760324
	public void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x760278
	private void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> arguments) { }

	// RVA: 0x316B894
	public void AddPrimative(string argumentName, T value) { }

	// RVA: 0x316B894
	public void AddNullablePrimitive(string argumentName, System.Nullable<T> nullable) { }

	// RVA: 0x760340
	public void AddString(string argumentName, string value) { }

	// RVA: 0x760420
	public void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x760568
	public void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

	// RVA: 0x30B2F18
	public void AddList(string argumentName, System.Collections.Generic.IEnumerable<T> list) { }

	// RVA: 0x760AC8
	public void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x760C30
	public string ToJsonString() { }

	// RVA: 0x760648
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

	// RVA: 0x30B2F18
	public void .ctor(FacebookBase facebookImpl, string methodName) { }

	// RVA: 0x30B1CD4
	public string get_MethodName() { }

	// RVA: 0x30B2CB8
	private void set_MethodName(string value) { }

	// RVA: 0x30B1CD4
	protected Facebook.Unity.FacebookDelegate<T> get_Callback() { }

	// RVA: 0x30B2CB8
	public void set_Callback(Facebook.Unity.FacebookDelegate<T> value) { }

	// RVA: 0x30B2CB8
	protected void set_FacebookImpl(FacebookBase value) { }

	// RVA: 0x30B2CB8
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

	// RVA: 0x760CB8
	internal void .ctor(string amount, string currency) { }

	// RVA: 0x760D08
	public string get_Amount() { }

	// RVA: 0x760D10
	private void set_Amount(string value) { }

	// RVA: 0x760D18
	public string get_Currency() { }

	// RVA: 0x760D20
	private void set_Currency(string value) { }

	// RVA: 0x760D28
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

	// RVA: 0x760E3C
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode) { }

	// RVA: 0x761010
	public string get_Title() { }

	// RVA: 0x761018
	private void set_Title(string value) { }

	// RVA: 0x761020
	public string get_ProductID() { }

	// RVA: 0x761028
	private void set_ProductID(string value) { }

	// RVA: 0x761030
	public string get_Description() { }

	// RVA: 0x761038
	private void set_Description(string value) { }

	// RVA: 0x761040
	public string get_ImageURI() { }

	// RVA: 0x761048
	private void set_ImageURI(string value) { }

	// RVA: 0x761050
	public string get_Price() { }

	// RVA: 0x761058
	private void set_Price(string value) { }

	// RVA: 0x761060
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x76106C
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x761074
	public string get_PriceCurrencyCode() { }

	// RVA: 0x76107C
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x761084
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

	// RVA: 0x761374
	internal void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest) { }

	// RVA: 0x76199C
	public string get_DeveloperPayload() { }

	// RVA: 0x7619A4
	private void set_DeveloperPayload(string value) { }

	// RVA: 0x7619AC
	public bool get_IsConsumed() { }

	// RVA: 0x7619B4
	public string get_PaymentActionType() { }

	// RVA: 0x7619BC
	private void set_PaymentActionType(string value) { }

	// RVA: 0x7619C4
	public string get_PaymentID() { }

	// RVA: 0x7619CC
	private void set_PaymentID(string value) { }

	// RVA: 0x7619D4
	public string get_ProductID() { }

	// RVA: 0x7619DC
	private void set_ProductID(string value) { }

	// RVA: 0x7619E4
	public string get_PurchasePlatform() { }

	// RVA: 0x7619EC
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x7619F4
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x7619FC
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x761A04
	public DateTime get_PurchaseTime() { }

	// RVA: 0x761A0C
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x761A14
	public string get_PurchaseToken() { }

	// RVA: 0x761A1C
	private void set_PurchaseToken(string value) { }

	// RVA: 0x761A24
	public string get_SignedRequest() { }

	// RVA: 0x761A2C
	private void set_SignedRequest(string value) { }

	// RVA: 0x761A34
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

	// RVA: 0x761D8C
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	// RVA: 0x761F80
	public string get_Title() { }

	// RVA: 0x761F88
	private void set_Title(string value) { }

	// RVA: 0x761F90
	public string get_ProductID() { }

	// RVA: 0x761F98
	private void set_ProductID(string value) { }

	// RVA: 0x761FA0
	public string get_Description() { }

	// RVA: 0x761FA8
	private void set_Description(string value) { }

	// RVA: 0x761FB0
	public string get_ImageURI() { }

	// RVA: 0x761FB8
	private void set_ImageURI(string value) { }

	// RVA: 0x761FC0
	public string get_Price() { }

	// RVA: 0x761FC8
	private void set_Price(string value) { }

	// RVA: 0x761FD0
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x761FDC
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x761FE4
	public string get_PriceCurrencyCode() { }

	// RVA: 0x761FEC
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x761FF4
	public string get_SubscriptionTerm() { }

	// RVA: 0x761FFC
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x762004
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

	// RVA: 0x76231C
	internal void .ctor(Int64 deactivationTime, bool isEntitlementActive, Int64 periodStartTime, Int64 periodEndTime, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	// RVA: 0x762C34
	public DateTime get_DeactivationTime() { }

	// RVA: 0x762C3C
	private void set_DeactivationTime(DateTime value) { }

	// RVA: 0x762C44
	public bool get_IsEntitlementActive() { }

	// RVA: 0x762C4C
	private void set_IsEntitlementActive(bool value) { }

	// RVA: 0x762C54
	public DateTime get_PeriodStartTime() { }

	// RVA: 0x762C5C
	private void set_PeriodStartTime(DateTime value) { }

	// RVA: 0x762C64
	public DateTime get_PeriodEndTime() { }

	// RVA: 0x762C6C
	private void set_PeriodEndTime(DateTime value) { }

	// RVA: 0x762C74
	public string get_ProductID() { }

	// RVA: 0x762C7C
	private void set_ProductID(string value) { }

	// RVA: 0x762C84
	public string get_PurchasePlatform() { }

	// RVA: 0x762C8C
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x762C94
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x762C9C
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x762CA4
	public DateTime get_PurchaseTime() { }

	// RVA: 0x762CAC
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x762CB4
	public string get_PurchaseToken() { }

	// RVA: 0x762CBC
	private void set_PurchaseToken(string value) { }

	// RVA: 0x762CC4
	public string get_SignedRequest() { }

	// RVA: 0x762CCC
	private void set_SignedRequest(string value) { }

	// RVA: 0x762CD4
	public string get_Status() { }

	// RVA: 0x762CDC
	private void set_Status(string value) { }

	// RVA: 0x762CE4
	public string get_SubscriptionTerm() { }

	// RVA: 0x762CEC
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x762CF4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult
{
	// Fields
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Methods

	// RVA: 0x763098
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7634A0
	public AccessToken get_AccessToken() { }

	// RVA: 0x7634A8
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x7634B0
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

	// RVA: 0x7637BC
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x763978
	public string get_Url() { }

	// RVA: 0x763980
	private void set_Url(string value) { }

	// RVA: 0x763988
	public string get_TargetUrl() { }

	// RVA: 0x763990
	private void set_TargetUrl(string value) { }

	// RVA: 0x763998
	public string get_Ref() { }

	// RVA: 0x7639A0
	private void set_Ref(string value) { }

	// RVA: 0x7639A8
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_Extras() { }

	// RVA: 0x7639B0
	private void set_Extras(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x7639B8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppRequestResult
{
	// Fields
	private string <RequestID>k__BackingField; // 0x50
	private System.Collections.Generic.IEnumerable<System.String> <To>k__BackingField; // 0x58

	// Methods

	// RVA: 0x763BF4
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7640C8
	public string get_RequestID() { }

	// RVA: 0x7640D0
	private void set_RequestID(string value) { }

	// RVA: 0x7640D8
	public System.Collections.Generic.IEnumerable<System.String> get_To() { }

	// RVA: 0x7640E0
	private void set_To(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7640E8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField; // 0x50

	// Methods

	// RVA: 0x764290
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x764ABC
	public System.Collections.Generic.IList<Facebook.Unity.Product> get_Products() { }

	// RVA: 0x764AC4
	private void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value) { }

	// RVA: 0x764ACC
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

	// RVA: 0x764EB4
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult
{
	// Methods

	// RVA: 0x764EB8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult
{
	// Methods

	// RVA: 0x764EBC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GraphResult
{
	// Fields
	private System.Collections.Generic.IList<System.Object> <ResultList>k__BackingField; // 0x50
	private Texture2D <Texture>k__BackingField; // 0x58

	// Methods

	// RVA: 0x764EC0
	internal void .ctor(UnityWebRequestAsyncOperation result) { }

	// RVA: 0x7651A8
	private void set_ResultList(System.Collections.Generic.IList<System.Object> value) { }

	// RVA: 0x7651B0
	public Texture2D get_Texture() { }

	// RVA: 0x7651B8
	private void set_Texture(Texture2D value) { }

	// RVA: 0x765088
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

	// RVA: 0x7651C0
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

	// RVA: 0x7651C4
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult
{
	// Methods

	// RVA: 0x7651C8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class InterstitialAdResult
{
	// Methods

	// RVA: 0x7651CC
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

	// RVA: 0x765314
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7658B8
	public AccessToken get_AccessToken() { }

	// RVA: 0x7658C0
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x7658C8
	public AuthenticationToken get_AuthenticationToken() { }

	// RVA: 0x7658D0
	private void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x7658D8
	public override string ToString() { }

	// RVA: 0x765A84
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class LoginStatusResult
{
	// Fields
	public static readonly string FailedKey; // 0x0
	private bool <Failed>k__BackingField; // 0x60

	// Methods

	// RVA: 0x765C80
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765E50
	public bool get_Failed() { }

	// RVA: 0x765E58
	private void set_Failed(bool value) { }

	// RVA: 0x765E60
	public override string ToString() { }

	// RVA: 0x765F9C
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult
{
	// Methods

	// RVA: 0x766014
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class PayloadResult
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x50

	// Methods

	// RVA: 0x766018
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7662A8
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x7662B0
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7662B8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PayResult
{
	// Methods

	// RVA: 0x7662FC
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7663EC
	public Int64 get_ErrorCode() { }

	// RVA: 0x7664C8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchaseResult
{
	// Fields
	private Purchase <Purchase>k__BackingField; // 0x50

	// Methods

	// RVA: 0x766690
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x766C28
	public Purchase get_Purchase() { }

	// RVA: 0x766C30
	private void set_Purchase(Purchase value) { }

	// RVA: 0x766C38
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchasesResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField; // 0x50

	// Methods

	// RVA: 0x766D30
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7674CC
	public System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases() { }

	// RVA: 0x7674D4
	private void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value) { }

	// RVA: 0x7674DC
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

	// RVA: 0x7631F8
	internal void .ctor(ResultContainer result) { }

	// RVA: 0x76503C
	internal void .ctor(ResultContainer result, string error, bool cancelled) { }

	// RVA: 0x767F94
	public virtual string get_Error() { }

	// RVA: 0x767F9C
	protected virtual void set_Error(string value) { }

	// RVA: 0x767FA4
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> get_ErrorDictionary() { }

	// RVA: 0x767FAC
	protected virtual void set_ErrorDictionary(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x767FB4
	public virtual System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x767FBC
	protected virtual void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x767FC4
	public virtual string get_RawResult() { }

	// RVA: 0x767FCC
	protected virtual void set_RawResult(string value) { }

	// RVA: 0x767FD4
	public virtual bool get_Cancelled() { }

	// RVA: 0x767FDC
	protected virtual void set_Cancelled(bool value) { }

	// RVA: 0x767FE4
	public virtual string get_CallbackId() { }

	// RVA: 0x767FEC
	protected virtual void set_CallbackId(string value) { }

	// RVA: 0x767FF4
	protected System.Nullable<System.Int64> get_CanvasErrorCode() { }

	// RVA: 0x768000
	private void set_CanvasErrorCode(System.Nullable<System.Int64> value) { }

	// RVA: 0x7635F0
	public override string ToString() { }

	// RVA: 0x767D80
	protected void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x7678C4
	private static string GetErrorValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x767960
	private static bool GetCancelledValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x767CE4
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

	// RVA: 0x76855C
	public void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x75FC00
	public void .ctor(string result) { }

	// RVA: 0x7687D0
	public string get_RawResult() { }

	// RVA: 0x7687D8
	private void set_RawResult(string value) { }

	// RVA: 0x7687E0
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x7687E8
	public void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x76861C
	private System.Collections.Generic.IDictionary<System.String,System.Object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

}

// Namespace: Facebook.Unity
internal class RewardedVideoResult
{
	// Methods

	// RVA: 0x7687F0
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult
{
	// Methods

	// RVA: 0x768938
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ShareResult
{
	// Fields
	private string <PostId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x76893C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x768AE8
	public string get_PostId() { }

	// RVA: 0x768AF0
	private void set_PostId(string value) { }

	// RVA: 0x768A7C
	internal static string get_PostIDKey() { }

	// RVA: 0x768AF8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Methods

	// RVA: 0x768BF0
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x76941C
	public System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> get_SubscribableProducts() { }

	// RVA: 0x769424
	private void set_SubscribableProducts(System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> value) { }

	// RVA: 0x76942C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionResult
{
	// Fields
	private Subscription <Subscription>k__BackingField; // 0x50

	// Methods

	// RVA: 0x769814
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x769DAC
	public Subscription get_Subscription() { }

	// RVA: 0x769DB4
	private void set_Subscription(Subscription value) { }

	// RVA: 0x769DBC
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionsResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Subscription> <Subscriptions>k__BackingField; // 0x50

	// Methods

	// RVA: 0x769EB4
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x76A648
	public System.Collections.Generic.IList<Facebook.Unity.Subscription> get_Subscriptions() { }

	// RVA: 0x76A650
	private void set_Subscriptions(System.Collections.Generic.IList<Facebook.Unity.Subscription> value) { }

	// RVA: 0x76A658
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

	// RVA: 0x76ADDC
	public void .ctor(int <>1__state) { }

	// RVA: 0x76AE10
	private void System.IDisposable.Dispose() { }

	// RVA: 0x76AE14
	private bool MoveNext() { }

	// RVA: 0x76B900
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x76B908
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x76B948
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

	// RVA: 0x76AA40
	internal static void Post(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76AB80
	internal static void Get(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76AC1C
	internal static void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76AAE0
	internal static void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76AD64
	internal IEnumerator Start() { }

	// RVA: 0x76ACBC
	internal AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x76ACE4
	internal AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x76AD3C
	internal AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x76ACEC
	internal AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x76AD14
	internal AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76AE08
	public void .ctor() { }

}

// Namespace: 
private class DebugLogger
{
	// Methods

	// RVA: 0x76BA0C
	public void .ctor() { }

	// RVA: 0x76BCCC
	public void Log(string msg) { }

	// RVA: 0x76BD8C
	public void Info(string msg) { }

	// RVA: 0x76BE14
	public void Warn(string msg) { }

}

// Namespace: Facebook.Unity
internal static class FacebookLogger
{
	// Fields
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x76B950
	private static void .cctor() { }

	// RVA: 0x76BA14
	private static IFacebookLogger get_Instance() { }

	// RVA: 0x76BA90
	internal static void set_Instance(IFacebookLogger value) { }

	// RVA: 0x76BB04
	public static void Log(string msg) { }

	// RVA: 0x759DF8
	public static void Info(string msg) { }

	// RVA: 0x758920
	public static void Warn(string msg) { }

	// RVA: 0x76BC40
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

	// RVA: 0x316B894
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

	// RVA: 0x76ED08
	private static void .cctor() { }

	// RVA: 0x76ED74
	public void .ctor() { }

	// RVA: 0x76ED7C
	internal string <ParsePermissionFromResult>b__19_0(object permission) { }

}

// Namespace: Facebook.Unity
internal static class Utilities
{
	// Methods

	// RVA: 0x30B4264
	public static bool TryGetValue(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, T value) { }

	// RVA: 0x754C0C
	public static Int64 TotalSeconds(DateTime dateTime) { }

	// RVA: 0x316B894
	public static T GetValueOrDefault(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, bool logWarning) { }

	// RVA: 0x754CF8
	public static string ToCommaSeparateList(System.Collections.Generic.IEnumerable<System.String> list) { }

	// RVA: 0x76BE9C
	public static string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x756C54
	public static string GetUserAgent(string productName, string productVersion) { }

	// RVA: 0x763B74
	public static string ToJson(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x30B933C
	public static void AddAllKVPFrom(System.Collections.Generic.IDictionary<T1,T2> dest, System.Collections.Generic.IDictionary<T1,T2> source) { }

	// RVA: 0x763338
	public static AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7657C0
	public static AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x754D98
	public static string ToStringNullOk(object obj) { }

	// RVA: 0x754DFC
	public static string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<System.String,System.String> propertiesAndValues) { }

	// RVA: 0x76BF6C
	private static DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76C480
	private static System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76C164
	private static System.Collections.Generic.ICollection<System.String> ParsePermissionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x764594
	public static System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76C6C4
	public static Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x768EF4
	public static System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> ParseSubscribableCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76CEEC
	public static SubscribableProduct ParseSubscribableProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x767034
	public static System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x766A8C
	public static Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76A1B0
	public static System.Collections.Generic.IList<Facebook.Unity.Subscription> ParseSubscriptionsFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x769C10
	public static Subscription ParseSubscriptionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x76D838
	public static Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> purchase, bool isWindows) { }

	// RVA: 0x76E498
	public static Subscription ParseSubscriptionFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> subscription, bool isWindows) { }

	// RVA: 0x768008
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x766164
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary, string key) { }

	// RVA: 0x7618F4
	public static DateTime FromTimestamp(int timestamp) { }

}

// Namespace: Facebook.Unity
internal static class FBUnityUtility
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Methods

	// RVA: 0x75EDBC
	public static IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper
{
	// Methods

	// RVA: 0x76EDAC
	public void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76EE4C
	public void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x76EDA4
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

	// RVA: 0x76F000
	public void .ctor(int <>1__state) { }

	// RVA: 0x76F034
	private void System.IDisposable.Dispose() { }

	// RVA: 0x76F038
	private bool MoveNext() { }

	// RVA: 0x76F114
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x76F11C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x76F15C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class FacebookScheduler
{
	// Methods

	// RVA: 0x76EEEC
	public void Schedule(Action action, Int64 delay) { }

	// RVA: 0x76EF80
	public IEnumerator DelayEvent(Action action, Int64 delay) { }

	// RVA: 0x76F02C
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public interface IHasLicenseResult
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog
{
	// Methods

	// RVA: 0x76F164
	internal static void handlePurchaseCompleted(object data) { }

	// RVA: 0x76F8E4
	internal static void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x76FABC
	internal static void addListenerToGameObject(object gameObject, object listenerObject) { }

	// RVA: 0x76FEAC
	private static Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x76FA18
	private static object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x770008
	private static object GetField(object inObj, string fieldName) { }

	// RVA: 0x76F880
	private static object GetProperty(object inObj, string propertyName) { }

}

// Namespace: 
private sealed class <GenSnapshot>d__4
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Methods

	// RVA: 0x7703F4
	public void .ctor(int <>1__state) { }

	// RVA: 0x771A08
	private void System.IDisposable.Dispose() { }

	// RVA: 0x771A0C
	private bool MoveNext() { }

	// RVA: 0x771C74
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x771C7C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x771CBC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
public class CodelessCrawler
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x770068
	public void Awake() { }

	// RVA: 0x770118
	public void CaptureViewHierarchy(string message) { }

	// RVA: 0x770398
	private IEnumerator GenSnapshot() { }

	// RVA: 0x770420
	private static void SendAndroid(string json) { }

	// RVA: 0x77062C
	private static void SendIos(string json) { }

	// RVA: 0x770630
	private static string GenBase64Screenshot() { }

	// RVA: 0x770770
	private static string GenViewJson() { }

	// RVA: 0x770BA0
	private static void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x771918
	private void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x7702FC
	private static void updateMainCamera() { }

	// RVA: 0x7716DC
	private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x771810
	private static string getClasstypeBitmaskButton() { }

	// RVA: 0x771898
	private static string getVisibility(GameObject gameObj) { }

	// RVA: 0x7719FC
	public void .ctor() { }

	// RVA: 0x771A04
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent
{
	// Fields
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x771CC4
	private FBSDKEventBindingManager get_eventBindingManager() { }

	// RVA: 0x771CCC
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x771CD4
	private void Awake() { }

	// RVA: 0x771CF8
	private static void SetLoggerInitAndroid() { }

	// RVA: 0x771E40
	private static void SetLoggerInitIos() { }

	// RVA: 0x771E44
	public void OnReceiveMapping(string message) { }

	// RVA: 0x77222C
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

	// RVA: 0x772234
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x772690
	public string get_className() { }

	// RVA: 0x772698
	public void set_className(string value) { }

	// RVA: 0x7726A0
	public void set_text(string value) { }

	// RVA: 0x7726A8
	public void set_hint(string value) { }

	// RVA: 0x7726B0
	public void set_desc(string value) { }

	// RVA: 0x7726B8
	public void set_tag(string value) { }

	// RVA: 0x7726C0
	public void set_index(Int64 value) { }

	// RVA: 0x7726C8
	public void set_section(Int64 value) { }

	// RVA: 0x7726D0
	public void set_row(Int64 value) { }

	// RVA: 0x7726D8
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

	// RVA: 0x7726E0
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x772BE0
	public string get_eventName() { }

	// RVA: 0x772BE8
	public void set_eventName(string value) { }

	// RVA: 0x772BF0
	public string get_eventType() { }

	// RVA: 0x772BF8
	public void set_eventType(string value) { }

	// RVA: 0x772C00
	public string get_appVersion() { }

	// RVA: 0x772C08
	public void set_appVersion(string value) { }

	// RVA: 0x772C10
	public System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path() { }

	// RVA: 0x772C18
	public void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager
{
	// Fields
	private System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Methods

	// RVA: 0x772C20
	public System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings() { }

	// RVA: 0x772C28
	public void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value) { }

	// RVA: 0x771F4C
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

	// RVA: 0x772C30
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x772D2C
	public string get_MediaId() { }

	// RVA: 0x772D34
	private void set_MediaId(string value) { }

	// RVA: 0x772D3C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface ISessionScoreResult
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult
{
	// Methods

	// RVA: 0x772E34
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public class AuthenticationToken
{
	// Fields
	private string <TokenString>k__BackingField; // 0x10
	private string <Nonce>k__BackingField; // 0x18

	// Methods

	// RVA: 0x76C5EC
	internal void .ctor(string tokenString, string nonce) { }

	// RVA: 0x772E38
	public string get_TokenString() { }

	// RVA: 0x772E40
	private void set_TokenString(string value) { }

	// RVA: 0x772E48
	public string get_Nonce() { }

	// RVA: 0x772E50
	private void set_Nonce(string value) { }

	// RVA: 0x772E58
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

	// RVA: 0x772F6C
	internal void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	// RVA: 0x7731D0
	public string get_UserID() { }

	// RVA: 0x7731D8
	private void set_UserID(string value) { }

	// RVA: 0x7731E0
	public string get_FirstName() { }

	// RVA: 0x7731E8
	private void set_FirstName(string value) { }

	// RVA: 0x7731F0
	public string get_MiddleName() { }

	// RVA: 0x7731F8
	private void set_MiddleName(string value) { }

	// RVA: 0x773200
	public string get_LastName() { }

	// RVA: 0x773208
	private void set_LastName(string value) { }

	// RVA: 0x773210
	public string get_Name() { }

	// RVA: 0x773218
	private void set_Name(string value) { }

	// RVA: 0x773220
	public string get_Email() { }

	// RVA: 0x773228
	private void set_Email(string value) { }

	// RVA: 0x773230
	public string get_ImageURL() { }

	// RVA: 0x773238
	private void set_ImageURL(string value) { }

	// RVA: 0x773240
	public string get_LinkURL() { }

	// RVA: 0x773248
	private void set_LinkURL(string value) { }

	// RVA: 0x773250
	public string[] get_FriendIDs() { }

	// RVA: 0x773258
	private void set_FriendIDs(string[] value) { }

	// RVA: 0x773260
	public System.Nullable<System.DateTime> get_Birthday() { }

	// RVA: 0x77326C
	private void set_Birthday(System.Nullable<System.DateTime> value) { }

	// RVA: 0x773274
	public UserAgeRange get_AgeRange() { }

	// RVA: 0x77327C
	private void set_AgeRange(UserAgeRange value) { }

	// RVA: 0x773284
	public FBLocation get_Hometown() { }

	// RVA: 0x77328C
	private void set_Hometown(FBLocation value) { }

	// RVA: 0x773294
	public FBLocation get_Location() { }

	// RVA: 0x77329C
	private void set_Location(FBLocation value) { }

	// RVA: 0x7732A4
	public string get_Gender() { }

	// RVA: 0x7732AC
	private void set_Gender(string value) { }

	// RVA: 0x7732B4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class UserAgeRange
{
	// Fields
	private Int64 <Min>k__BackingField; // 0x10
	private Int64 <Max>k__BackingField; // 0x18

	// Methods

	// RVA: 0x773778
	internal void .ctor(Int64 min, Int64 max) { }

	// RVA: 0x7737B0
	public Int64 get_Min() { }

	// RVA: 0x7737B8
	private void set_Min(Int64 value) { }

	// RVA: 0x7737C0
	public Int64 get_Max() { }

	// RVA: 0x7737C8
	private void set_Max(Int64 value) { }

	// RVA: 0x7737D0
	internal static UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x7739C0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class FBLocation
{
	// Fields
	private string <ID>k__BackingField; // 0x10
	private string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x773B08
	internal void .ctor(string id, string name) { }

	// RVA: 0x773B58
	public string get_ID() { }

	// RVA: 0x773B60
	private void set_ID(string value) { }

	// RVA: 0x773B68
	public string get_Name() { }

	// RVA: 0x773B70
	private void set_Name(string value) { }

	// RVA: 0x773B78
	internal static FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x773D60
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

	// RVA: 0x773E74
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x774088
	public string get_TournamentId() { }

	// RVA: 0x774090
	private void set_TournamentId(string value) { }

	// RVA: 0x774098
	public string get_ContextId() { }

	// RVA: 0x7740A0
	private void set_ContextId(string value) { }

	// RVA: 0x7740A8
	public int get_EndTime() { }

	// RVA: 0x7740B0
	private void set_EndTime(int value) { }

	// RVA: 0x7740B8
	public string get_TournamentTitle() { }

	// RVA: 0x7740C0
	private void set_TournamentTitle(string value) { }

	// RVA: 0x7740C8
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x7740D0
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7740D8
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

	// RVA: 0x7746B0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x774B88
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

	// RVA: 0x774B90
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x774BB4
	private void set_Success(bool value) { }

}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult
{
	// Methods

	// RVA: 0x774BBC
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

	// RVA: 0x774BC0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x774C84
	public string get_ContextId() { }

	// RVA: 0x774C8C
	private void set_ContextId(string value) { }

	// RVA: 0x774C94
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x774D8C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x774E50
	public string get_ContextId() { }

	// RVA: 0x774E58
	private void set_ContextId(string value) { }

	// RVA: 0x774E60
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x774F58
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x77501C
	public string get_ContextId() { }

	// RVA: 0x775024
	private void set_ContextId(string value) { }

	// RVA: 0x77502C
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

	// RVA: 0x775124
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7751E8
	public string get_ContextId() { }

	// RVA: 0x7751F0
	private void set_ContextId(string value) { }

	// RVA: 0x7751F8
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

	// RVA: 0x7752F0
	public void .ctor() { }

	// RVA: 0x7754A8
	public void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7754F8
	public override bool get_LimitEventUsage() { }

	// RVA: 0x775500
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x775508
	public override string get_SDKName() { }

	// RVA: 0x77554C
	public override string get_SDKVersion() { }

	// RVA: 0x75C37C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x775590
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x775684
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x775778
	public override void LogOut() { }

	// RVA: 0x775830
	public override bool get_LoggedIn() { }

	// RVA: 0x7758E8
	public override void ActivateApp(string appId) { }

	// RVA: 0x775994
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x775D04
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x775E44
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x775F30
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x77601C
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x776120
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x776214
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x776254
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x776294
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7762D4
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x776314
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x776400
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7764F4
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7765E8
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7766DC
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7767D0
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7768BC
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7769A8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x776A9C
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x776BD0
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x776CC4
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x776DB8
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x776EA4
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x776FA8
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7770E8
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x777204
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x777320
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x777450
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x777580
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7753EC
	private static IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x77766C
	public void Tick() { }

	// RVA: 0x777724
	public void Deinit() { }

	// RVA: 0x7777DC
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x77781C
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x77785C
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x77789C
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7778DC
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x77791C
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x77795C
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x77799C
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7779DC
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

	// RVA: 0x777A1C
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x777AD4
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject
{
	// Methods

	// RVA: 0x777ADC
	protected IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x777B58
	protected override void OnAwake() { }

	// RVA: 0x777B5C
	public void Update() { }

	// RVA: 0x777C74
	public void OnDestroy() { }

	// RVA: 0x777D90
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	private bool <LimitEventUsage>k__BackingField; // 0x30

	// Methods

	// RVA: 0x777D98
	public void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x777DE8
	public void .ctor() { }

	// RVA: 0x777F88
	public override bool get_LimitEventUsage() { }

	// RVA: 0x777F90
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x777F98
	public override string get_SDKName() { }

	// RVA: 0x777FDC
	public override string get_SDKVersion() { }

	// RVA: 0x777F40
	private static IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x778020
	public override void Init(InitDelegate onInitComplete) { }

	// RVA: 0x778134
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x778144
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7782F4
	public void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7784A4
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7785C0
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7786F8
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x778830
	public override void ActivateApp(string appId) { }

	// RVA: 0x7788BC
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x778A20
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x778AAC
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x778B38
	public bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x778B40
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x778B48
	public override Profile CurrentProfile() { }

	// RVA: 0x778B50
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x778B90
	public void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x778EB0
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x778F24
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x778F98
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x779010
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x779084
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7790F8
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x778E3C
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x77916C
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x7791E0
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x779254
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7792C8
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x77933C
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7793B0
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x779424
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x779498
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x77950C
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x779580
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7795F4
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x779668
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7796DC
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x779750
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x7797C4
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x779838
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7798AC
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x779920
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x779994
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x779A08
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x779A7C
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x779AF0
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x779B64
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x779BD8
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x779C4C
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x779CC0
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x779D34
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x779DA8
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x779E1C
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x779E94
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x779F0C
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x779F80
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x779FF4
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x77A068
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x77A0DC
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x77A150
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x77A288
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77A2C8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77A308
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77A4A0
	public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77A638
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x77A678
	public void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x77A79C
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x77A8C0
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x77A9E4
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x77AB08
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x77AC2C
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x77AD50
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x77AE74
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x77AF98
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x77B0BC
	public void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x77B1E0
	public void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x77B304
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x77B428
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x77B54C
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x77B670
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x77B794
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x77B8B8
	public void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x77B9DC
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x77BB00
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x77BC24
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77BE20
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x77BF44
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77C140
	public void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x77C264
	public void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x77C388
	public void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x77C4AC
	public void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x77C5D0
	public void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x77C6F4
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x77C734
	public void OnUrlResponse(string message) { }

	// RVA: 0x77C774
	public void OnHideUnity(bool hidden) { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject
{
	// Methods

	// RVA: 0x780924
	protected override void OnAwake() { }

	// RVA: 0x78092C
	private void OnEnable() { }

	// RVA: 0x7809DC
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x7809E4
	private void OnDisable() { }

	// RVA: 0x780A94
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x780AA0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader
{
	// Methods

	// RVA: 0x780AA8
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x780B44
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

	// RVA: 0x780B4C
	protected Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback() { }

	// RVA: 0x780B54
	public void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value) { }

	// RVA: 0x780B5C
	protected string get_CallbackID() { }

	// RVA: 0x780B64
	public void set_CallbackID(string value) { }

	// RVA: -1
	protected abstract string get_DialogTitle() { }

	// RVA: 0x780B6C
	public void Start() { }

	// RVA: 0x780C98
	public void OnGUI() { }

	// RVA: -1
	protected abstract void DoGui() { }

	// RVA: -1
	protected abstract void SendSuccessResult() { }

	// RVA: 0x780DA8
	protected virtual void SendCancelResult() { }

	// RVA: 0x780F28
	protected virtual void SendErrorResult(string errorMessage) { }

	// RVA: 0x781078
	private void OnGUIDialog(int windowId) { }

	// RVA: 0x781498
	protected void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x7814A0
	public void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x7814D4
	public void Init() { }

	// RVA: 0x7815B0
	public void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x781630
	public void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x7817B8
	public void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x781854
	public void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x78171C
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

	// RVA: 0x7818F0
	public string get_EmptyDialogTitle() { }

	// RVA: 0x7818F8
	public void set_EmptyDialogTitle(string value) { }

	// RVA: 0x781900
	protected override string get_DialogTitle() { }

	// RVA: 0x781908
	protected override void DoGui() { }

	// RVA: 0x78190C
	protected override void SendSuccessResult() { }

	// RVA: 0x781A7C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x782094
	public void .ctor() { }

	// RVA: 0x782108
	internal void <SendSuccessResult>b__0(IGraphResult graphResult) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1
{
	// Fields
	public string facebookID; // 0x10
	public Facebook.Unity.Editor.Dialogs.MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7824A8
	public void .ctor() { }

	// RVA: 0x7824B0
	internal void <SendSuccessResult>b__1(IGraphResult permResult) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog
{
	// Fields
	private string accessToken; // 0x48

	// Methods

	// RVA: 0x781A84
	protected override string get_DialogTitle() { }

	// RVA: 0x781AC8
	protected override void DoGui() { }

	// RVA: 0x781D28
	protected override void SendSuccessResult() { }

	// RVA: 0x78209C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog
{
	// Fields
	private string <SubTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x782EB0
	private string get_SubTitle() { }

	// RVA: 0x782EB8
	public void set_SubTitle(string value) { }

	// RVA: 0x782EC0
	protected override string get_DialogTitle() { }

	// RVA: 0x782F30
	protected override void DoGui() { }

	// RVA: 0x782F34
	protected override void SendSuccessResult() { }

	// RVA: 0x7833EC
	protected override void SendCancelResult() { }

	// RVA: 0x78310C
	private string GenerateFakePostID() { }

	// RVA: 0x783534
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

	// RVA: 0x78353C
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x783544
	public override Profile CurrentProfile() { }

	// RVA: 0x783584
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: -1
	public abstract bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7835C4
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x783640
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7836BC
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x783738
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7837B4
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x783830
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x7838FC
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x78393C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x78397C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7839BC
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x783A38
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x783AB4
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x783B30
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x783BAC
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x783C28
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x783CA4
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x783D20
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x783D9C
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x783E18
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x783E94
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x783F10
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x783F8C
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x784008
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x784084
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x784100
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x78417C
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7841F8
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x784274
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x7842F0
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x78436C
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7843E8
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x784464
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7844E0
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x78455C
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7845D8
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x784654
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7846D0
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x78474C
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x7847C8
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x784844
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7848C0
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x78493C
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7849B8
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x784A34
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x784AB0
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x784AF0
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x784B30
	public virtual void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x784B70
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x784BB0
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x784BF0
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x784C30
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x784C70
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x784CB0
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x784CF0
	public override void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x784D30
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x784D70
	public virtual void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x784DB0
	public virtual void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x784DF0
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x784E30
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x784E70
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x784EB0
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x784EF0
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x784F30
	public virtual void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x784F70
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x784FB0
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x784FF0
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x785030
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x785070
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7850B0
	public virtual void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x7850F0
	public virtual void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x785130
	public virtual void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x785170
	public virtual void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7851B0
	public virtual void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject
{
	// Methods

	// RVA: 0x7851F0
	private IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x78526C
	public void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x7853B4
	public void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x785500
	public void OnFriendFinderComplete(string message) { }

	// RVA: 0x78564C
	public void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x785798
	public void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x7858E4
	public void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x785A30
	public void OnGetCatalogComplete(string message) { }

	// RVA: 0x785B7C
	public void OnGetPurchasesComplete(string message) { }

	// RVA: 0x785CC8
	public void OnPurchaseComplete(string message) { }

	// RVA: 0x785E14
	public void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x785F60
	public void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x7860AC
	public void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x7861F8
	public void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x786344
	public void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x786490
	public void OnInitCloudGameComplete(string message) { }

	// RVA: 0x7865DC
	public void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x786728
	public void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x786874
	public void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x7869C0
	public void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x786B0C
	public void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x786C58
	public void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x786DA4
	public void OnGetPayloadComplete(string message) { }

	// RVA: 0x786EF0
	public virtual void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x78703C
	public virtual void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x787188
	public virtual void OnGetTournamentComplete(string message) { }

	// RVA: 0x7872D4
	public virtual void OnShareTournamentComplete(string message) { }

	// RVA: 0x787420
	public virtual void OnCreateTournamentComplete(string message) { }

	// RVA: 0x78756C
	public virtual void OnGetTournamentsComplete(string message) { }

	// RVA: 0x7876B8
	public virtual void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x787804
	public virtual void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x787950
	public virtual void OnTournamentDialogCancel(string message) { }

	// RVA: 0x787A9C
	public virtual void OnTournamentDialogError(string message) { }

	// RVA: 0x787BE8
	public void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x787D34
	public void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x787E80
	public void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x787FCC
	public void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x788118
	public void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x788264
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

	// RVA: 0x78A898
	public void .ctor() { }

	// RVA: 0x78A8DC
	public int get_NumEntries() { }

	// RVA: 0x78A8E4
	public void set_NumEntries(int value) { }

	// RVA: 0x78A8EC
	public string[] get_Keys() { }

	// RVA: 0x78A8F4
	public void set_Keys(string[] value) { }

	// RVA: 0x78A8FC
	public string[] get_Values() { }

	// RVA: 0x78A904
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

	// RVA: 0x78826C
	public void .ctor() { }

	// RVA: 0x7883AC
	public void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7883E4
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7883EC
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7884A8
	public override string get_SDKName() { }

	// RVA: 0x7884EC
	public override string get_SDKVersion() { }

	// RVA: 0x7885A4
	public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x788714
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78882C
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78892C
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x788A2C
	public override void LogOut() { }

	// RVA: 0x788AF0
	public override bool get_LoggedIn() { }

	// RVA: 0x788BCC
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x788C84
	public override Profile CurrentProfile() { }

	// RVA: 0x788D3C
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x789170
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7892A0
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7894B8
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x789B28
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x789C1C
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x789C24
	public override void ActivateApp(string appId) { }

	// RVA: 0x789CDC
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x789DF4
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x789F0C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x789F4C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x789F8C
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x78A0AC
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x78A1CC
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x78A378
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x78A490
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x78A5A8
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78A704
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78A858
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7882F0
	private static IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x7896A4
	private static NativeDict MarshallDict(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x30B1ACC
	private int AddCallback(Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject
{
	// Methods

	// RVA: 0x78A90C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader
{
	// Methods

	// RVA: 0x78A914
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x78AA38
	public void .ctor() { }

}

// Namespace: 
private class JavaMethodCall<T0>
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(AndroidFacebook androidImpl, string methodName) { }

	// RVA: 0x30B2CB8
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

	// RVA: 0x78F794
	private static void .cctor() { }

	// RVA: 0x78F800
	public void .ctor() { }

	// RVA: 0x78F808
	internal string <CreateTournament>b__73_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x78F8D0
	internal object <CreateTournament>b__73_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x78F99C
	internal string <ShareTournament>b__74_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x78FA64
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

	// RVA: 0x78AA40
	public void .ctor() { }

	// RVA: 0x78ABC8
	public void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	// RVA: 0x78AC58
	private void set_KeyHash(string value) { }

	// RVA: 0x78AC60
	public override bool get_LimitEventUsage() { }

	// RVA: 0x78AC68
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x78AE38
	public override string get_SDKName() { }

	// RVA: 0x78AE7C
	public override string get_SDKVersion() { }

	// RVA: 0x78AF5C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x78B1C4
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78B284
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78B3B4
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78B4E4
	public override void LogOut() { }

	// RVA: 0x78B5A0
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x78B8B4
	public override Profile CurrentProfile() { }

	// RVA: 0x78C174
	public void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x78C1F0
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78C548
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78C70C
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78C94C
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x78CA1C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78CCCC
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78CE84
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x78CF64
	public override void ActivateApp(string appId) { }

	// RVA: 0x78CFBC
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x78D08C
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x78D15C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x78D19C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x78D1DC
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78D3A8
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x78D50C
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x78D54C
	public override void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x78D61C
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x78D6EC
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x78D7BC
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x78D920
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x78DA50
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x78DB20
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x78DBF0
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x78DD20
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x78DE50
	public override void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x78DF20
	public override void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x78DFF0
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x78E1FC
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78E32C
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78E45C
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x78E58C
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x78E6BC
	public override void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x78E78C
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x78E8CC
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x78EA0C
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x78EADC
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x78EE8C
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x78F198
	public override void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x78F268
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x78F398
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x78F4C8
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x78F694
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x78AB0C
	private static IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x78AD08
	private void CallFB(string method, string args) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject
{
	// Methods

	// RVA: 0x78FB30
	protected override void OnAwake() { }

	// RVA: 0x78FB38
	private void OnEnable() { }

	// RVA: 0x78FBE8
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x78FBF0
	private void OnDisable() { }

	// RVA: 0x78FCA0
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x78FCAC
	public void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x78FDA0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader
{
	// Methods

	// RVA: 0x78FDA8
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x78FE60
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

	// RVA: 0x30B30EC
	public void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }

	// RVA: 0x30B2CB8
	public override void Call(MethodArguments args) { }

	// RVA: 0x30B30EC
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

	// RVA: 0x792BC4
	private static void .cctor() { }

	// RVA: 0x792C30
	public void .ctor() { }

	// RVA: 0x792C38
	internal void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass47_0
{
	// Fields
	public ResultContainer result; // 0x10
	public Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x7924C0
	public void .ctor() { }

	// RVA: 0x792CE8
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

	// RVA: 0x78FE68
	public void .ctor() { }

	// RVA: 0x78FFA8
	public void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x78FEEC
	private static ICanvasJSWrapper GetCanvasJSWrapper() { }

	// RVA: 0x78FFE0
	public override bool get_LimitEventUsage() { }

	// RVA: 0x78FFE8
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x78FFF0
	public override string get_SDKName() { }

	// RVA: 0x790034
	public override string get_SDKVersion() { }

	// RVA: 0x7900E8
	public override string get_SDKUserAgent() { }

	// RVA: 0x790398
	public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7907C8
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x790934
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x790AA0
	public override void LogOut() { }

	// RVA: 0x790B64
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x790F14
	public override void ActivateApp(string appId) { }

	// RVA: 0x790FCC
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7911A8
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x791400
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x79155C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x791680
	public override void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7917AC
	public override void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x7921D4
	public override void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x792214
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x792328
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7923A4
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x792420
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x79249C
	public void OnUrlResponse(string url) { }

	// RVA: 0x7924A4
	public void OnHideUnity(bool isGameShown) { }

	// RVA: 0x79183C
	private static void FormatAuthResponse(ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback) { }

	// RVA: 0x7924C8
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x792508
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x792548
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x792588
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7925C8
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x792608
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x792648
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x792688
	public override void CancelSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7926C8
	public override Profile CurrentProfile() { }

	// RVA: 0x792708
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x792748
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x792788
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7927C8
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x792808
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x792848
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x792888
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7928C8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x792908
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x792948
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x792988
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7929C8
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x792A08
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x792A48
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x792A88
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x792AC8
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x792B08
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x792B48
	private void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject
{
	// Methods

	// RVA: 0x7934DC
	protected ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x793558
	public void OnPayComplete(string result) { }

	// RVA: 0x7936A0
	public void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x7937EC
	public void OnUrlResponse(string message) { }

	// RVA: 0x793904
	public void OnHideUnity(bool hide) { }

	// RVA: 0x793A1C
	protected override void OnAwake() { }

	// RVA: 0x793AF4
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader
{
	// Methods

	// RVA: 0x793AFC
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x793C20
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

	// RVA: 0x793C28
	public void Start() { }

	// RVA: 0x793C8C
	public void OnLoginComplete(string responseJsonData) { }

	// RVA: 0x793D44
	public void OnFacebookAuthResponseChange(string responseJsonData) { }

	// RVA: 0x793DFC
	public void OnPayComplete(string responseJsonData) { }

	// RVA: 0x793EB0
	public void OnAppRequestsComplete(string responseJsonData) { }

	// RVA: 0x793F68
	public void OnShareLinkComplete(string responseJsonData) { }

	// RVA: 0x794020
	public void OnFacebookFocus(string state) { }

	// RVA: 0x794100
	public void OnInitComplete(string responseJsonData) { }

	// RVA: 0x7941B4
	public void OnUrlResponse(string url) { }

	// RVA: 0x79426C
	public void .ctor() { }

}


