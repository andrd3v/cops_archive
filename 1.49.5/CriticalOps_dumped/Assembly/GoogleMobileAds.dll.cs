// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.Api
public class ApplicationPreferences
{
	// Fields
	private static IApplicationPreferencesClient _client; // 0x0

	// Methods

	// RVA: 0x9F99C0
	private static void .cctor() { }

	// RVA: 0x9F9E40
	public static string GetString(string key) { }

}

// Namespace: 
private sealed class <RaiseAction>c__AnonStorey7
{
	// Fields
	internal Action action; // 0x10

	// Methods

	// RVA: 0x9FA274
	public void .ctor() { }

	// RVA: 0x9FA27C
	internal void <>m__0(object state) { }

}

// Namespace: GoogleMobileAds.Api
public class MobileAds
{
	// Fields
	private static IClientFactory clientFactory; // 0x0
	private static SynchronizationContext _synchronizationContext; // 0x8
	private static int _unityMainThreadId; // 0x10
	private static bool <RaiseAdEventsOnUnityMainThread>k__BackingField; // 0x14

	// Methods

	// RVA: 0x9F9F34
	private static void .cctor() { }

	// RVA: 0x9F9FCC
	public static bool get_RaiseAdEventsOnUnityMainThread() { }

	// RVA: 0x9F9BA0
	internal static IClientFactory GetClientFactory() { }

	// RVA: 0x9FA048
	internal static void RaiseAction(Action action) { }

	// RVA: 0x9F9F38
	internal static void SetUnityMainThreadSynchronizationContext() { }

}


