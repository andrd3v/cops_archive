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

	// RVA: 0xE85A90
	private static MonoScriptData Get() { }

	// RVA: 0xE85B94
	public void .ctor() { }

}

// Namespace: Singular
public static class Attributes
{
	// Fields
	public const string sngAttrFromDate = "sng_attr_from_date";
	public const string sngAttrToDate = "sng_attr_to_date";
	public const string sngAttrAchievementId = "sng_attr_achievement_id";
	public const string sngAttrContent = "sng_attr_content";
	public const string sngAttrContentId = "sng_attr_content_id";
	public const string sngAttrContentList = "sng_attr_content_list";
	public const string sngAttrContentType = "sng_attr_content_type";
	public const string sngAttrCouponCode = "sng_attr_coupon_code";
	public const string sngAttrDeepLink = "sng_attr_deep_link";
	public const string sngAttrEventEnd = "sng_attr_event_end";
	public const string sngAttrEventStart = "sng_attr_event_start";
	public const string sngAttrHotelScore = "sng_attr_hotel_score";
	public const string sngAttrItemDescription = "sng_attr_item_description";
	public const string sngAttrItemPrice = "sng_attr_item_price";
	public const string sngAttrLevel = "sng_attr_level";
	public const string sngAttrCountry = "sng_attr_country";
	public const string sngAttrRegion = "sng_attr_region";
	public const string sngAttrMax = "sng_attr_max";
	public const string sngAttrNewVersion = "sng_attr_new_version";
	public const string sngAttrOrigin = "sng_attr_origin";
	public const string sngAttrPaymentInfoAvailable = "sng_attr_payment_info_available";
	public const string sngAttrQuantity = "sng_attr_quantity";
	public const string sngAttrRating = "sng_attr_rating";
	public const string sngAttrRegistrationMethod = "sng_attr_registration_method";
	public const string sngAttrReviewText = "sng_attr_review_text";
	public const string sngAttrScore = "sng_attr_score";
	public const string sngAttrSearchString = "sng_attr_search_string";
	public const string sngAttrSubscriptionId = "sng_attr_subscription_id";
	public const string sngAttrSuccess = "sng_attr_success";
	public const string sngAttrTransactionId = "sng_attr_transaction_id";
	public const string sngAttrTutorialId = "sng_attr_tutorial_id";
	public const string sngAttrValid = "sng_attr_valid";
}

// Namespace: Singular
[Serializable]
public class ConversionValuesParams
{
	// Fields
	private int _value; // 0x10
	private int _coarse; // 0x14
	private bool _lock; // 0x18

	// Methods

	// RVA: 0xE85B9C
	public void .ctor() { }

	// RVA: 0xE85BA4
	public int get_Value() { }

	// RVA: 0xE85BAC
	public void set_Value(int value) { }

	// RVA: 0xE85BB4
	public int get_Coarse() { }

	// RVA: 0xE85BBC
	public void set_Coarse(int value) { }

	// RVA: 0xE85BC4
	public bool get_Lock() { }

	// RVA: 0xE85BCC
	public void set_Lock(bool value) { }

}

// Namespace: Singular
public static class Events
{
	// Fields
	public const string sngRate = "sng_rate";
	public const string sngSpentCredits = "sng_spent_credits";
	public const string sngTutorialComplete = "sng_tutorial_complete";
	public const string sngLogin = "sng_login";
	public const string sngStartTrial = "sng_start_trial";
	public const string sngSubscribe = "sng_subscribe";
	public const string sngBook = "sng_book";
	public const string sngContentViewList = "sng_content_view_list";
	public const string sngInvite = "sng_invite";
	public const string sngShare = "sng_share";
	public const string sngSubmitApplication = "sng_submit_application";
	public const string sngUpdate = "sng_update";
	public const string sngEcommercePurchase = "sng_ecommerce_purchase";
	public const string sngViewCart = "sng_view_cart";
	public const string sngAchievementUnlocked = "sng_achievement_unlocked";
	public const string sngAddPaymentInfo = "sng_add_payment_info";
	public const string sngAddToCart = "sng_add_to_cart";
	public const string sngAddToWishlist = "sng_add_to_wishlist";
	public const string sngCheckoutInitiated = "sng_checkout_initiated";
	public const string sngCompleteRegistration = "sng_complete_registration";
	public const string sngContentView = "sng_content_view";
	public const string sngLevelAchieved = "sng_level_achieved";
	public const string sngSearch = "sng_search";
}

// Namespace: Singular
[Serializable]
public class ShortLinkParams
{
	// Fields
	private string data; // 0x10
	private string error; // 0x18

	// Methods

	// RVA: 0xE85BD4
	public void .ctor() { }

	// RVA: 0xE85BDC
	public string get_Data() { }

	// RVA: 0xE85BE4
	public void set_Data(string value) { }

	// RVA: 0xE85BEC
	public string get_Error() { }

	// RVA: 0xE85BF4
	public void set_Error(string value) { }

}

// Namespace: 
public static class AdPlatforms
{
	// Fields
	public static readonly string MOPUB; // 0x0

	// Methods

	// RVA: 0xE865B8
	private static void .cctor() { }

}

// Namespace: Singular
public class SingularAdData
{
	// Fields
	private const string ADMON_IS_ADMON_REVENUE = "is_admon_revenue";
	private const string ADMON_AD_PLATFORM = "ad_platform";
	private const string ADMON_CURRENCY = "ad_currency";
	private const string ADMON_REVENUE = "ad_revenue";
	private const string ADMON_NETWORK_NAME = "ad_mediation_platform";
	private const string ADMON_AD_TYPE = "ad_type";
	private const string ADMON_AD_GROUP_TYPE = "ad_group_type";
	private const string ADMON_IMPRESSION_ID = "ad_impression_id";
	private const string ADMON_AD_PLACEMENT_NAME = "ad_placement_name";
	private const string ADMON_AD_UNIT_ID = "ad_unit_id";
	private const string ADMON_AD_UNIT_NAME = "ad_unit_name";
	private const string ADMON_AD_GROUP_ID = "ad_group_id";
	private const string ADMON_AD_GROUP_NAME = "ad_group_name";
	private const string ADMON_AD_GROUP_PRIORITY = "ad_group_priority";
	private const string ADMON_PRECISION = "ad_precision";
	private const string ADMON_PLACEMENT_ID = "ad_placement_id";
	private const string IS_REVENUE_EVENT_KEY = "is_revenue_event";
	private const string REVENUE_AMOUNT_KEY = "r";
	private const string REVENUE_CURRENCY_KEY = "pcc";
	private readonly string[] RequiredParams; // 0x50

	// Methods

	// RVA: 0xE85BFC
	public void .ctor(string adPlatform, string currency, Double revenue) { }

	// RVA: 0xE85FC4
	public SingularAdData WithNetworkName(string networkName) { }

	// RVA: 0xE86028
	public SingularAdData WithAdType(string adType) { }

	// RVA: 0xE8608C
	public SingularAdData WithAdGroupType(string adGroupType) { }

	// RVA: 0xE860F0
	public SingularAdData WithImpressionId(string impressionId) { }

	// RVA: 0xE86154
	public SingularAdData WithAdPlacmentName(string adPlacementName) { }

	// RVA: 0xE861B8
	public SingularAdData WithAdUnitId(string adUnitId) { }

	// RVA: 0xE8621C
	public SingularAdData WithAdUnitName(string adUnitName) { }

	// RVA: 0xE86280
	public SingularAdData WithAdGroupId(string adGroupId) { }

	// RVA: 0xE862E4
	public SingularAdData WithAdGroupName(string adGroupName) { }

	// RVA: 0xE86348
	public SingularAdData WithAdGroupPriority(string adGroupPriority) { }

	// RVA: 0xE863AC
	public SingularAdData WithPrecision(string precision) { }

	// RVA: 0xE86410
	public SingularAdData WithPlacementId(string placementId) { }

	// RVA: 0xE85E8C
	private void SetValue(string key, object value) { }

	// RVA: 0xE86474
	public bool HasRequiredParams() { }

}

// Namespace: Singular
public interface SingularConversionValuesUpdatedHandler
{
	// Methods

	// RVA: -1
	public abstract void OnConversionValuesUpdated(int value, int coarse, bool _lock) { }

}

// Namespace: Singular
public interface SingularConversionValueUpdatedHandler
{
	// Methods

	// RVA: -1
	public abstract void OnConversionValueUpdated(int value) { }

}

// Namespace: Singular
public interface SingularDeferredDeepLinkHandler
{
	// Methods

	// RVA: -1
	public abstract void OnDeferredDeepLink(string deepLink) { }

}

// Namespace: Singular
public interface SingularDeviceAttributionCallbackHandler
{
	// Methods

	// RVA: -1
	public abstract void OnSingularDeviceAttributionCallback(System.Collections.Generic.Dictionary<System.String,System.Object> attributionInfo) { }

}

// Namespace: Singular
public interface SingularLinkHandler
{
	// Methods

	// RVA: -1
	public abstract void OnSingularLinkResolved(SingularLinkParams linkParams) { }

}

// Namespace: Singular
[Serializable]
public class SingularLinkParams
{
	// Fields
	private string _deeplink; // 0x10
	private string _passthrough; // 0x18
	private bool _isDeferred; // 0x20
	private System.Collections.Generic.Dictionary<System.String,System.String> _urlParameters; // 0x28

	// Methods

	// RVA: 0xE86630
	public void .ctor() { }

	// RVA: 0xE86638
	public string get_Deeplink() { }

	// RVA: 0xE86640
	public void set_Deeplink(string value) { }

	// RVA: 0xE86648
	public string get_Passthrough() { }

	// RVA: 0xE86650
	public void set_Passthrough(string value) { }

	// RVA: 0xE86658
	public bool get_IsDeferred() { }

	// RVA: 0xE86660
	public void set_IsDeferred(bool value) { }

	// RVA: 0xE86668
	public System.Collections.Generic.Dictionary<System.String,System.String> get_UrlParameters() { }

	// RVA: 0xE86670
	public void set_UrlParameters(System.Collections.Generic.Dictionary<System.String,System.String> value) { }

}

// Namespace: Singular
public interface SingularSdidAccessorHandler
{
	// Methods

	// RVA: -1
	public abstract void DidSetSdid(string result) { }

	// RVA: -1
	public abstract void SdidReceived(string result) { }

}

// Namespace: Singular
public sealed class ShortLinkCallback
{
	// Methods

	// RVA: 0xE86678
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE86734
	public virtual void Invoke(string data, string error) { }

	// RVA: 0xE86748
	public virtual IAsyncResult BeginInvoke(string data, string error, AsyncCallback callback, object object) { }

	// RVA: 0xE867A4
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xE87910
	public void .ctor() { }

	// RVA: 0xE8799C
	public void SetValue(string key, object value) { }

	// RVA: 0xE89A58
	public string ToJsonString() { }

}

// Namespace: 
private class SingularGlobalProperty
{
	// Fields
	private string <Key>k__BackingField; // 0x10
	private string <Value>k__BackingField; // 0x18
	private bool <OverrideExisting>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE91984
	public string get_Key() { }

	// RVA: 0xE9198C
	public void set_Key(string value) { }

	// RVA: 0xE91994
	public string get_Value() { }

	// RVA: 0xE9199C
	public void set_Value(string value) { }

	// RVA: 0xE919A4
	public bool get_OverrideExisting() { }

	// RVA: 0xE919AC
	public void set_OverrideExisting(bool value) { }

	// RVA: 0xE91334
	public void .ctor(string key, string value, bool overrideExisting) { }

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
	private const string UNITY_WRAPPER_NAME = "Unity";
	private const string UNITY_VERSION = "5.6.0";
	public bool autoIAPComplete; // 0x38
	public bool clipboardAttribution; // 0x39
	public bool SKANEnabled; // 0x3A
	public bool manualSKANConversionManagement; // 0x3B
	public int waitForTrackingAuthorizationWithTimeoutInterval; // 0x3C
	public int enableODMWithTimeoutInterval; // 0x40
	public static string fcmDeviceToken; // 0x10
	public string facebookAppId; // 0x48
	public bool collectOAID; // 0x50
	private static string imei; // 0x18
	private System.Collections.Generic.Dictionary<System.String,Singular.SingularSDK.SingularGlobalProperty> globalProperties; // 0x58
	private static System.Nullable<System.Boolean> limitDataSharing; // 0x20
	private static string customUserId; // 0x28
	public bool limitAdvertisingIdentifiers; // 0x60
	public Int64 ddlTimeoutSec; // 0x68
	public Int64 sessionTimeoutSec; // 0x70
	public Int64 shortlinkResolveTimeout; // 0x78
	public static bool enableDeferredDeepLinks; // 0x30
	public static string openUri; // 0x38
	private static ShortLinkCallback shortLinkCallback; // 0x40
	private const Int64 DEFAULT_SHORT_LINKS_TIMEOUT = 10;
	private const Int64 DEFAULT_DDL_TIMEOUT = 60;
	private SingularLinkParams resolvedSingularLinkParams; // 0x80
	private int resolvedSingularLinkTime; // 0x88
	private static int cachedDDLMessageTime; // 0x48
	private static string cachedDDLMessage; // 0x50
	public static bool endSessionOnGoingToBackground; // 0x58
	public static bool restartSessionOnReturningToForeground; // 0x59
	public static bool batchEvents; // 0x5A
	private const string ADMON_REVENUE_EVENT_NAME = "__ADMON_USER_LEVEL_REVENUE__";
	public static string CustomSdid; // 0x60
	public string[] pushNotificationsLinkPaths; // 0x90
	public string[] brandedDomains; // 0x98
	public static SingularLinkHandler registeredSingularLinkHandler; // 0x68
	public static SingularDeferredDeepLinkHandler registeredDDLHandler; // 0x70
	public static SingularConversionValueUpdatedHandler registeredConversionValueUpdatedHandler; // 0x78
	public static SingularConversionValuesUpdatedHandler registeredConversionValuesUpdatedHandler; // 0x80
	public static SingularDeviceAttributionCallbackHandler registeredDeviceAttributionCallbackHandler; // 0x88
	public static SingularSdidAccessorHandler registeredSdidAccessorHandler; // 0x90
	private const string EVENT_NAME_IAP = "__iap__";
	private const string androidNativeMethodName_Revenue = "revenue";
	private const string androidNativeMethodName_CustomRevenue = "customRevenue";

	// Methods

	// RVA: 0xE867B0
	public static bool get_Initialized() { }

	// RVA: 0xE8682C
	private static void set_Initialized(bool value) { }

	// RVA: 0xE868B8
	private void Awake() { }

	// RVA: 0xE86D48
	public static void InitializeSingularSDK() { }

	// RVA: 0xE8774C
	public static void createReferrerShortLink(string baseLink, string referrerName, string referrerId, System.Collections.Generic.Dictionary<System.String,System.String> passthroughParams, ShortLinkCallback completionHandler) { }

	// RVA: 0xE870FC
	private static SingularConfig BuildSingularConfig() { }

	// RVA: 0xE87BE4
	public void Update() { }

	// RVA: 0xE87870
	private static extern bool createReferrerShortLink_(string baseLink, string referrerName, string referrerId, string passthroughParams) { }

	// RVA: 0xE87BE8
	private static extern bool StartSingularSession_(string config) { }

	// RVA: 0xE87C20
	private static extern bool StartSingularSessionWithLaunchOptions_(string key, string secret) { }

	// RVA: 0xE87C80
	private static extern bool StartSingularSessionWithLaunchURL_(string key, string secret, string url) { }

	// RVA: 0xE87CFC
	private static extern void SendEvent_(string name) { }

	// RVA: 0xE87D24
	private static extern void SendEventWithArgs(string name) { }

	// RVA: 0xE87D4C
	private static extern void SetDeviceCustomUserId_(string customUserId) { }

	// RVA: 0xE87D74
	private static extern void EndSingularSession_() { }

	// RVA: 0xE87D78
	private static extern void RestartSingularSession_(string key, string secret) { }

	// RVA: 0xE87748
	private static extern void SetAllowAutoIAPComplete_(bool allowed) { }

	// RVA: 0xE87DC0
	private static extern void HandlePushNotification_(string payloadJson) { }

	// RVA: 0xE87DE8
	private static extern void SetBatchesEvents_(bool allowed) { }

	// RVA: 0xE87DEC
	private static extern void SetBatchInterval_(int interval) { }

	// RVA: 0xE87DF0
	private static extern void SendAllBatches_() { }

	// RVA: 0xE87DF4
	private static extern void SetAge_(int age) { }

	// RVA: 0xE87DF8
	private static extern void SetGender_(string gender) { }

	// RVA: 0xE87E20
	private static extern string GetAPID_() { }

	// RVA: 0xE87E54
	private static extern string GetIDFA_() { }

	// RVA: 0xE87E88
	private static extern void Revenue_(string currency, Double amount) { }

	// RVA: 0xE87EC0
	private static extern void CustomRevenue_(string eventName, string currency, Double amount) { }

	// RVA: 0xE87F18
	private static extern void RevenueWithAllParams_(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE87FC8
	private static extern void CustomRevenueWithAllParams_(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE88094
	private static extern void RevenueWithAttributes_(string currency, Double amount, string attributesJson) { }

	// RVA: 0xE880EC
	private static extern void CustomRevenueWithAttributes_(string eventName, string currency, Double amount, string attributesJson) { }

	// RVA: 0xE88168
	private static extern void Init_NSDictionary() { }

	// RVA: 0xE8816C
	private static extern void Init_NSMasterArray() { }

	// RVA: 0xE88170
	private static extern void Push_NSDictionary(string key, string value, int type) { }

	// RVA: 0xE881C8
	private static extern void Free_NSDictionary() { }

	// RVA: 0xE881CC
	private static extern void Free_NSMasterArray() { }

	// RVA: 0xE881D0
	private static extern int New_NSDictionary() { }

	// RVA: 0xE881D4
	private static extern int New_NSArray() { }

	// RVA: 0xE881D8
	private static extern void Push_Container_NSDictionary(string key, int containerIndex) { }

	// RVA: 0xE88208
	private static extern void Push_To_Child_Dictionary(string key, string value, int type, int dictionaryIndex) { }

	// RVA: 0xE88268
	private static extern void Push_To_Child_Array(string value, int type, int arrayIndex) { }

	// RVA: 0xE882A8
	private static extern void Push_Container_To_Child_Dictionary(string key, int dictionaryIndex, int containerIndex) { }

	// RVA: 0xE882E8
	private static extern void Push_Container_To_Child_Array(int arrayIndex, int containerIndex) { }

	// RVA: 0xE882EC
	private static extern void RegisterDeviceTokenForUninstall_(string APNSToken) { }

	// RVA: 0xE88314
	private static extern void RegisterDeferredDeepLinkHandler_() { }

	// RVA: 0xE88318
	private static extern int SetDeferredDeepLinkTimeout_(int duration) { }

	// RVA: 0xE8831C
	private static extern void SetCustomUserId_(string customUserId) { }

	// RVA: 0xE88344
	private static extern void UnsetCustomUserId_() { }

	// RVA: 0xE88348
	private static extern void SetWrapperNameAndVersion_(string wrapper, string version) { }

	// RVA: 0xE88390
	private static extern string GetGlobalProperties_() { }

	// RVA: 0xE883C4
	private static extern bool SetGlobalProperty_(string key, string value, bool overrideExisting) { }

	// RVA: 0xE8842C
	private static extern void UnsetGlobalProperty_(string key) { }

	// RVA: 0xE88454
	private static extern void ClearGlobalProperties_() { }

	// RVA: 0xE88458
	private static extern void TrackingOptIn_() { }

	// RVA: 0xE8845C
	private static extern void TrackingUnder13_() { }

	// RVA: 0xE88460
	private static extern void StopAllTracking_() { }

	// RVA: 0xE88464
	private static extern void ResumeAllTracking_() { }

	// RVA: 0xE88468
	private static extern bool IsAllTrackingStopped_() { }

	// RVA: 0xE88484
	private static extern void LimitDataSharing_(bool limitDataSharingValue) { }

	// RVA: 0xE88488
	private static extern bool GetLimitDataSharing_() { }

	// RVA: 0xE884A4
	private static extern void SetLimitAdvertisingIdentifiers_(bool isEnabled) { }

	// RVA: 0xE884A8
	private static extern void SkanRegisterAppForAdNetworkAttribution_() { }

	// RVA: 0xE884AC
	private static extern bool SkanUpdateConversionValue_(int conversionValue) { }

	// RVA: 0xE884C8
	private static extern bool SkanUpdateConversionValues_(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xE884E4
	private static extern int SkanGetConversionValue_() { }

	// RVA: 0xE884E8
	private static void CreateDictionary(int parent, NSType parentType, string key, System.Collections.Generic.Dictionary<System.String,System.Object> source) { }

	// RVA: 0xE89380
	private static void CreateArray(int parent, NSType parentType, string key, ArrayList source) { }

	// RVA: 0xE875BC
	private static bool StartSingularSession(SingularConfig config) { }

	// RVA: 0xE89AE8
	public static bool StartSingularSessionWithLaunchOptions(string key, string secret, System.Collections.Generic.Dictionary<System.String,System.Object> options) { }

	// RVA: 0xE8A934
	public static bool StartSingularSessionWithLaunchURL(string key, string secret, string url) { }

	// RVA: 0xE8AA58
	public static void RestartSingularSession(string key, string secret) { }

	// RVA: 0xE8AAC8
	public static void EndSingularSession() { }

	// RVA: 0xE8AB38
	public static void Event(string name) { }

	// RVA: 0xE8AC78
	public static void Event(System.Collections.Generic.Dictionary<System.String,System.Object> args, string name) { }

	// RVA: 0xE8C044
	public static void Event(string name, object[] args) { }

	// RVA: 0xE8C390
	public static void SetDeviceCustomUserId(string customUserId) { }

	// RVA: 0xE8C4CC
	public static void SetAge(int age) { }

	// RVA: 0xE8C704
	public static void SetGender(string gender) { }

	// RVA: 0xE8C948
	public static void SetAllowAutoIAPComplete(bool allowed) { }

	// RVA: 0xE8CAC4
	public static void HandlePushNotification(System.Collections.Generic.Dictionary<System.String,System.String> pushNotificationPayload) { }

	// RVA: 0xE8CD98
	private void OnApplicationPause(bool paused) { }

	// RVA: 0xE8D028
	private void OnApplicationQuit() { }

	// RVA: 0xE8D1AC
	public static void SetDeferredDeepLinkHandler(SingularDeferredDeepLinkHandler ddlHandler) { }

	// RVA: 0xE8D510
	public void DeepLinkHandler(string message) { }

	// RVA: 0xE8D770
	private static int CurrentTimeSec() { }

	// RVA: 0xE8D84C
	public static void SetSingularLinkHandler(SingularLinkHandler handler) { }

	// RVA: 0xE8DC64
	public static void SetSingularDeviceAttributionCallbackHandler(SingularDeviceAttributionCallbackHandler handler) { }

	// RVA: 0xE8DD28
	private void SingularLinkHandlerResolved(string handlerParamsJson) { }

	// RVA: 0xE8DE24
	private void SingularDeviceAttributionCallback(string handlerParamsJson) { }

	// RVA: 0xE8E030
	private void ShortLinkResolved(string json) { }

	// RVA: 0xE8E1B0
	public static void SetConversionValueUpdatedHandler(SingularConversionValueUpdatedHandler handler) { }

	// RVA: 0xE8E274
	public static void SetConversionValuesUpdatedHandler(SingularConversionValuesUpdatedHandler handler) { }

	// RVA: 0xE8E338
	private void ConversionValueUpdated(string value) { }

	// RVA: 0xE8E48C
	private void ConversionValuesUpdated(string json) { }

	// RVA: 0xE8D994
	private void ResolveSingularLink() { }

	// RVA: 0xE8E624
	public static void RegisterDeviceTokenForUninstall(string APNSToken) { }

	// RVA: 0xE8E788
	public static string GetAPID() { }

	// RVA: 0xE8E84C
	public static string GetIDFA() { }

	// RVA: 0xE8E910
	public static void SetSingularSdidAccessorHandler(SingularSdidAccessorHandler handler) { }

	// RVA: 0xE8E9D4
	private void SingularDidSetSdid(string result) { }

	// RVA: 0xE8EB34
	private void SingularSdidReceived(string result) { }

	// RVA: 0xE8EC98
	public static void InAppPurchase(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE8ED28
	public static void InAppPurchase(string eventName, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE8F2CC
	public static void InAppPurchase(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE8F024
	public static void InAppPurchase(string eventName, Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE8F458
	private static System.Collections.Generic.Dictionary<System.String,System.Object> BuildIOSPurchaseAttributes(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE8FB88
	private static string ExtractIOSTransactionReceipt(string receipt) { }

	// RVA: 0xE8FCB4
	public static void Revenue(string currency, Double amount) { }

	// RVA: 0xE8F35C
	public static void CustomRevenue(string eventName, string currency, Double amount) { }

	// RVA: 0xE8FD90
	public static void Revenue(string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE8FE00
	public static void CustomRevenue(string eventName, string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE8FE70
	public static void Revenue(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE8FFCC
	public static void CustomRevenue(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE90144
	public static void Revenue(string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE902F0
	public static void CustomRevenue(string eventName, string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE904C4
	public static void RegisterTokenForUninstall(string token) { }

	// RVA: 0xE90544
	public static void SetFCMDeviceToken(string fcmDeviceToken) { }

	// RVA: 0xE905B4
	public static void SetGCMDeviceToken(string gcmDeviceToken) { }

	// RVA: 0xE90624
	public static void SetCustomUserId(string userId) { }

	// RVA: 0xE906EC
	public static void UnsetCustomUserId() { }

	// RVA: 0xE9079C
	public static void TrackingOptIn() { }

	// RVA: 0xE9084C
	public static void TrackingUnder13() { }

	// RVA: 0xE908FC
	public static void StopAllTracking() { }

	// RVA: 0xE909AC
	public static void ResumeAllTracking() { }

	// RVA: 0xE90A5C
	public static bool IsAllTrackingStopped() { }

	// RVA: 0xE90B5C
	public static void LimitDataSharing(bool limitDataSharingValue) { }

	// RVA: 0xE90C28
	public static bool GetLimitDataSharing() { }

	// RVA: 0xE90CF4
	public static void SetLimitAdvertisingIdentifiers(bool isEnabled) { }

	// RVA: 0xE90DC0
	public static void AdRevenue(SingularAdData adData) { }

	// RVA: 0xE90F38
	public static System.Collections.Generic.Dictionary<System.String,System.String> GetGlobalProperties() { }

	// RVA: 0xE910AC
	public static bool SetGlobalProperty(string key, string value, bool overrideExisting) { }

	// RVA: 0xE91390
	public static void UnsetGlobalProperty(string key) { }

	// RVA: 0xE914CC
	public static void ClearGlobalProperties() { }

	// RVA: 0xE9157C
	public static void SkanRegisterAppForAdNetworkAttribution() { }

	// RVA: 0xE915E4
	public static bool SkanUpdateConversionValue(int conversionValue) { }

	// RVA: 0xE91650
	public static void SkanUpdateConversionValue(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xE916C8
	public static System.Nullable<System.Int32> SkanGetConversionValue() { }

	// RVA: 0xE91788
	public void .ctor() { }

	// RVA: 0xE91884
	private static void .cctor() { }

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
	private const string LogTag = "[SingularLog]";

	// Methods

	// RVA: 0xE86BA0
	public static void SetLogLevel(int level) { }

	// RVA: 0xE919B4
	public static void EnableLogging(bool enable) { }

	// RVA: 0xE91A0C
	public static void LogVerbose(string message) { }

	// RVA: 0xE86CC0
	public static void LogDebug(string message) { }

	// RVA: 0xE91BD0
	public static void LogInfo(string message) { }

	// RVA: 0xE8C308
	public static void LogWarn(string message) { }

	// RVA: 0xE87074
	public static void LogError(string message) { }

	// RVA: 0xE91C58
	public static void LogAssert(string message) { }

	// RVA: 0xE91A94
	private static void TryLog(string message, LogLevel level, System.Action<System.String> logAction) { }

	// RVA: 0xE91CE0
	public void .ctor() { }

}

// Namespace: Singular
public static class Utilities
{
	// Methods

	// RVA: 0xE87A50
	public static String[][] DelimitedStringsArrayToArrayOfArrayOfString(string[] delimitedStringsArray, Char delimiter) { }

	// RVA: 0xE91CE8
	public static string ToCultureInvariantString(object value) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=654
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1544
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=1544 6E276F3844C19A690B40946C919ECFFFE7E4B25D02F867796A946DBFA66328BA; // 0x0
	internal static readonly __StaticArrayInitTypeSize=654 A89424C41B6598E7E1B59A21C08032D9E3E42DD7256CD0F044B7B6A173B0990A; // 0x608
}


