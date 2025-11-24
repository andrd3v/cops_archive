// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x5C3DB8
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x5C3DC0
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x5C3E4C
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

	// RVA: 0x5C4040
	public static void add_onOpen(Action value) { }

	// RVA: 0x5C4100
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5C41C0
	public static void add_onClose(Action value) { }

	// RVA: 0x5C4284
	public static void remove_onClose(Action value) { }

	// RVA: 0x5C4348
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C441C
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C44F0
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C45C4
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C4698
	private static extern void TheymesInitializeWithToken(string token, string domain) { }

	// RVA: 0x5C46E0
	private static extern void TheymesOpenSupport() { }

	// RVA: 0x5C46E4
	private static extern void TheymesOpenSupportWithConfig(string config) { }

	// RVA: 0x5C470C
	private static extern void TheymesOpenResource(string resource) { }

	// RVA: 0x5C4734
	private static extern void TheymesOpenResourceWithConfig(string resource, string config) { }

	// RVA: 0x5C477C
	private static extern void TheymesClose() { }

	// RVA: 0x5C4780
	private static extern IntPtr TheymesGetSdkVersion() { }

	// RVA: 0x5C4784
	private static extern bool TheymesIsSupported() { }

	// RVA: 0x5C47A0
	private static extern void TheymesRequestNotificationPermission() { }

	// RVA: 0x5C47A4
	private static extern void TheymesEnableNotifications() { }

	// RVA: 0x5C47A8
	private static extern void TheymesDisableNotifications() { }

	// RVA: 0x5C47AC
	private static extern int TheymesGetUnreadMessageCount() { }

	// RVA: 0x5C47B0
	private static extern int TheymesGetUnansweredMessageCount() { }

	// RVA: 0x5C47B4
	private static extern void TheymesRecordRetention() { }

	// RVA: 0x5C47B8
	private static extern void TheymesReset() { }

	// RVA: 0x5C47BC
	private static extern IntPtr TheymesGetLanguage() { }

	// RVA: 0x5C47C0
	private static extern void TheymesSetLanguage(string language) { }

	// RVA: 0x5C47E8
	private static extern IntPtr TheymesGetSignedMetadataToken() { }

	// RVA: 0x5C47EC
	private static extern void TheymesSetSignedMetadataToken(string token) { }

	// RVA: 0x5C4814
	private static extern IntPtr TheymesGetPlayer() { }

	// RVA: 0x5C4818
	private static extern void TheymesSetPlayer(string player) { }

	// RVA: 0x5C4840
	private static extern IntPtr TheymesGetTags() { }

	// RVA: 0x5C4844
	private static extern void TheymesSetTags(string tags) { }

	// RVA: 0x5C486C
	private static extern void TheymesAddTag(string tag) { }

	// RVA: 0x5C4894
	private static extern void TheymesAddTags(string tags) { }

	// RVA: 0x5C48BC
	private static extern void TheymesRemoveTag(string tag) { }

	// RVA: 0x5C48E4
	private static extern void TheymesRemoveTags(string tags) { }

	// RVA: 0x5C490C
	private static extern void TheymesRemoveAllTags() { }

	// RVA: 0x5C4910
	private static extern IntPtr TheymesGetFields() { }

	// RVA: 0x5C4914
	private static extern void TheymesSetFields(string fields) { }

	// RVA: 0x5C493C
	private static extern void TheymesAddField(string key, string value) { }

	// RVA: 0x5C4984
	private static extern void TheymesAddFields(string fields) { }

	// RVA: 0x5C49AC
	private static extern void TheymesRemoveField(string field) { }

	// RVA: 0x5C49D4
	private static extern void TheymesRemoveFields(string fields) { }

	// RVA: 0x5C49FC
	private static extern void TheymesRemoveAllFields() { }

	// RVA: 0x5C4A00
	private static extern void TheymesEnableLogging() { }

	// RVA: 0x5C4A04
	private static extern void TheymesDisableLogging() { }

	// RVA: 0x5C4A08
	private static extern bool TheymesIsYoungPlayer() { }

	// RVA: 0x5C4A24
	private static extern void TheymesSetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5C4A28
	private static extern bool TheymesIsPrivacyMode() { }

	// RVA: 0x5C4A44
	private static extern void TheymesSetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5C4A48
	private static extern void TheymesOnOpen(Action callback) { }

	// RVA: 0x5C4A5C
	private static extern void TheymesOnClose(Action callback) { }

	// RVA: 0x5C4A70
	private static extern void TheymesOnUnreadMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5C4A84
	private static extern void TheymesOnUnansweredMessageCountUpdated(System.Action<System.Int32> callback) { }

	// RVA: 0x5C4A98
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5C4AE0
	public static void OpenSupport() { }

	// RVA: 0x5C4AE4
	public static void OpenSupport(string configJson) { }

	// RVA: 0x5C4B0C
	public static void OpenResource(string resource) { }

	// RVA: 0x5C4B34
	public static void OpenResource(string resource, string configJson) { }

	// RVA: 0x5C4B7C
	public static void Close() { }

	// RVA: 0x5C4B80
	public static string GetSdkVersion() { }

	// RVA: 0x5C4C08
	public static bool IsSupported() { }

	// RVA: 0x5C4C24
	public static void RequestNotificationPermission() { }

	// RVA: 0x5C4C28
	public static void EnableNotifications() { }

	// RVA: 0x5C4C2C
	public static void DisableNotifications() { }

	// RVA: 0x5C4C30
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5C4C34
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5C4C38
	public static void RecordRetention() { }

	// RVA: 0x5C4C3C
	public static void Reset() { }

	// RVA: 0x5C4C40
	public static string GetLanguage() { }

	// RVA: 0x5C4CC8
	public static void SetLanguage(string language) { }

	// RVA: 0x5C4CF0
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5C4D78
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5C4DA0
	public static string GetPlayer() { }

	// RVA: 0x5C4E28
	public static void SetPlayer(string playerJson) { }

	// RVA: 0x5C4E50
	public static string GetTags() { }

	// RVA: 0x5C4ED8
	public static void SetTags(string tagsJson) { }

	// RVA: 0x5C4F00
	public static void AddTag(string tag) { }

	// RVA: 0x5C4F28
	public static void AddTags(string tagsJson) { }

	// RVA: 0x5C4F50
	public static void RemoveTag(string tag) { }

	// RVA: 0x5C4F78
	public static void RemoveTags(string tagsJson) { }

	// RVA: 0x5C4FA0
	public static void RemoveAllTags() { }

	// RVA: 0x5C4FA4
	public static string GetFields() { }

	// RVA: 0x5C502C
	public static void SetFields(string fieldsJson) { }

	// RVA: 0x5C5054
	public static void AddField(string key, string value) { }

	// RVA: 0x5C509C
	public static void AddFields(string fieldsJson) { }

	// RVA: 0x5C50C4
	public static void RemoveField(string field) { }

	// RVA: 0x5C50EC
	public static void RemoveFields(string fieldsJson) { }

	// RVA: 0x5C5114
	public static void RemoveAllFields() { }

	// RVA: 0x5C5118
	public static void EnableLogging() { }

	// RVA: 0x5C511C
	public static void DisableLogging() { }

	// RVA: 0x5C5120
	public static bool IsYoungPlayer() { }

	// RVA: 0x5C513C
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5C5140
	public static bool IsPrivacyMode() { }

	// RVA: 0x5C515C
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5C5160
	public static void SetupEventListeners() { }

	// RVA: 0x5C3E78
	public static void OnOpen() { }

	// RVA: 0x5C3EE0
	public static void OnClose() { }

	// RVA: 0x5C3F48
	public static void OnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5C3FC4
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

	// RVA: 0x5C52B8
	public string get_language() { }

	// RVA: 0x5C52C0
	public string get_signedMetadataToken() { }

	// RVA: 0x5C52C8
	public TheymesPlayer get_player() { }

	// RVA: 0x5C52D0
	public System.Collections.Generic.List<System.String> get_tags() { }

	// RVA: 0x5C52D8
	public System.Collections.Generic.Dictionary<System.String,System.Object> get_fields() { }

}

// Namespace: Theymes
internal class TheymesJsonHelpers
{
	// Methods

	// RVA: 0x5C52E0
	public static JSONObject PlayerToJsonObject(TheymesPlayer player) { }

	// RVA: 0x5C58FC
	public static string PlayerToJson(TheymesPlayer player) { }

	// RVA: 0x5C5BDC
	public static TheymesPlayer JsonToPlayer(string jsonStr) { }

	// RVA: 0x5C6640
	public static JSONObject ConfigToJsonObject(TheymesConfig config) { }

	// RVA: 0x5C6E90
	public static string ConfigToJson(TheymesConfig config) { }

	// RVA: 0x5C6FE8
	public static System.Collections.Generic.List<System.String> JsonToStringList(string jsonStr) { }

	// RVA: 0x5C6830
	public static JSONArray StringListToJsonArray(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5C76F8
	public static string StringListToJson(System.Collections.Generic.List<System.String> list) { }

	// RVA: 0x5C7850
	public static JSONNode ObjectToJsonNode(object value) { }

	// RVA: 0x5C7D50
	public static string ObjectToJson(object value) { }

	// RVA: 0x5C7D74
	public static System.Collections.Generic.Dictionary<System.String,System.Object> JsonToDictionary(string jsonStr) { }

	// RVA: 0x5C6B3C
	public static JSONObject DictionaryToJsonObject(System.Collections.Generic.Dictionary<System.String,System.Object> dict) { }

	// RVA: 0x5C8434
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

	// RVA: 0x5C858C
	public string get_id() { }

	// RVA: 0x5C8594
	public void set_id(string value) { }

	// RVA: 0x5C859C
	public string get_name() { }

	// RVA: 0x5C85A4
	public void set_name(string value) { }

	// RVA: 0x5C85AC
	public string get_email() { }

	// RVA: 0x5C85B4
	public void set_email(string value) { }

	// RVA: 0x5C85BC
	public System.Nullable<System.Int32> get_tier() { }

	// RVA: 0x5C85C4
	public void set_tier(System.Nullable<System.Int32> value) { }

	// RVA: 0x5C6488
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

	// RVA: 0x5C85CC
	public static void add_onOpen(Action value) { }

	// RVA: 0x5C868C
	public static void remove_onOpen(Action value) { }

	// RVA: 0x5C874C
	public static void add_onClose(Action value) { }

	// RVA: 0x5C8810
	public static void remove_onClose(Action value) { }

	// RVA: 0x5C88D4
	public static void add_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C89A8
	public static void remove_onUnreadMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C8A7C
	public static void add_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C8B50
	public static void remove_onUnansweredMessageCountUpdated(System.Action<System.Int32> value) { }

	// RVA: 0x5C8C24
	public static void Initialize(string token, string domain) { }

	// RVA: 0x5C8F24
	public static void OpenSupport() { }

	// RVA: 0x5C8F28
	public static void OpenSupport(TheymesConfig config) { }

	// RVA: 0x5C8F54
	public static void OpenResource(string resource) { }

	// RVA: 0x5C8F7C
	public static void OpenResource(string resource, TheymesConfig config) { }

	// RVA: 0x5C8FD4
	public static void Close() { }

	// RVA: 0x5C8FD8
	public static string GetSdkVersion() { }

	// RVA: 0x5C9060
	public static bool IsSupported() { }

	// RVA: 0x5C907C
	public static void RequestNotificationPermission() { }

	// RVA: 0x5C9080
	public static void EnableNotifications() { }

	// RVA: 0x5C9084
	public static void DisableNotifications() { }

	// RVA: 0x5C9088
	public static int GetUnreadMessageCount() { }

	// RVA: 0x5C908C
	public static int GetUnansweredMessageCount() { }

	// RVA: 0x5C9090
	public static void RecordRetention() { }

	// RVA: 0x5C9094
	public static void Reset() { }

	// RVA: 0x5C9098
	public static string GetLanguage() { }

	// RVA: 0x5C9120
	public static void SetLanguage(string language) { }

	// RVA: 0x5C9148
	public static string GetSignedMetadataToken() { }

	// RVA: 0x5C91D0
	public static void SetSignedMetadataToken(string token) { }

	// RVA: 0x5C91F8
	public static TheymesPlayer GetPlayer() { }

	// RVA: 0x5C9288
	public static void SetPlayer(TheymesPlayer player) { }

	// RVA: 0x5C92B4
	public static System.Collections.Generic.List<System.String> GetTags() { }

	// RVA: 0x5C9344
	public static void SetTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5C9370
	public static void AddTag(string tag) { }

	// RVA: 0x5C9398
	public static void AddTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5C93C4
	public static void RemoveTag(string tag) { }

	// RVA: 0x5C93EC
	public static void RemoveTags(System.Collections.Generic.List<System.String> tags) { }

	// RVA: 0x5C9418
	public static void RemoveAllTags() { }

	// RVA: 0x5C941C
	public static System.Collections.Generic.Dictionary<System.String,System.Object> GetFields() { }

	// RVA: 0x5C94AC
	public static void SetFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5C94D8
	public static void AddField(string key, object value) { }

	// RVA: 0x5C9544
	public static void AddFields(System.Collections.Generic.Dictionary<System.String,System.Object> fields) { }

	// RVA: 0x5C9570
	public static void RemoveField(string key) { }

	// RVA: 0x5C9598
	public static void RemoveFields(System.Collections.Generic.List<System.String> keys) { }

	// RVA: 0x5C95C4
	public static void RemoveAllFields() { }

	// RVA: 0x5C95C8
	public static void EnableLogging() { }

	// RVA: 0x5C95CC
	public static void DisableLogging() { }

	// RVA: 0x5C95D0
	public static bool IsYoungPlayer() { }

	// RVA: 0x5C95EC
	public static void SetYoungPlayer(bool youngPlayer) { }

	// RVA: 0x5C95F0
	public static bool IsPrivacyMode() { }

	// RVA: 0x5C960C
	public static void SetPrivacyMode(bool privacyMode) { }

	// RVA: 0x5C8CC8
	private static void _SetupEventListeners() { }

	// RVA: 0x5C9610
	private static void _TriggerOnOpen() { }

	// RVA: 0x5C9678
	private static void _TriggerOnClose() { }

	// RVA: 0x5C96E0
	private static void _TriggerOnUnreadMessageCountUpdated(int count) { }

	// RVA: 0x5C975C
	private static void _TriggerOnUnansweredMessageCountUpdated(int count) { }

	// RVA: 0x5C97D8
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

	// RVA: 0x5CB07C
	public void .ctor(Enumerator aArrayEnum) { }

	// RVA: 0x5CB0B4
	public void .ctor(Enumerator aDictEnum) { }

	// RVA: 0x5C738C
	public System.Collections.Generic.KeyValuePair<System.String,Theymes.SimpleJSON.JSONNode> get_Current() { }

	// RVA: 0x5C75A8
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

	// RVA: 0x5C97E0
	public virtual JSONNode get_Item(string aKey) { }

	// RVA: 0x5C97E8
	public virtual void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5C97EC
	public virtual string get_Value() { }

	// RVA: 0x5C9830
	public virtual bool get_IsNumber() { }

	// RVA: 0x5C9838
	public virtual bool get_IsString() { }

	// RVA: 0x5C9840
	public virtual bool get_IsBoolean() { }

	// RVA: 0x5C9848
	public virtual bool get_IsNull() { }

	// RVA: 0x5C9850
	public virtual bool get_IsArray() { }

	// RVA: 0x5C9858
	public virtual bool get_IsObject() { }

	// RVA: 0x5C9860
	public virtual void set_Inline(bool value) { }

	// RVA: 0x5C9864
	public virtual void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5C9868
	public virtual void Add(JSONNode aItem) { }

	// RVA: 0x5C98D0
	public override string ToString() { }

	// RVA: -1
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: -1
	public abstract Enumerator GetEnumerator() { }

	// RVA: 0x5C9968
	public virtual Double get_AsDouble() { }

	// RVA: 0x5C9A14
	public virtual int get_AsInt() { }

	// RVA: 0x5C9A4C
	public virtual bool get_AsBool() { }

	// RVA: 0x5C9B2C
	public virtual JSONArray get_AsArray() { }

	// RVA: 0x5C9BB0
	public virtual JSONObject get_AsObject() { }

	// RVA: 0x5C5754
	public static JSONNode op_Implicit(string s) { }

	// RVA: 0x5C6500
	public static string op_Implicit(JSONNode d) { }

	// RVA: 0x5C9C34
	public static JSONNode op_Implicit(Double n) { }

	// RVA: 0x5C584C
	public static JSONNode op_Implicit(int n) { }

	// RVA: 0x5C9CE0
	public static JSONNode op_Implicit(bool b) { }

	// RVA: 0x5C5A54
	public static bool op_Equality(JSONNode a, object b) { }

	// RVA: 0x5C6490
	public static bool op_Inequality(JSONNode a, object b) { }

	// RVA: 0x5C9D84
	public override bool Equals(object obj) { }

	// RVA: 0x5C9D90
	public override int GetHashCode() { }

	// RVA: 0x5C9D98
	internal static StringBuilder get_EscapeBuilder() { }

	// RVA: 0x5C9EA0
	internal static string Escape(string aText) { }

	// RVA: 0x5CA1D8
	private static JSONNode ParseElement(string token, bool quoted) { }

	// RVA: 0x5CA568
	public static JSONNode Parse(string aJSON) { }

	// RVA: 0x5CB020
	protected void .ctor() { }

	// RVA: 0x5CB028
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONArray
{
	// Fields
	private System.Collections.Generic.List<Theymes.SimpleJSON.JSONNode> m_List; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5CB0FC
	public override void set_Inline(bool value) { }

	// RVA: 0x5CB104
	public override bool get_IsArray() { }

	// RVA: 0x5CB10C
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CB1B4
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5CB2FC
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5CB478
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5CB5F4
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5C7640
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONObject
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,Theymes.SimpleJSON.JSONNode> m_Dict; // 0x10
	private bool inline; // 0x18

	// Methods

	// RVA: 0x5CB88C
	public override void set_Inline(bool value) { }

	// RVA: 0x5CB894
	public override bool get_IsObject() { }

	// RVA: 0x5CB89C
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CB950
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5CBB1C
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5CBD10
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5CBF68
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5C569C
	public void .ctor() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONString
{
	// Fields
	private string m_Data; // 0x10

	// Methods

	// RVA: 0x5CC448
	public override bool get_IsString() { }

	// RVA: 0x5CC450
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CC464
	public override string get_Value() { }

	// RVA: 0x5C7AF4
	public void .ctor(string aData) { }

	// RVA: 0x5CC46C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5CC514
	public override bool Equals(object obj) { }

	// RVA: 0x5CC748
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNumber
{
	// Fields
	private Double m_Data; // 0x10

	// Methods

	// RVA: 0x5CC76C
	public override bool get_IsNumber() { }

	// RVA: 0x5CC774
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CC788
	public override string get_Value() { }

	// RVA: 0x5CC7FC
	public override Double get_AsDouble() { }

	// RVA: 0x5C7B6C
	public void .ctor(Double aData) { }

	// RVA: 0x5CC804
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5CC8A8
	private static bool IsNumeric(object value) { }

	// RVA: 0x5CCA54
	public override bool Equals(object obj) { }

	// RVA: 0x5CCC9C
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONBool
{
	// Fields
	private bool m_Data; // 0x10

	// Methods

	// RVA: 0x5CCCBC
	public override bool get_IsBoolean() { }

	// RVA: 0x5CCCC4
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CCCD8
	public override string get_Value() { }

	// RVA: 0x5CCD60
	public override bool get_AsBool() { }

	// RVA: 0x5C7BE4
	public void .ctor(bool aData) { }

	// RVA: 0x5CCD68
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5CCDEC
	public override bool Equals(object obj) { }

	// RVA: 0x5CCE7C
	public override int GetHashCode() { }

}

// Namespace: Theymes.SimpleJSON
public class JSONNull
{
	// Fields
	private static JSONNull m_StaticInstance; // 0x0
	public static bool reuseSameInstance; // 0x8

	// Methods

	// RVA: 0x5C7C54
	public static JSONNull CreateOrGet() { }

	// RVA: 0x5CCF04
	private void .ctor() { }

	// RVA: 0x5CCF8C
	public override bool get_IsNull() { }

	// RVA: 0x5CCF94
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CCFA8
	public override string get_Value() { }

	// RVA: 0x5CCFEC
	public override bool get_AsBool() { }

	// RVA: 0x5CCFF4
	public override bool Equals(object obj) { }

	// RVA: 0x5CD0A4
	public override int GetHashCode() { }

	// RVA: 0x5CD0AC
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	// RVA: 0x5CD104
	private static void .cctor() { }

}

// Namespace: Theymes.SimpleJSON
internal class JSONLazyCreator
{
	// Fields
	private JSONNode m_Node; // 0x10
	private string m_Key; // 0x18

	// Methods

	// RVA: 0x5CD1C8
	public override Enumerator GetEnumerator() { }

	// RVA: 0x5CB274
	public void .ctor(JSONNode aNode) { }

	// RVA: 0x5CBA88
	public void .ctor(JSONNode aNode, string aKey) { }

	// RVA: 0x316B894
	private T Set(T aVal) { }

	// RVA: 0x5CD1DC
	public override JSONNode get_Item(string aKey) { }

	// RVA: 0x5CD2A8
	public override void set_Item(string aKey, JSONNode value) { }

	// RVA: 0x5CD354
	public override void Add(JSONNode aItem) { }

	// RVA: 0x5CD3F8
	public override void Add(string aKey, JSONNode aItem) { }

	// RVA: 0x5CD4A4
	public override bool Equals(object obj) { }

	// RVA: 0x5CD4B4
	public override int GetHashCode() { }

	// RVA: 0x5CD4BC
	public override int get_AsInt() { }

	// RVA: 0x5CD584
	public override Double get_AsDouble() { }

	// RVA: 0x5CD64C
	public override bool get_AsBool() { }

	// RVA: 0x5CD714
	public override JSONArray get_AsArray() { }

	// RVA: 0x5CD790
	public override JSONObject get_AsObject() { }

	// RVA: 0x5CD80C
	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

// Namespace: Theymes.SimpleJSON
public static class JSON
{
	// Methods

	// RVA: 0x5C6408
	public static JSONNode Parse(string aJSON) { }

}


