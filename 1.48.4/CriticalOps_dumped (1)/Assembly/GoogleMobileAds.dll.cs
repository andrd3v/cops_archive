// Namespace: 
internal class <Module> 
{}

// Namespace: GoogleMobileAds.Api
public class ApplicationPreferences 
{
	// Fields
	private static IApplicationPreferencesClient _client; // 0x0

	// Methods

	// RVA: 0x9C0E30
	void .cctor() { }

	// RVA: 0x9C12B0
	string GetString(string key) { }

}

// Namespace: 
private sealed class <RaiseAction>c__AnonStorey7 
{
	// Fields
	internal Action action; // 0x10

	// Methods

	// RVA: 0x9C16E4
	void .ctor() { }

	// RVA: 0x9C16EC
	void <>m__0(object state) { }

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

	// RVA: 0x9C13A4
	void .cctor() { }

	// RVA: 0x9C143C
	bool get_RaiseAdEventsOnUnityMainThread() { }

	// RVA: 0x9C1010
	IClientFactory GetClientFactory() { }

	// RVA: 0x9C14B8
	void RaiseAction(Action action) { }

	// RVA: 0x9C13A8
	void SetUnityMainThreadSynchronizationContext() { }

}


