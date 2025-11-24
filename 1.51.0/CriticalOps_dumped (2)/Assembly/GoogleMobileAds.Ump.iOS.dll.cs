// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class GADUConsentFormLoadCompletionHandler
{
	// Methods

	// RVA: 0xA7CA3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA7D528
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7D53C
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA7D5E0
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUConsentFormPresentCompletionHandler
{
	// Methods

	// RVA: 0xA7CD00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA7D5EC
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7D600
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA7D6A4
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

	// RVA: 0xA7C6EC
	private void .ctor() { }

	// RVA: 0xA7C7B8
	public static ConsentFormClient get_Instance() { }

	// RVA: 0xA7C834
	public void Load(Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError) { }

	// RVA: 0xA7CB0C
	public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA7CDD0
	public void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA7CFF0
	public void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA7C044
	internal static void ConsentFormLoadCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7C3B4
	internal static void ConsentFormPresentCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7D210
	private static ConsentFormClient IntPtrToConsentFormClient(IntPtr clientRef) { }

	// RVA: 0xA7D348
	public void Dispose() { }

	// RVA: 0xA7D37C
	protected override void Finalize() { }

	// RVA: 0xA7D424
	private static void .cctor() { }

}

// Namespace: 
internal sealed class GADUConsentInfoUpdateCallback
{
	// Methods

	// RVA: 0xA7DF74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA7E8D8
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7E8EC
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA7E990
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

	// RVA: 0xA7DA20
	private void .ctor() { }

	// RVA: 0xA7DB24
	private IntPtr get_ConsentInformationPtr() { }

	// RVA: 0xA7DAF8
	private void set_ConsentInformationPtr(IntPtr value) { }

	// RVA: 0xA7DB30
	public static ConsentInformationClient get_Instance() { }

	// RVA: 0xA7DBAC
	public void Update(ConsentRequestParameters request, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0xA7E04C
	public void Reset() { }

	// RVA: 0xA7E174
	public int GetConsentStatus() { }

	// RVA: 0xA7E2B8
	public int GetPrivacyOptionsRequirementStatus() { }

	// RVA: 0xA7E3FC
	public bool CanRequestAds() { }

	// RVA: 0xA7E548
	public bool IsConsentFormAvailable() { }

	// RVA: 0xA7D6B0
	internal static void ConsentInfoUpdateCallback(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA7E694
	private static ConsentInformationClient IntPtrToConsentInformationClient(IntPtr clientRef) { }

	// RVA: 0xA7E794
	public void Dispose() { }

	// RVA: 0xA7E7C8
	protected override void Finalize() { }

	// RVA: 0xA7E870
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.Ump.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA7E99C
	public void .ctor() { }

	// RVA: 0xA7D310
	internal static extern int GADUGetFormErrorCode(IntPtr error) { }

	// RVA: 0xA7D314
	internal static extern string GADUGetFormErrorMessage(IntPtr error) { }

	// RVA: 0xA7DE84
	internal static extern IntPtr GADUCreateRequestParameters() { }

	// RVA: 0xA7DE88
	internal static extern void GADUSetRequestParametersTagForUnderAgeOfConsent(IntPtr requestParametersRef, bool tagForUnderAgeOfConsent) { }

	// RVA: 0xA7DE8C
	internal static extern IntPtr GADUCreateDebugSettings() { }

	// RVA: 0xA7DE90
	internal static extern void GADUSetDebugSettingsDebugGeography(IntPtr debugSettingsRef, int debugGeography) { }

	// RVA: 0xA7DE94
	internal static extern void GADUSetDebugSettingsTestDeviceIdentifiers(IntPtr debugSettingsRef, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA7DF70
	internal static extern void GADUSetRequestParametersDebugSettings(IntPtr requestParametersRef, IntPtr debugSettingsRef) { }

	// RVA: 0xA7DAF4
	internal static extern IntPtr GADUCreateConsentInformation(IntPtr clientRef) { }

	// RVA: 0xA7E170
	internal static extern void GADUResetConsentInformation(IntPtr consentInfoRef) { }

	// RVA: 0xA7E2B4
	internal static extern int GADUGetConsentStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA7E3F8
	internal static extern int GADUGetPrivacyOptionsRequirementStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA7E52C
	internal static extern bool GADUUMPCanRequestAds(IntPtr consentInfoRef) { }

	// RVA: 0xA7E678
	internal static extern bool GADUIsConsentFormAvailable(IntPtr consentInfoRef) { }

	// RVA: 0xA7E018
	internal static extern void GADURequestConsentInfoUpdate(IntPtr clientRef, IntPtr parameters, GADUConsentInfoUpdateCallback callback) { }

	// RVA: 0xA7C7B4
	internal static extern IntPtr GADUCreateConsentForm(IntPtr clientRef) { }

	// RVA: 0xA7CAE0
	internal static extern void GADULoadConsentForm(IntPtr formRef, GADUConsentFormLoadCompletionHandler consentFormLoadCallback) { }

	// RVA: 0xA7CDA4
	internal static extern void GADUPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA7CFC4
	internal static extern void GADULoadAndPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA7D1E4
	internal static extern void GADUPresentPrivacyOptionsForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA7DB2C
	internal static extern void GADURelease(IntPtr obj) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class UmpClientFactory
{
	// Methods

	// RVA: 0xA7E9A4
	public void .ctor() { }

	// RVA: 0xA7E9AC
	public IConsentFormClient ConsentFormClient() { }

	// RVA: 0xA7EB58
	public IConsentInformationClient ConsentInformationClient() { }

}


