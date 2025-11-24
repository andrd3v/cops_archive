// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class GADUConsentFormLoadCompletionHandler
{
	// Methods

	// RVA: 0xA339B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA34448
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA3445C
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA34528
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUConsentFormPresentCompletionHandler
{
	// Methods

	// RVA: 0xA33C74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA34534
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA34548
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA34614
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

	// RVA: 0xA33660
	private void .ctor() { }

	// RVA: 0xA3372C
	public static ConsentFormClient get_Instance() { }

	// RVA: 0xA337A8
	public void Load(Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError) { }

	// RVA: 0xA33A80
	public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA33D44
	public void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA33F64
	public void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA3306C
	internal static void ConsentFormLoadCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA3338C
	internal static void ConsentFormPresentCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA34184
	private static ConsentFormClient IntPtrToConsentFormClient(IntPtr clientRef) { }

	// RVA: 0xA34268
	public void Dispose() { }

	// RVA: 0xA3429C
	protected override void Finalize() { }

	// RVA: 0xA34344
	private static void .cctor() { }

}

// Namespace: 
internal sealed class GADUConsentInfoUpdateCallback
{
	// Methods

	// RVA: 0xA34E94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA357A4
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA357B8
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA35884
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

	// RVA: 0xA34940
	private void .ctor() { }

	// RVA: 0xA34A44
	private IntPtr get_ConsentInformationPtr() { }

	// RVA: 0xA34A18
	private void set_ConsentInformationPtr(IntPtr value) { }

	// RVA: 0xA34A50
	public static ConsentInformationClient get_Instance() { }

	// RVA: 0xA34ACC
	public void Update(ConsentRequestParameters request, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0xA34F6C
	public void Reset() { }

	// RVA: 0xA35094
	public int GetConsentStatus() { }

	// RVA: 0xA351D8
	public int GetPrivacyOptionsRequirementStatus() { }

	// RVA: 0xA3531C
	public bool CanRequestAds() { }

	// RVA: 0xA35468
	public bool IsConsentFormAvailable() { }

	// RVA: 0xA34620
	internal static void ConsentInfoUpdateCallback(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA355B4
	private static ConsentInformationClient IntPtrToConsentInformationClient(IntPtr clientRef) { }

	// RVA: 0xA35660
	public void Dispose() { }

	// RVA: 0xA35694
	protected override void Finalize() { }

	// RVA: 0xA3573C
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.Ump.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA35890
	public void .ctor() { }

	// RVA: 0xA34230
	internal static extern int GADUGetFormErrorCode(IntPtr error) { }

	// RVA: 0xA34234
	internal static extern string GADUGetFormErrorMessage(IntPtr error) { }

	// RVA: 0xA34DA4
	internal static extern IntPtr GADUCreateRequestParameters() { }

	// RVA: 0xA34DA8
	internal static extern void GADUSetRequestParametersTagForUnderAgeOfConsent(IntPtr requestParametersRef, bool tagForUnderAgeOfConsent) { }

	// RVA: 0xA34DAC
	internal static extern IntPtr GADUCreateDebugSettings() { }

	// RVA: 0xA34DB0
	internal static extern void GADUSetDebugSettingsDebugGeography(IntPtr debugSettingsRef, int debugGeography) { }

	// RVA: 0xA34DB4
	internal static extern void GADUSetDebugSettingsTestDeviceIdentifiers(IntPtr debugSettingsRef, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA34E90
	internal static extern void GADUSetRequestParametersDebugSettings(IntPtr requestParametersRef, IntPtr debugSettingsRef) { }

	// RVA: 0xA34A14
	internal static extern IntPtr GADUCreateConsentInformation(IntPtr clientRef) { }

	// RVA: 0xA35090
	internal static extern void GADUResetConsentInformation(IntPtr consentInfoRef) { }

	// RVA: 0xA351D4
	internal static extern int GADUGetConsentStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA35318
	internal static extern int GADUGetPrivacyOptionsRequirementStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA3544C
	internal static extern bool GADUUMPCanRequestAds(IntPtr consentInfoRef) { }

	// RVA: 0xA35598
	internal static extern bool GADUIsConsentFormAvailable(IntPtr consentInfoRef) { }

	// RVA: 0xA34F38
	internal static extern void GADURequestConsentInfoUpdate(IntPtr clientRef, IntPtr parameters, GADUConsentInfoUpdateCallback callback) { }

	// RVA: 0xA33728
	internal static extern IntPtr GADUCreateConsentForm(IntPtr clientRef) { }

	// RVA: 0xA33A54
	internal static extern void GADULoadConsentForm(IntPtr formRef, GADUConsentFormLoadCompletionHandler consentFormLoadCallback) { }

	// RVA: 0xA33D18
	internal static extern void GADUPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA33F38
	internal static extern void GADULoadAndPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA34158
	internal static extern void GADUPresentPrivacyOptionsForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA34A4C
	internal static extern void GADURelease(IntPtr obj) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class UmpClientFactory
{
	// Methods

	// RVA: 0xA35898
	public void .ctor() { }

	// RVA: 0xA358A0
	public IConsentFormClient ConsentFormClient() { }

	// RVA: 0xA35A4C
	public IConsentInformationClient ConsentInformationClient() { }

}


