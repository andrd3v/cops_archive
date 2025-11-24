// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable 
{
	// Methods

	// RVA: 0x149BA8C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x149BB2C
	internal void Invoke() { }

}

// Namespace: UnityEngine
public sealed class AndroidJavaException 
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Methods

	// RVA: 0x149BB40
	void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x149BBC8
	string get_StackTrace() { }

}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef 
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x149BBF8
	void .ctor(IntPtr jobject) { }

	// RVA: 0x149BCC4
	void Finalize() { }

	// RVA: 0x149BE50
	IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x149BDB8
	void Dispose() { }

}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy 
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x149BED8
	void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x149C088
	void run() { }

	// RVA: 0x149C0B0
	IntPtr Invoke(string methodName, IntPtr javaArgs) { }

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

	// RVA: 0x149BFFC
	void .ctor(string javaInterface) { }

	// RVA: 0x149C6D0
	void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x149C708
	void Finalize() { }

	// RVA: 0x149C840
	AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x149E078
	AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x149C218
	IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x149F0DC
	bool equals(AndroidJavaObject obj) { }

	// RVA: 0x149F1CC
	int hashCode() { }

	// RVA: 0x149F59C
	string toString() { }

	// RVA: 0x149F614
	AndroidJavaObject GetProxyObject() { }

	// RVA: 0x149F3AC
	IntPtr GetRawProxy() { }

	// RVA: 0x149F830
	void .cctor() { }

}

// Namespace: UnityEngine
public class AndroidJavaObject 
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x149FA2C
	void .ctor(string className, object[] args) { }

	// RVA: 0x149DE68
	void .ctor(IntPtr jobject) { }

	// RVA: 0x149ED30
	void Dispose() { }

	// RVA: 0x149FD70
	void Call(string methodName, object[] args) { }

	// RVA: 0x149FE38
	void CallStatic(string methodName, object[] args) { }

	// RVA: 0x309AF8C
	FieldType GetStatic(string fieldName) { }

	// RVA: 0x149F074
	IntPtr GetRawObject() { }

	// RVA: 0x149FF18
	IntPtr GetRawClass() { }

	// RVA: 0x149FF58
	AndroidJavaObject CloneReference() { }

	// RVA: 0x309AF8C
	ReturnType Call(string methodName, object[] args) { }

	// RVA: 0x309AF8C
	ReturnType CallStatic(string methodName, object[] args) { }

	// RVA: 0x14A02A8
	void DebugPrint(string msg) { }

	// RVA: 0x149FA74
	void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x14A0384
	void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x149FA6C
	void .ctor() { }

	// RVA: 0x14A0838
	void Finalize() { }

	// RVA: 0x14A08D4
	void Dispose(bool disposing) { }

	// RVA: 0x149FDD4
	void _Call(string methodName, object[] args) { }

	// RVA: 0x14A0A44
	void _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x309AF8C
	ReturnType _Call(string methodName, object[] args) { }

	// RVA: 0x309AF8C
	ReturnType _Call(IntPtr methodID, object[] args) { }

	// RVA: 0x149FE9C
	void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x14A0D14
	void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x309AF8C
	ReturnType _CallStatic(string methodName, object[] args) { }

	// RVA: 0x309AF8C
	ReturnType _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: 0x309AF8C
	FieldType _GetStatic(string fieldName) { }

	// RVA: 0x309AF8C
	FieldType _GetStatic(IntPtr fieldID) { }

	// RVA: 0x149EF4C
	AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x14A0FE4
	AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x309AF8C
	ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x149FF00
	IntPtr _GetRawObject() { }

	// RVA: 0x149FF38
	IntPtr _GetRawClass() { }

}

// Namespace: UnityEngine
public class AndroidJavaClass 
{
	// Methods

	// RVA: 0x149C6A0
	void .ctor(string className) { }

	// RVA: 0x14A110C
	void _AndroidJavaClass(string className) { }

	// RVA: 0x14A0174
	void .ctor(IntPtr jclass) { }

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

	// RVA: 0x14A12FC
	bool IsPrimitive(Type t) { }

	// RVA: 0x14A1314
	bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x14A1338
	IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x14A14F4
	IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x14A16B0
	IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x14A19F4
	IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x14A1C14
	IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x14A1E34
	IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x14A1F78
	string GetFieldSignature(IntPtr field) { }

	// RVA: 0x14A210C
	IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x149DD28
	IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x14A2248
	void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class _AndroidJNIHelper 
{
	// Methods

	// RVA: 0x14A2578
	IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x14A2604
	IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x14A2668
	IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x14A27DC
	void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> ret) { }

	// RVA: 0x14A3AAC
	object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x149E264
	object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x149D318
	AndroidJavaObject Box(object obj) { }

	// RVA: 0x14A43A0
	void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x14A2DA4
	IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x309AF8C
	ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x14A4E38
	IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x14A4F80
	IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x309AF8C
	IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x309AF8C
	IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x14A4FC4
	IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x14A5288
	IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x14A54C0
	IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x14A556C
	IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x14A5A38
	string GetSignature(object obj) { }

	// RVA: 0x14A4E64
	string GetSignature(object[] args) { }

	// RVA: 0x2FE7084
	string GetSignature(object[] args) { }

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

	// RVA: 0x14A4F7C
	IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x149FA28
	IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x14A675C
	IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x14A3A48
	IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x149F678
	IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x14A0628
	void CreateJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x14A67A0
	void DeleteJNIArgArray(object[] args, System.Span<UnityEngine.jvalue> jniArgs) { }

	// RVA: 0x14A0358
	IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x14A0A00
	IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x309AF8C
	ArrayType ConvertFromJNIArray(IntPtr array) { }

	// RVA: 0x309AF8C
	IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x309AF8C
	IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	// RVA: 0x14A67A4
	IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x149EEE0
	IntPtr Box(int value) { }

	// RVA: 0x149EE74
	IntPtr Box(bool value) { }

}

// Namespace: UnityEngine
public static class AndroidJNI 
{
	// Methods

	// RVA: 0x14A6AA0
	IntPtr FindClass(string name) { }

	// RVA: 0x14A6AF0
	IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x14A6B40
	IntPtr ExceptionOccurred() { }

	// RVA: 0x14A6B80
	void ExceptionClear() { }

	// RVA: 0x14A5870
	int PushLocalFrame(int capacity) { }

	// RVA: 0x14A6BC0
	IntPtr PopLocalFrame(IntPtr ptr) { }

	// RVA: 0x149BC74
	IntPtr NewGlobalRef(IntPtr obj) { }

	// RVA: 0x14A6C10
	void QueueDeleteGlobalRef(IntPtr obj) { }

	// RVA: 0x149F7E0
	IntPtr NewWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x149F628
	void DeleteWeakGlobalRef(IntPtr obj) { }

	// RVA: 0x149F08C
	IntPtr NewLocalRef(IntPtr obj) { }

	// RVA: 0x14A6C60
	void DeleteLocalRef(IntPtr obj) { }

	// RVA: 0x149F164
	bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	// RVA: 0x14A6CB0
	IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A6D4C
	IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A6DA4
	IntPtr GetObjectClass(IntPtr obj) { }

	// RVA: 0x14A6DF4
	IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A6E4C
	IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A6EA4
	IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A6EFC
	IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A6F54
	IntPtr NewString(string chars) { }

	// RVA: 0x14A6FA4
	IntPtr NewStringFromStr(string chars) { }

	// RVA: 0x14A278C
	string GetStringChars(IntPtr str) { }

	// RVA: 0x14A6FF4
	string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x14A70DC
	string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7178
	string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A71D0
	IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A726C
	IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A72C4
	int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7360
	int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A73B8
	bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7454
	bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A74AC
	Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7548
	Int16 CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A75A0
	SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A763C
	SByte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7694
	Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7730
	Char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7788
	float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7824
	float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A787C
	Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7918
	Double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7970
	Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7A0C
	Int64 CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7A64
	void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7B00
	void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7B58
	string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x14A7C40
	string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7CDC
	string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7D34
	IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7DD0
	IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7E28
	int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7EC4
	int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A7F1C
	bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A7FB8
	bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A8010
	Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A80AC
	Int16 CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A8104
	SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A81A0
	SByte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A81F8
	Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A8294
	Char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A82EC
	float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A8388
	float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A83E0
	Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A847C
	Double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A84D4
	Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A8570
	Int64 CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A85C8
	void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A8664
	void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x14A86BC
	string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A8724
	IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A878C
	bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A87F4
	SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A885C
	Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A88C4
	Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A892C
	int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A8994
	Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A89FC
	float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A8A64
	Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A8ACC
	IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x14A8B1C
	IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x14A8B6C
	IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x14A8BE4
	IntPtr ToSByteArray(SByte* array, int length) { }

	// RVA: 0x14A8C4C
	IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x14A8CC4
	IntPtr ToCharArray(Char* array, int length) { }

	// RVA: 0x14A8D2C
	IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x14A8DA4
	IntPtr ToShortArray(Int16* array, int length) { }

	// RVA: 0x14A8E0C
	IntPtr ToIntArray(int[] array) { }

	// RVA: 0x14A8E84
	IntPtr ToIntArray(Int32* array, int length) { }

	// RVA: 0x14A8EEC
	IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x14A8F64
	IntPtr ToLongArray(Int64* array, int length) { }

	// RVA: 0x14A8FCC
	IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x14A9044
	IntPtr ToFloatArray(Single* array, int length) { }

	// RVA: 0x14A90AC
	IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x14A9124
	IntPtr ToDoubleArray(Double* array, int length) { }

	// RVA: 0x14A918C
	IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x14A91E4
	IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x14A924C
	bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x14A929C
	Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x14A92EC
	SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x14A933C
	Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x14A938C
	Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x14A93DC
	int[] FromIntArray(IntPtr array) { }

	// RVA: 0x14A942C
	Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x14A947C
	float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x14A94CC
	Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x14A951C
	int GetArrayLength(IntPtr array) { }

	// RVA: 0x14A4CA0
	IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	// RVA: 0x14A956C
	IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x14A4CF8
	void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

}

// Namespace: UnityEngine
internal class AndroidJNISafe 
{
	// Methods

	// RVA: 0x14A95D4
	void CheckException() { }

	// RVA: 0x149BE6C
	void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x149C7D4
	void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x149FD04
	void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x14A18C8
	IntPtr NewString(string chars) { }

	// RVA: 0x14A98BC
	string GetStringChars(IntPtr str) { }

	// RVA: 0x149FC60
	IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x14A1438
	IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A15F4
	IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x14A58C0
	IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A597C
	IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x14A51E4
	IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x149F984
	IntPtr FindClass(string name) { }

	// RVA: 0x14A0744
	IntPtr NewObject(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A9960
	IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9A14
	string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9AC8
	Char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9B7C
	Double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9C3C
	float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9CFC
	Int64 GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9DB0
	Int16 GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9E64
	SByte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9F18
	bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A9FCC
	int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x14A0EF8
	void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A196C
	IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x14A69AC
	IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A2084
	string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x14AA080
	string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA174
	Char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA268
	Double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA368
	float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA468
	Int64 CallStaticLongMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA55C
	Int16 CallStaticShortMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA650
	SByte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA744
	bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x149F4A8
	int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A0C28
	void CallVoidMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14A1EF0
	IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x14AA838
	IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AA92C
	string CallStringMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAA20
	Char CallCharMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAB14
	Double CallDoubleMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAC14
	float CallFloatMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAD14
	Int64 CallLongMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAE08
	Int16 CallShortMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAEFC
	SByte CallSByteMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AAFF0
	bool CallBooleanMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AB0E4
	int CallIntMethod(IntPtr obj, IntPtr methodID, System.Span<UnityEngine.jvalue> args) { }

	// RVA: 0x14AB1D8
	Char[] FromCharArray(IntPtr array) { }

	// RVA: 0x14AB27C
	Double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x14AB320
	float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x14AB3C4
	Int64[] FromLongArray(IntPtr array) { }

	// RVA: 0x14AB468
	Int16[] FromShortArray(IntPtr array) { }

	// RVA: 0x14AB50C
	Byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x14AB5B0
	SByte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x14AB654
	bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x14AB6F8
	int[] FromIntArray(IntPtr array) { }

	// RVA: 0x14A4D50
	IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x14A4BC0
	IntPtr ToCharArray(Char[] array) { }

	// RVA: 0x14A4AE0
	IntPtr ToDoubleArray(Double[] array) { }

	// RVA: 0x14A4A00
	IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x14A4920
	IntPtr ToLongArray(Int64[] array) { }

	// RVA: 0x14A4840
	IntPtr ToShortArray(Int16[] array) { }

	// RVA: 0x14A46BC
	IntPtr ToByteArray(Byte[] array) { }

	// RVA: 0x14A4760
	IntPtr ToSByteArray(SByte[] array) { }

	// RVA: 0x14A4618
	IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x14A4538
	IntPtr ToIntArray(int[] array) { }

	// RVA: 0x149EDC0
	IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x149C174
	int GetArrayLength(IntPtr array) { }

}

// Namespace: UnityEngine.Android
internal static class AndroidApp 
{
	// Methods

	// RVA: 0x14A6760
	IntPtr get_UnityPlayerRaw() { }

}

// Namespace: UnityEngine.Android
public class PermissionCallbacks 
{}

// Namespace: UnityEngine.Android
public struct Permission 
{
	// Methods

	// RVA: 0x14AB79C
	bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x14AB7A8
	void RequestUserPermission(string permission) { }

	// RVA: 0x14AB824
	void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }

}


