// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.Api
public class ApplicationPreferences
{
	// Fields
	private static IApplicationPreferencesClient _client; // 0x0

	// Methods

	// RVA: 0x9EA740
	private static void .cctor() { }

	// RVA: 0x9EABC0
	public static string GetString(string key) { }

}

// Namespace: 
private sealed class <RaiseAction>c__AnonStorey7
{
	// Fields
	internal Action action; // 0x10

	// Methods

	// RVA: 0x9EAFF4
	public void .ctor() { }

	// RVA: 0x9EAFFC
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

	// RVA: 0x9EACB4
	private static void .cctor() { }

	// RVA: 0x9EAD4C
	public static bool get_RaiseAdEventsOnUnityMainThread() { }

	// RVA: 0x9EA920
	internal static IClientFactory GetClientFactory() { }

	// RVA: 0x9EADC8
	internal static void RaiseAction(Action action) { }

	// RVA: 0x9EACB8
	internal static void SetUnityMainThreadSynchronizationContext() { }

}


