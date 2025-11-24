// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable
{
	// Methods

	// RVA: 0x15F48F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15F4990
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Methods

	// RVA: 0x15F49A4
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x15F4A2C
	public override string get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x15F4A5C
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15F4B28
	protected override void Finalize() { }

	// RVA: 0x15F4C64
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x15F4BF4
	public void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x15F4CD8
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x15F4E88
	public void run() { }

	// RVA: 0x15F4EB0
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }

}

// Namespace: UnityEngine
public class AndroidJavaProxy
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x15F4DFC
	public void .ctor(string javaInterface) { }

	// RVA: 0x15F5484
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x15F54BC
	protected override void Finalize() { }

	// RVA: 0x15F55D0
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x15F6D28
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x15F5008
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x15F7D84
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x15F7E74
	public virtual int hashCode() { }

	// RVA: 0x15F82C4
	public virtual string toString() { }

	// RVA: 0x15F833C
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x15F80E4
	internal IntPtr GetRawProxy() { }

	// RVA: 0x15F8670
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class AndroidJavaObject
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x15F88FC
	public void .ctor(string className, object[] args) { }

	// RVA: 0x15F6B64
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15F79F8
	public void Dispose() { }

	// RVA: 0x15F8C50
	public void Call(string methodName, object[] args) { }

	// RVA: 0x15F8D88
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x26AD93C
	public FieldType GetStatic(string fieldName) { }

	// RVA: 0x15F7D1C
	public IntPtr GetRawObject() { }

	// RVA: 0x15F8ED8
	public IntPtr GetRawClass() { }

	// RVA: 0x15F8F18
	public AndroidJavaObject CloneReference() { }

	// RVA: 0x26AD93C
	public ReturnType Call(string methodName, object[] args) { }

	// RVA: 0x26AD93C
	public ReturnType CallStatic(string methodName, object[] args) { }

	// RVA: 0x15F9220
	protected void DebugPrint(string msg) { }

	// RVA: 0x15F8944
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x15F935C
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x15F893C
	internal void .ctor() { }

	// RVA: 0x15F9904
	protected override void Finalize() { }

	// RVA: 0x15F99A0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15F8CEC
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x15F9B04
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x26AD93C
	protected ReturnType _Call(string methodName, object[] args) { }

	// RVA: 0x26AD93C
	protected ReturnType _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x15F8E24
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x15F9F38
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x26AD93C
	protected ReturnType _CallStatic(string methodName, object[] args) { }

	// RVA: 0x26AD93C
	protected ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x26AD93C
	protected FieldType _GetStatic(string fieldName) { }

	// RVA: 0x26AD93C
	protected FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x15F7C14
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x15FA30C
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x26AD93C
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x26AD93C
	internal static ReturnType FromJavaArray(IntPtr jobject) { }

	// RVA: 0x15F8EC0
	protected IntPtr _GetRawObject() { }

	// RVA: 0x15F8EF8
	protected IntPtr _GetRawClass() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass
{
	// Methods

	// RVA: 0x15F5454
	public void .ctor(string className) { }

	// RVA: 0x15FA414
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x15F9118
	internal void .ctor(IntPtr jclass) { }

}

// Namespace: UnityEngine
internal class AndroidReflection
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x15FA5F8
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x15FA610
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x15FA634
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x15FA790
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x15FA8EC
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x15FABF8
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15FAE18
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15FB038
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x15FB17C
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x15FB310
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x15F6A24
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x15FB44C
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper
{
	// Fields
	private static int FRAME_SIZE_FOR_ARRAYS; // 0x0

	// Methods

	// RVA: 0x15FB76C
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x15FB7F8
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15FB85C
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x15FBAE8
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret) { }

	// RVA: 0x15FD088
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x15F6F64
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x15F60CC
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x15FD9A4
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15FC14C
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x26AD93C
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x15FE42C
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15FE6F8
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x26AD93C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x26AD93C
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x15FE7E8
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x15FEA8C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15FECB8
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15FED64
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15FF1A0
	public static string GetSignature(object obj) { }

	// RVA: 0x15FE518
	public static string GetSignature(object[] args) { }

	// RVA: 0x35293EC
	public static string GetSignature(object[] args) { }

	// RVA: 0x15FFEEC
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct jvalue
{
	// Fields
	public bool z; // 0x10
	public SByte b; // 0x10
	public Char c; // 0x10
	public Int16 s; // 0x10
	public int i; // 0x10
	public Int64 j; // 0x10
	public float f; // 0x10
	public Double d; // 0x10
	public IntPtr l; // 0x10
}

// Namespace: UnityEngine
public static class AndroidJNIHelper
{
	// Methods

	// RVA: 0x15FE66C
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x15F887C
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15FFF3C
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15FCFC8
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15F8478
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x15F96D8
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15FFFFC
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15F92D0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15F9A84
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x26AD93C
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x26AD93C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x26AD93C
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x1600074
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x15F7BA8
	public static IntPtr Box(int value) { }

	// RVA: 0x15F7B3C
	public static IntPtr Box(bool value) { }

}

// Namespace: 
private struct JStringBinding
{
	// Fields
	private IntPtr javaString; // 0x10
	private IntPtr chars; // 0x18
	private int length; // 0x20
	private bool ownsRef; // 0x24

	// Methods

	// RVA: 0x16015D0
	public override string ToString() { }

	// RVA: 0x1604698
	public void Dispose() { }

}

// Namespace: UnityEngine
public static class AndroidJNI
{
	// Methods

	// RVA: 0x160031C
	private static void ReleaseStringChars(JStringBinding str) { }

	// RVA: 0x16003BC
	private static void InvokeAction(Action action) { }

	// RVA: 0x16003E4
	public static IntPtr FindClass(string name) { }

	// RVA: 0x16005BC
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x160060C
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0x160064C
	public static void ExceptionClear() { }

	// RVA: 0x15FF058
	public static int PushLocalFrame(int capacity) { }

	// RVA: 0x15FE29C
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x15F4AD8
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x160068C
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x15F8620
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x15F8428
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x15F7D34
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x16006DC
	public static void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x15F7E0C
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x160072C
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16007C8
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1600820
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x1600870
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1600B34
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1600DF8
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x16010BC
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1601380
	public static IntPtr NewString(string chars) { }

	// RVA: 0x1601384
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x15FB950
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x160155C
	private static JStringBinding GetStringCharsInternal(IntPtr str) { }

	// RVA: 0x16016A0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1601764
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16017DC
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601984
	private static JStringBinding CallStringMethodUnsafeInternal(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601A78
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601B14
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601B6C
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601C08
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601C60
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601CFC
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601D54
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601DF0
	public static Int16 CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601E48
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601EE4
	public static SByte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1601F3C
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1601FD8
	public static Char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602030
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16020CC
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602124
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16021C0
	public static Double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602218
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16022B4
	public static Int64 CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x160230C
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16023A8
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602400
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x16024C4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x160253C
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x16026E4
	private static JStringBinding CallStaticStringMethodUnsafeInternal(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x16027D8
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602874
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x16028CC
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602968
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x16029C0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602A5C
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602AB4
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602B50
	public static Int16 CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602BA8
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602C44
	public static SByte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602C9C
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602D38
	public static Char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602D90
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602E2C
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602E84
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1602F20
	public static Double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1602F78
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1603014
	public static Int64 CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x160306C
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1603108
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1603160
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1603300
	private static JStringBinding GetStaticStringFieldInternal(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x16033D4
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x160343C
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x16034A4
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x160350C
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1603574
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x16035DC
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1603644
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x16036AC
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1603714
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x160377C
	private static IntPtr ConvertToBooleanArray(bool[] array) { }

	// RVA: 0x16038A0
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x16038AC
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x16039D0
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x1603A48
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x1603AB0
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x1603B28
	public static IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x1603B90
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x1603C08
	public static IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x1603C70
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x1603CE8
	public static IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x1603D50
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x1603DC8
	public static IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x1603E30
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x1603EA8
	public static IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x1603F10
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x1603F88
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x1603FF0
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x1604048
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x16040B0
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x1604230
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x16043B0
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x1604400
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x1604450
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x16044A0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x16044F0
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x1604540
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x1604590
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x16045E0
	public static int GetArrayLength(IntPtr array) { }

	// RVA: 0x15FE244
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x1604630
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x15FE2EC
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	// RVA: 0x160036C
	private static void ReleaseStringChars_Injected(JStringBinding str) { }

	// RVA: 0x160056C
	private static IntPtr FindClass_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x1600ADC
	private static IntPtr GetMethodID_Injected(IntPtr clazz, ManagedSpanWrapper name, ManagedSpanWrapper sig) { }

	// RVA: 0x1600DA0
	private static IntPtr GetFieldID_Injected(IntPtr clazz, ManagedSpanWrapper name, ManagedSpanWrapper sig) { }

	// RVA: 0x1601064
	private static IntPtr GetStaticMethodID_Injected(IntPtr clazz, ManagedSpanWrapper name, ManagedSpanWrapper sig) { }

	// RVA: 0x1601328
	private static IntPtr GetStaticFieldID_Injected(IntPtr clazz, ManagedSpanWrapper name, ManagedSpanWrapper sig) { }

	// RVA: 0x160150C
	private static IntPtr NewStringFromStr_Injected(ManagedSpanWrapper chars) { }

	// RVA: 0x1601638
	private static void GetStringCharsInternal_Injected(IntPtr str, JStringBinding ret) { }

	// RVA: 0x1601A10
	private static void CallStringMethodUnsafeInternal_Injected(IntPtr obj, IntPtr methodID, jvalue* args, JStringBinding ret) { }

	// RVA: 0x1602770
	private static void CallStaticStringMethodUnsafeInternal_Injected(IntPtr clazz, IntPtr methodID, jvalue* args, JStringBinding ret) { }

	// RVA: 0x160337C
	private static void GetStaticStringFieldInternal_Injected(IntPtr clazz, IntPtr fieldID, JStringBinding ret) { }

	// RVA: 0x1603850
	private static IntPtr ConvertToBooleanArray_Injected(ManagedSpanWrapper array) { }

	// RVA: 0x1603980
	private static IntPtr ToByteArray_Injected(ManagedSpanWrapper array) { }

	// RVA: 0x16041C8
	private static void FromBooleanArray_Injected(IntPtr array, BlittableArrayWrapper ret) { }

	// RVA: 0x1604348
	private static void FromByteArray_Injected(IntPtr array, BlittableArrayWrapper ret) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe
{
	// Methods

	// RVA: 0x16046FC
	public static void CheckException() { }

	// RVA: 0x15F4C80
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x15F5578
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x15F8BF8
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x15FAAF4
	public static IntPtr NewString(string chars) { }

	// RVA: 0x1604938
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x15F8B54
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x15FA714
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15FA870
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x15FF0A8
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15FF124
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15FE9E8
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x15F8800
	public static IntPtr FindClass(string name) { }

	// RVA: 0x15F9DEC
	public static void PushLocalFrame(int capacity) { }

	// RVA: 0x15F9810
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16049B4
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604A68
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604AE4
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604B98
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604C58
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604D18
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604DCC
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604E80
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604F34
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1604FE8
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15FA220
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15FAB70
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1600228
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15FB288
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x160509C
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16051B8
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16052AC
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16053AC
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16054AC
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x16055A0
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605694
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605788
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15F81D0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15F9E4C
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15FB0F4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x160587C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605970
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605A8C
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605B80
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605C80
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605D80
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605E74
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1605F68
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x160605C
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1606150
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1606244
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x16062E8
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x160638C
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x1606430
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x16064D4
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x1606578
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x16065F4
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x1606698
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x1606714
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x15FE344
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x15FE164
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x15FE084
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x15FDFA4
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x15FDEC4
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x15FDDE4
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x15FDC88
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x15FDD04
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x15FDBEC
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x15FDB0C
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x15F7A88
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x15F4F64
	public static int GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine.Android
public static class AndroidApplication
{
	// Fields
	private static SynchronizationContext m_MainThreadSynchronizationContext; // 0x0
	private static AndroidConfiguration m_CurrentConfiguration; // 0x8
	private static System.Action<UnityEngine.Android.AndroidConfiguration> onConfigurationChanged; // 0x10

	// Methods

	// RVA: 0x15FFFBC
	internal static IntPtr get_UnityPlayerRaw() { }

	// RVA: 0x16067B8
	private static void AcquireMainThreadSynchronizationContext() { }

	// RVA: 0x1606874
	private static void SetCurrentConfiguration(AndroidConfiguration config) { }

	// RVA: 0x16068D0
	private static AndroidConfiguration GetCurrentConfiguration() { }

	// RVA: 0x160691C
	private static void DispatchConfigurationChanged(bool notifySubscribers) { }

}

// Namespace: UnityEngine.Android
public class PermissionCallbacks
{}

// Namespace: UnityEngine.Android
public struct Permission
{
	// Methods

	// RVA: 0x1606990
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x160699C
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x1606A18
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }

}

// Namespace: UnityEngine.Android
public enum AndroidColorModeHdr
{
	// Fields
	public int value__; // 0x10
	public const AndroidColorModeHdr Undefined = 0;
	public const AndroidColorModeHdr No = 4;
	public const AndroidColorModeHdr Yes = 8;
}

// Namespace: UnityEngine.Android
public enum AndroidColorModeWideColorGamut
{
	// Fields
	public int value__; // 0x10
	public const AndroidColorModeWideColorGamut Undefined = 0;
	public const AndroidColorModeWideColorGamut No = 1;
	public const AndroidColorModeWideColorGamut Yes = 2;
}

// Namespace: UnityEngine.Android
public class AndroidLocale
{
	// Fields
	private readonly string <country>k__BackingField; // 0x10
	private readonly string <language>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1606A1C
	public string get_country() { }

	// RVA: 0x1606A24
	public string get_language() { }

	// RVA: 0x1606A2C
	internal void .ctor(string _country, string _language) { }

}

// Namespace: UnityEngine.Android
public sealed class AndroidConfiguration
{
	// Fields
	private int <colorMode>k__BackingField; // 0x10
	private int <densityDpi>k__BackingField; // 0x14
	private float <fontScale>k__BackingField; // 0x18
	private int <fontWeightAdjustment>k__BackingField; // 0x1C
	private AndroidKeyboard <keyboard>k__BackingField; // 0x20
	private AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField; // 0x24
	private AndroidKeyboardHidden <keyboardHidden>k__BackingField; // 0x28
	private int <mobileCountryCode>k__BackingField; // 0x2C
	private int <mobileNetworkCode>k__BackingField; // 0x30
	private AndroidNavigation <navigation>k__BackingField; // 0x34
	private AndroidNavigationHidden <navigationHidden>k__BackingField; // 0x38
	private AndroidOrientation <orientation>k__BackingField; // 0x3C
	private int <screenHeightDp>k__BackingField; // 0x40
	private int <screenWidthDp>k__BackingField; // 0x44
	private int <smallestScreenWidthDp>k__BackingField; // 0x48
	private int <screenLayout>k__BackingField; // 0x4C
	private AndroidTouchScreen <touchScreen>k__BackingField; // 0x50
	private int <uiMode>k__BackingField; // 0x54
	private string <primaryLocaleCountry>k__BackingField; // 0x58
	private string <primaryLocaleLanguage>k__BackingField; // 0x60

	// Methods

	// RVA: 0x1606A7C
	private int get_colorMode() { }

	// RVA: 0x1606A84
	public int get_densityDpi() { }

	// RVA: 0x1606A8C
	public float get_fontScale() { }

	// RVA: 0x1606A94
	public int get_fontWeightAdjustment() { }

	// RVA: 0x1606A9C
	public AndroidKeyboard get_keyboard() { }

	// RVA: 0x1606AA4
	public AndroidHardwareKeyboardHidden get_hardKeyboardHidden() { }

	// RVA: 0x1606AAC
	public AndroidKeyboardHidden get_keyboardHidden() { }

	// RVA: 0x1606AB4
	public int get_mobileCountryCode() { }

	// RVA: 0x1606ABC
	public int get_mobileNetworkCode() { }

	// RVA: 0x1606AC4
	public AndroidNavigation get_navigation() { }

	// RVA: 0x1606ACC
	public AndroidNavigationHidden get_navigationHidden() { }

	// RVA: 0x1606AD4
	public AndroidOrientation get_orientation() { }

	// RVA: 0x1606ADC
	public int get_screenHeightDp() { }

	// RVA: 0x1606AE4
	public int get_screenWidthDp() { }

	// RVA: 0x1606AEC
	public int get_smallestScreenWidthDp() { }

	// RVA: 0x1606AF4
	private int get_screenLayout() { }

	// RVA: 0x1606AFC
	public AndroidTouchScreen get_touchScreen() { }

	// RVA: 0x1606B04
	private int get_uiMode() { }

	// RVA: 0x1606B0C
	private string get_primaryLocaleCountry() { }

	// RVA: 0x1606B14
	private string get_primaryLocaleLanguage() { }

	// RVA: 0x1606B1C
	public AndroidLocale[] get_locales() { }

	// RVA: 0x1606C40
	public AndroidColorModeHdr get_colorModeHdr() { }

	// RVA: 0x1606C4C
	public AndroidColorModeWideColorGamut get_colorModeWideColorGamut() { }

	// RVA: 0x1606C58
	public AndroidScreenLayoutDirection get_screenLayoutDirection() { }

	// RVA: 0x1606C64
	public AndroidScreenLayoutLong get_screenLayoutLong() { }

	// RVA: 0x1606C70
	public AndroidScreenLayoutRound get_screenLayoutRound() { }

	// RVA: 0x1606C7C
	public AndroidScreenLayoutSize get_screenLayoutSize() { }

	// RVA: 0x1606C88
	public AndroidUIModeNight get_uiModeNight() { }

	// RVA: 0x1606C94
	public AndroidUIModeType get_uiModeType() { }

	// RVA: 0x1606CA0
	public override string ToString() { }

}

// Namespace: UnityEngine.Android
public enum AndroidHardwareKeyboardHidden
{
	// Fields
	public int value__; // 0x10
	public const AndroidHardwareKeyboardHidden Undefined = 0;
	public const AndroidHardwareKeyboardHidden No = 1;
	public const AndroidHardwareKeyboardHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidKeyboard
{
	// Fields
	public int value__; // 0x10
	public const AndroidKeyboard Undefined = 0;
	public const AndroidKeyboard NoKeys = 1;
	public const AndroidKeyboard Qwerty = 2;
	public const AndroidKeyboard _12Key = 3;
}

// Namespace: UnityEngine.Android
public enum AndroidKeyboardHidden
{
	// Fields
	public int value__; // 0x10
	public const AndroidKeyboardHidden Undefined = 0;
	public const AndroidKeyboardHidden No = 1;
	public const AndroidKeyboardHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidNavigation
{
	// Fields
	public int value__; // 0x10
	public const AndroidNavigation Undefined = 0;
	public const AndroidNavigation NoNav = 1;
	public const AndroidNavigation Dpad = 2;
	public const AndroidNavigation TrackBall = 3;
	public const AndroidNavigation Wheel = 4;
}

// Namespace: UnityEngine.Android
public enum AndroidNavigationHidden
{
	// Fields
	public int value__; // 0x10
	public const AndroidNavigationHidden Undefined = 0;
	public const AndroidNavigationHidden No = 1;
	public const AndroidNavigationHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidOrientation
{
	// Fields
	public int value__; // 0x10
	public const AndroidOrientation Undefined = 0;
	public const AndroidOrientation Portrait = 1;
	public const AndroidOrientation Landscape = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutDirection
{
	// Fields
	public int value__; // 0x10
	public const AndroidScreenLayoutDirection LTR = 64;
	public const AndroidScreenLayoutDirection RTL = 128;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutLong
{
	// Fields
	public int value__; // 0x10
	public const AndroidScreenLayoutLong Undefined = 0;
	public const AndroidScreenLayoutLong No = 16;
	public const AndroidScreenLayoutLong Yes = 32;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutRound
{
	// Fields
	public int value__; // 0x10
	public const AndroidScreenLayoutRound Undefined = 0;
	public const AndroidScreenLayoutRound No = 256;
	public const AndroidScreenLayoutRound Yes = 512;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutSize
{
	// Fields
	public int value__; // 0x10
	public const AndroidScreenLayoutSize Undefined = 0;
	public const AndroidScreenLayoutSize Small = 1;
	public const AndroidScreenLayoutSize Normal = 2;
	public const AndroidScreenLayoutSize Large = 3;
	public const AndroidScreenLayoutSize XLarge = 4;
}

// Namespace: UnityEngine.Android
public enum AndroidTouchScreen
{
	// Fields
	public int value__; // 0x10
	public const AndroidTouchScreen Undefined = 0;
	public const AndroidTouchScreen NoTouch = 1;
	public const AndroidTouchScreen Finger = 3;
}

// Namespace: UnityEngine.Android
public enum AndroidUIModeNight
{
	// Fields
	public int value__; // 0x10
	public const AndroidUIModeNight Undefined = 0;
	public const AndroidUIModeNight No = 16;
	public const AndroidUIModeNight Yes = 32;
}

// Namespace: UnityEngine.Android
public enum AndroidUIModeType
{
	// Fields
	public int value__; // 0x10
	public const AndroidUIModeType Undefined = 0;
	public const AndroidUIModeType Normal = 1;
	public const AndroidUIModeType Desk = 2;
	public const AndroidUIModeType Car = 3;
	public const AndroidUIModeType Television = 4;
	public const AndroidUIModeType Appliance = 5;
	public const AndroidUIModeType Watch = 6;
	public const AndroidUIModeType VrHeadset = 7;
}


