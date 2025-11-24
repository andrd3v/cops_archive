// Namespace: 
internal class <Module>
{}

// Namespace: Firebase
internal class ExceptionAggregator
{
	// Fields
	private static System.Collections.Generic.List<System.Exception> threadLocalExceptions; // 0xFFFFFFFF

	// Methods

	// RVA: 0x7EF52C
	private static System.Collections.Generic.List<System.Exception> get_Exceptions() { }

	// RVA: 0x7EF608
	public static Exception GetAndClearPendingExceptions() { }

	// RVA: 0x7EF774
	public static void ThrowAndClearPendingExceptions() { }

	// RVA: 0x7EF7B4
	public static Exception LogException(Exception exception) { }

	// RVA: 0x7EFE08
	public static void Wrap(Action action) { }

	// RVA: 0x26AD93C
	public static T Wrap(System.Func<T> func, T errorValue) { }

}

// Namespace: 
private class CallbackStorage<T0>
{
	// Fields
	private TResult <Result>k__BackingField; // 0x0
	private Exception <Exception>k__BackingField; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public TResult get_Result() { }

	// RVA: 0x26AD93C
	public void set_Result(TResult value) { }

	// RVA: 0x3525804
	public Exception get_Exception() { }

	// RVA: 0x35267E8
	public void set_Exception(Exception value) { }

	// RVA: 0x35263A0
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35263A0
	internal void <Run>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public System.Threading.Tasks.TaskCompletionSource<TResult> tcs; // 0x0
	public System.Func<TResult> callback; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35263A0
	internal void <RunAsync>b__0() { }

}

// Namespace: Firebase
internal class Dispatcher
{
	// Fields
	private int ownerThreadId; // 0x10
	private System.Collections.Generic.Queue<System.Action> queue; // 0x18

	// Methods

	// RVA: 0x7EFEE8
	public void .ctor() { }

	// RVA: 0x26AD93C
	public TResult Run(System.Func<TResult> callback) { }

	// RVA: 0x35258B4
	public System.Threading.Tasks.Task<TResult> RunAsync(System.Func<TResult> callback) { }

	// RVA: 0x35293EC
	internal static System.Threading.Tasks.Task<TResult> RunAsyncNow(System.Func<TResult> callback) { }

	// RVA: 0x7EFF94
	internal bool ManagesThisThread() { }

	// RVA: 0x7EFFD4
	public void PollJobs() { }

}

// Namespace: Firebase.Unity
internal class UnityLoggingService
{
	// Fields
	private static UnityLoggingService _instance; // 0x0

	// Methods

	// RVA: 0x7F0158
	public static UnityLoggingService get_Instance() { }

	// RVA: 0x7F01D4
	public void .ctor() { }

	// RVA: 0x7F01DC
	private static void .cctor() { }

}

// Namespace: Firebase.Unity
internal class UnityPlatformServices
{
	// Methods

	// RVA: 0x7F0248
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

	// RVA: 0x7F0EA0
	public void .ctor(int <>1__state) { }

	// RVA: 0x7F0ED4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7F0ED8
	private bool MoveNext() { }

	// RVA: 0x7F1428
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7F1430
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7F1470
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class SynchronizationContextBehavoir
{
	// Fields
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> callbackQueue; // 0x20

	// Methods

	// RVA: 0x7F0640
	public System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> get_CallbackQueue() { }

	// RVA: 0x7F0E28
	private IEnumerator Start() { }

	// RVA: 0x7F0ECC
	public void .ctor() { }

}

// Namespace: 
private sealed class <SignaledCoroutine>d__13
{}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Methods

	// RVA: 0x7F1478
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_1
{
	// Methods

	// RVA: 0x7F1480
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public SendOrPostCallback d; // 0x10

	// Methods

	// RVA: 0x7F0D68
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_1
{
	// Fields
	public ManualResetEvent newSignal; // 0x10
	public Firebase.Unity.UnitySynchronizationContext.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7F0D70
	public void .ctor() { }

	// RVA: 0x7F1488
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

	// RVA: 0x7F0508
	private void .ctor(GameObject gameObject) { }

	// RVA: 0x7F06DC
	public static void Create(GameObject gameObject) { }

	// RVA: 0x7F07A8
	public static void Destroy() { }

	// RVA: 0x7F0810
	private ManualResetEvent GetThreadEvent() { }

	// RVA: 0x7F0A6C
	public override void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x7F0BCC
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x7F0D78
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

	// RVA: 0x7F15A0
	public static DebugLogger get_Instance() { }

	// RVA: 0x7F161C
	public void .ctor() { }

	// RVA: 0x7F1624
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

	// RVA: 0x7F1690
	private static void .cctor() { }

	// RVA: 0x7F19AC
	internal static void set_AppConfig(IAppConfigExtensions value) { }

	// RVA: 0x7F1A20
	internal static void set_Clock(IClockService value) { }

	// RVA: 0x7F1A8C
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

	// RVA: 0x7F1AF8
	public static FirebaseAppUtilsStub get_Instance() { }

	// RVA: 0x7F1B74
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7F1B98
	public void PollCallbacks() { }

	// RVA: 0x7F1B9C
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7F1BA4
	public void .ctor() { }

	// RVA: 0x7F1BAC
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

	// RVA: 0x35267E8
	public void .ctor(System.Func<T> getPropertyDelegate) { }

	// RVA: 0x26AD93C
	public T get_Value() { }

	// RVA: 0x26AD93C
	private T <get_Value>b__5_0() { }

}

// Namespace: 
internal class ApplicationFocusChangedEventArgs
{
	// Fields
	private bool <HasFocus>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7F3250
	public void set_HasFocus(bool value) { }

	// RVA: 0x7F3084
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

	// RVA: 0x7F3258
	private static void .cctor() { }

	// RVA: 0x7F32C4
	public void .ctor() { }

	// RVA: 0x7F32CC
	internal bool <StopMonoBehaviour>b__19_0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IFirebaseAppUtils appUtils; // 0x10

	// Methods

	// RVA: 0x7F2C84
	public void .ctor() { }

	// RVA: 0x7F3494
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

	// RVA: 0x7F1C18
	public static IFirebaseAppUtils get_AppUtils() { }

	// RVA: 0x7F1C94
	private static void set_AppUtils(IFirebaseAppUtils value) { }

	// RVA: 0x7F1D00
	public static int get_TickCount() { }

	// RVA: 0x7F1D7C
	private static Dispatcher get_ThreadDispatcher() { }

	// RVA: 0x7F1DF8
	private static void set_ThreadDispatcher(Dispatcher value) { }

	// RVA: 0x7F1E64
	public bool get_IsPlayMode() { }

	// RVA: 0x7F1E6C
	public void set_IsPlayMode(bool value) { }

	// RVA: 0x7F1E74
	private static void .cctor() { }

	// RVA: 0x7F1FCC
	private void .ctor() { }

	// RVA: 0x7F25B0
	internal void StartMonoBehaviour() { }

	// RVA: 0x7F28E4
	internal void StopMonoBehaviour() { }

	// RVA: 0x26AD93C
	public static TResult RunOnMainThread(System.Func<TResult> f) { }

	// RVA: 0x35293EC
	public static System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync(System.Func<TResult> f) { }

	// RVA: 0x7F2ACC
	internal static FirebaseHandler get_DefaultInstance() { }

	// RVA: 0x7F2B48
	internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7F2C8C
	internal static void Create(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7F2D14
	internal void Update() { }

	// RVA: 0x7F2F84
	internal void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7F310C
	internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	// RVA: 0x7F3220
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

	// RVA: 0x7F3C38
	private static void .cctor() { }

	// RVA: 0x7F3CA4
	public void .ctor() { }

	// RVA: 0x7F3CAC
	internal string <get_DefaultConfigLocation>b__6_0() { }

	// RVA: 0x7F3D1C
	internal string <get_RuntimeVersion>b__18_0() { }

}

// Namespace: Firebase.Platform
internal static class PlatformInformation
{
	// Fields
	private static string runtimeVersion; // 0x0
	private static float <RealtimeSinceStartupSafe>k__BackingField; // 0x8

	// Methods

	// RVA: 0x7F3768
	internal static bool get_IsAndroid() { }

	// RVA: 0x7F37C8
	internal static bool get_IsIOS() { }

	// RVA: 0x7F3874
	internal static string get_DefaultConfigLocation() { }

	// RVA: 0x7F39D8
	internal static float get_RealtimeSinceStartup() { }

	// RVA: 0x7F39E0
	internal static void set_RealtimeSinceStartupSafe(float value) { }

	// RVA: 0x7F3A38
	internal static string get_RuntimeName() { }

	// RVA: 0x7F3A7C
	internal static string get_RuntimeVersion() { }

}

// Namespace: Firebase.Platform
internal class FirebaseLogger
{
	// Fields
	private static Firebase.Platform.MainThreadProperty<System.Boolean> incompatibleStackUnwindingEnabled; // 0x0

	// Methods

	// RVA: 0x7F3D8C
	private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	// RVA: 0x7F3D98
	private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	// RVA: 0x7F4098
	internal static bool get_CanRedirectNativeLogs() { }

	// RVA: 0x7EFBB0
	internal static void LogMessage(PlatformLogLevel logLevel, string message) { }

	// RVA: 0x7F424C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseMonoBehaviour
{
	// Methods

	// RVA: 0x7F4338
	private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject() { }

	// RVA: 0x7F445C
	private void OnEnable() { }

	// RVA: 0x7F4460
	private void Update() { }

	// RVA: 0x7F44E0
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7F4514
	private void OnDestroy() { }

	// RVA: 0x7F4594
	public void .ctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseEditorDispatcher
{
	// Methods

	// RVA: 0x7F459C
	private static Type get_EditorApplicationType() { }

	// RVA: 0x7F20A4
	public static bool get_EditorIsPlaying() { }

	// RVA: 0x7F4630
	public static bool get_EditorIsPlayingOrWillChangePlaymode() { }

	// RVA: 0x7F2750
	public static void StartEditorUpdate() { }

	// RVA: 0x7F49B0
	public static void StopEditorUpdate() { }

	// RVA: 0x7F4B30
	public static void Update() { }

	// RVA: 0x7F2234
	public static void ListenToPlayState(bool start) { }

	// RVA: 0x7F4BF4
	private static void PlayModeStateChanged() { }

	// RVA: 0x26AD93C
	private static void PlayModeStateChangedWithArg(T t) { }

	// RVA: 0x7F47C0
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

	// RVA: 0x7F1930
	public static IAppConfigExtensions get_Instance() { }

	// RVA: 0x7F4F00
	protected void .ctor() { }

	// RVA: 0x7F4F08
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class SystemClock
{
	// Fields
	public static readonly IClockService Instance; // 0x0

	// Methods

	// RVA: 0x7F5094
	protected void .ctor() { }

	// RVA: 0x7F509C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class UnityConfigExtensions
{
	// Fields
	private static UnityConfigExtensions _instance; // 0x0

	// Methods

	// RVA: 0x7F048C
	public static IAppConfigExtensions get_DefaultInstance() { }

	// RVA: 0x7F5108
	public void .ctor() { }

	// RVA: 0x7F5190
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


