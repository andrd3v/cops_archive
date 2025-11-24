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

	// RVA: 0x160FFC4
	public EventType get_rawType() { }

	// RVA: 0x1610014
	public Vector2 get_mousePosition() { }

	// RVA: 0x16100D4
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x1610190
	public Vector2 get_delta() { }

	// RVA: 0x1610250
	public void set_delta(Vector2 value) { }

	// RVA: 0x161030C
	public PointerType get_pointerType() { }

	// RVA: 0x161035C
	public int get_button() { }

	// RVA: 0x16103AC
	public EventModifiers get_modifiers() { }

	// RVA: 0x16103FC
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1610464
	public float get_pressure() { }

	// RVA: 0x16104B4
	public float get_twist() { }

	// RVA: 0x1610504
	public Vector2 get_tilt() { }

	// RVA: 0x16105C4
	public PenStatus get_penStatus() { }

	// RVA: 0x1610614
	public int get_clickCount() { }

	// RVA: 0x1610664
	public Char get_character() { }

	// RVA: 0x16106B4
	public void set_character(Char value) { }

	// RVA: 0x161071C
	public KeyCode get_keyCode() { }

	// RVA: 0x161076C
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x16107D4
	public int get_displayIndex() { }

	// RVA: 0x1610824
	public void set_displayIndex(int value) { }

	// RVA: 0x161088C
	public EventType get_type() { }

	// RVA: 0x16108DC
	public void set_type(EventType value) { }

	// RVA: 0x1610944
	public string get_commandName() { }

	// RVA: 0x1610994
	public void set_commandName(string value) { }

	// RVA: 0x16109FC
	private void Internal_Use() { }

	// RVA: 0x1610A4C
	private static IntPtr Internal_Create(int displayIndex) { }

	// RVA: 0x1610A9C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1610AEC
	public EventType GetTypeForControl(int controlID) { }

	// RVA: 0x1610B54
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1610BBC
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1610C0C
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0x1610C5C
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1610E0C
	internal static int GetDoubleClickTime() { }

	// RVA: 0x1610E4C
	public void .ctor() { }

	// RVA: 0x1610DB0
	public void .ctor(int displayIndex) { }

	// RVA: 0x1610EB4
	protected override void Finalize() { }

	// RVA: 0x1610F90
	internal void CopyFrom(Event e) { }

	// RVA: 0x1611028
	public bool get_shift() { }

	// RVA: 0x1611088
	public bool get_control() { }

	// RVA: 0x16110E8
	public bool get_alt() { }

	// RVA: 0x1611148
	public bool get_command() { }

	// RVA: 0x16111A8
	public static Event get_current() { }

	// RVA: 0x16111F4
	public static void set_current(Event value) { }

	// RVA: 0x16112B4
	public bool get_isKey() { }

	// RVA: 0x1611304
	public bool get_isMouse() { }

	// RVA: 0x1611390
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x1611428
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x16131B8
	public override int GetHashCode() { }

	// RVA: 0x1613338
	public override bool Equals(object obj) { }

	// RVA: 0x1613690
	public override string ToString() { }

	// RVA: 0x1613F98
	public void Use() { }

	// RVA: 0x161006C
	private void get_mousePosition_Injected(Vector2 ret) { }

	// RVA: 0x1610128
	private void set_mousePosition_Injected(Vector2 value) { }

	// RVA: 0x16101E8
	private void get_delta_Injected(Vector2 ret) { }

	// RVA: 0x16102A4
	private void set_delta_Injected(Vector2 value) { }

	// RVA: 0x161055C
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

	// RVA: 0x16141B4
	public bool get_wantsMouseMove() { }

	// RVA: 0x16141BC
	public void set_wantsMouseMove(bool value) { }

	// RVA: 0x16141C4
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x16141CC
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	// RVA: 0x16141D4
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x16141DC
	public bool WantsEvent(EventType type) { }

	// RVA: 0x161420C
	public bool WantsLayoutPass(EventType type) { }

}

// Namespace: 
public sealed class WindowFunction
{
	// Methods

	// RVA: 0x162205C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1622100
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

	// RVA: 0x1614394
	public static Color get_color() { }

	// RVA: 0x1614490
	public static void set_color(Color value) { }

	// RVA: 0x1614598
	public static Color get_backgroundColor() { }

	// RVA: 0x1614694
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x161479C
	public static Color get_contentColor() { }

	// RVA: 0x1614898
	public static void set_contentColor(Color value) { }

	// RVA: 0x16149A0
	public static bool get_changed() { }

	// RVA: 0x16149E0
	public static void set_changed(bool value) { }

	// RVA: 0x1614A30
	public static bool get_enabled() { }

	// RVA: 0x1614A70
	public static void set_enabled(bool value) { }

	// RVA: 0x1614AC0
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x1614B00
	internal static Material get_blendMaterial() { }

	// RVA: 0x1614B40
	internal static Material get_blitMaterial() { }

	// RVA: 0x1614B80
	internal static Material get_roundedRectMaterial() { }

	// RVA: 0x1614BC0
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1614C00
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1614C50
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1614CA0
	internal static void ReleaseMouseControl() { }

	// RVA: 0x1614CE0
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1614D20
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x1614ED4
	private static void .cctor() { }

	// RVA: 0x16151B4
	internal static int get_scrollTroughSide() { }

	// RVA: 0x1615230
	internal static void set_scrollTroughSide(int value) { }

	// RVA: 0x16152BC
	internal static DateTime get_nextScrollStepTime() { }

	// RVA: 0x1615338
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x16153C4
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1615758
	public static GUISkin get_skin() { }

	// RVA: 0x1615568
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x16159F0
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1615AC8
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1615B88
	public static void Label(Rect position, string text) { }

	// RVA: 0x1615E00
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1616348
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x1616484
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x161657C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1616628
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1616810
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x161693C
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1616B28
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1616C8C
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1616DD8
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x16175F0
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, Rect outScreenRect, Rect outSourceRect) { }

	// RVA: 0x16176E4
	public static void Box(Rect position, string text) { }

	// RVA: 0x16177FC
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1617D38
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1617FE0
	public static bool Button(Rect position, GUIContent content) { }

	// RVA: 0x1617E50
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16181B8
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1618420
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x1618C5C
	internal static string PasswordFieldGetStrToShow(string password, Char maskChar) { }

	// RVA: 0x1618DEC
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x1618F0C
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1618FD8
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar) { }

	// RVA: 0x1619AD4
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0x161A330
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1619518
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x161B608
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1615EE8
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16182B0
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x161BF9C
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x161C06C
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x161C230
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x161D010
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x161D3D4
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x161C9F0
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x161D8C4
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x161D9A0
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x161E12C
	public static void EndGroup() { }

	// RVA: 0x161E204
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x161E280
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x161FBD4
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x1620B7C
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

	// RVA: 0x1620FB8
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x1620DEC
	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x1621198
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x1614440
	private static void get_color_Injected(Color ret) { }

	// RVA: 0x1614548
	private static void set_color_Injected(Color value) { }

	// RVA: 0x1614644
	private static void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x161474C
	private static void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x1614848
	private static void get_contentColor_Injected(Color ret) { }

	// RVA: 0x1614950
	private static void set_contentColor_Injected(Color value) { }

	// RVA: 0x1614E34
	private static void Internal_DoWindow_Injected(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, Rect ret) { }

}

// Namespace: 
internal struct ParentClipScope
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x162259C
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x1622618
	public void Dispose() { }

}

// Namespace: UnityEngine
internal sealed class GUIClip
{
	// Methods

	// RVA: 0x161BE44
	internal static Rect get_visibleRect() { }

	// RVA: 0x1622164
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x161E1C4
	internal static void Internal_Pop() { }

	// RVA: 0x1622234
	internal static int Internal_GetCount() { }

	// RVA: 0x1622274
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x1615A60
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x1615B38
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x16223D4
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x1622444
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x1622504
	internal static void Internal_PopParentClip() { }

	// RVA: 0x161E0C4
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1620B3C
	internal static void Pop() { }

	// RVA: 0x1622544
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x1622114
	private static void get_visibleRect_Injected(Rect ret) { }

	// RVA: 0x16221CC
	private static void Internal_Push_Injected(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x16222CC
	private static void UnclipToWindow_Vector2_Injected(Vector2 pos, Vector2 ret) { }

	// RVA: 0x1622334
	private static void GetMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x1622384
	private static void SetMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x16224AC
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

	// RVA: 0x1619410
	public string get_text() { }

	// RVA: 0x1619418
	public void set_text(string value) { }

	// RVA: 0x1622674
	public void set_image(Texture value) { }

	// RVA: 0x161BE3C
	public string get_tooltip() { }

	// RVA: 0x162267C
	public void set_tooltip(string value) { }

	// RVA: 0x1622684
	public void .ctor() { }

	// RVA: 0x1622708
	public void .ctor(string text) { }

	// RVA: 0x1622770
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x162286C
	public void .ctor(GUIContent src) { }

	// RVA: 0x1615D1C
	internal static GUIContent Temp(string t) { }

	// RVA: 0x162296C
	internal static void ClearStaticCache() { }

	// RVA: 0x1622AA4
	public override string ToString() { }

	// RVA: 0x1622AC4
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

	// RVA: 0x1622D00
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x162303C
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1622E78
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1623130
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x16233E0
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16232A8
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x162345C
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x16239F4
	public static string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1623594
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1623AF0
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1623CD8
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1623EE4
	public static void Space(float pixels) { }

	// RVA: 0x1624544
	public static void FlexibleSpace() { }

	// RVA: 0x1624AA0
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1624B68
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1625100
	public static void EndHorizontal() { }

	// RVA: 0x1625474
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x162553C
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1625710
	public static void EndVertical() { }

	// RVA: 0x1625778
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1625B00
	public static void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x1625860
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x1625F34
	public static void EndArea() { }

	// RVA: 0x1626348
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x16265C0
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x162688C
	public static void EndScrollView() { }

	// RVA: 0x162693C
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x1621968
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x16269FC
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x1626AB0
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x1621A18
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1626B64
	public static GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x16249B0
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1624904
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

	// RVA: 0x1624A5C
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

	// RVA: 0x1628F04
	private void set_id(int value) { }

	// RVA: 0x1627028
	internal void .ctor(int instanceID) { }

	// RVA: 0x1628F0C
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

	// RVA: 0x1626C18
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1626D3C
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x1626E58
	internal static int get_unbalancedgroupscount() { }

	// RVA: 0x1626ED4
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x1626F60
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x16217B0
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1627134
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x1627220
	internal static void Begin(int instanceID) { }

	// RVA: 0x1627474
	internal static void BeginContainer(LayoutCache cache) { }

	// RVA: 0x1621ACC
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1621DD8
	internal static void Layout() { }

	// RVA: 0x1627BD0
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x1627E10
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x16276F4
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1627940
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1627FB8
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1624D38
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x1625168
	internal static void EndLayoutGroup() { }

	// RVA: 0x1625B9C
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x162613C
	internal static void EndLayoutArea() { }

	// RVA: 0x1628218
	public static Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x16230B8
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1628284
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16244BC
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1628978
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1628B8C
	public static Rect GetLastRect() { }

	// RVA: 0x16242E0
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1628DE4
	private static void .cctor() { }

	// RVA: 0x1626CD4
	private static void Internal_GetWindowRect_Injected(int windowID, Rect ret) { }

	// RVA: 0x1626DF0
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

	// RVA: 0x16291F0
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x161B510
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x161B518
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x1629230
	public Color get_cursorColor() { }

	// RVA: 0x162923C
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1629294
	public Color get_selectionColor() { }

	// RVA: 0x16292A0
	public void set_selectionColor(Color value) { }

	// RVA: 0x16292AC
	public void .ctor() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate
{
	// Methods

	// RVA: 0x162CC44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x162CCE4
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

	// RVA: 0x16292D8
	public void .ctor() { }

	// RVA: 0x16293B4
	internal void OnEnable() { }

	// RVA: 0x16294E4
	internal static void CleanupRoots() { }

	// RVA: 0x161B570
	public Font get_font() { }

	// RVA: 0x1629550
	public void set_font(Font value) { }

	// RVA: 0x16177F4
	public GUIStyle get_box() { }

	// RVA: 0x1629768
	public void set_box(GUIStyle value) { }

	// RVA: 0x1615DF8
	public GUIStyle get_label() { }

	// RVA: 0x1629808
	public void set_label(GUIStyle value) { }

	// RVA: 0x162358C
	public GUIStyle get_textField() { }

	// RVA: 0x16298A8
	public void set_textField(GUIStyle value) { }

	// RVA: 0x1629948
	public GUIStyle get_textArea() { }

	// RVA: 0x1629950
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x1617E48
	public GUIStyle get_button() { }

	// RVA: 0x16299F0
	public void set_button(GUIStyle value) { }

	// RVA: 0x1629A90
	public GUIStyle get_toggle() { }

	// RVA: 0x1629A98
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1620DE4
	public GUIStyle get_window() { }

	// RVA: 0x1629B38
	public void set_window(GUIStyle value) { }

	// RVA: 0x1623CC8
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1629BD8
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x1623CD0
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1629C78
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1629D18
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1629D20
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1629DC0
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x1629DC8
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x1629E68
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1629E70
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1629F10
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1629F18
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1629FB8
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1629FC0
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x16265A8
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x162A060
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x162A100
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x162A108
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x162A1A8
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x162A1B0
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x162A250
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x162A258
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x16265B0
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x162A2F8
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x162A398
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x162A3A0
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x162A440
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x162A448
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x162A4E8
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x162A4F0
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x16265B8
	public GUIStyle get_scrollView() { }

	// RVA: 0x162A590
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x162A630
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x162A638
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x161B508
	public GUISettings get_settings() { }

	// RVA: 0x162A6EC
	internal static GUIStyle get_error() { }

	// RVA: 0x162944C
	internal void Apply() { }

	// RVA: 0x162A904
	private void BuildStyleCache() { }

	// RVA: 0x161C704
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x162CAEC
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x16158F0
	internal void MakeCurrent() { }

	// RVA: 0x162CB80
	public IEnumerator GetEnumerator() { }

}

// Namespace: UnityEngine
internal class GUIStateObjects
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x162CCF8
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x162CE98
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

	// RVA: 0x162CF34
	public void set_background(Texture2D value) { }

	// RVA: 0x162CA94
	public void set_textColor(Color value) { }

	// RVA: 0x162D004
	private static IntPtr Init() { }

	// RVA: 0x162D044
	private void Cleanup() { }

	// RVA: 0x162D094
	public void .ctor() { }

	// RVA: 0x162D0F0
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x162D138
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x162D1B4
	protected override void Finalize() { }

	// RVA: 0x162CF9C
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

	// RVA: 0x162D27C
	internal string get_rawName() { }

	// RVA: 0x162D2CC
	internal void set_rawName(string value) { }

	// RVA: 0x161B520
	public Font get_font() { }

	// RVA: 0x162D334
	public ImagePosition get_imagePosition() { }

	// RVA: 0x162D384
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x162D3EC
	public bool get_wordWrap() { }

	// RVA: 0x162D43C
	public Vector2 get_contentOffset() { }

	// RVA: 0x162D4FC
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x161D824
	public float get_fixedWidth() { }

	// RVA: 0x162D5B8
	public void set_fixedWidth(float value) { }

	// RVA: 0x161D874
	public float get_fixedHeight() { }

	// RVA: 0x162D620
	public bool get_stretchWidth() { }

	// RVA: 0x1628D7C
	public void set_stretchWidth(bool value) { }

	// RVA: 0x162D670
	public bool get_stretchHeight() { }

	// RVA: 0x162C948
	public void set_stretchHeight(bool value) { }

	// RVA: 0x162D6C0
	public void set_fontSize(int value) { }

	// RVA: 0x162D728
	internal void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0x162D7E4
	private static IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0x162D834
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0x162D89C
	private static void Internal_Destroy(IntPtr self) { }

	// RVA: 0x162D8EC
	private IntPtr GetStyleStatePtr(int idx) { }

	// RVA: 0x162D954
	private IntPtr GetRectOffsetPtr(int idx) { }

	// RVA: 0x162D9BC
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	// RVA: 0x162DA14
	private static float Internal_GetLineHeight(IntPtr target) { }

	// RVA: 0x162DA64
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x162DB84
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x162DC74
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x162DD60
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x162DED8
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x162DFC4
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x162E09C
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x162E18C
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	// RVA: 0x162E24C
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0x162E324
	private float Internal_CalcHeight(GUIContent content, float width) { }

	// RVA: 0x162E384
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0x161BEE8
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	// RVA: 0x161BE98
	internal static bool IsTooltipActive(string tooltip) { }

	// RVA: 0x162E4AC
	private static float Internal_GetCursorFlashOffset() { }

	// RVA: 0x1629718
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1628CC0
	public void .ctor() { }

	// RVA: 0x162E4EC
	public void .ctor(GUIStyle other) { }

	// RVA: 0x162E60C
	protected override void Finalize() { }

	// RVA: 0x161C680
	public string get_name() { }

	// RVA: 0x162A894
	public void set_name(string value) { }

	// RVA: 0x162C9B0
	public GUIStyleState get_normal() { }

	// RVA: 0x161FA04
	public RectOffset get_margin() { }

	// RVA: 0x162E724
	public RectOffset get_padding() { }

	// RVA: 0x162E7FC
	public void set_padding(RectOffset value) { }

	// RVA: 0x162E858
	public float get_lineHeight() { }

	// RVA: 0x161FADC
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x161BDA4
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x161DF9C
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x161B420
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1617B54
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x162E9B8
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x162EC34
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x162F00C
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x162F440
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x162F750
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x161DE30
	public static GUIStyle get_none() { }

	// RVA: 0x162F758
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x162F7D4
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x162F844
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x162880C
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x162F8AC
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x162872C
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x162F90C
	public void CalcMinMaxWidth(GUIContent content, float minWidth, float maxWidth) { }

	// RVA: 0x162F98C
	public override string ToString() { }

	// RVA: 0x162FA98
	private static void .cctor() { }

	// RVA: 0x162D494
	private void get_contentOffset_Injected(Vector2 ret) { }

	// RVA: 0x162D550
	private void set_contentOffset_Injected(Vector2 value) { }

	// RVA: 0x162D77C
	private void set_Internal_clipOffset_Injected(Vector2 value) { }

	// RVA: 0x162DAFC
	private void Internal_Draw_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x162DC04
	private void Internal_Draw2_Injected(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x162DCF0
	private void Internal_DrawCursor_Injected(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x162DE30
	private void Internal_DrawWithTextSelection_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x162DF54
	private void Internal_GetCursorPixelPosition_Injected(Rect position, GUIContent content, int cursorStringIndex, Vector2 ret) { }

	// RVA: 0x162E034
	private int Internal_GetCursorStringIndex_Injected(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x162E11C
	private string Internal_GetSelectedRenderedText_Injected(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x162E1F4
	private void Internal_CalcSize_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x162E2BC
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, Vector2 maxSize, Vector2 ret) { }

	// RVA: 0x162E3EC
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x162E444
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

	// RVA: 0x162FAE8
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

	// RVA: 0x16276B4
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x162FC98
	internal static int get_guiDepth() { }

	// RVA: 0x161E074
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x1614354
	internal static bool get_textFieldInput() { }

	// RVA: 0x161B5B8
	internal static void set_textFieldInput(bool value) { }

	// RVA: 0x162FCD8
	public static string get_systemCopyBuffer() { }

	// RVA: 0x162FD18
	public static void set_systemCopyBuffer(string value) { }

	// RVA: 0x162FD68
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x16180A0
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x162FE7C
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x162FECC
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0x162FF1C
	internal static void Internal_EndContainer() { }

	// RVA: 0x162FF5C
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x162FFAC
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x162FFEC
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x163002C
	internal static bool HasFocusableControls() { }

	// RVA: 0x163006C
	internal static bool OwnsId(int id) { }

	// RVA: 0x16300BC
	public static Rect AlignRectToDevice(Rect rect, int widthInPixels, int heightInPixels) { }

	// RVA: 0x161B578
	internal static string get_compositionString() { }

	// RVA: 0x16301F4
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1630244
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1630348
	private static int Internal_GetHotControl() { }

	// RVA: 0x1630388
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x16303C8
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x1630418
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x1630468
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x16304B8
	private static void Internal_ExitGUI() { }

	// RVA: 0x16304F8
	private static void MarkGUIChanged() { }

	// RVA: 0x1623A08
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1617AB4
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x161948C
	public static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x1630588
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1618BCC
	public static int get_hotControl() { }

	// RVA: 0x1618B20
	public static void set_hotControl(int value) { }

	// RVA: 0x1630614
	internal static void TakeCapture() { }

	// RVA: 0x16306A4
	internal static void RemoveCapture() { }

	// RVA: 0x161B2E4
	public static int get_keyboardControl() { }

	// RVA: 0x161B374
	public static void set_keyboardControl(int value) { }

	// RVA: 0x162EAA0
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x1630734
	public static void ExitGUI() { }

	// RVA: 0x1615814
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0x1630884
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool result) { }

	// RVA: 0x1630A9C
	internal static void EndContainer() { }

	// RVA: 0x1630B5C
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	// RVA: 0x1630E7C
	internal static void DestroyGUI(int instanceID) { }

	// RVA: 0x1630F04
	internal static void EndGUI(int layoutType) { }

	// RVA: 0x1631134
	internal static bool EndGUIFromException(Exception exception) { }

	// RVA: 0x16313AC
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1630C4C
	internal static void ResetGlobalState() { }

	// RVA: 0x1631494
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x16312AC
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1615484
	internal static void CheckOnGUI() { }

	// RVA: 0x1631530
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x1631614
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x163174C
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1631798
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x161BBC0
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x163187C
	private static void .cctor() { }

	// RVA: 0x162FE24
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x163018C
	private static void AlignRectToDevice_Injected(Rect rect, int widthInPixels, int heightInPixels, Rect ret) { }

	// RVA: 0x16302F8
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException
{
	// Methods

	// RVA: 0x1630770
	public void .ctor() { }

	// RVA: 0x1628128
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

	// RVA: 0x1631934
	public GUIStyle get_style() { }

	// RVA: 0x162767C
	public void set_style(GUIStyle value) { }

	// RVA: 0x163193C
	public virtual int get_marginLeft() { }

	// RVA: 0x1631A04
	public virtual int get_marginRight() { }

	// RVA: 0x1631ACC
	public virtual int get_marginTop() { }

	// RVA: 0x1631B94
	public virtual int get_marginBottom() { }

	// RVA: 0x1631C5C
	public int get_marginHorizontal() { }

	// RVA: 0x1631C9C
	public int get_marginVertical() { }

	// RVA: 0x1631CDC
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x162887C
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x1631DD0
	public virtual void CalcWidth() { }

	// RVA: 0x1631DD4
	public virtual void CalcHeight() { }

	// RVA: 0x1631DD8
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1631DE4
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1631DF0
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1631F18
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1632208
	public override string ToString() { }

	// RVA: 0x16327C8
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

	// RVA: 0x1632820
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x163290C
	public override void CalcWidth() { }

	// RVA: 0x16329B4
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

	// RVA: 0x1632A2C
	public override int get_marginLeft() { }

	// RVA: 0x1632A34
	public override int get_marginRight() { }

	// RVA: 0x1632A3C
	public override int get_marginTop() { }

	// RVA: 0x1632A44
	public override int get_marginBottom() { }

	// RVA: 0x1632A4C
	public void .ctor() { }

	// RVA: 0x1632B94
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1632CB4
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1632D34
	public void ResetCursor() { }

	// RVA: 0x1632D3C
	public GUILayoutEntry GetNext() { }

	// RVA: 0x1632FF8
	public Rect GetLast() { }

	// RVA: 0x1633324
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x1633388
	public override void CalcWidth() { }

	// RVA: 0x1633B04
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1634584
	public override void CalcHeight() { }

	// RVA: 0x1634C88
	public override void SetVertical(float y, float height) { }

	// RVA: 0x163571C
	public override string ToString() { }

	// RVA: 0x1635B58
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

	// RVA: 0x1635C38
	public void .ctor() { }

	// RVA: 0x1635CC8
	public override void CalcWidth() { }

	// RVA: 0x1635D44
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1635E40
	public override void CalcHeight() { }

	// RVA: 0x1635F18
	public override void SetVertical(float y, float height) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16360A0
	public void .ctor() { }

	// RVA: 0x163613C
	public void Dispose() { }

	// RVA: 0x1636270
	protected override void Finalize() { }

	// RVA: 0x1636208
	private void Destroy() { }

	// RVA: 0x16360FC
	private static IntPtr Internal_Create() { }

	// RVA: 0x163634C
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

	// RVA: 0x163639C
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

	// RVA: 0x16363A4
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

	// RVA: 0x16363AC
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1636428
	public float Handle() { }

	// RVA: 0x163650C
	private float OnMouseDown() { }

	// RVA: 0x16369F0
	private float OnMouseDrag() { }

	// RVA: 0x1636B80
	private float OnMouseUp() { }

	// RVA: 0x1636C5C
	private float OnRepaint() { }

	// RVA: 0x16364D8
	private EventType CurrentEventType() { }

	// RVA: 0x16375E0
	private int CurrentScrollTroughSide() { }

	// RVA: 0x1637378
	private bool IsEmptySlider() { }

	// RVA: 0x1637440
	private bool SupportsPageMovements() { }

	// RVA: 0x163766C
	private float PageMovementValue() { }

	// RVA: 0x1637A24
	private float PageUpMovementBound() { }

	// RVA: 0x1637370
	private Event CurrentEvent() { }

	// RVA: 0x1637768
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x1637844
	private float Clamp(float value) { }

	// RVA: 0x1637310
	private Rect ThumbSelectionRect() { }

	// RVA: 0x16373B4
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x16374C4
	private SliderState SliderState() { }

	// RVA: 0x163797C
	private Rect ThumbExtRect() { }

	// RVA: 0x1637A14
	private Rect ThumbRect() { }

	// RVA: 0x1637AA4
	private Rect VerticalThumbRect() { }

	// RVA: 0x1637BC8
	private Rect HorizontalThumbRect() { }

	// RVA: 0x1637388
	private float ClampedCurrentValue() { }

	// RVA: 0x1637870
	private float MousePosition() { }

	// RVA: 0x16378D4
	private float ValuesPerPixel() { }

	// RVA: 0x1637CEC
	private float ThumbSize() { }

	// RVA: 0x1637A8C
	private float MaxValue() { }

	// RVA: 0x1637A7C
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

	// RVA: 0x1637DB4
	private bool get_hasSelection() { }

	// RVA: 0x1637E70
	internal void set_revealCursor(bool value) { }

	// RVA: 0x1637EE4
	private int get_cursorIndex() { }

	// RVA: 0x1637FA8
	private void set_cursorIndex(int value) { }

	// RVA: 0x163801C
	private int get_selectIndex() { }

	// RVA: 0x16380E0
	private void set_selectIndex(int value) { }

	// RVA: 0x1638154
	public string get_text() { }

	// RVA: 0x163815C
	public void set_text(string value) { }

	// RVA: 0x1638200
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x1638270
	public bool UpdateImeState() { }

	// RVA: 0x1638548
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x1638550
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x163863C
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x16388E4
	public void EnableCursorPreviewState() { }

	// RVA: 0x1638850
	public void RestoreCursorState() { }

	// RVA: 0x1638A40
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x163A170
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x163D0AC
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x1638BD8
	private void InitKeyActions() { }

	// RVA: 0x163CB30
	public bool DeleteLineBack() { }

	// RVA: 0x163C85C
	public bool DeleteWordBack() { }

	// RVA: 0x163CE10
	public bool DeleteWordForward() { }

	// RVA: 0x163C1DC
	public bool Delete() { }

	// RVA: 0x163C478
	public bool Backspace() { }

	// RVA: 0x163D150
	public bool DeleteSelection() { }

	// RVA: 0x163834C
	public void ReplaceSelection(string replace) { }

	// RVA: 0x163DBE8
	public void Insert(Char c) { }

	// RVA: 0x163DC68
	public bool CanPaste() { }

	// RVA: 0x163C700
	public bool Cut() { }

	// RVA: 0x163C730
	public bool Paste() { }

	// RVA: 0x163DE0C
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x163DEA4
	internal void OnBlur() { }

	// RVA: 0x163DFF0
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

	// RVA: 0x163E094
	public string get_text() { }

	// RVA: 0x163E0B4
	public void set_text(string value) { }

	// RVA: 0x163E24C
	public Rect get_position() { }

	// RVA: 0x163E258
	public void set_position(Rect value) { }

	// RVA: 0x163E5D0
	internal virtual Rect get_localPosition() { }

	// RVA: 0x163E5DC
	public int get_cursorIndex() { }

	// RVA: 0x163E5E4
	public void set_cursorIndex(int value) { }

	// RVA: 0x163E698
	public int get_selectIndex() { }

	// RVA: 0x163E6A0
	public void set_selectIndex(int value) { }

	// RVA: 0x163E744
	private void ClearCursorPos() { }

	// RVA: 0x163E754
	public void .ctor() { }

	// RVA: 0x163E880
	public void OnFocus() { }

	// RVA: 0x163E968
	public void OnLostFocus() { }

	// RVA: 0x163E9C0
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x163EA54
	public bool HandleKeyEvent(Event e) { }

	// RVA: 0x163EA5C
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x16415C8
	public bool DeleteLineBack() { }

	// RVA: 0x1641878
	public bool DeleteWordBack() { }

	// RVA: 0x1641A3C
	public bool DeleteWordForward() { }

	// RVA: 0x1641CDC
	public bool Delete() { }

	// RVA: 0x1641EA4
	public bool Backspace() { }

	// RVA: 0x163E914
	public void SelectAll() { }

	// RVA: 0x1642044
	public void SelectNone() { }

	// RVA: 0x16416C4
	public bool get_hasSelection() { }

	// RVA: 0x16416D4
	public bool DeleteSelection() { }

	// RVA: 0x1642074
	public void ReplaceSelection(string replace) { }

	// RVA: 0x1642110
	public void Insert(Char c) { }

	// RVA: 0x1642190
	public void MoveRight() { }

	// RVA: 0x1642220
	public void MoveLeft() { }

	// RVA: 0x1642298
	public void MoveUp() { }

	// RVA: 0x1642358
	public void MoveDown() { }

	// RVA: 0x1642440
	public void MoveLineStart() { }

	// RVA: 0x16424C0
	public void MoveLineEnd() { }

	// RVA: 0x1642564
	public void MoveGraphicalLineStart() { }

	// RVA: 0x1642684
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x16427BC
	public void MoveTextStart() { }

	// RVA: 0x16427E8
	public void MoveTextEnd() { }

	// RVA: 0x1642834
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x16428A8
	public void MoveParagraphForward() { }

	// RVA: 0x1642930
	public void MoveParagraphBackward() { }

	// RVA: 0x16429B4
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1642A08
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x1642A9C
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1642F34
	public void SelectLeft() { }

	// RVA: 0x1642F90
	public void SelectRight() { }

	// RVA: 0x1642FEC
	public void SelectUp() { }

	// RVA: 0x1643054
	public void SelectDown() { }

	// RVA: 0x16430D8
	public void SelectTextEnd() { }

	// RVA: 0x1643114
	public void SelectTextStart() { }

	// RVA: 0x164311C
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x164312C
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x16425A8
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x16426C8
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x1643134
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x1643318
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x16433C4
	public void MoveWordRight() { }

	// RVA: 0x1643424
	public void MoveToStartOfNextWord() { }

	// RVA: 0x1643488
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x164351C
	public void SelectToStartOfNextWord() { }

	// RVA: 0x1643554
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x16431DC
	private CharacterType ClassifyChar(int index) { }

	// RVA: 0x1641B0C
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x164194C
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x164358C
	public void MoveWordLeft() { }

	// RVA: 0x16435D8
	public void SelectWordRight() { }

	// RVA: 0x1643698
	public void SelectWordLeft() { }

	// RVA: 0x1643740
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x16437A8
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1643810
	public void SelectGraphicalLineStart() { }

	// RVA: 0x1643848
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1643880
	public void SelectParagraphForward() { }

	// RVA: 0x164391C
	public void SelectParagraphBackward() { }

	// RVA: 0x16439E0
	public void SelectCurrentWord() { }

	// RVA: 0x1642D9C
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x1643A58
	public void SelectCurrentParagraph() { }

	// RVA: 0x1643B00
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0x163E310
	internal void UpdateScrollOffset() { }

	// RVA: 0x1643B60
	public void DrawCursor(string newText) { }

	// RVA: 0x1640E64
	private bool PerformOperation(TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x16440AC
	public void SaveBackup() { }

	// RVA: 0x1643EF8
	public bool Cut() { }

	// RVA: 0x1643F34
	public void Copy() { }

	// RVA: 0x16440F4
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x1643FF8
	public bool Paste() { }

	// RVA: 0x164418C
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x163EB88
	private void InitKeyActions() { }

	// RVA: 0x1642214
	public void DetectFocusChange() { }

	// RVA: 0x1644230
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x1644350
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x1644354
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x1644358
	private void ClampTextIndex(int index) { }

	// RVA: 0x163E1D4
	private void EnsureValidCodePointIndex(int index) { }

	// RVA: 0x16443A8
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x1641F80
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x1641DB8
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

	// RVA: 0x1637DD0
	public bool get_hasSelection() { }

	// RVA: 0x16444B0
	public bool get_revealCursor() { }

	// RVA: 0x1637EB8
	public void set_revealCursor(bool value) { }

	// RVA: 0x16444B8
	private int get_m_CharacterCount() { }

	// RVA: 0x16444E4
	private int get_characterCount() { }

	// RVA: 0x16445C8
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x1637F4C
	public int get_cursorIndex() { }

	// RVA: 0x1637FF0
	public void set_cursorIndex(int value) { }

	// RVA: 0x163DBC8
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x1638084
	public int get_selectIndex() { }

	// RVA: 0x1638128
	public void set_selectIndex(int value) { }

	// RVA: 0x163DBD0
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x1644650
	public string get_selectedText() { }

	// RVA: 0x1644944
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x1644998
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x16458A4
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x16474CC
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x1644ABC
	private void InitKeyActions() { }

	// RVA: 0x163DBD8
	public void ClearCursorPos() { }

	// RVA: 0x1647570
	public void OnFocus(bool selectAll) { }

	// RVA: 0x1647454
	public void SelectAll() { }

	// RVA: 0x163DF68
	public void SelectNone() { }

	// RVA: 0x1645DA4
	public void SelectLeft() { }

	// RVA: 0x1645F98
	public void SelectRight() { }

	// RVA: 0x164618C
	public void SelectUp() { }

	// RVA: 0x1646238
	public void SelectDown() { }

	// RVA: 0x1646A04
	public void SelectTextEnd() { }

	// RVA: 0x16469DC
	public void SelectTextStart() { }

	// RVA: 0x1646940
	public void SelectToStartOfNextWord() { }

	// RVA: 0x16468A4
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x16462E4
	public void SelectWordRight() { }

	// RVA: 0x16465C4
	public void SelectWordLeft() { }

	// RVA: 0x164731C
	public void SelectGraphicalLineStart() { }

	// RVA: 0x16473B8
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1646DE4
	public void SelectParagraphForward() { }

	// RVA: 0x164706C
	public void SelectParagraphBackward() { }

	// RVA: 0x16477E8
	public void SelectCurrentWord() { }

	// RVA: 0x1647AE4
	public void SelectCurrentParagraph() { }

	// RVA: 0x163A7E8
	public void MoveRight() { }

	// RVA: 0x163A588
	public void MoveLeft() { }

	// RVA: 0x163AA54
	public void MoveUp() { }

	// RVA: 0x163ACC4
	public void MoveDown() { }

	// RVA: 0x163AF44
	public void MoveLineStart() { }

	// RVA: 0x163B118
	public void MoveLineEnd() { }

	// RVA: 0x163BF3C
	public void MoveGraphicalLineStart() { }

	// RVA: 0x163C08C
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x163B9D8
	public void MoveTextStart() { }

	// RVA: 0x163BA44
	public void MoveTextEnd() { }

	// RVA: 0x163BAC0
	public void MoveParagraphForward() { }

	// RVA: 0x163BCF4
	public void MoveParagraphBackward() { }

	// RVA: 0x163B308
	public void MoveWordRight() { }

	// RVA: 0x163B518
	public void MoveToStartOfNextWord() { }

	// RVA: 0x163B680
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x163B7E8
	public void MoveWordLeft() { }

	// RVA: 0x1647E10
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1646A54
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1646C1C
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1647FC4
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x1647FCC
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x164809C
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1647CD0
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x1647D64
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x163D7AC
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x163D6A4
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1647994
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x164854C
	private int ClampTextIndex(int index) { }

	// RVA: 0x16445F4
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x164857C
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x1647798
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x163DAD4
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x163D9D8
	public int NextCodePointIndex(int index) { }

	// RVA: 0x164761C
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x16476D0
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x163DCEC
	public void Copy() { }

	// RVA: 0x16483C4
	private CharacterType ClassifyChar(int index) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Methods

	// RVA: 0x1648678
	internal static UInt32 ComputeStringHash(string s) { }

}


