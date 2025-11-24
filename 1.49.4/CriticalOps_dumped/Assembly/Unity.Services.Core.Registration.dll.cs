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

	// RVA: 0x157C884
	private void MoveNext() { }

	// RVA: 0x157CBE8
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

	// RVA: 0x157CC68
	private void MoveNext() { }

	// RVA: 0x157D0FC
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

	// RVA: 0x157D17C
	private void MoveNext() { }

	// RVA: 0x157D890
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

	// RVA: 0x157D8FC
	private void MoveNext() { }

	// RVA: 0x157DBD4
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

	// RVA: 0x157B7E8
	internal ActionScheduler get_ActionScheduler() { }

	// RVA: 0x157B7F0
	private void set_ActionScheduler(ActionScheduler value) { }

	// RVA: 0x157B7F8
	internal InstallationId get_InstallationId() { }

	// RVA: 0x157B800
	private void set_InstallationId(InstallationId value) { }

	// RVA: 0x157B808
	internal ProjectConfiguration get_ProjectConfig() { }

	// RVA: 0x157B810
	private void set_ProjectConfig(ProjectConfiguration value) { }

	// RVA: 0x157B818
	internal Environments get_Environments() { }

	// RVA: 0x157B820
	private void set_Environments(Environments value) { }

	// RVA: 0x157B828
	internal ExternalUserId get_ExternalUserId() { }

	// RVA: 0x157B830
	private void set_ExternalUserId(ExternalUserId value) { }

	// RVA: 0x157B838
	internal ICloudProjectId get_CloudProjectId() { }

	// RVA: 0x157B840
	private void set_CloudProjectId(ICloudProjectId value) { }

	// RVA: 0x157B848
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	// RVA: 0x157B850
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	// RVA: 0x157B858
	internal IMetricsFactory get_MetricsFactory() { }

	// RVA: 0x157B860
	private void set_MetricsFactory(IMetricsFactory value) { }

	// RVA: 0x157B868
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	// RVA: 0x157B870
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	// RVA: 0x157B878
	private static void InitializeOnLoad() { }

	// RVA: 0x157B97C
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x157B948
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x157BBB4
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x157BCC4
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	// RVA: 0x157BBDC
	private Task InitializeComponents() { }

	// RVA: 0x157BCEC
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x157BD70
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x157BDC4
	internal void InitializeInstallationId() { }

	// RVA: 0x157BE50
	internal void InitializeActionScheduler() { }

	// RVA: 0x157BEDC
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	// RVA: 0x157BFE4
	internal System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	// RVA: 0x157C114
	internal static System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x157C210
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x157C3A4
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x157C4F0
	internal void InitializeMetrics() { }

	// RVA: 0x157C568
	internal void InitializeDiagnostics() { }

	// RVA: 0x157C5E0
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x157C66C
	internal void InitializeUnityThreadUtils() { }

	// RVA: 0x157C6E4
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	// RVA: 0x157C87C
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

}


