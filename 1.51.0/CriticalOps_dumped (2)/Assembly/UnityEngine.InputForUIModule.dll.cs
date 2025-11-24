// Namespace: 
internal class <Module>
{}

// Namespace: 
public enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type Validate = 1;
	public const Type Execute = 2;
}

// Namespace: 
public enum Command
{
	// Fields
	public int value__; // 0x10
	public const Command Invalid = 0;
	public const Command Cut = 1;
	public const Command Copy = 2;
	public const Command Paste = 3;
	public const Command SelectAll = 4;
	public const Command DeselectAll = 5;
	public const Command InvertSelection = 6;
	public const Command Duplicate = 7;
	public const Command Rename = 8;
	public const Command Delete = 9;
	public const Command SoftDelete = 10;
	public const Command Find = 11;
	public const Command SelectChildren = 12;
	public const Command SelectPrefabRoot = 13;
	public const Command UndoRedoPerformed = 14;
	public const Command OnLostFocus = 15;
	public const Command NewKeyboardFocus = 16;
	public const Command ModifierKeysChanged = 17;
	public const Command EyeDropperUpdate = 18;
	public const Command EyeDropperClicked = 19;
	public const Command EyeDropperCancelled = 20;
	public const Command ColorPickerChanged = 21;
	public const Command FrameSelected = 22;
	public const Command FrameSelectedWithLock = 23;
}

// Namespace: UnityEngine.InputForUI
internal struct CommandEvent
{
	// Fields
	public Type type; // 0x10
	public Command command; // 0x14
	private DiscreteTime <timestamp>k__BackingField; // 0x18
	private EventSource <eventSource>k__BackingField; // 0x20
	private UInt32 <playerId>k__BackingField; // 0x24
	private EventModifiers <eventModifiers>k__BackingField; // 0x28

	// Methods

	// RVA: 0x1706BF8
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x1706C00
	public EventSource get_eventSource() { }

	// RVA: 0x1706C08
	public void set_eventSource(EventSource value) { }

	// RVA: 0x1706C10
	public void set_playerId(UInt32 value) { }

	// RVA: 0x1706C18
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x1706C20
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x1706C28
	public override string ToString() { }

}

// Namespace: 
public enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type Invalid = 0;
	public const Type KeyEvent = 1;
	public const Type PointerEvent = 2;
	public const Type TextInputEvent = 3;
	public const Type IMECompositionEvent = 4;
	public const Type CommandEvent = 5;
	public const Type NavigationEvent = 6;
}

// Namespace: 
private interface IMapFn<T0>
{
	// Methods

	// RVA: -1
	public abstract TOutputType Map(TEventType ev) { }

}

// Namespace: 
private struct MapAsObject
{
	// Methods

	// RVA: 0x35258B4
	public IEventProperties Map(TEventType ev) { }

}

// Namespace: 
private struct MapAsEventSource
{
	// Methods

	// RVA: 0x3525600
	public EventSource Map(TEventType ev) { }

}

// Namespace: 
private struct MapAsEventModifiers
{
	// Methods

	// RVA: 0x26AD93C
	public EventModifiers Map(TEventType ev) { }

}

// Namespace: UnityEngine.InputForUI
internal struct Event
{
	// Fields
	public static Type[] TypesWithState; // 0x0
	private Type _type; // 0x10
	private object _managedEvent; // 0x18
	private KeyEvent _keyEvent; // 0x20
	private PointerEvent _pointerEvent; // 0x20
	private TextInputEvent _textInputEvent; // 0x20
	private CommandEvent _commandEvent; // 0x20
	private NavigationEvent _navigationEvent; // 0x20

	// Methods

	// RVA: 0x1706CEC
	internal static int CompareType(Event a, Event b) { }

	// RVA: 0x1706F44
	public Type get_type() { }

	// RVA: 0x1706F4C
	private IEventProperties get_asObject() { }

	// RVA: 0x1706EB8
	public EventSource get_eventSource() { }

	// RVA: 0x1706FD8
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x1707064
	private void Ensure(Type t) { }

	// RVA: 0x1707120
	public override string ToString() { }

	// RVA: 0x1707A5C
	public static Event From(KeyEvent keyEvent) { }

	// RVA: 0x1707B00
	public KeyEvent get_asKeyEvent() { }

	// RVA: 0x1707C20
	public static Event From(PointerEvent pointerEvent) { }

	// RVA: 0x1707CCC
	public PointerEvent get_asPointerEvent() { }

	// RVA: 0x1707DEC
	public static Event From(TextInputEvent textInputEvent) { }

	// RVA: 0x1707E6C
	public TextInputEvent get_asTextInputEvent() { }

	// RVA: 0x1707F7C
	public static Event From(IMECompositionEvent imeCompositionEvent) { }

	// RVA: 0x1708064
	public IMECompositionEvent get_asIMECompositionEvent() { }

	// RVA: 0x17081C8
	public static Event From(CommandEvent commandEvent) { }

	// RVA: 0x1708248
	public CommandEvent get_asCommandEvent() { }

	// RVA: 0x1708358
	public static Event From(NavigationEvent navigationEvent) { }

	// RVA: 0x17083F0
	public NavigationEvent get_asNavigationEvent() { }

	// RVA: 0x26AD93C
	private TOutputType Map(TMapType fn) { }

	// RVA: 0x26AD93C
	private TOutputType Map() { }

	// RVA: 0x1708508
	private static void .cctor() { }

}

// Namespace: 
public enum Modifiers
{
	// Fields
	public UInt32 value__; // 0x10
	public const Modifiers LeftShift = 1;
	public const Modifiers RightShift = 2;
	public const Modifiers Shift = 3;
	public const Modifiers LeftCtrl = 4;
	public const Modifiers RightCtrl = 8;
	public const Modifiers Ctrl = 12;
	public const Modifiers LeftAlt = 16;
	public const Modifiers RightAlt = 32;
	public const Modifiers Alt = 48;
	public const Modifiers LeftMeta = 64;
	public const Modifiers RightMeta = 128;
	public const Modifiers Meta = 192;
	public const Modifiers CapsLock = 256;
	public const Modifiers Numlock = 512;
	public const Modifiers FunctionKey = 1024;
	public const Modifiers Numeric = 2048;
}

// Namespace: UnityEngine.InputForUI
internal struct EventModifiers
{
	// Fields
	private UInt32 _state; // 0x10

	// Methods

	// RVA: 0x17085AC
	public bool IsPressed(Modifiers mod) { }

	// RVA: 0x17085BC
	public bool get_isShiftPressed() { }

	// RVA: 0x17085CC
	public bool get_isCtrlPressed() { }

	// RVA: 0x17085DC
	public bool get_isAltPressed() { }

	// RVA: 0x17085EC
	public bool get_isMetaPressed() { }

	// RVA: 0x17085FC
	public bool get_isCapsLockEnabled() { }

	// RVA: 0x1708608
	public bool get_isFunctionKeyPressed() { }

	// RVA: 0x1708614
	public bool get_isNumericPressed() { }

	// RVA: 0x1708620
	public void SetPressed(Modifiers modifier, bool pressed) { }

	// RVA: 0x170863C
	public void Reset() { }

	// RVA: 0x1708644
	private static void Append(string str, string value) { }

	// RVA: 0x17073E4
	public override string ToString() { }

}

// Namespace: UnityEngine.InputForUI
internal enum EventSource
{
	// Fields
	public int value__; // 0x10
	public const EventSource Unspecified = 0;
	public const EventSource Keyboard = 1;
	public const EventSource Gamepad = 2;
	public const EventSource Mouse = 3;
	public const EventSource Pen = 4;
	public const EventSource Touch = 5;
}

// Namespace: UnityEngine.InputForUI
internal interface IEventProperties
{
	// Methods

	// RVA: -1
	public abstract EventSource get_eventSource() { }

	// RVA: -1
	public abstract EventModifiers get_eventModifiers() { }

}

// Namespace: UnityEngine.InputForUI
internal struct IMECompositionEvent
{
	// Fields
	public string compositionString; // 0x10
	private DiscreteTime <timestamp>k__BackingField; // 0x18
	private EventSource <eventSource>k__BackingField; // 0x20
	private UInt32 <playerId>k__BackingField; // 0x24
	private EventModifiers <eventModifiers>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17086C8
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x17086D0
	public EventSource get_eventSource() { }

	// RVA: 0x17086D8
	public void set_eventSource(EventSource value) { }

	// RVA: 0x17086E0
	public void set_playerId(UInt32 value) { }

	// RVA: 0x17086E8
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x17086F0
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x17086F8
	public override string ToString() { }

}

// Namespace: 
public enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type KeyPressed = 1;
	public const Type KeyRepeated = 2;
	public const Type KeyReleased = 3;
	public const Type State = 4;
}

// Namespace: 
private sealed class <GetAllPressed>d__8
{
	// Fields
	private int <>1__state; // 0x10
	private KeyCode <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public ButtonsState <>4__this; // 0x1C
	public ButtonsState <>3__<>4__this; // 0x44
	private UInt32 <index>5__1; // 0x6C

	// Methods

	// RVA: 0x1708A54
	public void .ctor(int <>1__state) { }

	// RVA: 0x1708BAC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1708BB0
	private bool MoveNext() { }

	// RVA: 0x1708C24
	private KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current() { }

	// RVA: 0x1708C2C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1708C6C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1708CD4
	private System.Collections.Generic.IEnumerator<UnityEngine.KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator() { }

	// RVA: 0x1708D84
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct <buttons>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct ButtonsState
{
	// Fields
	private UnityEngine.InputForUI.KeyEvent.ButtonsState.<buttons>e__FixedBuffer buttons; // 0x10

	// Methods

	// RVA: 0x170892C
	internal static bool ShouldBeProcessed(KeyCode keyCode) { }

	// RVA: 0x1708938
	private bool GetUnchecked(UInt32 index) { }

	// RVA: 0x1708954
	private void SetUnchecked(UInt32 index) { }

	// RVA: 0x1708978
	private void ClearUnchecked(UInt32 index) { }

	// RVA: 0x170899C
	public bool IsPressed(KeyCode keyCode) { }

	// RVA: 0x17089C8
	public System.Collections.Generic.IEnumerable<UnityEngine.KeyCode> GetAllPressed() { }

	// RVA: 0x1708A8C
	public void SetPressed(KeyCode keyCode, bool pressed) { }

	// RVA: 0x1708AC4
	public void Reset() { }

	// RVA: 0x1708AD4
	public override string ToString() { }

}

// Namespace: UnityEngine.InputForUI
internal struct KeyEvent
{
	// Fields
	public Type type; // 0x10
	public KeyCode keyCode; // 0x14
	public ButtonsState buttonsState; // 0x18
	private DiscreteTime <timestamp>k__BackingField; // 0x40
	private EventSource <eventSource>k__BackingField; // 0x48
	private UInt32 <playerId>k__BackingField; // 0x4C
	private EventModifiers <eventModifiers>k__BackingField; // 0x50

	// Methods

	// RVA: 0x1708768
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x1708770
	public EventSource get_eventSource() { }

	// RVA: 0x1708778
	public void set_eventSource(EventSource value) { }

	// RVA: 0x1708780
	public void set_playerId(UInt32 value) { }

	// RVA: 0x1708788
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x1708790
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x1708798
	public override string ToString() { }

}

// Namespace: 
public enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type Move = 1;
	public const Type Submit = 2;
	public const Type Cancel = 3;
}

// Namespace: 
public enum Direction
{
	// Fields
	public int value__; // 0x10
	public const Direction None = 0;
	public const Direction Left = 1;
	public const Direction Up = 2;
	public const Direction Right = 3;
	public const Direction Down = 4;
	public const Direction Next = 5;
	public const Direction Previous = 6;
}

// Namespace: UnityEngine.InputForUI
internal struct NavigationEvent
{
	// Fields
	public Type type; // 0x10
	public Direction direction; // 0x14
	public bool shouldBeUsed; // 0x18
	private DiscreteTime <timestamp>k__BackingField; // 0x20
	private EventSource <eventSource>k__BackingField; // 0x28
	private UInt32 <playerId>k__BackingField; // 0x2C
	private EventModifiers <eventModifiers>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1708E34
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x1708E3C
	public EventSource get_eventSource() { }

	// RVA: 0x1708E44
	public void set_eventSource(EventSource value) { }

	// RVA: 0x1708E4C
	public void set_playerId(UInt32 value) { }

	// RVA: 0x1708E54
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x1708E5C
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x1708E64
	public override string ToString() { }

	// RVA: 0x1708FD8
	internal static Direction DetermineMoveDirection(Vector2 vec, float deadZone) { }

}

// Namespace: 
public enum Type
{
	// Fields
	public int value__; // 0x10
	public const Type PointerMoved = 1;
	public const Type Scroll = 2;
	public const Type ButtonPressed = 3;
	public const Type ButtonReleased = 4;
	public const Type State = 5;
	public const Type TouchCanceled = 6;
}

// Namespace: 
public enum Button
{
	// Fields
	public UInt32 value__; // 0x10
	public const Button None = 0;
	public const Button Primary = 1;
	public const Button FingerInTouch = 1;
	public const Button PenTipInTouch = 1;
	public const Button PenEraserInTouch = 2;
	public const Button PenBarrelButton = 4;
	public const Button MouseLeft = 1;
	public const Button MouseRight = 2;
	public const Button MouseMiddle = 4;
	public const Button MouseForward = 8;
	public const Button MouseBack = 16;
}

// Namespace: 
public struct ButtonsState
{
	// Fields
	private UInt32 _state; // 0x10

	// Methods

	// RVA: 0x1709F38
	public void Set(Button button, bool pressed) { }

	// RVA: 0x1709F54
	public bool Get(Button button) { }

	// RVA: 0x1709F64
	public void Reset() { }

	// RVA: 0x1709F6C
	public override string ToString() { }

}

// Namespace: UnityEngine.InputForUI
internal struct PointerEvent
{
	// Fields
	public Type type; // 0x10
	public int pointerIndex; // 0x14
	public Vector2 position; // 0x18
	public Vector2 deltaPosition; // 0x20
	public Vector2 scroll; // 0x28
	public int displayIndex; // 0x30
	public Vector2 tilt; // 0x34
	public float twist; // 0x3C
	public float pressure; // 0x40
	public bool isInverted; // 0x44
	public Button button; // 0x48
	public ButtonsState buttonsState; // 0x4C
	public int clickCount; // 0x50
	private DiscreteTime <timestamp>k__BackingField; // 0x58
	private EventSource <eventSource>k__BackingField; // 0x60
	private UInt32 <playerId>k__BackingField; // 0x64
	private EventModifiers <eventModifiers>k__BackingField; // 0x68

	// Methods

	// RVA: 0x1709028
	public bool get_isPrimaryPointer() { }

	// RVA: 0x1709038
	public float get_azimuth() { }

	// RVA: 0x17091A4
	public float get_altitude() { }

	// RVA: 0x170922C
	public DiscreteTime get_timestamp() { }

	// RVA: 0x1709234
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x170923C
	public EventSource get_eventSource() { }

	// RVA: 0x1709244
	public void set_eventSource(EventSource value) { }

	// RVA: 0x170924C
	public void set_playerId(UInt32 value) { }

	// RVA: 0x1709254
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x170925C
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x1709264
	public override string ToString() { }

	// RVA: 0x1709F24
	internal static Button ButtonFromButtonIndex(int index) { }

}

// Namespace: UnityEngine.InputForUI
internal struct TextInputEvent
{
	// Fields
	public Char character; // 0x10
	private DiscreteTime <timestamp>k__BackingField; // 0x18
	private EventSource <eventSource>k__BackingField; // 0x20
	private UInt32 <playerId>k__BackingField; // 0x24
	private EventModifiers <eventModifiers>k__BackingField; // 0x28

	// Methods

	// RVA: 0x1709FEC
	public void set_timestamp(DiscreteTime value) { }

	// RVA: 0x1709FF4
	public EventSource get_eventSource() { }

	// RVA: 0x1709FFC
	public void set_eventSource(EventSource value) { }

	// RVA: 0x170A004
	public void set_playerId(UInt32 value) { }

	// RVA: 0x170A00C
	public EventModifiers get_eventModifiers() { }

	// RVA: 0x170A014
	public void set_eventModifiers(EventModifiers value) { }

	// RVA: 0x170A01C
	public override string ToString() { }

}

// Namespace: 
private struct Registration
{
	// Fields
	public EventConsumer handler; // 0x10
	public int priority; // 0x18
	public System.Nullable<System.Int32> playerId; // 0x1C
	public System.Collections.Generic.HashSet<UnityEngine.InputForUI.Event.Type> _types; // 0x28
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputForUI.EventProvider.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputForUI.EventProvider.Registration> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x170B718
	private static void .cctor() { }

	// RVA: 0x170B784
	public void .ctor() { }

	// RVA: 0x170B78C
	internal int <Subscribe>b__5_0(Registration a, Registration b) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public EventConsumer handler; // 0x10

	// Methods

	// RVA: 0x170A524
	public void .ctor() { }

	// RVA: 0x170B79C
	internal bool <Unsubscribe>b__0(Registration x) { }

}

// Namespace: UnityEngine.InputForUI
internal static class EventProvider
{
	// Fields
	private static IEventProviderImpl s_impl; // 0x0
	private static EventSanitizer s_sanitizer; // 0x8
	private static IEventProviderImpl s_implMockBackup; // 0x10
	private static bool s_focusChangedRegistered; // 0x18
	private static bool m_IsEnabled; // 0x19
	private static bool m_IsInitialized; // 0x1A
	private static System.Collections.Generic.List<UnityEngine.InputForUI.EventProvider.Registration> _registrations; // 0x20

	// Methods

	// RVA: 0x170A0D8
	public static void Subscribe(EventConsumer handler, int priority, System.Nullable<System.Int32> playerId, Type[] type) { }

	// RVA: 0x170A40C
	public static void Unsubscribe(EventConsumer handler) { }

	// RVA: 0x170A52C
	public static void SetEnabled(bool enable) { }

	// RVA: 0x170A9EC
	internal static void Dispatch(Event ev) { }

	// RVA: 0x170A370
	private static void Bootstrap() { }

	// RVA: 0x170A5F8
	private static void Initialize() { }

	// RVA: 0x170A810
	private static void Shutdown() { }

	// RVA: 0x170AF10
	private static void OnFocusChanged(bool focus) { }

	// RVA: 0x170B014
	internal static void NotifyUpdate() { }

	// RVA: 0x170B3C4
	internal static void SetInputSystemProvider(IEventProviderImpl impl) { }

	// RVA: 0x170B480
	private static void .cctor() { }

}

// Namespace: UnityEngine.InputForUI
internal sealed class EventConsumer
{
	// Methods

	// RVA: 0x170B7B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170B864
	public virtual bool Invoke(Event ev) { }

}

// Namespace: UnityEngine.InputForUI
internal interface IEventProviderImpl
{
	// Methods

	// RVA: -1
	public abstract void Initialize() { }

	// RVA: -1
	public abstract void Shutdown() { }

	// RVA: -1
	public abstract void Update() { }

	// RVA: -1
	public abstract void OnFocusChanged(bool focus) { }

}

// Namespace: UnityEngine.InputForUI
internal class InputEventPartialProvider
{
	// Fields
	private Event _ev; // 0x10
	private OperatingSystemFamily _operatingSystemFamily; // 0x18
	private ButtonsState _keyboardButtonsState; // 0x1C
	internal EventModifiers _eventModifiers; // 0x44
	internal bool _sendNavigationEventOnTabKey; // 0x48
	private System.Collections.Generic.IDictionary<System.String,UnityEngine.InputForUI.CommandEvent.Command> _IMGUICommandToInputForUICommandType; // 0x50

	// Methods

	// RVA: 0x170B878
	public void Initialize() { }

	// RVA: 0x170B8B4
	public void Shutdown() { }

	// RVA: 0x170B8B8
	public void Update() { }

	// RVA: 0x170C454
	public void OnFocusChanged(bool focus) { }

	// RVA: 0x170C470
	private DiscreteTime GetTimestamp(Event ev) { }

	// RVA: 0x170BC34
	private void UpdateEventModifiers(Event ev) { }

	// RVA: 0x170BF4C
	private KeyEvent ToKeyEvent(Event ev) { }

	// RVA: 0x170C218
	private TextInputEvent ToTextInputEvent(Event ev) { }

	// RVA: 0x170C0B8
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(Event ev) { }

	// RVA: 0x170C28C
	private CommandEvent ToCommandEvent(Event ev) { }

	// RVA: 0x170C48C
	public void .ctor() { }

}

// Namespace: 
private struct ButtonEventsIterator
{
	// Fields
	private UInt32 _mask; // 0x10
	private int _bit; // 0x14

	// Methods

	// RVA: 0x170F78C
	public bool get_Current() { }

	// RVA: 0x170F8E0
	public bool MoveNext() { }

	// RVA: 0x1710560
	public void Reset() { }

	// RVA: 0x171056C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x170F76C
	public static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current) { }

}

// Namespace: 
public struct Configuration
{
	// Fields
	public string HorizontalAxis; // 0x10
	public string VerticalAxis; // 0x18
	public string SubmitButton; // 0x20
	public string CancelButton; // 0x28
	public string NavigateNextButton; // 0x30
	public string NavigatePreviousButton; // 0x38
	public float InputActionsPerSecond; // 0x40
	public float RepeatDelay; // 0x44

	// Methods

	// RVA: 0x170CA00
	public static Configuration GetDefaultConfiguration() { }

}

// Namespace: 
internal interface IInput
{
	// Methods

	// RVA: -1
	public abstract string get_compositionString() { }

	// RVA: -1
	public abstract bool GetKey(KeyCode keyCode) { }

	// RVA: -1
	public abstract bool GetButtonDown(string button) { }

	// RVA: -1
	public abstract float GetAxisRaw(string axis) { }

	// RVA: -1
	public abstract PenData GetLastPenContactEvent() { }

	// RVA: -1
	public abstract bool get_touchSupported() { }

	// RVA: -1
	public abstract int get_touchCount() { }

	// RVA: -1
	public abstract Touch GetTouch(int index) { }

	// RVA: -1
	public abstract bool get_mousePresent() { }

	// RVA: -1
	public abstract bool GetMouseButton(int button) { }

	// RVA: -1
	public abstract bool GetMouseButtonDown(int button) { }

	// RVA: -1
	public abstract bool GetMouseButtonUp(int button) { }

	// RVA: -1
	public abstract Vector3 get_mousePosition() { }

	// RVA: -1
	public abstract Vector2 get_mouseScrollDelta() { }

}

// Namespace: 
private class Input
{
	// Methods

	// RVA: 0x17105A8
	public string get_compositionString() { }

	// RVA: 0x17105B0
	public bool GetKey(KeyCode key) { }

	// RVA: 0x17105BC
	public bool GetButtonDown(string button) { }

	// RVA: 0x17105C8
	public float GetAxisRaw(string axis) { }

	// RVA: 0x17105D4
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x1710618
	public bool get_touchSupported() { }

	// RVA: 0x1710620
	public int get_touchCount() { }

	// RVA: 0x1710628
	public Touch GetTouch(int index) { }

	// RVA: 0x171067C
	public bool get_mousePresent() { }

	// RVA: 0x1710684
	public bool GetMouseButton(int button) { }

	// RVA: 0x1710690
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x171069C
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x17106A8
	public Vector3 get_mousePosition() { }

	// RVA: 0x17106B0
	public Vector2 get_mouseScrollDelta() { }

	// RVA: 0x170CB6C
	public void .ctor() { }

}

// Namespace: 
internal interface ITime
{
	// Methods

	// RVA: -1
	public abstract RationalTime get_timeAsRational() { }

}

// Namespace: 
private class Time
{
	// Methods

	// RVA: 0x17106B8
	public RationalTime get_timeAsRational() { }

	// RVA: 0x170CB74
	public void .ctor() { }

}

// Namespace: UnityEngine.InputForUI
internal class InputManagerProvider
{
	// Fields
	private InputEventPartialProvider _inputEventPartialProvider; // 0x10
	private string _compositionString; // 0x18
	private Configuration _configuration; // 0x20
	private IInput _input; // 0x58
	private ITime _time; // 0x60
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; // 0x68
	private PointerState _mouseState; // 0x70
	private bool _isPenPresent; // 0x98
	private bool _seenAtLeastOnePenPosition; // 0x99
	private Vector2 _lastSeenPenPositionForDetection; // 0x9C
	private PointerState _penState; // 0xA8
	private PenData _lastPenData; // 0xD0
	private System.Collections.Generic.Dictionary<System.Int32,System.Int32> _touchFingerIdToFingerIndex; // 0xF8
	private int _touchNextFingerIndex; // 0x100
	private PointerState _touchState; // 0x108

	// Methods

	// RVA: 0x170C9E0
	private EventModifiers get__eventModifiers() { }

	// RVA: 0x170B580
	public void .ctor() { }

	// RVA: 0x170CCFC
	public void Initialize() { }

	// RVA: 0x170CF0C
	public void Shutdown() { }

	// RVA: 0x170CF10
	public void Update() { }

	// RVA: 0x170D414
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	// RVA: 0x170D2EC
	private void DetectPen() { }

	// RVA: 0x170F6D0
	private static Button PenStatusToButton(PenStatus status) { }

	// RVA: 0x170DBA0
	private bool CheckPenEvent(DiscreteTime currentTime, PenData currentPenData) { }

	// RVA: 0x170E044
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted) { }

	// RVA: 0x170E830
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	// RVA: 0x170F180
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	// RVA: 0x170EFA8
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	// RVA: 0x170EDAC
	private void DirectionNavigation(DiscreteTime currentTime) { }

	// RVA: 0x170EB6C
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	// RVA: 0x170FF88
	public void OnFocusChanged(bool focus) { }

	// RVA: 0x170FA74
	private EventSource GetEventSourceFromPressedKey() { }

	// RVA: 0x17100A0
	private bool InputManagerJoystickWasPressed() { }

	// RVA: 0x170FFA4
	private bool InputManagerKeyboardWasPressed() { }

	// RVA: 0x171019C
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	// RVA: 0x170F914
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	// RVA: 0x170FC54
	private System.ValueTuple<UnityEngine.Vector2,System.Boolean> ReadCurrentNavigationMoveVector() { }

	// RVA: 0x170FF20
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	// RVA: 0x17090FC
	internal static float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x170F66C
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x17091E8
	internal static float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x170F2E8
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x17102FC
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x1710470
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x170F3F8
	private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

}

// Namespace: UnityEngine.InputForUI
internal class NavigationEventRepeatHelper
{
	// Fields
	private int m_ConsecutiveMoveCount; // 0x10
	private Direction m_LastDirection; // 0x14
	private DiscreteTime m_PrevActionTime; // 0x18
	private readonly DiscreteTime m_InitialRepeatDelay; // 0x20
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; // 0x28

	// Methods

	// RVA: 0x170FD68
	public void Reset() { }

	// RVA: 0x170FDD8
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, Direction direction, bool axisButtonsWherePressedThisFrame) { }

	// RVA: 0x170CB7C
	public void .ctor() { }

}

// Namespace: UnityEngine.InputForUI
internal struct PointerState
{
	// Fields
	private Button <LastPressedButton>k__BackingField; // 0x10
	private ButtonsState _buttonsState; // 0x14
	private DiscreteTime <NextPressTime>k__BackingField; // 0x18
	private int <ClickCount>k__BackingField; // 0x20
	private Vector2 <LastPosition>k__BackingField; // 0x24
	private int <LastDisplayIndex>k__BackingField; // 0x2C
	private bool <LastPositionValid>k__BackingField; // 0x30
	private static readonly DiscreteTime kClickDelay; // 0x0

	// Methods

	// RVA: 0x17106C0
	public Button get_LastPressedButton() { }

	// RVA: 0x17106C8
	private void set_LastPressedButton(Button value) { }

	// RVA: 0x17106D0
	public ButtonsState get_ButtonsState() { }

	// RVA: 0x17106D8
	public DiscreteTime get_NextPressTime() { }

	// RVA: 0x17106E0
	private void set_NextPressTime(DiscreteTime value) { }

	// RVA: 0x17106E8
	public int get_ClickCount() { }

	// RVA: 0x17106F0
	private void set_ClickCount(int value) { }

	// RVA: 0x17106F8
	public Vector2 get_LastPosition() { }

	// RVA: 0x1710700
	private void set_LastPosition(Vector2 value) { }

	// RVA: 0x1710708
	public int get_LastDisplayIndex() { }

	// RVA: 0x1710710
	private void set_LastDisplayIndex(int value) { }

	// RVA: 0x1710718
	public bool get_LastPositionValid() { }

	// RVA: 0x1710720
	public void set_LastPositionValid(bool value) { }

	// RVA: 0x170F400
	public void OnButtonDown(DiscreteTime currentTime, Button button) { }

	// RVA: 0x170F5C0
	public void OnButtonUp(DiscreteTime currentTime, Button button) { }

	// RVA: 0x170F79C
	public void OnButtonChange(DiscreteTime currentTime, Button button, bool previousState, bool newState) { }

	// RVA: 0x170F6EC
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	// RVA: 0x170CE0C
	public void Reset() { }

	// RVA: 0x1710728
	private static void .cctor() { }

}

// Namespace: 
private interface IEventSanitizer
{
	// Methods

	// RVA: -1
	public abstract void Reset() { }

	// RVA: -1
	public abstract void BeforeProviderUpdate() { }

	// RVA: -1
	public abstract void AfterProviderUpdate() { }

	// RVA: -1
	public abstract void Inspect(Event ev) { }

}

// Namespace: UnityEngine.InputForUI
internal struct EventSanitizer
{
	// Fields
	private IEventSanitizer[] _sanitizers; // 0x10

	// Methods

	// RVA: 0x170ADFC
	public void Reset() { }

	// RVA: 0x170B1D4
	public void BeforeProviderUpdate() { }

	// RVA: 0x170B2CC
	public void AfterProviderUpdate() { }

	// RVA: 0x170ACF4
	public void Inspect(Event ev) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=12 B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137; // 0x0
}


