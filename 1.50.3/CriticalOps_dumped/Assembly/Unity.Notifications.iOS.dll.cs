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

	// RVA: 0x14E1EF8
	public bool get_IsFinished() { }

	// RVA: 0x14E1FC8
	private void set_IsFinished(bool value) { }

	// RVA: 0x14E1FD0
	private void set_Granted(bool value) { }

	// RVA: 0x14E1FD8
	private void set_Error(string value) { }

	// RVA: 0x14E1FE0
	public string get_DeviceToken() { }

	// RVA: 0x14E20A8
	private void set_DeviceToken(string value) { }

	// RVA: 0x14E20B0
	private static void .cctor() { }

	// RVA: 0x14E219C
	public void .ctor(AuthorizationOption authorizationOption, bool registerForRemoteNotifications) { }

	// RVA: 0x14E21F0
	private void OnAuthorizationRequestCompleted(iOSAuthorizationRequestData requestData) { }

	// RVA: 0x14E22F0
	internal static void OnAuthorizationRequestCompleted(IntPtr request, iOSAuthorizationRequestData requestData) { }

	// RVA: 0x14E2480
	public void Dispose() { }

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

	// RVA: 0x14E2484
	public string get_Identifier() { }

	// RVA: 0x14E248C
	public void set_Identifier(string value) { }

	// RVA: 0x14E2494
	public void set_Title(string value) { }

	// RVA: 0x14E249C
	public void set_Body(string value) { }

	// RVA: 0x14E24A4
	public void set_ShowInForeground(bool value) { }

	// RVA: 0x14E2550
	public void set_ForegroundPresentationOption(PresentationOption value) { }

	// RVA: 0x14E25EC
	public System.Nullable<System.Single> get_SoundVolume() { }

	// RVA: 0x14E25F4
	public void set_InterruptionLevel(NotificationInterruptionLevel value) { }

	// RVA: 0x14E25FC
	public void set_RelevanceScore(Double value) { }

	// RVA: 0x14E2604
	public void set_Data(string value) { }

	// RVA: 0x14E2680
	public System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> get_Attachments() { }

	// RVA: 0x14E2688
	public void set_Attachments(System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> value) { }

	// RVA: 0x14E2690
	public void set_Trigger(iOSNotificationTrigger value) { }

	// RVA: 0x14E2DB8
	private static string GenerateUniqueID() { }

	// RVA: 0x14E2E94
	public void .ctor() { }

	// RVA: 0x14E2EBC
	public void .ctor(string identifier) { }

	// RVA: 0x14E3154
	internal void .ctor(iOSNotificationWithUserInfo data) { }

	// RVA: 0x14E31C0
	internal iOSNotificationWithUserInfo GetDataForSending() { }

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

	// RVA: 0x14E3390
	public string get_Id() { }

	// RVA: 0x14E3398
	public string get_Title() { }

	// RVA: 0x14E33A0
	public iOSNotificationActionOptions get_Options() { }

	// RVA: 0x14E33A8
	internal virtual IntPtr CreateUNNotificationAction() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationAttachment
{
	// Fields
	private string <Id>k__BackingField; // 0x10
	private string <Url>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14E34CC
	public string get_Id() { }

	// RVA: 0x14E34D4
	public void set_Id(string value) { }

	// RVA: 0x14E34DC
	public string get_Url() { }

	// RVA: 0x14E34E4
	public void set_Url(string value) { }

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

	// RVA: 0x14E34EC
	public string get_Id() { }

	// RVA: 0x14E34F4
	public iOSNotificationAction[] get_Actions() { }

	// RVA: 0x14E3548
	public string[] get_IntentIdentifiers() { }

	// RVA: 0x14E359C
	public string get_HiddenPreviewsBodyPlaceholder() { }

	// RVA: 0x14E35A4
	public string get_SummaryFormat() { }

	// RVA: 0x14E35AC
	public iOSNotificationCategoryOptions get_Options() { }

}

// Namespace: 
public sealed class NotificationReceivedCallback
{
	// Methods

	// RVA: 0x14E4368
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E4488
	public virtual void Invoke(iOSNotification notification) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Notifications.iOS.iOSNotificationCenter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x14E449C
	private static void .cctor() { }

	// RVA: 0x14E4508
	public void .ctor() { }

	// RVA: 0x14E4510
	internal void <.cctor>b__39_0(iOSNotification <p0>) { }

	// RVA: 0x14E4514
	internal void <.cctor>b__39_1(iOSNotification <p0>) { }

}

// Namespace: Unity.Notifications.iOS
public class iOSNotificationCenter
{
	// Fields
	private static bool s_Initialized; // 0x0
	private static NotificationReceivedCallback s_OnNotificationReceived; // 0x8
	private static NotificationReceivedCallback s_OnRemoteNotificationReceived; // 0x10

	// Methods

	// RVA: 0x14E35B4
	private static bool Initialize() { }

	// RVA: 0x14E374C
	public static void ScheduleNotification(iOSNotification notification) { }

	// RVA: 0x14E3990
	public static iOSNotification[] GetScheduledNotifications() { }

	// RVA: 0x14E3C60
	public static iOSNotification[] GetDeliveredNotifications() { }

	// RVA: 0x14E3A4C
	private static iOSNotification[] NotificationDataToNotifications(iOSNotificationWithUserInfo[] notificationData) { }

	// RVA: 0x14E3D1C
	public static void RemoveScheduledNotification(string identifier) { }

	// RVA: 0x14E3E4C
	public static void RemoveDeliveredNotification(string identifier) { }

	// RVA: 0x14E3F7C
	internal static void OnReceivedRemoteNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x14E40E0
	internal static void OnSentNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x14E4244
	private static void .cctor() { }

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

	// RVA: 0x14E5008
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E6FA8
	public virtual void Invoke(IntPtr request, iOSAuthorizationRequestData data) { }

}

// Namespace: 
private sealed class NotificationReceivedCallback
{
	// Methods

	// RVA: 0x14E5194
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E6FE8
	public virtual void Invoke(iOSNotificationData notificationData) { }

}

// Namespace: 
private sealed class ReceiveNSDictionaryKeyValueCallback
{
	// Methods

	// RVA: 0x14E5FE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E706C
	public virtual void Invoke(IntPtr dict, string key, string value) { }

}

// Namespace: 
private sealed class ReceiveUNNotificationAttachmentCallback
{
	// Methods

	// RVA: 0x14E6084
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14E7080
	public virtual void Invoke(IntPtr array, string id, string url) { }

}

// Namespace: Unity.Notifications.iOS
internal class iOSNotificationsWrapper
{
	// Methods

	// RVA: 0x14E4A84
	private static extern void _RequestAuthorization(IntPtr request, int options, bool registerForRemote) { }

	// RVA: 0x14E4A88
	private static extern int _RegisteredForRemoteNotifications() { }

	// RVA: 0x14E4A8C
	private static extern void _UnregisterForRemoteNotifications() { }

	// RVA: 0x14E4A90
	private static extern void _ScheduleLocalNotification(iOSNotificationData data) { }

	// RVA: 0x14E4BF8
	private static extern void _SetNotificationReceivedDelegate(NotificationReceivedCallback callback) { }

	// RVA: 0x14E4C0C
	private static extern void _SetRemoteNotificationReceivedDelegate(NotificationReceivedCallback callback) { }

	// RVA: 0x14E4C20
	private static extern void _SetAuthorizationRequestReceivedDelegate(AuthorizationRequestCallback callback) { }

	// RVA: 0x14E4C34
	private static extern iOSNotificationSettings _GetNotificationSettings() { }

	// RVA: 0x14E4C38
	private static extern IntPtr _GetScheduledNotificationDataArray(int count) { }

	// RVA: 0x14E4C3C
	private static extern IntPtr _GetDeliveredNotificationDataArray(int count) { }

	// RVA: 0x14E3E24
	internal static extern void _RemoveScheduledNotification(string identifier) { }

	// RVA: 0x14E4C40
	internal static extern void _RemoveAllScheduledNotifications() { }

	// RVA: 0x14E3F54
	internal static extern void _RemoveDeliveredNotification(string identifier) { }

	// RVA: 0x14E4C44
	private static extern void _SetApplicationBadge(int badge) { }

	// RVA: 0x14E4C48
	private static extern int _GetApplicationBadge() { }

	// RVA: 0x14E4C4C
	private static extern int _GetAppOpenedUsingNotification() { }

	// RVA: 0x14E4C50
	internal static extern void _RemoveAllDeliveredNotifications() { }

	// RVA: 0x14E4C54
	private static extern IntPtr _GetLastNotificationData() { }

	// RVA: 0x14E4C58
	private static extern string _GetLastRespondedNotificationAction() { }

	// RVA: 0x14E4C8C
	private static extern string _GetLastRespondedNotificationUserText() { }

	// RVA: 0x14E4CC0
	private static extern void _FreeUnmanagediOSNotificationDataArray(IntPtr ptr, int count) { }

	// RVA: 0x14E4CC4
	internal static extern IntPtr _AddItemToNSDictionary(IntPtr dict, string key, string value) { }

	// RVA: 0x14E4D2C
	internal static extern IntPtr _AddAttachmentToNSArray(IntPtr atts, string id, string url, IntPtr error) { }

	// RVA: 0x14E4D9C
	private static extern void _ReadNSDictionary(IntPtr handle, IntPtr nsDict, ReceiveNSDictionaryKeyValueCallback callback) { }

	// RVA: 0x14E4DD0
	private static extern void _ReadAttachmentsNSArray(IntPtr handle, IntPtr nsArray, ReceiveUNNotificationAttachmentCallback callback) { }

	// RVA: 0x14E343C
	internal static extern IntPtr _CreateUNNotificationAction(string id, string title, int options, int iconType, string icon) { }

	// RVA: 0x14E4E04
	internal static extern IntPtr _CreateUNTextInputNotificationAction(string id, string title, int options, int iconType, string icon, string buttonTitle, string placeholder) { }

	// RVA: 0x14E4ED4
	private static extern void _ReleaseNSObject(IntPtr obj) { }

	// RVA: 0x14E4ED8
	private static extern string _NSErrorToMessage(IntPtr error) { }

	// RVA: 0x14E4F0C
	private static extern IntPtr _AddActionToNSArray(IntPtr actions, IntPtr action, int capacity) { }

	// RVA: 0x14E4F10
	private static extern IntPtr _CreateUNNotificationCategory(string id, string hiddenPreviewsBodyPlaceholder, string summaryFormat, int options, IntPtr actions, IntPtr intentIdentifiers) { }

	// RVA: 0x14E4FA8
	private static extern IntPtr _AddCategoryToCategorySet(IntPtr categorySet, IntPtr category) { }

	// RVA: 0x14E4FAC
	private static extern void _SetNotificationCategories(IntPtr categorySet) { }

	// RVA: 0x14E4FB0
	private static extern IntPtr _AddStringToNSArray(IntPtr array, string str, int capacity) { }

	// RVA: 0x14E5004
	internal static extern void _OpenNotificationSettings() { }

	// RVA: 0x14E20B4
	public static void RegisterAuthorizationRequestCallback() { }

	// RVA: 0x14E50AC
	public static void RegisterOnReceivedRemoteNotificationCallback() { }

	// RVA: 0x14E3664
	public static void RegisterOnReceivedCallback() { }

	// RVA: 0x14E4518
	public static void AuthorizationRequestReceived(IntPtr request, iOSAuthorizationRequestData data) { }

	// RVA: 0x14E45AC
	public static void RemoteNotificationReceived(iOSNotificationData data) { }

	// RVA: 0x14E4728
	public static void NotificationReceived(iOSNotificationData data) { }

	// RVA: 0x14E5238
	private static iOSNotificationWithUserInfo NotificationDataToDataWithUserInfo(iOSNotificationData data) { }

	// RVA: 0x14E48A4
	private static void ReceiveNSDictionaryKeyValue(IntPtr dict, string key, string value) { }

	// RVA: 0x14E4974
	private static void ReceiveUNNotificationAttachment(IntPtr array, string id, string url) { }

	// RVA: 0x14E21EC
	public static void RequestAuthorization(IntPtr request, int options, bool registerRemote) { }

	// RVA: 0x14E5630
	public static bool RegisteredForRemoteNotifications() { }

	// RVA: 0x14E564C
	public static void UnregisterForRemoteNotifications() { }

	// RVA: 0x14E5650
	public static iOSNotificationSettings GetNotificationSettings() { }

	// RVA: 0x14E38F8
	public static void ScheduleLocalNotification(iOSNotificationWithUserInfo data) { }

	// RVA: 0x14E3CF0
	public static iOSNotificationWithUserInfo[] GetDeliveredNotificationData() { }

	// RVA: 0x14E5F78
	public static string GetLastRespondedNotificationAction() { }

	// RVA: 0x14E5FAC
	public static string GetLastRespondedNotificationUserText() { }

	// RVA: 0x14E3A20
	public static iOSNotificationWithUserInfo[] GetScheduledNotificationData() { }

	// RVA: 0x14E5C90
	private static iOSNotificationWithUserInfo[] MarshalAndFreeNotificationDataArray(IntPtr ptr, int count) { }

	// RVA: 0x14E5690
	public static IntPtr CsDictionaryToObjC(System.Collections.Generic.Dictionary<System.String,System.String> userInfo) { }

	// RVA: 0x14E59D8
	public static IntPtr CsAttachmentsToObjc(System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> attachments) { }

	// RVA: 0x14E5330
	public static System.Collections.Generic.Dictionary<System.String,System.String> NSDictionaryToCs(IntPtr dict) { }

	// RVA: 0x14E54A4
	public static System.Collections.Generic.List<Unity.Notifications.iOS.iOSNotificationAttachment> AttachmentsNSArrayToCs(IntPtr array) { }

	// RVA: 0x14E6128
	public static void SetApplicationBadge(int badge) { }

	// RVA: 0x14E612C
	public static int GetApplicationBadge() { }

	// RVA: 0x14E6130
	public static bool GetAppOpenedUsingNotification() { }

	// RVA: 0x14E614C
	public static System.Nullable<Unity.Notifications.iOS.iOSNotificationWithUserInfo> GetLastNotificationData() { }

	// RVA: 0x14E639C
	public static void SetNotificationCategories(System.Collections.Generic.IEnumerable<Unity.Notifications.iOS.iOSNotificationCategory> categories) { }

	// RVA: 0x14E6FA0
	public void .ctor() { }

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

	// RVA: -1
	public abstract iOSNotificationTriggerType get_Type() { }

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

	// RVA: 0x14E7094
	public iOSNotificationTriggerType get_Type() { }

	// RVA: 0x14E709C
	public Double get_Latitude() { }

	// RVA: 0x14E70A4
	public Double get_Longitude() { }

	// RVA: 0x14E70AC
	public float get_Radius() { }

	// RVA: 0x14E70B4
	public bool get_NotifyOnEntry() { }

	// RVA: 0x14E70BC
	public bool get_NotifyOnExit() { }

	// RVA: 0x14E70C4
	public bool get_Repeats() { }

}

// Namespace: Unity.Notifications.iOS
public struct iOSNotificationTimeIntervalTrigger
{
	// Fields
	internal int timeInterval; // 0x10
	private bool <Repeats>k__BackingField; // 0x14

	// Methods

	// RVA: 0x14E70CC
	public iOSNotificationTriggerType get_Type() { }

	// RVA: 0x14E70D4
	public bool get_Repeats() { }

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

	// RVA: 0x14E70DC
	public iOSNotificationTriggerType get_Type() { }

	// RVA: 0x14E70E4
	public System.Nullable<System.Int32> get_Year() { }

	// RVA: 0x14E70EC
	public void set_Year(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E70F4
	public System.Nullable<System.Int32> get_Month() { }

	// RVA: 0x14E70FC
	public void set_Month(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E7104
	public System.Nullable<System.Int32> get_Day() { }

	// RVA: 0x14E710C
	public void set_Day(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E7114
	public System.Nullable<System.Int32> get_Hour() { }

	// RVA: 0x14E711C
	public void set_Hour(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E7124
	public System.Nullable<System.Int32> get_Minute() { }

	// RVA: 0x14E712C
	public void set_Minute(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E7134
	public System.Nullable<System.Int32> get_Second() { }

	// RVA: 0x14E713C
	public void set_Second(System.Nullable<System.Int32> value) { }

	// RVA: 0x14E7144
	public bool get_UtcTime() { }

	// RVA: 0x14E714C
	public bool get_Repeats() { }

	// RVA: 0x14E7154
	public void set_Repeats(bool value) { }

}


