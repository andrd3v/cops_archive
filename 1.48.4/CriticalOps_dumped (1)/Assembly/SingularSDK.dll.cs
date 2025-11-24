// Namespace: 
internal class <Module> 
{}

// Namespace: 
private struct MonoScriptData 
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 
{
	// Methods

	// RVA: 0xDF66AC
	MonoScriptData Get() { }

	// RVA: 0xDF67B0
	void .ctor() { }

}

// Namespace: Singular
public static class Attributes 
{
	// Fields
	public const string sngAttrFromDate = 5737027520;
	public const string sngAttrToDate = 5737027456;
	public const string sngAttrAchievementId = 5714677664;
	public const string sngAttrContent = 5737027392;
	public const string sngAttrContentId = 5714677584;
	public const string sngAttrContentList = 5714677504;
	public const string sngAttrContentType = 5714677424;
	public const string sngAttrCouponCode = 5714677344;
	public const string sngAttrDeepLink = 5737027328;
	public const string sngAttrEventEnd = 5737027264;
	public const string sngAttrEventStart = 5714677184;
	public const string sngAttrHotelScore = 5714677104;
	public const string sngAttrItemDescription = 5714677024;
	public const string sngAttrItemPrice = 5714676944;
	public const string sngAttrLevel = 5737027200;
	public const string sngAttrCountry = 5737027136;
	public const string sngAttrRegion = 5737027072;
	public const string sngAttrMax = 5737071872;
	public const string sngAttrNewVersion = 5714676864;
	public const string sngAttrOrigin = 5737071808;
	public const string sngAttrPaymentInfoAvailable = 5708594848;
	public const string sngAttrQuantity = 5737071744;
	public const string sngAttrRating = 5737071680;
	public const string sngAttrRegistrationMethod = 5708594752;
	public const string sngAttrReviewText = 5714676784;
	public const string sngAttrScore = 5737071616;
	public const string sngAttrSearchString = 5714676704;
	public const string sngAttrSubscriptionId = 5714676624;
	public const string sngAttrSuccess = 5737071552;
	public const string sngAttrTransactionId = 5714676544;
	public const string sngAttrTutorialId = 5714676464;
	public const string sngAttrValid = 5737071488;
}

// Namespace: Singular
public class ConversionValuesParams 
{
	// Fields
	private int _value; // 0x10
	private int _coarse; // 0x14
	private bool _lock; // 0x18

	// Methods

	// RVA: 0xDF67B8
	void .ctor() { }

	// RVA: 0xDF67C0
	int get_Value() { }

	// RVA: 0xDF67C8
	void set_Value(int value) { }

	// RVA: 0xDF67D0
	int get_Coarse() { }

	// RVA: 0xDF67D8
	void set_Coarse(int value) { }

	// RVA: 0xDF67E0
	bool get_Lock() { }

	// RVA: 0xDF67E8
	void set_Lock(bool value) { }

}

// Namespace: Singular
public static class Events 
{
	// Fields
	public const string sngRate = 5736724256;
	public const string sngSpentCredits = 5737070976;
	public const string sngTutorialComplete = 5714675424;
	public const string sngLogin = 5736724208;
	public const string sngStartTrial = 5737070912;
	public const string sngSubscribe = 5737070848;
	public const string sngBook = 5736724160;
	public const string sngContentViewList = 5714675344;
	public const string sngInvite = 5736724112;
	public const string sngShare = 5736724064;
	public const string sngSubmitApplication = 5714675184;
	public const string sngUpdate = 5736723920;
	public const string sngEcommercePurchase = 5714675104;
	public const string sngViewCart = 5737070784;
	public const string sngAchievementUnlocked = 5714674944;
	public const string sngAddPaymentInfo = 5714674864;
	public const string sngAddToCart = 5737070720;
	public const string sngAddToWishlist = 5714674704;
	public const string sngCheckoutInitiated = 5714674624;
	public const string sngCompleteRegistration = 5714674464;
	public const string sngContentView = 5737070656;
	public const string sngLevelAchieved = 5737070592;
	public const string sngSearch = 5736723872;
}

// Namespace: Singular
public class ShortLinkParams 
{
	// Fields
	private string data; // 0x10
	private string error; // 0x18

	// Methods

	// RVA: 0xDF67F0
	void .ctor() { }

	// RVA: 0xDF67F8
	string get_Data() { }

	// RVA: 0xDF6800
	void set_Data(string value) { }

	// RVA: 0xDF6808
	string get_Error() { }

	// RVA: 0xDF6810
	void set_Error(string value) { }

}

// Namespace: 
public static class AdPlatforms 
{
	// Fields
	public static readonly string MOPUB; // 0x0

	// Methods

	// RVA: 0xDF7210
	void .cctor() { }

}

// Namespace: Singular
public class SingularAdData 
{
	// Fields
	private const string ADMON_IS_ADMON_REVENUE = 5730684032;
	private const string ADMON_AD_PLATFORM = 5730683968;
	private const string ADMON_CURRENCY = 5730683904;
	private const string ADMON_REVENUE = 5736723536;
	private const string ADMON_NETWORK_NAME = 5714674304;
	private const string ADMON_AD_TYPE = 5736723488;
	private const string ADMON_AD_GROUP_TYPE = 5730683840;
	private const string ADMON_IMPRESSION_ID = 5730683776;
	private const string ADMON_AD_PLACEMENT_NAME = 5730683712;
	private const string ADMON_AD_UNIT_ID = 5736723440;
	private const string ADMON_AD_UNIT_NAME = 5730683648;
	private const string ADMON_AD_GROUP_ID = 5730683584;
	private const string ADMON_AD_GROUP_NAME = 5730683520;
	private const string ADMON_AD_GROUP_PRIORITY = 5730683456;
	private const string ADMON_PRECISION = 5730683392;
	private const string ADMON_PLACEMENT_ID = 5730683328;
	private const string IS_REVENUE_EVENT_KEY = 5730683264;
	private const string REVENUE_AMOUNT_KEY = 5736713088;
	private const string REVENUE_CURRENCY_KEY = 5736723392;
	private readonly string[] RequiredParams; // 0x50

	// Methods

	// RVA: 0xDF6818
	void .ctor(string adPlatform, string currency, Double revenue) { }

	// RVA: 0xDF6C10
	SingularAdData WithNetworkName(string networkName) { }

	// RVA: 0xDF6C74
	SingularAdData WithAdType(string adType) { }

	// RVA: 0xDF6CD8
	SingularAdData WithAdGroupType(string adGroupType) { }

	// RVA: 0xDF6D3C
	SingularAdData WithImpressionId(string impressionId) { }

	// RVA: 0xDF6DA0
	SingularAdData WithAdPlacmentName(string adPlacementName) { }

	// RVA: 0xDF6E04
	SingularAdData WithAdUnitId(string adUnitId) { }

	// RVA: 0xDF6E68
	SingularAdData WithAdUnitName(string adUnitName) { }

	// RVA: 0xDF6ECC
	SingularAdData WithAdGroupId(string adGroupId) { }

	// RVA: 0xDF6F30
	SingularAdData WithAdGroupName(string adGroupName) { }

	// RVA: 0xDF6F94
	SingularAdData WithAdGroupPriority(string adGroupPriority) { }

	// RVA: 0xDF6FF8
	SingularAdData WithPrecision(string precision) { }

	// RVA: 0xDF705C
	SingularAdData WithPlacementId(string placementId) { }

	// RVA: 0xDF6ACC
	void SetValue(string key, object value) { }

	// RVA: 0xDF70C0
	bool HasRequiredParams() { }

}

// Namespace: Singular
public interface SingularConversionValuesUpdatedHandler 
{
	// Methods

	// RVA: -1
	void OnConversionValuesUpdated(int value, int coarse, bool _lock) { }

}

// Namespace: Singular
public interface SingularConversionValueUpdatedHandler 
{
	// Methods

	// RVA: 0x2FE42A4
	void OnConversionValueUpdated(int value) { }

}

// Namespace: Singular
public interface SingularDeferredDeepLinkHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnDeferredDeepLink(string deepLink) { }

}

// Namespace: Singular
public interface SingularDeviceAttributionCallbackHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnSingularDeviceAttributionCallback(System.Collections.Generic.Dictionary<System.String,System.Object> attributionInfo) { }

}

// Namespace: Singular
public interface SingularLinkHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnSingularLinkResolved(SingularLinkParams linkParams) { }

}

// Namespace: Singular
public class SingularLinkParams 
{
	// Fields
	private string _deeplink; // 0x10
	private string _passthrough; // 0x18
	private bool _isDeferred; // 0x20
	private System.Collections.Generic.Dictionary<System.String,System.String> _urlParameters; // 0x28

	// Methods

	// RVA: 0xDF7288
	void .ctor() { }

	// RVA: 0xDF7290
	string get_Deeplink() { }

	// RVA: 0xDF7298
	void set_Deeplink(string value) { }

	// RVA: 0xDF72A0
	string get_Passthrough() { }

	// RVA: 0xDF72A8
	void set_Passthrough(string value) { }

	// RVA: 0xDF72B0
	bool get_IsDeferred() { }

	// RVA: 0xDF72B8
	void set_IsDeferred(bool value) { }

	// RVA: 0xDF72C0
	System.Collections.Generic.Dictionary<System.String,System.String> get_UrlParameters() { }

	// RVA: 0xDF72C8
	void set_UrlParameters(System.Collections.Generic.Dictionary<System.String,System.String> value) { }

}

// Namespace: Singular
public interface SingularSdidAccessorHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void DidSetSdid(string result) { }

	// RVA: 0x2FE4574
	void SdidReceived(string result) { }

}

// Namespace: Singular
public sealed class ShortLinkCallback 
{
	// Methods

	// RVA: 0xDF72D0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xDF738C
	internal void Invoke(string data, string error) { }

	// RVA: 0xDF73A0
	internal IAsyncResult BeginInvoke(string data, string error, AsyncCallback callback, object object) { }

	// RVA: 0xDF73FC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private enum NSType 
{
	// Fields
	public int value__; // 0x10
	public const NSType STRING = 0;
	public const NSType INT = 1;
	public const NSType LONG = 2;
	public const NSType FLOAT = 3;
	public const NSType DOUBLE = 4;
	public const NSType NULL = 5;
	public const NSType ARRAY = 6;
	public const NSType DICTIONARY = 7;
}

// Namespace: 
private class SingularConfig 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,System.Object> _configValues; // 0x10

	// Methods

	// RVA: 0xDF84E0
	void .ctor() { }

	// RVA: 0xDF856C
	void SetValue(string key, object value) { }

	// RVA: 0xDFA524
	string ToJsonString() { }

}

// Namespace: 
private class SingularGlobalProperty 
{
	// Fields
	private string <Key>k__BackingField; // 0x10
	private string <Value>k__BackingField; // 0x18
	private bool <OverrideExisting>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE020D8
	string get_Key() { }

	// RVA: 0xE020E0
	void set_Key(string value) { }

	// RVA: 0xE020E8
	string get_Value() { }

	// RVA: 0xE020F0
	void set_Value(string value) { }

	// RVA: 0xE020F8
	bool get_OverrideExisting() { }

	// RVA: 0xE02100
	void set_OverrideExisting(bool value) { }

	// RVA: 0xE01A90
	void .ctor(string key, string value, bool overrideExisting) { }

}

// Namespace: Singular
public class SingularSDK 
{
	// Fields
	public string SingularAPIKey; // 0x20
	public string SingularAPISecret; // 0x28
	public bool InitializeOnAwake; // 0x30
	public bool enableLogging; // 0x31
	public int logLevel; // 0x34
	private static SingularSDK instance; // 0x0
	private static bool <Initialized>k__BackingField; // 0x8
	private const string UNITY_WRAPPER_NAME = 5736723104;
	private const string UNITY_VERSION = 5736723056;
	public bool autoIAPComplete; // 0x38
	public bool clipboardAttribution; // 0x39
	public bool SKANEnabled; // 0x3A
	public bool manualSKANConversionManagement; // 0x3B
	public int waitForTrackingAuthorizationWithTimeoutInterval; // 0x3C
	public static string fcmDeviceToken; // 0x10
	public string facebookAppId; // 0x40
	public bool collectOAID; // 0x48
	public bool limitedIdentifiersEnabled; // 0x49
	private static string imei; // 0x18
	private System.Collections.Generic.Dictionary<System.String,Singular.SingularSDK.SingularGlobalProperty> globalProperties; // 0x50
	private static System.Nullable<System.Boolean> limitDataSharing; // 0x20
	private static string customUserId; // 0x28
	public Int64 ddlTimeoutSec; // 0x58
	public Int64 sessionTimeoutSec; // 0x60
	public Int64 shortlinkResolveTimeout; // 0x68
	public static bool enableDeferredDeepLinks; // 0x30
	public static string openUri; // 0x38
	private static ShortLinkCallback shortLinkCallback; // 0x40
	private const Int64 DEFAULT_SHORT_LINKS_TIMEOUT = 10;
	private const Int64 DEFAULT_DDL_TIMEOUT = 60;
	private SingularLinkParams resolvedSingularLinkParams; // 0x70
	private int resolvedSingularLinkTime; // 0x78
	private static int cachedDDLMessageTime; // 0x48
	private static string cachedDDLMessage; // 0x50
	public static bool endSessionOnGoingToBackground; // 0x58
	public static bool restartSessionOnReturningToForeground; // 0x59
	public static bool batchEvents; // 0x5A
	private const string ADMON_REVENUE_EVENT_NAME = 5708594560;
	public static string CustomSdid; // 0x60
	public static SingularLinkHandler registeredSingularLinkHandler; // 0x68
	public static SingularDeferredDeepLinkHandler registeredDDLHandler; // 0x70
	public static SingularConversionValueUpdatedHandler registeredConversionValueUpdatedHandler; // 0x78
	public static SingularConversionValuesUpdatedHandler registeredConversionValuesUpdatedHandler; // 0x80
	public static SingularDeviceAttributionCallbackHandler registeredDeviceAttributionCallbackHandler; // 0x88
	public static SingularSdidAccessorHandler registeredSdidAccessorHandler; // 0x90
	private const string androidNativeMethodName_Revenue = 5736722912;
	private const string androidNativeMethodName_CustomRevenue = 5730683072;

	// Methods

	// RVA: 0xDF7408
	bool get_Initialized() { }

	// RVA: 0xDF7484
	void set_Initialized(bool value) { }

	// RVA: 0xDF7510
	void Awake() { }

	// RVA: 0xDF79E8
	void InitializeSingularSDK() { }

	// RVA: 0xDF831C
	void createReferrerShortLink(string baseLink, string referrerName, string referrerId, System.Collections.Generic.Dictionary<System.String,System.String> passthroughParams, ShortLinkCallback completionHandler) { }

	// RVA: 0xDF7D9C
	SingularConfig BuildSingularConfig() { }

	// RVA: 0xDF8620
	void Update() { }

	// RVA: 0xDF8440
	bool createReferrerShortLink_(string baseLink, string referrerName, string referrerId, string passthroughParams) { }

	// RVA: 0xDF8624
	bool StartSingularSession_(string config) { }

	// RVA: 0xDF865C
	bool StartSingularSessionWithLaunchOptions_(string key, string secret) { }

	// RVA: 0xDF86BC
	bool StartSingularSessionWithLaunchURL_(string key, string secret, string url) { }

	// RVA: 0xDF8738
	void SendEvent_(string name) { }

	// RVA: 0xDF8760
	void SendEventWithArgs(string name) { }

	// RVA: 0xDF8788
	void SetDeviceCustomUserId_(string customUserId) { }

	// RVA: 0xDF87B0
	void EndSingularSession_() { }

	// RVA: 0xDF87B4
	void RestartSingularSession_(string key, string secret) { }

	// RVA: 0xDF8318
	void SetAllowAutoIAPComplete_(bool allowed) { }

	// RVA: 0xDF87FC
	void SetBatchesEvents_(bool allowed) { }

	// RVA: 0xDF8800
	void SetBatchInterval_(int interval) { }

	// RVA: 0xDF8804
	void SendAllBatches_() { }

	// RVA: 0xDF8808
	void SetAge_(int age) { }

	// RVA: 0xDF880C
	void SetGender_(string gender) { }

	// RVA: 0xDF8834
	string GetAPID_() { }

	// RVA: 0xDF8868
	string GetIDFA_() { }

	// RVA: 0xDF889C
	void Revenue_(string currency, Double amount) { }

	// RVA: 0xDF88D4
	void CustomRevenue_(string eventName, string currency, Double amount) { }

	// RVA: 0xDF892C
	void RevenueWithAllParams_(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xDF89DC
	void CustomRevenueWithAllParams_(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xDF8AA8
	void RevenueWithAttributes_(string currency, Double amount, string attributesJson) { }

	// RVA: 0xDF8B00
	void CustomRevenueWithAttributes_(string eventName, string currency, Double amount, string attributesJson) { }

	// RVA: 0xDF8B7C
	void Init_NSDictionary() { }

	// RVA: 0xDF8B80
	void Init_NSMasterArray() { }

	// RVA: 0xDF8B84
	void Push_NSDictionary(string key, string value, int type) { }

	// RVA: 0xDF8BDC
	void Free_NSDictionary() { }

	// RVA: 0xDF8BE0
	void Free_NSMasterArray() { }

	// RVA: 0xDF8BE4
	int New_NSDictionary() { }

	// RVA: 0xDF8BE8
	int New_NSArray() { }

	// RVA: 0xDF8BEC
	void Push_Container_NSDictionary(string key, int containerIndex) { }

	// RVA: 0xDF8C1C
	void Push_To_Child_Dictionary(string key, string value, int type, int dictionaryIndex) { }

	// RVA: 0xDF8C7C
	void Push_To_Child_Array(string value, int type, int arrayIndex) { }

	// RVA: 0xDF8CBC
	void Push_Container_To_Child_Dictionary(string key, int dictionaryIndex, int containerIndex) { }

	// RVA: 0xDF8CFC
	void Push_Container_To_Child_Array(int arrayIndex, int containerIndex) { }

	// RVA: 0xDF8D00
	void RegisterDeviceTokenForUninstall_(string APNSToken) { }

	// RVA: 0xDF8D28
	void RegisterDeferredDeepLinkHandler_() { }

	// RVA: 0xDF8D2C
	int SetDeferredDeepLinkTimeout_(int duration) { }

	// RVA: 0xDF8D30
	void SetCustomUserId_(string customUserId) { }

	// RVA: 0xDF8D58
	void UnsetCustomUserId_() { }

	// RVA: 0xDF8D5C
	void SetWrapperNameAndVersion_(string wrapper, string version) { }

	// RVA: 0xDF8DA4
	string GetGlobalProperties_() { }

	// RVA: 0xDF8DD8
	bool SetGlobalProperty_(string key, string value, bool overrideExisting) { }

	// RVA: 0xDF8E40
	void UnsetGlobalProperty_(string key) { }

	// RVA: 0xDF8E68
	void ClearGlobalProperties_() { }

	// RVA: 0xDF8E6C
	void TrackingOptIn_() { }

	// RVA: 0xDF8E70
	void TrackingUnder13_() { }

	// RVA: 0xDF8E74
	void StopAllTracking_() { }

	// RVA: 0xDF8E78
	void ResumeAllTracking_() { }

	// RVA: 0xDF8E7C
	bool IsAllTrackingStopped_() { }

	// RVA: 0xDF8E98
	void LimitDataSharing_(bool limitDataSharingValue) { }

	// RVA: 0xDF8E9C
	bool GetLimitDataSharing_() { }

	// RVA: 0xDF8EB8
	void SkanRegisterAppForAdNetworkAttribution_() { }

	// RVA: 0xDF8EBC
	bool SkanUpdateConversionValue_(int conversionValue) { }

	// RVA: 0xDF8ED8
	bool SkanUpdateConversionValues_(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xDF8EF4
	int SkanGetConversionValue_() { }

	// RVA: 0xDF8EF8
	void CreateDictionary(int parent, NSType parentType, string key, System.Collections.Generic.Dictionary<System.String,System.Object> source) { }

	// RVA: 0xDF9DEC
	void CreateArray(int parent, NSType parentType, string key, ArrayList source) { }

	// RVA: 0xDF818C
	bool StartSingularSession(SingularConfig config) { }

	// RVA: 0xDFA5B4
	bool StartSingularSessionWithLaunchOptions(string key, string secret, System.Collections.Generic.Dictionary<System.String,System.Object> options) { }

	// RVA: 0xDFB45C
	bool StartSingularSessionWithLaunchURL(string key, string secret, string url) { }

	// RVA: 0xDFB580
	void RestartSingularSession(string key, string secret) { }

	// RVA: 0xDFB5F0
	void EndSingularSession() { }

	// RVA: 0xDFB660
	void Event(string name) { }

	// RVA: 0xDFB7A0
	void Event(System.Collections.Generic.Dictionary<System.String,System.Object> args, string name) { }

	// RVA: 0xDFCC00
	void Event(string name, object[] args) { }

	// RVA: 0xDFCF64
	void SetDeviceCustomUserId(string customUserId) { }

	// RVA: 0xDFD0A0
	void SetAge(int age) { }

	// RVA: 0xDFD2D8
	void SetGender(string gender) { }

	// RVA: 0xDFD51C
	void SetAllowAutoIAPComplete(bool allowed) { }

	// RVA: 0xDFD698
	void OnApplicationPause(bool paused) { }

	// RVA: 0xDFD928
	void OnApplicationQuit() { }

	// RVA: 0xDFDAAC
	void SetDeferredDeepLinkHandler(SingularDeferredDeepLinkHandler ddlHandler) { }

	// RVA: 0xDFDE10
	void DeepLinkHandler(string message) { }

	// RVA: 0xDFE070
	int CurrentTimeSec() { }

	// RVA: 0xDFE14C
	void SetSingularLinkHandler(SingularLinkHandler handler) { }

	// RVA: 0xDFE564
	void SetSingularDeviceAttributionCallbackHandler(SingularDeviceAttributionCallbackHandler handler) { }

	// RVA: 0xDFE628
	void SingularLinkHandlerResolved(string handlerParamsJson) { }

	// RVA: 0xDFE724
	void SingularDeviceAttributionCallback(string handlerParamsJson) { }

	// RVA: 0xDFE930
	void ShortLinkResolved(string json) { }

	// RVA: 0xDFEAB0
	void SetConversionValueUpdatedHandler(SingularConversionValueUpdatedHandler handler) { }

	// RVA: 0xDFEB74
	void SetConversionValuesUpdatedHandler(SingularConversionValuesUpdatedHandler handler) { }

	// RVA: 0xDFEC38
	void ConversionValueUpdated(string value) { }

	// RVA: 0xDFED8C
	void ConversionValuesUpdated(string json) { }

	// RVA: 0xDFE294
	void ResolveSingularLink() { }

	// RVA: 0xDFEF24
	void RegisterDeviceTokenForUninstall(string APNSToken) { }

	// RVA: 0xDFF088
	string GetAPID() { }

	// RVA: 0xDFF14C
	string GetIDFA() { }

	// RVA: 0xDFF210
	void SetSingularSdidAccessorHandler(SingularSdidAccessorHandler handler) { }

	// RVA: 0xDFF2D4
	void SingularDidSetSdid(string result) { }

	// RVA: 0xDFF434
	void SingularSdidReceived(string result) { }

	// RVA: 0xDFF598
	void InAppPurchase(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xDFF628
	void InAppPurchase(string eventName, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xDFFAC0
	void InAppPurchase(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xDFF924
	void InAppPurchase(string eventName, Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xDFFC4C
	System.Collections.Generic.Dictionary<System.String,System.Object> BuildIOSPurchaseAttributes(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE003A4
	string ExtractIOSTransactionReceipt(string receipt) { }

	// RVA: 0xE004D0
	void Revenue(string currency, Double amount) { }

	// RVA: 0xDFFB50
	void CustomRevenue(string eventName, string currency, Double amount) { }

	// RVA: 0xE005AC
	void Revenue(string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE0061C
	void CustomRevenue(string eventName, string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE0068C
	void Revenue(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE007E8
	void CustomRevenue(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE00960
	void Revenue(string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE00B0C
	void CustomRevenue(string eventName, string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE00CE0
	void RegisterTokenForUninstall(string token) { }

	// RVA: 0xE00D60
	void SetFCMDeviceToken(string fcmDeviceToken) { }

	// RVA: 0xE00DD0
	void SetGCMDeviceToken(string gcmDeviceToken) { }

	// RVA: 0xE00E40
	void SetCustomUserId(string userId) { }

	// RVA: 0xE00F08
	void UnsetCustomUserId() { }

	// RVA: 0xE00FB8
	void TrackingOptIn() { }

	// RVA: 0xE01068
	void TrackingUnder13() { }

	// RVA: 0xE01118
	void StopAllTracking() { }

	// RVA: 0xE011C8
	void ResumeAllTracking() { }

	// RVA: 0xE01278
	bool IsAllTrackingStopped() { }

	// RVA: 0xE01378
	void LimitDataSharing(bool limitDataSharingValue) { }

	// RVA: 0xE01444
	bool GetLimitDataSharing() { }

	// RVA: 0xE01510
	void AdRevenue(SingularAdData adData) { }

	// RVA: 0xE01688
	System.Collections.Generic.Dictionary<System.String,System.String> GetGlobalProperties() { }

	// RVA: 0xE017FC
	bool SetGlobalProperty(string key, string value, bool overrideExisting) { }

	// RVA: 0xE01AEC
	void UnsetGlobalProperty(string key) { }

	// RVA: 0xE01C28
	void ClearGlobalProperties() { }

	// RVA: 0xE01CD8
	void SkanRegisterAppForAdNetworkAttribution() { }

	// RVA: 0xE01D40
	bool SkanUpdateConversionValue(int conversionValue) { }

	// RVA: 0xE01DAC
	void SkanUpdateConversionValue(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xE01E24
	System.Nullable<System.Int32> SkanGetConversionValue() { }

	// RVA: 0xE01EE4
	void .ctor() { }

	// RVA: 0xE01FD8
	void .cctor() { }

}

// Namespace: 
public enum LogLevel 
{
	// Fields
	public int value__; // 0x10
	public const LogLevel Verbose = 2;
	public const LogLevel Debug = 3;
	public const LogLevel Info = 4;
	public const LogLevel Warn = 5;
	public const LogLevel Error = 6;
	public const LogLevel Assert = 7;
}

// Namespace: Singular
internal class SingularUnityLogger 
{
	// Fields
	private static bool _enableLogging; // 0x0
	private static LogLevel _logLevel; // 0x4
	private const string LogTag = 5730682944;

	// Methods

	// RVA: 0xDF7804
	void SetLogLevel(int level) { }

	// RVA: 0xE02108
	void EnableLogging(bool enable) { }

	// RVA: 0xE02160
	void LogVerbose(string message) { }

	// RVA: 0xDF7960
	void LogDebug(string message) { }

	// RVA: 0xE02324
	void LogInfo(string message) { }

	// RVA: 0xDFCEDC
	void LogWarn(string message) { }

	// RVA: 0xDF7D14
	void LogError(string message) { }

	// RVA: 0xE023AC
	void LogAssert(string message) { }

	// RVA: 0xE021E8
	void TryLog(string message, LogLevel level, System.Action<System.String> logAction) { }

	// RVA: 0xE02434
	void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=631 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1420 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=631 3B047CC02FD76E38A104C38F7797B81620C1AC4358D24D95EC601F4A1A84A835; // 0x0
	internal static readonly __StaticArrayInitTypeSize=1420 F1DAB7D2F802BC56A55E60EB706E5BB4BD97324D00CC7BFDE34F14A8D97DDB55; // 0x277
}


