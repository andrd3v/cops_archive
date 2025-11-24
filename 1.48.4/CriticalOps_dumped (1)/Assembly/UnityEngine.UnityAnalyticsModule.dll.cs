// Namespace: 
internal class <Module> 
{}

// Namespace: 
public sealed class UpdatedEventHandler 
{
	// Methods

	// RVA: 0x17DFD70
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17DFE10
	internal void Invoke() { }

}

// Namespace: UnityEngine
public static class RemoteSettings 
{
	// Fields
	private static UpdatedEventHandler Updated; // 0x0
	private static Action BeforeFetchFromServer; // 0x8
	private static System.Action<System.Boolean,System.Boolean,System.Int32> Completed; // 0x10

	// Methods

	// RVA: 0x17DFC04
	void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

	// RVA: 0x17DFC6C
	void RemoteSettingsBeforeFetchFromServer() { }

	// RVA: 0x17DFCD4
	void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

}

// Namespace: UnityEngine
public class RemoteConfigSettings 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<System.Boolean> Updated; // 0x18

	// Methods

	// RVA: 0x17DFE24
	void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer) { }

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

	// RVA: 0x17DFF80
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17E0024
	internal void Invoke(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

}

// Namespace: 
public sealed class IdentityTokenChanged 
{
	// Methods

	// RVA: 0x17E0038
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17E00EC
	internal void Invoke(string token) { }

}

// Namespace: UnityEngine.Analytics
public static class AnalyticsSessionInfo 
{
	// Fields
	private static SessionStateChanged sessionStateChanged; // 0x0
	private static IdentityTokenChanged identityTokenChanged; // 0x8

	// Methods

	// RVA: 0x17DFE64
	void CallSessionStateChanged(AnalyticsSessionState sessionState, Int64 sessionId, Int64 sessionElapsedTime, bool sessionChanged) { }

	// RVA: 0x17DFF04
	void CallIdentityTokenChanged(string token) { }

}

// Namespace: UnityEngine.Analytics
internal class CustomEventData 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x17E0100
	void .ctor(string name) { }

	// RVA: 0x17E01C8
	void Finalize() { }

	// RVA: 0x17E02A4
	void Destroy() { }

	// RVA: 0x17E035C
	void Dispose() { }

	// RVA: 0x17E0160
	IntPtr Internal_Create(CustomEventData ced, string name) { }

	// RVA: 0x17E030C
	void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x17E0428
	bool AddString(string key, string value) { }

	// RVA: 0x17E0480
	bool AddInt32(string key, int value) { }

	// RVA: 0x17E04D8
	bool AddUInt32(string key, UInt32 value) { }

	// RVA: 0x17E0530
	bool AddInt64(string key, Int64 value) { }

	// RVA: 0x17E0588
	bool AddUInt64(string key, UInt64 value) { }

	// RVA: 0x17E05E0
	bool AddBool(string key, bool value) { }

	// RVA: 0x17E0638
	bool AddDouble(string key, Double value) { }

	// RVA: 0x17E0698
	bool AddDictionary(System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

}

// Namespace: UnityEngine.Analytics
public static class Analytics 
{
	// Methods

	// RVA: 0x17E1858
	void set_initializeOnStartup(bool value) { }

	// RVA: 0x17E1970
	AnalyticsResult ResumeInitialization() { }

	// RVA: 0x17E19EC
	AnalyticsResult ResumeInitializationInternal() { }

	// RVA: 0x17E1920
	void set_initializeOnStartupInternal(bool value) { }

	// RVA: 0x17E18E0
	bool IsInitialized() { }

	// RVA: 0x17E1A2C
	AnalyticsResult Transaction(string productId, Double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x17E1AAC
	AnalyticsResult SendCustomEventName(string customEventName) { }

	// RVA: 0x17E1AFC
	AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	// RVA: 0x17E1B4C
	AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x17E1B54
	AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	// RVA: 0x17E1D58
	AnalyticsResult CustomEvent(string customEventName, System.Collections.Generic.IDictionary<System.String,System.Object> eventData) { }

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


