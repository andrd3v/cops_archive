// Namespace: 
internal class <Module>
{}

// Namespace: Facebook.Unity.IOS
internal class IOSWrapper
{
	// Methods

	// RVA: 0x76D6D4
	public void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x76D7C0
	public void EnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x76D7CC
	public void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x76D8BC
	public void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x76D92C
	public void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x76D99C
	public void LogOut() { }

	// RVA: 0x76D9A4
	public void SetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x76D9F8
	public void SetShareDialogMode(int mode) { }

	// RVA: 0x76DA04
	public void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x76DB3C
	public void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x76DC5C
	public void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x76DF30
	public void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x76DF3C
	public void FBAppEventsActivateApp() { }

	// RVA: 0x76DF44
	public void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x76DFB4
	public void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x76E024
	public void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: 0x76E0C4
	public void GetCurrentGamingContext(int requestId) { }

	// RVA: 0x76E0D0
	public void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x76E290
	public void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x76E450
	public void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x76E45C
	public void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x76E468
	public void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled) { }

	// RVA: 0x76E474
	public bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x76E4B0
	public bool FBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x76E4EC
	public void GetAppLink(int requestId) { }

	// RVA: 0x76E4F8
	public string FBSdkVersion() { }

	// RVA: 0x76E560
	public void FBSetUserID(string userID) { }

	// RVA: 0x76E5B4
	public string FBGetUserID() { }

	// RVA: 0x76E61C
	public void SetDataProcessingOptions(string[] options, int country, int state) { }

	// RVA: 0x76E728
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x76E9C4
	public Profile CurrentProfile() { }

	// RVA: 0x76F220
	public void GetTournaments(int requestId) { }

	// RVA: 0x76F22C
	public void UpdateTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x76F2B0
	public void UpdateAndShareTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x76F334
	public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, Int64 endTime, string payload, int requestId) { }

	// RVA: 0x76F44C
	public void UploadImageToMediaLibrary(int requestId, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x76F514
	public void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x76F5CC
	public void FetchDeferredAppLink(int requestId) { }

	// RVA: 0x76F5D8
	public void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x76D74C
	private static extern void IOSFBInit(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x76D7C8
	private static extern void IOSFBEnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x76D8F4
	private static extern void IOSFBLogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x76D844
	private static extern void IOSFBLoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x76D964
	private static extern void IOSFBLogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x76D9A0
	private static extern void IOSFBLogOut() { }

	// RVA: 0x76D9D0
	private static extern void IOSFBSetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x76DA00
	private static extern void IOSFBSetShareDialogMode(int mode) { }

	// RVA: 0x76DAA0
	private static extern void IOSFBShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x76DB64
	private static extern void IOSFBFeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x76DCA4
	private static extern void IOSFBAppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x76DF40
	private static extern void IOSFBAppEventsActivateApp() { }

	// RVA: 0x76E0E4
	private static extern void IOSFBAppEventsLogEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x76E2A4
	private static extern void IOSFBAppEventsLogPurchase(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x76E458
	private static extern void IOSFBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x76E464
	private static extern void IOSFBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x76E470
	private static extern void IOSFBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID) { }

	// RVA: 0x76E494
	private static extern bool IOSFBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x76E4D0
	private static extern bool IOSFBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x76E4F4
	private static extern void IOSFBGetAppLink(int requestID) { }

	// RVA: 0x76E52C
	private static extern string IOSFBSdkVersion() { }

	// RVA: 0x76F5D4
	private static extern void IOSFBFetchDeferredAppLink(int requestID) { }

	// RVA: 0x76F5E0
	private static extern void IOSFBRefreshCurrentAccessToken(int requestID) { }

	// RVA: 0x76E58C
	private static extern void IOSFBSetUserID(string userID) { }

	// RVA: 0x76DF38
	private static extern void IOSFBOpenGamingServicesFriendFinder(int requestID) { }

	// RVA: 0x76F4B0
	private static extern void IOSFBUploadImageToMediaLibrary(int requestID, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x76F570
	private static extern void IOSFBUploadVideoToMediaLibrary(int requestID, string caption, string videoUri) { }

	// RVA: 0x76F228
	private static extern void IOSFBGetTournaments(int requestID) { }

	// RVA: 0x76F270
	private static extern void IOSFBUpdateTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x76F2F4
	private static extern void IOSFBUpdateAndShareTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x76F3C0
	private static extern void IOSFBCreateAndShareTournament(int initialScore, string title, int sortOrder, int scoreFormat, Int64 endTime, string payload, int requestID) { }

	// RVA: 0x76DF7C
	private static extern void IOSFBCreateGamingContext(int requestID, string playerID) { }

	// RVA: 0x76DFEC
	private static extern void IOSFBSwitchGamingContext(int requestID, string contextID) { }

	// RVA: 0x76E074
	private static extern void IOSFBChooseGamingContext(int requestID, string filter, int minSize, int maxSize) { }

	// RVA: 0x76E0CC
	private static extern void IOSFBGetCurrentGamingContext(int requestID) { }

	// RVA: 0x76E5E8
	private static extern string IOSFBGetUserID() { }

	// RVA: 0x76E640
	private static extern void IOSFBSetDataProcessingOptions(string[] options, int numOptions, int country, int state) { }

	// RVA: 0x76E990
	private static extern string IOSFBCurrentAuthenticationToken() { }

	// RVA: 0x76F1EC
	private static extern string IOSFBCurrentProfile() { }

	// RVA: 0x76F5E4
	public void .ctor() { }

}


