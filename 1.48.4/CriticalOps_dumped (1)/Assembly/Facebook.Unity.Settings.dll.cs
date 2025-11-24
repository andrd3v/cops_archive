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

	// RVA: 0x75AD20
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x75ADC0
	internal void Invoke() { }

	// RVA: 0x75ADD4
	internal IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x75AE2C
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class UrlSchemes 
{
	// Fields
	private System.Collections.Generic.List<System.String> list; // 0x10

	// Methods

	// RVA: 0x75ABD4
	void .ctor(System.Collections.Generic.List<System.String> schemes) { }

	// RVA: 0x75AE38
	System.Collections.Generic.List<System.String> get_Schemes() { }

	// RVA: 0x75AE40
	void set_Schemes(System.Collections.Generic.List<System.String> value) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Facebook.Unity.Settings.FacebookSettings.<>c <>9; // 0x0
	public static System.Action<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> <>9__85_0; // 0x8

	// Methods

	// RVA: 0x75AE48
	void .cctor() { }

	// RVA: 0x75AEB4
	void .ctor() { }

	// RVA: 0x75AEBC
	void <SettingsChanged>b__85_0(OnChangeCallback callback) { }

}

// Namespace: Facebook.Unity.Settings
public class FacebookSettings 
{
	// Fields
	public const string FacebookSettingsAssetName = 5736247040;
	public const string FacebookSettingsPath = 5714616144;
	public const string FacebookSettingsAssetExtension = 5736094624;
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

	// RVA: 0x758C88
	BuildTarget get_EditorBuildTarget() { }

	// RVA: 0x758E48
	void set_EditorBuildTarget(BuildTarget value) { }

	// RVA: 0x758EC8
	int get_SelectedAppIndex() { }

	// RVA: 0x758F3C
	void set_SelectedAppIndex(int value) { }

	// RVA: 0x75915C
	System.Collections.Generic.List<System.String> get_AppIds() { }

	// RVA: 0x7591D0
	void set_AppIds(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x759290
	System.Collections.Generic.List<System.String> get_AppLabels() { }

	// RVA: 0x759304
	void set_AppLabels(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x7593C4
	System.Collections.Generic.List<System.String> get_ClientTokens() { }

	// RVA: 0x759438
	void set_ClientTokens(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x7594F8
	string get_AppId() { }

	// RVA: 0x759654
	string get_ClientToken() { }

	// RVA: 0x7597B0
	bool get_IsValidAppId() { }

	// RVA: 0x75989C
	bool get_Cookie() { }

	// RVA: 0x759910
	void set_Cookie(bool value) { }

	// RVA: 0x7599C8
	bool get_Logging() { }

	// RVA: 0x759A3C
	void set_Logging(bool value) { }

	// RVA: 0x759AF4
	bool get_Status() { }

	// RVA: 0x759B68
	void set_Status(bool value) { }

	// RVA: 0x759C20
	bool get_Xfbml() { }

	// RVA: 0x759C94
	void set_Xfbml(bool value) { }

	// RVA: 0x759D4C
	string get_AndroidKeystorePath() { }

	// RVA: 0x759DC0
	void set_AndroidKeystorePath(string value) { }

	// RVA: 0x759E88
	string get_IosURLSuffix() { }

	// RVA: 0x759EFC
	void set_IosURLSuffix(string value) { }

	// RVA: 0x759FC4
	string get_ChannelUrl() { }

	// RVA: 0x75A008
	bool get_FrictionlessRequests() { }

	// RVA: 0x75A07C
	void set_FrictionlessRequests(bool value) { }

	// RVA: 0x75A134
	System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes() { }

	// RVA: 0x75A1A8
	void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value) { }

	// RVA: 0x75A268
	string get_UploadAccessToken() { }

	// RVA: 0x75A2DC
	void set_UploadAccessToken(string value) { }

	// RVA: 0x75A3A4
	bool get_AutoLogAppEventsEnabled() { }

	// RVA: 0x75A418
	void set_AutoLogAppEventsEnabled(bool value) { }

	// RVA: 0x75A4D0
	bool get_AdvertiserIDCollectionEnabled() { }

	// RVA: 0x75A544
	void set_AdvertiserIDCollectionEnabled(bool value) { }

	// RVA: 0x758CFC
	FacebookSettings get_Instance() { }

	// RVA: 0x75A5FC
	FacebookSettings get_NullableInstance() { }

	// RVA: 0x75A80C
	void RegisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x75A8B0
	void UnregisterChangeEventCallback(OnChangeCallback callback) { }

	// RVA: 0x758FF4
	void SettingsChanged() { }

	// RVA: 0x75A954
	void .ctor() { }

	// RVA: 0x75AC84
	void .cctor() { }

}


