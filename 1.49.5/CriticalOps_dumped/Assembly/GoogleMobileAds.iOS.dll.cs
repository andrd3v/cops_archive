// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.iOS
internal class AdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9FA2A4
	public void .ctor(IntPtr error) { }

	// RVA: 0x9FA2D0
	public int GetCode() { }

	// RVA: 0x9FA2DC
	public string GetDomain() { }

	// RVA: 0x9FA348
	public string GetMessage() { }

	// RVA: 0x9FA3B4
	public IAdErrorClient GetCause() { }

	// RVA: 0x9FA42C
	public override string ToString() { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdInspectorErrorClient
{
	// Methods

	// RVA: 0x9FA498
	public void .ctor(IntPtr error) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0x9FC370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE678
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9FE68C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FE748
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0x9FC414
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE754
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9FE768
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x9FE834
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0x9FC4B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE840
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9FE854
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FE910
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0x9FC55C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE91C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9FE930
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FE9EC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0x9FC600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FE9F8
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9FEA0C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0x9FEB24
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0x9FC6A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FEB30
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9FEB44
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FEC00
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0x9FC748
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FEC0C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0x9FEC20
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0x9FECDC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUAdViewAppEventCallback
{
	// Methods

	// RVA: 0x9FC7EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9FECE8
	public virtual void Invoke(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9FECFC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0x9FEDCC
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

	// RVA: 0x9FACF4
	public void .ctor() { }

	// RVA: 0x9FACFC
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FADB0
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FAE64
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FAF18
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FAFCC
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FB080
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FB134
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FB1E8
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FB29C
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FB350
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FB404
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9FB4B8
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9FB56C
	public void add_OnAdClicked(Action value) { }

	// RVA: 0x9FB610
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0x9FB6B4
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9FB758
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0x9FB7FC
	public System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> get_ValidAdSizes() { }

	// RVA: 0x9FB804
	public void set_ValidAdSizes(System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> value) { }

	// RVA: 0x9FBA10
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0x9FBA18
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0x9FBA48
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0x9FC968
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0x9FD2A4
	public void LoadAd(AdRequest request) { }

	// RVA: 0x9FE298
	public void ShowBannerView() { }

	// RVA: 0x9FE2A4
	public void HideBannerView() { }

	// RVA: 0x9FE2B0
	public void DestroyBannerView() { }

	// RVA: 0x9FE2E4
	public string GetAdUnitID() { }

	// RVA: 0x9FE350
	public float GetHeightInPixels() { }

	// RVA: 0x9FE35C
	public float GetWidthInPixels() { }

	// RVA: 0x9FE368
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0x9FE374
	public void SetPosition(int x, int y) { }

	// RVA: 0x9FE380
	public bool IsCollapsible() { }

	// RVA: 0x9FE3BC
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0x9FE48C
	public void Dispose() { }

	// RVA: 0x9FE4E0
	protected override void Finalize() { }

	// RVA: 0x9FA4C4
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0x9FA5CC
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0x9FA71C
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9FA824
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0x9FA92C
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9FAA64
	private static void AdViewAppEventCallback(IntPtr bannerClient, string name, string info) { }

	// RVA: 0x9FAB8C
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9FAC40
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0x9FE5A0
	private static AdManagerBannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA00CB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0184C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA01860
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0191C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA00D58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01928
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA0193C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA01A08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA01130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01A14
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA01A28
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA01B40
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUInterstitialAppEventCallback
{
	// Methods

	// RVA: 0xA011D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01B4C
	public virtual void Invoke(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0xA01B60
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0xA01C30
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA00EA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01C3C
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA01C50
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA01D1C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA00DFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01D28
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA01D3C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA01DF8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA00F44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01E04
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA01E18
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA01ED4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA00FE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01EE0
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA01EF4
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA01FB0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA0108C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA01FBC
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA01FD0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0208C
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

	// RVA: 0x9FF7AC
	public void .ctor() { }

	// RVA: 0x9FF7B4
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FF868
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FF91C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FF9D0
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0x9FFA84
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FFB38
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0x9FFBEC
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9FFCA0
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0x9FFD54
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9FFE08
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0x9FFEBC
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0x9FFF70
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA00024
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA000D8
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0018C
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA00240
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA002F4
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA00398
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA0043C
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA00444
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA00470
	public void CreateInterstitialAd() { }

	// RVA: 0xA0135C
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA013D0
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA01450
	public IAdManagerInterstitialClient PollAdManagerAd(string adUnitId) { }

	// RVA: 0xA014D0
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA01588
	public void Show() { }

	// RVA: 0xA01594
	public string GetAdUnitID() { }

	// RVA: 0xA01600
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA01674
	public void DestroyInterstitial() { }

	// RVA: 0xA0169C
	public void Dispose() { }

	// RVA: 0xA016E8
	protected override void Finalize() { }

	// RVA: 0x9FEDD8
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FEEE0
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FF030
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0x9FF168
	private static void InterstitialAppEventCallback(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0x9FF290
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0x9FF3E0
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FF4E8
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FF5F0
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0x9FF6F8
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA017A0
	private static AdManagerInterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdapterResponseInfoClient
{
	// Fields
	private IntPtr _adapterResponseInfoPtr; // 0x10

	// Methods

	// RVA: 0xA02098
	internal void .ctor(IntPtr adapterResponseInfoPtr) { }

	// RVA: 0xA020C4
	public string get_AdapterClassName() { }

	// RVA: 0xA02130
	public string get_AdSourceId() { }

	// RVA: 0xA0219C
	public string get_AdSourceName() { }

	// RVA: 0xA02208
	public string get_AdSourceInstanceId() { }

	// RVA: 0xA02274
	public string get_AdSourceInstanceName() { }

	// RVA: 0xA022E0
	public Int64 get_LatencyMillis() { }

	// RVA: 0xA022EC
	public System.Collections.Generic.Dictionary<System.String,System.String> get_AdUnitMapping() { }

	// RVA: 0xA02510
	public IAdErrorClient get_AdError() { }

	// RVA: 0xA02594
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAppOpenAdLoadedCallback
{
	// Methods

	// RVA: 0xA04194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA04BF0
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA04C04
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA04CC0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailToLoadCallback
{
	// Methods

	// RVA: 0xA04238
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA04CCC
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA04CE0
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA04DAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdPaidEventCallback
{
	// Methods

	// RVA: 0xA042DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA04DB8
	public virtual void Invoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA04DCC
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA04EE4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA04380
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA04EF0
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA04F04
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA04FD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA04424
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA04FDC
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA04FF0
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA050AC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA044C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA050B8
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA050CC
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA05188
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA0456C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA05194
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA051A8
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA05264
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA04610
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA05270
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA05284
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA05340
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

	// RVA: 0xA02EAC
	public void .ctor() { }

	// RVA: 0xA02EB4
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA02F68
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0301C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA030D0
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA03184
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA03238
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA032EC
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA033A0
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA03454
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA03508
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA035BC
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA03670
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA03724
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA037C8
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA0386C
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA03920
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA039D4
	private IntPtr get_AppOpenAdPtr() { }

	// RVA: 0xA039DC
	private void set_AppOpenAdPtr(IntPtr value) { }

	// RVA: 0xA03A08
	public void CreateAppOpenAd() { }

	// RVA: 0xA0478C
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA04800
	public IAppOpenAdClient PollAd(string adUnitId) { }

	// RVA: 0xA04880
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA0492C
	public void Show() { }

	// RVA: 0xA04938
	public string GetAdUnitID() { }

	// RVA: 0xA049A4
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA04A18
	public void DestroyAppOpenAd() { }

	// RVA: 0xA04A40
	public void Dispose() { }

	// RVA: 0xA04A8C
	protected override void Finalize() { }

	// RVA: 0xA02600
	private static void AppOpenAdLoadedCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA02708
	private static void AppOpenAdFailedToLoadCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA02858
	private static void AppOpenAdPaidEventCallback(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA02990
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA02AE0
	private static void AdWillPresentFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA02BE8
	private static void AdDidDismissFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA02CF0
	private static void AdDidRecordImpressionCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA02DF8
	private static void AdDidRecordClickCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA04B44
	private static AppOpenAdClient IntPtrToAppOpenAdClient(IntPtr appOpenAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
public class ApplicationPreferencesClient
{
	// Methods

	// RVA: 0xA0534C
	public void .ctor() { }

	// RVA: 0xA05354
	public void SetInt(string key, int value) { }

	// RVA: 0xA053B8
	public void SetString(string key, string value) { }

	// RVA: 0xA0544C
	public int GetInt(string key) { }

	// RVA: 0xA054B8
	public string GetString(string key) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0xA06EBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08AA4
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA08AB8
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA08B74
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0xA06F60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08B80
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA08B94
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA08C60
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA07004
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08C6C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA08C80
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA08D3C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA070A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08D48
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA08D5C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA08E18
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0xA0714C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08E24
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA08E38
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA08F50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0xA071F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA08F5C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA08F70
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0902C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0xA07294
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA09038
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA0904C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA09108
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

	// RVA: 0xA05C5C
	public void .ctor() { }

	// RVA: 0xA05C64
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA05D18
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA05DCC
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA05E80
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA05F34
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA05FE8
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0609C
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA06150
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA06204
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA062B8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA0636C
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA06410
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA064B4
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA06558
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA065FC
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0xA06604
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0xA06630
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0xA073F4
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0xA07CA0
	public void LoadAd(AdRequest request) { }

	// RVA: 0xA08784
	public void ShowBannerView() { }

	// RVA: 0xA0878C
	public void HideBannerView() { }

	// RVA: 0xA08794
	public void DestroyBannerView() { }

	// RVA: 0xA087C4
	public string GetAdUnitID() { }

	// RVA: 0xA08830
	public float GetHeightInPixels() { }

	// RVA: 0xA08838
	public float GetWidthInPixels() { }

	// RVA: 0xA08840
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA08848
	public void SetPosition(int x, int y) { }

	// RVA: 0xA08850
	public bool IsCollapsible() { }

	// RVA: 0xA08870
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA088E4
	public void Dispose() { }

	// RVA: 0xA08938
	protected override void Finalize() { }

	// RVA: 0xA05554
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0xA0565C
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA057AC
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA058B4
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA059BC
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA05AF4
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA05BA8
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA089F8
	private static BannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA09114
	public void .ctor() { }

	// RVA: 0xA0911C
	internal static extern void GADUInitializeWithCallback(IntPtr mobileAdsClient, GADUInitializationCompleteCallback callback) { }

	// RVA: 0xA09148
	internal static extern void GADUDisableMediationInitialization() { }

	// RVA: 0xA0914C
	internal static extern IntPtr GADUGetInitDescription(IntPtr status, string className) { }

	// RVA: 0xA09190
	internal static extern int GADUGetInitLatency(IntPtr status, string className) { }

	// RVA: 0xA091D4
	internal static extern int GADUGetInitState(IntPtr status, string className) { }

	// RVA: 0xA09218
	internal static extern IntPtr GADUGetInitAdapterClasses(IntPtr status) { }

	// RVA: 0xA0921C
	internal static extern int GADUGetInitNumberOfAdapterClasses(IntPtr status) { }

	// RVA: 0xA09220
	internal static extern void GADUSetApplicationVolume(float volume) { }

	// RVA: 0xA09224
	internal static extern void GADUSetApplicationMuted(bool muted) { }

	// RVA: 0xA09228
	internal static extern void GADUSetPlugin(string plugin) { }

	// RVA: 0xA09250
	internal static extern void GADUSetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA09254
	internal static extern void GADUDisableSDKCrashReporting() { }

	// RVA: 0xA09258
	internal static extern float GADUDeviceScale() { }

	// RVA: 0xA0925C
	internal static extern int GADUDeviceSafeWidth() { }

	// RVA: 0xA05388
	internal static extern void GADUSetIntegerPreference(string key, int value) { }

	// RVA: 0xA05404
	internal static extern void GADUSetStringPreference(string key, string value) { }

	// RVA: 0xA05484
	internal static extern int GADUGetIntegerPreference(string key) { }

	// RVA: 0xA05508
	internal static extern string GADUGetStringPreference(string key) { }

	// RVA: 0xA09260
	internal static extern IntPtr GADUCreateRequest() { }

	// RVA: 0xA09264
	internal static extern IntPtr GAMUCreateRequest() { }

	// RVA: 0xA09268
	internal static extern IntPtr GADUCreateMutableDictionary() { }

	// RVA: 0xA0926C
	internal static extern void GADUMutableDictionarySetValue(IntPtr mutableDictionaryPtr, string key, string value) { }

	// RVA: 0xA092C8
	internal static extern void GADUSetMediationExtras(IntPtr request, IntPtr mutableDictionaryPtr, string adNetworkExtrasClassName) { }

	// RVA: 0xA09310
	internal static extern void GADUAddKeyword(IntPtr request, string keyword) { }

	// RVA: 0xA09348
	internal static extern void GADUSetExtra(IntPtr request, string key, string value) { }

	// RVA: 0xA093A4
	internal static extern void GAMUSetPublisherProvidedID(IntPtr request, string publisherProvidedID) { }

	// RVA: 0xA093DC
	internal static extern void GAMUAddCategoryExclusion(IntPtr request, string category) { }

	// RVA: 0xA09414
	internal static extern void GAMUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0xA09470
	internal static extern void GADUSetRequestAgent(IntPtr request, string requestAgent) { }

	// RVA: 0x9FBA44
	internal static extern void GADURelease(IntPtr obj) { }

	// RVA: 0xA094A8
	internal static extern IntPtr GADUCreateRequestConfiguration() { }

	// RVA: 0xA094AC
	internal static extern void GADUSetRequestConfiguration(IntPtr requestConfiguration) { }

	// RVA: 0xA094B0
	internal static extern void GADUSetRequestConfigurationTestDeviceIdentifiers(IntPtr requestConfiguration, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA0958C
	internal static extern void GADUSetRequestConfigurationMaxAdContentRating(IntPtr requestConfiguration, string maxAdContentRating) { }

	// RVA: 0xA095C4
	internal static extern void GADUSetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration, int tagForUnderAgeOfConsent) { }

	// RVA: 0xA095C8
	internal static extern void GADUSetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration, int tagForChildDirectedTreatment) { }

	// RVA: 0xA095CC
	internal static extern void GADUSetRequestConfigurationPublisherFirstPartyIDEnabled(bool enabled) { }

	// RVA: 0xA095D0
	internal static extern void GADUSetRequestConfigurationPublisherPrivacyPersonalizationState(int state) { }

	// RVA: 0xA095D4
	internal static extern IntPtr GADUGetTestDeviceIdentifiers(IntPtr request) { }

	// RVA: 0xA095D8
	internal static extern int GADUGetTestDeviceIdentifiersCount(IntPtr request) { }

	// RVA: 0xA095DC
	internal static extern string GADUGetMaxAdContentRating(IntPtr requestConfiguration) { }

	// RVA: 0xA09610
	internal static extern int GADUGetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration) { }

	// RVA: 0xA09614
	internal static extern int GADUGetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration) { }

	// RVA: 0xA09618
	internal static extern int GADUGetRequestConfigurationPublisherPrivacyPersonalizationState() { }

	// RVA: 0xA0961C
	internal static extern IntPtr GADUCreateUIColor(float alpha, float red, float green, float blue) { }

	// RVA: 0xA09620
	internal static extern IntPtr GADUCreateVideoOptions(bool startMuted, bool clickToExpandRequested, bool customControlsRequested) { }

	// RVA: 0xA04190
	internal static extern IntPtr GADUCreateAppOpenAd(IntPtr appOpenAdClient) { }

	// RVA: 0xA048E4
	internal static extern void GADULoadAppOpenAdWithAdUnitID(IntPtr appOpenAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA04934
	internal static extern void GADUShowAppOpenAd(IntPtr appOpenAd) { }

	// RVA: 0xA046B4
	internal static extern void GADUSetAppOpenAdCallbacks(IntPtr appOpenAd, GADUAppOpenAdLoadedCallback adLoadedCallback, GADUAppOpenAdFailToLoadCallback adFailedToLoadCallback, GADUAppOpenAdPaidEventCallback paidEventCallback, GADUAppOpenAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUAppOpenAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUAppOpenAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUAppOpenAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUAppOpenAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA04970
	internal static extern string GADUGetAppOpenAdUnitID(IntPtr appOpenAd) { }

	// RVA: 0xA06E50
	internal static extern IntPtr GADUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int positionAtTop) { }

	// RVA: 0xA07C2C
	internal static extern IntPtr GADUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0xA06D90
	internal static extern IntPtr GADUCreateSmartBannerView(IntPtr bannerClient, string adUnitId, int positionAtTop) { }

	// RVA: 0xA07B5C
	internal static extern IntPtr GADUCreateSmartBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int x, int y) { }

	// RVA: 0xA06DE4
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int positionAtTop) { }

	// RVA: 0xA07BB8
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0xA07338
	internal static extern void GADUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback) { }

	// RVA: 0x9FE2AC
	internal static extern void GADUHideBannerView(IntPtr bannerView) { }

	// RVA: 0x9FE2A0
	internal static extern void GADUShowBannerView(IntPtr bannerView) { }

	// RVA: 0x9FE2E0
	internal static extern void GADURemoveBannerView(IntPtr bannerView) { }

	// RVA: 0x9FE294
	internal static extern void GADURequestBannerAd(IntPtr bannerView, IntPtr request) { }

	// RVA: 0xA087FC
	internal static extern string GADUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9FE358
	internal static extern float GADUGetBannerViewHeightInPixels(IntPtr bannerView) { }

	// RVA: 0x9FE364
	internal static extern float GADUGetBannerViewWidthInPixels(IntPtr bannerView) { }

	// RVA: 0x9FE370
	internal static extern void GADUSetBannerViewAdPosition(IntPtr bannerView, int position) { }

	// RVA: 0x9FE37C
	internal static extern void GADUSetBannerViewCustomPosition(IntPtr bannerView, int x, int y) { }

	// RVA: 0x9FE3A0
	internal static extern bool GADUIsBannerViewCollapsible(IntPtr bannerView) { }

	// RVA: 0xA09624
	internal static extern IntPtr GADUGetResponseInfo(IntPtr adFormat) { }

	// RVA: 0xA09628
	internal static extern string GADUResponseInfoMediationAdapterClassName(IntPtr responseInfo) { }

	// RVA: 0xA0965C
	internal static extern string GADUResponseInfoResponseId(IntPtr responseInfo) { }

	// RVA: 0xA09690
	internal static extern string GADUGetResponseInfoDescription(IntPtr responseInfo) { }

	// RVA: 0xA096C4
	internal static extern int GADUResponseInfoAdNetworkCount(IntPtr responseInfo) { }

	// RVA: 0xA096C8
	internal static extern IntPtr GADUResponseInfoAdNetworkAtIndex(IntPtr responseInfo, int index) { }

	// RVA: 0xA096CC
	internal static extern IntPtr GADUResponseInfoLoadedAdNetworkResponseInfo(IntPtr responseInfo) { }

	// RVA: 0xA096D0
	internal static extern int GADUResponseInfoExtrasCount(IntPtr responseInfo) { }

	// RVA: 0xA096D4
	internal static extern string GADUResponseInfoExtrasKey(IntPtr responseInfo, int index) { }

	// RVA: 0xA09708
	internal static extern string GADUResponseInfoExtrasValue(IntPtr responseInfo, string key) { }

	// RVA: 0x9FA2D8
	internal static extern int GADUGetAdErrorCode(IntPtr error) { }

	// RVA: 0x9FA314
	internal static extern string GADUGetAdErrorDomain(IntPtr error) { }

	// RVA: 0x9FA380
	internal static extern string GADUGetAdErrorMessage(IntPtr error) { }

	// RVA: 0x9FA428
	internal static extern IntPtr GADUGetAdErrorUnderLyingError(IntPtr error) { }

	// RVA: 0xA09764
	internal static extern IntPtr GADUGetAdErrorResponseInfo(IntPtr error) { }

	// RVA: 0x9FA464
	internal static extern string GADUGetAdErrorDescription(IntPtr error) { }

	// RVA: 0x9FC304
	internal static extern IntPtr GAMUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int adPosition) { }

	// RVA: 0x9FD230
	internal static extern IntPtr GAMUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0x9FC298
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int adPosition) { }

	// RVA: 0x9FD1BC
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0x9FE31C
	internal static extern string GAMUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0x9FC890
	internal static extern void GAMUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback, GAMUAdViewAppEventCallback appEventCallback) { }

	// RVA: 0x9FBA00
	internal static extern void GAMUBannerViewSetValidAdSizes(IntPtr bannerView, int[] validAdSizesArray, int validAdSizesLength) { }

	// RVA: 0xA09768
	internal static extern IntPtr GADUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA0976C
	internal static extern IntPtr GADULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA097C0
	internal static extern string GADUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA097F4
	internal static extern void GADUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adReceivedCallback, GADUInterstitialAdFailedToLoadCallback adFailedCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback) { }

	// RVA: 0xA01590
	internal static extern void GADUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA00CB0
	internal static extern IntPtr GAMUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA01534
	internal static extern IntPtr GAMULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA015CC
	internal static extern string GAMUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA01278
	internal static extern void GAMUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adLoadedCallback, GADUInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback, GAMUInterstitialAppEventCallback appEventCallback) { }

	// RVA: 0xA098CC
	internal static extern void GAMUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA098D0
	internal static extern IntPtr GADUCreateRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA098D4
	internal static extern IntPtr GADULoadRewardedAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA09928
	internal static extern void GADUShowRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA0992C
	internal static extern string GADUGetRewardedAdUnitID(IntPtr rewardedAd) { }

	// RVA: 0xA09960
	internal static extern void GADUSetRewardedAdCallbacks(IntPtr rewardedAd, GADURewardedAdLoadedCallback adLoadedCallback, GADURewardedAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedAdDidRecordClickCallback adDidRecordClickCallback, GADURewardedAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedAdPaidEventCallback paidEventCallback) { }

	// RVA: 0xA09A44
	internal static extern IntPtr GADUCreateServerSideVerificationOptions() { }

	// RVA: 0xA09A48
	internal static extern void GADUServerSideVerificationOptionsSetUserId(IntPtr options, string userId) { }

	// RVA: 0xA09A80
	internal static extern void GADUServerSideVerificationOptionsSetCustomRewardString(IntPtr options, string customRewardString) { }

	// RVA: 0xA09AB8
	internal static extern void GADURewardedAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA09ABC
	internal static extern string GADURewardedAdGetRewardType(IntPtr rewardedAd) { }

	// RVA: 0xA09AF0
	internal static extern Double GADURewardedAdGetRewardAmount(IntPtr rewardedAd) { }

	// RVA: 0xA09AF4
	internal static extern IntPtr GADUCreateRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA09AF8
	internal static extern IntPtr GADULoadRewardedInterstitialAd(IntPtr rewardedInterstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA09B4C
	internal static extern void GADUShowRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA09B50
	internal static extern string GADUGetRewardedInterstitialAdUnitID(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA09B84
	internal static extern void GADUSetRewardedInterstitialAdCallbacks(IntPtr rewardedInterstitialAd, GADURewardedInterstitialAdLoadedCallback adLoadedCallback, GADURewardedInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedInterstitialAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedInterstitialAdPaidEventCallback paidEventCallback, GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedInterstitialAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA09C68
	internal static extern void GADURewardedInterstitialAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA09C6C
	internal static extern string GADURewardedInterstitialAdGetRewardType(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA09CA0
	internal static extern Double GADURewardedInterstitialAdGetRewardAmount(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA09CA4
	internal static extern IntPtr GADUCreateNativeAdOptions(int adChoicesPlacement, int mediaAspectRatio, IntPtr videoOptions) { }

	// RVA: 0xA09CA8
	internal static extern IntPtr GADUCreateNativeTemplateTextStyle() { }

	// RVA: 0xA09CAC
	internal static extern IntPtr GADUSetNativeTemplateTextColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA09CB0
	internal static extern IntPtr GADUSetNativeTemplateTextBackgroundColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA09CB4
	internal static extern IntPtr GADUSetNativeTemplateTextFontStyle(IntPtr templateTextStyle, int fontType) { }

	// RVA: 0xA09CB8
	internal static extern IntPtr GADUSetNativeTemplateTextFontSize(IntPtr templateTextStyle, int size) { }

	// RVA: 0xA09CBC
	internal static extern IntPtr GADUCreateNativeTemplateStyle(string templateName) { }

	// RVA: 0xA09CF0
	internal static extern IntPtr GADUSetNativeTemplateStyleBackgroundColor(IntPtr templateStyle, IntPtr color) { }

	// RVA: 0xA09CF4
	internal static extern IntPtr GADUSetNativeTemplateStyleText(IntPtr templateStyle, string textType, IntPtr color) { }

	// RVA: 0xA09D48
	internal static extern IntPtr GADUCreateNativeTemplateAd(IntPtr nativeAdClient) { }

	// RVA: 0xA09D4C
	internal static extern void GADUSetNativeTemplateAdCallbacks(IntPtr nativeTemplateAd, GADUNativeAdLoadedCallback adLoadedCallback, GADUNativeAdFailedToLoadCallback adFailedCallback, GADUNativeAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUNativeAdDidRecordClickCallback adDidRecordClickCallback, GADUNativePaidEventCallback paidEventCallback, GADUNativeAdWillPresentScreenCallback willPresentCallback, GADUNativeAdDidDismissScreenCallback didDismissCallback) { }

	// RVA: 0xA09E08
	internal static extern void GADULoadNativeTemplateAd(IntPtr nativeTemplateAd, string adUnitID, IntPtr nativeAdOptions, IntPtr request) { }

	// RVA: 0xA09E58
	internal static extern void GADUShowNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle, int height, int width) { }

	// RVA: 0xA09E5C
	internal static extern void GADUShowDefaultNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle) { }

	// RVA: 0xA09E60
	internal static extern void GADUSetNativeTemplateAdPosition(IntPtr nativeTemplateAd, int position) { }

	// RVA: 0xA09E64
	internal static extern void GADUSetNativeTemplateAdCustomPosition(IntPtr nativeTemplateAd, int x, int y) { }

	// RVA: 0xA09E68
	internal static extern void GADUHideNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA09E6C
	internal static extern void GADUDisplayNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA09E70
	internal static extern void GADUDestroyNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA09E74
	internal static extern float GADUGetNativeTemplateAdHeightInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA09E78
	internal static extern float GADUGetNativeTemplateAdWidthInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA09E7C
	internal static extern void GADUPresentAdInspector(IntPtr mobileAdsClient, GADUAdInspectorClosedCallback callback) { }

	// RVA: 0xA020FC
	internal static extern string GADUAdapterResponseInfoAdNetworkClassName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA02168
	internal static extern string GADUAdapterResponseInfoAdSourceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA021D4
	internal static extern string GADUAdapterResponseInfoAdSourceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA02240
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA022AC
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA022E8
	internal static extern Int64 GADUAdapterResponseInfoLatency(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA0247C
	internal static extern int GADUAdapterResponseInfoAdUnitMappingCount(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA02480
	internal static extern string GADUAdapterResponseInfoAdUnitMappingKey(IntPtr adapterResponseInfoRef, int index) { }

	// RVA: 0xA024B4
	internal static extern string GADUAdapterResponseInfoAdUnitMappingValue(IntPtr adapterResponseInfoRef, string key) { }

	// RVA: 0xA02590
	internal static extern IntPtr GADUAdapterResponseInfoAdError(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA025CC
	internal static extern string GADUAdapterResponseInfoDescription(IntPtr error) { }

}

// Namespace: GoogleMobileAds
public class GoogleMobileAdsClientFactory
{
	// Methods

	// RVA: 0xA09EA8
	public void .ctor() { }

	// RVA: 0xA09EB0
	public IAppStateEventClient BuildAppStateEventClient() { }

	// RVA: 0xA09FD0
	public IAppOpenAdClient BuildAppOpenAdClient() { }

	// RVA: 0xA0A118
	public IBannerClient BuildBannerClient() { }

	// RVA: 0xA0A260
	public IAdManagerBannerClient BuildAdManagerBannerClient() { }

	// RVA: 0xA0A3A8
	public IInterstitialClient BuildInterstitialClient() { }

	// RVA: 0xA0A4F8
	public IAdManagerInterstitialClient BuildAdManagerInterstitialClient() { }

	// RVA: 0xA0A640
	public IRewardedAdClient BuildRewardedAdClient() { }

	// RVA: 0xA0A790
	public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient() { }

	// RVA: 0xA0A8E0
	public INativeOverlayAdClient BuildNativeOverlayAdClient() { }

	// RVA: 0xA0AA30
	public IApplicationPreferencesClient ApplicationPreferencesInstance() { }

	// RVA: 0xA0AB78
	public IMobileAdsClient MobileAdsInstance() { }

}

// Namespace: GoogleMobileAds.iOS
public class InitializationStatusClient
{
	// Fields
	private IntPtr status; // 0x10

	// Methods

	// RVA: 0xA0AD24
	public void .ctor(IntPtr status) { }

	// RVA: 0xA0AD50
	public AdapterStatus getAdapterStatusForClassName(string className) { }

	// RVA: 0xA0AF14
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap() { }

	// RVA: 0xA0B220
	public System.Collections.Generic.List<System.String> GetAdapterClassNames() { }

	// RVA: 0xA0B450
	public void Dispose() { }

	// RVA: 0xA0B458
	protected override void Finalize() { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA0D074
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0D994
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA0D9A8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0DA64
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA0D118
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DA70
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA0DA84
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA0DB50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA0D4F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DB5C
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA0DB70
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA0DC88
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA0D260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DC94
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA0DCA8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA0DD74
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA0D1BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DD80
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA0DD94
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0DE50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA0D304
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DE5C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA0DE70
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0DF2C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA0D3A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0DF38
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA0DF4C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0E008
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA0D44C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0E014
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA0E028
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0E0E4
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

	// RVA: 0xA0A4F0
	public void .ctor() { }

	// RVA: 0xA0BD98
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0BE4C
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0BF00
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA0BFB4
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA0C068
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA0C11C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA0C1D0
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA0C284
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA0C338
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C3EC
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C4A0
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C554
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C608
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C6BC
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA0C770
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA0C814
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA0C8B8
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA0C8C0
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA0C8EC
	public void CreateInterstitialAd() { }

	// RVA: 0xA0D594
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA0D608
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA0D67C
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA0D6E0
	public void Show() { }

	// RVA: 0xA0D6E8
	public string GetAdUnitID() { }

	// RVA: 0xA0D720
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA0D794
	public void DestroyInterstitial() { }

	// RVA: 0xA0D7BC
	public void Dispose() { }

	// RVA: 0xA0D81C
	protected override void Finalize() { }

	// RVA: 0xA0B4EC
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0xA0B5F4
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA0B744
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA0B87C
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA0B9CC
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA0BAD4
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA0BBDC
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0xA0BCE4
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA0D8E8
	private static InterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class LoadAdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0x9FE64C
	public void .ctor(IntPtr error) { }

	// RVA: 0xA0E0F0
	public int GetCode() { }

	// RVA: 0xA0E0F8
	public string GetDomain() { }

	// RVA: 0xA0E130
	public string GetMessage() { }

	// RVA: 0xA0E168
	public IAdErrorClient GetCause() { }

	// RVA: 0xA0E1DC
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA0E250
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAdInspectorClosedCallback
{
	// Methods

	// RVA: 0xA0F47C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0F724
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA0F738
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA0F804
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInitializationCompleteCallback
{
	// Methods

	// RVA: 0xA0E9BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0F810
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr initStatusClient) { }

	// RVA: 0xA0F824
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr initStatusClient, AsyncCallback callback, object object) { }

	// RVA: 0xA0F8F0
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

	// RVA: 0xA0E770
	private void .ctor() { }

	// RVA: 0xA0E7A4
	public static MobileAdsClient get_Instance() { }

	// RVA: 0xA0E820
	public void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction) { }

	// RVA: 0xA0EA60
	public void DisableMediationInitialization() { }

	// RVA: 0xA0EA64
	public void SetApplicationVolume(float volume) { }

	// RVA: 0xA0EA68
	public void SetApplicationMuted(bool muted) { }

	// RVA: 0xA0EA70
	public void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA0EFD0
	public RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA0F238
	public void SetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA0F240
	public void DisableSDKCrashReporting() { }

	// RVA: 0xA0F244
	public float GetDeviceScale() { }

	// RVA: 0xA0F248
	public int GetDeviceSafeWidth() { }

	// RVA: 0xA0F24C
	public void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) { }

	// RVA: 0xA0F2E0
	public void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed) { }

	// RVA: 0xA0E288
	private static void AdInspectorClosedCallback(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA0E434
	private static void InitializationCompleteCallback(IntPtr mobileAdsClient, IntPtr initStatus) { }

	// RVA: 0xA0F520
	private static MobileAdsClient IntPtrToMobileAdsClient(IntPtr mobileAdsClient) { }

	// RVA: 0xA0F5CC
	public void Dispose() { }

	// RVA: 0xA0F600
	protected override void Finalize() { }

	// RVA: 0xA0F6A8
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
public sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xA0F8FC
	public void .ctor(Type type) { }

}

// Namespace: 
internal sealed class GADUNativeAdLoadedCallback
{
	// Methods

	// RVA: 0xA1122C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA11D4C
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA11D60
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA11E1C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA112D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA11E28
	public virtual void Invoke(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA11E3C
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA11F08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativePaidEventCallback
{
	// Methods

	// RVA: 0xA114BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA11F14
	public virtual void Invoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA11F28
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA12040
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA11374
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1204C
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA12060
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1211C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA11418
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA12128
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA1213C
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA121F8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA11560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA12204
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA12218
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA122D4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA11604
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA122E0
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA122F4
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA123B0
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

	// RVA: 0xA0AA28
	public void .ctor() { }

	// RVA: 0xA10060
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA10114
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA101C8
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1027C
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA10330
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA103E4
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA10498
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA1053C
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA105E0
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA10694
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA10748
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA107FC
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA108B0
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA10964
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA10A18
	private static NativeOverlayAdClient IntPtrToNativeClient(IntPtr nativeClient) { }

	// RVA: 0xA10AC4
	private IntPtr get_NativePtr() { }

	// RVA: 0xA10ACC
	private void set_NativePtr(IntPtr value) { }

	// RVA: 0xA10AF8
	public void Load(string adUnitID, AdRequest request, NativeAdOptions nativeOptions) { }

	// RVA: 0xA116EC
	public void Hide() { }

	// RVA: 0xA116F4
	public void Show() { }

	// RVA: 0xA116FC
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, AdPosition adPosition) { }

	// RVA: 0xA11960
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, int x, int y) { }

	// RVA: 0xA119BC
	public void Render(NativeTemplateStyle templateViewStyle, AdPosition adPosition) { }

	// RVA: 0xA119F8
	public void Render(NativeTemplateStyle templateViewStyle, int x, int y) { }

	// RVA: 0xA11A44
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA11A4C
	public void SetPosition(int x, int y) { }

	// RVA: 0xA11A54
	public float GetHeightInPixels() { }

	// RVA: 0xA11A5C
	public float GetWidthInPixels() { }

	// RVA: 0xA11A64
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA11AD8
	public void DestroyAd() { }

	// RVA: 0xA11B00
	public void Dispose() { }

	// RVA: 0xA11B4C
	protected override void Finalize() { }

	// RVA: 0xA0F904
	private static void NativeLoadedCallback(IntPtr nativeClient) { }

	// RVA: 0xA0FA0C
	private static void NativeFailedToLoadCallback(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA0FB5C
	private static void NativePaidEventCallback(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA0FC94
	private static void AdDidRecordImpressionCallback(IntPtr nativeClient) { }

	// RVA: 0xA0FD9C
	private static void AdDidRecordClickCallback(IntPtr nativeClient) { }

	// RVA: 0xA0FE50
	private static void NativeAdWillPresentScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA0FF58
	private static void NativeAdDidDismissScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA116A8
	public static IntPtr BuildNativeAdOptions(NativeAdOptions options) { }

	// RVA: 0xA11750
	public static IntPtr BuildNativeTemplateStyles(NativeTemplateStyle templateStyle) { }

	// RVA: 0xA11C04
	public static IntPtr BuildNativeTemplateTextStyle(NativeTemplateTextStyle textStyle) { }

}

// Namespace: GoogleMobileAds.iOS
public class RequestConfigurationClient
{
	// Fields
	private static IntPtr requestConfigurationPtr; // 0x0

	// Methods

	// RVA: 0xA123BC
	public void .ctor() { }

	// RVA: 0xA0EAF0
	public static void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA0F038
	public static RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA123C4
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
internal class ResponseInfoClient
{
	// Fields
	private IntPtr _iosResponseInfo; // 0x10

	// Methods

	// RVA: 0x9FE430
	public void .ctor(ResponseInfoClientType type, IntPtr ptr) { }

	// RVA: 0xA12414
	public void .ctor(IntPtr adFormat, IntPtr iOSClient) { }

	// RVA: 0xA12440
	public System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses() { }

	// RVA: 0xA12598
	public IAdapterResponseInfoClient GetLoadedAdapterResponseInfo() { }

	// RVA: 0xA12630
	public System.Collections.Generic.Dictionary<System.String,System.String> GetResponseExtras() { }

	// RVA: 0xA127D4
	public string GetMediationAdapterClassName() { }

	// RVA: 0xA12864
	public string GetResponseId() { }

	// RVA: 0xA128F4
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADURewardedAdLoadedCallback
{
	// Methods

	// RVA: 0xA14864
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1536C
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA15380
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA1543C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA14908
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15448
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA1545C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA15528
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA14CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15534
	public virtual void Invoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA15548
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA15638
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdPaidEventCallback
{
	// Methods

	// RVA: 0xA14D84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15644
	public virtual void Invoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA15658
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA15770
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA14A50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1577C
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA15790
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA1585C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA149AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15868
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA1587C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA15938
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA14AF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15944
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA15958
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA15A14
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA14B98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15A20
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA15A34
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA15AF0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA14C3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA15AFC
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA15B10
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA15BCC
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

	// RVA: 0xA0A788
	public void .ctor() { }

	// RVA: 0xA13368
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA1341C
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA134D0
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA13584
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA13638
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA136EC
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA137A0
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA13854
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA13908
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA139BC
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA13A70
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13B24
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13BD8
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13C8C
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13D40
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13DF4
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA13EA8
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA13F4C
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA13FF0
	private IntPtr get_RewardedAdPtr() { }

	// RVA: 0xA13FF8
	private void set_RewardedAdPtr(IntPtr value) { }

	// RVA: 0xA14024
	public void CreateRewardedAd() { }

	// RVA: 0xA14E28
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA14E9C
	public IRewardedAdClient PollAd(string adUnitId) { }

	// RVA: 0xA14F1C
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA14F80
	public void Show() { }

	// RVA: 0xA14F88
	public string GetAdUnitID() { }

	// RVA: 0xA14FC0
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA15070
	public Reward GetRewardItem() { }

	// RVA: 0xA15120
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA15194
	public void DestroyRewardedAd() { }

	// RVA: 0xA151BC
	public void Dispose() { }

	// RVA: 0xA15208
	protected override void Finalize() { }

	// RVA: 0xA12984
	private static void RewardedAdLoadedCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA12A8C
	private static void RewardedAdFailedToLoadCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA12BDC
	private static void RewardedAdUserDidEarnRewardCallback(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA12D14
	private static void RewardedAdPaidEventCallback(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA12E4C
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA12F9C
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA130A4
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA131AC
	private static void AdDidRecordImpressionCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA132B4
	private static void AdDidRecordClickCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA152C0
	private static RewardedAdClient IntPtrToRewardedAdClient(IntPtr rewardedAdClient) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA17AB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18454
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA18468
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA18524
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA17B5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18530
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA18544
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA18610
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA17C00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1861C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA18630
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA18720
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdPaidEventCallback
{
	// Methods

	// RVA: 0xA17CA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1872C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA18740
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA18858
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA17D48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18864
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA18878
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA18944
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA17DEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18950
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA18964
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA18A20
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA17E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18A2C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA18A40
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA18AFC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA17F34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18B08
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA18B1C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA18BD8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA17FD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA18BE4
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA18BF8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA18CB4
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

	// RVA: 0xA0A8D8
	public void .ctor() { }

	// RVA: 0xA165BC
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16670
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16724
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA167D8
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA1688C
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA16940
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA169F4
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA16AA8
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA16B5C
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA16C10
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA16CC4
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16D78
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16E2C
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16EE0
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA16F94
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA17048
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA170FC
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA171A0
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA17244
	private IntPtr get_RewardedInterstitialAdPtr() { }

	// RVA: 0xA1724C
	private void set_RewardedInterstitialAdPtr(IntPtr value) { }

	// RVA: 0xA17278
	public void CreateRewardedInterstitialAd() { }

	// RVA: 0xA1807C
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA180E0
	public void Show() { }

	// RVA: 0xA180E8
	public string GetAdUnitID() { }

	// RVA: 0xA18120
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA18158
	public Reward GetRewardItem() { }

	// RVA: 0xA18208
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA1827C
	public void DestroyRewardedInterstitialAd() { }

	// RVA: 0xA182A4
	public void Dispose() { }

	// RVA: 0xA182F0
	protected override void Finalize() { }

	// RVA: 0xA15BD8
	private static void RewardedInterstitialAdLoadedCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA15CE0
	private static void RewardedInterstitialAdFailedToLoadCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA15E30
	private static void RewardedInterstitialAdUserDidEarnRewardCallback(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA15F68
	private static void RewardedInterstitialAdPaidEventCallback(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA160A0
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA161F0
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA162F8
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA16400
	private static void AdDidRecordImpressionCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA16508
	private static void AdDidRecordClickCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA183A8
	private static RewardedInterstitialAdClient IntPtrToRewardedInterstitialAdClient(IntPtr rewardedInterstitialAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Utils
{
	// Methods

	// RVA: 0xA18CC0
	public void .ctor() { }

	// RVA: 0xA07CDC
	public static IntPtr BuildAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0x9FD2E0
	public static IntPtr BuildAdManagerAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA14FF8
	public static IntPtr BuildServerSideVerificationOptions(ServerSideVerificationOptions options) { }

	// RVA: 0xA0AE98
	public static string PtrToString(IntPtr stringPtr) { }

	// RVA: 0xA0B258
	public static System.Collections.Generic.List<System.String> PtrArrayToManagedList(IntPtr arrayPtr, int numOfAssets) { }

}


