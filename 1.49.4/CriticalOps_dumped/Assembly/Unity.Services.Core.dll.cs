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

	// RVA: 0x1571D1C
	public string get_UserId() { }

	// RVA: 0x1571D24
	public void set_UserId(string value) { }

	// RVA: 0x1571D70
	public void .ctor() { }

}

// Namespace: Unity.Services.Core
public class InitializationOptions
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.Object> <Values>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1571D78
	internal System.Collections.Generic.IDictionary<System.String,System.Object> get_Values() { }

	// RVA: 0x1571D80
	public void .ctor() { }

	// RVA: 0x1571E0C
	internal void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> values) { }

	// RVA: 0x1571E40
	internal void .ctor(InitializationOptions source) { }

	// RVA: 0x1571EE0
	public InitializationOptions SetOption(string key, string value) { }

}

// Namespace: Unity.Services.Core
public class ServicesInitializationException
{
	// Methods

	// RVA: 0x1571FA8
	public void .ctor() { }

	// RVA: 0x1572030
	public void .ctor(string message) { }

	// RVA: 0x157209C
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

	// RVA: 0x1572118
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

	// RVA: 0x1572968
	private void MoveNext() { }

	// RVA: 0x157304C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Unity.Services.Core
public static class UnityServices
{
	// Fields
	private static IUnityServices <Instance>k__BackingField; // 0x0
	private static System.Threading.Tasks.TaskCompletionSource<System.Object> <InstantiationCompletion>k__BackingField; // 0x8
	internal static ExternalUserIdProperty ExternalUserIdProperty; // 0x10

	// Methods

	// RVA: 0x1572184
	internal static IUnityServices get_Instance() { }

	// RVA: 0x1572200
	internal static void set_Instance(IUnityServices value) { }

	// RVA: 0x1572274
	internal static System.Threading.Tasks.TaskCompletionSource<System.Object> get_InstantiationCompletion() { }

	// RVA: 0x15722F0
	internal static void set_InstantiationCompletion(System.Threading.Tasks.TaskCompletionSource<System.Object> value) { }

	// RVA: 0x157235C
	public static ServicesInitializationState get_State() { }

	// RVA: 0x15726BC
	public static string get_ExternalUserId() { }

	// RVA: 0x157273C
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x15727FC
	public static Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x15728E8
	private static void .cctor() { }

}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15730B8
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	// RVA: 0x1573114
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x1572650
	public static bool get_IsRunningOnUnityThread() { }

}


