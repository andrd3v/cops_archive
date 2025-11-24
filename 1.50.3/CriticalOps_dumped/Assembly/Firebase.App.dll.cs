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

	// RVA: 0x7B0958
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x7B09D8
	private void set_ErrorCode(int value) { }

}

// Namespace: Firebase
public sealed class InitializationException
{
	// Fields
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x7B09E0
	public InitResult get_InitResult() { }

	// RVA: 0x7B09E8
	private void set_InitResult(InitResult value) { }

	// RVA: 0x7B09F0
	public void .ctor(InitResult result, string message) { }

	// RVA: 0x7B0A70
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

	// RVA: 0x7B0AF8
	internal static string get_DependencyNotFoundErrorMessage() { }

	// RVA: 0x7B0BE8
	internal static string get_DllNotFoundExceptionErrorMessage() { }

	// RVA: 0x7B0CE0
	private static void .cctor() { }

}

// Namespace: 
internal sealed class LogMessageDelegate
{
	// Methods

	// RVA: 0x7B14E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B18CC
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

	// RVA: 0x7B0F84
	private static void .cctor() { }

	// RVA: 0x7B11B4
	public static void InitializeLogging() { }

	// RVA: 0x7B1424
	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x7B1430
	internal static void LogMessage(LogLevel logLevel, string message) { }

	// RVA: 0x7B0E30
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x7B104C
	public void .ctor() { }

	// RVA: 0x7B1700
	protected override void Finalize() { }

	// RVA: 0x7B17E8
	public void Dispose() { }

	// RVA: 0x7B17A8
	protected void Dispose(bool disposing) { }

	// RVA: 0x7B188C
	private void <.ctor>b__9_0(object sender, EventArgs e) { }

}

// Namespace: Firebase
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x7B18E0
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

	// RVA: 0x7B18E8
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B1954
	protected override void Finalize() { }

	// RVA: 0x7B19F0
	public void Dispose() { }

	// RVA: 0x7B1A80
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7B1C4C
	public FutureStatus status() { }

	// RVA: 0x7B2054
	public int error() { }

	// RVA: 0x7B21DC
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

	// RVA: 0x7B450C
	public void .ctor(StringStringMap collection) { }

	// RVA: 0x7B373C
	public System.Collections.Generic.KeyValuePair<System.String,System.String> get_Current() { }

	// RVA: 0x7B4B60
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7B3850
	public bool MoveNext() { }

	// RVA: 0x7B4BCC
	public void Reset() { }

	// RVA: 0x7B4C68
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringStringMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B2374
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B23E0
	internal static HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x7B2430
	protected override void Finalize() { }

	// RVA: 0x7B24D0
	public void Dispose() { }

	// RVA: 0x7B2564
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7B2730
	public string get_Item(string key) { }

	// RVA: 0x7B28B0
	public void set_Item(string key, string value) { }

	// RVA: 0x7B2A3C
	public bool TryGetValue(string key, string value) { }

	// RVA: 0x7B2C0C
	public int get_Count() { }

	// RVA: 0x7B2D90
	public bool get_IsReadOnly() { }

	// RVA: 0x7B2D98
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0x7B3364
	public System.Collections.Generic.ICollection<System.String> get_Values() { }

	// RVA: 0x7B39DC
	public void Add(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7B3CE0
	public bool Remove(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7B3E00
	public bool Contains(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7B40F8
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.String>[] array, int arrayIndex) { }

	// RVA: 0x7B44A8
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x7B45F4
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7B36D8
	public StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x7B4658
	public void .ctor() { }

	// RVA: 0x7B2C10
	private UInt32 size() { }

	// RVA: 0x7B47F0
	public void Clear() { }

	// RVA: 0x7B2734
	private string getitem(string key) { }

	// RVA: 0x7B28B4
	private void setitem(string key, string x) { }

	// RVA: 0x7B2A9C
	public bool ContainsKey(string key) { }

	// RVA: 0x7B3B58
	public void Add(string key, string value) { }

	// RVA: 0x7B3F88
	public bool Remove(string key) { }

	// RVA: 0x7B2EFC
	private IntPtr create_iterator_begin() { }

	// RVA: 0x7B307C
	private string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x7B31E4
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

	// RVA: 0x7B58E8
	public void .ctor(StringList collection) { }

	// RVA: 0x7B6644
	public string get_Current() { }

	// RVA: 0x7B6748
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7B674C
	public bool MoveNext() { }

	// RVA: 0x7B67D8
	public void Reset() { }

	// RVA: 0x7B6874
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringList
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B4C7C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B4CE8
	protected override void Finalize() { }

	// RVA: 0x7B4D88
	public void Dispose() { }

	// RVA: 0x7B4E1C
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7B4FE8
	public bool get_IsReadOnly() { }

	// RVA: 0x7B4FF0
	public string get_Item(int index) { }

	// RVA: 0x7B515C
	public void set_Item(int index, string value) { }

	// RVA: 0x7B52D4
	public int get_Count() { }

	// RVA: 0x7B5458
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x7B549C
	public void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x7B5844
	private System.Collections.Generic.IEnumerator<System.String> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x7B5958
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7B59FC
	public void Clear() { }

	// RVA: 0x7B5B78
	public void Add(string x) { }

	// RVA: 0x7B52D8
	private UInt32 size() { }

	// RVA: 0x7B56DC
	private string getitemcopy(int index) { }

	// RVA: 0x7B4FF4
	private string getitem(int index) { }

	// RVA: 0x7B5160
	private void setitem(int index, string val) { }

	// RVA: 0x7B5DDC
	public void Insert(int index, string x) { }

	// RVA: 0x7B5F98
	public void RemoveAt(int index) { }

	// RVA: 0x7B6124
	public bool Contains(string value) { }

	// RVA: 0x7B62DC
	public int IndexOf(string value) { }

	// RVA: 0x7B648C
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

	// RVA: 0x7B7538
	public void .ctor(CharVector collection) { }

	// RVA: 0x7B80E4
	public Byte get_Current() { }

	// RVA: 0x7B81F8
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7B8264
	public bool MoveNext() { }

	// RVA: 0x7B8334
	public void Reset() { }

	// RVA: 0x7B83D0
	public void Dispose() { }

}

// Namespace: Firebase
internal class CharVector
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B6888
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B68F4
	protected override void Finalize() { }

	// RVA: 0x7B6994
	public void Dispose() { }

	// RVA: 0x7B6A28
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7B6BF4
	public bool get_IsReadOnly() { }

	// RVA: 0x7B6BFC
	public Byte get_Item(int index) { }

	// RVA: 0x7B6D58
	public void set_Item(int index, Byte value) { }

	// RVA: 0x7B6EBC
	public int get_Count() { }

	// RVA: 0x7B7040
	public void CopyTo(Byte[] array) { }

	// RVA: 0x7B72F8
	public void CopyTo(Byte[] array, int arrayIndex) { }

	// RVA: 0x7B7078
	public void CopyTo(int index, Byte[] array, int arrayIndex, int count) { }

	// RVA: 0x7B7494
	private System.Collections.Generic.IEnumerator<System.Byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x7B75A8
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7B764C
	public void Clear() { }

	// RVA: 0x7B77C8
	public void Add(Byte x) { }

	// RVA: 0x7B6EC0
	private UInt32 size() { }

	// RVA: 0x7B733C
	private Byte getitemcopy(int index) { }

	// RVA: 0x7B6C00
	private Byte getitem(int index) { }

	// RVA: 0x7B6D5C
	private void setitem(int index, Byte val) { }

	// RVA: 0x7B7984
	public void Insert(int index, Byte x) { }

	// RVA: 0x7B7AF4
	public void RemoveAt(int index) { }

	// RVA: 0x7B7C80
	public bool Contains(Byte value) { }

	// RVA: 0x7B7E00
	public int IndexOf(Byte value) { }

	// RVA: 0x7B7F64
	public bool Remove(Byte value) { }

}

// Namespace: 
public sealed class Action
{
	// Methods

	// RVA: 0x7B8E04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B96DC
	public virtual void Invoke() { }

}

// Namespace: 
internal sealed class SWIG_CompletionDelegate
{
	// Methods

	// RVA: 0x7B9298
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B96F0
	public virtual void Invoke(int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public FutureVoid fu; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Int32> tcs; // 0x18

	// Methods

	// RVA: 0x7B8DFC
	public void .ctor() { }

	// RVA: 0x7B9704
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

	// RVA: 0x7B8600
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B8700
	public override void Dispose(bool disposing) { }

	// RVA: 0x7B8A80
	public static Task GetTask(FutureVoid fu) { }

	// RVA: 0x7B9224
	private void ThrowIfDisposed() { }

	// RVA: 0x7B8EA4
	public void SetOnCompletionCallback(Action userCompletionCallback) { }

	// RVA: 0x7B88E4
	private void SetCompletionData(IntPtr data) { }

	// RVA: 0x7B83E4
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x7B933C
	internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x7B94AC
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x7B9650
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

	// RVA: 0x7BF170
	public string get_CppModuleName() { }

	// RVA: 0x7BF178
	public void set_CppModuleName(string value) { }

	// RVA: 0x7BF180
	public string get_CSharpClassName() { }

	// RVA: 0x7BF188
	public void set_CSharpClassName(string value) { }

	// RVA: 0x7BF190
	public bool get_AlwaysEnable() { }

	// RVA: 0x7BF198
	public void set_AlwaysEnable(bool value) { }

	// RVA: 0x7BCE80
	public void .ctor(string csharp, string cpp, bool always) { }

}

// Namespace: 
private sealed class CreateDelegate
{
	// Methods

	// RVA: 0x7BABA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7BF1A0
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

	// RVA: 0x7BF1B4
	private static void .cctor() { }

	// RVA: 0x7BF220
	public void .ctor() { }

	// RVA: 0x7BF228
	internal FirebaseApp <Create>b__15_0() { }

	// RVA: 0x7BF290
	internal bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x7BF2F8
	internal DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x7BF380
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask) { }

	// RVA: 0x7BF534
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x7BF59C
	internal void <FixDependenciesAsync>b__60_1(Task t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public DependencyStatus status; // 0x10

	// Methods

	// RVA: 0x7BE480
	public void .ctor() { }

	// RVA: 0x7BF644
	internal void <CheckDependencies>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass60_0
{
	// Fields
	public Task task; // 0x10

	// Methods

	// RVA: 0x7BEA00
	public void .ctor() { }

	// RVA: 0x7BF6CC
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

	// RVA: 0x7B99E4
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B9A60
	internal static HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x7B9AB0
	protected override void Finalize() { }

	// RVA: 0x7B9C30
	public void Dispose() { }

	// RVA: 0x7B9B44
	public void Dispose(bool disposing) { }

	// RVA: 0x7BA110
	private static void .cctor() { }

	// RVA: 0x7BA2FC
	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x7BA454
	public static FirebaseApp get_DefaultInstance() { }

	// RVA: 0x7BA644
	public static FirebaseApp GetInstance(string name) { }

	// RVA: 0x7BA828
	public static FirebaseApp Create() { }

	// RVA: 0x7BB88C
	public string get_Name() { }

	// RVA: 0x7BB9AC
	public static LogLevel get_LogLevel() { }

	// RVA: 0x7BBA18
	public static void set_LogLevel(LogLevel value) { }

	// RVA: 0x7BBA9C
	private void AddReference() { }

	// RVA: 0x7B9E30
	private void RemoveReference() { }

	// RVA: 0x7BB938
	private void ThrowIfNull() { }

	// RVA: 0x7BC00C
	private static void InitializeAppUtilCallbacks() { }

	// RVA: 0x7BBE18
	private static void OnAllAppsDestroyed() { }

	// RVA: 0x7BD304
	internal static Uri UrlStringToUri(string urlString) { }

	// RVA: 0x7BD3FC
	private static bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x7BAC44
	private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x7BDDA4
	private static void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x7BA9D8
	private static void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x7BDC7C
	private static bool IsCheckDependenciesRunning() { }

	// RVA: 0x7BDFC0
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x7BE224
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x7BE3A4
	private static DependencyStatus CheckDependencies() { }

	// RVA: 0x7BE488
	private static DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x7BE90C
	public static Task FixDependenciesAsync() { }

	// RVA: 0x7BEA08
	private static void ResetDefaultAppCPtr() { }

	// RVA: 0x7B9CD0
	internal string get_NameInternal() { }

	// RVA: 0x7BEF28
	internal static FirebaseApp CreateInternal() { }

	// RVA: 0x7BBC54
	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x7BD7DC
	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x7BDAB8
	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x7BD964
	internal static void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x7BA4F0
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

	// RVA: 0x7C1130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7C12A0
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7C11E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7C12B4
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

	// RVA: 0x7C0398
	public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7C04A0
	public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7BFA28
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7BFAC0
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7BFB58
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7BFBF0
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7BFC88
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7BFD20
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7BFDB8
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7BFE50
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7BFEE8
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7BFF80
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7C0018
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7C00B0
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7C0150
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7C0274
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7C0718
	private static void .cctor() { }

	// RVA: 0x7BF980
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

	// RVA: 0x7B1DD4
	public static bool get_Pending() { }

	// RVA: 0x7C04F0
	public static void Set(Exception e) { }

	// RVA: 0x7B1E84
	public static Exception Retrieve() { }

	// RVA: 0x7C12C8
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7C14CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7C1580
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7C1380
	public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7C137C
	private static string CreateString(string cString) { }

	// RVA: 0x7C1394
	private static void .cctor() { }

	// RVA: 0x7BF988
	public void .ctor() { }

}

// Namespace: Firebase
internal class AppUtilPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7BF8BC
	private static void .cctor() { }

	// RVA: 0x7B1C44
	public static extern void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x7B1DCC
	public static extern int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x7B21D4
	public static extern int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x7B233C
	public static extern string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x7B47E4
	public static extern IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x7B47E8
	public static extern UInt32 StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x7B4964
	public static extern void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x7B496C
	public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B49C8
	public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x7B4A24
	public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B4A6C
	public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x7B4AC8
	public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B4B10
	public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x7B4B18
	public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7B4B54
	public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7B2728
	public static extern void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x7B5B70
	public static extern void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x7B5CDC
	public static extern void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B5D14
	public static extern UInt32 StringList_size(HandleRef jarg1) { }

	// RVA: 0x7B5D1C
	public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B5D58
	public static extern string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B5D94
	public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7B5F50
	public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7B6118
	public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B6294
	public static extern bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B6448
	public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B65FC
	public static extern bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7B4FE0
	public static extern void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x7B77C0
	public static extern void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x7B7948
	public static extern void CharVector_Add(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7B7954
	public static extern UInt32 CharVector_size(HandleRef jarg1) { }

	// RVA: 0x7B795C
	public static extern Byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B7968
	public static extern Byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B7974
	public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7B7AE4
	public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7B7C74
	public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7B7DDC
	public static extern bool CharVector_Contains(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7B7F58
	public static extern int CharVector_IndexOf(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7B80C0
	public static extern bool CharVector_Remove(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7B6BEC
	public static extern void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x7B9618
	public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x7B964C
	public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x7B8A78
	public static extern void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x7BEEF0
	public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x7BED94
	public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x7BF0FC
	internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x7BBA98
	internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1) { }

	// RVA: 0x7BBA14
	internal static extern int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x7BF104
	internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x7BF10C
	internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x7BF114
	public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x7BF13C
	public static extern string FirebaseApp_DefaultName_get() { }

	// RVA: 0x7BF990
	public static extern void PollCallbacks() { }

	// RVA: 0x7BF994
	public static extern void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x7BF998
	public static extern void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x7BF99C
	public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x7BF9CC
	public static extern bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x7BFA04
	public static extern void SetLogFunction(LogMessageDelegate jarg1) { }

	// RVA: 0x7BFA18
	public static extern int CheckAndroidDependencies() { }

	// RVA: 0x7BFA1C
	public static extern IntPtr FixAndroidDependencies() { }

	// RVA: 0x7BFA20
	internal static extern void InitializePlayServicesInternal() { }

	// RVA: 0x7BFA24
	internal static extern void TerminatePlayServicesInternal() { }

	// RVA: 0x7B86FC
	public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }

}

// Namespace: Firebase
internal class AppUtil
{
	// Methods

	// RVA: 0x7C1594
	internal static void PollCallbacks() { }

	// RVA: 0x7B12B8
	internal static void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x7BCEDC
	internal static void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x7BD1A8
	internal static void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x7BD048
	internal static bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x7B158C
	internal static void SetLogFunction(LogMessageDelegate arg0) { }

	// RVA: 0x7BE7A0
	public static GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x7BF808
	public static Task FixAndroidDependenciesAsync() { }

	// RVA: 0x7BEC3C
	internal static void InitializePlayServicesInternal() { }

	// RVA: 0x7BED98
	internal static void TerminatePlayServicesInternal() { }

}

// Namespace: Firebase
internal class VersionInfo
{
	// Methods

	// RVA: 0x7BD754
	internal static string get_SdkVersion() { }

	// RVA: 0x7BD798
	internal static string get_BuildSource() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtils
{
	// Fields
	private static FirebaseAppUtils instance; // 0x0

	// Methods

	// RVA: 0x7BD6D8
	public static FirebaseAppUtils get_Instance() { }

	// RVA: 0x7C16EC
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7C176C
	public void PollCallbacks() { }

	// RVA: 0x7C1770
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7C18CC
	public void .ctor() { }

	// RVA: 0x7C18D4
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppPlatform
{}


