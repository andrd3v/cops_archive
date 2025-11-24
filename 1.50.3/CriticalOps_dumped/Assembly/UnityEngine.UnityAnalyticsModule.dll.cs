// Namespace: 
internal class <Module>
{}

// Namespace: 
public sealed class UpdatedEventHandler
{
	// Methods

	// RVA: 0x18F7198
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18F7238
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

	// RVA: 0x18F702C
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	// RVA: 0x18F7094
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	// RVA: 0x18F70FC
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

// Namespace: UnityEngine
public class RemoteConfigSettings
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<System.Boolean> Updated; // 0x18

	// Methods

	// RVA: 0x18F724C
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

	// RVA: 0x18F73A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18F744C
	public virtual void Invoke(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

}

// Namespace: 
public sealed class IdentityTokenChanged
{
	// Methods

	// RVA: 0x18F7460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18F7514
	public virtual void Invoke(string token) { }

}

// Namespace: UnityEngine.Analytics
public static class AnalyticsSessionInfo
{
	// Fields
	private static SessionStateChanged sessionStateChanged; // 0x0
	private static IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	// RVA: 0x18F728C
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

	// RVA: 0x18F732C
	internal static void CallIdentityTokenChanged(string token) { }

}

// Namespace: UnityEngine.Analytics
internal class CustomEventData
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x18F7528
	public void .ctor(string name) { }

	// RVA: 0x18F75F0
	protected override void Finalize() { }

	// RVA: 0x18F76CC
	private void Destroy() { }

	// RVA: 0x18F7784
	public void Dispose() { }

	// RVA: 0x18F7588
	internal static IntPtr Internal_Create(CustomEventData ced, string name) { }

	// RVA: 0x18F7734
	internal static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x18F7850
	public bool AddString(string key, string value) { }

	// RVA: 0x18F78A8
	public bool AddInt32(string key, int value) { }

	// RVA: 0x18F7900
	public bool AddUInt32(string key, UInt32 value) { }

	// RVA: 0x18F7958
	public bool AddInt64(string key, Int64 value) { }

	// RVA: 0x18F79B0
	public bool AddUInt64(string key, UInt64 value) { }

	// RVA: 0x18F7A08
	public bool AddBool(string key, bool value) { }

	// RVA: 0x18F7A60
	public bool AddDouble(string key, Double value) { }

	// RVA: 0x18F7AC0
	public bool AddDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

}

// Namespace: UnityEngine.Analytics
public static class Analytics
{
	// Methods

	// RVA: 0x18F8C80
	public static void set_initializeOnStartup(bool value) { }

	// RVA: 0x18F8D98
	public static AnalyticsResult ResumeInitialization() { }

	// RVA: 0x18F8E14
	private static AnalyticsResult ResumeInitializationInternal() { }

	// RVA: 0x18F8D48
	private static void set_initializeOnStartupInternal(bool value) { }

	// RVA: 0x18F8D08
	internal static bool IsInitialized() { }

	// RVA: 0x18F8E54
	private static AnalyticsResult Transaction(string productId, Double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x18F8ED4
	private static AnalyticsResult SendCustomEventName(string customEventName) { }

	// RVA: 0x18F8F24
	private static AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	// RVA: 0x18F8F74
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x18F8F7C
	public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x18F9180
	public static AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

}

// Namespace: UnityEngine.Analytics
public enum AnalyticsResult
{
	// Fields
	public int value__; // 0x10
	public const AnalyticsResult Ok = 0;
	public const AnalyticsResult NotInitialized = 1;
	public const AnalyticsResult AnalyticsDisabled = 2;
	public const AnalyticsResult TooManyItems = 3;
	public const AnalyticsResult SizeLimitReached = 4;
	public const AnalyticsResult TooManyRequests = 5;
	public const AnalyticsResult InvalidData = 6;
	public const AnalyticsResult UnsupportedPlatform = 7;
}


