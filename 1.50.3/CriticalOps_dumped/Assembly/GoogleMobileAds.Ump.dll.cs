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

	// RVA: 0xA3230C
	public void .ctor() { }

	// RVA: 0xA32314
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <LoadAndShowConsentFormIfRequired>c__AnonStorey4
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0xA31F30
	public void .ctor() { }

	// RVA: 0xA321E0
	internal void <>m__0(FormError error) { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey7
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentForm.<ShowPrivacyOptionsForm>c__AnonStorey6 <>f__ref$6; // 0x18

	// Methods

	// RVA: 0xA32474
	public void .ctor() { }

	// RVA: 0xA3247C
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <ShowPrivacyOptionsForm>c__AnonStorey6
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed; // 0x10

	// Methods

	// RVA: 0xA321D8
	public void .ctor() { }

	// RVA: 0xA32348
	internal void <>m__0(FormError error) { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentForm
{
	// Methods

	// RVA: 0xA31D2C
	public static void LoadAndShowConsentFormIfRequired(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

	// RVA: 0xA31FD0
	public static void ShowPrivacyOptionsForm(System.Action<GoogleMobileAds.Ump.Api.FormError> onDismissed) { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey1
{
	// Fields
	internal FormError error; // 0x10
	internal GoogleMobileAds.Ump.Api.ConsentInformation.<Update>c__AnonStorey0 <>f__ref$0; // 0x18

	// Methods

	// RVA: 0xA32E30
	public void .ctor() { }

	// RVA: 0xA32E64
	internal void <>m__0() { }

}

// Namespace: 
private sealed class <Update>c__AnonStorey0
{
	// Fields
	internal System.Action<GoogleMobileAds.Ump.Api.FormError> consentInfoUpdateCallback; // 0x10

	// Methods

	// RVA: 0xA32C24
	public void .ctor() { }

	// RVA: 0xA32C2C
	internal void <>m__0() { }

	// RVA: 0xA32D04
	internal void <>m__1(FormError error) { }

	// RVA: 0xA32E38
	internal void <>m__2() { }

}

// Namespace: GoogleMobileAds.Ump.Api
public class ConsentInformation
{
	// Fields
	private static IUmpClientFactory _clientFactory; // 0x0

	// Methods

	// RVA: 0xA31F38
	internal static IUmpClientFactory get_ClientFactory() { }

	// RVA: 0xA3263C
	public static ConsentStatus get_ConsentStatus() { }

	// RVA: 0xA327FC
	public static PrivacyOptionsRequirementStatus get_PrivacyOptionsRequirementStatus() { }

	// RVA: 0xA329BC
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

	// RVA: 0xA32E98
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

	// RVA: 0xA32F24
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

	// RVA: 0xA33008
	internal void .ctor(int errorCode, string message) { }

	// RVA: 0xA3304C
	public int get_ErrorCode() { }

	// RVA: 0xA33054
	private void set_ErrorCode(int value) { }

	// RVA: 0xA3305C
	public string get_Message() { }

	// RVA: 0xA33064
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

	// RVA: 0xA324B0
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


