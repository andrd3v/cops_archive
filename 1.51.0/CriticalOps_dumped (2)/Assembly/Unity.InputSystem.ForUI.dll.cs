// Namespace: 
internal class <Module>
{}

// Namespace: 
public static class Actions
{
	// Fields
	public static readonly string PointAction; // 0x0
	public static readonly string MoveAction; // 0x8
	public static readonly string SubmitAction; // 0x10
	public static readonly string CancelAction; // 0x18
	public static readonly string LeftClickAction; // 0x20
	public static readonly string MiddleClickAction; // 0x28
	public static readonly string RightClickAction; // 0x30
	public static readonly string ScrollWheelAction; // 0x38

	// Methods

	// RVA: 0x13E1528
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.InputForUI.Event> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x13E16D0
	private static void .cctor() { }

	// RVA: 0x13E173C
	public void .ctor() { }

	// RVA: 0x13E1744
	internal int <Update>b__33_0(Event a, Event b) { }

}

// Namespace: UnityEngine.InputSystem.Plugins.InputForUI
internal class InputSystemProvider
{
	// Fields
	private InputEventPartialProvider m_InputEventPartialProvider; // 0x10
	private DefaultInputActions m_DefaultInputActions; // 0x18
	private InputActionAsset m_InputActionAsset; // 0x20
	private InputActionReference m_PointAction; // 0x28
	private InputActionReference m_MoveAction; // 0x30
	private InputActionReference m_SubmitAction; // 0x38
	private InputActionReference m_CancelAction; // 0x40
	private InputActionReference m_LeftClickAction; // 0x48
	private InputActionReference m_MiddleClickAction; // 0x50
	private InputActionReference m_RightClickAction; // 0x58
	private InputActionReference m_ScrollWheelAction; // 0x60
	private InputAction m_NextPreviousAction; // 0x68
	private System.Collections.Generic.List<UnityEngine.InputForUI.Event> m_Events; // 0x70
	private PointerState m_MouseState; // 0x78
	private PointerState m_PenState; // 0xA0
	private bool m_SeenPenEvents; // 0xC8
	private PointerState m_TouchState; // 0xD0
	private bool m_SeenTouchEvents; // 0xF8
	private NavigationEventRepeatHelper m_RepeatHelper; // 0x100
	private bool m_ResetSeenEventsOnUpdate; // 0x108
	private static System.Action<UnityEngine.InputSystem.InputActionAsset> s_OnRegisterActions; // 0x0

	// Methods

	// RVA: 0x13DD364
	private static void .cctor() { }

	// RVA: 0x13DD4CC
	private static void Bootstrap() { }

	// RVA: 0x13DD4D0
	private EventModifiers get_m_EventModifiers() { }

	// RVA: 0x13DD4F0
	private DiscreteTime get_m_CurrentTime() { }

	// RVA: 0x13DD50C
	public void Initialize() { }

	// RVA: 0x13DE220
	public void Shutdown() { }

	// RVA: 0x13DEA0C
	public void OnActionsChange() { }

	// RVA: 0x13DEA38
	public void Update() { }

	// RVA: 0x13DF18C
	private void ResetSeenEvents() { }

	// RVA: 0x13DEF90
	private void DirectionNavigation(DiscreteTime currentTime) { }

	// RVA: 0x13DF3F4
	private InputDevice GetActiveDeviceFromDirection(Direction direction) { }

	// RVA: 0x13DF198
	private System.ValueTuple<UnityEngine.Vector2,System.Boolean> ReadCurrentNavigationMoveVector() { }

	// RVA: 0x13DF2CC
	private Direction ReadNextPreviousDirection() { }

	// RVA: 0x13DF6E0
	private static int SortEvents(Event a, Event b) { }

	// RVA: 0x13DF80C
	public void OnFocusChanged(bool focus) { }

	// RVA: 0x13DF82C
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x13DF91C
	private EventSource GetEventSource(CallbackContext ctx) { }

	// RVA: 0x13DF538
	private EventSource GetEventSource(InputDevice device) { }

	// RVA: 0x13DF954
	private PointerState GetPointerStateForSource(EventSource eventSource) { }

	// RVA: 0x13DF974
	private void DispatchFromCallback(Event ev) { }

	// RVA: 0x13DFA30
	private static int FindTouchFingerIndex(Touchscreen touchscreen, CallbackContext ctx) { }

	// RVA: 0x13DFFAC
	private void OnPointerPerformed(CallbackContext ctx) { }

	// RVA: 0x13E0814
	private void OnSubmitPerformed(CallbackContext ctx) { }

	// RVA: 0x13E09A0
	private void OnCancelPerformed(CallbackContext ctx) { }

	// RVA: 0x13E0B2C
	private void OnClickPerformed(CallbackContext ctx, EventSource eventSource, Button button) { }

	// RVA: 0x13E0F94
	private void OnLeftClickPerformed(CallbackContext ctx) { }

	// RVA: 0x13E1000
	private void OnMiddleClickPerformed(CallbackContext ctx) { }

	// RVA: 0x13E106C
	private void OnRightClickPerformed(CallbackContext ctx) { }

	// RVA: 0x13E10D8
	private void OnScrollWheelPerformed(CallbackContext ctx) { }

	// RVA: 0x13DE12C
	private void RegisterFixedActions() { }

	// RVA: 0x13DE9C8
	private void UnregisterFixedActions() { }

	// RVA: 0x13DD88C
	private void RegisterActions() { }

	// RVA: 0x13DE348
	private void UnregisterActions() { }

	// RVA: 0x13DD6E8
	private void SelectInputActionAsset() { }

	// RVA: 0x13DD400
	public void .ctor() { }

}


