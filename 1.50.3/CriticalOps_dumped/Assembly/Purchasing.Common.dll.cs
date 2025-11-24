// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
public interface INativeStore
{
	// Methods

	// RVA: -1
	public abstract void RetrieveProducts(string json) { }

	// RVA: -1
	public abstract void Purchase(string productJSON, string developerPayload) { }

	// RVA: -1
	public abstract void FinishTransaction(string productJSON, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal sealed class UnityPurchasingCallback
{
	// Methods

	// RVA: 0xE37730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE377EC
	public virtual void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
public class MiniJson
{
	// Methods

	// RVA: 0xE37800
	public static string JsonEncode(object json) { }

	// RVA: 0xE37808
	public static object JsonDecode(string json) { }

}

// Namespace: 
private enum TOKEN
{
	// Fields
	public int value__; // 0x10
	public const TOKEN NONE = 0;
	public const TOKEN CURLY_OPEN = 1;
	public const TOKEN CURLY_CLOSE = 2;
	public const TOKEN SQUARED_OPEN = 3;
	public const TOKEN SQUARED_CLOSE = 4;
	public const TOKEN COLON = 5;
	public const TOKEN COMMA = 6;
	public const TOKEN STRING = 7;
	public const TOKEN NUMBER = 8;
	public const TOKEN TRUE = 9;
	public const TOKEN FALSE = 10;
	public const TOKEN NULL = 11;
}

// Namespace: 
private sealed class Parser
{
	// Fields
	private StringReader json; // 0x10

	// Methods

	// RVA: 0xE37AAC
	public static bool IsWordBreak(Char c) { }

	// RVA: 0xE37B7C
	private void .ctor(string jsonString) { }

	// RVA: 0xE37820
	public static object Parse(string jsonString) { }

	// RVA: 0xE37C24
	public void Dispose() { }

	// RVA: 0xE37C60
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0xE3853C
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0xE37BFC
	private object ParseValue() { }

	// RVA: 0xE3864C
	private object ParseByToken(TOKEN token) { }

	// RVA: 0xE38090
	private string ParseString() { }

	// RVA: 0xE38758
	private object ParseNumber() { }

	// RVA: 0xE38B4C
	private void EatWhitespace() { }

	// RVA: 0xE38C4C
	private Char get_PeekChar() { }

	// RVA: 0xE388B4
	private Char get_NextChar() { }

	// RVA: 0xE38940
	private string get_NextWord() { }

	// RVA: 0xE37DEC
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private readonly StringBuilder builder; // 0x10

	// Methods

	// RVA: 0xE38CD8
	private void .ctor() { }

	// RVA: 0xE379D8
	public static string Serialize(object obj) { }

	// RVA: 0xE38D50
	private void SerializeValue(object value) { }

	// RVA: 0xE39560
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0xE39218
	private void SerializeArray(IList anArray) { }

	// RVA: 0xE38F5C
	private void SerializeString(string str) { }

	// RVA: 0xE399E4
	private void SerializeOther(object value) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class Json
{
	// Methods

	// RVA: 0xE37814
	public static object Deserialize(string json) { }

	// RVA: 0xE37804
	public static string Serialize(object obj) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class MiniJsonExtensions
{
	// Methods

	// RVA: 0xE39CB8
	public static string GetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key, string defaultValue) { }

	// RVA: 0xE39D74
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.Object> obj) { }

	// RVA: 0xE39D78
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.String> obj) { }

	// RVA: 0xE39D7C
	public static System.Collections.Generic.List<System.Object> ArrayListFromJson(string json) { }

	// RVA: 0xE39E1C
	public static System.Collections.Generic.Dictionary<System.String,System.Object> HashtableFromJson(string json) { }

}


