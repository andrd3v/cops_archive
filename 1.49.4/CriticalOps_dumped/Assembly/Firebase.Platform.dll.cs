// Namespace: 
internal class <Module>
{}

// Namespace: Firebase
internal class ExceptionAggregator
{
	// Fields
	private static System.Collections.Generic.List<System.Exception> threadLocalExceptions; // 0xFFFFFFFF

	// Methods

	// RVA: 0x7A5C6C
	private static System.Collections.Generic.List<System.Exception> get_Exceptions() { }

	// RVA: 0x7A5D48
	public static Exception GetAndClearPendingExceptions() { }

	// RVA: 0x7A5EB4
	public static void ThrowAndClearPendingExceptions() { }

	// RVA: 0x7A5EF4
	public static Exception LogException(Exception exception) { }

	// RVA: 0x7A6548
	public static void Wrap(Action action) { }

	// RVA: 0x315B3A8
	public static T Wrap(System.Func<T> func, T errorValue) { }

}

// Namespace: 
private class CallbackStorage<T0>
{
	// Fields
	private TResult <Result>k__BackingField; // 0x0
	private Exception <Exception>k__BackingField; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public TResult get_Result() { }

	// RVA: 0x315B3A8
	public void set_Result(TResult value) { }

	// RVA: 0x30A17DC
	public Exception get_Exception() { }

	// RVA: 0x30A27C0
	public void set_Exception(Exception value) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0>
{
	// Fields
	public Firebase.Dispatcher.CallbackStorage<TResult> result; // 0x0
	public System.Func<TResult> callback; // 0x0
	public EventWaitHandle waitHandle; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	internal void <Run>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public System.Threading.Tasks.TaskCompletionSource<TResult> tcs; // 0x0
	public System.Func<TResult> callback; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	internal void <RunAsync>b__0() { }

}

// Namespace: Firebase
internal class Dispatcher
{
	// Fields
	private int ownerThreadId; // 0x10
	private System.Collections.Generic.Queue<System.Action> queue; // 0x18

	// Methods

	// RVA: 0x7A6628
	public void .ctor() { }

	// RVA: 0x315B3A8
	public TResult Run(System.Func<TResult> callback) { }

	// RVA: 0x30A188C
	public System.Threading.Tasks.Task<TResult> RunAsync(System.Func<TResult> callback) { }

	// RVA: 0x30A52D0
	internal static System.Threading.Tasks.Task<TResult> RunAsyncNow(System.Func<TResult> callback) { }

	// RVA: 0x7A66D4
	internal bool ManagesThisThread() { }

	// RVA: 0x7A6714
	public void PollJobs() { }

}

// Namespace: Firebase.Unity
internal class UnityLoggingService
{
	// Fields
	private static UnityLoggingService _instance; // 0x0

	// Methods

	// RVA: 0x7A6898
	public static UnityLoggingService get_Instance() { }

	// RVA: 0x7A6914
	public void .ctor() { }

	// RVA: 0x7A691C
	private static void .cctor() { }

}

// Namespace: Firebase.Unity
internal class UnityPlatformServices
{
	// Methods

	// RVA: 0x7A6988
	public static void SetupServices() { }

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

	// RVA: 0x7A75E0
	public void .ctor(int <>1__state) { }

	// RVA: 0x7A7614
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7A7618
	private bool MoveNext() { }

	// RVA: 0x7A7B68
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7A7B70
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7A7BB0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class SynchronizationContextBehavoir
{
	// Fields
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> callbackQueue; // 0x20

	// Methods

	// RVA: 0x7A6D80
	public System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> get_CallbackQueue() { }

	// RVA: 0x7A7568
	private IEnumerator Start() { }

	// RVA: 0x7A760C
	public void .ctor() { }

}

// Namespace: 
private sealed class <SignaledCoroutine>d__13
{}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Methods

	// RVA: 0x7A7BB8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_1
{
	// Methods

	// RVA: 0x7A7BC0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public SendOrPostCallback d; // 0x10

	// Methods

	// RVA: 0x7A74A8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_1
{
	// Fields
	public ManualResetEvent newSignal; // 0x10
	public Firebase.Unity.UnitySynchronizationContext.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7A74B0
	public void .ctor() { }

	// RVA: 0x7A7BC8
	internal void <Send>b__0(object x) { }

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

	// RVA: 0x7A6C48
	private void .ctor(GameObject gameObject) { }

	// RVA: 0x7A6E1C
	public static void Create(GameObject gameObject) { }

	// RVA: 0x7A6EE8
	public static void Destroy() { }

	// RVA: 0x7A6F50
	private ManualResetEvent GetThreadEvent() { }

	// RVA: 0x7A71AC
	public override void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x7A730C
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x7A74B8
	private static void .cctor() { }

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

	// RVA: 0x7A7CE0
	public static DebugLogger get_Instance() { }

	// RVA: 0x7A7D5C
	public void .ctor() { }

	// RVA: 0x7A7D64
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal static class Services
{
	// Fields
	private static IAppConfigExtensions <AppConfig>k__BackingField; // 0x0
	private static IClockService <Clock>k__BackingField; // 0x8
	private static ILoggingService <Logging>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A7DD0
	private static void .cctor() { }

	// RVA: 0x7A80EC
	internal static void set_AppConfig(IAppConfigExtensions value) { }

	// RVA: 0x7A8160
	internal static void set_Clock(IClockService value) { }

	// RVA: 0x7A81CC
	internal static void set_Logging(ILoggingService value) { }

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

	// RVA: -1
	public abstract void TranslateDllNotFoundException(Action action) { }

	// RVA: -1
	public abstract void PollCallbacks() { }

	// RVA: -1
	public abstract PlatformLogLevel GetLogLevel() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtilsStub
{
	// Fields
	private static FirebaseAppUtilsStub _instance; // 0x0

	// Methods

	// RVA: 0x7A8238
	public static FirebaseAppUtilsStub get_Instance() { }

	// RVA: 0x7A82B4
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7A82D8
	public void PollCallbacks() { }

	// RVA: 0x7A82DC
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7A82E4
	public void .ctor() { }

	// RVA: 0x7A82EC
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal class MainThreadProperty<T0>
{
	// Fields
	private System.Func<T> getPropertyDelegate; // 0x0
	private int lastGetPropertyTickCount; // 0x0
	private T cachedValue; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Func<T> getPropertyDelegate) { }

	// RVA: 0x315B3A8
	public T get_Value() { }

	// RVA: 0x315B3A8
	private T <get_Value>b__5_0() { }

}

// Namespace: 
internal class ApplicationFocusChangedEventArgs
{
	// Fields
	private bool <HasFocus>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A99EC
	public void set_HasFocus(bool value) { }

	// RVA: 0x7A9820
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Firebase.Platform.FirebaseHandler.<>c <>9; // 0x0
	public static System.Func<System.Boolean> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x7A99F4
	private static void .cctor() { }

	// RVA: 0x7A9A60
	public void .ctor() { }

	// RVA: 0x7A9A68
	internal bool <StopMonoBehaviour>b__19_0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IFirebaseAppUtils appUtils; // 0x10

	// Methods

	// RVA: 0x7A9420
	public void .ctor() { }

	// RVA: 0x7A9C30
	internal void <CreatePartialOnMainThread>b__0() { }

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

	// RVA: 0x7A8358
	public static IFirebaseAppUtils get_AppUtils() { }

	// RVA: 0x7A83D4
	private static void set_AppUtils(IFirebaseAppUtils value) { }

	// RVA: 0x7A8440
	public static int get_TickCount() { }

	// RVA: 0x7A84BC
	private static Dispatcher get_ThreadDispatcher() { }

	// RVA: 0x7A8538
	private static void set_ThreadDispatcher(Dispatcher value) { }

	// RVA: 0x7A85A4
	public bool get_IsPlayMode() { }

	// RVA: 0x7A85AC
	public void set_IsPlayMode(bool value) { }

	// RVA: 0x7A85B4
	private static void .cctor() { }

	// RVA: 0x7A870C
	private void .ctor() { }

	// RVA: 0x7A8D34
	internal void StartMonoBehaviour() { }

	// RVA: 0x7A9080
	internal void StopMonoBehaviour() { }

	// RVA: 0x315B3A8
	public static TResult RunOnMainThread(System.Func<TResult> f) { }

	// RVA: 0x30A52D0
	public static System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync(System.Func<TResult> f) { }

	// RVA: 0x7A9268
	internal static FirebaseHandler get_DefaultInstance() { }

	// RVA: 0x7A92E4
	internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7A9428
	internal static void Create(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7A94B0
	internal void Update() { }

	// RVA: 0x7A9720
	internal void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7A98A8
	internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	// RVA: 0x7A99BC
	private void <Update>b__36_0() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Firebase.Platform.PlatformInformation.<>c <>9; // 0x0
	public static System.Func<System.String> <>9__6_0; // 0x8
	public static System.Func<System.String> <>9__18_0; // 0x10

	// Methods

	// RVA: 0x7AA3E0
	private static void .cctor() { }

	// RVA: 0x7AA44C
	public void .ctor() { }

	// RVA: 0x7AA454
	internal string <get_DefaultConfigLocation>b__6_0() { }

	// RVA: 0x7AA4C4
	internal string <get_RuntimeVersion>b__18_0() { }

}

// Namespace: Firebase.Platform
internal static class PlatformInformation
{
	// Fields
	private static string runtimeVersion; // 0x0
	private static float <RealtimeSinceStartupSafe>k__BackingField; // 0x8

	// Methods

	// RVA: 0x7A9F10
	internal static bool get_IsAndroid() { }

	// RVA: 0x7A9F70
	internal static bool get_IsIOS() { }

	// RVA: 0x7AA01C
	internal static string get_DefaultConfigLocation() { }

	// RVA: 0x7AA180
	internal static float get_RealtimeSinceStartup() { }

	// RVA: 0x7AA188
	internal static void set_RealtimeSinceStartupSafe(float value) { }

	// RVA: 0x7AA1E0
	internal static string get_RuntimeName() { }

	// RVA: 0x7AA224
	internal static string get_RuntimeVersion() { }

}

// Namespace: Firebase.Platform
internal class FirebaseLogger
{
	// Fields
	private static Firebase.Platform.MainThreadProperty<System.Boolean> incompatibleStackUnwindingEnabled; // 0x0

	// Methods

	// RVA: 0x7AA534
	private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	// RVA: 0x7AA540
	private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	// RVA: 0x7AA844
	internal static bool get_CanRedirectNativeLogs() { }

	// RVA: 0x7A62F0
	internal static void LogMessage(PlatformLogLevel logLevel, string message) { }

	// RVA: 0x7AAA04
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseMonoBehaviour
{
	// Methods

	// RVA: 0x7AAAF0
	private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject() { }

	// RVA: 0x7AAC14
	private void OnEnable() { }

	// RVA: 0x7AAC18
	private void Update() { }

	// RVA: 0x7AAC98
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7AACCC
	private void OnDestroy() { }

	// RVA: 0x7AAD4C
	public void .ctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseEditorDispatcher
{
	// Methods

	// RVA: 0x7AAD54
	private static Type get_EditorApplicationType() { }

	// RVA: 0x7A87E4
	public static bool get_EditorIsPlaying() { }

	// RVA: 0x7AADF4
	public static bool get_EditorIsPlayingOrWillChangePlaymode() { }

	// RVA: 0x7A8ED4
	public static void StartEditorUpdate() { }

	// RVA: 0x7AB1A0
	public static void StopEditorUpdate() { }

	// RVA: 0x7AB338
	public static void Update() { }

	// RVA: 0x7A89A0
	public static void ListenToPlayState(bool start) { }

	// RVA: 0x7AB3FC
	private static void PlayModeStateChanged() { }

	// RVA: 0x315B3A8
	private static void PlayModeStateChangedWithArg(T t) { }

	// RVA: 0x7AAFB0
	private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target, bool add, string errorMessage) { }

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

	// RVA: 0x7A8070
	public static IAppConfigExtensions get_Instance() { }

	// RVA: 0x7AB708
	protected void .ctor() { }

	// RVA: 0x7AB710
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class SystemClock
{
	// Fields
	public static readonly IClockService Instance; // 0x0

	// Methods

	// RVA: 0x7AB89C
	protected void .ctor() { }

	// RVA: 0x7AB8A4
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class UnityConfigExtensions
{
	// Fields
	private static UnityConfigExtensions _instance; // 0x0

	// Methods

	// RVA: 0x7A6BCC
	public static IAppConfigExtensions get_DefaultInstance() { }

	// RVA: 0x7AB910
	public void .ctor() { }

	// RVA: 0x7AB998
	private static void .cctor() { }

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


