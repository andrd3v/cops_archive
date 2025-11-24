// Namespace: 
internal class <Module> 
{}

// Namespace: Unity.Services.Core.Threading.Internal
public interface IUnityThreadUtils 
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnostics 
{
	// Methods

	// RVA: 0x2FE49A8
	void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal interface IDiagnosticsComponentProvider 
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnosticsFactory 
{
	// Methods

	// RVA: 0x2FE36BC
	IDiagnostics Create(string packageName) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetrics 
{
	// Methods

	// RVA: -1
	void SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: -1
	void SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: -1
	void SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetricsFactory 
{
	// Methods

	// RVA: 0x2FE36BC
	IMetrics Create(string packageName) { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
public interface IActionScheduler 
{}

// Namespace: Unity.Services.Core.Environments.Internal
public interface IEnvironments 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Current() { }

}

// Namespace: Unity.Services.Core.Device.Internal
public interface IInstallationId 
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface ICloudProjectId 
{
	// Methods

	// RVA: 0x2FE360C
	string GetCloudProjectId() { }

}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IExternalUserId 
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IProjectConfiguration 
{
	// Methods

	// RVA: 0x2FE37A0
	string GetString(string key, string defaultValue) { }

}

// Namespace: Unity.Services.Core.Analytics.Internal
public interface IAnalyticsStandardEventComponent 
{}

// Namespace: Unity.Services.Core.Internal
internal abstract class AsyncOperationBase 
{
	// Methods

	// RVA: 0x14908A4
	bool get_keepWaiting() { }

	// RVA: 0x2FE3054
	bool get_IsCompleted() { }

}

// Namespace: Unity.Services.Core.Internal
internal class TaskAsyncOperation 
{
	// Fields
	internal static TaskScheduler Scheduler; // 0x0
	private Task m_Task; // 0x10

	// Methods

	// RVA: 0x14908C4
	bool get_IsCompleted() { }

	// RVA: 0x14908E4
	void SetScheduler() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class CoreLogger 
{
	// Methods

	// RVA: 0x1490968
	void LogWarning(object message) { }

	// RVA: 0x1490AC4
	void LogError(object message) { }

	// RVA: 0x1490C20
	void LogException(Exception exception) { }

}

// Namespace: Unity.Services.Core.Internal
public class CircularDependencyException 
{
	// Methods

	// RVA: 0x1490D80
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1490D88
	System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x1490D90
	void .ctor() { }

	// RVA: 0x309AF8C
	void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x309AF8C
	TComponent GetServiceComponent() { }

	// RVA: 0x1490E1C
	bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x1490F14
	void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal interface IComponentRegistry 
{
	// Methods

	// RVA: 0x309AF8C
	void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x309AF8C
	TComponent GetServiceComponent() { }

	// RVA: 0x2FE4574
	void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal class LockedComponentRegistry 
{
	// Fields
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1490FA8
	IComponentRegistry get_Registry() { }

	// RVA: 0x1490FB0
	void .ctor(IComponentRegistry registryToLock) { }

	// RVA: 0x309AF8C
	void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x309AF8C
	TComponent GetServiceComponent() { }

	// RVA: 0x1490FE4
	void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry 
{
	// Fields
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1491038
	CorePackageRegistry get_Instance() { }

	// RVA: 0x1491084
	void set_Instance(CorePackageRegistry value) { }

	// RVA: 0x14910E8
	IPackageRegistry get_Registry() { }

	// RVA: 0x14910F0
	void set_Registry(IPackageRegistry value) { }

	// RVA: 0x14910F8
	void .ctor() { }

	// RVA: 0x309AF8C
	CoreRegistration Register(TPackage package) { }

	// RVA: 0x1491360
	void Lock() { }

}

// Namespace: Unity.Services.Core.Internal
public struct CoreRegistration 
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x10
	private readonly int m_PackageHash; // 0x18

	// Methods

	// RVA: 0x1491450
	void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: 0x309AF8C
	CoreRegistration DependsOn() { }

	// RVA: 0x309AF8C
	CoreRegistration OptionallyDependsOn() { }

	// RVA: 0x309AF8C
	CoreRegistration ProvidesComponent() { }

}

// Namespace: Unity.Services.Core.Internal
public sealed class CoreRegistry 
{
	// Fields
	private static CoreRegistry <Instance>k__BackingField; // 0x0
	private readonly string <InstanceId>k__BackingField; // 0x10
	private ServicesType <Type>k__BackingField; // 0x18
	private InitializationOptions <Options>k__BackingField; // 0x20
	private IPackageRegistry <PackageRegistry>k__BackingField; // 0x28
	private IComponentRegistry <ComponentRegistry>k__BackingField; // 0x30
	private IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

	// Methods

	// RVA: 0x149147C
	CoreRegistry get_Instance() { }

	// RVA: 0x14914C8
	void set_Instance(CoreRegistry value) { }

	// RVA: 0x149152C
	ServicesType get_Type() { }

	// RVA: 0x1491534
	void set_Type(ServicesType value) { }

	// RVA: 0x149153C
	InitializationOptions get_Options() { }

	// RVA: 0x1491544
	void set_Options(InitializationOptions value) { }

	// RVA: 0x149154C
	IPackageRegistry get_PackageRegistry() { }

	// RVA: 0x1491554
	void set_PackageRegistry(IPackageRegistry value) { }

	// RVA: 0x149155C
	IComponentRegistry get_ComponentRegistry() { }

	// RVA: 0x1491564
	void set_ComponentRegistry(IComponentRegistry value) { }

	// RVA: 0x149156C
	void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x1491574
	void .ctor(IPackageRegistry packageRegistry, ServicesType type, string instanceId) { }

	// RVA: 0x309AF8C
	CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x309AF8C
	void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x309AF8C
	TComponent GetServiceComponent() { }

	// RVA: 0x14917B0
	void LockComponentRegistration() { }

}

// Namespace: 
private struct <<InitializeRegistryAsync>g__InitializePackageAsync|2>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x30
	public IInitializablePackage package; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1491D24
	void MoveNext() { }

	// RVA: 0x1492178
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>4__this; // 0x30
	public IInitializablePackage package; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x14921E4
	void MoveNext() { }

	// RVA: 0x1492708
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public Stopwatch stopwatch; // 0x10
	public System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packagesInitInfos; // 0x18
	public System.Collections.Generic.List<System.Exception> failureReasons; // 0x20
	public CoreRegistryInitializer <>4__this; // 0x28
	public DependencyTree dependencyTree; // 0x30

	// Methods

	// RVA: 0x14919D4
	void .ctor() { }

	// RVA: 0x14919DC
	Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x1491AE4
	IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	// RVA: 0x1491BA0
	Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x1491CA8
	void <InitializeRegistryAsync>g__Fail|3() { }

}

// Namespace: 
private struct <InitializeRegistryAsync>d__3 
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>t__builder; // 0x18
	public CoreRegistryInitializer <>4__this; // 0x30
	private Unity.Services.Core.Internal.CoreRegistryInitializer.<>c__DisplayClass3_0 <>8__1; // 0x38
	private int <i>5__2; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1492774
	void MoveNext() { }

	// RVA: 0x1493040
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer 
{
	// Fields
	private readonly CoreRegistry m_Registry; // 0x10
	private readonly System.Collections.Generic.List<System.Int32> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x149186C
	void .ctor(CoreRegistry registry, System.Collections.Generic.List<System.Int32> sortedPackageTypeHashes) { }

	// RVA: 0x14918BC
	System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync() { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTree 
{
	// Fields
	public readonly System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance; // 0x10
	public readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> ComponentTypeHashToPackageTypeHash; // 0x18
	public readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> PackageTypeHashToComponentTypeHashDependencies; // 0x20
	public readonly System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance; // 0x28

	// Methods

	// RVA: 0x14911A4
	void .ctor() { }

	// RVA: 0x14930C0
	void .ctor(System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<System.Int32,System.Int32> componentToPackage, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> packageToComponentDependencies, System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException 
{
	// Methods

	// RVA: 0x1493140
	void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

	// RVA: 0x14931D4
	string CreateExceptionMessage(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DependencyTreeExtensions 
{
	// Methods

	// RVA: 0x14932B8
	string ToJson(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> order) { }

	// RVA: 0x14948F8
	bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x1494984
	bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x1493CA0
	JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x1494560
	JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x14949FC
	string GetComponentIdentifier(IServiceComponent component) { }

}

// Namespace: 
private enum ExplorationMark 
{
	// Fields
	public int value__; // 0x10
	public const ExplorationMark None = 0;
	public const ExplorationMark Viewed = 1;
	public const ExplorationMark Sorted = 2;
}

// Namespace: Unity.Services.Core.Internal
internal struct DependencyTreeInitializeOrderSorter 
{
	// Fields
	public readonly DependencyTree Tree; // 0x10
	public readonly System.Collections.Generic.ICollection<System.Int32> Target; // 0x18
	private System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory; // 0x20

	// Methods

	// RVA: 0x1494AB8
	void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target) { }

	// RVA: 0x1494AFC
	void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x1495010
	void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x14955CC
	void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x1495254
	void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x14959B8
	void SortTreeThrough(System.Collections.Generic.IEnumerable<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x1495848
	void MarkPackage(int packageTypeHash, ExplorationMark mark) { }

	// RVA: 0x14951F8
	System.Collections.Generic.IReadOnlyCollection<System.Int32> GetPackageTypeHashes() { }

	// RVA: 0x1495D08
	int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x14958C4
	System.Collections.Generic.IEnumerable<System.Int32> GetDependencyTypeHashesFor(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class HashException 
{
	// Fields
	private readonly int <Hash>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x1495EDC
	int get_Hash() { }

	// RVA: 0x1495EE4
	void .ctor(int hash, string message) { }

	// RVA: 0x1495F54
	void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreePackageHashException 
{
	// Methods

	// RVA: 0x1495E6C
	void .ctor(int hash, string message) { }

	// RVA: 0x1495C80
	void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeComponentHashException 
{
	// Methods

	// RVA: 0x1495DFC
	void .ctor(int hash, string message) { }

}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackage 
{
	// Methods

	// RVA: 0x2FE36BC
	Task Initialize(CoreRegistry registry) { }

}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackageV2 
{
	// Methods

	// RVA: 0x2FE36BC
	Task InitializeInstanceAsync(CoreRegistry registry) { }

}

// Namespace: Unity.Services.Core.Internal
public interface IServiceComponent 
{}

// Namespace: Unity.Services.Core.Internal
internal class MissingComponent 
{
	// Fields
	private readonly Type <IntendedType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1495FDC
	Type get_IntendedType() { }

	// RVA: 0x1495FE4
	void .ctor(Type intendedType) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageInitializationInfo 
{
	// Fields
	public Type PackageType; // 0x10
	public Double InitializationTimeInSeconds; // 0x18

	// Methods

	// RVA: 0x1492700
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal interface IPackageRegistry 
{
	// Methods

	// RVA: 0x2FE360C
	DependencyTree get_Tree() { }

	// RVA: 0x309AF8C
	CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x2FE42A4
	void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterProvision(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class LockedPackageRegistry 
{
	// Fields
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1496018
	IPackageRegistry get_Registry() { }

	// RVA: 0x149141C
	void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x1496020
	DependencyTree get_Tree() { }

	// RVA: 0x309AF8C
	CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x2FE42A4
	void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterProvision(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry 
{
	// Fields
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Methods

	// RVA: 0x14960D4
	DependencyTree get_Tree() { }

	// RVA: 0x14960DC
	void set_Tree(DependencyTree value) { }

	// RVA: 0x149132C
	void .ctor(DependencyTree tree) { }

	// RVA: 0x309AF8C
	CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x2FE42A4
	void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x2FE42A4
	void RegisterProvision(int packageTypeHash) { }

	// RVA: 0x14960E4
	void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal interface IServiceRegistry 
{}

// Namespace: Unity.Services.Core.Internal
internal class ServiceRegistry 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,System.Object> <ServiceTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1491724
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreDiagnostics 
{
	// Fields
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <CoreTags>k__BackingField; // 0x10
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14961C4
	CoreDiagnostics get_Instance() { }

	// RVA: 0x1496210
	void set_Instance(CoreDiagnostics value) { }

	// RVA: 0x1496274
	void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	// RVA: 0x149627C
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreMetrics 
{
	// Fields
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1496308
	void set_Instance(CoreMetrics value) { }

	// RVA: 0x149636C
	void .ctor() { }

}

// Namespace: 
private struct <EnableServicesInitializationAsync>d__1 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1496904
	void MoveNext() { }

	// RVA: 0x1496C70
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer 
{
	// Methods

	// RVA: 0x14963F8
	void CreateStaticInstance() { }

	// RVA: 0x149686C
	void EnableServicesInitializationAsync() { }

}

// Namespace: 
private struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass22_0 <>4__this; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1; // 0x38

	// Methods

	// RVA: 0x1497210
	void MoveNext() { }

	// RVA: 0x14974E0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0 
{
	// Fields
	public DependencyTree dependencyTree; // 0x10
	public System.Collections.Generic.List<System.Int32> sortedPackageTypeHashes; // 0x18
	public UnityServicesInternal <>4__this; // 0x20
	public Stopwatch initStopwatch; // 0x28

	// Methods

	// RVA: 0x1496F10
	void .ctor() { }

	// RVA: 0x1496F18
	void <InitializeServicesAsync>g__SortPackages|0() { }

	// RVA: 0x1496F84
	Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

	// RVA: 0x149706C
	void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

	// RVA: 0x14970F4
	void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }

}

// Namespace: 
private struct <EnableInitializationAsync>d__25 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public UnityServicesInternal <>4__this; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x149754C
	void MoveNext() { }

	// RVA: 0x1497854
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeAsync>d__19 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public InitializationOptions options; // 0x30
	public UnityServicesInternal <>4__this; // 0x38
	private System.Runtime.CompilerServices.TaskAwaiter<System.Object> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x14978C0
	void MoveNext() { }

	// RVA: 0x1497CE4
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeServicesAsync>d__22 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public UnityServicesInternal <>4__this; // 0x30
	private Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass22_0 <>8__1; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1497D50
	void MoveNext() { }

	// RVA: 0x1498388
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal class UnityServicesInternal 
{
	// Fields
	private ServicesInitializationState <State>k__BackingField; // 0x10
	internal bool CanInitialize; // 0x14
	private System.Threading.Tasks.TaskCompletionSource<System.Object> m_Initialization; // 0x18
	private readonly CoreRegistry <Registry>k__BackingField; // 0x20
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x28
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1496C7C
	ServicesInitializationState get_State() { }

	// RVA: 0x1496C84
	void set_State(ServicesInitializationState value) { }

	// RVA: 0x1496C8C
	CoreRegistry get_Registry() { }

	// RVA: 0x1496808
	void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x1496C94
	Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x1496D98
	bool HasRequestedInitialization() { }

	// RVA: 0x1496DA8
	Task InitializeServicesAsync() { }

	// RVA: 0x1496B88
	Task EnableInitializationAsync() { }

	// RVA: 0x1496E94
	bool <InitializeAsync>g__HasInitializationFailed|19_0() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DictionaryExtensions 
{
	// Methods

	// RVA: 0x309AF8C
	TDictionary MergeAllowOverride(TDictionary self, System.Collections.Generic.IDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x2FE59C8
	bool ValueEquals(System.Collections.Generic.IDictionary<TKey,TValue> x, System.Collections.Generic.IDictionary<TKey,TValue> y) { }

	// RVA: 0x309AF8C
	bool ValueEquals(System.Collections.Generic.IDictionary<TKey,TValue> x, System.Collections.Generic.IDictionary<TKey,TValue> y, TComparer valueComparer) { }

}

// Namespace: Unity.Services.Core.Internal.Serialization
internal interface IJsonSerializer 
{
	// Methods

	// RVA: 0x309AF8C
	T DeserializeObject(string value) { }

}

// Namespace: Unity.Services.Core.Internal.Serialization
internal class NewtonsoftSerializer 
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x14983F4
	void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x1498438
	void .ctor(JsonSerializer serializer) { }

	// RVA: 0x309AF8C
	T DeserializeObject(string value) { }

}


