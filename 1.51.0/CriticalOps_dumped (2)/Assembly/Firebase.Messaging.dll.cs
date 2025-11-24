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

	// RVA: 0x7E86AC
	internal static FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	// RVA: 0x7E9A24
	private void set_CollapseKey(string value) { }

	// RVA: 0x7E9A2C
	private void set_Data(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7E9A34
	private void set_Error(string value) { }

	// RVA: 0x7E9A3C
	private void set_ErrorDescription(string value) { }

	// RVA: 0x7E9A44
	private void set_From(string value) { }

	// RVA: 0x7E9A4C
	private void set_Link(Uri value) { }

	// RVA: 0x7E9A54
	private void set_MessageId(string value) { }

	// RVA: 0x7E9A5C
	private void set_MessageType(string value) { }

	// RVA: 0x7E9A64
	private void set_Notification(FirebaseNotification value) { }

	// RVA: 0x7E9A6C
	private void set_NotificationOpened(bool value) { }

	// RVA: 0x7E9A74
	private void set_Priority(string value) { }

	// RVA: 0x7E9A7C
	public Byte[] get_RawData() { }

	// RVA: 0x7E9A84
	private void set_RawData(Byte[] value) { }

	// RVA: 0x7E9A8C
	private void set_TimeToLive(TimeSpan value) { }

	// RVA: 0x7E9A94
	private void set_To(string value) { }

	// RVA: 0x7E8970
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public static class FirebaseMessaging
{
	// Methods

	// RVA: 0x7E9A9C
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7E9C64
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7E9E2C
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7E9FF4
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

}

// Namespace: Firebase.Messaging
public sealed class AndroidNotificationParams
{
	// Fields
	private string <ChannelId>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7EA1BC
	internal static AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other) { }

	// RVA: 0x7EA33C
	private void set_ChannelId(string value) { }

	// RVA: 0x7EA250
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

	// RVA: 0x7E9264
	internal static FirebaseNotification FromInternal(FirebaseNotificationInternal other) { }

	// RVA: 0x7EB024
	private void set_Android(AndroidNotificationParams value) { }

	// RVA: 0x7EB02C
	private void set_Badge(string value) { }

	// RVA: 0x7EB034
	private void set_Body(string value) { }

	// RVA: 0x7EB03C
	private void set_BodyLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7EB044
	private void set_BodyLocalizationKey(string value) { }

	// RVA: 0x7EB04C
	private void set_ClickAction(string value) { }

	// RVA: 0x7EB054
	private void set_Color(string value) { }

	// RVA: 0x7EB05C
	private void set_Icon(string value) { }

	// RVA: 0x7EB064
	private void set_Sound(string value) { }

	// RVA: 0x7EB06C
	private void set_Tag(string value) { }

	// RVA: 0x7EB074
	private void set_Title(string value) { }

	// RVA: 0x7EB07C
	private void set_TitleLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7EB084
	private void set_TitleLocalizationKey(string value) { }

	// RVA: 0x7EA344
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class MessageReceivedEventArgs
{
	// Fields
	private FirebaseMessage <Message>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7EB08C
	public void .ctor(FirebaseMessage msg) { }

	// RVA: 0x7EB104
	public void set_Message(FirebaseMessage value) { }

}

// Namespace: Firebase.Messaging
public sealed class TokenReceivedEventArgs
{
	// Fields
	private string <Token>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7EB10C
	public void .ctor(string token) { }

	// RVA: 0x7EB184
	public void set_Token(string value) { }

}

// Namespace: Firebase.Messaging
internal class AndroidNotificationParamsInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7EB18C
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7EB1F8
	protected override void Finalize() { }

	// RVA: 0x7EB294
	public void Dispose() { }

	// RVA: 0x7EB324
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7EA258
	public string get_channel_id() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7EB514
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7EB580
	protected override void Finalize() { }

	// RVA: 0x7EB61C
	public void Dispose() { }

	// RVA: 0x7EB6AC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7EAD1C
	public string get_title() { }

	// RVA: 0x7EA5A0
	public string get_body() { }

	// RVA: 0x7EAA70
	public string get_icon() { }

	// RVA: 0x7EAB54
	public string get_sound() { }

	// RVA: 0x7EA4BC
	public string get_badge() { }

	// RVA: 0x7EAC38
	public string get_tag() { }

	// RVA: 0x7EA98C
	public string get_color() { }

	// RVA: 0x7EA8A8
	public string get_click_action() { }

	// RVA: 0x7EA7C4
	public string get_body_loc_key() { }

	// RVA: 0x7EA684
	public System.Collections.Generic.IEnumerable<System.String> get_body_loc_args() { }

	// RVA: 0x7EAF40
	public string get_title_loc_key() { }

	// RVA: 0x7EAE00
	public System.Collections.Generic.IEnumerable<System.String> get_title_loc_args() { }

	// RVA: 0x7EA34C
	internal AndroidNotificationParamsInternal get_android() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7EBAAC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7EBB18
	protected override void Finalize() { }

	// RVA: 0x7EBBB4
	public void Dispose() { }

	// RVA: 0x7EBC44
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7E8D64
	public string get_from() { }

	// RVA: 0x7E9940
	public string get_to() { }

	// RVA: 0x7E8978
	public string get_collapse_key() { }

	// RVA: 0x7E8A5C
	public System.Collections.Generic.IDictionary<System.String,System.String> get_data() { }

	// RVA: 0x7E96F0
	public CharVector get_raw_data() { }

	// RVA: 0x7E8F2C
	public string get_message_id() { }

	// RVA: 0x7E9010
	public string get_message_type() { }

	// RVA: 0x7E960C
	public string get_priority() { }

	// RVA: 0x7E9830
	public int get_time_to_live() { }

	// RVA: 0x7E8B9C
	public string get_error() { }

	// RVA: 0x7E8C80
	public string get_error_description() { }

	// RVA: 0x7E90F4
	internal FirebaseNotificationInternal get_notification() { }

	// RVA: 0x7E94F8
	public bool get_notification_opened() { }

	// RVA: 0x7E8E48
	public string get_link() { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7EDA1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EDB8C
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7EDAD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EDBA0
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

	// RVA: 0x7ECAB4
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7ECBBC
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7EC144
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7EC1DC
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7EC274
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7EC30C
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7EC3A4
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7EC43C
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7EC4D4
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7EC56C
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7EC604
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7EC69C
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7EC734
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7EC7CC
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7EC86C
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7EC990
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7ED004
	private static void .cctor() { }

	// RVA: 0x7EC0F8
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

	// RVA: 0x7ECDDC
	public static void Set(Exception e) { }

	// RVA: 0x7ECC0C
	public static Exception Retrieve() { }

	// RVA: 0x7EDBB4
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7EDDB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EDE6C
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7EDC6C
	internal static extern void SWIGRegisterStringCallback_FirebaseMessagingInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7EDC68
	private static string CreateString(string cString) { }

	// RVA: 0x7EDC80
	private static void .cctor() { }

	// RVA: 0x7EC100
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7EC034
	private static void .cctor() { }

	// RVA: 0x7EB4DC
	public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x7EB4D4
	internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x7EB85C
	internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x7EB864
	public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x7EB89C
	public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x7EB8D4
	public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x7EB90C
	public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x7EB944
	public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x7EB97C
	public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x7EB9B4
	public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x7EB9EC
	public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x7EBA24
	public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7EBA5C
	public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7EBA64
	public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7EBA9C
	public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7EBAA4
	public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x7EBDF4
	internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x7EBDFC
	public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x7EBE34
	public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x7EBE6C
	public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x7EBEA4
	public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x7EBEAC
	public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x7EBEB4
	public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x7EBEEC
	public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x7EBF24
	public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x7EBF5C
	public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x7EBF64
	public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x7EBF9C
	public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x7EBFD4
	public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x7EBFDC
	public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x7EBFFC
	public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x7EC108
	public static extern void SetListenerCallbacks(MessageReceivedDelegate jarg1, TokenReceivedDelegate jarg2) { }

	// RVA: 0x7EC13C
	public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x7EC140
	public static extern void SendPendingEvents() { }

}

// Namespace: 
internal sealed class MessageReceivedDelegate
{
	// Methods

	// RVA: 0x7EEFE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EF1E0
	public virtual bool Invoke(IntPtr message) { }

}

// Namespace: 
internal sealed class TokenReceivedDelegate
{
	// Methods

	// RVA: 0x7EF08C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7EF1F4
	public virtual void Invoke(string token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public IntPtr message; // 0x10
	public bool tookOwnership; // 0x18

	// Methods

	// RVA: 0x7EF1D0
	public void .ctor() { }

	// RVA: 0x7EF208
	internal bool <MessageReceivedDelegateMethod>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public string token; // 0x10

	// Methods

	// RVA: 0x7EF1D8
	public void .ctor() { }

	// RVA: 0x7EF400
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

	// RVA: 0x7EE484
	internal static Listener Create() { }

	// RVA: 0x7EE60C
	internal static void Destroy() { }

	// RVA: 0x7EEC1C
	private void .ctor() { }

	// RVA: 0x7EF140
	protected override void Finalize() { }

	// RVA: 0x7EEE4C
	public void Dispose() { }

	// RVA: 0x7EEA68
	private static bool MessageReceivedDelegateMethod(IntPtr message) { }

	// RVA: 0x7EEB58
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

	// RVA: 0x7EDE80
	internal static void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7EDF90
	internal static void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7EE0A0
	internal static void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7EE1B4
	internal static void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7EE2C8
	internal static void CreateOrDestroyListener() { }

	// RVA: 0x7EE930
	private static void .cctor() { }

	// RVA: 0x7E9B1C
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7E9CE4
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7E9EAC
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7EA074
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7EE984
	private static void SetListenerCallbacks(MessageReceivedDelegate messageCallback, TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x7EE740
	private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x7EE848
	private static void SendPendingEvents() { }

}


