// Namespace: 
internal class <Module>
{}

// Namespace: Firebase
internal class ExceptionAggregator
{
	// Fields
	private static System.Collections.Generic.List<System.Exception> threadLocalExceptions; // 0xFFFFFFFF

	// Methods

	// RVA: 0x7B4D34
	private static System.Collections.Generic.List<System.Exception> get_Exceptions() { }

	// RVA: 0x7B4E10
	public static Exception GetAndClearPendingExceptions() { }

	// RVA: 0x7B4F7C
	public static void ThrowAndClearPendingExceptions() { }

	// RVA: 0x7B4FBC
	public static Exception LogException(Exception exception) { }

	// RVA: 0x7B5610
	public static void Wrap(Action action) { }

	// RVA: 0x316B894
	public static T Wrap(System.Func<T> func, T errorValue) { }

}

// Namespace: 
private class CallbackStorage<T0>
{
	// Fields
	private TResult <Result>k__BackingField; // 0x0
	private Exception <Exception>k__BackingField; // 0x0

	// Methods

	// RVA: 0x316B894
	public TResult get_Result() { }

	// RVA: 0x316B894
	public void set_Result(TResult value) { }

	// RVA: 0x30B1CD4
	public Exception get_Exception() { }

	// RVA: 0x30B2CB8
	public void set_Exception(Exception value) { }

	// RVA: 0x30B2870
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2870
	internal void <Run>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public System.Threading.Tasks.TaskCompletionSource<TResult> tcs; // 0x0
	public System.Func<TResult> callback; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2870
	internal void <RunAsync>b__0() { }

}

// Namespace: Firebase
internal class Dispatcher
{
	// Fields
	private int ownerThreadId; // 0x10
	private System.Collections.Generic.Queue<System.Action> queue; // 0x18

	// Methods

	// RVA: 0x7B56F0
	public void .ctor() { }

	// RVA: 0x316B894
	public TResult Run(System.Func<TResult> callback) { }

	// RVA: 0x30B1D84
	public System.Threading.Tasks.Task<TResult> RunAsync(System.Func<TResult> callback) { }

	// RVA: 0x30B57C8
	internal static System.Threading.Tasks.Task<TResult> RunAsyncNow(System.Func<TResult> callback) { }

	// RVA: 0x7B579C
	internal bool ManagesThisThread() { }

	// RVA: 0x7B57DC
	public void PollJobs() { }

}

// Namespace: Firebase.Unity
internal class UnityLoggingService
{
	// Fields
	private static UnityLoggingService _instance; // 0x0

	// Methods

	// RVA: 0x7B5960
	public static UnityLoggingService get_Instance() { }

	// RVA: 0x7B59DC
	public void .ctor() { }

	// RVA: 0x7B59E4
	private static void .cctor() { }

}

// Namespace: Firebase.Unity
internal class UnityPlatformServices
{
	// Methods

	// RVA: 0x7B5A50
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

	// RVA: 0x7B66A8
	public void .ctor(int <>1__state) { }

	// RVA: 0x7B66DC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7B66E0
	private bool MoveNext() { }

	// RVA: 0x7B6C30
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x7B6C38
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x7B6C78
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class SynchronizationContextBehavoir
{
	// Fields
	private System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> callbackQueue; // 0x20

	// Methods

	// RVA: 0x7B5E48
	public System.Collections.Generic.Queue<System.Tuple<System.Threading.SendOrPostCallback,System.Object>> get_CallbackQueue() { }

	// RVA: 0x7B6630
	private IEnumerator Start() { }

	// RVA: 0x7B66D4
	public void .ctor() { }

}

// Namespace: 
private sealed class <SignaledCoroutine>d__13
{}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Methods

	// RVA: 0x7B6C80
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_1
{
	// Methods

	// RVA: 0x7B6C88
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public SendOrPostCallback d; // 0x10

	// Methods

	// RVA: 0x7B6570
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_1
{
	// Fields
	public ManualResetEvent newSignal; // 0x10
	public Firebase.Unity.UnitySynchronizationContext.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x7B6578
	public void .ctor() { }

	// RVA: 0x7B6C90
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

	// RVA: 0x7B5D10
	private void .ctor(GameObject gameObject) { }

	// RVA: 0x7B5EE4
	public static void Create(GameObject gameObject) { }

	// RVA: 0x7B5FB0
	public static void Destroy() { }

	// RVA: 0x7B6018
	private ManualResetEvent GetThreadEvent() { }

	// RVA: 0x7B6274
	public override void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x7B63D4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x7B6580
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

	// RVA: 0x7B6DA8
	public static DebugLogger get_Instance() { }

	// RVA: 0x7B6E24
	public void .ctor() { }

	// RVA: 0x7B6E2C
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

	// RVA: 0x7B6E98
	private static void .cctor() { }

	// RVA: 0x7B71B4
	internal static void set_AppConfig(IAppConfigExtensions value) { }

	// RVA: 0x7B7228
	internal static void set_Clock(IClockService value) { }

	// RVA: 0x7B7294
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

	// RVA: 0x7B7300
	public static FirebaseAppUtilsStub get_Instance() { }

	// RVA: 0x7B737C
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7B73A0
	public void PollCallbacks() { }

	// RVA: 0x7B73A4
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7B73AC
	public void .ctor() { }

	// RVA: 0x7B73B4
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

	// RVA: 0x30B2CB8
	public void .ctor(System.Func<T> getPropertyDelegate) { }

	// RVA: 0x316B894
	public T get_Value() { }

	// RVA: 0x316B894
	private T <get_Value>b__5_0() { }

}

// Namespace: 
internal class ApplicationFocusChangedEventArgs
{
	// Fields
	private bool <HasFocus>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7B8AB4
	public void set_HasFocus(bool value) { }

	// RVA: 0x7B88E8
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

	// RVA: 0x7B8ABC
	private static void .cctor() { }

	// RVA: 0x7B8B28
	public void .ctor() { }

	// RVA: 0x7B8B30
	internal bool <StopMonoBehaviour>b__19_0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public IFirebaseAppUtils appUtils; // 0x10

	// Methods

	// RVA: 0x7B84E8
	public void .ctor() { }

	// RVA: 0x7B8CF8
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

	// RVA: 0x7B7420
	public static IFirebaseAppUtils get_AppUtils() { }

	// RVA: 0x7B749C
	private static void set_AppUtils(IFirebaseAppUtils value) { }

	// RVA: 0x7B7508
	public static int get_TickCount() { }

	// RVA: 0x7B7584
	private static Dispatcher get_ThreadDispatcher() { }

	// RVA: 0x7B7600
	private static void set_ThreadDispatcher(Dispatcher value) { }

	// RVA: 0x7B766C
	public bool get_IsPlayMode() { }

	// RVA: 0x7B7674
	public void set_IsPlayMode(bool value) { }

	// RVA: 0x7B767C
	private static void .cctor() { }

	// RVA: 0x7B77D4
	private void .ctor() { }

	// RVA: 0x7B7DFC
	internal void StartMonoBehaviour() { }

	// RVA: 0x7B8148
	internal void StopMonoBehaviour() { }

	// RVA: 0x316B894
	public static TResult RunOnMainThread(System.Func<TResult> f) { }

	// RVA: 0x30B57C8
	public static System.Threading.Tasks.Task<TResult> RunOnMainThreadAsync(System.Func<TResult> f) { }

	// RVA: 0x7B8330
	internal static FirebaseHandler get_DefaultInstance() { }

	// RVA: 0x7B83AC
	internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7B84F0
	internal static void Create(IFirebaseAppUtils appUtils) { }

	// RVA: 0x7B8578
	internal void Update() { }

	// RVA: 0x7B87E8
	internal void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7B8970
	internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour) { }

	// RVA: 0x7B8A84
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

	// RVA: 0x7B94A8
	private static void .cctor() { }

	// RVA: 0x7B9514
	public void .ctor() { }

	// RVA: 0x7B951C
	internal string <get_DefaultConfigLocation>b__6_0() { }

	// RVA: 0x7B958C
	internal string <get_RuntimeVersion>b__18_0() { }

}

// Namespace: Firebase.Platform
internal static class PlatformInformation
{
	// Fields
	private static string runtimeVersion; // 0x0
	private static float <RealtimeSinceStartupSafe>k__BackingField; // 0x8

	// Methods

	// RVA: 0x7B8FD8
	internal static bool get_IsAndroid() { }

	// RVA: 0x7B9038
	internal static bool get_IsIOS() { }

	// RVA: 0x7B90E4
	internal static string get_DefaultConfigLocation() { }

	// RVA: 0x7B9248
	internal static float get_RealtimeSinceStartup() { }

	// RVA: 0x7B9250
	internal static void set_RealtimeSinceStartupSafe(float value) { }

	// RVA: 0x7B92A8
	internal static string get_RuntimeName() { }

	// RVA: 0x7B92EC
	internal static string get_RuntimeVersion() { }

}

// Namespace: Firebase.Platform
internal class FirebaseLogger
{
	// Fields
	private static Firebase.Platform.MainThreadProperty<System.Boolean> incompatibleStackUnwindingEnabled; // 0x0

	// Methods

	// RVA: 0x7B95FC
	private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	// RVA: 0x7B9608
	private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	// RVA: 0x7B990C
	internal static bool get_CanRedirectNativeLogs() { }

	// RVA: 0x7B53B8
	internal static void LogMessage(PlatformLogLevel logLevel, string message) { }

	// RVA: 0x7B9ACC
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseMonoBehaviour
{
	// Methods

	// RVA: 0x7B9BB8
	private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject() { }

	// RVA: 0x7B9CDC
	private void OnEnable() { }

	// RVA: 0x7B9CE0
	private void Update() { }

	// RVA: 0x7B9D60
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x7B9D94
	private void OnDestroy() { }

	// RVA: 0x7B9E14
	public void .ctor() { }

}

// Namespace: Firebase.Platform
internal sealed class FirebaseEditorDispatcher
{
	// Methods

	// RVA: 0x7B9E1C
	private static Type get_EditorApplicationType() { }

	// RVA: 0x7B78AC
	public static bool get_EditorIsPlaying() { }

	// RVA: 0x7B9EBC
	public static bool get_EditorIsPlayingOrWillChangePlaymode() { }

	// RVA: 0x7B7F9C
	public static void StartEditorUpdate() { }

	// RVA: 0x7BA268
	public static void StopEditorUpdate() { }

	// RVA: 0x7BA400
	public static void Update() { }

	// RVA: 0x7B7A68
	public static void ListenToPlayState(bool start) { }

	// RVA: 0x7BA4C4
	private static void PlayModeStateChanged() { }

	// RVA: 0x316B894
	private static void PlayModeStateChangedWithArg(T t) { }

	// RVA: 0x7BA078
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

	// RVA: 0x7B7138
	public static IAppConfigExtensions get_Instance() { }

	// RVA: 0x7BA7D0
	protected void .ctor() { }

	// RVA: 0x7BA7D8
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class SystemClock
{
	// Fields
	public static readonly IClockService Instance; // 0x0

	// Methods

	// RVA: 0x7BA964
	protected void .ctor() { }

	// RVA: 0x7BA96C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform.Default
internal class UnityConfigExtensions
{
	// Fields
	private static UnityConfigExtensions _instance; // 0x0

	// Methods

	// RVA: 0x7B5C94
	public static IAppConfigExtensions get_DefaultInstance() { }

	// RVA: 0x7BA9D8
	public void .ctor() { }

	// RVA: 0x7BAA60
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


