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

	// RVA: 0x15AED7C
	private void MoveNext() { }

	// RVA: 0x15AF0E0
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

	// RVA: 0x15AF160
	private void MoveNext() { }

	// RVA: 0x15AF5F4
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

	// RVA: 0x15AF674
	private void MoveNext() { }

	// RVA: 0x15AFD88
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

	// RVA: 0x15AFDF4
	private void MoveNext() { }

	// RVA: 0x15B00CC
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

	// RVA: 0x15ADCE0
	internal ActionScheduler get_ActionScheduler() { }

	// RVA: 0x15ADCE8
	private void set_ActionScheduler(ActionScheduler value) { }

	// RVA: 0x15ADCF0
	internal InstallationId get_InstallationId() { }

	// RVA: 0x15ADCF8
	private void set_InstallationId(InstallationId value) { }

	// RVA: 0x15ADD00
	internal ProjectConfiguration get_ProjectConfig() { }

	// RVA: 0x15ADD08
	private void set_ProjectConfig(ProjectConfiguration value) { }

	// RVA: 0x15ADD10
	internal Environments get_Environments() { }

	// RVA: 0x15ADD18
	private void set_Environments(Environments value) { }

	// RVA: 0x15ADD20
	internal ExternalUserId get_ExternalUserId() { }

	// RVA: 0x15ADD28
	private void set_ExternalUserId(ExternalUserId value) { }

	// RVA: 0x15ADD30
	internal ICloudProjectId get_CloudProjectId() { }

	// RVA: 0x15ADD38
	private void set_CloudProjectId(ICloudProjectId value) { }

	// RVA: 0x15ADD40
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	// RVA: 0x15ADD48
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	// RVA: 0x15ADD50
	internal IMetricsFactory get_MetricsFactory() { }

	// RVA: 0x15ADD58
	private void set_MetricsFactory(IMetricsFactory value) { }

	// RVA: 0x15ADD60
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	// RVA: 0x15ADD68
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	// RVA: 0x15ADD70
	private static void InitializeOnLoad() { }

	// RVA: 0x15ADE74
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x15ADE40
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x15AE0AC
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x15AE1BC
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	// RVA: 0x15AE0D4
	private Task InitializeComponents() { }

	// RVA: 0x15AE1E4
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x15AE268
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x15AE2BC
	internal void InitializeInstallationId() { }

	// RVA: 0x15AE348
	internal void InitializeActionScheduler() { }

	// RVA: 0x15AE3D4
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	// RVA: 0x15AE4DC
	internal System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	// RVA: 0x15AE60C
	internal static System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x15AE708
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x15AE89C
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x15AE9E8
	internal void InitializeMetrics() { }

	// RVA: 0x15AEA60
	internal void InitializeDiagnostics() { }

	// RVA: 0x15AEAD8
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x15AEB64
	internal void InitializeUnityThreadUtils() { }

	// RVA: 0x15AEBDC
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	// RVA: 0x15AED74
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

}


