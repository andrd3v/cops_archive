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

	// RVA: 0x16E6938
	private static MonoScriptData Get() { }

	// RVA: 0x16E6A3C
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

	// RVA: 0x16E6A44
	public string get_normalTrigger() { }

	// RVA: 0x16E6A4C
	public void set_normalTrigger(string value) { }

	// RVA: 0x16E6A54
	public string get_highlightedTrigger() { }

	// RVA: 0x16E6A5C
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x16E6A64
	public string get_pressedTrigger() { }

	// RVA: 0x16E6A6C
	public void set_pressedTrigger(string value) { }

	// RVA: 0x16E6A74
	public string get_selectedTrigger() { }

	// RVA: 0x16E6A7C
	public void set_selectedTrigger(string value) { }

	// RVA: 0x16E6A84
	public string get_disabledTrigger() { }

	// RVA: 0x16E6A8C
	public void set_disabledTrigger(string value) { }

	// RVA: 0x16E6A94
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ButtonClickedEvent
{
	// Methods

	// RVA: 0x16E6C4C
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

	// RVA: 0x16E6F78
	public void .ctor(int <>1__state) { }

	// RVA: 0x16E6FA4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16E6FA8
	private bool MoveNext() { }

	// RVA: 0x16E70BC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16E70C4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16E7104
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Button
{
	// Fields
	private ButtonClickedEvent m_OnClick; // 0x100

	// Methods

	// RVA: 0x16E6B98
	protected void .ctor() { }

	// RVA: 0x16E6C54
	public ButtonClickedEvent get_onClick() { }

	// RVA: 0x16E6C5C
	public void set_onClick(ButtonClickedEvent value) { }

	// RVA: 0x16E6C6C
	private void Press() { }

	// RVA: 0x16E6D08
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x16E6DB0
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x16E6F00
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

	// RVA: 0x16E710C
	protected void .ctor() { }

	// RVA: 0x16E7350
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x16E7438
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x16E753C
	private void CleanInvalidItems() { }

	// RVA: 0x16E7850
	private void PerformUpdate() { }

	// RVA: 0x16E8454
	private static int ParentCount(Transform child) { }

	// RVA: 0x16E8538
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x16E869C
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16E8840
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16E8798
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16E8940
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16E8A9C
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16E89C0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16E8B1C
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x16E8EC0
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x16E8BB0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16E8D38
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16E8F54
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x16E90DC
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x16E9264
	public static bool IsRebuildingLayout() { }

	// RVA: 0x16E92D8
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x16E934C
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

	// RVA: 0x16E93E8
	public Color get_normalColor() { }

	// RVA: 0x16E93F4
	public void set_normalColor(Color value) { }

	// RVA: 0x16E9400
	public Color get_highlightedColor() { }

	// RVA: 0x16E940C
	public void set_highlightedColor(Color value) { }

	// RVA: 0x16E9418
	public Color get_pressedColor() { }

	// RVA: 0x16E9424
	public void set_pressedColor(Color value) { }

	// RVA: 0x16E9430
	public Color get_selectedColor() { }

	// RVA: 0x16E943C
	public void set_selectedColor(Color value) { }

	// RVA: 0x16E9448
	public Color get_disabledColor() { }

	// RVA: 0x16E9454
	public void set_disabledColor(Color value) { }

	// RVA: 0x16E9460
	public float get_colorMultiplier() { }

	// RVA: 0x16E9468
	public void set_colorMultiplier(float value) { }

	// RVA: 0x16E9470
	public float get_fadeDuration() { }

	// RVA: 0x16E9478
	public void set_fadeDuration(float value) { }

	// RVA: 0x16E9480
	private static void .cctor() { }

	// RVA: 0x16E94FC
	public override bool Equals(object obj) { }

	// RVA: 0x16E95F4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x16E9828
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16E98DC
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x16E9994
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UI
public class ClipperRegistry
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers; // 0x10

	// Methods

	// RVA: 0x16E9A1C
	protected void .ctor() { }

	// RVA: 0x16E81F4
	public static ClipperRegistry get_instance() { }

	// RVA: 0x16E831C
	public void Cull() { }

	// RVA: 0x16E9AA8
	public static void Register(IClipper c) { }

	// RVA: 0x16E9B1C
	public static void Unregister(IClipper c) { }

	// RVA: 0x16E9B7C
	public static void Disable(IClipper c) { }

}

// Namespace: UnityEngine.UI
public static class Clipping
{
	// Methods

	// RVA: 0x16E9BDC
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

	// RVA: 0x16E9DE8
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x16EA00C
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

	// RVA: 0x16EF574
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x16EF5E4
	public void .ctor() { }

	// RVA: 0x16EF5EC
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

	// RVA: 0x16EA098
	public static IFactoryControls get_factory() { }

	// RVA: 0x16EA114
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x16EA2D4
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x16EA570
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x16EA67C
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x16EA438
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x16EA6E0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x16EA7D4
	public static GameObject CreatePanel(Resources resources) { }

	// RVA: 0x16EAF7C
	public static GameObject CreateButton(Resources resources) { }

	// RVA: 0x16EB43C
	public static GameObject CreateText(Resources resources) { }

	// RVA: 0x16EB5F8
	public static GameObject CreateImage(Resources resources) { }

	// RVA: 0x16EB740
	public static GameObject CreateRawImage(Resources resources) { }

	// RVA: 0x16EB888
	public static GameObject CreateSlider(Resources resources) { }

	// RVA: 0x16EC098
	public static GameObject CreateScrollbar(Resources resources) { }

	// RVA: 0x16EC630
	public static GameObject CreateToggle(Resources resources) { }

	// RVA: 0x16ECCC8
	public static GameObject CreateInputField(Resources resources) { }

	// RVA: 0x16ED3B8
	public static GameObject CreateDropdown(Resources resources) { }

	// RVA: 0x16EEAB8
	public static GameObject CreateScrollView(Resources resources) { }

	// RVA: 0x16EF4B0
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

	// RVA: 0x16F2CA8
	public Text get_text() { }

	// RVA: 0x16F2CB0
	public void set_text(Text value) { }

	// RVA: 0x16F2CB8
	public Image get_image() { }

	// RVA: 0x16F2CC0
	public void set_image(Image value) { }

	// RVA: 0x16F2CC8
	public RectTransform get_rectTransform() { }

	// RVA: 0x16F2CD0
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x16F2CD8
	public Toggle get_toggle() { }

	// RVA: 0x16F2CE0
	public void set_toggle(Toggle value) { }

	// RVA: 0x16F2CE8
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x16F2D70
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x16F2E40
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

	// RVA: 0x16F2E48
	public string get_text() { }

	// RVA: 0x16F2E50
	public void set_text(string value) { }

	// RVA: 0x16F2E58
	public Sprite get_image() { }

	// RVA: 0x16F2E60
	public void set_image(Sprite value) { }

	// RVA: 0x16EE860
	public void .ctor() { }

	// RVA: 0x16F01E0
	public void .ctor(string text) { }

	// RVA: 0x16F0340
	public void .ctor(Sprite image) { }

	// RVA: 0x16F2E68
	public void .ctor(string text, Sprite image) { }

}

// Namespace: 
[Serializable]
public class OptionDataList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options; // 0x10

	// Methods

	// RVA: 0x16F2EB8
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x16F2EC0
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x16EFA88
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DropdownEvent
{
	// Methods

	// RVA: 0x16EFB14
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass63_0
{
	// Fields
	public DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x16F1CBC
	public void .ctor() { }

	// RVA: 0x16F2EC8
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

	// RVA: 0x16F2AC4
	public void .ctor(int <>1__state) { }

	// RVA: 0x16F2EF0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16F2EF4
	private bool MoveNext() { }

	// RVA: 0x16F2FB8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16F2FC0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16F3000
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

	// RVA: 0x16EF658
	public RectTransform get_template() { }

	// RVA: 0x16EE7BC
	public void set_template(RectTransform value) { }

	// RVA: 0x16EF660
	public Text get_captionText() { }

	// RVA: 0x16EE7E8
	public void set_captionText(Text value) { }

	// RVA: 0x16EF668
	public Image get_captionImage() { }

	// RVA: 0x16EF670
	public void set_captionImage(Image value) { }

	// RVA: 0x16EF69C
	public Text get_itemText() { }

	// RVA: 0x16EE814
	public void set_itemText(Text value) { }

	// RVA: 0x16EF6A4
	public Image get_itemImage() { }

	// RVA: 0x16EF6AC
	public void set_itemImage(Image value) { }

	// RVA: 0x16EE840
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x16EF6D8
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x16EF70C
	public DropdownEvent get_onValueChanged() { }

	// RVA: 0x16EF714
	public void set_onValueChanged(DropdownEvent value) { }

	// RVA: 0x16EF724
	public float get_alphaFadeSpeed() { }

	// RVA: 0x16EF72C
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x16EF734
	public int get_value() { }

	// RVA: 0x16EF73C
	public void set_value(int value) { }

	// RVA: 0x16EF8B4
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x16EF744
	private void Set(int value, bool sendCallback) { }

	// RVA: 0x16EF8BC
	protected void .ctor() { }

	// RVA: 0x16EFB68
	protected override void Awake() { }

	// RVA: 0x16EFCA8
	protected override void Start() { }

	// RVA: 0x16EFD60
	protected override void OnDisable() { }

	// RVA: 0x16EE868
	public void RefreshShownValue() { }

	// RVA: 0x16F0040
	public void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }

	// RVA: 0x16F00B4
	public void AddOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x16F0214
	public void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }

	// RVA: 0x16F0374
	public void ClearOptions() { }

	// RVA: 0x16F0430
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: 0x315B3A8
	private static T GetOrAddComponent(GameObject go) { }

	// RVA: 0x16F0B74
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x16F1AA4
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x16F1AA8
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x16F0B78
	public void Show() { }

	// RVA: 0x16F20E8
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x16F264C
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x16F26D4
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x16F2778
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x16F2800
	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) { }

	// RVA: 0x16F28A4
	protected virtual void DestroyItem(DropdownItem item) { }

	// RVA: 0x16F1CC4
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }

	// RVA: 0x16F28A8
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x16F1FDC
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x16F2940
	private void SetAlpha(float alpha) { }

	// RVA: 0x16F1AAC
	public void Hide() { }

	// RVA: 0x16F2A3C
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x16EFE28
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x16F2AF0
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x16F2C20
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

	// RVA: 0x16F3008
	public static FontData get_defaultFontData() { }

	// RVA: 0x16F30A4
	public Font get_font() { }

	// RVA: 0x16F30AC
	public void set_font(Font value) { }

	// RVA: 0x16F30B4
	public int get_fontSize() { }

	// RVA: 0x16F30BC
	public void set_fontSize(int value) { }

	// RVA: 0x16F30C4
	public FontStyle get_fontStyle() { }

	// RVA: 0x16F30CC
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x16F30D4
	public bool get_bestFit() { }

	// RVA: 0x16F30DC
	public void set_bestFit(bool value) { }

	// RVA: 0x16F30E4
	public int get_minSize() { }

	// RVA: 0x16F30EC
	public void set_minSize(int value) { }

	// RVA: 0x16F30F4
	public int get_maxSize() { }

	// RVA: 0x16F30FC
	public void set_maxSize(int value) { }

	// RVA: 0x16F3104
	public TextAnchor get_alignment() { }

	// RVA: 0x16F310C
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x16F3114
	public bool get_alignByGeometry() { }

	// RVA: 0x16F311C
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x16F3124
	public bool get_richText() { }

	// RVA: 0x16F312C
	public void set_richText(bool value) { }

	// RVA: 0x16F3134
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x16F313C
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x16F3144
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x16F314C
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x16F3154
	public float get_lineSpacing() { }

	// RVA: 0x16F315C
	public void set_lineSpacing(float value) { }

	// RVA: 0x16F3164
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x16F3168
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x16F309C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x16F31AC
	public static void TrackText(Text t) { }

	// RVA: 0x16F3424
	private static void RebuildForFont(Font f) { }

	// RVA: 0x16F3660
	public static void UntrackText(Text t) { }

	// RVA: 0x16F3898
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

	// RVA: 0x16F3934
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x16F3A84
	public virtual Color get_color() { }

	// RVA: 0x16F3A90
	public virtual void set_color(Color value) { }

	// RVA: 0x16F3AD8
	public virtual bool get_raycastTarget() { }

	// RVA: 0x16F3AE0
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x16F41C4
	public Vector4 get_raycastPadding() { }

	// RVA: 0x16F41D0
	public void set_raycastPadding(Vector4 value) { }

	// RVA: 0x16F41DC
	protected bool get_useLegacyMeshGeneration() { }

	// RVA: 0x16F41E4
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x16F41EC
	protected void .ctor() { }

	// RVA: 0x16F42C4
	public virtual void SetAllDirty() { }

	// RVA: 0x16F455C
	public virtual void SetLayoutDirty() { }

	// RVA: 0x16F4720
	public virtual void SetVerticesDirty() { }

	// RVA: 0x16F4820
	public virtual void SetMaterialDirty() { }

	// RVA: 0x16F4344
	public void SetRaycastDirty() { }

	// RVA: 0x16F4920
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x16F4A30
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x16F4DF8
	protected override void OnTransformParentChanged() { }

	// RVA: 0x16F5320
	public int get_depth() { }

	// RVA: 0x16F4688
	public RectTransform get_rectTransform() { }

	// RVA: 0x16F3CDC
	public Canvas get_canvas() { }

	// RVA: 0x16F4F18
	private void CacheCanvas() { }

	// RVA: 0x16F5340
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x16F5414
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x16F547C
	public virtual Material get_material() { }

	// RVA: 0x16F5538
	public virtual void set_material(Material value) { }

	// RVA: 0x16F5618
	public virtual Material get_materialForRendering() { }

	// RVA: 0x16F57FC
	public virtual Texture get_mainTexture() { }

	// RVA: 0x16F5878
	protected override void OnEnable() { }

	// RVA: 0x16F5A54
	protected override void OnDisable() { }

	// RVA: 0x16F5EB0
	protected override void OnDestroy() { }

	// RVA: 0x16F6084
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x16F6274
	public virtual void OnCullingChanged() { }

	// RVA: 0x16F6368
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x16F6488
	public virtual void LayoutComplete() { }

	// RVA: 0x16F648C
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x16F6490
	protected virtual void UpdateMaterial() { }

	// RVA: 0x16F654C
	protected virtual void UpdateGeometry() { }

	// RVA: 0x16F69E4
	private void DoMeshGeneration() { }

	// RVA: 0x16F655C
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x16F6ED0
	protected static Mesh get_workerMesh() { }

	// RVA: 0x16F7068
	protected virtual void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }

	// RVA: 0x16F706C
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x16F7108
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x16F76FC
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x16F770C
	public virtual void SetNativeSize() { }

	// RVA: 0x16F7710
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x16F7C74
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x16F7268
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x16F8044
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x16F8058
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x16F82C8
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x16F82DC
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x16F837C
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x16F8430
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x16F84E4
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x16F8598
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x16F864C
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x16F8700
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x16F87B4
	private static void .cctor() { }

	// RVA: 0x16F8864
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

	// RVA: 0x16F9E7C
	private static void .cctor() { }

	// RVA: 0x16F9EE8
	public void .ctor() { }

	// RVA: 0x16F9EF0
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

	// RVA: 0x16F886C
	public override int get_sortOrderPriority() { }

	// RVA: 0x16F89BC
	public override int get_renderOrderPriority() { }

	// RVA: 0x16F8A20
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x16F8A28
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x16F8A30
	public BlockingObjects get_blockingObjects() { }

	// RVA: 0x16F8A38
	public void set_blockingObjects(BlockingObjects value) { }

	// RVA: 0x16F8A40
	public LayerMask get_blockingMask() { }

	// RVA: 0x16F8A48
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x16F8A50
	protected void .ctor() { }

	// RVA: 0x16F88C4
	private Canvas get_canvas() { }

	// RVA: 0x16F8AF4
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x16F9D0C
	public override Camera get_eventCamera() { }

	// RVA: 0x16F96AC
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }

	// RVA: 0x16F9DE0
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

	// RVA: 0x16F9F5C
	protected void .ctor() { }

	// RVA: 0x16FA120
	public static GraphicRegistry get_instance() { }

	// RVA: 0x16F50D8
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16F3F6C
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16F4BF8
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16F3D94
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16F5CDC
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16FA208
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x16FA3CC
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x16F95C8
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x16FA4B0
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

	// RVA: 0x16FA544
	public Sprite get_sprite() { }

	// RVA: 0x16EAB04
	public void set_sprite(Sprite value) { }

	// RVA: 0x16FA7DC
	public void DisableSpriteOptimizations() { }

	// RVA: 0x16FA7E4
	public Sprite get_overrideSprite() { }

	// RVA: 0x16FA8EC
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x16FA868
	private Sprite get_activeSprite() { }

	// RVA: 0x16FA978
	public Type get_type() { }

	// RVA: 0x16EAECC
	public void set_type(Type value) { }

	// RVA: 0x16FA980
	public bool get_preserveAspect() { }

	// RVA: 0x16FA988
	public void set_preserveAspect(bool value) { }

	// RVA: 0x16FAA38
	public bool get_fillCenter() { }

	// RVA: 0x16FAA40
	public void set_fillCenter(bool value) { }

	// RVA: 0x16FAAF0
	public FillMethod get_fillMethod() { }

	// RVA: 0x16FAAF8
	public void set_fillMethod(FillMethod value) { }

	// RVA: 0x16FABAC
	public float get_fillAmount() { }

	// RVA: 0x16FABB4
	public void set_fillAmount(float value) { }

	// RVA: 0x16FAC58
	public bool get_fillClockwise() { }

	// RVA: 0x16FAC60
	public void set_fillClockwise(bool value) { }

	// RVA: 0x16FAD10
	public int get_fillOrigin() { }

	// RVA: 0x16FAD18
	public void set_fillOrigin(int value) { }

	// RVA: 0x16FADC8
	public float get_eventAlphaThreshold() { }

	// RVA: 0x16FADD8
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x16FAF54
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x16FADE4
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x16FAF5C
	public bool get_useSpriteMesh() { }

	// RVA: 0x16FAF64
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x16FB014
	protected void .ctor() { }

	// RVA: 0x16FB060
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x16FB1B0
	public override Texture get_mainTexture() { }

	// RVA: 0x16FB444
	public bool get_hasBorder() { }

	// RVA: 0x16FB5F0
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x16FB5F8
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x16FB620
	public float get_pixelsPerUnit() { }

	// RVA: 0x16FB8F0
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x16FB918
	public override Material get_material() { }

	// RVA: 0x16FBB58
	public override void set_material(Material value) { }

	// RVA: 0x16FBC38
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x16FBC3C
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x16FBC90
	private void PreserveSpriteAspectRatio(Rect rect, Vector2 spriteSize) { }

	// RVA: 0x16FBDF4
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x16FC3C4
	public override void SetNativeSize() { }

	// RVA: 0x16FC714
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x16FA5E0
	private void TrackSprite() { }

	// RVA: 0x16FF7D4
	protected override void OnEnable() { }

	// RVA: 0x16FF7FC
	protected override void OnDisable() { }

	// RVA: 0x16FF9A4
	protected override void UpdateMaterial() { }

	// RVA: 0x16FFB80
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x16FC8E0
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x16FCC5C
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x16FD1C0
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x16FDA34
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x17000A8
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x16FFF48
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x16FFE1C
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x16FEB64
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x1700220
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x1700370
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x1700778
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x170077C
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1700780
	public virtual float get_minWidth() { }

	// RVA: 0x1700788
	public virtual float get_preferredWidth() { }

	// RVA: 0x170099C
	public virtual float get_flexibleWidth() { }

	// RVA: 0x17009A4
	public virtual float get_minHeight() { }

	// RVA: 0x17009AC
	public virtual float get_preferredHeight() { }

	// RVA: 0x1700BC0
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1700BC8
	public virtual int get_layoutPriority() { }

	// RVA: 0x1700BD0
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1701240
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x170159C
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x16FF678
	private static void TrackImage(Image g) { }

	// RVA: 0x16FF900
	private static void UnTrackImage(Image g) { }

	// RVA: 0x1701844
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1701888
	private static void .cctor() { }

	// RVA: 0x16FA54C
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	// RVA: 0x17019E8
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

	// RVA: 0x18814D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x188CE9C
	public virtual Char Invoke(string text, int charIndex, Char addedChar) { }

	// RVA: 0x188CEB0
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, Char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x188CFA4
	public virtual Char EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class SubmitEvent
{
	// Methods

	// RVA: 0x1880B7C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class EndEditEvent
{
	// Methods

	// RVA: 0x1880BD0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class OnChangeEvent
{
	// Methods

	// RVA: 0x1880C24
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

	// RVA: 0x1883BE0
	public void .ctor(int <>1__state) { }

	// RVA: 0x188CFD0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x188CFD4
	private bool MoveNext() { }

	// RVA: 0x188D15C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x188D164
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x188D1A4
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

	// RVA: 0x1886D80
	public void .ctor(int <>1__state) { }

	// RVA: 0x188D1AC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x188D1B0
	private bool MoveNext() { }

	// RVA: 0x188D450
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x188D458
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x188D498
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

	// RVA: 0x18806F4
	private BaseInput get_input() { }

	// RVA: 0x188085C
	private string get_compositionString() { }

	// RVA: 0x1880918
	protected void .ctor() { }

	// RVA: 0x1880D60
	protected Mesh get_mesh() { }

	// RVA: 0x1880E50
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1880EDC
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1880F48
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1881010
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1881018
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1881094
	public string get_text() { }

	// RVA: 0x188109C
	public void set_text(string value) { }

	// RVA: 0x18814D0
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x18810A4
	private void SetText(string value, bool sendCallback) { }

	// RVA: 0x1881B88
	public bool get_isFocused() { }

	// RVA: 0x1881B90
	public float get_caretBlinkRate() { }

	// RVA: 0x1881B98
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1881CF8
	public int get_caretWidth() { }

	// RVA: 0x1881D00
	public void set_caretWidth(int value) { }

	// RVA: 0x1881E68
	public Text get_textComponent() { }

	// RVA: 0x1881E70
	public void set_textComponent(Text value) { }

	// RVA: 0x1882114
	public Graphic get_placeholder() { }

	// RVA: 0x188211C
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1882178
	public Color get_caretColor() { }

	// RVA: 0x18821C4
	public void set_caretColor(Color value) { }

	// RVA: 0x188226C
	public bool get_customCaretColor() { }

	// RVA: 0x1882274
	public void set_customCaretColor(bool value) { }

	// RVA: 0x188231C
	public Color get_selectionColor() { }

	// RVA: 0x1882330
	public void set_selectionColor(Color value) { }

	// RVA: 0x18823D8
	public EndEditEvent get_onEndEdit() { }

	// RVA: 0x18823E0
	public void set_onEndEdit(EndEditEvent value) { }

	// RVA: 0x188243C
	public SubmitEvent get_onSubmit() { }

	// RVA: 0x1882444
	public void set_onSubmit(SubmitEvent value) { }

	// RVA: 0x18824A0
	public OnChangeEvent get_onValueChange() { }

	// RVA: 0x18824A8
	public void set_onValueChange(OnChangeEvent value) { }

	// RVA: 0x1882560
	public OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1882504
	public void set_onValueChanged(OnChangeEvent value) { }

	// RVA: 0x1882568
	public OnValidateInput get_onValidateInput() { }

	// RVA: 0x1882570
	public void set_onValidateInput(OnValidateInput value) { }

	// RVA: 0x18825CC
	public int get_characterLimit() { }

	// RVA: 0x18825D4
	public void set_characterLimit(int value) { }

	// RVA: 0x18826A0
	public ContentType get_contentType() { }

	// RVA: 0x18826A8
	public void set_contentType(ContentType value) { }

	// RVA: 0x18828C0
	public LineType get_lineType() { }

	// RVA: 0x18828C8
	public void set_lineType(LineType value) { }

	// RVA: 0x1882B0C
	public InputType get_inputType() { }

	// RVA: 0x1882B14
	public void set_inputType(InputType value) { }

	// RVA: 0x1882D0C
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1882D14
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1882D1C
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1882DC0
	public CharacterValidation get_characterValidation() { }

	// RVA: 0x1882DC8
	public void set_characterValidation(CharacterValidation value) { }

	// RVA: 0x1882E6C
	public bool get_readOnly() { }

	// RVA: 0x1882E74
	public void set_readOnly(bool value) { }

	// RVA: 0x1882E7C
	public bool get_multiLine() { }

	// RVA: 0x1882E90
	public Char get_asteriskChar() { }

	// RVA: 0x1882E98
	public void set_asteriskChar(Char value) { }

	// RVA: 0x1882F3C
	public bool get_wasCanceled() { }

	// RVA: 0x1882F44
	protected void ClampPos(int pos) { }

	// RVA: 0x1882F84
	protected int get_caretPositionInternal() { }

	// RVA: 0x1882FB4
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1882FF4
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1883024
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1883064
	private bool get_hasSelection() { }

	// RVA: 0x18830BC
	public int get_caretPosition() { }

	// RVA: 0x18830EC
	public void set_caretPosition(int value) { }

	// RVA: 0x1883280
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1883198
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x18832B0
	public int get_selectionFocusPosition() { }

	// RVA: 0x188320C
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x18832E0
	protected override void OnEnable() { }

	// RVA: 0x1883588
	protected override void OnDisable() { }

	// RVA: 0x1883AF8
	protected override void OnDestroy() { }

	// RVA: 0x1883B68
	private IEnumerator CaretBlink() { }

	// RVA: 0x1883C0C
	private void SetCaretVisible() { }

	// RVA: 0x1881C20
	private void SetCaretActive() { }

	// RVA: 0x1883C54
	private void UpdateCaretMaterial() { }

	// RVA: 0x1883DB0
	protected void OnFocus() { }

	// RVA: 0x1883DF4
	protected void SelectAll() { }

	// RVA: 0x1883E38
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1883ED0
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1883FA0
	private static string get_clipboard() { }

	// RVA: 0x1884010
	private static void set_clipboard(string value) { }

	// RVA: 0x1884098
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x188417C
	private bool InPlaceEditing() { }

	// RVA: 0x18841C0
	private bool InPlaceEditingChanged() { }

	// RVA: 0x188426C
	private RangeInt GetInternalSelection() { }

	// RVA: 0x188437C
	private void UpdateKeyboardCaret() { }

	// RVA: 0x188446C
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x188458C
	protected virtual void LateUpdate() { }

	// RVA: 0x1885E88
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x1886274
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x1886494
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x18868E4
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1886A04
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1886A30
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1886CF4
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1886DAC
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1886DD4
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1886FE8
	protected EditState KeyPressed(Event evt) { }

	// RVA: 0x1888298
	private bool IsValidChar(Char c) { }

	// RVA: 0x1888320
	public void ProcessEvent(Event e) { }

	// RVA: 0x1888324
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1887B3C
	private string GetSelectedString() { }

	// RVA: 0x1888540
	private int FindtNextWordBegin() { }

	// RVA: 0x18880C8
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1888628
	private int FindtPrevWordBegin() { }

	// RVA: 0x1887F08
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x18886F8
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x1888810
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1888D98
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1888290
	private void MoveDown(bool shift) { }

	// RVA: 0x1889308
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1888288
	private void MoveUp(bool shift) { }

	// RVA: 0x18894D4
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1887C18
	private void Delete() { }

	// RVA: 0x188793C
	private void ForwardSpace() { }

	// RVA: 0x18876B4
	private void Backspace() { }

	// RVA: 0x1889668
	private void Insert(Char c) { }

	// RVA: 0x1887EB0
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1885E00
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1881594
	private void SendOnValueChanged() { }

	// RVA: 0x1889878
	protected void SendOnEndEdit() { }

	// RVA: 0x1885690
	protected void SendOnSubmit() { }

	// RVA: 0x1889908
	protected virtual void Append(string input) { }

	// RVA: 0x18899CC
	protected virtual void Append(Char input) { }

	// RVA: 0x1881624
	protected void UpdateLabel() { }

	// RVA: 0x188AD98
	private bool IsSelectionVisible() { }

	// RVA: 0x188AE7C
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x188675C
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x1889C98
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x188AFD8
	public void ForceLabelUpdate() { }

	// RVA: 0x1881DE0
	private void MarkGeometryAsDirty() { }

	// RVA: 0x188AFDC
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x188B52C
	public virtual void LayoutComplete() { }

	// RVA: 0x188B530
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x188AFEC
	private void UpdateGeometry() { }

	// RVA: 0x18850FC
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x188B534
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x188B7A4
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x188C6CC
	private void CreateCursorVerts() { }

	// RVA: 0x188BF0C
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1885720
	protected Char Validate(string text, int pos, Char ch) { }

	// RVA: 0x188C818
	public void ActivateInputField() { }

	// RVA: 0x1884BFC
	private void ActivateInputFieldInternal() { }

	// RVA: 0x188C98C
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x188C9D8
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1883844
	public void DeactivateInputField() { }

	// RVA: 0x188CA00
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x188CA30
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18827F0
	private void EnforceContentType() { }

	// RVA: 0x1880C78
	private void EnforceTextHOverflow() { }

	// RVA: 0x188298C
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	// RVA: 0x1882BB8
	private void SetToCustom() { }

	// RVA: 0x188CA90
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x188CABC
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x188CAC0
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x188CAC4
	public virtual float get_minWidth() { }

	// RVA: 0x188CACC
	public virtual float get_preferredWidth() { }

	// RVA: 0x188CC50
	public virtual float get_flexibleWidth() { }

	// RVA: 0x188CC58
	public virtual float get_minHeight() { }

	// RVA: 0x188CC60
	public virtual float get_preferredHeight() { }

	// RVA: 0x188CDD0
	public virtual float get_flexibleHeight() { }

	// RVA: 0x188CDD8
	public virtual int get_layoutPriority() { }

	// RVA: 0x188CDE0
	private static void .cctor() { }

	// RVA: 0x188CE94
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

	// RVA: 0x188D4A0
	public AspectMode get_aspectMode() { }

	// RVA: 0x188D4A8
	public void set_aspectMode(AspectMode value) { }

	// RVA: 0x188D550
	public float get_aspectRatio() { }

	// RVA: 0x188D558
	public void set_aspectRatio(float value) { }

	// RVA: 0x188D608
	private RectTransform get_rectTransform() { }

	// RVA: 0x188D700
	protected void .ctor() { }

	// RVA: 0x188D710
	protected override void OnEnable() { }

	// RVA: 0x188D7AC
	protected override void Start() { }

	// RVA: 0x188D92C
	protected override void OnDisable() { }

	// RVA: 0x188DEE8
	protected override void OnTransformParentChanged() { }

	// RVA: 0x188DF84
	protected virtual void Update() { }

	// RVA: 0x188DF98
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x188DF9C
	private void UpdateRect() { }

	// RVA: 0x188E36C
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x188E250
	private Vector2 GetParentSize() { }

	// RVA: 0x188E464
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x188E468
	public virtual void SetLayoutVertical() { }

	// RVA: 0x188D54C
	protected void SetDirty() { }

	// RVA: 0x188D80C
	public bool IsComponentValidOnObject() { }

	// RVA: 0x188D904
	public bool IsAspectModeValid() { }

	// RVA: 0x188E46C
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

	// RVA: 0x188E474
	public ScaleMode get_uiScaleMode() { }

	// RVA: 0x188E47C
	public void set_uiScaleMode(ScaleMode value) { }

	// RVA: 0x188E484
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x188E48C
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x188E494
	public float get_scaleFactor() { }

	// RVA: 0x188E49C
	public void set_scaleFactor(float value) { }

	// RVA: 0x188E4B8
	public Vector2 get_referenceResolution() { }

	// RVA: 0x188E4C0
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x188E548
	public ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x188E550
	public void set_screenMatchMode(ScreenMatchMode value) { }

	// RVA: 0x188E558
	public float get_matchWidthOrHeight() { }

	// RVA: 0x188E560
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x188E568
	public Unit get_physicalUnit() { }

	// RVA: 0x188E570
	public void set_physicalUnit(Unit value) { }

	// RVA: 0x188E578
	public float get_fallbackScreenDPI() { }

	// RVA: 0x188E580
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x188E588
	public float get_defaultSpriteDPI() { }

	// RVA: 0x188E590
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x188E5A4
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x188E5AC
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x188E5B4
	protected void .ctor() { }

	// RVA: 0x188E5FC
	protected override void OnEnable() { }

	// RVA: 0x188E6E8
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x188E6F8
	protected override void OnDisable() { }

	// RVA: 0x188E8C0
	protected virtual void Handle() { }

	// RVA: 0x188E9FC
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x188EA94
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x188EB2C
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x188EE20
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x188E800
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x188E860
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

	// RVA: 0x188EEE4
	public FitMode get_horizontalFit() { }

	// RVA: 0x188EEEC
	public void set_horizontalFit(FitMode value) { }

	// RVA: 0x188F064
	public FitMode get_verticalFit() { }

	// RVA: 0x188F06C
	public void set_verticalFit(FitMode value) { }

	// RVA: 0x188F13C
	private RectTransform get_rectTransform() { }

	// RVA: 0x188F234
	protected void .ctor() { }

	// RVA: 0x188F23C
	protected override void OnEnable() { }

	// RVA: 0x188F2EC
	protected override void OnDisable() { }

	// RVA: 0x188F370
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x188F418
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x188F514
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x188F544
	public virtual void SetLayoutVertical() { }

	// RVA: 0x188EFBC
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

	// RVA: 0x188F54C
	public Corner get_startCorner() { }

	// RVA: 0x188F554
	public void set_startCorner(Corner value) { }

	// RVA: 0x188F5C4
	public Axis get_startAxis() { }

	// RVA: 0x188F5CC
	public void set_startAxis(Axis value) { }

	// RVA: 0x188F63C
	public Vector2 get_cellSize() { }

	// RVA: 0x188F644
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x188F6C0
	public Vector2 get_spacing() { }

	// RVA: 0x188F6C8
	public void set_spacing(Vector2 value) { }

	// RVA: 0x188F744
	public Constraint get_constraint() { }

	// RVA: 0x188F74C
	public void set_constraint(Constraint value) { }

	// RVA: 0x188F7BC
	public int get_constraintCount() { }

	// RVA: 0x188F7C4
	public void set_constraintCount(int value) { }

	// RVA: 0x188F83C
	protected void .ctor() { }

	// RVA: 0x188FA00
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18900AC
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x189040C
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1890D58
	public override void SetLayoutVertical() { }

	// RVA: 0x1890414
	private void SetCellsAlongAxis(int axis) { }

}

// Namespace: UnityEngine.UI
public class HorizontalLayoutGroup
{
	// Methods

	// RVA: 0x1890FB4
	protected void .ctor() { }

	// RVA: 0x1890FCC
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18914D4
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x18914E0
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1891D70
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

	// RVA: 0x1891D7C
	public float get_spacing() { }

	// RVA: 0x1891D84
	public void set_spacing(float value) { }

	// RVA: 0x1891DFC
	public bool get_childForceExpandWidth() { }

	// RVA: 0x1891E04
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1891E74
	public bool get_childForceExpandHeight() { }

	// RVA: 0x1891E7C
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1891EEC
	public bool get_childControlWidth() { }

	// RVA: 0x1891EF4
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1891F64
	public bool get_childControlHeight() { }

	// RVA: 0x1891F6C
	public void set_childControlHeight(bool value) { }

	// RVA: 0x1891FDC
	public bool get_childScaleWidth() { }

	// RVA: 0x1891FE4
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1892054
	public bool get_childScaleHeight() { }

	// RVA: 0x189205C
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x18920CC
	public bool get_reverseArrangement() { }

	// RVA: 0x18920D4
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x1890FF8
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x18914EC
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1892144
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, float min, float preferred, float flexible) { }

	// RVA: 0x1890FC0
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

	// RVA: 0x18928FC
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x1892904
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x1892ADC
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1892AE0
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1892AE4
	public virtual float get_minWidth() { }

	// RVA: 0x1892AEC
	public virtual void set_minWidth(float value) { }

	// RVA: 0x1892BF8
	public virtual float get_minHeight() { }

	// RVA: 0x1892C00
	public virtual void set_minHeight(float value) { }

	// RVA: 0x1892D0C
	public virtual float get_preferredWidth() { }

	// RVA: 0x1892D14
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x1892E20
	public virtual float get_preferredHeight() { }

	// RVA: 0x1892E28
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x1892F34
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1892F3C
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x1893048
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1893050
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x189315C
	public virtual int get_layoutPriority() { }

	// RVA: 0x1893164
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1893268
	protected void .ctor() { }

	// RVA: 0x1893288
	protected override void OnEnable() { }

	// RVA: 0x1893364
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1893438
	protected override void OnDisable() { }

	// RVA: 0x1893524
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18935F8
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1892A08
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

	// RVA: 0x1893CC4
	public void .ctor(int <>1__state) { }

	// RVA: 0x1893CF0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1893CF4
	private bool MoveNext() { }

	// RVA: 0x1893DA8
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1893DB0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1893DF0
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

	// RVA: 0x18936CC
	public RectOffset get_padding() { }

	// RVA: 0x18936D4
	public void set_padding(RectOffset value) { }

	// RVA: 0x1893734
	public TextAnchor get_childAlignment() { }

	// RVA: 0x189373C
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1890314
	protected RectTransform get_rectTransform() { }

	// RVA: 0x18937AC
	protected System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }

	// RVA: 0x188FC00
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: 0x18937B4
	public virtual float get_minWidth() { }

	// RVA: 0x18937BC
	public virtual float get_preferredWidth() { }

	// RVA: 0x18937C4
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18937CC
	public virtual float get_minHeight() { }

	// RVA: 0x18937D4
	public virtual float get_preferredHeight() { }

	// RVA: 0x18937DC
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18937E4
	public virtual int get_layoutPriority() { }

	// RVA: -1
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1
	public abstract void SetLayoutVertical() { }

	// RVA: 0x188F8A8
	protected void .ctor() { }

	// RVA: 0x18937EC
	protected override void OnEnable() { }

	// RVA: 0x1893958
	protected override void OnDisable() { }

	// RVA: 0x18939DC
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1892868
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x1892758
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x18927E0
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1890D60
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x189225C
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1890014
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x18939E0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x1892508
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x1890ED4
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x189229C
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1893AB8
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x1893C08
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1893C48
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x315B3A8
	protected void SetProperty(T currentValue, T newValue) { }

	// RVA: 0x1893814
	protected void SetDirty() { }

	// RVA: 0x1893C4C
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

	// RVA: 0x18953DC
	private static void .cctor() { }

	// RVA: 0x1895448
	public void .ctor() { }

	// RVA: 0x1895450
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x18954A8
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x18954E0
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1895574
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1895650
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x189572C
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x189580C
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

	// RVA: 0x1893DF8
	private void Initialize(RectTransform controller) { }

	// RVA: 0x1893E3C
	private void Clear() { }

	// RVA: 0x1893E6C
	private static void .cctor() { }

	// RVA: 0x189405C
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x18940DC
	public Transform get_transform() { }

	// RVA: 0x18940E4
	public bool IsDestroyed() { }

	// RVA: 0x1894150
	private static void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }

	// RVA: 0x1894270
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x189437C
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18949C0
	private void PerformLayoutControl(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x1894698
	private void PerformLayoutCalculation(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x188D9B0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1894E38
	private static bool ValidController(RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }

	// RVA: 0x18950A0
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1895244
	public void LayoutComplete() { }

	// RVA: 0x18952E8
	public void GraphicUpdateComplete() { }

	// RVA: 0x18952EC
	public override int GetHashCode() { }

	// RVA: 0x18952F4
	public override bool Equals(object obj) { }

	// RVA: 0x1895348
	public override string ToString() { }

	// RVA: 0x18953D4
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

	// RVA: 0x1896498
	private static void .cctor() { }

	// RVA: 0x1896504
	public void .ctor() { }

	// RVA: 0x189650C
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x18965C0
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x1896674
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x1896728
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x18967DC
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1896890
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1896944
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x18969F8
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

// Namespace: UnityEngine.UI
public static class LayoutUtility
{
	// Methods

	// RVA: 0x188F4FC
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x188F508
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x18928F0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1895A04
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x1895CF4
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x1895FE4
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x18958EC
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1895B1C
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x1895ECC
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x18960FC
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue) { }

	// RVA: 0x1896120
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue, ILayoutElement source) { }

}

// Namespace: UnityEngine.UI
public class VerticalLayoutGroup
{
	// Methods

	// RVA: 0x1896AAC
	protected void .ctor() { }

	// RVA: 0x1896AB8
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1896AE4
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1896AF0
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1896AFC
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

	// RVA: 0x1896B08
	public RectTransform get_rectTransform() { }

	// RVA: 0x1896BB4
	public bool get_showMaskGraphic() { }

	// RVA: 0x1896BBC
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1896D54
	public Graphic get_graphic() { }

	// RVA: 0x1896E00
	protected void .ctor() { }

	// RVA: 0x1896E10
	public virtual bool MaskEnabled() { }

	// RVA: 0x1896F3C
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1896F40
	protected override void OnEnable() { }

	// RVA: 0x1897568
	protected override void OnDisable() { }

	// RVA: 0x1897978
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1897AB4
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: 
[Serializable]
public class CullStateChangedEvent
{
	// Methods

	// RVA: 0x1899548
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

	// RVA: 0x18984F4
	public CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x18984FC
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	// RVA: 0x1898504
	public bool get_maskable() { }

	// RVA: 0x189850C
	public void set_maskable(bool value) { }

	// RVA: 0x1898538
	public bool get_isMaskingGraphic() { }

	// RVA: 0x189727C
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x1898540
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1898670
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18989C0
	private void UpdateCull(bool cull) { }

	// RVA: 0x1898AA8
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1898B28
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x1898B64
	protected override void OnEnable() { }

	// RVA: 0x1898D88
	protected override void OnDisable() { }

	// RVA: 0x1898E54
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1898EB4
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1898EB8
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1898754
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1898BC4
	private void UpdateClipParent() { }

	// RVA: 0x1899398
	public virtual void RecalculateClipping() { }

	// RVA: 0x189939C
	public virtual void RecalculateMasking() { }

	// RVA: 0x1899434
	protected void .ctor() { }

	// RVA: 0x189959C
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

// Namespace: UnityEngine.UI
public class MaskUtilities
{
	// Methods

	// RVA: 0x18995A4
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x1897290
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x1897F38
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x189812C
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x1899880
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x1898F18
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x1899A54
	public static void GetRectMasksForClip(RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }

	// RVA: 0x1899E30
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

	// RVA: 0x1899E38
	public static void Destroy(object obj) { }

	// RVA: 0x1899FCC
	public static void DestroyImmediate(object obj) { }

}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities
{
	// Methods

	// RVA: 0x189A120
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, Vector2 position) { }

	// RVA: 0x189A630
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x189A198
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

	// RVA: 0x189A70C
	public Mode get_mode() { }

	// RVA: 0x189A714
	public void set_mode(Mode value) { }

	// RVA: 0x189A71C
	public bool get_wrapAround() { }

	// RVA: 0x189A724
	public void set_wrapAround(bool value) { }

	// RVA: 0x189A72C
	public Selectable get_selectOnUp() { }

	// RVA: 0x189A734
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x189A73C
	public Selectable get_selectOnDown() { }

	// RVA: 0x189A744
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x189A74C
	public Selectable get_selectOnLeft() { }

	// RVA: 0x189A754
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x189A75C
	public Selectable get_selectOnRight() { }

	// RVA: 0x189A764
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x189A76C
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x189A78C
	public bool Equals(Navigation other) { }

}

// Namespace: UnityEngine.UI
public class RawImage
{
	// Fields
	private Texture m_Texture; // 0xD8
	private Rect m_UVRect; // 0xE0

	// Methods

	// RVA: 0x189A8F8
	protected void .ctor() { }

	// RVA: 0x189A92C
	public override Texture get_mainTexture() { }

	// RVA: 0x189AB00
	public Texture get_texture() { }

	// RVA: 0x189AB08
	public void set_texture(Texture value) { }

	// RVA: 0x189ABFC
	public Rect get_uvRect() { }

	// RVA: 0x189AC08
	public void set_uvRect(Rect value) { }

	// RVA: 0x189AC40
	public override void SetNativeSize() { }

	// RVA: 0x189AF64
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x189B840
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

	// RVA: 0x189B888
	public Vector4 get_padding() { }

	// RVA: 0x189B894
	public void set_padding(Vector4 value) { }

	// RVA: 0x189B8A4
	public Vector2Int get_softness() { }

	// RVA: 0x189B8AC
	public void set_softness(Vector2Int value) { }

	// RVA: 0x189B8C8
	internal Canvas get_Canvas() { }

	// RVA: 0x189BAA8
	public Rect get_canvasRect() { }

	// RVA: 0x189BB6C
	public RectTransform get_rectTransform() { }

	// RVA: 0x189BC18
	protected void .ctor() { }

	// RVA: 0x189BDBC
	protected override void OnEnable() { }

	// RVA: 0x189BDFC
	protected override void OnDisable() { }

	// RVA: 0x189BF00
	protected override void OnDestroy() { }

	// RVA: 0x189BF2C
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x189C098
	private Rect get_rootCanvasRect() { }

	// RVA: 0x189C2BC
	public virtual void PerformClipping() { }

	// RVA: 0x189CD70
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x189D17C
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x189D2C0
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x189D488
	protected override void OnTransformParentChanged() { }

	// RVA: 0x189D4C4
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

	// RVA: 0x189DB3C
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

	// RVA: 0x189F150
	public void .ctor(int <>1__state) { }

	// RVA: 0x189FDC4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x189FDC8
	private bool MoveNext() { }

	// RVA: 0x18A0214
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x18A021C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x18A025C
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

	// RVA: 0x189D500
	public RectTransform get_handleRect() { }

	// RVA: 0x189D508
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x189D974
	public Direction get_direction() { }

	// RVA: 0x189D97C
	public void set_direction(Direction value) { }

	// RVA: 0x189DA20
	protected void .ctor() { }

	// RVA: 0x189DCD0
	public float get_value() { }

	// RVA: 0x189DD8C
	public void set_value(float value) { }

	// RVA: 0x189DFCC
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x189DFD4
	public float get_size() { }

	// RVA: 0x189DFDC
	public void set_size(float value) { }

	// RVA: 0x189E074
	public int get_numberOfSteps() { }

	// RVA: 0x189E07C
	public void set_numberOfSteps(int value) { }

	// RVA: 0x189E130
	public ScrollEvent get_onValueChanged() { }

	// RVA: 0x189E138
	public void set_onValueChanged(ScrollEvent value) { }

	// RVA: 0x189E148
	private float get_stepSize() { }

	// RVA: 0x189E178
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x189E17C
	public virtual void LayoutComplete() { }

	// RVA: 0x189E180
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x189E184
	protected override void OnEnable() { }

	// RVA: 0x189E4B4
	protected override void OnDisable() { }

	// RVA: 0x189E624
	protected virtual void Update() { }

	// RVA: 0x189D588
	private void UpdateCachedReferences() { }

	// RVA: 0x189DD94
	private void Set(float input, bool sendCallback) { }

	// RVA: 0x189E638
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x189E680
	private Axis get_axis() { }

	// RVA: 0x189E690
	private bool get_reverseValue() { }

	// RVA: 0x189D6D8
	private void UpdateVisuals() { }

	// RVA: 0x189E6A4
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x189E968
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x189E9D4
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x189EA30
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x189EC2C
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x189ED0C
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x189F0A0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x189F000
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x189F17C
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x189F304
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x189F76C
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x189F87C
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x189F98C
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x189FA9C
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x189FBAC
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x189FBC8
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x189FDBC
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

	// RVA: 0x18A0E34
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

	// RVA: 0x18A0264
	public RectTransform get_content() { }

	// RVA: 0x18A026C
	public void set_content(RectTransform value) { }

	// RVA: 0x18A0274
	public bool get_horizontal() { }

	// RVA: 0x18A027C
	public void set_horizontal(bool value) { }

	// RVA: 0x18A0284
	public bool get_vertical() { }

	// RVA: 0x18A028C
	public void set_vertical(bool value) { }

	// RVA: 0x18A0294
	public MovementType get_movementType() { }

	// RVA: 0x18A029C
	public void set_movementType(MovementType value) { }

	// RVA: 0x18A02A4
	public float get_elasticity() { }

	// RVA: 0x18A02AC
	public void set_elasticity(float value) { }

	// RVA: 0x18A02B4
	public bool get_inertia() { }

	// RVA: 0x18A02BC
	public void set_inertia(bool value) { }

	// RVA: 0x18A02C4
	public float get_decelerationRate() { }

	// RVA: 0x18A02CC
	public void set_decelerationRate(float value) { }

	// RVA: 0x18A02D4
	public float get_scrollSensitivity() { }

	// RVA: 0x18A02DC
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x18A02E4
	public RectTransform get_viewport() { }

	// RVA: 0x18A02EC
	public void set_viewport(RectTransform value) { }

	// RVA: 0x18A03FC
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x18A0404
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x18A0608
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x18A0610
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x18A0814
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x18A081C
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18A0824
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x18A082C
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x18A0834
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x18A083C
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x18A09A0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x18A09A8
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x18A0A5C
	public ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x18A0A64
	public void set_onValueChanged(ScrollRectEvent value) { }

	// RVA: 0x18A0A6C
	protected RectTransform get_viewRect() { }

	// RVA: 0x18A0BE0
	public Vector2 get_velocity() { }

	// RVA: 0x18A0BE8
	public void set_velocity(Vector2 value) { }

	// RVA: 0x18A0BF0
	private RectTransform get_rectTransform() { }

	// RVA: 0x18A0CE8
	protected void .ctor() { }

	// RVA: 0x18A0E88
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18A1CB4
	public virtual void LayoutComplete() { }

	// RVA: 0x18A1CB8
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18A0F14
	private void UpdateCachedData() { }

	// RVA: 0x18A1CBC
	protected override void OnEnable() { }

	// RVA: 0x18A1F6C
	protected override void OnDisable() { }

	// RVA: 0x18A21D0
	public override bool IsActive() { }

	// RVA: 0x18A2278
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x18A22FC
	public virtual void StopMovement() { }

	// RVA: 0x18A2350
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x18A2804
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18A2874
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18A29B4
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18A29E0
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18A2D38
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x18A2E18
	protected virtual void LateUpdate() { }

	// RVA: 0x18A1BAC
	protected void UpdatePrevData() { }

	// RVA: 0x18A16FC
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x18A363C
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x18A3B8C
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x18A3974
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x18A3BE0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x18A3A80
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x18A3BF4
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x18A3C08
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x18A3C1C
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x18A3C30
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x18A2CFC
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x18A3F84
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18A4034
	private bool get_hScrollingNeeded() { }

	// RVA: 0x18A40F0
	private bool get_vScrollingNeeded() { }

	// RVA: 0x18A41AC
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18A41B0
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18A41B4
	public virtual float get_minWidth() { }

	// RVA: 0x18A41BC
	public virtual float get_preferredWidth() { }

	// RVA: 0x18A41C4
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18A41CC
	public virtual float get_minHeight() { }

	// RVA: 0x18A41D4
	public virtual float get_preferredHeight() { }

	// RVA: 0x18A41DC
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18A41E4
	public virtual int get_layoutPriority() { }

	// RVA: 0x18A41EC
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18A496C
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18A3824
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x18A4DE8
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x18A4A30
	private void UpdateScrollbarLayout() { }

	// RVA: 0x18A1378
	protected void UpdateBounds() { }

	// RVA: 0x18A4F30
	internal static void AdjustBounds(Bounds viewBounds, Vector2 contentPivot, Vector3 contentSize, Vector3 contentPos) { }

	// RVA: 0x18A484C
	private Bounds GetBounds() { }

	// RVA: 0x18A4FB8
	internal static Bounds InternalGetBounds(Vector3[] corners, Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x18A269C
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x18A51FC
	internal static Vector2 InternalCalculateOffset(Bounds viewBounds, Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, Vector2 delta) { }

	// RVA: 0x18A08F0
	protected void SetDirty() { }

	// RVA: 0x18A0314
	protected void SetDirtyCaching() { }

	// RVA: 0x18A533C
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

	// RVA: 0x18A5344
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x18A53E0
	public static int get_allSelectableCount() { }

	// RVA: 0x18A545C
	public static System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }

	// RVA: 0x18A558C
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x18A567C
	public Navigation get_navigation() { }

	// RVA: 0x18A5694
	public void set_navigation(Navigation value) { }

	// RVA: 0x18A57DC
	public Transition get_transition() { }

	// RVA: 0x18A57E4
	public void set_transition(Transition value) { }

	// RVA: 0x18A58DC
	public ColorBlock get_colors() { }

	// RVA: 0x18A5908
	public void set_colors(ColorBlock value) { }

	// RVA: 0x18A59F0
	public SpriteState get_spriteState() { }

	// RVA: 0x18A59FC
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x18A5ACC
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x18A5AD4
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x18A5BA0
	public Graphic get_targetGraphic() { }

	// RVA: 0x18A5BA8
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x18A5C74
	public bool get_interactable() { }

	// RVA: 0x18A5C7C
	public void set_interactable(bool value) { }

	// RVA: 0x18A5E88
	private bool get_isPointerInside() { }

	// RVA: 0x18A5E90
	private void set_isPointerInside(bool value) { }

	// RVA: 0x18A5E98
	private bool get_isPointerDown() { }

	// RVA: 0x18A5EA0
	private void set_isPointerDown(bool value) { }

	// RVA: 0x18A5EA8
	private bool get_hasSelection() { }

	// RVA: 0x18A5EB0
	private void set_hasSelection(bool value) { }

	// RVA: 0x189DB90
	protected void .ctor() { }

	// RVA: 0x18A5EB8
	public Image get_image() { }

	// RVA: 0x18A5F40
	public void set_image(Image value) { }

	// RVA: 0x18A5F48
	public Animator get_animator() { }

	// RVA: 0x18A5FB0
	protected override void Awake() { }

	// RVA: 0x18A60A0
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x18A6134
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x18A62D8
	public virtual bool IsInteractable() { }

	// RVA: 0x18A62F8
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x189E1C0
	protected override void OnEnable() { }

	// RVA: 0x18A63DC
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18A576C
	private void OnSetProperty() { }

	// RVA: 0x189E4E0
	protected override void OnDisable() { }

	// RVA: 0x18A6410
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18A6368
	protected SelectionState get_currentSelectionState() { }

	// RVA: 0x18A64CC
	protected virtual void InstantClearState() { }

	// RVA: 0x18A6C10
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x18A6EC0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x18A73FC
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x18A75AC
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x189F790
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x189F8A0
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x189F9B0
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x189FAC0
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x189F6C8
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18A6610
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x18A6748
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x18A68DC
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x18A768C
	protected bool IsHighlighted() { }

	// RVA: 0x18A647C
	protected bool IsPressed() { }

	// RVA: 0x18A770C
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x189EE38
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x189F248
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18A77B4
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18A7864
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18A7910
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18A79C0
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18A7A6C
	public virtual void Select() { }

	// RVA: 0x18A7BC0
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility
{
	// Methods

	// RVA: 0x18A7C50
	public static bool SetColor(Color currentValue, Color newValue) { }

	// RVA: 0x315B3A8
	public static bool SetStruct(T currentValue, T newValue) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x18A8EFC
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

	// RVA: 0x18A7C9C
	public RectTransform get_fillRect() { }

	// RVA: 0x18A7CA4
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x18A87D4
	public RectTransform get_handleRect() { }

	// RVA: 0x18A87DC
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18A885C
	public Direction get_direction() { }

	// RVA: 0x18A8864
	public void set_direction(Direction value) { }

	// RVA: 0x18A8908
	public float get_minValue() { }

	// RVA: 0x18A8910
	public void set_minValue(float value) { }

	// RVA: 0x18A89DC
	public float get_maxValue() { }

	// RVA: 0x18A89E4
	public void set_maxValue(float value) { }

	// RVA: 0x18A8AB0
	public bool get_wholeNumbers() { }

	// RVA: 0x18A8AB8
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x18A8B78
	public virtual float get_value() { }

	// RVA: 0x18A8C44
	public virtual void set_value(float value) { }

	// RVA: 0x18A8C58
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18A8C6C
	public float get_normalizedValue() { }

	// RVA: 0x18A8D60
	public void set_normalizedValue(float value) { }

	// RVA: 0x18A8D9C
	public SliderEvent get_onValueChanged() { }

	// RVA: 0x18A8DA4
	public void set_onValueChanged(SliderEvent value) { }

	// RVA: 0x18A8DB4
	private float get_stepSize() { }

	// RVA: 0x18A8DE4
	protected void .ctor() { }

	// RVA: 0x18A8F50
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18A8F54
	public virtual void LayoutComplete() { }

	// RVA: 0x18A8F58
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18A8F5C
	protected override void OnEnable() { }

	// RVA: 0x18A8FA4
	protected override void OnDisable() { }

	// RVA: 0x18A8FD0
	protected virtual void Update() { }

	// RVA: 0x18A9020
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18A7D24
	private void UpdateCachedReferences() { }

	// RVA: 0x18A951C
	private float ClampValue(float input) { }

	// RVA: 0x18A9620
	protected virtual void Set(float input, bool sendCallback) { }

	// RVA: 0x18A97A8
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18A9610
	private Axis get_axis() { }

	// RVA: 0x18A95FC
	private bool get_reverseValue() { }

	// RVA: 0x18A80D0
	private void UpdateVisuals() { }

	// RVA: 0x18A97F0
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x18A9A68
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18A9AC4
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18A9CD0
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18A9D4C
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18AA110
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18AA134
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18AA158
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18AA17C
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18AA1A0
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18AA1BC
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18AA3B0
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

	// RVA: 0x18AA3B8
	public Sprite get_highlightedSprite() { }

	// RVA: 0x18AA3C0
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x18AA3C8
	public Sprite get_pressedSprite() { }

	// RVA: 0x18AA3D0
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x18AA3D8
	public Sprite get_selectedSprite() { }

	// RVA: 0x18AA3E0
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x18AA3E8
	public Sprite get_disabledSprite() { }

	// RVA: 0x18AA3F0
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x18AA3F8
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

	// RVA: 0x18AB11C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class StencilMaterial
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	// RVA: 0x18AA568
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x18AA570
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x18AB058
	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	// RVA: 0x18AA608
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x18AB12C
	public static void Remove(Material customMat) { }

	// RVA: 0x18AB318
	public static void ClearAll() { }

	// RVA: 0x18AB4D0
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

	// RVA: 0x18AB56C
	protected void .ctor() { }

	// RVA: 0x18AB628
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x18AB6E0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x18AB76C
	public override Texture get_mainTexture() { }

	// RVA: 0x18AB9C0
	public void FontTextureChanged() { }

	// RVA: 0x18AB9A0
	public Font get_font() { }

	// RVA: 0x18ABB14
	public void set_font(Font value) { }

	// RVA: 0x18ABC54
	public virtual string get_text() { }

	// RVA: 0x18ABC5C
	public virtual void set_text(string value) { }

	// RVA: 0x18ABD50
	public bool get_supportRichText() { }

	// RVA: 0x18ABD70
	public void set_supportRichText(bool value) { }

	// RVA: 0x18ABDDC
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x18ABDFC
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x18ABE68
	public int get_resizeTextMinSize() { }

	// RVA: 0x18ABE88
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x18ABEEC
	public int get_resizeTextMaxSize() { }

	// RVA: 0x18ABF0C
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x18ABF70
	public TextAnchor get_alignment() { }

	// RVA: 0x18ABF90
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x18ABFF4
	public bool get_alignByGeometry() { }

	// RVA: 0x18AC014
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x18AC05C
	public int get_fontSize() { }

	// RVA: 0x18AC07C
	public void set_fontSize(int value) { }

	// RVA: 0x18AC0E0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x18AC100
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x18AC164
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x18AC184
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x18AC1E8
	public float get_lineSpacing() { }

	// RVA: 0x18AC208
	public void set_lineSpacing(float value) { }

	// RVA: 0x18AC26C
	public FontStyle get_fontStyle() { }

	// RVA: 0x18AC28C
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x18AC2F0
	public float get_pixelsPerUnit() { }

	// RVA: 0x18AC484
	protected override void OnEnable() { }

	// RVA: 0x18AC518
	protected override void OnDisable() { }

	// RVA: 0x18AC588
	protected override void UpdateGeometry() { }

	// RVA: 0x18AC628
	internal void AssignDefaultFont() { }

	// RVA: 0x18AC69C
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x18AC770
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x18AC934
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x18AC9C0
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x18AD12C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18AD130
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18AD134
	public virtual float get_minWidth() { }

	// RVA: 0x18AD13C
	public virtual float get_preferredWidth() { }

	// RVA: 0x18AD294
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18AD29C
	public virtual float get_minHeight() { }

	// RVA: 0x18AD2A4
	public virtual float get_preferredHeight() { }

	// RVA: 0x18AD3C8
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18AD3D0
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

	// RVA: 0x18AD924
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

	// RVA: 0x18AD3D8
	public ToggleGroup get_group() { }

	// RVA: 0x18AD3E0
	public void set_group(ToggleGroup value) { }

	// RVA: 0x18AD83C
	protected void .ctor() { }

	// RVA: 0x18AD978
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18AD97C
	public virtual void LayoutComplete() { }

	// RVA: 0x18AD980
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18AD984
	protected override void OnDestroy() { }

	// RVA: 0x18ADE94
	protected override void OnEnable() { }

	// RVA: 0x18ADF80
	protected override void OnDisable() { }

	// RVA: 0x18ADFAC
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18AD4C0
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x18AE6EC
	public bool get_isOn() { }

	// RVA: 0x18AE6F4
	public void set_isOn(bool value) { }

	// RVA: 0x18AE6FC
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x18AE164
	private void Set(bool value, bool sendCallback) { }

	// RVA: 0x18AD74C
	private void PlayEffect(bool instant) { }

	// RVA: 0x18AE874
	protected override void Start() { }

	// RVA: 0x18AE94C
	private void InternalToggle() { }

	// RVA: 0x18AE9B0
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18AEA24
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18AEA88
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

	// RVA: 0x18AEFE8
	private static void .cctor() { }

	// RVA: 0x18AF054
	public void .ctor() { }

	// RVA: 0x18AF05C
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x18AF078
	internal bool <ActiveToggles>b__14_0(Toggle x) { }

}

// Namespace: UnityEngine.UI
public class ToggleGroup
{
	// Fields
	private bool m_AllowSwitchOff; // 0x20
	protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles; // 0x28

	// Methods

	// RVA: 0x18AEA90
	public bool get_allowSwitchOff() { }

	// RVA: 0x18AEA98
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x18AEAA0
	protected void .ctor() { }

	// RVA: 0x18AEB2C
	protected override void Start() { }

	// RVA: 0x18AEB54
	protected override void OnEnable() { }

	// RVA: 0x18AEB7C
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x18AE4FC
	public void NotifyToggleOn(Toggle toggle, bool sendCallback) { }

	// RVA: 0x18AE3BC
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x18AE45C
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x18ADA4C
	public void EnsureValidState() { }

	// RVA: 0x18AE704
	public bool AnyTogglesOn() { }

	// RVA: 0x18AECF4
	public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }

	// RVA: 0x18AEE24
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x18AEED4
	public void SetAllTogglesOff(bool sendCallback) { }

}

// Namespace: 
public sealed class Raycast3DCallback
{
	// Methods

	// RVA: 0x18AF87C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18AF920
	public virtual bool Invoke(Ray r, RaycastHit hit, float f, int i) { }

	// RVA: 0x18AF960
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18AFAA4
	public virtual bool EndInvoke(RaycastHit hit, IAsyncResult result) { }

}

// Namespace: 
public sealed class RaycastAllCallback
{
	// Methods

	// RVA: 0x18AFB08
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18AFBAC
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x18AFBEC
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18AFD00
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GetRaycastNonAllocCallback
{
	// Methods

	// RVA: 0x18AFD0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18AFDB0
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x18AFDF0
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18AFF10
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

	// RVA: 0x18AF094
	public void .ctor() { }

	// RVA: 0x18AF7D4
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

	// RVA: 0x18AFF3C
	public void .ctor() { }

	// RVA: 0x18AFF44
	public void .ctor(Mesh m) { }

	// RVA: 0x18B0184
	private void InitializeListIfRequired() { }

	// RVA: 0x18B039C
	public void Dispose() { }

	// RVA: 0x189B244
	public void Clear() { }

	// RVA: 0x18B0614
	public int get_currentVertCount() { }

	// RVA: 0x18B066C
	public int get_currentIndexCount() { }

	// RVA: 0x18B06C4
	public void PopulateUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18B086C
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x18B0A14
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x18B0B80
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x18B0D4C
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x189B5D4
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x18B0E58
	public void AddVert(UIVertex v) { }

	// RVA: 0x189B784
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x18ACF78
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x18B0EF0
	public void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x18B0FA0
	public void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

	// RVA: 0x18B0FF4
	public void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }

	// RVA: 0x18B1048
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseVertexEffect
{
	// Methods

	// RVA: -1
	public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x18B10E4
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseMeshEffect
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Methods

	// RVA: 0x18B10EC
	protected Graphic get_graphic() { }

	// RVA: 0x18B11E4
	protected override void OnEnable() { }

	// RVA: 0x18B12AC
	protected override void OnDisable() { }

	// RVA: 0x18B1394
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18B147C
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1
	public abstract void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x18B15F8
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

	// RVA: 0x18B1600
	protected void .ctor() { }

	// RVA: 0x18B1650
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class PositionAsUV1
{
	// Methods

	// RVA: 0x18B1B74
	protected void .ctor() { }

	// RVA: 0x18B1B7C
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

	// RVA: 0x18B1628
	protected void .ctor() { }

	// RVA: 0x18B1C70
	public Color get_effectColor() { }

	// RVA: 0x18B1C7C
	public void set_effectColor(Color value) { }

	// RVA: 0x18B1D68
	public Vector2 get_effectDistance() { }

	// RVA: 0x18B1D70
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x18B1E94
	public bool get_useGraphicAlpha() { }

	// RVA: 0x18B1E9C
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x18B18D0
	protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18B1F60
	protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x18B1F68
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

	// RVA: 0x315B3A8
	public void Add(T item) { }

	// RVA: 0x315B3A8
	public void Add(T item, bool isActive) { }

	// RVA: 0x315B3A8
	public bool AddUnique(T item, bool isActive) { }

	// RVA: 0x315B3A8
	public bool EnableItem(T item) { }

	// RVA: 0x315B3A8
	public bool DisableItem(T item) { }

	// RVA: 0x315B3A8
	public bool Remove(T item) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(T item) { }

	// RVA: 0x30A2828
	public void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A14A4
	public int get_Capacity() { }

	// RVA: 0x30A1224
	public bool get_IsReadOnly() { }

	// RVA: 0x315B3A8
	public int IndexOf(T item) { }

	// RVA: 0x315B3A8
	public void Insert(int index, T item) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int index) { }

	// RVA: 0x30A2560
	private void Swap(int index1, int index2) { }

	// RVA: 0x315B3A8
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, T value) { }

	// RVA: 0x30A27C0
	public void RemoveAll(System.Predicate<T> match) { }

	// RVA: 0x30A27C0
	public void Sort(System.Comparison<T> sortLayoutFunction) { }

	// RVA: 0x30A2378
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

	// RVA: 0x18B22E4
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

	// RVA: 0x18B20DC
	public Color get_startColor() { }

	// RVA: 0x18B20E8
	public void set_startColor(Color value) { }

	// RVA: 0x18B20F4
	public Color get_targetColor() { }

	// RVA: 0x18B2100
	public void set_targetColor(Color value) { }

	// RVA: 0x18B210C
	public ColorTweenMode get_tweenMode() { }

	// RVA: 0x18B2114
	public void set_tweenMode(ColorTweenMode value) { }

	// RVA: 0x18B211C
	public float get_duration() { }

	// RVA: 0x18B2124
	public void set_duration(float value) { }

	// RVA: 0x18B212C
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18B2134
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18B213C
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18B220C
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }

	// RVA: 0x18B2338
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18B2340
	public float GetDuration() { }

	// RVA: 0x18B21FC
	public bool ValidTarget() { }

}

// Namespace: 
public class FloatTweenCallback
{
	// Methods

	// RVA: 0x18B2508
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

	// RVA: 0x18B2348
	public float get_startValue() { }

	// RVA: 0x18B2350
	public void set_startValue(float value) { }

	// RVA: 0x18B2358
	public float get_targetValue() { }

	// RVA: 0x18B2360
	public void set_targetValue(float value) { }

	// RVA: 0x18B2368
	public float get_duration() { }

	// RVA: 0x18B2370
	public void set_duration(float value) { }

	// RVA: 0x18B2378
	public bool get_ignoreTimeScale() { }

	// RVA: 0x18B2380
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x18B2388
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x18B2430
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }

	// RVA: 0x18B255C
	public bool GetIgnoreTimescale() { }

	// RVA: 0x18B2564
	public float GetDuration() { }

	// RVA: 0x18B2420
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

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A17DC
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T0>
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	// RVA: 0x315B3A8
	private static IEnumerator Start(T tweenInfo) { }

	// RVA: 0x30A27C0
	public void Init(MonoBehaviour coroutineContainer) { }

	// RVA: 0x315B3A8
	public void StartTween(T info) { }

	// RVA: 0x30A2378
	public void StopTween() { }

	// RVA: 0x30A2378
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

	// RVA: 0x18B53E0
	public int get_pointerId() { }

	// RVA: 0x18B53E8
	private void set_pointerId(int value) { }

	// RVA: 0x18B53F0
	public string get_pointerType() { }

	// RVA: 0x18B53F8
	private void set_pointerType(string value) { }

	// RVA: 0x18B5400
	public bool get_isPrimary() { }

	// RVA: 0x18B5408
	private void set_isPrimary(bool value) { }

	// RVA: 0x18B5410
	public int get_button() { }

	// RVA: 0x18B5418
	private void set_button(int value) { }

	// RVA: 0x18B5420
	public int get_pressedButtons() { }

	// RVA: 0x18B5428
	private void set_pressedButtons(int value) { }

	// RVA: 0x18B5430
	public Vector3 get_position() { }

	// RVA: 0x18B543C
	private void set_position(Vector3 value) { }

	// RVA: 0x18B5448
	public Vector3 get_localPosition() { }

	// RVA: 0x18B5454
	private void set_localPosition(Vector3 value) { }

	// RVA: 0x18B5460
	public Vector3 get_deltaPosition() { }

	// RVA: 0x18B546C
	private void set_deltaPosition(Vector3 value) { }

	// RVA: 0x18B5478
	public float get_deltaTime() { }

	// RVA: 0x18B5480
	private void set_deltaTime(float value) { }

	// RVA: 0x18B5488
	public int get_clickCount() { }

	// RVA: 0x18B5490
	private void set_clickCount(int value) { }

	// RVA: 0x18B5498
	public float get_pressure() { }

	// RVA: 0x18B54A0
	private void set_pressure(float value) { }

	// RVA: 0x18B54A8
	public float get_tangentialPressure() { }

	// RVA: 0x18B54B0
	private void set_tangentialPressure(float value) { }

	// RVA: 0x18B54B8
	public float get_altitudeAngle() { }

	// RVA: 0x18B54C0
	private void set_altitudeAngle(float value) { }

	// RVA: 0x18B54C8
	public float get_azimuthAngle() { }

	// RVA: 0x18B54D0
	private void set_azimuthAngle(float value) { }

	// RVA: 0x18B54D8
	public float get_twist() { }

	// RVA: 0x18B54E0
	private void set_twist(float value) { }

	// RVA: 0x18B54E8
	public Vector2 get_tilt() { }

	// RVA: 0x18B54F0
	private void set_tilt(Vector2 value) { }

	// RVA: 0x18B54F8
	public PenStatus get_penStatus() { }

	// RVA: 0x18B5500
	private void set_penStatus(PenStatus value) { }

	// RVA: 0x18B5508
	public Vector2 get_radius() { }

	// RVA: 0x18B5510
	private void set_radius(Vector2 value) { }

	// RVA: 0x18B5518
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18B5520
	private void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18B5528
	public EventModifiers get_modifiers() { }

	// RVA: 0x18B5530
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x18B5538
	public bool get_shiftKey() { }

	// RVA: 0x18B5544
	public bool get_ctrlKey() { }

	// RVA: 0x18B5550
	public bool get_commandKey() { }

	// RVA: 0x18B555C
	public bool get_altKey() { }

	// RVA: 0x18B5568
	public bool get_actionKey() { }

	// RVA: 0x18B4DCC
	public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18B5308
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x18B53D0
	public void .ctor() { }

	// RVA: 0x18B5634
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

	// RVA: 0x18B256C
	public IPanel get_panel() { }

	// RVA: 0x18B2574
	public void set_panel(IPanel value) { }

	// RVA: 0x18B29B0
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18B29C8
	private EventSystem get_eventSystem() { }

	// RVA: 0x18B2AE8
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x18B2BDC
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x18B2C18
	protected override void OnEnable() { }

	// RVA: 0x18B2C20
	protected override void OnDisable() { }

	// RVA: 0x18B27F4
	private void RegisterCallbacks() { }

	// RVA: 0x18B2638
	private void UnregisterCallbacks() { }

	// RVA: 0x18B2C28
	private void OnPanelDestroyed() { }

	// RVA: 0x18B2C98
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x18B2EB8
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x18B2EBC
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18B2F3C
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18B2F50
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x18B32E0
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18B34FC
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18B3804
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18B3B48
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18B3BAC
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18B3BD4
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18B3FD0
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x18B41F8
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x18B4440
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18B3278
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x18B4630
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x18B4654
	internal void Update() { }

	// RVA: 0x18B46E4
	private void LateUpdate() { }

	// RVA: 0x18B3DFC
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x18B46EC
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x18B4780
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x18B4C10
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	// RVA: 0x18B47F8
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x18B4A04
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x18B30FC
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x18B5320
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PanelRaycaster
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Methods

	// RVA: 0x18B5648
	public IPanel get_panel() { }

	// RVA: 0x18B5650
	public void set_panel(IPanel value) { }

	// RVA: 0x18B588C
	private void RegisterCallbacks() { }

	// RVA: 0x18B57EC
	private void UnregisterCallbacks() { }

	// RVA: 0x18B592C
	private void OnPanelDestroyed() { }

	// RVA: 0x18B5934
	private GameObject get_selectableGameObject() { }

	// RVA: 0x18B594C
	public override int get_sortOrderPriority() { }

	// RVA: 0x18B59F4
	public override int get_renderOrderPriority() { }

	// RVA: 0x18B5A94
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x18B5F50
	public override Camera get_eventCamera() { }

	// RVA: 0x18B5F58
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class AxisEventData
{
	// Fields
	private Vector2 <moveVector>k__BackingField; // 0x20
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Methods

	// RVA: 0x18B5F68
	public Vector2 get_moveVector() { }

	// RVA: 0x18B5F70
	public void set_moveVector(Vector2 value) { }

	// RVA: 0x18B5F78
	public MoveDirection get_moveDir() { }

	// RVA: 0x18B5F80
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x18B5F88
	public void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData
{
	// Fields
	protected bool m_Used; // 0x10

	// Methods

	// RVA: 0x18B6034
	public virtual void Reset() { }

	// RVA: 0x18B603C
	public virtual void Use() { }

	// RVA: 0x18B6048
	public virtual bool get_used() { }

	// RVA: 0x18B6050
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseEventData
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Methods

	// RVA: 0x18B6000
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18B6058
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18B6078
	public GameObject get_selectedObject() { }

	// RVA: 0x18B6098
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

	// RVA: 0x18B6340
	public GameObject get_pointerEnter() { }

	// RVA: 0x18B6348
	public void set_pointerEnter(GameObject value) { }

	// RVA: 0x18B6350
	public GameObject get_lastPress() { }

	// RVA: 0x18B6358
	private void set_lastPress(GameObject value) { }

	// RVA: 0x18B6360
	public GameObject get_rawPointerPress() { }

	// RVA: 0x18B6368
	public void set_rawPointerPress(GameObject value) { }

	// RVA: 0x18B6370
	public GameObject get_pointerDrag() { }

	// RVA: 0x18B6378
	public void set_pointerDrag(GameObject value) { }

	// RVA: 0x18B6380
	public GameObject get_pointerClick() { }

	// RVA: 0x18B6388
	public void set_pointerClick(GameObject value) { }

	// RVA: 0x18B6390
	public RaycastResult get_pointerCurrentRaycast() { }

	// RVA: 0x18B63AC
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	// RVA: 0x18B63DC
	public RaycastResult get_pointerPressRaycast() { }

	// RVA: 0x18B63F8
	public void set_pointerPressRaycast(RaycastResult value) { }

	// RVA: 0x18B6428
	public bool get_eligibleForClick() { }

	// RVA: 0x18B6430
	public void set_eligibleForClick(bool value) { }

	// RVA: 0x18B6438
	public int get_displayIndex() { }

	// RVA: 0x18B6440
	public void set_displayIndex(int value) { }

	// RVA: 0x18B6448
	public int get_pointerId() { }

	// RVA: 0x18B6450
	public void set_pointerId(int value) { }

	// RVA: 0x18B6458
	public Vector2 get_position() { }

	// RVA: 0x18B6464
	public void set_position(Vector2 value) { }

	// RVA: 0x18B6470
	public Vector2 get_delta() { }

	// RVA: 0x18B647C
	public void set_delta(Vector2 value) { }

	// RVA: 0x18B6488
	public Vector2 get_pressPosition() { }

	// RVA: 0x18B6494
	public void set_pressPosition(Vector2 value) { }

	// RVA: 0x18B64A0
	public Vector3 get_worldPosition() { }

	// RVA: 0x18B64B0
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x18B64C0
	public Vector3 get_worldNormal() { }

	// RVA: 0x18B64D0
	public void set_worldNormal(Vector3 value) { }

	// RVA: 0x18B64E0
	public float get_clickTime() { }

	// RVA: 0x18B64E8
	public void set_clickTime(float value) { }

	// RVA: 0x18B64F0
	public int get_clickCount() { }

	// RVA: 0x18B64F8
	public void set_clickCount(int value) { }

	// RVA: 0x18B6500
	public Vector2 get_scrollDelta() { }

	// RVA: 0x18B650C
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x18B6518
	public bool get_useDragThreshold() { }

	// RVA: 0x18B6520
	public void set_useDragThreshold(bool value) { }

	// RVA: 0x18B6528
	public bool get_dragging() { }

	// RVA: 0x18B6530
	public void set_dragging(bool value) { }

	// RVA: 0x18B6538
	public InputButton get_button() { }

	// RVA: 0x18B6540
	public void set_button(InputButton value) { }

	// RVA: 0x18B6548
	public float get_pressure() { }

	// RVA: 0x18B6550
	public void set_pressure(float value) { }

	// RVA: 0x18B6558
	public float get_tangentialPressure() { }

	// RVA: 0x18B6560
	public void set_tangentialPressure(float value) { }

	// RVA: 0x18B6568
	public float get_altitudeAngle() { }

	// RVA: 0x18B6570
	public void set_altitudeAngle(float value) { }

	// RVA: 0x18B6578
	public float get_azimuthAngle() { }

	// RVA: 0x18B6580
	public void set_azimuthAngle(float value) { }

	// RVA: 0x18B6588
	public float get_twist() { }

	// RVA: 0x18B6590
	public void set_twist(float value) { }

	// RVA: 0x18B6598
	public Vector2 get_tilt() { }

	// RVA: 0x18B65A4
	public void set_tilt(Vector2 value) { }

	// RVA: 0x18B65B0
	public PenStatus get_penStatus() { }

	// RVA: 0x18B65B8
	public void set_penStatus(PenStatus value) { }

	// RVA: 0x18B65C0
	public Vector2 get_radius() { }

	// RVA: 0x18B65CC
	public void set_radius(Vector2 value) { }

	// RVA: 0x18B65D8
	public Vector2 get_radiusVariance() { }

	// RVA: 0x18B65E4
	public void set_radiusVariance(Vector2 value) { }

	// RVA: 0x18B65F0
	public bool get_fullyExited() { }

	// RVA: 0x18B65F8
	public void set_fullyExited(bool value) { }

	// RVA: 0x18B6600
	public bool get_reentered() { }

	// RVA: 0x18B6608
	public void set_reentered(bool value) { }

	// RVA: 0x18B6610
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x18B6750
	public bool IsPointerMoving() { }

	// RVA: 0x18B6770
	public bool IsScrolling() { }

	// RVA: 0x18B6790
	public Camera get_enterEventCamera() { }

	// RVA: 0x18B6854
	public Camera get_pressEventCamera() { }

	// RVA: 0x18B6918
	public GameObject get_pointerPress() { }

	// RVA: 0x18B6920
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x18B69FC
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

	// RVA: 0x18B9188
	public void .ctor() { }

	// RVA: 0x18B9CE8
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

	// RVA: 0x18B778C
	public static EventSystem get_current() { }

	// RVA: 0x18B7888
	public static void set_current(EventSystem value) { }

	// RVA: 0x18B7A60
	public bool get_sendNavigationEvents() { }

	// RVA: 0x18B7A68
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x18B7A70
	public int get_pixelDragThreshold() { }

	// RVA: 0x18B7A78
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x18B7A80
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x18B7A88
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x18B7A90
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x18B7A98
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x18B7AA0
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x18B7AA8
	public bool get_isFocused() { }

	// RVA: 0x18B7AB0
	protected void .ctor() { }

	// RVA: 0x18B7B50
	public void UpdateModules() { }

	// RVA: 0x18B7CC4
	public bool get_alreadySelecting() { }

	// RVA: 0x18B60B8
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x18B7CCC
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x18B2DF8
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x18B7D78
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x18B8274
	public void RaycastAll(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }

	// RVA: 0x18B84F4
	public bool IsPointerOverGameObject() { }

	// RVA: 0x18B85B8
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18B8680
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x18B87C0
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x18B885C
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x18B88F8
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart) { }

	// RVA: 0x18B8ACC
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x18B90D0
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x18B8E00
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x18B9190
	protected override void Start() { }

	// RVA: 0x18B91A0
	protected override void OnEnable() { }

	// RVA: 0x18B9328
	protected override void OnDisable() { }

	// RVA: 0x18B948C
	private void TickModules() { }

	// RVA: 0x18B95C0
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x18B95D0
	protected virtual void Update() { }

	// RVA: 0x18B98B8
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x18B9A28
	public override string ToString() { }

	// RVA: 0x18B9BA8
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class TriggerEvent
{
	// Methods

	// RVA: 0x18BA13C
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

	// RVA: 0x18BA190
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class EventTrigger
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates; // 0x20

	// Methods

	// RVA: 0x18B9D78
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }

	// RVA: 0x18B9EB0
	public void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18B9EB8
	protected void .ctor() { }

	// RVA: 0x18B9E14
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }

	// RVA: 0x18B9EC0
	public void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x18B9EC8
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x18BA070
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x18BA07C
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x18BA088
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18BA094
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x18BA0A0
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18BA0AC
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18BA0B8
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18BA0C4
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18BA0D0
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18BA0DC
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x18BA0E8
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x18BA0F4
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x18BA100
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18BA10C
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18BA118
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18BA124
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x18BA130
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

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }

	// RVA: 0x315B3A8
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x315B3A8
	public static T ValidateEventData(BaseEventData data) { }

	// RVA: 0x18BA23C
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA358
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA474
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA590
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA6AC
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA7C8
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BA8E4
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAA00
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAB1C
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAC38
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAD54
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAE70
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BAF8C
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB03C
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB0EC
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB19C
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB2B8
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB368
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x18BB418
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x18BB494
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x18BB510
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x18BB58C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x18BB608
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x18BB684
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x18BB700
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x18BB77C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x18BB7F8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }

	// RVA: 0x18BB874
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x18BB8F0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }

	// RVA: 0x18BB96C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }

	// RVA: 0x18BB9E8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x18BBA64
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }

	// RVA: 0x18BBAE0
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x18BBB5C
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }

	// RVA: 0x18BBBD8
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }

	// RVA: 0x18BBC54
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }

	// RVA: 0x18BBCD0
	private static void GetEventChain(GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }

	// RVA: 0x30A3D6C
	public static bool Execute(GameObject target, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }

	// RVA: 0x30A550C
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }

	// RVA: 0x30A3970
	private static bool ShouldSendToComponent(Component component) { }

	// RVA: 0x30A8E44
	private static void GetEventList(GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }

	// RVA: 0x30A3970
	public static bool CanHandleEvent(GameObject go) { }

	// RVA: 0x30A52D0
	public static GameObject GetEventHandler(GameObject root) { }

	// RVA: 0x18BBEB8
	private static void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseInput
{
	// Methods

	// RVA: 0x18BC5A0
	public virtual string get_compositionString() { }

	// RVA: 0x18BC5A8
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x18BC5B0
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x18BC5BC
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x18BC5C4
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x18BC5CC
	public virtual bool get_mousePresent() { }

	// RVA: 0x18BC5D4
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x18BC5E0
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x18BC5EC
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x18BC5F8
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x18BC600
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x18BC608
	public virtual bool get_touchSupported() { }

	// RVA: 0x18BC610
	public virtual int get_touchCount() { }

	// RVA: 0x18BC618
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x18BC66C
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x18BC678
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x18BC684
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

	// RVA: 0x18BC68C
	internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x18BC694
	internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x18BC69C
	public BaseInput get_input() { }

	// RVA: 0x18BC934
	public BaseInput get_inputOverride() { }

	// RVA: 0x18BC93C
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x18BC944
	protected EventSystem get_eventSystem() { }

	// RVA: 0x18BC94C
	protected override void OnEnable() { }

	// RVA: 0x18BC9D0
	protected override void OnDisable() { }

	// RVA: -1
	public abstract void Process() { }

	// RVA: 0x18BC9EC
	protected static RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }

	// RVA: 0x18BCB14
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x18BCB68
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x18BCBB4
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x18BCDAC
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x18BDA68
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x18BDBC0
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x18BDC6C
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18BDC74
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x18BDCC0
	public virtual void DeactivateModule() { }

	// RVA: 0x18BDCC4
	public virtual void ActivateModule() { }

	// RVA: 0x18BDCC8
	public virtual void UpdateModule() { }

	// RVA: 0x18BDCCC
	public virtual bool IsModuleSupported() { }

	// RVA: 0x18BDCD4
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x18BDD80
	protected void .ctor() { }

}

// Namespace: 
protected class ButtonState
{
	// Fields
	private InputButton m_Button; // 0x10
	private MouseButtonEventData m_EventData; // 0x18

	// Methods

	// RVA: 0x18BFA48
	public MouseButtonEventData get_eventData() { }

	// RVA: 0x18BFA50
	public void set_eventData(MouseButtonEventData value) { }

	// RVA: 0x18BFA58
	public InputButton get_button() { }

	// RVA: 0x18BFA60
	public void set_button(InputButton value) { }

	// RVA: 0x18BFA68
	public void .ctor() { }

}

// Namespace: 
protected class MouseState
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x18BFA70
	public bool AnyPressesThisFrame() { }

	// RVA: 0x18BFB5C
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x18BFC50
	public ButtonState GetButtonState(InputButton button) { }

	// RVA: 0x18BE998
	public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x18BF9BC
	public void .ctor() { }

}

// Namespace: 
public class MouseButtonEventData
{
	// Fields
	public FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x18BFB4C
	public bool PressedThisFrame() { }

	// RVA: 0x18BFC3C
	public bool ReleasedThisFrame() { }

	// RVA: 0x18BFDC8
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

	// RVA: 0x18BDE14
	protected bool GetPointerData(int id, PointerEventData data, bool create) { }

	// RVA: 0x18BDF20
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x18BDF9C
	protected PointerEventData GetTouchPointerEventData(Touch input, bool pressed, bool released) { }

	// RVA: 0x18BE37C
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x18BE448
	protected FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x18BE4D0
	protected virtual MouseState GetMousePointerEventData() { }

	// RVA: 0x18BE4E4
	protected virtual MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x18BE9D8
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x18BEA70
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x18BEAA0
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x18BEAE8
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x18BEEF0
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x18BF008
	protected void ClearSelection() { }

	// RVA: 0x18BF244
	public override string ToString() { }

	// RVA: 0x18BF6E8
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x18BF824
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

	// RVA: 0x18BFDD0
	protected void .ctor() { }

	// RVA: 0x18BFEB0
	public InputMode get_inputMode() { }

	// RVA: 0x18BFEB8
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x18BFEC0
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x18BFEC8
	public bool get_forceModuleActive() { }

	// RVA: 0x18BFED0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18BFED8
	public float get_inputActionsPerSecond() { }

	// RVA: 0x18BFEE0
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x18BFEE8
	public float get_repeatDelay() { }

	// RVA: 0x18BFEF0
	public void set_repeatDelay(float value) { }

	// RVA: 0x18BFEF8
	public string get_horizontalAxis() { }

	// RVA: 0x18BFF00
	public void set_horizontalAxis(string value) { }

	// RVA: 0x18BFF08
	public string get_verticalAxis() { }

	// RVA: 0x18BFF10
	public void set_verticalAxis(string value) { }

	// RVA: 0x18BFF18
	public string get_submitButton() { }

	// RVA: 0x18BFF20
	public void set_submitButton(string value) { }

	// RVA: 0x18BFF28
	public string get_cancelButton() { }

	// RVA: 0x18BFF30
	public void set_cancelButton(string value) { }

	// RVA: 0x18BFF38
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x18BFF40
	public override void UpdateModule() { }

	// RVA: 0x18C004C
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x18C0544
	public override bool ShouldActivateModule() { }

	// RVA: 0x18C07A0
	public override void ActivateModule() { }

	// RVA: 0x18C08CC
	public override void DeactivateModule() { }

	// RVA: 0x18C08D0
	public override void Process() { }

	// RVA: 0x18C0AF0
	private bool ProcessTouchEvents() { }

	// RVA: 0x18C11E4
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18C0F74
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x18C1BB8
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x18C0CC0
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x18C0CB8
	protected void ProcessMouseEvent() { }

	// RVA: 0x18C1F98
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x18C1CC8
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x18C0974
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x18C1FA0
	protected void ProcessMousePress(MouseButtonEventData data) { }

	// RVA: 0x18C2498
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

	// RVA: 0x18C24A0
	protected void .ctor() { }

	// RVA: 0x18C24A4
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x18C24AC
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x18C24B4
	public bool get_forceModuleActive() { }

	// RVA: 0x18C24BC
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x18C24C4
	public override void UpdateModule() { }

	// RVA: 0x18C2664
	public override bool IsModuleSupported() { }

	// RVA: 0x18C26A0
	public override bool ShouldActivateModule() { }

	// RVA: 0x18C2784
	private bool UseFakeInput() { }

	// RVA: 0x18C27B4
	public override void Process() { }

	// RVA: 0x18C2804
	private void FakeTouches() { }

	// RVA: 0x18C2930
	private void ProcessTouchEvents() { }

	// RVA: 0x18C2AD8
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x18C3498
	public override void DeactivateModule() { }

	// RVA: 0x18C349C
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

	// RVA: 0x18C37E0
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18C38DC
	public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }

	// RVA: 0x18C3958
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x18C3A54
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

	// RVA: 0x18C3AF0
	public virtual int get_priority() { }

	// RVA: 0x18C3AF8
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x18C3B00
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x18B8168
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x18C3B08
	public override string ToString() { }

	// RVA: 0x18C3D78
	protected override void OnEnable() { }

	// RVA: 0x18C3DF8
	protected override void OnDisable() { }

	// RVA: 0x18C3E78
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18C3E88
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18B5F60
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class Physics2DRaycaster
{
	// Methods

	// RVA: 0x18C3E98
	protected void .ctor() { }

	// RVA: 0x18C3F00
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: 
private class RaycastHitComparer
{
	// Fields
	public static RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x18C48FC
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x18C4948
	public void .ctor() { }

	// RVA: 0x18C4950
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

	// RVA: 0x18C3ECC
	protected void .ctor() { }

	// RVA: 0x18C3F04
	public override Camera get_eventCamera() { }

	// RVA: 0x18C404C
	public virtual int get_depth() { }

	// RVA: 0x18C4138
	public int get_finalEventMask() { }

	// RVA: 0x18C4220
	public LayerMask get_eventMask() { }

	// RVA: 0x18C4228
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x18C4230
	public int get_maxRayIntersections() { }

	// RVA: 0x18C4238
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x18C4240
	protected bool ComputeRayAndDistance(PointerEventData eventData, Ray ray, int eventDisplayIndex, float distanceToClipPlane) { }

	// RVA: 0x18C4548
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

	// RVA: 0x18C49BC
	public GameObject get_gameObject() { }

	// RVA: 0x18C49C4
	public void set_gameObject(GameObject value) { }

	// RVA: 0x18C49CC
	public bool get_isValid() { }

	// RVA: 0x18C4A94
	public void Clear() { }

	// RVA: 0x18B7110
	public override string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour
{
	// Methods

	// RVA: 0x18C4B60
	protected virtual void Awake() { }

	// RVA: 0x18B2C1C
	protected virtual void OnEnable() { }

	// RVA: 0x18B919C
	protected virtual void Start() { }

	// RVA: 0x18B2C24
	protected virtual void OnDisable() { }

	// RVA: 0x18C4B64
	protected virtual void OnDestroy() { }

	// RVA: 0x18C4B68
	public virtual bool IsActive() { }

	// RVA: 0x18C4B70
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x18C4B74
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x18C3E94
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x18C4B78
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x18C4B7C
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x18C3E84
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x18C4B80
	public bool IsDestroyed() { }

	// RVA: 0x18B53D8
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


