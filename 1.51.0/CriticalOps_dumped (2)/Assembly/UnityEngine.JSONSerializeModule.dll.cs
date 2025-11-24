// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class JsonUtility
{
	// Methods

	// RVA: 0x171478C
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	// RVA: 0x1714928
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x1714B24
	public static string ToJson(object obj) { }

	// RVA: 0x1714B2C
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: 0x26AD93C
	public static T FromJson(string json) { }

	// RVA: 0x1714C8C
	public static object FromJson(string json, Type type) { }

	// RVA: 0x1714E5C
	public static void FromJsonOverwrite(string json, object objectToOverwrite) { }

	// RVA: 0x17148D0
	private static void ToJsonInternal_Injected(object obj, bool prettyPrint, ManagedSpanWrapper ret) { }

	// RVA: 0x1714ACC
	private static object FromJsonInternal_Injected(ManagedSpanWrapper json, object objectToOverwrite, Type type) { }

}


