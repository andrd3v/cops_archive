// Namespace: 
internal class <Module> 
{}

// Namespace: GoogleMobileAds.iOS
internal class AdErrorClient 
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9C1714
	void .ctor(IntPtr error) { }

	// RVA: 0x9C1740
	int GetCode() { }

	// RVA: 0x9C174C
	string GetDomain() { }

	// RVA: 0x9C17B8
	string GetMessage() { }

	// RVA: 0x9C1824
	IAdErrorClient GetCause() { }

	// RVA: 0x9C189C
	string ToString() { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdInspectorErrorClient 
{
	// Methods

	// RVA: 0x9C1908
	void .ctor(IntPtr error) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback 
{
	// Methods

	// RVA: 0x9C37E0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5AE8
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9C5AFC
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C5BB8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback 
{
	// Methods

	// RVA: 0x9C3884
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5BC4
	internal void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9C5BD8
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9C5CA4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback 
{
	// Methods

	// RVA: 0x9C3928
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5CB0
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9C5CC4
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C5D80
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback 
{
	// Methods

	// RVA: 0x9C39CC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5D8C
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9C5DA0
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C5E5C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback 
{
	// Methods

	// RVA: 0x9C3A70
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5E68
	internal void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9C5E7C
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9C5F94
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback 
{
	// Methods

	// RVA: 0x9C3B14
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C5FA0
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9C5FB4
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C6070
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback 
{
	// Methods

	// RVA: 0x9C3BB8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C607C
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9C6090
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C614C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUAdViewAppEventCallback 
{
	// Methods

	// RVA: 0x9C3C5C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C6158
	internal void Invoke(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9C616C
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0x9C623C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class AdManagerBannerClient 
{
	// Fields
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x10
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x18
	private System.EventHandler<System.EventArgs> OnAdOpening; // 0x20
	private System.EventHandler<System.EventArgs> OnAdClosed; // 0x28
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x30
	private System.Action<GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent; // 0x38
	private Action OnAdClicked; // 0x40
	private Action OnAdImpressionRecorded; // 0x48
	private System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> _validAdSizes; // 0x50
	private IntPtr _bannerViewPtr; // 0x58
	private IntPtr _bannerClientPtr; // 0x60
	private static GADUAdViewDidReceiveAdCallback <>f__mg$cache0; // 0x0
	private static GADUAdViewDidFailToReceiveAdWithErrorCallback <>f__mg$cache1; // 0x8
	private static GADUAdViewWillPresentScreenCallback <>f__mg$cache2; // 0x10
	private static GADUAdViewDidDismissScreenCallback <>f__mg$cache3; // 0x18
	private static GADUAdViewPaidEventCallback <>f__mg$cache4; // 0x20
	private static GADUAdViewImpressionCallback <>f__mg$cache5; // 0x28
	private static GADUAdViewClickCallback <>f__mg$cache6; // 0x30
	private static GAMUAdViewAppEventCallback <>f__mg$cache7; // 0x38
	private static GADUAdViewDidReceiveAdCallback <>f__mg$cache8; // 0x40
	private static GADUAdViewDidFailToReceiveAdWithErrorCallback <>f__mg$cache9; // 0x48
	private static GADUAdViewWillPresentScreenCallback <>f__mg$cacheA; // 0x50
	private static GADUAdViewDidDismissScreenCallback <>f__mg$cacheB; // 0x58
	private static GADUAdViewPaidEventCallback <>f__mg$cacheC; // 0x60
	private static GADUAdViewImpressionCallback <>f__mg$cacheD; // 0x68
	private static GADUAdViewClickCallback <>f__mg$cacheE; // 0x70
	private static GAMUAdViewAppEventCallback <>f__mg$cacheF; // 0x78

	// Methods

	// RVA: 0x9C2164
	void .ctor() { }

	// RVA: 0x9C216C
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C2220
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C22D4
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9C2388
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9C243C
	void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C24F0
	void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C25A4
	void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C2658
	void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C270C
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9C27C0
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9C2874
	void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9C2928
	void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9C29DC
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9C2A80
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9C2B24
	void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9C2BC8
	void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9C2C6C
	System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> get_ValidAdSizes() { }

	// RVA: 0x9C2C74
	void set_ValidAdSizes(System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> value) { }

	// RVA: 0x9C2E80
	IntPtr get_BannerViewPtr() { }

	// RVA: 0x9C2E88
	void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0x9C2EB8
	void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0x9C3DD8
	void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0x9C4714
	void LoadAd(AdRequest request) { }

	// RVA: 0x9C5708
	void ShowBannerView() { }

	// RVA: 0x9C5714
	void HideBannerView() { }

	// RVA: 0x9C5720
	void DestroyBannerView() { }

	// RVA: 0x9C5754
	string GetAdUnitID() { }

	// RVA: 0x9C57C0
	float GetHeightInPixels() { }

	// RVA: 0x9C57CC
	float GetWidthInPixels() { }

	// RVA: 0x9C57D8
	void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9C57E4
	void SetPosition(int x, int y) { }

	// RVA: 0x9C57F0
	bool IsCollapsible() { }

	// RVA: 0x9C582C
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9C58FC
	void Dispose() { }

	// RVA: 0x9C5950
	void Finalize() { }

	// RVA: 0x9C1934
	void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0x9C1A3C
	void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9C1B8C
	void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9C1C94
	void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9C1D9C
	void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9C1ED4
	void AdViewAppEventCallback(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9C1FFC
	void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9C20B0
	void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9C5A10
	AdManagerBannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback 
{
	// Methods

	// RVA: 0x9C8124
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C8CB4
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9C8CC8
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C8D84
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback 
{
	// Methods

	// RVA: 0x9C81C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C8D90
	internal void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9C8DA4
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9C8E70
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback 
{
	// Methods

	// RVA: 0x9C85A0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C8E7C
	internal void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9C8E90
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9C8FA8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUInterstitialAppEventCallback 
{
	// Methods

	// RVA: 0x9C8644
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C8FB4
	internal void Invoke(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0x9C8FC8
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0x9C9098
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9C8310
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C90A4
	internal void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9C90B8
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9C9184
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9C826C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C9190
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9C91A4
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C9260
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9C83B4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C926C
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9C9280
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C933C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9C8458
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C9348
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9C935C
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C9418
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9C84FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9C9424
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9C9438
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9C94F4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class AdManagerInterstitialClient 
{
	// Fields
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x10
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x18
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x20
	private System.Action<GoogleMobileAds.Api.AdManager.AppEvent> OnAppEvent; // 0x28
	private System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent; // 0x30
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x38
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x48
	private Action OnAdClicked; // 0x50
	private IntPtr _interstitialClientPtr; // 0x58
	private IntPtr _interstitialPtr; // 0x60
	private static GADUInterstitialAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADUInterstitialAdFailedToLoadCallback <>f__mg$cache1; // 0x8
	private static GADUInterstitialAdWillPresentFullScreenContentCallback <>f__mg$cache2; // 0x10
	private static GADUInterstitialAdFailedToPresentFullScreenContentCallback <>f__mg$cache3; // 0x18
	private static GADUInterstitialAdDidDismissFullScreenContentCallback <>f__mg$cache4; // 0x20
	private static GADUInterstitialAdDidRecordImpressionCallback <>f__mg$cache5; // 0x28
	private static GADUInterstitialAdDidRecordClickCallback <>f__mg$cache6; // 0x30
	private static GADUInterstitialPaidEventCallback <>f__mg$cache7; // 0x38
	private static GAMUInterstitialAppEventCallback <>f__mg$cache8; // 0x40

	// Methods

	// RVA: 0x9C6C1C
	void .ctor() { }

	// RVA: 0x9C6C24
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C6CD8
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C6D8C
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9C6E40
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9C6EF4
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9C6FA8
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9C705C
	void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9C7110
	void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9C71C4
	void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9C7278
	void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9C732C
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C73E0
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C7494
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C7548
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C75FC
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C76B0
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9C7764
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9C7808
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9C78AC
	IntPtr get_InterstitialPtr() { }

	// RVA: 0x9C78B4
	void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0x9C78E0
	void CreateInterstitialAd() { }

	// RVA: 0x9C87CC
	bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9C8840
	IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0x9C888C
	IAdManagerInterstitialClient PollAdManagerAd(string adUnitId) { }

	// RVA: 0x9C8910
	void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9C89C8
	void Show() { }

	// RVA: 0x9C89D4
	string GetAdUnitID() { }

	// RVA: 0x9C8A40
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9C8AB4
	void DestroyInterstitial() { }

	// RVA: 0x9C8ADC
	void Dispose() { }

	// RVA: 0x9C8B3C
	void Finalize() { }

	// RVA: 0x9C6248
	void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0x9C6350
	void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9C64A0
	void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9C65D8
	void InterstitialAppEventCallback(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0x9C6700
	void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9C6850
	void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9C6958
	void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9C6A60
	void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0x9C6B68
	void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0x9C8C08
	AdManagerInterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdapterResponseInfoClient 
{
	// Fields
	private IntPtr _adapterResponseInfoPtr; // 0x10

	// Methods

	// RVA: 0x9C9500
	void .ctor(IntPtr adapterResponseInfoPtr) { }

	// RVA: 0x9C952C
	string get_AdapterClassName() { }

	// RVA: 0x9C9598
	string get_AdSourceId() { }

	// RVA: 0x9C9604
	string get_AdSourceName() { }

	// RVA: 0x9C9670
	string get_AdSourceInstanceId() { }

	// RVA: 0x9C96DC
	string get_AdSourceInstanceName() { }

	// RVA: 0x9C9748
	Int64 get_LatencyMillis() { }

	// RVA: 0x9C9754
	System.Collections.Generic.Dictionary<System.String,System.String> get_AdUnitMapping() { }

	// RVA: 0x9C9978
	IAdErrorClient get_AdError() { }

	// RVA: 0x9C99FC
	string ToString() { }

}

// Namespace: 
internal sealed class GADUAppOpenAdLoadedCallback 
{
	// Methods

	// RVA: 0x9CB5FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC084
	internal void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9CC098
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9CC154
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailToLoadCallback 
{
	// Methods

	// RVA: 0x9CB6A0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC160
	internal void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9CC174
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9CC240
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdPaidEventCallback 
{
	// Methods

	// RVA: 0x9CB744
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC24C
	internal void Invoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9CC260
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9CC378
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailedToPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9CB7E8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC384
	internal void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9CC398
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9CC464
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdWillPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9CB88C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC470
	internal void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9CC484
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9CC540
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidDismissFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9CB930
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC54C
	internal void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9CC560
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9CC61C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9CB9D4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC628
	internal void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9CC63C
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9CC6F8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9CBA78
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9CC704
	internal void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9CC718
	internal IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9CC7D4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class AppOpenAdClient 
{
	// Fields
	private IntPtr appOpenAdPtr; // 0x10
	private IntPtr appOpenAdClientPtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x30
	private System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent; // 0x38
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x48
	private Action OnAdClicked; // 0x50
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x58
	private static GADUAppOpenAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADUAppOpenAdFailToLoadCallback <>f__mg$cache1; // 0x8
	private static GADUAppOpenAdPaidEventCallback <>f__mg$cache2; // 0x10
	private static GADUAppOpenAdFailedToPresentFullScreenContentCallback <>f__mg$cache3; // 0x18
	private static GADUAppOpenAdWillPresentFullScreenContentCallback <>f__mg$cache4; // 0x20
	private static GADUAppOpenAdDidDismissFullScreenContentCallback <>f__mg$cache5; // 0x28
	private static GADUAppOpenAdDidRecordImpressionCallback <>f__mg$cache6; // 0x30
	private static GADUAppOpenAdDidRecordClickCallback <>f__mg$cache7; // 0x38

	// Methods

	// RVA: 0x9CA314
	void .ctor() { }

	// RVA: 0x9CA31C
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CA3D0
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CA484
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9CA538
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9CA5EC
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9CA6A0
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9CA754
	void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9CA808
	void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9CA8BC
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CA970
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CAA24
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CAAD8
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CAB8C
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9CAC30
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9CACD4
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CAD88
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CAE3C
	IntPtr get_AppOpenAdPtr() { }

	// RVA: 0x9CAE44
	void set_AppOpenAdPtr(IntPtr value) { }

	// RVA: 0x9CAE70
	void CreateAppOpenAd() { }

	// RVA: 0x9CBBF4
	bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9CBC68
	IAppOpenAdClient PollAd(string adUnitId) { }

	// RVA: 0x9CBCEC
	void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9CBD98
	void Show() { }

	// RVA: 0x9CBDA4
	string GetAdUnitID() { }

	// RVA: 0x9CBE10
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9CBE84
	void DestroyAppOpenAd() { }

	// RVA: 0x9CBEAC
	void Dispose() { }

	// RVA: 0x9CBF0C
	void Finalize() { }

	// RVA: 0x9C9A68
	void AppOpenAdLoadedCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9C9B70
	void AppOpenAdFailedToLoadCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9C9CC0
	void AppOpenAdPaidEventCallback(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9C9DF8
	void AdFailedToPresentFullScreenContentCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9C9F48
	void AdWillPresentFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9CA050
	void AdDidDismissFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9CA158
	void AdDidRecordImpressionCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9CA260
	void AdDidRecordClickCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9CBFD8
	AppOpenAdClient IntPtrToAppOpenAdClient(IntPtr appOpenAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
public class ApplicationPreferencesClient 
{
	// Methods

	// RVA: 0x9CC7E0
	void .ctor() { }

	// RVA: 0x9CC7E8
	void SetInt(string key, int value) { }

	// RVA: 0x9CC84C
	void SetString(string key, string value) { }

	// RVA: 0x9CC8E0
	int GetInt(string key) { }

	// RVA: 0x9CC94C
	string GetString(string key) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback 
{
	// Methods

	// RVA: 0x9CE350
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D01B8
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9D01CC
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D0288
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback 
{
	// Methods

	// RVA: 0x9CE3F4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D0294
	internal void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9D02A8
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9D0374
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback 
{
	// Methods

	// RVA: 0x9CE498
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D0380
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9D0394
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D0450
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback 
{
	// Methods

	// RVA: 0x9CE53C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D045C
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9D0470
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D052C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback 
{
	// Methods

	// RVA: 0x9CE5E0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D0538
	internal void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9D054C
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9D0664
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback 
{
	// Methods

	// RVA: 0x9CE684
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D0670
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9D0684
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D0740
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback 
{
	// Methods

	// RVA: 0x9CE728
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D074C
	internal void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9D0760
	internal IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D081C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class BannerClient 
{
	// Fields
	private IntPtr bannerViewPtr; // 0x10
	private IntPtr bannerClientPtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.EventHandler<System.EventArgs> OnAdOpening; // 0x30
	private System.EventHandler<System.EventArgs> OnAdClosed; // 0x38
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x40
	private Action OnAdClicked; // 0x48
	private Action OnAdImpressionRecorded; // 0x50
	private static GADUAdViewDidReceiveAdCallback <>f__mg$cache0; // 0x0
	private static GADUAdViewDidFailToReceiveAdWithErrorCallback <>f__mg$cache1; // 0x8
	private static GADUAdViewWillPresentScreenCallback <>f__mg$cache2; // 0x10
	private static GADUAdViewDidDismissScreenCallback <>f__mg$cache3; // 0x18
	private static GADUAdViewPaidEventCallback <>f__mg$cache4; // 0x20
	private static GADUAdViewImpressionCallback <>f__mg$cache5; // 0x28
	private static GADUAdViewClickCallback <>f__mg$cache6; // 0x30
	private static GADUAdViewDidReceiveAdCallback <>f__mg$cache7; // 0x38
	private static GADUAdViewDidFailToReceiveAdWithErrorCallback <>f__mg$cache8; // 0x40
	private static GADUAdViewWillPresentScreenCallback <>f__mg$cache9; // 0x48
	private static GADUAdViewDidDismissScreenCallback <>f__mg$cacheA; // 0x50
	private static GADUAdViewPaidEventCallback <>f__mg$cacheB; // 0x58
	private static GADUAdViewImpressionCallback <>f__mg$cacheC; // 0x60
	private static GADUAdViewClickCallback <>f__mg$cacheD; // 0x68

	// Methods

	// RVA: 0x9CD0F0
	void .ctor() { }

	// RVA: 0x9CD0F8
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD1AC
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD260
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9CD314
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9CD3C8
	void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD47C
	void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD530
	void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD5E4
	void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9CD698
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9CD74C
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9CD800
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9CD8A4
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9CD948
	void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9CD9EC
	void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9CDA90
	IntPtr get_BannerViewPtr() { }

	// RVA: 0x9CDA98
	void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0x9CDAC4
	void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0x9CE888
	void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0x9CF134
	void LoadAd(AdRequest request) { }

	// RVA: 0x9CFE98
	void ShowBannerView() { }

	// RVA: 0x9CFEA0
	void HideBannerView() { }

	// RVA: 0x9CFEA8
	void DestroyBannerView() { }

	// RVA: 0x9CFED8
	string GetAdUnitID() { }

	// RVA: 0x9CFF44
	float GetHeightInPixels() { }

	// RVA: 0x9CFF4C
	float GetWidthInPixels() { }

	// RVA: 0x9CFF54
	void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9CFF5C
	void SetPosition(int x, int y) { }

	// RVA: 0x9CFF64
	bool IsCollapsible() { }

	// RVA: 0x9CFF84
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9CFFF8
	void Dispose() { }

	// RVA: 0x9D004C
	void Finalize() { }

	// RVA: 0x9CC9E8
	void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0x9CCAF0
	void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9CCC40
	void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9CCD48
	void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9CCE50
	void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9CCF88
	void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9CD03C
	void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9D010C
	BannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Externs 
{
	// Methods

	// RVA: 0x9D0828
	void .ctor() { }

	// RVA: 0x9D0830
	void GADUInitializeWithCallback(IntPtr mobileAdsClient, GADUInitializationCompleteCallback callback) { }

	// RVA: 0x9D085C
	void GADUPreloadWithCallback(IntPtr mobileAdsClient, IntPtr[] configurations, int configurationsCount, GADUAdAvailableCallback adAvailable, GADUAdsExhaustedCallback adsExhausted) { }

	// RVA: 0x9D08C4
	void GADUDisableMediationInitialization() { }

	// RVA: 0x9D08C8
	IntPtr GADUGetInitDescription(IntPtr status, string className) { }

	// RVA: 0x9D090C
	int GADUGetInitLatency(IntPtr status, string className) { }

	// RVA: 0x9D0950
	int GADUGetInitState(IntPtr status, string className) { }

	// RVA: 0x9D0994
	IntPtr GADUGetInitAdapterClasses(IntPtr status) { }

	// RVA: 0x9D0998
	int GADUGetInitNumberOfAdapterClasses(IntPtr status) { }

	// RVA: 0x9D099C
	void GADUSetApplicationVolume(float volume) { }

	// RVA: 0x9D09A0
	void GADUSetApplicationMuted(bool muted) { }

	// RVA: 0x9D09A4
	void GADUSetPlugin(string plugin) { }

	// RVA: 0x9D09CC
	void GADUSetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0x9D09D0
	void GADUDisableSDKCrashReporting() { }

	// RVA: 0x9D09D4
	float GADUDeviceScale() { }

	// RVA: 0x9D09D8
	int GADUDeviceSafeWidth() { }

	// RVA: 0x9CC81C
	void GADUSetIntegerPreference(string key, int value) { }

	// RVA: 0x9CC898
	void GADUSetStringPreference(string key, string value) { }

	// RVA: 0x9CC918
	int GADUGetIntegerPreference(string key) { }

	// RVA: 0x9CC99C
	string GADUGetStringPreference(string key) { }

	// RVA: 0x9D09DC
	IntPtr GADUCreateRequest() { }

	// RVA: 0x9D09E0
	IntPtr GAMUCreateRequest() { }

	// RVA: 0x9D09E4
	IntPtr GADUCreateMutableDictionary() { }

	// RVA: 0x9D09E8
	void GADUMutableDictionarySetValue(IntPtr mutableDictionaryPtr, string key, string value) { }

	// RVA: 0x9D0A44
	void GADUSetMediationExtras(IntPtr request, IntPtr mutableDictionaryPtr, string adNetworkExtrasClassName) { }

	// RVA: 0x9D0A8C
	void GADUAddKeyword(IntPtr request, string keyword) { }

	// RVA: 0x9D0AC4
	void GADUSetExtra(IntPtr request, string key, string value) { }

	// RVA: 0x9D0B20
	void GAMUSetPublisherProvidedID(IntPtr request, string publisherProvidedID) { }

	// RVA: 0x9D0B58
	void GAMUAddCategoryExclusion(IntPtr request, string category) { }

	// RVA: 0x9D0B90
	void GADUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0x9D0BEC
	void GAMUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0x9D0C48
	void GADUSetRequestAgent(IntPtr request, string requestAgent) { }

	// RVA: 0x9C2EB4
	void GADURelease(IntPtr obj) { }

	// RVA: 0x9D0C80
	IntPtr GADUCreatePreloadConfiguration() { }

	// RVA: 0x9D0C84
	string GADUGetPreloadConfigurationAdUnitID(IntPtr preloadConfiguration) { }

	// RVA: 0x9D0CB8
	void GADUSetPreloadConfigurationAdUnitID(IntPtr preloadConfiguration, string adUnitId) { }

	// RVA: 0x9D0CF0
	int GADUGetPreloadConfigurationAdFormat(IntPtr preloadConfiguration) { }

	// RVA: 0x9D0CF4
	void GADUSetPreloadConfigurationAdFormat(IntPtr preloadConfiguration, int adFormat) { }

	// RVA: 0x9D0CF8
	void GADUSetPreloadConfigurationAdRequest(IntPtr preloadConfiguration, IntPtr adRequest) { }

	// RVA: 0x9D0CFC
	UInt32 GADUGetPreloadConfigurationBufferSize(IntPtr preloadConfiguration) { }

	// RVA: 0x9D0D00
	void GADUSetPreloadConfigurationBufferSize(IntPtr preloadConfiguration, UInt32 bufferSize) { }

	// RVA: 0x9D0D04
	string GADUMobileAdsVersion() { }

	// RVA: 0x9D0D38
	IntPtr GADUCreateRequestConfiguration() { }

	// RVA: 0x9D0D3C
	void GADUSetRequestConfiguration(IntPtr requestConfiguration) { }

	// RVA: 0x9D0D40
	void GADUSetRequestConfigurationTestDeviceIdentifiers(IntPtr requestConfiguration, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0x9D0E1C
	void GADUSetRequestConfigurationMaxAdContentRating(IntPtr requestConfiguration, string maxAdContentRating) { }

	// RVA: 0x9D0E54
	void GADUSetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration, int tagForUnderAgeOfConsent) { }

	// RVA: 0x9D0E58
	void GADUSetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration, int tagForChildDirectedTreatment) { }

	// RVA: 0x9D0E5C
	void GADUSetRequestConfigurationPublisherFirstPartyIDEnabled(bool enabled) { }

	// RVA: 0x9D0E60
	void GADUSetRequestConfigurationPublisherPrivacyPersonalizationState(int state) { }

	// RVA: 0x9D0E64
	IntPtr GADUGetTestDeviceIdentifiers(IntPtr request) { }

	// RVA: 0x9D0E68
	int GADUGetTestDeviceIdentifiersCount(IntPtr request) { }

	// RVA: 0x9D0E6C
	string GADUGetMaxAdContentRating(IntPtr requestConfiguration) { }

	// RVA: 0x9D0EA0
	int GADUGetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration) { }

	// RVA: 0x9D0EA4
	int GADUGetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration) { }

	// RVA: 0x9D0EA8
	int GADUGetRequestConfigurationPublisherPrivacyPersonalizationState() { }

	// RVA: 0x9D0EAC
	IntPtr GADUCreateUIColor(float alpha, float red, float green, float blue) { }

	// RVA: 0x9D0EB0
	IntPtr GADUCreateVideoOptions(bool startMuted, bool clickToExpandRequested, bool customControlsRequested) { }

	// RVA: 0x9CB5F8
	IntPtr GADUCreateAppOpenAd(IntPtr appOpenAdClient) { }

	// RVA: 0x9CBD50
	void GADULoadAppOpenAdWithAdUnitID(IntPtr appOpenAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9CBC30
	bool GADUAppOpenIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0x9CBCB4
	void GADUAppOpenPreloadedAdWithAdUnitID(IntPtr appOpenAd, string adUnitId) { }

	// RVA: 0x9CBDA0
	void GADUShowAppOpenAd(IntPtr appOpenAd) { }

	// RVA: 0x9CBB1C
	void GADUSetAppOpenAdCallbacks(IntPtr appOpenAd, GADUAppOpenAdLoadedCallback adLoadedCallback, GADUAppOpenAdFailToLoadCallback adFailedToLoadCallback, GADUAppOpenAdPaidEventCallback paidEventCallback, GADUAppOpenAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUAppOpenAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUAppOpenAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUAppOpenAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUAppOpenAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0x9CBDDC
	string GADUGetAppOpenAdUnitID(IntPtr appOpenAd) { }

	// RVA: 0x9CE2E4
	IntPtr GADUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int positionAtTop) { }

	// RVA: 0x9CF0C0
	IntPtr GADUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0x9CE224
	IntPtr GADUCreateSmartBannerView(IntPtr bannerClient, string adUnitId, int positionAtTop) { }

	// RVA: 0x9CEFF0
	IntPtr GADUCreateSmartBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int x, int y) { }

	// RVA: 0x9CE278
	IntPtr GADUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int positionAtTop) { }

	// RVA: 0x9CF04C
	IntPtr GADUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0x9CE7CC
	void GADUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback) { }

	// RVA: 0x9C571C
	void GADUHideBannerView(IntPtr bannerView) { }

	// RVA: 0x9C5710
	void GADUShowBannerView(IntPtr bannerView) { }

	// RVA: 0x9C5750
	void GADURemoveBannerView(IntPtr bannerView) { }

	// RVA: 0x9C5704
	void GADURequestBannerAd(IntPtr bannerView, IntPtr request) { }

	// RVA: 0x9CFF10
	string GADUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9C57C8
	float GADUGetBannerViewHeightInPixels(IntPtr bannerView) { }

	// RVA: 0x9C57D4
	float GADUGetBannerViewWidthInPixels(IntPtr bannerView) { }

	// RVA: 0x9C57E0
	void GADUSetBannerViewAdPosition(IntPtr bannerView, int position) { }

	// RVA: 0x9C57EC
	void GADUSetBannerViewCustomPosition(IntPtr bannerView, int x, int y) { }

	// RVA: 0x9C5810
	bool GADUIsBannerViewCollapsible(IntPtr bannerView) { }

	// RVA: 0x9D0EB4
	IntPtr GADUGetResponseInfo(IntPtr adFormat) { }

	// RVA: 0x9D0EB8
	string GADUResponseInfoMediationAdapterClassName(IntPtr responseInfo) { }

	// RVA: 0x9D0EEC
	string GADUResponseInfoResponseId(IntPtr responseInfo) { }

	// RVA: 0x9D0F20
	string GADUGetResponseInfoDescription(IntPtr responseInfo) { }

	// RVA: 0x9D0F54
	int GADUResponseInfoAdNetworkCount(IntPtr responseInfo) { }

	// RVA: 0x9D0F58
	IntPtr GADUResponseInfoAdNetworkAtIndex(IntPtr responseInfo, int index) { }

	// RVA: 0x9D0F5C
	IntPtr GADUResponseInfoLoadedAdNetworkResponseInfo(IntPtr responseInfo) { }

	// RVA: 0x9D0F60
	int GADUResponseInfoExtrasCount(IntPtr responseInfo) { }

	// RVA: 0x9D0F64
	string GADUResponseInfoExtrasKey(IntPtr responseInfo, int index) { }

	// RVA: 0x9D0F98
	string GADUResponseInfoExtrasValue(IntPtr responseInfo, string key) { }

	// RVA: 0x9C1748
	int GADUGetAdErrorCode(IntPtr error) { }

	// RVA: 0x9C1784
	string GADUGetAdErrorDomain(IntPtr error) { }

	// RVA: 0x9C17F0
	string GADUGetAdErrorMessage(IntPtr error) { }

	// RVA: 0x9C1898
	IntPtr GADUGetAdErrorUnderLyingError(IntPtr error) { }

	// RVA: 0x9D0FF4
	IntPtr GADUGetAdErrorResponseInfo(IntPtr error) { }

	// RVA: 0x9C18D4
	string GADUGetAdErrorDescription(IntPtr error) { }

	// RVA: 0x9C3774
	IntPtr GAMUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int adPosition) { }

	// RVA: 0x9C46A0
	IntPtr GAMUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0x9C3708
	IntPtr GAMUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int adPosition) { }

	// RVA: 0x9C462C
	IntPtr GAMUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0x9C578C
	string GAMUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9C3D00
	void GAMUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback, GAMUAdViewAppEventCallback appEventCallback) { }

	// RVA: 0x9C2E70
	void GAMUBannerViewSetValidAdSizes(IntPtr bannerView, int[] validAdSizesArray, int validAdSizesLength) { }

	// RVA: 0x9D0FF8
	IntPtr GADUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0x9D0FFC
	bool GADUInterstitialIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0x9D1034
	void GADUInterstitialPreloadedAdWithAdUnitID(IntPtr interstitialAd, string adUnitId) { }

	// RVA: 0x9D106C
	IntPtr GADULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9D10C0
	string GADUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0x9D10F4
	void GADUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adReceivedCallback, GADUInterstitialAdFailedToLoadCallback adFailedCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback) { }

	// RVA: 0x9C89D0
	void GADUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0x9C8120
	IntPtr GAMUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0x9C8808
	bool GAMUInterstitialIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0x9C88D8
	void GAMUInterstitialPreloadedAdWithAdUnitID(IntPtr interstitialAd, string adUnitId) { }

	// RVA: 0x9C8974
	IntPtr GAMULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9C8A0C
	string GAMUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0x9C86E8
	void GAMUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adLoadedCallback, GADUInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback, GAMUInterstitialAppEventCallback appEventCallback) { }

	// RVA: 0x9D11CC
	void GAMUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0x9D11D0
	IntPtr GADUCreateRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0x9D11D4
	bool GADURewardedIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0x9D120C
	void GADURewardedPreloadedAdWithAdUnitID(IntPtr rewardedAd, string adUnitId) { }

	// RVA: 0x9D1244
	IntPtr GADULoadRewardedAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9D1298
	void GADUShowRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0x9D129C
	string GADUGetRewardedAdUnitID(IntPtr rewardedAd) { }

	// RVA: 0x9D12D0
	void GADUSetRewardedAdCallbacks(IntPtr rewardedAd, GADURewardedAdLoadedCallback adLoadedCallback, GADURewardedAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedAdDidRecordClickCallback adDidRecordClickCallback, GADURewardedAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedAdPaidEventCallback paidEventCallback) { }

	// RVA: 0x9D13B4
	IntPtr GADUCreateServerSideVerificationOptions() { }

	// RVA: 0x9D13B8
	void GADUServerSideVerificationOptionsSetUserId(IntPtr options, string userId) { }

	// RVA: 0x9D13F0
	void GADUServerSideVerificationOptionsSetCustomRewardString(IntPtr options, string customRewardString) { }

	// RVA: 0x9D1428
	void GADURewardedAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0x9D142C
	string GADURewardedAdGetRewardType(IntPtr rewardedAd) { }

	// RVA: 0x9D1460
	Double GADURewardedAdGetRewardAmount(IntPtr rewardedAd) { }

	// RVA: 0x9D1464
	IntPtr GADUCreateRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9D1468
	IntPtr GADULoadRewardedInterstitialAd(IntPtr rewardedInterstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9D14BC
	void GADUShowRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9D14C0
	string GADUGetRewardedInterstitialAdUnitID(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9D14F4
	void GADUSetRewardedInterstitialAdCallbacks(IntPtr rewardedInterstitialAd, GADURewardedInterstitialAdLoadedCallback adLoadedCallback, GADURewardedInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedInterstitialAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedInterstitialAdPaidEventCallback paidEventCallback, GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedInterstitialAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0x9D15D8
	void GADURewardedInterstitialAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0x9D15DC
	string GADURewardedInterstitialAdGetRewardType(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9D1610
	Double GADURewardedInterstitialAdGetRewardAmount(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9D1614
	IntPtr GADUCreateNativeAdOptions(int adChoicesPlacement, int mediaAspectRatio, IntPtr videoOptions) { }

	// RVA: 0x9D1618
	IntPtr GADUCreateNativeTemplateTextStyle() { }

	// RVA: 0x9D161C
	IntPtr GADUSetNativeTemplateTextColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0x9D1620
	IntPtr GADUSetNativeTemplateTextBackgroundColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0x9D1624
	IntPtr GADUSetNativeTemplateTextFontStyle(IntPtr templateTextStyle, int fontType) { }

	// RVA: 0x9D1628
	IntPtr GADUSetNativeTemplateTextFontSize(IntPtr templateTextStyle, int size) { }

	// RVA: 0x9D162C
	IntPtr GADUCreateNativeTemplateStyle(string templateName) { }

	// RVA: 0x9D1660
	IntPtr GADUSetNativeTemplateStyleBackgroundColor(IntPtr templateStyle, IntPtr color) { }

	// RVA: 0x9D1664
	IntPtr GADUSetNativeTemplateStyleText(IntPtr templateStyle, string textType, IntPtr color) { }

	// RVA: 0x9D16B8
	IntPtr GADUCreateNativeTemplateAd(IntPtr nativeAdClient) { }

	// RVA: 0x9D16BC
	void GADUSetNativeTemplateAdCallbacks(IntPtr nativeTemplateAd, GADUNativeAdLoadedCallback adLoadedCallback, GADUNativeAdFailedToLoadCallback adFailedCallback, GADUNativeAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUNativeAdDidRecordClickCallback adDidRecordClickCallback, GADUNativePaidEventCallback paidEventCallback, GADUNativeAdWillPresentScreenCallback willPresentCallback, GADUNativeAdDidDismissScreenCallback didDismissCallback) { }

	// RVA: 0x9D1778
	void GADULoadNativeTemplateAd(IntPtr nativeTemplateAd, string adUnitID, IntPtr nativeAdOptions, IntPtr request) { }

	// RVA: 0x9D17C8
	void GADUShowNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle, int height, int width) { }

	// RVA: 0x9D17CC
	void GADUShowDefaultNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle) { }

	// RVA: 0x9D17D0
	void GADUSetNativeTemplateAdPosition(IntPtr nativeTemplateAd, int position) { }

	// RVA: 0x9D17D4
	void GADUSetNativeTemplateAdCustomPosition(IntPtr nativeTemplateAd, int x, int y) { }

	// RVA: 0x9D17D8
	void GADUHideNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9D17DC
	void GADUDisplayNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9D17E0
	void GADUDestroyNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9D17E4
	float GADUGetNativeTemplateAdHeightInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0x9D17E8
	float GADUGetNativeTemplateAdWidthInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0x9D17EC
	void GADUPresentAdInspector(IntPtr mobileAdsClient, GADUAdInspectorClosedCallback callback) { }

	// RVA: 0x9C9564
	string GADUAdapterResponseInfoAdNetworkClassName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C95D0
	string GADUAdapterResponseInfoAdSourceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C963C
	string GADUAdapterResponseInfoAdSourceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C96A8
	string GADUAdapterResponseInfoAdSourceInstanceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C9714
	string GADUAdapterResponseInfoAdSourceInstanceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C9750
	Int64 GADUAdapterResponseInfoLatency(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C98E4
	int GADUAdapterResponseInfoAdUnitMappingCount(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C98E8
	string GADUAdapterResponseInfoAdUnitMappingKey(IntPtr adapterResponseInfoRef, int index) { }

	// RVA: 0x9C991C
	string GADUAdapterResponseInfoAdUnitMappingValue(IntPtr adapterResponseInfoRef, string key) { }

	// RVA: 0x9C99F8
	IntPtr GADUAdapterResponseInfoAdError(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9C9A34
	string GADUAdapterResponseInfoDescription(IntPtr error) { }

}

// Namespace: GoogleMobileAds
public class GoogleMobileAdsClientFactory 
{
	// Methods

	// RVA: 0x9D1818
	void .ctor() { }

	// RVA: 0x9D1820
	IAppStateEventClient BuildAppStateEventClient() { }

	// RVA: 0x9D1940
	IAppOpenAdClient BuildAppOpenAdClient() { }

	// RVA: 0x9D1A88
	IBannerClient BuildBannerClient() { }

	// RVA: 0x9D1BD0
	IAdManagerBannerClient BuildAdManagerBannerClient() { }

	// RVA: 0x9D1D18
	IInterstitialClient BuildInterstitialClient() { }

	// RVA: 0x9D1E68
	IAdManagerInterstitialClient BuildAdManagerInterstitialClient() { }

	// RVA: 0x9D1FB0
	IRewardedAdClient BuildRewardedAdClient() { }

	// RVA: 0x9D2100
	IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient() { }

	// RVA: 0x9D2250
	INativeOverlayAdClient BuildNativeOverlayAdClient() { }

	// RVA: 0x9D23A0
	IApplicationPreferencesClient ApplicationPreferencesInstance() { }

	// RVA: 0x9D24E8
	IMobileAdsClient MobileAdsInstance() { }

}

// Namespace: GoogleMobileAds.iOS
public class InitializationStatusClient 
{
	// Fields
	private IntPtr status; // 0x10

	// Methods

	// RVA: 0x9D2694
	void .ctor(IntPtr status) { }

	// RVA: 0x9D26C0
	AdapterStatus getAdapterStatusForClassName(string className) { }

	// RVA: 0x9D2884
	System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap() { }

	// RVA: 0x9D2B90
	System.Collections.Generic.List<System.String> GetAdapterClassNames() { }

	// RVA: 0x9D2DC0
	void Dispose() { }

	// RVA: 0x9D2DC8
	void Finalize() { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback 
{
	// Methods

	// RVA: 0x9D49E4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D52A4
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9D52B8
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D5374
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback 
{
	// Methods

	// RVA: 0x9D4A88
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D5380
	internal void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9D5394
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9D5460
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback 
{
	// Methods

	// RVA: 0x9D4E60
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D546C
	internal void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9D5480
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9D5598
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9D4BD0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D55A4
	internal void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9D55B8
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9D5684
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9D4B2C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D5690
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9D56A4
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D5760
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9D4C74
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D576C
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9D5780
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D583C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9D4D18
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D5848
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9D585C
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D5918
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9D4DBC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D5924
	internal void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9D5938
	internal IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D59F4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class InterstitialClient 
{
	// Fields
	private IntPtr interstitialClientPtr; // 0x10
	private IntPtr interstitialPtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x30
	private System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent; // 0x38
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x48
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x50
	private Action OnAdClicked; // 0x58
	private static GADUInterstitialAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADUInterstitialAdFailedToLoadCallback <>f__mg$cache1; // 0x8
	private static GADUInterstitialAdWillPresentFullScreenContentCallback <>f__mg$cache2; // 0x10
	private static GADUInterstitialAdFailedToPresentFullScreenContentCallback <>f__mg$cache3; // 0x18
	private static GADUInterstitialAdDidDismissFullScreenContentCallback <>f__mg$cache4; // 0x20
	private static GADUInterstitialAdDidRecordImpressionCallback <>f__mg$cache5; // 0x28
	private static GADUInterstitialAdDidRecordClickCallback <>f__mg$cache6; // 0x30
	private static GADUInterstitialPaidEventCallback <>f__mg$cache7; // 0x38

	// Methods

	// RVA: 0x9D1E60
	void .ctor() { }

	// RVA: 0x9D3708
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D37BC
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D3870
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9D3924
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9D39D8
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9D3A8C
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9D3B40
	void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9D3BF4
	void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9D3CA8
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D3D5C
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D3E10
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D3EC4
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D3F78
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D402C
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D40E0
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9D4184
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9D4228
	IntPtr get_InterstitialPtr() { }

	// RVA: 0x9D4230
	void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0x9D425C
	void CreateInterstitialAd() { }

	// RVA: 0x9D4F04
	bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9D4F40
	IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0x9D4F8C
	void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9D4FF0
	void Show() { }

	// RVA: 0x9D4FF8
	string GetAdUnitID() { }

	// RVA: 0x9D5030
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9D50A4
	void DestroyInterstitial() { }

	// RVA: 0x9D50CC
	void Dispose() { }

	// RVA: 0x9D512C
	void Finalize() { }

	// RVA: 0x9D2E5C
	void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0x9D2F64
	void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9D30B4
	void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9D31EC
	void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9D333C
	void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9D3444
	void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9D354C
	void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0x9D3654
	void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0x9D51F8
	InterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class LoadAdErrorClient 
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9C5ABC
	void .ctor(IntPtr error) { }

	// RVA: 0x9D5A00
	int GetCode() { }

	// RVA: 0x9D5A08
	string GetDomain() { }

	// RVA: 0x9D5A40
	string GetMessage() { }

	// RVA: 0x9D5A78
	IAdErrorClient GetCause() { }

	// RVA: 0x9D5AEC
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9D5B60
	string ToString() { }

}

// Namespace: 
internal sealed class GADUAdInspectorClosedCallback 
{
	// Methods

	// RVA: 0x9D773C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D7A2C
	internal void Invoke(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0x9D7A40
	internal IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0x9D7B0C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInitializationCompleteCallback 
{
	// Methods

	// RVA: 0x9D6654
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D7B18
	internal void Invoke(IntPtr mobileAdsClient, IntPtr initStatusClient) { }

	// RVA: 0x9D7B2C
	internal IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr initStatusClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D7BF8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdAvailableCallback 
{
	// Methods

	// RVA: 0x9D7458
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D7C04
	internal void Invoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient) { }

	// RVA: 0x9D7C18
	internal IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D7CE4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdsExhaustedCallback 
{
	// Methods

	// RVA: 0x9D74FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9D7CF0
	internal void Invoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient) { }

	// RVA: 0x9D7D04
	internal IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient, AsyncCallback callback, object object) { }

	// RVA: 0x9D7DD0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class MobileAdsClient 
{
	// Fields
	private static MobileAdsClient instance; // 0x0
	private System.Action<GoogleMobileAds.Api.PreloadConfiguration> adAvailableAction; // 0x10
	private System.Action<GoogleMobileAds.Api.PreloadConfiguration> adsExhaustedAction; // 0x18
	private System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction; // 0x20
	private System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction; // 0x28
	private IntPtr mobileAdsClientPtr; // 0x30
	private static GADUInitializationCompleteCallback <>f__mg$cache0; // 0x8
	private static GADUAdAvailableCallback <>f__mg$cache1; // 0x10
	private static GADUAdsExhaustedCallback <>f__mg$cache2; // 0x18
	private static GADUAdInspectorClosedCallback <>f__mg$cache3; // 0x20

	// Methods

	// RVA: 0x9D6408
	void .ctor() { }

	// RVA: 0x9D643C
	MobileAdsClient get_Instance() { }

	// RVA: 0x9D64B8
	void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction) { }

	// RVA: 0x9D66F8
	void DisableMediationInitialization() { }

	// RVA: 0x9D66FC
	void SetApplicationVolume(float volume) { }

	// RVA: 0x9D6700
	void SetApplicationMuted(bool muted) { }

	// RVA: 0x9D6708
	void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0x9D6C68
	RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0x9D6ED0
	void SetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0x9D6ED8
	void DisableSDKCrashReporting() { }

	// RVA: 0x9D6EDC
	float GetDeviceScale() { }

	// RVA: 0x9D6EE0
	int GetDeviceSafeWidth() { }

	// RVA: 0x9D6EE4
	Version GetSDKVersion() { }

	// RVA: 0x9D6F60
	void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) { }

	// RVA: 0x9D75A0
	void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed) { }

	// RVA: 0x9D5B98
	void AdAvailableCallback(IntPtr mobileAdsClient, IntPtr config) { }

	// RVA: 0x9D5D5C
	void AdsExhaustedCallback(IntPtr mobileAdsClient, IntPtr config) { }

	// RVA: 0x9D5F20
	void AdInspectorClosedCallback(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0x9D60CC
	void InitializationCompleteCallback(IntPtr mobileAdsClient, IntPtr initStatus) { }

	// RVA: 0x9D77E0
	MobileAdsClient IntPtrToMobileAdsClient(IntPtr mobileAdsClient) { }

	// RVA: 0x9D78D4
	void Dispose() { }

	// RVA: 0x9D7908
	void Finalize() { }

	// RVA: 0x9D79B0
	void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
public sealed class MonoPInvokeCallbackAttribute 
{
	// Methods

	// RVA: 0x9D7DDC
	void .ctor(Type type) { }

}

// Namespace: 
internal sealed class GADUNativeAdLoadedCallback 
{
	// Methods

	// RVA: 0x9D970C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA22C
	internal void Invoke(IntPtr nativeClient) { }

	// RVA: 0x9DA240
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DA2FC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdFailedToLoadCallback 
{
	// Methods

	// RVA: 0x9D97B0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA308
	internal void Invoke(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0x9DA31C
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9DA3E8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativePaidEventCallback 
{
	// Methods

	// RVA: 0x9D999C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA3F4
	internal void Invoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9DA408
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9DA520
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9D9854
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA52C
	internal void Invoke(IntPtr nativeClient) { }

	// RVA: 0x9DA540
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DA5FC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9D98F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA608
	internal void Invoke(IntPtr nativeClient) { }

	// RVA: 0x9DA61C
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DA6D8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdWillPresentScreenCallback 
{
	// Methods

	// RVA: 0x9D9A40
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA6E4
	internal void Invoke(IntPtr nativeClient) { }

	// RVA: 0x9DA6F8
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DA7B4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidDismissScreenCallback 
{
	// Methods

	// RVA: 0x9D9AE4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DA7C0
	internal void Invoke(IntPtr nativeClient) { }

	// RVA: 0x9DA7D4
	internal IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DA890
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class NativeOverlayAdClient 
{
	// Fields
	private IntPtr nativeClientPtr; // 0x10
	private IntPtr nativePtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x30
	private Action OnAdClicked; // 0x38
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x48
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x50
	private static GADUNativeAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADUNativeAdFailedToLoadCallback <>f__mg$cache1; // 0x8
	private static GADUNativeAdDidRecordImpressionCallback <>f__mg$cache2; // 0x10
	private static GADUNativeAdDidRecordClickCallback <>f__mg$cache3; // 0x18
	private static GADUNativePaidEventCallback <>f__mg$cache4; // 0x20
	private static GADUNativeAdWillPresentScreenCallback <>f__mg$cache5; // 0x28
	private static GADUNativeAdDidDismissScreenCallback <>f__mg$cache6; // 0x30

	// Methods

	// RVA: 0x9D2398
	void .ctor() { }

	// RVA: 0x9D8540
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D85F4
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D86A8
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9D875C
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9D8810
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D88C4
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D8978
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9D8A1C
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9D8AC0
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D8B74
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D8C28
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D8CDC
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9D8D90
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9D8E44
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9D8EF8
	NativeOverlayAdClient IntPtrToNativeClient(IntPtr nativeClient) { }

	// RVA: 0x9D8FA4
	IntPtr get_NativePtr() { }

	// RVA: 0x9D8FAC
	void set_NativePtr(IntPtr value) { }

	// RVA: 0x9D8FD8
	void Load(string adUnitID, AdRequest request, NativeAdOptions nativeOptions) { }

	// RVA: 0x9D9BCC
	void Hide() { }

	// RVA: 0x9D9BD4
	void Show() { }

	// RVA: 0x9D9BDC
	void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, AdPosition adPosition) { }

	// RVA: 0x9D9E40
	void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, int x, int y) { }

	// RVA: 0x9D9E9C
	void Render(NativeTemplateStyle templateViewStyle, AdPosition adPosition) { }

	// RVA: 0x9D9ED8
	void Render(NativeTemplateStyle templateViewStyle, int x, int y) { }

	// RVA: 0x9D9F24
	void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9D9F2C
	void SetPosition(int x, int y) { }

	// RVA: 0x9D9F34
	float GetHeightInPixels() { }

	// RVA: 0x9D9F3C
	float GetWidthInPixels() { }

	// RVA: 0x9D9F44
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9D9FB8
	void DestroyAd() { }

	// RVA: 0x9D9FE0
	void Dispose() { }

	// RVA: 0x9DA02C
	void Finalize() { }

	// RVA: 0x9D7DE4
	void NativeLoadedCallback(IntPtr nativeClient) { }

	// RVA: 0x9D7EEC
	void NativeFailedToLoadCallback(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0x9D803C
	void NativePaidEventCallback(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9D8174
	void AdDidRecordImpressionCallback(IntPtr nativeClient) { }

	// RVA: 0x9D827C
	void AdDidRecordClickCallback(IntPtr nativeClient) { }

	// RVA: 0x9D8330
	void NativeAdWillPresentScreenCallback(IntPtr nativeClient) { }

	// RVA: 0x9D8438
	void NativeAdDidDismissScreenCallback(IntPtr nativeClient) { }

	// RVA: 0x9D9B88
	IntPtr BuildNativeAdOptions(NativeAdOptions options) { }

	// RVA: 0x9D9C30
	IntPtr BuildNativeTemplateStyles(NativeTemplateStyle templateStyle) { }

	// RVA: 0x9DA0E4
	IntPtr BuildNativeTemplateTextStyle(NativeTemplateTextStyle textStyle) { }

}

// Namespace: GoogleMobileAds.iOS
internal class PreloadConfigurationClient 
{
	// Fields
	private AdRequest _adRequest; // 0x10
	internal IntPtr preloadConfigurationPtr; // 0x18

	// Methods

	// RVA: 0x9D7394
	void .ctor(IntPtr preloadConfiguration) { }

	// RVA: 0x9D788C
	string get_AdUnitId() { }

	// RVA: 0x9D73C0
	void set_AdUnitId(string value) { }

	// RVA: 0x9D78C4
	AdFormat get_Format() { }

	// RVA: 0x9D73F8
	void set_Format(AdFormat value) { }

	// RVA: 0x9DA89C
	AdRequest get_Request() { }

	// RVA: 0x9D7408
	void set_Request(AdRequest value) { }

	// RVA: 0x9D78CC
	UInt32 get_BufferSize() { }

	// RVA: 0x9D7400
	void set_BufferSize(UInt32 value) { }

}

// Namespace: GoogleMobileAds.iOS
public class RequestConfigurationClient 
{
	// Fields
	private static IntPtr requestConfigurationPtr; // 0x0

	// Methods

	// RVA: 0x9DA8A4
	void .ctor() { }

	// RVA: 0x9D6788
	void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0x9D6CD0
	RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0x9DA8AC
	void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
internal class ResponseInfoClient 
{
	// Fields
	private IntPtr _iosResponseInfo; // 0x10

	// Methods

	// RVA: 0x9C58A0
	void .ctor(ResponseInfoClientType type, IntPtr ptr) { }

	// RVA: 0x9DA8FC
	void .ctor(IntPtr adFormat, IntPtr iOSClient) { }

	// RVA: 0x9DA928
	System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses() { }

	// RVA: 0x9DAA80
	IAdapterResponseInfoClient GetLoadedAdapterResponseInfo() { }

	// RVA: 0x9DAB18
	System.Collections.Generic.Dictionary<System.String,System.String> GetResponseExtras() { }

	// RVA: 0x9DACBC
	string GetMediationAdapterClassName() { }

	// RVA: 0x9DAD4C
	string GetResponseId() { }

	// RVA: 0x9DADDC
	string ToString() { }

}

// Namespace: 
internal sealed class GADURewardedAdLoadedCallback 
{
	// Methods

	// RVA: 0x9DCD4C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DD810
	internal void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0x9DD824
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DD8E0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToLoadCallback 
{
	// Methods

	// RVA: 0x9DCDF0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DD8EC
	internal void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0x9DD900
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9DD9CC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdUserEarnedRewardCallback 
{
	// Methods

	// RVA: 0x9DD1C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DD9D8
	internal void Invoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0x9DD9EC
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x9DDADC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdPaidEventCallback 
{
	// Methods

	// RVA: 0x9DD26C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDAE8
	internal void Invoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9DDAFC
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9DDC14
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9DCF38
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDC20
	internal void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0x9DDC34
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9DDD00
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdWillPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9DCE94
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDD0C
	internal void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0x9DDD20
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DDDDC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidDismissFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9DCFDC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDDE8
	internal void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0x9DDDFC
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DDEB8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9DD080
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDEC4
	internal void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0x9DDED8
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DDF94
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9DD124
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9DDFA0
	internal void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0x9DDFB4
	internal IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9DE070
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class RewardedAdClient 
{
	// Fields
	private IntPtr rewardedAdClientPtr; // 0x10
	private IntPtr rewardedAdPtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward; // 0x30
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x38
	private System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x48
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x50
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x58
	private Action OnAdClicked; // 0x60
	private static GADURewardedAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADURewardedAdFailedToLoadCallback <>f__mg$cache1; // 0x8
	private static GADURewardedAdWillPresentFullScreenContentCallback <>f__mg$cache2; // 0x10
	private static GADURewardedAdFailedToPresentFullScreenContentCallback <>f__mg$cache3; // 0x18
	private static GADURewardedAdDidDismissFullScreenContentCallback <>f__mg$cache4; // 0x20
	private static GADURewardedAdDidRecordImpressionCallback <>f__mg$cache5; // 0x28
	private static GADURewardedAdDidRecordClickCallback <>f__mg$cache6; // 0x30
	private static GADURewardedAdUserEarnedRewardCallback <>f__mg$cache7; // 0x38
	private static GADURewardedAdPaidEventCallback <>f__mg$cache8; // 0x40

	// Methods

	// RVA: 0x9D20F8
	void .ctor() { }

	// RVA: 0x9DB850
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DB904
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DB9B8
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9DBA6C
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9DBB20
	void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0x9DBBD4
	void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0x9DBC88
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9DBD3C
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9DBDF0
	void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9DBEA4
	void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9DBF58
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC00C
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC0C0
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC174
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC228
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC2DC
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DC390
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9DC434
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9DC4D8
	IntPtr get_RewardedAdPtr() { }

	// RVA: 0x9DC4E0
	void set_RewardedAdPtr(IntPtr value) { }

	// RVA: 0x9DC50C
	void CreateRewardedAd() { }

	// RVA: 0x9DD310
	bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9DD34C
	IRewardedAdClient PollAd(string adUnitId) { }

	// RVA: 0x9DD398
	void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9DD3FC
	void Show() { }

	// RVA: 0x9DD404
	string GetAdUnitID() { }

	// RVA: 0x9DD43C
	void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0x9DD4EC
	Reward GetRewardItem() { }

	// RVA: 0x9DD59C
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9DD610
	void DestroyRewardedAd() { }

	// RVA: 0x9DD638
	void Dispose() { }

	// RVA: 0x9DD698
	void Finalize() { }

	// RVA: 0x9DAE6C
	void RewardedAdLoadedCallback(IntPtr rewardedAdClient) { }

	// RVA: 0x9DAF74
	void RewardedAdFailedToLoadCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0x9DB0C4
	void RewardedAdUserDidEarnRewardCallback(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0x9DB1FC
	void RewardedAdPaidEventCallback(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9DB334
	void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0x9DB484
	void AdWillPresentFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0x9DB58C
	void AdDidDismissFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0x9DB694
	void AdDidRecordImpressionCallback(IntPtr rewardedAdClient) { }

	// RVA: 0x9DB79C
	void AdDidRecordClickCallback(IntPtr rewardedAdClient) { }

	// RVA: 0x9DD764
	RewardedAdClient IntPtrToRewardedAdClient(IntPtr rewardedAdClient) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdLoadedCallback 
{
	// Methods

	// RVA: 0x9DFF5C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E08F8
	internal void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E090C
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9E09C8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToLoadCallback 
{
	// Methods

	// RVA: 0x9E0000
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E09D4
	internal void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0x9E09E8
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9E0AB4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdUserEarnedRewardCallback 
{
	// Methods

	// RVA: 0x9E00A4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0AC0
	internal void Invoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0x9E0AD4
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0x9E0BC4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdPaidEventCallback 
{
	// Methods

	// RVA: 0x9E0148
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0BD0
	internal void Invoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9E0BE4
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9E0CFC
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9E01EC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0D08
	internal void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0x9E0D1C
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9E0DE8
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdWillPresentFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9E0290
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0DF4
	internal void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E0E08
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9E0EC4
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidDismissFullScreenContentCallback 
{
	// Methods

	// RVA: 0x9E0334
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0ED0
	internal void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E0EE4
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9E0FA0
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordImpressionCallback 
{
	// Methods

	// RVA: 0x9E03D8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E0FAC
	internal void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E0FC0
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9E107C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordClickCallback 
{
	// Methods

	// RVA: 0x9E047C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E1088
	internal void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E109C
	internal IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9E1158
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class RewardedInterstitialAdClient 
{
	// Fields
	private IntPtr rewardedInterstitialAdClientPtr; // 0x10
	private IntPtr rewardedInterstitialAdPtr; // 0x18
	private System.EventHandler<System.EventArgs> OnAdLoaded; // 0x20
	private System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> OnAdFailedToLoad; // 0x28
	private System.EventHandler<GoogleMobileAds.Api.Reward> OnUserEarnedReward; // 0x30
	private System.Action<GoogleMobileAds.Api.AdValue> OnPaidEvent; // 0x38
	private System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent; // 0x40
	private System.EventHandler<System.EventArgs> OnAdDidPresentFullScreenContent; // 0x48
	private System.EventHandler<System.EventArgs> OnAdDidDismissFullScreenContent; // 0x50
	private System.EventHandler<System.EventArgs> OnAdDidRecordImpression; // 0x58
	private Action OnAdClicked; // 0x60
	private static GADURewardedInterstitialAdLoadedCallback <>f__mg$cache0; // 0x0
	private static GADURewardedInterstitialAdFailedToLoadCallback <>f__mg$cache1; // 0x8
	private static GADURewardedInterstitialAdUserEarnedRewardCallback <>f__mg$cache2; // 0x10
	private static GADURewardedInterstitialAdPaidEventCallback <>f__mg$cache3; // 0x18
	private static GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback <>f__mg$cache4; // 0x20
	private static GADURewardedInterstitialAdWillPresentFullScreenContentCallback <>f__mg$cache5; // 0x28
	private static GADURewardedInterstitialAdDidDismissFullScreenContentCallback <>f__mg$cache6; // 0x30
	private static GADURewardedInterstitialAdDidRecordImpressionCallback <>f__mg$cache7; // 0x38
	private static GADURewardedInterstitialAdDidRecordClickCallback <>f__mg$cache8; // 0x40

	// Methods

	// RVA: 0x9D2248
	void .ctor() { }

	// RVA: 0x9DEA60
	void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DEB14
	void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DEBC8
	void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9DEC7C
	void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9DED30
	void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0x9DEDE4
	void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0x9DEE98
	void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9DEF4C
	void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9DF000
	void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9DF0B4
	void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9DF168
	void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF21C
	void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF2D0
	void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF384
	void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF438
	void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF4EC
	void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9DF5A0
	void add_OnAdClicked(Action value) { }

	// RVA: 0x9DF644
	void remove_OnAdClicked(Action value) { }

	// RVA: 0x9DF6E8
	IntPtr get_RewardedInterstitialAdPtr() { }

	// RVA: 0x9DF6F0
	void set_RewardedInterstitialAdPtr(IntPtr value) { }

	// RVA: 0x9DF71C
	void CreateRewardedInterstitialAd() { }

	// RVA: 0x9E0520
	void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9E0584
	void Show() { }

	// RVA: 0x9E058C
	string GetAdUnitID() { }

	// RVA: 0x9E05C4
	void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0x9E05FC
	Reward GetRewardItem() { }

	// RVA: 0x9E06AC
	IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9E0720
	void DestroyRewardedInterstitialAd() { }

	// RVA: 0x9E0748
	void Dispose() { }

	// RVA: 0x9E0794
	void Finalize() { }

	// RVA: 0x9DE07C
	void RewardedInterstitialAdLoadedCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9DE184
	void RewardedInterstitialAdFailedToLoadCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0x9DE2D4
	void RewardedInterstitialAdUserDidEarnRewardCallback(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0x9DE40C
	void RewardedInterstitialAdPaidEventCallback(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9DE544
	void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0x9DE694
	void AdWillPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9DE79C
	void AdDidDismissFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9DE8A4
	void AdDidRecordImpressionCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9DE9AC
	void AdDidRecordClickCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0x9E084C
	RewardedInterstitialAdClient IntPtrToRewardedInterstitialAdClient(IntPtr rewardedInterstitialAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Utils 
{
	// Methods

	// RVA: 0x9E1164
	void .ctor() { }

	// RVA: 0x9CF170
	IntPtr BuildAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0x9C4750
	IntPtr BuildAdManagerAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0x9DD474
	IntPtr BuildServerSideVerificationOptions(ServerSideVerificationOptions options) { }

	// RVA: 0x9D2808
	string PtrToString(IntPtr stringPtr) { }

	// RVA: 0x9D2BC8
	System.Collections.Generic.List<System.String> PtrArrayToManagedList(IntPtr arrayPtr, int numOfAssets) { }

}


