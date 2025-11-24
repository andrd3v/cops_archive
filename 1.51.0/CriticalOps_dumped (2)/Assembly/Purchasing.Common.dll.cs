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

	// RVA: 0xE76F8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE77048
	public virtual void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
public class MiniJson
{
	// Methods

	// RVA: 0xE7705C
	public static string JsonEncode(object json) { }

	// RVA: 0xE77064
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

	// RVA: 0xE77308
	public static bool IsWordBreak(Char c) { }

	// RVA: 0xE773C8
	private void .ctor(string jsonString) { }

	// RVA: 0xE7707C
	public static object Parse(string jsonString) { }

	// RVA: 0xE77470
	public void Dispose() { }

	// RVA: 0xE774AC
	private System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0xE77D88
	private System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0xE77448
	private object ParseValue() { }

	// RVA: 0xE77E98
	private object ParseByToken(TOKEN token) { }

	// RVA: 0xE778DC
	private string ParseString() { }

	// RVA: 0xE77F50
	private object ParseNumber() { }

	// RVA: 0xE78330
	private void EatWhitespace() { }

	// RVA: 0xE78414
	private Char get_PeekChar() { }

	// RVA: 0xE780A0
	private Char get_NextChar() { }

	// RVA: 0xE7812C
	private string get_NextWord() { }

	// RVA: 0xE77638
	private TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer
{
	// Fields
	private readonly StringBuilder builder; // 0x10

	// Methods

	// RVA: 0xE784A0
	private void .ctor() { }

	// RVA: 0xE77234
	public static string Serialize(object obj) { }

	// RVA: 0xE78518
	private void SerializeValue(object value) { }

	// RVA: 0xE78CF4
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0xE789AC
	private void SerializeArray(IList anArray) { }

	// RVA: 0xE786F0
	private void SerializeString(string str) { }

	// RVA: 0xE79178
	private void SerializeOther(object value) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class Json
{
	// Methods

	// RVA: 0xE77070
	public static object Deserialize(string json) { }

	// RVA: 0xE77060
	public static string Serialize(object obj) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class MiniJsonExtensions
{
	// Methods

	// RVA: 0xE7937C
	public static string GetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key, string defaultValue) { }

	// RVA: 0xE79438
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.Object> obj) { }

	// RVA: 0xE7943C
	public static string toJson(System.Collections.Generic.Dictionary<System.String,System.String> obj) { }

	// RVA: 0xE79440
	public static System.Collections.Generic.List<System.Object> ArrayListFromJson(string json) { }

	// RVA: 0xE794E0
	public static System.Collections.Generic.Dictionary<System.String,System.Object> HashtableFromJson(string json) { }

}


