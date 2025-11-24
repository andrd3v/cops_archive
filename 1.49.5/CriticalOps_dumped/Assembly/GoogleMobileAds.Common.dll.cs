// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.Common
public class AdErrorClientEventArgs
{
	// Fields
	private IAdErrorClient <AdErrorClient>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9F7BF0
	public void .ctor() { }

	// RVA: 0x9F7C78
	public void set_AdErrorClient(IAdErrorClient value) { }

}

// Namespace: GoogleMobileAds.Common
public class AdInspectorErrorClientEventArgs
{
	// Fields
	private IAdInspectorErrorClient <AdErrorClient>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9F7C80
	public void .ctor() { }

	// RVA: 0x9F7D08
	public void set_AdErrorClient(IAdInspectorErrorClient value) { }

}

// Namespace: GoogleMobileAds.Common
public class AppStateEventClient
{
	// Fields
	private static AppStateEventClient instance; // 0x0
	private System.Action<GoogleMobileAds.Common.AppState> AppStateChanged; // 0x20
	private static System.Action<GoogleMobileAds.Common.AppState> <>f__am$cache0; // 0x8

	// Methods

	// RVA: 0x9F7D10
	public void .ctor() { }

	// RVA: 0x9F7E00
	public static AppStateEventClient get_Instance() { }

	// RVA: 0x9F7F68
	public void add_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value) { }

	// RVA: 0x9F801C
	public void remove_AppStateChanged(System.Action<GoogleMobileAds.Common.AppState> value) { }

	// RVA: 0x9F80D0
	private void OnApplicationPause(bool isPaused) { }

	// RVA: 0x9F8110
	private static void <AppStateChanged>m__0(AppState ) { }

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

	// RVA: -1
	public abstract string GetString(string key) { }

}

// Namespace: GoogleMobileAds.Common
public interface IBannerClient
{}

// Namespace: GoogleMobileAds
public interface IClientFactory
{
	// Methods

	// RVA: -1
	public abstract IApplicationPreferencesClient ApplicationPreferencesInstance() { }

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

	// RVA: 0x9F8114
	public void .ctor() { }

	// RVA: 0x9F819C
	public void set_LoadAdErrorClient(ILoadAdErrorClient value) { }

}

// Namespace: 
private sealed class <InvokeInUpdate>c__AnonStorey0
{
	// Fields
	internal UnityEvent eventParam; // 0x10

	// Methods

	// RVA: 0x9F8744
	public void .ctor() { }

	// RVA: 0x9F8C68
	internal void <>m__0() { }

}

// Namespace: GoogleMobileAds.Common
public class MobileAdsEventExecutor
{
	// Fields
	public static MobileAdsEventExecutor instance; // 0x0
	private static System.Collections.Generic.List<System.Action> adEventsQueue; // 0x8
	private static bool adEventsQueueEmpty; // 0x10

	// Methods

	// RVA: 0x9F81A4
	public void .ctor() { }

	// RVA: 0x9F81AC
	public static void Initialize() { }

	// RVA: 0x9F83A8
	public static bool IsActive() { }

	// RVA: 0x9F8474
	public void Awake() { }

	// RVA: 0x9F8500
	public static void ExecuteInUpdate(Action action) { }

	// RVA: 0x9F8640
	public static void InvokeInUpdate(UnityEvent eventParam) { }

	// RVA: 0x9F874C
	public void Update() { }

	// RVA: 0x9F8B38
	public void OnDisable() { }

	// RVA: 0x9F8BA0
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.Common
public enum ResponseInfoClientType
{
	// Fields
	public int value__; // 0x10
	public const ResponseInfoClientType AdLoaded = 1;
	public const ResponseInfoClientType AdError = 2;
}


