// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16D21B4
	public static IntPtr ConvertToNative(Event e) { }

}

// Namespace: UnityEngine
public sealed class Event
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal const float scrollWheelDeltaPerTick = 3;
	internal static bool ignoreGuiDepth; // 0x0
	private static Event s_Current; // 0x8
	private static Event s_MasterEvent; // 0x10

	// Methods

	// RVA: 0x16CCB0C
	public EventType get_rawType() { }

	// RVA: 0x16CCBCC
	public Vector2 get_mousePosition() { }

	// RVA: 0x16CCCB0
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x16CCD90
	public Vector2 get_delta() { }

	// RVA: 0x16CCE74
	public void set_delta(Vector2 value) { }

	// RVA: 0x16CCF54
	public PointerType get_pointerType() { }

	// RVA: 0x16CD014
	public int get_button() { }

	// RVA: 0x16CD0D4
	public EventModifiers get_modifiers() { }

	// RVA: 0x16CD194
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x16CD284
	public float get_pressure() { }

	// RVA: 0x16CD344
	public float get_twist() { }

	// RVA: 0x16CD404
	public Vector2 get_tilt() { }

	// RVA: 0x16CD4E8
	public PenStatus get_penStatus() { }

	// RVA: 0x16CD5A8
	public int get_clickCount() { }

	// RVA: 0x16CD668
	public Char get_character() { }

	// RVA: 0x16CD728
	public void set_character(Char value) { }

	// RVA: 0x16CD818
	private KeyCode get_Internal_keyCode() { }

	// RVA: 0x16CD8D8
	private void set_Internal_keyCode(KeyCode value) { }

	// RVA: 0x16CD9C8
	public KeyCode get_keyCode() { }

	// RVA: 0x16CDD18
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x16CDDA0
	public int get_displayIndex() { }

	// RVA: 0x16CDE60
	public void set_displayIndex(int value) { }

	// RVA: 0x16CDF50
	public EventType get_type() { }

	// RVA: 0x16CE010
	public void set_type(EventType value) { }

	// RVA: 0x16CE100
	public string get_commandName() { }

	// RVA: 0x16CE280
	public void set_commandName(string value) { }

	// RVA: 0x16CE498
	private void Internal_Use() { }

	// RVA: 0x16CE558
	private static IntPtr Internal_Create(int displayIndex) { }

	// RVA: 0x16CE5A8
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x16CE5F8
	public EventType GetTypeForControl(int controlID) { }

	// RVA: 0x16CE6E8
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x16CE7D8
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x16CE8E4
	internal static void GetEventAtIndex(int index, Event outEvent) { }

	// RVA: 0x16CEA20
	public static int GetEventCount() { }

	// RVA: 0x16CEA60
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0x16CEAB0
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x16CEC7C
	internal static int GetDoubleClickTime() { }

	// RVA: 0x16CECBC
	public void .ctor() { }

	// RVA: 0x16CEC20
	public void .ctor(int displayIndex) { }

	// RVA: 0x16CED24
	protected override void Finalize() { }

	// RVA: 0x16CEDE4
	internal void CopyFrom(Event e) { }

	// RVA: 0x16CEE84
	public bool get_shift() { }

	// RVA: 0x16CEF04
	public bool get_control() { }

	// RVA: 0x16CEF84
	public bool get_alt() { }

	// RVA: 0x16CF004
	public bool get_command() { }

	// RVA: 0x16CF084
	public bool get_capsLock() { }

	// RVA: 0x16CF104
	public bool get_numeric() { }

	// RVA: 0x16CF184
	public bool get_functionKey() { }

	// RVA: 0x16CF204
	public static Event get_current() { }

	// RVA: 0x16CF250
	public static void set_current(Event value) { }

	// RVA: 0x16CF308
	public bool get_isKey() { }

	// RVA: 0x16CDBFC
	public bool get_isMouse() { }

	// RVA: 0x16CDCA8
	public bool get_isScrollWheel() { }

	// RVA: 0x16CF37C
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x16CF468
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x16D0E58
	public override int GetHashCode() { }

	// RVA: 0x16D1060
	public override bool Equals(object obj) { }

	// RVA: 0x16D144C
	public override string ToString() { }

	// RVA: 0x16D1F08
	public void Use() { }

	// RVA: 0x16CCB7C
	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CCC48
	private static void get_mousePosition_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16CCD28
	private static void set_mousePosition_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16CCE0C
	private static void get_delta_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16CCEEC
	private static void set_delta_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16CCFC4
	private static PointerType get_pointerType_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD084
	private static int get_button_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD144
	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD21C
	private static void set_modifiers_Injected(IntPtr _unity_self, EventModifiers value) { }

	// RVA: 0x16CD2F4
	private static float get_pressure_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD3B4
	private static float get_twist_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD480
	private static void get_tilt_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16CD558
	private static PenStatus get_penStatus_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD618
	private static int get_clickCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD6D8
	private static Char get_character_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD7B0
	private static void set_character_Injected(IntPtr _unity_self, Char value) { }

	// RVA: 0x16CD888
	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CD960
	private static void set_Internal_keyCode_Injected(IntPtr _unity_self, KeyCode value) { }

	// RVA: 0x16CDE10
	private static int get_displayIndex_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CDEE8
	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x16CDFC0
	private static EventType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CE098
	private static void set_type_Injected(IntPtr _unity_self, EventType value) { }

	// RVA: 0x16CE218
	private static void get_commandName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x16CE430
	private static void set_commandName_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x16CE508
	private static void Internal_Use_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CE680
	private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID) { }

	// RVA: 0x16CE770
	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	// RVA: 0x16CE894
	private static bool PopEvent_Injected(IntPtr outEvent) { }

	// RVA: 0x16CE9B8
	private static void GetEventAtIndex_Injected(int index, IntPtr outEvent) { }

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

	// RVA: 0x16D21D0
	public bool get_wantsMouseMove() { }

	// RVA: 0x16D21D8
	public void set_wantsMouseMove(bool value) { }

	// RVA: 0x16D21E0
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x16D21E8
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	// RVA: 0x16D21F0
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x16D21F8
	public bool WantsEvent(EventType type) { }

	// RVA: 0x16D2228
	public bool WantsLayoutPass(EventType type) { }

}

// Namespace: 
public sealed class WindowFunction
{
	// Methods

	// RVA: 0x16DEE80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16DEF24
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

	// RVA: 0x16D2350
	public static Color get_color() { }

	// RVA: 0x16D244C
	public static void set_color(Color value) { }

	// RVA: 0x16D2554
	public static Color get_backgroundColor() { }

	// RVA: 0x16D2650
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x16D2758
	public static Color get_contentColor() { }

	// RVA: 0x16D2854
	public static void set_contentColor(Color value) { }

	// RVA: 0x16D295C
	public static bool get_changed() { }

	// RVA: 0x16D299C
	public static void set_changed(bool value) { }

	// RVA: 0x16D29EC
	public static bool get_enabled() { }

	// RVA: 0x16D2A2C
	public static void set_enabled(bool value) { }

	// RVA: 0x16D2A7C
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x16D2ABC
	internal static Material get_blendMaterial() { }

	// RVA: 0x16D2BB8
	internal static Material get_blitMaterial() { }

	// RVA: 0x16D2CB4
	internal static Material get_roundedRectMaterial() { }

	// RVA: 0x16D2DB0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x16D2EAC
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x16D2EFC
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x16D2F4C
	internal static void ReleaseMouseControl() { }

	// RVA: 0x16D2F8C
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x16D2FCC
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x16D3180
	private static void .cctor() { }

	// RVA: 0x16D3460
	internal static int get_scrollTroughSide() { }

	// RVA: 0x16D34DC
	internal static void set_scrollTroughSide(int value) { }

	// RVA: 0x16D3568
	internal static DateTime get_nextScrollStepTime() { }

	// RVA: 0x16D35E4
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x16D3670
	public static void set_skin(GUISkin value) { }

	// RVA: 0x16D385C
	public static GUISkin get_skin() { }

	// RVA: 0x16D3738
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x16D3AB0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x16D3B88
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x16D3C48
	public static void Label(Rect position, string text) { }

	// RVA: 0x16D3F20
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D4420
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x16D455C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x16D4654
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x16D4700
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x16D48E8
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x16D4A14
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x16D4C00
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x16D4D64
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x16D4EB0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x16D587C
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, Rect outScreenRect, Rect outSourceRect) { }

	// RVA: 0x16D5970
	public static void Box(Rect position, string text) { }

	// RVA: 0x16D5A88
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D5E30
	public static bool Button(Rect position, string text) { }

	// RVA: 0x16D60E4
	public static bool Button(Rect position, GUIContent content) { }

	// RVA: 0x16D5F48
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D61A4
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D643C
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x16D6A1C
	internal static string PasswordFieldGetStrToShow(string password, Char maskChar) { }

	// RVA: 0x16D6BE0
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x16D6D00
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x16D6DCC
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar) { }

	// RVA: 0x16D71C0
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0x16D77A4
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x16D8468
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D4010
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D62A4
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x16D8DA4
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x16D8E74
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x16D9044
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x16DA344
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x16DA724
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x16D97B8
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x16DACBC
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16DAD98
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x16DB348
	public static void EndGroup() { }

	// RVA: 0x16DB428
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x16DB4A4
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x16DC980
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x16DDA00
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

	// RVA: 0x16DDE24
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x16DDC58
	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x16DDFE4
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x16D23FC
	private static void get_color_Injected(Color ret) { }

	// RVA: 0x16D2504
	private static void set_color_Injected(Color value) { }

	// RVA: 0x16D2600
	private static void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x16D2708
	private static void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x16D2804
	private static void get_contentColor_Injected(Color ret) { }

	// RVA: 0x16D290C
	private static void set_contentColor_Injected(Color value) { }

	// RVA: 0x16D2B78
	private static IntPtr get_blendMaterial_Injected() { }

	// RVA: 0x16D2C74
	private static IntPtr get_blitMaterial_Injected() { }

	// RVA: 0x16D2D70
	private static IntPtr get_roundedRectMaterial_Injected() { }

	// RVA: 0x16D2E6C
	private static IntPtr get_roundedRectWithColorPerBorderMaterial_Injected() { }

	// RVA: 0x16D30E0
	private static void Internal_DoWindow_Injected(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, Rect ret) { }

}

// Namespace: 
internal struct ParentClipScope
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x16DF3C0
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x16DF43C
	public void Dispose() { }

}

// Namespace: UnityEngine
internal sealed class GUIClip
{
	// Methods

	// RVA: 0x16D89EC
	internal static Rect get_visibleRect() { }

	// RVA: 0x16DEF88
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16DB3E8
	internal static void Internal_Pop() { }

	// RVA: 0x16DF058
	internal static int Internal_GetCount() { }

	// RVA: 0x16DF098
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x16D3B20
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x16D3BF8
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x16DF1F8
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x16DF268
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x16DF328
	internal static void Internal_PopParentClip() { }

	// RVA: 0x16DB2E0
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16DD9C0
	internal static void Pop() { }

	// RVA: 0x16DF368
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x16DEF38
	private static void get_visibleRect_Injected(Rect ret) { }

	// RVA: 0x16DEFF0
	private static void Internal_Push_Injected(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16DF0F0
	private static void UnclipToWindow_Vector2_Injected(Vector2 pos, Vector2 ret) { }

	// RVA: 0x16DF158
	private static void GetMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x16DF1A8
	private static void SetMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x16DF2D0
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
	private string m_TextWithWhitespace; // 0x28
	private Action OnTextChanged; // 0x30
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	internal static string k_ZeroWidthSpace; // 0x18
	public static GUIContent none; // 0x20

	// Methods

	// RVA: 0x16DF498
	internal void add_OnTextChanged(Action value) { }

	// RVA: 0x16DF53C
	internal void remove_OnTextChanged(Action value) { }

	// RVA: 0x16D70E8
	public string get_text() { }

	// RVA: 0x16D70F0
	public void set_text(string value) { }

	// RVA: 0x16DF664
	internal string get_textWithWhitespace() { }

	// RVA: 0x16DF5E0
	internal void set_textWithWhitespace(string value) { }

	// RVA: 0x16DF710
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x16DF79C
	public void set_image(Texture value) { }

	// RVA: 0x16D89E4
	public string get_tooltip() { }

	// RVA: 0x16DF7A4
	public void set_tooltip(string value) { }

	// RVA: 0x16DF7AC
	public void .ctor() { }

	// RVA: 0x16DF81C
	public void .ctor(string text) { }

	// RVA: 0x16DF8D4
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x16DF990
	public void .ctor(GUIContent src) { }

	// RVA: 0x16D3DE4
	internal static GUIContent Temp(string t) { }

	// RVA: 0x16DFA44
	internal static void ClearStaticCache() { }

	// RVA: 0x16DFBC4
	public override string ToString() { }

	// RVA: 0x16DFBE4
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

	// RVA: 0x16DFE74
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x16E01C0
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16DFFF4
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E02B4
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x16E056C
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E0434
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E05E8
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x16E0A58
	public static string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E0728
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E0A6C
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x16E0C64
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x16E0E70
	public static void Space(float pixels) { }

	// RVA: 0x16E153C
	public static void FlexibleSpace() { }

	// RVA: 0x16E1A80
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x16E1B48
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E20E0
	public static void EndHorizontal() { }

	// RVA: 0x16E2454
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x16E251C
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E26E4
	public static void EndVertical() { }

	// RVA: 0x16E274C
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x16E2AE8
	public static void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x16E2834
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x16E2F28
	public static void EndArea() { }

	// RVA: 0x16E3368
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x16E35F8
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x16E38D8
	public static void EndScrollView() { }

	// RVA: 0x16E3988
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x16DE7FC
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x16E3A48
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x16E3AE8
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x16DE898
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x16E3B88
	public static GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x16E199C
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x16E18FC
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

	// RVA: 0x16E1A3C
	internal void .ctor(Type type, object value) { }

}

// Namespace: 
internal sealed class LayoutCache
{
	// Fields
	private int <id>k__BackingField; // 0x10
	public GUILayoutGroup topLevel; // 0x18
	internal GenericStack layoutGroups; // 0x20
	internal GUILayoutGroup windows; // 0x28

	// Methods

	// RVA: 0x16E5D8C
	private void set_id(int value) { }

	// RVA: 0x16E4038
	public void .ctor(int instanceID) { }

	// RVA: 0x16E5D94
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

	// RVA: 0x16E3C28
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x16E3D4C
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x16E3E68
	internal static int get_unbalancedgroupscount() { }

	// RVA: 0x16E3EE4
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x16E3F70
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x16DE644
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x16E4144
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x16E4230
	internal static void Begin(int instanceID) { }

	// RVA: 0x16E44A4
	internal static void BeginContainer(LayoutCache cache) { }

	// RVA: 0x16DE938
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16DEC4C
	internal static void Layout() { }

	// RVA: 0x16E4BA4
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x16E4DA0
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x16E46C8
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x16E4914
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x16E4F48
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x16E1D0C
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x16E2148
	internal static void EndLayoutGroup() { }

	// RVA: 0x16E2B84
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x16E315C
	internal static void EndLayoutArea() { }

	// RVA: 0x16E50B4
	public static Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x16E023C
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E5120
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E14B4
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E5754
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16E5988
	public static Rect GetLastRect() { }

	// RVA: 0x16E1268
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x16E5C6C
	private static void .cctor() { }

	// RVA: 0x16E3CE4
	private static void Internal_GetWindowRect_Injected(int windowID, Rect ret) { }

	// RVA: 0x16E3E00
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

	// RVA: 0x16E6078
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x16D8374
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x16D837C
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x16E60B8
	public Color get_cursorColor() { }

	// RVA: 0x16E60C4
	public float get_cursorFlashSpeed() { }

	// RVA: 0x16E611C
	public Color get_selectionColor() { }

	// RVA: 0x16E6128
	public void set_selectionColor(Color value) { }

	// RVA: 0x16E6134
	public void .ctor() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate
{
	// Methods

	// RVA: 0x16E9988
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16E9A28
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

	// RVA: 0x16E6160
	public void .ctor() { }

	// RVA: 0x16E623C
	internal void OnEnable() { }

	// RVA: 0x16E636C
	internal static void CleanupRoots() { }

	// RVA: 0x16D8460
	public Font get_font() { }

	// RVA: 0x16E63D8
	public void set_font(Font value) { }

	// RVA: 0x16D5A80
	public GUIStyle get_box() { }

	// RVA: 0x16E670C
	public void set_box(GUIStyle value) { }

	// RVA: 0x16D3F18
	public GUIStyle get_label() { }

	// RVA: 0x16E67AC
	public void set_label(GUIStyle value) { }

	// RVA: 0x16E0720
	public GUIStyle get_textField() { }

	// RVA: 0x16E684C
	public void set_textField(GUIStyle value) { }

	// RVA: 0x16E68EC
	public GUIStyle get_textArea() { }

	// RVA: 0x16E68F4
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x16D5F40
	public GUIStyle get_button() { }

	// RVA: 0x16E6994
	public void set_button(GUIStyle value) { }

	// RVA: 0x16E6A34
	public GUIStyle get_toggle() { }

	// RVA: 0x16E6A3C
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x16DDC50
	public GUIStyle get_window() { }

	// RVA: 0x16E6ADC
	public void set_window(GUIStyle value) { }

	// RVA: 0x16E0C54
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x16E6B7C
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x16E0C5C
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x16E6C1C
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x16E6CBC
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x16E6CC4
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x16E6D64
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x16E6D6C
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x16E6E0C
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x16E6E14
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x16E6EB4
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x16E6EBC
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x16E6F5C
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x16E6F64
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x16E35E0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x16E7004
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x16E70A4
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x16E70AC
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x16E714C
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x16E7154
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x16E71F4
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x16E71FC
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x16E35E8
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x16E729C
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x16E733C
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x16E7344
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x16E73E4
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x16E73EC
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x16E748C
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x16E7494
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x16E35F0
	public GUIStyle get_scrollView() { }

	// RVA: 0x16E7534
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x16E75D4
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x16E75DC
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x16D836C
	public GUISettings get_settings() { }

	// RVA: 0x16E7690
	internal static GUIStyle get_error() { }

	// RVA: 0x16E62D4
	internal void Apply() { }

	// RVA: 0x16E7848
	private void BuildStyleCache() { }

	// RVA: 0x16D94AC
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x16E9830
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x16D3920
	internal void MakeCurrent() { }

	// RVA: 0x16E98C4
	public IEnumerator GetEnumerator() { }

}

// Namespace: UnityEngine
internal class GUIStateObjects
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x16E9A3C
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x16E9BD0
	private static void .cctor() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16EA104
	public static IntPtr ConvertToNative(GUIStyleState guiStyleState) { }

}

// Namespace: UnityEngine
[Serializable]
public sealed class GUIStyleState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x16E9C6C
	public void set_background(Texture2D value) { }

	// RVA: 0x16E97B4
	public void set_textColor(Color value) { }

	// RVA: 0x16E9E14
	private static IntPtr Init() { }

	// RVA: 0x16E9E54
	private void Cleanup() { }

	// RVA: 0x16E9F14
	public void .ctor() { }

	// RVA: 0x16E9F70
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x16E9FB8
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x16EA034
	protected override void Finalize() { }

	// RVA: 0x16E9D44
	private static void set_background_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x16E9DAC
	private static void set_textColor_Injected(IntPtr _unity_self, Color value) { }

	// RVA: 0x16E9EC4
	private static void Cleanup_Injected(IntPtr _unity_self) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16EE62C
	public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

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

	// RVA: 0x16EA120
	internal string get_rawName() { }

	// RVA: 0x16EA2E0
	internal void set_rawName(string value) { }

	// RVA: 0x16D8384
	public Font get_font() { }

	// RVA: 0x16EA574
	public ImagePosition get_imagePosition() { }

	// RVA: 0x16EA68C
	public TextAnchor get_alignment() { }

	// RVA: 0x16EA7A4
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x16EA8E0
	public bool get_wordWrap() { }

	// RVA: 0x16EA9F8
	public TextClipping get_clipping() { }

	// RVA: 0x16EAB10
	public Vector2 get_contentOffset() { }

	// RVA: 0x16EAC48
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x16DAB2C
	public float get_fixedWidth() { }

	// RVA: 0x16EADCC
	public void set_fixedWidth(float value) { }

	// RVA: 0x16DABF4
	public float get_fixedHeight() { }

	// RVA: 0x16EAF4C
	public bool get_stretchWidth() { }

	// RVA: 0x16E5B98
	public void set_stretchWidth(bool value) { }

	// RVA: 0x16EB0CC
	public bool get_stretchHeight() { }

	// RVA: 0x16E9584
	public void set_stretchHeight(bool value) { }

	// RVA: 0x16EB24C
	public int get_fontSize() { }

	// RVA: 0x16EB364
	public void set_fontSize(int value) { }

	// RVA: 0x16EB4A0
	public FontStyle get_fontStyle() { }

	// RVA: 0x16EB5B8
	public bool get_richText() { }

	// RVA: 0x16EB6D0
	internal Vector2 get_Internal_clipOffset() { }

	// RVA: 0x16EB808
	internal void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0x16EB93C
	private static IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0x16EB98C
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0x16EBAA8
	private static void Internal_Destroy(IntPtr self) { }

	// RVA: 0x16EBAF8
	private IntPtr GetStyleStatePtr(int idx) { }

	// RVA: 0x16EBC34
	private IntPtr GetRectOffsetPtr(int idx) { }

	// RVA: 0x16EBD70
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	// RVA: 0x16EBE98
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x16EC028
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x16EC188
	private void Internal_DrawCursor(Rect position, GUIContent content, Vector2 pos, Color cursorColor) { }

	// RVA: 0x16EC2E4
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, Vector2 cursorFirstPosition, Vector2 cursorLastPosition, Color cursorColor, Color selectionColor) { }

	// RVA: 0x16EC4CC
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0x16EC614
	private float Internal_CalcHeight(GUIContent content, float width) { }

	// RVA: 0x16EC744
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0x16EC874
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	// RVA: 0x16D8BF8
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	// RVA: 0x16D8A40
	internal static bool IsTooltipActive(string tooltip) { }

	// RVA: 0x16ECA88
	private static float Internal_GetCursorFlashOffset() { }

	// RVA: 0x16E6624
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x16ECB18
	internal static Font GetDefaultFont() { }

	// RVA: 0x16ECC14
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	// RVA: 0x16E5ADC
	public void .ctor() { }

	// RVA: 0x16ECC64
	public void .ctor(GUIStyle other) { }

	// RVA: 0x16ECDD0
	protected override void Finalize() { }

	// RVA: 0x16D944C
	public string get_name() { }

	// RVA: 0x16E7818
	public void set_name(string value) { }

	// RVA: 0x16E9658
	public GUIStyleState get_normal() { }

	// RVA: 0x16DC764
	public RectOffset get_margin() { }

	// RVA: 0x16ECED0
	public RectOffset get_padding() { }

	// RVA: 0x16ED020
	public void set_padding(RectOffset value) { }

	// RVA: 0x16ED0E8
	public float get_lineHeight() { }

	// RVA: 0x16DC8B4
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x16D89E0
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x16DB2BC
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x16D8348
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x16D5D08
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x16ED208
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x16ED22C
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x16ED83C
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x16EDD30
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x16EDF48
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x16DB150
	public static GUIStyle get_none() { }

	// RVA: 0x16ED634
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x16E5710
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x16EDF50
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x16EE020
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	// RVA: 0x16E54E8
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x16EE120
	public void CalcMinMaxWidth(GUIContent content, float minWidth, float maxWidth) { }

	// RVA: 0x16EE14C
	public override string ToString() { }

	// RVA: 0x16EE238
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, MeshInfoBindings[] meshInfos, Vector2 dimensions, int generationId) { }

	// RVA: 0x16EE504
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, Vector2 dimensions) { }

	// RVA: 0x16EE540
	internal static void GetLineHeight(GUIStyle style, float lineHeight) { }

	// RVA: 0x16EE56C
	internal static void EmptyManagedCache() { }

	// RVA: 0x16EE5DC
	private static void .cctor() { }

	// RVA: 0x16EA278
	private static void get_rawName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x16EA4BC
	private static void set_rawName_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x16EA524
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EA63C
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EA754
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EA878
	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	// RVA: 0x16EA9A8
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EAAC0
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EABE0
	private static void get_contentOffset_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16EAD14
	private static void set_contentOffset_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16EAD7C
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EAE94
	private static void set_fixedWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x16EAEFC
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB014
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB064
	private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16EB194
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB1E4
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16EB314
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB438
	private static void set_fontSize_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x16EB568
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB680
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	// RVA: 0x16EB7A0
	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16EB8D4
	private static void set_Internal_clipOffset_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16EBA40
	private static IntPtr Internal_Copy_Injected(GUIStyle self, IntPtr other) { }

	// RVA: 0x16EBBCC
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x16EBD08
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x16EBE40
	private static void AssignRectOffset_Injected(IntPtr _unity_self, int idx, IntPtr srcRectOffset) { }

	// RVA: 0x16EBFA0
	private static void Internal_Draw_Injected(IntPtr _unity_self, Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x16EC118
	private static void Internal_Draw2_Injected(IntPtr _unity_self, Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x16EC274
	private static void Internal_DrawCursor_Injected(IntPtr _unity_self, Rect position, GUIContent content, Vector2 pos, Color cursorColor) { }

	// RVA: 0x16EC424
	private static void Internal_DrawWithTextSelection_Injected(IntPtr _unity_self, Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, Vector2 cursorFirstPosition, Vector2 cursorLastPosition, Color cursorColor, Color selectionColor) { }

	// RVA: 0x16EC5AC
	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, Vector2 maxSize, Vector2 ret) { }

	// RVA: 0x16EC6E4
	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	// RVA: 0x16EC81C
	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, Vector2 ret) { }

	// RVA: 0x16EC960
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, Rect screenRect, GUIContent content, Vector2 textSize, Vector2 ret) { }

	// RVA: 0x16EC9D0
	private static void SetMouseTooltip_Injected(ManagedSpanWrapper tooltip, Rect screenRect) { }

	// RVA: 0x16ECA38
	private static bool IsTooltipActive_Injected(ManagedSpanWrapper tooltip) { }

	// RVA: 0x16ECAC8
	private static void SetDefaultFont_Injected(IntPtr font) { }

	// RVA: 0x16ECBD4
	private static IntPtr GetDefaultFont_Injected() { }

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
public enum TextClipping
{
	// Fields
	public int value__; // 0x10
	public const TextClipping Overflow = 0;
	public const TextClipping Clip = 1;
	public const TextClipping Ellipsis = 2;
}

// Namespace: UnityEngine
public class GUITargetAttribute
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	// RVA: 0x16EE648
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
	internal static System.Action<UnityEngine.EventType,UnityEngine.KeyCode,UnityEngine.EventModifiers> beforeEventProcessed; // 0x40
	private static Event m_Event; // 0x48
	private static bool <guiIsExiting>k__BackingField; // 0x50
	internal static System.Func<System.Boolean> s_HasCurrentWindowKeyFocusFunc; // 0x58

	// Methods

	// RVA: 0x16EE7EC
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x16EE82C
	internal static void set_pixelsPerPoint(float value) { }

	// RVA: 0x16EE884
	internal static int get_guiDepth() { }

	// RVA: 0x16EE8C4
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x16EE914
	internal static bool get_textFieldInput() { }

	// RVA: 0x16EE954
	internal static void set_textFieldInput(bool value) { }

	// RVA: 0x16EE9A4
	public static string get_systemCopyBuffer() { }

	// RVA: 0x16EEB0C
	public static void set_systemCopyBuffer(string value) { }

	// RVA: 0x16EECFC
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x16EEE10
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x16EEF28
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x16EF060
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0x16EF14C
	internal static void Internal_EndContainer() { }

	// RVA: 0x16EF18C
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x16EF278
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x16EF2B8
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x16EF2F8
	internal static bool HasFocusableControls() { }

	// RVA: 0x16EF338
	internal static bool OwnsId(int id) { }

	// RVA: 0x16EF388
	public static Rect AlignRectToDevice(Rect rect, int widthInPixels, int heightInPixels) { }

	// RVA: 0x16EF4C0
	internal static string get_compositionString() { }

	// RVA: 0x16EF628
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x16EF678
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x16EF77C
	private static int Internal_GetHotControl() { }

	// RVA: 0x16EF7BC
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x16EF7FC
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x16EF84C
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x16EF89C
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x16EF8EC
	private static void Internal_ExitGUI() { }

	// RVA: 0x16EF92C
	private static void MarkGUIChanged() { }

	// RVA: 0x16EF9BC
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x16EFAA4
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x16EFB44
	public static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x16EFBB0
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x16EFC3C
	public static int get_hotControl() { }

	// RVA: 0x16EFCCC
	public static void set_hotControl(int value) { }

	// RVA: 0x16EFD78
	internal static void TakeCapture() { }

	// RVA: 0x16EFE08
	internal static void RemoveCapture() { }

	// RVA: 0x16EFE98
	public static int get_keyboardControl() { }

	// RVA: 0x16EFF28
	public static void set_keyboardControl(int value) { }

	// RVA: 0x16EFFD4
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x16F0168
	public static void ExitGUI() { }

	// RVA: 0x16F02B8
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0x16F0394
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool result) { }

	// RVA: 0x16F05E0
	internal static void EndContainer() { }

	// RVA: 0x16F06A0
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	// RVA: 0x16F08FC
	internal static void DestroyGUI(int instanceID) { }

	// RVA: 0x16F0964
	internal static void EndGUI(int layoutType) { }

	// RVA: 0x16F0B58
	internal static bool EndGUIFromException(Exception exception) { }

	// RVA: 0x16F0DD0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x16F077C
	internal static void ResetGlobalState() { }

	// RVA: 0x16F0EB8
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x16F0CD0
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x16F0F54
	internal static void CheckOnGUI() { }

	// RVA: 0x16F1038
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x16F111C
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x16F1254
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x16F12A0
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x16F1384
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x16F14C8
	private static void .cctor() { }

	// RVA: 0x16EEABC
	private static void get_systemCopyBuffer_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16EECAC
	private static void set_systemCopyBuffer_Injected(ManagedSpanWrapper value) { }

	// RVA: 0x16EEDB8
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x16EF010
	private static void BeginContainerFromOwner_Injected(IntPtr owner) { }

	// RVA: 0x16EF0FC
	private static void BeginContainer_Injected(IntPtr objectGUIState) { }

	// RVA: 0x16EF228
	private static int CheckForTabEvent_Injected(IntPtr evt) { }

	// RVA: 0x16EF458
	private static void AlignRectToDevice_Injected(Rect rect, int widthInPixels, int heightInPixels, Rect ret) { }

	// RVA: 0x16EF5D8
	private static void get_compositionString_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16EF72C
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException
{
	// Methods

	// RVA: 0x16F01A4
	public void .ctor() { }

	// RVA: 0x16F1554
	internal void .ctor(string message) { }

}

// Namespace: 
internal class TextHandleTuple
{
	// Fields
	public float lastTimeUsed; // 0x10
	public int hashCode; // 0x14

	// Methods

	// RVA: 0x16F24AC
	public void .ctor(float lastTimeUsed, int hashCode) { }

}

// Namespace: UnityEngine
internal class IMGUITextHandle
{
	// Fields
	internal System.Collections.Generic.LinkedListNode<UnityEngine.IMGUITextHandle.TextHandleTuple> tuple; // 0xB0
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.IMGUITextHandle> textHandles; // 0x0
	private static System.Collections.Generic.LinkedList<UnityEngine.IMGUITextHandle.TextHandleTuple> textHandlesTuple; // 0x8
	private static float lastCleanupTime; // 0x10
	private static int newHandlesSinceCleanup; // 0x14
	internal bool isCachedOnNative; // 0xB8

	// Methods

	// RVA: 0x16F1644
	internal static void EmptyManagedCache() { }

	// RVA: 0x16F1708
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	// RVA: 0x16F2058
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, bool isCached) { }

	// RVA: 0x16F21B0
	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

	// RVA: 0x16F21C8
	private static void ClearUnusedTextHandles() { }

	// RVA: 0x16F1C74
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, bool isCached) { }

	// RVA: 0x16F24E8
	internal static float GetLineHeight(GUIStyle style) { }

	// RVA: 0x16F25EC
	internal Vector2 GetPreferredSize() { }

	// RVA: 0x16F1868
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	// RVA: 0x16F26F4
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	// RVA: 0x16F241C
	public void .ctor() { }

	// RVA: 0x16F270C
	private static void .cctor() { }

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

	// RVA: 0x16F2810
	public GUIStyle get_style() { }

	// RVA: 0x16F2818
	public void set_style(GUIStyle value) { }

	// RVA: 0x16F2850
	public virtual int get_marginLeft() { }

	// RVA: 0x16F287C
	public virtual int get_marginRight() { }

	// RVA: 0x16F28A8
	public virtual int get_marginTop() { }

	// RVA: 0x16F28D4
	public virtual int get_marginBottom() { }

	// RVA: 0x16F2900
	public int get_marginHorizontal() { }

	// RVA: 0x16F2940
	public int get_marginVertical() { }

	// RVA: 0x16F2980
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x16F2A7C
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x16F2B7C
	public virtual void CalcWidth() { }

	// RVA: 0x16F2B80
	public virtual void CalcHeight() { }

	// RVA: 0x16F2B84
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x16F2B90
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x16F2B9C
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x16F2C2C
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x16F2EDC
	public override string ToString() { }

	// RVA: 0x16F3454
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

	// RVA: 0x16F34AC
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x16F3594
	public override void CalcWidth() { }

	// RVA: 0x16F3634
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

	// RVA: 0x16F36A4
	public override int get_marginLeft() { }

	// RVA: 0x16F36AC
	public override int get_marginRight() { }

	// RVA: 0x16F36B4
	public override int get_marginTop() { }

	// RVA: 0x16F36BC
	public override int get_marginBottom() { }

	// RVA: 0x16F36C4
	public void .ctor() { }

	// RVA: 0x16F3808
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x16F38FC
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x16F3978
	public void ResetCursor() { }

	// RVA: 0x16F3980
	public GUILayoutEntry GetNext() { }

	// RVA: 0x16F3C3C
	public Rect GetLast() { }

	// RVA: 0x16F3F68
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x16F3FCC
	public override void CalcWidth() { }

	// RVA: 0x16F4774
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x16F5228
	public override void CalcHeight() { }

	// RVA: 0x16F5904
	public override void SetVertical(float y, float height) { }

	// RVA: 0x16F63CC
	public override string ToString() { }

	// RVA: 0x16F6804
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

	// RVA: 0x16F68E0
	public void .ctor() { }

	// RVA: 0x16F6970
	public override void CalcWidth() { }

	// RVA: 0x16F69EC
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x16F6AE8
	public override void CalcHeight() { }

	// RVA: 0x16F6BC0
	public override void SetVertical(float y, float height) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16F7008
	public static IntPtr ConvertToNative(ObjectGUIState objectGUIState) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16F6D48
	public void .ctor() { }

	// RVA: 0x16F6DE4
	public void Dispose() { }

	// RVA: 0x16F6EEC
	protected override void Finalize() { }

	// RVA: 0x16F6E94
	private void Destroy() { }

	// RVA: 0x16F6DA4
	private static IntPtr Internal_Create() { }

	// RVA: 0x16F6FB8
	private static void Internal_Destroy(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class RuntimeTextSettings
{
	// Fields
	private static RuntimeTextSettings s_DefaultTextSettings; // 0x0
	private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetIMGUIInternal; // 0x8

	// Methods

	// RVA: 0x16F25F4
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	// RVA: 0x16F7024
	internal override System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x16F7070
	internal override void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets) { }

	// RVA: 0x16F70CC
	public void .ctor() { }

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

	// RVA: 0x16F70D4
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

	// RVA: 0x16F70DC
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

	// RVA: 0x16F70E4
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x16F7160
	public float Handle() { }

	// RVA: 0x16F7244
	private float OnMouseDown() { }

	// RVA: 0x16F7794
	private float OnMouseDrag() { }

	// RVA: 0x16F798C
	private float OnMouseUp() { }

	// RVA: 0x16F7B44
	private float OnRepaint() { }

	// RVA: 0x16F7210
	private EventType CurrentEventType() { }

	// RVA: 0x16F8608
	private int CurrentScrollTroughSide() { }

	// RVA: 0x16F8354
	private bool IsEmptySlider() { }

	// RVA: 0x16F841C
	private bool SupportsPageMovements() { }

	// RVA: 0x16F8694
	private float PageMovementValue() { }

	// RVA: 0x16F8A4C
	private float PageUpMovementBound() { }

	// RVA: 0x16F834C
	private Event CurrentEvent() { }

	// RVA: 0x16F8790
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x16F886C
	private float Clamp(float value) { }

	// RVA: 0x16F82EC
	private Rect ThumbSelectionRect() { }

	// RVA: 0x16F8390
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x16F84A0
	private SliderState SliderState() { }

	// RVA: 0x16F89A4
	private Rect ThumbExtRect() { }

	// RVA: 0x16F8A3C
	private Rect ThumbRect() { }

	// RVA: 0x16F8ACC
	private Rect VerticalThumbRect() { }

	// RVA: 0x16F8BF0
	private Rect HorizontalThumbRect() { }

	// RVA: 0x16F8364
	private float ClampedCurrentValue() { }

	// RVA: 0x16F8898
	private float MousePosition() { }

	// RVA: 0x16F88FC
	private float ValuesPerPixel() { }

	// RVA: 0x16F8D14
	private float ThumbSize() { }

	// RVA: 0x16F8AB4
	private float MaxValue() { }

	// RVA: 0x16F8AA4
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
	internal TextHandle textHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal bool isCompositionActive; // 0x24
	private bool m_UpdateImeWindowPosition; // 0x25
	internal Action OnTextChanged; // 0x28
	public bool multiline; // 0x30
	private string m_Text; // 0x38
	private static System.Collections.Generic.Dictionary<UnityEngine.Event,UnityEngine.TextEditOp> s_KeyEditOps; // 0x0
	private Char m_HighSurrogate; // 0x40

	// Methods

	// RVA: 0x16F8DDC
	private bool get_hasSelection() { }

	// RVA: 0x16F8F58
	internal void set_revealCursor(bool value) { }

	// RVA: 0x16F8FCC
	internal int get_stringCursorIndex() { }

	// RVA: 0x16F9048
	private int get_cursorIndex() { }

	// RVA: 0x16F9114
	private void set_cursorIndex(int value) { }

	// RVA: 0x16F9188
	private int get_cursorIndexNoValidation() { }

	// RVA: 0x16F91B0
	private void set_cursorIndexNoValidation(int value) { }

	// RVA: 0x16F9224
	private void set_selectIndexNoValidation(int value) { }

	// RVA: 0x16F9298
	internal int get_stringSelectIndex() { }

	// RVA: 0x16F9314
	private int get_selectIndex() { }

	// RVA: 0x16F93E0
	private void set_selectIndex(int value) { }

	// RVA: 0x16F9454
	public string get_text() { }

	// RVA: 0x16F945C
	public void set_text(string value) { }

	// RVA: 0x16F9500
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x16F9508
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x16F9578
	public bool UpdateImeState() { }

	// RVA: 0x16F98A8
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x16F98B0
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x16F9A18
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x16F9CEC
	public void EnableCursorPreviewState() { }

	// RVA: 0x16F9C58
	public void RestoreCursorState() { }

	// RVA: 0x16F9DD8
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x16FB508
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x16FEEB0
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x16F9F70
	private void InitKeyActions() { }

	// RVA: 0x16FE79C
	public bool DeleteLineBack() { }

	// RVA: 0x16FE4D4
	public bool DeleteWordBack() { }

	// RVA: 0x16FEBE4
	public bool DeleteWordForward() { }

	// RVA: 0x16FDA9C
	public bool Delete() { }

	// RVA: 0x16FDE40
	public bool Backspace() { }

	// RVA: 0x16FEF54
	public bool DeleteSelection() { }

	// RVA: 0x16F9640
	public void ReplaceSelection(string replace) { }

	// RVA: 0x16FFAC8
	public bool Insert(Char c) { }

	// RVA: 0x16FFC48
	public bool CanPaste() { }

	// RVA: 0x16FE37C
	public bool Cut() { }

	// RVA: 0x16FE3AC
	public bool Paste() { }

	// RVA: 0x16FFDDC
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x16FFE74
	internal void OnBlur() { }

	// RVA: 0x1700074
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

// Namespace: UnityEngine
public class TextEditor
{
	// Fields
	private readonly GUIContent m_Content; // 0x10
	private TextSelectingUtilities m_TextSelecting; // 0x18
	internal TextEditingUtilities m_TextEditing; // 0x20
	internal IMGUITextHandle m_TextHandle; // 0x28
	public TouchScreenKeyboard keyboardOnScreen; // 0x30
	public int controlID; // 0x38
	public GUIStyle style; // 0x40
	public bool hasHorizontalCursorPos; // 0x48
	public bool isPasswordField; // 0x49
	public Vector2 scrollOffset; // 0x4C
	private bool focus; // 0x54
	private string m_TextWithWhitespace; // 0x58
	private Rect <position>k__BackingField; // 0x60
	public Vector2 graphicalCursorPos; // 0x70
	private Vector2 lastCursorPos; // 0x78
	private Vector2 previousContentSize; // 0x80
	private string oldText; // 0x88
	private int oldPos; // 0x90
	private int oldSelectPos; // 0x94

	// Methods

	// RVA: 0x1700120
	public void set_isMultiline(bool value) { }

	// RVA: 0x1700140
	public bool get_showCursor() { }

	// RVA: 0x1700160
	internal bool get_m_HasFocus() { }

	// RVA: 0x1700168
	internal void set_m_HasFocus(bool value) { }

	// RVA: 0x1700170
	public string get_text() { }

	// RVA: 0x1700190
	public void set_text(string value) { }

	// RVA: 0x17004C0
	internal string get_textWithWhitespace() { }

	// RVA: 0x17002A8
	internal void set_textWithWhitespace(string value) { }

	// RVA: 0x170056C
	public Rect get_position() { }

	// RVA: 0x1700578
	public void set_position(Rect value) { }

	// RVA: 0x1700584
	public int get_cursorIndex() { }

	// RVA: 0x17005EC
	public int get_selectIndex() { }

	// RVA: 0x1700654
	public void .ctor() { }

	// RVA: 0x1700BB8
	private void OnTextChangedHandle() { }

	// RVA: 0x1700C6C
	private void OnContentTextChangedHandle() { }

	// RVA: 0x1700D18
	public void OnFocus() { }

	// RVA: 0x1700E7C
	public void OnLostFocus() { }

	// RVA: 0x1700E84
	public bool HandleKeyEvent(Event e) { }

	// RVA: 0x1700FF8
	public void ReplaceSelection(string replace) { }

	// RVA: 0x1701014
	public void Insert(Char c) { }

	// RVA: 0x1701030
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x17010A0
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x1701278
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x17010D4
	private Vector2 GetLocalCursorPosition(Vector2 cursorPosition) { }

	// RVA: 0x1701870
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1701AB0
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x1701AD8
	public void SelectCurrentWord() { }

	// RVA: 0x1701E00
	public void SelectCurrentParagraph() { }

	// RVA: 0x1702100
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0x170032C
	internal void UpdateTextHandle() { }

	// RVA: 0x1702160
	internal void UpdateScrollOffset() { }

	// RVA: 0x17025CC
	public void DrawCursor(string newText) { }

	// RVA: 0x1702BA8
	public void SaveBackup() { }

	// RVA: 0x1702C8C
	public void DetectFocusChange() { }

	// RVA: 0x1702C98
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x1702ED0
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x1702ED4
	internal virtual void OnSelectIndexChange() { }

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
	public TextHandle textHandle; // 0x28
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

	// RVA: 0x16F8E9C
	public bool get_hasSelection() { }

	// RVA: 0x1702ED8
	public bool get_revealCursor() { }

	// RVA: 0x16F8FA0
	public void set_revealCursor(bool value) { }

	// RVA: 0x1702EE0
	private int get_m_CharacterCount() { }

	// RVA: 0x1702F00
	private int get_characterCount() { }

	// RVA: 0x1702FD4
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x16F90B0
	public int get_cursorIndex() { }

	// RVA: 0x16F915C
	public void set_cursorIndex(int value) { }

	// RVA: 0x16F91A8
	internal int get_cursorIndexNoValidation() { }

	// RVA: 0x16F91F8
	internal void set_cursorIndexNoValidation(int value) { }

	// RVA: 0x1703030
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x16F937C
	public int get_selectIndex() { }

	// RVA: 0x16F9428
	public void set_selectIndex(int value) { }

	// RVA: 0x16F926C
	internal void set_selectIndexNoValidation(int value) { }

	// RVA: 0x1703038
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x1703040
	public string get_selectedText() { }

	// RVA: 0x1700B64
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x1700ED4
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x1704104
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x17061D4
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x170331C
	private void InitKeyActions() { }

	// RVA: 0x16FFAB8
	public void ClearCursorPos() { }

	// RVA: 0x1700DD0
	public void OnFocus(bool selectAll) { }

	// RVA: 0x170615C
	public void SelectAll() { }

	// RVA: 0x16FFFC4
	public void SelectNone() { }

	// RVA: 0x170469C
	public void SelectLeft() { }

	// RVA: 0x17048E0
	public void SelectRight() { }

	// RVA: 0x1704B28
	public void SelectUp() { }

	// RVA: 0x1704BE8
	public void SelectDown() { }

	// RVA: 0x17054D8
	public void SelectTextEnd() { }

	// RVA: 0x17054B0
	public void SelectTextStart() { }

	// RVA: 0x17053FC
	public void SelectToStartOfNextWord() { }

	// RVA: 0x1705348
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x1704CA8
	public void SelectWordRight() { }

	// RVA: 0x1704FF8
	public void SelectWordLeft() { }

	// RVA: 0x1705FF4
	public void SelectGraphicalLineStart() { }

	// RVA: 0x17060A8
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1705960
	public void SelectParagraphForward() { }

	// RVA: 0x1705CB0
	public void SelectParagraphBackward() { }

	// RVA: 0x1701AF4
	public void SelectCurrentWord() { }

	// RVA: 0x1701E1C
	public void SelectCurrentParagraph() { }

	// RVA: 0x16FBBF0
	public void MoveRight() { }

	// RVA: 0x16FB920
	public void MoveLeft() { }

	// RVA: 0x16FBED0
	public void MoveUp() { }

	// RVA: 0x16FC144
	public void MoveDown() { }

	// RVA: 0x16FC3CC
	public void MoveLineStart() { }

	// RVA: 0x16FC5C4
	public void MoveLineEnd() { }

	// RVA: 0x16FD784
	public void MoveGraphicalLineStart() { }

	// RVA: 0x16FD910
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x16FD01C
	public void MoveTextStart() { }

	// RVA: 0x16FD088
	public void MoveTextEnd() { }

	// RVA: 0x16FD104
	public void MoveParagraphForward() { }

	// RVA: 0x16FD440
	public void MoveParagraphBackward() { }

	// RVA: 0x16FC7EC
	public void MoveWordRight() { }

	// RVA: 0x16FCA54
	public void MoveToStartOfNextWord() { }

	// RVA: 0x16FCBDC
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x16FCD64
	public void MoveWordLeft() { }

	// RVA: 0x170188C
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1705528
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1705744
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1701AD0
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x170119C
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x17012A4
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x17067BC
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x17068C4
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x16FF73C
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x16FF544
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1706578
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x1703000
	private int ClampTextIndex(int index) { }

	// RVA: 0x1706528
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x16FFA58
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x1706278
	public int NextCodePointIndex(int index) { }

	// RVA: 0x17062DC
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x17063F8
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x16FFCC4
	public void Copy() { }

	// RVA: 0x1706A08
	private CharacterType ClassifyChar(int index) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Methods

	// RVA: 0x1706B6C
	internal static UInt32 ComputeStringHash(string s) { }

}


