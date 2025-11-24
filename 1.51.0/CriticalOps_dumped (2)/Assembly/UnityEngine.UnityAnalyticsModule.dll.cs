// Namespace: 
internal class <Module>
{}

// Namespace: 
public sealed class UpdatedEventHandler
{
	// Methods

	// RVA: 0x1A54B7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A54C1C
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public static class RemoteSettings
{
	// Fields
	private static UpdatedEventHandler Updated; // 0x0
	private static Action BeforeFetchFromServer; // 0x8
	private static System.Action<System.Boolean,System.Boolean,System.Int32> Completed; // 0x10

	// Methods

	// RVA: 0x1A54A10
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	// RVA: 0x1A54A78
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	// RVA: 0x1A54AE0
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

// Namespace: UnityEngine
public class RemoteConfigSettings
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<System.Boolean> Updated; // 0x18

	// Methods

	// RVA: 0x1A54C30
	internal static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }

}

// Namespace: 
internal enum Tag
{
	// Fields
	public int value__; // 0x10
	public const Tag kUnknown = 0;
	public const Tag kIntVal = 1;
	public const Tag kInt64Val = 2;
	public const Tag kUInt64Val = 3;
	public const Tag kDoubleVal = 4;
	public const Tag kBoolVal = 5;
	public const Tag kStringVal = 6;
	public const Tag kArrayVal = 7;
	public const Tag kMixedArrayVal = 8;
	public const Tag kMapVal = 9;
	public const Tag kMaxTags = 10;
}

// Namespace: UnityEngine
internal static class RemoteConfigSettingsHelper
{}

// Namespace: UnityEngine.Analytics
public class ContinuousEvent
{}

// Namespace: UnityEngine.Analytics
public enum AnalyticsSessionState
{
	// Fields
	public int value__; // 0x10
	public const AnalyticsSessionState kSessionStopped = 0;
	public const AnalyticsSessionState kSessionStarted = 1;
	public const AnalyticsSessionState kSessionPaused = 2;
	public const AnalyticsSessionState kSessionResumed = 3;
}

// Namespace: 
public sealed class SessionStateChanged
{
	// Methods

	// RVA: 0x1A54D8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A54E30
	public virtual void Invoke(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

}

// Namespace: 
public sealed class IdentityTokenChanged
{
	// Methods

	// RVA: 0x1A54E44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A54EF8
	public virtual void Invoke(string token) { }

}

// Namespace: UnityEngine.Analytics
public static class AnalyticsSessionInfo
{
	// Fields
	private static SessionStateChanged sessionStateChanged; // 0x0
	private static IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	// RVA: 0x1A54C70
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

	// RVA: 0x1A54D10
	internal static void CallIdentityTokenChanged(string token) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A570B4
	public static IntPtr ConvertToNative(CustomEventData customEventData) { }

}

// Namespace: UnityEngine.Analytics
internal class CustomEventData
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1A54F0C
	public void .ctor(string name) { }

	// RVA: 0x1A550E0
	protected override void Finalize() { }

	// RVA: 0x1A551AC
	private void Destroy() { }

	// RVA: 0x1A55254
	public void Dispose() { }

	// RVA: 0x1A54F44
	internal static IntPtr Internal_Create(CustomEventData ced, string name) { }

	// RVA: 0x1A55204
	internal static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1A5536C
	public bool AddString(string key, string value) { }

	// RVA: 0x1A55658
	public bool AddInt32(string key, int value) { }

	// RVA: 0x1A55884
	public bool AddUInt32(string key, UInt32 value) { }

	// RVA: 0x1A55AB0
	public bool AddInt64(string key, Int64 value) { }

	// RVA: 0x1A55CDC
	public bool AddUInt64(string key, UInt64 value) { }

	// RVA: 0x1A55F08
	public bool AddBool(string key, bool value) { }

	// RVA: 0x1A56134
	public bool AddDouble(string key, Double value) { }

	// RVA: 0x1A56374
	public bool AddDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

	// RVA: 0x1A55304
	private static IntPtr Internal_Create_Injected(CustomEventData ced, ManagedSpanWrapper name) { }

	// RVA: 0x1A55600
	private static bool AddString_Injected(IntPtr _unity_self, ManagedSpanWrapper key, ManagedSpanWrapper value) { }

	// RVA: 0x1A5582C
	private static bool AddInt32_Injected(IntPtr _unity_self, ManagedSpanWrapper key, int value) { }

	// RVA: 0x1A55A58
	private static bool AddUInt32_Injected(IntPtr _unity_self, ManagedSpanWrapper key, UInt32 value) { }

	// RVA: 0x1A55C84
	private static bool AddInt64_Injected(IntPtr _unity_self, ManagedSpanWrapper key, Int64 value) { }

	// RVA: 0x1A55EB0
	private static bool AddUInt64_Injected(IntPtr _unity_self, ManagedSpanWrapper key, UInt64 value) { }

	// RVA: 0x1A560DC
	private static bool AddBool_Injected(IntPtr _unity_self, ManagedSpanWrapper key, bool value) { }

	// RVA: 0x1A56314
	private static bool AddDouble_Injected(IntPtr _unity_self, ManagedSpanWrapper key, Double value) { }

}

// Namespace: UnityEngine.Analytics
public static class Analytics
{
	// Methods

	// RVA: 0x1A570D0
	public static void set_initializeOnStartup(bool value) { }

	// RVA: 0x1A571E8
	public static AnalyticsResult ResumeInitialization() { }

	// RVA: 0x1A57264
	private static AnalyticsResult ResumeInitializationInternal() { }

	// RVA: 0x1A57198
	private static void set_initializeOnStartupInternal(bool value) { }

	// RVA: 0x1A57158
	internal static bool IsInitialized() { }

	// RVA: 0x1A572A4
	private static AnalyticsResult Transaction(string productId, Double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x1A57728
	private static AnalyticsResult SendCustomEventName(string customEventName) { }

	// RVA: 0x1A57900
	private static AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	// RVA: 0x1A579B4
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x1A579BC
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x1A57B80
	public static AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

	// RVA: 0x1A576A8
	private static AnalyticsResult Transaction_Injected(ManagedSpanWrapper productId, Double amount, ManagedSpanWrapper currency, ManagedSpanWrapper receiptPurchaseData, ManagedSpanWrapper signature, bool usingIAPService) { }

	// RVA: 0x1A578B0
	private static AnalyticsResult SendCustomEventName_Injected(ManagedSpanWrapper customEventName) { }

	// RVA: 0x1A57964
	private static AnalyticsResult SendCustomEvent_Injected(IntPtr eventData) { }

}


