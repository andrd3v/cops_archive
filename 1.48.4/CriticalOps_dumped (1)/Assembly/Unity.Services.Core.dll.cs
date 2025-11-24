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

	// RVA: 0x148E9A0
	string get_UserId() { }

	// RVA: 0x148E9A8
	void set_UserId(string value) { }

	// RVA: 0x148E9F4
	void .ctor() { }

}

// Namespace: Unity.Services.Core
public class InitializationOptions 
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.Object> <Values>k__BackingField; // 0x10

	// Methods

	// RVA: 0x148E9FC
	System.Collections.Generic.IDictionary<System.String,System.Object> get_Values() { }

	// RVA: 0x148EA04
	void .ctor() { }

	// RVA: 0x148EA90
	void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> values) { }

	// RVA: 0x148EAC4
	void .ctor(InitializationOptions source) { }

	// RVA: 0x148EB64
	InitializationOptions SetOption(string key, string value) { }

}

// Namespace: Unity.Services.Core
public class ServicesInitializationException 
{
	// Methods

	// RVA: 0x148EC2C
	void .ctor() { }

	// RVA: 0x148ECB4
	void .ctor(string message) { }

	// RVA: 0x148ED20
	void .ctor(string message, Exception innerException) { }

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

	// RVA: 0x148ED9C
	void .ctor(string message) { }

}

// Namespace: Unity.Services.Core
public interface IUnityServices 
{
	// Methods

	// RVA: 0x2FE32D4
	ServicesInitializationState get_State() { }

	// RVA: 0x2FE36BC
	Task InitializeAsync(InitializationOptions options) { }

}

// Namespace: Unity.Services.Core
internal enum ServicesType 
{
	// Fields
	public int value__; // 0x10
	public const ServicesType Default = 0;
	public const ServicesType Instance = 1;
}

// Namespace: 
private struct <InitializeAsync>d__15 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public InitializationOptions options; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.Object> <>u__1; // 0x38
	private TaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x148F5EC
	void MoveNext() { }

	// RVA: 0x148FCD0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core
public static class UnityServices 
{
	// Fields
	private static IUnityServices <Instance>k__BackingField; // 0x0
	private static System.Threading.Tasks.TaskCompletionSource<System.Object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10

	// Methods

	// RVA: 0x148EE08
	IUnityServices get_Instance() { }

	// RVA: 0x148EE84
	void set_Instance(IUnityServices value) { }

	// RVA: 0x148EEF8
	System.Threading.Tasks.TaskCompletionSource<System.Object> get_InstantiationCompletion() { }

	// RVA: 0x148EF74
	void set_InstantiationCompletion(System.Threading.Tasks.TaskCompletionSource<System.Object> value) { }

	// RVA: 0x148EFE0
	ServicesInitializationState get_State() { }

	// RVA: 0x148F340
	string get_ExternalUserId() { }

	// RVA: 0x148F3C0
	void set_ExternalUserId(string value) { }

	// RVA: 0x148F480
	Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x148F56C
	void .cctor() { }

}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils 
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Methods

	// RVA: 0x148FD3C
	void set_UnityThreadScheduler(TaskScheduler value) { }

	// RVA: 0x148FD98
	void CaptureUnityThreadInfo() { }

	// RVA: 0x148F2D4
	bool get_IsRunningOnUnityThread() { }

}


