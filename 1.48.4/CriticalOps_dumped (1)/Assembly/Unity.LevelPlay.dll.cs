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

	// RVA: 0x1459ED4
	void .ctor() { }

	// RVA: 0x145A3C4
	IronSource get_Agent() { }

	// RVA: 0x145A4AC
	string pluginVersion() { }

	// RVA: 0x145A528
	string unityVersion() { }

	// RVA: 0x145A598
	void setUnsupportedPlatform() { }

	// RVA: 0x145A61C
	void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x145A6D8
	void onApplicationPause(bool pause) { }

	// RVA: 0x145A790
	string getAdvertiserId() { }

	// RVA: 0x145A848
	void validateIntegration() { }

	// RVA: 0x145A900
	void shouldTrackNetworkState(bool track) { }

	// RVA: 0x145A9B8
	bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x145AA70
	void setAdaptersDebug(bool enabled) { }

	// RVA: 0x145AB28
	void setMetaData(string key, string value) { }

	// RVA: 0x145ABE8
	void setMetaData(string key, string[] values) { }

	// RVA: 0x145ACA8
	System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x145AD60
	void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x145AE18
	void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x145AED8
	void SetPauseGame(bool pause) { }

	// RVA: 0x145AF90
	void setUserId(string userId) { }

	// RVA: 0x145B048
	void init(string appKey) { }

	// RVA: 0x145B100
	void init(string appKey, string[] adUnits) { }

	// RVA: 0x145B1C0
	void loadRewardedVideo() { }

	// RVA: 0x145B278
	void showRewardedVideo() { }

	// RVA: 0x145B330
	void showRewardedVideo(string placementName) { }

	// RVA: 0x145B3E8
	IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x145B4A0
	bool isRewardedVideoAvailable() { }

	// RVA: 0x145B558
	bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x145B610
	void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x145B6C8
	void clearRewardedVideoServerParams() { }

	// RVA: 0x145B780
	void loadInterstitial() { }

	// RVA: 0x145B838
	void showInterstitial() { }

	// RVA: 0x145B8F0
	void showInterstitial(string placementName) { }

	// RVA: 0x145B9A8
	bool isInterstitialReady() { }

	// RVA: 0x145BA60
	bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x145BB18
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x145BBD8
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x145BCA8
	void destroyBanner() { }

	// RVA: 0x145BD60
	void displayBanner() { }

	// RVA: 0x145BE18
	void hideBanner() { }

	// RVA: 0x145BED0
	bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x145BF88
	float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x145C040
	float getDeviceScreenWidth() { }

	// RVA: 0x145C0F8
	void setSegment(IronSourceSegment segment) { }

	// RVA: 0x145C1B0
	void setConsent(bool consent) { }

	// RVA: 0x145C268
	void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x145C320
	void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x145C3D8
	void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x145C498
	void launchTestSuite() { }

	// RVA: 0x145C550
	void .cctor() { }

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

	// RVA: 0x145C5BC
	void .ctor(string json) { }

	// RVA: 0x145CDD4
	string ToString() { }

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

	// RVA: 0x145D2AC
	void Awake() { }

	// RVA: 0x145D360
	void add__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145D430
	void remove__onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145D500
	void add_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145D5A0
	void remove_onAdLoadedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145D640
	void onAdLoaded(string args) { }

	// RVA: 0x145D6F8
	void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x145D7CC
	void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x145D8A0
	void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x145D940
	void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x145D9E0
	void onAdLoadFailed(string description) { }

	// RVA: 0x145DD34
	void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145DE08
	void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145DEDC
	void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145DF7C
	void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E01C
	void onAdClicked(string args) { }

	// RVA: 0x145E0D4
	void add__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E1A8
	void remove__onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E27C
	void add_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E31C
	void remove_onAdScreenPresentedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E3BC
	void onAdScreenPresented(string args) { }

	// RVA: 0x145E474
	void add__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E548
	void remove__onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E61C
	void add_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E6BC
	void remove_onAdScreenDismissedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E75C
	void onAdScreenDismissed(string args) { }

	// RVA: 0x145E814
	void add__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E8E8
	void remove__onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145E9BC
	void add_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145EA5C
	void remove_onAdLeftApplicationEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x145EAFC
	void onAdLeftApplication(string args) { }

	// RVA: 0x145DA78
	IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x145EBF8
	IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x145EF18
	void .ctor() { }

}

// Namespace: 
public class IronSourceConfig 
{
	// Fields
	private const string unsupportedPlatformStr = 5714689712;
	private static IronSourceConfig _instance; // 0x0

	// Methods

	// RVA: 0x145EF20
	IronSourceConfig get_Instance() { }

	// RVA: 0x145EFD4
	void CFSetLanguage(string language) { }

	// RVA: 0x145EFFC
	void CFSetClientSideCallbacks(bool useClientSideCallbacks) { }

	// RVA: 0x145F000
	void CFSetRewardedVideoCustomParams(string rewardedVideoCustomParams) { }

	// RVA: 0x145F028
	void setLanguage(string language) { }

	// RVA: 0x145F054
	void setClientSideCallbacks(bool status) { }

	// RVA: 0x145F05C
	void setRewardedVideoCustomParams(System.Collections.Generic.Dictionary<System.String,System.String> rewardedVideoCustomParams) { }

	// RVA: 0x145EFCC
	void .ctor() { }

}

// Namespace: 
public static class IronSourceConstants 
{
	// Fields
	public const string GET_INSTANCE_KEY = 5730729728;
	public const string ERROR_CODE = 5736766704;
	public const string ERROR_DESCRIPTION = 5730729664;
	public const string EMPTY_STRING = 5081882432;
	public const string LevelPlayinterstitialBridgeListenerClass = 5705178032;
	public const string LevelPlayRewardedVideoBridgeListenerClass = 5705177856;
	public const string LevelPlayRewardedVideoManualBridgeListenerClass = 5736315328;
	public const string bridgeClass = 5708573696;
	public const string LevelPlaybannerBridgeListenerClass = 5475813568;
	public const string segmentBridgeListenerClass = 5709425472;
	public const string impressionDataBridgeListenerClass = 5475813408;
	public const string initializeBridgeListenerClass = 5475813248;
	public const string IMPRESSION_DATA_KEY_AUCTION_ID = 5736766656;
	public const string IMPRESSION_DATA_KEY_AD_UNIT = 5736766608;
	internal const string IMPRESSION_DATA_KEY_AD_FORMAT = 5736766560;
	internal const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_NAME = 5714689312;
	internal const string IMPRESSION_DATA_KEY_MEDIATION_AD_UNIT_ID = 5730729600;
	public const string IMPRESSION_DATA_KEY_COUNTRY = 5736766512;
	public const string IMPRESSION_DATA_KEY_ABTEST = 5736712160;
	public const string IMPRESSION_DATA_KEY_SEGMENT_NAME = 5730729536;
	public const string IMPRESSION_DATA_KEY_PLACEMENT = 5736766464;
	public const string IMPRESSION_DATA_KEY_AD_NETWORK = 5736766416;
	public const string IMPRESSION_DATA_KEY_INSTANCE_NAME = 5730729472;
	public const string IMPRESSION_DATA_KEY_INSTANCE_ID = 5736766368;
	public const string IMPRESSION_DATA_KEY_REVENUE = 5736766224;
	public const string IMPRESSION_DATA_KEY_PRECISION = 5736766176;
	public const string IMPRESSION_DATA_KEY_LIFETIME_REVENUE = 5730729408;
	public const string IMPRESSION_DATA_KEY_ENCRYPTED_CPM = 5730729344;
	public const string IMPRESSION_DATA_KEY_CONVERSION_VALUE = 5730729280;
	public const string GENDER_MALE = 5736766128;
	public const string GENDER_FEMALE = 5736766080;
	public const string GENDER_UNKNOWN = 5736766032;
	public const string IRONSOURCE_MEDIATION_SETTING_NAME = 5708591584;
	public const string IRONSOURCE_MEDIATED_NETWORK_SETTING_NAME = 5708639520;
	public const string IRONSOURCE_RESOURCES_PATH = 5714689232;
	public const string IRONSOURCE_SKAN_ID_KEY = 5714689152;
}

// Namespace: 
public class IronSourceError 
{
	// Fields
	private string description; // 0x10
	private int code; // 0x18

	// Methods

	// RVA: 0x145F090
	int getErrorCode() { }

	// RVA: 0x145F098
	string getDescription() { }

	// RVA: 0x145F0A0
	int getCode() { }

	// RVA: 0x145EBB4
	void .ctor(int errorCode, string errorDescription) { }

	// RVA: 0x145F0A8
	string ToString() { }

}

// Namespace: 
private sealed class ISUnityBackgroundCallback 
{
	// Methods

	// RVA: 0x145F508
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1462204
	internal void Invoke(string args) { }

	// RVA: 0x1462218
	internal IAsyncResult BeginInvoke(string args, AsyncCallback callback, object object) { }

	// RVA: 0x1462268
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class IronSourceEvents 
{
	// Fields
	private const string ERROR_CODE = 5736765936;
	private const string ERROR_DESCRIPTION = 5730729152;
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

	// RVA: 0x145F1C4
	void RegisterCallback(ISUnityBackgroundCallback func) { }

	// RVA: 0x145F1D8
	void add_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x145F2A8
	void remove_onImpressionDataReadyEvent(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x145F378
	void Awake() { }

	// RVA: 0x145F10C
	void FireCallback(string args) { }

	// RVA: 0x145F638
	void add__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x145F6FC
	void remove__onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x145F7C0
	void add_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x145F8E4
	void remove_onSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x145FA08
	void onSdkInitializationCompleted(string empty) { }

	// RVA: 0x145FA70
	void add__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x145FB44
	void remove__onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x145FC18
	void add_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x145FCB8
	void remove_onSegmentReceivedEvent(System.Action<System.String> value) { }

	// RVA: 0x145FD58
	void onSegmentReceived(string segmentName) { }

	// RVA: 0x145FDD4
	void add__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x145FEA8
	void remove__onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x145FF7C
	void add_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x146001C
	void remove_onConsentViewDidFailToLoadWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14600BC
	void onConsentViewDidFailToLoadWithError(string args) { }

	// RVA: 0x14604C8
	void add__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x146059C
	void remove__onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1460670
	void add_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x1460710
	void remove_onConsentViewDidFailToShowWithErrorEvent(System.Action<System.String,IronSourceError> value) { }

	// RVA: 0x14607B0
	void onConsentViewDidFailToShowWithError(string args) { }

	// RVA: 0x1460900
	void add__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x14609D4
	void remove__onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1460AA8
	void add_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1460B48
	void remove_onConsentViewDidAcceptEvent(System.Action<System.String> value) { }

	// RVA: 0x1460BE8
	void onConsentViewDidAccept(string consentViewType) { }

	// RVA: 0x1460C64
	void add__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1460D38
	void remove__onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1460E0C
	void add_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1460EAC
	void remove_onConsentViewDidDismissEvent(System.Action<System.String> value) { }

	// RVA: 0x1460F4C
	void onConsentViewDidDismiss(string consentViewType) { }

	// RVA: 0x1460FC8
	void add__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x146109C
	void remove__onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1461170
	void add_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1461210
	void remove_onConsentViewDidLoadSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14612B0
	void onConsentViewDidLoadSuccess(string consentViewType) { }

	// RVA: 0x146132C
	void add__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1461400
	void remove__onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x14614D4
	void add_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1461574
	void remove_onConsentViewDidShowSuccessEvent(System.Action<System.String> value) { }

	// RVA: 0x1461614
	void onConsentViewDidShowSuccess(string consentViewType) { }

	// RVA: 0x146020C
	IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1461690
	IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x145F5BC
	void InvokeEvent(System.Action<IronSourceImpressionData> evt, string args) { }

	// RVA: 0x14621FC
	void .ctor() { }

}

// Namespace: 
public class IronSourceEventsDispatcher 
{
	// Fields
	private static IronSourceEventsDispatcher instance; // 0x0
	private static readonly System.Collections.Generic.Queue<System.Action> ironSourceExecuteOnMainThreadQueue; // 0x8

	// Methods

	// RVA: 0x1462274
	void executeAction(Action action) { }

	// RVA: 0x14623C8
	void Update() { }

	// RVA: 0x14627A8
	void removeFromParent() { }

	// RVA: 0x14628B8
	void initialize() { }

	// RVA: 0x1462AB4
	bool isCreated() { }

	// RVA: 0x1462B80
	void Awake() { }

	// RVA: 0x1462C0C
	void OnDisable() { }

	// RVA: 0x1462C74
	void .ctor() { }

	// RVA: 0x1462C7C
	void .cctor() { }

}

// Namespace: 
public interface IronSourceIAgent 
{
	// Methods

	// RVA: 0x2FE45DC
	void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x2FE4234
	void onApplicationPause(bool pause) { }

	// RVA: 0x2FE360C
	string getAdvertiserId() { }

	// RVA: 0x2FE41A8
	void validateIntegration() { }

	// RVA: 0x2FE4234
	void shouldTrackNetworkState(bool track) { }

	// RVA: 0x2FE3174
	bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x2FE4234
	void setAdaptersDebug(bool enabled) { }

	// RVA: 0x2FE47D4
	void setMetaData(string key, string value) { }

	// RVA: 0x2FE47D4
	void setMetaData(string key, string[] values) { }

	// RVA: -1
	System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x2FE4234
	void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x2FE47D4
	void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x2FE4234
	void SetPauseGame(bool pause) { }

	// RVA: 0x2FE4574
	void setUserId(string userId) { }

	// RVA: 0x2FE4574
	void init(string appKey) { }

	// RVA: 0x2FE47D4
	void init(string appKey, string[] adUnits) { }

	// RVA: 0x2FE41A8
	void loadRewardedVideo() { }

	// RVA: 0x2FE41A8
	void showRewardedVideo() { }

	// RVA: 0x2FE4574
	void showRewardedVideo(string placementName) { }

	// RVA: 0x2FE3054
	bool isRewardedVideoAvailable() { }

	// RVA: 0x2FE3174
	bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x2FE36BC
	IronSourcePlacement getPlacementInfo(string name) { }

	// RVA: 0x2FE4574
	void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x2FE41A8
	void clearRewardedVideoServerParams() { }

	// RVA: 0x2FE41A8
	void loadInterstitial() { }

	// RVA: 0x2FE41A8
	void showInterstitial() { }

	// RVA: 0x2FE4574
	void showInterstitial(string placementName) { }

	// RVA: 0x2FE3054
	bool isInterstitialReady() { }

	// RVA: 0x2FE3174
	bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x2FE45DC
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x2FE4650
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x2FE41A8
	void destroyBanner() { }

	// RVA: 0x2FE41A8
	void displayBanner() { }

	// RVA: 0x2FE41A8
	void hideBanner() { }

	// RVA: 0x2FE3174
	bool isBannerPlacementCapped(string placementName) { }

	// RVA: -1
	float getMaximalAdaptiveHeight(float width) { }

	// RVA: -1
	float getDeviceScreenWidth() { }

	// RVA: 0x2FE4574
	void setSegment(IronSourceSegment segment) { }

	// RVA: 0x2FE4234
	void setConsent(bool consent) { }

	// RVA: 0x2FE4574
	void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x2FE4574
	void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x2FE47D4
	void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x2FE41A8
	void launchTestSuite() { }

}

// Namespace: 
public static class dataSource 
{
	// Methods

	// RVA: 0x1462D2C
	string get_MOPUB() { }

}

// Namespace: 
public static class IronSourceAdUnits 
{
	// Methods

	// RVA: 0x1462D70
	string get_REWARDED_VIDEO() { }

	// RVA: 0x1462DB4
	string get_INTERSTITIAL() { }

	// RVA: 0x1462DF8
	string get_OFFERWALL() { }

	// RVA: 0x1462E3C
	string get_BANNER() { }

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

	// RVA: 0x1462E80
	void .ctor() { }

	// RVA: 0x1462F2C
	void .ctor(int width, int height) { }

	// RVA: 0x1462FE4
	void .ctor(string description) { }

	// RVA: 0x1463080
	void SetAdaptive(bool adaptive, int customWidth) { }

	// RVA: 0x1463110
	bool IsAdaptiveEnabled() { }

	// RVA: 0x1463118
	void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x1463120
	ISContainerParams getBannerContainerParams() { }

	// RVA: 0x1463128
	void SetRespectAndroidCutouts(bool respectAndroidCutouts) { }

	// RVA: 0x1463130
	bool IsRespectAndroidCutoutsEnabled() { }

	// RVA: 0x1463138
	string get_Description() { }

	// RVA: 0x1463140
	int get_Width() { }

	// RVA: 0x1463148
	int get_Height() { }

	// RVA: 0x1463150
	void .cctor() { }

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

	// RVA: 0x1463434
	float get_Width() { }

	// RVA: 0x146343C
	void set_Width(float value) { }

	// RVA: 0x1463444
	float get_Height() { }

	// RVA: 0x146344C
	void set_Height(float value) { }

	// RVA: 0x1462F00
	void .ctor() { }

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

	// RVA: 0x1461954
	void .ctor(string json) { }

	// RVA: 0x1463454
	string ToString() { }

}

// Namespace: 
public class IronSourceInitilizer 
{
	// Methods

	// RVA: 0x1463AE4
	void Initilize() { }

	// RVA: 0x1464060
	void .ctor() { }

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

	// RVA: 0x1464068
	void Awake() { }

	// RVA: 0x146411C
	void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14641EC
	void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14642BC
	void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x146435C
	void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14643FC
	void onAdReady(string args) { }

	// RVA: 0x14644B4
	void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1464588
	void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x146465C
	void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14646FC
	void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x146479C
	void onAdLoadFailed(string description) { }

	// RVA: 0x1464AF0
	void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1464BC4
	void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1464C98
	void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1464D38
	void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1464DD8
	void onAdOpened(string args) { }

	// RVA: 0x1464E90
	void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1464F64
	void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465038
	void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14650D8
	void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465178
	void onAdClosed(string args) { }

	// RVA: 0x1465230
	void add__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465304
	void remove__onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14653D8
	void add_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465478
	void remove_onAdShowSucceededEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465518
	void onAdShowSucceeded(string args) { }

	// RVA: 0x14655D0
	void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14656A4
	void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x1465778
	void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x1465818
	void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14658B8
	void onAdShowFailed(string args) { }

	// RVA: 0x1465A24
	void add__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465AF8
	void remove__onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465BCC
	void add_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465C6C
	void remove_onAdClickedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1465D0C
	void onAdClicked(string args) { }

	// RVA: 0x1464834
	IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1465DC4
	IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1466088
	void .ctor() { }

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

	// RVA: 0x1466090
	void .ctor() { }

	// RVA: 0x1466114
	void .cctor() { }

}

// Namespace: 
public class IronSourcePlacement 
{
	// Fields
	private string rewardName; // 0x10
	private int rewardAmount; // 0x18
	private string placementName; // 0x20

	// Methods

	// RVA: 0x145EEBC
	void .ctor(string placementName, string rewardName, int rewardAmount) { }

	// RVA: 0x14661D0
	string getRewardName() { }

	// RVA: 0x14661D8
	int getRewardAmount() { }

	// RVA: 0x14661E0
	string getPlacementName() { }

	// RVA: 0x14661E8
	string ToString() { }

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

	// RVA: 0x1466310
	void Awake() { }

	// RVA: 0x14663C4
	void add__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x1466494
	void remove__onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x1466564
	void add_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x1466604
	void remove_onAdShowFailedEvent(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x14666A4
	void onAdShowFailed(string args) { }

	// RVA: 0x1466ACC
	void add__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1466BA0
	void remove__onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1466C74
	void add_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1466D14
	void remove_onAdOpenedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1466DB4
	void onAdOpened(string args) { }

	// RVA: 0x1466E6C
	void add__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1466F40
	void remove__onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1467014
	void add_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14670B4
	void remove_onAdClosedEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1467154
	void onAdClosed(string args) { }

	// RVA: 0x146720C
	void add__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14672E0
	void remove__onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14673B4
	void add_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x1467454
	void remove_onAdRewardedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14674F4
	void onAdRewarded(string args) { }

	// RVA: 0x1467924
	void add__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x14679F8
	void remove__onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x1467ACC
	void add_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x1467B6C
	void remove_onAdClickedEvent(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x1467C0C
	void onAdClicked(string args) { }

	// RVA: 0x1467D78
	void add__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1467E4C
	void remove__onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1467F20
	void add_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1467FC0
	void remove_onAdAvailableEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1468060
	void onAdAvailable(string args) { }

	// RVA: 0x1468118
	void add__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14681DC
	void remove__onAdUnavailableEvent(Action value) { }

	// RVA: 0x14682A0
	void add_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14683C4
	void remove_onAdUnavailableEvent(Action value) { }

	// RVA: 0x14684E8
	void onAdUnavailable() { }

	// RVA: 0x1468550
	void add__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1468624
	void remove__onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x14686F8
	void add_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1468798
	void remove_onAdLoadFailedEvent(System.Action<IronSourceError> value) { }

	// RVA: 0x1468838
	void onAdLoadFailed(string description) { }

	// RVA: 0x14688D0
	void add__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x14689A4
	void remove__onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1468A78
	void add_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1468B18
	void remove_onAdReadyEvent(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x1468BB8
	void onAdReady(string adinfo) { }

	// RVA: 0x1466810
	IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x1467660
	IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1468C70
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly IronSourceSegment.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.String> <>9__10_0; // 0x8
	public static System.Func<System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>>,System.String> <>9__10_1; // 0x10
	public static System.Func<System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>>,System.String> <>9__10_2; // 0x18

	// Methods

	// RVA: 0x1469294
	void .cctor() { }

	// RVA: 0x1469300
	void .ctor() { }

	// RVA: 0x1469308
	string <getSegmentAsDict>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> d) { }

	// RVA: 0x14693D0
	string <getSegmentAsDict>b__10_1(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

	// RVA: 0x1469480
	string <getSegmentAsDict>b__10_2(System.Linq.IGrouping<System.String,System.Collections.Generic.KeyValuePair<System.String,System.String>> d) { }

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

	// RVA: 0x1468C78
	void .ctor() { }

	// RVA: 0x1468D1C
	void setCustom(string key, string value) { }

	// RVA: 0x1468D88
	System.Collections.Generic.Dictionary<System.String,System.String> getSegmentAsDict() { }

}

// Namespace: 
public class IronSourceUtils 
{
	// Fields
	private const string ERROR_CODE = 5736765744;
	private const string ERROR_DESCRIPTION = 5730729024;
	private const string INSTANCE_ID_KEY = 5736765696;
	private const string PLACEMENT_KEY = 5736765648;

	// Methods

	// RVA: 0x1469580
	IronSourceError getErrorFromErrorObject(object descriptionObject) { }

	// RVA: 0x146983C
	IronSourcePlacement getPlacementFromObject(object placementObject) { }

	// RVA: 0x1469B00
	void .ctor() { }

}

// Namespace: 
public interface IUnityImpressionData 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnImpressionDataReady(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x2FE4574
	void remove_OnImpressionDataReady(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x2FE4574
	void add_OnImpressionSuccess(System.Action<IronSourceImpressionData> value) { }

	// RVA: 0x2FE4574
	void remove_OnImpressionSuccess(System.Action<IronSourceImpressionData> value) { }

}

// Namespace: 
public interface IUnityInitialization 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnSdkInitializationCompletedEvent(Action value) { }

	// RVA: 0x2FE4574
	void remove_OnSdkInitializationCompletedEvent(Action value) { }

}

// Namespace: 
public interface IUnityLevelPlayBanner 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLeftApplication(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLeftApplication(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdScreenDismissed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdScreenDismissed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdScreenPresented(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdScreenPresented(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

}

// Namespace: 
public interface IUnityLevelPlayInterstitial 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdShowSucceeded(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdShowSucceeded(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<IronSourceAdInfo> value) { }

}

// Namespace: 
public interface IUnityLevelPlayRewardedVideo 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdShowFailed(System.Action<IronSourceError,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdOpened(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdRewarded(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdRewarded(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<IronSourcePlacement,IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdAvailable(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdAvailable(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdUnavailable(Action value) { }

	// RVA: 0x2FE4574
	void remove_OnAdUnavailable(Action value) { }

}

// Namespace: 
public interface IUnityLevelPlayRewardedVideoManual 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdReady(System.Action<IronSourceAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<IronSourceError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<IronSourceError> value) { }

}

// Namespace: 
public interface IUnitySegment 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x2FE4574
	void remove_OnSegmentRecieved(System.Action<System.String> value) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly IronSourceSegmentAndroid.<>c <>9; // 0x0
	public static System.Action<System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x146A2BC
	void .cctor() { }

	// RVA: 0x146A328
	void .ctor() { }

	// RVA: 0x146A330
	void <.ctor>b__3_0(string <p0>) { }

}

// Namespace: 
public class IronSourceSegmentAndroid 
{
	// Fields
	private System.Action<System.String> OnSegmentRecieved; // 0x20

	// Methods

	// RVA: 0x1469B08
	void add_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x1469BBC
	void remove_OnSegmentRecieved(System.Action<System.String> value) { }

	// RVA: 0x1469C70
	void .ctor() { }

	// RVA: 0x146A2A0
	void onSegmentRecieved(string segmentName) { }

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

	// RVA: 0x146B794
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x146B838
	internal void Invoke(bool pause) { }

	// RVA: 0x146B84C
	internal IAsyncResult BeginInvoke(bool pause, AsyncCallback callback, object object) { }

	// RVA: 0x146B908
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class iOSAgent 
{
	// Methods

	// RVA: 0x146A334
	void LPPSetWaterfallConfiguration(IOSWaterfallConfiguration configurationParams, AdFormat adFormat) { }

	// RVA: 0x146A338
	void CFSetPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x146A3A4
	string CFGetAdvertiserId() { }

	// RVA: 0x146A3D8
	void CFValidateIntegration() { }

	// RVA: 0x146A3DC
	void CFShouldTrackNetworkState(bool track) { }

	// RVA: 0x146A3E0
	bool CFSetDynamicUserId(string dynamicUserId) { }

	// RVA: 0x146A418
	void CFSetAdaptersDebug(bool enabled) { }

	// RVA: 0x146A41C
	void CFSetMetaData(string key, string value) { }

	// RVA: 0x146A464
	void CFSetMetaDataWithValues(string key, string[] values) { }

	// RVA: 0x146A55C
	string CFGetConversionValue() { }

	// RVA: 0x146A590
	void CFSetManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x146A594
	void CFSetNetworkData(string networkKey, string networkData) { }

	// RVA: 0x146A5DC
	void RegisterPauseGameFunction(bool pasue) { }

	// RVA: 0x146A5E0
	void CFSetUserId(string userId) { }

	// RVA: 0x146A608
	void CFInit(string appKey) { }

	// RVA: 0x146A630
	void CFInitWithAdUnits(string appKey, string[] adUnits) { }

	// RVA: 0x146A728
	void CFLoadRewardedVideo() { }

	// RVA: 0x146A72C
	void CFShowRewardedVideo() { }

	// RVA: 0x146A730
	void CFShowRewardedVideoWithPlacementName(string placementName) { }

	// RVA: 0x146A758
	bool CFIsRewardedVideoAvailable() { }

	// RVA: 0x146A774
	bool CFIsRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x146A7AC
	string CFGetPlacementInfo(string placementName) { }

	// RVA: 0x146A7F8
	void CFSetRewardedVideoServerParameters(string jsonString) { }

	// RVA: 0x146A820
	void CFClearRewardedVideoServerParameters() { }

	// RVA: 0x146A824
	void CFLoadInterstitial() { }

	// RVA: 0x146A828
	void CFShowInterstitial() { }

	// RVA: 0x146A82C
	void CFShowInterstitialWithPlacementName(string placementName) { }

	// RVA: 0x146A854
	bool CFIsInterstitialReady() { }

	// RVA: 0x146A870
	bool CFIsInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x146A8A8
	void CFLoadBanner(string description, int width, int height, int position, string placementName, bool isAdaptive, float containerWidth, float containerHeight) { }

	// RVA: 0x146A938
	void CFDestroyBanner() { }

	// RVA: 0x146A93C
	void CFDisplayBanner() { }

	// RVA: 0x146A940
	void CFHideBanner() { }

	// RVA: 0x146A944
	bool CFIsBannerPlacementCapped(string placementName) { }

	// RVA: 0x146A97C
	float CFIGetMaximalAdaptiveHeight(float width) { }

	// RVA: 0x146A980
	float CFIGetDeviceScreenWidth() { }

	// RVA: 0x146A984
	void CFSetSegment(string json) { }

	// RVA: 0x146A9AC
	void CFSetConsent(bool consent) { }

	// RVA: 0x146A9B0
	void CFLoadConsentViewWithType(string consentViewType) { }

	// RVA: 0x146A9D8
	void CFShowConsentViewWithType(string consentViewType) { }

	// RVA: 0x146AA00
	void CFSetAdRevenueData(string dataSource, string impressionData) { }

	// RVA: 0x146AA48
	void CFLaunchTestSuite() { }

	// RVA: 0x145A360
	void .ctor() { }

	// RVA: 0x146AA4C
	void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x146ABD0
	void onApplicationPause(bool pause) { }

	// RVA: 0x146ABD4
	string getAdvertiserId() { }

	// RVA: 0x146AC08
	void validateIntegration() { }

	// RVA: 0x146AC0C
	void shouldTrackNetworkState(bool track) { }

	// RVA: 0x146AC14
	bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x146AC50
	void setAdaptersDebug(bool enabled) { }

	// RVA: 0x146AC58
	void setMetaData(string key, string[] values) { }

	// RVA: 0x146AC64
	void setMetaData(string key, string value) { }

	// RVA: 0x146ACB0
	System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x146ADB4
	void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x146ADBC
	void setNetworkData(string networkKey, string networkData) { }

	// RVA: 0x146AE08
	void SetPauseGame(bool pause) { }

	// RVA: 0x146AEC0
	void setUserId(string userId) { }

	// RVA: 0x146AEEC
	void init(string appKey) { }

	// RVA: 0x146B064
	void init(string appKey, string[] adUnits) { }

	// RVA: 0x146B1DC
	void loadRewardedVideo() { }

	// RVA: 0x146B1E0
	void showRewardedVideo() { }

	// RVA: 0x146B1E4
	void showRewardedVideo(string placementName) { }

	// RVA: 0x146B210
	bool isRewardedVideoAvailable() { }

	// RVA: 0x146B22C
	bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x146B268
	IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x146B494
	void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x146B4C4
	void clearRewardedVideoServerParams() { }

	// RVA: 0x146B4C8
	void loadInterstitial() { }

	// RVA: 0x146B4CC
	void showInterstitial() { }

	// RVA: 0x146B4D0
	void showInterstitial(string placementName) { }

	// RVA: 0x146B4FC
	bool isInterstitialReady() { }

	// RVA: 0x146B518
	bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x146B554
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x146B5B0
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x146B64C
	void destroyBanner() { }

	// RVA: 0x146B650
	void displayBanner() { }

	// RVA: 0x146B654
	void hideBanner() { }

	// RVA: 0x146B658
	bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x146B694
	float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x146B698
	float getDeviceScreenWidth() { }

	// RVA: 0x146B69C
	void setSegment(IronSourceSegment segment) { }

	// RVA: 0x146B6D8
	void setConsent(bool consent) { }

	// RVA: 0x146B6E0
	void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x146B70C
	void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x146B738
	void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x146B790
	void launchTestSuite() { }

}

// Namespace: 
public class UnsupportedPlatformAgent 
{
	// Methods

	// RVA: 0x145A368
	void .ctor() { }

	// RVA: 0x146B914
	void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat) { }

	// RVA: 0x146B918
	void start() { }

	// RVA: 0x146B91C
	void onApplicationPause(bool pause) { }

	// RVA: 0x146B920
	string getAdvertiserId() { }

	// RVA: 0x146B964
	void validateIntegration() { }

	// RVA: 0x146B968
	void shouldTrackNetworkState(bool track) { }

	// RVA: 0x146B96C
	bool setDynamicUserId(string dynamicUserId) { }

	// RVA: 0x146B974
	void setAdaptersDebug(bool enabled) { }

	// RVA: 0x146B978
	void setMetaData(string key, string value) { }

	// RVA: 0x146B97C
	void setMetaData(string key, string[] values) { }

	// RVA: 0x146B980
	System.Nullable<System.Int32> getConversionValue() { }

	// RVA: 0x146B988
	void setManualLoadRewardedVideo(bool isOn) { }

	// RVA: 0x146B98C
	void setNetworkData(string networkKey, string networkDataJson) { }

	// RVA: 0x146B990
	void SetPauseGame(bool pause) { }

	// RVA: 0x146B994
	void setUserId(string userId) { }

	// RVA: 0x146B998
	void init(string appKey) { }

	// RVA: 0x146B99C
	void init(string appKey, string[] adUnits) { }

	// RVA: 0x146B9A0
	void loadRewardedVideo() { }

	// RVA: 0x146B9A4
	void showRewardedVideo() { }

	// RVA: 0x146B9A8
	void showRewardedVideo(string placementName) { }

	// RVA: 0x146B9AC
	bool isRewardedVideoAvailable() { }

	// RVA: 0x146B9B4
	bool isRewardedVideoPlacementCapped(string placementName) { }

	// RVA: 0x146B9BC
	IronSourcePlacement getPlacementInfo(string placementName) { }

	// RVA: 0x146B9C4
	void setRewardedVideoServerParams(System.Collections.Generic.Dictionary<System.String,System.String> parameters) { }

	// RVA: 0x146B9C8
	void clearRewardedVideoServerParams() { }

	// RVA: 0x146B9CC
	void loadInterstitial() { }

	// RVA: 0x146B9D0
	void showInterstitial() { }

	// RVA: 0x146B9D4
	void showInterstitial(string placementName) { }

	// RVA: 0x146B9D8
	bool isInterstitialReady() { }

	// RVA: 0x146B9E0
	bool isInterstitialPlacementCapped(string placementName) { }

	// RVA: 0x146B9E8
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position) { }

	// RVA: 0x146B9EC
	void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName) { }

	// RVA: 0x146B9F0
	void destroyBanner() { }

	// RVA: 0x146B9F4
	void displayBanner() { }

	// RVA: 0x146B9F8
	void hideBanner() { }

	// RVA: 0x146B9FC
	bool isBannerPlacementCapped(string placementName) { }

	// RVA: 0x146BA04
	float getMaximalAdaptiveHeight(float width) { }

	// RVA: 0x146BA0C
	float getDeviceScreenWidth() { }

	// RVA: 0x146BA14
	void setBannerContainerParams(ISContainerParams parameters) { }

	// RVA: 0x146BA18
	void setSegment(IronSourceSegment segment) { }

	// RVA: 0x146BA1C
	void setConsent(bool consent) { }

	// RVA: 0x146BA20
	void loadConsentViewWithType(string consentViewType) { }

	// RVA: 0x146BA24
	void showConsentViewWithType(string consentViewType) { }

	// RVA: 0x146BA28
	void setAdRevenueData(string dataSource, System.Collections.Generic.Dictionary<System.String,System.String> impressionData) { }

	// RVA: 0x146BA2C
	void launchTestSuite() { }

}

// Namespace: 
public class WaterfallConfigurationBuilder 
{
	// Fields
	private System.Nullable<System.Double> ceiling; // 0x10
	private System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x146BB2C
	void .ctor() { }

	// RVA: 0x146BBFC
	WaterfallConfigurationBuilder SetCeiling(Double ceiling) { }

	// RVA: 0x146BC80
	WaterfallConfigurationBuilder SetFloor(Double floor) { }

	// RVA: 0x146BD04
	WaterfallConfiguration Build() { }

}

// Namespace: 
public class WaterfallConfiguration 
{
	// Fields
	private readonly System.Nullable<System.Double> ceiling; // 0x10
	private readonly System.Nullable<System.Double> floor; // 0x20

	// Methods

	// RVA: 0x146BA70
	System.Nullable<System.Double> get_Ceiling() { }

	// RVA: 0x146BA7C
	System.Nullable<System.Double> get_Floor() { }

	// RVA: 0x146BA88
	void .ctor(System.Nullable<System.Double> ceiling, System.Nullable<System.Double> floor) { }

	// RVA: 0x146BAD4
	WaterfallConfigurationBuilder Builder() { }

	// RVA: 0x146BB34
	WaterfallConfiguration Empty() { }

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

	// RVA: 0x146BD88
	MonoScriptData Get() { }

	// RVA: 0x146BE8C
	void .ctor() { }

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
	private const string WHITE_SPACE = 5736765456;
	private const string WORD_BREAK = 5730728896;
	private StringReader json; // 0x10

	// Methods

	// RVA: 0x146C134
	void .ctor(string jsonString) { }

	// RVA: 0x146BE94
	object Parse(string jsonString) { }

	// RVA: 0x146C1DC
	void Dispose() { }

	// RVA: 0x146C218
	System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0x146CAE4
	System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0x146C1B4
	object ParseValue() { }

	// RVA: 0x146CBF4
	object ParseByToken(TOKEN token) { }

	// RVA: 0x146C648
	string ParseString() { }

	// RVA: 0x146CD00
	object ParseNumber() { }

	// RVA: 0x146D04C
	void EatWhitespace() { }

	// RVA: 0x146D144
	Char get_PeekChar() { }

	// RVA: 0x146CE34
	Char get_NextChar() { }

	// RVA: 0x146CEC0
	string get_NextWord() { }

	// RVA: 0x146C3A4
	TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer 
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x146D1D0
	void .ctor() { }

	// RVA: 0x146C060
	string Serialize(object obj) { }

	// RVA: 0x146D248
	void SerializeValue(object value) { }

	// RVA: 0x146DA24
	void SerializeObject(IDictionary obj) { }

	// RVA: 0x146D6DC
	void SerializeArray(IList anArray) { }

	// RVA: 0x146D420
	void SerializeString(string str) { }

	// RVA: 0x146DEA8
	void SerializeOther(object value) { }

}

// Namespace: IronSourceJSON
public static class Json 
{
	// Methods

	// RVA: 0x145CC6C
	object Deserialize(string json) { }

	// RVA: 0x145F08C
	string Serialize(object obj) { }

}

// Namespace: Unity.Services.LevelPlay
internal static class Constants 
{
	// Fields
	internal const string PackageName = 5708639328;
	internal const string PackageVersion = 5736765168;
	internal const string PackageVersionAnnotation = 5081882432;
	internal const string AnnotatedPackageVersion = 5736765120;
	internal const string PackageAnalyticsIdentifier = 5730728704;
	internal const string UnityPackageDirectoryName = 5736765072;
}

// Namespace: Unity.Services.LevelPlay
internal static class LevelPlayLogger 
{
	// Fields
	private const string k_Tag = 5730728512;
	private const string k_VerboseLoggingDefine = 5708573312;
	private const string k_UnityAssertions = 5730728448;

	// Methods

	// RVA: 0x145CC78
	void Log(object message) { }

	// RVA: 0x1463F04
	void LogWarning(object message) { }

	// RVA: 0x146A144
	void LogError(object message) { }

	// RVA: 0x1462648
	void LogException(Exception exception) { }

	// RVA: 0x146E094
	void LogAssertion(object message) { }

	// RVA: 0x146E1F4
	void LogVerbose(object message) { }

}

// Namespace: com.unity3d.mediation
public interface ILevelPlayBannerAd 
{
	// Methods

	// RVA: 0x2FE41A8
	void LoadAd() { }

	// RVA: 0x2FE41A8
	void DestroyAd() { }

	// RVA: 0x2FE41A8
	void ShowAd() { }

	// RVA: 0x2FE41A8
	void HideAd() { }

	// RVA: 0x2FE360C
	string GetAdUnitId() { }

	// RVA: 0x2FE360C
	LevelPlayAdSize GetAdSize() { }

	// RVA: 0x2FE32D4
	LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x2FE360C
	string GetPlacementName() { }

	// RVA: 0x2FE41A8
	void PauseAutoRefresh() { }

	// RVA: 0x2FE41A8
	void ResumeAutoRefresh() { }

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

}

// Namespace: com.unity3d.mediation
public interface ILevelPlayInterstitialAd 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE360C
	string get_AdUnitId() { }

	// RVA: 0x2FE41A8
	void LoadAd() { }

	// RVA: 0x2FE4574
	void ShowAd(string placementName) { }

	// RVA: 0x2FE41A8
	void DestroyAd() { }

	// RVA: 0x2FE3054
	bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
public interface ILevelPlayRewardedAd 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE360C
	string get_AdUnitId() { }

	// RVA: 0x2FE41A8
	void LoadAd() { }

	// RVA: 0x2FE4574
	void ShowAd(string placementName) { }

	// RVA: 0x2FE41A8
	void DestroyAd() { }

	// RVA: 0x2FE3054
	bool IsAdReady() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly com.unity3d.mediation.LevelPlay.<>c <>9; // 0x0

	// Methods

	// RVA: 0x146EF14
	void .cctor() { }

	// RVA: 0x146EF80
	void .ctor() { }

	// RVA: 0x146EF88
	void <.cctor>b__12_0(LevelPlayConfiguration configuration) { }

	// RVA: 0x146F02C
	void <.cctor>b__12_1(LevelPlayInitError error) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlay 
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> InitSuccessReceived; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailedReceived; // 0x8

	// Methods

	// RVA: 0x146E350
	void add_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x146E460
	void remove_InitSuccessReceived(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x146E570
	void add_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x146E684
	void remove_OnInitFailedReceived(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x146E798
	void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x146E8B0
	void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x146E9C4
	void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x146EADC
	void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x146EBF0
	void .cctor() { }

	// RVA: 0x146ED30
	void Init(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x146EDAC
	void SetPauseGame(bool pause) { }

	// RVA: 0x146EF0C
	void .ctor() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdDisplayInfoError 
{
	// Fields
	private LevelPlayAdInfo <DisplayLevelPlayAdInfo>k__BackingField; // 0x10
	private LevelPlayAdError <LevelPlayError>k__BackingField; // 0x18

	// Methods

	// RVA: 0x146F0D0
	LevelPlayAdInfo get_DisplayLevelPlayAdInfo() { }

	// RVA: 0x146F0D8
	void set_DisplayLevelPlayAdInfo(LevelPlayAdInfo value) { }

	// RVA: 0x146F0E0
	LevelPlayAdError get_LevelPlayError() { }

	// RVA: 0x146F0E8
	void set_LevelPlayError(LevelPlayAdError value) { }

	// RVA: 0x146F0F0
	void .ctor(LevelPlayAdInfo levelPlayAdInfo, LevelPlayAdError error) { }

	// RVA: 0x146F140
	string ToString() { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayAdError 
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18
	private readonly string <AdUnitId>k__BackingField; // 0x20

	// Methods

	// RVA: 0x146F1E4
	int get_ErrorCode() { }

	// RVA: 0x146F1EC
	string get_ErrorMessage() { }

	// RVA: 0x146F1F4
	string get_AdUnitId() { }

	// RVA: 0x146F1FC
	void .ctor(string json) { }

	// RVA: 0x146F4C0
	void .ctor(string adUnitId, int errorCode, string errorMessage) { }

	// RVA: 0x146F518
	string ToString() { }

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
	private const string AdUnitIdKey = 5737082144;
	private const string AdUnitNameKey = 5737082096;
	private const string AdSizeKey = 5737082048;
	private const string AdFormatKey = 5737082000;
	private const string PlacementNameKey = 5730728000;
	private const string AuctionIdKey = 5737081952;
	private const string CountryKey = 5737081904;
	private const string AbKey = 5736712032;
	private const string SegmentNameKey = 5730727936;
	private const string AdNetworkKey = 5737081856;
	private const string InstanceNameKey = 5730727872;
	private const string InstanceIdKey = 5737081808;
	private const string RevenueKey = 5737081760;
	private const string PrecisionKey = 5737081712;
	private const string EncryptedCpmKey = 5730727808;
	private const string AdSizeDescriptionKey = 5730727680;
	private const string AdSizeWidthKey = 5737081664;
	private const string AdSizeHeightKey = 5737081616;
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

	// RVA: 0x146F5A8
	void .ctor(string json) { }

	// RVA: 0x1470034
	LevelPlayAdSize GetAdSize(string adSizeJson) { }

	// RVA: 0x147037C
	string ToString() { }

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

	// RVA: 0x1470788
	void .ctor(string description) { }

	// RVA: 0x147032C
	void .ctor(string description, int width, int height) { }

	// RVA: 0x14707C4
	LevelPlayAdSize CreateCustomBannerSize(int width, int height) { }

	// RVA: 0x1470868
	LevelPlayAdSize CreateAdaptiveAdSize(int customWidth) { }

	// RVA: 0x1470900
	string get_Description() { }

	// RVA: 0x1470908
	int get_Width() { }

	// RVA: 0x1470910
	int get_Height() { }

	// RVA: 0x1470918
	int get_CustomWidth() { }

	// RVA: 0x1470920
	string ToString() { }

	// RVA: 0x14709D8
	void .cctor() { }

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

	// RVA: 0x1470B88
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1470C3C
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1470CF0
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1470DA4
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1470E58
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1470F0C
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1470FC0
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1471074
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1471128
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14711DC
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1471290
	void add_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1471344
	void remove_OnAdExpanded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14713F8
	void add_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14714AC
	void remove_OnAdCollapsed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1471560
	void add_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1471614
	void remove_OnAdLeftApplication(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14716C8
	void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementName, bool displayOnLoad, bool respectSafeArea) { }

	// RVA: 0x1471EC8
	void LoadAd() { }

	// RVA: 0x1471F80
	void DestroyAd() { }

	// RVA: 0x1472038
	void ShowAd() { }

	// RVA: 0x14720F0
	void HideAd() { }

	// RVA: 0x14721A8
	string GetAdUnitId() { }

	// RVA: 0x1472260
	LevelPlayAdSize GetAdSize() { }

	// RVA: 0x1472318
	LevelPlayBannerPosition GetPosition() { }

	// RVA: 0x14723D0
	string GetPlacementName() { }

	// RVA: 0x1472488
	void PauseAutoRefresh() { }

	// RVA: 0x1472540
	void ResumeAutoRefresh() { }

	// RVA: 0x1471974
	void SetupCallbacks() { }

	// RVA: 0x14725F8
	void Dispose() { }

	// RVA: 0x14726B8
	void <SetupCallbacks>b__37_0(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14726DC
	void <SetupCallbacks>b__37_1(object sender, LevelPlayAdError args) { }

	// RVA: 0x1472700
	void <SetupCallbacks>b__37_2(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1472724
	void <SetupCallbacks>b__37_3(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1472748
	void <SetupCallbacks>b__37_4(object sender, LevelPlayAdDisplayInfoError args) { }

	// RVA: 0x147276C
	void <SetupCallbacks>b__37_5(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x1472790
	void <SetupCallbacks>b__37_6(object sender, LevelPlayAdInfo args) { }

	// RVA: 0x14727B4
	void <SetupCallbacks>b__37_7(object sender, LevelPlayAdInfo args) { }

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
	private const string k_IsAdQualityEnabled = 5730727552;
	private readonly bool <IsAdQualityEnabled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x14727D8
	bool get_IsAdQualityEnabled() { }

	// RVA: 0x14727E0
	void .ctor(string json) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayInitError 
{
	// Fields
	private readonly int <ErrorCode>k__BackingField; // 0x10
	private readonly string <ErrorMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1472A54
	int get_ErrorCode() { }

	// RVA: 0x1472A5C
	string get_ErrorMessage() { }

	// RVA: 0x1472A64
	void .ctor(string json) { }

	// RVA: 0x1472CD0
	string ToString() { }

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

	// RVA: 0x1472D60
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1472E14
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1472EC8
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1472F7C
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1473030
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14730E4
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1473198
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147324C
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1473300
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14733B4
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1473468
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x147351C
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14735D0
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1473684
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1473738
	string get_AdUnitId() { }

	// RVA: 0x14737F0
	void .ctor(string adUnitId) { }

	// RVA: 0x1473CFC
	void .ctor(IPlatformInterstitialAd platformInterstitialAd) { }

	// RVA: 0x1473D30
	void LoadAd() { }

	// RVA: 0x1473DE8
	void DestroyAd() { }

	// RVA: 0x1473F50
	void ShowAd(string placementName) { }

	// RVA: 0x1474008
	bool IsAdReady() { }

	// RVA: 0x14740C0
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x1473E9C
	void Dispose() { }

	// RVA: 0x14740C8
	void <.ctor>b__24_0(LevelPlayAdInfo info) { }

	// RVA: 0x14740E4
	void <.ctor>b__24_1(LevelPlayAdError error) { }

	// RVA: 0x1474100
	void <.ctor>b__24_2(LevelPlayAdInfo info) { }

	// RVA: 0x147411C
	void <.ctor>b__24_3(LevelPlayAdInfo info) { }

	// RVA: 0x1474138
	void <.ctor>b__24_4(LevelPlayAdInfo info) { }

	// RVA: 0x1474154
	void <.ctor>b__24_5(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x1474170
	void <.ctor>b__24_6(LevelPlayAdInfo info) { }

}

// Namespace: com.unity3d.mediation
public class LevelPlayReward 
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	private readonly int <Amount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x147418C
	string get_Name() { }

	// RVA: 0x1474194
	int get_Amount() { }

	// RVA: 0x147419C
	void .ctor(string name, int amount) { }

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

	// RVA: 0x14741E4
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474298
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147434C
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1474400
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14744B4
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474568
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147461C
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14746D0
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1474784
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1474838
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x14748EC
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14749A0
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474A54
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474B08
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474BBC
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474C70
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1474D24
	string get_AdUnitId() { }

	// RVA: 0x1474DDC
	void .ctor(string adUnitId) { }

	// RVA: 0x1475394
	void .ctor(IPlatformRewardedAd platformRewardedAd) { }

	// RVA: 0x14753C8
	void LoadAd() { }

	// RVA: 0x1475480
	void ShowAd(string placementName) { }

	// RVA: 0x1475538
	void DestroyAd() { }

	// RVA: 0x14756A0
	bool IsAdReady() { }

	// RVA: 0x1475758
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14755EC
	void Dispose() { }

	// RVA: 0x1475760
	void <.ctor>b__27_0(LevelPlayAdInfo info) { }

	// RVA: 0x147577C
	void <.ctor>b__27_1(LevelPlayAdError error) { }

	// RVA: 0x1475798
	void <.ctor>b__27_2(LevelPlayAdInfo info) { }

	// RVA: 0x14757B4
	void <.ctor>b__27_3(LevelPlayAdDisplayInfoError infoError) { }

	// RVA: 0x14757D0
	void <.ctor>b__27_4(LevelPlayAdInfo info, LevelPlayReward reward) { }

	// RVA: 0x14757EC
	void <.ctor>b__27_5(LevelPlayAdInfo info) { }

	// RVA: 0x1475808
	void <.ctor>b__27_6(LevelPlayAdInfo info) { }

	// RVA: 0x1475824
	void <.ctor>b__27_7(LevelPlayAdInfo info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0 
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x1476324
	void .ctor() { }

	// RVA: 0x14773A4
	void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0 
{
	// Fields
	public AndroidInterstitialAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x14765B4
	void .ctor() { }

	// RVA: 0x1477710
	void <ShowAd>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class AndroidInterstitialAd 
{
	// Fields
	private const string k_AndroidInterstitialClass = 5708572928;
	private const string k_AndroidLoadAdFunction = 5737081328;
	private const string k_AndroidShowAdFunction = 5737081280;
	private const string k_IsAdReadyFunction = 5737081232;
	private const string k_IsPlacementCappedStaticFunction = 5730727360;
	private const string k_ErrorDisposed = 5736314944;
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

	// RVA: 0x1475840
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14758F4
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14759A8
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1475A5C
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1475B10
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475BC4
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475C78
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475D2C
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475DE0
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475E94
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1475F48
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1475FFC
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x14760B0
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1476164
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1476218
	string get_AdUnitId() { }

	// RVA: 0x1476220
	void .ctor(string adUnitId) { }

	// RVA: 0x147632C
	void LoadAd() { }

	// RVA: 0x1476480
	void ShowAd(string placementName) { }

	// RVA: 0x14765BC
	bool IsAdReady() { }

	// RVA: 0x14766C8
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x14769B0
	void onAdLoaded(string adInfo) { }

	// RVA: 0x1476A3C
	void onAdLoadFailed(string error) { }

	// RVA: 0x1476AC8
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x1476B54
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1476C60
	void onAdClosed(string adInfo) { }

	// RVA: 0x1476CEC
	void onAdClicked(string adInfo) { }

	// RVA: 0x1476D78
	void onAdInfoChanged(string adInfo) { }

	// RVA: 0x1476E04
	void Dispose(bool disposing) { }

	// RVA: 0x1476EBC
	void Dispose() { }

	// RVA: 0x1476F5C
	void Finalize() { }

	// RVA: 0x147641C
	bool CheckDisposedAndLogError() { }

	// RVA: 0x1477030
	void <LoadAd>b__35_0(object state) { }

	// RVA: 0x14771A4
	void <IsAdReady>b__37_0(object state) { }

	// RVA: 0x1477350
	void <Dispose>b__46_0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0 
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string adUnitId; // 0x18

	// Methods

	// RVA: 0x14784E0
	void .ctor() { }

	// RVA: 0x1479640
	void <.ctor>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0 
{
	// Fields
	public AndroidRewardedAd <>4__this; // 0x10
	public string placementName; // 0x18

	// Methods

	// RVA: 0x1478770
	void .ctor() { }

	// RVA: 0x14799AC
	void <ShowAd>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class AndroidRewardedAd 
{
	// Fields
	private const string k_AndroidRewardedAdClass = 5708572288;
	private const string k_AndroidLoadAdFunction = 5737080896;
	private const string k_AndroidShowAdFunction = 5737080848;
	private const string k_IsAdReadyFunction = 5737080800;
	private const string k_IsPlacementCappedStaticFunction = 5730727232;
	private const string k_ErrorDisposed = 5736314368;
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

	// RVA: 0x1477894
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1477948
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14779FC
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1477AB0
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1477B64
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1477C18
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1477CCC
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1477D80
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1477E34
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1477EE8
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1477F9C
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1478050
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1478104
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14781B8
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147826C
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1478320
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14783D4
	string get_AdUnitId() { }

	// RVA: 0x14783DC
	void .ctor(string adUnitId) { }

	// RVA: 0x14784E8
	void LoadAd() { }

	// RVA: 0x147863C
	void ShowAd(string placementName) { }

	// RVA: 0x1478778
	bool IsAdReady() { }

	// RVA: 0x1478884
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x1478B6C
	void onAdLoaded(string adInfo) { }

	// RVA: 0x1478BF8
	void onAdLoadFailed(string error) { }

	// RVA: 0x1478C84
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x1478D10
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1478E1C
	void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x1478EFC
	void onAdClicked(string adInfo) { }

	// RVA: 0x1478F88
	void onAdClosed(string adInfo) { }

	// RVA: 0x1479014
	void onAdInfoChanged(string adInfo) { }

	// RVA: 0x14790A0
	void Dispose(bool disposing) { }

	// RVA: 0x1479158
	void Dispose() { }

	// RVA: 0x14791F8
	void Finalize() { }

	// RVA: 0x14785D8
	bool CheckDisposedAndLogError() { }

	// RVA: 0x14792CC
	void <LoadAd>b__38_0(object state) { }

	// RVA: 0x1479440
	void <IsAdReady>b__40_0(object state) { }

	// RVA: 0x14795EC
	void <Dispose>b__50_0(object state) { }

}

// Namespace: com.unity3d.mediation
internal interface IUnityInterstitialAdListener 
{
	// Methods

	// RVA: 0x2FE4574
	void onAdLoaded(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdLoadFailed(string error) { }

	// RVA: 0x2FE4574
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x2FE47D4
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x2FE4574
	void onAdClosed(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdClicked(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdInfoChanged(string adInfo) { }

}

// Namespace: com.unity3d.mediation
internal interface IUnityRewardedAdListener 
{
	// Methods

	// RVA: 0x2FE4574
	void onAdLoaded(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdLoadFailed(string error) { }

	// RVA: 0x2FE4574
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x2FE47D4
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x2FE4840
	void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x2FE4574
	void onAdClicked(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdClosed(string adInfo) { }

	// RVA: 0x2FE4574
	void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1479C14
	void .ctor() { }

	// RVA: 0x147A1B8
	void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x1479D00
	void .ctor() { }

	// RVA: 0x147A280
	void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1479DEC
	void .ctor() { }

	// RVA: 0x147A34C
	void <onAdDisplayed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string error; // 0x18
	public string adInfo; // 0x20

	// Methods

	// RVA: 0x1479EEC
	void .ctor() { }

	// RVA: 0x147A418
	void <onAdDisplayFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1479FD8
	void .ctor() { }

	// RVA: 0x147A4DC
	void <onAdClosed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147A0C4
	void .ctor() { }

	// RVA: 0x147A5A8
	void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public UnityInterstitialAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147A1B0
	void .ctor() { }

	// RVA: 0x147A674
	void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityInterstitialAdListener 
{
	// Fields
	private const string k_AndroidInterstitialListenerName = 5475812768;
	private readonly IUnityInterstitialAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x1477680
	void .ctor(IUnityInterstitialAdListener listener) { }

	// RVA: 0x1479B30
	void onAdLoaded(string adInfo) { }

	// RVA: 0x1479C1C
	void onAdLoadFailed(string error) { }

	// RVA: 0x1479D08
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x1479DF4
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x1479EF4
	void onAdClosed(string adInfo) { }

	// RVA: 0x1479FE0
	void onAdClicked(string adInfo) { }

	// RVA: 0x147A0CC
	void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147AED0
	void .ctor() { }

	// RVA: 0x147AED8
	void <onAdInfoChanged>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147A824
	void .ctor() { }

	// RVA: 0x147AFA4
	void <onAdLoaded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x147A910
	void .ctor() { }

	// RVA: 0x147B06C
	void <onAdLoadFailed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147A9FC
	void .ctor() { }

	// RVA: 0x147B138
	void <onAdDisplayed>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string error; // 0x18
	public string adInfo; // 0x20

	// Methods

	// RVA: 0x147AAFC
	void .ctor() { }

	// RVA: 0x147B204
	void <onAdDisplayFailed>b__0(object state) { }

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

	// RVA: 0x147AC0C
	void .ctor() { }

	// RVA: 0x147B2C8
	void <onAdRewarded>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147ACF8
	void .ctor() { }

	// RVA: 0x147B394
	void <onAdClicked>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public UnityRewardedAdListener <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147ADE4
	void .ctor() { }

	// RVA: 0x147B460
	void <onAdClosed>b__0(object state) { }

}

// Namespace: com.unity3d.mediation
internal class UnityRewardedAdListener 
{
	// Fields
	private const string k_AndroidRewardedAdListenerName = 5475812448;
	private readonly IUnityRewardedAdListener m_UnityListener; // 0x20

	// Methods

	// RVA: 0x147991C
	void .ctor(IUnityRewardedAdListener listener) { }

	// RVA: 0x147A740
	void onAdLoaded(string adInfo) { }

	// RVA: 0x147A82C
	void onAdLoadFailed(string error) { }

	// RVA: 0x147A918
	void onAdDisplayed(string adInfo) { }

	// RVA: 0x147AA04
	void onAdDisplayFailed(string error, string adInfo) { }

	// RVA: 0x147AB04
	void onAdRewarded(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x147AC14
	void onAdClicked(string adInfo) { }

	// RVA: 0x147AD00
	void onAdClosed(string adInfo) { }

	// RVA: 0x147ADEC
	void onAdInfoChanged(string adInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass48_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147C8F0
	void .ctor() { }

	// RVA: 0x147CFC0
	void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass49_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdError error; // 0x18

	// Methods

	// RVA: 0x147C9DC
	void .ctor() { }

	// RVA: 0x147CFFC
	void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass50_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147CAC8
	void .ctor() { }

	// RVA: 0x147D038
	void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass51_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147CBB4
	void .ctor() { }

	// RVA: 0x147D074
	void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x147CCF4
	void .ctor() { }

	// RVA: 0x147D0B0
	void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147CDE0
	void .ctor() { }

	// RVA: 0x147D0EC
	void <InvokeExpandedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147CECC
	void .ctor() { }

	// RVA: 0x147D128
	void <InvokeCollapsedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0 
{
	// Fields
	public iOSBannerAd <>4__this; // 0x10
	public LevelPlayAdInfo adInfo; // 0x18

	// Methods

	// RVA: 0x147CFB8
	void .ctor() { }

	// RVA: 0x147D164
	void <InvokeLeftApplicationEvent>b__0(object state) { }

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

	// RVA: 0x147B52C
	void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147B5E0
	void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147B694
	void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x147B748
	void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x147B7FC
	void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147B8B0
	void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147B964
	void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BA18
	void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BACC
	void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x147BB80
	void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x147BC34
	void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BCE8
	void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BD9C
	void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BE50
	void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BF04
	void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147BFB8
	void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147C06C
	string get_AdUnitId() { }

	// RVA: 0x147C074
	LevelPlayAdSize get_AdSize() { }

	// RVA: 0x147C07C
	string get_PlacementName() { }

	// RVA: 0x147C084
	LevelPlayBannerPosition get_Position() { }

	// RVA: 0x147C08C
	bool get_DisplayOnLoad() { }

	// RVA: 0x14717B0
	void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition bannerPosition, string placementName, bool displayOnLoad) { }

	// RVA: 0x147C520
	void PauseAutoRefresh() { }

	// RVA: 0x147C598
	void ResumeAutoRefresh() { }

	// RVA: 0x147C610
	void Load() { }

	// RVA: 0x147C7AC
	void DestroyAd() { }

	// RVA: 0x147C724
	void SetPosition() { }

	// RVA: 0x147C79C
	void ShowAd() { }

	// RVA: 0x147C7A4
	void HideAd() { }

	// RVA: 0x147C80C
	void InvokeLoadedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147C8F8
	void InvokeFailedLoadEvent(LevelPlayAdError error) { }

	// RVA: 0x147C9E4
	void InvokeClickedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147CAD0
	void InvokeDisplayedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147CBBC
	void InvokeFailedDisplayEvent(LevelPlayAdInfo adInfo, LevelPlayAdError error) { }

	// RVA: 0x147CCFC
	void InvokeExpandedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147CDE8
	void InvokeCollapsedEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147CED4
	void InvokeLeftApplicationEvent(LevelPlayAdInfo adInfo) { }

	// RVA: 0x147C094
	IntPtr BannerAdCreate(string adUnitId, string placementName, string description, int width, int height, int customWidth) { }

	// RVA: 0x147C51C
	void BannerAdSetDelegate(IntPtr bannerAdView, IntPtr bannerAdListener) { }

	// RVA: 0x147C720
	void BannerAdLoad(IntPtr bannerAdView) { }

	// RVA: 0x147C7FC
	void BannerAdDestroy(IntPtr bannerAdView) { }

	// RVA: 0x147C800
	void BannerAdSetPosition(IntPtr bannerAdView, int position) { }

	// RVA: 0x147C804
	void BannerAdViewShow(IntPtr bannerAdView) { }

	// RVA: 0x147C808
	void BannerAdViewHide(IntPtr bannerAdView) { }

	// RVA: 0x147C594
	void BannerAdPauseAutoRefresh(IntPtr bannerAdView) { }

	// RVA: 0x147C60C
	void BannerAdResumeAutoRefresh(IntPtr bannerAdView) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo 
{
	// Methods

	// RVA: 0x147DA60
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147DB04
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147DB18
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147DBD8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId 
{
	// Methods

	// RVA: 0x147DBE4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147DC88
	internal void Invoke(IntPtr bannerPtr, string errorPtr) { }

	// RVA: 0x147DC9C
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x147DD5C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo 
{
	// Methods

	// RVA: 0x147DD68
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147DE0C
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147DE20
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147DEE0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x147DEEC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147DF90
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147DFA4
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147E064
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x147E070
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147E114
	internal void Invoke(IntPtr bannerPtr, string adInfoJson, string errorPtr) { }

	// RVA: 0x147E128
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x147E1F8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidExpandAdWithAdInfo 
{
	// Methods

	// RVA: 0x147E204
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147E2A8
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147E2BC
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147E37C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCollapseAdWithAdInfo 
{
	// Methods

	// RVA: 0x147E388
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147E42C
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147E440
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147E500
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidLeaveAppWithAdInfo 
{
	// Methods

	// RVA: 0x147E50C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x147E5B0
	internal void Invoke(IntPtr bannerPtr, string adInfoJson) { }

	// RVA: 0x147E5C4
	internal IAsyncResult BeginInvoke(IntPtr bannerPtr, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x147E684
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x147C12C
	void .ctor(iOSBannerAd bannerAd) { }

	// RVA: 0x147D9FC
	void Dispose() { }

	// RVA: 0x147D924
	IntPtr LPMBannerAdViewDelegateCreate(IntPtr bannerAdPtr, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidClickWithAdInfo clicked, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidExpandAdWithAdInfo expanded, DidCollapseAdWithAdInfo collapsed, DidLeaveAppWithAdInfo leftApp) { }

	// RVA: 0x147DA5C
	void LPMBannerAdViewDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x147D1A0
	void LoadSuccess(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x147D274
	void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x147D360
	void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x147D44C
	void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x147D538
	void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x147D660
	void Expanded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x147D74C
	void Collapsed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x147D838
	void LeftApplication(IntPtr ptr, string adInfoJson) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x147FE78
	void .ctor() { }

	// RVA: 0x1480718
	void <InvokeLoadedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x1480014
	void .ctor() { }

	// RVA: 0x14807B4
	void <InvokeFailedLoadEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x148013C
	void .ctor() { }

	// RVA: 0x1480850
	void <InvokeClickedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1480264
	void .ctor() { }

	// RVA: 0x14808EC
	void <InvokeDisplayedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x1480428
	void .ctor() { }

	// RVA: 0x1480988
	void <InvokeFailedDisplayEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1480550
	void .ctor() { }

	// RVA: 0x14809C4
	void <InvokeClosedEvent>b__0(object state) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0 
{
	// Fields
	public IosInterstitialAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1480678
	void .ctor() { }

	// RVA: 0x1480A60
	void <InvokeOnAdInfoChangedEvent>b__0(object state) { }

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

	// RVA: 0x147E690
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147E744
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147E7F8
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x147E8AC
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x147E960
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147EA14
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147EAC8
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x147EB7C
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x147EC30
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147ECE4
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147ED98
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147EE4C
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147EF00
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147EFB4
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x147F068
	string get_AdUnitId() { }

	// RVA: 0x147F070
	void .ctor(string adUnitId) { }

	// RVA: 0x147F8FC
	void LoadAd() { }

	// RVA: 0x147FAD4
	void ShowAd(string placementName) { }

	// RVA: 0x147FB9C
	bool IsAdReady() { }

	// RVA: 0x147FC38
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x147FCA8
	void Dispose() { }

	// RVA: 0x147FD58
	void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x147FEF4
	void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x148001C
	void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x1480144
	void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x148026C
	void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x1480430
	void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x1480558
	void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x1480680
	void Finalize() { }

	// RVA: 0x147F198
	IntPtr InterstitialAdCreate(string adUnitId) { }

	// RVA: 0x147F8F8
	void InterstitialAdSetDelegate(IntPtr interstitialAd, IntPtr interstitialAdListener) { }

	// RVA: 0x147FAD0
	void InterstitialAdLoadAd(IntPtr interstitialAd) { }

	// RVA: 0x147FB64
	void InterstitialAdShowAd(IntPtr interstitialAd, string placementName) { }

	// RVA: 0x147FC1C
	bool InterstitialAdIsAdReady(IntPtr interstitialAd) { }

	// RVA: 0x147FC70
	bool InterstitialAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo 
{
	// Methods

	// RVA: 0x1481034
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481570
	internal void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x1481584
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1481644
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId 
{
	// Methods

	// RVA: 0x14810D8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481650
	internal void Invoke(IntPtr interstitialAd, string errorPtr) { }

	// RVA: 0x1481664
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x1481724
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x148117C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481730
	internal void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x1481744
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1481804
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x1481220
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481810
	internal void Invoke(IntPtr interstitialAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x1481824
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x14818F4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo 
{
	// Methods

	// RVA: 0x14812C4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481900
	internal void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x1481914
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x14819D4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo 
{
	// Methods

	// RVA: 0x1481368
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14819E0
	internal void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x14819F4
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1481AB4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo 
{
	// Methods

	// RVA: 0x148140C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1481AC0
	internal void Invoke(IntPtr interstitialAd, string adInfoJson) { }

	// RVA: 0x1481AD4
	internal IAsyncResult BeginInvoke(IntPtr interstitialAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1481B94
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x147F334
	void .ctor(IosInterstitialAd interstitialAd) { }

	// RVA: 0x14814B0
	IntPtr LPMInterstitialAdDelegateCreate(IntPtr interstitialAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x148156C
	void LPMInterstitialAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x1480AFC
	void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1480BB8
	void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x1480C74
	void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1480D30
	void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1480DEC
	void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x1480EBC
	void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1480F78
	void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
public class IosLevelPlaySdk 
{
	// Fields
	private static System.Action<com.unity3d.mediation.LevelPlayConfiguration> OnInitSuccess; // 0x0
	private static System.Action<com.unity3d.mediation.LevelPlayInitError> OnInitFailed; // 0x8

	// Methods

	// RVA: 0x1481BA0
	void add_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1481CB0
	void remove_OnInitSuccess(System.Action<com.unity3d.mediation.LevelPlayConfiguration> value) { }

	// RVA: 0x1481DC0
	void add_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1481ED4
	void remove_OnInitFailed(System.Action<com.unity3d.mediation.LevelPlayInitError> value) { }

	// RVA: 0x1481FE8
	void Awake() { }

	// RVA: 0x1482074
	void .cctor() { }

	// RVA: 0x1482078
	void Initialize(string appKey, string userId, LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14825D0
	void SetPauseGame(bool pause) { }

	// RVA: 0x14823A0
	string[] GetAdFormatArray(LevelPlayAdFormat[] adFormats) { }

	// RVA: 0x14824C4
	void LPMInitialize(string appKey, string userId, string[] adFormats) { }

	// RVA: 0x1482334
	void setPluginData(string pluginType, string pluginVersion, string pluginFrameworkVersion) { }

	// RVA: 0x1482650
	void LPMSetPauseGame(bool pause) { }

	// RVA: 0x1482654
	void OnInitializationSuccess(string configuration) { }

	// RVA: 0x1482724
	void OnInitializationFailed(string error) { }

	// RVA: 0x14827F4
	void .ctor() { }

}

// Namespace: com.unity3d.mediation
public abstract class IosNativeObject 
{
	// Fields
	private static System.Collections.Concurrent.ConcurrentDictionary<System.IntPtr,com.unity3d.mediation.IosNativeObject> s_Objects; // 0x0
	private IntPtr m_NativePtr; // 0x10
	private readonly bool m_UsesCallbacks; // 0x18

	// Methods

	// RVA: 0x147F16C
	void .ctor(bool usesCallbacks) { }

	// RVA: 0x14827FC
	IntPtr get_NativePtr() { }

	// RVA: 0x147F1CC
	void set_NativePtr(IntPtr value) { }

	// RVA: 0x309AF8C
	T Get(IntPtr ptr) { }

	// RVA: 0x147FD14
	void Dispose() { }

	// RVA: 0x147F96C
	bool CheckDisposedAndLogError(string message) { }

	// RVA: 0x1482804
	void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1483F78
	void .ctor() { }

	// RVA: 0x14848F0
	void <InvokeLoadedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass35_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string error; // 0x18

	// Methods

	// RVA: 0x14840A0
	void .ctor() { }

	// RVA: 0x148498C
	void <InvokeFailedLoadEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass36_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x14841C8
	void .ctor() { }

	// RVA: 0x1484A28
	void <InvokeDisplayedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass37_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public LevelPlayAdDisplayInfoError errorInfo; // 0x18

	// Methods

	// RVA: 0x148438C
	void .ctor() { }

	// RVA: 0x1484AC4
	void <InvokeFailedDisplayEvent>b__0(object _) { }

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

	// RVA: 0x14844D8
	void .ctor() { }

	// RVA: 0x1484B00
	void <InvokeRewardedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1484600
	void .ctor() { }

	// RVA: 0x1484BE4
	void <InvokeClickedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass40_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1484728
	void .ctor() { }

	// RVA: 0x1484C80
	void <InvokeClosedEvent>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0 
{
	// Fields
	public IosRewardedAd <>4__this; // 0x10
	public string adInfo; // 0x18

	// Methods

	// RVA: 0x1484850
	void .ctor() { }

	// RVA: 0x1484D1C
	void <InvokeOnAdInfoChangedEvent>b__0(object _) { }

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

	// RVA: 0x14828A0
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1482954
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1482A08
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1482ABC
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1482B70
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1482C24
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1482CD8
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1482D8C
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1482E40
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1482EF4
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1482FA8
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x148305C
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1483110
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14831C4
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1483278
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x148332C
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14833E0
	string get_AdUnitId() { }

	// RVA: 0x14833E8
	void .ctor(string adUnitId) { }

	// RVA: 0x1483BA4
	void LoadAd() { }

	// RVA: 0x1483C18
	void ShowAd(string placementName) { }

	// RVA: 0x1483CE0
	bool IsAdReady() { }

	// RVA: 0x1483D7C
	bool IsPlacementCapped(string placementName) { }

	// RVA: 0x1483DEC
	void Dispose() { }

	// RVA: 0x1483E58
	void InvokeLoadedEvent(string adInfo) { }

	// RVA: 0x1483F80
	void InvokeFailedLoadEvent(string error) { }

	// RVA: 0x14840A8
	void InvokeDisplayedEvent(string adInfo) { }

	// RVA: 0x14841D0
	void InvokeFailedDisplayEvent(string adInfo, string error) { }

	// RVA: 0x1484394
	void InvokeRewardedEvent(string adInfo, string rewardName, int rewardAmount) { }

	// RVA: 0x14844E0
	void InvokeClickedEvent(string adInfo) { }

	// RVA: 0x1484608
	void InvokeClosedEvent(string adInfo) { }

	// RVA: 0x1484730
	void InvokeOnAdInfoChangedEvent(string adInfo) { }

	// RVA: 0x1484858
	void Finalize() { }

	// RVA: 0x14834E4
	IntPtr RewardedAdCreate(string adUnitId) { }

	// RVA: 0x1483BA0
	void RewardedAdSetDelegate(IntPtr rewardedAd, IntPtr rewardedAdListener) { }

	// RVA: 0x1483C14
	void RewardedAdLoadAd(IntPtr rewardedAd) { }

	// RVA: 0x1483CA8
	void RewardedAdShowAd(IntPtr rewardedAd, string placementName) { }

	// RVA: 0x1483D60
	bool RewardedAdIsAdReady(IntPtr rewardedAd) { }

	// RVA: 0x1483DB4
	bool RewardedAdIsPlacementCapped(string placementName) { }

}

// Namespace: 
private sealed class DidLoadAdWithAdInfo 
{
	// Methods

	// RVA: 0x14853C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14859C4
	internal void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x14859D8
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1485A98
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToLoadAdWithAdUnitId 
{
	// Methods

	// RVA: 0x148546C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485AA4
	internal void Invoke(IntPtr rewardedAd, string errorPtr) { }

	// RVA: 0x1485AB8
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x1485B78
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x1485510
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485B84
	internal void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x1485B98
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1485C58
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidFailToDisplayWithAdInfo 
{
	// Methods

	// RVA: 0x14855B4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485C64
	internal void Invoke(IntPtr rewardedAd, string adInfoJson, string errorPtr) { }

	// RVA: 0x1485C78
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string errorPtr, AsyncCallback callback, object object) { }

	// RVA: 0x1485D48
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidAdRewardedWithAdInfo 
{
	// Methods

	// RVA: 0x1485658
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485D54
	internal void Invoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x1485D68
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, string rewardName, int rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x1485E60
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidClickWithAdInfo 
{
	// Methods

	// RVA: 0x14856FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485E6C
	internal void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x1485E80
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1485F40
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidCloseWithAdInfo 
{
	// Methods

	// RVA: 0x14857A0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1485F4C
	internal void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x1485F60
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1486020
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class DidChangeAdInfo 
{
	// Methods

	// RVA: 0x1485844
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148602C
	internal void Invoke(IntPtr rewardedAd, string adInfoJson) { }

	// RVA: 0x1486040
	internal IAsyncResult BeginInvoke(IntPtr rewardedAd, string adInfoJson, AsyncCallback callback, object object) { }

	// RVA: 0x1486100
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x1483518
	void .ctor(IosRewardedAd rewardedAd) { }

	// RVA: 0x14858E8
	IntPtr LPMRewardedAdDelegateCreate(IntPtr rewardedAd, DidLoadAdWithAdInfo loadSuccess, DidFailToLoadAdWithAdUnitId loadFailed, DidDisplayWithAdInfo displayed, DidFailToDisplayWithAdInfo displayFailed, DidAdRewardedWithAdInfo rewarded, DidClickWithAdInfo clicked, DidCloseWithAdInfo closed, DidChangeAdInfo adInfoChanged) { }

	// RVA: 0x14859C0
	void LPMRewardedAdDelegateDestroy(IntPtr delegatePtr) { }

	// RVA: 0x1484DB8
	void Loaded(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1484E74
	void LoadFailed(IntPtr ptr, string errorPtr) { }

	// RVA: 0x1484F30
	void Displayed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1484FEC
	void DisplayFailed(IntPtr ptr, string adInfoJson, string errorPtr) { }

	// RVA: 0x14850BC
	void Rewarded(IntPtr ptr, string adInfoJson, string rewardName, int rewardAmount) { }

	// RVA: 0x1485194
	void Clicked(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x1485250
	void Closed(IntPtr ptr, string adInfoJson) { }

	// RVA: 0x148530C
	void AdInfoChanged(IntPtr ptr, string adInfoJson) { }

}

// Namespace: com.unity3d.mediation
internal interface IPlatformBannerAd 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE360C
	string get_AdUnitId() { }

	// RVA: 0x2FE360C
	LevelPlayAdSize get_AdSize() { }

	// RVA: 0x2FE360C
	string get_PlacementName() { }

	// RVA: 0x2FE32D4
	LevelPlayBannerPosition get_Position() { }

	// RVA: 0x2FE41A8
	void Load() { }

	// RVA: 0x2FE41A8
	void DestroyAd() { }

	// RVA: 0x2FE41A8
	void ShowAd() { }

	// RVA: 0x2FE41A8
	void HideAd() { }

	// RVA: 0x2FE41A8
	void PauseAutoRefresh() { }

	// RVA: 0x2FE41A8
	void ResumeAutoRefresh() { }

}

// Namespace: com.unity3d.mediation
internal interface IPlatformInterstitialAd 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE360C
	string get_AdUnitId() { }

	// RVA: 0x2FE41A8
	void LoadAd() { }

	// RVA: 0x2FE4574
	void ShowAd(string placementName) { }

	// RVA: 0x2FE3054
	bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
internal interface IPlatformRewardedAd 
{
	// Methods

	// RVA: 0x2FE4574
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x2FE4574
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE4574
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x2FE360C
	string get_AdUnitId() { }

	// RVA: 0x2FE41A8
	void LoadAd() { }

	// RVA: 0x2FE4574
	void ShowAd(string placementName) { }

	// RVA: 0x2FE3054
	bool IsAdReady() { }

}

// Namespace: com.unity3d.mediation
internal static class ThreadUtil 
{
	// Fields
	internal static SynchronizationContext UnitySynchronizationContext; // 0x0

	// Methods

	// RVA: 0x148610C
	void Init() { }

	// RVA: 0x147FE80
	void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x148616C
	void Send(SendOrPostCallback d, object state) { }

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

	// RVA: 0x14861E0
	void .ctor(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId) { }

	// RVA: 0x1486240
	void add_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14862F4
	void remove_OnAdLoaded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14863A8
	void add_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x148645C
	void remove_OnAdLoadFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1486510
	void add_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14865C4
	void remove_OnAdClicked(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486678
	void add_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x148672C
	void remove_OnAdDisplayed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14867E0
	void add_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1486894
	void remove_OnAdDisplayFailed(System.EventHandler<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1486948
	void add_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14869FC
	void remove_OnAdExpanded(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486AB0
	void add_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486B64
	void remove_OnAdCollapsed(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486C18
	void add_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486CCC
	void remove_OnAdLeftApplication(System.EventHandler<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486D80
	LevelPlayBannerPosition get_Position() { }

	// RVA: 0x1486D88
	void Load() { }

	// RVA: 0x1486D8C
	void DestroyAd() { }

	// RVA: 0x1486D90
	void ShowAd() { }

	// RVA: 0x1486D94
	void HideAd() { }

	// RVA: 0x1486D98
	void PauseAutoRefresh() { }

	// RVA: 0x1486D9C
	void ResumeAutoRefresh() { }

	// RVA: 0x1486DA0
	void SetAutoRefresh(bool flag) { }

	// RVA: 0x1486DA4
	void Dispose() { }

	// RVA: 0x1486DA8
	string get_AdUnitId() { }

	// RVA: 0x1486DB0
	LevelPlayAdSize get_AdSize() { }

	// RVA: 0x1486DB8
	LevelPlayAdSize get_Size() { }

	// RVA: 0x1486DC0
	string get_PlacementName() { }

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

	// RVA: 0x1486DC8
	void Dispose() { }

	// RVA: 0x1486DCC
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486E80
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1486F34
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1486FE8
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x148709C
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487150
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487204
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14872B8
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x148736C
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487420
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14874D4
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1487588
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x148763C
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14876F0
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14877A4
	string get_AdUnitId() { }

	// RVA: 0x14877AC
	void .ctor(string adUnitId) { }

	// RVA: 0x14877B4
	void LoadAd() { }

	// RVA: 0x14877B8
	void ShowAd(string placementName) { }

	// RVA: 0x14877BC
	bool IsAdReady() { }

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

	// RVA: 0x14877C4
	void Dispose() { }

	// RVA: 0x14877C8
	void add_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x148787C
	void remove_OnAdLoaded(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487930
	void add_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x14879E4
	void remove_OnAdLoadFailed(System.Action<com.unity3d.mediation.LevelPlayAdError> value) { }

	// RVA: 0x1487A98
	void add_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487B4C
	void remove_OnAdDisplayed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487C00
	void add_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1487CB4
	void remove_OnAdDisplayFailed(System.Action<com.unity3d.mediation.LevelPlayAdDisplayInfoError> value) { }

	// RVA: 0x1487D68
	void add_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1487E1C
	void remove_OnAdRewarded(System.Action<com.unity3d.mediation.LevelPlayAdInfo,com.unity3d.mediation.LevelPlayReward> value) { }

	// RVA: 0x1487ED0
	void add_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1487F84
	void remove_OnAdClicked(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1488038
	void add_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14880EC
	void remove_OnAdClosed(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x14881A0
	void add_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1488254
	void remove_OnAdInfoChanged(System.Action<com.unity3d.mediation.LevelPlayAdInfo> value) { }

	// RVA: 0x1488308
	string get_AdUnitId() { }

	// RVA: 0x1488310
	void .ctor(string adUnitId) { }

	// RVA: 0x1488318
	void LoadAd() { }

	// RVA: 0x148831C
	void ShowAd(string placementName) { }

	// RVA: 0x1488320
	bool IsAdReady() { }

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


