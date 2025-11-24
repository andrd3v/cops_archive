// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable
{
	// Methods

	// RVA: 0x15B1300
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15B13A0
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Methods

	// RVA: 0x15B13B4
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x15B143C
	public override string get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x15B146C
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15B1538
	protected override void Finalize() { }

	// RVA: 0x15B16C4
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x15B162C
	public void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x15B174C
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x15B18FC
	public void run() { }

	// RVA: 0x15B1924
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

	// RVA: 0x15B1870
	public void .ctor(string javaInterface) { }

	// RVA: 0x15B1F44
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x15B1F7C
	protected override void Finalize() { }

	// RVA: 0x15B20B4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x15B38EC
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x15B1A8C
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x15B4950
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x15B4A40
	public virtual int hashCode() { }

	// RVA: 0x15B4E10
	public virtual string toString() { }

	// RVA: 0x15B4E88
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x15B4C20
	internal IntPtr GetRawProxy() { }

	// RVA: 0x15B50A4
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

	// RVA: 0x15B52A0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x15B36DC
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15B45A4
	public void Dispose() { }

	// RVA: 0x15B55E4
	public void Call(string methodName, object[] args) { }

	// RVA: 0x15B56AC
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x318DB98
	public FieldType GetStatic(string fieldName) { }

	// RVA: 0x15B48E8
	public IntPtr GetRawObject() { }

	// RVA: 0x15B578C
	public IntPtr GetRawClass() { }

	// RVA: 0x15B57CC
	public AndroidJavaObject CloneReference() { }

	// RVA: 0x318DB98
	public ReturnType Call(string methodName, object[] args) { }

	// RVA: 0x318DB98
	public ReturnType CallStatic(string methodName, object[] args) { }

	// RVA: 0x15B5B1C
	protected void DebugPrint(string msg) { }

	// RVA: 0x15B52E8
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x15B5BF8
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x15B52E0
	internal void .ctor() { }

	// RVA: 0x15B60AC
	protected override void Finalize() { }

	// RVA: 0x15B6148
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15B5648
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x15B62B8
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x318DB98
	protected ReturnType _Call(string methodName, object[] args) { }

	// RVA: 0x318DB98
	protected ReturnType _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x15B5710
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x15B6588
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x318DB98
	protected ReturnType _CallStatic(string methodName, object[] args) { }

	// RVA: 0x318DB98
	protected ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x318DB98
	protected FieldType _GetStatic(string fieldName) { }

	// RVA: 0x318DB98
	protected FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x15B47C0
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x15B6858
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x318DB98
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x15B5774
	protected IntPtr _GetRawObject() { }

	// RVA: 0x15B57AC
	protected IntPtr _GetRawClass() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass
{
	// Methods

	// RVA: 0x15B1F14
	public void .ctor(string className) { }

	// RVA: 0x15B6980
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x15B59E8
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

	// RVA: 0x15B6B70
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x15B6B88
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x15B6BAC
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x15B6D68
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x15B6F24
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x15B7268
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15B7488
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15B76A8
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x15B77EC
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x15B7980
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x15B359C
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x15B7ABC
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper
{
	// Methods

	// RVA: 0x15B7DEC
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x15B7E78
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15B7EDC
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x15B8050
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret) { }

	// RVA: 0x15B9320
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x15B3AD8
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x15B2B8C
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x15B9C14
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15B8618
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x318DB98
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x15BA6AC
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15BA7F4
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x318DB98
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x318DB98
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x15BA838
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x15BAAFC
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15BAD34
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15BADE0
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15BB2AC
	public static string GetSignature(object obj) { }

	// RVA: 0x15BA6D8
	public static string GetSignature(object[] args) { }

	// RVA: 0x30D77E4
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

	// RVA: 0x15BA7F0
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x15B529C
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15BBFD0
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15B92BC
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x15B4EEC
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x15B5E9C
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15BC014
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x15B5BCC
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15B6274
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x318DB98
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x318DB98
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x318DB98
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x15BC018
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x15B4754
	public static IntPtr Box(int value) { }

	// RVA: 0x15B46E8
	public static IntPtr Box(bool value) { }

}

// Namespace: UnityEngine
public static class AndroidJNI
{
	// Methods

	// RVA: 0x15BC314
	public static IntPtr FindClass(string name) { }

	// RVA: 0x15BC364
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x15BC3B4
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0x15BC3F4
	public static void ExceptionClear() { }

	// RVA: 0x15BB0E4
	public static int PushLocalFrame(int capacity) { }

	// RVA: 0x15BC434
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x15B14E8
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x15BC484
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x15B5054
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x15B4E9C
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x15B4900
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x15BC4D4
	public static void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x15B49D8
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x15BC524
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BC5C0
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BC618
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x15BC668
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BC6C0
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BC718
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BC770
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BC7C8
	public static IntPtr NewString(string chars) { }

	// RVA: 0x15BC818
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x15B8000
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x15BC868
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x15BC950
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BC9EC
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCA44
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCAE0
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCB38
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCBD4
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCC2C
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCCC8
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCD20
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCDBC
	public static Int16 CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCE14
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCEB0
	public static SByte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCF08
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BCFA4
	public static Char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BCFFC
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD098
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD0F0
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD18C
	public static Double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD1E4
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD280
	public static Int64 CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD2D8
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD374
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD3CC
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x15BD4B4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD550
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD5A8
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD644
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD69C
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD738
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD790
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD82C
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD884
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BD920
	public static Int16 CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BD978
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDA14
	public static SByte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDA6C
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDB08
	public static Char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDB60
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDBFC
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDC54
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDCF0
	public static Double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDD48
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDDE4
	public static Int64 CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDE3C
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BDED8
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x15BDF30
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BDF98
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE000
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE068
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE0D0
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE138
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE1A0
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE208
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE270
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE2D8
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BE340
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x15BE390
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x15BE3E0
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x15BE458
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x15BE4C0
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x15BE538
	public static IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x15BE5A0
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x15BE618
	public static IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x15BE680
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x15BE6F8
	public static IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x15BE760
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x15BE7D8
	public static IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x15BE840
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x15BE8B8
	public static IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x15BE920
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x15BE998
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x15BEA00
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x15BEA58
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x15BEAC0
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x15BEB10
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x15BEB60
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x15BEBB0
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x15BEC00
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x15BEC50
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x15BECA0
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x15BECF0
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x15BED40
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x15BED90
	public static int GetArrayLength(IntPtr array) { }

	// RVA: 0x15BA514
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x15BEDE0
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x15BA56C
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe
{
	// Methods

	// RVA: 0x15BEE48
	public static void CheckException() { }

	// RVA: 0x15B16E0
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x15B2048
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x15B5578
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x15B713C
	public static IntPtr NewString(string chars) { }

	// RVA: 0x15BF130
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x15B54D4
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x15B6CAC
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15B6E68
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x15BB134
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BB1F0
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15BAA58
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x15B51F8
	public static IntPtr FindClass(string name) { }

	// RVA: 0x15B5FB8
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BF1D4
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF288
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF33C
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF3F0
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF4B0
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF570
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF624
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF6D8
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF78C
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15BF840
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15B676C
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15B71E0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x15BC220
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15B78F8
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x15BF8F4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BF9E8
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFADC
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFBDC
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFCDC
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFDD0
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFEC4
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15BFFB8
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15B4D1C
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15B649C
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15B7764
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x15C00AC
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C01A0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0294
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0388
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0488
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0588
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C067C
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0770
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0864
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0958
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15C0A4C
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x15C0AF0
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x15C0B94
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x15C0C38
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x15C0CDC
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x15C0D80
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x15C0E24
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x15C0EC8
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x15C0F6C
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x15BA5C4
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x15BA434
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x15BA354
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x15BA274
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x15BA194
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x15BA0B4
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x15B9F30
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x15B9FD4
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x15B9E8C
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x15B9DAC
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x15B4634
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x15B19E8
	public static int GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine.Android
internal static class AndroidApp
{
	// Methods

	// RVA: 0x15BBFD4
	public static IntPtr get_UnityPlayerRaw() { }

}

// Namespace: UnityEngine.Android
public class PermissionCallbacks
{}

// Namespace: UnityEngine.Android
public struct Permission
{
	// Methods

	// RVA: 0x15C1010
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x15C101C
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x15C1098
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }

}


