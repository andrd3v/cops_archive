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

	// RVA: 0x5CF850
	private static MonoScriptData Get() { }

	// RVA: 0x5CF950
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

	// RVA: 0x5CF958
	public static UInt32 CalculateHash(Byte[] buf, int len, UInt32 seed) { }

	// RVA: 0x5CFCF4
	public void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
internal class BitconverterExt
{
	// Methods

	// RVA: 0x5CFCFC
	public static Byte[] GetBytes(Decimal dec) { }

	// RVA: 0x5CFE44
	public static Decimal ToDecimal(Byte[] bytes) { }

	// RVA: 0x5CFFC4
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

	// RVA: 0x5CFFCC
	private static bool get_IsMainThread() { }

	// RVA: 0x5D004C
	public static void SetMainThread() { }

	// RVA: 0x5D00D8
	private static void CheckMainThread() { }

	// RVA: 0x5D0208
	public static void set_CryptoKey(string value) { }

	// RVA: 0x5D0274
	public static string get_CryptoKey() { }

	// RVA: 0x5D02F0
	public static string get_DeviceId() { }

	// RVA: 0x5D04A8
	public static void set_DeviceId(string value) { }

	// RVA: 0x5D0514
	internal static string get_DeviceID() { }

	// RVA: 0x5D057C
	internal static void set_DeviceID(string value) { }

	// RVA: 0x5D0640
	private static UInt32 get_DeviceIdHash() { }

	// RVA: 0x5D07F0
	public static void ForceLockToDeviceInit() { }

	// RVA: 0x5D0984
	internal static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5D0A48
	public static void SetInt(string key, int value) { }

	// RVA: 0x5D0CF0
	public static int GetInt(string key) { }

	// RVA: 0x5D0D78
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x5D0C74
	internal static string EncryptIntValue(string key, int value) { }

	// RVA: 0x5D0FF8
	internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue) { }

	// RVA: 0x5D1C70
	public static void SetUInt(string key, UInt32 value) { }

	// RVA: 0x5D1DC0
	public static UInt32 GetUInt(string key) { }

	// RVA: 0x5D1E48
	public static UInt32 GetUInt(string key, UInt32 defaultValue) { }

	// RVA: 0x5D1D44
	private static string EncryptUIntValue(string key, UInt32 value) { }

	// RVA: 0x5D1F24
	private static UInt32 DecryptUIntValue(string key, string encryptedInput, UInt32 defaultValue) { }

	// RVA: 0x5D2070
	public static void SetString(string key, string value) { }

	// RVA: 0x5D21F0
	public static string GetString(string key) { }

	// RVA: 0x5D2294
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x5D215C
	internal static string EncryptStringValue(string key, string value) { }

	// RVA: 0x5D241C
	internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue) { }

	// RVA: 0x5D2578
	public static void SetFloat(string key, float value) { }

	// RVA: 0x5D26D0
	public static float GetFloat(string key) { }

	// RVA: 0x5D2758
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x5D264C
	internal static string EncryptFloatValue(string key, float value) { }

	// RVA: 0x5D28E0
	internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue) { }

	// RVA: 0x5D2A2C
	public static void SetDouble(string key, Double value) { }

	// RVA: 0x5D2B84
	public static Double GetDouble(string key) { }

	// RVA: 0x5D2C0C
	public static Double GetDouble(string key, Double defaultValue) { }

	// RVA: 0x5D2B00
	private static string EncryptDoubleValue(string key, Double value) { }

	// RVA: 0x5D2CE8
	private static Double DecryptDoubleValue(string key, string encryptedInput, Double defaultValue) { }

	// RVA: 0x5D2E34
	public static void SetDecimal(string key, Decimal value) { }

	// RVA: 0x5D2F94
	public static Decimal GetDecimal(string key) { }

	// RVA: 0x5D3058
	public static Decimal GetDecimal(string key, Decimal defaultValue) { }

	// RVA: 0x5D2F0C
	private static string EncryptDecimalValue(string key, Decimal value) { }

	// RVA: 0x5D3140
	private static Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue) { }

	// RVA: 0x5D32C4
	public static void SetLong(string key, Int64 value) { }

	// RVA: 0x5D3414
	public static Int64 GetLong(string key) { }

	// RVA: 0x5D349C
	public static Int64 GetLong(string key, Int64 defaultValue) { }

	// RVA: 0x5D3398
	private static string EncryptLongValue(string key, Int64 value) { }

	// RVA: 0x5D3578
	private static Int64 DecryptLongValue(string key, string encryptedInput, Int64 defaultValue) { }

	// RVA: 0x5D36C4
	public static void SetULong(string key, UInt64 value) { }

	// RVA: 0x5D3814
	public static UInt64 GetULong(string key) { }

	// RVA: 0x5D389C
	public static UInt64 GetULong(string key, UInt64 defaultValue) { }

	// RVA: 0x5D3798
	private static string EncryptULongValue(string key, UInt64 value) { }

	// RVA: 0x5D3978
	private static UInt64 DecryptULongValue(string key, string encryptedInput, UInt64 defaultValue) { }

	// RVA: 0x5D3AC4
	public static void SetBool(string key, bool value) { }

	// RVA: 0x5D3C14
	public static bool GetBool(string key) { }

	// RVA: 0x5D3C9C
	public static bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x5D3B98
	private static string EncryptBoolValue(string key, bool value) { }

	// RVA: 0x5D3D78
	private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue) { }

	// RVA: 0x5D3ED0
	public static void SetByteArray(string key, Byte[] value) { }

	// RVA: 0x5D4000
	public static Byte[] GetByteArray(string key) { }

	// RVA: 0x5D4068
	public static Byte[] GetByteArray(string key, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5D3F94
	private static string EncryptByteArrayValue(string key, Byte[] value) { }

	// RVA: 0x5D4318
	private static Byte[] DecryptByteArrayValue(string key, string encryptedInput, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5D4238
	private static Byte[] ConstructByteArray(Byte value, int length) { }

	// RVA: 0x5D4628
	public static void SetVector2(string key, Vector2 value) { }

	// RVA: 0x5D47A4
	public static Vector2 GetVector2(string key) { }

	// RVA: 0x5D4848
	public static Vector2 GetVector2(string key, Vector2 defaultValue) { }

	// RVA: 0x5D46C0
	private static string EncryptVector2Value(string key, Vector2 value) { }

	// RVA: 0x5D4928
	private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue) { }

	// RVA: 0x5D4B50
	public static void SetVector3(string key, Vector3 value) { }

	// RVA: 0x5D4D0C
	public static Vector3 GetVector3(string key) { }

	// RVA: 0x5D4DC0
	public static Vector3 GetVector3(string key, Vector3 defaultValue) { }

	// RVA: 0x5D4BF8
	private static string EncryptVector3Value(string key, Vector3 value) { }

	// RVA: 0x5D4EB8
	private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue) { }

	// RVA: 0x5D512C
	public static void SetQuaternion(string key, Quaternion value) { }

	// RVA: 0x5D5318
	public static Quaternion GetQuaternion(string key) { }

	// RVA: 0x5D53D0
	public static Quaternion GetQuaternion(string key, Quaternion defaultValue) { }

	// RVA: 0x5D51DC
	private static string EncryptQuaternionValue(string key, Quaternion value) { }

	// RVA: 0x5D54D8
	private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue) { }

	// RVA: 0x5D5784
	public static void SetColor(string key, Color32 value) { }

	// RVA: 0x5D58E0
	public static Color32 GetColor(string key) { }

	// RVA: 0x5D5968
	public static Color32 GetColor(string key, Color32 defaultValue) { }

	// RVA: 0x5D5864
	private static string EncryptColorValue(string key, UInt32 value) { }

	// RVA: 0x5D5A54
	public static void SetRect(string key, Rect value) { }

	// RVA: 0x5D5C40
	public static Rect GetRect(string key) { }

	// RVA: 0x5D5CB0
	public static Rect GetRect(string key, Rect defaultValue) { }

	// RVA: 0x5D5B04
	private static string EncryptRectValue(string key, Rect value) { }

	// RVA: 0x5D5DB8
	private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue) { }

	// RVA: 0x5D6064
	public static void SetRawValue(string key, string encryptedValue) { }

	// RVA: 0x5D60D8
	public static string GetRawValue(string key) { }

	// RVA: 0x5D6144
	internal static DataType GetRawValueType(string value) { }

	// RVA: 0x5D0B40
	internal static string EncryptKey(string key) { }

	// RVA: 0x5D6578
	public static bool HasKey(string key) { }

	// RVA: 0x5D6638
	public static void DeleteKey(string key) { }

	// RVA: 0x5D66D0
	public static void DeleteAll() { }

	// RVA: 0x5D6748
	public static void Save() { }

	// RVA: 0x5D0F00
	private static string GetEncryptedPrefsString(string key, string encryptedKey) { }

	// RVA: 0x5D1144
	private static string EncryptData(string key, Byte[] cleanBytes, DataType type) { }

	// RVA: 0x5D1860
	internal static Byte[] DecryptData(string key, string encryptedInput) { }

	// RVA: 0x5D0710
	private static UInt32 CalculateChecksum(string input) { }

	// RVA: 0x5D68D0
	private static void SavesTampered() { }

	// RVA: 0x5D6994
	private static void PossibleForeignSavesDetected() { }

	// RVA: 0x5D0444
	private static string GetDeviceId() { }

	// RVA: 0x5D67C0
	private static Byte[] EncryptDecryptBytes(Byte[] bytes, int dataLength, string key) { }

	// RVA: 0x5D13F8
	private static string DeprecatedDecryptValue(string value) { }

	// RVA: 0x5D6B64
	private static string DeprecatedCalculateChecksum(string input) { }

	// RVA: 0x5D6A74
	private static string get_DeprecatedDeviceId() { }

	// RVA: 0x5D6F1C
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

	// RVA: 0x5D6FBC
	private void .ctor() { }

	// RVA: 0x5D6FC4
	private void .ctor(Byte[] value) { }

	// RVA: 0x5D7060
	public static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5D70D4
	public static string EncryptDecrypt(string value) { }

	// RVA: 0x5D63E4
	public static string EncryptDecrypt(string value, string key) { }

	// RVA: 0x5D7178
	public void ApplyNewCryptoKey() { }

	// RVA: 0x5D74F0
	public void RandomizeCryptoKey() { }

	// RVA: 0x5D7678
	public string GetEncrypted() { }

	// RVA: 0x5D780C
	public void SetEncrypted(string encrypted) { }

	// RVA: 0x5D7914
	public string GetDecrypted() { }

	// RVA: 0x5D7424
	private static Byte[] InternalEncrypt(string value) { }

	// RVA: 0x5D760C
	private static Byte[] InternalEncrypt(string value, string key) { }

	// RVA: 0x5D727C
	private string InternalDecrypt() { }

	// RVA: 0x5D7918
	public int get_Length() { }

	// RVA: 0x5D7944
	public static ObscuredString op_Implicit(string value) { }

	// RVA: 0x5D7A30
	public static string op_Implicit(ObscuredString value) { }

	// RVA: 0x5D7C3C
	public override string ToString() { }

	// RVA: 0x5D7AE4
	public static bool op_Equality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5D7CAC
	public static bool op_Inequality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5D7D1C
	public override bool Equals(object obj) { }

	// RVA: 0x5D7D9C
	public bool Equals(ObscuredString value) { }

	// RVA: 0x5D7F30
	public bool Equals(ObscuredString value, StringComparison comparisonType) { }

	// RVA: 0x5D8018
	public override int GetHashCode() { }

	// RVA: 0x5D7888
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x5D777C
	private static string GetString(Byte[] bytes) { }

	// RVA: 0x5D7C40
	private static bool ArraysEquals(Byte[] a1, Byte[] a2) { }

	// RVA: 0x5D803C
	private static void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.Common
internal class Constants
{
	// Fields
	internal const string LOG_PREFIX = "[ACTk] ";

	// Methods

	// RVA: 0x5D80B4
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


