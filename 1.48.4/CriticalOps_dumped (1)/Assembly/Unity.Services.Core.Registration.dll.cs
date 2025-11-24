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

	// RVA: 0x1499508
	void MoveNext() { }

	// RVA: 0x149986C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <GetSerializedConfigOrEmptyAsync>d__54 
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder; // 0x18
	private System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1; // 0x30

	// Methods

	// RVA: 0x14998EC
	void MoveNext() { }

	// RVA: 0x1499D80
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1499E00
	void MoveNext() { }

	// RVA: 0x149A514
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x149A580
	void MoveNext() { }

	// RVA: 0x149A858
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x149846C
	ActionScheduler get_ActionScheduler() { }

	// RVA: 0x1498474
	void set_ActionScheduler(ActionScheduler value) { }

	// RVA: 0x149847C
	InstallationId get_InstallationId() { }

	// RVA: 0x1498484
	void set_InstallationId(InstallationId value) { }

	// RVA: 0x149848C
	ProjectConfiguration get_ProjectConfig() { }

	// RVA: 0x1498494
	void set_ProjectConfig(ProjectConfiguration value) { }

	// RVA: 0x149849C
	Environments get_Environments() { }

	// RVA: 0x14984A4
	void set_Environments(Environments value) { }

	// RVA: 0x14984AC
	ExternalUserId get_ExternalUserId() { }

	// RVA: 0x14984B4
	void set_ExternalUserId(ExternalUserId value) { }

	// RVA: 0x14984BC
	ICloudProjectId get_CloudProjectId() { }

	// RVA: 0x14984C4
	void set_CloudProjectId(ICloudProjectId value) { }

	// RVA: 0x14984CC
	IDiagnosticsFactory get_DiagnosticsFactory() { }

	// RVA: 0x14984D4
	void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	// RVA: 0x14984DC
	IMetricsFactory get_MetricsFactory() { }

	// RVA: 0x14984E4
	void set_MetricsFactory(IMetricsFactory value) { }

	// RVA: 0x14984EC
	UnityThreadUtilsInternal get_UnityThreadUtils() { }

	// RVA: 0x14984F4
	void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	// RVA: 0x14984FC
	void InitializeOnLoad() { }

	// RVA: 0x1498600
	void Register(CorePackageRegistry registry) { }

	// RVA: 0x14985CC
	void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x1498838
	Task Initialize(CoreRegistry registry) { }

	// RVA: 0x1498948
	Task InitializeInstanceAsync(CoreRegistry registry) { }

	// RVA: 0x1498860
	Task InitializeComponents() { }

	// RVA: 0x1498970
	bool HaveInitOptionsChanged() { }

	// RVA: 0x14989F4
	void FreeOptionsDependantComponents() { }

	// RVA: 0x1498A48
	void InitializeInstallationId() { }

	// RVA: 0x1498AD4
	void InitializeActionScheduler() { }

	// RVA: 0x1498B60
	Task InitializeProjectConfigAsync(InitializationOptions options) { }

	// RVA: 0x1498C68
	System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	// RVA: 0x1498D98
	System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x1498E94
	void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x1499028
	void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x1499174
	void InitializeMetrics() { }

	// RVA: 0x14991EC
	void InitializeDiagnostics() { }

	// RVA: 0x1499264
	void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x14992F0
	void InitializeUnityThreadUtils() { }

	// RVA: 0x1499368
	void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	// RVA: 0x1499500
	bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }

}


