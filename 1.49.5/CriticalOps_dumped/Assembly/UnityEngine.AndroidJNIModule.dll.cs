// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable
{
	// Methods

	// RVA: 0x158E138
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x158E1D8
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Methods

	// RVA: 0x158E1EC
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x158E274
	public override string get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x158E2A4
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x158E370
	protected override void Finalize() { }

	// RVA: 0x158E4FC
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x158E464
	public void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x158E584
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x158E734
	public void run() { }

	// RVA: 0x158E75C
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

	// RVA: 0x158E6A8
	public void .ctor(string javaInterface) { }

	// RVA: 0x158ED7C
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x158EDB4
	protected override void Finalize() { }

	// RVA: 0x158EEEC
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x1590724
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x158E8C4
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x1591788
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x1591878
	public virtual int hashCode() { }

	// RVA: 0x1591C48
	public virtual string toString() { }

	// RVA: 0x1591CC0
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x1591A58
	internal IntPtr GetRawProxy() { }

	// RVA: 0x1591EDC
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

	// RVA: 0x15920D8
	public void .ctor(string className, object[] args) { }

	// RVA: 0x1590514
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x15913DC
	public void Dispose() { }

	// RVA: 0x159241C
	public void Call(string methodName, object[] args) { }

	// RVA: 0x15924E4
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x316B894
	public FieldType GetStatic(string fieldName) { }

	// RVA: 0x1591720
	public IntPtr GetRawObject() { }

	// RVA: 0x15925C4
	public IntPtr GetRawClass() { }

	// RVA: 0x1592604
	public AndroidJavaObject CloneReference() { }

	// RVA: 0x316B894
	public ReturnType Call(string methodName, object[] args) { }

	// RVA: 0x316B894
	public ReturnType CallStatic(string methodName, object[] args) { }

	// RVA: 0x1592954
	protected void DebugPrint(string msg) { }

	// RVA: 0x1592120
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x1592A30
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x1592118
	internal void .ctor() { }

	// RVA: 0x1592EE4
	protected override void Finalize() { }

	// RVA: 0x1592F80
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1592480
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x15930F0
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x316B894
	protected ReturnType _Call(string methodName, object[] args) { }

	// RVA: 0x316B894
	protected ReturnType _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x1592548
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x15933C0
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x316B894
	protected ReturnType _CallStatic(string methodName, object[] args) { }

	// RVA: 0x316B894
	protected ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x316B894
	protected FieldType _GetStatic(string fieldName) { }

	// RVA: 0x316B894
	protected FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x15915F8
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x1593690
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x316B894
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x15925AC
	protected IntPtr _GetRawObject() { }

	// RVA: 0x15925E4
	protected IntPtr _GetRawClass() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass
{
	// Methods

	// RVA: 0x158ED4C
	public void .ctor(string className) { }

	// RVA: 0x15937B8
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x1592820
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

	// RVA: 0x15939A8
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x15939C0
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x15939E4
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1593BA0
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1593D5C
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x15940A0
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x15942C0
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15944E0
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x1594624
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x15947B8
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x15903D4
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x15948F4
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper
{
	// Methods

	// RVA: 0x1594C24
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x1594CB0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x1594D14
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x1594E88
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret) { }

	// RVA: 0x1596158
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x1590910
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x158F9C4
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x1596A4C
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x1595450
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x316B894
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x15974E4
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x159762C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x316B894
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x316B894
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x1597670
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x1597934
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1597B6C
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1597C18
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15980E4
	public static string GetSignature(object obj) { }

	// RVA: 0x1597510
	public static string GetSignature(object[] args) { }

	// RVA: 0x30B57C8
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

	// RVA: 0x1597628
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x15920D4
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1598E08
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x15960F4
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x1591D24
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x1592CD4
	public static void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x1598E4C
	public static void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x1592A04
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x15930AC
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x316B894
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x316B894
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x316B894
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x1598E50
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x159158C
	public static IntPtr Box(int value) { }

	// RVA: 0x1591520
	public static IntPtr Box(bool value) { }

}

// Namespace: UnityEngine
public static class AndroidJNI
{
	// Methods

	// RVA: 0x159914C
	public static IntPtr FindClass(string name) { }

	// RVA: 0x159919C
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x15991EC
	public static IntPtr ExceptionOccurred() { }

	// RVA: 0x159922C
	public static void ExceptionClear() { }

	// RVA: 0x1597F1C
	public static int PushLocalFrame(int capacity) { }

	// RVA: 0x159926C
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x158E320
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x15992BC
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x1591E8C
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x1591CD4
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x1591738
	public static IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x159930C
	public static void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x1591810
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x159935C
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15993F8
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599450
	public static IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x15994A0
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15994F8
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1599550
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x15995A8
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1599600
	public static IntPtr NewString(string chars) { }

	// RVA: 0x1599650
	private static IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x1594E38
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x15996A0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1599788
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599824
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159987C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599918
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599970
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599A0C
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599A64
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599B00
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599B58
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599BF4
	public static Int16 CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599C4C
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599CE8
	public static SByte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599D40
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599DDC
	public static Char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599E34
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599ED0
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1599F28
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1599FC4
	public static Double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A01C
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A0B8
	public static Int64 CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A110
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A1AC
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A204
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x159A2EC
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A388
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A3E0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A47C
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A4D4
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A570
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A5C8
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A664
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A6BC
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A758
	public static Int16 CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A7B0
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A84C
	public static SByte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A8A4
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159A940
	public static Char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159A998
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159AA34
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159AA8C
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159AB28
	public static Double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159AB80
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159AC1C
	public static Int64 CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159AC74
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159AD10
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x159AD68
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159ADD0
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159AE38
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159AEA0
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159AF08
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159AF70
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159AFD8
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159B040
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159B0A8
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159B110
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159B178
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x159B1C8
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x159B218
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x159B290
	public static IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x159B2F8
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x159B370
	public static IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x159B3D8
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x159B450
	public static IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x159B4B8
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x159B530
	public static IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x159B598
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x159B610
	public static IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x159B678
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x159B6F0
	public static IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x159B758
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x159B7D0
	public static IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x159B838
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x159B890
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x159B8F8
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x159B948
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x159B998
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x159B9E8
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x159BA38
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x159BA88
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x159BAD8
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x159BB28
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x159BB78
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x159BBC8
	public static int GetArrayLength(IntPtr array) { }

	// RVA: 0x159734C
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x159BC18
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x15973A4
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe
{
	// Methods

	// RVA: 0x159BC80
	public static void CheckException() { }

	// RVA: 0x158E518
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x158EE80
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x15923B0
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x1593F74
	public static IntPtr NewString(string chars) { }

	// RVA: 0x159BF68
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x159230C
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x1593AE4
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1593CA0
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x1597F6C
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1598028
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1597890
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x1592030
	public static IntPtr FindClass(string name) { }

	// RVA: 0x1592DF0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159C00C
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C0C0
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C174
	public static Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C228
	public static Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C2E8
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C3A8
	public static Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C45C
	public static Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C510
	public static SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C5C4
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x159C678
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x15935A4
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1594018
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1599058
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1594730
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x159C72C
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159C820
	public static Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159C914
	public static Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CA14
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CB14
	public static Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CC08
	public static Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CCFC
	public static SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CDF0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x1591B54
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x15932D4
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159459C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x159CEE4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159CFD8
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D0CC
	public static Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D1C0
	public static Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D2C0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D3C0
	public static Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D4B4
	public static Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D5A8
	public static SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D69C
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D790
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x159D884
	public static Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x159D928
	public static Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x159D9CC
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x159DA70
	public static Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x159DB14
	public static Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x159DBB8
	public static Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x159DC5C
	public static SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x159DD00
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x159DDA4
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x15973FC
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x159726C
	public static IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x159718C
	public static IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x15970AC
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x1596FCC
	public static IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x1596EEC
	public static IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x1596D68
	public static IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x1596E0C
	public static IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x1596CC4
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x1596BE4
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x159146C
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x158E820
	public static int GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine.Android
internal static class AndroidApp
{
	// Methods

	// RVA: 0x1598E0C
	public static IntPtr get_UnityPlayerRaw() { }

}

// Namespace: UnityEngine.Android
public class PermissionCallbacks
{}

// Namespace: UnityEngine.Android
public struct Permission
{
	// Methods

	// RVA: 0x159DE48
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x159DE54
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x159DED0
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }

}


