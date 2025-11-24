// Namespace: 
internal class <Module> 
{}

// Namespace: 
public class AppsFlyerObjectScript 
{
	// Fields
	public string devKey; // 0x20
	public string appID; // 0x28
	public string UWPAppID; // 0x30
	public string macOSAppID; // 0x38
	public bool isDebug; // 0x40
	public bool getConversionData; // 0x41

	// Methods

	// RVA: 0x816C
	void Start() { }

	// RVA: 0x8758
	void Update() { }

	// RVA: 0x875C
	void onConversionDataSuccess(string conversionData) { }

	// RVA: 0x89AC
	void onConversionDataFail(string error) { }

	// RVA: 0x8A50
	void onAppOpenAttribution(string attributionData) { }

	// RVA: 0x8B34
	void onAppOpenAttributionFailure(string error) { }

	// RVA: 0x8BD8
	void .ctor() { }

}

// Namespace: AppsFlyerSDK
public class AFPurchaseDetailsAndroid 
{}

// Namespace: AppsFlyerSDK
public class AFSDKPurchaseDetailsIOS 
{
	// Fields
	private string <productId>k__BackingField; // 0x10
	private string <price>k__BackingField; // 0x18
	private string <currency>k__BackingField; // 0x20
	private string <transactionId>k__BackingField; // 0x28

	// Methods

	// RVA: 0x8BE0
	string get_productId() { }

	// RVA: 0x8BE8
	string get_price() { }

	// RVA: 0x8BF0
	string get_currency() { }

	// RVA: 0x8BF8
	string get_transactionId() { }

}

// Namespace: AppsFlyerSDK
public class AppsFlyer 
{
	// Fields
	public static readonly string kAppsFlyerPluginVersion; // 0x0
	public static string CallBackObjectName; // 0x8
	private static EventHandler onRequestResponse; // 0x10
	private static EventHandler onInAppResponse; // 0x18
	private static EventHandler onDeepLinkReceived; // 0x20
	public static IAppsFlyerNativeBridge instance; // 0x28

	// Methods

	// RVA: 0x8C00
	void initSDK(string devKey, string appID) { }

	// RVA: 0x83B8
	void initSDK(string devKey, string appID, MonoBehaviour gameObject) { }

	// RVA: 0x862C
	void startSDK() { }

	// RVA: 0x8D78
	void sendEvent(string eventName, System.Collections.Generic.Dictionary<System.String,System.String> eventValues) { }

	// RVA: 0x8EC4
	void stopSDK(bool isSDKStopped) { }

	// RVA: 0x8FE8
	bool isSDKStopped() { }

	// RVA: 0x910C
	string getSdkVersion() { }

	// RVA: 0x820C
	void setIsDebug(bool shouldEnable) { }

	// RVA: 0x924C
	void setCustomerUserId(string id) { }

	// RVA: 0x9370
	void setAppInviteOneLinkID(string oneLinkId) { }

	// RVA: 0x9494
	void setDeepLinkTimeout(Int64 deepLinkTimeout) { }

	// RVA: 0x95B8
	void setAdditionalData(System.Collections.Generic.Dictionary<System.String,System.String> customData) { }

	// RVA: 0x96DC
	void setResolveDeepLinkURLs(string[] urls) { }

	// RVA: 0x9800
	void setOneLinkCustomDomain(string[] domains) { }

	// RVA: 0x996C
	void setCurrencyCode(string currencyCode) { }

	// RVA: 0x9B18
	void setConsentData(AppsFlyerConsent appsFlyerConsent) { }

	// RVA: 0x9C3C
	void recordLocation(Double latitude, Double longitude) { }

	// RVA: 0x9D68
	void anonymizeUser(bool shouldAnonymizeUser) { }

	// RVA: 0x9E8C
	void enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x9FB0
	string getAppsFlyerId() { }

	// RVA: 0xA0F0
	void setMinTimeBetweenSessions(int seconds) { }

	// RVA: 0xA214
	void setHost(string hostPrefixName, string hostName) { }

	// RVA: 0xA3D0
	void setUserEmails(EmailCryptType cryptType, string[] userEmails) { }

	// RVA: 0xA4FC
	void updateServerUninstallToken(string token) { }

	// RVA: 0xA6A0
	void setPhoneNumber(string phoneNumber) { }

	// RVA: 0xA7C4
	void setImeiData(string aImei) { }

	// RVA: 0xA96C
	void setSharingFilterForAllPartners() { }

	// RVA: 0xAA8C
	void setAndroidIdData(string aAndroidId) { }

	// RVA: 0xAC34
	void waitForCustomerUserId(bool wait) { }

	// RVA: 0xADDC
	void setSharingFilter(string[] partners) { }

	// RVA: 0xAF00
	void setCustomerIdAndStartSDK(string id) { }

	// RVA: 0xB0A8
	void setSharingFilterForPartners(string[] partners) { }

	// RVA: 0xB174
	string getOutOfStore() { }

	// RVA: 0xB348
	void setOutOfStore(string sourceName) { }

	// RVA: 0xB4F0
	void getConversionData(string objectName) { }

	// RVA: 0xB614
	void setCollectAndroidID(bool isCollect) { }

	// RVA: 0xB7BC
	void setIsUpdate(bool isUpdate) { }

	// RVA: 0xB964
	void setCollectIMEI(bool isCollect) { }

	// RVA: 0xBB0C
	void setDisableCollectAppleAdSupport(bool disable) { }

	// RVA: 0xBCB0
	void setShouldCollectDeviceName(bool shouldCollectDeviceName) { }

	// RVA: 0xBE58
	void attributeAndOpenStore(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> userParams, MonoBehaviour gameObject) { }

	// RVA: 0xBFA0
	void setPreinstallAttribution(string mediaSource, string campaign, string siteId) { }

	// RVA: 0xC164
	void setDisableCollectIAd(bool disableCollectIAd) { }

	// RVA: 0xC30C
	bool isPreInstalledApp() { }

	// RVA: 0xC4C4
	void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox) { }

	// RVA: 0xC66C
	void recordCrossPromoteImpression(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0xC7AC
	void setUseUninstallSandbox(bool useUninstallSandbox) { }

	// RVA: 0xC954
	string getAttributionId() { }

	// RVA: 0xCB28
	void handlePushNotifications() { }

	// RVA: 0xCCDC
	void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0xCED0
	void validateAndSendInAppPurchase(AFSDKPurchaseDetailsIOS details, System.Collections.Generic.Dictionary<System.String,System.String> extraEventValues, MonoBehaviour gameObject) { }

	// RVA: 0xD094
	void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0xD288
	void validateAndSendInAppPurchase(AFPurchaseDetailsAndroid details, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0xD44C
	void handleOpenUrl(string url, string sourceApplication, string annotation) { }

	// RVA: 0xD610
	void registerUninstall(Byte[] deviceToken) { }

	// RVA: 0xD7B8
	void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval) { }

	// RVA: 0xD960
	void setCurrentDeviceLanguage(string language) { }

	// RVA: 0xDB08
	void generateUserInviteLink(System.Collections.Generic.Dictionary<System.String,System.String> parameters, MonoBehaviour gameObject) { }

	// RVA: 0xDC34
	void disableSKAdNetwork(bool isDisabled) { }

	// RVA: 0xDE8C
	void setCollectOaid(bool isCollect) { }

	// RVA: 0xE034
	void addPushNotificationDeepLinkPath(string[] paths) { }

	// RVA: 0xE158
	void setDisableAdvertisingIdentifiers(bool disable) { }

	// RVA: 0xE300
	void subscribeForDeepLink() { }

	// RVA: 0xE42C
	void setPartnerData(string partnerId, System.Collections.Generic.Dictionary<System.String,System.String> partnerInfo) { }

	// RVA: 0xE558
	void setDisableNetworkData(bool disable) { }

	// RVA: 0xE700
	void disableIDFVCollection(bool isDisabled) { }

	// RVA: 0xE934
	void add_OnRequestResponse(EventHandler value) { }

	// RVA: 0xEA18
	void remove_OnRequestResponse(EventHandler value) { }

	// RVA: 0xEAFC
	void add_OnInAppResponse(EventHandler value) { }

	// RVA: 0xEBE0
	void remove_OnInAppResponse(EventHandler value) { }

	// RVA: 0xECC4
	void add_OnDeepLinkReceived(EventHandler value) { }

	// RVA: 0xEDB0
	void remove_OnDeepLinkReceived(EventHandler value) { }

	// RVA: 0xEE94
	void inAppResponseReceived(string response) { }

	// RVA: 0xF2F4
	void requestResponseReceived(string response) { }

	// RVA: 0xF3D0
	void onDeepLinking(string response) { }

	// RVA: 0xEF70
	AppsFlyerRequestEventArgs parseRequestCallback(string response) { }

	// RVA: 0x890C
	System.Collections.Generic.Dictionary<System.String,System.Object> CallbackStringToDictionary(string str) { }

	// RVA: 0x8840
	void AFLog(string methodName, string str) { }

	// RVA: 0xFB68
	void .ctor() { }

	// RVA: 0xFB70
	void .cctor() { }

}

// Namespace: AppsFlyerSDK
public enum EmailCryptType 
{
	// Fields
	public int value__; // 0x10
	public const EmailCryptType EmailCryptTypeNone = 0;
	public const EmailCryptType EmailCryptTypeSHA256 = 1;
}

// Namespace: AppsFlyerSDK
public class AppsFlyerConsent 
{
	// Fields
	private bool <isUserSubjectToGDPR>k__BackingField; // 0x10
	private bool <hasConsentForDataUsage>k__BackingField; // 0x11
	private bool <hasConsentForAdsPersonalization>k__BackingField; // 0x12

	// Methods

	// RVA: 0xFC10
	bool get_isUserSubjectToGDPR() { }

	// RVA: 0xFC18
	bool get_hasConsentForDataUsage() { }

	// RVA: 0xFC20
	bool get_hasConsentForAdsPersonalization() { }

}

// Namespace: AppsFlyerSDK
public class AppsFlyerRequestEventArgs 
{
	// Fields
	private readonly int <statusCode>k__BackingField; // 0x10
	private readonly string <errorDescription>k__BackingField; // 0x18

	// Methods

	// RVA: 0xFAD4
	void .ctor(int code, string description) { }

}

// Namespace: AppsFlyerSDK
public class DeepLinkEventsArgs 
{
	// Fields
	public System.Collections.Generic.Dictionary<System.String,System.Object> deepLink; // 0x10
	private readonly DeepLinkStatus <status>k__BackingField; // 0x18
	private readonly DeepLinkError <error>k__BackingField; // 0x1C

	// Methods

	// RVA: 0xF4B4
	void .ctor(string str) { }

}

// Namespace: AppsFlyerSDK
public enum DeepLinkStatus 
{
	// Fields
	public int value__; // 0x10
	public const DeepLinkStatus FOUND = 0;
	public const DeepLinkStatus NOT_FOUND = 1;
	public const DeepLinkStatus ERROR = 2;
}

// Namespace: AppsFlyerSDK
public enum DeepLinkError 
{
	// Fields
	public int value__; // 0x10
	public const DeepLinkError TIMEOUT = 0;
	public const DeepLinkError NETWORK = 1;
	public const DeepLinkError HTTP_STATUS_CODE = 2;
	public const DeepLinkError UNEXPECTED = 3;
}

// Namespace: AppsFlyerSDK
public class AppsFlyeriOS 
{
	// Fields
	private bool <isInit>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFC28
	bool get_isInit() { }

	// RVA: 0xFC30
	void set_isInit(bool value) { }

	// RVA: 0x9244
	void .ctor() { }

	// RVA: 0x8C6C
	void .ctor(string devKey, string appID, MonoBehaviour gameObject) { }

	// RVA: 0xFCBC
	void startSDK(bool shouldCallback, string CallBackObjectName) { }

	// RVA: 0xFD2C
	void sendEvent(string eventName, System.Collections.Generic.Dictionary<System.String,System.String> eventValues, bool shouldCallback, string callBackObjectName) { }

	// RVA: 0xFC90
	void getConversionData(string objectName) { }

	// RVA: 0xFE50
	void setCustomerUserId(string customerUserID) { }

	// RVA: 0xFEA4
	void setAdditionalData(System.Collections.Generic.Dictionary<System.String,System.String> customData) { }

	// RVA: 0xFC38
	void setAppsFlyerDevKey(string appsFlyerDevKey) { }

	// RVA: 0xFC64
	void setAppleAppID(string appleAppID) { }

	// RVA: 0xFF4C
	void setCurrencyCode(string currencyCode) { }

	// RVA: 0xFFA0
	void setDisableCollectAppleAdSupport(bool disableCollectAppleAdSupport) { }

	// RVA: 0xFFAC
	void setIsDebug(bool isDebug) { }

	// RVA: 0xFFB8
	void setShouldCollectDeviceName(bool shouldCollectDeviceName) { }

	// RVA: 0xFFC4
	void setAppInviteOneLinkID(string appInviteOneLinkID) { }

	// RVA: 0x10018
	void setDeepLinkTimeout(Int64 deepLinkTimeout) { }

	// RVA: 0x10024
	void enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x10030
	void setConsentData(AppsFlyerConsent appsFlyerConsent) { }

	// RVA: 0x1005C
	void anonymizeUser(bool shouldAnonymizeUser) { }

	// RVA: 0x10068
	void setDisableCollectIAd(bool disableCollectIAd) { }

	// RVA: 0x10074
	void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox) { }

	// RVA: 0x10080
	void setUseUninstallSandbox(bool useUninstallSandbox) { }

	// RVA: 0x1008C
	void setResolveDeepLinkURLs(string[] resolveDeepLinkURLs) { }

	// RVA: 0x1016C
	void setOneLinkCustomDomain(string[] oneLinkCustomDomains) { }

	// RVA: 0x1024C
	void setUserEmails(EmailCryptType cryptType, string[] userEmails) { }

	// RVA: 0x1034C
	void setPhoneNumber(string phoneNumber) { }

	// RVA: 0x103A0
	void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x10564
	void validateAndSendInAppPurchase(AFSDKPurchaseDetailsIOS details, System.Collections.Generic.Dictionary<System.String,System.String> extraEventValues, MonoBehaviour gameObject) { }

	// RVA: 0x10710
	void recordLocation(Double longitude, Double latitude) { }

	// RVA: 0x10718
	string getAppsFlyerId() { }

	// RVA: 0x10780
	void registerUninstall(Byte[] deviceToken) { }

	// RVA: 0x107A0
	string getSdkVersion() { }

	// RVA: 0x10808
	void setHost(string hostPrefix, string host) { }

	// RVA: 0x1089C
	void setMinTimeBetweenSessions(int minTimeBetweenSessions) { }

	// RVA: 0x108A8
	void stopSDK(bool isSDKStopped) { }

	// RVA: 0x108B4
	bool isSDKStopped() { }

	// RVA: 0x108EC
	void handleOpenUrl(string url, string sourceApplication, string annotation) { }

	// RVA: 0x109C8
	void setSharingFilterForAllPartners() { }

	// RVA: 0x109D0
	void setSharingFilter(string[] partners) { }

	// RVA: 0xB154
	void setSharingFilterForPartners(string[] partners) { }

	// RVA: 0x10B74
	void recordCrossPromoteImpression(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x10C5C
	void attributeAndOpenStore(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> parameters, MonoBehaviour gameObject) { }

	// RVA: 0x10E1C
	void generateUserInviteLink(System.Collections.Generic.Dictionary<System.String,System.String> parameters, MonoBehaviour gameObject) { }

	// RVA: 0x10F5C
	void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval) { }

	// RVA: 0x10F68
	void disableSKAdNetwork(bool isDisabled) { }

	// RVA: 0x10F74
	void addPushNotificationDeepLinkPath(string[] paths) { }

	// RVA: 0x11054
	void subscribeForDeepLink(string objectName) { }

	// RVA: 0x110A8
	void setCurrentDeviceLanguage(string language) { }

	// RVA: 0x110FC
	void setPartnerData(string partnerId, System.Collections.Generic.Dictionary<System.String,System.String> partnerInfo) { }

	// RVA: 0x1119C
	void disableIDFVCollection(bool isDisabled) { }

	// RVA: 0xFCF4
	void _startSDK(bool shouldCallback, string objectName) { }

	// RVA: 0xFE28
	void _getConversionData(string objectName) { }

	// RVA: 0xFE7C
	void _setCustomerUserID(string customerUserID) { }

	// RVA: 0xFED4
	void _setAdditionalData(string customData) { }

	// RVA: 0xFEFC
	void _setAppsFlyerDevKey(string appsFlyerDevKey) { }

	// RVA: 0xFF24
	void _setAppleAppID(string appleAppID) { }

	// RVA: 0xFF78
	void _setCurrencyCode(string currencyCode) { }

	// RVA: 0xFFA8
	void _setDisableCollectAppleAdSupport(bool disableCollectAppleAdSupport) { }

	// RVA: 0xFFB4
	void _setIsDebug(bool isDebug) { }

	// RVA: 0xFFC0
	void _setShouldCollectDeviceName(bool shouldCollectDeviceName) { }

	// RVA: 0xFFF0
	void _setAppInviteOneLinkID(string appInviteOneLinkID) { }

	// RVA: 0x10020
	void _setDeepLinkTimeout(Int64 deepLinkTimeout) { }

	// RVA: 0x10064
	void _anonymizeUser(bool shouldAnonymizeUser) { }

	// RVA: 0x1002C
	void _enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x10058
	void _setConsentData(bool isUserSubjectToGDPR, bool hasConsentForDataUsage, bool hasConsentForAdsPersonalization) { }

	// RVA: 0x10070
	void _setDisableCollectIAd(bool disableCollectIAd) { }

	// RVA: 0x1007C
	void _setUseReceiptValidationSandbox(bool useReceiptValidationSandbox) { }

	// RVA: 0x10088
	void _setUseUninstallSandbox(bool useUninstallSandbox) { }

	// RVA: 0x100A8
	void _setResolveDeepLinkURLs(int length, string[] resolveDeepLinkURLs) { }

	// RVA: 0x10188
	void _setOneLinkCustomDomains(int length, string[] oneLinkCustomDomains) { }

	// RVA: 0x10270
	void _setUserEmails(EmailCryptType cryptType, int length, string[] userEmails) { }

	// RVA: 0x10378
	void _setPhoneNumber(string phoneNumber) { }

	// RVA: 0xFDB4
	void _afSendEvent(string eventName, string eventValues, bool shouldCallback, string objectName) { }

	// RVA: 0x1049C
	void _validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, string additionalParameters, string objectName) { }

	// RVA: 0x10648
	void _validateAndSendInAppPurchaseV2(string product, string price, string currency, string transactionId, string extraEventValues, string objectName) { }

	// RVA: 0x10714
	void _recordLocation(Double longitude, Double latitude) { }

	// RVA: 0x1074C
	string _getAppsFlyerId() { }

	// RVA: 0x10790
	void _registerUninstall(Byte[] deviceToken) { }

	// RVA: 0x107D4
	string _getSDKVersion() { }

	// RVA: 0x10854
	void _setHost(string host, string hostPrefix) { }

	// RVA: 0x108A4
	void _setMinTimeBetweenSessions(int minTimeBetweenSessions) { }

	// RVA: 0x108B0
	void _stopSDK(bool isStopSDK) { }

	// RVA: 0x108D0
	bool _isSDKStopped() { }

	// RVA: 0x1095C
	void _handleOpenUrl(string url, string sourceApplication, string annotation) { }

	// RVA: 0x109CC
	void _setSharingFilterForAllPartners() { }

	// RVA: 0x109EC
	void _setSharingFilter(int length, string[] partners) { }

	// RVA: 0x10AB0
	void _setSharingFilterForPartners(int length, string[] partners) { }

	// RVA: 0x10BF0
	void _recordCrossPromoteImpression(string appID, string campaign, string parameters) { }

	// RVA: 0x10D94
	void _attributeAndOpenStore(string appID, string campaign, string parameters, string gameObject) { }

	// RVA: 0x10F14
	void _generateUserInviteLink(string parameters, string gameObject) { }

	// RVA: 0x10F64
	void _waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval) { }

	// RVA: 0x10F70
	void _disableSKAdNetwork(bool isDisabled) { }

	// RVA: 0x10F90
	void _addPushNotificationDeepLinkPath(int length, string[] paths) { }

	// RVA: 0x11080
	void _subscribeForDeepLink(string objectName) { }

	// RVA: 0x110D4
	void _setCurrentDeviceLanguage(string language) { }

	// RVA: 0x11154
	void _setPartnerData(string partnerId, string partnerInfo) { }

	// RVA: 0x111A4
	void _disableIDFVCollection(bool isDisabled) { }

}

// Namespace: AppsFlyerSDK
public interface IAppsFlyerAndroidBridge 
{
	// Methods

	// RVA: 0x2FE4574
	void updateServerUninstallToken(string token) { }

	// RVA: 0x2FE4574
	void setImeiData(string imei) { }

	// RVA: 0x2FE4574
	void setAndroidIdData(string androidId) { }

	// RVA: 0x2FE4234
	void waitForCustomerUserId(bool wait) { }

	// RVA: 0x2FE4574
	void setCustomerIdAndStartSDK(string id) { }

	// RVA: 0x2FE360C
	string getOutOfStore() { }

	// RVA: 0x2FE4574
	void setOutOfStore(string sourceName) { }

	// RVA: 0x2FE4234
	void setCollectAndroidID(bool isCollect) { }

	// RVA: 0x2FE4234
	void setCollectIMEI(bool isCollect) { }

	// RVA: 0x2FE4234
	void setIsUpdate(bool isUpdate) { }

	// RVA: 0x2FE49A8
	void setPreinstallAttribution(string mediaSource, string campaign, string siteId) { }

	// RVA: 0x2FE3054
	bool isPreInstalledApp() { }

	// RVA: 0x2FE360C
	string getAttributionId() { }

	// RVA: 0x2FE41A8
	void handlePushNotifications() { }

	// RVA: 0x2FE4BD8
	void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x2FE49A8
	void validateAndSendInAppPurchase(AFPurchaseDetailsAndroid details, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x2FE4234
	void setCollectOaid(bool isCollect) { }

	// RVA: 0x2FE4234
	void setDisableAdvertisingIdentifiers(bool disable) { }

	// RVA: 0x2FE4234
	void setDisableNetworkData(bool disable) { }

}

// Namespace: AppsFlyerSDK
public interface IAppsFlyerConversionData 
{}

// Namespace: AppsFlyerSDK
public interface IAppsFlyerIOSBridge 
{
	// Methods

	// RVA: 0x2FE4234
	void setDisableCollectAppleAdSupport(bool disable) { }

	// RVA: 0x2FE4234
	void setShouldCollectDeviceName(bool shouldCollectDeviceName) { }

	// RVA: 0x2FE4234
	void setDisableCollectIAd(bool disableCollectIAd) { }

	// RVA: 0x2FE4234
	void setUseReceiptValidationSandbox(bool useReceiptValidationSandbox) { }

	// RVA: 0x2FE4234
	void setUseUninstallSandbox(bool useUninstallSandbox) { }

	// RVA: 0x2FE4B68
	void validateAndSendInAppPurchase(string productIdentifier, string price, string currency, string transactionId, System.Collections.Generic.Dictionary<System.String,System.String> additionalParameters, MonoBehaviour gameObject) { }

	// RVA: 0x2FE49A8
	void validateAndSendInAppPurchase(AFSDKPurchaseDetailsIOS details, System.Collections.Generic.Dictionary<System.String,System.String> extraEventValues, MonoBehaviour gameObject) { }

	// RVA: 0x2FE4574
	void registerUninstall(Byte[] deviceToken) { }

	// RVA: 0x2FE49A8
	void handleOpenUrl(string url, string sourceApplication, string annotation) { }

	// RVA: 0x2FE42A4
	void waitForATTUserAuthorizationWithTimeoutInterval(int timeoutInterval) { }

	// RVA: 0x2FE4574
	void setCurrentDeviceLanguage(string language) { }

	// RVA: 0x2FE4234
	void disableSKAdNetwork(bool isDisabled) { }

	// RVA: 0x2FE4234
	void disableIDFVCollection(bool isDisabled) { }

}

// Namespace: AppsFlyerSDK
public interface IAppsFlyerNativeBridge 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_isInit() { }

	// RVA: 0x2FE4234
	void set_isInit(bool value) { }

	// RVA: -1
	void startSDK(bool onRequestResponse, string CallBackObjectName) { }

	// RVA: -1
	void sendEvent(string eventName, System.Collections.Generic.Dictionary<System.String,System.String> eventValues, bool onInAppResponse, string CallBackObjectName) { }

	// RVA: 0x2FE4234
	void stopSDK(bool isSDKStopped) { }

	// RVA: 0x2FE3054
	bool isSDKStopped() { }

	// RVA: 0x2FE360C
	string getSdkVersion() { }

	// RVA: 0x2FE4574
	void setCustomerUserId(string id) { }

	// RVA: 0x2FE4574
	void setAppInviteOneLinkID(string oneLinkId) { }

	// RVA: 0x2FE4574
	void setAdditionalData(System.Collections.Generic.Dictionary<System.String,System.String> customData) { }

	// RVA: -1
	void setDeepLinkTimeout(Int64 deepLinkTimeout) { }

	// RVA: 0x2FE4574
	void setResolveDeepLinkURLs(string[] urls) { }

	// RVA: 0x2FE4574
	void setOneLinkCustomDomain(string[] domains) { }

	// RVA: 0x2FE4574
	void setCurrencyCode(string currencyCode) { }

	// RVA: -1
	void recordLocation(Double latitude, Double longitude) { }

	// RVA: 0x2FE4234
	void anonymizeUser(bool shouldAnonymizeUser) { }

	// RVA: 0x2FE360C
	string getAppsFlyerId() { }

	// RVA: 0x2FE4234
	void enableTCFDataCollection(bool shouldCollectTcfData) { }

	// RVA: 0x2FE4574
	void setConsentData(AppsFlyerConsent appsFlyerConsent) { }

	// RVA: 0x2FE42A4
	void setMinTimeBetweenSessions(int seconds) { }

	// RVA: 0x2FE47D4
	void setHost(string hostPrefixName, string hostName) { }

	// RVA: 0x2FE4574
	void setPhoneNumber(string phoneNumber) { }

	// RVA: 0x2FE41A8
	void setSharingFilterForAllPartners() { }

	// RVA: 0x2FE4574
	void setSharingFilter(string[] partners) { }

	// RVA: 0x2FE4574
	void getConversionData(string objectName) { }

	// RVA: 0x2FE4A14
	void attributeAndOpenStore(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> userParams, MonoBehaviour gameObject) { }

	// RVA: 0x2FE49A8
	void recordCrossPromoteImpression(string appID, string campaign, System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x2FE47D4
	void generateUserInviteLink(System.Collections.Generic.Dictionary<System.String,System.String> parameters, MonoBehaviour gameObject) { }

	// RVA: 0x2FE4574
	void addPushNotificationDeepLinkPath(string[] paths) { }

	// RVA: 0x2FE440C
	void setUserEmails(EmailCryptType cryptType, string[] userEmails) { }

	// RVA: 0x2FE4574
	void subscribeForDeepLink(string objectName) { }

	// RVA: 0x2FE4234
	void setIsDebug(bool shouldEnable) { }

	// RVA: 0x2FE47D4
	void setPartnerData(string partnerId, System.Collections.Generic.Dictionary<System.String,System.String> partnerInfo) { }

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

	// RVA: 0x11434
	bool IsWordBreak(Char c) { }

	// RVA: 0x11504
	void .ctor(string jsonString) { }

	// RVA: 0x111A8
	object Parse(string jsonString) { }

	// RVA: 0x115AC
	void Dispose() { }

	// RVA: 0x115E8
	System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x11EC4
	System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x11584
	object ParseValue() { }

	// RVA: 0x11FD4
	object ParseByToken(TOKEN token) { }

	// RVA: 0x11A18
	string ParseString() { }

	// RVA: 0x120E0
	object ParseNumber() { }

	// RVA: 0x1245C
	void EatWhitespace() { }

	// RVA: 0x1255C
	Char get_PeekChar() { }

	// RVA: 0x121C4
	Char get_NextChar() { }

	// RVA: 0x12250
	string get_NextWord() { }

	// RVA: 0x11774
	TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer 
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x125E8
	void .ctor() { }

	// RVA: 0x11360
	string Serialize(object obj) { }

	// RVA: 0x12660
	void SerializeValue(object value) { }

	// RVA: 0x12E70
	void SerializeObject(IDictionary obj) { }

	// RVA: 0x12B28
	void SerializeArray(IList anArray) { }

	// RVA: 0x1286C
	void SerializeString(string str) { }

	// RVA: 0x132F4
	void SerializeOther(object value) { }

}

// Namespace: AFMiniJSON
public static class Json 
{
	// Methods

	// RVA: 0xFB5C
	object Deserialize(string json) { }

	// RVA: 0xFDB0
	string Serialize(object obj) { }

}


