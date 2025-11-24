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

	// RVA: 0xE0EEDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE0EF98
	public virtual void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
public class MiniJson
{
	// Methods

	// RVA: 0xE0EFAC
	public static string JsonEncode(object json) { }

	// RVA: 0xE0EFB4
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

	// RVA: 0xE0F258
	public static bool IsWordBreak(Char c) { }

	// RVA: 0xE0F328
	private void .ctor(string jsonString) { }

	// RVA: 0xE0EFCC
	public static object Parse(string jsonString) { }

	// RVA: 0xE0F3D0
	public void Dispose() { }

	// RVA: 0xE0F40C
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0xE0FCE8
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0xE0F3A8
	private object ParseValue() { }

	// RVA: 0xE0FDF8
	private object ParseByToken(TOKEN token) { }

	// RVA: 0xE0F83C
	private string ParseString() { }

	// RVA: 0xE0FF04
	private object ParseNumber() { }

	// RVA: 0xE102F8
	private void EatWhitespace() { }

	// RVA: 0xE103F8
	private Char get_PeekChar() { }

	// RVA: 0xE10060
	private Char get_NextChar() { }

	// RVA: 0xE100EC
	private string get_NextWord() { }

	// RVA: 0xE0F598
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private readonly StringBuilder builder; // 0x10

	// Methods

	// RVA: 0xE10484
	private void .ctor() { }

	// RVA: 0xE0F184
	public static string Serialize(object obj) { }

	// RVA: 0xE104FC
	private void SerializeValue(object value) { }

	// RVA: 0xE10D0C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0xE109C4
	private void SerializeArray(IList anArray) { }

	// RVA: 0xE10708
	private void SerializeString(string str) { }

	// RVA: 0xE11190
	private void SerializeOther(object value) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class Json
{
	// Methods

	// RVA: 0xE0EFC0
	public static object Deserialize(string json) { }

	// RVA: 0xE0EFB0
	public static string Serialize(object obj) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class MiniJsonExtensions
{
	// Methods

	// RVA: 0xE11464
	public static string GetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key, string defaultValue) { }

	// RVA: 0xE11520
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.Object> obj) { }

	// RVA: 0xE11524
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.String> obj) { }

	// RVA: 0xE11528
	public static System.Collections.Generic.List<System.Object> ArrayListFromJson(string json) { }

	// RVA: 0xE115C8
	public static System.Collections.Generic.Dictionary<System.String,System.Object> HashtableFromJson(string json) { }

}


