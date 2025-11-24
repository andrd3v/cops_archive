// Namespace: 
internal class <Module> 
{}

// Namespace: Facebook.Unity.IOS
internal class IOSWrapper 
{
	// Methods

	// RVA: 0x756D70
	void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x756E5C
	void EnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x756E68
	void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x756F58
	void LogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x756FC8
	void LogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x757038
	void LogOut() { }

	// RVA: 0x757040
	void SetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x757094
	void SetShareDialogMode(int mode) { }

	// RVA: 0x7570A0
	void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x7571D8
	void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x7572F8
	void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x7575CC
	void OpenFriendFinderDialog(int requestId) { }

	// RVA: 0x7575D8
	void FBAppEventsActivateApp() { }

	// RVA: 0x7575E0
	void CreateGamingContext(int requestId, string playerID) { }

	// RVA: 0x757650
	void SwitchGamingContext(int requestId, string gamingContextID) { }

	// RVA: 0x7576C0
	void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize) { }

	// RVA: 0x757760
	void GetCurrentGamingContext(int requestId) { }

	// RVA: 0x75776C
	void LogAppEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x75792C
	void LogPurchaseAppEvent(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x757AEC
	void FBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x757AF8
	void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x757B04
	void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled) { }

	// RVA: 0x757B10
	bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x757B4C
	bool FBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x757B88
	void GetAppLink(int requestId) { }

	// RVA: 0x757B94
	string FBSdkVersion() { }

	// RVA: 0x757BFC
	void FBSetUserID(string userID) { }

	// RVA: 0x757C50
	string FBGetUserID() { }

	// RVA: 0x757CB8
	void SetDataProcessingOptions(string[] options, int country, int state) { }

	// RVA: 0x757DC4
	AuthenticationToken CurrentAuthenticationToken() { }

	// RVA: 0x758060
	Profile CurrentProfile() { }

	// RVA: 0x7588BC
	void GetTournaments(int requestId) { }

	// RVA: 0x7588C8
	void UpdateTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x75894C
	void UpdateAndShareTournament(string tournamentId, int score, int requestId) { }

	// RVA: 0x7589D0
	void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, Int64 endTime, string payload, int requestId) { }

	// RVA: 0x758AE8
	void UploadImageToMediaLibrary(int requestId, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x758BB0
	void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri) { }

	// RVA: 0x758C68
	void FetchDeferredAppLink(int requestId) { }

	// RVA: 0x758C74
	void RefreshCurrentAccessToken(int requestId) { }

	// RVA: 0x756DE8
	void IOSFBInit(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix) { }

	// RVA: 0x756E64
	void IOSFBEnableProfileUpdatesOnAccessTokenChange(bool enable) { }

	// RVA: 0x756F90
	void IOSFBLogInWithReadPermissions(int requestId, string scope) { }

	// RVA: 0x756EE0
	void IOSFBLoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce) { }

	// RVA: 0x757000
	void IOSFBLogInWithPublishPermissions(int requestId, string scope) { }

	// RVA: 0x75703C
	void IOSFBLogOut() { }

	// RVA: 0x75706C
	void IOSFBSetPushNotificationsDeviceTokenString(string token) { }

	// RVA: 0x75709C
	void IOSFBSetShareDialogMode(int mode) { }

	// RVA: 0x75713C
	void IOSFBShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL) { }

	// RVA: 0x757200
	void IOSFBFeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource) { }

	// RVA: 0x757340
	void IOSFBAppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title) { }

	// RVA: 0x7575DC
	void IOSFBAppEventsActivateApp() { }

	// RVA: 0x757780
	void IOSFBAppEventsLogEvent(string logEvent, Double valueToSum, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x757940
	void IOSFBAppEventsLogPurchase(Double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals) { }

	// RVA: 0x757AF4
	void IOSFBAppEventsSetLimitEventUsage(bool limitEventUsage) { }

	// RVA: 0x757B00
	void IOSFBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled) { }

	// RVA: 0x757B0C
	void IOSFBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID) { }

	// RVA: 0x757B30
	bool IOSFBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled) { }

	// RVA: 0x757B6C
	bool IOSFBDomainErrorEnabled(bool domainErrorEnabled) { }

	// RVA: 0x757B90
	void IOSFBGetAppLink(int requestID) { }

	// RVA: 0x757BC8
	string IOSFBSdkVersion() { }

	// RVA: 0x758C70
	void IOSFBFetchDeferredAppLink(int requestID) { }

	// RVA: 0x758C7C
	void IOSFBRefreshCurrentAccessToken(int requestID) { }

	// RVA: 0x757C28
	void IOSFBSetUserID(string userID) { }

	// RVA: 0x7575D4
	void IOSFBOpenGamingServicesFriendFinder(int requestID) { }

	// RVA: 0x758B4C
	void IOSFBUploadImageToMediaLibrary(int requestID, string caption, string imageUri, bool shouldLaunchMediaDialog) { }

	// RVA: 0x758C0C
	void IOSFBUploadVideoToMediaLibrary(int requestID, string caption, string videoUri) { }

	// RVA: 0x7588C4
	void IOSFBGetTournaments(int requestID) { }

	// RVA: 0x75890C
	void IOSFBUpdateTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x758990
	void IOSFBUpdateAndShareTournament(string tournamentID, int score, int requestID) { }

	// RVA: 0x758A5C
	void IOSFBCreateAndShareTournament(int initialScore, string title, int sortOrder, int scoreFormat, Int64 endTime, string payload, int requestID) { }

	// RVA: 0x757618
	void IOSFBCreateGamingContext(int requestID, string playerID) { }

	// RVA: 0x757688
	void IOSFBSwitchGamingContext(int requestID, string contextID) { }

	// RVA: 0x757710
	void IOSFBChooseGamingContext(int requestID, string filter, int minSize, int maxSize) { }

	// RVA: 0x757768
	void IOSFBGetCurrentGamingContext(int requestID) { }

	// RVA: 0x757C84
	string IOSFBGetUserID() { }

	// RVA: 0x757CDC
	void IOSFBSetDataProcessingOptions(string[] options, int numOptions, int country, int state) { }

	// RVA: 0x75802C
	string IOSFBCurrentAuthenticationToken() { }

	// RVA: 0x758888
	string IOSFBCurrentProfile() { }

	// RVA: 0x758C80
	void .ctor() { }

}


