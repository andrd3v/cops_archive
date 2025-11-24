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

	// RVA: 0x17DF24C
	private static MonoScriptData Get() { }

	// RVA: 0x17DF350
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

	// RVA: 0x17DF358
	public string get_normalTrigger() { }

	// RVA: 0x17DF360
	public void set_normalTrigger(string value) { }

	// RVA: 0x17DF368
	public string get_highlightedTrigger() { }

	// RVA: 0x17DF370
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x17DF378
	public string get_pressedTrigger() { }

	// RVA: 0x17DF380
	public void set_pressedTrigger(string value) { }

	// RVA: 0x17DF388
	public string get_selectedTrigger() { }

	// RVA: 0x17DF390
	public void set_selectedTrigger(string value) { }

	// RVA: 0x17DF398
	public string get_disabledTrigger() { }

	// RVA: 0x17DF3A0
	public void set_disabledTrigger(string value) { }

	// RVA: 0x17DF3A8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ButtonClickedEvent
{
	// Methods

	// RVA: 0x17DF560
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

	// RVA: 0x17DF88C
	public void .ctor(int <>1__state) { }

	// RVA: 0x17DF8B8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17DF8BC
	private bool MoveNext() { }

	// RVA: 0x17DF9D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17DF9D8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17DFA18
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI
public class Button
{
	// Fields
	private ButtonClickedEvent m_OnClick; // 0x100

	// Methods

	// RVA: 0x17DF4AC
	protected void .ctor() { }

	// RVA: 0x17DF568
	public ButtonClickedEvent get_onClick() { }

	// RVA: 0x17DF570
	public void set_onClick(ButtonClickedEvent value) { }

	// RVA: 0x17DF580
	private void Press() { }

	// RVA: 0x17DF61C
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17DF6C4
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x17DF814
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

	// RVA: 0x17DFA20
	protected void .ctor() { }

	// RVA: 0x17DFC64
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x17DFD4C
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x17DFE50
	private void CleanInvalidItems() { }

	// RVA: 0x17E0164
	private void PerformUpdate() { }

	// RVA: 0x17E0D68
	private static int ParentCount(Transform child) { }

	// RVA: 0x17E0E4C
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x17E0FB0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x17E1154
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x17E10AC
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x17E1254
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x17E13B0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x17E12D4
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x17E1430
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x17E17D4
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x17E14C4
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x17E164C
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x17E1868
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x17E19F0
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x17E1B78
	public static bool IsRebuildingLayout() { }

	// RVA: 0x17E1BEC
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x17E1C60
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

	// RVA: 0x17E1CFC
	public Color get_normalColor() { }

	// RVA: 0x17E1D08
	public void set_normalColor(Color value) { }

	// RVA: 0x17E1D14
	public Color get_highlightedColor() { }

	// RVA: 0x17E1D20
	public void set_highlightedColor(Color value) { }

	// RVA: 0x17E1D2C
	public Color get_pressedColor() { }

	// RVA: 0x17E1D38
	public void set_pressedColor(Color value) { }

	// RVA: 0x17E1D44
	public Color get_selectedColor() { }

	// RVA: 0x17E1D50
	public void set_selectedColor(Color value) { }

	// RVA: 0x17E1D5C
	public Color get_disabledColor() { }

	// RVA: 0x17E1D68
	public void set_disabledColor(Color value) { }

	// RVA: 0x17E1D74
	public float get_colorMultiplier() { }

	// RVA: 0x17E1D7C
	public void set_colorMultiplier(float value) { }

	// RVA: 0x17E1D84
	public float get_fadeDuration() { }

	// RVA: 0x17E1D8C
	public void set_fadeDuration(float value) { }

	// RVA: 0x17E1D94
	private static void .cctor() { }

	// RVA: 0x17E1E10
	public override bool Equals(object obj) { }

	// RVA: 0x17E1F08
	public bool Equals(ColorBlock other) { }

	// RVA: 0x17E213C
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x17E21F0
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x17E22A8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UI
public class ClipperRegistry
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers; // 0x10

	// Methods

	// RVA: 0x17E2330
	protected void .ctor() { }

	// RVA: 0x17E0B08
	public static ClipperRegistry get_instance() { }

	// RVA: 0x17E0C30
	public void Cull() { }

	// RVA: 0x17E23BC
	public static void Register(IClipper c) { }

	// RVA: 0x17E2430
	public static void Unregister(IClipper c) { }

	// RVA: 0x17E2490
	public static void Disable(IClipper c) { }

}

// Namespace: UnityEngine.UI
public static class Clipping
{
	// Methods

	// RVA: 0x17E24F0
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

	// RVA: 0x17E26FC
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x17E2920
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

	// RVA: 0x17E7E04
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x17E7E74
	public void .ctor() { }

	// RVA: 0x17E7E7C
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

	// RVA: 0x17E29AC
	public static IFactoryControls get_factory() { }

	// RVA: 0x17E2A28
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x17E2BE8
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x17E2E84
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x17E2F90
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x17E2D4C
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x17E2FF4
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x17E30E8
	public static GameObject CreatePanel(Resources resources) { }

	// RVA: 0x17E3884
	public static GameObject CreateButton(Resources resources) { }

	// RVA: 0x17E3D38
	public static GameObject CreateText(Resources resources) { }

	// RVA: 0x17E3EE8
	public static GameObject CreateImage(Resources resources) { }

	// RVA: 0x17E4024
	public static GameObject CreateRawImage(Resources resources) { }

	// RVA: 0x17E4160
	public static GameObject CreateSlider(Resources resources) { }

	// RVA: 0x17E4964
	public static GameObject CreateScrollbar(Resources resources) { }

	// RVA: 0x17E4EF0
	public static GameObject CreateToggle(Resources resources) { }

	// RVA: 0x17E557C
	public static GameObject CreateInputField(Resources resources) { }

	// RVA: 0x17E5C60
	public static GameObject CreateDropdown(Resources resources) { }

	// RVA: 0x17E7354
	public static GameObject CreateScrollView(Resources resources) { }

	// RVA: 0x17E7D40
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

	// RVA: 0x17EB548
	public Text get_text() { }

	// RVA: 0x17EB550
	public void set_text(Text value) { }

	// RVA: 0x17EB558
	public Image get_image() { }

	// RVA: 0x17EB560
	public void set_image(Image value) { }

	// RVA: 0x17EB568
	public RectTransform get_rectTransform() { }

	// RVA: 0x17EB570
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x17EB578
	public Toggle get_toggle() { }

	// RVA: 0x17EB580
	public void set_toggle(Toggle value) { }

	// RVA: 0x17EB588
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x17EB610
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x17EB6E0
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

	// RVA: 0x17EB6E8
	public string get_text() { }

	// RVA: 0x17EB6F0
	public void set_text(string value) { }

	// RVA: 0x17EB6F8
	public Sprite get_image() { }

	// RVA: 0x17EB700
	public void set_image(Sprite value) { }

	// RVA: 0x17E70FC
	public void .ctor() { }

	// RVA: 0x17E8A70
	public void .ctor(string text) { }

	// RVA: 0x17E8BD0
	public void .ctor(Sprite image) { }

	// RVA: 0x17EB708
	public void .ctor(string text, Sprite image) { }

}

// Namespace: 
[Serializable]
public class OptionDataList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options; // 0x10

	// Methods

	// RVA: 0x17EB758
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x17EB760
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x17E8318
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class DropdownEvent
{
	// Methods

	// RVA: 0x17E83A4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass63_0
{
	// Fields
	public DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x17EA554
	public void .ctor() { }

	// RVA: 0x17EB768
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

	// RVA: 0x17EB35C
	public void .ctor(int <>1__state) { }

	// RVA: 0x17EB790
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17EB794
	private bool MoveNext() { }

	// RVA: 0x17EB858
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x17EB860
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17EB8A0
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

	// RVA: 0x17E7EE8
	public RectTransform get_template() { }

	// RVA: 0x17E7058
	public void set_template(RectTransform value) { }

	// RVA: 0x17E7EF0
	public Text get_captionText() { }

	// RVA: 0x17E7084
	public void set_captionText(Text value) { }

	// RVA: 0x17E7EF8
	public Image get_captionImage() { }

	// RVA: 0x17E7F00
	public void set_captionImage(Image value) { }

	// RVA: 0x17E7F2C
	public Text get_itemText() { }

	// RVA: 0x17E70B0
	public void set_itemText(Text value) { }

	// RVA: 0x17E7F34
	public Image get_itemImage() { }

	// RVA: 0x17E7F3C
	public void set_itemImage(Image value) { }

	// RVA: 0x17E70DC
	public System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options() { }

	// RVA: 0x17E7F68
	public void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value) { }

	// RVA: 0x17E7F9C
	public DropdownEvent get_onValueChanged() { }

	// RVA: 0x17E7FA4
	public void set_onValueChanged(DropdownEvent value) { }

	// RVA: 0x17E7FB4
	public float get_alphaFadeSpeed() { }

	// RVA: 0x17E7FBC
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x17E7FC4
	public int get_value() { }

	// RVA: 0x17E7FCC
	public void set_value(int value) { }

	// RVA: 0x17E8144
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x17E7FD4
	private void Set(int value, bool sendCallback) { }

	// RVA: 0x17E814C
	protected void .ctor() { }

	// RVA: 0x17E83F8
	protected override void Awake() { }

	// RVA: 0x17E8538
	protected override void Start() { }

	// RVA: 0x17E85F0
	protected override void OnDisable() { }

	// RVA: 0x17E7104
	public void RefreshShownValue() { }

	// RVA: 0x17E88D0
	public void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options) { }

	// RVA: 0x17E8944
	public void AddOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x17E8AA4
	public void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options) { }

	// RVA: 0x17E8C04
	public void ClearOptions() { }

	// RVA: 0x17E8CC0
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: 0x26AD93C
	private static T GetOrAddComponent(GameObject go) { }

	// RVA: 0x17E9404
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x17EA33C
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x17EA340
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x17E9408
	public void Show() { }

	// RVA: 0x17EA980
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x17EAEE4
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x17EAF6C
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x17EB010
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x17EB098
	protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) { }

	// RVA: 0x17EB13C
	protected virtual void DestroyItem(DropdownItem item) { }

	// RVA: 0x17EA55C
	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items) { }

	// RVA: 0x17EB140
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x17EA874
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x17EB1D8
	private void SetAlpha(float alpha) { }

	// RVA: 0x17EA344
	public void Hide() { }

	// RVA: 0x17EB2D4
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x17E86B8
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x17EB388
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x17EB4C0
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

	// RVA: 0x17EB8A8
	public static FontData get_defaultFontData() { }

	// RVA: 0x17EB944
	public Font get_font() { }

	// RVA: 0x17EB94C
	public void set_font(Font value) { }

	// RVA: 0x17EB954
	public int get_fontSize() { }

	// RVA: 0x17EB95C
	public void set_fontSize(int value) { }

	// RVA: 0x17EB964
	public FontStyle get_fontStyle() { }

	// RVA: 0x17EB96C
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x17EB974
	public bool get_bestFit() { }

	// RVA: 0x17EB97C
	public void set_bestFit(bool value) { }

	// RVA: 0x17EB984
	public int get_minSize() { }

	// RVA: 0x17EB98C
	public void set_minSize(int value) { }

	// RVA: 0x17EB994
	public int get_maxSize() { }

	// RVA: 0x17EB99C
	public void set_maxSize(int value) { }

	// RVA: 0x17EB9A4
	public TextAnchor get_alignment() { }

	// RVA: 0x17EB9AC
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x17EB9B4
	public bool get_alignByGeometry() { }

	// RVA: 0x17EB9BC
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x17EB9C4
	public bool get_richText() { }

	// RVA: 0x17EB9CC
	public void set_richText(bool value) { }

	// RVA: 0x17EB9D4
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x17EB9DC
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x17EB9E4
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x17EB9EC
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x17EB9F4
	public float get_lineSpacing() { }

	// RVA: 0x17EB9FC
	public void set_lineSpacing(float value) { }

	// RVA: 0x17EBA04
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x17EBA08
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x17EB93C
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Font,System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x17EBA4C
	public static void TrackText(Text t) { }

	// RVA: 0x17EBCC4
	private static void RebuildForFont(Font f) { }

	// RVA: 0x17EBF00
	public static void UntrackText(Text t) { }

	// RVA: 0x17EC138
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

	// RVA: 0x17EC1D4
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x17EC324
	public virtual Color get_color() { }

	// RVA: 0x17EC330
	public virtual void set_color(Color value) { }

	// RVA: 0x17EC378
	public virtual bool get_raycastTarget() { }

	// RVA: 0x17EC380
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x17ECA64
	public Vector4 get_raycastPadding() { }

	// RVA: 0x17ECA70
	public void set_raycastPadding(Vector4 value) { }

	// RVA: 0x17ECA7C
	protected bool get_useLegacyMeshGeneration() { }

	// RVA: 0x17ECA84
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x17ECA8C
	protected void .ctor() { }

	// RVA: 0x17ECB64
	public virtual void SetAllDirty() { }

	// RVA: 0x17ECDFC
	public virtual void SetLayoutDirty() { }

	// RVA: 0x17ECFC0
	public virtual void SetVerticesDirty() { }

	// RVA: 0x17ED0C0
	public virtual void SetMaterialDirty() { }

	// RVA: 0x17ECBE4
	public void SetRaycastDirty() { }

	// RVA: 0x17ED1C0
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x17ED2D0
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x17ED698
	protected override void OnTransformParentChanged() { }

	// RVA: 0x17EDBC0
	public int get_depth() { }

	// RVA: 0x17ECF28
	public RectTransform get_rectTransform() { }

	// RVA: 0x17EC57C
	public Canvas get_canvas() { }

	// RVA: 0x17ED7B8
	private void CacheCanvas() { }

	// RVA: 0x17EDBE0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x17EDCB4
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x17EDD1C
	public virtual Material get_material() { }

	// RVA: 0x17EDDD8
	public virtual void set_material(Material value) { }

	// RVA: 0x17EDEB8
	public virtual Material get_materialForRendering() { }

	// RVA: 0x17EE09C
	public virtual Texture get_mainTexture() { }

	// RVA: 0x17EE118
	protected override void OnEnable() { }

	// RVA: 0x17EE2F4
	protected override void OnDisable() { }

	// RVA: 0x17EE750
	protected override void OnDestroy() { }

	// RVA: 0x17EE924
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17EEB14
	public virtual void OnCullingChanged() { }

	// RVA: 0x17EEC08
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x17EED28
	public virtual void LayoutComplete() { }

	// RVA: 0x17EED2C
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x17EED30
	protected virtual void UpdateMaterial() { }

	// RVA: 0x17EEDEC
	protected virtual void UpdateGeometry() { }

	// RVA: 0x17EF278
	private void DoMeshGeneration() { }

	// RVA: 0x17EEDFC
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x17EF758
	protected static Mesh get_workerMesh() { }

	// RVA: 0x17EF8F0
	protected virtual void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo) { }

	// RVA: 0x17EF8F4
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x17EF990
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x17EFF84
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x17EFF94
	public virtual void SetNativeSize() { }

	// RVA: 0x17EFF98
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x17EFFA0
	protected bool Raycast(Vector2 sp, Camera eventCamera, bool ignoreMasks) { }

	// RVA: 0x17F05A0
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x17EFAF0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x17F0970
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x17F0984
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x17F0BF4
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x17F0C08
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x17F0CA8
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x17F0D5C
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x17F0E10
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x17F0EC4
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x17F0F78
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x17F102C
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x17F10E0
	private static void .cctor() { }

	// RVA: 0x17F1190
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

	// RVA: 0x17F27A8
	private static void .cctor() { }

	// RVA: 0x17F2814
	public void .ctor() { }

	// RVA: 0x17F281C
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

	// RVA: 0x17F1198
	public override int get_sortOrderPriority() { }

	// RVA: 0x17F12E8
	public override int get_renderOrderPriority() { }

	// RVA: 0x17F134C
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x17F1354
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x17F135C
	public BlockingObjects get_blockingObjects() { }

	// RVA: 0x17F1364
	public void set_blockingObjects(BlockingObjects value) { }

	// RVA: 0x17F136C
	public LayerMask get_blockingMask() { }

	// RVA: 0x17F1374
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x17F137C
	protected void .ctor() { }

	// RVA: 0x17F11F0
	private Canvas get_canvas() { }

	// RVA: 0x17F1420
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x17F2638
	public override Camera get_eventCamera() { }

	// RVA: 0x17F1FD8
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results) { }

	// RVA: 0x17F270C
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

	// RVA: 0x17F2888
	protected void .ctor() { }

	// RVA: 0x17F2A4C
	public static GraphicRegistry get_instance() { }

	// RVA: 0x17ED978
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17EC80C
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17ED498
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17EC634
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17EE57C
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17F2B34
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x17F2CF8
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x17F1EF4
	public static System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x17F2DDC
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

	// RVA: 0x17F2E70
	public Sprite get_sprite() { }

	// RVA: 0x17E340C
	public void set_sprite(Sprite value) { }

	// RVA: 0x17F3108
	public void DisableSpriteOptimizations() { }

	// RVA: 0x17F3110
	public Sprite get_overrideSprite() { }

	// RVA: 0x17F3218
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x17F3194
	private Sprite get_activeSprite() { }

	// RVA: 0x17F32A4
	public Type get_type() { }

	// RVA: 0x17E37D4
	public void set_type(Type value) { }

	// RVA: 0x17F32AC
	public bool get_preserveAspect() { }

	// RVA: 0x17F32B4
	public void set_preserveAspect(bool value) { }

	// RVA: 0x17F3364
	public bool get_fillCenter() { }

	// RVA: 0x17F336C
	public void set_fillCenter(bool value) { }

	// RVA: 0x17F341C
	public FillMethod get_fillMethod() { }

	// RVA: 0x17F3424
	public void set_fillMethod(FillMethod value) { }

	// RVA: 0x17F34D8
	public float get_fillAmount() { }

	// RVA: 0x17F34E0
	public void set_fillAmount(float value) { }

	// RVA: 0x17F3584
	public bool get_fillClockwise() { }

	// RVA: 0x17F358C
	public void set_fillClockwise(bool value) { }

	// RVA: 0x17F363C
	public int get_fillOrigin() { }

	// RVA: 0x17F3644
	public void set_fillOrigin(int value) { }

	// RVA: 0x17F36F4
	public float get_eventAlphaThreshold() { }

	// RVA: 0x17F3704
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x17F3880
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x17F3710
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x17F3888
	public bool get_useSpriteMesh() { }

	// RVA: 0x17F3890
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x17F3940
	protected void .ctor() { }

	// RVA: 0x17F398C
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x17F3ADC
	public override Texture get_mainTexture() { }

	// RVA: 0x17F3D70
	public bool get_hasBorder() { }

	// RVA: 0x17F3F1C
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x17F3F24
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x17F3F4C
	public float get_pixelsPerUnit() { }

	// RVA: 0x17F421C
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x17F4244
	public override Material get_material() { }

	// RVA: 0x17F4484
	public override void set_material(Material value) { }

	// RVA: 0x17F4564
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x17F4568
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x17F45BC
	private void PreserveSpriteAspectRatio(Rect rect, Vector2 spriteSize) { }

	// RVA: 0x17F4720
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x17F4CF0
	public override void SetNativeSize() { }

	// RVA: 0x17F5040
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x17F2F0C
	private void TrackSprite() { }

	// RVA: 0x17F8100
	protected override void OnEnable() { }

	// RVA: 0x17F8128
	protected override void OnDisable() { }

	// RVA: 0x17F82D0
	protected override void UpdateMaterial() { }

	// RVA: 0x17F84AC
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x17F520C
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x17F5588
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x17F5AEC
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x17F6360
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x17F89D4
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x17F8874
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x17F8748
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x17F7490
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x17F8B4C
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x17F8C9C
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x17F90A4
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x17F90A8
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x17F90AC
	public virtual float get_minWidth() { }

	// RVA: 0x17F90B4
	public virtual float get_preferredWidth() { }

	// RVA: 0x17F92C8
	public virtual float get_flexibleWidth() { }

	// RVA: 0x17F92D0
	public virtual float get_minHeight() { }

	// RVA: 0x17F92D8
	public virtual float get_preferredHeight() { }

	// RVA: 0x17F94EC
	public virtual float get_flexibleHeight() { }

	// RVA: 0x17F94F4
	public virtual int get_layoutPriority() { }

	// RVA: 0x17F94FC
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x17F9B50
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x17F9EAC
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x17F7FA4
	private static void TrackImage(Image g) { }

	// RVA: 0x17F822C
	private static void UnTrackImage(Image g) { }

	// RVA: 0x17FA154
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x17FA198
	private static void .cctor() { }

	// RVA: 0x17F2E78
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	// RVA: 0x17FA2F8
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

	// RVA: 0x1A0E768
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1A10C
	public virtual Char Invoke(string text, int charIndex, Char addedChar) { }

	// RVA: 0x1A1A120
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, Char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x1A1A1CC
	public virtual Char EndInvoke(IAsyncResult result) { }

}

// Namespace: 
[Serializable]
public class SubmitEvent
{
	// Methods

	// RVA: 0x1A0DE2C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class EndEditEvent
{
	// Methods

	// RVA: 0x1A0DE80
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class OnChangeEvent
{
	// Methods

	// RVA: 0x1A0DED4
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

	// RVA: 0x1A10E64
	public void .ctor(int <>1__state) { }

	// RVA: 0x1A1A1F8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A1A1FC
	private bool MoveNext() { }

	// RVA: 0x1A1A384
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1A1A38C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1A1A3CC
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

	// RVA: 0x1A14020
	public void .ctor(int <>1__state) { }

	// RVA: 0x1A1A3D4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A1A3D8
	private bool MoveNext() { }

	// RVA: 0x1A1A678
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1A1A680
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1A1A6C0
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

	// RVA: 0x1A0D9B8
	private BaseInput get_input() { }

	// RVA: 0x1A0DB20
	private string get_compositionString() { }

	// RVA: 0x1A0DBDC
	protected void .ctor() { }

	// RVA: 0x1A0E010
	protected Mesh get_mesh() { }

	// RVA: 0x1A0E100
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1A0E18C
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1A0E1F8
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1A0E2C0
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1A0E2C8
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1A0E344
	public string get_text() { }

	// RVA: 0x1A0E34C
	public void set_text(string value) { }

	// RVA: 0x1A0E760
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1A0E354
	private void SetText(string value, bool sendCallback) { }

	// RVA: 0x1A0EE18
	public bool get_isFocused() { }

	// RVA: 0x1A0EE20
	public float get_caretBlinkRate() { }

	// RVA: 0x1A0EE28
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1A0EF88
	public int get_caretWidth() { }

	// RVA: 0x1A0EF90
	public void set_caretWidth(int value) { }

	// RVA: 0x1A0F0F8
	public Text get_textComponent() { }

	// RVA: 0x1A0F100
	public void set_textComponent(Text value) { }

	// RVA: 0x1A0F3A4
	public Graphic get_placeholder() { }

	// RVA: 0x1A0F3AC
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1A0F408
	public Color get_caretColor() { }

	// RVA: 0x1A0F454
	public void set_caretColor(Color value) { }

	// RVA: 0x1A0F4FC
	public bool get_customCaretColor() { }

	// RVA: 0x1A0F504
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1A0F5AC
	public Color get_selectionColor() { }

	// RVA: 0x1A0F5C0
	public void set_selectionColor(Color value) { }

	// RVA: 0x1A0F668
	public EndEditEvent get_onEndEdit() { }

	// RVA: 0x1A0F670
	public void set_onEndEdit(EndEditEvent value) { }

	// RVA: 0x1A0F6CC
	public SubmitEvent get_onSubmit() { }

	// RVA: 0x1A0F6D4
	public void set_onSubmit(SubmitEvent value) { }

	// RVA: 0x1A0F730
	public OnChangeEvent get_onValueChange() { }

	// RVA: 0x1A0F738
	public void set_onValueChange(OnChangeEvent value) { }

	// RVA: 0x1A0F7F0
	public OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1A0F794
	public void set_onValueChanged(OnChangeEvent value) { }

	// RVA: 0x1A0F7F8
	public OnValidateInput get_onValidateInput() { }

	// RVA: 0x1A0F800
	public void set_onValidateInput(OnValidateInput value) { }

	// RVA: 0x1A0F85C
	public int get_characterLimit() { }

	// RVA: 0x1A0F864
	public void set_characterLimit(int value) { }

	// RVA: 0x1A0F930
	public ContentType get_contentType() { }

	// RVA: 0x1A0F938
	public void set_contentType(ContentType value) { }

	// RVA: 0x1A0FB50
	public LineType get_lineType() { }

	// RVA: 0x1A0FB58
	public void set_lineType(LineType value) { }

	// RVA: 0x1A0FD9C
	public InputType get_inputType() { }

	// RVA: 0x1A0FDA4
	public void set_inputType(InputType value) { }

	// RVA: 0x1A0FF9C
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1A0FFA4
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1A0FFAC
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1A10050
	public CharacterValidation get_characterValidation() { }

	// RVA: 0x1A10058
	public void set_characterValidation(CharacterValidation value) { }

	// RVA: 0x1A100FC
	public bool get_readOnly() { }

	// RVA: 0x1A10104
	public void set_readOnly(bool value) { }

	// RVA: 0x1A1010C
	public bool get_multiLine() { }

	// RVA: 0x1A10120
	public Char get_asteriskChar() { }

	// RVA: 0x1A10128
	public void set_asteriskChar(Char value) { }

	// RVA: 0x1A101CC
	public bool get_wasCanceled() { }

	// RVA: 0x1A101D4
	protected void ClampPos(int pos) { }

	// RVA: 0x1A10214
	protected int get_caretPositionInternal() { }

	// RVA: 0x1A10244
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1A10284
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1A102B4
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1A102F4
	private bool get_hasSelection() { }

	// RVA: 0x1A1034C
	public int get_caretPosition() { }

	// RVA: 0x1A1037C
	public void set_caretPosition(int value) { }

	// RVA: 0x1A10510
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1A10428
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1A10540
	public int get_selectionFocusPosition() { }

	// RVA: 0x1A1049C
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1A10570
	protected override void OnEnable() { }

	// RVA: 0x1A1080C
	protected override void OnDisable() { }

	// RVA: 0x1A10D7C
	protected override void OnDestroy() { }

	// RVA: 0x1A10DEC
	private IEnumerator CaretBlink() { }

	// RVA: 0x1A10E90
	private void SetCaretVisible() { }

	// RVA: 0x1A0EEB0
	private void SetCaretActive() { }

	// RVA: 0x1A10ED8
	private void UpdateCaretMaterial() { }

	// RVA: 0x1A11034
	protected void OnFocus() { }

	// RVA: 0x1A11078
	protected void SelectAll() { }

	// RVA: 0x1A110BC
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1A11154
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1A11224
	private static string get_clipboard() { }

	// RVA: 0x1A11294
	private static void set_clipboard(string value) { }

	// RVA: 0x1A1131C
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x1A11400
	private bool InPlaceEditing() { }

	// RVA: 0x1A11444
	private bool InPlaceEditingChanged() { }

	// RVA: 0x1A114F0
	private RangeInt GetInternalSelection() { }

	// RVA: 0x1A11600
	private void UpdateKeyboardCaret() { }

	// RVA: 0x1A116F0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x1A11810
	protected virtual void LateUpdate() { }

	// RVA: 0x1A13128
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x1A13514
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x1A13734
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x1A13B84
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1A13CA4
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A13CD0
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A13F94
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1A1404C
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A14074
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A14288
	protected EditState KeyPressed(Event evt) { }

	// RVA: 0x1A15538
	private bool IsValidChar(Char c) { }

	// RVA: 0x1A155C0
	public void ProcessEvent(Event e) { }

	// RVA: 0x1A155C4
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1A14DDC
	private string GetSelectedString() { }

	// RVA: 0x1A157E0
	private int FindtNextWordBegin() { }

	// RVA: 0x1A15368
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1A158C8
	private int FindtPrevWordBegin() { }

	// RVA: 0x1A151A8
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1A15998
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x1A15AB0
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1A16038
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1A15530
	private void MoveDown(bool shift) { }

	// RVA: 0x1A165A8
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1A15528
	private void MoveUp(bool shift) { }

	// RVA: 0x1A16774
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1A14EB8
	private void Delete() { }

	// RVA: 0x1A14BDC
	private void ForwardSpace() { }

	// RVA: 0x1A14954
	private void Backspace() { }

	// RVA: 0x1A16908
	private void Insert(Char c) { }

	// RVA: 0x1A15150
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1A130A0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1A0E824
	private void SendOnValueChanged() { }

	// RVA: 0x1A16AF8
	protected void SendOnEndEdit() { }

	// RVA: 0x1A12908
	protected void SendOnSubmit() { }

	// RVA: 0x1A16B88
	protected virtual void Append(string input) { }

	// RVA: 0x1A16C4C
	protected virtual void Append(Char input) { }

	// RVA: 0x1A0E8B4
	protected void UpdateLabel() { }

	// RVA: 0x1A18014
	private bool IsSelectionVisible() { }

	// RVA: 0x1A180F8
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x1A139FC
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x1A16F14
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x1A18254
	public void ForceLabelUpdate() { }

	// RVA: 0x1A0F070
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1A18258
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A1879C
	public virtual void LayoutComplete() { }

	// RVA: 0x1A187A0
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A18268
	private void UpdateGeometry() { }

	// RVA: 0x1A12374
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1A187A4
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x1A18A14
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1A1993C
	private void CreateCursorVerts() { }

	// RVA: 0x1A1917C
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1A12998
	protected Char Validate(string text, int pos, Char ch) { }

	// RVA: 0x1A19A88
	public void ActivateInputField() { }

	// RVA: 0x1A11E74
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1A19BFC
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1A19C48
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A10AC8
	public void DeactivateInputField() { }

	// RVA: 0x1A19C70
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1A19CA0
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A0FA80
	private void EnforceContentType() { }

	// RVA: 0x1A0DF28
	private void EnforceTextHOverflow() { }

	// RVA: 0x1A0FC1C
	private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) { }

	// RVA: 0x1A0FE48
	private void SetToCustom() { }

	// RVA: 0x1A19D00
	protected override void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x1A19D2C
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A19D30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1A19D34
	public virtual float get_minWidth() { }

	// RVA: 0x1A19D3C
	public virtual float get_preferredWidth() { }

	// RVA: 0x1A19EC0
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1A19EC8
	public virtual float get_minHeight() { }

	// RVA: 0x1A19ED0
	public virtual float get_preferredHeight() { }

	// RVA: 0x1A1A040
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1A1A048
	public virtual int get_layoutPriority() { }

	// RVA: 0x1A1A050
	private static void .cctor() { }

	// RVA: 0x1A1A104
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

	// RVA: 0x1A1A6C8
	public AspectMode get_aspectMode() { }

	// RVA: 0x1A1A6D0
	public void set_aspectMode(AspectMode value) { }

	// RVA: 0x1A1A778
	public float get_aspectRatio() { }

	// RVA: 0x1A1A780
	public void set_aspectRatio(float value) { }

	// RVA: 0x1A1A830
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A1A928
	protected void .ctor() { }

	// RVA: 0x1A1A938
	protected override void OnEnable() { }

	// RVA: 0x1A1A9D4
	protected override void Start() { }

	// RVA: 0x1A1AB54
	protected override void OnDisable() { }

	// RVA: 0x1A1B104
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A1B1A0
	protected virtual void Update() { }

	// RVA: 0x1A1B1B4
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A1B1B8
	private void UpdateRect() { }

	// RVA: 0x1A1B588
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x1A1B46C
	private Vector2 GetParentSize() { }

	// RVA: 0x1A1B680
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1A1B684
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1A1A774
	protected void SetDirty() { }

	// RVA: 0x1A1AA34
	public bool IsComponentValidOnObject() { }

	// RVA: 0x1A1AB2C
	public bool IsAspectModeValid() { }

	// RVA: 0x1A1B688
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

	// RVA: 0x1A1B690
	public ScaleMode get_uiScaleMode() { }

	// RVA: 0x1A1B698
	public void set_uiScaleMode(ScaleMode value) { }

	// RVA: 0x1A1B6A0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1A1B6A8
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1A1B6B0
	public float get_scaleFactor() { }

	// RVA: 0x1A1B6B8
	public void set_scaleFactor(float value) { }

	// RVA: 0x1A1B6D4
	public Vector2 get_referenceResolution() { }

	// RVA: 0x1A1B6DC
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x1A1B764
	public ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1A1B76C
	public void set_screenMatchMode(ScreenMatchMode value) { }

	// RVA: 0x1A1B774
	public float get_matchWidthOrHeight() { }

	// RVA: 0x1A1B77C
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x1A1B784
	public Unit get_physicalUnit() { }

	// RVA: 0x1A1B78C
	public void set_physicalUnit(Unit value) { }

	// RVA: 0x1A1B794
	public float get_fallbackScreenDPI() { }

	// RVA: 0x1A1B79C
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x1A1B7A4
	public float get_defaultSpriteDPI() { }

	// RVA: 0x1A1B7AC
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x1A1B7C0
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x1A1B7C8
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x1A1B7D0
	protected void .ctor() { }

	// RVA: 0x1A1B818
	protected override void OnEnable() { }

	// RVA: 0x1A1B904
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x1A1B914
	protected override void OnDisable() { }

	// RVA: 0x1A1BAD4
	protected virtual void Handle() { }

	// RVA: 0x1A1BC10
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x1A1BCA8
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x1A1BD40
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x1A1C020
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x1A1BA14
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x1A1BA74
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

	// RVA: 0x1A1C0F4
	public FitMode get_horizontalFit() { }

	// RVA: 0x1A1C0FC
	public void set_horizontalFit(FitMode value) { }

	// RVA: 0x1A1C274
	public FitMode get_verticalFit() { }

	// RVA: 0x1A1C27C
	public void set_verticalFit(FitMode value) { }

	// RVA: 0x1A1C34C
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A1C444
	protected void .ctor() { }

	// RVA: 0x1A1C44C
	protected override void OnEnable() { }

	// RVA: 0x1A1C4FC
	protected override void OnDisable() { }

	// RVA: 0x1A1C580
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A1C628
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x1A1C724
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1A1C754
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1A1C1CC
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

	// RVA: 0x1A1C75C
	public Corner get_startCorner() { }

	// RVA: 0x1A1C764
	public void set_startCorner(Corner value) { }

	// RVA: 0x1A1C7D4
	public Axis get_startAxis() { }

	// RVA: 0x1A1C7DC
	public void set_startAxis(Axis value) { }

	// RVA: 0x1A1C84C
	public Vector2 get_cellSize() { }

	// RVA: 0x1A1C854
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x1A1C8D0
	public Vector2 get_spacing() { }

	// RVA: 0x1A1C8D8
	public void set_spacing(Vector2 value) { }

	// RVA: 0x1A1C954
	public Constraint get_constraint() { }

	// RVA: 0x1A1C95C
	public void set_constraint(Constraint value) { }

	// RVA: 0x1A1C9CC
	public int get_constraintCount() { }

	// RVA: 0x1A1C9D4
	public void set_constraintCount(int value) { }

	// RVA: 0x1A1CA4C
	protected void .ctor() { }

	// RVA: 0x1A1CC10
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A1D2B0
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A1D610
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A1DF5C
	public override void SetLayoutVertical() { }

	// RVA: 0x1A1D618
	private void SetCellsAlongAxis(int axis) { }

}

// Namespace: UnityEngine.UI
public class HorizontalLayoutGroup
{
	// Methods

	// RVA: 0x1A1E1B8
	protected void .ctor() { }

	// RVA: 0x1A1E1D0
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A1E6D8
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A1E6E4
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A1EF74
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

	// RVA: 0x1A1EF80
	public float get_spacing() { }

	// RVA: 0x1A1EF88
	public void set_spacing(float value) { }

	// RVA: 0x1A1F000
	public bool get_childForceExpandWidth() { }

	// RVA: 0x1A1F008
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1A1F078
	public bool get_childForceExpandHeight() { }

	// RVA: 0x1A1F080
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1A1F0F0
	public bool get_childControlWidth() { }

	// RVA: 0x1A1F0F8
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1A1F168
	public bool get_childControlHeight() { }

	// RVA: 0x1A1F170
	public void set_childControlHeight(bool value) { }

	// RVA: 0x1A1F1E0
	public bool get_childScaleWidth() { }

	// RVA: 0x1A1F1E8
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1A1F258
	public bool get_childScaleHeight() { }

	// RVA: 0x1A1F260
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x1A1F2D0
	public bool get_reverseArrangement() { }

	// RVA: 0x1A1F2D8
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x1A1E1FC
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1A1E6F0
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1A1F348
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, float min, float preferred, float flexible) { }

	// RVA: 0x1A1E1C4
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

	// RVA: 0x1A1FB00
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x1A1FB08
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x1A1FCE0
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A1FCE4
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1A1FCE8
	public virtual float get_minWidth() { }

	// RVA: 0x1A1FCF0
	public virtual void set_minWidth(float value) { }

	// RVA: 0x1A1FDFC
	public virtual float get_minHeight() { }

	// RVA: 0x1A1FE04
	public virtual void set_minHeight(float value) { }

	// RVA: 0x1A1FF10
	public virtual float get_preferredWidth() { }

	// RVA: 0x1A1FF18
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x1A20024
	public virtual float get_preferredHeight() { }

	// RVA: 0x1A2002C
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x1A20138
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1A20140
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x1A2024C
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1A20254
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x1A20360
	public virtual int get_layoutPriority() { }

	// RVA: 0x1A20368
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1A2046C
	protected void .ctor() { }

	// RVA: 0x1A2048C
	protected override void OnEnable() { }

	// RVA: 0x1A20568
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A2063C
	protected override void OnDisable() { }

	// RVA: 0x1A20728
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A207FC
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1A1FC0C
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

	// RVA: 0x1A20EBC
	public void .ctor(int <>1__state) { }

	// RVA: 0x1A20EE8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A20EEC
	private bool MoveNext() { }

	// RVA: 0x1A20FA0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1A20FA8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1A20FE8
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

	// RVA: 0x1A208D0
	public RectOffset get_padding() { }

	// RVA: 0x1A208D8
	public void set_padding(RectOffset value) { }

	// RVA: 0x1A20938
	public TextAnchor get_childAlignment() { }

	// RVA: 0x1A20940
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1A1D518
	protected RectTransform get_rectTransform() { }

	// RVA: 0x1A209B0
	protected System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren() { }

	// RVA: 0x1A1CE10
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: 0x1A209B8
	public virtual float get_minWidth() { }

	// RVA: 0x1A209C0
	public virtual float get_preferredWidth() { }

	// RVA: 0x1A209C8
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1A209D0
	public virtual float get_minHeight() { }

	// RVA: 0x1A209D8
	public virtual float get_preferredHeight() { }

	// RVA: 0x1A209E0
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1A209E8
	public virtual int get_layoutPriority() { }

	// RVA: -1
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1
	public abstract void SetLayoutVertical() { }

	// RVA: 0x1A1CAB8
	protected void .ctor() { }

	// RVA: 0x1A209F0
	protected override void OnEnable() { }

	// RVA: 0x1A20B5C
	protected override void OnDisable() { }

	// RVA: 0x1A20BE0
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A1FA6C
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x1A1F95C
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x1A1F9E4
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1A1DF64
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x1A1F460
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1A1D218
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x1A20BE4
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x1A1F70C
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x1A1E0D8
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x1A1F4A0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1A20CBC
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x1A20E00
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A20E40
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x26AD93C
	protected void SetProperty(T currentValue, T newValue) { }

	// RVA: 0x1A20A18
	protected void SetDirty() { }

	// RVA: 0x1A20E44
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

	// RVA: 0x1A227D0
	private static void .cctor() { }

	// RVA: 0x1A2283C
	public void .ctor() { }

	// RVA: 0x1A22844
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x1A2289C
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x1A228D4
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1A22968
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1A22A44
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x1A22B20
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1A22C00
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

	// RVA: 0x1A20FF0
	private void Initialize(RectTransform controller) { }

	// RVA: 0x1A21034
	private void Clear() { }

	// RVA: 0x1A21064
	private static void .cctor() { }

	// RVA: 0x1A21254
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x1A212D4
	public Transform get_transform() { }

	// RVA: 0x1A212DC
	public bool IsDestroyed() { }

	// RVA: 0x1A21348
	private static void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components) { }

	// RVA: 0x1A21468
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x1A2162C
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1A21C64
	private void PerformLayoutControl(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x1A21948
	private void PerformLayoutCalculation(RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action) { }

	// RVA: 0x1A1ABD8
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1A220D0
	private static bool ValidController(RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps) { }

	// RVA: 0x1A2232C
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1A2257C
	public void LayoutComplete() { }

	// RVA: 0x1A226DC
	public void GraphicUpdateComplete() { }

	// RVA: 0x1A226E0
	public override int GetHashCode() { }

	// RVA: 0x1A226E8
	public override bool Equals(object obj) { }

	// RVA: 0x1A2273C
	public override string ToString() { }

	// RVA: 0x1A227C8
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

	// RVA: 0x1A23880
	private static void .cctor() { }

	// RVA: 0x1A238EC
	public void .ctor() { }

	// RVA: 0x1A238F4
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x1A239A8
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x1A23A5C
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x1A23B10
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x1A23BC4
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1A23C78
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1A23D2C
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x1A23DE0
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

// Namespace: UnityEngine.UI
public static class LayoutUtility
{
	// Methods

	// RVA: 0x1A1C70C
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x1A1C718
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x1A1FAF4
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1A22DF8
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x1A230E8
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x1A233D8
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x1A22CE0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1A22F10
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x1A232C0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x1A234F0
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue) { }

	// RVA: 0x1A23514
	public static float GetLayoutProperty(RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement,System.Single> property, float defaultValue, ILayoutElement source) { }

}

// Namespace: UnityEngine.UI
public class VerticalLayoutGroup
{
	// Methods

	// RVA: 0x1A23E94
	protected void .ctor() { }

	// RVA: 0x1A23EA0
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A23ECC
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A23ED8
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A23EE4
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

	// RVA: 0x1A23EF0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1A23F9C
	public bool get_showMaskGraphic() { }

	// RVA: 0x1A23FA4
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1A2413C
	public Graphic get_graphic() { }

	// RVA: 0x1A241E8
	protected void .ctor() { }

	// RVA: 0x1A241F8
	public virtual bool MaskEnabled() { }

	// RVA: 0x1A24324
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1A24328
	protected override void OnEnable() { }

	// RVA: 0x1A24950
	protected override void OnDisable() { }

	// RVA: 0x1A24D60
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1A24E9C
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

}

// Namespace: 
[Serializable]
public class CullStateChangedEvent
{
	// Methods

	// RVA: 0x1A26944
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

	// RVA: 0x1A258DC
	public CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x1A258E4
	public void set_onCullStateChanged(CullStateChangedEvent value) { }

	// RVA: 0x1A258EC
	public bool get_maskable() { }

	// RVA: 0x1A258F4
	public void set_maskable(bool value) { }

	// RVA: 0x1A25920
	public bool get_isMaskingGraphic() { }

	// RVA: 0x1A24664
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x1A25928
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1A25A58
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1A25DA8
	private void UpdateCull(bool cull) { }

	// RVA: 0x1A25E90
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1A25F10
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x1A25F4C
	protected override void OnEnable() { }

	// RVA: 0x1A26170
	protected override void OnDisable() { }

	// RVA: 0x1A2623C
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A2629C
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1A262A0
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A25B3C
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1A25FAC
	private void UpdateClipParent() { }

	// RVA: 0x1A26780
	public virtual void RecalculateClipping() { }

	// RVA: 0x1A26784
	public virtual void RecalculateMasking() { }

	// RVA: 0x1A2681C
	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1A26830
	protected void .ctor() { }

	// RVA: 0x1A26998
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }

}

// Namespace: UnityEngine.UI
public class MaskUtilities
{
	// Methods

	// RVA: 0x1A269A0
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x1A24678
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x1A25320
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1A25514
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x1A26C7C
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x1A26300
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x1A26E50
	public static void GetRectMasksForClip(RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks) { }

	// RVA: 0x1A2722C
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

	// RVA: 0x1A27234
	public static void Destroy(object obj) { }

	// RVA: 0x1A273C8
	public static void DestroyImmediate(object obj) { }

}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities
{
	// Methods

	// RVA: 0x1A2751C
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, Vector2 position) { }

	// RVA: 0x1A27A2C
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x1A27594
	public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex) { }

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

	// RVA: 0x1A27B08
	public Mode get_mode() { }

	// RVA: 0x1A27B10
	public void set_mode(Mode value) { }

	// RVA: 0x1A27B18
	public bool get_wrapAround() { }

	// RVA: 0x1A27B20
	public void set_wrapAround(bool value) { }

	// RVA: 0x1A27B28
	public Selectable get_selectOnUp() { }

	// RVA: 0x1A27B30
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x1A27B38
	public Selectable get_selectOnDown() { }

	// RVA: 0x1A27B40
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x1A27B48
	public Selectable get_selectOnLeft() { }

	// RVA: 0x1A27B50
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x1A27B58
	public Selectable get_selectOnRight() { }

	// RVA: 0x1A27B60
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x1A27B68
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x1A27B88
	public bool Equals(Navigation other) { }

}

// Namespace: UnityEngine.UI
public class RawImage
{
	// Fields
	private Texture m_Texture; // 0xD8
	private Rect m_UVRect; // 0xE0

	// Methods

	// RVA: 0x1A27CF4
	protected void .ctor() { }

	// RVA: 0x1A27D28
	public override Texture get_mainTexture() { }

	// RVA: 0x1A27EFC
	public Texture get_texture() { }

	// RVA: 0x1A27F04
	public void set_texture(Texture value) { }

	// RVA: 0x1A27FF8
	public Rect get_uvRect() { }

	// RVA: 0x1A28004
	public void set_uvRect(Rect value) { }

	// RVA: 0x1A2803C
	public override void SetNativeSize() { }

	// RVA: 0x1A28360
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1A28C3C
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

	// RVA: 0x1A28C84
	public Vector4 get_padding() { }

	// RVA: 0x1A28C90
	public void set_padding(Vector4 value) { }

	// RVA: 0x1A28CA0
	public Vector2Int get_softness() { }

	// RVA: 0x1A28CA8
	public void set_softness(Vector2Int value) { }

	// RVA: 0x1A28CC4
	internal Canvas get_Canvas() { }

	// RVA: 0x1A28EA4
	public Rect get_canvasRect() { }

	// RVA: 0x1A28F68
	public RectTransform get_rectTransform() { }

	// RVA: 0x1A29014
	protected void .ctor() { }

	// RVA: 0x1A291B8
	protected override void OnEnable() { }

	// RVA: 0x1A291F8
	protected override void OnDisable() { }

	// RVA: 0x1A292FC
	protected override void OnDestroy() { }

	// RVA: 0x1A29328
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1A29494
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1A296B8
	public virtual void PerformClipping() { }

	// RVA: 0x1A2A16C
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x1A2A578
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1A2A6BC
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1A2A884
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A2A8C0
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

	// RVA: 0x1A2AF38
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
private sealed class <ClickRepeat>d__59
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

	// Methods

	// RVA: 0x1A2C5E4
	public void .ctor(int <>1__state) { }

	// RVA: 0x1A2D258
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A2D25C
	private bool MoveNext() { }

	// RVA: 0x1A2D38C
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1A2D394
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1A2D3D4
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

	// RVA: 0x1A2A8FC
	public RectTransform get_handleRect() { }

	// RVA: 0x1A2A904
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1A2AD70
	public Direction get_direction() { }

	// RVA: 0x1A2AD78
	public void set_direction(Direction value) { }

	// RVA: 0x1A2AE1C
	protected void .ctor() { }

	// RVA: 0x1A2B0CC
	public float get_value() { }

	// RVA: 0x1A2B188
	public void set_value(float value) { }

	// RVA: 0x1A2B3C8
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1A2B3D0
	public float get_size() { }

	// RVA: 0x1A2B3D8
	public void set_size(float value) { }

	// RVA: 0x1A2B470
	public int get_numberOfSteps() { }

	// RVA: 0x1A2B478
	public void set_numberOfSteps(int value) { }

	// RVA: 0x1A2B52C
	public ScrollEvent get_onValueChanged() { }

	// RVA: 0x1A2B534
	public void set_onValueChanged(ScrollEvent value) { }

	// RVA: 0x1A2B544
	private float get_stepSize() { }

	// RVA: 0x1A2B574
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1A2B578
	public virtual void LayoutComplete() { }

	// RVA: 0x1A2B57C
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A2B580
	protected override void OnEnable() { }

	// RVA: 0x1A2B8B0
	protected override void OnDisable() { }

	// RVA: 0x1A2BA20
	protected virtual void Update() { }

	// RVA: 0x1A2A984
	private void UpdateCachedReferences() { }

	// RVA: 0x1A2B190
	private void Set(float input, bool sendCallback) { }

	// RVA: 0x1A2BA34
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A2BA7C
	private Axis get_axis() { }

	// RVA: 0x1A2BA8C
	private bool get_reverseValue() { }

	// RVA: 0x1A2AAD4
	private void UpdateVisuals() { }

	// RVA: 0x1A2BAA0
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x1A2BBE8
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	// RVA: 0x1A2BDFC
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1A2BE68
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1A2BEC4
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A2C0C0
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A2C1A0
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A2C534
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	// RVA: 0x1A2C494
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x1A2C610
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A2C798
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A2CC00
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1A2CD10
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1A2CE20
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1A2CF30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1A2D040
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1A2D05C
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1A2D250
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

	// RVA: 0x1A2DFAC
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

	// RVA: 0x1A2D3DC
	public RectTransform get_content() { }

	// RVA: 0x1A2D3E4
	public void set_content(RectTransform value) { }

	// RVA: 0x1A2D3EC
	public bool get_horizontal() { }

	// RVA: 0x1A2D3F4
	public void set_horizontal(bool value) { }

	// RVA: 0x1A2D3FC
	public bool get_vertical() { }

	// RVA: 0x1A2D404
	public void set_vertical(bool value) { }

	// RVA: 0x1A2D40C
	public MovementType get_movementType() { }

	// RVA: 0x1A2D414
	public void set_movementType(MovementType value) { }

	// RVA: 0x1A2D41C
	public float get_elasticity() { }

	// RVA: 0x1A2D424
	public void set_elasticity(float value) { }

	// RVA: 0x1A2D42C
	public bool get_inertia() { }

	// RVA: 0x1A2D434
	public void set_inertia(bool value) { }

	// RVA: 0x1A2D43C
	public float get_decelerationRate() { }

	// RVA: 0x1A2D444
	public void set_decelerationRate(float value) { }

	// RVA: 0x1A2D44C
	public float get_scrollSensitivity() { }

	// RVA: 0x1A2D454
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1A2D45C
	public RectTransform get_viewport() { }

	// RVA: 0x1A2D464
	public void set_viewport(RectTransform value) { }

	// RVA: 0x1A2D574
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1A2D57C
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x1A2D780
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1A2D788
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1A2D98C
	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1A2D994
	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x1A2D99C
	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x1A2D9A4
	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	// RVA: 0x1A2D9AC
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x1A2D9B4
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1A2DB18
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x1A2DB20
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x1A2DBD4
	public ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x1A2DBDC
	public void set_onValueChanged(ScrollRectEvent value) { }

	// RVA: 0x1A2DBE4
	protected RectTransform get_viewRect() { }

	// RVA: 0x1A2DD58
	public Vector2 get_velocity() { }

	// RVA: 0x1A2DD60
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1A2DD68
	private RectTransform get_rectTransform() { }

	// RVA: 0x1A2DE60
	protected void .ctor() { }

	// RVA: 0x1A2E000
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1A2EE2C
	public virtual void LayoutComplete() { }

	// RVA: 0x1A2EE30
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A2E08C
	private void UpdateCachedData() { }

	// RVA: 0x1A2EE34
	protected override void OnEnable() { }

	// RVA: 0x1A2F0E4
	protected override void OnDisable() { }

	// RVA: 0x1A2F348
	public override bool IsActive() { }

	// RVA: 0x1A2F3F0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x1A2F474
	public virtual void StopMovement() { }

	// RVA: 0x1A2F4C8
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1A2F97C
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1A2F9EC
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A2FB2C
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A2FB58
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A2FEB0
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1A2FF90
	protected virtual void LateUpdate() { }

	// RVA: 0x1A2ED24
	protected void UpdatePrevData() { }

	// RVA: 0x1A2E874
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1A307B4
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1A30D04
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1A30AEC
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1A30D58
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1A30BF8
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1A30D6C
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1A30D80
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1A30D94
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1A30DA8
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1A2FE74
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x1A310FC
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A311AC
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1A31268
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1A31324
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A31328
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1A3132C
	public virtual float get_minWidth() { }

	// RVA: 0x1A31334
	public virtual float get_preferredWidth() { }

	// RVA: 0x1A3133C
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1A31344
	public virtual float get_minHeight() { }

	// RVA: 0x1A3134C
	public virtual float get_preferredHeight() { }

	// RVA: 0x1A31354
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1A3135C
	public virtual int get_layoutPriority() { }

	// RVA: 0x1A31364
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1A31AE4
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1A3099C
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1A31F60
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x1A31BA8
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1A2E4F0
	protected void UpdateBounds() { }

	// RVA: 0x1A320A8
	internal static void AdjustBounds(Bounds viewBounds, Vector2 contentPivot, Vector3 contentSize, Vector3 contentPos) { }

	// RVA: 0x1A319C4
	private Bounds GetBounds() { }

	// RVA: 0x1A32130
	internal static Bounds InternalGetBounds(Vector3[] corners, Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x1A2F814
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1A32374
	internal static Vector2 InternalCalculateOffset(Bounds viewBounds, Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, Vector2 delta) { }

	// RVA: 0x1A2DA68
	protected void SetDirty() { }

	// RVA: 0x1A2D48C
	protected void SetDirtyCaching() { }

	// RVA: 0x1A324B4
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

	// RVA: 0x1A324BC
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x1A32558
	public static int get_allSelectableCount() { }

	// RVA: 0x1A325D4
	public static System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables() { }

	// RVA: 0x1A32704
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1A327F4
	public Navigation get_navigation() { }

	// RVA: 0x1A3280C
	public void set_navigation(Navigation value) { }

	// RVA: 0x1A32954
	public Transition get_transition() { }

	// RVA: 0x1A3295C
	public void set_transition(Transition value) { }

	// RVA: 0x1A32A54
	public ColorBlock get_colors() { }

	// RVA: 0x1A32A80
	public void set_colors(ColorBlock value) { }

	// RVA: 0x1A32B68
	public SpriteState get_spriteState() { }

	// RVA: 0x1A32B74
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x1A32C44
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x1A32C4C
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x1A32D18
	public Graphic get_targetGraphic() { }

	// RVA: 0x1A32D20
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1A32DEC
	public bool get_interactable() { }

	// RVA: 0x1A32DF4
	public void set_interactable(bool value) { }

	// RVA: 0x1A33000
	private bool get_isPointerInside() { }

	// RVA: 0x1A33008
	private void set_isPointerInside(bool value) { }

	// RVA: 0x1A33010
	private bool get_isPointerDown() { }

	// RVA: 0x1A33018
	private void set_isPointerDown(bool value) { }

	// RVA: 0x1A33020
	private bool get_hasSelection() { }

	// RVA: 0x1A33028
	private void set_hasSelection(bool value) { }

	// RVA: 0x1A2AF8C
	protected void .ctor() { }

	// RVA: 0x1A33030
	public Image get_image() { }

	// RVA: 0x1A330B8
	public void set_image(Image value) { }

	// RVA: 0x1A330C0
	public Animator get_animator() { }

	// RVA: 0x1A33128
	protected override void Awake() { }

	// RVA: 0x1A33218
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x1A332AC
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x1A33450
	public virtual bool IsInteractable() { }

	// RVA: 0x1A33470
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A2B5BC
	protected override void OnEnable() { }

	// RVA: 0x1A33554
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A328E4
	private void OnSetProperty() { }

	// RVA: 0x1A2B8DC
	protected override void OnDisable() { }

	// RVA: 0x1A33588
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1A334E0
	protected SelectionState get_currentSelectionState() { }

	// RVA: 0x1A33644
	protected virtual void InstantClearState() { }

	// RVA: 0x1A33D88
	protected virtual void DoStateTransition(SelectionState state, bool instant) { }

	// RVA: 0x1A3402C
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x1A34568
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x1A34718
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x1A2CC24
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x1A2CD34
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x1A2CE44
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x1A2CF54
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x1A2CB5C
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A33788
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x1A338C0
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x1A33A54
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x1A347F8
	protected bool IsHighlighted() { }

	// RVA: 0x1A335F4
	protected bool IsPressed() { }

	// RVA: 0x1A34878
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x1A2C2CC
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A2C6DC
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A34920
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1A349D0
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1A34A7C
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1A34B2C
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1A34BD8
	public virtual void Select() { }

	// RVA: 0x1A34D2C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility
{
	// Methods

	// RVA: 0x1A34DBC
	public static bool SetColor(Color currentValue, Color newValue) { }

	// RVA: 0x26AD93C
	public static bool SetStruct(T currentValue, T newValue) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x1A36068
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

	// RVA: 0x1A34E08
	public RectTransform get_fillRect() { }

	// RVA: 0x1A34E10
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x1A35940
	public RectTransform get_handleRect() { }

	// RVA: 0x1A35948
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1A359C8
	public Direction get_direction() { }

	// RVA: 0x1A359D0
	public void set_direction(Direction value) { }

	// RVA: 0x1A35A74
	public float get_minValue() { }

	// RVA: 0x1A35A7C
	public void set_minValue(float value) { }

	// RVA: 0x1A35B48
	public float get_maxValue() { }

	// RVA: 0x1A35B50
	public void set_maxValue(float value) { }

	// RVA: 0x1A35C1C
	public bool get_wholeNumbers() { }

	// RVA: 0x1A35C24
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x1A35CE4
	public virtual float get_value() { }

	// RVA: 0x1A35DB0
	public virtual void set_value(float value) { }

	// RVA: 0x1A35DC4
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1A35DD8
	public float get_normalizedValue() { }

	// RVA: 0x1A35ECC
	public void set_normalizedValue(float value) { }

	// RVA: 0x1A35F08
	public SliderEvent get_onValueChanged() { }

	// RVA: 0x1A35F10
	public void set_onValueChanged(SliderEvent value) { }

	// RVA: 0x1A35F20
	private float get_stepSize() { }

	// RVA: 0x1A35F50
	protected void .ctor() { }

	// RVA: 0x1A360BC
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1A360C0
	public virtual void LayoutComplete() { }

	// RVA: 0x1A360C4
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A360C8
	protected override void OnEnable() { }

	// RVA: 0x1A36110
	protected override void OnDisable() { }

	// RVA: 0x1A3613C
	protected virtual void Update() { }

	// RVA: 0x1A3618C
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A34E90
	private void UpdateCachedReferences() { }

	// RVA: 0x1A36688
	private float ClampValue(float input) { }

	// RVA: 0x1A3678C
	protected virtual void Set(float input, bool sendCallback) { }

	// RVA: 0x1A36914
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A3677C
	private Axis get_axis() { }

	// RVA: 0x1A36768
	private bool get_reverseValue() { }

	// RVA: 0x1A3523C
	private void UpdateVisuals() { }

	// RVA: 0x1A3695C
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1A36BD4
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1A36C30
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A36E3C
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A36EB8
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A3727C
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1A372A0
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1A372C4
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1A372E8
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1A3730C
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1A37328
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1A3751C
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

	// RVA: 0x1A37524
	public Sprite get_highlightedSprite() { }

	// RVA: 0x1A3752C
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x1A37534
	public Sprite get_pressedSprite() { }

	// RVA: 0x1A3753C
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x1A37544
	public Sprite get_selectedSprite() { }

	// RVA: 0x1A3754C
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x1A37554
	public Sprite get_disabledSprite() { }

	// RVA: 0x1A3755C
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x1A37564
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

	// RVA: 0x1A38270
	public void .ctor() { }

}

// Namespace: UnityEngine.UI
public static class StencilMaterial
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	// RVA: 0x1A376D4
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x1A376DC
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x1A381AC
	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	// RVA: 0x1A37774
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x1A38280
	public static void Remove(Material customMat) { }

	// RVA: 0x1A3846C
	public static void ClearAll() { }

	// RVA: 0x1A38624
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

	// RVA: 0x1A386C0
	protected void .ctor() { }

	// RVA: 0x1A38770
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x1A38828
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x1A388B4
	public override Texture get_mainTexture() { }

	// RVA: 0x1A38B08
	public void FontTextureChanged() { }

	// RVA: 0x1A38AE8
	public Font get_font() { }

	// RVA: 0x1A38C5C
	public void set_font(Font value) { }

	// RVA: 0x1A38D9C
	public virtual string get_text() { }

	// RVA: 0x1A38DA4
	public virtual void set_text(string value) { }

	// RVA: 0x1A38E98
	public bool get_supportRichText() { }

	// RVA: 0x1A38EB8
	public void set_supportRichText(bool value) { }

	// RVA: 0x1A38F24
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x1A38F44
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x1A38FB0
	public int get_resizeTextMinSize() { }

	// RVA: 0x1A38FD0
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x1A39034
	public int get_resizeTextMaxSize() { }

	// RVA: 0x1A39054
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x1A390B8
	public TextAnchor get_alignment() { }

	// RVA: 0x1A390D8
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A3913C
	public bool get_alignByGeometry() { }

	// RVA: 0x1A3915C
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1A391A4
	public int get_fontSize() { }

	// RVA: 0x1A391C4
	public void set_fontSize(int value) { }

	// RVA: 0x1A39228
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1A39248
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1A392AC
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1A392CC
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1A39330
	public float get_lineSpacing() { }

	// RVA: 0x1A39350
	public void set_lineSpacing(float value) { }

	// RVA: 0x1A393B4
	public FontStyle get_fontStyle() { }

	// RVA: 0x1A393D4
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1A39438
	public float get_pixelsPerUnit() { }

	// RVA: 0x1A395CC
	protected override void OnEnable() { }

	// RVA: 0x1A39660
	protected override void OnDisable() { }

	// RVA: 0x1A396D0
	protected override void UpdateGeometry() { }

	// RVA: 0x1A39770
	internal void AssignDefaultFont() { }

	// RVA: 0x1A397E4
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x1A398B8
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x1A39A7C
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x1A39B08
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1A3A274
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A3A278
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1A3A27C
	public virtual float get_minWidth() { }

	// RVA: 0x1A3A284
	public virtual float get_preferredWidth() { }

	// RVA: 0x1A3A3DC
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1A3A3E4
	public virtual float get_minHeight() { }

	// RVA: 0x1A3A3EC
	public virtual float get_preferredHeight() { }

	// RVA: 0x1A3A510
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1A3A518
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

	// RVA: 0x1A3AA6C
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

	// RVA: 0x1A3A520
	public ToggleGroup get_group() { }

	// RVA: 0x1A3A528
	public void set_group(ToggleGroup value) { }

	// RVA: 0x1A3A984
	protected void .ctor() { }

	// RVA: 0x1A3AAC0
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1A3AAC4
	public virtual void LayoutComplete() { }

	// RVA: 0x1A3AAC8
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A3AACC
	protected override void OnDestroy() { }

	// RVA: 0x1A3AFDC
	protected override void OnEnable() { }

	// RVA: 0x1A3B0C8
	protected override void OnDisable() { }

	// RVA: 0x1A3B0F4
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A3A608
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x1A3B834
	public bool get_isOn() { }

	// RVA: 0x1A3B83C
	public void set_isOn(bool value) { }

	// RVA: 0x1A3B844
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x1A3B2AC
	private void Set(bool value, bool sendCallback) { }

	// RVA: 0x1A3A894
	private void PlayEffect(bool instant) { }

	// RVA: 0x1A3B9BC
	protected override void Start() { }

	// RVA: 0x1A3BA94
	private void InternalToggle() { }

	// RVA: 0x1A3BAF8
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A3BB6C
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A3BBD0
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

	// RVA: 0x1A3C130
	private static void .cctor() { }

	// RVA: 0x1A3C19C
	public void .ctor() { }

	// RVA: 0x1A3C1A4
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x1A3C1C0
	internal bool <ActiveToggles>b__14_0(Toggle x) { }

}

// Namespace: UnityEngine.UI
public class ToggleGroup
{
	// Fields
	private bool m_AllowSwitchOff; // 0x20
	protected System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles; // 0x28

	// Methods

	// RVA: 0x1A3BBD8
	public bool get_allowSwitchOff() { }

	// RVA: 0x1A3BBE0
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x1A3BBE8
	protected void .ctor() { }

	// RVA: 0x1A3BC74
	protected override void Start() { }

	// RVA: 0x1A3BC9C
	protected override void OnEnable() { }

	// RVA: 0x1A3BCC4
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x1A3B644
	public void NotifyToggleOn(Toggle toggle, bool sendCallback) { }

	// RVA: 0x1A3B504
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x1A3B5A4
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x1A3AB94
	public void EnsureValidState() { }

	// RVA: 0x1A3B84C
	public bool AnyTogglesOn() { }

	// RVA: 0x1A3BE3C
	public System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles() { }

	// RVA: 0x1A3BF6C
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x1A3C01C
	public void SetAllTogglesOff(bool sendCallback) { }

}

// Namespace: 
public sealed class Raycast3DCallback
{
	// Methods

	// RVA: 0x1A3C9A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A3CA4C
	public virtual bool Invoke(Ray r, RaycastHit hit, float f, int i) { }

	// RVA: 0x1A3CA8C
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1A3CBA8
	public virtual bool EndInvoke(RaycastHit hit, IAsyncResult result) { }

}

// Namespace: 
public sealed class RaycastAllCallback
{
	// Methods

	// RVA: 0x1A3CC0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A3CCB0
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1A3CCF0
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1A3CDDC
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

// Namespace: 
public sealed class GetRaycastNonAllocCallback
{
	// Methods

	// RVA: 0x1A3CDE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A3CE8C
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x1A3CECC
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1A3CFC4
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

	// RVA: 0x1A3C1DC
	public void .ctor() { }

	// RVA: 0x1A3C900
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

	// RVA: 0x1A3CFF0
	public void .ctor() { }

	// RVA: 0x1A3CFF8
	public void .ctor(Mesh m) { }

	// RVA: 0x1A3D238
	private void InitializeListIfRequired() { }

	// RVA: 0x1A3D450
	public void Dispose() { }

	// RVA: 0x1A28640
	public void Clear() { }

	// RVA: 0x1A3D6C8
	public int get_currentVertCount() { }

	// RVA: 0x1A3D720
	public int get_currentIndexCount() { }

	// RVA: 0x1A3D778
	public void PopulateUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x1A3D920
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x1A3DAC8
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x1A3DC34
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1A3DE00
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1A289D0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x1A3DF0C
	public void AddVert(UIVertex v) { }

	// RVA: 0x1A28B80
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x1A3A0C0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x1A3DFA4
	public void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1A3E054
	public void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts) { }

	// RVA: 0x1A3E0A8
	public void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream) { }

	// RVA: 0x1A3E0FC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseVertexEffect
{
	// Methods

	// RVA: -1
	public abstract void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x1A3E198
	protected void .ctor() { }

}

// Namespace: UnityEngine.UI
public abstract class BaseMeshEffect
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Methods

	// RVA: 0x1A3E1A0
	protected Graphic get_graphic() { }

	// RVA: 0x1A3E298
	protected override void OnEnable() { }

	// RVA: 0x1A3E360
	protected override void OnDisable() { }

	// RVA: 0x1A3E448
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A3E530
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1
	public abstract void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x1A3E6AC
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

	// RVA: 0x1A3E6B4
	protected void .ctor() { }

	// RVA: 0x1A3E704
	public override void ModifyMesh(VertexHelper vh) { }

}

// Namespace: UnityEngine.UI
public class PositionAsUV1
{
	// Methods

	// RVA: 0x1A3EC28
	protected void .ctor() { }

	// RVA: 0x1A3EC30
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

	// RVA: 0x1A3E6DC
	protected void .ctor() { }

	// RVA: 0x1A3ED24
	public Color get_effectColor() { }

	// RVA: 0x1A3ED30
	public void set_effectColor(Color value) { }

	// RVA: 0x1A3EE1C
	public Vector2 get_effectDistance() { }

	// RVA: 0x1A3EE24
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x1A3EF48
	public bool get_useGraphicAlpha() { }

	// RVA: 0x1A3EF50
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x1A3E984
	protected void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1A3F014
	protected void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1A3F01C
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

	// RVA: 0x26AD93C
	public void Add(T item) { }

	// RVA: 0x26AD93C
	public void Add(T item, bool isActive) { }

	// RVA: 0x26AD93C
	public bool AddUnique(T item, bool isActive) { }

	// RVA: 0x26AD93C
	public bool EnableItem(T item) { }

	// RVA: 0x26AD93C
	public bool DisableItem(T item) { }

	// RVA: 0x26AD93C
	public bool Remove(T item) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool Contains(T item) { }

	// RVA: 0x3526850
	public void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35254D0
	public int get_Capacity() { }

	// RVA: 0x35251DC
	public bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public int IndexOf(T item) { }

	// RVA: 0x26AD93C
	public void Insert(int index, T item) { }

	// RVA: 0x3526518
	public void RemoveAt(int index) { }

	// RVA: 0x3526588
	private void Swap(int index1, int index2) { }

	// RVA: 0x26AD93C
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, T value) { }

	// RVA: 0x35267E8
	public void RemoveAll(System.Predicate<T> match) { }

	// RVA: 0x35267E8
	public void Sort(System.Comparison<T> sortLayoutFunction) { }

	// RVA: 0x35263A0
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

	// RVA: 0x1A3F398
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

	// RVA: 0x1A3F190
	public Color get_startColor() { }

	// RVA: 0x1A3F19C
	public void set_startColor(Color value) { }

	// RVA: 0x1A3F1A8
	public Color get_targetColor() { }

	// RVA: 0x1A3F1B4
	public void set_targetColor(Color value) { }

	// RVA: 0x1A3F1C0
	public ColorTweenMode get_tweenMode() { }

	// RVA: 0x1A3F1C8
	public void set_tweenMode(ColorTweenMode value) { }

	// RVA: 0x1A3F1D0
	public float get_duration() { }

	// RVA: 0x1A3F1D8
	public void set_duration(float value) { }

	// RVA: 0x1A3F1E0
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1A3F1E8
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1A3F1F0
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1A3F2C0
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback) { }

	// RVA: 0x1A3F3EC
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1A3F3F4
	public float GetDuration() { }

	// RVA: 0x1A3F2B0
	public bool ValidTarget() { }

}

// Namespace: 
public class FloatTweenCallback
{
	// Methods

	// RVA: 0x1A3F5BC
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

	// RVA: 0x1A3F3FC
	public float get_startValue() { }

	// RVA: 0x1A3F404
	public void set_startValue(float value) { }

	// RVA: 0x1A3F40C
	public float get_targetValue() { }

	// RVA: 0x1A3F414
	public void set_targetValue(float value) { }

	// RVA: 0x1A3F41C
	public float get_duration() { }

	// RVA: 0x1A3F424
	public void set_duration(float value) { }

	// RVA: 0x1A3F42C
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1A3F434
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1A3F43C
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1A3F4E4
	public void AddOnChangedCallback(UnityEngine.Events.UnityAction<System.Single> callback) { }

	// RVA: 0x1A3F610
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1A3F618
	public float GetDuration() { }

	// RVA: 0x1A3F4D4
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

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x3525804
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T0>
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	// RVA: 0x26AD93C
	private static IEnumerator Start(T tweenInfo) { }

	// RVA: 0x35267E8
	public void Init(MonoBehaviour coroutineContainer) { }

	// RVA: 0x26AD93C
	public void StartTween(T info) { }

	// RVA: 0x35263A0
	public void StopTween() { }

	// RVA: 0x35263A0
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

	// RVA: 0x1A424BC
	public int get_pointerId() { }

	// RVA: 0x1A424C4
	private void set_pointerId(int value) { }

	// RVA: 0x1A424CC
	public string get_pointerType() { }

	// RVA: 0x1A424D4
	private void set_pointerType(string value) { }

	// RVA: 0x1A424DC
	public bool get_isPrimary() { }

	// RVA: 0x1A424E4
	private void set_isPrimary(bool value) { }

	// RVA: 0x1A424EC
	public int get_button() { }

	// RVA: 0x1A424F4
	private void set_button(int value) { }

	// RVA: 0x1A424FC
	public int get_pressedButtons() { }

	// RVA: 0x1A42504
	private void set_pressedButtons(int value) { }

	// RVA: 0x1A4250C
	public Vector3 get_position() { }

	// RVA: 0x1A42518
	private void set_position(Vector3 value) { }

	// RVA: 0x1A42524
	public Vector3 get_localPosition() { }

	// RVA: 0x1A42530
	private void set_localPosition(Vector3 value) { }

	// RVA: 0x1A4253C
	public Vector3 get_deltaPosition() { }

	// RVA: 0x1A42548
	private void set_deltaPosition(Vector3 value) { }

	// RVA: 0x1A42554
	public float get_deltaTime() { }

	// RVA: 0x1A4255C
	private void set_deltaTime(float value) { }

	// RVA: 0x1A42564
	public int get_clickCount() { }

	// RVA: 0x1A4256C
	private void set_clickCount(int value) { }

	// RVA: 0x1A42574
	public float get_pressure() { }

	// RVA: 0x1A4257C
	private void set_pressure(float value) { }

	// RVA: 0x1A42584
	public float get_tangentialPressure() { }

	// RVA: 0x1A4258C
	private void set_tangentialPressure(float value) { }

	// RVA: 0x1A42594
	public float get_altitudeAngle() { }

	// RVA: 0x1A4259C
	private void set_altitudeAngle(float value) { }

	// RVA: 0x1A425A4
	public float get_azimuthAngle() { }

	// RVA: 0x1A425AC
	private void set_azimuthAngle(float value) { }

	// RVA: 0x1A425B4
	public float get_twist() { }

	// RVA: 0x1A425BC
	private void set_twist(float value) { }

	// RVA: 0x1A425C4
	public Vector2 get_tilt() { }

	// RVA: 0x1A425CC
	private void set_tilt(Vector2 value) { }

	// RVA: 0x1A425D4
	public PenStatus get_penStatus() { }

	// RVA: 0x1A425DC
	private void set_penStatus(PenStatus value) { }

	// RVA: 0x1A425E4
	public Vector2 get_radius() { }

	// RVA: 0x1A425EC
	private void set_radius(Vector2 value) { }

	// RVA: 0x1A425F4
	public Vector2 get_radiusVariance() { }

	// RVA: 0x1A425FC
	private void set_radiusVariance(Vector2 value) { }

	// RVA: 0x1A42604
	public EventModifiers get_modifiers() { }

	// RVA: 0x1A4260C
	private void set_modifiers(EventModifiers value) { }

	// RVA: 0x1A42614
	public bool get_shiftKey() { }

	// RVA: 0x1A42620
	public bool get_ctrlKey() { }

	// RVA: 0x1A4262C
	public bool get_commandKey() { }

	// RVA: 0x1A42638
	public bool get_altKey() { }

	// RVA: 0x1A42644
	public bool get_actionKey() { }

	// RVA: 0x1A41EA8
	public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x1A423E4
	public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) { }

	// RVA: 0x1A424AC
	public void .ctor() { }

	// RVA: 0x1A42710
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

	// RVA: 0x1A3F620
	public IPanel get_panel() { }

	// RVA: 0x1A3F628
	public void set_panel(IPanel value) { }

	// RVA: 0x1A3FA64
	private GameObject get_selectableGameObject() { }

	// RVA: 0x1A3FA7C
	private EventSystem get_eventSystem() { }

	// RVA: 0x1A3FB9C
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x1A3FC90
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x1A3FCCC
	protected override void OnEnable() { }

	// RVA: 0x1A3FCD4
	protected override void OnDisable() { }

	// RVA: 0x1A3F8A8
	private void RegisterCallbacks() { }

	// RVA: 0x1A3F6EC
	private void UnregisterCallbacks() { }

	// RVA: 0x1A3FCDC
	private void OnPanelDestroyed() { }

	// RVA: 0x1A3FD4C
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x1A3FF6C
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x1A3FF70
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1A3FFF0
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1A40004
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x1A40394
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A405B0
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A408B8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1A40BFC
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1A40C60
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A40C88
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A41084
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1A412AC
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A414F4
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A4032C
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x1A4170C
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x1A41730
	internal void Update() { }

	// RVA: 0x1A417C0
	private void LateUpdate() { }

	// RVA: 0x1A40EB0
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x1A417C8
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x1A4185C
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x1A41CEC
	private void SendTabEvent(Event e, Direction direction, Focusable target) { }

	// RVA: 0x1A418D4
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x1A41AE0
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x1A401B0
	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType) { }

	// RVA: 0x1A423FC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PanelRaycaster
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x28

	// Methods

	// RVA: 0x1A42724
	public IPanel get_panel() { }

	// RVA: 0x1A4272C
	public void set_panel(IPanel value) { }

	// RVA: 0x1A42968
	private void RegisterCallbacks() { }

	// RVA: 0x1A428C8
	private void UnregisterCallbacks() { }

	// RVA: 0x1A42A08
	private void OnPanelDestroyed() { }

	// RVA: 0x1A42A10
	private GameObject get_selectableGameObject() { }

	// RVA: 0x1A42A28
	public override int get_sortOrderPriority() { }

	// RVA: 0x1A42AD0
	public override int get_renderOrderPriority() { }

	// RVA: 0x1A42B70
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

	// RVA: 0x1A4303C
	public override Camera get_eventCamera() { }

	// RVA: 0x1A43044
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class AxisEventData
{
	// Fields
	private Vector2 <moveVector>k__BackingField; // 0x20
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Methods

	// RVA: 0x1A43054
	public Vector2 get_moveVector() { }

	// RVA: 0x1A4305C
	public void set_moveVector(Vector2 value) { }

	// RVA: 0x1A43064
	public MoveDirection get_moveDir() { }

	// RVA: 0x1A4306C
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x1A43074
	public void .ctor(EventSystem eventSystem) { }

}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData
{
	// Fields
	protected bool m_Used; // 0x10

	// Methods

	// RVA: 0x1A43120
	public virtual void Reset() { }

	// RVA: 0x1A43128
	public virtual void Use() { }

	// RVA: 0x1A43134
	public virtual bool get_used() { }

	// RVA: 0x1A4313C
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseEventData
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Methods

	// RVA: 0x1A430EC
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1A43144
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1A43164
	public GameObject get_selectedObject() { }

	// RVA: 0x1A43184
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

	// RVA: 0x1A4342C
	public GameObject get_pointerEnter() { }

	// RVA: 0x1A43434
	public void set_pointerEnter(GameObject value) { }

	// RVA: 0x1A4343C
	public GameObject get_lastPress() { }

	// RVA: 0x1A43444
	private void set_lastPress(GameObject value) { }

	// RVA: 0x1A4344C
	public GameObject get_rawPointerPress() { }

	// RVA: 0x1A43454
	public void set_rawPointerPress(GameObject value) { }

	// RVA: 0x1A4345C
	public GameObject get_pointerDrag() { }

	// RVA: 0x1A43464
	public void set_pointerDrag(GameObject value) { }

	// RVA: 0x1A4346C
	public GameObject get_pointerClick() { }

	// RVA: 0x1A43474
	public void set_pointerClick(GameObject value) { }

	// RVA: 0x1A4347C
	public RaycastResult get_pointerCurrentRaycast() { }

	// RVA: 0x1A43498
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	// RVA: 0x1A434C8
	public RaycastResult get_pointerPressRaycast() { }

	// RVA: 0x1A434E4
	public void set_pointerPressRaycast(RaycastResult value) { }

	// RVA: 0x1A43514
	public bool get_eligibleForClick() { }

	// RVA: 0x1A4351C
	public void set_eligibleForClick(bool value) { }

	// RVA: 0x1A43524
	public int get_displayIndex() { }

	// RVA: 0x1A4352C
	public void set_displayIndex(int value) { }

	// RVA: 0x1A43534
	public int get_pointerId() { }

	// RVA: 0x1A4353C
	public void set_pointerId(int value) { }

	// RVA: 0x1A43544
	public Vector2 get_position() { }

	// RVA: 0x1A43550
	public void set_position(Vector2 value) { }

	// RVA: 0x1A4355C
	public Vector2 get_delta() { }

	// RVA: 0x1A43568
	public void set_delta(Vector2 value) { }

	// RVA: 0x1A43574
	public Vector2 get_pressPosition() { }

	// RVA: 0x1A43580
	public void set_pressPosition(Vector2 value) { }

	// RVA: 0x1A4358C
	public Vector3 get_worldPosition() { }

	// RVA: 0x1A4359C
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x1A435AC
	public Vector3 get_worldNormal() { }

	// RVA: 0x1A435BC
	public void set_worldNormal(Vector3 value) { }

	// RVA: 0x1A435CC
	public float get_clickTime() { }

	// RVA: 0x1A435D4
	public void set_clickTime(float value) { }

	// RVA: 0x1A435DC
	public int get_clickCount() { }

	// RVA: 0x1A435E4
	public void set_clickCount(int value) { }

	// RVA: 0x1A435EC
	public Vector2 get_scrollDelta() { }

	// RVA: 0x1A435F8
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x1A43604
	public bool get_useDragThreshold() { }

	// RVA: 0x1A4360C
	public void set_useDragThreshold(bool value) { }

	// RVA: 0x1A43614
	public bool get_dragging() { }

	// RVA: 0x1A4361C
	public void set_dragging(bool value) { }

	// RVA: 0x1A43624
	public InputButton get_button() { }

	// RVA: 0x1A4362C
	public void set_button(InputButton value) { }

	// RVA: 0x1A43634
	public float get_pressure() { }

	// RVA: 0x1A4363C
	public void set_pressure(float value) { }

	// RVA: 0x1A43644
	public float get_tangentialPressure() { }

	// RVA: 0x1A4364C
	public void set_tangentialPressure(float value) { }

	// RVA: 0x1A43654
	public float get_altitudeAngle() { }

	// RVA: 0x1A4365C
	public void set_altitudeAngle(float value) { }

	// RVA: 0x1A43664
	public float get_azimuthAngle() { }

	// RVA: 0x1A4366C
	public void set_azimuthAngle(float value) { }

	// RVA: 0x1A43674
	public float get_twist() { }

	// RVA: 0x1A4367C
	public void set_twist(float value) { }

	// RVA: 0x1A43684
	public Vector2 get_tilt() { }

	// RVA: 0x1A43690
	public void set_tilt(Vector2 value) { }

	// RVA: 0x1A4369C
	public PenStatus get_penStatus() { }

	// RVA: 0x1A436A4
	public void set_penStatus(PenStatus value) { }

	// RVA: 0x1A436AC
	public Vector2 get_radius() { }

	// RVA: 0x1A436B8
	public void set_radius(Vector2 value) { }

	// RVA: 0x1A436C4
	public Vector2 get_radiusVariance() { }

	// RVA: 0x1A436D0
	public void set_radiusVariance(Vector2 value) { }

	// RVA: 0x1A436DC
	public bool get_fullyExited() { }

	// RVA: 0x1A436E4
	public void set_fullyExited(bool value) { }

	// RVA: 0x1A436EC
	public bool get_reentered() { }

	// RVA: 0x1A436F4
	public void set_reentered(bool value) { }

	// RVA: 0x1A436FC
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1A4383C
	public bool IsPointerMoving() { }

	// RVA: 0x1A4385C
	public bool IsScrolling() { }

	// RVA: 0x1A4387C
	public Camera get_enterEventCamera() { }

	// RVA: 0x1A43940
	public Camera get_pressEventCamera() { }

	// RVA: 0x1A43A04
	public GameObject get_pointerPress() { }

	// RVA: 0x1A43A0C
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x1A43AE8
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

	// RVA: 0x1A4625C
	public void .ctor() { }

	// RVA: 0x1A46DBC
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

	// RVA: 0x1A4486C
	public static EventSystem get_current() { }

	// RVA: 0x1A44968
	public static void set_current(EventSystem value) { }

	// RVA: 0x1A44B40
	public bool get_sendNavigationEvents() { }

	// RVA: 0x1A44B48
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x1A44B50
	public int get_pixelDragThreshold() { }

	// RVA: 0x1A44B58
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x1A44B60
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1A44B68
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x1A44B70
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x1A44B78
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x1A44B80
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x1A44B88
	public bool get_isFocused() { }

	// RVA: 0x1A44B90
	protected void .ctor() { }

	// RVA: 0x1A44C30
	public void UpdateModules() { }

	// RVA: 0x1A44DA4
	public bool get_alreadySelecting() { }

	// RVA: 0x1A431A4
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x1A44DAC
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x1A3FEAC
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x1A44E58
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x1A45354
	public void RaycastAll(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults) { }

	// RVA: 0x1A455D4
	public bool IsPointerOverGameObject() { }

	// RVA: 0x1A45698
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1A45760
	private bool get_isUIToolkitActiveEventSystem() { }

	// RVA: 0x1A458A0
	private bool get_sendUIToolkitEvents() { }

	// RVA: 0x1A4593C
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	// RVA: 0x1A459D8
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart) { }

	// RVA: 0x1A45BAC
	private void StartTrackingUIToolkitPanels() { }

	// RVA: 0x1A461A4
	private void StopTrackingUIToolkitPanels() { }

	// RVA: 0x1A45EE0
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	// RVA: 0x1A46264
	protected override void Start() { }

	// RVA: 0x1A46274
	protected override void OnEnable() { }

	// RVA: 0x1A463FC
	protected override void OnDisable() { }

	// RVA: 0x1A46560
	private void TickModules() { }

	// RVA: 0x1A46694
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1A466A4
	protected virtual void Update() { }

	// RVA: 0x1A4698C
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x1A46AFC
	public override string ToString() { }

	// RVA: 0x1A46C7C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public class TriggerEvent
{
	// Methods

	// RVA: 0x1A47210
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

	// RVA: 0x1A47264
	public void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class EventTrigger
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates; // 0x20

	// Methods

	// RVA: 0x1A46E4C
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates() { }

	// RVA: 0x1A46F84
	public void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x1A46F8C
	protected void .ctor() { }

	// RVA: 0x1A46EE8
	public System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers() { }

	// RVA: 0x1A46F94
	public void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value) { }

	// RVA: 0x1A46F9C
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x1A47144
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1A47150
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1A4715C
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A47168
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x1A47174
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1A47180
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1A4718C
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1A47198
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1A471A4
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1A471B0
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1A471BC
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1A471C8
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1A471D4
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1A471E0
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A471EC
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A471F8
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1A47204
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

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }

	// RVA: 0x26AD93C
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }

	// RVA: 0x35267E8
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

	// RVA: 0x26AD93C
	public static T ValidateEventData(BaseEventData data) { }

	// RVA: 0x1A47310
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4742C
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47548
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47664
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47780
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4789C
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A479B8
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47AD4
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47BF0
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47D0C
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47E28
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A47F44
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A48060
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A48110
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A481C0
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A48270
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4838C
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A4843C
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x1A484EC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x1A48568
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x1A485E4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x1A48660
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x1A486DC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x1A48758
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x1A487D4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x1A48850
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x1A488CC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler() { }

	// RVA: 0x1A48948
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x1A489C4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler() { }

	// RVA: 0x1A48A40
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler() { }

	// RVA: 0x1A48ABC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x1A48B38
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler() { }

	// RVA: 0x1A48BB4
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x1A48C30
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler() { }

	// RVA: 0x1A48CAC
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler() { }

	// RVA: 0x1A48D28
	public static UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler() { }

	// RVA: 0x1A48DA4
	private static void GetEventChain(GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain) { }

	// RVA: 0x3527DAC
	public static bool Execute(GameObject target, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor) { }

	// RVA: 0x3529628
	public static GameObject ExecuteHierarchy(GameObject root, BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction) { }

	// RVA: 0x35279B0
	private static bool ShouldSendToComponent(Component component) { }

	// RVA: 0x352CF50
	private static void GetEventList(GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results) { }

	// RVA: 0x35279B0
	public static bool CanHandleEvent(GameObject go) { }

	// RVA: 0x35293EC
	public static GameObject GetEventHandler(GameObject root) { }

	// RVA: 0x1A48F8C
	private static void .cctor() { }

}

// Namespace: UnityEngine.EventSystems
public class BaseInput
{
	// Methods

	// RVA: 0x1A49674
	public virtual string get_compositionString() { }

	// RVA: 0x1A4967C
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1A49684
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1A49690
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x1A49698
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A496A0
	public virtual bool get_mousePresent() { }

	// RVA: 0x1A496A8
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x1A496B4
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x1A496C0
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x1A496CC
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x1A496D4
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1A496DC
	public virtual float get_mouseScrollDeltaPerTick() { }

	// RVA: 0x1A496E4
	public virtual bool get_touchSupported() { }

	// RVA: 0x1A496EC
	public virtual int get_touchCount() { }

	// RVA: 0x1A496F4
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x1A49748
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x1A49754
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x1A49760
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

	// RVA: 0x1A49768
	protected internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x1A49770
	protected internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x1A49778
	public BaseInput get_input() { }

	// RVA: 0x1A49A04
	public BaseInput get_inputOverride() { }

	// RVA: 0x1A49A0C
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x1A49A14
	protected EventSystem get_eventSystem() { }

	// RVA: 0x1A49A1C
	protected override void OnEnable() { }

	// RVA: 0x1A49AA0
	protected override void OnDisable() { }

	// RVA: -1
	public abstract void Process() { }

	// RVA: 0x1A49ABC
	protected static RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates) { }

	// RVA: 0x1A49BE4
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x1A49C38
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x1A49C84
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x1A49E7C
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x1A4AB38
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x1A4AC90
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x1A4AD3C
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1A4AD44
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x1A4AD90
	public virtual void DeactivateModule() { }

	// RVA: 0x1A4AD94
	public virtual void ActivateModule() { }

	// RVA: 0x1A4AD98
	public virtual void UpdateModule() { }

	// RVA: 0x1A4AD9C
	public virtual bool IsModuleSupported() { }

	// RVA: 0x1A4ADA4
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x1A4AE50
	public virtual Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	// RVA: 0x1A4AE98
	protected void .ctor() { }

}

// Namespace: 
protected class ButtonState
{
	// Fields
	private InputButton m_Button; // 0x10
	private MouseButtonEventData m_EventData; // 0x18

	// Methods

	// RVA: 0x1A4CB60
	public MouseButtonEventData get_eventData() { }

	// RVA: 0x1A4CB68
	public void set_eventData(MouseButtonEventData value) { }

	// RVA: 0x1A4CB70
	public InputButton get_button() { }

	// RVA: 0x1A4CB78
	public void set_button(InputButton value) { }

	// RVA: 0x1A4CB80
	public void .ctor() { }

}

// Namespace: 
protected class MouseState
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x1A4CB88
	public bool AnyPressesThisFrame() { }

	// RVA: 0x1A4CC74
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x1A4CD68
	public ButtonState GetButtonState(InputButton button) { }

	// RVA: 0x1A4BAB0
	public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x1A4CAD4
	public void .ctor() { }

}

// Namespace: 
public class MouseButtonEventData
{
	// Fields
	public FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x1A4CC64
	public bool PressedThisFrame() { }

	// RVA: 0x1A4CD54
	public bool ReleasedThisFrame() { }

	// RVA: 0x1A4CEE0
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

	// RVA: 0x1A4AF2C
	protected bool GetPointerData(int id, PointerEventData data, bool create) { }

	// RVA: 0x1A4B038
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x1A4B0B4
	protected PointerEventData GetTouchPointerEventData(Touch input, bool pressed, bool released) { }

	// RVA: 0x1A4B494
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x1A4B560
	protected FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x1A4B5E8
	protected virtual MouseState GetMousePointerEventData() { }

	// RVA: 0x1A4B5FC
	protected virtual MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x1A4BAF0
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x1A4BB88
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x1A4BBB8
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x1A4BC00
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x1A4C008
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1A4C120
	protected void ClearSelection() { }

	// RVA: 0x1A4C35C
	public override string ToString() { }

	// RVA: 0x1A4C800
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x1A4C93C
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
	private readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.EventSystems.PointerEventData> m_InputPointerEvents; // 0x90
	private const float doubleClickTime = 0.3;
	private string m_HorizontalAxis; // 0x98
	private string m_VerticalAxis; // 0xA0
	private string m_SubmitButton; // 0xA8
	private string m_CancelButton; // 0xB0
	private float m_InputActionsPerSecond; // 0xB8
	private float m_RepeatDelay; // 0xBC
	private bool m_ForceModuleActive; // 0xC0

	// Methods

	// RVA: 0x1A4CEE8
	protected void .ctor() { }

	// RVA: 0x1A4D01C
	public InputMode get_inputMode() { }

	// RVA: 0x1A4D024
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x1A4D02C
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x1A4D034
	public bool get_forceModuleActive() { }

	// RVA: 0x1A4D03C
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1A4D044
	public float get_inputActionsPerSecond() { }

	// RVA: 0x1A4D04C
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x1A4D054
	public float get_repeatDelay() { }

	// RVA: 0x1A4D05C
	public void set_repeatDelay(float value) { }

	// RVA: 0x1A4D064
	public string get_horizontalAxis() { }

	// RVA: 0x1A4D06C
	public void set_horizontalAxis(string value) { }

	// RVA: 0x1A4D074
	public string get_verticalAxis() { }

	// RVA: 0x1A4D07C
	public void set_verticalAxis(string value) { }

	// RVA: 0x1A4D084
	public string get_submitButton() { }

	// RVA: 0x1A4D08C
	public void set_submitButton(string value) { }

	// RVA: 0x1A4D094
	public string get_cancelButton() { }

	// RVA: 0x1A4D09C
	public void set_cancelButton(string value) { }

	// RVA: 0x1A4D0A4
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x1A4D0AC
	public override void UpdateModule() { }

	// RVA: 0x1A4D114
	private void ReleasePointerDrags() { }

	// RVA: 0x1A4D6C4
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x1A4DBF0
	public override bool ShouldActivateModule() { }

	// RVA: 0x1A4DE4C
	public override void ActivateModule() { }

	// RVA: 0x1A4DF78
	public override void DeactivateModule() { }

	// RVA: 0x1A4DF7C
	public override void Process() { }

	// RVA: 0x1A4E19C
	private bool ProcessTouchEvents() { }

	// RVA: 0x1A4E890
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1A4E620
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x1A4F294
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x1A4E36C
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x1A4E364
	protected void ProcessMouseEvent() { }

	// RVA: 0x1A4F674
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x1A4F3A4
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x1A4E020
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x1A4F67C
	protected void ProcessMousePress(MouseButtonEventData data) { }

	// RVA: 0x1A4FB8C
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

	// RVA: 0x1A4FB94
	protected void .ctor() { }

	// RVA: 0x1A4FB98
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x1A4FBA0
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x1A4FBA8
	public bool get_forceModuleActive() { }

	// RVA: 0x1A4FBB0
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1A4FBB8
	public override void UpdateModule() { }

	// RVA: 0x1A4FD58
	public override bool IsModuleSupported() { }

	// RVA: 0x1A4FD94
	public override bool ShouldActivateModule() { }

	// RVA: 0x1A4FE78
	private bool UseFakeInput() { }

	// RVA: 0x1A4FEA8
	public override void Process() { }

	// RVA: 0x1A4FEF8
	private void FakeTouches() { }

	// RVA: 0x1A50024
	private void ProcessTouchEvents() { }

	// RVA: 0x1A501CC
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1A50B8C
	public override void DeactivateModule() { }

	// RVA: 0x1A50B90
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

	// RVA: 0x1A50ED4
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x1A50FD0
	public static System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters() { }

	// RVA: 0x1A5104C
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x1A51148
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

	// RVA: 0x1A511E4
	public virtual int get_priority() { }

	// RVA: 0x1A511EC
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x1A511F4
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x1A45248
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x1A511FC
	public override string ToString() { }

	// RVA: 0x1A5146C
	protected override void OnEnable() { }

	// RVA: 0x1A514EC
	protected override void OnDisable() { }

	// RVA: 0x1A5156C
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A5157C
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A4304C
	protected void .ctor() { }

}

// Namespace: UnityEngine.EventSystems
public class Physics2DRaycaster
{
	// Methods

	// RVA: 0x1A5158C
	protected void .ctor() { }

	// RVA: 0x1A515F4
	public override void Raycast(PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }

}

// Namespace: 
private class RaycastHitComparer
{
	// Fields
	public static RaycastHitComparer instance; // 0x0

	// Methods

	// RVA: 0x1A51FF4
	public int Compare(RaycastHit x, RaycastHit y) { }

	// RVA: 0x1A52040
	public void .ctor() { }

	// RVA: 0x1A52048
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

	// RVA: 0x1A515C0
	protected void .ctor() { }

	// RVA: 0x1A515F8
	public override Camera get_eventCamera() { }

	// RVA: 0x1A51740
	public virtual int get_depth() { }

	// RVA: 0x1A5182C
	public int get_finalEventMask() { }

	// RVA: 0x1A51914
	public LayerMask get_eventMask() { }

	// RVA: 0x1A5191C
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x1A51924
	public int get_maxRayIntersections() { }

	// RVA: 0x1A5192C
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x1A51934
	protected bool ComputeRayAndDistance(PointerEventData eventData, Ray ray, int eventDisplayIndex, float distanceToClipPlane) { }

	// RVA: 0x1A51C40
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

	// RVA: 0x1A520B4
	public GameObject get_gameObject() { }

	// RVA: 0x1A520BC
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1A520C4
	public bool get_isValid() { }

	// RVA: 0x1A5218C
	public void Clear() { }

	// RVA: 0x1A441F0
	public override string ToString() { }

}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour
{
	// Methods

	// RVA: 0x1A52258
	protected virtual void Awake() { }

	// RVA: 0x1A3FCD0
	protected virtual void OnEnable() { }

	// RVA: 0x1A46270
	protected virtual void Start() { }

	// RVA: 0x1A3FCD8
	protected virtual void OnDisable() { }

	// RVA: 0x1A5225C
	protected virtual void OnDestroy() { }

	// RVA: 0x1A52260
	public virtual bool IsActive() { }

	// RVA: 0x1A52268
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A5226C
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x1A51588
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A52270
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A52274
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x1A51578
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A52278
	public bool IsDestroyed() { }

	// RVA: 0x1A424B4
	protected void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5527
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=8101
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x0
	internal static readonly __StaticArrayInitTypeSize=5527 7C777EEED2359F9E03B1E9BA3FE7218E75A8BA42A33894ABBE8BB2022DDED720; // 0xC
	internal static readonly __StaticArrayInitTypeSize=8101 81E765C381E024A588DEFB93764C144E31932833629564E2FB83336839706A1B; // 0x15A3
}


