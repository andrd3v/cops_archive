// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable
{
	// Methods

	// RVA: 0x157EE08
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x157EEA8
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Methods

	// RVA: 0x157EEBC
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x157EF44
	public override string get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x157EF74
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x157F040
	protected override void Finalize() { }

	// RVA: 0x157F1CC
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x157F134
	public void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x157F254
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x157F404
	public void run() { }

	// RVA: 0x157F42C
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

	// RVA: 0x157F378
	public void .ctor(string javaInterface) { }

	// RVA: 0x157FA4C
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x157FA84
	protected override void Finalize() { }

	// RVA: 0x157FBBC
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x15813F4
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x157F594
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x1582458
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x1582548
	public virtual int hashCode() { }

	// RVA: 0x1582918
	public virtual string toString() { }

	// RVA: 0x1582990
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x1582728
	internal IntPtr GetRawProxy() { }

	// RVA: 0x1582BAC
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

	// RVA: 0x1582DA8
	public void .ctor(string className, object[] args) { }

	// RVA: 0x15811E4
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15820AC
	public void Dispose() { }

	// RVA: 0x15830EC
	public void Call(string methodName, object[] args) { }

	// RVA: 0x15831B4
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x315B3A8
	public FieldType GetStatic(string fieldName) { }

	// RVA: 0x15823F0
	public IntPtr GetRawObject() { }

	// RVA: 0x1583294
	public IntPtr GetRawClass() { }

	// RVA: 0x15832D4
	public AndroidJavaObject CloneReference() { }

	// RVA: 0x315B3A8
	public ReturnType Call(string methodName, object[] args) { }

	// RVA: 0x315B3A8
	public ReturnType CallStatic(string methodName, object[] args) { }

	// RVA: 0x1583624
	protected void DebugPrint(string msg) { }

	// RVA: 0x1582DF0
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x1583700
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x1582DE8
	internal void .ctor() { }

	// RVA: 0x1583BB4
	protected override void Finalize() { }

	// RVA: 0x1583C50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1583150
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x1583DC0
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x315B3A8
	protected ReturnType _Call(string methodName, object[] args) { }

	// RVA: 0x315B3A8
	protected ReturnType _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x1583218
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x1584090
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x315B3A8
	protected ReturnType _CallStatic(string methodName, object[] args) { }

	// RVA: 0x315B3A8
	protected ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x315B3A8
	protected FieldType _GetStatic(string fieldName) { }

	// RVA: 0x315B3A8
	protected FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x15822C8
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x1584360
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x315B3A8
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x158327C
	protected IntPtr _GetRawObject() { }

	// RVA: 0x15832B4
	protected IntPtr _GetRawClass() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass
{
	// Methods

	// RVA: 0x157FA1C
	public void .ctor(string className) { }

	// RVA: 0x1584488
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x15834F0
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

	// RVA: 0x1584678
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x1584690
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x15846B4
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1584870
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1584A2C
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x1584D70
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1584F90
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15851B0
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x15852F4
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x1585488
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x15810A4
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x15855C4
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper
{
	// Methods

	// RVA: 0x15858F4
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x1585980
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15859E4
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x1585B58
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret) { }

	// RVA: 0x1586E28
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x15815E0
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x1580694
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x158771C
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x1586120
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x315B3A8
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x15881B4
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15882FC
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x315B3A8
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x315B3A8
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x1588340
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x1588604
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x158883C
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15888E8
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x1588DB4
	public static string GetSignature(object obj) { }

	// RVA: 0x15881E0
	public static string GetSignature(object[] args) { }

	// RVA: 0x30A52D0
	public static string GetSignature(object[] args) { }

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

	// RVA: 0x15882F8
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x1582DA4
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1589AD8
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x1586DC4
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15829F4
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x15839A4
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x1589B1C
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15836D4
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x1583D7C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x315B3A8
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x315B3A8
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x315B3A8
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x1589B20
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x158225C
	public static IntPtr Box(int value) { }

	// RVA: 0x15821F0
	public static IntPtr Box(bool value) { }

}

// Namespace: UnityEngine
public static class AndroidJNI
{
	// Methods

	// RVA: 0x1589E1C
	public static IntPtr FindClass(string name) { }

	// RVA: 0x1589E6C
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x1589EBC
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0x1589EFC
	public static void ExceptionClear() { }

	// RVA: 0x1588BEC
	public static int PushLocalFrame(int capacity) { }

	// RVA: 0x1589F3C
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x157EFF0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x1589F8C
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x1582B5C
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x15829A4
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x1582408
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x1589FDC
	public static void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x15824E0
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x158A02C
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A0C8
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A120
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x158A170
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x158A1C8
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x158A220
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x158A278
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x158A2D0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x158A320
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x1585B08
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x158A370
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x158A458
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A4F4
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A54C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A5E8
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A640
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A6DC
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A734
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A7D0
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A828
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A8C4
	public static Int16 CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158A91C
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158A9B8
	public static SByte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158AA10
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158AAAC
	public static Char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158AB04
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158ABA0
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158ABF8
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158AC94
	public static Double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158ACEC
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158AD88
	public static Int64 CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158ADE0
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158AE7C
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158AED4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x158AFBC
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B058
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B0B0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B14C
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B1A4
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B240
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B298
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B334
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B38C
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B428
	public static Int16 CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B480
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B51C
	public static SByte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B574
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B610
	public static Char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B668
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B704
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B75C
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B7F8
	public static Double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B850
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B8EC
	public static Int64 CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158B944
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158B9E0
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x158BA38
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BAA0
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BB08
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BB70
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BBD8
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BC40
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BCA8
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BD10
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BD78
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BDE0
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158BE48
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x158BE98
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x158BEE8
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x158BF60
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x158BFC8
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x158C040
	public static IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x158C0A8
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x158C120
	public static IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x158C188
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x158C200
	public static IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x158C268
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x158C2E0
	public static IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x158C348
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x158C3C0
	public static IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x158C428
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x158C4A0
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x158C508
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x158C560
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x158C5C8
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x158C618
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x158C668
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x158C6B8
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x158C708
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x158C758
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x158C7A8
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x158C7F8
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x158C848
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x158C898
	public static int GetArrayLength(IntPtr array) { }

	// RVA: 0x158801C
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x158C8E8
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x1588074
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe
{
	// Methods

	// RVA: 0x158C950
	public static void CheckException() { }

	// RVA: 0x157F1E8
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x157FB50
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x1583080
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x1584C44
	public static IntPtr NewString(string chars) { }

	// RVA: 0x158CC38
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x1582FDC
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x15847B4
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1584970
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x1588C3C
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1588CF8
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1588560
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x1582D00
	public static IntPtr FindClass(string name) { }

	// RVA: 0x1583AC0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158CCDC
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158CD90
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158CE44
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158CEF8
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158CFB8
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158D078
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158D12C
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158D1E0
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158D294
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x158D348
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1584274
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1584CE8
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1589D28
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1585400
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x158D3FC
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D4F0
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D5E4
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D6E4
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D7E4
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D8D8
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158D9CC
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158DAC0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1582824
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1583FA4
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158526C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x158DBB4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158DCA8
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158DD9C
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158DE90
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158DF90
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E090
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E184
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E278
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E36C
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E460
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x158E554
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x158E5F8
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x158E69C
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x158E740
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x158E7E4
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x158E888
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x158E92C
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x158E9D0
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x158EA74
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x15880CC
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x1587F3C
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x1587E5C
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x1587D7C
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x1587C9C
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x1587BBC
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x1587A38
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x1587ADC
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x1587994
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x15878B4
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x158213C
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x157F4F0
	public static int GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine.Android
internal static class AndroidApp
{
	// Methods

	// RVA: 0x1589ADC
	public static IntPtr get_UnityPlayerRaw() { }

}

// Namespace: UnityEngine.Android
public class PermissionCallbacks
{}

// Namespace: UnityEngine.Android
public struct Permission
{
	// Methods

	// RVA: 0x158EB18
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x158EB24
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x158EBA0
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }

}


