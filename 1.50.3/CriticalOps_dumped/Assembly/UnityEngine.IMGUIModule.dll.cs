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

	// RVA: 0x16423B8
	public EventType get_rawType() { }

	// RVA: 0x1642408
	public Vector2 get_mousePosition() { }

	// RVA: 0x16424C8
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x1642584
	public Vector2 get_delta() { }

	// RVA: 0x1642644
	public void set_delta(Vector2 value) { }

	// RVA: 0x1642700
	public PointerType get_pointerType() { }

	// RVA: 0x1642750
	public int get_button() { }

	// RVA: 0x16427A0
	public EventModifiers get_modifiers() { }

	// RVA: 0x16427F0
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1642858
	public float get_pressure() { }

	// RVA: 0x16428A8
	public float get_twist() { }

	// RVA: 0x16428F8
	public Vector2 get_tilt() { }

	// RVA: 0x16429B8
	public PenStatus get_penStatus() { }

	// RVA: 0x1642A08
	public int get_clickCount() { }

	// RVA: 0x1642A58
	public Char get_character() { }

	// RVA: 0x1642AA8
	public void set_character(Char value) { }

	// RVA: 0x1642B10
	public KeyCode get_keyCode() { }

	// RVA: 0x1642B60
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x1642BC8
	public int get_displayIndex() { }

	// RVA: 0x1642C18
	public void set_displayIndex(int value) { }

	// RVA: 0x1642C80
	public EventType get_type() { }

	// RVA: 0x1642CD0
	public void set_type(EventType value) { }

	// RVA: 0x1642D38
	public string get_commandName() { }

	// RVA: 0x1642D88
	public void set_commandName(string value) { }

	// RVA: 0x1642DF0
	private void Internal_Use() { }

	// RVA: 0x1642E40
	private static IntPtr Internal_Create(int displayIndex) { }

	// RVA: 0x1642E90
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1642EE0
	public EventType GetTypeForControl(int controlID) { }

	// RVA: 0x1642F48
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1642FB0
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1643000
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0x1643050
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1643200
	internal static int GetDoubleClickTime() { }

	// RVA: 0x1643240
	public void .ctor() { }

	// RVA: 0x16431A4
	public void .ctor(int displayIndex) { }

	// RVA: 0x16432A8
	protected override void Finalize() { }

	// RVA: 0x1643384
	internal void CopyFrom(Event e) { }

	// RVA: 0x164341C
	public bool get_shift() { }

	// RVA: 0x164347C
	public bool get_control() { }

	// RVA: 0x16434DC
	public bool get_alt() { }

	// RVA: 0x164353C
	public bool get_command() { }

	// RVA: 0x164359C
	public static Event get_current() { }

	// RVA: 0x16435E8
	public static void set_current(Event value) { }

	// RVA: 0x16436A8
	public bool get_isKey() { }

	// RVA: 0x16436F8
	public bool get_isMouse() { }

	// RVA: 0x1643784
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x164381C
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x16455AC
	public override int GetHashCode() { }

	// RVA: 0x164572C
	public override bool Equals(object obj) { }

	// RVA: 0x1645A84
	public override string ToString() { }

	// RVA: 0x164638C
	public void Use() { }

	// RVA: 0x1642460
	private void get_mousePosition_Injected(Vector2 ret) { }

	// RVA: 0x164251C
	private void set_mousePosition_Injected(Vector2 value) { }

	// RVA: 0x16425DC
	private void get_delta_Injected(Vector2 ret) { }

	// RVA: 0x1642698
	private void set_delta_Injected(Vector2 value) { }

	// RVA: 0x1642950
	private void get_tilt_Injected(Vector2 ret) { }

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

	// RVA: 0x16465A8
	public bool get_wantsMouseMove() { }

	// RVA: 0x16465B0
	public void set_wantsMouseMove(bool value) { }

	// RVA: 0x16465B8
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x16465C0
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	// RVA: 0x16465C8
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x16465D0
	public bool WantsEvent(EventType type) { }

	// RVA: 0x1646600
	public bool WantsLayoutPass(EventType type) { }

}

// Namespace: 
public sealed class WindowFunction
{
	// Methods

	// RVA: 0x1654450
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16544F4
	public virtual void Invoke(int id) { }

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

	// RVA: 0x1646788
	public static Color get_color() { }

	// RVA: 0x1646884
	public static void set_color(Color value) { }

	// RVA: 0x164698C
	public static Color get_backgroundColor() { }

	// RVA: 0x1646A88
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1646B90
	public static Color get_contentColor() { }

	// RVA: 0x1646C8C
	public static void set_contentColor(Color value) { }

	// RVA: 0x1646D94
	public static bool get_changed() { }

	// RVA: 0x1646DD4
	public static void set_changed(bool value) { }

	// RVA: 0x1646E24
	public static bool get_enabled() { }

	// RVA: 0x1646E64
	public static void set_enabled(bool value) { }

	// RVA: 0x1646EB4
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x1646EF4
	internal static Material get_blendMaterial() { }

	// RVA: 0x1646F34
	internal static Material get_blitMaterial() { }

	// RVA: 0x1646F74
	internal static Material get_roundedRectMaterial() { }

	// RVA: 0x1646FB4
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1646FF4
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1647044
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1647094
	internal static void ReleaseMouseControl() { }

	// RVA: 0x16470D4
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1647114
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x16472C8
	private static void .cctor() { }

	// RVA: 0x16475A8
	internal static int get_scrollTroughSide() { }

	// RVA: 0x1647624
	internal static void set_scrollTroughSide(int value) { }

	// RVA: 0x16476B0
	internal static DateTime get_nextScrollStepTime() { }

	// RVA: 0x164772C
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x16477B8
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1647B4C
	public static GUISkin get_skin() { }

	// RVA: 0x164795C
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1647DE4
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1647EBC
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1647F7C
	public static void Label(Rect position, string text) { }

	// RVA: 0x16481F4
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x164873C
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1648878
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x1648970
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1648A1C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1648C04
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1648D30
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1648F1C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1649080
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x16491CC
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x16499E4
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, Rect outScreenRect, Rect outSourceRect) { }

	// RVA: 0x1649AD8
	public static void Box(Rect position, string text) { }

	// RVA: 0x1649BF0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x164A12C
	public static bool Button(Rect position, string text) { }

	// RVA: 0x164A3D4
	public static bool Button(Rect position, GUIContent content) { }

	// RVA: 0x164A244
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x164A5AC
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x164A814
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x164B050
	internal static string PasswordFieldGetStrToShow(string password, Char maskChar) { }

	// RVA: 0x164B1E0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x164B300
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x164B3CC
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar) { }

	// RVA: 0x164BEC8
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0x164C724
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x164B90C
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x164D9FC
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x16482DC
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x164A6A4
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x164E390
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x164E460
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x164E624
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x164F404
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x164F7C8
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x164EDE4
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x164FCB8
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x164FD94
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x1650520
	public static void EndGroup() { }

	// RVA: 0x16505F8
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x1650674
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x1651FC8
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x1652F70
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

	// RVA: 0x16533AC
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x16531E0
	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x165358C
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1646834
	private static void get_color_Injected(Color ret) { }

	// RVA: 0x164693C
	private static void set_color_Injected(Color value) { }

	// RVA: 0x1646A38
	private static void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x1646B40
	private static void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x1646C3C
	private static void get_contentColor_Injected(Color ret) { }

	// RVA: 0x1646D44
	private static void set_contentColor_Injected(Color value) { }

	// RVA: 0x1647228
	private static void Internal_DoWindow_Injected(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, Rect ret) { }

}

// Namespace: 
internal struct ParentClipScope
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x1654990
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x1654A0C
	public void Dispose() { }

}

// Namespace: UnityEngine
internal sealed class GUIClip
{
	// Methods

	// RVA: 0x164E238
	internal static Rect get_visibleRect() { }

	// RVA: 0x1654558
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16505B8
	internal static void Internal_Pop() { }

	// RVA: 0x1654628
	internal static int Internal_GetCount() { }

	// RVA: 0x1654668
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x1647E54
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x1647F2C
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x16547C8
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x1654838
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x16548F8
	internal static void Internal_PopParentClip() { }

	// RVA: 0x16504B8
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1652F30
	internal static void Pop() { }

	// RVA: 0x1654938
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x1654508
	private static void get_visibleRect_Injected(Rect ret) { }

	// RVA: 0x16545C0
	private static void Internal_Push_Injected(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16546C0
	private static void UnclipToWindow_Vector2_Injected(Vector2 pos, Vector2 ret) { }

	// RVA: 0x1654728
	private static void GetMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x1654778
	private static void SetMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x16548A0
	private static void Internal_PushParentClip_Injected(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

}

// Namespace: UnityEngine
[Serializable]
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

	// RVA: 0x164B804
	public string get_text() { }

	// RVA: 0x164B80C
	public void set_text(string value) { }

	// RVA: 0x1654A68
	public void set_image(Texture value) { }

	// RVA: 0x164E230
	public string get_tooltip() { }

	// RVA: 0x1654A70
	public void set_tooltip(string value) { }

	// RVA: 0x1654A78
	public void .ctor() { }

	// RVA: 0x1654AFC
	public void .ctor(string text) { }

	// RVA: 0x1654B64
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1654C60
	public void .ctor(GUIContent src) { }

	// RVA: 0x1648110
	internal static GUIContent Temp(string t) { }

	// RVA: 0x1654D60
	internal static void ClearStaticCache() { }

	// RVA: 0x1654E98
	public override string ToString() { }

	// RVA: 0x1654EB8
	private static void .cctor() { }

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

	// RVA: 0x16550F4
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x1655430
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x165526C
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1655524
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x16557D4
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x165569C
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1655850
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1655DE8
	public static string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1655988
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1655EE4
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x16560CC
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x16562D8
	public static void Space(float pixels) { }

	// RVA: 0x1656938
	public static void FlexibleSpace() { }

	// RVA: 0x1656E94
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1656F5C
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16574F4
	public static void EndHorizontal() { }

	// RVA: 0x1657868
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x1657930
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1657B04
	public static void EndVertical() { }

	// RVA: 0x1657B6C
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1657EF4
	public static void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x1657C54
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1658328
	public static void EndArea() { }

	// RVA: 0x165873C
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x16589B4
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x1658C80
	public static void EndScrollView() { }

	// RVA: 0x1658D30
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x1653D5C
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1658DF0
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x1658EA4
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x1653E0C
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1658F58
	public static GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x1656DA4
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1656CF8
	public static GUILayoutOption ExpandHeight(bool expand) { }

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

	// RVA: 0x1656E50
	internal void .ctor(Type type, object value) { }

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

	// RVA: 0x165B2F8
	private void set_id(int value) { }

	// RVA: 0x165941C
	internal void .ctor(int instanceID) { }

	// RVA: 0x165B300
	public void ResetCursor() { }

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

	// RVA: 0x165900C
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1659130
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x165924C
	internal static int get_unbalancedgroupscount() { }

	// RVA: 0x16592C8
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x1659354
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x1653BA4
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1659528
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x1659614
	internal static void Begin(int instanceID) { }

	// RVA: 0x1659868
	internal static void BeginContainer(LayoutCache cache) { }

	// RVA: 0x1653EC0
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16541CC
	internal static void Layout() { }

	// RVA: 0x1659FC4
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x165A204
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1659AE8
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1659D34
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x165A3AC
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x165712C
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x165755C
	internal static void EndLayoutGroup() { }

	// RVA: 0x1657F90
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x1658530
	internal static void EndLayoutArea() { }

	// RVA: 0x165A60C
	public static Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x16554AC
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x165A678
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16568B0
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x165AD6C
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x165AF80
	public static Rect GetLastRect() { }

	// RVA: 0x16566D4
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x165B1D8
	private static void .cctor() { }

	// RVA: 0x16590C8
	private static void Internal_GetWindowRect_Injected(int windowID, Rect ret) { }

	// RVA: 0x16591E4
	private static void Internal_MoveWindow_Injected(int windowID, Rect r) { }

}

// Namespace: UnityEngine
[Serializable]
public sealed class GUISettings
{
	// Fields
	private bool m_DoubleClickSelectsWord; // 0x10
	private bool m_TripleClickSelectsLine; // 0x11
	private Color m_CursorColor; // 0x14
	private float m_CursorFlashSpeed; // 0x24
	private Color m_SelectionColor; // 0x28

	// Methods

	// RVA: 0x165B5E4
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x164D904
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x164D90C
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x165B624
	public Color get_cursorColor() { }

	// RVA: 0x165B630
	public float get_cursorFlashSpeed() { }

	// RVA: 0x165B688
	public Color get_selectionColor() { }

	// RVA: 0x165B694
	public void set_selectionColor(Color value) { }

	// RVA: 0x165B6A0
	public void .ctor() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate
{
	// Methods

	// RVA: 0x165F038
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x165F0D8
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
[Serializable]
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

	// RVA: 0x165B6CC
	public void .ctor() { }

	// RVA: 0x165B7A8
	internal void OnEnable() { }

	// RVA: 0x165B8D8
	internal static void CleanupRoots() { }

	// RVA: 0x164D964
	public Font get_font() { }

	// RVA: 0x165B944
	public void set_font(Font value) { }

	// RVA: 0x1649BE8
	public GUIStyle get_box() { }

	// RVA: 0x165BB5C
	public void set_box(GUIStyle value) { }

	// RVA: 0x16481EC
	public GUIStyle get_label() { }

	// RVA: 0x165BBFC
	public void set_label(GUIStyle value) { }

	// RVA: 0x1655980
	public GUIStyle get_textField() { }

	// RVA: 0x165BC9C
	public void set_textField(GUIStyle value) { }

	// RVA: 0x165BD3C
	public GUIStyle get_textArea() { }

	// RVA: 0x165BD44
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x164A23C
	public GUIStyle get_button() { }

	// RVA: 0x165BDE4
	public void set_button(GUIStyle value) { }

	// RVA: 0x165BE84
	public GUIStyle get_toggle() { }

	// RVA: 0x165BE8C
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x16531D8
	public GUIStyle get_window() { }

	// RVA: 0x165BF2C
	public void set_window(GUIStyle value) { }

	// RVA: 0x16560BC
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x165BFCC
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x16560C4
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x165C06C
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x165C10C
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x165C114
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x165C1B4
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x165C1BC
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x165C25C
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x165C264
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x165C304
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x165C30C
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x165C3AC
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x165C3B4
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x165899C
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x165C454
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x165C4F4
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x165C4FC
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x165C59C
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x165C5A4
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x165C644
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x165C64C
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x16589A4
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x165C6EC
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x165C78C
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x165C794
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x165C834
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x165C83C
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x165C8DC
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x165C8E4
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x16589AC
	public GUIStyle get_scrollView() { }

	// RVA: 0x165C984
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x165CA24
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x165CA2C
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x164D8FC
	public GUISettings get_settings() { }

	// RVA: 0x165CAE0
	internal static GUIStyle get_error() { }

	// RVA: 0x165B840
	internal void Apply() { }

	// RVA: 0x165CCF8
	private void BuildStyleCache() { }

	// RVA: 0x164EAF8
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x165EEE0
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1647CE4
	internal void MakeCurrent() { }

	// RVA: 0x165EF74
	public IEnumerator GetEnumerator() { }

}

// Namespace: UnityEngine
internal class GUIStateObjects
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x165F0EC
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x165F28C
	private static void .cctor() { }

}

// Namespace: UnityEngine
[Serializable]
public sealed class GUIStyleState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x165F328
	public void set_background(Texture2D value) { }

	// RVA: 0x165EE88
	public void set_textColor(Color value) { }

	// RVA: 0x165F3F8
	private static IntPtr Init() { }

	// RVA: 0x165F438
	private void Cleanup() { }

	// RVA: 0x165F488
	public void .ctor() { }

	// RVA: 0x165F4E4
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x165F52C
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x165F5A8
	protected override void Finalize() { }

	// RVA: 0x165F390
	private void set_textColor_Injected(Color value) { }

}

// Namespace: UnityEngine
[Serializable]
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

	// RVA: 0x165F670
	internal string get_rawName() { }

	// RVA: 0x165F6C0
	internal void set_rawName(string value) { }

	// RVA: 0x164D914
	public Font get_font() { }

	// RVA: 0x165F728
	public ImagePosition get_imagePosition() { }

	// RVA: 0x165F778
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x165F7E0
	public bool get_wordWrap() { }

	// RVA: 0x165F830
	public Vector2 get_contentOffset() { }

	// RVA: 0x165F8F0
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x164FC18
	public float get_fixedWidth() { }

	// RVA: 0x165F9AC
	public void set_fixedWidth(float value) { }

	// RVA: 0x164FC68
	public float get_fixedHeight() { }

	// RVA: 0x165FA14
	public bool get_stretchWidth() { }

	// RVA: 0x165B170
	public void set_stretchWidth(bool value) { }

	// RVA: 0x165FA64
	public bool get_stretchHeight() { }

	// RVA: 0x165ED3C
	public void set_stretchHeight(bool value) { }

	// RVA: 0x165FAB4
	public void set_fontSize(int value) { }

	// RVA: 0x165FB1C
	internal void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0x165FBD8
	private static IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0x165FC28
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0x165FC90
	private static void Internal_Destroy(IntPtr self) { }

	// RVA: 0x165FCE0
	private IntPtr GetStyleStatePtr(int idx) { }

	// RVA: 0x165FD48
	private IntPtr GetRectOffsetPtr(int idx) { }

	// RVA: 0x165FDB0
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	// RVA: 0x165FE08
	private static float Internal_GetLineHeight(IntPtr target) { }

	// RVA: 0x165FE58
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x165FF78
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1660068
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x1660154
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x16602CC
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x16603B8
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1660490
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x1660580
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	// RVA: 0x1660640
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0x1660718
	private float Internal_CalcHeight(GUIContent content, float width) { }

	// RVA: 0x1660778
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0x164E2DC
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	// RVA: 0x164E28C
	internal static bool IsTooltipActive(string tooltip) { }

	// RVA: 0x16608A0
	private static float Internal_GetCursorFlashOffset() { }

	// RVA: 0x165BB0C
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x165B0B4
	public void .ctor() { }

	// RVA: 0x16608E0
	public void .ctor(GUIStyle other) { }

	// RVA: 0x1660A00
	protected override void Finalize() { }

	// RVA: 0x164EA74
	public string get_name() { }

	// RVA: 0x165CC88
	public void set_name(string value) { }

	// RVA: 0x165EDA4
	public GUIStyleState get_normal() { }

	// RVA: 0x1651DF8
	public RectOffset get_margin() { }

	// RVA: 0x1660B18
	public RectOffset get_padding() { }

	// RVA: 0x1660BF0
	public void set_padding(RectOffset value) { }

	// RVA: 0x1660C4C
	public float get_lineHeight() { }

	// RVA: 0x1651ED0
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x164E198
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1650390
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x164D814
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1649F48
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x1660DAC
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x1661028
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x1661400
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x1661834
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x1661B44
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x1650224
	public static GUIStyle get_none() { }

	// RVA: 0x1661B4C
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1661BC8
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1661C38
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x165AC00
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x1661CA0
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x165AB20
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x1661D00
	public void CalcMinMaxWidth(GUIContent content, float minWidth, float maxWidth) { }

	// RVA: 0x1661D80
	public override string ToString() { }

	// RVA: 0x1661E8C
	private static void .cctor() { }

	// RVA: 0x165F888
	private void get_contentOffset_Injected(Vector2 ret) { }

	// RVA: 0x165F944
	private void set_contentOffset_Injected(Vector2 value) { }

	// RVA: 0x165FB70
	private void set_Internal_clipOffset_Injected(Vector2 value) { }

	// RVA: 0x165FEF0
	private void Internal_Draw_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x165FFF8
	private void Internal_Draw2_Injected(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x16600E4
	private void Internal_DrawCursor_Injected(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x1660224
	private void Internal_DrawWithTextSelection_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x1660348
	private void Internal_GetCursorPixelPosition_Injected(Rect position, GUIContent content, int cursorStringIndex, Vector2 ret) { }

	// RVA: 0x1660428
	private int Internal_GetCursorStringIndex_Injected(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x1660510
	private string Internal_GetSelectedRenderedText_Injected(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x16605E8
	private void Internal_CalcSize_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x16606B0
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, Vector2 maxSize, Vector2 ret) { }

	// RVA: 0x16607E0
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x1660838
	private static void SetMouseTooltip_Injected(string tooltip, Rect screenRect) { }

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

	// RVA: 0x1661EDC
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }

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

	// RVA: 0x1659AA8
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x166208C
	internal static int get_guiDepth() { }

	// RVA: 0x1650468
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1646748
	internal static bool get_textFieldInput() { }

	// RVA: 0x164D9AC
	internal static void set_textFieldInput(bool value) { }

	// RVA: 0x16620CC
	public static string get_systemCopyBuffer() { }

	// RVA: 0x166210C
	public static void set_systemCopyBuffer(string value) { }

	// RVA: 0x166215C
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x164A494
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x1662270
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x16622C0
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0x1662310
	internal static void Internal_EndContainer() { }

	// RVA: 0x1662350
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x16623A0
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x16623E0
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x1662420
	internal static bool HasFocusableControls() { }

	// RVA: 0x1662460
	internal static bool OwnsId(int id) { }

	// RVA: 0x16624B0
	public static Rect AlignRectToDevice(Rect rect, int widthInPixels, int heightInPixels) { }

	// RVA: 0x164D96C
	internal static string get_compositionString() { }

	// RVA: 0x16625E8
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1662638
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x166273C
	private static int Internal_GetHotControl() { }

	// RVA: 0x166277C
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x16627BC
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x166280C
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x166285C
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x16628AC
	private static void Internal_ExitGUI() { }

	// RVA: 0x16628EC
	private static void MarkGUIChanged() { }

	// RVA: 0x1655DFC
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1649EA8
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x164B880
	public static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x166297C
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x164AFC0
	public static int get_hotControl() { }

	// RVA: 0x164AF14
	public static void set_hotControl(int value) { }

	// RVA: 0x1662A08
	internal static void TakeCapture() { }

	// RVA: 0x1662A98
	internal static void RemoveCapture() { }

	// RVA: 0x164D6D8
	public static int get_keyboardControl() { }

	// RVA: 0x164D768
	public static void set_keyboardControl(int value) { }

	// RVA: 0x1660E94
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1662B28
	public static void ExitGUI() { }

	// RVA: 0x1647C08
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0x1662C78
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool result) { }

	// RVA: 0x1662E90
	internal static void EndContainer() { }

	// RVA: 0x1662F50
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	// RVA: 0x1663270
	internal static void DestroyGUI(int instanceID) { }

	// RVA: 0x16632F8
	internal static void EndGUI(int layoutType) { }

	// RVA: 0x1663528
	internal static bool EndGUIFromException(Exception exception) { }

	// RVA: 0x16637A0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1663040
	internal static void ResetGlobalState() { }

	// RVA: 0x1663888
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x16636A0
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1647878
	internal static void CheckOnGUI() { }

	// RVA: 0x1663924
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x1663A08
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x1663B40
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1663B8C
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x164DFB4
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1663C70
	private static void .cctor() { }

	// RVA: 0x1662218
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x1662580
	private static void AlignRectToDevice_Injected(Rect rect, int widthInPixels, int heightInPixels, Rect ret) { }

	// RVA: 0x16626EC
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException
{
	// Methods

	// RVA: 0x1662B64
	public void .ctor() { }

	// RVA: 0x165A51C
	internal void .ctor(string message) { }

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

	// RVA: 0x1663D28
	public GUIStyle get_style() { }

	// RVA: 0x1659A70
	public void set_style(GUIStyle value) { }

	// RVA: 0x1663D30
	public virtual int get_marginLeft() { }

	// RVA: 0x1663DF8
	public virtual int get_marginRight() { }

	// RVA: 0x1663EC0
	public virtual int get_marginTop() { }

	// RVA: 0x1663F88
	public virtual int get_marginBottom() { }

	// RVA: 0x1664050
	public int get_marginHorizontal() { }

	// RVA: 0x1664090
	public int get_marginVertical() { }

	// RVA: 0x16640D0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x165AC70
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x16641C4
	public virtual void CalcWidth() { }

	// RVA: 0x16641C8
	public virtual void CalcHeight() { }

	// RVA: 0x16641CC
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x16641D8
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x16641E4
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x166430C
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x16645FC
	public override string ToString() { }

	// RVA: 0x1664BBC
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class GUIWordWrapSizer
{
	// Fields
	private readonly GUIContent m_Content; // 0x48
	private readonly float m_ForcedMinHeight; // 0x50
	private readonly float m_ForcedMaxHeight; // 0x54

	// Methods

	// RVA: 0x1664C14
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x1664D00
	public override void CalcWidth() { }

	// RVA: 0x1664DA8
	public override void CalcHeight() { }

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

	// RVA: 0x1664E20
	public override int get_marginLeft() { }

	// RVA: 0x1664E28
	public override int get_marginRight() { }

	// RVA: 0x1664E30
	public override int get_marginTop() { }

	// RVA: 0x1664E38
	public override int get_marginBottom() { }

	// RVA: 0x1664E40
	public void .ctor() { }

	// RVA: 0x1664F88
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x16650A8
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1665128
	public void ResetCursor() { }

	// RVA: 0x1665130
	public GUILayoutEntry GetNext() { }

	// RVA: 0x16653EC
	public Rect GetLast() { }

	// RVA: 0x1665718
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x166577C
	public override void CalcWidth() { }

	// RVA: 0x1665EF8
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1666978
	public override void CalcHeight() { }

	// RVA: 0x166707C
	public override void SetVertical(float y, float height) { }

	// RVA: 0x1667B10
	public override string ToString() { }

	// RVA: 0x1667F4C
	private static void .cctor() { }

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

	// RVA: 0x166802C
	public void .ctor() { }

	// RVA: 0x16680BC
	public override void CalcWidth() { }

	// RVA: 0x1668138
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1668234
	public override void CalcHeight() { }

	// RVA: 0x166830C
	public override void SetVertical(float y, float height) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1668494
	public void .ctor() { }

	// RVA: 0x1668530
	public void Dispose() { }

	// RVA: 0x1668664
	protected override void Finalize() { }

	// RVA: 0x16685FC
	private void Destroy() { }

	// RVA: 0x16684F0
	private static IntPtr Internal_Create() { }

	// RVA: 0x1668740
	private static void Internal_Destroy(IntPtr ptr) { }

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

	// RVA: 0x1668790
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class SliderState
{
	// Fields
	public float dragStartPos; // 0x10
	public float dragStartValue; // 0x14
	public bool isDragging; // 0x18

	// Methods

	// RVA: 0x1668798
	public void .ctor() { }

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

	// RVA: 0x16687A0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x166881C
	public float Handle() { }

	// RVA: 0x1668900
	private float OnMouseDown() { }

	// RVA: 0x1668DE4
	private float OnMouseDrag() { }

	// RVA: 0x1668F74
	private float OnMouseUp() { }

	// RVA: 0x1669050
	private float OnRepaint() { }

	// RVA: 0x16688CC
	private EventType CurrentEventType() { }

	// RVA: 0x16699D4
	private int CurrentScrollTroughSide() { }

	// RVA: 0x166976C
	private bool IsEmptySlider() { }

	// RVA: 0x1669834
	private bool SupportsPageMovements() { }

	// RVA: 0x1669A60
	private float PageMovementValue() { }

	// RVA: 0x1669E18
	private float PageUpMovementBound() { }

	// RVA: 0x1669764
	private Event CurrentEvent() { }

	// RVA: 0x1669B5C
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x1669C38
	private float Clamp(float value) { }

	// RVA: 0x1669704
	private Rect ThumbSelectionRect() { }

	// RVA: 0x16697A8
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x16698B8
	private SliderState SliderState() { }

	// RVA: 0x1669D70
	private Rect ThumbExtRect() { }

	// RVA: 0x1669E08
	private Rect ThumbRect() { }

	// RVA: 0x1669E98
	private Rect VerticalThumbRect() { }

	// RVA: 0x1669FBC
	private Rect HorizontalThumbRect() { }

	// RVA: 0x166977C
	private float ClampedCurrentValue() { }

	// RVA: 0x1669C64
	private float MousePosition() { }

	// RVA: 0x1669CC8
	private float ValuesPerPixel() { }

	// RVA: 0x166A0E0
	private float ThumbSize() { }

	// RVA: 0x1669E80
	private float MaxValue() { }

	// RVA: 0x1669E70
	private float MinValue() { }

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

	// RVA: 0x166A1A8
	private bool get_hasSelection() { }

	// RVA: 0x166A264
	internal void set_revealCursor(bool value) { }

	// RVA: 0x166A2D8
	private int get_cursorIndex() { }

	// RVA: 0x166A39C
	private void set_cursorIndex(int value) { }

	// RVA: 0x166A410
	private int get_selectIndex() { }

	// RVA: 0x166A4D4
	private void set_selectIndex(int value) { }

	// RVA: 0x166A548
	public string get_text() { }

	// RVA: 0x166A550
	public void set_text(string value) { }

	// RVA: 0x166A5F4
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x166A664
	public bool UpdateImeState() { }

	// RVA: 0x166A93C
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x166A944
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x166AA30
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x166ACD8
	public void EnableCursorPreviewState() { }

	// RVA: 0x166AC44
	public void RestoreCursorState() { }

	// RVA: 0x166AE34
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x166C564
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x166F4A0
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x166AFCC
	private void InitKeyActions() { }

	// RVA: 0x166EF24
	public bool DeleteLineBack() { }

	// RVA: 0x166EC50
	public bool DeleteWordBack() { }

	// RVA: 0x166F204
	public bool DeleteWordForward() { }

	// RVA: 0x166E5D0
	public bool Delete() { }

	// RVA: 0x166E86C
	public bool Backspace() { }

	// RVA: 0x166F544
	public bool DeleteSelection() { }

	// RVA: 0x166A740
	public void ReplaceSelection(string replace) { }

	// RVA: 0x166FFDC
	public void Insert(Char c) { }

	// RVA: 0x167005C
	public bool CanPaste() { }

	// RVA: 0x166EAF4
	public bool Cut() { }

	// RVA: 0x166EB24
	public bool Paste() { }

	// RVA: 0x1670200
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x1670298
	internal void OnBlur() { }

	// RVA: 0x16703E4
	internal bool TouchScreenKeyboardShouldBeUsed() { }

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

	// RVA: 0x1670488
	public string get_text() { }

	// RVA: 0x16704A8
	public void set_text(string value) { }

	// RVA: 0x1670640
	public Rect get_position() { }

	// RVA: 0x167064C
	public void set_position(Rect value) { }

	// RVA: 0x16709C4
	internal virtual Rect get_localPosition() { }

	// RVA: 0x16709D0
	public int get_cursorIndex() { }

	// RVA: 0x16709D8
	public void set_cursorIndex(int value) { }

	// RVA: 0x1670A8C
	public int get_selectIndex() { }

	// RVA: 0x1670A94
	public void set_selectIndex(int value) { }

	// RVA: 0x1670B38
	private void ClearCursorPos() { }

	// RVA: 0x1670B48
	public void .ctor() { }

	// RVA: 0x1670C74
	public void OnFocus() { }

	// RVA: 0x1670D5C
	public void OnLostFocus() { }

	// RVA: 0x1670DB4
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x1670E48
	public bool HandleKeyEvent(Event e) { }

	// RVA: 0x1670E50
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x16739BC
	public bool DeleteLineBack() { }

	// RVA: 0x1673C6C
	public bool DeleteWordBack() { }

	// RVA: 0x1673E30
	public bool DeleteWordForward() { }

	// RVA: 0x16740D0
	public bool Delete() { }

	// RVA: 0x1674298
	public bool Backspace() { }

	// RVA: 0x1670D08
	public void SelectAll() { }

	// RVA: 0x1674438
	public void SelectNone() { }

	// RVA: 0x1673AB8
	public bool get_hasSelection() { }

	// RVA: 0x1673AC8
	public bool DeleteSelection() { }

	// RVA: 0x1674468
	public void ReplaceSelection(string replace) { }

	// RVA: 0x1674504
	public void Insert(Char c) { }

	// RVA: 0x1674584
	public void MoveRight() { }

	// RVA: 0x1674614
	public void MoveLeft() { }

	// RVA: 0x167468C
	public void MoveUp() { }

	// RVA: 0x167474C
	public void MoveDown() { }

	// RVA: 0x1674834
	public void MoveLineStart() { }

	// RVA: 0x16748B4
	public void MoveLineEnd() { }

	// RVA: 0x1674958
	public void MoveGraphicalLineStart() { }

	// RVA: 0x1674A78
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x1674BB0
	public void MoveTextStart() { }

	// RVA: 0x1674BDC
	public void MoveTextEnd() { }

	// RVA: 0x1674C28
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x1674C9C
	public void MoveParagraphForward() { }

	// RVA: 0x1674D24
	public void MoveParagraphBackward() { }

	// RVA: 0x1674DA8
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1674DFC
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x1674E90
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1675328
	public void SelectLeft() { }

	// RVA: 0x1675384
	public void SelectRight() { }

	// RVA: 0x16753E0
	public void SelectUp() { }

	// RVA: 0x1675448
	public void SelectDown() { }

	// RVA: 0x16754CC
	public void SelectTextEnd() { }

	// RVA: 0x1675508
	public void SelectTextStart() { }

	// RVA: 0x1675510
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1675520
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x167499C
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x1674ABC
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x1675528
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x167570C
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x16757B8
	public void MoveWordRight() { }

	// RVA: 0x1675818
	public void MoveToStartOfNextWord() { }

	// RVA: 0x167587C
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x1675910
	public void SelectToStartOfNextWord() { }

	// RVA: 0x1675948
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x16755D0
	private CharacterType ClassifyChar(int index) { }

	// RVA: 0x1673F00
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x1673D40
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1675980
	public void MoveWordLeft() { }

	// RVA: 0x16759CC
	public void SelectWordRight() { }

	// RVA: 0x1675A8C
	public void SelectWordLeft() { }

	// RVA: 0x1675B34
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1675B9C
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1675C04
	public void SelectGraphicalLineStart() { }

	// RVA: 0x1675C3C
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1675C74
	public void SelectParagraphForward() { }

	// RVA: 0x1675D10
	public void SelectParagraphBackward() { }

	// RVA: 0x1675DD4
	public void SelectCurrentWord() { }

	// RVA: 0x1675190
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x1675E4C
	public void SelectCurrentParagraph() { }

	// RVA: 0x1675EF4
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0x1670704
	internal void UpdateScrollOffset() { }

	// RVA: 0x1675F54
	public void DrawCursor(string newText) { }

	// RVA: 0x1673258
	private bool PerformOperation(TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x16764A0
	public void SaveBackup() { }

	// RVA: 0x16762EC
	public bool Cut() { }

	// RVA: 0x1676328
	public void Copy() { }

	// RVA: 0x16764E8
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x16763EC
	public bool Paste() { }

	// RVA: 0x1676580
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x1670F7C
	private void InitKeyActions() { }

	// RVA: 0x1674608
	public void DetectFocusChange() { }

	// RVA: 0x1676624
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x1676744
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x1676748
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x167674C
	private void ClampTextIndex(int index) { }

	// RVA: 0x16705C8
	private void EnsureValidCodePointIndex(int index) { }

	// RVA: 0x167679C
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x1674374
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x16741AC
	private int NextCodePointIndex(int index) { }

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

	// RVA: 0x166A1C4
	public bool get_hasSelection() { }

	// RVA: 0x16768A4
	public bool get_revealCursor() { }

	// RVA: 0x166A2AC
	public void set_revealCursor(bool value) { }

	// RVA: 0x16768AC
	private int get_m_CharacterCount() { }

	// RVA: 0x16768D8
	private int get_characterCount() { }

	// RVA: 0x16769BC
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x166A340
	public int get_cursorIndex() { }

	// RVA: 0x166A3E4
	public void set_cursorIndex(int value) { }

	// RVA: 0x166FFBC
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x166A478
	public int get_selectIndex() { }

	// RVA: 0x166A51C
	public void set_selectIndex(int value) { }

	// RVA: 0x166FFC4
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x1676A44
	public string get_selectedText() { }

	// RVA: 0x1676D38
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x1676D8C
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x1677C98
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x16798C0
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x1676EB0
	private void InitKeyActions() { }

	// RVA: 0x166FFCC
	public void ClearCursorPos() { }

	// RVA: 0x1679964
	public void OnFocus(bool selectAll) { }

	// RVA: 0x1679848
	public void SelectAll() { }

	// RVA: 0x167035C
	public void SelectNone() { }

	// RVA: 0x1678198
	public void SelectLeft() { }

	// RVA: 0x167838C
	public void SelectRight() { }

	// RVA: 0x1678580
	public void SelectUp() { }

	// RVA: 0x167862C
	public void SelectDown() { }

	// RVA: 0x1678DF8
	public void SelectTextEnd() { }

	// RVA: 0x1678DD0
	public void SelectTextStart() { }

	// RVA: 0x1678D34
	public void SelectToStartOfNextWord() { }

	// RVA: 0x1678C98
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x16786D8
	public void SelectWordRight() { }

	// RVA: 0x16789B8
	public void SelectWordLeft() { }

	// RVA: 0x1679710
	public void SelectGraphicalLineStart() { }

	// RVA: 0x16797AC
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x16791D8
	public void SelectParagraphForward() { }

	// RVA: 0x1679460
	public void SelectParagraphBackward() { }

	// RVA: 0x1679BDC
	public void SelectCurrentWord() { }

	// RVA: 0x1679ED8
	public void SelectCurrentParagraph() { }

	// RVA: 0x166CBDC
	public void MoveRight() { }

	// RVA: 0x166C97C
	public void MoveLeft() { }

	// RVA: 0x166CE48
	public void MoveUp() { }

	// RVA: 0x166D0B8
	public void MoveDown() { }

	// RVA: 0x166D338
	public void MoveLineStart() { }

	// RVA: 0x166D50C
	public void MoveLineEnd() { }

	// RVA: 0x166E330
	public void MoveGraphicalLineStart() { }

	// RVA: 0x166E480
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x166DDCC
	public void MoveTextStart() { }

	// RVA: 0x166DE38
	public void MoveTextEnd() { }

	// RVA: 0x166DEB4
	public void MoveParagraphForward() { }

	// RVA: 0x166E0E8
	public void MoveParagraphBackward() { }

	// RVA: 0x166D6FC
	public void MoveWordRight() { }

	// RVA: 0x166D90C
	public void MoveToStartOfNextWord() { }

	// RVA: 0x166DA74
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x166DBDC
	public void MoveWordLeft() { }

	// RVA: 0x167A204
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1678E48
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1679010
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x167A3B8
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x167A3C0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x167A490
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x167A0C4
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x167A158
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x166FBA0
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x166FA98
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1679D88
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x167A940
	private int ClampTextIndex(int index) { }

	// RVA: 0x16769E8
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x167A970
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x1679B8C
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x166FEC8
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x166FDCC
	public int NextCodePointIndex(int index) { }

	// RVA: 0x1679A10
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x1679AC4
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x16700E0
	public void Copy() { }

	// RVA: 0x167A7B8
	private CharacterType ClassifyChar(int index) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Methods

	// RVA: 0x167AA6C
	internal static UInt32 ComputeStringHash(string s) { }

}


