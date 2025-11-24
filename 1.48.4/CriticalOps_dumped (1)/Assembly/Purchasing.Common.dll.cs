// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine.Purchasing
public interface INativeStore 
{
	// Methods

	// RVA: 0x2FE4574
	void RetrieveProducts(string json) { }

	// RVA: 0x2FE47D4
	void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x2FE47D4
	void FinishTransaction(string productJSON, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal sealed class UnityPurchasingCallback 
{
	// Methods

	// RVA: 0xDE79F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE7AB4
	internal void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
public class MiniJson 
{
	// Methods

	// RVA: 0xDE7AC8
	string JsonEncode(object json) { }

	// RVA: 0xDE7AD0
	object JsonDecode(string json) { }

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

	// RVA: 0xDE7D74
	bool IsWordBreak(Char c) { }

	// RVA: 0xDE7E44
	void .ctor(string jsonString) { }

	// RVA: 0xDE7AE8
	object Parse(string jsonString) { }

	// RVA: 0xDE7EEC
	void Dispose() { }

	// RVA: 0xDE7F28
	System.Collections.Generic.Dictionary<System.String,System.Object> ParseObject() { }

	// RVA: 0xDE8804
	System.Collections.Generic.List<System.Object> ParseArray() { }

	// RVA: 0xDE7EC4
	object ParseValue() { }

	// RVA: 0xDE8914
	object ParseByToken(TOKEN token) { }

	// RVA: 0xDE8358
	string ParseString() { }

	// RVA: 0xDE8A20
	object ParseNumber() { }

	// RVA: 0xDE8E14
	void EatWhitespace() { }

	// RVA: 0xDE8F14
	Char get_PeekChar() { }

	// RVA: 0xDE8B7C
	Char get_NextChar() { }

	// RVA: 0xDE8C08
	string get_NextWord() { }

	// RVA: 0xDE80B4
	TOKEN get_NextToken() { }

}

// Namespace: 
private sealed class Serializer 
{
	// Fields
	private readonly StringBuilder builder; // 0x10

	// Methods

	// RVA: 0xDE8FA0
	void .ctor() { }

	// RVA: 0xDE7CA0
	string Serialize(object obj) { }

	// RVA: 0xDE9018
	void SerializeValue(object value) { }

	// RVA: 0xDE9828
	void SerializeObject(IDictionary obj) { }

	// RVA: 0xDE94E0
	void SerializeArray(IList anArray) { }

	// RVA: 0xDE9224
	void SerializeString(string str) { }

	// RVA: 0xDE9CAC
	void SerializeOther(object value) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class Json 
{
	// Methods

	// RVA: 0xDE7ADC
	object Deserialize(string json) { }

	// RVA: 0xDE7ACC
	string Serialize(object obj) { }

}

// Namespace: UnityEngine.Purchasing.MiniJSON
public static class MiniJsonExtensions 
{
	// Methods

	// RVA: 0xDE9F80
	string GetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key, string defaultValue) { }

	// RVA: 0xDEA03C
	string toJson(System.Collections.Generic.Dictionary<System.String,System.Object> obj) { }

	// RVA: 0xDEA040
	string toJson(System.Collections.Generic.Dictionary<System.String,System.String> obj) { }

	// RVA: 0xDEA044
	System.Collections.Generic.List<System.Object> ArrayListFromJson(string json) { }

	// RVA: 0xDEA0E4
	System.Collections.Generic.Dictionary<System.String,System.Object> HashtableFromJson(string json) { }

}


