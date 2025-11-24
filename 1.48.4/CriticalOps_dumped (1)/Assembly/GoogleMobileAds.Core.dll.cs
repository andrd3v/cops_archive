// Namespace: 
internal class <Module> 
{}

// Namespace: GoogleMobileAds.Api
public enum AdChoicesPlacement 
{
	// Fields
	public int value__; // 0x10
	public const AdChoicesPlacement TopRightCorner = 0;
	public const AdChoicesPlacement TopLeftCorner = 1;
	public const AdChoicesPlacement BottomRightCorner = 2;
	public const AdChoicesPlacement BottomLeftCorner = 3;
}

// Namespace: GoogleMobileAds.Api
public enum AdFormat 
{
	// Fields
	public int value__; // 0x10
	public const AdFormat BANNER = 0;
	public const AdFormat INTERSTITIAL = 1;
	public const AdFormat REWARDED = 2;
	public const AdFormat REWARDED_INTERSTITIAL = 3;
	public const AdFormat NATIVE = 4;
	public const AdFormat APP_OPEN_AD = 5;
}

// Namespace: GoogleMobileAds.Api.AdManager
public class AdManagerAdRequest 
{
	// Fields
	public string PublisherProvidedId; // 0x30
	public System.Collections.Generic.HashSet<System.String> CategoryExclusions; // 0x38

	// Methods

	// RVA: 0x9C0110
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public enum AdPosition 
{
	// Fields
	public int value__; // 0x10
	public const AdPosition Top = 0;
	public const AdPosition Bottom = 1;
	public const AdPosition TopLeft = 2;
	public const AdPosition TopRight = 3;
	public const AdPosition BottomLeft = 4;
	public const AdPosition BottomRight = 5;
	public const AdPosition Center = 6;
}

// Namespace: GoogleMobileAds.Api
public class AdRequest 
{
	// Fields
	private static string <Version>k__BackingField; // 0x0
	public System.Collections.Generic.Dictionary<System.String,System.String> CustomTargeting; // 0x10
	public System.Collections.Generic.HashSet<System.String> Keywords; // 0x18
	public System.Collections.Generic.Dictionary<System.String,System.String> Extras; // 0x20
	public System.Collections.Generic.List<GoogleMobileAds.Api.Mediation.MediationExtras> MediationExtras; // 0x28

	// Methods

	// RVA: 0x9C0334
	void .cctor() { }

	// RVA: 0x9C01DC
	void .ctor() { }

	// RVA: 0x9C0510
	string get_Version() { }

	// RVA: 0x9C058C
	void set_Version(string value) { }

	// RVA: 0x9C0600
	string BuildVersionString(string nativePluginVersion) { }

}

// Namespace: GoogleMobileAds.Api
internal enum Orientation 
{
	// Fields
	public int value__; // 0x10
	public const Orientation Current = 0;
	public const Orientation Landscape = 1;
	public const Orientation Portrait = 2;
}

// Namespace: 
public enum Type 
{
	// Fields
	public int value__; // 0x10
	public const Type Standard = 0;
	public const Type SmartBanner = 1;
	public const Type AnchoredAdaptive = 2;
}

// Namespace: GoogleMobileAds.Api
public class AdSize 
{
	// Fields
	private Type _type; // 0x10
	private Orientation _orientation; // 0x14
	private int _width; // 0x18
	private int _height; // 0x1C
	public static readonly AdSize Banner; // 0x0
	public static readonly AdSize MediumRectangle; // 0x8
	public static readonly AdSize IABBanner; // 0x10
	public static readonly AdSize Leaderboard; // 0x18
	public static readonly AdSize SmartBanner; // 0x20
	public static readonly int FullWidth; // 0x28

	// Methods

	// RVA: 0x9C0760
	void .ctor(int width, int height) { }

	// RVA: 0x9C079C
	void .ctor(int width, int height, Type type) { }

	// RVA: 0x9C07DC
	int get_Width() { }

	// RVA: 0x9C07E4
	int get_Height() { }

	// RVA: 0x9C07EC
	Type get_AdType() { }

	// RVA: 0x9C07F4
	Orientation get_Orientation() { }

	// RVA: 0x9C07FC
	bool Equals(object obj) { }

	// RVA: 0x9C08FC
	int GetHashCode() { }

	// RVA: 0x9C0974
	void .cctor() { }

}

// Namespace: 
public enum PrecisionType 
{
	// Fields
	public int value__; // 0x10
	public const PrecisionType Unknown = 0;
	public const PrecisionType Estimated = 1;
	public const PrecisionType PublisherProvided = 2;
	public const PrecisionType Precise = 3;
}

// Namespace: GoogleMobileAds.Api
public class AdValue 
{
	// Fields
	private PrecisionType <Precision>k__BackingField; // 0x10
	private Int64 <Value>k__BackingField; // 0x18
	private string <CurrencyCode>k__BackingField; // 0x20

	// Methods

	// RVA: 0x9C0AD0
	void .ctor() { }

	// RVA: 0x9C0AD8
	void set_Precision(PrecisionType value) { }

	// RVA: 0x9C0AE0
	void set_Value(Int64 value) { }

	// RVA: 0x9C0AE8
	void set_CurrencyCode(string value) { }

}

// Namespace: GoogleMobileAds.Api
public enum AdapterState 
{
	// Fields
	public int value__; // 0x10
	public const AdapterState NotReady = 0;
	public const AdapterState Ready = 1;
}

// Namespace: GoogleMobileAds.Api
public class AdapterStatus 
{
	// Fields
	private AdapterState <InitializationState>k__BackingField; // 0x10
	private string <Description>k__BackingField; // 0x18
	private int <Latency>k__BackingField; // 0x20

	// Methods

	// RVA: 0x9C0AF0
	void .ctor(AdapterState state, string description, int latency) { }

	// RVA: 0x9C0B40
	void set_InitializationState(AdapterState value) { }

	// RVA: 0x9C0B48
	void set_Description(string value) { }

	// RVA: 0x9C0B50
	void set_Latency(int value) { }

}

// Namespace: GoogleMobileAds.Api.AdManager
public class AppEvent 
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private string <Data>k__BackingField; // 0x18

	// Methods

	// RVA: 0x9C0B58
	void .ctor() { }

	// RVA: 0x9C0B60
	void set_Name(string value) { }

	// RVA: 0x9C0B68
	void set_Data(string value) { }

}

// Namespace: GoogleMobileAds.Api
public class MaxAdContentRating 
{
	// Fields
	private string <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9C0B70
	void .ctor(string value) { }

	// RVA: 0x9C0BA4
	MaxAdContentRating ToMaxAdContentRating(string value) { }

	// RVA: 0x9C0C18
	string get_Value() { }

	// RVA: 0x9C0C20
	void set_Value(string value) { }

}

// Namespace: GoogleMobileAds.Api
public enum MediaAspectRatio 
{
	// Fields
	public int value__; // 0x10
	public const MediaAspectRatio Unknown = 0;
	public const MediaAspectRatio Any = 1;
	public const MediaAspectRatio Landscape = 2;
	public const MediaAspectRatio Portrait = 3;
	public const MediaAspectRatio Square = 4;
}

// Namespace: GoogleMobileAds.Api
public class NativeAdOptions 
{
	// Fields
	public MediaAspectRatio MediaAspectRatio; // 0x10
	public AdChoicesPlacement AdChoicesPlacement; // 0x14
	public VideoOptions VideoOptions; // 0x18

	// Methods

	// RVA: 0x9C0C28
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public class NativeTemplateStyle 
{
	// Fields
	public string TemplateId; // 0x10
	public Color MainBackgroundColor; // 0x18
	public NativeTemplateTextStyle PrimaryText; // 0x28
	public NativeTemplateTextStyle SecondaryText; // 0x30
	public NativeTemplateTextStyle TertiaryText; // 0x38
	public NativeTemplateTextStyle CallToActionText; // 0x40
}

// Namespace: GoogleMobileAds.Api
public enum NativeTemplateFontStyle 
{
	// Fields
	public int value__; // 0x10
	public const NativeTemplateFontStyle Normal = 0;
	public const NativeTemplateFontStyle Bold = 1;
	public const NativeTemplateFontStyle Italic = 2;
	public const NativeTemplateFontStyle Monospace = 3;
}

// Namespace: GoogleMobileAds.Api
public class NativeTemplateTextStyle 
{
	// Fields
	private Color <BackgroundColor>k__BackingField; // 0x10
	private Color <TextColor>k__BackingField; // 0x20
	private int <FontSize>k__BackingField; // 0x30
	private NativeTemplateFontStyle <Style>k__BackingField; // 0x34

	// Methods

	// RVA: 0x9C0CD4
	void .ctor() { }

	// RVA: 0x9C0CDC
	Color get_BackgroundColor() { }

	// RVA: 0x9C0CE8
	Color get_TextColor() { }

	// RVA: 0x9C0CF4
	int get_FontSize() { }

	// RVA: 0x9C0CFC
	NativeTemplateFontStyle get_Style() { }

}

// Namespace: GoogleMobileAds.Api
public sealed class PreloadConfiguration 
{
	// Fields
	public string AdUnitId; // 0x10
	public AdFormat Format; // 0x18
	public AdRequest Request; // 0x20
	public UInt32 BufferSize; // 0x28

	// Methods

	// RVA: 0x9C0D04
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public enum PublisherPrivacyPersonalizationState 
{
	// Fields
	public int value__; // 0x10
	public const PublisherPrivacyPersonalizationState Default = 0;
	public const PublisherPrivacyPersonalizationState Enabled = 1;
	public const PublisherPrivacyPersonalizationState Disabled = 2;
}

// Namespace: GoogleMobileAds.Api
public class RequestConfiguration 
{
	// Fields
	public MaxAdContentRating MaxAdContentRating; // 0x10
	public System.Nullable<GoogleMobileAds.Api.TagForChildDirectedTreatment> TagForChildDirectedTreatment; // 0x18
	public System.Nullable<GoogleMobileAds.Api.TagForUnderAgeOfConsent> TagForUnderAgeOfConsent; // 0x20
	public System.Nullable<GoogleMobileAds.Api.PublisherPrivacyPersonalizationState> PublisherPrivacyPersonalizationState; // 0x28
	public System.Collections.Generic.List<System.String> TestDeviceIds; // 0x30
	public System.Nullable<System.Boolean> PublisherFirstPartyIdEnabled; // 0x38

	// Methods

	// RVA: 0x9C0D0C
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public class Reward 
{
	// Fields
	public string Type; // 0x10
	public Double Amount; // 0x18

	// Methods

	// RVA: 0x9C0D98
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public class ServerSideVerificationOptions 
{
	// Fields
	public string UserId; // 0x10
	public string CustomData; // 0x18

	// Methods

	// RVA: 0x9C0E20
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api
public enum TagForChildDirectedTreatment 
{
	// Fields
	public int value__; // 0x10
	public const TagForChildDirectedTreatment Unspecified = 4294967295;
	public const TagForChildDirectedTreatment False = 0;
	public const TagForChildDirectedTreatment True = 1;
}

// Namespace: GoogleMobileAds.Api
public enum TagForUnderAgeOfConsent 
{
	// Fields
	public int value__; // 0x10
	public const TagForUnderAgeOfConsent Unspecified = 4294967295;
	public const TagForUnderAgeOfConsent False = 0;
	public const TagForUnderAgeOfConsent True = 1;
}

// Namespace: GoogleMobileAds.Api
public class VideoOptions 
{
	// Fields
	public bool ClickToExpandRequested; // 0x10
	public bool CustomControlsRequested; // 0x11
	public bool StartMuted; // 0x12

	// Methods

	// RVA: 0x9C0CA8
	void .ctor() { }

}

// Namespace: GoogleMobileAds.Api.Mediation
public abstract class MediationExtras 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,System.String> <Extras>k__BackingField; // 0x10

	// Methods

	// RVA: 0x9C0E28
	System.Collections.Generic.Dictionary<System.String,System.String> get_Extras() { }

	// RVA: 0x2FE360C
	string get_IOSMediationExtraBuilderClassName() { }

}


