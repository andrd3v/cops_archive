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

	// RVA: 0x5B6AD8
	private static MonoScriptData Get() { }

	// RVA: 0x5B6BD8
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

	// RVA: 0x5B6BE0
	public static UInt32 CalculateHash(Byte[] buf, int len, UInt32 seed) { }

	// RVA: 0x5B6F7C
	public void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
internal class BitconverterExt
{
	// Methods

	// RVA: 0x5B6F84
	public static Byte[] GetBytes(Decimal dec) { }

	// RVA: 0x5B70CC
	public static Decimal ToDecimal(Byte[] bytes) { }

	// RVA: 0x5B724C
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

	// RVA: 0x5B7254
	private static bool get_IsMainThread() { }

	// RVA: 0x5B72D4
	public static void SetMainThread() { }

	// RVA: 0x5B7360
	private static void CheckMainThread() { }

	// RVA: 0x5B7490
	public static void set_CryptoKey(string value) { }

	// RVA: 0x5B74FC
	public static string get_CryptoKey() { }

	// RVA: 0x5B7578
	public static string get_DeviceId() { }

	// RVA: 0x5B7730
	public static void set_DeviceId(string value) { }

	// RVA: 0x5B779C
	internal static string get_DeviceID() { }

	// RVA: 0x5B7804
	internal static void set_DeviceID(string value) { }

	// RVA: 0x5B78C8
	private static UInt32 get_DeviceIdHash() { }

	// RVA: 0x5B7A78
	public static void ForceLockToDeviceInit() { }

	// RVA: 0x5B7C0C
	internal static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5B7CD0
	public static void SetInt(string key, int value) { }

	// RVA: 0x5B7F78
	public static int GetInt(string key) { }

	// RVA: 0x5B8000
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x5B7EFC
	internal static string EncryptIntValue(string key, int value) { }

	// RVA: 0x5B8280
	internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue) { }

	// RVA: 0x5B8EF8
	public static void SetUInt(string key, UInt32 value) { }

	// RVA: 0x5B9048
	public static UInt32 GetUInt(string key) { }

	// RVA: 0x5B90D0
	public static UInt32 GetUInt(string key, UInt32 defaultValue) { }

	// RVA: 0x5B8FCC
	private static string EncryptUIntValue(string key, UInt32 value) { }

	// RVA: 0x5B91AC
	private static UInt32 DecryptUIntValue(string key, string encryptedInput, UInt32 defaultValue) { }

	// RVA: 0x5B92F8
	public static void SetString(string key, string value) { }

	// RVA: 0x5B9478
	public static string GetString(string key) { }

	// RVA: 0x5B951C
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x5B93E4
	internal static string EncryptStringValue(string key, string value) { }

	// RVA: 0x5B96A4
	internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue) { }

	// RVA: 0x5B9800
	public static void SetFloat(string key, float value) { }

	// RVA: 0x5B9958
	public static float GetFloat(string key) { }

	// RVA: 0x5B99E0
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x5B98D4
	internal static string EncryptFloatValue(string key, float value) { }

	// RVA: 0x5B9B68
	internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue) { }

	// RVA: 0x5B9CB4
	public static void SetDouble(string key, Double value) { }

	// RVA: 0x5B9E0C
	public static Double GetDouble(string key) { }

	// RVA: 0x5B9E94
	public static Double GetDouble(string key, Double defaultValue) { }

	// RVA: 0x5B9D88
	private static string EncryptDoubleValue(string key, Double value) { }

	// RVA: 0x5B9F70
	private static Double DecryptDoubleValue(string key, string encryptedInput, Double defaultValue) { }

	// RVA: 0x5BA0BC
	public static void SetDecimal(string key, Decimal value) { }

	// RVA: 0x5BA21C
	public static Decimal GetDecimal(string key) { }

	// RVA: 0x5BA2E0
	public static Decimal GetDecimal(string key, Decimal defaultValue) { }

	// RVA: 0x5BA194
	private static string EncryptDecimalValue(string key, Decimal value) { }

	// RVA: 0x5BA3C8
	private static Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue) { }

	// RVA: 0x5BA54C
	public static void SetLong(string key, Int64 value) { }

	// RVA: 0x5BA69C
	public static Int64 GetLong(string key) { }

	// RVA: 0x5BA724
	public static Int64 GetLong(string key, Int64 defaultValue) { }

	// RVA: 0x5BA620
	private static string EncryptLongValue(string key, Int64 value) { }

	// RVA: 0x5BA800
	private static Int64 DecryptLongValue(string key, string encryptedInput, Int64 defaultValue) { }

	// RVA: 0x5BA94C
	public static void SetULong(string key, UInt64 value) { }

	// RVA: 0x5BAA9C
	public static UInt64 GetULong(string key) { }

	// RVA: 0x5BAB24
	public static UInt64 GetULong(string key, UInt64 defaultValue) { }

	// RVA: 0x5BAA20
	private static string EncryptULongValue(string key, UInt64 value) { }

	// RVA: 0x5BAC00
	private static UInt64 DecryptULongValue(string key, string encryptedInput, UInt64 defaultValue) { }

	// RVA: 0x5BAD4C
	public static void SetBool(string key, bool value) { }

	// RVA: 0x5BAE9C
	public static bool GetBool(string key) { }

	// RVA: 0x5BAF24
	public static bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x5BAE20
	private static string EncryptBoolValue(string key, bool value) { }

	// RVA: 0x5BB000
	private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue) { }

	// RVA: 0x5BB158
	public static void SetByteArray(string key, Byte[] value) { }

	// RVA: 0x5BB288
	public static Byte[] GetByteArray(string key) { }

	// RVA: 0x5BB2F0
	public static Byte[] GetByteArray(string key, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5BB21C
	private static string EncryptByteArrayValue(string key, Byte[] value) { }

	// RVA: 0x5BB5A0
	private static Byte[] DecryptByteArrayValue(string key, string encryptedInput, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5BB4C0
	private static Byte[] ConstructByteArray(Byte value, int length) { }

	// RVA: 0x5BB8B0
	public static void SetVector2(string key, Vector2 value) { }

	// RVA: 0x5BBA2C
	public static Vector2 GetVector2(string key) { }

	// RVA: 0x5BBAD0
	public static Vector2 GetVector2(string key, Vector2 defaultValue) { }

	// RVA: 0x5BB948
	private static string EncryptVector2Value(string key, Vector2 value) { }

	// RVA: 0x5BBBB0
	private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue) { }

	// RVA: 0x5BBDD8
	public static void SetVector3(string key, Vector3 value) { }

	// RVA: 0x5BBF94
	public static Vector3 GetVector3(string key) { }

	// RVA: 0x5BC048
	public static Vector3 GetVector3(string key, Vector3 defaultValue) { }

	// RVA: 0x5BBE80
	private static string EncryptVector3Value(string key, Vector3 value) { }

	// RVA: 0x5BC140
	private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue) { }

	// RVA: 0x5BC3B4
	public static void SetQuaternion(string key, Quaternion value) { }

	// RVA: 0x5BC5A0
	public static Quaternion GetQuaternion(string key) { }

	// RVA: 0x5BC658
	public static Quaternion GetQuaternion(string key, Quaternion defaultValue) { }

	// RVA: 0x5BC464
	private static string EncryptQuaternionValue(string key, Quaternion value) { }

	// RVA: 0x5BC760
	private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue) { }

	// RVA: 0x5BCA0C
	public static void SetColor(string key, Color32 value) { }

	// RVA: 0x5BCB68
	public static Color32 GetColor(string key) { }

	// RVA: 0x5BCBF0
	public static Color32 GetColor(string key, Color32 defaultValue) { }

	// RVA: 0x5BCAEC
	private static string EncryptColorValue(string key, UInt32 value) { }

	// RVA: 0x5BCCDC
	public static void SetRect(string key, Rect value) { }

	// RVA: 0x5BCEC8
	public static Rect GetRect(string key) { }

	// RVA: 0x5BCF38
	public static Rect GetRect(string key, Rect defaultValue) { }

	// RVA: 0x5BCD8C
	private static string EncryptRectValue(string key, Rect value) { }

	// RVA: 0x5BD040
	private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue) { }

	// RVA: 0x5BD2EC
	public static void SetRawValue(string key, string encryptedValue) { }

	// RVA: 0x5BD360
	public static string GetRawValue(string key) { }

	// RVA: 0x5BD3CC
	internal static DataType GetRawValueType(string value) { }

	// RVA: 0x5B7DC8
	internal static string EncryptKey(string key) { }

	// RVA: 0x5BD800
	public static bool HasKey(string key) { }

	// RVA: 0x5BD8C0
	public static void DeleteKey(string key) { }

	// RVA: 0x5BD958
	public static void DeleteAll() { }

	// RVA: 0x5BD9D0
	public static void Save() { }

	// RVA: 0x5B8188
	private static string GetEncryptedPrefsString(string key, string encryptedKey) { }

	// RVA: 0x5B83CC
	private static string EncryptData(string key, Byte[] cleanBytes, DataType type) { }

	// RVA: 0x5B8AE8
	internal static Byte[] DecryptData(string key, string encryptedInput) { }

	// RVA: 0x5B7998
	private static UInt32 CalculateChecksum(string input) { }

	// RVA: 0x5BDB58
	private static void SavesTampered() { }

	// RVA: 0x5BDC1C
	private static void PossibleForeignSavesDetected() { }

	// RVA: 0x5B76CC
	private static string GetDeviceId() { }

	// RVA: 0x5BDA48
	private static Byte[] EncryptDecryptBytes(Byte[] bytes, int dataLength, string key) { }

	// RVA: 0x5B8680
	private static string DeprecatedDecryptValue(string value) { }

	// RVA: 0x5BDDEC
	private static string DeprecatedCalculateChecksum(string input) { }

	// RVA: 0x5BDCFC
	private static string get_DeprecatedDeviceId() { }

	// RVA: 0x5BE1A4
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

	// RVA: 0x5BE244
	private void .ctor() { }

	// RVA: 0x5BE24C
	private void .ctor(Byte[] value) { }

	// RVA: 0x5BE2E8
	public static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5BE35C
	public static string EncryptDecrypt(string value) { }

	// RVA: 0x5BD66C
	public static string EncryptDecrypt(string value, string key) { }

	// RVA: 0x5BE400
	public void ApplyNewCryptoKey() { }

	// RVA: 0x5BE778
	public void RandomizeCryptoKey() { }

	// RVA: 0x5BE900
	public string GetEncrypted() { }

	// RVA: 0x5BEA94
	public void SetEncrypted(string encrypted) { }

	// RVA: 0x5BEB9C
	public string GetDecrypted() { }

	// RVA: 0x5BE6AC
	private static Byte[] InternalEncrypt(string value) { }

	// RVA: 0x5BE894
	private static Byte[] InternalEncrypt(string value, string key) { }

	// RVA: 0x5BE504
	private string InternalDecrypt() { }

	// RVA: 0x5BEBA0
	public int get_Length() { }

	// RVA: 0x5BEBCC
	public static ObscuredString op_Implicit(string value) { }

	// RVA: 0x5BECB8
	public static string op_Implicit(ObscuredString value) { }

	// RVA: 0x5BEEC4
	public override string ToString() { }

	// RVA: 0x5BED6C
	public static bool op_Equality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5BEF34
	public static bool op_Inequality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5BEFA4
	public override bool Equals(object obj) { }

	// RVA: 0x5BF024
	public bool Equals(ObscuredString value) { }

	// RVA: 0x5BF1B8
	public bool Equals(ObscuredString value, StringComparison comparisonType) { }

	// RVA: 0x5BF2A0
	public override int GetHashCode() { }

	// RVA: 0x5BEB10
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x5BEA04
	private static string GetString(Byte[] bytes) { }

	// RVA: 0x5BEEC8
	private static bool ArraysEquals(Byte[] a1, Byte[] a2) { }

	// RVA: 0x5BF2C4
	private static void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.Common
internal class Constants
{
	// Fields
	internal const string LOG_PREFIX = "[ACTk] ";

	// Methods

	// RVA: 0x5BF33C
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


