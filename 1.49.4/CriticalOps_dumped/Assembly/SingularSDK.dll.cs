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

	// RVA: 0xE1DB90
	private static MonoScriptData Get() { }

	// RVA: 0xE1DC94
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

	// RVA: 0xE1DC9C
	public void .ctor() { }

	// RVA: 0xE1DCA4
	public int get_Value() { }

	// RVA: 0xE1DCAC
	public void set_Value(int value) { }

	// RVA: 0xE1DCB4
	public int get_Coarse() { }

	// RVA: 0xE1DCBC
	public void set_Coarse(int value) { }

	// RVA: 0xE1DCC4
	public bool get_Lock() { }

	// RVA: 0xE1DCCC
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

	// RVA: 0xE1DCD4
	public void .ctor() { }

	// RVA: 0xE1DCDC
	public string get_Data() { }

	// RVA: 0xE1DCE4
	public void set_Data(string value) { }

	// RVA: 0xE1DCEC
	public string get_Error() { }

	// RVA: 0xE1DCF4
	public void set_Error(string value) { }

}

// Namespace: 
public static class AdPlatforms
{
	// Fields
	public static readonly string MOPUB; // 0x0

	// Methods

	// RVA: 0xE1E6F4
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

	// RVA: 0xE1DCFC
	public void .ctor(string adPlatform, string currency, Double revenue) { }

	// RVA: 0xE1E0F4
	public SingularAdData WithNetworkName(string networkName) { }

	// RVA: 0xE1E158
	public SingularAdData WithAdType(string adType) { }

	// RVA: 0xE1E1BC
	public SingularAdData WithAdGroupType(string adGroupType) { }

	// RVA: 0xE1E220
	public SingularAdData WithImpressionId(string impressionId) { }

	// RVA: 0xE1E284
	public SingularAdData WithAdPlacmentName(string adPlacementName) { }

	// RVA: 0xE1E2E8
	public SingularAdData WithAdUnitId(string adUnitId) { }

	// RVA: 0xE1E34C
	public SingularAdData WithAdUnitName(string adUnitName) { }

	// RVA: 0xE1E3B0
	public SingularAdData WithAdGroupId(string adGroupId) { }

	// RVA: 0xE1E414
	public SingularAdData WithAdGroupName(string adGroupName) { }

	// RVA: 0xE1E478
	public SingularAdData WithAdGroupPriority(string adGroupPriority) { }

	// RVA: 0xE1E4DC
	public SingularAdData WithPrecision(string precision) { }

	// RVA: 0xE1E540
	public SingularAdData WithPlacementId(string placementId) { }

	// RVA: 0xE1DFB0
	private void SetValue(string key, object value) { }

	// RVA: 0xE1E5A4
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

	// RVA: 0xE1E76C
	public void .ctor() { }

	// RVA: 0xE1E774
	public string get_Deeplink() { }

	// RVA: 0xE1E77C
	public void set_Deeplink(string value) { }

	// RVA: 0xE1E784
	public string get_Passthrough() { }

	// RVA: 0xE1E78C
	public void set_Passthrough(string value) { }

	// RVA: 0xE1E794
	public bool get_IsDeferred() { }

	// RVA: 0xE1E79C
	public void set_IsDeferred(bool value) { }

	// RVA: 0xE1E7A4
	public System.Collections.Generic.Dictionary<System.String,System.String> get_UrlParameters() { }

	// RVA: 0xE1E7AC
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

	// RVA: 0xE1E7B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE1E870
	public virtual void Invoke(string data, string error) { }

	// RVA: 0xE1E884
	public virtual IAsyncResult BeginInvoke(string data, string error, AsyncCallback callback, object object) { }

	// RVA: 0xE1E8E0
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

	// RVA: 0xE1FA0C
	public void .ctor() { }

	// RVA: 0xE1FA98
	public void SetValue(string key, object value) { }

	// RVA: 0xE21A50
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

	// RVA: 0xE29604
	public string get_Key() { }

	// RVA: 0xE2960C
	public void set_Key(string value) { }

	// RVA: 0xE29614
	public string get_Value() { }

	// RVA: 0xE2961C
	public void set_Value(string value) { }

	// RVA: 0xE29624
	public bool get_OverrideExisting() { }

	// RVA: 0xE2962C
	public void set_OverrideExisting(bool value) { }

	// RVA: 0xE28FBC
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
	private const string UNITY_VERSION = "5.3.2";
	public bool autoIAPComplete; // 0x38
	public bool clipboardAttribution; // 0x39
	public bool SKANEnabled; // 0x3A
	public bool manualSKANConversionManagement; // 0x3B
	public int waitForTrackingAuthorizationWithTimeoutInterval; // 0x3C
	public static string fcmDeviceToken; // 0x10
	public string facebookAppId; // 0x40
	public bool collectOAID; // 0x48
	private static string imei; // 0x18
	private System.Collections.Generic.Dictionary<System.String,Singular.SingularSDK.SingularGlobalProperty> globalProperties; // 0x50
	private static System.Nullable<System.Boolean> limitDataSharing; // 0x20
	private static string customUserId; // 0x28
	public bool limitedIdentifiersEnabled; // 0x58
	public Int64 ddlTimeoutSec; // 0x60
	public Int64 sessionTimeoutSec; // 0x68
	public Int64 shortlinkResolveTimeout; // 0x70
	public static bool enableDeferredDeepLinks; // 0x30
	public static string openUri; // 0x38
	private static ShortLinkCallback shortLinkCallback; // 0x40
	private const Int64 DEFAULT_SHORT_LINKS_TIMEOUT = 10;
	private const Int64 DEFAULT_DDL_TIMEOUT = 60;
	private SingularLinkParams resolvedSingularLinkParams; // 0x78
	private int resolvedSingularLinkTime; // 0x80
	private static int cachedDDLMessageTime; // 0x48
	private static string cachedDDLMessage; // 0x50
	public static bool endSessionOnGoingToBackground; // 0x58
	public static bool restartSessionOnReturningToForeground; // 0x59
	public static bool batchEvents; // 0x5A
	private const string ADMON_REVENUE_EVENT_NAME = "__ADMON_USER_LEVEL_REVENUE__";
	public static string CustomSdid; // 0x60
	public static SingularLinkHandler registeredSingularLinkHandler; // 0x68
	public static SingularDeferredDeepLinkHandler registeredDDLHandler; // 0x70
	public static SingularConversionValueUpdatedHandler registeredConversionValueUpdatedHandler; // 0x78
	public static SingularConversionValuesUpdatedHandler registeredConversionValuesUpdatedHandler; // 0x80
	public static SingularDeviceAttributionCallbackHandler registeredDeviceAttributionCallbackHandler; // 0x88
	public static SingularSdidAccessorHandler registeredSdidAccessorHandler; // 0x90
	private const string androidNativeMethodName_Revenue = "revenue";
	private const string androidNativeMethodName_CustomRevenue = "customRevenue";

	// Methods

	// RVA: 0xE1E8EC
	public static bool get_Initialized() { }

	// RVA: 0xE1E968
	private static void set_Initialized(bool value) { }

	// RVA: 0xE1E9F4
	private void Awake() { }

	// RVA: 0xE1EECC
	public static void InitializeSingularSDK() { }

	// RVA: 0xE1F848
	public static void createReferrerShortLink(string baseLink, string referrerName, string referrerId, System.Collections.Generic.Dictionary<System.String,System.String> passthroughParams, ShortLinkCallback completionHandler) { }

	// RVA: 0xE1F280
	private static SingularConfig BuildSingularConfig() { }

	// RVA: 0xE1FB4C
	public void Update() { }

	// RVA: 0xE1F96C
	private static extern bool createReferrerShortLink_(string baseLink, string referrerName, string referrerId, string passthroughParams) { }

	// RVA: 0xE1FB50
	private static extern bool StartSingularSession_(string config) { }

	// RVA: 0xE1FB88
	private static extern bool StartSingularSessionWithLaunchOptions_(string key, string secret) { }

	// RVA: 0xE1FBE8
	private static extern bool StartSingularSessionWithLaunchURL_(string key, string secret, string url) { }

	// RVA: 0xE1FC64
	private static extern void SendEvent_(string name) { }

	// RVA: 0xE1FC8C
	private static extern void SendEventWithArgs(string name) { }

	// RVA: 0xE1FCB4
	private static extern void SetDeviceCustomUserId_(string customUserId) { }

	// RVA: 0xE1FCDC
	private static extern void EndSingularSession_() { }

	// RVA: 0xE1FCE0
	private static extern void RestartSingularSession_(string key, string secret) { }

	// RVA: 0xE1F844
	private static extern void SetAllowAutoIAPComplete_(bool allowed) { }

	// RVA: 0xE1FD28
	private static extern void SetBatchesEvents_(bool allowed) { }

	// RVA: 0xE1FD2C
	private static extern void SetBatchInterval_(int interval) { }

	// RVA: 0xE1FD30
	private static extern void SendAllBatches_() { }

	// RVA: 0xE1FD34
	private static extern void SetAge_(int age) { }

	// RVA: 0xE1FD38
	private static extern void SetGender_(string gender) { }

	// RVA: 0xE1FD60
	private static extern string GetAPID_() { }

	// RVA: 0xE1FD94
	private static extern string GetIDFA_() { }

	// RVA: 0xE1FDC8
	private static extern void Revenue_(string currency, Double amount) { }

	// RVA: 0xE1FE00
	private static extern void CustomRevenue_(string eventName, string currency, Double amount) { }

	// RVA: 0xE1FE58
	private static extern void RevenueWithAllParams_(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE1FF08
	private static extern void CustomRevenueWithAllParams_(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE1FFD4
	private static extern void RevenueWithAttributes_(string currency, Double amount, string attributesJson) { }

	// RVA: 0xE2002C
	private static extern void CustomRevenueWithAttributes_(string eventName, string currency, Double amount, string attributesJson) { }

	// RVA: 0xE200A8
	private static extern void Init_NSDictionary() { }

	// RVA: 0xE200AC
	private static extern void Init_NSMasterArray() { }

	// RVA: 0xE200B0
	private static extern void Push_NSDictionary(string key, string value, int type) { }

	// RVA: 0xE20108
	private static extern void Free_NSDictionary() { }

	// RVA: 0xE2010C
	private static extern void Free_NSMasterArray() { }

	// RVA: 0xE20110
	private static extern int New_NSDictionary() { }

	// RVA: 0xE20114
	private static extern int New_NSArray() { }

	// RVA: 0xE20118
	private static extern void Push_Container_NSDictionary(string key, int containerIndex) { }

	// RVA: 0xE20148
	private static extern void Push_To_Child_Dictionary(string key, string value, int type, int dictionaryIndex) { }

	// RVA: 0xE201A8
	private static extern void Push_To_Child_Array(string value, int type, int arrayIndex) { }

	// RVA: 0xE201E8
	private static extern void Push_Container_To_Child_Dictionary(string key, int dictionaryIndex, int containerIndex) { }

	// RVA: 0xE20228
	private static extern void Push_Container_To_Child_Array(int arrayIndex, int containerIndex) { }

	// RVA: 0xE2022C
	private static extern void RegisterDeviceTokenForUninstall_(string APNSToken) { }

	// RVA: 0xE20254
	private static extern void RegisterDeferredDeepLinkHandler_() { }

	// RVA: 0xE20258
	private static extern int SetDeferredDeepLinkTimeout_(int duration) { }

	// RVA: 0xE2025C
	private static extern void SetCustomUserId_(string customUserId) { }

	// RVA: 0xE20284
	private static extern void UnsetCustomUserId_() { }

	// RVA: 0xE20288
	private static extern void SetWrapperNameAndVersion_(string wrapper, string version) { }

	// RVA: 0xE202D0
	private static extern string GetGlobalProperties_() { }

	// RVA: 0xE20304
	private static extern bool SetGlobalProperty_(string key, string value, bool overrideExisting) { }

	// RVA: 0xE2036C
	private static extern void UnsetGlobalProperty_(string key) { }

	// RVA: 0xE20394
	private static extern void ClearGlobalProperties_() { }

	// RVA: 0xE20398
	private static extern void TrackingOptIn_() { }

	// RVA: 0xE2039C
	private static extern void TrackingUnder13_() { }

	// RVA: 0xE203A0
	private static extern void StopAllTracking_() { }

	// RVA: 0xE203A4
	private static extern void ResumeAllTracking_() { }

	// RVA: 0xE203A8
	private static extern bool IsAllTrackingStopped_() { }

	// RVA: 0xE203C4
	private static extern void LimitDataSharing_(bool limitDataSharingValue) { }

	// RVA: 0xE203C8
	private static extern bool GetLimitDataSharing_() { }

	// RVA: 0xE203E4
	private static extern void SkanRegisterAppForAdNetworkAttribution_() { }

	// RVA: 0xE203E8
	private static extern bool SkanUpdateConversionValue_(int conversionValue) { }

	// RVA: 0xE20404
	private static extern bool SkanUpdateConversionValues_(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xE20420
	private static extern int SkanGetConversionValue_() { }

	// RVA: 0xE20424
	private static void CreateDictionary(int parent, NSType parentType, string key, System.Collections.Generic.Dictionary<System.String,System.Object> source) { }

	// RVA: 0xE21318
	private static void CreateArray(int parent, NSType parentType, string key, ArrayList source) { }

	// RVA: 0xE1F6B8
	private static bool StartSingularSession(SingularConfig config) { }

	// RVA: 0xE21AE0
	public static bool StartSingularSessionWithLaunchOptions(string key, string secret, System.Collections.Generic.Dictionary<System.String,System.Object> options) { }

	// RVA: 0xE22988
	public static bool StartSingularSessionWithLaunchURL(string key, string secret, string url) { }

	// RVA: 0xE22AAC
	public static void RestartSingularSession(string key, string secret) { }

	// RVA: 0xE22B1C
	public static void EndSingularSession() { }

	// RVA: 0xE22B8C
	public static void Event(string name) { }

	// RVA: 0xE22CCC
	public static void Event(System.Collections.Generic.Dictionary<System.String,System.Object> args, string name) { }

	// RVA: 0xE2412C
	public static void Event(string name, object[] args) { }

	// RVA: 0xE24490
	public static void SetDeviceCustomUserId(string customUserId) { }

	// RVA: 0xE245CC
	public static void SetAge(int age) { }

	// RVA: 0xE24804
	public static void SetGender(string gender) { }

	// RVA: 0xE24A48
	public static void SetAllowAutoIAPComplete(bool allowed) { }

	// RVA: 0xE24BC4
	private void OnApplicationPause(bool paused) { }

	// RVA: 0xE24E54
	private void OnApplicationQuit() { }

	// RVA: 0xE24FD8
	public static void SetDeferredDeepLinkHandler(SingularDeferredDeepLinkHandler ddlHandler) { }

	// RVA: 0xE2533C
	public void DeepLinkHandler(string message) { }

	// RVA: 0xE2559C
	private static int CurrentTimeSec() { }

	// RVA: 0xE25678
	public static void SetSingularLinkHandler(SingularLinkHandler handler) { }

	// RVA: 0xE25A90
	public static void SetSingularDeviceAttributionCallbackHandler(SingularDeviceAttributionCallbackHandler handler) { }

	// RVA: 0xE25B54
	private void SingularLinkHandlerResolved(string handlerParamsJson) { }

	// RVA: 0xE25C50
	private void SingularDeviceAttributionCallback(string handlerParamsJson) { }

	// RVA: 0xE25E5C
	private void ShortLinkResolved(string json) { }

	// RVA: 0xE25FDC
	public static void SetConversionValueUpdatedHandler(SingularConversionValueUpdatedHandler handler) { }

	// RVA: 0xE260A0
	public static void SetConversionValuesUpdatedHandler(SingularConversionValuesUpdatedHandler handler) { }

	// RVA: 0xE26164
	private void ConversionValueUpdated(string value) { }

	// RVA: 0xE262B8
	private void ConversionValuesUpdated(string json) { }

	// RVA: 0xE257C0
	private void ResolveSingularLink() { }

	// RVA: 0xE26450
	public static void RegisterDeviceTokenForUninstall(string APNSToken) { }

	// RVA: 0xE265B4
	public static string GetAPID() { }

	// RVA: 0xE26678
	public static string GetIDFA() { }

	// RVA: 0xE2673C
	public static void SetSingularSdidAccessorHandler(SingularSdidAccessorHandler handler) { }

	// RVA: 0xE26800
	private void SingularDidSetSdid(string result) { }

	// RVA: 0xE26960
	private void SingularSdidReceived(string result) { }

	// RVA: 0xE26AC4
	public static void InAppPurchase(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE26B54
	public static void InAppPurchase(string eventName, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE26FEC
	public static void InAppPurchase(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE26E50
	public static void InAppPurchase(string eventName, Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE27178
	private static System.Collections.Generic.Dictionary<System.String,System.Object> BuildIOSPurchaseAttributes(Product product, System.Collections.Generic.Dictionary<System.String,System.Object> attributes, bool isRestored) { }

	// RVA: 0xE278D0
	private static string ExtractIOSTransactionReceipt(string receipt) { }

	// RVA: 0xE279FC
	public static void Revenue(string currency, Double amount) { }

	// RVA: 0xE2707C
	public static void CustomRevenue(string eventName, string currency, Double amount) { }

	// RVA: 0xE27AD8
	public static void Revenue(string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE27B48
	public static void CustomRevenue(string eventName, string currency, Double amount, string receipt, string signature) { }

	// RVA: 0xE27BB8
	public static void Revenue(string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE27D14
	public static void CustomRevenue(string eventName, string currency, Double amount, string productSKU, string productName, string productCategory, int productQuantity, Double productPrice) { }

	// RVA: 0xE27E8C
	public static void Revenue(string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE28038
	public static void CustomRevenue(string eventName, string currency, Double amount, System.Collections.Generic.Dictionary<System.String,System.Object> attributes) { }

	// RVA: 0xE2820C
	public static void RegisterTokenForUninstall(string token) { }

	// RVA: 0xE2828C
	public static void SetFCMDeviceToken(string fcmDeviceToken) { }

	// RVA: 0xE282FC
	public static void SetGCMDeviceToken(string gcmDeviceToken) { }

	// RVA: 0xE2836C
	public static void SetCustomUserId(string userId) { }

	// RVA: 0xE28434
	public static void UnsetCustomUserId() { }

	// RVA: 0xE284E4
	public static void TrackingOptIn() { }

	// RVA: 0xE28594
	public static void TrackingUnder13() { }

	// RVA: 0xE28644
	public static void StopAllTracking() { }

	// RVA: 0xE286F4
	public static void ResumeAllTracking() { }

	// RVA: 0xE287A4
	public static bool IsAllTrackingStopped() { }

	// RVA: 0xE288A4
	public static void LimitDataSharing(bool limitDataSharingValue) { }

	// RVA: 0xE28970
	public static bool GetLimitDataSharing() { }

	// RVA: 0xE28A3C
	public static void AdRevenue(SingularAdData adData) { }

	// RVA: 0xE28BB4
	public static System.Collections.Generic.Dictionary<System.String,System.String> GetGlobalProperties() { }

	// RVA: 0xE28D28
	public static bool SetGlobalProperty(string key, string value, bool overrideExisting) { }

	// RVA: 0xE29018
	public static void UnsetGlobalProperty(string key) { }

	// RVA: 0xE29154
	public static void ClearGlobalProperties() { }

	// RVA: 0xE29204
	public static void SkanRegisterAppForAdNetworkAttribution() { }

	// RVA: 0xE2926C
	public static bool SkanUpdateConversionValue(int conversionValue) { }

	// RVA: 0xE292D8
	public static void SkanUpdateConversionValue(int conversionValue, int coarse, bool _lock) { }

	// RVA: 0xE29350
	public static System.Nullable<System.Int32> SkanGetConversionValue() { }

	// RVA: 0xE29410
	public void .ctor() { }

	// RVA: 0xE29504
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

	// RVA: 0xE1ECE8
	public static void SetLogLevel(int level) { }

	// RVA: 0xE29634
	public static void EnableLogging(bool enable) { }

	// RVA: 0xE2968C
	public static void LogVerbose(string message) { }

	// RVA: 0xE1EE44
	public static void LogDebug(string message) { }

	// RVA: 0xE29850
	public static void LogInfo(string message) { }

	// RVA: 0xE24408
	public static void LogWarn(string message) { }

	// RVA: 0xE1F1F8
	public static void LogError(string message) { }

	// RVA: 0xE298D8
	public static void LogAssert(string message) { }

	// RVA: 0xE29714
	private static void TryLog(string message, LogLevel level, System.Action<System.String> logAction) { }

	// RVA: 0xE29960
	public void .ctor() { }

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
	internal static readonly __StaticArrayInitTypeSize=1420 8523609DCBA4301B637C47178808B8F70838F40D0686F289CFF3B5C4BE9AD013; // 0x277
}


