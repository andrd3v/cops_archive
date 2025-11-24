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

	// RVA: 0x14815AC
	private void .ctor() { }

	// RVA: 0x1481A9C
	public static IronSource get_Agent() { }

	// RVA: 0x1481B84
	public static string pluginVersion() { }

	// RVA: 0x1481C00
	public static string unityVersion() { }

	// RVA: 0x1481C70
	public static void setUnsupportedPlatform() { }

	// RVA: 0x1481CF4
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x1481DB0
	public void onApplicationPause(bool pause) { }

	// RVA: 0x1481E68
	public string getAdvertiserId() { }

	// RVA: 0x1481F20
	public void validateIntegration() { }

	// RVA: 0x1481FD8
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x1482090
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1482148
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x1482200
	public void setMetaData(string key, string value) { }

	// RVA: 0x14822C0
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x1482380
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x1482438
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x14824F0
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14825B0
	public void SetPauseGame(bool pause) { }

	// RVA: 0x1482668
	public void setUserId(string userId) { }

	// RVA: 0x1482720
	public void init(string appKey) { }

	// RVA: 0x14827D8
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x1482898
	public void loadRewardedVideo() { }

	// RVA: 0x1482950
	public void showRewardedVideo() { }

	// RVA: 0x1482A08
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x1482AC0
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x1482B78
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x1482C30
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x1482CE8
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x1482DA0
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x1482E58
	public void loadInterstitial() { }

	// RVA: 0x1482F10
	public void showInterstitial() { }

	// RVA: 0x1482FC8
	public void showInterstitial(string placementName) { }

	// RVA: 0x1483080
	public bool isInterstitialReady() { }

	// RVA: 0x1483138
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14831F0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14832B0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x1483380
	public void destroyBanner() { }

	// RVA: 0x1483438
	public void displayBanner() { }

	// RVA: 0x14834F0
	public void hideBanner() { }

	// RVA: 0x14835A8
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x1483660
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x1483718
	public float getDeviceScreenWidth() { }

	// RVA: 0x14837D0
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x1483888
	public void setConsent(bool consent) { }

	// RVA: 0x1483940
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14839F8
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x1483AB0
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x1483B70
	public void launchTestSuite() { }

	// RVA: 0x1483C28
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

	// RVA: 0x1483C94
	public void .ctor(string json) { }

	// RVA: 0x14844AC
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

	// RVA: 0x1484984
	private void Awake() { }

	// RVA: 0x1484A38
	private static void add__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1484B08
	private static void remove__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1484BD8
	public static void add_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1484C78
	public static void remove_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1484D18
	public void onAdLoaded(string args) { }

	// RVA: 0x1484DD0
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1484EA4
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1484F78
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1485018
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14850B8
	public void onAdLoadFailed(string description) { }

	// RVA: 0x148540C
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14854E0
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14855B4
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485654
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14856F4
	public void onAdClicked(string args) { }

	// RVA: 0x14857AC
	private static void add__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485880
	private static void remove__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485954
	public static void add_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14859F4
	public static void remove_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485A94
	public void onAdScreenPresented(string args) { }

	// RVA: 0x1485B4C
	private static void add__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485C20
	private static void remove__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485CF4
	public static void add_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485D94
	public static void remove_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485E34
	public void onAdScreenDismissed(string args) { }

	// RVA: 0x1485EEC
	private static void add__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1485FC0
	private static void remove__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1486094
	public static void add_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1486134
	public static void remove_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14861D4
	public void onAdLeftApplication(string args) { }

	// RVA: 0x1485150
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x14862D0
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14865F0
	public void .ctor() { }

}

// Namespace: 
public class IronSourceConfig
{
	// Fields
	private const string unsupportedPlatformStr = "Unsupported Platform";
	private static IronSourceConfig _instance; // 0x0

	// Methods

	// RVA: 0x14865F8
	public static IronSourceConfig get_Instance() { }

	// RVA: 0x14866AC
	private static extern void CFSetLanguage(string language) { }

	// RVA: 0x14866D4
	private static extern void CFSetClientSideCallbacks(bool useClientSideCallbacks) { }

	// RVA: 0x14866D8
	private static extern void CFSetRewardedVideoCustomParams(string rewardedVideoCustomParams) { }

	// RVA: 0x1486700
	public void setLanguage(string language) { }

	// RVA: 0x148672C
	public void setClientSideCallbacks(bool status) { }

	// RVA: 0x1486734
	public void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<System.String,System.String> rewardedVideoCustomParams) { }

	// RVA: 0x14866A4
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

	// RVA: 0x1486768
	public int getErrorCode() { }

	// RVA: 0x1486770
	public string getDescription() { }

	// RVA: 0x1486778
	public int getCode() { }

	// RVA: 0x148628C
	public void .ctor(int errorCode, string errorDescription) { }

	// RVA: 0x1486780
	public override string ToString() { }

}

// Namespace: 
private sealed class ISUnityBackgroundCallback
{
	// Methods

	// RVA: 0x1486BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14898DC
	public virtual void Invoke(string args) { }

	// RVA: 0x14898F0
	public virtual IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x1489940
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

	// RVA: 0x148689C
	private static extern void RegisterCallback(ISUnityBackgroundCallback func) { }

	// RVA: 0x14868B0
	public static void add_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x1486980
	public static void remove_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x1486A50
	private void Awake() { }

	// RVA: 0x14867E4
	public static void FireCallback(string args) { }

	// RVA: 0x1486D10
	private static void add__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x1486DD4
	private static void remove__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x1486E98
	public static void add_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x1486FBC
	public static void remove_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x14870E0
	public void onSdkInitializationCompleted(string empty) { }

	// RVA: 0x1487148
	private static void add__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x148721C
	private static void remove__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x14872F0
	public static void add_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x1487390
	public static void remove_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x1487430
	public void onSegmentReceived(string segmentName) { }

	// RVA: 0x14874AC
	private static void add__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487580
	private static void remove__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487654
	public static void add_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14876F4
	public static void remove_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487794
	public void onConsentViewDidFailToLoadWithError(string args) { }

	// RVA: 0x1487BA0
	private static void add__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487C74
	private static void remove__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487D48
	public static void add_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487DE8
	public static void remove_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1487E88
	public void onConsentViewDidFailToShowWithError(string args) { }

	// RVA: 0x1487FD8
	private static void add__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14880AC
	private static void remove__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1488180
	public static void add_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1488220
	public static void remove_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14882C0
	public void onConsentViewDidAccept(string consentViewType) { }

	// RVA: 0x148833C
	private static void add__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1488410
	private static void remove__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x14884E4
	public static void add_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1488584
	public static void remove_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1488624
	public void onConsentViewDidDismiss(string consentViewType) { }

	// RVA: 0x14886A0
	private static void add__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488774
	private static void remove__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488848
	public static void add_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14888E8
	public static void remove_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488988
	public void onConsentViewDidLoadSuccess(string consentViewType) { }

	// RVA: 0x1488A04
	private static void add__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488AD8
	private static void remove__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488BAC
	public static void add_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488C4C
	public static void remove_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1488CEC
	public void onConsentViewDidShowSuccess(string consentViewType) { }

	// RVA: 0x14878E4
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1488D68
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1486C94
	private static void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args) { }

	// RVA: 0x14898D4
	public void .ctor() { }

}

// Namespace: 
public class IronSourceEventsDispatcher
{
	// Fields
	private static IronSourceEventsDispatcher instance; // 0x0
	private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue; // 0x8

	// Methods

	// RVA: 0x148994C
	public static void executeAction(Action action) { }

	// RVA: 0x1489AA0
	private void Update() { }

	// RVA: 0x1489E80
	public void removeFromParent() { }

	// RVA: 0x1489F90
	public static void initialize() { }

	// RVA: 0x148A18C
	public static bool isCreated() { }

	// RVA: 0x148A258
	public void Awake() { }

	// RVA: 0x148A2E4
	public void OnDisable() { }

	// RVA: 0x148A34C
	public void .ctor() { }

	// RVA: 0x148A354
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

	// RVA: 0x148A404
	public static string get_MOPUB() { }

}

// Namespace: 
public static class IronSourceAdUnits
{
	// Methods

	// RVA: 0x148A448
	public static string get_REWARDED_VIDEO() { }

	// RVA: 0x148A48C
	public static string get_INTERSTITIAL() { }

	// RVA: 0x148A4D0
	public static string get_OFFERWALL() { }

	// RVA: 0x148A514
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

	// RVA: 0x148A558
	private void .ctor() { }

	// RVA: 0x148A604
	public void .ctor(int width, int height) { }

	// RVA: 0x148A6BC
	public void .ctor(string description) { }

	// RVA: 0x148A758
	public void SetAdaptive(bool adaptive, int customWidth) { }

	// RVA: 0x148A7E8
	public bool IsAdaptiveEnabled() { }

	// RVA: 0x148A7F0
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x148A7F8
	public ISContainerParams getBannerContainerParams() { }

	// RVA: 0x148A800
	public void SetRespectAndroidCutouts(bool respectAndroidCutouts) { }

	// RVA: 0x148A808
	public bool IsRespectAndroidCutoutsEnabled() { }

	// RVA: 0x148A810
	public string get_Description() { }

	// RVA: 0x148A818
	public int get_Width() { }

	// RVA: 0x148A820
	public int get_Height() { }

	// RVA: 0x148A828
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

	// RVA: 0x148AB0C
	public float get_Width() { }

	// RVA: 0x148AB14
	public void set_Width(float value) { }

	// RVA: 0x148AB1C
	public float get_Height() { }

	// RVA: 0x148AB24
	public void set_Height(float value) { }

	// RVA: 0x148A5D8
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

	// RVA: 0x148902C
	public void .ctor(string json) { }

	// RVA: 0x148AB2C
	public override string ToString() { }

}

// Namespace: 
public class IronSourceInitilizer
{
	// Methods

	// RVA: 0x148B1BC
	private static void Initilize() { }

	// RVA: 0x148B738
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

	// RVA: 0x148B740
	private void Awake() { }

	// RVA: 0x148B7F4
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148B8C4
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148B994
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148BA34
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148BAD4
	public void onAdReady(string args) { }

	// RVA: 0x148BB8C
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148BC60
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148BD34
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148BDD4
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148BE74
	public void onAdLoadFailed(string description) { }

	// RVA: 0x148C1C8
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C29C
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C370
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C410
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C4B0
	public void onAdOpened(string args) { }

	// RVA: 0x148C568
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C63C
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C710
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C7B0
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C850
	public void onAdClosed(string args) { }

	// RVA: 0x148C908
	private static void add__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148C9DC
	private static void remove__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148CAB0
	public static void add_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148CB50
	public static void remove_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148CBF0
	public void onAdShowSucceeded(string args) { }

	// RVA: 0x148CCA8
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148CD7C
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148CE50
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148CEF0
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148CF90
	public void onAdShowFailed(string args) { }

	// RVA: 0x148D0FC
	private static void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148D1D0
	private static void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148D2A4
	public static void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148D344
	public static void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148D3E4
	public void onAdClicked(string args) { }

	// RVA: 0x148BF0C
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x148D49C
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x148D760
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

	// RVA: 0x148D768
	public void .ctor() { }

	// RVA: 0x148D7EC
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

	// RVA: 0x1486594
	public void .ctor(string placementName, string rewardName, int rewardAmount) { }

	// RVA: 0x148D8A8
	public string getRewardName() { }

	// RVA: 0x148D8B0
	public int getRewardAmount() { }

	// RVA: 0x148D8B8
	public string getPlacementName() { }

	// RVA: 0x148D8C0
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

	// RVA: 0x148D9E8
	private void Awake() { }

	// RVA: 0x148DA9C
	private static void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148DB6C
	private static void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148DC3C
	public static void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148DCDC
	public static void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x148DD7C
	public void onAdShowFailed(string args) { }

	// RVA: 0x148E1A4
	private static void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E278
	private static void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E34C
	public static void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E3EC
	public static void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E48C
	public void onAdOpened(string args) { }

	// RVA: 0x148E544
	private static void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E618
	private static void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E6EC
	public static void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E78C
	public static void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148E82C
	public void onAdClosed(string args) { }

	// RVA: 0x148E8E4
	private static void add__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148E9B8
	private static void remove__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148EA8C
	public static void add_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148EB2C
	public static void remove_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148EBCC
	public void onAdRewarded(string args) { }

	// RVA: 0x148EFFC
	private static void add__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148F0D0
	private static void remove__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148F1A4
	public static void add_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148F244
	public static void remove_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x148F2E4
	public void onAdClicked(string args) { }

	// RVA: 0x148F450
	private static void add__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148F524
	private static void remove__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148F5F8
	public static void add_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148F698
	public static void remove_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x148F738
	public void onAdAvailable(string args) { }

	// RVA: 0x148F7F0
	private static void add__onAdUnavailableEvent(Action value) { }

	// RVA: 0x148F8B4
	private static void remove__onAdUnavailableEvent(Action value) { }

	// RVA: 0x148F978
	public static void add_onAdUnavailableEvent(Action value) { }

	// RVA: 0x148FA9C
	public static void remove_onAdUnavailableEvent(Action value) { }

	// RVA: 0x148FBC0
	public void onAdUnavailable() { }

	// RVA: 0x148FC28
	private static void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148FCFC
	private static void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148FDD0
	public static void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148FE70
	public static void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x148FF10
	public void onAdLoadFailed(string description) { }

	// RVA: 0x148FFA8
	private static void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x149007C
	private static void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1490150
	public static void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14901F0
	public static void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1490290
	public void onAdReady(string adinfo) { }

	// RVA: 0x148DEE8
	private IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x148ED38
	private IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1490348
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

	// RVA: 0x149096C
	private static void .cctor() { }

	// RVA: 0x14909D8
	public void .ctor() { }

	// RVA: 0x14909E0
	internal string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> d) { }

	// RVA: 0x1490AA8
	internal string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

	// RVA: 0x1490B58
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

	// RVA: 0x1490350
	public void .ctor() { }

	// RVA: 0x14903F4
	public void setCustom(string key, string value) { }

	// RVA: 0x1490460
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

	// RVA: 0x1490C58
	public static IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1490F14
	public static IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x14911D8
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

	// RVA: 0x1491994
	private static void .cctor() { }

	// RVA: 0x1491A00
	public void .ctor() { }

	// RVA: 0x1491A08
	internal void <.ctor>b__3_0(string <p0>) { }

}

// Namespace: 
public class IronSourceSegmentAndroid
{
	// Fields
	private System.Action<System.String> OnSegmentRecieved; // 0x20

	// Methods

	// RVA: 0x14911E0
	public void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x1491294
	public void remove_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x1491348
	public void .ctor() { }

	// RVA: 0x1491978
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

	// RVA: 0x1492E6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1492F10
	public virtual void Invoke(bool pause) { }

	// RVA: 0x1492F24
	public virtual IAsyncResult BeginInvoke(bool pause, AsyncCallback callback, object object) { }

	// RVA: 0x1492FE0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class iOSAgent
{
	// Methods

	// RVA: 0x1491A0C
	private static extern void LPPSetWaterfallConfiguration(IOSWaterfallConfiguration configurationParams, AdFormat adFormat) { }

	// RVA: 0x1491A10
	private static extern void CFSetPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x1491A7C
	private static extern string CFGetAdvertiserId() { }

	// RVA: 0x1491AB0
	private static extern void CFValidateIntegration() { }

	// RVA: 0x1491AB4
	private static extern void CFShouldTrackNetworkState(bool track) { }

	// RVA: 0x1491AB8
	private static extern bool CFSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1491AF0
	private static extern void CFSetAdaptersDebug(bool enabled) { }

	// RVA: 0x1491AF4
	private static extern void CFSetMetaData(string key, string value) { }

	// RVA: 0x1491B3C
	private static extern void CFSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x1491C34
	private static extern string CFGetConversionValue() { }

	// RVA: 0x1491C68
	private static extern void CFSetManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x1491C6C
	private static extern void CFSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x1491CB4
	private static extern void RegisterPauseGameFunction(bool pasue) { }

	// RVA: 0x1491CB8
	private static extern void CFSetUserId(string userId) { }

	// RVA: 0x1491CE0
	private static extern void CFInit(string appKey) { }

	// RVA: 0x1491D08
	private static extern void CFInitWithAdUnits(string appKey, string[] adUnits) { }

	// RVA: 0x1491E00
	private static extern void CFLoadRewardedVideo() { }

	// RVA: 0x1491E04
	private static extern void CFShowRewardedVideo() { }

	// RVA: 0x1491E08
	private static extern void CFShowRewardedVideoWithPlacementName(string placementName) { }

	// RVA: 0x1491E30
	private static extern bool CFIsRewardedVideoAvailable() { }

	// RVA: 0x1491E4C
	private static extern bool CFIsRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x1491E84
	private static extern string CFGetPlacementInfo(string placementName) { }

	// RVA: 0x1491ED0
	private static extern void CFSetRewardedVideoServerParameters(string jsonString) { }

	// RVA: 0x1491EF8
	private static extern void CFClearRewardedVideoServerParameters() { }

	// RVA: 0x1491EFC
	private static extern void CFLoadInterstitial() { }

	// RVA: 0x1491F00
	private static extern void CFShowInterstitial() { }

	// RVA: 0x1491F04
	private static extern void CFShowInterstitialWithPlacementName(string placementName) { }

	// RVA: 0x1491F2C
	private static extern bool CFIsInterstitialReady() { }

	// RVA: 0x1491F48
	private static extern bool CFIsInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x1491F80
	private static extern void CFLoadBanner(string description, int width, int height, int position, string placementName, bool isAdaptive, float containerWidth, float containerHeight) { }

	// RVA: 0x1492010
	private static extern void CFDestroyBanner() { }

	// RVA: 0x1492014
	private static extern void CFDisplayBanner() { }

	// RVA: 0x1492018
	private static extern void CFHideBanner() { }

	// RVA: 0x149201C
	private static extern bool CFIsBannerPlacementCapped(string placementName) { }

	// RVA: 0x1492054
	private static extern float CFIGetMaximalAdaptiveHeight(float width) { }

	// RVA: 0x1492058
	private static extern float CFIGetDeviceScreenWidth() { }

	// RVA: 0x149205C
	private static extern void CFSetSegment(string json) { }

	// RVA: 0x1492084
	private static extern void CFSetConsent(bool consent) { }

	// RVA: 0x1492088
	private static extern void CFLoadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14920B0
	private static extern void CFShowConsentViewWithType(string consentViewType) { }

	// RVA: 0x14920D8
	private static extern void CFSetAdRevenueData(string dataSource, string impressionData) { }

	// RVA: 0x1492120
	private static extern void CFLaunchTestSuite() { }

	// RVA: 0x1481A38
	public void .ctor() { }

	// RVA: 0x1492124
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x14922A8
	public void onApplicationPause(bool pause) { }

	// RVA: 0x14922AC
	public string getAdvertiserId() { }

	// RVA: 0x14922E0
	public void validateIntegration() { }

	// RVA: 0x14922E4
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x14922EC
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x1492328
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x1492330
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x149233C
	public void setMetaData(string key, string value) { }

	// RVA: 0x1492388
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x149248C
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x1492494
	public void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x14924E0
	public void SetPauseGame(bool pause) { }

	// RVA: 0x1492598
	public void setUserId(string userId) { }

	// RVA: 0x14925C4
	public void init(string appKey) { }

	// RVA: 0x149273C
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x14928B4
	public void loadRewardedVideo() { }

	// RVA: 0x14928B8
	public void showRewardedVideo() { }

	// RVA: 0x14928BC
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x14928E8
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x1492904
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x1492940
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x1492B6C
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x1492B9C
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x1492BA0
	public void loadInterstitial() { }

	// RVA: 0x1492BA4
	public void showInterstitial() { }

	// RVA: 0x1492BA8
	public void showInterstitial(string placementName) { }

	// RVA: 0x1492BD4
	public bool isInterstitialReady() { }

	// RVA: 0x1492BF0
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x1492C2C
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x1492C88
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x1492D24
	public void destroyBanner() { }

	// RVA: 0x1492D28
	public void displayBanner() { }

	// RVA: 0x1492D2C
	public void hideBanner() { }

	// RVA: 0x1492D30
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x1492D6C
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x1492D70
	public float getDeviceScreenWidth() { }

	// RVA: 0x1492D74
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x1492DB0
	public void setConsent(bool consent) { }

	// RVA: 0x1492DB8
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x1492DE4
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x1492E10
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x1492E68
	public void launchTestSuite() { }

}

// Namespace: 
public class UnsupportedPlatformAgent
{
	// Methods

	// RVA: 0x1481A40
	public void .ctor() { }

	// RVA: 0x1492FEC
	public void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x1492FF0
	public void start() { }

	// RVA: 0x1492FF4
	public void onApplicationPause(bool pause) { }

	// RVA: 0x1492FF8
	public string getAdvertiserId() { }

	// RVA: 0x149303C
	public void validateIntegration() { }

	// RVA: 0x1493040
	public void shouldTrackNetworkState(bool track) { }

	// RVA: 0x1493044
	public bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x149304C
	public void setAdaptersDebug(bool enabled) { }

	// RVA: 0x1493050
	public void setMetaData(string key, string value) { }

	// RVA: 0x1493054
	public void setMetaData(string key, string[] values) { }

	// RVA: 0x1493058
	public System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x1493060
	public void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x1493064
	public void setNetworkData(string networkKey, string networkDataJson) { }

	// RVA: 0x1493068
	public void SetPauseGame(bool pause) { }

	// RVA: 0x149306C
	public void setUserId(string userId) { }

	// RVA: 0x1493070
	public void init(string appKey) { }

	// RVA: 0x1493074
	public void init(string appKey, string[] adUnits) { }

	// RVA: 0x1493078
	public void loadRewardedVideo() { }

	// RVA: 0x149307C
	public void showRewardedVideo() { }

	// RVA: 0x1493080
	public void showRewardedVideo(string placementName) { }

	// RVA: 0x1493084
	public bool isRewardedVideoAvailable() { }

	// RVA: 0x149308C
	public bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x1493094
	public IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x149309C
	public void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x14930A0
	public void clearRewardedVideoServerParams() { }

	// RVA: 0x14930A4
	public void loadInterstitial() { }

	// RVA: 0x14930A8
	public void showInterstitial() { }

	// RVA: 0x14930AC
	public void showInterstitial(string placementName) { }

	// RVA: 0x14930B0
	public bool isInterstitialReady() { }

	// RVA: 0x14930B8
	public bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x14930C0
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x14930C4
	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x14930C8
	public void destroyBanner() { }

	// RVA: 0x14930CC
	public void displayBanner() { }

	// RVA: 0x14930D0
	public void hideBanner() { }

	// RVA: 0x14930D4
	public bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x14930DC
	public float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x14930E4
	public float getDeviceScreenWidth() { }

	// RVA: 0x14930EC
	public void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x14930F0
	public void setSegment(IronSourceSegment segment) { }

	// RVA: 0x14930F4
	public void setConsent(bool consent) { }

	// RVA: 0x14930F8
	public void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x14930FC
	public void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x1493100
	public void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x1493104
	public void launchTestSuite() { }

}

// Namespace: 
public class WaterfallConfigurationBuilder
{
	// Fields
	private System.Nullable<System.Double> ceiling; // 0x10
	private System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x1493204
	internal void .ctor() { }

	// RVA: 0x14932D4
	public WaterfallConfigurationBuilder SetCeiling(Double ceiling) { }

	// RVA: 0x1493358
	public WaterfallConfigurationBuilder SetFloor(Double floor) { }

	// RVA: 0x14933DC
	public WaterfallConfiguration Build() { }

}

// Namespace: 
public class WaterfallConfiguration
{
	// Fields
	private readonly System.Nullable<System.Double> ceiling; // 0x10
	private readonly System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x1493148
	public System.Nullable<System.Double> get_Ceiling() { }

	// RVA: 0x1493154
	public System.Nullable<System.Double> get_Floor() { }

	// RVA: 0x1493160
	private void .ctor(System.Nullable<System.Double> ceiling, System.Nullable<System.Double> floor) { }

	// RVA: 0x14931AC
	public static WaterfallConfigurationBuilder Builder() { }

	// RVA: 0x149320C
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

	// RVA: 0x1493460
	private static MonoScriptData Get() { }

	// RVA: 0x1493564
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

	// RVA: 0x149380C
	private void .ctor(string jsonString) { }

	// RVA: 0x149356C
	public static object Parse(string jsonString) { }

	// RVA: 0x14938B4
	public void Dispose() { }

	// RVA: 0x14938F0
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x14941BC
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x149388C
	private object ParseValue() { }

	// RVA: 0x14942CC
	private object ParseByToken(TOKEN token) { }

	// RVA: 0x1493D20
	private string ParseString() { }

	// RVA: 0x14943D8
	private object ParseNumber() { }

	// RVA: 0x1494724
	private void EatWhitespace() { }

	// RVA: 0x149481C
	private Char get_PeekChar() { }

	// RVA: 0x149450C
	private Char get_NextChar() { }

	// RVA: 0x1494598
	private string get_NextWord() { }

	// RVA: 0x1493A7C
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x14948A8
	private void .ctor() { }

	// RVA: 0x1493738
	public static string Serialize(object obj) { }

	// RVA: 0x1494920
	private void SerializeValue(object value) { }

	// RVA: 0x14950FC
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x1494DB4
	private void SerializeArray(IList anArray) { }

	// RVA: 0x1494AF8
	private void SerializeString(string str) { }

	// RVA: 0x1495580
	private void SerializeOther(object value) { }

}

// Namespace: IronSourceJSON
public static class Json
{
	// Methods

	// RVA: 0x1484344
	public static object Deserialize(string json) { }

	// RVA: 0x1486764
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

	// RVA: 0x1484350
	public static void Log(object message) { }

	// RVA: 0x148B5DC
	public static void LogWarning(object message) { }

	// RVA: 0x149181C
	public static void LogError(object message) { }

	// RVA: 0x1489D20
	public static void LogException(Exception exception) { }

	// RVA: 0x149576C
	public static void LogAssertion(object message) { }

	// RVA: 0x14958CC
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

	// RVA: 0x14965EC
	private static void .cctor() { }

	// RVA: 0x1496658
	public void .ctor() { }

	// RVA: 0x1496660
	internal void <.cctor>b__12_0(LevelPlayConfiguration configuration) { }

	// RVA: 0x1496704
	internal void <.cctor>b__12_1(LevelPlayInitError error) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlay
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> InitSuccessReceived; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived; // 0x8

	// Methods

	// RVA: 0x1495A28
	private static void add_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1495B38
	private static void remove_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1495C48
	private static void add_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1495D5C
	private static void remove_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1495E70
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1495F88
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x149609C
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14961B4
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14962C8
	private static void .cctor() { }

	// RVA: 0x1496408
	public static void Init(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x1496484
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14965E4
	public void .ctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdDisplayInfoError
{
	// Fields
	private LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField; // 0x10
	private LevelPlayAdError <LevelPlayError>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14967A8
	public LevelPlayAdInfo get_DisplayLevelPlayAdInfo() { }

	// RVA: 0x14967B0
	private void set_DisplayLevelPlayAdInfo(LevelPlayAdInfo value) { }

	// RVA: 0x14967B8
	public LevelPlayAdError get_LevelPlayError() { }

	// RVA: 0x14967C0
	private void set_LevelPlayError(LevelPlayAdError value) { }

	// RVA: 0x14967C8
	public void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

	// RVA: 0x1496818
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

	// RVA: 0x14968BC
	public int get_ErrorCode() { }

	// RVA: 0x14968C4
	public string get_ErrorMessage() { }

	// RVA: 0x14968CC
	public string get_AdUnitId() { }

	// RVA: 0x14968D4
	internal void .ctor(string json) { }

	// RVA: 0x1496B98
	public void .ctor(string adUnitId, int errorCode, string errorMessage) { }

	// RVA: 0x1496BF0
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

	// RVA: 0x1496C80
	internal void .ctor(string json) { }

	// RVA: 0x149770C
	private static LevelPlayAdSize GetAdSize(string adSizeJson) { }

	// RVA: 0x1497A54
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

	// RVA: 0x1497E60
	private void .ctor(string description) { }

	// RVA: 0x1497A04
	internal void .ctor(string description, int width, int height) { }

	// RVA: 0x1497E9C
	public static LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x1497F40
	public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x1497FD8
	public string get_Description() { }

	// RVA: 0x1497FE0
	public int get_Width() { }

	// RVA: 0x1497FE8
	public int get_Height() { }

	// RVA: 0x1497FF0
	public int get_CustomWidth() { }

	// RVA: 0x1497FF8
	public override string ToString() { }

	// RVA: 0x14980B0
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

	// RVA: 0x1498260
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498314
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14983C8
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149847C
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1498530
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14985E4
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498698
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149874C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498800
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14988B4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1498968
	public void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498A1C
	public void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498AD0
	public void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498B84
	public void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498C38
	public void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498CEC
	public void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1498DA0
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

	// RVA: 0x14995A0
	public void LoadAd() { }

	// RVA: 0x1499658
	public void DestroyAd() { }

	// RVA: 0x1499710
	public void ShowAd() { }

	// RVA: 0x14997C8
	public void HideAd() { }

	// RVA: 0x1499880
	public string GetAdUnitId() { }

	// RVA: 0x1499938
	public LevelPlayAdSize GetAdSize() { }

	// RVA: 0x14999F0
	public LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x1499AA8
	public string GetPlacementName() { }

	// RVA: 0x1499B60
	public void PauseAutoRefresh() { }

	// RVA: 0x1499C18
	public void ResumeAutoRefresh() { }

	// RVA: 0x149904C
	private void SetupCallbacks() { }

	// RVA: 0x1499CD0
	public void Dispose() { }

	// RVA: 0x1499D90
	private void <SetupCallbacks>b__37_0(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1499DB4
	private void <SetupCallbacks>b__37_1(object sender, LevelPlayAdError args) { }

	// RVA: 0x1499DD8
	private void <SetupCallbacks>b__37_2(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1499DFC
	private void <SetupCallbacks>b__37_3(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1499E20
	private void <SetupCallbacks>b__37_4(object sender, LevelPlayAdDisplayInfoError args) { }

	// RVA: 0x1499E44
	private void <SetupCallbacks>b__37_5(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1499E68
	private void <SetupCallbacks>b__37_6(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1499E8C
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

	// RVA: 0x1499EB0
	public bool get_IsAdQualityEnabled() { }

	// RVA: 0x1499EB8
	internal void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInitError
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x149A12C
	public int get_ErrorCode() { }

	// RVA: 0x149A134
	public string get_ErrorMessage() { }

	// RVA: 0x149A13C
	internal void .ctor(string json) { }

	// RVA: 0x149A3A8
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

	// RVA: 0x149A438
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A4EC
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A5A0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149A654
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149A708
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A7BC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A870
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A924
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149A9D8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149AA8C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149AB40
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149ABF4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149ACA8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149AD5C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149AE10
	public string get_AdUnitId() { }

	// RVA: 0x149AEC8
	public void .ctor(string adUnitId) { }

	// RVA: 0x149B3D4
	internal void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

	// RVA: 0x149B408
	public void LoadAd() { }

	// RVA: 0x149B4C0
	public void DestroyAd() { }

	// RVA: 0x149B628
	public void ShowAd(string placementName) { }

	// RVA: 0x149B6E0
	public bool IsAdReady() { }

	// RVA: 0x149B798
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x149B574
	public void Dispose() { }

	// RVA: 0x149B7A0
	private void <.ctor>b__24_0(LevelPlayAdInfo info) { }

	// RVA: 0x149B7BC
	private void <.ctor>b__24_1(LevelPlayAdError error) { }

	// RVA: 0x149B7D8
	private void <.ctor>b__24_2(LevelPlayAdInfo info) { }

	// RVA: 0x149B7F4
	private void <.ctor>b__24_3(LevelPlayAdInfo info) { }

	// RVA: 0x149B810
	private void <.ctor>b__24_4(LevelPlayAdInfo info) { }

	// RVA: 0x149B82C
	private void <.ctor>b__24_5(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x149B848
	private void <.ctor>b__24_6(LevelPlayAdInfo info) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayReward
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	private readonly int <Amount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x149B864
	public string get_Name() { }

	// RVA: 0x149B86C
	public int get_Amount() { }

	// RVA: 0x149B874
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

	// RVA: 0x149B8BC
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149B970
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149BA24
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149BAD8
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149BB8C
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149BC40
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149BCF4
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149BDA8
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149BE5C
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x149BF10
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x149BFC4
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C078
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C12C
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C1E0
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C294
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C348
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149C3FC
	public string get_AdUnitId() { }

	// RVA: 0x149C4B4
	public void .ctor(string adUnitId) { }

	// RVA: 0x149CA6C
	internal void .ctor(IPlatformRewardedAd platformRewardedAd) { }

	// RVA: 0x149CAA0
	public void LoadAd() { }

	// RVA: 0x149CB58
	public void ShowAd(string placementName) { }

	// RVA: 0x149CC10
	public void DestroyAd() { }

	// RVA: 0x149CD78
	public bool IsAdReady() { }

	// RVA: 0x149CE30
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x149CCC4
	public void Dispose() { }

	// RVA: 0x149CE38
	private void <.ctor>b__27_0(LevelPlayAdInfo info) { }

	// RVA: 0x149CE54
	private void <.ctor>b__27_1(LevelPlayAdError error) { }

	// RVA: 0x149CE70
	private void <.ctor>b__27_2(LevelPlayAdInfo info) { }

	// RVA: 0x149CE8C
	private void <.ctor>b__27_3(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x149CEA8
	private void <.ctor>b__27_4(LevelPlayAdInfo info, LevelPlayReward reward) { }

	// RVA: 0x149CEC4
	private void <.ctor>b__27_5(LevelPlayAdInfo info) { }

	// RVA: 0x149CEE0
	private void <.ctor>b__27_6(LevelPlayAdInfo info) { }

	// RVA: 0x149CEFC
	private void <.ctor>b__27_7(LevelPlayAdInfo info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x149D9FC
	public void .ctor() { }

	// RVA: 0x149EA7C
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x149DC8C
	public void .ctor() { }

	// RVA: 0x149EDE8
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

	// RVA: 0x149CF18
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149CFCC
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D080
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149D134
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149D1E8
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D29C
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D350
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D404
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D4B8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D56C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D620
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149D6D4
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149D788
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D83C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149D8F0
	public string get_AdUnitId() { }

	// RVA: 0x149D8F8
	internal void .ctor(string adUnitId) { }

	// RVA: 0x149DA04
	public void LoadAd() { }

	// RVA: 0x149DB58
	public void ShowAd(string placementName) { }

	// RVA: 0x149DC94
	public bool IsAdReady() { }

	// RVA: 0x149DDA0
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x149E088
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x149E114
	public void onAdLoadFailed(string error) { }

	// RVA: 0x149E1A0
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x149E22C
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x149E338
	public void onAdClosed(string adInfo) { }

	// RVA: 0x149E3C4
	public void onAdClicked(string adInfo) { }

	// RVA: 0x149E450
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x149E4DC
	private void Dispose(bool disposing) { }

	// RVA: 0x149E594
	public void Dispose() { }

	// RVA: 0x149E634
	protected override void Finalize() { }

	// RVA: 0x149DAF4
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x149E708
	private void <LoadAd>b__35_0(object state) { }

	// RVA: 0x149E87C
	private void <IsAdReady>b__37_0(object state) { }

	// RVA: 0x149EA28
	private void <Dispose>b__46_0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x149FBB8
	public void .ctor() { }

	// RVA: 0x14A0D18
	internal void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x149FE48
	public void .ctor() { }

	// RVA: 0x14A1084
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

	// RVA: 0x149EF6C
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F020
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F0D4
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149F188
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x149F23C
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F2F0
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F3A4
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149F458
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x149F50C
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x149F5C0
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x149F674
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F728
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F7DC
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F890
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F944
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149F9F8
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x149FAAC
	public string get_AdUnitId() { }

	// RVA: 0x149FAB4
	internal void .ctor(string adUnitId) { }

	// RVA: 0x149FBC0
	public void LoadAd() { }

	// RVA: 0x149FD14
	public void ShowAd(string placementName) { }

	// RVA: 0x149FE50
	public bool IsAdReady() { }

	// RVA: 0x149FF5C
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14A0244
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14A02D0
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14A035C
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14A03E8
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14A04F4
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14A05D4
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14A0660
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14A06EC
	public void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14A0778
	private void Dispose(bool disposing) { }

	// RVA: 0x14A0830
	public void Dispose() { }

	// RVA: 0x14A08D0
	protected override void Finalize() { }

	// RVA: 0x149FCB0
	private bool CheckDisposedAndLogError() { }

	// RVA: 0x14A09A4
	private void <LoadAd>b__38_0(object state) { }

	// RVA: 0x14A0B18
	private void <IsAdReady>b__40_0(object state) { }

	// RVA: 0x14A0CC4
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

	// RVA: 0x14A12EC
	public void .ctor() { }

	// RVA: 0x14A1890
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14A13D8
	public void .ctor() { }

	// RVA: 0x14A1958
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A14C4
	public void .ctor() { }

	// RVA: 0x14A1A24
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

	// RVA: 0x14A15C4
	public void .ctor() { }

	// RVA: 0x14A1AF0
	internal void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A16B0
	public void .ctor() { }

	// RVA: 0x14A1BB4
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A179C
	public void .ctor() { }

	// RVA: 0x14A1C80
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A1888
	public void .ctor() { }

	// RVA: 0x14A1D4C
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityInterstitialAdListener
{
	// Fields
	private const string k_AndroidInterstitialListenerName = "com.ironsource.unity.androidbridge.IUnityInterstitialAdListener";
	private readonly IUnityInterstitialAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x149ED58
	public void .ctor(IUnityInterstitialAdListener listener) { }

	// RVA: 0x14A1208
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14A12F4
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14A13E0
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14A14CC
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14A15CC
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14A16B8
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14A17A4
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A25A8
	public void .ctor() { }

	// RVA: 0x14A25B0
	internal void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A1EFC
	public void .ctor() { }

	// RVA: 0x14A267C
	internal void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14A1FE8
	public void .ctor() { }

	// RVA: 0x14A2744
	internal void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A20D4
	public void .ctor() { }

	// RVA: 0x14A2810
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

	// RVA: 0x14A21D4
	public void .ctor() { }

	// RVA: 0x14A28DC
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

	// RVA: 0x14A22E4
	public void .ctor() { }

	// RVA: 0x14A29A0
	internal void <onAdRewarded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A23D0
	public void .ctor() { }

	// RVA: 0x14A2A6C
	internal void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A24BC
	public void .ctor() { }

	// RVA: 0x14A2B38
	internal void <onAdClosed>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityRewardedAdListener
{
	// Fields
	private const string k_AndroidRewardedAdListenerName = "com.ironsource.unity.androidbridge.IUnityRewardedAdListener";
	private readonly IUnityRewardedAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x14A0FF4
	public void .ctor(IUnityRewardedAdListener listener) { }

	// RVA: 0x14A1E18
	public void onAdLoaded(string adInfo) { }

	// RVA: 0x14A1F04
	public void onAdLoadFailed(string error) { }

	// RVA: 0x14A1FF0
	public void onAdDisplayed(string adInfo) { }

	// RVA: 0x14A20DC
	public void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x14A21DC
	public void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14A22EC
	public void onAdClicked(string adInfo) { }

	// RVA: 0x14A23D8
	public void onAdClosed(string adInfo) { }

	// RVA: 0x14A24C4
	public void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass48_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A3FC8
	public void .ctor() { }

	// RVA: 0x14A4698
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass49_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdError error; // 0x18

	// Methods

	// RVA: 0x14A40B4
	public void .ctor() { }

	// RVA: 0x14A46D4
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass50_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A41A0
	public void .ctor() { }

	// RVA: 0x14A4710
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass51_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A428C
	public void .ctor() { }

	// RVA: 0x14A474C
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14A43CC
	public void .ctor() { }

	// RVA: 0x14A4788
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A44B8
	public void .ctor() { }

	// RVA: 0x14A47C4
	internal void <InvokeExpandedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A45A4
	public void .ctor() { }

	// RVA: 0x14A4800
	internal void <InvokeCollapsedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x14A4690
	public void .ctor() { }

	// RVA: 0x14A483C
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

	// RVA: 0x14A2C04
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A2CB8
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A2D6C
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A2E20
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A2ED4
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A2F88
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A303C
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A30F0
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A31A4
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A3258
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A330C
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A33C0
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A3474
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A3528
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A35DC
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A3690
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A3744
	public string get_AdUnitId() { }

	// RVA: 0x14A374C
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14A3754
	public string get_PlacementName() { }

	// RVA: 0x14A375C
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14A3764
	private bool get_DisplayOnLoad() { }

	// RVA: 0x1498E88
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

	// RVA: 0x14A3BF8
	public void PauseAutoRefresh() { }

	// RVA: 0x14A3C70
	public void ResumeAutoRefresh() { }

	// RVA: 0x14A3CE8
	public void Load() { }

	// RVA: 0x14A3E84
	public void DestroyAd() { }

	// RVA: 0x14A3DFC
	public void SetPosition() { }

	// RVA: 0x14A3E74
	public void ShowAd() { }

	// RVA: 0x14A3E7C
	public void HideAd() { }

	// RVA: 0x14A3EE4
	internal void InvokeLoadedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A3FD0
	internal void InvokeFailedLoadEvent(LevelPlayAdError error) { }

	// RVA: 0x14A40BC
	internal void InvokeClickedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A41A8
	internal void InvokeDisplayedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A4294
	internal void InvokeFailedDisplayEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }

	// RVA: 0x14A43D4
	internal void InvokeExpandedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A44C0
	internal void InvokeCollapsedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A45AC
	internal void InvokeLeftApplicationEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x14A376C
	private static extern IntPtr BannerAdCreate(string adUnitId, string placementName, string description, int width, int height, int customWidth) { }

	// RVA: 0x14A3BF4
	private static extern void BannerAdSetDelegate(IntPtr bannerAdView, IntPtr bannerAdListener) { }

	// RVA: 0x14A3DF8
	private static extern void BannerAdLoad(IntPtr bannerAdView) { }

	// RVA: 0x14A3ED4
	private static extern void BannerAdDestroy(IntPtr bannerAdView) { }

	// RVA: 0x14A3ED8
	private static extern void BannerAdSetPosition(IntPtr bannerAdView, int position) { }

	// RVA: 0x14A3EDC
	private static extern void BannerAdViewShow(IntPtr bannerAdView) { }

	// RVA: 0x14A3EE0
	private static extern void BannerAdViewHide(IntPtr bannerAdView) { }

	// RVA: 0x14A3C6C
	private static extern void BannerAdPauseAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x14A3CE4
	private static extern void BannerAdResumeAutoRefresh(IntPtr bannerAdView) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14A5138
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A51DC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A51F0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A52B0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14A52BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A5360
	public virtual void Invoke(IntPtr bannerPtr, string errorPtr) { }

	// RVA: 0x14A5374
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14A5434
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14A5440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A54E4
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A54F8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A55B8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14A55C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A5668
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A567C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A573C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14A5748
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A57EC
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14A5800
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14A58D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidExpandAdWithAdInfo
{
	// Methods

	// RVA: 0x14A58DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A5980
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A5994
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A5A54
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCollapseAdWithAdInfo
{
	// Methods

	// RVA: 0x14A5A60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A5B04
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A5B18
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A5BD8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidLeaveAppWithAdInfo
{
	// Methods

	// RVA: 0x14A5BE4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A5C88
	public virtual void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x14A5C9C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A5D5C
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

	// RVA: 0x14A3804
	public void .ctor(iOSBannerAd bannerAd) { }

	// RVA: 0x14A50D4
	public override void Dispose() { }

	// RVA: 0x14A4FFC
	private static extern IntPtr LPMBannerAdViewDelegateCreate(IntPtr bannerAdPtr, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidClickWithAdInfo clicked, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidExpandAdWithAdInfo expanded, DidCollapseAdWithAdInfo collapsed, DidLeaveAppWithAdInfo leftApp) { }

	// RVA: 0x14A5134
	private static extern void LPMBannerAdViewDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14A4878
	private static void LoadSuccess(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A494C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14A4A38
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A4B24
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A4C10
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14A4D38
	private static void Expanded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A4E24
	private static void Collapsed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A4F10
	private static void LeftApplication(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A7550
	public void .ctor() { }

	// RVA: 0x14A7DF0
	internal void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14A76EC
	public void .ctor() { }

	// RVA: 0x14A7E8C
	internal void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A7814
	public void .ctor() { }

	// RVA: 0x14A7F28
	internal void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A793C
	public void .ctor() { }

	// RVA: 0x14A7FC4
	internal void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14A7B00
	public void .ctor() { }

	// RVA: 0x14A8060
	internal void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A7C28
	public void .ctor() { }

	// RVA: 0x14A809C
	internal void <InvokeClosedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14A7D50
	public void .ctor() { }

	// RVA: 0x14A8138
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

	// RVA: 0x14A5D68
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A5E1C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A5ED0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A5F84
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14A6038
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A60EC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A61A0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A6254
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14A6308
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A63BC
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A6470
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A6524
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A65D8
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A668C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14A6740
	public string get_AdUnitId() { }

	// RVA: 0x14A6748
	public void .ctor(string adUnitId) { }

	// RVA: 0x14A6FD4
	public void LoadAd() { }

	// RVA: 0x14A71AC
	public void ShowAd(string placementName) { }

	// RVA: 0x14A7274
	public bool IsAdReady() { }

	// RVA: 0x14A7310
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14A7380
	public override void Dispose() { }

	// RVA: 0x14A7430
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14A75CC
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14A76F4
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14A781C
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14A7944
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14A7B08
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14A7C30
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14A7D58
	protected override void Finalize() { }

	// RVA: 0x14A6870
	private static extern IntPtr InterstitialAdCreate(string adUnitId) { }

	// RVA: 0x14A6FD0
	private static extern void InterstitialAdSetDelegate(IntPtr interstitialAd, IntPtr interstitialAdListener) { }

	// RVA: 0x14A71A8
	private static extern void InterstitialAdLoadAd(IntPtr interstitialAd) { }

	// RVA: 0x14A723C
	private static extern void InterstitialAdShowAd(IntPtr interstitialAd, string placementName) { }

	// RVA: 0x14A72F4
	private static extern bool InterstitialAdIsAdReady(IntPtr interstitialAd) { }

	// RVA: 0x14A7348
	private static extern bool InterstitialAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14A870C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A8C48
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14A8C5C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A8D1C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14A87B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A8D28
	public virtual void Invoke(IntPtr interstitialAd, string errorPtr) { }

	// RVA: 0x14A8D3C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14A8DFC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14A8854
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A8E08
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14A8E1C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A8EDC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14A88F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A8EE8
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14A8EFC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14A8FCC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14A899C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A8FD8
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14A8FEC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A90AC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14A8A40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A90B8
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14A90CC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A918C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14A8AE4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14A9198
	public virtual void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14A91AC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14A926C
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

	// RVA: 0x14A6A0C
	internal void .ctor(IosInterstitialAd interstitialAd) { }

	// RVA: 0x14A8B88
	private static extern IntPtr LPMInterstitialAdDelegateCreate(IntPtr interstitialAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14A8C44
	private static extern void LPMInterstitialAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14A81D4
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A8290
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14A834C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A8408
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A84C4
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14A8594
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14A8650
	private static void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
public class IosLevelPlaySdk
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed; // 0x8

	// Methods

	// RVA: 0x14A9278
	public static void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A9388
	public static void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x14A9498
	public static void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A95AC
	public static void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x14A96C0
	private void Awake() { }

	// RVA: 0x14A974C
	private static void .cctor() { }

	// RVA: 0x14A9750
	public static void Initialize(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14A9CA8
	public static void SetPauseGame(bool pause) { }

	// RVA: 0x14A9A78
	private static string[] GetAdFormatArray(LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14A9B9C
	private static extern void LPMInitialize(string appKey, string userId, string[] adFormats) { }

	// RVA: 0x14A9A0C
	private static extern void setPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x14A9D28
	private static extern void LPMSetPauseGame(bool pause) { }

	// RVA: 0x14A9D2C
	public void OnInitializationSuccess(string configuration) { }

	// RVA: 0x14A9DFC
	public void OnInitializationFailed(string error) { }

	// RVA: 0x14A9ECC
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

	// RVA: 0x14A6844
	protected void .ctor(bool usesCallbacks) { }

	// RVA: 0x14A9ED4
	public IntPtr get_NativePtr() { }

	// RVA: 0x14A68A4
	protected void set_NativePtr(IntPtr value) { }

	// RVA: 0x315B3A8
	protected static T Get(IntPtr ptr) { }

	// RVA: 0x14A73EC
	public virtual void Dispose() { }

	// RVA: 0x14A7044
	protected bool CheckDisposedAndLogError(string message) { }

	// RVA: 0x14A9EDC
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14AB650
	public void .ctor() { }

	// RVA: 0x14ABFC8
	internal void <InvokeLoadedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14AB778
	public void .ctor() { }

	// RVA: 0x14AC064
	internal void <InvokeFailedLoadEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14AB8A0
	public void .ctor() { }

	// RVA: 0x14AC100
	internal void <InvokeDisplayedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x14ABA64
	public void .ctor() { }

	// RVA: 0x14AC19C
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

	// RVA: 0x14ABBB0
	public void .ctor() { }

	// RVA: 0x14AC1D8
	internal void <InvokeRewardedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14ABCD8
	public void .ctor() { }

	// RVA: 0x14AC2BC
	internal void <InvokeClickedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14ABE00
	public void .ctor() { }

	// RVA: 0x14AC358
	internal void <InvokeClosedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14ABF28
	public void .ctor() { }

	// RVA: 0x14AC3F4
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

	// RVA: 0x14A9F78
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA02C
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA0E0
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AA194
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AA248
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA2FC
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA3B0
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AA464
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AA518
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AA5CC
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AA680
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA734
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA7E8
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA89C
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AA950
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AAA04
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AAAB8
	public string get_AdUnitId() { }

	// RVA: 0x14AAAC0
	public void .ctor(string adUnitId) { }

	// RVA: 0x14AB27C
	public void LoadAd() { }

	// RVA: 0x14AB2F0
	public void ShowAd(string placementName) { }

	// RVA: 0x14AB3B8
	public bool IsAdReady() { }

	// RVA: 0x14AB454
	public static bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14AB4C4
	public override void Dispose() { }

	// RVA: 0x14AB530
	internal void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x14AB658
	internal void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14AB780
	internal void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14AB8A8
	internal void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x14ABA6C
	internal void InvokeRewardedEvent(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14ABBB8
	internal void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x14ABCE0
	internal void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x14ABE08
	internal void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x14ABF30
	protected override void Finalize() { }

	// RVA: 0x14AABBC
	private static extern IntPtr RewardedAdCreate(string adUnitId) { }

	// RVA: 0x14AB278
	private static extern void RewardedAdSetDelegate(IntPtr rewardedAd, IntPtr rewardedAdListener) { }

	// RVA: 0x14AB2EC
	private static extern void RewardedAdLoadAd(IntPtr rewardedAd) { }

	// RVA: 0x14AB380
	private static extern void RewardedAdShowAd(IntPtr rewardedAd, string placementName) { }

	// RVA: 0x14AB438
	private static extern bool RewardedAdIsAdReady(IntPtr rewardedAd) { }

	// RVA: 0x14AB48C
	private static extern bool RewardedAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo
{
	// Methods

	// RVA: 0x14ACAA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD09C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14AD0B0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14AD170
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId
{
	// Methods

	// RVA: 0x14ACB44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD17C
	public virtual void Invoke(IntPtr rewardedAd, string errorPtr) { }

	// RVA: 0x14AD190
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14AD250
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14ACBE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD25C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14AD270
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14AD330
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo
{
	// Methods

	// RVA: 0x14ACC8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD33C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x14AD350
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14AD420
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidAdRewardedWithAdInfo
{
	// Methods

	// RVA: 0x14ACD30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD42C
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14AD440
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x14AD538
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo
{
	// Methods

	// RVA: 0x14ACDD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD544
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14AD558
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14AD618
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo
{
	// Methods

	// RVA: 0x14ACE78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD624
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14AD638
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14AD6F8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo
{
	// Methods

	// RVA: 0x14ACF1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14AD704
	public virtual void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14AD718
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14AD7D8
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

	// RVA: 0x14AABF0
	internal void .ctor(IosRewardedAd rewardedAd) { }

	// RVA: 0x14ACFC0
	private static extern IntPtr LPMRewardedAdDelegateCreate(IntPtr rewardedAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidAdRewardedWithAdInfo rewarded, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14AD098
	private static extern void LPMRewardedAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x14AC490
	private static void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14AC54C
	private static void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x14AC608
	private static void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14AC6C4
	private static void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14AC794
	private static void Rewarded(IntPtr ptr, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x14AC86C
	private static void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14AC928
	private static void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x14AC9E4
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

	// RVA: 0x14AD7E4
	private static void Init() { }

	// RVA: 0x14A7558
	public static void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x14AD844
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

	// RVA: 0x14AD8B8
	public void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

	// RVA: 0x14AD918
	public void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AD9CC
	public void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ADA80
	public void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14ADB34
	public void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14ADBE8
	public void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ADC9C
	public void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ADD50
	public void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ADE04
	public void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14ADEB8
	public void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14ADF6C
	public void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AE020
	public void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE0D4
	public void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE188
	public void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE23C
	public void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE2F0
	public void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE3A4
	public void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE458
	public LevelPlayBannerPosition get_Position() { }

	// RVA: 0x14AE460
	public void Load() { }

	// RVA: 0x14AE464
	public void DestroyAd() { }

	// RVA: 0x14AE468
	public void ShowAd() { }

	// RVA: 0x14AE46C
	public void HideAd() { }

	// RVA: 0x14AE470
	public void PauseAutoRefresh() { }

	// RVA: 0x14AE474
	public void ResumeAutoRefresh() { }

	// RVA: 0x14AE478
	public void SetAutoRefresh(bool flag) { }

	// RVA: 0x14AE47C
	public void Dispose() { }

	// RVA: 0x14AE480
	public string get_AdUnitId() { }

	// RVA: 0x14AE488
	public LevelPlayAdSize get_AdSize() { }

	// RVA: 0x14AE490
	public LevelPlayAdSize get_Size() { }

	// RVA: 0x14AE498
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

	// RVA: 0x14AE4A0
	public void Dispose() { }

	// RVA: 0x14AE4A4
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE558
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE60C
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AE6C0
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AE774
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE828
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE8DC
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AE990
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEA44
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEAF8
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEBAC
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AEC60
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AED14
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEDC8
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEE7C
	public string get_AdUnitId() { }

	// RVA: 0x14AEE84
	public void .ctor(string adUnitId) { }

	// RVA: 0x14AEE8C
	public void LoadAd() { }

	// RVA: 0x14AEE90
	public void ShowAd(string placementName) { }

	// RVA: 0x14AEE94
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

	// RVA: 0x14AEE9C
	public void Dispose() { }

	// RVA: 0x14AEEA0
	public void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AEF54
	public void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF008
	public void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AF0BC
	public void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14AF170
	public void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF224
	public void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF2D8
	public void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AF38C
	public void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14AF440
	public void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AF4F4
	public void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14AF5A8
	public void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF65C
	public void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF710
	public void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF7C4
	public void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF878
	public void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF92C
	public void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14AF9E0
	public string get_AdUnitId() { }

	// RVA: 0x14AF9E8
	public void .ctor(string adUnitId) { }

	// RVA: 0x14AF9F0
	public void LoadAd() { }

	// RVA: 0x14AF9F4
	public void ShowAd(string placementName) { }

	// RVA: 0x14AF9F8
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


