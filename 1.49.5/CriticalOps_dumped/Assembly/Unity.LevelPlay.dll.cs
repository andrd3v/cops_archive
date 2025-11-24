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

	// RVA: 0x14908DC
	private void .ctor() { }

	// RVA: 0x1490DCC
	public static IronSource get_Agent() { }

	// RVA: 0x1490EB4
	public static string pluginVersion() { }

	// RVA: 0x1490F30
	public static string unityVersion() { }

	// RVA: 0x1490FA0
	public static void setUnsupportedPlatform() { }

	// RVA: 0x1491024
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14910E0
	public void onApplicationPause(bool pause) { }

	// RVA: 0x1491198
	public string getAdvertiserId() { }

	// RVA: 0x1491250
	public void validateIntegration() { }

	// RVA: 0x1491308
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14913C0
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1491478
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x1491530
	public void setMetaData(string key, string value) { }

	// RVA: 0x14915F0
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14916B0
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x1491768
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x1491820
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14918E0
	public void SetPauseGame(bool pause) { }

	// RVA: 0x1491998
	public void setUserId(string userId) { }

	// RVA: 0x1491A50
	public void init(string appKey) { }

	// RVA: 0x1491B08
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x1491BC8
	public void loadRewardedVideo() { }

	// RVA: 0x1491C80
	public void showRewardedVideo() { }

	// RVA: 0x1491D38
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x1491DF0
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x1491EA8
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x1491F60
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x1492018
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14920D0
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x1492188
	public void loadInterstitial() { }

	// RVA: 0x1492240
	public void showInterstitial() { }

	// RVA: 0x14922F8
	public void showInterstitial(string placementName) { }

	// RVA: 0x14923B0
	public bool isInterstitialReady() { }

	// RVA: 0x1492468
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x1492520
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14925E0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14926B0
	public void destroyBanner() { }

	// RVA: 0x1492768
	public void displayBanner() { }

	// RVA: 0x1492820
	public void hideBanner() { }

	// RVA: 0x14928D8
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x1492990
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x1492A48
	public float getDeviceScreenWidth() { }

	// RVA: 0x1492B00
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x1492BB8
	public void setConsent(bool consent) { }

	// RVA: 0x1492C70
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x1492D28
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x1492DE0
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x1492EA0
	public void launchTestSuite() { }

	// RVA: 0x1492F58
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

	// RVA: 0x1492FC4
	public void .ctor(string json) { }

	// RVA: 0x14937DC
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

	// RVA: 0x1493CB4
	private void Awake() { }

	// RVA: 0x1493D68
	private static void add__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1493E38
	private static void remove__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1493F08
	public static void add_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1493FA8
	public static void remove_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494048
	public void onAdLoaded(string args) { }

	// RVA: 0x1494100
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14941D4
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14942A8
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1494348
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14943E8
	public void onAdLoadFailed(string description) { }

	// RVA: 0x149473C
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494810
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14948E4
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494984
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494A24
	public void onAdClicked(string args) { }

	// RVA: 0x1494ADC
	private static void add__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494BB0
	private static void remove__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494C84
	public static void add_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494D24
	public static void remove_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494DC4
	public void onAdScreenPresented(string args) { }

	// RVA: 0x1494E7C
	private static void add__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1494F50
	private static void remove__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1495024
	public static void add_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14950C4
	public static void remove_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1495164
	public void onAdScreenDismissed(string args) { }

	// RVA: 0x149521C
	private static void add__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14952F0
	private static void remove__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14953C4
	public static void add_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1495464
	public static void remove_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1495504
	public void onAdLeftApplication(string args) { }

	// RVA: 0x1494480
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1495600
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1495920
	public void .ctor() { }

}

// Namespace: 
public class IronSourceConfig
{
	// Fields
	private const string unsupportedPlatformStr = "Unsupported Platform";
	private static IronSourceConfig _instance; // 0x0

	// Methods

	// RVA: 0x1495928
	public static IronSourceConfig get_Instance() { }

	// RVA: 0x14959DC
	private static extern void CFSetLanguage(string language) { }

	// RVA: 0x1495A04
	private static extern void CFSetClientSideCallbacks(bool useClientSideCallbacks) { }

	// RVA: 0x1495A08
	private static extern void CFSetRewardedVideoCustomParams(string rewardedVideoCustomParams) { }

	// RVA: 0x1495A30
	public void setLanguage(string language) { }

	// RVA: 0x1495A5C
	public void setClientSideCallbacks(bool status) { }

	// RVA: 0x1495A64
	public void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<System.String,System.String> rewardedVideoCustomParams) { }

	// RVA: 0x14959D4
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

	// RVA: 0x1495A98
	public int getErrorCode() { }

	// RVA: 0x1495AA0
	public string getDescription() { }

	// RVA: 0x1495AA8
	public int getCode() { }

	// RVA: 0x14955BC
	public void .ctor(int errorCode, string errorDescription) { }

	// RVA: 0x1495AB0
	public override string ToString() { }

}

// Namespace: 
private sealed class ISUnityBackgroundCallback
{
	// Methods

	// RVA: 0x1495F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1498C0C
	public virtual void Invoke(string args) { }

	// RVA: 0x1498C20
	public virtual IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x1498C70
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

	// RVA: 0x1495BCC
	private static extern void RegisterCallback(ISUnityBackgroundCallback func) { }

	// RVA: 0x1495BE0
	public static void add_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x1495CB0
	public static void remove_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x1495D80
	private void Awake() { }

	// RVA: 0x1495B14
	public static void FireCallback(string args) { }

	// RVA: 0x1496040
	private static void add__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x1496104
	private static void remove__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14961C8
	public static void add_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14962EC
	public static void remove_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x1496410
	public void onSdkInitializationCompleted(string empty) { }

	// RVA: 0x1496478
	private static void add__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x149654C
	private static void remove__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x1496620
	public static void add_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14966C0
	public static void remove_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x1496760
	public void onSegmentReceived(string segmentName) { }

	// RVA: 0x14967DC
	private static void add__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14968B0
	private static void remove__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1496984
	public static void add_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1496A24
	public static void remove_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1496AC4
	public void onConsentViewDidFailToLoadWithError(string args) { }

	// RVA: 0x1496ED0
	private static void add__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1496FA4
	private static void remove__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1497078
	public static void add_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1497118
	public static void remove_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14971B8
	public void onConsentViewDidFailToShowWithError(string args) { }

	// RVA: 0x1497308
	private static void add__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14973DC
	private static void remove__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14974B0
	public static void add_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1497550
	public static void remove_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14975F0
	public void onConsentViewDidAccept(string consentViewType) { }

	// RVA: 0x149766C
	private static void add__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1497740
	private static void remove__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1497814
	public static void add_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14978B4
	public static void remove_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1497954
	public void onConsentViewDidDismiss(string consentViewType) { }

	// RVA: 0x14979D0
	private static void add__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497AA4
	private static void remove__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497B78
	public static void add_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497C18
	public static void remove_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497CB8
	public void onConsentViewDidLoadSuccess(string consentViewType) { }

	// RVA: 0x1497D34
	private static void add__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497E08
	private static void remove__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497EDC
	public static void add_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1497F7C
	public static void remove_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x149801C
	public void onConsentViewDidShowSuccess(string consentViewType) { }

	// RVA: 0x1496C14
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1498098
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1495FC4
	private static void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args) { }

	// RVA: 0x1498C04
	public void .ctor() { }

}

// Namespace: 
public class IronSourceEventsDispatcher
{
	// Fields
	private static IronSourceEventsDispatcher instance; // 0x0
	private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue; // 0x8

	// Methods

	// RVA: 0x1498C7C
	public static void executeAction(Action action) { }

	// RVA: 0x1498DD0
	private void Update() { }

	// RVA: 0x14991B0
	public void removeFromParent() { }

	// RVA: 0x14992C0
	public static void initialize() { }

	// RVA: 0x14994BC
	public static bool isCreated() { }

	// RVA: 0x1499588
	public void Awake() { }

	// RVA: 0x1499614
	public void OnDisable() { }

	// RVA: 0x149967C
	public void .ctor() { }

	// RVA: 0x1499684
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

	// RVA: 0x1499734
	public static string get_MOPUB() { }

}

// Namespace: 
public static class IronSourceAdUnits
{
	// Methods

	// RVA: 0x1499778
	public static string get_REWARDED_VIDEO() { }

	// RVA: 0x14997BC
	public static string get_INTERSTITIAL() { }

	// RVA: 0x1499800
	public static string get_OFFERWALL() { }

	// RVA: 0x1499844
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

	// RVA: 0x1499888
	private void .ctor() { }

	// RVA: 0x1499934
	public void .ctor(int width, int height) { }

	// RVA: 0x14999EC
	public void .ctor(string description) { }

	// RVA: 0x1499A88
	public void SetAdaptive(bool adaptive, int customWidth) { }

	// RVA: 0x1499B18
	public bool IsAdaptiveEnabled() { }

	// RVA: 0x1499B20
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x1499B28
	public ISContainerParams getBannerContainerParams() { }

	// RVA: 0x1499B30
	public void SetRespectAndroidCutouts(bool respectAndroidCutouts) { }

	// RVA: 0x1499B38
	public bool IsRespectAndroidCutoutsEnabled() { }

	// RVA: 0x1499B40
	public string get_Description() { }

	// RVA: 0x1499B48
	public int get_Width() { }

	// RVA: 0x1499B50
	public int get_Height() { }

	// RVA: 0x1499B58
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

	// RVA: 0x1499E3C
	public float get_Width() { }

	// RVA: 0x1499E44
	public void set_Width(float value) { }

	// RVA: 0x1499E4C
	public float get_Height() { }

	// RVA: 0x1499E54
	public void set_Height(float value) { }

	// RVA: 0x1499908
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

	// RVA: 0x149835C
	public void .ctor(string json) { }

	// RVA: 0x1499E5C
	public override string ToString() { }

}

// Namespace: 
public class IronSourceInitilizer
{
	// Methods

	// RVA: 0x149A4EC
	private static void Initilize() { }

	// RVA: 0x149AA68
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

	// RVA: 0x149AA70
	private void Awake() { }

	// RVA: 0x149AB24
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149ABF4
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149ACC4
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149AD64
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149AE04
	public void onAdReady(string args) { }

	// RVA: 0x149AEBC
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149AF90
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149B064
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149B104
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149B1A4
	public void onAdLoadFailed(string description) { }

	// RVA: 0x149B4F8
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149B5CC
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149B6A0
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149B740
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149B7E0
	public void onAdOpened(string args) { }

	// RVA: 0x149B898
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149B96C
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BA40
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BAE0
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BB80
	public void onAdClosed(string args) { }

	// RVA: 0x149BC38
	private static void add__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BD0C
	private static void remove__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BDE0
	public static void add_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BE80
	public static void remove_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149BF20
	public void onAdShowSucceeded(string args) { }

	// RVA: 0x149BFD8
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149C0AC
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149C180
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149C220
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149C2C0
	public void onAdShowFailed(string args) { }

	// RVA: 0x149C42C
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149C500
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149C5D4
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149C674
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149C714
	public void onAdClicked(string args) { }

	// RVA: 0x149B23C
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x149C7CC
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x149CA90
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

	// RVA: 0x149CA98
	public void .ctor() { }

	// RVA: 0x149CB1C
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

	// RVA: 0x14958C4
	public void .ctor(string placementName, string rewardName, int rewardAmount) { }

	// RVA: 0x149CBD8
	public string getRewardName() { }

	// RVA: 0x149CBE0
	public int getRewardAmount() { }

	// RVA: 0x149CBE8
	public string getPlacementName() { }

	// RVA: 0x149CBF0
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

	// RVA: 0x149CD18
	private void Awake() { }

	// RVA: 0x149CDCC
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149CE9C
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149CF6C
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149D00C
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x149D0AC
	public void onAdShowFailed(string args) { }

	// RVA: 0x149D4D4
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149D5A8
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149D67C
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149D71C
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149D7BC
	public void onAdOpened(string args) { }

	// RVA: 0x149D874
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149D948
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149DA1C
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149DABC
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149DB5C
	public void onAdClosed(string args) { }

	// RVA: 0x149DC14
	private static void add__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149DCE8
	private static void remove__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149DDBC
	public static void add_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149DE5C
	public static void remove_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149DEFC
	public void onAdRewarded(string args) { }

	// RVA: 0x149E32C
	private static void add__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149E400
	private static void remove__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149E4D4
	public static void add_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149E574
	public static void remove_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x149E614
	public void onAdClicked(string args) { }

	// RVA: 0x149E780
	private static void add__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149E854
	private static void remove__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149E928
	public static void add_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149E9C8
	public static void remove_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149EA68
	public void onAdAvailable(string args) { }

	// RVA: 0x149EB20
	private static void add__onAdUnavailableEvent(Action value) { }

	// RVA: 0x149EBE4
	private static void remove__onAdUnavailableEvent(Action value) { }

	// RVA: 0x149ECA8
	public static void add_onAdUnavailableEvent(Action value) { }

	// RVA: 0x149EDCC
	public static void remove_onAdUnavailableEvent(Action value) { }

	// RVA: 0x149EEF0
	public void onAdUnavailable() { }

	// RVA: 0x149EF58
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149F02C
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149F100
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149F1A0
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x149F240
	public void onAdLoadFailed(string description) { }

	// RVA: 0x149F2D8
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149F3AC
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149F480
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149F520
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149F5C0
	public void onAdReady(string adinfo) { }

	// RVA: 0x149D218
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x149E068
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x149F678
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

	// RVA: 0x149FC9C
	private static void .cctor() { }

	// RVA: 0x149FD08
	public void .ctor() { }

	// RVA: 0x149FD10
	internal string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> d) { }

	// RVA: 0x149FDD8
	internal string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

	// RVA: 0x149FE88
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

	// RVA: 0x149F680
	public void .ctor() { }

	// RVA: 0x149F724
	public void setCustom(string key, string value) { }

	// RVA: 0x149F790
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

	// RVA: 0x149FF88
	public static IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14A0244
	public static IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14A0508
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

	// RVA: 0x14A0CC4
	private static void .cctor() { }

	// RVA: 0x14A0D30
	public void .ctor() { }

	// RVA: 0x14A0D38
	internal void <.ctor>b__3_0(string <p0>) { }

}

// Namespace: 
public class IronSourceSegmentAndroid
{
	// Fields
	private System.Action<System.String> OnSegmentRecieved; // 0x20

	// Methods

	// RVA: 0x14A0510
	public void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14A05C4
	public void remove_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x14A0678
	public void .ctor() { }

	// RVA: 0x14A0CA8
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

	// RVA: 0x14A219C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A2240
	public virtual void Invoke(bool pause) { }

	// RVA: 0x14A2254
	public virtual IAsyncResult BeginInvoke(bool pause, AsyncCallback callback, object object) { }

	// RVA: 0x14A2310
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class iOSAgent
{
	// Methods

	// RVA: 0x14A0D3C
	private static extern void LPPSetWaterfallConfiguration(IOSWaterfallConfiguration configurationParams, AdFormat adFormat) { }

	// RVA: 0x14A0D40
	private static extern void CFSetPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14A0DAC
	private static extern string CFGetAdvertiserId() { }

	// RVA: 0x14A0DE0
	private static extern void CFValidateIntegration() { }

	// RVA: 0x14A0DE4
	private static extern void CFShouldTrackNetworkState(bool track) { }

	// RVA: 0x14A0DE8
	private static extern bool CFSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14A0E20
	private static extern void CFSetAdaptersDebug(bool enabled) { }

	// RVA: 0x14A0E24
	private static extern void CFSetMetaData(string key, string value) { }

	// RVA: 0x14A0E6C
	private static extern void CFSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x14A0F64
	private static extern string CFGetConversionValue() { }

	// RVA: 0x14A0F98
	private static extern void CFSetManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14A0F9C
	private static extern void CFSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14A0FE4
	private static extern void RegisterPauseGameFunction(bool pasue) { }

	// RVA: 0x14A0FE8
	private static extern void CFSetUserId(string userId) { }

	// RVA: 0x14A1010
	private static extern void CFInit(string appKey) { }

	// RVA: 0x14A1038
	private static extern void CFInitWithAdUnits(string appKey, string[] adUnits) { }

	// RVA: 0x14A1130
	private static extern void CFLoadRewardedVideo() { }

	// RVA: 0x14A1134
	private static extern void CFShowRewardedVideo() { }

	// RVA: 0x14A1138
	private static extern void CFShowRewardedVideoWithPlacementName(string placementName) { }

	// RVA: 0x14A1160
	private static extern bool CFIsRewardedVideoAvailable() { }

	// RVA: 0x14A117C
	private static extern bool CFIsRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14A11B4
	private static extern string CFGetPlacementInfo(string placementName) { }

	// RVA: 0x14A1200
	private static extern void CFSetRewardedVideoServerParameters(string jsonString) { }

	// RVA: 0x14A1228
	private static extern void CFClearRewardedVideoServerParameters() { }

	// RVA: 0x14A122C
	private static extern void CFLoadInterstitial() { }

	// RVA: 0x14A1230
	private static extern void CFShowInterstitial() { }

	// RVA: 0x14A1234
	private static extern void CFShowInterstitialWithPlacementName(string placementName) { }

	// RVA: 0x14A125C
	private static extern bool CFIsInterstitialReady() { }

	// RVA: 0x14A1278
	private static extern bool CFIsInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14A12B0
	private static extern void CFLoadBanner(string description, int width, int height, int position, string placementName, bool isAdaptive, float containerWidth, float containerHeight) { }

	// RVA: 0x14A1340
	private static extern void CFDestroyBanner() { }

	// RVA: 0x14A1344
	private static extern void CFDisplayBanner() { }

	// RVA: 0x14A1348
	private static extern void CFHideBanner() { }

	// RVA: 0x14A134C
	private static extern bool CFIsBannerPlacementCapped(string placementName) { }

	// RVA: 0x14A1384
	private static extern float CFIGetMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14A1388
	private static extern float CFIGetDeviceScreenWidth() { }

	// RVA: 0x14A138C
	private static extern void CFSetSegment(string json) { }

	// RVA: 0x14A13B4
	private static extern void CFSetConsent(bool consent) { }

	// RVA: 0x14A13B8
	private static extern void CFLoadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A13E0
	private static extern void CFShowConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A1408
	private static extern void CFSetAdRevenueData(string dataSource, string impressionData) { }

	// RVA: 0x14A1450
	private static extern void CFLaunchTestSuite() { }

	// RVA: 0x1490D68
	public void .ctor() { }

	// RVA: 0x14A1454
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14A15D8
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14A15DC
	public string getAdvertiserId() { }

	// RVA: 0x14A1610
	public void validateIntegration() { }

	// RVA: 0x14A1614
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14A161C
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14A1658
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14A1660
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14A166C
	public void setMetaData(string key, string value) { }

	// RVA: 0x14A16B8
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14A17BC
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14A17C4
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14A1810
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14A18C8
	public void setUserId(string userId) { }

	// RVA: 0x14A18F4
	public void init(string appKey) { }

	// RVA: 0x14A1A6C
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14A1BE4
	public void loadRewardedVideo() { }

	// RVA: 0x14A1BE8
	public void showRewardedVideo() { }

	// RVA: 0x14A1BEC
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14A1C18
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14A1C34
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14A1C70
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14A1E9C
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14A1ECC
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14A1ED0
	public void loadInterstitial() { }

	// RVA: 0x14A1ED4
	public void showInterstitial() { }

	// RVA: 0x14A1ED8
	public void showInterstitial(string placementName) { }

	// RVA: 0x14A1F04
	public bool isInterstitialReady() { }

	// RVA: 0x14A1F20
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14A1F5C
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14A1FB8
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14A2054
	public void destroyBanner() { }

	// RVA: 0x14A2058
	public void displayBanner() { }

	// RVA: 0x14A205C
	public void hideBanner() { }

	// RVA: 0x14A2060
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14A209C
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14A20A0
	public float getDeviceScreenWidth() { }

	// RVA: 0x14A20A4
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14A20E0
	public void setConsent(bool consent) { }

	// RVA: 0x14A20E8
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A2114
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A2140
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14A2198
	public void launchTestSuite() { }

}

// Namespace: 
public class UnsupportedPlatformAgent
{
	// Methods

	// RVA: 0x1490D70
	public void .ctor() { }

	// RVA: 0x14A231C
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14A2320
	public void start() { }

	// RVA: 0x14A2324
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14A2328
	public string getAdvertiserId() { }

	// RVA: 0x14A236C
	public void validateIntegration() { }

	// RVA: 0x14A2370
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14A2374
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x14A237C
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x14A2380
	public void setMetaData(string key, string value) { }

	// RVA: 0x14A2384
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x14A2388
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x14A2390
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14A2394
	public void setNetworkData(string networkKey, string networkDataJson) { }

	// RVA: 0x14A2398
	public void SetPauseGame(bool pause) { }

	// RVA: 0x14A239C
	public void setUserId(string userId) { }

	// RVA: 0x14A23A0
	public void init(string appKey) { }

	// RVA: 0x14A23A4
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14A23A8
	public void loadRewardedVideo() { }

	// RVA: 0x14A23AC
	public void showRewardedVideo() { }

	// RVA: 0x14A23B0
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14A23B4
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x14A23BC
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x14A23C4
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x14A23CC
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14A23D0
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14A23D4
	public void loadInterstitial() { }

	// RVA: 0x14A23D8
	public void showInterstitial() { }

	// RVA: 0x14A23DC
	public void showInterstitial(string placementName) { }

	// RVA: 0x14A23E0
	public bool isInterstitialReady() { }

	// RVA: 0x14A23E8
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14A23F0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14A23F4
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14A23F8
	public void destroyBanner() { }

	// RVA: 0x14A23FC
	public void displayBanner() { }

	// RVA: 0x14A2400
	public void hideBanner() { }

	// RVA: 0x14A2404
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14A240C
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14A2414
	public float getDeviceScreenWidth() { }

	// RVA: 0x14A241C
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14A2420
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14A2424
	public void setConsent(bool consent) { }

	// RVA: 0x14A2428
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A242C
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x14A2430
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x14A2434
	public void launchTestSuite() { }

}

// Namespace: 
public class WaterfallConfigurationBuilder
{
	// Fields
	private System.Nullable<System.Double> ceiling; // 0x10
	private System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14A2534
	internal void .ctor() { }

	// RVA: 0x14A2604
	public WaterfallConfigurationBuilder SetCeiling(Double ceiling) { }

	// RVA: 0x14A2688
	public WaterfallConfigurationBuilder SetFloor(Double floor) { }

	// RVA: 0x14A270C
	public WaterfallConfiguration Build() { }

}

// Namespace: 
public class WaterfallConfiguration
{
	// Fields
	private readonly System.Nullable<System.Double> ceiling; // 0x10
	private readonly System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x14A2478
	public System.Nullable<System.Double> get_Ceiling() { }

	// RVA: 0x14A2484
	public System.Nullable<System.Double> get_Floor() { }

	// RVA: 0x14A2490
	private void .ctor(System.Nullable<System.Double> ceiling, System.Nullable<System.Double> floor) { }

	// RVA: 0x14A24DC
	public static WaterfallConfigurationBuilder Builder() { }

	// RVA: 0x14A253C
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

	// RVA: 0x14A2790
	private static MonoScriptData Get() { }

	// RVA: 0x14A2894
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

	// RVA: 0x14A2B3C
	private void .ctor(string jsonString) { }

	// RVA: 0x14A289C
	public static object Parse(string jsonString) { }

	// RVA: 0x14A2BE4
	public void Dispose() { }

	// RVA: 0x14A2C20
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x14A34EC
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x14A2BBC
	private object ParseValue() { }

	// RVA: 0x14A35FC
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x14A3050
	private string ParseString() { }

	// RVA: 0x14A3708
	private object ParseNumber() { }

	// RVA: 0x14A3A54
	private void EatWhitespace() { }

	// RVA: 0x14A3B4C
	private Char get_PeekChar() { }

	// RVA: 0x14A383C
	private Char get_NextChar() { }

	// RVA: 0x14A38C8
	private string get_NextWord() { }

	// RVA: 0x14A2DAC
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x14A3BD8
	private void .ctor() { }

	// RVA: 0x14A2A68
	public static string Serialize(object obj) { }

	// RVA: 0x14A3C50
	private void SerializeValue(object value) { }

	// RVA: 0x14A442C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x14A40E4
	private void SerializeArray(IList anArray) { }

	// RVA: 0x14A3E28
	private void SerializeString(string str) { }

	// RVA: 0x14A48B0
	private void SerializeOther(object value) { }

}

// Namespace: IronSourceJSON
public static class Json
{
	// Methods

	// RVA: 0x1493674
	public static object Deserialize(string json) { }

	// RVA: 0x1495A94
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

	// RVA: 0x1493680
	public static void Log(object message) { }

	// RVA: 0x149A90C
	public static void LogWarning(object message) { }

	// RVA: 0x14A0B4C
	public static void LogError(object message) { }

	// RVA: 0x1499050
	public static void LogException(Exception exception) { }

	// RVA: 0x14A4A9C
	public static void LogAssertion(object message) { }

	// RVA: 0x14A4BFC
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

	// RVA: 0x14A591C
	private static void .cctor() { }

	// RVA: 0x14A5988
	public void .ctor() { }

	// RVA: 0x14A5990
	internal void <.cctor>b__12_0(LevelPlayConfiguration configuration) { }

	// RVA: 0x14A5A34
	internal void <.cctor>b__12_1(LevelPlayInitError error) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlay
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> InitSuccessReceived; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived; // 0x8

	// Methods

	// RVA: 0x14A4D58
	private static void add_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A4E68
	private static void remove_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A4F78
	private static void add_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A508C
	private static void remove_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A51A0
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A52B8
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A53CC
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A54E4
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A55F8
	private static void .cctor() { }

	// RVA: 0x14A5738
	public static void Init(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14A57B4
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14A5914
	public void .ctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdDisplayInfoError
{
	// Fields
	private LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField; // 0x10
	private LevelPlayAdError <LevelPlayError>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14A5AD8
	public LevelPlayAdInfo get_DisplayLevelPlayAdInfo() { }

	// RVA: 0x14A5AE0
	private void set_DisplayLevelPlayAdInfo(LevelPlayAdInfo value) { }

	// RVA: 0x14A5AE8
	public LevelPlayAdError get_LevelPlayError() { }

	// RVA: 0x14A5AF0
	private void set_LevelPlayError(LevelPlayAdError value) { }

	// RVA: 0x14A5AF8
	public void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

	// RVA: 0x14A5B48
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

	// RVA: 0x14A5BEC
	public int get_ErrorCode() { }

	// RVA: 0x14A5BF4
	public string get_ErrorMessage() { }

	// RVA: 0x14A5BFC
	public string get_AdUnitId() { }

	// RVA: 0x14A5C04
	internal void .ctor(string json) { }

	// RVA: 0x14A5EC8
	public void .ctor(string adUnitId, int errorCode, string errorMessage) { }

	// RVA: 0x14A5F20
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

	// RVA: 0x14A5FB0
	internal void .ctor(string json) { }

	// RVA: 0x14A6A3C
	private static LevelPlayAdSize GetAdSize(string adSizeJson) { }

	// RVA: 0x14A6D84
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

	// RVA: 0x14A7190
	private void .ctor(string description) { }

	// RVA: 0x14A6D34
	internal void .ctor(string description, int width, int height) { }

	// RVA: 0x14A71CC
	public static LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x14A7270
	public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x14A7308
	public string get_Description() { }

	// RVA: 0x14A7310
	public int get_Width() { }

	// RVA: 0x14A7318
	public int get_Height() { }

	// RVA: 0x14A7320
	public int get_CustomWidth() { }

	// RVA: 0x14A7328
	public override string ToString() { }

	// RVA: 0x14A73E0
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

	// RVA: 0x14A7590
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7644
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A76F8
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A77AC
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A7860
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7914
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A79C8
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7A7C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7B30
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A7BE4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A7C98
	public void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7D4C
	public void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7E00
	public void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7EB4
	public void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A7F68
	public void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A801C
	public void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A80D0
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

	// RVA: 0x14A88D0
	public void LoadAd() { }

	// RVA: 0x14A8988
	public void DestroyAd() { }

	// RVA: 0x14A8A40
	public void ShowAd() { }

	// RVA: 0x14A8AF8
	public void HideAd() { }

	// RVA: 0x14A8BB0
	public string GetAdUnitId() { }

	// RVA: 0x14A8C68
	public LevelPlayAdSize GetAdSize() { }

	// RVA: 0x14A8D20
	public LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x14A8DD8
	public string GetPlacementName() { }

	// RVA: 0x14A8E90
	public void PauseAutoRefresh() { }

	// RVA: 0x14A8F48
	public void ResumeAutoRefresh() { }

	// RVA: 0x14A837C
	private void SetupCallbacks() { }

	// RVA: 0x14A9000
	public void Dispose() { }

	// RVA: 0x14A90C0
	private void <SetupCallbacks>b__37_0(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14A90E4
	private void <SetupCallbacks>b__37_1(object sender, LevelPlayAdError args) { }

	// RVA: 0x14A9108
	private void <SetupCallbacks>b__37_2(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14A912C
	private void <SetupCallbacks>b__37_3(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14A9150
	private void <SetupCallbacks>b__37_4(object sender, LevelPlayAdDisplayInfoError args) { }

	// RVA: 0x14A9174
	private void <SetupCallbacks>b__37_5(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14A9198
	private void <SetupCallbacks>b__37_6(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14A91BC
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

	// RVA: 0x14A91E0
	public bool get_IsAdQualityEnabled() { }

	// RVA: 0x14A91E8
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInitError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14A945C
	public int get_ErrorCode() { }

	// RVA: 0x14A9464
	public string get_ErrorMessage() { }

	// RVA: 0x14A946C
	internal void .ctor(string json) { }

	// RVA: 0x14A96D8
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

	// RVA: 0x14A9768
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A981C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A98D0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A9984
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A9A38
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9AEC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9BA0
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9C54
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9D08
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9DBC
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A9E70
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A9F24
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A9FD8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA08C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA140
	public string get_AdUnitId() { }

	// RVA: 0x14AA1F8
	public void .ctor(string adUnitId) { }

	// RVA: 0x14AA704
	internal void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

	// RVA: 0x14AA738
	public void LoadAd() { }

	// RVA: 0x14AA7F0
	public void DestroyAd() { }

	// RVA: 0x14AA958
	public void ShowAd(string placementName) { }

	// RVA: 0x14AAA10
	public bool IsAdReady() { }

	// RVA: 0x14AAAC8
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14AA8A4
	public void Dispose() { }

	// RVA: 0x14AAAD0
	private void <.ctor>b__24_0(LevelPlayAdInfo info) { }

	// RVA: 0x14AAAEC
	private void <.ctor>b__24_1(LevelPlayAdError error) { }

	// RVA: 0x14AAB08
	private void <.ctor>b__24_2(LevelPlayAdInfo info) { }

	// RVA: 0x14AAB24
	private void <.ctor>b__24_3(LevelPlayAdInfo info) { }

	// RVA: 0x14AAB40
	private void <.ctor>b__24_4(LevelPlayAdInfo info) { }

	// RVA: 0x14AAB5C
	private void <.ctor>b__24_5(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x14AAB78
	private void <.ctor>b__24_6(LevelPlayAdInfo info) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayReward
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	private readonly int <Amount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14AAB94
	public string get_Name() { }

	// RVA: 0x14AAB9C
	public int get_Amount() { }

	// RVA: 0x14AABA4
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

	// RVA: 0x14AABEC
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AACA0
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AAD54
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AAE08
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AAEBC
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AAF70
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB024
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AB0D8
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AB18C
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AB240
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AB2F4
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB3A8
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB45C
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB510
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB5C4
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB678
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AB72C
	public string get_AdUnitId() { }

	// RVA: 0x14AB7E4
	public void .ctor(string adUnitId) { }

	// RVA: 0x14ABD9C
	internal void .ctor(IPlatformRewardedAd platformRewardedAd) { }

	// RVA: 0x14ABDD0
	public void LoadAd() { }

	// RVA: 0x14ABE88
	public void ShowAd(string placementName) { }

	// RVA: 0x14ABF40
	public void DestroyAd() { }

	// RVA: 0x14AC0A8
	public bool IsAdReady() { }

	// RVA: 0x14AC160
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14ABFF4
	public void Dispose() { }

	// RVA: 0x14AC168
	private void <.ctor>b__27_0(LevelPlayAdInfo info) { }

	// RVA: 0x14AC184
	private void <.ctor>b__27_1(LevelPlayAdError error) { }

	// RVA: 0x14AC1A0
	private void <.ctor>b__27_2(LevelPlayAdInfo info) { }

	// RVA: 0x14AC1BC
	private void <.ctor>b__27_3(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x14AC1D8
	private void <.ctor>b__27_4(LevelPlayAdInfo info, LevelPlayReward reward) { }

	// RVA: 0x14AC1F4
	private void <.ctor>b__27_5(LevelPlayAdInfo info) { }

	// RVA: 0x14AC210
	private void <.ctor>b__27_6(LevelPlayAdInfo info) { }

	// RVA: 0x14AC22C
	private void <.ctor>b__27_7(LevelPlayAdInfo info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x14ACD2C
	public void .ctor() { }

	// RVA: 0x14ADDAC
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x14ACFBC
	public void .ctor() { }

	// RVA: 0x14AE118
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

	// RVA: 0x14AC248
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC2FC
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC3B0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AC464
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AC518
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC5CC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC680
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC734
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC7E8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC89C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AC950
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14ACA04
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14ACAB8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ACB6C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ACC20
	public string get_AdUnitId() { }

	// RVA: 0x14ACC28
	internal void .ctor(string adUnitId) { }

	// RVA: 0x14ACD34
	public void LoadAd() { }

	// RVA: 0x14ACE88
	public void ShowAd(string placementName) { }

	// RVA: 0x14ACFC4
	public bool IsAdReady() { }

	// RVA: 0x14AD0D0
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14AD3B8
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14AD444
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14AD4D0
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14AD55C
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14AD668
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14AD6F4
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14AD780
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14AD80C
	private void Dispose(bool disposing) { }

	// RVA: 0x14AD8C4
	public void Dispose() { }

	// RVA: 0x14AD964
	protected override void Finalize() { }

	// RVA: 0x14ACE24
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x14ADA38
	private void <LoadAd>b__35_0(object state) { }

	// RVA: 0x14ADBAC
	private void <IsAdReady>b__37_0(object state) { }

	// RVA: 0x14ADD58
	private void <Dispose>b__46_0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x14AEEE8
	public void .ctor() { }

	// RVA: 0x14B0048
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x14AF178
	public void .ctor() { }

	// RVA: 0x14B03B4
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

	// RVA: 0x14AE29C
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE350
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE404
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AE4B8
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AE56C
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE620
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE6D4
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AE788
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AE83C
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AE8F0
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AE9A4
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEA58
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEB0C
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEBC0
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEC74
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AED28
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEDDC
	public string get_AdUnitId() { }

	// RVA: 0x14AEDE4
	internal void .ctor(string adUnitId) { }

	// RVA: 0x14AEEF0
	public void LoadAd() { }

	// RVA: 0x14AF044
	public void ShowAd(string placementName) { }

	// RVA: 0x14AF180
	public bool IsAdReady() { }

	// RVA: 0x14AF28C
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14AF574
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14AF600
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14AF68C
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14AF718
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14AF824
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14AF904
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14AF990
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14AFA1C
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14AFAA8
	private void Dispose(bool disposing) { }

	// RVA: 0x14AFB60
	public void Dispose() { }

	// RVA: 0x14AFC00
	protected override void Finalize() { }

	// RVA: 0x14AEFE0
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x14AFCD4
	private void <LoadAd>b__38_0(object state) { }

	// RVA: 0x14AFE48
	private void <IsAdReady>b__40_0(object state) { }

	// RVA: 0x14AFFF4
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

	// RVA: 0x14B061C
	public void .ctor() { }

	// RVA: 0x14B0BC0
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14B0708
	public void .ctor() { }

	// RVA: 0x14B0C88
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B07F4
	public void .ctor() { }

	// RVA: 0x14B0D54
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

	// RVA: 0x14B08F4
	public void .ctor() { }

	// RVA: 0x14B0E20
	internal void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B09E0
	public void .ctor() { }

	// RVA: 0x14B0EE4
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B0ACC
	public void .ctor() { }

	// RVA: 0x14B0FB0
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B0BB8
	public void .ctor() { }

	// RVA: 0x14B107C
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityInterstitialAdListener
{
	// Fields
	private const string k_AndroidInterstitialListenerName = "com.ironsource.unity.androidbridge.IUnityInterstitialAdListener";
	private readonly IUnityInterstitialAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x14AE088
	public void .ctor(IUnityInterstitialAdListener listener) { }

	// RVA: 0x14B0538
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14B0624
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14B0710
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14B07FC
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14B08FC
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14B09E8
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14B0AD4
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B18D8
	public void .ctor() { }

	// RVA: 0x14B18E0
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B122C
	public void .ctor() { }

	// RVA: 0x14B19AC
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14B1318
	public void .ctor() { }

	// RVA: 0x14B1A74
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B1404
	public void .ctor() { }

	// RVA: 0x14B1B40
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

	// RVA: 0x14B1504
	public void .ctor() { }

	// RVA: 0x14B1C0C
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

	// RVA: 0x14B1614
	public void .ctor() { }

	// RVA: 0x14B1CD0
	internal void <onAdRewarded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B1700
	public void .ctor() { }

	// RVA: 0x14B1D9C
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B17EC
	public void .ctor() { }

	// RVA: 0x14B1E68
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityRewardedAdListener
{
	// Fields
	private const string k_AndroidRewardedAdListenerName = "com.ironsource.unity.androidbridge.IUnityRewardedAdListener";
	private readonly IUnityRewardedAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x14B0324
	public void .ctor(IUnityRewardedAdListener listener) { }

	// RVA: 0x14B1148
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14B1234
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14B1320
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14B140C
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14B150C
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14B161C
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14B1708
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14B17F4
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass48_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B32F8
	public void .ctor() { }

	// RVA: 0x14B39C8
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass49_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdError error; // 0x18

	// Methods

	// RVA: 0x14B33E4
	public void .ctor() { }

	// RVA: 0x14B3A04
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass50_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B34D0
	public void .ctor() { }

	// RVA: 0x14B3A40
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass51_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B35BC
	public void .ctor() { }

	// RVA: 0x14B3A7C
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14B36FC
	public void .ctor() { }

	// RVA: 0x14B3AB8
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B37E8
	public void .ctor() { }

	// RVA: 0x14B3AF4
	internal void <InvokeExpandedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B38D4
	public void .ctor() { }

	// RVA: 0x14B3B30
	internal void <InvokeCollapsedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14B39C0
	public void .ctor() { }

	// RVA: 0x14B3B6C
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

	// RVA: 0x14B1F34
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B1FE8
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B209C
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B2150
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B2204
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B22B8
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B236C
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B2420
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B24D4
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B2588
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B263C
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B26F0
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B27A4
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B2858
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B290C
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B29C0
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B2A74
	public string get_AdUnitId() { }

	// RVA: 0x14B2A7C
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14B2A84
	public string get_PlacementName() { }

	// RVA: 0x14B2A8C
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14B2A94
	private bool get_DisplayOnLoad() { }

	// RVA: 0x14A81B8
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

	// RVA: 0x14B2F28
	public void PauseAutoRefresh() { }

	// RVA: 0x14B2FA0
	public void ResumeAutoRefresh() { }

	// RVA: 0x14B3018
	public void Load() { }

	// RVA: 0x14B31B4
	public void DestroyAd() { }

	// RVA: 0x14B312C
	public void SetPosition() { }

	// RVA: 0x14B31A4
	public void ShowAd() { }

	// RVA: 0x14B31AC
	public void HideAd() { }

	// RVA: 0x14B3214
	internal void InvokeLoadedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B3300
	internal void InvokeFailedLoadEvent(LevelPlayAdError error) { }

	// RVA: 0x14B33EC
	internal void InvokeClickedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B34D8
	internal void InvokeDisplayedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B35C4
	internal void InvokeFailedDisplayEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }

	// RVA: 0x14B3704
	internal void InvokeExpandedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B37F0
	internal void InvokeCollapsedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B38DC
	internal void InvokeLeftApplicationEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14B2A9C
	private static extern IntPtr BannerAdCreate(string adUnitId, string placementName, string description, int width, int height, int customWidth) { }

	// RVA: 0x14B2F24
	private static extern void BannerAdSetDelegate(IntPtr bannerAdView, IntPtr bannerAdListener) { }

	// RVA: 0x14B3128
	private static extern void BannerAdLoad(IntPtr bannerAdView) { }

	// RVA: 0x14B3204
	private static extern void BannerAdDestroy(IntPtr bannerAdView) { }

	// RVA: 0x14B3208
	private static extern void BannerAdSetPosition(IntPtr bannerAdView, int position) { }

	// RVA: 0x14B320C
	private static extern void BannerAdViewShow(IntPtr bannerAdView) { }

	// RVA: 0x14B3210
	private static extern void BannerAdViewHide(IntPtr bannerAdView) { }

	// RVA: 0x14B2F9C
	private static extern void BannerAdPauseAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x14B3014
	private static extern void BannerAdResumeAutoRefresh(IntPtr bannerAdView) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14B4468
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B450C
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B4520
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B45E0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14B45EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4690
	public virtual void Invoke(IntPtr bannerPtr, string errorPtr) { }

	// RVA: 0x14B46A4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14B4764
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14B4770
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4814
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B4828
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B48E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14B48F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4998
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B49AC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B4A6C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14B4A78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4B1C
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14B4B30
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14B4C00
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidExpandAdWithAdInfo
{
	// Methods

	// RVA: 0x14B4C0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4CB0
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B4CC4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B4D84
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCollapseAdWithAdInfo
{
	// Methods

	// RVA: 0x14B4D90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4E34
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B4E48
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B4F08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidLeaveAppWithAdInfo
{
	// Methods

	// RVA: 0x14B4F14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B4FB8
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14B4FCC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B508C
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

	// RVA: 0x14B2B34
	public void .ctor(iOSBannerAd bannerAd) { }

	// RVA: 0x14B4404
	public override void Dispose() { }

	// RVA: 0x14B432C
	private static extern IntPtr LPMBannerAdViewDelegateCreate(IntPtr bannerAdPtr, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidClickWithAdInfo clicked, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidExpandAdWithAdInfo expanded, DidCollapseAdWithAdInfo collapsed, DidLeaveAppWithAdInfo leftApp) { }

	// RVA: 0x14B4464
	private static extern void LPMBannerAdViewDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14B3BA8
	private static void LoadSuccess(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B3C7C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14B3D68
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B3E54
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B3F40
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14B4068
	private static void Expanded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B4154
	private static void Collapsed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B4240
	private static void LeftApplication(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B6880
	public void .ctor() { }

	// RVA: 0x14B7120
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14B6A1C
	public void .ctor() { }

	// RVA: 0x14B71BC
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B6B44
	public void .ctor() { }

	// RVA: 0x14B7258
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B6C6C
	public void .ctor() { }

	// RVA: 0x14B72F4
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14B6E30
	public void .ctor() { }

	// RVA: 0x14B7390
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B6F58
	public void .ctor() { }

	// RVA: 0x14B73CC
	internal void <InvokeClosedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14B7080
	public void .ctor() { }

	// RVA: 0x14B7468
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

	// RVA: 0x14B5098
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B514C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B5200
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B52B4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B5368
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B541C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B54D0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B5584
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B5638
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B56EC
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B57A0
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B5854
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B5908
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B59BC
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B5A70
	public string get_AdUnitId() { }

	// RVA: 0x14B5A78
	public void .ctor(string adUnitId) { }

	// RVA: 0x14B6304
	public void LoadAd() { }

	// RVA: 0x14B64DC
	public void ShowAd(string placementName) { }

	// RVA: 0x14B65A4
	public bool IsAdReady() { }

	// RVA: 0x14B6640
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14B66B0
	public override void Dispose() { }

	// RVA: 0x14B6760
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14B68FC
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14B6A24
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14B6B4C
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14B6C74
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14B6E38
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14B6F60
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14B7088
	protected override void Finalize() { }

	// RVA: 0x14B5BA0
	private static extern IntPtr InterstitialAdCreate(string adUnitId) { }

	// RVA: 0x14B6300
	private static extern void InterstitialAdSetDelegate(IntPtr interstitialAd, IntPtr interstitialAdListener) { }

	// RVA: 0x14B64D8
	private static extern void InterstitialAdLoadAd(IntPtr interstitialAd) { }

	// RVA: 0x14B656C
	private static extern void InterstitialAdShowAd(IntPtr interstitialAd, string placementName) { }

	// RVA: 0x14B6624
	private static extern bool InterstitialAdIsAdReady(IntPtr interstitialAd) { }

	// RVA: 0x14B6678
	private static extern bool InterstitialAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14B7A3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B7F78
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14B7F8C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B804C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14B7AE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B8058
	public virtual void Invoke(IntPtr interstitialAd, string errorPtr) { }

	// RVA: 0x14B806C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14B812C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14B7B84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B8138
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14B814C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B820C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14B7C28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B8218
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14B822C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14B82FC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14B7CCC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B8308
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14B831C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B83DC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14B7D70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B83E8
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14B83FC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B84BC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14B7E14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B84C8
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14B84DC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14B859C
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

	// RVA: 0x14B5D3C
	internal void .ctor(IosInterstitialAd interstitialAd) { }

	// RVA: 0x14B7EB8
	private static extern IntPtr LPMInterstitialAdDelegateCreate(IntPtr interstitialAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14B7F74
	private static extern void LPMInterstitialAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14B7504
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B75C0
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14B767C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B7738
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B77F4
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14B78C4
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14B7980
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
public class IosLevelPlaySdk
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed; // 0x8

	// Methods

	// RVA: 0x14B85A8
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14B86B8
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14B87C8
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14B88DC
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14B89F0
	private void Awake() { }

	// RVA: 0x14B8A7C
	private static void .cctor() { }

	// RVA: 0x14B8A80
	public static void Initialize(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14B8FD8
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14B8DA8
	private static string[] GetAdFormatArray(LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14B8ECC
	private static extern void LPMInitialize(string appKey, string userId, string[] adFormats) { }

	// RVA: 0x14B8D3C
	private static extern void setPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14B9058
	private static extern void LPMSetPauseGame(bool pause) { }

	// RVA: 0x14B905C
	public void OnInitializationSuccess(string configuration) { }

	// RVA: 0x14B912C
	public void OnInitializationFailed(string error) { }

	// RVA: 0x14B91FC
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

	// RVA: 0x14B5B74
	protected void .ctor(bool usesCallbacks) { }

	// RVA: 0x14B9204
	public IntPtr get_NativePtr() { }

	// RVA: 0x14B5BD4
	protected void set_NativePtr(IntPtr value) { }

	// RVA: 0x316B894
	protected static T Get(IntPtr ptr) { }

	// RVA: 0x14B671C
	public virtual void Dispose() { }

	// RVA: 0x14B6374
	protected bool CheckDisposedAndLogError(string message) { }

	// RVA: 0x14B920C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14BA980
	public void .ctor() { }

	// RVA: 0x14BB2F8
	internal void <InvokeLoadedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14BAAA8
	public void .ctor() { }

	// RVA: 0x14BB394
	internal void <InvokeFailedLoadEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14BABD0
	public void .ctor() { }

	// RVA: 0x14BB430
	internal void <InvokeDisplayedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14BAD94
	public void .ctor() { }

	// RVA: 0x14BB4CC
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

	// RVA: 0x14BAEE0
	public void .ctor() { }

	// RVA: 0x14BB508
	internal void <InvokeRewardedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14BB008
	public void .ctor() { }

	// RVA: 0x14BB5EC
	internal void <InvokeClickedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14BB130
	public void .ctor() { }

	// RVA: 0x14BB688
	internal void <InvokeClosedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14BB258
	public void .ctor() { }

	// RVA: 0x14BB724
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

	// RVA: 0x14B92A8
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B935C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9410
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B94C4
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14B9578
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B962C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B96E0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B9794
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14B9848
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14B98FC
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14B99B0
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9A64
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9B18
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9BCC
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9C80
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9D34
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14B9DE8
	public string get_AdUnitId() { }

	// RVA: 0x14B9DF0
	public void .ctor(string adUnitId) { }

	// RVA: 0x14BA5AC
	public void LoadAd() { }

	// RVA: 0x14BA620
	public void ShowAd(string placementName) { }

	// RVA: 0x14BA6E8
	public bool IsAdReady() { }

	// RVA: 0x14BA784
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14BA7F4
	public override void Dispose() { }

	// RVA: 0x14BA860
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14BA988
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14BAAB0
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14BABD8
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14BAD9C
	internal void InvokeRewardedEvent(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14BAEE8
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14BB010
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14BB138
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14BB260
	protected override void Finalize() { }

	// RVA: 0x14B9EEC
	private static extern IntPtr RewardedAdCreate(string adUnitId) { }

	// RVA: 0x14BA5A8
	private static extern void RewardedAdSetDelegate(IntPtr rewardedAd, IntPtr rewardedAdListener) { }

	// RVA: 0x14BA61C
	private static extern void RewardedAdLoadAd(IntPtr rewardedAd) { }

	// RVA: 0x14BA6B0
	private static extern void RewardedAdShowAd(IntPtr rewardedAd, string placementName) { }

	// RVA: 0x14BA768
	private static extern bool RewardedAdIsAdReady(IntPtr rewardedAd) { }

	// RVA: 0x14BA7BC
	private static extern bool RewardedAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14BBDD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC3CC
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14BC3E0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14BC4A0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14BBE74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC4AC
	public virtual void Invoke(IntPtr rewardedAd, string errorPtr) { }

	// RVA: 0x14BC4C0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14BC580
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14BBF18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC58C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14BC5A0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14BC660
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14BBFBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC66C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14BC680
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14BC750
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidAdRewardedWithAdInfo
{
	// Methods

	// RVA: 0x14BC060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC75C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14BC770
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x14BC868
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14BC104
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC874
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14BC888
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14BC948
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14BC1A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC954
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14BC968
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14BCA28
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14BC24C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BCA34
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14BCA48
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14BCB08
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

	// RVA: 0x14B9F20
	internal void .ctor(IosRewardedAd rewardedAd) { }

	// RVA: 0x14BC2F0
	private static extern IntPtr LPMRewardedAdDelegateCreate(IntPtr rewardedAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidAdRewardedWithAdInfo rewarded, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14BC3C8
	private static extern void LPMRewardedAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14BB7C0
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14BB87C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14BB938
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14BB9F4
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14BBAC4
	private static void Rewarded(IntPtr ptr, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14BBB9C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14BBC58
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14BBD14
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

	// RVA: 0x14BCB14
	private static void Init() { }

	// RVA: 0x14B6888
	public static void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x14BCB74
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

	// RVA: 0x14BCBE8
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

	// RVA: 0x14BCC48
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BCCFC
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BCDB0
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BCE64
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BCF18
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BCFCC
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD080
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD134
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD1E8
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BD29C
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BD350
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD404
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD4B8
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD56C
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD620
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD6D4
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD788
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14BD790
	public void Load() { }

	// RVA: 0x14BD794
	public void DestroyAd() { }

	// RVA: 0x14BD798
	public void ShowAd() { }

	// RVA: 0x14BD79C
	public void HideAd() { }

	// RVA: 0x14BD7A0
	public void PauseAutoRefresh() { }

	// RVA: 0x14BD7A4
	public void ResumeAutoRefresh() { }

	// RVA: 0x14BD7A8
	public void SetAutoRefresh(bool flag) { }

	// RVA: 0x14BD7AC
	public void Dispose() { }

	// RVA: 0x14BD7B0
	public string get_AdUnitId() { }

	// RVA: 0x14BD7B8
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14BD7C0
	public LevelPlayAdSize get_Size() { }

	// RVA: 0x14BD7C8
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

	// RVA: 0x14BD7D0
	public void Dispose() { }

	// RVA: 0x14BD7D4
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD888
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BD93C
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BD9F0
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BDAA4
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDB58
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDC0C
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDCC0
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDD74
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDE28
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BDEDC
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BDF90
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BE044
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE0F8
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE1AC
	public string get_AdUnitId() { }

	// RVA: 0x14BE1B4
	public void .ctor(string adUnitId) { }

	// RVA: 0x14BE1BC
	public void LoadAd() { }

	// RVA: 0x14BE1C0
	public void ShowAd(string placementName) { }

	// RVA: 0x14BE1C4
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

	// RVA: 0x14BE1CC
	public void Dispose() { }

	// RVA: 0x14BE1D0
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE284
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE338
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BE3EC
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14BE4A0
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE554
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE608
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BE6BC
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14BE770
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14BE824
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14BE8D8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BE98C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BEA40
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BEAF4
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BEBA8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BEC5C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14BED10
	public string get_AdUnitId() { }

	// RVA: 0x14BED18
	public void .ctor(string adUnitId) { }

	// RVA: 0x14BED20
	public void LoadAd() { }

	// RVA: 0x14BED24
	public void ShowAd(string placementName) { }

	// RVA: 0x14BED28
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


