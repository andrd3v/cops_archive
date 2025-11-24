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

	// RVA: 0x7ADE70
	internal static FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	// RVA: 0x7AF1B8
	private void set_CollapseKey(string value) { }

	// RVA: 0x7AF1C0
	private void set_Data(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x7AF1C8
	private void set_Error(string value) { }

	// RVA: 0x7AF1D0
	private void set_ErrorDescription(string value) { }

	// RVA: 0x7AF1D8
	private void set_From(string value) { }

	// RVA: 0x7AF1E0
	private void set_Link(Uri value) { }

	// RVA: 0x7AF1E8
	private void set_MessageId(string value) { }

	// RVA: 0x7AF1F0
	private void set_MessageType(string value) { }

	// RVA: 0x7AF1F8
	private void set_Notification(FirebaseNotification value) { }

	// RVA: 0x7AF200
	private void set_NotificationOpened(bool value) { }

	// RVA: 0x7AF208
	private void set_Priority(string value) { }

	// RVA: 0x7AF210
	public Byte[] get_RawData() { }

	// RVA: 0x7AF218
	private void set_RawData(Byte[] value) { }

	// RVA: 0x7AF220
	private void set_TimeToLive(TimeSpan value) { }

	// RVA: 0x7AF228
	private void set_To(string value) { }

	// RVA: 0x7AE134
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public static class FirebaseMessaging
{
	// Methods

	// RVA: 0x7AF230
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7AF404
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7AF5D8
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7AF7AC
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

}

// Namespace: Firebase.Messaging
public sealed class AndroidNotificationParams
{
	// Fields
	private string <ChannelId>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7AF980
	internal static AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other) { }

	// RVA: 0x7AFB00
	private void set_ChannelId(string value) { }

	// RVA: 0x7AFA14
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

	// RVA: 0x7AEA08
	internal static FirebaseNotification FromInternal(FirebaseNotificationInternal other) { }

	// RVA: 0x7B07B8
	private void set_Android(AndroidNotificationParams value) { }

	// RVA: 0x7B07C0
	private void set_Badge(string value) { }

	// RVA: 0x7B07C8
	private void set_Body(string value) { }

	// RVA: 0x7B07D0
	private void set_BodyLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7B07D8
	private void set_BodyLocalizationKey(string value) { }

	// RVA: 0x7B07E0
	private void set_ClickAction(string value) { }

	// RVA: 0x7B07E8
	private void set_Color(string value) { }

	// RVA: 0x7B07F0
	private void set_Icon(string value) { }

	// RVA: 0x7B07F8
	private void set_Sound(string value) { }

	// RVA: 0x7B0800
	private void set_Tag(string value) { }

	// RVA: 0x7B0808
	private void set_Title(string value) { }

	// RVA: 0x7B0810
	private void set_TitleLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7B0818
	private void set_TitleLocalizationKey(string value) { }

	// RVA: 0x7AFB08
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class MessageReceivedEventArgs
{
	// Fields
	private FirebaseMessage <Message>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7B0820
	public void .ctor(FirebaseMessage msg) { }

	// RVA: 0x7B0898
	public void set_Message(FirebaseMessage value) { }

}

// Namespace: Firebase.Messaging
public sealed class TokenReceivedEventArgs
{
	// Fields
	private string <Token>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7B08A0
	public void .ctor(string token) { }

	// RVA: 0x7B0918
	public void set_Token(string value) { }

}

// Namespace: Firebase.Messaging
internal class AndroidNotificationParamsInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B0920
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B098C
	protected override void Finalize() { }

	// RVA: 0x7B0A28
	public void Dispose() { }

	// RVA: 0x7B0AB8
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7AFA1C
	public string get_channel_id() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B0CBC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B0D28
	protected override void Finalize() { }

	// RVA: 0x7B0DC4
	public void Dispose() { }

	// RVA: 0x7B0E54
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7B04C0
	public string get_title() { }

	// RVA: 0x7AFD54
	public string get_body() { }

	// RVA: 0x7B0214
	public string get_icon() { }

	// RVA: 0x7B02F8
	public string get_sound() { }

	// RVA: 0x7AFC70
	public string get_badge() { }

	// RVA: 0x7B03DC
	public string get_tag() { }

	// RVA: 0x7B0130
	public string get_color() { }

	// RVA: 0x7B004C
	public string get_click_action() { }

	// RVA: 0x7AFF68
	public string get_body_loc_key() { }

	// RVA: 0x7AFE38
	public System.Collections.Generic.IEnumerable<System.String> get_body_loc_args() { }

	// RVA: 0x7B06D4
	public string get_title_loc_key() { }

	// RVA: 0x7B05A4
	public System.Collections.Generic.IEnumerable<System.String> get_title_loc_args() { }

	// RVA: 0x7AFB10
	internal AndroidNotificationParamsInternal get_android() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7B1268
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7B12D4
	protected override void Finalize() { }

	// RVA: 0x7B1370
	public void Dispose() { }

	// RVA: 0x7B1400
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7AE518
	public string get_from() { }

	// RVA: 0x7AF0D4
	public string get_to() { }

	// RVA: 0x7AE13C
	public string get_collapse_key() { }

	// RVA: 0x7AE220
	public System.Collections.Generic.IDictionary<System.String,System.String> get_data() { }

	// RVA: 0x7AEE94
	public CharVector get_raw_data() { }

	// RVA: 0x7AE6E0
	public string get_message_id() { }

	// RVA: 0x7AE7C4
	public string get_message_type() { }

	// RVA: 0x7AEDB0
	public string get_priority() { }

	// RVA: 0x7AEFC4
	public int get_time_to_live() { }

	// RVA: 0x7AE350
	public string get_error() { }

	// RVA: 0x7AE434
	public string get_error_description() { }

	// RVA: 0x7AE8A8
	internal FirebaseNotificationInternal get_notification() { }

	// RVA: 0x7AEC9C
	public bool get_notification_opened() { }

	// RVA: 0x7AE5FC
	public string get_link() { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7B31EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B335C
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7B32A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B3370
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

	// RVA: 0x7B2284
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7B238C
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7B1914
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7B19AC
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7B1A44
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7B1ADC
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7B1B74
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7B1C0C
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7B1CA4
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7B1D3C
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7B1DD4
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7B1E6C
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7B1F04
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7B1F9C
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7B203C
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7B2160
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7B27D4
	private static void .cctor() { }

	// RVA: 0x7B18C8
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

	// RVA: 0x7B25AC
	public static void Set(Exception e) { }

	// RVA: 0x7B23DC
	public static Exception Retrieve() { }

	// RVA: 0x7B3384
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7B3588
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B363C
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7B343C
	internal static extern void SWIGRegisterStringCallback_FirebaseMessagingInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7B3438
	private static string CreateString(string cString) { }

	// RVA: 0x7B3450
	private static void .cctor() { }

	// RVA: 0x7B18D0
	public void .ctor() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7B1804
	private static void .cctor() { }

	// RVA: 0x7B0C84
	public static extern string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x7B0C7C
	internal static extern void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x7B1018
	internal static extern void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x7B1020
	public static extern string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x7B1058
	public static extern string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x7B1090
	public static extern string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x7B10C8
	public static extern string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x7B1100
	public static extern string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x7B1138
	public static extern string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x7B1170
	public static extern string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x7B11A8
	public static extern string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x7B11E0
	public static extern string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7B1218
	public static extern IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7B1220
	public static extern string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x7B1258
	public static extern IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x7B1260
	public static extern IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x7B15C4
	internal static extern void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x7B15CC
	public static extern string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x7B1604
	public static extern string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x7B163C
	public static extern string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x7B1674
	public static extern IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x7B167C
	public static extern IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x7B1684
	public static extern string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x7B16BC
	public static extern string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x7B16F4
	public static extern string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x7B172C
	public static extern int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x7B1734
	public static extern string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x7B176C
	public static extern string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x7B17A4
	public static extern IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x7B17AC
	public static extern bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x7B17CC
	public static extern string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x7B18D8
	public static extern void SetListenerCallbacks(MessageReceivedDelegate jarg1, TokenReceivedDelegate jarg2) { }

	// RVA: 0x7B190C
	public static extern void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x7B1910
	public static extern void SendPendingEvents() { }

}

// Namespace: 
internal sealed class MessageReceivedDelegate
{
	// Methods

	// RVA: 0x7B47F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B49E8
	public virtual bool Invoke(IntPtr message) { }

}

// Namespace: 
internal sealed class TokenReceivedDelegate
{
	// Methods

	// RVA: 0x7B4894
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7B49FC
	public virtual void Invoke(string token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public IntPtr message; // 0x10
	public bool tookOwnership; // 0x18

	// Methods

	// RVA: 0x7B49D8
	public void .ctor() { }

	// RVA: 0x7B4A10
	internal bool <MessageReceivedDelegateMethod>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public string token; // 0x10

	// Methods

	// RVA: 0x7B49E0
	public void .ctor() { }

	// RVA: 0x7B4C08
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

	// RVA: 0x7B3C60
	internal static Listener Create() { }

	// RVA: 0x7B3DF4
	internal static void Destroy() { }

	// RVA: 0x7B4418
	private void .ctor() { }

	// RVA: 0x7B4948
	protected override void Finalize() { }

	// RVA: 0x7B4648
	public void Dispose() { }

	// RVA: 0x7B4264
	private static bool MessageReceivedDelegateMethod(IntPtr message) { }

	// RVA: 0x7B4354
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

	// RVA: 0x7B3650
	internal static void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7B3760
	internal static void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7B3870
	internal static void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7B3984
	internal static void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7B3A98
	internal static void CreateOrDestroyListener() { }

	// RVA: 0x7B412C
	private static void .cctor() { }

	// RVA: 0x7AF2B0
	public static void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7AF484
	public static void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7AF658
	public static void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7AF82C
	public static void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7B4180
	private static void SetListenerCallbacks(MessageReceivedDelegate messageCallback, TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x7B3F3C
	private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x7B4044
	private static void SendPendingEvents() { }

}


