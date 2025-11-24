// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.Api
public class ApplicationPreferences
{
	// Fields
	private static IApplicationPreferencesClient _client; // 0x0

	// Methods

	// RVA: 0xA12A24
	private static void .cctor() { }

	// RVA: 0xA12EA4
	public static string GetString(string key) { }

}

// Namespace: 
private sealed class <RaiseAction>c__AnonStorey7
{
	// Fields
	internal Action action; // 0x10

	// Methods

	// RVA: 0xA132D8
	public void .ctor() { }

	// RVA: 0xA132E0
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

	// RVA: 0xA12F98
	private static void .cctor() { }

	// RVA: 0xA13030
	public static bool get_RaiseAdEventsOnUnityMainThread() { }

	// RVA: 0xA12C04
	internal static IClientFactory GetClientFactory() { }

	// RVA: 0xA130AC
	internal static void RaiseAction(Action action) { }

	// RVA: 0xA12F9C
	internal static void SetUnityMainThreadSynchronizationContext() { }

}


