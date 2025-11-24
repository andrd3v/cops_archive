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

	// RVA: 0x799DE0
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x799E60
	private void set_ErrorCode(int value) { }

}

// Namespace: Firebase
public sealed class InitializationException
{
	// Fields
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x799E68
	public InitResult get_InitResult() { }

	// RVA: 0x799E70
	private void set_InitResult(InitResult value) { }

	// RVA: 0x799E78
	public void .ctor(InitResult result, string message) { }

	// RVA: 0x799EF8
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

	// RVA: 0x799F80
	internal static string get_DependencyNotFoundErrorMessage() { }

	// RVA: 0x79A070
	internal static string get_DllNotFoundExceptionErrorMessage() { }

	// RVA: 0x79A168
	private static void .cctor() { }

}

// Namespace: 
internal sealed class LogMessageDelegate
{
	// Methods

	// RVA: 0x79A970
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79AD54
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

	// RVA: 0x79A40C
	private static void .cctor() { }

	// RVA: 0x79A63C
	public static void InitializeLogging() { }

	// RVA: 0x79A8AC
	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x79A8B8
	internal static void LogMessage(LogLevel logLevel, string message) { }

	// RVA: 0x79A2B8
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x79A4D4
	public void .ctor() { }

	// RVA: 0x79AB88
	protected override void Finalize() { }

	// RVA: 0x79AC70
	public void Dispose() { }

	// RVA: 0x79AC30
	protected void Dispose(bool disposing) { }

	// RVA: 0x79AD14
	private void <.ctor>b__9_0(object sender, EventArgs e) { }

}

// Namespace: Firebase
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x79AD68
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

	// RVA: 0x79AD70
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x79ADDC
	protected override void Finalize() { }

	// RVA: 0x79AE78
	public void Dispose() { }

	// RVA: 0x79AF08
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x79B0D4
	public FutureStatus status() { }

	// RVA: 0x79B4DC
	public int error() { }

	// RVA: 0x79B664
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

	// RVA: 0x79D994
	public void .ctor(StringStringMap collection) { }

	// RVA: 0x79CBC4
	public System.Collections.Generic.KeyValuePair<System.String,System.String> get_Current() { }

	// RVA: 0x79DFE8
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x79CCD8
	public bool MoveNext() { }

	// RVA: 0x79E054
	public void Reset() { }

	// RVA: 0x79E0F0
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringStringMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x79B7FC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x79B868
	internal static HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x79B8B8
	protected override void Finalize() { }

	// RVA: 0x79B958
	public void Dispose() { }

	// RVA: 0x79B9EC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x79BBB8
	public string get_Item(string key) { }

	// RVA: 0x79BD38
	public void set_Item(string key, string value) { }

	// RVA: 0x79BEC4
	public bool TryGetValue(string key, string value) { }

	// RVA: 0x79C094
	public int get_Count() { }

	// RVA: 0x79C218
	public bool get_IsReadOnly() { }

	// RVA: 0x79C220
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0x79C7EC
	public System.Collections.Generic.ICollection<System.String> get_Values() { }

	// RVA: 0x79CE64
	public void Add(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x79D168
	public bool Remove(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x79D288
	public bool Contains(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x79D580
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.String>[] array, int arrayIndex) { }

	// RVA: 0x79D930
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x79DA7C
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x79CB60
	public StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x79DAE0
	public void .ctor() { }

	// RVA: 0x79C098
	private UInt32 size() { }

	// RVA: 0x79DC78
	public void Clear() { }

	// RVA: 0x79BBBC
	private string getitem(string key) { }

	// RVA: 0x79BD3C
	private void setitem(string key, string x) { }

	// RVA: 0x79BF24
	public bool ContainsKey(string key) { }

	// RVA: 0x79CFE0
	public void Add(string key, string value) { }

	// RVA: 0x79D410
	public bool Remove(string key) { }

	// RVA: 0x79C384
	private IntPtr create_iterator_begin() { }

	// RVA: 0x79C504
	private string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x79C66C
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

	// RVA: 0x79ED70
	public void .ctor(StringList collection) { }

	// RVA: 0x79FACC
	public string get_Current() { }

	// RVA: 0x79FBD0
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x79FBD4
	public bool MoveNext() { }

	// RVA: 0x79FC60
	public void Reset() { }

	// RVA: 0x79FCFC
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringList
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x79E104
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x79E170
	protected override void Finalize() { }

	// RVA: 0x79E210
	public void Dispose() { }

	// RVA: 0x79E2A4
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x79E470
	public bool get_IsReadOnly() { }

	// RVA: 0x79E478
	public string get_Item(int index) { }

	// RVA: 0x79E5E4
	public void set_Item(int index, string value) { }

	// RVA: 0x79E75C
	public int get_Count() { }

	// RVA: 0x79E8E0
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x79E924
	public void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x79ECCC
	private System.Collections.Generic.IEnumerator<System.String> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x79EDE0
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x79EE84
	public void Clear() { }

	// RVA: 0x79F000
	public void Add(string x) { }

	// RVA: 0x79E760
	private UInt32 size() { }

	// RVA: 0x79EB64
	private string getitemcopy(int index) { }

	// RVA: 0x79E47C
	private string getitem(int index) { }

	// RVA: 0x79E5E8
	private void setitem(int index, string val) { }

	// RVA: 0x79F264
	public void Insert(int index, string x) { }

	// RVA: 0x79F420
	public void RemoveAt(int index) { }

	// RVA: 0x79F5AC
	public bool Contains(string value) { }

	// RVA: 0x79F764
	public int IndexOf(string value) { }

	// RVA: 0x79F914
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

	// RVA: 0x7A09C0
	public void .ctor(CharVector collection) { }

	// RVA: 0x7A156C
	public Byte get_Current() { }

	// RVA: 0x7A1680
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7A16EC
	public bool MoveNext() { }

	// RVA: 0x7A17BC
	public void Reset() { }

	// RVA: 0x7A1858
	public void Dispose() { }

}

// Namespace: Firebase
internal class CharVector
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x79FD10
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x79FD7C
	protected override void Finalize() { }

	// RVA: 0x79FE1C
	public void Dispose() { }

	// RVA: 0x79FEB0
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7A007C
	public bool get_IsReadOnly() { }

	// RVA: 0x7A0084
	public Byte get_Item(int index) { }

	// RVA: 0x7A01E0
	public void set_Item(int index, Byte value) { }

	// RVA: 0x7A0344
	public int get_Count() { }

	// RVA: 0x7A04C8
	public void CopyTo(Byte[] array) { }

	// RVA: 0x7A0780
	public void CopyTo(Byte[] array, int arrayIndex) { }

	// RVA: 0x7A0500
	public void CopyTo(int index, Byte[] array, int arrayIndex, int count) { }

	// RVA: 0x7A091C
	private System.Collections.Generic.IEnumerator<System.Byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x7A0A30
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7A0AD4
	public void Clear() { }

	// RVA: 0x7A0C50
	public void Add(Byte x) { }

	// RVA: 0x7A0348
	private UInt32 size() { }

	// RVA: 0x7A07C4
	private Byte getitemcopy(int index) { }

	// RVA: 0x7A0088
	private Byte getitem(int index) { }

	// RVA: 0x7A01E4
	private void setitem(int index, Byte val) { }

	// RVA: 0x7A0E0C
	public void Insert(int index, Byte x) { }

	// RVA: 0x7A0F7C
	public void RemoveAt(int index) { }

	// RVA: 0x7A1108
	public bool Contains(Byte value) { }

	// RVA: 0x7A1288
	public int IndexOf(Byte value) { }

	// RVA: 0x7A13EC
	public bool Remove(Byte value) { }

}

// Namespace: 
public sealed class Action
{
	// Methods

	// RVA: 0x7A228C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A2B64
	public virtual void Invoke() { }

}

// Namespace: 
internal sealed class SWIG_CompletionDelegate
{
	// Methods

	// RVA: 0x7A2720
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A2B78
	public virtual void Invoke(int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public FutureVoid fu; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Int32> tcs; // 0x18

	// Methods

	// RVA: 0x7A2284
	public void .ctor() { }

	// RVA: 0x7A2B8C
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

	// RVA: 0x7A1A88
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7A1B88
	public override void Dispose(bool disposing) { }

	// RVA: 0x7A1F08
	public static Task GetTask(FutureVoid fu) { }

	// RVA: 0x7A26AC
	private void ThrowIfDisposed() { }

	// RVA: 0x7A232C
	public void SetOnCompletionCallback(Action userCompletionCallback) { }

	// RVA: 0x7A1D6C
	private void SetCompletionData(IntPtr data) { }

	// RVA: 0x7A186C
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x7A27C4
	internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x7A2934
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x7A2AD8
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

	// RVA: 0x7A85F8
	public string get_CppModuleName() { }

	// RVA: 0x7A8600
	public void set_CppModuleName(string value) { }

	// RVA: 0x7A8608
	public string get_CSharpClassName() { }

	// RVA: 0x7A8610
	public void set_CSharpClassName(string value) { }

	// RVA: 0x7A8618
	public bool get_AlwaysEnable() { }

	// RVA: 0x7A8620
	public void set_AlwaysEnable(bool value) { }

	// RVA: 0x7A6308
	public void .ctor(string csharp, string cpp, bool always) { }

}

// Namespace: 
private sealed class CreateDelegate
{
	// Methods

	// RVA: 0x7A402C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A8628
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

	// RVA: 0x7A863C
	private static void .cctor() { }

	// RVA: 0x7A86A8
	public void .ctor() { }

	// RVA: 0x7A86B0
	internal FirebaseApp <Create>b__15_0() { }

	// RVA: 0x7A8718
	internal bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x7A8780
	internal DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x7A8808
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask) { }

	// RVA: 0x7A89BC
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x7A8A24
	internal void <FixDependenciesAsync>b__60_1(Task t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public DependencyStatus status; // 0x10

	// Methods

	// RVA: 0x7A7908
	public void .ctor() { }

	// RVA: 0x7A8ACC
	internal void <CheckDependencies>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass60_0
{
	// Fields
	public Task task; // 0x10

	// Methods

	// RVA: 0x7A7E88
	public void .ctor() { }

	// RVA: 0x7A8B54
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

	// RVA: 0x7A2E6C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7A2EE8
	internal static HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x7A2F38
	protected override void Finalize() { }

	// RVA: 0x7A30B8
	public void Dispose() { }

	// RVA: 0x7A2FCC
	public void Dispose(bool disposing) { }

	// RVA: 0x7A3598
	private static void .cctor() { }

	// RVA: 0x7A3784
	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x7A38DC
	public static FirebaseApp get_DefaultInstance() { }

	// RVA: 0x7A3ACC
	public static FirebaseApp GetInstance(string name) { }

	// RVA: 0x7A3CB0
	public static FirebaseApp Create() { }

	// RVA: 0x7A4D14
	public string get_Name() { }

	// RVA: 0x7A4E34
	public static LogLevel get_LogLevel() { }

	// RVA: 0x7A4EA0
	public static void set_LogLevel(LogLevel value) { }

	// RVA: 0x7A4F24
	private void AddReference() { }

	// RVA: 0x7A32B8
	private void RemoveReference() { }

	// RVA: 0x7A4DC0
	private void ThrowIfNull() { }

	// RVA: 0x7A5494
	private static void InitializeAppUtilCallbacks() { }

	// RVA: 0x7A52A0
	private static void OnAllAppsDestroyed() { }

	// RVA: 0x7A678C
	internal static Uri UrlStringToUri(string urlString) { }

	// RVA: 0x7A6884
	private static bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x7A40CC
	private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x7A722C
	private static void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x7A3E60
	private static void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x7A7104
	private static bool IsCheckDependenciesRunning() { }

	// RVA: 0x7A7448
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x7A76AC
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x7A782C
	private static DependencyStatus CheckDependencies() { }

	// RVA: 0x7A7910
	private static DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x7A7D94
	public static Task FixDependenciesAsync() { }

	// RVA: 0x7A7E90
	private static void ResetDefaultAppCPtr() { }

	// RVA: 0x7A3158
	internal string get_NameInternal() { }

	// RVA: 0x7A83B0
	internal static FirebaseApp CreateInternal() { }

	// RVA: 0x7A50DC
	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x7A6C64
	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x7A6F40
	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x7A6DEC
	internal static void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x7A3978
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

	// RVA: 0x7AA5B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7AA728
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7AA66C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7AA73C
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

	// RVA: 0x7A9820
	public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7A9928
	public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7A8EB0
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7A8F48
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7A8FE0
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7A9078
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7A9110
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7A91A8
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7A9240
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7A92D8
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7A9370
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7A9408
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7A94A0
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7A9538
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7A95D8
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7A96FC
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7A9BA0
	private static void .cctor() { }

	// RVA: 0x7A8E08
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

	// RVA: 0x79B25C
	public static bool get_Pending() { }

	// RVA: 0x7A9978
	public static void Set(Exception e) { }

	// RVA: 0x79B30C
	public static Exception Retrieve() { }

	// RVA: 0x7AA750
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7AA954
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7AAA08
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7AA808
	public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7AA804
	private static string CreateString(string cString) { }

	// RVA: 0x7AA81C
	private static void .cctor() { }

	// RVA: 0x7A8E10
	public void .ctor() { }

}

// Namespace: Firebase
internal class AppUtilPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7A8D44
	private static void .cctor() { }

	// RVA: 0x79B0CC
	public static extern void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x79B254
	public static extern int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x79B65C
	public static extern int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x79B7C4
	public static extern string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x79DC6C
	public static extern IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x79DC70
	public static extern UInt32 StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x79DDEC
	public static extern void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x79DDF4
	public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79DE50
	public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x79DEAC
	public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79DEF4
	public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x79DF50
	public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79DF98
	public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x79DFA0
	public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x79DFDC
	public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x79BBB0
	public static extern void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x79EFF8
	public static extern void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x79F164
	public static extern void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79F19C
	public static extern UInt32 StringList_size(HandleRef jarg1) { }

	// RVA: 0x79F1A4
	public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x79F1E0
	public static extern string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x79F21C
	public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x79F3D8
	public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x79F5A0
	public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x79F71C
	public static extern bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79F8D0
	public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79FA84
	public static extern bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x79E468
	public static extern void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x7A0C48
	public static extern void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x7A0DD0
	public static extern void CharVector_Add(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7A0DDC
	public static extern UInt32 CharVector_size(HandleRef jarg1) { }

	// RVA: 0x7A0DE4
	public static extern Byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7A0DF0
	public static extern Byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7A0DFC
	public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7A0F6C
	public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7A10FC
	public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7A1264
	public static extern bool CharVector_Contains(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7A13E0
	public static extern int CharVector_IndexOf(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7A1548
	public static extern bool CharVector_Remove(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7A0074
	public static extern void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x7A2AA0
	public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x7A2AD4
	public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x7A1F00
	public static extern void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x7A8378
	public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x7A821C
	public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x7A8584
	internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x7A4F20
	internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1) { }

	// RVA: 0x7A4E9C
	internal static extern int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x7A858C
	internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x7A8594
	internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x7A859C
	public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x7A85C4
	public static extern string FirebaseApp_DefaultName_get() { }

	// RVA: 0x7A8E18
	public static extern void PollCallbacks() { }

	// RVA: 0x7A8E1C
	public static extern void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x7A8E20
	public static extern void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x7A8E24
	public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x7A8E54
	public static extern bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x7A8E8C
	public static extern void SetLogFunction(LogMessageDelegate jarg1) { }

	// RVA: 0x7A8EA0
	public static extern int CheckAndroidDependencies() { }

	// RVA: 0x7A8EA4
	public static extern IntPtr FixAndroidDependencies() { }

	// RVA: 0x7A8EA8
	internal static extern void InitializePlayServicesInternal() { }

	// RVA: 0x7A8EAC
	internal static extern void TerminatePlayServicesInternal() { }

	// RVA: 0x7A1B84
	public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }

}

// Namespace: Firebase
internal class AppUtil
{
	// Methods

	// RVA: 0x7AAA1C
	internal static void PollCallbacks() { }

	// RVA: 0x79A740
	internal static void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x7A6364
	internal static void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x7A6630
	internal static void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x7A64D0
	internal static bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x79AA14
	internal static void SetLogFunction(LogMessageDelegate arg0) { }

	// RVA: 0x7A7C28
	public static GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x7A8C90
	public static Task FixAndroidDependenciesAsync() { }

	// RVA: 0x7A80C4
	internal static void InitializePlayServicesInternal() { }

	// RVA: 0x7A8220
	internal static void TerminatePlayServicesInternal() { }

}

// Namespace: Firebase
internal class VersionInfo
{
	// Methods

	// RVA: 0x7A6BDC
	internal static string get_SdkVersion() { }

	// RVA: 0x7A6C20
	internal static string get_BuildSource() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtils
{
	// Fields
	private static FirebaseAppUtils instance; // 0x0

	// Methods

	// RVA: 0x7A6B60
	public static FirebaseAppUtils get_Instance() { }

	// RVA: 0x7AAB74
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7AABF4
	public void PollCallbacks() { }

	// RVA: 0x7AABF8
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7AAD54
	public void .ctor() { }

	// RVA: 0x7AAD5C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppPlatform
{}


