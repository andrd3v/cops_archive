// Namespace: 
internal class <Module>
{}

// Namespace: 
public enum BuildTarget
{
	// Fields
	public int value__; // 0x10
	public const BuildTarget StandaloneOSX = 0;
	public const BuildTarget StandaloneWindows = 1;
	public const BuildTarget iOS = 2;
	public const BuildTarget Android = 3;
	public const BuildTarget StandaloneWindows64 = 4;
	public const BuildTarget WebGL = 5;
	public const BuildTarget WSAPlayer = 6;
	public const BuildTarget StandaloneLinux64 = 7;
	public const BuildTarget PS4 = 8;
	public const BuildTarget XboxOne = 9;
	public const BuildTarget tvOS = 10;
	public const BuildTarget Switch = 11;
	public const BuildTarget Stadia = 12;
	public const BuildTarget CloudRendering = 13;
	public const BuildTarget PS5 = 14;
	public const BuildTarget none = 15;
}

// Namespace: 
public sealed class OnChangeCallback
{
	// Methods

	// RVA: 0x7972DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x79737C
	public virtual void Invoke() { }

	// RVA: 0x797390
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x7973E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class UrlSchemes
{
	// Fields
	private System.Collections.Generic.List<System.String> list; // 0x10

	// Methods

	// RVA: 0x797190
	public void .ctor(System.Collections.Generic.List<System.String> schemes) { }

	// RVA: 0x7973F4
	public System.Collections.Generic.List<System.String> get_Schemes() { }

	// RVA: 0x7973FC
	public void set_Schemes(System.Collections.Generic.List<System.String> value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Facebook.Unity.Settings.FacebookSettings.<>c <>9; // 0x0
	public static System.Action<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> <>9__85_0; // 0x8

	// Methods

	// RVA: 0x797404
	private static void .cctor() { }

	// RVA: 0x797470
	public void .ctor() { }

	// RVA: 0x797478
	internal void <SettingsChanged>b__85_0(OnChangeCallback callback) { }

}

// Namespace: Facebook.Unity.Settings
public class FacebookSettings
{
	// Fields
	public const string FacebookSettingsAssetName = "FacebookSettings";
	public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";
	public const string FacebookSettingsAssetExtension = ".asset";
	private static System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> onChangeCallbacks; // 0x0
	private static FacebookSettings instance; // 0x8
	private int selectedAppIndex; // 0x18
	private System.Collections.Generic.List<System.String> clientTokens; // 0x20
	private System.Collections.Generic.List<System.String> appIds; // 0x28
	private System.Collections.Generic.List<System.String> appLabels; // 0x30
	private bool cookie; // 0x38
	private bool logging; // 0x39
	private bool status; // 0x3A
	private bool xfbml; // 0x3B
	private bool frictionlessRequests; // 0x3C
	private string androidKeystorePath; // 0x40
	private string iosURLSuffix; // 0x48
	private System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> appLinkSchemes; // 0x50
	private string uploadAccessToken; // 0x58
	private bool autoLogAppEventsEnabled; // 0x60
	private bool advertiserIDCollectionEnabled; // 0x61
	private BuildTarget editorBuildTargetName; // 0x64

	// Methods

	// RVA: 0x795244
	public static BuildTarget get_EditorBuildTarget() { }

	// RVA: 0x795404
	public static void set_EditorBuildTarget(BuildTarget value) { }

	// RVA: 0x795484
	public static int get_SelectedAppIndex() { }

	// RVA: 0x7954F8
	public static void set_SelectedAppIndex(int value) { }

	// RVA: 0x795718
	public static System.Collections.Generic.List<System.String> get_AppIds() { }

	// RVA: 0x79578C
	public static void set_AppIds(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x79584C
	public static System.Collections.Generic.List<System.String> get_AppLabels() { }

	// RVA: 0x7958C0
	public static void set_AppLabels(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x795980
	public static System.Collections.Generic.List<System.String> get_ClientTokens() { }

	// RVA: 0x7959F4
	public static void set_ClientTokens(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x795AB4
	public static string get_AppId() { }

	// RVA: 0x795C10
	public static string get_ClientToken() { }

	// RVA: 0x795D6C
	public static bool get_IsValidAppId() { }

	// RVA: 0x795E58
	public static bool get_Cookie() { }

	// RVA: 0x795ECC
	public static void set_Cookie(bool value) { }

	// RVA: 0x795F84
	public static bool get_Logging() { }

	// RVA: 0x795FF8
	public static void set_Logging(bool value) { }

	// RVA: 0x7960B0
	public static bool get_Status() { }

	// RVA: 0x796124
	public static void set_Status(bool value) { }

	// RVA: 0x7961DC
	public static bool get_Xfbml() { }

	// RVA: 0x796250
	public static void set_Xfbml(bool value) { }

	// RVA: 0x796308
	public static string get_AndroidKeystorePath() { }

	// RVA: 0x79637C
	public static void set_AndroidKeystorePath(string value) { }

	// RVA: 0x796444
	public static string get_IosURLSuffix() { }

	// RVA: 0x7964B8
	public static void set_IosURLSuffix(string value) { }

	// RVA: 0x796580
	public static string get_ChannelUrl() { }

	// RVA: 0x7965C4
	public static bool get_FrictionlessRequests() { }

	// RVA: 0x796638
	public static void set_FrictionlessRequests(bool value) { }

	// RVA: 0x7966F0
	public static System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes() { }

	// RVA: 0x796764
	public static void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value) { }

	// RVA: 0x796824
	public static string get_UploadAccessToken() { }

	// RVA: 0x796898
	public static void set_UploadAccessToken(string value) { }

	// RVA: 0x796960
	public static bool get_AutoLogAppEventsEnabled() { }

	// RVA: 0x7969D4
	public static void set_AutoLogAppEventsEnabled(bool value) { }

	// RVA: 0x796A8C
	public static bool get_AdvertiserIDCollectionEnabled() { }

	// RVA: 0x796B00
	public static void set_AdvertiserIDCollectionEnabled(bool value) { }

	// RVA: 0x7952B8
	public static FacebookSettings get_Instance() { }

	// RVA: 0x796BB8
	public static FacebookSettings get_NullableInstance() { }

	// RVA: 0x796DC8
	public static void RegisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x796E6C
	public static void UnregisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x7955B0
	private static void SettingsChanged() { }

	// RVA: 0x796F10
	public void .ctor() { }

	// RVA: 0x797240
	private static void .cctor() { }

}


