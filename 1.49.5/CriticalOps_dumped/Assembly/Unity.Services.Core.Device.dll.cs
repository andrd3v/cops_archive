// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Device
internal class InstallationId
{
	// Fields
	internal string Identifier; // 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; // 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; // 0x20

	// Methods

	// RVA: 0x158252C
	public void .ctor() { }

	// RVA: 0x15825EC
	public void CreateIdentifier() { }

	// RVA: 0x158294C
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x15829C4
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x1582994
	private static string GenerateGuid() { }

}

// Namespace: Unity.Services.Core.Device
internal interface IUserIdentifierProvider
{
	// Methods

	// RVA: -1
	public abstract string get_UserId() { }

	// RVA: -1
	public abstract void set_UserId(string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class NSUserDefaults
{
	// Methods

	// RVA: 0x1582A24
	public static string GetString(string key) { }

	// RVA: 0x1582B18
	public static void SetString(string key, string value) { }

	// RVA: 0x1582ACC
	private static extern string UserDefaultsGetString(string key) { }

	// RVA: 0x1582BBC
	private static extern void UserDefaultsSetString(string key, string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier
{
	// Methods

	// RVA: 0x1582C04
	public string get_UserId() { }

	// RVA: 0x1582C8C
	public void set_UserId(string value) { }

	// RVA: 0x1582C48
	private static string get_IdentifierForInstallIos() { }

	// RVA: 0x1582CE0
	private static void set_IdentifierForInstallIos(string value) { }

	// RVA: 0x15825DC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier
{
	// Methods

	// RVA: 0x1582D34
	public string get_UserId() { }

	// RVA: 0x1582D7C
	public void set_UserId(string value) { }

	// RVA: 0x15825E4
	public void .ctor() { }

}


