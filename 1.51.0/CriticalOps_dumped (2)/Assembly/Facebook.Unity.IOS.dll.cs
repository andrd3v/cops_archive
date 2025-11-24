// Namespace: 
internal class <Module>
{}

// Namespace: Facebook.Unity.IOS
internal class IOSWrapper
{
	// Methods

	// RVA: 0x7B1738
	public void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x7B1824
	public void EnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x7B1830
	public void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x7B1920
	public void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x7B1990
	public void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x7B1A00
	public void LogOut() { }

	// RVA: 0x7B1A08
	public void SetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x7B1A5C
	public void SetShareDialogMode(int mode) { }

	// RVA: 0x7B1A68
	public void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x7B1BA0
	public void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x7B1CC0
	public void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x7B1F94
	public void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x7B1FA0
	public void FBAppEventsActivateApp() { }

	// RVA: 0x7B1FA8
	public void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x7B2018
	public void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x7B2088
	public void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: 0x7B2128
	public void GetCurrentGamingContext(int requestId) { }

	// RVA: 0x7B2134
	public void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7B22F4
	public void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7B24B4
	public void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x7B24C0
	public void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x7B24CC
	public void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled) { }

	// RVA: 0x7B24D8
	public bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x7B2514
	public bool FBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x7B2550
	public void GetAppLink(int requestId) { }

	// RVA: 0x7B255C
	public string FBSdkVersion() { }

	// RVA: 0x7B25C4
	public void FBSetUserID(string userID) { }

	// RVA: 0x7B2618
	public string FBGetUserID() { }

	// RVA: 0x7B2680
	public void SetDataProcessingOptions(string[] options, int country, int state) { }

	// RVA: 0x7B278C
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x7B2A28
	public Profile CurrentProfile() { }

	// RVA: 0x7B3284
	public void GetTournaments(int requestId) { }

	// RVA: 0x7B3290
	public void UpdateTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x7B3314
	public void UpdateAndShareTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x7B3398
	public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, Int64 endTime, string payload, int requestId) { }

	// RVA: 0x7B34B0
	public void UploadImageToMediaLibrary(int requestId, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x7B3578
	public void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x7B3630
	public void FetchDeferredAppLink(int requestId) { }

	// RVA: 0x7B363C
	public void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x7B17B0
	private static extern void IOSFBInit(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x7B182C
	private static extern void IOSFBEnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x7B1958
	private static extern void IOSFBLogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x7B18A8
	private static extern void IOSFBLoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x7B19C8
	private static extern void IOSFBLogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x7B1A04
	private static extern void IOSFBLogOut() { }

	// RVA: 0x7B1A34
	private static extern void IOSFBSetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x7B1A64
	private static extern void IOSFBSetShareDialogMode(int mode) { }

	// RVA: 0x7B1B04
	private static extern void IOSFBShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x7B1BC8
	private static extern void IOSFBFeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x7B1D08
	private static extern void IOSFBAppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x7B1FA4
	private static extern void IOSFBAppEventsActivateApp() { }

	// RVA: 0x7B2148
	private static extern void IOSFBAppEventsLogEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7B2308
	private static extern void IOSFBAppEventsLogPurchase(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7B24BC
	private static extern void IOSFBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x7B24C8
	private static extern void IOSFBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x7B24D4
	private static extern void IOSFBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID) { }

	// RVA: 0x7B24F8
	private static extern bool IOSFBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x7B2534
	private static extern bool IOSFBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x7B2558
	private static extern void IOSFBGetAppLink(int requestID) { }

	// RVA: 0x7B2590
	private static extern string IOSFBSdkVersion() { }

	// RVA: 0x7B3638
	private static extern void IOSFBFetchDeferredAppLink(int requestID) { }

	// RVA: 0x7B3644
	private static extern void IOSFBRefreshCurrentAccessToken(int requestID) { }

	// RVA: 0x7B25F0
	private static extern void IOSFBSetUserID(string userID) { }

	// RVA: 0x7B1F9C
	private static extern void IOSFBOpenGamingServicesFriendFinder(int requestID) { }

	// RVA: 0x7B3514
	private static extern void IOSFBUploadImageToMediaLibrary(int requestID, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x7B35D4
	private static extern void IOSFBUploadVideoToMediaLibrary(int requestID, string caption, string videoUri) { }

	// RVA: 0x7B328C
	private static extern void IOSFBGetTournaments(int requestID) { }

	// RVA: 0x7B32D4
	private static extern void IOSFBUpdateTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x7B3358
	private static extern void IOSFBUpdateAndShareTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x7B3424
	private static extern void IOSFBCreateAndShareTournament(int initialScore, string title, int sortOrder, int scoreFormat, Int64 endTime, string payload, int requestID) { }

	// RVA: 0x7B1FE0
	private static extern void IOSFBCreateGamingContext(int requestID, string playerID) { }

	// RVA: 0x7B2050
	private static extern void IOSFBSwitchGamingContext(int requestID, string contextID) { }

	// RVA: 0x7B20D8
	private static extern void IOSFBChooseGamingContext(int requestID, string filter, int minSize, int maxSize) { }

	// RVA: 0x7B2130
	private static extern void IOSFBGetCurrentGamingContext(int requestID) { }

	// RVA: 0x7B264C
	private static extern string IOSFBGetUserID() { }

	// RVA: 0x7B26A4
	private static extern void IOSFBSetDataProcessingOptions(string[] options, int numOptions, int country, int state) { }

	// RVA: 0x7B29F4
	private static extern string IOSFBCurrentAuthenticationToken() { }

	// RVA: 0x7B3250
	private static extern string IOSFBCurrentProfile() { }

	// RVA: 0x7B3648
	public void .ctor() { }

}


