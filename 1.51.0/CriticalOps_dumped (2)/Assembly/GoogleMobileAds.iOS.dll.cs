// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.iOS
internal class AdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0xA57E44
	public void .ctor(IntPtr error) { }

	// RVA: 0xA57E70
	public int GetCode() { }

	// RVA: 0xA57E7C
	public string GetDomain() { }

	// RVA: 0xA57EE8
	public string GetMessage() { }

	// RVA: 0xA57F54
	public IAdErrorClient GetCause() { }

	// RVA: 0xA57FCC
	public override string ToString() { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdInspectorErrorClient
{
	// Methods

	// RVA: 0xA58038
	public void .ctor(IntPtr error) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0xA59BB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5AF60
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA5AF74
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5B008
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0xA59C58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B014
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA5B028
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA5B0CC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA59CFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B0D8
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA5B0EC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5B180
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA59DA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B18C
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA5B1A0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5B234
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0xA59E44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B240
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA5B254
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA5B31C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0xA59EE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B328
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA5B33C
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5B3D0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0xA59F8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B3DC
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA5B3F0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5B484
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUAdViewAppEventCallback
{
	// Methods

	// RVA: 0xA5A030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5B490
	public virtual void Invoke(IntPtr bannerClient, string name, string info) { }

	// RVA: 0xA5B4A4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0xA5B54C
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

	// RVA: 0xA58548
	public void .ctor() { }

	// RVA: 0xA58550
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA58604
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA586B8
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA5876C
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA58820
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA588D4
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA58988
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA58A3C
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA58AF0
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA58BA4
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA58C58
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA58D0C
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA58DC0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA58E64
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA58F08
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA58FAC
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA59050
	public System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> get_ValidAdSizes() { }

	// RVA: 0xA59058
	public void set_ValidAdSizes(System.Collections.Generic.List<GoogleMobileAds.Api.AdSize> value) { }

	// RVA: 0xA59254
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0xA5925C
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0xA5928C
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0xA5A1AC
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0xA5AAE8
	public void LoadAd(AdRequest request) { }

	// RVA: 0xA5AB2C
	public void ShowBannerView() { }

	// RVA: 0xA5AB38
	public void HideBannerView() { }

	// RVA: 0xA5AB44
	public void DestroyBannerView() { }

	// RVA: 0xA5AB78
	public string GetAdUnitID() { }

	// RVA: 0xA5ABE4
	public float GetHeightInPixels() { }

	// RVA: 0xA5ABF0
	public float GetWidthInPixels() { }

	// RVA: 0xA5ABFC
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA5AC08
	public void SetPosition(int x, int y) { }

	// RVA: 0xA5AC14
	public bool IsCollapsible() { }

	// RVA: 0xA5AC50
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA5AD20
	public void Dispose() { }

	// RVA: 0xA5AD74
	protected override void Finalize() { }

	// RVA: 0xA58064
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0xA58108
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA581F4
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA58298
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA5833C
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA58414
	private static void AdViewAppEventCallback(IntPtr bannerClient, string name, string info) { }

	// RVA: 0xA584D8
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA58510
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA5AE34
	private static AdManagerBannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA5D09C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5DC64
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA5DC78
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5DD0C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA5D140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5DD18
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA5DD2C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA5DDD0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA5D518
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5DDDC
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA5DDF0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA5DEB8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GAMUInterstitialAppEventCallback
{
	// Methods

	// RVA: 0xA5D5BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5DEC4
	public virtual void Invoke(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0xA5DED8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, string name, string info, AsyncCallback callback, object object) { }

	// RVA: 0xA5DF80
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA5D288
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5DF8C
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA5DFA0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA5E044
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA5D1E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5E050
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA5E064
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5E0F8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA5D32C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5E104
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA5E118
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5E1AC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA5D3D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5E1B8
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA5E1CC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5E260
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA5D474
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA5E26C
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA5E280
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA5E314
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

	// RVA: 0xA5BB94
	public void .ctor() { }

	// RVA: 0xA5BB9C
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5BC50
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5BD04
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA5BDB8
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA5BE6C
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA5BF20
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA5BFD4
	public void add_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA5C088
	public void remove_OnAppEvent(System.Action<GoogleMobileAds.Api.AdManager.AppEvent> value) { }

	// RVA: 0xA5C13C
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA5C1F0
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA5C2A4
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C358
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C40C
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C4C0
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C574
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C628
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5C6DC
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA5C780
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA5C824
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA5C82C
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA5C858
	public void CreateInterstitialAd() { }

	// RVA: 0xA5D744
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA5D7B8
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA5D804
	public IAdManagerInterstitialClient PollAdManagerAd(string adUnitId) { }

	// RVA: 0xA5D888
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA5D944
	public void Show() { }

	// RVA: 0xA5D950
	public string GetAdUnitID() { }

	// RVA: 0xA5D9BC
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA5DA30
	public void DestroyInterstitial() { }

	// RVA: 0xA5DA58
	public void Dispose() { }

	// RVA: 0xA5DAA8
	protected override void Finalize() { }

	// RVA: 0xA5B558
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0xA5B5FC
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA5B6E8
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA5B7C0
	private static void InterstitialAppEventCallback(IntPtr interstitialClient, string name, string info) { }

	// RVA: 0xA5B884
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA5B970
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA5BA14
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA5BAB8
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0xA5BB5C
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA5DB64
	private static AdManagerInterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class AdapterResponseInfoClient
{
	// Fields
	private IntPtr _adapterResponseInfoPtr; // 0x10

	// Methods

	// RVA: 0xA5E320
	internal void .ctor(IntPtr adapterResponseInfoPtr) { }

	// RVA: 0xA5E34C
	public string get_AdapterClassName() { }

	// RVA: 0xA5E3B8
	public string get_AdSourceId() { }

	// RVA: 0xA5E424
	public string get_AdSourceName() { }

	// RVA: 0xA5E490
	public string get_AdSourceInstanceId() { }

	// RVA: 0xA5E4FC
	public string get_AdSourceInstanceName() { }

	// RVA: 0xA5E568
	public Int64 get_LatencyMillis() { }

	// RVA: 0xA5E574
	public System.Collections.Generic.Dictionary<System.String,System.String> get_AdUnitMapping() { }

	// RVA: 0xA5E798
	public IAdErrorClient get_AdError() { }

	// RVA: 0xA5E820
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAppOpenAdLoadedCallback
{
	// Methods

	// RVA: 0xA600D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA61318
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA6132C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA613C0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailToLoadCallback
{
	// Methods

	// RVA: 0xA60178
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA613CC
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA613E0
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA61484
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdPaidEventCallback
{
	// Methods

	// RVA: 0xA6021C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA61490
	public virtual void Invoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA614A4
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA6156C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA602C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA61578
	public virtual void Invoke(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA6158C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA61630
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA60364
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6163C
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA61650
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA616E4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA60408
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA616F0
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA61704
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA61798
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA604AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA617A4
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA617B8
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6184C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAppOpenAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA60550
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA61858
	public virtual void Invoke(IntPtr appOpenAdClient) { }

	// RVA: 0xA6186C
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA61900
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
	private static GADUAppOpenAdLoadedCallback <>f__mg$cache8; // 0x40
	private static GADUAppOpenAdFailToLoadCallback <>f__mg$cache9; // 0x48
	private static GADUAppOpenAdPaidEventCallback <>f__mg$cacheA; // 0x50
	private static GADUAppOpenAdFailedToPresentFullScreenContentCallback <>f__mg$cacheB; // 0x58
	private static GADUAppOpenAdWillPresentFullScreenContentCallback <>f__mg$cacheC; // 0x60
	private static GADUAppOpenAdDidDismissFullScreenContentCallback <>f__mg$cacheD; // 0x68
	private static GADUAppOpenAdDidRecordImpressionCallback <>f__mg$cacheE; // 0x70
	private static GADUAppOpenAdDidRecordClickCallback <>f__mg$cacheF; // 0x78

	// Methods

	// RVA: 0xA5EE04
	public void .ctor() { }

	// RVA: 0xA5EE0C
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5EEC0
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5EF74
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA5F028
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA5F0DC
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA5F190
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA5F244
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA5F2F8
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA5F3AC
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F460
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F514
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F5C8
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F67C
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA5F720
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA5F7C4
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F878
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA5F92C
	private IntPtr get_AppOpenAdPtr() { }

	// RVA: 0xA5F934
	private void set_AppOpenAdPtr(IntPtr value) { }

	// RVA: 0xA5F960
	internal void CreateAppOpenAdWithReference(IntPtr appOpenAdClientRef, IntPtr appOpenAdRef) { }

	// RVA: 0xA606CC
	public void CreateAppOpenAd() { }

	// RVA: 0xA60E50
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA60EC4
	public IAppOpenAdClient PollAd(string adUnitId) { }

	// RVA: 0xA60F48
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA60FF8
	public void Show() { }

	// RVA: 0xA61004
	public string GetAdUnitID() { }

	// RVA: 0xA61070
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA610E4
	public void DestroyAppOpenAd() { }

	// RVA: 0xA6110C
	public void Dispose() { }

	// RVA: 0xA6115C
	protected override void Finalize() { }

	// RVA: 0xA5E88C
	private static void AppOpenAdLoadedCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA5E930
	private static void AppOpenAdFailedToLoadCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA5EA1C
	private static void AppOpenAdPaidEventCallback(IntPtr appOpenAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA5EAF4
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr appOpenAdClient, IntPtr error) { }

	// RVA: 0xA5EBE0
	private static void AdWillPresentFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA5EC84
	private static void AdDidDismissFullScreenContentCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA5ED28
	private static void AdDidRecordImpressionCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA5EDCC
	private static void AdDidRecordClickCallback(IntPtr appOpenAdClient) { }

	// RVA: 0xA61218
	private static AppOpenAdClient IntPtrToAppOpenAdClient(IntPtr appOpenAdClient) { }

}

// Namespace: 
internal sealed class GADUAdAvailableForPreloadIdCallback
{
	// Methods

	// RVA: 0xA61DFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA62D60
	public virtual void Invoke(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA62D74
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr responseInfoClient, AsyncCallback callback, object object) { }

	// RVA: 0xA62E24
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdFailedToPreloadForPreloadIdCallback
{
	// Methods

	// RVA: 0xA61EA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA62E30
	public virtual void Invoke(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA62E44
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr adErrorReference, AsyncCallback callback, object object) { }

	// RVA: 0xA62EF4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdsExhaustedForPreloadIdCallback
{
	// Methods

	// RVA: 0xA61F44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA62F00
	public virtual void Invoke(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA62F14
	public virtual IAsyncResult BeginInvoke(IntPtr appOpenAdPreloaderClient, string preloadId, AsyncCallback callback, object object) { }

	// RVA: 0xA62FAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class AppOpenAdPreloaderClient
{
	// Fields
	private IntPtr _appOpenAdPreloaderPtr; // 0x10
	private readonly IntPtr _appOpenAdPreloaderClientPtr; // 0x18
	private System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> _onAdFailedToPreload; // 0x20
	private System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> _onAdPreloaded; // 0x28
	private System.Action<System.String> _onAdsExhausted; // 0x30
	private static GADUAdAvailableForPreloadIdCallback <>f__mg$cache0; // 0x0
	private static GADUAdFailedToPreloadForPreloadIdCallback <>f__mg$cache1; // 0x8
	private static GADUAdsExhaustedForPreloadIdCallback <>f__mg$cache2; // 0x10

	// Methods

	// RVA: 0xA61AA8
	public void .ctor() { }

	// RVA: 0xA62044
	private IntPtr get_AppOpenAdPreloaderPtr() { }

	// RVA: 0xA61DD0
	private void set_AppOpenAdPreloaderPtr(IntPtr value) { }

	// RVA: 0xA6204C
	public bool Preload(string preloadId, PreloadConfiguration preloadConfiguration, System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> onAdPreloaded, System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> onAdFailedToPreload, System.Action<System.String> onAdsExhausted) { }

	// RVA: 0xA622C8
	public bool IsAdAvailable(string preloadId) { }

	// RVA: 0xA62358
	public IAppOpenAdClient DequeueAd(string preloadId) { }

	// RVA: 0xA62490
	public int GetNumAdsAvailable(string preloadId) { }

	// RVA: 0xA62518
	public PreloadConfiguration GetConfiguration(string preloadId) { }

	// RVA: 0xA626A8
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.PreloadConfiguration> GetConfigurations() { }

	// RVA: 0xA62AF0
	public void Destroy(string preloadId) { }

	// RVA: 0xA62B60
	public void DestroyAll() { }

	// RVA: 0xA62B6C
	protected override void Finalize() { }

	// RVA: 0xA6190C
	private static void AdAvailableForPreloadIdCallback(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA619B4
	private static void AdFailedToPreloadForPreloadIdCallback(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA61A5C
	private static void AdsExhaustedForPreloadIdCallback(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA62C34
	private static AppOpenAdPreloaderClient IntPtrToAppOpenAdPreloaderClient(IntPtr appOpenAdPreloaderClient) { }

}

// Namespace: GoogleMobileAds.iOS
public class ApplicationPreferencesClient
{
	// Methods

	// RVA: 0xA62FB8
	public void .ctor() { }

	// RVA: 0xA62FC0
	public void SetInt(string key, int value) { }

	// RVA: 0xA63024
	public void SetString(string key, string value) { }

	// RVA: 0xA630B8
	public int GetInt(string key) { }

	// RVA: 0xA63124
	public string GetString(string key) { }

}

// Namespace: 
internal sealed class GADUAdViewDidReceiveAdCallback
{
	// Methods

	// RVA: 0xA64840
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA659D8
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA659EC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA65A80
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidFailToReceiveAdWithErrorCallback
{
	// Methods

	// RVA: 0xA648E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65A8C
	public virtual void Invoke(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA65AA0
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA65B44
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA64988
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65B50
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA65B64
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA65BF8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA64A2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65C04
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA65C18
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA65CAC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewPaidEventCallback
{
	// Methods

	// RVA: 0xA64AD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65CB8
	public virtual void Invoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA65CCC
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA65D94
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewImpressionCallback
{
	// Methods

	// RVA: 0xA64B74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65DA0
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA65DB4
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA65E48
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdViewClickCallback
{
	// Methods

	// RVA: 0xA64C18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA65E54
	public virtual void Invoke(IntPtr bannerClient) { }

	// RVA: 0xA65E68
	public virtual IAsyncResult BeginInvoke(IntPtr bannerClient, AsyncCallback callback, object object) { }

	// RVA: 0xA65EFC
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

	// RVA: 0xA635E0
	public void .ctor() { }

	// RVA: 0xA635E8
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6369C
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA63750
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA63804
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA638B8
	public void add_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6396C
	public void remove_OnAdOpening(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA63A20
	public void add_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA63AD4
	public void remove_OnAdClosed(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA63B88
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA63C3C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA63CF0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA63D94
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA63E38
	public void add_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA63EDC
	public void remove_OnAdImpressionRecorded(Action value) { }

	// RVA: 0xA63F80
	private IntPtr get_BannerViewPtr() { }

	// RVA: 0xA63F88
	private void set_BannerViewPtr(IntPtr value) { }

	// RVA: 0xA63FB4
	public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position) { }

	// RVA: 0xA64D78
	public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y) { }

	// RVA: 0xA65624
	public void LoadAd(AdRequest request) { }

	// RVA: 0xA65664
	public void ShowBannerView() { }

	// RVA: 0xA6566C
	public void HideBannerView() { }

	// RVA: 0xA65674
	public void DestroyBannerView() { }

	// RVA: 0xA656A4
	public string GetAdUnitID() { }

	// RVA: 0xA65710
	public float GetHeightInPixels() { }

	// RVA: 0xA65718
	public float GetWidthInPixels() { }

	// RVA: 0xA65720
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA65728
	public void SetPosition(int x, int y) { }

	// RVA: 0xA65730
	public bool IsCollapsible() { }

	// RVA: 0xA65750
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA657C4
	public void Dispose() { }

	// RVA: 0xA65818
	protected override void Finalize() { }

	// RVA: 0xA631C0
	private static void AdViewDidReceiveAdCallback(IntPtr bannerClient) { }

	// RVA: 0xA63264
	private static void AdViewDidFailToReceiveAdWithErrorCallback(IntPtr bannerClient, IntPtr error) { }

	// RVA: 0xA63350
	private static void AdViewWillPresentScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA633F4
	private static void AdViewDidDismissScreenCallback(IntPtr bannerClient) { }

	// RVA: 0xA63498
	private static void AdViewPaidEventCallback(IntPtr bannerClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA63570
	private static void AdViewImpressionRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA635A8
	private static void AdViewClickRecordedCallback(IntPtr adClientRef) { }

	// RVA: 0xA658D8
	private static BannerClient IntPtrToBannerClient(IntPtr bannerClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA65F08
	public void .ctor() { }

	// RVA: 0xA65F10
	internal static extern void GADUInitializeWithCallback(IntPtr mobileAdsClient, GADUInitializationCompleteCallback callback) { }

	// RVA: 0xA65F3C
	internal static extern void GADUPreloadWithCallback(IntPtr mobileAdsClient, IntPtr[] configurations, int configurationsCount, GADUAdAvailableCallback adAvailable, GADUAdsExhaustedCallback adsExhausted) { }

	// RVA: 0xA65FA4
	internal static extern void GADUDisableMediationInitialization() { }

	// RVA: 0xA65FA8
	internal static extern IntPtr GADUGetInitDescription(IntPtr status, string className) { }

	// RVA: 0xA65FEC
	internal static extern int GADUGetInitLatency(IntPtr status, string className) { }

	// RVA: 0xA66030
	internal static extern int GADUGetInitState(IntPtr status, string className) { }

	// RVA: 0xA66074
	internal static extern IntPtr GADUGetInitAdapterClasses(IntPtr status) { }

	// RVA: 0xA66078
	internal static extern int GADUGetInitNumberOfAdapterClasses(IntPtr status) { }

	// RVA: 0xA6607C
	internal static extern void GADUSetApplicationVolume(float volume) { }

	// RVA: 0xA66080
	internal static extern void GADUSetApplicationMuted(bool muted) { }

	// RVA: 0xA66084
	internal static extern void GADUSetPlugin(string plugin) { }

	// RVA: 0xA660AC
	internal static extern void GADUSetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA660B0
	internal static extern void GADUDisableSDKCrashReporting() { }

	// RVA: 0xA660B4
	internal static extern float GADUDeviceScale() { }

	// RVA: 0xA660B8
	internal static extern int GADUDeviceSafeWidth() { }

	// RVA: 0xA62FF4
	internal static extern void GADUSetIntegerPreference(string key, int value) { }

	// RVA: 0xA63070
	internal static extern void GADUSetStringPreference(string key, string value) { }

	// RVA: 0xA630F0
	internal static extern int GADUGetIntegerPreference(string key) { }

	// RVA: 0xA63174
	internal static extern string GADUGetStringPreference(string key) { }

	// RVA: 0xA660BC
	internal static extern IntPtr GADUCreateRequest() { }

	// RVA: 0xA660C0
	internal static extern IntPtr GAMUCreateRequest() { }

	// RVA: 0xA660C4
	internal static extern IntPtr GADUCreateMutableDictionary() { }

	// RVA: 0xA660C8
	internal static extern void GADUMutableDictionarySetValue(IntPtr mutableDictionaryPtr, string key, string value) { }

	// RVA: 0xA66124
	internal static extern int GADUNSDictionaryCount(IntPtr dictPtr) { }

	// RVA: 0xA66128
	internal static extern string GADUNSDictionaryKeyAtIndex(IntPtr dictPtr, int index) { }

	// RVA: 0xA6615C
	internal static extern IntPtr GADUNSDictionaryValueForKey(IntPtr dictPtr, string key) { }

	// RVA: 0xA661A0
	internal static extern void GADUSetMediationExtras(IntPtr request, IntPtr mutableDictionaryPtr, string adNetworkExtrasClassName) { }

	// RVA: 0xA661E8
	internal static extern void GADUAddKeyword(IntPtr request, string keyword) { }

	// RVA: 0xA66220
	internal static extern void GADUSetExtra(IntPtr request, string key, string value) { }

	// RVA: 0xA6627C
	internal static extern void GAMUSetPublisherProvidedID(IntPtr request, string publisherProvidedID) { }

	// RVA: 0xA662B4
	internal static extern void GAMUAddCategoryExclusion(IntPtr request, string category) { }

	// RVA: 0xA662EC
	internal static extern void GADUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0xA66348
	internal static extern void GAMUSetCustomTargeting(IntPtr request, string key, string value) { }

	// RVA: 0xA663A4
	internal static extern void GADUSetRequestAgent(IntPtr request, string requestAgent) { }

	// RVA: 0xA59288
	internal static extern void GADURelease(IntPtr obj) { }

	// RVA: 0xA663DC
	internal static extern IntPtr GADUCreatePreloadConfiguration() { }

	// RVA: 0xA621AC
	internal static extern IntPtr GADUCreatePreloadConfigurationV2() { }

	// RVA: 0xA663E0
	internal static extern string GADUGetPreloadConfigurationAdUnitID(IntPtr preloadConfiguration) { }

	// RVA: 0xA66414
	internal static extern void GADUSetPreloadConfigurationAdUnitID(IntPtr preloadConfiguration, string adUnitId) { }

	// RVA: 0xA6644C
	internal static extern int GADUGetPreloadConfigurationAdFormat(IntPtr preloadConfiguration) { }

	// RVA: 0xA66450
	internal static extern void GADUSetPreloadConfigurationAdFormat(IntPtr preloadConfiguration, int adFormat) { }

	// RVA: 0xA66454
	internal static extern void GADUSetPreloadConfigurationAdRequest(IntPtr preloadConfiguration, IntPtr adRequest) { }

	// RVA: 0xA66458
	internal static extern UInt32 GADUGetPreloadConfigurationBufferSize(IntPtr preloadConfiguration) { }

	// RVA: 0xA6645C
	internal static extern void GADUSetPreloadConfigurationBufferSize(IntPtr preloadConfiguration, UInt32 bufferSize) { }

	// RVA: 0xA66460
	internal static extern string GADUGetPreloadConfigurationV2AdUnitID(IntPtr preloadConfiguration) { }

	// RVA: 0xA66494
	internal static extern void GADUSetPreloadConfigurationV2AdUnitID(IntPtr preloadConfiguration, string adUnitId) { }

	// RVA: 0xA664CC
	internal static extern void GADUSetPreloadConfigurationV2AdRequest(IntPtr preloadConfiguration, IntPtr adRequest) { }

	// RVA: 0xA664D0
	internal static extern UInt32 GADUGetPreloadConfigurationV2BufferSize(IntPtr preloadConfiguration) { }

	// RVA: 0xA664D4
	internal static extern void GADUSetPreloadConfigurationV2BufferSize(IntPtr preloadConfiguration, UInt32 bufferSize) { }

	// RVA: 0xA664D8
	internal static extern string GADUMobileAdsVersion() { }

	// RVA: 0xA6650C
	internal static extern IntPtr GADUCreateRequestConfiguration() { }

	// RVA: 0xA66510
	internal static extern void GADUSetRequestConfiguration(IntPtr requestConfiguration) { }

	// RVA: 0xA66514
	internal static extern void GADUSetRequestConfigurationTestDeviceIdentifiers(IntPtr requestConfiguration, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA665F0
	internal static extern void GADUSetRequestConfigurationMaxAdContentRating(IntPtr requestConfiguration, string maxAdContentRating) { }

	// RVA: 0xA66628
	internal static extern void GADUSetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration, int tagForUnderAgeOfConsent) { }

	// RVA: 0xA6662C
	internal static extern void GADUSetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration, int tagForChildDirectedTreatment) { }

	// RVA: 0xA66630
	internal static extern void GADUSetRequestConfigurationPublisherFirstPartyIDEnabled(bool enabled) { }

	// RVA: 0xA66634
	internal static extern void GADUSetRequestConfigurationPublisherPrivacyPersonalizationState(int state) { }

	// RVA: 0xA66638
	internal static extern IntPtr GADUGetTestDeviceIdentifiers(IntPtr request) { }

	// RVA: 0xA6663C
	internal static extern int GADUGetTestDeviceIdentifiersCount(IntPtr request) { }

	// RVA: 0xA66640
	internal static extern string GADUGetMaxAdContentRating(IntPtr requestConfiguration) { }

	// RVA: 0xA66674
	internal static extern int GADUGetRequestConfigurationTagForUnderAgeOfConsent(IntPtr requestConfiguration) { }

	// RVA: 0xA66678
	internal static extern int GADUGetRequestConfigurationTagForChildDirectedTreatment(IntPtr requestConfiguration) { }

	// RVA: 0xA6667C
	internal static extern int GADUGetRequestConfigurationPublisherPrivacyPersonalizationState() { }

	// RVA: 0xA66680
	internal static extern IntPtr GADUCreateUIColor(float alpha, float red, float green, float blue) { }

	// RVA: 0xA66684
	internal static extern IntPtr GADUCreateVideoOptions(bool startMuted, bool clickToExpandRequested, bool customControlsRequested) { }

	// RVA: 0xA60E4C
	internal static extern IntPtr GADUCreateAppOpenAd(IntPtr appOpenAdClient) { }

	// RVA: 0xA60FB0
	internal static extern void GADULoadAppOpenAdWithAdUnitID(IntPtr appOpenAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA60E8C
	internal static extern bool GADUAppOpenIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0xA60F10
	internal static extern void GADUAppOpenPreloadedAdWithAdUnitID(IntPtr appOpenAd, string adUnitId) { }

	// RVA: 0xA61000
	internal static extern void GADUShowAppOpenAd(IntPtr appOpenAd) { }

	// RVA: 0xA605F4
	internal static extern void GADUSetAppOpenAdCallbacks(IntPtr appOpenAd, GADUAppOpenAdLoadedCallback adLoadedCallback, GADUAppOpenAdFailToLoadCallback adFailedToLoadCallback, GADUAppOpenAdPaidEventCallback paidEventCallback, GADUAppOpenAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUAppOpenAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUAppOpenAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUAppOpenAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUAppOpenAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA6103C
	internal static extern string GADUGetAppOpenAdUnitID(IntPtr appOpenAd) { }

	// RVA: 0xA61DCC
	internal static extern IntPtr GADUCreateAppOpenAdPreloader(IntPtr appOpenAdPreloaderClient) { }

	// RVA: 0xA62270
	internal static extern bool GADUAppOpenAdPreloaderPreload(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr preloadConfiguration) { }

	// RVA: 0xA62310
	internal static extern bool GADUAppOpenAdPreloaderIsAdAvailable(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA6243C
	internal static extern IntPtr GADUAppOpenAdPreloaderGetPreloadedAd(IntPtr appOpenAdPreloaderClient, string preloadId, IntPtr appOpenAdClientPtr) { }

	// RVA: 0xA624D4
	internal static extern int GADUAppOpenAdPreloaderGetNumAdsAvailable(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA62624
	internal static extern IntPtr GADUAppOpenAdPreloaderGetConfiguration(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA62AEC
	internal static extern IntPtr GADUAppOpenAdPreloaderGetConfigurations(IntPtr appOpenAdPreloaderClient) { }

	// RVA: 0xA62B28
	internal static extern void GADUAppOpenAdPreloaderDestroy(IntPtr appOpenAdPreloaderClient, string preloadId) { }

	// RVA: 0xA62B68
	internal static extern void GADUAppOpenAdPreloaderDestroyAll(IntPtr appOpenAdPreloaderClient) { }

	// RVA: 0xA61FE8
	internal static extern void GADUSetAppOpenAdPreloaderCallbacks(IntPtr appOpenAdPreloader, GADUAdAvailableForPreloadIdCallback adPreloadedCallback, GADUAdFailedToPreloadForPreloadIdCallback adFailedToPreloadCallback, GADUAdsExhaustedForPreloadIdCallback adsExhaustedCallback) { }

	// RVA: 0xA66688
	internal static extern IntPtr GADUCreateRewardedAdPreloader(IntPtr rewardedAdPreloaderClient) { }

	// RVA: 0xA6668C
	internal static extern bool GADURewardedAdPreloaderPreload(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr preloadConfiguration) { }

	// RVA: 0xA666E4
	internal static extern bool GADURewardedAdPreloaderIsAdAvailable(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA6672C
	internal static extern IntPtr GADURewardedAdPreloaderGetPreloadedAd(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr appOpenAdClientPtr) { }

	// RVA: 0xA66780
	internal static extern int GADURewardedAdPreloaderGetNumAdsAvailable(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA667C4
	internal static extern IntPtr GADURewardedAdPreloaderGetConfiguration(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA66808
	internal static extern IntPtr GADURewardedAdPreloaderGetConfigurations(IntPtr rewardedAdPreloaderClient) { }

	// RVA: 0xA6680C
	internal static extern bool GADURewardedAdPreloaderDestroy(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA66854
	internal static extern void GADURewardedAdPreloaderDestroyAll(IntPtr rewardedAdPreloaderClient) { }

	// RVA: 0xA66858
	internal static extern void GADUSetRewardedAdPreloaderCallbacks(IntPtr appOpenAdPreloader, GADUAdAvailableForPreloadIdCallback adPreloadedCallback, GADUAdFailedToPreloadForPreloadIdCallback adFailedToPreloadCallback, GADUAdsExhaustedForPreloadIdCallback adsExhaustedCallback) { }

	// RVA: 0xA668B4
	internal static extern IntPtr GADUCreateInterstitialAdPreloader(IntPtr interstitialAdPreloaderClient) { }

	// RVA: 0xA668B8
	internal static extern bool GADUInterstitialAdPreloaderPreload(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr preloadConfiguration) { }

	// RVA: 0xA66910
	internal static extern bool GADUInterstitialAdPreloaderIsAdAvailable(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA66958
	internal static extern IntPtr GADUInterstitialAdPreloaderGetPreloadedAd(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr appOpenAdClientPtr) { }

	// RVA: 0xA669AC
	internal static extern int GADUInterstitialAdPreloaderGetNumAdsAvailable(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA669F0
	internal static extern IntPtr GADUInterstitialAdPreloaderGetConfiguration(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA66A34
	internal static extern IntPtr GADUInterstitialAdPreloaderGetConfigurations(IntPtr interstitialAdPreloaderClient) { }

	// RVA: 0xA66A38
	internal static extern bool GADUInterstitialAdPreloaderDestroy(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA66A80
	internal static extern void GADUInterstitialAdPreloaderDestroyAll(IntPtr interstitialAdPreloaderClient) { }

	// RVA: 0xA66A84
	internal static extern void GADUSetInterstitialAdPreloaderCallbacks(IntPtr interstitialAdPreloader, GADUAdAvailableForPreloadIdCallback adPreloadedCallback, GADUAdFailedToPreloadForPreloadIdCallback adFailedToPreloadCallback, GADUAdsExhaustedForPreloadIdCallback adsExhaustedCallback) { }

	// RVA: 0xA647D4
	internal static extern IntPtr GADUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int positionAtTop) { }

	// RVA: 0xA655B0
	internal static extern IntPtr GADUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0xA64714
	internal static extern IntPtr GADUCreateSmartBannerView(IntPtr bannerClient, string adUnitId, int positionAtTop) { }

	// RVA: 0xA654E0
	internal static extern IntPtr GADUCreateSmartBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int x, int y) { }

	// RVA: 0xA64768
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int positionAtTop) { }

	// RVA: 0xA6553C
	internal static extern IntPtr GADUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0xA64CBC
	internal static extern void GADUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback) { }

	// RVA: 0xA5AB40
	internal static extern void GADUHideBannerView(IntPtr bannerView) { }

	// RVA: 0xA5AB34
	internal static extern void GADUShowBannerView(IntPtr bannerView) { }

	// RVA: 0xA5AB74
	internal static extern void GADURemoveBannerView(IntPtr bannerView) { }

	// RVA: 0xA5AB28
	internal static extern void GADURequestBannerAd(IntPtr bannerView, IntPtr request) { }

	// RVA: 0xA656DC
	internal static extern string GADUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0xA5ABEC
	internal static extern float GADUGetBannerViewHeightInPixels(IntPtr bannerView) { }

	// RVA: 0xA5ABF8
	internal static extern float GADUGetBannerViewWidthInPixels(IntPtr bannerView) { }

	// RVA: 0xA5AC04
	internal static extern void GADUSetBannerViewAdPosition(IntPtr bannerView, int position) { }

	// RVA: 0xA5AC10
	internal static extern void GADUSetBannerViewCustomPosition(IntPtr bannerView, int x, int y) { }

	// RVA: 0xA5AC34
	internal static extern bool GADUIsBannerViewCollapsible(IntPtr bannerView) { }

	// RVA: 0xA66AE0
	internal static extern bool GADUIsBannerViewHidden(IntPtr bannerView) { }

	// RVA: 0xA66AFC
	internal static extern IntPtr GADUGetResponseInfo(IntPtr adFormat) { }

	// RVA: 0xA66B00
	internal static extern string GADUResponseInfoMediationAdapterClassName(IntPtr responseInfo) { }

	// RVA: 0xA66B34
	internal static extern string GADUResponseInfoResponseId(IntPtr responseInfo) { }

	// RVA: 0xA66B68
	internal static extern string GADUGetResponseInfoDescription(IntPtr responseInfo) { }

	// RVA: 0xA66B9C
	internal static extern int GADUResponseInfoAdNetworkCount(IntPtr responseInfo) { }

	// RVA: 0xA66BA0
	internal static extern IntPtr GADUResponseInfoAdNetworkAtIndex(IntPtr responseInfo, int index) { }

	// RVA: 0xA66BA4
	internal static extern IntPtr GADUResponseInfoLoadedAdNetworkResponseInfo(IntPtr responseInfo) { }

	// RVA: 0xA66BA8
	internal static extern int GADUResponseInfoExtrasCount(IntPtr responseInfo) { }

	// RVA: 0xA66BAC
	internal static extern string GADUResponseInfoExtrasKey(IntPtr responseInfo, int index) { }

	// RVA: 0xA66BE0
	internal static extern string GADUResponseInfoExtrasValue(IntPtr responseInfo, string key) { }

	// RVA: 0xA57E78
	internal static extern int GADUGetAdErrorCode(IntPtr error) { }

	// RVA: 0xA57EB4
	internal static extern string GADUGetAdErrorDomain(IntPtr error) { }

	// RVA: 0xA57F20
	internal static extern string GADUGetAdErrorMessage(IntPtr error) { }

	// RVA: 0xA57FC8
	internal static extern IntPtr GADUGetAdErrorUnderLyingError(IntPtr error) { }

	// RVA: 0xA66C3C
	internal static extern IntPtr GADUGetAdErrorResponseInfo(IntPtr error) { }

	// RVA: 0xA58004
	internal static extern string GADUGetAdErrorDescription(IntPtr error) { }

	// RVA: 0xA59B48
	internal static extern IntPtr GAMUCreateBannerView(IntPtr bannerClient, string adUnitId, int width, int height, int adPosition) { }

	// RVA: 0xA5AA74
	internal static extern IntPtr GAMUCreateBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int height, int x, int y) { }

	// RVA: 0xA59ADC
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerView(IntPtr bannerClient, string adUnitId, int width, int orientation, int adPosition) { }

	// RVA: 0xA5AA00
	internal static extern IntPtr GAMUCreateAnchoredAdaptiveBannerViewWithCustomPosition(IntPtr bannerClient, string adUnitId, int width, int orientation, int x, int y) { }

	// RVA: 0xA5ABB0
	internal static extern string GAMUGetBannerViewAdUnitID(IntPtr bannerView) { }

	// RVA: 0xA5A0D4
	internal static extern void GAMUSetBannerCallbacks(IntPtr bannerView, GADUAdViewDidReceiveAdCallback adReceivedCallback, GADUAdViewDidFailToReceiveAdWithErrorCallback adFailedCallback, GADUAdViewWillPresentScreenCallback willPresentCallback, GADUAdViewDidDismissScreenCallback didDismissCallback, GADUAdViewPaidEventCallback paidEventCallback, GADUAdViewImpressionCallback adImpressionCallback, GADUAdViewClickCallback adClickCallback, GAMUAdViewAppEventCallback appEventCallback) { }

	// RVA: 0xA59244
	internal static extern void GAMUBannerViewSetValidAdSizes(IntPtr bannerView, int[] validAdSizesArray, int validAdSizesLength) { }

	// RVA: 0xA66C40
	internal static extern IntPtr GADUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA66C44
	internal static extern bool GADUInterstitialIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0xA66C7C
	internal static extern void GADUInterstitialPreloadedAdWithAdUnitID(IntPtr interstitialAd, string adUnitId) { }

	// RVA: 0xA66CB4
	internal static extern IntPtr GADULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA66D08
	internal static extern string GADUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA66D3C
	internal static extern void GADUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adReceivedCallback, GADUInterstitialAdFailedToLoadCallback adFailedCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback) { }

	// RVA: 0xA5D94C
	internal static extern void GADUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA5D098
	internal static extern IntPtr GAMUCreateInterstitial(IntPtr interstitialClient) { }

	// RVA: 0xA5D780
	internal static extern bool GAMUInterstitialIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0xA5D850
	internal static extern void GAMUInterstitialPreloadedAdWithAdUnitID(IntPtr interstitialAd, string adUnitId) { }

	// RVA: 0xA5D8F0
	internal static extern IntPtr GAMULoadInterstitialAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA5D988
	internal static extern string GAMUGetInterstitialAdUnitID(IntPtr interstitialAd) { }

	// RVA: 0xA5D660
	internal static extern void GAMUSetInterstitialCallbacks(IntPtr interstitial, GADUInterstitialAdLoadedCallback adLoadedCallback, GADUInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADUInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADUInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADUInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADUInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUInterstitialAdDidRecordClickCallback adDidRecordClickCallback, GADUInterstitialPaidEventCallback paidEventCallback, GAMUInterstitialAppEventCallback appEventCallback) { }

	// RVA: 0xA66E14
	internal static extern void GAMUShowInterstitial(IntPtr interstitial) { }

	// RVA: 0xA66E18
	internal static extern IntPtr GADUCreateRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA66E1C
	internal static extern bool GADURewardedIsPreloadedAdAvailable(string adUnitId) { }

	// RVA: 0xA66E54
	internal static extern void GADURewardedPreloadedAdWithAdUnitID(IntPtr rewardedAd, string adUnitId) { }

	// RVA: 0xA66E8C
	internal static extern IntPtr GADULoadRewardedAd(IntPtr interstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA66EE0
	internal static extern void GADUShowRewardedAd(IntPtr rewardedAd) { }

	// RVA: 0xA66EE4
	internal static extern string GADUGetRewardedAdUnitID(IntPtr rewardedAd) { }

	// RVA: 0xA66F18
	internal static extern void GADUSetRewardedAdCallbacks(IntPtr rewardedAd, GADURewardedAdLoadedCallback adLoadedCallback, GADURewardedAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedAdDidRecordClickCallback adDidRecordClickCallback, GADURewardedAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedAdPaidEventCallback paidEventCallback) { }

	// RVA: 0xA66FFC
	internal static extern IntPtr GADUCreateServerSideVerificationOptions() { }

	// RVA: 0xA67000
	internal static extern void GADUServerSideVerificationOptionsSetUserId(IntPtr options, string userId) { }

	// RVA: 0xA67038
	internal static extern void GADUServerSideVerificationOptionsSetCustomRewardString(IntPtr options, string customRewardString) { }

	// RVA: 0xA67070
	internal static extern void GADURewardedAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA67074
	internal static extern string GADURewardedAdGetRewardType(IntPtr rewardedAd) { }

	// RVA: 0xA670A8
	internal static extern Double GADURewardedAdGetRewardAmount(IntPtr rewardedAd) { }

	// RVA: 0xA670AC
	internal static extern IntPtr GADUCreateRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA670B0
	internal static extern IntPtr GADULoadRewardedInterstitialAd(IntPtr rewardedInterstitialAd, string adUnitID, IntPtr request) { }

	// RVA: 0xA67104
	internal static extern void GADUShowRewardedInterstitialAd(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA67108
	internal static extern string GADUGetRewardedInterstitialAdUnitID(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA6713C
	internal static extern void GADUSetRewardedInterstitialAdCallbacks(IntPtr rewardedInterstitialAd, GADURewardedInterstitialAdLoadedCallback adLoadedCallback, GADURewardedInterstitialAdFailedToLoadCallback adFailedToLoadCallback, GADURewardedInterstitialAdUserEarnedRewardCallback adDidEarnRewardCallback, GADURewardedInterstitialAdPaidEventCallback paidEventCallback, GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback adFailToPresentFullScreenContentCallback, GADURewardedInterstitialAdWillPresentFullScreenContentCallback adWillPresentFullScreenContentCallback, GADURewardedInterstitialAdDidDismissFullScreenContentCallback adDidDismissFullScreenContentCallback, GADURewardedInterstitialAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADURewardedInterstitialAdDidRecordClickCallback adDidRecordClickCallback) { }

	// RVA: 0xA67220
	internal static extern void GADURewardedInterstitialAdSetServerSideVerificationOptions(IntPtr rewardedAd, IntPtr options) { }

	// RVA: 0xA67224
	internal static extern string GADURewardedInterstitialAdGetRewardType(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA67258
	internal static extern Double GADURewardedInterstitialAdGetRewardAmount(IntPtr rewardedInterstitialAd) { }

	// RVA: 0xA6725C
	internal static extern IntPtr GADUCreateNativeAdOptions(int adChoicesPlacement, int mediaAspectRatio, IntPtr videoOptions) { }

	// RVA: 0xA67260
	internal static extern IntPtr GADUCreateNativeTemplateTextStyle() { }

	// RVA: 0xA67264
	internal static extern IntPtr GADUSetNativeTemplateTextColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA67268
	internal static extern IntPtr GADUSetNativeTemplateTextBackgroundColor(IntPtr templateTextStyle, IntPtr color) { }

	// RVA: 0xA6726C
	internal static extern IntPtr GADUSetNativeTemplateTextFontStyle(IntPtr templateTextStyle, int fontType) { }

	// RVA: 0xA67270
	internal static extern IntPtr GADUSetNativeTemplateTextFontSize(IntPtr templateTextStyle, int size) { }

	// RVA: 0xA67274
	internal static extern IntPtr GADUCreateNativeTemplateStyle(string templateName) { }

	// RVA: 0xA672A8
	internal static extern IntPtr GADUSetNativeTemplateStyleBackgroundColor(IntPtr templateStyle, IntPtr color) { }

	// RVA: 0xA672AC
	internal static extern IntPtr GADUSetNativeTemplateStyleText(IntPtr templateStyle, string textType, IntPtr color) { }

	// RVA: 0xA67300
	internal static extern IntPtr GADUCreateNativeTemplateAd(IntPtr nativeAdClient) { }

	// RVA: 0xA67304
	internal static extern void GADUSetNativeTemplateAdCallbacks(IntPtr nativeTemplateAd, GADUNativeAdLoadedCallback adLoadedCallback, GADUNativeAdFailedToLoadCallback adFailedCallback, GADUNativeAdDidRecordImpressionCallback adDidRecordImpressionCallback, GADUNativeAdDidRecordClickCallback adDidRecordClickCallback, GADUNativePaidEventCallback paidEventCallback, GADUNativeAdWillPresentScreenCallback willPresentCallback, GADUNativeAdDidDismissScreenCallback didDismissCallback) { }

	// RVA: 0xA673C0
	internal static extern void GADULoadNativeTemplateAd(IntPtr nativeTemplateAd, string adUnitID, IntPtr nativeAdOptions, IntPtr request) { }

	// RVA: 0xA67410
	internal static extern void GADUShowNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle, int height, int width) { }

	// RVA: 0xA67414
	internal static extern void GADUShowDefaultNativeTemplateAd(IntPtr nativeTemplateAd, IntPtr templateStyle) { }

	// RVA: 0xA67418
	internal static extern void GADUSetNativeTemplateAdPosition(IntPtr nativeTemplateAd, int position) { }

	// RVA: 0xA6741C
	internal static extern void GADUSetNativeTemplateAdCustomPosition(IntPtr nativeTemplateAd, int x, int y) { }

	// RVA: 0xA67420
	internal static extern void GADUHideNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA67424
	internal static extern void GADUDisplayNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA67428
	internal static extern void GADUDestroyNativeTemplateAd(IntPtr nativeTemplateAd) { }

	// RVA: 0xA6742C
	internal static extern float GADUGetNativeTemplateAdHeightInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA67430
	internal static extern float GADUGetNativeTemplateAdWidthInPixels(IntPtr nativeTemplateAd) { }

	// RVA: 0xA67434
	internal static extern void GADUPresentAdInspector(IntPtr mobileAdsClient, GADUAdInspectorClosedCallback callback) { }

	// RVA: 0xA5E384
	internal static extern string GADUAdapterResponseInfoAdNetworkClassName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E3F0
	internal static extern string GADUAdapterResponseInfoAdSourceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E45C
	internal static extern string GADUAdapterResponseInfoAdSourceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E4C8
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceID(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E534
	internal static extern string GADUAdapterResponseInfoAdSourceInstanceName(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E570
	internal static extern Int64 GADUAdapterResponseInfoLatency(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E704
	internal static extern int GADUAdapterResponseInfoAdUnitMappingCount(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E708
	internal static extern string GADUAdapterResponseInfoAdUnitMappingKey(IntPtr adapterResponseInfoRef, int index) { }

	// RVA: 0xA5E73C
	internal static extern string GADUAdapterResponseInfoAdUnitMappingValue(IntPtr adapterResponseInfoRef, string key) { }

	// RVA: 0xA5E81C
	internal static extern IntPtr GADUAdapterResponseInfoAdError(IntPtr adapterResponseInfoRef) { }

	// RVA: 0xA5E858
	internal static extern string GADUAdapterResponseInfoDescription(IntPtr error) { }

}

// Namespace: GoogleMobileAds
public class GoogleMobileAdsClientFactory
{
	// Methods

	// RVA: 0xA67460
	public void .ctor() { }

	// RVA: 0xA67468
	public IAppStateEventClient BuildAppStateEventClient() { }

	// RVA: 0xA67588
	public IAppOpenAdClient BuildAppOpenAdClient() { }

	// RVA: 0xA676D0
	public IAppOpenAdPreloaderClient BuildAppOpenAdPreloaderClient() { }

	// RVA: 0xA67814
	public IBannerClient BuildBannerClient() { }

	// RVA: 0xA6795C
	public IAdManagerBannerClient BuildAdManagerBannerClient() { }

	// RVA: 0xA67AA4
	public IInterstitialClient BuildInterstitialClient() { }

	// RVA: 0xA67BF4
	public IInterstitialAdPreloaderClient BuildInterstitialAdPreloaderClient() { }

	// RVA: 0xA6805C
	public IAdManagerInterstitialClient BuildAdManagerInterstitialClient() { }

	// RVA: 0xA681A4
	public IRewardedAdClient BuildRewardedAdClient() { }

	// RVA: 0xA682F4
	public IRewardedAdPreloaderClient BuildRewardedAdPreloaderClient() { }

	// RVA: 0xA6864C
	public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient() { }

	// RVA: 0xA68794
	public INativeOverlayAdClient BuildNativeOverlayAdClient() { }

	// RVA: 0xA688E4
	public IApplicationPreferencesClient ApplicationPreferencesInstance() { }

	// RVA: 0xA68A2C
	public IMobileAdsClient MobileAdsInstance() { }

}

// Namespace: GoogleMobileAds.iOS
public class InitializationStatusClient
{
	// Fields
	private IntPtr status; // 0x10

	// Methods

	// RVA: 0xA68BD8
	public void .ctor(IntPtr status) { }

	// RVA: 0xA68C04
	public AdapterStatus getAdapterStatusForClassName(string className) { }

	// RVA: 0xA68D08
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.AdapterStatus> getAdapterStatusMap() { }

	// RVA: 0xA69018
	public System.Collections.Generic.List<System.String> GetAdapterClassNames() { }

	// RVA: 0xA69054
	public void Dispose() { }

	// RVA: 0xA6905C
	protected override void Finalize() { }

}

// Namespace: 
internal sealed class GADUAdAvailableForPreloadIdCallback
{
	// Methods

	// RVA: 0xA692B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6A648
	public virtual void Invoke(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA6A65C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr responseInfoClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6A70C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdFailedToPreloadForPreloadIdCallback
{
	// Methods

	// RVA: 0xA6935C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6A718
	public virtual void Invoke(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA6A72C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr adErrorReference, AsyncCallback callback, object object) { }

	// RVA: 0xA6A7DC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdsExhaustedForPreloadIdCallback
{
	// Methods

	// RVA: 0xA69400
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6A7E8
	public virtual void Invoke(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA6A7FC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialAdPreloaderClient, string preloadId, AsyncCallback callback, object object) { }

	// RVA: 0xA6A894
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class InterstitialAdPreloaderClient
{
	// Fields
	private IntPtr _interstitialAdPreloaderPtr; // 0x10
	private readonly IntPtr _interstitialAdPreloaderClientPtr; // 0x18
	private System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> _onAdFailedToPreload; // 0x20
	private System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> _onAdPreloaded; // 0x28
	private System.Action<System.String> _onAdsExhausted; // 0x30
	private static GADUAdAvailableForPreloadIdCallback <>f__mg$cache0; // 0x0
	private static GADUAdFailedToPreloadForPreloadIdCallback <>f__mg$cache1; // 0x8
	private static GADUAdsExhaustedForPreloadIdCallback <>f__mg$cache2; // 0x10

	// Methods

	// RVA: 0xA67D38
	public void .ctor() { }

	// RVA: 0xA694A4
	private IntPtr get_InterstitialAdPreloaderPtr() { }

	// RVA: 0xA6928C
	private void set_InterstitialAdPreloaderPtr(IntPtr value) { }

	// RVA: 0xA694AC
	public bool Preload(string preloadId, PreloadConfiguration preloadConfiguration, System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> onAdPreloaded, System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> onAdFailedToPreload, System.Action<System.String> onAdsExhausted) { }

	// RVA: 0xA6960C
	public bool IsAdAvailable(string preloadId) { }

	// RVA: 0xA69654
	public IInterstitialClient DequeueAd(string preloadId) { }

	// RVA: 0xA69EAC
	public int GetNumAdsAvailable(string preloadId) { }

	// RVA: 0xA69EF0
	public PreloadConfiguration GetConfiguration(string preloadId) { }

	// RVA: 0xA69FFC
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.PreloadConfiguration> GetConfigurations() { }

	// RVA: 0xA6A440
	public void Destroy(string preloadId) { }

	// RVA: 0xA6A478
	public void DestroyAll() { }

	// RVA: 0xA6A480
	protected override void Finalize() { }

	// RVA: 0xA690F0
	private static void AdAvailableForPreloadIdCallback(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA69198
	private static void AdFailedToPreloadForPreloadIdCallback(IntPtr interstitialAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA69240
	private static void AdsExhaustedForPreloadIdCallback(IntPtr interstitialAdPreloaderClient, string preloadId) { }

	// RVA: 0xA6A548
	private static InterstitialAdPreloaderClient IntPtrToInterstitialAdPreloaderClient(IntPtr interstitialAdPreloaderClient) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA6B96C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6C9E4
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA6C9F8
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6CA8C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA6BA10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CA98
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA6CAAC
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA6CB50
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialPaidEventCallback
{
	// Methods

	// RVA: 0xA6BDE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CB5C
	public virtual void Invoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA6CB70
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA6CC38
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA6BB58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CC44
	public virtual void Invoke(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA6CC58
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA6CCFC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA6BAB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CD08
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA6CD1C
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6CDB0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA6BBFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CDBC
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA6CDD0
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6CE64
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA6BCA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CE70
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA6CE84
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6CF18
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA6BD44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6CF24
	public virtual void Invoke(IntPtr interstitialClient) { }

	// RVA: 0xA6CF38
	public virtual IAsyncResult BeginInvoke(IntPtr interstitialClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6CFCC
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
	private static GADUInterstitialAdLoadedCallback <>f__mg$cache8; // 0x40
	private static GADUInterstitialAdFailedToLoadCallback <>f__mg$cache9; // 0x48
	private static GADUInterstitialAdWillPresentFullScreenContentCallback <>f__mg$cacheA; // 0x50
	private static GADUInterstitialAdFailedToPresentFullScreenContentCallback <>f__mg$cacheB; // 0x58
	private static GADUInterstitialAdDidDismissFullScreenContentCallback <>f__mg$cacheC; // 0x60
	private static GADUInterstitialAdDidRecordImpressionCallback <>f__mg$cacheD; // 0x68
	private static GADUInterstitialAdDidRecordClickCallback <>f__mg$cacheE; // 0x70
	private static GADUInterstitialPaidEventCallback <>f__mg$cacheF; // 0x78

	// Methods

	// RVA: 0xA67BEC
	public void .ctor() { }

	// RVA: 0xA6AE18
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6AECC
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6AF80
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA6B034
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA6B0E8
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA6B19C
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA6B250
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA6B304
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA6B3B8
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B46C
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B520
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B5D4
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B688
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B73C
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6B7F0
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA6B894
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA6B938
	private IntPtr get_InterstitialPtr() { }

	// RVA: 0xA6B940
	private void set_InterstitialPtr(IntPtr value) { }

	// RVA: 0xA69738
	internal void CreateInterstitialAdWithReference(IntPtr interstitialAdClientRef, IntPtr interstitialAdRef) { }

	// RVA: 0xA6BE8C
	public void CreateInterstitialAd() { }

	// RVA: 0xA6C60C
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA6C648
	public IInterstitialClient PollAd(string adUnitId) { }

	// RVA: 0xA6C694
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA6C6FC
	public void Show() { }

	// RVA: 0xA6C704
	public string GetAdUnitID() { }

	// RVA: 0xA6C73C
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA6C7B0
	public void DestroyInterstitial() { }

	// RVA: 0xA6C7D8
	public void Dispose() { }

	// RVA: 0xA6C828
	protected override void Finalize() { }

	// RVA: 0xA6A8A0
	private static void InterstitialLoadedCallback(IntPtr interstitialClient) { }

	// RVA: 0xA6A944
	private static void InterstitialFailedToLoadCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA6AA30
	private static void InterstitialPaidEventCallback(IntPtr interstitialClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA6AB08
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr interstitialClient, IntPtr error) { }

	// RVA: 0xA6ABF4
	private static void AdWillPresentFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA6AC98
	private static void AdDidDismissFullScreenContentCallback(IntPtr interstitialClient) { }

	// RVA: 0xA6AD3C
	private static void AdDidRecordImpressionCallback(IntPtr interstitialClient) { }

	// RVA: 0xA6ADE0
	private static void AdDidRecordClickCallback(IntPtr interstitialClient) { }

	// RVA: 0xA6C8E4
	private static InterstitialClient IntPtrToInterstitialClient(IntPtr interstitialClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class LoadAdErrorClient
{
	// Fields
	private IntPtr error; // 0x10

	// Methods

	// RVA: 0xA5AF34
	public void .ctor(IntPtr error) { }

	// RVA: 0xA6CFD8
	public int GetCode() { }

	// RVA: 0xA6CFE0
	public string GetDomain() { }

	// RVA: 0xA6D018
	public string GetMessage() { }

	// RVA: 0xA6D050
	public IAdErrorClient GetCause() { }

	// RVA: 0xA6D0C4
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA6D138
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADUAdInspectorClosedCallback
{
	// Methods

	// RVA: 0xA6EC44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6EF88
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA6EF9C
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA6F040
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUInitializationCompleteCallback
{
	// Methods

	// RVA: 0xA6DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6F04C
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr initStatusClient) { }

	// RVA: 0xA6F060
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr initStatusClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6F104
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdAvailableCallback
{
	// Methods

	// RVA: 0xA6E960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6F110
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient) { }

	// RVA: 0xA6F124
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6F1C8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdsExhaustedCallback
{
	// Methods

	// RVA: 0xA6EA04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA6F1D4
	public virtual void Invoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient) { }

	// RVA: 0xA6F1E8
	public virtual IAsyncResult BeginInvoke(IntPtr mobileAdsClient, IntPtr preloadConfigClient, AsyncCallback callback, object object) { }

	// RVA: 0xA6F28C
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0xA6D904
	private void .ctor() { }

	// RVA: 0xA6D938
	public static MobileAdsClient get_Instance() { }

	// RVA: 0xA6D9B4
	public void Initialize(System.Action<GoogleMobileAds.Common.IInitializationStatusClient> initCompleteAction) { }

	// RVA: 0xA6DBF4
	public void DisableMediationInitialization() { }

	// RVA: 0xA6DBF8
	public void SetApplicationVolume(float volume) { }

	// RVA: 0xA6DBFC
	public void SetApplicationMuted(bool muted) { }

	// RVA: 0xA6DC04
	public void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA6E164
	public RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA6E3D0
	public void SetiOSAppPauseOnBackground(bool pause) { }

	// RVA: 0xA6E3D8
	public void DisableSDKCrashReporting() { }

	// RVA: 0xA6E3DC
	public float GetDeviceScale() { }

	// RVA: 0xA6E3E0
	public int GetDeviceSafeWidth() { }

	// RVA: 0xA6E3E4
	public Version GetSDKVersion() { }

	// RVA: 0xA6E460
	public void Preload(System.Collections.Generic.List<GoogleMobileAds.Api.PreloadConfiguration> configurations, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdAvailable, System.Action<GoogleMobileAds.Api.PreloadConfiguration> onAdsExhausted) { }

	// RVA: 0xA6EAA8
	public void OpenAdInspector(System.Action<GoogleMobileAds.Common.AdInspectorErrorClientEventArgs> onAdInspectorClosed) { }

	// RVA: 0xA6D170
	private static void AdAvailableCallback(IntPtr mobileAdsClient, IntPtr config) { }

	// RVA: 0xA6D2DC
	private static void AdsExhaustedCallback(IntPtr mobileAdsClient, IntPtr config) { }

	// RVA: 0xA6D448
	private static void AdInspectorClosedCallback(IntPtr mobileAdsClient, IntPtr errorRef) { }

	// RVA: 0xA6D588
	private static void InitializationCompleteCallback(IntPtr mobileAdsClient, IntPtr initStatus) { }

	// RVA: 0xA6ECE8
	private static MobileAdsClient IntPtrToMobileAdsClient(IntPtr mobileAdsClient) { }

	// RVA: 0xA6EE30
	public void Dispose() { }

	// RVA: 0xA6EE64
	protected override void Finalize() { }

	// RVA: 0xA6EF0C
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
public sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xA6F298
	public void .ctor(Type type) { }

}

// Namespace: 
internal sealed class GADUNativeAdLoadedCallback
{
	// Methods

	// RVA: 0xA70950
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA71470
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA71484
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA71518
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA709F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA71524
	public virtual void Invoke(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA71538
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA715DC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativePaidEventCallback
{
	// Methods

	// RVA: 0xA70BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA715E8
	public virtual void Invoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA715FC
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA716C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA70A98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA716D0
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA716E4
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA71778
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA70B3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA71784
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA71798
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA7182C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdWillPresentScreenCallback
{
	// Methods

	// RVA: 0xA70C84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA71838
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA7184C
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA718E0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUNativeAdDidDismissScreenCallback
{
	// Methods

	// RVA: 0xA70D28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA718EC
	public virtual void Invoke(IntPtr nativeClient) { }

	// RVA: 0xA71900
	public virtual IAsyncResult BeginInvoke(IntPtr nativeClient, AsyncCallback callback, object object) { }

	// RVA: 0xA71994
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

	// RVA: 0xA688DC
	public void .ctor() { }

	// RVA: 0xA6F72C
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6F7E0
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6F894
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA6F948
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA6F9FC
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FAB0
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FB64
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA6FC08
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA6FCAC
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FD60
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FE14
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FEC8
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA6FF7C
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA70030
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA700E4
	private static NativeOverlayAdClient IntPtrToNativeClient(IntPtr nativeClient) { }

	// RVA: 0xA701E4
	private IntPtr get_NativePtr() { }

	// RVA: 0xA701EC
	private void set_NativePtr(IntPtr value) { }

	// RVA: 0xA70218
	public void Load(string adUnitID, AdRequest request, NativeAdOptions nativeOptions) { }

	// RVA: 0xA70E10
	public void Hide() { }

	// RVA: 0xA70E18
	public void Show() { }

	// RVA: 0xA70E20
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, AdPosition adPosition) { }

	// RVA: 0xA71084
	public void Render(NativeTemplateStyle templateViewStyle, AdSize adSize, int x, int y) { }

	// RVA: 0xA710E0
	public void Render(NativeTemplateStyle templateViewStyle, AdPosition adPosition) { }

	// RVA: 0xA7111C
	public void Render(NativeTemplateStyle templateViewStyle, int x, int y) { }

	// RVA: 0xA71168
	public void SetPosition(AdPosition adPosition) { }

	// RVA: 0xA71170
	public void SetPosition(int x, int y) { }

	// RVA: 0xA71178
	public float GetHeightInPixels() { }

	// RVA: 0xA71180
	public float GetWidthInPixels() { }

	// RVA: 0xA71188
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA711FC
	public void DestroyAd() { }

	// RVA: 0xA71224
	public void Dispose() { }

	// RVA: 0xA71270
	protected override void Finalize() { }

	// RVA: 0xA6F2A0
	private static void NativeLoadedCallback(IntPtr nativeClient) { }

	// RVA: 0xA6F344
	private static void NativeFailedToLoadCallback(IntPtr nativeClient, IntPtr error) { }

	// RVA: 0xA6F430
	private static void NativePaidEventCallback(IntPtr nativeClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA6F508
	private static void AdDidRecordImpressionCallback(IntPtr nativeClient) { }

	// RVA: 0xA6F5AC
	private static void AdDidRecordClickCallback(IntPtr nativeClient) { }

	// RVA: 0xA6F5E4
	private static void NativeAdWillPresentScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA6F688
	private static void NativeAdDidDismissScreenCallback(IntPtr nativeClient) { }

	// RVA: 0xA70DCC
	public static IntPtr BuildNativeAdOptions(NativeAdOptions options) { }

	// RVA: 0xA70E74
	public static IntPtr BuildNativeTemplateStyles(NativeTemplateStyle templateStyle) { }

	// RVA: 0xA71328
	public static IntPtr BuildNativeTemplateTextStyle(NativeTemplateTextStyle textStyle) { }

}

// Namespace: GoogleMobileAds.iOS
internal class PreloadConfigurationClient
{
	// Fields
	private AdRequest _adRequest; // 0x10
	internal IntPtr preloadConfigurationPtr; // 0x18

	// Methods

	// RVA: 0xA6E898
	internal void .ctor(IntPtr preloadConfiguration) { }

	// RVA: 0xA6EDE8
	internal string get_AdUnitId() { }

	// RVA: 0xA6E8C4
	internal void set_AdUnitId(string value) { }

	// RVA: 0xA6EE20
	internal AdFormat get_Format() { }

	// RVA: 0xA6E8FC
	internal void set_Format(AdFormat value) { }

	// RVA: 0xA719A0
	internal AdRequest get_Request() { }

	// RVA: 0xA6E90C
	internal void set_Request(AdRequest value) { }

	// RVA: 0xA6EE28
	internal UInt32 get_BufferSize() { }

	// RVA: 0xA6E904
	internal void set_BufferSize(UInt32 value) { }

}

// Namespace: GoogleMobileAds.iOS
internal class PreloadConfigurationV2Client
{
	// Fields
	private AdRequest _adRequest; // 0x10
	private readonly IntPtr _preloadConfigurationV2Ptr; // 0x18

	// Methods

	// RVA: 0xA621B0
	internal void .ctor(IntPtr preloadConfigurationV2) { }

	// RVA: 0xA62668
	internal string get_AdUnitId() { }

	// RVA: 0xA621DC
	internal void set_AdUnitId(string value) { }

	// RVA: 0xA719A8
	internal AdRequest get_Request() { }

	// RVA: 0xA6221C
	internal void set_Request(AdRequest value) { }

	// RVA: 0xA626A0
	internal UInt32 get_BufferSize() { }

	// RVA: 0xA62214
	internal void set_BufferSize(UInt32 value) { }

}

// Namespace: GoogleMobileAds.iOS
public class RequestConfigurationClient
{
	// Fields
	private static IntPtr requestConfigurationPtr; // 0x0

	// Methods

	// RVA: 0xA719B0
	public void .ctor() { }

	// RVA: 0xA6DC84
	public static void SetRequestConfiguration(RequestConfiguration requestConfiguration) { }

	// RVA: 0xA6E1CC
	public static RequestConfiguration GetRequestConfiguration() { }

	// RVA: 0xA719B8
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.iOS
internal class ResponseInfoClient
{
	// Fields
	private IntPtr _iosResponseInfo; // 0x10

	// Methods

	// RVA: 0xA5ACC4
	public void .ctor(ResponseInfoClientType type, IntPtr ptr) { }

	// RVA: 0xA62D34
	public void .ctor(IntPtr iOSClient) { }

	// RVA: 0xA71A08
	public System.Collections.Generic.List<GoogleMobileAds.Common.IAdapterResponseInfoClient> GetAdapterResponses() { }

	// RVA: 0xA71B50
	public IAdapterResponseInfoClient GetLoadedAdapterResponseInfo() { }

	// RVA: 0xA71BD8
	public System.Collections.Generic.Dictionary<System.String,System.String> GetResponseExtras() { }

	// RVA: 0xA71D6C
	public string GetMediationAdapterClassName() { }

	// RVA: 0xA71DC8
	public string GetResponseId() { }

	// RVA: 0xA71E24
	public override string ToString() { }

}

// Namespace: 
internal sealed class GADURewardedAdLoadedCallback
{
	// Methods

	// RVA: 0xA739C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA74C88
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA74C9C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA74D30
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA73A6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA74D3C
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA74D50
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA74DF4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA73E44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA74E00
	public virtual void Invoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA74E14
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA74EC8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdPaidEventCallback
{
	// Methods

	// RVA: 0xA73EE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA74ED4
	public virtual void Invoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA74EE8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA74FB0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA73BB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA74FBC
	public virtual void Invoke(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA74FD0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA75074
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA73B10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA75080
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA75094
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA75128
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA73C58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA75134
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA75148
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA751DC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA73CFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA751E8
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA751FC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA75290
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA73DA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA7529C
	public virtual void Invoke(IntPtr rewardedAdClient) { }

	// RVA: 0xA752B0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA75344
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
	private static GADURewardedAdLoadedCallback <>f__mg$cache9; // 0x48
	private static GADURewardedAdFailedToLoadCallback <>f__mg$cacheA; // 0x50
	private static GADURewardedAdWillPresentFullScreenContentCallback <>f__mg$cacheB; // 0x58
	private static GADURewardedAdFailedToPresentFullScreenContentCallback <>f__mg$cacheC; // 0x60
	private static GADURewardedAdDidDismissFullScreenContentCallback <>f__mg$cacheD; // 0x68
	private static GADURewardedAdDidRecordImpressionCallback <>f__mg$cacheE; // 0x70
	private static GADURewardedAdDidRecordClickCallback <>f__mg$cacheF; // 0x78
	private static GADURewardedAdUserEarnedRewardCallback <>f__mg$cache10; // 0x80
	private static GADURewardedAdPaidEventCallback <>f__mg$cache11; // 0x88

	// Methods

	// RVA: 0xA682EC
	public void .ctor() { }

	// RVA: 0xA724D0
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72584
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72638
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA726EC
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA727A0
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA72854
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA72908
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA729BC
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA72A70
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA72B24
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA72BD8
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72C8C
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72D40
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72DF4
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72EA8
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA72F5C
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA73010
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA730B4
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA73158
	private IntPtr get_RewardedAdPtr() { }

	// RVA: 0xA73160
	private void set_RewardedAdPtr(IntPtr value) { }

	// RVA: 0xA7318C
	internal void CreateRewardedAdWithReference(IntPtr rewardedAdClientRef, IntPtr rewardedAdRef) { }

	// RVA: 0xA73F8C
	public void CreateRewardedAd() { }

	// RVA: 0xA747C4
	public bool IsAdAvailable(string adUnitId) { }

	// RVA: 0xA74800
	public IRewardedAdClient PollAd(string adUnitId) { }

	// RVA: 0xA7484C
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA748B4
	public void Show() { }

	// RVA: 0xA748BC
	public string GetAdUnitID() { }

	// RVA: 0xA748F4
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA74930
	public Reward GetRewardItem() { }

	// RVA: 0xA749E0
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA74A54
	public void DestroyRewardedAd() { }

	// RVA: 0xA74A7C
	public void Dispose() { }

	// RVA: 0xA74ACC
	protected override void Finalize() { }

	// RVA: 0xA71E80
	private static void RewardedAdLoadedCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA71F24
	private static void RewardedAdFailedToLoadCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA72010
	private static void RewardedAdUserDidEarnRewardCallback(IntPtr rewardedAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA720E8
	private static void RewardedAdPaidEventCallback(IntPtr rewardedAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA721C0
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedAdClient, IntPtr error) { }

	// RVA: 0xA722AC
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA72350
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA723F4
	private static void AdDidRecordImpressionCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA72498
	private static void AdDidRecordClickCallback(IntPtr rewardedAdClient) { }

	// RVA: 0xA74B88
	private static RewardedAdClient IntPtrToRewardedAdClient(IntPtr rewardedAdClient) { }

}

// Namespace: 
internal sealed class GADUAdAvailableForPreloadIdCallback
{
	// Methods

	// RVA: 0xA75F48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA75FEC
	public virtual void Invoke(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA76000
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr responseInfoClient, AsyncCallback callback, object object) { }

	// RVA: 0xA760B0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdFailedToPreloadForPreloadIdCallback
{
	// Methods

	// RVA: 0xA760BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA76160
	public virtual void Invoke(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA76174
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr adErrorReference, AsyncCallback callback, object object) { }

	// RVA: 0xA76224
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUAdsExhaustedForPreloadIdCallback
{
	// Methods

	// RVA: 0xA76230
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA762D4
	public virtual void Invoke(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA762E8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedAdPreloaderClient, string preloadId, AsyncCallback callback, object object) { }

	// RVA: 0xA76380
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.iOS
public class RewardedAdPreloaderClient
{
	// Fields
	private IntPtr _rewardedAdPreloaderPtr; // 0x10
	private readonly IntPtr _rewardedAdPreloaderClientPtr; // 0x18
	private System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> _onAdFailedToPreload; // 0x20
	private System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> _onAdPreloaded; // 0x28
	private System.Action<System.String> _onAdsExhausted; // 0x30
	private static GADUAdAvailableForPreloadIdCallback <>f__mg$cache0; // 0x0
	private static GADUAdFailedToPreloadForPreloadIdCallback <>f__mg$cache1; // 0x8
	private static GADUAdsExhaustedForPreloadIdCallback <>f__mg$cache2; // 0x10

	// Methods

	// RVA: 0xA68438
	public void .ctor() { }

	// RVA: 0xA75518
	private IntPtr get_RewardedAdPreloaderPtr() { }

	// RVA: 0xA754EC
	private void set_RewardedAdPreloaderPtr(IntPtr value) { }

	// RVA: 0xA75520
	public bool Preload(string preloadId, PreloadConfiguration preloadConfiguration, System.Action<System.String,GoogleMobileAds.Common.IResponseInfoClient> onAdPreloaded, System.Action<System.String,GoogleMobileAds.Common.IAdErrorClient> onAdFailedToPreload, System.Action<System.String> onAdsExhausted) { }

	// RVA: 0xA75680
	public bool IsAdAvailable(string preloadId) { }

	// RVA: 0xA756C8
	public IRewardedAdClient DequeueAd(string preloadId) { }

	// RVA: 0xA757AC
	public int GetNumAdsAvailable(string preloadId) { }

	// RVA: 0xA757F0
	public PreloadConfiguration GetConfiguration(string preloadId) { }

	// RVA: 0xA758FC
	public System.Collections.Generic.Dictionary<System.String,GoogleMobileAds.Api.PreloadConfiguration> GetConfigurations() { }

	// RVA: 0xA75D40
	public void Destroy(string preloadId) { }

	// RVA: 0xA75D78
	public void DestroyAll() { }

	// RVA: 0xA75D80
	protected override void Finalize() { }

	// RVA: 0xA75350
	private static void AdAvailableForPreloadIdCallback(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr responseInfoClient) { }

	// RVA: 0xA753F8
	private static void AdFailedToPreloadForPreloadIdCallback(IntPtr rewardedAdPreloaderClient, string preloadId, IntPtr adErrorReference) { }

	// RVA: 0xA754A0
	private static void AdsExhaustedForPreloadIdCallback(IntPtr rewardedAdPreloaderClient, string preloadId) { }

	// RVA: 0xA75E48
	private static RewardedAdPreloaderClient IntPtrToRewardedAdPreloaderClient(IntPtr rewardedAdPreloaderClient) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdLoadedCallback
{
	// Methods

	// RVA: 0xA77EA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79768
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA7977C
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA79810
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToLoadCallback
{
	// Methods

	// RVA: 0xA77F48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA7981C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA79830
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA798D4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdUserEarnedRewardCallback
{
	// Methods

	// RVA: 0xA77FEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA798E0
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA798F4
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount, AsyncCallback callback, object object) { }

	// RVA: 0xA799A8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdPaidEventCallback
{
	// Methods

	// RVA: 0xA78090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA799B4
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA799C8
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode, AsyncCallback callback, object object) { }

	// RVA: 0xA79A90
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdFailedToPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA78134
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79A9C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA79AB0
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0xA79B54
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdWillPresentFullScreenContentCallback
{
	// Methods

	// RVA: 0xA781D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79B60
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA79B74
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA79C08
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidDismissFullScreenContentCallback
{
	// Methods

	// RVA: 0xA7827C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79C14
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA79C28
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA79CBC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordImpressionCallback
{
	// Methods

	// RVA: 0xA78320
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79CC8
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA79CDC
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA79D70
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADURewardedInterstitialAdDidRecordClickCallback
{
	// Methods

	// RVA: 0xA783C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA79D7C
	public virtual void Invoke(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA79D90
	public virtual IAsyncResult BeginInvoke(IntPtr rewardedInterstitialAdClient, AsyncCallback callback, object object) { }

	// RVA: 0xA79E24
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

	// RVA: 0xA769DC
	public void .ctor() { }

	// RVA: 0xA769E4
	public void add_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA76A98
	public void remove_OnAdLoaded(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA76B4C
	public void add_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA76C00
	public void remove_OnAdFailedToLoad(System.EventHandler<GoogleMobileAds.Common.LoadAdErrorClientEventArgs> value) { }

	// RVA: 0xA76CB4
	public void add_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA76D68
	public void remove_OnUserEarnedReward(System.EventHandler<GoogleMobileAds.Api.Reward> value) { }

	// RVA: 0xA76E1C
	public void add_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA76ED0
	public void remove_OnPaidEvent(System.Action<GoogleMobileAds.Api.AdValue> value) { }

	// RVA: 0xA76F84
	public void add_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA77038
	public void remove_OnAdFailedToPresentFullScreenContent(System.EventHandler<GoogleMobileAds.Common.AdErrorClientEventArgs> value) { }

	// RVA: 0xA770EC
	public void add_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA771A0
	public void remove_OnAdDidPresentFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA77254
	public void add_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA77308
	public void remove_OnAdDidDismissFullScreenContent(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA773BC
	public void add_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA77470
	public void remove_OnAdDidRecordImpression(System.EventHandler<System.EventArgs> value) { }

	// RVA: 0xA77524
	public void add_OnAdClicked(Action value) { }

	// RVA: 0xA775C8
	public void remove_OnAdClicked(Action value) { }

	// RVA: 0xA7766C
	private IntPtr get_RewardedInterstitialAdPtr() { }

	// RVA: 0xA77674
	private void set_RewardedInterstitialAdPtr(IntPtr value) { }

	// RVA: 0xA776A4
	public void CreateRewardedInterstitialAd() { }

	// RVA: 0xA78468
	public void LoadAd(string adUnitID, AdRequest request) { }

	// RVA: 0xA79340
	public void Show() { }

	// RVA: 0xA7934C
	public string GetAdUnitID() { }

	// RVA: 0xA79358
	public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions) { }

	// RVA: 0xA79418
	public Reward GetRewardItem() { }

	// RVA: 0xA794C0
	public IResponseInfoClient GetResponseInfoClient() { }

	// RVA: 0xA79530
	public void DestroyRewardedInterstitialAd() { }

	// RVA: 0xA7955C
	public void Dispose() { }

	// RVA: 0xA795AC
	protected override void Finalize() { }

	// RVA: 0xA7638C
	private static void RewardedInterstitialAdLoadedCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA76430
	private static void RewardedInterstitialAdFailedToLoadCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA7651C
	private static void RewardedInterstitialAdUserDidEarnRewardCallback(IntPtr rewardedInterstitialAdClient, string rewardType, Double rewardAmount) { }

	// RVA: 0xA765F4
	private static void RewardedInterstitialAdPaidEventCallback(IntPtr rewardedInterstitialAdClient, int precision, Int64 value, string currencyCode) { }

	// RVA: 0xA766CC
	private static void AdFailedToPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient, IntPtr error) { }

	// RVA: 0xA767B8
	private static void AdWillPresentFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA7685C
	private static void AdDidDismissFullScreenContentCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA76900
	private static void AdDidRecordImpressionCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA769A4
	private static void AdDidRecordClickCallback(IntPtr rewardedInterstitialAdClient) { }

	// RVA: 0xA79668
	private static RewardedInterstitialAdClient IntPtrToRewardedInterstitialAdClient(IntPtr rewardedInterstitialAdClient) { }

}

// Namespace: GoogleMobileAds.iOS
internal class Utils
{
	// Methods

	// RVA: 0xA79E30
	public void .ctor() { }

	// RVA: 0xA79E38
	public static IntPtr BuildAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA784BC
	public static IntPtr BuildAdManagerAdRequest(AdRequest request, string nativePluginVersion) { }

	// RVA: 0xA793C8
	public static IntPtr BuildServerSideVerificationOptions(ServerSideVerificationOptions options) { }

	// RVA: 0xA7AA68
	public static string PtrToString(IntPtr stringPtr) { }

	// RVA: 0xA7AAE4
	public static System.Collections.Generic.List<System.String> PtrArrayToManagedList(IntPtr arrayPtr, int numOfAssets) { }

	// RVA: 0xA7ACDC
	public static System.Collections.Generic.Dictionary<System.String,System.IntPtr> PtrNsDictionaryToDictionary(IntPtr dictPtr) { }

}


