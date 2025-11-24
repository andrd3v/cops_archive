// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.iOS
internal class AdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9EB024
	public void .ctor(IntPtr error) { }

	// RVA: 0x9EB050
	public int GetCode() { }

	// RVA: 0x9EB05C
	public string GetDomain() { }

	// RVA: 0x9EB0C8
	public string GetMessage() { }

	// RVA: 0x9EB134
	public IAdErrorClient GetCause() { }

	// RVA: 0x9EB1AC
	public override string ToString() { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdInspectorErrorClient
{
	// Methods

	// RVA: 0x9EB218
	public void .ctor(IntPtr error) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0x9ED0F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF3F8
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9EF40C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9EF4C8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0x9ED194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF4D4
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9EF4E8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9EF5B4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0x9ED238
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF5C0
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9EF5D4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9EF690
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0x9ED2DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF69C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9EF6B0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9EF76C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0x9ED380
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF778
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9EF78C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9EF8A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0x9ED424
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF8B0
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9EF8C4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9EF980
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0x9ED4C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EF98C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9EF9A0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9EFA5C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUAdViewAppEventCallback
{
	// Methods

	// RVA: 0x9ED56C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9EFA68
	public virtual void Invoke(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9EFA7C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0x9EFB4C
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

	// RVA: 0x9EBA74
	public void .ctor() { }

	// RVA: 0x9EBA7C
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EBB30
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EBBE4
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9EBC98
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9EBD4C
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EBE00
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EBEB4
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EBF68
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9EC01C
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9EC0D0
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9EC184
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9EC238
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9EC2EC
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9EC390
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9EC434
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9EC4D8
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9EC57C
	public System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> get_ValidAdSizes() { }

	// RVA: 0x9EC584
	public void set_ValidAdSizes(System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> value) { }

	// RVA: 0x9EC790
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0x9EC798
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0x9EC7C8
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0x9ED6E8
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0x9EE024
	public void LoadAd(AdRequest request) { }

	// RVA: 0x9EF018
	public void ShowBannerView() { }

	// RVA: 0x9EF024
	public void HideBannerView() { }

	// RVA: 0x9EF030
	public void DestroyBannerView() { }

	// RVA: 0x9EF064
	public string GetAdUnitID() { }

	// RVA: 0x9EF0D0
	public float GetHeightInPixels() { }

	// RVA: 0x9EF0DC
	public float GetWidthInPixels() { }

	// RVA: 0x9EF0E8
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9EF0F4
	public void SetPosition(int x, int y) { }

	// RVA: 0x9EF100
	public bool IsCollapsible() { }

	// RVA: 0x9EF13C
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9EF20C
	public void Dispose() { }

	// RVA: 0x9EF260
	protected override void Finalize() { }

	// RVA: 0x9EB244
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0x9EB34C
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9EB49C
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9EB5A4
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9EB6AC
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9EB7E4
	private static void AdViewAppEventCallback(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9EB90C
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9EB9C0
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9EF320
	private static AdManagerBannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0x9F1A34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F25CC
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9F25E0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F269C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0x9F1AD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F26A8
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9F26BC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9F2788
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0x9F1EB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F2794
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9F27A8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9F28C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUInterstitialAppEventCallback
{
	// Methods

	// RVA: 0x9F1F54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F28CC
	public virtual void Invoke(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0x9F28E0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0x9F29B0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F1C20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F29BC
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9F29D0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9F2A9C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F1B7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F2AA8
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9F2ABC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F2B78
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F1CC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F2B84
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9F2B98
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F2C54
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0x9F1D68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F2C60
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9F2C74
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F2D30
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0x9F1E0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F2D3C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9F2D50
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F2E0C
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

	// RVA: 0x9F052C
	public void .ctor() { }

	// RVA: 0x9F0534
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F05E8
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F069C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F0750
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F0804
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F08B8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F096C
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9F0A20
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9F0AD4
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9F0B88
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9F0C3C
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F0CF0
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F0DA4
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F0E58
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F0F0C
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F0FC0
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F1074
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9F1118
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9F11BC
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0x9F11C4
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0x9F11F0
	public void CreateInterstitialAd() { }

	// RVA: 0x9F20DC
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9F2150
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0x9F21D0
	public IAdManagerInterstitialClient PollAdManagerAd(string adUnitId) { }

	// RVA: 0x9F2250
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9F2308
	public void Show() { }

	// RVA: 0x9F2314
	public string GetAdUnitID() { }

	// RVA: 0x9F2380
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9F23F4
	public void DestroyInterstitial() { }

	// RVA: 0x9F241C
	public void Dispose() { }

	// RVA: 0x9F2468
	protected override void Finalize() { }

	// RVA: 0x9EFB58
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0x9EFC60
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9EFDB0
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9EFEE8
	private static void InterstitialAppEventCallback(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0x9F0010
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9F0160
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9F0268
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9F0370
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0x9F0478
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0x9F2520
	private static AdManagerInterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdapterResponseInfoClient
{
	// Fields
	private IntPtr _adapterResponseInfoPtr; // 0x10

	// Methods

	// RVA: 0x9F2E18
	internal void .ctor(IntPtr adapterResponseInfoPtr) { }

	// RVA: 0x9F2E44
	public string get_AdapterClassName() { }

	// RVA: 0x9F2EB0
	public string get_AdSourceId() { }

	// RVA: 0x9F2F1C
	public string get_AdSourceName() { }

	// RVA: 0x9F2F88
	public string get_AdSourceInstanceId() { }

	// RVA: 0x9F2FF4
	public string get_AdSourceInstanceName() { }

	// RVA: 0x9F3060
	public Int64 get_LatencyMillis() { }

	// RVA: 0x9F306C
	public System.Collections.Generic.Dictionary<System.String,System.String> get_AdUnitMapping() { }

	// RVA: 0x9F3290
	public IAdErrorClient get_AdError() { }

	// RVA: 0x9F3314
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAppOpenAdLoadedCallback
{
	// Methods

	// RVA: 0x9F4F14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5970
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9F5984
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F5A40
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailToLoadCallback
{
	// Methods

	// RVA: 0x9F4FB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5A4C
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9F5A60
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9F5B2C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdPaidEventCallback
{
	// Methods

	// RVA: 0x9F505C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5B38
	public virtual void Invoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9F5B4C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9F5C64
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F5100
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5C70
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9F5C84
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9F5D50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F51A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5D5C
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9F5D70
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F5E2C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0x9F5248
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5E38
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9F5E4C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F5F08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0x9F52EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5F14
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9F5F28
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F5FE4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordClickCallback
{
	// Methods

	// RVA: 0x9F5390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F5FF0
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0x9F6004
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F60C0
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

	// RVA: 0x9F3C2C
	public void .ctor() { }

	// RVA: 0x9F3C34
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F3CE8
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F3D9C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F3E50
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F3F04
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F3FB8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F406C
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9F4120
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9F41D4
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F4288
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F433C
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F43F0
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F44A4
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9F4548
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9F45EC
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F46A0
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F4754
	private IntPtr get_AppOpenAdPtr() { }

	// RVA: 0x9F475C
	private void set_AppOpenAdPtr(IntPtr value) { }

	// RVA: 0x9F4788
	public void CreateAppOpenAd() { }

	// RVA: 0x9F550C
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9F5580
	public IAppOpenAdClient PollAd(string adUnitId) { }

	// RVA: 0x9F5600
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9F56AC
	public void Show() { }

	// RVA: 0x9F56B8
	public string GetAdUnitID() { }

	// RVA: 0x9F5724
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9F5798
	public void DestroyAppOpenAd() { }

	// RVA: 0x9F57C0
	public void Dispose() { }

	// RVA: 0x9F580C
	protected override void Finalize() { }

	// RVA: 0x9F3380
	private static void AppOpenAdLoadedCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9F3488
	private static void AppOpenAdFailedToLoadCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9F35D8
	private static void AppOpenAdPaidEventCallback(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9F3710
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0x9F3860
	private static void AdWillPresentFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9F3968
	private static void AdDidDismissFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9F3A70
	private static void AdDidRecordImpressionCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9F3B78
	private static void AdDidRecordClickCallback(IntPtr appOpenAdClient) { }

	// RVA: 0x9F58C4
	private static AppOpenAdClient IntPtrToAppOpenAdClient(IntPtr appOpenAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
public class ApplicationPreferencesClient
{
	// Methods

	// RVA: 0x9F60CC
	public void .ctor() { }

	// RVA: 0x9F60D4
	public void SetInt(string key, int value) { }

	// RVA: 0x9F6138
	public void SetString(string key, string value) { }

	// RVA: 0x9F61CC
	public int GetInt(string key) { }

	// RVA: 0x9F6238
	public string GetString(string key) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0x9F7C3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9824
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9F9838
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F98F4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0x9F7CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9900
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9F9914
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9F99E0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0x9F7D84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F99EC
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9F9A00
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F9ABC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0x9F7E28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9AC8
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9F9ADC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F9B98
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0x9F7ECC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9BA4
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9F9BB8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9F9CD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0x9F7F70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9CDC
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9F9CF0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F9DAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0x9F8014
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9F9DB8
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9F9DCC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9F9E88
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

	// RVA: 0x9F69DC
	public void .ctor() { }

	// RVA: 0x9F69E4
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6A98
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6B4C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F6C00
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9F6CB4
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6D68
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6E1C
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6ED0
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9F6F84
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F7038
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9F70EC
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9F7190
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9F7234
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9F72D8
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9F737C
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0x9F7384
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0x9F73B0
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0x9F8174
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0x9F8A20
	public void LoadAd(AdRequest request) { }

	// RVA: 0x9F9504
	public void ShowBannerView() { }

	// RVA: 0x9F950C
	public void HideBannerView() { }

	// RVA: 0x9F9514
	public void DestroyBannerView() { }

	// RVA: 0x9F9544
	public string GetAdUnitID() { }

	// RVA: 0x9F95B0
	public float GetHeightInPixels() { }

	// RVA: 0x9F95B8
	public float GetWidthInPixels() { }

	// RVA: 0x9F95C0
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9F95C8
	public void SetPosition(int x, int y) { }

	// RVA: 0x9F95D0
	public bool IsCollapsible() { }

	// RVA: 0x9F95F0
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9F9664
	public void Dispose() { }

	// RVA: 0x9F96B8
	protected override void Finalize() { }

	// RVA: 0x9F62D4
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0x9F63DC
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9F652C
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9F6634
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9F673C
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9F6874
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9F6928
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9F9778
	private static BannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Externs
{
	// Methods

	// RVA: 0x9F9E94
	public void .ctor() { }

	// RVA: 0x9F9E9C
	internal static extern void GADUInitializeWithCallback(IntPtr mobileAdsClient, GADUInitializationCompleteCallback callback) { }

	// RVA: 0x9F9EC8
	internal static extern void GADUDisableMediationInitialization() { }

	// RVA: 0x9F9ECC
	internal static extern IntPtr GADUGetInitDescription(IntPtr status, string className) { }

	// RVA: 0x9F9F10
	internal static extern int GADUGetInitLatency(IntPtr status, string className) { }

	// RVA: 0x9F9F54
	internal static extern int GADUGetInitState(IntPtr status, string className) { }

	// RVA: 0x9F9F98
	internal static extern IntPtr GADUGetInitAdapterClasses(IntPtr status) { }

	// RVA: 0x9F9F9C
	internal static extern int GADUGetInitNumberOfAdapterClasses(IntPtr status) { }

	// RVA: 0x9F9FA0
	internal static extern void GADUSetApplicationVolume(float volume) { }

	// RVA: 0x9F9FA4
	internal static extern void GADUSetApplicationMuted(bool muted) { }

	// RVA: 0x9F9FA8
	internal static extern void GADUSetPlugin(string plugin) { }

	// RVA: 0x9F9FD0
	internal static extern void GADUSetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0x9F9FD4
	internal static extern void GADUDisableSDKCrashReporting() { }

	// RVA: 0x9F9FD8
	internal static extern float GADUDeviceScale() { }

	// RVA: 0x9F9FDC
	internal static extern int GADUDeviceSafeWidth() { }

	// RVA: 0x9F6108
	internal static extern void GADUSetIntegerPreference(string key, int value) { }

	// RVA: 0x9F6184
	internal static extern void GADUSetStringPreference(string key, string value) { }

	// RVA: 0x9F6204
	internal static extern int GADUGetIntegerPreference(string key) { }

	// RVA: 0x9F6288
	internal static extern string GADUGetStringPreference(string key) { }

	// RVA: 0x9F9FE0
	internal static extern IntPtr GADUCreateRequest() { }

	// RVA: 0x9F9FE4
	internal static extern IntPtr GAMUCreateRequest() { }

	// RVA: 0x9F9FE8
	internal static extern IntPtr GADUCreateMutableDictionary() { }

	// RVA: 0x9F9FEC
	internal static extern void GADUMutableDictionarySetValue(IntPtr mutableDictionaryPtr, string key, string value) { }

	// RVA: 0x9FA048
	internal static extern void GADUSetMediationExtras(IntPtr request, IntPtr mutableDictionaryPtr, string adNetworkExtrasClassName) { }

	// RVA: 0x9FA090
	internal static extern void GADUAddKeyword(IntPtr request, string keyword) { }

	// RVA: 0x9FA0C8
	internal static extern void GADUSetExtra(IntPtr request, string key, string value) { }

	// RVA: 0x9FA124
	internal static extern void GAMUSetPublisherProvidedID(IntPtr request, string publisherProvidedID) { }

	// RVA: 0x9FA15C
	internal static extern void GAMUAddCategoryExclusion(IntPtr request, string category) { }

	// RVA: 0x9FA194
	internal static extern void GAMUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0x9FA1F0
	internal static extern void GADUSetRequestAgent(IntPtr request, string requestAgent) { }

	// RVA: 0x9EC7C4
	internal static extern void GADURelease(IntPtr obj) { }

	// RVA: 0x9FA228
	internal static extern IntPtr GADUCreateRequestConfiguration() { }

	// RVA: 0x9FA22C
	internal static extern void GADUSetRequestConfiguration(IntPtr requestConfiguration) { }

	// RVA: 0x9FA230
	internal static extern void GADUSetRequestConfigurationTestDeviceIdentifiers(IntPtr requestConfiguration, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0x9FA30C
	internal static extern void GADUSetRequestConfigurationMaxAdContentRating(IntPtr requestConfiguration, string maxAdContentRating) { }

	// RVA: 0x9FA344
	internal static extern void GADUSetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration, int tagForUnderAgeOfConsent) { }

	// RVA: 0x9FA348
	internal static extern void GADUSetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration, int tagForChildDirectedTreatment) { }

	// RVA: 0x9FA34C
	internal static extern void GADUSetRequestConfigurationPublisherFirstPartyIDEnabled(bool enabled) { }

	// RVA: 0x9FA350
	internal static extern void GADUSetRequestConfigurationPublisherPrivacyPersonalizationState(int state) { }

	// RVA: 0x9FA354
	internal static extern IntPtr GADUGetTestDeviceIdentifiers(IntPtr request) { }

	// RVA: 0x9FA358
	internal static extern int GADUGetTestDeviceIdentifiersCount(IntPtr request) { }

	// RVA: 0x9FA35C
	internal static extern string GADUGetMaxAdContentRating(IntPtr requestConfiguration) { }

	// RVA: 0x9FA390
	internal static extern int GADUGetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration) { }

	// RVA: 0x9FA394
	internal static extern int GADUGetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration) { }

	// RVA: 0x9FA398
	internal static extern int GADUGetRequestConfigurationPublisherPrivacyPersonalizationState() { }

	// RVA: 0x9FA39C
	internal static extern IntPtr GADUCreateUIColor(float alpha, float red, float green, float blue) { }

	// RVA: 0x9FA3A0
	internal static extern IntPtr GADUCreateVideoOptions(bool startMuted, bool clickToExpandRequested, bool customControlsRequested) { }

	// RVA: 0x9F4F10
	internal static extern IntPtr GADUCreateAppOpenAd(IntPtr appOpenAdClient) { }

	// RVA: 0x9F5664
	internal static extern void GADULoadAppOpenAdWithAdUnitID(IntPtr appOpenAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9F56B4
	internal static extern void GADUShowAppOpenAd(IntPtr appOpenAd) { }

	// RVA: 0x9F5434
	internal static extern void GADUSetAppOpenAdCallbacks(IntPtr appOpenAd, GADUAppOpenAdLoadedCallback adLoadedCallback, GADUAppOpenAdFailToLoadCallback adFailedToLoadCallback, GADUAppOpenAdPaidEventCallback paidEventCallback, GADUAppOpenAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUAppOpenAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUAppOpenAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUAppOpenAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUAppOpenAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0x9F56F0
	internal static extern string GADUGetAppOpenAdUnitID(IntPtr appOpenAd) { }

	// RVA: 0x9F7BD0
	internal static extern IntPtr GADUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int positionAtTop) { }

	// RVA: 0x9F89AC
	internal static extern IntPtr GADUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0x9F7B10
	internal static extern IntPtr GADUCreateSmartBannerView(IntPtr bannerClient, string adUnitId, int positionAtTop) { }

	// RVA: 0x9F88DC
	internal static extern IntPtr GADUCreateSmartBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int x, int y) { }

	// RVA: 0x9F7B64
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int positionAtTop) { }

	// RVA: 0x9F8938
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0x9F80B8
	internal static extern void GADUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback) { }

	// RVA: 0x9EF02C
	internal static extern void GADUHideBannerView(IntPtr bannerView) { }

	// RVA: 0x9EF020
	internal static extern void GADUShowBannerView(IntPtr bannerView) { }

	// RVA: 0x9EF060
	internal static extern void GADURemoveBannerView(IntPtr bannerView) { }

	// RVA: 0x9EF014
	internal static extern void GADURequestBannerAd(IntPtr bannerView, IntPtr request) { }

	// RVA: 0x9F957C
	internal static extern string GADUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9EF0D8
	internal static extern float GADUGetBannerViewHeightInPixels(IntPtr bannerView) { }

	// RVA: 0x9EF0E4
	internal static extern float GADUGetBannerViewWidthInPixels(IntPtr bannerView) { }

	// RVA: 0x9EF0F0
	internal static extern void GADUSetBannerViewAdPosition(IntPtr bannerView, int position) { }

	// RVA: 0x9EF0FC
	internal static extern void GADUSetBannerViewCustomPosition(IntPtr bannerView, int x, int y) { }

	// RVA: 0x9EF120
	internal static extern bool GADUIsBannerViewCollapsible(IntPtr bannerView) { }

	// RVA: 0x9FA3A4
	internal static extern IntPtr GADUGetResponseInfo(IntPtr adFormat) { }

	// RVA: 0x9FA3A8
	internal static extern string GADUResponseInfoMediationAdapterClassName(IntPtr responseInfo) { }

	// RVA: 0x9FA3DC
	internal static extern string GADUResponseInfoResponseId(IntPtr responseInfo) { }

	// RVA: 0x9FA410
	internal static extern string GADUGetResponseInfoDescription(IntPtr responseInfo) { }

	// RVA: 0x9FA444
	internal static extern int GADUResponseInfoAdNetworkCount(IntPtr responseInfo) { }

	// RVA: 0x9FA448
	internal static extern IntPtr GADUResponseInfoAdNetworkAtIndex(IntPtr responseInfo, int index) { }

	// RVA: 0x9FA44C
	internal static extern IntPtr GADUResponseInfoLoadedAdNetworkResponseInfo(IntPtr responseInfo) { }

	// RVA: 0x9FA450
	internal static extern int GADUResponseInfoExtrasCount(IntPtr responseInfo) { }

	// RVA: 0x9FA454
	internal static extern string GADUResponseInfoExtrasKey(IntPtr responseInfo, int index) { }

	// RVA: 0x9FA488
	internal static extern string GADUResponseInfoExtrasValue(IntPtr responseInfo, string key) { }

	// RVA: 0x9EB058
	internal static extern int GADUGetAdErrorCode(IntPtr error) { }

	// RVA: 0x9EB094
	internal static extern string GADUGetAdErrorDomain(IntPtr error) { }

	// RVA: 0x9EB100
	internal static extern string GADUGetAdErrorMessage(IntPtr error) { }

	// RVA: 0x9EB1A8
	internal static extern IntPtr GADUGetAdErrorUnderLyingError(IntPtr error) { }

	// RVA: 0x9FA4E4
	internal static extern IntPtr GADUGetAdErrorResponseInfo(IntPtr error) { }

	// RVA: 0x9EB1E4
	internal static extern string GADUGetAdErrorDescription(IntPtr error) { }

	// RVA: 0x9ED084
	internal static extern IntPtr GAMUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int adPosition) { }

	// RVA: 0x9EDFB0
	internal static extern IntPtr GAMUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0x9ED018
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int adPosition) { }

	// RVA: 0x9EDF3C
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0x9EF09C
	internal static extern string GAMUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9ED610
	internal static extern void GAMUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback, GAMUAdViewAppEventCallback appEventCallback) { }

	// RVA: 0x9EC780
	internal static extern void GAMUBannerViewSetValidAdSizes(IntPtr bannerView, int[] validAdSizesArray, int validAdSizesLength) { }

	// RVA: 0x9FA4E8
	internal static extern IntPtr GADUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0x9FA4EC
	internal static extern IntPtr GADULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9FA540
	internal static extern string GADUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0x9FA574
	internal static extern void GADUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adReceivedCallback, GADUInterstitialAdFailedToLoadCallback adFailedCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback) { }

	// RVA: 0x9F2310
	internal static extern void GADUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0x9F1A30
	internal static extern IntPtr GAMUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0x9F22B4
	internal static extern IntPtr GAMULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9F234C
	internal static extern string GAMUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0x9F1FF8
	internal static extern void GAMUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adLoadedCallback, GADUInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback, GAMUInterstitialAppEventCallback appEventCallback) { }

	// RVA: 0x9FA64C
	internal static extern void GAMUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0x9FA650
	internal static extern IntPtr GADUCreateRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0x9FA654
	internal static extern IntPtr GADULoadRewardedAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9FA6A8
	internal static extern void GADUShowRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0x9FA6AC
	internal static extern string GADUGetRewardedAdUnitID(IntPtr rewardedAd) { }

	// RVA: 0x9FA6E0
	internal static extern void GADUSetRewardedAdCallbacks(IntPtr rewardedAd, GADURewardedAdLoadedCallback adLoadedCallback, GADURewardedAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedAdDidRecordClickCallback adDidRecordClickCallback, GADURewardedAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedAdPaidEventCallback paidEventCallback) { }

	// RVA: 0x9FA7C4
	internal static extern IntPtr GADUCreateServerSideVerificationOptions() { }

	// RVA: 0x9FA7C8
	internal static extern void GADUServerSideVerificationOptionsSetUserId(IntPtr options, string userId) { }

	// RVA: 0x9FA800
	internal static extern void GADUServerSideVerificationOptionsSetCustomRewardString(IntPtr options, string customRewardString) { }

	// RVA: 0x9FA838
	internal static extern void GADURewardedAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0x9FA83C
	internal static extern string GADURewardedAdGetRewardType(IntPtr rewardedAd) { }

	// RVA: 0x9FA870
	internal static extern Double GADURewardedAdGetRewardAmount(IntPtr rewardedAd) { }

	// RVA: 0x9FA874
	internal static extern IntPtr GADUCreateRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9FA878
	internal static extern IntPtr GADULoadRewardedInterstitialAd(IntPtr rewardedInterstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0x9FA8CC
	internal static extern void GADUShowRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9FA8D0
	internal static extern string GADUGetRewardedInterstitialAdUnitID(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9FA904
	internal static extern void GADUSetRewardedInterstitialAdCallbacks(IntPtr rewardedInterstitialAd, GADURewardedInterstitialAdLoadedCallback adLoadedCallback, GADURewardedInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedInterstitialAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedInterstitialAdPaidEventCallback paidEventCallback, GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedInterstitialAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0x9FA9E8
	internal static extern void GADURewardedInterstitialAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0x9FA9EC
	internal static extern string GADURewardedInterstitialAdGetRewardType(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9FAA20
	internal static extern Double GADURewardedInterstitialAdGetRewardAmount(IntPtr rewardedInterstitialAd) { }

	// RVA: 0x9FAA24
	internal static extern IntPtr GADUCreateNativeAdOptions(int adChoicesPlacement, int mediaAspectRatio, IntPtr videoOptions) { }

	// RVA: 0x9FAA28
	internal static extern IntPtr GADUCreateNativeTemplateTextStyle() { }

	// RVA: 0x9FAA2C
	internal static extern IntPtr GADUSetNativeTemplateTextColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0x9FAA30
	internal static extern IntPtr GADUSetNativeTemplateTextBackgroundColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0x9FAA34
	internal static extern IntPtr GADUSetNativeTemplateTextFontStyle(IntPtr templateTextStyle, int fontType) { }

	// RVA: 0x9FAA38
	internal static extern IntPtr GADUSetNativeTemplateTextFontSize(IntPtr templateTextStyle, int size) { }

	// RVA: 0x9FAA3C
	internal static extern IntPtr GADUCreateNativeTemplateStyle(string templateName) { }

	// RVA: 0x9FAA70
	internal static extern IntPtr GADUSetNativeTemplateStyleBackgroundColor(IntPtr templateStyle, IntPtr color) { }

	// RVA: 0x9FAA74
	internal static extern IntPtr GADUSetNativeTemplateStyleText(IntPtr templateStyle, string textType, IntPtr color) { }

	// RVA: 0x9FAAC8
	internal static extern IntPtr GADUCreateNativeTemplateAd(IntPtr nativeAdClient) { }

	// RVA: 0x9FAACC
	internal static extern void GADUSetNativeTemplateAdCallbacks(IntPtr nativeTemplateAd, GADUNativeAdLoadedCallback adLoadedCallback, GADUNativeAdFailedToLoadCallback adFailedCallback, GADUNativeAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUNativeAdDidRecordClickCallback adDidRecordClickCallback, GADUNativePaidEventCallback paidEventCallback, GADUNativeAdWillPresentScreenCallback willPresentCallback, GADUNativeAdDidDismissScreenCallback didDismissCallback) { }

	// RVA: 0x9FAB88
	internal static extern void GADULoadNativeTemplateAd(IntPtr nativeTemplateAd, string adUnitID, IntPtr nativeAdOptions, IntPtr request) { }

	// RVA: 0x9FABD8
	internal static extern void GADUShowNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle, int height, int width) { }

	// RVA: 0x9FABDC
	internal static extern void GADUShowDefaultNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle) { }

	// RVA: 0x9FABE0
	internal static extern void GADUSetNativeTemplateAdPosition(IntPtr nativeTemplateAd, int position) { }

	// RVA: 0x9FABE4
	internal static extern void GADUSetNativeTemplateAdCustomPosition(IntPtr nativeTemplateAd, int x, int y) { }

	// RVA: 0x9FABE8
	internal static extern void GADUHideNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9FABEC
	internal static extern void GADUDisplayNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9FABF0
	internal static extern void GADUDestroyNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0x9FABF4
	internal static extern float GADUGetNativeTemplateAdHeightInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0x9FABF8
	internal static extern float GADUGetNativeTemplateAdWidthInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0x9FABFC
	internal static extern void GADUPresentAdInspector(IntPtr mobileAdsClient, GADUAdInspectorClosedCallback callback) { }

	// RVA: 0x9F2E7C
	internal static extern string GADUAdapterResponseInfoAdNetworkClassName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F2EE8
	internal static extern string GADUAdapterResponseInfoAdSourceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F2F54
	internal static extern string GADUAdapterResponseInfoAdSourceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F2FC0
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F302C
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F3068
	internal static extern Int64 GADUAdapterResponseInfoLatency(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F31FC
	internal static extern int GADUAdapterResponseInfoAdUnitMappingCount(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F3200
	internal static extern string GADUAdapterResponseInfoAdUnitMappingKey(IntPtr adapterResponseInfoRef, int index) { }

	// RVA: 0x9F3234
	internal static extern string GADUAdapterResponseInfoAdUnitMappingValue(IntPtr adapterResponseInfoRef, string key) { }

	// RVA: 0x9F3310
	internal static extern IntPtr GADUAdapterResponseInfoAdError(IntPtr adapterResponseInfoRef) { }

	// RVA: 0x9F334C
	internal static extern string GADUAdapterResponseInfoDescription(IntPtr error) { }

}

// Namespace: GoogleMobileAds
public class GoogleMobileAdsClientFactory
{
	// Methods

	// RVA: 0x9FAC28
	public void .ctor() { }

	// RVA: 0x9FAC30
	public IAppStateEventClient BuildAppStateEventClient() { }

	// RVA: 0x9FAD50
	public IAppOpenAdClient BuildAppOpenAdClient() { }

	// RVA: 0x9FAE98
	public IBannerClient BuildBannerClient() { }

	// RVA: 0x9FAFE0
	public IAdManagerBannerClient BuildAdManagerBannerClient() { }

	// RVA: 0x9FB128
	public IInterstitialClient BuildInterstitialClient() { }

	// RVA: 0x9FB278
	public IAdManagerInterstitialClient BuildAdManagerInterstitialClient() { }

	// RVA: 0x9FB3C0
	public IRewardedAdClient BuildRewardedAdClient() { }

	// RVA: 0x9FB510
	public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient() { }

	// RVA: 0x9FB660
	public INativeOverlayAdClient BuildNativeOverlayAdClient() { }

	// RVA: 0x9FB7B0
	public IApplicationPreferencesClient ApplicationPreferencesInstance() { }

	// RVA: 0x9FB8F8
	public IMobileAdsClient MobileAdsInstance() { }

}

// Namespace: GoogleMobileAds.iOS
public class InitializationStatusClient
{
	// Fields
	private IntPtr status; // 0x10

	// Methods

	// RVA: 0x9FBAA4
	public void .ctor(IntPtr status) { }

	// RVA: 0x9FBAD0
	public AdapterStatus getAdapterStatusForClassName(string className) { }

	// RVA: 0x9FBC94
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap() { }

	// RVA: 0x9FBFA0
	public System.Collections.Generic.List<System.String> GetAdapterClassNames() { }

	// RVA: 0x9FC1D0
	public void Dispose() { }

	// RVA: 0x9FC1D8
	protected override void Finalize() { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0x9FDDF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE714
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9FE728
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FE7E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0x9FDE98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE7F0
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FE804
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9FE8D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0x9FE270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE8DC
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9FE8F0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9FEA08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9FDFE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FEA14
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FEA28
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9FEAF4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0x9FDF3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FEB00
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9FEB14
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FEBD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0x9FE084
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FEBDC
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9FEBF0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FECAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0x9FE128
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FECB8
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9FECCC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FED88
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0x9FE1CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FED94
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0x9FEDA8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FEE64
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

	// RVA: 0x9FB270
	public void .ctor() { }

	// RVA: 0x9FCB18
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FCBCC
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FCC80
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FCD34
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FCDE8
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FCE9C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FCF50
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9FD004
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9FD0B8
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD16C
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD220
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD2D4
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD388
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD43C
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FD4F0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9FD594
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9FD638
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0x9FD640
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0x9FD66C
	public void CreateInterstitialAd() { }

	// RVA: 0x9FE314
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0x9FE388
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0x9FE3FC
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0x9FE460
	public void Show() { }

	// RVA: 0x9FE468
	public string GetAdUnitID() { }

	// RVA: 0x9FE4A0
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9FE514
	public void DestroyInterstitial() { }

	// RVA: 0x9FE53C
	public void Dispose() { }

	// RVA: 0x9FE59C
	protected override void Finalize() { }

	// RVA: 0x9FC26C
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FC374
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FC4C4
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9FC5FC
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FC74C
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FC854
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FC95C
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FCA64
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FE668
	private static InterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class LoadAdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9EF3CC
	public void .ctor(IntPtr error) { }

	// RVA: 0x9FEE70
	public int GetCode() { }

	// RVA: 0x9FEE78
	public string GetDomain() { }

	// RVA: 0x9FEEB0
	public string GetMessage() { }

	// RVA: 0x9FEEE8
	public IAdErrorClient GetCause() { }

	// RVA: 0x9FEF5C
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9FEFD0
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAdInspectorClosedCallback
{
	// Methods

	// RVA: 0xA001FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA004A4
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA004B8
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA00584
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInitializationCompleteCallback
{
	// Methods

	// RVA: 0x9FF73C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA00590
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr initStatusClient) { }

	// RVA: 0xA005A4
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr initStatusClient, AsyncCallback callback, object object) { }

	// RVA: 0xA00670
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

	// RVA: 0x9FF4F0
	private void .ctor() { }

	// RVA: 0x9FF524
	public static MobileAdsClient get_Instance() { }

	// RVA: 0x9FF5A0
	public void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction) { }

	// RVA: 0x9FF7E0
	public void DisableMediationInitialization() { }

	// RVA: 0x9FF7E4
	public void SetApplicationVolume(float volume) { }

	// RVA: 0x9FF7E8
	public void SetApplicationMuted(bool muted) { }

	// RVA: 0x9FF7F0
	public void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0x9FFD50
	public RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0x9FFFB8
	public void SetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0x9FFFC0
	public void DisableSDKCrashReporting() { }

	// RVA: 0x9FFFC4
	public float GetDeviceScale() { }

	// RVA: 0x9FFFC8
	public int GetDeviceSafeWidth() { }

	// RVA: 0x9FFFCC
	public void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) { }

	// RVA: 0xA00060
	public void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed) { }

	// RVA: 0x9FF008
	private static void AdInspectorClosedCallback(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0x9FF1B4
	private static void InitializationCompleteCallback(IntPtr mobileAdsClient, IntPtr initStatus) { }

	// RVA: 0xA002A0
	private static MobileAdsClient IntPtrToMobileAdsClient(IntPtr mobileAdsClient) { }

	// RVA: 0xA0034C
	public void Dispose() { }

	// RVA: 0xA00380
	protected override void Finalize() { }

	// RVA: 0xA00428
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
public sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xA0067C
	public void .ctor(Type type) { }

}

// Namespace: 
internal sealed class GADUNativeAdLoadedCallback
{
	// Methods

	// RVA: 0xA01FAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02ACC
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA02AE0
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA02B9C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA02050
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02BA8
	public virtual void Invoke(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA02BBC
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA02C88
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativePaidEventCallback
{
	// Methods

	// RVA: 0xA0223C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02C94
	public virtual void Invoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA02CA8
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA02DC0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA020F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02DCC
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA02DE0
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA02E9C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA02198
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02EA8
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA02EBC
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA02F78
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA022E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA02F84
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA02F98
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA03054
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA02384
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA03060
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA03074
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA03130
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

	// RVA: 0x9FB7A8
	public void .ctor() { }

	// RVA: 0xA00DE0
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA00E94
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA00F48
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA00FFC
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA010B0
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA01164
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA01218
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA012BC
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA01360
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA01414
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA014C8
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0157C
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA01630
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA016E4
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA01798
	private static NativeOverlayAdClient IntPtrToNativeClient(IntPtr nativeClient) { }

	// RVA: 0xA01844
	private IntPtr get_NativePtr() { }

	// RVA: 0xA0184C
	private void set_NativePtr(IntPtr value) { }

	// RVA: 0xA01878
	public void Load(string adUnitID, AdRequest request, NativeAdOptions nativeOptions) { }

	// RVA: 0xA0246C
	public void Hide() { }

	// RVA: 0xA02474
	public void Show() { }

	// RVA: 0xA0247C
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, AdPosition adPosition) { }

	// RVA: 0xA026E0
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, int x, int y) { }

	// RVA: 0xA0273C
	public void Render(NativeTemplateStyle templateViewStyle, AdPosition adPosition) { }

	// RVA: 0xA02778
	public void Render(NativeTemplateStyle templateViewStyle, int x, int y) { }

	// RVA: 0xA027C4
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA027CC
	public void SetPosition(int x, int y) { }

	// RVA: 0xA027D4
	public float GetHeightInPixels() { }

	// RVA: 0xA027DC
	public float GetWidthInPixels() { }

	// RVA: 0xA027E4
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA02858
	public void DestroyAd() { }

	// RVA: 0xA02880
	public void Dispose() { }

	// RVA: 0xA028CC
	protected override void Finalize() { }

	// RVA: 0xA00684
	private static void NativeLoadedCallback(IntPtr nativeClient) { }

	// RVA: 0xA0078C
	private static void NativeFailedToLoadCallback(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA008DC
	private static void NativePaidEventCallback(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA00A14
	private static void AdDidRecordImpressionCallback(IntPtr nativeClient) { }

	// RVA: 0xA00B1C
	private static void AdDidRecordClickCallback(IntPtr nativeClient) { }

	// RVA: 0xA00BD0
	private static void NativeAdWillPresentScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA00CD8
	private static void NativeAdDidDismissScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA02428
	public static IntPtr BuildNativeAdOptions(NativeAdOptions options) { }

	// RVA: 0xA024D0
	public static IntPtr BuildNativeTemplateStyles(NativeTemplateStyle templateStyle) { }

	// RVA: 0xA02984
	public static IntPtr BuildNativeTemplateTextStyle(NativeTemplateTextStyle textStyle) { }

}

// Namespace: GoogleMobileAds.iOS
public class RequestConfigurationClient
{
	// Fields
	private static IntPtr requestConfigurationPtr; // 0x0

	// Methods

	// RVA: 0xA0313C
	public void .ctor() { }

	// RVA: 0x9FF870
	public static void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0x9FFDB8
	public static RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA03144
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
internal class ResponseInfoClient
{
	// Fields
	private IntPtr _iosResponseInfo; // 0x10

	// Methods

	// RVA: 0x9EF1B0
	public void .ctor(ResponseInfoClientType type, IntPtr ptr) { }

	// RVA: 0xA03194
	public void .ctor(IntPtr adFormat, IntPtr iOSClient) { }

	// RVA: 0xA031C0
	public System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses() { }

	// RVA: 0xA03318
	public IAdapterResponseInfoClient GetLoadedAdapterResponseInfo() { }

	// RVA: 0xA033B0
	public System.Collections.Generic.Dictionary<System.String,System.String> GetResponseExtras() { }

	// RVA: 0xA03554
	public string GetMediationAdapterClassName() { }

	// RVA: 0xA035E4
	public string GetResponseId() { }

	// RVA: 0xA03674
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADURewardedAdLoadedCallback
{
	// Methods

	// RVA: 0xA055E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA060EC
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA06100
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA061BC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA05688
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA061C8
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA061DC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA062A8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA05A60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA062B4
	public virtual void Invoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA062C8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA063B8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdPaidEventCallback
{
	// Methods

	// RVA: 0xA05B04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA063C4
	public virtual void Invoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA063D8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA064F0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA057D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA064FC
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA06510
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA065DC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA0572C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA065E8
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA065FC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA066B8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA05874
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA066C4
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA066D8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA06794
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA05918
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA067A0
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA067B4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA06870
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA059BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0687C
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA06890
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0694C
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

	// RVA: 0x9FB508
	public void .ctor() { }

	// RVA: 0xA040E8
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0419C
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04250
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA04304
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA043B8
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA0446C
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA04520
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA045D4
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA04688
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA0473C
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA047F0
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA048A4
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04958
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04A0C
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04AC0
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04B74
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA04C28
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA04CCC
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA04D70
	private IntPtr get_RewardedAdPtr() { }

	// RVA: 0xA04D78
	private void set_RewardedAdPtr(IntPtr value) { }

	// RVA: 0xA04DA4
	public void CreateRewardedAd() { }

	// RVA: 0xA05BA8
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA05C1C
	public IRewardedAdClient PollAd(string adUnitId) { }

	// RVA: 0xA05C9C
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA05D00
	public void Show() { }

	// RVA: 0xA05D08
	public string GetAdUnitID() { }

	// RVA: 0xA05D40
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA05DF0
	public Reward GetRewardItem() { }

	// RVA: 0xA05EA0
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA05F14
	public void DestroyRewardedAd() { }

	// RVA: 0xA05F3C
	public void Dispose() { }

	// RVA: 0xA05F88
	protected override void Finalize() { }

	// RVA: 0xA03704
	private static void RewardedAdLoadedCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA0380C
	private static void RewardedAdFailedToLoadCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA0395C
	private static void RewardedAdUserDidEarnRewardCallback(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA03A94
	private static void RewardedAdPaidEventCallback(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA03BCC
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA03D1C
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA03E24
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA03F2C
	private static void AdDidRecordImpressionCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA04034
	private static void AdDidRecordClickCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA06040
	private static RewardedAdClient IntPtrToRewardedAdClient(IntPtr rewardedAdClient) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA08838
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA091D4
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA091E8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA092A4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA088DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA092B0
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA092C4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA09390
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA08980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0939C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA093B0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA094A0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdPaidEventCallback
{
	// Methods

	// RVA: 0xA08A24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA094AC
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA094C0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA095D8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA08AC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA095E4
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA095F8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA096C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA08B6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA096D0
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA096E4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA097A0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA08C10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA097AC
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA097C0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0987C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA08CB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA09888
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA0989C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA09958
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA08D58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA09964
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA09978
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA09A34
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

	// RVA: 0x9FB658
	public void .ctor() { }

	// RVA: 0xA0733C
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA073F0
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA074A4
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA07558
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA0760C
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA076C0
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA07774
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA07828
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA078DC
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA07990
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA07A44
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07AF8
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07BAC
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07C60
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07D14
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07DC8
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA07E7C
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA07F20
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA07FC4
	private IntPtr get_RewardedInterstitialAdPtr() { }

	// RVA: 0xA07FCC
	private void set_RewardedInterstitialAdPtr(IntPtr value) { }

	// RVA: 0xA07FF8
	public void CreateRewardedInterstitialAd() { }

	// RVA: 0xA08DFC
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA08E60
	public void Show() { }

	// RVA: 0xA08E68
	public string GetAdUnitID() { }

	// RVA: 0xA08EA0
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA08ED8
	public Reward GetRewardItem() { }

	// RVA: 0xA08F88
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA08FFC
	public void DestroyRewardedInterstitialAd() { }

	// RVA: 0xA09024
	public void Dispose() { }

	// RVA: 0xA09070
	protected override void Finalize() { }

	// RVA: 0xA06958
	private static void RewardedInterstitialAdLoadedCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA06A60
	private static void RewardedInterstitialAdFailedToLoadCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA06BB0
	private static void RewardedInterstitialAdUserDidEarnRewardCallback(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA06CE8
	private static void RewardedInterstitialAdPaidEventCallback(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA06E20
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA06F70
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA07078
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA07180
	private static void AdDidRecordImpressionCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA07288
	private static void AdDidRecordClickCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA09128
	private static RewardedInterstitialAdClient IntPtrToRewardedInterstitialAdClient(IntPtr rewardedInterstitialAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Utils
{
	// Methods

	// RVA: 0xA09A40
	public void .ctor() { }

	// RVA: 0x9F8A5C
	public static IntPtr BuildAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0x9EE060
	public static IntPtr BuildAdManagerAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA05D78
	public static IntPtr BuildServerSideVerificationOptions(ServerSideVerificationOptions options) { }

	// RVA: 0x9FBC18
	public static string PtrToString(IntPtr stringPtr) { }

	// RVA: 0x9FBFD8
	public static System.Collections.Generic.List<System.String> PtrArrayToManagedList(IntPtr arrayPtr, int numOfAssets) { }

}


