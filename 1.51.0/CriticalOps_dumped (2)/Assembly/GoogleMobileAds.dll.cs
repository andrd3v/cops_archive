// Namespace: 
internal class <Module>
{}

// Namespace: GoogleMobileAds.Api
public class ApplicationPreferences
{
	// Fields
	private static IApplicationPreferencesClient _client; // 0x0

	// Methods

	// RVA: 0xA57818
	private static void .cctor() { }

	// RVA: 0xA57BF0
	public static string GetString(string key) { }

}

// Namespace: GoogleMobileAds.Api
public class MobileAds
{
	// Fields
	private static IClientFactory clientFactory; // 0x0
	private static bool <RaiseAdEventsOnUnityMainThread>k__BackingField; // 0x8

	// Methods

	// RVA: 0xA57CE4
	public static bool get_RaiseAdEventsOnUnityMainThread() { }

	// RVA: 0xA579D0
	internal static IClientFactory GetClientFactory() { }

	// RVA: 0xA57D30
	internal static void RaiseAction(Action action) { }

}


