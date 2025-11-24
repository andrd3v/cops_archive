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

	// RVA: 0x7C49E8
	internal static FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	// RVA: 0x7C5D30
	private void set_CollapseKey(string value) { }

	// RVA: 0x7C5D38
	private void set_Data(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7C5D40
	private void set_Error(string value) { }

	// RVA: 0x7C5D48
	private void set_ErrorDescription(string value) { }

	// RVA: 0x7C5D50
	private void set_From(string value) { }

	// RVA: 0x7C5D58
	private void set_Link(Uri value) { }

	// RVA: 0x7C5D60
	private void set_MessageId(string value) { }

	// RVA: 0x7C5D68
	private void set_MessageType(string value) { }

	// RVA: 0x7C5D70
	private void set_Notification(FirebaseNotification value) { }

	// RVA: 0x7C5D78
	private void set_NotificationOpened(bool value) { }

	// RVA: 0x7C5D80
	private void set_Priority(string value) { }

	// RVA: 0x7C5D88
	public Byte[] get_RawData() { }

	// RVA: 0x7C5D90
	private void set_RawData(Byte[] value) { }

	// RVA: 0x7C5D98
	private void set_TimeToLive(TimeSpan value) { }

	// RVA: 0x7C5DA0
	private void set_To(string value) { }

	// RVA: 0x7C4CAC
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public static class FirebaseMessaging
{
	// Methods

	// RVA: 0x7C5DA8
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7C5F7C
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7C6150
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7C6324
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

}

// Namespace: Firebase.Messaging
public sealed class AndroidNotificationParams
{
	// Fields
	private string <ChannelId>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7C64F8
	internal static AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other) { }

	// RVA: 0x7C6678
	private void set_ChannelId(string value) { }

	// RVA: 0x7C658C
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

	// RVA: 0x7C5580
	internal static FirebaseNotification FromInternal(FirebaseNotificationInternal other) { }

	// RVA: 0x7C7330
	private void set_Android(AndroidNotificationParams value) { }

	// RVA: 0x7C7338
	private void set_Badge(string value) { }

	// RVA: 0x7C7340
	private void set_Body(string value) { }

	// RVA: 0x7C7348
	private void set_BodyLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7C7350
	private void set_BodyLocalizationKey(string value) { }

	// RVA: 0x7C7358
	private void set_ClickAction(string value) { }

	// RVA: 0x7C7360
	private void set_Color(string value) { }

	// RVA: 0x7C7368
	private void set_Icon(string value) { }

	// RVA: 0x7C7370
	private void set_Sound(string value) { }

	// RVA: 0x7C7378
	private void set_Tag(string value) { }

	// RVA: 0x7C7380
	private void set_Title(string value) { }

	// RVA: 0x7C7388
	private void set_TitleLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7C7390
	private void set_TitleLocalizationKey(string value) { }

	// RVA: 0x7C6680
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class MessageReceivedEventArgs
{
	// Fields
	private FirebaseMessage <Message>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7C7398
	public void .ctor(FirebaseMessage msg) { }

	// RVA: 0x7C7410
	public void set_Message(FirebaseMessage value) { }

}

// Namespace: Firebase.Messaging
public sealed class TokenReceivedEventArgs
{
	// Fields
	private string <Token>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7C7418
	public void .ctor(string token) { }

	// RVA: 0x7C7490
	public void set_Token(string value) { }

}

// Namespace: Firebase.Messaging
internal class AndroidNotificationParamsInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7C7498
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7C7504
	protected override void Finalize() { }

	// RVA: 0x7C75A0
	public void Dispose() { }

	// RVA: 0x7C7630
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7C6594
	public string get_channel_id() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7C7834
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7C78A0
	protected override void Finalize() { }

	// RVA: 0x7C793C
	public void Dispose() { }

	// RVA: 0x7C79CC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7C7038
	public string get_title() { }

	// RVA: 0x7C68CC
	public string get_body() { }

	// RVA: 0x7C6D8C
	public string get_icon() { }

	// RVA: 0x7C6E70
	public string get_sound() { }

	// RVA: 0x7C67E8
	public string get_badge() { }

	// RVA: 0x7C6F54
	public string get_tag() { }

	// RVA: 0x7C6CA8
	public string get_color() { }

	// RVA: 0x7C6BC4
	public string get_click_action() { }

	// RVA: 0x7C6AE0
	public string get_body_loc_key() { }

	// RVA: 0x7C69B0
	public System.Collections.Generic.IEnumerable<System.String> get_body_loc_args() { }

	// RVA: 0x7C724C
	public string get_title_loc_key() { }

	// RVA: 0x7C711C
	public System.Collections.Generic.IEnumerable<System.String> get_title_loc_args() { }

	// RVA: 0x7C6688
	internal AndroidNotificationParamsInternal get_android() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7C7DE0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7C7E4C
	protected override void Finalize() { }

	// RVA: 0x7C7EE8
	public void Dispose() { }

	// RVA: 0x7C7F78
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7C5090
	public string get_from() { }

	// RVA: 0x7C5C4C
	public string get_to() { }

	// RVA: 0x7C4CB4
	public string get_collapse_key() { }

	// RVA: 0x7C4D98
	public System.Collections.Generic.IDictionary<System.String,System.String> get_data() { }

	// RVA: 0x7C5A0C
	public CharVector get_raw_data() { }

	// RVA: 0x7C5258
	public string get_message_id() { }

	// RVA: 0x7C533C
	public string get_message_type() { }

	// RVA: 0x7C5928
	public string get_priority() { }

	// RVA: 0x7C5B3C
	public int get_time_to_live() { }

	// RVA: 0x7C4EC8
	public string get_error() { }

	// RVA: 0x7C4FAC
	public string get_error_description() { }

	// RVA: 0x7C5420
	internal FirebaseNotificationInternal get_notification() { }

	// RVA: 0x7C5814
	public bool get_notification_opened() { }

	// RVA: 0x7C5174
	public string get_link() { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7C9D64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7C9ED4
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7C9E18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7C9EE8
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

	// RVA: 0x7C8DFC
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7C8F04
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7C848C
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7C8524
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7C85BC
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7C8654
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7C86EC
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7C8784
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7C881C
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7C88B4
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7C894C
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7C89E4
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7C8A7C
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7C8B14
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7C8BB4
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7C8CD8
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7C934C
	private static void .cctor() { }

	// RVA: 0x7C8440
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

	// RVA: 0x7C9124
	public static void Set(Exception e) { }

	// RVA: 0x7C8F54
	public static Exception Retrieve() { }

	// RVA: 0x7C9EFC
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7CA100
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CA1B4
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7C9FB4
	internal static extern void SWIGRegisterStringCallback_FirebaseMessagingInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7C9FB0
	private static string CreateString(string cString) { }

	// RVA: 0x7C9FC8
	private static void .cctor() { }

	// RVA: 0x7C8448
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7C837C
	private static void .cctor() { }

	// RVA: 0x7C77FC
	public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x7C77F4
	internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x7C7B90
	internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x7C7B98
	public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x7C7BD0
	public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x7C7C08
	public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x7C7C40
	public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x7C7C78
	public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x7C7CB0
	public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x7C7CE8
	public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x7C7D20
	public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x7C7D58
	public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7C7D90
	public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7C7D98
	public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7C7DD0
	public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7C7DD8
	public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x7C813C
	internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x7C8144
	public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x7C817C
	public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x7C81B4
	public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x7C81EC
	public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x7C81F4
	public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x7C81FC
	public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x7C8234
	public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x7C826C
	public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x7C82A4
	public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x7C82AC
	public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x7C82E4
	public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x7C831C
	public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x7C8324
	public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x7C8344
	public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x7C8450
	public static extern void SetListenerCallbacks(MessageReceivedDelegate jarg1, TokenReceivedDelegate jarg2) { }

	// RVA: 0x7C8484
	public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x7C8488
	public static extern void SendPendingEvents() { }

}

// Namespace: 
internal sealed class MessageReceivedDelegate
{
	// Methods

	// RVA: 0x7CB368
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CB560
	public virtual bool Invoke(IntPtr message) { }

}

// Namespace: 
internal sealed class TokenReceivedDelegate
{
	// Methods

	// RVA: 0x7CB40C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CB574
	public virtual void Invoke(string token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public IntPtr message; // 0x10
	public bool tookOwnership; // 0x18

	// Methods

	// RVA: 0x7CB550
	public void .ctor() { }

	// RVA: 0x7CB588
	internal bool <MessageReceivedDelegateMethod>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public string token; // 0x10

	// Methods

	// RVA: 0x7CB558
	public void .ctor() { }

	// RVA: 0x7CB780
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

	// RVA: 0x7CA7D8
	internal static Listener Create() { }

	// RVA: 0x7CA96C
	internal static void Destroy() { }

	// RVA: 0x7CAF90
	private void .ctor() { }

	// RVA: 0x7CB4C0
	protected override void Finalize() { }

	// RVA: 0x7CB1C0
	public void Dispose() { }

	// RVA: 0x7CADDC
	private static bool MessageReceivedDelegateMethod(IntPtr message) { }

	// RVA: 0x7CAECC
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

	// RVA: 0x7CA1C8
	internal static void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7CA2D8
	internal static void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7CA3E8
	internal static void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7CA4FC
	internal static void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7CA610
	internal static void CreateOrDestroyListener() { }

	// RVA: 0x7CACA4
	private static void .cctor() { }

	// RVA: 0x7C5E28
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7C5FFC
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7C61D0
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7C63A4
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7CACF8
	private static void SetListenerCallbacks(MessageReceivedDelegate messageCallback, TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x7CAAB4
	private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x7CABBC
	private static void SendPendingEvents() { }

}


