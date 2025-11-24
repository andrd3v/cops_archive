// Namespace: 
internal class <Module>
{}

// Namespace: Facebook.Unity.IOS
internal class IOSWrapper
{
	// Methods

	// RVA: 0x77C7B4
	public void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x77C8A0
	public void EnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x77C8AC
	public void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x77C99C
	public void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x77CA0C
	public void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x77CA7C
	public void LogOut() { }

	// RVA: 0x77CA84
	public void SetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x77CAD8
	public void SetShareDialogMode(int mode) { }

	// RVA: 0x77CAE4
	public void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x77CC1C
	public void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x77CD3C
	public void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x77D010
	public void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x77D01C
	public void FBAppEventsActivateApp() { }

	// RVA: 0x77D024
	public void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x77D094
	public void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x77D104
	public void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: 0x77D1A4
	public void GetCurrentGamingContext(int requestId) { }

	// RVA: 0x77D1B0
	public void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x77D370
	public void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x77D530
	public void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x77D53C
	public void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x77D548
	public void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled) { }

	// RVA: 0x77D554
	public bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x77D590
	public bool FBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x77D5CC
	public void GetAppLink(int requestId) { }

	// RVA: 0x77D5D8
	public string FBSdkVersion() { }

	// RVA: 0x77D640
	public void FBSetUserID(string userID) { }

	// RVA: 0x77D694
	public string FBGetUserID() { }

	// RVA: 0x77D6FC
	public void SetDataProcessingOptions(string[] options, int country, int state) { }

	// RVA: 0x77D808
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x77DAA4
	public Profile CurrentProfile() { }

	// RVA: 0x77E300
	public void GetTournaments(int requestId) { }

	// RVA: 0x77E30C
	public void UpdateTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x77E390
	public void UpdateAndShareTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x77E414
	public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, Int64 endTime, string payload, int requestId) { }

	// RVA: 0x77E52C
	public void UploadImageToMediaLibrary(int requestId, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x77E5F4
	public void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x77E6AC
	public void FetchDeferredAppLink(int requestId) { }

	// RVA: 0x77E6B8
	public void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x77C82C
	private static extern void IOSFBInit(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x77C8A8
	private static extern void IOSFBEnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x77C9D4
	private static extern void IOSFBLogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x77C924
	private static extern void IOSFBLoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x77CA44
	private static extern void IOSFBLogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x77CA80
	private static extern void IOSFBLogOut() { }

	// RVA: 0x77CAB0
	private static extern void IOSFBSetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x77CAE0
	private static extern void IOSFBSetShareDialogMode(int mode) { }

	// RVA: 0x77CB80
	private static extern void IOSFBShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x77CC44
	private static extern void IOSFBFeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x77CD84
	private static extern void IOSFBAppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x77D020
	private static extern void IOSFBAppEventsActivateApp() { }

	// RVA: 0x77D1C4
	private static extern void IOSFBAppEventsLogEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x77D384
	private static extern void IOSFBAppEventsLogPurchase(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x77D538
	private static extern void IOSFBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x77D544
	private static extern void IOSFBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x77D550
	private static extern void IOSFBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID) { }

	// RVA: 0x77D574
	private static extern bool IOSFBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x77D5B0
	private static extern bool IOSFBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x77D5D4
	private static extern void IOSFBGetAppLink(int requestID) { }

	// RVA: 0x77D60C
	private static extern string IOSFBSdkVersion() { }

	// RVA: 0x77E6B4
	private static extern void IOSFBFetchDeferredAppLink(int requestID) { }

	// RVA: 0x77E6C0
	private static extern void IOSFBRefreshCurrentAccessToken(int requestID) { }

	// RVA: 0x77D66C
	private static extern void IOSFBSetUserID(string userID) { }

	// RVA: 0x77D018
	private static extern void IOSFBOpenGamingServicesFriendFinder(int requestID) { }

	// RVA: 0x77E590
	private static extern void IOSFBUploadImageToMediaLibrary(int requestID, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x77E650
	private static extern void IOSFBUploadVideoToMediaLibrary(int requestID, string caption, string videoUri) { }

	// RVA: 0x77E308
	private static extern void IOSFBGetTournaments(int requestID) { }

	// RVA: 0x77E350
	private static extern void IOSFBUpdateTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x77E3D4
	private static extern void IOSFBUpdateAndShareTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x77E4A0
	private static extern void IOSFBCreateAndShareTournament(int initialScore, string title, int sortOrder, int scoreFormat, Int64 endTime, string payload, int requestID) { }

	// RVA: 0x77D05C
	private static extern void IOSFBCreateGamingContext(int requestID, string playerID) { }

	// RVA: 0x77D0CC
	private static extern void IOSFBSwitchGamingContext(int requestID, string contextID) { }

	// RVA: 0x77D154
	private static extern void IOSFBChooseGamingContext(int requestID, string filter, int minSize, int maxSize) { }

	// RVA: 0x77D1AC
	private static extern void IOSFBGetCurrentGamingContext(int requestID) { }

	// RVA: 0x77D6C8
	private static extern string IOSFBGetUserID() { }

	// RVA: 0x77D720
	private static extern void IOSFBSetDataProcessingOptions(string[] options, int numOptions, int country, int state) { }

	// RVA: 0x77DA70
	private static extern string IOSFBCurrentAuthenticationToken() { }

	// RVA: 0x77E2CC
	private static extern string IOSFBCurrentProfile() { }

	// RVA: 0x77E6C4
	public void .ctor() { }

}


