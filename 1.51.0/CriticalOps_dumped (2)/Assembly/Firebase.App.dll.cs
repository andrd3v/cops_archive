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

	// RVA: 0x7CEFE4
	public void .ctor(int errorCode, string message) { }

	// RVA: 0x7CF064
	private void set_ErrorCode(int value) { }

}

// Namespace: Firebase
public sealed class InitializationException
{
	// Fields
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Methods

	// RVA: 0x7CF06C
	public InitResult get_InitResult() { }

	// RVA: 0x7CF074
	private void set_InitResult(InitResult value) { }

	// RVA: 0x7CF07C
	public void .ctor(InitResult result, string message) { }

	// RVA: 0x7CF0FC
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

	// RVA: 0x7CF184
	internal static string get_DependencyNotFoundErrorMessage() { }

	// RVA: 0x7CF274
	internal static string get_DllNotFoundExceptionErrorMessage() { }

	// RVA: 0x7CF36C
	private static void .cctor() { }

}

// Namespace: 
internal sealed class LogMessageDelegate
{
	// Methods

	// RVA: 0x7CFB74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CFF58
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

	// RVA: 0x7CF610
	private static void .cctor() { }

	// RVA: 0x7CF840
	public static void InitializeLogging() { }

	// RVA: 0x7CFAB0
	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x7CFABC
	internal static void LogMessage(LogLevel logLevel, string message) { }

	// RVA: 0x7CF4BC
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x7CF6D8
	public void .ctor() { }

	// RVA: 0x7CFD8C
	protected override void Finalize() { }

	// RVA: 0x7CFE74
	public void Dispose() { }

	// RVA: 0x7CFE34
	protected void Dispose(bool disposing) { }

	// RVA: 0x7CFF18
	private void <.ctor>b__9_0(object sender, EventArgs e) { }

}

// Namespace: Firebase
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x7CFF6C
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

	// RVA: 0x7CFF74
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7CFFE0
	protected override void Finalize() { }

	// RVA: 0x7D007C
	public void Dispose() { }

	// RVA: 0x7D010C
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7D02C4
	public FutureStatus status() { }

	// RVA: 0x7D06CC
	public int error() { }

	// RVA: 0x7D0854
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

	// RVA: 0x7D2B70
	public void .ctor(StringStringMap collection) { }

	// RVA: 0x7D1DA0
	public System.Collections.Generic.KeyValuePair<System.String,System.String> get_Current() { }

	// RVA: 0x7D31C4
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7D1EB4
	public bool MoveNext() { }

	// RVA: 0x7D3230
	public void Reset() { }

	// RVA: 0x7D32CC
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringStringMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7D09EC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7D0A58
	internal static HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x7D0AA8
	protected override void Finalize() { }

	// RVA: 0x7D0B48
	public void Dispose() { }

	// RVA: 0x7D0BDC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7D0D94
	public string get_Item(string key) { }

	// RVA: 0x7D0F14
	public void set_Item(string key, string value) { }

	// RVA: 0x7D10A0
	public bool TryGetValue(string key, string value) { }

	// RVA: 0x7D1270
	public int get_Count() { }

	// RVA: 0x7D13F4
	public bool get_IsReadOnly() { }

	// RVA: 0x7D13FC
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0x7D19C8
	public System.Collections.Generic.ICollection<System.String> get_Values() { }

	// RVA: 0x7D2040
	public void Add(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7D2344
	public bool Remove(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7D2464
	public bool Contains(System.Collections.Generic.KeyValuePair<System.String,System.String> item) { }

	// RVA: 0x7D275C
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.String>[] array, int arrayIndex) { }

	// RVA: 0x7D2B0C
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x7D2C58
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7D1D3C
	public StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x7D2CBC
	public void .ctor() { }

	// RVA: 0x7D1274
	private UInt32 size() { }

	// RVA: 0x7D2E54
	public void Clear() { }

	// RVA: 0x7D0D98
	private string getitem(string key) { }

	// RVA: 0x7D0F18
	private void setitem(string key, string x) { }

	// RVA: 0x7D1100
	public bool ContainsKey(string key) { }

	// RVA: 0x7D21BC
	public void Add(string key, string value) { }

	// RVA: 0x7D25EC
	public bool Remove(string key) { }

	// RVA: 0x7D1560
	private IntPtr create_iterator_begin() { }

	// RVA: 0x7D16E0
	private string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x7D1848
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

	// RVA: 0x7D3F88
	public void .ctor(StringList collection) { }

	// RVA: 0x7D4E74
	public string get_Current() { }

	// RVA: 0x7D4F54
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7D4F58
	public bool MoveNext() { }

	// RVA: 0x7D4FE4
	public void Reset() { }

	// RVA: 0x7D5080
	public void Dispose() { }

}

// Namespace: Firebase
internal class StringList
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7D32E0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7D334C
	internal static HandleRef getCPtr(StringList obj) { }

	// RVA: 0x7D339C
	protected override void Finalize() { }

	// RVA: 0x7D343C
	public void Dispose() { }

	// RVA: 0x7D34D0
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7D3688
	public bool get_IsReadOnly() { }

	// RVA: 0x7D3690
	public string get_Item(int index) { }

	// RVA: 0x7D37FC
	public void set_Item(int index, string value) { }

	// RVA: 0x7D3974
	public int get_Count() { }

	// RVA: 0x7D3AF8
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x7D3B3C
	public void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x7D3EE4
	private System.Collections.Generic.IEnumerator<System.String> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x7D3FF8
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7D409C
	public void .ctor() { }

	// RVA: 0x7D422C
	public void Clear() { }

	// RVA: 0x7D43A8
	public void Add(string x) { }

	// RVA: 0x7D3978
	private UInt32 size() { }

	// RVA: 0x7D3D7C
	private string getitemcopy(int index) { }

	// RVA: 0x7D3694
	private string getitem(int index) { }

	// RVA: 0x7D3800
	private void setitem(int index, string val) { }

	// RVA: 0x7D460C
	public void Insert(int index, string x) { }

	// RVA: 0x7D47C8
	public void RemoveAt(int index) { }

	// RVA: 0x7D4954
	public bool Contains(string value) { }

	// RVA: 0x7D4B0C
	public int IndexOf(string value) { }

	// RVA: 0x7D4CBC
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

	// RVA: 0x7D5D10
	public void .ctor(CharVector collection) { }

	// RVA: 0x7D68BC
	public Byte get_Current() { }

	// RVA: 0x7D69AC
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7D69E0
	public bool MoveNext() { }

	// RVA: 0x7D6A90
	public void Reset() { }

	// RVA: 0x7D6B2C
	public void Dispose() { }

}

// Namespace: Firebase
internal class CharVector
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7D5094
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7D5100
	protected override void Finalize() { }

	// RVA: 0x7D51A0
	public void Dispose() { }

	// RVA: 0x7D5234
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7D53EC
	public bool get_IsReadOnly() { }

	// RVA: 0x7D53F4
	public Byte get_Item(int index) { }

	// RVA: 0x7D5550
	public void set_Item(int index, Byte value) { }

	// RVA: 0x7D56B4
	public int get_Count() { }

	// RVA: 0x7D5838
	public void CopyTo(Byte[] array) { }

	// RVA: 0x7D5AD0
	public void CopyTo(Byte[] array, int arrayIndex) { }

	// RVA: 0x7D5870
	public void CopyTo(int index, Byte[] array, int arrayIndex, int count) { }

	// RVA: 0x7D5C6C
	private System.Collections.Generic.IEnumerator<System.Byte> global::System.Collections.Generic.IEnumerable<System.Byte>.GetEnumerator() { }

	// RVA: 0x7D5D80
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7D5E24
	public void Clear() { }

	// RVA: 0x7D5FA0
	public void Add(Byte x) { }

	// RVA: 0x7D56B8
	private UInt32 size() { }

	// RVA: 0x7D5B14
	private Byte getitemcopy(int index) { }

	// RVA: 0x7D53F8
	private Byte getitem(int index) { }

	// RVA: 0x7D5554
	private void setitem(int index, Byte val) { }

	// RVA: 0x7D615C
	public void Insert(int index, Byte x) { }

	// RVA: 0x7D62CC
	public void RemoveAt(int index) { }

	// RVA: 0x7D6458
	public bool Contains(Byte value) { }

	// RVA: 0x7D65D8
	public int IndexOf(Byte value) { }

	// RVA: 0x7D673C
	public bool Remove(Byte value) { }

}

// Namespace: 
public sealed class Action
{
	// Methods

	// RVA: 0x7D7534
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7D7DF4
	public virtual void Invoke() { }

}

// Namespace: 
internal sealed class SWIG_CompletionDelegate
{
	// Methods

	// RVA: 0x7D79B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7D7E08
	public virtual void Invoke(int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public FutureVoid fu; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Int32> tcs; // 0x18

	// Methods

	// RVA: 0x7D752C
	public void .ctor() { }

	// RVA: 0x7D7E1C
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

	// RVA: 0x7D6D5C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7D6E5C
	public override void Dispose(bool disposing) { }

	// RVA: 0x7D71B0
	public static Task GetTask(FutureVoid fu) { }

	// RVA: 0x7D7948
	private void ThrowIfDisposed() { }

	// RVA: 0x7D75D4
	public void SetOnCompletionCallback(Action userCompletionCallback) { }

	// RVA: 0x7D702C
	private void SetCompletionData(IntPtr data) { }

	// RVA: 0x7D6B40
	private static void SWIG_CompletionDispatcher(int key) { }

	// RVA: 0x7D7A54
	internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key) { }

	// RVA: 0x7D7BC4
	public static void SWIG_FreeCompletionData(IntPtr data) { }

	// RVA: 0x7D7D68
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

	// RVA: 0x7DDA10
	public string get_CppModuleName() { }

	// RVA: 0x7DDA18
	public void set_CppModuleName(string value) { }

	// RVA: 0x7DDA20
	public string get_CSharpClassName() { }

	// RVA: 0x7DDA28
	public void set_CSharpClassName(string value) { }

	// RVA: 0x7DDA30
	public bool get_AlwaysEnable() { }

	// RVA: 0x7DDA38
	public void set_AlwaysEnable(bool value) { }

	// RVA: 0x7DB724
	public void .ctor(string csharp, string cpp, bool always) { }

}

// Namespace: 
private sealed class CreateDelegate
{
	// Methods

	// RVA: 0x7D92A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7DDA40
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

	// RVA: 0x7DDA54
	private static void .cctor() { }

	// RVA: 0x7DDAC0
	public void .ctor() { }

	// RVA: 0x7DDAC8
	internal FirebaseApp <Create>b__15_0() { }

	// RVA: 0x7DDB30
	internal bool <CreateAndTrack>b__48_0() { }

	// RVA: 0x7DDB98
	internal DependencyStatus <CheckDependenciesAsync>b__56_0() { }

	// RVA: 0x7DDC20
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> checkTask) { }

	// RVA: 0x7DDDD4
	internal System.Threading.Tasks.Task<Firebase.DependencyStatus> <CheckAndFixDependenciesAsync>b__57_1(Task t) { }

	// RVA: 0x7DDE3C
	internal void <FixDependenciesAsync>b__60_1(Task t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public DependencyStatus status; // 0x10

	// Methods

	// RVA: 0x7DCD18
	public void .ctor() { }

	// RVA: 0x7DDEE4
	internal void <CheckDependencies>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass60_0
{
	// Fields
	public Task task; // 0x10

	// Methods

	// RVA: 0x7DD298
	public void .ctor() { }

	// RVA: 0x7DDF6C
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

	// RVA: 0x7D80FC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7D8178
	internal static HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x7D81C8
	protected override void Finalize() { }

	// RVA: 0x7D8348
	public void Dispose() { }

	// RVA: 0x7D825C
	public void Dispose(bool disposing) { }

	// RVA: 0x7D8814
	private static void .cctor() { }

	// RVA: 0x7D8A00
	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x7D8B58
	public static FirebaseApp get_DefaultInstance() { }

	// RVA: 0x7D8D48
	public static FirebaseApp GetInstance(string name) { }

	// RVA: 0x7D8F2C
	public static FirebaseApp Create() { }

	// RVA: 0x7DA154
	public string get_Name() { }

	// RVA: 0x7DA25C
	public static LogLevel get_LogLevel() { }

	// RVA: 0x7DA2C8
	public static void set_LogLevel(LogLevel value) { }

	// RVA: 0x7DA34C
	private void AddReference() { }

	// RVA: 0x7D8548
	private void RemoveReference() { }

	// RVA: 0x7DA1F4
	private void ThrowIfNull() { }

	// RVA: 0x7DA8BC
	private static void InitializeAppUtilCallbacks() { }

	// RVA: 0x7DA6C8
	private static void OnAllAppsDestroyed() { }

	// RVA: 0x7DBBA8
	internal static Uri UrlStringToUri(string urlString) { }

	// RVA: 0x7DBCA0
	private static bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x7D9348
	private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x7DC63C
	private static void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x7D90DC
	private static void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x7DC514
	private static bool IsCheckDependenciesRunning() { }

	// RVA: 0x7DC858
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x7DCABC
	public static System.Threading.Tasks.Task<Firebase.DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x7DCC3C
	private static DependencyStatus CheckDependencies() { }

	// RVA: 0x7DCD20
	private static DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x7DD1A4
	public static Task FixDependenciesAsync() { }

	// RVA: 0x7DD2A0
	private static void ResetDefaultAppCPtr() { }

	// RVA: 0x7D83E8
	internal string get_NameInternal() { }

	// RVA: 0x7DD7C0
	internal static FirebaseApp CreateInternal() { }

	// RVA: 0x7DA504
	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x7DC074
	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x7DC350
	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x7DC1FC
	internal static void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x7D8BF4
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
public sealed class VariantVariantMapEnumerator
{
	// Fields
	private VariantVariantMap collectionRef; // 0x10
	private System.Collections.Generic.IList<Firebase.Variant> keyCollection; // 0x18
	private int currentIndex; // 0x20
	private object currentObject; // 0x28
	private int currentSize; // 0x30

	// Methods

	// RVA: 0x7E0448
	public void .ctor(VariantVariantMap collection) { }

	// RVA: 0x7DF600
	public System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant> get_Current() { }

	// RVA: 0x7E0868
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7DF714
	public bool MoveNext() { }

	// RVA: 0x7E08D4
	public void Reset() { }

	// RVA: 0x7E0970
	public void Dispose() { }

}

// Namespace: Firebase
internal class VariantVariantMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7DE15C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7DE1C8
	protected override void Finalize() { }

	// RVA: 0x7DE268
	public void Dispose() { }

	// RVA: 0x7DE2FC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7DE4B4
	public Variant get_Item(Variant key) { }

	// RVA: 0x7DE6A0
	public void set_Item(Variant key, Variant value) { }

	// RVA: 0x7DE878
	public bool TryGetValue(Variant key, Variant value) { }

	// RVA: 0x7DEA78
	public int get_Count() { }

	// RVA: 0x7DEBFC
	public bool get_IsReadOnly() { }

	// RVA: 0x7DEC04
	public System.Collections.Generic.ICollection<Firebase.Variant> get_Keys() { }

	// RVA: 0x7DF228
	public System.Collections.Generic.ICollection<Firebase.Variant> get_Values() { }

	// RVA: 0x7DF8A0
	public void Add(System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant> item) { }

	// RVA: 0x7DFBF0
	public bool Remove(System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant> item) { }

	// RVA: 0x7DFD10
	public bool Contains(System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant> item) { }

	// RVA: 0x7E0034
	public void CopyTo(System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant>[] array, int arrayIndex) { }

	// RVA: 0x7E03E4
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Firebase.Variant,Firebase.Variant>>.GetEnumerator() { }

	// RVA: 0x7E0530
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7DF59C
	public VariantVariantMapEnumerator GetEnumerator() { }

	// RVA: 0x7DEA7C
	private UInt32 size() { }

	// RVA: 0x7E059C
	public void Clear() { }

	// RVA: 0x7DE4B8
	private Variant getitem(Variant key) { }

	// RVA: 0x7DE6A4
	private void setitem(Variant key, Variant x) { }

	// RVA: 0x7DE8D8
	public bool ContainsKey(Variant key) { }

	// RVA: 0x7DFA1C
	public void Add(Variant key, Variant value) { }

	// RVA: 0x7DFE94
	public bool Remove(Variant key) { }

	// RVA: 0x7DED68
	private IntPtr create_iterator_begin() { }

	// RVA: 0x7DEEE8
	private Variant get_next_key(IntPtr swigiterator) { }

	// RVA: 0x7DF0A8
	private void destroy_iterator(IntPtr swigiterator) { }

}

// Namespace: 
public sealed class VariantListEnumerator
{
	// Fields
	private VariantList collectionRef; // 0x10
	private int currentIndex; // 0x18
	private object currentObject; // 0x20
	private int currentSize; // 0x28

	// Methods

	// RVA: 0x7E1110
	public void .ctor(VariantList collection) { }

	// RVA: 0x7E1568
	public Variant get_Current() { }

	// RVA: 0x7E1688
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7E168C
	public bool MoveNext() { }

	// RVA: 0x7E1718
	public void Reset() { }

	// RVA: 0x7E17B4
	public void Dispose() { }

}

// Namespace: Firebase
internal class VariantList
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7E0984
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7E09F0
	internal static HandleRef getCPtr(VariantList obj) { }

	// RVA: 0x7E0A40
	protected override void Finalize() { }

	// RVA: 0x7E0ADC
	public void Dispose() { }

	// RVA: 0x7E0B6C
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7E0D24
	public Variant get_Item(int index) { }

	// RVA: 0x7E0EE8
	public int get_Count() { }

	// RVA: 0x7E106C
	private System.Collections.Generic.IEnumerator<Firebase.Variant> global::System.Collections.Generic.IEnumerable<Firebase.Variant>.GetEnumerator() { }

	// RVA: 0x7E1180
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7E1224
	public void .ctor() { }

	// RVA: 0x7E13B4
	public void Add(Variant x) { }

	// RVA: 0x7E0EEC
	private UInt32 size() { }

	// RVA: 0x7E0D28
	private Variant getitem(int index) { }

}

// Namespace: Firebase
internal class Variant
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7E0774
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7E0718
	internal static HandleRef getCPtr(Variant obj) { }

	// RVA: 0x7E17C8
	protected override void Finalize() { }

	// RVA: 0x7E1864
	public void Dispose() { }

	// RVA: 0x7E18F4
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7E1AAC
	public static Variant FromBlob(Byte[] blob) { }

	// RVA: 0x7E1E74
	public static Variant FromObject(object o) { }

	// RVA: 0x7E257C
	public static Variant Null() { }

	// RVA: 0x7E2DFC
	public static Variant EmptyVector() { }

	// RVA: 0x7E3154
	public static Variant EmptyMap() { }

	// RVA: 0x7E1B44
	public static Variant EmptyMutableBlob(UInt32 sizeBytes) { }

	// RVA: 0x7E2FA4
	public VariantList vector() { }

	// RVA: 0x7E32FC
	public VariantVariantMap map() { }

	// RVA: 0x7E28E4
	public static Variant FromInt64(Int64 value) { }

	// RVA: 0x7E2A94
	public static Variant FromDouble(Double value) { }

	// RVA: 0x7E2C4C
	public static Variant FromBool(bool value) { }

	// RVA: 0x7E2724
	public static Variant FromString(string value) { }

	// RVA: 0x7E1CF4
	public IntPtr untyped_mutable_blob_data() { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7E4D88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7E4EF8
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7E4E3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7E4F0C
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

	// RVA: 0x7E3FF0
	public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7E40F8
	public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7E3680
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7E3718
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7E37B0
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7E3848
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7E38E0
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7E3978
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7E3A10
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7E3AA8
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7E3B40
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7E3BD8
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7E3C70
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7E3D08
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7E3DA8
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7E3ECC
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7E4370
	private static void .cctor() { }

	// RVA: 0x7E35D8
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

	// RVA: 0x7D044C
	public static bool get_Pending() { }

	// RVA: 0x7E4148
	public static void Set(Exception e) { }

	// RVA: 0x7D04FC
	public static Exception Retrieve() { }

	// RVA: 0x7E4F20
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7E5124
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7E51D8
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7E4FD8
	public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7E4FD4
	private static string CreateString(string cString) { }

	// RVA: 0x7E4FEC
	private static void .cctor() { }

	// RVA: 0x7E35E0
	public void .ctor() { }

}

// Namespace: Firebase
internal class AppUtilPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7E3514
	private static void .cctor() { }

	// RVA: 0x7D02BC
	public static extern void delete_FutureBase(HandleRef jarg1) { }

	// RVA: 0x7D0444
	public static extern int FutureBase_status(HandleRef jarg1) { }

	// RVA: 0x7D084C
	public static extern int FutureBase_error(HandleRef jarg1) { }

	// RVA: 0x7D09B4
	public static extern string FutureBase_error_message(HandleRef jarg1) { }

	// RVA: 0x7D2E48
	public static extern IntPtr new_StringStringMap__SWIG_0() { }

	// RVA: 0x7D2E4C
	public static extern UInt32 StringStringMap_size(HandleRef jarg1) { }

	// RVA: 0x7D2FC8
	public static extern void StringStringMap_Clear(HandleRef jarg1) { }

	// RVA: 0x7D2FD0
	public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D302C
	public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x7D3088
	public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D30D0
	public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3) { }

	// RVA: 0x7D312C
	public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D3174
	public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x7D317C
	public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7D31B8
	public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7D0D8C
	public static extern void delete_StringStringMap(HandleRef jarg1) { }

	// RVA: 0x7D4228
	public static extern IntPtr new_StringList__SWIG_0() { }

	// RVA: 0x7D43A0
	public static extern void StringList_Clear(HandleRef jarg1) { }

	// RVA: 0x7D450C
	public static extern void StringList_Add(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D4544
	public static extern UInt32 StringList_size(HandleRef jarg1) { }

	// RVA: 0x7D454C
	public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D4588
	public static extern string StringList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D45C4
	public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7D4780
	public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3) { }

	// RVA: 0x7D4948
	public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D4AC4
	public static extern bool StringList_Contains(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D4C78
	public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D4E2C
	public static extern bool StringList_Remove(HandleRef jarg1, string jarg2) { }

	// RVA: 0x7D3680
	public static extern void delete_StringList(HandleRef jarg1) { }

	// RVA: 0x7D5F98
	public static extern void CharVector_Clear(HandleRef jarg1) { }

	// RVA: 0x7D6120
	public static extern void CharVector_Add(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7D612C
	public static extern UInt32 CharVector_size(HandleRef jarg1) { }

	// RVA: 0x7D6134
	public static extern Byte CharVector_getitemcopy(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D6140
	public static extern Byte CharVector_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D614C
	public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7D62BC
	public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, Byte jarg3) { }

	// RVA: 0x7D644C
	public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7D65B4
	public static extern bool CharVector_Contains(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7D6730
	public static extern int CharVector_IndexOf(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7D6898
	public static extern bool CharVector_Remove(HandleRef jarg1, Byte jarg2) { }

	// RVA: 0x7D53E4
	public static extern void delete_CharVector(HandleRef jarg1) { }

	// RVA: 0x7D7D30
	public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, SWIG_CompletionDelegate jarg2, int jarg3) { }

	// RVA: 0x7D7D64
	public static extern void FutureVoid_SWIG_FreeCompletionData(IntPtr jarg1) { }

	// RVA: 0x7D71A8
	public static extern void delete_FutureVoid(HandleRef jarg1) { }

	// RVA: 0x7DD788
	public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1) { }

	// RVA: 0x7DD62C
	public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0() { }

	// RVA: 0x7DD99C
	internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1) { }

	// RVA: 0x7DA348
	internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1) { }

	// RVA: 0x7DA2C4
	internal static extern int FirebaseApp_GetLogLevelInternal() { }

	// RVA: 0x7DD9A4
	internal static extern void FirebaseApp_RegisterLibrariesInternal(HandleRef jarg1) { }

	// RVA: 0x7DD9AC
	internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1) { }

	// RVA: 0x7DD9B4
	public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1) { }

	// RVA: 0x7DD9DC
	public static extern string FirebaseApp_DefaultName_get() { }

	// RVA: 0x7E35E8
	public static extern void PollCallbacks() { }

	// RVA: 0x7E35EC
	public static extern void AppEnableLogCallback(bool jarg1) { }

	// RVA: 0x7E35F0
	public static extern void SetEnabledAllAppCallbacks(bool jarg1) { }

	// RVA: 0x7E35F4
	public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2) { }

	// RVA: 0x7E3624
	public static extern bool GetEnabledAppCallbackByName(string jarg1) { }

	// RVA: 0x7E365C
	public static extern void SetLogFunction(LogMessageDelegate jarg1) { }

	// RVA: 0x7E3670
	public static extern int CheckAndroidDependencies() { }

	// RVA: 0x7E3674
	public static extern IntPtr FixAndroidDependencies() { }

	// RVA: 0x7E3678
	internal static extern void InitializePlayServicesInternal() { }

	// RVA: 0x7E367C
	internal static extern void TerminatePlayServicesInternal() { }

	// RVA: 0x7E0594
	public static extern UInt32 VariantVariantMap_size(HandleRef jarg1) { }

	// RVA: 0x7E0710
	public static extern void VariantVariantMap_Clear(HandleRef jarg1) { }

	// RVA: 0x7E0768
	public static extern IntPtr VariantVariantMap_getitem(HandleRef jarg1, HandleRef jarg2) { }

	// RVA: 0x7E07E0
	public static extern void VariantVariantMap_setitem(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) { }

	// RVA: 0x7E07F0
	public static extern bool VariantVariantMap_ContainsKey(HandleRef jarg1, HandleRef jarg2) { }

	// RVA: 0x7E0814
	public static extern void VariantVariantMap_Add(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3) { }

	// RVA: 0x7E0824
	public static extern bool VariantVariantMap_Remove(HandleRef jarg1, HandleRef jarg2) { }

	// RVA: 0x7E0848
	public static extern IntPtr VariantVariantMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x7E0850
	public static extern IntPtr VariantVariantMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7E085C
	public static extern void VariantVariantMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7DE4AC
	public static extern void delete_VariantVariantMap(HandleRef jarg1) { }

	// RVA: 0x7E13B0
	public static extern IntPtr new_VariantList__SWIG_0() { }

	// RVA: 0x7E1548
	public static extern void VariantList_Add(HandleRef jarg1, HandleRef jarg2) { }

	// RVA: 0x7E1554
	public static extern UInt32 VariantList_size(HandleRef jarg1) { }

	// RVA: 0x7E155C
	public static extern IntPtr VariantList_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7E0D1C
	public static extern void delete_VariantList(HandleRef jarg1) { }

	// RVA: 0x7E1AA4
	public static extern void delete_Variant(HandleRef jarg1) { }

	// RVA: 0x7E34AC
	public static extern IntPtr Variant_Null() { }

	// RVA: 0x7E34B0
	public static extern IntPtr Variant_EmptyVector() { }

	// RVA: 0x7E34B4
	public static extern IntPtr Variant_EmptyMap() { }

	// RVA: 0x7E34B8
	public static extern IntPtr Variant_EmptyMutableBlob(UInt32 jarg1) { }

	// RVA: 0x7E34BC
	public static extern IntPtr Variant_vector__SWIG_0(HandleRef jarg1) { }

	// RVA: 0x7E34C4
	public static extern IntPtr Variant_map__SWIG_0(HandleRef jarg1) { }

	// RVA: 0x7E34CC
	public static extern IntPtr Variant_FromInt64(Int64 jarg1) { }

	// RVA: 0x7E34D0
	public static extern IntPtr Variant_FromDouble(Double jarg1) { }

	// RVA: 0x7E34D4
	public static extern IntPtr Variant_FromBool(bool jarg1) { }

	// RVA: 0x7E34D8
	public static extern IntPtr Variant_FromString(string jarg1) { }

	// RVA: 0x7E350C
	public static extern IntPtr Variant_untyped_mutable_blob_data(HandleRef jarg1) { }

	// RVA: 0x7D6E58
	public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1) { }

}

// Namespace: Firebase
internal class AppUtil
{
	// Methods

	// RVA: 0x7E51EC
	internal static void PollCallbacks() { }

	// RVA: 0x7CF944
	internal static void AppEnableLogCallback(bool arg0) { }

	// RVA: 0x7DB780
	internal static void SetEnabledAllAppCallbacks(bool arg0) { }

	// RVA: 0x7DBA4C
	internal static void SetEnabledAppCallbackByName(string arg0, bool arg1) { }

	// RVA: 0x7DB8EC
	internal static bool GetEnabledAppCallbackByName(string arg0) { }

	// RVA: 0x7CFC18
	internal static void SetLogFunction(LogMessageDelegate arg0) { }

	// RVA: 0x7DD038
	public static GooglePlayServicesAvailability CheckAndroidDependencies() { }

	// RVA: 0x7DE0A8
	public static Task FixAndroidDependenciesAsync() { }

	// RVA: 0x7DD4D4
	internal static void InitializePlayServicesInternal() { }

	// RVA: 0x7DD630
	internal static void TerminatePlayServicesInternal() { }

}

// Namespace: Firebase
internal class VersionInfo
{
	// Methods

	// RVA: 0x7DBFEC
	internal static string get_SdkVersion() { }

	// RVA: 0x7DC030
	internal static string get_BuildSource() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppUtils
{
	// Fields
	private static FirebaseAppUtils instance; // 0x0

	// Methods

	// RVA: 0x7DBF70
	public static FirebaseAppUtils get_Instance() { }

	// RVA: 0x7E5344
	public void TranslateDllNotFoundException(Action action) { }

	// RVA: 0x7E53C4
	public void PollCallbacks() { }

	// RVA: 0x7E53C8
	public PlatformLogLevel GetLogLevel() { }

	// RVA: 0x7E5524
	public void .ctor() { }

	// RVA: 0x7E552C
	private static void .cctor() { }

}

// Namespace: Firebase.Platform
internal class FirebaseAppPlatform
{}


