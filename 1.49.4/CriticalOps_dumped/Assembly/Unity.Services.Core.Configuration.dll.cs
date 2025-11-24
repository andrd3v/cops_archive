// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Configuration
internal class CloudProjectId
{
	// Methods

	// RVA: 0x1570908
	public string GetCloudProjectId() { }

	// RVA: 0x1570978
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationCollectionHelper
{
	// Methods

	// RVA: 0x1570980
	public static void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	// RVA: 0x1570BE8
	public static void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, InitializationOptions options) { }

	// RVA: 0x1570A14
	private static void SetOrCreateEntry(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, string key, ConfigurationEntry entry) { }

}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal class ConfigurationEntry
{
	// Fields
	private string m_Value; // 0x10
	private bool m_IsReadOnly; // 0x18

	// Methods

	// RVA: 0x1571188
	public string get_Value() { }

	// RVA: 0x1571190
	public bool get_IsReadOnly() { }

	// RVA: 0x1571198
	public void .ctor() { }

	// RVA: 0x15711A0
	public void .ctor(string value, bool isReadOnly) { }

	// RVA: 0x1571144
	public bool TrySetValue(string value) { }

	// RVA: 0x1571128
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x15710B0
	public static ConfigurationEntry op_Implicit(string value) { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationUtils
{
	// Fields
	private static IConfigurationLoader <ConfigurationLoader>k__BackingField; // 0x0

	// Methods

	// RVA: 0x15711E8
	public static IConfigurationLoader get_ConfigurationLoader() { }

	// RVA: 0x1571264
	private static void .cctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId
{
	// Methods

	// RVA: 0x157135C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal interface IConfigurationLoader
{
	// Methods

	// RVA: -1
	public abstract System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync() { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ProjectConfiguration
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues; // 0x10
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1571364
	public void .ctor(System.Collections.Generic.IReadOnlyDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x15713B4
	public string GetString(string key, string defaultValue) { }

}

// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal struct SerializableProjectConfiguration
{
	// Fields
	internal string[] Keys; // 0x10
	internal ConfigurationEntry[] Values; // 0x18

	// Methods

	// RVA: 0x15714C4
	public static SerializableProjectConfiguration get_Empty() { }

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

	// RVA: 0x1571768
	private void MoveNext() { }

	// RVA: 0x1571C9C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x1571328
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x1571650
	public System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class StreamingAssetsUtils
{
	// Methods

	// RVA: 0x1571AB8
	public static System.Threading.Tasks.Task<System.String> GetFileTextFromStreamingAssetsAsync(string path) { }

}


