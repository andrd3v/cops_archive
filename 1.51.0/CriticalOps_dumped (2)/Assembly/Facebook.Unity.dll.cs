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

	// RVA: 0x787C24
	private void .ctor(string jsonString) { }

	// RVA: 0x787CA4
	private Char get_PeekChar() { }

	// RVA: 0x787D30
	private Char get_NextChar() { }

	// RVA: 0x787DBC
	private string get_NextWord() { }

	// RVA: 0x787F48
	private TOKEN get_NextToken() { }

	// RVA: 0x7878D8
	public static object Parse(string jsonString) { }

	// RVA: 0x78830C
	public void Dispose() { }

	// RVA: 0x788348
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x788970
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x7882E4
	private object ParseValue() { }

	// RVA: 0x788A80
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x7884D4
	private string ParseString() { }

	// RVA: 0x788B38
	private object ParseNumber() { }

	// RVA: 0x7881EC
	private void EatWhitespace() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x788C38
	private void .ctor() { }

	// RVA: 0x787A94
	public static string Serialize(object obj) { }

	// RVA: 0x788CB0
	private void SerializeValue(object value) { }

	// RVA: 0x789458
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x789110
	private void SerializeArray(IList array) { }

	// RVA: 0x788E54
	private void SerializeString(string str) { }

	// RVA: 0x7898DC
	private void SerializeOther(object value) { }

}

// Namespace: Facebook.MiniJSON
public static class Json
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x7878CC
	public static object Deserialize(string json) { }

	// RVA: 0x787A90
	public static string Serialize(object obj) { }

	// RVA: 0x787B68
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

	// RVA: 0x7899D0
	internal void .ctor(string tokenString, string userId, DateTime expirationTime, System.Collections.Generic.IEnumerable<System.String> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain) { }

	// RVA: 0x789BC0
	public static AccessToken get_CurrentAccessToken() { }

	// RVA: 0x789C0C
	internal static void set_CurrentAccessToken(AccessToken value) { }

	// RVA: 0x789C70
	public string get_TokenString() { }

	// RVA: 0x789C78
	private void set_TokenString(string value) { }

	// RVA: 0x789C80
	public DateTime get_ExpirationTime() { }

	// RVA: 0x789C88
	private void set_ExpirationTime(DateTime value) { }

	// RVA: 0x789C90
	public System.Collections.Generic.IEnumerable<System.String> get_Permissions() { }

	// RVA: 0x789C98
	private void set_Permissions(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x789CA0
	public string get_UserId() { }

	// RVA: 0x789CA8
	private void set_UserId(string value) { }

	// RVA: 0x789CB0
	public System.Nullable<System.DateTime> get_LastRefresh() { }

	// RVA: 0x789CBC
	private void set_LastRefresh(System.Nullable<System.DateTime> value) { }

	// RVA: 0x789CC4
	public string get_GraphDomain() { }

	// RVA: 0x789CCC
	private void set_GraphDomain(string value) { }

	// RVA: 0x789CD4
	public override string ToString() { }

	// RVA: 0x78A704
	internal string ToJson() { }

}

// Namespace: Facebook.Unity
internal class CallbackManager
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: 0x35258B4
	public string AddFacebookDelegate(Facebook.Unity.FacebookDelegate<T> callback) { }

	// RVA: 0x78A9AC
	public void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x78AC7C
	private static void CallCallback(object callback, IResult result) { }

	// RVA: 0x3527C54
	private static bool TryCallCallback(object callback, IResult result) { }

	// RVA: 0x78B400
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

	// RVA: 0x78B48C
	private static GameObject get_FacebookGameObject() { }

	// RVA: 0x26AD93C
	public static T GetComponent(IfNotExist ifNotExist) { }

	// RVA: 0x26AD93C
	public static T AddComponent() { }

}

// Namespace: Facebook.Unity
internal static class Constants
{
	// Fields
	private static System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform; // 0x0

	// Methods

	// RVA: 0x78B5B0
	public static Uri get_GraphUrl() { }

	// RVA: 0x78B8E0
	public static string get_GraphApiUserAgent() { }

	// RVA: 0x78BC84
	public static bool get_IsEditor() { }

	// RVA: 0x78BCF4
	public static bool get_IsWeb() { }

	// RVA: 0x78BE90
	public static string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x78BC0C
	public static string get_UnitySDKUserAgent() { }

	// RVA: 0x78C124
	public static bool get_DebugMode() { }

	// RVA: 0x78BD10
	public static FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x78C194
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

	// RVA: 0x78C224
	public System.Collections.Generic.IDictionary<System.String,System.String> toGraphAPIData() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText
{
	// Fields
	private string _default; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> _localizations; // 0x18

	// Methods

	// RVA: 0x78C3D4
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x78C4F4
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo
{
	// Fields
	private string _url; // 0x10

	// Methods

	// RVA: 0x78C6D8
	public string get_Url() { }

}

// Namespace: 
private sealed class OnDLLLoaded
{
	// Methods

	// RVA: 0x78DC20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x790F94
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class Mobile
{
	// Methods

	// RVA: 0x790FA8
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x791088
	public static void LoginWithTrackingPreference(LoginTracking loginTracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7911C8
	public static AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x791280
	public static Profile CurrentProfile() { }

	// RVA: 0x791338
	public static void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7913FC
	public static bool IsImplicitPurchaseLoggingEnabled() { }

}

// Namespace: 
internal abstract class CompiledFacebookLoader
{
	// Methods

	// RVA: -1
	protected abstract FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7914B4
	public void Start() { }

	// RVA: 0x7915F8
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

	// RVA: 0x78DC18
	public void .ctor() { }

	// RVA: 0x791600
	internal void <Init>b__0() { }

	// RVA: 0x791810
	internal void <Init>b__1() { }

	// RVA: 0x7918E8
	internal void <Init>b__2() { }

	// RVA: 0x791AB0
	internal void <Init>b__3() { }

	// RVA: 0x791BC0
	internal void <Init>b__4() { }

	// RVA: 0x791C80
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

	// RVA: 0x78C6E0
	public static string get_AppId() { }

	// RVA: 0x78C75C
	private static void set_AppId(string value) { }

	// RVA: 0x78C7C8
	public static string get_ClientToken() { }

	// RVA: 0x78C844
	private static void set_ClientToken(string value) { }

	// RVA: 0x78C8B0
	public static string get_GraphApiVersion() { }

	// RVA: 0x78C92C
	public static void set_GraphApiVersion(string value) { }

	// RVA: 0x78C998
	public static bool get_IsLoggedIn() { }

	// RVA: 0x78CAB4
	public static bool get_IsInitialized() { }

	// RVA: 0x78CBD8
	public static bool get_LimitAppEventUsage() { }

	// RVA: 0x78CCFC
	public static void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x78BB20
	internal static IFacebook get_FacebookImpl() { }

	// RVA: 0x78CE20
	internal static void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x78B79C
	internal static string get_FacebookDomain() { }

	// RVA: 0x78CE94
	internal static void set_FacebookDomain(string value) { }

	// RVA: 0x78CF00
	private static OnDLLLoaded get_OnDLLLoadedDelegate() { }

	// RVA: 0x78CF7C
	private static void set_OnDLLLoadedDelegate(OnDLLLoaded value) { }

	// RVA: 0x78CFE8
	public static void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x78D128
	public static void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x78DE00
	public static void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78DEF8
	public static void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x78DFF0
	public static void LogOut() { }

	// RVA: 0x78E0E0
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78E248
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78E3B8
	public static void AppRequest(string message, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x78E508
	public static void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78E628
	public static void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x78E774
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x78E8DC
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x78EA44
	public static void ActivateApp() { }

	// RVA: 0x78EB88
	public static void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x78EC80
	public static void ClearAppLink() { }

	// RVA: 0x78EC84
	public static void LogAppEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78ED8C
	public static void LogPurchase(Decimal logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78EE78
	public static void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x78EFA0
	private static void LogVersion() { }

	// RVA: 0x78F2D8
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x78F3C8
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x78F4B8
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x78F5C0
	public static void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x78F6B8
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x78F7A8
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x78F898
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x78F990
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x78FA88
	public static Profile CurrentProfile() { }

	// RVA: 0x78FB78
	public static void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x78FC68
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78FD60
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x78FE58
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x78FF50
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x790048
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x790138
	public static void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x790228
	public static void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x790320
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x790448
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x790540
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x790638
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x790728
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x790830
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x790978
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x790A88
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x790B98
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x790CB4
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x790DD4
	public static void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x790EC4
	public void .ctor() { }

	// RVA: 0x790ECC
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public sealed class FBGamingServices
{
	// Methods

	// RVA: 0x791D3C
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x791EE0
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x791FB8
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x792090
	public static void PerformCustomUpdate(CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x792128
	public static void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7921EC
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7922B0
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x792374
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x79243C
	public static void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7924FC
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7925C0
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x792684
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x792744
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x792804
	public static void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7928C8
	public static void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x79298C
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x792A7C
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x792B3C
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x792BFC
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x792CBC
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x792D7C
	public static void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x792E40
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x792F00
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x792FC4
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x79308C
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x793194
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x793254
	public static void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x793318
	public static void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7933D8
	public static void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x793498
	public static void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x793570
	public static void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x791E00
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x793634
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

	// RVA: 0x794BD0
	private static void .cctor() { }

	// RVA: 0x794C3C
	public void .ctor() { }

	// RVA: 0x794C44
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

	// RVA: 0x79363C
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract bool get_LimitEventUsage() { }

	// RVA: -1
	public abstract void set_LimitEventUsage(bool value) { }

	// RVA: -1
	public abstract string get_SDKName() { }

	// RVA: -1
	public abstract string get_SDKVersion() { }

	// RVA: 0x793670
	public virtual string get_SDKUserAgent() { }

	// RVA: 0x7936BC
	public virtual bool get_LoggedIn() { }

	// RVA: 0x793790
	public bool get_Initialized() { }

	// RVA: 0x793798
	public void set_Initialized(bool value) { }

	// RVA: 0x7937A0
	protected CallbackManager get_CallbackManager() { }

	// RVA: 0x7937A8
	private void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x7937B0
	public virtual void Init(InitDelegate onInitComplete) { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7937B8
	public virtual void LogOut() { }

	// RVA: -1
	public abstract void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: -1
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x793810
	public void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7942D4
	public void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void ActivateApp(string appId) { }

	// RVA: -1
	public abstract void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	public abstract void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x794514
	public virtual void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x794684
	public void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7946DC
	protected void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x794B24
	protected virtual void OnAuthResponse(LoginResult result) { }

	// RVA: 0x793BB4
	private System.Collections.Generic.IDictionary<System.String,System.String> CopyByValue(System.Collections.Generic.IDictionary<System.String,System.String> data) { }

	// RVA: 0x79420C
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

	// RVA: 0x794BAC
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x794BB0
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x794BB4
	private void <OnInitComplete>b__35_0(ILoginResult result) { }

}

// Namespace: Facebook.Unity
public sealed class InitDelegate
{
	// Methods

	// RVA: 0x794C50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x794CF0
	public virtual void Invoke() { }

}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T result) { }

}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate
{
	// Methods

	// RVA: 0x794D04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x794DA8
	public virtual void Invoke(bool isUnityShown) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject
{
	// Fields
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Methods

	// RVA: 0x794DBC
	public IFacebookImplementation get_Facebook() { }

	// RVA: 0x794DC4
	public void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x794DCC
	public void Awake() { }

	// RVA: 0x794EAC
	public void OnInitComplete(string message) { }

	// RVA: 0x795118
	public void OnLoginComplete(string message) { }

	// RVA: 0x7951F8
	public void OnLogoutComplete(string message) { }

	// RVA: 0x7952D8
	public void OnGetAppLinkComplete(string message) { }

	// RVA: 0x7953B8
	public void OnAppRequestsComplete(string message) { }

	// RVA: 0x795498
	public void OnShareLinkComplete(string message) { }

	// RVA: 0x795578
	protected virtual void OnAwake() { }

	// RVA: 0x79557C
	protected void .ctor() { }

}

// Namespace: Facebook.Unity
public class FacebookSdkVersion
{
	// Methods

	// RVA: 0x78BFB0
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

	// RVA: 0x795584
	public void .ctor() { }

	// RVA: 0x7956AC
	public void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x795600
	private void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> arguments) { }

	// RVA: 0x26AD93C
	public void AddPrimative(string argumentName, T value) { }

	// RVA: 0x26AD93C
	public void AddNullablePrimitive(string argumentName, System.Nullable<T> nullable) { }

	// RVA: 0x7956C8
	public void AddString(string argumentName, string value) { }

	// RVA: 0x7957A8
	public void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7958E4
	public void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

	// RVA: 0x35269D4
	public void AddList(string argumentName, System.Collections.Generic.IEnumerable<T> list) { }

	// RVA: 0x795E44
	public void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x795FAC
	public string ToJsonString() { }

	// RVA: 0x7959C4
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

	// RVA: 0x35269D4
	public void .ctor(FacebookBase facebookImpl, string methodName) { }

	// RVA: 0x3525804
	public string get_MethodName() { }

	// RVA: 0x35267E8
	private void set_MethodName(string value) { }

	// RVA: 0x3525804
	protected Facebook.Unity.FacebookDelegate<T> get_Callback() { }

	// RVA: 0x35267E8
	public void set_Callback(Facebook.Unity.FacebookDelegate<T> value) { }

	// RVA: 0x35267E8
	protected void set_FacebookImpl(FacebookBase value) { }

	// RVA: 0x35267E8
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

	// RVA: 0x796034
	internal void .ctor(string amount, string currency) { }

	// RVA: 0x796084
	public string get_Amount() { }

	// RVA: 0x79608C
	private void set_Amount(string value) { }

	// RVA: 0x796094
	public string get_Currency() { }

	// RVA: 0x79609C
	private void set_Currency(string value) { }

	// RVA: 0x7960A4
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

	// RVA: 0x7961B8
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode) { }

	// RVA: 0x79638C
	public string get_Title() { }

	// RVA: 0x796394
	private void set_Title(string value) { }

	// RVA: 0x79639C
	public string get_ProductID() { }

	// RVA: 0x7963A4
	private void set_ProductID(string value) { }

	// RVA: 0x7963AC
	public string get_Description() { }

	// RVA: 0x7963B4
	private void set_Description(string value) { }

	// RVA: 0x7963BC
	public string get_ImageURI() { }

	// RVA: 0x7963C4
	private void set_ImageURI(string value) { }

	// RVA: 0x7963CC
	public string get_Price() { }

	// RVA: 0x7963D4
	private void set_Price(string value) { }

	// RVA: 0x7963DC
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x7963E8
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x7963F0
	public string get_PriceCurrencyCode() { }

	// RVA: 0x7963F8
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x796400
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

	// RVA: 0x7966F0
	internal void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest) { }

	// RVA: 0x796D18
	public string get_DeveloperPayload() { }

	// RVA: 0x796D20
	private void set_DeveloperPayload(string value) { }

	// RVA: 0x796D28
	public bool get_IsConsumed() { }

	// RVA: 0x796D30
	public string get_PaymentActionType() { }

	// RVA: 0x796D38
	private void set_PaymentActionType(string value) { }

	// RVA: 0x796D40
	public string get_PaymentID() { }

	// RVA: 0x796D48
	private void set_PaymentID(string value) { }

	// RVA: 0x796D50
	public string get_ProductID() { }

	// RVA: 0x796D58
	private void set_ProductID(string value) { }

	// RVA: 0x796D60
	public string get_PurchasePlatform() { }

	// RVA: 0x796D68
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x796D70
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x796D78
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x796D80
	public DateTime get_PurchaseTime() { }

	// RVA: 0x796D88
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x796D90
	public string get_PurchaseToken() { }

	// RVA: 0x796D98
	private void set_PurchaseToken(string value) { }

	// RVA: 0x796DA0
	public string get_SignedRequest() { }

	// RVA: 0x796DA8
	private void set_SignedRequest(string value) { }

	// RVA: 0x796DB0
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

	// RVA: 0x7970FC
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	// RVA: 0x7972F0
	public string get_Title() { }

	// RVA: 0x7972F8
	private void set_Title(string value) { }

	// RVA: 0x797300
	public string get_ProductID() { }

	// RVA: 0x797308
	private void set_ProductID(string value) { }

	// RVA: 0x797310
	public string get_Description() { }

	// RVA: 0x797318
	private void set_Description(string value) { }

	// RVA: 0x797320
	public string get_ImageURI() { }

	// RVA: 0x797328
	private void set_ImageURI(string value) { }

	// RVA: 0x797330
	public string get_Price() { }

	// RVA: 0x797338
	private void set_Price(string value) { }

	// RVA: 0x797340
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x79734C
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x797354
	public string get_PriceCurrencyCode() { }

	// RVA: 0x79735C
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x797364
	public string get_SubscriptionTerm() { }

	// RVA: 0x79736C
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x797374
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

	// RVA: 0x79768C
	internal void .ctor(Int64 deactivationTime, bool isEntitlementActive, Int64 periodStartTime, Int64 periodEndTime, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	// RVA: 0x797FA4
	public DateTime get_DeactivationTime() { }

	// RVA: 0x797FAC
	private void set_DeactivationTime(DateTime value) { }

	// RVA: 0x797FB4
	public bool get_IsEntitlementActive() { }

	// RVA: 0x797FBC
	private void set_IsEntitlementActive(bool value) { }

	// RVA: 0x797FC4
	public DateTime get_PeriodStartTime() { }

	// RVA: 0x797FCC
	private void set_PeriodStartTime(DateTime value) { }

	// RVA: 0x797FD4
	public DateTime get_PeriodEndTime() { }

	// RVA: 0x797FDC
	private void set_PeriodEndTime(DateTime value) { }

	// RVA: 0x797FE4
	public string get_ProductID() { }

	// RVA: 0x797FEC
	private void set_ProductID(string value) { }

	// RVA: 0x797FF4
	public string get_PurchasePlatform() { }

	// RVA: 0x797FFC
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x798004
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x79800C
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x798014
	public DateTime get_PurchaseTime() { }

	// RVA: 0x79801C
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x798024
	public string get_PurchaseToken() { }

	// RVA: 0x79802C
	private void set_PurchaseToken(string value) { }

	// RVA: 0x798034
	public string get_SignedRequest() { }

	// RVA: 0x79803C
	private void set_SignedRequest(string value) { }

	// RVA: 0x798044
	public string get_Status() { }

	// RVA: 0x79804C
	private void set_Status(string value) { }

	// RVA: 0x798054
	public string get_SubscriptionTerm() { }

	// RVA: 0x79805C
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x798064
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult
{
	// Fields
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7983FC
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x798804
	public AccessToken get_AccessToken() { }

	// RVA: 0x79880C
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x798814
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

	// RVA: 0x798B14
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x798CD0
	public string get_Url() { }

	// RVA: 0x798CD8
	private void set_Url(string value) { }

	// RVA: 0x798CE0
	public string get_TargetUrl() { }

	// RVA: 0x798CE8
	private void set_TargetUrl(string value) { }

	// RVA: 0x798CF0
	public string get_Ref() { }

	// RVA: 0x798CF8
	private void set_Ref(string value) { }

	// RVA: 0x798D00
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_Extras() { }

	// RVA: 0x798D08
	private void set_Extras(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x798D10
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppRequestResult
{
	// Fields
	private string <RequestID>k__BackingField; // 0x50
	private System.Collections.Generic.IEnumerable<System.String> <To>k__BackingField; // 0x58

	// Methods

	// RVA: 0x798F4C
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x799414
	public string get_RequestID() { }

	// RVA: 0x79941C
	private void set_RequestID(string value) { }

	// RVA: 0x799424
	public System.Collections.Generic.IEnumerable<System.String> get_To() { }

	// RVA: 0x79942C
	private void set_To(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x799434
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7995D0
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x799DF0
	public System.Collections.Generic.IList<Facebook.Unity.Product> get_Products() { }

	// RVA: 0x799DF8
	private void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value) { }

	// RVA: 0x799E00
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

	// RVA: 0x79A1E8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult
{
	// Methods

	// RVA: 0x79A1EC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult
{
	// Methods

	// RVA: 0x79A1F0
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GraphResult
{
	// Fields
	private System.Collections.Generic.IList<System.Object> <ResultList>k__BackingField; // 0x50
	private Texture2D <Texture>k__BackingField; // 0x58

	// Methods

	// RVA: 0x79A1F4
	internal void .ctor(UnityWebRequestAsyncOperation result) { }

	// RVA: 0x79A4DC
	private void set_ResultList(System.Collections.Generic.IList<System.Object> value) { }

	// RVA: 0x79A4E4
	public Texture2D get_Texture() { }

	// RVA: 0x79A4EC
	private void set_Texture(Texture2D value) { }

	// RVA: 0x79A3BC
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

	// RVA: 0x79A4F4
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

	// RVA: 0x79A4F8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult
{
	// Methods

	// RVA: 0x79A4FC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class InterstitialAdResult
{
	// Methods

	// RVA: 0x79A500
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

	// RVA: 0x79A648
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79ABEC
	public AccessToken get_AccessToken() { }

	// RVA: 0x79ABF4
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x79ABFC
	public AuthenticationToken get_AuthenticationToken() { }

	// RVA: 0x79AC04
	private void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x79AC0C
	public override string ToString() { }

	// RVA: 0x79ADB8
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class LoginStatusResult
{
	// Fields
	public static readonly string FailedKey; // 0x0
	private bool <Failed>k__BackingField; // 0x60

	// Methods

	// RVA: 0x79AFB4
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79B184
	public bool get_Failed() { }

	// RVA: 0x79B18C
	private void set_Failed(bool value) { }

	// RVA: 0x79B194
	public override string ToString() { }

	// RVA: 0x79B2C4
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult
{
	// Methods

	// RVA: 0x79B33C
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class PayloadResult
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79B340
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79B5C4
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x79B5CC
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x79B5D4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PayResult
{
	// Methods

	// RVA: 0x79B618
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79B708
	public Int64 get_ErrorCode() { }

	// RVA: 0x79B7E4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchaseResult
{
	// Fields
	private Purchase <Purchase>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79B9AC
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79BF38
	public Purchase get_Purchase() { }

	// RVA: 0x79BF40
	private void set_Purchase(Purchase value) { }

	// RVA: 0x79BF48
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchasesResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79C040
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79C7D0
	public System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases() { }

	// RVA: 0x79C7D8
	private void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value) { }

	// RVA: 0x79C7E0
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

	// RVA: 0x79855C
	internal void .ctor(ResultContainer result) { }

	// RVA: 0x79A370
	internal void .ctor(ResultContainer result, string error, bool cancelled) { }

	// RVA: 0x79D28C
	public virtual string get_Error() { }

	// RVA: 0x79D294
	protected virtual void set_Error(string value) { }

	// RVA: 0x79D29C
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> get_ErrorDictionary() { }

	// RVA: 0x79D2A4
	protected virtual void set_ErrorDictionary(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x79D2AC
	public virtual System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x79D2B4
	protected virtual void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x79D2BC
	public virtual string get_RawResult() { }

	// RVA: 0x79D2C4
	protected virtual void set_RawResult(string value) { }

	// RVA: 0x79D2CC
	public virtual bool get_Cancelled() { }

	// RVA: 0x79D2D4
	protected virtual void set_Cancelled(bool value) { }

	// RVA: 0x79D2DC
	public virtual string get_CallbackId() { }

	// RVA: 0x79D2E4
	protected virtual void set_CallbackId(string value) { }

	// RVA: 0x79D2EC
	protected System.Nullable<System.Int64> get_CanvasErrorCode() { }

	// RVA: 0x79D2F8
	private void set_CanvasErrorCode(System.Nullable<System.Int64> value) { }

	// RVA: 0x798954
	public override string ToString() { }

	// RVA: 0x79D078
	protected void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x79CBC8
	private static string GetErrorValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x79CC64
	private static bool GetCancelledValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x79CFDC
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

	// RVA: 0x79D854
	public void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x794F88
	public void .ctor(string result) { }

	// RVA: 0x79DAC8
	public string get_RawResult() { }

	// RVA: 0x79DAD0
	private void set_RawResult(string value) { }

	// RVA: 0x79DAD8
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x79DAE0
	public void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x79D914
	private System.Collections.Generic.IDictionary<System.String,System.Object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

}

// Namespace: Facebook.Unity
internal class RewardedVideoResult
{
	// Methods

	// RVA: 0x79DAE8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult
{
	// Methods

	// RVA: 0x79DC30
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ShareResult
{
	// Fields
	private string <PostId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79DC34
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79DDE0
	public string get_PostId() { }

	// RVA: 0x79DDE8
	private void set_PostId(string value) { }

	// RVA: 0x79DD74
	internal static string get_PostIDKey() { }

	// RVA: 0x79DDF0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79DEE8
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79E708
	public System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> get_SubscribableProducts() { }

	// RVA: 0x79E710
	private void set_SubscribableProducts(System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> value) { }

	// RVA: 0x79E718
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionResult
{
	// Fields
	private Subscription <Subscription>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79EB00
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79F08C
	public Subscription get_Subscription() { }

	// RVA: 0x79F094
	private void set_Subscription(Subscription value) { }

	// RVA: 0x79F09C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionsResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Subscription> <Subscriptions>k__BackingField; // 0x50

	// Methods

	// RVA: 0x79F194
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x79F91C
	public System.Collections.Generic.IList<Facebook.Unity.Subscription> get_Subscriptions() { }

	// RVA: 0x79F924
	private void set_Subscriptions(System.Collections.Generic.IList<Facebook.Unity.Subscription> value) { }

	// RVA: 0x79F92C
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

	// RVA: 0x7A00B0
	public void .ctor(int <>1__state) { }

	// RVA: 0x7A00E4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7A00E8
	private bool MoveNext() { }

	// RVA: 0x7A0BD4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7A0BDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7A0C1C
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

	// RVA: 0x79FD14
	internal static void Post(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x79FE54
	internal static void Get(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x79FEF0
	internal static void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x79FDB4
	internal static void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7A0038
	internal IEnumerator Start() { }

	// RVA: 0x79FF90
	internal AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x79FFB8
	internal AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x7A0010
	internal AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x79FFC0
	internal AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x79FFE8
	internal AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7A00DC
	public void .ctor() { }

}

// Namespace: 
private class DebugLogger
{
	// Methods

	// RVA: 0x7A0CE0
	public void .ctor() { }

	// RVA: 0x7A0FA0
	public void Log(string msg) { }

	// RVA: 0x7A1060
	public void Info(string msg) { }

	// RVA: 0x7A10E8
	public void Warn(string msg) { }

}

// Namespace: Facebook.Unity
internal static class FacebookLogger
{
	// Fields
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x7A0C24
	private static void .cctor() { }

	// RVA: 0x7A0CE8
	private static IFacebookLogger get_Instance() { }

	// RVA: 0x7A0D64
	internal static void set_Instance(IFacebookLogger value) { }

	// RVA: 0x7A0DD8
	public static void Log(string msg) { }

	// RVA: 0x78F198
	public static void Info(string msg) { }

	// RVA: 0x78DCC0
	public static void Warn(string msg) { }

	// RVA: 0x7A0F14
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

	// RVA: 0x26AD93C
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

	// RVA: 0x7A3FD0
	private static void .cctor() { }

	// RVA: 0x7A403C
	public void .ctor() { }

	// RVA: 0x7A4044
	internal string <ParsePermissionFromResult>b__19_0(object permission) { }

}

// Namespace: Facebook.Unity
internal static class Utilities
{
	// Methods

	// RVA: 0x3527DAC
	public static bool TryGetValue(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, T value) { }

	// RVA: 0x789FB8
	public static Int64 TotalSeconds(DateTime dateTime) { }

	// RVA: 0x26AD93C
	public static T GetValueOrDefault(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, bool logWarning) { }

	// RVA: 0x78A0A4
	public static string ToCommaSeparateList(System.Collections.Generic.IEnumerable<System.String> list) { }

	// RVA: 0x7A1170
	public static string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x78BFF4
	public static string GetUserAgent(string productName, string productVersion) { }

	// RVA: 0x798ECC
	public static string ToJson(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x352CF50
	public static void AddAllKVPFrom(System.Collections.Generic.IDictionary<T1,T2> dest, System.Collections.Generic.IDictionary<T1,T2> source) { }

	// RVA: 0x79869C
	public static AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x79AAF4
	public static AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x78A138
	public static string ToStringNullOk(object obj) { }

	// RVA: 0x78A19C
	public static string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<System.String,System.String> propertiesAndValues) { }

	// RVA: 0x7A1234
	private static DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7A1748
	private static System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7A142C
	private static System.Collections.Generic.ICollection<System.String> ParsePermissionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7998D4
	public static System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7A198C
	public static Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x79E1EC
	public static System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> ParseSubscribableCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7A21B4
	public static SubscribableProduct ParseSubscribableProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x79C344
	public static System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x79BDA8
	public static Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x79F490
	public static System.Collections.Generic.IList<Facebook.Unity.Subscription> ParseSubscriptionsFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x79EEFC
	public static Subscription ParseSubscriptionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7A2B00
	public static Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> purchase, bool isWindows) { }

	// RVA: 0x7A3760
	public static Subscription ParseSubscriptionFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> subscription, bool isWindows) { }

	// RVA: 0x79D300
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x79B48C
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary, string key) { }

	// RVA: 0x796C70
	public static DateTime FromTimestamp(int timestamp) { }

}

// Namespace: Facebook.Unity
internal static class FBUnityUtility
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Methods

	// RVA: 0x794150
	public static IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper
{
	// Methods

	// RVA: 0x7A4074
	public void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7A4114
	public void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7A406C
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

	// RVA: 0x7A42C8
	public void .ctor(int <>1__state) { }

	// RVA: 0x7A42FC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7A4300
	private bool MoveNext() { }

	// RVA: 0x7A43DC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7A43E4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7A4424
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class FacebookScheduler
{
	// Methods

	// RVA: 0x7A41B4
	public void Schedule(Action action, Int64 delay) { }

	// RVA: 0x7A4248
	public IEnumerator DelayEvent(Action action, Int64 delay) { }

	// RVA: 0x7A42F4
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public interface IHasLicenseResult
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog
{
	// Methods

	// RVA: 0x7A442C
	internal static void handlePurchaseCompleted(object data) { }

	// RVA: 0x7A4B98
	internal static void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x7A4D70
	internal static void addListenerToGameObject(object gameObject, object listenerObject) { }

	// RVA: 0x7A5154
	private static Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x7A4CCC
	private static object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x7A52B0
	private static object GetField(object inObj, string fieldName) { }

	// RVA: 0x7A4B34
	private static object GetProperty(object inObj, string propertyName) { }

}

// Namespace: 
private sealed class <GenSnapshot>d__4
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Methods

	// RVA: 0x7A55DC
	public void .ctor(int <>1__state) { }

	// RVA: 0x7A6A78
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7A6A7C
	private bool MoveNext() { }

	// RVA: 0x7A6C74
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7A6C7C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7A6CBC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
public class CodelessCrawler
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x7A5310
	public void Awake() { }

	// RVA: 0x7A53C0
	public void CaptureViewHierarchy(string message) { }

	// RVA: 0x7A5580
	private IEnumerator GenSnapshot() { }

	// RVA: 0x7A5608
	private static void SendAndroid(string json) { }

	// RVA: 0x7A5814
	private static void SendIos(string json) { }

	// RVA: 0x7A5818
	private static string GenBase64Screenshot() { }

	// RVA: 0x7A5958
	private static string GenViewJson() { }

	// RVA: 0x7A5D44
	private static void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x7A6A18
	private void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x7A5528
	private static void updateMainCamera() { }

	// RVA: 0x7A6818
	private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x7A6910
	private static string getClasstypeBitmaskButton() { }

	// RVA: 0x7A6998
	private static string getVisibility(GameObject gameObj) { }

	// RVA: 0x7A6A70
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent
{
	// Fields
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x7A6CC4
	private FBSDKEventBindingManager get_eventBindingManager() { }

	// RVA: 0x7A6CCC
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x7A6CD4
	private void Awake() { }

	// RVA: 0x7A6CF8
	private static void SetLoggerInitAndroid() { }

	// RVA: 0x7A6E2C
	private static void SetLoggerInitIos() { }

	// RVA: 0x7A6E30
	public void OnReceiveMapping(string message) { }

	// RVA: 0x7A7218
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

	// RVA: 0x7A7220
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x7A7644
	public string get_className() { }

	// RVA: 0x7A764C
	public void set_className(string value) { }

	// RVA: 0x7A7654
	public void set_text(string value) { }

	// RVA: 0x7A765C
	public void set_hint(string value) { }

	// RVA: 0x7A7664
	public void set_desc(string value) { }

	// RVA: 0x7A766C
	public void set_tag(string value) { }

	// RVA: 0x7A7674
	public void set_index(Int64 value) { }

	// RVA: 0x7A767C
	public void set_section(Int64 value) { }

	// RVA: 0x7A7684
	public void set_row(Int64 value) { }

	// RVA: 0x7A768C
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

	// RVA: 0x7A7694
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x7A7B88
	public string get_eventName() { }

	// RVA: 0x7A7B90
	public void set_eventName(string value) { }

	// RVA: 0x7A7B98
	public string get_eventType() { }

	// RVA: 0x7A7BA0
	public void set_eventType(string value) { }

	// RVA: 0x7A7BA8
	public string get_appVersion() { }

	// RVA: 0x7A7BB0
	public void set_appVersion(string value) { }

	// RVA: 0x7A7BB8
	public System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path() { }

	// RVA: 0x7A7BC0
	public void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager
{
	// Fields
	private System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A7BC8
	public System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings() { }

	// RVA: 0x7A7BD0
	public void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value) { }

	// RVA: 0x7A6F38
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

	// RVA: 0x7A7BD8
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A7CD4
	public string get_MediaId() { }

	// RVA: 0x7A7CDC
	private void set_MediaId(string value) { }

	// RVA: 0x7A7CE4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface ISessionScoreResult
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult
{
	// Methods

	// RVA: 0x7A7DDC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public class AuthenticationToken
{
	// Fields
	private string <TokenString>k__BackingField; // 0x10
	private string <Nonce>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7A18B4
	internal void .ctor(string tokenString, string nonce) { }

	// RVA: 0x7A7DE0
	public string get_TokenString() { }

	// RVA: 0x7A7DE8
	private void set_TokenString(string value) { }

	// RVA: 0x7A7DF0
	public string get_Nonce() { }

	// RVA: 0x7A7DF8
	private void set_Nonce(string value) { }

	// RVA: 0x7A7E00
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

	// RVA: 0x7A7F14
	internal void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	// RVA: 0x7A8178
	public string get_UserID() { }

	// RVA: 0x7A8180
	private void set_UserID(string value) { }

	// RVA: 0x7A8188
	public string get_FirstName() { }

	// RVA: 0x7A8190
	private void set_FirstName(string value) { }

	// RVA: 0x7A8198
	public string get_MiddleName() { }

	// RVA: 0x7A81A0
	private void set_MiddleName(string value) { }

	// RVA: 0x7A81A8
	public string get_LastName() { }

	// RVA: 0x7A81B0
	private void set_LastName(string value) { }

	// RVA: 0x7A81B8
	public string get_Name() { }

	// RVA: 0x7A81C0
	private void set_Name(string value) { }

	// RVA: 0x7A81C8
	public string get_Email() { }

	// RVA: 0x7A81D0
	private void set_Email(string value) { }

	// RVA: 0x7A81D8
	public string get_ImageURL() { }

	// RVA: 0x7A81E0
	private void set_ImageURL(string value) { }

	// RVA: 0x7A81E8
	public string get_LinkURL() { }

	// RVA: 0x7A81F0
	private void set_LinkURL(string value) { }

	// RVA: 0x7A81F8
	public string[] get_FriendIDs() { }

	// RVA: 0x7A8200
	private void set_FriendIDs(string[] value) { }

	// RVA: 0x7A8208
	public System.Nullable<System.DateTime> get_Birthday() { }

	// RVA: 0x7A8214
	private void set_Birthday(System.Nullable<System.DateTime> value) { }

	// RVA: 0x7A821C
	public UserAgeRange get_AgeRange() { }

	// RVA: 0x7A8224
	private void set_AgeRange(UserAgeRange value) { }

	// RVA: 0x7A822C
	public FBLocation get_Hometown() { }

	// RVA: 0x7A8234
	private void set_Hometown(FBLocation value) { }

	// RVA: 0x7A823C
	public FBLocation get_Location() { }

	// RVA: 0x7A8244
	private void set_Location(FBLocation value) { }

	// RVA: 0x7A824C
	public string get_Gender() { }

	// RVA: 0x7A8254
	private void set_Gender(string value) { }

	// RVA: 0x7A825C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class UserAgeRange
{
	// Fields
	private Int64 <Min>k__BackingField; // 0x10
	private Int64 <Max>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7A8720
	internal void .ctor(Int64 min, Int64 max) { }

	// RVA: 0x7A8758
	public Int64 get_Min() { }

	// RVA: 0x7A8760
	private void set_Min(Int64 value) { }

	// RVA: 0x7A8768
	public Int64 get_Max() { }

	// RVA: 0x7A8770
	private void set_Max(Int64 value) { }

	// RVA: 0x7A8778
	internal static UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x7A8968
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class FBLocation
{
	// Fields
	private string <ID>k__BackingField; // 0x10
	private string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7A8AB0
	internal void .ctor(string id, string name) { }

	// RVA: 0x7A8B00
	public string get_ID() { }

	// RVA: 0x7A8B08
	private void set_ID(string value) { }

	// RVA: 0x7A8B10
	public string get_Name() { }

	// RVA: 0x7A8B18
	private void set_Name(string value) { }

	// RVA: 0x7A8B20
	internal static FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x7A8D08
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

	// RVA: 0x7A8E1C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9030
	public string get_TournamentId() { }

	// RVA: 0x7A9038
	private void set_TournamentId(string value) { }

	// RVA: 0x7A9040
	public string get_ContextId() { }

	// RVA: 0x7A9048
	private void set_ContextId(string value) { }

	// RVA: 0x7A9050
	public int get_EndTime() { }

	// RVA: 0x7A9058
	private void set_EndTime(int value) { }

	// RVA: 0x7A9060
	public string get_TournamentTitle() { }

	// RVA: 0x7A9068
	private void set_TournamentTitle(string value) { }

	// RVA: 0x7A9070
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x7A9078
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7A9080
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

	// RVA: 0x7A9658
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9B30
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

	// RVA: 0x7A9B38
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9B5C
	private void set_Success(bool value) { }

}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult
{
	// Methods

	// RVA: 0x7A9B64
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

	// RVA: 0x7A9B68
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9C2C
	public string get_ContextId() { }

	// RVA: 0x7A9C34
	private void set_ContextId(string value) { }

	// RVA: 0x7A9C3C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7A9D34
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9DF8
	public string get_ContextId() { }

	// RVA: 0x7A9E00
	private void set_ContextId(string value) { }

	// RVA: 0x7A9E08
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7A9F00
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7A9FC4
	public string get_ContextId() { }

	// RVA: 0x7A9FCC
	private void set_ContextId(string value) { }

	// RVA: 0x7A9FD4
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

	// RVA: 0x7AA0CC
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7AA190
	public string get_ContextId() { }

	// RVA: 0x7AA198
	private void set_ContextId(string value) { }

	// RVA: 0x7AA1A0
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

	// RVA: 0x7AA298
	public void .ctor() { }

	// RVA: 0x7AA450
	public void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7AA4A0
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7AA4A8
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7AA4B0
	public override string get_SDKName() { }

	// RVA: 0x7AA4F4
	public override string get_SDKVersion() { }

	// RVA: 0x79171C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7AA538
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7AA62C
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7AA720
	public override void LogOut() { }

	// RVA: 0x7AA7D8
	public override bool get_LoggedIn() { }

	// RVA: 0x7AA890
	public override void ActivateApp(string appId) { }

	// RVA: 0x7AA93C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7AACA0
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7AADE0
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7AAECC
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7AAFB8
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7AB0BC
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7AB1B0
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7AB1F0
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7AB230
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7AB270
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7AB2B0
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x7AB39C
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7AB490
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7AB584
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7AB678
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7AB76C
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7AB858
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7AB944
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7ABA38
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7ABB6C
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7ABC60
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7ABD54
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7ABE40
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7ABF44
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7AC084
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AC1A0
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AC2BC
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AC3EC
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AC51C
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7AA394
	private static IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x7AC608
	public void Tick() { }

	// RVA: 0x7AC6C0
	public void Deinit() { }

	// RVA: 0x7AC778
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7AC7B8
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AC7F8
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AC838
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7AC878
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7AC8B8
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7AC8F8
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AC938
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AC978
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

	// RVA: 0x7AC9B8
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7ACA70
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject
{
	// Methods

	// RVA: 0x7ACA78
	protected IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x7ACAF4
	protected override void OnAwake() { }

	// RVA: 0x7ACAF8
	public void Update() { }

	// RVA: 0x7ACC10
	public void OnDestroy() { }

	// RVA: 0x7ACD2C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	private bool <LimitEventUsage>k__BackingField; // 0x30

	// Methods

	// RVA: 0x7ACD34
	public void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x7ACD84
	public void .ctor() { }

	// RVA: 0x7ACF24
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7ACF2C
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7ACF34
	public override string get_SDKName() { }

	// RVA: 0x7ACF78
	public override string get_SDKVersion() { }

	// RVA: 0x7ACEDC
	private static IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x7ACFBC
	public override void Init(InitDelegate onInitComplete) { }

	// RVA: 0x7AD0D0
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7AD0E0
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7AD284
	public void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7AD428
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7AD544
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7AD67C
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7AD7B4
	public override void ActivateApp(string appId) { }

	// RVA: 0x7AD840
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7AD9A4
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7ADA30
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7ADABC
	public bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7ADAC4
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7ADACC
	public override Profile CurrentProfile() { }

	// RVA: 0x7ADAD4
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x7ADB14
	public void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7ADE34
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7ADEA8
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7ADF1C
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7ADF94
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE008
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE07C
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7ADDC0
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE0F0
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE164
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE1D8
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE24C
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE2C0
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE334
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE3A8
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE41C
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE490
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE504
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE578
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE5EC
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE660
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE6D4
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE748
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE7BC
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE830
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE8A4
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE918
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AE98C
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEA00
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEA74
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEAE8
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEB5C
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEBD0
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEC44
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AECB8
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AED2C
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x7AEDA0
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x7AEE18
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x7AEE90
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEF04
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEF78
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AEFEC
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AF060
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7AF0D4
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7AF20C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7AF24C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7AF28C
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AF424
	public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7AF5BC
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7AF5FC
	public void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7AF720
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7AF844
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7AF968
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7AFA8C
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7AFBB0
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7AFCD4
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7AFDF8
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7AFF1C
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7B0040
	public void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7B0164
	public void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7B0288
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7B03AC
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7B04D0
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7B05F4
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7B0718
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7B083C
	public void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x7B0960
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7B0A84
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7B0BA8
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7B0DA4
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7B0EC8
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7B10C4
	public void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x7B11E8
	public void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7B130C
	public void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7B1430
	public void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7B1554
	public void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7B1678
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x7B16B8
	public void OnUrlResponse(string message) { }

	// RVA: 0x7B16F8
	public void OnHideUnity(bool hidden) { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject
{
	// Methods

	// RVA: 0x7B589C
	protected override void OnAwake() { }

	// RVA: 0x7B58A4
	private void OnEnable() { }

	// RVA: 0x7B5954
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x7B595C
	private void OnDisable() { }

	// RVA: 0x7B5A0C
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x7B5A18
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader
{
	// Methods

	// RVA: 0x7B5A20
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7B5ABC
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

	// RVA: 0x7B5AC4
	protected Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback() { }

	// RVA: 0x7B5ACC
	public void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value) { }

	// RVA: 0x7B5AD4
	protected string get_CallbackID() { }

	// RVA: 0x7B5ADC
	public void set_CallbackID(string value) { }

	// RVA: -1
	protected abstract string get_DialogTitle() { }

	// RVA: 0x7B5AE4
	public void Start() { }

	// RVA: 0x7B5C10
	public void OnGUI() { }

	// RVA: -1
	protected abstract void DoGui() { }

	// RVA: -1
	protected abstract void SendSuccessResult() { }

	// RVA: 0x7B5D20
	protected virtual void SendCancelResult() { }

	// RVA: 0x7B5E8C
	protected virtual void SendErrorResult(string errorMessage) { }

	// RVA: 0x7B5FDC
	private void OnGUIDialog(int windowId) { }

	// RVA: 0x7B63FC
	protected void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x7B6404
	public void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x7B6438
	public void Init() { }

	// RVA: 0x7B6508
	public void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x7B6588
	public void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x7B6710
	public void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x7B67AC
	public void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x7B6674
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

	// RVA: 0x7B6848
	public string get_EmptyDialogTitle() { }

	// RVA: 0x7B6850
	public void set_EmptyDialogTitle(string value) { }

	// RVA: 0x7B6858
	protected override string get_DialogTitle() { }

	// RVA: 0x7B6860
	protected override void DoGui() { }

	// RVA: 0x7B6864
	protected override void SendSuccessResult() { }

	// RVA: 0x7B69C0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x7B6FD8
	public void .ctor() { }

	// RVA: 0x7B7020
	internal void <SendSuccessResult>b__0(IGraphResult graphResult) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1
{
	// Fields
	public string facebookID; // 0x10
	public Facebook.Unity.Editor.Dialogs.MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7B73B4
	public void .ctor() { }

	// RVA: 0x7B73BC
	internal void <SendSuccessResult>b__1(IGraphResult permResult) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog
{
	// Fields
	private string accessToken; // 0x48

	// Methods

	// RVA: 0x7B69C8
	protected override string get_DialogTitle() { }

	// RVA: 0x7B6A0C
	protected override void DoGui() { }

	// RVA: 0x7B6C6C
	protected override void SendSuccessResult() { }

	// RVA: 0x7B6FE0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog
{
	// Fields
	private string <SubTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x7B7DB0
	private string get_SubTitle() { }

	// RVA: 0x7B7DB8
	public void set_SubTitle(string value) { }

	// RVA: 0x7B7DC0
	protected override string get_DialogTitle() { }

	// RVA: 0x7B7E30
	protected override void DoGui() { }

	// RVA: 0x7B7E34
	protected override void SendSuccessResult() { }

	// RVA: 0x7B82E0
	protected override void SendCancelResult() { }

	// RVA: 0x7B8000
	private string GenerateFakePostID() { }

	// RVA: 0x7B8428
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

	// RVA: 0x7B8430
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7B8438
	public override Profile CurrentProfile() { }

	// RVA: 0x7B8478
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: -1
	public abstract bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7B84B8
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8534
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B85B0
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B862C
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B86A8
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8724
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B87F0
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7B8830
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7B8870
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7B88B0
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B892C
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B89A8
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8A24
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8AA0
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8B1C
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8B98
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8C14
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8C90
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8D0C
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8D88
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8E04
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8E80
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8EFC
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8F78
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B8FF4
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9070
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B90EC
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9168
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B91E4
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9260
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B92DC
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9358
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B93D4
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9450
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B94CC
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9548
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B95C4
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x7B9640
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x7B96BC
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x7B9738
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B97B4
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9830
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B98AC
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B9928
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7B99A4
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7B99E4
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7B9A24
	public virtual void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7B9A64
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7B9AA4
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7B9AE4
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7B9B24
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7B9B64
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7B9BA4
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7B9BE4
	public override void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7B9C24
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7B9C64
	public virtual void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7B9CA4
	public virtual void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7B9CE4
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7B9D24
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7B9D64
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7B9DA4
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7B9DE4
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7B9E24
	public virtual void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x7B9E64
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7B9EA4
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7B9EE4
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7B9F24
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7B9F64
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7B9FA4
	public virtual void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x7B9FE4
	public virtual void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7BA024
	public virtual void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7BA064
	public virtual void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7BA0A4
	public virtual void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject
{
	// Methods

	// RVA: 0x7BA0E4
	private IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x7BA160
	public void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x7BA2A8
	public void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x7BA3F4
	public void OnFriendFinderComplete(string message) { }

	// RVA: 0x7BA540
	public void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x7BA68C
	public void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x7BA7D8
	public void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x7BA924
	public void OnGetCatalogComplete(string message) { }

	// RVA: 0x7BAA70
	public void OnGetPurchasesComplete(string message) { }

	// RVA: 0x7BABBC
	public void OnPurchaseComplete(string message) { }

	// RVA: 0x7BAD08
	public void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x7BAE54
	public void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x7BAFA0
	public void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x7BB0EC
	public void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x7BB238
	public void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x7BB384
	public void OnInitCloudGameComplete(string message) { }

	// RVA: 0x7BB4D0
	public void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x7BB61C
	public void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x7BB768
	public void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x7BB8B4
	public void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x7BBA00
	public void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x7BBB4C
	public void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x7BBC98
	public void OnGetPayloadComplete(string message) { }

	// RVA: 0x7BBDE4
	public virtual void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x7BBF30
	public virtual void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x7BC07C
	public virtual void OnGetTournamentComplete(string message) { }

	// RVA: 0x7BC1C8
	public virtual void OnShareTournamentComplete(string message) { }

	// RVA: 0x7BC314
	public virtual void OnCreateTournamentComplete(string message) { }

	// RVA: 0x7BC460
	public virtual void OnGetTournamentsComplete(string message) { }

	// RVA: 0x7BC5AC
	public virtual void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x7BC6F8
	public virtual void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x7BC844
	public virtual void OnTournamentDialogCancel(string message) { }

	// RVA: 0x7BC990
	public virtual void OnTournamentDialogError(string message) { }

	// RVA: 0x7BCADC
	public void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x7BCC28
	public void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x7BCD74
	public void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x7BCEC0
	public void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x7BD00C
	public void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x7BD158
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

	// RVA: 0x7BF79C
	public void .ctor() { }

	// RVA: 0x7BF7E0
	public int get_NumEntries() { }

	// RVA: 0x7BF7E8
	public void set_NumEntries(int value) { }

	// RVA: 0x7BF7F0
	public string[] get_Keys() { }

	// RVA: 0x7BF7F8
	public void set_Keys(string[] value) { }

	// RVA: 0x7BF800
	public string[] get_Values() { }

	// RVA: 0x7BF808
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

	// RVA: 0x7BD160
	public void .ctor() { }

	// RVA: 0x7BD2A0
	public void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7BD2D8
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7BD2E0
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7BD39C
	public override string get_SDKName() { }

	// RVA: 0x7BD3E0
	public override string get_SDKVersion() { }

	// RVA: 0x7BD498
	public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7BD608
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7BD720
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7BD820
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7BD920
	public override void LogOut() { }

	// RVA: 0x7BD9E4
	public override bool get_LoggedIn() { }

	// RVA: 0x7BDAC0
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7BDB78
	public override Profile CurrentProfile() { }

	// RVA: 0x7BDC30
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7BE058
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7BE188
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7BE3BC
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7BEA2C
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7BEB20
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7BEB28
	public override void ActivateApp(string appId) { }

	// RVA: 0x7BEBE0
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7BECF8
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7BEE10
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7BEE50
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7BEE90
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7BEFB0
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7BF0D0
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7BF27C
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7BF394
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7BF4AC
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7BF608
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7BF75C
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7BD1E4
	private static IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x7BE5A8
	private static NativeDict MarshallDict(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x3525600
	private int AddCallback(Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject
{
	// Methods

	// RVA: 0x7BF810
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader
{
	// Methods

	// RVA: 0x7BF818
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7BF93C
	public void .ctor() { }

}

// Namespace: 
private class JavaMethodCall<T0>
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: 0x35269D4
	public void .ctor(AndroidFacebook androidImpl, string methodName) { }

	// RVA: 0x35267E8
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

	// RVA: 0x7C4614
	private static void .cctor() { }

	// RVA: 0x7C4680
	public void .ctor() { }

	// RVA: 0x7C4688
	internal string <CreateTournament>b__73_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7C4750
	internal object <CreateTournament>b__73_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7C481C
	internal string <ShareTournament>b__74_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7C48E4
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

	// RVA: 0x7BF944
	public void .ctor() { }

	// RVA: 0x7BFAA4
	public void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7BFAFC
	private void set_KeyHash(string value) { }

	// RVA: 0x7BFB04
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7BFB0C
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7BFCD0
	public override string get_SDKName() { }

	// RVA: 0x7BFD14
	public override string get_SDKVersion() { }

	// RVA: 0x7BFDF4
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7C005C
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7C011C
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7C024C
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7C037C
	public override void LogOut() { }

	// RVA: 0x7C0438
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7C074C
	public override Profile CurrentProfile() { }

	// RVA: 0x7C100C
	public void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x7C1088
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7C13D4
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7C1598
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7C17D8
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7C18A8
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7C1B58
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7C1D10
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7C1DF0
	public override void ActivateApp(string appId) { }

	// RVA: 0x7C1E48
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x7C1F18
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7C1FE8
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7C2028
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7C2068
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7C2228
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7C238C
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7C23CC
	public override void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x7C249C
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7C256C
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7C263C
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7C27A0
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7C28D0
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7C29A0
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7C2A70
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7C2BA0
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7C2CD0
	public override void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7C2DA0
	public override void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7C2E70
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7C307C
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7C31AC
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7C32DC
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7C340C
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7C353C
	public override void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x7C360C
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7C374C
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7C388C
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7C395C
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7C3D0C
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7C4018
	public override void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x7C40E8
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7C4218
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7C4348
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7C4514
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7BF9E8
	private static IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x7BFBA0
	private void CallFB(string method, string args) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject
{
	// Methods

	// RVA: 0x7C49B0
	protected override void OnAwake() { }

	// RVA: 0x7C49B8
	private void OnEnable() { }

	// RVA: 0x7C4A68
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x7C4A70
	private void OnDisable() { }

	// RVA: 0x7C4B20
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x7C4B2C
	public void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x7C4C20
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader
{
	// Methods

	// RVA: 0x7C4C28
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7C4CE0
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

	// RVA: 0x3526BA8
	public void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }

	// RVA: 0x35267E8
	public override void Call(MethodArguments args) { }

	// RVA: 0x3526BA8
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

	// RVA: 0x7C7A2C
	private static void .cctor() { }

	// RVA: 0x7C7A98
	public void .ctor() { }

	// RVA: 0x7C7AA0
	internal void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass47_0
{
	// Fields
	public ResultContainer result; // 0x10
	public Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x7C7328
	public void .ctor() { }

	// RVA: 0x7C7B50
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

	// RVA: 0x7C4CE8
	public void .ctor() { }

	// RVA: 0x7C4E28
	public void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7C4D6C
	private static ICanvasJSWrapper GetCanvasJSWrapper() { }

	// RVA: 0x7C4E60
	public override bool get_LimitEventUsage() { }

	// RVA: 0x7C4E68
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7C4E70
	public override string get_SDKName() { }

	// RVA: 0x7C4EB4
	public override string get_SDKVersion() { }

	// RVA: 0x7C4F68
	public override string get_SDKUserAgent() { }

	// RVA: 0x7C5218
	public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7C5648
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7C57B4
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7C5920
	public override void LogOut() { }

	// RVA: 0x7C59E4
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7C5D94
	public override void ActivateApp(string appId) { }

	// RVA: 0x7C5E4C
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7C6028
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7C6280
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7C63D0
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7C64F4
	public override void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7C6620
	public override void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x7C703C
	public override void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x7C707C
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x7C7190
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7C720C
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7C7288
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7C7304
	public void OnUrlResponse(string url) { }

	// RVA: 0x7C730C
	public void OnHideUnity(bool isGameShown) { }

	// RVA: 0x7C66B0
	private static void FormatAuthResponse(ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback) { }

	// RVA: 0x7C7330
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7C7370
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7C73B0
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7C73F0
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7C7430
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7C7470
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7C74B0
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7C74F0
	public override void CancelSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7C7530
	public override Profile CurrentProfile() { }

	// RVA: 0x7C7570
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x7C75B0
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7C75F0
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7C7630
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7C7670
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7C76B0
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7C76F0
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7C7730
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7C7770
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7C77B0
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7C77F0
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7C7830
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7C7870
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7C78B0
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7C78F0
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7C7930
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7C7970
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7C79B0
	private void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject
{
	// Methods

	// RVA: 0x7C8344
	protected ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x7C83C0
	public void OnPayComplete(string result) { }

	// RVA: 0x7C8508
	public void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x7C8654
	public void OnUrlResponse(string message) { }

	// RVA: 0x7C876C
	public void OnHideUnity(bool hide) { }

	// RVA: 0x7C8884
	protected override void OnAwake() { }

	// RVA: 0x7C895C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader
{
	// Methods

	// RVA: 0x7C8964
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7C8A88
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

	// RVA: 0x7C8A90
	public void Start() { }

	// RVA: 0x7C8AF4
	public void OnLoginComplete(string responseJsonData) { }

	// RVA: 0x7C8BAC
	public void OnFacebookAuthResponseChange(string responseJsonData) { }

	// RVA: 0x7C8C64
	public void OnPayComplete(string responseJsonData) { }

	// RVA: 0x7C8D18
	public void OnAppRequestsComplete(string responseJsonData) { }

	// RVA: 0x7C8DD0
	public void OnShareLinkComplete(string responseJsonData) { }

	// RVA: 0x7C8E88
	public void OnFacebookFocus(string state) { }

	// RVA: 0x7C8F68
	public void OnInitComplete(string responseJsonData) { }

	// RVA: 0x7C901C
	public void OnUrlResponse(string url) { }

	// RVA: 0x7C90D4
	public void .ctor() { }

}


