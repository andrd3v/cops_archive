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

	// RVA: 0x1718D7C
	private static MonoScriptData Get() { }

	// RVA: 0x1718E80
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	private string m_NormalTrigger; // 0x10
	private string m_HighlightedTrigger; // 0x18
	private string m_PressedTrigger; // 0x20
	private string m_SelectedTrigger; // 0x28
	private string m_DisabledTrigger; // 0x30

	// Methods

	// RVA: 0x1718E88
	public string get_normalTrigger() { }

	// RVA: 0x1718E90
	public void set_normalTrigger(string value) { }

	// RVA: 0x1718E98
	public string get_highlightedTrigger() { }

	// RVA: 0x1718EA0
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x1718EA8
	public string get_pressedTrigger() { }

	// RVA: 0x1718EB0
	public void set_pressedTrigger(string value) { }

	// RVA: 0x1718EB8
	public string get_selectedTrigger() { }

	// RVA: 0x1718EC0
	public void set_selectedTrigger(string value) { }

	// RVA: 0x1718EC8
	public string get_disabledTrigger() { }

	// RVA: 0x1718ED0
	public void set_disabledTrigger(string value) { }

	// RVA: 0x1718ED8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ButtonClickedEvent
{
	// Methods

	// RVA: 0x1719090
	public void .ctor() { }

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

	// RVA: 0x17193BC
	public void .ctor(int <>1__state) { }

	// RVA: 0x17193E8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17193EC
	private bool MoveNext() { }

	// RVA: 0x1719500
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1719508
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1719548
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Button
{
	// Fields
	private ButtonClickedEvent m_OnClick; // 0x100

	// Methods

	// RVA: 0x1718FDC
	protected void .ctor() { }

	// RVA: 0x1719098
	public ButtonClickedEvent get_onClick() { }

	// RVA: 0x17190A0
	public void set_onClick(ButtonClickedEvent value) { }

	// RVA: 0x17190B0
	private void Press() { }

	// RVA: 0x171914C
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17191F4
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1719344
	private IEnumerator OnFinishSubmit() { }

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

	// RVA: -1
	public abstract void Rebuild(CanvasUpdate executing) { }

	// RVA: -1
	public abstract Transform get_transform() { }

	// RVA: -1
	public abstract void LayoutComplete() { }

	// RVA: -1
	public abstract void GraphicUpdateComplete() { }

	// RVA: -1
	public abstract bool IsDestroyed() { }

}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction; // 0x8

	// Methods

	// RVA: 0x1719550
	protected void .ctor() { }

	// RVA: 0x1719794
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x171987C
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x1719980
	private void CleanInvalidItems() { }

	// RVA: 0x1719C94
	private void PerformUpdate() { }

	// RVA: 0x171A898
	private static int ParentCount(Transform child) { }

	// RVA: 0x171A97C
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x171AAE0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x171AC84
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x171ABDC
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x171AD84
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x171AEE0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x171AE04
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x171AF60
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x171B304
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x171AFF4
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x171B17C
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x171B398
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x171B520
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x171B6A8
	public static bool IsRebuildingLayout() { }

	// RVA: 0x171B71C
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x171B790
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
[Serializable]
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

	// RVA: 0x171B82C
	public Color get_normalColor() { }

	// RVA: 0x171B838
	public void set_normalColor(Color value) { }

	// RVA: 0x171B844
	public Color get_highlightedColor() { }

	// RVA: 0x171B850
	public void set_highlightedColor(Color value) { }

	// RVA: 0x171B85C
	public Color get_pressedColor() { }

	// RVA: 0x171B868
	public void set_pressedColor(Color value) { }

	// RVA: 0x171B874
	public Color get_selectedColor() { }

	// RVA: 0x171B880
	public void set_selectedColor(Color value) { }

	// RVA: 0x171B88C
	public Color get_disabledColor() { }

	// RVA: 0x171B898
	public void set_disabledColor(Color value) { }

	// RVA: 0x171B8A4
	public float get_colorMultiplier() { }

	// RVA: 0x171B8AC
	public void set_colorMultiplier(float value) { }

	// RVA: 0x171B8B4
	public float get_fadeDuration() { }

	// RVA: 0x171B8BC
	public void set_fadeDuration(float value) { }

	// RVA: 0x171B8C4
	private static void .cctor() { }

	// RVA: 0x171B940
	public override bool Equals(object obj) { }

	// RVA: 0x171BA38
	public bool Equals(ColorBlock other) { }

	// RVA: 0x171BC6C
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x171BD20
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x171BDD8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UI
public class ClipperRegistry
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers; // 0x10

	// Methods

	// RVA: 0x171BE60
	protected void .ctor() { }

	// RVA: 0x171A638
	public static ClipperRegistry get_instance() { }

	// RVA: 0x171A760
	public void Cull() { }

	// RVA: 0x171BEEC
	public static void Register(IClipper c) { }

	// RVA: 0x171BF60
	public static void Unregister(IClipper c) { }

	// RVA: 0x171BFC0
	public static void Disable(IClipper c) { }

}

// Namespace: UnityEngine.UI
public static class Clipping
{
	// Methods

	// RVA: 0x171C020
	public static Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, bool validRect) { }

}

// Namespace: UnityEngine.UI
public interface IClipper
{
	// Methods

	// RVA: -1
	public abstract void PerformClipping() { }

}

// Namespace: UnityEngine.UI
public interface IClippable
{
	// Methods

	// RVA: -1
	public abstract GameObject get_gameObject() { }

	// RVA: -1
	public abstract void RecalculateClipping() { }

	// RVA: -1
	public abstract RectTransform get_rectTransform() { }

	// RVA: -1
	public abstract void Cull(Rect clipRect, bool validRect) { }

	// RVA: -1
	public abstract void SetClipRect(Rect value, bool validRect) { }

	// RVA: -1
	public abstract void SetClipSoftness(Vector2 clipSoftness) { }

}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x171C22C
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x171C450
	public void .ctor() { }

}

// Namespace: 
public interface IFactoryControls
{
	// Methods

	// RVA: -1
	public abstract GameObject CreateGameObject(string name, Type[] components) { }

}

// Namespace: 
private class DefaultRuntimeFactory
{
	// Fields
	public static IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x17219B8
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x1721A28
	public void .ctor() { }

	// RVA: 0x1721A30
	private static void .cctor() { }

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
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Methods

	// RVA: 0x171C4DC
	public static IFactoryControls get_factory() { }

	// RVA: 0x171C558
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x171C718
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x171C9B4
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x171CAC0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x171C87C
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x171CB24
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x171CC18
	public static GameObject CreatePanel(Resources resources) { }

	// RVA: 0x171D3C0
	public static GameObject CreateButton(Resources resources) { }

	// RVA: 0x171D880
	public static GameObject CreateText(Resources resources) { }

	// RVA: 0x171DA3C
	public static GameObject CreateImage(Resources resources) { }

	// RVA: 0x171DB84
	public static GameObject CreateRawImage(Resources resources) { }

	// RVA: 0x171DCCC
	public static GameObject CreateSlider(Resources resources) { }

	// RVA: 0x171E4DC
	public static GameObject CreateScrollbar(Resources resources) { }

	// RVA: 0x171EA74
	public static GameObject CreateToggle(Resources resources) { }

	// RVA: 0x171F10C
	public static GameObject CreateInputField(Resources resources) { }

	// RVA: 0x171F7FC
	public static GameObject CreateDropdown(Resources resources) { }

	// RVA: 0x1720EFC
	public static GameObject CreateScrollView(Resources resources) { }

	// RVA: 0x17218F4
	private static void .cctor() { }

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

	// RVA: 0x17250EC
	public Text get_text() { }

	// RVA: 0x17250F4
	public void set_text(Text value) { }

	// RVA: 0x17250FC
	public Image get_image() { }

	// RVA: 0x1725104
	public void set_image(Image value) { }

	// RVA: 0x172510C
	public RectTransform get_rectTransform() { }

	// RVA: 0x1725114
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x172511C
	public Toggle get_toggle() { }

	// RVA: 0x1725124
	public void set_toggle(Toggle value) { }

	// RVA: 0x172512C
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17251B4
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1725284
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class OptionData
{
	// Fields
	private string m_Text; // 0x10
	private Sprite m_Image; // 0x18

	// Methods

	// RVA: 0x172528C
	public string get_text() { }

	// RVA: 0x1725294
	public void set_text(string value) { }

	// RVA: 0x172529C
	public Sprite get_image() { }

	// RVA: 0x17252A4
	public void set_image(Sprite value) { }

	// RVA: 0x1720CA4
	public void .ctor() { }

	// RVA: 0x1722624
	public void .ctor(string text) { }

	// RVA: 0x1722784
	public void .ctor(Sprite image) { }

	// RVA: 0x17252AC
	public void .ctor(string text, Sprite image) { }

}

// Namespace: 
[Serializable]
public class OptionDataList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options; // 0x10

	// Methods

	// RVA: 0x17252FC
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x1725304
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x1721ECC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DropdownEvent
{
	// Methods

	// RVA: 0x1721F58
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass63_0
{
	// Fields
	public DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1724100
	public void .ctor() { }

	// RVA: 0x172530C
	internal void <Show>b__0(bool x) { }

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

	// RVA: 0x1724F08
	public void .ctor(int <>1__state) { }

	// RVA: 0x1725334
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1725338
	private bool MoveNext() { }

	// RVA: 0x17253FC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1725404
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1725444
	private object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x1721A9C
	public RectTransform get_template() { }

	// RVA: 0x1720C00
	public void set_template(RectTransform value) { }

	// RVA: 0x1721AA4
	public Text get_captionText() { }

	// RVA: 0x1720C2C
	public void set_captionText(Text value) { }

	// RVA: 0x1721AAC
	public Image get_captionImage() { }

	// RVA: 0x1721AB4
	public void set_captionImage(Image value) { }

	// RVA: 0x1721AE0
	public Text get_itemText() { }

	// RVA: 0x1720C58
	public void set_itemText(Text value) { }

	// RVA: 0x1721AE8
	public Image get_itemImage() { }

	// RVA: 0x1721AF0
	public void set_itemImage(Image value) { }

	// RVA: 0x1720C84
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x1721B1C
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x1721B50
	public DropdownEvent get_onValueChanged() { }

	// RVA: 0x1721B58
	public void set_onValueChanged(DropdownEvent value) { }

	// RVA: 0x1721B68
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1721B70
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1721B78
	public int get_value() { }

	// RVA: 0x1721B80
	public void set_value(int value) { }

	// RVA: 0x1721CF8
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1721B88
	private void Set(int value, bool sendCallback) { }

	// RVA: 0x1721D00
	protected void .ctor() { }

	// RVA: 0x1721FAC
	protected override void Awake() { }

	// RVA: 0x17220EC
	protected override void Start() { }

	// RVA: 0x17221A4
	protected override void OnDisable() { }

	// RVA: 0x1720CAC
	public void RefreshShownValue() { }

	// RVA: 0x1722484
	public void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }

	// RVA: 0x17224F8
	public void AddOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x1722658
	public void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }

	// RVA: 0x17227B8
	public void ClearOptions() { }

	// RVA: 0x1722874
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: 0x318DB98
	private static T GetOrAddComponent(GameObject go) { }

	// RVA: 0x1722FB8
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1723EE8
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1723EEC
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1722FBC
	public void Show() { }

	// RVA: 0x172452C
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1724A90
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1724B18
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1724BBC
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1724C44
	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) { }

	// RVA: 0x1724CE8
	protected virtual void DestroyItem(DropdownItem item) { }

	// RVA: 0x1724108
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }

	// RVA: 0x1724CEC
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1724420
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1724D84
	private void SetAlpha(float alpha) { }

	// RVA: 0x1723EF0
	public void Hide() { }

	// RVA: 0x1724E80
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x172226C
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1724F34
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1725064
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
[Serializable]
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

	// RVA: 0x172544C
	public static FontData get_defaultFontData() { }

	// RVA: 0x17254E8
	public Font get_font() { }

	// RVA: 0x17254F0
	public void set_font(Font value) { }

	// RVA: 0x17254F8
	public int get_fontSize() { }

	// RVA: 0x1725500
	public void set_fontSize(int value) { }

	// RVA: 0x1725508
	public FontStyle get_fontStyle() { }

	// RVA: 0x1725510
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1725518
	public bool get_bestFit() { }

	// RVA: 0x1725520
	public void set_bestFit(bool value) { }

	// RVA: 0x1725528
	public int get_minSize() { }

	// RVA: 0x1725530
	public void set_minSize(int value) { }

	// RVA: 0x1725538
	public int get_maxSize() { }

	// RVA: 0x1725540
	public void set_maxSize(int value) { }

	// RVA: 0x1725548
	public TextAnchor get_alignment() { }

	// RVA: 0x1725550
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1725558
	public bool get_alignByGeometry() { }

	// RVA: 0x1725560
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1725568
	public bool get_richText() { }

	// RVA: 0x1725570
	public void set_richText(bool value) { }

	// RVA: 0x1725578
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1725580
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1725588
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1725590
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1725598
	public float get_lineSpacing() { }

	// RVA: 0x17255A0
	public void set_lineSpacing(float value) { }

	// RVA: 0x17255A8
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x17255AC
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x17254E0
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x17255F0
	public static void TrackText(Text t) { }

	// RVA: 0x1725868
	private static void RebuildForFont(Font f) { }

	// RVA: 0x1725AA4
	public static void UntrackText(Text t) { }

	// RVA: 0x1725CDC
	private static void .cctor() { }

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

	// RVA: 0x1725D78
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x1725EC8
	public virtual Color get_color() { }

	// RVA: 0x1725ED4
	public virtual void set_color(Color value) { }

	// RVA: 0x1725F1C
	public virtual bool get_raycastTarget() { }

	// RVA: 0x1725F24
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x1726608
	public Vector4 get_raycastPadding() { }

	// RVA: 0x1726614
	public void set_raycastPadding(Vector4 value) { }

	// RVA: 0x1726620
	protected bool get_useLegacyMeshGeneration() { }

	// RVA: 0x1726628
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x1726630
	protected void .ctor() { }

	// RVA: 0x1726708
	public virtual void SetAllDirty() { }

	// RVA: 0x17269A0
	public virtual void SetLayoutDirty() { }

	// RVA: 0x1726B64
	public virtual void SetVerticesDirty() { }

	// RVA: 0x1726C64
	public virtual void SetMaterialDirty() { }

	// RVA: 0x1726788
	public void SetRaycastDirty() { }

	// RVA: 0x1726D64
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1726E74
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x172723C
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1727764
	public int get_depth() { }

	// RVA: 0x1726ACC
	public RectTransform get_rectTransform() { }

	// RVA: 0x1726120
	public Canvas get_canvas() { }

	// RVA: 0x172735C
	private void CacheCanvas() { }

	// RVA: 0x1727784
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1727858
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x17278C0
	public virtual Material get_material() { }

	// RVA: 0x172797C
	public virtual void set_material(Material value) { }

	// RVA: 0x1727A5C
	public virtual Material get_materialForRendering() { }

	// RVA: 0x1727C40
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1727CBC
	protected override void OnEnable() { }

	// RVA: 0x1727E98
	protected override void OnDisable() { }

	// RVA: 0x17282F4
	protected override void OnDestroy() { }

	// RVA: 0x17284C8
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17286B8
	public virtual void OnCullingChanged() { }

	// RVA: 0x17287AC
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x17288CC
	public virtual void LayoutComplete() { }

	// RVA: 0x17288D0
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x17288D4
	protected virtual void UpdateMaterial() { }

	// RVA: 0x1728990
	protected virtual void UpdateGeometry() { }

	// RVA: 0x1728E28
	private void DoMeshGeneration() { }

	// RVA: 0x17289A0
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x1729314
	protected static Mesh get_workerMesh() { }

	// RVA: 0x17294AC
	protected virtual void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }

	// RVA: 0x17294B0
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x172954C
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1729B40
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1729B50
	public virtual void SetNativeSize() { }

	// RVA: 0x1729B54
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x172A0B8
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x17296AC
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x172A488
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x172A49C
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x172A70C
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x172A720
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x172A7C0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x172A874
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x172A928
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x172A9DC
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x172AA90
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x172AB44
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x172ABF8
	private static void .cctor() { }

	// RVA: 0x172ACA8
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

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
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UI.GraphicRaycaster.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UI.Graphic> <>9__27_0; // 0x8

	// Methods

	// RVA: 0x172C2C0
	private static void .cctor() { }

	// RVA: 0x172C32C
	public void .ctor() { }

	// RVA: 0x172C334
	internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }

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

	// RVA: 0x172ACB0
	public override int get_sortOrderPriority() { }

	// RVA: 0x172AE00
	public override int get_renderOrderPriority() { }

	// RVA: 0x172AE64
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x172AE6C
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x172AE74
	public BlockingObjects get_blockingObjects() { }

	// RVA: 0x172AE7C
	public void set_blockingObjects(BlockingObjects value) { }

	// RVA: 0x172AE84
	public LayerMask get_blockingMask() { }

	// RVA: 0x172AE8C
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x172AE94
	protected void .ctor() { }

	// RVA: 0x172AD08
	private Canvas get_canvas() { }

	// RVA: 0x172AF38
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x172C150
	public override Camera get_eventCamera() { }

	// RVA: 0x172BAF0
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }

	// RVA: 0x172C224
	private static void .cctor() { }

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

	// RVA: 0x172C3A0
	protected void .ctor() { }

	// RVA: 0x172C564
	public static GraphicRegistry get_instance() { }

	// RVA: 0x172751C
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17263B0
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x172703C
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17261D8
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1728120
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x172C64C
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x172C810
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x172BA0C
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x172C8F4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
internal interface IGraphicEnabledDisabled
{
	// Methods

	// RVA: -1
	public abstract void OnSiblingGraphicEnabledDisabled() { }

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

	// RVA: 0x172C988
	public Sprite get_sprite() { }

	// RVA: 0x171CF48
	public void set_sprite(Sprite value) { }

	// RVA: 0x172CC20
	public void DisableSpriteOptimizations() { }

	// RVA: 0x172CC28
	public Sprite get_overrideSprite() { }

	// RVA: 0x172CD30
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x172CCAC
	private Sprite get_activeSprite() { }

	// RVA: 0x172CDBC
	public Type get_type() { }

	// RVA: 0x171D310
	public void set_type(Type value) { }

	// RVA: 0x172CDC4
	public bool get_preserveAspect() { }

	// RVA: 0x172CDCC
	public void set_preserveAspect(bool value) { }

	// RVA: 0x172CE7C
	public bool get_fillCenter() { }

	// RVA: 0x172CE84
	public void set_fillCenter(bool value) { }

	// RVA: 0x172CF34
	public FillMethod get_fillMethod() { }

	// RVA: 0x172CF3C
	public void set_fillMethod(FillMethod value) { }

	// RVA: 0x172CFF0
	public float get_fillAmount() { }

	// RVA: 0x172CFF8
	public void set_fillAmount(float value) { }

	// RVA: 0x172D09C
	public bool get_fillClockwise() { }

	// RVA: 0x172D0A4
	public void set_fillClockwise(bool value) { }

	// RVA: 0x172D154
	public int get_fillOrigin() { }

	// RVA: 0x172D15C
	public void set_fillOrigin(int value) { }

	// RVA: 0x172D20C
	public float get_eventAlphaThreshold() { }

	// RVA: 0x172D21C
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x172D398
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x172D228
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x172D3A0
	public bool get_useSpriteMesh() { }

	// RVA: 0x172D3A8
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x172D458
	protected void .ctor() { }

	// RVA: 0x172D4A4
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x172D5F4
	public override Texture get_mainTexture() { }

	// RVA: 0x172D888
	public bool get_hasBorder() { }

	// RVA: 0x172DA34
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x172DA3C
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x172DA64
	public float get_pixelsPerUnit() { }

	// RVA: 0x172DD34
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x172DD5C
	public override Material get_material() { }

	// RVA: 0x172DF9C
	public override void set_material(Material value) { }

	// RVA: 0x172E07C
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x172E080
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x172E0D4
	private void PreserveSpriteAspectRatio(Rect rect, Vector2 spriteSize) { }

	// RVA: 0x172E238
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x172E808
	public override void SetNativeSize() { }

	// RVA: 0x172EB58
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x172CA24
	private void TrackSprite() { }

	// RVA: 0x1731C18
	protected override void OnEnable() { }

	// RVA: 0x1731C40
	protected override void OnDisable() { }

	// RVA: 0x1731DE8
	protected override void UpdateMaterial() { }

	// RVA: 0x1731FC4
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x172ED24
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x172F0A0
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x172F604
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x172FE78
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x17324EC
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x173238C
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x1732260
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x1730FA8
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x1732664
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x17327B4
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x1732BBC
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1732BC0
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1732BC4
	public virtual float get_minWidth() { }

	// RVA: 0x1732BCC
	public virtual float get_preferredWidth() { }

	// RVA: 0x1732DE0
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1732DE8
	public virtual float get_minHeight() { }

	// RVA: 0x1732DF0
	public virtual float get_preferredHeight() { }

	// RVA: 0x1733004
	public virtual float get_flexibleHeight() { }

	// RVA: 0x173300C
	public virtual int get_layoutPriority() { }

	// RVA: 0x1733014
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1733684
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x17339E0
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1731ABC
	private static void TrackImage(Image g) { }

	// RVA: 0x1731D44
	private static void UnTrackImage(Image g) { }

	// RVA: 0x1733C88
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1733CCC
	private static void .cctor() { }

	// RVA: 0x172C990
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	// RVA: 0x1733E2C
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }

}

// Namespace: UnityEngine.UI
public interface IMask
{
	// Methods

	// RVA: -1
	public abstract bool Enabled() { }

	// RVA: -1
	public abstract RectTransform get_rectTransform() { }

}

// Namespace: UnityEngine.UI
public interface IMaskable
{
	// Methods

	// RVA: -1
	public abstract void RecalculateMasking() { }

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

	// RVA: 0x18B391C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18BF2E0
	public virtual Char Invoke(string text, int charIndex, Char addedChar) { }

	// RVA: 0x18BF2F4
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, Char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x18BF3E8
	public virtual Char EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class SubmitEvent
{
	// Methods

	// RVA: 0x18B2FC0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class EndEditEvent
{
	// Methods

	// RVA: 0x18B3014
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class OnChangeEvent
{
	// Methods

	// RVA: 0x18B3068
	public void .ctor() { }

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

	// RVA: 0x18B6024
	public void .ctor(int <>1__state) { }

	// RVA: 0x18BF414
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18BF418
	private bool MoveNext() { }

	// RVA: 0x18BF5A0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18BF5A8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18BF5E8
	private object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x18B91C4
	public void .ctor(int <>1__state) { }

	// RVA: 0x18BF5F0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18BF5F4
	private bool MoveNext() { }

	// RVA: 0x18BF894
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18BF89C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18BF8DC
	private object System.Collections.IEnumerator.get_Current() { }

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
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
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
	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Methods

	// RVA: 0x18B2B38
	private BaseInput get_input() { }

	// RVA: 0x18B2CA0
	private string get_compositionString() { }

	// RVA: 0x18B2D5C
	protected void .ctor() { }

	// RVA: 0x18B31A4
	protected Mesh get_mesh() { }

	// RVA: 0x18B3294
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x18B3320
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x18B338C
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x18B3454
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x18B345C
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x18B34D8
	public string get_text() { }

	// RVA: 0x18B34E0
	public void set_text(string value) { }

	// RVA: 0x18B3914
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x18B34E8
	private void SetText(string value, bool sendCallback) { }

	// RVA: 0x18B3FCC
	public bool get_isFocused() { }

	// RVA: 0x18B3FD4
	public float get_caretBlinkRate() { }

	// RVA: 0x18B3FDC
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x18B413C
	public int get_caretWidth() { }

	// RVA: 0x18B4144
	public void set_caretWidth(int value) { }

	// RVA: 0x18B42AC
	public Text get_textComponent() { }

	// RVA: 0x18B42B4
	public void set_textComponent(Text value) { }

	// RVA: 0x18B4558
	public Graphic get_placeholder() { }

	// RVA: 0x18B4560
	public void set_placeholder(Graphic value) { }

	// RVA: 0x18B45BC
	public Color get_caretColor() { }

	// RVA: 0x18B4608
	public void set_caretColor(Color value) { }

	// RVA: 0x18B46B0
	public bool get_customCaretColor() { }

	// RVA: 0x18B46B8
	public void set_customCaretColor(bool value) { }

	// RVA: 0x18B4760
	public Color get_selectionColor() { }

	// RVA: 0x18B4774
	public void set_selectionColor(Color value) { }

	// RVA: 0x18B481C
	public EndEditEvent get_onEndEdit() { }

	// RVA: 0x18B4824
	public void set_onEndEdit(EndEditEvent value) { }

	// RVA: 0x18B4880
	public SubmitEvent get_onSubmit() { }

	// RVA: 0x18B4888
	public void set_onSubmit(SubmitEvent value) { }

	// RVA: 0x18B48E4
	public OnChangeEvent get_onValueChange() { }

	// RVA: 0x18B48EC
	public void set_onValueChange(OnChangeEvent value) { }

	// RVA: 0x18B49A4
	public OnChangeEvent get_onValueChanged() { }

	// RVA: 0x18B4948
	public void set_onValueChanged(OnChangeEvent value) { }

	// RVA: 0x18B49AC
	public OnValidateInput get_onValidateInput() { }

	// RVA: 0x18B49B4
	public void set_onValidateInput(OnValidateInput value) { }

	// RVA: 0x18B4A10
	public int get_characterLimit() { }

	// RVA: 0x18B4A18
	public void set_characterLimit(int value) { }

	// RVA: 0x18B4AE4
	public ContentType get_contentType() { }

	// RVA: 0x18B4AEC
	public void set_contentType(ContentType value) { }

	// RVA: 0x18B4D04
	public LineType get_lineType() { }

	// RVA: 0x18B4D0C
	public void set_lineType(LineType value) { }

	// RVA: 0x18B4F50
	public InputType get_inputType() { }

	// RVA: 0x18B4F58
	public void set_inputType(InputType value) { }

	// RVA: 0x18B5150
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x18B5158
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x18B5160
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x18B5204
	public CharacterValidation get_characterValidation() { }

	// RVA: 0x18B520C
	public void set_characterValidation(CharacterValidation value) { }

	// RVA: 0x18B52B0
	public bool get_readOnly() { }

	// RVA: 0x18B52B8
	public void set_readOnly(bool value) { }

	// RVA: 0x18B52C0
	public bool get_multiLine() { }

	// RVA: 0x18B52D4
	public Char get_asteriskChar() { }

	// RVA: 0x18B52DC
	public void set_asteriskChar(Char value) { }

	// RVA: 0x18B5380
	public bool get_wasCanceled() { }

	// RVA: 0x18B5388
	protected void ClampPos(int pos) { }

	// RVA: 0x18B53C8
	protected int get_caretPositionInternal() { }

	// RVA: 0x18B53F8
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x18B5438
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x18B5468
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x18B54A8
	private bool get_hasSelection() { }

	// RVA: 0x18B5500
	public int get_caretPosition() { }

	// RVA: 0x18B5530
	public void set_caretPosition(int value) { }

	// RVA: 0x18B56C4
	public int get_selectionAnchorPosition() { }

	// RVA: 0x18B55DC
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x18B56F4
	public int get_selectionFocusPosition() { }

	// RVA: 0x18B5650
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x18B5724
	protected override void OnEnable() { }

	// RVA: 0x18B59CC
	protected override void OnDisable() { }

	// RVA: 0x18B5F3C
	protected override void OnDestroy() { }

	// RVA: 0x18B5FAC
	private IEnumerator CaretBlink() { }

	// RVA: 0x18B6050
	private void SetCaretVisible() { }

	// RVA: 0x18B4064
	private void SetCaretActive() { }

	// RVA: 0x18B6098
	private void UpdateCaretMaterial() { }

	// RVA: 0x18B61F4
	protected void OnFocus() { }

	// RVA: 0x18B6238
	protected void SelectAll() { }

	// RVA: 0x18B627C
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x18B6314
	public void MoveTextStart(bool shift) { }

	// RVA: 0x18B63E4
	private static string get_clipboard() { }

	// RVA: 0x18B6454
	private static void set_clipboard(string value) { }

	// RVA: 0x18B64DC
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x18B65C0
	private bool InPlaceEditing() { }

	// RVA: 0x18B6604
	private bool InPlaceEditingChanged() { }

	// RVA: 0x18B66B0
	private RangeInt GetInternalSelection() { }

	// RVA: 0x18B67C0
	private void UpdateKeyboardCaret() { }

	// RVA: 0x18B68B0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x18B69D0
	protected virtual void LateUpdate() { }

	// RVA: 0x18B82CC
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x18B86B8
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x18B88D8
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x18B8D28
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18B8E48
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18B8E74
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18B9138
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x18B91F0
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18B9218
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18B942C
	protected EditState KeyPressed(Event evt) { }

	// RVA: 0x18BA6DC
	private bool IsValidChar(Char c) { }

	// RVA: 0x18BA764
	public void ProcessEvent(Event e) { }

	// RVA: 0x18BA768
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x18B9F80
	private string GetSelectedString() { }

	// RVA: 0x18BA984
	private int FindtNextWordBegin() { }

	// RVA: 0x18BA50C
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x18BAA6C
	private int FindtPrevWordBegin() { }

	// RVA: 0x18BA34C
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x18BAB3C
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x18BAC54
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x18BB1DC
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x18BA6D4
	private void MoveDown(bool shift) { }

	// RVA: 0x18BB74C
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x18BA6CC
	private void MoveUp(bool shift) { }

	// RVA: 0x18BB918
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x18BA05C
	private void Delete() { }

	// RVA: 0x18B9D80
	private void ForwardSpace() { }

	// RVA: 0x18B9AF8
	private void Backspace() { }

	// RVA: 0x18BBAAC
	private void Insert(Char c) { }

	// RVA: 0x18BA2F4
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x18B8244
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x18B39D8
	private void SendOnValueChanged() { }

	// RVA: 0x18BBCBC
	protected void SendOnEndEdit() { }

	// RVA: 0x18B7AD4
	protected void SendOnSubmit() { }

	// RVA: 0x18BBD4C
	protected virtual void Append(string input) { }

	// RVA: 0x18BBE10
	protected virtual void Append(Char input) { }

	// RVA: 0x18B3A68
	protected void UpdateLabel() { }

	// RVA: 0x18BD1DC
	private bool IsSelectionVisible() { }

	// RVA: 0x18BD2C0
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x18B8BA0
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x18BC0DC
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x18BD41C
	public void ForceLabelUpdate() { }

	// RVA: 0x18B4224
	private void MarkGeometryAsDirty() { }

	// RVA: 0x18BD420
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x18BD970
	public virtual void LayoutComplete() { }

	// RVA: 0x18BD974
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18BD430
	private void UpdateGeometry() { }

	// RVA: 0x18B7540
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x18BD978
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x18BDBE8
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x18BEB10
	private void CreateCursorVerts() { }

	// RVA: 0x18BE350
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x18B7B64
	protected Char Validate(string text, int pos, Char ch) { }

	// RVA: 0x18BEC5C
	public void ActivateInputField() { }

	// RVA: 0x18B7040
	private void ActivateInputFieldInternal() { }

	// RVA: 0x18BEDD0
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18BEE1C
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18B5C88
	public void DeactivateInputField() { }

	// RVA: 0x18BEE44
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18BEE74
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18B4C34
	private void EnforceContentType() { }

	// RVA: 0x18B30BC
	private void EnforceTextHOverflow() { }

	// RVA: 0x18B4DD0
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	// RVA: 0x18B4FFC
	private void SetToCustom() { }

	// RVA: 0x18BEED4
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x18BEF00
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18BEF04
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18BEF08
	public virtual float get_minWidth() { }

	// RVA: 0x18BEF10
	public virtual float get_preferredWidth() { }

	// RVA: 0x18BF094
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18BF09C
	public virtual float get_minHeight() { }

	// RVA: 0x18BF0A4
	public virtual float get_preferredHeight() { }

	// RVA: 0x18BF214
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18BF21C
	public virtual int get_layoutPriority() { }

	// RVA: 0x18BF224
	private static void .cctor() { }

	// RVA: 0x18BF2D8
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

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

	// RVA: 0x18BF8E4
	public AspectMode get_aspectMode() { }

	// RVA: 0x18BF8EC
	public void set_aspectMode(AspectMode value) { }

	// RVA: 0x18BF994
	public float get_aspectRatio() { }

	// RVA: 0x18BF99C
	public void set_aspectRatio(float value) { }

	// RVA: 0x18BFA4C
	private RectTransform get_rectTransform() { }

	// RVA: 0x18BFB44
	protected void .ctor() { }

	// RVA: 0x18BFB54
	protected override void OnEnable() { }

	// RVA: 0x18BFBF0
	protected override void Start() { }

	// RVA: 0x18BFD70
	protected override void OnDisable() { }

	// RVA: 0x18C032C
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18C03C8
	protected virtual void Update() { }

	// RVA: 0x18C03DC
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18C03E0
	private void UpdateRect() { }

	// RVA: 0x18C07B0
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x18C0694
	private Vector2 GetParentSize() { }

	// RVA: 0x18C08A8
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18C08AC
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18BF990
	protected void SetDirty() { }

	// RVA: 0x18BFC50
	public bool IsComponentValidOnObject() { }

	// RVA: 0x18BFD48
	public bool IsAspectModeValid() { }

	// RVA: 0x18C08B0
	private bool DoesParentExists() { }

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
	private const float kLogBase = 2;
	protected Unit m_PhysicalUnit; // 0x3C
	protected float m_FallbackScreenDPI; // 0x40
	protected float m_DefaultSpriteDPI; // 0x44
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	protected bool m_PresetInfoIsWorld; // 0x60

	// Methods

	// RVA: 0x18C08B8
	public ScaleMode get_uiScaleMode() { }

	// RVA: 0x18C08C0
	public void set_uiScaleMode(ScaleMode value) { }

	// RVA: 0x18C08C8
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x18C08D0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x18C08D8
	public float get_scaleFactor() { }

	// RVA: 0x18C08E0
	public void set_scaleFactor(float value) { }

	// RVA: 0x18C08FC
	public Vector2 get_referenceResolution() { }

	// RVA: 0x18C0904
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x18C098C
	public ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x18C0994
	public void set_screenMatchMode(ScreenMatchMode value) { }

	// RVA: 0x18C099C
	public float get_matchWidthOrHeight() { }

	// RVA: 0x18C09A4
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x18C09AC
	public Unit get_physicalUnit() { }

	// RVA: 0x18C09B4
	public void set_physicalUnit(Unit value) { }

	// RVA: 0x18C09BC
	public float get_fallbackScreenDPI() { }

	// RVA: 0x18C09C4
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x18C09CC
	public float get_defaultSpriteDPI() { }

	// RVA: 0x18C09D4
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x18C09E8
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x18C09F0
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x18C09F8
	protected void .ctor() { }

	// RVA: 0x18C0A40
	protected override void OnEnable() { }

	// RVA: 0x18C0B2C
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x18C0B3C
	protected override void OnDisable() { }

	// RVA: 0x18C0D04
	protected virtual void Handle() { }

	// RVA: 0x18C0E40
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x18C0ED8
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x18C0F70
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x18C1264
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x18C0C44
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x18C0CA4
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }

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

	// RVA: 0x18C1328
	public FitMode get_horizontalFit() { }

	// RVA: 0x18C1330
	public void set_horizontalFit(FitMode value) { }

	// RVA: 0x18C14A8
	public FitMode get_verticalFit() { }

	// RVA: 0x18C14B0
	public void set_verticalFit(FitMode value) { }

	// RVA: 0x18C1580
	private RectTransform get_rectTransform() { }

	// RVA: 0x18C1678
	protected void .ctor() { }

	// RVA: 0x18C1680
	protected override void OnEnable() { }

	// RVA: 0x18C1730
	protected override void OnDisable() { }

	// RVA: 0x18C17B4
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18C185C
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x18C1958
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18C1988
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18C1400
	protected void SetDirty() { }

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

	// RVA: 0x18C1990
	public Corner get_startCorner() { }

	// RVA: 0x18C1998
	public void set_startCorner(Corner value) { }

	// RVA: 0x18C1A08
	public Axis get_startAxis() { }

	// RVA: 0x18C1A10
	public void set_startAxis(Axis value) { }

	// RVA: 0x18C1A80
	public Vector2 get_cellSize() { }

	// RVA: 0x18C1A88
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x18C1B04
	public Vector2 get_spacing() { }

	// RVA: 0x18C1B0C
	public void set_spacing(Vector2 value) { }

	// RVA: 0x18C1B88
	public Constraint get_constraint() { }

	// RVA: 0x18C1B90
	public void set_constraint(Constraint value) { }

	// RVA: 0x18C1C00
	public int get_constraintCount() { }

	// RVA: 0x18C1C08
	public void set_constraintCount(int value) { }

	// RVA: 0x18C1C80
	protected void .ctor() { }

	// RVA: 0x18C1E44
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18C24F0
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18C2850
	public override void SetLayoutHorizontal() { }

	// RVA: 0x18C319C
	public override void SetLayoutVertical() { }

	// RVA: 0x18C2858
	private void SetCellsAlongAxis(int axis) { }

}

// Namespace: UnityEngine.UI
public class HorizontalLayoutGroup
{
	// Methods

	// RVA: 0x18C33F8
	protected void .ctor() { }

	// RVA: 0x18C3410
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18C3918
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18C3924
	public override void SetLayoutHorizontal() { }

	// RVA: 0x18C41B4
	public override void SetLayoutVertical() { }

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

	// RVA: 0x18C41C0
	public float get_spacing() { }

	// RVA: 0x18C41C8
	public void set_spacing(float value) { }

	// RVA: 0x18C4240
	public bool get_childForceExpandWidth() { }

	// RVA: 0x18C4248
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x18C42B8
	public bool get_childForceExpandHeight() { }

	// RVA: 0x18C42C0
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x18C4330
	public bool get_childControlWidth() { }

	// RVA: 0x18C4338
	public void set_childControlWidth(bool value) { }

	// RVA: 0x18C43A8
	public bool get_childControlHeight() { }

	// RVA: 0x18C43B0
	public void set_childControlHeight(bool value) { }

	// RVA: 0x18C4420
	public bool get_childScaleWidth() { }

	// RVA: 0x18C4428
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x18C4498
	public bool get_childScaleHeight() { }

	// RVA: 0x18C44A0
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x18C4510
	public bool get_reverseArrangement() { }

	// RVA: 0x18C4518
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x18C343C
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x18C3930
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x18C4588
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, float min, float preferred, float flexible) { }

	// RVA: 0x18C3404
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface ILayoutElement
{
	// Methods

	// RVA: -1
	public abstract void CalculateLayoutInputHorizontal() { }

	// RVA: -1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: -1
	public abstract float get_minWidth() { }

	// RVA: -1
	public abstract float get_preferredWidth() { }

	// RVA: -1
	public abstract float get_flexibleWidth() { }

	// RVA: -1
	public abstract float get_minHeight() { }

	// RVA: -1
	public abstract float get_preferredHeight() { }

	// RVA: -1
	public abstract float get_flexibleHeight() { }

	// RVA: -1
	public abstract int get_layoutPriority() { }

}

// Namespace: UnityEngine.UI
public interface ILayoutController
{
	// Methods

	// RVA: -1
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1
	public abstract void SetLayoutVertical() { }

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

	// RVA: -1
	public abstract bool get_ignoreLayout() { }

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

	// RVA: 0x18C4D40
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x18C4D48
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x18C4F20
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18C4F24
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18C4F28
	public virtual float get_minWidth() { }

	// RVA: 0x18C4F30
	public virtual void set_minWidth(float value) { }

	// RVA: 0x18C503C
	public virtual float get_minHeight() { }

	// RVA: 0x18C5044
	public virtual void set_minHeight(float value) { }

	// RVA: 0x18C5150
	public virtual float get_preferredWidth() { }

	// RVA: 0x18C5158
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x18C5264
	public virtual float get_preferredHeight() { }

	// RVA: 0x18C526C
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x18C5378
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18C5380
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x18C548C
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18C5494
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x18C55A0
	public virtual int get_layoutPriority() { }

	// RVA: 0x18C55A8
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x18C56AC
	protected void .ctor() { }

	// RVA: 0x18C56CC
	protected override void OnEnable() { }

	// RVA: 0x18C57A8
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18C587C
	protected override void OnDisable() { }

	// RVA: 0x18C5968
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18C5A3C
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x18C4E4C
	protected void SetDirty() { }

}

// Namespace: 
private sealed class <DelayedSetDirty>d__56
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Methods

	// RVA: 0x18C6108
	public void .ctor(int <>1__state) { }

	// RVA: 0x18C6134
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18C6138
	private bool MoveNext() { }

	// RVA: 0x18C61EC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18C61F4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18C6234
	private object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x18C5B10
	public RectOffset get_padding() { }

	// RVA: 0x18C5B18
	public void set_padding(RectOffset value) { }

	// RVA: 0x18C5B78
	public TextAnchor get_childAlignment() { }

	// RVA: 0x18C5B80
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x18C2758
	protected RectTransform get_rectTransform() { }

	// RVA: 0x18C5BF0
	protected System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }

	// RVA: 0x18C2044
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: 0x18C5BF8
	public virtual float get_minWidth() { }

	// RVA: 0x18C5C00
	public virtual float get_preferredWidth() { }

	// RVA: 0x18C5C08
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18C5C10
	public virtual float get_minHeight() { }

	// RVA: 0x18C5C18
	public virtual float get_preferredHeight() { }

	// RVA: 0x18C5C20
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18C5C28
	public virtual int get_layoutPriority() { }

	// RVA: -1
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1
	public abstract void SetLayoutVertical() { }

	// RVA: 0x18C1CEC
	protected void .ctor() { }

	// RVA: 0x18C5C30
	protected override void OnEnable() { }

	// RVA: 0x18C5D9C
	protected override void OnDisable() { }

	// RVA: 0x18C5E20
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18C4CAC
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x18C4B9C
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x18C4C24
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x18C31A4
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x18C46A0
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x18C2458
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x18C5E24
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x18C494C
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x18C3318
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x18C46E0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x18C5EFC
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x18C604C
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18C608C
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x318DB98
	protected void SetProperty(T currentValue, T newValue) { }

	// RVA: 0x18C5C58
	protected void SetDirty() { }

	// RVA: 0x18C6090
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0x18C7820
	private static void .cctor() { }

	// RVA: 0x18C788C
	public void .ctor() { }

	// RVA: 0x18C7894
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x18C78EC
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x18C7924
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x18C79B8
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x18C7A94
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x18C7B70
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x18C7C50
	internal void <Rebuild>b__12_3(Component e) { }

}

// Namespace: UnityEngine.UI
public class LayoutRebuilder
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders; // 0x0

	// Methods

	// RVA: 0x18C623C
	private void Initialize(RectTransform controller) { }

	// RVA: 0x18C6280
	private void Clear() { }

	// RVA: 0x18C62B0
	private static void .cctor() { }

	// RVA: 0x18C64A0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x18C6520
	public Transform get_transform() { }

	// RVA: 0x18C6528
	public bool IsDestroyed() { }

	// RVA: 0x18C6594
	private static void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }

	// RVA: 0x18C66B4
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x18C67C0
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18C6E04
	private void PerformLayoutControl(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x18C6ADC
	private void PerformLayoutCalculation(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x18BFDF4
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x18C727C
	private static bool ValidController(RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }

	// RVA: 0x18C74E4
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x18C7688
	public void LayoutComplete() { }

	// RVA: 0x18C772C
	public void GraphicUpdateComplete() { }

	// RVA: 0x18C7730
	public override int GetHashCode() { }

	// RVA: 0x18C7738
	public override bool Equals(object obj) { }

	// RVA: 0x18C778C
	public override string ToString() { }

	// RVA: 0x18C7818
	public void .ctor() { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0x18C88DC
	private static void .cctor() { }

	// RVA: 0x18C8948
	public void .ctor() { }

	// RVA: 0x18C8950
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x18C8A04
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x18C8AB8
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x18C8B6C
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x18C8C20
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x18C8CD4
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x18C8D88
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x18C8E3C
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

// Namespace: UnityEngine.UI
public static class LayoutUtility
{
	// Methods

	// RVA: 0x18C1940
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x18C194C
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x18C4D34
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x18C7E48
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x18C8138
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x18C8428
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x18C7D30
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x18C7F60
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x18C8310
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x18C8540
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue) { }

	// RVA: 0x18C8564
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue, ILayoutElement source) { }

}

// Namespace: UnityEngine.UI
public class VerticalLayoutGroup
{
	// Methods

	// RVA: 0x18C8EF0
	protected void .ctor() { }

	// RVA: 0x18C8EFC
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18C8F28
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18C8F34
	public override void SetLayoutHorizontal() { }

	// RVA: 0x18C8F40
	public override void SetLayoutVertical() { }

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

	// RVA: 0x18C8F4C
	public RectTransform get_rectTransform() { }

	// RVA: 0x18C8FF8
	public bool get_showMaskGraphic() { }

	// RVA: 0x18C9000
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x18C9198
	public Graphic get_graphic() { }

	// RVA: 0x18C9244
	protected void .ctor() { }

	// RVA: 0x18C9254
	public virtual bool MaskEnabled() { }

	// RVA: 0x18C9380
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x18C9384
	protected override void OnEnable() { }

	// RVA: 0x18C99AC
	protected override void OnDisable() { }

	// RVA: 0x18C9DBC
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18C9EF8
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: 
[Serializable]
public class CullStateChangedEvent
{
	// Methods

	// RVA: 0x18CB98C
	public void .ctor() { }

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

	// RVA: 0x18CA938
	public CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x18CA940
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	// RVA: 0x18CA948
	public bool get_maskable() { }

	// RVA: 0x18CA950
	public void set_maskable(bool value) { }

	// RVA: 0x18CA97C
	public bool get_isMaskingGraphic() { }

	// RVA: 0x18C96C0
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x18CA984
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x18CAAB4
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18CAE04
	private void UpdateCull(bool cull) { }

	// RVA: 0x18CAEEC
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x18CAF6C
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x18CAFA8
	protected override void OnEnable() { }

	// RVA: 0x18CB1CC
	protected override void OnDisable() { }

	// RVA: 0x18CB298
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18CB2F8
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x18CB2FC
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18CAB98
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18CB008
	private void UpdateClipParent() { }

	// RVA: 0x18CB7DC
	public virtual void RecalculateClipping() { }

	// RVA: 0x18CB7E0
	public virtual void RecalculateMasking() { }

	// RVA: 0x18CB878
	protected void .ctor() { }

	// RVA: 0x18CB9E0
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

// Namespace: UnityEngine.UI
public class MaskUtilities
{
	// Methods

	// RVA: 0x18CB9E8
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x18C96D4
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x18CA37C
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x18CA570
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x18CBCC4
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x18CB35C
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x18CBE98
	public static void GetRectMasksForClip(RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }

	// RVA: 0x18CC274
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface IMaterialModifier
{
	// Methods

	// RVA: -1
	public abstract Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: UnityEngine.UI
internal static class Misc
{
	// Methods

	// RVA: 0x18CC27C
	public static void Destroy(object obj) { }

	// RVA: 0x18CC410
	public static void DestroyImmediate(object obj) { }

}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities
{
	// Methods

	// RVA: 0x18CC564
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, Vector2 position) { }

	// RVA: 0x18CCA74
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x18CC5DC
	public static Vector3 RelativeMouseAtScaled(Vector2 position) { }

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
[Serializable]
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

	// RVA: 0x18CCB50
	public Mode get_mode() { }

	// RVA: 0x18CCB58
	public void set_mode(Mode value) { }

	// RVA: 0x18CCB60
	public bool get_wrapAround() { }

	// RVA: 0x18CCB68
	public void set_wrapAround(bool value) { }

	// RVA: 0x18CCB70
	public Selectable get_selectOnUp() { }

	// RVA: 0x18CCB78
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x18CCB80
	public Selectable get_selectOnDown() { }

	// RVA: 0x18CCB88
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x18CCB90
	public Selectable get_selectOnLeft() { }

	// RVA: 0x18CCB98
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x18CCBA0
	public Selectable get_selectOnRight() { }

	// RVA: 0x18CCBA8
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x18CCBB0
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x18CCBD0
	public bool Equals(Navigation other) { }

}

// Namespace: UnityEngine.UI
public class RawImage
{
	// Fields
	private Texture m_Texture; // 0xD8
	private Rect m_UVRect; // 0xE0

	// Methods

	// RVA: 0x18CCD3C
	protected void .ctor() { }

	// RVA: 0x18CCD70
	public override Texture get_mainTexture() { }

	// RVA: 0x18CCF44
	public Texture get_texture() { }

	// RVA: 0x18CCF4C
	public void set_texture(Texture value) { }

	// RVA: 0x18CD040
	public Rect get_uvRect() { }

	// RVA: 0x18CD04C
	public void set_uvRect(Rect value) { }

	// RVA: 0x18CD084
	public override void SetNativeSize() { }

	// RVA: 0x18CD3A8
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x18CDC84
	protected override void OnDidApplyAnimationProperties() { }

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

	// RVA: 0x18CDCCC
	public Vector4 get_padding() { }

	// RVA: 0x18CDCD8
	public void set_padding(Vector4 value) { }

	// RVA: 0x18CDCE8
	public Vector2Int get_softness() { }

	// RVA: 0x18CDCF0
	public void set_softness(Vector2Int value) { }

	// RVA: 0x18CDD0C
	internal Canvas get_Canvas() { }

	// RVA: 0x18CDEEC
	public Rect get_canvasRect() { }

	// RVA: 0x18CDFB0
	public RectTransform get_rectTransform() { }

	// RVA: 0x18CE05C
	protected void .ctor() { }

	// RVA: 0x18CE200
	protected override void OnEnable() { }

	// RVA: 0x18CE240
	protected override void OnDisable() { }

	// RVA: 0x18CE344
	protected override void OnDestroy() { }

	// RVA: 0x18CE370
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18CE4DC
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18CE700
	public virtual void PerformClipping() { }

	// RVA: 0x18CF1B4
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x18CF5C0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x18CF704
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x18CF8CC
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18CF908
	protected override void OnCanvasHierarchyChanged() { }

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
[Serializable]
public class ScrollEvent
{
	// Methods

	// RVA: 0x18CFF80
	public void .ctor() { }

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

	// RVA: 0x18D1594
	public void .ctor(int <>1__state) { }

	// RVA: 0x18D2208
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18D220C
	private bool MoveNext() { }

	// RVA: 0x18D2658
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18D2660
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18D26A0
	private object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x18CF944
	public RectTransform get_handleRect() { }

	// RVA: 0x18CF94C
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18CFDB8
	public Direction get_direction() { }

	// RVA: 0x18CFDC0
	public void set_direction(Direction value) { }

	// RVA: 0x18CFE64
	protected void .ctor() { }

	// RVA: 0x18D0114
	public float get_value() { }

	// RVA: 0x18D01D0
	public void set_value(float value) { }

	// RVA: 0x18D0410
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18D0418
	public float get_size() { }

	// RVA: 0x18D0420
	public void set_size(float value) { }

	// RVA: 0x18D04B8
	public int get_numberOfSteps() { }

	// RVA: 0x18D04C0
	public void set_numberOfSteps(int value) { }

	// RVA: 0x18D0574
	public ScrollEvent get_onValueChanged() { }

	// RVA: 0x18D057C
	public void set_onValueChanged(ScrollEvent value) { }

	// RVA: 0x18D058C
	private float get_stepSize() { }

	// RVA: 0x18D05BC
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18D05C0
	public virtual void LayoutComplete() { }

	// RVA: 0x18D05C4
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18D05C8
	protected override void OnEnable() { }

	// RVA: 0x18D08F8
	protected override void OnDisable() { }

	// RVA: 0x18D0A68
	protected virtual void Update() { }

	// RVA: 0x18CF9CC
	private void UpdateCachedReferences() { }

	// RVA: 0x18D01D8
	private void Set(float input, bool sendCallback) { }

	// RVA: 0x18D0A7C
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18D0AC4
	private Axis get_axis() { }

	// RVA: 0x18D0AD4
	private bool get_reverseValue() { }

	// RVA: 0x18CFB1C
	private void UpdateVisuals() { }

	// RVA: 0x18D0AE8
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x18D0DAC
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x18D0E18
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18D0E74
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18D1070
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18D1150
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18D14E4
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x18D1444
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x18D15C0
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18D1748
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18D1BB0
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18D1CC0
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18D1DD0
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18D1EE0
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18D1FF0
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18D200C
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18D2200
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

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
[Serializable]
public class ScrollRectEvent
{
	// Methods

	// RVA: 0x18D3278
	public void .ctor() { }

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

	// RVA: 0x18D26A8
	public RectTransform get_content() { }

	// RVA: 0x18D26B0
	public void set_content(RectTransform value) { }

	// RVA: 0x18D26B8
	public bool get_horizontal() { }

	// RVA: 0x18D26C0
	public void set_horizontal(bool value) { }

	// RVA: 0x18D26C8
	public bool get_vertical() { }

	// RVA: 0x18D26D0
	public void set_vertical(bool value) { }

	// RVA: 0x18D26D8
	public MovementType get_movementType() { }

	// RVA: 0x18D26E0
	public void set_movementType(MovementType value) { }

	// RVA: 0x18D26E8
	public float get_elasticity() { }

	// RVA: 0x18D26F0
	public void set_elasticity(float value) { }

	// RVA: 0x18D26F8
	public bool get_inertia() { }

	// RVA: 0x18D2700
	public void set_inertia(bool value) { }

	// RVA: 0x18D2708
	public float get_decelerationRate() { }

	// RVA: 0x18D2710
	public void set_decelerationRate(float value) { }

	// RVA: 0x18D2718
	public float get_scrollSensitivity() { }

	// RVA: 0x18D2720
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x18D2728
	public RectTransform get_viewport() { }

	// RVA: 0x18D2730
	public void set_viewport(RectTransform value) { }

	// RVA: 0x18D2840
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x18D2848
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x18D2A4C
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x18D2A54
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x18D2C58
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x18D2C60
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18D2C68
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x18D2C70
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18D2C78
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x18D2C80
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x18D2DE4
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x18D2DEC
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x18D2EA0
	public ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x18D2EA8
	public void set_onValueChanged(ScrollRectEvent value) { }

	// RVA: 0x18D2EB0
	protected RectTransform get_viewRect() { }

	// RVA: 0x18D3024
	public Vector2 get_velocity() { }

	// RVA: 0x18D302C
	public void set_velocity(Vector2 value) { }

	// RVA: 0x18D3034
	private RectTransform get_rectTransform() { }

	// RVA: 0x18D312C
	protected void .ctor() { }

	// RVA: 0x18D32CC
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18D40F8
	public virtual void LayoutComplete() { }

	// RVA: 0x18D40FC
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18D3358
	private void UpdateCachedData() { }

	// RVA: 0x18D4100
	protected override void OnEnable() { }

	// RVA: 0x18D43B0
	protected override void OnDisable() { }

	// RVA: 0x18D4614
	public override bool IsActive() { }

	// RVA: 0x18D46BC
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x18D4740
	public virtual void StopMovement() { }

	// RVA: 0x18D4794
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x18D4C48
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18D4CB8
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18D4DF8
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18D4E24
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18D517C
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x18D525C
	protected virtual void LateUpdate() { }

	// RVA: 0x18D3FF0
	protected void UpdatePrevData() { }

	// RVA: 0x18D3B40
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x18D5A80
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x18D5FD0
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x18D5DB8
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x18D6024
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x18D5EC4
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x18D6038
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x18D604C
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x18D6060
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x18D6074
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x18D5140
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x18D63C8
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18D6478
	private bool get_hScrollingNeeded() { }

	// RVA: 0x18D6534
	private bool get_vScrollingNeeded() { }

	// RVA: 0x18D65F0
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18D65F4
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18D65F8
	public virtual float get_minWidth() { }

	// RVA: 0x18D6600
	public virtual float get_preferredWidth() { }

	// RVA: 0x18D6608
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18D6610
	public virtual float get_minHeight() { }

	// RVA: 0x18D6618
	public virtual float get_preferredHeight() { }

	// RVA: 0x18D6620
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18D6628
	public virtual int get_layoutPriority() { }

	// RVA: 0x18D6630
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18D6DB0
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18D5C68
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x18D722C
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x18D6E74
	private void UpdateScrollbarLayout() { }

	// RVA: 0x18D37BC
	protected void UpdateBounds() { }

	// RVA: 0x18D7374
	internal static void AdjustBounds(Bounds viewBounds, Vector2 contentPivot, Vector3 contentSize, Vector3 contentPos) { }

	// RVA: 0x18D6C90
	private Bounds GetBounds() { }

	// RVA: 0x18D73FC
	internal static Bounds InternalGetBounds(Vector3[] corners, Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x18D4AE0
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x18D7640
	internal static Vector2 InternalCalculateOffset(Bounds viewBounds, Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, Vector2 delta) { }

	// RVA: 0x18D2D34
	protected void SetDirty() { }

	// RVA: 0x18D2758
	protected void SetDirtyCaching() { }

	// RVA: 0x18D7780
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

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

	// RVA: 0x18D7788
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x18D7824
	public static int get_allSelectableCount() { }

	// RVA: 0x18D78A0
	public static System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }

	// RVA: 0x18D79D0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x18D7AC0
	public Navigation get_navigation() { }

	// RVA: 0x18D7AD8
	public void set_navigation(Navigation value) { }

	// RVA: 0x18D7C20
	public Transition get_transition() { }

	// RVA: 0x18D7C28
	public void set_transition(Transition value) { }

	// RVA: 0x18D7D20
	public ColorBlock get_colors() { }

	// RVA: 0x18D7D4C
	public void set_colors(ColorBlock value) { }

	// RVA: 0x18D7E34
	public SpriteState get_spriteState() { }

	// RVA: 0x18D7E40
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x18D7F10
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x18D7F18
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x18D7FE4
	public Graphic get_targetGraphic() { }

	// RVA: 0x18D7FEC
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x18D80B8
	public bool get_interactable() { }

	// RVA: 0x18D80C0
	public void set_interactable(bool value) { }

	// RVA: 0x18D82CC
	private bool get_isPointerInside() { }

	// RVA: 0x18D82D4
	private void set_isPointerInside(bool value) { }

	// RVA: 0x18D82DC
	private bool get_isPointerDown() { }

	// RVA: 0x18D82E4
	private void set_isPointerDown(bool value) { }

	// RVA: 0x18D82EC
	private bool get_hasSelection() { }

	// RVA: 0x18D82F4
	private void set_hasSelection(bool value) { }

	// RVA: 0x18CFFD4
	protected void .ctor() { }

	// RVA: 0x18D82FC
	public Image get_image() { }

	// RVA: 0x18D8384
	public void set_image(Image value) { }

	// RVA: 0x18D838C
	public Animator get_animator() { }

	// RVA: 0x18D83F4
	protected override void Awake() { }

	// RVA: 0x18D84E4
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x18D8578
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x18D871C
	public virtual bool IsInteractable() { }

	// RVA: 0x18D873C
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18D0604
	protected override void OnEnable() { }

	// RVA: 0x18D8820
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18D7BB0
	private void OnSetProperty() { }

	// RVA: 0x18D0924
	protected override void OnDisable() { }

	// RVA: 0x18D8854
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18D87AC
	protected SelectionState get_currentSelectionState() { }

	// RVA: 0x18D8910
	protected virtual void InstantClearState() { }

	// RVA: 0x18D9054
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x18D9304
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x18D9840
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x18D99F0
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x18D1BD4
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x18D1CE4
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x18D1DF4
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x18D1F04
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x18D1B0C
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18D8A54
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x18D8B8C
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x18D8D20
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x18D9AD0
	protected bool IsHighlighted() { }

	// RVA: 0x18D88C0
	protected bool IsPressed() { }

	// RVA: 0x18D9B50
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x18D127C
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18D168C
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18D9BF8
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18D9CA8
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18D9D54
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18D9E04
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18D9EB0
	public virtual void Select() { }

	// RVA: 0x18DA004
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility
{
	// Methods

	// RVA: 0x18DA094
	public static bool SetColor(Color currentValue, Color newValue) { }

	// RVA: 0x318DB98
	public static bool SetStruct(T currentValue, T newValue) { }

	// RVA: 0x318DB98
	public static bool SetClass(T currentValue, T newValue) { }

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
[Serializable]
public class SliderEvent
{
	// Methods

	// RVA: 0x18DB340
	public void .ctor() { }

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

	// RVA: 0x18DA0E0
	public RectTransform get_fillRect() { }

	// RVA: 0x18DA0E8
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x18DAC18
	public RectTransform get_handleRect() { }

	// RVA: 0x18DAC20
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18DACA0
	public Direction get_direction() { }

	// RVA: 0x18DACA8
	public void set_direction(Direction value) { }

	// RVA: 0x18DAD4C
	public float get_minValue() { }

	// RVA: 0x18DAD54
	public void set_minValue(float value) { }

	// RVA: 0x18DAE20
	public float get_maxValue() { }

	// RVA: 0x18DAE28
	public void set_maxValue(float value) { }

	// RVA: 0x18DAEF4
	public bool get_wholeNumbers() { }

	// RVA: 0x18DAEFC
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x18DAFBC
	public virtual float get_value() { }

	// RVA: 0x18DB088
	public virtual void set_value(float value) { }

	// RVA: 0x18DB09C
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18DB0B0
	public float get_normalizedValue() { }

	// RVA: 0x18DB1A4
	public void set_normalizedValue(float value) { }

	// RVA: 0x18DB1E0
	public SliderEvent get_onValueChanged() { }

	// RVA: 0x18DB1E8
	public void set_onValueChanged(SliderEvent value) { }

	// RVA: 0x18DB1F8
	private float get_stepSize() { }

	// RVA: 0x18DB228
	protected void .ctor() { }

	// RVA: 0x18DB394
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18DB398
	public virtual void LayoutComplete() { }

	// RVA: 0x18DB39C
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18DB3A0
	protected override void OnEnable() { }

	// RVA: 0x18DB3E8
	protected override void OnDisable() { }

	// RVA: 0x18DB414
	protected virtual void Update() { }

	// RVA: 0x18DB464
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18DA168
	private void UpdateCachedReferences() { }

	// RVA: 0x18DB960
	private float ClampValue(float input) { }

	// RVA: 0x18DBA64
	protected virtual void Set(float input, bool sendCallback) { }

	// RVA: 0x18DBBEC
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18DBA54
	private Axis get_axis() { }

	// RVA: 0x18DBA40
	private bool get_reverseValue() { }

	// RVA: 0x18DA514
	private void UpdateVisuals() { }

	// RVA: 0x18DBC34
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x18DBEAC
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18DBF08
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18DC114
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18DC190
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18DC554
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18DC578
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18DC59C
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18DC5C0
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18DC5E4
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18DC600
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18DC7F4
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState
{
	// Fields
	private Sprite m_HighlightedSprite; // 0x10
	private Sprite m_PressedSprite; // 0x18
	private Sprite m_SelectedSprite; // 0x20
	private Sprite m_DisabledSprite; // 0x28

	// Methods

	// RVA: 0x18DC7FC
	public Sprite get_highlightedSprite() { }

	// RVA: 0x18DC804
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x18DC80C
	public Sprite get_pressedSprite() { }

	// RVA: 0x18DC814
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x18DC81C
	public Sprite get_selectedSprite() { }

	// RVA: 0x18DC824
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x18DC82C
	public Sprite get_disabledSprite() { }

	// RVA: 0x18DC834
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x18DC83C
	public bool Equals(SpriteState other) { }

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

	// RVA: 0x18DD560
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class StencilMaterial
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	// RVA: 0x18DC9AC
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x18DC9B4
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x18DD49C
	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	// RVA: 0x18DCA4C
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x18DD570
	public static void Remove(Material customMat) { }

	// RVA: 0x18DD75C
	public static void ClearAll() { }

	// RVA: 0x18DD914
	private static void .cctor() { }

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

	// RVA: 0x18DD9B0
	protected void .ctor() { }

	// RVA: 0x18DDA6C
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x18DDB24
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x18DDBB0
	public override Texture get_mainTexture() { }

	// RVA: 0x18DDE04
	public void FontTextureChanged() { }

	// RVA: 0x18DDDE4
	public Font get_font() { }

	// RVA: 0x18DDF58
	public void set_font(Font value) { }

	// RVA: 0x18DE098
	public virtual string get_text() { }

	// RVA: 0x18DE0A0
	public virtual void set_text(string value) { }

	// RVA: 0x18DE194
	public bool get_supportRichText() { }

	// RVA: 0x18DE1B4
	public void set_supportRichText(bool value) { }

	// RVA: 0x18DE220
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x18DE240
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x18DE2AC
	public int get_resizeTextMinSize() { }

	// RVA: 0x18DE2CC
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x18DE330
	public int get_resizeTextMaxSize() { }

	// RVA: 0x18DE350
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x18DE3B4
	public TextAnchor get_alignment() { }

	// RVA: 0x18DE3D4
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x18DE438
	public bool get_alignByGeometry() { }

	// RVA: 0x18DE458
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x18DE4A0
	public int get_fontSize() { }

	// RVA: 0x18DE4C0
	public void set_fontSize(int value) { }

	// RVA: 0x18DE524
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x18DE544
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x18DE5A8
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x18DE5C8
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x18DE62C
	public float get_lineSpacing() { }

	// RVA: 0x18DE64C
	public void set_lineSpacing(float value) { }

	// RVA: 0x18DE6B0
	public FontStyle get_fontStyle() { }

	// RVA: 0x18DE6D0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x18DE734
	public float get_pixelsPerUnit() { }

	// RVA: 0x18DE8C8
	protected override void OnEnable() { }

	// RVA: 0x18DE95C
	protected override void OnDisable() { }

	// RVA: 0x18DE9CC
	protected override void UpdateGeometry() { }

	// RVA: 0x18DEA6C
	internal void AssignDefaultFont() { }

	// RVA: 0x18DEAE0
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x18DEBB4
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x18DED78
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x18DEE04
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x18DF570
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18DF574
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18DF578
	public virtual float get_minWidth() { }

	// RVA: 0x18DF580
	public virtual float get_preferredWidth() { }

	// RVA: 0x18DF6D8
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18DF6E0
	public virtual float get_minHeight() { }

	// RVA: 0x18DF6E8
	public virtual float get_preferredHeight() { }

	// RVA: 0x18DF80C
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18DF814
	public virtual int get_layoutPriority() { }

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
[Serializable]
public class ToggleEvent
{
	// Methods

	// RVA: 0x18DFD68
	public void .ctor() { }

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

	// RVA: 0x18DF81C
	public ToggleGroup get_group() { }

	// RVA: 0x18DF824
	public void set_group(ToggleGroup value) { }

	// RVA: 0x18DFC80
	protected void .ctor() { }

	// RVA: 0x18DFDBC
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18DFDC0
	public virtual void LayoutComplete() { }

	// RVA: 0x18DFDC4
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18DFDC8
	protected override void OnDestroy() { }

	// RVA: 0x18E02D8
	protected override void OnEnable() { }

	// RVA: 0x18E03C4
	protected override void OnDisable() { }

	// RVA: 0x18E03F0
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18DF904
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x18E0B30
	public bool get_isOn() { }

	// RVA: 0x18E0B38
	public void set_isOn(bool value) { }

	// RVA: 0x18E0B40
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x18E05A8
	private void Set(bool value, bool sendCallback) { }

	// RVA: 0x18DFB90
	private void PlayEffect(bool instant) { }

	// RVA: 0x18E0CB8
	protected override void Start() { }

	// RVA: 0x18E0D90
	private void InternalToggle() { }

	// RVA: 0x18E0DF4
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18E0E68
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18E0ECC
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UI.ToggleGroup.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UI.Toggle> <>9__13_0; // 0x8
	public static System.Func<UnityEngine.UI.Toggle,System.Boolean> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x18E142C
	private static void .cctor() { }

	// RVA: 0x18E1498
	public void .ctor() { }

	// RVA: 0x18E14A0
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x18E14BC
	internal bool <ActiveToggles>b__14_0(Toggle x) { }

}

// Namespace: UnityEngine.UI
public class ToggleGroup
{
	// Fields
	private bool m_AllowSwitchOff; // 0x20
	protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles; // 0x28

	// Methods

	// RVA: 0x18E0ED4
	public bool get_allowSwitchOff() { }

	// RVA: 0x18E0EDC
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x18E0EE4
	protected void .ctor() { }

	// RVA: 0x18E0F70
	protected override void Start() { }

	// RVA: 0x18E0F98
	protected override void OnEnable() { }

	// RVA: 0x18E0FC0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x18E0940
	public void NotifyToggleOn(Toggle toggle, bool sendCallback) { }

	// RVA: 0x18E0800
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x18E08A0
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x18DFE90
	public void EnsureValidState() { }

	// RVA: 0x18E0B48
	public bool AnyTogglesOn() { }

	// RVA: 0x18E1138
	public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }

	// RVA: 0x18E1268
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x18E1318
	public void SetAllTogglesOff(bool sendCallback) { }

}

// Namespace: 
public sealed class Raycast3DCallback
{
	// Methods

	// RVA: 0x18E1CC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E1D64
	public virtual bool Invoke(Ray r, RaycastHit hit, float f, int i) { }

	// RVA: 0x18E1DA4
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18E1EE8
	public virtual bool EndInvoke(RaycastHit hit, IAsyncResult result) { }

}

// Namespace: 
public sealed class RaycastAllCallback
{
	// Methods

	// RVA: 0x18E1F4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E1FF0
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x18E2030
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18E2144
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GetRaycastNonAllocCallback
{
	// Methods

	// RVA: 0x18E2150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E21F4
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x18E2234
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18E2354
	public virtual int EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x18E14D8
	public void .ctor() { }

	// RVA: 0x18E1C18
	public static ReflectionMethodsCache get_Singleton() { }

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

	// RVA: 0x18E2380
	public void .ctor() { }

	// RVA: 0x18E2388
	public void .ctor(Mesh m) { }

	// RVA: 0x18E25C8
	private void InitializeListIfRequired() { }

	// RVA: 0x18E27E0
	public void Dispose() { }

	// RVA: 0x18CD688
	public void Clear() { }

	// RVA: 0x18E2A58
	public int get_currentVertCount() { }

	// RVA: 0x18E2AB0
	public int get_currentIndexCount() { }

	// RVA: 0x18E2B08
	public void PopulateUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18E2CB0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18E2E58
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x18E2FC4
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x18E3190
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x18CDA18
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x18E329C
	public void AddVert(UIVertex v) { }

	// RVA: 0x18CDBC8
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x18DF3BC
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x18E3334
	public void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x18E33E4
	public void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

	// RVA: 0x18E3438
	public void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }

	// RVA: 0x18E348C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseVertexEffect
{
	// Methods

	// RVA: -1
	public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x18E3528
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseMeshEffect
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Methods

	// RVA: 0x18E3530
	protected Graphic get_graphic() { }

	// RVA: 0x18E3628
	protected override void OnEnable() { }

	// RVA: 0x18E36F0
	protected override void OnDisable() { }

	// RVA: 0x18E37D8
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18E38C0
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1
	public abstract void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x18E3A3C
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public interface IVertexModifier
{
	// Methods

	// RVA: -1
	public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

}

// Namespace: UnityEngine.UI
public interface IMeshModifier
{
	// Methods

	// RVA: -1
	public abstract void ModifyMesh(Mesh mesh) { }

	// RVA: -1
	public abstract void ModifyMesh(VertexHelper verts) { }

}

// Namespace: UnityEngine.UI
public class Outline
{
	// Methods

	// RVA: 0x18E3A44
	protected void .ctor() { }

	// RVA: 0x18E3A94
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class PositionAsUV1
{
	// Methods

	// RVA: 0x18E3FB8
	protected void .ctor() { }

	// RVA: 0x18E3FC0
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class Shadow
{
	// Fields
	private Color m_EffectColor; // 0x28
	private Vector2 m_EffectDistance; // 0x38
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Methods

	// RVA: 0x18E3A6C
	protected void .ctor() { }

	// RVA: 0x18E40B4
	public Color get_effectColor() { }

	// RVA: 0x18E40C0
	public void set_effectColor(Color value) { }

	// RVA: 0x18E41AC
	public Vector2 get_effectDistance() { }

	// RVA: 0x18E41B4
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x18E42D8
	public bool get_useGraphicAlpha() { }

	// RVA: 0x18E42E0
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x18E3D14
	protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18E43A4
	protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18E43AC
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI.Collections
internal class IndexedSet<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<T> m_List; // 0x0
	private System.Collections.Generic.Dictionary<T,System.Int32> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Methods

	// RVA: 0x318DB98
	public void Add(T item) { }

	// RVA: 0x318DB98
	public void Add(T item, bool isActive) { }

	// RVA: 0x318DB98
	public bool AddUnique(T item, bool isActive) { }

	// RVA: 0x318DB98
	public bool EnableItem(T item) { }

	// RVA: 0x318DB98
	public bool DisableItem(T item) { }

	// RVA: 0x318DB98
	public bool Remove(T item) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(T item) { }

	// RVA: 0x30D4D3C
	public void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D39B8
	public int get_Capacity() { }

	// RVA: 0x30D3738
	public bool get_IsReadOnly() { }

	// RVA: 0x318DB98
	public int IndexOf(T item) { }

	// RVA: 0x318DB98
	public void Insert(int index, T item) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int index) { }

	// RVA: 0x30D4A74
	private void Swap(int index1, int index2) { }

	// RVA: 0x318DB98
	public T get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, T value) { }

	// RVA: 0x30D4CD4
	public void RemoveAll(System.Predicate<T> match) { }

	// RVA: 0x30D4CD4
	public void Sort(System.Comparison<T> sortLayoutFunction) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue
{
	// Methods

	// RVA: -1
	public abstract void TweenValue(float floatPercentage) { }

	// RVA: -1
	public abstract bool get_ignoreTimeScale() { }

	// RVA: -1
	public abstract float get_duration() { }

	// RVA: -1
	public abstract bool ValidTarget() { }

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

	// RVA: 0x18E4728
	public void .ctor() { }

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

	// RVA: 0x18E4520
	public Color get_startColor() { }

	// RVA: 0x18E452C
	public void set_startColor(Color value) { }

	// RVA: 0x18E4538
	public Color get_targetColor() { }

	// RVA: 0x18E4544
	public void set_targetColor(Color value) { }

	// RVA: 0x18E4550
	public ColorTweenMode get_tweenMode() { }

	// RVA: 0x18E4558
	public void set_tweenMode(ColorTweenMode value) { }

	// RVA: 0x18E4560
	public float get_duration() { }

	// RVA: 0x18E4568
	public void set_duration(float value) { }

	// RVA: 0x18E4570
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18E4578
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18E4580
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18E4650
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }

	// RVA: 0x18E477C
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18E4784
	public float GetDuration() { }

	// RVA: 0x18E4640
	public bool ValidTarget() { }

}

// Namespace: 
public class FloatTweenCallback
{
	// Methods

	// RVA: 0x18E494C
	public void .ctor() { }

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

	// RVA: 0x18E478C
	public float get_startValue() { }

	// RVA: 0x18E4794
	public void set_startValue(float value) { }

	// RVA: 0x18E479C
	public float get_targetValue() { }

	// RVA: 0x18E47A4
	public void set_targetValue(float value) { }

	// RVA: 0x18E47AC
	public float get_duration() { }

	// RVA: 0x18E47B4
	public void set_duration(float value) { }

	// RVA: 0x18E47BC
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18E47C4
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18E47CC
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18E4874
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }

	// RVA: 0x18E49A0
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18E49A8
	public float GetDuration() { }

	// RVA: 0x18E4864
	public bool ValidTarget() { }

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

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D3CF0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T0>
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	// RVA: 0x318DB98
	private static IEnumerator Start(T tweenInfo) { }

	// RVA: 0x30D4CD4
	public void Init(MonoBehaviour coroutineContainer) { }

	// RVA: 0x318DB98
	public void StartTween(T info) { }

	// RVA: 0x30D488C
	public void StopTween() { }

	// RVA: 0x30D488C
	public void .ctor() { }

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

	// RVA: 0x18E7824
	public int get_pointerId() { }

	// RVA: 0x18E782C
	private void set_pointerId(int value) { }

	// RVA: 0x18E7834
	public string get_pointerType() { }

	// RVA: 0x18E783C
	private void set_pointerType(string value) { }

	// RVA: 0x18E7844
	public bool get_isPrimary() { }

	// RVA: 0x18E784C
	private void set_isPrimary(bool value) { }

	// RVA: 0x18E7854
	public int get_button() { }

	// RVA: 0x18E785C
	private void set_button(int value) { }

	// RVA: 0x18E7864
	public int get_pressedButtons() { }

	// RVA: 0x18E786C
	private void set_pressedButtons(int value) { }

	// RVA: 0x18E7874
	public Vector3 get_position() { }

	// RVA: 0x18E7880
	private void set_position(Vector3 value) { }

	// RVA: 0x18E788C
	public Vector3 get_localPosition() { }

	// RVA: 0x18E7898
	private void set_localPosition(Vector3 value) { }

	// RVA: 0x18E78A4
	public Vector3 get_deltaPosition() { }

	// RVA: 0x18E78B0
	private void set_deltaPosition(Vector3 value) { }

	// RVA: 0x18E78BC
	public float get_deltaTime() { }

	// RVA: 0x18E78C4
	private void set_deltaTime(float value) { }

	// RVA: 0x18E78CC
	public int get_clickCount() { }

	// RVA: 0x18E78D4
	private void set_clickCount(int value) { }

	// RVA: 0x18E78DC
	public float get_pressure() { }

	// RVA: 0x18E78E4
	private void set_pressure(float value) { }

	// RVA: 0x18E78EC
	public float get_tangentialPressure() { }

	// RVA: 0x18E78F4
	private void set_tangentialPressure(float value) { }

	// RVA: 0x18E78FC
	public float get_altitudeAngle() { }

	// RVA: 0x18E7904
	private void set_altitudeAngle(float value) { }

	// RVA: 0x18E790C
	public float get_azimuthAngle() { }

	// RVA: 0x18E7914
	private void set_azimuthAngle(float value) { }

	// RVA: 0x18E791C
	public float get_twist() { }

	// RVA: 0x18E7924
	private void set_twist(float value) { }

	// RVA: 0x18E792C
	public Vector2 get_tilt() { }

	// RVA: 0x18E7934
	private void set_tilt(Vector2 value) { }

	// RVA: 0x18E793C
	public PenStatus get_penStatus() { }

	// RVA: 0x18E7944
	private void set_penStatus(PenStatus value) { }

	// RVA: 0x18E794C
	public Vector2 get_radius() { }

	// RVA: 0x18E7954
	private void set_radius(Vector2 value) { }

	// RVA: 0x18E795C
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18E7964
	private void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18E796C
	public EventModifiers get_modifiers() { }

	// RVA: 0x18E7974
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x18E797C
	public bool get_shiftKey() { }

	// RVA: 0x18E7988
	public bool get_ctrlKey() { }

	// RVA: 0x18E7994
	public bool get_commandKey() { }

	// RVA: 0x18E79A0
	public bool get_altKey() { }

	// RVA: 0x18E79AC
	public bool get_actionKey() { }

	// RVA: 0x18E7210
	public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18E774C
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x18E7814
	public void .ctor() { }

	// RVA: 0x18E7A78
	internal static bool <Read>g__InRange|90_0(int i, int start, int count) { }

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

	// RVA: 0x18E49B0
	public IPanel get_panel() { }

	// RVA: 0x18E49B8
	public void set_panel(IPanel value) { }

	// RVA: 0x18E4DF4
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18E4E0C
	private EventSystem get_eventSystem() { }

	// RVA: 0x18E4F2C
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x18E5020
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x18E505C
	protected override void OnEnable() { }

	// RVA: 0x18E5064
	protected override void OnDisable() { }

	// RVA: 0x18E4C38
	private void RegisterCallbacks() { }

	// RVA: 0x18E4A7C
	private void UnregisterCallbacks() { }

	// RVA: 0x18E506C
	private void OnPanelDestroyed() { }

	// RVA: 0x18E50DC
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x18E52FC
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x18E5300
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18E5380
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18E5394
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x18E5724
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18E5940
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18E5C48
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18E5F8C
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18E5FF0
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18E6018
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18E6414
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x18E663C
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x18E6884
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18E56BC
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x18E6A74
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x18E6A98
	internal void Update() { }

	// RVA: 0x18E6B28
	private void LateUpdate() { }

	// RVA: 0x18E6240
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x18E6B30
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x18E6BC4
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x18E7054
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	// RVA: 0x18E6C3C
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x18E6E48
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x18E5540
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18E7764
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PanelRaycaster
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Methods

	// RVA: 0x18E7A8C
	public IPanel get_panel() { }

	// RVA: 0x18E7A94
	public void set_panel(IPanel value) { }

	// RVA: 0x18E7CD0
	private void RegisterCallbacks() { }

	// RVA: 0x18E7C30
	private void UnregisterCallbacks() { }

	// RVA: 0x18E7D70
	private void OnPanelDestroyed() { }

	// RVA: 0x18E7D78
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18E7D90
	public override int get_sortOrderPriority() { }

	// RVA: 0x18E7E38
	public override int get_renderOrderPriority() { }

	// RVA: 0x18E7ED8
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x18E8394
	public override Camera get_eventCamera() { }

	// RVA: 0x18E839C
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class AxisEventData
{
	// Fields
	private Vector2 <moveVector>k__BackingField; // 0x20
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Methods

	// RVA: 0x18E83AC
	public Vector2 get_moveVector() { }

	// RVA: 0x18E83B4
	public void set_moveVector(Vector2 value) { }

	// RVA: 0x18E83BC
	public MoveDirection get_moveDir() { }

	// RVA: 0x18E83C4
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x18E83CC
	public void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData
{
	// Fields
	protected bool m_Used; // 0x10

	// Methods

	// RVA: 0x18E8478
	public virtual void Reset() { }

	// RVA: 0x18E8480
	public virtual void Use() { }

	// RVA: 0x18E848C
	public virtual bool get_used() { }

	// RVA: 0x18E8494
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseEventData
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Methods

	// RVA: 0x18E8444
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18E849C
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18E84BC
	public GameObject get_selectedObject() { }

	// RVA: 0x18E84DC
	public void set_selectedObject(GameObject value) { }

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

	// RVA: 0x18E8784
	public GameObject get_pointerEnter() { }

	// RVA: 0x18E878C
	public void set_pointerEnter(GameObject value) { }

	// RVA: 0x18E8794
	public GameObject get_lastPress() { }

	// RVA: 0x18E879C
	private void set_lastPress(GameObject value) { }

	// RVA: 0x18E87A4
	public GameObject get_rawPointerPress() { }

	// RVA: 0x18E87AC
	public void set_rawPointerPress(GameObject value) { }

	// RVA: 0x18E87B4
	public GameObject get_pointerDrag() { }

	// RVA: 0x18E87BC
	public void set_pointerDrag(GameObject value) { }

	// RVA: 0x18E87C4
	public GameObject get_pointerClick() { }

	// RVA: 0x18E87CC
	public void set_pointerClick(GameObject value) { }

	// RVA: 0x18E87D4
	public RaycastResult get_pointerCurrentRaycast() { }

	// RVA: 0x18E87F0
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	// RVA: 0x18E8820
	public RaycastResult get_pointerPressRaycast() { }

	// RVA: 0x18E883C
	public void set_pointerPressRaycast(RaycastResult value) { }

	// RVA: 0x18E886C
	public bool get_eligibleForClick() { }

	// RVA: 0x18E8874
	public void set_eligibleForClick(bool value) { }

	// RVA: 0x18E887C
	public int get_displayIndex() { }

	// RVA: 0x18E8884
	public void set_displayIndex(int value) { }

	// RVA: 0x18E888C
	public int get_pointerId() { }

	// RVA: 0x18E8894
	public void set_pointerId(int value) { }

	// RVA: 0x18E889C
	public Vector2 get_position() { }

	// RVA: 0x18E88A8
	public void set_position(Vector2 value) { }

	// RVA: 0x18E88B4
	public Vector2 get_delta() { }

	// RVA: 0x18E88C0
	public void set_delta(Vector2 value) { }

	// RVA: 0x18E88CC
	public Vector2 get_pressPosition() { }

	// RVA: 0x18E88D8
	public void set_pressPosition(Vector2 value) { }

	// RVA: 0x18E88E4
	public Vector3 get_worldPosition() { }

	// RVA: 0x18E88F4
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x18E8904
	public Vector3 get_worldNormal() { }

	// RVA: 0x18E8914
	public void set_worldNormal(Vector3 value) { }

	// RVA: 0x18E8924
	public float get_clickTime() { }

	// RVA: 0x18E892C
	public void set_clickTime(float value) { }

	// RVA: 0x18E8934
	public int get_clickCount() { }

	// RVA: 0x18E893C
	public void set_clickCount(int value) { }

	// RVA: 0x18E8944
	public Vector2 get_scrollDelta() { }

	// RVA: 0x18E8950
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x18E895C
	public bool get_useDragThreshold() { }

	// RVA: 0x18E8964
	public void set_useDragThreshold(bool value) { }

	// RVA: 0x18E896C
	public bool get_dragging() { }

	// RVA: 0x18E8974
	public void set_dragging(bool value) { }

	// RVA: 0x18E897C
	public InputButton get_button() { }

	// RVA: 0x18E8984
	public void set_button(InputButton value) { }

	// RVA: 0x18E898C
	public float get_pressure() { }

	// RVA: 0x18E8994
	public void set_pressure(float value) { }

	// RVA: 0x18E899C
	public float get_tangentialPressure() { }

	// RVA: 0x18E89A4
	public void set_tangentialPressure(float value) { }

	// RVA: 0x18E89AC
	public float get_altitudeAngle() { }

	// RVA: 0x18E89B4
	public void set_altitudeAngle(float value) { }

	// RVA: 0x18E89BC
	public float get_azimuthAngle() { }

	// RVA: 0x18E89C4
	public void set_azimuthAngle(float value) { }

	// RVA: 0x18E89CC
	public float get_twist() { }

	// RVA: 0x18E89D4
	public void set_twist(float value) { }

	// RVA: 0x18E89DC
	public Vector2 get_tilt() { }

	// RVA: 0x18E89E8
	public void set_tilt(Vector2 value) { }

	// RVA: 0x18E89F4
	public PenStatus get_penStatus() { }

	// RVA: 0x18E89FC
	public void set_penStatus(PenStatus value) { }

	// RVA: 0x18E8A04
	public Vector2 get_radius() { }

	// RVA: 0x18E8A10
	public void set_radius(Vector2 value) { }

	// RVA: 0x18E8A1C
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18E8A28
	public void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18E8A34
	public bool get_fullyExited() { }

	// RVA: 0x18E8A3C
	public void set_fullyExited(bool value) { }

	// RVA: 0x18E8A44
	public bool get_reentered() { }

	// RVA: 0x18E8A4C
	public void set_reentered(bool value) { }

	// RVA: 0x18E8A54
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18E8B94
	public bool IsPointerMoving() { }

	// RVA: 0x18E8BB4
	public bool IsScrolling() { }

	// RVA: 0x18E8BD4
	public Camera get_enterEventCamera() { }

	// RVA: 0x18E8C98
	public Camera get_pressEventCamera() { }

	// RVA: 0x18E8D5C
	public GameObject get_pointerPress() { }

	// RVA: 0x18E8D64
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x18E8E40
	public override string ToString() { }

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

	// RVA: -1
	public abstract void OnPointerMove(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPointerEnter(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPointerExit(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPointerDown(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPointerUp(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler
{
	// Methods

	// RVA: -1
	public abstract void OnPointerClick(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler
{
	// Methods

	// RVA: -1
	public abstract void OnBeginDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler
{
	// Methods

	// RVA: -1
	public abstract void OnInitializePotentialDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler
{
	// Methods

	// RVA: -1
	public abstract void OnDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler
{
	// Methods

	// RVA: -1
	public abstract void OnEndDrag(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler
{
	// Methods

	// RVA: -1
	public abstract void OnDrop(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler
{
	// Methods

	// RVA: -1
	public abstract void OnScroll(PointerEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler
{
	// Methods

	// RVA: -1
	public abstract void OnUpdateSelected(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler
{
	// Methods

	// RVA: -1
	public abstract void OnSelect(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler
{
	// Methods

	// RVA: -1
	public abstract void OnDeselect(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler
{
	// Methods

	// RVA: -1
	public abstract void OnMove(AxisEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler
{
	// Methods

	// RVA: -1
	public abstract void OnSubmit(BaseEventData eventData) { }

}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler
{
	// Methods

	// RVA: -1
	public abstract void OnCancel(BaseEventData eventData) { }

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

	// RVA: 0x18EB5CC
	public void .ctor() { }

	// RVA: 0x18EC12C
	internal void <CreateUIToolkitPanelGameObject>b__0() { }

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

	// RVA: 0x18E9BD0
	public static EventSystem get_current() { }

	// RVA: 0x18E9CCC
	public static void set_current(EventSystem value) { }

	// RVA: 0x18E9EA4
	public bool get_sendNavigationEvents() { }

	// RVA: 0x18E9EAC
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x18E9EB4
	public int get_pixelDragThreshold() { }

	// RVA: 0x18E9EBC
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x18E9EC4
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18E9ECC
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x18E9ED4
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x18E9EDC
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x18E9EE4
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x18E9EEC
	public bool get_isFocused() { }

	// RVA: 0x18E9EF4
	protected void .ctor() { }

	// RVA: 0x18E9F94
	public void UpdateModules() { }

	// RVA: 0x18EA108
	public bool get_alreadySelecting() { }

	// RVA: 0x18E84FC
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x18EA110
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x18E523C
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x18EA1BC
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x18EA6B8
	public void RaycastAll(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }

	// RVA: 0x18EA938
	public bool IsPointerOverGameObject() { }

	// RVA: 0x18EA9FC
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18EAAC4
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x18EAC04
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x18EACA0
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x18EAD3C
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart) { }

	// RVA: 0x18EAF10
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x18EB514
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x18EB244
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x18EB5D4
	protected override void Start() { }

	// RVA: 0x18EB5E4
	protected override void OnEnable() { }

	// RVA: 0x18EB76C
	protected override void OnDisable() { }

	// RVA: 0x18EB8D0
	private void TickModules() { }

	// RVA: 0x18EBA04
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18EBA14
	protected virtual void Update() { }

	// RVA: 0x18EBCFC
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x18EBE6C
	public override string ToString() { }

	// RVA: 0x18EBFEC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class TriggerEvent
{
	// Methods

	// RVA: 0x18EC580
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class Entry
{
	// Fields
	public EventTriggerType eventID; // 0x10
	public TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x18EC5D4
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class EventTrigger
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates; // 0x20

	// Methods

	// RVA: 0x18EC1BC
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }

	// RVA: 0x18EC2F4
	public void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18EC2FC
	protected void .ctor() { }

	// RVA: 0x18EC258
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }

	// RVA: 0x18EC304
	public void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18EC30C
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x18EC4B4
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18EC4C0
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18EC4CC
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18EC4D8
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x18EC4E4
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18EC4F0
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18EC4FC
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18EC508
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18EC514
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18EC520
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18EC52C
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18EC538
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x18EC544
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18EC550
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18EC55C
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18EC568
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18EC574
	public virtual void OnCancel(BaseEventData eventData) { }

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
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }

	// RVA: 0x318DB98
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x30D4CD4
	public virtual void EndInvoke(IAsyncResult result) { }

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

	// RVA: 0x318DB98
	public static T ValidateEventData(BaseEventData data) { }

	// RVA: 0x18EC680
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18EC79C
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x18EC8B8
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18EC9D4
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ECAF0
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ECC0C
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ECD28
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ECE44
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ECF60
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED07C
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED198
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED2B4
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED3D0
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED480
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED530
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED5E0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED6FC
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED7AC
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x18ED85C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x18ED8D8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x18ED954
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x18ED9D0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x18EDA4C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x18EDAC8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x18EDB44
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x18EDBC0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x18EDC3C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }

	// RVA: 0x18EDCB8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x18EDD34
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }

	// RVA: 0x18EDDB0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }

	// RVA: 0x18EDE2C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x18EDEA8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }

	// RVA: 0x18EDF24
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x18EDFA0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }

	// RVA: 0x18EE01C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }

	// RVA: 0x18EE098
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }

	// RVA: 0x18EE114
	private static void GetEventChain(GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }

	// RVA: 0x30D6280
	public static bool Execute(GameObject target, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }

	// RVA: 0x30D7A20
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }

	// RVA: 0x30D5E84
	private static bool ShouldSendToComponent(Component component) { }

	// RVA: 0x30DB358
	private static void GetEventList(GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }

	// RVA: 0x30D5E84
	public static bool CanHandleEvent(GameObject go) { }

	// RVA: 0x30D77E4
	public static GameObject GetEventHandler(GameObject root) { }

	// RVA: 0x18EE2FC
	private static void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseInput
{
	// Methods

	// RVA: 0x18EE9E4
	public virtual string get_compositionString() { }

	// RVA: 0x18EE9EC
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x18EE9F4
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x18EEA00
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x18EEA08
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x18EEA10
	public virtual bool get_mousePresent() { }

	// RVA: 0x18EEA18
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x18EEA24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x18EEA30
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x18EEA3C
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x18EEA44
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x18EEA4C
	public virtual bool get_touchSupported() { }

	// RVA: 0x18EEA54
	public virtual int get_touchCount() { }

	// RVA: 0x18EEA5C
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x18EEAB0
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x18EEABC
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x18EEAC8
	public void .ctor() { }

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

	// RVA: 0x18EEAD0
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x18EEAD8
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x18EEAE0
	public BaseInput get_input() { }

	// RVA: 0x18EED78
	public BaseInput get_inputOverride() { }

	// RVA: 0x18EED80
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x18EED88
	protected EventSystem get_eventSystem() { }

	// RVA: 0x18EED90
	protected override void OnEnable() { }

	// RVA: 0x18EEE14
	protected override void OnDisable() { }

	// RVA: -1
	public abstract void Process() { }

	// RVA: 0x18EEE30
	protected static RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }

	// RVA: 0x18EEF58
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x18EEFAC
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x18EEFF8
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x18EF1F0
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x18EFEAC
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x18F0004
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x18F00B0
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18F00B8
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x18F0104
	public virtual void DeactivateModule() { }

	// RVA: 0x18F0108
	public virtual void ActivateModule() { }

	// RVA: 0x18F010C
	public virtual void UpdateModule() { }

	// RVA: 0x18F0110
	public virtual bool IsModuleSupported() { }

	// RVA: 0x18F0118
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x18F01C4
	protected void .ctor() { }

}

// Namespace: 
protected class ButtonState
{
	// Fields
	private InputButton m_Button; // 0x10
	private MouseButtonEventData m_EventData; // 0x18

	// Methods

	// RVA: 0x18F1E8C
	public MouseButtonEventData get_eventData() { }

	// RVA: 0x18F1E94
	public void set_eventData(MouseButtonEventData value) { }

	// RVA: 0x18F1E9C
	public InputButton get_button() { }

	// RVA: 0x18F1EA4
	public void set_button(InputButton value) { }

	// RVA: 0x18F1EAC
	public void .ctor() { }

}

// Namespace: 
protected class MouseState
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x18F1EB4
	public bool AnyPressesThisFrame() { }

	// RVA: 0x18F1FA0
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x18F2094
	public ButtonState GetButtonState(InputButton button) { }

	// RVA: 0x18F0DDC
	public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x18F1E00
	public void .ctor() { }

}

// Namespace: 
public class MouseButtonEventData
{
	// Fields
	public FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x18F1F90
	public bool PressedThisFrame() { }

	// RVA: 0x18F2080
	public bool ReleasedThisFrame() { }

	// RVA: 0x18F220C
	public void .ctor() { }

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

	// RVA: 0x18F0258
	protected bool GetPointerData(int id, PointerEventData data, bool create) { }

	// RVA: 0x18F0364
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x18F03E0
	protected PointerEventData GetTouchPointerEventData(Touch input, bool pressed, bool released) { }

	// RVA: 0x18F07C0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x18F088C
	protected FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x18F0914
	protected virtual MouseState GetMousePointerEventData() { }

	// RVA: 0x18F0928
	protected virtual MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x18F0E1C
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x18F0EB4
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x18F0EE4
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x18F0F2C
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x18F1334
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18F144C
	protected void ClearSelection() { }

	// RVA: 0x18F1688
	public override string ToString() { }

	// RVA: 0x18F1B2C
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x18F1C68
	protected void .ctor() { }

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
	private const float doubleClickTime = 0.3;
	private string m_HorizontalAxis; // 0x98
	private string m_VerticalAxis; // 0xA0
	private string m_SubmitButton; // 0xA8
	private string m_CancelButton; // 0xB0
	private float m_InputActionsPerSecond; // 0xB8
	private float m_RepeatDelay; // 0xBC
	private bool m_ForceModuleActive; // 0xC0

	// Methods

	// RVA: 0x18F2214
	protected void .ctor() { }

	// RVA: 0x18F22F4
	public InputMode get_inputMode() { }

	// RVA: 0x18F22FC
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x18F2304
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x18F230C
	public bool get_forceModuleActive() { }

	// RVA: 0x18F2314
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18F231C
	public float get_inputActionsPerSecond() { }

	// RVA: 0x18F2324
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x18F232C
	public float get_repeatDelay() { }

	// RVA: 0x18F2334
	public void set_repeatDelay(float value) { }

	// RVA: 0x18F233C
	public string get_horizontalAxis() { }

	// RVA: 0x18F2344
	public void set_horizontalAxis(string value) { }

	// RVA: 0x18F234C
	public string get_verticalAxis() { }

	// RVA: 0x18F2354
	public void set_verticalAxis(string value) { }

	// RVA: 0x18F235C
	public string get_submitButton() { }

	// RVA: 0x18F2364
	public void set_submitButton(string value) { }

	// RVA: 0x18F236C
	public string get_cancelButton() { }

	// RVA: 0x18F2374
	public void set_cancelButton(string value) { }

	// RVA: 0x18F237C
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x18F2384
	public override void UpdateModule() { }

	// RVA: 0x18F2490
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x18F2988
	public override bool ShouldActivateModule() { }

	// RVA: 0x18F2BE4
	public override void ActivateModule() { }

	// RVA: 0x18F2D10
	public override void DeactivateModule() { }

	// RVA: 0x18F2D14
	public override void Process() { }

	// RVA: 0x18F2F34
	private bool ProcessTouchEvents() { }

	// RVA: 0x18F3628
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18F33B8
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x18F3FFC
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x18F3104
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x18F30FC
	protected void ProcessMouseEvent() { }

	// RVA: 0x18F43DC
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x18F410C
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x18F2DB8
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x18F43E4
	protected void ProcessMousePress(MouseButtonEventData data) { }

	// RVA: 0x18F48DC
	protected GameObject GetCurrentFocusedGameObject() { }

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

	// RVA: 0x18F48E4
	protected void .ctor() { }

	// RVA: 0x18F48E8
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x18F48F0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x18F48F8
	public bool get_forceModuleActive() { }

	// RVA: 0x18F4900
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18F4908
	public override void UpdateModule() { }

	// RVA: 0x18F4AA8
	public override bool IsModuleSupported() { }

	// RVA: 0x18F4AE4
	public override bool ShouldActivateModule() { }

	// RVA: 0x18F4BC8
	private bool UseFakeInput() { }

	// RVA: 0x18F4BF8
	public override void Process() { }

	// RVA: 0x18F4C48
	private void FakeTouches() { }

	// RVA: 0x18F4D74
	private void ProcessTouchEvents() { }

	// RVA: 0x18F4F1C
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18F58DC
	public override void DeactivateModule() { }

	// RVA: 0x18F58E0
	public override string ToString() { }

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

	// RVA: 0x18F5C24
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18F5D20
	public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }

	// RVA: 0x18F5D9C
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18F5E98
	private static void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Methods

	// RVA: -1
	public abstract void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: -1
	public abstract Camera get_eventCamera() { }

	// RVA: 0x18F5F34
	public virtual int get_priority() { }

	// RVA: 0x18F5F3C
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x18F5F44
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x18EA5AC
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x18F5F4C
	public override string ToString() { }

	// RVA: 0x18F61BC
	protected override void OnEnable() { }

	// RVA: 0x18F623C
	protected override void OnDisable() { }

	// RVA: 0x18F62BC
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18F62CC
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18E83A4
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class Physics2DRaycaster
{
	// Methods

	// RVA: 0x18F62DC
	protected void .ctor() { }

	// RVA: 0x18F6344
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: 
private class RaycastHitComparer
{
	// Fields
	public static RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x18F6D40
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x18F6D8C
	public void .ctor() { }

	// RVA: 0x18F6D94
	private static void .cctor() { }

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

	// RVA: 0x18F6310
	protected void .ctor() { }

	// RVA: 0x18F6348
	public override Camera get_eventCamera() { }

	// RVA: 0x18F6490
	public virtual int get_depth() { }

	// RVA: 0x18F657C
	public int get_finalEventMask() { }

	// RVA: 0x18F6664
	public LayerMask get_eventMask() { }

	// RVA: 0x18F666C
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x18F6674
	public int get_maxRayIntersections() { }

	// RVA: 0x18F667C
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x18F6684
	protected bool ComputeRayAndDistance(PointerEventData eventData, Ray ray, int eventDisplayIndex, float distanceToClipPlane) { }

	// RVA: 0x18F698C
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

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

	// RVA: 0x18F6E00
	public GameObject get_gameObject() { }

	// RVA: 0x18F6E08
	public void set_gameObject(GameObject value) { }

	// RVA: 0x18F6E10
	public bool get_isValid() { }

	// RVA: 0x18F6ED8
	public void Clear() { }

	// RVA: 0x18E9554
	public override string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour
{
	// Methods

	// RVA: 0x18F6FA4
	protected virtual void Awake() { }

	// RVA: 0x18E5060
	protected virtual void OnEnable() { }

	// RVA: 0x18EB5E0
	protected virtual void Start() { }

	// RVA: 0x18E5068
	protected virtual void OnDisable() { }

	// RVA: 0x18F6FA8
	protected virtual void OnDestroy() { }

	// RVA: 0x18F6FAC
	public virtual bool IsActive() { }

	// RVA: 0x18F6FB4
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x18F6FB8
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x18F62D8
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x18F6FBC
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x18F6FC0
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x18F62C8
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x18F6FC4
	public bool IsDestroyed() { }

	// RVA: 0x18E781C
	protected void .ctor() { }

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


