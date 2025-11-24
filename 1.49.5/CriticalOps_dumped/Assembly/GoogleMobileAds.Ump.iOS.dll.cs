// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class GADUConsentFormLoadCompletionHandler
{
	// Methods

	// RVA: 0xA1A94C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1B3E4
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1B3F8
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA1B4C4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
internal sealed class GADUConsentFormPresentCompletionHandler
{
	// Methods

	// RVA: 0xA1AC10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1B4D0
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1B4E4
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA1B5B0
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

	// RVA: 0xA1A5FC
	private void .ctor() { }

	// RVA: 0xA1A6C8
	public static ConsentFormClient get_Instance() { }

	// RVA: 0xA1A744
	public void Load(Action onFormLoaded, System.Action<GoogleMobileAds.Ump.Api.FormError> onError) { }

	// RVA: 0xA1AA1C
	public void Show(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA1ACE0
	public void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA1AF00
	public void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA1A008
	internal static void ConsentFormLoadCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1A328
	internal static void ConsentFormPresentCompletionHandler(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1B120
	private static ConsentFormClient IntPtrToConsentFormClient(IntPtr clientRef) { }

	// RVA: 0xA1B204
	public void Dispose() { }

	// RVA: 0xA1B238
	protected override void Finalize() { }

	// RVA: 0xA1B2E0
	private static void .cctor() { }

}

// Namespace: 
internal sealed class GADUConsentInfoUpdateCallback
{
	// Methods

	// RVA: 0xA1BE30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1C740
	public virtual void Invoke(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1C754
	public virtual IAsyncResult BeginInvoke(IntPtr clientRef, IntPtr errorRef, AsyncCallback callback, object object) { }

	// RVA: 0xA1C820
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

	// RVA: 0xA1B8DC
	private void .ctor() { }

	// RVA: 0xA1B9E0
	private IntPtr get_ConsentInformationPtr() { }

	// RVA: 0xA1B9B4
	private void set_ConsentInformationPtr(IntPtr value) { }

	// RVA: 0xA1B9EC
	public static ConsentInformationClient get_Instance() { }

	// RVA: 0xA1BA68
	public void Update(ConsentRequestParameters request, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0xA1BF08
	public void Reset() { }

	// RVA: 0xA1C030
	public int GetConsentStatus() { }

	// RVA: 0xA1C174
	public int GetPrivacyOptionsRequirementStatus() { }

	// RVA: 0xA1C2B8
	public bool CanRequestAds() { }

	// RVA: 0xA1C404
	public bool IsConsentFormAvailable() { }

	// RVA: 0xA1B5BC
	internal static void ConsentInfoUpdateCallback(IntPtr clientRef, IntPtr errorRef) { }

	// RVA: 0xA1C550
	private static ConsentInformationClient IntPtrToConsentInformationClient(IntPtr clientRef) { }

	// RVA: 0xA1C5FC
	public void Dispose() { }

	// RVA: 0xA1C630
	protected override void Finalize() { }

	// RVA: 0xA1C6D8
	private static void .cctor() { }

}

// Namespace: GoogleMobileAds.Ump.iOS
internal class Externs
{
	// Methods

	// RVA: 0xA1C82C
	public void .ctor() { }

	// RVA: 0xA1B1CC
	internal static extern int GADUGetFormErrorCode(IntPtr error) { }

	// RVA: 0xA1B1D0
	internal static extern string GADUGetFormErrorMessage(IntPtr error) { }

	// RVA: 0xA1BD40
	internal static extern IntPtr GADUCreateRequestParameters() { }

	// RVA: 0xA1BD44
	internal static extern void GADUSetRequestParametersTagForUnderAgeOfConsent(IntPtr requestParametersRef, bool tagForUnderAgeOfConsent) { }

	// RVA: 0xA1BD48
	internal static extern IntPtr GADUCreateDebugSettings() { }

	// RVA: 0xA1BD4C
	internal static extern void GADUSetDebugSettingsDebugGeography(IntPtr debugSettingsRef, int debugGeography) { }

	// RVA: 0xA1BD50
	internal static extern void GADUSetDebugSettingsTestDeviceIdentifiers(IntPtr debugSettingsRef, string[] testDeviceIDs, int testDeviceIDLength) { }

	// RVA: 0xA1BE2C
	internal static extern void GADUSetRequestParametersDebugSettings(IntPtr requestParametersRef, IntPtr debugSettingsRef) { }

	// RVA: 0xA1B9B0
	internal static extern IntPtr GADUCreateConsentInformation(IntPtr clientRef) { }

	// RVA: 0xA1C02C
	internal static extern void GADUResetConsentInformation(IntPtr consentInfoRef) { }

	// RVA: 0xA1C170
	internal static extern int GADUGetConsentStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA1C2B4
	internal static extern int GADUGetPrivacyOptionsRequirementStatus(IntPtr consentInfoRef) { }

	// RVA: 0xA1C3E8
	internal static extern bool GADUUMPCanRequestAds(IntPtr consentInfoRef) { }

	// RVA: 0xA1C534
	internal static extern bool GADUIsConsentFormAvailable(IntPtr consentInfoRef) { }

	// RVA: 0xA1BED4
	internal static extern void GADURequestConsentInfoUpdate(IntPtr clientRef, IntPtr parameters, GADUConsentInfoUpdateCallback callback) { }

	// RVA: 0xA1A6C4
	internal static extern IntPtr GADUCreateConsentForm(IntPtr clientRef) { }

	// RVA: 0xA1A9F0
	internal static extern void GADULoadConsentForm(IntPtr formRef, GADUConsentFormLoadCompletionHandler consentFormLoadCallback) { }

	// RVA: 0xA1ACB4
	internal static extern void GADUPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA1AED4
	internal static extern void GADULoadAndPresentConsentForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA1B0F4
	internal static extern void GADUPresentPrivacyOptionsForm(IntPtr formRef, GADUConsentFormPresentCompletionHandler consentFormPresentCallback) { }

	// RVA: 0xA1B9E8
	internal static extern void GADURelease(IntPtr obj) { }

}

// Namespace: GoogleMobileAds.Ump.iOS
public class UmpClientFactory
{
	// Methods

	// RVA: 0xA1C834
	public void .ctor() { }

	// RVA: 0xA1C83C
	public IConsentFormClient ConsentFormClient() { }

	// RVA: 0xA1C9E8
	public IConsentInformationClient ConsentInformationClient() { }

}


