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

	// RVA: 0x72CC9C
	void .ctor(string jsonString) { }

	// RVA: 0x72CD1C
	Char get_PeekChar() { }

	// RVA: 0x72CDA8
	Char get_NextChar() { }

	// RVA: 0x72CE34
	string get_NextWord() { }

	// RVA: 0x72CFC0
	TOKEN get_NextToken() { }

	// RVA: 0x72C950
	object Parse(string jsonString) { }

	// RVA: 0x72D384
	void Dispose() { }

	// RVA: 0x72D3C0
	System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x72D9E8
	System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x72D35C
	object ParseValue() { }

	// RVA: 0x72DAF8
	object ParseByToken(TOKEN token) { }

	// RVA: 0x72D54C
	string ParseString() { }

	// RVA: 0x72DC04
	object ParseNumber() { }

	// RVA: 0x72D264
	void EatWhitespace() { }

}

// Namespace: 
private sealed class Serializer 
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x72DD10
	void .ctor() { }

	// RVA: 0x72CB0C
	string Serialize(object obj) { }

	// RVA: 0x72DD88
	void SerializeValue(object value) { }

	// RVA: 0x72E564
	void SerializeObject(IDictionary obj) { }

	// RVA: 0x72E21C
	void SerializeArray(IList array) { }

	// RVA: 0x72DF60
	void SerializeString(string str) { }

	// RVA: 0x72E9E8
	void SerializeOther(object value) { }

}

// Namespace: Facebook.MiniJSON
public static class Json 
{
	// Fields
	private static NumberFormatInfo numberFormat; // 0x0

	// Methods

	// RVA: 0x72C944
	object Deserialize(string json) { }

	// RVA: 0x72CB08
	string Serialize(object obj) { }

	// RVA: 0x72CBE0
	void .cctor() { }

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

	// RVA: 0x72EBD4
	void .ctor(string tokenString, string userId, DateTime expirationTime, System.Collections.Generic.IEnumerable<System.String> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain) { }

	// RVA: 0x72EDC4
	AccessToken get_CurrentAccessToken() { }

	// RVA: 0x72EE10
	void set_CurrentAccessToken(AccessToken value) { }

	// RVA: 0x72EE74
	string get_TokenString() { }

	// RVA: 0x72EE7C
	void set_TokenString(string value) { }

	// RVA: 0x72EE84
	DateTime get_ExpirationTime() { }

	// RVA: 0x72EE8C
	void set_ExpirationTime(DateTime value) { }

	// RVA: 0x72EE94
	System.Collections.Generic.IEnumerable<System.String> get_Permissions() { }

	// RVA: 0x72EE9C
	void set_Permissions(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x72EEA4
	string get_UserId() { }

	// RVA: 0x72EEAC
	void set_UserId(string value) { }

	// RVA: 0x72EEB4
	System.Nullable<System.DateTime> get_LastRefresh() { }

	// RVA: 0x72EEC0
	void set_LastRefresh(System.Nullable<System.DateTime> value) { }

	// RVA: 0x72EEC8
	string get_GraphDomain() { }

	// RVA: 0x72EED0
	void set_GraphDomain(string value) { }

	// RVA: 0x72EED8
	string ToString() { }

	// RVA: 0x72F920
	string ToJson() { }

}

// Namespace: Facebook.Unity
internal class CallbackManager 
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> facebookDelegates; // 0x10
	private int nextAsyncId; // 0x18

	// Methods

	// RVA: 0x2FE36BC
	string AddFacebookDelegate(Facebook.Unity.FacebookDelegate<T> callback) { }

	// RVA: 0x72FBC8
	void OnFacebookResponse(IInternalResult result) { }

	// RVA: 0x72FE98
	void CallCallback(object callback, IResult result) { }

	// RVA: 0x2FE59C8
	bool TryCallCallback(object callback, IResult result) { }

	// RVA: 0x73061C
	void .ctor() { }

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

	// RVA: 0x7306A8
	GameObject get_FacebookGameObject() { }

	// RVA: 0x309AF8C
	T GetComponent(IfNotExist ifNotExist) { }

	// RVA: 0x309AF8C
	T AddComponent() { }

}

// Namespace: Facebook.Unity
internal static class Constants 
{
	// Fields
	private static System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform; // 0x0

	// Methods

	// RVA: 0x7307CC
	Uri get_GraphUrl() { }

	// RVA: 0x730AFC
	string get_GraphApiUserAgent() { }

	// RVA: 0x730EA0
	bool get_IsEditor() { }

	// RVA: 0x730F10
	bool get_IsWeb() { }

	// RVA: 0x7310AC
	string get_UnitySDKUserAgentSuffixLegacy() { }

	// RVA: 0x730E28
	string get_UnitySDKUserAgent() { }

	// RVA: 0x731340
	bool get_DebugMode() { }

	// RVA: 0x730F2C
	FacebookUnityPlatform get_CurrentPlatform() { }

	// RVA: 0x7313B0
	FacebookUnityPlatform GetCurrentPlatform() { }

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

	// RVA: 0x731440
	System.Collections.Generic.IDictionary<System.String,System.String> toGraphAPIData() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateLocalizedText 
{
	// Fields
	private string _default; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> _localizations; // 0x18

	// Methods

	// RVA: 0x7315F0
	string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMedia 
{
	// Fields
	private CustomUpdateMediaInfo _gif; // 0x10
	private CustomUpdateMediaInfo _video; // 0x18

	// Methods

	// RVA: 0x731710
	string toJson() { }

}

// Namespace: Facebook.Unity
public sealed class CustomUpdateMediaInfo 
{
	// Fields
	private string _url; // 0x10

	// Methods

	// RVA: 0x7318F4
	string get_Url() { }

}

// Namespace: 
private sealed class OnDLLLoaded 
{
	// Methods

	// RVA: 0x732E3C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x7361B0
	internal void Invoke() { }

}

// Namespace: 
public sealed class Mobile 
{
	// Methods

	// RVA: 0x7361C4
	IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x7362A4
	void LoginWithTrackingPreference(LoginTracking loginTracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7363E4
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x73649C
	Profile CurrentProfile() { }

	// RVA: 0x736554
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x736618
	bool IsImplicitPurchaseLoggingEnabled() { }

}

// Namespace: 
internal abstract class CompiledFacebookLoader 
{
	// Methods

	// RVA: 0x2FE360C
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x7366D0
	void Start() { }

	// RVA: 0x736814
	void .ctor() { }

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

	// RVA: 0x732E34
	void .ctor() { }

	// RVA: 0x73681C
	void <Init>b__0() { }

	// RVA: 0x736A2C
	void <Init>b__1() { }

	// RVA: 0x736B04
	void <Init>b__2() { }

	// RVA: 0x736CCC
	void <Init>b__3() { }

	// RVA: 0x736DDC
	void <Init>b__4() { }

	// RVA: 0x736E9C
	void <Init>b__5() { }

}

// Namespace: Facebook.Unity
public sealed class FB 
{
	// Fields
	private const string DefaultJSSDKLocale = 5736094864;
	private static IFacebook facebook; // 0x0
	private static bool isInitCalled; // 0x8
	private static string facebookDomain; // 0x10
	private static string gamingDomain; // 0x18
	private static string graphApiVersion; // 0x20
	private static string <AppId>k__BackingField; // 0x28
	private static string <ClientToken>k__BackingField; // 0x30
	private static OnDLLLoaded <OnDLLLoadedDelegate>k__BackingField; // 0x38

	// Methods

	// RVA: 0x7318FC
	string get_AppId() { }

	// RVA: 0x731978
	void set_AppId(string value) { }

	// RVA: 0x7319E4
	string get_ClientToken() { }

	// RVA: 0x731A60
	void set_ClientToken(string value) { }

	// RVA: 0x731ACC
	string get_GraphApiVersion() { }

	// RVA: 0x731B48
	void set_GraphApiVersion(string value) { }

	// RVA: 0x731BB4
	bool get_IsLoggedIn() { }

	// RVA: 0x731CD0
	bool get_IsInitialized() { }

	// RVA: 0x731DF4
	bool get_LimitAppEventUsage() { }

	// RVA: 0x731F18
	void set_LimitAppEventUsage(bool value) { }

	// RVA: 0x730D3C
	IFacebook get_FacebookImpl() { }

	// RVA: 0x73203C
	void set_FacebookImpl(IFacebook value) { }

	// RVA: 0x7309B8
	string get_FacebookDomain() { }

	// RVA: 0x7320B0
	void set_FacebookDomain(string value) { }

	// RVA: 0x73211C
	OnDLLLoaded get_OnDLLLoadedDelegate() { }

	// RVA: 0x732198
	void set_OnDLLLoadedDelegate(OnDLLLoaded value) { }

	// RVA: 0x732204
	void Init(InitDelegate onInitComplete, HideUnityDelegate onHideUnity, string authResponse) { }

	// RVA: 0x732344
	void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, HideUnityDelegate onHideUnity, InitDelegate onInitComplete) { }

	// RVA: 0x73301C
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x733114
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x73320C
	void LogOut() { }

	// RVA: 0x7332FC
	void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x733464
	void AppRequest(string message, OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x7335D4
	void AppRequest(string message, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x733724
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x733844
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x733990
	void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x733AF8
	void API(string query, HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, WWWForm formData) { }

	// RVA: 0x733C60
	void ActivateApp() { }

	// RVA: 0x733DA4
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x733E9C
	void ClearAppLink() { }

	// RVA: 0x733EA0
	void LogAppEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x733FA8
	void LogPurchase(Decimal logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x734094
	void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7341BC
	void LogVersion() { }

	// RVA: 0x7344F4
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7345E4
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7346D4
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7347DC
	void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7348D4
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7349C4
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x734AB4
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x734BAC
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x734CA4
	Profile CurrentProfile() { }

	// RVA: 0x734D94
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x734E84
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x734F7C
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x735074
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x73516C
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x735264
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x735354
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x735444
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x73553C
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x735664
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x73575C
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x735854
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x735944
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x735A4C
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x735B94
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x735CA4
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x735DB4
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x735ED0
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x735FF0
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7360E0
	void .ctor() { }

	// RVA: 0x7360E8
	void .cctor() { }

}

// Namespace: Facebook.Unity
public sealed class FBGamingServices 
{
	// Methods

	// RVA: 0x736F58
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7370FC
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7371D4
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7372AC
	void PerformCustomUpdate(CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x737344
	void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x737408
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7374CC
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x737590
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x737658
	void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x737718
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7377DC
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7378A0
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x737960
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x737A20
	void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x737AE4
	void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x737BA8
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x737C98
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x737D58
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x737E18
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x737ED8
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x737F98
	void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x73805C
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x73811C
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7381E0
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7382A8
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7383B0
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x738470
	void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x738534
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x7385F4
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x7386B4
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x73878C
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x73701C
	IMobileFacebook get_MobileFacebookImpl() { }

	// RVA: 0x738850
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Facebook.Unity.FacebookBase.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__41_0; // 0x8

	// Methods

	// RVA: 0x739E04
	void .cctor() { }

	// RVA: 0x739E70
	void .ctor() { }

	// RVA: 0x739E78
	bool <ValidateAppRequestArgs>b__41_0(string toWhom) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookBase 
{
	// Fields
	private InitDelegate onInitCompleteDelegate; // 0x10
	private bool <Initialized>k__BackingField; // 0x18
	private CallbackManager <CallbackManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x738858
	void .ctor(CallbackManager callbackManager) { }

	// RVA: 0x2FE3054
	bool get_LimitEventUsage() { }

	// RVA: 0x2FE4234
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x2FE360C
	string get_SDKName() { }

	// RVA: 0x2FE360C
	string get_SDKVersion() { }

	// RVA: 0x73888C
	string get_SDKUserAgent() { }

	// RVA: 0x7388D8
	bool get_LoggedIn() { }

	// RVA: 0x7389AC
	bool get_Initialized() { }

	// RVA: 0x7389B4
	void set_Initialized(bool value) { }

	// RVA: 0x7389BC
	CallbackManager get_CallbackManager() { }

	// RVA: 0x7389C4
	void set_CallbackManager(CallbackManager value) { }

	// RVA: 0x7389CC
	void Init(InitDelegate onInitComplete) { }

	// RVA: 0x2FE47D4
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x2FE47D4
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7389D4
	void LogOut() { }

	// RVA: -1
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x2FE4AF8
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x2FE4C50
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x738A2C
	void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7394FC
	void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x2FE4574
	void ActivateApp(string appId) { }

	// RVA: 0x2FE4574
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x739748
	void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7398B8
	void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x739910
	void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x739D58
	void OnAuthResponse(LoginResult result) { }

	// RVA: 0x738DDC
	System.Collections.Generic.IDictionary<System.String,System.String> CopyByValue(System.Collections.Generic.IDictionary<System.String,System.String> data) { }

	// RVA: 0x739434
	Uri GetGraphUrl(string query) { }

	// RVA: 0x2FE4574
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x2FE4574
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x2FE49A8
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x2FE47D4
	void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x2FE4574
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x2FE4574
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x2FE47D4
	void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x2FE47D4
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x2FE360C
	Profile CurrentProfile() { }

	// RVA: 0x2FE4574
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x2FE47D4
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x2FE47D4
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x2FE47D4
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x2FE47D4
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x2FE4574
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x2FE4574
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x2FE47D4
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x2FE440C
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x2FE440C
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x2FE4574
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x739DE0
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x739DE4
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x2FE4574
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x739DE8
	void <OnInitComplete>b__35_0(ILoginResult result) { }

}

// Namespace: Facebook.Unity
public sealed class InitDelegate 
{
	// Methods

	// RVA: 0x739E84
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x739F24
	internal void Invoke() { }

}

// Namespace: Facebook.Unity
public sealed class FacebookDelegate<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T result) { }

}

// Namespace: Facebook.Unity
public sealed class HideUnityDelegate 
{
	// Methods

	// RVA: 0x739F38
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x739FDC
	internal void Invoke(bool isUnityShown) { }

}

// Namespace: Facebook.Unity
internal abstract class FacebookGameObject 
{
	// Fields
	private IFacebookImplementation <Facebook>k__BackingField; // 0x20

	// Methods

	// RVA: 0x739FF0
	IFacebookImplementation get_Facebook() { }

	// RVA: 0x739FF8
	void set_Facebook(IFacebookImplementation value) { }

	// RVA: 0x73A000
	void Awake() { }

	// RVA: 0x73A0E0
	void OnInitComplete(string message) { }

	// RVA: 0x73A34C
	void OnLoginComplete(string message) { }

	// RVA: 0x73A42C
	void OnLogoutComplete(string message) { }

	// RVA: 0x73A50C
	void OnGetAppLinkComplete(string message) { }

	// RVA: 0x73A5EC
	void OnAppRequestsComplete(string message) { }

	// RVA: 0x73A6CC
	void OnShareLinkComplete(string message) { }

	// RVA: 0x73A7AC
	void OnAwake() { }

	// RVA: 0x73A7B0
	void .ctor() { }

}

// Namespace: Facebook.Unity
public class FacebookSdkVersion 
{
	// Methods

	// RVA: 0x7311CC
	string get_Build() { }

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

	// RVA: 0x2FE3054
	bool get_LoggedIn() { }

	// RVA: 0x2FE3054
	bool get_LimitEventUsage() { }

	// RVA: 0x2FE4234
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x2FE360C
	string get_SDKUserAgent() { }

	// RVA: 0x2FE3054
	bool get_Initialized() { }

	// RVA: 0x2FE47D4
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x2FE47D4
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x2FE41A8
	void LogOut() { }

	// RVA: -1
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x2FE4AF8
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x2FE4C50
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: -1
	void API(string query, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	void API(string query, HttpMethod method, WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x2FE4574
	void ActivateApp(string appId) { }

	// RVA: 0x2FE4574
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: -1
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: -1
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x2FE4574
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x2FE4574
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x2FE49A8
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x2FE47D4
	void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x2FE4574
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x2FE4574
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x2FE47D4
	void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x2FE47D4
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x2FE360C
	Profile CurrentProfile() { }

	// RVA: 0x2FE4574
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x2FE47D4
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x2FE47D4
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x2FE47D4
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x2FE47D4
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x2FE4574
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x2FE4574
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x2FE47D4
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: -1
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x2FE440C
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x2FE440C
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x2FE4574
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: -1
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: -1
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x2FE4574
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookWindows 
{
	// Methods

	// RVA: -1
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: -1
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookCallbackHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnInitComplete(string message) { }

	// RVA: 0x2FE4574
	void OnLoginComplete(string message) { }

	// RVA: 0x2FE4574
	void OnAppRequestsComplete(string message) { }

	// RVA: 0x2FE4574
	void OnShareLinkComplete(string message) { }

}

// Namespace: Facebook.Unity
internal interface IFacebookImplementation 
{}

// Namespace: Facebook.Unity
internal interface IFacebookResultHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnInitComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnLogoutComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnShareLinkComplete(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class MethodArguments 
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.Object> arguments; // 0x10

	// Methods

	// RVA: 0x73A7B8
	void .ctor() { }

	// RVA: 0x73A8E0
	void .ctor(MethodArguments methodArgs) { }

	// RVA: 0x73A834
	void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> arguments) { }

	// RVA: 0x309AF8C
	void AddPrimative(string argumentName, T value) { }

	// RVA: 0x309AF8C
	void AddNullablePrimitive(string argumentName, System.Nullable<T> nullable) { }

	// RVA: 0x73A8FC
	void AddString(string argumentName, string value) { }

	// RVA: 0x73A9DC
	void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x73AB24
	void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

	// RVA: 0x2FE47D4
	void AddList(string argumentName, System.Collections.Generic.IEnumerable<T> list) { }

	// RVA: 0x73B084
	void AddUri(string argumentName, Uri uri) { }

	// RVA: 0x73B1EC
	string ToJsonString() { }

	// RVA: 0x73AC04
	System.Collections.Generic.Dictionary<System.String,System.String> ToStringDict(System.Collections.Generic.IDictionary<System.String,System.Object> dict) { }

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

	// RVA: 0x2FE47D4
	void .ctor(FacebookBase facebookImpl, string methodName) { }

	// RVA: 0x2FE360C
	string get_MethodName() { }

	// RVA: 0x2FE4574
	void set_MethodName(string value) { }

	// RVA: 0x2FE360C
	Facebook.Unity.FacebookDelegate<T> get_Callback() { }

	// RVA: 0x2FE4574
	void set_Callback(Facebook.Unity.FacebookDelegate<T> value) { }

	// RVA: 0x2FE4574
	void set_FacebookImpl(FacebookBase value) { }

	// RVA: 0x2FE4574
	void set_Parameters(MethodArguments value) { }

	// RVA: 0x2FE4574
	void Call(MethodArguments args) { }

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

	// RVA: 0x73B274
	void .ctor(string amount, string currency) { }

	// RVA: 0x73B2C4
	string get_Amount() { }

	// RVA: 0x73B2CC
	void set_Amount(string value) { }

	// RVA: 0x73B2D4
	string get_Currency() { }

	// RVA: 0x73B2DC
	void set_Currency(string value) { }

	// RVA: 0x73B2E4
	string ToString() { }

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

	// RVA: 0x73B3F8
	void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode) { }

	// RVA: 0x73B5CC
	string get_Title() { }

	// RVA: 0x73B5D4
	void set_Title(string value) { }

	// RVA: 0x73B5DC
	string get_ProductID() { }

	// RVA: 0x73B5E4
	void set_ProductID(string value) { }

	// RVA: 0x73B5EC
	string get_Description() { }

	// RVA: 0x73B5F4
	void set_Description(string value) { }

	// RVA: 0x73B5FC
	string get_ImageURI() { }

	// RVA: 0x73B604
	void set_ImageURI(string value) { }

	// RVA: 0x73B60C
	string get_Price() { }

	// RVA: 0x73B614
	void set_Price(string value) { }

	// RVA: 0x73B61C
	System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x73B628
	void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x73B630
	string get_PriceCurrencyCode() { }

	// RVA: 0x73B638
	void set_PriceCurrencyCode(string value) { }

	// RVA: 0x73B640
	string ToString() { }

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

	// RVA: 0x73B930
	void .ctor(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest) { }

	// RVA: 0x73BF58
	string get_DeveloperPayload() { }

	// RVA: 0x73BF60
	void set_DeveloperPayload(string value) { }

	// RVA: 0x73BF68
	bool get_IsConsumed() { }

	// RVA: 0x73BF70
	string get_PaymentActionType() { }

	// RVA: 0x73BF78
	void set_PaymentActionType(string value) { }

	// RVA: 0x73BF80
	string get_PaymentID() { }

	// RVA: 0x73BF88
	void set_PaymentID(string value) { }

	// RVA: 0x73BF90
	string get_ProductID() { }

	// RVA: 0x73BF98
	void set_ProductID(string value) { }

	// RVA: 0x73BFA0
	string get_PurchasePlatform() { }

	// RVA: 0x73BFA8
	void set_PurchasePlatform(string value) { }

	// RVA: 0x73BFB0
	CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x73BFB8
	void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x73BFC0
	DateTime get_PurchaseTime() { }

	// RVA: 0x73BFC8
	void set_PurchaseTime(DateTime value) { }

	// RVA: 0x73BFD0
	string get_PurchaseToken() { }

	// RVA: 0x73BFD8
	void set_PurchaseToken(string value) { }

	// RVA: 0x73BFE0
	string get_SignedRequest() { }

	// RVA: 0x73BFE8
	void set_SignedRequest(string value) { }

	// RVA: 0x73BFF0
	string ToString() { }

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

	// RVA: 0x73C348
	void .ctor(string title, string productID, string description, string imageURI, string price, System.Nullable<System.Double> priceAmount, string priceCurrencyCode, string subscriptionTerm) { }

	// RVA: 0x73C53C
	string get_Title() { }

	// RVA: 0x73C544
	void set_Title(string value) { }

	// RVA: 0x73C54C
	string get_ProductID() { }

	// RVA: 0x73C554
	void set_ProductID(string value) { }

	// RVA: 0x73C55C
	string get_Description() { }

	// RVA: 0x73C564
	void set_Description(string value) { }

	// RVA: 0x73C56C
	string get_ImageURI() { }

	// RVA: 0x73C574
	void set_ImageURI(string value) { }

	// RVA: 0x73C57C
	string get_Price() { }

	// RVA: 0x73C584
	void set_Price(string value) { }

	// RVA: 0x73C58C
	System.Nullable<System.Double> get_PriceAmount() { }

	// RVA: 0x73C598
	void set_PriceAmount(System.Nullable<System.Double> value) { }

	// RVA: 0x73C5A0
	string get_PriceCurrencyCode() { }

	// RVA: 0x73C5A8
	void set_PriceCurrencyCode(string value) { }

	// RVA: 0x73C5B0
	string get_SubscriptionTerm() { }

	// RVA: 0x73C5B8
	void set_SubscriptionTerm(string value) { }

	// RVA: 0x73C5C0
	string ToString() { }

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

	// RVA: 0x73C8D8
	void .ctor(Int64 deactivationTime, bool isEntitlementActive, Int64 periodStartTime, Int64 periodEndTime, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<System.String,System.Object> purchasePrice, Int64 purchaseTime, string purchaseToken, string signedRequest, string status, string subscriptionTerm) { }

	// RVA: 0x73D1F0
	DateTime get_DeactivationTime() { }

	// RVA: 0x73D1F8
	void set_DeactivationTime(DateTime value) { }

	// RVA: 0x73D200
	bool get_IsEntitlementActive() { }

	// RVA: 0x73D208
	void set_IsEntitlementActive(bool value) { }

	// RVA: 0x73D210
	DateTime get_PeriodStartTime() { }

	// RVA: 0x73D218
	void set_PeriodStartTime(DateTime value) { }

	// RVA: 0x73D220
	DateTime get_PeriodEndTime() { }

	// RVA: 0x73D228
	void set_PeriodEndTime(DateTime value) { }

	// RVA: 0x73D230
	string get_ProductID() { }

	// RVA: 0x73D238
	void set_ProductID(string value) { }

	// RVA: 0x73D240
	string get_PurchasePlatform() { }

	// RVA: 0x73D248
	void set_PurchasePlatform(string value) { }

	// RVA: 0x73D250
	CurrencyAmount get_PurchasePrice() { }

	// RVA: 0x73D258
	void set_PurchasePrice(CurrencyAmount value) { }

	// RVA: 0x73D260
	DateTime get_PurchaseTime() { }

	// RVA: 0x73D268
	void set_PurchaseTime(DateTime value) { }

	// RVA: 0x73D270
	string get_PurchaseToken() { }

	// RVA: 0x73D278
	void set_PurchaseToken(string value) { }

	// RVA: 0x73D280
	string get_SignedRequest() { }

	// RVA: 0x73D288
	void set_SignedRequest(string value) { }

	// RVA: 0x73D290
	string get_Status() { }

	// RVA: 0x73D298
	void set_Status(string value) { }

	// RVA: 0x73D2A0
	string get_SubscriptionTerm() { }

	// RVA: 0x73D2A8
	void set_SubscriptionTerm(string value) { }

	// RVA: 0x73D2B0
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class AccessTokenRefreshResult 
{
	// Fields
	private AccessToken <AccessToken>k__BackingField; // 0x50

	// Methods

	// RVA: 0x73D654
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x73DA5C
	AccessToken get_AccessToken() { }

	// RVA: 0x73DA64
	void set_AccessToken(AccessToken value) { }

	// RVA: 0x73DA6C
	string ToString() { }

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

	// RVA: 0x73DD78
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x73DF34
	string get_Url() { }

	// RVA: 0x73DF3C
	void set_Url(string value) { }

	// RVA: 0x73DF44
	string get_TargetUrl() { }

	// RVA: 0x73DF4C
	void set_TargetUrl(string value) { }

	// RVA: 0x73DF54
	string get_Ref() { }

	// RVA: 0x73DF5C
	void set_Ref(string value) { }

	// RVA: 0x73DF64
	System.Collections.Generic.IDictionary<System.String,System.Object> get_Extras() { }

	// RVA: 0x73DF6C
	void set_Extras(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x73DF74
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class AppRequestResult 
{
	// Fields
	private string <RequestID>k__BackingField; // 0x50
	private System.Collections.Generic.IEnumerable<System.String> <To>k__BackingField; // 0x58

	// Methods

	// RVA: 0x73E1B0
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x73E684
	string get_RequestID() { }

	// RVA: 0x73E68C
	void set_RequestID(string value) { }

	// RVA: 0x73E694
	System.Collections.Generic.IEnumerable<System.String> get_To() { }

	// RVA: 0x73E69C
	void set_To(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x73E6A4
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class CatalogResult 
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField; // 0x50

	// Methods

	// RVA: 0x73E84C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x73F078
	System.Collections.Generic.IList<Facebook.Unity.Product> get_Products() { }

	// RVA: 0x73F080
	void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value) { }

	// RVA: 0x73F088
	string ToString() { }

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

	// RVA: 0x73F470
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ConsumePurchaseResult 
{
	// Methods

	// RVA: 0x73F474
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GamingServicesFriendFinderResult 
{
	// Methods

	// RVA: 0x73F478
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GraphResult 
{
	// Fields
	private System.Collections.Generic.IList<System.Object> <ResultList>k__BackingField; // 0x50
	private Texture2D <Texture>k__BackingField; // 0x58

	// Methods

	// RVA: 0x73F47C
	void .ctor(UnityWebRequestAsyncOperation result) { }

	// RVA: 0x73F764
	void set_ResultList(System.Collections.Generic.IList<System.Object> value) { }

	// RVA: 0x73F76C
	Texture2D get_Texture() { }

	// RVA: 0x73F774
	void set_Texture(Texture2D value) { }

	// RVA: 0x73F644
	void Init(string rawResult) { }

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

	// RVA: 0x73F77C
	void .ctor(ResultContainer resultContainer) { }

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

	// RVA: 0x73F780
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class GameLoadCompleteResult 
{
	// Methods

	// RVA: 0x73F784
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class InterstitialAdResult 
{
	// Methods

	// RVA: 0x73F788
	void .ctor(ResultContainer resultContainer) { }

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

	// RVA: 0x2FE360C
	string get_CallbackId() { }

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

	// RVA: 0x2FE360C
	string get_Error() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x2FE3054
	bool get_Cancelled() { }

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

	// RVA: 0x73F8D0
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x73FE74
	AccessToken get_AccessToken() { }

	// RVA: 0x73FE7C
	void set_AccessToken(AccessToken value) { }

	// RVA: 0x73FE84
	AuthenticationToken get_AuthenticationToken() { }

	// RVA: 0x73FE8C
	void set_AuthenticationToken(AuthenticationToken value) { }

	// RVA: 0x73FE94
	string ToString() { }

	// RVA: 0x740040
	void .cctor() { }

}

// Namespace: Facebook.Unity
internal class LoginStatusResult 
{
	// Fields
	public static readonly string FailedKey; // 0x0
	private bool <Failed>k__BackingField; // 0x60

	// Methods

	// RVA: 0x74023C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74040C
	bool get_Failed() { }

	// RVA: 0x740414
	void set_Failed(bool value) { }

	// RVA: 0x74041C
	string ToString() { }

	// RVA: 0x740558
	void .cctor() { }

}

// Namespace: Facebook.Unity
internal class OpenAppStoreResult 
{
	// Methods

	// RVA: 0x7405D0
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class PayloadResult 
{
	// Fields
	private System.Collections.Generic.IDictionary<System.String,System.String> <Payload>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7405D4
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x740864
	System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x74086C
	void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x740874
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class PayResult 
{
	// Methods

	// RVA: 0x7408B8
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7409A8
	Int64 get_ErrorCode() { }

	// RVA: 0x740A84
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchaseResult 
{
	// Fields
	private Purchase <Purchase>k__BackingField; // 0x50

	// Methods

	// RVA: 0x740C4C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7411E4
	Purchase get_Purchase() { }

	// RVA: 0x7411EC
	void set_Purchase(Purchase value) { }

	// RVA: 0x7411F4
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class PurchasesResult 
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7412EC
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x741A88
	System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases() { }

	// RVA: 0x741A90
	void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value) { }

	// RVA: 0x741A98
	string ToString() { }

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

	// RVA: 0x73D7B4
	void .ctor(ResultContainer result) { }

	// RVA: 0x73F5F8
	void .ctor(ResultContainer result, string error, bool cancelled) { }

	// RVA: 0x742550
	string get_Error() { }

	// RVA: 0x742558
	void set_Error(string value) { }

	// RVA: 0x742560
	System.Collections.Generic.IDictionary<System.String,System.String> get_ErrorDictionary() { }

	// RVA: 0x742568
	void set_ErrorDictionary(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x742570
	System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x742578
	void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x742580
	string get_RawResult() { }

	// RVA: 0x742588
	void set_RawResult(string value) { }

	// RVA: 0x742590
	bool get_Cancelled() { }

	// RVA: 0x742598
	void set_Cancelled(bool value) { }

	// RVA: 0x7425A0
	string get_CallbackId() { }

	// RVA: 0x7425A8
	void set_CallbackId(string value) { }

	// RVA: 0x7425B0
	System.Nullable<System.Int64> get_CanvasErrorCode() { }

	// RVA: 0x7425BC
	void set_CanvasErrorCode(System.Nullable<System.Int64> value) { }

	// RVA: 0x73DBAC
	string ToString() { }

	// RVA: 0x74233C
	void Init(ResultContainer result, string error, bool cancelled, string callbackId) { }

	// RVA: 0x741E80
	string GetErrorValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x741F1C
	bool GetCancelledValue(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

	// RVA: 0x7422A0
	string GetCallbackId(System.Collections.Generic.IDictionary<System.String,System.Object> result) { }

}

// Namespace: Facebook.Unity
internal class ResultContainer 
{
	// Fields
	private const string CanvasResponseKey = 5736094768;
	private string <RawResult>k__BackingField; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.Object> <ResultDictionary>k__BackingField; // 0x18

	// Methods

	// RVA: 0x742B18
	void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x73A1BC
	void .ctor(string result) { }

	// RVA: 0x742D8C
	string get_RawResult() { }

	// RVA: 0x742D94
	void set_RawResult(string value) { }

	// RVA: 0x742D9C
	System.Collections.Generic.IDictionary<System.String,System.Object> get_ResultDictionary() { }

	// RVA: 0x742DA4
	void set_ResultDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> value) { }

	// RVA: 0x742BD8
	System.Collections.Generic.IDictionary<System.String,System.Object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

}

// Namespace: Facebook.Unity
internal class RewardedVideoResult 
{
	// Methods

	// RVA: 0x742DAC
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ScheduleAppToUserNotificationResult 
{
	// Methods

	// RVA: 0x742EF4
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
internal class ShareResult 
{
	// Fields
	private string <PostId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x742EF8
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7430A4
	string get_PostId() { }

	// RVA: 0x7430AC
	void set_PostId(string value) { }

	// RVA: 0x743038
	string get_PostIDKey() { }

	// RVA: 0x7430B4
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscribableCatalogResult 
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> <SubscribableProducts>k__BackingField; // 0x50

	// Methods

	// RVA: 0x7431AC
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x7439D8
	System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> get_SubscribableProducts() { }

	// RVA: 0x7439E0
	void set_SubscribableProducts(System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> value) { }

	// RVA: 0x7439E8
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionResult 
{
	// Fields
	private Subscription <Subscription>k__BackingField; // 0x50

	// Methods

	// RVA: 0x743DD0
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x744368
	Subscription get_Subscription() { }

	// RVA: 0x744370
	void set_Subscription(Subscription value) { }

	// RVA: 0x744378
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class SubscriptionsResult 
{
	// Fields
	private System.Collections.Generic.IList<Facebook.Unity.Subscription> <Subscriptions>k__BackingField; // 0x50

	// Methods

	// RVA: 0x744470
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x744C04
	System.Collections.Generic.IList<Facebook.Unity.Subscription> get_Subscriptions() { }

	// RVA: 0x744C0C
	void set_Subscriptions(System.Collections.Generic.IList<Facebook.Unity.Subscription> value) { }

	// RVA: 0x744C14
	string ToString() { }

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

	// RVA: 0x745398
	void .ctor(int <>1__state) { }

	// RVA: 0x7453CC
	void System.IDisposable.Dispose() { }

	// RVA: 0x7453D0
	bool MoveNext() { }

	// RVA: 0x745EBC
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x745EC4
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x745F04
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x744FFC
	void Post(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x74513C
	void Get(Uri url, System.Collections.Generic.Dictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7451D8
	void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x74509C
	void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x745320
	IEnumerator Start() { }

	// RVA: 0x745278
	AsyncRequestString SetUrl(Uri url) { }

	// RVA: 0x7452A0
	AsyncRequestString SetMethod(HttpMethod method) { }

	// RVA: 0x7452F8
	AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<System.String,System.String> formData) { }

	// RVA: 0x7452A8
	AsyncRequestString SetQuery(WWWForm query) { }

	// RVA: 0x7452D0
	AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x7453C4
	void .ctor() { }

}

// Namespace: 
private class DebugLogger 
{
	// Methods

	// RVA: 0x745FC8
	void .ctor() { }

	// RVA: 0x746288
	void Log(string msg) { }

	// RVA: 0x746348
	void Info(string msg) { }

	// RVA: 0x7463D0
	void Warn(string msg) { }

}

// Namespace: Facebook.Unity
internal static class FacebookLogger 
{
	// Fields
	private static IFacebookLogger <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x745F0C
	void .cctor() { }

	// RVA: 0x745FD0
	IFacebookLogger get_Instance() { }

	// RVA: 0x74604C
	void set_Instance(IFacebookLogger value) { }

	// RVA: 0x7460C0
	void Log(string msg) { }

	// RVA: 0x7343B4
	void Info(string msg) { }

	// RVA: 0x732EDC
	void Warn(string msg) { }

	// RVA: 0x7461FC
	void Warn(string format, string[] args) { }

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

	// RVA: 0x2FE4574
	void Log(string msg) { }

	// RVA: 0x2FE4574
	void Info(string msg) { }

	// RVA: 0x2FE4574
	void Warn(string msg) { }

}

// Namespace: 
public sealed class Callback<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T obj) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Facebook.Unity.Utilities.<>c <>9; // 0x0
	public static System.Func<System.Object,System.String> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x7492C4
	void .cctor() { }

	// RVA: 0x749330
	void .ctor() { }

	// RVA: 0x749338
	string <ParsePermissionFromResult>b__19_0(object permission) { }

}

// Namespace: Facebook.Unity
internal static class Utilities 
{
	// Methods

	// RVA: 0x2FE5B20
	bool TryGetValue(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, out T value) { }

	// RVA: 0x72F1C8
	Int64 TotalSeconds(DateTime dateTime) { }

	// RVA: 0x309AF8C
	T GetValueOrDefault(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary, string key, bool logWarning) { }

	// RVA: 0x72F2B4
	string ToCommaSeparateList(System.Collections.Generic.IEnumerable<System.String> list) { }

	// RVA: 0x746458
	string AbsoluteUrlOrEmptyString(Uri uri) { }

	// RVA: 0x731210
	string GetUserAgent(string productName, string productVersion) { }

	// RVA: 0x73E130
	string ToJson(System.Collections.Generic.IDictionary<System.String,System.Object> dictionary) { }

	// RVA: 0x2FEAB7C
	void AddAllKVPFrom(System.Collections.Generic.IDictionary<T1,T2> dest, System.Collections.Generic.IDictionary<T1,T2> source) { }

	// RVA: 0x73D8F4
	AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x73FD7C
	AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x72F354
	string ToStringNullOk(object obj) { }

	// RVA: 0x72F3B8
	string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<System.String,System.String> propertiesAndValues) { }

	// RVA: 0x746528
	DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x746A3C
	System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x746720
	System.Collections.Generic.ICollection<System.String> ParsePermissionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x73EB50
	System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x746C80
	Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x7434B0
	System.Collections.Generic.IList<Facebook.Unity.SubscribableProduct> ParseSubscribableCatalogFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7474A8
	SubscribableProduct ParseSubscribableProductFromCatalogResult(System.Collections.Generic.IDictionary<System.String,System.Object> product, bool isWindows) { }

	// RVA: 0x7415F0
	System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x741048
	Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x74476C
	System.Collections.Generic.IList<Facebook.Unity.Subscription> ParseSubscriptionsFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x7441CC
	Subscription ParseSubscriptionFromResult(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary) { }

	// RVA: 0x747DF4
	Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> purchase, bool isWindows) { }

	// RVA: 0x748A54
	Subscription ParseSubscriptionFromDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> subscription, bool isWindows) { }

	// RVA: 0x7425C4
	System.Collections.Generic.IDictionary<System.String,System.String> ParseStringDictionaryFromString(string input) { }

	// RVA: 0x740720
	System.Collections.Generic.IDictionary<System.String,System.String> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> resultDictionary, string key) { }

	// RVA: 0x73BEB0
	DateTime FromTimestamp(int timestamp) { }

}

// Namespace: Facebook.Unity
internal static class FBUnityUtility 
{
	// Fields
	private static IAsyncRequestStringWrapper asyncRequestStringWrapper; // 0x0

	// Methods

	// RVA: 0x739378
	IAsyncRequestStringWrapper get_AsyncRequestStringWrapper() { }

}

// Namespace: Facebook.Unity
internal class AsyncRequestStringWrapper 
{
	// Methods

	// RVA: 0x749368
	void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x749408
	void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: 0x749360
	void .ctor() { }

}

// Namespace: Facebook.Unity
internal interface IAsyncRequestStringWrapper 
{
	// Methods

	// RVA: -1
	void Request(Uri url, HttpMethod method, WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

	// RVA: -1
	void Request(Uri url, HttpMethod method, System.Collections.Generic.IDictionary<System.String,System.String> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback) { }

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

	// RVA: 0x7495BC
	void .ctor(int <>1__state) { }

	// RVA: 0x7495F0
	void System.IDisposable.Dispose() { }

	// RVA: 0x7495F4
	bool MoveNext() { }

	// RVA: 0x7496D0
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7496D8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x749718
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
internal class FacebookScheduler 
{
	// Methods

	// RVA: 0x7494A8
	void Schedule(Action action, Int64 delay) { }

	// RVA: 0x74953C
	IEnumerator DelayEvent(Action action, Int64 delay) { }

	// RVA: 0x7495E8
	void .ctor() { }

}

// Namespace: Facebook.Unity
public interface IHasLicenseResult 
{}

// Namespace: Facebook.Unity
internal class CodelessIAPAutoLog 
{
	// Methods

	// RVA: 0x749720
	void handlePurchaseCompleted(object data) { }

	// RVA: 0x749EA0
	void addListenerToIAPButtons(object listenerObject) { }

	// RVA: 0x74A078
	void addListenerToGameObject(object gameObject, object listenerObject) { }

	// RVA: 0x74A468
	Type FindTypeInAssemblies(string typeName, string nameSpace) { }

	// RVA: 0x749FD4
	object[] FindObjectsOfTypeByName(string typeName, string nameSpace) { }

	// RVA: 0x74A5C4
	object GetField(object inObj, string fieldName) { }

	// RVA: 0x749E3C
	object GetProperty(object inObj, string propertyName) { }

}

// Namespace: 
private sealed class <GenSnapshot>d__4 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Methods

	// RVA: 0x74A9B0
	void .ctor(int <>1__state) { }

	// RVA: 0x74BFC4
	void System.IDisposable.Dispose() { }

	// RVA: 0x74BFC8
	bool MoveNext() { }

	// RVA: 0x74C230
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x74C238
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x74C278
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Facebook.Unity
public class CodelessCrawler 
{
	// Fields
	private static bool isGeneratingSnapshot; // 0x0
	private static Camera mainCamera; // 0x8

	// Methods

	// RVA: 0x74A624
	void Awake() { }

	// RVA: 0x74A6D4
	void CaptureViewHierarchy(string message) { }

	// RVA: 0x74A954
	IEnumerator GenSnapshot() { }

	// RVA: 0x74A9DC
	void SendAndroid(string json) { }

	// RVA: 0x74ABE8
	void SendIos(string json) { }

	// RVA: 0x74ABEC
	string GenBase64Screenshot() { }

	// RVA: 0x74AD2C
	string GenViewJson() { }

	// RVA: 0x74B15C
	void GenChild(GameObject curObj, StringBuilder builder) { }

	// RVA: 0x74BED4
	void onActiveSceneChanged(Scene arg0, Scene arg1) { }

	// RVA: 0x74A8B8
	void updateMainCamera() { }

	// RVA: 0x74BC98
	Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode) { }

	// RVA: 0x74BDCC
	string getClasstypeBitmaskButton() { }

	// RVA: 0x74BE54
	string getVisibility(GameObject gameObj) { }

	// RVA: 0x74BFB8
	void .ctor() { }

	// RVA: 0x74BFC0
	void .cctor() { }

}

// Namespace: Facebook.Unity
public class CodelessUIInteractEvent 
{
	// Fields
	private FBSDKEventBindingManager <eventBindingManager>k__BackingField; // 0x20

	// Methods

	// RVA: 0x74C280
	FBSDKEventBindingManager get_eventBindingManager() { }

	// RVA: 0x74C288
	void set_eventBindingManager(FBSDKEventBindingManager value) { }

	// RVA: 0x74C290
	void Awake() { }

	// RVA: 0x74C2B4
	void SetLoggerInitAndroid() { }

	// RVA: 0x74C3FC
	void SetLoggerInitIos() { }

	// RVA: 0x74C400
	void OnReceiveMapping(string message) { }

	// RVA: 0x74C7E8
	void .ctor() { }

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

	// RVA: 0x74C7F0
	void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x74CC4C
	string get_className() { }

	// RVA: 0x74CC54
	void set_className(string value) { }

	// RVA: 0x74CC5C
	void set_text(string value) { }

	// RVA: 0x74CC64
	void set_hint(string value) { }

	// RVA: 0x74CC6C
	void set_desc(string value) { }

	// RVA: 0x74CC74
	void set_tag(string value) { }

	// RVA: 0x74CC7C
	void set_index(Int64 value) { }

	// RVA: 0x74CC84
	void set_section(Int64 value) { }

	// RVA: 0x74CC8C
	void set_row(Int64 value) { }

	// RVA: 0x74CC94
	void set_matchBitmask(Int64 value) { }

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

	// RVA: 0x74CC9C
	void .ctor(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x74D19C
	string get_eventName() { }

	// RVA: 0x74D1A4
	void set_eventName(string value) { }

	// RVA: 0x74D1AC
	string get_eventType() { }

	// RVA: 0x74D1B4
	void set_eventType(string value) { }

	// RVA: 0x74D1BC
	string get_appVersion() { }

	// RVA: 0x74D1C4
	void set_appVersion(string value) { }

	// RVA: 0x74D1CC
	System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path() { }

	// RVA: 0x74D1D4
	void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value) { }

}

// Namespace: Facebook.Unity
public class FBSDKEventBindingManager 
{
	// Fields
	private System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField; // 0x10

	// Methods

	// RVA: 0x74D1DC
	System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings() { }

	// RVA: 0x74D1E4
	void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value) { }

	// RVA: 0x74C508
	void .ctor(System.Collections.Generic.List<System.Object> listDict) { }

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

	// RVA: 0x74D1EC
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74D2E8
	string get_MediaId() { }

	// RVA: 0x74D2F0
	void set_MediaId(string value) { }

	// RVA: 0x74D2F8
	string ToString() { }

}

// Namespace: Facebook.Unity
public interface ISessionScoreResult 
{}

// Namespace: Facebook.Unity
internal class SessionScoreResult 
{
	// Methods

	// RVA: 0x74D3F0
	void .ctor(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity
public class AuthenticationToken 
{
	// Fields
	private string <TokenString>k__BackingField; // 0x10
	private string <Nonce>k__BackingField; // 0x18

	// Methods

	// RVA: 0x746BA8
	void .ctor(string tokenString, string nonce) { }

	// RVA: 0x74D3F4
	string get_TokenString() { }

	// RVA: 0x74D3FC
	void set_TokenString(string value) { }

	// RVA: 0x74D404
	string get_Nonce() { }

	// RVA: 0x74D40C
	void set_Nonce(string value) { }

	// RVA: 0x74D414
	string ToString() { }

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

	// RVA: 0x74D528
	void .ctor(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, UserAgeRange ageRange, FBLocation hometown, FBLocation location, string gender) { }

	// RVA: 0x74D78C
	string get_UserID() { }

	// RVA: 0x74D794
	void set_UserID(string value) { }

	// RVA: 0x74D79C
	string get_FirstName() { }

	// RVA: 0x74D7A4
	void set_FirstName(string value) { }

	// RVA: 0x74D7AC
	string get_MiddleName() { }

	// RVA: 0x74D7B4
	void set_MiddleName(string value) { }

	// RVA: 0x74D7BC
	string get_LastName() { }

	// RVA: 0x74D7C4
	void set_LastName(string value) { }

	// RVA: 0x74D7CC
	string get_Name() { }

	// RVA: 0x74D7D4
	void set_Name(string value) { }

	// RVA: 0x74D7DC
	string get_Email() { }

	// RVA: 0x74D7E4
	void set_Email(string value) { }

	// RVA: 0x74D7EC
	string get_ImageURL() { }

	// RVA: 0x74D7F4
	void set_ImageURL(string value) { }

	// RVA: 0x74D7FC
	string get_LinkURL() { }

	// RVA: 0x74D804
	void set_LinkURL(string value) { }

	// RVA: 0x74D80C
	string[] get_FriendIDs() { }

	// RVA: 0x74D814
	void set_FriendIDs(string[] value) { }

	// RVA: 0x74D81C
	System.Nullable<System.DateTime> get_Birthday() { }

	// RVA: 0x74D828
	void set_Birthday(System.Nullable<System.DateTime> value) { }

	// RVA: 0x74D830
	UserAgeRange get_AgeRange() { }

	// RVA: 0x74D838
	void set_AgeRange(UserAgeRange value) { }

	// RVA: 0x74D840
	FBLocation get_Hometown() { }

	// RVA: 0x74D848
	void set_Hometown(FBLocation value) { }

	// RVA: 0x74D850
	FBLocation get_Location() { }

	// RVA: 0x74D858
	void set_Location(FBLocation value) { }

	// RVA: 0x74D860
	string get_Gender() { }

	// RVA: 0x74D868
	void set_Gender(string value) { }

	// RVA: 0x74D870
	string ToString() { }

}

// Namespace: Facebook.Unity
public class UserAgeRange 
{
	// Fields
	private Int64 <Min>k__BackingField; // 0x10
	private Int64 <Max>k__BackingField; // 0x18

	// Methods

	// RVA: 0x74DD34
	void .ctor(Int64 min, Int64 max) { }

	// RVA: 0x74DD6C
	Int64 get_Min() { }

	// RVA: 0x74DD74
	void set_Min(Int64 value) { }

	// RVA: 0x74DD7C
	Int64 get_Max() { }

	// RVA: 0x74DD84
	void set_Max(Int64 value) { }

	// RVA: 0x74DD8C
	UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x74DF7C
	string ToString() { }

}

// Namespace: Facebook.Unity
public class FBLocation 
{
	// Fields
	private string <ID>k__BackingField; // 0x10
	private string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x74E0C4
	void .ctor(string id, string name) { }

	// RVA: 0x74E114
	string get_ID() { }

	// RVA: 0x74E11C
	void set_ID(string value) { }

	// RVA: 0x74E124
	string get_Name() { }

	// RVA: 0x74E12C
	void set_Name(string value) { }

	// RVA: 0x74E134
	FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<System.String,System.String> dictionary) { }

	// RVA: 0x74E31C
	string ToString() { }

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

	// RVA: 0x74E430
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74E644
	string get_TournamentId() { }

	// RVA: 0x74E64C
	void set_TournamentId(string value) { }

	// RVA: 0x74E654
	string get_ContextId() { }

	// RVA: 0x74E65C
	void set_ContextId(string value) { }

	// RVA: 0x74E664
	int get_EndTime() { }

	// RVA: 0x74E66C
	void set_EndTime(int value) { }

	// RVA: 0x74E674
	string get_TournamentTitle() { }

	// RVA: 0x74E67C
	void set_TournamentTitle(string value) { }

	// RVA: 0x74E684
	System.Collections.Generic.IDictionary<System.String,System.String> get_Payload() { }

	// RVA: 0x74E68C
	void set_Payload(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x74E694
	string ToString() { }

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

	// RVA: 0x74EC6C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F144
	void set_Tournaments(TournamentResult[] value) { }

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

	// RVA: 0x74F14C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F170
	void set_Success(bool value) { }

}

// Namespace: Facebook.Unity
public interface ITournamentScoreResult 
{}

// Namespace: Facebook.Unity
internal class TournamentScoreResult 
{
	// Methods

	// RVA: 0x74F178
	void .ctor(ResultContainer resultContainer) { }

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

	// RVA: 0x74F17C
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F240
	string get_ContextId() { }

	// RVA: 0x74F248
	void set_ContextId(string value) { }

	// RVA: 0x74F250
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class CreateGamingContextResult 
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x74F348
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F40C
	string get_ContextId() { }

	// RVA: 0x74F414
	void set_ContextId(string value) { }

	// RVA: 0x74F41C
	string ToString() { }

}

// Namespace: Facebook.Unity
internal class SwitchGamingContextResult 
{
	// Fields
	private string <ContextId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x74F514
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F5D8
	string get_ContextId() { }

	// RVA: 0x74F5E0
	void set_ContextId(string value) { }

	// RVA: 0x74F5E8
	string ToString() { }

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

	// RVA: 0x74F6E0
	void .ctor(ResultContainer resultContainer) { }

	// RVA: 0x74F7A4
	string get_ContextId() { }

	// RVA: 0x74F7AC
	void set_ContextId(string value) { }

	// RVA: 0x74F7B4
	string ToString() { }

}

// Namespace: Facebook.Unity.Windows
internal sealed class WindowsFacebook 
{
	// Fields
	private string appId; // 0x28
	private IWindowsWrapper windowsWrapper; // 0x30
	private bool <LimitEventUsage>k__BackingField; // 0x38

	// Methods

	// RVA: 0x74F8AC
	void .ctor() { }

	// RVA: 0x74FA64
	void .ctor(IWindowsWrapper windowsWrapper, CallbackManager callbackManager) { }

	// RVA: 0x74FAB4
	bool get_LimitEventUsage() { }

	// RVA: 0x74FABC
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x74FAC4
	string get_SDKName() { }

	// RVA: 0x74FB08
	string get_SDKVersion() { }

	// RVA: 0x736938
	void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x74FB4C
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x74FC40
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x74FD34
	void LogOut() { }

	// RVA: 0x74FDEC
	bool get_LoggedIn() { }

	// RVA: 0x74FEA4
	void ActivateApp(string appId) { }

	// RVA: 0x74FF50
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7502C0
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x750400
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x7504EC
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x7505D8
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7506DC
	void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7507D0
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x750810
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x750850
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x750890
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x7508D0
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x7509BC
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x750AB0
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x750BA4
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x750C98
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x750D8C
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x750E78
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x750F64
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x751058
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x75118C
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x751280
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x751374
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x751460
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x751564
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7516A4
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7517C0
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x7518DC
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x751A0C
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x751B3C
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x74F9A8
	IWindowsWrapper GetWindowsWrapper() { }

	// RVA: 0x751C28
	void Tick() { }

	// RVA: 0x751CE0
	void Deinit() { }

	// RVA: 0x751D98
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x751DD8
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x751E18
	void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x751E58
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x751E98
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x751ED8
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x751F18
	void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x751F58
	void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x751F98
	Profile CurrentProfile() { }

}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsFacebookImplementation 
{
	// Methods

	// RVA: 0x2FE41A8
	void Tick() { }

	// RVA: 0x2FE41A8
	void Deinit() { }

}

// Namespace: Facebook.Unity.Windows
internal interface IWindowsWrapper 
{
	// Methods

	// RVA: -1
	bool Init(string appId, string clientToken) { }

	// RVA: 0x2FE49A8
	void LogInWithScopes(System.Collections.Generic.IEnumerable<System.String> scope, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE3054
	bool IsLoggedIn() { }

	// RVA: 0x2FE41A8
	void LogOut() { }

	// RVA: 0x2FE41A8
	void Tick() { }

	// RVA: 0x2FE41A8
	void Deinit() { }

	// RVA: 0x2FE47D4
	void GetCatalog(string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void GetPurchases(string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE4A14
	void Purchase(string productID, string developerPayload, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void ConsumePurchase(string productToken, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void CurrentProfile(string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void LoadInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void ShowInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void LoadRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void ShowRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void OpenFriendFinderDialog(string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void GetFriendFinderInvitations(string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE49A8
	void DeleteFriendFinderInvitation(string invitationId, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void PostSessionScore(int score, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void PostTournamentScore(int score, string callbackId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void GetTournament(string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, string callbackId, CallbackManager callbackManager) { }

	// RVA: -1
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager) { }

	// RVA: -1
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager) { }

	// RVA: 0x2FE47D4
	void GetUserLocale(string callbackId, CallbackManager callbackManager) { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookLoader 
{
	// Methods

	// RVA: 0x751FD8
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x752090
	void .ctor() { }

}

// Namespace: Facebook.Unity.Windows
internal class WindowsFacebookGameObject 
{
	// Methods

	// RVA: 0x752098
	IWindowsFacebookImplementation get_WindowsFacebookImpl() { }

	// RVA: 0x752114
	void OnAwake() { }

	// RVA: 0x752118
	void Update() { }

	// RVA: 0x752230
	void OnDestroy() { }

	// RVA: 0x75234C
	void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebook 
{
	// Fields
	private IEditorWrapper editorWrapper; // 0x28
	private bool <LimitEventUsage>k__BackingField; // 0x30

	// Methods

	// RVA: 0x752354
	void .ctor(IEditorWrapper wrapper, CallbackManager callbackManager) { }

	// RVA: 0x7523A4
	void .ctor() { }

	// RVA: 0x752544
	bool get_LimitEventUsage() { }

	// RVA: 0x75254C
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x752554
	string get_SDKName() { }

	// RVA: 0x752598
	string get_SDKVersion() { }

	// RVA: 0x7524FC
	IFacebookCallbackHandler get_EditorGameObject() { }

	// RVA: 0x7525DC
	void Init(InitDelegate onInitComplete) { }

	// RVA: 0x7526F0
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x752700
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x7528B0
	void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x752A60
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x752B7C
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x752CB4
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x752DEC
	void ActivateApp(string appId) { }

	// RVA: 0x752E78
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x752FDC
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x753068
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7530F4
	bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7530FC
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x753104
	Profile CurrentProfile() { }

	// RVA: 0x75310C
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x75314C
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x75346C
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7534E0
	void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x753554
	void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x7535CC
	void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x753640
	void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x7536B4
	void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x7533F8
	void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x753728
	void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x75379C
	void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x753810
	void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x753884
	void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x7538F8
	void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x75396C
	void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x7539E0
	void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x753A54
	void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x753AC8
	void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x753B3C
	void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x753BB0
	void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x753C24
	void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x753C98
	void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x753D0C
	void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x753D80
	void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x753DF4
	void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x753E68
	void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x753EDC
	void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x753F50
	void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x753FC4
	void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x754038
	void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x7540AC
	void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x754120
	void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x754194
	void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x754208
	void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x75427C
	void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x7542F0
	void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x754364
	void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x7543D8
	void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x754450
	void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x7544C8
	void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x75453C
	void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x7545B0
	void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x754624
	void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x754698
	void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x75470C
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x754844
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x754884
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x7548C4
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x754A5C
	void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x754BF4
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x754C34
	void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x754D58
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x754E7C
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x754FA0
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x7550C4
	void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x7551E8
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x75530C
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x755430
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x755554
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x755678
	void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x75579C
	void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7558C0
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7559E4
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x755B08
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x755C2C
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x755D50
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x755E74
	void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x755F98
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x7560BC
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x7561E0
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7563DC
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x756500
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x7566FC
	void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x756820
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x756944
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x756A68
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x756B8C
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x756CB0
	void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x756CF0
	void OnUrlResponse(string message) { }

	// RVA: 0x756D30
	void OnHideUnity(bool hidden) { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookGameObject 
{
	// Methods

	// RVA: 0x75AEE0
	void OnAwake() { }

	// RVA: 0x75AEE8
	void OnEnable() { }

	// RVA: 0x75AF98
	void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x75AFA0
	void OnDisable() { }

	// RVA: 0x75B050
	void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x75B05C
	void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorFacebookLoader 
{
	// Methods

	// RVA: 0x75B064
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x75B100
	void .ctor() { }

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

	// RVA: 0x75B108
	Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback() { }

	// RVA: 0x75B110
	void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value) { }

	// RVA: 0x75B118
	string get_CallbackID() { }

	// RVA: 0x75B120
	void set_CallbackID(string value) { }

	// RVA: 0x2FE360C
	string get_DialogTitle() { }

	// RVA: 0x75B128
	void Start() { }

	// RVA: 0x75B254
	void OnGUI() { }

	// RVA: 0x2FE41A8
	void DoGui() { }

	// RVA: 0x2FE41A8
	void SendSuccessResult() { }

	// RVA: 0x75B364
	void SendCancelResult() { }

	// RVA: 0x75B4E4
	void SendErrorResult(string errorMessage) { }

	// RVA: 0x75B634
	void OnGUIDialog(int windowId) { }

	// RVA: 0x75BA54
	void .ctor() { }

}

// Namespace: Facebook.Unity.Editor
internal class EditorWrapper 
{
	// Fields
	private IFacebookCallbackHandler callbackHandler; // 0x10

	// Methods

	// RVA: 0x75BA5C
	void .ctor(IFacebookCallbackHandler callbackHandler) { }

	// RVA: 0x75BA90
	void Init() { }

	// RVA: 0x75BB6C
	void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions) { }

	// RVA: 0x75BBEC
	void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x75BD74
	void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x75BE10
	void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x75BCD8
	void ShowEmptyMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string title) { }

}

// Namespace: Facebook.Unity.Editor
internal interface IEditorWrapper 
{
	// Methods

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE49A8
	void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permissions) { }

	// RVA: 0x2FE47D4
	void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId) { }

	// RVA: 0x2FE49A8
	void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

	// RVA: 0x2FE49A8
	void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class EmptyMockDialog 
{
	// Fields
	private string <EmptyDialogTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x75BEAC
	string get_EmptyDialogTitle() { }

	// RVA: 0x75BEB4
	void set_EmptyDialogTitle(string value) { }

	// RVA: 0x75BEBC
	string get_DialogTitle() { }

	// RVA: 0x75BEC4
	void DoGui() { }

	// RVA: 0x75BEC8
	void SendSuccessResult() { }

	// RVA: 0x75C038
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public MockLoginDialog <>4__this; // 0x10
	public string graphDomain; // 0x18

	// Methods

	// RVA: 0x75C650
	void .ctor() { }

	// RVA: 0x75C6C4
	void <SendSuccessResult>b__0(IGraphResult graphResult) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_1 
{
	// Fields
	public string facebookID; // 0x10
	public Facebook.Unity.Editor.Dialogs.MockLoginDialog.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x75CA64
	void .ctor() { }

	// RVA: 0x75CA6C
	void <SendSuccessResult>b__1(IGraphResult permResult) { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockLoginDialog 
{
	// Fields
	private string accessToken; // 0x48

	// Methods

	// RVA: 0x75C040
	string get_DialogTitle() { }

	// RVA: 0x75C084
	void DoGui() { }

	// RVA: 0x75C2E4
	void SendSuccessResult() { }

	// RVA: 0x75C658
	void .ctor() { }

}

// Namespace: Facebook.Unity.Editor.Dialogs
internal class MockShareDialog 
{
	// Fields
	private string <SubTitle>k__BackingField; // 0x48

	// Methods

	// RVA: 0x75D46C
	string get_SubTitle() { }

	// RVA: 0x75D474
	void set_SubTitle(string value) { }

	// RVA: 0x75D47C
	string get_DialogTitle() { }

	// RVA: 0x75D4EC
	void DoGui() { }

	// RVA: 0x75D4F0
	void SendSuccessResult() { }

	// RVA: 0x75D9A8
	void SendCancelResult() { }

	// RVA: 0x75D6C8
	string GenerateFakePostID() { }

	// RVA: 0x75DAF0
	void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebook 
{
	// Methods

	// RVA: 0x2FE4A14
	void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x2FE4574
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x2FE3054
	bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x2FE4574
	void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x2FE4574
	void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x2FE4574
	void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x2FE4574
	void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x2FE4574
	void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x2FE47D4
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x2FE47D4
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: -1
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x2FE4574
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x2FE360C
	AuthenticationToken CurrentAuthenticationToken() { }

}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookImplementation 
{}

// Namespace: Facebook.Unity.Mobile
internal interface IMobileFacebookResultHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebook 
{
	// Methods

	// RVA: 0x75DAF8
	void .ctor(CallbackManager callbackManager) { }

	// RVA: 0x2FE360C
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x75DB00
	Profile CurrentProfile() { }

	// RVA: 0x75DB40
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x2FE4A14
	void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x2FE4574
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x2FE3054
	bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x75DB80
	void OnLoginComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DBFC
	void OnGetAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DC78
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DCF4
	void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DD70
	void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DDEC
	void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DEB8
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x75DEF8
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x75DF38
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x75DF78
	void OnFriendFinderComplete(ResultContainer resultContainer) { }

	// RVA: 0x75DFF4
	void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E070
	void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E0EC
	void OnOnIAPReadyComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E168
	void OnGetCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E1E4
	void OnGetPurchasesComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E260
	void OnPurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E2DC
	void OnConsumePurchaseComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E358
	void OnGetSubscribableCatalogComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E3D4
	void OnGetSubscriptionsComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E450
	void OnPurchaseSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E4CC
	void OnCancelSubscriptionComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E548
	void OnInitCloudGameComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E5C4
	void OnGameLoadCompleteComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E640
	void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E6BC
	void OnLoadInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E738
	void OnShowInterstitialAdComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E7B4
	void OnLoadRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E830
	void OnShowRewardedVideoComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E8AC
	void OnGetPayloadComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E928
	void OnPostSessionScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x75E9A4
	void OnPostTournamentScoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EA20
	void OnGetTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EA9C
	void OnShareTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EB18
	void OnCreateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EB94
	void OnGetTournamentsComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EC10
	void OnUpdateTournamentComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EC8C
	void OnTournamentDialogSuccess(ResultContainer resultContainer) { }

	// RVA: 0x75ED08
	void OnTournamentDialogError(ResultContainer resultContainer) { }

	// RVA: 0x75ED84
	void OnTournamentDialogCancel(ResultContainer resultContainer) { }

	// RVA: 0x75EE00
	void OnOpenAppStoreComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EE7C
	void OnCreateGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EEF8
	void OnSwitchGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EF74
	void OnChooseGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x75EFF0
	void OnGetCurrentGamingContextComplete(ResultContainer resultContainer) { }

	// RVA: 0x75F06C
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75F0AC
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x75F0EC
	void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x75F12C
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x75F16C
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x75F1AC
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x75F1EC
	void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x75F22C
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x75F26C
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x75F2AC
	void PurchaseSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x75F2EC
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x75F32C
	void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x75F36C
	void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x75F3AC
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x75F3EC
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75F42C
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x75F46C
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75F4AC
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x75F4EC
	void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x75F52C
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x75F56C
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75F5AC
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75F5EC
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x75F62C
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x75F66C
	void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x75F6AC
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x75F6EC
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x75F72C
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x75F76C
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

}

// Namespace: Facebook.Unity.Mobile
internal abstract class MobileFacebookGameObject 
{
	// Methods

	// RVA: 0x75F7AC
	IMobileFacebookImplementation get_MobileFacebook() { }

	// RVA: 0x75F828
	void OnFetchDeferredAppLinkComplete(string message) { }

	// RVA: 0x75F970
	void OnRefreshCurrentAccessTokenComplete(string message) { }

	// RVA: 0x75FABC
	void OnFriendFinderComplete(string message) { }

	// RVA: 0x75FC08
	void OnUploadImageToMediaLibraryComplete(string message) { }

	// RVA: 0x75FD54
	void OnUploadVideoToMediaLibraryComplete(string message) { }

	// RVA: 0x75FEA0
	void OnOnIAPReadyComplete(string message) { }

	// RVA: 0x75FFEC
	void OnGetCatalogComplete(string message) { }

	// RVA: 0x760138
	void OnGetPurchasesComplete(string message) { }

	// RVA: 0x760284
	void OnPurchaseComplete(string message) { }

	// RVA: 0x7603D0
	void OnConsumePurchaseComplete(string message) { }

	// RVA: 0x76051C
	void OnGetSubscribableCatalogComplete(string message) { }

	// RVA: 0x760668
	void OnGetSubscriptionsComplete(string message) { }

	// RVA: 0x7607B4
	void OnPurchaseSubscriptionComplete(string message) { }

	// RVA: 0x760900
	void OnCancelSubscriptionComplete(string message) { }

	// RVA: 0x760A4C
	void OnInitCloudGameComplete(string message) { }

	// RVA: 0x760B98
	void OnGameLoadCompleteComplete(string message) { }

	// RVA: 0x760CE4
	void OnScheduleAppToUserNotificationComplete(string message) { }

	// RVA: 0x760E30
	void OnLoadInterstitialAdComplete(string message) { }

	// RVA: 0x760F7C
	void OnShowInterstitialAdComplete(string message) { }

	// RVA: 0x7610C8
	void OnLoadRewardedVideoComplete(string message) { }

	// RVA: 0x761214
	void OnShowRewardedVideoComplete(string message) { }

	// RVA: 0x761360
	void OnGetPayloadComplete(string message) { }

	// RVA: 0x7614AC
	void OnPostSessionScoreComplete(string message) { }

	// RVA: 0x7615F8
	void OnPostTournamentScoreComplete(string message) { }

	// RVA: 0x761744
	void OnGetTournamentComplete(string message) { }

	// RVA: 0x761890
	void OnShareTournamentComplete(string message) { }

	// RVA: 0x7619DC
	void OnCreateTournamentComplete(string message) { }

	// RVA: 0x761B28
	void OnGetTournamentsComplete(string message) { }

	// RVA: 0x761C74
	void OnUpdateTournamentComplete(string message) { }

	// RVA: 0x761DC0
	void OnTournamentDialogSuccess(string message) { }

	// RVA: 0x761F0C
	void OnTournamentDialogCancel(string message) { }

	// RVA: 0x762058
	void OnTournamentDialogError(string message) { }

	// RVA: 0x7621A4
	void OnOpenAppStoreComplete(string message) { }

	// RVA: 0x7622F0
	void OnCreateGamingContextComplete(string message) { }

	// RVA: 0x76243C
	void OnSwitchGamingContextComplete(string message) { }

	// RVA: 0x762588
	void OnChooseGamingContextComplete(string message) { }

	// RVA: 0x7626D4
	void OnGetCurrentGamingContextComplete(string message) { }

	// RVA: 0x762820
	void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal interface IIOSWrapper 
{
	// Methods

	// RVA: -1
	void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x2FE440C
	void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x2FE440C
	void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: -1
	void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x2FE41A8
	void LogOut() { }

	// RVA: -1
	void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: -1
	void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: -1
	void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x2FE41A8
	void FBAppEventsActivateApp() { }

	// RVA: -1
	void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: -1
	void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x2FE4234
	void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x2FE42A4
	void GetAppLink(int requestId) { }

	// RVA: 0x2FE42A4
	void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x2FE360C
	string FBSdkVersion() { }

	// RVA: 0x2FE360C
	string FBGetUserID() { }

	// RVA: 0x2FE42A4
	void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x2FE440C
	void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x2FE440C
	void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x2FE42A4
	void GetCurrentGamingContext(int requestId) { }

	// RVA: -1
	void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: -1
	void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog) { }

	// RVA: -1
	void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x2FE360C
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x2FE360C
	Profile CurrentProfile() { }

}

// Namespace: 
private class NativeDict 
{
	// Fields
	private int <NumEntries>k__BackingField; // 0x10
	private string[] <Keys>k__BackingField; // 0x18
	private string[] <Values>k__BackingField; // 0x20

	// Methods

	// RVA: 0x764E54
	void .ctor() { }

	// RVA: 0x764E98
	int get_NumEntries() { }

	// RVA: 0x764EA0
	void set_NumEntries(int value) { }

	// RVA: 0x764EA8
	string[] get_Keys() { }

	// RVA: 0x764EB0
	void set_Keys(string[] value) { }

	// RVA: 0x764EB8
	string[] get_Values() { }

	// RVA: 0x764EC0
	void set_Values(string[] value) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebook 
{
	// Fields
	private bool limitEventUsage; // 0x28
	private IIOSWrapper iosWrapper; // 0x30
	private string userID; // 0x38

	// Methods

	// RVA: 0x762828
	void .ctor() { }

	// RVA: 0x762968
	void .ctor(IIOSWrapper iosWrapper, CallbackManager callbackManager) { }

	// RVA: 0x7629A0
	bool get_LimitEventUsage() { }

	// RVA: 0x7629A8
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x762A64
	string get_SDKName() { }

	// RVA: 0x762AA8
	string get_SDKVersion() { }

	// RVA: 0x762B60
	void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x762CD0
	void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x762DE8
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x762EE8
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x762FE8
	void LogOut() { }

	// RVA: 0x7630AC
	bool get_LoggedIn() { }

	// RVA: 0x763188
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x763240
	Profile CurrentProfile() { }

	// RVA: 0x7632F8
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76372C
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76385C
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x763A74
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7640E4
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x7641D8
	bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x7641E0
	void ActivateApp(string appId) { }

	// RVA: 0x764298
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x7643B0
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x7644C8
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x764508
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x764548
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x764668
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x764788
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x764934
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x764A4C
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x764B64
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x764CC0
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x764E14
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x7628AC
	IIOSWrapper GetIOSWrapper() { }

	// RVA: 0x763C60
	NativeDict MarshallDict(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x2FE3404
	int AddCallback(Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookGameObject 
{
	// Methods

	// RVA: 0x764EC8
	void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.IOS
internal class IOSFacebookLoader 
{
	// Methods

	// RVA: 0x764ED0
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x764FF4
	void .ctor() { }

}

// Namespace: 
private class JavaMethodCall<T0> 
{
	// Fields
	private AndroidFacebook androidImpl; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(AndroidFacebook androidImpl, string methodName) { }

	// RVA: 0x2FE4574
	void Call(MethodArguments args) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Facebook.Unity.Mobile.Android.AndroidFacebook.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__73_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Object> <>9__73_1; // 0x10
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__74_0; // 0x18
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Object> <>9__74_1; // 0x20

	// Methods

	// RVA: 0x769D50
	void .cctor() { }

	// RVA: 0x769DBC
	void .ctor() { }

	// RVA: 0x769DC4
	string <CreateTournament>b__73_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x769E8C
	object <CreateTournament>b__73_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x769F58
	string <ShareTournament>b__74_0(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

	// RVA: 0x76A020
	object <ShareTournament>b__74_1(System.Collections.Generic.KeyValuePair<System.String,System.String> pair) { }

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

	// RVA: 0x764FFC
	void .ctor() { }

	// RVA: 0x765184
	void .ctor(IAndroidWrapper androidWrapper, CallbackManager callbackManager) { }

	// RVA: 0x765214
	void set_KeyHash(string value) { }

	// RVA: 0x76521C
	bool get_LimitEventUsage() { }

	// RVA: 0x765224
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x7653F4
	string get_SDKName() { }

	// RVA: 0x765438
	string get_SDKVersion() { }

	// RVA: 0x765518
	void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x765780
	void LoginWithTrackingPreference(string tracking, System.Collections.Generic.IEnumerable<System.String> permissions, string nonce, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x765840
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x765970
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x765AA0
	void LogOut() { }

	// RVA: 0x765B5C
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x765E70
	Profile CurrentProfile() { }

	// RVA: 0x766730
	void OnLoginStatusRetrieved(ResultContainer resultContainer) { }

	// RVA: 0x7667AC
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x766B04
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x766CC8
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x766F08
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x766FD8
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x767288
	void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x767440
	bool IsImplicitPurchaseLoggingEnabled() { }

	// RVA: 0x767520
	void ActivateApp(string appId) { }

	// RVA: 0x767578
	void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback) { }

	// RVA: 0x767648
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x767718
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x767758
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x767798
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x767964
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x767AC8
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x767B08
	void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback) { }

	// RVA: 0x767BD8
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x767CA8
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x767D78
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x767EDC
	void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x76800C
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x7680DC
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x7681AC
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x7682DC
	void CancelSubscription(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x76840C
	void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback) { }

	// RVA: 0x7684DC
	void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback) { }

	// RVA: 0x7685AC
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x7687B8
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x7688E8
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x768A18
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x768B48
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x768C78
	void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback) { }

	// RVA: 0x768D48
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x768E88
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x768FC8
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x769098
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x769448
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x769754
	void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback) { }

	// RVA: 0x769824
	void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback) { }

	// RVA: 0x769954
	void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback) { }

	// RVA: 0x769A84
	void ChooseGamingContext(System.Collections.Generic.List<System.String> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback) { }

	// RVA: 0x769C50
	void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback) { }

	// RVA: 0x7650C8
	IAndroidWrapper GetAndroidWrapper() { }

	// RVA: 0x7652C4
	void CallFB(string method, string args) { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookGameObject 
{
	// Methods

	// RVA: 0x76A0EC
	void OnAwake() { }

	// RVA: 0x76A0F4
	void OnEnable() { }

	// RVA: 0x76A1A4
	void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x76A1AC
	void OnDisable() { }

	// RVA: 0x76A25C
	void onPurchaseCompleteHandler(object data) { }

	// RVA: 0x76A268
	void OnLoginStatusRetrieved(string message) { }

	// RVA: 0x76A35C
	void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal class AndroidFacebookLoader 
{
	// Methods

	// RVA: 0x76A364
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x76A41C
	void .ctor() { }

}

// Namespace: Facebook.Unity.Mobile.Android
internal interface IAndroidWrapper 
{
	// Methods

	// RVA: 0x309AF8C
	T CallStatic(string methodName) { }

	// RVA: 0x2FE47D4
	void CallStatic(string methodName, object[] args) { }

}

// Namespace: 
private class CanvasUIMethodCall<T0> 
{
	// Fields
	private CanvasFacebook canvasImpl; // 0x0
	private string callbackMethod; // 0x0

	// Methods

	// RVA: 0x2FE49A8
	void .ctor(CanvasFacebook canvasImpl, string methodName, string callbackMethod) { }

	// RVA: 0x2FE4574
	void Call(MethodArguments args) { }

	// RVA: 0x2FE49A8
	void UI(string method, MethodArguments args, Facebook.Unity.FacebookDelegate<T> callback) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Facebook.Unity.Canvas.CanvasFacebook.<>c <>9; // 0x0
	public static Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <>9__40_0; // 0x8

	// Methods

	// RVA: 0x76D180
	void .cctor() { }

	// RVA: 0x76D1EC
	void .ctor() { }

	// RVA: 0x76D1F4
	void <OnFacebookAuthResponseChange>b__40_0(ResultContainer formattedResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass47_0 
{
	// Fields
	public ResultContainer result; // 0x10
	public Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback; // 0x18

	// Methods

	// RVA: 0x76CA7C
	void .ctor() { }

	// RVA: 0x76D2A4
	void <FormatAuthResponse>b__0(IGraphResult r) { }

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

	// RVA: 0x76A424
	void .ctor() { }

	// RVA: 0x76A564
	void .ctor(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager) { }

	// RVA: 0x76A4A8
	ICanvasJSWrapper GetCanvasJSWrapper() { }

	// RVA: 0x76A59C
	bool get_LimitEventUsage() { }

	// RVA: 0x76A5A4
	void set_LimitEventUsage(bool value) { }

	// RVA: 0x76A5AC
	string get_SDKName() { }

	// RVA: 0x76A5F0
	string get_SDKVersion() { }

	// RVA: 0x76A6A4
	string get_SDKUserAgent() { }

	// RVA: 0x76A954
	void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete) { }

	// RVA: 0x76AD84
	void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x76AEF0
	void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<System.String> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback) { }

	// RVA: 0x76B05C
	void LogOut() { }

	// RVA: 0x76B120
	void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<System.String> to, System.Collections.Generic.IEnumerable<System.Object> filters, System.Collections.Generic.IEnumerable<System.String> excludeIds, System.Nullable<System.Int32> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback) { }

	// RVA: 0x76B4D0
	void ActivateApp(string appId) { }

	// RVA: 0x76B588
	void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76B764
	void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback) { }

	// RVA: 0x76B9BC
	void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback) { }

	// RVA: 0x76BB18
	void AppEventsLogEvent(string logEvent, System.Nullable<System.Single> valueToSum, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x76BC3C
	void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<System.String,System.Object> parameters) { }

	// RVA: 0x76BD68
	void OnLoginComplete(ResultContainer result) { }

	// RVA: 0x76C790
	void OnGetAppLinkComplete(ResultContainer message) { }

	// RVA: 0x76C7D0
	void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x76C8E4
	void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x76C960
	void OnAppRequestsComplete(ResultContainer resultContainer) { }

	// RVA: 0x76C9DC
	void OnShareLinkComplete(ResultContainer resultContainer) { }

	// RVA: 0x76CA58
	void OnUrlResponse(string url) { }

	// RVA: 0x76CA60
	void OnHideUnity(bool isGameShown) { }

	// RVA: 0x76BDF8
	void FormatAuthResponse(ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback) { }

	// RVA: 0x76CA84
	void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback) { }

	// RVA: 0x76CAC4
	void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback) { }

	// RVA: 0x76CB04
	void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload) { }

	// RVA: 0x76CB44
	void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback) { }

	// RVA: 0x76CB84
	void GetSubscribableCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscribableCatalogResult> callback) { }

	// RVA: 0x76CBC4
	void GetSubscriptions(Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionsResult> callback) { }

	// RVA: 0x76CC04
	void PurchaseSubscription(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISubscriptionResult> callback) { }

	// RVA: 0x76CC44
	void CancelSubscription(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICancelSubscriptionResult> callback) { }

	// RVA: 0x76CC84
	Profile CurrentProfile() { }

	// RVA: 0x76CCC4
	void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback) { }

	// RVA: 0x76CD04
	void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x76CD44
	void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback) { }

	// RVA: 0x76CD84
	void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x76CDC4
	void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback) { }

	// RVA: 0x76CE04
	void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback) { }

	// RVA: 0x76CE44
	void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x76CE84
	void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback) { }

	// RVA: 0x76CEC4
	void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback) { }

	// RVA: 0x76CF04
	void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback) { }

	// RVA: 0x76CF44
	void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x76CF84
	void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x76CFC4
	void ShareTournament(int score, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback) { }

	// RVA: 0x76D004
	void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<System.String,System.String> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback) { }

	// RVA: 0x76D044
	void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x76D084
	void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback) { }

	// RVA: 0x76D0C4
	void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback) { }

	// RVA: 0x76D104
	void <OnLoginComplete>b__37_0(ResultContainer formattedResponse) { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookGameObject 
{
	// Methods

	// RVA: 0x76DA98
	ICanvasFacebookImplementation get_CanvasFacebookImpl() { }

	// RVA: 0x76DB14
	void OnPayComplete(string result) { }

	// RVA: 0x76DC5C
	void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x76DDA8
	void OnUrlResponse(string message) { }

	// RVA: 0x76DEC0
	void OnHideUnity(bool hide) { }

	// RVA: 0x76DFD8
	void OnAwake() { }

	// RVA: 0x76E0B0
	void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal class CanvasFacebookLoader 
{
	// Methods

	// RVA: 0x76E0B8
	FacebookGameObject get_FBGameObject() { }

	// RVA: 0x76E1DC
	void .ctor() { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookCallbackHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPayComplete(string message) { }

	// RVA: 0x2FE4574
	void OnFacebookAuthResponseChange(string message) { }

	// RVA: 0x2FE4574
	void OnUrlResponse(string message) { }

	// RVA: 0x2FE4234
	void OnHideUnity(bool hide) { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookImplementation 
{}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasFacebookResultHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPayComplete(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnFacebookAuthResponseChange(ResultContainer resultContainer) { }

	// RVA: 0x2FE4574
	void OnUrlResponse(string message) { }

	// RVA: 0x2FE4234
	void OnHideUnity(bool hide) { }

}

// Namespace: Facebook.Unity.Canvas
internal interface ICanvasJSWrapper 
{
	// Methods

	// RVA: 0x2FE360C
	string GetSDKVersion() { }

	// RVA: 0x2FE41A8
	void DisableFullScreen() { }

	// RVA: -1
	void Init(string connectFacebookUrl, string locale, int debug, string initParams, int status) { }

	// RVA: 0x2FE47D4
	void Login(System.Collections.Generic.IEnumerable<System.String> scope, string callback_id) { }

	// RVA: 0x2FE41A8
	void Logout() { }

	// RVA: 0x2FE41A8
	void ActivateApp() { }

	// RVA: -1
	void LogAppEvent(string eventName, System.Nullable<System.Single> valueToSum, string parameters) { }

	// RVA: -1
	void LogPurchase(float purchaseAmount, string currency, string parameters) { }

	// RVA: 0x2FE49A8
	void Ui(string x, string uid, string callbackMethodName) { }

	// RVA: 0x2FE41A8
	void InitScreenPosition() { }

}

// Namespace: Facebook.Unity.Canvas
internal class JsBridge 
{
	// Fields
	private ICanvasFacebookCallbackHandler facebook; // 0x20

	// Methods

	// RVA: 0x76E1E4
	void Start() { }

	// RVA: 0x76E248
	void OnLoginComplete(string responseJsonData) { }

	// RVA: 0x76E300
	void OnFacebookAuthResponseChange(string responseJsonData) { }

	// RVA: 0x76E3B8
	void OnPayComplete(string responseJsonData) { }

	// RVA: 0x76E46C
	void OnAppRequestsComplete(string responseJsonData) { }

	// RVA: 0x76E524
	void OnShareLinkComplete(string responseJsonData) { }

	// RVA: 0x76E5DC
	void OnFacebookFocus(string state) { }

	// RVA: 0x76E6BC
	void OnInitComplete(string responseJsonData) { }

	// RVA: 0x76E770
	void OnUrlResponse(string url) { }

	// RVA: 0x76E828
	void .ctor() { }

}


