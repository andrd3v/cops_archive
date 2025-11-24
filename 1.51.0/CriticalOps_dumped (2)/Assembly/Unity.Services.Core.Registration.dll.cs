// Namespace: 
internal class <Module>
{}

// Namespace: 
private struct <GenerateProjectConfigurationAsync>d__53
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder; // 0x18
	public InitializationOptions options; // 0x30
	public CorePackageInitializer <>4__this; // 0x38
	private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1; // 0x40

	// Methods

	// RVA: 0x15F2298
	private void MoveNext() { }

	// RVA: 0x15F25FC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <GetSerializedConfigOrEmptyAsync>d__54
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder; // 0x18
	private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x15F267C
	private void MoveNext() { }

	// RVA: 0x15F2B10
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeComponents>d__47
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CorePackageInitializer <>4__this; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x15F2B90
	private void MoveNext() { }

	// RVA: 0x15F3278
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeProjectConfigAsync>d__52
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CorePackageInitializer <>4__this; // 0x30
	public InitializationOptions options; // 0x38
	private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1; // 0x40

	// Methods

	// RVA: 0x15F32E4
	private void MoveNext() { }

	// RVA: 0x15F35BC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Registration
internal class CorePackageInitializer
{
	// Fields
	private ActionScheduler <ActionScheduler>k__BackingField; // 0x10
	private InstallationId <InstallationId>k__BackingField; // 0x18
	private ProjectConfiguration <ProjectConfig>k__BackingField; // 0x20
	private Environments <Environments>k__BackingField; // 0x28
	private ExternalUserId <ExternalUserId>k__BackingField; // 0x30
	private ICloudProjectId <CloudProjectId>k__BackingField; // 0x38
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; // 0x40
	private IMetricsFactory <MetricsFactory>k__BackingField; // 0x48
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; // 0x50
	private CoreRegistry m_Registry; // 0x58
	private readonly IJsonSerializer m_Serializer; // 0x60
	private InitializationOptions m_CurrentInitializationOptions; // 0x68

	// Methods

	// RVA: 0x15F11FC
	internal ActionScheduler get_ActionScheduler() { }

	// RVA: 0x15F1204
	private void set_ActionScheduler(ActionScheduler value) { }

	// RVA: 0x15F120C
	internal InstallationId get_InstallationId() { }

	// RVA: 0x15F1214
	private void set_InstallationId(InstallationId value) { }

	// RVA: 0x15F121C
	internal ProjectConfiguration get_ProjectConfig() { }

	// RVA: 0x15F1224
	private void set_ProjectConfig(ProjectConfiguration value) { }

	// RVA: 0x15F122C
	internal Environments get_Environments() { }

	// RVA: 0x15F1234
	private void set_Environments(Environments value) { }

	// RVA: 0x15F123C
	internal ExternalUserId get_ExternalUserId() { }

	// RVA: 0x15F1244
	private void set_ExternalUserId(ExternalUserId value) { }

	// RVA: 0x15F124C
	internal ICloudProjectId get_CloudProjectId() { }

	// RVA: 0x15F1254
	private void set_CloudProjectId(ICloudProjectId value) { }

	// RVA: 0x15F125C
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	// RVA: 0x15F1264
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	// RVA: 0x15F126C
	internal IMetricsFactory get_MetricsFactory() { }

	// RVA: 0x15F1274
	private void set_MetricsFactory(IMetricsFactory value) { }

	// RVA: 0x15F127C
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	// RVA: 0x15F1284
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	// RVA: 0x15F128C
	private static void InitializeOnLoad() { }

	// RVA: 0x15F1390
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x15F135C
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x15F15C8
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x15F16D8
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	// RVA: 0x15F15F0
	private Task InitializeComponents() { }

	// RVA: 0x15F1700
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x15F1784
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x15F17D8
	internal void InitializeInstallationId() { }

	// RVA: 0x15F1864
	internal void InitializeActionScheduler() { }

	// RVA: 0x15F18F0
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	// RVA: 0x15F19F8
	internal System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	// RVA: 0x15F1B28
	internal static System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x15F1C24
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x15F1DB8
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x15F1F04
	internal void InitializeMetrics() { }

	// RVA: 0x15F1F7C
	internal void InitializeDiagnostics() { }

	// RVA: 0x15F1FF4
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x15F2080
	internal void InitializeUnityThreadUtils() { }

	// RVA: 0x15F20F8
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	// RVA: 0x15F2290
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

}


