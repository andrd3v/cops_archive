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

	// RVA: 0x7E5D60
	private static void .cctor() { }

	// RVA: 0x7E6208
	internal static ExceptionHandler get_ExceptionHandler() { }

	// RVA: 0x7E5708
	internal static Impl get_Impl() { }

	// RVA: 0x7E6284
	internal static FirebaseApp get_App() { }

}

// Namespace: Firebase.Crashlytics
public static class Crashlytics
{
	// Fields
	private static bool <ReportUncaughtExceptionsAsFatal>k__BackingField; // 0x0

	// Methods

	// RVA: 0x7E5598
	public static bool get_ReportUncaughtExceptionsAsFatal() { }

	// RVA: 0x7E55E4
	public static void set_ReportUncaughtExceptionsAsFatal(bool value) { }

	// RVA: 0x7E563C
	public static bool get_IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7E5784
	public static void set_IsCrashlyticsCollectionEnabled(bool value) { }

	// RVA: 0x7E5860
	private static void Initialize() { }

	// RVA: 0x7E590C
	public static void Log(string message) { }

	// RVA: 0x7E59E8
	public static void SetCustomKey(string key, string value) { }

	// RVA: 0x7E5ACC
	public static void SetUserId(string identifier) { }

	// RVA: 0x7E5BA8
	public static void LogException(Exception exception) { }

	// RVA: 0x7E5C84
	internal static void LogExceptionAsFatal(Exception exception) { }

}

// Namespace: Firebase.Crashlytics
internal class ExceptionHandler
{
	// Fields
	private bool isRegistered; // 0x10

	// Methods

	// RVA: 0x7E6018
	internal void Register() { }

	// RVA: 0x7E6300
	internal void HandleException(object sender, UnhandledExceptionEventArgs eArgs) { }

	// RVA: 0x7E6494
	internal void HandleLog(string message, string stackTraceString, LogType type) { }

	// RVA: 0x7E6564
	private string[] getMessageParts(string message) { }

	// RVA: 0x7E686C
	internal virtual void LogException(LoggedException e) { }

	// RVA: 0x7E5EF4
	public void .ctor() { }

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

	// RVA: 0x7E5F00
	public static Impl Make() { }

	// RVA: 0x7E6B70
	public virtual bool IsSDKInitialized() { }

	// RVA: 0x7E6B78
	public virtual void Log(string message) { }

	// RVA: 0x7E6C20
	public virtual void SetCustomKey(string key, string value) { }

	// RVA: 0x7E6CD0
	public virtual void SetUserId(string identifier) { }

	// RVA: 0x7E6D78
	public virtual void LogException(Exception exception) { }

	// RVA: 0x7E6E20
	public virtual void LogExceptionAsFatal(Exception exception) { }

	// RVA: 0x7E6EC8
	public virtual bool IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7E7024
	public virtual void SetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7E6B68
	public void .ctor() { }

	// RVA: 0x7E70F4
	private static void .cctor() { }

}

// Namespace: Firebase.Crashlytics
internal class LoggedException
{
	// Fields
	private string <Name>k__BackingField; // 0x90
	private string <CustomStackTrace>k__BackingField; // 0x98
	private System.Collections.Generic.Dictionary<System.String,System.String>[] <ParsedStackTrace>k__BackingField; // 0xA0

	// Methods

	// RVA: 0x7E6754
	public void .ctor(string name, string message, string stackTrace) { }

	// RVA: 0x7E63A4
	public static LoggedException FromException(Exception exception) { }

	// RVA: 0x7E7558
	public string get_Name() { }

	// RVA: 0x7E7560
	private void set_Name(string value) { }

	// RVA: 0x7E7568
	public string get_CustomStackTrace() { }

	// RVA: 0x7E7570
	private void set_CustomStackTrace(string value) { }

	// RVA: 0x7E7578
	public System.Collections.Generic.Dictionary<System.String,System.String>[] get_ParsedStackTrace() { }

	// RVA: 0x7E7580
	private void set_ParsedStackTrace(System.Collections.Generic.Dictionary<System.String,System.String>[] value) { }

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

	// RVA: 0x7E7588
	public void .ctor() { }

}

// Namespace: Firebase.Crashlytics
internal class MetadataBuilder
{
	// Fields
	public static string METADATA_KEY; // 0x0

	// Methods

	// RVA: 0x7E77C4
	public static string GenerateMetadataJSON() { }

	// RVA: 0x7E7908
	private static void .cctor() { }

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

	// RVA: 0x7E7274
	public static System.Collections.Generic.Dictionary<System.String,System.String>[] ParseStackTraceString(string stackTrace) { }

	// RVA: 0x7E7980
	private static System.Collections.Generic.Dictionary<System.String,System.String> ParseFrameString(string regex, string frameString) { }

	// RVA: 0x7E7D98
	private static void .cctor() { }

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

	// RVA: 0x7E6AE0
	public void .ctor() { }

}

// Namespace: Firebase.Crashlytics
internal class IOSImpl
{
	// Methods

	// RVA: 0x7E7F2C
	private static extern bool CLUIsInitialized() { }

	// RVA: 0x7E7F48
	private static extern void CLULog(string msg) { }

	// RVA: 0x7E7F70
	private static extern void CLUSetKeyValue(string key, string value) { }

	// RVA: 0x7E7FB8
	private static extern void CLUSetInternalKeyValue(string key, string value) { }

	// RVA: 0x7E8000
	private static extern void CLUSetUserIdentifier(string identifier) { }

	// RVA: 0x7E8028
	private static extern void CLUSetDevelopmentPlatform(string name, string version) { }

	// RVA: 0x7E8070
	private static extern void CLURecordCustomException(string name, string reason, Frame[] frames, int frameCount, bool isOnDemand) { }

	// RVA: 0x7E8204
	private static extern bool CLUIsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7E8220
	private static extern void CLUSetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7E6998
	public void .ctor() { }

	// RVA: 0x7E8224
	public override bool IsSDKInitialized() { }

	// RVA: 0x7E8240
	public override void Log(string message) { }

	// RVA: 0x7E826C
	public override void SetCustomKey(string key, string value) { }

	// RVA: 0x7E82B8
	public override void SetUserId(string identifier) { }

	// RVA: 0x7E82E4
	public override void LogException(Exception exception) { }

	// RVA: 0x7E8668
	public override void LogExceptionAsFatal(Exception exception) { }

	// RVA: 0x7E8688
	public override bool IsCrashlyticsCollectionEnabled() { }

	// RVA: 0x7E86A4
	public override void SetCrashlyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7E8304
	private void RecordCustomException(LoggedException loggedException, bool isOnDemand) { }

}


