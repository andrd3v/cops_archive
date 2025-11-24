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

	// RVA: 0x15A56F4
	public void .ctor() { }

	// RVA: 0x15A57B4
	public void CreateIdentifier() { }

	// RVA: 0x15A5B14
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x15A5B8C
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x15A5B5C
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

	// RVA: 0x15A5BEC
	public static string GetString(string key) { }

	// RVA: 0x15A5CE0
	public static void SetString(string key, string value) { }

	// RVA: 0x15A5C94
	private static extern string UserDefaultsGetString(string key) { }

	// RVA: 0x15A5D84
	private static extern void UserDefaultsSetString(string key, string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier
{
	// Methods

	// RVA: 0x15A5DCC
	public string get_UserId() { }

	// RVA: 0x15A5E54
	public void set_UserId(string value) { }

	// RVA: 0x15A5E10
	private static string get_IdentifierForInstallIos() { }

	// RVA: 0x15A5EA8
	private static void set_IdentifierForInstallIos(string value) { }

	// RVA: 0x15A57A4
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier
{
	// Methods

	// RVA: 0x15A5EFC
	public string get_UserId() { }

	// RVA: 0x15A5F44
	public void set_UserId(string value) { }

	// RVA: 0x15A57AC
	public void .ctor() { }

}


