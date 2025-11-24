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

	// RVA: 0x771AE4
	void .ctor(int errorCode, string message) { }

	// RVA: 0x771B64
	void set_ErrorCode(int value) { }

}

// Namespace: Firebase
public sealed class InitializationException 
{
	// Fields
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x771B6C
	InitResult get_InitResult() { }

	// RVA: 0x771B74
	void set_InitResult(InitResult value) { }

	// RVA: 0x771B7C
	void .ctor(InitResult result, string message) { }

	// RVA: 0x771BFC
	void .ctor(InitResult result, string message, Exception inner) { }

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

	// RVA: 0x771C84
	string get_DependencyNotFoundErrorMessage() { }

	// RVA: 0x771D74
	string get_DllNotFoundExceptionErrorMessage() { }

	// RVA: 0x771E6C
	void .cctor() { }

}

// Namespace: 
internal sealed class LogMessageDelegate 
{
	// Methods

	// RVA: 0x772674
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x772A58
	internal void Invoke(LogLevel log_level, string message) { }

}

// Namespace: Firebase
internal sealed class LogUtil 
{
	// Fields
	private static LogUtil _instance; // 0x0
	private static object InitializeLoggingLock; // 0x8
	private bool _disposed; // 0x10

	// Methods

	// RVA: 0x772110
	void .cctor() { }

	// RVA: 0x772340
	void InitializeLogging() { }

	// RVA: 0x7725B0
	PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x7725BC
	void LogMessage(LogLevel logLevel, string message) { }

	// RVA: 0x771FBC
	void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x7721D8
	void .ctor() { }

	// RVA: 0x77288C
	void Finalize() { }

	// RVA: 0x772974
	void Dispose() { }

	// RVA: 0x772934
	void Dispose(bool disposing) { }

	// RVA: 0x772A18
	void <.ctor>b__9_0(object sender, EventArgs e) { }

}

// Namespace: Firebase
internal sealed class MonoPInvokeCallbackAttribute 
{
	// Methods

	// RVA: 0x772A6C
	void .ctor(Type t) { }

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

	// RVA: 0x772A74
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x772AE0
	void Finalize() { }

	// RVA: 0x772B7C
	void Dispose() { }

	// RVA: 0x772C0C
	void Dispose(bool disposing) { }

	// RVA: 0x772DD8
	FutureStatus status() { }

	// RVA: 0x7731E0
	int error() { }

	// RVA: 0x773368
	string error_message() { }

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

	// RVA: 0x775698
	void .ctor(StringStringMap collection) { }

	// RVA: 0x7748C8
	System.Collections.Generic.KeyValuePair<System.String,System.String> get_Current() { }

	// RVA: 0x775CEC
	object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7749DC
	bool MoveNext() { }

	// RVA: 0x775D58
	void Reset() { }

	// RVA: 0x775DF4
	void Dispose() { }

}

// Namespace: Firebase
internal class StringStringMap 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x773500
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x77356C
	HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x7735BC
	void Finalize() { }

	// RVA: 0x77365C
	void Dispose() { }

	// RVA: 0x7736F0
	void Dispose(bool disposing) { }

	// RVA: 0x7738BC
	string get_Item(string key) { }

	// RVA: 0x773A3C
	void set_Item(string key, string value) { }

	// RVA: 0x773BC8
	bool TryGetValue(string key, out string value) { }

	// RVA: 0x773D98
	int get_Count() { }

	// RVA: 0x773F1C
	bool get_IsReadOnly() { }

	// RVA: 0x773F24
	System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0x7744F0
	System.Collections.Generic.ICollection<System.String> get_Values() { }

	// RVA: 0x774B68
	void Add(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x774E6C
	bool Remove(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x774F8C
	bool Contains(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x775284
	void CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.String>[] array, int arrayIndex) { }

	// RVA: 0x775634
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x775780
	IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x774864
	StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x7757E4
	void .ctor() { }

	// RVA: 0x773D9C
	UInt32 size() { }

	// RVA: 0x77597C
	void Clear() { }

	// RVA: 0x7738C0
	string getitem(string key) { }

	// RVA: 0x773A40
	void setitem(string key, string x) { }

	// RVA: 0x773C28
	bool ContainsKey(string key) { }

	// RVA: 0x774CE4
	void Add(string key, string value) { }

	// RVA: 0x775114
	bool Remove(string key) { }

	// RVA: 0x774088
	IntPtr create_iterator_begin() { }

	// RVA: 0x774208
	string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x774370
	void destroy_iterator(IntPtr swigiterator) { }

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

	// RVA: 0x776A74
	void .ctor(StringList collection) { }

	// RVA: 0x7777D0
	string get_Current() { }

	// RVA: 0x7778D4
	object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7778D8
	bool MoveNext() { }

	// RVA: 0x777964
	void Reset() { }

	// RVA: 0x777A00
	void Dispose() { }

}

// Namespace: Firebase
internal class StringList 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x775E08
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x775E74
	void Finalize() { }

	// RVA: 0x775F14
	void Dispose() { }

	// RVA: 0x775FA8
	void Dispose(bool disposing) { }

	// RVA: 0x776174
	bool get_IsReadOnly() { }

	// RVA: 0x77617C
	string get_Item(int index) { }

	// RVA: 0x7762E8
	void set_Item(int index, string value) { }

	// RVA: 0x776460
	int get_Count() { }

	// RVA: 0x7765E4
	void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x776628
	void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x7769D0
	System.Collections.Generic.IEnumerator<System.String> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x776AE4
	IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x776B88
	void Clear() { }

	// RVA: 0x776D04
	void Add(string x) { }

	// RVA: 0x776464
	UInt32 size() { }

	// RVA: 0x776868
	string getitemcopy(int index) { }

	// RVA: 0x776180
	string getitem(int index) { }

	// RVA: 0x7762EC
	void setitem(int index, string val) { }

	// RVA: 0x776F68
	void Insert(int index, string x) { }

	// RVA: 0x777124
	void RemoveAt(int index) { }

	// RVA: 0x7772B0
	bool Contains(string value) { }

	// RVA: 0x777468
	int IndexOf(string value) { }

	// RVA: 0x777618
	bool Remove(string value) { }

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

	// RVA: 0x7786C4
	void .ctor(CharVector collection) { }

	// RVA: 0x779270
	Byte get_Current() { }

	// RVA: 0x779384
	object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7793F0
	bool MoveNext() { }

	// RVA: 0x7794C0
	void Reset() { }

	// RVA: 0x77955C
	void Dispose() { }

}

// Namespace: Firebase
internal class CharVector 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x777A14
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x777A80
	void Finalize() { }

	// RVA: 0x777B20
	void Dispose() { }

	// RVA: 0x777BB4
	void Dispose(bool disposing) { }

	// RVA: 0x777D80
	bool get_IsReadOnly() { }

	// RVA: 0x777D88
	Byte get_Item(int index) { }

	// RVA: 0x777EE4
	void set_Item(int index, Byte value) { }

	// RVA: 0x778048
	int get_Count() { }

	// RVA: 0x7781CC
	void CopyTo(Byte[] array) { }

	// RVA: 0x778484
	void CopyTo(Byte[] array, int arrayIndex) { }

	// RVA: 0x778204
	void CopyTo(int index, Byte[] array, int arrayIndex, int count) { }

	// RVA: 0x778620
	System.Collections.Generic.IEnumerator<System.Byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x778734
	IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7787D8
	void Clear() { }

	// RVA: 0x778954
	void Add(Byte x) { }

	// RVA: 0x77804C
	UInt32 size() { }

	// RVA: 0x7784C8
	Byte getitemcopy(int index) { }

	// RVA: 0x777D8C
	Byte getitem(int index) { }

	// RVA: 0x777EE8
	void setitem(int index, Byte val) { }

	// RVA: 0x778B10
	void Insert(int index, Byte x) { }

	// RVA: 0x778C80
	void RemoveAt(int index) { }

	// RVA: 0x778E0C
	bool Contains(Byte value) { }

	// RVA: 0x778F8C
	int IndexOf(Byte value) { }

	// RVA: 0x7790F0
	bool Remove(Byte value) { }

}

// Namespace: 
public sealed class Action 
{
	// Methods

	// RVA: 0x779F90
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x77A868
	internal void Invoke() { }

}

// Namespace: 
internal sealed class SWIG_CompletionDelegate 
{
	// Methods

	// RVA: 0x77A424
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x77A87C
	internal void Invoke(int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public FutureVoid fu; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Int32> tcs; // 0x18

	// Methods

	// RVA: 0x779F88
	void .ctor() { }

	// RVA: 0x77A890
	void <GetTask>b__0() { }

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

	// RVA: 0x77978C
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x77988C
	void Dispose(bool disposing) { }

	// RVA: 0x779C0C
	Task GetTask(FutureVoid fu) { }

	// RVA: 0x77A3B0
	void ThrowIfDisposed() { }

	// RVA: 0x77A030
	void SetOnCompletionCallback(Action userCompletionCallback) { }

	// RVA: 0x779A70
	void SetCompletionData(IntPtr data) { }

	// RVA: 0x779570
	void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x77A4C8
	IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x77A638
	void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x77A7DC
	void .cctor() { }

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

	// RVA: 0x7802FC
	string get_CppModuleName() { }

	// RVA: 0x780304
	void set_CppModuleName(string value) { }

	// RVA: 0x78030C
	string get_CSharpClassName() { }

	// RVA: 0x780314
	void set_CSharpClassName(string value) { }

	// RVA: 0x78031C
	bool get_AlwaysEnable() { }

	// RVA: 0x780324
	void set_AlwaysEnable(bool value) { }

	// RVA: 0x77E00C
	void .ctor(string csharp, string cpp, bool always) { }

}

// Namespace: 
private sealed class CreateDelegate 
{
	// Methods

	// RVA: 0x77BD30
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78032C
	internal FirebaseApp Invoke() { }

}

// Namespace: 
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

	// RVA: 0x780340
	void .cctor() { }

	// RVA: 0x7803AC
	void .ctor() { }

	// RVA: 0x7803B4
	FirebaseApp <Create>b__15_0() { }

	// RVA: 0x78041C
	bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x780484
	DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x78050C
	System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask) { }

	// RVA: 0x7806C0
	System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x780728
	void <FixDependenciesAsync>b__60_1(Task t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0 
{
	// Fields
	public DependencyStatus status; // 0x10

	// Methods

	// RVA: 0x77F60C
	void .ctor() { }

	// RVA: 0x7807D0
	void <CheckDependencies>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass60_0 
{
	// Fields
	public Task task; // 0x10

	// Methods

	// RVA: 0x77FB8C
	void .ctor() { }

	// RVA: 0x780858
	void <FixDependenciesAsync>b__0() { }

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

	// RVA: 0x77AB70
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x77ABEC
	HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x77AC3C
	void Finalize() { }

	// RVA: 0x77ADBC
	void Dispose() { }

	// RVA: 0x77ACD0
	void Dispose(bool disposing) { }

	// RVA: 0x77B29C
	void .cctor() { }

	// RVA: 0x77B488
	void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x77B5E0
	FirebaseApp get_DefaultInstance() { }

	// RVA: 0x77B7D0
	FirebaseApp GetInstance(string name) { }

	// RVA: 0x77B9B4
	FirebaseApp Create() { }

	// RVA: 0x77CA18
	string get_Name() { }

	// RVA: 0x77CB38
	LogLevel get_LogLevel() { }

	// RVA: 0x77CBA4
	void set_LogLevel(LogLevel value) { }

	// RVA: 0x77CC28
	void AddReference() { }

	// RVA: 0x77AFBC
	void RemoveReference() { }

	// RVA: 0x77CAC4
	void ThrowIfNull() { }

	// RVA: 0x77D198
	void InitializeAppUtilCallbacks() { }

	// RVA: 0x77CFA4
	void OnAllAppsDestroyed() { }

	// RVA: 0x77E490
	Uri UrlStringToUri(string urlString) { }

	// RVA: 0x77E588
	bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x77BDD0
	FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x77EF30
	void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x77BB64
	void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x77EE08
	bool IsCheckDependenciesRunning() { }

	// RVA: 0x77F14C
	System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x77F3B0
	System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x77F530
	DependencyStatus CheckDependencies() { }

	// RVA: 0x77F614
	DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x77FA98
	Task FixDependenciesAsync() { }

	// RVA: 0x77FB94
	void ResetDefaultAppCPtr() { }

	// RVA: 0x77AE5C
	string get_NameInternal() { }

	// RVA: 0x7800B4
	FirebaseApp CreateInternal() { }

	// RVA: 0x77CDE0
	void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x77E968
	void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x77EC44
	void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x77EAF0
	void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x77B67C
	string get_DefaultName() { }

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

	// RVA: 0x7822BC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78242C
	internal void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate 
{
	// Methods

	// RVA: 0x782370
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x782440
	internal void Invoke(string message, string paramName) { }

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

	// RVA: 0x781524
	void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x78162C
	void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x780BB4
	void SetPendingApplicationException(string message) { }

	// RVA: 0x780C4C
	void SetPendingArithmeticException(string message) { }

	// RVA: 0x780CE4
	void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x780D7C
	void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x780E14
	void SetPendingInvalidCastException(string message) { }

	// RVA: 0x780EAC
	void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x780F44
	void SetPendingIOException(string message) { }

	// RVA: 0x780FDC
	void SetPendingNullReferenceException(string message) { }

	// RVA: 0x781074
	void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x78110C
	void SetPendingOverflowException(string message) { }

	// RVA: 0x7811A4
	void SetPendingSystemException(string message) { }

	// RVA: 0x78123C
	void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7812DC
	void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x781400
	void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7818A4
	void .cctor() { }

	// RVA: 0x780B0C
	void .ctor() { }

}

// Namespace: 
public class SWIGPendingException 
{
	// Fields
	private static Exception pendingException; // 0xFFFFFFFF
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x772F60
	bool get_Pending() { }

	// RVA: 0x78167C
	void Set(Exception e) { }

	// RVA: 0x773010
	Exception Retrieve() { }

	// RVA: 0x782454
	void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate 
{
	// Methods

	// RVA: 0x782658
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78270C
	internal string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper 
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x78250C
	void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x782508
	string CreateString(string cString) { }

	// RVA: 0x782520
	void .cctor() { }

	// RVA: 0x780B14
	void .ctor() { }

}

// Namespace: Firebase
internal class AppUtilPINVOKE 
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x780A48
	void .cctor() { }

	// RVA: 0x772DD0
	void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x772F58
	int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x773360
	int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x7734C8
	string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x775970
	IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x775974
	UInt32 StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x775AF0
	void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x775AF8
	string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x775B54
	void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x775BB0
	bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x775BF8
	void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x775C54
	bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x775C9C
	IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x775CA4
	string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x775CE0
	void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7738B4
	void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x776CFC
	void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x776E68
	void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x776EA0
	UInt32 StringList_size(HandleRef jarg1) { }

	// RVA: 0x776EA8
	string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x776EE4
	string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x776F20
	void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7770DC
	void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7772A4
	void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x777420
	bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7775D4
	int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x777788
	bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x77616C
	void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x77894C
	void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x778AD4
	void CharVector_Add(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x778AE0
	UInt32 CharVector_size(HandleRef jarg1) { }

	// RVA: 0x778AE8
	Byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x778AF4
	Byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x778B00
	void CharVector_setitem(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x778C70
	void CharVector_Insert(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x778E00
	void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x778F68
	bool CharVector_Contains(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7790E4
	int CharVector_IndexOf(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x77924C
	bool CharVector_Remove(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x777D78
	void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x77A7A4
	IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x77A7D8
	void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x779C04
	void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x78007C
	string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x77FF20
	IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x780288
	void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x77CC24
	void FirebaseApp_SetLogLevelInternal(int jarg1) { }

	// RVA: 0x77CBA0
	int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x780290
	void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x780298
	void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x7802A0
	void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x7802C8
	string FirebaseApp_DefaultName_get() { }

	// RVA: 0x780B1C
	void PollCallbacks() { }

	// RVA: 0x780B20
	void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x780B24
	void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x780B28
	void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x780B58
	bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x780B90
	void SetLogFunction(LogMessageDelegate jarg1) { }

	// RVA: 0x780BA4
	int CheckAndroidDependencies() { }

	// RVA: 0x780BA8
	IntPtr FixAndroidDependencies() { }

	// RVA: 0x780BAC
	void InitializePlayServicesInternal() { }

	// RVA: 0x780BB0
	void TerminatePlayServicesInternal() { }

	// RVA: 0x779888
	IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }

}

// Namespace: Firebase
internal class AppUtil 
{
	// Methods

	// RVA: 0x782720
	void PollCallbacks() { }

	// RVA: 0x772444
	void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x77E068
	void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x77E334
	void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x77E1D4
	bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x772718
	void SetLogFunction(LogMessageDelegate arg0) { }

	// RVA: 0x77F92C
	GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x780994
	Task FixAndroidDependenciesAsync() { }

	// RVA: 0x77FDC8
	void InitializePlayServicesInternal() { }

	// RVA: 0x77FF24
	void TerminatePlayServicesInternal() { }

}

// Namespace: Firebase
internal class VersionInfo 
{
	// Methods

	// RVA: 0x77E8E0
	string get_SdkVersion() { }

	// RVA: 0x77E924
	string get_BuildSource() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtils 
{
	// Fields
	private static FirebaseAppUtils instance; // 0x0

	// Methods

	// RVA: 0x77E864
	FirebaseAppUtils get_Instance() { }

	// RVA: 0x782878
	void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7828F8
	void PollCallbacks() { }

	// RVA: 0x7828FC
	PlatformLogLevel GetLogLevel() { }

	// RVA: 0x782A58
	void .ctor() { }

	// RVA: 0x782A60
	void .cctor() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppPlatform 
{}


