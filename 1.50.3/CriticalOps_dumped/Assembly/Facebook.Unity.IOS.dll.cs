// Namespace: 
internal class <Module>
{}

// Namespace: Facebook.Unity.IOS
internal class IOSWrapper
{
	// Methods

	// RVA: 0x79332C
	public void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x793418
	public void EnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x793424
	public void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x793514
	public void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x793584
	public void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x7935F4
	public void LogOut() { }

	// RVA: 0x7935FC
	public void SetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x793650
	public void SetShareDialogMode(int mode) { }

	// RVA: 0x79365C
	public void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x793794
	public void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x7938B4
	public void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x793B88
	public void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x793B94
	public void FBAppEventsActivateApp() { }

	// RVA: 0x793B9C
	public void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x793C0C
	public void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x793C7C
	public void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: 0x793D1C
	public void GetCurrentGamingContext(int requestId) { }

	// RVA: 0x793D28
	public void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x793EE8
	public void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7940A8
	public void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x7940B4
	public void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x7940C0
	public void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled) { }

	// RVA: 0x7940CC
	public bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x794108
	public bool FBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x794144
	public void GetAppLink(int requestId) { }

	// RVA: 0x794150
	public string FBSdkVersion() { }

	// RVA: 0x7941B8
	public void FBSetUserID(string userID) { }

	// RVA: 0x79420C
	public string FBGetUserID() { }

	// RVA: 0x794274
	public void SetDataProcessingOptions(string[] options, int country, int state) { }

	// RVA: 0x794380
	public AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x79461C
	public Profile CurrentProfile() { }

	// RVA: 0x794E78
	public void GetTournaments(int requestId) { }

	// RVA: 0x794E84
	public void UpdateTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x794F08
	public void UpdateAndShareTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x794F8C
	public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, Int64 endTime, string payload, int requestId) { }

	// RVA: 0x7950A4
	public void UploadImageToMediaLibrary(int requestId, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x79516C
	public void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x795224
	public void FetchDeferredAppLink(int requestId) { }

	// RVA: 0x795230
	public void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x7933A4
	private static extern void IOSFBInit(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x793420
	private static extern void IOSFBEnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x79354C
	private static extern void IOSFBLogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x79349C
	private static extern void IOSFBLoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x7935BC
	private static extern void IOSFBLogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x7935F8
	private static extern void IOSFBLogOut() { }

	// RVA: 0x793628
	private static extern void IOSFBSetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x793658
	private static extern void IOSFBSetShareDialogMode(int mode) { }

	// RVA: 0x7936F8
	private static extern void IOSFBShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x7937BC
	private static extern void IOSFBFeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x7938FC
	private static extern void IOSFBAppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x793B98
	private static extern void IOSFBAppEventsActivateApp() { }

	// RVA: 0x793D3C
	private static extern void IOSFBAppEventsLogEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x793EFC
	private static extern void IOSFBAppEventsLogPurchase(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x7940B0
	private static extern void IOSFBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x7940BC
	private static extern void IOSFBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x7940C8
	private static extern void IOSFBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID) { }

	// RVA: 0x7940EC
	private static extern bool IOSFBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x794128
	private static extern bool IOSFBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x79414C
	private static extern void IOSFBGetAppLink(int requestID) { }

	// RVA: 0x794184
	private static extern string IOSFBSdkVersion() { }

	// RVA: 0x79522C
	private static extern void IOSFBFetchDeferredAppLink(int requestID) { }

	// RVA: 0x795238
	private static extern void IOSFBRefreshCurrentAccessToken(int requestID) { }

	// RVA: 0x7941E4
	private static extern void IOSFBSetUserID(string userID) { }

	// RVA: 0x793B90
	private static extern void IOSFBOpenGamingServicesFriendFinder(int requestID) { }

	// RVA: 0x795108
	private static extern void IOSFBUploadImageToMediaLibrary(int requestID, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x7951C8
	private static extern void IOSFBUploadVideoToMediaLibrary(int requestID, string caption, string videoUri) { }

	// RVA: 0x794E80
	private static extern void IOSFBGetTournaments(int requestID) { }

	// RVA: 0x794EC8
	private static extern void IOSFBUpdateTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x794F4C
	private static extern void IOSFBUpdateAndShareTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x795018
	private static extern void IOSFBCreateAndShareTournament(int initialScore, string title, int sortOrder, int scoreFormat, Int64 endTime, string payload, int requestID) { }

	// RVA: 0x793BD4
	private static extern void IOSFBCreateGamingContext(int requestID, string playerID) { }

	// RVA: 0x793C44
	private static extern void IOSFBSwitchGamingContext(int requestID, string contextID) { }

	// RVA: 0x793CCC
	private static extern void IOSFBChooseGamingContext(int requestID, string filter, int minSize, int maxSize) { }

	// RVA: 0x793D24
	private static extern void IOSFBGetCurrentGamingContext(int requestID) { }

	// RVA: 0x794240
	private static extern string IOSFBGetUserID() { }

	// RVA: 0x794298
	private static extern void IOSFBSetDataProcessingOptions(string[] options, int numOptions, int country, int state) { }

	// RVA: 0x7945E8
	private static extern string IOSFBCurrentAuthenticationToken() { }

	// RVA: 0x794E44
	private static extern string IOSFBCurrentProfile() { }

	// RVA: 0x79523C
	public void .ctor() { }

}


