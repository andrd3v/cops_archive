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

	// RVA: 0x158BBB4
	private void MoveNext() { }

	// RVA: 0x158BF18
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

	// RVA: 0x158BF98
	private void MoveNext() { }

	// RVA: 0x158C42C
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

	// RVA: 0x158C4AC
	private void MoveNext() { }

	// RVA: 0x158CBC0
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

	// RVA: 0x158CC2C
	private void MoveNext() { }

	// RVA: 0x158CF04
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

	// RVA: 0x158AB18
	internal ActionScheduler get_ActionScheduler() { }

	// RVA: 0x158AB20
	private void set_ActionScheduler(ActionScheduler value) { }

	// RVA: 0x158AB28
	internal InstallationId get_InstallationId() { }

	// RVA: 0x158AB30
	private void set_InstallationId(InstallationId value) { }

	// RVA: 0x158AB38
	internal ProjectConfiguration get_ProjectConfig() { }

	// RVA: 0x158AB40
	private void set_ProjectConfig(ProjectConfiguration value) { }

	// RVA: 0x158AB48
	internal Environments get_Environments() { }

	// RVA: 0x158AB50
	private void set_Environments(Environments value) { }

	// RVA: 0x158AB58
	internal ExternalUserId get_ExternalUserId() { }

	// RVA: 0x158AB60
	private void set_ExternalUserId(ExternalUserId value) { }

	// RVA: 0x158AB68
	internal ICloudProjectId get_CloudProjectId() { }

	// RVA: 0x158AB70
	private void set_CloudProjectId(ICloudProjectId value) { }

	// RVA: 0x158AB78
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	// RVA: 0x158AB80
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	// RVA: 0x158AB88
	internal IMetricsFactory get_MetricsFactory() { }

	// RVA: 0x158AB90
	private void set_MetricsFactory(IMetricsFactory value) { }

	// RVA: 0x158AB98
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	// RVA: 0x158ABA0
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	// RVA: 0x158ABA8
	private static void InitializeOnLoad() { }

	// RVA: 0x158ACAC
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x158AC78
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x158AEE4
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x158AFF4
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	// RVA: 0x158AF0C
	private Task InitializeComponents() { }

	// RVA: 0x158B01C
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x158B0A0
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x158B0F4
	internal void InitializeInstallationId() { }

	// RVA: 0x158B180
	internal void InitializeActionScheduler() { }

	// RVA: 0x158B20C
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	// RVA: 0x158B314
	internal System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	// RVA: 0x158B444
	internal static System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x158B540
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x158B6D4
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x158B820
	internal void InitializeMetrics() { }

	// RVA: 0x158B898
	internal void InitializeDiagnostics() { }

	// RVA: 0x158B910
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x158B99C
	internal void InitializeUnityThreadUtils() { }

	// RVA: 0x158BA14
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	// RVA: 0x158BBAC
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

}


