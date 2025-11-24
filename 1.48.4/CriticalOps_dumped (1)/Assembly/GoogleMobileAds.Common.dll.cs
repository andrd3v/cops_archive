// Namespace: 
internal class <Module> 
{}

// Namespace: GoogleMobileAds.Common
public class AdErrorClientEventArgs 
{
	// Fields
	private IAdErrorClient <AdErrorClient>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9BF078
	void .ctor() { }

	// RVA: 0x9BF100
	void set_AdErrorClient(IAdErrorClient value) { }

}

// Namespace: GoogleMobileAds.Common
public class AdInspectorErrorClientEventArgs 
{
	// Fields
	private IAdInspectorErrorClient <AdErrorClient>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9BF108
	void .ctor() { }

	// RVA: 0x9BF190
	void set_AdErrorClient(IAdInspectorErrorClient value) { }

}

// Namespace: GoogleMobileAds.Common
public class AppStateEventClient 
{
	// Fields
	private static AppStateEventClient instance; // 0x0
	private System.Action<GoogleMobileAds.Common.AppState> AppStateChanged; // 0x20
	private static System.Action<GoogleMobileAds.Common.AppState> <>f__am$cache0; // 0x8

	// Methods

	// RVA: 0x9BF198
	void .ctor() { }

	// RVA: 0x9BF288
	AppStateEventClient get_Instance() { }

	// RVA: 0x9BF3F0
	void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value) { }

	// RVA: 0x9BF4A4
	void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value) { }

	// RVA: 0x9BF558
	void OnApplicationPause(bool isPaused) { }

	// RVA: 0x9BF598
	void <AppStateChanged>m__0(AppState ) { }

}

// Namespace: GoogleMobileAds.Common
public interface IAdErrorClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IAdInspectorErrorClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IAdManagerBannerClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IAdManagerInterstitialClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IAdapterResponseInfoClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IAppOpenAdClient 
{}

// Namespace: GoogleMobileAds.Common
public enum AppState 
{
	// Fields
	public int value__; // 0x10
	public const AppState Background = 0;
	public const AppState Foreground = 1;
}

// Namespace: GoogleMobileAds.Common
public interface IAppStateEventClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IApplicationPreferencesClient 
{
	// Methods

	// RVA: 0x2FE36BC
	string GetString(string key) { }

}

// Namespace: GoogleMobileAds.Common
public interface IBannerClient 
{}

// Namespace: GoogleMobileAds
public interface IClientFactory 
{
	// Methods

	// RVA: 0x2FE360C
	IApplicationPreferencesClient ApplicationPreferencesInstance() { }

}

// Namespace: GoogleMobileAds.Common
public interface IInitializationStatusClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IInterstitialClient 
{}

// Namespace: GoogleMobileAds.Common
public interface ILoadAdErrorClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IMobileAdsClient 
{}

// Namespace: GoogleMobileAds.Common
public interface INativeOverlayAdClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IResponseInfoClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IRewardedAdClient 
{}

// Namespace: GoogleMobileAds.Common
public interface IRewardedInterstitialAdClient 
{}

// Namespace: GoogleMobileAds.Common
public class LoadAdErrorClientEventArgs 
{
	// Fields
	private ILoadAdErrorClient <LoadAdErrorClient>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9BF59C
	void .ctor() { }

	// RVA: 0x9BF624
	void set_LoadAdErrorClient(ILoadAdErrorClient value) { }

}

// Namespace: 
private sealed class <InvokeInUpdate>c__AnonStorey0 
{
	// Fields
	internal UnityEvent eventParam; // 0x10

	// Methods

	// RVA: 0x9BFBCC
	void .ctor() { }

	// RVA: 0x9C00F0
	void <>m__0() { }

}

// Namespace: GoogleMobileAds.Common
public class MobileAdsEventExecutor 
{
	// Fields
	public static MobileAdsEventExecutor instance; // 0x0
	private static System.Collections.Generic.List<System.Action> adEventsQueue; // 0x8
	private static bool adEventsQueueEmpty; // 0x10

	// Methods

	// RVA: 0x9BF62C
	void .ctor() { }

	// RVA: 0x9BF634
	void Initialize() { }

	// RVA: 0x9BF830
	bool IsActive() { }

	// RVA: 0x9BF8FC
	void Awake() { }

	// RVA: 0x9BF988
	void ExecuteInUpdate(Action action) { }

	// RVA: 0x9BFAC8
	void InvokeInUpdate(UnityEvent eventParam) { }

	// RVA: 0x9BFBD4
	void Update() { }

	// RVA: 0x9BFFC0
	void OnDisable() { }

	// RVA: 0x9C0028
	void .cctor() { }

}

// Namespace: GoogleMobileAds.Common
public enum ResponseInfoClientType 
{
	// Fields
	public int value__; // 0x10
	public const ResponseInfoClientType AdLoaded = 1;
	public const ResponseInfoClientType AdError = 2;
}


