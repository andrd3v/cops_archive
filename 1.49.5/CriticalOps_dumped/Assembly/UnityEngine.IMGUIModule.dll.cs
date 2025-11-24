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

	// RVA: 0x161F234
	public EventType get_rawType() { }

	// RVA: 0x161F284
	public Vector2 get_mousePosition() { }

	// RVA: 0x161F344
	public void set_mousePosition(Vector2 value) { }

	// RVA: 0x161F400
	public Vector2 get_delta() { }

	// RVA: 0x161F4C0
	public void set_delta(Vector2 value) { }

	// RVA: 0x161F57C
	public PointerType get_pointerType() { }

	// RVA: 0x161F5CC
	public int get_button() { }

	// RVA: 0x161F61C
	public EventModifiers get_modifiers() { }

	// RVA: 0x161F66C
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x161F6D4
	public float get_pressure() { }

	// RVA: 0x161F724
	public float get_twist() { }

	// RVA: 0x161F774
	public Vector2 get_tilt() { }

	// RVA: 0x161F834
	public PenStatus get_penStatus() { }

	// RVA: 0x161F884
	public int get_clickCount() { }

	// RVA: 0x161F8D4
	public Char get_character() { }

	// RVA: 0x161F924
	public void set_character(Char value) { }

	// RVA: 0x161F98C
	public KeyCode get_keyCode() { }

	// RVA: 0x161F9DC
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x161FA44
	public int get_displayIndex() { }

	// RVA: 0x161FA94
	public void set_displayIndex(int value) { }

	// RVA: 0x161FAFC
	public EventType get_type() { }

	// RVA: 0x161FB4C
	public void set_type(EventType value) { }

	// RVA: 0x161FBB4
	public string get_commandName() { }

	// RVA: 0x161FC04
	public void set_commandName(string value) { }

	// RVA: 0x161FC6C
	private void Internal_Use() { }

	// RVA: 0x161FCBC
	private static IntPtr Internal_Create(int displayIndex) { }

	// RVA: 0x161FD0C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x161FD5C
	public EventType GetTypeForControl(int controlID) { }

	// RVA: 0x161FDC4
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x161FE2C
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x161FE7C
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	// RVA: 0x161FECC
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x162007C
	internal static int GetDoubleClickTime() { }

	// RVA: 0x16200BC
	public void .ctor() { }

	// RVA: 0x1620020
	public void .ctor(int displayIndex) { }

	// RVA: 0x1620124
	protected override void Finalize() { }

	// RVA: 0x1620200
	internal void CopyFrom(Event e) { }

	// RVA: 0x1620298
	public bool get_shift() { }

	// RVA: 0x16202F8
	public bool get_control() { }

	// RVA: 0x1620358
	public bool get_alt() { }

	// RVA: 0x16203B8
	public bool get_command() { }

	// RVA: 0x1620418
	public static Event get_current() { }

	// RVA: 0x1620464
	public static void set_current(Event value) { }

	// RVA: 0x1620524
	public bool get_isKey() { }

	// RVA: 0x1620574
	public bool get_isMouse() { }

	// RVA: 0x1620600
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x1620698
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x1622428
	public override int GetHashCode() { }

	// RVA: 0x16225A8
	public override bool Equals(object obj) { }

	// RVA: 0x1622900
	public override string ToString() { }

	// RVA: 0x1623208
	public void Use() { }

	// RVA: 0x161F2DC
	private void get_mousePosition_Injected(Vector2 ret) { }

	// RVA: 0x161F398
	private void set_mousePosition_Injected(Vector2 value) { }

	// RVA: 0x161F458
	private void get_delta_Injected(Vector2 ret) { }

	// RVA: 0x161F514
	private void set_delta_Injected(Vector2 value) { }

	// RVA: 0x161F7CC
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

	// RVA: 0x1623424
	public bool get_wantsMouseMove() { }

	// RVA: 0x162342C
	public void set_wantsMouseMove(bool value) { }

	// RVA: 0x1623434
	public bool get_wantsMouseEnterLeaveWindow() { }

	// RVA: 0x162343C
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	// RVA: 0x1623444
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x162344C
	public bool WantsEvent(EventType type) { }

	// RVA: 0x162347C
	public bool WantsLayoutPass(EventType type) { }

}

// Namespace: 
public sealed class WindowFunction
{
	// Methods

	// RVA: 0x16312CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1631370
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

	// RVA: 0x1623604
	public static Color get_color() { }

	// RVA: 0x1623700
	public static void set_color(Color value) { }

	// RVA: 0x1623808
	public static Color get_backgroundColor() { }

	// RVA: 0x1623904
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x1623A0C
	public static Color get_contentColor() { }

	// RVA: 0x1623B08
	public static void set_contentColor(Color value) { }

	// RVA: 0x1623C10
	public static bool get_changed() { }

	// RVA: 0x1623C50
	public static void set_changed(bool value) { }

	// RVA: 0x1623CA0
	public static bool get_enabled() { }

	// RVA: 0x1623CE0
	public static void set_enabled(bool value) { }

	// RVA: 0x1623D30
	internal static bool get_usePageScrollbars() { }

	// RVA: 0x1623D70
	internal static Material get_blendMaterial() { }

	// RVA: 0x1623DB0
	internal static Material get_blitMaterial() { }

	// RVA: 0x1623DF0
	internal static Material get_roundedRectMaterial() { }

	// RVA: 0x1623E30
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x1623E70
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x1623EC0
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x1623F10
	internal static void ReleaseMouseControl() { }

	// RVA: 0x1623F50
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x1623F90
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x1624144
	private static void .cctor() { }

	// RVA: 0x1624424
	internal static int get_scrollTroughSide() { }

	// RVA: 0x16244A0
	internal static void set_scrollTroughSide(int value) { }

	// RVA: 0x162452C
	internal static DateTime get_nextScrollStepTime() { }

	// RVA: 0x16245A8
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1624634
	public static void set_skin(GUISkin value) { }

	// RVA: 0x16249C8
	public static GUISkin get_skin() { }

	// RVA: 0x16247D8
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x1624C60
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1624D38
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1624DF8
	public static void Label(Rect position, string text) { }

	// RVA: 0x1625070
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x16255B8
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x16256F4
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x16257EC
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x1625898
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x1625A80
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x1625BAC
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x1625D98
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x1625EFC
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1626048
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x1626860
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, Rect outScreenRect, Rect outSourceRect) { }

	// RVA: 0x1626954
	public static void Box(Rect position, string text) { }

	// RVA: 0x1626A6C
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1626FA8
	public static bool Button(Rect position, string text) { }

	// RVA: 0x1627250
	public static bool Button(Rect position, GUIContent content) { }

	// RVA: 0x16270C0
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1627428
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x1627690
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x1627ECC
	internal static string PasswordFieldGetStrToShow(string password, Char maskChar) { }

	// RVA: 0x162805C
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x162817C
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x1628248
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar) { }

	// RVA: 0x1628D44
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, Char maskChar, TextEditor editor) { }

	// RVA: 0x16295A0
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x1628788
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x162A878
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x1625158
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x1627520
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x162B20C
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x162B2DC
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x162B4A0
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x162C280
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x162C644
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x162BC60
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x162CB34
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x162CC10
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x162D39C
	public static void EndGroup() { }

	// RVA: 0x162D474
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x162D4F0
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x162EE44
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x162FDEC
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text) { }

	// RVA: 0x1630228
	public static Rect Window(int id, Rect clientRect, WindowFunction func, string text, GUIStyle style) { }

	// RVA: 0x163005C
	private static Rect DoWindow(int id, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	// RVA: 0x1630408
	internal static void CallWindowDelegate(WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x16236B0
	private static void get_color_Injected(Color ret) { }

	// RVA: 0x16237B8
	private static void set_color_Injected(Color value) { }

	// RVA: 0x16238B4
	private static void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x16239BC
	private static void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x1623AB8
	private static void get_contentColor_Injected(Color ret) { }

	// RVA: 0x1623BC0
	private static void set_contentColor_Injected(Color value) { }

	// RVA: 0x16240A4
	private static void Internal_DoWindow_Injected(int id, int instanceID, Rect clientRect, WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, Rect ret) { }

}

// Namespace: 
internal struct ParentClipScope
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x163180C
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x1631888
	public void Dispose() { }

}

// Namespace: UnityEngine
internal sealed class GUIClip
{
	// Methods

	// RVA: 0x162B0B4
	internal static Rect get_visibleRect() { }

	// RVA: 0x16313D4
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x162D434
	internal static void Internal_Pop() { }

	// RVA: 0x16314A4
	internal static int Internal_GetCount() { }

	// RVA: 0x16314E4
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x1624CD0
	internal static Matrix4x4 GetMatrix() { }

	// RVA: 0x1624DA8
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x1631644
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x16316B4
	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	// RVA: 0x1631774
	internal static void Internal_PopParentClip() { }

	// RVA: 0x162D334
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x162FDAC
	internal static void Pop() { }

	// RVA: 0x16317B4
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x1631384
	private static void get_visibleRect_Injected(Rect ret) { }

	// RVA: 0x163143C
	private static void Internal_Push_Injected(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x163153C
	private static void UnclipToWindow_Vector2_Injected(Vector2 pos, Vector2 ret) { }

	// RVA: 0x16315A4
	private static void GetMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x16315F4
	private static void SetMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x163171C
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

	// RVA: 0x1628680
	public string get_text() { }

	// RVA: 0x1628688
	public void set_text(string value) { }

	// RVA: 0x16318E4
	public void set_image(Texture value) { }

	// RVA: 0x162B0AC
	public string get_tooltip() { }

	// RVA: 0x16318EC
	public void set_tooltip(string value) { }

	// RVA: 0x16318F4
	public void .ctor() { }

	// RVA: 0x1631978
	public void .ctor(string text) { }

	// RVA: 0x16319E0
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x1631ADC
	public void .ctor(GUIContent src) { }

	// RVA: 0x1624F8C
	internal static GUIContent Temp(string t) { }

	// RVA: 0x1631BDC
	internal static void ClearStaticCache() { }

	// RVA: 0x1631D14
	public override string ToString() { }

	// RVA: 0x1631D34
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

	// RVA: 0x1631F70
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x16322AC
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16320E8
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16323A0
	public static bool Button(string text, GUILayoutOption[] options) { }

	// RVA: 0x1632650
	public static bool Button(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1632518
	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16326CC
	public static string TextField(string text, GUILayoutOption[] options) { }

	// RVA: 0x1632C64
	public static string TextField(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1632804
	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1632D60
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x1632F48
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x1633154
	public static void Space(float pixels) { }

	// RVA: 0x16337B4
	public static void FlexibleSpace() { }

	// RVA: 0x1633D10
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x1633DD8
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1634370
	public static void EndHorizontal() { }

	// RVA: 0x16346E4
	public static void BeginVertical(GUILayoutOption[] options) { }

	// RVA: 0x16347AC
	public static void BeginVertical(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1634980
	public static void EndVertical() { }

	// RVA: 0x16349E8
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x1634D70
	public static void BeginArea(Rect screenRect, GUIStyle style) { }

	// RVA: 0x1634AD0
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x16351A4
	public static void EndArea() { }

	// RVA: 0x16355B8
	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUILayoutOption[] options) { }

	// RVA: 0x1635830
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x1635AFC
	public static void EndScrollView() { }

	// RVA: 0x1635BAC
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x1630BD8
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1635C6C
	public static GUILayoutOption MinWidth(float minWidth) { }

	// RVA: 0x1635D20
	public static GUILayoutOption MaxWidth(float maxWidth) { }

	// RVA: 0x1630C88
	public static GUILayoutOption Height(float height) { }

	// RVA: 0x1635DD4
	public static GUILayoutOption MinHeight(float minHeight) { }

	// RVA: 0x1633C20
	public static GUILayoutOption ExpandWidth(bool expand) { }

	// RVA: 0x1633B74
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

	// RVA: 0x1633CCC
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

	// RVA: 0x1638174
	private void set_id(int value) { }

	// RVA: 0x1636298
	internal void .ctor(int instanceID) { }

	// RVA: 0x163817C
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

	// RVA: 0x1635E88
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1635FAC
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x16360C8
	internal static int get_unbalancedgroupscount() { }

	// RVA: 0x1636144
	internal static void set_unbalancedgroupscount(int value) { }

	// RVA: 0x16361D0
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x1630A20
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x16363A4
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x1636490
	internal static void Begin(int instanceID) { }

	// RVA: 0x16366E4
	internal static void BeginContainer(LayoutCache cache) { }

	// RVA: 0x1630D3C
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1631048
	internal static void Layout() { }

	// RVA: 0x1636E40
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x1637080
	internal static void LayoutFromContainer(float w, float h) { }

	// RVA: 0x1636964
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1636BB0
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1637228
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x1633FA8
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x16343D8
	internal static void EndLayoutGroup() { }

	// RVA: 0x1634E0C
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x16353AC
	internal static void EndLayoutArea() { }

	// RVA: 0x1637488
	public static Rect GetRect(GUIContent content, GUIStyle style) { }

	// RVA: 0x1632328
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x16374F4
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x163372C
	public static Rect GetRect(float width, float height, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1637BE8
	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1637DFC
	public static Rect GetLastRect() { }

	// RVA: 0x1633550
	internal static GUIStyle get_spaceStyle() { }

	// RVA: 0x1638054
	private static void .cctor() { }

	// RVA: 0x1635F44
	private static void Internal_GetWindowRect_Injected(int windowID, Rect ret) { }

	// RVA: 0x1636060
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

	// RVA: 0x1638460
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x162A780
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x162A788
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x16384A0
	public Color get_cursorColor() { }

	// RVA: 0x16384AC
	public float get_cursorFlashSpeed() { }

	// RVA: 0x1638504
	public Color get_selectionColor() { }

	// RVA: 0x1638510
	public void set_selectionColor(Color value) { }

	// RVA: 0x163851C
	public void .ctor() { }

}

// Namespace: 
internal sealed class SkinChangedDelegate
{
	// Methods

	// RVA: 0x163BEB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x163BF54
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

	// RVA: 0x1638548
	public void .ctor() { }

	// RVA: 0x1638624
	internal void OnEnable() { }

	// RVA: 0x1638754
	internal static void CleanupRoots() { }

	// RVA: 0x162A7E0
	public Font get_font() { }

	// RVA: 0x16387C0
	public void set_font(Font value) { }

	// RVA: 0x1626A64
	public GUIStyle get_box() { }

	// RVA: 0x16389D8
	public void set_box(GUIStyle value) { }

	// RVA: 0x1625068
	public GUIStyle get_label() { }

	// RVA: 0x1638A78
	public void set_label(GUIStyle value) { }

	// RVA: 0x16327FC
	public GUIStyle get_textField() { }

	// RVA: 0x1638B18
	public void set_textField(GUIStyle value) { }

	// RVA: 0x1638BB8
	public GUIStyle get_textArea() { }

	// RVA: 0x1638BC0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x16270B8
	public GUIStyle get_button() { }

	// RVA: 0x1638C60
	public void set_button(GUIStyle value) { }

	// RVA: 0x1638D00
	public GUIStyle get_toggle() { }

	// RVA: 0x1638D08
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1630054
	public GUIStyle get_window() { }

	// RVA: 0x1638DA8
	public void set_window(GUIStyle value) { }

	// RVA: 0x1632F38
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1638E48
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x1632F40
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1638EE8
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1638F88
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1638F90
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1639030
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x1639038
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x16390D8
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x16390E0
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1639180
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1639188
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1639228
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1639230
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1635818
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x16392D0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1639370
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1639378
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1639418
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1639420
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x16394C0
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x16394C8
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1635820
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1639568
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1639608
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1639610
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x16396B0
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x16396B8
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1639758
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1639760
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1635828
	public GUIStyle get_scrollView() { }

	// RVA: 0x1639800
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x16398A0
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x16398A8
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x162A778
	public GUISettings get_settings() { }

	// RVA: 0x163995C
	internal static GUIStyle get_error() { }

	// RVA: 0x16386BC
	internal void Apply() { }

	// RVA: 0x1639B74
	private void BuildStyleCache() { }

	// RVA: 0x162B974
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x163BD5C
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1624B60
	internal void MakeCurrent() { }

	// RVA: 0x163BDF0
	public IEnumerator GetEnumerator() { }

}

// Namespace: UnityEngine
internal class GUIStateObjects
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,System.Object> s_StateCache; // 0x0

	// Methods

	// RVA: 0x163BF68
	internal static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x163C108
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

	// RVA: 0x163C1A4
	public void set_background(Texture2D value) { }

	// RVA: 0x163BD04
	public void set_textColor(Color value) { }

	// RVA: 0x163C274
	private static IntPtr Init() { }

	// RVA: 0x163C2B4
	private void Cleanup() { }

	// RVA: 0x163C304
	public void .ctor() { }

	// RVA: 0x163C360
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x163C3A8
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x163C424
	protected override void Finalize() { }

	// RVA: 0x163C20C
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

	// RVA: 0x163C4EC
	internal string get_rawName() { }

	// RVA: 0x163C53C
	internal void set_rawName(string value) { }

	// RVA: 0x162A790
	public Font get_font() { }

	// RVA: 0x163C5A4
	public ImagePosition get_imagePosition() { }

	// RVA: 0x163C5F4
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x163C65C
	public bool get_wordWrap() { }

	// RVA: 0x163C6AC
	public Vector2 get_contentOffset() { }

	// RVA: 0x163C76C
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x162CA94
	public float get_fixedWidth() { }

	// RVA: 0x163C828
	public void set_fixedWidth(float value) { }

	// RVA: 0x162CAE4
	public float get_fixedHeight() { }

	// RVA: 0x163C890
	public bool get_stretchWidth() { }

	// RVA: 0x1637FEC
	public void set_stretchWidth(bool value) { }

	// RVA: 0x163C8E0
	public bool get_stretchHeight() { }

	// RVA: 0x163BBB8
	public void set_stretchHeight(bool value) { }

	// RVA: 0x163C930
	public void set_fontSize(int value) { }

	// RVA: 0x163C998
	internal void set_Internal_clipOffset(Vector2 value) { }

	// RVA: 0x163CA54
	private static IntPtr Internal_Create(GUIStyle self) { }

	// RVA: 0x163CAA4
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	// RVA: 0x163CB0C
	private static void Internal_Destroy(IntPtr self) { }

	// RVA: 0x163CB5C
	private IntPtr GetStyleStatePtr(int idx) { }

	// RVA: 0x163CBC4
	private IntPtr GetRectOffsetPtr(int idx) { }

	// RVA: 0x163CC2C
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	// RVA: 0x163CC84
	private static float Internal_GetLineHeight(IntPtr target) { }

	// RVA: 0x163CCD4
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x163CDF4
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x163CEE4
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x163CFD0
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x163D148
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x163D234
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x163D30C
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x163D3FC
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	// RVA: 0x163D4BC
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	// RVA: 0x163D594
	private float Internal_CalcHeight(GUIContent content, float width) { }

	// RVA: 0x163D5F4
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	// RVA: 0x162B158
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	// RVA: 0x162B108
	internal static bool IsTooltipActive(string tooltip) { }

	// RVA: 0x163D71C
	private static float Internal_GetCursorFlashOffset() { }

	// RVA: 0x1638988
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x1637F30
	public void .ctor() { }

	// RVA: 0x163D75C
	public void .ctor(GUIStyle other) { }

	// RVA: 0x163D87C
	protected override void Finalize() { }

	// RVA: 0x162B8F0
	public string get_name() { }

	// RVA: 0x1639B04
	public void set_name(string value) { }

	// RVA: 0x163BC20
	public GUIStyleState get_normal() { }

	// RVA: 0x162EC74
	public RectOffset get_margin() { }

	// RVA: 0x163D994
	public RectOffset get_padding() { }

	// RVA: 0x163DA6C
	public void set_padding(RectOffset value) { }

	// RVA: 0x163DAC8
	public float get_lineHeight() { }

	// RVA: 0x162ED4C
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x162B014
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x162D20C
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x162A690
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x1626DC4
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x163DC28
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x163DEA4
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x163E27C
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x163E6B0
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x163E9C0
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x162D0A0
	public static GUIStyle get_none() { }

	// RVA: 0x163E9C8
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x163EA44
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x163EAB4
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x1637A7C
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x163EB1C
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x163799C
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x163EB7C
	public void CalcMinMaxWidth(GUIContent content, float minWidth, float maxWidth) { }

	// RVA: 0x163EBFC
	public override string ToString() { }

	// RVA: 0x163ED08
	private static void .cctor() { }

	// RVA: 0x163C704
	private void get_contentOffset_Injected(Vector2 ret) { }

	// RVA: 0x163C7C0
	private void set_contentOffset_Injected(Vector2 value) { }

	// RVA: 0x163C9EC
	private void set_Internal_clipOffset_Injected(Vector2 value) { }

	// RVA: 0x163CD6C
	private void Internal_Draw_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x163CE74
	private void Internal_Draw2_Injected(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x163CF60
	private void Internal_DrawCursor_Injected(Rect position, GUIContent content, int pos, Color cursorColor) { }

	// RVA: 0x163D0A0
	private void Internal_DrawWithTextSelection_Injected(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	// RVA: 0x163D1C4
	private void Internal_GetCursorPixelPosition_Injected(Rect position, GUIContent content, int cursorStringIndex, Vector2 ret) { }

	// RVA: 0x163D2A4
	private int Internal_GetCursorStringIndex_Injected(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x163D38C
	private string Internal_GetSelectedRenderedText_Injected(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x163D464
	private void Internal_CalcSize_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x163D52C
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, Vector2 maxSize, Vector2 ret) { }

	// RVA: 0x163D65C
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, Vector2 ret) { }

	// RVA: 0x163D6B4
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

	// RVA: 0x163ED58
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

	// RVA: 0x1636924
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x163EF08
	internal static int get_guiDepth() { }

	// RVA: 0x162D2E4
	internal static void set_mouseUsed(bool value) { }

	// RVA: 0x16235C4
	internal static bool get_textFieldInput() { }

	// RVA: 0x162A828
	internal static void set_textFieldInput(bool value) { }

	// RVA: 0x163EF48
	public static string get_systemCopyBuffer() { }

	// RVA: 0x163EF88
	public static void set_systemCopyBuffer(string value) { }

	// RVA: 0x163EFD8
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x1627310
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x163F0EC
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	// RVA: 0x163F13C
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	// RVA: 0x163F18C
	internal static void Internal_EndContainer() { }

	// RVA: 0x163F1CC
	internal static int CheckForTabEvent(Event evt) { }

	// RVA: 0x163F21C
	internal static void SetKeyboardControlToFirstControlId() { }

	// RVA: 0x163F25C
	internal static void SetKeyboardControlToLastControlId() { }

	// RVA: 0x163F29C
	internal static bool HasFocusableControls() { }

	// RVA: 0x163F2DC
	internal static bool OwnsId(int id) { }

	// RVA: 0x163F32C
	public static Rect AlignRectToDevice(Rect rect, int widthInPixels, int heightInPixels) { }

	// RVA: 0x162A7E8
	internal static string get_compositionString() { }

	// RVA: 0x163F464
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x163F4B4
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x163F5B8
	private static int Internal_GetHotControl() { }

	// RVA: 0x163F5F8
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x163F638
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x163F688
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x163F6D8
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x163F728
	private static void Internal_ExitGUI() { }

	// RVA: 0x163F768
	private static void MarkGUIChanged() { }

	// RVA: 0x1632C78
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x1626D24
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x16286FC
	public static object GetStateObject(Type t, int controlID) { }

	// RVA: 0x163F7F8
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x1627E3C
	public static int get_hotControl() { }

	// RVA: 0x1627D90
	public static void set_hotControl(int value) { }

	// RVA: 0x163F884
	internal static void TakeCapture() { }

	// RVA: 0x163F914
	internal static void RemoveCapture() { }

	// RVA: 0x162A554
	public static int get_keyboardControl() { }

	// RVA: 0x162A5E4
	public static void set_keyboardControl(int value) { }

	// RVA: 0x163DD10
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x163F9A4
	public static void ExitGUI() { }

	// RVA: 0x1624A84
	internal static GUISkin GetDefaultSkin() { }

	// RVA: 0x163FAF4
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool result) { }

	// RVA: 0x163FD0C
	internal static void EndContainer() { }

	// RVA: 0x163FDCC
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	// RVA: 0x16400EC
	internal static void DestroyGUI(int instanceID) { }

	// RVA: 0x1640174
	internal static void EndGUI(int layoutType) { }

	// RVA: 0x16403A4
	internal static bool EndGUIFromException(Exception exception) { }

	// RVA: 0x164061C
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x163FEBC
	internal static void ResetGlobalState() { }

	// RVA: 0x1640704
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x164051C
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x16246F4
	internal static void CheckOnGUI() { }

	// RVA: 0x16407A0
	internal static float RoundToPixelGrid(float v) { }

	// RVA: 0x1640884
	public static Rect AlignRectToDevice(Rect rect) { }

	// RVA: 0x16409BC
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x1640A08
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x162AE30
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x1640AEC
	private static void .cctor() { }

	// RVA: 0x163F094
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x163F3FC
	private static void AlignRectToDevice_Injected(Rect rect, int widthInPixels, int heightInPixels, Rect ret) { }

	// RVA: 0x163F568
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class ExitGUIException
{
	// Methods

	// RVA: 0x163F9E0
	public void .ctor() { }

	// RVA: 0x1637398
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

	// RVA: 0x1640BA4
	public GUIStyle get_style() { }

	// RVA: 0x16368EC
	public void set_style(GUIStyle value) { }

	// RVA: 0x1640BAC
	public virtual int get_marginLeft() { }

	// RVA: 0x1640C74
	public virtual int get_marginRight() { }

	// RVA: 0x1640D3C
	public virtual int get_marginTop() { }

	// RVA: 0x1640E04
	public virtual int get_marginBottom() { }

	// RVA: 0x1640ECC
	public int get_marginHorizontal() { }

	// RVA: 0x1640F0C
	public int get_marginVertical() { }

	// RVA: 0x1640F4C
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1637AEC
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x1641040
	public virtual void CalcWidth() { }

	// RVA: 0x1641044
	public virtual void CalcHeight() { }

	// RVA: 0x1641048
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1641054
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1641060
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1641188
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1641478
	public override string ToString() { }

	// RVA: 0x1641A38
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

	// RVA: 0x1641A90
	public void .ctor(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	// RVA: 0x1641B7C
	public override void CalcWidth() { }

	// RVA: 0x1641C24
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

	// RVA: 0x1641C9C
	public override int get_marginLeft() { }

	// RVA: 0x1641CA4
	public override int get_marginRight() { }

	// RVA: 0x1641CAC
	public override int get_marginTop() { }

	// RVA: 0x1641CB4
	public override int get_marginBottom() { }

	// RVA: 0x1641CBC
	public void .ctor() { }

	// RVA: 0x1641E04
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1641F24
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1641FA4
	public void ResetCursor() { }

	// RVA: 0x1641FAC
	public GUILayoutEntry GetNext() { }

	// RVA: 0x1642268
	public Rect GetLast() { }

	// RVA: 0x1642594
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x16425F8
	public override void CalcWidth() { }

	// RVA: 0x1642D74
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x16437F4
	public override void CalcHeight() { }

	// RVA: 0x1643EF8
	public override void SetVertical(float y, float height) { }

	// RVA: 0x164498C
	public override string ToString() { }

	// RVA: 0x1644DC8
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

	// RVA: 0x1644EA8
	public void .ctor() { }

	// RVA: 0x1644F38
	public override void CalcWidth() { }

	// RVA: 0x1644FB4
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x16450B0
	public override void CalcHeight() { }

	// RVA: 0x1645188
	public override void SetVertical(float y, float height) { }

}

// Namespace: UnityEngine
internal class ObjectGUIState
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1645310
	public void .ctor() { }

	// RVA: 0x16453AC
	public void Dispose() { }

	// RVA: 0x16454E0
	protected override void Finalize() { }

	// RVA: 0x1645478
	private void Destroy() { }

	// RVA: 0x164536C
	private static IntPtr Internal_Create() { }

	// RVA: 0x16455BC
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

	// RVA: 0x164560C
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

	// RVA: 0x1645614
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

	// RVA: 0x164561C
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x1645698
	public float Handle() { }

	// RVA: 0x164577C
	private float OnMouseDown() { }

	// RVA: 0x1645C60
	private float OnMouseDrag() { }

	// RVA: 0x1645DF0
	private float OnMouseUp() { }

	// RVA: 0x1645ECC
	private float OnRepaint() { }

	// RVA: 0x1645748
	private EventType CurrentEventType() { }

	// RVA: 0x1646850
	private int CurrentScrollTroughSide() { }

	// RVA: 0x16465E8
	private bool IsEmptySlider() { }

	// RVA: 0x16466B0
	private bool SupportsPageMovements() { }

	// RVA: 0x16468DC
	private float PageMovementValue() { }

	// RVA: 0x1646C94
	private float PageUpMovementBound() { }

	// RVA: 0x16465E0
	private Event CurrentEvent() { }

	// RVA: 0x16469D8
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x1646AB4
	private float Clamp(float value) { }

	// RVA: 0x1646580
	private Rect ThumbSelectionRect() { }

	// RVA: 0x1646624
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x1646734
	private SliderState SliderState() { }

	// RVA: 0x1646BEC
	private Rect ThumbExtRect() { }

	// RVA: 0x1646C84
	private Rect ThumbRect() { }

	// RVA: 0x1646D14
	private Rect VerticalThumbRect() { }

	// RVA: 0x1646E38
	private Rect HorizontalThumbRect() { }

	// RVA: 0x16465F8
	private float ClampedCurrentValue() { }

	// RVA: 0x1646AE0
	private float MousePosition() { }

	// RVA: 0x1646B44
	private float ValuesPerPixel() { }

	// RVA: 0x1646F5C
	private float ThumbSize() { }

	// RVA: 0x1646CFC
	private float MaxValue() { }

	// RVA: 0x1646CEC
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

	// RVA: 0x1647024
	private bool get_hasSelection() { }

	// RVA: 0x16470E0
	internal void set_revealCursor(bool value) { }

	// RVA: 0x1647154
	private int get_cursorIndex() { }

	// RVA: 0x1647218
	private void set_cursorIndex(int value) { }

	// RVA: 0x164728C
	private int get_selectIndex() { }

	// RVA: 0x1647350
	private void set_selectIndex(int value) { }

	// RVA: 0x16473C4
	public string get_text() { }

	// RVA: 0x16473CC
	public void set_text(string value) { }

	// RVA: 0x1647470
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }

	// RVA: 0x16474E0
	public bool UpdateImeState() { }

	// RVA: 0x16477B8
	public bool ShouldUpdateImeWindowPosition() { }

	// RVA: 0x16477C0
	public void SetImeWindowPosition(Vector2 worldPosition) { }

	// RVA: 0x16478AC
	public string GeneratePreviewString(bool richText) { }

	// RVA: 0x1647B54
	public void EnableCursorPreviewState() { }

	// RVA: 0x1647AC0
	public void RestoreCursorState() { }

	// RVA: 0x1647CB0
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x16493E0
	private void PerformOperation(TextEditOp operation) { }

	// RVA: 0x164C31C
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x1647E48
	private void InitKeyActions() { }

	// RVA: 0x164BDA0
	public bool DeleteLineBack() { }

	// RVA: 0x164BACC
	public bool DeleteWordBack() { }

	// RVA: 0x164C080
	public bool DeleteWordForward() { }

	// RVA: 0x164B44C
	public bool Delete() { }

	// RVA: 0x164B6E8
	public bool Backspace() { }

	// RVA: 0x164C3C0
	public bool DeleteSelection() { }

	// RVA: 0x16475BC
	public void ReplaceSelection(string replace) { }

	// RVA: 0x164CE58
	public void Insert(Char c) { }

	// RVA: 0x164CED8
	public bool CanPaste() { }

	// RVA: 0x164B970
	public bool Cut() { }

	// RVA: 0x164B9A0
	public bool Paste() { }

	// RVA: 0x164D07C
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x164D114
	internal void OnBlur() { }

	// RVA: 0x164D260
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

	// RVA: 0x164D304
	public string get_text() { }

	// RVA: 0x164D324
	public void set_text(string value) { }

	// RVA: 0x164D4BC
	public Rect get_position() { }

	// RVA: 0x164D4C8
	public void set_position(Rect value) { }

	// RVA: 0x164D840
	internal virtual Rect get_localPosition() { }

	// RVA: 0x164D84C
	public int get_cursorIndex() { }

	// RVA: 0x164D854
	public void set_cursorIndex(int value) { }

	// RVA: 0x164D908
	public int get_selectIndex() { }

	// RVA: 0x164D910
	public void set_selectIndex(int value) { }

	// RVA: 0x164D9B4
	private void ClearCursorPos() { }

	// RVA: 0x164D9C4
	public void .ctor() { }

	// RVA: 0x164DAF0
	public void OnFocus() { }

	// RVA: 0x164DBD8
	public void OnLostFocus() { }

	// RVA: 0x164DC30
	private void GrabGraphicalCursorPos() { }

	// RVA: 0x164DCC4
	public bool HandleKeyEvent(Event e) { }

	// RVA: 0x164DCCC
	internal bool HandleKeyEvent(Event e, bool textIsReadOnly) { }

	// RVA: 0x1650838
	public bool DeleteLineBack() { }

	// RVA: 0x1650AE8
	public bool DeleteWordBack() { }

	// RVA: 0x1650CAC
	public bool DeleteWordForward() { }

	// RVA: 0x1650F4C
	public bool Delete() { }

	// RVA: 0x1651114
	public bool Backspace() { }

	// RVA: 0x164DB84
	public void SelectAll() { }

	// RVA: 0x16512B4
	public void SelectNone() { }

	// RVA: 0x1650934
	public bool get_hasSelection() { }

	// RVA: 0x1650944
	public bool DeleteSelection() { }

	// RVA: 0x16512E4
	public void ReplaceSelection(string replace) { }

	// RVA: 0x1651380
	public void Insert(Char c) { }

	// RVA: 0x1651400
	public void MoveRight() { }

	// RVA: 0x1651490
	public void MoveLeft() { }

	// RVA: 0x1651508
	public void MoveUp() { }

	// RVA: 0x16515C8
	public void MoveDown() { }

	// RVA: 0x16516B0
	public void MoveLineStart() { }

	// RVA: 0x1651730
	public void MoveLineEnd() { }

	// RVA: 0x16517D4
	public void MoveGraphicalLineStart() { }

	// RVA: 0x16518F4
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x1651A2C
	public void MoveTextStart() { }

	// RVA: 0x1651A58
	public void MoveTextEnd() { }

	// RVA: 0x1651AA4
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x1651B18
	public void MoveParagraphForward() { }

	// RVA: 0x1651BA0
	public void MoveParagraphBackward() { }

	// RVA: 0x1651C24
	public void MoveCursorToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1651C78
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x1651D0C
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x16521A4
	public void SelectLeft() { }

	// RVA: 0x1652200
	public void SelectRight() { }

	// RVA: 0x165225C
	public void SelectUp() { }

	// RVA: 0x16522C4
	public void SelectDown() { }

	// RVA: 0x1652348
	public void SelectTextEnd() { }

	// RVA: 0x1652384
	public void SelectTextStart() { }

	// RVA: 0x165238C
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x165239C
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x1651818
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x1651938
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x16523A4
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x1652588
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x1652634
	public void MoveWordRight() { }

	// RVA: 0x1652694
	public void MoveToStartOfNextWord() { }

	// RVA: 0x16526F8
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x165278C
	public void SelectToStartOfNextWord() { }

	// RVA: 0x16527C4
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x165244C
	private CharacterType ClassifyChar(int index) { }

	// RVA: 0x1650D7C
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x1650BBC
	private int FindEndOfPreviousWord(int p) { }

	// RVA: 0x16527FC
	public void MoveWordLeft() { }

	// RVA: 0x1652848
	public void SelectWordRight() { }

	// RVA: 0x1652908
	public void SelectWordLeft() { }

	// RVA: 0x16529B0
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1652A18
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1652A80
	public void SelectGraphicalLineStart() { }

	// RVA: 0x1652AB8
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1652AF0
	public void SelectParagraphForward() { }

	// RVA: 0x1652B8C
	public void SelectParagraphBackward() { }

	// RVA: 0x1652C50
	public void SelectCurrentWord() { }

	// RVA: 0x165200C
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x1652CC8
	public void SelectCurrentParagraph() { }

	// RVA: 0x1652D70
	public void UpdateScrollOffsetIfNeeded(Event evt) { }

	// RVA: 0x164D580
	internal void UpdateScrollOffset() { }

	// RVA: 0x1652DD0
	public void DrawCursor(string newText) { }

	// RVA: 0x16500D4
	private bool PerformOperation(TextEditOp operation, bool textIsReadOnly) { }

	// RVA: 0x165331C
	public void SaveBackup() { }

	// RVA: 0x1653168
	public bool Cut() { }

	// RVA: 0x16531A4
	public void Copy() { }

	// RVA: 0x1653364
	private static string ReplaceNewlinesWithSpaces(string value) { }

	// RVA: 0x1653268
	public bool Paste() { }

	// RVA: 0x16533FC
	private static void MapKey(string key, TextEditOp action) { }

	// RVA: 0x164DDF8
	private void InitKeyActions() { }

	// RVA: 0x1651484
	public void DetectFocusChange() { }

	// RVA: 0x16534A0
	internal virtual void OnDetectFocusChange() { }

	// RVA: 0x16535C0
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x16535C4
	internal virtual void OnSelectIndexChange() { }

	// RVA: 0x16535C8
	private void ClampTextIndex(int index) { }

	// RVA: 0x164D444
	private void EnsureValidCodePointIndex(int index) { }

	// RVA: 0x1653618
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x16511F0
	private int PreviousCodePointIndex(int index) { }

	// RVA: 0x1651028
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

	// RVA: 0x1647040
	public bool get_hasSelection() { }

	// RVA: 0x1653720
	public bool get_revealCursor() { }

	// RVA: 0x1647128
	public void set_revealCursor(bool value) { }

	// RVA: 0x1653728
	private int get_m_CharacterCount() { }

	// RVA: 0x1653754
	private int get_characterCount() { }

	// RVA: 0x1653838
	private TextElementInfo[] get_m_TextElementInfos() { }

	// RVA: 0x16471BC
	public int get_cursorIndex() { }

	// RVA: 0x1647260
	public void set_cursorIndex(int value) { }

	// RVA: 0x164CE38
	internal void SetCursorIndexWithoutNotify(int index) { }

	// RVA: 0x16472F4
	public int get_selectIndex() { }

	// RVA: 0x1647398
	public void set_selectIndex(int value) { }

	// RVA: 0x164CE40
	internal void SetSelectIndexWithoutNotify(int index) { }

	// RVA: 0x16538C0
	public string get_selectedText() { }

	// RVA: 0x1653BB4
	public void .ctor(TextHandle textHandle) { }

	// RVA: 0x1653C08
	internal bool HandleKeyEvent(Event e) { }

	// RVA: 0x1654B14
	private bool PerformOperation(TextSelectOp operation) { }

	// RVA: 0x165673C
	private static void MapKey(string key, TextSelectOp action) { }

	// RVA: 0x1653D2C
	private void InitKeyActions() { }

	// RVA: 0x164CE48
	public void ClearCursorPos() { }

	// RVA: 0x16567E0
	public void OnFocus(bool selectAll) { }

	// RVA: 0x16566C4
	public void SelectAll() { }

	// RVA: 0x164D1D8
	public void SelectNone() { }

	// RVA: 0x1655014
	public void SelectLeft() { }

	// RVA: 0x1655208
	public void SelectRight() { }

	// RVA: 0x16553FC
	public void SelectUp() { }

	// RVA: 0x16554A8
	public void SelectDown() { }

	// RVA: 0x1655C74
	public void SelectTextEnd() { }

	// RVA: 0x1655C4C
	public void SelectTextStart() { }

	// RVA: 0x1655BB0
	public void SelectToStartOfNextWord() { }

	// RVA: 0x1655B14
	public void SelectToEndOfPreviousWord() { }

	// RVA: 0x1655554
	public void SelectWordRight() { }

	// RVA: 0x1655834
	public void SelectWordLeft() { }

	// RVA: 0x165658C
	public void SelectGraphicalLineStart() { }

	// RVA: 0x1656628
	public void SelectGraphicalLineEnd() { }

	// RVA: 0x1656054
	public void SelectParagraphForward() { }

	// RVA: 0x16562DC
	public void SelectParagraphBackward() { }

	// RVA: 0x1656A58
	public void SelectCurrentWord() { }

	// RVA: 0x1656D54
	public void SelectCurrentParagraph() { }

	// RVA: 0x1649A58
	public void MoveRight() { }

	// RVA: 0x16497F8
	public void MoveLeft() { }

	// RVA: 0x1649CC4
	public void MoveUp() { }

	// RVA: 0x1649F34
	public void MoveDown() { }

	// RVA: 0x164A1B4
	public void MoveLineStart() { }

	// RVA: 0x164A388
	public void MoveLineEnd() { }

	// RVA: 0x164B1AC
	public void MoveGraphicalLineStart() { }

	// RVA: 0x164B2FC
	public void MoveGraphicalLineEnd() { }

	// RVA: 0x164AC48
	public void MoveTextStart() { }

	// RVA: 0x164ACB4
	public void MoveTextEnd() { }

	// RVA: 0x164AD30
	public void MoveParagraphForward() { }

	// RVA: 0x164AF64
	public void MoveParagraphBackward() { }

	// RVA: 0x164A578
	public void MoveWordRight() { }

	// RVA: 0x164A788
	public void MoveToStartOfNextWord() { }

	// RVA: 0x164A8F0
	public void MoveToEndOfPreviousWord() { }

	// RVA: 0x164AA58
	public void MoveWordLeft() { }

	// RVA: 0x1657080
	public void MouseDragSelectsWholeWords(bool on) { }

	// RVA: 0x1655CC4
	public void ExpandSelectGraphicalLineStart() { }

	// RVA: 0x1655E8C
	public void ExpandSelectGraphicalLineEnd() { }

	// RVA: 0x1657234
	public void DblClickSnap(DblClickSnapping snapping) { }

	// RVA: 0x165723C
	protected internal void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift) { }

	// RVA: 0x165730C
	public void SelectToPosition(Vector2 cursorPosition) { }

	// RVA: 0x1656F40
	private int FindNextSeperator(int startPos) { }

	// RVA: 0x1656FD4
	private int FindPrevSeperator(int startPos) { }

	// RVA: 0x164CA1C
	public int FindStartOfNextWord(int p) { }

	// RVA: 0x164C914
	public int FindEndOfPreviousWord(int p) { }

	// RVA: 0x1656C04
	private int FindEndOfClassification(int p, Direction dir) { }

	// RVA: 0x16577BC
	private int ClampTextIndex(int index) { }

	// RVA: 0x1653864
	internal int EnsureValidCodePointIndex(int index) { }

	// RVA: 0x16577EC
	private bool IsValidCodePointIndex(int index) { }

	// RVA: 0x1656A08
	private int IndexOfEndOfLine(int startIndex) { }

	// RVA: 0x164CD44
	public int PreviousCodePointIndex(int index) { }

	// RVA: 0x164CC48
	public int NextCodePointIndex(int index) { }

	// RVA: 0x165688C
	private int GetGraphicalLineStart(int p) { }

	// RVA: 0x1656940
	private int GetGraphicalLineEnd(int p) { }

	// RVA: 0x164CF5C
	public void Copy() { }

	// RVA: 0x1657634
	private CharacterType ClassifyChar(int index) { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Methods

	// RVA: 0x16578E8
	internal static UInt32 ComputeStringHash(string s) { }

}


