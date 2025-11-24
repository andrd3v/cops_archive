// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x5F3054
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x5F305C
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x5F30E8
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

	// RVA: 0x5F32DC
	public static void add_onOpen(Action value) { }

	// RVA: 0x5F339C
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5F345C
	public static void add_onClose(Action value) { }

	// RVA: 0x5F3520
	public static void remove_onClose(Action value) { }

	// RVA: 0x5F35E4
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F36B8
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F378C
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F3860
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F3934
	private static extern void TheymesInitializeWithToken(string token, string domain) { }

	// RVA: 0x5F397C
	private static extern void TheymesOpenSupport() { }

	// RVA: 0x5F3980
	private static extern void TheymesOpenSupportWithConfig(string config) { }

	// RVA: 0x5F39A8
	private static extern void TheymesOpenResource(string resource) { }

	// RVA: 0x5F39D0
	private static extern void TheymesOpenResourceWithConfig(string resource, string config) { }

	// RVA: 0x5F3A18
	private static extern void TheymesClose() { }

	// RVA: 0x5F3A1C
	private static extern IntPtr TheymesGetSdkVersion() { }

	// RVA: 0x5F3A20
	private static extern bool TheymesIsSupported() { }

	// RVA: 0x5F3A3C
	private static extern void TheymesRequestNotificationPermission() { }

	// RVA: 0x5F3A40
	private static extern void TheymesEnableNotifications() { }

	// RVA: 0x5F3A44
	private static extern void TheymesDisableNotifications() { }

	// RVA: 0x5F3A48
	private static extern int TheymesGetUnreadMessageCount() { }

	// RVA: 0x5F3A4C
	private static extern int TheymesGetUnansweredMessageCount() { }

	// RVA: 0x5F3A50
	private static extern void TheymesRecordRetention() { }

	// RVA: 0x5F3A54
	private static extern void TheymesReset() { }

	// RVA: 0x5F3A58
	private static extern IntPtr TheymesGetLanguage() { }

	// RVA: 0x5F3A5C
	private static extern void TheymesSetLanguage(string language) { }

	// RVA: 0x5F3A84
	private static extern IntPtr TheymesGetSignedMetadataToken() { }

	// RVA: 0x5F3A88
	private static extern void TheymesSetSignedMetadataToken(string token) { }

	// RVA: 0x5F3AB0
	private static extern IntPtr TheymesGetPlayer() { }

	// RVA: 0x5F3AB4
	private static extern void TheymesSetPlayer(string player) { }

	// RVA: 0x5F3ADC
	private static extern IntPtr TheymesGetTags() { }

	// RVA: 0x5F3AE0
	private static extern void TheymesSetTags(string tags) { }

	// RVA: 0x5F3B08
	private static extern void TheymesAddTag(string tag) { }

	// RVA: 0x5F3B30
	private static extern void TheymesAddTags(string tags) { }

	// RVA: 0x5F3B58
	private static extern void TheymesRemoveTag(string tag) { }

	// RVA: 0x5F3B80
	private static extern void TheymesRemoveTags(string tags) { }

	// RVA: 0x5F3BA8
	private static extern void TheymesRemoveAllTags() { }

	// RVA: 0x5F3BAC
	private static extern IntPtr TheymesGetFields() { }

	// RVA: 0x5F3BB0
	private static extern void TheymesSetFields(string fields) { }

	// RVA: 0x5F3BD8
	private static extern void TheymesAddField(string key, string value) { }

	// RVA: 0x5F3C20
	private static extern void TheymesAddFields(string fields) { }

	// RVA: 0x5F3C48
	private static extern void TheymesRemoveField(string field) { }

	// RVA: 0x5F3C70
	private static extern void TheymesRemoveFields(string fields) { }

	// RVA: 0x5F3C98
	private static extern void TheymesRemoveAllFields() { }

	// RVA: 0x5F3C9C
	private static extern void TheymesEnableLogging() { }

	// RVA: 0x5F3CA0
	private static extern void TheymesDisableLogging() { }

	// RVA: 0x5F3CA4
	private static extern bool TheymesIsYoungPlayer() { }

	// RVA: 0x5F3CC0
	private static extern void TheymesSetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5F3CC4
	private static extern bool TheymesIsPrivacyMode() { }

	// RVA: 0x5F3CE0
	private static extern void TheymesSetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5F3CE4
	private static extern void TheymesOnOpen(Action callback) { }

	// RVA: 0x5F3CF8
	private static extern void TheymesOnClose(Action callback) { }

	// RVA: 0x5F3D0C
	private static extern void TheymesOnUnreadMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5F3D20
	private static extern void TheymesOnUnansweredMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5F3D34
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5F3D7C
	public static void OpenSupport() { }

	// RVA: 0x5F3D80
	public static void OpenSupport(string configJson) { }

	// RVA: 0x5F3DA8
	public static void OpenResource(string resource) { }

	// RVA: 0x5F3DD0
	public static void OpenResource(string resource, string configJson) { }

	// RVA: 0x5F3E18
	public static void Close() { }

	// RVA: 0x5F3E1C
	public static string GetSdkVersion() { }

	// RVA: 0x5F3EA4
	public static bool IsSupported() { }

	// RVA: 0x5F3EC0
	public static void RequestNotificationPermission() { }

	// RVA: 0x5F3EC4
	public static void EnableNotifications() { }

	// RVA: 0x5F3EC8
	public static void DisableNotifications() { }

	// RVA: 0x5F3ECC
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5F3ED0
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5F3ED4
	public static void RecordRetention() { }

	// RVA: 0x5F3ED8
	public static void Reset() { }

	// RVA: 0x5F3EDC
	public static string GetLanguage() { }

	// RVA: 0x5F3F64
	public static void SetLanguage(string language) { }

	// RVA: 0x5F3F8C
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5F4014
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5F403C
	public static string GetPlayer() { }

	// RVA: 0x5F40C4
	public static void SetPlayer(string playerJson) { }

	// RVA: 0x5F40EC
	public static string GetTags() { }

	// RVA: 0x5F4174
	public static void SetTags(string tagsJson) { }

	// RVA: 0x5F419C
	public static void AddTag(string tag) { }

	// RVA: 0x5F41C4
	public static void AddTags(string tagsJson) { }

	// RVA: 0x5F41EC
	public static void RemoveTag(string tag) { }

	// RVA: 0x5F4214
	public static void RemoveTags(string tagsJson) { }

	// RVA: 0x5F423C
	public static void RemoveAllTags() { }

	// RVA: 0x5F4240
	public static string GetFields() { }

	// RVA: 0x5F42C8
	public static void SetFields(string fieldsJson) { }

	// RVA: 0x5F42F0
	public static void AddField(string key, string value) { }

	// RVA: 0x5F4338
	public static void AddFields(string fieldsJson) { }

	// RVA: 0x5F4360
	public static void RemoveField(string field) { }

	// RVA: 0x5F4388
	public static void RemoveFields(string fieldsJson) { }

	// RVA: 0x5F43B0
	public static void RemoveAllFields() { }

	// RVA: 0x5F43B4
	public static void EnableLogging() { }

	// RVA: 0x5F43B8
	public static void DisableLogging() { }

	// RVA: 0x5F43BC
	public static bool IsYoungPlayer() { }

	// RVA: 0x5F43D8
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5F43DC
	public static bool IsPrivacyMode() { }

	// RVA: 0x5F43F8
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5F43FC
	public static void SetupEventListeners() { }

	// RVA: 0x5F3114
	public static void OnOpen() { }

	// RVA: 0x5F317C
	public static void OnClose() { }

	// RVA: 0x5F31E4
	public static void OnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5F3260
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

	// RVA: 0x5F4554
	public string get_language() { }

	// RVA: 0x5F455C
	public string get_signedMetadataToken() { }

	// RVA: 0x5F4564
	public TheymesPlayer get_player() { }

	// RVA: 0x5F456C
	public System.Collections.Generic.List<System.String> get_tags() { }

	// RVA: 0x5F4574
	public System.Collections.Generic.Dictionary<System.String,System.Object> get_fields() { }

}

// Namespace: Theymes
internal class TheymesJsonHelpers
{
	// Methods

	// RVA: 0x5F457C
	public static JSONObject PlayerToJsonObject(TheymesPlayer player) { }

	// RVA: 0x5F4B98
	public static string PlayerToJson(TheymesPlayer player) { }

	// RVA: 0x5F4E78
	public static TheymesPlayer JsonToPlayer(string jsonStr) { }

	// RVA: 0x5F58DC
	public static JSONObject ConfigToJsonObject(TheymesConfig config) { }

	// RVA: 0x5F612C
	public static string ConfigToJson(TheymesConfig config) { }

	// RVA: 0x5F6284
	public static System.Collections.Generic.List<System.String> JsonToStringList(string jsonStr) { }

	// RVA: 0x5F5ACC
	public static JSONArray StringListToJsonArray(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5F6988
	public static string StringListToJson(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5F6AE0
	public static JSONNode ObjectToJsonNode(object value) { }

	// RVA: 0x5F6F80
	public static string ObjectToJson(object value) { }

	// RVA: 0x5F6FA4
	public static System.Collections.Generic.Dictionary<System.String,System.Object> JsonToDictionary(string jsonStr) { }

	// RVA: 0x5F5DD8
	public static JSONObject DictionaryToJsonObject(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x5F764C
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

	// RVA: 0x5F77A4
	public string get_id() { }

	// RVA: 0x5F77AC
	public void set_id(string value) { }

	// RVA: 0x5F77B4
	public string get_name() { }

	// RVA: 0x5F77BC
	public void set_name(string value) { }

	// RVA: 0x5F77C4
	public string get_email() { }

	// RVA: 0x5F77CC
	public void set_email(string value) { }

	// RVA: 0x5F77D4
	public System.Nullable<System.Int32> get_tier() { }

	// RVA: 0x5F77DC
	public void set_tier(System.Nullable<System.Int32> value) { }

	// RVA: 0x5F5724
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

	// RVA: 0x5F77E4
	public static void add_onOpen(Action value) { }

	// RVA: 0x5F78A4
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5F7964
	public static void add_onClose(Action value) { }

	// RVA: 0x5F7A28
	public static void remove_onClose(Action value) { }

	// RVA: 0x5F7AEC
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F7BC0
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F7C94
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F7D68
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5F7E3C
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5F813C
	public static void OpenSupport() { }

	// RVA: 0x5F8140
	public static void OpenSupport(TheymesConfig config) { }

	// RVA: 0x5F816C
	public static void OpenResource(string resource) { }

	// RVA: 0x5F8194
	public static void OpenResource(string resource, TheymesConfig config) { }

	// RVA: 0x5F81EC
	public static void Close() { }

	// RVA: 0x5F81F0
	public static string GetSdkVersion() { }

	// RVA: 0x5F8278
	public static bool IsSupported() { }

	// RVA: 0x5F8294
	public static void RequestNotificationPermission() { }

	// RVA: 0x5F8298
	public static void EnableNotifications() { }

	// RVA: 0x5F829C
	public static void DisableNotifications() { }

	// RVA: 0x5F82A0
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5F82A4
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5F82A8
	public static void RecordRetention() { }

	// RVA: 0x5F82AC
	public static void Reset() { }

	// RVA: 0x5F82B0
	public static string GetLanguage() { }

	// RVA: 0x5F8338
	public static void SetLanguage(string language) { }

	// RVA: 0x5F8360
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5F83E8
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5F8410
	public static TheymesPlayer GetPlayer() { }

	// RVA: 0x5F84A0
	public static void SetPlayer(TheymesPlayer player) { }

	// RVA: 0x5F84CC
	public static System.Collections.Generic.List<System.String> GetTags() { }

	// RVA: 0x5F855C
	public static void SetTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5F8588
	public static void AddTag(string tag) { }

	// RVA: 0x5F85B0
	public static void AddTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5F85DC
	public static void RemoveTag(string tag) { }

	// RVA: 0x5F8604
	public static void RemoveTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5F8630
	public static void RemoveAllTags() { }

	// RVA: 0x5F8634
	public static System.Collections.Generic.Dictionary<System.String,System.Object> GetFields() { }

	// RVA: 0x5F86C4
	public static void SetFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5F86F0
	public static void AddField(string key, object value) { }

	// RVA: 0x5F875C
	public static void AddFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5F8788
	public static void RemoveField(string key) { }

	// RVA: 0x5F87B0
	public static void RemoveFields(System.Collections.Generic.List<System.String> keys) { }

	// RVA: 0x5F87DC
	public static void RemoveAllFields() { }

	// RVA: 0x5F87E0
	public static void EnableLogging() { }

	// RVA: 0x5F87E4
	public static void DisableLogging() { }

	// RVA: 0x5F87E8
	public static bool IsYoungPlayer() { }

	// RVA: 0x5F8804
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5F8808
	public static bool IsPrivacyMode() { }

	// RVA: 0x5F8824
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5F7EE0
	private static void _SetupEventListeners() { }

	// RVA: 0x5F8828
	private static void _TriggerOnOpen() { }

	// RVA: 0x5F8890
	private static void _TriggerOnClose() { }

	// RVA: 0x5F88F8
	private static void _TriggerOnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5F8974
	private static void _TriggerOnUnansweredMessageCountUpdated(int count) { }

	// RVA: 0x5F89F0
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

	// RVA: 0x5FA264
	public void .ctor(Enumerator aArrayEnum) { }

	// RVA: 0x5FA29C
	public void .ctor(Enumerator aDictEnum) { }

	// RVA: 0x5F6628
	public System.Collections.Generic.KeyValuePair<System.String,Theymes.SimpleJSON.JSONNode> get_Current() { }

	// RVA: 0x5F6838
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

	// RVA: 0x5F89F8
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x5F8A00
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5F8A04
	public virtual string get_Value() { }

	// RVA: 0x5F8A48
	public virtual bool get_IsNumber() { }

	// RVA: 0x5F8A50
	public virtual bool get_IsString() { }

	// RVA: 0x5F8A58
	public virtual bool get_IsBoolean() { }

	// RVA: 0x5F8A60
	public virtual bool get_IsNull() { }

	// RVA: 0x5F8A68
	public virtual bool get_IsArray() { }

	// RVA: 0x5F8A70
	public virtual bool get_IsObject() { }

	// RVA: 0x5F8A78
	public virtual void set_Inline(bool value) { }

	// RVA: 0x5F8A7C
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5F8A80
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x5F8AE8
	public override string ToString() { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract Enumerator GetEnumerator() { }

	// RVA: 0x5F8B80
	public virtual Double get_AsDouble() { }

	// RVA: 0x5F8C2C
	public virtual int get_AsInt() { }

	// RVA: 0x5F8C64
	public virtual bool get_AsBool() { }

	// RVA: 0x5F8D14
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x5F8D98
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x5F49F0
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x5F579C
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x5F8E1C
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x5F4AE8
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x5F8EC8
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x5F4CF0
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x5F572C
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x5F8F6C
	public override bool Equals(object obj) { }

	// RVA: 0x5F8F78
	public override int GetHashCode() { }

	// RVA: 0x5F8F80
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x5F9088
	internal static string Escape(string aText) { }

	// RVA: 0x5F93C0
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x5F9750
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x5FA208
	protected void .ctor() { }

	// RVA: 0x5FA210
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<Theymes.SimpleJSON.JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5FA2E4
	public override void set_Inline(bool value) { }

	// RVA: 0x5FA2EC
	public override bool get_IsArray() { }

	// RVA: 0x5FA2F4
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FA39C
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5FA4E4
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5FA660
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5FA7DC
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5F68D0
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,Theymes.SimpleJSON.JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5FAA74
	public override void set_Inline(bool value) { }

	// RVA: 0x5FAA7C
	public override bool get_IsObject() { }

	// RVA: 0x5FAA84
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FAB38
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5FAD04
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5FAEF8
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5FB150
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5F4938
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x5FB630
	public override bool get_IsString() { }

	// RVA: 0x5FB638
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FB64C
	public override string get_Value() { }

	// RVA: 0x5F6D24
	public void .ctor(string aData) { }

	// RVA: 0x5FB654
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5FB6FC
	public override bool Equals(object obj) { }

	// RVA: 0x5FB924
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x5FB948
	public override bool get_IsNumber() { }

	// RVA: 0x5FB950
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FB964
	public override string get_Value() { }

	// RVA: 0x5FB9D8
	public override Double get_AsDouble() { }

	// RVA: 0x5F6D9C
	public void .ctor(Double aData) { }

	// RVA: 0x5FB9E0
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5FBA84
	private static bool IsNumeric(object value) { }

	// RVA: 0x5FBB70
	public override bool Equals(object obj) { }

	// RVA: 0x5FBE74
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x5FBE94
	public override bool get_IsBoolean() { }

	// RVA: 0x5FBE9C
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FBEB0
	public override string get_Value() { }

	// RVA: 0x5FBF00
	public override bool get_AsBool() { }

	// RVA: 0x5F6E14
	public void .ctor(bool aData) { }

	// RVA: 0x5FBF08
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5FBF8C
	public override bool Equals(object obj) { }

	// RVA: 0x5FBFF0
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNull
{
	// Fields
	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	// Methods

	// RVA: 0x5F6E84
	public static JSONNull CreateOrGet() { }

	// RVA: 0x5FC040
	private void .ctor() { }

	// RVA: 0x5FC0C8
	public override bool get_IsNull() { }

	// RVA: 0x5FC0D0
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FC0E4
	public override string get_Value() { }

	// RVA: 0x5FC128
	public override bool get_AsBool() { }

	// RVA: 0x5FC130
	public override bool Equals(object obj) { }

	// RVA: 0x5FC1E0
	public override int GetHashCode() { }

	// RVA: 0x5FC1E8
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5FC240
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x5FC304
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5FA45C
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x5FAC70
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x26AD93C
	private T Set(T aVal) { }

	// RVA: 0x5FC318
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5FC3E4
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5FC490
	public override void Add(JSONNode aItem) { }

	// RVA: 0x5FC534
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5FC5E0
	public override bool Equals(object obj) { }

	// RVA: 0x5FC5F0
	public override int GetHashCode() { }

	// RVA: 0x5FC5F8
	public override int get_AsInt() { }

	// RVA: 0x5FC6C0
	public override Double get_AsDouble() { }

	// RVA: 0x5FC788
	public override bool get_AsBool() { }

	// RVA: 0x5FC850
	public override JSONArray get_AsArray() { }

	// RVA: 0x5FC8CC
	public override JSONObject get_AsObject() { }

	// RVA: 0x5FC948
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: Theymes.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x5F56A4
	public static JSONNode Parse(string aJSON) { }

}


