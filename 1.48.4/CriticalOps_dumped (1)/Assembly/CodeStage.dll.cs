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

	// RVA: 0x5B1838
	MonoScriptData Get() { }

	// RVA: 0x5B1938
	void .ctor() { }

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

	// RVA: 0x5B1940
	UInt32 CalculateHash(Byte[] buf, int len, UInt32 seed) { }

	// RVA: 0x5B1CDC
	void .ctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
internal class BitconverterExt 
{
	// Methods

	// RVA: 0x5B1CE4
	Byte[] GetBytes(Decimal dec) { }

	// RVA: 0x5B1E2C
	Decimal ToDecimal(Byte[] bytes) { }

	// RVA: 0x5B1FAC
	void .ctor() { }

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
	private const string RAW_NOT_FOUND = 5736247168;
	private const string DATA_SEPARATOR = 5736713696;
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

	// RVA: 0x5B1FB4
	bool get_IsMainThread() { }

	// RVA: 0x5B2034
	void SetMainThread() { }

	// RVA: 0x5B20C0
	void CheckMainThread() { }

	// RVA: 0x5B21F0
	void set_CryptoKey(string value) { }

	// RVA: 0x5B225C
	string get_CryptoKey() { }

	// RVA: 0x5B22D8
	string get_DeviceId() { }

	// RVA: 0x5B2490
	void set_DeviceId(string value) { }

	// RVA: 0x5B24FC
	string get_DeviceID() { }

	// RVA: 0x5B2564
	void set_DeviceID(string value) { }

	// RVA: 0x5B2628
	UInt32 get_DeviceIdHash() { }

	// RVA: 0x5B27D8
	void ForceLockToDeviceInit() { }

	// RVA: 0x5B296C
	void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5B2A30
	void SetInt(string key, int value) { }

	// RVA: 0x5B2CD8
	int GetInt(string key) { }

	// RVA: 0x5B2D60
	int GetInt(string key, int defaultValue) { }

	// RVA: 0x5B2C5C
	string EncryptIntValue(string key, int value) { }

	// RVA: 0x5B2FE0
	int DecryptIntValue(string key, string encryptedInput, int defaultValue) { }

	// RVA: 0x5B3C58
	void SetUInt(string key, UInt32 value) { }

	// RVA: 0x5B3DA8
	UInt32 GetUInt(string key) { }

	// RVA: 0x5B3E30
	UInt32 GetUInt(string key, UInt32 defaultValue) { }

	// RVA: 0x5B3D2C
	string EncryptUIntValue(string key, UInt32 value) { }

	// RVA: 0x5B3F0C
	UInt32 DecryptUIntValue(string key, string encryptedInput, UInt32 defaultValue) { }

	// RVA: 0x5B4058
	void SetString(string key, string value) { }

	// RVA: 0x5B41D8
	string GetString(string key) { }

	// RVA: 0x5B427C
	string GetString(string key, string defaultValue) { }

	// RVA: 0x5B4144
	string EncryptStringValue(string key, string value) { }

	// RVA: 0x5B4404
	string DecryptStringValue(string key, string encryptedInput, string defaultValue) { }

	// RVA: 0x5B4560
	void SetFloat(string key, float value) { }

	// RVA: 0x5B46B8
	float GetFloat(string key) { }

	// RVA: 0x5B4740
	float GetFloat(string key, float defaultValue) { }

	// RVA: 0x5B4634
	string EncryptFloatValue(string key, float value) { }

	// RVA: 0x5B48C8
	float DecryptFloatValue(string key, string encryptedInput, float defaultValue) { }

	// RVA: 0x5B4A14
	void SetDouble(string key, Double value) { }

	// RVA: 0x5B4B6C
	Double GetDouble(string key) { }

	// RVA: 0x5B4BF4
	Double GetDouble(string key, Double defaultValue) { }

	// RVA: 0x5B4AE8
	string EncryptDoubleValue(string key, Double value) { }

	// RVA: 0x5B4CD0
	Double DecryptDoubleValue(string key, string encryptedInput, Double defaultValue) { }

	// RVA: 0x5B4E1C
	void SetDecimal(string key, Decimal value) { }

	// RVA: 0x5B4F7C
	Decimal GetDecimal(string key) { }

	// RVA: 0x5B5040
	Decimal GetDecimal(string key, Decimal defaultValue) { }

	// RVA: 0x5B4EF4
	string EncryptDecimalValue(string key, Decimal value) { }

	// RVA: 0x5B5128
	Decimal DecryptDecimalValue(string key, string encryptedInput, Decimal defaultValue) { }

	// RVA: 0x5B52AC
	void SetLong(string key, Int64 value) { }

	// RVA: 0x5B53FC
	Int64 GetLong(string key) { }

	// RVA: 0x5B5484
	Int64 GetLong(string key, Int64 defaultValue) { }

	// RVA: 0x5B5380
	string EncryptLongValue(string key, Int64 value) { }

	// RVA: 0x5B5560
	Int64 DecryptLongValue(string key, string encryptedInput, Int64 defaultValue) { }

	// RVA: 0x5B56AC
	void SetULong(string key, UInt64 value) { }

	// RVA: 0x5B57FC
	UInt64 GetULong(string key) { }

	// RVA: 0x5B5884
	UInt64 GetULong(string key, UInt64 defaultValue) { }

	// RVA: 0x5B5780
	string EncryptULongValue(string key, UInt64 value) { }

	// RVA: 0x5B5960
	UInt64 DecryptULongValue(string key, string encryptedInput, UInt64 defaultValue) { }

	// RVA: 0x5B5AAC
	void SetBool(string key, bool value) { }

	// RVA: 0x5B5BFC
	bool GetBool(string key) { }

	// RVA: 0x5B5C84
	bool GetBool(string key, bool defaultValue) { }

	// RVA: 0x5B5B80
	string EncryptBoolValue(string key, bool value) { }

	// RVA: 0x5B5D60
	bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue) { }

	// RVA: 0x5B5EB8
	void SetByteArray(string key, Byte[] value) { }

	// RVA: 0x5B5FE8
	Byte[] GetByteArray(string key) { }

	// RVA: 0x5B6050
	Byte[] GetByteArray(string key, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5B5F7C
	string EncryptByteArrayValue(string key, Byte[] value) { }

	// RVA: 0x5B6300
	Byte[] DecryptByteArrayValue(string key, string encryptedInput, Byte defaultValue, int defaultLength) { }

	// RVA: 0x5B6220
	Byte[] ConstructByteArray(Byte value, int length) { }

	// RVA: 0x5B6610
	void SetVector2(string key, Vector2 value) { }

	// RVA: 0x5B678C
	Vector2 GetVector2(string key) { }

	// RVA: 0x5B6830
	Vector2 GetVector2(string key, Vector2 defaultValue) { }

	// RVA: 0x5B66A8
	string EncryptVector2Value(string key, Vector2 value) { }

	// RVA: 0x5B6910
	Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue) { }

	// RVA: 0x5B6B38
	void SetVector3(string key, Vector3 value) { }

	// RVA: 0x5B6CF4
	Vector3 GetVector3(string key) { }

	// RVA: 0x5B6DA8
	Vector3 GetVector3(string key, Vector3 defaultValue) { }

	// RVA: 0x5B6BE0
	string EncryptVector3Value(string key, Vector3 value) { }

	// RVA: 0x5B6EA0
	Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue) { }

	// RVA: 0x5B7114
	void SetQuaternion(string key, Quaternion value) { }

	// RVA: 0x5B7300
	Quaternion GetQuaternion(string key) { }

	// RVA: 0x5B73B8
	Quaternion GetQuaternion(string key, Quaternion defaultValue) { }

	// RVA: 0x5B71C4
	string EncryptQuaternionValue(string key, Quaternion value) { }

	// RVA: 0x5B74C0
	Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue) { }

	// RVA: 0x5B776C
	void SetColor(string key, Color32 value) { }

	// RVA: 0x5B78C8
	Color32 GetColor(string key) { }

	// RVA: 0x5B7950
	Color32 GetColor(string key, Color32 defaultValue) { }

	// RVA: 0x5B784C
	string EncryptColorValue(string key, UInt32 value) { }

	// RVA: 0x5B7A3C
	void SetRect(string key, Rect value) { }

	// RVA: 0x5B7C28
	Rect GetRect(string key) { }

	// RVA: 0x5B7C98
	Rect GetRect(string key, Rect defaultValue) { }

	// RVA: 0x5B7AEC
	string EncryptRectValue(string key, Rect value) { }

	// RVA: 0x5B7DA0
	Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue) { }

	// RVA: 0x5B804C
	void SetRawValue(string key, string encryptedValue) { }

	// RVA: 0x5B80C0
	string GetRawValue(string key) { }

	// RVA: 0x5B812C
	DataType GetRawValueType(string value) { }

	// RVA: 0x5B2B28
	string EncryptKey(string key) { }

	// RVA: 0x5B8560
	bool HasKey(string key) { }

	// RVA: 0x5B8620
	void DeleteKey(string key) { }

	// RVA: 0x5B86B8
	void DeleteAll() { }

	// RVA: 0x5B8730
	void Save() { }

	// RVA: 0x5B2EE8
	string GetEncryptedPrefsString(string key, string encryptedKey) { }

	// RVA: 0x5B312C
	string EncryptData(string key, Byte[] cleanBytes, DataType type) { }

	// RVA: 0x5B3848
	Byte[] DecryptData(string key, string encryptedInput) { }

	// RVA: 0x5B26F8
	UInt32 CalculateChecksum(string input) { }

	// RVA: 0x5B88B8
	void SavesTampered() { }

	// RVA: 0x5B897C
	void PossibleForeignSavesDetected() { }

	// RVA: 0x5B242C
	string GetDeviceId() { }

	// RVA: 0x5B87A8
	Byte[] EncryptDecryptBytes(Byte[] bytes, int dataLength, string key) { }

	// RVA: 0x5B33E0
	string DeprecatedDecryptValue(string value) { }

	// RVA: 0x5B8B4C
	string DeprecatedCalculateChecksum(string input) { }

	// RVA: 0x5B8A5C
	string get_DeprecatedDeviceId() { }

	// RVA: 0x5B8F04
	void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.ObscuredTypes
public sealed class ObscuredString 
{
	// Fields
	private static string s_cryptoKey; // 0x0
	private string currentCryptoKey; // 0x10
	private Byte[] hiddenValue; // 0x18
	private bool inited; // 0x20

	// Methods

	// RVA: 0x5B8FA4
	void .ctor() { }

	// RVA: 0x5B8FAC
	void .ctor(Byte[] value) { }

	// RVA: 0x5B9048
	void SetNewCryptoKey(string newKey) { }

	// RVA: 0x5B90BC
	string EncryptDecrypt(string value) { }

	// RVA: 0x5B83CC
	string EncryptDecrypt(string value, string key) { }

	// RVA: 0x5B9160
	void ApplyNewCryptoKey() { }

	// RVA: 0x5B94D8
	void RandomizeCryptoKey() { }

	// RVA: 0x5B9660
	string GetEncrypted() { }

	// RVA: 0x5B97F4
	void SetEncrypted(string encrypted) { }

	// RVA: 0x5B98FC
	string GetDecrypted() { }

	// RVA: 0x5B940C
	Byte[] InternalEncrypt(string value) { }

	// RVA: 0x5B95F4
	Byte[] InternalEncrypt(string value, string key) { }

	// RVA: 0x5B9264
	string InternalDecrypt() { }

	// RVA: 0x5B9900
	int get_Length() { }

	// RVA: 0x5B992C
	ObscuredString op_Implicit(string value) { }

	// RVA: 0x5B9A18
	string op_Implicit(ObscuredString value) { }

	// RVA: 0x5B9C24
	string ToString() { }

	// RVA: 0x5B9ACC
	bool op_Equality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5B9C94
	bool op_Inequality(ObscuredString a, ObscuredString b) { }

	// RVA: 0x5B9D04
	bool Equals(object obj) { }

	// RVA: 0x5B9D84
	bool Equals(ObscuredString value) { }

	// RVA: 0x5B9F18
	bool Equals(ObscuredString value, StringComparison comparisonType) { }

	// RVA: 0x5BA000
	int GetHashCode() { }

	// RVA: 0x5B9870
	Byte[] GetBytes(string str) { }

	// RVA: 0x5B9764
	string GetString(Byte[] bytes) { }

	// RVA: 0x5B9C28
	bool ArraysEquals(Byte[] a1, Byte[] a2) { }

	// RVA: 0x5BA024
	void .cctor() { }

}

// Namespace: CodeStage.AntiCheat.Common
internal class Constants 
{
	// Fields
	internal const string LOG_PREFIX = 5736094960;

	// Methods

	// RVA: 0x5BA09C
	void .ctor() { }

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


