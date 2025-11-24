// Namespace: 
internal class <Module>
{}

// Namespace: Firebase
public enum DependencyStatus
{
	// Fields
	public int value__; // 0x10
	public const DependencyStatus Available = 0;
	public const DependencyStatus UnavailableDisabled = 1;
	public const DependencyStatus UnavailableInvalid = 2;
	public const DependencyStatus UnavilableMissing = 3;
	public const DependencyStatus UnavailablePermission = 4;
	public const DependencyStatus UnavailableUpdaterequired = 5;
	public const DependencyStatus UnavailableUpdating = 6;
	public const DependencyStatus UnavailableOther = 7;
}

// Namespace: Firebase
public sealed class FirebaseException
{
	// Fields
	private int <ErrorCode>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x78AD00
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x78AD80
	private void set_ErrorCode(int value) { }

}

// Namespace: Firebase
public sealed class InitializationException
{
	// Fields
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x78AD88
	public InitResult get_InitResult() { }

	// RVA: 0x78AD90
	private void set_InitResult(InitResult value) { }

	// RVA: 0x78AD98
	public void .ctor(InitResult result, string message) { }

	// RVA: 0x78AE18
	public void .ctor(InitResult result, string message, Exception inner) { }

}

// Namespace: Firebase
internal class ErrorMessages
{
	// Fields
	private static string DEPENDENCY_NOT_FOUND_ERROR_ANDROID; // 0x0
	private static string DEPENDENCY_NOT_FOUND_ERROR_IOS; // 0x8
	private static string DEPENDENCY_NOT_FOUND_ERROR_GENERIC; // 0x10
	private static string DLL_NOT_FOUND_ERROR_ANDROID; // 0x18
	private static string DLL_NOT_FOUND_ERROR_IOS; // 0x20
	private static string DLL_NOT_FOUND_ERROR_GENERIC; // 0x28

	// Methods

	// RVA: 0x78AEA0
	internal static string get_DependencyNotFoundErrorMessage() { }

	// RVA: 0x78AF90
	internal static string get_DllNotFoundExceptionErrorMessage() { }

	// RVA: 0x78B088
	private static void .cctor() { }

}

// Namespace: 
internal sealed class LogMessageDelegate
{
	// Methods

	// RVA: 0x78B890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x78BC74
	public virtual void Invoke(LogLevel log_level, string message) { }

}

// Namespace: Firebase
internal sealed class LogUtil
{
	// Fields
	private static LogUtil _instance; // 0x0
	private static object InitializeLoggingLock; // 0x8
	private bool _disposed; // 0x10

	// Methods

	// RVA: 0x78B32C
	private static void .cctor() { }

	// RVA: 0x78B55C
	public static void InitializeLogging() { }

	// RVA: 0x78B7CC
	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x78B7D8
	internal static void LogMessage(LogLevel logLevel, string message) { }

	// RVA: 0x78B1D8
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x78B3F4
	public void .ctor() { }

	// RVA: 0x78BAA8
	protected override void Finalize() { }

	// RVA: 0x78BB90
	public void Dispose() { }

	// RVA: 0x78BB50
	protected void Dispose(bool disposing) { }

	// RVA: 0x78BC34
	private void <.ctor>b__9_0(object sender, EventArgs e) { }

}

// Namespace: Firebase
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x78BC88
	public void .ctor(Type t) { }

}

// Namespace: Firebase
internal enum FutureStatus
{
	// Fields
	public int value__; // 0x10
	public const FutureStatus Complete = 0;
	public const FutureStatus Pending = 1;
	public const FutureStatus Invalid = 2;
}

// Namespace: Firebase
internal class FutureBase
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x78BC90
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x78BCFC
	protected override void Finalize() { }

	// RVA: 0x78BD98
	public void Dispose() { }

	// RVA: 0x78BE28
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x78BFF4
	public FutureStatus status() { }

	// RVA: 0x78C3FC
	public int error() { }

	// RVA: 0x78C584
	public string error_message() { }

}

// Namespace: 
public sealed class StringStringMapEnumerator
{
	// Fields
	private StringStringMap collectionRef; // 0x10
	private System.Collections.Generic.IList<System.String> keyCollection; // 0x18
	private int currentIndex; // 0x20
	private object currentObject; // 0x28
	private int currentSize; // 0x30

	// Methods

	// RVA: 0x78E8B4
	public void .ctor(StringStringMap collection) { }

	// RVA: 0x78DAE4
	public System.Collections.Generic.KeyValuePair<System.String,System.String> get_Current() { }

	// RVA: 0x78EF08
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x78DBF8
	public bool MoveNext() { }

	// RVA: 0x78EF74
	public void Reset() { }

	// RVA: 0x78F010
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringStringMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x78C71C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x78C788
	internal static HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x78C7D8
	protected override void Finalize() { }

	// RVA: 0x78C878
	public void Dispose() { }

	// RVA: 0x78C90C
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x78CAD8
	public string get_Item(string key) { }

	// RVA: 0x78CC58
	public void set_Item(string key, string value) { }

	// RVA: 0x78CDE4
	public bool TryGetValue(string key, string value) { }

	// RVA: 0x78CFB4
	public int get_Count() { }

	// RVA: 0x78D138
	public bool get_IsReadOnly() { }

	// RVA: 0x78D140
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0x78D70C
	public System.Collections.Generic.ICollection<System.String> get_Values() { }

	// RVA: 0x78DD84
	public void Add(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x78E088
	public bool Remove(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x78E1A8
	public bool Contains(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x78E4A0
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.String>[] array, int arrayIndex) { }

	// RVA: 0x78E850
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x78E99C
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x78DA80
	public StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x78EA00
	public void .ctor() { }

	// RVA: 0x78CFB8
	private UInt32 size() { }

	// RVA: 0x78EB98
	public void Clear() { }

	// RVA: 0x78CADC
	private string getitem(string key) { }

	// RVA: 0x78CC5C
	private void setitem(string key, string x) { }

	// RVA: 0x78CE44
	public bool ContainsKey(string key) { }

	// RVA: 0x78DF00
	public void Add(string key, string value) { }

	// RVA: 0x78E330
	public bool Remove(string key) { }

	// RVA: 0x78D2A4
	private IntPtr create_iterator_begin() { }

	// RVA: 0x78D424
	private string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x78D58C
	private void destroy_iterator(IntPtr swigiterator) { }

}

// Namespace: 
public sealed class StringListEnumerator
{
	// Fields
	private StringList collectionRef; // 0x10
	private int currentIndex; // 0x18
	private object currentObject; // 0x20
	private int currentSize; // 0x28

	// Methods

	// RVA: 0x78FC90
	public void .ctor(StringList collection) { }

	// RVA: 0x7909EC
	public string get_Current() { }

	// RVA: 0x790AF0
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x790AF4
	public bool MoveNext() { }

	// RVA: 0x790B80
	public void Reset() { }

	// RVA: 0x790C1C
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringList
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x78F024
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x78F090
	protected override void Finalize() { }

	// RVA: 0x78F130
	public void Dispose() { }

	// RVA: 0x78F1C4
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x78F390
	public bool get_IsReadOnly() { }

	// RVA: 0x78F398
	public string get_Item(int index) { }

	// RVA: 0x78F504
	public void set_Item(int index, string value) { }

	// RVA: 0x78F67C
	public int get_Count() { }

	// RVA: 0x78F800
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x78F844
	public void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x78FBEC
	private System.Collections.Generic.IEnumerator<System.String> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x78FD00
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x78FDA4
	public void Clear() { }

	// RVA: 0x78FF20
	public void Add(string x) { }

	// RVA: 0x78F680
	private UInt32 size() { }

	// RVA: 0x78FA84
	private string getitemcopy(int index) { }

	// RVA: 0x78F39C
	private string getitem(int index) { }

	// RVA: 0x78F508
	private void setitem(int index, string val) { }

	// RVA: 0x790184
	public void Insert(int index, string x) { }

	// RVA: 0x790340
	public void RemoveAt(int index) { }

	// RVA: 0x7904CC
	public bool Contains(string value) { }

	// RVA: 0x790684
	public int IndexOf(string value) { }

	// RVA: 0x790834
	public bool Remove(string value) { }

}

// Namespace: 
public sealed class CharVectorEnumerator
{
	// Fields
	private CharVector collectionRef; // 0x10
	private int currentIndex; // 0x18
	private object currentObject; // 0x20
	private int currentSize; // 0x28

	// Methods

	// RVA: 0x7918E0
	public void .ctor(CharVector collection) { }

	// RVA: 0x79248C
	public Byte get_Current() { }

	// RVA: 0x7925A0
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x79260C
	public bool MoveNext() { }

	// RVA: 0x7926DC
	public void Reset() { }

	// RVA: 0x792778
	public void Dispose() { }

}

// Namespace: Firebase
internal class CharVector
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x790C30
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x790C9C
	protected override void Finalize() { }

	// RVA: 0x790D3C
	public void Dispose() { }

	// RVA: 0x790DD0
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x790F9C
	public bool get_IsReadOnly() { }

	// RVA: 0x790FA4
	public Byte get_Item(int index) { }

	// RVA: 0x791100
	public void set_Item(int index, Byte value) { }

	// RVA: 0x791264
	public int get_Count() { }

	// RVA: 0x7913E8
	public void CopyTo(Byte[] array) { }

	// RVA: 0x7916A0
	public void CopyTo(Byte[] array, int arrayIndex) { }

	// RVA: 0x791420
	public void CopyTo(int index, Byte[] array, int arrayIndex, int count) { }

	// RVA: 0x79183C
	private System.Collections.Generic.IEnumerator<System.Byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x791950
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7919F4
	public void Clear() { }

	// RVA: 0x791B70
	public void Add(Byte x) { }

	// RVA: 0x791268
	private UInt32 size() { }

	// RVA: 0x7916E4
	private Byte getitemcopy(int index) { }

	// RVA: 0x790FA8
	private Byte getitem(int index) { }

	// RVA: 0x791104
	private void setitem(int index, Byte val) { }

	// RVA: 0x791D2C
	public void Insert(int index, Byte x) { }

	// RVA: 0x791E9C
	public void RemoveAt(int index) { }

	// RVA: 0x792028
	public bool Contains(Byte value) { }

	// RVA: 0x7921A8
	public int IndexOf(Byte value) { }

	// RVA: 0x79230C
	public bool Remove(Byte value) { }

}

// Namespace: 
public sealed class Action
{
	// Methods

	// RVA: 0x7931AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x793A84
	public virtual void Invoke() { }

}

// Namespace: 
internal sealed class SWIG_CompletionDelegate
{
	// Methods

	// RVA: 0x793640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x793A98
	public virtual void Invoke(int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public FutureVoid fu; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Int32> tcs; // 0x18

	// Methods

	// RVA: 0x7931A4
	public void .ctor() { }

	// RVA: 0x793AAC
	internal void <GetTask>b__0() { }

}

// Namespace: Firebase
internal class FutureVoid
{
	// Fields
	private HandleRef swigCPtr; // 0x28
	private static System.Collections.Generic.Dictionary<System.Int32,Firebase.FutureVoid.Action> Callbacks; // 0x0
	private static int CallbackIndex; // 0x8
	private static object CallbackLock; // 0x10
	private IntPtr callbackData; // 0x38
	private SWIG_CompletionDelegate SWIG_CompletionCB; // 0x40

	// Methods

	// RVA: 0x7929A8
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x792AA8
	public override void Dispose(bool disposing) { }

	// RVA: 0x792E28
	public static Task GetTask(FutureVoid fu) { }

	// RVA: 0x7935CC
	private void ThrowIfDisposed() { }

	// RVA: 0x79324C
	public void SetOnCompletionCallback(Action userCompletionCallback) { }

	// RVA: 0x792C8C
	private void SetCompletionData(IntPtr data) { }

	// RVA: 0x79278C
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x7936E4
	internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x793854
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x7939F8
	private static void .cctor() { }

}

// Namespace: Firebase
public enum InitResult
{
	// Fields
	public int value__; // 0x10
	public const InitResult Success = 0;
	public const InitResult FailedMissingDependency = 1;
}

// Namespace: 
public class EnableModuleParams
{
	// Fields
	private string <CppModuleName>k__BackingField; // 0x10
	private string <CSharpClassName>k__BackingField; // 0x18
	private bool <AlwaysEnable>k__BackingField; // 0x20

	// Methods

	// RVA: 0x799518
	public string get_CppModuleName() { }

	// RVA: 0x799520
	public void set_CppModuleName(string value) { }

	// RVA: 0x799528
	public string get_CSharpClassName() { }

	// RVA: 0x799530
	public void set_CSharpClassName(string value) { }

	// RVA: 0x799538
	public bool get_AlwaysEnable() { }

	// RVA: 0x799540
	public void set_AlwaysEnable(bool value) { }

	// RVA: 0x797228
	public void .ctor(string csharp, string cpp, bool always) { }

}

// Namespace: 
private sealed class CreateDelegate
{
	// Methods

	// RVA: 0x794F4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x799548
	public virtual FirebaseApp Invoke() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Firebase.FirebaseApp.<>c <>9; // 0x0
	public static CreateDelegate <>9__15_0; // 0x8
	public static System.Func<System.Boolean> <>9__48_0; // 0x10
	public static System.Func<Firebase.DependencyStatus> <>9__56_0; // 0x18
	public static System.Func<System.Threading.Tasks.Task,System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__57_1; // 0x20
	public static System.Func<System.Threading.Tasks.Task<Firebase.DependencyStatus>,System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__57_0; // 0x28
	public static System.Action<System.Threading.Tasks.Task> <>9__60_1; // 0x30

	// Methods

	// RVA: 0x79955C
	private static void .cctor() { }

	// RVA: 0x7995C8
	public void .ctor() { }

	// RVA: 0x7995D0
	internal FirebaseApp <Create>b__15_0() { }

	// RVA: 0x799638
	internal bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x7996A0
	internal DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x799728
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask) { }

	// RVA: 0x7998DC
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x799944
	internal void <FixDependenciesAsync>b__60_1(Task t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public DependencyStatus status; // 0x10

	// Methods

	// RVA: 0x798828
	public void .ctor() { }

	// RVA: 0x7999EC
	internal void <CheckDependencies>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass60_0
{
	// Fields
	public Task task; // 0x10

	// Methods

	// RVA: 0x798DA8
	public void .ctor() { }

	// RVA: 0x799A74
	internal void <FixDependenciesAsync>b__0() { }

}

// Namespace: Firebase
public sealed class FirebaseApp
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	private bool swigCMemOwn; // 0x20
	internal static readonly object disposeLock; // 0x0
	private string name; // 0x28
	private EventHandler AppDisposed; // 0x30
	private static System.Collections.Generic.Dictionary<System.String,Firebase.FirebaseApp> nameToProxy; // 0x8
	private static System.Collections.Generic.Dictionary<System.IntPtr,Firebase.FirebaseApp> cPtrToProxy; // 0x10
	private static bool AppUtilCallbacksInitialized; // 0x18
	private static object AppUtilCallbacksLock; // 0x20
	private static bool PreventOnAllAppsDestroyed; // 0x28
	private static bool crashlyticsInitializationAttempted; // 0x29
	private static bool userAgentRegistered; // 0x2A
	private static int CheckDependenciesThread; // 0x2C
	private static object CheckDependenciesThreadLock; // 0x30
	private FirebaseAppPlatform appPlatform; // 0x38

	// Methods

	// RVA: 0x793D8C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x793E08
	internal static HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x793E58
	protected override void Finalize() { }

	// RVA: 0x793FD8
	public void Dispose() { }

	// RVA: 0x793EEC
	public void Dispose(bool disposing) { }

	// RVA: 0x7944B8
	private static void .cctor() { }

	// RVA: 0x7946A4
	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x7947FC
	public static FirebaseApp get_DefaultInstance() { }

	// RVA: 0x7949EC
	public static FirebaseApp GetInstance(string name) { }

	// RVA: 0x794BD0
	public static FirebaseApp Create() { }

	// RVA: 0x795C34
	public string get_Name() { }

	// RVA: 0x795D54
	public static LogLevel get_LogLevel() { }

	// RVA: 0x795DC0
	public static void set_LogLevel(LogLevel value) { }

	// RVA: 0x795E44
	private void AddReference() { }

	// RVA: 0x7941D8
	private void RemoveReference() { }

	// RVA: 0x795CE0
	private void ThrowIfNull() { }

	// RVA: 0x7963B4
	private static void InitializeAppUtilCallbacks() { }

	// RVA: 0x7961C0
	private static void OnAllAppsDestroyed() { }

	// RVA: 0x7976AC
	internal static Uri UrlStringToUri(string urlString) { }

	// RVA: 0x7977A4
	private static bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x794FEC
	private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x79814C
	private static void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x794D80
	private static void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x798024
	private static bool IsCheckDependenciesRunning() { }

	// RVA: 0x798368
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x7985CC
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x79874C
	private static DependencyStatus CheckDependencies() { }

	// RVA: 0x798830
	private static DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x798CB4
	public static Task FixDependenciesAsync() { }

	// RVA: 0x798DB0
	private static void ResetDefaultAppCPtr() { }

	// RVA: 0x794078
	internal string get_NameInternal() { }

	// RVA: 0x7992D0
	internal static FirebaseApp CreateInternal() { }

	// RVA: 0x795FFC
	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x797B84
	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x797E60
	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x797D0C
	internal static void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x794898
	public static string get_DefaultName() { }

}

// Namespace: Firebase
public enum LogLevel
{
	// Fields
	public int value__; // 0x10
	public const LogLevel Verbose = 0;
	public const LogLevel Debug = 1;
	public const LogLevel Info = 2;
	public const LogLevel Warning = 3;
	public const LogLevel Error = 4;
	public const LogLevel Assert = 5;
}

// Namespace: Firebase
internal enum GooglePlayServicesAvailability
{
	// Fields
	public int value__; // 0x10
	public const GooglePlayServicesAvailability AvailabilityAvailable = 0;
	public const GooglePlayServicesAvailability AvailabilityUnavailableDisabled = 1;
	public const GooglePlayServicesAvailability AvailabilityUnavailableInvalid = 2;
	public const GooglePlayServicesAvailability AvailabilityUnavailableMissing = 3;
	public const GooglePlayServicesAvailability AvailabilityUnavailablePermissions = 4;
	public const GooglePlayServicesAvailability AvailabilityUnavailableUpdateRequired = 5;
	public const GooglePlayServicesAvailability AvailabilityUnavailableUpdating = 6;
	public const GooglePlayServicesAvailability AvailabilityUnavailableOther = 7;
}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x79B4D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79B648
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x79B58C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79B65C
	public virtual void Invoke(string message, string paramName) { }

}

// Namespace: 
protected class SWIGExceptionHelper
{
	// Fields
	private static ExceptionDelegate applicationDelegate; // 0x0
	private static ExceptionDelegate arithmeticDelegate; // 0x8
	private static ExceptionDelegate divideByZeroDelegate; // 0x10
	private static ExceptionDelegate indexOutOfRangeDelegate; // 0x18
	private static ExceptionDelegate invalidCastDelegate; // 0x20
	private static ExceptionDelegate invalidOperationDelegate; // 0x28
	private static ExceptionDelegate ioDelegate; // 0x30
	private static ExceptionDelegate nullReferenceDelegate; // 0x38
	private static ExceptionDelegate outOfMemoryDelegate; // 0x40
	private static ExceptionDelegate overflowDelegate; // 0x48
	private static ExceptionDelegate systemDelegate; // 0x50
	private static ExceptionArgumentDelegate argumentDelegate; // 0x58
	private static ExceptionArgumentDelegate argumentNullDelegate; // 0x60
	private static ExceptionArgumentDelegate argumentOutOfRangeDelegate; // 0x68

	// Methods

	// RVA: 0x79A740
	public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x79A848
	public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x799DD0
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x799E68
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x799F00
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x799F98
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x79A030
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x79A0C8
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x79A160
	private static void SetPendingIOException(string message) { }

	// RVA: 0x79A1F8
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x79A290
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x79A328
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x79A3C0
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x79A458
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x79A4F8
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x79A61C
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x79AAC0
	private static void .cctor() { }

	// RVA: 0x799D28
	public void .ctor() { }

}

// Namespace: 
public class SWIGPendingException
{
	// Fields
	private static Exception pendingException; // 0xFFFFFFFF
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x78C17C
	public static bool get_Pending() { }

	// RVA: 0x79A898
	public static void Set(Exception e) { }

	// RVA: 0x78C22C
	public static Exception Retrieve() { }

	// RVA: 0x79B670
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x79B874
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79B928
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x79B728
	public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x79B724
	private static string CreateString(string cString) { }

	// RVA: 0x79B73C
	private static void .cctor() { }

	// RVA: 0x799D30
	public void .ctor() { }

}

// Namespace: Firebase
internal class AppUtilPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x799C64
	private static void .cctor() { }

	// RVA: 0x78BFEC
	public static extern void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x78C174
	public static extern int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x78C57C
	public static extern int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x78C6E4
	public static extern string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x78EB8C
	public static extern IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x78EB90
	public static extern UInt32 StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x78ED0C
	public static extern void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x78ED14
	public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x78ED70
	public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x78EDCC
	public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x78EE14
	public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x78EE70
	public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x78EEB8
	public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x78EEC0
	public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x78EEFC
	public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x78CAD0
	public static extern void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x78FF18
	public static extern void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x790084
	public static extern void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7900BC
	public static extern UInt32 StringList_size(HandleRef jarg1) { }

	// RVA: 0x7900C4
	public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x790100
	public static extern string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x79013C
	public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7902F8
	public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7904C0
	public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x79063C
	public static extern bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7907F0
	public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7909A4
	public static extern bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x78F388
	public static extern void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x791B68
	public static extern void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x791CF0
	public static extern void CharVector_Add(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x791CFC
	public static extern UInt32 CharVector_size(HandleRef jarg1) { }

	// RVA: 0x791D04
	public static extern Byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x791D10
	public static extern Byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x791D1C
	public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x791E8C
	public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x79201C
	public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x792184
	public static extern bool CharVector_Contains(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x792300
	public static extern int CharVector_IndexOf(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x792468
	public static extern bool CharVector_Remove(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x790F94
	public static extern void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x7939C0
	public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x7939F4
	public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x792E20
	public static extern void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x799298
	public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x79913C
	public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x7994A4
	internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x795E40
	internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1) { }

	// RVA: 0x795DBC
	internal static extern int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x7994AC
	internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x7994B4
	internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x7994BC
	public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x7994E4
	public static extern string FirebaseApp_DefaultName_get() { }

	// RVA: 0x799D38
	public static extern void PollCallbacks() { }

	// RVA: 0x799D3C
	public static extern void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x799D40
	public static extern void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x799D44
	public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x799D74
	public static extern bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x799DAC
	public static extern void SetLogFunction(LogMessageDelegate jarg1) { }

	// RVA: 0x799DC0
	public static extern int CheckAndroidDependencies() { }

	// RVA: 0x799DC4
	public static extern IntPtr FixAndroidDependencies() { }

	// RVA: 0x799DC8
	internal static extern void InitializePlayServicesInternal() { }

	// RVA: 0x799DCC
	internal static extern void TerminatePlayServicesInternal() { }

	// RVA: 0x792AA4
	public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }

}

// Namespace: Firebase
internal class AppUtil
{
	// Methods

	// RVA: 0x79B93C
	internal static void PollCallbacks() { }

	// RVA: 0x78B660
	internal static void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x797284
	internal static void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x797550
	internal static void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x7973F0
	internal static bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x78B934
	internal static void SetLogFunction(LogMessageDelegate arg0) { }

	// RVA: 0x798B48
	public static GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x799BB0
	public static Task FixAndroidDependenciesAsync() { }

	// RVA: 0x798FE4
	internal static void InitializePlayServicesInternal() { }

	// RVA: 0x799140
	internal static void TerminatePlayServicesInternal() { }

}

// Namespace: Firebase
internal class VersionInfo
{
	// Methods

	// RVA: 0x797AFC
	internal static string get_SdkVersion() { }

	// RVA: 0x797B40
	internal static string get_BuildSource() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtils
{
	// Fields
	private static FirebaseAppUtils instance; // 0x0

	// Methods

	// RVA: 0x797A80
	public static FirebaseAppUtils get_Instance() { }

	// RVA: 0x79BA94
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x79BB14
	public void PollCallbacks() { }

	// RVA: 0x79BB18
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x79BC74
	public void .ctor() { }

	// RVA: 0x79BC7C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppPlatform
{}


