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

	// RVA: 0x743600
	private void .ctor(string jsonString) { }

	// RVA: 0x743680
	private Char get_PeekChar() { }

	// RVA: 0x74370C
	private Char get_NextChar() { }

	// RVA: 0x743798
	private string get_NextWord() { }

	// RVA: 0x743924
	private TOKEN get_NextToken() { }

	// RVA: 0x7432B4
	public static object Parse(string jsonString) { }

	// RVA: 0x743CE8
	public void Dispose() { }

	// RVA: 0x743D24
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x74434C
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x743CC0
	private object ParseValue() { }

	// RVA: 0x74445C
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x743EB0
	private string ParseString() { }

	// RVA: 0x744568
	private object ParseNumber() { }

	// RVA: 0x743BC8
	private void EatWhitespace() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x744674
	private void .ctor() { }

	// RVA: 0x743470
	public static string Serialize(object obj) { }

	// RVA: 0x7446EC
	private void SerializeValue(object value) { }

	// RVA: 0x744EC8
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x744B80
	private void SerializeArray(IList array) { }

	// RVA: 0x7448C4
	private void SerializeString(string str) { }

	// RVA: 0x74534C
	private void SerializeOther(object value) { }

}

// Namespace: Facebook.MiniJSON
public static class Json
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x7432A8
	public static object Deserialize(string json) { }

	// RVA: 0x74346C
	public static string Serialize(object obj) { }

	// RVA: 0x743544
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

	// RVA: 0x745538
	internal void .ctor(string tokenString, string userId, DateTime expirationTime, System.Collections.Generic.IEnumerable<System.String> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain) { }

	// RVA: 0x745728
	public static AccessToken get_CurrentAccessToken() { }

	// RVA: 0x745774
	internal static void set_CurrentAccessToken(AccessToken value) { }

	// RVA: 0x7457D8
	public string get_TokenString() { }

	// RVA: 0x7457E0
	private void set_TokenString(string value) { }

	// RVA: 0x7457E8
	public DateTime get_ExpirationTime() { }

	// RVA: 0x7457F0
	private void set_ExpirationTime(DateTime value) { }

	// RVA: 0x7457F8
	public System.Collections.Generic.IEnumerable<System.String> get_Permissions() { }

	// RVA: 0x745800
	private void set_Permissions(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x745808
	public string get_UserId() { }

	// RVA: 0x745810
	private void set_UserId(string value) { }

	// RVA: 0x745818
	public System.Nullable<System.DateTime> get_LastRefresh() { }

	// RVA: 0x745824
	private void set_LastRefresh(System.Nullable<System.DateTime> value) { }

	// RVA: 0x74582C
	public string get_GraphDomain() { }

	// RVA: 0x745834
	private void set_GraphDomain(string value) { }

	// RVA: 0x74583C
	public override string ToString() { }

	// RVA: 0x746284
	internal string ToJson() { }

}

// Namespace: Facebook.Unity
internal class CallbackManager
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: 0x30A188C
	public string AddFacebookDelegate(Facebook.Unity.FacebookDelegate<T> callback) { }

	// RVA: 0x74652C
	public void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x7467FC
	private static void CallCallback(object callback, IResult result) { }

	// RVA: 0x30A3C14
	private static bool TryCallCallback(object callback, IResult result) { }

	// RVA: 0x746F80
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

	// RVA: 0x74700C
	private static GameObject get_FacebookGameObject() { }

	// RVA: 0x315B3A8
	public static T GetComponent(IfNotExist ifNotExist) { }

	// RVA: 0x315B3A8
	public static T AddComponent() { }

}

// Namespace: Facebook.Unity
internal static class Constants
{
	// Fields
	private static System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform; // 0x0

	// Methods

	// RVA: 0x747130
	public static Uri get_GraphUrl() { }

	// RVA: 0x747460
	public static string get_GraphApiUserAgent() { }

	// RVA: 0x747804
	public static bool get_IsEditor() { }

	// RVA: 0x747874
	public static bool get_IsWeb() { }

	// RVA: 0x747A10
	public static string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x74778C
	public static string get_UnitySDKUserAgent() { }

	// RVA: 0x747CA4
	public static bool get_DebugMode() { }

	// RVA: 0x747890
	public static FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x747D14
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

	// RVA: 0x747DA4
	public System.Collections.Generic.IDictionary<System.String,System.String> toGraphAPIData() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText
{
	// Fields
	private string _default; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> _localizations; // 0x18

	// Methods

	// RVA: 0x747F54
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x748074
	public string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo
{
	// Fields
	private string _url; // 0x10

	// Methods

	// RVA: 0x748258
	public string get_Url() { }

}

// Namespace: 
private sealed class OnDLLLoaded
{
	// Methods

	// RVA: 0x7497A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x74CB14
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class Mobile
{
	// Methods

	// RVA: 0x74CB28
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x74CC08
	public static void LoginWithTrackingPreference(LoginTracking loginTracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x74CD48
	public static AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x74CE00
	public static Profile CurrentProfile() { }

	// RVA: 0x74CEB8
	public static void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x74CF7C
	public static bool IsImplicitPurchaseLoggingEnabled() { }

}

// Namespace: 
internal abstract class CompiledFacebookLoader
{
	// Methods

	// RVA: -1
	protected abstract FacebookGameObject get_FBGameObject() { }

	// RVA: 0x74D034
	public void Start() { }

	// RVA: 0x74D178
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

	// RVA: 0x749798
	public void .ctor() { }

	// RVA: 0x74D180
	internal void <Init>b__0() { }

	// RVA: 0x74D390
	internal void <Init>b__1() { }

	// RVA: 0x74D468
	internal void <Init>b__2() { }

	// RVA: 0x74D630
	internal void <Init>b__3() { }

	// RVA: 0x74D740
	internal void <Init>b__4() { }

	// RVA: 0x74D800
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

	// RVA: 0x748260
	public static string get_AppId() { }

	// RVA: 0x7482DC
	private static void set_AppId(string value) { }

	// RVA: 0x748348
	public static string get_ClientToken() { }

	// RVA: 0x7483C4
	private static void set_ClientToken(string value) { }

	// RVA: 0x748430
	public static string get_GraphApiVersion() { }

	// RVA: 0x7484AC
	public static void set_GraphApiVersion(string value) { }

	// RVA: 0x748518
	public static bool get_IsLoggedIn() { }

	// RVA: 0x748634
	public static bool get_IsInitialized() { }

	// RVA: 0x748758
	public static bool get_LimitAppEventUsage() { }

	// RVA: 0x74887C
	public static void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x7476A0
	internal static IFacebook get_FacebookImpl() { }

	// RVA: 0x7489A0
	internal static void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x74731C
	internal static string get_FacebookDomain() { }

	// RVA: 0x748A14
	internal static void set_FacebookDomain(string value) { }

	// RVA: 0x748A80
	private static OnDLLLoaded get_OnDLLLoadedDelegate() { }

	// RVA: 0x748AFC
	private static void set_OnDLLLoadedDelegate(OnDLLLoaded value) { }

	// RVA: 0x748B68
	public static void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x748CA8
	public static void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x749980
	public static void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x749A78
	public static void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x749B70
	public static void LogOut() { }

	// RVA: 0x749C60
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x749DC8
	public static void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x749F38
	public static void AppRequest(string message, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x74A088
	public static void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x74A1A8
	public static void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x74A2F4
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x74A45C
	public static void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x74A5C4
	public static void ActivateApp() { }

	// RVA: 0x74A708
	public static void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x74A800
	public static void ClearAppLink() { }

	// RVA: 0x74A804
	public static void LogAppEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x74A90C
	public static void LogPurchase(Decimal logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x74A9F8
	public static void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x74AB20
	private static void LogVersion() { }

	// RVA: 0x74AE58
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x74AF48
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x74B038
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x74B140
	public static void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x74B238
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x74B328
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x74B418
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x74B510
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x74B608
	public static Profile CurrentProfile() { }

	// RVA: 0x74B6F8
	public static void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x74B7E8
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x74B8E0
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x74B9D8
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x74BAD0
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x74BBC8
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x74BCB8
	public static void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x74BDA8
	public static void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x74BEA0
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x74BFC8
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x74C0C0
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x74C1B8
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x74C2A8
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x74C3B0
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x74C4F8
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74C608
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74C718
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74C834
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74C954
	public static void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x74CA44
	public void .ctor() { }

	// RVA: 0x74CA4C
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public sealed class FBGamingServices
{
	// Methods

	// RVA: 0x74D8BC
	public static void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x74DA60
	public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74DB38
	public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x74DC10
	public static void PerformCustomUpdate(CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x74DCA8
	public static void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x74DD6C
	public static void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x74DE30
	public static void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x74DEF4
	public static void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x74DFBC
	public static void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x74E07C
	public static void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x74E140
	public static void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x74E204
	public static void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x74E2C4
	public static void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x74E384
	public static void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x74E448
	public static void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x74E50C
	public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x74E5FC
	public static void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x74E6BC
	public static void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x74E77C
	public static void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x74E83C
	public static void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x74E8FC
	public static void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x74E9C0
	public static void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x74EA80
	public static void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x74EB44
	public static void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x74EC0C
	public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x74ED14
	public static void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x74EDD4
	public static void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x74EE98
	public static void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x74EF58
	public static void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x74F018
	public static void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x74F0F0
	public static void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x74D980
	private static IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x74F1B4
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

	// RVA: 0x750768
	private static void .cctor() { }

	// RVA: 0x7507D4
	public void .ctor() { }

	// RVA: 0x7507DC
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

	// RVA: 0x74F1BC
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract bool get_LimitEventUsage() { }

	// RVA: -1
	public abstract void set_LimitEventUsage(bool value) { }

	// RVA: -1
	public abstract string get_SDKName() { }

	// RVA: -1
	public abstract string get_SDKVersion() { }

	// RVA: 0x74F1F0
	public virtual string get_SDKUserAgent() { }

	// RVA: 0x74F23C
	public virtual bool get_LoggedIn() { }

	// RVA: 0x74F310
	public bool get_Initialized() { }

	// RVA: 0x74F318
	public void set_Initialized(bool value) { }

	// RVA: 0x74F320
	protected CallbackManager get_CallbackManager() { }

	// RVA: 0x74F328
	private void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x74F330
	public virtual void Init(InitDelegate onInitComplete) { }

	// RVA: -1
	public abstract void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x74F338
	public virtual void LogOut() { }

	// RVA: -1
	public abstract void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: -1
	public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x74F390
	public void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x74FE60
	public void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	public abstract void ActivateApp(string appId) { }

	// RVA: -1
	public abstract void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	public abstract void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	public abstract void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7500AC
	public virtual void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x75021C
	public void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: -1
	public abstract void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x750274
	protected void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7506BC
	protected virtual void OnAuthResponse(LoginResult result) { }

	// RVA: 0x74F740
	private System.Collections.Generic.IDictionary<System.String,System.String> CopyByValue(System.Collections.Generic.IDictionary<System.String,System.String> data) { }

	// RVA: 0x74FD98
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

	// RVA: 0x750744
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x750748
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	public abstract void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x75074C
	private void <OnInitComplete>b__35_0(ILoginResult result) { }

}

// Namespace: Facebook.Unity
public sealed class InitDelegate
{
	// Methods

	// RVA: 0x7507E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x750888
	public virtual void Invoke() { }

}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T result) { }

}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate
{
	// Methods

	// RVA: 0x75089C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x750940
	public virtual void Invoke(bool isUnityShown) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject
{
	// Fields
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Methods

	// RVA: 0x750954
	public IFacebookImplementation get_Facebook() { }

	// RVA: 0x75095C
	public void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x750964
	public void Awake() { }

	// RVA: 0x750A44
	public void OnInitComplete(string message) { }

	// RVA: 0x750CB0
	public void OnLoginComplete(string message) { }

	// RVA: 0x750D90
	public void OnLogoutComplete(string message) { }

	// RVA: 0x750E70
	public void OnGetAppLinkComplete(string message) { }

	// RVA: 0x750F50
	public void OnAppRequestsComplete(string message) { }

	// RVA: 0x751030
	public void OnShareLinkComplete(string message) { }

	// RVA: 0x751110
	protected virtual void OnAwake() { }

	// RVA: 0x751114
	protected void .ctor() { }

}

// Namespace: Facebook.Unity
public class FacebookSdkVersion
{
	// Methods

	// RVA: 0x747B30
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

	// RVA: 0x75111C
	public void .ctor() { }

	// RVA: 0x751244
	public void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x751198
	private void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> arguments) { }

	// RVA: 0x315B3A8
	public void AddPrimative(string argumentName, T value) { }

	// RVA: 0x315B3A8
	public void AddNullablePrimitive(string argumentName, System.Nullable<T> nullable) { }

	// RVA: 0x751260
	public void AddString(string argumentName, string value) { }

	// RVA: 0x751340
	public void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x751488
	public void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

	// RVA: 0x30A2A20
	public void AddList(string argumentName, System.Collections.Generic.IEnumerable<T> list) { }

	// RVA: 0x7519E8
	public void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x751B50
	public string ToJsonString() { }

	// RVA: 0x751568
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

	// RVA: 0x30A2A20
	public void .ctor(FacebookBase facebookImpl, string methodName) { }

	// RVA: 0x30A17DC
	public string get_MethodName() { }

	// RVA: 0x30A27C0
	private void set_MethodName(string value) { }

	// RVA: 0x30A17DC
	protected Facebook.Unity.FacebookDelegate<T> get_Callback() { }

	// RVA: 0x30A27C0
	public void set_Callback(Facebook.Unity.FacebookDelegate<T> value) { }

	// RVA: 0x30A27C0
	protected void set_FacebookImpl(FacebookBase value) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x751BD8
	internal void .ctor(string amount, string currency) { }

	// RVA: 0x751C28
	public string get_Amount() { }

	// RVA: 0x751C30
	private void set_Amount(string value) { }

	// RVA: 0x751C38
	public string get_Currency() { }

	// RVA: 0x751C40
	private void set_Currency(string value) { }

	// RVA: 0x751C48
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

	// RVA: 0x751D5C
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode) { }

	// RVA: 0x751F30
	public string get_Title() { }

	// RVA: 0x751F38
	private void set_Title(string value) { }

	// RVA: 0x751F40
	public string get_ProductID() { }

	// RVA: 0x751F48
	private void set_ProductID(string value) { }

	// RVA: 0x751F50
	public string get_Description() { }

	// RVA: 0x751F58
	private void set_Description(string value) { }

	// RVA: 0x751F60
	public string get_ImageURI() { }

	// RVA: 0x751F68
	private void set_ImageURI(string value) { }

	// RVA: 0x751F70
	public string get_Price() { }

	// RVA: 0x751F78
	private void set_Price(string value) { }

	// RVA: 0x751F80
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x751F8C
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x751F94
	public string get_PriceCurrencyCode() { }

	// RVA: 0x751F9C
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x751FA4
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

	// RVA: 0x752294
	internal void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest) { }

	// RVA: 0x7528BC
	public string get_DeveloperPayload() { }

	// RVA: 0x7528C4
	private void set_DeveloperPayload(string value) { }

	// RVA: 0x7528CC
	public bool get_IsConsumed() { }

	// RVA: 0x7528D4
	public string get_PaymentActionType() { }

	// RVA: 0x7528DC
	private void set_PaymentActionType(string value) { }

	// RVA: 0x7528E4
	public string get_PaymentID() { }

	// RVA: 0x7528EC
	private void set_PaymentID(string value) { }

	// RVA: 0x7528F4
	public string get_ProductID() { }

	// RVA: 0x7528FC
	private void set_ProductID(string value) { }

	// RVA: 0x752904
	public string get_PurchasePlatform() { }

	// RVA: 0x75290C
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x752914
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x75291C
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x752924
	public DateTime get_PurchaseTime() { }

	// RVA: 0x75292C
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x752934
	public string get_PurchaseToken() { }

	// RVA: 0x75293C
	private void set_PurchaseToken(string value) { }

	// RVA: 0x752944
	public string get_SignedRequest() { }

	// RVA: 0x75294C
	private void set_SignedRequest(string value) { }

	// RVA: 0x752954
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

	// RVA: 0x752CAC
	internal void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	// RVA: 0x752EA0
	public string get_Title() { }

	// RVA: 0x752EA8
	private void set_Title(string value) { }

	// RVA: 0x752EB0
	public string get_ProductID() { }

	// RVA: 0x752EB8
	private void set_ProductID(string value) { }

	// RVA: 0x752EC0
	public string get_Description() { }

	// RVA: 0x752EC8
	private void set_Description(string value) { }

	// RVA: 0x752ED0
	public string get_ImageURI() { }

	// RVA: 0x752ED8
	private void set_ImageURI(string value) { }

	// RVA: 0x752EE0
	public string get_Price() { }

	// RVA: 0x752EE8
	private void set_Price(string value) { }

	// RVA: 0x752EF0
	public System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x752EFC
	private void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x752F04
	public string get_PriceCurrencyCode() { }

	// RVA: 0x752F0C
	private void set_PriceCurrencyCode(string value) { }

	// RVA: 0x752F14
	public string get_SubscriptionTerm() { }

	// RVA: 0x752F1C
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x752F24
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

	// RVA: 0x75323C
	internal void .ctor(Int64 deactivationTime, bool isEntitlementActive, Int64 periodStartTime, Int64 periodEndTime, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	// RVA: 0x753B54
	public DateTime get_DeactivationTime() { }

	// RVA: 0x753B5C
	private void set_DeactivationTime(DateTime value) { }

	// RVA: 0x753B64
	public bool get_IsEntitlementActive() { }

	// RVA: 0x753B6C
	private void set_IsEntitlementActive(bool value) { }

	// RVA: 0x753B74
	public DateTime get_PeriodStartTime() { }

	// RVA: 0x753B7C
	private void set_PeriodStartTime(DateTime value) { }

	// RVA: 0x753B84
	public DateTime get_PeriodEndTime() { }

	// RVA: 0x753B8C
	private void set_PeriodEndTime(DateTime value) { }

	// RVA: 0x753B94
	public string get_ProductID() { }

	// RVA: 0x753B9C
	private void set_ProductID(string value) { }

	// RVA: 0x753BA4
	public string get_PurchasePlatform() { }

	// RVA: 0x753BAC
	private void set_PurchasePlatform(string value) { }

	// RVA: 0x753BB4
	public CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x753BBC
	private void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x753BC4
	public DateTime get_PurchaseTime() { }

	// RVA: 0x753BCC
	private void set_PurchaseTime(DateTime value) { }

	// RVA: 0x753BD4
	public string get_PurchaseToken() { }

	// RVA: 0x753BDC
	private void set_PurchaseToken(string value) { }

	// RVA: 0x753BE4
	public string get_SignedRequest() { }

	// RVA: 0x753BEC
	private void set_SignedRequest(string value) { }

	// RVA: 0x753BF4
	public string get_Status() { }

	// RVA: 0x753BFC
	private void set_Status(string value) { }

	// RVA: 0x753C04
	public string get_SubscriptionTerm() { }

	// RVA: 0x753C0C
	private void set_SubscriptionTerm(string value) { }

	// RVA: 0x753C14
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult
{
	// Fields
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Methods

	// RVA: 0x753FB8
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7543C0
	public AccessToken get_AccessToken() { }

	// RVA: 0x7543C8
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x7543D0
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

	// RVA: 0x7546DC
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x754898
	public string get_Url() { }

	// RVA: 0x7548A0
	private void set_Url(string value) { }

	// RVA: 0x7548A8
	public string get_TargetUrl() { }

	// RVA: 0x7548B0
	private void set_TargetUrl(string value) { }

	// RVA: 0x7548B8
	public string get_Ref() { }

	// RVA: 0x7548C0
	private void set_Ref(string value) { }

	// RVA: 0x7548C8
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_Extras() { }

	// RVA: 0x7548D0
	private void set_Extras(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x7548D8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppRequestResult
{
	// Fields
	private string <RequestID>k__BackingField; // 0x50
	private System.Collections.Generic.IEnumerable<System.String> <To>k__BackingField; // 0x58

	// Methods

	// RVA: 0x754B14
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x754FE8
	public string get_RequestID() { }

	// RVA: 0x754FF0
	private void set_RequestID(string value) { }

	// RVA: 0x754FF8
	public System.Collections.Generic.IEnumerable<System.String> get_To() { }

	// RVA: 0x755000
	private void set_To(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x755008
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7551B0
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7559DC
	public System.Collections.Generic.IList<Facebook.Unity.Product> get_Products() { }

	// RVA: 0x7559E4
	private void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value) { }

	// RVA: 0x7559EC
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

	// RVA: 0x755DD4
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult
{
	// Methods

	// RVA: 0x755DD8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult
{
	// Methods

	// RVA: 0x755DDC
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GraphResult
{
	// Fields
	private System.Collections.Generic.IList<System.Object> <ResultList>k__BackingField; // 0x50
	private Texture2D <Texture>k__BackingField; // 0x58

	// Methods

	// RVA: 0x755DE0
	internal void .ctor(UnityWebRequestAsyncOperation result) { }

	// RVA: 0x7560C8
	private void set_ResultList(System.Collections.Generic.IList<System.Object> value) { }

	// RVA: 0x7560D0
	public Texture2D get_Texture() { }

	// RVA: 0x7560D8
	private void set_Texture(Texture2D value) { }

	// RVA: 0x755FA8
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

	// RVA: 0x7560E0
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

	// RVA: 0x7560E4
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult
{
	// Methods

	// RVA: 0x7560E8
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class InterstitialAdResult
{
	// Methods

	// RVA: 0x7560EC
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

	// RVA: 0x756234
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7567D8
	public AccessToken get_AccessToken() { }

	// RVA: 0x7567E0
	private void set_AccessToken(AccessToken value) { }

	// RVA: 0x7567E8
	public AuthenticationToken get_AuthenticationToken() { }

	// RVA: 0x7567F0
	private void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x7567F8
	public override string ToString() { }

	// RVA: 0x7569A4
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class LoginStatusResult
{
	// Fields
	public static readonly string FailedKey; // 0x0
	private bool <Failed>k__BackingField; // 0x60

	// Methods

	// RVA: 0x756BA0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x756D70
	public bool get_Failed() { }

	// RVA: 0x756D78
	private void set_Failed(bool value) { }

	// RVA: 0x756D80
	public override string ToString() { }

	// RVA: 0x756EBC
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult
{
	// Methods

	// RVA: 0x756F34
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class PayloadResult
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x50

	// Methods

	// RVA: 0x756F38
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7571C8
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x7571D0
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7571D8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PayResult
{
	// Methods

	// RVA: 0x75721C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x75730C
	public Int64 get_ErrorCode() { }

	// RVA: 0x7573E8
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchaseResult
{
	// Fields
	private Purchase <Purchase>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7575B0
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x757B48
	public Purchase get_Purchase() { }

	// RVA: 0x757B50
	private void set_Purchase(Purchase value) { }

	// RVA: 0x757B58
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchasesResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField; // 0x50

	// Methods

	// RVA: 0x757C50
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7583EC
	public System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases() { }

	// RVA: 0x7583F4
	private void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value) { }

	// RVA: 0x7583FC
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

	// RVA: 0x754118
	internal void .ctor(ResultContainer result) { }

	// RVA: 0x755F5C
	internal void .ctor(ResultContainer result, string error, bool cancelled) { }

	// RVA: 0x758EB4
	public virtual string get_Error() { }

	// RVA: 0x758EBC
	protected virtual void set_Error(string value) { }

	// RVA: 0x758EC4
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> get_ErrorDictionary() { }

	// RVA: 0x758ECC
	protected virtual void set_ErrorDictionary(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x758ED4
	public virtual System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x758EDC
	protected virtual void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x758EE4
	public virtual string get_RawResult() { }

	// RVA: 0x758EEC
	protected virtual void set_RawResult(string value) { }

	// RVA: 0x758EF4
	public virtual bool get_Cancelled() { }

	// RVA: 0x758EFC
	protected virtual void set_Cancelled(bool value) { }

	// RVA: 0x758F04
	public virtual string get_CallbackId() { }

	// RVA: 0x758F0C
	protected virtual void set_CallbackId(string value) { }

	// RVA: 0x758F14
	protected System.Nullable<System.Int64> get_CanvasErrorCode() { }

	// RVA: 0x758F20
	private void set_CanvasErrorCode(System.Nullable<System.Int64> value) { }

	// RVA: 0x754510
	public override string ToString() { }

	// RVA: 0x758CA0
	protected void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x7587E4
	private static string GetErrorValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x758880
	private static bool GetCancelledValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x758C04
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

	// RVA: 0x75947C
	public void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x750B20
	public void .ctor(string result) { }

	// RVA: 0x7596F0
	public string get_RawResult() { }

	// RVA: 0x7596F8
	private void set_RawResult(string value) { }

	// RVA: 0x759700
	public System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x759708
	public void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x75953C
	private System.Collections.Generic.IDictionary<System.String,System.Object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

}

// Namespace: Facebook.Unity
internal class RewardedVideoResult
{
	// Methods

	// RVA: 0x759710
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult
{
	// Methods

	// RVA: 0x759858
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ShareResult
{
	// Fields
	private string <PostId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x75985C
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x759A08
	public string get_PostId() { }

	// RVA: 0x759A10
	private void set_PostId(string value) { }

	// RVA: 0x75999C
	internal static string get_PostIDKey() { }

	// RVA: 0x759A18
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Methods

	// RVA: 0x759B10
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x75A33C
	public System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> get_SubscribableProducts() { }

	// RVA: 0x75A344
	private void set_SubscribableProducts(System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> value) { }

	// RVA: 0x75A34C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionResult
{
	// Fields
	private Subscription <Subscription>k__BackingField; // 0x50

	// Methods

	// RVA: 0x75A734
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x75ACCC
	public Subscription get_Subscription() { }

	// RVA: 0x75ACD4
	private void set_Subscription(Subscription value) { }

	// RVA: 0x75ACDC
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionsResult
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Subscription> <Subscriptions>k__BackingField; // 0x50

	// Methods

	// RVA: 0x75ADD4
	public void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x75B568
	public System.Collections.Generic.IList<Facebook.Unity.Subscription> get_Subscriptions() { }

	// RVA: 0x75B570
	private void set_Subscriptions(System.Collections.Generic.IList<Facebook.Unity.Subscription> value) { }

	// RVA: 0x75B578
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

	// RVA: 0x75BCFC
	public void .ctor(int <>1__state) { }

	// RVA: 0x75BD30
	private void System.IDisposable.Dispose() { }

	// RVA: 0x75BD34
	private bool MoveNext() { }

	// RVA: 0x75C820
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x75C828
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x75C868
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

	// RVA: 0x75B960
	internal static void Post(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75BAA0
	internal static void Get(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75BB3C
	internal static void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75BA00
	internal static void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75BC84
	internal IEnumerator Start() { }

	// RVA: 0x75BBDC
	internal AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x75BC04
	internal AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x75BC5C
	internal AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x75BC0C
	internal AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x75BC34
	internal AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75BD28
	public void .ctor() { }

}

// Namespace: 
private class DebugLogger
{
	// Methods

	// RVA: 0x75C92C
	public void .ctor() { }

	// RVA: 0x75CBEC
	public void Log(string msg) { }

	// RVA: 0x75CCAC
	public void Info(string msg) { }

	// RVA: 0x75CD34
	public void Warn(string msg) { }

}

// Namespace: Facebook.Unity
internal static class FacebookLogger
{
	// Fields
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x75C870
	private static void .cctor() { }

	// RVA: 0x75C934
	private static IFacebookLogger get_Instance() { }

	// RVA: 0x75C9B0
	internal static void set_Instance(IFacebookLogger value) { }

	// RVA: 0x75CA24
	public static void Log(string msg) { }

	// RVA: 0x74AD18
	public static void Info(string msg) { }

	// RVA: 0x749840
	public static void Warn(string msg) { }

	// RVA: 0x75CB60
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

	// RVA: 0x315B3A8
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

	// RVA: 0x75FC28
	private static void .cctor() { }

	// RVA: 0x75FC94
	public void .ctor() { }

	// RVA: 0x75FC9C
	internal string <ParsePermissionFromResult>b__19_0(object permission) { }

}

// Namespace: Facebook.Unity
internal static class Utilities
{
	// Methods

	// RVA: 0x30A3D6C
	public static bool TryGetValue(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, T value) { }

	// RVA: 0x745B2C
	public static Int64 TotalSeconds(DateTime dateTime) { }

	// RVA: 0x315B3A8
	public static T GetValueOrDefault(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, bool logWarning) { }

	// RVA: 0x745C18
	public static string ToCommaSeparateList(System.Collections.Generic.IEnumerable<System.String> list) { }

	// RVA: 0x75CDBC
	public static string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x747B74
	public static string GetUserAgent(string productName, string productVersion) { }

	// RVA: 0x754A94
	public static string ToJson(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x30A8E44
	public static void AddAllKVPFrom(System.Collections.Generic.IDictionary<T1,T2> dest, System.Collections.Generic.IDictionary<T1,T2> source) { }

	// RVA: 0x754258
	public static AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7566E0
	public static AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x745CB8
	public static string ToStringNullOk(object obj) { }

	// RVA: 0x745D1C
	public static string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<System.String,System.String> propertiesAndValues) { }

	// RVA: 0x75CE8C
	private static DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75D3A0
	private static System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75D084
	private static System.Collections.Generic.ICollection<System.String> ParsePermissionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7554B4
	public static System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75D5E4
	public static Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x759E14
	public static System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> ParseSubscribableCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75DE0C
	public static SubscribableProduct ParseSubscribableProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x757F54
	public static System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7579AC
	public static Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75B0D0
	public static System.Collections.Generic.IList<Facebook.Unity.Subscription> ParseSubscriptionsFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75AB30
	public static Subscription ParseSubscriptionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x75E758
	public static Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> purchase, bool isWindows) { }

	// RVA: 0x75F3B8
	public static Subscription ParseSubscriptionFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> subscription, bool isWindows) { }

	// RVA: 0x758F28
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x757084
	public static System.Collections.Generic.IDictionary<System.String,System.String> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary, string key) { }

	// RVA: 0x752814
	public static DateTime FromTimestamp(int timestamp) { }

}

// Namespace: Facebook.Unity
internal static class FBUnityUtility
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Methods

	// RVA: 0x74FCDC
	public static IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper
{
	// Methods

	// RVA: 0x75FCCC
	public void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75FD6C
	public void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x75FCC4
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

	// RVA: 0x75FF20
	public void .ctor(int <>1__state) { }

	// RVA: 0x75FF54
	private void System.IDisposable.Dispose() { }

	// RVA: 0x75FF58
	private bool MoveNext() { }

	// RVA: 0x760034
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x76003C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x76007C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class FacebookScheduler
{
	// Methods

	// RVA: 0x75FE0C
	public void Schedule(Action action, Int64 delay) { }

	// RVA: 0x75FEA0
	public IEnumerator DelayEvent(Action action, Int64 delay) { }

	// RVA: 0x75FF4C
	public void .ctor() { }

}

// Namespace: Facebook.Unity
public interface IHasLicenseResult
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog
{
	// Methods

	// RVA: 0x760084
	internal static void handlePurchaseCompleted(object data) { }

	// RVA: 0x760804
	internal static void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x7609DC
	internal static void addListenerToGameObject(object gameObject, object listenerObject) { }

	// RVA: 0x760DCC
	private static Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x760938
	private static object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x760F28
	private static object GetField(object inObj, string fieldName) { }

	// RVA: 0x7607A0
	private static object GetProperty(object inObj, string propertyName) { }

}

// Namespace: 
private sealed class <GenSnapshot>d__4
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Methods

	// RVA: 0x761314
	public void .ctor(int <>1__state) { }

	// RVA: 0x762928
	private void System.IDisposable.Dispose() { }

	// RVA: 0x76292C
	private bool MoveNext() { }

	// RVA: 0x762B94
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x762B9C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x762BDC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
public class CodelessCrawler
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x760F88
	public void Awake() { }

	// RVA: 0x761038
	public void CaptureViewHierarchy(string message) { }

	// RVA: 0x7612B8
	private IEnumerator GenSnapshot() { }

	// RVA: 0x761340
	private static void SendAndroid(string json) { }

	// RVA: 0x76154C
	private static void SendIos(string json) { }

	// RVA: 0x761550
	private static string GenBase64Screenshot() { }

	// RVA: 0x761690
	private static string GenViewJson() { }

	// RVA: 0x761AC0
	private static void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x762838
	private void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x76121C
	private static void updateMainCamera() { }

	// RVA: 0x7625FC
	private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x762730
	private static string getClasstypeBitmaskButton() { }

	// RVA: 0x7627B8
	private static string getVisibility(GameObject gameObj) { }

	// RVA: 0x76291C
	public void .ctor() { }

	// RVA: 0x762924
	private static void .cctor() { }

}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent
{
	// Fields
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x762BE4
	private FBSDKEventBindingManager get_eventBindingManager() { }

	// RVA: 0x762BEC
	private void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x762BF4
	private void Awake() { }

	// RVA: 0x762C18
	private static void SetLoggerInitAndroid() { }

	// RVA: 0x762D60
	private static void SetLoggerInitIos() { }

	// RVA: 0x762D64
	public void OnReceiveMapping(string message) { }

	// RVA: 0x76314C
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

	// RVA: 0x763154
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x7635B0
	public string get_className() { }

	// RVA: 0x7635B8
	public void set_className(string value) { }

	// RVA: 0x7635C0
	public void set_text(string value) { }

	// RVA: 0x7635C8
	public void set_hint(string value) { }

	// RVA: 0x7635D0
	public void set_desc(string value) { }

	// RVA: 0x7635D8
	public void set_tag(string value) { }

	// RVA: 0x7635E0
	public void set_index(Int64 value) { }

	// RVA: 0x7635E8
	public void set_section(Int64 value) { }

	// RVA: 0x7635F0
	public void set_row(Int64 value) { }

	// RVA: 0x7635F8
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

	// RVA: 0x763600
	public void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x763B00
	public string get_eventName() { }

	// RVA: 0x763B08
	public void set_eventName(string value) { }

	// RVA: 0x763B10
	public string get_eventType() { }

	// RVA: 0x763B18
	public void set_eventType(string value) { }

	// RVA: 0x763B20
	public string get_appVersion() { }

	// RVA: 0x763B28
	public void set_appVersion(string value) { }

	// RVA: 0x763B30
	public System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path() { }

	// RVA: 0x763B38
	public void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager
{
	// Fields
	private System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Methods

	// RVA: 0x763B40
	public System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings() { }

	// RVA: 0x763B48
	public void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value) { }

	// RVA: 0x762E6C
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

	// RVA: 0x763B50
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x763C4C
	public string get_MediaId() { }

	// RVA: 0x763C54
	private void set_MediaId(string value) { }

	// RVA: 0x763C5C
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public interface ISessionScoreResult
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult
{
	// Methods

	// RVA: 0x763D54
	internal void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public class AuthenticationToken
{
	// Fields
	private string <TokenString>k__BackingField; // 0x10
	private string <Nonce>k__BackingField; // 0x18

	// Methods

	// RVA: 0x75D50C
	internal void .ctor(string tokenString, string nonce) { }

	// RVA: 0x763D58
	public string get_TokenString() { }

	// RVA: 0x763D60
	private void set_TokenString(string value) { }

	// RVA: 0x763D68
	public string get_Nonce() { }

	// RVA: 0x763D70
	private void set_Nonce(string value) { }

	// RVA: 0x763D78
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

	// RVA: 0x763E8C
	internal void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	// RVA: 0x7640F0
	public string get_UserID() { }

	// RVA: 0x7640F8
	private void set_UserID(string value) { }

	// RVA: 0x764100
	public string get_FirstName() { }

	// RVA: 0x764108
	private void set_FirstName(string value) { }

	// RVA: 0x764110
	public string get_MiddleName() { }

	// RVA: 0x764118
	private void set_MiddleName(string value) { }

	// RVA: 0x764120
	public string get_LastName() { }

	// RVA: 0x764128
	private void set_LastName(string value) { }

	// RVA: 0x764130
	public string get_Name() { }

	// RVA: 0x764138
	private void set_Name(string value) { }

	// RVA: 0x764140
	public string get_Email() { }

	// RVA: 0x764148
	private void set_Email(string value) { }

	// RVA: 0x764150
	public string get_ImageURL() { }

	// RVA: 0x764158
	private void set_ImageURL(string value) { }

	// RVA: 0x764160
	public string get_LinkURL() { }

	// RVA: 0x764168
	private void set_LinkURL(string value) { }

	// RVA: 0x764170
	public string[] get_FriendIDs() { }

	// RVA: 0x764178
	private void set_FriendIDs(string[] value) { }

	// RVA: 0x764180
	public System.Nullable<System.DateTime> get_Birthday() { }

	// RVA: 0x76418C
	private void set_Birthday(System.Nullable<System.DateTime> value) { }

	// RVA: 0x764194
	public UserAgeRange get_AgeRange() { }

	// RVA: 0x76419C
	private void set_AgeRange(UserAgeRange value) { }

	// RVA: 0x7641A4
	public FBLocation get_Hometown() { }

	// RVA: 0x7641AC
	private void set_Hometown(FBLocation value) { }

	// RVA: 0x7641B4
	public FBLocation get_Location() { }

	// RVA: 0x7641BC
	private void set_Location(FBLocation value) { }

	// RVA: 0x7641C4
	public string get_Gender() { }

	// RVA: 0x7641CC
	private void set_Gender(string value) { }

	// RVA: 0x7641D4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class UserAgeRange
{
	// Fields
	private Int64 <Min>k__BackingField; // 0x10
	private Int64 <Max>k__BackingField; // 0x18

	// Methods

	// RVA: 0x764698
	internal void .ctor(Int64 min, Int64 max) { }

	// RVA: 0x7646D0
	public Int64 get_Min() { }

	// RVA: 0x7646D8
	private void set_Min(Int64 value) { }

	// RVA: 0x7646E0
	public Int64 get_Max() { }

	// RVA: 0x7646E8
	private void set_Max(Int64 value) { }

	// RVA: 0x7646F0
	internal static UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x7648E0
	public override string ToString() { }

}

// Namespace: Facebook.Unity
public class FBLocation
{
	// Fields
	private string <ID>k__BackingField; // 0x10
	private string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x764A28
	internal void .ctor(string id, string name) { }

	// RVA: 0x764A78
	public string get_ID() { }

	// RVA: 0x764A80
	private void set_ID(string value) { }

	// RVA: 0x764A88
	public string get_Name() { }

	// RVA: 0x764A90
	private void set_Name(string value) { }

	// RVA: 0x764A98
	internal static FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x764C80
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

	// RVA: 0x764D94
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x764FA8
	public string get_TournamentId() { }

	// RVA: 0x764FB0
	private void set_TournamentId(string value) { }

	// RVA: 0x764FB8
	public string get_ContextId() { }

	// RVA: 0x764FC0
	private void set_ContextId(string value) { }

	// RVA: 0x764FC8
	public int get_EndTime() { }

	// RVA: 0x764FD0
	private void set_EndTime(int value) { }

	// RVA: 0x764FD8
	public string get_TournamentTitle() { }

	// RVA: 0x764FE0
	private void set_TournamentTitle(string value) { }

	// RVA: 0x764FE8
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x764FF0
	private void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x764FF8
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

	// RVA: 0x7655D0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765AA8
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

	// RVA: 0x765AB0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765AD4
	private void set_Success(bool value) { }

}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult
{
	// Methods

	// RVA: 0x765ADC
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

	// RVA: 0x765AE0
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765BA4
	public string get_ContextId() { }

	// RVA: 0x765BAC
	private void set_ContextId(string value) { }

	// RVA: 0x765BB4
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x765CAC
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765D70
	public string get_ContextId() { }

	// RVA: 0x765D78
	private void set_ContextId(string value) { }

	// RVA: 0x765D80
	public override string ToString() { }

}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x765E78
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x765F3C
	public string get_ContextId() { }

	// RVA: 0x765F44
	private void set_ContextId(string value) { }

	// RVA: 0x765F4C
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

	// RVA: 0x766044
	internal void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x766108
	public string get_ContextId() { }

	// RVA: 0x766110
	private void set_ContextId(string value) { }

	// RVA: 0x766118
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

	// RVA: 0x766210
	public void .ctor() { }

	// RVA: 0x7663C8
	public void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	// RVA: 0x766418
	public override bool get_LimitEventUsage() { }

	// RVA: 0x766420
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x766428
	public override string get_SDKName() { }

	// RVA: 0x76646C
	public override string get_SDKVersion() { }

	// RVA: 0x74D29C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7664B0
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7665A4
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x766698
	public override void LogOut() { }

	// RVA: 0x766750
	public override bool get_LoggedIn() { }

	// RVA: 0x766808
	public override void ActivateApp(string appId) { }

	// RVA: 0x7668B4
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x766C24
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x766D64
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x766E50
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x766F3C
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x767040
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x767134
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x767174
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7671B4
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7671F4
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x767234
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x767320
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x767414
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x767508
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7675FC
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x7676F0
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7677DC
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7678C8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7679BC
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x767AF0
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x767BE4
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x767CD8
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x767DC4
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x767EC8
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x768008
	public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x768124
	public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x768240
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x768370
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7684A0
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x76630C
	private static IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x76858C
	public void Tick() { }

	// RVA: 0x768644
	public void Deinit() { }

	// RVA: 0x7686FC
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76873C
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x76877C
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7687BC
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7687FC
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76883C
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x76887C
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7688BC
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7688FC
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

	// RVA: 0x76893C
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7689F4
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject
{
	// Methods

	// RVA: 0x7689FC
	protected IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x768A78
	protected override void OnAwake() { }

	// RVA: 0x768A7C
	public void Update() { }

	// RVA: 0x768B94
	public void OnDestroy() { }

	// RVA: 0x768CB0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	private bool <LimitEventUsage>k__BackingField; // 0x30

	// Methods

	// RVA: 0x768CB8
	public void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x768D08
	public void .ctor() { }

	// RVA: 0x768EA8
	public override bool get_LimitEventUsage() { }

	// RVA: 0x768EB0
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x768EB8
	public override string get_SDKName() { }

	// RVA: 0x768EFC
	public override string get_SDKVersion() { }

	// RVA: 0x768E60
	private static IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x768F40
	public override void Init(InitDelegate onInitComplete) { }

	// RVA: 0x769054
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x769064
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x769214
	public void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7693C4
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7694E0
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x769618
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x769750
	public override void ActivateApp(string appId) { }

	// RVA: 0x7697DC
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x769940
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7699CC
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x769A58
	public bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x769A60
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x769A68
	public override Profile CurrentProfile() { }

	// RVA: 0x769A70
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x769AB0
	public void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x769DD0
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x769E44
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x769EB8
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x769F30
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x769FA4
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A018
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x769D5C
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A08C
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A100
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A174
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A1E8
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A25C
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A2D0
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A344
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A3B8
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A42C
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A4A0
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A514
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A588
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A5FC
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A670
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A6E4
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A758
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A7CC
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A840
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A8B4
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A928
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x76A99C
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AA10
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AA84
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AAF8
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AB6C
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x76ABE0
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AC54
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x76ACC8
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x76AD3C
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x76ADB4
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x76AE2C
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AEA0
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AF14
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AF88
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x76AFFC
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x76B070
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x76B1A8
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x76B1E8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x76B228
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x76B3C0
	public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x76B558
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x76B598
	public void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x76B6BC
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x76B7E0
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x76B904
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x76BA28
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x76BB4C
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x76BC70
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x76BD94
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x76BEB8
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x76BFDC
	public void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x76C100
	public void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x76C224
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x76C348
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x76C46C
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x76C590
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x76C6B4
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x76C7D8
	public void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x76C8FC
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x76CA20
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x76CB44
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x76CD40
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x76CE64
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x76D060
	public void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x76D184
	public void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x76D2A8
	public void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x76D3CC
	public void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x76D4F0
	public void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x76D614
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x76D654
	public void OnUrlResponse(string message) { }

	// RVA: 0x76D694
	public void OnHideUnity(bool hidden) { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject
{
	// Methods

	// RVA: 0x771844
	protected override void OnAwake() { }

	// RVA: 0x77184C
	private void OnEnable() { }

	// RVA: 0x7718FC
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x771904
	private void OnDisable() { }

	// RVA: 0x7719B4
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x7719C0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader
{
	// Methods

	// RVA: 0x7719C8
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x771A64
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

	// RVA: 0x771A6C
	protected Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback() { }

	// RVA: 0x771A74
	public void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value) { }

	// RVA: 0x771A7C
	protected string get_CallbackID() { }

	// RVA: 0x771A84
	public void set_CallbackID(string value) { }

	// RVA: -1
	protected abstract string get_DialogTitle() { }

	// RVA: 0x771A8C
	public void Start() { }

	// RVA: 0x771BB8
	public void OnGUI() { }

	// RVA: -1
	protected abstract void DoGui() { }

	// RVA: -1
	protected abstract void SendSuccessResult() { }

	// RVA: 0x771CC8
	protected virtual void SendCancelResult() { }

	// RVA: 0x771E48
	protected virtual void SendErrorResult(string errorMessage) { }

	// RVA: 0x771F98
	private void OnGUIDialog(int windowId) { }

	// RVA: 0x7723B8
	protected void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x7723C0
	public void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x7723F4
	public void Init() { }

	// RVA: 0x7724D0
	public void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x772550
	public void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x7726D8
	public void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x772774
	public void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x77263C
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

	// RVA: 0x772810
	public string get_EmptyDialogTitle() { }

	// RVA: 0x772818
	public void set_EmptyDialogTitle(string value) { }

	// RVA: 0x772820
	protected override string get_DialogTitle() { }

	// RVA: 0x772828
	protected override void DoGui() { }

	// RVA: 0x77282C
	protected override void SendSuccessResult() { }

	// RVA: 0x77299C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x772FB4
	public void .ctor() { }

	// RVA: 0x773028
	internal void <SendSuccessResult>b__0(IGraphResult graphResult) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1
{
	// Fields
	public string facebookID; // 0x10
	public Facebook.Unity.Editor.Dialogs.MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7733C8
	public void .ctor() { }

	// RVA: 0x7733D0
	internal void <SendSuccessResult>b__1(IGraphResult permResult) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog
{
	// Fields
	private string accessToken; // 0x48

	// Methods

	// RVA: 0x7729A4
	protected override string get_DialogTitle() { }

	// RVA: 0x7729E8
	protected override void DoGui() { }

	// RVA: 0x772C48
	protected override void SendSuccessResult() { }

	// RVA: 0x772FBC
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog
{
	// Fields
	private string <SubTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x773DD0
	private string get_SubTitle() { }

	// RVA: 0x773DD8
	public void set_SubTitle(string value) { }

	// RVA: 0x773DE0
	protected override string get_DialogTitle() { }

	// RVA: 0x773E50
	protected override void DoGui() { }

	// RVA: 0x773E54
	protected override void SendSuccessResult() { }

	// RVA: 0x77430C
	protected override void SendCancelResult() { }

	// RVA: 0x77402C
	private string GenerateFakePostID() { }

	// RVA: 0x774454
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

	// RVA: 0x77445C
	protected void .ctor(CallbackManager callbackManager) { }

	// RVA: -1
	public abstract AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x774464
	public override Profile CurrentProfile() { }

	// RVA: 0x7744A4
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: -1
	public abstract void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: -1
	public abstract void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: -1
	public abstract bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7744E4
	public override void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x774560
	public override void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7745DC
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x774658
	public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7746D4
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x774750
	public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x77481C
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x77485C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77489C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7748DC
	public void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x774958
	public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x7749D4
	public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x774A50
	public void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x774ACC
	public void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x774B48
	public void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x774BC4
	public void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x774C40
	public void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x774CBC
	public void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x774D38
	public void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x774DB4
	public void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x774E30
	public void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x774EAC
	public void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x774F28
	public void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x774FA4
	public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x775020
	public void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x77509C
	public void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x775118
	public void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x775194
	public void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x775210
	public void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x77528C
	public void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x775308
	public void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x775384
	public void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x775400
	public void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x77547C
	public void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7754F8
	public void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x775574
	public void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x7755F0
	public void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x77566C
	public void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x7756E8
	public void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x775764
	public void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7757E0
	public void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x77585C
	public void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7758D8
	public void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x775954
	public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7759D0
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x775A10
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x775A50
	public virtual void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x775A90
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x775AD0
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x775B10
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x775B50
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x775B90
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x775BD0
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x775C10
	public override void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x775C50
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x775C90
	public virtual void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x775CD0
	public virtual void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x775D10
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x775D50
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x775D90
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x775DD0
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x775E10
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x775E50
	public virtual void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x775E90
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x775ED0
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x775F10
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x775F50
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x775F90
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x775FD0
	public virtual void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x776010
	public virtual void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x776050
	public virtual void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x776090
	public virtual void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7760D0
	public virtual void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject
{
	// Methods

	// RVA: 0x776110
	private IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x77618C
	public void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x7762D4
	public void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x776420
	public void OnFriendFinderComplete(string message) { }

	// RVA: 0x77656C
	public void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x7766B8
	public void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x776804
	public void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x776950
	public void OnGetCatalogComplete(string message) { }

	// RVA: 0x776A9C
	public void OnGetPurchasesComplete(string message) { }

	// RVA: 0x776BE8
	public void OnPurchaseComplete(string message) { }

	// RVA: 0x776D34
	public void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x776E80
	public void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x776FCC
	public void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x777118
	public void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x777264
	public void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x7773B0
	public void OnInitCloudGameComplete(string message) { }

	// RVA: 0x7774FC
	public void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x777648
	public void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x777794
	public void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x7778E0
	public void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x777A2C
	public void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x777B78
	public void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x777CC4
	public void OnGetPayloadComplete(string message) { }

	// RVA: 0x777E10
	public virtual void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x777F5C
	public virtual void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x7780A8
	public virtual void OnGetTournamentComplete(string message) { }

	// RVA: 0x7781F4
	public virtual void OnShareTournamentComplete(string message) { }

	// RVA: 0x778340
	public virtual void OnCreateTournamentComplete(string message) { }

	// RVA: 0x77848C
	public virtual void OnGetTournamentsComplete(string message) { }

	// RVA: 0x7785D8
	public virtual void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x778724
	public virtual void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x778870
	public virtual void OnTournamentDialogCancel(string message) { }

	// RVA: 0x7789BC
	public virtual void OnTournamentDialogError(string message) { }

	// RVA: 0x778B08
	public void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x778C54
	public void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x778DA0
	public void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x778EEC
	public void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x779038
	public void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x779184
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

	// RVA: 0x77B7B8
	public void .ctor() { }

	// RVA: 0x77B7FC
	public int get_NumEntries() { }

	// RVA: 0x77B804
	public void set_NumEntries(int value) { }

	// RVA: 0x77B80C
	public string[] get_Keys() { }

	// RVA: 0x77B814
	public void set_Keys(string[] value) { }

	// RVA: 0x77B81C
	public string[] get_Values() { }

	// RVA: 0x77B824
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

	// RVA: 0x77918C
	public void .ctor() { }

	// RVA: 0x7792CC
	public void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x779304
	public override bool get_LimitEventUsage() { }

	// RVA: 0x77930C
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x7793C8
	public override string get_SDKName() { }

	// RVA: 0x77940C
	public override string get_SDKVersion() { }

	// RVA: 0x7794C4
	public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x779634
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77974C
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77984C
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77994C
	public override void LogOut() { }

	// RVA: 0x779A10
	public override bool get_LoggedIn() { }

	// RVA: 0x779AEC
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x779BA4
	public override Profile CurrentProfile() { }

	// RVA: 0x779C5C
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x77A090
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x77A1C0
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x77A3D8
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x77AA48
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x77AB3C
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x77AB44
	public override void ActivateApp(string appId) { }

	// RVA: 0x77ABFC
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x77AD14
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x77AE2C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77AE6C
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77AEAC
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x77AFCC
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x77B0EC
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x77B298
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x77B3B0
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x77B4C8
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77B624
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77B778
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x779210
	private static IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x77A5C4
	private static NativeDict MarshallDict(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x30A15D4
	private int AddCallback(Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject
{
	// Methods

	// RVA: 0x77B82C
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader
{
	// Methods

	// RVA: 0x77B834
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x77B958
	public void .ctor() { }

}

// Namespace: 
private class JavaMethodCall<T0>
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(AndroidFacebook androidImpl, string methodName) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x7806B4
	private static void .cctor() { }

	// RVA: 0x780720
	public void .ctor() { }

	// RVA: 0x780728
	internal string <CreateTournament>b__73_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7807F0
	internal object <CreateTournament>b__73_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x7808BC
	internal string <ShareTournament>b__74_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x780984
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

	// RVA: 0x77B960
	public void .ctor() { }

	// RVA: 0x77BAE8
	public void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	// RVA: 0x77BB78
	private void set_KeyHash(string value) { }

	// RVA: 0x77BB80
	public override bool get_LimitEventUsage() { }

	// RVA: 0x77BB88
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x77BD58
	public override string get_SDKName() { }

	// RVA: 0x77BD9C
	public override string get_SDKVersion() { }

	// RVA: 0x77BE7C
	public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x77C0E4
	public override void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77C1A4
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77C2D4
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x77C404
	public override void LogOut() { }

	// RVA: 0x77C4C0
	public override AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x77C7D4
	public override Profile CurrentProfile() { }

	// RVA: 0x77D094
	public void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x77D110
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x77D468
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x77D62C
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x77D86C
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x77D93C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x77DBEC
	public override void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x77DDA4
	public override bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x77DE84
	public override void ActivateApp(string appId) { }

	// RVA: 0x77DEDC
	public override void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x77DFAC
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x77E07C
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77E0BC
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x77E0FC
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77E2C8
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x77E42C
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x77E46C
	public override void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x77E53C
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x77E60C
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x77E6DC
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x77E840
	public override void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x77E970
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x77EA40
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x77EB10
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x77EC40
	public override void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x77ED70
	public override void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x77EE40
	public override void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x77EF10
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x77F11C
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x77F24C
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x77F37C
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x77F4AC
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x77F5DC
	public override void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x77F6AC
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x77F7EC
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x77F92C
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77F9FC
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x77FDAC
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7800B8
	public override void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x780188
	public override void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7802B8
	public override void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7803E8
	public override void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x7805B4
	public override void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x77BA2C
	private static IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x77BC28
	private void CallFB(string method, string args) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject
{
	// Methods

	// RVA: 0x780A50
	protected override void OnAwake() { }

	// RVA: 0x780A58
	private void OnEnable() { }

	// RVA: 0x780B08
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x780B10
	private void OnDisable() { }

	// RVA: 0x780BC0
	public void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x780BCC
	public void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x780CC0
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader
{
	// Methods

	// RVA: 0x780CC8
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x780D80
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

	// RVA: 0x30A2BF4
	public void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }

	// RVA: 0x30A27C0
	public override void Call(MethodArguments args) { }

	// RVA: 0x30A2BF4
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

	// RVA: 0x783AE4
	private static void .cctor() { }

	// RVA: 0x783B50
	public void .ctor() { }

	// RVA: 0x783B58
	internal void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass47_0
{
	// Fields
	public ResultContainer result; // 0x10
	public Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x7833E0
	public void .ctor() { }

	// RVA: 0x783C08
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

	// RVA: 0x780D88
	public void .ctor() { }

	// RVA: 0x780EC8
	public void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x780E0C
	private static ICanvasJSWrapper GetCanvasJSWrapper() { }

	// RVA: 0x780F00
	public override bool get_LimitEventUsage() { }

	// RVA: 0x780F08
	public override void set_LimitEventUsage(bool value) { }

	// RVA: 0x780F10
	public override string get_SDKName() { }

	// RVA: 0x780F54
	public override string get_SDKVersion() { }

	// RVA: 0x781008
	public override string get_SDKUserAgent() { }

	// RVA: 0x7812B8
	public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x7816E8
	public override void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x781854
	public override void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7819C0
	public override void LogOut() { }

	// RVA: 0x781A84
	public override void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x781E34
	public override void ActivateApp(string appId) { }

	// RVA: 0x781EEC
	public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x7820C8
	public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x782320
	public override void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x78247C
	public override void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7825A0
	public override void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7826CC
	public override void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x7830F4
	public override void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x783134
	public void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x783248
	public void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7832C4
	public override void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x783340
	public override void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7833BC
	public void OnUrlResponse(string url) { }

	// RVA: 0x7833C4
	public void OnHideUnity(bool isGameShown) { }

	// RVA: 0x78275C
	private static void FormatAuthResponse(ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback) { }

	// RVA: 0x7833E8
	public override void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x783428
	public override void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x783468
	public override void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7834A8
	public override void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7834E8
	public override void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x783528
	public override void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x783568
	public override void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7835A8
	public override void CancelSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7835E8
	public override Profile CurrentProfile() { }

	// RVA: 0x783628
	public override void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x783668
	public override void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7836A8
	public override void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7836E8
	public override void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x783728
	public override void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x783768
	public override void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7837A8
	public override void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7837E8
	public override void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x783828
	public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x783868
	public override void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7838A8
	public override void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7838E8
	public override void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x783928
	public override void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x783968
	public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7839A8
	public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7839E8
	public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x783A28
	public override void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x783A68
	private void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject
{
	// Methods

	// RVA: 0x7843FC
	protected ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x784478
	public void OnPayComplete(string result) { }

	// RVA: 0x7845C0
	public void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x78470C
	public void OnUrlResponse(string message) { }

	// RVA: 0x784824
	public void OnHideUnity(bool hide) { }

	// RVA: 0x78493C
	protected override void OnAwake() { }

	// RVA: 0x784A14
	public void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader
{
	// Methods

	// RVA: 0x784A1C
	protected override FacebookGameObject get_FBGameObject() { }

	// RVA: 0x784B40
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

	// RVA: 0x784B48
	public void Start() { }

	// RVA: 0x784BAC
	public void OnLoginComplete(string responseJsonData) { }

	// RVA: 0x784C64
	public void OnFacebookAuthResponseChange(string responseJsonData) { }

	// RVA: 0x784D1C
	public void OnPayComplete(string responseJsonData) { }

	// RVA: 0x784DD0
	public void OnAppRequestsComplete(string responseJsonData) { }

	// RVA: 0x784E88
	public void OnShareLinkComplete(string responseJsonData) { }

	// RVA: 0x784F40
	public void OnFacebookFocus(string state) { }

	// RVA: 0x785020
	public void OnInitComplete(string responseJsonData) { }

	// RVA: 0x7850D4
	public void OnUrlResponse(string url) { }

	// RVA: 0x78518C
	public void .ctor() { }

}


