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

	// RVA: 0x15731FC
	public void .ctor() { }

	// RVA: 0x15732BC
	public void CreateIdentifier() { }

	// RVA: 0x157361C
	private static string ReadIdentifierFromFile() { }

	// RVA: 0x1573694
	private static void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x1573664
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

	// RVA: 0x15736F4
	public static string GetString(string key) { }

	// RVA: 0x15737E8
	public static void SetString(string key, string value) { }

	// RVA: 0x157379C
	private static extern string UserDefaultsGetString(string key) { }

	// RVA: 0x157388C
	private static extern void UserDefaultsSetString(string key, string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier
{
	// Methods

	// RVA: 0x15738D4
	public string get_UserId() { }

	// RVA: 0x157395C
	public void set_UserId(string value) { }

	// RVA: 0x1573918
	private static string get_IdentifierForInstallIos() { }

	// RVA: 0x15739B0
	private static void set_IdentifierForInstallIos(string value) { }

	// RVA: 0x15732AC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier
{
	// Methods

	// RVA: 0x1573A04
	public string get_UserId() { }

	// RVA: 0x1573A4C
	public void set_UserId(string value) { }

	// RVA: 0x15732B4
	public void .ctor() { }

}


