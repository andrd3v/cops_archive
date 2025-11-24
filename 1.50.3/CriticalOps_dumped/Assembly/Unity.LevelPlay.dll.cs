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

	// RVA: 0x14B3AA4
	private void .ctor() { }

	// RVA: 0x14B3F94
	public static IronSource get_Agent() { }

	// RVA: 0x14B407C
	public static string pluginVersion() { }

	// RVA: 0x14B40F8
	public static string unityVersion() { }

	// RVA: 0x14B4168
	public static void setUnsupportedPlatform() { }

	// RVA: 0x14B41EC
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14B42A8
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14B4360
	public string getAdvertiserId() { }

	// RVA: 0x14B4418
	public void validateIntegration() { }

	// RVA: 0x14B44D0
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14B4588
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14B4640
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14B46F8
	public void setMetaData(string key, string value) { }

	// RVA: 0x14B47B8
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14B4878
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14B4930
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14B49E8
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14B4AA8
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14B4B60
	public void setUserId(string userId) { }

	// RVA: 0x14B4C18
	public void init(string appKey) { }

	// RVA: 0x14B4CD0
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14B4D90
	public void loadRewardedVideo() { }

	// RVA: 0x14B4E48
	public void showRewardedVideo() { }

	// RVA: 0x14B4F00
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14B4FB8
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14B5070
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14B5128
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14B51E0
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14B5298
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14B5350
	public void loadInterstitial() { }

	// RVA: 0x14B5408
	public void showInterstitial() { }

	// RVA: 0x14B54C0
	public void showInterstitial(string placementName) { }

	// RVA: 0x14B5578
	public bool isInterstitialReady() { }

	// RVA: 0x14B5630
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14B56E8
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14B57A8
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14B5878
	public void destroyBanner() { }

	// RVA: 0x14B5930
	public void displayBanner() { }

	// RVA: 0x14B59E8
	public void hideBanner() { }

	// RVA: 0x14B5AA0
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14B5B58
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14B5C10
	public float getDeviceScreenWidth() { }

	// RVA: 0x14B5CC8
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14B5D80
	public void setConsent(bool consent) { }

	// RVA: 0x14B5E38
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14B5EF0
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14B5FA8
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14B6068
	public void launchTestSuite() { }

	// RVA: 0x14B6120
	private static void .cctor() { }

}

// Namespace: 
public class IronSourceAdInfo
{
	// Fields
	public readonly string auctionId; // 0x10
	public readonly string adUnit; // 0x18
	public readonly string country; // 0x20
	public readonly string ab; // 0x28
	public readonly string segmentName; // 0x30
	public readonly string adNetwork; // 0x38
	public readonly string instanceName; // 0x40
	public readonly string instanceId; // 0x48
	public readonly System.Nullable<System.Double> revenue; // 0x50
	public readonly string precision; // 0x60
	public readonly System.Nullable<System.Double> lifetimeRevenue; // 0x68
	public readonly string encryptedCPM; // 0x78

	// Methods

	// RVA: 0x14B618C
	public void .ctor(string json) { }

	// RVA: 0x14B69A4
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

	// RVA: 0x14B6E7C
	private void Awake() { }

	// RVA: 0x14B6F30
	private static void add__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7000
	private static void remove__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B70D0
	public static void add_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7170
	public static void remove_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7210
	public void onAdLoaded(string args) { }

	// RVA: 0x14B72C8
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14B739C
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14B7470
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14B7510
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14B75B0
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14B7904
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B79D8
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7AAC
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7B4C
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7BEC
	public void onAdClicked(string args) { }

	// RVA: 0x14B7CA4
	private static void add__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7D78
	private static void remove__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7E4C
	public static void add_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7EEC
	public static void remove_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B7F8C
	public void onAdScreenPresented(string args) { }

	// RVA: 0x14B8044
	private static void add__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B8118
	private static void remove__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B81EC
	public static void add_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B828C
	public static void remove_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B832C
	public void onAdScreenDismissed(string args) { }

	// RVA: 0x14B83E4
	private static void add__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B84B8
	private static void remove__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B858C
	public static void add_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B862C
	public static void remove_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14B86CC
	public void onAdLeftApplication(string args) { }

	// RVA: 0x14B7648
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14B87C8
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14B8AE8
	public void .ctor() { }

}

// Namespace: 
public class IronSourceConfig
{
	// Fields
	private const string unsupportedPlatformStr = "Unsupported Platform";
	private static IronSourceConfig _instance; // 0x0

	// Methods

	// RVA: 0x14B8AF0
	public static IronSourceConfig get_Instance() { }

	// RVA: 0x14B8BA4
	private static extern void CFSetLanguage(string language) { }

	// RVA: 0x14B8BCC
	private static extern void CFSetClientSideCallbacks(bool useClientSideCallbacks) { }

	// RVA: 0x14B8BD0
	private static extern void CFSetRewardedVideoCustomParams(string rewardedVideoCustomParams) { }

	// RVA: 0x14B8BF8
	public void setLanguage(string language) { }

	// RVA: 0x14B8C24
	public void setClientSideCallbacks(bool status) { }

	// RVA: 0x14B8C2C
	public void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<System.String,System.String> rewardedVideoCustomParams) { }

	// RVA: 0x14B8B9C
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

	// RVA: 0x14B8C60
	public int getErrorCode() { }

	// RVA: 0x14B8C68
	public string getDescription() { }

	// RVA: 0x14B8C70
	public int getCode() { }

	// RVA: 0x14B8784
	public void .ctor(int errorCode, string errorDescription) { }

	// RVA: 0x14B8C78
	public override string ToString() { }

}

// Namespace: 
private sealed class ISUnityBackgroundCallback
{
	// Methods

	// RVA: 0x14B90D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BBDD4
	public virtual void Invoke(string args) { }

	// RVA: 0x14BBDE8
	public virtual IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x14BBE38
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

	// RVA: 0x14B8D94
	private static extern void RegisterCallback(ISUnityBackgroundCallback func) { }

	// RVA: 0x14B8DA8
	public static void add_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x14B8E78
	public static void remove_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x14B8F48
	private void Awake() { }

	// RVA: 0x14B8CDC
	public static void FireCallback(string args) { }

	// RVA: 0x14B9208
	private static void add__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14B92CC
	private static void remove__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14B9390
	public static void add_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14B94B4
	public static void remove_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14B95D8
	public void onSdkInitializationCompleted(string empty) { }

	// RVA: 0x14B9640
	private static void add__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14B9714
	private static void remove__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14B97E8
	public static void add_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14B9888
	public static void remove_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14B9928
	public void onSegmentReceived(string segmentName) { }

	// RVA: 0x14B99A4
	private static void add__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14B9A78
	private static void remove__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14B9B4C
	public static void add_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14B9BEC
	public static void remove_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14B9C8C
	public void onConsentViewDidFailToLoadWithError(string args) { }

	// RVA: 0x14BA098
	private static void add__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14BA16C
	private static void remove__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14BA240
	public static void add_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14BA2E0
	public static void remove_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14BA380
	public void onConsentViewDidFailToShowWithError(string args) { }

	// RVA: 0x14BA4D0
	private static void add__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA5A4
	private static void remove__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA678
	public static void add_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA718
	public static void remove_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA7B8
	public void onConsentViewDidAccept(string consentViewType) { }

	// RVA: 0x14BA834
	private static void add__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA908
	private static void remove__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14BA9DC
	public static void add_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAA7C
	public static void remove_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAB1C
	public void onConsentViewDidDismiss(string consentViewType) { }

	// RVA: 0x14BAB98
	private static void add__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAC6C
	private static void remove__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAD40
	public static void add_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BADE0
	public static void remove_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAE80
	public void onConsentViewDidLoadSuccess(string consentViewType) { }

	// RVA: 0x14BAEFC
	private static void add__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BAFD0
	private static void remove__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BB0A4
	public static void add_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BB144
	public static void remove_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14BB1E4
	public void onConsentViewDidShowSuccess(string consentViewType) { }

	// RVA: 0x14B9DDC
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14BB260
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14B918C
	private static void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args) { }

	// RVA: 0x14BBDCC
	public void .ctor() { }

}

// Namespace: 
public class IronSourceEventsDispatcher
{
	// Fields
	private static IronSourceEventsDispatcher instance; // 0x0
	private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue; // 0x8

	// Methods

	// RVA: 0x14BBE44
	public static void executeAction(Action action) { }

	// RVA: 0x14BBF98
	private void Update() { }

	// RVA: 0x14BC378
	public void removeFromParent() { }

	// RVA: 0x14BC488
	public static void initialize() { }

	// RVA: 0x14BC684
	public static bool isCreated() { }

	// RVA: 0x14BC750
	public void Awake() { }

	// RVA: 0x14BC7DC
	public void OnDisable() { }

	// RVA: 0x14BC844
	public void .ctor() { }

	// RVA: 0x14BC84C
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

	// RVA: 0x14BC8FC
	public static string get_MOPUB() { }

}

// Namespace: 
public static class IronSourceAdUnits
{
	// Methods

	// RVA: 0x14BC940
	public static string get_REWARDED_VIDEO() { }

	// RVA: 0x14BC984
	public static string get_INTERSTITIAL() { }

	// RVA: 0x14BC9C8
	public static string get_OFFERWALL() { }

	// RVA: 0x14BCA0C
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

	// RVA: 0x14BCA50
	private void .ctor() { }

	// RVA: 0x14BCAFC
	public void .ctor(int width, int height) { }

	// RVA: 0x14BCBB4
	public void .ctor(string description) { }

	// RVA: 0x14BCC50
	public void SetAdaptive(bool adaptive, int customWidth) { }

	// RVA: 0x14BCCE0
	public bool IsAdaptiveEnabled() { }

	// RVA: 0x14BCCE8
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14BCCF0
	public ISContainerParams getBannerContainerParams() { }

	// RVA: 0x14BCCF8
	public void SetRespectAndroidCutouts(bool respectAndroidCutouts) { }

	// RVA: 0x14BCD00
	public bool IsRespectAndroidCutoutsEnabled() { }

	// RVA: 0x14BCD08
	public string get_Description() { }

	// RVA: 0x14BCD10
	public int get_Width() { }

	// RVA: 0x14BCD18
	public int get_Height() { }

	// RVA: 0x14BCD20
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

	// RVA: 0x14BD004
	public float get_Width() { }

	// RVA: 0x14BD00C
	public void set_Width(float value) { }

	// RVA: 0x14BD014
	public float get_Height() { }

	// RVA: 0x14BD01C
	public void set_Height(float value) { }

	// RVA: 0x14BCAD0
	public void .ctor() { }

}

// Namespace: 
public class IronSourceImpressionData
{
	// Fields
	public readonly string auctionId; // 0x10
	public readonly string adUnit; // 0x18
	public readonly string adFormat; // 0x20
	public readonly string mediationAdUnitName; // 0x28
	public readonly string mediationAdUnitId; // 0x30
	public readonly string country; // 0x38
	public readonly string ab; // 0x40
	public readonly string segmentName; // 0x48
	public readonly string placement; // 0x50
	public readonly string adNetwork; // 0x58
	public readonly string instanceName; // 0x60
	public readonly string instanceId; // 0x68
	public readonly System.Nullable<System.Double> revenue; // 0x70
	public readonly string precision; // 0x80
	public readonly System.Nullable<System.Double> lifetimeRevenue; // 0x88
	public readonly string encryptedCPM; // 0x98
	public readonly System.Nullable<System.Int32> conversionValue; // 0xA0
	public readonly string allData; // 0xA8

	// Methods

	// RVA: 0x14BB524
	public void .ctor(string json) { }

	// RVA: 0x14BD024
	public override string ToString() { }

}

// Namespace: 
public class IronSourceInitilizer
{
	// Methods

	// RVA: 0x14BD6B4
	private static void Initilize() { }

	// RVA: 0x14BDC30
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

	// RVA: 0x14BDC38
	private void Awake() { }

	// RVA: 0x14BDCEC
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BDDBC
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BDE8C
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BDF2C
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BDFCC
	public void onAdReady(string args) { }

	// RVA: 0x14BE084
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14BE158
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14BE22C
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14BE2CC
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14BE36C
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14BE6C0
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BE794
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BE868
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BE908
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BE9A8
	public void onAdOpened(string args) { }

	// RVA: 0x14BEA60
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BEB34
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BEC08
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BECA8
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BED48
	public void onAdClosed(string args) { }

	// RVA: 0x14BEE00
	private static void add__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BEED4
	private static void remove__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BEFA8
	public static void add_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF048
	public static void remove_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF0E8
	public void onAdShowSucceeded(string args) { }

	// RVA: 0x14BF1A0
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14BF274
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14BF348
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14BF3E8
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14BF488
	public void onAdShowFailed(string args) { }

	// RVA: 0x14BF5F4
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF6C8
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF79C
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF83C
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14BF8DC
	public void onAdClicked(string args) { }

	// RVA: 0x14BE404
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14BF994
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14BFC58
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

	// RVA: 0x14BFC60
	public void .ctor() { }

	// RVA: 0x14BFCE4
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

	// RVA: 0x14B8A8C
	public void .ctor(string placementName, string rewardName, int rewardAmount) { }

	// RVA: 0x14BFDA0
	public string getRewardName() { }

	// RVA: 0x14BFDA8
	public int getRewardAmount() { }

	// RVA: 0x14BFDB0
	public string getPlacementName() { }

	// RVA: 0x14BFDB8
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

	// RVA: 0x14BFEE0
	private void Awake() { }

	// RVA: 0x14BFF94
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14C0064
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14C0134
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14C01D4
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14C0274
	public void onAdShowFailed(string args) { }

	// RVA: 0x14C069C
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0770
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0844
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C08E4
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0984
	public void onAdOpened(string args) { }

	// RVA: 0x14C0A3C
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0B10
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0BE4
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0C84
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C0D24
	public void onAdClosed(string args) { }

	// RVA: 0x14C0DDC
	private static void add__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C0EB0
	private static void remove__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C0F84
	public static void add_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C1024
	public static void remove_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C10C4
	public void onAdRewarded(string args) { }

	// RVA: 0x14C14F4
	private static void add__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C15C8
	private static void remove__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C169C
	public static void add_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C173C
	public static void remove_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14C17DC
	public void onAdClicked(string args) { }

	// RVA: 0x14C1948
	private static void add__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C1A1C
	private static void remove__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C1AF0
	public static void add_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C1B90
	public static void remove_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C1C30
	public void onAdAvailable(string args) { }

	// RVA: 0x14C1CE8
	private static void add__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14C1DAC
	private static void remove__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14C1E70
	public static void add_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14C1F94
	public static void remove_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14C20B8
	public void onAdUnavailable() { }

	// RVA: 0x14C2120
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14C21F4
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14C22C8
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14C2368
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14C2408
	public void onAdLoadFailed(string description) { }

	// RVA: 0x14C24A0
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C2574
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C2648
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C26E8
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14C2788
	public void onAdReady(string adinfo) { }

	// RVA: 0x14C03E0
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14C1230
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14C2840
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

	// RVA: 0x14C2E64
	private static void .cctor() { }

	// RVA: 0x14C2ED0
	public void .ctor() { }

	// RVA: 0x14C2ED8
	internal string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> d) { }

	// RVA: 0x14C2FA0
	internal string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

	// RVA: 0x14C3050
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

	// RVA: 0x14C2848
	public void .ctor() { }

	// RVA: 0x14C28EC
	public void setCustom(string key, string value) { }

	// RVA: 0x14C2958
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

	// RVA: 0x14C3150
	public static IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14C340C
	public static IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14C36D0
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

	// RVA: 0x14C3E8C
	private static void .cctor() { }

	// RVA: 0x14C3EF8
	public void .ctor() { }

	// RVA: 0x14C3F00
	internal void <.ctor>b__3_0(string <p0>) { }

}

// Namespace: 
public class IronSourceSegmentAndroid
{
	// Fields
	private System.Action<System.String> OnSegmentRecieved; // 0x20

	// Methods

	// RVA: 0x14C36D8
	public void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14C378C
	public void remove_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14C3840
	public void .ctor() { }

	// RVA: 0x14C3E70
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

	// RVA: 0x14C5364
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C5408
	public virtual void Invoke(bool pause) { }

	// RVA: 0x14C541C
	public virtual IAsyncResult BeginInvoke(bool pause, AsyncCallback callback, object object) { }

	// RVA: 0x14C54D8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class iOSAgent
{
	// Methods

	// RVA: 0x14C3F04
	private static extern void LPPSetWaterfallConfiguration(IOSWaterfallConfiguration configurationParams, AdFormat adFormat) { }

	// RVA: 0x14C3F08
	private static extern void CFSetPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14C3F74
	private static extern string CFGetAdvertiserId() { }

	// RVA: 0x14C3FA8
	private static extern void CFValidateIntegration() { }

	// RVA: 0x14C3FAC
	private static extern void CFShouldTrackNetworkState(bool track) { }

	// RVA: 0x14C3FB0
	private static extern bool CFSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14C3FE8
	private static extern void CFSetAdaptersDebug(bool enabled) { }

	// RVA: 0x14C3FEC
	private static extern void CFSetMetaData(string key, string value) { }

	// RVA: 0x14C4034
	private static extern void CFSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x14C412C
	private static extern string CFGetConversionValue() { }

	// RVA: 0x14C4160
	private static extern void CFSetManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14C4164
	private static extern void CFSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14C41AC
	private static extern void RegisterPauseGameFunction(bool pasue) { }

	// RVA: 0x14C41B0
	private static extern void CFSetUserId(string userId) { }

	// RVA: 0x14C41D8
	private static extern void CFInit(string appKey) { }

	// RVA: 0x14C4200
	private static extern void CFInitWithAdUnits(string appKey, string[] adUnits) { }

	// RVA: 0x14C42F8
	private static extern void CFLoadRewardedVideo() { }

	// RVA: 0x14C42FC
	private static extern void CFShowRewardedVideo() { }

	// RVA: 0x14C4300
	private static extern void CFShowRewardedVideoWithPlacementName(string placementName) { }

	// RVA: 0x14C4328
	private static extern bool CFIsRewardedVideoAvailable() { }

	// RVA: 0x14C4344
	private static extern bool CFIsRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14C437C
	private static extern string CFGetPlacementInfo(string placementName) { }

	// RVA: 0x14C43C8
	private static extern void CFSetRewardedVideoServerParameters(string jsonString) { }

	// RVA: 0x14C43F0
	private static extern void CFClearRewardedVideoServerParameters() { }

	// RVA: 0x14C43F4
	private static extern void CFLoadInterstitial() { }

	// RVA: 0x14C43F8
	private static extern void CFShowInterstitial() { }

	// RVA: 0x14C43FC
	private static extern void CFShowInterstitialWithPlacementName(string placementName) { }

	// RVA: 0x14C4424
	private static extern bool CFIsInterstitialReady() { }

	// RVA: 0x14C4440
	private static extern bool CFIsInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14C4478
	private static extern void CFLoadBanner(string description, int width, int height, int position, string placementName, bool isAdaptive, float containerWidth, float containerHeight) { }

	// RVA: 0x14C4508
	private static extern void CFDestroyBanner() { }

	// RVA: 0x14C450C
	private static extern void CFDisplayBanner() { }

	// RVA: 0x14C4510
	private static extern void CFHideBanner() { }

	// RVA: 0x14C4514
	private static extern bool CFIsBannerPlacementCapped(string placementName) { }

	// RVA: 0x14C454C
	private static extern float CFIGetMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14C4550
	private static extern float CFIGetDeviceScreenWidth() { }

	// RVA: 0x14C4554
	private static extern void CFSetSegment(string json) { }

	// RVA: 0x14C457C
	private static extern void CFSetConsent(bool consent) { }

	// RVA: 0x14C4580
	private static extern void CFLoadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C45A8
	private static extern void CFShowConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C45D0
	private static extern void CFSetAdRevenueData(string dataSource, string impressionData) { }

	// RVA: 0x14C4618
	private static extern void CFLaunchTestSuite() { }

	// RVA: 0x14B3F30
	public void .ctor() { }

	// RVA: 0x14C461C
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14C47A0
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14C47A4
	public string getAdvertiserId() { }

	// RVA: 0x14C47D8
	public void validateIntegration() { }

	// RVA: 0x14C47DC
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14C47E4
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14C4820
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14C4828
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14C4834
	public void setMetaData(string key, string value) { }

	// RVA: 0x14C4880
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14C4984
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14C498C
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14C49D8
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14C4A90
	public void setUserId(string userId) { }

	// RVA: 0x14C4ABC
	public void init(string appKey) { }

	// RVA: 0x14C4C34
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14C4DAC
	public void loadRewardedVideo() { }

	// RVA: 0x14C4DB0
	public void showRewardedVideo() { }

	// RVA: 0x14C4DB4
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14C4DE0
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14C4DFC
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14C4E38
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14C5064
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14C5094
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14C5098
	public void loadInterstitial() { }

	// RVA: 0x14C509C
	public void showInterstitial() { }

	// RVA: 0x14C50A0
	public void showInterstitial(string placementName) { }

	// RVA: 0x14C50CC
	public bool isInterstitialReady() { }

	// RVA: 0x14C50E8
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14C5124
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14C5180
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14C521C
	public void destroyBanner() { }

	// RVA: 0x14C5220
	public void displayBanner() { }

	// RVA: 0x14C5224
	public void hideBanner() { }

	// RVA: 0x14C5228
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14C5264
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14C5268
	public float getDeviceScreenWidth() { }

	// RVA: 0x14C526C
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14C52A8
	public void setConsent(bool consent) { }

	// RVA: 0x14C52B0
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C52DC
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C5308
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14C5360
	public void launchTestSuite() { }

}

// Namespace: 
public class UnsupportedPlatformAgent
{
	// Methods

	// RVA: 0x14B3F38
	public void .ctor() { }

	// RVA: 0x14C54E4
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14C54E8
	public void start() { }

	// RVA: 0x14C54EC
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14C54F0
	public string getAdvertiserId() { }

	// RVA: 0x14C5534
	public void validateIntegration() { }

	// RVA: 0x14C5538
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14C553C
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14C5544
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14C5548
	public void setMetaData(string key, string value) { }

	// RVA: 0x14C554C
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14C5550
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14C5558
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14C555C
	public void setNetworkData(string networkKey, string networkDataJson) { }

	// RVA: 0x14C5560
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14C5564
	public void setUserId(string userId) { }

	// RVA: 0x14C5568
	public void init(string appKey) { }

	// RVA: 0x14C556C
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14C5570
	public void loadRewardedVideo() { }

	// RVA: 0x14C5574
	public void showRewardedVideo() { }

	// RVA: 0x14C5578
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14C557C
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14C5584
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14C558C
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14C5594
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14C5598
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14C559C
	public void loadInterstitial() { }

	// RVA: 0x14C55A0
	public void showInterstitial() { }

	// RVA: 0x14C55A4
	public void showInterstitial(string placementName) { }

	// RVA: 0x14C55A8
	public bool isInterstitialReady() { }

	// RVA: 0x14C55B0
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14C55B8
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14C55BC
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14C55C0
	public void destroyBanner() { }

	// RVA: 0x14C55C4
	public void displayBanner() { }

	// RVA: 0x14C55C8
	public void hideBanner() { }

	// RVA: 0x14C55CC
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14C55D4
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14C55DC
	public float getDeviceScreenWidth() { }

	// RVA: 0x14C55E4
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14C55E8
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14C55EC
	public void setConsent(bool consent) { }

	// RVA: 0x14C55F0
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C55F4
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14C55F8
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14C55FC
	public void launchTestSuite() { }

}

// Namespace: 
public class WaterfallConfigurationBuilder
{
	// Fields
	private System.Nullable<System.Double> ceiling; // 0x10
	private System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14C56FC
	internal void .ctor() { }

	// RVA: 0x14C57CC
	public WaterfallConfigurationBuilder SetCeiling(Double ceiling) { }

	// RVA: 0x14C5850
	public WaterfallConfigurationBuilder SetFloor(Double floor) { }

	// RVA: 0x14C58D4
	public WaterfallConfiguration Build() { }

}

// Namespace: 
public class WaterfallConfiguration
{
	// Fields
	private readonly System.Nullable<System.Double> ceiling; // 0x10
	private readonly System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14C5640
	public System.Nullable<System.Double> get_Ceiling() { }

	// RVA: 0x14C564C
	public System.Nullable<System.Double> get_Floor() { }

	// RVA: 0x14C5658
	private void .ctor(System.Nullable<System.Double> ceiling, System.Nullable<System.Double> floor) { }

	// RVA: 0x14C56A4
	public static WaterfallConfigurationBuilder Builder() { }

	// RVA: 0x14C5704
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

	// RVA: 0x14C5958
	private static MonoScriptData Get() { }

	// RVA: 0x14C5A5C
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

	// RVA: 0x14C5D04
	private void .ctor(string jsonString) { }

	// RVA: 0x14C5A64
	public static object Parse(string jsonString) { }

	// RVA: 0x14C5DAC
	public void Dispose() { }

	// RVA: 0x14C5DE8
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x14C66B4
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x14C5D84
	private object ParseValue() { }

	// RVA: 0x14C67C4
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x14C6218
	private string ParseString() { }

	// RVA: 0x14C68D0
	private object ParseNumber() { }

	// RVA: 0x14C6C1C
	private void EatWhitespace() { }

	// RVA: 0x14C6D14
	private Char get_PeekChar() { }

	// RVA: 0x14C6A04
	private Char get_NextChar() { }

	// RVA: 0x14C6A90
	private string get_NextWord() { }

	// RVA: 0x14C5F74
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x14C6DA0
	private void .ctor() { }

	// RVA: 0x14C5C30
	public static string Serialize(object obj) { }

	// RVA: 0x14C6E18
	private void SerializeValue(object value) { }

	// RVA: 0x14C75F4
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x14C72AC
	private void SerializeArray(IList anArray) { }

	// RVA: 0x14C6FF0
	private void SerializeString(string str) { }

	// RVA: 0x14C7A78
	private void SerializeOther(object value) { }

}

// Namespace: IronSourceJSON
public static class Json
{
	// Methods

	// RVA: 0x14B683C
	public static object Deserialize(string json) { }

	// RVA: 0x14B8C5C
	public static string Serialize(object obj) { }

}

// Namespace: Unity.Services.LevelPlay
internal static class Constants
{
	// Fields
	internal const string PackageName = "com.unity.services.levelplay";
	internal const string PackageVersion = "8.5.1";
	internal const string PackageVersionAnnotation = "";
	internal const string AnnotatedPackageVersion = "8.5.1";
	internal const string PackageAnalyticsIdentifier = "UnityLevelPlay";
	internal const string UnityPackageDirectoryName = "LevelPlay";
}

// Namespace: Unity.Services.LevelPlay
internal static class LevelPlayLogger
{
	// Fields
	private const string k_Tag = "[LevelPlay]";
	private const string k_VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_LEVELPLAY_VERBOSE_LOGGING";
	private const string k_UnityAssertions = "UNITY_ASSERTIONS";

	// Methods

	// RVA: 0x14B6848
	public static void Log(object message) { }

	// RVA: 0x14BDAD4
	public static void LogWarning(object message) { }

	// RVA: 0x14C3D14
	public static void LogError(object message) { }

	// RVA: 0x14BC218
	public static void LogException(Exception exception) { }

	// RVA: 0x14C7C64
	public static void LogAssertion(object message) { }

	// RVA: 0x14C7DC4
	public static void LogVerbose(object message) { }

}

// Namespace: com.unity3d.mediation
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

// Namespace: com.unity3d.mediation
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

// Namespace: com.unity3d.mediation
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
	public static readonly com.unity3d.mediation.LevelPlay.<>c <>9; // 0x0

	// Methods

	// RVA: 0x14C8AE4
	private static void .cctor() { }

	// RVA: 0x14C8B50
	public void .ctor() { }

	// RVA: 0x14C8B58
	internal void <.cctor>b__12_0(LevelPlayConfiguration configuration) { }

	// RVA: 0x14C8BFC
	internal void <.cctor>b__12_1(LevelPlayInitError error) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlay
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> InitSuccessReceived; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived; // 0x8

	// Methods

	// RVA: 0x14C7F20
	private static void add_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14C8030
	private static void remove_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14C8140
	private static void add_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14C8254
	private static void remove_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14C8368
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14C8480
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14C8594
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14C86AC
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14C87C0
	private static void .cctor() { }

	// RVA: 0x14C8900
	public static void Init(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14C897C
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14C8ADC
	public void .ctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdDisplayInfoError
{
	// Fields
	private LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField; // 0x10
	private LevelPlayAdError <LevelPlayError>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14C8CA0
	public LevelPlayAdInfo get_DisplayLevelPlayAdInfo() { }

	// RVA: 0x14C8CA8
	private void set_DisplayLevelPlayAdInfo(LevelPlayAdInfo value) { }

	// RVA: 0x14C8CB0
	public LevelPlayAdError get_LevelPlayError() { }

	// RVA: 0x14C8CB8
	private void set_LevelPlayError(LevelPlayAdError value) { }

	// RVA: 0x14C8CC0
	public void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

	// RVA: 0x14C8D10
	public override string ToString() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18
	private readonly string <AdUnitId>k__BackingField; // 0x20

	// Methods

	// RVA: 0x14C8DB4
	public int get_ErrorCode() { }

	// RVA: 0x14C8DBC
	public string get_ErrorMessage() { }

	// RVA: 0x14C8DC4
	public string get_AdUnitId() { }

	// RVA: 0x14C8DCC
	internal void .ctor(string json) { }

	// RVA: 0x14C9090
	public void .ctor(string adUnitId, int errorCode, string errorMessage) { }

	// RVA: 0x14C90E8
	public override string ToString() { }

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
	// Fields
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
	public readonly string AdUnitId; // 0x90
	public readonly string AdUnitName; // 0x98
	public readonly LevelPlayAdSize AdSize; // 0xA0
	public readonly string AdFormat; // 0xA8
	public readonly string PlacementName; // 0xB0
	public readonly string AuctionId; // 0xB8
	public readonly string Country; // 0xC0
	public readonly string Ab; // 0xC8
	public readonly string SegmentName; // 0xD0
	public readonly string AdNetwork; // 0xD8
	public readonly string InstanceName; // 0xE0
	public readonly string InstanceId; // 0xE8
	public readonly System.Nullable<System.Double> Revenue; // 0xF0
	public readonly string Precision; // 0x100
	public readonly string EncryptedCPM; // 0x108

	// Methods

	// RVA: 0x14C9178
	internal void .ctor(string json) { }

	// RVA: 0x14C9C04
	private static LevelPlayAdSize GetAdSize(string adSizeJson) { }

	// RVA: 0x14C9F4C
	public override string ToString() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdSize
{
	// Fields
	private int width; // 0x10
	private int height; // 0x14
	private string description; // 0x18
	private int customWidth; // 0x20
	public static LevelPlayAdSize BANNER; // 0x0
	public static LevelPlayAdSize LARGE; // 0x8
	public static LevelPlayAdSize MEDIUM_RECTANGLE; // 0x10
	public static LevelPlayAdSize LEADERBOARD; // 0x18

	// Methods

	// RVA: 0x14CA358
	private void .ctor(string description) { }

	// RVA: 0x14C9EFC
	internal void .ctor(string description, int width, int height) { }

	// RVA: 0x14CA394
	public static LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x14CA438
	public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x14CA4D0
	public string get_Description() { }

	// RVA: 0x14CA4D8
	public int get_Width() { }

	// RVA: 0x14CA4E0
	public int get_Height() { }

	// RVA: 0x14CA4E8
	public int get_CustomWidth() { }

	// RVA: 0x14CA4F0
	public override string ToString() { }

	// RVA: 0x14CA5A8
	private static void .cctor() { }

}

// Namespace: com.unity3d.mediation
public sealed class LevelPlayBannerAd
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

	// RVA: 0x14CA758
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CA80C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CA8C0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CA974
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CAA28
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CAADC
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CAB90
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CAC44
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CACF8
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CADAC
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CAE60
	public void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CAF14
	public void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CAFC8
	public void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CB07C
	public void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CB130
	public void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CB1E4
	public void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CB298
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

	// RVA: 0x14CBA98
	public void LoadAd() { }

	// RVA: 0x14CBB50
	public void DestroyAd() { }

	// RVA: 0x14CBC08
	public void ShowAd() { }

	// RVA: 0x14CBCC0
	public void HideAd() { }

	// RVA: 0x14CBD78
	public string GetAdUnitId() { }

	// RVA: 0x14CBE30
	public LevelPlayAdSize GetAdSize() { }

	// RVA: 0x14CBEE8
	public LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x14CBFA0
	public string GetPlacementName() { }

	// RVA: 0x14CC058
	public void PauseAutoRefresh() { }

	// RVA: 0x14CC110
	public void ResumeAutoRefresh() { }

	// RVA: 0x14CB544
	private void SetupCallbacks() { }

	// RVA: 0x14CC1C8
	public void Dispose() { }

	// RVA: 0x14CC288
	private void <SetupCallbacks>b__37_0(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14CC2AC
	private void <SetupCallbacks>b__37_1(object sender, LevelPlayAdError args) { }

	// RVA: 0x14CC2D0
	private void <SetupCallbacks>b__37_2(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14CC2F4
	private void <SetupCallbacks>b__37_3(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14CC318
	private void <SetupCallbacks>b__37_4(object sender, LevelPlayAdDisplayInfoError args) { }

	// RVA: 0x14CC33C
	private void <SetupCallbacks>b__37_5(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14CC360
	private void <SetupCallbacks>b__37_6(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14CC384
	private void <SetupCallbacks>b__37_7(object sender, LevelPlayAdInfo args) { }

}

// Namespace: com.unity3d.mediation
public enum LevelPlayBannerPosition
{
	// Fields
	public int value__; // 0x10
	public const LevelPlayBannerPosition TopCenter = 1;
	public const LevelPlayBannerPosition BottomCenter = 2;
}

// Namespace: com.unity3d.mediation
public class LevelPlayConfiguration
{
	// Fields
	private const string k_IsAdQualityEnabled = "isAdQualityEnabled";
	private readonly bool <IsAdQualityEnabled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x14CC3A8
	public bool get_IsAdQualityEnabled() { }

	// RVA: 0x14CC3B0
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInitError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14CC624
	public int get_ErrorCode() { }

	// RVA: 0x14CC62C
	public string get_ErrorMessage() { }

	// RVA: 0x14CC634
	internal void .ctor(string json) { }

	// RVA: 0x14CC8A0
	public string ToString() { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14CC930
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CC9E4
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCA98
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CCB4C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CCC00
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCCB4
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCD68
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCE1C
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCED0
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CCF84
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CD038
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CD0EC
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CD1A0
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CD254
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CD308
	public string get_AdUnitId() { }

	// RVA: 0x14CD3C0
	public void .ctor(string adUnitId) { }

	// RVA: 0x14CD8CC
	internal void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

	// RVA: 0x14CD900
	public void LoadAd() { }

	// RVA: 0x14CD9B8
	public void DestroyAd() { }

	// RVA: 0x14CDB20
	public void ShowAd(string placementName) { }

	// RVA: 0x14CDBD8
	public bool IsAdReady() { }

	// RVA: 0x14CDC90
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14CDA6C
	public void Dispose() { }

	// RVA: 0x14CDC98
	private void <.ctor>b__24_0(LevelPlayAdInfo info) { }

	// RVA: 0x14CDCB4
	private void <.ctor>b__24_1(LevelPlayAdError error) { }

	// RVA: 0x14CDCD0
	private void <.ctor>b__24_2(LevelPlayAdInfo info) { }

	// RVA: 0x14CDCEC
	private void <.ctor>b__24_3(LevelPlayAdInfo info) { }

	// RVA: 0x14CDD08
	private void <.ctor>b__24_4(LevelPlayAdInfo info) { }

	// RVA: 0x14CDD24
	private void <.ctor>b__24_5(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x14CDD40
	private void <.ctor>b__24_6(LevelPlayAdInfo info) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayReward
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	private readonly int <Amount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14CDD5C
	public string get_Name() { }

	// RVA: 0x14CDD64
	public int get_Amount() { }

	// RVA: 0x14CDD6C
	internal void .ctor(string name, int amount) { }

}

// Namespace: com.unity3d.mediation
public sealed class LevelPlayRewardedAd
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

	// RVA: 0x14CDDB4
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CDE68
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CDF1C
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CDFD0
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CE084
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE138
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE1EC
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CE2A0
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CE354
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14CE408
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14CE4BC
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE570
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE624
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE6D8
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE78C
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE840
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CE8F4
	public string get_AdUnitId() { }

	// RVA: 0x14CE9AC
	public void .ctor(string adUnitId) { }

	// RVA: 0x14CEF64
	internal void .ctor(IPlatformRewardedAd platformRewardedAd) { }

	// RVA: 0x14CEF98
	public void LoadAd() { }

	// RVA: 0x14CF050
	public void ShowAd(string placementName) { }

	// RVA: 0x14CF108
	public void DestroyAd() { }

	// RVA: 0x14CF270
	public bool IsAdReady() { }

	// RVA: 0x14CF328
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14CF1BC
	public void Dispose() { }

	// RVA: 0x14CF330
	private void <.ctor>b__27_0(LevelPlayAdInfo info) { }

	// RVA: 0x14CF34C
	private void <.ctor>b__27_1(LevelPlayAdError error) { }

	// RVA: 0x14CF368
	private void <.ctor>b__27_2(LevelPlayAdInfo info) { }

	// RVA: 0x14CF384
	private void <.ctor>b__27_3(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x14CF3A0
	private void <.ctor>b__27_4(LevelPlayAdInfo info, LevelPlayReward reward) { }

	// RVA: 0x14CF3BC
	private void <.ctor>b__27_5(LevelPlayAdInfo info) { }

	// RVA: 0x14CF3D8
	private void <.ctor>b__27_6(LevelPlayAdInfo info) { }

	// RVA: 0x14CF3F4
	private void <.ctor>b__27_7(LevelPlayAdInfo info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x14CFEF4
	public void .ctor() { }

	// RVA: 0x14D0F74
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x14D0184
	public void .ctor() { }

	// RVA: 0x14D12E0
	internal void <ShowAd>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class AndroidInterstitialAd
{
	// Fields
	private const string k_AndroidInterstitialClass = "com.ironsource.unity.androidbridge.InterstitialAd";
	private const string k_AndroidLoadAdFunction = "loadAd";
	private const string k_AndroidShowAdFunction = "showAd";
	private const string k_IsAdReadyFunction = "isAdReady";
	private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";
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

	// RVA: 0x14CF410
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF4C4
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF578
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CF62C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14CF6E0
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF794
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF848
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF8FC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CF9B0
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CFA64
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CFB18
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CFBCC
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14CFC80
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CFD34
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14CFDE8
	public string get_AdUnitId() { }

	// RVA: 0x14CFDF0
	internal void .ctor(string adUnitId) { }

	// RVA: 0x14CFEFC
	public void LoadAd() { }

	// RVA: 0x14D0050
	public void ShowAd(string placementName) { }

	// RVA: 0x14D018C
	public bool IsAdReady() { }

	// RVA: 0x14D0298
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14D0580
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14D060C
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14D0698
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14D0724
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14D0830
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14D08BC
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14D0948
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14D09D4
	private void Dispose(bool disposing) { }

	// RVA: 0x14D0A8C
	public void Dispose() { }

	// RVA: 0x14D0B2C
	protected override void Finalize() { }

	// RVA: 0x14CFFEC
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x14D0C00
	private void <LoadAd>b__35_0(object state) { }

	// RVA: 0x14D0D74
	private void <IsAdReady>b__37_0(object state) { }

	// RVA: 0x14D0F20
	private void <Dispose>b__46_0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x14D20B0
	public void .ctor() { }

	// RVA: 0x14D3210
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x14D2340
	public void .ctor() { }

	// RVA: 0x14D357C
	internal void <ShowAd>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class AndroidRewardedAd
{
	// Fields
	private const string k_AndroidRewardedAdClass = "com.ironsource.unity.androidbridge.RewardedAd";
	private const string k_AndroidLoadAdFunction = "loadAd";
	private const string k_AndroidShowAdFunction = "showAd";
	private const string k_IsAdReadyFunction = "isAdReady";
	private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";
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

	// RVA: 0x14D1464
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1518
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D15CC
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D1680
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D1734
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D17E8
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D189C
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D1950
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D1A04
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14D1AB8
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14D1B6C
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1C20
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1CD4
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1D88
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1E3C
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1EF0
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D1FA4
	public string get_AdUnitId() { }

	// RVA: 0x14D1FAC
	internal void .ctor(string adUnitId) { }

	// RVA: 0x14D20B8
	public void LoadAd() { }

	// RVA: 0x14D220C
	public void ShowAd(string placementName) { }

	// RVA: 0x14D2348
	public bool IsAdReady() { }

	// RVA: 0x14D2454
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14D273C
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14D27C8
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14D2854
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14D28E0
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14D29EC
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14D2ACC
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14D2B58
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14D2BE4
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14D2C70
	private void Dispose(bool disposing) { }

	// RVA: 0x14D2D28
	public void Dispose() { }

	// RVA: 0x14D2DC8
	protected override void Finalize() { }

	// RVA: 0x14D21A8
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x14D2E9C
	private void <LoadAd>b__38_0(object state) { }

	// RVA: 0x14D3010
	private void <IsAdReady>b__40_0(object state) { }

	// RVA: 0x14D31BC
	private void <Dispose>b__50_0(object state) { }

}

// Namespace: com.unity3d.mediation
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

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14D37E4
	public void .ctor() { }

	// RVA: 0x14D3D88
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14D38D0
	public void .ctor() { }

	// RVA: 0x14D3E50
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D39BC
	public void .ctor() { }

	// RVA: 0x14D3F1C
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

	// RVA: 0x14D3ABC
	public void .ctor() { }

	// RVA: 0x14D3FE8
	internal void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D3BA8
	public void .ctor() { }

	// RVA: 0x14D40AC
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D3C94
	public void .ctor() { }

	// RVA: 0x14D4178
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D3D80
	public void .ctor() { }

	// RVA: 0x14D4244
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityInterstitialAdListener
{
	// Fields
	private const string k_AndroidInterstitialListenerName = "com.ironsource.unity.androidbridge.IUnityInterstitialAdListener";
	private readonly IUnityInterstitialAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x14D1250
	public void .ctor(IUnityInterstitialAdListener listener) { }

	// RVA: 0x14D3700
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14D37EC
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14D38D8
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14D39C4
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14D3AC4
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14D3BB0
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14D3C9C
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D4AA0
	public void .ctor() { }

	// RVA: 0x14D4AA8
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D43F4
	public void .ctor() { }

	// RVA: 0x14D4B74
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14D44E0
	public void .ctor() { }

	// RVA: 0x14D4C3C
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D45CC
	public void .ctor() { }

	// RVA: 0x14D4D08
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

	// RVA: 0x14D46CC
	public void .ctor() { }

	// RVA: 0x14D4DD4
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

	// RVA: 0x14D47DC
	public void .ctor() { }

	// RVA: 0x14D4E98
	internal void <onAdRewarded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D48C8
	public void .ctor() { }

	// RVA: 0x14D4F64
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D49B4
	public void .ctor() { }

	// RVA: 0x14D5030
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityRewardedAdListener
{
	// Fields
	private const string k_AndroidRewardedAdListenerName = "com.ironsource.unity.androidbridge.IUnityRewardedAdListener";
	private readonly IUnityRewardedAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x14D34EC
	public void .ctor(IUnityRewardedAdListener listener) { }

	// RVA: 0x14D4310
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14D43FC
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14D44E8
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14D45D4
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14D46D4
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14D47E4
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14D48D0
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14D49BC
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass48_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D64C0
	public void .ctor() { }

	// RVA: 0x14D6B90
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass49_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdError error; // 0x18

	// Methods

	// RVA: 0x14D65AC
	public void .ctor() { }

	// RVA: 0x14D6BCC
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass50_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D6698
	public void .ctor() { }

	// RVA: 0x14D6C08
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass51_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D6784
	public void .ctor() { }

	// RVA: 0x14D6C44
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14D68C4
	public void .ctor() { }

	// RVA: 0x14D6C80
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D69B0
	public void .ctor() { }

	// RVA: 0x14D6CBC
	internal void <InvokeExpandedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D6A9C
	public void .ctor() { }

	// RVA: 0x14D6CF8
	internal void <InvokeCollapsedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14D6B88
	public void .ctor() { }

	// RVA: 0x14D6D34
	internal void <InvokeLeftApplicationEvent>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
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
	private readonly bool <DisplayOnLoad>k__BackingField; // 0x7C
	private IosBannerAdListener _mBannerAdListener; // 0x80

	// Methods

	// RVA: 0x14D50FC
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D51B0
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5264
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D5318
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D53CC
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5480
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5534
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D55E8
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D569C
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D5750
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D5804
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D58B8
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D596C
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5A20
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5AD4
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5B88
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D5C3C
	public string get_AdUnitId() { }

	// RVA: 0x14D5C44
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14D5C4C
	public string get_PlacementName() { }

	// RVA: 0x14D5C54
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14D5C5C
	private bool get_DisplayOnLoad() { }

	// RVA: 0x14CB380
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

	// RVA: 0x14D60F0
	public void PauseAutoRefresh() { }

	// RVA: 0x14D6168
	public void ResumeAutoRefresh() { }

	// RVA: 0x14D61E0
	public void Load() { }

	// RVA: 0x14D637C
	public void DestroyAd() { }

	// RVA: 0x14D62F4
	public void SetPosition() { }

	// RVA: 0x14D636C
	public void ShowAd() { }

	// RVA: 0x14D6374
	public void HideAd() { }

	// RVA: 0x14D63DC
	internal void InvokeLoadedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D64C8
	internal void InvokeFailedLoadEvent(LevelPlayAdError error) { }

	// RVA: 0x14D65B4
	internal void InvokeClickedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D66A0
	internal void InvokeDisplayedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D678C
	internal void InvokeFailedDisplayEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }

	// RVA: 0x14D68CC
	internal void InvokeExpandedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D69B8
	internal void InvokeCollapsedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D6AA4
	internal void InvokeLeftApplicationEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14D5C64
	private static extern IntPtr BannerAdCreate(string adUnitId, string placementName, string description, int width, int height, int customWidth) { }

	// RVA: 0x14D60EC
	private static extern void BannerAdSetDelegate(IntPtr bannerAdView, IntPtr bannerAdListener) { }

	// RVA: 0x14D62F0
	private static extern void BannerAdLoad(IntPtr bannerAdView) { }

	// RVA: 0x14D63CC
	private static extern void BannerAdDestroy(IntPtr bannerAdView) { }

	// RVA: 0x14D63D0
	private static extern void BannerAdSetPosition(IntPtr bannerAdView, int position) { }

	// RVA: 0x14D63D4
	private static extern void BannerAdViewShow(IntPtr bannerAdView) { }

	// RVA: 0x14D63D8
	private static extern void BannerAdViewHide(IntPtr bannerAdView) { }

	// RVA: 0x14D6164
	private static extern void BannerAdPauseAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x14D61DC
	private static extern void BannerAdResumeAutoRefresh(IntPtr bannerAdView) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14D7630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D76D4
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D76E8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D77A8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14D77B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D7858
	public virtual void Invoke(IntPtr bannerPtr, string errorPtr) { }

	// RVA: 0x14D786C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14D792C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14D7938
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D79DC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D79F0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D7AB0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14D7ABC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D7B60
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D7B74
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D7C34
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14D7C40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D7CE4
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14D7CF8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14D7DC8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidExpandAdWithAdInfo
{
	// Methods

	// RVA: 0x14D7DD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D7E78
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D7E8C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D7F4C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCollapseAdWithAdInfo
{
	// Methods

	// RVA: 0x14D7F58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D7FFC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D8010
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D80D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidLeaveAppWithAdInfo
{
	// Methods

	// RVA: 0x14D80DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D8180
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14D8194
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14D8254
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14D5CFC
	public void .ctor(iOSBannerAd bannerAd) { }

	// RVA: 0x14D75CC
	public override void Dispose() { }

	// RVA: 0x14D74F4
	private static extern IntPtr LPMBannerAdViewDelegateCreate(IntPtr bannerAdPtr, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidClickWithAdInfo clicked, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidExpandAdWithAdInfo expanded, DidCollapseAdWithAdInfo collapsed, DidLeaveAppWithAdInfo leftApp) { }

	// RVA: 0x14D762C
	private static extern void LPMBannerAdViewDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14D6D70
	private static void LoadSuccess(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14D6E44
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14D6F30
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14D701C
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14D7108
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14D7230
	private static void Expanded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14D731C
	private static void Collapsed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14D7408
	private static void LeftApplication(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D9A48
	public void .ctor() { }

	// RVA: 0x14DA2E8
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14D9BE4
	public void .ctor() { }

	// RVA: 0x14DA384
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D9D0C
	public void .ctor() { }

	// RVA: 0x14DA420
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14D9E34
	public void .ctor() { }

	// RVA: 0x14DA4BC
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14D9FF8
	public void .ctor() { }

	// RVA: 0x14DA558
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DA120
	public void .ctor() { }

	// RVA: 0x14DA594
	internal void <InvokeClosedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DA248
	public void .ctor() { }

	// RVA: 0x14DA630
	internal void <InvokeOnAdInfoChangedEvent>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14D8260
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8314
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D83C8
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D847C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14D8530
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D85E4
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8698
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D874C
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14D8800
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D88B4
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8968
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8A1C
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8AD0
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8B84
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14D8C38
	public string get_AdUnitId() { }

	// RVA: 0x14D8C40
	public void .ctor(string adUnitId) { }

	// RVA: 0x14D94CC
	public void LoadAd() { }

	// RVA: 0x14D96A4
	public void ShowAd(string placementName) { }

	// RVA: 0x14D976C
	public bool IsAdReady() { }

	// RVA: 0x14D9808
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14D9878
	public override void Dispose() { }

	// RVA: 0x14D9928
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14D9AC4
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14D9BEC
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14D9D14
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14D9E3C
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14DA000
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14DA128
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14DA250
	protected override void Finalize() { }

	// RVA: 0x14D8D68
	private static extern IntPtr InterstitialAdCreate(string adUnitId) { }

	// RVA: 0x14D94C8
	private static extern void InterstitialAdSetDelegate(IntPtr interstitialAd, IntPtr interstitialAdListener) { }

	// RVA: 0x14D96A0
	private static extern void InterstitialAdLoadAd(IntPtr interstitialAd) { }

	// RVA: 0x14D9734
	private static extern void InterstitialAdShowAd(IntPtr interstitialAd, string placementName) { }

	// RVA: 0x14D97EC
	private static extern bool InterstitialAdIsAdReady(IntPtr interstitialAd) { }

	// RVA: 0x14D9840
	private static extern bool InterstitialAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14DAC04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB140
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14DB154
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DB214
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14DACA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB220
	public virtual void Invoke(IntPtr interstitialAd, string errorPtr) { }

	// RVA: 0x14DB234
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14DB2F4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14DAD4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB300
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14DB314
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DB3D4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14DADF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB3E0
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14DB3F4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14DB4C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14DAE94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB4D0
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14DB4E4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DB5A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14DAF38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB5B0
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14DB5C4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DB684
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14DAFDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DB690
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14DB6A4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DB764
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14D8F04
	internal void .ctor(IosInterstitialAd interstitialAd) { }

	// RVA: 0x14DB080
	private static extern IntPtr LPMInterstitialAdDelegateCreate(IntPtr interstitialAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14DB13C
	private static extern void LPMInterstitialAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14DA6CC
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DA788
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14DA844
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DA900
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DA9BC
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14DAA8C
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DAB48
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
public class IosLevelPlaySdk
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed; // 0x8

	// Methods

	// RVA: 0x14DB770
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14DB880
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14DB990
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14DBAA4
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14DBBB8
	private void Awake() { }

	// RVA: 0x14DBC44
	private static void .cctor() { }

	// RVA: 0x14DBC48
	public static void Initialize(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14DC1A0
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14DBF70
	private static string[] GetAdFormatArray(LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14DC094
	private static extern void LPMInitialize(string appKey, string userId, string[] adFormats) { }

	// RVA: 0x14DBF04
	private static extern void setPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14DC220
	private static extern void LPMSetPauseGame(bool pause) { }

	// RVA: 0x14DC224
	public void OnInitializationSuccess(string configuration) { }

	// RVA: 0x14DC2F4
	public void OnInitializationFailed(string error) { }

	// RVA: 0x14DC3C4
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

	// RVA: 0x14D8D3C
	protected void .ctor(bool usesCallbacks) { }

	// RVA: 0x14DC3CC
	public IntPtr get_NativePtr() { }

	// RVA: 0x14D8D9C
	protected void set_NativePtr(IntPtr value) { }

	// RVA: 0x318DB98
	protected static T Get(IntPtr ptr) { }

	// RVA: 0x14D98E4
	public virtual void Dispose() { }

	// RVA: 0x14D953C
	protected bool CheckDisposedAndLogError(string message) { }

	// RVA: 0x14DC3D4
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DDB48
	public void .ctor() { }

	// RVA: 0x14DE4C0
	internal void <InvokeLoadedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14DDC70
	public void .ctor() { }

	// RVA: 0x14DE55C
	internal void <InvokeFailedLoadEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DDD98
	public void .ctor() { }

	// RVA: 0x14DE5F8
	internal void <InvokeDisplayedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14DDF5C
	public void .ctor() { }

	// RVA: 0x14DE694
	internal void <InvokeFailedDisplayEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18
	public string rewardName; // 0x20
	public int rewardAmount; // 0x28

	// Methods

	// RVA: 0x14DE0A8
	public void .ctor() { }

	// RVA: 0x14DE6D0
	internal void <InvokeRewardedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DE1D0
	public void .ctor() { }

	// RVA: 0x14DE7B4
	internal void <InvokeClickedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DE2F8
	public void .ctor() { }

	// RVA: 0x14DE850
	internal void <InvokeClosedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14DE420
	public void .ctor() { }

	// RVA: 0x14DE8EC
	internal void <InvokeOnAdInfoChangedEvent>b__0(object _) { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14DC470
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DC524
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DC5D8
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14DC68C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14DC740
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DC7F4
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DC8A8
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14DC95C
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14DCA10
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14DCAC4
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14DCB78
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCC2C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCCE0
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCD94
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCE48
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCEFC
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DCFB0
	public string get_AdUnitId() { }

	// RVA: 0x14DCFB8
	public void .ctor(string adUnitId) { }

	// RVA: 0x14DD774
	public void LoadAd() { }

	// RVA: 0x14DD7E8
	public void ShowAd(string placementName) { }

	// RVA: 0x14DD8B0
	public bool IsAdReady() { }

	// RVA: 0x14DD94C
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14DD9BC
	public override void Dispose() { }

	// RVA: 0x14DDA28
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14DDB50
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14DDC78
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14DDDA0
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14DDF64
	internal void InvokeRewardedEvent(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14DE0B0
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14DE1D8
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14DE300
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14DE428
	protected override void Finalize() { }

	// RVA: 0x14DD0B4
	private static extern IntPtr RewardedAdCreate(string adUnitId) { }

	// RVA: 0x14DD770
	private static extern void RewardedAdSetDelegate(IntPtr rewardedAd, IntPtr rewardedAdListener) { }

	// RVA: 0x14DD7E4
	private static extern void RewardedAdLoadAd(IntPtr rewardedAd) { }

	// RVA: 0x14DD878
	private static extern void RewardedAdShowAd(IntPtr rewardedAd, string placementName) { }

	// RVA: 0x14DD930
	private static extern bool RewardedAdIsAdReady(IntPtr rewardedAd) { }

	// RVA: 0x14DD984
	private static extern bool RewardedAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14DEF98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DF594
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14DF5A8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DF668
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14DF03C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DF674
	public virtual void Invoke(IntPtr rewardedAd, string errorPtr) { }

	// RVA: 0x14DF688
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14DF748
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14DF0E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DF754
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14DF768
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DF828
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14DF184
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DF834
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14DF848
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14DF918
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidAdRewardedWithAdInfo
{
	// Methods

	// RVA: 0x14DF228
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DF924
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14DF938
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x14DFA30
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14DF2CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DFA3C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14DFA50
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DFB10
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14DF370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DFB1C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14DFB30
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DFBF0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14DF414
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14DFBFC
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14DFC10
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14DFCD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: com.unity3d.mediation
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

	// RVA: 0x14DD0E8
	internal void .ctor(IosRewardedAd rewardedAd) { }

	// RVA: 0x14DF4B8
	private static extern IntPtr LPMRewardedAdDelegateCreate(IntPtr rewardedAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidAdRewardedWithAdInfo rewarded, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14DF590
	private static extern void LPMRewardedAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14DE988
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DEA44
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14DEB00
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DEBBC
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14DEC8C
	private static void Rewarded(IntPtr ptr, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14DED64
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DEE20
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14DEEDC
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
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

// Namespace: com.unity3d.mediation
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
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
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
	public abstract string get_AdUnitId() { }

	// RVA: -1
	public abstract void LoadAd() { }

	// RVA: -1
	public abstract void ShowAd(string placementName) { }

	// RVA: -1
	public abstract bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
internal static class ThreadUtil
{
	// Fields
	internal static SynchronizationContext UnitySynchronizationContext; // 0x0

	// Methods

	// RVA: 0x14DFCDC
	private static void Init() { }

	// RVA: 0x14D9A50
	public static void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x14DFD3C
	public static void Send(SendOrPostCallback d, object state) { }

}

// Namespace: com.unity3d.mediation
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
	private readonly string <AdUnitId>k__BackingField; // 0x58
	private readonly LevelPlayAdSize <AdSize>k__BackingField; // 0x60
	private readonly LevelPlayAdSize <Size>k__BackingField; // 0x68
	private readonly string <PlacementName>k__BackingField; // 0x70

	// Methods

	// RVA: 0x14DFDB0
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

	// RVA: 0x14DFE10
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DFEC4
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14DFF78
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E002C
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E00E0
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0194
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0248
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E02FC
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E03B0
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E0464
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E0518
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E05CC
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0680
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0734
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E07E8
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E089C
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0950
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14E0958
	public void Load() { }

	// RVA: 0x14E095C
	public void DestroyAd() { }

	// RVA: 0x14E0960
	public void ShowAd() { }

	// RVA: 0x14E0964
	public void HideAd() { }

	// RVA: 0x14E0968
	public void PauseAutoRefresh() { }

	// RVA: 0x14E096C
	public void ResumeAutoRefresh() { }

	// RVA: 0x14E0970
	public void SetAutoRefresh(bool flag) { }

	// RVA: 0x14E0974
	public void Dispose() { }

	// RVA: 0x14E0978
	public string get_AdUnitId() { }

	// RVA: 0x14E0980
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14E0988
	public LevelPlayAdSize get_Size() { }

	// RVA: 0x14E0990
	public string get_PlacementName() { }

}

// Namespace: com.unity3d.mediation
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
	private readonly string <AdUnitId>k__BackingField; // 0x48

	// Methods

	// RVA: 0x14E0998
	public void Dispose() { }

	// RVA: 0x14E099C
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0A50
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0B04
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E0BB8
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E0C6C
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0D20
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0DD4
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0E88
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0F3C
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E0FF0
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E10A4
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E1158
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E120C
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E12C0
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1374
	public string get_AdUnitId() { }

	// RVA: 0x14E137C
	public void .ctor(string adUnitId) { }

	// RVA: 0x14E1384
	public void LoadAd() { }

	// RVA: 0x14E1388
	public void ShowAd(string placementName) { }

	// RVA: 0x14E138C
	public bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
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
	private readonly string <AdUnitId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x14E1394
	public void Dispose() { }

	// RVA: 0x14E1398
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E144C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1500
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E15B4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14E1668
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E171C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E17D0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E1884
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14E1938
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14E19EC
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14E1AA0
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1B54
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1C08
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1CBC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1D70
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1E24
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14E1ED8
	public string get_AdUnitId() { }

	// RVA: 0x14E1EE0
	public void .ctor(string adUnitId) { }

	// RVA: 0x14E1EE8
	public void LoadAd() { }

	// RVA: 0x14E1EEC
	public void ShowAd(string placementName) { }

	// RVA: 0x14E1EF0
	public bool IsAdReady() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=2715
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=6740
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=2715 9DB1F711DD2B735379E1147355FA6A9177D4C5002C1CF0B215876EC73D6A4C7F; // 0x0
	internal static readonly __StaticArrayInitTypeSize=6740 DAF287D10CCEDB815CCEB43CFAB7EEB80363E3DBAF1385D9C794A24A6B1DCDF9; // 0xA9B
}


