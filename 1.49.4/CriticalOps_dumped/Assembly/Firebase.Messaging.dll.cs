// Namespace: 
internal class <Module>
{}

// Namespace: Firebase.Messaging
public sealed class FirebaseMessage
{
	// Fields
	private string <CollapseKey>k__BackingField; // 0x10
	private System.Collections.Generic.IDictionary<System.String,System.String> <Data>k__BackingField; // 0x18
	private string <Error>k__BackingField; // 0x20
	private string <ErrorDescription>k__BackingField; // 0x28
	private string <From>k__BackingField; // 0x30
	private Uri <Link>k__BackingField; // 0x38
	private string <MessageId>k__BackingField; // 0x40
	private string <MessageType>k__BackingField; // 0x48
	private FirebaseNotification <Notification>k__BackingField; // 0x50
	private bool <NotificationOpened>k__BackingField; // 0x58
	private string <Priority>k__BackingField; // 0x60
	private Byte[] <RawData>k__BackingField; // 0x68
	private TimeSpan <TimeToLive>k__BackingField; // 0x70
	private string <To>k__BackingField; // 0x78

	// Methods

	// RVA: 0x79ED90
	internal static FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	// RVA: 0x7A00D8
	private void set_CollapseKey(string value) { }

	// RVA: 0x7A00E0
	public System.Collections.Generic.IDictionary<System.String,System.String> get_Data() { }

	// RVA: 0x7A00E8
	private void set_Data(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7A00F0
	private void set_Error(string value) { }

	// RVA: 0x7A00F8
	private void set_ErrorDescription(string value) { }

	// RVA: 0x7A0100
	private void set_From(string value) { }

	// RVA: 0x7A0108
	private void set_Link(Uri value) { }

	// RVA: 0x7A0110
	private void set_MessageId(string value) { }

	// RVA: 0x7A0118
	private void set_MessageType(string value) { }

	// RVA: 0x7A0120
	private void set_Notification(FirebaseNotification value) { }

	// RVA: 0x7A0128
	private void set_NotificationOpened(bool value) { }

	// RVA: 0x7A0130
	private void set_Priority(string value) { }

	// RVA: 0x7A0138
	public Byte[] get_RawData() { }

	// RVA: 0x7A0140
	private void set_RawData(Byte[] value) { }

	// RVA: 0x7A0148
	private void set_TimeToLive(TimeSpan value) { }

	// RVA: 0x7A0150
	private void set_To(string value) { }

	// RVA: 0x79F054
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public static class FirebaseMessaging
{
	// Methods

	// RVA: 0x7A0158
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A032C
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A0500
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7A06D4
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

}

// Namespace: Firebase.Messaging
public sealed class AndroidNotificationParams
{
	// Fields
	private string <ChannelId>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A08A8
	internal static AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other) { }

	// RVA: 0x7A0A28
	private void set_ChannelId(string value) { }

	// RVA: 0x7A093C
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class FirebaseNotification
{
	// Fields
	private AndroidNotificationParams <Android>k__BackingField; // 0x10
	private string <Badge>k__BackingField; // 0x18
	private string <Body>k__BackingField; // 0x20
	private System.Collections.Generic.IEnumerable<System.String> <BodyLocalizationArgs>k__BackingField; // 0x28
	private string <BodyLocalizationKey>k__BackingField; // 0x30
	private string <ClickAction>k__BackingField; // 0x38
	private string <Color>k__BackingField; // 0x40
	private string <Icon>k__BackingField; // 0x48
	private string <Sound>k__BackingField; // 0x50
	private string <Tag>k__BackingField; // 0x58
	private string <Title>k__BackingField; // 0x60
	private System.Collections.Generic.IEnumerable<System.String> <TitleLocalizationArgs>k__BackingField; // 0x68
	private string <TitleLocalizationKey>k__BackingField; // 0x70

	// Methods

	// RVA: 0x79F928
	internal static FirebaseNotification FromInternal(FirebaseNotificationInternal other) { }

	// RVA: 0x7A16E0
	private void set_Android(AndroidNotificationParams value) { }

	// RVA: 0x7A16E8
	private void set_Badge(string value) { }

	// RVA: 0x7A16F0
	private void set_Body(string value) { }

	// RVA: 0x7A16F8
	private void set_BodyLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7A1700
	private void set_BodyLocalizationKey(string value) { }

	// RVA: 0x7A1708
	private void set_ClickAction(string value) { }

	// RVA: 0x7A1710
	private void set_Color(string value) { }

	// RVA: 0x7A1718
	private void set_Icon(string value) { }

	// RVA: 0x7A1720
	private void set_Sound(string value) { }

	// RVA: 0x7A1728
	private void set_Tag(string value) { }

	// RVA: 0x7A1730
	private void set_Title(string value) { }

	// RVA: 0x7A1738
	private void set_TitleLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7A1740
	private void set_TitleLocalizationKey(string value) { }

	// RVA: 0x7A0A30
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class MessageReceivedEventArgs
{
	// Fields
	private FirebaseMessage <Message>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A1748
	public void .ctor(FirebaseMessage msg) { }

	// RVA: 0x7A17C0
	public FirebaseMessage get_Message() { }

	// RVA: 0x7A17C8
	public void set_Message(FirebaseMessage value) { }

}

// Namespace: Firebase.Messaging
public sealed class TokenReceivedEventArgs
{
	// Fields
	private string <Token>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7A17D0
	public void .ctor(string token) { }

	// RVA: 0x7A1848
	public string get_Token() { }

	// RVA: 0x7A1850
	public void set_Token(string value) { }

}

// Namespace: Firebase.Messaging
internal class AndroidNotificationParamsInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7A1858
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7A18C4
	protected override void Finalize() { }

	// RVA: 0x7A1960
	public void Dispose() { }

	// RVA: 0x7A19F0
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7A0944
	public string get_channel_id() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7A1BF4
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7A1C60
	protected override void Finalize() { }

	// RVA: 0x7A1CFC
	public void Dispose() { }

	// RVA: 0x7A1D8C
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7A13E8
	public string get_title() { }

	// RVA: 0x7A0C7C
	public string get_body() { }

	// RVA: 0x7A113C
	public string get_icon() { }

	// RVA: 0x7A1220
	public string get_sound() { }

	// RVA: 0x7A0B98
	public string get_badge() { }

	// RVA: 0x7A1304
	public string get_tag() { }

	// RVA: 0x7A1058
	public string get_color() { }

	// RVA: 0x7A0F74
	public string get_click_action() { }

	// RVA: 0x7A0E90
	public string get_body_loc_key() { }

	// RVA: 0x7A0D60
	public System.Collections.Generic.IEnumerable<System.String> get_body_loc_args() { }

	// RVA: 0x7A15FC
	public string get_title_loc_key() { }

	// RVA: 0x7A14CC
	public System.Collections.Generic.IEnumerable<System.String> get_title_loc_args() { }

	// RVA: 0x7A0A38
	internal AndroidNotificationParamsInternal get_android() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7A21A0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7A220C
	protected override void Finalize() { }

	// RVA: 0x7A22A8
	public void Dispose() { }

	// RVA: 0x7A2338
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x79F438
	public string get_from() { }

	// RVA: 0x79FFF4
	public string get_to() { }

	// RVA: 0x79F05C
	public string get_collapse_key() { }

	// RVA: 0x79F140
	public System.Collections.Generic.IDictionary<System.String,System.String> get_data() { }

	// RVA: 0x79FDB4
	public CharVector get_raw_data() { }

	// RVA: 0x79F600
	public string get_message_id() { }

	// RVA: 0x79F6E4
	public string get_message_type() { }

	// RVA: 0x79FCD0
	public string get_priority() { }

	// RVA: 0x79FEE4
	public int get_time_to_live() { }

	// RVA: 0x79F270
	public string get_error() { }

	// RVA: 0x79F354
	public string get_error_description() { }

	// RVA: 0x79F7C8
	internal FirebaseNotificationInternal get_notification() { }

	// RVA: 0x79FBBC
	public bool get_notification_opened() { }

	// RVA: 0x79F51C
	public string get_link() { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7A4124
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A4294
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7A41D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A42A8
	public virtual void Invoke(string message, string paramName) { }

}

// Namespace: 
protected class SWIGExceptionHelper
{
	// Fields
	private static ExceptionDelegate applicationDelegate; // 0x0
	private static ExceptionDelegate arithmeticDelegate; // 0x8
	private static ExceptionDelegate divideByZeroDelegate; // 0x10
	private static ExceptionDelegate indexOutOfRangeDelegate; // 0x18
	private static ExceptionDelegate invalidCastDelegate; // 0x20
	private static ExceptionDelegate invalidOperationDelegate; // 0x28
	private static ExceptionDelegate ioDelegate; // 0x30
	private static ExceptionDelegate nullReferenceDelegate; // 0x38
	private static ExceptionDelegate outOfMemoryDelegate; // 0x40
	private static ExceptionDelegate overflowDelegate; // 0x48
	private static ExceptionDelegate systemDelegate; // 0x50
	private static ExceptionArgumentDelegate argumentDelegate; // 0x58
	private static ExceptionArgumentDelegate argumentNullDelegate; // 0x60
	private static ExceptionArgumentDelegate argumentOutOfRangeDelegate; // 0x68

	// Methods

	// RVA: 0x7A31BC
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7A32C4
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7A284C
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7A28E4
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7A297C
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7A2A14
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7A2AAC
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7A2B44
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7A2BDC
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7A2C74
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7A2D0C
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7A2DA4
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7A2E3C
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7A2ED4
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7A2F74
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7A3098
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7A370C
	private static void .cctor() { }

	// RVA: 0x7A2800
	public void .ctor() { }

}

// Namespace: 
public class SWIGPendingException
{
	// Fields
	private static Exception pendingException; // 0xFFFFFFFF
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x7A34E4
	public static void Set(Exception e) { }

	// RVA: 0x7A3314
	public static Exception Retrieve() { }

	// RVA: 0x7A42BC
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7A44C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A4574
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7A4374
	internal static extern void SWIGRegisterStringCallback_FirebaseMessagingInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7A4370
	private static string CreateString(string cString) { }

	// RVA: 0x7A4388
	private static void .cctor() { }

	// RVA: 0x7A2808
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7A273C
	private static void .cctor() { }

	// RVA: 0x7A1BBC
	public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x7A1BB4
	internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x7A1F50
	internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x7A1F58
	public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x7A1F90
	public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x7A1FC8
	public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x7A2000
	public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x7A2038
	public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x7A2070
	public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x7A20A8
	public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x7A20E0
	public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x7A2118
	public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7A2150
	public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7A2158
	public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7A2190
	public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7A2198
	public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x7A24FC
	internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x7A2504
	public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x7A253C
	public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x7A2574
	public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x7A25AC
	public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x7A25B4
	public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x7A25BC
	public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x7A25F4
	public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x7A262C
	public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x7A2664
	public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x7A266C
	public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x7A26A4
	public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x7A26DC
	public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x7A26E4
	public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x7A2704
	public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x7A2810
	public static extern void SetListenerCallbacks(MessageReceivedDelegate jarg1, TokenReceivedDelegate jarg2) { }

	// RVA: 0x7A2844
	public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x7A2848
	public static extern void SendPendingEvents() { }

}

// Namespace: 
internal sealed class MessageReceivedDelegate
{
	// Methods

	// RVA: 0x7A5728
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A5920
	public virtual bool Invoke(IntPtr message) { }

}

// Namespace: 
internal sealed class TokenReceivedDelegate
{
	// Methods

	// RVA: 0x7A57CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7A5934
	public virtual void Invoke(string token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public IntPtr message; // 0x10
	public bool tookOwnership; // 0x18

	// Methods

	// RVA: 0x7A5910
	public void .ctor() { }

	// RVA: 0x7A5948
	internal bool <MessageReceivedDelegateMethod>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public string token; // 0x10

	// Methods

	// RVA: 0x7A5918
	public void .ctor() { }

	// RVA: 0x7A5B40
	internal void <TokenReceivedDelegateMethod>b__0() { }

}

// Namespace: 
internal class Listener
{
	// Fields
	private MessageReceivedDelegate messageReceivedDelegate; // 0x10
	private TokenReceivedDelegate tokenReceivedDelegate; // 0x18
	private FirebaseApp app; // 0x20
	private static Listener listener; // 0x0

	// Methods

	// RVA: 0x7A4B98
	internal static Listener Create() { }

	// RVA: 0x7A4D2C
	internal static void Destroy() { }

	// RVA: 0x7A5350
	private void .ctor() { }

	// RVA: 0x7A5880
	protected override void Finalize() { }

	// RVA: 0x7A5580
	public void Dispose() { }

	// RVA: 0x7A519C
	private static bool MessageReceivedDelegateMethod(IntPtr message) { }

	// RVA: 0x7A528C
	private static void TokenReceivedDelegateMethod(string token) { }

}

// Namespace: Firebase.Messaging
internal sealed class FirebaseMessagingInternal
{
	// Fields
	private static System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> MessageReceivedInternal; // 0x0
	private static System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> TokenReceivedInternal; // 0x8
	private static Listener listener; // 0x10

	// Methods

	// RVA: 0x7A4588
	internal static void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A4698
	internal static void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A47A8
	internal static void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7A48BC
	internal static void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7A49D0
	internal static void CreateOrDestroyListener() { }

	// RVA: 0x7A5064
	private static void .cctor() { }

	// RVA: 0x7A01D8
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A03AC
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7A0580
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7A0754
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7A50B8
	private static void SetListenerCallbacks(MessageReceivedDelegate messageCallback, TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x7A4E74
	private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x7A4F7C
	private static void SendPendingEvents() { }

}


