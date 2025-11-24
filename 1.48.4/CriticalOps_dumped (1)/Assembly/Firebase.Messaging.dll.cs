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

	// RVA: 0x785B74
	FirebaseMessage FromInternal(FirebaseMessageInternal other) { }

	// RVA: 0x786EBC
	void set_CollapseKey(string value) { }

	// RVA: 0x786EC4
	System.Collections.Generic.IDictionary<System.String,System.String> get_Data() { }

	// RVA: 0x786ECC
	void set_Data(System.Collections.Generic.IDictionary<System.String,System.String> value) { }

	// RVA: 0x786ED4
	void set_Error(string value) { }

	// RVA: 0x786EDC
	void set_ErrorDescription(string value) { }

	// RVA: 0x786EE4
	void set_From(string value) { }

	// RVA: 0x786EEC
	void set_Link(Uri value) { }

	// RVA: 0x786EF4
	void set_MessageId(string value) { }

	// RVA: 0x786EFC
	void set_MessageType(string value) { }

	// RVA: 0x786F04
	void set_Notification(FirebaseNotification value) { }

	// RVA: 0x786F0C
	void set_NotificationOpened(bool value) { }

	// RVA: 0x786F14
	void set_Priority(string value) { }

	// RVA: 0x786F1C
	Byte[] get_RawData() { }

	// RVA: 0x786F24
	void set_RawData(Byte[] value) { }

	// RVA: 0x786F2C
	void set_TimeToLive(TimeSpan value) { }

	// RVA: 0x786F34
	void set_To(string value) { }

	// RVA: 0x785E38
	void .ctor() { }

}

// Namespace: Firebase.Messaging
public static class FirebaseMessaging 
{
	// Methods

	// RVA: 0x786F3C
	void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x787110
	void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x7872E4
	void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x7874B8
	void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

}

// Namespace: Firebase.Messaging
public sealed class AndroidNotificationParams 
{
	// Fields
	private string <ChannelId>k__BackingField; // 0x10

	// Methods

	// RVA: 0x78768C
	AndroidNotificationParams FromInternal(AndroidNotificationParamsInternal other) { }

	// RVA: 0x78780C
	void set_ChannelId(string value) { }

	// RVA: 0x787720
	void .ctor() { }

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

	// RVA: 0x78670C
	FirebaseNotification FromInternal(FirebaseNotificationInternal other) { }

	// RVA: 0x7884C4
	void set_Android(AndroidNotificationParams value) { }

	// RVA: 0x7884CC
	void set_Badge(string value) { }

	// RVA: 0x7884D4
	void set_Body(string value) { }

	// RVA: 0x7884DC
	void set_BodyLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x7884E4
	void set_BodyLocalizationKey(string value) { }

	// RVA: 0x7884EC
	void set_ClickAction(string value) { }

	// RVA: 0x7884F4
	void set_Color(string value) { }

	// RVA: 0x7884FC
	void set_Icon(string value) { }

	// RVA: 0x788504
	void set_Sound(string value) { }

	// RVA: 0x78850C
	void set_Tag(string value) { }

	// RVA: 0x788514
	void set_Title(string value) { }

	// RVA: 0x78851C
	void set_TitleLocalizationArgs(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x788524
	void set_TitleLocalizationKey(string value) { }

	// RVA: 0x787814
	void .ctor() { }

}

// Namespace: Firebase.Messaging
public sealed class MessageReceivedEventArgs 
{
	// Fields
	private FirebaseMessage <Message>k__BackingField; // 0x10

	// Methods

	// RVA: 0x78852C
	void .ctor(FirebaseMessage msg) { }

	// RVA: 0x7885A4
	FirebaseMessage get_Message() { }

	// RVA: 0x7885AC
	void set_Message(FirebaseMessage value) { }

}

// Namespace: Firebase.Messaging
public sealed class TokenReceivedEventArgs 
{
	// Fields
	private string <Token>k__BackingField; // 0x10

	// Methods

	// RVA: 0x7885B4
	void .ctor(string token) { }

	// RVA: 0x78862C
	string get_Token() { }

	// RVA: 0x788634
	void set_Token(string value) { }

}

// Namespace: Firebase.Messaging
internal class AndroidNotificationParamsInternal 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x78863C
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7886A8
	void Finalize() { }

	// RVA: 0x788744
	void Dispose() { }

	// RVA: 0x7887D4
	void Dispose(bool disposing) { }

	// RVA: 0x787728
	string get_channel_id() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseNotificationInternal 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7889D8
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x788A44
	void Finalize() { }

	// RVA: 0x788AE0
	void Dispose() { }

	// RVA: 0x788B70
	void Dispose(bool disposing) { }

	// RVA: 0x7881CC
	string get_title() { }

	// RVA: 0x787A60
	string get_body() { }

	// RVA: 0x787F20
	string get_icon() { }

	// RVA: 0x788004
	string get_sound() { }

	// RVA: 0x78797C
	string get_badge() { }

	// RVA: 0x7880E8
	string get_tag() { }

	// RVA: 0x787E3C
	string get_color() { }

	// RVA: 0x787D58
	string get_click_action() { }

	// RVA: 0x787C74
	string get_body_loc_key() { }

	// RVA: 0x787B44
	System.Collections.Generic.IEnumerable<System.String> get_body_loc_args() { }

	// RVA: 0x7883E0
	string get_title_loc_key() { }

	// RVA: 0x7882B0
	System.Collections.Generic.IEnumerable<System.String> get_title_loc_args() { }

	// RVA: 0x78781C
	AndroidNotificationParamsInternal get_android() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessageInternal 
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x788F84
	void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x788FF0
	void Finalize() { }

	// RVA: 0x78908C
	void Dispose() { }

	// RVA: 0x78911C
	void Dispose(bool disposing) { }

	// RVA: 0x78621C
	string get_from() { }

	// RVA: 0x786DD8
	string get_to() { }

	// RVA: 0x785E40
	string get_collapse_key() { }

	// RVA: 0x785F24
	System.Collections.Generic.IDictionary<System.String,System.String> get_data() { }

	// RVA: 0x786B98
	CharVector get_raw_data() { }

	// RVA: 0x7863E4
	string get_message_id() { }

	// RVA: 0x7864C8
	string get_message_type() { }

	// RVA: 0x786AB4
	string get_priority() { }

	// RVA: 0x786CC8
	int get_time_to_live() { }

	// RVA: 0x786054
	string get_error() { }

	// RVA: 0x786138
	string get_error_description() { }

	// RVA: 0x7865AC
	FirebaseNotificationInternal get_notification() { }

	// RVA: 0x7869A0
	bool get_notification_opened() { }

	// RVA: 0x786300
	string get_link() { }

}

// Namespace: 
public sealed class ExceptionDelegate 
{
	// Methods

	// RVA: 0x78AF08
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78B078
	internal void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate 
{
	// Methods

	// RVA: 0x78AFBC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78B08C
	internal void Invoke(string message, string paramName) { }

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

	// RVA: 0x789FA0
	void SWIGRegisterExceptionCallbacks_FirebaseMessagingInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x78A0A8
	void SWIGRegisterExceptionCallbacksArgument_FirebaseMessagingInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x789630
	void SetPendingApplicationException(string message) { }

	// RVA: 0x7896C8
	void SetPendingArithmeticException(string message) { }

	// RVA: 0x789760
	void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7897F8
	void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x789890
	void SetPendingInvalidCastException(string message) { }

	// RVA: 0x789928
	void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7899C0
	void SetPendingIOException(string message) { }

	// RVA: 0x789A58
	void SetPendingNullReferenceException(string message) { }

	// RVA: 0x789AF0
	void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x789B88
	void SetPendingOverflowException(string message) { }

	// RVA: 0x789C20
	void SetPendingSystemException(string message) { }

	// RVA: 0x789CB8
	void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x789D58
	void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x789E7C
	void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x78A4F0
	void .cctor() { }

	// RVA: 0x7895E4
	void .ctor() { }

}

// Namespace: 
public class SWIGPendingException 
{
	// Fields
	private static Exception pendingException; // 0xFFFFFFFF
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x78A2C8
	void Set(Exception e) { }

	// RVA: 0x78A0F8
	Exception Retrieve() { }

	// RVA: 0x78B0A0
	void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate 
{
	// Methods

	// RVA: 0x78B2A4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78B358
	internal string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper 
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x78B158
	void SWIGRegisterStringCallback_FirebaseMessagingInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x78B154
	string CreateString(string cString) { }

	// RVA: 0x78B16C
	void .cctor() { }

	// RVA: 0x7895EC
	void .ctor() { }

}

// Namespace: Firebase.Messaging
internal class FirebaseMessagingInternalPINVOKE 
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x789520
	void .cctor() { }

	// RVA: 0x7889A0
	string AndroidNotificationParamsInternal_channel_id_get(HandleRef jarg1) { }

	// RVA: 0x788998
	void delete_AndroidNotificationParamsInternal(HandleRef jarg1) { }

	// RVA: 0x788D34
	void delete_FirebaseNotificationInternal(HandleRef jarg1) { }

	// RVA: 0x788D3C
	string FirebaseNotificationInternal_title_get(HandleRef jarg1) { }

	// RVA: 0x788D74
	string FirebaseNotificationInternal_body_get(HandleRef jarg1) { }

	// RVA: 0x788DAC
	string FirebaseNotificationInternal_icon_get(HandleRef jarg1) { }

	// RVA: 0x788DE4
	string FirebaseNotificationInternal_sound_get(HandleRef jarg1) { }

	// RVA: 0x788E1C
	string FirebaseNotificationInternal_badge_get(HandleRef jarg1) { }

	// RVA: 0x788E54
	string FirebaseNotificationInternal_tag_get(HandleRef jarg1) { }

	// RVA: 0x788E8C
	string FirebaseNotificationInternal_color_get(HandleRef jarg1) { }

	// RVA: 0x788EC4
	string FirebaseNotificationInternal_click_action_get(HandleRef jarg1) { }

	// RVA: 0x788EFC
	string FirebaseNotificationInternal_body_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x788F34
	IntPtr FirebaseNotificationInternal_body_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x788F3C
	string FirebaseNotificationInternal_title_loc_key_get(HandleRef jarg1) { }

	// RVA: 0x788F74
	IntPtr FirebaseNotificationInternal_title_loc_args_get(HandleRef jarg1) { }

	// RVA: 0x788F7C
	IntPtr FirebaseNotificationInternal_android_get(HandleRef jarg1) { }

	// RVA: 0x7892E0
	void delete_FirebaseMessageInternal(HandleRef jarg1) { }

	// RVA: 0x7892E8
	string FirebaseMessageInternal_from_get(HandleRef jarg1) { }

	// RVA: 0x789320
	string FirebaseMessageInternal_to_get(HandleRef jarg1) { }

	// RVA: 0x789358
	string FirebaseMessageInternal_collapse_key_get(HandleRef jarg1) { }

	// RVA: 0x789390
	IntPtr FirebaseMessageInternal_data_get(HandleRef jarg1) { }

	// RVA: 0x789398
	IntPtr FirebaseMessageInternal_raw_data_get(HandleRef jarg1) { }

	// RVA: 0x7893A0
	string FirebaseMessageInternal_message_id_get(HandleRef jarg1) { }

	// RVA: 0x7893D8
	string FirebaseMessageInternal_message_type_get(HandleRef jarg1) { }

	// RVA: 0x789410
	string FirebaseMessageInternal_priority_get(HandleRef jarg1) { }

	// RVA: 0x789448
	int FirebaseMessageInternal_time_to_live_get(HandleRef jarg1) { }

	// RVA: 0x789450
	string FirebaseMessageInternal_error_get(HandleRef jarg1) { }

	// RVA: 0x789488
	string FirebaseMessageInternal_error_description_get(HandleRef jarg1) { }

	// RVA: 0x7894C0
	IntPtr FirebaseMessageInternal_notification_get(HandleRef jarg1) { }

	// RVA: 0x7894C8
	bool FirebaseMessageInternal_notification_opened_get(HandleRef jarg1) { }

	// RVA: 0x7894E8
	string FirebaseMessageInternal_link_get(HandleRef jarg1) { }

	// RVA: 0x7895F4
	void SetListenerCallbacks(MessageReceivedDelegate jarg1, TokenReceivedDelegate jarg2) { }

	// RVA: 0x789628
	void SetListenerCallbacksEnabled(bool jarg1, bool jarg2) { }

	// RVA: 0x78962C
	void SendPendingEvents() { }

}

// Namespace: 
internal sealed class MessageReceivedDelegate 
{
	// Methods

	// RVA: 0x78C50C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78C704
	internal bool Invoke(IntPtr message) { }

}

// Namespace: 
internal sealed class TokenReceivedDelegate 
{
	// Methods

	// RVA: 0x78C5B0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x78C718
	internal void Invoke(string token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public IntPtr message; // 0x10
	public bool tookOwnership; // 0x18

	// Methods

	// RVA: 0x78C6F4
	void .ctor() { }

	// RVA: 0x78C72C
	bool <MessageReceivedDelegateMethod>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0 
{
	// Fields
	public string token; // 0x10

	// Methods

	// RVA: 0x78C6FC
	void .ctor() { }

	// RVA: 0x78C924
	void <TokenReceivedDelegateMethod>b__0() { }

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

	// RVA: 0x78B97C
	Listener Create() { }

	// RVA: 0x78BB10
	void Destroy() { }

	// RVA: 0x78C134
	void .ctor() { }

	// RVA: 0x78C664
	void Finalize() { }

	// RVA: 0x78C364
	void Dispose() { }

	// RVA: 0x78BF80
	bool MessageReceivedDelegateMethod(IntPtr message) { }

	// RVA: 0x78C070
	void TokenReceivedDelegateMethod(string token) { }

}

// Namespace: Firebase.Messaging
internal sealed class FirebaseMessagingInternal 
{
	// Fields
	private static System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> MessageReceivedInternal; // 0x0
	private static System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> TokenReceivedInternal; // 0x8
	private static Listener listener; // 0x10

	// Methods

	// RVA: 0x78B36C
	void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x78B47C
	void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x78B58C
	void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x78B6A0
	void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x78B7B4
	void CreateOrDestroyListener() { }

	// RVA: 0x78BE48
	void .cctor() { }

	// RVA: 0x786FBC
	void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x787190
	void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value) { }

	// RVA: 0x787364
	void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x787538
	void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value) { }

	// RVA: 0x78BE9C
	void SetListenerCallbacks(MessageReceivedDelegate messageCallback, TokenReceivedDelegate tokenCallback) { }

	// RVA: 0x78BC58
	void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled) { }

	// RVA: 0x78BD60
	void SendPendingEvents() { }

}


