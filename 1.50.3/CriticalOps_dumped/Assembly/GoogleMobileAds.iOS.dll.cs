// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.iOS
internal class AdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0xA13308
	public void .ctor(IntPtr error) { }

	// RVA: 0xA13334
	public int GetCode() { }

	// RVA: 0xA13340
	public string GetDomain() { }

	// RVA: 0xA133AC
	public string GetMessage() { }

	// RVA: 0xA13418
	public IAdErrorClient GetCause() { }

	// RVA: 0xA13490
	public override string ToString() { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdInspectorErrorClient
{
	// Methods

	// RVA: 0xA134FC
	public void .ctor(IntPtr error) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0xA153D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA176DC
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA176F0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA177AC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0xA15478
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA177B8
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA177CC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA17898
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA1551C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA178A4
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA178B8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA17974
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA155C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA17980
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA17994
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA17A50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0xA15664
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA17A5C
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA17A70
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA17B88
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0xA15708
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA17B94
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA17BA8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA17C64
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0xA157AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA17C70
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA17C84
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA17D40
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUAdViewAppEventCallback
{
	// Methods

	// RVA: 0xA15850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA17D4C
	public virtual void Invoke(IntPtr bannerClient, string name, string info) { }

	// RVA: 0xA17D60
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0xA17E30
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA13D58
	public void .ctor() { }

	// RVA: 0xA13D60
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13E14
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13EC8
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA13F7C
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA14030
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA140E4
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA14198
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1424C
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA14300
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA143B4
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA14468
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA1451C
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA145D0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA14674
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA14718
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA147BC
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA14860
	public System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> get_ValidAdSizes() { }

	// RVA: 0xA14868
	public void set_ValidAdSizes(System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> value) { }

	// RVA: 0xA14A74
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0xA14A7C
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0xA14AAC
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0xA159CC
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0xA16308
	public void LoadAd(AdRequest request) { }

	// RVA: 0xA172FC
	public void ShowBannerView() { }

	// RVA: 0xA17308
	public void HideBannerView() { }

	// RVA: 0xA17314
	public void DestroyBannerView() { }

	// RVA: 0xA17348
	public string GetAdUnitID() { }

	// RVA: 0xA173B4
	public float GetHeightInPixels() { }

	// RVA: 0xA173C0
	public float GetWidthInPixels() { }

	// RVA: 0xA173CC
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA173D8
	public void SetPosition(int x, int y) { }

	// RVA: 0xA173E4
	public bool IsCollapsible() { }

	// RVA: 0xA17420
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA174F0
	public void Dispose() { }

	// RVA: 0xA17544
	protected override void Finalize() { }

	// RVA: 0xA13528
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0xA13630
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA13780
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA13888
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA13990
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA13AC8
	private static void AdViewAppEventCallback(IntPtr bannerClient, string name, string info) { }

	// RVA: 0xA13BF0
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA13CA4
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA17604
	private static AdManagerBannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA19D18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1A8B0
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA1A8C4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1A980
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA19DBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1A98C
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA1A9A0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA1AA6C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA1A194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1AA78
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA1AA8C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA1ABA4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUInterstitialAppEventCallback
{
	// Methods

	// RVA: 0xA1A238
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1ABB0
	public virtual void Invoke(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0xA1ABC4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0xA1AC94
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA19F04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1ACA0
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA1ACB4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA1AD80
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA19E60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1AD8C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA1ADA0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1AE5C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA19FA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1AE68
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA1AE7C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1AF38
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA1A04C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1AF44
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA1AF58
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1B014
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA1A0F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1B020
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA1B034
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1B0F0
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA18810
	public void .ctor() { }

	// RVA: 0xA18818
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA188CC
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA18980
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA18A34
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA18AE8
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA18B9C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA18C50
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA18D04
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA18DB8
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA18E6C
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA18F20
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA18FD4
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA19088
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1913C
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA191F0
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA192A4
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA19358
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA193FC
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA194A0
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA194A8
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA194D4
	public void CreateInterstitialAd() { }

	// RVA: 0xA1A3C0
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA1A434
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA1A4B4
	public IAdManagerInterstitialClient PollAdManagerAd(string adUnitId) { }

	// RVA: 0xA1A534
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA1A5EC
	public void Show() { }

	// RVA: 0xA1A5F8
	public string GetAdUnitID() { }

	// RVA: 0xA1A664
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA1A6D8
	public void DestroyInterstitial() { }

	// RVA: 0xA1A700
	public void Dispose() { }

	// RVA: 0xA1A74C
	protected override void Finalize() { }

	// RVA: 0xA17E3C
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0xA17F44
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA18094
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA181CC
	private static void InterstitialAppEventCallback(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0xA182F4
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA18444
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA1854C
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA18654
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0xA1875C
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA1A804
	private static AdManagerInterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdapterResponseInfoClient
{
	// Fields
	private IntPtr _adapterResponseInfoPtr; // 0x10

	// Methods

	// RVA: 0xA1B0FC
	internal void .ctor(IntPtr adapterResponseInfoPtr) { }

	// RVA: 0xA1B128
	public string get_AdapterClassName() { }

	// RVA: 0xA1B194
	public string get_AdSourceId() { }

	// RVA: 0xA1B200
	public string get_AdSourceName() { }

	// RVA: 0xA1B26C
	public string get_AdSourceInstanceId() { }

	// RVA: 0xA1B2D8
	public string get_AdSourceInstanceName() { }

	// RVA: 0xA1B344
	public Int64 get_LatencyMillis() { }

	// RVA: 0xA1B350
	public System.Collections.Generic.Dictionary<System.String,System.String> get_AdUnitMapping() { }

	// RVA: 0xA1B574
	public IAdErrorClient get_AdError() { }

	// RVA: 0xA1B5F8
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAppOpenAdLoadedCallback
{
	// Methods

	// RVA: 0xA1D1F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1DC54
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA1DC68
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1DD24
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailToLoadCallback
{
	// Methods

	// RVA: 0xA1D29C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1DD30
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA1DD44
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA1DE10
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdPaidEventCallback
{
	// Methods

	// RVA: 0xA1D340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1DE1C
	public virtual void Invoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA1DE30
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA1DF48
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA1D3E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1DF54
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA1DF68
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA1E034
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA1D488
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1E040
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA1E054
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1E110
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA1D52C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1E11C
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA1E130
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1E1EC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA1D5D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1E1F8
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA1E20C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1E2C8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA1D674
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1E2D4
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA1E2E8
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1E3A4
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA1BF10
	public void .ctor() { }

	// RVA: 0xA1BF18
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1BFCC
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C080
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1C134
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1C1E8
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA1C29C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA1C350
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA1C404
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA1C4B8
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C56C
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C620
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C6D4
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C788
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA1C82C
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA1C8D0
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1C984
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1CA38
	private IntPtr get_AppOpenAdPtr() { }

	// RVA: 0xA1CA40
	private void set_AppOpenAdPtr(IntPtr value) { }

	// RVA: 0xA1CA6C
	public void CreateAppOpenAd() { }

	// RVA: 0xA1D7F0
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA1D864
	public IAppOpenAdClient PollAd(string adUnitId) { }

	// RVA: 0xA1D8E4
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA1D990
	public void Show() { }

	// RVA: 0xA1D99C
	public string GetAdUnitID() { }

	// RVA: 0xA1DA08
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA1DA7C
	public void DestroyAppOpenAd() { }

	// RVA: 0xA1DAA4
	public void Dispose() { }

	// RVA: 0xA1DAF0
	protected override void Finalize() { }

	// RVA: 0xA1B664
	private static void AppOpenAdLoadedCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA1B76C
	private static void AppOpenAdFailedToLoadCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA1B8BC
	private static void AppOpenAdPaidEventCallback(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA1B9F4
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA1BB44
	private static void AdWillPresentFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA1BC4C
	private static void AdDidDismissFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA1BD54
	private static void AdDidRecordImpressionCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA1BE5C
	private static void AdDidRecordClickCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA1DBA8
	private static AppOpenAdClient IntPtrToAppOpenAdClient(IntPtr appOpenAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
public class ApplicationPreferencesClient
{
	// Methods

	// RVA: 0xA1E3B0
	public void .ctor() { }

	// RVA: 0xA1E3B8
	public void SetInt(string key, int value) { }

	// RVA: 0xA1E41C
	public void SetString(string key, string value) { }

	// RVA: 0xA1E4B0
	public int GetInt(string key) { }

	// RVA: 0xA1E51C
	public string GetString(string key) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0xA1FF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21B08
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA21B1C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA21BD8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0xA1FFC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21BE4
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA21BF8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA21CC4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA20068
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21CD0
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA21CE4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA21DA0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA2010C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21DAC
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA21DC0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA21E7C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0xA201B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21E88
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA21E9C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA21FB4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0xA20254
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA21FC0
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA21FD4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA22090
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0xA202F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2209C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA220B0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2216C
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA1ECC0
	public void .ctor() { }

	// RVA: 0xA1ECC8
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1ED7C
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1EE30
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1EEE4
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1EF98
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1F04C
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1F100
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1F1B4
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1F268
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA1F31C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA1F3D0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA1F474
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA1F518
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA1F5BC
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA1F660
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0xA1F668
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0xA1F694
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0xA20458
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0xA20D04
	public void LoadAd(AdRequest request) { }

	// RVA: 0xA217E8
	public void ShowBannerView() { }

	// RVA: 0xA217F0
	public void HideBannerView() { }

	// RVA: 0xA217F8
	public void DestroyBannerView() { }

	// RVA: 0xA21828
	public string GetAdUnitID() { }

	// RVA: 0xA21894
	public float GetHeightInPixels() { }

	// RVA: 0xA2189C
	public float GetWidthInPixels() { }

	// RVA: 0xA218A4
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA218AC
	public void SetPosition(int x, int y) { }

	// RVA: 0xA218B4
	public bool IsCollapsible() { }

	// RVA: 0xA218D4
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA21948
	public void Dispose() { }

	// RVA: 0xA2199C
	protected override void Finalize() { }

	// RVA: 0xA1E5B8
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0xA1E6C0
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA1E810
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA1E918
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA1EA20
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA1EB58
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA1EC0C
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA21A5C
	private static BannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA22178
	public void .ctor() { }

	// RVA: 0xA22180
	internal static extern void GADUInitializeWithCallback(IntPtr mobileAdsClient, GADUInitializationCompleteCallback callback) { }

	// RVA: 0xA221AC
	internal static extern void GADUDisableMediationInitialization() { }

	// RVA: 0xA221B0
	internal static extern IntPtr GADUGetInitDescription(IntPtr status, string className) { }

	// RVA: 0xA221F4
	internal static extern int GADUGetInitLatency(IntPtr status, string className) { }

	// RVA: 0xA22238
	internal static extern int GADUGetInitState(IntPtr status, string className) { }

	// RVA: 0xA2227C
	internal static extern IntPtr GADUGetInitAdapterClasses(IntPtr status) { }

	// RVA: 0xA22280
	internal static extern int GADUGetInitNumberOfAdapterClasses(IntPtr status) { }

	// RVA: 0xA22284
	internal static extern void GADUSetApplicationVolume(float volume) { }

	// RVA: 0xA22288
	internal static extern void GADUSetApplicationMuted(bool muted) { }

	// RVA: 0xA2228C
	internal static extern void GADUSetPlugin(string plugin) { }

	// RVA: 0xA222B4
	internal static extern void GADUSetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA222B8
	internal static extern void GADUDisableSDKCrashReporting() { }

	// RVA: 0xA222BC
	internal static extern float GADUDeviceScale() { }

	// RVA: 0xA222C0
	internal static extern int GADUDeviceSafeWidth() { }

	// RVA: 0xA1E3EC
	internal static extern void GADUSetIntegerPreference(string key, int value) { }

	// RVA: 0xA1E468
	internal static extern void GADUSetStringPreference(string key, string value) { }

	// RVA: 0xA1E4E8
	internal static extern int GADUGetIntegerPreference(string key) { }

	// RVA: 0xA1E56C
	internal static extern string GADUGetStringPreference(string key) { }

	// RVA: 0xA222C4
	internal static extern IntPtr GADUCreateRequest() { }

	// RVA: 0xA222C8
	internal static extern IntPtr GAMUCreateRequest() { }

	// RVA: 0xA222CC
	internal static extern IntPtr GADUCreateMutableDictionary() { }

	// RVA: 0xA222D0
	internal static extern void GADUMutableDictionarySetValue(IntPtr mutableDictionaryPtr, string key, string value) { }

	// RVA: 0xA2232C
	internal static extern void GADUSetMediationExtras(IntPtr request, IntPtr mutableDictionaryPtr, string adNetworkExtrasClassName) { }

	// RVA: 0xA22374
	internal static extern void GADUAddKeyword(IntPtr request, string keyword) { }

	// RVA: 0xA223AC
	internal static extern void GADUSetExtra(IntPtr request, string key, string value) { }

	// RVA: 0xA22408
	internal static extern void GAMUSetPublisherProvidedID(IntPtr request, string publisherProvidedID) { }

	// RVA: 0xA22440
	internal static extern void GAMUAddCategoryExclusion(IntPtr request, string category) { }

	// RVA: 0xA22478
	internal static extern void GAMUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0xA224D4
	internal static extern void GADUSetRequestAgent(IntPtr request, string requestAgent) { }

	// RVA: 0xA14AA8
	internal static extern void GADURelease(IntPtr obj) { }

	// RVA: 0xA2250C
	internal static extern IntPtr GADUCreateRequestConfiguration() { }

	// RVA: 0xA22510
	internal static extern void GADUSetRequestConfiguration(IntPtr requestConfiguration) { }

	// RVA: 0xA22514
	internal static extern void GADUSetRequestConfigurationTestDeviceIdentifiers(IntPtr requestConfiguration, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA225F0
	internal static extern void GADUSetRequestConfigurationMaxAdContentRating(IntPtr requestConfiguration, string maxAdContentRating) { }

	// RVA: 0xA22628
	internal static extern void GADUSetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration, int tagForUnderAgeOfConsent) { }

	// RVA: 0xA2262C
	internal static extern void GADUSetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration, int tagForChildDirectedTreatment) { }

	// RVA: 0xA22630
	internal static extern void GADUSetRequestConfigurationPublisherFirstPartyIDEnabled(bool enabled) { }

	// RVA: 0xA22634
	internal static extern void GADUSetRequestConfigurationPublisherPrivacyPersonalizationState(int state) { }

	// RVA: 0xA22638
	internal static extern IntPtr GADUGetTestDeviceIdentifiers(IntPtr request) { }

	// RVA: 0xA2263C
	internal static extern int GADUGetTestDeviceIdentifiersCount(IntPtr request) { }

	// RVA: 0xA22640
	internal static extern string GADUGetMaxAdContentRating(IntPtr requestConfiguration) { }

	// RVA: 0xA22674
	internal static extern int GADUGetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration) { }

	// RVA: 0xA22678
	internal static extern int GADUGetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration) { }

	// RVA: 0xA2267C
	internal static extern int GADUGetRequestConfigurationPublisherPrivacyPersonalizationState() { }

	// RVA: 0xA22680
	internal static extern IntPtr GADUCreateUIColor(float alpha, float red, float green, float blue) { }

	// RVA: 0xA22684
	internal static extern IntPtr GADUCreateVideoOptions(bool startMuted, bool clickToExpandRequested, bool customControlsRequested) { }

	// RVA: 0xA1D1F4
	internal static extern IntPtr GADUCreateAppOpenAd(IntPtr appOpenAdClient) { }

	// RVA: 0xA1D948
	internal static extern void GADULoadAppOpenAdWithAdUnitID(IntPtr appOpenAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA1D998
	internal static extern void GADUShowAppOpenAd(IntPtr appOpenAd) { }

	// RVA: 0xA1D718
	internal static extern void GADUSetAppOpenAdCallbacks(IntPtr appOpenAd, GADUAppOpenAdLoadedCallback adLoadedCallback, GADUAppOpenAdFailToLoadCallback adFailedToLoadCallback, GADUAppOpenAdPaidEventCallback paidEventCallback, GADUAppOpenAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUAppOpenAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUAppOpenAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUAppOpenAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUAppOpenAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA1D9D4
	internal static extern string GADUGetAppOpenAdUnitID(IntPtr appOpenAd) { }

	// RVA: 0xA1FEB4
	internal static extern IntPtr GADUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int positionAtTop) { }

	// RVA: 0xA20C90
	internal static extern IntPtr GADUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0xA1FDF4
	internal static extern IntPtr GADUCreateSmartBannerView(IntPtr bannerClient, string adUnitId, int positionAtTop) { }

	// RVA: 0xA20BC0
	internal static extern IntPtr GADUCreateSmartBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int x, int y) { }

	// RVA: 0xA1FE48
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int positionAtTop) { }

	// RVA: 0xA20C1C
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0xA2039C
	internal static extern void GADUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback) { }

	// RVA: 0xA17310
	internal static extern void GADUHideBannerView(IntPtr bannerView) { }

	// RVA: 0xA17304
	internal static extern void GADUShowBannerView(IntPtr bannerView) { }

	// RVA: 0xA17344
	internal static extern void GADURemoveBannerView(IntPtr bannerView) { }

	// RVA: 0xA172F8
	internal static extern void GADURequestBannerAd(IntPtr bannerView, IntPtr request) { }

	// RVA: 0xA21860
	internal static extern string GADUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0xA173BC
	internal static extern float GADUGetBannerViewHeightInPixels(IntPtr bannerView) { }

	// RVA: 0xA173C8
	internal static extern float GADUGetBannerViewWidthInPixels(IntPtr bannerView) { }

	// RVA: 0xA173D4
	internal static extern void GADUSetBannerViewAdPosition(IntPtr bannerView, int position) { }

	// RVA: 0xA173E0
	internal static extern void GADUSetBannerViewCustomPosition(IntPtr bannerView, int x, int y) { }

	// RVA: 0xA17404
	internal static extern bool GADUIsBannerViewCollapsible(IntPtr bannerView) { }

	// RVA: 0xA22688
	internal static extern IntPtr GADUGetResponseInfo(IntPtr adFormat) { }

	// RVA: 0xA2268C
	internal static extern string GADUResponseInfoMediationAdapterClassName(IntPtr responseInfo) { }

	// RVA: 0xA226C0
	internal static extern string GADUResponseInfoResponseId(IntPtr responseInfo) { }

	// RVA: 0xA226F4
	internal static extern string GADUGetResponseInfoDescription(IntPtr responseInfo) { }

	// RVA: 0xA22728
	internal static extern int GADUResponseInfoAdNetworkCount(IntPtr responseInfo) { }

	// RVA: 0xA2272C
	internal static extern IntPtr GADUResponseInfoAdNetworkAtIndex(IntPtr responseInfo, int index) { }

	// RVA: 0xA22730
	internal static extern IntPtr GADUResponseInfoLoadedAdNetworkResponseInfo(IntPtr responseInfo) { }

	// RVA: 0xA22734
	internal static extern int GADUResponseInfoExtrasCount(IntPtr responseInfo) { }

	// RVA: 0xA22738
	internal static extern string GADUResponseInfoExtrasKey(IntPtr responseInfo, int index) { }

	// RVA: 0xA2276C
	internal static extern string GADUResponseInfoExtrasValue(IntPtr responseInfo, string key) { }

	// RVA: 0xA1333C
	internal static extern int GADUGetAdErrorCode(IntPtr error) { }

	// RVA: 0xA13378
	internal static extern string GADUGetAdErrorDomain(IntPtr error) { }

	// RVA: 0xA133E4
	internal static extern string GADUGetAdErrorMessage(IntPtr error) { }

	// RVA: 0xA1348C
	internal static extern IntPtr GADUGetAdErrorUnderLyingError(IntPtr error) { }

	// RVA: 0xA227C8
	internal static extern IntPtr GADUGetAdErrorResponseInfo(IntPtr error) { }

	// RVA: 0xA134C8
	internal static extern string GADUGetAdErrorDescription(IntPtr error) { }

	// RVA: 0xA15368
	internal static extern IntPtr GAMUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int adPosition) { }

	// RVA: 0xA16294
	internal static extern IntPtr GAMUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0xA152FC
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int adPosition) { }

	// RVA: 0xA16220
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0xA17380
	internal static extern string GAMUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0xA158F4
	internal static extern void GAMUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback, GAMUAdViewAppEventCallback appEventCallback) { }

	// RVA: 0xA14A64
	internal static extern void GAMUBannerViewSetValidAdSizes(IntPtr bannerView, int[] validAdSizesArray, int validAdSizesLength) { }

	// RVA: 0xA227CC
	internal static extern IntPtr GADUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA227D0
	internal static extern IntPtr GADULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA22824
	internal static extern string GADUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA22858
	internal static extern void GADUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adReceivedCallback, GADUInterstitialAdFailedToLoadCallback adFailedCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback) { }

	// RVA: 0xA1A5F4
	internal static extern void GADUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA19D14
	internal static extern IntPtr GAMUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA1A598
	internal static extern IntPtr GAMULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA1A630
	internal static extern string GAMUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA1A2DC
	internal static extern void GAMUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adLoadedCallback, GADUInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback, GAMUInterstitialAppEventCallback appEventCallback) { }

	// RVA: 0xA22930
	internal static extern void GAMUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA22934
	internal static extern IntPtr GADUCreateRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA22938
	internal static extern IntPtr GADULoadRewardedAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA2298C
	internal static extern void GADUShowRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA22990
	internal static extern string GADUGetRewardedAdUnitID(IntPtr rewardedAd) { }

	// RVA: 0xA229C4
	internal static extern void GADUSetRewardedAdCallbacks(IntPtr rewardedAd, GADURewardedAdLoadedCallback adLoadedCallback, GADURewardedAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedAdDidRecordClickCallback adDidRecordClickCallback, GADURewardedAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedAdPaidEventCallback paidEventCallback) { }

	// RVA: 0xA22AA8
	internal static extern IntPtr GADUCreateServerSideVerificationOptions() { }

	// RVA: 0xA22AAC
	internal static extern void GADUServerSideVerificationOptionsSetUserId(IntPtr options, string userId) { }

	// RVA: 0xA22AE4
	internal static extern void GADUServerSideVerificationOptionsSetCustomRewardString(IntPtr options, string customRewardString) { }

	// RVA: 0xA22B1C
	internal static extern void GADURewardedAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA22B20
	internal static extern string GADURewardedAdGetRewardType(IntPtr rewardedAd) { }

	// RVA: 0xA22B54
	internal static extern Double GADURewardedAdGetRewardAmount(IntPtr rewardedAd) { }

	// RVA: 0xA22B58
	internal static extern IntPtr GADUCreateRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA22B5C
	internal static extern IntPtr GADULoadRewardedInterstitialAd(IntPtr rewardedInterstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA22BB0
	internal static extern void GADUShowRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA22BB4
	internal static extern string GADUGetRewardedInterstitialAdUnitID(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA22BE8
	internal static extern void GADUSetRewardedInterstitialAdCallbacks(IntPtr rewardedInterstitialAd, GADURewardedInterstitialAdLoadedCallback adLoadedCallback, GADURewardedInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedInterstitialAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedInterstitialAdPaidEventCallback paidEventCallback, GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedInterstitialAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA22CCC
	internal static extern void GADURewardedInterstitialAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA22CD0
	internal static extern string GADURewardedInterstitialAdGetRewardType(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA22D04
	internal static extern Double GADURewardedInterstitialAdGetRewardAmount(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA22D08
	internal static extern IntPtr GADUCreateNativeAdOptions(int adChoicesPlacement, int mediaAspectRatio, IntPtr videoOptions) { }

	// RVA: 0xA22D0C
	internal static extern IntPtr GADUCreateNativeTemplateTextStyle() { }

	// RVA: 0xA22D10
	internal static extern IntPtr GADUSetNativeTemplateTextColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA22D14
	internal static extern IntPtr GADUSetNativeTemplateTextBackgroundColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA22D18
	internal static extern IntPtr GADUSetNativeTemplateTextFontStyle(IntPtr templateTextStyle, int fontType) { }

	// RVA: 0xA22D1C
	internal static extern IntPtr GADUSetNativeTemplateTextFontSize(IntPtr templateTextStyle, int size) { }

	// RVA: 0xA22D20
	internal static extern IntPtr GADUCreateNativeTemplateStyle(string templateName) { }

	// RVA: 0xA22D54
	internal static extern IntPtr GADUSetNativeTemplateStyleBackgroundColor(IntPtr templateStyle, IntPtr color) { }

	// RVA: 0xA22D58
	internal static extern IntPtr GADUSetNativeTemplateStyleText(IntPtr templateStyle, string textType, IntPtr color) { }

	// RVA: 0xA22DAC
	internal static extern IntPtr GADUCreateNativeTemplateAd(IntPtr nativeAdClient) { }

	// RVA: 0xA22DB0
	internal static extern void GADUSetNativeTemplateAdCallbacks(IntPtr nativeTemplateAd, GADUNativeAdLoadedCallback adLoadedCallback, GADUNativeAdFailedToLoadCallback adFailedCallback, GADUNativeAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUNativeAdDidRecordClickCallback adDidRecordClickCallback, GADUNativePaidEventCallback paidEventCallback, GADUNativeAdWillPresentScreenCallback willPresentCallback, GADUNativeAdDidDismissScreenCallback didDismissCallback) { }

	// RVA: 0xA22E6C
	internal static extern void GADULoadNativeTemplateAd(IntPtr nativeTemplateAd, string adUnitID, IntPtr nativeAdOptions, IntPtr request) { }

	// RVA: 0xA22EBC
	internal static extern void GADUShowNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle, int height, int width) { }

	// RVA: 0xA22EC0
	internal static extern void GADUShowDefaultNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle) { }

	// RVA: 0xA22EC4
	internal static extern void GADUSetNativeTemplateAdPosition(IntPtr nativeTemplateAd, int position) { }

	// RVA: 0xA22EC8
	internal static extern void GADUSetNativeTemplateAdCustomPosition(IntPtr nativeTemplateAd, int x, int y) { }

	// RVA: 0xA22ECC
	internal static extern void GADUHideNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA22ED0
	internal static extern void GADUDisplayNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA22ED4
	internal static extern void GADUDestroyNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA22ED8
	internal static extern float GADUGetNativeTemplateAdHeightInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA22EDC
	internal static extern float GADUGetNativeTemplateAdWidthInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA22EE0
	internal static extern void GADUPresentAdInspector(IntPtr mobileAdsClient, GADUAdInspectorClosedCallback callback) { }

	// RVA: 0xA1B160
	internal static extern string GADUAdapterResponseInfoAdNetworkClassName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B1CC
	internal static extern string GADUAdapterResponseInfoAdSourceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B238
	internal static extern string GADUAdapterResponseInfoAdSourceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B2A4
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B310
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B34C
	internal static extern Int64 GADUAdapterResponseInfoLatency(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B4E0
	internal static extern int GADUAdapterResponseInfoAdUnitMappingCount(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B4E4
	internal static extern string GADUAdapterResponseInfoAdUnitMappingKey(IntPtr adapterResponseInfoRef, int index) { }

	// RVA: 0xA1B518
	internal static extern string GADUAdapterResponseInfoAdUnitMappingValue(IntPtr adapterResponseInfoRef, string key) { }

	// RVA: 0xA1B5F4
	internal static extern IntPtr GADUAdapterResponseInfoAdError(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA1B630
	internal static extern string GADUAdapterResponseInfoDescription(IntPtr error) { }

}

// Namespace: GoogleMobileAds
public class GoogleMobileAdsClientFactory
{
	// Methods

	// RVA: 0xA22F0C
	public void .ctor() { }

	// RVA: 0xA22F14
	public IAppStateEventClient BuildAppStateEventClient() { }

	// RVA: 0xA23034
	public IAppOpenAdClient BuildAppOpenAdClient() { }

	// RVA: 0xA2317C
	public IBannerClient BuildBannerClient() { }

	// RVA: 0xA232C4
	public IAdManagerBannerClient BuildAdManagerBannerClient() { }

	// RVA: 0xA2340C
	public IInterstitialClient BuildInterstitialClient() { }

	// RVA: 0xA2355C
	public IAdManagerInterstitialClient BuildAdManagerInterstitialClient() { }

	// RVA: 0xA236A4
	public IRewardedAdClient BuildRewardedAdClient() { }

	// RVA: 0xA237F4
	public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient() { }

	// RVA: 0xA23944
	public INativeOverlayAdClient BuildNativeOverlayAdClient() { }

	// RVA: 0xA23A94
	public IApplicationPreferencesClient ApplicationPreferencesInstance() { }

	// RVA: 0xA23BDC
	public IMobileAdsClient MobileAdsInstance() { }

}

// Namespace: GoogleMobileAds.iOS
public class InitializationStatusClient
{
	// Fields
	private IntPtr status; // 0x10

	// Methods

	// RVA: 0xA23D88
	public void .ctor(IntPtr status) { }

	// RVA: 0xA23DB4
	public AdapterStatus getAdapterStatusForClassName(string className) { }

	// RVA: 0xA23F78
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap() { }

	// RVA: 0xA24284
	public System.Collections.Generic.List<System.String> GetAdapterClassNames() { }

	// RVA: 0xA244B4
	public void Dispose() { }

	// RVA: 0xA244BC
	protected override void Finalize() { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA260D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA269F8
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA26A0C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA26AC8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA2617C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26AD4
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA26AE8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA26BB4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA26554
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26BC0
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA26BD4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA26CEC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA262C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26CF8
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA26D0C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA26DD8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA26220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26DE4
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA26DF8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA26EB4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA26368
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26EC0
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA26ED4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA26F90
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA2640C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA26F9C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA26FB0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2706C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA264B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA27078
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA2708C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA27148
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA23554
	public void .ctor() { }

	// RVA: 0xA24DFC
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA24EB0
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA24F64
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA25018
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA250CC
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA25180
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA25234
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA252E8
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA2539C
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA25450
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA25504
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA255B8
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2566C
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA25720
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA257D4
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA25878
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA2591C
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA25924
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA25950
	public void CreateInterstitialAd() { }

	// RVA: 0xA265F8
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA2666C
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA266E0
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA26744
	public void Show() { }

	// RVA: 0xA2674C
	public string GetAdUnitID() { }

	// RVA: 0xA26784
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA267F8
	public void DestroyInterstitial() { }

	// RVA: 0xA26820
	public void Dispose() { }

	// RVA: 0xA26880
	protected override void Finalize() { }

	// RVA: 0xA24550
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0xA24658
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA247A8
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA248E0
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA24A30
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA24B38
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA24C40
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0xA24D48
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA2694C
	private static InterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class LoadAdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0xA176B0
	public void .ctor(IntPtr error) { }

	// RVA: 0xA27154
	public int GetCode() { }

	// RVA: 0xA2715C
	public string GetDomain() { }

	// RVA: 0xA27194
	public string GetMessage() { }

	// RVA: 0xA271CC
	public IAdErrorClient GetCause() { }

	// RVA: 0xA27240
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA272B4
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAdInspectorClosedCallback
{
	// Methods

	// RVA: 0xA284E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA28788
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA2879C
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA28868
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInitializationCompleteCallback
{
	// Methods

	// RVA: 0xA27A20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA28874
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr initStatusClient) { }

	// RVA: 0xA28888
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr initStatusClient, AsyncCallback callback, object object) { }

	// RVA: 0xA28954
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class MobileAdsClient
{
	// Fields
	private static MobileAdsClient instance; // 0x0
	private System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> adInspectorClosedAction; // 0x10
	private System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction; // 0x18
	private IntPtr mobileAdsClientPtr; // 0x20
	private static GADUInitializationCompleteCallback <>f__mg$cache0; // 0x8
	private static GADUAdInspectorClosedCallback <>f__mg$cache1; // 0x10

	// Methods

	// RVA: 0xA277D4
	private void .ctor() { }

	// RVA: 0xA27808
	public static MobileAdsClient get_Instance() { }

	// RVA: 0xA27884
	public void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction) { }

	// RVA: 0xA27AC4
	public void DisableMediationInitialization() { }

	// RVA: 0xA27AC8
	public void SetApplicationVolume(float volume) { }

	// RVA: 0xA27ACC
	public void SetApplicationMuted(bool muted) { }

	// RVA: 0xA27AD4
	public void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA28034
	public RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA2829C
	public void SetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA282A4
	public void DisableSDKCrashReporting() { }

	// RVA: 0xA282A8
	public float GetDeviceScale() { }

	// RVA: 0xA282AC
	public int GetDeviceSafeWidth() { }

	// RVA: 0xA282B0
	public void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) { }

	// RVA: 0xA28344
	public void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed) { }

	// RVA: 0xA272EC
	private static void AdInspectorClosedCallback(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA27498
	private static void InitializationCompleteCallback(IntPtr mobileAdsClient, IntPtr initStatus) { }

	// RVA: 0xA28584
	private static MobileAdsClient IntPtrToMobileAdsClient(IntPtr mobileAdsClient) { }

	// RVA: 0xA28630
	public void Dispose() { }

	// RVA: 0xA28664
	protected override void Finalize() { }

	// RVA: 0xA2870C
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
public sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xA28960
	public void .ctor(Type type) { }

}

// Namespace: 
internal sealed class GADUNativeAdLoadedCallback
{
	// Methods

	// RVA: 0xA2A290
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2ADB0
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA2ADC4
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2AE80
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA2A334
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2AE8C
	public virtual void Invoke(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA2AEA0
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA2AF6C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativePaidEventCallback
{
	// Methods

	// RVA: 0xA2A520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2AF78
	public virtual void Invoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA2AF8C
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA2B0A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA2A3D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2B0B0
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA2B0C4
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2B180
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA2A47C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2B18C
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA2B1A0
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2B25C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA2A5C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2B268
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA2B27C
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2B338
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA2A668
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2B344
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA2B358
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2B414
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA23A8C
	public void .ctor() { }

	// RVA: 0xA290C4
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA29178
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2922C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA292E0
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA29394
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA29448
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA294FC
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA295A0
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA29644
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA296F8
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA297AC
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA29860
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA29914
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA299C8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA29A7C
	private static NativeOverlayAdClient IntPtrToNativeClient(IntPtr nativeClient) { }

	// RVA: 0xA29B28
	private IntPtr get_NativePtr() { }

	// RVA: 0xA29B30
	private void set_NativePtr(IntPtr value) { }

	// RVA: 0xA29B5C
	public void Load(string adUnitID, AdRequest request, NativeAdOptions nativeOptions) { }

	// RVA: 0xA2A750
	public void Hide() { }

	// RVA: 0xA2A758
	public void Show() { }

	// RVA: 0xA2A760
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, AdPosition adPosition) { }

	// RVA: 0xA2A9C4
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, int x, int y) { }

	// RVA: 0xA2AA20
	public void Render(NativeTemplateStyle templateViewStyle, AdPosition adPosition) { }

	// RVA: 0xA2AA5C
	public void Render(NativeTemplateStyle templateViewStyle, int x, int y) { }

	// RVA: 0xA2AAA8
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA2AAB0
	public void SetPosition(int x, int y) { }

	// RVA: 0xA2AAB8
	public float GetHeightInPixels() { }

	// RVA: 0xA2AAC0
	public float GetWidthInPixels() { }

	// RVA: 0xA2AAC8
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA2AB3C
	public void DestroyAd() { }

	// RVA: 0xA2AB64
	public void Dispose() { }

	// RVA: 0xA2ABB0
	protected override void Finalize() { }

	// RVA: 0xA28968
	private static void NativeLoadedCallback(IntPtr nativeClient) { }

	// RVA: 0xA28A70
	private static void NativeFailedToLoadCallback(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA28BC0
	private static void NativePaidEventCallback(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA28CF8
	private static void AdDidRecordImpressionCallback(IntPtr nativeClient) { }

	// RVA: 0xA28E00
	private static void AdDidRecordClickCallback(IntPtr nativeClient) { }

	// RVA: 0xA28EB4
	private static void NativeAdWillPresentScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA28FBC
	private static void NativeAdDidDismissScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA2A70C
	public static IntPtr BuildNativeAdOptions(NativeAdOptions options) { }

	// RVA: 0xA2A7B4
	public static IntPtr BuildNativeTemplateStyles(NativeTemplateStyle templateStyle) { }

	// RVA: 0xA2AC68
	public static IntPtr BuildNativeTemplateTextStyle(NativeTemplateTextStyle textStyle) { }

}

// Namespace: GoogleMobileAds.iOS
public class RequestConfigurationClient
{
	// Fields
	private static IntPtr requestConfigurationPtr; // 0x0

	// Methods

	// RVA: 0xA2B420
	public void .ctor() { }

	// RVA: 0xA27B54
	public static void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA2809C
	public static RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA2B428
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
internal class ResponseInfoClient
{
	// Fields
	private IntPtr _iosResponseInfo; // 0x10

	// Methods

	// RVA: 0xA17494
	public void .ctor(ResponseInfoClientType type, IntPtr ptr) { }

	// RVA: 0xA2B478
	public void .ctor(IntPtr adFormat, IntPtr iOSClient) { }

	// RVA: 0xA2B4A4
	public System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses() { }

	// RVA: 0xA2B5FC
	public IAdapterResponseInfoClient GetLoadedAdapterResponseInfo() { }

	// RVA: 0xA2B694
	public System.Collections.Generic.Dictionary<System.String,System.String> GetResponseExtras() { }

	// RVA: 0xA2B838
	public string GetMediationAdapterClassName() { }

	// RVA: 0xA2B8C8
	public string GetResponseId() { }

	// RVA: 0xA2B958
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADURewardedAdLoadedCallback
{
	// Methods

	// RVA: 0xA2D8C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E3D0
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA2E3E4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2E4A0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA2D96C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E4AC
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA2E4C0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA2E58C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA2DD44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E598
	public virtual void Invoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA2E5AC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA2E69C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdPaidEventCallback
{
	// Methods

	// RVA: 0xA2DDE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E6A8
	public virtual void Invoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA2E6BC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA2E7D4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA2DAB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E7E0
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA2E7F4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA2E8C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA2DA10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E8CC
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA2E8E0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2E99C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA2DB58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2E9A8
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA2E9BC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2EA78
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA2DBFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2EA84
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA2EA98
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2EB54
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA2DCA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA2EB60
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA2EB74
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA2EC30
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA237EC
	public void .ctor() { }

	// RVA: 0xA2C3CC
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2C480
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2C534
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA2C5E8
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA2C69C
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA2C750
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA2C804
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA2C8B8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA2C96C
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA2CA20
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA2CAD4
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CB88
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CC3C
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CCF0
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CDA4
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CE58
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2CF0C
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA2CFB0
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA2D054
	private IntPtr get_RewardedAdPtr() { }

	// RVA: 0xA2D05C
	private void set_RewardedAdPtr(IntPtr value) { }

	// RVA: 0xA2D088
	public void CreateRewardedAd() { }

	// RVA: 0xA2DE8C
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA2DF00
	public IRewardedAdClient PollAd(string adUnitId) { }

	// RVA: 0xA2DF80
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA2DFE4
	public void Show() { }

	// RVA: 0xA2DFEC
	public string GetAdUnitID() { }

	// RVA: 0xA2E024
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA2E0D4
	public Reward GetRewardItem() { }

	// RVA: 0xA2E184
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA2E1F8
	public void DestroyRewardedAd() { }

	// RVA: 0xA2E220
	public void Dispose() { }

	// RVA: 0xA2E26C
	protected override void Finalize() { }

	// RVA: 0xA2B9E8
	private static void RewardedAdLoadedCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA2BAF0
	private static void RewardedAdFailedToLoadCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA2BC40
	private static void RewardedAdUserDidEarnRewardCallback(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA2BD78
	private static void RewardedAdPaidEventCallback(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA2BEB0
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA2C000
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA2C108
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA2C210
	private static void AdDidRecordImpressionCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA2C318
	private static void AdDidRecordClickCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA2E324
	private static RewardedAdClient IntPtrToRewardedAdClient(IntPtr rewardedAdClient) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA30B1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA314B8
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA314CC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA31588
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA30BC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31594
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA315A8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA31674
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA30C64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31680
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA31694
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA31784
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdPaidEventCallback
{
	// Methods

	// RVA: 0xA30D08
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31790
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA317A4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA318BC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA30DAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA318C8
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA318DC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA319A8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA30E50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA319B4
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA319C8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA31A84
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA30EF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31A90
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA31AA4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA31B60
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA30F98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31B6C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA31B80
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA31C3C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA3103C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA31C48
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA31C5C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA31D18
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA2393C
	public void .ctor() { }

	// RVA: 0xA2F620
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2F6D4
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2F788
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA2F83C
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA2F8F0
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA2F9A4
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA2FA58
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA2FB0C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA2FBC0
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA2FC74
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA2FD28
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2FDDC
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2FE90
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2FF44
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA2FFF8
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA300AC
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA30160
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA30204
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA302A8
	private IntPtr get_RewardedInterstitialAdPtr() { }

	// RVA: 0xA302B0
	private void set_RewardedInterstitialAdPtr(IntPtr value) { }

	// RVA: 0xA302DC
	public void CreateRewardedInterstitialAd() { }

	// RVA: 0xA310E0
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA31144
	public void Show() { }

	// RVA: 0xA3114C
	public string GetAdUnitID() { }

	// RVA: 0xA31184
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA311BC
	public Reward GetRewardItem() { }

	// RVA: 0xA3126C
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA312E0
	public void DestroyRewardedInterstitialAd() { }

	// RVA: 0xA31308
	public void Dispose() { }

	// RVA: 0xA31354
	protected override void Finalize() { }

	// RVA: 0xA2EC3C
	private static void RewardedInterstitialAdLoadedCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA2ED44
	private static void RewardedInterstitialAdFailedToLoadCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA2EE94
	private static void RewardedInterstitialAdUserDidEarnRewardCallback(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA2EFCC
	private static void RewardedInterstitialAdPaidEventCallback(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA2F104
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA2F254
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA2F35C
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA2F464
	private static void AdDidRecordImpressionCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA2F56C
	private static void AdDidRecordClickCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA3140C
	private static RewardedInterstitialAdClient IntPtrToRewardedInterstitialAdClient(IntPtr rewardedInterstitialAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Utils
{
	// Methods

	// RVA: 0xA31D24
	public void .ctor() { }

	// RVA: 0xA20D40
	public static IntPtr BuildAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA16344
	public static IntPtr BuildAdManagerAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA2E05C
	public static IntPtr BuildServerSideVerificationOptions(ServerSideVerificationOptions options) { }

	// RVA: 0xA23EFC
	public static string PtrToString(IntPtr stringPtr) { }

	// RVA: 0xA242BC
	public static System.Collections.Generic.List<System.String> PtrArrayToManagedList(IntPtr arrayPtr, int numOfAssets) { }

}


