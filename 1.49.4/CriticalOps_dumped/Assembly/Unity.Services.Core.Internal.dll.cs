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

	// RVA: 0x1573C20
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

	// RVA: 0x1573C40
	public override bool get_IsCompleted() { }

	// RVA: 0x1573C60
	internal static void SetScheduler() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class CoreLogger
{
	// Methods

	// RVA: 0x1573CE4
	public static void LogWarning(object message) { }

	// RVA: 0x1573E40
	public static void LogError(object message) { }

	// RVA: 0x1573F9C
	public static void LogException(Exception exception) { }

}

// Namespace: Unity.Services.Core.Internal
public class CircularDependencyException
{
	// Methods

	// RVA: 0x15740FC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1574104
	internal System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x157410C
	public void .ctor() { }

	// RVA: 0x315B3A8
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x315B3A8
	public TComponent GetServiceComponent() { }

	// RVA: 0x1574198
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x1574290
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

	// RVA: 0x1574324
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x157432C
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: 0x315B3A8
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x315B3A8
	public TComponent GetServiceComponent() { }

	// RVA: 0x1574360
	public void ResetProvidedComponents(System.Collections.Generic.IDictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry
{
	// Fields
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15743B4
	public static CorePackageRegistry get_Instance() { }

	// RVA: 0x1574400
	internal static void set_Instance(CorePackageRegistry value) { }

	// RVA: 0x1574464
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x157446C
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x1574474
	internal void .ctor() { }

	// RVA: 0x315B3A8
	public CoreRegistration Register(TPackage package) { }

	// RVA: 0x15746DC
	internal void Lock() { }

}

// Namespace: Unity.Services.Core.Internal
public struct CoreRegistration
{
	// Fields
	private readonly IPackageRegistry m_Registry; // 0x10
	private readonly int m_PackageHash; // 0x18

	// Methods

	// RVA: 0x15747CC
	internal void .ctor(IPackageRegistry registry, int packageHash) { }

	// RVA: 0x315B3A8
	public CoreRegistration DependsOn() { }

	// RVA: 0x315B3A8
	public CoreRegistration OptionallyDependsOn() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x15747F8
	public static CoreRegistry get_Instance() { }

	// RVA: 0x1574844
	internal static void set_Instance(CoreRegistry value) { }

	// RVA: 0x15748A8
	internal ServicesType get_Type() { }

	// RVA: 0x15748B0
	private void set_Type(ServicesType value) { }

	// RVA: 0x15748B8
	internal InitializationOptions get_Options() { }

	// RVA: 0x15748C0
	internal void set_Options(InitializationOptions value) { }

	// RVA: 0x15748C8
	internal IPackageRegistry get_PackageRegistry() { }

	// RVA: 0x15748D0
	private void set_PackageRegistry(IPackageRegistry value) { }

	// RVA: 0x15748D8
	internal IComponentRegistry get_ComponentRegistry() { }

	// RVA: 0x15748E0
	private void set_ComponentRegistry(IComponentRegistry value) { }

	// RVA: 0x15748E8
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x15748F0
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type, string instanceId) { }

	// RVA: 0x315B3A8
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x315B3A8
	public void RegisterServiceComponent(TComponent component) { }

	// RVA: 0x315B3A8
	public TComponent GetServiceComponent() { }

	// RVA: 0x1574B2C
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

	// RVA: 0x15750A0
	private void MoveNext() { }

	// RVA: 0x15754F4
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

	// RVA: 0x1575560
	private void MoveNext() { }

	// RVA: 0x1575A84
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

	// RVA: 0x1574D50
	public void .ctor() { }

	// RVA: 0x1574D58
	internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x1574E60
	internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	// RVA: 0x1574F1C
	internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x1575024
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

	// RVA: 0x1575AF0
	private void MoveNext() { }

	// RVA: 0x15763BC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreRegistryInitializer
{
	// Fields
	private readonly CoreRegistry m_Registry; // 0x10
	private readonly System.Collections.Generic.List<System.Int32> m_SortedPackageTypeHashes; // 0x18

	// Methods

	// RVA: 0x1574BE8
	public void .ctor(CoreRegistry registry, System.Collections.Generic.List<System.Int32> sortedPackageTypeHashes) { }

	// RVA: 0x1574C38
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

	// RVA: 0x1574520
	internal void .ctor() { }

	// RVA: 0x157643C
	internal void .ctor(System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<System.Int32,System.Int32> componentToPackage, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> packageToComponentDependencies, System.Collections.Generic.Dictionary<System.Int32,Unity.Services.Core.Internal.IServiceComponent> componentToInstance) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeSortFailedException
{
	// Methods

	// RVA: 0x15764BC
	public void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

	// RVA: 0x1576550
	private static string CreateExceptionMessage(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DependencyTreeExtensions
{
	// Methods

	// RVA: 0x1576634
	internal static string ToJson(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> order) { }

	// RVA: 0x1577C74
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x1577D00
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x157701C
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x15778DC
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x1577D78
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

	// RVA: 0x1577E34
	public void .ctor(DependencyTree tree, System.Collections.Generic.ICollection<System.Int32> target) { }

	// RVA: 0x1577E78
	public void SortRegisteredPackagesIntoTarget() { }

	// RVA: 0x157838C
	private void RemoveUnprovidedOptionalDependenciesFromTree() { }

	// RVA: 0x1578948
	private void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x15785D0
	private void SortTreeThrough(int packageTypeHash) { }

	// RVA: 0x1578D34
	private void SortTreeThrough(System.Collections.Generic.IEnumerable<System.Int32> dependencyTypeHashes) { }

	// RVA: 0x1578BC4
	private void MarkPackage(int packageTypeHash, ExplorationMark mark) { }

	// RVA: 0x1578574
	private System.Collections.Generic.IReadOnlyCollection<System.Int32> GetPackageTypeHashes() { }

	// RVA: 0x1579084
	private int GetPackageTypeHashFor(int componentTypeHash) { }

	// RVA: 0x1578C40
	private System.Collections.Generic.IEnumerable<System.Int32> GetDependencyTypeHashesFor(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class HashException
{
	// Fields
	private readonly int <Hash>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x1579258
	public int get_Hash() { }

	// RVA: 0x1579260
	public void .ctor(int hash, string message) { }

	// RVA: 0x15792D0
	public void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreePackageHashException
{
	// Methods

	// RVA: 0x15791E8
	public void .ctor(int hash, string message) { }

	// RVA: 0x1578FFC
	public void .ctor(int hash, string message, Exception inner) { }

}

// Namespace: Unity.Services.Core.Internal
internal class DependencyTreeComponentHashException
{
	// Methods

	// RVA: 0x1579178
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

	// RVA: 0x1579358
	public Type get_IntendedType() { }

	// RVA: 0x1579360
	internal void .ctor(Type intendedType) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageInitializationInfo
{
	// Fields
	public Type PackageType; // 0x10
	public Double InitializationTimeInSeconds; // 0x18

	// Methods

	// RVA: 0x1575A7C
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

	// RVA: 0x1579394
	internal IPackageRegistry get_Registry() { }

	// RVA: 0x1574798
	public void .ctor(IPackageRegistry registryToLock) { }

	// RVA: 0x157939C
	public DependencyTree get_Tree() { }

	// RVA: 0x315B3A8
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x30A24F0
	public void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x30A24F0
	public void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x30A24F0
	public void RegisterProvision(int packageTypeHash) { }

}

// Namespace: Unity.Services.Core.Internal
internal class PackageRegistry
{
	// Fields
	private DependencyTree <Tree>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1579450
	public DependencyTree get_Tree() { }

	// RVA: 0x1579458
	public void set_Tree(DependencyTree value) { }

	// RVA: 0x15746A8
	public void .ctor(DependencyTree tree) { }

	// RVA: 0x315B3A8
	public CoreRegistration RegisterPackage(TPackage package) { }

	// RVA: 0x30A24F0
	public void RegisterDependency(int packageTypeHash) { }

	// RVA: 0x30A24F0
	public void RegisterOptionalDependency(int packageTypeHash) { }

	// RVA: 0x30A24F0
	public void RegisterProvision(int packageTypeHash) { }

	// RVA: 0x1579460
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

	// RVA: 0x1574AA0
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreDiagnostics
{
	// Fields
	private static CoreDiagnostics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <CoreTags>k__BackingField; // 0x10
	private IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1579540
	public static CoreDiagnostics get_Instance() { }

	// RVA: 0x157958C
	internal static void set_Instance(CoreDiagnostics value) { }

	// RVA: 0x15795F0
	internal void set_DiagnosticsComponentProvider(IDiagnosticsComponentProvider value) { }

	// RVA: 0x15795F8
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Internal
internal class CoreMetrics
{
	// Fields
	private static CoreMetrics <Instance>k__BackingField; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1579684
	internal static void set_Instance(CoreMetrics value) { }

	// RVA: 0x15796E8
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

	// RVA: 0x1579C80
	private void MoveNext() { }

	// RVA: 0x1579FEC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer
{
	// Methods

	// RVA: 0x1579774
	private static void CreateStaticInstance() { }

	// RVA: 0x1579BE8
	private static void EnableServicesInitializationAsync() { }

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

	// RVA: 0x157A58C
	private void MoveNext() { }

	// RVA: 0x157A85C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x157A28C
	public void .ctor() { }

	// RVA: 0x157A294
	internal void <InitializeServicesAsync>g__SortPackages|0() { }

	// RVA: 0x157A300
	internal Task <InitializeServicesAsync>g__InitializePackagesAsync|1() { }

	// RVA: 0x157A3E8
	internal void <InitializeServicesAsync>g__FailServicesInitialization|2(Exception reason) { }

	// RVA: 0x157A470
	internal void <InitializeServicesAsync>g__SucceedServicesInitialization|3() { }

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

	// RVA: 0x157A8C8
	private void MoveNext() { }

	// RVA: 0x157ABD0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x157AC3C
	private void MoveNext() { }

	// RVA: 0x157B060
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x157B0CC
	private void MoveNext() { }

	// RVA: 0x157B704
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1579FF8
	public ServicesInitializationState get_State() { }

	// RVA: 0x157A000
	private void set_State(ServicesInitializationState value) { }

	// RVA: 0x157A008
	internal CoreRegistry get_Registry() { }

	// RVA: 0x1579B84
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x157A010
	public Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x157A114
	private bool HasRequestedInitialization() { }

	// RVA: 0x157A124
	private Task InitializeServicesAsync() { }

	// RVA: 0x1579F04
	internal Task EnableInitializationAsync() { }

	// RVA: 0x157A210
	private bool <InitializeAsync>g__HasInitializationFailed|19_0() { }

}

// Namespace: Unity.Services.Core.Internal
internal static class DictionaryExtensions
{
	// Methods

	// RVA: 0x315B3A8
	public static TDictionary MergeAllowOverride(TDictionary self, System.Collections.Generic.IDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30A3C14
	public static bool ValueEquals(System.Collections.Generic.IDictionary<TKey,TValue> x, System.Collections.Generic.IDictionary<TKey,TValue> y) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x157B770
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x157B7B4
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: 0x315B3A8
	public T DeserializeObject(string value) { }

}


