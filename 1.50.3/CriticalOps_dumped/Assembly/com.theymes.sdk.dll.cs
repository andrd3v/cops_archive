// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x5D80BC
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x5D80C4
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x5D8150
	public void .ctor(Byte ) { }

}

// Namespace: Theymes
public static class TheymesUnityIosBridge
{
	// Fields
	private static Action onOpen; // 0x0
	private static Action onClose; // 0x8
	private static System.Action<System.Int32> onUnreadMessageCountUpdated; // 0x10
	private static System.Action<System.Int32> onUnansweredMessageCountUpdated; // 0x18

	// Methods

	// RVA: 0x5D8344
	public static void add_onOpen(Action value) { }

	// RVA: 0x5D8404
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5D84C4
	public static void add_onClose(Action value) { }

	// RVA: 0x5D8588
	public static void remove_onClose(Action value) { }

	// RVA: 0x5D864C
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5D8720
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5D87F4
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5D88C8
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5D899C
	private static extern void TheymesInitializeWithToken(string token, string domain) { }

	// RVA: 0x5D89E4
	private static extern void TheymesOpenSupport() { }

	// RVA: 0x5D89E8
	private static extern void TheymesOpenSupportWithConfig(string config) { }

	// RVA: 0x5D8A10
	private static extern void TheymesOpenResource(string resource) { }

	// RVA: 0x5D8A38
	private static extern void TheymesOpenResourceWithConfig(string resource, string config) { }

	// RVA: 0x5D8A80
	private static extern void TheymesClose() { }

	// RVA: 0x5D8A84
	private static extern IntPtr TheymesGetSdkVersion() { }

	// RVA: 0x5D8A88
	private static extern bool TheymesIsSupported() { }

	// RVA: 0x5D8AA4
	private static extern void TheymesRequestNotificationPermission() { }

	// RVA: 0x5D8AA8
	private static extern void TheymesEnableNotifications() { }

	// RVA: 0x5D8AAC
	private static extern void TheymesDisableNotifications() { }

	// RVA: 0x5D8AB0
	private static extern int TheymesGetUnreadMessageCount() { }

	// RVA: 0x5D8AB4
	private static extern int TheymesGetUnansweredMessageCount() { }

	// RVA: 0x5D8AB8
	private static extern void TheymesRecordRetention() { }

	// RVA: 0x5D8ABC
	private static extern void TheymesReset() { }

	// RVA: 0x5D8AC0
	private static extern IntPtr TheymesGetLanguage() { }

	// RVA: 0x5D8AC4
	private static extern void TheymesSetLanguage(string language) { }

	// RVA: 0x5D8AEC
	private static extern IntPtr TheymesGetSignedMetadataToken() { }

	// RVA: 0x5D8AF0
	private static extern void TheymesSetSignedMetadataToken(string token) { }

	// RVA: 0x5D8B18
	private static extern IntPtr TheymesGetPlayer() { }

	// RVA: 0x5D8B1C
	private static extern void TheymesSetPlayer(string player) { }

	// RVA: 0x5D8B44
	private static extern IntPtr TheymesGetTags() { }

	// RVA: 0x5D8B48
	private static extern void TheymesSetTags(string tags) { }

	// RVA: 0x5D8B70
	private static extern void TheymesAddTag(string tag) { }

	// RVA: 0x5D8B98
	private static extern void TheymesAddTags(string tags) { }

	// RVA: 0x5D8BC0
	private static extern void TheymesRemoveTag(string tag) { }

	// RVA: 0x5D8BE8
	private static extern void TheymesRemoveTags(string tags) { }

	// RVA: 0x5D8C10
	private static extern void TheymesRemoveAllTags() { }

	// RVA: 0x5D8C14
	private static extern IntPtr TheymesGetFields() { }

	// RVA: 0x5D8C18
	private static extern void TheymesSetFields(string fields) { }

	// RVA: 0x5D8C40
	private static extern void TheymesAddField(string key, string value) { }

	// RVA: 0x5D8C88
	private static extern void TheymesAddFields(string fields) { }

	// RVA: 0x5D8CB0
	private static extern void TheymesRemoveField(string field) { }

	// RVA: 0x5D8CD8
	private static extern void TheymesRemoveFields(string fields) { }

	// RVA: 0x5D8D00
	private static extern void TheymesRemoveAllFields() { }

	// RVA: 0x5D8D04
	private static extern void TheymesEnableLogging() { }

	// RVA: 0x5D8D08
	private static extern void TheymesDisableLogging() { }

	// RVA: 0x5D8D0C
	private static extern bool TheymesIsYoungPlayer() { }

	// RVA: 0x5D8D28
	private static extern void TheymesSetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5D8D2C
	private static extern bool TheymesIsPrivacyMode() { }

	// RVA: 0x5D8D48
	private static extern void TheymesSetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5D8D4C
	private static extern void TheymesOnOpen(Action callback) { }

	// RVA: 0x5D8D60
	private static extern void TheymesOnClose(Action callback) { }

	// RVA: 0x5D8D74
	private static extern void TheymesOnUnreadMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5D8D88
	private static extern void TheymesOnUnansweredMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5D8D9C
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5D8DE4
	public static void OpenSupport() { }

	// RVA: 0x5D8DE8
	public static void OpenSupport(string configJson) { }

	// RVA: 0x5D8E10
	public static void OpenResource(string resource) { }

	// RVA: 0x5D8E38
	public static void OpenResource(string resource, string configJson) { }

	// RVA: 0x5D8E80
	public static void Close() { }

	// RVA: 0x5D8E84
	public static string GetSdkVersion() { }

	// RVA: 0x5D8F0C
	public static bool IsSupported() { }

	// RVA: 0x5D8F28
	public static void RequestNotificationPermission() { }

	// RVA: 0x5D8F2C
	public static void EnableNotifications() { }

	// RVA: 0x5D8F30
	public static void DisableNotifications() { }

	// RVA: 0x5D8F34
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5D8F38
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5D8F3C
	public static void RecordRetention() { }

	// RVA: 0x5D8F40
	public static void Reset() { }

	// RVA: 0x5D8F44
	public static string GetLanguage() { }

	// RVA: 0x5D8FCC
	public static void SetLanguage(string language) { }

	// RVA: 0x5D8FF4
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5D907C
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5D90A4
	public static string GetPlayer() { }

	// RVA: 0x5D912C
	public static void SetPlayer(string playerJson) { }

	// RVA: 0x5D9154
	public static string GetTags() { }

	// RVA: 0x5D91DC
	public static void SetTags(string tagsJson) { }

	// RVA: 0x5D9204
	public static void AddTag(string tag) { }

	// RVA: 0x5D922C
	public static void AddTags(string tagsJson) { }

	// RVA: 0x5D9254
	public static void RemoveTag(string tag) { }

	// RVA: 0x5D927C
	public static void RemoveTags(string tagsJson) { }

	// RVA: 0x5D92A4
	public static void RemoveAllTags() { }

	// RVA: 0x5D92A8
	public static string GetFields() { }

	// RVA: 0x5D9330
	public static void SetFields(string fieldsJson) { }

	// RVA: 0x5D9358
	public static void AddField(string key, string value) { }

	// RVA: 0x5D93A0
	public static void AddFields(string fieldsJson) { }

	// RVA: 0x5D93C8
	public static void RemoveField(string field) { }

	// RVA: 0x5D93F0
	public static void RemoveFields(string fieldsJson) { }

	// RVA: 0x5D9418
	public static void RemoveAllFields() { }

	// RVA: 0x5D941C
	public static void EnableLogging() { }

	// RVA: 0x5D9420
	public static void DisableLogging() { }

	// RVA: 0x5D9424
	public static bool IsYoungPlayer() { }

	// RVA: 0x5D9440
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5D9444
	public static bool IsPrivacyMode() { }

	// RVA: 0x5D9460
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5D9464
	public static void SetupEventListeners() { }

	// RVA: 0x5D817C
	public static void OnOpen() { }

	// RVA: 0x5D81E4
	public static void OnClose() { }

	// RVA: 0x5D824C
	public static void OnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5D82C8
	public static void OnUnansweredMessageCountUpdated(int count) { }

}

// Namespace: Theymes
public class TheymesConfig
{
	// Fields
	private string <language>k__BackingField; // 0x10
	private string <signedMetadataToken>k__BackingField; // 0x18
	private TheymesPlayer <player>k__BackingField; // 0x20
	private System.Collections.Generic.List<System.String> <tags>k__BackingField; // 0x28
	private System.Collections.Generic.Dictionary<System.String,System.Object> <fields>k__BackingField; // 0x30

	// Methods

	// RVA: 0x5D95BC
	public string get_language() { }

	// RVA: 0x5D95C4
	public string get_signedMetadataToken() { }

	// RVA: 0x5D95CC
	public TheymesPlayer get_player() { }

	// RVA: 0x5D95D4
	public System.Collections.Generic.List<System.String> get_tags() { }

	// RVA: 0x5D95DC
	public System.Collections.Generic.Dictionary<System.String,System.Object> get_fields() { }

}

// Namespace: Theymes
internal class TheymesJsonHelpers
{
	// Methods

	// RVA: 0x5D95E4
	public static JSONObject PlayerToJsonObject(TheymesPlayer player) { }

	// RVA: 0x5D9C00
	public static string PlayerToJson(TheymesPlayer player) { }

	// RVA: 0x5D9EE0
	public static TheymesPlayer JsonToPlayer(string jsonStr) { }

	// RVA: 0x5DA944
	public static JSONObject ConfigToJsonObject(TheymesConfig config) { }

	// RVA: 0x5DB194
	public static string ConfigToJson(TheymesConfig config) { }

	// RVA: 0x5DB2EC
	public static System.Collections.Generic.List<System.String> JsonToStringList(string jsonStr) { }

	// RVA: 0x5DAB34
	public static JSONArray StringListToJsonArray(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5DB9FC
	public static string StringListToJson(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5DBB54
	public static JSONNode ObjectToJsonNode(object value) { }

	// RVA: 0x5DC054
	public static string ObjectToJson(object value) { }

	// RVA: 0x5DC078
	public static System.Collections.Generic.Dictionary<System.String,System.Object> JsonToDictionary(string jsonStr) { }

	// RVA: 0x5DAE40
	public static JSONObject DictionaryToJsonObject(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x5DC738
	public static string DictionaryToJson(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

}

// Namespace: Theymes
public class TheymesPlayer
{
	// Fields
	private string <id>k__BackingField; // 0x10
	private string <name>k__BackingField; // 0x18
	private string <email>k__BackingField; // 0x20
	private System.Nullable<System.Int32> <tier>k__BackingField; // 0x28

	// Methods

	// RVA: 0x5DC890
	public string get_id() { }

	// RVA: 0x5DC898
	public void set_id(string value) { }

	// RVA: 0x5DC8A0
	public string get_name() { }

	// RVA: 0x5DC8A8
	public void set_name(string value) { }

	// RVA: 0x5DC8B0
	public string get_email() { }

	// RVA: 0x5DC8B8
	public void set_email(string value) { }

	// RVA: 0x5DC8C0
	public System.Nullable<System.Int32> get_tier() { }

	// RVA: 0x5DC8C8
	public void set_tier(System.Nullable<System.Int32> value) { }

	// RVA: 0x5DA78C
	public void .ctor() { }

}

// Namespace: Theymes
public class TheymesSdk
{
	// Fields
	private static Action onOpen; // 0x0
	private static Action onClose; // 0x8
	private static System.Action<System.Int32> onUnreadMessageCountUpdated; // 0x10
	private static System.Action<System.Int32> onUnansweredMessageCountUpdated; // 0x18
	private static bool isInitialized; // 0x20

	// Methods

	// RVA: 0x5DC8D0
	public static void add_onOpen(Action value) { }

	// RVA: 0x5DC990
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5DCA50
	public static void add_onClose(Action value) { }

	// RVA: 0x5DCB14
	public static void remove_onClose(Action value) { }

	// RVA: 0x5DCBD8
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5DCCAC
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5DCD80
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5DCE54
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5DCF28
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5DD228
	public static void OpenSupport() { }

	// RVA: 0x5DD22C
	public static void OpenSupport(TheymesConfig config) { }

	// RVA: 0x5DD258
	public static void OpenResource(string resource) { }

	// RVA: 0x5DD280
	public static void OpenResource(string resource, TheymesConfig config) { }

	// RVA: 0x5DD2D8
	public static void Close() { }

	// RVA: 0x5DD2DC
	public static string GetSdkVersion() { }

	// RVA: 0x5DD364
	public static bool IsSupported() { }

	// RVA: 0x5DD380
	public static void RequestNotificationPermission() { }

	// RVA: 0x5DD384
	public static void EnableNotifications() { }

	// RVA: 0x5DD388
	public static void DisableNotifications() { }

	// RVA: 0x5DD38C
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5DD390
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5DD394
	public static void RecordRetention() { }

	// RVA: 0x5DD398
	public static void Reset() { }

	// RVA: 0x5DD39C
	public static string GetLanguage() { }

	// RVA: 0x5DD424
	public static void SetLanguage(string language) { }

	// RVA: 0x5DD44C
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5DD4D4
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5DD4FC
	public static TheymesPlayer GetPlayer() { }

	// RVA: 0x5DD58C
	public static void SetPlayer(TheymesPlayer player) { }

	// RVA: 0x5DD5B8
	public static System.Collections.Generic.List<System.String> GetTags() { }

	// RVA: 0x5DD648
	public static void SetTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5DD674
	public static void AddTag(string tag) { }

	// RVA: 0x5DD69C
	public static void AddTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5DD6C8
	public static void RemoveTag(string tag) { }

	// RVA: 0x5DD6F0
	public static void RemoveTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5DD71C
	public static void RemoveAllTags() { }

	// RVA: 0x5DD720
	public static System.Collections.Generic.Dictionary<System.String,System.Object> GetFields() { }

	// RVA: 0x5DD7B0
	public static void SetFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5DD7DC
	public static void AddField(string key, object value) { }

	// RVA: 0x5DD848
	public static void AddFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5DD874
	public static void RemoveField(string key) { }

	// RVA: 0x5DD89C
	public static void RemoveFields(System.Collections.Generic.List<System.String> keys) { }

	// RVA: 0x5DD8C8
	public static void RemoveAllFields() { }

	// RVA: 0x5DD8CC
	public static void EnableLogging() { }

	// RVA: 0x5DD8D0
	public static void DisableLogging() { }

	// RVA: 0x5DD8D4
	public static bool IsYoungPlayer() { }

	// RVA: 0x5DD8F0
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5DD8F4
	public static bool IsPrivacyMode() { }

	// RVA: 0x5DD910
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5DCFCC
	private static void _SetupEventListeners() { }

	// RVA: 0x5DD914
	private static void _TriggerOnOpen() { }

	// RVA: 0x5DD97C
	private static void _TriggerOnClose() { }

	// RVA: 0x5DD9E4
	private static void _TriggerOnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5DDA60
	private static void _TriggerOnUnansweredMessageCountUpdated(int count) { }

	// RVA: 0x5DDADC
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public enum JSONTextMode
{
	// Fields
	public int value__; // 0x10
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;
}

// Namespace: 
private enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type None = 0;
	public const Type Array = 1;
	public const Type Object = 2;
}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Type type; // 0x10
	private Enumerator m_Object; // 0x18
	private Enumerator m_Array; // 0x40

	// Methods

	// RVA: 0x5DF380
	public void .ctor(Enumerator aArrayEnum) { }

	// RVA: 0x5DF3B8
	public void .ctor(Enumerator aDictEnum) { }

	// RVA: 0x5DB690
	public System.Collections.Generic.KeyValuePair<System.String,Theymes.SimpleJSON.JSONNode> get_Current() { }

	// RVA: 0x5DB8AC
	public bool MoveNext() { }

}

// Namespace: Theymes.SimpleJSON
public abstract class JSONNode
{
	// Fields
	public static bool forceASCII; // 0x0
	public static bool longAsString; // 0x1
	public static bool allowLineComments; // 0x2
	private static StringBuilder m_EscapeBuilder; // 0xFFFFFFFF

	// Methods

	// RVA: 0x5DDAE4
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x5DDAEC
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5DDAF0
	public virtual string get_Value() { }

	// RVA: 0x5DDB34
	public virtual bool get_IsNumber() { }

	// RVA: 0x5DDB3C
	public virtual bool get_IsString() { }

	// RVA: 0x5DDB44
	public virtual bool get_IsBoolean() { }

	// RVA: 0x5DDB4C
	public virtual bool get_IsNull() { }

	// RVA: 0x5DDB54
	public virtual bool get_IsArray() { }

	// RVA: 0x5DDB5C
	public virtual bool get_IsObject() { }

	// RVA: 0x5DDB64
	public virtual void set_Inline(bool value) { }

	// RVA: 0x5DDB68
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5DDB6C
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x5DDBD4
	public override string ToString() { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract Enumerator GetEnumerator() { }

	// RVA: 0x5DDC6C
	public virtual Double get_AsDouble() { }

	// RVA: 0x5DDD18
	public virtual int get_AsInt() { }

	// RVA: 0x5DDD50
	public virtual bool get_AsBool() { }

	// RVA: 0x5DDE30
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x5DDEB4
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x5D9A58
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x5DA804
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x5DDF38
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x5D9B50
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x5DDFE4
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x5D9D58
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x5DA794
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x5DE088
	public override bool Equals(object obj) { }

	// RVA: 0x5DE094
	public override int GetHashCode() { }

	// RVA: 0x5DE09C
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x5DE1A4
	internal static string Escape(string aText) { }

	// RVA: 0x5DE4DC
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x5DE86C
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x5DF324
	protected void .ctor() { }

	// RVA: 0x5DF32C
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<Theymes.SimpleJSON.JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5DF400
	public override void set_Inline(bool value) { }

	// RVA: 0x5DF408
	public override bool get_IsArray() { }

	// RVA: 0x5DF410
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5DF4B8
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5DF600
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5DF77C
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5DF8F8
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5DB944
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,Theymes.SimpleJSON.JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5DFB90
	public override void set_Inline(bool value) { }

	// RVA: 0x5DFB98
	public override bool get_IsObject() { }

	// RVA: 0x5DFBA0
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5DFC54
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5DFE20
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5E0014
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5E026C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5D99A0
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x5E074C
	public override bool get_IsString() { }

	// RVA: 0x5E0754
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5E0768
	public override string get_Value() { }

	// RVA: 0x5DBDF8
	public void .ctor(string aData) { }

	// RVA: 0x5E0770
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5E0818
	public override bool Equals(object obj) { }

	// RVA: 0x5E0A4C
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x5E0A70
	public override bool get_IsNumber() { }

	// RVA: 0x5E0A78
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5E0A8C
	public override string get_Value() { }

	// RVA: 0x5E0B00
	public override Double get_AsDouble() { }

	// RVA: 0x5DBE70
	public void .ctor(Double aData) { }

	// RVA: 0x5E0B08
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5E0BAC
	private static bool IsNumeric(object value) { }

	// RVA: 0x5E0D58
	public override bool Equals(object obj) { }

	// RVA: 0x5E0FA0
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x5E0FC0
	public override bool get_IsBoolean() { }

	// RVA: 0x5E0FC8
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5E0FDC
	public override string get_Value() { }

	// RVA: 0x5E1064
	public override bool get_AsBool() { }

	// RVA: 0x5DBEE8
	public void .ctor(bool aData) { }

	// RVA: 0x5E106C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5E10F0
	public override bool Equals(object obj) { }

	// RVA: 0x5E1180
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNull
{
	// Fields
	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	// Methods

	// RVA: 0x5DBF58
	public static JSONNull CreateOrGet() { }

	// RVA: 0x5E1208
	private void .ctor() { }

	// RVA: 0x5E1290
	public override bool get_IsNull() { }

	// RVA: 0x5E1298
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5E12AC
	public override string get_Value() { }

	// RVA: 0x5E12F0
	public override bool get_AsBool() { }

	// RVA: 0x5E12F8
	public override bool Equals(object obj) { }

	// RVA: 0x5E13A8
	public override int GetHashCode() { }

	// RVA: 0x5E13B0
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5E1408
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x5E14CC
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5DF578
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x5DFD8C
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x318DB98
	private T Set(T aVal) { }

	// RVA: 0x5E14E0
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5E15AC
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5E1658
	public override void Add(JSONNode aItem) { }

	// RVA: 0x5E16FC
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5E17A8
	public override bool Equals(object obj) { }

	// RVA: 0x5E17B8
	public override int GetHashCode() { }

	// RVA: 0x5E17C0
	public override int get_AsInt() { }

	// RVA: 0x5E1888
	public override Double get_AsDouble() { }

	// RVA: 0x5E1950
	public override bool get_AsBool() { }

	// RVA: 0x5E1A18
	public override JSONArray get_AsArray() { }

	// RVA: 0x5E1A94
	public override JSONObject get_AsObject() { }

	// RVA: 0x5E1B10
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: Theymes.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x5DA70C
	public static JSONNode Parse(string aJSON) { }

}


