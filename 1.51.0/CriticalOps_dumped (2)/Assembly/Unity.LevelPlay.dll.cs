// Namespace: 
internal class <Module>
{}

// Namespace: 
public enum AdFormat
{
	// Fields
	public int value__; // 0x10
	public const AdFormat RewardedVideo = 0;
	public const AdFormat Interstitial = 1;
	public const AdFormat Banner = 2;
}

// Namespace: 
public class IronSource
{
	// Fields
	private IronSourceIAgent _platformAgent; // 0x10
	private static IronSource _instance; // 0x0
	public static string UNITY_PLUGIN_VERSION; // 0x8
	private static bool isUnsupportedPlatform; // 0x10

	// Methods

	// RVA: 0x14EDEE0
	private void .ctor() { }

	// RVA: 0x14EE3F8
	public static IronSource get_Agent() { }

	// RVA: 0x14EE4E0
	public static string pluginVersion() { }

	// RVA: 0x14EE55C
	public static string unityVersion() { }

	// RVA: 0x14EE5CC
	public static void setUnsupportedPlatform() { }

	// RVA: 0x14EE650
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14EE70C
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14EE7C4
	public string getAdvertiserId() { }

	// RVA: 0x14EE87C
	public void validateIntegration() { }

	// RVA: 0x14EE934
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14EE9EC
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14EEAA4
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14EEB5C
	public void setMetaData(string key, string value) { }

	// RVA: 0x14EEC1C
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14EECDC
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14EED94
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14EEE4C
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14EEF0C
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14EEFC4
	public void setUserId(string userId) { }

	// RVA: 0x14EF07C
	public void init(string appKey) { }

	// RVA: 0x14EF134
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14EF1F4
	public void loadRewardedVideo() { }

	// RVA: 0x14EF2AC
	public void showRewardedVideo() { }

	// RVA: 0x14EF364
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14EF41C
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14EF4D4
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14EF58C
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14EF644
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14EF6FC
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14EF7B4
	public void loadInterstitial() { }

	// RVA: 0x14EF86C
	public void showInterstitial() { }

	// RVA: 0x14EF924
	public void showInterstitial(string placementName) { }

	// RVA: 0x14EF9DC
	public bool isInterstitialReady() { }

	// RVA: 0x14EFA94
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14EFB4C
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14EFC0C
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14EFCDC
	public void destroyBanner() { }

	// RVA: 0x14EFD94
	public void displayBanner() { }

	// RVA: 0x14EFE4C
	public void hideBanner() { }

	// RVA: 0x14EFF04
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14EFFBC
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14F0074
	public float getDeviceScreenWidth() { }

	// RVA: 0x14F012C
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14F01E4
	public void setConsent(bool consent) { }

	// RVA: 0x14F029C
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14F0354
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14F040C
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14F04CC
	public void launchTestSuite() { }

	// RVA: 0x14F0584
	private static void .cctor() { }

}

// Namespace: 
public class IronSourceAdInfo
{
	// Fields
	public readonly string auctionId; // 0x10
	public readonly string creativeId; // 0x18
	public readonly string adUnit; // 0x20
	public readonly string country; // 0x28
	public readonly string ab; // 0x30
	public readonly string segmentName; // 0x38
	public readonly string adNetwork; // 0x40
	public readonly string instanceName; // 0x48
	public readonly string instanceId; // 0x50
	public readonly System.Nullable<System.Double> revenue; // 0x58
	public readonly string precision; // 0x68
	public readonly System.Nullable<System.Double> lifetimeRevenue; // 0x70
	public readonly string encryptedCPM; // 0x80

	// Methods

	// RVA: 0x14F05F0
	public void .ctor(string json) { }

	// RVA: 0x14F0D08
	public override string ToString() { }

}

// Namespace: 
public class IronSourceBannerEvents
{
	// Fields
	private static System.Action<IronSourceAdInfo> _onAdLoadedEvent; // 0x0
	private static System.Action<IronSourceError> _onAdLoadFailedEvent; // 0x8
	private static System.Action<IronSourceAdInfo> _onAdClickedEvent; // 0x10
	private static System.Action<IronSourceAdInfo> _onAdScreenPresentedEvent; // 0x18
	private static System.Action<IronSourceAdInfo> _onAdScreenDismissedEvent; // 0x20
	private static System.Action<IronSourceAdInfo> _onAdLeftApplicationEvent; // 0x28

	// Methods

	// RVA: 0x14F1234
	private void Awake() { }

	// RVA: 0x14F12E8
	private static void add__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F13B8
	private static void remove__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1488
	public static void add_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1528
	public static void remove_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F15C8
	public void onAdLoaded(string args) { }

	// RVA: 0x14F1680
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F1754
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F1828
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F18C8
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F1968
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14F1CB0
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1D84
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1E58
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1EF8
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F1F98
	public void onAdClicked(string args) { }

	// RVA: 0x14F2050
	private static void add__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2124
	private static void remove__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F21F8
	public static void add_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2298
	public static void remove_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2338
	public void onAdScreenPresented(string args) { }

	// RVA: 0x14F23F0
	private static void add__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F24C4
	private static void remove__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2598
	public static void add_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2638
	public static void remove_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F26D8
	public void onAdScreenDismissed(string args) { }

	// RVA: 0x14F2790
	private static void add__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2864
	private static void remove__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2938
	public static void add_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F29D8
	public static void remove_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F2A78
	public void onAdLeftApplication(string args) { }

	// RVA: 0x14F1A00
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14F2B74
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14F2E88
	public void .ctor() { }

}

// Namespace: 
public class IronSourceConfig
{
	// Fields
	private const string unsupportedPlatformStr = "Unsupported Platform";
	private static IronSourceConfig _instance; // 0x0

	// Methods

	// RVA: 0x14F2E90
	public static IronSourceConfig get_Instance() { }

	// RVA: 0x14F2F44
	private static extern void CFSetLanguage(string language) { }

	// RVA: 0x14F2F6C
	private static extern void CFSetClientSideCallbacks(bool useClientSideCallbacks) { }

	// RVA: 0x14F2F70
	private static extern void CFSetRewardedVideoCustomParams(string rewardedVideoCustomParams) { }

	// RVA: 0x14F2F98
	public void setLanguage(string language) { }

	// RVA: 0x14F2FC4
	public void setClientSideCallbacks(bool status) { }

	// RVA: 0x14F2FCC
	public void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<System.String,System.String> rewardedVideoCustomParams) { }

	// RVA: 0x14F2F3C
	public void .ctor() { }

}

// Namespace: 
public static class IronSourceConstants
{
	// Fields
	public const string GET_INSTANCE_KEY = "getInstance";
	public const string ERROR_CODE = "error_code";
	public const string ERROR_DESCRIPTION = "error_description";
	public const string EMPTY_STRING = "";
	public const string LevelPlayinterstitialBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityLevelPlayInterstitialListener";
	public const string LevelPlayRewardedVideoBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityLevelPlayRewardedVideoListener";
	public const string LevelPlayRewardedVideoManualBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityLevelPlayRewardedVideoManualListener";
	public const string bridgeClass = "com.ironsource.unity.androidbridge.AndroidBridge";
	public const string LevelPlaybannerBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityLevelPlayBannerListener";
	public const string segmentBridgeListenerClass = "com.ironsource.unity.androidbridge.UnitySegmentListener";
	public const string impressionDataBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityImpressionDataListener";
	public const string initializeBridgeListenerClass = "com.ironsource.unity.androidbridge.UnityInitializationListener";
	public const string IMPRESSION_DATA_KEY_AUCTION_ID = "auctionId";
	internal const string k_ImpressionDataKeyCreativeID = "creativeId";
	public const string IMPRESSION_DATA_KEY_AD_UNIT = "adUnit";
	internal const string IMPRESSION_DATA_KEY_AD_FORMAT = "adFormat";
	internal const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_NAME = "mediationAdUnitName";
	internal const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_ID = "mediationAdUnitId";
	public const string IMPRESSION_DATA_KEY_COUNTRY = "country";
	public const string IMPRESSION_DATA_KEY_ABTEST = "ab";
	public const string IMPRESSION_DATA_KEY_SEGMENT_NAME = "segmentName";
	public const string IMPRESSION_DATA_KEY_PLACEMENT = "placement";
	public const string IMPRESSION_DATA_KEY_AD_NETWORK = "adNetwork";
	public const string IMPRESSION_DATA_KEY_INSTANCE_NAME = "instanceName";
	public const string IMPRESSION_DATA_KEY_INSTANCE_ID = "instanceId";
	public const string IMPRESSION_DATA_KEY_REVENUE = "revenue";
	public const string IMPRESSION_DATA_KEY_PRECISION = "precision";
	public const string IMPRESSION_DATA_KEY_LIFETIME_REVENUE = "lifetimeRevenue";
	public const string IMPRESSION_DATA_KEY_ENCRYPTED_CPM = "encryptedCPM";
	public const string IMPRESSION_DATA_KEY_CONVERSION_VALUE = "conversionValue";
	public const string GENDER_MALE = "male";
	public const string GENDER_FEMALE = "female";
	public const string GENDER_UNKNOWN = "unknown";
	public const string IRONSOURCE_MEDIATION_SETTING_NAME = "IronSourceMediationSettings";
	public const string IRONSOURCE_MEDIATED_NETWORK_SETTING_NAME = "IronSourceMediatedNetworkSettings";
	public const string IRONSOURCE_RESOURCES_PATH = "Assets/LevelPlay/Resources";
	public const string IRONSOURCE_SKAN_ID_KEY = "su67r6k2v3.skadnetwork";
}

// Namespace: 
public class IronSourceError
{
	// Fields
	private string description; // 0x10
	private int code; // 0x18

	// Methods

	// RVA: 0x14F3000
	public int getErrorCode() { }

	// RVA: 0x14F3008
	public string getDescription() { }

	// RVA: 0x14F3010
	public int getCode() { }

	// RVA: 0x14F2B30
	public void .ctor(int errorCode, string errorDescription) { }

	// RVA: 0x14F3018
	public override string ToString() { }

}

// Namespace: 
private sealed class ISUnityBackgroundCallback
{
	// Methods

	// RVA: 0x14F3478
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14F61B8
	public virtual void Invoke(string args) { }

	// RVA: 0x14F61CC
	public virtual IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x14F621C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class IronSourceEvents
{
	// Fields
	private const string ERROR_CODE = "error_code";
	private const string ERROR_DESCRIPTION = "error_description";
	private static System.Action<IronSourceImpressionData> onImpressionDataReadyEvent; // 0x0
	private static Action _onSdkInitializationCompletedEvent; // 0x8
	private static System.Action<System.String> _onSegmentReceivedEvent; // 0x10
	private static System.Action<System.String,IronSourceError> _onConsentViewDidFailToLoadWithErrorEvent; // 0x18
	private static System.Action<System.String,IronSourceError> _onConsentViewDidFailToShowWithErrorEvent; // 0x20
	private static System.Action<System.String> _onConsentViewDidAcceptEvent; // 0x28
	private static System.Action<System.String> _onConsentViewDidDismissEvent; // 0x30
	private static System.Action<System.String> _onConsentViewDidLoadSuccessEvent; // 0x38
	private static System.Action<System.String> _onConsentViewDidShowSuccessEvent; // 0x40

	// Methods

	// RVA: 0x14F3134
	private static extern void RegisterCallback(ISUnityBackgroundCallback func) { }

	// RVA: 0x14F3148
	public static void add_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x14F3218
	public static void remove_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x14F32E8
	private void Awake() { }

	// RVA: 0x14F307C
	public static void FireCallback(string args) { }

	// RVA: 0x14F35A8
	private static void add__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14F366C
	private static void remove__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14F3730
	public static void add_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14F3854
	public static void remove_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14F3978
	public void onSdkInitializationCompleted(string empty) { }

	// RVA: 0x14F39E0
	private static void add__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14F3AB4
	private static void remove__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14F3B88
	public static void add_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14F3C28
	public static void remove_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14F3CC8
	public void onSegmentReceived(string segmentName) { }

	// RVA: 0x14F3D44
	private static void add__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F3E18
	private static void remove__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F3EEC
	public static void add_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F3F8C
	public static void remove_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F402C
	public void onConsentViewDidFailToLoadWithError(string args) { }

	// RVA: 0x14F442C
	private static void add__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F4500
	private static void remove__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F45D4
	public static void add_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F4674
	public static void remove_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14F4714
	public void onConsentViewDidFailToShowWithError(string args) { }

	// RVA: 0x14F4864
	private static void add__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4938
	private static void remove__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4A0C
	public static void add_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4AAC
	public static void remove_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4B4C
	public void onConsentViewDidAccept(string consentViewType) { }

	// RVA: 0x14F4BC8
	private static void add__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4C9C
	private static void remove__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4D70
	public static void add_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4E10
	public static void remove_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14F4EB0
	public void onConsentViewDidDismiss(string consentViewType) { }

	// RVA: 0x14F4F2C
	private static void add__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5000
	private static void remove__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F50D4
	public static void add_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5174
	public static void remove_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5214
	public void onConsentViewDidLoadSuccess(string consentViewType) { }

	// RVA: 0x14F5290
	private static void add__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5364
	private static void remove__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5438
	public static void add_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F54D8
	public static void remove_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14F5578
	public void onConsentViewDidShowSuccess(string consentViewType) { }

	// RVA: 0x14F417C
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14F55F4
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14F352C
	private static void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args) { }

	// RVA: 0x14F61B0
	public void .ctor() { }

}

// Namespace: 
public class IronSourceEventsDispatcher
{
	// Fields
	private static IronSourceEventsDispatcher instance; // 0x0
	private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue; // 0x8

	// Methods

	// RVA: 0x14F6228
	public static void executeAction(Action action) { }

	// RVA: 0x14F637C
	private void Update() { }

	// RVA: 0x14F6600
	public void removeFromParent() { }

	// RVA: 0x14F6710
	public static void initialize() { }

	// RVA: 0x14F690C
	public static bool isCreated() { }

	// RVA: 0x14F69D8
	public void Awake() { }

	// RVA: 0x14F6A64
	public void OnDisable() { }

	// RVA: 0x14F6ACC
	public void .ctor() { }

	// RVA: 0x14F6AD4
	private static void .cctor() { }

}

// Namespace: 
public interface IronSourceIAgent
{
	// Methods

	// RVA: -1
	public abstract void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: -1
	public abstract void onApplicationPause(bool pause) { }

	// RVA: -1
	public abstract string getAdvertiserId() { }

	// RVA: -1
	public abstract void validateIntegration() { }

	// RVA: -1
	public abstract void shouldTrackNetworkState(bool track) { }

	// RVA: -1
	public abstract bool setDynamicUserId(string dynamicUserId) { }

	// RVA: -1
	public abstract void setAdaptersDebug(bool enabled) { }

	// RVA: -1
	public abstract void setMetaData(string key, string value) { }

	// RVA: -1
	public abstract void setMetaData(string key, string[] values) { }

	// RVA: -1
	public abstract System.Nullable<System.Int32> getConversionValue() { }

	// RVA: -1
	public abstract void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: -1
	public abstract void setNetworkData(string networkKey, string networkData) { }

	// RVA: -1
	public abstract void SetPauseGame(bool pause) { }

	// RVA: -1
	public abstract void setUserId(string userId) { }

	// RVA: -1
	public abstract void init(string appKey) { }

	// RVA: -1
	public abstract void init(string appKey, string[] adUnits) { }

	// RVA: -1
	public abstract void loadRewardedVideo() { }

	// RVA: -1
	public abstract void showRewardedVideo() { }

	// RVA: -1
	public abstract void showRewardedVideo(string placementName) { }

	// RVA: -1
	public abstract bool isRewardedVideoAvailable() { }

	// RVA: -1
	public abstract bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: -1
	public abstract IronSourcePlacement getPlacementInfo(string name) { }

	// RVA: -1
	public abstract void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: -1
	public abstract void clearRewardedVideoServerParams() { }

	// RVA: -1
	public abstract void loadInterstitial() { }

	// RVA: -1
	public abstract void showInterstitial() { }

	// RVA: -1
	public abstract void showInterstitial(string placementName) { }

	// RVA: -1
	public abstract bool isInterstitialReady() { }

	// RVA: -1
	public abstract bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: -1
	public abstract void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: -1
	public abstract void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: -1
	public abstract void destroyBanner() { }

	// RVA: -1
	public abstract void displayBanner() { }

	// RVA: -1
	public abstract void hideBanner() { }

	// RVA: -1
	public abstract bool isBannerPlacementCapped(string placementName) { }

	// RVA: -1
	public abstract float getMaximalAdaptiveHeight(float width) { }

	// RVA: -1
	public abstract float getDeviceScreenWidth() { }

	// RVA: -1
	public abstract void setSegment(IronSourceSegment segment) { }

	// RVA: -1
	public abstract void setConsent(bool consent) { }

	// RVA: -1
	public abstract void loadConsentViewWithType(string consentViewType) { }

	// RVA: -1
	public abstract void showConsentViewWithType(string consentViewType) { }

	// RVA: -1
	public abstract void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: -1
	public abstract void launchTestSuite() { }

}

// Namespace: 
public static class dataSource
{
	// Methods

	// RVA: 0x14F6B84
	public static string get_MOPUB() { }

}

// Namespace: 
public static class IronSourceAdUnits
{
	// Methods

	// RVA: 0x14F6BC8
	public static string get_REWARDED_VIDEO() { }

	// RVA: 0x14F6C0C
	public static string get_INTERSTITIAL() { }

	// RVA: 0x14F6C50
	public static string get_OFFERWALL() { }

	// RVA: 0x14F6C94
	public static string get_BANNER() { }

}

// Namespace: 
public class IronSourceBannerSize
{
	// Fields
	private int width; // 0x10
	private int height; // 0x14
	private string description; // 0x18
	private bool isAdaptive; // 0x20
	private ISContainerParams isContainerParams; // 0x28
	private bool respectAndroidCutouts; // 0x30
	public static IronSourceBannerSize BANNER; // 0x0
	public static IronSourceBannerSize LARGE; // 0x8
	public static IronSourceBannerSize RECTANGLE; // 0x10
	public static IronSourceBannerSize SMART; // 0x18

	// Methods

	// RVA: 0x14F6CD8
	private void .ctor() { }

	// RVA: 0x14F6D84
	public void .ctor(int width, int height) { }

	// RVA: 0x14F6E3C
	public void .ctor(string description) { }

	// RVA: 0x14F6ED8
	public void SetAdaptive(bool adaptive, int customWidth) { }

	// RVA: 0x14F6F68
	public bool IsAdaptiveEnabled() { }

	// RVA: 0x14F6F70
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14F6F78
	public ISContainerParams getBannerContainerParams() { }

	// RVA: 0x14F6F80
	public void SetRespectAndroidCutouts(bool respectAndroidCutouts) { }

	// RVA: 0x14F6F88
	public bool IsRespectAndroidCutoutsEnabled() { }

	// RVA: 0x14F6F90
	public string get_Description() { }

	// RVA: 0x14F6F98
	public int get_Width() { }

	// RVA: 0x14F6FA0
	public int get_Height() { }

	// RVA: 0x14F6FA8
	private static void .cctor() { }

}

// Namespace: 
public enum IronSourceBannerPosition
{
	// Fields
	public int value__; // 0x10
	public const IronSourceBannerPosition TOP = 1;
	public const IronSourceBannerPosition BOTTOM = 2;
}

// Namespace: 
public class ISContainerParams
{
	// Fields
	private float <Width>k__BackingField; // 0x10
	private float <Height>k__BackingField; // 0x14

	// Methods

	// RVA: 0x14F728C
	public float get_Width() { }

	// RVA: 0x14F7294
	public void set_Width(float value) { }

	// RVA: 0x14F729C
	public float get_Height() { }

	// RVA: 0x14F72A4
	public void set_Height(float value) { }

	// RVA: 0x14F6D58
	public void .ctor() { }

}

// Namespace: 
public class IronSourceImpressionData
{
	// Fields
	public readonly string auctionId; // 0x10
	public readonly string CreativeId; // 0x18
	public readonly string adUnit; // 0x20
	public readonly string adFormat; // 0x28
	public readonly string mediationAdUnitName; // 0x30
	public readonly string mediationAdUnitId; // 0x38
	public readonly string country; // 0x40
	public readonly string ab; // 0x48
	public readonly string segmentName; // 0x50
	public readonly string placement; // 0x58
	public readonly string adNetwork; // 0x60
	public readonly string instanceName; // 0x68
	public readonly string instanceId; // 0x70
	public readonly System.Nullable<System.Double> revenue; // 0x78
	public readonly string precision; // 0x88
	public readonly System.Nullable<System.Double> lifetimeRevenue; // 0x90
	public readonly string encryptedCPM; // 0xA0
	public readonly System.Nullable<System.Int32> conversionValue; // 0xA8
	public readonly string allData; // 0xB0

	// Methods

	// RVA: 0x14F58AC
	public void .ctor(string json) { }

	// RVA: 0x14F72AC
	public override string ToString() { }

}

// Namespace: 
public class IronSourceInitilizer
{
	// Methods

	// RVA: 0x14F7988
	private static void Initilize() { }

	// RVA: 0x14F7E58
	public void .ctor() { }

}

// Namespace: 
public class IronSourceInterstitialEvents
{
	// Fields
	private static System.Action<IronSourceAdInfo> _onAdReadyEvent; // 0x0
	private static System.Action<IronSourceError> _onAdLoadFailedEvent; // 0x8
	private static System.Action<IronSourceAdInfo> _onAdOpenedEvent; // 0x10
	private static System.Action<IronSourceAdInfo> _onAdClosedEvent; // 0x18
	private static System.Action<IronSourceAdInfo> _onAdShowSucceededEvent; // 0x20
	private static System.Action<IronSourceError,IronSourceAdInfo> _onAdShowFailedEvent; // 0x28
	private static System.Action<IronSourceAdInfo> _onAdClickedEvent; // 0x30

	// Methods

	// RVA: 0x14F7E60
	private void Awake() { }

	// RVA: 0x14F7F14
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F7FE4
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F80B4
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8154
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F81F4
	public void onAdReady(string args) { }

	// RVA: 0x14F82AC
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F8380
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F8454
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F84F4
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14F8594
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14F88DC
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F89B0
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8A84
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8B24
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8BC4
	public void onAdOpened(string args) { }

	// RVA: 0x14F8C7C
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8D50
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8E24
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8EC4
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F8F64
	public void onAdClosed(string args) { }

	// RVA: 0x14F901C
	private static void add__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F90F0
	private static void remove__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F91C4
	public static void add_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F9264
	public static void remove_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F9304
	public void onAdShowSucceeded(string args) { }

	// RVA: 0x14F93BC
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14F9490
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14F9564
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14F9604
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14F96A4
	public void onAdShowFailed(string args) { }

	// RVA: 0x14F9810
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F98E4
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F99B8
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F9A58
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14F9AF8
	public void onAdClicked(string args) { }

	// RVA: 0x14F862C
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14F9BB0
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14F9E68
	public void .ctor() { }

}

// Namespace: 
public class IronSourceMediationSettings
{
	// Fields
	public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH; // 0x0
	public string AndroidAppKey; // 0x18
	public string IOSAppKey; // 0x20
	public bool EnableIronsourceSDKInitAPI; // 0x28
	public bool AddIronsourceSkadnetworkID; // 0x29
	public bool DeclareAD_IDPermission; // 0x2A
	public bool EnableAdapterDebug; // 0x2B
	public bool EnableIntegrationHelper; // 0x2C

	// Methods

	// RVA: 0x14F9E70
	public void .ctor() { }

	// RVA: 0x14F9EC8
	private static void .cctor() { }

}

// Namespace: 
public class IronSourcePlacement
{
	// Fields
	private string rewardName; // 0x10
	private int rewardAmount; // 0x18
	private string placementName; // 0x20

	// Methods

	// RVA: 0x14F2E2C
	public void .ctor(string placementName, string rewardName, int rewardAmount) { }

	// RVA: 0x14F9F84
	public string getRewardName() { }

	// RVA: 0x14F9F8C
	public int getRewardAmount() { }

	// RVA: 0x14F9F94
	public string getPlacementName() { }

	// RVA: 0x14F9F9C
	public override string ToString() { }

}

// Namespace: 
public class IronSourceRewardedVideoEvents
{
	// Fields
	private static System.Action<IronSourceError,IronSourceAdInfo> _onAdShowFailedEvent; // 0x0
	private static System.Action<IronSourceAdInfo> _onAdOpenedEvent; // 0x8
	private static System.Action<IronSourceAdInfo> _onAdClosedEvent; // 0x10
	private static System.Action<IronSourcePlacement,IronSourceAdInfo> _onAdRewardedEvent; // 0x18
	private static System.Action<IronSourcePlacement,IronSourceAdInfo> _onAdClickedEvent; // 0x20
	private static System.Action<IronSourceAdInfo> _onAdAvailableEvent; // 0x28
	private static Action _onAdUnavailableEvent; // 0x30
	private static System.Action<IronSourceError> _onAdLoadFailedEvent; // 0x38
	private static System.Action<IronSourceAdInfo> _onAdReadyEvent; // 0x40

	// Methods

	// RVA: 0x14FA0C4
	private void Awake() { }

	// RVA: 0x14FA178
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14FA248
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14FA318
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14FA3B8
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14FA458
	public void onAdShowFailed(string args) { }

	// RVA: 0x14FA874
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FA948
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FAA1C
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FAABC
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FAB5C
	public void onAdOpened(string args) { }

	// RVA: 0x14FAC14
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FACE8
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FADBC
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FAE5C
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FAEFC
	public void onAdClosed(string args) { }

	// RVA: 0x14FAFB4
	private static void add__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB088
	private static void remove__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB15C
	public static void add_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB1FC
	public static void remove_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB29C
	public void onAdRewarded(string args) { }

	// RVA: 0x14FB6C0
	private static void add__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB794
	private static void remove__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB868
	public static void add_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB908
	public static void remove_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14FB9A8
	public void onAdClicked(string args) { }

	// RVA: 0x14FBB14
	private static void add__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FBBE8
	private static void remove__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FBCBC
	public static void add_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FBD5C
	public static void remove_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FBDFC
	public void onAdAvailable(string args) { }

	// RVA: 0x14FBEB4
	private static void add__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14FBF78
	private static void remove__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14FC03C
	public static void add_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14FC160
	public static void remove_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14FC284
	public void onAdUnavailable() { }

	// RVA: 0x14FC2EC
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14FC3C0
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14FC494
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14FC534
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14FC5D4
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14FC66C
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FC740
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FC814
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FC8B4
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14FC954
	public void onAdReady(string adinfo) { }

	// RVA: 0x14FA5C4
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14FB408
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14FCA0C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly IronSourceSegment.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__10_0; // 0x8
	public static System.Func<System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>>,System.String> <>9__10_1; // 0x10
	public static System.Func<System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>>,System.String> <>9__10_2; // 0x18

	// Methods

	// RVA: 0x14FD030
	private static void .cctor() { }

	// RVA: 0x14FD09C
	public void .ctor() { }

	// RVA: 0x14FD0A4
	internal string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> d) { }

	// RVA: 0x14FD16C
	internal string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

	// RVA: 0x14FD21C
	internal string <getSegmentAsDict>b__10_2(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

}

// Namespace: 
public class IronSourceSegment
{
	// Fields
	public int age; // 0x10
	public string gender; // 0x18
	public int level; // 0x20
	public int isPaying; // 0x24
	public Int64 userCreationDate; // 0x28
	public Double iapt; // 0x30
	public string segmentName; // 0x38
	public System.Collections.Generic.Dictionary<System.String,System.String> customs; // 0x40

	// Methods

	// RVA: 0x14FCA14
	public void .ctor() { }

	// RVA: 0x14FCAB8
	public void setCustom(string key, string value) { }

	// RVA: 0x14FCB24
	public System.Collections.Generic.Dictionary<System.String,System.String> getSegmentAsDict() { }

}

// Namespace: 
public class IronSourceUtils
{
	// Fields
	private const string ERROR_CODE = "error_code";
	private const string ERROR_DESCRIPTION = "error_description";
	private const string INSTANCE_ID_KEY = "instanceId";
	private const string PLACEMENT_KEY = "placement";

	// Methods

	// RVA: 0x14FD31C
	public static IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14FD5CC
	public static IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14FD884
	public void .ctor() { }

}

// Namespace: 
public interface IUnityImpressionData
{
	// Methods

	// RVA: -1
	public abstract void add_OnImpressionDataReady(System.Action<IronSourceImpressionData> value) { }

	// RVA: -1
	public abstract void remove_OnImpressionDataReady(System.Action<IronSourceImpressionData> value) { }

	// RVA: -1
	public abstract void add_OnImpressionSuccess(System.Action<IronSourceImpressionData> value) { }

	// RVA: -1
	public abstract void remove_OnImpressionSuccess(System.Action<IronSourceImpressionData> value) { }

}

// Namespace: 
public interface IUnityInitialization
{
	// Methods

	// RVA: -1
	public abstract void add_OnSdkInitializationCompletedEvent(Action value) { }

	// RVA: -1
	public abstract void remove_OnSdkInitializationCompletedEvent(Action value) { }

}

// Namespace: 
public interface IUnityLevelPlayBanner
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLeftApplication(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLeftApplication(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdScreenDismissed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdScreenDismissed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdScreenPresented(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdScreenPresented(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

}

// Namespace: 
public interface IUnityLevelPlayInterstitial
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: -1
	public abstract void add_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdShowSucceeded(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdShowSucceeded(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

}

// Namespace: 
public interface IUnityLevelPlayRewardedVideo
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdRewarded(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdRewarded(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdAvailable(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdAvailable(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdUnavailable(Action value) { }

	// RVA: -1
	public abstract void remove_OnAdUnavailable(Action value) { }

}

// Namespace: 
public interface IUnityLevelPlayRewardedVideoManual
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

}

// Namespace: 
public interface IUnitySegment
{
	// Methods

	// RVA: -1
	public abstract void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: -1
	public abstract void remove_OnSegmentRecieved(System.Action<System.String> value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly IronSourceSegmentAndroid.<>c <>9; // 0x0
	public static System.Action<System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14FDEE8
	private static void .cctor() { }

	// RVA: 0x14FDF54
	public void .ctor() { }

	// RVA: 0x14FDF5C
	internal void <.ctor>b__3_0(string <p0>) { }

}

// Namespace: 
public class IronSourceSegmentAndroid
{
	// Fields
	private System.Action<System.String> OnSegmentRecieved; // 0x20

	// Methods

	// RVA: 0x14FD88C
	public void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14FD940
	public void remove_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14FD9F4
	public void .ctor() { }

	// RVA: 0x14FDECC
	public void onSegmentRecieved(string segmentName) { }

}

// Namespace: 
private struct IOSWaterfallConfiguration
{
	// Fields
	public Double Floor; // 0x10
	public Double Ceiling; // 0x18
}

// Namespace: 
private sealed class ISUnityPauseGame
{
	// Methods

	// RVA: 0x14FF3C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14FF464
	public virtual void Invoke(bool pause) { }

	// RVA: 0x14FF478
	public virtual IAsyncResult BeginInvoke(bool pause, AsyncCallback callback, object object) { }

	// RVA: 0x14FF50C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class iOSAgent
{
	// Methods

	// RVA: 0x14FDF60
	private static extern void LPPSetWaterfallConfiguration(IOSWaterfallConfiguration configurationParams, AdFormat adFormat) { }

	// RVA: 0x14FDF64
	private static extern void CFSetPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14FDFD0
	private static extern string CFGetAdvertiserId() { }

	// RVA: 0x14FE004
	private static extern void CFValidateIntegration() { }

	// RVA: 0x14FE008
	private static extern void CFShouldTrackNetworkState(bool track) { }

	// RVA: 0x14FE00C
	private static extern bool CFSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14FE044
	private static extern void CFSetAdaptersDebug(bool enabled) { }

	// RVA: 0x14FE048
	private static extern void CFSetMetaData(string key, string value) { }

	// RVA: 0x14FE090
	private static extern void CFSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x14FE188
	private static extern string CFGetConversionValue() { }

	// RVA: 0x14FE1BC
	private static extern void CFSetManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14FE1C0
	private static extern void CFSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14FE208
	private static extern void RegisterPauseGameFunction(bool pasue) { }

	// RVA: 0x14FE20C
	private static extern void CFSetUserId(string userId) { }

	// RVA: 0x14FE234
	private static extern void CFInit(string appKey) { }

	// RVA: 0x14FE25C
	private static extern void CFInitWithAdUnits(string appKey, string[] adUnits) { }

	// RVA: 0x14FE354
	private static extern void CFLoadRewardedVideo() { }

	// RVA: 0x14FE358
	private static extern void CFShowRewardedVideo() { }

	// RVA: 0x14FE35C
	private static extern void CFShowRewardedVideoWithPlacementName(string placementName) { }

	// RVA: 0x14FE384
	private static extern bool CFIsRewardedVideoAvailable() { }

	// RVA: 0x14FE3A0
	private static extern bool CFIsRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14FE3D8
	private static extern string CFGetPlacementInfo(string placementName) { }

	// RVA: 0x14FE424
	private static extern void CFSetRewardedVideoServerParameters(string jsonString) { }

	// RVA: 0x14FE44C
	private static extern void CFClearRewardedVideoServerParameters() { }

	// RVA: 0x14FE450
	private static extern void CFLoadInterstitial() { }

	// RVA: 0x14FE454
	private static extern void CFShowInterstitial() { }

	// RVA: 0x14FE458
	private static extern void CFShowInterstitialWithPlacementName(string placementName) { }

	// RVA: 0x14FE480
	private static extern bool CFIsInterstitialReady() { }

	// RVA: 0x14FE49C
	private static extern bool CFIsInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14FE4D4
	private static extern void CFLoadBanner(string description, int width, int height, int position, string placementName, bool isAdaptive, float containerWidth, float containerHeight) { }

	// RVA: 0x14FE564
	private static extern void CFDestroyBanner() { }

	// RVA: 0x14FE568
	private static extern void CFDisplayBanner() { }

	// RVA: 0x14FE56C
	private static extern void CFHideBanner() { }

	// RVA: 0x14FE570
	private static extern bool CFIsBannerPlacementCapped(string placementName) { }

	// RVA: 0x14FE5A8
	private static extern float CFIGetMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14FE5AC
	private static extern float CFIGetDeviceScreenWidth() { }

	// RVA: 0x14FE5B0
	private static extern void CFSetSegment(string json) { }

	// RVA: 0x14FE5D8
	private static extern void CFSetConsent(bool consent) { }

	// RVA: 0x14FE5DC
	private static extern void CFLoadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FE604
	private static extern void CFShowConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FE62C
	private static extern void CFSetAdRevenueData(string dataSource, string impressionData) { }

	// RVA: 0x14FE674
	private static extern void CFLaunchTestSuite() { }

	// RVA: 0x14EE390
	public void .ctor() { }

	// RVA: 0x14FE678
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14FE7FC
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14FE800
	public string getAdvertiserId() { }

	// RVA: 0x14FE834
	public void validateIntegration() { }

	// RVA: 0x14FE838
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14FE840
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14FE87C
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14FE884
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14FE890
	public void setMetaData(string key, string value) { }

	// RVA: 0x14FE8DC
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14FE9E0
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14FE9E8
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14FEA34
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14FEAEC
	public void setUserId(string userId) { }

	// RVA: 0x14FEB18
	public void init(string appKey) { }

	// RVA: 0x14FEC90
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14FEE08
	public void loadRewardedVideo() { }

	// RVA: 0x14FEE0C
	public void showRewardedVideo() { }

	// RVA: 0x14FEE10
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14FEE3C
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14FEE58
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14FEE94
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14FF0C0
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14FF0F0
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14FF0F4
	public void loadInterstitial() { }

	// RVA: 0x14FF0F8
	public void showInterstitial() { }

	// RVA: 0x14FF0FC
	public void showInterstitial(string placementName) { }

	// RVA: 0x14FF128
	public bool isInterstitialReady() { }

	// RVA: 0x14FF144
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14FF180
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14FF1DC
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14FF278
	public void destroyBanner() { }

	// RVA: 0x14FF27C
	public void displayBanner() { }

	// RVA: 0x14FF280
	public void hideBanner() { }

	// RVA: 0x14FF284
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14FF2C0
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14FF2C4
	public float getDeviceScreenWidth() { }

	// RVA: 0x14FF2C8
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14FF304
	public void setConsent(bool consent) { }

	// RVA: 0x14FF30C
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FF338
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FF364
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14FF3BC
	public void launchTestSuite() { }

}

// Namespace: 
public class UnsupportedPlatformAgent
{
	// Methods

	// RVA: 0x14EE398
	public void .ctor() { }

	// RVA: 0x14FF518
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14FF51C
	public void start() { }

	// RVA: 0x14FF520
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14FF524
	public string getAdvertiserId() { }

	// RVA: 0x14FF568
	public void validateIntegration() { }

	// RVA: 0x14FF56C
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14FF570
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14FF578
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14FF57C
	public void setMetaData(string key, string value) { }

	// RVA: 0x14FF580
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14FF584
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14FF58C
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14FF590
	public void setNetworkData(string networkKey, string networkDataJson) { }

	// RVA: 0x14FF594
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14FF598
	public void setUserId(string userId) { }

	// RVA: 0x14FF59C
	public void init(string appKey) { }

	// RVA: 0x14FF5A0
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14FF5A4
	public void loadRewardedVideo() { }

	// RVA: 0x14FF5A8
	public void showRewardedVideo() { }

	// RVA: 0x14FF5AC
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14FF5B0
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14FF5B8
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14FF5C0
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14FF5C8
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14FF5CC
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14FF5D0
	public void loadInterstitial() { }

	// RVA: 0x14FF5D4
	public void showInterstitial() { }

	// RVA: 0x14FF5D8
	public void showInterstitial(string placementName) { }

	// RVA: 0x14FF5DC
	public bool isInterstitialReady() { }

	// RVA: 0x14FF5E4
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14FF5EC
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14FF5F0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14FF5F4
	public void destroyBanner() { }

	// RVA: 0x14FF5F8
	public void displayBanner() { }

	// RVA: 0x14FF5FC
	public void hideBanner() { }

	// RVA: 0x14FF600
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14FF608
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14FF610
	public float getDeviceScreenWidth() { }

	// RVA: 0x14FF618
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14FF61C
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14FF620
	public void setConsent(bool consent) { }

	// RVA: 0x14FF624
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FF628
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14FF62C
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14FF630
	public void launchTestSuite() { }

}

// Namespace: 
public class WaterfallConfigurationBuilder
{
	// Fields
	private System.Nullable<System.Double> ceiling; // 0x10
	private System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14FF734
	internal void .ctor() { }

	// RVA: 0x14FF804
	public WaterfallConfigurationBuilder SetCeiling(Double ceiling) { }

	// RVA: 0x14FF888
	public WaterfallConfigurationBuilder SetFloor(Double floor) { }

	// RVA: 0x14FF90C
	public WaterfallConfiguration Build() { }

}

// Namespace: 
public class WaterfallConfiguration
{
	// Fields
	private readonly System.Nullable<System.Double> ceiling; // 0x10
	private readonly System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14FF678
	public System.Nullable<System.Double> get_Ceiling() { }

	// RVA: 0x14FF684
	public System.Nullable<System.Double> get_Floor() { }

	// RVA: 0x14FF690
	private void .ctor(System.Nullable<System.Double> ceiling, System.Nullable<System.Double> floor) { }

	// RVA: 0x14FF6DC
	public static WaterfallConfigurationBuilder Builder() { }

	// RVA: 0x14FF73C
	public static WaterfallConfiguration Empty() { }

}

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

	// RVA: 0x14FF990
	private static MonoScriptData Get() { }

	// RVA: 0x14FFA94
	public void .ctor() { }

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
	private const string WHITE_SPACE = " 	
";
	private const string WORD_BREAK = " 	
{}[],:"";
	private StringReader json; // 0x10

	// Methods

	// RVA: 0x14FFD3C
	private void .ctor(string jsonString) { }

	// RVA: 0x14FFA9C
	public static object Parse(string jsonString) { }

	// RVA: 0x14FFDE4
	public void Dispose() { }

	// RVA: 0x14FFE20
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x15006EC
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x14FFDBC
	private object ParseValue() { }

	// RVA: 0x15007FC
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x1500250
	private string ParseString() { }

	// RVA: 0x15008B4
	private object ParseNumber() { }

	// RVA: 0x1500BE8
	private void EatWhitespace() { }

	// RVA: 0x1500CE0
	private Char get_PeekChar() { }

	// RVA: 0x15009D0
	private Char get_NextChar() { }

	// RVA: 0x1500A5C
	private string get_NextWord() { }

	// RVA: 0x14FFFAC
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x1500D6C
	private void .ctor() { }

	// RVA: 0x14FFC68
	public static string Serialize(object obj) { }

	// RVA: 0x1500DE4
	private void SerializeValue(object value) { }

	// RVA: 0x150158C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x1501244
	private void SerializeArray(IList anArray) { }

	// RVA: 0x1500F88
	private void SerializeString(string str) { }

	// RVA: 0x1501A10
	private void SerializeOther(object value) { }

}

// Namespace: IronSourceJSON
public static class Json
{
	// Methods

	// RVA: 0x14F0CFC
	public static object Deserialize(string json) { }

	// RVA: 0x14F2FFC
	public static string Serialize(object obj) { }

}

// Namespace: Unity.Services.LevelPlay
public interface ILevelPlayBannerAd
{
	// Methods

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void DestroyAd() { }

	// RVA: -1
	public abstract void ShowAd() { }

	// RVA: -1
	public abstract void HideAd() { }

	// RVA: -1
	public abstract string GetAdId() { }

	// RVA: -1
	public abstract string GetAdUnitId() { }

	// RVA: -1
	public abstract LevelPlayAdSize GetAdSize() { }

	// RVA: -1
	public abstract LevelPlayBannerPosition GetPosition() { }

	// RVA: -1
	public abstract string GetPlacementName() { }

	// RVA: -1
	public abstract void PauseAutoRefresh() { }

	// RVA: -1
	public abstract void ResumeAutoRefresh() { }

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

}

// Namespace: Unity.Services.LevelPlay
public interface ILevelPlayInterstitialAd
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract string GetAdId() { }

	// RVA: -1
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract void DestroyAd() { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: Unity.Services.LevelPlay
public interface ILevelPlayRewardedAd
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: -1
	public abstract void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract string GetAdId() { }

	// RVA: -1
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract void DestroyAd() { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Services.LevelPlay.LevelPlay.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1502F24
	private static void .cctor() { }

	// RVA: 0x1502F90
	public void .ctor() { }

	// RVA: 0x1502F98
	internal void <.cctor>b__22_0(LevelPlayConfiguration configuration) { }

	// RVA: 0x150303C
	internal void <.cctor>b__22_1(LevelPlayInitError error) { }

	// RVA: 0x15030E0
	internal void <.cctor>b__22_2(LevelPlayImpressionData impressionData) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlay
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccessReceived; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived; // 0x8
	private static System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> OnImpressionDataReadyReceived; // 0x10

	// Methods

	// RVA: 0x1501B04
	public static string get_UnityVersion() { }

	// RVA: 0x1501B74
	public static string get_PluginVersion() { }

	// RVA: 0x1501BB8
	private static void add_OnInitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1501CC8
	private static void remove_OnInitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1501DD8
	private static void add_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1501EEC
	private static void remove_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1502000
	private static void add_OnImpressionDataReadyReceived(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x1502114
	private static void remove_OnImpressionDataReadyReceived(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x1502228
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1502340
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1502454
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x150256C
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1502680
	public static void add_OnImpressionDataReady(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x1502798
	public static void remove_OnImpressionDataReady(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x15028AC
	private static void .cctor() { }

	// RVA: 0x14F7DDC
	public static void Init(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x1502A50
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x1502AD8
	public static bool SetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1502B60
	public static void ValidateIntegration() { }

	// RVA: 0x1502BD0
	public static void LaunchTestSuite() { }

	// RVA: 0x1502C40
	public static void SetAdaptersDebug(bool enabled) { }

	// RVA: 0x1502CC8
	public static void SetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x1502D34
	public static void SetMetaData(string key, string value) { }

	// RVA: 0x1502DA0
	public static void SetMetaData(string key, string[] values) { }

	// RVA: 0x1502E0C
	public static void SetConsent(bool consent) { }

	// RVA: 0x1502E94
	public static void SetSegment(LevelPlaySegment segment) { }

	// RVA: 0x1502F1C
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayAdDisplayInfoError
{
	// Fields
	private LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField; // 0x10
	private LevelPlayAdError <LevelPlayError>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1503184
	public LevelPlayAdInfo get_DisplayLevelPlayAdInfo() { }

	// RVA: 0x150318C
	private void set_DisplayLevelPlayAdInfo(LevelPlayAdInfo value) { }

	// RVA: 0x1503194
	public LevelPlayAdError get_LevelPlayError() { }

	// RVA: 0x150319C
	private void set_LevelPlayError(LevelPlayAdError value) { }

	// RVA: 0x15031A4
	internal void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

	// RVA: 0x15031F4
	public override string ToString() { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayAdError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18
	private readonly string <AdUnitId>k__BackingField; // 0x20
	private readonly string <AdId>k__BackingField; // 0x28

	// Methods

	// RVA: 0x1503298
	public int get_ErrorCode() { }

	// RVA: 0x15032A0
	public string get_ErrorMessage() { }

	// RVA: 0x15032A8
	public string get_AdUnitId() { }

	// RVA: 0x15032B0
	public string get_AdId() { }

	// RVA: 0x15032B8
	internal void .ctor(string json) { }

	// RVA: 0x15035D4
	internal void .ctor(string adUnitId, int errorCode, string errorMessage, string adId) { }

	// RVA: 0x1503648
	internal void .ctor(string adUnitId, int errorCode, string errorMessage) { }

	// RVA: 0x15036A0
	public override string ToString() { }

}

// Namespace: Unity.Services.LevelPlay
public enum LevelPlayAdFormat
{
	// Fields
	public int value__; // 0x10
	public const LevelPlayAdFormat BANNER = 0;
	public const LevelPlayAdFormat INTERSTITIAL = 1;
	public const LevelPlayAdFormat REWARDED = 2;
}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayAdInfo
{
	// Fields
	private const string AdIdKey = "adId";
	private const string AdUnitIdKey = "adUnitId";
	private const string AdUnitNameKey = "adUnitName";
	private const string AdSizeKey = "adSize";
	private const string AdFormatKey = "adFormat";
	private const string PlacementNameKey = "placementName";
	private const string AuctionIdKey = "auctionId";
	private const string CountryKey = "country";
	private const string AbKey = "ab";
	private const string SegmentNameKey = "segmentName";
	private const string AdNetworkKey = "adNetwork";
	private const string InstanceNameKey = "instanceName";
	private const string InstanceIdKey = "instanceId";
	private const string RevenueKey = "revenue";
	private const string PrecisionKey = "precision";
	private const string EncryptedCpmKey = "encryptedCPM";
	private const string AdSizeDescriptionKey = "description";
	private const string AdSizeWidthKey = "width";
	private const string AdSizeHeightKey = "height";
	public readonly string adUnitId; // 0x10
	public readonly string adUnitName; // 0x18
	public readonly LevelPlayAdSize adSize; // 0x20
	public readonly string adFormat; // 0x28
	public readonly string placementName; // 0x30
	public readonly string auctionId; // 0x38
	public readonly string country; // 0x40
	public readonly string ab; // 0x48
	public readonly string segmentName; // 0x50
	public readonly string adNetwork; // 0x58
	public readonly string instanceName; // 0x60
	public readonly string instanceId; // 0x68
	public readonly System.Nullable<System.Double> revenue; // 0x70
	public readonly string precision; // 0x80
	public readonly string encryptedCPM; // 0x88
	public readonly string AdId; // 0x90
	public readonly string AdUnitId; // 0x98
	public readonly string AdUnitName; // 0xA0
	public readonly LevelPlayAdSize AdSize; // 0xA8
	public readonly string AdFormat; // 0xB0
	public readonly string PlacementName; // 0xB8
	public readonly string AuctionId; // 0xC0
	public readonly string CreativeId; // 0xC8
	public readonly string Country; // 0xD0
	public readonly string Ab; // 0xD8
	public readonly string SegmentName; // 0xE0
	public readonly string AdNetwork; // 0xE8
	public readonly string InstanceName; // 0xF0
	public readonly string InstanceId; // 0xF8
	public readonly System.Nullable<System.Double> Revenue; // 0x100
	public readonly string Precision; // 0x110
	public readonly string EncryptedCPM; // 0x118

	// Methods

	// RVA: 0x1503838
	internal void .ctor(string json) { }

	// RVA: 0x1504374
	private static LevelPlayAdSize GetAdSize(string adSizeJson) { }

	// RVA: 0x1504630
	private static LevelPlayAdSize GetAdSize(string description, int width, int height) { }

	// RVA: 0x1504A14
	public override string ToString() { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayAdSize
{
	// Fields
	private IPlatformLevelPlayAdSize m_PlatformLevelPlayAdSize; // 0x10
	public static LevelPlayAdSize BANNER; // 0x0
	public static LevelPlayAdSize LARGE; // 0x8
	public static LevelPlayAdSize MEDIUM_RECTANGLE; // 0x10
	public static LevelPlayAdSize LEADERBOARD; // 0x18

	// Methods

	// RVA: 0x1504E90
	internal IPlatformLevelPlayAdSize GetPlatformLevelPlayAdSize() { }

	// RVA: 0x1504E98
	internal void .ctor() { }

	// RVA: 0x1504F94
	internal void .ctor(IPlatformLevelPlayAdSize adSize) { }

	// RVA: 0x1504F14
	private void .ctor(PlatformLevelPlayAdSizeType adSizeType) { }

	// RVA: 0x1504FC8
	private void .ctor(int width, int height) { }

	// RVA: 0x15048B8
	public static LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x1504980
	public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x1505058
	public string get_Description() { }

	// RVA: 0x15051A0
	public int get_Width() { }

	// RVA: 0x1505254
	public int get_Height() { }

	// RVA: 0x150530C
	public int get_CustomWidth() { }

	// RVA: 0x15053C0
	public override string ToString() { }

	// RVA: 0x15055A0
	private static void .cctor() { }

}

// Namespace: 
public class Builder
{
	// Fields
	private readonly IConfigBuilder m_Builder; // 0x10

	// Methods

	// RVA: 0x1507460
	public void .ctor() { }

	// RVA: 0x15074D8
	public Builder SetBidFloor(Double bidFloor) { }

	// RVA: 0x1507594
	public Builder SetSize(LevelPlayAdSize size) { }

	// RVA: 0x1507654
	public Builder SetPosition(LevelPlayBannerPosition position) { }

	// RVA: 0x1507714
	public Builder SetPlacementName(string placementName) { }

	// RVA: 0x15077D8
	public Builder SetDisplayOnLoad(bool displayOnLoad) { }

	// RVA: 0x1507898
	public Builder SetRespectSafeArea(bool respectSafeArea) { }

	// RVA: 0x1507958
	public Config Build() { }

}

// Namespace: 
public class Config
{
	// Fields
	private readonly IConfig <PlatformConfig>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1507424
	internal IConfig get_PlatformConfig() { }

	// RVA: 0x150742C
	private void .ctor(IConfig platformConfig) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayBannerAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication; // 0x48
	private bool _autoRefresh; // 0x50
	private readonly IPlatformBannerAd _bannerAd; // 0x58

	// Methods

	// RVA: 0x15057C0
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505874
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505928
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x15059DC
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1505A90
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505B44
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505BF8
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505CAC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505D60
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1505E14
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1505EC8
	public void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1505F7C
	public void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1506030
	public void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15060E4
	public void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1506198
	public void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150624C
	public void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1506300
	public void .ctor(string adUnitId, Config config) { }

	// RVA: 0x1506940
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

	// RVA: 0x1506A5C
	public void LoadAd() { }

	// RVA: 0x1506B14
	public void DestroyAd() { }

	// RVA: 0x1506BCC
	public void ShowAd() { }

	// RVA: 0x1506C84
	public void HideAd() { }

	// RVA: 0x1506D3C
	public string GetAdId() { }

	// RVA: 0x1506DF4
	public string GetAdUnitId() { }

	// RVA: 0x1506EAC
	public LevelPlayAdSize GetAdSize() { }

	// RVA: 0x1506F64
	public LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x150701C
	public string GetPlacementName() { }

	// RVA: 0x15070D4
	public void PauseAutoRefresh() { }

	// RVA: 0x150718C
	public void ResumeAutoRefresh() { }

	// RVA: 0x15063EC
	private void SetupCallbacks() { }

	// RVA: 0x1507244
	public void Dispose() { }

	// RVA: 0x1507304
	private void <SetupCallbacks>b__39_0(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1507328
	private void <SetupCallbacks>b__39_1(object sender, LevelPlayAdError args) { }

	// RVA: 0x150734C
	private void <SetupCallbacks>b__39_2(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1507370
	private void <SetupCallbacks>b__39_3(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1507394
	private void <SetupCallbacks>b__39_4(object sender, LevelPlayAdDisplayInfoError args) { }

	// RVA: 0x15073B8
	private void <SetupCallbacks>b__39_5(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x15073DC
	private void <SetupCallbacks>b__39_6(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1507400
	private void <SetupCallbacks>b__39_7(object sender, LevelPlayAdInfo args) { }

}

// Namespace: 
private enum Presets
{
	// Fields
	public int value__; // 0x10
	public const Presets TopLeft = 0;
	public const Presets TopCenter = 1;
	public const Presets TopRight = 2;
	public const Presets CenterLeft = 3;
	public const Presets Center = 4;
	public const Presets CenterRight = 5;
	public const Presets BottomLeft = 6;
	public const Presets BottomCenter = 7;
	public const Presets BottomRight = 8;
	public const Presets Custom = 9;
}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayBannerPosition
{
	// Fields
	internal readonly Vector2 Position; // 0x10
	public readonly string Description; // 0x18
	public static readonly LevelPlayBannerPosition TopLeft; // 0x0
	public static readonly LevelPlayBannerPosition TopCenter; // 0x8
	public static readonly LevelPlayBannerPosition TopRight; // 0x10
	public static readonly LevelPlayBannerPosition CenterLeft; // 0x18
	public static readonly LevelPlayBannerPosition Center; // 0x20
	public static readonly LevelPlayBannerPosition CenterRight; // 0x28
	public static readonly LevelPlayBannerPosition BottomLeft; // 0x30
	public static readonly LevelPlayBannerPosition BottomCenter; // 0x38
	public static readonly LevelPlayBannerPosition BottomRight; // 0x40

	// Methods

	// RVA: 0x1507A44
	private void .ctor(Presets presets, Vector2 position) { }

	// RVA: 0x1507AE8
	public void .ctor(Vector2 position) { }

	// RVA: 0x1507B8C
	public override string ToString() { }

	// RVA: 0x1507BE4
	private static void .cctor() { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayConfiguration
{
	// Fields
	private const string k_IsAdQualityEnabled = "isAdQualityEnabled";
	private readonly bool <IsAdQualityEnabled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x150808C
	public bool get_IsAdQualityEnabled() { }

	// RVA: 0x1508094
	internal void .ctor(string json) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayImpressionData
{
	// Fields
	private readonly string <AllData>k__BackingField; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.String,System.Object> InternalDictionary; // 0x18

	// Methods

	// RVA: 0x1508304
	public string get_AuctionId() { }

	// RVA: 0x1508498
	public string get_CreativeId() { }

	// RVA: 0x1508584
	public string get_AdFormat() { }

	// RVA: 0x1508670
	public string get_MediationAdUnitName() { }

	// RVA: 0x150875C
	public string get_MediationAdUnitId() { }

	// RVA: 0x1508848
	public string get_Country() { }

	// RVA: 0x1508934
	public string get_Ab() { }

	// RVA: 0x1508A20
	public string get_SegmentName() { }

	// RVA: 0x1508B0C
	public string get_Placement() { }

	// RVA: 0x1508BF8
	public string get_AdNetwork() { }

	// RVA: 0x1508CE4
	public string get_InstanceName() { }

	// RVA: 0x1508DD0
	public string get_InstanceId() { }

	// RVA: 0x1508EBC
	public System.Nullable<System.Double> get_Revenue() { }

	// RVA: 0x1509078
	public string get_Precision() { }

	// RVA: 0x1509164
	public string get_EncryptedCpm() { }

	// RVA: 0x1509250
	public System.Nullable<System.Int32> get_ConversionValue() { }

	// RVA: 0x15093E0
	public string get_AllData() { }

	// RVA: 0x15093E8
	internal void .ctor(string levelplayImpressionJson) { }

	// RVA: 0x1509434
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseJson(string json) { }

	// RVA: 0x15083F0
	private string GetValueAsString(string key) { }

	// RVA: 0x1508F10
	private System.Nullable<System.Double> GetValueAsDouble(string key) { }

	// RVA: 0x15092A4
	private System.Nullable<System.Int32> GetValueAsInt(string key) { }

	// RVA: 0x15095A8
	public override string ToString() { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayInitError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x150A584
	public int get_ErrorCode() { }

	// RVA: 0x150A58C
	public string get_ErrorMessage() { }

	// RVA: 0x150A594
	internal void .ctor(string json) { }

	// RVA: 0x150A800
	public override string ToString() { }

}

// Namespace: 
public class Builder
{
	// Fields
	private readonly IConfigBuilder m_Builder; // 0x10

	// Methods

	// RVA: 0x150BEC8
	public void .ctor() { }

	// RVA: 0x150BF40
	public Builder SetBidFloor(Double bidFloor) { }

	// RVA: 0x150BFFC
	public Config Build() { }

}

// Namespace: 
public class Config
{
	// Fields
	private readonly IConfig <PlatformConfig>k__BackingField; // 0x10

	// Methods

	// RVA: 0x150BE8C
	internal IConfig get_PlatformConfig() { }

	// RVA: 0x150BE94
	private void .ctor(IConfig platformConfig) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayInterstitialAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x40
	private readonly IPlatformInterstitialAd m_InterstitialAd; // 0x48

	// Methods

	// RVA: 0x150A884
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150A938
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150A9EC
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150AAA0
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150AB54
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150AC08
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150ACBC
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150AD70
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150AE24
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150AED8
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150AF8C
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150B040
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150B0F4
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150B1A8
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150B25C
	public string get_AdUnitId() { }

	// RVA: 0x150B314
	public void .ctor(string adUnitId) { }

	// RVA: 0x150B858
	public void .ctor(string adUnitId, Config config) { }

	// RVA: 0x150B39C
	private void SetupEvents() { }

	// RVA: 0x150B944
	internal void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

	// RVA: 0x150B978
	public void LoadAd() { }

	// RVA: 0x150BA30
	public void DestroyAd() { }

	// RVA: 0x150BB98
	public void ShowAd(string placementName) { }

	// RVA: 0x150BC50
	public bool IsAdReady() { }

	// RVA: 0x150BD08
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x150BAE4
	public void Dispose() { }

	// RVA: 0x150BD10
	public string GetAdId() { }

	// RVA: 0x150BDC8
	private void <SetupEvents>b__26_0(LevelPlayAdInfo info) { }

	// RVA: 0x150BDE4
	private void <SetupEvents>b__26_1(LevelPlayAdError error) { }

	// RVA: 0x150BE00
	private void <SetupEvents>b__26_2(LevelPlayAdInfo info) { }

	// RVA: 0x150BE1C
	private void <SetupEvents>b__26_3(LevelPlayAdInfo info) { }

	// RVA: 0x150BE38
	private void <SetupEvents>b__26_4(LevelPlayAdInfo info) { }

	// RVA: 0x150BE54
	private void <SetupEvents>b__26_5(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x150BE70
	private void <SetupEvents>b__26_6(LevelPlayAdInfo info) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayReward
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	private readonly int <Amount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x150C0E8
	public string get_Name() { }

	// RVA: 0x150C0F0
	public int get_Amount() { }

	// RVA: 0x150C0F8
	internal void .ctor(string name, int amount) { }

}

// Namespace: 
public class Builder
{
	// Fields
	private readonly IConfigBuilder m_Builder; // 0x10

	// Methods

	// RVA: 0x150D9B4
	public void .ctor() { }

	// RVA: 0x150DA2C
	public Builder SetBidFloor(Double bidFloor) { }

	// RVA: 0x150DAE8
	public Config Build() { }

}

// Namespace: 
public class Config
{
	// Fields
	private readonly IConfig <PlatformConfig>k__BackingField; // 0x10

	// Methods

	// RVA: 0x150D978
	internal IConfig get_PlatformConfig() { }

	// RVA: 0x150D980
	private void .ctor(IConfig platformConfig) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlayRewardedAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> OnAdRewarded; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x48
	private readonly IPlatformRewardedAd m_RewardedAd; // 0x50

	// Methods

	// RVA: 0x150C140
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C1F4
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C2A8
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150C35C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150C410
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C4C4
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C578
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150C62C
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150C6E0
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x150C794
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x150C848
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C8FC
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150C9B0
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150CA64
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150CB18
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150CBCC
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150CC80
	public string get_AdUnitId() { }

	// RVA: 0x150CD38
	public void .ctor(string adUnitId) { }

	// RVA: 0x150D328
	public void .ctor(string adUnitId, Config config) { }

	// RVA: 0x150CDC0
	private void SetupEvents() { }

	// RVA: 0x150D414
	internal void .ctor(IPlatformRewardedAd platformRewardedAd) { }

	// RVA: 0x150D448
	public void LoadAd() { }

	// RVA: 0x150D500
	public void ShowAd(string placementName) { }

	// RVA: 0x150D5B8
	public void DestroyAd() { }

	// RVA: 0x150D720
	public bool IsAdReady() { }

	// RVA: 0x150D7D8
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x150D66C
	public void Dispose() { }

	// RVA: 0x150D7E0
	public string GetAdId() { }

	// RVA: 0x150D898
	private void <SetupEvents>b__29_0(LevelPlayAdInfo info) { }

	// RVA: 0x150D8B4
	private void <SetupEvents>b__29_1(LevelPlayAdError error) { }

	// RVA: 0x150D8D0
	private void <SetupEvents>b__29_2(LevelPlayAdInfo info) { }

	// RVA: 0x150D8EC
	private void <SetupEvents>b__29_3(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x150D908
	private void <SetupEvents>b__29_4(LevelPlayAdInfo info, LevelPlayReward reward) { }

	// RVA: 0x150D924
	private void <SetupEvents>b__29_5(LevelPlayAdInfo info) { }

	// RVA: 0x150D940
	private void <SetupEvents>b__29_6(LevelPlayAdInfo info) { }

	// RVA: 0x150D95C
	private void <SetupEvents>b__29_7(LevelPlayAdInfo info) { }

}

// Namespace: Unity.Services.LevelPlay
public class LevelPlaySegment
{
	// Fields
	public int Level; // 0x10
	public int IsPaying; // 0x14
	public Int64 UserCreationDate; // 0x18
	public Double IapTotal; // 0x20
	public string SegmentName; // 0x28
	public readonly System.Collections.Generic.Dictionary<System.String,System.String> CustomData; // 0x30

	// Methods

	// RVA: 0x150DBD4
	public void SetCustom(string key, string value) { }

	// RVA: 0x150DC40
	public System.Collections.Generic.Dictionary<System.String,System.String> GetSegmentAsDictionary() { }

	// RVA: 0x150E154
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal static class Constants
{
	// Fields
	internal const string PackageName = "com.unity.services.levelplay";
	internal const string PackageVersion = "8.10.1";
	internal const string PackageVersionAnnotation = "";
	internal const string AnnotatedPackageVersion = "8.10.1";
	internal const string PackageAnalyticsIdentifier = "UnityLevelPlay";
	internal const string UnityPackageDirectoryName = "LevelPlay";
}

// Namespace: 
internal class Builder
{
	// Fields
	private const string KBuilderClass = "com.ironsource.unity.androidbridge.InterstitialAd$ConfigBuilder";
	private readonly AndroidJavaObject m_BuilderJavaObject; // 0x10

	// Methods

	// RVA: 0x1510004
	internal void .ctor() { }

	// RVA: 0x1510138
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x151023C
	public IConfig Build() { }

}

// Namespace: 
internal class Config
{
	// Fields
	private readonly AndroidJavaObject <ConfigJavaObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x150FFC8
	internal AndroidJavaObject get_ConfigJavaObject() { }

	// RVA: 0x150FFD0
	private void .ctor(AndroidJavaObject config) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x150EE04
	public void .ctor() { }

	// RVA: 0x15103B0
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18
	public Config config; // 0x20

	// Methods

	// RVA: 0x150EF2C
	public void .ctor() { }

	// RVA: 0x1510624
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x150F1C8
	public void .ctor() { }

	// RVA: 0x1510900
	internal void <ShowAd>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal class AndroidInterstitialAd
{
	// Fields
	private const string k_AndroidInterstitialClass = "com.ironsource.unity.androidbridge.InterstitialAd";
	private const string k_AndroidLoadAdFunction = "loadAd";
	private const string k_AndroidShowAdFunction = "showAd";
	private const string k_IsAdReadyFunction = "isAdReady";
	private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";
	private const string k_FuncGetAdId = "getAdId";
	private const string k_ErrorDisposed = "Instance is disposed. Please create a new instance in order to call any method.";
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x40
	private AndroidJavaObject m_InterstitialJavaObject; // 0x48
	private IUnityInterstitialAdListener m_InterstitialListener; // 0x50
	private bool m_Disposed; // 0x58
	private bool m_IsReady; // 0x59
	private readonly string <AdUnitId>k__BackingField; // 0x60

	// Methods

	// RVA: 0x150E1E8
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E29C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E350
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150E404
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x150E4B8
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E56C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E620
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E6D4
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E788
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E83C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150E8F0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150E9A4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x150EA58
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150EB0C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x150EBC0
	public string get_AdUnitId() { }

	// RVA: 0x150EBC8
	public string get_AdId() { }

	// RVA: 0x150ED00
	internal void .ctor(string adUnitId) { }

	// RVA: 0x150EE0C
	internal void .ctor(string adUnitId, Config config) { }

	// RVA: 0x150EF34
	public void LoadAd() { }

	// RVA: 0x150F090
	public void ShowAd(string placementName) { }

	// RVA: 0x150F1D0
	public bool IsAdReady() { }

	// RVA: 0x150F2E0
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x150F5CC
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x150F65C
	public void onAdLoadFailed(string error) { }

	// RVA: 0x150F6EC
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x150F77C
	public void onAdClosed(string adInfo) { }

	// RVA: 0x150F80C
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x150F900
	public void onAdClicked(string adInfo) { }

	// RVA: 0x150F990
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x150FA20
	private void Dispose(bool disposing) { }

	// RVA: 0x150FAD8
	public void Dispose() { }

	// RVA: 0x150FB78
	protected override void Finalize() { }

	// RVA: 0x150F028
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x150FC4C
	private void <LoadAd>b__39_0(object state) { }

	// RVA: 0x150FDC4
	private void <IsAdReady>b__41_0(object state) { }

	// RVA: 0x150FF74
	private void <Dispose>b__50_0(object state) { }

}

// Namespace: 
internal class Builder
{
	// Fields
	private const string KBuilderClass = "com.ironsource.unity.androidbridge.RewardedAd$ConfigBuilder";
	private readonly AndroidJavaObject m_BuilderJavaObject; // 0x10

	// Methods

	// RVA: 0x1512AE4
	internal void .ctor() { }

	// RVA: 0x1512C18
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x1512D1C
	public IConfig Build() { }

}

// Namespace: 
internal class Config
{
	// Fields
	private readonly AndroidJavaObject <ConfigJavaObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1512AA8
	internal AndroidJavaObject get_ConfigJavaObject() { }

	// RVA: 0x1512AB0
	private void .ctor(AndroidJavaObject config) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x151180C
	public void .ctor() { }

	// RVA: 0x1512E90
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18
	public Config config; // 0x20

	// Methods

	// RVA: 0x1511934
	public void .ctor() { }

	// RVA: 0x1513104
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x1511BD0
	public void .ctor() { }

	// RVA: 0x15133E0
	internal void <ShowAd>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal class AndroidRewardedAd
{
	// Fields
	private const string k_AndroidRewardedAdClass = "com.ironsource.unity.androidbridge.RewardedAd";
	private const string k_AndroidLoadAdFunction = "loadAd";
	private const string k_AndroidShowAdFunction = "showAd";
	private const string k_IsAdReadyFunction = "isAdReady";
	private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";
	private const string k_FuncGetAdId = "getAdId";
	private const string k_ErrorDisposed = "Instance is disposed. Please create a new instance in order to call any method.";
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> OnAdRewarded; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x48
	private AndroidJavaObject m_RewardedAdJavaObject; // 0x50
	private IUnityRewardedAdListener m_RewardedAdListener; // 0x58
	private bool m_Disposed; // 0x60
	private bool m_IsReady; // 0x61
	private readonly string <AdUnitId>k__BackingField; // 0x68

	// Methods

	// RVA: 0x1510A88
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1510B3C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1510BF0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1510CA4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1510D58
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1510E0C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1510EC0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1510F74
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1511028
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x15110DC
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1511190
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1511244
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15112F8
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15113AC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1511460
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1511514
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15115C8
	public string get_AdUnitId() { }

	// RVA: 0x15115D0
	public string get_AdId() { }

	// RVA: 0x1511708
	internal void .ctor(string adUnitId) { }

	// RVA: 0x1511814
	internal void .ctor(string adUnitId, Config config) { }

	// RVA: 0x151193C
	public void LoadAd() { }

	// RVA: 0x1511A98
	public void ShowAd(string placementName) { }

	// RVA: 0x1511BD8
	public bool IsAdReady() { }

	// RVA: 0x1511CE8
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x1511FD4
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x1512064
	public void onAdLoadFailed(string error) { }

	// RVA: 0x15120F4
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x1512184
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1512278
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x1512350
	public void onAdClicked(string adInfo) { }

	// RVA: 0x15123E0
	public void onAdClosed(string adInfo) { }

	// RVA: 0x1512470
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x1512500
	private void Dispose(bool disposing) { }

	// RVA: 0x15125B8
	public void Dispose() { }

	// RVA: 0x1512658
	protected override void Finalize() { }

	// RVA: 0x1511A30
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x151272C
	private void <LoadAd>b__42_0(object state) { }

	// RVA: 0x15128A4
	private void <IsAdReady>b__44_0(object state) { }

	// RVA: 0x1512A54
	private void <Dispose>b__54_0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal interface IUnityInterstitialAdListener
{
	// Methods

	// RVA: -1
	public abstract void onAdLoaded(string adInfo) { }

	// RVA: -1
	public abstract void onAdLoadFailed(string error) { }

	// RVA: -1
	public abstract void onAdDisplayed(string adInfo) { }

	// RVA: -1
	public abstract void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: -1
	public abstract void onAdClosed(string adInfo) { }

	// RVA: -1
	public abstract void onAdClicked(string adInfo) { }

	// RVA: -1
	public abstract void onAdInfoChanged(string adInfo) { }

}

// Namespace: Unity.Services.LevelPlay
internal interface IUnityRewardedAdListener
{
	// Methods

	// RVA: -1
	public abstract void onAdLoaded(string adInfo) { }

	// RVA: -1
	public abstract void onAdLoadFailed(string error) { }

	// RVA: -1
	public abstract void onAdDisplayed(string adInfo) { }

	// RVA: -1
	public abstract void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: -1
	public abstract void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: -1
	public abstract void onAdClicked(string adInfo) { }

	// RVA: -1
	public abstract void onAdClosed(string adInfo) { }

	// RVA: -1
	public abstract void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1513718
	public void .ctor() { }

	// RVA: 0x1513E98
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x15138B4
	public void .ctor() { }

	// RVA: 0x1513F60
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x15139DC
	public void .ctor() { }

	// RVA: 0x151402C
	internal void <onAdDisplayed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18
	public string adInfo; // 0x20

	// Methods

	// RVA: 0x1513B18
	public void .ctor() { }

	// RVA: 0x15140F8
	internal void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1513C40
	public void .ctor() { }

	// RVA: 0x15141BC
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1513D68
	public void .ctor() { }

	// RVA: 0x1514288
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1513E90
	public void .ctor() { }

	// RVA: 0x1514354
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal class UnityInterstitialAdListener
{
	// Fields
	private const string k_AndroidInterstitialListenerName = "com.ironsource.unity.androidbridge.IUnityInterstitialAdListener";
	private readonly IUnityInterstitialAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x1513568
	public void .ctor(IUnityInterstitialAdListener listener) { }

	// RVA: 0x15135F8
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x1513794
	public void onAdLoadFailed(string error) { }

	// RVA: 0x15138BC
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x15139E4
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1513B20
	public void onAdClosed(string adInfo) { }

	// RVA: 0x1513C48
	public void onAdClicked(string adInfo) { }

	// RVA: 0x1513D70
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1514E20
	public void .ctor() { }

	// RVA: 0x1514E28
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x15145D0
	public void .ctor() { }

	// RVA: 0x1514EF4
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x15146F8
	public void .ctor() { }

	// RVA: 0x1514FBC
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1514820
	public void .ctor() { }

	// RVA: 0x1515088
	internal void <onAdDisplayed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18
	public string adInfo; // 0x20

	// Methods

	// RVA: 0x151495C
	public void .ctor() { }

	// RVA: 0x1515154
	internal void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18
	public string rewardName; // 0x20
	public int rewardAmount; // 0x28

	// Methods

	// RVA: 0x1514AA8
	public void .ctor() { }

	// RVA: 0x1515218
	internal void <onAdRewarded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1514BD0
	public void .ctor() { }

	// RVA: 0x15152E4
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1514CF8
	public void .ctor() { }

	// RVA: 0x15153B0
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal class UnityRewardedAdListener
{
	// Fields
	private const string k_AndroidRewardedAdListenerName = "com.ironsource.unity.androidbridge.IUnityRewardedAdListener";
	private readonly IUnityRewardedAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x1514420
	public void .ctor(IUnityRewardedAdListener listener) { }

	// RVA: 0x15144B0
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x15145D8
	public void onAdLoadFailed(string error) { }

	// RVA: 0x1514700
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x1514828
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1514964
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x1514AB0
	public void onAdClicked(string adInfo) { }

	// RVA: 0x1514BD8
	public void onAdClosed(string adInfo) { }

	// RVA: 0x1514D00
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: Unity.Services.LevelPlay
internal class AdPrefab
{
	// Methods

	// RVA: 0x151547C
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal class BannerPrefab
{
	// Methods

	// RVA: 0x1515484
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal class InterstitialPrefab
{
	// Methods

	// RVA: 0x151548C
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal class RewardedPrefab
{
	// Methods

	// RVA: 0x1515494
	public void .ctor() { }

}

// Namespace: 
internal class Builder
{
	// Fields
	private LevelPlayAdSize _adSize; // 0x10
	private LevelPlayBannerPosition _position; // 0x18
	private string _placementName; // 0x20
	private bool _displayOnLoad; // 0x28
	private readonly IntPtr m_Builder; // 0x30

	// Methods

	// RVA: 0x1517D14
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x1517D20
	public void SetSize(LevelPlayAdSize size) { }

	// RVA: 0x1517DD8
	public void SetPosition(LevelPlayBannerPosition position) { }

	// RVA: 0x1517DE0
	public void SetPlacementName(string placementName) { }

	// RVA: 0x1517E70
	public void SetDisplayOnLoad(bool displayOnLoad) { }

	// RVA: 0x1517E78
	public void SetRespectSafeArea(bool respectSafeArea) { }

	// RVA: 0x1517E7C
	public IConfig Build() { }

	// RVA: 0x1517F44
	private static extern IntPtr BannerAdCreateConfigBuilder() { }

	// RVA: 0x1517D1C
	private static extern IntPtr BannerAdConfigBuilderSetBidFloor(IntPtr builder, Double bidFloor) { }

	// RVA: 0x1517DD4
	private static extern IntPtr BannerAdConfigBuilderSetSize(IntPtr builder, IntPtr size) { }

	// RVA: 0x1517E2C
	private static extern IntPtr BannerAdConfigBuilderSetPlacementName(IntPtr builder, string placementName) { }

	// RVA: 0x1517F40
	private static extern IntPtr BannerAdConfigBuilderBuild(IntPtr builder) { }

	// RVA: 0x1517F48
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Fields
	private readonly LevelPlayAdSize <AdSize>k__BackingField; // 0x10
	private readonly LevelPlayBannerPosition <Position>k__BackingField; // 0x18
	private readonly string <PlacementName>k__BackingField; // 0x20
	private readonly bool <DisplayOnLoad>k__BackingField; // 0x28
	private readonly IntPtr <IosConfig>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1517C6C
	internal LevelPlayAdSize get_AdSize() { }

	// RVA: 0x1517C74
	internal LevelPlayBannerPosition get_Position() { }

	// RVA: 0x1517C7C
	internal string get_PlacementName() { }

	// RVA: 0x1517C84
	internal bool get_DisplayOnLoad() { }

	// RVA: 0x1517C8C
	internal IntPtr get_IosConfig() { }

	// RVA: 0x1517C94
	private void .ctor(LevelPlayAdSize adSize, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, IntPtr iosConfig) { }

}

// Namespace: 
private sealed class <>c__DisplayClass51_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x15173D4
	public void .ctor() { }

	// RVA: 0x1517F74
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdError error; // 0x18

	// Methods

	// RVA: 0x15174FC
	public void .ctor() { }

	// RVA: 0x1517FB0
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x1517624
	public void .ctor() { }

	// RVA: 0x1517FEC
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x151774C
	public void .ctor() { }

	// RVA: 0x1518028
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x15178B0
	public void .ctor() { }

	// RVA: 0x1518064
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass56_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x15179E0
	public void .ctor() { }

	// RVA: 0x15180A0
	internal void <InvokeExpandedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x1517B08
	public void .ctor() { }

	// RVA: 0x15180DC
	internal void <InvokeCollapsedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x1517C30
	public void .ctor() { }

	// RVA: 0x1518118
	internal void <InvokeLeftApplicationEvent>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
public class iOSBannerAd
{
	// Fields
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x20
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x28
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x30
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x38
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x40
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded; // 0x48
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed; // 0x50
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication; // 0x58
	private readonly string <AdUnitId>k__BackingField; // 0x60
	private readonly LevelPlayAdSize <AdSize>k__BackingField; // 0x68
	private readonly string <PlacementName>k__BackingField; // 0x70
	private readonly LevelPlayBannerPosition <Position>k__BackingField; // 0x78
	private readonly bool <DisplayOnLoad>k__BackingField; // 0x80
	private IosBannerAdListener _mBannerAdListener; // 0x88

	// Methods

	// RVA: 0x151549C
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515550
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515604
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x15156B8
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x151576C
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515820
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15158D4
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515988
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515A3C
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1515AF0
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1515BA4
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515C58
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515D0C
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515DC0
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515E74
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515F28
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1515FDC
	public string get_AdUnitId() { }

	// RVA: 0x1515FE4
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x1515FEC
	public string get_PlacementName() { }

	// RVA: 0x1515FF4
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x1515FFC
	private bool get_DisplayOnLoad() { }

	// RVA: 0x1516004
	public string get_AdId() { }

	// RVA: 0x151614C
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

	// RVA: 0x1516BB8
	internal void .ctor(string adUnitId, Config config) { }

	// RVA: 0x1516DE8
	public void PauseAutoRefresh() { }

	// RVA: 0x1516FCC
	public void ResumeAutoRefresh() { }

	// RVA: 0x1517040
	public void Load() { }

	// RVA: 0x15171B4
	public void DestroyAd() { }

	// RVA: 0x15170EC
	public void SetPosition() { }

	// RVA: 0x15171A4
	public void ShowAd() { }

	// RVA: 0x15171AC
	public void HideAd() { }

	// RVA: 0x15172B4
	internal void InvokeLoadedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x15173DC
	internal void InvokeFailedLoadEvent(LevelPlayAdError error) { }

	// RVA: 0x1517504
	internal void InvokeClickedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x151762C
	internal void InvokeDisplayedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x1517754
	internal void InvokeFailedDisplayEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }

	// RVA: 0x15178C0
	internal void InvokeExpandedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x15179E8
	internal void InvokeCollapsedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x1517B10
	internal void InvokeLeftApplicationEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x15160A8
	private string GetAdId() { }

	// RVA: 0x151639C
	private static extern IntPtr BannerAdCreate(string adUnitId, string placementName, IntPtr adSize) { }

	// RVA: 0x1516D9C
	private static extern IntPtr BannerAdCreate(string adUnitId, IntPtr config, IntPtr adSize) { }

	// RVA: 0x1516BB4
	private static extern void BannerAdSetDelegate(IntPtr bannerAdView, IntPtr bannerAdListener) { }

	// RVA: 0x15170E8
	private static extern void BannerAdLoad(IntPtr bannerAdView) { }

	// RVA: 0x1517204
	private static extern void BannerAdDestroy(IntPtr bannerAdView) { }

	// RVA: 0x151725C
	private static extern void BannerAdSetPosition(IntPtr bannerAdView, string position, float x, float y) { }

	// RVA: 0x15172AC
	private static extern void BannerAdViewShow(IntPtr bannerAdView) { }

	// RVA: 0x15172B0
	private static extern void BannerAdViewHide(IntPtr bannerAdView) { }

	// RVA: 0x1516FC8
	private static extern void BannerAdPauseAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x151703C
	private static extern void BannerAdResumeAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x1517C38
	private static extern string BannerAdId(IntPtr bannerAdView) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x15188FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1518F6C
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x1518F80
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1519018
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x15189A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1519024
	public virtual void Invoke(IntPtr bannerPtr, string errorPtr) { }

	// RVA: 0x1519038
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x15190D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x1518A44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15190DC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x15190F0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1519188
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x1518AE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1519194
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x15191A8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1519240
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x1518B8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151924C
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson, string errorPtr) { }

	// RVA: 0x1519260
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x1519308
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidExpandAdWithAdInfo
{
	// Methods

	// RVA: 0x1518C30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1519314
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x1519328
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x15193C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCollapseAdWithAdInfo
{
	// Methods

	// RVA: 0x1518CD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15193CC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x15193E0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1519478
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidLeaveAppWithAdInfo
{
	// Methods

	// RVA: 0x1518D78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1519484
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x1519498
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1519530
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosBannerAdListener
{
	// Fields
	private readonly DidLoadAdWithAdInfo _kLoadSuccessCallback; // 0x20
	private readonly DidFailToLoadAdWithAdUnitId _kFailedToLoad; // 0x28
	private readonly DidClickWithAdInfo _kClicked; // 0x30
	private readonly DidDisplayWithAdInfo _kDisplayed; // 0x38
	private readonly DidFailToDisplayWithAdInfo _kDisplayFailed; // 0x40
	private readonly DidExpandAdWithAdInfo _kExpanded; // 0x48
	private readonly DidCollapseAdWithAdInfo _kCollapsed; // 0x50
	private readonly DidLeaveAppWithAdInfo _kLeftApp; // 0x58
	private iOSBannerAd _bannerAd; // 0x60

	// Methods

	// RVA: 0x151652C
	public void .ctor(iOSBannerAd bannerAd) { }

	// RVA: 0x1518EF4
	public override void Dispose() { }

	// RVA: 0x1518E1C
	private static extern IntPtr LPMBannerAdViewDelegateCreate(IntPtr bannerAdPtr, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidClickWithAdInfo clicked, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidExpandAdWithAdInfo expanded, DidCollapseAdWithAdInfo collapsed, DidLeaveAppWithAdInfo leftApp) { }

	// RVA: 0x1518F58
	private static extern void LPMBannerAdViewDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x1518154
	private static void LoadSuccess(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151822C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x151831C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151840C
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x15184FC
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x151862C
	private static void Expanded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151871C
	private static void Collapsed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151880C
	private static void LeftApplication(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
internal class Builder
{
	// Fields
	private readonly IntPtr m_Builder; // 0x10

	// Methods

	// RVA: 0x151B508
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x151B514
	public IConfig Build() { }

	// RVA: 0x151B58C
	private static extern IntPtr InterstitialAdCreateConfigBuilder() { }

	// RVA: 0x151B510
	private static extern IntPtr InterstitialConfigBuilderSetBidFloor(IntPtr builder, Double bidFloor) { }

	// RVA: 0x151B588
	private static extern IntPtr InterstitialConfigBuilderBuild(IntPtr builder) { }

	// RVA: 0x151B590
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Fields
	private readonly IntPtr <IosConfig>k__BackingField; // 0x10

	// Methods

	// RVA: 0x151B4D4
	internal IntPtr get_IosConfig() { }

	// RVA: 0x151B4DC
	private void .ctor(IntPtr iosConfig) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151AC74
	public void .ctor() { }

	// RVA: 0x151B5BC
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x151AD9C
	public void .ctor() { }

	// RVA: 0x151B658
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151AEC4
	public void .ctor() { }

	// RVA: 0x151B6F4
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151AFEC
	public void .ctor() { }

	// RVA: 0x151B790
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x151B1B0
	public void .ctor() { }

	// RVA: 0x151B82C
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151B2D8
	public void .ctor() { }

	// RVA: 0x151B868
	internal void <InvokeClosedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151B400
	public void .ctor() { }

	// RVA: 0x151B904
	internal void <InvokeOnAdInfoChangedEvent>b__0(object state) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosInterstitialAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x48
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x50
	private readonly string <AdUnitId>k__BackingField; // 0x58
	private IosInterstitialAdListener m_InterstitialListener; // 0x60

	// Methods

	// RVA: 0x151953C
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15195F0
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15196A4
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1519758
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x151980C
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15198C0
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519974
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1519A28
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1519ADC
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519B90
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519C44
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519CF8
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519DAC
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519E60
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1519F14
	public string get_AdUnitId() { }

	// RVA: 0x1519F1C
	public string get_AdId() { }

	// RVA: 0x151A064
	public void .ctor(string adUnitId) { }

	// RVA: 0x151A75C
	public void .ctor(string adUnitId, Config config) { }

	// RVA: 0x151A8AC
	public void LoadAd() { }

	// RVA: 0x151A920
	public void ShowAd(string placementName) { }

	// RVA: 0x151A9E8
	public bool IsAdReady() { }

	// RVA: 0x151AA84
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x151AAF4
	public override void Dispose() { }

	// RVA: 0x151AB54
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x151AC7C
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x151ADA4
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x151AECC
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x151AFF4
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x151B1B8
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x151B2E0
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x1519FC0
	private string GetAdId() { }

	// RVA: 0x151B43C
	protected override void Finalize() { }

	// RVA: 0x151A160
	private static extern IntPtr InterstitialAdCreate(string adUnitId) { }

	// RVA: 0x151A870
	private static extern IntPtr InterstitialAdCreate(string adUnitId, IntPtr config) { }

	// RVA: 0x151A758
	private static extern void InterstitialAdSetDelegate(IntPtr interstitialAd, IntPtr interstitialAdListener) { }

	// RVA: 0x151A91C
	private static extern void InterstitialAdLoadAd(IntPtr interstitialAd) { }

	// RVA: 0x151A9B0
	private static extern void InterstitialAdShowAd(IntPtr interstitialAd, string placementName) { }

	// RVA: 0x151AA68
	private static extern bool InterstitialAdIsAdReady(IntPtr interstitialAd) { }

	// RVA: 0x151AABC
	private static extern bool InterstitialAdIsPlacementCapped(string placementName) { }

	// RVA: 0x151B408
	private static extern string InterstitialAdId(IntPtr interstitialAd) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x151BED8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C414
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x151C428
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x151C4C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x151BF7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C4CC
	public virtual void Invoke(IntPtr interstitialAd, string errorPtr) { }

	// RVA: 0x151C4E0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x151C578
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x151C020
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C584
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x151C598
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x151C630
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x151C0C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C63C
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x151C650
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x151C6F8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x151C168
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C704
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x151C718
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x151C7B0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x151C20C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C7BC
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x151C7D0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x151C868
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x151C2B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x151C874
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x151C888
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x151C920
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosInterstitialAdListener
{
	// Fields
	private readonly DidLoadAdWithAdInfo k_LoadSuccessCallback; // 0x20
	private readonly DidFailToLoadAdWithAdUnitId k_FailedToLoadCallback; // 0x28
	private readonly DidDisplayWithAdInfo k_DisplayedCallback; // 0x30
	private readonly DidFailToDisplayWithAdInfo k_DisplayFailedCallback; // 0x38
	private readonly DidClickWithAdInfo k_ClickedCallback; // 0x40
	private readonly DidCloseWithAdInfo k_ClosedCallback; // 0x48
	private readonly DidChangeAdInfo k_AdInfoChangedCallback; // 0x50
	private IosInterstitialAd m_InterstitialAd; // 0x58

	// Methods

	// RVA: 0x151A194
	internal void .ctor(IosInterstitialAd interstitialAd) { }

	// RVA: 0x151C354
	private static extern IntPtr LPMInterstitialAdDelegateCreate(IntPtr interstitialAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x151C410
	private static extern void LPMInterstitialAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x151B9A0
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151BA5C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x151BB18
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151BBD4
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151BC90
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x151BD60
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151BE1C
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosLevelPlayAdSize
{
	// Fields
	private PlatformLevelPlayAdSizeType m_PlatformLevelPlayAdSizeType; // 0x1C

	// Methods

	// RVA: 0x151C92C
	internal void .ctor(PlatformLevelPlayAdSizeType adSizeType) { }

	// RVA: 0x151C9BC
	internal void .ctor(int width, int height) { }

	// RVA: 0x151CA58
	private void .ctor(PlatformLevelPlayAdSizeType adSizeType, IntPtr nativePtr) { }

	// RVA: 0x151CAE0
	public int get_Width() { }

	// RVA: 0x151CAEC
	public int get_Height() { }

	// RVA: 0x151CAF8
	public PlatformLevelPlayAdSizeType get_AdSizeType() { }

	// RVA: 0x151CB00
	internal static IosLevelPlayAdSize CreateAdaptiveAdSize() { }

	// RVA: 0x151CBC0
	internal static IosLevelPlayAdSize CreateAdaptiveAdSize(int width) { }

	// RVA: 0x151C9B8
	private static extern IntPtr LPMCreateAdSizeWithType(PlatformLevelPlayAdSizeType adSizeType, int width, int height) { }

	// RVA: 0x151CBBC
	private static extern IntPtr LPMCreateAdaptiveAdSize() { }

	// RVA: 0x151CC84
	private static extern IntPtr LPMCreateAdaptiveAdSizeWithWidth(int width) { }

	// RVA: 0x151CAE8
	private static extern int LPMGetAdSizeWidth(IntPtr adSize) { }

	// RVA: 0x151CAF4
	private static extern int LPMGetAdSizeHeight(IntPtr adSize) { }

}

// Namespace: 
internal class Builder
{
	// Fields
	private readonly IntPtr m_Builder; // 0x10

	// Methods

	// RVA: 0x151EFCC
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x151EFD8
	public IConfig Build() { }

	// RVA: 0x151F050
	private static extern IntPtr RewardedAdCreateConfigBuilder() { }

	// RVA: 0x151EFD4
	private static extern IntPtr RewardedConfigBuilderSetBidFloor(IntPtr builder, Double bidFloor) { }

	// RVA: 0x151F04C
	private static extern IntPtr RewardedConfigBuilderBuild(IntPtr builder) { }

	// RVA: 0x151F054
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Fields
	private readonly IntPtr <IosConfig>k__BackingField; // 0x10

	// Methods

	// RVA: 0x151EF98
	internal IntPtr get_IosConfig() { }

	// RVA: 0x151EFA0
	private void .ctor(IntPtr iosConfig) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151E5EC
	public void .ctor() { }

	// RVA: 0x151F080
	internal void <InvokeLoadedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x151E714
	public void .ctor() { }

	// RVA: 0x151F11C
	internal void <InvokeFailedLoadEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151E83C
	public void .ctor() { }

	// RVA: 0x151F1B8
	internal void <InvokeDisplayedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x151EA00
	public void .ctor() { }

	// RVA: 0x151F254
	internal void <InvokeFailedDisplayEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18
	public string rewardName; // 0x20
	public int rewardAmount; // 0x28

	// Methods

	// RVA: 0x151EB4C
	public void .ctor() { }

	// RVA: 0x151F290
	internal void <InvokeRewardedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151EC74
	public void .ctor() { }

	// RVA: 0x151F37C
	internal void <InvokeClickedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass43_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151ED9C
	public void .ctor() { }

	// RVA: 0x151F418
	internal void <InvokeClosedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x151EEC4
	public void .ctor() { }

	// RVA: 0x151F4B4
	internal void <InvokeOnAdInfoChangedEvent>b__0(object _) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosRewardedAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> OnAdRewarded; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x48
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x50
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x58
	private readonly string <AdUnitId>k__BackingField; // 0x60
	private IosRewardedAdListener m_RewardedAdListener; // 0x68

	// Methods

	// RVA: 0x151CC88
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151CD3C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151CDF0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x151CEA4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x151CF58
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D00C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D0C0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x151D174
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x151D228
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x151D2DC
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x151D390
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D444
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D4F8
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D5AC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D660
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D714
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x151D7C8
	public string get_AdUnitId() { }

	// RVA: 0x151D7D0
	public string get_AdId() { }

	// RVA: 0x151D918
	public void .ctor(string adUnitId) { }

	// RVA: 0x151E0D4
	public void .ctor(string adUnitId, Config config) { }

	// RVA: 0x151E224
	public void LoadAd() { }

	// RVA: 0x151E298
	public void ShowAd(string placementName) { }

	// RVA: 0x151E360
	public bool IsAdReady() { }

	// RVA: 0x151E3FC
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x151E46C
	public override void Dispose() { }

	// RVA: 0x151E4CC
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x151E5F4
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x151E71C
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x151E844
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x151EA08
	internal void InvokeRewardedEvent(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x151EB54
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x151EC7C
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x151EDA4
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x151D874
	private string GetAdId() { }

	// RVA: 0x151EF00
	protected override void Finalize() { }

	// RVA: 0x151DA14
	private static extern IntPtr RewardedAdCreate(string adUnitId) { }

	// RVA: 0x151E1E8
	private static extern IntPtr RewardedAdCreate(string adUnitId, IntPtr config) { }

	// RVA: 0x151E0D0
	private static extern void RewardedAdSetDelegate(IntPtr rewardedAd, IntPtr rewardedAdListener) { }

	// RVA: 0x151E294
	private static extern void RewardedAdLoadAd(IntPtr rewardedAd) { }

	// RVA: 0x151E328
	private static extern void RewardedAdShowAd(IntPtr rewardedAd, string placementName) { }

	// RVA: 0x151E3E0
	private static extern bool RewardedAdIsAdReady(IntPtr rewardedAd) { }

	// RVA: 0x151E434
	private static extern bool RewardedAdIsPlacementCapped(string placementName) { }

	// RVA: 0x151EECC
	private static extern string RewardedAdId(IntPtr rewardedAd) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x151FB60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x152015C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x1520170
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1520208
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x151FC04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1520214
	public virtual void Invoke(IntPtr rewardedAd, string errorPtr) { }

	// RVA: 0x1520228
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x15202C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x151FCA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15202CC
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x15202E0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1520378
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x151FD4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1520384
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x1520398
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x1520440
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidAdRewardedWithAdInfo
{
	// Methods

	// RVA: 0x151FDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x152044C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x1520460
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x152051C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x151FE94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1520528
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x152053C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x15205D4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x151FF38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15205E0
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x15205F4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x152068C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x151FFDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1520698
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x15206AC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1520744
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: Unity.Services.LevelPlay
internal class IosRewardedAdListener
{
	// Fields
	private readonly DidLoadAdWithAdInfo k_LoadSuccessCallback; // 0x20
	private readonly DidFailToLoadAdWithAdUnitId k_FailedToLoadCallback; // 0x28
	private readonly DidDisplayWithAdInfo k_DisplayedCallback; // 0x30
	private readonly DidFailToDisplayWithAdInfo k_DisplayFailedCallback; // 0x38
	private readonly DidAdRewardedWithAdInfo k_RewardedCallback; // 0x40
	private readonly DidClickWithAdInfo k_ClickedCallback; // 0x48
	private readonly DidCloseWithAdInfo k_ClosedCallback; // 0x50
	private readonly DidChangeAdInfo k_AdInfoChangedCallback; // 0x58
	private IosRewardedAd _mRewardedAd; // 0x60

	// Methods

	// RVA: 0x151DA48
	internal void .ctor(IosRewardedAd rewardedAd) { }

	// RVA: 0x1520080
	private static extern IntPtr LPMRewardedAdDelegateCreate(IntPtr rewardedAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidAdRewardedWithAdInfo rewarded, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x1520158
	private static extern void LPMRewardedAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x151F550
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151F60C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x151F6C8
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151F784
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x151F854
	private static void Rewarded(IntPtr ptr, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x151F92C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151F9E8
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x151FAA4
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
internal interface IConfig
{}

// Namespace: 
internal interface IConfigBuilder
{
	// Methods

	// RVA: -1
	public abstract void SetBidFloor(Double bidFloor) { }

	// RVA: -1
	public abstract void SetSize(LevelPlayAdSize size) { }

	// RVA: -1
	public abstract void SetPosition(LevelPlayBannerPosition position) { }

	// RVA: -1
	public abstract void SetPlacementName(string placementName) { }

	// RVA: -1
	public abstract void SetDisplayOnLoad(bool displayOnLoad) { }

	// RVA: -1
	public abstract void SetRespectSafeArea(bool respectSafeArea) { }

	// RVA: -1
	public abstract IConfig Build() { }

}

// Namespace: Unity.Services.LevelPlay
internal interface IPlatformBannerAd
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract string get_AdId() { }

	// RVA: -1
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract LevelPlayAdSize get_AdSize() { }

	// RVA: -1
	public abstract string get_PlacementName() { }

	// RVA: -1
	public abstract LevelPlayBannerPosition get_Position() { }

	// RVA: -1
	public abstract void Load() { }

	// RVA: -1
	public abstract void DestroyAd() { }

	// RVA: -1
	public abstract void ShowAd() { }

	// RVA: -1
	public abstract void HideAd() { }

	// RVA: -1
	public abstract void PauseAutoRefresh() { }

	// RVA: -1
	public abstract void ResumeAutoRefresh() { }

}

// Namespace: 
internal interface IConfig
{}

// Namespace: 
internal interface IConfigBuilder
{
	// Methods

	// RVA: -1
	public abstract void SetBidFloor(Double bidFloor) { }

	// RVA: -1
	public abstract IConfig Build() { }

}

// Namespace: Unity.Services.LevelPlay
internal interface IPlatformInterstitialAd
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract string get_AdId() { }

	// RVA: -1
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: Unity.Services.LevelPlay
internal enum PlatformLevelPlayAdSizeType
{
	// Fields
	public int value__; // 0x10
	public const PlatformLevelPlayAdSizeType Unknown = 0;
	public const PlatformLevelPlayAdSizeType Banner = 1;
	public const PlatformLevelPlayAdSizeType Large = 2;
	public const PlatformLevelPlayAdSizeType MediumRectangle = 3;
	public const PlatformLevelPlayAdSizeType Custom = 4;
	public const PlatformLevelPlayAdSizeType LeaderBoard = 5;
	public const PlatformLevelPlayAdSizeType Adaptive = 6;
}

// Namespace: Unity.Services.LevelPlay
internal interface IPlatformLevelPlayAdSize
{
	// Methods

	// RVA: -1
	public abstract int get_Width() { }

	// RVA: -1
	public abstract int get_Height() { }

	// RVA: -1
	public abstract PlatformLevelPlayAdSizeType get_AdSizeType() { }

}

// Namespace: 
internal interface IConfig
{}

// Namespace: 
internal interface IConfigBuilder
{
	// Methods

	// RVA: -1
	public abstract void SetBidFloor(Double bidFloor) { }

	// RVA: -1
	public abstract IConfig Build() { }

}

// Namespace: Unity.Services.LevelPlay
internal interface IPlatformRewardedAd
{
	// Methods

	// RVA: -1
	public abstract void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: -1
	public abstract void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: -1
	public abstract void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: -1
	public abstract void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: -1
	public abstract string get_AdId() { }

	// RVA: -1
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: Unity.Services.LevelPlay
internal static class ThreadUtil
{
	// Fields
	internal static SynchronizationContext UnitySynchronizationContext; // 0x0

	// Methods

	// RVA: 0x1520750
	private static void Init() { }

	// RVA: 0x1513720
	public static void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x15207B0
	public static void Send(SendOrPostCallback d, object state) { }

}

// Namespace: 
internal class Builder
{
	// Methods

	// RVA: 0x15213CC
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x15213D0
	public void SetSize(LevelPlayAdSize size) { }

	// RVA: 0x15213D4
	public void SetPosition(LevelPlayBannerPosition position) { }

	// RVA: 0x15213D8
	public void SetPlacementName(string placementName) { }

	// RVA: 0x15213DC
	public void SetDisplayOnLoad(bool displayOnLoad) { }

	// RVA: 0x15213E0
	public void SetRespectSafeArea(bool respectSafeArea) { }

	// RVA: 0x15213E4
	public IConfig Build() { }

	// RVA: 0x152143C
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Methods

	// RVA: 0x15213C4
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
public class UnsupportedBannerAd
{
	// Fields
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x20
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x28
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x30
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdExpanded; // 0x38
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdCollapsed; // 0x40
	private System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> OnAdLeftApplication; // 0x48
	private readonly LevelPlayBannerPosition <Position>k__BackingField; // 0x50
	private readonly string <AdId>k__BackingField; // 0x58
	private readonly string <AdUnitId>k__BackingField; // 0x60
	private readonly LevelPlayAdSize <AdSize>k__BackingField; // 0x68
	private readonly LevelPlayAdSize <Size>k__BackingField; // 0x70
	private readonly string <PlacementName>k__BackingField; // 0x78

	// Methods

	// RVA: 0x1520824
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

	// RVA: 0x152082C
	internal void .ctor(string adUnitId, Config config) { }

	// RVA: 0x1520834
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15208E8
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x152099C
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1520A50
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1520B04
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1520BB8
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1520C6C
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1520D20
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1520DD4
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1520E88
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1520F3C
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1520FF0
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15210A4
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521158
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x152120C
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15212C0
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521374
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x152137C
	public void Load() { }

	// RVA: 0x1521380
	public void DestroyAd() { }

	// RVA: 0x1521384
	public void ShowAd() { }

	// RVA: 0x1521388
	public void HideAd() { }

	// RVA: 0x152138C
	public void PauseAutoRefresh() { }

	// RVA: 0x1521390
	public void ResumeAutoRefresh() { }

	// RVA: 0x1521394
	public void SetAutoRefresh(bool flag) { }

	// RVA: 0x1521398
	public void Dispose() { }

	// RVA: 0x152139C
	public string get_AdId() { }

	// RVA: 0x15213A4
	public string get_AdUnitId() { }

	// RVA: 0x15213AC
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x15213B4
	public LevelPlayAdSize get_Size() { }

	// RVA: 0x15213BC
	public string get_PlacementName() { }

}

// Namespace: 
internal class Builder
{
	// Methods

	// RVA: 0x1521E50
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x1521E54
	public IConfig Build() { }

	// RVA: 0x1521EAC
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Methods

	// RVA: 0x1521E48
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal class UnsupportedInterstitialAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x40
	private readonly string <AdId>k__BackingField; // 0x48
	private readonly string <AdUnitId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x1521444
	public void Dispose() { }

	// RVA: 0x1521448
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15214FC
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15215B0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1521664
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1521718
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15217CC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521880
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521934
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15219E8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521A9C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521B50
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1521C04
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1521CB8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521D6C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521E20
	public string get_AdId() { }

	// RVA: 0x1521E28
	public string get_AdUnitId() { }

	// RVA: 0x1521E30
	public void .ctor(string adUnitId) { }

	// RVA: 0x1521E38
	public void LoadAd() { }

	// RVA: 0x1521E3C
	public void ShowAd(string placementName) { }

	// RVA: 0x1521E40
	public bool IsAdReady() { }

}

// Namespace: Unity.Services.LevelPlay
internal class UnsupportedLevelPlayAdSize
{
	// Methods

	// RVA: 0x1521EB4
	internal void .ctor() { }

	// RVA: 0x1521EBC
	public int get_Width() { }

	// RVA: 0x1521EC4
	public int get_Height() { }

	// RVA: 0x1521ECC
	public PlatformLevelPlayAdSizeType get_AdSizeType() { }

}

// Namespace: 
internal class Builder
{
	// Methods

	// RVA: 0x1522A48
	public void SetBidFloor(Double bidFloor) { }

	// RVA: 0x1522A4C
	public IConfig Build() { }

	// RVA: 0x1522AA4
	public void .ctor() { }

}

// Namespace: 
internal class Config
{
	// Methods

	// RVA: 0x1522A40
	public void .ctor() { }

}

// Namespace: Unity.Services.LevelPlay
internal class UnsupportedRewardedAd
{
	// Fields
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdLoaded; // 0x10
	private System.Action<com.unity3d.mediation.LevelPlayAdError> OnAdLoadFailed; // 0x18
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdDisplayed; // 0x20
	private System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> OnAdDisplayFailed; // 0x28
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> OnAdRewarded; // 0x30
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClicked; // 0x38
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdClosed; // 0x40
	private System.Action<com.unity3d.mediation.LevelPlayAdInfo> OnAdInfoChanged; // 0x48
	private readonly string <AdId>k__BackingField; // 0x50
	private readonly string <AdUnitId>k__BackingField; // 0x58

	// Methods

	// RVA: 0x1521ED4
	public void Dispose() { }

	// RVA: 0x1521ED8
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1521F8C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522040
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x15220F4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x15221A8
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x152225C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522310
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x15223C4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1522478
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x152252C
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x15225E0
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522694
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522748
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15227FC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x15228B0
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522964
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1522A18
	public string get_AdId() { }

	// RVA: 0x1522A20
	public string get_AdUnitId() { }

	// RVA: 0x1522A28
	public void .ctor(string adUnitId) { }

	// RVA: 0x1522A30
	public void LoadAd() { }

	// RVA: 0x1522A34
	public void ShowAd(string placementName) { }

	// RVA: 0x1522A38
	public bool IsAdReady() { }

}

// Namespace: Unity.Services.LevelPlay
internal static class LevelPlayLogger
{
	// Fields
	private const string k_Tag = "[LevelPlay]";
	private const string k_VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_LEVELPLAY_VERBOSE_LOGGING";
	private const string k_UnityAssertions = "UNITY_ASSERTIONS";

	// Methods

	// RVA: 0x1522AAC
	public static void Log(object message) { }

	// RVA: 0x1522B58
	public static void LogWarning(object message) { }

	// RVA: 0x1522C04
	public static void LogError(object message) { }

	// RVA: 0x1522CB0
	public static void LogException(Exception exception) { }

	// RVA: 0x1522DEC
	public static void LogAssertion(object message) { }

	// RVA: 0x1522DF0
	public static void LogVerbose(object message) { }

}

// Namespace: Unity.Services.LevelPlay
internal static class ObjectUtility
{
	// Methods

	// RVA: 0x26AD93C
	internal static void DestroySafely(T obj) { }

}

// Namespace: com.unity3d.mediation
public interface ILevelPlayBannerAd
{}

// Namespace: com.unity3d.mediation
public interface ILevelPlayInterstitialAd
{}

// Namespace: com.unity3d.mediation
public interface ILevelPlayRewardedAd
{}

// Namespace: com.unity3d.mediation
public class LevelPlay
{
	// Methods

	// RVA: 0x1522E9C
	public void .ctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdDisplayInfoError
{
	// Methods

	// RVA: 0x15178B8
	public void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdError
{
	// Methods

	// RVA: 0x1518F64
	internal void .ctor(string json) { }

	// RVA: 0x1522F24
	public void .ctor(string adUnitId, int errorCode, string errorMessage) { }

}

// Namespace: com.unity3d.mediation
public enum LevelPlayAdFormat
{
	// Fields
	public int value__; // 0x10
	public const LevelPlayAdFormat BANNER = 0;
	public const LevelPlayAdFormat INTERSTITIAL = 1;
	public const LevelPlayAdFormat REWARDED = 2;
}

// Namespace: com.unity3d.mediation
public class LevelPlayAdInfo
{
	// Methods

	// RVA: 0x1518F5C
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdSize
{
	// Fields
	private readonly LevelPlayAdSize m_AdSize; // 0x10

	// Methods

	// RVA: 0x1522F2C
	private void .ctor(LevelPlayAdSize adSize) { }

	// RVA: 0x1522F60
	public string get_Description() { }

	// RVA: 0x1522F80
	public int get_Width() { }

	// RVA: 0x1522FA0
	public int get_Height() { }

	// RVA: 0x1522FC0
	public int get_CustomWidth() { }

	// RVA: 0x1522FE0
	public override string ToString() { }

	// RVA: 0x1523004
	public static LevelPlayAdSize get_BANNER() { }

	// RVA: 0x152309C
	public static LevelPlayAdSize get_LARGE() { }

	// RVA: 0x1523134
	public static LevelPlayAdSize get_MEDIUM_RECTANGLE() { }

	// RVA: 0x15231CC
	public static LevelPlayAdSize get_LEADERBOARD() { }

	// RVA: 0x1523264
	public static LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x1523314
	public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x151637C
	internal IPlatformLevelPlayAdSize GetPlatformLevelPlayAdSize() { }

}

// Namespace: com.unity3d.mediation
public sealed class LevelPlayBannerAd
{
	// Methods

	// RVA: 0x15233BC
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayBannerPosition
{
	// Fields
	private readonly LevelPlayBannerPosition m_Position; // 0x10
	public static readonly LevelPlayBannerPosition TopLeft; // 0x0
	public static readonly LevelPlayBannerPosition TopCenter; // 0x8
	public static readonly LevelPlayBannerPosition TopRight; // 0x10
	public static readonly LevelPlayBannerPosition CenterLeft; // 0x18
	public static readonly LevelPlayBannerPosition Center; // 0x20
	public static readonly LevelPlayBannerPosition CenterRight; // 0x28
	public static readonly LevelPlayBannerPosition BottomLeft; // 0x30
	public static readonly LevelPlayBannerPosition BottomCenter; // 0x38
	public static readonly LevelPlayBannerPosition BottomRight; // 0x40

	// Methods

	// RVA: 0x151721C
	internal string get_Description() { }

	// RVA: 0x151723C
	internal Vector2 get_Position() { }

	// RVA: 0x15233C4
	private void .ctor(LevelPlayBannerPosition position) { }

	// RVA: 0x15233F8
	public void .ctor(Vector2 position) { }

	// RVA: 0x1523488
	private static void .cctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayConfiguration
{
	// Methods

	// RVA: 0x152375C
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInitError
{
	// Methods

	// RVA: 0x1523764
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInterstitialAd
{
	// Methods

	// RVA: 0x152376C
	public void .ctor(string adUnitId) { }

	// RVA: 0x1523774
	internal void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayReward
{
	// Methods

	// RVA: 0x151F374
	internal void .ctor(string name, int amount) { }

}

// Namespace: com.unity3d.mediation
public sealed class LevelPlayRewardedAd
{
	// Methods

	// RVA: 0x152377C
	public void .ctor(string adUnitId) { }

	// RVA: 0x1523784
	internal void .ctor(IPlatformRewardedAd platformRewardedAd) { }

}

// Namespace: com.unity3d.mediation
public class iOSBannerAd
{
	// Methods

	// RVA: 0x152378C
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

}

// Namespace: com.unity3d.mediation
public class IosLevelPlaySdk
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed; // 0x8
	private static System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> OnImpressionDataReady; // 0x10

	// Methods

	// RVA: 0x1523790
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x15238A0
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x15239B0
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1523AC4
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1523BD8
	public static void add_OnImpressionDataReady(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x1523CEC
	public static void remove_OnImpressionDataReady(System.Action<Unity.Services.LevelPlay.LevelPlayImpressionData> value) { }

	// RVA: 0x1523E00
	private void Awake() { }

	// RVA: 0x1523E8C
	private static void .cctor() { }

	// RVA: 0x1523E90
	public static void Initialize(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x15243EC
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x1524470
	internal static bool SetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1524528
	internal static void ValidateIntegration() { }

	// RVA: 0x1524594
	internal static void LaunchTestSuite() { }

	// RVA: 0x1524600
	internal static void SetAdaptersDebug(bool enabled) { }

	// RVA: 0x1524684
	internal static void SetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x152475C
	internal static void SetMetaData(string key, string value) { }

	// RVA: 0x1524834
	internal static void SetMetaData(string key, string[] values) { }

	// RVA: 0x15249B8
	internal static void SetConsent(bool consent) { }

	// RVA: 0x1524A3C
	internal static void SetSegment(LevelPlaySegment segment) { }

	// RVA: 0x15241AC
	private static string[] GetAdFormatArray(LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x15242E0
	private static extern void LPMInitialize(string appKey, string userId, string[] adFormats) { }

	// RVA: 0x1524140
	private static extern void setPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x152446C
	private static extern void LPMSetPauseGame(bool pause) { }

	// RVA: 0x1524AEC
	public void OnInitializationSuccess(string configuration) { }

	// RVA: 0x1524BBC
	public void OnInitializationFailed(string error) { }

	// RVA: 0x1524C8C
	public void onImpressionSuccess(string impressionData) { }

	// RVA: 0x15244F0
	private static extern bool LPMSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1524590
	private static extern void LPMValidateIntegration() { }

	// RVA: 0x15245FC
	private static extern void LPMLaunchTestSuite() { }

	// RVA: 0x1524680
	private static extern void LPMSetAdaptersDebug(bool enabled) { }

	// RVA: 0x1524714
	private static extern void LPMSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x15247EC
	private static extern void LPMSetMetaData(string key, string value) { }

	// RVA: 0x15248C0
	private static extern void LPMSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x1524A38
	private static extern void LPMSetConsent(bool consent) { }

	// RVA: 0x1524AC4
	private static extern void LPMSetSegment(string json) { }

	// RVA: 0x1524D5C
	public void .ctor() { }

}

// Namespace: com.unity3d.mediation
public abstract class IosNativeObject
{
	// Fields
	private static System.Collections.Concurrent.ConcurrentDictionary<System.IntPtr,com.unity3d.mediation.IosNativeObject> s_Objects; // 0x0
	private IntPtr m_NativePtr; // 0x10
	private readonly bool m_UsesCallbacks; // 0x18

	// Methods

	// RVA: 0x1516350
	protected void .ctor(bool usesCallbacks) { }

	// RVA: 0x1524D64
	public IntPtr get_NativePtr() { }

	// RVA: 0x1516400
	protected void set_NativePtr(IntPtr value) { }

	// RVA: 0x26AD93C
	protected static T Get(IntPtr ptr) { }

	// RVA: 0x1517208
	public virtual void Dispose() { }

	// RVA: 0x1516E58
	protected bool CheckDisposedAndLogError(string message) { }

	// RVA: 0x1524D6C
	private static void .cctor() { }

}

// Namespace: com.unity3d.mediation
public class UnsupportedBannerAd
{
	// Methods

	// RVA: 0x1524E08
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=5666
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=8514
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=8514 B5946179B6869DFD3DDBB17C0FFC171B2FEF91DEE799AFC022C12961EE1379DB; // 0x0
	internal static readonly __StaticArrayInitTypeSize=5666 FCFD58AA2601181370212FCF6D119110D3A431C3FA9DB4AB311808178AB0718A; // 0x2142
}


