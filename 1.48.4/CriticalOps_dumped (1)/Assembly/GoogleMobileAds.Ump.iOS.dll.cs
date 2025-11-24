// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal sealed class GADUConsentFormLoadCompletionHandler 
{
	// Methods

	// RVA: 0x9E2DF0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E3888
	internal void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E389C
	internal IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0x9E3968
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUConsentFormPresentCompletionHandler 
{
	// Methods

	// RVA: 0x9E30B4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E3974
	internal void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E3988
	internal IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0x9E3A54
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x9E2AA0
	void .ctor() { }

	// RVA: 0x9E2B6C
	ConsentFormClient get_Instance() { }

	// RVA: 0x9E2BE8
	void Load(Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError) { }

	// RVA: 0x9E2EC0
	void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0x9E3184
	void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0x9E33A4
	void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0x9E24AC
	void ConsentFormLoadCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E27CC
	void ConsentFormPresentCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E35C4
	ConsentFormClient IntPtrToConsentFormClient(IntPtr clientRef) { }

	// RVA: 0x9E36A8
	void Dispose() { }

	// RVA: 0x9E36DC
	void Finalize() { }

	// RVA: 0x9E3784
	void .cctor() { }

}

// Namespace: 
internal sealed class GADUConsentInfoUpdateCallback 
{
	// Methods

	// RVA: 0x9E42D4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x9E4BE4
	internal void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E4BF8
	internal IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0x9E4CC4
	internal void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x9E3D80
	void .ctor() { }

	// RVA: 0x9E3E84
	IntPtr get_ConsentInformationPtr() { }

	// RVA: 0x9E3E58
	void set_ConsentInformationPtr(IntPtr value) { }

	// RVA: 0x9E3E90
	ConsentInformationClient get_Instance() { }

	// RVA: 0x9E3F0C
	void Update(ConsentRequestParameters request, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0x9E43AC
	void Reset() { }

	// RVA: 0x9E44D4
	int GetConsentStatus() { }

	// RVA: 0x9E4618
	int GetPrivacyOptionsRequirementStatus() { }

	// RVA: 0x9E475C
	bool CanRequestAds() { }

	// RVA: 0x9E48A8
	bool IsConsentFormAvailable() { }

	// RVA: 0x9E3A60
	void ConsentInfoUpdateCallback(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0x9E49F4
	ConsentInformationClient IntPtrToConsentInformationClient(IntPtr clientRef) { }

	// RVA: 0x9E4AA0
	void Dispose() { }

	// RVA: 0x9E4AD4
	void Finalize() { }

	// RVA: 0x9E4B7C
	void .cctor() { }

}

// Namespace: GoogleMobileAds.Ump.iOS
internal class Externs 
{
	// Methods

	// RVA: 0x9E4CD0
	void .ctor() { }

	// RVA: 0x9E3670
	int GADUGetFormErrorCode(IntPtr error) { }

	// RVA: 0x9E3674
	string GADUGetFormErrorMessage(IntPtr error) { }

	// RVA: 0x9E41E4
	IntPtr GADUCreateRequestParameters() { }

	// RVA: 0x9E41E8
	void GADUSetRequestParametersTagForUnderAgeOfConsent(IntPtr requestParametersRef, bool tagForUnderAgeOfConsent) { }

	// RVA: 0x9E41EC
	IntPtr GADUCreateDebugSettings() { }

	// RVA: 0x9E41F0
	void GADUSetDebugSettingsDebugGeography(IntPtr debugSettingsRef, int debugGeography) { }

	// RVA: 0x9E41F4
	void GADUSetDebugSettingsTestDeviceIdentifiers(IntPtr debugSettingsRef, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0x9E42D0
	void GADUSetRequestParametersDebugSettings(IntPtr requestParametersRef, IntPtr debugSettingsRef) { }

	// RVA: 0x9E3E54
	IntPtr GADUCreateConsentInformation(IntPtr clientRef) { }

	// RVA: 0x9E44D0
	void GADUResetConsentInformation(IntPtr consentInfoRef) { }

	// RVA: 0x9E4614
	int GADUGetConsentStatus(IntPtr consentInfoRef) { }

	// RVA: 0x9E4758
	int GADUGetPrivacyOptionsRequirementStatus(IntPtr consentInfoRef) { }

	// RVA: 0x9E488C
	bool GADUUMPCanRequestAds(IntPtr consentInfoRef) { }

	// RVA: 0x9E49D8
	bool GADUIsConsentFormAvailable(IntPtr consentInfoRef) { }

	// RVA: 0x9E4378
	void GADURequestConsentInfoUpdate(IntPtr clientRef, IntPtr parameters, GADUConsentInfoUpdateCallback callback) { }

	// RVA: 0x9E2B68
	IntPtr GADUCreateConsentForm(IntPtr clientRef) { }

	// RVA: 0x9E2E94
	void GADULoadConsentForm(IntPtr formRef, GADUConsentFormLoadCompletionHandler consentFormLoadCallback) { }

	// RVA: 0x9E3158
	void GADUPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0x9E3378
	void GADULoadAndPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0x9E3598
	void GADUPresentPrivacyOptionsForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0x9E3E8C
	void GADURelease(IntPtr obj) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class UmpClientFactory 
{
	// Methods

	// RVA: 0x9E4CD8
	void .ctor() { }

	// RVA: 0x9E4CE0
	IConsentFormClient ConsentFormClient() { }

	// RVA: 0x9E4E8C
	IConsentInformationClient ConsentInformationClient() { }

}


