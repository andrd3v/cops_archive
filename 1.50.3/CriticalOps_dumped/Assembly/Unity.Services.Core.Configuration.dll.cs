// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Configuration
internal class CloudProjectId
{
	// Methods

	// RVA: 0x15A2E00
	public string GetCloudProjectId() { }

	// RVA: 0x15A2E70
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationCollectionHelper
{
	// Methods

	// RVA: 0x15A2E78
	public static void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	// RVA: 0x15A30E0
	public static void FillWith(System.Collections.Generic.IDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> self, InitializationOptions options) { }

	// RVA: 0x15A2F0C
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

	// RVA: 0x15A3680
	public string get_Value() { }

	// RVA: 0x15A3688
	public bool get_IsReadOnly() { }

	// RVA: 0x15A3690
	public void .ctor() { }

	// RVA: 0x15A3698
	public void .ctor(string value, bool isReadOnly) { }

	// RVA: 0x15A363C
	public bool TrySetValue(string value) { }

	// RVA: 0x15A3620
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x15A35A8
	public static ConfigurationEntry op_Implicit(string value) { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class ConfigurationUtils
{
	// Fields
	private static IConfigurationLoader <ConfigurationLoader>k__BackingField; // 0x0

	// Methods

	// RVA: 0x15A36E0
	public static IConfigurationLoader get_ConfigurationLoader() { }

	// RVA: 0x15A375C
	private static void .cctor() { }

}

// Namespace: Unity.Services.Core.Configuration
internal class ExternalUserId
{
	// Methods

	// RVA: 0x15A3854
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

	// RVA: 0x15A385C
	public void .ctor(System.Collections.Generic.IReadOnlyDictionary<System.String,Unity.Services.Core.Configuration.ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x15A38AC
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

	// RVA: 0x15A39BC
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

	// RVA: 0x15A3C60
	private void MoveNext() { }

	// RVA: 0x15A4194
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x15A3820
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x15A3B48
	public System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetConfigAsync() { }

}

// Namespace: Unity.Services.Core.Configuration
internal static class StreamingAssetsUtils
{
	// Methods

	// RVA: 0x15A3FB0
	public static System.Threading.Tasks.Task<System.String> GetFileTextFromStreamingAssetsAsync(string path) { }

}


