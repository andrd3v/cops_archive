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

	// RVA: 0x780764
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x780804
	public virtual void Invoke() { }

	// RVA: 0x780818
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x780870
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class UrlSchemes
{
	// Fields
	private System.Collections.Generic.List<System.String> list; // 0x10

	// Methods

	// RVA: 0x780618
	public void .ctor(System.Collections.Generic.List<System.String> schemes) { }

	// RVA: 0x78087C
	public System.Collections.Generic.List<System.String> get_Schemes() { }

	// RVA: 0x780884
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

	// RVA: 0x78088C
	private static void .cctor() { }

	// RVA: 0x7808F8
	public void .ctor() { }

	// RVA: 0x780900
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

	// RVA: 0x77E6CC
	public static BuildTarget get_EditorBuildTarget() { }

	// RVA: 0x77E88C
	public static void set_EditorBuildTarget(BuildTarget value) { }

	// RVA: 0x77E90C
	public static int get_SelectedAppIndex() { }

	// RVA: 0x77E980
	public static void set_SelectedAppIndex(int value) { }

	// RVA: 0x77EBA0
	public static System.Collections.Generic.List<System.String> get_AppIds() { }

	// RVA: 0x77EC14
	public static void set_AppIds(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x77ECD4
	public static System.Collections.Generic.List<System.String> get_AppLabels() { }

	// RVA: 0x77ED48
	public static void set_AppLabels(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x77EE08
	public static System.Collections.Generic.List<System.String> get_ClientTokens() { }

	// RVA: 0x77EE7C
	public static void set_ClientTokens(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x77EF3C
	public static string get_AppId() { }

	// RVA: 0x77F098
	public static string get_ClientToken() { }

	// RVA: 0x77F1F4
	public static bool get_IsValidAppId() { }

	// RVA: 0x77F2E0
	public static bool get_Cookie() { }

	// RVA: 0x77F354
	public static void set_Cookie(bool value) { }

	// RVA: 0x77F40C
	public static bool get_Logging() { }

	// RVA: 0x77F480
	public static void set_Logging(bool value) { }

	// RVA: 0x77F538
	public static bool get_Status() { }

	// RVA: 0x77F5AC
	public static void set_Status(bool value) { }

	// RVA: 0x77F664
	public static bool get_Xfbml() { }

	// RVA: 0x77F6D8
	public static void set_Xfbml(bool value) { }

	// RVA: 0x77F790
	public static string get_AndroidKeystorePath() { }

	// RVA: 0x77F804
	public static void set_AndroidKeystorePath(string value) { }

	// RVA: 0x77F8CC
	public static string get_IosURLSuffix() { }

	// RVA: 0x77F940
	public static void set_IosURLSuffix(string value) { }

	// RVA: 0x77FA08
	public static string get_ChannelUrl() { }

	// RVA: 0x77FA4C
	public static bool get_FrictionlessRequests() { }

	// RVA: 0x77FAC0
	public static void set_FrictionlessRequests(bool value) { }

	// RVA: 0x77FB78
	public static System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes() { }

	// RVA: 0x77FBEC
	public static void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value) { }

	// RVA: 0x77FCAC
	public static string get_UploadAccessToken() { }

	// RVA: 0x77FD20
	public static void set_UploadAccessToken(string value) { }

	// RVA: 0x77FDE8
	public static bool get_AutoLogAppEventsEnabled() { }

	// RVA: 0x77FE5C
	public static void set_AutoLogAppEventsEnabled(bool value) { }

	// RVA: 0x77FF14
	public static bool get_AdvertiserIDCollectionEnabled() { }

	// RVA: 0x77FF88
	public static void set_AdvertiserIDCollectionEnabled(bool value) { }

	// RVA: 0x77E740
	public static FacebookSettings get_Instance() { }

	// RVA: 0x780040
	public static FacebookSettings get_NullableInstance() { }

	// RVA: 0x780250
	public static void RegisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x7802F4
	public static void UnregisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x77EA38
	private static void SettingsChanged() { }

	// RVA: 0x780398
	public void .ctor() { }

	// RVA: 0x7806C8
	private static void .cctor() { }

}


