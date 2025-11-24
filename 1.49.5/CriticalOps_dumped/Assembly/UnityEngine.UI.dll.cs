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

	// RVA: 0x16F5BA8
	private static MonoScriptData Get() { }

	// RVA: 0x16F5CAC
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

	// RVA: 0x16F5CB4
	public string get_normalTrigger() { }

	// RVA: 0x16F5CBC
	public void set_normalTrigger(string value) { }

	// RVA: 0x16F5CC4
	public string get_highlightedTrigger() { }

	// RVA: 0x16F5CCC
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x16F5CD4
	public string get_pressedTrigger() { }

	// RVA: 0x16F5CDC
	public void set_pressedTrigger(string value) { }

	// RVA: 0x16F5CE4
	public string get_selectedTrigger() { }

	// RVA: 0x16F5CEC
	public void set_selectedTrigger(string value) { }

	// RVA: 0x16F5CF4
	public string get_disabledTrigger() { }

	// RVA: 0x16F5CFC
	public void set_disabledTrigger(string value) { }

	// RVA: 0x16F5D04
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ButtonClickedEvent
{
	// Methods

	// RVA: 0x16F5EBC
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

	// RVA: 0x16F61E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x16F6214
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16F6218
	private bool MoveNext() { }

	// RVA: 0x16F632C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16F6334
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16F6374
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Button
{
	// Fields
	private ButtonClickedEvent m_OnClick; // 0x100

	// Methods

	// RVA: 0x16F5E08
	protected void .ctor() { }

	// RVA: 0x16F5EC4
	public ButtonClickedEvent get_onClick() { }

	// RVA: 0x16F5ECC
	public void set_onClick(ButtonClickedEvent value) { }

	// RVA: 0x16F5EDC
	private void Press() { }

	// RVA: 0x16F5F78
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x16F6020
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x16F6170
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

	// RVA: 0x16F637C
	protected void .ctor() { }

	// RVA: 0x16F65C0
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x16F66A8
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x16F67AC
	private void CleanInvalidItems() { }

	// RVA: 0x16F6AC0
	private void PerformUpdate() { }

	// RVA: 0x16F76C4
	private static int ParentCount(Transform child) { }

	// RVA: 0x16F77A8
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x16F790C
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16F7AB0
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16F7A08
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16F7BB0
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16F7D0C
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16F7C30
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16F7D8C
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x16F8130
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x16F7E20
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16F7FA8
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16F81C4
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16F834C
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16F84D4
	public static bool IsRebuildingLayout() { }

	// RVA: 0x16F8548
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x16F85BC
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

	// RVA: 0x16F8658
	public Color get_normalColor() { }

	// RVA: 0x16F8664
	public void set_normalColor(Color value) { }

	// RVA: 0x16F8670
	public Color get_highlightedColor() { }

	// RVA: 0x16F867C
	public void set_highlightedColor(Color value) { }

	// RVA: 0x16F8688
	public Color get_pressedColor() { }

	// RVA: 0x16F8694
	public void set_pressedColor(Color value) { }

	// RVA: 0x16F86A0
	public Color get_selectedColor() { }

	// RVA: 0x16F86AC
	public void set_selectedColor(Color value) { }

	// RVA: 0x16F86B8
	public Color get_disabledColor() { }

	// RVA: 0x16F86C4
	public void set_disabledColor(Color value) { }

	// RVA: 0x16F86D0
	public float get_colorMultiplier() { }

	// RVA: 0x16F86D8
	public void set_colorMultiplier(float value) { }

	// RVA: 0x16F86E0
	public float get_fadeDuration() { }

	// RVA: 0x16F86E8
	public void set_fadeDuration(float value) { }

	// RVA: 0x16F86F0
	private static void .cctor() { }

	// RVA: 0x16F876C
	public override bool Equals(object obj) { }

	// RVA: 0x16F8864
	public bool Equals(ColorBlock other) { }

	// RVA: 0x16F8A98
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16F8B4C
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16F8C04
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UI
public class ClipperRegistry
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers; // 0x10

	// Methods

	// RVA: 0x16F8C8C
	protected void .ctor() { }

	// RVA: 0x16F7464
	public static ClipperRegistry get_instance() { }

	// RVA: 0x16F758C
	public void Cull() { }

	// RVA: 0x16F8D18
	public static void Register(IClipper c) { }

	// RVA: 0x16F8D8C
	public static void Unregister(IClipper c) { }

	// RVA: 0x16F8DEC
	public static void Disable(IClipper c) { }

}

// Namespace: UnityEngine.UI
public static class Clipping
{
	// Methods

	// RVA: 0x16F8E4C
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

	// RVA: 0x16F9058
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x16F927C
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

	// RVA: 0x16FE7E4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x16FE854
	public void .ctor() { }

	// RVA: 0x16FE85C
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

	// RVA: 0x16F9308
	public static IFactoryControls get_factory() { }

	// RVA: 0x16F9384
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x16F9544
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x16F97E0
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x16F98EC
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x16F96A8
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x16F9950
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x16F9A44
	public static GameObject CreatePanel(Resources resources) { }

	// RVA: 0x16FA1EC
	public static GameObject CreateButton(Resources resources) { }

	// RVA: 0x16FA6AC
	public static GameObject CreateText(Resources resources) { }

	// RVA: 0x16FA868
	public static GameObject CreateImage(Resources resources) { }

	// RVA: 0x16FA9B0
	public static GameObject CreateRawImage(Resources resources) { }

	// RVA: 0x16FAAF8
	public static GameObject CreateSlider(Resources resources) { }

	// RVA: 0x16FB308
	public static GameObject CreateScrollbar(Resources resources) { }

	// RVA: 0x16FB8A0
	public static GameObject CreateToggle(Resources resources) { }

	// RVA: 0x16FBF38
	public static GameObject CreateInputField(Resources resources) { }

	// RVA: 0x16FC628
	public static GameObject CreateDropdown(Resources resources) { }

	// RVA: 0x16FDD28
	public static GameObject CreateScrollView(Resources resources) { }

	// RVA: 0x16FE720
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

	// RVA: 0x1701F18
	public Text get_text() { }

	// RVA: 0x1701F20
	public void set_text(Text value) { }

	// RVA: 0x1701F28
	public Image get_image() { }

	// RVA: 0x1701F30
	public void set_image(Image value) { }

	// RVA: 0x1701F38
	public RectTransform get_rectTransform() { }

	// RVA: 0x1701F40
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1701F48
	public Toggle get_toggle() { }

	// RVA: 0x1701F50
	public void set_toggle(Toggle value) { }

	// RVA: 0x1701F58
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1701FE0
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x17020B0
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

	// RVA: 0x17020B8
	public string get_text() { }

	// RVA: 0x17020C0
	public void set_text(string value) { }

	// RVA: 0x17020C8
	public Sprite get_image() { }

	// RVA: 0x17020D0
	public void set_image(Sprite value) { }

	// RVA: 0x16FDAD0
	public void .ctor() { }

	// RVA: 0x16FF450
	public void .ctor(string text) { }

	// RVA: 0x16FF5B0
	public void .ctor(Sprite image) { }

	// RVA: 0x17020D8
	public void .ctor(string text, Sprite image) { }

}

// Namespace: 
[Serializable]
public class OptionDataList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options; // 0x10

	// Methods

	// RVA: 0x1702128
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x1702130
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x16FECF8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DropdownEvent
{
	// Methods

	// RVA: 0x16FED84
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass63_0
{
	// Fields
	public DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1700F2C
	public void .ctor() { }

	// RVA: 0x1702138
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

	// RVA: 0x1701D34
	public void .ctor(int <>1__state) { }

	// RVA: 0x1702160
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1702164
	private bool MoveNext() { }

	// RVA: 0x1702228
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1702230
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1702270
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

	// RVA: 0x16FE8C8
	public RectTransform get_template() { }

	// RVA: 0x16FDA2C
	public void set_template(RectTransform value) { }

	// RVA: 0x16FE8D0
	public Text get_captionText() { }

	// RVA: 0x16FDA58
	public void set_captionText(Text value) { }

	// RVA: 0x16FE8D8
	public Image get_captionImage() { }

	// RVA: 0x16FE8E0
	public void set_captionImage(Image value) { }

	// RVA: 0x16FE90C
	public Text get_itemText() { }

	// RVA: 0x16FDA84
	public void set_itemText(Text value) { }

	// RVA: 0x16FE914
	public Image get_itemImage() { }

	// RVA: 0x16FE91C
	public void set_itemImage(Image value) { }

	// RVA: 0x16FDAB0
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x16FE948
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x16FE97C
	public DropdownEvent get_onValueChanged() { }

	// RVA: 0x16FE984
	public void set_onValueChanged(DropdownEvent value) { }

	// RVA: 0x16FE994
	public float get_alphaFadeSpeed() { }

	// RVA: 0x16FE99C
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x16FE9A4
	public int get_value() { }

	// RVA: 0x16FE9AC
	public void set_value(int value) { }

	// RVA: 0x16FEB24
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x16FE9B4
	private void Set(int value, bool sendCallback) { }

	// RVA: 0x16FEB2C
	protected void .ctor() { }

	// RVA: 0x16FEDD8
	protected override void Awake() { }

	// RVA: 0x16FEF18
	protected override void Start() { }

	// RVA: 0x16FEFD0
	protected override void OnDisable() { }

	// RVA: 0x16FDAD8
	public void RefreshShownValue() { }

	// RVA: 0x16FF2B0
	public void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }

	// RVA: 0x16FF324
	public void AddOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x16FF484
	public void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }

	// RVA: 0x16FF5E4
	public void ClearOptions() { }

	// RVA: 0x16FF6A0
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: 0x316B894
	private static T GetOrAddComponent(GameObject go) { }

	// RVA: 0x16FFDE4
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1700D14
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1700D18
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x16FFDE8
	public void Show() { }

	// RVA: 0x1701358
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x17018BC
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1701944
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x17019E8
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1701A70
	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) { }

	// RVA: 0x1701B14
	protected virtual void DestroyItem(DropdownItem item) { }

	// RVA: 0x1700F34
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }

	// RVA: 0x1701B18
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x170124C
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1701BB0
	private void SetAlpha(float alpha) { }

	// RVA: 0x1700D1C
	public void Hide() { }

	// RVA: 0x1701CAC
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x16FF098
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1701D60
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1701E90
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

	// RVA: 0x1702278
	public static FontData get_defaultFontData() { }

	// RVA: 0x1702314
	public Font get_font() { }

	// RVA: 0x170231C
	public void set_font(Font value) { }

	// RVA: 0x1702324
	public int get_fontSize() { }

	// RVA: 0x170232C
	public void set_fontSize(int value) { }

	// RVA: 0x1702334
	public FontStyle get_fontStyle() { }

	// RVA: 0x170233C
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1702344
	public bool get_bestFit() { }

	// RVA: 0x170234C
	public void set_bestFit(bool value) { }

	// RVA: 0x1702354
	public int get_minSize() { }

	// RVA: 0x170235C
	public void set_minSize(int value) { }

	// RVA: 0x1702364
	public int get_maxSize() { }

	// RVA: 0x170236C
	public void set_maxSize(int value) { }

	// RVA: 0x1702374
	public TextAnchor get_alignment() { }

	// RVA: 0x170237C
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1702384
	public bool get_alignByGeometry() { }

	// RVA: 0x170238C
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1702394
	public bool get_richText() { }

	// RVA: 0x170239C
	public void set_richText(bool value) { }

	// RVA: 0x17023A4
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x17023AC
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x17023B4
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x17023BC
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x17023C4
	public float get_lineSpacing() { }

	// RVA: 0x17023CC
	public void set_lineSpacing(float value) { }

	// RVA: 0x17023D4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x17023D8
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x170230C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x170241C
	public static void TrackText(Text t) { }

	// RVA: 0x1702694
	private static void RebuildForFont(Font f) { }

	// RVA: 0x17028D0
	public static void UntrackText(Text t) { }

	// RVA: 0x1702B08
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

	// RVA: 0x1702BA4
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x1702CF4
	public virtual Color get_color() { }

	// RVA: 0x1702D00
	public virtual void set_color(Color value) { }

	// RVA: 0x1702D48
	public virtual bool get_raycastTarget() { }

	// RVA: 0x1702D50
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x1703434
	public Vector4 get_raycastPadding() { }

	// RVA: 0x1703440
	public void set_raycastPadding(Vector4 value) { }

	// RVA: 0x170344C
	protected bool get_useLegacyMeshGeneration() { }

	// RVA: 0x1703454
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x170345C
	protected void .ctor() { }

	// RVA: 0x1703534
	public virtual void SetAllDirty() { }

	// RVA: 0x17037CC
	public virtual void SetLayoutDirty() { }

	// RVA: 0x1703990
	public virtual void SetVerticesDirty() { }

	// RVA: 0x1703A90
	public virtual void SetMaterialDirty() { }

	// RVA: 0x17035B4
	public void SetRaycastDirty() { }

	// RVA: 0x1703B90
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1703CA0
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1704068
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1704590
	public int get_depth() { }

	// RVA: 0x17038F8
	public RectTransform get_rectTransform() { }

	// RVA: 0x1702F4C
	public Canvas get_canvas() { }

	// RVA: 0x1704188
	private void CacheCanvas() { }

	// RVA: 0x17045B0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1704684
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x17046EC
	public virtual Material get_material() { }

	// RVA: 0x17047A8
	public virtual void set_material(Material value) { }

	// RVA: 0x1704888
	public virtual Material get_materialForRendering() { }

	// RVA: 0x1704A6C
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1704AE8
	protected override void OnEnable() { }

	// RVA: 0x1704CC4
	protected override void OnDisable() { }

	// RVA: 0x1705120
	protected override void OnDestroy() { }

	// RVA: 0x17052F4
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17054E4
	public virtual void OnCullingChanged() { }

	// RVA: 0x17055D8
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x17056F8
	public virtual void LayoutComplete() { }

	// RVA: 0x17056FC
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1705700
	protected virtual void UpdateMaterial() { }

	// RVA: 0x17057BC
	protected virtual void UpdateGeometry() { }

	// RVA: 0x1705C54
	private void DoMeshGeneration() { }

	// RVA: 0x17057CC
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x1706140
	protected static Mesh get_workerMesh() { }

	// RVA: 0x17062D8
	protected virtual void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }

	// RVA: 0x17062DC
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1706378
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x170696C
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x170697C
	public virtual void SetNativeSize() { }

	// RVA: 0x1706980
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1706EE4
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x17064D8
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x17072B4
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x17072C8
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x1707538
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x170754C
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x17075EC
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x17076A0
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1707754
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1707808
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x17078BC
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1707970
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1707A24
	private static void .cctor() { }

	// RVA: 0x1707AD4
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

	// RVA: 0x17090EC
	private static void .cctor() { }

	// RVA: 0x1709158
	public void .ctor() { }

	// RVA: 0x1709160
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

	// RVA: 0x1707ADC
	public override int get_sortOrderPriority() { }

	// RVA: 0x1707C2C
	public override int get_renderOrderPriority() { }

	// RVA: 0x1707C90
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1707C98
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1707CA0
	public BlockingObjects get_blockingObjects() { }

	// RVA: 0x1707CA8
	public void set_blockingObjects(BlockingObjects value) { }

	// RVA: 0x1707CB0
	public LayerMask get_blockingMask() { }

	// RVA: 0x1707CB8
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x1707CC0
	protected void .ctor() { }

	// RVA: 0x1707B34
	private Canvas get_canvas() { }

	// RVA: 0x1707D64
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1708F7C
	public override Camera get_eventCamera() { }

	// RVA: 0x170891C
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }

	// RVA: 0x1709050
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

	// RVA: 0x17091CC
	protected void .ctor() { }

	// RVA: 0x1709390
	public static GraphicRegistry get_instance() { }

	// RVA: 0x1704348
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17031DC
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1703E68
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1703004
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1704F4C
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1709478
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x170963C
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1708838
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1709720
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

	// RVA: 0x17097B4
	public Sprite get_sprite() { }

	// RVA: 0x16F9D74
	public void set_sprite(Sprite value) { }

	// RVA: 0x1709A4C
	public void DisableSpriteOptimizations() { }

	// RVA: 0x1709A54
	public Sprite get_overrideSprite() { }

	// RVA: 0x1709B5C
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x1709AD8
	private Sprite get_activeSprite() { }

	// RVA: 0x1709BE8
	public Type get_type() { }

	// RVA: 0x16FA13C
	public void set_type(Type value) { }

	// RVA: 0x1709BF0
	public bool get_preserveAspect() { }

	// RVA: 0x1709BF8
	public void set_preserveAspect(bool value) { }

	// RVA: 0x1709CA8
	public bool get_fillCenter() { }

	// RVA: 0x1709CB0
	public void set_fillCenter(bool value) { }

	// RVA: 0x1709D60
	public FillMethod get_fillMethod() { }

	// RVA: 0x1709D68
	public void set_fillMethod(FillMethod value) { }

	// RVA: 0x1709E1C
	public float get_fillAmount() { }

	// RVA: 0x1709E24
	public void set_fillAmount(float value) { }

	// RVA: 0x1709EC8
	public bool get_fillClockwise() { }

	// RVA: 0x1709ED0
	public void set_fillClockwise(bool value) { }

	// RVA: 0x1709F80
	public int get_fillOrigin() { }

	// RVA: 0x1709F88
	public void set_fillOrigin(int value) { }

	// RVA: 0x170A038
	public float get_eventAlphaThreshold() { }

	// RVA: 0x170A048
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x170A1C4
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x170A054
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x170A1CC
	public bool get_useSpriteMesh() { }

	// RVA: 0x170A1D4
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x170A284
	protected void .ctor() { }

	// RVA: 0x170A2D0
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x170A420
	public override Texture get_mainTexture() { }

	// RVA: 0x170A6B4
	public bool get_hasBorder() { }

	// RVA: 0x170A860
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x170A868
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x170A890
	public float get_pixelsPerUnit() { }

	// RVA: 0x170AB60
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x170AB88
	public override Material get_material() { }

	// RVA: 0x170ADC8
	public override void set_material(Material value) { }

	// RVA: 0x170AEA8
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x170AEAC
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x170AF00
	private void PreserveSpriteAspectRatio(Rect rect, Vector2 spriteSize) { }

	// RVA: 0x170B064
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x170B634
	public override void SetNativeSize() { }

	// RVA: 0x170B984
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1709850
	private void TrackSprite() { }

	// RVA: 0x170EA44
	protected override void OnEnable() { }

	// RVA: 0x170EA6C
	protected override void OnDisable() { }

	// RVA: 0x170EC14
	protected override void UpdateMaterial() { }

	// RVA: 0x170EDF0
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x170BB50
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x170BECC
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x170C430
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x170CCA4
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x170F318
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x170F1B8
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x170F08C
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x170DDD4
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x170F490
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x170F5E0
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x170F9E8
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x170F9EC
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x170F9F0
	public virtual float get_minWidth() { }

	// RVA: 0x170F9F8
	public virtual float get_preferredWidth() { }

	// RVA: 0x170FC0C
	public virtual float get_flexibleWidth() { }

	// RVA: 0x170FC14
	public virtual float get_minHeight() { }

	// RVA: 0x170FC1C
	public virtual float get_preferredHeight() { }

	// RVA: 0x170FE30
	public virtual float get_flexibleHeight() { }

	// RVA: 0x170FE38
	public virtual int get_layoutPriority() { }

	// RVA: 0x170FE40
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x17104B0
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x171080C
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x170E8E8
	private static void TrackImage(Image g) { }

	// RVA: 0x170EB70
	private static void UnTrackImage(Image g) { }

	// RVA: 0x1710AB4
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1710AF8
	private static void .cctor() { }

	// RVA: 0x17097BC
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	// RVA: 0x1710C58
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

	// RVA: 0x1890748
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x189C10C
	public virtual Char Invoke(string text, int charIndex, Char addedChar) { }

	// RVA: 0x189C120
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, Char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x189C214
	public virtual Char EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class SubmitEvent
{
	// Methods

	// RVA: 0x188FDEC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class EndEditEvent
{
	// Methods

	// RVA: 0x188FE40
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class OnChangeEvent
{
	// Methods

	// RVA: 0x188FE94
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

	// RVA: 0x1892E50
	public void .ctor(int <>1__state) { }

	// RVA: 0x189C240
	private void System.IDisposable.Dispose() { }

	// RVA: 0x189C244
	private bool MoveNext() { }

	// RVA: 0x189C3CC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x189C3D4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x189C414
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

	// RVA: 0x1895FF0
	public void .ctor(int <>1__state) { }

	// RVA: 0x189C41C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x189C420
	private bool MoveNext() { }

	// RVA: 0x189C6C0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x189C6C8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x189C708
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

	// RVA: 0x188F964
	private BaseInput get_input() { }

	// RVA: 0x188FACC
	private string get_compositionString() { }

	// RVA: 0x188FB88
	protected void .ctor() { }

	// RVA: 0x188FFD0
	protected Mesh get_mesh() { }

	// RVA: 0x18900C0
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x189014C
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x18901B8
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1890280
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1890288
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1890304
	public string get_text() { }

	// RVA: 0x189030C
	public void set_text(string value) { }

	// RVA: 0x1890740
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1890314
	private void SetText(string value, bool sendCallback) { }

	// RVA: 0x1890DF8
	public bool get_isFocused() { }

	// RVA: 0x1890E00
	public float get_caretBlinkRate() { }

	// RVA: 0x1890E08
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1890F68
	public int get_caretWidth() { }

	// RVA: 0x1890F70
	public void set_caretWidth(int value) { }

	// RVA: 0x18910D8
	public Text get_textComponent() { }

	// RVA: 0x18910E0
	public void set_textComponent(Text value) { }

	// RVA: 0x1891384
	public Graphic get_placeholder() { }

	// RVA: 0x189138C
	public void set_placeholder(Graphic value) { }

	// RVA: 0x18913E8
	public Color get_caretColor() { }

	// RVA: 0x1891434
	public void set_caretColor(Color value) { }

	// RVA: 0x18914DC
	public bool get_customCaretColor() { }

	// RVA: 0x18914E4
	public void set_customCaretColor(bool value) { }

	// RVA: 0x189158C
	public Color get_selectionColor() { }

	// RVA: 0x18915A0
	public void set_selectionColor(Color value) { }

	// RVA: 0x1891648
	public EndEditEvent get_onEndEdit() { }

	// RVA: 0x1891650
	public void set_onEndEdit(EndEditEvent value) { }

	// RVA: 0x18916AC
	public SubmitEvent get_onSubmit() { }

	// RVA: 0x18916B4
	public void set_onSubmit(SubmitEvent value) { }

	// RVA: 0x1891710
	public OnChangeEvent get_onValueChange() { }

	// RVA: 0x1891718
	public void set_onValueChange(OnChangeEvent value) { }

	// RVA: 0x18917D0
	public OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1891774
	public void set_onValueChanged(OnChangeEvent value) { }

	// RVA: 0x18917D8
	public OnValidateInput get_onValidateInput() { }

	// RVA: 0x18917E0
	public void set_onValidateInput(OnValidateInput value) { }

	// RVA: 0x189183C
	public int get_characterLimit() { }

	// RVA: 0x1891844
	public void set_characterLimit(int value) { }

	// RVA: 0x1891910
	public ContentType get_contentType() { }

	// RVA: 0x1891918
	public void set_contentType(ContentType value) { }

	// RVA: 0x1891B30
	public LineType get_lineType() { }

	// RVA: 0x1891B38
	public void set_lineType(LineType value) { }

	// RVA: 0x1891D7C
	public InputType get_inputType() { }

	// RVA: 0x1891D84
	public void set_inputType(InputType value) { }

	// RVA: 0x1891F7C
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1891F84
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1891F8C
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1892030
	public CharacterValidation get_characterValidation() { }

	// RVA: 0x1892038
	public void set_characterValidation(CharacterValidation value) { }

	// RVA: 0x18920DC
	public bool get_readOnly() { }

	// RVA: 0x18920E4
	public void set_readOnly(bool value) { }

	// RVA: 0x18920EC
	public bool get_multiLine() { }

	// RVA: 0x1892100
	public Char get_asteriskChar() { }

	// RVA: 0x1892108
	public void set_asteriskChar(Char value) { }

	// RVA: 0x18921AC
	public bool get_wasCanceled() { }

	// RVA: 0x18921B4
	protected void ClampPos(int pos) { }

	// RVA: 0x18921F4
	protected int get_caretPositionInternal() { }

	// RVA: 0x1892224
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1892264
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1892294
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x18922D4
	private bool get_hasSelection() { }

	// RVA: 0x189232C
	public int get_caretPosition() { }

	// RVA: 0x189235C
	public void set_caretPosition(int value) { }

	// RVA: 0x18924F0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1892408
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1892520
	public int get_selectionFocusPosition() { }

	// RVA: 0x189247C
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1892550
	protected override void OnEnable() { }

	// RVA: 0x18927F8
	protected override void OnDisable() { }

	// RVA: 0x1892D68
	protected override void OnDestroy() { }

	// RVA: 0x1892DD8
	private IEnumerator CaretBlink() { }

	// RVA: 0x1892E7C
	private void SetCaretVisible() { }

	// RVA: 0x1890E90
	private void SetCaretActive() { }

	// RVA: 0x1892EC4
	private void UpdateCaretMaterial() { }

	// RVA: 0x1893020
	protected void OnFocus() { }

	// RVA: 0x1893064
	protected void SelectAll() { }

	// RVA: 0x18930A8
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1893140
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1893210
	private static string get_clipboard() { }

	// RVA: 0x1893280
	private static void set_clipboard(string value) { }

	// RVA: 0x1893308
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x18933EC
	private bool InPlaceEditing() { }

	// RVA: 0x1893430
	private bool InPlaceEditingChanged() { }

	// RVA: 0x18934DC
	private RangeInt GetInternalSelection() { }

	// RVA: 0x18935EC
	private void UpdateKeyboardCaret() { }

	// RVA: 0x18936DC
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x18937FC
	protected virtual void LateUpdate() { }

	// RVA: 0x18950F8
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x18954E4
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x1895704
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x1895B54
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1895C74
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1895CA0
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1895F64
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x189601C
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1896044
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1896258
	protected EditState KeyPressed(Event evt) { }

	// RVA: 0x1897508
	private bool IsValidChar(Char c) { }

	// RVA: 0x1897590
	public void ProcessEvent(Event e) { }

	// RVA: 0x1897594
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1896DAC
	private string GetSelectedString() { }

	// RVA: 0x18977B0
	private int FindtNextWordBegin() { }

	// RVA: 0x1897338
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1897898
	private int FindtPrevWordBegin() { }

	// RVA: 0x1897178
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1897968
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x1897A80
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1898008
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1897500
	private void MoveDown(bool shift) { }

	// RVA: 0x1898578
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x18974F8
	private void MoveUp(bool shift) { }

	// RVA: 0x1898744
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1896E88
	private void Delete() { }

	// RVA: 0x1896BAC
	private void ForwardSpace() { }

	// RVA: 0x1896924
	private void Backspace() { }

	// RVA: 0x18988D8
	private void Insert(Char c) { }

	// RVA: 0x1897120
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1895070
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1890804
	private void SendOnValueChanged() { }

	// RVA: 0x1898AE8
	protected void SendOnEndEdit() { }

	// RVA: 0x1894900
	protected void SendOnSubmit() { }

	// RVA: 0x1898B78
	protected virtual void Append(string input) { }

	// RVA: 0x1898C3C
	protected virtual void Append(Char input) { }

	// RVA: 0x1890894
	protected void UpdateLabel() { }

	// RVA: 0x189A008
	private bool IsSelectionVisible() { }

	// RVA: 0x189A0EC
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x18959CC
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x1898F08
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x189A248
	public void ForceLabelUpdate() { }

	// RVA: 0x1891050
	private void MarkGeometryAsDirty() { }

	// RVA: 0x189A24C
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x189A79C
	public virtual void LayoutComplete() { }

	// RVA: 0x189A7A0
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x189A25C
	private void UpdateGeometry() { }

	// RVA: 0x189436C
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x189A7A4
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x189AA14
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x189B93C
	private void CreateCursorVerts() { }

	// RVA: 0x189B17C
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1894990
	protected Char Validate(string text, int pos, Char ch) { }

	// RVA: 0x189BA88
	public void ActivateInputField() { }

	// RVA: 0x1893E6C
	private void ActivateInputFieldInternal() { }

	// RVA: 0x189BBFC
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x189BC48
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1892AB4
	public void DeactivateInputField() { }

	// RVA: 0x189BC70
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x189BCA0
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1891A60
	private void EnforceContentType() { }

	// RVA: 0x188FEE8
	private void EnforceTextHOverflow() { }

	// RVA: 0x1891BFC
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	// RVA: 0x1891E28
	private void SetToCustom() { }

	// RVA: 0x189BD00
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x189BD2C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x189BD30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x189BD34
	public virtual float get_minWidth() { }

	// RVA: 0x189BD3C
	public virtual float get_preferredWidth() { }

	// RVA: 0x189BEC0
	public virtual float get_flexibleWidth() { }

	// RVA: 0x189BEC8
	public virtual float get_minHeight() { }

	// RVA: 0x189BED0
	public virtual float get_preferredHeight() { }

	// RVA: 0x189C040
	public virtual float get_flexibleHeight() { }

	// RVA: 0x189C048
	public virtual int get_layoutPriority() { }

	// RVA: 0x189C050
	private static void .cctor() { }

	// RVA: 0x189C104
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

	// RVA: 0x189C710
	public AspectMode get_aspectMode() { }

	// RVA: 0x189C718
	public void set_aspectMode(AspectMode value) { }

	// RVA: 0x189C7C0
	public float get_aspectRatio() { }

	// RVA: 0x189C7C8
	public void set_aspectRatio(float value) { }

	// RVA: 0x189C878
	private RectTransform get_rectTransform() { }

	// RVA: 0x189C970
	protected void .ctor() { }

	// RVA: 0x189C980
	protected override void OnEnable() { }

	// RVA: 0x189CA1C
	protected override void Start() { }

	// RVA: 0x189CB9C
	protected override void OnDisable() { }

	// RVA: 0x189D158
	protected override void OnTransformParentChanged() { }

	// RVA: 0x189D1F4
	protected virtual void Update() { }

	// RVA: 0x189D208
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x189D20C
	private void UpdateRect() { }

	// RVA: 0x189D5DC
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x189D4C0
	private Vector2 GetParentSize() { }

	// RVA: 0x189D6D4
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x189D6D8
	public virtual void SetLayoutVertical() { }

	// RVA: 0x189C7BC
	protected void SetDirty() { }

	// RVA: 0x189CA7C
	public bool IsComponentValidOnObject() { }

	// RVA: 0x189CB74
	public bool IsAspectModeValid() { }

	// RVA: 0x189D6DC
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

	// RVA: 0x189D6E4
	public ScaleMode get_uiScaleMode() { }

	// RVA: 0x189D6EC
	public void set_uiScaleMode(ScaleMode value) { }

	// RVA: 0x189D6F4
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x189D6FC
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x189D704
	public float get_scaleFactor() { }

	// RVA: 0x189D70C
	public void set_scaleFactor(float value) { }

	// RVA: 0x189D728
	public Vector2 get_referenceResolution() { }

	// RVA: 0x189D730
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x189D7B8
	public ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x189D7C0
	public void set_screenMatchMode(ScreenMatchMode value) { }

	// RVA: 0x189D7C8
	public float get_matchWidthOrHeight() { }

	// RVA: 0x189D7D0
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x189D7D8
	public Unit get_physicalUnit() { }

	// RVA: 0x189D7E0
	public void set_physicalUnit(Unit value) { }

	// RVA: 0x189D7E8
	public float get_fallbackScreenDPI() { }

	// RVA: 0x189D7F0
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x189D7F8
	public float get_defaultSpriteDPI() { }

	// RVA: 0x189D800
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x189D814
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x189D81C
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x189D824
	protected void .ctor() { }

	// RVA: 0x189D86C
	protected override void OnEnable() { }

	// RVA: 0x189D958
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x189D968
	protected override void OnDisable() { }

	// RVA: 0x189DB30
	protected virtual void Handle() { }

	// RVA: 0x189DC6C
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x189DD04
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x189DD9C
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x189E090
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x189DA70
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x189DAD0
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

	// RVA: 0x189E154
	public FitMode get_horizontalFit() { }

	// RVA: 0x189E15C
	public void set_horizontalFit(FitMode value) { }

	// RVA: 0x189E2D4
	public FitMode get_verticalFit() { }

	// RVA: 0x189E2DC
	public void set_verticalFit(FitMode value) { }

	// RVA: 0x189E3AC
	private RectTransform get_rectTransform() { }

	// RVA: 0x189E4A4
	protected void .ctor() { }

	// RVA: 0x189E4AC
	protected override void OnEnable() { }

	// RVA: 0x189E55C
	protected override void OnDisable() { }

	// RVA: 0x189E5E0
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x189E688
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x189E784
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x189E7B4
	public virtual void SetLayoutVertical() { }

	// RVA: 0x189E22C
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

	// RVA: 0x189E7BC
	public Corner get_startCorner() { }

	// RVA: 0x189E7C4
	public void set_startCorner(Corner value) { }

	// RVA: 0x189E834
	public Axis get_startAxis() { }

	// RVA: 0x189E83C
	public void set_startAxis(Axis value) { }

	// RVA: 0x189E8AC
	public Vector2 get_cellSize() { }

	// RVA: 0x189E8B4
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x189E930
	public Vector2 get_spacing() { }

	// RVA: 0x189E938
	public void set_spacing(Vector2 value) { }

	// RVA: 0x189E9B4
	public Constraint get_constraint() { }

	// RVA: 0x189E9BC
	public void set_constraint(Constraint value) { }

	// RVA: 0x189EA2C
	public int get_constraintCount() { }

	// RVA: 0x189EA34
	public void set_constraintCount(int value) { }

	// RVA: 0x189EAAC
	protected void .ctor() { }

	// RVA: 0x189EC70
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x189F31C
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x189F67C
	public override void SetLayoutHorizontal() { }

	// RVA: 0x189FFC8
	public override void SetLayoutVertical() { }

	// RVA: 0x189F684
	private void SetCellsAlongAxis(int axis) { }

}

// Namespace: UnityEngine.UI
public class HorizontalLayoutGroup
{
	// Methods

	// RVA: 0x18A0224
	protected void .ctor() { }

	// RVA: 0x18A023C
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18A0744
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18A0750
	public override void SetLayoutHorizontal() { }

	// RVA: 0x18A0FE0
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

	// RVA: 0x18A0FEC
	public float get_spacing() { }

	// RVA: 0x18A0FF4
	public void set_spacing(float value) { }

	// RVA: 0x18A106C
	public bool get_childForceExpandWidth() { }

	// RVA: 0x18A1074
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x18A10E4
	public bool get_childForceExpandHeight() { }

	// RVA: 0x18A10EC
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x18A115C
	public bool get_childControlWidth() { }

	// RVA: 0x18A1164
	public void set_childControlWidth(bool value) { }

	// RVA: 0x18A11D4
	public bool get_childControlHeight() { }

	// RVA: 0x18A11DC
	public void set_childControlHeight(bool value) { }

	// RVA: 0x18A124C
	public bool get_childScaleWidth() { }

	// RVA: 0x18A1254
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x18A12C4
	public bool get_childScaleHeight() { }

	// RVA: 0x18A12CC
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x18A133C
	public bool get_reverseArrangement() { }

	// RVA: 0x18A1344
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x18A0268
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x18A075C
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x18A13B4
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, float min, float preferred, float flexible) { }

	// RVA: 0x18A0230
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

	// RVA: 0x18A1B6C
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x18A1B74
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x18A1D4C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18A1D50
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18A1D54
	public virtual float get_minWidth() { }

	// RVA: 0x18A1D5C
	public virtual void set_minWidth(float value) { }

	// RVA: 0x18A1E68
	public virtual float get_minHeight() { }

	// RVA: 0x18A1E70
	public virtual void set_minHeight(float value) { }

	// RVA: 0x18A1F7C
	public virtual float get_preferredWidth() { }

	// RVA: 0x18A1F84
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x18A2090
	public virtual float get_preferredHeight() { }

	// RVA: 0x18A2098
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x18A21A4
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18A21AC
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x18A22B8
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18A22C0
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x18A23CC
	public virtual int get_layoutPriority() { }

	// RVA: 0x18A23D4
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x18A24D8
	protected void .ctor() { }

	// RVA: 0x18A24F8
	protected override void OnEnable() { }

	// RVA: 0x18A25D4
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18A26A8
	protected override void OnDisable() { }

	// RVA: 0x18A2794
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18A2868
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x18A1C78
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

	// RVA: 0x18A2F34
	public void .ctor(int <>1__state) { }

	// RVA: 0x18A2F60
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18A2F64
	private bool MoveNext() { }

	// RVA: 0x18A3018
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18A3020
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18A3060
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

	// RVA: 0x18A293C
	public RectOffset get_padding() { }

	// RVA: 0x18A2944
	public void set_padding(RectOffset value) { }

	// RVA: 0x18A29A4
	public TextAnchor get_childAlignment() { }

	// RVA: 0x18A29AC
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x189F584
	protected RectTransform get_rectTransform() { }

	// RVA: 0x18A2A1C
	protected System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }

	// RVA: 0x189EE70
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: 0x18A2A24
	public virtual float get_minWidth() { }

	// RVA: 0x18A2A2C
	public virtual float get_preferredWidth() { }

	// RVA: 0x18A2A34
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18A2A3C
	public virtual float get_minHeight() { }

	// RVA: 0x18A2A44
	public virtual float get_preferredHeight() { }

	// RVA: 0x18A2A4C
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18A2A54
	public virtual int get_layoutPriority() { }

	// RVA: -1
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1
	public abstract void SetLayoutVertical() { }

	// RVA: 0x189EB18
	protected void .ctor() { }

	// RVA: 0x18A2A5C
	protected override void OnEnable() { }

	// RVA: 0x18A2BC8
	protected override void OnDisable() { }

	// RVA: 0x18A2C4C
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18A1AD8
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x18A19C8
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x18A1A50
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x189FFD0
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x18A14CC
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x189F284
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x18A2C50
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x18A1778
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x18A0144
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x18A150C
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x18A2D28
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x18A2E78
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18A2EB8
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x316B894
	protected void SetProperty(T currentValue, T newValue) { }

	// RVA: 0x18A2A84
	protected void SetDirty() { }

	// RVA: 0x18A2EBC
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

	// RVA: 0x18A464C
	private static void .cctor() { }

	// RVA: 0x18A46B8
	public void .ctor() { }

	// RVA: 0x18A46C0
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x18A4718
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x18A4750
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x18A47E4
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x18A48C0
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x18A499C
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x18A4A7C
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

	// RVA: 0x18A3068
	private void Initialize(RectTransform controller) { }

	// RVA: 0x18A30AC
	private void Clear() { }

	// RVA: 0x18A30DC
	private static void .cctor() { }

	// RVA: 0x18A32CC
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x18A334C
	public Transform get_transform() { }

	// RVA: 0x18A3354
	public bool IsDestroyed() { }

	// RVA: 0x18A33C0
	private static void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }

	// RVA: 0x18A34E0
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x18A35EC
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18A3C30
	private void PerformLayoutControl(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x18A3908
	private void PerformLayoutCalculation(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x189CC20
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x18A40A8
	private static bool ValidController(RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }

	// RVA: 0x18A4310
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x18A44B4
	public void LayoutComplete() { }

	// RVA: 0x18A4558
	public void GraphicUpdateComplete() { }

	// RVA: 0x18A455C
	public override int GetHashCode() { }

	// RVA: 0x18A4564
	public override bool Equals(object obj) { }

	// RVA: 0x18A45B8
	public override string ToString() { }

	// RVA: 0x18A4644
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

	// RVA: 0x18A5708
	private static void .cctor() { }

	// RVA: 0x18A5774
	public void .ctor() { }

	// RVA: 0x18A577C
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x18A5830
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x18A58E4
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x18A5998
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x18A5A4C
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x18A5B00
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x18A5BB4
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x18A5C68
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

// Namespace: UnityEngine.UI
public static class LayoutUtility
{
	// Methods

	// RVA: 0x189E76C
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x189E778
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x18A1B60
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x18A4C74
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x18A4F64
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x18A5254
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x18A4B5C
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x18A4D8C
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x18A513C
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x18A536C
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue) { }

	// RVA: 0x18A5390
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue, ILayoutElement source) { }

}

// Namespace: UnityEngine.UI
public class VerticalLayoutGroup
{
	// Methods

	// RVA: 0x18A5D1C
	protected void .ctor() { }

	// RVA: 0x18A5D28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18A5D54
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18A5D60
	public override void SetLayoutHorizontal() { }

	// RVA: 0x18A5D6C
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

	// RVA: 0x18A5D78
	public RectTransform get_rectTransform() { }

	// RVA: 0x18A5E24
	public bool get_showMaskGraphic() { }

	// RVA: 0x18A5E2C
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x18A5FC4
	public Graphic get_graphic() { }

	// RVA: 0x18A6070
	protected void .ctor() { }

	// RVA: 0x18A6080
	public virtual bool MaskEnabled() { }

	// RVA: 0x18A61AC
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x18A61B0
	protected override void OnEnable() { }

	// RVA: 0x18A67D8
	protected override void OnDisable() { }

	// RVA: 0x18A6BE8
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18A6D24
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: 
[Serializable]
public class CullStateChangedEvent
{
	// Methods

	// RVA: 0x18A87B8
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

	// RVA: 0x18A7764
	public CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x18A776C
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	// RVA: 0x18A7774
	public bool get_maskable() { }

	// RVA: 0x18A777C
	public void set_maskable(bool value) { }

	// RVA: 0x18A77A8
	public bool get_isMaskingGraphic() { }

	// RVA: 0x18A64EC
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x18A77B0
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x18A78E0
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18A7C30
	private void UpdateCull(bool cull) { }

	// RVA: 0x18A7D18
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x18A7D98
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x18A7DD4
	protected override void OnEnable() { }

	// RVA: 0x18A7FF8
	protected override void OnDisable() { }

	// RVA: 0x18A80C4
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18A8124
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x18A8128
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18A79C4
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18A7E34
	private void UpdateClipParent() { }

	// RVA: 0x18A8608
	public virtual void RecalculateClipping() { }

	// RVA: 0x18A860C
	public virtual void RecalculateMasking() { }

	// RVA: 0x18A86A4
	protected void .ctor() { }

	// RVA: 0x18A880C
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

// Namespace: UnityEngine.UI
public class MaskUtilities
{
	// Methods

	// RVA: 0x18A8814
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x18A6500
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x18A71A8
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x18A739C
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x18A8AF0
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x18A8188
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x18A8CC4
	public static void GetRectMasksForClip(RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }

	// RVA: 0x18A90A0
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

	// RVA: 0x18A90A8
	public static void Destroy(object obj) { }

	// RVA: 0x18A923C
	public static void DestroyImmediate(object obj) { }

}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities
{
	// Methods

	// RVA: 0x18A9390
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, Vector2 position) { }

	// RVA: 0x18A98A0
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x18A9408
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

	// RVA: 0x18A997C
	public Mode get_mode() { }

	// RVA: 0x18A9984
	public void set_mode(Mode value) { }

	// RVA: 0x18A998C
	public bool get_wrapAround() { }

	// RVA: 0x18A9994
	public void set_wrapAround(bool value) { }

	// RVA: 0x18A999C
	public Selectable get_selectOnUp() { }

	// RVA: 0x18A99A4
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x18A99AC
	public Selectable get_selectOnDown() { }

	// RVA: 0x18A99B4
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x18A99BC
	public Selectable get_selectOnLeft() { }

	// RVA: 0x18A99C4
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x18A99CC
	public Selectable get_selectOnRight() { }

	// RVA: 0x18A99D4
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x18A99DC
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x18A99FC
	public bool Equals(Navigation other) { }

}

// Namespace: UnityEngine.UI
public class RawImage
{
	// Fields
	private Texture m_Texture; // 0xD8
	private Rect m_UVRect; // 0xE0

	// Methods

	// RVA: 0x18A9B68
	protected void .ctor() { }

	// RVA: 0x18A9B9C
	public override Texture get_mainTexture() { }

	// RVA: 0x18A9D70
	public Texture get_texture() { }

	// RVA: 0x18A9D78
	public void set_texture(Texture value) { }

	// RVA: 0x18A9E6C
	public Rect get_uvRect() { }

	// RVA: 0x18A9E78
	public void set_uvRect(Rect value) { }

	// RVA: 0x18A9EB0
	public override void SetNativeSize() { }

	// RVA: 0x18AA1D4
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x18AAAB0
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

	// RVA: 0x18AAAF8
	public Vector4 get_padding() { }

	// RVA: 0x18AAB04
	public void set_padding(Vector4 value) { }

	// RVA: 0x18AAB14
	public Vector2Int get_softness() { }

	// RVA: 0x18AAB1C
	public void set_softness(Vector2Int value) { }

	// RVA: 0x18AAB38
	internal Canvas get_Canvas() { }

	// RVA: 0x18AAD18
	public Rect get_canvasRect() { }

	// RVA: 0x18AADDC
	public RectTransform get_rectTransform() { }

	// RVA: 0x18AAE88
	protected void .ctor() { }

	// RVA: 0x18AB02C
	protected override void OnEnable() { }

	// RVA: 0x18AB06C
	protected override void OnDisable() { }

	// RVA: 0x18AB170
	protected override void OnDestroy() { }

	// RVA: 0x18AB19C
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18AB308
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18AB52C
	public virtual void PerformClipping() { }

	// RVA: 0x18ABFE0
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x18AC3EC
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x18AC530
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x18AC6F8
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18AC734
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

	// RVA: 0x18ACDAC
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

	// RVA: 0x18AE3C0
	public void .ctor(int <>1__state) { }

	// RVA: 0x18AF034
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18AF038
	private bool MoveNext() { }

	// RVA: 0x18AF484
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18AF48C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18AF4CC
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

	// RVA: 0x18AC770
	public RectTransform get_handleRect() { }

	// RVA: 0x18AC778
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18ACBE4
	public Direction get_direction() { }

	// RVA: 0x18ACBEC
	public void set_direction(Direction value) { }

	// RVA: 0x18ACC90
	protected void .ctor() { }

	// RVA: 0x18ACF40
	public float get_value() { }

	// RVA: 0x18ACFFC
	public void set_value(float value) { }

	// RVA: 0x18AD23C
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18AD244
	public float get_size() { }

	// RVA: 0x18AD24C
	public void set_size(float value) { }

	// RVA: 0x18AD2E4
	public int get_numberOfSteps() { }

	// RVA: 0x18AD2EC
	public void set_numberOfSteps(int value) { }

	// RVA: 0x18AD3A0
	public ScrollEvent get_onValueChanged() { }

	// RVA: 0x18AD3A8
	public void set_onValueChanged(ScrollEvent value) { }

	// RVA: 0x18AD3B8
	private float get_stepSize() { }

	// RVA: 0x18AD3E8
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18AD3EC
	public virtual void LayoutComplete() { }

	// RVA: 0x18AD3F0
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18AD3F4
	protected override void OnEnable() { }

	// RVA: 0x18AD724
	protected override void OnDisable() { }

	// RVA: 0x18AD894
	protected virtual void Update() { }

	// RVA: 0x18AC7F8
	private void UpdateCachedReferences() { }

	// RVA: 0x18AD004
	private void Set(float input, bool sendCallback) { }

	// RVA: 0x18AD8A8
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18AD8F0
	private Axis get_axis() { }

	// RVA: 0x18AD900
	private bool get_reverseValue() { }

	// RVA: 0x18AC948
	private void UpdateVisuals() { }

	// RVA: 0x18AD914
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x18ADBD8
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x18ADC44
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18ADCA0
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18ADE9C
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18ADF7C
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18AE310
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x18AE270
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x18AE3EC
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18AE574
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18AE9DC
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18AEAEC
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18AEBFC
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18AED0C
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18AEE1C
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18AEE38
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18AF02C
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

	// RVA: 0x18B00A4
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

	// RVA: 0x18AF4D4
	public RectTransform get_content() { }

	// RVA: 0x18AF4DC
	public void set_content(RectTransform value) { }

	// RVA: 0x18AF4E4
	public bool get_horizontal() { }

	// RVA: 0x18AF4EC
	public void set_horizontal(bool value) { }

	// RVA: 0x18AF4F4
	public bool get_vertical() { }

	// RVA: 0x18AF4FC
	public void set_vertical(bool value) { }

	// RVA: 0x18AF504
	public MovementType get_movementType() { }

	// RVA: 0x18AF50C
	public void set_movementType(MovementType value) { }

	// RVA: 0x18AF514
	public float get_elasticity() { }

	// RVA: 0x18AF51C
	public void set_elasticity(float value) { }

	// RVA: 0x18AF524
	public bool get_inertia() { }

	// RVA: 0x18AF52C
	public void set_inertia(bool value) { }

	// RVA: 0x18AF534
	public float get_decelerationRate() { }

	// RVA: 0x18AF53C
	public void set_decelerationRate(float value) { }

	// RVA: 0x18AF544
	public float get_scrollSensitivity() { }

	// RVA: 0x18AF54C
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x18AF554
	public RectTransform get_viewport() { }

	// RVA: 0x18AF55C
	public void set_viewport(RectTransform value) { }

	// RVA: 0x18AF66C
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x18AF674
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x18AF878
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x18AF880
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x18AFA84
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x18AFA8C
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18AFA94
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x18AFA9C
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18AFAA4
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x18AFAAC
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x18AFC10
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x18AFC18
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x18AFCCC
	public ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x18AFCD4
	public void set_onValueChanged(ScrollRectEvent value) { }

	// RVA: 0x18AFCDC
	protected RectTransform get_viewRect() { }

	// RVA: 0x18AFE50
	public Vector2 get_velocity() { }

	// RVA: 0x18AFE58
	public void set_velocity(Vector2 value) { }

	// RVA: 0x18AFE60
	private RectTransform get_rectTransform() { }

	// RVA: 0x18AFF58
	protected void .ctor() { }

	// RVA: 0x18B00F8
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18B0F24
	public virtual void LayoutComplete() { }

	// RVA: 0x18B0F28
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18B0184
	private void UpdateCachedData() { }

	// RVA: 0x18B0F2C
	protected override void OnEnable() { }

	// RVA: 0x18B11DC
	protected override void OnDisable() { }

	// RVA: 0x18B1440
	public override bool IsActive() { }

	// RVA: 0x18B14E8
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x18B156C
	public virtual void StopMovement() { }

	// RVA: 0x18B15C0
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x18B1A74
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18B1AE4
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18B1C24
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18B1C50
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18B1FA8
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x18B2088
	protected virtual void LateUpdate() { }

	// RVA: 0x18B0E1C
	protected void UpdatePrevData() { }

	// RVA: 0x18B096C
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x18B28AC
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x18B2DFC
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x18B2BE4
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x18B2E50
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x18B2CF0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x18B2E64
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x18B2E78
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x18B2E8C
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x18B2EA0
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x18B1F6C
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x18B31F4
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18B32A4
	private bool get_hScrollingNeeded() { }

	// RVA: 0x18B3360
	private bool get_vScrollingNeeded() { }

	// RVA: 0x18B341C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18B3420
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18B3424
	public virtual float get_minWidth() { }

	// RVA: 0x18B342C
	public virtual float get_preferredWidth() { }

	// RVA: 0x18B3434
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18B343C
	public virtual float get_minHeight() { }

	// RVA: 0x18B3444
	public virtual float get_preferredHeight() { }

	// RVA: 0x18B344C
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18B3454
	public virtual int get_layoutPriority() { }

	// RVA: 0x18B345C
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18B3BDC
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18B2A94
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x18B4058
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x18B3CA0
	private void UpdateScrollbarLayout() { }

	// RVA: 0x18B05E8
	protected void UpdateBounds() { }

	// RVA: 0x18B41A0
	internal static void AdjustBounds(Bounds viewBounds, Vector2 contentPivot, Vector3 contentSize, Vector3 contentPos) { }

	// RVA: 0x18B3ABC
	private Bounds GetBounds() { }

	// RVA: 0x18B4228
	internal static Bounds InternalGetBounds(Vector3[] corners, Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x18B190C
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x18B446C
	internal static Vector2 InternalCalculateOffset(Bounds viewBounds, Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, Vector2 delta) { }

	// RVA: 0x18AFB60
	protected void SetDirty() { }

	// RVA: 0x18AF584
	protected void SetDirtyCaching() { }

	// RVA: 0x18B45AC
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

	// RVA: 0x18B45B4
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x18B4650
	public static int get_allSelectableCount() { }

	// RVA: 0x18B46CC
	public static System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }

	// RVA: 0x18B47FC
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x18B48EC
	public Navigation get_navigation() { }

	// RVA: 0x18B4904
	public void set_navigation(Navigation value) { }

	// RVA: 0x18B4A4C
	public Transition get_transition() { }

	// RVA: 0x18B4A54
	public void set_transition(Transition value) { }

	// RVA: 0x18B4B4C
	public ColorBlock get_colors() { }

	// RVA: 0x18B4B78
	public void set_colors(ColorBlock value) { }

	// RVA: 0x18B4C60
	public SpriteState get_spriteState() { }

	// RVA: 0x18B4C6C
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x18B4D3C
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x18B4D44
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x18B4E10
	public Graphic get_targetGraphic() { }

	// RVA: 0x18B4E18
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x18B4EE4
	public bool get_interactable() { }

	// RVA: 0x18B4EEC
	public void set_interactable(bool value) { }

	// RVA: 0x18B50F8
	private bool get_isPointerInside() { }

	// RVA: 0x18B5100
	private void set_isPointerInside(bool value) { }

	// RVA: 0x18B5108
	private bool get_isPointerDown() { }

	// RVA: 0x18B5110
	private void set_isPointerDown(bool value) { }

	// RVA: 0x18B5118
	private bool get_hasSelection() { }

	// RVA: 0x18B5120
	private void set_hasSelection(bool value) { }

	// RVA: 0x18ACE00
	protected void .ctor() { }

	// RVA: 0x18B5128
	public Image get_image() { }

	// RVA: 0x18B51B0
	public void set_image(Image value) { }

	// RVA: 0x18B51B8
	public Animator get_animator() { }

	// RVA: 0x18B5220
	protected override void Awake() { }

	// RVA: 0x18B5310
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x18B53A4
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x18B5548
	public virtual bool IsInteractable() { }

	// RVA: 0x18B5568
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18AD430
	protected override void OnEnable() { }

	// RVA: 0x18B564C
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18B49DC
	private void OnSetProperty() { }

	// RVA: 0x18AD750
	protected override void OnDisable() { }

	// RVA: 0x18B5680
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18B55D8
	protected SelectionState get_currentSelectionState() { }

	// RVA: 0x18B573C
	protected virtual void InstantClearState() { }

	// RVA: 0x18B5E80
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x18B6130
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x18B666C
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x18B681C
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x18AEA00
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x18AEB10
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x18AEC20
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x18AED30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x18AE938
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18B5880
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x18B59B8
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x18B5B4C
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x18B68FC
	protected bool IsHighlighted() { }

	// RVA: 0x18B56EC
	protected bool IsPressed() { }

	// RVA: 0x18B697C
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x18AE0A8
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18AE4B8
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18B6A24
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18B6AD4
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18B6B80
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18B6C30
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18B6CDC
	public virtual void Select() { }

	// RVA: 0x18B6E30
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility
{
	// Methods

	// RVA: 0x18B6EC0
	public static bool SetColor(Color currentValue, Color newValue) { }

	// RVA: 0x316B894
	public static bool SetStruct(T currentValue, T newValue) { }

	// RVA: 0x316B894
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

	// RVA: 0x18B816C
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

	// RVA: 0x18B6F0C
	public RectTransform get_fillRect() { }

	// RVA: 0x18B6F14
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x18B7A44
	public RectTransform get_handleRect() { }

	// RVA: 0x18B7A4C
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18B7ACC
	public Direction get_direction() { }

	// RVA: 0x18B7AD4
	public void set_direction(Direction value) { }

	// RVA: 0x18B7B78
	public float get_minValue() { }

	// RVA: 0x18B7B80
	public void set_minValue(float value) { }

	// RVA: 0x18B7C4C
	public float get_maxValue() { }

	// RVA: 0x18B7C54
	public void set_maxValue(float value) { }

	// RVA: 0x18B7D20
	public bool get_wholeNumbers() { }

	// RVA: 0x18B7D28
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x18B7DE8
	public virtual float get_value() { }

	// RVA: 0x18B7EB4
	public virtual void set_value(float value) { }

	// RVA: 0x18B7EC8
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18B7EDC
	public float get_normalizedValue() { }

	// RVA: 0x18B7FD0
	public void set_normalizedValue(float value) { }

	// RVA: 0x18B800C
	public SliderEvent get_onValueChanged() { }

	// RVA: 0x18B8014
	public void set_onValueChanged(SliderEvent value) { }

	// RVA: 0x18B8024
	private float get_stepSize() { }

	// RVA: 0x18B8054
	protected void .ctor() { }

	// RVA: 0x18B81C0
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18B81C4
	public virtual void LayoutComplete() { }

	// RVA: 0x18B81C8
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18B81CC
	protected override void OnEnable() { }

	// RVA: 0x18B8214
	protected override void OnDisable() { }

	// RVA: 0x18B8240
	protected virtual void Update() { }

	// RVA: 0x18B8290
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18B6F94
	private void UpdateCachedReferences() { }

	// RVA: 0x18B878C
	private float ClampValue(float input) { }

	// RVA: 0x18B8890
	protected virtual void Set(float input, bool sendCallback) { }

	// RVA: 0x18B8A18
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18B8880
	private Axis get_axis() { }

	// RVA: 0x18B886C
	private bool get_reverseValue() { }

	// RVA: 0x18B7340
	private void UpdateVisuals() { }

	// RVA: 0x18B8A60
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x18B8CD8
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18B8D34
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18B8F40
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18B8FBC
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18B9380
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18B93A4
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18B93C8
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18B93EC
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18B9410
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18B942C
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18B9620
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

	// RVA: 0x18B9628
	public Sprite get_highlightedSprite() { }

	// RVA: 0x18B9630
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x18B9638
	public Sprite get_pressedSprite() { }

	// RVA: 0x18B9640
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x18B9648
	public Sprite get_selectedSprite() { }

	// RVA: 0x18B9650
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x18B9658
	public Sprite get_disabledSprite() { }

	// RVA: 0x18B9660
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x18B9668
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

	// RVA: 0x18BA38C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class StencilMaterial
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	// RVA: 0x18B97D8
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x18B97E0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x18BA2C8
	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	// RVA: 0x18B9878
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x18BA39C
	public static void Remove(Material customMat) { }

	// RVA: 0x18BA588
	public static void ClearAll() { }

	// RVA: 0x18BA740
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

	// RVA: 0x18BA7DC
	protected void .ctor() { }

	// RVA: 0x18BA898
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x18BA950
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x18BA9DC
	public override Texture get_mainTexture() { }

	// RVA: 0x18BAC30
	public void FontTextureChanged() { }

	// RVA: 0x18BAC10
	public Font get_font() { }

	// RVA: 0x18BAD84
	public void set_font(Font value) { }

	// RVA: 0x18BAEC4
	public virtual string get_text() { }

	// RVA: 0x18BAECC
	public virtual void set_text(string value) { }

	// RVA: 0x18BAFC0
	public bool get_supportRichText() { }

	// RVA: 0x18BAFE0
	public void set_supportRichText(bool value) { }

	// RVA: 0x18BB04C
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x18BB06C
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x18BB0D8
	public int get_resizeTextMinSize() { }

	// RVA: 0x18BB0F8
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x18BB15C
	public int get_resizeTextMaxSize() { }

	// RVA: 0x18BB17C
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x18BB1E0
	public TextAnchor get_alignment() { }

	// RVA: 0x18BB200
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x18BB264
	public bool get_alignByGeometry() { }

	// RVA: 0x18BB284
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x18BB2CC
	public int get_fontSize() { }

	// RVA: 0x18BB2EC
	public void set_fontSize(int value) { }

	// RVA: 0x18BB350
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x18BB370
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x18BB3D4
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x18BB3F4
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x18BB458
	public float get_lineSpacing() { }

	// RVA: 0x18BB478
	public void set_lineSpacing(float value) { }

	// RVA: 0x18BB4DC
	public FontStyle get_fontStyle() { }

	// RVA: 0x18BB4FC
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x18BB560
	public float get_pixelsPerUnit() { }

	// RVA: 0x18BB6F4
	protected override void OnEnable() { }

	// RVA: 0x18BB788
	protected override void OnDisable() { }

	// RVA: 0x18BB7F8
	protected override void UpdateGeometry() { }

	// RVA: 0x18BB898
	internal void AssignDefaultFont() { }

	// RVA: 0x18BB90C
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x18BB9E0
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x18BBBA4
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x18BBC30
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x18BC39C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18BC3A0
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18BC3A4
	public virtual float get_minWidth() { }

	// RVA: 0x18BC3AC
	public virtual float get_preferredWidth() { }

	// RVA: 0x18BC504
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18BC50C
	public virtual float get_minHeight() { }

	// RVA: 0x18BC514
	public virtual float get_preferredHeight() { }

	// RVA: 0x18BC638
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18BC640
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

	// RVA: 0x18BCB94
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

	// RVA: 0x18BC648
	public ToggleGroup get_group() { }

	// RVA: 0x18BC650
	public void set_group(ToggleGroup value) { }

	// RVA: 0x18BCAAC
	protected void .ctor() { }

	// RVA: 0x18BCBE8
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18BCBEC
	public virtual void LayoutComplete() { }

	// RVA: 0x18BCBF0
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18BCBF4
	protected override void OnDestroy() { }

	// RVA: 0x18BD104
	protected override void OnEnable() { }

	// RVA: 0x18BD1F0
	protected override void OnDisable() { }

	// RVA: 0x18BD21C
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18BC730
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x18BD95C
	public bool get_isOn() { }

	// RVA: 0x18BD964
	public void set_isOn(bool value) { }

	// RVA: 0x18BD96C
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x18BD3D4
	private void Set(bool value, bool sendCallback) { }

	// RVA: 0x18BC9BC
	private void PlayEffect(bool instant) { }

	// RVA: 0x18BDAE4
	protected override void Start() { }

	// RVA: 0x18BDBBC
	private void InternalToggle() { }

	// RVA: 0x18BDC20
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18BDC94
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18BDCF8
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

	// RVA: 0x18BE258
	private static void .cctor() { }

	// RVA: 0x18BE2C4
	public void .ctor() { }

	// RVA: 0x18BE2CC
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x18BE2E8
	internal bool <ActiveToggles>b__14_0(Toggle x) { }

}

// Namespace: UnityEngine.UI
public class ToggleGroup
{
	// Fields
	private bool m_AllowSwitchOff; // 0x20
	protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles; // 0x28

	// Methods

	// RVA: 0x18BDD00
	public bool get_allowSwitchOff() { }

	// RVA: 0x18BDD08
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x18BDD10
	protected void .ctor() { }

	// RVA: 0x18BDD9C
	protected override void Start() { }

	// RVA: 0x18BDDC4
	protected override void OnEnable() { }

	// RVA: 0x18BDDEC
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x18BD76C
	public void NotifyToggleOn(Toggle toggle, bool sendCallback) { }

	// RVA: 0x18BD62C
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x18BD6CC
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x18BCCBC
	public void EnsureValidState() { }

	// RVA: 0x18BD974
	public bool AnyTogglesOn() { }

	// RVA: 0x18BDF64
	public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }

	// RVA: 0x18BE094
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x18BE144
	public void SetAllTogglesOff(bool sendCallback) { }

}

// Namespace: 
public sealed class Raycast3DCallback
{
	// Methods

	// RVA: 0x18BEAEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18BEB90
	public virtual bool Invoke(Ray r, RaycastHit hit, float f, int i) { }

	// RVA: 0x18BEBD0
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18BED14
	public virtual bool EndInvoke(RaycastHit hit, IAsyncResult result) { }

}

// Namespace: 
public sealed class RaycastAllCallback
{
	// Methods

	// RVA: 0x18BED78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18BEE1C
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x18BEE5C
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18BEF70
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GetRaycastNonAllocCallback
{
	// Methods

	// RVA: 0x18BEF7C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18BF020
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x18BF060
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18BF180
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

	// RVA: 0x18BE304
	public void .ctor() { }

	// RVA: 0x18BEA44
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

	// RVA: 0x18BF1AC
	public void .ctor() { }

	// RVA: 0x18BF1B4
	public void .ctor(Mesh m) { }

	// RVA: 0x18BF3F4
	private void InitializeListIfRequired() { }

	// RVA: 0x18BF60C
	public void Dispose() { }

	// RVA: 0x18AA4B4
	public void Clear() { }

	// RVA: 0x18BF884
	public int get_currentVertCount() { }

	// RVA: 0x18BF8DC
	public int get_currentIndexCount() { }

	// RVA: 0x18BF934
	public void PopulateUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18BFADC
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18BFC84
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x18BFDF0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x18BFFBC
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x18AA844
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x18C00C8
	public void AddVert(UIVertex v) { }

	// RVA: 0x18AA9F4
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x18BC1E8
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x18C0160
	public void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x18C0210
	public void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

	// RVA: 0x18C0264
	public void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }

	// RVA: 0x18C02B8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseVertexEffect
{
	// Methods

	// RVA: -1
	public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x18C0354
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseMeshEffect
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Methods

	// RVA: 0x18C035C
	protected Graphic get_graphic() { }

	// RVA: 0x18C0454
	protected override void OnEnable() { }

	// RVA: 0x18C051C
	protected override void OnDisable() { }

	// RVA: 0x18C0604
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18C06EC
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1
	public abstract void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x18C0868
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

	// RVA: 0x18C0870
	protected void .ctor() { }

	// RVA: 0x18C08C0
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class PositionAsUV1
{
	// Methods

	// RVA: 0x18C0DE4
	protected void .ctor() { }

	// RVA: 0x18C0DEC
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

	// RVA: 0x18C0898
	protected void .ctor() { }

	// RVA: 0x18C0EE0
	public Color get_effectColor() { }

	// RVA: 0x18C0EEC
	public void set_effectColor(Color value) { }

	// RVA: 0x18C0FD8
	public Vector2 get_effectDistance() { }

	// RVA: 0x18C0FE0
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x18C1104
	public bool get_useGraphicAlpha() { }

	// RVA: 0x18C110C
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x18C0B40
	protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18C11D0
	protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18C11D8
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

	// RVA: 0x316B894
	public void Add(T item) { }

	// RVA: 0x316B894
	public void Add(T item, bool isActive) { }

	// RVA: 0x316B894
	public bool AddUnique(T item, bool isActive) { }

	// RVA: 0x316B894
	public bool EnableItem(T item) { }

	// RVA: 0x316B894
	public bool DisableItem(T item) { }

	// RVA: 0x316B894
	public bool Remove(T item) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(T item) { }

	// RVA: 0x30B2D20
	public void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B199C
	public int get_Capacity() { }

	// RVA: 0x30B171C
	public bool get_IsReadOnly() { }

	// RVA: 0x316B894
	public int IndexOf(T item) { }

	// RVA: 0x316B894
	public void Insert(int index, T item) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

	// RVA: 0x30B2A58
	private void Swap(int index1, int index2) { }

	// RVA: 0x316B894
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, T value) { }

	// RVA: 0x30B2CB8
	public void RemoveAll(System.Predicate<T> match) { }

	// RVA: 0x30B2CB8
	public void Sort(System.Comparison<T> sortLayoutFunction) { }

	// RVA: 0x30B2870
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

	// RVA: 0x18C1554
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

	// RVA: 0x18C134C
	public Color get_startColor() { }

	// RVA: 0x18C1358
	public void set_startColor(Color value) { }

	// RVA: 0x18C1364
	public Color get_targetColor() { }

	// RVA: 0x18C1370
	public void set_targetColor(Color value) { }

	// RVA: 0x18C137C
	public ColorTweenMode get_tweenMode() { }

	// RVA: 0x18C1384
	public void set_tweenMode(ColorTweenMode value) { }

	// RVA: 0x18C138C
	public float get_duration() { }

	// RVA: 0x18C1394
	public void set_duration(float value) { }

	// RVA: 0x18C139C
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18C13A4
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18C13AC
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18C147C
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }

	// RVA: 0x18C15A8
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18C15B0
	public float GetDuration() { }

	// RVA: 0x18C146C
	public bool ValidTarget() { }

}

// Namespace: 
public class FloatTweenCallback
{
	// Methods

	// RVA: 0x18C1778
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

	// RVA: 0x18C15B8
	public float get_startValue() { }

	// RVA: 0x18C15C0
	public void set_startValue(float value) { }

	// RVA: 0x18C15C8
	public float get_targetValue() { }

	// RVA: 0x18C15D0
	public void set_targetValue(float value) { }

	// RVA: 0x18C15D8
	public float get_duration() { }

	// RVA: 0x18C15E0
	public void set_duration(float value) { }

	// RVA: 0x18C15E8
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18C15F0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18C15F8
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18C16A0
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }

	// RVA: 0x18C17CC
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18C17D4
	public float GetDuration() { }

	// RVA: 0x18C1690
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

	// RVA: 0x30B29E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30B171C
	private bool MoveNext() { }

	// RVA: 0x30B1CD4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T0>
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	// RVA: 0x316B894
	private static IEnumerator Start(T tweenInfo) { }

	// RVA: 0x30B2CB8
	public void Init(MonoBehaviour coroutineContainer) { }

	// RVA: 0x316B894
	public void StartTween(T info) { }

	// RVA: 0x30B2870
	public void StopTween() { }

	// RVA: 0x30B2870
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

	// RVA: 0x18C4650
	public int get_pointerId() { }

	// RVA: 0x18C4658
	private void set_pointerId(int value) { }

	// RVA: 0x18C4660
	public string get_pointerType() { }

	// RVA: 0x18C4668
	private void set_pointerType(string value) { }

	// RVA: 0x18C4670
	public bool get_isPrimary() { }

	// RVA: 0x18C4678
	private void set_isPrimary(bool value) { }

	// RVA: 0x18C4680
	public int get_button() { }

	// RVA: 0x18C4688
	private void set_button(int value) { }

	// RVA: 0x18C4690
	public int get_pressedButtons() { }

	// RVA: 0x18C4698
	private void set_pressedButtons(int value) { }

	// RVA: 0x18C46A0
	public Vector3 get_position() { }

	// RVA: 0x18C46AC
	private void set_position(Vector3 value) { }

	// RVA: 0x18C46B8
	public Vector3 get_localPosition() { }

	// RVA: 0x18C46C4
	private void set_localPosition(Vector3 value) { }

	// RVA: 0x18C46D0
	public Vector3 get_deltaPosition() { }

	// RVA: 0x18C46DC
	private void set_deltaPosition(Vector3 value) { }

	// RVA: 0x18C46E8
	public float get_deltaTime() { }

	// RVA: 0x18C46F0
	private void set_deltaTime(float value) { }

	// RVA: 0x18C46F8
	public int get_clickCount() { }

	// RVA: 0x18C4700
	private void set_clickCount(int value) { }

	// RVA: 0x18C4708
	public float get_pressure() { }

	// RVA: 0x18C4710
	private void set_pressure(float value) { }

	// RVA: 0x18C4718
	public float get_tangentialPressure() { }

	// RVA: 0x18C4720
	private void set_tangentialPressure(float value) { }

	// RVA: 0x18C4728
	public float get_altitudeAngle() { }

	// RVA: 0x18C4730
	private void set_altitudeAngle(float value) { }

	// RVA: 0x18C4738
	public float get_azimuthAngle() { }

	// RVA: 0x18C4740
	private void set_azimuthAngle(float value) { }

	// RVA: 0x18C4748
	public float get_twist() { }

	// RVA: 0x18C4750
	private void set_twist(float value) { }

	// RVA: 0x18C4758
	public Vector2 get_tilt() { }

	// RVA: 0x18C4760
	private void set_tilt(Vector2 value) { }

	// RVA: 0x18C4768
	public PenStatus get_penStatus() { }

	// RVA: 0x18C4770
	private void set_penStatus(PenStatus value) { }

	// RVA: 0x18C4778
	public Vector2 get_radius() { }

	// RVA: 0x18C4780
	private void set_radius(Vector2 value) { }

	// RVA: 0x18C4788
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18C4790
	private void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18C4798
	public EventModifiers get_modifiers() { }

	// RVA: 0x18C47A0
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x18C47A8
	public bool get_shiftKey() { }

	// RVA: 0x18C47B4
	public bool get_ctrlKey() { }

	// RVA: 0x18C47C0
	public bool get_commandKey() { }

	// RVA: 0x18C47CC
	public bool get_altKey() { }

	// RVA: 0x18C47D8
	public bool get_actionKey() { }

	// RVA: 0x18C403C
	public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18C4578
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x18C4640
	public void .ctor() { }

	// RVA: 0x18C48A4
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

	// RVA: 0x18C17DC
	public IPanel get_panel() { }

	// RVA: 0x18C17E4
	public void set_panel(IPanel value) { }

	// RVA: 0x18C1C20
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18C1C38
	private EventSystem get_eventSystem() { }

	// RVA: 0x18C1D58
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x18C1E4C
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x18C1E88
	protected override void OnEnable() { }

	// RVA: 0x18C1E90
	protected override void OnDisable() { }

	// RVA: 0x18C1A64
	private void RegisterCallbacks() { }

	// RVA: 0x18C18A8
	private void UnregisterCallbacks() { }

	// RVA: 0x18C1E98
	private void OnPanelDestroyed() { }

	// RVA: 0x18C1F08
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x18C2128
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x18C212C
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18C21AC
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18C21C0
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x18C2550
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18C276C
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18C2A74
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18C2DB8
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18C2E1C
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18C2E44
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18C3240
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x18C3468
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x18C36B0
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18C24E8
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x18C38A0
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x18C38C4
	internal void Update() { }

	// RVA: 0x18C3954
	private void LateUpdate() { }

	// RVA: 0x18C306C
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x18C395C
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x18C39F0
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x18C3E80
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	// RVA: 0x18C3A68
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x18C3C74
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x18C236C
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18C4590
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PanelRaycaster
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Methods

	// RVA: 0x18C48B8
	public IPanel get_panel() { }

	// RVA: 0x18C48C0
	public void set_panel(IPanel value) { }

	// RVA: 0x18C4AFC
	private void RegisterCallbacks() { }

	// RVA: 0x18C4A5C
	private void UnregisterCallbacks() { }

	// RVA: 0x18C4B9C
	private void OnPanelDestroyed() { }

	// RVA: 0x18C4BA4
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18C4BBC
	public override int get_sortOrderPriority() { }

	// RVA: 0x18C4C64
	public override int get_renderOrderPriority() { }

	// RVA: 0x18C4D04
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x18C51C0
	public override Camera get_eventCamera() { }

	// RVA: 0x18C51C8
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class AxisEventData
{
	// Fields
	private Vector2 <moveVector>k__BackingField; // 0x20
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Methods

	// RVA: 0x18C51D8
	public Vector2 get_moveVector() { }

	// RVA: 0x18C51E0
	public void set_moveVector(Vector2 value) { }

	// RVA: 0x18C51E8
	public MoveDirection get_moveDir() { }

	// RVA: 0x18C51F0
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x18C51F8
	public void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData
{
	// Fields
	protected bool m_Used; // 0x10

	// Methods

	// RVA: 0x18C52A4
	public virtual void Reset() { }

	// RVA: 0x18C52AC
	public virtual void Use() { }

	// RVA: 0x18C52B8
	public virtual bool get_used() { }

	// RVA: 0x18C52C0
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseEventData
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Methods

	// RVA: 0x18C5270
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18C52C8
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18C52E8
	public GameObject get_selectedObject() { }

	// RVA: 0x18C5308
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

	// RVA: 0x18C55B0
	public GameObject get_pointerEnter() { }

	// RVA: 0x18C55B8
	public void set_pointerEnter(GameObject value) { }

	// RVA: 0x18C55C0
	public GameObject get_lastPress() { }

	// RVA: 0x18C55C8
	private void set_lastPress(GameObject value) { }

	// RVA: 0x18C55D0
	public GameObject get_rawPointerPress() { }

	// RVA: 0x18C55D8
	public void set_rawPointerPress(GameObject value) { }

	// RVA: 0x18C55E0
	public GameObject get_pointerDrag() { }

	// RVA: 0x18C55E8
	public void set_pointerDrag(GameObject value) { }

	// RVA: 0x18C55F0
	public GameObject get_pointerClick() { }

	// RVA: 0x18C55F8
	public void set_pointerClick(GameObject value) { }

	// RVA: 0x18C5600
	public RaycastResult get_pointerCurrentRaycast() { }

	// RVA: 0x18C561C
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	// RVA: 0x18C564C
	public RaycastResult get_pointerPressRaycast() { }

	// RVA: 0x18C5668
	public void set_pointerPressRaycast(RaycastResult value) { }

	// RVA: 0x18C5698
	public bool get_eligibleForClick() { }

	// RVA: 0x18C56A0
	public void set_eligibleForClick(bool value) { }

	// RVA: 0x18C56A8
	public int get_displayIndex() { }

	// RVA: 0x18C56B0
	public void set_displayIndex(int value) { }

	// RVA: 0x18C56B8
	public int get_pointerId() { }

	// RVA: 0x18C56C0
	public void set_pointerId(int value) { }

	// RVA: 0x18C56C8
	public Vector2 get_position() { }

	// RVA: 0x18C56D4
	public void set_position(Vector2 value) { }

	// RVA: 0x18C56E0
	public Vector2 get_delta() { }

	// RVA: 0x18C56EC
	public void set_delta(Vector2 value) { }

	// RVA: 0x18C56F8
	public Vector2 get_pressPosition() { }

	// RVA: 0x18C5704
	public void set_pressPosition(Vector2 value) { }

	// RVA: 0x18C5710
	public Vector3 get_worldPosition() { }

	// RVA: 0x18C5720
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x18C5730
	public Vector3 get_worldNormal() { }

	// RVA: 0x18C5740
	public void set_worldNormal(Vector3 value) { }

	// RVA: 0x18C5750
	public float get_clickTime() { }

	// RVA: 0x18C5758
	public void set_clickTime(float value) { }

	// RVA: 0x18C5760
	public int get_clickCount() { }

	// RVA: 0x18C5768
	public void set_clickCount(int value) { }

	// RVA: 0x18C5770
	public Vector2 get_scrollDelta() { }

	// RVA: 0x18C577C
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x18C5788
	public bool get_useDragThreshold() { }

	// RVA: 0x18C5790
	public void set_useDragThreshold(bool value) { }

	// RVA: 0x18C5798
	public bool get_dragging() { }

	// RVA: 0x18C57A0
	public void set_dragging(bool value) { }

	// RVA: 0x18C57A8
	public InputButton get_button() { }

	// RVA: 0x18C57B0
	public void set_button(InputButton value) { }

	// RVA: 0x18C57B8
	public float get_pressure() { }

	// RVA: 0x18C57C0
	public void set_pressure(float value) { }

	// RVA: 0x18C57C8
	public float get_tangentialPressure() { }

	// RVA: 0x18C57D0
	public void set_tangentialPressure(float value) { }

	// RVA: 0x18C57D8
	public float get_altitudeAngle() { }

	// RVA: 0x18C57E0
	public void set_altitudeAngle(float value) { }

	// RVA: 0x18C57E8
	public float get_azimuthAngle() { }

	// RVA: 0x18C57F0
	public void set_azimuthAngle(float value) { }

	// RVA: 0x18C57F8
	public float get_twist() { }

	// RVA: 0x18C5800
	public void set_twist(float value) { }

	// RVA: 0x18C5808
	public Vector2 get_tilt() { }

	// RVA: 0x18C5814
	public void set_tilt(Vector2 value) { }

	// RVA: 0x18C5820
	public PenStatus get_penStatus() { }

	// RVA: 0x18C5828
	public void set_penStatus(PenStatus value) { }

	// RVA: 0x18C5830
	public Vector2 get_radius() { }

	// RVA: 0x18C583C
	public void set_radius(Vector2 value) { }

	// RVA: 0x18C5848
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18C5854
	public void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18C5860
	public bool get_fullyExited() { }

	// RVA: 0x18C5868
	public void set_fullyExited(bool value) { }

	// RVA: 0x18C5870
	public bool get_reentered() { }

	// RVA: 0x18C5878
	public void set_reentered(bool value) { }

	// RVA: 0x18C5880
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18C59C0
	public bool IsPointerMoving() { }

	// RVA: 0x18C59E0
	public bool IsScrolling() { }

	// RVA: 0x18C5A00
	public Camera get_enterEventCamera() { }

	// RVA: 0x18C5AC4
	public Camera get_pressEventCamera() { }

	// RVA: 0x18C5B88
	public GameObject get_pointerPress() { }

	// RVA: 0x18C5B90
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x18C5C6C
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

	// RVA: 0x18C83F8
	public void .ctor() { }

	// RVA: 0x18C8F58
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

	// RVA: 0x18C69FC
	public static EventSystem get_current() { }

	// RVA: 0x18C6AF8
	public static void set_current(EventSystem value) { }

	// RVA: 0x18C6CD0
	public bool get_sendNavigationEvents() { }

	// RVA: 0x18C6CD8
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x18C6CE0
	public int get_pixelDragThreshold() { }

	// RVA: 0x18C6CE8
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x18C6CF0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18C6CF8
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x18C6D00
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x18C6D08
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x18C6D10
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x18C6D18
	public bool get_isFocused() { }

	// RVA: 0x18C6D20
	protected void .ctor() { }

	// RVA: 0x18C6DC0
	public void UpdateModules() { }

	// RVA: 0x18C6F34
	public bool get_alreadySelecting() { }

	// RVA: 0x18C5328
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x18C6F3C
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x18C2068
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x18C6FE8
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x18C74E4
	public void RaycastAll(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }

	// RVA: 0x18C7764
	public bool IsPointerOverGameObject() { }

	// RVA: 0x18C7828
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18C78F0
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x18C7A30
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x18C7ACC
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x18C7B68
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart) { }

	// RVA: 0x18C7D3C
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x18C8340
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x18C8070
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x18C8400
	protected override void Start() { }

	// RVA: 0x18C8410
	protected override void OnEnable() { }

	// RVA: 0x18C8598
	protected override void OnDisable() { }

	// RVA: 0x18C86FC
	private void TickModules() { }

	// RVA: 0x18C8830
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18C8840
	protected virtual void Update() { }

	// RVA: 0x18C8B28
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x18C8C98
	public override string ToString() { }

	// RVA: 0x18C8E18
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class TriggerEvent
{
	// Methods

	// RVA: 0x18C93AC
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

	// RVA: 0x18C9400
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class EventTrigger
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates; // 0x20

	// Methods

	// RVA: 0x18C8FE8
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }

	// RVA: 0x18C9120
	public void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18C9128
	protected void .ctor() { }

	// RVA: 0x18C9084
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }

	// RVA: 0x18C9130
	public void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18C9138
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x18C92E0
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18C92EC
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18C92F8
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18C9304
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x18C9310
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18C931C
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18C9328
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18C9334
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18C9340
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18C934C
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18C9358
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18C9364
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x18C9370
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18C937C
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18C9388
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18C9394
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18C93A0
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

	// RVA: 0x316B894
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }

	// RVA: 0x316B894
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x30B2CB8
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

	// RVA: 0x316B894
	public static T ValidateEventData(BaseEventData data) { }

	// RVA: 0x18C94AC
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C95C8
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C96E4
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9800
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C991C
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9A38
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9B54
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9C70
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9D8C
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9EA8
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18C9FC4
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA0E0
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA1FC
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA2AC
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA35C
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA40C
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA528
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA5D8
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x18CA688
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x18CA704
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x18CA780
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x18CA7FC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x18CA878
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x18CA8F4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x18CA970
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x18CA9EC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x18CAA68
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }

	// RVA: 0x18CAAE4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x18CAB60
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }

	// RVA: 0x18CABDC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }

	// RVA: 0x18CAC58
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x18CACD4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }

	// RVA: 0x18CAD50
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x18CADCC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }

	// RVA: 0x18CAE48
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }

	// RVA: 0x18CAEC4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }

	// RVA: 0x18CAF40
	private static void GetEventChain(GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }

	// RVA: 0x30B4264
	public static bool Execute(GameObject target, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }

	// RVA: 0x30B5A04
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }

	// RVA: 0x30B3E68
	private static bool ShouldSendToComponent(Component component) { }

	// RVA: 0x30B933C
	private static void GetEventList(GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }

	// RVA: 0x30B3E68
	public static bool CanHandleEvent(GameObject go) { }

	// RVA: 0x30B57C8
	public static GameObject GetEventHandler(GameObject root) { }

	// RVA: 0x18CB128
	private static void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseInput
{
	// Methods

	// RVA: 0x18CB810
	public virtual string get_compositionString() { }

	// RVA: 0x18CB818
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x18CB820
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x18CB82C
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x18CB834
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x18CB83C
	public virtual bool get_mousePresent() { }

	// RVA: 0x18CB844
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x18CB850
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x18CB85C
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x18CB868
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x18CB870
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x18CB878
	public virtual bool get_touchSupported() { }

	// RVA: 0x18CB880
	public virtual int get_touchCount() { }

	// RVA: 0x18CB888
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x18CB8DC
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x18CB8E8
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x18CB8F4
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

	// RVA: 0x18CB8FC
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x18CB904
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x18CB90C
	public BaseInput get_input() { }

	// RVA: 0x18CBBA4
	public BaseInput get_inputOverride() { }

	// RVA: 0x18CBBAC
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x18CBBB4
	protected EventSystem get_eventSystem() { }

	// RVA: 0x18CBBBC
	protected override void OnEnable() { }

	// RVA: 0x18CBC40
	protected override void OnDisable() { }

	// RVA: -1
	public abstract void Process() { }

	// RVA: 0x18CBC5C
	protected static RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }

	// RVA: 0x18CBD84
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x18CBDD8
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x18CBE24
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x18CC01C
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x18CCCD8
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x18CCE30
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x18CCEDC
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18CCEE4
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x18CCF30
	public virtual void DeactivateModule() { }

	// RVA: 0x18CCF34
	public virtual void ActivateModule() { }

	// RVA: 0x18CCF38
	public virtual void UpdateModule() { }

	// RVA: 0x18CCF3C
	public virtual bool IsModuleSupported() { }

	// RVA: 0x18CCF44
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x18CCFF0
	protected void .ctor() { }

}

// Namespace: 
protected class ButtonState
{
	// Fields
	private InputButton m_Button; // 0x10
	private MouseButtonEventData m_EventData; // 0x18

	// Methods

	// RVA: 0x18CECB8
	public MouseButtonEventData get_eventData() { }

	// RVA: 0x18CECC0
	public void set_eventData(MouseButtonEventData value) { }

	// RVA: 0x18CECC8
	public InputButton get_button() { }

	// RVA: 0x18CECD0
	public void set_button(InputButton value) { }

	// RVA: 0x18CECD8
	public void .ctor() { }

}

// Namespace: 
protected class MouseState
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x18CECE0
	public bool AnyPressesThisFrame() { }

	// RVA: 0x18CEDCC
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x18CEEC0
	public ButtonState GetButtonState(InputButton button) { }

	// RVA: 0x18CDC08
	public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x18CEC2C
	public void .ctor() { }

}

// Namespace: 
public class MouseButtonEventData
{
	// Fields
	public FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x18CEDBC
	public bool PressedThisFrame() { }

	// RVA: 0x18CEEAC
	public bool ReleasedThisFrame() { }

	// RVA: 0x18CF038
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

	// RVA: 0x18CD084
	protected bool GetPointerData(int id, PointerEventData data, bool create) { }

	// RVA: 0x18CD190
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x18CD20C
	protected PointerEventData GetTouchPointerEventData(Touch input, bool pressed, bool released) { }

	// RVA: 0x18CD5EC
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x18CD6B8
	protected FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x18CD740
	protected virtual MouseState GetMousePointerEventData() { }

	// RVA: 0x18CD754
	protected virtual MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x18CDC48
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x18CDCE0
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x18CDD10
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x18CDD58
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x18CE160
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18CE278
	protected void ClearSelection() { }

	// RVA: 0x18CE4B4
	public override string ToString() { }

	// RVA: 0x18CE958
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x18CEA94
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

	// RVA: 0x18CF040
	protected void .ctor() { }

	// RVA: 0x18CF120
	public InputMode get_inputMode() { }

	// RVA: 0x18CF128
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x18CF130
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x18CF138
	public bool get_forceModuleActive() { }

	// RVA: 0x18CF140
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18CF148
	public float get_inputActionsPerSecond() { }

	// RVA: 0x18CF150
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x18CF158
	public float get_repeatDelay() { }

	// RVA: 0x18CF160
	public void set_repeatDelay(float value) { }

	// RVA: 0x18CF168
	public string get_horizontalAxis() { }

	// RVA: 0x18CF170
	public void set_horizontalAxis(string value) { }

	// RVA: 0x18CF178
	public string get_verticalAxis() { }

	// RVA: 0x18CF180
	public void set_verticalAxis(string value) { }

	// RVA: 0x18CF188
	public string get_submitButton() { }

	// RVA: 0x18CF190
	public void set_submitButton(string value) { }

	// RVA: 0x18CF198
	public string get_cancelButton() { }

	// RVA: 0x18CF1A0
	public void set_cancelButton(string value) { }

	// RVA: 0x18CF1A8
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x18CF1B0
	public override void UpdateModule() { }

	// RVA: 0x18CF2BC
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x18CF7B4
	public override bool ShouldActivateModule() { }

	// RVA: 0x18CFA10
	public override void ActivateModule() { }

	// RVA: 0x18CFB3C
	public override void DeactivateModule() { }

	// RVA: 0x18CFB40
	public override void Process() { }

	// RVA: 0x18CFD60
	private bool ProcessTouchEvents() { }

	// RVA: 0x18D0454
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18D01E4
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x18D0E28
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x18CFF30
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x18CFF28
	protected void ProcessMouseEvent() { }

	// RVA: 0x18D1208
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x18D0F38
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x18CFBE4
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x18D1210
	protected void ProcessMousePress(MouseButtonEventData data) { }

	// RVA: 0x18D1708
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

	// RVA: 0x18D1710
	protected void .ctor() { }

	// RVA: 0x18D1714
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x18D171C
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x18D1724
	public bool get_forceModuleActive() { }

	// RVA: 0x18D172C
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18D1734
	public override void UpdateModule() { }

	// RVA: 0x18D18D4
	public override bool IsModuleSupported() { }

	// RVA: 0x18D1910
	public override bool ShouldActivateModule() { }

	// RVA: 0x18D19F4
	private bool UseFakeInput() { }

	// RVA: 0x18D1A24
	public override void Process() { }

	// RVA: 0x18D1A74
	private void FakeTouches() { }

	// RVA: 0x18D1BA0
	private void ProcessTouchEvents() { }

	// RVA: 0x18D1D48
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18D2708
	public override void DeactivateModule() { }

	// RVA: 0x18D270C
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

	// RVA: 0x18D2A50
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18D2B4C
	public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }

	// RVA: 0x18D2BC8
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18D2CC4
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

	// RVA: 0x18D2D60
	public virtual int get_priority() { }

	// RVA: 0x18D2D68
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x18D2D70
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x18C73D8
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x18D2D78
	public override string ToString() { }

	// RVA: 0x18D2FE8
	protected override void OnEnable() { }

	// RVA: 0x18D3068
	protected override void OnDisable() { }

	// RVA: 0x18D30E8
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18D30F8
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18C51D0
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class Physics2DRaycaster
{
	// Methods

	// RVA: 0x18D3108
	protected void .ctor() { }

	// RVA: 0x18D3170
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: 
private class RaycastHitComparer
{
	// Fields
	public static RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x18D3B6C
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x18D3BB8
	public void .ctor() { }

	// RVA: 0x18D3BC0
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

	// RVA: 0x18D313C
	protected void .ctor() { }

	// RVA: 0x18D3174
	public override Camera get_eventCamera() { }

	// RVA: 0x18D32BC
	public virtual int get_depth() { }

	// RVA: 0x18D33A8
	public int get_finalEventMask() { }

	// RVA: 0x18D3490
	public LayerMask get_eventMask() { }

	// RVA: 0x18D3498
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x18D34A0
	public int get_maxRayIntersections() { }

	// RVA: 0x18D34A8
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x18D34B0
	protected bool ComputeRayAndDistance(PointerEventData eventData, Ray ray, int eventDisplayIndex, float distanceToClipPlane) { }

	// RVA: 0x18D37B8
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

	// RVA: 0x18D3C2C
	public GameObject get_gameObject() { }

	// RVA: 0x18D3C34
	public void set_gameObject(GameObject value) { }

	// RVA: 0x18D3C3C
	public bool get_isValid() { }

	// RVA: 0x18D3D04
	public void Clear() { }

	// RVA: 0x18C6380
	public override string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour
{
	// Methods

	// RVA: 0x18D3DD0
	protected virtual void Awake() { }

	// RVA: 0x18C1E8C
	protected virtual void OnEnable() { }

	// RVA: 0x18C840C
	protected virtual void Start() { }

	// RVA: 0x18C1E94
	protected virtual void OnDisable() { }

	// RVA: 0x18D3DD4
	protected virtual void OnDestroy() { }

	// RVA: 0x18D3DD8
	public virtual bool IsActive() { }

	// RVA: 0x18D3DE0
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x18D3DE4
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x18D3104
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x18D3DE8
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x18D3DEC
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x18D30F4
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x18D3DF0
	public bool IsDestroyed() { }

	// RVA: 0x18C4648
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


