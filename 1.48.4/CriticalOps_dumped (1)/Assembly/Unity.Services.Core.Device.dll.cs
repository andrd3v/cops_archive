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

	// RVA: 0x148FE80
	void .ctor() { }

	// RVA: 0x148FF40
	void CreateIdentifier() { }

	// RVA: 0x14902A0
	string ReadIdentifierFromFile() { }

	// RVA: 0x1490318
	void WriteIdentifierToFile(string identifier) { }

	// RVA: 0x14902E8
	string GenerateGuid() { }

}

// Namespace: Unity.Services.Core.Device
internal interface IUserIdentifierProvider 
{
	// Methods

	// RVA: 0x2FE360C
	string get_UserId() { }

	// RVA: 0x2FE4574
	void set_UserId(string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class NSUserDefaults 
{
	// Methods

	// RVA: 0x1490378
	string GetString(string key) { }

	// RVA: 0x149046C
	void SetString(string key, string value) { }

	// RVA: 0x1490420
	string UserDefaultsGetString(string key) { }

	// RVA: 0x1490510
	void UserDefaultsSetString(string key, string value) { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAdsIdentifier 
{
	// Methods

	// RVA: 0x1490558
	string get_UserId() { }

	// RVA: 0x14905E0
	void set_UserId(string value) { }

	// RVA: 0x149059C
	string get_IdentifierForInstallIos() { }

	// RVA: 0x1490634
	void set_IdentifierForInstallIos(string value) { }

	// RVA: 0x148FF30
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Device
internal class UnityAnalyticsIdentifier 
{
	// Methods

	// RVA: 0x1490688
	string get_UserId() { }

	// RVA: 0x14906D0
	void set_UserId(string value) { }

	// RVA: 0x148FF38
	void .ctor() { }

}


