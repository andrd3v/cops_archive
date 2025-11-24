// Namespace: 
internal class <Module>
{}

// Namespace: 
private struct MonoScriptData
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Methods

	// RVA: 0x5BB54C
	private static MonoScriptData Get() { }

	// RVA: 0x5BB64C
	public void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.Utils
internal class xxHash
{
	// Fields
	private const UInt32 PRIME32_1 = 2654435761;
	private const UInt32 PRIME32_2 = 2246822519;
	private const UInt32 PRIME32_3 = 3266489917;
	private const UInt32 PRIME32_4 = 668265263;
	private const UInt32 PRIME32_5 = 374761393;

	// Methods

	// RVA: 0x5BB654
	public static UInt32 CalculateHash(Byte[] buf, int len, UInt32 seed) { }

	// RVA: 0x5BB9F0
	public void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
internal class BitconverterExt
{
	// Methods

	// RVA: 0x5BB9F8
	public static Byte[] GetBytes(Decimal dec) { }

	// RVA: 0x5BBB40
	public static Decimal ToDecimal(Byte[] bytes) { }

	// RVA: 0x5BBCC0
	public void .ctor() { }

}

// Namespace: 
internal enum DataType
{
	// Fields
	public Byte value__; // 0x10
	public const DataType Unknown = 0;
	public const DataType Int = 5;
	public const DataType UInt = 10;
	public const DataType String = 15;
	public const DataType Float = 20;
	public const DataType Double = 25;
	public const DataType Decimal = 27;
	public const DataType Long = 30;
	public const DataType ULong = 32;
	public const DataType Bool = 35;
	public const DataType ByteArray = 40;
	public const DataType Vector2 = 45;
	public const DataType Vector3 = 50;
	public const DataType Quaternion = 55;
	public const DataType Color = 60;
	public const DataType Rect = 65;
}

// Namespace: 
public enum DeviceLockLevel
{
	// Fields
	public Byte value__; // 0x10
	public const DeviceLockLevel None = 0;
	public const DeviceLockLevel Soft = 1;
	public const DeviceLockLevel Strict = 2;
}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
public static class ObscuredPrefs
{
	// Fields
	private const Byte VERSION = 2;
	private const string RAW_NOT_FOUND = "{not_found}";
	private const string DATA_SEPARATOR = "|";
	private static bool foreignSavesReported; // 0x0
	private static string cryptoKey; // 0x8
	private static int mainThreadId; // 0x10
	private static string deviceId; // 0x18
	private static UInt32 deviceIdHash; // 0x20
	public static Action onAlterationDetected; // 0x28
	public static bool preservePlayerPrefs; // 0x30
	public static Action onPossibleForeignSavesDetected; // 0x38
	public static DeviceLockLevel lockToDevice; // 0x40
	public static bool readForeignSaves; // 0x41
	public static bool emergencyMode; // 0x42
	private const Char DEPRECATED_RAW_SEPARATOR = 58;
	private static string deprecatedDeviceId; // 0x48

	// Methods

	// RVA: 0x5BBCC8
	private static bool get_IsMainThread() { }

	// RVA: 0x5BBD48
	public static void SetMainThread() { }

	// RVA: 0x5BBDD4
	private static void CheckMainThread() { }

	// RVA: 0x5BBF04
	public static void set_CryptoKey(string value) { }

	// RVA: 0x5BBF70
	public static string get_CryptoKey() { }

	// RVA: 0x5BBFEC
	public static string get_DeviceId() { }

	// RVA: 0x5BC1A4
	public static void set_DeviceId(string value) { }

	// RVA: 0x5BC210
	internal static string get_DeviceID() { }

	// RVA: 0x5BC278
	internal static void set_DeviceID(string value) { }

	// RVA: 0x5BC33C
	private static UInt32 get_DeviceIdHash() { }

	// RVA: 0x5BC4EC
	public static void ForceLockToDeviceInit() { }

	// RVA: 0x5BC680
	internal static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5BC744
	public static void SetInt(string key, int value) { }

	// RVA: 0x5BC9EC
	public static int GetInt(string key) { }

	// RVA: 0x5BCA74
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x5BC970
	internal static string EncryptIntValue(string key, int value) { }

	// RVA: 0x5BCCF4
	internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue) { }

	// RVA: 0x5BD96C
	public static void SetUInt(string key, UInt32 value) { }

	// RVA: 0x5BDABC
	public static UInt32 GetUInt(string key) { }

	// RVA: 0x5BDB44
	public static UInt32 GetUInt(string key, UInt32 defaultValue) { }

	// RVA: 0x5BDA40
	private static string EncryptUIntValue(string key, UInt32 value) { }

	// RVA: 0x5BDC20
	private static UInt32 DecryptUIntValue(string key, string encryptedInput, UInt32 defaultValue) { }

	// RVA: 0x5BDD6C
	public static void SetString(string key, string value) { }

	// RVA: 0x5BDEEC
	public static string GetString(string key) { }

	// RVA: 0x5BDF90
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x5BDE58
	internal static string EncryptStringValue(string key, string value) { }

	// RVA: 0x5BE118
	internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue) { }

	// RVA: 0x5BE274
	public static void SetFloat(string key, float value) { }

	// RVA: 0x5BE3CC
	public static float GetFloat(string key) { }

	// RVA: 0x5BE454
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x5BE348
	internal static string EncryptFloatValue(string key, float value) { }

	// RVA: 0x5BE5DC
	internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue) { }

	// RVA: 0x5BE728
	public static void SetDouble(string key, Double value) { }

	// RVA: 0x5BE880
	public static Double GetDouble(string key) { }

	// RVA: 0x5BE908
	public static Double GetDouble(string key, Double defaultValue) { }

	// RVA: 0x5BE7FC
	private static string EncryptDoubleValue(string key, Double value) { }

	// RVA: 0x5BE9E4
	private static Double DecryptDoubleValue(string key, string encryptedInput, Double defaultValue) { }

	// RVA: 0x5BEB30
	public static void SetDecimal(string key, Decimal value) { }

	// RVA: 0x5BEC90
	public static Decimal GetDecimal(string key) { }

	// RVA: 0x5BED54
	public static Decimal GetDecimal(string key, Decimal defaultValue) { }

	// RVA: 0x5BEC08
	private static string EncryptDecimalValue(string key, Decimal value) { }

	// RVA: 0x5BEE3C
	private static Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue) { }

	// RVA: 0x5BEFC0
	public static void SetLong(string key, Int64 value) { }

	// RVA: 0x5BF110
	public static Int64 GetLong(string key) { }

	// RVA: 0x5BF198
	public static Int64 GetLong(string key, Int64 defaultValue) { }

	// RVA: 0x5BF094
	private static string EncryptLongValue(string key, Int64 value) { }

	// RVA: 0x5BF274
	private static Int64 DecryptLongValue(string key, string encryptedInput, Int64 defaultValue) { }

	// RVA: 0x5BF3C0
	public static void SetULong(string key, UInt64 value) { }

	// RVA: 0x5BF510
	public static UInt64 GetULong(string key) { }

	// RVA: 0x5BF598
	public static UInt64 GetULong(string key, UInt64 defaultValue) { }

	// RVA: 0x5BF494
	private static string EncryptULongValue(string key, UInt64 value) { }

	// RVA: 0x5BF674
	private static UInt64 DecryptULongValue(string key, string encryptedInput, UInt64 defaultValue) { }

	// RVA: 0x5BF7C0
	public static void SetBool(string key, bool value) { }

	// RVA: 0x5BF910
	public static bool GetBool(string key) { }

	// RVA: 0x5BF998
	public static bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x5BF894
	private static string EncryptBoolValue(string key, bool value) { }

	// RVA: 0x5BFA74
	private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue) { }

	// RVA: 0x5BFBCC
	public static void SetByteArray(string key, Byte[] value) { }

	// RVA: 0x5BFCFC
	public static Byte[] GetByteArray(string key) { }

	// RVA: 0x5BFD64
	public static Byte[] GetByteArray(string key, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5BFC90
	private static string EncryptByteArrayValue(string key, Byte[] value) { }

	// RVA: 0x5C0014
	private static Byte[] DecryptByteArrayValue(string key, string encryptedInput, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5BFF34
	private static Byte[] ConstructByteArray(Byte value, int length) { }

	// RVA: 0x5C0324
	public static void SetVector2(string key, Vector2 value) { }

	// RVA: 0x5C04A0
	public static Vector2 GetVector2(string key) { }

	// RVA: 0x5C0544
	public static Vector2 GetVector2(string key, Vector2 defaultValue) { }

	// RVA: 0x5C03BC
	private static string EncryptVector2Value(string key, Vector2 value) { }

	// RVA: 0x5C0624
	private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue) { }

	// RVA: 0x5C084C
	public static void SetVector3(string key, Vector3 value) { }

	// RVA: 0x5C0A08
	public static Vector3 GetVector3(string key) { }

	// RVA: 0x5C0ABC
	public static Vector3 GetVector3(string key, Vector3 defaultValue) { }

	// RVA: 0x5C08F4
	private static string EncryptVector3Value(string key, Vector3 value) { }

	// RVA: 0x5C0BB4
	private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue) { }

	// RVA: 0x5C0E28
	public static void SetQuaternion(string key, Quaternion value) { }

	// RVA: 0x5C1014
	public static Quaternion GetQuaternion(string key) { }

	// RVA: 0x5C10CC
	public static Quaternion GetQuaternion(string key, Quaternion defaultValue) { }

	// RVA: 0x5C0ED8
	private static string EncryptQuaternionValue(string key, Quaternion value) { }

	// RVA: 0x5C11D4
	private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue) { }

	// RVA: 0x5C1480
	public static void SetColor(string key, Color32 value) { }

	// RVA: 0x5C15DC
	public static Color32 GetColor(string key) { }

	// RVA: 0x5C1664
	public static Color32 GetColor(string key, Color32 defaultValue) { }

	// RVA: 0x5C1560
	private static string EncryptColorValue(string key, UInt32 value) { }

	// RVA: 0x5C1750
	public static void SetRect(string key, Rect value) { }

	// RVA: 0x5C193C
	public static Rect GetRect(string key) { }

	// RVA: 0x5C19AC
	public static Rect GetRect(string key, Rect defaultValue) { }

	// RVA: 0x5C1800
	private static string EncryptRectValue(string key, Rect value) { }

	// RVA: 0x5C1AB4
	private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue) { }

	// RVA: 0x5C1D60
	public static void SetRawValue(string key, string encryptedValue) { }

	// RVA: 0x5C1DD4
	public static string GetRawValue(string key) { }

	// RVA: 0x5C1E40
	internal static DataType GetRawValueType(string value) { }

	// RVA: 0x5BC83C
	internal static string EncryptKey(string key) { }

	// RVA: 0x5C2274
	public static bool HasKey(string key) { }

	// RVA: 0x5C2334
	public static void DeleteKey(string key) { }

	// RVA: 0x5C23CC
	public static void DeleteAll() { }

	// RVA: 0x5C2444
	public static void Save() { }

	// RVA: 0x5BCBFC
	private static string GetEncryptedPrefsString(string key, string encryptedKey) { }

	// RVA: 0x5BCE40
	private static string EncryptData(string key, Byte[] cleanBytes, DataType type) { }

	// RVA: 0x5BD55C
	internal static Byte[] DecryptData(string key, string encryptedInput) { }

	// RVA: 0x5BC40C
	private static UInt32 CalculateChecksum(string input) { }

	// RVA: 0x5C25CC
	private static void SavesTampered() { }

	// RVA: 0x5C2690
	private static void PossibleForeignSavesDetected() { }

	// RVA: 0x5BC140
	private static string GetDeviceId() { }

	// RVA: 0x5C24BC
	private static Byte[] EncryptDecryptBytes(Byte[] bytes, int dataLength, string key) { }

	// RVA: 0x5BD0F4
	private static string DeprecatedDecryptValue(string value) { }

	// RVA: 0x5C2860
	private static string DeprecatedCalculateChecksum(string input) { }

	// RVA: 0x5C2770
	private static string get_DeprecatedDeviceId() { }

	// RVA: 0x5C2C18
	private static void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
[Serializable]
public sealed class ObscuredString
{
	// Fields
	private static string s_cryptoKey; // 0x0
	private string currentCryptoKey; // 0x10
	private Byte[] hiddenValue; // 0x18
	private bool inited; // 0x20

	// Methods

	// RVA: 0x5C2CB8
	private void .ctor() { }

	// RVA: 0x5C2CC0
	private void .ctor(Byte[] value) { }

	// RVA: 0x5C2D5C
	public static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5C2DD0
	public static string EncryptDecrypt(string value) { }

	// RVA: 0x5C20E0
	public static string EncryptDecrypt(string value, string key) { }

	// RVA: 0x5C2E74
	public void ApplyNewCryptoKey() { }

	// RVA: 0x5C31EC
	public void RandomizeCryptoKey() { }

	// RVA: 0x5C3374
	public string GetEncrypted() { }

	// RVA: 0x5C3508
	public void SetEncrypted(string encrypted) { }

	// RVA: 0x5C3610
	public string GetDecrypted() { }

	// RVA: 0x5C3120
	private static Byte[] InternalEncrypt(string value) { }

	// RVA: 0x5C3308
	private static Byte[] InternalEncrypt(string value, string key) { }

	// RVA: 0x5C2F78
	private string InternalDecrypt() { }

	// RVA: 0x5C3614
	public int get_Length() { }

	// RVA: 0x5C3640
	public static ObscuredString op_Implicit(string value) { }

	// RVA: 0x5C372C
	public static string op_Implicit(ObscuredString value) { }

	// RVA: 0x5C3938
	public override string ToString() { }

	// RVA: 0x5C37E0
	public static bool op_Equality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5C39A8
	public static bool op_Inequality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5C3A18
	public override bool Equals(object obj) { }

	// RVA: 0x5C3A98
	public bool Equals(ObscuredString value) { }

	// RVA: 0x5C3C2C
	public bool Equals(ObscuredString value, StringComparison comparisonType) { }

	// RVA: 0x5C3D14
	public override int GetHashCode() { }

	// RVA: 0x5C3584
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x5C3478
	private static string GetString(Byte[] bytes) { }

	// RVA: 0x5C393C
	private static bool ArraysEquals(Byte[] a1, Byte[] a2) { }

	// RVA: 0x5C3D38
	private static void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.Common
internal class Constants
{
	// Fields
	internal const string LOG_PREFIX = "[ACTk] ";

	// Methods

	// RVA: 0x5C3DB0
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=237
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=527
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=527 72BF8639D2382933FEC4564A4705D91BD07259FFC6A10260018E58855EC24285; // 0x0
	internal static readonly __StaticArrayInitTypeSize=237 86DA078FF28822024C17AEB97C8F109C9524D88586CAA932D8D4EBFD2E6FDC64; // 0x20F
}


