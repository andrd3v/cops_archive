// Namespace: 
internal class <Module> 
{}

// Namespace: Firebase
internal class ExceptionAggregator 
{
	// Fields
	private static System.Collections.Generic.List<System.Exception> threadLocalExceptions; // 0xFFFFFFFF

	// Methods

	// RVA: 0x78CA50
	System.Collections.Generic.List<System.Exception> get_Exceptions() { }

	// RVA: 0x78CB2C
	Exception GetAndClearPendingExceptions() { }

	// RVA: 0x78CC98
	void ThrowAndClearPendingExceptions() { }

	// RVA: 0x78CCD8
	Exception LogException(Exception exception) { }

	// RVA: 0x78D32C
	void Wrap(Action action) { }

	// RVA: 0x309AF8C
	T Wrap(System.Func<T> func, T errorValue) { }

}

// Namespace: 
private class CallbackStorage<T0> 
{
	// Fields
	private TResult <Result>k__BackingField; // 0x0
	private Exception <Exception>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	TResult get_Result() { }

	// RVA: 0x309AF8C
	void set_Result(TResult value) { }

	// RVA: 0x2FE360C
	Exception get_Exception() { }

	// RVA: 0x2FE4574
	void set_Exception(Exception value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0> 
{
	// Fields
	public Firebase.Dispatcher.CallbackStorage<TResult> result; // 0x0
	public System.Func<TResult> callback; // 0x0
	public EventWaitHandle waitHandle; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void <Run>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0> 
{
	// Fields
	public System.Threading.Tasks.TaskCompletionSource<TResult> tcs; // 0x0
	public System.Func<TResult> callback; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void <RunAsync>b__0() { }

}

// Namespace: Firebase
internal class Dispatcher 
{
	// Fields
	private int ownerThreadId; // 0x10
	private System.Collections.Generic.Queue<System.Action> queue; // 0x18

	// Methods

	// RVA: 0x78D40C
	void .ctor() { }

	// RVA: 0x309AF8C
	TResult Run(System.Func<TResult> callback) { }

	// RVA: 0x2FE36BC
	System.Threading.Tasks.Task<TResult> RunAsync(System.Func<TResult> callback) { }

	// RVA: 0x2FE7084
	System.Threading.Tasks.Task<TResult> RunAsyncNow(System.Func<TResult> callback) { }

	// RVA: 0x78D4B8
	bool ManagesThisThread() { }

	// RVA: 0x78D4F8
	void PollJobs() { }

}

// Namespace: Firebase.Unity
internal class UnityLoggingService 
{
	// Fields
	private static UnityLoggingService _instance; // 0x0

	// Methods

	// RVA: 0x78D67C
	UnityLoggingService get_Instance() { }

	// RVA: 0x78D6F8
	void .ctor() { }

	// RVA: 0x78D700
	void .cctor() { }

}

// Namespace: Firebase.Unity
internal class UnityPlatformServices 
{
	// Methods

	// RVA: 0x78D76C
	void SetupServices() { }

}

// Namespace: 
private sealed class <Start>d__3 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SynchronizationContextBehavoir <>4__this; // 0x20
	private System.Tuple<System.Threading.SendOrPostCallback,System.Object> <entry>5__1; // 0x28
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> <>s__2; // 0x30
	private bool <>s__3; // 0x38
	private Exception <e>5__4; // 0x40

	// Methods

	// RVA: 0x78E3C4
	void .ctor(int <>1__state) { }

	// RVA: 0x78E3F8
	void System.IDisposable.Dispose() { }

	// RVA: 0x78E3FC
	bool MoveNext() { }

	// RVA: 0x78E94C
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x78E954
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x78E994
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class SynchronizationContextBehavoir 
{
	// Fields
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> callbackQueue; // 0x20

	// Methods

	// RVA: 0x78DB64
	System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> get_CallbackQueue() { }

	// RVA: 0x78E34C
	IEnumerator Start() { }

	// RVA: 0x78E3F0
	void .ctor() { }

}

// Namespace: 
private sealed class <SignaledCoroutine>d__13 
{}

// Namespace: 
private sealed class <>c__DisplayClass14_0 
{
	// Methods

	// RVA: 0x78E99C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_1 
{
	// Methods

	// RVA: 0x78E9A4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0 
{
	// Fields
	public SendOrPostCallback d; // 0x10

	// Methods

	// RVA: 0x78E28C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_1 
{
	// Fields
	public ManualResetEvent newSignal; // 0x10
	public Firebase.Unity.UnitySynchronizationContext.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x78E294
	void .ctor() { }

	// RVA: 0x78E9AC
	void <Send>b__0(object x) { }

}

// Namespace: Firebase.Unity
internal class UnitySynchronizationContext 
{
	// Fields
	private static UnitySynchronizationContext _instance; // 0x0
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> queue; // 0x18
	private SynchronizationContextBehavoir behavior; // 0x20
	private int mainThreadId; // 0x28
	private static System.Collections.Generic.Dictionary<System.Int32,System.Threading.ManualResetEvent> signalDictionary; // 0x8

	// Methods

	// RVA: 0x78DA2C
	void .ctor(GameObject gameObject) { }

	// RVA: 0x78DC00
	void Create(GameObject gameObject) { }

	// RVA: 0x78DCCC
	void Destroy() { }

	// RVA: 0x78DD34
	ManualResetEvent GetThreadEvent() { }

	// RVA: 0x78DF90
	void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x78E0F0
	void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x78E29C
	void .cctor() { }

}

// Namespace: Firebase.Platform
internal interface IAppConfigExtensions 
{}

// Namespace: Firebase.Platform
internal interface IClockService 
{}

// Namespace: Firebase.Platform
internal interface ILoggingService 
{}

// Namespace: Firebase.Platform
internal class DebugLogger 
{
	// Fields
	private static DebugLogger _instance; // 0x0

	// Methods

	// RVA: 0x78EAC4
	DebugLogger get_Instance() { }

	// RVA: 0x78EB40
	void .ctor() { }

	// RVA: 0x78EB48
	void .cctor() { }

}

// Namespace: Firebase.Platform
internal static class Services 
{
	// Fields
	private static IAppConfigExtensions <AppConfig>k__BackingField; // 0x0
	private static IClockService <Clock>k__BackingField; // 0x8
	private static ILoggingService <Logging>k__BackingField; // 0x10

	// Methods

	// RVA: 0x78EBB4
	void .cctor() { }

	// RVA: 0x78EED0
	void set_AppConfig(IAppConfigExtensions value) { }

	// RVA: 0x78EF44
	void set_Clock(IClockService value) { }

	// RVA: 0x78EFB0
	void set_Logging(ILoggingService value) { }

}

// Namespace: Firebase.Platform
internal enum PlatformLogLevel 
{
	// Fields
	public int value__; // 0x10
	public const PlatformLogLevel Verbose = 0;
	public const PlatformLogLevel Debug = 1;
	public const PlatformLogLevel Info = 2;
	public const PlatformLogLevel Warning = 3;
	public const PlatformLogLevel Error = 4;
	public const PlatformLogLevel Assert = 5;
}

// Namespace: Firebase.Platform
internal interface IFirebaseAppUtils 
{
	// Methods

	// RVA: 0x2FE4574
	void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x2FE41A8
	void PollCallbacks() { }

	// RVA: 0x2FE32D4
	PlatformLogLevel GetLogLevel() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtilsStub 
{
	// Fields
	private static FirebaseAppUtilsStub _instance; // 0x0

	// Methods

	// RVA: 0x78F01C
	FirebaseAppUtilsStub get_Instance() { }

	// RVA: 0x78F098
	void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x78F0BC
	void PollCallbacks() { }

	// RVA: 0x78F0C0
	PlatformLogLevel GetLogLevel() { }

	// RVA: 0x78F0C8
	void .ctor() { }

	// RVA: 0x78F0D0
	void .cctor() { }

}

// Namespace: Firebase.Platform
internal class MainThreadProperty<T0> 
{
	// Fields
	private System.Func<T> getPropertyDelegate; // 0x0
	private int lastGetPropertyTickCount; // 0x0
	private T cachedValue; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Func<T> getPropertyDelegate) { }

	// RVA: 0x309AF8C
	T get_Value() { }

	// RVA: 0x309AF8C
	T <get_Value>b__5_0() { }

}

// Namespace: 
internal class ApplicationFocusChangedEventArgs 
{
	// Fields
	private bool <HasFocus>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7907D0
	void set_HasFocus(bool value) { }

	// RVA: 0x790604
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Firebase.Platform.FirebaseHandler.<>c <>9; // 0x0
	public static System.Func<System.Boolean> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x7907D8
	void .cctor() { }

	// RVA: 0x790844
	void .ctor() { }

	// RVA: 0x79084C
	bool <StopMonoBehaviour>b__19_0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0 
{
	// Fields
	public IFirebaseAppUtils appUtils; // 0x10

	// Methods

	// RVA: 0x790204
	void .ctor() { }

	// RVA: 0x790A14
	void <CreatePartialOnMainThread>b__0() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseHandler 
{
	// Fields
	private static FirebaseMonoBehaviour firebaseMonoBehaviour; // 0x0
	private static IFirebaseAppUtils <AppUtils>k__BackingField; // 0x8
	private static int tickCount; // 0x10
	private static Dispatcher <ThreadDispatcher>k__BackingField; // 0x18
	private bool <IsPlayMode>k__BackingField; // 0x10
	private static FirebaseHandler firebaseHandler; // 0x20
	private System.EventHandler<System.EventArgs> Updated; // 0x18
	internal Action UpdatedEventWrapper; // 0x20
	private System.EventHandler<Firebase.Platform.FirebaseHandler.ApplicationFocusChangedEventArgs> ApplicationFocusChanged; // 0x28

	// Methods

	// RVA: 0x78F13C
	IFirebaseAppUtils get_AppUtils() { }

	// RVA: 0x78F1B8
	void set_AppUtils(IFirebaseAppUtils value) { }

	// RVA: 0x78F224
	int get_TickCount() { }

	// RVA: 0x78F2A0
	Dispatcher get_ThreadDispatcher() { }

	// RVA: 0x78F31C
	void set_ThreadDispatcher(Dispatcher value) { }

	// RVA: 0x78F388
	bool get_IsPlayMode() { }

	// RVA: 0x78F390
	void set_IsPlayMode(bool value) { }

	// RVA: 0x78F398
	void .cctor() { }

	// RVA: 0x78F4F0
	void .ctor() { }

	// RVA: 0x78FB18
	void StartMonoBehaviour() { }

	// RVA: 0x78FE64
	void StopMonoBehaviour() { }

	// RVA: 0x309AF8C
	TResult RunOnMainThread(System.Func<TResult> f) { }

	// RVA: 0x2FE7084
	System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync(System.Func<TResult> f) { }

	// RVA: 0x79004C
	FirebaseHandler get_DefaultInstance() { }

	// RVA: 0x7900C8
	void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	// RVA: 0x79020C
	void Create(IFirebaseAppUtils appUtils) { }

	// RVA: 0x790294
	void Update() { }

	// RVA: 0x790504
	void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x79068C
	void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	// RVA: 0x7907A0
	void <Update>b__36_0() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Firebase.Platform.PlatformInformation.<>c <>9; // 0x0
	public static System.Func<System.String> <>9__6_0; // 0x8
	public static System.Func<System.String> <>9__18_0; // 0x10

	// Methods

	// RVA: 0x7911C4
	void .cctor() { }

	// RVA: 0x791230
	void .ctor() { }

	// RVA: 0x791238
	string <get_DefaultConfigLocation>b__6_0() { }

	// RVA: 0x7912A8
	string <get_RuntimeVersion>b__18_0() { }

}

// Namespace: Firebase.Platform
internal static class PlatformInformation 
{
	// Fields
	private static string runtimeVersion; // 0x0
	private static float <RealtimeSinceStartupSafe>k__BackingField; // 0x8

	// Methods

	// RVA: 0x790CF4
	bool get_IsAndroid() { }

	// RVA: 0x790D54
	bool get_IsIOS() { }

	// RVA: 0x790E00
	string get_DefaultConfigLocation() { }

	// RVA: 0x790F64
	float get_RealtimeSinceStartup() { }

	// RVA: 0x790F6C
	void set_RealtimeSinceStartupSafe(float value) { }

	// RVA: 0x790FC4
	string get_RuntimeName() { }

	// RVA: 0x791008
	string get_RuntimeVersion() { }

}

// Namespace: Firebase.Platform
internal class FirebaseLogger 
{
	// Fields
	private static Firebase.Platform.MainThreadProperty<System.Boolean> incompatibleStackUnwindingEnabled; // 0x0

	// Methods

	// RVA: 0x791318
	bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	// RVA: 0x791324
	bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	// RVA: 0x791628
	bool get_CanRedirectNativeLogs() { }

	// RVA: 0x78D0D4
	void LogMessage(PlatformLogLevel logLevel, string message) { }

	// RVA: 0x7917E8
	void .cctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseMonoBehaviour 
{
	// Methods

	// RVA: 0x7918D4
	FirebaseHandler GetFirebaseHandlerOrDestroyGameObject() { }

	// RVA: 0x7919F8
	void OnEnable() { }

	// RVA: 0x7919FC
	void Update() { }

	// RVA: 0x791A7C
	void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x791AB0
	void OnDestroy() { }

	// RVA: 0x791B30
	void .ctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseEditorDispatcher 
{
	// Methods

	// RVA: 0x791B38
	Type get_EditorApplicationType() { }

	// RVA: 0x78F5C8
	bool get_EditorIsPlaying() { }

	// RVA: 0x791BD8
	bool get_EditorIsPlayingOrWillChangePlaymode() { }

	// RVA: 0x78FCB8
	void StartEditorUpdate() { }

	// RVA: 0x791F84
	void StopEditorUpdate() { }

	// RVA: 0x79211C
	void Update() { }

	// RVA: 0x78F784
	void ListenToPlayState(bool start) { }

	// RVA: 0x7921E0
	void PlayModeStateChanged() { }

	// RVA: 0x309AF8C
	void PlayModeStateChangedWithArg(T t) { }

	// RVA: 0x791D94
	void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target, bool add, string errorMessage) { }

}

// Namespace: Firebase.Platform.Default
internal class AppConfigExtensions 
{
	// Fields
	private static readonly Uri DefaultUpdateUrl; // 0x0
	private static readonly string Default; // 0x8
	private static readonly object Sync; // 0x10
	private static AppConfigExtensions _instance; // 0x18
	private static readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.String,System.String>> SStringState; // 0x20

	// Methods

	// RVA: 0x78EE54
	IAppConfigExtensions get_Instance() { }

	// RVA: 0x7924EC
	void .ctor() { }

	// RVA: 0x7924F4
	void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class SystemClock 
{
	// Fields
	public static readonly IClockService Instance; // 0x0

	// Methods

	// RVA: 0x792680
	void .ctor() { }

	// RVA: 0x792688
	void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class UnityConfigExtensions 
{
	// Fields
	private static UnityConfigExtensions _instance; // 0x0

	// Methods

	// RVA: 0x78D9B0
	IAppConfigExtensions get_DefaultInstance() { }

	// RVA: 0x7926F4
	void .ctor() { }

	// RVA: 0x79277C
	void .cctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=20 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=20 49099593592620E150DA54A7EF0F932A27DCDB0B8F245B90432DA0E622C461C1; // 0x0
}


