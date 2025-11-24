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

	// RVA: -1
	public abstract void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal interface IDiagnosticsComponentProvider
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IDiagnosticsFactory
{
	// Methods

	// RVA: -1
	public abstract IDiagnostics Create(string packageName) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetrics
{
	// Methods

	// RVA: -1
	public abstract void SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: -1
	public abstract void SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: -1
	public abstract void SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
public interface IMetricsFactory
{
	// Methods

	// RVA: -1
	public abstract IMetrics Create(string packageName) { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
public interface IActionScheduler
{}

// Namespace: Unity.Services.Core.Environments.Internal
public interface IEnvironments
{
	// Methods

	// RVA: -1
	public abstract string get_Current() { }

}

// Namespace: Unity.Services.Core.Device.Internal
public interface IInstallationId
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface ICloudProjectId
{
	// Methods

	// RVA: -1
	public abstract string GetCloudProjectId() { }

}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IExternalUserId
{}

// Namespace: Unity.Services.Core.Configuration.Internal
public interface IProjectConfiguration
{
	// Methods

	// RVA: -1
	public abstract string GetString(string key, string defaultValue) { }

}

// Namespace: Unity.Services.Core.Analytics.Internal
public interface IAnalyticsStandardEventComponent
{}

// Namespace: Unity.Services.Core.Internal
internal abstract class AsyncOperationBase
{
	// Methods

	// RVA: 0x15E9150
	public override bool get_keepWaiting() { }

	// RVA: -1
	public abstract bool get_IsCompleted() { }

}

// Namespace: Unity.Services.Core.Internal
internal class TaskAsyncOperation
{
	// Fields
	internal static TaskScheduler Scheduler; // 0x0
	private Task m_Task; // 0x10

	// Methods

	// RVA: 0x15E9170
	public override bool get_IsCompleted() { }

	// RVA: 0x15E9190
	internal static void SetScheduler() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class CoreLogger
{
	// Methods

	// RVA: 0x15E9214
	public static void LogWarning(object message) { }

	// RVA: 0x15E9370
	public static void LogError(object message) { }

	// RVA: 0x15E94CC
	public static void LogException(Exception exception) { }

}

// Namespace: Unity.Services.Core.Internal
public class CircularDependencyException
{
	// Methods

	// RVA: 0x15E962C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15E9634
	internal System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x15E963C
	public void .ctor() { }

	// RVA: 0x26AD93C
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x26AD93C
	public TComponent GetServiceComponent() { }

	// RVA: 0x15E96C8
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x15E97C0
	public void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal interface IComponentRegistry
{
	// Methods

	// RVA: -1
	public abstract void RegisterServiceComponent(TComponent component) { }

	// RVA: -1
	public abstract TComponent GetServiceComponent() { }

	// RVA: -1
	public abstract void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal class LockedComponentRegistry
{
	// Fields
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15E9854
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x15E985C
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: 0x26AD93C
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x26AD93C
	public TComponent GetServiceComponent() { }

	// RVA: 0x15E9890
	public void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry
{
	// Fields
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15E98E4
	public static CorePackageRegistry get_Instance() { }

	// RVA: 0x15E9930
	internal static void set_Instance(CorePackageRegistry value) { }

	// RVA: 0x15E9994
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x15E999C
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x15E99A4
	internal void .ctor() { }

	// RVA: 0x26AD93C
	public CoreRegistration Register(TPackage package) { }

	// RVA: 0x15E9C0C
	internal void Lock() { }

}

// Namespace: Unity.Services.Core.Internal
public struct CoreRegistration
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x10
	private readonly int m_PackageHash; // 0x18

	// Methods

	// RVA: 0x15E9CFC
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: 0x26AD93C
	public CoreRegistration DependsOn() { }

	// RVA: 0x26AD93C
	public CoreRegistration OptionallyDependsOn() { }

	// RVA: 0x26AD93C
	public CoreRegistration ProvidesComponent() { }

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

	// RVA: 0x15E9D28
	public static CoreRegistry get_Instance() { }

	// RVA: 0x15E9D74
	internal static void set_Instance(CoreRegistry value) { }

	// RVA: 0x15E9DD8
	internal ServicesType get_Type() { }

	// RVA: 0x15E9DE0
	private void set_Type(ServicesType value) { }

	// RVA: 0x15E9DE8
	internal InitializationOptions get_Options() { }

	// RVA: 0x15E9DF0
	internal void set_Options(InitializationOptions value) { }

	// RVA: 0x15E9DF8
	internal IPackageRegistry get_PackageRegistry() { }

	// RVA: 0x15E9E00
	private void set_PackageRegistry(IPackageRegistry value) { }

	// RVA: 0x15E9E08
	internal IComponentRegistry get_ComponentRegistry() { }

	// RVA: 0x15E9E10
	private void set_ComponentRegistry(IComponentRegistry value) { }

	// RVA: 0x15E9E18
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x15E9E20
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type, string instanceId) { }

	// RVA: 0x26AD93C
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x26AD93C
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x26AD93C
	public TComponent GetServiceComponent() { }

	// RVA: 0x15EA05C
	internal void LockComponentRegistration() { }

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

	// RVA: 0x15EA5D0
	private void MoveNext() { }

	// RVA: 0x15EAA24
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x15EAA90
	private void MoveNext() { }

	// RVA: 0x15EAFB4
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x15EA280
	public void .ctor() { }

	// RVA: 0x15EA288
	internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x15EA390
	internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	// RVA: 0x15EA44C
	internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x15EA554
	internal void <InitializeRegistryAsync>g__Fail|3() { }

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

	// RVA: 0x15EB020
	private void MoveNext() { }

	// RVA: 0x15EB8EC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer
{
	// Fields
	private readonly CoreRegistry m_Registry; // 0x10
	private readonly System.Collections.Generic.List<System.Int32> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x15EA118
	public void .ctor(CoreRegistry registry, System.Collections.Generic.List<System.Int32> sortedPackageTypeHashes) { }

	// RVA: 0x15EA168
	public System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync() { }

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

	// RVA: 0x15E9A50
	internal void .ctor() { }

	// RVA: 0x15EB96C
	internal void .ctor(System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<System.Int32,System.Int32> componentToPackage, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> packageToComponentDependencies, System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException
{
	// Methods

	// RVA: 0x15EB9EC
	public void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

	// RVA: 0x15EBA80
	private static string CreateExceptionMessage(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DependencyTreeExtensions
{
	// Methods

	// RVA: 0x15EBB58
	internal static string ToJson(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> order) { }

	// RVA: 0x15ED180
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x15ED20C
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x15EC540
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x15ECDF4
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x15ED284
	private static string GetComponentIdentifier(IServiceComponent component) { }

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

	// RVA: 0x15ED340
	public void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target) { }

	// RVA: 0x15ED384
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x15ED898
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x15EDE4C
	private void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x15EDADC
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x15EE238
	private void SortTreeThrough(System.Collections.Generic.IEnumerable<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x15EE0C8
	private void MarkPackage(int packageTypeHash, ExplorationMark mark) { }

	// RVA: 0x15EDA80
	private System.Collections.Generic.IReadOnlyCollection<System.Int32> GetPackageTypeHashes() { }

	// RVA: 0x15EE588
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x15EE144
	private System.Collections.Generic.IEnumerable<System.Int32> GetDependencyTypeHashesFor(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class HashException
{
	// Fields
	private readonly int <Hash>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x15EE75C
	public int get_Hash() { }

	// RVA: 0x15EE764
	public void .ctor(int hash, string message) { }

	// RVA: 0x15EE7D4
	public void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreePackageHashException
{
	// Methods

	// RVA: 0x15EE6EC
	public void .ctor(int hash, string message) { }

	// RVA: 0x15EE500
	public void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeComponentHashException
{
	// Methods

	// RVA: 0x15EE67C
	public void .ctor(int hash, string message) { }

}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackage
{
	// Methods

	// RVA: -1
	public abstract Task Initialize(CoreRegistry registry) { }

}

// Namespace: Unity.Services.Core.Internal
public interface IInitializablePackageV2
{
	// Methods

	// RVA: -1
	public abstract Task InitializeInstanceAsync(CoreRegistry registry) { }

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

	// RVA: 0x15EE85C
	public Type get_IntendedType() { }

	// RVA: 0x15EE864
	internal void .ctor(Type intendedType) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageInitializationInfo
{
	// Fields
	public Type PackageType; // 0x10
	public Double InitializationTimeInSeconds; // 0x18

	// Methods

	// RVA: 0x15EAFAC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal interface IPackageRegistry
{
	// Methods

	// RVA: -1
	public abstract DependencyTree get_Tree() { }

	// RVA: -1
	public abstract CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: -1
	public abstract void RegisterDependency(int packageTypeHash) { }

	// RVA: -1
	public abstract void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: -1
	public abstract void RegisterProvision(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class LockedPackageRegistry
{
	// Fields
	private readonly IPackageRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15EE898
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x15E9CC8
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x15EE8A0
	public DependencyTree get_Tree() { }

	// RVA: 0x26AD93C
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x3526518
	public void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x3526518
	public void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x3526518
	public void RegisterProvision(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry
{
	// Fields
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15EE954
	public DependencyTree get_Tree() { }

	// RVA: 0x15EE95C
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x15E9BD8
	public void .ctor(DependencyTree tree) { }

	// RVA: 0x26AD93C
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x3526518
	public void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x3526518
	public void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x3526518
	public void RegisterProvision(int packageTypeHash) { }

	// RVA: 0x15EE964
	private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash) { }

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

	// RVA: 0x15E9FD0
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal enum ServicesType
{
	// Fields
	public int value__; // 0x10
	public const ServicesType Default = 0;
	public const ServicesType Instance = 1;
}

// Namespace: Unity.Services.Core.Internal
internal class CoreDiagnostics
{
	// Fields
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <CoreTags>k__BackingField; // 0x10
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15EEA44
	public static CoreDiagnostics get_Instance() { }

	// RVA: 0x15EEA90
	internal static void set_Instance(CoreDiagnostics value) { }

	// RVA: 0x15EEAF4
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	// RVA: 0x15EEAFC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreMetrics
{
	// Fields
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15EEB88
	public static CoreMetrics get_Instance() { }

	// RVA: 0x15EEBD4
	internal static void set_Instance(CoreMetrics value) { }

	// RVA: 0x15EEC38
	public void .ctor() { }

}

// Namespace: 
private struct <EnableServicesInitializationAsync>d__1
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x15EF3F8
	private void MoveNext() { }

	// RVA: 0x15EF764
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer
{
	// Methods

	// RVA: 0x15EECC4
	private static void CreateStaticInstance() { }

	// RVA: 0x15EF1BC
	private static void EnableServicesInitializationAsync() { }

	// RVA: 0x15EF254
	internal static IUnityServices CreateInstance(string servicesId) { }

}

// Namespace: 
private struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0 <>4__this; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1; // 0x38

	// Methods

	// RVA: 0x15EFEC4
	private void MoveNext() { }

	// RVA: 0x15F0194
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public DependencyTree dependencyTree; // 0x10
	public System.Collections.Generic.List<System.Int32> sortedPackageTypeHashes; // 0x18
	public UnityServicesInternal <>4__this; // 0x20
	public Stopwatch initStopwatch; // 0x28

	// Methods

	// RVA: 0x15EFBC4
	public void .ctor() { }

	// RVA: 0x15EFBCC
	internal void <InitializeServicesAsync>g__SortPackages|0() { }

	// RVA: 0x15EFC38
	internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

	// RVA: 0x15EFD20
	internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

	// RVA: 0x15EFDA8
	internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }

}

// Namespace: 
private struct <EnableInitializationAsync>d__36
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public UnityServicesInternal <>4__this; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x15F0200
	private void MoveNext() { }

	// RVA: 0x15F0508
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeAsync>d__27
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public InitializationOptions options; // 0x30
	public UnityServicesInternal <>4__this; // 0x38
	private System.Runtime.CompilerServices.TaskAwaiter<System.Object> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x15F0574
	private void MoveNext() { }

	// RVA: 0x15F0A74
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitializeServicesAsync>d__33
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public UnityServicesInternal <>4__this; // 0x30
	private Unity.Services.Core.Internal.UnityServicesInternal.<>c__DisplayClass33_0 <>8__1; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x15F0AE0
	private void MoveNext() { }

	// RVA: 0x15F1118
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal class UnityServicesInternal
{
	// Fields
	private Action Initialized; // 0x10
	private System.Action<System.Exception> InitializeFailed; // 0x18
	private ServicesInitializationState <State>k__BackingField; // 0x20
	internal bool CanInitialize; // 0x24
	private System.Threading.Tasks.TaskCompletionSource<System.Object> m_Initialization; // 0x28
	private readonly CoreRegistry <Registry>k__BackingField; // 0x30
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x38
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x40

	// Methods

	// RVA: 0x15EF770
	public ServicesInitializationState get_State() { }

	// RVA: 0x15EF778
	private void set_State(ServicesInitializationState value) { }

	// RVA: 0x15EF780
	internal CoreRegistry get_Registry() { }

	// RVA: 0x15EF158
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x15EF788
	public Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x15EF88C
	private void TriggerInitializeSuccess() { }

	// RVA: 0x15EF96C
	private void TriggerInitializeFailed(Exception initException) { }

	// RVA: 0x15EFA4C
	private bool HasRequestedInitialization() { }

	// RVA: 0x15EFA5C
	private Task InitializeServicesAsync() { }

	// RVA: 0x15EF3EC
	internal void EnableInitialization() { }

	// RVA: 0x15EF67C
	internal Task EnableInitializationAsync() { }

	// RVA: 0x15EFB48
	private bool <InitializeAsync>g__HasInitializationFailed|27_0() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DictionaryExtensions
{
	// Methods

	// RVA: 0x26AD93C
	public static TDictionary MergeAllowOverride(TDictionary self, System.Collections.Generic.IDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x3527C54
	public static bool ValueEquals(System.Collections.Generic.IDictionary<TKey,TValue> x, System.Collections.Generic.IDictionary<TKey,TValue> y) { }

	// RVA: 0x26AD93C
	public static bool ValueEquals(System.Collections.Generic.IDictionary<TKey,TValue> x, System.Collections.Generic.IDictionary<TKey,TValue> y, TComparer valueComparer) { }

}

// Namespace: Unity.Services.Core.Internal.Serialization
internal interface IJsonSerializer
{
	// Methods

	// RVA: -1
	public abstract T DeserializeObject(string value) { }

}

// Namespace: Unity.Services.Core.Internal.Serialization
internal class NewtonsoftSerializer
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x15F1184
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x15F11C8
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: 0x26AD93C
	public T DeserializeObject(string value) { }

}


