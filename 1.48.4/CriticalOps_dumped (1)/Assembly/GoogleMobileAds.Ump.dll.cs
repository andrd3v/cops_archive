// Namespace: 
internal class <Module> 
{}

// Namespace: 
private sealed class <LoadAndShowConsentFormIfRequired>c__AnonStorey5 
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentForm.<LoadAndShowConsentFormIfRequired>c__AnonStorey4 <>f__ref$4; // 0x18

	// Methods

	// RVA: 0x9E174C
	void .ctor() { }

	// RVA: 0x9E1754
	void <>m__0() { }

}

// Namespace: 
private sealed class <LoadAndShowConsentFormIfRequired>c__AnonStorey4 
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0x9E1370
	void .ctor() { }

	// RVA: 0x9E1620
	void <>m__0(FormError error) { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey7 
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6 <>f__ref$6; // 0x18

	// Methods

	// RVA: 0x9E18B4
	void .ctor() { }

	// RVA: 0x9E18BC
	void <>m__0() { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey6 
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0x9E1618
	void .ctor() { }

	// RVA: 0x9E1788
	void <>m__0(FormError error) { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentForm 
{
	// Methods

	// RVA: 0x9E116C
	void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0x9E1410
	void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey1 
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0 <>f__ref$0; // 0x18

	// Methods

	// RVA: 0x9E2270
	void .ctor() { }

	// RVA: 0x9E22A4
	void <>m__0() { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey0 
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback; // 0x10

	// Methods

	// RVA: 0x9E2064
	void .ctor() { }

	// RVA: 0x9E206C
	void <>m__0() { }

	// RVA: 0x9E2144
	void <>m__1(FormError error) { }

	// RVA: 0x9E2278
	void <>m__2() { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentInformation 
{
	// Fields
	private static IUmpClientFactory _clientFactory; // 0x0

	// Methods

	// RVA: 0x9E1378
	IUmpClientFactory get_ClientFactory() { }

	// RVA: 0x9E1A7C
	ConsentStatus get_ConsentStatus() { }

	// RVA: 0x9E1C3C
	PrivacyOptionsRequirementStatus get_PrivacyOptionsRequirementStatus() { }

	// RVA: 0x9E1DFC
	void Update(ConsentRequestParameters request, System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback) { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentDebugSettings 
{
	// Fields
	public DebugGeography DebugGeography; // 0x10
	public System.Collections.Generic.List<System.String> TestDeviceHashedIds; // 0x18

	// Methods

	// RVA: 0x9E22D8
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentRequestParameters 
{
	// Fields
	public bool TagForUnderAgeOfConsent; // 0x10
	public ConsentDebugSettings ConsentDebugSettings; // 0x18

	// Methods

	// RVA: 0x9E2364
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Ump.Api
public enum ConsentStatus 
{
	// Fields
	public int value__; // 0x10
	public const ConsentStatus Unknown = 0;
	public const ConsentStatus NotRequired = 1;
	public const ConsentStatus Required = 2;
	public const ConsentStatus Obtained = 3;
}

// Namespace: GoogleMobileAds.Ump.Api
public enum DebugGeography 
{
	// Fields
	public int value__; // 0x10
	public const DebugGeography Disabled = 0;
	public const DebugGeography EEA = 1;
	public const DebugGeography NotEEA = 2;
	public const DebugGeography RegulatedUSState = 3;
	public const DebugGeography Other = 4;
}

// Namespace: GoogleMobileAds.Ump.Api
public class FormError 
{
	// Fields
	private int <ErrorCode>k__BackingField; // 0x10
	private string <Message>k__BackingField; // 0x18

	// Methods

	// RVA: 0x9E2448
	void .ctor(int errorCode, string message) { }

	// RVA: 0x9E248C
	int get_ErrorCode() { }

	// RVA: 0x9E2494
	void set_ErrorCode(int value) { }

	// RVA: 0x9E249C
	string get_Message() { }

	// RVA: 0x9E24A4
	void set_Message(string value) { }

}

// Namespace: GoogleMobileAds.Ump.Api
public enum PrivacyOptionsRequirementStatus 
{
	// Fields
	public int value__; // 0x10
	public const PrivacyOptionsRequirementStatus Unknown = 0;
	public const PrivacyOptionsRequirementStatus NotRequired = 1;
	public const PrivacyOptionsRequirementStatus Required = 2;
}

// Namespace: GoogleMobileAds.Ump.Api
internal class Utils 
{
	// Methods

	// RVA: 0x9E18F0
	IUmpClientFactory GetClientFactory() { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IConsentFormClient 
{
	// Methods

	// RVA: 0x2FE4574
	void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0x2FE4574
	void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IConsentInformationClient 
{
	// Methods

	// RVA: 0x2FE49A8
	void Update(ConsentRequestParameters consentRequestParameters, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: 0x2FE32D4
	int GetConsentStatus() { }

	// RVA: 0x2FE32D4
	int GetPrivacyOptionsRequirementStatus() { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IUmpClientFactory 
{
	// Methods

	// RVA: 0x2FE360C
	IConsentFormClient ConsentFormClient() { }

	// RVA: 0x2FE360C
	IConsentInformationClient ConsentInformationClient() { }

}


