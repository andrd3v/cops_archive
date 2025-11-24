// Namespace: 
internal class <Module> 
{}

// Namespace: 
private struct MonoScriptData 
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 
{
	// Methods

	// RVA: 0x1601954
	MonoScriptData Get() { }

	// RVA: 0x1601A58
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public class AnimationTriggers 
{
	// Fields
	private const string kDefaultNormalAnimName = 5731172240;
	private const string kDefaultHighlightedAnimName = 5730923136;
	private const string kDefaultPressedAnimName = 5731172192;
	private const string kDefaultSelectedAnimName = 5731172144;
	private const string kDefaultDisabledAnimName = 5731172096;
	private string m_NormalTrigger; // 0x10
	private string m_HighlightedTrigger; // 0x18
	private string m_PressedTrigger; // 0x20
	private string m_SelectedTrigger; // 0x28
	private string m_DisabledTrigger; // 0x30

	// Methods

	// RVA: 0x1601A60
	string get_normalTrigger() { }

	// RVA: 0x1601A68
	void set_normalTrigger(string value) { }

	// RVA: 0x1601A70
	string get_highlightedTrigger() { }

	// RVA: 0x1601A78
	void set_highlightedTrigger(string value) { }

	// RVA: 0x1601A80
	string get_pressedTrigger() { }

	// RVA: 0x1601A88
	void set_pressedTrigger(string value) { }

	// RVA: 0x1601A90
	string get_selectedTrigger() { }

	// RVA: 0x1601A98
	void set_selectedTrigger(string value) { }

	// RVA: 0x1601AA0
	string get_disabledTrigger() { }

	// RVA: 0x1601AA8
	void set_disabledTrigger(string value) { }

	// RVA: 0x1601AB0
	void .ctor() { }

}

// Namespace: 
public class ButtonClickedEvent 
{
	// Methods

	// RVA: 0x1601C68
	void .ctor() { }

}

// Namespace: 
private sealed class <OnFinishSubmit>d__9 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

	// Methods

	// RVA: 0x1601F94
	void .ctor(int <>1__state) { }

	// RVA: 0x1601FC0
	void System.IDisposable.Dispose() { }

	// RVA: 0x1601FC4
	bool MoveNext() { }

	// RVA: 0x16020D8
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16020E0
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1602120
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Button 
{
	// Fields
	private ButtonClickedEvent m_OnClick; // 0x100

	// Methods

	// RVA: 0x1601BB4
	void .ctor() { }

	// RVA: 0x1601C70
	ButtonClickedEvent get_onClick() { }

	// RVA: 0x1601C78
	void set_onClick(ButtonClickedEvent value) { }

	// RVA: 0x1601C88
	void Press() { }

	// RVA: 0x1601D24
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1601DCC
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1601F1C
	IEnumerator OnFinishSubmit() { }

}

// Namespace: UnityEngine.UI
public enum CanvasUpdate 
{
	// Fields
	public int value__; // 0x10
	public const CanvasUpdate Prelayout = 0;
	public const CanvasUpdate Layout = 1;
	public const CanvasUpdate PostLayout = 2;
	public const CanvasUpdate PreRender = 3;
	public const CanvasUpdate LatePreRender = 4;
	public const CanvasUpdate MaxUpdateValue = 5;
}

// Namespace: UnityEngine.UI
public interface ICanvasElement 
{
	// Methods

	// RVA: 0x2FE42A4
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x2FE360C
	Transform get_transform() { }

	// RVA: 0x2FE41A8
	void LayoutComplete() { }

	// RVA: 0x2FE41A8
	void GraphicUpdateComplete() { }

	// RVA: 0x2FE3054
	bool IsDestroyed() { }

}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry 
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = 5714747952;
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction; // 0x8

	// Methods

	// RVA: 0x1602128
	void .ctor() { }

	// RVA: 0x160236C
	CanvasUpdateRegistry get_instance() { }

	// RVA: 0x1602454
	bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x1602558
	void CleanInvalidItems() { }

	// RVA: 0x160286C
	void PerformUpdate() { }

	// RVA: 0x1603470
	int ParentCount(Transform child) { }

	// RVA: 0x1603554
	int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x16036B8
	void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x160385C
	bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16037B4
	bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x160395C
	void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1603AB8
	bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16039DC
	bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1603B38
	void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1603EDC
	void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1603BCC
	void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1603D54
	void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1603F70
	void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16040F8
	void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1604280
	bool IsRebuildingLayout() { }

	// RVA: 0x16042F4
	bool IsRebuildingGraphics() { }

	// RVA: 0x1604368
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public struct ColorBlock 
{
	// Fields
	private Color m_NormalColor; // 0x10
	private Color m_HighlightedColor; // 0x20
	private Color m_PressedColor; // 0x30
	private Color m_SelectedColor; // 0x40
	private Color m_DisabledColor; // 0x50
	private float m_ColorMultiplier; // 0x60
	private float m_FadeDuration; // 0x64
	public static ColorBlock defaultColorBlock; // 0x0

	// Methods

	// RVA: 0x1604404
	Color get_normalColor() { }

	// RVA: 0x1604410
	void set_normalColor(Color value) { }

	// RVA: 0x160441C
	Color get_highlightedColor() { }

	// RVA: 0x1604428
	void set_highlightedColor(Color value) { }

	// RVA: 0x1604434
	Color get_pressedColor() { }

	// RVA: 0x1604440
	void set_pressedColor(Color value) { }

	// RVA: 0x160444C
	Color get_selectedColor() { }

	// RVA: 0x1604458
	void set_selectedColor(Color value) { }

	// RVA: 0x1604464
	Color get_disabledColor() { }

	// RVA: 0x1604470
	void set_disabledColor(Color value) { }

	// RVA: 0x160447C
	float get_colorMultiplier() { }

	// RVA: 0x1604484
	void set_colorMultiplier(float value) { }

	// RVA: 0x160448C
	float get_fadeDuration() { }

	// RVA: 0x1604494
	void set_fadeDuration(float value) { }

	// RVA: 0x160449C
	void .cctor() { }

	// RVA: 0x1604518
	bool Equals(object obj) { }

	// RVA: 0x1604610
	bool Equals(ColorBlock other) { }

	// RVA: 0x1604844
	bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16048F8
	bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16049B0
	int GetHashCode() { }

}

// Namespace: UnityEngine.UI
public class ClipperRegistry 
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers; // 0x10

	// Methods

	// RVA: 0x1604A38
	void .ctor() { }

	// RVA: 0x1603210
	ClipperRegistry get_instance() { }

	// RVA: 0x1603338
	void Cull() { }

	// RVA: 0x1604AC4
	void Register(IClipper c) { }

	// RVA: 0x1604B38
	void Unregister(IClipper c) { }

	// RVA: 0x1604B98
	void Disable(IClipper c) { }

}

// Namespace: UnityEngine.UI
public static class Clipping 
{
	// Methods

	// RVA: 0x1604BF8
	Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, out bool validRect) { }

}

// Namespace: UnityEngine.UI
public interface IClipper 
{
	// Methods

	// RVA: 0x2FE41A8
	void PerformClipping() { }

}

// Namespace: UnityEngine.UI
public interface IClippable 
{
	// Methods

	// RVA: 0x2FE360C
	GameObject get_gameObject() { }

	// RVA: 0x2FE41A8
	void RecalculateClipping() { }

	// RVA: 0x2FE360C
	RectTransform get_rectTransform() { }

	// RVA: -1
	void Cull(Rect clipRect, bool validRect) { }

	// RVA: -1
	void SetClipRect(Rect value, bool validRect) { }

	// RVA: -1
	void SetClipSoftness(Vector2 clipSoftness) { }

}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper 
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x1604E04
	Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x1605028
	void .ctor() { }

}

// Namespace: 
public interface IFactoryControls 
{
	// Methods

	// RVA: 0x2FE37A0
	GameObject CreateGameObject(string name, Type[] components) { }

}

// Namespace: 
private class DefaultRuntimeFactory 
{
	// Fields
	public static IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x160A590
	GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x160A600
	void .ctor() { }

	// RVA: 0x160A608
	void .cctor() { }

}

// Namespace: 
public struct Resources 
{
	// Fields
	public Sprite standard; // 0x10
	public Sprite background; // 0x18
	public Sprite inputField; // 0x20
	public Sprite knob; // 0x28
	public Sprite checkmark; // 0x30
	public Sprite dropdown; // 0x38
	public Sprite mask; // 0x40
}

// Namespace: UnityEngine.UI
public static class DefaultControls 
{
	// Fields
	private static IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 1126170624;
	private const float kThickHeight = 1106247680;
	private const float kThinHeight = 1101004800;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Methods

	// RVA: 0x16050B4
	IFactoryControls get_factory() { }

	// RVA: 0x1605130
	GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x16052F0
	GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x160558C
	void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x1605698
	void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1605454
	void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x16056FC
	void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x16057F0
	GameObject CreatePanel(Resources resources) { }

	// RVA: 0x1605F98
	GameObject CreateButton(Resources resources) { }

	// RVA: 0x1606458
	GameObject CreateText(Resources resources) { }

	// RVA: 0x1606614
	GameObject CreateImage(Resources resources) { }

	// RVA: 0x160675C
	GameObject CreateRawImage(Resources resources) { }

	// RVA: 0x16068A4
	GameObject CreateSlider(Resources resources) { }

	// RVA: 0x16070B4
	GameObject CreateScrollbar(Resources resources) { }

	// RVA: 0x160764C
	GameObject CreateToggle(Resources resources) { }

	// RVA: 0x1607CE4
	GameObject CreateInputField(Resources resources) { }

	// RVA: 0x16083D4
	GameObject CreateDropdown(Resources resources) { }

	// RVA: 0x1609AD4
	GameObject CreateScrollView(Resources resources) { }

	// RVA: 0x160A4CC
	void .cctor() { }

}

// Namespace: 
protected internal class DropdownItem 
{
	// Fields
	private Text m_Text; // 0x20
	private Image m_Image; // 0x28
	private RectTransform m_RectTransform; // 0x30
	private Toggle m_Toggle; // 0x38

	// Methods

	// RVA: 0x160DCC4
	Text get_text() { }

	// RVA: 0x160DCCC
	void set_text(Text value) { }

	// RVA: 0x160DCD4
	Image get_image() { }

	// RVA: 0x160DCDC
	void set_image(Image value) { }

	// RVA: 0x160DCE4
	RectTransform get_rectTransform() { }

	// RVA: 0x160DCEC
	void set_rectTransform(RectTransform value) { }

	// RVA: 0x160DCF4
	Toggle get_toggle() { }

	// RVA: 0x160DCFC
	void set_toggle(Toggle value) { }

	// RVA: 0x160DD04
	void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x160DD8C
	void OnCancel(BaseEventData eventData) { }

	// RVA: 0x160DE5C
	void .ctor() { }

}

// Namespace: 
public class OptionData 
{
	// Fields
	private string m_Text; // 0x10
	private Sprite m_Image; // 0x18

	// Methods

	// RVA: 0x160DE64
	string get_text() { }

	// RVA: 0x160DE6C
	void set_text(string value) { }

	// RVA: 0x160DE74
	Sprite get_image() { }

	// RVA: 0x160DE7C
	void set_image(Sprite value) { }

	// RVA: 0x160987C
	void .ctor() { }

	// RVA: 0x160B1FC
	void .ctor(string text) { }

	// RVA: 0x160B35C
	void .ctor(Sprite image) { }

	// RVA: 0x160DE84
	void .ctor(string text, Sprite image) { }

}

// Namespace: 
public class OptionDataList 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options; // 0x10

	// Methods

	// RVA: 0x160DED4
	System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x160DEDC
	void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x160AAA4
	void .ctor() { }

}

// Namespace: 
public class DropdownEvent 
{
	// Methods

	// RVA: 0x160AB30
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass63_0 
{
	// Fields
	public DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x160CCD8
	void .ctor() { }

	// RVA: 0x160DEE4
	void <Show>b__0(bool x) { }

}

// Namespace: 
private sealed class <DelayedDestroyDropdownList>d__75 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

	// Methods

	// RVA: 0x160DAE0
	void .ctor(int <>1__state) { }

	// RVA: 0x160DF0C
	void System.IDisposable.Dispose() { }

	// RVA: 0x160DF10
	bool MoveNext() { }

	// RVA: 0x160DFD4
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x160DFDC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x160E01C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Dropdown 
{
	// Fields
	private RectTransform m_Template; // 0x100
	private Text m_CaptionText; // 0x108
	private Image m_CaptionImage; // 0x110
	private Text m_ItemText; // 0x118
	private Image m_ItemImage; // 0x120
	private int m_Value; // 0x128
	private OptionDataList m_Options; // 0x130
	private DropdownEvent m_OnValueChanged; // 0x138
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items; // 0x158
	private UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static OptionData s_NoOptionData; // 0x0

	// Methods

	// RVA: 0x160A674
	RectTransform get_template() { }

	// RVA: 0x16097D8
	void set_template(RectTransform value) { }

	// RVA: 0x160A67C
	Text get_captionText() { }

	// RVA: 0x1609804
	void set_captionText(Text value) { }

	// RVA: 0x160A684
	Image get_captionImage() { }

	// RVA: 0x160A68C
	void set_captionImage(Image value) { }

	// RVA: 0x160A6B8
	Text get_itemText() { }

	// RVA: 0x1609830
	void set_itemText(Text value) { }

	// RVA: 0x160A6C0
	Image get_itemImage() { }

	// RVA: 0x160A6C8
	void set_itemImage(Image value) { }

	// RVA: 0x160985C
	System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x160A6F4
	void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x160A728
	DropdownEvent get_onValueChanged() { }

	// RVA: 0x160A730
	void set_onValueChanged(DropdownEvent value) { }

	// RVA: 0x160A740
	float get_alphaFadeSpeed() { }

	// RVA: 0x160A748
	void set_alphaFadeSpeed(float value) { }

	// RVA: 0x160A750
	int get_value() { }

	// RVA: 0x160A758
	void set_value(int value) { }

	// RVA: 0x160A8D0
	void SetValueWithoutNotify(int input) { }

	// RVA: 0x160A760
	void Set(int value, bool sendCallback) { }

	// RVA: 0x160A8D8
	void .ctor() { }

	// RVA: 0x160AB84
	void Awake() { }

	// RVA: 0x160ACC4
	void Start() { }

	// RVA: 0x160AD7C
	void OnDisable() { }

	// RVA: 0x1609884
	void RefreshShownValue() { }

	// RVA: 0x160B05C
	void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }

	// RVA: 0x160B0D0
	void AddOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x160B230
	void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }

	// RVA: 0x160B390
	void ClearOptions() { }

	// RVA: 0x160B44C
	void SetupTemplate(Canvas rootCanvas) { }

	// RVA: 0x309AF8C
	T GetOrAddComponent(GameObject go) { }

	// RVA: 0x160BB90
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x160CAC0
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x160CAC4
	void OnCancel(BaseEventData eventData) { }

	// RVA: 0x160BB94
	void Show() { }

	// RVA: 0x160D104
	GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x160D668
	void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x160D6F0
	GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x160D794
	void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x160D81C
	DropdownItem CreateItem(DropdownItem itemTemplate) { }

	// RVA: 0x160D8C0
	void DestroyItem(DropdownItem item) { }

	// RVA: 0x160CCE0
	DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }

	// RVA: 0x160D8C4
	void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x160CFF8
	void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x160D95C
	void SetAlpha(float alpha) { }

	// RVA: 0x160CAC8
	void Hide() { }

	// RVA: 0x160DA58
	IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x160AE44
	void ImmediateDestroyDropdownList() { }

	// RVA: 0x160DB0C
	void OnSelectItem(Toggle toggle) { }

	// RVA: 0x160DC3C
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public class FontData 
{
	// Fields
	private Font m_Font; // 0x10
	private int m_FontSize; // 0x18
	private FontStyle m_FontStyle; // 0x1C
	private bool m_BestFit; // 0x20
	private int m_MinSize; // 0x24
	private int m_MaxSize; // 0x28
	private TextAnchor m_Alignment; // 0x2C
	private bool m_AlignByGeometry; // 0x30
	private bool m_RichText; // 0x31
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	private float m_LineSpacing; // 0x3C

	// Methods

	// RVA: 0x160E024
	FontData get_defaultFontData() { }

	// RVA: 0x160E0C0
	Font get_font() { }

	// RVA: 0x160E0C8
	void set_font(Font value) { }

	// RVA: 0x160E0D0
	int get_fontSize() { }

	// RVA: 0x160E0D8
	void set_fontSize(int value) { }

	// RVA: 0x160E0E0
	FontStyle get_fontStyle() { }

	// RVA: 0x160E0E8
	void set_fontStyle(FontStyle value) { }

	// RVA: 0x160E0F0
	bool get_bestFit() { }

	// RVA: 0x160E0F8
	void set_bestFit(bool value) { }

	// RVA: 0x160E100
	int get_minSize() { }

	// RVA: 0x160E108
	void set_minSize(int value) { }

	// RVA: 0x160E110
	int get_maxSize() { }

	// RVA: 0x160E118
	void set_maxSize(int value) { }

	// RVA: 0x160E120
	TextAnchor get_alignment() { }

	// RVA: 0x160E128
	void set_alignment(TextAnchor value) { }

	// RVA: 0x160E130
	bool get_alignByGeometry() { }

	// RVA: 0x160E138
	void set_alignByGeometry(bool value) { }

	// RVA: 0x160E140
	bool get_richText() { }

	// RVA: 0x160E148
	void set_richText(bool value) { }

	// RVA: 0x160E150
	HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x160E158
	void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x160E160
	VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x160E168
	void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x160E170
	float get_lineSpacing() { }

	// RVA: 0x160E178
	void set_lineSpacing(float value) { }

	// RVA: 0x160E180
	void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x160E184
	void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x160E0B8
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker 
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x160E1C8
	void TrackText(Text t) { }

	// RVA: 0x160E440
	void RebuildForFont(Font f) { }

	// RVA: 0x160E67C
	void UntrackText(Text t) { }

	// RVA: 0x160E8B4
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class Graphic 
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	protected Material m_Material; // 0x20
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner; // 0x98
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Methods

	// RVA: 0x160E950
	Material get_defaultGraphicMaterial() { }

	// RVA: 0x160EAA0
	Color get_color() { }

	// RVA: 0x160EAAC
	void set_color(Color value) { }

	// RVA: 0x160EAF4
	bool get_raycastTarget() { }

	// RVA: 0x160EAFC
	void set_raycastTarget(bool value) { }

	// RVA: 0x160F1E0
	Vector4 get_raycastPadding() { }

	// RVA: 0x160F1EC
	void set_raycastPadding(Vector4 value) { }

	// RVA: 0x160F1F8
	bool get_useLegacyMeshGeneration() { }

	// RVA: 0x160F200
	void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x160F208
	void .ctor() { }

	// RVA: 0x160F2E0
	void SetAllDirty() { }

	// RVA: 0x160F578
	void SetLayoutDirty() { }

	// RVA: 0x160F73C
	void SetVerticesDirty() { }

	// RVA: 0x160F83C
	void SetMaterialDirty() { }

	// RVA: 0x160F360
	void SetRaycastDirty() { }

	// RVA: 0x160F93C
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x160FA4C
	void OnBeforeTransformParentChanged() { }

	// RVA: 0x160FE14
	void OnTransformParentChanged() { }

	// RVA: 0x161033C
	int get_depth() { }

	// RVA: 0x160F6A4
	RectTransform get_rectTransform() { }

	// RVA: 0x160ECF8
	Canvas get_canvas() { }

	// RVA: 0x160FF34
	void CacheCanvas() { }

	// RVA: 0x161035C
	CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1610430
	Material get_defaultMaterial() { }

	// RVA: 0x1610498
	Material get_material() { }

	// RVA: 0x1610554
	void set_material(Material value) { }

	// RVA: 0x1610634
	Material get_materialForRendering() { }

	// RVA: 0x1610818
	Texture get_mainTexture() { }

	// RVA: 0x1610894
	void OnEnable() { }

	// RVA: 0x1610A70
	void OnDisable() { }

	// RVA: 0x1610ECC
	void OnDestroy() { }

	// RVA: 0x16110A0
	void OnCanvasHierarchyChanged() { }

	// RVA: 0x1611290
	void OnCullingChanged() { }

	// RVA: 0x1611384
	void Rebuild(CanvasUpdate update) { }

	// RVA: 0x16114A4
	void LayoutComplete() { }

	// RVA: 0x16114A8
	void GraphicUpdateComplete() { }

	// RVA: 0x16114AC
	void UpdateMaterial() { }

	// RVA: 0x1611568
	void UpdateGeometry() { }

	// RVA: 0x1611A00
	void DoMeshGeneration() { }

	// RVA: 0x1611578
	void DoLegacyMeshGeneration() { }

	// RVA: 0x1611EEC
	Mesh get_workerMesh() { }

	// RVA: 0x1612084
	void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }

	// RVA: 0x1612088
	void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1612124
	void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1612718
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x1612728
	void SetNativeSize() { }

	// RVA: 0x161272C
	bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1612C90
	Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x1612284
	Rect GetPixelAdjustedRect() { }

	// RVA: 0x1613060
	void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1613074
	void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x16132E4
	Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x16132F8
	void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1613398
	void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x161344C
	void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1613500
	void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x16135B4
	void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1613668
	void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x161371C
	void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x16137D0
	void .cctor() { }

	// RVA: 0x1613880
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
public enum BlockingObjects 
{
	// Fields
	public int value__; // 0x10
	public const BlockingObjects None = 0;
	public const BlockingObjects TwoD = 1;
	public const BlockingObjects ThreeD = 2;
	public const BlockingObjects All = 3;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UI.GraphicRaycaster.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UI.Graphic> <>9__27_0; // 0x8

	// Methods

	// RVA: 0x1614E98
	void .cctor() { }

	// RVA: 0x1614F04
	void .ctor() { }

	// RVA: 0x1614F0C
	int <Raycast>b__27_0(Graphic g1, Graphic g2) { }

}

// Namespace: UnityEngine.UI
public class GraphicRaycaster 
{
	// Fields
	protected const int kNoEventMaskSet = 4294967295;
	private bool m_IgnoreReversedGraphics; // 0x28
	private BlockingObjects m_BlockingObjects; // 0x2C
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults; // 0x40
	private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics; // 0x0

	// Methods

	// RVA: 0x1613888
	int get_sortOrderPriority() { }

	// RVA: 0x16139D8
	int get_renderOrderPriority() { }

	// RVA: 0x1613A3C
	bool get_ignoreReversedGraphics() { }

	// RVA: 0x1613A44
	void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1613A4C
	BlockingObjects get_blockingObjects() { }

	// RVA: 0x1613A54
	void set_blockingObjects(BlockingObjects value) { }

	// RVA: 0x1613A5C
	LayerMask get_blockingMask() { }

	// RVA: 0x1613A64
	void set_blockingMask(LayerMask value) { }

	// RVA: 0x1613A6C
	void .ctor() { }

	// RVA: 0x16138E0
	Canvas get_canvas() { }

	// RVA: 0x1613B10
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1614D28
	Camera get_eventCamera() { }

	// RVA: 0x16146C8
	void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }

	// RVA: 0x1614DFC
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public class GraphicRegistry 
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics; // 0x10
	private readonly System.Collections.Generic.Dictionary<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList; // 0x8

	// Methods

	// RVA: 0x1614F78
	void .ctor() { }

	// RVA: 0x161513C
	GraphicRegistry get_instance() { }

	// RVA: 0x16100F4
	void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x160EF88
	void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x160FC14
	void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x160EDB0
	void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1610CF8
	void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1615224
	void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16153E8
	System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x16145E4
	System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x16154CC
	void .cctor() { }

}

// Namespace: UnityEngine.UI
internal interface IGraphicEnabledDisabled 
{
	// Methods

	// RVA: 0x2FE41A8
	void OnSiblingGraphicEnabledDisabled() { }

}

// Namespace: 
public enum Type 
{
	// Fields
	public int value__; // 0x10
	public const Type Simple = 0;
	public const Type Sliced = 1;
	public const Type Tiled = 2;
	public const Type Filled = 3;
}

// Namespace: 
public enum FillMethod 
{
	// Fields
	public int value__; // 0x10
	public const FillMethod Horizontal = 0;
	public const FillMethod Vertical = 1;
	public const FillMethod Radial90 = 2;
	public const FillMethod Radial180 = 3;
	public const FillMethod Radial360 = 4;
}

// Namespace: 
public enum OriginHorizontal 
{
	// Fields
	public int value__; // 0x10
	public const OriginHorizontal Left = 0;
	public const OriginHorizontal Right = 1;
}

// Namespace: 
public enum OriginVertical 
{
	// Fields
	public int value__; // 0x10
	public const OriginVertical Bottom = 0;
	public const OriginVertical Top = 1;
}

// Namespace: 
public enum Origin90 
{
	// Fields
	public int value__; // 0x10
	public const Origin90 BottomLeft = 0;
	public const Origin90 TopLeft = 1;
	public const Origin90 TopRight = 2;
	public const Origin90 BottomRight = 3;
}

// Namespace: 
public enum Origin180 
{
	// Fields
	public int value__; // 0x10
	public const Origin180 Bottom = 0;
	public const Origin180 Left = 1;
	public const Origin180 Top = 2;
	public const Origin180 Right = 3;
}

// Namespace: 
public enum Origin360 
{
	// Fields
	public int value__; // 0x10
	public const Origin360 Bottom = 0;
	public const Origin360 Right = 1;
	public const Origin360 Top = 2;
	public const Origin360 Left = 3;
}

// Namespace: UnityEngine.UI
public class Image 
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	private Sprite m_Sprite; // 0xD8
	private Sprite m_OverrideSprite; // 0xE0
	private Type m_Type; // 0xE8
	private bool m_PreserveAspect; // 0xEC
	private bool m_FillCenter; // 0xED
	private FillMethod m_FillMethod; // 0xF0
	private float m_FillAmount; // 0xF4
	private bool m_FillClockwise; // 0xF8
	private int m_FillOrigin; // 0xFC
	private float m_AlphaHitTestMinimumThreshold; // 0x100
	private bool m_Tracked; // 0x104
	private bool m_UseSpriteMesh; // 0x105
	private float m_PixelsPerUnitMultiplier; // 0x108
	private float m_CachedReferencePixelsPerUnit; // 0x10C
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Methods

	// RVA: 0x1615560
	Sprite get_sprite() { }

	// RVA: 0x1605B20
	void set_sprite(Sprite value) { }

	// RVA: 0x16157F8
	void DisableSpriteOptimizations() { }

	// RVA: 0x1615800
	Sprite get_overrideSprite() { }

	// RVA: 0x1615908
	void set_overrideSprite(Sprite value) { }

	// RVA: 0x1615884
	Sprite get_activeSprite() { }

	// RVA: 0x1615994
	Type get_type() { }

	// RVA: 0x1605EE8
	void set_type(Type value) { }

	// RVA: 0x161599C
	bool get_preserveAspect() { }

	// RVA: 0x16159A4
	void set_preserveAspect(bool value) { }

	// RVA: 0x1615A54
	bool get_fillCenter() { }

	// RVA: 0x1615A5C
	void set_fillCenter(bool value) { }

	// RVA: 0x1615B0C
	FillMethod get_fillMethod() { }

	// RVA: 0x1615B14
	void set_fillMethod(FillMethod value) { }

	// RVA: 0x1615BC8
	float get_fillAmount() { }

	// RVA: 0x1615BD0
	void set_fillAmount(float value) { }

	// RVA: 0x1615C74
	bool get_fillClockwise() { }

	// RVA: 0x1615C7C
	void set_fillClockwise(bool value) { }

	// RVA: 0x1615D2C
	int get_fillOrigin() { }

	// RVA: 0x1615D34
	void set_fillOrigin(int value) { }

	// RVA: 0x1615DE4
	float get_eventAlphaThreshold() { }

	// RVA: 0x1615DF4
	void set_eventAlphaThreshold(float value) { }

	// RVA: 0x1615F70
	float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x1615E00
	void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x1615F78
	bool get_useSpriteMesh() { }

	// RVA: 0x1615F80
	void set_useSpriteMesh(bool value) { }

	// RVA: 0x1616030
	void .ctor() { }

	// RVA: 0x161607C
	Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x16161CC
	Texture get_mainTexture() { }

	// RVA: 0x1616460
	bool get_hasBorder() { }

	// RVA: 0x161660C
	float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x1616614
	void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x161663C
	float get_pixelsPerUnit() { }

	// RVA: 0x161690C
	float get_multipliedPixelsPerUnit() { }

	// RVA: 0x1616934
	Material get_material() { }

	// RVA: 0x1616B74
	void set_material(Material value) { }

	// RVA: 0x1616C54
	void OnBeforeSerialize() { }

	// RVA: 0x1616C58
	void OnAfterDeserialize() { }

	// RVA: 0x1616CAC
	void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x1616E10
	Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x16173E0
	void SetNativeSize() { }

	// RVA: 0x1617730
	void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x16155FC
	void TrackSprite() { }

	// RVA: 0x161A7F0
	void OnEnable() { }

	// RVA: 0x161A818
	void OnDisable() { }

	// RVA: 0x161A9C0
	void UpdateMaterial() { }

	// RVA: 0x161AB9C
	void OnCanvasHierarchyChanged() { }

	// RVA: 0x16178FC
	void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x1617C78
	void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x16181DC
	void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x1618A50
	void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x161B0C4
	void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x161AF64
	void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x161AE38
	Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x1619B80
	void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x161B23C
	bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x161B38C
	void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x161B794
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x161B798
	void CalculateLayoutInputVertical() { }

	// RVA: 0x161B79C
	float get_minWidth() { }

	// RVA: 0x161B7A4
	float get_preferredWidth() { }

	// RVA: 0x161B9B8
	float get_flexibleWidth() { }

	// RVA: 0x161B9C0
	float get_minHeight() { }

	// RVA: 0x161B9C8
	float get_preferredHeight() { }

	// RVA: 0x161BBDC
	float get_flexibleHeight() { }

	// RVA: 0x161BBE4
	int get_layoutPriority() { }

	// RVA: 0x161BBEC
	bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x161C25C
	Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x161C5B8
	void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x161A694
	void TrackImage(Image g) { }

	// RVA: 0x161A91C
	void UnTrackImage(Image g) { }

	// RVA: 0x161C860
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x161C8A4
	void .cctor() { }

	// RVA: 0x1615568
	void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	// RVA: 0x161CA04
	bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

}

// Namespace: UnityEngine.UI
public interface IMask 
{
	// Methods

	// RVA: 0x2FE3054
	bool Enabled() { }

	// RVA: 0x2FE360C
	RectTransform get_rectTransform() { }

}

// Namespace: UnityEngine.UI
public interface IMaskable 
{
	// Methods

	// RVA: 0x2FE41A8
	void RecalculateMasking() { }

}

// Namespace: 
public enum ContentType 
{
	// Fields
	public int value__; // 0x10
	public const ContentType Standard = 0;
	public const ContentType Autocorrected = 1;
	public const ContentType IntegerNumber = 2;
	public const ContentType DecimalNumber = 3;
	public const ContentType Alphanumeric = 4;
	public const ContentType Name = 5;
	public const ContentType EmailAddress = 6;
	public const ContentType Password = 7;
	public const ContentType Pin = 8;
	public const ContentType Custom = 9;
}

// Namespace: 
public enum InputType 
{
	// Fields
	public int value__; // 0x10
	public const InputType Standard = 0;
	public const InputType AutoCorrect = 1;
	public const InputType Password = 2;
}

// Namespace: 
public enum CharacterValidation 
{
	// Fields
	public int value__; // 0x10
	public const CharacterValidation None = 0;
	public const CharacterValidation Integer = 1;
	public const CharacterValidation Decimal = 2;
	public const CharacterValidation Alphanumeric = 3;
	public const CharacterValidation Name = 4;
	public const CharacterValidation EmailAddress = 5;
}

// Namespace: 
public enum LineType 
{
	// Fields
	public int value__; // 0x10
	public const LineType SingleLine = 0;
	public const LineType MultiLineSubmit = 1;
	public const LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class OnValidateInput 
{
	// Methods

	// RVA: 0x179C4F4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17A7EB8
	internal Char Invoke(string text, int charIndex, Char addedChar) { }

	// RVA: 0x17A7ECC
	internal IAsyncResult BeginInvoke(string text, int charIndex, Char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x17A7FC0
	internal Char EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public class SubmitEvent 
{
	// Methods

	// RVA: 0x179BB98
	void .ctor() { }

}

// Namespace: 
public class EndEditEvent 
{
	// Methods

	// RVA: 0x179BBEC
	void .ctor() { }

}

// Namespace: 
public class OnChangeEvent 
{
	// Methods

	// RVA: 0x179BC40
	void .ctor() { }

}

// Namespace: 
protected enum EditState 
{
	// Fields
	public int value__; // 0x10
	public const EditState Continue = 0;
	public const EditState Finish = 1;
}

// Namespace: 
private sealed class <CaretBlink>d__170 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Methods

	// RVA: 0x179EBFC
	void .ctor(int <>1__state) { }

	// RVA: 0x17A7FEC
	void System.IDisposable.Dispose() { }

	// RVA: 0x17A7FF0
	bool MoveNext() { }

	// RVA: 0x17A8178
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17A8180
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17A81C0
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private sealed class <MouseDragOutsideRect>d__194 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PointerEventData eventData; // 0x20
	public InputField <>4__this; // 0x28

	// Methods

	// RVA: 0x17A1D9C
	void .ctor(int <>1__state) { }

	// RVA: 0x17A81C8
	void System.IDisposable.Dispose() { }

	// RVA: 0x17A81CC
	bool MoveNext() { }

	// RVA: 0x17A846C
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17A8474
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17A84B4
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class InputField 
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly Char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	protected Text m_TextComponent; // 0x108
	protected Graphic m_Placeholder; // 0x110
	private ContentType m_ContentType; // 0x118
	private InputType m_InputType; // 0x11C
	private Char m_AsteriskChar; // 0x120
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	private LineType m_LineType; // 0x128
	private bool m_HideMobileInput; // 0x12C
	private CharacterValidation m_CharacterValidation; // 0x130
	private int m_CharacterLimit; // 0x134
	private SubmitEvent m_OnSubmit; // 0x138
	private EndEditEvent m_OnDidEndEdit; // 0x140
	private OnChangeEvent m_OnValueChanged; // 0x148
	private OnValidateInput m_OnValidateInput; // 0x150
	private Color m_CaretColor; // 0x158
	private bool m_CustomCaretColor; // 0x168
	private Color m_SelectionColor; // 0x16C
	protected string m_Text; // 0x180
	private float m_CaretBlinkRate; // 0x188
	private int m_CaretWidth; // 0x18C
	private bool m_ReadOnly; // 0x190
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 1028443341;
	private const float kVScrollSpeed = 1036831949;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = 5714747792;
	private const string kOculusQuestDeviceModel = 5730923008;
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Methods

	// RVA: 0x179B710
	BaseInput get_input() { }

	// RVA: 0x179B878
	string get_compositionString() { }

	// RVA: 0x179B934
	void .ctor() { }

	// RVA: 0x179BD7C
	Mesh get_mesh() { }

	// RVA: 0x179BE6C
	TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x179BEF8
	void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x179BF64
	bool get_shouldHideMobileInput() { }

	// RVA: 0x179C02C
	void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x179C034
	bool get_shouldActivateOnSelect() { }

	// RVA: 0x179C0B0
	string get_text() { }

	// RVA: 0x179C0B8
	void set_text(string value) { }

	// RVA: 0x179C4EC
	void SetTextWithoutNotify(string input) { }

	// RVA: 0x179C0C0
	void SetText(string value, bool sendCallback) { }

	// RVA: 0x179CBA4
	bool get_isFocused() { }

	// RVA: 0x179CBAC
	float get_caretBlinkRate() { }

	// RVA: 0x179CBB4
	void set_caretBlinkRate(float value) { }

	// RVA: 0x179CD14
	int get_caretWidth() { }

	// RVA: 0x179CD1C
	void set_caretWidth(int value) { }

	// RVA: 0x179CE84
	Text get_textComponent() { }

	// RVA: 0x179CE8C
	void set_textComponent(Text value) { }

	// RVA: 0x179D130
	Graphic get_placeholder() { }

	// RVA: 0x179D138
	void set_placeholder(Graphic value) { }

	// RVA: 0x179D194
	Color get_caretColor() { }

	// RVA: 0x179D1E0
	void set_caretColor(Color value) { }

	// RVA: 0x179D288
	bool get_customCaretColor() { }

	// RVA: 0x179D290
	void set_customCaretColor(bool value) { }

	// RVA: 0x179D338
	Color get_selectionColor() { }

	// RVA: 0x179D34C
	void set_selectionColor(Color value) { }

	// RVA: 0x179D3F4
	EndEditEvent get_onEndEdit() { }

	// RVA: 0x179D3FC
	void set_onEndEdit(EndEditEvent value) { }

	// RVA: 0x179D458
	SubmitEvent get_onSubmit() { }

	// RVA: 0x179D460
	void set_onSubmit(SubmitEvent value) { }

	// RVA: 0x179D4BC
	OnChangeEvent get_onValueChange() { }

	// RVA: 0x179D4C4
	void set_onValueChange(OnChangeEvent value) { }

	// RVA: 0x179D57C
	OnChangeEvent get_onValueChanged() { }

	// RVA: 0x179D520
	void set_onValueChanged(OnChangeEvent value) { }

	// RVA: 0x179D584
	OnValidateInput get_onValidateInput() { }

	// RVA: 0x179D58C
	void set_onValidateInput(OnValidateInput value) { }

	// RVA: 0x179D5E8
	int get_characterLimit() { }

	// RVA: 0x179D5F0
	void set_characterLimit(int value) { }

	// RVA: 0x179D6BC
	ContentType get_contentType() { }

	// RVA: 0x179D6C4
	void set_contentType(ContentType value) { }

	// RVA: 0x179D8DC
	LineType get_lineType() { }

	// RVA: 0x179D8E4
	void set_lineType(LineType value) { }

	// RVA: 0x179DB28
	InputType get_inputType() { }

	// RVA: 0x179DB30
	void set_inputType(InputType value) { }

	// RVA: 0x179DD28
	TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x179DD30
	TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x179DD38
	void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x179DDDC
	CharacterValidation get_characterValidation() { }

	// RVA: 0x179DDE4
	void set_characterValidation(CharacterValidation value) { }

	// RVA: 0x179DE88
	bool get_readOnly() { }

	// RVA: 0x179DE90
	void set_readOnly(bool value) { }

	// RVA: 0x179DE98
	bool get_multiLine() { }

	// RVA: 0x179DEAC
	Char get_asteriskChar() { }

	// RVA: 0x179DEB4
	void set_asteriskChar(Char value) { }

	// RVA: 0x179DF58
	bool get_wasCanceled() { }

	// RVA: 0x179DF60
	void ClampPos(ref int pos) { }

	// RVA: 0x179DFA0
	int get_caretPositionInternal() { }

	// RVA: 0x179DFD0
	void set_caretPositionInternal(int value) { }

	// RVA: 0x179E010
	int get_caretSelectPositionInternal() { }

	// RVA: 0x179E040
	void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x179E080
	bool get_hasSelection() { }

	// RVA: 0x179E0D8
	int get_caretPosition() { }

	// RVA: 0x179E108
	void set_caretPosition(int value) { }

	// RVA: 0x179E29C
	int get_selectionAnchorPosition() { }

	// RVA: 0x179E1B4
	void set_selectionAnchorPosition(int value) { }

	// RVA: 0x179E2CC
	int get_selectionFocusPosition() { }

	// RVA: 0x179E228
	void set_selectionFocusPosition(int value) { }

	// RVA: 0x179E2FC
	void OnEnable() { }

	// RVA: 0x179E5A4
	void OnDisable() { }

	// RVA: 0x179EB14
	void OnDestroy() { }

	// RVA: 0x179EB84
	IEnumerator CaretBlink() { }

	// RVA: 0x179EC28
	void SetCaretVisible() { }

	// RVA: 0x179CC3C
	void SetCaretActive() { }

	// RVA: 0x179EC70
	void UpdateCaretMaterial() { }

	// RVA: 0x179EDCC
	void OnFocus() { }

	// RVA: 0x179EE10
	void SelectAll() { }

	// RVA: 0x179EE54
	void MoveTextEnd(bool shift) { }

	// RVA: 0x179EEEC
	void MoveTextStart(bool shift) { }

	// RVA: 0x179EFBC
	string get_clipboard() { }

	// RVA: 0x179F02C
	void set_clipboard(string value) { }

	// RVA: 0x179F0B4
	bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x179F198
	bool InPlaceEditing() { }

	// RVA: 0x179F1DC
	bool InPlaceEditingChanged() { }

	// RVA: 0x179F288
	RangeInt GetInternalSelection() { }

	// RVA: 0x179F398
	void UpdateKeyboardCaret() { }

	// RVA: 0x179F488
	void UpdateCaretFromKeyboard() { }

	// RVA: 0x179F5A8
	void LateUpdate() { }

	// RVA: 0x17A0EA4
	Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x17A1290
	int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x17A14B0
	int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x17A1900
	bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x17A1A20
	void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x17A1A4C
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17A1D10
	IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x17A1DC8
	void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x17A1DF0
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17A2004
	EditState KeyPressed(Event evt) { }

	// RVA: 0x17A32B4
	bool IsValidChar(Char c) { }

	// RVA: 0x17A333C
	void ProcessEvent(Event e) { }

	// RVA: 0x17A3340
	void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x17A2B58
	string GetSelectedString() { }

	// RVA: 0x17A355C
	int FindtNextWordBegin() { }

	// RVA: 0x17A30E4
	void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x17A3644
	int FindtPrevWordBegin() { }

	// RVA: 0x17A2F24
	void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x17A3714
	int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x17A382C
	int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x17A3DB4
	int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x17A32AC
	void MoveDown(bool shift) { }

	// RVA: 0x17A4324
	void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x17A32A4
	void MoveUp(bool shift) { }

	// RVA: 0x17A44F0
	void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x17A2C34
	void Delete() { }

	// RVA: 0x17A2958
	void ForwardSpace() { }

	// RVA: 0x17A26D0
	void Backspace() { }

	// RVA: 0x17A4684
	void Insert(Char c) { }

	// RVA: 0x17A2ECC
	void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x17A0E1C
	void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x179C5B0
	void SendOnValueChanged() { }

	// RVA: 0x17A4894
	void SendOnEndEdit() { }

	// RVA: 0x17A06AC
	void SendOnSubmit() { }

	// RVA: 0x17A4924
	void Append(string input) { }

	// RVA: 0x17A49E8
	void Append(Char input) { }

	// RVA: 0x179C640
	void UpdateLabel() { }

	// RVA: 0x17A5DB4
	bool IsSelectionVisible() { }

	// RVA: 0x17A5E98
	int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x17A1778
	int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x17A4CB4
	void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x17A5FF4
	void ForceLabelUpdate() { }

	// RVA: 0x179CDFC
	void MarkGeometryAsDirty() { }

	// RVA: 0x17A5FF8
	void Rebuild(CanvasUpdate update) { }

	// RVA: 0x17A6548
	void LayoutComplete() { }

	// RVA: 0x17A654C
	void GraphicUpdateComplete() { }

	// RVA: 0x17A6008
	void UpdateGeometry() { }

	// RVA: 0x17A0118
	void AssignPositioningIfNeeded() { }

	// RVA: 0x17A6550
	void OnFillVBO(Mesh vbo) { }

	// RVA: 0x17A67C0
	void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x17A76E8
	void CreateCursorVerts() { }

	// RVA: 0x17A6F28
	void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x17A073C
	Char Validate(string text, int pos, Char ch) { }

	// RVA: 0x17A7834
	void ActivateInputField() { }

	// RVA: 0x179FC18
	void ActivateInputFieldInternal() { }

	// RVA: 0x17A79A8
	void OnSelect(BaseEventData eventData) { }

	// RVA: 0x17A79F4
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x179E860
	void DeactivateInputField() { }

	// RVA: 0x17A7A1C
	void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x17A7A4C
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x179D80C
	void EnforceContentType() { }

	// RVA: 0x179BC94
	void EnforceTextHOverflow() { }

	// RVA: 0x179D9A8
	void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	// RVA: 0x179DBD4
	void SetToCustom() { }

	// RVA: 0x17A7AAC
	void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x17A7AD8
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17A7ADC
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17A7AE0
	float get_minWidth() { }

	// RVA: 0x17A7AE8
	float get_preferredWidth() { }

	// RVA: 0x17A7C6C
	float get_flexibleWidth() { }

	// RVA: 0x17A7C74
	float get_minHeight() { }

	// RVA: 0x17A7C7C
	float get_preferredHeight() { }

	// RVA: 0x17A7DEC
	float get_flexibleHeight() { }

	// RVA: 0x17A7DF4
	int get_layoutPriority() { }

	// RVA: 0x17A7DFC
	void .cctor() { }

	// RVA: 0x17A7EB0
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
public enum AspectMode 
{
	// Fields
	public int value__; // 0x10
	public const AspectMode None = 0;
	public const AspectMode WidthControlsHeight = 1;
	public const AspectMode HeightControlsWidth = 2;
	public const AspectMode FitInParent = 3;
	public const AspectMode EnvelopeParent = 4;
}

// Namespace: UnityEngine.UI
public class AspectRatioFitter 
{
	// Fields
	private AspectMode m_AspectMode; // 0x20
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Methods

	// RVA: 0x17A84BC
	AspectMode get_aspectMode() { }

	// RVA: 0x17A84C4
	void set_aspectMode(AspectMode value) { }

	// RVA: 0x17A856C
	float get_aspectRatio() { }

	// RVA: 0x17A8574
	void set_aspectRatio(float value) { }

	// RVA: 0x17A8624
	RectTransform get_rectTransform() { }

	// RVA: 0x17A871C
	void .ctor() { }

	// RVA: 0x17A872C
	void OnEnable() { }

	// RVA: 0x17A87C8
	void Start() { }

	// RVA: 0x17A8948
	void OnDisable() { }

	// RVA: 0x17A8F04
	void OnTransformParentChanged() { }

	// RVA: 0x17A8FA0
	void Update() { }

	// RVA: 0x17A8FB4
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17A8FB8
	void UpdateRect() { }

	// RVA: 0x17A9388
	float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x17A926C
	Vector2 GetParentSize() { }

	// RVA: 0x17A9480
	void SetLayoutHorizontal() { }

	// RVA: 0x17A9484
	void SetLayoutVertical() { }

	// RVA: 0x17A8568
	void SetDirty() { }

	// RVA: 0x17A8828
	bool IsComponentValidOnObject() { }

	// RVA: 0x17A8920
	bool IsAspectModeValid() { }

	// RVA: 0x17A9488
	bool DoesParentExists() { }

}

// Namespace: 
public enum ScaleMode 
{
	// Fields
	public int value__; // 0x10
	public const ScaleMode ConstantPixelSize = 0;
	public const ScaleMode ScaleWithScreenSize = 1;
	public const ScaleMode ConstantPhysicalSize = 2;
}

// Namespace: 
public enum ScreenMatchMode 
{
	// Fields
	public int value__; // 0x10
	public const ScreenMatchMode MatchWidthOrHeight = 0;
	public const ScreenMatchMode Expand = 1;
	public const ScreenMatchMode Shrink = 2;
}

// Namespace: 
public enum Unit 
{
	// Fields
	public int value__; // 0x10
	public const Unit Centimeters = 0;
	public const Unit Millimeters = 1;
	public const Unit Inches = 2;
	public const Unit Points = 3;
	public const Unit Picas = 4;
}

// Namespace: UnityEngine.UI
public class CanvasScaler 
{
	// Fields
	private ScaleMode m_UiScaleMode; // 0x20
	protected float m_ReferencePixelsPerUnit; // 0x24
	protected float m_ScaleFactor; // 0x28
	protected Vector2 m_ReferenceResolution; // 0x2C
	protected ScreenMatchMode m_ScreenMatchMode; // 0x34
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 1073741824;
	protected Unit m_PhysicalUnit; // 0x3C
	protected float m_FallbackScreenDPI; // 0x40
	protected float m_DefaultSpriteDPI; // 0x44
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	protected bool m_PresetInfoIsWorld; // 0x60

	// Methods

	// RVA: 0x17A9490
	ScaleMode get_uiScaleMode() { }

	// RVA: 0x17A9498
	void set_uiScaleMode(ScaleMode value) { }

	// RVA: 0x17A94A0
	float get_referencePixelsPerUnit() { }

	// RVA: 0x17A94A8
	void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x17A94B0
	float get_scaleFactor() { }

	// RVA: 0x17A94B8
	void set_scaleFactor(float value) { }

	// RVA: 0x17A94D4
	Vector2 get_referenceResolution() { }

	// RVA: 0x17A94DC
	void set_referenceResolution(Vector2 value) { }

	// RVA: 0x17A9564
	ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x17A956C
	void set_screenMatchMode(ScreenMatchMode value) { }

	// RVA: 0x17A9574
	float get_matchWidthOrHeight() { }

	// RVA: 0x17A957C
	void set_matchWidthOrHeight(float value) { }

	// RVA: 0x17A9584
	Unit get_physicalUnit() { }

	// RVA: 0x17A958C
	void set_physicalUnit(Unit value) { }

	// RVA: 0x17A9594
	float get_fallbackScreenDPI() { }

	// RVA: 0x17A959C
	void set_fallbackScreenDPI(float value) { }

	// RVA: 0x17A95A4
	float get_defaultSpriteDPI() { }

	// RVA: 0x17A95AC
	void set_defaultSpriteDPI(float value) { }

	// RVA: 0x17A95C0
	float get_dynamicPixelsPerUnit() { }

	// RVA: 0x17A95C8
	void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x17A95D0
	void .ctor() { }

	// RVA: 0x17A9618
	void OnEnable() { }

	// RVA: 0x17A9704
	void Canvas_preWillRenderCanvases() { }

	// RVA: 0x17A9714
	void OnDisable() { }

	// RVA: 0x17A98DC
	void Handle() { }

	// RVA: 0x17A9A18
	void HandleWorldCanvas() { }

	// RVA: 0x17A9AB0
	void HandleConstantPixelSize() { }

	// RVA: 0x17A9B48
	void HandleScaleWithScreenSize() { }

	// RVA: 0x17A9E3C
	void HandleConstantPhysicalSize() { }

	// RVA: 0x17A981C
	void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x17A987C
	void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

}

// Namespace: 
public enum FitMode 
{
	// Fields
	public int value__; // 0x10
	public const FitMode Unconstrained = 0;
	public const FitMode MinSize = 1;
	public const FitMode PreferredSize = 2;
}

// Namespace: UnityEngine.UI
public class ContentSizeFitter 
{
	// Fields
	protected FitMode m_HorizontalFit; // 0x20
	protected FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Methods

	// RVA: 0x17A9F00
	FitMode get_horizontalFit() { }

	// RVA: 0x17A9F08
	void set_horizontalFit(FitMode value) { }

	// RVA: 0x17AA080
	FitMode get_verticalFit() { }

	// RVA: 0x17AA088
	void set_verticalFit(FitMode value) { }

	// RVA: 0x17AA158
	RectTransform get_rectTransform() { }

	// RVA: 0x17AA250
	void .ctor() { }

	// RVA: 0x17AA258
	void OnEnable() { }

	// RVA: 0x17AA308
	void OnDisable() { }

	// RVA: 0x17AA38C
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17AA434
	void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x17AA530
	void SetLayoutHorizontal() { }

	// RVA: 0x17AA560
	void SetLayoutVertical() { }

	// RVA: 0x17A9FD8
	void SetDirty() { }

}

// Namespace: 
public enum Corner 
{
	// Fields
	public int value__; // 0x10
	public const Corner UpperLeft = 0;
	public const Corner UpperRight = 1;
	public const Corner LowerLeft = 2;
	public const Corner LowerRight = 3;
}

// Namespace: 
public enum Axis 
{
	// Fields
	public int value__; // 0x10
	public const Axis Horizontal = 0;
	public const Axis Vertical = 1;
}

// Namespace: 
public enum Constraint 
{
	// Fields
	public int value__; // 0x10
	public const Constraint Flexible = 0;
	public const Constraint FixedColumnCount = 1;
	public const Constraint FixedRowCount = 2;
}

// Namespace: UnityEngine.UI
public class GridLayoutGroup 
{
	// Fields
	protected Corner m_StartCorner; // 0x60
	protected Axis m_StartAxis; // 0x64
	protected Vector2 m_CellSize; // 0x68
	protected Vector2 m_Spacing; // 0x70
	protected Constraint m_Constraint; // 0x78
	protected int m_ConstraintCount; // 0x7C

	// Methods

	// RVA: 0x17AA568
	Corner get_startCorner() { }

	// RVA: 0x17AA570
	void set_startCorner(Corner value) { }

	// RVA: 0x17AA5E0
	Axis get_startAxis() { }

	// RVA: 0x17AA5E8
	void set_startAxis(Axis value) { }

	// RVA: 0x17AA658
	Vector2 get_cellSize() { }

	// RVA: 0x17AA660
	void set_cellSize(Vector2 value) { }

	// RVA: 0x17AA6DC
	Vector2 get_spacing() { }

	// RVA: 0x17AA6E4
	void set_spacing(Vector2 value) { }

	// RVA: 0x17AA760
	Constraint get_constraint() { }

	// RVA: 0x17AA768
	void set_constraint(Constraint value) { }

	// RVA: 0x17AA7D8
	int get_constraintCount() { }

	// RVA: 0x17AA7E0
	void set_constraintCount(int value) { }

	// RVA: 0x17AA858
	void .ctor() { }

	// RVA: 0x17AAA1C
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17AB0C8
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17AB428
	void SetLayoutHorizontal() { }

	// RVA: 0x17ABD74
	void SetLayoutVertical() { }

	// RVA: 0x17AB430
	void SetCellsAlongAxis(int axis) { }

}

// Namespace: UnityEngine.UI
public class HorizontalLayoutGroup 
{
	// Methods

	// RVA: 0x17ABFD0
	void .ctor() { }

	// RVA: 0x17ABFE8
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17AC4F0
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17AC4FC
	void SetLayoutHorizontal() { }

	// RVA: 0x17ACD8C
	void SetLayoutVertical() { }

}

// Namespace: UnityEngine.UI
public abstract class HorizontalOrVerticalLayoutGroup 
{
	// Fields
	protected float m_Spacing; // 0x60
	protected bool m_ChildForceExpandWidth; // 0x64
	protected bool m_ChildForceExpandHeight; // 0x65
	protected bool m_ChildControlWidth; // 0x66
	protected bool m_ChildControlHeight; // 0x67
	protected bool m_ChildScaleWidth; // 0x68
	protected bool m_ChildScaleHeight; // 0x69
	protected bool m_ReverseArrangement; // 0x6A

	// Methods

	// RVA: 0x17ACD98
	float get_spacing() { }

	// RVA: 0x17ACDA0
	void set_spacing(float value) { }

	// RVA: 0x17ACE18
	bool get_childForceExpandWidth() { }

	// RVA: 0x17ACE20
	void set_childForceExpandWidth(bool value) { }

	// RVA: 0x17ACE90
	bool get_childForceExpandHeight() { }

	// RVA: 0x17ACE98
	void set_childForceExpandHeight(bool value) { }

	// RVA: 0x17ACF08
	bool get_childControlWidth() { }

	// RVA: 0x17ACF10
	void set_childControlWidth(bool value) { }

	// RVA: 0x17ACF80
	bool get_childControlHeight() { }

	// RVA: 0x17ACF88
	void set_childControlHeight(bool value) { }

	// RVA: 0x17ACFF8
	bool get_childScaleWidth() { }

	// RVA: 0x17AD000
	void set_childScaleWidth(bool value) { }

	// RVA: 0x17AD070
	bool get_childScaleHeight() { }

	// RVA: 0x17AD078
	void set_childScaleHeight(bool value) { }

	// RVA: 0x17AD0E8
	bool get_reverseArrangement() { }

	// RVA: 0x17AD0F0
	void set_reverseArrangement(bool value) { }

	// RVA: 0x17AC014
	void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x17AC508
	void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x17AD160
	void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x17ABFDC
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface ILayoutElement 
{
	// Methods

	// RVA: 0x2FE41A8
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2FE41A8
	void CalculateLayoutInputVertical() { }

	// RVA: -1
	float get_minWidth() { }

	// RVA: -1
	float get_preferredWidth() { }

	// RVA: -1
	float get_flexibleWidth() { }

	// RVA: -1
	float get_minHeight() { }

	// RVA: -1
	float get_preferredHeight() { }

	// RVA: -1
	float get_flexibleHeight() { }

	// RVA: 0x2FE32D4
	int get_layoutPriority() { }

}

// Namespace: UnityEngine.UI
public interface ILayoutController 
{
	// Methods

	// RVA: 0x2FE41A8
	void SetLayoutHorizontal() { }

	// RVA: 0x2FE41A8
	void SetLayoutVertical() { }

}

// Namespace: UnityEngine.UI
public interface ILayoutGroup 
{}

// Namespace: UnityEngine.UI
public interface ILayoutSelfController 
{}

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_ignoreLayout() { }

}

// Namespace: UnityEngine.UI
public class LayoutElement 
{
	// Fields
	private bool m_IgnoreLayout; // 0x20
	private float m_MinWidth; // 0x24
	private float m_MinHeight; // 0x28
	private float m_PreferredWidth; // 0x2C
	private float m_PreferredHeight; // 0x30
	private float m_FlexibleWidth; // 0x34
	private float m_FlexibleHeight; // 0x38
	private int m_LayoutPriority; // 0x3C

	// Methods

	// RVA: 0x17AD918
	bool get_ignoreLayout() { }

	// RVA: 0x17AD920
	void set_ignoreLayout(bool value) { }

	// RVA: 0x17ADAF8
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17ADAFC
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17ADB00
	float get_minWidth() { }

	// RVA: 0x17ADB08
	void set_minWidth(float value) { }

	// RVA: 0x17ADC14
	float get_minHeight() { }

	// RVA: 0x17ADC1C
	void set_minHeight(float value) { }

	// RVA: 0x17ADD28
	float get_preferredWidth() { }

	// RVA: 0x17ADD30
	void set_preferredWidth(float value) { }

	// RVA: 0x17ADE3C
	float get_preferredHeight() { }

	// RVA: 0x17ADE44
	void set_preferredHeight(float value) { }

	// RVA: 0x17ADF50
	float get_flexibleWidth() { }

	// RVA: 0x17ADF58
	void set_flexibleWidth(float value) { }

	// RVA: 0x17AE064
	float get_flexibleHeight() { }

	// RVA: 0x17AE06C
	void set_flexibleHeight(float value) { }

	// RVA: 0x17AE178
	int get_layoutPriority() { }

	// RVA: 0x17AE180
	void set_layoutPriority(int value) { }

	// RVA: 0x17AE284
	void .ctor() { }

	// RVA: 0x17AE2A4
	void OnEnable() { }

	// RVA: 0x17AE380
	void OnTransformParentChanged() { }

	// RVA: 0x17AE454
	void OnDisable() { }

	// RVA: 0x17AE540
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17AE614
	void OnBeforeTransformParentChanged() { }

	// RVA: 0x17ADA24
	void SetDirty() { }

}

// Namespace: 
private sealed class <DelayedSetDirty>d__56 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Methods

	// RVA: 0x17AECE0
	void .ctor(int <>1__state) { }

	// RVA: 0x17AED0C
	void System.IDisposable.Dispose() { }

	// RVA: 0x17AED10
	bool MoveNext() { }

	// RVA: 0x17AEDC4
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17AEDCC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17AEE0C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public abstract class LayoutGroup 
{
	// Fields
	protected RectOffset m_Padding; // 0x20
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren; // 0x58

	// Methods

	// RVA: 0x17AE6E8
	RectOffset get_padding() { }

	// RVA: 0x17AE6F0
	void set_padding(RectOffset value) { }

	// RVA: 0x17AE750
	TextAnchor get_childAlignment() { }

	// RVA: 0x17AE758
	void set_childAlignment(TextAnchor value) { }

	// RVA: 0x17AB330
	RectTransform get_rectTransform() { }

	// RVA: 0x17AE7C8
	System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }

	// RVA: 0x17AAC1C
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2FE41A8
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17AE7D0
	float get_minWidth() { }

	// RVA: 0x17AE7D8
	float get_preferredWidth() { }

	// RVA: 0x17AE7E0
	float get_flexibleWidth() { }

	// RVA: 0x17AE7E8
	float get_minHeight() { }

	// RVA: 0x17AE7F0
	float get_preferredHeight() { }

	// RVA: 0x17AE7F8
	float get_flexibleHeight() { }

	// RVA: 0x17AE800
	int get_layoutPriority() { }

	// RVA: 0x2FE41A8
	void SetLayoutHorizontal() { }

	// RVA: 0x2FE41A8
	void SetLayoutVertical() { }

	// RVA: 0x17AA8C4
	void .ctor() { }

	// RVA: 0x17AE808
	void OnEnable() { }

	// RVA: 0x17AE974
	void OnDisable() { }

	// RVA: 0x17AE9F8
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17AD884
	float GetTotalMinSize(int axis) { }

	// RVA: 0x17AD774
	float GetTotalPreferredSize(int axis) { }

	// RVA: 0x17AD7FC
	float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x17ABD7C
	float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x17AD278
	float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x17AB030
	void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x17AE9FC
	void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x17AD524
	void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x17ABEF0
	void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x17AD2B8
	void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x17AEAD4
	bool get_isRootLayoutGroup() { }

	// RVA: 0x17AEC24
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17AEC64
	void OnTransformChildrenChanged() { }

	// RVA: 0x309AF8C
	void SetProperty(ref T currentValue, T newValue) { }

	// RVA: 0x17AE830
	void SetDirty() { }

	// RVA: 0x17AEC68
	IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UI.LayoutRebuilder.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.Component> <>9__10_0; // 0x8
	public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0; // 0x10
	public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1; // 0x18
	public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2; // 0x20
	public static UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x17B03F8
	void .cctor() { }

	// RVA: 0x17B0464
	void .ctor() { }

	// RVA: 0x17B046C
	LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x17B04C4
	void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x17B04FC
	bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x17B0590
	void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x17B066C
	void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x17B0748
	void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x17B0828
	void <Rebuild>b__12_3(Component e) { }

}

// Namespace: UnityEngine.UI
public class LayoutRebuilder 
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders; // 0x0

	// Methods

	// RVA: 0x17AEE14
	void Initialize(RectTransform controller) { }

	// RVA: 0x17AEE58
	void Clear() { }

	// RVA: 0x17AEE88
	void .cctor() { }

	// RVA: 0x17AF078
	void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x17AF0F8
	Transform get_transform() { }

	// RVA: 0x17AF100
	bool IsDestroyed() { }

	// RVA: 0x17AF16C
	void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }

	// RVA: 0x17AF28C
	void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x17AF398
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x17AF9DC
	void PerformLayoutControl(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x17AF6B4
	void PerformLayoutCalculation(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x17A89CC
	void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x17AFE54
	bool ValidController(RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }

	// RVA: 0x17B00BC
	void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x17B0260
	void LayoutComplete() { }

	// RVA: 0x17B0304
	void GraphicUpdateComplete() { }

	// RVA: 0x17B0308
	int GetHashCode() { }

	// RVA: 0x17B0310
	bool Equals(object obj) { }

	// RVA: 0x17B0364
	string ToString() { }

	// RVA: 0x17B03F0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UI.LayoutUtility.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__3_0; // 0x8
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__4_0; // 0x10
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__4_1; // 0x18
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__5_0; // 0x20
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__6_0; // 0x28
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__7_0; // 0x30
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__7_1; // 0x38
	public static System.Func<UnityEngine.UI.ILayoutElement,System.Single> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x17B14B4
	void .cctor() { }

	// RVA: 0x17B1520
	void .ctor() { }

	// RVA: 0x17B1528
	float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x17B15DC
	float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x17B1690
	float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x17B1744
	float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x17B17F8
	float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x17B18AC
	float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x17B1960
	float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x17B1A14
	float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

// Namespace: UnityEngine.UI
public static class LayoutUtility 
{
	// Methods

	// RVA: 0x17AA518
	float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x17AA524
	float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x17AD90C
	float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x17B0A20
	float GetMinWidth(RectTransform rect) { }

	// RVA: 0x17B0D10
	float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x17B1000
	float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x17B0908
	float GetMinHeight(RectTransform rect) { }

	// RVA: 0x17B0B38
	float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x17B0EE8
	float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x17B1118
	float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue) { }

	// RVA: 0x17B113C
	float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue, out ILayoutElement source) { }

}

// Namespace: UnityEngine.UI
public class VerticalLayoutGroup 
{
	// Methods

	// RVA: 0x17B1AC8
	void .ctor() { }

	// RVA: 0x17B1AD4
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17B1B00
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17B1B0C
	void SetLayoutHorizontal() { }

	// RVA: 0x17B1B18
	void SetLayoutVertical() { }

}

// Namespace: UnityEngine.UI
public class Mask 
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Methods

	// RVA: 0x17B1B24
	RectTransform get_rectTransform() { }

	// RVA: 0x17B1BD0
	bool get_showMaskGraphic() { }

	// RVA: 0x17B1BD8
	void set_showMaskGraphic(bool value) { }

	// RVA: 0x17B1D70
	Graphic get_graphic() { }

	// RVA: 0x17B1E1C
	void .ctor() { }

	// RVA: 0x17B1E2C
	bool MaskEnabled() { }

	// RVA: 0x17B1F58
	void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x17B1F5C
	void OnEnable() { }

	// RVA: 0x17B2584
	void OnDisable() { }

	// RVA: 0x17B2994
	bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17B2AD0
	Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: 
public class CullStateChangedEvent 
{
	// Methods

	// RVA: 0x17B4564
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class MaskableGraphic 
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA1
	protected Material m_MaskMaterial; // 0xA8
	private RectMask2D m_ParentMask; // 0xB0
	private bool m_Maskable; // 0xB8
	private bool m_IsMaskingGraphic; // 0xB9
	protected bool m_IncludeForMasking; // 0xBA
	private CullStateChangedEvent m_OnCullStateChanged; // 0xC0
	protected bool m_ShouldRecalculate; // 0xC8
	protected int m_StencilValue; // 0xCC
	private readonly Vector3[] m_Corners; // 0xD0

	// Methods

	// RVA: 0x17B3510
	CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x17B3518
	void set_onCullStateChanged(CullStateChangedEvent value) { }

	// RVA: 0x17B3520
	bool get_maskable() { }

	// RVA: 0x17B3528
	void set_maskable(bool value) { }

	// RVA: 0x17B3554
	bool get_isMaskingGraphic() { }

	// RVA: 0x17B2298
	void set_isMaskingGraphic(bool value) { }

	// RVA: 0x17B355C
	Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x17B368C
	void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x17B39DC
	void UpdateCull(bool cull) { }

	// RVA: 0x17B3AC4
	void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x17B3B44
	void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x17B3B80
	void OnEnable() { }

	// RVA: 0x17B3DA4
	void OnDisable() { }

	// RVA: 0x17B3E70
	void OnTransformParentChanged() { }

	// RVA: 0x17B3ED0
	void ParentMaskStateChanged() { }

	// RVA: 0x17B3ED4
	void OnCanvasHierarchyChanged() { }

	// RVA: 0x17B3770
	Rect get_rootCanvasRect() { }

	// RVA: 0x17B3BE0
	void UpdateClipParent() { }

	// RVA: 0x17B43B4
	void RecalculateClipping() { }

	// RVA: 0x17B43B8
	void RecalculateMasking() { }

	// RVA: 0x17B4450
	void .ctor() { }

	// RVA: 0x17B45B8
	GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

// Namespace: UnityEngine.UI
public class MaskUtilities 
{
	// Methods

	// RVA: 0x17B45C0
	void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x17B22AC
	void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x17B2F54
	Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x17B3148
	int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x17B489C
	bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x17B3F34
	RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x17B4A70
	void GetRectMasksForClip(RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }

	// RVA: 0x17B4E4C
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface IMaterialModifier 
{
	// Methods

	// RVA: 0x2FE36BC
	Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: UnityEngine.UI
internal static class Misc 
{
	// Methods

	// RVA: 0x17B4E54
	void Destroy(object obj) { }

	// RVA: 0x17B4FE8
	void DestroyImmediate(object obj) { }

}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities 
{
	// Methods

	// RVA: 0x17B513C
	bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	// RVA: 0x17B564C
	Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x17B51B4
	Vector3 RelativeMouseAtScaled(Vector2 position) { }

}

// Namespace: 
public enum Mode 
{
	// Fields
	public int value__; // 0x10
	public const Mode None = 0;
	public const Mode Horizontal = 1;
	public const Mode Vertical = 2;
	public const Mode Automatic = 3;
	public const Mode Explicit = 4;
}

// Namespace: UnityEngine.UI
public struct Navigation 
{
	// Fields
	private Mode m_Mode; // 0x10
	private bool m_WrapAround; // 0x14
	private Selectable m_SelectOnUp; // 0x18
	private Selectable m_SelectOnDown; // 0x20
	private Selectable m_SelectOnLeft; // 0x28
	private Selectable m_SelectOnRight; // 0x30

	// Methods

	// RVA: 0x17B5728
	Mode get_mode() { }

	// RVA: 0x17B5730
	void set_mode(Mode value) { }

	// RVA: 0x17B5738
	bool get_wrapAround() { }

	// RVA: 0x17B5740
	void set_wrapAround(bool value) { }

	// RVA: 0x17B5748
	Selectable get_selectOnUp() { }

	// RVA: 0x17B5750
	void set_selectOnUp(Selectable value) { }

	// RVA: 0x17B5758
	Selectable get_selectOnDown() { }

	// RVA: 0x17B5760
	void set_selectOnDown(Selectable value) { }

	// RVA: 0x17B5768
	Selectable get_selectOnLeft() { }

	// RVA: 0x17B5770
	void set_selectOnLeft(Selectable value) { }

	// RVA: 0x17B5778
	Selectable get_selectOnRight() { }

	// RVA: 0x17B5780
	void set_selectOnRight(Selectable value) { }

	// RVA: 0x17B5788
	Navigation get_defaultNavigation() { }

	// RVA: 0x17B57A8
	bool Equals(Navigation other) { }

}

// Namespace: UnityEngine.UI
public class RawImage 
{
	// Fields
	private Texture m_Texture; // 0xD8
	private Rect m_UVRect; // 0xE0

	// Methods

	// RVA: 0x17B5914
	void .ctor() { }

	// RVA: 0x17B5948
	Texture get_mainTexture() { }

	// RVA: 0x17B5B1C
	Texture get_texture() { }

	// RVA: 0x17B5B24
	void set_texture(Texture value) { }

	// RVA: 0x17B5C18
	Rect get_uvRect() { }

	// RVA: 0x17B5C24
	void set_uvRect(Rect value) { }

	// RVA: 0x17B5C5C
	void SetNativeSize() { }

	// RVA: 0x17B5F80
	void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x17B685C
	void OnDidApplyAnimationProperties() { }

}

// Namespace: UnityEngine.UI
public class RectMask2D 
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets; // 0x30
	private System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	private Vector4 m_Padding; // 0x64
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Methods

	// RVA: 0x17B68A4
	Vector4 get_padding() { }

	// RVA: 0x17B68B0
	void set_padding(Vector4 value) { }

	// RVA: 0x17B68C0
	Vector2Int get_softness() { }

	// RVA: 0x17B68C8
	void set_softness(Vector2Int value) { }

	// RVA: 0x17B68E4
	Canvas get_Canvas() { }

	// RVA: 0x17B6AC4
	Rect get_canvasRect() { }

	// RVA: 0x17B6B88
	RectTransform get_rectTransform() { }

	// RVA: 0x17B6C34
	void .ctor() { }

	// RVA: 0x17B6DD8
	void OnEnable() { }

	// RVA: 0x17B6E18
	void OnDisable() { }

	// RVA: 0x17B6F1C
	void OnDestroy() { }

	// RVA: 0x17B6F48
	bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17B70B4
	Rect get_rootCanvasRect() { }

	// RVA: 0x17B72D8
	void PerformClipping() { }

	// RVA: 0x17B7D8C
	void UpdateClipSoftness() { }

	// RVA: 0x17B8198
	void AddClippable(IClippable clippable) { }

	// RVA: 0x17B82DC
	void RemoveClippable(IClippable clippable) { }

	// RVA: 0x17B84A4
	void OnTransformParentChanged() { }

	// RVA: 0x17B84E0
	void OnCanvasHierarchyChanged() { }

}

// Namespace: 
public enum Direction 
{
	// Fields
	public int value__; // 0x10
	public const Direction LeftToRight = 0;
	public const Direction RightToLeft = 1;
	public const Direction BottomToTop = 2;
	public const Direction TopToBottom = 3;
}

// Namespace: 
public class ScrollEvent 
{
	// Methods

	// RVA: 0x17B8B58
	void .ctor() { }

}

// Namespace: 
private enum Axis 
{
	// Fields
	public int value__; // 0x10
	public const Axis Horizontal = 0;
	public const Axis Vertical = 1;
}

// Namespace: 
private sealed class <ClickRepeat>d__58 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

	// Methods

	// RVA: 0x17BA16C
	void .ctor(int <>1__state) { }

	// RVA: 0x17BADE0
	void System.IDisposable.Dispose() { }

	// RVA: 0x17BADE4
	bool MoveNext() { }

	// RVA: 0x17BB230
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17BB238
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17BB278
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Scrollbar 
{
	// Fields
	private RectTransform m_HandleRect; // 0x100
	private Direction m_Direction; // 0x108
	private float m_Value; // 0x10C
	private float m_Size; // 0x110
	private int m_NumberOfSteps; // 0x114
	private ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Methods

	// RVA: 0x17B851C
	RectTransform get_handleRect() { }

	// RVA: 0x17B8524
	void set_handleRect(RectTransform value) { }

	// RVA: 0x17B8990
	Direction get_direction() { }

	// RVA: 0x17B8998
	void set_direction(Direction value) { }

	// RVA: 0x17B8A3C
	void .ctor() { }

	// RVA: 0x17B8CEC
	float get_value() { }

	// RVA: 0x17B8DA8
	void set_value(float value) { }

	// RVA: 0x17B8FE8
	void SetValueWithoutNotify(float input) { }

	// RVA: 0x17B8FF0
	float get_size() { }

	// RVA: 0x17B8FF8
	void set_size(float value) { }

	// RVA: 0x17B9090
	int get_numberOfSteps() { }

	// RVA: 0x17B9098
	void set_numberOfSteps(int value) { }

	// RVA: 0x17B914C
	ScrollEvent get_onValueChanged() { }

	// RVA: 0x17B9154
	void set_onValueChanged(ScrollEvent value) { }

	// RVA: 0x17B9164
	float get_stepSize() { }

	// RVA: 0x17B9194
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x17B9198
	void LayoutComplete() { }

	// RVA: 0x17B919C
	void GraphicUpdateComplete() { }

	// RVA: 0x17B91A0
	void OnEnable() { }

	// RVA: 0x17B94D0
	void OnDisable() { }

	// RVA: 0x17B9640
	void Update() { }

	// RVA: 0x17B85A4
	void UpdateCachedReferences() { }

	// RVA: 0x17B8DB0
	void Set(float input, bool sendCallback) { }

	// RVA: 0x17B9654
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17B969C
	Axis get_axis() { }

	// RVA: 0x17B96AC
	bool get_reverseValue() { }

	// RVA: 0x17B86F4
	void UpdateVisuals() { }

	// RVA: 0x17B96C0
	void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x17B9984
	void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x17B99F0
	bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x17B9A4C
	void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x17B9C48
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17B9D28
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17BA0BC
	IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x17BA01C
	IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x17BA198
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17BA320
	void OnMove(AxisEventData eventData) { }

	// RVA: 0x17BA788
	Selectable FindSelectableOnLeft() { }

	// RVA: 0x17BA898
	Selectable FindSelectableOnRight() { }

	// RVA: 0x17BA9A8
	Selectable FindSelectableOnUp() { }

	// RVA: 0x17BAAB8
	Selectable FindSelectableOnDown() { }

	// RVA: 0x17BABC8
	void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x17BABE4
	void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x17BADD8
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
public enum MovementType 
{
	// Fields
	public int value__; // 0x10
	public const MovementType Unrestricted = 0;
	public const MovementType Elastic = 1;
	public const MovementType Clamped = 2;
}

// Namespace: 
public enum ScrollbarVisibility 
{
	// Fields
	public int value__; // 0x10
	public const ScrollbarVisibility Permanent = 0;
	public const ScrollbarVisibility AutoHide = 1;
	public const ScrollbarVisibility AutoHideAndExpandViewport = 2;
}

// Namespace: 
public class ScrollRectEvent 
{
	// Methods

	// RVA: 0x17BBE50
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public class ScrollRect 
{
	// Fields
	private RectTransform m_Content; // 0x20
	private bool m_Horizontal; // 0x28
	private bool m_Vertical; // 0x29
	private MovementType m_MovementType; // 0x2C
	private float m_Elasticity; // 0x30
	private bool m_Inertia; // 0x34
	private float m_DecelerationRate; // 0x38
	private float m_ScrollSensitivity; // 0x3C
	private RectTransform m_Viewport; // 0x40
	private Scrollbar m_HorizontalScrollbar; // 0x48
	private Scrollbar m_VerticalScrollbar; // 0x50
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	private ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	private float m_HorizontalScrollbarSpacing; // 0x60
	private float m_VerticalScrollbarSpacing; // 0x64
	private ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Methods

	// RVA: 0x17BB280
	RectTransform get_content() { }

	// RVA: 0x17BB288
	void set_content(RectTransform value) { }

	// RVA: 0x17BB290
	bool get_horizontal() { }

	// RVA: 0x17BB298
	void set_horizontal(bool value) { }

	// RVA: 0x17BB2A0
	bool get_vertical() { }

	// RVA: 0x17BB2A8
	void set_vertical(bool value) { }

	// RVA: 0x17BB2B0
	MovementType get_movementType() { }

	// RVA: 0x17BB2B8
	void set_movementType(MovementType value) { }

	// RVA: 0x17BB2C0
	float get_elasticity() { }

	// RVA: 0x17BB2C8
	void set_elasticity(float value) { }

	// RVA: 0x17BB2D0
	bool get_inertia() { }

	// RVA: 0x17BB2D8
	void set_inertia(bool value) { }

	// RVA: 0x17BB2E0
	float get_decelerationRate() { }

	// RVA: 0x17BB2E8
	void set_decelerationRate(float value) { }

	// RVA: 0x17BB2F0
	float get_scrollSensitivity() { }

	// RVA: 0x17BB2F8
	void set_scrollSensitivity(float value) { }

	// RVA: 0x17BB300
	RectTransform get_viewport() { }

	// RVA: 0x17BB308
	void set_viewport(RectTransform value) { }

	// RVA: 0x17BB418
	Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x17BB420
	void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x17BB624
	Scrollbar get_verticalScrollbar() { }

	// RVA: 0x17BB62C
	void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x17BB830
	ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x17BB838
	void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x17BB840
	ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x17BB848
	void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x17BB850
	float get_horizontalScrollbarSpacing() { }

	// RVA: 0x17BB858
	void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x17BB9BC
	float get_verticalScrollbarSpacing() { }

	// RVA: 0x17BB9C4
	void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x17BBA78
	ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x17BBA80
	void set_onValueChanged(ScrollRectEvent value) { }

	// RVA: 0x17BBA88
	RectTransform get_viewRect() { }

	// RVA: 0x17BBBFC
	Vector2 get_velocity() { }

	// RVA: 0x17BBC04
	void set_velocity(Vector2 value) { }

	// RVA: 0x17BBC0C
	RectTransform get_rectTransform() { }

	// RVA: 0x17BBD04
	void .ctor() { }

	// RVA: 0x17BBEA4
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x17BCCD0
	void LayoutComplete() { }

	// RVA: 0x17BCCD4
	void GraphicUpdateComplete() { }

	// RVA: 0x17BBF30
	void UpdateCachedData() { }

	// RVA: 0x17BCCD8
	void OnEnable() { }

	// RVA: 0x17BCF88
	void OnDisable() { }

	// RVA: 0x17BD1EC
	bool IsActive() { }

	// RVA: 0x17BD294
	void EnsureLayoutHasRebuilt() { }

	// RVA: 0x17BD318
	void StopMovement() { }

	// RVA: 0x17BD36C
	void OnScroll(PointerEventData data) { }

	// RVA: 0x17BD820
	void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x17BD890
	void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x17BD9D0
	void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x17BD9FC
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17BDD54
	void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x17BDE34
	void LateUpdate() { }

	// RVA: 0x17BCBC8
	void UpdatePrevData() { }

	// RVA: 0x17BC718
	void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x17BE658
	Vector2 get_normalizedPosition() { }

	// RVA: 0x17BEBA8
	void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x17BE990
	float get_horizontalNormalizedPosition() { }

	// RVA: 0x17BEBFC
	void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x17BEA9C
	float get_verticalNormalizedPosition() { }

	// RVA: 0x17BEC10
	void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x17BEC24
	void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x17BEC38
	void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x17BEC4C
	void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x17BDD18
	float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x17BEFA0
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17BF050
	bool get_hScrollingNeeded() { }

	// RVA: 0x17BF10C
	bool get_vScrollingNeeded() { }

	// RVA: 0x17BF1C8
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17BF1CC
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17BF1D0
	float get_minWidth() { }

	// RVA: 0x17BF1D8
	float get_preferredWidth() { }

	// RVA: 0x17BF1E0
	float get_flexibleWidth() { }

	// RVA: 0x17BF1E8
	float get_minHeight() { }

	// RVA: 0x17BF1F0
	float get_preferredHeight() { }

	// RVA: 0x17BF1F8
	float get_flexibleHeight() { }

	// RVA: 0x17BF200
	int get_layoutPriority() { }

	// RVA: 0x17BF208
	void SetLayoutHorizontal() { }

	// RVA: 0x17BF988
	void SetLayoutVertical() { }

	// RVA: 0x17BE840
	void UpdateScrollbarVisibility() { }

	// RVA: 0x17BFE04
	void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x17BFA4C
	void UpdateScrollbarLayout() { }

	// RVA: 0x17BC394
	void UpdateBounds() { }

	// RVA: 0x17BFF4C
	void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x17BF868
	Bounds GetBounds() { }

	// RVA: 0x17BFFD4
	Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x17BD6B8
	Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x17C0218
	Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x17BB90C
	void SetDirty() { }

	// RVA: 0x17BB330
	void SetDirtyCaching() { }

	// RVA: 0x17C0358
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
public enum Transition 
{
	// Fields
	public int value__; // 0x10
	public const Transition None = 0;
	public const Transition ColorTint = 1;
	public const Transition SpriteSwap = 2;
	public const Transition Animation = 3;
}

// Namespace: 
protected enum SelectionState 
{
	// Fields
	public int value__; // 0x10
	public const SelectionState Normal = 0;
	public const SelectionState Highlighted = 1;
	public const SelectionState Pressed = 2;
	public const SelectionState Selected = 3;
	public const SelectionState Disabled = 4;
}

// Namespace: UnityEngine.UI
public class Selectable 
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	private Navigation m_Navigation; // 0x28
	private Transition m_Transition; // 0x50
	private ColorBlock m_Colors; // 0x54
	private SpriteState m_SpriteState; // 0xB0
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	private bool m_Interactable; // 0xD8
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	private bool <isPointerInside>k__BackingField; // 0xF0
	private bool <isPointerDown>k__BackingField; // 0xF1
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Methods

	// RVA: 0x17C0360
	Selectable[] get_allSelectablesArray() { }

	// RVA: 0x17C03FC
	int get_allSelectableCount() { }

	// RVA: 0x17C0478
	System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }

	// RVA: 0x17C05A8
	int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x17C0698
	Navigation get_navigation() { }

	// RVA: 0x17C06B0
	void set_navigation(Navigation value) { }

	// RVA: 0x17C07F8
	Transition get_transition() { }

	// RVA: 0x17C0800
	void set_transition(Transition value) { }

	// RVA: 0x17C08F8
	ColorBlock get_colors() { }

	// RVA: 0x17C0924
	void set_colors(ColorBlock value) { }

	// RVA: 0x17C0A0C
	SpriteState get_spriteState() { }

	// RVA: 0x17C0A18
	void set_spriteState(SpriteState value) { }

	// RVA: 0x17C0AE8
	AnimationTriggers get_animationTriggers() { }

	// RVA: 0x17C0AF0
	void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x17C0BBC
	Graphic get_targetGraphic() { }

	// RVA: 0x17C0BC4
	void set_targetGraphic(Graphic value) { }

	// RVA: 0x17C0C90
	bool get_interactable() { }

	// RVA: 0x17C0C98
	void set_interactable(bool value) { }

	// RVA: 0x17C0EA4
	bool get_isPointerInside() { }

	// RVA: 0x17C0EAC
	void set_isPointerInside(bool value) { }

	// RVA: 0x17C0EB4
	bool get_isPointerDown() { }

	// RVA: 0x17C0EBC
	void set_isPointerDown(bool value) { }

	// RVA: 0x17C0EC4
	bool get_hasSelection() { }

	// RVA: 0x17C0ECC
	void set_hasSelection(bool value) { }

	// RVA: 0x17B8BAC
	void .ctor() { }

	// RVA: 0x17C0ED4
	Image get_image() { }

	// RVA: 0x17C0F5C
	void set_image(Image value) { }

	// RVA: 0x17C0F64
	Animator get_animator() { }

	// RVA: 0x17C0FCC
	void Awake() { }

	// RVA: 0x17C10BC
	void OnCanvasGroupChanged() { }

	// RVA: 0x17C1150
	bool ParentGroupAllowsInteraction() { }

	// RVA: 0x17C12F4
	bool IsInteractable() { }

	// RVA: 0x17C1314
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17B91DC
	void OnEnable() { }

	// RVA: 0x17C13F8
	void OnTransformParentChanged() { }

	// RVA: 0x17C0788
	void OnSetProperty() { }

	// RVA: 0x17B94FC
	void OnDisable() { }

	// RVA: 0x17C142C
	void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x17C1384
	SelectionState get_currentSelectionState() { }

	// RVA: 0x17C14E8
	void InstantClearState() { }

	// RVA: 0x17C1C2C
	void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x17C1EDC
	Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x17C2418
	Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x17C25C8
	void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x17BA7AC
	Selectable FindSelectableOnLeft() { }

	// RVA: 0x17BA8BC
	Selectable FindSelectableOnRight() { }

	// RVA: 0x17BA9CC
	Selectable FindSelectableOnUp() { }

	// RVA: 0x17BAADC
	Selectable FindSelectableOnDown() { }

	// RVA: 0x17BA6E4
	void OnMove(AxisEventData eventData) { }

	// RVA: 0x17C162C
	void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x17C1764
	void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x17C18F8
	void TriggerAnimation(string triggername) { }

	// RVA: 0x17C26A8
	bool IsHighlighted() { }

	// RVA: 0x17C1498
	bool IsPressed() { }

	// RVA: 0x17C2728
	void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x17B9E54
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17BA264
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17C27D0
	void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17C2880
	void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x17C292C
	void OnSelect(BaseEventData eventData) { }

	// RVA: 0x17C29DC
	void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x17C2A88
	void Select() { }

	// RVA: 0x17C2BDC
	void .cctor() { }

}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility 
{
	// Methods

	// RVA: 0x17C2C6C
	bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: 0x309AF8C
	bool SetStruct(ref T currentValue, T newValue) { }

	// RVA: 0x309AF8C
	bool SetClass(ref T currentValue, T newValue) { }

}

// Namespace: 
public enum Direction 
{
	// Fields
	public int value__; // 0x10
	public const Direction LeftToRight = 0;
	public const Direction RightToLeft = 1;
	public const Direction BottomToTop = 2;
	public const Direction TopToBottom = 3;
}

// Namespace: 
public class SliderEvent 
{
	// Methods

	// RVA: 0x17C3F18
	void .ctor() { }

}

// Namespace: 
private enum Axis 
{
	// Fields
	public int value__; // 0x10
	public const Axis Horizontal = 0;
	public const Axis Vertical = 1;
}

// Namespace: UnityEngine.UI
public class Slider 
{
	// Fields
	private RectTransform m_FillRect; // 0x100
	private RectTransform m_HandleRect; // 0x108
	private Direction m_Direction; // 0x110
	private float m_MinValue; // 0x114
	private float m_MaxValue; // 0x118
	private bool m_WholeNumbers; // 0x11C
	protected float m_Value; // 0x120
	private SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Methods

	// RVA: 0x17C2CB8
	RectTransform get_fillRect() { }

	// RVA: 0x17C2CC0
	void set_fillRect(RectTransform value) { }

	// RVA: 0x17C37F0
	RectTransform get_handleRect() { }

	// RVA: 0x17C37F8
	void set_handleRect(RectTransform value) { }

	// RVA: 0x17C3878
	Direction get_direction() { }

	// RVA: 0x17C3880
	void set_direction(Direction value) { }

	// RVA: 0x17C3924
	float get_minValue() { }

	// RVA: 0x17C392C
	void set_minValue(float value) { }

	// RVA: 0x17C39F8
	float get_maxValue() { }

	// RVA: 0x17C3A00
	void set_maxValue(float value) { }

	// RVA: 0x17C3ACC
	bool get_wholeNumbers() { }

	// RVA: 0x17C3AD4
	void set_wholeNumbers(bool value) { }

	// RVA: 0x17C3B94
	float get_value() { }

	// RVA: 0x17C3C60
	void set_value(float value) { }

	// RVA: 0x17C3C74
	void SetValueWithoutNotify(float input) { }

	// RVA: 0x17C3C88
	float get_normalizedValue() { }

	// RVA: 0x17C3D7C
	void set_normalizedValue(float value) { }

	// RVA: 0x17C3DB8
	SliderEvent get_onValueChanged() { }

	// RVA: 0x17C3DC0
	void set_onValueChanged(SliderEvent value) { }

	// RVA: 0x17C3DD0
	float get_stepSize() { }

	// RVA: 0x17C3E00
	void .ctor() { }

	// RVA: 0x17C3F6C
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x17C3F70
	void LayoutComplete() { }

	// RVA: 0x17C3F74
	void GraphicUpdateComplete() { }

	// RVA: 0x17C3F78
	void OnEnable() { }

	// RVA: 0x17C3FC0
	void OnDisable() { }

	// RVA: 0x17C3FEC
	void Update() { }

	// RVA: 0x17C403C
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17C2D40
	void UpdateCachedReferences() { }

	// RVA: 0x17C4538
	float ClampValue(float input) { }

	// RVA: 0x17C463C
	void Set(float input, bool sendCallback) { }

	// RVA: 0x17C47C4
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17C462C
	Axis get_axis() { }

	// RVA: 0x17C4618
	bool get_reverseValue() { }

	// RVA: 0x17C30EC
	void UpdateVisuals() { }

	// RVA: 0x17C480C
	void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x17C4A84
	bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x17C4AE0
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17C4CEC
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17C4D68
	void OnMove(AxisEventData eventData) { }

	// RVA: 0x17C512C
	Selectable FindSelectableOnLeft() { }

	// RVA: 0x17C5150
	Selectable FindSelectableOnRight() { }

	// RVA: 0x17C5174
	Selectable FindSelectableOnUp() { }

	// RVA: 0x17C5198
	Selectable FindSelectableOnDown() { }

	// RVA: 0x17C51BC
	void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x17C51D8
	void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x17C53CC
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: UnityEngine.UI
public struct SpriteState 
{
	// Fields
	private Sprite m_HighlightedSprite; // 0x10
	private Sprite m_PressedSprite; // 0x18
	private Sprite m_SelectedSprite; // 0x20
	private Sprite m_DisabledSprite; // 0x28

	// Methods

	// RVA: 0x17C53D4
	Sprite get_highlightedSprite() { }

	// RVA: 0x17C53DC
	void set_highlightedSprite(Sprite value) { }

	// RVA: 0x17C53E4
	Sprite get_pressedSprite() { }

	// RVA: 0x17C53EC
	void set_pressedSprite(Sprite value) { }

	// RVA: 0x17C53F4
	Sprite get_selectedSprite() { }

	// RVA: 0x17C53FC
	void set_selectedSprite(Sprite value) { }

	// RVA: 0x17C5404
	Sprite get_disabledSprite() { }

	// RVA: 0x17C540C
	void set_disabledSprite(Sprite value) { }

	// RVA: 0x17C5414
	bool Equals(SpriteState other) { }

}

// Namespace: 
private class MatEntry 
{
	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x17C6138
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class StencilMaterial 
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	// RVA: 0x17C5584
	Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x17C558C
	Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x17C6074
	void LogWarningWhenNotInBatchmode(string warning, object context) { }

	// RVA: 0x17C5624
	Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x17C6148
	void Remove(Material customMat) { }

	// RVA: 0x17C6334
	void ClearAll() { }

	// RVA: 0x17C64EC
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public class Text 
{
	// Fields
	private FontData m_FontData; // 0xD8
	protected string m_Text; // 0xE0
	private TextGenerator m_TextCache; // 0xE8
	private TextGenerator m_TextCacheForLayout; // 0xF0
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xF8
	private readonly UIVertex[] m_TempVerts; // 0x100

	// Methods

	// RVA: 0x17C6588
	void .ctor() { }

	// RVA: 0x17C6644
	TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x17C66FC
	TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x17C6788
	Texture get_mainTexture() { }

	// RVA: 0x17C69DC
	void FontTextureChanged() { }

	// RVA: 0x17C69BC
	Font get_font() { }

	// RVA: 0x17C6B30
	void set_font(Font value) { }

	// RVA: 0x17C6C70
	string get_text() { }

	// RVA: 0x17C6C78
	void set_text(string value) { }

	// RVA: 0x17C6D6C
	bool get_supportRichText() { }

	// RVA: 0x17C6D8C
	void set_supportRichText(bool value) { }

	// RVA: 0x17C6DF8
	bool get_resizeTextForBestFit() { }

	// RVA: 0x17C6E18
	void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x17C6E84
	int get_resizeTextMinSize() { }

	// RVA: 0x17C6EA4
	void set_resizeTextMinSize(int value) { }

	// RVA: 0x17C6F08
	int get_resizeTextMaxSize() { }

	// RVA: 0x17C6F28
	void set_resizeTextMaxSize(int value) { }

	// RVA: 0x17C6F8C
	TextAnchor get_alignment() { }

	// RVA: 0x17C6FAC
	void set_alignment(TextAnchor value) { }

	// RVA: 0x17C7010
	bool get_alignByGeometry() { }

	// RVA: 0x17C7030
	void set_alignByGeometry(bool value) { }

	// RVA: 0x17C7078
	int get_fontSize() { }

	// RVA: 0x17C7098
	void set_fontSize(int value) { }

	// RVA: 0x17C70FC
	HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x17C711C
	void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x17C7180
	VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x17C71A0
	void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x17C7204
	float get_lineSpacing() { }

	// RVA: 0x17C7224
	void set_lineSpacing(float value) { }

	// RVA: 0x17C7288
	FontStyle get_fontStyle() { }

	// RVA: 0x17C72A8
	void set_fontStyle(FontStyle value) { }

	// RVA: 0x17C730C
	float get_pixelsPerUnit() { }

	// RVA: 0x17C74A0
	void OnEnable() { }

	// RVA: 0x17C7534
	void OnDisable() { }

	// RVA: 0x17C75A4
	void UpdateGeometry() { }

	// RVA: 0x17C7644
	void AssignDefaultFont() { }

	// RVA: 0x17C76B8
	void AssignDefaultFontIfNecessary() { }

	// RVA: 0x17C778C
	TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x17C7950
	Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x17C79DC
	void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x17C8148
	void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17C814C
	void CalculateLayoutInputVertical() { }

	// RVA: 0x17C8150
	float get_minWidth() { }

	// RVA: 0x17C8158
	float get_preferredWidth() { }

	// RVA: 0x17C82B0
	float get_flexibleWidth() { }

	// RVA: 0x17C82B8
	float get_minHeight() { }

	// RVA: 0x17C82C0
	float get_preferredHeight() { }

	// RVA: 0x17C83E4
	float get_flexibleHeight() { }

	// RVA: 0x17C83EC
	int get_layoutPriority() { }

}

// Namespace: 
public enum ToggleTransition 
{
	// Fields
	public int value__; // 0x10
	public const ToggleTransition None = 0;
	public const ToggleTransition Fade = 1;
}

// Namespace: 
public class ToggleEvent 
{
	// Methods

	// RVA: 0x17C8940
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public class Toggle 
{
	// Fields
	public ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	private ToggleGroup m_Group; // 0x110
	public ToggleEvent onValueChanged; // 0x118
	private bool m_IsOn; // 0x120

	// Methods

	// RVA: 0x17C83F4
	ToggleGroup get_group() { }

	// RVA: 0x17C83FC
	void set_group(ToggleGroup value) { }

	// RVA: 0x17C8858
	void .ctor() { }

	// RVA: 0x17C8994
	void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x17C8998
	void LayoutComplete() { }

	// RVA: 0x17C899C
	void GraphicUpdateComplete() { }

	// RVA: 0x17C89A0
	void OnDestroy() { }

	// RVA: 0x17C8EB0
	void OnEnable() { }

	// RVA: 0x17C8F9C
	void OnDisable() { }

	// RVA: 0x17C8FC8
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17C84DC
	void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x17C9708
	bool get_isOn() { }

	// RVA: 0x17C9710
	void set_isOn(bool value) { }

	// RVA: 0x17C9718
	void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x17C9180
	void Set(bool value, bool sendCallback) { }

	// RVA: 0x17C8768
	void PlayEffect(bool instant) { }

	// RVA: 0x17C9890
	void Start() { }

	// RVA: 0x17C9968
	void InternalToggle() { }

	// RVA: 0x17C99CC
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17C9A40
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x17C9AA4
	Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UI.ToggleGroup.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UI.Toggle> <>9__13_0; // 0x8
	public static System.Func<UnityEngine.UI.Toggle,System.Boolean> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x17CA004
	void .cctor() { }

	// RVA: 0x17CA070
	void .ctor() { }

	// RVA: 0x17CA078
	bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x17CA094
	bool <ActiveToggles>b__14_0(Toggle x) { }

}

// Namespace: UnityEngine.UI
public class ToggleGroup 
{
	// Fields
	private bool m_AllowSwitchOff; // 0x20
	protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles; // 0x28

	// Methods

	// RVA: 0x17C9AAC
	bool get_allowSwitchOff() { }

	// RVA: 0x17C9AB4
	void set_allowSwitchOff(bool value) { }

	// RVA: 0x17C9ABC
	void .ctor() { }

	// RVA: 0x17C9B48
	void Start() { }

	// RVA: 0x17C9B70
	void OnEnable() { }

	// RVA: 0x17C9B98
	void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x17C9518
	void NotifyToggleOn(Toggle toggle, bool sendCallback) { }

	// RVA: 0x17C93D8
	void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x17C9478
	void RegisterToggle(Toggle toggle) { }

	// RVA: 0x17C8A68
	void EnsureValidState() { }

	// RVA: 0x17C9720
	bool AnyTogglesOn() { }

	// RVA: 0x17C9D10
	System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }

	// RVA: 0x17C9E40
	Toggle GetFirstActiveToggle() { }

	// RVA: 0x17C9EF0
	void SetAllTogglesOff(bool sendCallback) { }

}

// Namespace: 
public sealed class Raycast3DCallback 
{
	// Methods

	// RVA: 0x17CA898
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17CA93C
	internal bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x17CA97C
	internal IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x17CAAC0
	internal bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

}

// Namespace: 
public sealed class RaycastAllCallback 
{
	// Methods

	// RVA: 0x17CAB24
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17CABC8
	internal RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x17CAC08
	internal IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x17CAD1C
	internal RaycastHit[] EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GetRaycastNonAllocCallback 
{
	// Methods

	// RVA: 0x17CAD28
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x17CADCC
	internal int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x17CAE0C
	internal IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x17CAF2C
	internal int EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.UI
internal class ReflectionMethodsCache 
{
	// Fields
	public Raycast3DCallback raycast3D; // 0x10
	public RaycastAllCallback raycast3DAll; // 0x18
	public GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Methods

	// RVA: 0x17CA0B0
	void .ctor() { }

	// RVA: 0x17CA7F0
	ReflectionMethodsCache get_Singleton() { }

}

// Namespace: UnityEngine.UI
public class VertexHelper 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Vector3> m_Positions; // 0x10
	private System.Collections.Generic.List<UnityEngine.Color32> m_Colors; // 0x18
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S; // 0x20
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S; // 0x28
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S; // 0x30
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S; // 0x38
	private System.Collections.Generic.List<UnityEngine.Vector3> m_Normals; // 0x40
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents; // 0x48
	private System.Collections.Generic.List<System.Int32> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Methods

	// RVA: 0x17CAF58
	void .ctor() { }

	// RVA: 0x17CAF60
	void .ctor(Mesh m) { }

	// RVA: 0x17CB1A0
	void InitializeListIfRequired() { }

	// RVA: 0x17CB3B8
	void Dispose() { }

	// RVA: 0x17B6260
	void Clear() { }

	// RVA: 0x17CB630
	int get_currentVertCount() { }

	// RVA: 0x17CB688
	int get_currentIndexCount() { }

	// RVA: 0x17CB6E0
	void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x17CB888
	void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x17CBA30
	void FillMesh(Mesh mesh) { }

	// RVA: 0x17CBB9C
	void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x17CBD68
	void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x17B65F0
	void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x17CBE74
	void AddVert(UIVertex v) { }

	// RVA: 0x17B67A0
	void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x17C7F94
	void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x17CBF0C
	void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x17CBFBC
	void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

	// RVA: 0x17CC010
	void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }

	// RVA: 0x17CC064
	void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseVertexEffect 
{
	// Methods

	// RVA: 0x2FE4574
	void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x17CC100
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseMeshEffect 
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Methods

	// RVA: 0x17CC108
	Graphic get_graphic() { }

	// RVA: 0x17CC200
	void OnEnable() { }

	// RVA: 0x17CC2C8
	void OnDisable() { }

	// RVA: 0x17CC3B0
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17CC498
	void ModifyMesh(Mesh mesh) { }

	// RVA: 0x2FE4574
	void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x17CC614
	void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface IVertexModifier 
{
	// Methods

	// RVA: 0x2FE4574
	void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

}

// Namespace: UnityEngine.UI
public interface IMeshModifier 
{
	// Methods

	// RVA: 0x2FE4574
	void ModifyMesh(Mesh mesh) { }

	// RVA: 0x2FE4574
	void ModifyMesh(VertexHelper verts) { }

}

// Namespace: UnityEngine.UI
public class Outline 
{
	// Methods

	// RVA: 0x17CC61C
	void .ctor() { }

	// RVA: 0x17CC66C
	void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class PositionAsUV1 
{
	// Methods

	// RVA: 0x17CCB90
	void .ctor() { }

	// RVA: 0x17CCB98
	void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class Shadow 
{
	// Fields
	private Color m_EffectColor; // 0x28
	private Vector2 m_EffectDistance; // 0x38
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 1142292480;

	// Methods

	// RVA: 0x17CC644
	void .ctor() { }

	// RVA: 0x17CCC8C
	Color get_effectColor() { }

	// RVA: 0x17CCC98
	void set_effectColor(Color value) { }

	// RVA: 0x17CCD84
	Vector2 get_effectDistance() { }

	// RVA: 0x17CCD8C
	void set_effectDistance(Vector2 value) { }

	// RVA: 0x17CCEB0
	bool get_useGraphicAlpha() { }

	// RVA: 0x17CCEB8
	void set_useGraphicAlpha(bool value) { }

	// RVA: 0x17CC8EC
	void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x17CCF7C
	void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x17CCF84
	void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI.Collections
internal class IndexedSet<T0> 
{
	// Fields
	private readonly System.Collections.Generic.List<T> m_List; // 0x0
	private System.Collections.Generic.Dictionary<T,System.Int32> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void Add(T item) { }

	// RVA: 0x309AF8C
	void Add(T item, bool isActive) { }

	// RVA: 0x309AF8C
	bool AddUnique(T item, bool isActive) { }

	// RVA: 0x309AF8C
	bool EnableItem(T item) { }

	// RVA: 0x309AF8C
	bool DisableItem(T item) { }

	// RVA: 0x309AF8C
	bool Remove(T item) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(T item) { }

	// RVA: 0x2FE45DC
	void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE32D4
	int get_Capacity() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x309AF8C
	int IndexOf(T item) { }

	// RVA: 0x309AF8C
	void Insert(int index, T item) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int index) { }

	// RVA: 0x2FE4314
	void Swap(int index1, int index2) { }

	// RVA: 0x309AF8C
	T get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, T value) { }

	// RVA: 0x2FE4574
	void RemoveAll(System.Predicate<T> match) { }

	// RVA: 0x2FE4574
	void Sort(System.Comparison<T> sortLayoutFunction) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue 
{
	// Methods

	// RVA: -1
	void TweenValue(float floatPercentage) { }

	// RVA: 0x2FE3054
	bool get_ignoreTimeScale() { }

	// RVA: -1
	float get_duration() { }

	// RVA: 0x2FE3054
	bool ValidTarget() { }

}

// Namespace: 
public enum ColorTweenMode 
{
	// Fields
	public int value__; // 0x10
	public const ColorTweenMode All = 0;
	public const ColorTweenMode RGB = 1;
	public const ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTweenCallback 
{
	// Methods

	// RVA: 0x17CD300
	void .ctor() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween 
{
	// Fields
	private ColorTweenCallback m_Target; // 0x10
	private Color m_StartColor; // 0x18
	private Color m_TargetColor; // 0x28
	private ColorTweenMode m_TweenMode; // 0x38
	private float m_Duration; // 0x3C
	private bool m_IgnoreTimeScale; // 0x40

	// Methods

	// RVA: 0x17CD0F8
	Color get_startColor() { }

	// RVA: 0x17CD104
	void set_startColor(Color value) { }

	// RVA: 0x17CD110
	Color get_targetColor() { }

	// RVA: 0x17CD11C
	void set_targetColor(Color value) { }

	// RVA: 0x17CD128
	ColorTweenMode get_tweenMode() { }

	// RVA: 0x17CD130
	void set_tweenMode(ColorTweenMode value) { }

	// RVA: 0x17CD138
	float get_duration() { }

	// RVA: 0x17CD140
	void set_duration(float value) { }

	// RVA: 0x17CD148
	bool get_ignoreTimeScale() { }

	// RVA: 0x17CD150
	void set_ignoreTimeScale(bool value) { }

	// RVA: 0x17CD158
	void TweenValue(float floatPercentage) { }

	// RVA: 0x17CD228
	void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }

	// RVA: 0x17CD354
	bool GetIgnoreTimescale() { }

	// RVA: 0x17CD35C
	float GetDuration() { }

	// RVA: 0x17CD218
	bool ValidTarget() { }

}

// Namespace: 
public class FloatTweenCallback 
{
	// Methods

	// RVA: 0x17CD524
	void .ctor() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween 
{
	// Fields
	private FloatTweenCallback m_Target; // 0x10
	private float m_StartValue; // 0x18
	private float m_TargetValue; // 0x1C
	private float m_Duration; // 0x20
	private bool m_IgnoreTimeScale; // 0x24

	// Methods

	// RVA: 0x17CD364
	float get_startValue() { }

	// RVA: 0x17CD36C
	void set_startValue(float value) { }

	// RVA: 0x17CD374
	float get_targetValue() { }

	// RVA: 0x17CD37C
	void set_targetValue(float value) { }

	// RVA: 0x17CD384
	float get_duration() { }

	// RVA: 0x17CD38C
	void set_duration(float value) { }

	// RVA: 0x17CD394
	bool get_ignoreTimeScale() { }

	// RVA: 0x17CD39C
	void set_ignoreTimeScale(bool value) { }

	// RVA: 0x17CD3A4
	void TweenValue(float floatPercentage) { }

	// RVA: 0x17CD44C
	void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }

	// RVA: 0x17CD578
	bool GetIgnoreTimescale() { }

	// RVA: 0x17CD580
	float GetDuration() { }

	// RVA: 0x17CD43C
	bool ValidTarget() { }

}

// Namespace: 
private sealed class <Start>d__2 
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public T tweenInfo; // 0x0
	private float <elapsedTime>5__2; // 0x0

	// Methods

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE360C
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T0> 
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	// RVA: 0x309AF8C
	IEnumerator Start(T tweenInfo) { }

	// RVA: 0x2FE4574
	void Init(MonoBehaviour coroutineContainer) { }

	// RVA: 0x309AF8C
	void StartTween(T info) { }

	// RVA: 0x2FE41A8
	void StopTween() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private enum PointerEventType 
{
	// Fields
	public int value__; // 0x10
	public const PointerEventType Default = 0;
	public const PointerEventType Down = 1;
	public const PointerEventType Up = 2;
}

// Namespace: 
private class PointerEvent 
{
	// Fields
	private int <pointerId>k__BackingField; // 0x10
	private string <pointerType>k__BackingField; // 0x18
	private bool <isPrimary>k__BackingField; // 0x20
	private int <button>k__BackingField; // 0x24
	private int <pressedButtons>k__BackingField; // 0x28
	private Vector3 <position>k__BackingField; // 0x2C
	private Vector3 <localPosition>k__BackingField; // 0x38
	private Vector3 <deltaPosition>k__BackingField; // 0x44
	private float <deltaTime>k__BackingField; // 0x50
	private int <clickCount>k__BackingField; // 0x54
	private float <pressure>k__BackingField; // 0x58
	private float <tangentialPressure>k__BackingField; // 0x5C
	private float <altitudeAngle>k__BackingField; // 0x60
	private float <azimuthAngle>k__BackingField; // 0x64
	private float <twist>k__BackingField; // 0x68
	private Vector2 <tilt>k__BackingField; // 0x6C
	private PenStatus <penStatus>k__BackingField; // 0x74
	private Vector2 <radius>k__BackingField; // 0x78
	private Vector2 <radiusVariance>k__BackingField; // 0x80
	private EventModifiers <modifiers>k__BackingField; // 0x88

	// Methods

	// RVA: 0x17D03FC
	int get_pointerId() { }

	// RVA: 0x17D0404
	void set_pointerId(int value) { }

	// RVA: 0x17D040C
	string get_pointerType() { }

	// RVA: 0x17D0414
	void set_pointerType(string value) { }

	// RVA: 0x17D041C
	bool get_isPrimary() { }

	// RVA: 0x17D0424
	void set_isPrimary(bool value) { }

	// RVA: 0x17D042C
	int get_button() { }

	// RVA: 0x17D0434
	void set_button(int value) { }

	// RVA: 0x17D043C
	int get_pressedButtons() { }

	// RVA: 0x17D0444
	void set_pressedButtons(int value) { }

	// RVA: 0x17D044C
	Vector3 get_position() { }

	// RVA: 0x17D0458
	void set_position(Vector3 value) { }

	// RVA: 0x17D0464
	Vector3 get_localPosition() { }

	// RVA: 0x17D0470
	void set_localPosition(Vector3 value) { }

	// RVA: 0x17D047C
	Vector3 get_deltaPosition() { }

	// RVA: 0x17D0488
	void set_deltaPosition(Vector3 value) { }

	// RVA: 0x17D0494
	float get_deltaTime() { }

	// RVA: 0x17D049C
	void set_deltaTime(float value) { }

	// RVA: 0x17D04A4
	int get_clickCount() { }

	// RVA: 0x17D04AC
	void set_clickCount(int value) { }

	// RVA: 0x17D04B4
	float get_pressure() { }

	// RVA: 0x17D04BC
	void set_pressure(float value) { }

	// RVA: 0x17D04C4
	float get_tangentialPressure() { }

	// RVA: 0x17D04CC
	void set_tangentialPressure(float value) { }

	// RVA: 0x17D04D4
	float get_altitudeAngle() { }

	// RVA: 0x17D04DC
	void set_altitudeAngle(float value) { }

	// RVA: 0x17D04E4
	float get_azimuthAngle() { }

	// RVA: 0x17D04EC
	void set_azimuthAngle(float value) { }

	// RVA: 0x17D04F4
	float get_twist() { }

	// RVA: 0x17D04FC
	void set_twist(float value) { }

	// RVA: 0x17D0504
	Vector2 get_tilt() { }

	// RVA: 0x17D050C
	void set_tilt(Vector2 value) { }

	// RVA: 0x17D0514
	PenStatus get_penStatus() { }

	// RVA: 0x17D051C
	void set_penStatus(PenStatus value) { }

	// RVA: 0x17D0524
	Vector2 get_radius() { }

	// RVA: 0x17D052C
	void set_radius(Vector2 value) { }

	// RVA: 0x17D0534
	Vector2 get_radiusVariance() { }

	// RVA: 0x17D053C
	void set_radiusVariance(Vector2 value) { }

	// RVA: 0x17D0544
	EventModifiers get_modifiers() { }

	// RVA: 0x17D054C
	void set_modifiers(EventModifiers value) { }

	// RVA: 0x17D0554
	bool get_shiftKey() { }

	// RVA: 0x17D0560
	bool get_ctrlKey() { }

	// RVA: 0x17D056C
	bool get_commandKey() { }

	// RVA: 0x17D0578
	bool get_altKey() { }

	// RVA: 0x17D0584
	bool get_actionKey() { }

	// RVA: 0x17CFDE8
	void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x17D0324
	void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x17D03EC
	void .ctor() { }

	// RVA: 0x17D0650
	bool <Read>g__InRange|90_0(int i, int start, int count) { }

}

// Namespace: UnityEngine.UIElements
public class PanelEventHandler 
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x20
	private readonly PointerEvent m_PointerEvent; // 0x28
	private float m_LastClickTime; // 0x30
	private bool m_Selecting; // 0x34
	private Event m_Event; // 0x38
	private static EventModifiers s_Modifiers; // 0x0

	// Methods

	// RVA: 0x17CD588
	IPanel get_panel() { }

	// RVA: 0x17CD590
	void set_panel(IPanel value) { }

	// RVA: 0x17CD9CC
	GameObject get_selectableGameObject() { }

	// RVA: 0x17CD9E4
	EventSystem get_eventSystem() { }

	// RVA: 0x17CDB04
	bool get_isCurrentFocusedPanel() { }

	// RVA: 0x17CDBF8
	Focusable get_currentFocusedElement() { }

	// RVA: 0x17CDC34
	void OnEnable() { }

	// RVA: 0x17CDC3C
	void OnDisable() { }

	// RVA: 0x17CD810
	void RegisterCallbacks() { }

	// RVA: 0x17CD654
	void UnregisterCallbacks() { }

	// RVA: 0x17CDC44
	void OnPanelDestroyed() { }

	// RVA: 0x17CDCB4
	void OnElementFocus(FocusEvent e) { }

	// RVA: 0x17CDED4
	void OnElementBlur(BlurEvent e) { }

	// RVA: 0x17CDED8
	void OnSelect(BaseEventData eventData) { }

	// RVA: 0x17CDF58
	void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x17CDF6C
	void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x17CE2FC
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17CE518
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17CE820
	void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x17CEB64
	void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17CEBC8
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17CEBF0
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x17CEFEC
	void OnCancel(BaseEventData eventData) { }

	// RVA: 0x17CF214
	void OnMove(AxisEventData eventData) { }

	// RVA: 0x17CF45C
	void OnScroll(PointerEventData eventData) { }

	// RVA: 0x17CE294
	void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x17CF64C
	void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x17CF670
	void Update() { }

	// RVA: 0x17CF700
	void LateUpdate() { }

	// RVA: 0x17CEE18
	void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x17CF708
	void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x17CF79C
	void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x17CFC2C
	void SendTabEvent(Event e, Direction direction, Focusable target) { }

	// RVA: 0x17CF814
	void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x17CFA20
	void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x17CE118
	bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x17D033C
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PanelRaycaster 
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Methods

	// RVA: 0x17D0664
	IPanel get_panel() { }

	// RVA: 0x17D066C
	void set_panel(IPanel value) { }

	// RVA: 0x17D08A8
	void RegisterCallbacks() { }

	// RVA: 0x17D0808
	void UnregisterCallbacks() { }

	// RVA: 0x17D0948
	void OnPanelDestroyed() { }

	// RVA: 0x17D0950
	GameObject get_selectableGameObject() { }

	// RVA: 0x17D0968
	int get_sortOrderPriority() { }

	// RVA: 0x17D0A10
	int get_renderOrderPriority() { }

	// RVA: 0x17D0AB0
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x17D0F6C
	Camera get_eventCamera() { }

	// RVA: 0x17D0F74
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class AxisEventData 
{
	// Fields
	private Vector2 <moveVector>k__BackingField; // 0x20
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17D0F84
	Vector2 get_moveVector() { }

	// RVA: 0x17D0F8C
	void set_moveVector(Vector2 value) { }

	// RVA: 0x17D0F94
	MoveDirection get_moveDir() { }

	// RVA: 0x17D0F9C
	void set_moveDir(MoveDirection value) { }

	// RVA: 0x17D0FA4
	void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData 
{
	// Fields
	protected bool m_Used; // 0x10

	// Methods

	// RVA: 0x17D1050
	void Reset() { }

	// RVA: 0x17D1058
	void Use() { }

	// RVA: 0x17D1064
	bool get_used() { }

	// RVA: 0x17D106C
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseEventData 
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Methods

	// RVA: 0x17D101C
	void .ctor(EventSystem eventSystem) { }

	// RVA: 0x17D1074
	BaseInputModule get_currentInputModule() { }

	// RVA: 0x17D1094
	GameObject get_selectedObject() { }

	// RVA: 0x17D10B4
	void set_selectedObject(GameObject value) { }

}

// Namespace: 
public enum InputButton 
{
	// Fields
	public int value__; // 0x10
	public const InputButton Left = 0;
	public const InputButton Right = 1;
	public const InputButton Middle = 2;
}

// Namespace: 
public enum FramePressState 
{
	// Fields
	public int value__; // 0x10
	public const FramePressState Pressed = 0;
	public const FramePressState Released = 1;
	public const FramePressState PressedAndReleased = 2;
	public const FramePressState NotChanged = 3;
}

// Namespace: UnityEngine.EventSystems
public class PointerEventData 
{
	// Fields
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	private GameObject <lastPress>k__BackingField; // 0x30
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	private GameObject <pointerDrag>k__BackingField; // 0x40
	private GameObject <pointerClick>k__BackingField; // 0x48
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public System.Collections.Generic.List<UnityEngine.GameObject> hovered; // 0xF0
	private bool <eligibleForClick>k__BackingField; // 0xF8
	private int <displayIndex>k__BackingField; // 0xFC
	private int <pointerId>k__BackingField; // 0x100
	private Vector2 <position>k__BackingField; // 0x104
	private Vector2 <delta>k__BackingField; // 0x10C
	private Vector2 <pressPosition>k__BackingField; // 0x114
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	private Vector3 <worldNormal>k__BackingField; // 0x128
	private float <clickTime>k__BackingField; // 0x134
	private int <clickCount>k__BackingField; // 0x138
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	private bool <useDragThreshold>k__BackingField; // 0x144
	private bool <dragging>k__BackingField; // 0x145
	private InputButton <button>k__BackingField; // 0x148
	private float <pressure>k__BackingField; // 0x14C
	private float <tangentialPressure>k__BackingField; // 0x150
	private float <altitudeAngle>k__BackingField; // 0x154
	private float <azimuthAngle>k__BackingField; // 0x158
	private float <twist>k__BackingField; // 0x15C
	private Vector2 <tilt>k__BackingField; // 0x160
	private PenStatus <penStatus>k__BackingField; // 0x168
	private Vector2 <radius>k__BackingField; // 0x16C
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	private bool <fullyExited>k__BackingField; // 0x17C
	private bool <reentered>k__BackingField; // 0x17D

	// Methods

	// RVA: 0x17D135C
	GameObject get_pointerEnter() { }

	// RVA: 0x17D1364
	void set_pointerEnter(GameObject value) { }

	// RVA: 0x17D136C
	GameObject get_lastPress() { }

	// RVA: 0x17D1374
	void set_lastPress(GameObject value) { }

	// RVA: 0x17D137C
	GameObject get_rawPointerPress() { }

	// RVA: 0x17D1384
	void set_rawPointerPress(GameObject value) { }

	// RVA: 0x17D138C
	GameObject get_pointerDrag() { }

	// RVA: 0x17D1394
	void set_pointerDrag(GameObject value) { }

	// RVA: 0x17D139C
	GameObject get_pointerClick() { }

	// RVA: 0x17D13A4
	void set_pointerClick(GameObject value) { }

	// RVA: 0x17D13AC
	RaycastResult get_pointerCurrentRaycast() { }

	// RVA: 0x17D13C8
	void set_pointerCurrentRaycast(RaycastResult value) { }

	// RVA: 0x17D13F8
	RaycastResult get_pointerPressRaycast() { }

	// RVA: 0x17D1414
	void set_pointerPressRaycast(RaycastResult value) { }

	// RVA: 0x17D1444
	bool get_eligibleForClick() { }

	// RVA: 0x17D144C
	void set_eligibleForClick(bool value) { }

	// RVA: 0x17D1454
	int get_displayIndex() { }

	// RVA: 0x17D145C
	void set_displayIndex(int value) { }

	// RVA: 0x17D1464
	int get_pointerId() { }

	// RVA: 0x17D146C
	void set_pointerId(int value) { }

	// RVA: 0x17D1474
	Vector2 get_position() { }

	// RVA: 0x17D1480
	void set_position(Vector2 value) { }

	// RVA: 0x17D148C
	Vector2 get_delta() { }

	// RVA: 0x17D1498
	void set_delta(Vector2 value) { }

	// RVA: 0x17D14A4
	Vector2 get_pressPosition() { }

	// RVA: 0x17D14B0
	void set_pressPosition(Vector2 value) { }

	// RVA: 0x17D14BC
	Vector3 get_worldPosition() { }

	// RVA: 0x17D14CC
	void set_worldPosition(Vector3 value) { }

	// RVA: 0x17D14DC
	Vector3 get_worldNormal() { }

	// RVA: 0x17D14EC
	void set_worldNormal(Vector3 value) { }

	// RVA: 0x17D14FC
	float get_clickTime() { }

	// RVA: 0x17D1504
	void set_clickTime(float value) { }

	// RVA: 0x17D150C
	int get_clickCount() { }

	// RVA: 0x17D1514
	void set_clickCount(int value) { }

	// RVA: 0x17D151C
	Vector2 get_scrollDelta() { }

	// RVA: 0x17D1528
	void set_scrollDelta(Vector2 value) { }

	// RVA: 0x17D1534
	bool get_useDragThreshold() { }

	// RVA: 0x17D153C
	void set_useDragThreshold(bool value) { }

	// RVA: 0x17D1544
	bool get_dragging() { }

	// RVA: 0x17D154C
	void set_dragging(bool value) { }

	// RVA: 0x17D1554
	InputButton get_button() { }

	// RVA: 0x17D155C
	void set_button(InputButton value) { }

	// RVA: 0x17D1564
	float get_pressure() { }

	// RVA: 0x17D156C
	void set_pressure(float value) { }

	// RVA: 0x17D1574
	float get_tangentialPressure() { }

	// RVA: 0x17D157C
	void set_tangentialPressure(float value) { }

	// RVA: 0x17D1584
	float get_altitudeAngle() { }

	// RVA: 0x17D158C
	void set_altitudeAngle(float value) { }

	// RVA: 0x17D1594
	float get_azimuthAngle() { }

	// RVA: 0x17D159C
	void set_azimuthAngle(float value) { }

	// RVA: 0x17D15A4
	float get_twist() { }

	// RVA: 0x17D15AC
	void set_twist(float value) { }

	// RVA: 0x17D15B4
	Vector2 get_tilt() { }

	// RVA: 0x17D15C0
	void set_tilt(Vector2 value) { }

	// RVA: 0x17D15CC
	PenStatus get_penStatus() { }

	// RVA: 0x17D15D4
	void set_penStatus(PenStatus value) { }

	// RVA: 0x17D15DC
	Vector2 get_radius() { }

	// RVA: 0x17D15E8
	void set_radius(Vector2 value) { }

	// RVA: 0x17D15F4
	Vector2 get_radiusVariance() { }

	// RVA: 0x17D1600
	void set_radiusVariance(Vector2 value) { }

	// RVA: 0x17D160C
	bool get_fullyExited() { }

	// RVA: 0x17D1614
	void set_fullyExited(bool value) { }

	// RVA: 0x17D161C
	bool get_reentered() { }

	// RVA: 0x17D1624
	void set_reentered(bool value) { }

	// RVA: 0x17D162C
	void .ctor(EventSystem eventSystem) { }

	// RVA: 0x17D176C
	bool IsPointerMoving() { }

	// RVA: 0x17D178C
	bool IsScrolling() { }

	// RVA: 0x17D17AC
	Camera get_enterEventCamera() { }

	// RVA: 0x17D1870
	Camera get_pressEventCamera() { }

	// RVA: 0x17D1934
	GameObject get_pointerPress() { }

	// RVA: 0x17D193C
	void set_pointerPress(GameObject value) { }

	// RVA: 0x17D1A18
	string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public enum EventHandle 
{
	// Fields
	public int value__; // 0x10
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;
}

// Namespace: UnityEngine.EventSystems
public interface IEventSystemHandler 
{}

// Namespace: UnityEngine.EventSystems
public interface IPointerMoveHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerMove(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerEnter(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerExit(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerDown(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerUp(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPointerClick(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnBeginDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnInitializePotentialDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnEndDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnDrop(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnScroll(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnUpdateSelected(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnSelect(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnDeselect(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnMove(AxisEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnSubmit(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void OnCancel(BaseEventData eventData) { }

}

// Namespace: 
private struct UIToolkitOverrideConfig 
{
	// Fields
	public EventSystem activeEventSystem; // 0x10
	public bool sendEvents; // 0x18
	public bool createPanelGameObjectsOnStart; // 0x19
}

// Namespace: 
private sealed class <>c__DisplayClass56_0 
{
	// Fields
	public GameObject go; // 0x10

	// Methods

	// RVA: 0x17D41A4
	void .ctor() { }

	// RVA: 0x17D4D04
	void <CreateUIToolkitPanelGameObject>b__0() { }

}

// Namespace: UnityEngine.EventSystems
public class EventSystem 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems; // 0x0
	private GameObject m_FirstSelected; // 0x30
	private bool m_sendNavigationEvents; // 0x38
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer; // 0x8
	private static UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	private bool m_Started; // 0x58
	private bool m_IsTrackingUIToolkitPanels; // 0x59

	// Methods

	// RVA: 0x17D27A8
	EventSystem get_current() { }

	// RVA: 0x17D28A4
	void set_current(EventSystem value) { }

	// RVA: 0x17D2A7C
	bool get_sendNavigationEvents() { }

	// RVA: 0x17D2A84
	void set_sendNavigationEvents(bool value) { }

	// RVA: 0x17D2A8C
	int get_pixelDragThreshold() { }

	// RVA: 0x17D2A94
	void set_pixelDragThreshold(int value) { }

	// RVA: 0x17D2A9C
	BaseInputModule get_currentInputModule() { }

	// RVA: 0x17D2AA4
	GameObject get_firstSelectedGameObject() { }

	// RVA: 0x17D2AAC
	void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x17D2AB4
	GameObject get_currentSelectedGameObject() { }

	// RVA: 0x17D2ABC
	GameObject get_lastSelectedGameObject() { }

	// RVA: 0x17D2AC4
	bool get_isFocused() { }

	// RVA: 0x17D2ACC
	void .ctor() { }

	// RVA: 0x17D2B6C
	void UpdateModules() { }

	// RVA: 0x17D2CE0
	bool get_alreadySelecting() { }

	// RVA: 0x17D10D4
	void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x17D2CE8
	BaseEventData get_baseEventDataCache() { }

	// RVA: 0x17CDE14
	void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x17D2D94
	int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x17D3290
	void RaycastAll(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }

	// RVA: 0x17D3510
	bool IsPointerOverGameObject() { }

	// RVA: 0x17D35D4
	bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x17D369C
	bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x17D37DC
	bool get_sendUIToolkitEvents() { }

	// RVA: 0x17D3878
	bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x17D3914
	void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart) { }

	// RVA: 0x17D3AE8
	void StartTrackingUIToolkitPanels() { }

	// RVA: 0x17D40EC
	void StopTrackingUIToolkitPanels() { }

	// RVA: 0x17D3E1C
	void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x17D41AC
	void Start() { }

	// RVA: 0x17D41BC
	void OnEnable() { }

	// RVA: 0x17D4344
	void OnDisable() { }

	// RVA: 0x17D44A8
	void TickModules() { }

	// RVA: 0x17D45DC
	void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x17D45EC
	void Update() { }

	// RVA: 0x17D48D4
	void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x17D4A44
	string ToString() { }

	// RVA: 0x17D4BC4
	void .cctor() { }

}

// Namespace: 
public class TriggerEvent 
{
	// Methods

	// RVA: 0x17D5158
	void .ctor() { }

}

// Namespace: 
public class Entry 
{
	// Fields
	public EventTriggerType eventID; // 0x10
	public TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x17D51AC
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class EventTrigger 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates; // 0x20

	// Methods

	// RVA: 0x17D4D94
	System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }

	// RVA: 0x17D4ECC
	void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x17D4ED4
	void .ctor() { }

	// RVA: 0x17D4E30
	System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }

	// RVA: 0x17D4EDC
	void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x17D4EE4
	void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x17D508C
	void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17D5098
	void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x17D50A4
	void OnDrag(PointerEventData eventData) { }

	// RVA: 0x17D50B0
	void OnDrop(PointerEventData eventData) { }

	// RVA: 0x17D50BC
	void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x17D50C8
	void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x17D50D4
	void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17D50E0
	void OnSelect(BaseEventData eventData) { }

	// RVA: 0x17D50EC
	void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x17D50F8
	void OnScroll(PointerEventData eventData) { }

	// RVA: 0x17D5104
	void OnMove(AxisEventData eventData) { }

	// RVA: 0x17D5110
	void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x17D511C
	void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x17D5128
	void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x17D5134
	void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x17D5140
	void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x17D514C
	void OnCancel(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public enum EventTriggerType 
{
	// Fields
	public int value__; // 0x10
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;
}

// Namespace: 
public sealed class EventFunction<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 handler, BaseEventData eventData) { }

	// RVA: 0x309AF8C
	internal IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x2FE4574
	internal void EndInvoke(IAsyncResult result) { }

}

// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents 
{
	// Fields
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler; // 0x40
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler; // 0x50
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler; // 0x68
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler; // 0x78
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler; // 0x88
	private static readonly System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList; // 0x90

	// Methods

	// RVA: 0x309AF8C
	T ValidateEventData(BaseEventData data) { }

	// RVA: 0x17D5258
	void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5374
	void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5490
	void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D55AC
	void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D56C8
	void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D57E4
	void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5900
	void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5A1C
	void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5B38
	void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5C54
	void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5D70
	void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5E8C
	void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D5FA8
	void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D6058
	void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D6108
	void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D61B8
	void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D62D4
	void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D6384
	void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x17D6434
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x17D64B0
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x17D652C
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x17D65A8
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x17D6624
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x17D66A0
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x17D671C
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x17D6798
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x17D6814
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }

	// RVA: 0x17D6890
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x17D690C
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }

	// RVA: 0x17D6988
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }

	// RVA: 0x17D6A04
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x17D6A80
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }

	// RVA: 0x17D6AFC
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x17D6B78
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }

	// RVA: 0x17D6BF4
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }

	// RVA: 0x17D6C70
	UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }

	// RVA: 0x17D6CEC
	void GetEventChain(GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }

	// RVA: 0x2FE5B20
	bool Execute(GameObject target, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }

	// RVA: 0x2FE72C0
	GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }

	// RVA: 0x2FE5724
	bool ShouldSendToComponent(Component component) { }

	// RVA: 0x2FEAB7C
	void GetEventList(GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }

	// RVA: 0x2FE5724
	bool CanHandleEvent(GameObject go) { }

	// RVA: 0x2FE7084
	GameObject GetEventHandler(GameObject root) { }

	// RVA: 0x17D6ED4
	void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseInput 
{
	// Methods

	// RVA: 0x17D75BC
	string get_compositionString() { }

	// RVA: 0x17D75C4
	IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x17D75CC
	void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x17D75D8
	Vector2 get_compositionCursorPos() { }

	// RVA: 0x17D75E0
	void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x17D75E8
	bool get_mousePresent() { }

	// RVA: 0x17D75F0
	bool GetMouseButtonDown(int button) { }

	// RVA: 0x17D75FC
	bool GetMouseButtonUp(int button) { }

	// RVA: 0x17D7608
	bool GetMouseButton(int button) { }

	// RVA: 0x17D7614
	Vector2 get_mousePosition() { }

	// RVA: 0x17D761C
	Vector2 get_mouseScrollDelta() { }

	// RVA: 0x17D7624
	bool get_touchSupported() { }

	// RVA: 0x17D762C
	int get_touchCount() { }

	// RVA: 0x17D7634
	Touch GetTouch(int index) { }

	// RVA: 0x17D7688
	float GetAxisRaw(string axisName) { }

	// RVA: 0x17D7694
	bool GetButtonDown(string buttonName) { }

	// RVA: 0x17D76A0
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class BaseInputModule 
{
	// Fields
	protected System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache; // 0x20
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Methods

	// RVA: 0x17D76A8
	bool get_sendPointerHoverToParent() { }

	// RVA: 0x17D76B0
	void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x17D76B8
	BaseInput get_input() { }

	// RVA: 0x17D7950
	BaseInput get_inputOverride() { }

	// RVA: 0x17D7958
	void set_inputOverride(BaseInput value) { }

	// RVA: 0x17D7960
	EventSystem get_eventSystem() { }

	// RVA: 0x17D7968
	void OnEnable() { }

	// RVA: 0x17D79EC
	void OnDisable() { }

	// RVA: 0x2FE41A8
	void Process() { }

	// RVA: 0x17D7A08
	RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }

	// RVA: 0x17D7B30
	MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x17D7B84
	MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x17D7BD0
	GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x17D7DC8
	void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x17D8A84
	AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x17D8BDC
	BaseEventData GetBaseEventData() { }

	// RVA: 0x17D8C88
	bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x17D8C90
	bool ShouldActivateModule() { }

	// RVA: 0x17D8CDC
	void DeactivateModule() { }

	// RVA: 0x17D8CE0
	void ActivateModule() { }

	// RVA: 0x17D8CE4
	void UpdateModule() { }

	// RVA: 0x17D8CE8
	bool IsModuleSupported() { }

	// RVA: 0x17D8CF0
	int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x17D8D9C
	void .ctor() { }

}

// Namespace: 
protected class ButtonState 
{
	// Fields
	private InputButton m_Button; // 0x10
	private MouseButtonEventData m_EventData; // 0x18

	// Methods

	// RVA: 0x17DAA64
	MouseButtonEventData get_eventData() { }

	// RVA: 0x17DAA6C
	void set_eventData(MouseButtonEventData value) { }

	// RVA: 0x17DAA74
	InputButton get_button() { }

	// RVA: 0x17DAA7C
	void set_button(InputButton value) { }

	// RVA: 0x17DAA84
	void .ctor() { }

}

// Namespace: 
protected class MouseState 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x17DAA8C
	bool AnyPressesThisFrame() { }

	// RVA: 0x17DAB78
	bool AnyReleasesThisFrame() { }

	// RVA: 0x17DAC6C
	ButtonState GetButtonState(InputButton button) { }

	// RVA: 0x17D99B4
	void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x17DA9D8
	void .ctor() { }

}

// Namespace: 
public class MouseButtonEventData 
{
	// Fields
	public FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x17DAB68
	bool PressedThisFrame() { }

	// RVA: 0x17DAC58
	bool ReleasedThisFrame() { }

	// RVA: 0x17DADE4
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule 
{
	// Fields
	public const int kMouseLeftId = 4294967295;
	public const int kMouseRightId = 4294967294;
	public const int kMouseMiddleId = 4294967293;
	public const int kFakeTouchesId = 4294967292;
	protected System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData> m_PointerData; // 0x58
	private readonly MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x17D8E30
	bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x17D8F3C
	void RemovePointerData(PointerEventData data) { }

	// RVA: 0x17D8FB8
	PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x17D9398
	void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x17D9464
	FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x17D94EC
	MouseState GetMousePointerEventData() { }

	// RVA: 0x17D9500
	MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x17D99F4
	PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x17D9A8C
	bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x17D9ABC
	void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x17D9B04
	void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x17D9F0C
	bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x17DA024
	void ClearSelection() { }

	// RVA: 0x17DA260
	string ToString() { }

	// RVA: 0x17DA704
	void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x17DA840
	void .ctor() { }

}

// Namespace: 
public enum InputMode 
{
	// Fields
	public int value__; // 0x10
	public const InputMode Mouse = 0;
	public const InputMode Buttons = 1;
}

// Namespace: UnityEngine.EventSystems
public class StandaloneInputModule 
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private PointerEventData m_InputPointerEvent; // 0x90
	private const float doubleClickTime = 1050253722;
	private string m_HorizontalAxis; // 0x98
	private string m_VerticalAxis; // 0xA0
	private string m_SubmitButton; // 0xA8
	private string m_CancelButton; // 0xB0
	private float m_InputActionsPerSecond; // 0xB8
	private float m_RepeatDelay; // 0xBC
	private bool m_ForceModuleActive; // 0xC0

	// Methods

	// RVA: 0x17DADEC
	void .ctor() { }

	// RVA: 0x17DAECC
	InputMode get_inputMode() { }

	// RVA: 0x17DAED4
	bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x17DAEDC
	void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x17DAEE4
	bool get_forceModuleActive() { }

	// RVA: 0x17DAEEC
	void set_forceModuleActive(bool value) { }

	// RVA: 0x17DAEF4
	float get_inputActionsPerSecond() { }

	// RVA: 0x17DAEFC
	void set_inputActionsPerSecond(float value) { }

	// RVA: 0x17DAF04
	float get_repeatDelay() { }

	// RVA: 0x17DAF0C
	void set_repeatDelay(float value) { }

	// RVA: 0x17DAF14
	string get_horizontalAxis() { }

	// RVA: 0x17DAF1C
	void set_horizontalAxis(string value) { }

	// RVA: 0x17DAF24
	string get_verticalAxis() { }

	// RVA: 0x17DAF2C
	void set_verticalAxis(string value) { }

	// RVA: 0x17DAF34
	string get_submitButton() { }

	// RVA: 0x17DAF3C
	void set_submitButton(string value) { }

	// RVA: 0x17DAF44
	string get_cancelButton() { }

	// RVA: 0x17DAF4C
	void set_cancelButton(string value) { }

	// RVA: 0x17DAF54
	bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x17DAF5C
	void UpdateModule() { }

	// RVA: 0x17DB068
	void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x17DB560
	bool ShouldActivateModule() { }

	// RVA: 0x17DB7BC
	void ActivateModule() { }

	// RVA: 0x17DB8E8
	void DeactivateModule() { }

	// RVA: 0x17DB8EC
	void Process() { }

	// RVA: 0x17DBB0C
	bool ProcessTouchEvents() { }

	// RVA: 0x17DC200
	void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x17DBF90
	bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x17DCBD4
	Vector2 GetRawMoveVector() { }

	// RVA: 0x17DBCDC
	bool SendMoveEventToSelectedObject() { }

	// RVA: 0x17DBCD4
	void ProcessMouseEvent() { }

	// RVA: 0x17DCFB4
	bool ForceAutoSelect() { }

	// RVA: 0x17DCCE4
	void ProcessMouseEvent(int id) { }

	// RVA: 0x17DB990
	bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x17DCFBC
	void ProcessMousePress(MouseButtonEventData data) { }

	// RVA: 0x17DD4B4
	GameObject GetCurrentFocusedGameObject() { }

}

// Namespace: UnityEngine.EventSystems
public class TouchInputModule 
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	private bool m_ForceModuleActive; // 0x80

	// Methods

	// RVA: 0x17DD4BC
	void .ctor() { }

	// RVA: 0x17DD4C0
	bool get_allowActivationOnStandalone() { }

	// RVA: 0x17DD4C8
	void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x17DD4D0
	bool get_forceModuleActive() { }

	// RVA: 0x17DD4D8
	void set_forceModuleActive(bool value) { }

	// RVA: 0x17DD4E0
	void UpdateModule() { }

	// RVA: 0x17DD680
	bool IsModuleSupported() { }

	// RVA: 0x17DD6BC
	bool ShouldActivateModule() { }

	// RVA: 0x17DD7A0
	bool UseFakeInput() { }

	// RVA: 0x17DD7D0
	void Process() { }

	// RVA: 0x17DD820
	void FakeTouches() { }

	// RVA: 0x17DD94C
	void ProcessTouchEvents() { }

	// RVA: 0x17DDAF4
	void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x17DE4B4
	void DeactivateModule() { }

	// RVA: 0x17DE4B8
	string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public enum MoveDirection 
{
	// Fields
	public int value__; // 0x10
	public const MoveDirection Left = 0;
	public const MoveDirection Up = 1;
	public const MoveDirection Right = 2;
	public const MoveDirection Down = 3;
	public const MoveDirection None = 4;
}

// Namespace: UnityEngine.EventSystems
public static class RaycasterManager 
{
	// Fields
	private static readonly System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters; // 0x0

	// Methods

	// RVA: 0x17DE7FC
	void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x17DE8F8
	System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }

	// RVA: 0x17DE974
	void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x17DEA70
	void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster 
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Methods

	// RVA: 0x2FE47D4
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x2FE360C
	Camera get_eventCamera() { }

	// RVA: 0x17DEB0C
	int get_priority() { }

	// RVA: 0x17DEB14
	int get_sortOrderPriority() { }

	// RVA: 0x17DEB1C
	int get_renderOrderPriority() { }

	// RVA: 0x17D3184
	BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x17DEB24
	string ToString() { }

	// RVA: 0x17DED94
	void OnEnable() { }

	// RVA: 0x17DEE14
	void OnDisable() { }

	// RVA: 0x17DEE94
	void OnCanvasHierarchyChanged() { }

	// RVA: 0x17DEEA4
	void OnTransformParentChanged() { }

	// RVA: 0x17D0F7C
	void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class Physics2DRaycaster 
{
	// Methods

	// RVA: 0x17DEEB4
	void .ctor() { }

	// RVA: 0x17DEF1C
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: 
private class RaycastHitComparer 
{
	// Fields
	public static RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x17DF918
	int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x17DF964
	void .ctor() { }

	// RVA: 0x17DF96C
	void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class PhysicsRaycaster 
{
	// Fields
	protected const int kNoEventMaskSet = 4294967295;
	protected Camera m_EventCamera; // 0x28
	protected LayerMask m_EventMask; // 0x30
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38
	private RaycastHit[] m_Hits; // 0x40

	// Methods

	// RVA: 0x17DEEE8
	void .ctor() { }

	// RVA: 0x17DEF20
	Camera get_eventCamera() { }

	// RVA: 0x17DF068
	int get_depth() { }

	// RVA: 0x17DF154
	int get_finalEventMask() { }

	// RVA: 0x17DF23C
	LayerMask get_eventMask() { }

	// RVA: 0x17DF244
	void set_eventMask(LayerMask value) { }

	// RVA: 0x17DF24C
	int get_maxRayIntersections() { }

	// RVA: 0x17DF254
	void set_maxRayIntersections(int value) { }

	// RVA: 0x17DF25C
	bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x17DF564
	void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: UnityEngine.EventSystems
public struct RaycastResult 
{
	// Fields
	private GameObject m_GameObject; // 0x10
	public BaseRaycaster module; // 0x18
	public float distance; // 0x20
	public float index; // 0x24
	public int depth; // 0x28
	public int sortingGroupID; // 0x2C
	public int sortingGroupOrder; // 0x30
	public int sortingLayer; // 0x34
	public int sortingOrder; // 0x38
	public Vector3 worldPosition; // 0x3C
	public Vector3 worldNormal; // 0x48
	public Vector2 screenPosition; // 0x54
	public int displayIndex; // 0x5C

	// Methods

	// RVA: 0x17DF9D8
	GameObject get_gameObject() { }

	// RVA: 0x17DF9E0
	void set_gameObject(GameObject value) { }

	// RVA: 0x17DF9E8
	bool get_isValid() { }

	// RVA: 0x17DFAB0
	void Clear() { }

	// RVA: 0x17D212C
	string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour 
{
	// Methods

	// RVA: 0x17DFB7C
	void Awake() { }

	// RVA: 0x17CDC38
	void OnEnable() { }

	// RVA: 0x17D41B8
	void Start() { }

	// RVA: 0x17CDC40
	void OnDisable() { }

	// RVA: 0x17DFB80
	void OnDestroy() { }

	// RVA: 0x17DFB84
	bool IsActive() { }

	// RVA: 0x17DFB8C
	void OnRectTransformDimensionsChange() { }

	// RVA: 0x17DFB90
	void OnBeforeTransformParentChanged() { }

	// RVA: 0x17DEEB0
	void OnTransformParentChanged() { }

	// RVA: 0x17DFB94
	void OnDidApplyAnimationProperties() { }

	// RVA: 0x17DFB98
	void OnCanvasGroupChanged() { }

	// RVA: 0x17DEEA0
	void OnCanvasHierarchyChanged() { }

	// RVA: 0x17DFB9C
	bool IsDestroyed() { }

	// RVA: 0x17D03F4
	void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=12 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5527 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=7141 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x0
	internal static readonly __StaticArrayInitTypeSize=5527 7C777EEED2359F9E03B1E9BA3FE7218E75A8BA42A33894ABBE8BB2022DDED720; // 0xC
	internal static readonly __StaticArrayInitTypeSize=7141 F8E13B9278EE691BEBE612B17CB7B9E4D3E7E27D94AF464B25288A45134C990D; // 0x15A3
}


