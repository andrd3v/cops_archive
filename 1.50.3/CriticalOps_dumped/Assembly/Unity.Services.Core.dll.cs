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

	// RVA: 0x15A4214
	public string get_UserId() { }

	// RVA: 0x15A421C
	public void set_UserId(string value) { }

	// RVA: 0x15A4268
	public void .ctor() { }

}

// Namespace: Unity.Services.Core
public class InitializationOptions
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.Object> <Values>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15A4270
	internal System.Collections.Generic.IDictionary<System.String,System.Object> get_Values() { }

	// RVA: 0x15A4278
	public void .ctor() { }

	// RVA: 0x15A4304
	internal void .ctor(System.Collections.Generic.IDictionary<System.String,System.Object> values) { }

	// RVA: 0x15A4338
	internal void .ctor(InitializationOptions source) { }

	// RVA: 0x15A43D8
	public InitializationOptions SetOption(string key, string value) { }

}

// Namespace: Unity.Services.Core
public class ServicesInitializationException
{
	// Methods

	// RVA: 0x15A44A0
	public void .ctor() { }

	// RVA: 0x15A4528
	public void .ctor(string message) { }

	// RVA: 0x15A4594
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

	// RVA: 0x15A4610
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

	// RVA: 0x15A4E60
	private void MoveNext() { }

	// RVA: 0x15A5544
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

	// RVA: 0x15A467C
	internal static IUnityServices get_Instance() { }

	// RVA: 0x15A46F8
	internal static void set_Instance(IUnityServices value) { }

	// RVA: 0x15A476C
	internal static System.Threading.Tasks.TaskCompletionSource<System.Object> get_InstantiationCompletion() { }

	// RVA: 0x15A47E8
	internal static void set_InstantiationCompletion(System.Threading.Tasks.TaskCompletionSource<System.Object> value) { }

	// RVA: 0x15A4854
	public static ServicesInitializationState get_State() { }

	// RVA: 0x15A4BB4
	public static string get_ExternalUserId() { }

	// RVA: 0x15A4C34
	public static void set_ExternalUserId(string value) { }

	// RVA: 0x15A4CF4
	public static Task InitializeAsync(InitializationOptions options) { }

	// RVA: 0x15A4DE0
	private static void .cctor() { }

}

// Namespace: Unity.Services.Core
internal static class UnityThreadUtils
{
	// Fields
	private static int s_UnityThreadId; // 0x0
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15A55B0
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

	// RVA: 0x15A560C
	private static void CaptureUnityThreadInfo() { }

	// RVA: 0x15A4B48
	public static bool get_IsRunningOnUnityThread() { }

}


