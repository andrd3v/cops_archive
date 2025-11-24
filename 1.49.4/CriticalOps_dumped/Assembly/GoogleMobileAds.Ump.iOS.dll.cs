// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class GADUConsentFormLoadCompletionHandler
{
	// Methods

	// RVA: 0xA0B6CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0C164
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0C178
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA0C244
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUConsentFormPresentCompletionHandler
{
	// Methods

	// RVA: 0xA0B990
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0C250
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0C264
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA0C330
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class ConsentFormClient
{
	// Fields
	private static readonly ConsentFormClient _instance; // 0x0
	private readonly IntPtr _consentForm; // 0x10
	private readonly IntPtr _consentFormClientPtr; // 0x18
	private Action _loadCompleteAction; // 0x20
	private System.Action<GoogleMobileAds.Ump.Api.FormError> _loadFailedAction; // 0x28
	private System.Action<GoogleMobileAds.Ump.Api.FormError> _consentFormDismissedAction; // 0x30
	private static GADUConsentFormLoadCompletionHandler <>f__mg$cache0; // 0x8
	private static GADUConsentFormPresentCompletionHandler <>f__mg$cache1; // 0x10
	private static GADUConsentFormPresentCompletionHandler <>f__mg$cache2; // 0x18
	private static GADUConsentFormPresentCompletionHandler <>f__mg$cache3; // 0x20

	// Methods

	// RVA: 0xA0B37C
	private void .ctor() { }

	// RVA: 0xA0B448
	public static ConsentFormClient get_Instance() { }

	// RVA: 0xA0B4C4
	public void Load(Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError) { }

	// RVA: 0xA0B79C
	public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA0BA60
	public void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA0BC80
	public void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA0AD88
	internal static void ConsentFormLoadCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0B0A8
	internal static void ConsentFormPresentCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0BEA0
	private static ConsentFormClient IntPtrToConsentFormClient(IntPtr clientRef) { }

	// RVA: 0xA0BF84
	public void Dispose() { }

	// RVA: 0xA0BFB8
	protected override void Finalize() { }

	// RVA: 0xA0C060
	private static void .cctor() { }

}

// Namespace: 
internal sealed class GADUConsentInfoUpdateCallback
{
	// Methods

	// RVA: 0xA0CBB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA0D4C0
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0D4D4
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA0D5A0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class ConsentInformationClient
{
	// Fields
	private static readonly ConsentInformationClient _instance; // 0x0
	private readonly IntPtr _consentInformationClientPtr; // 0x10
	private IntPtr _consentInformationPtr; // 0x18
	private Action _consentInfoUpdateSuccessAction; // 0x20
	private System.Action<GoogleMobileAds.Ump.Api.FormError> _consentInfoUpdateFailureAction; // 0x28
	private static GADUConsentInfoUpdateCallback <>f__mg$cache0; // 0x8

	// Methods

	// RVA: 0xA0C65C
	private void .ctor() { }

	// RVA: 0xA0C760
	private IntPtr get_ConsentInformationPtr() { }

	// RVA: 0xA0C734
	private void set_ConsentInformationPtr(IntPtr value) { }

	// RVA: 0xA0C76C
	public static ConsentInformationClient get_Instance() { }

	// RVA: 0xA0C7E8
	public void Update(ConsentRequestParameters request, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0xA0CC88
	public void Reset() { }

	// RVA: 0xA0CDB0
	public int GetConsentStatus() { }

	// RVA: 0xA0CEF4
	public int GetPrivacyOptionsRequirementStatus() { }

	// RVA: 0xA0D038
	public bool CanRequestAds() { }

	// RVA: 0xA0D184
	public bool IsConsentFormAvailable() { }

	// RVA: 0xA0C33C
	internal static void ConsentInfoUpdateCallback(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA0D2D0
	private static ConsentInformationClient IntPtrToConsentInformationClient(IntPtr clientRef) { }

	// RVA: 0xA0D37C
	public void Dispose() { }

	// RVA: 0xA0D3B0
	protected override void Finalize() { }

	// RVA: 0xA0D458
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.Ump.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA0D5AC
	public void .ctor() { }

	// RVA: 0xA0BF4C
	internal static extern int GADUGetFormErrorCode(IntPtr error) { }

	// RVA: 0xA0BF50
	internal static extern string GADUGetFormErrorMessage(IntPtr error) { }

	// RVA: 0xA0CAC0
	internal static extern IntPtr GADUCreateRequestParameters() { }

	// RVA: 0xA0CAC4
	internal static extern void GADUSetRequestParametersTagForUnderAgeOfConsent(IntPtr requestParametersRef, bool tagForUnderAgeOfConsent) { }

	// RVA: 0xA0CAC8
	internal static extern IntPtr GADUCreateDebugSettings() { }

	// RVA: 0xA0CACC
	internal static extern void GADUSetDebugSettingsDebugGeography(IntPtr debugSettingsRef, int debugGeography) { }

	// RVA: 0xA0CAD0
	internal static extern void GADUSetDebugSettingsTestDeviceIdentifiers(IntPtr debugSettingsRef, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA0CBAC
	internal static extern void GADUSetRequestParametersDebugSettings(IntPtr requestParametersRef, IntPtr debugSettingsRef) { }

	// RVA: 0xA0C730
	internal static extern IntPtr GADUCreateConsentInformation(IntPtr clientRef) { }

	// RVA: 0xA0CDAC
	internal static extern void GADUResetConsentInformation(IntPtr consentInfoRef) { }

	// RVA: 0xA0CEF0
	internal static extern int GADUGetConsentStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA0D034
	internal static extern int GADUGetPrivacyOptionsRequirementStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA0D168
	internal static extern bool GADUUMPCanRequestAds(IntPtr consentInfoRef) { }

	// RVA: 0xA0D2B4
	internal static extern bool GADUIsConsentFormAvailable(IntPtr consentInfoRef) { }

	// RVA: 0xA0CC54
	internal static extern void GADURequestConsentInfoUpdate(IntPtr clientRef, IntPtr parameters, GADUConsentInfoUpdateCallback callback) { }

	// RVA: 0xA0B444
	internal static extern IntPtr GADUCreateConsentForm(IntPtr clientRef) { }

	// RVA: 0xA0B770
	internal static extern void GADULoadConsentForm(IntPtr formRef, GADUConsentFormLoadCompletionHandler consentFormLoadCallback) { }

	// RVA: 0xA0BA34
	internal static extern void GADUPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA0BC54
	internal static extern void GADULoadAndPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA0BE74
	internal static extern void GADUPresentPrivacyOptionsForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA0C768
	internal static extern void GADURelease(IntPtr obj) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class UmpClientFactory
{
	// Methods

	// RVA: 0xA0D5B4
	public void .ctor() { }

	// RVA: 0xA0D5BC
	public IConsentFormClient ConsentFormClient() { }

	// RVA: 0xA0D768
	public IConsentInformationClient ConsentInformationClient() { }

}


