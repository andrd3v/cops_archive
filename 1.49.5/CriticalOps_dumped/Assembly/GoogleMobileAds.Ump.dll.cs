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

	// RVA: 0xA192A8
	public void .ctor() { }

	// RVA: 0xA192B0
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <LoadAndShowConsentFormIfRequired>c__AnonStorey4
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0xA18ECC
	public void .ctor() { }

	// RVA: 0xA1917C
	internal void <>m__0(FormError error) { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey7
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6 <>f__ref$6; // 0x18

	// Methods

	// RVA: 0xA19410
	public void .ctor() { }

	// RVA: 0xA19418
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey6
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0xA19174
	public void .ctor() { }

	// RVA: 0xA192E4
	internal void <>m__0(FormError error) { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentForm
{
	// Methods

	// RVA: 0xA18CC8
	public static void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA18F6C
	public static void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey1
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0 <>f__ref$0; // 0x18

	// Methods

	// RVA: 0xA19DCC
	public void .ctor() { }

	// RVA: 0xA19E00
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey0
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback; // 0x10

	// Methods

	// RVA: 0xA19BC0
	public void .ctor() { }

	// RVA: 0xA19BC8
	internal void <>m__0() { }

	// RVA: 0xA19CA0
	internal void <>m__1(FormError error) { }

	// RVA: 0xA19DD4
	internal void <>m__2() { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentInformation
{
	// Fields
	private static IUmpClientFactory _clientFactory; // 0x0

	// Methods

	// RVA: 0xA18ED4
	internal static IUmpClientFactory get_ClientFactory() { }

	// RVA: 0xA195D8
	public static ConsentStatus get_ConsentStatus() { }

	// RVA: 0xA19798
	public static PrivacyOptionsRequirementStatus get_PrivacyOptionsRequirementStatus() { }

	// RVA: 0xA19958
	public static void Update(ConsentRequestParameters request, System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback) { }

}

// Namespace: GoogleMobileAds.Ump.Api
[Serializable]
public class ConsentDebugSettings
{
	// Fields
	public DebugGeography DebugGeography; // 0x10
	public System.Collections.Generic.List<System.String> TestDeviceHashedIds; // 0x18

	// Methods

	// RVA: 0xA19E34
	public void .ctor() { }

}

// Namespace: GoogleMobileAds.Ump.Api
[Serializable]
public class ConsentRequestParameters
{
	// Fields
	public bool TagForUnderAgeOfConsent; // 0x10
	public ConsentDebugSettings ConsentDebugSettings; // 0x18

	// Methods

	// RVA: 0xA19EC0
	public void .ctor() { }

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
}

// Namespace: GoogleMobileAds.Ump.Api
public class FormError
{
	// Fields
	private int <ErrorCode>k__BackingField; // 0x10
	private string <Message>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA19FA4
	internal void .ctor(int errorCode, string message) { }

	// RVA: 0xA19FE8
	public int get_ErrorCode() { }

	// RVA: 0xA19FF0
	private void set_ErrorCode(int value) { }

	// RVA: 0xA19FF8
	public string get_Message() { }

	// RVA: 0xA1A000
	private void set_Message(string value) { }

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

	// RVA: 0xA1944C
	internal static IUmpClientFactory GetClientFactory() { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IConsentFormClient
{
	// Methods

	// RVA: -1
	public abstract void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: -1
	public abstract void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IConsentInformationClient
{
	// Methods

	// RVA: -1
	public abstract void Update(ConsentRequestParameters consentRequestParameters, Action onConsentInfoUpdateSuccessCallback, System.Action<GoogleMobileAds.Ump.Api.FormError> onConsentInfoUpdateFailureCallback) { }

	// RVA: -1
	public abstract int GetConsentStatus() { }

	// RVA: -1
	public abstract int GetPrivacyOptionsRequirementStatus() { }

}

// Namespace: GoogleMobileAds.Ump.Common
public interface IUmpClientFactory
{
	// Methods

	// RVA: -1
	public abstract IConsentFormClient ConsentFormClient() { }

	// RVA: -1
	public abstract IConsentInformationClient ConsentInformationClient() { }

}


