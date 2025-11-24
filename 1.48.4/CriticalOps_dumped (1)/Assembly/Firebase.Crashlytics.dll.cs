// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal static class PlatformAccessor 
{
	// Fields
	private static ExceptionHandler _exceptionHandler; // 0x0
	private static Impl _impl; // 0x8
	private static FirebaseApp _app; // 0x10

	// Methods

	// RVA: 0x783294
	void .cctor() { }

	// RVA: 0x78373C
	ExceptionHandler get_ExceptionHandler() { }

	// RVA: 0x782C3C
	Impl get_Impl() { }

	// RVA: 0x7837B8
	FirebaseApp get_App() { }

}

// Namespace: Firebase.Crashlytics
public static class Crashlytics 
{
	// Fields
	private static bool <ReportUncaughtExceptionsAsFatal>k__BackingField; // 0x0

	// Methods

	// RVA: 0x782ACC
	bool get_ReportUncaughtExceptionsAsFatal() { }

	// RVA: 0x782B18
	void set_ReportUncaughtExceptionsAsFatal(bool value) { }

	// RVA: 0x782B70
	bool get_IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x782CB8
	void set_IsCrashlyticsCollectionEnabled(bool value) { }

	// RVA: 0x782D94
	void Initialize() { }

	// RVA: 0x782E40
	void Log(string message) { }

	// RVA: 0x782F1C
	void SetCustomKey(string key, string value) { }

	// RVA: 0x783000
	void SetUserId(string identifier) { }

	// RVA: 0x7830DC
	void LogException(Exception exception) { }

	// RVA: 0x7831B8
	void LogExceptionAsFatal(Exception exception) { }

}

// Namespace: Firebase.Crashlytics
internal class ExceptionHandler 
{
	// Fields
	private bool isRegistered; // 0x10

	// Methods

	// RVA: 0x78354C
	void Register() { }

	// RVA: 0x783834
	void HandleException(object sender, UnhandledExceptionEventArgs eArgs) { }

	// RVA: 0x7839C8
	void HandleLog(string message, string stackTraceString, LogType type) { }

	// RVA: 0x783A98
	string[] getMessageParts(string message) { }

	// RVA: 0x783DA0
	void LogException(LoggedException e) { }

	// RVA: 0x783428
	void .ctor() { }

}

// Namespace: Firebase.Crashlytics
internal class Impl 
{
	// Fields
	private static readonly string LogString; // 0x0
	private static readonly string SetKeyValueString; // 0x8
	private static readonly string SetUserIdentifierString; // 0x10
	private static readonly string LogExceptionString; // 0x18
	private static readonly string LogExceptionAsFatalString; // 0x20
	private static readonly string IsCrashlyticsCollectionEnabledString; // 0x28
	private static readonly string SetCrashlyticsCollectionEnabledString; // 0x30

	// Methods

	// RVA: 0x783434
	Impl Make() { }

	// RVA: 0x7840A4
	bool IsSDKInitialized() { }

	// RVA: 0x7840AC
	void Log(string message) { }

	// RVA: 0x784154
	void SetCustomKey(string key, string value) { }

	// RVA: 0x784204
	void SetUserId(string identifier) { }

	// RVA: 0x7842AC
	void LogException(Exception exception) { }

	// RVA: 0x784354
	void LogExceptionAsFatal(Exception exception) { }

	// RVA: 0x7843FC
	bool IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7844CC
	void SetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x78409C
	void .ctor() { }

	// RVA: 0x7845A8
	void .cctor() { }

}

// Namespace: Firebase.Crashlytics
internal class LoggedException 
{
	// Fields
	private string <Name>k__BackingField; // 0x90
	private string <CustomStackTrace>k__BackingField; // 0x98
	private System.Collections.Generic.Dictionary<System.String,System.String>[] <ParsedStackTrace>k__BackingField; // 0xA0

	// Methods

	// RVA: 0x783C88
	void .ctor(string name, string message, string stackTrace) { }

	// RVA: 0x7838D8
	LoggedException FromException(Exception exception) { }

	// RVA: 0x784A0C
	string get_Name() { }

	// RVA: 0x784A14
	void set_Name(string value) { }

	// RVA: 0x784A1C
	string get_CustomStackTrace() { }

	// RVA: 0x784A24
	void set_CustomStackTrace(string value) { }

	// RVA: 0x784A2C
	System.Collections.Generic.Dictionary<System.String,System.String>[] get_ParsedStackTrace() { }

	// RVA: 0x784A34
	void set_ParsedStackTrace(System.Collections.Generic.Dictionary<System.String,System.String>[] value) { }

}

// Namespace: Firebase.Crashlytics
internal class Metadata 
{
	// Fields
	public string uv; // 0x10
	public bool idb; // 0x18
	public string pt; // 0x20
	public int pc; // 0x28
	public int pf; // 0x2C
	public int sms; // 0x30
	public int gms; // 0x34
	public int gdid; // 0x38
	public int gdvid; // 0x3C
	public string gdn; // 0x40
	public string gdv; // 0x48
	public string gdver; // 0x50
	public GraphicsDeviceType gdt; // 0x58
	public int gsl; // 0x5C
	public int grtc; // 0x60
	public CopyTextureSupport gcts; // 0x64
	public int gmts; // 0x68
	public string ss; // 0x70
	public float sdpi; // 0x78
	public int srr; // 0x7C

	// Methods

	// RVA: 0x784A3C
	void .ctor() { }

}

// Namespace: Firebase.Crashlytics
internal class MetadataBuilder 
{
	// Fields
	public static string METADATA_KEY; // 0x0

	// Methods

	// RVA: 0x784C8C
	string GenerateMetadataJSON() { }

	// RVA: 0x784DD0
	void .cctor() { }

}

// Namespace: Firebase.Crashlytics
internal class StackTraceParser 
{
	// Fields
	private static readonly string FrameArgsRegex; // 0x0
	private static readonly string FrameRegexWithoutFileInfo; // 0x8
	private static readonly string FrameRegexWithFileInfo; // 0x10
	private static readonly string MonoFilenameUnknownString; // 0x18
	private static readonly string[] StringDelimiters; // 0x20

	// Methods

	// RVA: 0x784728
	System.Collections.Generic.Dictionary<System.String,System.String>[] ParseStackTraceString(string stackTrace) { }

	// RVA: 0x784E48
	System.Collections.Generic.Dictionary<System.String,System.String> ParseFrameString(string regex, string frameString) { }

	// RVA: 0x785260
	void .cctor() { }

}

// Namespace: Firebase.Crashlytics
internal struct Frame 
{
	// Fields
	public string library; // 0x10
	public string symbol; // 0x18
	public string fileName; // 0x20
	public string lineNumber; // 0x28
}

// Namespace: Firebase.Crashlytics
internal class AndroidImpl 
{
	// Methods

	// RVA: 0x784014
	void .ctor() { }

}

// Namespace: Firebase.Crashlytics
internal class IOSImpl 
{
	// Methods

	// RVA: 0x7853F4
	bool CLUIsInitialized() { }

	// RVA: 0x785410
	void CLULog(string msg) { }

	// RVA: 0x785438
	void CLUSetKeyValue(string key, string value) { }

	// RVA: 0x785480
	void CLUSetInternalKeyValue(string key, string value) { }

	// RVA: 0x7854C8
	void CLUSetUserIdentifier(string identifier) { }

	// RVA: 0x7854F0
	void CLUSetDevelopmentPlatform(string name, string version) { }

	// RVA: 0x785538
	void CLURecordCustomException(string name, string reason, Frame[] frames, int frameCount, bool isOnDemand) { }

	// RVA: 0x7856CC
	bool CLUIsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7856E8
	void CLUSetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x783ECC
	void .ctor() { }

	// RVA: 0x7856EC
	bool IsSDKInitialized() { }

	// RVA: 0x785708
	void Log(string message) { }

	// RVA: 0x785734
	void SetCustomKey(string key, string value) { }

	// RVA: 0x785780
	void SetUserId(string identifier) { }

	// RVA: 0x7857AC
	void LogException(Exception exception) { }

	// RVA: 0x785B30
	void LogExceptionAsFatal(Exception exception) { }

	// RVA: 0x785B50
	bool IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x785B6C
	void SetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7857CC
	void RecordCustomException(LoggedException loggedException, bool isOnDemand) { }

}


