// Namespace: 
internal class <Module> 
{}

// Namespace: Unity.Notifications.iOS
public enum AuthorizationOption 
{
	// Fields
	public int value__; // 0x10
	public const AuthorizationOption Badge = 1;
	public const AuthorizationOption Sound = 2;
	public const AuthorizationOption Alert = 4;
	public const AuthorizationOption CarPlay = 8;
	public const AuthorizationOption CriticalAlert = 16;
	public const AuthorizationOption ProvidesAppNotificationSettings = 32;
	public const AuthorizationOption Provisional = 64;
}

// Namespace: Unity.Notifications.iOS
internal struct iOSAuthorizationRequestData 
{
	// Fields
	internal int granted; // 0x10
	internal string error; // 0x18
	internal string deviceToken; // 0x20
}

// Namespace: Unity.Notifications.iOS
public class AuthorizationRequest 
{
	// Fields
	private bool m_IsFinished; // 0x10
	private bool m_Granted; // 0x11
	private string m_Error; // 0x18
	private string m_DeviceToken; // 0x20

	// Methods

	// RVA: 0x1488328
	bool get_IsFinished() { }

	// RVA: 0x14883F8
	void set_IsFinished(bool value) { }

	// RVA: 0x1488400
	void set_Granted(bool value) { }

	// RVA: 0x1488408
	void set_Error(string value) { }

	// RVA: 0x1488410
	string get_DeviceToken() { }

	// RVA: 0x14884D8
	void set_DeviceToken(string value) { }

	// RVA: 0x14884E0
	void .cctor() { }

	// RVA: 0x14885CC
	void .ctor(AuthorizationOption authorizationOption, bool registerForRemoteNotifications) { }

	// RVA: 0x1488620
	void OnAuthorizationRequestCompleted(iOSAuthorizationRequestData requestData) { }

	// RVA: 0x1488720
	void OnAuthorizationRequestCompleted(IntPtr request, iOSAuthorizationRequestData requestData) { }

	// RVA: 0x14888B0
	void Dispose() { }

}

// Namespace: Unity.Notifications.iOS
public enum PresentationOption 
{
	// Fields
	public int value__; // 0x10
	public const PresentationOption None = 0;
	public const PresentationOption Badge = 1;
	public const PresentationOption Sound = 2;
	public const PresentationOption Alert = 4;
	public const PresentationOption List = 8;
	public const PresentationOption Banner = 16;
}

// Namespace: Unity.Notifications.iOS
public enum NotificationInterruptionLevel 
{
	// Fields
	public int value__; // 0x10
	public const NotificationInterruptionLevel Active = 0;
	public const NotificationInterruptionLevel Critical = 1;
	public const NotificationInterruptionLevel Passive = 2;
	public const NotificationInterruptionLevel TimeSensitive = 3;
}

// Namespace: Unity.Notifications.iOS
internal struct TimeTriggerData 
{
	// Fields
	public int interval; // 0x10
	public Byte repeats; // 0x14
}

// Namespace: Unity.Notifications.iOS
internal struct CalendarTriggerData 
{
	// Fields
	public int year; // 0x10
	public int month; // 0x14
	public int day; // 0x18
	public int hour; // 0x1C
	public int minute; // 0x20
	public int second; // 0x24
	public Byte repeats; // 0x28
}

// Namespace: Unity.Notifications.iOS
internal struct LocationTriggerData 
{
	// Fields
	public Double latitude; // 0x10
	public Double longitude; // 0x18
	public float radius; // 0x20
	public Byte notifyOnEntry; // 0x24
	public Byte notifyOnExit; // 0x25
	public Byte repeats; // 0x26
}

// Namespace: Unity.Notifications.iOS
internal struct TriggerData 
{
	// Fields
	public TimeTriggerData timeInterval; // 0x10
	public CalendarTriggerData calendar; // 0x10
	public LocationTriggerData location; // 0x10
}

// Namespace: Unity.Notifications.iOS
internal struct iOSNotificationData 
{
	// Fields
	public string identifier; // 0x10
	public string title; // 0x18
	public string body; // 0x20
	public int badge; // 0x28
	public string subtitle; // 0x30
	public string categoryIdentifier; // 0x38
	public string threadIdentifier; // 0x40
	public int soundType; // 0x48
	public float soundVolume; // 0x4C
	public string soundName; // 0x50
	public int interruptionLevel; // 0x58
	public Double relevanceScore; // 0x60
	public IntPtr userInfo; // 0x68
	public IntPtr attachments; // 0x70
	public int triggerType; // 0x78
	public TriggerData trigger; // 0x80
}

// Namespace: Unity.Notifications.iOS
public class iOSNotification 
{
	// Fields
	private System.Nullable<System.Single> <SoundVolume>k__BackingField; // 0x10
	private System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> <Attachments>k__BackingField; // 0x18
	private iOSNotificationData data; // 0x20
	private System.Collections.Generic.Dictionary<System.String,System.String> userInfo; // 0xB0

	// Methods

	// RVA: 0x14888B4
	string get_Identifier() { }

	// RVA: 0x14888BC
	void set_Identifier(string value) { }

	// RVA: 0x14888C4
	void set_Title(string value) { }

	// RVA: 0x14888CC
	void set_Body(string value) { }

	// RVA: 0x14888D4
	void set_ShowInForeground(bool value) { }

	// RVA: 0x1488980
	void set_ForegroundPresentationOption(PresentationOption value) { }

	// RVA: 0x1488A1C
	System.Nullable<System.Single> get_SoundVolume() { }

	// RVA: 0x1488A24
	void set_InterruptionLevel(NotificationInterruptionLevel value) { }

	// RVA: 0x1488A2C
	void set_RelevanceScore(Double value) { }

	// RVA: 0x1488A34
	void set_Data(string value) { }

	// RVA: 0x1488AB0
	System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> get_Attachments() { }

	// RVA: 0x1488AB8
	void set_Attachments(System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> value) { }

	// RVA: 0x1488AC0
	void set_Trigger(iOSNotificationTrigger value) { }

	// RVA: 0x14891E8
	string GenerateUniqueID() { }

	// RVA: 0x14892C4
	void .ctor() { }

	// RVA: 0x14892EC
	void .ctor(string identifier) { }

	// RVA: 0x1489584
	void .ctor(iOSNotificationWithUserInfo data) { }

	// RVA: 0x14895F0
	iOSNotificationWithUserInfo GetDataForSending() { }

}

// Namespace: Unity.Notifications.iOS
public enum iOSNotificationActionOptions 
{
	// Fields
	public int value__; // 0x10
	public const iOSNotificationActionOptions None = 0;
	public const iOSNotificationActionOptions Required = 1;
	public const iOSNotificationActionOptions Destructive = 2;
	public const iOSNotificationActionOptions Foreground = 4;
}

// Namespace: Unity.Notifications.iOS
internal enum iOSNotificationActionIconType 
{
	// Fields
	public int value__; // 0x10
	public const iOSNotificationActionIconType None = 0;
	public const iOSNotificationActionIconType SystemImageName = 1;
	public const iOSNotificationActionIconType TemplateImageName = 2;
}

// Namespace: Unity.Notifications.iOS
public class iOSNotificationAction 
{
	// Fields
	internal iOSNotificationActionIconType _imageType; // 0x10
	internal string _image; // 0x18
	private string <Id>k__BackingField; // 0x20
	private string <Title>k__BackingField; // 0x28
	private iOSNotificationActionOptions <Options>k__BackingField; // 0x30

	// Methods

	// RVA: 0x14897C0
	string get_Id() { }

	// RVA: 0x14897C8
	string get_Title() { }

	// RVA: 0x14897D0
	iOSNotificationActionOptions get_Options() { }

	// RVA: 0x14897D8
	IntPtr CreateUNNotificationAction() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationAttachment 
{
	// Fields
	private string <Id>k__BackingField; // 0x10
	private string <Url>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14898FC
	string get_Id() { }

	// RVA: 0x1489904
	void set_Id(string value) { }

	// RVA: 0x148990C
	string get_Url() { }

	// RVA: 0x1489914
	void set_Url(string value) { }

}

// Namespace: Unity.Notifications.iOS
public enum iOSNotificationCategoryOptions 
{
	// Fields
	public int value__; // 0x10
	public const iOSNotificationCategoryOptions None = 0;
	public const iOSNotificationCategoryOptions CustomDismissAction = 1;
	public const iOSNotificationCategoryOptions AllowInCarPlay = 2;
	public const iOSNotificationCategoryOptions HiddenPreviewsShowTitle = 4;
	public const iOSNotificationCategoryOptions HiddenPreviewsShowSubtitle = 8;
}

// Namespace: Unity.Notifications.iOS
public class iOSNotificationCategory 
{
	// Fields
	private System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAction> m_Actions; // 0x10
	private System.Collections.Generic.List<System.String> m_IntentIdentifiers; // 0x18
	private string <Id>k__BackingField; // 0x20
	private string <HiddenPreviewsBodyPlaceholder>k__BackingField; // 0x28
	private string <SummaryFormat>k__BackingField; // 0x30
	private iOSNotificationCategoryOptions <Options>k__BackingField; // 0x38

	// Methods

	// RVA: 0x148991C
	string get_Id() { }

	// RVA: 0x1489924
	iOSNotificationAction[] get_Actions() { }

	// RVA: 0x1489978
	string[] get_IntentIdentifiers() { }

	// RVA: 0x14899CC
	string get_HiddenPreviewsBodyPlaceholder() { }

	// RVA: 0x14899D4
	string get_SummaryFormat() { }

	// RVA: 0x14899DC
	iOSNotificationCategoryOptions get_Options() { }

}

// Namespace: 
public sealed class NotificationReceivedCallback 
{
	// Methods

	// RVA: 0x148A798
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148A8B8
	internal void Invoke(iOSNotification notification) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Unity.Notifications.iOS.iOSNotificationCenter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x148A8CC
	void .cctor() { }

	// RVA: 0x148A938
	void .ctor() { }

	// RVA: 0x148A940
	void <.cctor>b__39_0(iOSNotification <p0>) { }

	// RVA: 0x148A944
	void <.cctor>b__39_1(iOSNotification <p0>) { }

}

// Namespace: Unity.Notifications.iOS
public class iOSNotificationCenter 
{
	// Fields
	private static bool s_Initialized; // 0x0
	private static NotificationReceivedCallback s_OnNotificationReceived; // 0x8
	private static NotificationReceivedCallback s_OnRemoteNotificationReceived; // 0x10

	// Methods

	// RVA: 0x14899E4
	bool Initialize() { }

	// RVA: 0x1489B7C
	void ScheduleNotification(iOSNotification notification) { }

	// RVA: 0x1489DC0
	iOSNotification[] GetScheduledNotifications() { }

	// RVA: 0x148A090
	iOSNotification[] GetDeliveredNotifications() { }

	// RVA: 0x1489E7C
	iOSNotification[] NotificationDataToNotifications(iOSNotificationWithUserInfo[] notificationData) { }

	// RVA: 0x148A14C
	void RemoveScheduledNotification(string identifier) { }

	// RVA: 0x148A27C
	void RemoveDeliveredNotification(string identifier) { }

	// RVA: 0x148A3AC
	void OnReceivedRemoteNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x148A510
	void OnSentNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x148A674
	void .cctor() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationSettings 
{
	// Fields
	internal int authorizationStatus; // 0x10
	internal int notificationCenterSetting; // 0x14
	internal int lockScreenSetting; // 0x18
	internal int carPlaySetting; // 0x1C
	internal int alertSetting; // 0x20
	internal int badgeSetting; // 0x24
	internal int soundSetting; // 0x28
	internal int alertStyle; // 0x2C
	internal int showPreviewsSetting; // 0x30
}

// Namespace: Unity.Notifications.iOS
internal struct iOSNotificationWithUserInfo 
{
	// Fields
	internal iOSNotificationData data; // 0x10
	internal System.Collections.Generic.Dictionary<System.String,System.String> userInfo; // 0xA0
	internal System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> attachments; // 0xA8
}

// Namespace: 
private sealed class AuthorizationRequestCallback 
{
	// Methods

	// RVA: 0x148B438
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D3D8
	internal void Invoke(IntPtr request, iOSAuthorizationRequestData data) { }

}

// Namespace: 
private sealed class NotificationReceivedCallback 
{
	// Methods

	// RVA: 0x148B5C4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D418
	internal void Invoke(iOSNotificationData notificationData) { }

}

// Namespace: 
private sealed class ReceiveNSDictionaryKeyValueCallback 
{
	// Methods

	// RVA: 0x148C410
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D49C
	internal void Invoke(IntPtr dict, string key, string value) { }

}

// Namespace: 
private sealed class ReceiveUNNotificationAttachmentCallback 
{
	// Methods

	// RVA: 0x148C4B4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x148D4B0
	internal void Invoke(IntPtr array, string id, string url) { }

}

// Namespace: Unity.Notifications.iOS
internal class iOSNotificationsWrapper 
{
	// Methods

	// RVA: 0x148AEB4
	void _RequestAuthorization(IntPtr request, int options, bool registerForRemote) { }

	// RVA: 0x148AEB8
	int _RegisteredForRemoteNotifications() { }

	// RVA: 0x148AEBC
	void _UnregisterForRemoteNotifications() { }

	// RVA: 0x148AEC0
	void _ScheduleLocalNotification(iOSNotificationData data) { }

	// RVA: 0x148B028
	void _SetNotificationReceivedDelegate(NotificationReceivedCallback callback) { }

	// RVA: 0x148B03C
	void _SetRemoteNotificationReceivedDelegate(NotificationReceivedCallback callback) { }

	// RVA: 0x148B050
	void _SetAuthorizationRequestReceivedDelegate(AuthorizationRequestCallback callback) { }

	// RVA: 0x148B064
	iOSNotificationSettings _GetNotificationSettings() { }

	// RVA: 0x148B068
	IntPtr _GetScheduledNotificationDataArray(out int count) { }

	// RVA: 0x148B06C
	IntPtr _GetDeliveredNotificationDataArray(out int count) { }

	// RVA: 0x148A254
	void _RemoveScheduledNotification(string identifier) { }

	// RVA: 0x148B070
	void _RemoveAllScheduledNotifications() { }

	// RVA: 0x148A384
	void _RemoveDeliveredNotification(string identifier) { }

	// RVA: 0x148B074
	void _SetApplicationBadge(int badge) { }

	// RVA: 0x148B078
	int _GetApplicationBadge() { }

	// RVA: 0x148B07C
	int _GetAppOpenedUsingNotification() { }

	// RVA: 0x148B080
	void _RemoveAllDeliveredNotifications() { }

	// RVA: 0x148B084
	IntPtr _GetLastNotificationData() { }

	// RVA: 0x148B088
	string _GetLastRespondedNotificationAction() { }

	// RVA: 0x148B0BC
	string _GetLastRespondedNotificationUserText() { }

	// RVA: 0x148B0F0
	void _FreeUnmanagediOSNotificationDataArray(IntPtr ptr, int count) { }

	// RVA: 0x148B0F4
	IntPtr _AddItemToNSDictionary(IntPtr dict, string key, string value) { }

	// RVA: 0x148B15C
	IntPtr _AddAttachmentToNSArray(IntPtr atts, string id, string url, out IntPtr error) { }

	// RVA: 0x148B1CC
	void _ReadNSDictionary(IntPtr handle, IntPtr nsDict, ReceiveNSDictionaryKeyValueCallback callback) { }

	// RVA: 0x148B200
	void _ReadAttachmentsNSArray(IntPtr handle, IntPtr nsArray, ReceiveUNNotificationAttachmentCallback callback) { }

	// RVA: 0x148986C
	IntPtr _CreateUNNotificationAction(string id, string title, int options, int iconType, string icon) { }

	// RVA: 0x148B234
	IntPtr _CreateUNTextInputNotificationAction(string id, string title, int options, int iconType, string icon, string buttonTitle, string placeholder) { }

	// RVA: 0x148B304
	void _ReleaseNSObject(IntPtr obj) { }

	// RVA: 0x148B308
	string _NSErrorToMessage(IntPtr error) { }

	// RVA: 0x148B33C
	IntPtr _AddActionToNSArray(IntPtr actions, IntPtr action, int capacity) { }

	// RVA: 0x148B340
	IntPtr _CreateUNNotificationCategory(string id, string hiddenPreviewsBodyPlaceholder, string summaryFormat, int options, IntPtr actions, IntPtr intentIdentifiers) { }

	// RVA: 0x148B3D8
	IntPtr _AddCategoryToCategorySet(IntPtr categorySet, IntPtr category) { }

	// RVA: 0x148B3DC
	void _SetNotificationCategories(IntPtr categorySet) { }

	// RVA: 0x148B3E0
	IntPtr _AddStringToNSArray(IntPtr array, string str, int capacity) { }

	// RVA: 0x148B434
	void _OpenNotificationSettings() { }

	// RVA: 0x14884E4
	void RegisterAuthorizationRequestCallback() { }

	// RVA: 0x148B4DC
	void RegisterOnReceivedRemoteNotificationCallback() { }

	// RVA: 0x1489A94
	void RegisterOnReceivedCallback() { }

	// RVA: 0x148A948
	void AuthorizationRequestReceived(IntPtr request, iOSAuthorizationRequestData data) { }

	// RVA: 0x148A9DC
	void RemoteNotificationReceived(iOSNotificationData data) { }

	// RVA: 0x148AB58
	void NotificationReceived(iOSNotificationData data) { }

	// RVA: 0x148B668
	iOSNotificationWithUserInfo NotificationDataToDataWithUserInfo(iOSNotificationData data) { }

	// RVA: 0x148ACD4
	void ReceiveNSDictionaryKeyValue(IntPtr dict, string key, string value) { }

	// RVA: 0x148ADA4
	void ReceiveUNNotificationAttachment(IntPtr array, string id, string url) { }

	// RVA: 0x148861C
	void RequestAuthorization(IntPtr request, int options, bool registerRemote) { }

	// RVA: 0x148BA60
	bool RegisteredForRemoteNotifications() { }

	// RVA: 0x148BA7C
	void UnregisterForRemoteNotifications() { }

	// RVA: 0x148BA80
	iOSNotificationSettings GetNotificationSettings() { }

	// RVA: 0x1489D28
	void ScheduleLocalNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x148A120
	iOSNotificationWithUserInfo[] GetDeliveredNotificationData() { }

	// RVA: 0x148C3A8
	string GetLastRespondedNotificationAction() { }

	// RVA: 0x148C3DC
	string GetLastRespondedNotificationUserText() { }

	// RVA: 0x1489E50
	iOSNotificationWithUserInfo[] GetScheduledNotificationData() { }

	// RVA: 0x148C0C0
	iOSNotificationWithUserInfo[] MarshalAndFreeNotificationDataArray(IntPtr ptr, int count) { }

	// RVA: 0x148BAC0
	IntPtr CsDictionaryToObjC(System.Collections.Generic.Dictionary<System.String,System.String> userInfo) { }

	// RVA: 0x148BE08
	IntPtr CsAttachmentsToObjc(System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> attachments) { }

	// RVA: 0x148B760
	System.Collections.Generic.Dictionary<System.String,System.String> NSDictionaryToCs(IntPtr dict) { }

	// RVA: 0x148B8D4
	System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> AttachmentsNSArrayToCs(IntPtr array) { }

	// RVA: 0x148C558
	void SetApplicationBadge(int badge) { }

	// RVA: 0x148C55C
	int GetApplicationBadge() { }

	// RVA: 0x148C560
	bool GetAppOpenedUsingNotification() { }

	// RVA: 0x148C57C
	System.Nullable<Unity.Notifications.iOS.iOSNotificationWithUserInfo> GetLastNotificationData() { }

	// RVA: 0x148C7CC
	void SetNotificationCategories(System.Collections.Generic.IEnumerable<Unity.Notifications.iOS.iOSNotificationCategory> categories) { }

	// RVA: 0x148D3D0
	void .ctor() { }

}

// Namespace: Unity.Notifications.iOS
public enum iOSNotificationTriggerType 
{
	// Fields
	public int value__; // 0x10
	public const iOSNotificationTriggerType TimeInterval = 0;
	public const iOSNotificationTriggerType Calendar = 10;
	public const iOSNotificationTriggerType Location = 20;
	public const iOSNotificationTriggerType Push = 3;
	public const iOSNotificationTriggerType Unknown = 4294967295;
}

// Namespace: Unity.Notifications.iOS
public interface iOSNotificationTrigger 
{
	// Methods

	// RVA: 0x2FE32D4
	iOSNotificationTriggerType get_Type() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationLocationTrigger 
{
	// Fields
	private Double <Latitude>k__BackingField; // 0x10
	private Double <Longitude>k__BackingField; // 0x18
	private float <Radius>k__BackingField; // 0x20
	private bool <NotifyOnEntry>k__BackingField; // 0x24
	private bool <NotifyOnExit>k__BackingField; // 0x25
	private bool <Repeats>k__BackingField; // 0x26

	// Methods

	// RVA: 0x148D4C4
	iOSNotificationTriggerType get_Type() { }

	// RVA: 0x148D4CC
	Double get_Latitude() { }

	// RVA: 0x148D4D4
	Double get_Longitude() { }

	// RVA: 0x148D4DC
	float get_Radius() { }

	// RVA: 0x148D4E4
	bool get_NotifyOnEntry() { }

	// RVA: 0x148D4EC
	bool get_NotifyOnExit() { }

	// RVA: 0x148D4F4
	bool get_Repeats() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationTimeIntervalTrigger 
{
	// Fields
	internal int timeInterval; // 0x10
	private bool <Repeats>k__BackingField; // 0x14

	// Methods

	// RVA: 0x148D4FC
	iOSNotificationTriggerType get_Type() { }

	// RVA: 0x148D504
	bool get_Repeats() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationCalendarTrigger 
{
	// Fields
	private System.Nullable<System.Int32> <Year>k__BackingField; // 0x10
	private System.Nullable<System.Int32> <Month>k__BackingField; // 0x18
	private System.Nullable<System.Int32> <Day>k__BackingField; // 0x20
	private System.Nullable<System.Int32> <Hour>k__BackingField; // 0x28
	private System.Nullable<System.Int32> <Minute>k__BackingField; // 0x30
	private System.Nullable<System.Int32> <Second>k__BackingField; // 0x38
	private bool <UtcTime>k__BackingField; // 0x40
	private bool <Repeats>k__BackingField; // 0x41

	// Methods

	// RVA: 0x148D50C
	iOSNotificationTriggerType get_Type() { }

	// RVA: 0x148D514
	System.Nullable<System.Int32> get_Year() { }

	// RVA: 0x148D51C
	void set_Year(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D524
	System.Nullable<System.Int32> get_Month() { }

	// RVA: 0x148D52C
	void set_Month(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D534
	System.Nullable<System.Int32> get_Day() { }

	// RVA: 0x148D53C
	void set_Day(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D544
	System.Nullable<System.Int32> get_Hour() { }

	// RVA: 0x148D54C
	void set_Hour(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D554
	System.Nullable<System.Int32> get_Minute() { }

	// RVA: 0x148D55C
	void set_Minute(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D564
	System.Nullable<System.Int32> get_Second() { }

	// RVA: 0x148D56C
	void set_Second(System.Nullable<System.Int32> value) { }

	// RVA: 0x148D574
	bool get_UtcTime() { }

	// RVA: 0x148D57C
	bool get_Repeats() { }

	// RVA: 0x148D584
	void set_Repeats(bool value) { }

}


