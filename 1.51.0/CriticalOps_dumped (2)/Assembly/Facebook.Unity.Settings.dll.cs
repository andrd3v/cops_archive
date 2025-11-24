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

	// RVA: 0x7B56DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B577C
	public virtual void Invoke() { }

	// RVA: 0x7B5790
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x7B57E8
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class UrlSchemes
{
	// Fields
	private System.Collections.Generic.List<System.String> list; // 0x10

	// Methods

	// RVA: 0x7B5590
	public void .ctor(System.Collections.Generic.List<System.String> schemes) { }

	// RVA: 0x7B57F4
	public System.Collections.Generic.List<System.String> get_Schemes() { }

	// RVA: 0x7B57FC
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

	// RVA: 0x7B5804
	private static void .cctor() { }

	// RVA: 0x7B5870
	public void .ctor() { }

	// RVA: 0x7B5878
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

	// RVA: 0x7B3650
	public static BuildTarget get_EditorBuildTarget() { }

	// RVA: 0x7B3810
	public static void set_EditorBuildTarget(BuildTarget value) { }

	// RVA: 0x7B3890
	public static int get_SelectedAppIndex() { }

	// RVA: 0x7B3904
	public static void set_SelectedAppIndex(int value) { }

	// RVA: 0x7B3B24
	public static System.Collections.Generic.List<System.String> get_AppIds() { }

	// RVA: 0x7B3B98
	public static void set_AppIds(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x7B3C58
	public static System.Collections.Generic.List<System.String> get_AppLabels() { }

	// RVA: 0x7B3CCC
	public static void set_AppLabels(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x7B3D8C
	public static System.Collections.Generic.List<System.String> get_ClientTokens() { }

	// RVA: 0x7B3E00
	public static void set_ClientTokens(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x7B3EC0
	public static string get_AppId() { }

	// RVA: 0x7B401C
	public static string get_ClientToken() { }

	// RVA: 0x7B4178
	public static bool get_IsValidAppId() { }

	// RVA: 0x7B4264
	public static bool get_Cookie() { }

	// RVA: 0x7B42D8
	public static void set_Cookie(bool value) { }

	// RVA: 0x7B4390
	public static bool get_Logging() { }

	// RVA: 0x7B4404
	public static void set_Logging(bool value) { }

	// RVA: 0x7B44BC
	public static bool get_Status() { }

	// RVA: 0x7B4530
	public static void set_Status(bool value) { }

	// RVA: 0x7B45E8
	public static bool get_Xfbml() { }

	// RVA: 0x7B465C
	public static void set_Xfbml(bool value) { }

	// RVA: 0x7B4714
	public static string get_AndroidKeystorePath() { }

	// RVA: 0x7B4788
	public static void set_AndroidKeystorePath(string value) { }

	// RVA: 0x7B4850
	public static string get_IosURLSuffix() { }

	// RVA: 0x7B48C4
	public static void set_IosURLSuffix(string value) { }

	// RVA: 0x7B498C
	public static string get_ChannelUrl() { }

	// RVA: 0x7B49D0
	public static bool get_FrictionlessRequests() { }

	// RVA: 0x7B4A44
	public static void set_FrictionlessRequests(bool value) { }

	// RVA: 0x7B4AFC
	public static System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes() { }

	// RVA: 0x7B4B70
	public static void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value) { }

	// RVA: 0x7B4C30
	public static string get_UploadAccessToken() { }

	// RVA: 0x7B4CA4
	public static void set_UploadAccessToken(string value) { }

	// RVA: 0x7B4D6C
	public static bool get_AutoLogAppEventsEnabled() { }

	// RVA: 0x7B4DE0
	public static void set_AutoLogAppEventsEnabled(bool value) { }

	// RVA: 0x7B4E98
	public static bool get_AdvertiserIDCollectionEnabled() { }

	// RVA: 0x7B4F0C
	public static void set_AdvertiserIDCollectionEnabled(bool value) { }

	// RVA: 0x7B36C4
	public static FacebookSettings get_Instance() { }

	// RVA: 0x7B4FC4
	public static FacebookSettings get_NullableInstance() { }

	// RVA: 0x7B51D4
	public static void RegisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x7B5278
	public static void UnregisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x7B39BC
	private static void SettingsChanged() { }

	// RVA: 0x7B531C
	public void .ctor() { }

	// RVA: 0x7B5640
	private static void .cctor() { }

}


