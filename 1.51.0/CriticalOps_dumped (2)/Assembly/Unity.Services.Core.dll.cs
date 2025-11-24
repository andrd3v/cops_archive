// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core
internal class ExternalUserIdProperty
{
	// Fields
	private System.Action<System.String> UserIdChanged; // 0x10
	private string m_UserId; // 0x18

	// Methods

	// RVA: 0x15E6F70
	public string get_UserId() { }

	// RVA: 0x15E6F78
	public void set_UserId(string value) { }

	// RVA: 0x15E6FC4
	public void .ctor() { }

}

// Namespace: Unity.Services.Core
public class InitializationOptions
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.Object> <Values>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15E6FCC
	internal System.Collections.Generic.IDictionary<System.String,System.Object> get_Values() { }

	// RVA: 0x15E6FD4
	public void .ctor() { }

	// RVA: 0x15E7060
	internal void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> values) { }

	// RVA: 0x15E7094
	internal void .ctor(InitializationOptions source) { }

	// RVA: 0x15E7134
	public InitializationOptions SetOption(string key, string value) { }

}

// Namespace: Unity.Services.Core
public class ServicesInitializationException
{
	// Methods

	// RVA: 0x15E71FC
	public void .ctor() { }

	// RVA: 0x15E7284
	public void .ctor(string message) { }

	// RVA: 0x15E72F0
	public void .ctor(string message, Exception innerException) { }

}

// Namespace: Unity.Services.Core
public enum ServicesInitializationState
{
	// Fields
	public int value__; // 0x10
	public const ServicesInitializationState Uninitialized = 0;
	public const ServicesInitializationState Initializing = 1;
	public const ServicesInitializationState Initialized = 2;
}

// Namespace: Unity.Services.Core
internal class UnityProjectNotLinkedException
{
	// Methods

	// RVA: 0x15E736C
	public void .ctor(string message) { }

}

// Namespace: Unity.Services.Core
public interface IUnityServices
{
	// Methods

	// RVA: -1
	public abstract ServicesInitializationState get_State() { }

	// RVA: -1
	public abstract Task InitializeAsync(InitializationOptions options) { }

}

// Namespace: 
private struct <InitializeAsync>d__26
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public InitializationOptions options; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.Object> <>u__1; // 0x38
	private TaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x15E7D6C
	private void MoveNext() { }

	// RVA: 0x15E8450
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core
public static class UnityServices
{
	// Fields
	private static IUnityServices <Instance>k__BackingField; // 0x0
	private static System.Threading.Tasks.TaskCompletionSource<System.Object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10
	private static readonly System.Collections.Generic.Dictionary<System.String,Unity.Services.Core.IUnityServices> <s_Services>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15E73D8
	public static IUnityServices get_Instance() { }

	// RVA: 0x15E7454
	public static void set_Instance(IUnityServices value) { }

	// RVA: 0x15E74C8
	internal static System.Threading.Tasks.TaskCompletionSource<System.Object> get_InstantiationCompletion() { }

	// RVA: 0x15E7544
	internal static void set_InstantiationCompletion(System.Threading.Tasks.TaskCompletionSource<System.Object> value) { }

	// RVA: 0x15E75B0
	private static System.Collections.Generic.Dictionary<System.String,Unity.Services.Core.IUnityServices> get_s_Services() { }

	// RVA: 0x15E762C
	public static ServicesInitializationState get_State() { }

	// RVA: 0x15E798C
	public static string get_ExternalUserId() { }

	// RVA: 0x15E7A0C
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x15E7ACC
	public static Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x15E7BB8
	internal static void ClearServices() { }

	// RVA: 0x15E7C94
	private static void .cctor() { }

}

// Namespace: 
internal sealed class CreationDelegate
{
	// Methods

	// RVA: 0x15E8520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15E85D4
	public virtual IUnityServices Invoke(string servicesId) { }

}

// Namespace: Unity.Services.Core
internal static class UnityServicesBuilder
{
	// Fields
	private static CreationDelegate <InstanceCreationDelegate>k__BackingField; // 0x0

	// Methods

	// RVA: 0x15E84BC
	internal static void set_InstanceCreationDelegate(CreationDelegate value) { }

}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15E85E8
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	// RVA: 0x15E8644
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x15E7920
	public static bool get_IsRunningOnUnityThread() { }

}


