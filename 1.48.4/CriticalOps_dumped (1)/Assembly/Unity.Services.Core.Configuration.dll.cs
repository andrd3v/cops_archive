// Namespace: 
internal class <Module> 
{}

// Namespace: Unity.Services.Core.Configuration
internal class CloudProjectId 
{
	// Methods

	// RVA: 0x148D58C
	string GetCloudProjectId() { }

	// RVA: 0x148D5FC
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationCollectionHelper 
{
	// Methods

	// RVA: 0x148D604
	void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	// RVA: 0x148D86C
	void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, InitializationOptions options) { }

	// RVA: 0x148D698
	void SetOrCreateEntry(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, ConfigurationEntry entry) { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ConfigurationEntry 
{
	// Fields
	private string m_Value; // 0x10
	private bool m_IsReadOnly; // 0x18

	// Methods

	// RVA: 0x148DE0C
	string get_Value() { }

	// RVA: 0x148DE14
	bool get_IsReadOnly() { }

	// RVA: 0x148DE1C
	void .ctor() { }

	// RVA: 0x148DE24
	void .ctor(string value, bool isReadOnly) { }

	// RVA: 0x148DDC8
	bool TrySetValue(string value) { }

	// RVA: 0x148DDAC
	string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x148DD34
	ConfigurationEntry op_Implicit(string value) { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationUtils 
{
	// Fields
	private static IConfigurationLoader <ConfigurationLoader>k__BackingField; // 0x0

	// Methods

	// RVA: 0x148DE6C
	IConfigurationLoader get_ConfigurationLoader() { }

	// RVA: 0x148DEE8
	void .cctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId 
{
	// Methods

	// RVA: 0x148DFE0
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal interface IConfigurationLoader 
{
	// Methods

	// RVA: 0x2FE360C
	System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync() { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ProjectConfiguration 
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues; // 0x10
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x18

	// Methods

	// RVA: 0x148DFE8
	void .ctor(System.Collections.Generic.IReadOnlyDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x148E038
	string GetString(string key, string defaultValue) { }

}

// Namespace: Unity.Services.Core.Configuration
internal struct SerializableProjectConfiguration 
{
	// Fields
	internal string[] Keys; // 0x10
	internal ConfigurationEntry[] Values; // 0x18

	// Methods

	// RVA: 0x148E148
	SerializableProjectConfiguration get_Empty() { }

}

// Namespace: 
private struct <GetConfigAsync>d__2 
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder; // 0x18
	public StreamingAssetsConfigurationLoader <>4__this; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__1; // 0x38

	// Methods

	// RVA: 0x148E3EC
	void MoveNext() { }

	// RVA: 0x148E920
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader 
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x148DFAC
	void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x148E2D4
	System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class StreamingAssetsUtils 
{
	// Methods

	// RVA: 0x148E73C
	System.Threading.Tasks.Task<System.String> GetFileTextFromStreamingAssetsAsync(string path) { }

}


