// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public sealed class Event 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Methods

	// RVA: 0x152B858
	EventType get_rawType() { }

	// RVA: 0x152B8A8
	Vector2 get_mousePosition() { }

	// RVA: 0x152B968
	void set_mousePosition(Vector2 value) { }

	// RVA: 0x152BA24
	Vector2 get_delta() { }

	// RVA: 0x152BAE4
	void set_delta(Vector2 value) { }

	// RVA: 0x152BBA0
	PointerType get_pointerType() { }

	// RVA: 0x152BBF0
	int get_button() { }

	// RVA: 0x152BC40
	EventModifiers get_modifiers() { }

	// RVA: 0x152BC90
	void set_modifiers(EventModifiers value) { }

	// RVA: 0x152BCF8
	float get_pressure() { }

	// RVA: 0x152BD48
	float get_twist() { }

	// RVA: 0x152BD98
	Vector2 get_tilt() { }

	// RVA: 0x152BE58
	PenStatus get_penStatus() { }

	// RVA: 0x152BEA8
	int get_clickCount() { }

	// RVA: 0x152BEF8
	Char get_character() { }

	// RVA: 0x152BF48
	void set_character(Char value) { }

	// RVA: 0x152BFB0
	KeyCode get_keyCode() { }

	// RVA: 0x152C000
	void set_keyCode(KeyCode value) { }

	// RVA: 0x152C068
	int get_displayIndex() { }

	// RVA: 0x152C0B8
	void set_displayIndex(int value) { }

	// RVA: 0x152C120
	EventType get_type() { }

	// RVA: 0x152C170
	void set_type(EventType value) { }

	// RVA: 0x152C1D8
	string get_commandName() { }

	// RVA: 0x152C228
	void set_commandName(string value) { }

	// RVA: 0x152C290
	void Internal_Use() { }

	// RVA: 0x152C2E0
	IntPtr Internal_Create(int displayIndex) { }

	// RVA: 0x152C330
	void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x152C380
	EventType GetTypeForControl(int controlID) { }

	// RVA: 0x152C3E8
	void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x152C450
	bool PopEvent(Event outEvent) { }

	// RVA: 0x152C4A0
	void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0x152C4F0
	void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x152C6A0
	int GetDoubleClickTime() { }

	// RVA: 0x152C6E0
	void .ctor() { }

	// RVA: 0x152C644
	void .ctor(int displayIndex) { }

	// RVA: 0x152C748
	void Finalize() { }

	// RVA: 0x152C824
	void CopyFrom(Event e) { }

	// RVA: 0x152C8BC
	bool get_shift() { }

	// RVA: 0x152C91C
	bool get_control() { }

	// RVA: 0x152C97C
	bool get_alt() { }

	// RVA: 0x152C9DC
	bool get_command() { }

	// RVA: 0x152CA3C
	Event get_current() { }

	// RVA: 0x152CA88
	void set_current(Event value) { }

	// RVA: 0x152CB48
	bool get_isKey() { }

	// RVA: 0x152CB98
	bool get_isMouse() { }

	// RVA: 0x152CC24
	bool get_isDirectManipulationDevice() { }

	// RVA: 0x152CCBC
	Event KeyboardEvent(string key) { }

	// RVA: 0x152EA4C
	int GetHashCode() { }

	// RVA: 0x152EBCC
	bool Equals(object obj) { }

	// RVA: 0x152EF24
	string ToString() { }

	// RVA: 0x152F82C
	void Use() { }

	// RVA: 0x152B900
	void get_mousePosition_Injected(out Vector2 ret) { }

	// RVA: 0x152B9BC
	void set_mousePosition_Injected(ref Vector2 value) { }

	// RVA: 0x152BA7C
	void get_delta_Injected(out Vector2 ret) { }

	// RVA: 0x152BB38
	void set_delta_Injected(ref Vector2 value) { }

	// RVA: 0x152BDF0
	void get_tilt_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine
public enum EventType 
{
	// Fields
	public int value__; // 0x10
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	public const EventType mouseDown = 0;
	public const EventType mouseUp = 1;
	public const EventType mouseMove = 2;
	public const EventType mouseDrag = 3;
	public const EventType keyDown = 4;
	public const EventType keyUp = 5;
	public const EventType scrollWheel = 6;
	public const EventType repaint = 7;
	public const EventType layout = 8;
	public const EventType dragUpdated = 9;
	public const EventType dragPerform = 10;
	public const EventType ignore = 11;
	public const EventType used = 12;
}

// Namespace: UnityEngine
public enum EventModifiers 
{
	// Fields
	public int value__; // 0x10
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: UnityEngine
public enum PointerType 
{
	// Fields
	public int value__; // 0x10
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;
}

// Namespace: UnityEngine
internal struct EventInterests 
{
	// Fields
	private bool <wantsMouseMove>k__BackingField; // 0x10
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x11
	private bool <wantsLessLayoutEvents>k__BackingField; // 0x12

	// Methods

	// RVA: 0x152FA48
	bool get_wantsMouseMove() { }

	// RVA: 0x152FA50
	void set_wantsMouseMove(bool value) { }

	// RVA: 0x152FA58
	bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x152FA60
	void set_wantsMouseEnterLeaveWindow(bool value) { }

	// RVA: 0x152FA68
	bool get_wantsLessLayoutEvents() { }

	// RVA: 0x152FA70
	bool WantsEvent(EventType type) { }

	// RVA: 0x152FAA0
	bool WantsLayoutPass(EventType type) { }

}

// Namespace: 
public sealed class WindowFunction 
{
	// Methods

	// RVA: 0x153D8F0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x153D994
	internal void Invoke(int id) { }

}

// Namespace: UnityEngine
public class GUI 
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	private static int <scrollTroughSide>k__BackingField; // 0x28
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Methods

	// RVA: 0x152FC28
	Color get_color() { }

	// RVA: 0x152FD24
	void set_color(Color value) { }

	// RVA: 0x152FE2C
	Color get_backgroundColor() { }

	// RVA: 0x152FF28
	void set_backgroundColor(Color value) { }

	// RVA: 0x1530030
	Color get_contentColor() { }

	// RVA: 0x153012C
	void set_contentColor(Color value) { }

	// RVA: 0x1530234
	bool get_changed() { }

	// RVA: 0x1530274
	void set_changed(bool value) { }

	// RVA: 0x15302C4
	bool get_enabled() { }

	// RVA: 0x1530304
	void set_enabled(bool value) { }

	// RVA: 0x1530354
	bool get_usePageScrollbars() { }

	// RVA: 0x1530394
	Material get_blendMaterial() { }

	// RVA: 0x15303D4
	Material get_blitMaterial() { }

	// RVA: 0x1530414
	Material get_roundedRectMaterial() { }

	// RVA: 0x1530454
	Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1530494
	void GrabMouseControl(int id) { }

	// RVA: 0x15304E4
	bool HasMouseControl(int id) { }

	// RVA: 0x1530534
	void ReleaseMouseControl() { }

	// RVA: 0x1530574
	void InternalRepaintEditorWindow() { }

	// RVA: 0x15305B4
	Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x1530768
	void .cctor() { }

	// RVA: 0x1530A48
	int get_scrollTroughSide() { }

	// RVA: 0x1530AC4
	void set_scrollTroughSide(int value) { }

	// RVA: 0x1530B50
	DateTime get_nextScrollStepTime() { }

	// RVA: 0x1530BCC
	void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1530C58
	void set_skin(GUISkin value) { }

	// RVA: 0x1530FEC
	GUISkin get_skin() { }

	// RVA: 0x1530DFC
	void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1531284
	Matrix4x4 get_matrix() { }

	// RVA: 0x153135C
	void set_matrix(Matrix4x4 value) { }

	// RVA: 0x153141C
	void Label(Rect position, string text) { }

	// RVA: 0x1531694
	void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1531BDC
	void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1531D18
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1531E10
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1531EBC
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x15320A4
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x15321D0
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x15323BC
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1532520
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x153266C
	void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1532E84
	bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x1532F78
	void Box(Rect position, string text) { }

	// RVA: 0x1533090
	void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x15335CC
	bool Button(Rect position, string text) { }

	// RVA: 0x1533874
	bool Button(Rect position, GUIContent content) { }

	// RVA: 0x15336E4
	bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1533A4C
	bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1533CB4
	bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x15344F0
	string PasswordFieldGetStrToShow(string password, Char maskChar) { }

	// RVA: 0x1534680
	void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x15347A0
	void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x153486C
	void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar) { }

	// RVA: 0x1535368
	void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0x1535BC4
	void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1534DAC
	void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x1536E9C
	bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x153177C
	void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1533B44
	bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1537830
	float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x1537900
	float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1537AC4
	float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x15388A4
	bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x1538C68
	float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x1538284
	float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x1539158
	void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1539234
	void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x15399C0
	void EndGroup() { }

	// RVA: 0x1539A98
	GenericStack get_scrollViewStates() { }

	// RVA: 0x1539B14
	Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x153B468
	void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x153C410
	Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

	// RVA: 0x153C84C
	Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x153C680
	Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x153CA2C
	void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x152FCD4
	void get_color_Injected(out Color ret) { }

	// RVA: 0x152FDDC
	void set_color_Injected(ref Color value) { }

	// RVA: 0x152FED8
	void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x152FFE0
	void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x15300DC
	void get_contentColor_Injected(out Color ret) { }

	// RVA: 0x15301E4
	void set_contentColor_Injected(ref Color value) { }

	// RVA: 0x15306C8
	void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }

}

// Namespace: 
internal struct ParentClipScope 
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x153DE30
	void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x153DEAC
	void Dispose() { }

}

// Namespace: UnityEngine
internal sealed class GUIClip 
{
	// Methods

	// RVA: 0x15376D8
	Rect get_visibleRect() { }

	// RVA: 0x153D9F8
	void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1539A58
	void Internal_Pop() { }

	// RVA: 0x153DAC8
	int Internal_GetCount() { }

	// RVA: 0x153DB08
	Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x15312F4
	Matrix4x4 GetMatrix() { }

	// RVA: 0x15313CC
	void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x153DC68
	void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x153DCD8
	void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x153DD98
	void Internal_PopParentClip() { }

	// RVA: 0x1539958
	void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x153C3D0
	void Pop() { }

	// RVA: 0x153DDD8
	Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x153D9A8
	void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x153DA60
	void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x153DB60
	void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x153DBC8
	void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x153DC18
	void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x153DD40
	void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) { }

}

// Namespace: UnityEngine
public class GUIContent 
{
	// Fields
	private string m_Text; // 0x10
	private Texture m_Image; // 0x18
	private string m_Tooltip; // 0x20
	private Action OnTextChanged; // 0x28
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Methods

	// RVA: 0x1534CA4
	string get_text() { }

	// RVA: 0x1534CAC
	void set_text(string value) { }

	// RVA: 0x153DF08
	void set_image(Texture value) { }

	// RVA: 0x15376D0
	string get_tooltip() { }

	// RVA: 0x153DF10
	void set_tooltip(string value) { }

	// RVA: 0x153DF18
	void .ctor() { }

	// RVA: 0x153DF9C
	void .ctor(string text) { }

	// RVA: 0x153E004
	void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x153E100
	void .ctor(GUIContent src) { }

	// RVA: 0x15315B0
	GUIContent Temp(string t) { }

	// RVA: 0x153E200
	void ClearStaticCache() { }

	// RVA: 0x153E338
	string ToString() { }

	// RVA: 0x153E358
	void .cctor() { }

}

// Namespace: UnityEngine
public enum ScaleMode 
{
	// Fields
	public int value__; // 0x10
	public const ScaleMode StretchToFill = 0;
	public const ScaleMode ScaleAndCrop = 1;
	public const ScaleMode ScaleToFit = 2;
}

// Namespace: UnityEngine
public enum FocusType 
{
	// Fields
	public int value__; // 0x10
	public const FocusType Native = 0;
	public const FocusType Keyboard = 1;
	public const FocusType Passive = 2;
}

// Namespace: UnityEngine
public class GUILayout 
{
	// Methods

	// RVA: 0x153E594
	void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x153E8D0
	void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153E70C
	void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153E9C4
	bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x153EC74
	bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153EB3C
	bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153ECF0
	string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x153F288
	string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153EE28
	string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153F384
	float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x153F56C
	float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x153F778
	void Space(float pixels) { }

	// RVA: 0x153FDD8
	void FlexibleSpace() { }

	// RVA: 0x1540334
	void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x15403FC
	void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1540994
	void EndHorizontal() { }

	// RVA: 0x1540D08
	void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1540DD0
	void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1540FA4
	void EndVertical() { }

	// RVA: 0x154100C
	void BeginArea(Rect screenRect) { }

	// RVA: 0x1541394
	void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x15410F4
	void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x15417C8
	void EndArea() { }

	// RVA: 0x1541BDC
	Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x1541E54
	Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x1542120
	void EndScrollView() { }

	// RVA: 0x15421D0
	void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x153D1FC
	GUILayoutOption Width(float width) { }

	// RVA: 0x1542290
	GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x1542344
	GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x153D2AC
	GUILayoutOption Height(float height) { }

	// RVA: 0x15423F8
	GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x1540244
	GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1540198
	GUILayoutOption ExpandHeight(bool expand) { }

}

// Namespace: 
internal enum Type 
{
	// Fields
	public int value__; // 0x10
	public const Type fixedWidth = 0;
	public const Type fixedHeight = 1;
	public const Type minWidth = 2;
	public const Type maxWidth = 3;
	public const Type minHeight = 4;
	public const Type maxHeight = 5;
	public const Type stretchWidth = 6;
	public const Type stretchHeight = 7;
	public const Type alignStart = 8;
	public const Type alignMiddle = 9;
	public const Type alignEnd = 10;
	public const Type alignJustify = 11;
	public const Type equalSize = 12;
	public const Type spacing = 13;
}

// Namespace: UnityEngine
public sealed class GUILayoutOption 
{
	// Fields
	internal Type type; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x15402F0
	void .ctor(Type type, object value) { }

}

// Namespace: 
internal sealed class LayoutCache 
{
	// Fields
	private int <id>k__BackingField; // 0x10
	internal GUILayoutGroup topLevel; // 0x18
	internal GenericStack layoutGroups; // 0x20
	internal GUILayoutGroup windows; // 0x28

	// Methods

	// RVA: 0x1544798
	void set_id(int value) { }

	// RVA: 0x15428BC
	void .ctor(int instanceID) { }

	// RVA: 0x15447A0
	void ResetCursor() { }

}

// Namespace: UnityEngine
public class GUILayoutUtility 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18
	private static int <unbalancedgroupscount>k__BackingField; // 0x28
	private static GUIStyle s_SpaceStyle; // 0x30

	// Methods

	// RVA: 0x15424AC
	Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x15425D0
	void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x15426EC
	int get_unbalancedgroupscount() { }

	// RVA: 0x1542768
	void set_unbalancedgroupscount(int value) { }

	// RVA: 0x15427F4
	LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x153D044
	LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x15429C8
	void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x1542AB4
	void Begin(int instanceID) { }

	// RVA: 0x1542D08
	void BeginContainer(LayoutCache cache) { }

	// RVA: 0x153D360
	void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153D66C
	void Layout() { }

	// RVA: 0x1543464
	void LayoutFromEditorWindow() { }

	// RVA: 0x15436A4
	void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1542F88
	void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x15431D4
	void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x154384C
	GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x15405CC
	GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x15409FC
	void EndLayoutGroup() { }

	// RVA: 0x1541430
	GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x15419D0
	void EndLayoutArea() { }

	// RVA: 0x1543AAC
	Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x153E94C
	Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1543B18
	Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x153FD50
	Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x154420C
	Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1544420
	Rect GetLastRect() { }

	// RVA: 0x153FB74
	GUIStyle get_spaceStyle() { }

	// RVA: 0x1544678
	void .cctor() { }

	// RVA: 0x1542568
	void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1542684
	void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }

}

// Namespace: UnityEngine
public sealed class GUISettings 
{
	// Fields
	private bool m_DoubleClickSelectsWord; // 0x10
	private bool m_TripleClickSelectsLine; // 0x11
	private Color m_CursorColor; // 0x14
	private float m_CursorFlashSpeed; // 0x24
	private Color m_SelectionColor; // 0x28

	// Methods

	// RVA: 0x1544A84
	float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x1536DA4
	bool get_doubleClickSelectsWord() { }

	// RVA: 0x1536DAC
	bool get_tripleClickSelectsLine() { }

	// RVA: 0x1544AC4
	Color get_cursorColor() { }

	// RVA: 0x1544AD0
	float get_cursorFlashSpeed() { }

	// RVA: 0x1544B28
	Color get_selectionColor() { }

	// RVA: 0x1544B34
	void set_selectionColor(Color value) { }

	// RVA: 0x1544B40
	void .ctor() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate 
{
	// Methods

	// RVA: 0x15484D8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1548578
	internal void Invoke() { }

}

// Namespace: UnityEngine
public sealed class GUISkin 
{
	// Fields
	private Font m_Font; // 0x18
	private GUIStyle m_box; // 0x20
	private GUIStyle m_button; // 0x28
	private GUIStyle m_toggle; // 0x30
	private GUIStyle m_label; // 0x38
	private GUIStyle m_textField; // 0x40
	private GUIStyle m_textArea; // 0x48
	private GUIStyle m_window; // 0x50
	private GUIStyle m_horizontalSlider; // 0x58
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	private GUIStyle m_verticalSlider; // 0x70
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	private GUIStyle m_horizontalScrollbar; // 0x90
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	private GUIStyle m_verticalScrollbar; // 0xB0
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	private GUIStyle m_ScrollView; // 0xD0
	internal GUIStyle[] m_CustomStyles; // 0xD8
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.GUIStyle> m_Styles; // 0xE8
	internal static SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Methods

	// RVA: 0x1544B6C
	void .ctor() { }

	// RVA: 0x1544C48
	void OnEnable() { }

	// RVA: 0x1544D78
	void CleanupRoots() { }

	// RVA: 0x1536E04
	Font get_font() { }

	// RVA: 0x1544DE4
	void set_font(Font value) { }

	// RVA: 0x1533088
	GUIStyle get_box() { }

	// RVA: 0x1544FFC
	void set_box(GUIStyle value) { }

	// RVA: 0x153168C
	GUIStyle get_label() { }

	// RVA: 0x154509C
	void set_label(GUIStyle value) { }

	// RVA: 0x153EE20
	GUIStyle get_textField() { }

	// RVA: 0x154513C
	void set_textField(GUIStyle value) { }

	// RVA: 0x15451DC
	GUIStyle get_textArea() { }

	// RVA: 0x15451E4
	void set_textArea(GUIStyle value) { }

	// RVA: 0x15336DC
	GUIStyle get_button() { }

	// RVA: 0x1545284
	void set_button(GUIStyle value) { }

	// RVA: 0x1545324
	GUIStyle get_toggle() { }

	// RVA: 0x154532C
	void set_toggle(GUIStyle value) { }

	// RVA: 0x153C678
	GUIStyle get_window() { }

	// RVA: 0x15453CC
	void set_window(GUIStyle value) { }

	// RVA: 0x153F55C
	GUIStyle get_horizontalSlider() { }

	// RVA: 0x154546C
	void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x153F564
	GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x154550C
	void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x15455AC
	GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x15455B4
	void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1545654
	GUIStyle get_sliderMixed() { }

	// RVA: 0x154565C
	void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x15456FC
	GUIStyle get_verticalSlider() { }

	// RVA: 0x1545704
	void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x15457A4
	GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x15457AC
	void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x154584C
	GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1545854
	void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1541E3C
	GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x15458F4
	void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1545994
	GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x154599C
	void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1545A3C
	GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1545A44
	void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1545AE4
	GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1545AEC
	void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1541E44
	GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1545B8C
	void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1545C2C
	GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1545C34
	void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1545CD4
	GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1545CDC
	void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1545D7C
	GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1545D84
	void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1541E4C
	GUIStyle get_scrollView() { }

	// RVA: 0x1545E24
	void set_scrollView(GUIStyle value) { }

	// RVA: 0x1545EC4
	GUIStyle[] get_customStyles() { }

	// RVA: 0x1545ECC
	void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1536D9C
	GUISettings get_settings() { }

	// RVA: 0x1545F80
	GUIStyle get_error() { }

	// RVA: 0x1544CE0
	void Apply() { }

	// RVA: 0x1546198
	void BuildStyleCache() { }

	// RVA: 0x1537F98
	GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1548380
	GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1531184
	void MakeCurrent() { }

	// RVA: 0x1548414
	IEnumerator GetEnumerator() { }

}

// Namespace: UnityEngine
internal class GUIStateObjects 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x154858C
	object GetStateObject(Type t, int controlID) { }

	// RVA: 0x154872C
	void .cctor() { }

}

// Namespace: UnityEngine
public sealed class GUIStyleState 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x15487C8
	void set_background(Texture2D value) { }

	// RVA: 0x1548328
	void set_textColor(Color value) { }

	// RVA: 0x1548898
	IntPtr Init() { }

	// RVA: 0x15488D8
	void Cleanup() { }

	// RVA: 0x1548928
	void .ctor() { }

	// RVA: 0x1548984
	void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x15489CC
	GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1548A48
	void Finalize() { }

	// RVA: 0x1548830
	void set_textColor_Injected(ref Color value) { }

}

// Namespace: UnityEngine
public sealed class GUIStyle 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Methods

	// RVA: 0x1548B10
	string get_rawName() { }

	// RVA: 0x1548B60
	void set_rawName(string value) { }

	// RVA: 0x1536DB4
	Font get_font() { }

	// RVA: 0x1548BC8
	ImagePosition get_imagePosition() { }

	// RVA: 0x1548C18
	void set_alignment(TextAnchor value) { }

	// RVA: 0x1548C80
	bool get_wordWrap() { }

	// RVA: 0x1548CD0
	Vector2 get_contentOffset() { }

	// RVA: 0x1548D90
	void set_contentOffset(Vector2 value) { }

	// RVA: 0x15390B8
	float get_fixedWidth() { }

	// RVA: 0x1548E4C
	void set_fixedWidth(float value) { }

	// RVA: 0x1539108
	float get_fixedHeight() { }

	// RVA: 0x1548EB4
	bool get_stretchWidth() { }

	// RVA: 0x1544610
	void set_stretchWidth(bool value) { }

	// RVA: 0x1548F04
	bool get_stretchHeight() { }

	// RVA: 0x15481DC
	void set_stretchHeight(bool value) { }

	// RVA: 0x1548F54
	void set_fontSize(int value) { }

	// RVA: 0x1548FBC
	void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0x1549078
	IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0x15490C8
	IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0x1549130
	void Internal_Destroy(IntPtr self) { }

	// RVA: 0x1549180
	IntPtr GetStyleStatePtr(int idx) { }

	// RVA: 0x15491E8
	IntPtr GetRectOffsetPtr(int idx) { }

	// RVA: 0x1549250
	void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	// RVA: 0x15492A8
	float Internal_GetLineHeight(IntPtr target) { }

	// RVA: 0x15492F8
	void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1549418
	void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1549508
	void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x15495F4
	void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x154976C
	Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1549858
	int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1549930
	string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1549A20
	Vector2 Internal_CalcSize(GUIContent content) { }

	// RVA: 0x1549AE0
	Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0x1549BB8
	float Internal_CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1549C18
	Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0x153777C
	void SetMouseTooltip(string tooltip, Rect screenRect) { }

	// RVA: 0x153772C
	bool IsTooltipActive(string tooltip) { }

	// RVA: 0x1549D40
	float Internal_GetCursorFlashOffset() { }

	// RVA: 0x1544FAC
	void SetDefaultFont(Font font) { }

	// RVA: 0x1544554
	void .ctor() { }

	// RVA: 0x1549D80
	void .ctor(GUIStyle other) { }

	// RVA: 0x1549EA0
	void Finalize() { }

	// RVA: 0x1537F14
	string get_name() { }

	// RVA: 0x1546128
	void set_name(string value) { }

	// RVA: 0x1548244
	GUIStyleState get_normal() { }

	// RVA: 0x153B298
	RectOffset get_margin() { }

	// RVA: 0x1549FB8
	RectOffset get_padding() { }

	// RVA: 0x154A090
	void set_padding(RectOffset value) { }

	// RVA: 0x154A0EC
	float get_lineHeight() { }

	// RVA: 0x153B370
	void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1537638
	void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1539830
	void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x1536CB4
	void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x15333E8
	void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x154A24C
	void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x154A4C8
	void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x154A8A0
	void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x154ACD4
	void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x154AFE4
	void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x15396C4
	GUIStyle get_none() { }

	// RVA: 0x154AFEC
	Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x154B068
	int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x154B0D8
	Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x15440A0
	Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x154B140
	float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1543FC0
	bool get_isHeightDependantOnWidth() { }

	// RVA: 0x154B1A0
	void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x154B220
	string ToString() { }

	// RVA: 0x154B32C
	void .cctor() { }

	// RVA: 0x1548D28
	void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x1548DE4
	void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1549010
	void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x1549390
	void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1549498
	void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1549584
	void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x15496C4
	void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x15497E8
	void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x15498C8
	int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x15499B0
	string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1549A88
	void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1549B50
	void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x1549C80
	void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x1549CD8
	void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

}

// Namespace: UnityEngine
public enum ImagePosition 
{
	// Fields
	public int value__; // 0x10
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
public class GUITargetAttribute 
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	// RVA: 0x154B37C
	int GetGUITargetAttrValue(Type klass, string methodName) { }

}

// Namespace: UnityEngine
public class GUIUtility 
{
	// Fields
	internal static int s_ControlCount; // 0x0
	internal static int s_SkinMode; // 0x4
	internal static int s_OriginalID; // 0x8
	internal static Action takeCapture; // 0x10
	internal static Action releaseCapture; // 0x18
	internal static System.Func<System.Int32,System.IntPtr,System.Boolean> processEvent; // 0x20
	internal static Action cleanupRoots; // 0x28
	internal static System.Func<System.Exception,System.Boolean> endContainerGUIFromException; // 0x30
	internal static Action guiChanged; // 0x38
	internal static System.Action<UnityEngine.EventType,UnityEngine.KeyCode> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static System.Func<System.Boolean> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Methods

	// RVA: 0x1542F48
	float get_pixelsPerPoint() { }

	// RVA: 0x154B52C
	int get_guiDepth() { }

	// RVA: 0x1539908
	void set_mouseUsed(bool value) { }

	// RVA: 0x152FBE8
	bool get_textFieldInput() { }

	// RVA: 0x1536E4C
	void set_textFieldInput(bool value) { }

	// RVA: 0x154B56C
	string get_systemCopyBuffer() { }

	// RVA: 0x154B5AC
	void set_systemCopyBuffer(string value) { }

	// RVA: 0x154B5FC
	int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x1533934
	int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x154B710
	void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x154B760
	void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0x154B7B0
	void Internal_EndContainer() { }

	// RVA: 0x154B7F0
	int CheckForTabEvent(Event evt) { }

	// RVA: 0x154B840
	void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x154B880
	void SetKeyboardControlToLastControlId() { }

	// RVA: 0x154B8C0
	bool HasFocusableControls() { }

	// RVA: 0x154B900
	bool OwnsId(int id) { }

	// RVA: 0x154B950
	Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	// RVA: 0x1536E0C
	string get_compositionString() { }

	// RVA: 0x154BA88
	void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x154BAD8
	void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x154BBDC
	int Internal_GetHotControl() { }

	// RVA: 0x154BC1C
	int Internal_GetKeyboardControl() { }

	// RVA: 0x154BC5C
	void Internal_SetHotControl(int value) { }

	// RVA: 0x154BCAC
	void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x154BCFC
	object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x154BD4C
	void Internal_ExitGUI() { }

	// RVA: 0x154BD8C
	void MarkGUIChanged() { }

	// RVA: 0x153F29C
	int GetControlID(FocusType focus) { }

	// RVA: 0x1533348
	int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x1534D20
	object GetStateObject(Type t, int controlID) { }

	// RVA: 0x154BE1C
	void set_guiIsExiting(bool value) { }

	// RVA: 0x1534460
	int get_hotControl() { }

	// RVA: 0x15343B4
	void set_hotControl(int value) { }

	// RVA: 0x154BEA8
	void TakeCapture() { }

	// RVA: 0x154BF38
	void RemoveCapture() { }

	// RVA: 0x1536B78
	int get_keyboardControl() { }

	// RVA: 0x1536C08
	void set_keyboardControl(int value) { }

	// RVA: 0x154A334
	bool HasKeyFocus(int controlID) { }

	// RVA: 0x154BFC8
	void ExitGUI() { }

	// RVA: 0x15310A8
	GUISkin GetDefaultSkin() { }

	// RVA: 0x154C118
	void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	// RVA: 0x154C330
	void EndContainer() { }

	// RVA: 0x154C3F0
	void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	// RVA: 0x154C710
	void DestroyGUI(int instanceID) { }

	// RVA: 0x154C798
	void EndGUI(int layoutType) { }

	// RVA: 0x154C9C8
	bool EndGUIFromException(Exception exception) { }

	// RVA: 0x154CC40
	bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x154C4E0
	void ResetGlobalState() { }

	// RVA: 0x154CD28
	bool IsExitGUIException(Exception exception) { }

	// RVA: 0x154CB40
	bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1530D18
	void CheckOnGUI() { }

	// RVA: 0x154CDC4
	float RoundToPixelGrid(float v) { }

	// RVA: 0x154CEA8
	Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x154CFE0
	bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x154D02C
	bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x1537454
	bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x154D110
	void .cctor() { }

	// RVA: 0x154B6B8
	int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x154BA20
	void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	// RVA: 0x154BB8C
	void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException 
{
	// Methods

	// RVA: 0x154C004
	void .ctor() { }

	// RVA: 0x15439BC
	void .ctor(string message) { }

}

// Namespace: UnityEngine
internal class GUILayoutEntry 
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Methods

	// RVA: 0x154D1C8
	GUIStyle get_style() { }

	// RVA: 0x1542F10
	void set_style(GUIStyle value) { }

	// RVA: 0x154D1D0
	int get_marginLeft() { }

	// RVA: 0x154D298
	int get_marginRight() { }

	// RVA: 0x154D360
	int get_marginTop() { }

	// RVA: 0x154D428
	int get_marginBottom() { }

	// RVA: 0x154D4F0
	int get_marginHorizontal() { }

	// RVA: 0x154D530
	int get_marginVertical() { }

	// RVA: 0x154D570
	void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1544110
	void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x154D664
	void CalcWidth() { }

	// RVA: 0x154D668
	void CalcHeight() { }

	// RVA: 0x154D66C
	void SetHorizontal(float x, float width) { }

	// RVA: 0x154D678
	void SetVertical(float y, float height) { }

	// RVA: 0x154D684
	void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x154D7AC
	void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x154DA9C
	string ToString() { }

	// RVA: 0x154E05C
	void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer 
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly float m_ForcedMinHeight; // 0x50
	private readonly float m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0x154E0B4
	void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x154E1A0
	void CalcWidth() { }

	// RVA: 0x154E248
	void CalcHeight() { }

}

// Namespace: UnityEngine
internal class GUILayoutGroup 
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Methods

	// RVA: 0x154E2C0
	int get_marginLeft() { }

	// RVA: 0x154E2C8
	int get_marginRight() { }

	// RVA: 0x154E2D0
	int get_marginTop() { }

	// RVA: 0x154E2D8
	int get_marginBottom() { }

	// RVA: 0x154E2E0
	void .ctor() { }

	// RVA: 0x154E428
	void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x154E548
	void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x154E5C8
	void ResetCursor() { }

	// RVA: 0x154E5D0
	GUILayoutEntry GetNext() { }

	// RVA: 0x154E88C
	Rect GetLast() { }

	// RVA: 0x154EBB8
	void Add(GUILayoutEntry e) { }

	// RVA: 0x154EC1C
	void CalcWidth() { }

	// RVA: 0x154F398
	void SetHorizontal(float x, float width) { }

	// RVA: 0x154FE18
	void CalcHeight() { }

	// RVA: 0x155051C
	void SetVertical(float y, float height) { }

	// RVA: 0x1550FB0
	string ToString() { }

	// RVA: 0x15513EC
	void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup 
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	// RVA: 0x15514CC
	void .ctor() { }

	// RVA: 0x155155C
	void CalcWidth() { }

	// RVA: 0x15515D8
	void SetHorizontal(float x, float width) { }

	// RVA: 0x15516D4
	void CalcHeight() { }

	// RVA: 0x15517AC
	void SetVertical(float y, float height) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1551934
	void .ctor() { }

	// RVA: 0x15519D0
	void Dispose() { }

	// RVA: 0x1551B04
	void Finalize() { }

	// RVA: 0x1551A9C
	void Destroy() { }

	// RVA: 0x1551990
	IntPtr Internal_Create() { }

	// RVA: 0x1551BE0
	void Internal_Destroy(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class ScrollViewState 
{
	// Fields
	public Rect position; // 0x10
	public Rect visibleRect; // 0x20
	public Rect viewRect; // 0x30
	public Vector2 scrollPosition; // 0x40
	public bool apply; // 0x48
	public bool isDuringTouchScroll; // 0x49
	public Vector2 touchScrollStartMousePosition; // 0x4C
	public Vector2 touchScrollStartPosition; // 0x54
	public Vector2 velocity; // 0x5C
	public float previousTimeSinceStartup; // 0x64

	// Methods

	// RVA: 0x1551C30
	void .ctor() { }

}

// Namespace: UnityEngine
internal class SliderState 
{
	// Fields
	public float dragStartPos; // 0x10
	public float dragStartValue; // 0x14
	public bool isDragging; // 0x18

	// Methods

	// RVA: 0x1551C38
	void .ctor() { }

}

// Namespace: UnityEngine
internal struct SliderHandler 
{
	// Fields
	private readonly Rect position; // 0x10
	private readonly float currentValue; // 0x20
	private readonly float size; // 0x24
	private readonly float start; // 0x28
	private readonly float end; // 0x2C
	private readonly GUIStyle slider; // 0x30
	private readonly GUIStyle thumb; // 0x38
	private readonly GUIStyle thumbExtent; // 0x40
	private readonly bool horiz; // 0x48
	private readonly int id; // 0x4C

	// Methods

	// RVA: 0x1551C40
	void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1551CBC
	float Handle() { }

	// RVA: 0x1551DA0
	float OnMouseDown() { }

	// RVA: 0x1552284
	float OnMouseDrag() { }

	// RVA: 0x1552414
	float OnMouseUp() { }

	// RVA: 0x15524F0
	float OnRepaint() { }

	// RVA: 0x1551D6C
	EventType CurrentEventType() { }

	// RVA: 0x1552E74
	int CurrentScrollTroughSide() { }

	// RVA: 0x1552C0C
	bool IsEmptySlider() { }

	// RVA: 0x1552CD4
	bool SupportsPageMovements() { }

	// RVA: 0x1552F00
	float PageMovementValue() { }

	// RVA: 0x15532B8
	float PageUpMovementBound() { }

	// RVA: 0x1552C04
	Event CurrentEvent() { }

	// RVA: 0x1552FFC
	float ValueForCurrentMousePosition() { }

	// RVA: 0x15530D8
	float Clamp(float value) { }

	// RVA: 0x1552BA4
	Rect ThumbSelectionRect() { }

	// RVA: 0x1552C48
	void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x1552D58
	SliderState SliderState() { }

	// RVA: 0x1553210
	Rect ThumbExtRect() { }

	// RVA: 0x15532A8
	Rect ThumbRect() { }

	// RVA: 0x1553338
	Rect VerticalThumbRect() { }

	// RVA: 0x155345C
	Rect HorizontalThumbRect() { }

	// RVA: 0x1552C1C
	float ClampedCurrentValue() { }

	// RVA: 0x1553104
	float MousePosition() { }

	// RVA: 0x1553168
	float ValuesPerPixel() { }

	// RVA: 0x1553580
	float ThumbSize() { }

	// RVA: 0x1553320
	float MaxValue() { }

	// RVA: 0x1553310
	float MinValue() { }

}

// Namespace: UnityEngine
internal enum TextEditOp 
{
	// Fields
	public int value__; // 0x10
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp Delete = 18;
	public const TextEditOp Backspace = 19;
	public const TextEditOp DeleteWordBack = 20;
	public const TextEditOp DeleteWordForward = 21;
	public const TextEditOp DeleteLineBack = 22;
	public const TextEditOp Cut = 23;
	public const TextEditOp Paste = 24;
	public const TextEditOp ScrollStart = 25;
	public const TextEditOp ScrollEnd = 26;
	public const TextEditOp ScrollPageUp = 27;
	public const TextEditOp ScrollPageDown = 28;
}

// Namespace: UnityEngine
internal enum TextSelectOp 
{
	// Fields
	public int value__; // 0x10
	public const TextSelectOp SelectLeft = 0;
	public const TextSelectOp SelectRight = 1;
	public const TextSelectOp SelectUp = 2;
	public const TextSelectOp SelectDown = 3;
	public const TextSelectOp SelectTextStart = 4;
	public const TextSelectOp SelectTextEnd = 5;
	public const TextSelectOp SelectPageUp = 6;
	public const TextSelectOp SelectPageDown = 7;
	public const TextSelectOp ExpandSelectGraphicalLineStart = 8;
	public const TextSelectOp ExpandSelectGraphicalLineEnd = 9;
	public const TextSelectOp SelectGraphicalLineStart = 10;
	public const TextSelectOp SelectGraphicalLineEnd = 11;
	public const TextSelectOp SelectWordLeft = 12;
	public const TextSelectOp SelectWordRight = 13;
	public const TextSelectOp SelectToEndOfPreviousWord = 14;
	public const TextSelectOp SelectToStartOfNextWord = 15;
	public const TextSelectOp SelectParagraphBackward = 16;
	public const TextSelectOp SelectParagraphForward = 17;
	public const TextSelectOp Copy = 18;
	public const TextSelectOp SelectAll = 19;
	public const TextSelectOp SelectNone = 20;
}

// Namespace: UnityEngine
internal class TextEditingUtilities 
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	private TextHandle m_TextHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	public bool multiline; // 0x26
	private string m_Text; // 0x28
	private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditOp> s_KeyEditOps; // 0x0

	// Methods

	// RVA: 0x1553648
	bool get_hasSelection() { }

	// RVA: 0x1553704
	void set_revealCursor(bool value) { }

	// RVA: 0x1553778
	int get_cursorIndex() { }

	// RVA: 0x155383C
	void set_cursorIndex(int value) { }

	// RVA: 0x15538B0
	int get_selectIndex() { }

	// RVA: 0x1553974
	void set_selectIndex(int value) { }

	// RVA: 0x15539E8
	string get_text() { }

	// RVA: 0x15539F0
	void set_text(string value) { }

	// RVA: 0x1553A94
	void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x1553B04
	bool UpdateImeState() { }

	// RVA: 0x1553DDC
	bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x1553DE4
	void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x1553ED0
	string GeneratePreviewString(bool richText) { }

	// RVA: 0x1554178
	void EnableCursorPreviewState() { }

	// RVA: 0x15540E4
	void RestoreCursorState() { }

	// RVA: 0x15542D4
	bool HandleKeyEvent(Event e) { }

	// RVA: 0x1555A04
	void PerformOperation(TextEditOp operation) { }

	// RVA: 0x1558940
	void MapKey(string key, TextEditOp action) { }

	// RVA: 0x155446C
	void InitKeyActions() { }

	// RVA: 0x15583C4
	bool DeleteLineBack() { }

	// RVA: 0x15580F0
	bool DeleteWordBack() { }

	// RVA: 0x15586A4
	bool DeleteWordForward() { }

	// RVA: 0x1557A70
	bool Delete() { }

	// RVA: 0x1557D0C
	bool Backspace() { }

	// RVA: 0x15589E4
	bool DeleteSelection() { }

	// RVA: 0x1553BE0
	void ReplaceSelection(string replace) { }

	// RVA: 0x155947C
	void Insert(Char c) { }

	// RVA: 0x15594FC
	bool CanPaste() { }

	// RVA: 0x1557F94
	bool Cut() { }

	// RVA: 0x1557FC4
	bool Paste() { }

	// RVA: 0x15596A0
	string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x1559738
	void OnBlur() { }

	// RVA: 0x1559884
	bool TouchScreenKeyboardShouldBeUsed() { }

}

// Namespace: 
public enum DblClickSnapping 
{
	// Fields
	public Byte value__; // 0x10
	public const DblClickSnapping WORDS = 0;
	public const DblClickSnapping PARAGRAPHS = 1;
}

// Namespace: 
private enum CharacterType 
{
	// Fields
	public int value__; // 0x10
	public const CharacterType LetterLike = 0;
	public const CharacterType Symbol = 1;
	public const CharacterType Symbol2 = 2;
	public const CharacterType WhiteSpace = 3;
}

// Namespace: 
private enum Direction 
{
	// Fields
	public int value__; // 0x10
	public const Direction Forward = 0;
	public const Direction Backward = 1;
}

// Namespace: 
private enum TextEditOp 
{
	// Fields
	public int value__; // 0x10
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp SelectLeft = 18;
	public const TextEditOp SelectRight = 19;
	public const TextEditOp SelectUp = 20;
	public const TextEditOp SelectDown = 21;
	public const TextEditOp SelectTextStart = 22;
	public const TextEditOp SelectTextEnd = 23;
	public const TextEditOp SelectPageUp = 24;
	public const TextEditOp SelectPageDown = 25;
	public const TextEditOp ExpandSelectGraphicalLineStart = 26;
	public const TextEditOp ExpandSelectGraphicalLineEnd = 27;
	public const TextEditOp SelectGraphicalLineStart = 28;
	public const TextEditOp SelectGraphicalLineEnd = 29;
	public const TextEditOp SelectWordLeft = 30;
	public const TextEditOp SelectWordRight = 31;
	public const TextEditOp SelectToEndOfPreviousWord = 32;
	public const TextEditOp SelectToStartOfNextWord = 33;
	public const TextEditOp SelectParagraphBackward = 34;
	public const TextEditOp SelectParagraphForward = 35;
	public const TextEditOp Delete = 36;
	public const TextEditOp Backspace = 37;
	public const TextEditOp DeleteWordBack = 38;
	public const TextEditOp DeleteWordForward = 39;
	public const TextEditOp DeleteLineBack = 40;
	public const TextEditOp Cut = 41;
	public const TextEditOp Copy = 42;
	public const TextEditOp Paste = 43;
	public const TextEditOp SelectAll = 44;
	public const TextEditOp SelectNone = 45;
	public const TextEditOp ScrollStart = 46;
	public const TextEditOp ScrollEnd = 47;
	public const TextEditOp ScrollPageUp = 48;
	public const TextEditOp ScrollPageDown = 49;
}

// Namespace: UnityEngine
public class TextEditor 
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	internal bool m_HasFocus; // 0x2B
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private Rect m_Position; // 0x40
	private int m_CursorIndex; // 0x50
	private int m_SelectIndex; // 0x54
	private bool m_RevealCursor; // 0x58
	public Vector2 graphicalCursorPos; // 0x5C
	public Vector2 graphicalSelectCursorPos; // 0x64
	private bool m_MouseDragSelectsWholeWords; // 0x6C
	private int m_DblClickInitPos; // 0x70
	private DblClickSnapping m_DblClickSnap; // 0x74
	private bool m_bJustSelected; // 0x75
	private int m_iAltCursorPos; // 0x78
	private string oldText; // 0x80
	private int oldPos; // 0x88
	private int oldSelectPos; // 0x8C
	private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditor.TextEditOp> s_Keyactions; // 0x0

	// Methods

	// RVA: 0x1559928
	string get_text() { }

	// RVA: 0x1559948
	void set_text(string value) { }

	// RVA: 0x1559AE0
	Rect get_position() { }

	// RVA: 0x1559AEC
	void set_position(Rect value) { }

	// RVA: 0x1559E64
	Rect get_localPosition() { }

	// RVA: 0x1559E70
	int get_cursorIndex() { }

	// RVA: 0x1559E78
	void set_cursorIndex(int value) { }

	// RVA: 0x1559F2C
	int get_selectIndex() { }

	// RVA: 0x1559F34
	void set_selectIndex(int value) { }

	// RVA: 0x1559FD8
	void ClearCursorPos() { }

	// RVA: 0x1559FE8
	void .ctor() { }

	// RVA: 0x155A114
	void OnFocus() { }

	// RVA: 0x155A1FC
	void OnLostFocus() { }

	// RVA: 0x155A254
	void GrabGraphicalCursorPos() { }

	// RVA: 0x155A2E8
	bool HandleKeyEvent(Event e) { }

	// RVA: 0x155A2F0
	bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x155CE5C
	bool DeleteLineBack() { }

	// RVA: 0x155D10C
	bool DeleteWordBack() { }

	// RVA: 0x155D2D0
	bool DeleteWordForward() { }

	// RVA: 0x155D570
	bool Delete() { }

	// RVA: 0x155D738
	bool Backspace() { }

	// RVA: 0x155A1A8
	void SelectAll() { }

	// RVA: 0x155D8D8
	void SelectNone() { }

	// RVA: 0x155CF58
	bool get_hasSelection() { }

	// RVA: 0x155CF68
	bool DeleteSelection() { }

	// RVA: 0x155D908
	void ReplaceSelection(string replace) { }

	// RVA: 0x155D9A4
	void Insert(Char c) { }

	// RVA: 0x155DA24
	void MoveRight() { }

	// RVA: 0x155DAB4
	void MoveLeft() { }

	// RVA: 0x155DB2C
	void MoveUp() { }

	// RVA: 0x155DBEC
	void MoveDown() { }

	// RVA: 0x155DCD4
	void MoveLineStart() { }

	// RVA: 0x155DD54
	void MoveLineEnd() { }

	// RVA: 0x155DDF8
	void MoveGraphicalLineStart() { }

	// RVA: 0x155DF18
	void MoveGraphicalLineEnd() { }

	// RVA: 0x155E050
	void MoveTextStart() { }

	// RVA: 0x155E07C
	void MoveTextEnd() { }

	// RVA: 0x155E0C8
	int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x155E13C
	void MoveParagraphForward() { }

	// RVA: 0x155E1C4
	void MoveParagraphBackward() { }

	// RVA: 0x155E248
	void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x155E29C
	void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x155E330
	void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x155E7C8
	void SelectLeft() { }

	// RVA: 0x155E824
	void SelectRight() { }

	// RVA: 0x155E880
	void SelectUp() { }

	// RVA: 0x155E8E8
	void SelectDown() { }

	// RVA: 0x155E96C
	void SelectTextEnd() { }

	// RVA: 0x155E9A8
	void SelectTextStart() { }

	// RVA: 0x155E9B0
	void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x155E9C0
	void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x155DE3C
	int GetGraphicalLineStart(int p) { }

	// RVA: 0x155DF5C
	int GetGraphicalLineEnd(int p) { }

	// RVA: 0x155E9C8
	int FindNextSeperator(int startPos) { }

	// RVA: 0x155EBAC
	int FindPrevSeperator(int startPos) { }

	// RVA: 0x155EC58
	void MoveWordRight() { }

	// RVA: 0x155ECB8
	void MoveToStartOfNextWord() { }

	// RVA: 0x155ED1C
	void MoveToEndOfPreviousWord() { }

	// RVA: 0x155EDB0
	void SelectToStartOfNextWord() { }

	// RVA: 0x155EDE8
	void SelectToEndOfPreviousWord() { }

	// RVA: 0x155EA70
	CharacterType ClassifyChar(int index) { }

	// RVA: 0x155D3A0
	int FindStartOfNextWord(int p) { }

	// RVA: 0x155D1E0
	int FindEndOfPreviousWord(int p) { }

	// RVA: 0x155EE20
	void MoveWordLeft() { }

	// RVA: 0x155EE6C
	void SelectWordRight() { }

	// RVA: 0x155EF2C
	void SelectWordLeft() { }

	// RVA: 0x155EFD4
	void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x155F03C
	void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x155F0A4
	void SelectGraphicalLineStart() { }

	// RVA: 0x155F0DC
	void SelectGraphicalLineEnd() { }

	// RVA: 0x155F114
	void SelectParagraphForward() { }

	// RVA: 0x155F1B0
	void SelectParagraphBackward() { }

	// RVA: 0x155F274
	void SelectCurrentWord() { }

	// RVA: 0x155E630
	int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x155F2EC
	void SelectCurrentParagraph() { }

	// RVA: 0x155F394
	void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0x1559BA4
	void UpdateScrollOffset() { }

	// RVA: 0x155F3F4
	void DrawCursor(string newText) { }

	// RVA: 0x155C6F8
	bool PerformOperation(TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x155F940
	void SaveBackup() { }

	// RVA: 0x155F78C
	bool Cut() { }

	// RVA: 0x155F7C8
	void Copy() { }

	// RVA: 0x155F988
	string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x155F88C
	bool Paste() { }

	// RVA: 0x155FA20
	void MapKey(string key, TextEditOp action) { }

	// RVA: 0x155A41C
	void InitKeyActions() { }

	// RVA: 0x155DAA8
	void DetectFocusChange() { }

	// RVA: 0x155FAC4
	void OnDetectFocusChange() { }

	// RVA: 0x155FBE4
	void OnCursorIndexChange() { }

	// RVA: 0x155FBE8
	void OnSelectIndexChange() { }

	// RVA: 0x155FBEC
	void ClampTextIndex(ref int index) { }

	// RVA: 0x1559A68
	void EnsureValidCodePointIndex(ref int index) { }

	// RVA: 0x155FC3C
	bool IsValidCodePointIndex(int index) { }

	// RVA: 0x155D814
	int PreviousCodePointIndex(int index) { }

	// RVA: 0x155D64C
	int NextCodePointIndex(int index) { }

}

// Namespace: 
private enum CharacterType 
{
	// Fields
	public int value__; // 0x10
	public const CharacterType LetterLike = 0;
	public const CharacterType Symbol = 1;
	public const CharacterType Symbol2 = 2;
	public const CharacterType WhiteSpace = 3;
	public const CharacterType NewLine = 4;
}

// Namespace: 
private enum Direction 
{
	// Fields
	public int value__; // 0x10
	public const Direction Forward = 0;
	public const Direction Backward = 1;
}

// Namespace: UnityEngine
internal class TextSelectingUtilities 
{
	// Fields
	public DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPosStart; // 0x1C
	private int m_DblClickInitPosEnd; // 0x20
	private TextHandle m_TextHandle; // 0x28
	private const int kMoveDownHeight = 5;
	private const Char kNewLineChar = 10;
	private bool m_RevealCursor; // 0x30
	private int m_CursorIndex; // 0x34
	internal int m_SelectIndex; // 0x38
	private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextSelectOp> s_KeySelectOps; // 0x0
	internal Action OnCursorIndexChange; // 0x40
	internal Action OnSelectIndexChange; // 0x48
	internal Action OnRevealCursorChange; // 0x50

	// Methods

	// RVA: 0x1553664
	bool get_hasSelection() { }

	// RVA: 0x155FD44
	bool get_revealCursor() { }

	// RVA: 0x155374C
	void set_revealCursor(bool value) { }

	// RVA: 0x155FD4C
	int get_m_CharacterCount() { }

	// RVA: 0x155FD78
	int get_characterCount() { }

	// RVA: 0x155FE5C
	TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x15537E0
	int get_cursorIndex() { }

	// RVA: 0x1553884
	void set_cursorIndex(int value) { }

	// RVA: 0x155945C
	void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x1553918
	int get_selectIndex() { }

	// RVA: 0x15539BC
	void set_selectIndex(int value) { }

	// RVA: 0x1559464
	void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x155FEE4
	string get_selectedText() { }

	// RVA: 0x15601D8
	void .ctor(TextHandle textHandle) { }

	// RVA: 0x156022C
	bool HandleKeyEvent(Event e) { }

	// RVA: 0x1561138
	bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x1562D60
	void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x1560350
	void InitKeyActions() { }

	// RVA: 0x155946C
	void ClearCursorPos() { }

	// RVA: 0x1562E04
	void OnFocus(bool selectAll) { }

	// RVA: 0x1562CE8
	void SelectAll() { }

	// RVA: 0x15597FC
	void SelectNone() { }

	// RVA: 0x1561638
	void SelectLeft() { }

	// RVA: 0x156182C
	void SelectRight() { }

	// RVA: 0x1561A20
	void SelectUp() { }

	// RVA: 0x1561ACC
	void SelectDown() { }

	// RVA: 0x1562298
	void SelectTextEnd() { }

	// RVA: 0x1562270
	void SelectTextStart() { }

	// RVA: 0x15621D4
	void SelectToStartOfNextWord() { }

	// RVA: 0x1562138
	void SelectToEndOfPreviousWord() { }

	// RVA: 0x1561B78
	void SelectWordRight() { }

	// RVA: 0x1561E58
	void SelectWordLeft() { }

	// RVA: 0x1562BB0
	void SelectGraphicalLineStart() { }

	// RVA: 0x1562C4C
	void SelectGraphicalLineEnd() { }

	// RVA: 0x1562678
	void SelectParagraphForward() { }

	// RVA: 0x1562900
	void SelectParagraphBackward() { }

	// RVA: 0x156307C
	void SelectCurrentWord() { }

	// RVA: 0x1563378
	void SelectCurrentParagraph() { }

	// RVA: 0x155607C
	void MoveRight() { }

	// RVA: 0x1555E1C
	void MoveLeft() { }

	// RVA: 0x15562E8
	void MoveUp() { }

	// RVA: 0x1556558
	void MoveDown() { }

	// RVA: 0x15567D8
	void MoveLineStart() { }

	// RVA: 0x15569AC
	void MoveLineEnd() { }

	// RVA: 0x15577D0
	void MoveGraphicalLineStart() { }

	// RVA: 0x1557920
	void MoveGraphicalLineEnd() { }

	// RVA: 0x155726C
	void MoveTextStart() { }

	// RVA: 0x15572D8
	void MoveTextEnd() { }

	// RVA: 0x1557354
	void MoveParagraphForward() { }

	// RVA: 0x1557588
	void MoveParagraphBackward() { }

	// RVA: 0x1556B9C
	void MoveWordRight() { }

	// RVA: 0x1556DAC
	void MoveToStartOfNextWord() { }

	// RVA: 0x1556F14
	void MoveToEndOfPreviousWord() { }

	// RVA: 0x155707C
	void MoveWordLeft() { }

	// RVA: 0x15636A4
	void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x15622E8
	void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x15624B0
	void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1563858
	void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x1563860
	void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x1563930
	void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1563564
	int FindNextSeperator(int startPos) { }

	// RVA: 0x15635F8
	int FindPrevSeperator(int startPos) { }

	// RVA: 0x1559040
	int FindStartOfNextWord(int p) { }

	// RVA: 0x1558F38
	int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1563228
	int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x1563DE0
	int ClampTextIndex(int index) { }

	// RVA: 0x155FE88
	int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x1563E10
	bool IsValidCodePointIndex(int index) { }

	// RVA: 0x156302C
	int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x1559368
	int PreviousCodePointIndex(int index) { }

	// RVA: 0x155926C
	int NextCodePointIndex(int index) { }

	// RVA: 0x1562EB0
	int GetGraphicalLineStart(int p) { }

	// RVA: 0x1562F64
	int GetGraphicalLineEnd(int p) { }

	// RVA: 0x1559580
	void Copy() { }

	// RVA: 0x1563C58
	CharacterType ClassifyChar(int index) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Methods

	// RVA: 0x1563F0C
	UInt32 ComputeStringHash(string s) { }

}


