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

	// RVA: 0x15E872C
	public void .ctor() { }

	// RVA: 0x15E87EC
	public void CreateIdentifier() { }

	// RVA: 0x15E8B4C
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x15E8BC4
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x15E8B94
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

	// RVA: 0x15E8C24
	public static string GetString(string key) { }

	// RVA: 0x15E8D18
	public static void SetString(string key, string value) { }

	// RVA: 0x15E8CCC
	private static extern string UserDefaultsGetString(string key) { }

	// RVA: 0x15E8DBC
	private static extern void UserDefaultsSetString(string key, string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier
{
	// Methods

	// RVA: 0x15E8E04
	public string get_UserId() { }

	// RVA: 0x15E8E8C
	public void set_UserId(string value) { }

	// RVA: 0x15E8E48
	private static string get_IdentifierForInstallIos() { }

	// RVA: 0x15E8EE0
	private static void set_IdentifierForInstallIos(string value) { }

	// RVA: 0x15E87DC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier
{
	// Methods

	// RVA: 0x15E8F34
	public string get_UserId() { }

	// RVA: 0x15E8F7C
	public void set_UserId(string value) { }

	// RVA: 0x15E87E4
	public void .ctor() { }

}


