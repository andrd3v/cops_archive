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

	// RVA: 0x5EA7E4
	private static MonoScriptData Get() { }

	// RVA: 0x5EA8E4
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

	// RVA: 0x5EA8EC
	public static UInt32 CalculateHash(Byte[] buf, int len, UInt32 seed) { }

	// RVA: 0x5EAC8C
	public void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
internal class BitconverterExt
{
	// Methods

	// RVA: 0x5EAC94
	public static Byte[] GetBytes(Decimal dec) { }

	// RVA: 0x5EADDC
	public static Decimal ToDecimal(Byte[] bytes) { }

	// RVA: 0x5EAF5C
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

	// RVA: 0x5EAF64
	private static bool get_IsMainThread() { }

	// RVA: 0x5EAFE4
	public static void SetMainThread() { }

	// RVA: 0x5EB070
	private static void CheckMainThread() { }

	// RVA: 0x5EB1A0
	public static void set_CryptoKey(string value) { }

	// RVA: 0x5EB20C
	public static string get_CryptoKey() { }

	// RVA: 0x5EB288
	public static string get_DeviceId() { }

	// RVA: 0x5EB440
	public static void set_DeviceId(string value) { }

	// RVA: 0x5EB4AC
	internal static string get_DeviceID() { }

	// RVA: 0x5EB514
	internal static void set_DeviceID(string value) { }

	// RVA: 0x5EB5D8
	private static UInt32 get_DeviceIdHash() { }

	// RVA: 0x5EB788
	public static void ForceLockToDeviceInit() { }

	// RVA: 0x5EB91C
	internal static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5EB9E0
	public static void SetInt(string key, int value) { }

	// RVA: 0x5EBC88
	public static int GetInt(string key) { }

	// RVA: 0x5EBD10
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x5EBC0C
	internal static string EncryptIntValue(string key, int value) { }

	// RVA: 0x5EBF90
	internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue) { }

	// RVA: 0x5ECC08
	public static void SetUInt(string key, UInt32 value) { }

	// RVA: 0x5ECD58
	public static UInt32 GetUInt(string key) { }

	// RVA: 0x5ECDE0
	public static UInt32 GetUInt(string key, UInt32 defaultValue) { }

	// RVA: 0x5ECCDC
	private static string EncryptUIntValue(string key, UInt32 value) { }

	// RVA: 0x5ECEBC
	private static UInt32 DecryptUIntValue(string key, string encryptedInput, UInt32 defaultValue) { }

	// RVA: 0x5ED008
	public static void SetString(string key, string value) { }

	// RVA: 0x5ED188
	public static string GetString(string key) { }

	// RVA: 0x5ED22C
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x5ED0F4
	internal static string EncryptStringValue(string key, string value) { }

	// RVA: 0x5ED3B4
	internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue) { }

	// RVA: 0x5ED510
	public static void SetFloat(string key, float value) { }

	// RVA: 0x5ED668
	public static float GetFloat(string key) { }

	// RVA: 0x5ED6F0
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x5ED5E4
	internal static string EncryptFloatValue(string key, float value) { }

	// RVA: 0x5ED878
	internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue) { }

	// RVA: 0x5ED9C4
	public static void SetDouble(string key, Double value) { }

	// RVA: 0x5EDB1C
	public static Double GetDouble(string key) { }

	// RVA: 0x5EDBA4
	public static Double GetDouble(string key, Double defaultValue) { }

	// RVA: 0x5EDA98
	private static string EncryptDoubleValue(string key, Double value) { }

	// RVA: 0x5EDC80
	private static Double DecryptDoubleValue(string key, string encryptedInput, Double defaultValue) { }

	// RVA: 0x5EDDCC
	public static void SetDecimal(string key, Decimal value) { }

	// RVA: 0x5EDF2C
	public static Decimal GetDecimal(string key) { }

	// RVA: 0x5EDFF0
	public static Decimal GetDecimal(string key, Decimal defaultValue) { }

	// RVA: 0x5EDEA4
	private static string EncryptDecimalValue(string key, Decimal value) { }

	// RVA: 0x5EE0D8
	private static Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue) { }

	// RVA: 0x5EE25C
	public static void SetLong(string key, Int64 value) { }

	// RVA: 0x5EE3AC
	public static Int64 GetLong(string key) { }

	// RVA: 0x5EE434
	public static Int64 GetLong(string key, Int64 defaultValue) { }

	// RVA: 0x5EE330
	private static string EncryptLongValue(string key, Int64 value) { }

	// RVA: 0x5EE510
	private static Int64 DecryptLongValue(string key, string encryptedInput, Int64 defaultValue) { }

	// RVA: 0x5EE65C
	public static void SetULong(string key, UInt64 value) { }

	// RVA: 0x5EE7AC
	public static UInt64 GetULong(string key) { }

	// RVA: 0x5EE834
	public static UInt64 GetULong(string key, UInt64 defaultValue) { }

	// RVA: 0x5EE730
	private static string EncryptULongValue(string key, UInt64 value) { }

	// RVA: 0x5EE910
	private static UInt64 DecryptULongValue(string key, string encryptedInput, UInt64 defaultValue) { }

	// RVA: 0x5EEA5C
	public static void SetBool(string key, bool value) { }

	// RVA: 0x5EEBAC
	public static bool GetBool(string key) { }

	// RVA: 0x5EEC34
	public static bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x5EEB30
	private static string EncryptBoolValue(string key, bool value) { }

	// RVA: 0x5EED10
	private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue) { }

	// RVA: 0x5EEE68
	public static void SetByteArray(string key, Byte[] value) { }

	// RVA: 0x5EEF98
	public static Byte[] GetByteArray(string key) { }

	// RVA: 0x5EF000
	public static Byte[] GetByteArray(string key, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5EEF2C
	private static string EncryptByteArrayValue(string key, Byte[] value) { }

	// RVA: 0x5EF2B0
	private static Byte[] DecryptByteArrayValue(string key, string encryptedInput, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5EF1D0
	private static Byte[] ConstructByteArray(Byte value, int length) { }

	// RVA: 0x5EF5C0
	public static void SetVector2(string key, Vector2 value) { }

	// RVA: 0x5EF73C
	public static Vector2 GetVector2(string key) { }

	// RVA: 0x5EF7E0
	public static Vector2 GetVector2(string key, Vector2 defaultValue) { }

	// RVA: 0x5EF658
	private static string EncryptVector2Value(string key, Vector2 value) { }

	// RVA: 0x5EF8C0
	private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue) { }

	// RVA: 0x5EFAE8
	public static void SetVector3(string key, Vector3 value) { }

	// RVA: 0x5EFCA4
	public static Vector3 GetVector3(string key) { }

	// RVA: 0x5EFD58
	public static Vector3 GetVector3(string key, Vector3 defaultValue) { }

	// RVA: 0x5EFB90
	private static string EncryptVector3Value(string key, Vector3 value) { }

	// RVA: 0x5EFE50
	private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue) { }

	// RVA: 0x5F00C4
	public static void SetQuaternion(string key, Quaternion value) { }

	// RVA: 0x5F02B0
	public static Quaternion GetQuaternion(string key) { }

	// RVA: 0x5F0368
	public static Quaternion GetQuaternion(string key, Quaternion defaultValue) { }

	// RVA: 0x5F0174
	private static string EncryptQuaternionValue(string key, Quaternion value) { }

	// RVA: 0x5F0470
	private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue) { }

	// RVA: 0x5F071C
	public static void SetColor(string key, Color32 value) { }

	// RVA: 0x5F0878
	public static Color32 GetColor(string key) { }

	// RVA: 0x5F0900
	public static Color32 GetColor(string key, Color32 defaultValue) { }

	// RVA: 0x5F07FC
	private static string EncryptColorValue(string key, UInt32 value) { }

	// RVA: 0x5F09EC
	public static void SetRect(string key, Rect value) { }

	// RVA: 0x5F0BD8
	public static Rect GetRect(string key) { }

	// RVA: 0x5F0C48
	public static Rect GetRect(string key, Rect defaultValue) { }

	// RVA: 0x5F0A9C
	private static string EncryptRectValue(string key, Rect value) { }

	// RVA: 0x5F0D50
	private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue) { }

	// RVA: 0x5F0FFC
	public static void SetRawValue(string key, string encryptedValue) { }

	// RVA: 0x5F1070
	public static string GetRawValue(string key) { }

	// RVA: 0x5F10DC
	internal static DataType GetRawValueType(string value) { }

	// RVA: 0x5EBAD8
	internal static string EncryptKey(string key) { }

	// RVA: 0x5F1510
	public static bool HasKey(string key) { }

	// RVA: 0x5F15D0
	public static void DeleteKey(string key) { }

	// RVA: 0x5F1668
	public static void DeleteAll() { }

	// RVA: 0x5F16E0
	public static void Save() { }

	// RVA: 0x5EBE98
	private static string GetEncryptedPrefsString(string key, string encryptedKey) { }

	// RVA: 0x5EC0DC
	private static string EncryptData(string key, Byte[] cleanBytes, DataType type) { }

	// RVA: 0x5EC7F8
	internal static Byte[] DecryptData(string key, string encryptedInput) { }

	// RVA: 0x5EB6A8
	private static UInt32 CalculateChecksum(string input) { }

	// RVA: 0x5F1868
	private static void SavesTampered() { }

	// RVA: 0x5F192C
	private static void PossibleForeignSavesDetected() { }

	// RVA: 0x5EB3DC
	private static string GetDeviceId() { }

	// RVA: 0x5F1758
	private static Byte[] EncryptDecryptBytes(Byte[] bytes, int dataLength, string key) { }

	// RVA: 0x5EC390
	private static string DeprecatedDecryptValue(string value) { }

	// RVA: 0x5F1AFC
	private static string DeprecatedCalculateChecksum(string input) { }

	// RVA: 0x5F1A0C
	private static string get_DeprecatedDeviceId() { }

	// RVA: 0x5F1EB4
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

	// RVA: 0x5F1F54
	private void .ctor() { }

	// RVA: 0x5F1F5C
	private void .ctor(Byte[] value) { }

	// RVA: 0x5F1FF8
	public static void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5F206C
	public static string EncryptDecrypt(string value) { }

	// RVA: 0x5F137C
	public static string EncryptDecrypt(string value, string key) { }

	// RVA: 0x5F2110
	public void ApplyNewCryptoKey() { }

	// RVA: 0x5F2488
	public void RandomizeCryptoKey() { }

	// RVA: 0x5F2610
	public string GetEncrypted() { }

	// RVA: 0x5F27A4
	public void SetEncrypted(string encrypted) { }

	// RVA: 0x5F28AC
	public string GetDecrypted() { }

	// RVA: 0x5F23BC
	private static Byte[] InternalEncrypt(string value) { }

	// RVA: 0x5F25A4
	private static Byte[] InternalEncrypt(string value, string key) { }

	// RVA: 0x5F2214
	private string InternalDecrypt() { }

	// RVA: 0x5F28B0
	public int get_Length() { }

	// RVA: 0x5F28DC
	public static ObscuredString op_Implicit(string value) { }

	// RVA: 0x5F29C8
	public static string op_Implicit(ObscuredString value) { }

	// RVA: 0x5F2BD4
	public override string ToString() { }

	// RVA: 0x5F2A7C
	public static bool op_Equality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5F2C44
	public static bool op_Inequality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5F2CB4
	public override bool Equals(object obj) { }

	// RVA: 0x5F2D34
	public bool Equals(ObscuredString value) { }

	// RVA: 0x5F2EC8
	public bool Equals(ObscuredString value, StringComparison comparisonType) { }

	// RVA: 0x5F2FB0
	public override int GetHashCode() { }

	// RVA: 0x5F2820
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x5F2714
	private static string GetString(Byte[] bytes) { }

	// RVA: 0x5F2BD8
	private static bool ArraysEquals(Byte[] a1, Byte[] a2) { }

	// RVA: 0x5F2FD4
	private static void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.Common
internal class Constants
{
	// Fields
	internal const string LOG_PREFIX = "[ACTk] ";

	// Methods

	// RVA: 0x5F304C
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


